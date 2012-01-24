<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneral
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnDiction = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnCrossword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(84, 29)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Калкулатор"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnDiction
        '
        Me.btnDiction.Location = New System.Drawing.Point(102, 12)
        Me.btnDiction.Name = "btnDiction"
        Me.btnDiction.Size = New System.Drawing.Size(84, 29)
        Me.btnDiction.TabIndex = 1
        Me.btnDiction.Text = "Речник"
        Me.btnDiction.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(192, 12)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(84, 29)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Админ"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnCrossword
        '
        Me.btnCrossword.Location = New System.Drawing.Point(282, 12)
        Me.btnCrossword.Name = "btnCrossword"
        Me.btnCrossword.Size = New System.Drawing.Size(98, 29)
        Me.btnCrossword.TabIndex = 3
        Me.btnCrossword.Text = "Кръстословица"
        Me.btnCrossword.UseVisualStyleBackColor = True
        '
        'frmGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 222)
        Me.Controls.Add(Me.btnCrossword)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnDiction)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmGeneral"
        Me.Text = "Начална страница"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnDiction As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnCrossword As System.Windows.Forms.Button

End Class
