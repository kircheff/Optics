Public Class frmTest
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM test", con)

    Dim seconds As Byte 'Секунди
    Dim question As String 'Текущ въпрос
    Dim questionID As Integer 'Номер на текущия въпрос
    Dim answers(2) As String 'Възможни отговори на текущия въпрос
    Dim correct_answer As Byte 'Верен отговор на текущия въпрос
    Dim points As Byte 'Текущи точки на потребителя
    Dim answer_points As Byte 'Колко точки е текущят въпрос
    Dim user_answer As Byte 'Избран отговор от потребителя
    Dim questons_answered As Byte 'На колко въпроса е отговорил потребителя досега
    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs.Fill(ds, "Test")

        NextQuestion()


    End Sub
    Private Sub tmr_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_time.Tick
        seconds = seconds + 1
        lbl_seconds.Text = 60 - seconds & " / 60"

        If seconds >= 60 Then NextQuestion()
    End Sub

    Private Sub NextQuestion()
        If questons_answered = 10 Then
            'frmEdikakvo si .show
            End
        End If

        Dim rand As Integer

        seconds = 0
        rand = RandomNumber(ds.Tables("test").Rows.Count, 0)

        If rand = questionID Then
            rand = RandomNumber(ds.Tables("test").Rows.Count, 0)
        End If

        questionID = rand
        question = ds.Tables("test").Rows(rand).Item("question")


        answers(0) = ds.Tables("test").Rows(rand).Item("ans1")
        answers(1) = ds.Tables("test").Rows(rand).Item("ans2")
        answers(2) = ds.Tables("test").Rows(rand).Item("ans3")

        correct_answer = ds.Tables("test").Rows(rand).Item("correct")
        answer_points = ds.Tables("test").Rows(rand).Item("points")

        If opt_answ1.Checked = True Then user_answer = 1
        If opt_answ2.Checked = True Then user_answer = 2
        If opt_answ3.Checked = True Then user_answer = 3

        If user_answer = correct_answer Then

            points = points + answer_points
        End If

        opt_answ1.Text = answers(0).ToString
        opt_answ2.Text = answers(1).ToString
        opt_answ3.Text = answers(2).ToString

        lblQuestion.Text = question



    End Sub

    Public Function RandomNumber(ByVal MaxNumber As Integer, Optional ByVal MinNumber As Integer = 0) As Integer

        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        'if passed incorrect arguments, swap them
        'can also throw exception or return 0

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function

    Private Sub cmd_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_next.Click
        NextQuestion()
        TextBox1.Text = points

    End Sub

    Private Sub Clear_array(ByVal array As Array)
        array.Clear(array, array.GetLowerBound(0), array.Length)
    End Sub
End Class