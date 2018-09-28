Public Class LOGIN
    Dim i As Integer = 0
    Dim mailrecuperar As String = Nothing
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
                Consulta = "select contrasenia , nombre , cedula from usuarios where cedula = '" + user + "' and tipo<'2';"
                consultar()

                For Each row As DataRow In Tabla.Rows

                    If row("contrasenia").ToString = pass Then
                        MENU3.Nombre.Text = row("nombre")
                        MENU3.lbl_cedula.Text = row("cedula")

                        MENU3.cedulaIngre = row("cedula").ToString

                        Me.Hide()
                        MENU3.Show()
                    Else
                        MsgBox("Cedula/Contraseaña Incorrecto")
                    End If


                Next

            Catch ex As Exception
                MsgBox("Cedula/Contraseaña Incorrecto")
            End Try
        End If
    End Sub

    Private Sub contrasenia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles contrasenia.KeyDown
        If e.KeyCode = Keys.Enter Then
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
                    Consulta = "select contrasenia , nombre , cedula from usuarios where cedula = '" + user + "' and tipo<'2';"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        If row("contrasenia").ToString = pass Then
                            MENU3.Nombre.Text = row("nombre")
                            MENU3.lbl_cedula.Text = row("cedula")
                            Me.Hide()
                            MENU3.Show()
                        Else
                            MsgBox("Cedula/Contraseaña Incorrecto")
                        End If


                    Next

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
                        Me.Hide()
                        MENU3.Show()
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

    Private Sub Label1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Labels_transparentes3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_transparentes3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        mailrecuperar = InputBox("Por favor ingrese su cedula para restablecer su contraseña")

        Consulta = "select * from usuarios where cedula = '" & mailrecuperar & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            enviarEmail(row("mail"), "recuperación contraseña", "Su Contraseña es : " & row("contrasenia"))
        Next

    End Sub

End Class