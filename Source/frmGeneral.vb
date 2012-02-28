Public Class frmGeneral
    Dim destination As String
    Dim numOfMoves As Byte = 0
    Dim visibleImageIndex As Integer = 0



    Private Sub УрочниСтатииToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УрочниСтатииToolStripMenuItem.Click

        frmInformation.Show()

    End Sub

    Private Sub РечникToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РечникToolStripMenuItem.Click
        frmDictionary.Show()

    End Sub

    Private Sub ТестToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТестToolStripMenuItem.Click
        frmTest.Show()

    End Sub

    Private Sub КръстословицаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КръстословицаToolStripMenuItem.Click
        frmCrossword.Show()

    End Sub

    Private Sub ИграToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИграToolStripMenuItem.Click
        frmGame.Show()

    End Sub

    Private Sub ГалерияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ГалерияToolStripMenuItem.Click
        frmGallery.Show()

    End Sub

    Private Sub КалкулаторToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КалкулаторToolStripMenuItem.Click
        frmCalculator.Show()

    End Sub

    Private Sub АдминПанелToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles АдминПанелToolStripMenuItem.Click
        frmAdminSplash.Show()

    End Sub

    Private Sub ТърсенеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТърсенеToolStripMenuItem.Click
        frmSearch.Show()

    End Sub

    Private Sub ЗаПрограматаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаПрограматаToolStripMenuItem.Click
        frmInfoProgram.Show()

    End Sub

    Private Sub ЗаАвторитеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаАвторитеToolStripMenuItem.Click
        frmInfoUs.Show()

    End Sub

    Private Sub ИзползванаЛитератураToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзползванаЛитератураToolStripMenuItem.Click
        frmInfoLit.Show()

    End Sub

    Private Sub frmGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Разположение на дясна стрелка: -30, 450
        'Разположение на горна стрелка: 510, -35

    End Sub

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick

        numOfMoves = numOfMoves + 1
        moveImages(destination)
        If numOfMoves = 10 Then

            numOfMoves = 0
            tmrMove.Stop()

        End If
    End Sub

    Sub moveImages(ByVal destination As String)
        If destination = "Right" Then

            pic_arrow.Left = pic_arrow.Left - 50

        ElseIf destination = "Left" Then

            pic_arrow.Left = pic_arrow.Left + 50

        End If
    End Sub

    Private Sub pic_diction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_diction.Click
        frmDictionary.Show()

    End Sub

    Private Sub pic_diction_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_diction.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_dictionary.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_diction_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_diction.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_crossword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_crossword.Click
        frmCrossword.Show()
    End Sub

    Private Sub pic_crossword_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_crossword.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_crossword.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_crossword_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_crossword.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_gallery_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_gallery.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_gallery.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_gallery_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_gallery.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_info_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_info.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_info.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_info_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_info.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_search_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_search.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_search.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_search_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_search.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_admin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_admin.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_admin.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_admin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_admin.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_calc_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_calc.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_calc.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_calc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_calc.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_test_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_test.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_test.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_test_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_test.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_game_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_game.Click
        frmGame.Show()
    End Sub

    Private Sub pic_game_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_game.MouseHover
        pic_arrow.Image = System.Drawing.Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\General\arrow_game.png")
        destination = "Left"
        tmrMove.Start()
    End Sub

    Private Sub pic_game_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_game.MouseLeave
        pic_arrow.Left = -580
        numOfMoves = 0
    End Sub

    Private Sub pic_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_info.Click
        frmInformation.Show()
    End Sub

    Private Sub pic_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_search.Click
        frmSearch.Show()
    End Sub

    Private Sub pic_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_test.Click
        frmTestSplash.Show()
    End Sub

    Private Sub pic_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_admin.Click
        frmAdminSplash.Show()
    End Sub

    Private Sub pic_gallery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_gallery.Click
        frmGallerySplash.Show()
    End Sub

    Private Sub pic_calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_calc.Click
        frmCalculator.Show()
    End Sub
End Class
