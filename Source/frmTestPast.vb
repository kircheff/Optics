Public Class frmTestPast

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM test", con)
  

    Dim questionID() As String
    Dim questions(9) As String
    Dim answer_selected(9) As String
    Dim answers(2) As String
    Dim lbl_answers(2) As Label
    Dim answer_correct As String

    Private Sub frmTestPast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        rs.Fill(ds, "Test")

        readQuestion(question_order)
        readAnswers(question_answers)


        For i = 0 To questionID.Count - 1
            lst_questions.Items.Add("Въпрос " & i + 1)

        Next
        Dim j = 1
        For i = 0 To questionID.Count - 1
            Try
                questions(i) = ds.Tables("test").Rows(questionID(i)).Item("question")
            Catch ex As Exception
                MsgBox("Един от въпросите не е намерен в базата. Не може да се прегледа хронология за този потребител.", , "Опаа!")
                Me.Close()
            End Try


        Next


    End Sub

    Private Sub readQuestion(ByVal question_order As String)


        question_order = question_order.Substring(0, question_order.Length - 1)
        questionID = question_order.Split(",")


    End Sub
    Private Sub readAnswers(ByVal asnwers As String)
        question_answers = question_answers.Substring(0, question_answers.Length - 1)
        answer_selected = question_answers.Split(",")
    End Sub

    Private Sub lst_questions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_questions.SelectedIndexChanged
        lbl_ans1.ForeColor = Color.Black
        lbl_ans2.ForeColor = Color.Black
        lbl_ans3.ForeColor = Color.Black

        lbl_question.Text = questions(lst_questions.SelectedIndex)

        answers(0) = ds.Tables("test").Rows(questionID(lst_questions.SelectedIndex)).Item("ans1")
        answers(1) = ds.Tables("test").Rows(questionID(lst_questions.SelectedIndex)).Item("ans2")
        answers(2) = ds.Tables("test").Rows(questionID(lst_questions.SelectedIndex)).Item("ans3")

        lbl_ans1.Text = "1. " & answers(0)
        lbl_ans2.Text = "2. " & answers(1)
        lbl_ans3.Text = "3. " & answers(2)

        answer_correct = ds.Tables("test").Rows(questionID(lst_questions.SelectedIndex)).Item("correct")

        'Оцветяване на потребителския отговор
        If answer_selected(lst_questions.SelectedIndex) = "0" Then
            MsgBox("На този въпрос не е избран отговор от потребителя.", , "Опаа!")
        End If

        If answer_selected(lst_questions.SelectedIndex) = "1" Then
            lbl_ans1.ForeColor = Color.Red
            lbl_ans1.Text = "1. " & answers(0)
        End If

        If answer_selected(lst_questions.SelectedIndex) = "2" Then
            lbl_ans2.ForeColor = Color.Red
            lbl_ans2.Text = "2. " & answers(1)
        End If

        If answer_selected(lst_questions.SelectedIndex) = "3" Then
            lbl_ans3.ForeColor = Color.Red
            lbl_ans3.Text = "3. " & answers(2)
        End If
        'край

        'Оцветяване на верния отговор
        If lbl_ans1.Text = "1. " & answer_correct Then
            lbl_ans1.ForeColor = Color.Green
            lbl_ans1.Text = "1. " & answer_correct
        End If

        If lbl_ans2.Text = "2. " & answer_correct Then

            lbl_ans2.ForeColor = Color.Green
            lbl_ans2.Text = "2. " & answer_correct
        End If
        If lbl_ans3.Text = "3. " & answer_correct Then
            lbl_ans3.ForeColor = Color.Green
            lbl_ans3.Text = "3. " & answer_correct
        End If
        'край
    End Sub
    Private Sub НачалнаСтаницаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НачалнаСтаницаToolStripMenuItem.Click
        frmGeneral.Show()
        Me.Close()
    End Sub

    Private Sub ТърсенеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТърсенеToolStripMenuItem.Click
        frmSearch.Show()

    End Sub


    Private Sub ЗаПрограматаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаПрограматаToolStripMenuItem.Click
        frmInfoProgram.Show()
    End Sub

    Private Sub ЗаАвторитеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаАвторитеToolStripMenuItem.Click
        frmInfoUs.Show()
    End Sub

    Private Sub ИзползванаЛитератураToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзползванаЛитератураToolStripMenuItem.Click
        frmInfoLit.Show()
    End Sub
End Class