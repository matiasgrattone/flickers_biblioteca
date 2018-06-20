Public Class LOGIN
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim user As String
        Dim pass As String

        If LTrim$(usuario.Text) = "" Then ' Verifica si esta vacio nombre
            errorusuario.Text = "Nombre no puede estar vacío"
            i = 1
        Else
            user = usuario.Text
        End If

        If LTrim$(contrasenia.Text) = "" Then ' Verifica si esta vacio nombre
            errorpass.Text = "Nombre no puede estar vacío"
            i = 1
        Else
            pass = contrasenia.Text
        End If

        If i = 0 Then
            Try
                Consulta = "select contrasenia, nombre from usuarios where cedula = '" + user + "';"
                consultar()
                DataGridView1.DataSource = Tabla
                Dim row As DataGridViewRow = DataGridView1.CurrentRow
                Dim pass1 As String = CStr(row.Cells(0).Value)
                Modulo.nombre = CStr(row.Cells(1).Value)
                If pass1 = pass Then
                    Me.Hide()
                    MENU3.Show()
                Else
                    MsgBox("Cedula/Contraseaña Incorrecto")
                End If
            Catch ex As Exception
                MsgBox("Cedula/Contraseaña Incorrecto")
            End Try
        End If
    End Sub
End Class