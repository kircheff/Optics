Public Class frmCrossword
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Private Sub frmCrossword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i
    End Sub
End Class