
Public Class MainPage
    Public Shared DS_Hot As New ConnectDataSet.CoffeeDataTable           'DataSets to be Used for Data Loading
    Public Shared DS_Tea As New ConnectDataSet.CoffeeDataTable           'DataSets to be Used for Data Loading
    Public Shared DS_Cold As New ConnectDataSet.CoffeeDataTable          'DataSets to be Used for Data Loading
    Public Shared DS_Frozen As New ConnectDataSet.CoffeeDataTable        'DataSets to be Used for Data Loading
    Public Shared DS_Snacks As New ConnectDataSet.CoffeeDataTable        'DataSets to be Used for Data Loading
    Public Shared DS_COD As New ConnectDataSet.CoffeeDataTable           'DataSets to be Used for Data Loading

    Private Coffee_Num_List() As Integer = {}              'Array Version of Listbox
    Private Coffee_Name_List() As String = {}              'Array Version of Listbox
    Private Coffee_Price_List() As Double = {}             'Array Version of Listbox

    Public Shared Selected_Num As Integer = 0          'Current Selected STATS of a Button
    Private Selected_Price As Double                   'Current Selected STATS of a Button
    Private Selected_IsTakeAway As Boolean             'Current Selected STATS of a Button

    Public Shared IsTakeAway As Boolean

    ' Private Coffee_IsTakeAway() As Boolean
    ' Private Coffee_Condiments()() As Integer

    Private SpecificCoffee As ConnectDataSet.CoffeeRow   'Datarow From Dataset

    Public Shared PaymentPage As Payment

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Extracts Data from Database and Loads with Dataset
        Me.CoffeeTableAdapter.Fill(Me.ConnectDataSet.Coffee)
        Me.CoffeeTableAdapter.LoadCoffee(DS_Hot, "Hot Coffee")
        Me.CoffeeTableAdapter.LoadCoffee(DS_Tea, "Tea")
        Me.CoffeeTableAdapter.LoadCoffee(DS_Cold, "Cold Drinks")
        Me.CoffeeTableAdapter.LoadCoffee(DS_Frozen, "Frozen Drinks")
        Me.CoffeeTableAdapter.LoadCoffee(DS_Snacks, "Snacks")
        Me.CoffeeTableAdapter.LoadCoffee(DS_COD, "Coffee Of The Day")

        LoadCoffee() ' Create Buttons

    End Sub

    Private Sub LoadCoffee()
        'Loads All The Button
        CreateButton(DS_Hot, FLP_HotCoffee)
        CreateButton(DS_Tea, FLP_Tea)
        CreateButton(DS_Cold, FLP_Cold)
        CreateButton(DS_Frozen, FLP_Frozen)
        CreateButton(DS_Snacks, FLP_Snacks)
        CreateButton(DS_COD, FLP_COD)

    End Sub

    Private Sub CreateButton(DS_Gen As ConnectDataSet.CoffeeDataTable, FLP_Gen As FlowLayoutPanel)
        'Creates The Button
        Dim btn As New Button

        For i As Integer = 0 To DS_Gen.Count() - 1 'Creates Buttons equal to The Number of Dataset
            btn = New Button()

            With btn 'Generates the Design of The Button
                .Tag = DS_Gen.Rows(i).Item("ID")    'Embeds the Primary Key to Tag of Button
                .Text = DS_Gen.Rows(i).Item("Name") & vbCrLf & FormatCurrency(DS_Gen.Rows(i).Item("Price"))     'Display Text of Button to Price and Name of Coffee
                .Size = New System.Drawing.Size(75, 75)
            End With

            ' Set Button properties or call a method to do so.
            FLP_Gen.Controls.Add(btn)  ' Add Button to the container.
            AddHandler btn.Click, AddressOf Me.Coffee_Click   ' Adds Handler for Button.
        Next

    End Sub




    Private Sub Coffee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Uses Hidden PK in Tag
        AddCoffee(ActiveControl.Tag)
    End Sub

    Private Sub AddCoffee(C_ID As Integer)
        'Extracts the HIDDEN Tag of Buttons Containing the PRIMARY KEY OF COFFEE
        'C_ID is the PK


        Dim IsCoffeeinLB As Boolean = False
        SpecificCoffee = ConnectDataSet.Coffee.FindByID(C_ID)
        'MsgBox(SpecificCoffee("Name") & SpecificCoffee("Price"))

        '
        For Counter As Integer = 0 To LB_Name.Items.Count() - 1
            'If Coffee is already in LB, Add 1 to Num and Recalculate Price
            If SpecificCoffee("Name") = LB_Name.Items(Counter) Then
                Coffee_Num_List(Counter) += 1
                LB_Num.Items(Counter) = Coffee_Num_List(Counter)
                IsCoffeeinLB = True

                Coffee_Price_List(Counter) += SpecificCoffee("Price")
                LB_Price.Items(Counter) = FormatCurrency(Coffee_Price_List(Counter))
                lbl_Total.Text = "Total: " + FormatCurrency(UpdateTotal())

            End If
        Next

        'If Coffee is not yet in the listbox. Find the name of coffee 
        If IsCoffeeinLB = False Then
            'arr = arr.Concat({newItem}).ToArray
            Coffee_Name_List = Coffee_Name_List.Concat({SpecificCoffee("Name")}).ToArray
            LB_Name.Items.Add(SpecificCoffee("Name"))
            LB_PK.Items.Add(C_ID)
            'Coffee_Num_List = Coffee_Name_List.Concat({Selected_Num}).ToArray

            If Selected_Num = 0 Then
                Selected_Num = 1
            End If
            JoinArrayInt(Coffee_Num_List, Selected_Num)
            LB_Num.Items.Add(Selected_Num)

            Selected_Price = Selected_Num * SpecificCoffee("Price")
            LB_Price.Items.Add(FormatCurrency(Selected_Price))
            JoinArrayDouble(Coffee_Price_List, Selected_Price)
            lbl_Total.Text = "Total: " + FormatCurrency(UpdateTotal())


            btn_ClearEntry.PerformClick()

        End If

    End Sub

    Private Sub JoinArrayInt(Arr() As Integer, Join As Integer)
        'Inserting Integer Value to Array
        Dim Arr2() As Integer = {Join}
        Arr = Arr.Concat(Arr2).ToArray
        Coffee_Num_List = Arr

    End Sub

    Private Sub JoinArrayDouble(Arr() As Double, Join As Double)
        'Inserting Double Value to Array
        Dim Arr2() As Double = {Join}
        Arr = Arr.Concat(Arr2).ToArray
        Coffee_Price_List = Arr

    End Sub

    Public Function UpdateTotal()
        'Update the total
        Dim Total As Double
        For Counter As Integer = 0 To Me.LB_Price.Items.Count() - 1
            Total += Me.LB_Price.Items(Counter)
        Next

        Return Total

        ' Array Sum Calculation
        '    Public Function UpdateTotal()
        '   Dim Total As Double
        '   For Counter As Integer = 0 To Coffee_Price_List.Length() - 1
        '       Total += Coffee_Price_List(Counter)
        '   Next
        '
        '   Return Total
    End Function



    Private Sub Numpad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        'Numpad Controlling all the buttons of a numkey and adds the number to txt
        If Selected_Num <> 0 Then
            Selected_Num = Val(Convert.ToString(Selected_Num) + ActiveControl.Text)
        Else
            Selected_Num = Val(ActiveControl.Text)
        End If
        txt_ShowStats.Text = Selected_Num & vbCrLf & If(Selected_IsTakeAway = 1, "Take Out", "Dine In")
        'MsgBox(Selected_Num)

    End Sub

    Private Sub CoffeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Hidden Database Connector
        Me.Validate()
        Me.CoffeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConnectDataSet)

    End Sub

    Private Sub CoffeeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CoffeeBindingNavigatorSaveItem.Click
        'Hidden Database Connector

        Me.Validate()
        Me.CoffeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConnectDataSet)

    End Sub

    Private Sub btn_ClearEntry_click(sender As Object, e As EventArgs) Handles btn_ClearEntry.Click
        'Clear the amount of coffee BEING entered

        Selected_Num = 0
        Selected_IsTakeAway = 0
        txt_ShowStats.Text = ""
    End Sub

    Private Sub btn_ClearAll_Click(sender As Object, e As EventArgs) Handles btn_ClearAll.Click
        'Clears Everything
        LB_Name.Items.Clear()
        LB_Num.Items.Clear()
        LB_Price.Items.Clear()
        LB_PK.Items.Clear()

        Coffee_Num_List = {}
        Coffee_Name_List = {}
        Coffee_Price_List = {}

        lbl_Total.Text = "Total: " + FormatCurrency(UpdateTotal())
    End Sub

    Private Sub btn_RS_Click(sender As Object, e As EventArgs) Handles btn_RS.Click
        'Removes Selected Item From ListBox

        Dim Counter As Integer = 0
        Dim Limit As Integer = LB_Name.SelectedIndices.Count() - 1


        'VERSION 1 MULTI-SELECT REMOVAL
        ' If (Limit >= 0) Then
        '     Dim StartDeleteIndex As Integer = LB_Name.SelectedIndices(0)
        '
        '     For Counter = 0 To Limit
        '         RemoveSelected(StartDeleteIndex, LB_Price)
        '         RemoveSelected(StartDeleteIndex, LB_Num)
        '         RemoveSelected(StartDeleteIndex, LB_Name)
        '     Next
        '
        ' End If

        'VERSION 2 MULTI-SELECT REMOVAL
        'Performs Loop to Select all the Selected Index and Remove Each Item from Each ListBox
        If (Limit >= 0) Then
            Dim StartDeleteIndex As Integer = LB_Name.SelectedIndices(0)

            For Counter = 0 To Limit
                RemoveSelected(LB_Name.SelectedIndices(Limit - Counter), LB_Price)
                RemoveSelected(LB_Name.SelectedIndices(Limit - Counter), LB_Num)
                RemoveSelected(LB_Name.SelectedIndices(Limit - Counter), LB_PK)
                RemoveSelected(LB_Name.SelectedIndices(Limit - Counter), LB_Name)

            Next

        End If
        lbl_Total.Text = "Total: " + FormatCurrency(UpdateTotal())
    End Sub


    Private Sub RemoveSelected(Index As Integer, ListBox As ListBox)
        'Remove Selected Item From ListBox with specified Index
        ListBox.Items.RemoveAt(Index)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        'Log Outs of the Cashier
        LoginPage.Show()
        btn_ClearAll.PerformClick()


        Me.Hide()
    End Sub
    Private Sub BeveragesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeveragesToolStripMenuItem.Click
        'Opens Coffee List Form
        CoffeeList.Show()

    End Sub
    Private Sub AddEditEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditEmployeesToolStripMenuItem.Click
        'Opens Employee Form
        EmployeeList.Show()

    End Sub
    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        'Dine In PAyment and Initialization of Values of Payment Form
        If LB_Name.Items.Count() <> 0 Then
            Payment.LB_Name.Items.Clear()
            Payment.LB_Num.Items.Clear()
            Payment.LB_Price.Items.Clear()

            Payment.LB_Name.Items.AddRange(LB_Name.Items)
            Payment.LB_Num.Items.AddRange(LB_Num.Items)
            Payment.LB_Price.Items.AddRange(LB_Price.Items)
            Payment.LB_PK.Items.AddRange(LB_PK.Items)
            Payment.Show()
            Payment.lbl_Total.Text = lbl_Total.Text
            Payment.Total = UpdateTotal()

            Me.Hide()
        End If



    End Sub
    Private Sub btn_TAPay_Click(sender As Object, e As EventArgs) Handles btn_TAPay.Click
        'Take Away PAyment and Initialization of Values of Payment Form
        If LB_Name.Items.Count() <> 0 Then
            IsTakeAway = 1
            Payment.LB_Name.Items.Clear()
            Payment.LB_Num.Items.Clear()
            Payment.LB_Price.Items.Clear()
            Payment.LB_PK.Items.Clear()

            Payment.Original_Total = UpdateTotal()
            LB_Price.Items.Add(FormatNumber(UpdateTotal() * 0.05, 2))
            LB_Num.Items.Add("=")
            LB_Name.Items.Add("TAKEAWAY FEE")

            Payment.LB_Name.Items.AddRange(LB_Name.Items)
            Payment.LB_Num.Items.AddRange(LB_Num.Items)
            Payment.LB_Price.Items.AddRange(LB_Price.Items)
            Payment.LB_PK.Items.AddRange(LB_PK.Items)

            lbl_Total.Text = "Total: " + FormatCurrency(UpdateTotal())
            Payment.Show()
            Payment.lbl_Total.Text = lbl_Total.Text
            Payment.Total = UpdateTotal()

            Me.Hide()
        End If
    End Sub


    Private Sub CheckSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckSalesToolStripMenuItem.Click
        'Opens The Form of Sales and Refresh the Database
        Sales.Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter.Fill(Sales.ConnectDataSet.Number_Of_Coffee_Sales_In_a_Specific_Day)
        Sales.Show()
    End Sub

    ' Single-Select Remove ListBox
    'Private Sub RemoveSelectedCD(ListBox As ListBox, ListBox2 As ListBox)
    '      Dim Index As Integer = ListBox.SelectedIndex
    '
    '      ListBox2.Items.RemoveAt(Index)
    '      ListBox.Items.RemoveAt(Index)
    '
    '  End Sub



End Class