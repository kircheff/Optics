Public Class frmInfoProgram

    Private Sub frmInfoProgram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtb_info.LoadFile(AppDomain.CurrentDomain.BaseDirectory & "Info\Help\program.rtf")
    End Sub
End Class