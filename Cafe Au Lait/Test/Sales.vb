Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConnectDataSet.Total_Profit' table. You can move, or remove it, as needed.
        Me.Total_ProfitTableAdapter.Fill(Me.ConnectDataSet.Total_Profit)
        'TODO: This line of code loads data into the 'ConnectDataSet.Order_Profit' table. You can move, or remove it, as needed.
        Me.Order_ProfitTableAdapter.Fill(Me.ConnectDataSet.Order_Profit)
        'TODO: This line of code loads data into the 'ConnectDataSet.Number_Of_Coffee_Sales_In_a_Specific_Day' table. You can move, or remove it, as needed.
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter.Fill(Me.ConnectDataSet.Number_Of_Coffee_Sales_In_a_Specific_Day)

    End Sub
End Class