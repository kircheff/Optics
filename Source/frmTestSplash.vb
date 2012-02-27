Public Class frmTestSplash

   
    Private Sub cmd_forward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_forward.Click
        If txt_username.Text = "" Or txt_username.Text.Length < 3 Then
            MsgBox("Въвели сте празно, или по- малко от 3 символа, име!", , "Невалидно име")
            Exit Sub
        End If

        user = txt_username.Text
        user_class = txt_klas.Text

        frmTest.Show()
        Close()
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

    Private Sub pic_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_submit.Click
        cmd_forward_Click(sender, e)
    End Sub
End Class