Public Class frmInformation
    'Променливи за връзка с базата данни
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Base.accdb")
    Dim ds As New DataSet
    Dim rs_information As New OleDb.OleDbDataAdapter("SELECT * FROM information", con)
    Dim rs_tochki As New OleDb.OleDbDataAdapter("SELECT * FROM tochki", con)
    Dim numOfMoves As Byte = 0
    Dim opened As Boolean = False


    Dim custRow As DataRow
    Dim orderRow As DataRow



    Private Sub frmInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()

        rs_information.Fill(ds, "information")
        rs_tochki.Fill(ds, "tochki")
       
        Dim datarel As DataRelation = ds.Relations.Add("Infotochka", _
                      ds.Tables("information").Columns("ID"), _
                      ds.Tables("tochki").Columns("tochka_urok"))

        Dim i As Byte = 0
        For Each Me.custRow In ds.Tables("information").Rows

            trv_info.Nodes.Add(custRow.Item("statia"))
            For Each Me.orderRow In custRow.GetChildRows(datarel)
                trv_info.Nodes(custRow.Item("Id") - 1).Nodes.Add(orderRow.Item("tochka_ime"))
            Next

        Next
    End Sub



    Private Sub pnl_menu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl_menu.MouseHover
        If opened = False Then
            tmrMovePanelIn.Start()
        End If

    End Sub
    Sub moveImages(ByVal destination As String)
        If destination = "Right" Then

            pnl_menu.Left = pnl_menu.Left - 40

        ElseIf destination = "Left" Then

            pnl_menu.Left = pnl_menu.Left + 40

        End If
    End Sub

    Private Sub tmrMovePanelIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovePanelIn.Tick
        numOfMoves = numOfMoves + 1
        moveImages("Left")
        If numOfMoves = 6 Then

            numOfMoves = 0
            tmrMovePanelIn.Stop()
            opened = True
        End If
    End Sub

    Private Sub tmrMovePanelOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovePanelOut.Tick
        numOfMoves = numOfMoves + 1
        moveImages("Right")
        If numOfMoves = 6 Then

            numOfMoves = 0
            tmrMovePanelOut.Stop()
            opened = False
        End If
    End Sub

    Private Sub pnl_menu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl_menu.MouseLeave
        If opened = True Then
            tmrMovePanelOut.Start()
        End If
    End Sub


    Private Sub trv_info_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_info.AfterSelect
        Dim datarel As DataRelation = ds.Relations.Item("Infotochka")

        Try
            Dim selected_node As String
            selected_node = trv_info.SelectedNode.Text.ToString()
            For Each Me.custRow In ds.Tables("information").Rows
                For Each Me.orderRow In custRow.GetChildRows(datarel)
                    If selected_node = Me.orderRow.Item("tochka_ime") Then
                        rtb_info.LoadFile(AppDomain.CurrentDomain.BaseDirectory & custRow.Item("Directory").ToString & "\" & orderRow.Item("tochka_podredba") & ".rtf")
                    End If
                Next

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class