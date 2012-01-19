Public Class frmCalculator

    Dim sign_Indicator As Integer = 0
    Dim variable1 As Double
    Dim variable2 As Double
    Dim addBit As Integer = 0
    Dim subBit As Integer = 0
    Dim multBit As Integer = 0
    Dim divBit As Integer = 0
    Dim modBit As Integer = 0
    Dim powerBit As Integer = 0
    Dim memFuncsBit As Integer = 0
    Dim fl As Integer = 0
    Dim memoryVariable As Double = 0



    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(0)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 0
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(1)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 1
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(2)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 2
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(3)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 3
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(4)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 4
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(5)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 5
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(6)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 6
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(7)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 7
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(8)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 8
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(9)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 9
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub displayText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles displayText.KeyPress
        e.Handled = True
        If e.KeyChar Like "[0-9]" Or e.KeyChar = Chr(&H8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        If displayText.Text.Length = 0 Then
            displayText.Text = displayText.Text + CStr("-")
        ElseIf displayText.Text <> "." Then
            displayText.Text = displayText.Text * -1
        End If
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        displayText.Clear()
        sign_Indicator = 0
        variable1 = 0
        variable2 = 0
        memoryVariable = 0
        reset_SignBits()
    End Sub

    Private Sub btnClearTextbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTextbox.Click
        displayText.Clear()
    End Sub

    Private Function reset_SignBits()
        addBit = 0
        subBit = 0
        multBit = 0
        divBit = 0
        modBit = 0
        powerBit = 0
        fl = 0
        Return 0
    End Function


    Private Function Calculate()
        If displayText.Text <> "." Then

            variable2 = displayText.Text
            If fl = False Then
                variable1 = variable2
            ElseIf addBit = 1 Then
                variable1 = variable1 + variable2
            ElseIf subBit = 1 Then
                variable1 = variable1 - variable2
            ElseIf multBit = 1 Then
                variable1 = variable1 * variable2
            ElseIf divBit = 1 Then
                variable1 = variable1 / variable2
            ElseIf modBit = 1 Then
                variable1 = variable1 Mod variable2
            ElseIf powerBit = 1 Then
                variable1 = Math.Pow(variable1, variable2)
            Else
                variable1 = variable2
            End If
            displayText.Text = CStr(variable1)

        End If
        Return 0
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            addBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click

        If displayText.Text.Length <> 0 Then
            variable2 = displayText.Text
            Calculate()
            reset_SignBits()
            subBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            multBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            divBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnModulus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModulus.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            modBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPower.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            powerBit = 1
            sign_Indicator = 1
        End If
    End Sub



    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        Dim i As Integer
        Dim chr As Char
        Dim decimal_Indicator As Integer = 0

        If sign_Indicator <> 1 Then
            For i = 0 To displayText.Text.Count - 1
                chr = displayText.Text(i)
                If chr = "." Then
                    decimal_Indicator = 1
                End If
            Next

            If decimal_Indicator <> 1 Then
                displayText.Text = displayText.Text & CStr(".")
            End If
        End If
    End Sub


   

    Private Sub btnBackSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackSpace.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text.Remove(displayText.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInverse.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = 1 / displayText.Text
        End If
    End Sub

    Private Sub btnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Sin(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Cos(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPI.Click
        displayText.Text = Math.PI
        sign_Indicator = 1
    End Sub

 

    Private Sub btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlog.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Log10(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btne.Click
        displayText.Text = Math.E
        sign_Indicator = 1
    End Sub

    Private Sub btnex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnex.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Exp(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnsqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsqrt.Click
        If displayText.Text.Length <> 0 Then
            If displayText.Text <> "." Then
                displayText.Text = Math.Sqrt(displayText.Text)
            End If
            sign_Indicator = 1
        End If
    End Sub


    Public Function Factorial(ByVal temp)
        Dim result As Double = temp
        If temp = 0 Then
            Return 1
        Else
            For i = temp - 1 To 1 Step -1
                result = result * i
            Next
        End If
        Return result
    End Function

    Private Sub btnFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFact.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            Dim result = Factorial(temp)
            displayText.Text = CStr(result)
        End If
        sign_Indicator = 1
    End Sub


    Private Sub btnSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquare.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub
    Private Sub btnInvSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Asin(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnInvCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Acos(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnInvTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Atan(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        If displayText.Text.Length <> 0 Then
            If memoryVariable = 0 Then
                memoryVariable = CDbl(displayText.Text)
            End If
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub btnMplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMplus.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable + memoryVariable
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub btnMminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMminus.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable - memoryVariable
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub


    Private Sub btnEqual_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnTg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTg.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Tan(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnCotg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCotg.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = 1 / Math.Tan(displayText.Text)
        End If

        sign_Indicator = 1
    End Sub
End Class
