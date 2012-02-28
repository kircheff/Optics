Public Class frmInfoLit

    Private Sub frmInfoLit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtb_info.LoadFile(AppDomain.CurrentDomain.BaseDirectory & "Info\Help\lit.rtf")

    End Sub
End Class