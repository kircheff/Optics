Public Class frmSearch
    Private Sub FindText(ByVal text As String, ByVal dir As String)
        For Each f As String In My.Computer.FileSystem.GetFiles(dir, FileIO.SearchOption.SearchAllSubDirectories, "*.txt")

            Dim str() As String = System.IO.File.ReadAllLines(f)
            For Each s As String In str

                If s.Contains(text) Then
                    Dim splitted() As String
                    Dim nameOfArticle As String = "Toчка "
                    splitted = f.Split("\")
                    Dim tochka() As String
                    tochka = splitted(splitted.Count - 1).Split(".")
                    nameOfArticle = nameOfArticle & tochka(0) & " oт урока "
                    Select Case splitted(splitted.Count - 2)
                        Case Is = "Difrakciq"
                            nameOfArticle = nameOfArticle & "Дифракция"
                        Case Is = "Interferenciq"
                            nameOfArticle = nameOfArticle & "Интерференция"
                        Case Is = "Razprostranenie"
                            nameOfArticle = nameOfArticle & "Разпространение на светлината"
                        Case Is = "Otrajenie"
                            nameOfArticle = nameOfArticle & "Отражение и пречупване"
                        Case Is = "Dispersiq"
                            nameOfArticle = nameOfArticle & "Дисперсия"



                    End Select
                    lst_results.Items.Add(nameOfArticle)
                    ListBox1.Items.Add(f)
                    Exit For


                End If
            Next

        Next
        If lst_results.Items.Count = 0 Then
            MsgBox("Съжаляваме, не бяха намерени резултати с дадената от вас дума", , "Няма намерени резултати")
            txt_search.Text = ""
        End If
        'RemoveDuplicateItem(ListBox1)
        'RemoveDuplicateItem(ListBox2)
    End Sub
    Sub RemoveDuplicateItem(ByVal listboxName As ListBox)
        listboxName.Sorted = True
        listboxName.Refresh()
        Dim index As Integer
        Dim itemcount As Integer = listboxName.Items.Count

        If itemcount > 1 Then
            Dim lastitem As String = listboxName.Items(itemcount - 1)

            For index = itemcount - 2 To 0 Step -1
                If listboxName.Items(index) = lastitem Then
                    listboxName.Items.RemoveAt(index)
                Else
                    lastitem = listboxName.Items(index)
                End If
            Next
        End If
    End Sub
    Private Sub НачалнаСтаницаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НачалнаСтаницаToolStripMenuItem.Click
        frmGeneral.Show()
        Me.Close()
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

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click
        If txt_search.Text = "" Then
            MsgBox("Моля въведете текст в полето за търсене!", , "Грешка")
            txt_search.Text = "Въведете дума за търсене..."
            Exit Sub
        End If

        ListBox1.Items.Clear()
        lst_results.Items.Clear()
        FindText(txt_search.Text, AppDomain.CurrentDomain.BaseDirectory & "Info")
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_results.SelectedIndexChanged
        rtb_file.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Items(lst_results.SelectedIndex))
    End Sub


    Private Sub lbl_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_search.Click
        cmd_search_Click(sender, e)
    End Sub

    Private Sub txt_search_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_search.GotFocus
        txt_search.Text = ""
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged

    End Sub
End Class