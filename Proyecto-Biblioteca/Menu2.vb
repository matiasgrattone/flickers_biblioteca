Public Class Menu2
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf1, yf1, xf2, yf2 As Integer
    Private Sub Menu2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load





        Menu2_1.Show()

        Dim x = Me.Location.X
        Dim y = Me.Location.Y

        Me.Location = New Point(x + 192, y)
        Menu2_1.Location = New Point(x, y)
        Menu2_1.Opacity = 0.9


        yf2 = Menu2_1.Location.Y
        xf2 = Menu2_1.Location.X
        xf1 = Me.Location.X
        yf1 = Me.Location.Y
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
        Me.Opacity = 0.8
        Menu2_1.Opacity = 0.7
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf1 = Me.Location.X
        yf1 = Me.Location.Y
        yf2 = Menu2_1.Location.Y
        xf2 = Menu2_1.Location.X
        a = 0
        Me.Opacity = 1
        Menu2_1.Opacity = 0.9
    End Sub


    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove

        Select Case a
            Case 1
               
                xc = Cursor.Position.X
                yc = Cursor.Position.Y
                Me.Location = New Point(xf1 + (xc - xco), yf1 + (yc - yco))
                Menu2_1.Location = New Point(xf2 + (xc - xco), yf2 + (yc - yco))

            Case 0
                xco = Cursor.Position.X
                yco = Cursor.Position.Y
        End Select

    End Sub

End Class