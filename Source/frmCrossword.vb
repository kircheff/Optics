Public Class frmCrossword
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Private Sub frmCrossword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i

        Const Max As Integer = 10
        Const max2 As Integer = 10
        Dim TextBoxes(Max, max2) As TextBox
        For i = 0 To Max
            For j = 0 To max2
                TextBoxes(i, j) = New TextBox
                TextBoxes(i, j).Height = 27
                TextBoxes(i, j).Width = 27
                TextBoxes(i, j).Top = i * TextBoxes(i, j).Height
                TextBoxes(i, j).Left = j * TextBoxes(i, j).Width
                Controls.Add(TextBoxes(i, j))
            Next j

        Next i
    End Sub
End Class