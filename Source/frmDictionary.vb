Public Class frmDictionary
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim dt As New DataTable("rechnik")
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)

    Private Sub frmDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs.Fill(dt)
        For indx = 0 To dt.Rows.Count - 1
            lstWords.Items.Add(dt.Rows(indx).Item("duma"))
        Next indx
        con.Close()
    End Sub

    Private Sub lstWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged
        lblWord.Text = dt.Rows(lstWords.SelectedIndex).Item("duma").ToString
        lblMeaning.Text = dt.Rows(lstWords.SelectedIndex).Item("znachenie").ToString
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        lstWordsResults.Items.Clear()
        Dim count As Integer = (lstWords.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = lstWords.Items.Item(a)
            If InStr(words.ToLower, txtSearch.Text.ToLower) = 1 Then
                lstWordsResults.Items.Add(words)
            End If

        Next
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
End Class