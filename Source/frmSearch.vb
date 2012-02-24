Public Class frmSearch
    Private Sub FindText(ByVal text As String, ByVal dir As String)
        For Each f As String In My.Computer.FileSystem.GetFiles(dir, FileIO.SearchOption.SearchAllSubDirectories, "*.txt")

            Dim str() As String = System.IO.File.ReadAllLines(f)
            For Each s As String In str
                If s.Contains(text) Then
                    ListBox1.Items.Add(f)
                End If
            Next

        Next
        RemoveDuplicateItem(ListBox1)
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
        FindText(TextBox1.Text, AppDomain.CurrentDomain.BaseDirectory & "Info")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Items(ListBox1.SelectedIndex))
    End Sub
End Class