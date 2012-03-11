<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaves))
        Me.Mnu = New System.Windows.Forms.MenuStrip()
        Me.НачалнаСтаницаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТърсенеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаПрограматаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаАвторитеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзползванаЛитератураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Mnu.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mnu
        '
        Me.Mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НачалнаСтаницаToolStripMenuItem, Me.ТърсенеToolStripMenuItem, Me.ПомощToolStripMenuItem})
        resources.ApplyResources(Me.Mnu, "Mnu")
        Me.Mnu.Name = "Mnu"
        '
        'НачалнаСтаницаToolStripMenuItem
        '
        Me.НачалнаСтаницаToolStripMenuItem.Name = "НачалнаСтаницаToolStripMenuItem"
        resources.ApplyResources(Me.НачалнаСтаницаToolStripMenuItem, "НачалнаСтаницаToolStripMenuItem")
        '
        'ТърсенеToolStripMenuItem
        '
        Me.ТърсенеToolStripMenuItem.Name = "ТърсенеToolStripMenuItem"
        resources.ApplyResources(Me.ТърсенеToolStripMenuItem, "ТърсенеToolStripMenuItem")
        '
        'ПомощToolStripMenuItem
        '
        Me.ПомощToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаПрограматаToolStripMenuItem, Me.ЗаАвторитеToolStripMenuItem, Me.ИзползванаЛитератураToolStripMenuItem})
        Me.ПомощToolStripMenuItem.Name = "ПомощToolStripMenuItem"
        resources.ApplyResources(Me.ПомощToolStripMenuItem, "ПомощToolStripMenuItem")
        '
        'ЗаПрограматаToolStripMenuItem
        '
        Me.ЗаПрограматаToolStripMenuItem.Name = "ЗаПрограматаToolStripMenuItem"
        resources.ApplyResources(Me.ЗаПрограматаToolStripMenuItem, "ЗаПрограматаToolStripMenuItem")
        '
        'ЗаАвторитеToolStripMenuItem
        '
        Me.ЗаАвторитеToolStripMenuItem.Name = "ЗаАвторитеToolStripMenuItem"
        resources.ApplyResources(Me.ЗаАвторитеToolStripMenuItem, "ЗаАвторитеToolStripMenuItem")
        '
        'ИзползванаЛитератураToolStripMenuItem
        '
        Me.ИзползванаЛитератураToolStripMenuItem.Name = "ИзползванаЛитератураToolStripMenuItem"
        resources.ApplyResources(Me.ИзползванаЛитератураToolStripMenuItem, "ИзползванаЛитератураToolStripMenuItem")
        '
        'AxShockwaveFlash1
        '
        resources.ApplyResources(Me.AxShockwaveFlash1, "AxShockwaveFlash1")
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'frmWaves
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Mnu)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmWaves"
        Me.Mnu.ResumeLayout(False)
        Me.Mnu.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents НачалнаСтаницаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТърсенеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаПрограматаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаАвторитеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзползванаЛитератураToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
