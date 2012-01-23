Public Class frmAdmin
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs.Fill(ds, "Rechnik")
        txtWord.Text = ds.Tables("rechnik").Rows(1).Item(1)
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        txtWord.Enabled = True
        txtMeaning.Enabled = True


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cb As New OleDb.OleDbCommandBuilder(rs)
        ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("duma") = txtWord.Text
        ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("znachenie") = txtMeaning.Text

        rs.Update(ds, "Rechnik")
        MsgBox("Data updated")
    End Sub

    Private Sub lstWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged
        txtWord.Text = ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("duma").ToString
        txtMeaning.Text = ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("znachenie").ToString

    End Sub
End Class