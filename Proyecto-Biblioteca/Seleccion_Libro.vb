Public Class Seleccion_Libro
    Dim P1, P2 As Integer
    Public buscarlibro1 As New buscarlibro

    Private Sub Seleccion_Libro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick


        If Panel2.Width < 482 Then
            Panel2.Width += 10
        Else
            Timer10.Enabled = False

        End If


    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer20.Tick

        If Panel2.Width > 60 Then
            Panel2.Width -= 10
        Else


            Timer20.Enabled = False

            buscarlibro1.TopLevel = False
            buscarlibro1.Parent = Panel1
            buscarlibro1.Show()
            PictureBox1.Visible = False
            Label2.Visible = False
            buscarlibro1.Dock = DockStyle.Fill

            P2 = 0
        End If




    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As System.EventArgs) Handles Panel1.MouseEnter


        'Timer1.Enabled = False
        'Timer2.Enabled = True
        'Timer3.Enabled = False
        'Timer4.Enabled = False

    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As System.EventArgs) Handles Panel1.MouseLeave


        Timer10.Enabled = True
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = False




    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer30.Tick

        If Panel2.Width < 900 Then
            Panel2.Width += 10
        Else
            Timer10.Enabled = False
        End If

    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As System.EventArgs) Handles Panel2.MouseEnter

        buscarlibro1.Hide()
        PictureBox1.Visible = True
        Label2.Visible = True

        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = True
        Timer40.Enabled = False


        P2 = 1






    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As System.EventArgs) Handles Panel2.MouseLeave

        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = True

    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer40.Tick
        If Panel2.Width > 482 Then
            Panel2.Width -= 10
        Else
            Timer20.Enabled = False
        End If

    End Sub

    Private Sub Panel1_mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick




    End Sub


    Private Sub Panel2_mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        ingresolibro.Show()
    End Sub


    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

        Timer10.Enabled = False
        Timer20.Enabled = True
        Timer30.Enabled = False
        Timer40.Enabled = False

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = True
        Timer40.Enabled = False

    End Sub
End Class