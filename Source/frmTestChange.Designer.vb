<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestChange
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
        Me.lst_questions = New System.Windows.Forms.ListBox()
        Me.cmd_change = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.cmd_new = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_questions
        '
        Me.lst_questions.FormattingEnabled = True
        Me.lst_questions.Location = New System.Drawing.Point(12, 12)
        Me.lst_questions.Name = "lst_questions"
        Me.lst_questions.Size = New System.Drawing.Size(514, 108)
        Me.lst_questions.TabIndex = 0
        '
        'cmd_change
        '
        Me.cmd_change.Location = New System.Drawing.Point(12, 458)
        Me.cmd_change.Name = "cmd_change"
        Me.cmd_change.Size = New System.Drawing.Size(163, 36)
        Me.cmd_change.TabIndex = 4
        Me.cmd_change.Text = "Промени"
        Me.cmd_change.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(181, 458)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(167, 36)
        Me.cmd_save.TabIndex = 5
        Me.cmd_save.Text = "Запамети текущи промени"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'txt_question
        '
        Me.txt_question.Enabled = False
        Me.txt_question.Location = New System.Drawing.Point(12, 131)
        Me.txt_question.Multiline = True
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(514, 68)
        Me.txt_question.TabIndex = 6
        '
        'cmd_new
        '
        Me.cmd_new.Location = New System.Drawing.Point(354, 458)
        Me.cmd_new.Name = "cmd_new"
        Me.cmd_new.Size = New System.Drawing.Size(166, 36)
        Me.cmd_new.TabIndex = 10
        Me.cmd_new.Text = "Добави нов въпрос"
        Me.cmd_new.UseVisualStyleBackColor = True
        '
        'frmTestChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 506)
        Me.Controls.Add(Me.cmd_new)
        Me.Controls.Add(Me.txt_question)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.cmd_change)
        Me.Controls.Add(Me.lst_questions)
        Me.Name = "frmTestChange"
        Me.Text = "Администрация Тест Промяна"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_questions As System.Windows.Forms.ListBox
    Friend WithEvents cmd_change As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents txt_question As System.Windows.Forms.TextBox
    Friend WithEvents cmd_new As System.Windows.Forms.Button
End Class
