Public Class frmCrosswordSplash
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)

    Dim v_duma As String
    Dim pos_start() As Integer
    Private Sub frmCrosswordSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rs.Fill(ds, "Rechnik")
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        v_duma = lstWords.Items(lstWords.SelectedIndex)
        lst_words_vis.Items.Clear()
        Dim masiv As String
        masiv = v_duma.ToCharArray


        For i = 0 To lstWords.Items.Count - 1
            For j = 0 To masiv.Count - 1
                If InStr(lstWords.Items(i), masiv(j)) Then
                        lst_words_vis.Items.Add(lstWords.Items(i))
                End If
            Next j
        Next i

        RemoveDuplicateItem(lst_words_vis)

        For i = 0 To masiv.Count - 1
            Do While InStr(lst_words_vis.Items(RandomNumber(lst_words_vis.Items.Count - 1)), masiv(i)) = False

                pos_start(i) = InStr(lst_words_vis.Items(RandomNumber(lst_words_vis.Items.Count - 1)), masiv(i))
            Loop
        Next


    End Sub


    Function RemoveDuplicateItem(ByVal listboxName As ListBox)
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
    End Function

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

End Class