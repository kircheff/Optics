<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(50, 75)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(184, 20)
        Me.txtPass2.TabIndex = 0
        '
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(50, 49)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(184, 20)
        Me.txtPass1.TabIndex = 1
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(134, 101)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdChange.TabIndex = 2
        Me.cmdChange.Text = "Смени паролата"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(50, 23)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(184, 20)
        Me.txtOldPass.TabIndex = 3
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 160)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.txtPass1)
        Me.Controls.Add(Me.txtPass2)
        Me.Name = "frmChangePassword"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPass1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
End Class
