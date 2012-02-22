<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminSplash
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.cmdDictAdmin = New System.Windows.Forms.Button()
        Me.cmdChangePass = New System.Windows.Forms.Button()
        Me.cmdResetDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(33, 12)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 0
        '
        'cmdCheck
        '
        Me.cmdCheck.Location = New System.Drawing.Point(189, 12)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(75, 23)
        Me.cmdCheck.TabIndex = 1
        Me.cmdCheck.Text = "Влез"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'cmdDictAdmin
        '
        Me.cmdDictAdmin.Enabled = False
        Me.cmdDictAdmin.Location = New System.Drawing.Point(33, 115)
        Me.cmdDictAdmin.Name = "cmdDictAdmin"
        Me.cmdDictAdmin.Size = New System.Drawing.Size(231, 23)
        Me.cmdDictAdmin.TabIndex = 2
        Me.cmdDictAdmin.Text = "Администриране на речника"
        Me.cmdDictAdmin.UseVisualStyleBackColor = True
        '
        'cmdChangePass
        '
        Me.cmdChangePass.Enabled = False
        Me.cmdChangePass.Location = New System.Drawing.Point(33, 86)
        Me.cmdChangePass.Name = "cmdChangePass"
        Me.cmdChangePass.Size = New System.Drawing.Size(231, 23)
        Me.cmdChangePass.TabIndex = 3
        Me.cmdChangePass.Text = "Смяна на паролата"
        Me.cmdChangePass.UseVisualStyleBackColor = True
        '
        'cmdResetDB
        '
        Me.cmdResetDB.Enabled = False
        Me.cmdResetDB.Location = New System.Drawing.Point(33, 144)
        Me.cmdResetDB.Name = "cmdResetDB"
        Me.cmdResetDB.Size = New System.Drawing.Size(231, 41)
        Me.cmdResetDB.TabIndex = 4
        Me.cmdResetDB.Text = "Връщане на базата данни в начално състояние"
        Me.cmdResetDB.UseVisualStyleBackColor = True
        '
        'frmAdminSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 259)
        Me.Controls.Add(Me.cmdResetDB)
        Me.Controls.Add(Me.cmdChangePass)
        Me.Controls.Add(Me.cmdDictAdmin)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.txtPassword)
        Me.Name = "frmAdminSplash"
        Me.Text = "frmAdminSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdCheck As System.Windows.Forms.Button
    Friend WithEvents cmdDictAdmin As System.Windows.Forms.Button
    Friend WithEvents cmdChangePass As System.Windows.Forms.Button
    Friend WithEvents cmdResetDB As System.Windows.Forms.Button
End Class
