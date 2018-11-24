Public Class Payment

    Public Shared Tendered As String
    Public Shared Change As Double
    Public Shared Total As Double
    Public Shared Original_Total As Double
    Public Shared Cashier As String

    Private IsDecimalAround As String                        'Functionalities for Decimal Reader
    Private DecimalCounter As Integer                        'Functionalities for Decimal Reader
    Private IsEftpos As Boolean                              'Functionalities for EFtpos Cashout
    Private IsTransactionFinished As Boolean = False         'Functionalities for Detection of New Order or Modifier

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConnectDataSet1.Order_Profit' table. You can move, or remove it, as needed.
        Me.Order_ProfitTableAdapter.Fill(Me.ConnectDataSet1.Order_Profit)
        'TODO: This line of code loads data into the 'ConnectDataSet1.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.ConnectDataSet1.Order)

    End Sub

    Private Sub Record_List(CoffeeID As Integer, Amount As Integer)
        'Records and Updates the Database
        Me.OrderTableAdapter.InsertOrderList(CoffeeID, Amount, Date.Today)
        Me.Order_ProfitTableAdapter.ProfitInsert(Total)
    End Sub
    Private Sub RemoveSelected(Index As Integer, ListBox As ListBox)
        ' Remove a Selected Index in a Listbox
        ListBox.Items.RemoveAt(Index)
    End Sub
    Private Sub btn_Modify_Click(sender As Object, e As EventArgs) Handles btn_Modify.Click
        'Goes Back to Mainpage to change Order OR New Order
        If IsTransactionFinished = True Then
            EnableButtons()

        ElseIf MainPage.IsTakeAway = True Then

            MainPage.LB_Name.Items.RemoveAt(MainPage.LB_Name.Items.Count - 1)
            MainPage.LB_Num.Items.RemoveAt(MainPage.LB_Num.Items.Count - 1)
            MainPage.LB_Price.Items.RemoveAt(MainPage.LB_Price.Items.Count - 1)
            MainPage.lbl_Total.Text = "Total: " + FormatCurrency(Original_Total)
            MainPage.IsTakeAway = 0

        End If

        Me.Hide()
        MainPage.Show()


    End Sub

    Private Sub Numpad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click, btn_Dec.Click
        'When Customer Pays using combination of Bills
        If (ActiveControl.Text <> ".") And DecimalCounter <= 1 Then
            Tendered = Tendered + ActiveControl.Text

            If IsDecimalAround = 1 Then
                DecimalCounter += 1
            End If

        ElseIf IsDecimalAround = 0 Then
            IsDecimalAround = 1
            If Tendered = "" Then
                Tendered += "0"
            End If
            Tendered = Tendered + "."

        End If

        txt_Tendered.Text = Tendered


    End Sub

    Private Sub Exact_Tendered(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_e50.Click, btn_e20.Click, btn_e10.Click, btn_e5.Click, btn_e2.Click, btn_e1.Click
        'Customer Payment of an exact Bill
        Tendered = ActiveControl.Text.Remove(0, 1)
        txt_Tendered.Text = Tendered

        btn_Enter.PerformClick()
    End Sub

    Private Sub btn_exact_Click(sender As Object, e As EventArgs) Handles btn_exact.Click
        'When Customer Pays Exactly 

        Tendered = Val(Total)
        txt_Tendered.Text = Tendered

        btn_Enter.PerformClick()
    End Sub

    Private Sub btn_EFTPOS_Click(sender As Object, e As EventArgs) Handles btn_EFTPOS.Click
        'Cash Out / Credit Card Payment
        If MsgBox("Do you want a cash out?", vbOKCancel) = vbOK Then
            txt_Tendered.Text = ""
            Tendered = ""
            lbl_tendered.Text = "Cash Out:"
            IsEftpos = 1
        Else
            Tendered = Val(Total)
            txt_Tendered.Text = Tendered
            btn_Enter.PerformClick()
        End If


    End Sub

    Private Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        'Confirms the Order
        If (Tendered >= Total) And (IsEftpos = 0) Then
            Change = Val(Tendered) - Total
            txt_Change.Text = FormatCurrency(Change)

            MsgBox("Transaction Complete")

            DisableButtons()

        ElseIf IsEftpos = True Then   'For Eftpos Cashout
            lbl_tendered.Text = "Tendered:"
            lbl_Change.Text = "Cash Out:"
            Change = Val(Tendered)
            txt_Change.Text = FormatCurrency(Change)
            Tendered = FormatCurrency(Val(Total) + Val(Tendered))
            txt_Tendered.Text = Tendered
            IsEftpos = 0

            MsgBox("Transaction Complete")

            DisableButtons()

        Else
            MsgBox("Insufficient Funds")
        End If

        For Counter As Integer = 0 To LB_Name.Items.Count() - (1 + Convert.ToDouble(MainPage.IsTakeAway))
            Record_List(LB_PK.Items(Counter), LB_Num.Items(Counter))
        Next

    End Sub

    Private Sub DisableButtons()
        'Disables all button
        btn_0.Enabled = False
        btn_1.Enabled = False
        btn_2.Enabled = False
        btn_3.Enabled = False
        btn_4.Enabled = False
        btn_5.Enabled = False
        btn_6.Enabled = False
        btn_7.Enabled = False
        btn_8.Enabled = False
        btn_9.Enabled = False


        btn_Dec.Enabled = False
        btn_EFTPOS.Enabled = False
        btn_AC.Enabled = False
        btn_Enter.Enabled = False

        btn_e50.Enabled = False
        btn_e20.Enabled = False
        btn_e10.Enabled = False
        btn_e5.Enabled = False
        btn_e2.Enabled = False
        btn_e1.Enabled = False
        btn_exact.Enabled = False

        IsTransactionFinished = 1
        btn_Modify.Text = "New Order"

        ReceiptsToolStripMenuItem.Enabled = True

    End Sub

    Private Sub EnableButtons()
        'Enables Button and Clears The ListBox
        btn_0.Enabled = True
        btn_1.Enabled = True
        btn_2.Enabled = True
        btn_3.Enabled = True
        btn_4.Enabled = True
        btn_5.Enabled = True
        btn_6.Enabled = True
        btn_7.Enabled = True
        btn_8.Enabled = True
        btn_9.Enabled = True


        btn_Dec.Enabled = True
        btn_EFTPOS.Enabled = True
        btn_AC.Enabled = True
        btn_Enter.Enabled = True

        btn_e50.Enabled = True
        btn_e20.Enabled = True
        btn_e10.Enabled = True
        btn_e5.Enabled = True
        btn_e2.Enabled = True
        btn_e1.Enabled = True
        btn_exact.Enabled = True

        IsTransactionFinished = 0
        btn_Modify.Text = "New Order"

        LB_Name.Items.Clear()
        LB_Num.Items.Clear()
        LB_Price.Items.Clear()
        LB_PK.Items.Clear()

        MainPage.LB_Name.Items.Clear()
        MainPage.LB_Num.Items.Clear()
        MainPage.LB_Price.Items.Clear()
        MainPage.LB_PK.Items.Clear()
        MainPage.Selected_Num = 0

        MainPage.lbl_Total.Text = "Total: " + FormatCurrency(0)

        txt_Tendered.Text = ""
        txt_Change.Text = ""



    End Sub


    Private Sub btn_AC_Click(sender As Object, e As EventArgs) Handles btn_AC.Click
        'Removes the last character of Tendered.Text
        If (Tendered.Length() > 0) Then

            If Tendered(Tendered.Length - 1) = "." Then
                IsDecimalAround = 0

            ElseIf IsDecimalAround = 1 Then
                DecimalCounter -= 1

            End If

            Tendered = Tendered.Remove(Tendered.Length() - 1, 1)
            txt_Tendered.Text = Tendered


        End If
    End Sub

    Private Sub BarristaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarristaToolStripMenuItem.Click
        'Initialize all the Values of BaristaReceipt Before Opening
        BarristaReceipt.lbl_Cashier.Text = "Cashier: " + Cashier
        BarristaReceipt.LB_Name.Items.AddRange(LB_Name.Items)
        BarristaReceipt.LB_Num.Items.AddRange(LB_Num.Items)
        BarristaReceipt.Show()

        If MainPage.IsTakeAway = True Then
            BarristaReceipt.lbl_TakeAway.Visible = True

            BarristaReceipt.LB_Name.Items.RemoveAt(BarristaReceipt.LB_Name.Items.Count - 1)
            BarristaReceipt.LB_Num.Items.RemoveAt(BarristaReceipt.LB_Num.Items.Count - 1)


        Else
            BarristaReceipt.lbl_TakeAway.Visible = False
        End If


    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click

        'Initialize all the Values of CustomerReceipt Before Opening
        CustomerReceipt.lbl_Cashier.Text = "Cashier: " + Cashier
        CustomerReceipt.lbl_Tendered.Text = "Tendered :  " + FormatCurrency(Tendered)
        CustomerReceipt.lbl_Change.Text = "Change:      " + FormatCurrency(Change)
        CustomerReceipt.lbl_Total.Text = "Total:         " + FormatCurrency(Total)
        CustomerReceipt.LB_Name.Items.AddRange(LB_Name.Items)
        CustomerReceipt.LB_Num.Items.AddRange(LB_Num.Items)
        CustomerReceipt.LB_Price.Items.AddRange(LB_Price.Items)
        CustomerReceipt.Show()




    End Sub

    Private Sub OrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConnectDataSet1)

    End Sub


End Class