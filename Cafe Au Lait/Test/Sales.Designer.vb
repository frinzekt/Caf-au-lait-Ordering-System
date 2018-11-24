<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SumOfAmountLabel As System.Windows.Forms.Label
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim Order_ProfitLabel As System.Windows.Forms.Label
        Dim SumOfOrder_ProfitLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.ConnectDataSet = New Test.ConnectDataSet()
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter = New Test.ConnectDataSetTableAdapters.Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter()
        Me.TableAdapterManager = New Test.ConnectDataSetTableAdapters.TableAdapterManager()
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SumOfAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Order_ProfitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_ProfitTableAdapter = New Test.ConnectDataSetTableAdapters.Order_ProfitTableAdapter()
        Me.Order_ProfitDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_ProfitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Total_ProfitTableAdapter = New Test.ConnectDataSetTableAdapters.Total_ProfitTableAdapter()
        Me.Total_ProfitDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.Order_ProfitTextBox = New System.Windows.Forms.TextBox()
        Me.SumOfOrder_ProfitTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SumOfAmountLabel = New System.Windows.Forms.Label()
        OrderIDLabel = New System.Windows.Forms.Label()
        Order_ProfitLabel = New System.Windows.Forms.Label()
        SumOfOrder_ProfitLabel = New System.Windows.Forms.Label()
        CType(Me.ConnectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.SuspendLayout()
        CType(Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_ProfitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_ProfitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_ProfitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_ProfitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(34, 70)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(34, 96)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'SumOfAmountLabel
        '
        SumOfAmountLabel.AutoSize = True
        SumOfAmountLabel.Location = New System.Drawing.Point(34, 122)
        SumOfAmountLabel.Name = "SumOfAmountLabel"
        SumOfAmountLabel.Size = New System.Drawing.Size(92, 13)
        SumOfAmountLabel.TabIndex = 6
        SumOfAmountLabel.Text = "Number Of Coffee"
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Location = New System.Drawing.Point(34, 226)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(50, 13)
        OrderIDLabel.TabIndex = 10
        OrderIDLabel.Text = "Order ID:"
        '
        'Order_ProfitLabel
        '
        Order_ProfitLabel.AutoSize = True
        Order_ProfitLabel.Location = New System.Drawing.Point(34, 252)
        Order_ProfitLabel.Name = "Order_ProfitLabel"
        Order_ProfitLabel.Size = New System.Drawing.Size(63, 13)
        Order_ProfitLabel.TabIndex = 12
        Order_ProfitLabel.Text = "Order Profit:"
        '
        'SumOfOrder_ProfitLabel
        '
        SumOfOrder_ProfitLabel.AutoSize = True
        SumOfOrder_ProfitLabel.Location = New System.Drawing.Point(25, 420)
        SumOfOrder_ProfitLabel.Name = "SumOfOrder_ProfitLabel"
        SumOfOrder_ProfitLabel.Size = New System.Drawing.Size(58, 13)
        SumOfOrder_ProfitLabel.TabIndex = 14
        SumOfOrder_ProfitLabel.Text = "Total Profit"
        '
        'ConnectDataSet
        '
        Me.ConnectDataSet.DataSetName = "ConnectDataSet"
        Me.ConnectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource
        '
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource.DataMember = "Number Of Coffee Sales In a Specific Day"
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource.DataSource = Me.ConnectDataSet
        '
        'Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter
        '
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter.ClearBeforeFill = True
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
        'Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator
        '
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.BindingSource = Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem})
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.Name = "Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator"
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.Size = New System.Drawing.Size(880, 25)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.TabIndex = 0
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.Highlight
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
        'Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem
        '
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.Enabled = False
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.Image = CType(resources.GetObject("Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.Name = "Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem"
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView
        '
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.AutoGenerateColumns = False
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.DataSource = Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.Enabled = False
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.Location = New System.Drawing.Point(398, 44)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.Name = "Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView"
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.Size = New System.Drawing.Size(472, 157)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SumOfAmount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Number of Coffee"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(124, 67)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(222, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource, "Name", True))
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(124, 93)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'SumOfAmountTextBox
        '
        Me.SumOfAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource, "SumOfAmount", True))
        Me.SumOfAmountTextBox.Enabled = False
        Me.SumOfAmountTextBox.Location = New System.Drawing.Point(124, 119)
        Me.SumOfAmountTextBox.Name = "SumOfAmountTextBox"
        Me.SumOfAmountTextBox.Size = New System.Drawing.Size(222, 20)
        Me.SumOfAmountTextBox.TabIndex = 7
        '
        'Order_ProfitBindingSource
        '
        Me.Order_ProfitBindingSource.DataMember = "Order Profit"
        Me.Order_ProfitBindingSource.DataSource = Me.ConnectDataSet
        '
        'Order_ProfitTableAdapter
        '
        Me.Order_ProfitTableAdapter.ClearBeforeFill = True
        '
        'Order_ProfitDataGridView
        '
        Me.Order_ProfitDataGridView.AutoGenerateColumns = False
        Me.Order_ProfitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Order_ProfitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Order_ProfitDataGridView.DataSource = Me.Order_ProfitBindingSource
        Me.Order_ProfitDataGridView.Enabled = False
        Me.Order_ProfitDataGridView.Location = New System.Drawing.Point(398, 216)
        Me.Order_ProfitDataGridView.Name = "Order_ProfitDataGridView"
        Me.Order_ProfitDataGridView.Size = New System.Drawing.Size(472, 186)
        Me.Order_ProfitDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OrderID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Order Profit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Order Profit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Total_ProfitBindingSource
        '
        Me.Total_ProfitBindingSource.DataMember = "Total Profit"
        Me.Total_ProfitBindingSource.DataSource = Me.ConnectDataSet
        '
        'Total_ProfitTableAdapter
        '
        Me.Total_ProfitTableAdapter.ClearBeforeFill = True
        '
        'Total_ProfitDataGridView
        '
        Me.Total_ProfitDataGridView.AutoGenerateColumns = False
        Me.Total_ProfitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Total_ProfitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.Total_ProfitDataGridView.DataSource = Me.Total_ProfitBindingSource
        Me.Total_ProfitDataGridView.Enabled = False
        Me.Total_ProfitDataGridView.Location = New System.Drawing.Point(398, 420)
        Me.Total_ProfitDataGridView.Name = "Total_ProfitDataGridView"
        Me.Total_ProfitDataGridView.Size = New System.Drawing.Size(145, 59)
        Me.Total_ProfitDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SumOfOrder Profit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Profit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_ProfitBindingSource, "OrderID", True))
        Me.OrderIDTextBox.Enabled = False
        Me.OrderIDTextBox.Location = New System.Drawing.Point(103, 223)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrderIDTextBox.TabIndex = 11
        '
        'Order_ProfitTextBox
        '
        Me.Order_ProfitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_ProfitBindingSource, "Order Profit", True))
        Me.Order_ProfitTextBox.Enabled = False
        Me.Order_ProfitTextBox.Location = New System.Drawing.Point(103, 249)
        Me.Order_ProfitTextBox.Name = "Order_ProfitTextBox"
        Me.Order_ProfitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Order_ProfitTextBox.TabIndex = 13
        '
        'SumOfOrder_ProfitTextBox
        '
        Me.SumOfOrder_ProfitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Total_ProfitBindingSource, "SumOfOrder Profit", True))
        Me.SumOfOrder_ProfitTextBox.Enabled = False
        Me.SumOfOrder_ProfitTextBox.Location = New System.Drawing.Point(132, 417)
        Me.SumOfOrder_ProfitTextBox.Name = "SumOfOrder_ProfitTextBox"
        Me.SumOfOrder_ProfitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SumOfOrder_ProfitTextBox.TabIndex = 15
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 490)
        Me.Controls.Add(SumOfOrder_ProfitLabel)
        Me.Controls.Add(Me.SumOfOrder_ProfitTextBox)
        Me.Controls.Add(OrderIDLabel)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Controls.Add(Order_ProfitLabel)
        Me.Controls.Add(Me.Order_ProfitTextBox)
        Me.Controls.Add(Me.Total_ProfitDataGridView)
        Me.Controls.Add(Me.Order_ProfitDataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SumOfAmountLabel)
        Me.Controls.Add(Me.SumOfAmountTextBox)
        Me.Controls.Add(Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView)
        Me.Controls.Add(Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "Sales"
        Me.Text = "Sales"
        CType(Me.ConnectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.ResumeLayout(False)
        Me.Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator.PerformLayout()
        CType(Me.Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_ProfitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_ProfitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_ProfitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_ProfitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectDataSet As ConnectDataSet
    Friend WithEvents Number_Of_Coffee_Sales_In_a_Specific_DayBindingSource As BindingSource
    Friend WithEvents Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter As ConnectDataSetTableAdapters.Number_Of_Coffee_Sales_In_a_Specific_DayTableAdapter
    Friend WithEvents TableAdapterManager As ConnectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigator As BindingNavigator
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
    Friend WithEvents Number_Of_Coffee_Sales_In_a_Specific_DayBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Number_Of_Coffee_Sales_In_a_Specific_DayDataGridView As DataGridView
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SumOfAmountTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Order_ProfitBindingSource As BindingSource
    Friend WithEvents Order_ProfitTableAdapter As ConnectDataSetTableAdapters.Order_ProfitTableAdapter
    Friend WithEvents Order_ProfitDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Total_ProfitBindingSource As BindingSource
    Friend WithEvents Total_ProfitTableAdapter As ConnectDataSetTableAdapters.Total_ProfitTableAdapter
    Friend WithEvents Total_ProfitDataGridView As DataGridView
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents Order_ProfitTextBox As TextBox
    Friend WithEvents SumOfOrder_ProfitTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
