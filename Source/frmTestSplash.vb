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

    Private Sub frmTestSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class