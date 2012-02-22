Public Class frmTest
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM test", con)
    Dim rs_users As New OleDb.OleDbDataAdapter("SELECT * FROM potrebiteli", con)
    Dim cb As New OleDb.OleDbCommandBuilder(rs_users)

    Dim seconds As Byte 'Секунди
    Dim question As String 'Текущ въпрос
    Dim questionID As Integer 'Номер на текущия въпрос
    Dim answers(2) As String 'Възможни отговори на текущия въпрос
    Dim correct_answer As String 'Верен отговор на текущия въпрос
    Dim points As Byte = 0 'Текущи точки на потребителя
    Dim points_max As Byte = 0 'Максимален брой точки, които потребителя може да получи
    Dim answer_points As Byte 'Колко точки е текущият въпрос
    Dim user_answer As String 'Избран отговор от потребителя
    Dim selected_answers As String = "" 'Избрани отговори, които ще се записват в базата данни
    Dim questions_answered As Byte = 0 'На колко въпроса е отговорил потребителя досега
    Dim questions_order As String = "" 'Последователността от въпроси които са се паднали на произволен принцип
    Dim mark As Double 'Оценка на потребителя

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.Open()

        rs.Fill(ds, "Test")
        rs_users.Fill(ds, "potrebiteli")

        lbl_name.Text = user

        ds.Tables("potrebiteli").Rows.Add(ds.Tables("potrebiteli").NewRow())
        ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("username") = user
        ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("klas") = user_class
        ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("ID") = ds.Tables("potrebiteli").Rows.Count - 1
        ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("data_zap") = System.DateTime.Now

        'rs_users.Update(ds, "Potrebiteli")

        NextQuestion()


    End Sub
    Private Sub tmr_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_time.Tick
        seconds = seconds + 1
        lbl_seconds.Text = 60 - seconds & " / 60"

        If seconds >= 60 Then NextQuestion()
    End Sub

    Private Sub NextQuestion()

        UncheckRadioButtons(Me)

        If questions_answered = 10 Then

            questions_answered = 0

            mark = Math.Round(2 + 4 * points / points_max, 2)

            MsgBox("Вашата оценка е: " & mark, , "Оценка")


            ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("test") = questions_order
            ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("points") = points
            ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("ocenka") = mark
            ds.Tables("potrebiteli").Rows(ds.Tables("potrebiteli").Rows.Count - 1).Item("otgovori") = selected_answers
            rs_users.Update(ds, "Potrebiteli")

            End
        End If

        Dim rand As Integer

        seconds = 0
        rand = RandomNumber(ds.Tables("test").Rows.Count, 0)

        'Подсигуряваме се че в текущия тест няма да се паднат 2 еднакви въпроса
        Do While InStr(questions_order, rand.ToString)
            rand = RandomNumber(ds.Tables("test").Rows.Count, 0)
        Loop

        questionID = rand
        question = ds.Tables("test").Rows(rand).Item("question")

        answers(0) = ds.Tables("test").Rows(rand).Item("ans1")
        answers(1) = ds.Tables("test").Rows(rand).Item("ans2")
        answers(2) = ds.Tables("test").Rows(rand).Item("ans3")

        correct_answer = ds.Tables("test").Rows(rand).Item("correct")
        answer_points = ds.Tables("test").Rows(rand).Item("points")

        'If opt_answ1.Checked = True Then user_answer = 1
        'If opt_answ2.Checked = True Then user_answer = 2
        'If opt_answ3.Checked = True Then user_answer = 3

        'If user_answer = correct_answer Then

        '    points = points + answer_points
        'Else : points = points + 0
        'End If

        'points_max = points_max + answer_points

        opt_answ1.Text = answers(0).ToString
        opt_answ2.Text = answers(1).ToString
        opt_answ3.Text = answers(2).ToString

        lblQuestion.Text = question

        lbl_question_number.Text = questions_answered + 1 & "/10 въпроса"

        questions_answered = questions_answered + 1

        questions_order = questions_order & questionID & ","


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
        If opt_answ1.Checked = False And opt_answ2.Checked = False And opt_answ3.Checked = False Then
            MsgBox("Моля изберете отговор на въпроса!", , "Не е избран отговор")
            Exit Sub
        End If

        If user_answer = correct_answer Then

            points = points + answer_points
        Else : points = points + 0
        End If

        points_max = points_max + answer_points

        If opt_answ1.Checked = True Then
            selected_answers = selected_answers & 1 & ","
        End If

        If opt_answ2.Checked = True Then
            selected_answers = selected_answers & 2 & ","
        End If

        If opt_answ3.Checked = True Then
            selected_answers = selected_answers & 3 & ","
        End If

        NextQuestion()
        TextBox1.Text = points

       
    End Sub

    Private Sub Clear_array(ByVal array As Array)
        array.Clear(array, array.GetLowerBound(0), array.Length)
    End Sub
    Private Sub UncheckRadioButtons(ByVal ctrl As Control)

        For Each c As Control In ctrl.Controls
            If TypeOf c Is RadioButton Then
                CType(c, RadioButton).Checked = False
            Else
                If c.HasChildren Then UncheckRadioButtons(c)
            End If
        Next

    End Sub

    Private Sub opt_answ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_answ1.CheckedChanged
        user_answer = opt_answ1.Text
    End Sub

    Private Sub opt_answ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_answ2.CheckedChanged
        user_answer = opt_answ2.Text
    End Sub

    Private Sub opt_answ3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_answ3.CheckedChanged
        user_answer = opt_answ3.Text
    End Sub
End Class