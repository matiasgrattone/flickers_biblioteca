Public Class Inicio_UsuariosV2
    Dim activado As Integer = 0
    Dim tamaño As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Select Case activado
            Case 1
                If Panel1.Left < 890 Then
                    Panel1.Left += 5
                    tamaño = tamaño + 5
                Else
                    activado = 0
                    DataGridView1.Width = DataGridView1.Width + tamaño
                    Timer1.Enabled = False
                    tamaño = 0
                End If
            Case 0
                If Panel1.Left > 640 Then
                    Panel1.Left -= 5
                    tamaño = tamaño + 5
                Else
                    activado = 1
                    DataGridView1.Width = DataGridView1.Width - tamaño
                    Timer1.Enabled = False
                    tamaño = 0
                End If
        End Select


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

End Class