<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoUs
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
        Me.rtb_info = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtb_info
        '
        Me.rtb_info.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.rtb_info.Location = New System.Drawing.Point(16, 9)
        Me.rtb_info.Name = "rtb_info"
        Me.rtb_info.Size = New System.Drawing.Size(301, 293)
        Me.rtb_info.TabIndex = 1
        Me.rtb_info.Text = ""
        '
        'frmInfoUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 310)
        Me.Controls.Add(Me.rtb_info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInfoUs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "За авторите"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtb_info As System.Windows.Forms.RichTextBox
End Class
