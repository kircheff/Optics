

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

                picBoxes(i).Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Info\" & chosenGallery & "\" & i & ".jpg")
                picBoxes(i).Height = Me.Height - 100
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
        

        Button2.Visible = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        visibleImageIndex = visibleImageIndex + 1
        tmrMove.Start()
        destination = "Right"
        Button2.Enabled = False
        Button1.Enabled = False
        Button2.Visible = True
        If visibleImageIndex = 4 Then
            Button1.Visible = False
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
            Button2.Enabled = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
  
        visibleImageIndex = visibleImageIndex - 1
        tmrMove.Start()
        destination = "Left"
        Button2.Enabled = False
        Button1.Enabled = False
        Button1.Visible = True
        If visibleImageIndex = 0 Then
            Button2.Visible = False
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