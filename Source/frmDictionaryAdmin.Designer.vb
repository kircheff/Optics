<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDictionaryAdmin
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtAddMeaning = New System.Windows.Forms.TextBox()
        Me.txtAddWord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtMeaning = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(516, 379)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmdAdd)
        Me.TabPage1.Controls.Add(Me.txtAddMeaning)
        Me.TabPage1.Controls.Add(Me.txtAddWord)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmdChange)
        Me.TabPage1.Controls.Add(Me.lstWords)
        Me.TabPage1.Controls.Add(Me.cmdSave)
        Me.TabPage1.Controls.Add(Me.txtMeaning)
        Me.TabPage1.Controls.Add(Me.txtWord)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(508, 353)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "la"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Изтрий избраната дума от речника"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Добави нова дума"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(324, 180)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(156, 23)
        Me.cmdAdd.TabIndex = 13
        Me.cmdAdd.Text = " Добави"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtAddMeaning
        '
        Me.txtAddMeaning.Location = New System.Drawing.Point(324, 116)
        Me.txtAddMeaning.Multiline = True
        Me.txtAddMeaning.Name = "txtAddMeaning"
        Me.txtAddMeaning.Size = New System.Drawing.Size(156, 58)
        Me.txtAddMeaning.TabIndex = 12
        Me.txtAddMeaning.Text = "Напишете значение..."
        '
        'txtAddWord
        '
        Me.txtAddWord.Location = New System.Drawing.Point(324, 90)
        Me.txtAddWord.Name = "txtAddWord"
        Me.txtAddWord.Size = New System.Drawing.Size(156, 20)
        Me.txtAddWord.TabIndex = 11
        Me.txtAddWord.Text = "Напишете думата..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Промяна на дума"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Речник"
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(162, 180)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 8
        Me.cmdChange.Text = "Промени"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(19, 67)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(133, 225)
        Me.lstWords.TabIndex = 7
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(243, 180)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Запамети"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtMeaning
        '
        Me.txtMeaning.Enabled = False
        Me.txtMeaning.Location = New System.Drawing.Point(162, 116)
        Me.txtMeaning.Multiline = True
        Me.txtMeaning.Name = "txtMeaning"
        Me.txtMeaning.Size = New System.Drawing.Size(156, 58)
        Me.txtMeaning.TabIndex = 4
        '
        'txtWord
        '
        Me.txtWord.Enabled = False
        Me.txtWord.Location = New System.Drawing.Point(162, 90)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(156, 20)
        Me.txtWord.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(508, 353)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 403)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmAdmin"
        Me.Text = "Администраторски панел"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents txtAddMeaning As System.Windows.Forms.TextBox
    Friend WithEvents txtAddWord As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtMeaning As System.Windows.Forms.TextBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
