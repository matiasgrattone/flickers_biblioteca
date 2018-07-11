Public Class Seleccion_Libro
    Dim P1, P2 As Integer
    Private Sub Seleccion_Libro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


        If Panel2.Width < 482 Then
            Panel2.Width += 10
        Else
            Timer1.Enabled = False
        End If


    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        If Panel2.Width > 60 Then
            Panel2.Width -= 10
        Else
            Timer2.Enabled = False
        End If




    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As System.EventArgs) Handles Panel1.MouseEnter

        Timer1.Enabled = False
        Timer2.Enabled = True
        Timer3.Enabled = False
        Timer4.Enabled = False

    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As System.EventArgs) Handles Panel1.MouseLeave

        Timer1.Enabled = True
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick

        If Panel2.Width < 900 Then
            Panel2.Width += 10
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As System.EventArgs) Handles Panel2.MouseEnter

        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = True
        Timer4.Enabled = False

    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As System.EventArgs) Handles Panel2.MouseLeave

        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = True

    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If Panel2.Width > 482 Then
            Panel2.Width -= 10
        Else
            Timer2.Enabled = False
        End If

    End Sub

    Private Sub Panel1_mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        buscarlibro.Show()
    End Sub

    Private Sub Panel2_mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        ingresolibro.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class