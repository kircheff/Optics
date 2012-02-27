Imports System.IO
Imports System
Public Class frmAdminSplash

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim dt As New DataTable("admin")
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM admin", con)
    Dim passHash As String
    Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function
    Private Sub frmAdminSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs.Fill(dt)

        passHash = dt.Rows(0).Item("parola")

        con.Close()
    End Sub

    Private Sub cmdDictAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDictAdmin.Click
        frmDictionaryAdmin.Show()
    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        If passHash = getMD5Hash(txtPassword.Text & "optics") Then
            cmdDictAdmin.Enabled = True
            cmdChangePass.Enabled = True
            cmdResetDB.Enabled = True

        Else
            MsgBox("Грешна парола!! Пробвай се пак!", , "Опаа!")
        End If
    End Sub

    Private Sub cmdChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangePass.Click
        frmChangePassword.Show()
    End Sub

    Private Sub cmdResetDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetDB.Click
        Dim response As VariantType
        response = MsgBox("Сигурни ли сте, че искате да върнете базата данни в начално състояние? Това ще изтрие всички промени в базата и ще върне началната парола на Админ панела.", vbYesNo + vbExclamation, "Внимание!")
        If response = vbYes Then
            response = MsgBox("Ама напълно ли сте убедени??", vbYesNo + vbExclamation, "Внимание!")
            If response = vbYes Then
                Try
                    'File.Delete(AppDomain.CurrentDomain.BaseDirectory & "Base.accdb")

                    File.Copy(AppDomain.CurrentDomain.BaseDirectory & "Info\Base.accdb", AppDomain.CurrentDomain.BaseDirectory & "Base.accdb", True)
                Catch ex As Exception

                End Try
            Else
                Exit Sub
            End If
        Else
            Exit Sub
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
        frmInfoProgram.Show()

    End Sub

    Private Sub ЗаАвторитеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаАвторитеToolStripMenuItem.Click
        frmInfoUs.show()
    End Sub

    Private Sub ИзползванаЛитератураToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзползванаЛитератураToolStripMenuItem.Click
        frmInfoLit.show()
    End Sub
End Class