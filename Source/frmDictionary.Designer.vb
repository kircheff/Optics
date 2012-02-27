<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDictionary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDictionary))
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstWordsResults = New System.Windows.Forms.ListBox()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWord2 = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lstWords.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lstWords.ForeColor = System.Drawing.SystemColors.Info
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 20
        Me.lstWords.Location = New System.Drawing.Point(41, 139)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(194, 364)
        Me.lstWords.TabIndex = 0
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(178, 48)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(0, 13)
        Me.lblWord.TabIndex = 1
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.BackColor = System.Drawing.Color.Transparent
        Me.lblMeaning.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMeaning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMeaning.Location = New System.Drawing.Point(348, 241)
        Me.lblMeaning.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(0, 20)
        Me.lblMeaning.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(41, 102)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(194, 25)
        Me.txtSearch.TabIndex = 3
        '
        'lstWordsResults
        '
        Me.lstWordsResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lstWordsResults.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lstWordsResults.ForeColor = System.Drawing.SystemColors.Info
        Me.lstWordsResults.FormattingEnabled = True
        Me.lstWordsResults.ItemHeight = 20
        Me.lstWordsResults.Location = New System.Drawing.Point(41, 139)
        Me.lstWordsResults.Name = "lstWordsResults"
        Me.lstWordsResults.Size = New System.Drawing.Size(194, 384)
        Me.lstWordsResults.TabIndex = 4
        Me.lstWordsResults.Visible = False
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(750, 24)
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
        'lblWord2
        '
        Me.lblWord2.AutoSize = True
        Me.lblWord2.BackColor = System.Drawing.Color.Transparent
        Me.lblWord2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblWord2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWord2.Location = New System.Drawing.Point(310, 109)
        Me.lblWord2.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblWord2.Name = "lblWord2"
        Me.lblWord2.Size = New System.Drawing.Size(0, 23)
        Me.lblWord2.TabIndex = 15
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(750, 574)
        Me.Controls.Add(Me.lblWord2)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.lstWordsResults)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmDictionary"
        Me.Text = "Речник"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstWordsResults As System.Windows.Forms.ListBox
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWord2 As System.Windows.Forms.Label
End Class
