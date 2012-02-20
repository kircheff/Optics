<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestSplash
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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_klas = New System.Windows.Forms.TextBox()
        Me.cmd_forward = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_klas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(53, 12)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(341, 20)
        Me.txt_username.TabIndex = 0
        '
        'txt_klas
        '
        Me.txt_klas.Location = New System.Drawing.Point(53, 38)
        Me.txt_klas.Name = "txt_klas"
        Me.txt_klas.Size = New System.Drawing.Size(100, 20)
        Me.txt_klas.TabIndex = 1
        '
        'cmd_forward
        '
        Me.cmd_forward.Location = New System.Drawing.Point(400, 9)
        Me.cmd_forward.Name = "cmd_forward"
        Me.cmd_forward.Size = New System.Drawing.Size(75, 23)
        Me.cmd_forward.TabIndex = 2
        Me.cmd_forward.Text = "Напред"
        Me.cmd_forward.UseVisualStyleBackColor = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(12, 19)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(32, 13)
        Me.lbl_username.TabIndex = 3
        Me.lbl_username.Text = "Име:"
        '
        'lbl_klas
        '
        Me.lbl_klas.AutoSize = True
        Me.lbl_klas.Location = New System.Drawing.Point(12, 41)
        Me.lbl_klas.Name = "lbl_klas"
        Me.lbl_klas.Size = New System.Drawing.Size(35, 13)
        Me.lbl_klas.TabIndex = 4
        Me.lbl_klas.Text = "Клас:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "(не е задължителен)"
        '
        'frmTestSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 96)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_klas)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.cmd_forward)
        Me.Controls.Add(Me.txt_klas)
        Me.Controls.Add(Me.txt_username)
        Me.Name = "frmTestSplash"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_klas As System.Windows.Forms.TextBox
    Friend WithEvents cmd_forward As System.Windows.Forms.Button
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_klas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
