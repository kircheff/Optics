<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestPast
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
        Me.lbl_question = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lst_questions
        '
        Me.lst_questions.FormattingEnabled = True
        Me.lst_questions.Location = New System.Drawing.Point(12, 12)
        Me.lst_questions.Name = "lst_questions"
        Me.lst_questions.Size = New System.Drawing.Size(120, 251)
        Me.lst_questions.TabIndex = 0
        '
        'lbl_question
        '
        Me.lbl_question.AutoSize = True
        Me.lbl_question.Location = New System.Drawing.Point(209, 12)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(45, 13)
        Me.lbl_question.TabIndex = 1
        Me.lbl_question.Text = "Въпрос"
        '
        'frmTestPast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 270)
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.lst_questions)
        Me.Name = "frmTestPast"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_questions As System.Windows.Forms.ListBox
    Friend WithEvents lbl_question As System.Windows.Forms.Label
End Class
