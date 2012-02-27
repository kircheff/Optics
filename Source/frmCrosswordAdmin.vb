Public Class frmCrossword
    'Деклариране на променливи
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Dim num_h, num_v As Byte
    Dim v_duma As String
    Dim pos_start() As Integer
    Private Sub frmCrosswordAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Позициониране на формата
        Me.Top = 0
        Me.Left = 0

        'Извличане на думите от базата данни
        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            If InStr(ds.Tables("rechnik").Rows(i).Item("duma"), " ") = False Then
                lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
            End If
        Next i

        'Извикване на процедурата за създаване на кръстословица
        cmdMakeCrossword_Click()
        cmdMakeCrossword.Visible = False
        cmdMakeCrossword.Visible = True

    End Sub

    Private Sub cmdMakeCrossword_Click() Handles cmdMakeCrossword.Click

Beginning:

        'Подготовка за създаване на кръстословицата
        tmrCombo.Enabled = False
        cmdMakeCrossword.Enabled = False
        cmdCheckCrossword.Enabled = False
        cmdClearCrossword_Click()
        lst_words_vis.Items.Clear()
        lst_pos_vis.Items.Clear()
        lst_izbrani_vis.Items.Clear()
        txtMeanings.Text = ""
        txtHints.Text = ""

        'Избор на дума по вертикалата на случаен принцип и преобразуване на думата в масив от тип Char
        Dim chosenWordIndex As Integer = RandomNumber(lstWords.Items.Count - 1, 0)
        v_duma = lstWords.Items(chosenWordIndex)
        Dim chosenWord As String
        chosenWord = v_duma.ToCharArray

        'Ако думата е по-дълга от 13 символа - избери друга дума
        If chosenWord.Length > 13 Then
            GoTo Beginning
        End If

        'Деклариране на променливи
        Dim pos_start(chosenWord.Length - 1) As Integer
        Dim izbrani_dumi(chosenWord.Length - 1) As String
        Dim meanings(izbrani_dumi.Length - 1) As String

        'Намиране на всички думи, които могат да участват в кръстословицата
        For j = 0 To chosenWord.Count - 1
            Dim check As Integer = 0
            For i = 0 To lstWords.Items.Count - 1
                If InStr(lstWords.Items(i), chosenWord(j)) And lstWords.Items(i) <> lstWords.Items(chosenWordIndex) Then
                    lst_words_vis.Items.Add(lstWords.Items(i))
                Else
                    check = check + 1
                End If
            Next i
            If check = lstWords.Items.Count Then
                GoTo Beginning
            End If
        Next j
        RemoveDuplicateItem(lst_words_vis)

        'Избиране на думите, които ще участват в кръстословицата на случаен принцип
        Dim rand As Integer = RandomNumber(lst_words_vis.Items.Count - 1)
        Dim found As Boolean
        For i = 0 To chosenWord.Count - 1
            found = False
            Dim CountOfTries As Integer = 0
            rand = RandomNumber(lst_words_vis.Items.Count - 1)
            Do While found = False And CountOfTries < 1000000
                If InStr(lst_words_vis.Items(rand), chosenWord(i)) Then
                    pos_start(i) = InStr(lst_words_vis.Items(rand), chosenWord(i))
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
                    GoTo Beginning
                End If
            Loop
        Next

        For i = 0 To pos_start.Count - 1
            lst_pos_vis.Items.Add(pos_start(i))
        Next i

        'Извличане на значенията на избраните думи от базата данни
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            For j = 0 To izbrani_dumi.Count - 1
                If izbrani_dumi(j) = ds.Tables("rechnik").Rows(i).Item("duma") Then
                    meanings(j) = ds.Tables("rechnik").Rows(i).Item("znachenie")
                End If
            Next
        Next

        'Вкарване на избраните думи и технитен значения в текстови кутии
        For i = 0 To izbrani_dumi.Count - 1
            txtHints.Text = txtHints.Text & izbrani_dumi(i) & Environment.NewLine
        Next
        For i = 0 To meanings.Count - 1
            txtMeanings.Text = txtMeanings.Text & i + 1 & ". " & meanings(i) & Environment.NewLine
        Next

        'Намиране на размерите на двумерния масив, които ще съдържа кръстословицата
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

        num_v = Len(chosenWord)
        num_h = 1 + maxLeft + maxRight

        'Създаване на двумерния масив и текстовите кутии, и лейбълите с имената на въпросите
        Dim crossword(Len(chosenWord), 1 + maxLeft + maxRight) As Char
        Dim TextBoxes(num_v, num_h) As TextBox
        Dim TextBoxesInvisible(num_v, num_h) As TextBox
        For i = 0 To Len(chosenWord) - 1
            For j = 0 To maxLeft + maxRight
                TextBoxesInvisible(i, j) = New TextBox
                TextBoxesInvisible(i, j).Height = 25
                TextBoxesInvisible(i, j).MaxLength = 1
                TextBoxesInvisible(i, j).Width = 28
                TextBoxesInvisible(i, j).Top = 0
                TextBoxesInvisible(i, j).Left = 0
                TextBoxesInvisible(i, j).Name = "txtBoxInv" & i & j
                TextBoxesInvisible(i, j).Visible = False
                Controls.Add(TextBoxesInvisible(i, j))
            Next j
        Next i

        For i = 0 To Len(chosenWord) - 1
            For j = 0 To maxLeft + maxRight
                TextBoxes(i, j) = New TextBox
                TextBoxes(i, j).Height = 25
                TextBoxes(i, j).MaxLength = 1
                TextBoxes(i, j).Width = 28
                TextBoxes(i, j).TextAlign = HorizontalAlignment.Center
                TextBoxes(i, j).Font = New Font("Times New Roman", 14)
                TextBoxes(i, j).Multiline = True
                TextBoxes(i, j).Top = i * TextBoxes(i, j).Height + 80
                TextBoxes(i, j).Left = j * TextBoxes(i, j).Width + 60
                TextBoxes(i, j).Name = "txtBox" & i & j
                Controls.Add(TextBoxes(i, j))
            Next j
        Next i

        Dim NumBoxes(num_v) As Label
        For i = 0 To Len(chosenWord) - 1
            NumBoxes(i) = New Label
            NumBoxes(i).Height = 26.3
            NumBoxes(i).Width = 28
            NumBoxes(i).Top = i * NumBoxes(i).Height + 80
            NumBoxes(i).Left = NumBoxes(i).Width
            NumBoxes(i).Name = "NumBox" & i
            NumBoxes(i).Text = i + 1
            NumBoxes(i).Font = New Font("Times New Roman", 14)
            Controls.Add(NumBoxes(i))

        Next i
        For i = 0 To Len(chosenWord) - 1
            izbrani_dumi(i) = AddStars(maxLeft - pos_start(i) + 1, izbrani_dumi(i), "Left")
            izbrani_dumi(i) = AddStars(maxRight + maxLeft + 1 - Len(izbrani_dumi(i)), izbrani_dumi(i), "Right")

        Next
        For i = 0 To izbrani_dumi.Count - 1
            lst_izbrani_vis.Items.Add(izbrani_dumi(i))
        Next i
        Dim helpStr As String
        For i = 0 To Len(chosenWord) - 1
            helpStr = izbrani_dumi(i)
            For j = 0 To maxLeft + maxRight
                crossword(i, j) = helpStr(j)
            Next
        Next

        For i = 0 To Len(chosenWord) - 1
            For j = 0 To maxLeft + maxRight
                If j = maxLeft Then
                    TextBoxes(i, j).BackColor = Color.Cyan
                End If
                TextBoxes(i, j).Text = crossword(i, j)
                TextBoxesInvisible(i, j).Text = crossword(i, j)
            Next j
        Next i
        For i = 0 To Len(chosenWord) - 1
            For j = 0 To maxLeft + maxRight
                If TextBoxes(i, j).Text = "*" Then
                    TextBoxes(i, j).Visible = False
                Else
                    TextBoxes(i, j).Text = ""
                End If


            Next j
        Next i

        'Позициониране на контролите в формата
        txtMeanings.Left = num_h * 30 + 40
        If txtMeanings.Left < cmdCheckCrossword.Left + cmdCheckCrossword.Width Then
            txtMeanings.Left = cmdCheckCrossword.Left + cmdCheckCrossword.Width + 40
        End If
        txtMeanings.Height = num_v * 28 + 60
        txtHints.Height = num_v * 26
        txtHints.Width = (num_h + 1) * 28.2
        Me.Width = txtMeanings.Left + txtMeanings.Width + 30
        Me.Height = txtMeanings.Height + 60
        cmdMakeCrossword.Enabled = True
        cmdCheckCrossword.Enabled = True
        tmrCombo.Enabled = True
        tmrCombo.Start()

        'Изчистване на масивите
        Array.Clear(pos_start, pos_start.GetLowerBound(0), pos_start.Length)
        Array.Clear(izbrani_dumi, izbrani_dumi.GetLowerBound(0), izbrani_dumi.Length)

    End Sub
    'Функция спомагаща за преобразуването на избраните думи в двумерен масив
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

    'Процедура за изтриване на повтарящи се думи от списъчна кутия
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

    'Функция за генериране на случайно число
    Public Function RandomNumber(ByVal MaxNumber As Integer, Optional ByVal MinNumber As Integer = 0) As Integer

        Dim r As New Random(System.DateTime.Now.Millisecond)
        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function

    Private Sub cmdClearCrossword_Click() Handles cmdClearCrossword.Click

        'Изчисане на формата от динамичните контроли
        For i = 0 To num_v - 1
            For j = 0 To num_h - 1
                Controls.RemoveByKey("txtBox" & i & j)
                Controls.RemoveByKey("txtBoxInv" & i & j)
            Next j
        Next i
        For i = 0 To num_v - 1
            Controls.RemoveByKey("NumBox" & i)
        Next i
    End Sub


    Private Sub cmdCheckCrossword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheckCrossword.Click
        'Проверка как е решена кръстословицата
        Dim txt As Control
        Dim crosswordAnswers(num_v, num_h) As Char
        Dim crossword(num_v, num_h) As Char

        For i = 0 To num_v - 1
            For j = 0 To num_h - 1
                For Each txt In Controls
                    If TypeOf txt Is TextBox And txt.Name = "txtBox" & i & j Then
                        crosswordAnswers(i, j) = txt.Text
                    End If
                Next
            Next
        Next
        For i = 0 To num_v - 1
            For j = 0 To num_h - 1
                For Each txt In Controls
                    If TypeOf txt Is TextBox And txt.Name = "txtBoxInv" & i & j Then
                        crossword(i, j) = txt.Text
                    End If
                Next
            Next
        Next
        Dim numOfMistakes As String = ""
        Dim mistake As Boolean
        For i = 0 To num_v - 1
            mistake = False
            For j = 0 To num_h - 1
                If crossword(i, j) <> LCase(crosswordAnswers(i, j)) Then
                    mistake = True
                End If
            Next
            If mistake = True Then
                numOfMistakes = numOfMistakes & (i + 1) & ", "
            End If
        Next

        If numOfMistakes = "" Then
            MsgBox("Вие попълнихте кръстословицата правилно!!", , "Честито!")
        Else
            numOfMistakes = numOfMistakes.Substring(0, numOfMistakes.Length - 2)
            MsgBox("Вие имате грешки във въпросите - " & numOfMistakes & ".", , "Опааа!")
        End If

    End Sub

    Private Sub tmrCombo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCombo.Tick

        'Таймер, който следи дали е натисната кл. комбинация Ctrl + Alt + Shift
        'Ако е натисната визуализира решението на кръстословицата

        If My.Computer.Keyboard.AltKeyDown And My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.ShiftKeyDown Then
            txtHints.Visible = True


        Else
            txtHints.Visible = False
        End If

    End Sub
    'Кодове за навигацията на менюто
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