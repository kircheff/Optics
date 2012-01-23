<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtMeaning = New System.Windows.Forms.TextBox()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(12, 12)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(116, 225)
        Me.lstWords.TabIndex = 1
        '
        'txtWord
        '
        Me.txtWord.Enabled = False
        Me.txtWord.Location = New System.Drawing.Point(215, 12)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(156, 20)
        Me.txtWord.TabIndex = 2
        '
        'txtMeaning
        '
        Me.txtMeaning.Enabled = False
        Me.txtMeaning.Location = New System.Drawing.Point(215, 38)
        Me.txtMeaning.Multiline = True
        Me.txtMeaning.Name = "txtMeaning"
        Me.txtMeaning.Size = New System.Drawing.Size(156, 58)
        Me.txtMeaning.TabIndex = 3
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(215, 102)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 4
        Me.cmdChange.Text = "Промени"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(296, 102)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Запамети"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 279)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.txtMeaning)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmAdmin"
        Me.Text = "Администраторски панел"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents txtMeaning As System.Windows.Forms.TextBox
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
End Class
