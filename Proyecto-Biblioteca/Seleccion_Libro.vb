Public Class Seleccion_Libro
    Dim P1, P2 As Integer
    Public buscarlibro1 As New buscarlibro
    Public ingresarlibro1 As New ingresolibro

    Private Sub Seleccion_Libro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pcbox3.Visible = False
        pcbox4.Visible = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        If Panel2.Width < 482 Then
            Panel2.Width += 10
            pcbox3.Visible = False
            pcbox4.Visible = False
        Else
            Timer10.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick
        If Panel2.Width > 60 And ERROR1 = 0 Then
            Panel2.Width -= 10
        ElseIf ERROR1 = 0 Then
            pcbox3.Visible = True
            pcbox4.Visible = False
            Timer20.Enabled = False
            buscarlibro1.TopLevel = False
            buscarlibro1.Parent = Panel1
            buscarlibro1.Show()
            pcbox1.Visible = False
            Label2.Visible = False
            buscarlibro1.Dock = DockStyle.Fill
            P2 = 0
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer30.Tick

        If Panel2.Width < 900 And ERROR1 = 0 Then
            Panel2.Width += 10

        ElseIf ERROR1 = 0 Then

            pcbox3.Visible = False
            pcbox4.Visible = True
            Timer10.Enabled = False

            ingresarlibro1.TopLevel = False
            ingresarlibro1.Parent = Panel2
            ingresarlibro1.Show()
            pcbox2.Visible = False
            Label1.Visible = False
            ingresarlibro1.Dock = DockStyle.Fill
        End If

    End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer40.Tick
        If Panel2.Width > 482 Then
            Panel2.Width -= 10
            pcbox3.Visible = False
            pcbox4.Visible = False

        Else

            Timer20.Enabled = False
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        Timer10.Enabled = False
        Timer20.Enabled = True
        Timer30.Enabled = False
        Timer40.Enabled = False

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = True
        Timer40.Enabled = False

    End Sub

    Private Sub pcbox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox3.Click

        Timer10.Enabled = True
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = False

        buscarlibro1.Hide()
        Label2.Visible = True
        pcbox1.Visible = True
    End Sub

    Private Sub pcbox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox4.Click

        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = True

        ingresarlibro1.Hide()
        Label1.Visible = True
        pcbox2.Visible = True

    End Sub

    Private Sub pcbox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox3.MouseEnter
        pcbox3.Image = My.Resources.ResourceManager.GetObject("right-arrow1")
    End Sub

    Private Sub pcbox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox4.MouseEnter
        pcbox4.Image = My.Resources.ResourceManager.GetObject("back1")

    End Sub

    Private Sub pcbox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox4.MouseLeave
        pcbox4.Image = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub pcbox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox3.MouseLeave
        pcbox3.Image = My.Resources.ResourceManager.GetObject("right-arrow1")
    End Sub

    Private Sub Label1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Drawing.Color.LightGray
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Drawing.Color.LightGray
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Drawing.Color.Black
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Drawing.Color.Black
    End Sub
End Class
