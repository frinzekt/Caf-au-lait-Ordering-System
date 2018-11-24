<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.lbl_StatusLogin = New System.Windows.Forms.Label()
        Me.TC_Coffee = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FLP_HotCoffee = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FLP_Tea = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FLP_Cold = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.FLP_Frozen = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.FLP_Snacks = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.FLP_COD = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CoffeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CoffeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CoffeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LB_Name = New System.Windows.Forms.ListBox()
        Me.LB_Price = New System.Windows.Forms.ListBox()
        Me.FLP_Numpad = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.LB_Num = New System.Windows.Forms.ListBox()
        Me.txt_ShowStats = New System.Windows.Forms.TextBox()
        Me.FLP_Link = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_RS = New System.Windows.Forms.Button()
        Me.btn_ClearAll = New System.Windows.Forms.Button()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.btn_TAPay = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_TakeAway = New System.Windows.Forms.Button()
        Me.btn_DineIn = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_subtract = New System.Windows.Forms.Button()
        Me.btn_ClearEntry = New System.Windows.Forms.Button()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AdminTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeveragesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_PK = New System.Windows.Forms.ListBox()
        Me.CoffeeTableAdapter = New Test.ConnectDataSetTableAdapters.CoffeeTableAdapter()
        Me.TableAdapterManager = New Test.ConnectDataSetTableAdapters.TableAdapterManager()
        Me.TC_Coffee.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FLP_HotCoffee.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FLP_Tea.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FLP_Cold.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.FLP_Frozen.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.FLP_Snacks.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.FLP_COD.SuspendLayout()
        CType(Me.CoffeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoffeeBindingNavigator.SuspendLayout()
        CType(Me.CoffeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FLP_Numpad.SuspendLayout()
        Me.FLP_Link.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_StatusLogin
        '
        Me.lbl_StatusLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_StatusLogin.Location = New System.Drawing.Point(0, 680)
        Me.lbl_StatusLogin.Name = "lbl_StatusLogin"
        Me.lbl_StatusLogin.Size = New System.Drawing.Size(330, 15)
        Me.lbl_StatusLogin.TabIndex = 0
        Me.lbl_StatusLogin.Text = "Login As : "
        '
        'TC_Coffee
        '
        Me.TC_Coffee.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TC_Coffee.Controls.Add(Me.TabPage1)
        Me.TC_Coffee.Controls.Add(Me.TabPage2)
        Me.TC_Coffee.Controls.Add(Me.TabPage3)
        Me.TC_Coffee.Controls.Add(Me.TabPage4)
        Me.TC_Coffee.Controls.Add(Me.TabPage5)
        Me.TC_Coffee.Controls.Add(Me.TabPage6)
        Me.TC_Coffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_Coffee.Location = New System.Drawing.Point(12, 183)
        Me.TC_Coffee.Multiline = True
        Me.TC_Coffee.Name = "TC_Coffee"
        Me.TC_Coffee.SelectedIndex = 0
        Me.TC_Coffee.Size = New System.Drawing.Size(657, 481)
        Me.TC_Coffee.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FLP_HotCoffee)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(630, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hot Coffee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FLP_HotCoffee
        '
        Me.FLP_HotCoffee.Controls.Add(Me.FlowLayoutPanel1)
        Me.FLP_HotCoffee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_HotCoffee.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_HotCoffee.Location = New System.Drawing.Point(3, 3)
        Me.FLP_HotCoffee.Name = "FLP_HotCoffee"
        Me.FLP_HotCoffee.Size = New System.Drawing.Size(624, 467)
        Me.FLP_HotCoffee.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FLP_Tea)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(630, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tea"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FLP_Tea
        '
        Me.FLP_Tea.Controls.Add(Me.FlowLayoutPanel3)
        Me.FLP_Tea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Tea.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Tea.Location = New System.Drawing.Point(3, 3)
        Me.FLP_Tea.Name = "FLP_Tea"
        Me.FLP_Tea.Size = New System.Drawing.Size(624, 467)
        Me.FLP_Tea.TabIndex = 1
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel3.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.FLP_Cold)
        Me.TabPage3.Location = New System.Drawing.Point(23, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(630, 473)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cold Drinks"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FLP_Cold
        '
        Me.FLP_Cold.Controls.Add(Me.FlowLayoutPanel4)
        Me.FLP_Cold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Cold.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Cold.Location = New System.Drawing.Point(3, 3)
        Me.FLP_Cold.Name = "FLP_Cold"
        Me.FLP_Cold.Size = New System.Drawing.Size(624, 467)
        Me.FLP_Cold.TabIndex = 1
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel4.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.FLP_Frozen)
        Me.TabPage4.Location = New System.Drawing.Point(23, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(630, 473)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Frozen Drinks"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FLP_Frozen
        '
        Me.FLP_Frozen.Controls.Add(Me.FlowLayoutPanel5)
        Me.FLP_Frozen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Frozen.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Frozen.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Frozen.Name = "FLP_Frozen"
        Me.FLP_Frozen.Size = New System.Drawing.Size(630, 473)
        Me.FLP_Frozen.TabIndex = 1
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel5.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.FLP_Snacks)
        Me.TabPage5.Location = New System.Drawing.Point(23, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(630, 473)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Snacks"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'FLP_Snacks
        '
        Me.FLP_Snacks.Controls.Add(Me.FlowLayoutPanel7)
        Me.FLP_Snacks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Snacks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Snacks.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Snacks.Name = "FLP_Snacks"
        Me.FLP_Snacks.Size = New System.Drawing.Size(630, 473)
        Me.FLP_Snacks.TabIndex = 2
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel7.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.FLP_COD)
        Me.TabPage6.Location = New System.Drawing.Point(23, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(630, 473)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Cofee Of The Day"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'FLP_COD
        '
        Me.FLP_COD.Controls.Add(Me.FlowLayoutPanel6)
        Me.FLP_COD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_COD.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_COD.Location = New System.Drawing.Point(0, 0)
        Me.FLP_COD.Name = "FLP_COD"
        Me.FLP_COD.Size = New System.Drawing.Size(630, 473)
        Me.FLP_COD.TabIndex = 1
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel6.TabIndex = 0
        '
        'CoffeeBindingNavigator
        '
        Me.CoffeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CoffeeBindingNavigator.BindingSource = Me.CoffeeBindingSource
        Me.CoffeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CoffeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CoffeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CoffeeBindingNavigatorSaveItem})
        Me.CoffeeBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.CoffeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CoffeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CoffeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CoffeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CoffeeBindingNavigator.Name = "CoffeeBindingNavigator"
        Me.CoffeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CoffeeBindingNavigator.Size = New System.Drawing.Size(1103, 25)
        Me.CoffeeBindingNavigator.TabIndex = 3
        Me.CoffeeBindingNavigator.Text = "BindingNavigator1"
        Me.CoffeeBindingNavigator.Visible = False
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
        'CoffeeBindingSource
        '
        Me.CoffeeBindingSource.DataMember = "Coffee"
        Me.CoffeeBindingSource.DataSource = Me.ConnectDataSet
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
        'CoffeeBindingNavigatorSaveItem
        '
        Me.CoffeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CoffeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("CoffeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CoffeeBindingNavigatorSaveItem.Name = "CoffeeBindingNavigatorSaveItem"
        Me.CoffeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CoffeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LB_Name
        '
        Me.LB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Name.FormattingEnabled = True
        Me.LB_Name.ItemHeight = 18
        Me.LB_Name.Location = New System.Drawing.Point(61, 6)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Name.Size = New System.Drawing.Size(219, 490)
        Me.LB_Name.TabIndex = 4
        '
        'LB_Price
        '
        Me.LB_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Price.FormattingEnabled = True
        Me.LB_Price.ItemHeight = 18
        Me.LB_Price.Location = New System.Drawing.Point(277, 6)
        Me.LB_Price.Name = "LB_Price"
        Me.LB_Price.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LB_Price.Size = New System.Drawing.Size(102, 490)
        Me.LB_Price.TabIndex = 5
        '
        'FLP_Numpad
        '
        Me.FLP_Numpad.Controls.Add(Me.btn_1)
        Me.FLP_Numpad.Controls.Add(Me.btn_2)
        Me.FLP_Numpad.Controls.Add(Me.btn_3)
        Me.FLP_Numpad.Controls.Add(Me.btn_4)
        Me.FLP_Numpad.Controls.Add(Me.btn_5)
        Me.FLP_Numpad.Controls.Add(Me.btn_6)
        Me.FLP_Numpad.Controls.Add(Me.btn_7)
        Me.FLP_Numpad.Controls.Add(Me.btn_8)
        Me.FLP_Numpad.Controls.Add(Me.btn_9)
        Me.FLP_Numpad.Controls.Add(Me.btn_0)
        Me.FLP_Numpad.Location = New System.Drawing.Point(12, 125)
        Me.FLP_Numpad.Name = "FLP_Numpad"
        Me.FLP_Numpad.Size = New System.Drawing.Size(668, 52)
        Me.FLP_Numpad.TabIndex = 6
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(3, 3)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(60, 41)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(69, 3)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(60, 41)
        Me.btn_2.TabIndex = 1
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(135, 3)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(60, 41)
        Me.btn_3.TabIndex = 2
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(201, 3)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(60, 41)
        Me.btn_4.TabIndex = 3
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(267, 3)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(60, 41)
        Me.btn_5.TabIndex = 4
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(333, 3)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(60, 41)
        Me.btn_6.TabIndex = 5
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(399, 3)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(60, 41)
        Me.btn_7.TabIndex = 6
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(465, 3)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(60, 41)
        Me.btn_8.TabIndex = 7
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(531, 3)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(60, 41)
        Me.btn_9.TabIndex = 8
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(597, 3)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(60, 41)
        Me.btn_0.TabIndex = 9
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'LB_Num
        '
        Me.LB_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Num.FormattingEnabled = True
        Me.LB_Num.ItemHeight = 18
        Me.LB_Num.Location = New System.Drawing.Point(8, 6)
        Me.LB_Num.Name = "LB_Num"
        Me.LB_Num.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LB_Num.Size = New System.Drawing.Size(54, 490)
        Me.LB_Num.TabIndex = 7
        '
        'txt_ShowStats
        '
        Me.txt_ShowStats.Location = New System.Drawing.Point(18, 28)
        Me.txt_ShowStats.Multiline = True
        Me.txt_ShowStats.Name = "txt_ShowStats"
        Me.txt_ShowStats.Size = New System.Drawing.Size(144, 86)
        Me.txt_ShowStats.TabIndex = 10
        Me.txt_ShowStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FLP_Link
        '
        Me.FLP_Link.Controls.Add(Me.btn_RS)
        Me.FLP_Link.Controls.Add(Me.btn_ClearAll)
        Me.FLP_Link.Controls.Add(Me.btn_Pay)
        Me.FLP_Link.Controls.Add(Me.btn_TAPay)
        Me.FLP_Link.Location = New System.Drawing.Point(675, 610)
        Me.FLP_Link.Name = "FLP_Link"
        Me.FLP_Link.Size = New System.Drawing.Size(416, 73)
        Me.FLP_Link.TabIndex = 11
        Me.FLP_Link.TabStop = True
        '
        'btn_RS
        '
        Me.btn_RS.Location = New System.Drawing.Point(3, 3)
        Me.btn_RS.Name = "btn_RS"
        Me.btn_RS.Size = New System.Drawing.Size(97, 65)
        Me.btn_RS.TabIndex = 3
        Me.btn_RS.Text = "Remove Selected"
        Me.btn_RS.UseVisualStyleBackColor = True
        '
        'btn_ClearAll
        '
        Me.btn_ClearAll.Location = New System.Drawing.Point(106, 3)
        Me.btn_ClearAll.Name = "btn_ClearAll"
        Me.btn_ClearAll.Size = New System.Drawing.Size(97, 65)
        Me.btn_ClearAll.TabIndex = 0
        Me.btn_ClearAll.Text = "CLEAR ALL"
        Me.btn_ClearAll.UseVisualStyleBackColor = True
        '
        'btn_Pay
        '
        Me.btn_Pay.Location = New System.Drawing.Point(209, 3)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(97, 65)
        Me.btn_Pay.TabIndex = 2
        Me.btn_Pay.Text = "Dine In   Payment"
        Me.btn_Pay.UseVisualStyleBackColor = True
        '
        'btn_TAPay
        '
        Me.btn_TAPay.Location = New System.Drawing.Point(312, 3)
        Me.btn_TAPay.Name = "btn_TAPay"
        Me.btn_TAPay.Size = New System.Drawing.Size(94, 65)
        Me.btn_TAPay.TabIndex = 4
        Me.btn_TAPay.Text = "Take Away Payment"
        Me.btn_TAPay.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_TakeAway)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_DineIn)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_add)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_subtract)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_ClearEntry)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(181, 24)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(499, 90)
        Me.FlowLayoutPanel2.TabIndex = 12
        '
        'btn_TakeAway
        '
        Me.btn_TakeAway.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_TakeAway.Enabled = False
        Me.btn_TakeAway.Location = New System.Drawing.Point(3, 3)
        Me.btn_TakeAway.Name = "btn_TakeAway"
        Me.btn_TakeAway.Size = New System.Drawing.Size(86, 76)
        Me.btn_TakeAway.TabIndex = 0
        Me.btn_TakeAway.Text = "Take Away"
        Me.btn_TakeAway.UseVisualStyleBackColor = False
        '
        'btn_DineIn
        '
        Me.btn_DineIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_DineIn.Enabled = False
        Me.btn_DineIn.Location = New System.Drawing.Point(95, 3)
        Me.btn_DineIn.Name = "btn_DineIn"
        Me.btn_DineIn.Size = New System.Drawing.Size(86, 76)
        Me.btn_DineIn.TabIndex = 1
        Me.btn_DineIn.Text = "Dine In"
        Me.btn_DineIn.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_add.Enabled = False
        Me.btn_add.Location = New System.Drawing.Point(187, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(86, 76)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_subtract
        '
        Me.btn_subtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_subtract.Enabled = False
        Me.btn_subtract.Location = New System.Drawing.Point(279, 3)
        Me.btn_subtract.Name = "btn_subtract"
        Me.btn_subtract.Size = New System.Drawing.Size(86, 76)
        Me.btn_subtract.TabIndex = 3
        Me.btn_subtract.Text = "-"
        Me.btn_subtract.UseVisualStyleBackColor = False
        '
        'btn_ClearEntry
        '
        Me.btn_ClearEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_ClearEntry.Location = New System.Drawing.Point(371, 3)
        Me.btn_ClearEntry.Name = "btn_ClearEntry"
        Me.btn_ClearEntry.Size = New System.Drawing.Size(101, 76)
        Me.btn_ClearEntry.TabIndex = 4
        Me.btn_ClearEntry.Text = "Clear Entry"
        Me.btn_ClearEntry.UseVisualStyleBackColor = False
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lbl_Total.Location = New System.Drawing.Point(878, 558)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(197, 37)
        Me.lbl_Total.TabIndex = 13
        Me.lbl_Total.Text = "Total : $0.00"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(719, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(770, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(986, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Price"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminTaskToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1103, 24)
        Me.MenuStrip.TabIndex = 17
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AdminTaskToolStripMenuItem
        '
        Me.AdminTaskToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeveragesToolStripMenuItem, Me.AddEditEmployeesToolStripMenuItem, Me.CheckSalesToolStripMenuItem})
        Me.AdminTaskToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTaskToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AdminTaskToolStripMenuItem.Name = "AdminTaskToolStripMenuItem"
        Me.AdminTaskToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AdminTaskToolStripMenuItem.Text = "Admin Tasks"
        '
        'BeveragesToolStripMenuItem
        '
        Me.BeveragesToolStripMenuItem.Name = "BeveragesToolStripMenuItem"
        Me.BeveragesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BeveragesToolStripMenuItem.Text = "Add/Edit Coffee"
        '
        'AddEditEmployeesToolStripMenuItem
        '
        Me.AddEditEmployeesToolStripMenuItem.Name = "AddEditEmployeesToolStripMenuItem"
        Me.AddEditEmployeesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AddEditEmployeesToolStripMenuItem.Text = "Add/Edit Employees"
        '
        'CheckSalesToolStripMenuItem
        '
        Me.CheckSalesToolStripMenuItem.Name = "CheckSalesToolStripMenuItem"
        Me.CheckSalesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CheckSalesToolStripMenuItem.Text = "Check Sales"
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(331, 674)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(74, 25)
        Me.btn_logout.TabIndex = 18
        Me.btn_logout.Text = "Log Out"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_Num)
        Me.GroupBox1.Controls.Add(Me.LB_Price)
        Me.GroupBox1.Controls.Add(Me.LB_Name)
        Me.GroupBox1.Location = New System.Drawing.Point(701, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 507)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'LB_PK
        '
        Me.LB_PK.FormattingEnabled = True
        Me.LB_PK.Location = New System.Drawing.Point(687, 483)
        Me.LB_PK.Name = "LB_PK"
        Me.LB_PK.Size = New System.Drawing.Size(185, 121)
        Me.LB_PK.TabIndex = 20
        Me.LB_PK.Visible = False
        '
        'CoffeeTableAdapter
        '
        Me.CoffeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoffeeTableAdapter = Me.CoffeeTableAdapter
        Me.TableAdapterManager.Order_ProfitTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Test.ConnectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 695)
        Me.Controls.Add(Me.LB_PK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_StatusLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.FLP_Link)
        Me.Controls.Add(Me.txt_ShowStats)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FLP_Numpad)
        Me.Controls.Add(Me.CoffeeBindingNavigator)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.TC_Coffee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cafe Au Lait"
        Me.TC_Coffee.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FLP_HotCoffee.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.FLP_Tea.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.FLP_Cold.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.FLP_Frozen.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.FLP_Snacks.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.FLP_COD.ResumeLayout(False)
        CType(Me.CoffeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoffeeBindingNavigator.ResumeLayout(False)
        Me.CoffeeBindingNavigator.PerformLayout()
        CType(Me.CoffeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FLP_Numpad.ResumeLayout(False)
        Me.FLP_Link.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_StatusLogin As Label
    Friend WithEvents TC_Coffee As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FLP_HotCoffee As FlowLayoutPanel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ConnectDataSet As ConnectDataSet
    Friend WithEvents CoffeeBindingSource As BindingSource
    Friend WithEvents CoffeeTableAdapter As ConnectDataSetTableAdapters.CoffeeTableAdapter
    Friend WithEvents TableAdapterManager As ConnectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CoffeeBindingNavigator As BindingNavigator
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
    Friend WithEvents CoffeeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FLP_Tea As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FLP_Cold As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FLP_Frozen As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FLP_COD As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents FLP_Snacks As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents LB_Name As ListBox
    Friend WithEvents LB_Price As ListBox
    Friend WithEvents FLP_Numpad As FlowLayoutPanel
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents LB_Num As ListBox
    Friend WithEvents txt_ShowStats As TextBox
    Friend WithEvents FLP_Link As FlowLayoutPanel
    Friend WithEvents btn_ClearAll As Button
    Friend WithEvents btn_Pay As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btn_TakeAway As Button
    Friend WithEvents btn_DineIn As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_subtract As Button
    Friend WithEvents btn_ClearEntry As Button
    Friend WithEvents lbl_Total As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_RS As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents AdminTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_logout As Button
    Friend WithEvents BeveragesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEditEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_TAPay As Button
    Friend WithEvents LB_PK As ListBox
    Friend WithEvents CheckSalesToolStripMenuItem As ToolStripMenuItem
End Class
