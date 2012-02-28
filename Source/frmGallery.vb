

Public Class frmGallery
    Dim picBoxes() As PictureBox
    Dim destination As String
    Dim numOfMoves As Byte = 0
    Dim visibleImageIndex As Integer = 0


    Private Sub frmGallery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Array_Size As Integer = 4

        ReDim picBoxes(Array_Size)
        Try
            For i = 0 To Array_Size

                picBoxes(i) = New PictureBox

                picBoxes(i).Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & chosenGallery & "\" & i & ".jpg")
                picBoxes(i).Height = Me.Height
                picBoxes(i).Width = Me.Width
                picBoxes(i).SizeMode = PictureBoxSizeMode.StretchImage

                picBoxes(i).Top = 0
                picBoxes(i).Left = Me.Width * i

                Me.Controls.Add(picBoxes(i))

            Next
        Catch ex As Exception
            MsgBox("Файлът " & ex.Message & " липсва.", , "Грешка!")
            Me.Close()
        End Try
        

        cmd_back.Visible = False
    End Sub


    Private Sub cmd_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_next.Click
        visibleImageIndex = visibleImageIndex + 1
        tmrMove.Start()
        destination = "Right"
        cmd_back.Enabled = False
        cmd_next.Enabled = False
        cmd_back.Visible = True
        If visibleImageIndex = 4 Then
            cmd_next.Visible = False
        End If
    End Sub
    Sub moveImages(ByVal destination As String)
        If destination = "Right" Then
            For i = 0 To 4
                picBoxes(i).Left = picBoxes(i).Left - 50
            Next
        ElseIf destination = "Left" Then
            For i = 0 To 4
                picBoxes(i).Left = picBoxes(i).Left + 50
            Next
        End If
    End Sub

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick

        numOfMoves = numOfMoves + 1
        moveImages(destination)
        If numOfMoves = 10 Then

            numOfMoves = 0
            tmrMove.Stop()
            cmd_back.Enabled = True
            cmd_next.Enabled = True
        End If
    End Sub

    Private Sub cmd_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click

        visibleImageIndex = visibleImageIndex - 1
        tmrMove.Start()
        destination = "Left"
        cmd_back.Enabled = False
        cmd_next.Enabled = False
        cmd_next.Visible = True
        If visibleImageIndex = 0 Then
            cmd_back.Visible = False
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