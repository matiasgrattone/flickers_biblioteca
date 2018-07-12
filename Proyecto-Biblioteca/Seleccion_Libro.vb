Public Class Seleccion_Libro
    Dim P1, P2 As Integer
    Public buscarlibro1 As New buscarlibro
    Public ingresarlibro1 As New ingresolibro

    Private Sub Seleccion_Libro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick
        If Panel2.Width < 482 Then
            Panel2.Width += 10
            PictureBox3.Visible = False
            PictureBox4.Visible = False
        Else
            Timer10.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer20.Tick
        If Panel2.Width > 60 Then
            Panel2.Width -= 10
        Else
            PictureBox3.Visible = True
            PictureBox4.Visible = False
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

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer30.Tick

        If Panel2.Width < 900 Then
            Panel2.Width += 10

        Else

            PictureBox3.Visible = False
            PictureBox4.Visible = True
            Timer10.Enabled = False

            ingresarlibro1.TopLevel = False
            ingresarlibro1.Parent = Panel2
            ingresarlibro1.Show()
            PictureBox2.Visible = False
            Label1.Visible = False
            ingresarlibro1.Dock = DockStyle.Fill
        End If

    End Sub


    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer40.Tick
        If Panel2.Width > 482 Then
            Panel2.Width -= 10
            PictureBox3.Visible = False
            PictureBox4.Visible = False
        Else

            Timer20.Enabled = False
        End If

    End Sub

    Private Sub Panel1_mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick




    End Sub


    Private Sub Panel2_mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick

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

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        Timer10.Enabled = True
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = False

        buscarlibro1.Hide()
        Label2.Visible = True
        PictureBox1.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = True

        ingresarlibro1.Hide()
        Label1.Visible = True
        PictureBox2.Visible = True

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class