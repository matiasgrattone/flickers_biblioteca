Public Class Menu1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Modulo.nombre

        Try
            Consulta = "select nombre, titulo, fecha_salida from usuarios u inner join prestamo p on u.cedula=p.cedula inner join libro l on p.cod_libro=l.cod_libro;"
            consultar()
            Lunes.DataSource = Tabla
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        inicio_usuarios.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Dispose()
        LOGIN.Show()
    End Sub
End Class