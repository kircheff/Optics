﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneral))
        Me.Mnu = New System.Windows.Forms.MenuStrip()
        Me.ТеорияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УрочниСтатииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РечникToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПровериЗнаниятаСиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТестToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КръстословицаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗабавноToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИграToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ГалерияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КалкулаторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АдминПанелToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_diction = New System.Windows.Forms.PictureBox()
        Me.pic_crossword = New System.Windows.Forms.PictureBox()
        Me.pic_info = New System.Windows.Forms.PictureBox()
        Me.pic_search = New System.Windows.Forms.PictureBox()
        Me.pic_test = New System.Windows.Forms.PictureBox()
        Me.pic_admin = New System.Windows.Forms.PictureBox()
        Me.pic_gallery = New System.Windows.Forms.PictureBox()
        Me.pic_calc = New System.Windows.Forms.PictureBox()
        Me.pic_arrow = New System.Windows.Forms.PictureBox()
        Me.pic_game = New System.Windows.Forms.PictureBox()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.Mnu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_diction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_crossword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_test, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_gallery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_calc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_game, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mnu
        '
        Me.Mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ТеорияToolStripMenuItem, Me.ПровериЗнаниятаСиToolStripMenuItem, Me.ЗабавноToolStripMenuItem, Me.КалкулаторToolStripMenuItem, Me.АдминПанелToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Mnu.Location = New System.Drawing.Point(0, 0)
        Me.Mnu.Name = "Mnu"
        Me.Mnu.Size = New System.Drawing.Size(642, 24)
        Me.Mnu.TabIndex = 10
        Me.Mnu.Text = "MenuStrip1"
        '
        'ТеорияToolStripMenuItem
        '
        Me.ТеорияToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УрочниСтатииToolStripMenuItem, Me.РечникToolStripMenuItem})
        Me.ТеорияToolStripMenuItem.Name = "ТеорияToolStripMenuItem"
        Me.ТеорияToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ТеорияToolStripMenuItem.Text = "Теория"
        '
        'УрочниСтатииToolStripMenuItem
        '
        Me.УрочниСтатииToolStripMenuItem.Name = "УрочниСтатииToolStripMenuItem"
        Me.УрочниСтатииToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.УрочниСтатииToolStripMenuItem.Text = "Урочни статии"
        '
        'РечникToolStripMenuItem
        '
        Me.РечникToolStripMenuItem.Name = "РечникToolStripMenuItem"
        Me.РечникToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.РечникToolStripMenuItem.Text = "Речник"
        '
        'ПровериЗнаниятаСиToolStripMenuItem
        '
        Me.ПровериЗнаниятаСиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ТестToolStripMenuItem, Me.КръстословицаToolStripMenuItem})
        Me.ПровериЗнаниятаСиToolStripMenuItem.Name = "ПровериЗнаниятаСиToolStripMenuItem"
        Me.ПровериЗнаниятаСиToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.ПровериЗнаниятаСиToolStripMenuItem.Text = "Провери знанията си"
        '
        'ТестToolStripMenuItem
        '
        Me.ТестToolStripMenuItem.Name = "ТестToolStripMenuItem"
        Me.ТестToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ТестToolStripMenuItem.Text = "Тест"
        '
        'КръстословицаToolStripMenuItem
        '
        Me.КръстословицаToolStripMenuItem.Name = "КръстословицаToolStripMenuItem"
        Me.КръстословицаToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.КръстословицаToolStripMenuItem.Text = "Кръстословица"
        '
        'ЗабавноToolStripMenuItem
        '
        Me.ЗабавноToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИграToolStripMenuItem, Me.ГалерияToolStripMenuItem})
        Me.ЗабавноToolStripMenuItem.Name = "ЗабавноToolStripMenuItem"
        Me.ЗабавноToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ЗабавноToolStripMenuItem.Text = "Забавно"
        '
        'ИграToolStripMenuItem
        '
        Me.ИграToolStripMenuItem.Name = "ИграToolStripMenuItem"
        Me.ИграToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ИграToolStripMenuItem.Text = "Игра"
        '
        'ГалерияToolStripMenuItem
        '
        Me.ГалерияToolStripMenuItem.Name = "ГалерияToolStripMenuItem"
        Me.ГалерияToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ГалерияToolStripMenuItem.Text = "Галерия"
        '
        'КалкулаторToolStripMenuItem
        '
        Me.КалкулаторToolStripMenuItem.Name = "КалкулаторToolStripMenuItem"
        Me.КалкулаторToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.КалкулаторToolStripMenuItem.Text = "Калкулатор"
        '
        'АдминПанелToolStripMenuItem
        '
        Me.АдминПанелToolStripMenuItem.Name = "АдминПанелToolStripMenuItem"
        Me.АдминПанелToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.АдминПанелToolStripMenuItem.Text = "Админ панел"
        '
        'ТърсенеToolStripMenuItem
        '
        Me.ТърсенеToolStripMenuItem.Name = "ТърсенеToolStripMenuItem"
        Me.ТърсенеToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ТърсенеToolStripMenuItem.Text = "Търсене "
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(484, -102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 569)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pic_diction
        '
        Me.pic_diction.BackColor = System.Drawing.Color.Transparent
        Me.pic_diction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_diction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_diction.Image = CType(resources.GetObject("pic_diction.Image"), System.Drawing.Image)
        Me.pic_diction.Location = New System.Drawing.Point(40, 27)
        Me.pic_diction.Name = "pic_diction"
        Me.pic_diction.Size = New System.Drawing.Size(422, 42)
        Me.pic_diction.TabIndex = 12
        Me.pic_diction.TabStop = False
        '
        'pic_crossword
        '
        Me.pic_crossword.BackColor = System.Drawing.Color.Transparent
        Me.pic_crossword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_crossword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_crossword.Image = CType(resources.GetObject("pic_crossword.Image"), System.Drawing.Image)
        Me.pic_crossword.Location = New System.Drawing.Point(40, 75)
        Me.pic_crossword.Name = "pic_crossword"
        Me.pic_crossword.Size = New System.Drawing.Size(422, 42)
        Me.pic_crossword.TabIndex = 13
        Me.pic_crossword.TabStop = False
        '
        'pic_info
        '
        Me.pic_info.BackColor = System.Drawing.Color.Transparent
        Me.pic_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_info.Image = CType(resources.GetObject("pic_info.Image"), System.Drawing.Image)
        Me.pic_info.Location = New System.Drawing.Point(40, 123)
        Me.pic_info.Name = "pic_info"
        Me.pic_info.Size = New System.Drawing.Size(422, 42)
        Me.pic_info.TabIndex = 14
        Me.pic_info.TabStop = False
        '
        'pic_search
        '
        Me.pic_search.BackColor = System.Drawing.Color.Transparent
        Me.pic_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_search.Image = CType(resources.GetObject("pic_search.Image"), System.Drawing.Image)
        Me.pic_search.Location = New System.Drawing.Point(40, 171)
        Me.pic_search.Name = "pic_search"
        Me.pic_search.Size = New System.Drawing.Size(422, 42)
        Me.pic_search.TabIndex = 15
        Me.pic_search.TabStop = False
        '
        'pic_test
        '
        Me.pic_test.BackColor = System.Drawing.Color.Transparent
        Me.pic_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_test.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_test.Image = CType(resources.GetObject("pic_test.Image"), System.Drawing.Image)
        Me.pic_test.Location = New System.Drawing.Point(40, 219)
        Me.pic_test.Name = "pic_test"
        Me.pic_test.Size = New System.Drawing.Size(422, 42)
        Me.pic_test.TabIndex = 16
        Me.pic_test.TabStop = False
        '
        'pic_admin
        '
        Me.pic_admin.BackColor = System.Drawing.Color.Transparent
        Me.pic_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_admin.Image = CType(resources.GetObject("pic_admin.Image"), System.Drawing.Image)
        Me.pic_admin.Location = New System.Drawing.Point(40, 267)
        Me.pic_admin.Name = "pic_admin"
        Me.pic_admin.Size = New System.Drawing.Size(422, 42)
        Me.pic_admin.TabIndex = 17
        Me.pic_admin.TabStop = False
        '
        'pic_gallery
        '
        Me.pic_gallery.BackColor = System.Drawing.Color.Transparent
        Me.pic_gallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_gallery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_gallery.Image = CType(resources.GetObject("pic_gallery.Image"), System.Drawing.Image)
        Me.pic_gallery.Location = New System.Drawing.Point(40, 315)
        Me.pic_gallery.Name = "pic_gallery"
        Me.pic_gallery.Size = New System.Drawing.Size(422, 42)
        Me.pic_gallery.TabIndex = 18
        Me.pic_gallery.TabStop = False
        '
        'pic_calc
        '
        Me.pic_calc.BackColor = System.Drawing.Color.Transparent
        Me.pic_calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_calc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_calc.Image = CType(resources.GetObject("pic_calc.Image"), System.Drawing.Image)
        Me.pic_calc.Location = New System.Drawing.Point(40, 363)
        Me.pic_calc.Name = "pic_calc"
        Me.pic_calc.Size = New System.Drawing.Size(422, 42)
        Me.pic_calc.TabIndex = 19
        Me.pic_calc.TabStop = False
        '
        'pic_arrow
        '
        Me.pic_arrow.BackColor = System.Drawing.Color.Transparent
        Me.pic_arrow.Image = CType(resources.GetObject("pic_arrow.Image"), System.Drawing.Image)
        Me.pic_arrow.Location = New System.Drawing.Point(-580, 450)
        Me.pic_arrow.Name = "pic_arrow"
        Me.pic_arrow.Size = New System.Drawing.Size(562, 97)
        Me.pic_arrow.TabIndex = 20
        Me.pic_arrow.TabStop = False
        '
        'pic_game
        '
        Me.pic_game.BackColor = System.Drawing.Color.Transparent
        Me.pic_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_game.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_game.Image = CType(resources.GetObject("pic_game.Image"), System.Drawing.Image)
        Me.pic_game.Location = New System.Drawing.Point(40, 411)
        Me.pic_game.Name = "pic_game"
        Me.pic_game.Size = New System.Drawing.Size(422, 42)
        Me.pic_game.TabIndex = 21
        Me.pic_game.TabStop = False
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 50
        '
        'frmGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(642, 573)
        Me.Controls.Add(Me.pic_game)
        Me.Controls.Add(Me.pic_arrow)
        Me.Controls.Add(Me.pic_calc)
        Me.Controls.Add(Me.pic_gallery)
        Me.Controls.Add(Me.pic_admin)
        Me.Controls.Add(Me.pic_test)
        Me.Controls.Add(Me.pic_search)
        Me.Controls.Add(Me.pic_info)
        Me.Controls.Add(Me.pic_crossword)
        Me.Controls.Add(Me.pic_diction)
        Me.Controls.Add(Me.Mnu)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Mnu
        Me.MaximizeBox = False
        Me.Name = "frmGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Начална страница"
        Me.Mnu.ResumeLayout(False)
        Me.Mnu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_diction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_crossword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_test, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_gallery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_calc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_game, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents КалкулаторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents АдминПанелToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТеорияToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УрочниСтатииToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РечникToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПровериЗнаниятаСиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТестToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КръстословицаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗабавноToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИграToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ГалерияToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_diction As System.Windows.Forms.PictureBox
    Friend WithEvents pic_crossword As System.Windows.Forms.PictureBox
    Friend WithEvents pic_info As System.Windows.Forms.PictureBox
    Friend WithEvents pic_search As System.Windows.Forms.PictureBox
    Friend WithEvents pic_test As System.Windows.Forms.PictureBox
    Friend WithEvents pic_admin As System.Windows.Forms.PictureBox
    Friend WithEvents pic_gallery As System.Windows.Forms.PictureBox
    Friend WithEvents pic_calc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_arrow As System.Windows.Forms.PictureBox
    Friend WithEvents pic_game As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMove As System.Windows.Forms.Timer

End Class
