<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGallerySplash
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
        Me.cmdGoRazprostranenie = New System.Windows.Forms.Button()
        Me.cmdGoOtrajenie = New System.Windows.Forms.Button()
        Me.cmdGoDispersiq = New System.Windows.Forms.Button()
        Me.cmdGoInterferenciq = New System.Windows.Forms.Button()
        Me.cmdGoDifrakciq = New System.Windows.Forms.Button()
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
        'cmdGoRazprostranenie
        '
        Me.cmdGoRazprostranenie.Location = New System.Drawing.Point(53, 52)
        Me.cmdGoRazprostranenie.Name = "cmdGoRazprostranenie"
        Me.cmdGoRazprostranenie.Size = New System.Drawing.Size(116, 28)
        Me.cmdGoRazprostranenie.TabIndex = 0
        Me.cmdGoRazprostranenie.Text = "Разпространение"
        Me.cmdGoRazprostranenie.UseVisualStyleBackColor = True
        '
        'cmdGoOtrajenie
        '
        Me.cmdGoOtrajenie.Location = New System.Drawing.Point(170, 52)
        Me.cmdGoOtrajenie.Name = "cmdGoOtrajenie"
        Me.cmdGoOtrajenie.Size = New System.Drawing.Size(113, 28)
        Me.cmdGoOtrajenie.TabIndex = 1
        Me.cmdGoOtrajenie.Text = "Отражение"
        Me.cmdGoOtrajenie.UseVisualStyleBackColor = True
        '
        'cmdGoDispersiq
        '
        Me.cmdGoDispersiq.Location = New System.Drawing.Point(109, 81)
        Me.cmdGoDispersiq.Name = "cmdGoDispersiq"
        Me.cmdGoDispersiq.Size = New System.Drawing.Size(117, 28)
        Me.cmdGoDispersiq.TabIndex = 2
        Me.cmdGoDispersiq.Text = "Дисперсия"
        Me.cmdGoDispersiq.UseVisualStyleBackColor = True
        '
        'cmdGoInterferenciq
        '
        Me.cmdGoInterferenciq.Location = New System.Drawing.Point(53, 110)
        Me.cmdGoInterferenciq.Name = "cmdGoInterferenciq"
        Me.cmdGoInterferenciq.Size = New System.Drawing.Size(116, 28)
        Me.cmdGoInterferenciq.TabIndex = 3
        Me.cmdGoInterferenciq.Text = "Интерференция"
        Me.cmdGoInterferenciq.UseVisualStyleBackColor = True
        '
        'cmdGoDifrakciq
        '
        Me.cmdGoDifrakciq.Location = New System.Drawing.Point(170, 110)
        Me.cmdGoDifrakciq.Name = "cmdGoDifrakciq"
        Me.cmdGoDifrakciq.Size = New System.Drawing.Size(113, 28)
        Me.cmdGoDifrakciq.TabIndex = 4
        Me.cmdGoDifrakciq.Text = "Дифракция"
        Me.cmdGoDifrakciq.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(346, 24)
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
        'frmGallerySplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 168)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.cmdGoDifrakciq)
        Me.Controls.Add(Me.cmdGoInterferenciq)
        Me.Controls.Add(Me.cmdGoDispersiq)
        Me.Controls.Add(Me.cmdGoOtrajenie)
        Me.Controls.Add(Me.cmdGoRazprostranenie)
        Me.Name = "frmGallerySplash"
        Me.Text = "frmGallerySplash"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGoRazprostranenie As System.Windows.Forms.Button
    Friend WithEvents cmdGoOtrajenie As System.Windows.Forms.Button
    Friend WithEvents cmdGoDispersiq As System.Windows.Forms.Button
    Friend WithEvents cmdGoInterferenciq As System.Windows.Forms.Button
    Friend WithEvents cmdGoDifrakciq As System.Windows.Forms.Button
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
