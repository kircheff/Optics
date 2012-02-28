Public Class frmInfoUs

    Private Sub frmInfoUs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtb_info.LoadFile(AppDomain.CurrentDomain.BaseDirectory & "Info\Help\info.rtf")
    End Sub
End Class