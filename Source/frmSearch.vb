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
                    ListBox2.Items.Add(nameOfArticle)
                    ListBox1.Items.Add(f)
                    Exit For

                End If
            Next

        Next
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
    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        FindText(TextBox1.Text, AppDomain.CurrentDomain.BaseDirectory & "Info")
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Items(ListBox2.SelectedIndex))
    End Sub
End Class