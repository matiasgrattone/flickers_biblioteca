Public Class LOGIN
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim user As String = Nothing
        Dim pass As String = Nothing
        Dim pass1 As String = Nothing

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

                For Each row As DataRow In Tabla.Rows
                    pass1 = row("contrasenia").ToString
                Next


                '    DataGridView1.DataSource = Tabla
                '    Dim row As DataGridViewRow = DataGridView1.CurrentRow
                '    Dim pass1 As String = CStr(row.Cells(0).Value)
                '    Modulo.nombre = CStr(row.Cells(1).Value)
                If pass1 = pass Then
                    MENU3.Show()
                    Me.Hide()
                    MENU3.Nombre.Text = Modulo.nombre
                Else
                    MsgBox("Cedula/Contraseaña Incorrecto")
                End If
            Catch ex As Exception
                MsgBox("Cedula/Contraseaña Incorrecto")
            End Try
        End If
    End Sub

    Private Sub contrasenia_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles contrasenia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim user As String = Nothing
            Dim pass As String = Nothing

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
                        MENU3.Show()
                        Me.Close()
                        MENU3.Nombre.Text = Modulo.nombre
                    Else
                        MsgBox("Cedula/Contraseaña Incorrecto")
                    End If
                Catch ex As Exception
                    MsgBox("Cedula/Contraseaña Incorrecto")
                End Try
            End If
        End If


    End Sub

    Private Sub contrasenia_TextChanged(sender As System.Object, e As System.EventArgs) Handles contrasenia.TextChanged
        errorpass.Text = ""
        i = 0
    End Sub

    Private Sub usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim user As String = Nothing
            Dim pass As String = Nothing

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
                        MENU3.Show()
                        Me.Close()
                        MENU3.Nombre.Text = Modulo.nombre
                    Else
                        MsgBox("Cedula/Contraseaña Incorrecto")
                    End If
                Catch ex As Exception
                    MsgBox("Cedula/Contraseaña Incorrecto")
                End Try
            End If
        End If
    End Sub

    Private Sub usuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles usuario.TextChanged
        errorusuario.Text = ""
        i = 0
    End Sub

    Private Sub Labels_transparentes3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labels_transparentes3.Click
        invitado = 1
        MENU3.Show()
        Me.Hide()
        MENU3.Nombre.Text = "Invitado"
    End Sub
End Class