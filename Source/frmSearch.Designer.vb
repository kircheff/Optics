<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.rtb_file = New System.Windows.Forms.RichTextBox()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lst_results = New System.Windows.Forms.ListBox()
        Me.Mnu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.Mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(56, 127)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(627, 82)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        '
        'rtb_file
        '
        Me.rtb_file.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.rtb_file.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rtb_file.ForeColor = System.Drawing.SystemColors.Info
        Me.rtb_file.Location = New System.Drawing.Point(56, 290)
        Me.rtb_file.Name = "rtb_file"
        Me.rtb_file.Size = New System.Drawing.Size(627, 226)
        Me.rtb_file.TabIndex = 1
        Me.rtb_file.Text = ""
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(526, 28)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(157, 29)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Търси"
        Me.cmd_search.UseVisualStyleBackColor = True
        Me.cmd_search.Visible = False
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_search.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_search.Location = New System.Drawing.Point(56, 91)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(427, 30)
        Me.txt_search.TabIndex = 3
        Me.txt_search.Text = "Въведете дума за търсене..."
        '
        'lst_results
        '
        Me.lst_results.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lst_results.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lst_results.ForeColor = System.Drawing.SystemColors.Info
        Me.lst_results.ItemHeight = 16
        Me.lst_results.Location = New System.Drawing.Point(56, 127)
        Me.lst_results.Name = "lst_results"
        Me.lst_results.Size = New System.Drawing.Size(627, 148)
        Me.lst_results.TabIndex = 4
        '
        'Mnu
        '
        Me.Mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Mnu.Location = New System.Drawing.Point(0, 0)
        Me.Mnu.Name = "Mnu"
        Me.Mnu.Size = New System.Drawing.Size(750, 24)
        Me.Mnu.TabIndex = 14
        Me.Mnu.Text = "MenuStrip1"
        '
        'НачалнаСтаницаToolStripMenuItem
        '
        Me.НачалнаСтаницаToolStripMenuItem.Name = "НачалнаСтаницаToolStripMenuItem"
        Me.НачалнаСтаницаToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.НачалнаСтаницаToolStripMenuItem.Text = "Начална станица"
        '
        'ПомощToolStripMenuItem
        '
        Me.ПомощToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаПрограматаToolStripMenuItem, Me.ЗаАвторитеToolStripMenuItem, Me.ИзползванаЛитератураToolStripMenuItem})
        Me.ПомощToolStripMenuItem.Name = "ПомощToolStripMenuItem"
        Me.ПомощToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ПомощToolStripMenuItem.Text = "Помощ"
        '
        'ЗаПрограматаToolStripMenuItem
        '
        Me.ЗаПрограматаToolStripMenuItem.Name = "ЗаПрограматаToolStripMenuItem"
        Me.ЗаПрограматаToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ЗаПрограматаToolStripMenuItem.Text = "За програмата"
        '
        'ЗаАвторитеToolStripMenuItem
        '
        Me.ЗаАвторитеToolStripMenuItem.Name = "ЗаАвторитеToolStripMenuItem"
        Me.ЗаАвторитеToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ЗаАвторитеToolStripMenuItem.Text = "За авторите"
        '
        'ИзползванаЛитератураToolStripMenuItem
        '
        Me.ИзползванаЛитератураToolStripMenuItem.Name = "ИзползванаЛитератураToolStripMenuItem"
        Me.ИзползванаЛитератураToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ИзползванаЛитератураToolStripMenuItem.Text = "Използвана литература"
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_search.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_search.Location = New System.Drawing.Point(532, 72)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(168, 19)
        Me.lbl_search.TabIndex = 15
        Me.lbl_search.Text = "           Търси                "
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(750, 576)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.Mnu)
        Me.Controls.Add(Me.lst_results)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.rtb_file)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Търсене"
        Me.Mnu.ResumeLayout(False)
        Me.Mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents rtb_file As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents lst_results As System.Windows.Forms.ListBox
    Friend WithEvents Mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_search As System.Windows.Forms.Label
End Class
