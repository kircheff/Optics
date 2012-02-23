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
        Me.txt_correct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_points = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.cmd_save.Enabled = False
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
        Me.txt_question.Location = New System.Drawing.Point(12, 150)
        Me.txt_question.Multiline = True
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(514, 68)
        Me.txt_question.TabIndex = 6
        '
        'cmd_new
        '
        Me.cmd_new.Location = New System.Drawing.Point(354, 458)
        Me.cmd_new.Name = "cmd_new"
        Me.cmd_new.Size = New System.Drawing.Size(172, 36)
        Me.cmd_new.TabIndex = 10
        Me.cmd_new.Text = "Добави нов въпрос"
        Me.cmd_new.UseVisualStyleBackColor = True
        '
        'txt_correct
        '
        Me.txt_correct.Enabled = False
        Me.txt_correct.Location = New System.Drawing.Point(12, 403)
        Me.txt_correct.Multiline = True
        Me.txt_correct.Name = "txt_correct"
        Me.txt_correct.Size = New System.Drawing.Size(463, 23)
        Me.txt_correct.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Отговори"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Въпрос"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Правилен отговор"
        '
        'txt_points
        '
        Me.txt_points.Enabled = False
        Me.txt_points.Location = New System.Drawing.Point(481, 403)
        Me.txt_points.Multiline = True
        Me.txt_points.Name = "txt_points"
        Me.txt_points.Size = New System.Drawing.Size(45, 23)
        Me.txt_points.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Точки"
        '
        'frmTestChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 506)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_points)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_correct)
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
    Friend WithEvents txt_correct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_points As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
