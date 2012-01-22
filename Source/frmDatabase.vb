Public Class frmDatabase
    
    Private Sub frmDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb"
        con.Open()
        Dim dt As New DataTable("rechnik")
        Dim rs As OleDb.OleDbDataAdapter
        rs = New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
        rs.Fill(dt)
        For indx = 0 To dt.Rows.Count - 1



            lstWords.Items.Add(dt.Rows(indx).Item("duma"))
           
        Next indx
    End Sub
End Class