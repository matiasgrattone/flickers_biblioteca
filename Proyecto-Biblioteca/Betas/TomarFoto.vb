Public Class TomarFoto

    Dim guardarFoto As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Question
    Dim proceso As Integer = 0
    Dim nombre As String = nombreFoto
    Dim cedula As String = cedulaFoto

    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer

    Private Sub TomarFoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbProce.Visible = False
        rd_Procesando.Visible = False
        timer_Guardado.Interval = 500

        xf = Me.Location.X
        yf = Me.Location.Y

        WebCam1.Start()

        'If opcionConfigUsers = 0 Then
        '    rutaFoto = "Fotos de perfil/" & nombre & "-" & cedula & ".png"
        'Else
        '    rutaFoto = "Fotos de socio/" & nombre & "-" & cedula & ".png"
        'End If


    End Sub

    Private Sub btnCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturar.Click

        WebCam1.Stop()
        ptbFoto.BringToFront()
        ptbFoto.Image = WebCam1.Imagen

        timer_Guardado.Enabled = True

    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebCam1.Start()
        ptbFoto.SendToBack()
    End Sub

    Private Sub timer_Guardado_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_Guardado.Tick

        If proceso <= 5 Then

            rd_Procesando.Start()
            rd_Procesando.Visible = True
            lbProce.Visible = True

            proceso = proceso + 1

        Else

            rd_Procesando.Stop()
            rd_Procesando.Visible = False
            lbProce.Visible = False
            timer_Guardado.Enabled = False

            If MsgBox("Desea guardar la foto?", guardarFoto, Title:="Guardar?") = MsgBoxResult.Yes Then

                Try
                    ptbFoto.Image.Save(rutaFoto)
                    Inicio_UsuariosV2.ptbFotoSocio.Image = Image.FromFile(rutaFoto)
                    Inicio_UsuariosV2.ptbFotoSocio.Refresh()
                    Inicio_UsuariosV2.ptbFotoSocio.ImageLocation = Convert.ToString(rutaFoto)
                    MsgBox("Se guardo correctamente")
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    MsgBox("No se pudo guardar")
                    ptbFoto.SendToBack()
                    WebCam1.Start()
                End Try

            Else
                proceso = 0
                WebCam1.Start()
                ptbFoto.SendToBack()

                rutaFoto = "Fotos de socio/student.jpg"
            End If

        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub Panel1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If a = 1 Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
            Me.Opacity = 0.9
            MENU3.Timer_Prestamos_LIVE.Enabled = False
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
            MENU3.Timer_Prestamos_LIVE.Enabled = True
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub TomarFoto_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Inicio_UsuariosV2.ptbFotoSocio.Refresh()
    End Sub
End Class