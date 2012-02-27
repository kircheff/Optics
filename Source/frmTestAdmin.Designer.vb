<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestAdmin
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
        Me.lst_users = New System.Windows.Forms.ListBox()
        Me.fra_info = New System.Windows.Forms.GroupBox()
        Me.lbl_class_base = New System.Windows.Forms.Label()
        Me.lbl_mark_base = New System.Windows.Forms.Label()
        Me.lbl_points_base = New System.Windows.Forms.Label()
        Me.lbl_date_base = New System.Windows.Forms.Label()
        Me.lbl_name_base = New System.Windows.Forms.Label()
        Me.cmd_show_test = New System.Windows.Forms.Button()
        Me.lbl_class = New System.Windows.Forms.Label()
        Me.lbl_mark = New System.Windows.Forms.Label()
        Me.lbl_points = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fra_info.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_users
        '
        Me.lst_users.FormattingEnabled = True
        Me.lst_users.Location = New System.Drawing.Point(12, 40)
        Me.lst_users.Name = "lst_users"
        Me.lst_users.Size = New System.Drawing.Size(138, 225)
        Me.lst_users.TabIndex = 0
        '
        'fra_info
        '
        Me.fra_info.Controls.Add(Me.lbl_class_base)
        Me.fra_info.Controls.Add(Me.lbl_mark_base)
        Me.fra_info.Controls.Add(Me.lbl_points_base)
        Me.fra_info.Controls.Add(Me.lbl_date_base)
        Me.fra_info.Controls.Add(Me.lbl_name_base)
        Me.fra_info.Controls.Add(Me.cmd_show_test)
        Me.fra_info.Controls.Add(Me.lbl_class)
        Me.fra_info.Controls.Add(Me.lbl_mark)
        Me.fra_info.Controls.Add(Me.lbl_points)
        Me.fra_info.Controls.Add(Me.lbl_date)
        Me.fra_info.Controls.Add(Me.lbl_name)
        Me.fra_info.Location = New System.Drawing.Point(173, 40)
        Me.fra_info.Name = "fra_info"
        Me.fra_info.Size = New System.Drawing.Size(385, 225)
        Me.fra_info.TabIndex = 7
        Me.fra_info.TabStop = False
        Me.fra_info.Text = "Данни"
        '
        'lbl_class_base
        '
        Me.lbl_class_base.AutoSize = True
        Me.lbl_class_base.Location = New System.Drawing.Point(137, 57)
        Me.lbl_class_base.Name = "lbl_class_base"
        Me.lbl_class_base.Size = New System.Drawing.Size(31, 13)
        Me.lbl_class_base.TabIndex = 17
        Me.lbl_class_base.Text = "клас"
        '
        'lbl_mark_base
        '
        Me.lbl_mark_base.AutoSize = True
        Me.lbl_mark_base.Location = New System.Drawing.Point(68, 166)
        Me.lbl_mark_base.Name = "lbl_mark_base"
        Me.lbl_mark_base.Size = New System.Drawing.Size(43, 13)
        Me.lbl_mark_base.TabIndex = 16
        Me.lbl_mark_base.Text = "оценка"
        '
        'lbl_points_base
        '
        Me.lbl_points_base.AutoSize = True
        Me.lbl_points_base.Location = New System.Drawing.Point(105, 131)
        Me.lbl_points_base.Name = "lbl_points_base"
        Me.lbl_points_base.Size = New System.Drawing.Size(35, 13)
        Me.lbl_points_base.TabIndex = 15
        Me.lbl_points_base.Text = "точки"
        '
        'lbl_date_base
        '
        Me.lbl_date_base.AutoSize = True
        Me.lbl_date_base.Location = New System.Drawing.Point(197, 95)
        Me.lbl_date_base.Name = "lbl_date_base"
        Me.lbl_date_base.Size = New System.Drawing.Size(59, 13)
        Me.lbl_date_base.TabIndex = 14
        Me.lbl_date_base.Text = "дата и час"
        '
        'lbl_name_base
        '
        Me.lbl_name_base.AutoSize = True
        Me.lbl_name_base.Location = New System.Drawing.Point(137, 18)
        Me.lbl_name_base.Name = "lbl_name_base"
        Me.lbl_name_base.Size = New System.Drawing.Size(27, 13)
        Me.lbl_name_base.TabIndex = 13
        Me.lbl_name_base.Text = "име"
        '
        'cmd_show_test
        '
        Me.cmd_show_test.Location = New System.Drawing.Point(277, 192)
        Me.cmd_show_test.Name = "cmd_show_test"
        Me.cmd_show_test.Size = New System.Drawing.Size(102, 27)
        Me.cmd_show_test.TabIndex = 12
        Me.cmd_show_test.Text = "Прегледай теста"
        Me.cmd_show_test.UseVisualStyleBackColor = True
        '
        'lbl_class
        '
        Me.lbl_class.AutoSize = True
        Me.lbl_class.Location = New System.Drawing.Point(14, 57)
        Me.lbl_class.Name = "lbl_class"
        Me.lbl_class.Size = New System.Drawing.Size(120, 13)
        Me.lbl_class.TabIndex = 11
        Me.lbl_class.Text = "Клас на потребителя: "
        '
        'lbl_mark
        '
        Me.lbl_mark.AutoSize = True
        Me.lbl_mark.Location = New System.Drawing.Point(14, 166)
        Me.lbl_mark.Name = "lbl_mark"
        Me.lbl_mark.Size = New System.Drawing.Size(48, 13)
        Me.lbl_mark.TabIndex = 10
        Me.lbl_mark.Text = "Оценка:"
        '
        'lbl_points
        '
        Me.lbl_points.AutoSize = True
        Me.lbl_points.Location = New System.Drawing.Point(14, 131)
        Me.lbl_points.Name = "lbl_points"
        Me.lbl_points.Size = New System.Drawing.Size(89, 13)
        Me.lbl_points.TabIndex = 9
        Me.lbl_points.Text = "Получени точки:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(14, 95)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(180, 13)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "Ден и час на започване на теста: "
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(14, 18)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(117, 13)
        Me.lbl_name.TabIndex = 7
        Me.lbl_name.Text = "Име на потребителя: "
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(570, 24)
        Me.Menu.TabIndex = 14
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
        'frmTestAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 277)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.fra_info)
        Me.Controls.Add(Me.lst_users)
        Me.Name = "frmTestAdmin"
        Me.Text = "Администрация Тест"
        Me.fra_info.ResumeLayout(False)
        Me.fra_info.PerformLayout()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_users As System.Windows.Forms.ListBox
    Friend WithEvents fra_info As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_show_test As System.Windows.Forms.Button
    Friend WithEvents lbl_class As System.Windows.Forms.Label
    Friend WithEvents lbl_mark As System.Windows.Forms.Label
    Friend WithEvents lbl_points As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_class_base As System.Windows.Forms.Label
    Friend WithEvents lbl_mark_base As System.Windows.Forms.Label
    Friend WithEvents lbl_points_base As System.Windows.Forms.Label
    Friend WithEvents lbl_date_base As System.Windows.Forms.Label
    Friend WithEvents lbl_name_base As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
