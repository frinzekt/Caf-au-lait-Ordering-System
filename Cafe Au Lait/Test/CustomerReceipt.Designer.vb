<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerReceipt
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LB_Num = New System.Windows.Forms.ListBox()
        Me.LB_Price = New System.Windows.Forms.ListBox()
        Me.LB_Name = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_Tendered = New System.Windows.Forms.Label()
        Me.lbl_Change = New System.Windows.Forms.Label()
        Me.lbl_Cashier = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LB_Num)
        Me.GroupBox2.Controls.Add(Me.LB_Price)
        Me.GroupBox2.Controls.Add(Me.LB_Name)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 507)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'LB_Num
        '
        Me.LB_Num.Enabled = False
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
        Me.LB_Price.Enabled = False
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
        Me.LB_Name.Enabled = False
        Me.LB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Name.FormattingEnabled = True
        Me.LB_Name.ItemHeight = 18
        Me.LB_Name.Location = New System.Drawing.Point(61, 6)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Name.Size = New System.Drawing.Size(219, 490)
        Me.LB_Name.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 52)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cafe Au Lait"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lbl_Total.Location = New System.Drawing.Point(39, 594)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(269, 37)
        Me.lbl_Total.TabIndex = 27
        Me.lbl_Total.Text = "Total :         $0.00"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Tendered
        '
        Me.lbl_Tendered.AutoSize = True
        Me.lbl_Tendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lbl_Tendered.Location = New System.Drawing.Point(39, 631)
        Me.lbl_Tendered.Name = "lbl_Tendered"
        Me.lbl_Tendered.Size = New System.Drawing.Size(270, 37)
        Me.lbl_Tendered.TabIndex = 28
        Me.lbl_Tendered.Text = "Tendered :  $0.00"
        Me.lbl_Tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Change
        '
        Me.lbl_Change.AutoSize = True
        Me.lbl_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lbl_Change.Location = New System.Drawing.Point(39, 668)
        Me.lbl_Change.Name = "lbl_Change"
        Me.lbl_Change.Size = New System.Drawing.Size(273, 37)
        Me.lbl_Change.TabIndex = 29
        Me.lbl_Change.Text = "Change:      $0.00"
        Me.lbl_Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Cashier
        '
        Me.lbl_Cashier.Font = New System.Drawing.Font("Agency FB", 12.0!)
        Me.lbl_Cashier.Location = New System.Drawing.Point(-2, 49)
        Me.lbl_Cashier.Name = "lbl_Cashier"
        Me.lbl_Cashier.Size = New System.Drawing.Size(486, 22)
        Me.lbl_Cashier.TabIndex = 30
        Me.lbl_Cashier.Text = "Cashier: Frinze Lapuz"
        Me.lbl_Cashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 749)
        Me.Controls.Add(Me.lbl_Cashier)
        Me.Controls.Add(Me.lbl_Change)
        Me.Controls.Add(Me.lbl_Tendered)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CustomerReceipt"
        Me.Text = "CustomerReceipt"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LB_Num As ListBox
    Friend WithEvents LB_Price As ListBox
    Friend WithEvents LB_Name As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents lbl_Tendered As Label
    Friend WithEvents lbl_Change As Label
    Friend WithEvents lbl_Cashier As Label
End Class
