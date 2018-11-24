Public Class CoffeeList


    Private Sub CoffeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CoffeeBindingNavigatorSaveItem.Click
        'Updates Database
        Me.Close()
        Me.Validate()
        Me.CoffeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConnectDataSet)

        'Refreshes The Mainpage
        MainPage.CoffeeTableAdapter.Fill(MainPage.ConnectDataSet.Coffee)
        MainPage.CoffeeTableAdapter.LoadCoffee(MainPage.DS_Hot, "Hot Coffee")
        MainPage.CoffeeTableAdapter.LoadCoffee(MainPage.DS_Tea, "Tea")
        MainPage.CoffeeTableAdapter.LoadCoffee(MainPage.DS_Cold, "Cold Drinks")
        MainPage.CoffeeTableAdapter.LoadCoffee(MainPage.DS_Frozen, "Frozen Drinks")
        MainPage.CoffeeTableAdapter.LoadCoffee(MainPage.DS_Snacks, "Snacks")
        MainPage.CoffeeTableAdapter.LoadCoffee(MainPage.DS_COD, "Coffee Of The Day")

        MainPage.Close()
        MainPage.Show()

        MainPage.lbl_StatusLogin.Text = "Login As: " + LoginPage.Status




    End Sub

    Private Sub CoffeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ConnectDataSet.Coffee' table. You can move, or remove it, as needed.
        Me.CoffeeTableAdapter.Fill(Me.ConnectDataSet.Coffee)

    End Sub
End Class