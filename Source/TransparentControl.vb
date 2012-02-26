Class TransparentControl
    Inherits Control

    Public Sub New()
        MyBase.New()
        MyBase.SetStyle(ControlStyles.UserPaint, True)
        MyBase.SetStyle(ControlStyles.DoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub
End Class
Class TransparentRichTextBox
    Inherits RichTextBox

    Public Sub New()
        MyBase.New()
        MyBase.ScrollBars = RichTextBoxScrollBars.None
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = (cp.ExStyle Or 32)
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)

    End Sub
End Class