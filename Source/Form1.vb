Public Class frmCrosswordSplash
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)

    Dim v_duma As String
    Private Sub frmCrosswordSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        v_duma = lstWords.Items(lstWords.SelectedIndex)

        Dim masiv As String

        masiv = v_duma.ToCharArray

        For i = 0 To lstWords.Items.Count - 1
            For j = 0 To masiv.Count - 1
                If InStr(lstWords.Items(i), masiv(j)) Then
                    lst_words_vis.Items.Add(lstWords.Items(i))
                End If
            Next j
        Next i

        For u = lst_words_vis.Items.Count To 1 Step -1
            If lst_words_vis.Items(u) = lst_words_vis.Items(u - 1) Then
                lst_words_vis.Items.Remove(u)
            End If
        Next
    End Sub
End Class