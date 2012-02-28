Public Class frmDictionaryAdmin
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM rechnik", con)
    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        con.Open()

        rs.Fill(ds, "Rechnik")
        txtWord.Text = ds.Tables("rechnik").Rows(1).Item(1)
        For i = 0 To ds.Tables("rechnik").Rows.Count - 1
            lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
        Next i
    End Sub


    Private Sub cmdDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If lstWords.SelectedIndex = -1 Then
            MsgBox("Моля, изберете дума, която да изтриете.", vbOKOnly, "Oпаа!")
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(rs)
            ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Delete()
            rs.Update(ds, "Rechnik")
            lstWords.Items.Clear()
            For i = 0 To ds.Tables("rechnik").Rows.Count - 1
                lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
            Next i
            MsgBox("Думата е изтрита от базата данни.", , "Честито!")
        End If
    End Sub

    Private Sub cmdAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtAddWord.Text = "" Or txtAddMeaning.Text = "" Then
            MsgBox("НЕ може да добавяте празни записи в базата данни!", vbCritical + vbOKOnly, "Внимание!")
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(rs)
            ds.Tables("rechnik").Rows.Add(ds.Tables("rechnik").NewRow())
            ds.Tables("rechnik").Rows(ds.Tables("rechnik").Rows.Count - 1).Item("duma") = txtAddWord.Text
            ds.Tables("rechnik").Rows(ds.Tables("rechnik").Rows.Count - 1).Item("znachenie") = txtAddMeaning.Text
            ds.Tables("rechnik").Rows(ds.Tables("rechnik").Rows.Count - 1).Item("ID") = ds.Tables("rechnik").Rows.Count - 1
            rs.Update(ds, "Rechnik")
            lstWords.Items.Clear()
            For i = 0 To ds.Tables("rechnik").Rows.Count - 1
                lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
            Next i

            MsgBox("Думата е добавена в базата данни. За да се запишат промените формата ще се затвори автоматично.", , "Честито!")
            Me.Close()
        End If
    End Sub

    Private Sub lstWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWords.SelectedIndexChanged
        txtWord.Text = ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("duma").ToString
        txtMeaning.Text = ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("znachenie").ToString
        txtWord.Enabled = False
        txtMeaning.Enabled = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cb As New OleDb.OleDbCommandBuilder(rs)
        If txtWord.Text = "" Or txtMeaning.Text = "" Then
            MsgBox("НЕ може да добавяте празни записи в базата данни!", vbCritical + vbOKOnly, "Внимание!")
        Else
            ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("duma") = txtWord.Text
            ds.Tables("rechnik").Rows(lstWords.SelectedIndex).Item("znachenie") = txtMeaning.Text

            rs.Update(ds, "Rechnik")

            lstWords.Items.Clear()
            For i = 0 To ds.Tables("rechnik").Rows.Count - 1
                lstWords.Items.Add(ds.Tables("rechnik").Rows(i).Item("duma"))
            Next i

            MsgBox("Информацията е обновена.", , "Честито!")

            txtWord.Enabled = False
            txtMeaning.Enabled = False
        End If
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        txtWord.Enabled = True
        txtMeaning.Enabled = True
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