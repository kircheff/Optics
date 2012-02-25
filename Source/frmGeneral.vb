Public Class frmGeneral

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        frmCalculator.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiction.Click
        frmDictionary.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        frmAdminSplash.Show()

    End Sub

    Private Sub btnCrossword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrossword.Click
        frmCrossword.Show()
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmTestSplash.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmTestAdmin.Show()

    End Sub

    Private Sub cmdGallery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGallery.Click
        frmGallerySplash.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmInformation.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmSearch.Show()
    End Sub


End Class
