Public Class frmDictionary
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim dt As New DataTable("rechnik")
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)

    Private Sub frmDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        con.Open()

        rs.Fill(dt)
        For indx = 0 To dt.Rows.Count - 1
            lstWords.Items.Add(dt.Rows(indx).Item("duma"))
        Next indx

        lstWords.SelectedIndex = 0
        con.Close()
    End Sub

    Private Sub lstWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged
        lblWord2.Text = dt.Rows(lstWords.SelectedIndex).Item("duma").ToString
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

        lstWordsResults.Visible = True
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

    Private Sub lstWordsResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWordsResults.SelectedIndexChanged
        lblWord2.Text = dt.Rows(lstWordsResults.SelectedIndex).Item("duma").ToString
        lblMeaning.Text = dt.Rows(lstWordsResults.SelectedIndex).Item("znachenie").ToString

        lstWordsResults.Visible = False
        txtSearch.Text = ""
    End Sub
End Class