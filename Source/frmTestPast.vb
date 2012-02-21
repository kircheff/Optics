Public Class frmTestPast

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM test", con)
  

    Dim questionID() As String
    Dim questions(9) As String

    Private Sub frmTestPast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        rs.Fill(ds, "Test")

        readQuestion(question_order)
        For i = 0 To questionID.Count - 1
            lst_questions.Items.Add("Въпрос " & i + 1)


        Next
        Dim j = 1
        For i = 0 To questionID.Count - 1

            questions(i) = ds.Tables("test").Rows(questionID(i) - 1).Item("question")

        Next


    End Sub

    Private Sub readQuestion(ByVal question_order As String)


        question_order = question_order.Substring(0, question_order.Length - 1)
        questionID = question_order.Split(",")


    End Sub

    Private Sub lst_questions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_questions.SelectedIndexChanged
        lbl_question.Text = questions(lst_questions.SelectedIndex)
    End Sub
End Class