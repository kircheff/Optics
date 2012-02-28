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
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdHistory = New System.Windows.Forms.Button()
        Me.cmdTestAdm = New System.Windows.Forms.Button()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(33, 57)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 0
        '
        'cmdCheck
        '
        Me.cmdCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdCheck.Location = New System.Drawing.Point(189, 57)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(75, 23)
        Me.cmdCheck.TabIndex = 1
        Me.cmdCheck.Text = "Влез"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'cmdDictAdmin
        '
        Me.cmdDictAdmin.Enabled = False
        Me.cmdDictAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
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
        Me.cmdChangePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
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
        Me.cmdResetDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdResetDB.Location = New System.Drawing.Point(33, 225)
        Me.cmdResetDB.Name = "cmdResetDB"
        Me.cmdResetDB.Size = New System.Drawing.Size(231, 41)
        Me.cmdResetDB.TabIndex = 4
        Me.cmdResetDB.Text = "Връщане на базата данни в начално състояние"
        Me.cmdResetDB.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(300, 24)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Въведете своята парола"
        '
        'cmdHistory
        '
        Me.cmdHistory.Enabled = False
        Me.cmdHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdHistory.Location = New System.Drawing.Point(33, 174)
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.Size = New System.Drawing.Size(231, 45)
        Me.cmdHistory.TabIndex = 16
        Me.cmdHistory.Text = "Преглед на хронологията от теста"
        Me.cmdHistory.UseVisualStyleBackColor = True
        '
        'cmdTestAdm
        '
        Me.cmdTestAdm.Enabled = False
        Me.cmdTestAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdTestAdm.Location = New System.Drawing.Point(33, 144)
        Me.cmdTestAdm.Name = "cmdTestAdm"
        Me.cmdTestAdm.Size = New System.Drawing.Size(231, 24)
        Me.cmdTestAdm.TabIndex = 17
        Me.cmdTestAdm.Text = "Администриране на теста"
        Me.cmdTestAdm.UseVisualStyleBackColor = True
        '
        'frmAdminSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 277)
        Me.Controls.Add(Me.cmdTestAdm)
        Me.Controls.Add(Me.cmdHistory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.cmdResetDB)
        Me.Controls.Add(Me.cmdChangePass)
        Me.Controls.Add(Me.cmdDictAdmin)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.txtPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAdminSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Администрация"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdCheck As System.Windows.Forms.Button
    Friend WithEvents cmdDictAdmin As System.Windows.Forms.Button
    Friend WithEvents cmdChangePass As System.Windows.Forms.Button
    Friend WithEvents cmdResetDB As System.Windows.Forms.Button
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdHistory As System.Windows.Forms.Button
    Friend WithEvents cmdTestAdm As System.Windows.Forms.Button
End Class
