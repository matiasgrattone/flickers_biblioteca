Public Class Menu2
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Private Sub Menu2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
        Me.Opacity = 0.8
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub


    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove

        Select Case a
            Case 1
                xc = Cursor.Position.X
                yc = Cursor.Position.Y
                Me.Location = New Point(xf + (xc - xco), yf + (yc - yco))
            Case 0
                xco = Cursor.Position.X
                yco = Cursor.Position.Y
        End Select

    End Sub

End Class