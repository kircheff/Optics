<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.displayText = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnInverse = New System.Windows.Forms.Button()
        Me.btnModulus = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnPI = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.btne = New System.Windows.Forms.Button()
        Me.btnex = New System.Windows.Forms.Button()
        Me.btnsqrt = New System.Windows.Forms.Button()
        Me.btnFact = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnClearTextbox = New System.Windows.Forms.Button()
        Me.btnMplus = New System.Windows.Forms.Button()
        Me.btnMminus = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnCotg = New System.Windows.Forms.Button()
        Me.btnTg = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'displayText
        '
        Me.displayText.BackColor = System.Drawing.Color.Silver
        Me.displayText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayText.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayText.Location = New System.Drawing.Point(12, 38)
        Me.displayText.Name = "displayText"
        Me.displayText.Size = New System.Drawing.Size(467, 31)
        Me.displayText.TabIndex = 0
        Me.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.DimGray
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(186, 201)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 37)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.DimGray
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(244, 201)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(60, 37)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.DimGray
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(302, 201)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(60, 37)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.DimGray
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(186, 166)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(60, 37)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.DimGray
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(244, 166)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(60, 37)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.DimGray
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(302, 166)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(60, 37)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.DimGray
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(186, 131)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(60, 37)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.DimGray
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(244, 131)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(60, 37)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.DimGray
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(302, 131)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(60, 37)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.DimGray
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(186, 236)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(60, 37)
        Me.btn0.TabIndex = 0
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Location = New System.Drawing.Point(360, 236)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 37)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.DimGray
        Me.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSub.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSub.Location = New System.Drawing.Point(360, 200)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(60, 37)
        Me.btnSub.TabIndex = 11
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnMult
        '
        Me.btnMult.BackColor = System.Drawing.Color.DimGray
        Me.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMult.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMult.Location = New System.Drawing.Point(360, 166)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(60, 37)
        Me.btnMult.TabIndex = 12
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = False
        '
        'btnDiv
        '
        Me.btnDiv.BackColor = System.Drawing.Color.DimGray
        Me.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiv.Font = New System.Drawing.Font("Courier New", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDiv.Location = New System.Drawing.Point(360, 131)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(60, 37)
        Me.btnDiv.TabIndex = 13
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = False
        '
        'btnDecimal
        '
        Me.btnDecimal.BackColor = System.Drawing.Color.DimGray
        Me.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecimal.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDecimal.Location = New System.Drawing.Point(244, 236)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(60, 37)
        Me.btnDecimal.TabIndex = 15
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = False
        '
        'btnSign
        '
        Me.btnSign.BackColor = System.Drawing.Color.DimGray
        Me.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSign.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSign.Location = New System.Drawing.Point(302, 236)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(60, 37)
        Me.btnSign.TabIndex = 16
        Me.btnSign.Text = "+/-"
        Me.btnSign.UseVisualStyleBackColor = False
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Courier New", 14.75!, System.Drawing.FontStyle.Bold)
        Me.btnClearAll.ForeColor = System.Drawing.Color.White
        Me.btnClearAll.Location = New System.Drawing.Point(388, 82)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(60, 37)
        Me.btnClearAll.TabIndex = 17
        Me.btnClearAll.Text = "C"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnBackSpace
        '
        Me.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackSpace.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSpace.ForeColor = System.Drawing.Color.White
        Me.btnBackSpace.Location = New System.Drawing.Point(255, 82)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(60, 37)
        Me.btnBackSpace.TabIndex = 18
        Me.btnBackSpace.Text = "<-"
        Me.btnBackSpace.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnInverse
        '
        Me.btnInverse.BackColor = System.Drawing.Color.DimGray
        Me.btnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInverse.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInverse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInverse.Location = New System.Drawing.Point(129, 200)
        Me.btnInverse.Name = "btnInverse"
        Me.btnInverse.Size = New System.Drawing.Size(60, 37)
        Me.btnInverse.TabIndex = 28
        Me.btnInverse.Text = "1/x"
        Me.btnInverse.UseVisualStyleBackColor = False
        '
        'btnModulus
        '
        Me.btnModulus.BackColor = System.Drawing.Color.DimGray
        Me.btnModulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModulus.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModulus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModulus.Location = New System.Drawing.Point(129, 236)
        Me.btnModulus.Name = "btnModulus"
        Me.btnModulus.Size = New System.Drawing.Size(60, 37)
        Me.btnModulus.TabIndex = 29
        Me.btnModulus.Text = "%"
        Me.btnModulus.UseVisualStyleBackColor = False
        '
        'btnPower
        '
        Me.btnPower.BackColor = System.Drawing.Color.DimGray
        Me.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPower.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPower.Location = New System.Drawing.Point(419, 131)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(60, 37)
        Me.btnPower.TabIndex = 33
        Me.btnPower.Text = "x^"
        Me.btnPower.UseVisualStyleBackColor = False
        '
        'btnPI
        '
        Me.btnPI.BackColor = System.Drawing.Color.DimGray
        Me.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPI.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPI.Location = New System.Drawing.Point(70, 131)
        Me.btnPI.Name = "btnPI"
        Me.btnPI.Size = New System.Drawing.Size(60, 37)
        Me.btnPI.TabIndex = 34
        Me.btnPI.Text = "PI"
        Me.btnPI.UseVisualStyleBackColor = False
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.DimGray
        Me.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlog.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlog.Location = New System.Drawing.Point(70, 236)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(60, 37)
        Me.btnlog.TabIndex = 42
        Me.btnlog.Text = "log"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'btne
        '
        Me.btne.BackColor = System.Drawing.Color.DimGray
        Me.btne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btne.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btne.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btne.Location = New System.Drawing.Point(70, 202)
        Me.btne.Name = "btne"
        Me.btne.Size = New System.Drawing.Size(60, 37)
        Me.btne.TabIndex = 44
        Me.btne.Text = "e"
        Me.btne.UseVisualStyleBackColor = False
        '
        'btnex
        '
        Me.btnex.BackColor = System.Drawing.Color.DimGray
        Me.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnex.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnex.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnex.Location = New System.Drawing.Point(129, 131)
        Me.btnex.Name = "btnex"
        Me.btnex.Size = New System.Drawing.Size(60, 37)
        Me.btnex.TabIndex = 45
        Me.btnex.Text = "e^x"
        Me.btnex.UseVisualStyleBackColor = False
        '
        'btnsqrt
        '
        Me.btnsqrt.BackColor = System.Drawing.Color.DimGray
        Me.btnsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsqrt.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsqrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsqrt.Location = New System.Drawing.Point(70, 166)
        Me.btnsqrt.Name = "btnsqrt"
        Me.btnsqrt.Size = New System.Drawing.Size(60, 37)
        Me.btnsqrt.TabIndex = 46
        Me.btnsqrt.Text = "sqrt"
        Me.btnsqrt.UseVisualStyleBackColor = False
        '
        'btnFact
        '
        Me.btnFact.BackColor = System.Drawing.Color.DimGray
        Me.btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFact.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFact.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFact.Location = New System.Drawing.Point(129, 167)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(60, 36)
        Me.btnFact.TabIndex = 50
        Me.btnFact.Text = "x!"
        Me.btnFact.UseVisualStyleBackColor = False
        '
        'btnSquare
        '
        Me.btnSquare.BackColor = System.Drawing.Color.DimGray
        Me.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSquare.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSquare.Location = New System.Drawing.Point(419, 167)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(60, 36)
        Me.btnSquare.TabIndex = 54
        Me.btnSquare.Text = "x^2"
        Me.btnSquare.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM.ForeColor = System.Drawing.Color.White
        Me.btnM.Location = New System.Drawing.Point(173, 82)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(60, 37)
        Me.btnM.TabIndex = 57
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'btnClearTextbox
        '
        Me.btnClearTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearTextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextbox.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextbox.ForeColor = System.Drawing.Color.White
        Me.btnClearTextbox.Location = New System.Drawing.Point(321, 82)
        Me.btnClearTextbox.Name = "btnClearTextbox"
        Me.btnClearTextbox.Size = New System.Drawing.Size(60, 37)
        Me.btnClearTextbox.TabIndex = 58
        Me.btnClearTextbox.Text = "CE"
        Me.btnClearTextbox.UseVisualStyleBackColor = False
        '
        'btnMplus
        '
        Me.btnMplus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMplus.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMplus.ForeColor = System.Drawing.Color.White
        Me.btnMplus.Location = New System.Drawing.Point(108, 82)
        Me.btnMplus.Name = "btnMplus"
        Me.btnMplus.Size = New System.Drawing.Size(60, 37)
        Me.btnMplus.TabIndex = 59
        Me.btnMplus.Text = "M+"
        Me.btnMplus.UseVisualStyleBackColor = False
        '
        'btnMminus
        '
        Me.btnMminus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMminus.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMminus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMminus.Location = New System.Drawing.Point(45, 82)
        Me.btnMminus.Name = "btnMminus"
        Me.btnMminus.Size = New System.Drawing.Size(58, 37)
        Me.btnMminus.TabIndex = 60
        Me.btnMminus.Text = "M-"
        Me.btnMminus.UseVisualStyleBackColor = False
        '
        'btnSin
        '
        Me.btnSin.BackColor = System.Drawing.Color.DimGray
        Me.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSin.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSin.Location = New System.Drawing.Point(12, 131)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(60, 37)
        Me.btnSin.TabIndex = 61
        Me.btnSin.Text = "sin"
        Me.btnSin.UseVisualStyleBackColor = False
        '
        'btnCos
        '
        Me.btnCos.BackColor = System.Drawing.Color.DimGray
        Me.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCos.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCos.Location = New System.Drawing.Point(12, 166)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(60, 37)
        Me.btnCos.TabIndex = 64
        Me.btnCos.Text = "cos"
        Me.btnCos.UseVisualStyleBackColor = False
        '
        'btnCotg
        '
        Me.btnCotg.BackColor = System.Drawing.Color.DimGray
        Me.btnCotg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotg.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCotg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCotg.Location = New System.Drawing.Point(12, 236)
        Me.btnCotg.Name = "btnCotg"
        Me.btnCotg.Size = New System.Drawing.Size(60, 37)
        Me.btnCotg.TabIndex = 62
        Me.btnCotg.Text = "cotg"
        Me.btnCotg.UseVisualStyleBackColor = False
        '
        'btnTg
        '
        Me.btnTg.BackColor = System.Drawing.Color.DimGray
        Me.btnTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTg.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTg.Location = New System.Drawing.Point(12, 202)
        Me.btnTg.Name = "btnTg"
        Me.btnTg.Size = New System.Drawing.Size(60, 37)
        Me.btnTg.TabIndex = 63
        Me.btnTg.Text = "tg"
        Me.btnTg.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.DimGray
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqual.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEqual.Location = New System.Drawing.Point(419, 202)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(60, 71)
        Me.btnEqual.TabIndex = 65
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(494, 24)
        Me.Menu.TabIndex = 66
        Me.Menu.Text = "MenuStrip1"
        '
        'НачалнаСтаницаToolStripMenuItem
        '
        Me.НачалнаСтаницаToolStripMenuItem.Name = "НачалнаСтаницаToolStripMenuItem"
        Me.НачалнаСтаницаToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.НачалнаСтаницаToolStripMenuItem.Text = "Начална станица"
        '
        'ТърсенеToolStripMenuItem
        '
        Me.ТърсенеToolStripMenuItem.Name = "ТърсенеToolStripMenuItem"
        Me.ТърсенеToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ТърсенеToolStripMenuItem.Text = "Търсене"
        '
        'ПомощToolStripMenuItem
        '
        Me.ПомощToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаПрограматаToolStripMenuItem, Me.ЗаАвторитеToolStripMenuItem, Me.ИзползванаЛитератураToolStripMenuItem})
        Me.ПомощToolStripMenuItem.Name = "ПомощToolStripMenuItem"
        Me.ПомощToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ПомощToolStripMenuItem.Text = "Помощ"
        '
        'ЗаПрограматаToolStripMenuItem
        '
        Me.ЗаПрограматаToolStripMenuItem.Name = "ЗаПрограматаToolStripMenuItem"
        Me.ЗаПрограматаToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ЗаПрограматаToolStripMenuItem.Text = "За програмата"
        '
        'ЗаАвторитеToolStripMenuItem
        '
        Me.ЗаАвторитеToolStripMenuItem.Name = "ЗаАвторитеToolStripMenuItem"
        Me.ЗаАвторитеToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ЗаАвторитеToolStripMenuItem.Text = "За авторите"
        '
        'ИзползванаЛитератураToolStripMenuItem
        '
        Me.ИзползванаЛитератураToolStripMenuItem.Name = "ИзползванаЛитератураToolStripMenuItem"
        Me.ИзползванаЛитератураToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ИзползванаЛитератураToolStripMenuItem.Text = "Използвана литература"
        '
        'frmCalculator
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(494, 292)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnCotg)
        Me.Controls.Add(Me.btnTg)
        Me.Controls.Add(Me.btnPI)
        Me.Controls.Add(Me.btnFact)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnMminus)
        Me.Controls.Add(Me.btnMplus)
        Me.Controls.Add(Me.btnClearTextbox)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnsqrt)
        Me.Controls.Add(Me.btnex)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnModulus)
        Me.Controls.Add(Me.btnInverse)
        Me.Controls.Add(Me.btnBackSpace)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.displayText)
        Me.Controls.Add(Me.btne)
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Калкулатор"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayText As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnMult As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnBackSpace As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnInverse As System.Windows.Forms.Button
    Friend WithEvents btnModulus As System.Windows.Forms.Button
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnPI As System.Windows.Forms.Button
    Friend WithEvents btnlog As System.Windows.Forms.Button
    Friend WithEvents btne As System.Windows.Forms.Button
    Friend WithEvents btnex As System.Windows.Forms.Button
    Friend WithEvents btnsqrt As System.Windows.Forms.Button
    Friend WithEvents btnFact As System.Windows.Forms.Button
    Friend WithEvents btnSquare As System.Windows.Forms.Button
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents btnClearTextbox As System.Windows.Forms.Button
    Friend WithEvents btnMplus As System.Windows.Forms.Button
    Friend WithEvents btnMminus As System.Windows.Forms.Button
    Friend WithEvents btnSin As System.Windows.Forms.Button
    Friend WithEvents btnCos As System.Windows.Forms.Button
    Friend WithEvents btnCotg As System.Windows.Forms.Button
    Friend WithEvents btnTg As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
