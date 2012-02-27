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
        Me.lbl_question_number = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(12, 100)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(450, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(45, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Въпрос"
        '
        'opt_answ1
        '
        Me.opt_answ1.AutoSize = True
        Me.opt_answ1.Location = New System.Drawing.Point(15, 182)
        Me.opt_answ1.MaximumSize = New System.Drawing.Size(400, 0)
        Me.opt_answ1.Name = "opt_answ1"
        Me.opt_answ1.Size = New System.Drawing.Size(76, 17)
        Me.opt_answ1.TabIndex = 1
        Me.opt_answ1.Text = "Отговор 1"
        Me.opt_answ1.UseVisualStyleBackColor = True
        '
        'opt_answ2
        '
        Me.opt_answ2.AutoSize = True
        Me.opt_answ2.Location = New System.Drawing.Point(15, 205)
        Me.opt_answ2.MaximumSize = New System.Drawing.Size(400, 0)
        Me.opt_answ2.Name = "opt_answ2"
        Me.opt_answ2.Size = New System.Drawing.Size(76, 17)
        Me.opt_answ2.TabIndex = 2
        Me.opt_answ2.Text = "Отговор 1"
        Me.opt_answ2.UseVisualStyleBackColor = True
        '
        'opt_answ3
        '
        Me.opt_answ3.AutoSize = True
        Me.opt_answ3.Location = New System.Drawing.Point(15, 228)
        Me.opt_answ3.MaximumSize = New System.Drawing.Size(400, 0)
        Me.opt_answ3.Name = "opt_answ3"
        Me.opt_answ3.Size = New System.Drawing.Size(76, 17)
        Me.opt_answ3.TabIndex = 3
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
        Me.lbl_seconds.Location = New System.Drawing.Point(318, 49)
        Me.lbl_seconds.Name = "lbl_seconds"
        Me.lbl_seconds.Size = New System.Drawing.Size(49, 13)
        Me.lbl_seconds.TabIndex = 4
        Me.lbl_seconds.Text = "Секунди"
        '
        'cmd_next
        '
        Me.cmd_next.Location = New System.Drawing.Point(373, 252)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(75, 23)
        Me.cmd_next.TabIndex = 5
        Me.cmd_next.Text = "Следващ >"
        Me.cmd_next.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(373, 226)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'lbl_question_number
        '
        Me.lbl_question_number.AutoSize = True
        Me.lbl_question_number.Location = New System.Drawing.Point(290, 62)
        Me.lbl_question_number.Name = "lbl_question_number"
        Me.lbl_question_number.Size = New System.Drawing.Size(30, 13)
        Me.lbl_question_number.TabIndex = 7
        Me.lbl_question_number.Text = "1/10"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 159)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Отговор 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(12, 49)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(29, 13)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.Text = "Име"
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(540, 24)
        Me.Menu.TabIndex = 13
        Me.Menu.Text = "MenuStrip1"
        '
        'НачалнаСтаницаToolStripMenuItem
        '
        Me.НачалнаСтаницаToolStripMenuItem.Name = "НачалнаСтаницаToolStripMenuItem"
        Me.НачалнаСтаницаToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.НачалнаСтаницаToolStripMenuItem.Text = "Начална станица"
        '
        'ТърсенеToolStripMenuItem
        '
        Me.ТърсенеToolStripMenuItem.Name = "ТърсенеToolStripMenuItem"
        Me.ТърсенеToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ТърсенеToolStripMenuItem.Text = "Търсене"
        '
        'ПомощToolStripMenuItem
        '
        Me.ПомощToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаПрограматаToolStripMenuItem, Me.ЗаАвторитеToolStripMenuItem, Me.ИзползванаЛитератураToolStripMenuItem})
        Me.ПомощToolStripMenuItem.Name = "ПомощToolStripMenuItem"
        Me.ПомощToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ПомощToolStripMenuItem.Text = "Помощ"
        '
        'ЗаПрограматаToolStripMenuItem
        '
        Me.ЗаПрограматаToolStripMenuItem.Name = "ЗаПрограматаToolStripMenuItem"
        Me.ЗаПрограматаToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ЗаПрограматаToolStripMenuItem.Text = "За програмата"
        '
        'ЗаАвторитеToolStripMenuItem
        '
        Me.ЗаАвторитеToolStripMenuItem.Name = "ЗаАвторитеToolStripMenuItem"
        Me.ЗаАвторитеToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ЗаАвторитеToolStripMenuItem.Text = "За авторите"
        '
        'ИзползванаЛитератураToolStripMenuItem
        '
        Me.ИзползванаЛитератураToolStripMenuItem.Name = "ИзползванаЛитератураToolStripMenuItem"
        Me.ИзползванаЛитератураToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ИзползванаЛитератураToolStripMenuItem.Text = "Използвана литература"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 349)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.lbl_question_number)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.lbl_seconds)
        Me.Controls.Add(Me.opt_answ3)
        Me.Controls.Add(Me.opt_answ2)
        Me.Controls.Add(Me.opt_answ1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmTest"
        Me.Text = "Тест"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
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
    Friend WithEvents lbl_question_number As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
