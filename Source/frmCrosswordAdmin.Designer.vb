﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrosswordSplash
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
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdMakeCrossword = New System.Windows.Forms.Button()
        Me.lst_words_vis = New System.Windows.Forms.ListBox()
        Me.lst_pos_vis = New System.Windows.Forms.ListBox()
        Me.lst_izbrani_vis = New System.Windows.Forms.ListBox()
        Me.lst_meanings_vis = New System.Windows.Forms.ListBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(509, 23)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(133, 160)
        Me.lstWords.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(509, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Моля изберете ключова дума по вертикала"
        '
        'cmdMakeCrossword
        '
        Me.cmdMakeCrossword.Location = New System.Drawing.Point(509, 189)
        Me.cmdMakeCrossword.Name = "cmdMakeCrossword"
        Me.cmdMakeCrossword.Size = New System.Drawing.Size(133, 55)
        Me.cmdMakeCrossword.TabIndex = 11
        Me.cmdMakeCrossword.Text = "Генерирай кръстословица"
        Me.cmdMakeCrossword.UseVisualStyleBackColor = True
        '
        'lst_words_vis
        '
        Me.lst_words_vis.FormattingEnabled = True
        Me.lst_words_vis.Location = New System.Drawing.Point(648, 23)
        Me.lst_words_vis.Name = "lst_words_vis"
        Me.lst_words_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_words_vis.TabIndex = 12
        '
        'lst_pos_vis
        '
        Me.lst_pos_vis.FormattingEnabled = True
        Me.lst_pos_vis.Location = New System.Drawing.Point(792, 23)
        Me.lst_pos_vis.Name = "lst_pos_vis"
        Me.lst_pos_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_pos_vis.TabIndex = 13
        '
        'lst_izbrani_vis
        '
        Me.lst_izbrani_vis.FormattingEnabled = True
        Me.lst_izbrani_vis.Location = New System.Drawing.Point(936, 23)
        Me.lst_izbrani_vis.Name = "lst_izbrani_vis"
        Me.lst_izbrani_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_izbrani_vis.TabIndex = 14
        '
        'lst_meanings_vis
        '
        Me.lst_meanings_vis.FormattingEnabled = True
        Me.lst_meanings_vis.Location = New System.Drawing.Point(648, 189)
        Me.lst_meanings_vis.Name = "lst_meanings_vis"
        Me.lst_meanings_vis.Size = New System.Drawing.Size(426, 160)
        Me.lst_meanings_vis.TabIndex = 15
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(512, 250)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 20)
        Me.txtMax.TabIndex = 16
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(512, 276)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 20)
        Me.txtMin.TabIndex = 17
        '
        'frmCrosswordSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 361)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.lst_meanings_vis)
        Me.Controls.Add(Me.lst_izbrani_vis)
        Me.Controls.Add(Me.lst_pos_vis)
        Me.Controls.Add(Me.lst_words_vis)
        Me.Controls.Add(Me.cmdMakeCrossword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmCrosswordSplash"
        Me.Text = "CrosswordSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdMakeCrossword As System.Windows.Forms.Button
    Friend WithEvents lst_words_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_pos_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_izbrani_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_meanings_vis As System.Windows.Forms.ListBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
End Class