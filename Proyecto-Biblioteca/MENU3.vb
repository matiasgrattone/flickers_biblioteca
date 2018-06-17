Public Class MENU3
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer
    Dim opciontamaño As Integer = 0
    Dim respuesta As Integer = 1

    Private Sub MENU3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If a = 1 Then
            '///////////////////////////////////////////////////////MOUSE//////////////////////////////
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

        Select Case respuesta
            Case 1
                opciontamaño = 1
                Timer1.Start()
                respuesta = 2
            Case 2
                opciontamaño = 2
                Timer1.Start()
                respuesta = 1
        End Select


    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
     
        Select Case opciontamaño
            Case 1
                Panel3.Left -= 30
                If Panel3.Location.X = -2 Then
                    Timer1.Stop()
                End If
            Case 2
                Panel3.Left += 30
                If Panel3.Location.X = 47 Then
                    Timer1.Stop()
                End If
        End Select



    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        inicio_usuarios.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Form4.Show()
    End Sub
End Class