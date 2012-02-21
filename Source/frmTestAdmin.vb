﻿Public Class frmTestAdmin
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM potrebiteli", con)

    Private Sub frmTestAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        rs.Fill(ds, "Potrebiteli")

        For i = 0 To ds.Tables("potrebiteli").Rows.Count - 1
            lst_users.Items.Add(ds.Tables("potrebiteli").Rows(i).Item("username"))
        Next
    End Sub

    Private Sub lst_users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_users.SelectedIndexChanged

        'Визуализиране на данните от базата данни в съотвестващи им label-и
        lbl_name_base.Text = ds.Tables("potrebiteli").Rows(lst_users.SelectedIndex).Item("username")
        lbl_class_base.Text = ds.Tables("potrebiteli").Rows(lst_users.SelectedIndex).Item("klas")
        lbl_date_base.Text = ds.Tables("potrebiteli").Rows(lst_users.SelectedIndex).Item("data_zap")
        lbl_points_base.Text = ds.Tables("potrebiteli").Rows(lst_users.SelectedIndex).Item("points")
        lbl_mark_base.Text = ds.Tables("potrebiteli").Rows(lst_users.SelectedIndex).Item("ocenka")

        'Присвояване на стойността на глобалната променлива за подреждане на въпросите в теста
        question_order = ds.Tables("potrebiteli").Rows(lst_users.SelectedIndex).Item("test")

    End Sub

    Private Sub cmd_show_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show_test.Click
        frmTestPast.Show()
    End Sub
End Class