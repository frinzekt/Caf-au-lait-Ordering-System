Public Class EmployeeList
    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserBindingNavigatorSaveItem.Click
        'Updates The DATABASE
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConnectDataSet)



    End Sub

    Private Sub EmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConnectDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.ConnectDataSet.User)

    End Sub
End Class