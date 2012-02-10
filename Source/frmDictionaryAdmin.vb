Public Class frmDictionaryAdmin
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


    Private Sub cmdChange_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        txtWord.Enabled = True
        txtMeaning.Enabled = True
    End Sub

    Private Sub cmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cb As New OleDb.OleDbCommandBuilder(rs)

        ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("duma") = txtWord.Text
        ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("znachenie") = txtMeaning.Text
        rs.Update(ds, "Rechnik")

        lstWords.Items.Clear()
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i

        MsgBox("Информацията е обновена.", , "Честито!")

        txtWord.Enabled = False
        txtMeaning.Enabled = False
    End Sub

    Private Sub lstWords_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged
        txtWord.Text = ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("duma").ToString
        txtMeaning.Text = ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("znachenie").ToString
        txtWord.Enabled = False
        txtMeaning.Enabled = False
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim cb As New OleDb.OleDbCommandBuilder(rs)
        ds.Tables("rechnik").Rows.Add(ds.Tables("rechnik").NewRow())
        ds.Tables("rechnik").Rows(ds.Tables("rechnik").Rows.Count - 1).Item("duma") = txtAddWord.Text
        ds.Tables("rechnik").Rows(ds.Tables("rechnik").Rows.Count - 1).Item("znachenie") = txtAddMeaning.Text
        ds.Tables("rechnik").Rows(ds.Tables("rechnik").Rows.Count - 1).Item("ID") = ds.Tables("rechnik").Rows.Count - 1
        rs.Update(ds, "Rechnik")
        lstWords.Items.Clear()
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i

        MsgBox("Думата е добавена в базата данни.", , "Честито!")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cb As New OleDb.OleDbCommandBuilder(rs)
        ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Delete()
        rs.Update(ds, "Rechnik")
        lstWords.Items.Clear()
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i
        MsgBox("Думата е добавена в базата данни.", , "Честито!")
    End Sub


    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class