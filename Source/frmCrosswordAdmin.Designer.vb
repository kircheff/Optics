<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrossword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrossword))
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.cmdMakeCrossword = New System.Windows.Forms.Button()
        Me.lst_words_vis = New System.Windows.Forms.ListBox()
        Me.lst_pos_vis = New System.Windows.Forms.ListBox()
        Me.lst_izbrani_vis = New System.Windows.Forms.ListBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.cmdClearCrossword = New System.Windows.Forms.Button()
        Me.txtMeanings = New System.Windows.Forms.TextBox()
        Me.cmdCheckCrossword = New System.Windows.Forms.Button()
        Me.txtHints = New System.Windows.Forms.TextBox()
        Me.tmrCombo = New System.Windows.Forms.Timer(Me.components)
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
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(509, 23)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(133, 160)
        Me.lstWords.TabIndex = 9
        Me.lstWords.Visible = False
        '
        'cmdMakeCrossword
        '
        Me.cmdMakeCrossword.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmdMakeCrossword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdMakeCrossword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdMakeCrossword.Location = New System.Drawing.Point(29, 41)
        Me.cmdMakeCrossword.Name = "cmdMakeCrossword"
        Me.cmdMakeCrossword.Size = New System.Drawing.Size(186, 31)
        Me.cmdMakeCrossword.TabIndex = 11
        Me.cmdMakeCrossword.Text = "Генерирай нова кръстословица"
        Me.cmdMakeCrossword.UseVisualStyleBackColor = False
        '
        'lst_words_vis
        '
        Me.lst_words_vis.FormattingEnabled = True
        Me.lst_words_vis.Location = New System.Drawing.Point(648, 23)
        Me.lst_words_vis.Name = "lst_words_vis"
        Me.lst_words_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_words_vis.TabIndex = 12
        Me.lst_words_vis.Visible = False
        '
        'lst_pos_vis
        '
        Me.lst_pos_vis.FormattingEnabled = True
        Me.lst_pos_vis.Location = New System.Drawing.Point(792, 23)
        Me.lst_pos_vis.Name = "lst_pos_vis"
        Me.lst_pos_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_pos_vis.TabIndex = 13
        Me.lst_pos_vis.Visible = False
        '
        'lst_izbrani_vis
        '
        Me.lst_izbrani_vis.FormattingEnabled = True
        Me.lst_izbrani_vis.Location = New System.Drawing.Point(936, 23)
        Me.lst_izbrani_vis.Name = "lst_izbrani_vis"
        Me.lst_izbrani_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_izbrani_vis.TabIndex = 14
        Me.lst_izbrani_vis.Visible = False
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(512, 291)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 20)
        Me.txtMax.TabIndex = 16
        Me.txtMax.Visible = False
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(512, 317)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 20)
        Me.txtMin.TabIndex = 17
        Me.txtMin.Visible = False
        '
        'cmdClearCrossword
        '
        Me.cmdClearCrossword.Location = New System.Drawing.Point(15, 408)
        Me.cmdClearCrossword.Name = "cmdClearCrossword"
        Me.cmdClearCrossword.Size = New System.Drawing.Size(388, 31)
        Me.cmdClearCrossword.TabIndex = 18
        Me.cmdClearCrossword.Text = "Изчисти кръстословица"
        Me.cmdClearCrossword.UseVisualStyleBackColor = True
        Me.cmdClearCrossword.Visible = False
        '
        'txtMeanings
        '
        Me.txtMeanings.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtMeanings.Location = New System.Drawing.Point(524, 41)
        Me.txtMeanings.Multiline = True
        Me.txtMeanings.Name = "txtMeanings"
        Me.txtMeanings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMeanings.Size = New System.Drawing.Size(313, 411)
        Me.txtMeanings.TabIndex = 19
        '
        'cmdCheckCrossword
        '
        Me.cmdCheckCrossword.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmdCheckCrossword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdCheckCrossword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCheckCrossword.Location = New System.Drawing.Point(221, 41)
        Me.cmdCheckCrossword.Name = "cmdCheckCrossword"
        Me.cmdCheckCrossword.Size = New System.Drawing.Size(182, 31)
        Me.cmdCheckCrossword.TabIndex = 20
        Me.cmdCheckCrossword.Text = "Провери кръстословица"
        Me.cmdCheckCrossword.UseVisualStyleBackColor = False
        '
        'txtHints
        '
        Me.txtHints.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtHints.Location = New System.Drawing.Point(29, 78)
        Me.txtHints.Multiline = True
        Me.txtHints.Name = "txtHints"
        Me.txtHints.Size = New System.Drawing.Size(374, 180)
        Me.txtHints.TabIndex = 21
        Me.txtHints.Text = " "
        Me.txtHints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHints.Visible = False
        '
        'tmrCombo
        '
        Me.tmrCombo.Interval = 1
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(849, 24)
        Me.Menu.TabIndex = 22
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
        'frmCrossword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(849, 466)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.txtHints)
        Me.Controls.Add(Me.cmdCheckCrossword)
        Me.Controls.Add(Me.txtMeanings)
        Me.Controls.Add(Me.cmdClearCrossword)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.lst_izbrani_vis)
        Me.Controls.Add(Me.lst_pos_vis)
        Me.Controls.Add(Me.lst_words_vis)
        Me.Controls.Add(Me.cmdMakeCrossword)
        Me.Controls.Add(Me.lstWords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCrossword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Кръстословица"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents cmdMakeCrossword As System.Windows.Forms.Button
    Friend WithEvents lst_words_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_pos_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_izbrani_vis As System.Windows.Forms.ListBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearCrossword As System.Windows.Forms.Button
    Friend WithEvents txtMeanings As System.Windows.Forms.TextBox
    Friend WithEvents cmdCheckCrossword As System.Windows.Forms.Button
    Friend WithEvents txtHints As System.Windows.Forms.TextBox
    Friend WithEvents tmrCombo As System.Windows.Forms.Timer
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
