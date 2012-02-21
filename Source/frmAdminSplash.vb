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

        passHash = dt.Rows(0).Item("password")

        con.Close()
    End Sub

    Private Sub cmdDictAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDictAdmin.Click
        frmDictionaryAdmin.Show()
    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        If passHash = getMD5Hash(txtPassword.Text & "optics") Then
            cmdDictAdmin.Enabled = True
            cmdChangePass.Enabled = True
        Else
            MsgBox("Грешна парола!! Пробвай се пак!", , "Опаа!")
        End If
    End Sub

    Private Sub cmdChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangePass.Click
        frmChangePassword.show()
    End Sub
End Class