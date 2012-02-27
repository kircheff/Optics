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

            txt_answers(i).Width = txt_question.Width
            txt_answers(i).Top = txt_question.Top + txt_question.Height + 18 + i * 40
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

        txt_correct.Text = ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("correct")
        txt_points.Text = ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("points")
    End Sub

    Private Sub cmd_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_change.Click

        Dim cControl As Control
        For Each cControl In Me.Controls
            If (TypeOf cControl Is TextBox) Then
                cControl.Enabled = True

            End If
        Next cControl
        cmd_change.Enabled = False
        cmd_save.Enabled = True
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If txt_correct.Text = "" Or txt_points.Text = "" Or txt_question.Text = "" Or txt_answers(0).Text = "" Or txt_answers(1).Text = "" Or txt_answers(2).Text = "" Then
            MsgBox("НЕ може да оставяте празно поле!!", vbCritical + vbOKOnly, "Грешка!")
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(rs)

            ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("question") = txt_question.Text

            For i = 0 To txt_answers.Count - 1
                ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("ans" & i + 1) = txt_answers(i).Text
            Next
            ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("correct") = txt_correct.Text
            ds.Tables("test").Rows(lst_questions.SelectedIndex).Item("points") = txt_points.Text

            rs.Update(ds, "Test")

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is TextBox) Then
                    cControl.Enabled = False

                End If
            Next cControl

            cmd_change.Enabled = True
            cmd_save.Enabled = False
        End If
    End Sub

    Private Sub cmd_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_new.Click
        If txt_correct.Text = "" Or txt_points.Text = "" Or txt_question.Text = "" Or txt_answers(0).Text = "" Or txt_answers(1).Text = "" Or txt_answers(2).Text = "" Then
            MsgBox("НЕ може да оставяте празно поле!!", vbCritical + vbOKOnly, "Грешка!")
        Else
            Dim cControl As Control

            If cmd_new.Text = "Добави нов въпрос" Then
                For Each cControl In Me.Controls
                    If (TypeOf cControl Is TextBox) Then
                        cControl.Text = ""
                        cControl.Enabled = True

                    End If
                Next cControl

                cmd_new.Text = "Запазване на въпроса"
            ElseIf cmd_new.Text = "Запазване на въпроса" Then
                'Добавяне на новя въпрос, отговори и точки в базата данни
                Dim cb As New OleDb.OleDbCommandBuilder(rs)

                ds.Tables("test").Rows.Add(ds.Tables("test").NewRow())
                ds.Tables("test").Rows(ds.Tables("test").Rows.Count - 1).Item("question") = txt_question.Text

                For i = 0 To txt_answers.Count - 1
                    ds.Tables("test").Rows(ds.Tables("test").Rows.Count - 1).Item("ans" & i + 1) = txt_answers(i).Text
                Next
                ds.Tables("test").Rows(ds.Tables("test").Rows.Count - 1).Item("correct") = txt_correct.Text
                ds.Tables("test").Rows(ds.Tables("test").Rows.Count - 1).Item("points") = txt_points.Text
                rs.Update(ds, "Test")

                lst_questions.Items.Clear()

                For i = 0 To ds.Tables("test").Rows.Count - 1
                    lst_questions.Items.Add(ds.Tables("test").Rows(i).Item("question"))
                Next i


                cmd_new.Text = "Добави нов въпрос"

                For Each cControl In Me.Controls
                    If (TypeOf cControl Is TextBox) Then
                        cControl.Enabled = False
                        cControl.Text = ""
                    End If
                Next cControl

                lst_questions.SelectedIndex = -1
                MsgBox("Въпросът е добавен в базата данни. Формата ще се изключи, за да се вкарат промените в базата.", , "Честито!")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If lst_questions.SelectedIndex = -1 Then
            MsgBox("Моля, изберете въпрос, който да бъде изтрит.", vbOKOnly, "Опаа!")
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(rs)
            ds.Tables("test").Rows(lst_questions.SelectedIndex).Delete()
            rs.Update(ds, "Test")
            lst_questions.Items.Clear()
            For i = 0 To ds.Tables("test").Rows.Count - 1
                lst_questions.Items.Add(ds.Tables("test").Rows(i).Item("question"))
            Next

            MsgBox("Въпросът е изтрит от базата данни.", , "Честито!")

            txt_correct.Text = ""
            txt_points.Text = ""
            txt_question.Text = ""
            txt_answers(0).Text = ""
            txt_answers(1).Text = ""
            txt_answers(2).Text = ""
        End If
    End Sub
    Private Sub НачалнаСтаницаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НачалнаСтаницаToolStripMenuItem.Click
        frmGeneral.Show()
        Me.Close()
    End Sub

    Private Sub ТърсенеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТърсенеToolStripMenuItem.Click
        frmSearch.Show()

    End Sub


    Private Sub ЗаПрограматаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаПрограматаToolStripMenuItem.Click
        frmInfoProgram.show()
    End Sub

    Private Sub ЗаАвторитеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаАвторитеToolStripMenuItem.Click
        frmInfoUs.show()
    End Sub

    Private Sub ИзползванаЛитератураToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзползванаЛитератураToolStripMenuItem.Click
        frmInfoLit.show()
    End Sub
End Class