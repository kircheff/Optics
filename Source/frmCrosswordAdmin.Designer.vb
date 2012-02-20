<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmdMakeCrossword = New System.Windows.Forms.Button()
        Me.lst_words_vis = New System.Windows.Forms.ListBox()
        Me.lst_pos_vis = New System.Windows.Forms.ListBox()
        Me.lst_izbrani_vis = New System.Windows.Forms.ListBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.cmdClearCrossword = New System.Windows.Forms.Button()
        Me.txtMeanings = New System.Windows.Forms.TextBox()
        Me.cmdCheckCrossword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(509, 23)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(133, 160)
        Me.lstWords.TabIndex = 9
        Me.lstWords.Visible = False
        '
        'cmdMakeCrossword
        '
        Me.cmdMakeCrossword.Location = New System.Drawing.Point(29, 23)
        Me.cmdMakeCrossword.Name = "cmdMakeCrossword"
        Me.cmdMakeCrossword.Size = New System.Drawing.Size(186, 31)
        Me.cmdMakeCrossword.TabIndex = 11
        Me.cmdMakeCrossword.Text = "Генерирай нова кръстословица"
        Me.cmdMakeCrossword.UseVisualStyleBackColor = True
        '
        'lst_words_vis
        '
        Me.lst_words_vis.FormattingEnabled = True
        Me.lst_words_vis.Location = New System.Drawing.Point(648, 23)
        Me.lst_words_vis.Name = "lst_words_vis"
        Me.lst_words_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_words_vis.TabIndex = 12
        Me.lst_words_vis.Visible = False
        '
        'lst_pos_vis
        '
        Me.lst_pos_vis.FormattingEnabled = True
        Me.lst_pos_vis.Location = New System.Drawing.Point(792, 23)
        Me.lst_pos_vis.Name = "lst_pos_vis"
        Me.lst_pos_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_pos_vis.TabIndex = 13
        Me.lst_pos_vis.Visible = False
        '
        'lst_izbrani_vis
        '
        Me.lst_izbrani_vis.FormattingEnabled = True
        Me.lst_izbrani_vis.Location = New System.Drawing.Point(936, 23)
        Me.lst_izbrani_vis.Name = "lst_izbrani_vis"
        Me.lst_izbrani_vis.Size = New System.Drawing.Size(138, 160)
        Me.lst_izbrani_vis.TabIndex = 14
        Me.lst_izbrani_vis.Visible = False
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(512, 291)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 20)
        Me.txtMax.TabIndex = 16
        Me.txtMax.Visible = False
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(512, 317)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 20)
        Me.txtMin.TabIndex = 17
        Me.txtMin.Visible = False
        '
        'cmdClearCrossword
        '
        Me.cmdClearCrossword.Location = New System.Drawing.Point(77, 402)
        Me.cmdClearCrossword.Name = "cmdClearCrossword"
        Me.cmdClearCrossword.Size = New System.Drawing.Size(388, 31)
        Me.cmdClearCrossword.TabIndex = 18
        Me.cmdClearCrossword.Text = "Изчисти кръстословица"
        Me.cmdClearCrossword.UseVisualStyleBackColor = True
        Me.cmdClearCrossword.Visible = False
        '
        'txtMeanings
        '
        Me.txtMeanings.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtMeanings.Location = New System.Drawing.Point(524, 21)
        Me.txtMeanings.Multiline = True
        Me.txtMeanings.Name = "txtMeanings"
        Me.txtMeanings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMeanings.Size = New System.Drawing.Size(313, 431)
        Me.txtMeanings.TabIndex = 19
        '
        'cmdCheckCrossword
        '
        Me.cmdCheckCrossword.Location = New System.Drawing.Point(221, 23)
        Me.cmdCheckCrossword.Name = "cmdCheckCrossword"
        Me.cmdCheckCrossword.Size = New System.Drawing.Size(182, 31)
        Me.cmdCheckCrossword.TabIndex = 20
        Me.cmdCheckCrossword.Text = "Провери кръстословица"
        Me.cmdCheckCrossword.UseVisualStyleBackColor = True
        '
        'frmCrosswordSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 466)
        Me.Controls.Add(Me.cmdCheckCrossword)
        Me.Controls.Add(Me.txtMeanings)
        Me.Controls.Add(Me.cmdClearCrossword)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.lst_izbrani_vis)
        Me.Controls.Add(Me.lst_pos_vis)
        Me.Controls.Add(Me.lst_words_vis)
        Me.Controls.Add(Me.cmdMakeCrossword)
        Me.Controls.Add(Me.lstWords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCrosswordSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CrosswordSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents cmdMakeCrossword As System.Windows.Forms.Button
    Friend WithEvents lst_words_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_pos_vis As System.Windows.Forms.ListBox
    Friend WithEvents lst_izbrani_vis As System.Windows.Forms.ListBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearCrossword As System.Windows.Forms.Button
    Friend WithEvents txtMeanings As System.Windows.Forms.TextBox
    Friend WithEvents cmdCheckCrossword As System.Windows.Forms.Button
End Class
