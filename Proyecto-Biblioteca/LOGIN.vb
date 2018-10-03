Public Class LOGIN
    Dim i As Integer = 0
    Dim mailrecuperar As String = Nothing

    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim user As String = Nothing
        Dim pass As String = Nothing
        Dim pass1 As String = Nothing

        'Dim fecha_actual As Date = DateTime.Now.ToString("dd/MM/yyyy")
        Dim fecha_entrada As Date
        Dim dia, mes, anio, diferenciaDia As Integer

        dia = Val(DateTime.Now.ToString("dd"))
        mes = Val(DateTime.Now.ToString("MM"))
        anio = Val(DateTime.Now.ToString("yyyy"))

        'MsgBox(DateTime.Now.ToString("dd"))

        If LTrim$(usuario.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(usuario, "Nombre no puede estar vacío")
            i = 1
        Else
            user = usuario.Text
        End If

        If LTrim$(contrasenia.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(contrasenia, "Contraseña no puede estar vacía")
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
                        usuario.Clear()
                        contrasenia.Clear()
                    End If


                Next

            Catch ex As Exception
                MsgBox("Cedula/Contraseaña Incorrecto")
                usuario.Clear()
                contrasenia.Clear()
            End Try
        End If
    End Sub

    Private Sub contrasenia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles contrasenia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim user As String = Nothing
            Dim pass As String = Nothing
            Dim pass1 As String = Nothing

            'Dim fecha_actual As Date = DateTime.Now.ToString("dd/MM/yyyy")
            Dim fecha_entrada As Date
            Dim dia, mes, anio, diferenciaDia As Integer

            dia = Val(DateTime.Now.ToString("dd"))
            mes = Val(DateTime.Now.ToString("MM"))
            anio = Val(DateTime.Now.ToString("yyyy"))

            'MsgBox(DateTime.Now.ToString("dd"))

            If LTrim$(usuario.Text) = "" Then ' Verifica si esta vacio nombre
                ErrorProvider1.SetError(usuario, "Nombre no puede estar vacío")
                i = 1
            Else
                user = usuario.Text
            End If

            If LTrim$(contrasenia.Text) = "" Then ' Verifica si esta vacio nombre
                ErrorProvider1.SetError(contrasenia, "Contraseña no puede estar vacía")
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
                            usuario.Clear()
                            contrasenia.Clear()
                        End If


                    Next

                Catch ex As Exception
                    MsgBox("Cedula/Contraseaña Incorrecto")
                    usuario.Clear()
                    contrasenia.Clear()
                End Try
            End If
        End If


    End Sub

    Private Sub contrasenia_TextChanged(sender As System.Object, e As System.EventArgs) Handles contrasenia.TextChanged
        'errorpass.Text = ""
        ErrorProvider1.SetError(contrasenia, "")
        i = 0
    End Sub

    Private Sub usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim user As String = Nothing
            Dim pass As String = Nothing
            Dim pass1 As String = Nothing

            'Dim fecha_actual As Date = DateTime.Now.ToString("dd/MM/yyyy")
            Dim fecha_entrada As Date
            Dim dia, mes, anio, diferenciaDia As Integer

            dia = Val(DateTime.Now.ToString("dd"))
            mes = Val(DateTime.Now.ToString("MM"))
            anio = Val(DateTime.Now.ToString("yyyy"))

            'MsgBox(DateTime.Now.ToString("dd"))

            If LTrim$(usuario.Text) = "" Then ' Verifica si esta vacio nombre
                ErrorProvider1.SetError(usuario, "Nombre no puede estar vacío")
                i = 1
            Else
                user = usuario.Text
            End If

            If LTrim$(contrasenia.Text) = "" Then ' Verifica si esta vacio nombre
                ErrorProvider1.SetError(contrasenia, "Contraseña no puede estar vacía")
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
                            usuario.Clear()
                            contrasenia.Clear()
                        End If


                    Next

                Catch ex As Exception
                    MsgBox("Cedula/Contraseaña Incorrecto")
                    usuario.Clear()
                    contrasenia.Clear()
                End Try
            End If
        End If
    End Sub

    Private Sub usuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles usuario.TextChanged
        'errorusuario.Text = ""
        ErrorProvider1.SetError(usuario, "")
        i = 0
    End Sub

    Private Sub Labels_transparentes3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labels_transparentes3.Click
        invitado = 1
        MENU3.Show()
        Me.Hide()
        MENU3.Nombre.Text = "Invitado"
    End Sub

    Private Sub Label1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes4.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes4.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Labels_transparentes3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Labels_transparentes3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Labels_transparentes4_Click(sender As System.Object, e As System.EventArgs) Handles Labels_transparentes4.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        mailrecuperar = InputBox("Por favor ingrese su cedula para restablecer su contraseña")

        Consulta = "select * from usuarios where cedula = '" & mailrecuperar & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            enviarEmail(row("mail"), "recuperación contraseña", "Su Contraseña es : " & row("contrasenia"))
        Next
    End Sub

    Private Sub PictureBox1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If a = 1 Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
            Me.Opacity = 0.9
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
   a = 1
    End Sub

    Private Sub LOGIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y

    End Sub
End Class