﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(53, 54)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(341, 20)
        Me.txt_username.TabIndex = 0
        '
        'txt_klas
        '
        Me.txt_klas.Location = New System.Drawing.Point(53, 80)
        Me.txt_klas.Name = "txt_klas"
        Me.txt_klas.Size = New System.Drawing.Size(100, 20)
        Me.txt_klas.TabIndex = 1
        '
        'cmd_forward
        '
        Me.cmd_forward.Location = New System.Drawing.Point(400, 51)
        Me.cmd_forward.Name = "cmd_forward"
        Me.cmd_forward.Size = New System.Drawing.Size(75, 23)
        Me.cmd_forward.TabIndex = 2
        Me.cmd_forward.Text = "Напред"
        Me.cmd_forward.UseVisualStyleBackColor = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(12, 61)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(32, 13)
        Me.lbl_username.TabIndex = 3
        Me.lbl_username.Text = "Име:"
        '
        'lbl_klas
        '
        Me.lbl_klas.AutoSize = True
        Me.lbl_klas.Location = New System.Drawing.Point(12, 83)
        Me.lbl_klas.Name = "lbl_klas"
        Me.lbl_klas.Size = New System.Drawing.Size(35, 13)
        Me.lbl_klas.TabIndex = 4
        Me.lbl_klas.Text = "Клас:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "(не е задължителен)"
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(487, 24)
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
        'frmTestSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 132)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_klas)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.cmd_forward)
        Me.Controls.Add(Me.txt_klas)
        Me.Controls.Add(Me.txt_username)
        Me.Name = "frmTestSplash"
        Me.Text = "Form1"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_klas As System.Windows.Forms.TextBox
    Friend WithEvents cmd_forward As System.Windows.Forms.Button
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_klas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
