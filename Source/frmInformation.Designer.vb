<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformation))
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.trv_info = New System.Windows.Forms.TreeView()
        Me.tmrMovePanelIn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovePanelOut = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.rtb_info = New System.Windows.Forms.RichTextBox()
        Me.pic_notes = New System.Windows.Forms.PictureBox()
        Me.pic_save = New System.Windows.Forms.PictureBox()
        Me.pic_font = New System.Windows.Forms.PictureBox()
        Me.pic_color = New System.Windows.Forms.PictureBox()
        Me.pic_print = New System.Windows.Forms.PictureBox()
        Me.pic_gallery = New System.Windows.Forms.PictureBox()
        Me.pic_waves = New System.Windows.Forms.PictureBox()
        Me.pic_circle = New System.Windows.Forms.PictureBox()
        Me.pic_up = New System.Windows.Forms.PictureBox()
        Me.pic_down = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_menu.SuspendLayout()
        CType(Me.pic_notes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_font, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_gallery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_waves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_circle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_up, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_down, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.CadetBlue
        Me.pnl_menu.BackgroundImage = CType(resources.GetObject("pnl_menu.BackgroundImage"), System.Drawing.Image)
        Me.pnl_menu.Controls.Add(Me.trv_info)
        Me.pnl_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnl_menu.Location = New System.Drawing.Point(-240, 47)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(290, 514)
        Me.pnl_menu.TabIndex = 312
        '
        'trv_info
        '
        Me.trv_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.trv_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.trv_info.ForeColor = System.Drawing.SystemColors.Info
        Me.trv_info.FullRowSelect = True
        Me.trv_info.Indent = 13
        Me.trv_info.ItemHeight = 27
        Me.trv_info.LabelEdit = True
        Me.trv_info.LineColor = System.Drawing.Color.White
        Me.trv_info.Location = New System.Drawing.Point(0, 19)
        Me.trv_info.Name = "trv_info"
        Me.trv_info.Scrollable = False
        Me.trv_info.ShowPlusMinus = False
        Me.trv_info.Size = New System.Drawing.Size(240, 479)
        Me.trv_info.TabIndex = 7
        Me.trv_info.TabStop = False
        '
        'tmrMovePanelIn
        '
        Me.tmrMovePanelIn.Interval = 50
        '
        'tmrMovePanelOut
        '
        Me.tmrMovePanelOut.Interval = 50
        '
        'rtb_info
        '
        Me.rtb_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.rtb_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_info.Location = New System.Drawing.Point(326, 113)
        Me.rtb_info.Name = "rtb_info"
        Me.rtb_info.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_info.Size = New System.Drawing.Size(341, 277)
        Me.rtb_info.TabIndex = 0
        Me.rtb_info.Text = ""
        '
        'pic_notes
        '
        Me.pic_notes.BackColor = System.Drawing.Color.Transparent
        Me.pic_notes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_notes.Image = CType(resources.GetObject("pic_notes.Image"), System.Drawing.Image)
        Me.pic_notes.Location = New System.Drawing.Point(312, 475)
        Me.pic_notes.Name = "pic_notes"
        Me.pic_notes.Size = New System.Drawing.Size(65, 61)
        Me.pic_notes.TabIndex = 12
        Me.pic_notes.TabStop = False
        '
        'pic_save
        '
        Me.pic_save.BackColor = System.Drawing.Color.Transparent
        Me.pic_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_save.Image = CType(resources.GetObject("pic_save.Image"), System.Drawing.Image)
        Me.pic_save.Location = New System.Drawing.Point(474, 475)
        Me.pic_save.Name = "pic_save"
        Me.pic_save.Size = New System.Drawing.Size(71, 61)
        Me.pic_save.TabIndex = 14
        Me.pic_save.TabStop = False
        '
        'pic_font
        '
        Me.pic_font.BackColor = System.Drawing.Color.Transparent
        Me.pic_font.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_font.Image = CType(resources.GetObject("pic_font.Image"), System.Drawing.Image)
        Me.pic_font.Location = New System.Drawing.Point(616, 475)
        Me.pic_font.Name = "pic_font"
        Me.pic_font.Size = New System.Drawing.Size(73, 61)
        Me.pic_font.TabIndex = 15
        Me.pic_font.TabStop = False
        '
        'pic_color
        '
        Me.pic_color.BackColor = System.Drawing.Color.Transparent
        Me.pic_color.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_color.Image = CType(resources.GetObject("pic_color.Image"), System.Drawing.Image)
        Me.pic_color.Location = New System.Drawing.Point(551, 475)
        Me.pic_color.Name = "pic_color"
        Me.pic_color.Size = New System.Drawing.Size(59, 61)
        Me.pic_color.TabIndex = 16
        Me.pic_color.TabStop = False
        '
        'pic_print
        '
        Me.pic_print.BackColor = System.Drawing.Color.Transparent
        Me.pic_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_print.Image = CType(resources.GetObject("pic_print.Image"), System.Drawing.Image)
        Me.pic_print.Location = New System.Drawing.Point(383, 475)
        Me.pic_print.Name = "pic_print"
        Me.pic_print.Size = New System.Drawing.Size(85, 61)
        Me.pic_print.TabIndex = 17
        Me.pic_print.TabStop = False
        '
        'pic_gallery
        '
        Me.pic_gallery.BackColor = System.Drawing.Color.Transparent
        Me.pic_gallery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_gallery.Image = CType(resources.GetObject("pic_gallery.Image"), System.Drawing.Image)
        Me.pic_gallery.Location = New System.Drawing.Point(43, 326)
        Me.pic_gallery.Name = "pic_gallery"
        Me.pic_gallery.Size = New System.Drawing.Size(248, 77)
        Me.pic_gallery.TabIndex = 20
        Me.pic_gallery.TabStop = False
        '
        'pic_waves
        '
        Me.pic_waves.BackColor = System.Drawing.Color.Transparent
        Me.pic_waves.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_waves.Image = CType(resources.GetObject("pic_waves.Image"), System.Drawing.Image)
        Me.pic_waves.Location = New System.Drawing.Point(43, 222)
        Me.pic_waves.Name = "pic_waves"
        Me.pic_waves.Size = New System.Drawing.Size(248, 76)
        Me.pic_waves.TabIndex = 19
        Me.pic_waves.TabStop = False
        '
        'pic_circle
        '
        Me.pic_circle.BackColor = System.Drawing.Color.Transparent
        Me.pic_circle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_circle.Image = CType(resources.GetObject("pic_circle.Image"), System.Drawing.Image)
        Me.pic_circle.Location = New System.Drawing.Point(43, 122)
        Me.pic_circle.Name = "pic_circle"
        Me.pic_circle.Size = New System.Drawing.Size(248, 75)
        Me.pic_circle.TabIndex = 18
        Me.pic_circle.TabStop = False
        '
        'pic_up
        '
        Me.pic_up.BackColor = System.Drawing.Color.Transparent
        Me.pic_up.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_up.Location = New System.Drawing.Point(433, 422)
        Me.pic_up.Name = "pic_up"
        Me.pic_up.Size = New System.Drawing.Size(62, 41)
        Me.pic_up.TabIndex = 21
        Me.pic_up.TabStop = False
        '
        'pic_down
        '
        Me.pic_down.BackColor = System.Drawing.Color.Transparent
        Me.pic_down.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_down.Location = New System.Drawing.Point(499, 422)
        Me.pic_down.Name = "pic_down"
        Me.pic_down.Size = New System.Drawing.Size(62, 41)
        Me.pic_down.TabIndex = 22
        Me.pic_down.TabStop = False
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(750, 24)
        Me.Menu.TabIndex = 313
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
        'frmInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(750, 576)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.pic_down)
        Me.Controls.Add(Me.pic_up)
        Me.Controls.Add(Me.pnl_menu)
        Me.Controls.Add(Me.pic_gallery)
        Me.Controls.Add(Me.pic_waves)
        Me.Controls.Add(Me.pic_circle)
        Me.Controls.Add(Me.pic_print)
        Me.Controls.Add(Me.pic_color)
        Me.Controls.Add(Me.pic_font)
        Me.Controls.Add(Me.pic_save)
        Me.Controls.Add(Me.pic_notes)
        Me.Controls.Add(Me.rtb_info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Информация"
        Me.pnl_menu.ResumeLayout(False)
        CType(Me.pic_notes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_font, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_gallery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_waves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_circle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_up, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_down, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents trv_info As System.Windows.Forms.TreeView
    Friend WithEvents tmrMovePanelIn As System.Windows.Forms.Timer
    Friend WithEvents tmrMovePanelOut As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents rtb_info As System.Windows.Forms.RichTextBox
    Friend WithEvents pic_notes As System.Windows.Forms.PictureBox
    Friend WithEvents pic_save As System.Windows.Forms.PictureBox
    Friend WithEvents pic_font As System.Windows.Forms.PictureBox
    Friend WithEvents pic_color As System.Windows.Forms.PictureBox
    Friend WithEvents pic_print As System.Windows.Forms.PictureBox
    Friend WithEvents pic_gallery As System.Windows.Forms.PictureBox
    Friend WithEvents pic_waves As System.Windows.Forms.PictureBox
    Friend WithEvents pic_circle As System.Windows.Forms.PictureBox
    Friend WithEvents pic_up As System.Windows.Forms.PictureBox
    Friend WithEvents pic_down As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
