Public Class frmAdmin
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim dt As New DataTable("rechnik")
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs.Fill(dt)
        For indx = 0 To dt.Rows.Count - 1
            lstWords.Items.Add(dt.Rows(indx).Item("duma"))
        Next indx
        Me.rs.Fill(ds.Tables("rechnik"))
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        txtWord.Enabled = True
        txtMeaning.Enabled = True


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cb As New OleDb.OleDbCommandBuilder(rs)

        dt.Rows(lstWords.SelectedIndex)("duma") = txtWord.Text
        dt.Rows(lstWords.SelectedIndex)("znachenie") = txtMeaning.Text

        rs.Update(dt)



        MsgBox("Data updated")
    End Sub

    Private Sub lstWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged
        txtWord.Text = dt.Rows(lstWords.SelectedIndex).Item("duma").ToString
        txtMeaning.Text = dt.Rows(lstWords.SelectedIndex).Item("znachenie").ToString
    End Sub
End Class