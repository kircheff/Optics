<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrossword
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
        Me.lbl_word_general = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(484, 12)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(133, 316)
        Me.lstWords.TabIndex = 8
        '
        'lbl_word_general
        '
        Me.lbl_word_general.AutoSize = True
        Me.lbl_word_general.Location = New System.Drawing.Point(439, 13)
        Me.lbl_word_general.Name = "lbl_word_general"
        Me.lbl_word_general.Size = New System.Drawing.Size(13, 13)
        Me.lbl_word_general.TabIndex = 9
        Me.lbl_word_general.Text = "?"
        '
        'frmCrossword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 347)
        Me.Controls.Add(Me.lbl_word_general)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmCrossword"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents lbl_word_general As System.Windows.Forms.Label
End Class
