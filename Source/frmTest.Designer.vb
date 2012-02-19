<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.opt_answ1 = New System.Windows.Forms.RadioButton()
        Me.opt_answ2 = New System.Windows.Forms.RadioButton()
        Me.opt_answ3 = New System.Windows.Forms.RadioButton()
        Me.tmr_time = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_seconds = New System.Windows.Forms.Label()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(164, 78)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(45, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Въпрос"
        '
        'opt_answ1
        '
        Me.opt_answ1.AutoSize = True
        Me.opt_answ1.Location = New System.Drawing.Point(164, 133)
        Me.opt_answ1.Name = "opt_answ1"
        Me.opt_answ1.Size = New System.Drawing.Size(76, 17)
        Me.opt_answ1.TabIndex = 1
        Me.opt_answ1.TabStop = True
        Me.opt_answ1.Text = "Отговор 1"
        Me.opt_answ1.UseVisualStyleBackColor = True
        '
        'opt_answ2
        '
        Me.opt_answ2.AutoSize = True
        Me.opt_answ2.Location = New System.Drawing.Point(164, 156)
        Me.opt_answ2.Name = "opt_answ2"
        Me.opt_answ2.Size = New System.Drawing.Size(76, 17)
        Me.opt_answ2.TabIndex = 2
        Me.opt_answ2.TabStop = True
        Me.opt_answ2.Text = "Отговор 1"
        Me.opt_answ2.UseVisualStyleBackColor = True
        '
        'opt_answ3
        '
        Me.opt_answ3.AutoSize = True
        Me.opt_answ3.Location = New System.Drawing.Point(164, 179)
        Me.opt_answ3.Name = "opt_answ3"
        Me.opt_answ3.Size = New System.Drawing.Size(76, 17)
        Me.opt_answ3.TabIndex = 3
        Me.opt_answ3.TabStop = True
        Me.opt_answ3.Text = "Отговор 1"
        Me.opt_answ3.UseVisualStyleBackColor = True
        '
        'tmr_time
        '
        Me.tmr_time.Enabled = True
        Me.tmr_time.Interval = 1000
        '
        'lbl_seconds
        '
        Me.lbl_seconds.AutoSize = True
        Me.lbl_seconds.Location = New System.Drawing.Point(528, 9)
        Me.lbl_seconds.Name = "lbl_seconds"
        Me.lbl_seconds.Size = New System.Drawing.Size(45, 13)
        Me.lbl_seconds.TabIndex = 4
        Me.lbl_seconds.Text = "Въпрос"
        '
        'cmd_next
        '
        Me.cmd_next.Location = New System.Drawing.Point(417, 312)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(75, 23)
        Me.cmd_next.TabIndex = 5
        Me.cmd_next.Text = "Следващ >"
        Me.cmd_next.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 390)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.lbl_seconds)
        Me.Controls.Add(Me.opt_answ3)
        Me.Controls.Add(Me.opt_answ2)
        Me.Controls.Add(Me.opt_answ1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmTest"
        Me.Text = "Тест"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents opt_answ1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_answ2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_answ3 As System.Windows.Forms.RadioButton
    Friend WithEvents tmr_time As System.Windows.Forms.Timer
    Friend WithEvents lbl_seconds As System.Windows.Forms.Label
    Friend WithEvents cmd_next As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
