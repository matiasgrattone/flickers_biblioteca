Public Class Seleccion_Revistas

    Dim P1, P2 As Integer
    Public BuscarRevistas As New BusquedaRevistas
    Public IngresoRevistas As New IngresoRevistas

    Private Sub pcbox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox3.Click
        Timer10.Enabled = True
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = False

        BuscarRevistas.Hide()
        lbl2.Visible = True
        pcbox1.Visible = True
    End Sub

    Private Sub pcbox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbox4.Click
        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = False
        Timer40.Enabled = True

        IngresoRevistas.Hide()
        lbl1.Visible = True
        pcbox2.Visible = True

    End Sub

    Private Sub lbl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.Click
        Timer10.Enabled = False
        Timer20.Enabled = False
        Timer30.Enabled = True
        Timer40.Enabled = False
    End Sub

    Private Sub lbl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl2.Click
        Timer10.Enabled = False
        Timer20.Enabled = True
        Timer30.Enabled = False
        Timer40.Enabled = False
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        If Panel1.Width < 482 Then
            Panel1.Width += 10
            pcbox3.Visible = False
            pcbox4.Visible = False
        Else
            Timer10.Enabled = False
            pcbox2.Visible = True
        End If
       
    End Sub

    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick
        If Panel1.Width > 60 And ERROR1 = 0 Then
            Panel1.Width -= 10
        ElseIf ERROR1 = 0 Then
            pcbox3.Visible = True
            pcbox4.Visible = False
            Timer20.Enabled = False
            BuscarRevistas.TopLevel = False
            BuscarRevistas.Parent = Panel2
            BuscarRevistas.Show()
            pcbox2.Visible = False
            lbl2.Visible = False
            BuscarRevistas.Dock = DockStyle.Fill
            P2 = 0
        End If

    End Sub

    Private Sub Timer30_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer30.Tick
        If Panel1.Width < 900 And ERROR1 = 0 Then
            Panel1.Width += 10

        ElseIf ERROR1 = 0 Then

            pcbox3.Visible = False
            pcbox4.Visible = True
            Timer10.Enabled = False

            IngresoRevistas.TopLevel = False
            IngresoRevistas.Parent = Panel1
            IngresoRevistas.Dock = DockStyle.Fill
            IngresoRevistas.Show()

            pcbox1.Visible = False
            lbl1.Visible = False

        End If
    End Sub

    Private Sub Timer40_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer40.Tick
        If Panel1.Width > 482 Then
            Panel1.Width -= 10
            pcbox3.Visible = False
            pcbox4.Visible = False
        Else
            Timer20.Enabled = False
            pcbox1.Visible = True
        End If

    End Sub

    Private Sub pcbox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbox3.MouseEnter
        pcbox3.Image = My.Resources.ResourceManager.GetObject("right-arrow1")
    End Sub

    Private Sub pcbox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbox3.MouseLeave
        pcbox3.Image = My.Resources.ResourceManager.GetObject("right-arrow")
    End Sub

    Private Sub pcbox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbox4.MouseEnter
        pcbox4.Image = My.Resources.ResourceManager.GetObject("back1")
    End Sub

    Private Sub pcbox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcbox4.MouseLeave
        pcbox4.Image = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub lbl1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.MouseEnter
        lbl1.ForeColor = Drawing.Color.LightGray
    End Sub

    Private Sub lbl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.MouseLeave
        lbl1.ForeColor = Drawing.Color.Black
    End Sub

    Private Sub lbl2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl2.MouseEnter
        lbl2.ForeColor = Drawing.Color.LightGray
    End Sub

    Private Sub lbl2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl2.MouseLeave
        lbl2.ForeColor = Drawing.Color.Black
    End Sub

    Private Sub Seleccion_Revistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pcbox3.Visible = False
        pcbox4.Visible = False
    End Sub

End Class