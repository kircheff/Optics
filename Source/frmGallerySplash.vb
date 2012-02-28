Public Class frmGallerySplash

    Private Sub cmdGoRazprostranenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chosenGallery = "Info\Razprostranenie"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoOtrajenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chosenGallery = "Info\Otrajenie"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoDispersiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chosenGallery = "Info\Dispersiq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoInterferenciq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chosenGallery = "Info\Interferenciq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoDifrakciq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chosenGallery = "Info\Difrakciq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub НачалнаСтаницаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НачалнаСтаницаToolStripMenuItem.Click
        frmGeneral.Show()
        Me.Close()
    End Sub

    Private Sub ТърсенеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТърсенеToolStripMenuItem.Click
        frmSearch.Show()

    End Sub


    Private Sub ЗаПрограматаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаПрограматаToolStripMenuItem.Click
        frmInfoProgram.show()
    End Sub

    Private Sub ЗаАвторитеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаАвторитеToolStripMenuItem.Click
        frmInfoUs.show()
    End Sub

    Private Sub ИзползванаЛитератураToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзползванаЛитератураToolStripMenuItem.Click
        frmInfoLit.show()
    End Sub

    Private Sub pic_razprost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_razprost.Click
        chosenGallery = "Info\Razprostranenie"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub ppic_otraj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ppic_otraj.Click
        chosenGallery = "Info\Otrajenie"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        chosenGallery = "Info\Dispersiq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chosenGallery = "Info\Difrakciq"
        frmGallery.Show()
        Me.Close()
    End Sub


    Private Sub pic_difrak_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_difrak.Click
        chosenGallery = "Info\Difrakciq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub pic_inter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_inter.Click
        chosenGallery = "Info\Interferenciq"
        frmGallery.Show()
        Me.Close()
    End Sub


End Class