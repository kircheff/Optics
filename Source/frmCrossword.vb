Public Class frmCrossword
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)

    Const Max As Integer = 10
    Const max2 As Integer = 10
    Dim TextBoxes(Max, max2) As TextBox

    Dim v_duma As String

    Private Sub frmCrossword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i

        
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        v_duma = lstWords.Items(lstWords.SelectedIndex)

        Dim masiv As String

        masiv = v_duma.ToCharArray

        For i = 0 To masiv.Count - 1
            TextBoxes(i, 0).Text = masiv(i)
        Next

        Dim pos(0 To masiv.Count - 1)


    End Sub

    Private Sub lstWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged

    End Sub
End Class