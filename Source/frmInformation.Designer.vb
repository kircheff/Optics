<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformation
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
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.trv_info = New System.Windows.Forms.TreeView()
        Me.tmrMovePanelIn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovePanelOut = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(401, 313)
        Me.txt_1.Multiline = True
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(100, 30)
        Me.txt_1.TabIndex = 1
        '
        'txt_2
        '
        Me.txt_2.Location = New System.Drawing.Point(617, 313)
        Me.txt_2.Multiline = True
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(100, 30)
        Me.txt_2.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(401, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(316, 295)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_menu.Controls.Add(Me.trv_info)
        Me.pnl_menu.Location = New System.Drawing.Point(-240, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(291, 360)
        Me.pnl_menu.TabIndex = 7
        '
        'trv_info
        '
        Me.trv_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.trv_info.FullRowSelect = True
        Me.trv_info.Indent = 13
        Me.trv_info.ItemHeight = 27
        Me.trv_info.LabelEdit = True
        Me.trv_info.Location = New System.Drawing.Point(0, 0)
        Me.trv_info.Name = "trv_info"
        Me.trv_info.ShowPlusMinus = False
        Me.trv_info.Size = New System.Drawing.Size(239, 360)
        Me.trv_info.TabIndex = 7
        '
        'tmrMovePanelIn
        '
        Me.tmrMovePanelIn.Interval = 50
        '
        'tmrMovePanelOut
        '
        Me.tmrMovePanelOut.Interval = 50
        '
        'frmInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 355)
        Me.Controls.Add(Me.pnl_menu)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.txt_1)
        Me.Name = "frmInformation"
        Me.pnl_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents trv_info As System.Windows.Forms.TreeView
    Friend WithEvents tmrMovePanelIn As System.Windows.Forms.Timer
    Friend WithEvents tmrMovePanelOut As System.Windows.Forms.Timer
End Class
