Public Class labels_transparentes
    Inherits Control
    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim mybrush As Brush = New SolidBrush(ForeColor)
        e.Graphics.DrawString(Text, Font, mybrush, New PointF(-1, 0))
    End Sub
    Protected Overrides Sub OnPaintbackground(ByVal e As PaintEventArgs)
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20
            Return cp
        End Get
    End Property
End Class
