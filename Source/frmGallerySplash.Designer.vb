<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGallerySplash
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
        Me.cmdGoRazprostranenie = New System.Windows.Forms.Button()
        Me.cmdGoOtrajenie = New System.Windows.Forms.Button()
        Me.cmdGoDispersiq = New System.Windows.Forms.Button()
        Me.cmdGoInterferenciq = New System.Windows.Forms.Button()
        Me.cmdGoDifrakciq = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdGoRazprostranenie
        '
        Me.cmdGoRazprostranenie.Location = New System.Drawing.Point(34, 23)
        Me.cmdGoRazprostranenie.Name = "cmdGoRazprostranenie"
        Me.cmdGoRazprostranenie.Size = New System.Drawing.Size(116, 28)
        Me.cmdGoRazprostranenie.TabIndex = 0
        Me.cmdGoRazprostranenie.Text = "Разпространение"
        Me.cmdGoRazprostranenie.UseVisualStyleBackColor = True
        '
        'cmdGoOtrajenie
        '
        Me.cmdGoOtrajenie.Location = New System.Drawing.Point(151, 23)
        Me.cmdGoOtrajenie.Name = "cmdGoOtrajenie"
        Me.cmdGoOtrajenie.Size = New System.Drawing.Size(113, 28)
        Me.cmdGoOtrajenie.TabIndex = 1
        Me.cmdGoOtrajenie.Text = "Отражение"
        Me.cmdGoOtrajenie.UseVisualStyleBackColor = True
        '
        'cmdGoDispersiq
        '
        Me.cmdGoDispersiq.Location = New System.Drawing.Point(90, 52)
        Me.cmdGoDispersiq.Name = "cmdGoDispersiq"
        Me.cmdGoDispersiq.Size = New System.Drawing.Size(117, 28)
        Me.cmdGoDispersiq.TabIndex = 2
        Me.cmdGoDispersiq.Text = "Дисперсия"
        Me.cmdGoDispersiq.UseVisualStyleBackColor = True
        '
        'cmdGoInterferenciq
        '
        Me.cmdGoInterferenciq.Location = New System.Drawing.Point(34, 81)
        Me.cmdGoInterferenciq.Name = "cmdGoInterferenciq"
        Me.cmdGoInterferenciq.Size = New System.Drawing.Size(116, 28)
        Me.cmdGoInterferenciq.TabIndex = 3
        Me.cmdGoInterferenciq.Text = "Интерференция"
        Me.cmdGoInterferenciq.UseVisualStyleBackColor = True
        '
        'cmdGoDifrakciq
        '
        Me.cmdGoDifrakciq.Location = New System.Drawing.Point(151, 81)
        Me.cmdGoDifrakciq.Name = "cmdGoDifrakciq"
        Me.cmdGoDifrakciq.Size = New System.Drawing.Size(113, 28)
        Me.cmdGoDifrakciq.TabIndex = 4
        Me.cmdGoDifrakciq.Text = "Дифракция"
        Me.cmdGoDifrakciq.UseVisualStyleBackColor = True
        '
        'frmGallerySplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 129)
        Me.Controls.Add(Me.cmdGoDifrakciq)
        Me.Controls.Add(Me.cmdGoInterferenciq)
        Me.Controls.Add(Me.cmdGoDispersiq)
        Me.Controls.Add(Me.cmdGoOtrajenie)
        Me.Controls.Add(Me.cmdGoRazprostranenie)
        Me.Name = "frmGallerySplash"
        Me.Text = "frmGallerySplash"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdGoRazprostranenie As System.Windows.Forms.Button
    Friend WithEvents cmdGoOtrajenie As System.Windows.Forms.Button
    Friend WithEvents cmdGoDispersiq As System.Windows.Forms.Button
    Friend WithEvents cmdGoInterferenciq As System.Windows.Forms.Button
    Friend WithEvents cmdGoDifrakciq As System.Windows.Forms.Button
End Class
