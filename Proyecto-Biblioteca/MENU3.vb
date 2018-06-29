Imports System.Threading
Public Class MENU3
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer

    Dim opciontamaño As Integer = 0
    Dim respuesta As Integer = 1
    Dim transicion As Integer = 1



    Private Sub MENU3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
        WebBrowser1.Visible = False
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If a = 1 Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
            Me.Opacity = 0.9
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
        Me.Opacity = 1
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs)

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

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        Select Case transicion



            Case 1



                If Panel7.Location.X <= -602 Then

                    transicion = 2
                    '    Timer2.Stop()
                    ' Thread.Sleep(5000)


                Else

                    Panel6.Left -= 10
                    Panel7.Left -= 10




                End If

                If Panel9.Location.X >= 0 Then
                    Panel9.Left -= 5
                End If


            Case 2


                If Panel6.Location.X >= 602 Then

                    transicion = 1
                    ' Timer2.Stop()
                    'Thread.Sleep(5000)
                Else

                    Panel6.Left += 10
                    Panel7.Left += 10

                    If Panel9.Location.X <= 305 Then
                        Panel9.Left += 5
                    End If

                End If


            Case 3



        End Select

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Start()
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("www.google.com.uy")
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim timer As Integer = 0
        Select Case timer

            Case 0
                timer = 1
                Timer2.Start()
            Case 1
                timer = 0
                Timer2.Stop()
        End Select


    End Sub

End Class