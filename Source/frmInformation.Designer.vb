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
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.trv_info = New System.Windows.Forms.TreeView()
        Me.tmrMovePanelIn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovePanelOut = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.rtb_info = New Optics.TransparentRichTextBox()
        Me.pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_menu.Controls.Add(Me.trv_info)
        Me.pnl_menu.Location = New System.Drawing.Point(-240, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(290, 360)
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
        Me.trv_info.Size = New System.Drawing.Size(238, 360)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(482, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rtb_info
        '
        Me.rtb_info.Location = New System.Drawing.Point(376, 30)
        Me.rtb_info.Name = "rtb_info"
        Me.rtb_info.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_info.Size = New System.Drawing.Size(325, 262)
        Me.rtb_info.TabIndex = 10
        Me.rtb_info.Text = ""
        '
        'frmInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 355)
        Me.Controls.Add(Me.rtb_info)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnl_menu)
        Me.Name = "frmInformation"
        Me.pnl_menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents trv_info As System.Windows.Forms.TreeView
    Friend WithEvents tmrMovePanelIn As System.Windows.Forms.Timer
    Friend WithEvents tmrMovePanelOut As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents rtb_info As Optics.TransparentRichTextBox
End Class
