<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstWordsResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(12, 58)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(116, 225)
        Me.lstWords.TabIndex = 0
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(178, 48)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(0, 13)
        Me.lblWord.TabIndex = 1
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.Location = New System.Drawing.Point(285, 201)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(39, 13)
        Me.lblMeaning.TabIndex = 2
        Me.lblMeaning.Text = "Label2"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(13, 32)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(115, 20)
        Me.txtSearch.TabIndex = 3
        '
        'lstWordsResults
        '
        Me.lstWordsResults.FormattingEnabled = True
        Me.lstWordsResults.Location = New System.Drawing.Point(125, 58)
        Me.lstWordsResults.Name = "lstWordsResults"
        Me.lstWordsResults.Size = New System.Drawing.Size(116, 225)
        Me.lstWordsResults.TabIndex = 4
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 381)
        Me.Controls.Add(Me.lstWordsResults)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmDatabase"
        Me.Text = "Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstWordsResults As System.Windows.Forms.ListBox
End Class
