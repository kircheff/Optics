Imports System.IO

Public Class frmInformation
    Inherits System.Windows.Forms.Form

    'Променливи за връзка с базата данни
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs_information As New OleDb.OleDbDataAdapter("SELECT * FROM information", con)
    Dim rs_tochki As New OleDb.OleDbDataAdapter("SELECT * FROM tochki", con)

    Dim numOfMoves As Byte = 0
    Dim opened As Boolean = False
    Dim openedFile As String = AppDomain.CurrentDomain.BaseDirectory & "Info\Razprostranenie\1.rtf"
    Dim notesFile As String = AppDomain.CurrentDomain.BaseDirectory & "Info\Razprostranenie\1_temp.rtf"

    Dim notesSelected As Boolean = False
    Dim custRow As DataRow
    Dim orderRow As DataRow
    Private m_nFirstCharOnPage As Integer

    Private Sub areNotesOpened()
        If notesSelected = True Then
            Dim response As VariantType
            response = MsgBox("Не сте запаметили бележките. Искате ли да ги запаметите?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Внимание!")
            If response = vbYes Then
                rtb_info.SaveFile(notesFile)
                rtb_info.LoadFile(openedFile)
                rtb_info.ReadOnly = True
                notesSelected = False
            Else
                notesSelected = False
                rtb_info.LoadFile(openedFile)
                rtb_info.ReadOnly = True
            End If
            ToolTip1.SetToolTip(Me.pic_notes, "Отвори бележки")
        End If
    End Sub

    Private Sub frmInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs_information.Fill(ds, "information")
        rs_tochki.Fill(ds, "tochki")
        'pnl_menu.Parent = Me
        'pnl_menu.BackColor = Color.Transparent
        Dim datarel As DataRelation = ds.Relations.Add("Infotochka", _
                      ds.Tables("information").Columns("ID"), _
                      ds.Tables("tochki").Columns("tochka_urok"))

        Dim i As Byte = 0
        For Each Me.custRow In ds.Tables("information").Rows

            trv_info.Nodes.Add(custRow.Item("statia"))
            For Each Me.orderRow In custRow.GetChildRows(datarel)
                trv_info.Nodes(custRow.Item("Id") - 1).Nodes.Add(orderRow.Item("tochka_ime"))
            Next

        Next
        rtb_info.LoadFile(openedFile)
        chosenGallery = "Info\Razprostranenie"
    End Sub



    Private Sub pnl_menu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl_menu.MouseHover
        If opened = False Then
            tmrMovePanelIn.Start()
        End If

    End Sub
    Sub moveImages(ByVal destination As String)
        If destination = "Right" Then

            pnl_menu.Left = pnl_menu.Left - 40

        ElseIf destination = "Left" Then

            pnl_menu.Left = pnl_menu.Left + 40

        End If
    End Sub

    Private Sub tmrMovePanelIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovePanelIn.Tick
        numOfMoves = numOfMoves + 1
        moveImages("Left")
        If numOfMoves = 6 Then

            numOfMoves = 0
            tmrMovePanelIn.Stop()
            opened = True
        End If
    End Sub

    Private Sub tmrMovePanelOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovePanelOut.Tick
        numOfMoves = numOfMoves + 1
        moveImages("Right")
        If numOfMoves = 6 Then

            numOfMoves = 0
            tmrMovePanelOut.Stop()
            opened = False
        End If
    End Sub

    Private Sub pnl_menu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl_menu.MouseLeave
        If opened = True Then
            tmrMovePanelOut.Start()
        End If
        rtb_info.Focus()
    End Sub


    Private Sub trv_info_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_info.AfterSelect
        Dim datarel As DataRelation = ds.Relations.Item("Infotochka")


        Try


            Dim selected_node As String
            selected_node = trv_info.SelectedNode.Text.ToString()
            For Each Me.custRow In ds.Tables("information").Rows
                For Each Me.orderRow In custRow.GetChildRows(datarel)
                    If selected_node = Me.orderRow.Item("tochka_ime") Then
                        If notesSelected = True Then
                            Dim response As VariantType
                            response = MsgBox("Не сте запаметили бележките. Искате ли да ги запаметите?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Внимание!")
                            If response = vbYes Then
                                rtb_info.SaveFile(notesFile)
                                rtb_info.LoadFile(openedFile)

                                notesSelected = False
                                ToolTip1.SetToolTip(Me.pic_notes, "Отвори бележки")
                                rtb_info.Focus()
                            Else
                                notesSelected = False
                                ToolTip1.SetToolTip(Me.pic_notes, "Отвори бележки")
                                rtb_info.Focus()
                            End If
                        End If
                        notesFile = AppDomain.CurrentDomain.BaseDirectory & custRow.Item("Directory").ToString & "\" & orderRow.Item("tochka_podredba") & "_temp.rtf"
                        openedFile = AppDomain.CurrentDomain.BaseDirectory & custRow.Item("Directory").ToString & "\" & orderRow.Item("tochka_podredba") & ".rtf"
                        chosenGallery = custRow.Item("Directory").ToString
                        rtb_info.LoadFile(openedFile)
                        rtb_info.ReadOnly = True
                        rtb_info.Focus()

                    End If
                Next

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rtb_info.Focus()
    End Sub

    Private Sub trv_info_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trv_info.BeforeExpand
        trv_info.CollapseAll()
    End Sub

    Private Sub pic_color_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_color.MouseHover
        pic_color.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_color_hover.png")
        ToolTip1.SetToolTip(Me.pic_color, "Смени цвета")
    End Sub

    Private Sub pic_color_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_color.MouseLeave
        pic_color.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_color.png")
    End Sub

    Private Sub pic_font_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_font.MouseHover
        pic_font.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_font_hover.png")
        ToolTip1.SetToolTip(Me.pic_font, "Смени шрифта")
    End Sub

    Private Sub pic_font_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_font.MouseLeave
        pic_font.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_font.png")
    End Sub

    Private Sub pic_notes_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_notes.MouseHover
        pic_notes.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_notes_hover.png")
        If notesSelected = False Then

            ToolTip1.SetToolTip(Me.pic_notes, "Отвори бележки")
        Else

            ToolTip1.SetToolTip(Me.pic_notes, "Запази бележки")
        End If
    End Sub

    Private Sub pic_notes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_notes.MouseLeave
        pic_notes.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_notes.png")
    End Sub

    Private Sub pic_print_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_print.MouseHover
        pic_print.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_print_hover.png")
        ToolTip1.SetToolTip(Me.pic_print, "Принтирай")
    End Sub

    Private Sub pic_print_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_print.MouseLeave
        pic_print.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_print.png")
    End Sub

    Private Sub pic_save_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_save.MouseHover
        pic_save.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_save_hover.png")
        ToolTip1.SetToolTip(Me.pic_save, "Запиши")
    End Sub

    Private Sub pic_save_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_save.MouseLeave
        pic_save.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\icon_save.png")
    End Sub



    Private Sub pic_circle_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_circle.MouseHover
        pic_circle.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\button_circle_hover.png")
    End Sub

    Private Sub pic_circle_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_circle.MouseLeave
        pic_circle.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\button_circle.png")
    End Sub

    Private Sub pic_waves_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_waves.MouseHover
        pic_waves.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\button_waves_hover.png")
    End Sub

    Private Sub pic_waves_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_waves.MouseLeave
        pic_waves.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\button_waves.png")
    End Sub

    Private Sub pic_gallery_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_gallery.MouseHover
        pic_gallery.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\button_gallery_hover.png")
    End Sub

    Private Sub pic_gallery_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_gallery.MouseLeave
        pic_gallery.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Info\button_gallery.png")
    End Sub

    Private Sub pic_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_print.Click
        areNotesOpened()

        Dim MyPrintObject As New TextPrint(rtb_info.Text)

        MyPrintObject.Font = New Font("Tahoma", 8)

        MyPrintObject.Print()
    End Sub

    Private Sub pic_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_save.Click
        areNotesOpened()

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            File.Copy(openedFile, saveFileDialog1.FileName, True)

        End If
    End Sub

    Private Sub pic_color_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_color.Click
        ColorDialog1.ShowDialog()
        rtb_info.Select(0, rtb_info.TextLength)
        rtb_info.SelectionColor = ColorDialog1.Color

    End Sub

    Private Sub pic_font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_font.Click
        FontDialog1.ShowDialog()
        rtb_info.Font = FontDialog1.Font
    End Sub

    Private Sub pic_notes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_notes.Click
        If notesSelected = False Then
            rtb_info.LoadFile(notesFile)
            rtb_info.ReadOnly = False

            notesSelected = True

        Else
            notesSelected = False
            rtb_info.ReadOnly = True
            rtb_info.SaveFile(notesFile)
            rtb_info.LoadFile(openedFile)
        End If
    End Sub

    Private Sub pic_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_up.Click
        rtb_info.Focus()
        SendKeys.Send("{UP}{UP}{UP}{UP}{UP}{UP}{UP}{UP}{UP}{UP}{UP}{UP}")
    End Sub

    Private Sub pic_down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_down.Click
        rtb_info.Focus()
        SendKeys.Send("{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}")
    End Sub

    Private Sub pic_up_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_up.MouseHover
        ToolTip1.SetToolTip(Me.pic_up, "Нагоре")
    End Sub

    Private Sub pic_down_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_down.MouseHover
        ToolTip1.SetToolTip(Me.pic_down, "Надолу")
    End Sub


    Private Sub pic_circle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_circle.Click
        frmCircle.Show()
    End Sub

    Private Sub pic_waves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_waves.Click
        frmWaves.Show()
    End Sub

    Private Sub pic_gallery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_gallery.Click
        frmGallery.Show()
    End Sub
End Class