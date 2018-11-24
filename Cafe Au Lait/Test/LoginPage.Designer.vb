<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Me.UserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConnectDataSet = New Test.ConnectDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txt_PIN = New System.Windows.Forms.TextBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.UserTableAdapter = New Test.ConnectDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New Test.ConnectDataSetTableAdapters.TableAdapterManager()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_AC = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserBindingNavigator.SuspendLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserBindingNavigator
        '
        Me.UserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserBindingNavigator.BindingSource = Me.UserBindingSource
        Me.UserBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserBindingNavigatorSaveItem})
        Me.UserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserBindingNavigator.Name = "UserBindingNavigator"
        Me.UserBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserBindingNavigator.Size = New System.Drawing.Size(1103, 25)
        Me.UserBindingNavigator.TabIndex = 0
        Me.UserBindingNavigator.Text = "BindingNavigator1"
        Me.UserBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.ConnectDataSet
        '
        'ConnectDataSet
        '
        Me.ConnectDataSet.DataSetName = "ConnectDataSet"
        Me.ConnectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UserBindingNavigatorSaveItem
        '
        Me.UserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserBindingNavigatorSaveItem.Name = "UserBindingNavigatorSaveItem"
        Me.UserBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txt_PIN
        '
        Me.txt_PIN.Enabled = False
        Me.txt_PIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PIN.Location = New System.Drawing.Point(268, 125)
        Me.txt_PIN.Name = "txt_PIN"
        Me.txt_PIN.Size = New System.Drawing.Size(512, 44)
        Me.txt_PIN.TabIndex = 1
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_Login.Location = New System.Drawing.Point(327, 297)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(156, 92)
        Me.btn_Login.TabIndex = 2
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoffeeTableAdapter = Nothing
        Me.TableAdapterManager.Order_ProfitTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Test.ConnectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_4)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_5)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_6)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_7)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_8)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_9)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_AC)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_0)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Login)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(279, 209)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(491, 401)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_1.Location = New System.Drawing.Point(3, 3)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(156, 92)
        Me.btn_1.TabIndex = 3
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_2.Location = New System.Drawing.Point(165, 3)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(156, 92)
        Me.btn_2.TabIndex = 4
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_3.Location = New System.Drawing.Point(327, 3)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(156, 92)
        Me.btn_3.TabIndex = 5
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_4.Location = New System.Drawing.Point(3, 101)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(156, 92)
        Me.btn_4.TabIndex = 6
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_5.Location = New System.Drawing.Point(165, 101)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(156, 92)
        Me.btn_5.TabIndex = 7
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_6.Location = New System.Drawing.Point(327, 101)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(156, 92)
        Me.btn_6.TabIndex = 8
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_7.Location = New System.Drawing.Point(3, 199)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(156, 92)
        Me.btn_7.TabIndex = 9
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_8.Location = New System.Drawing.Point(165, 199)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(156, 92)
        Me.btn_8.TabIndex = 10
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_9.Location = New System.Drawing.Point(327, 199)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(156, 92)
        Me.btn_9.TabIndex = 11
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_AC
        '
        Me.btn_AC.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_AC.Location = New System.Drawing.Point(3, 297)
        Me.btn_AC.Name = "btn_AC"
        Me.btn_AC.Size = New System.Drawing.Size(156, 92)
        Me.btn_AC.TabIndex = 12
        Me.btn_AC.Text = "AC"
        Me.btn_AC.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_0.Location = New System.Drawing.Point(165, 297)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(156, 92)
        Me.btn_0.TabIndex = 13
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'lbl_Title
        '
        Me.lbl_Title.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(282, 31)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(480, 52)
        Me.lbl_Title.TabIndex = 34
        Me.lbl_Title.Text = "Cafe Au Lait"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 695)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txt_PIN)
        Me.Controls.Add(Me.UserBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cafe Au Lait Login System"
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserBindingNavigator.ResumeLayout(False)
        Me.UserBindingNavigator.PerformLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectDataSet As ConnectDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As ConnectDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As ConnectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txt_PIN As TextBox
    Friend WithEvents btn_Login As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_AC As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lbl_Title As Label
End Class
