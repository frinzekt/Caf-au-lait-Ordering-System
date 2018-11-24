<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarristaReceipt
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
        Me.lbl_Cashier = New System.Windows.Forms.Label()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.LB_Num = New System.Windows.Forms.ListBox()
        Me.LB_Name = New System.Windows.Forms.ListBox()
        Me.lbl_TakeAway = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Cashier
        '
        Me.lbl_Cashier.Font = New System.Drawing.Font("Agency FB", 12.0!)
        Me.lbl_Cashier.Location = New System.Drawing.Point(-3, 62)
        Me.lbl_Cashier.Name = "lbl_Cashier"
        Me.lbl_Cashier.Size = New System.Drawing.Size(486, 22)
        Me.lbl_Cashier.TabIndex = 34
        Me.lbl_Cashier.Text = "Cashier: Frinze Lapuz"
        Me.lbl_Cashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Title
        '
        Me.lbl_Title.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(-6, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(480, 52)
        Me.lbl_Title.TabIndex = 33
        Me.lbl_Title.Text = "Cafe Au Lait"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_Num
        '
        Me.LB_Num.Enabled = False
        Me.LB_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Num.FormattingEnabled = True
        Me.LB_Num.ItemHeight = 18
        Me.LB_Num.Location = New System.Drawing.Point(54, 100)
        Me.LB_Num.Name = "LB_Num"
        Me.LB_Num.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LB_Num.Size = New System.Drawing.Size(70, 472)
        Me.LB_Num.TabIndex = 32
        '
        'LB_Name
        '
        Me.LB_Name.Enabled = False
        Me.LB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Name.FormattingEnabled = True
        Me.LB_Name.ItemHeight = 18
        Me.LB_Name.Location = New System.Drawing.Point(121, 100)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Name.Size = New System.Drawing.Size(321, 472)
        Me.LB_Name.TabIndex = 31
        '
        'lbl_TakeAway
        '
        Me.lbl_TakeAway.AutoSize = True
        Me.lbl_TakeAway.Font = New System.Drawing.Font("Monotxt_IV25", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TakeAway.Location = New System.Drawing.Point(24, 617)
        Me.lbl_TakeAway.Name = "lbl_TakeAway"
        Me.lbl_TakeAway.Size = New System.Drawing.Size(448, 80)
        Me.lbl_TakeAway.TabIndex = 35
        Me.lbl_TakeAway.Text = "TAKE AWAY"
        Me.lbl_TakeAway.Visible = False
        '
        'BarristaReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 749)
        Me.Controls.Add(Me.lbl_TakeAway)
        Me.Controls.Add(Me.lbl_Cashier)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.LB_Num)
        Me.Controls.Add(Me.LB_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BarristaReceipt"
        Me.Text = "BarristaReceipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Cashier As Label
    Friend WithEvents lbl_Title As Label
    Friend WithEvents LB_Num As ListBox
    Friend WithEvents LB_Name As ListBox
    Friend WithEvents lbl_TakeAway As Label
End Class
