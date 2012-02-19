Public Class frmCrosswordSplash
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Dim num_h, num_v As Byte
    Dim v_duma As String
    Dim pos_start() As Integer
    Private Sub frmCrosswordSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            If InStr(ds.Tables("rechnik").Rows(i).Item("duma"), " ") = False Then
                lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
            End If
        Next i

       
    End Sub

    Private Sub cmdMakeCrossword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMakeCrossword.Click
        If lstWords.SelectedIndex = -1 Then

            MsgBox("Моля, изберете елемент")
        Else
            v_duma = lstWords.Items(lstWords.SelectedIndex)

            lst_words_vis.Items.Clear()
            lst_pos_vis.Items.Clear()
            lst_izbrani_vis.Items.Clear()
            txtMeanings.Text = ""

            Dim masiv As String
            masiv = v_duma.ToCharArray
            Dim pos_start(masiv.Length - 1) As Integer
            Dim izbrani_dumi(masiv.Length - 1) As String
            Dim meanings(izbrani_dumi.Length - 1) As String
            For j = 0 To masiv.Count - 1
                Dim check As Integer = 0
                For i = 0 To lstWords.Items.Count - 1

                    If InStr(lstWords.Items(i), masiv(j)) And lstWords.Items(i) <> lstWords.Items(lstWords.SelectedIndex) Then
                        lst_words_vis.Items.Add(lstWords.Items(i))
                    Else
                        check = check + 1
                    End If

                Next i
                If check = lstWords.Items.Count Then
                    MsgBox("В речника няма дума съдържаща буквата '" & masiv(j) & "'. Моля, изберете друга дума или добавете дума с тази буква в речника!")
                    Exit Sub
                End If
            Next j
            RemoveDuplicateItem(lst_words_vis)
            Dim rand As Integer = RandomNumber(lst_words_vis.Items.Count - 1)
            Dim found As Boolean
            For i = 0 To masiv.Count - 1
                found = False
                Dim CountOfTries As Integer = 0
                rand = RandomNumber(lst_words_vis.Items.Count - 1)
                Do While found = False And CountOfTries < 1000000

                    If InStr(lst_words_vis.Items(rand), masiv(i)) Then
                        pos_start(i) = InStr(lst_words_vis.Items(rand), masiv(i))

                        izbrani_dumi(i) = lst_words_vis.Items(rand).ToString
                        lst_words_vis.Items.RemoveAt(rand)
                        found = True
                        If rand = lst_words_vis.Items.Count - 1 Then
                            rand = -1
                        End If
                        rand = rand + 1
                    Else
                        found = False
                        If rand = lst_words_vis.Items.Count - 1 Then
                            rand = -1
                        End If
                        rand = rand + 1
                        CountOfTries = CountOfTries + 1

                    End If
                    If CountOfTries = 1000000 Then
                        MsgBox("Създаването на кръстословица с думата " & masiv & " е неуспешно! Моля, изберете друга дума или пробвайте отново!")
                        Exit Sub
                    End If
                Loop
            Next
            'Dim rand As Integer
            'Dim found As Boolean
            'For i = 0 To masiv.Count - 1
            '    found = False
            '    rand = RandomNumber(lst_words_vis.Items.Count - 1)
            '    Dim tries As Integer = 0
            '    Do While found = False And tries < 100000
            '        rand = RandomNumber(lst_words_vis.Items.Count - 1)
            '        If InStr(lst_words_vis.Items(rand), masiv(i)) Then
            '            pos_start(i) = InStr(lst_words_vis.Items(rand), masiv(i))

            '            izbrani_dumi(i) = lst_words_vis.Items(rand).ToString
            '            lst_words_vis.Items.RemoveAt(rand)
            '            found = True
            '            rand = RandomNumber(lst_words_vis.Items.Count - 1)
            '        Else
            '            found = False
            '            tries = tries + 1
            '        End If
            '        If tries = 100000 Then
            '            Exit Sub
            '        End If
            '    Loop
            'Next


            For i = 0 To pos_start.Count - 1
                lst_pos_vis.Items.Add(pos_start(i))
            Next i

          
            For i = 0 To ds.Tables("rechnik").Rows.Count - 1
                For j = 0 To izbrani_dumi.Count - 1
                    If izbrani_dumi(j) = ds.Tables("rechnik").Rows(i).Item("duma") Then
                        meanings(j) = ds.Tables("rechnik").Rows(i).Item("znachenie")
                    End If
                Next
            Next
            For i = 0 To meanings.Count - 1
                txtMeanings.Text = txtMeanings.Text & i + 1 & ". " & meanings(i) & Environment.NewLine
            Next
            Dim maxLeft As Byte = pos_start(0) - 1
            Dim maxRight As Byte = Len(izbrani_dumi(0)) - pos_start(0)
            For i = 1 To pos_start.Count - 1
                If maxLeft < pos_start(i) - 1 Then
                    maxLeft = pos_start(i) - 1
                End If
                If maxRight < Len(izbrani_dumi(i)) - pos_start(i) Then
                    maxRight = Len(izbrani_dumi(i)) - pos_start(i)
                End If
            Next
            txtMax.Text = maxRight
            txtMin.Text = maxLeft

            num_v = Len(masiv)
            num_h = 1 + maxLeft + maxRight

            Dim crossword(Len(masiv), 1 + maxLeft + maxRight) As Char
            Dim TextBoxes(num_v, num_h) As TextBox
            
            For i = 0 To Len(masiv) - 1
                For j = 0 To maxLeft + maxRight
                    TextBoxes(i, j) = New TextBox
                    TextBoxes(i, j).Height = 25
                    TextBoxes(i, j).MaxLength = 1
                    TextBoxes(i, j).Width = 28
                    TextBoxes(i, j).TextAlign = HorizontalAlignment.Center
                    TextBoxes(i, j).Font = New Font("Times New Roman", 14)
                    TextBoxes(i, j).Multiline = True
                    TextBoxes(i, j).Top = i * TextBoxes(i, j).Height + 20
                    TextBoxes(i, j).Left = j * TextBoxes(i, j).Width + 60
                    TextBoxes(i, j).Name = "txtBox" & i & j
                    Controls.Add(TextBoxes(i, j))
                Next j
            Next i
            Dim NumBoxes(num_v) As Label
            For i = 0 To Len(masiv) - 1

                NumBoxes(i) = New Label
                NumBoxes(i).Height = 26.3
                NumBoxes(i).Width = 28
                NumBoxes(i).Top = i * NumBoxes(i).Height + 20
                NumBoxes(i).Left = NumBoxes(i).Width
                NumBoxes(i).Name = "NumBox" & i
                NumBoxes(i).Text = i + 1
                NumBoxes(i).Font = New Font("Times New Roman", 14)
                Controls.Add(NumBoxes(i))

            Next i
            For i = 0 To Len(masiv) - 1
                izbrani_dumi(i) = AddStars(maxLeft - pos_start(i) + 1, izbrani_dumi(i), "Left")
                izbrani_dumi(i) = AddStars(maxRight + maxLeft + 1 - Len(izbrani_dumi(i)), izbrani_dumi(i), "Right")

            Next
            For i = 0 To izbrani_dumi.Count - 1
                lst_izbrani_vis.Items.Add(izbrani_dumi(i))
            Next i
            Dim helpStr As String
            For i = 0 To Len(masiv) - 1
                helpStr = izbrani_dumi(i)
                For j = 0 To maxLeft + maxRight
                    crossword(i, j) = helpStr(j)
                Next
            Next

            For i = 0 To Len(masiv) - 1
                For j = 0 To maxLeft + maxRight
                    If j = maxLeft Then
                        TextBoxes(i, j).BackColor = Color.Cyan
                    End If
                    TextBoxes(i, j).Text = crossword(i, j)
                Next j
            Next i
            For i = 0 To Len(masiv) - 1
                For j = 0 To maxLeft + maxRight
                    If TextBoxes(i, j).Text = "*" Then
                        TextBoxes(i, j).Visible = False
                    End If

                Next j
            Next i
            Array.Clear(pos_start, pos_start.GetLowerBound(0), pos_start.Length)
            Array.Clear(izbrani_dumi, izbrani_dumi.GetLowerBound(0), izbrani_dumi.Length)

        End If

    End Sub

    Function AddStars(ByVal numberOfStars As Byte, ByVal stringToAdd As String, ByVal side As String) As String
        If side = "Left" Then
            For i = 1 To numberOfStars
                stringToAdd = "*" & stringToAdd
            Next
        ElseIf side = "Right" Then
            For i = 1 To numberOfStars
                stringToAdd = stringToAdd & "*"
            Next
        End If
        AddStars = stringToAdd
    End Function
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



    Private Sub cmdClearCrossword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearCrossword.Click


        For i = 0 To num_v - 1
            For j = 0 To num_h - 1
                Controls.RemoveByKey("txtBox" & i & j)
            Next j
        Next i
        For i = 0 To num_v - 1
            Controls.RemoveByKey("NumBox" & i)
        Next i
    End Sub
End Class