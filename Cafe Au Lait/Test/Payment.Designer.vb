<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.btn_Modify = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_Num = New System.Windows.Forms.ListBox()
        Me.LB_Price = New System.Windows.Forms.ListBox()
        Me.LB_Name = New System.Windows.Forms.ListBox()
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
        Me.btn_Dec = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_Enter = New System.Windows.Forms.Button()
        Me.btn_AC = New System.Windows.Forms.Button()
        Me.btn_EFTPOS = New System.Windows.Forms.Button()
        Me.lbl_tendered = New System.Windows.Forms.Label()
        Me.lbl_Change = New System.Windows.Forms.Label()
        Me.txt_Tendered = New System.Windows.Forms.TextBox()
        Me.txt_Change = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_e50 = New System.Windows.Forms.Button()
        Me.btn_e20 = New System.Windows.Forms.Button()
        Me.btn_e10 = New System.Windows.Forms.Button()
        Me.btn_e5 = New System.Windows.Forms.Button()
        Me.btn_e2 = New System.Windows.Forms.Button()
        Me.btn_e1 = New System.Windows.Forms.Button()
        Me.btn_exact = New System.Windows.Forms.Button()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReceiptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LB_PK = New System.Windows.Forms.ListBox()
        Me.ConnectDataSet1 = New Test.ConnectDataSet()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New Test.ConnectDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New Test.ConnectDataSetTableAdapters.TableAdapterManager()
        Me.OrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.OrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Order_ProfitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_ProfitTableAdapter = New Test.ConnectDataSetTableAdapters.Order_ProfitTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ConnectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderBindingNavigator.SuspendLayout()
        CType(Me.Order_ProfitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Modify
        '
        Me.btn_Modify.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btn_Modify.Location = New System.Drawing.Point(1004, 617)
        Me.btn_Modify.Name = "btn_Modify"
        Me.btn_Modify.Size = New System.Drawing.Size(87, 66)
        Me.btn_Modify.TabIndex = 0
        Me.btn_Modify.Text = "Modify Order"
        Me.btn_Modify.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_Num)
        Me.GroupBox1.Controls.Add(Me.LB_Price)
        Me.GroupBox1.Controls.Add(Me.LB_Name)
        Me.GroupBox1.Location = New System.Drawing.Point(701, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 507)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
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
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Dec)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_0)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Enter)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_AC)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_EFTPOS)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 318)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(347, 365)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_1.Location = New System.Drawing.Point(3, 3)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(105, 65)
        Me.btn_1.TabIndex = 3
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_2.Location = New System.Drawing.Point(114, 3)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(105, 65)
        Me.btn_2.TabIndex = 4
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_3.Location = New System.Drawing.Point(225, 3)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(105, 65)
        Me.btn_3.TabIndex = 5
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_4.Location = New System.Drawing.Point(3, 74)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(105, 65)
        Me.btn_4.TabIndex = 6
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_5.Location = New System.Drawing.Point(114, 74)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(105, 65)
        Me.btn_5.TabIndex = 7
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_6.Location = New System.Drawing.Point(225, 74)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(105, 65)
        Me.btn_6.TabIndex = 8
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_7.Location = New System.Drawing.Point(3, 145)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(105, 65)
        Me.btn_7.TabIndex = 9
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_8.Location = New System.Drawing.Point(114, 145)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(105, 65)
        Me.btn_8.TabIndex = 10
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_9.Location = New System.Drawing.Point(225, 145)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(105, 65)
        Me.btn_9.TabIndex = 11
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_Dec
        '
        Me.btn_Dec.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_Dec.Location = New System.Drawing.Point(3, 216)
        Me.btn_Dec.Name = "btn_Dec"
        Me.btn_Dec.Size = New System.Drawing.Size(105, 65)
        Me.btn_Dec.TabIndex = 12
        Me.btn_Dec.Text = "."
        Me.btn_Dec.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_0.Location = New System.Drawing.Point(114, 216)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(105, 65)
        Me.btn_0.TabIndex = 13
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'btn_Enter
        '
        Me.btn_Enter.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_Enter.Location = New System.Drawing.Point(225, 216)
        Me.btn_Enter.Name = "btn_Enter"
        Me.btn_Enter.Size = New System.Drawing.Size(105, 65)
        Me.btn_Enter.TabIndex = 2
        Me.btn_Enter.Text = "Enter"
        Me.btn_Enter.UseVisualStyleBackColor = False
        '
        'btn_AC
        '
        Me.btn_AC.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_AC.Location = New System.Drawing.Point(3, 287)
        Me.btn_AC.Name = "btn_AC"
        Me.btn_AC.Size = New System.Drawing.Size(105, 65)
        Me.btn_AC.TabIndex = 14
        Me.btn_AC.Text = "AC"
        Me.btn_AC.UseVisualStyleBackColor = False
        '
        'btn_EFTPOS
        '
        Me.btn_EFTPOS.BackColor = System.Drawing.Color.GhostWhite
        Me.btn_EFTPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EFTPOS.Location = New System.Drawing.Point(114, 287)
        Me.btn_EFTPOS.Name = "btn_EFTPOS"
        Me.btn_EFTPOS.Size = New System.Drawing.Size(105, 65)
        Me.btn_EFTPOS.TabIndex = 15
        Me.btn_EFTPOS.Text = "EFTPOS"
        Me.btn_EFTPOS.UseVisualStyleBackColor = False
        '
        'lbl_tendered
        '
        Me.lbl_tendered.AutoSize = True
        Me.lbl_tendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tendered.Location = New System.Drawing.Point(26, 39)
        Me.lbl_tendered.Name = "lbl_tendered"
        Me.lbl_tendered.Size = New System.Drawing.Size(99, 24)
        Me.lbl_tendered.TabIndex = 21
        Me.lbl_tendered.Text = "Tendered:"
        '
        'lbl_Change
        '
        Me.lbl_Change.AutoSize = True
        Me.lbl_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Change.Location = New System.Drawing.Point(8, 108)
        Me.lbl_Change.Name = "lbl_Change"
        Me.lbl_Change.Size = New System.Drawing.Size(147, 39)
        Me.lbl_Change.TabIndex = 22
        Me.lbl_Change.Text = "Change:"
        Me.lbl_Change.UseWaitCursor = True
        '
        'txt_Tendered
        '
        Me.txt_Tendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tendered.Location = New System.Drawing.Point(165, 28)
        Me.txt_Tendered.Name = "txt_Tendered"
        Me.txt_Tendered.Size = New System.Drawing.Size(368, 40)
        Me.txt_Tendered.TabIndex = 23
        '
        'txt_Change
        '
        Me.txt_Change.Enabled = False
        Me.txt_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Change.Location = New System.Drawing.Point(165, 108)
        Me.txt_Change.Name = "txt_Change"
        Me.txt_Change.Size = New System.Drawing.Size(368, 44)
        Me.txt_Change.TabIndex = 24
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_e50)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_e20)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_e10)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_e5)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_e2)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_e1)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_exact)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(15, 166)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(638, 146)
        Me.FlowLayoutPanel2.TabIndex = 25
        '
        'btn_e50
        '
        Me.btn_e50.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_e50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e50.Location = New System.Drawing.Point(3, 3)
        Me.btn_e50.Name = "btn_e50"
        Me.btn_e50.Size = New System.Drawing.Size(149, 58)
        Me.btn_e50.TabIndex = 0
        Me.btn_e50.Text = "$50"
        Me.btn_e50.UseVisualStyleBackColor = False
        '
        'btn_e20
        '
        Me.btn_e20.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_e20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e20.Location = New System.Drawing.Point(158, 3)
        Me.btn_e20.Name = "btn_e20"
        Me.btn_e20.Size = New System.Drawing.Size(149, 58)
        Me.btn_e20.TabIndex = 1
        Me.btn_e20.Text = "$20"
        Me.btn_e20.UseVisualStyleBackColor = False
        '
        'btn_e10
        '
        Me.btn_e10.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_e10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e10.Location = New System.Drawing.Point(313, 3)
        Me.btn_e10.Name = "btn_e10"
        Me.btn_e10.Size = New System.Drawing.Size(149, 58)
        Me.btn_e10.TabIndex = 2
        Me.btn_e10.Text = "$10"
        Me.btn_e10.UseVisualStyleBackColor = False
        '
        'btn_e5
        '
        Me.btn_e5.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_e5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e5.Location = New System.Drawing.Point(468, 3)
        Me.btn_e5.Name = "btn_e5"
        Me.btn_e5.Size = New System.Drawing.Size(149, 58)
        Me.btn_e5.TabIndex = 3
        Me.btn_e5.Text = "$5"
        Me.btn_e5.UseVisualStyleBackColor = False
        '
        'btn_e2
        '
        Me.btn_e2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_e2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e2.Location = New System.Drawing.Point(3, 67)
        Me.btn_e2.Name = "btn_e2"
        Me.btn_e2.Size = New System.Drawing.Size(149, 58)
        Me.btn_e2.TabIndex = 4
        Me.btn_e2.Text = "$2"
        Me.btn_e2.UseVisualStyleBackColor = False
        '
        'btn_e1
        '
        Me.btn_e1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_e1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e1.Location = New System.Drawing.Point(158, 67)
        Me.btn_e1.Name = "btn_e1"
        Me.btn_e1.Size = New System.Drawing.Size(149, 58)
        Me.btn_e1.TabIndex = 5
        Me.btn_e1.Text = "$1"
        Me.btn_e1.UseVisualStyleBackColor = False
        '
        'btn_exact
        '
        Me.btn_exact.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_exact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exact.Location = New System.Drawing.Point(313, 67)
        Me.btn_exact.Name = "btn_exact"
        Me.btn_exact.Size = New System.Drawing.Size(149, 58)
        Me.btn_exact.TabIndex = 6
        Me.btn_exact.Text = "Exact Cash"
        Me.btn_exact.UseVisualStyleBackColor = False
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lbl_Total.Location = New System.Drawing.Point(702, 534)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(197, 37)
        Me.lbl_Total.TabIndex = 26
        Me.lbl_Total.Text = "Total : $0.00"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceiptsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1111, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReceiptsToolStripMenuItem
        '
        Me.ReceiptsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarristaToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.ReceiptsToolStripMenuItem.Enabled = False
        Me.ReceiptsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ReceiptsToolStripMenuItem.Name = "ReceiptsToolStripMenuItem"
        Me.ReceiptsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ReceiptsToolStripMenuItem.Text = "Receipts"
        '
        'BarristaToolStripMenuItem
        '
        Me.BarristaToolStripMenuItem.Name = "BarristaToolStripMenuItem"
        Me.BarristaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarristaToolStripMenuItem.Text = "Barrista"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'LB_PK
        '
        Me.LB_PK.FormattingEnabled = True
        Me.LB_PK.Location = New System.Drawing.Point(913, 535)
        Me.LB_PK.Name = "LB_PK"
        Me.LB_PK.Size = New System.Drawing.Size(178, 69)
        Me.LB_PK.TabIndex = 28
        Me.LB_PK.Visible = False
        '
        'ConnectDataSet1
        '
        Me.ConnectDataSet1.DataSetName = "ConnectDataSet"
        Me.ConnectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = Me.ConnectDataSet1
        Me.OrderBindingSource.Position = 0
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoffeeTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Order_ProfitTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Test.ConnectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'OrderBindingNavigator
        '
        Me.OrderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrderBindingNavigator.BindingSource = Me.OrderBindingSource
        Me.OrderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrderBindingNavigatorSaveItem})
        Me.OrderBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.OrderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrderBindingNavigator.Name = "OrderBindingNavigator"
        Me.OrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrderBindingNavigator.Size = New System.Drawing.Size(1111, 25)
        Me.OrderBindingNavigator.TabIndex = 29
        Me.OrderBindingNavigator.Text = "BindingNavigator1"
        Me.OrderBindingNavigator.Visible = False
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
        Me.BindingNavigatorPositionItem.Text = "1"
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
        'OrderBindingNavigatorSaveItem
        '
        Me.OrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrderBindingNavigatorSaveItem.Name = "OrderBindingNavigatorSaveItem"
        Me.OrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Order_ProfitBindingSource
        '
        Me.Order_ProfitBindingSource.DataMember = "Order Profit"
        Me.Order_ProfitBindingSource.DataSource = Me.ConnectDataSet1
        '
        'Order_ProfitTableAdapter
        '
        Me.Order_ProfitTableAdapter.ClearBeforeFill = True
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 703)
        Me.Controls.Add(Me.OrderBindingNavigator)
        Me.Controls.Add(Me.LB_PK)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.txt_Change)
        Me.Controls.Add(Me.txt_Tendered)
        Me.Controls.Add(Me.lbl_Change)
        Me.Controls.Add(Me.lbl_tendered)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Modify)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ConnectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderBindingNavigator.ResumeLayout(False)
        Me.OrderBindingNavigator.PerformLayout()
        CType(Me.Order_ProfitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Modify As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_Num As ListBox
    Friend WithEvents LB_Price As ListBox
    Friend WithEvents LB_Name As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_Dec As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_Enter As Button
    Friend WithEvents btn_AC As Button
    Friend WithEvents lbl_tendered As Label
    Friend WithEvents lbl_Change As Label
    Friend WithEvents txt_Tendered As TextBox
    Friend WithEvents txt_Change As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btn_e50 As Button
    Friend WithEvents btn_e20 As Button
    Friend WithEvents btn_e10 As Button
    Friend WithEvents btn_e5 As Button
    Friend WithEvents btn_e2 As Button
    Friend WithEvents btn_e1 As Button
    Friend WithEvents btn_exact As Button
    Friend WithEvents btn_EFTPOS As Button
    Friend WithEvents lbl_Total As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReceiptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarristaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LB_PK As ListBox
    Friend WithEvents ConnectDataSet1 As ConnectDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As ConnectDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents TableAdapterManager As ConnectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderBindingNavigator As BindingNavigator
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
    Friend WithEvents OrderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Order_ProfitBindingSource As BindingSource
    Friend WithEvents Order_ProfitTableAdapter As ConnectDataSetTableAdapters.Order_ProfitTableAdapter
End Class
