Public Class frmGeneral

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        frmCalculator.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiction.Click
        frmDatabase.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        frmAdmin.Show()

    End Sub

    Private Sub btnCrossword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrossword.Click
        frmCrossword.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCrosswordSplash.Show()
    End Sub
End Class
