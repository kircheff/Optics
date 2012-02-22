Public Class frmTestChange
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM test", con)
    Dim txt_answers(2) As TextBox


    Private Sub frmTestChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rs.Fill(ds, "Test")

        For i = 0 To ds.Tables("test").Rows.Count - 1
            lst_questions.Items.Add(ds.Tables("test").Rows(i).Item("question"))
        Next

        For i = 0 To txt_answers.Count - 1
            txt_answers(i) = New TextBox

            txt_answers(i).Text = i
            txt_answers(i).Width = txt_question.Width
            txt_answers(i).Top = txt_question.Top + txt_question.Height + 10 + i * 40
            txt_answers(i).Left = txt_question.Left
            txt_answers(i).Enabled = False

            Me.Controls.Add(txt_answers(i))
        Next
    End Sub

    Private Sub lst_questions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_questions.SelectedIndexChanged
        txt_question.Text = ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("question")

        For i = 0 To txt_answers.Count - 1
            txt_answers(i).Text = ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("ans" & i + 1)
        Next
    End Sub

    Private Sub cmd_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_change.Click
        txt_question.Enabled = True
        For i = 0 To txt_answers.Count - 1
            txt_answers(i).Enabled = True
        Next i

        cmd_change.Enabled = False
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click


        For i = 0 To txt_answers.Count - 1
            ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("ans" & i + 1) = txt_answers(i).Text
        Next
    End Sub
End Class