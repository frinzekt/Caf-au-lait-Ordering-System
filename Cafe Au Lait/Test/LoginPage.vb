Public Class LoginPage
    Private Pin As String = ""
    Private UserInfo As DataTable
    Public UserName As String

    Public Shared Status As String
    Public Shared IsAdmin As Boolean



    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserBindingNavigatorSaveItem.Click
        'Hidden Database Control
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConnectDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConnectDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.ConnectDataSet.User)

    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        'Authenticates USer
        Pin = Val(txt_PIN.Text)
        UserInfo = Me.UserTableAdapter.SQL_LoginFetch(Pin) 'Fetch a data with Pin equal to ID


        If (UserInfo.Rows.Count) Then  'Counts the Number of Row. TRUE or False Value Only. Primary Key exists or not
            UserName = Me.UserTableAdapter.SQL_LoginFetch(Pin).Rows(0).Item("Fname") + " " + Me.UserTableAdapter.SQL_LoginFetch(Pin).Rows(0).Item("LName")
            Status = UserName
            IsAdmin = Me.UserTableAdapter.SQL_LoginFetch(Pin).Rows(0).Item("IsAdmin")

            MainPage.Show()
            Me.Hide()

            txt_PIN.Text = ""
            Pin = ""

            MainPage.lbl_StatusLogin.Text = "Login As: " + Status
            Payment.Cashier = Status
            MainPage.MenuStrip.Visible = IsAdmin

        Else      'Failed Login
            MsgBox("Login Failed")
            Pin = ""
            txt_PIN.Text = ""
            txt_PIN.Focus()
        End If
    End Sub

    Private Sub NumpadClick(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        'Controls the Numpad
        Pin += ActiveControl.Text
        txt_PIN.Text = Pin
    End Sub

    Private Sub btn_AC_Click(sender As Object, e As EventArgs) Handles btn_AC.Click
        'Removes Last Character in the TXTBOX
        If (Pin.Length() > 0) Then
            Pin = Pin.Remove(Pin.Length() - 1, 1)
            txt_PIN.Text = Pin
        End If
    End Sub
End Class
