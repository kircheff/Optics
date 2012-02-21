Public Class frmGallerySplash

    Private Sub cmdGoRazprostranenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoRazprostranenie.Click
        chosenGallery = "Razprostranenie"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoOtrajenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoOtrajenie.Click
        chosenGallery = "Otrajenie"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoDispersiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoDispersiq.Click
        chosenGallery = "Dispersiq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoInterferenciq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoInterferenciq.Click
        chosenGallery = "Interferenciq"
        frmGallery.Show()
        Me.Close()
    End Sub

    Private Sub cmdGoDifrakciq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoDifrakciq.Click
        chosenGallery = "Difrakciq"
        frmGallery.Show()
        Me.Close()
    End Sub
End Class