Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Class PictureboxBordesRedondos
    Inherits PictureBox

    Public Sub New()
        Me.BackColor = Color.DarkGray
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)

        Using gp = New GraphicsPath()
            gp.AddEllipse(New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
            Me.Region = New Region(gp)
        End Using
    End Sub
End Class
