Public Class TomarFoto

    Dim guardarFoto As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Question
    Dim proceso As Integer = 0
    Dim nombre As String = nombreFoto
    Dim cedula As String = cedulaFoto

    Private Sub TomarFoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbProce.Visible = False
        rd_Procesando.Visible = False
        timer_Guardado.Interval = 500

        WebCam1.Start()

        rutaFoto = "Fotos de socio/" & nombre & "-" & cedula & ".png"

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
                    'Inicio_UsuariosV2.ptbFotoSocio.ImageLocation = Convert.ToString(rutaFoto)
                    MsgBox("Se guardo correctamente")
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox("No se pudo guardar")
                    ptbFoto.SendToBack()
                    WebCam1.Start()
                End Try

            Else
                proceso = 0
                WebCam1.Start()
                ptbFoto.SendToBack()

                rutaFoto = "Fotos de socio/student.png"
            End If

        End If

    End Sub
End Class