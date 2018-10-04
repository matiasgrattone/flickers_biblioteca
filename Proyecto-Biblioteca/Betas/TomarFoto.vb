Public Class TomarFoto

    Public rutaFoto As String
    Dim guardarFoto As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Question

    Private Sub TomarFoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        WebCam1.Start()

        rutaFoto = "Fotos de socio/" & Inicio_UsuariosV2.nombreFoto & "-" & Inicio_UsuariosV2.cedulaFoto

    End Sub

    Private Sub btnCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturar.Click

        WebCam1.Stop()
        ptbFoto.BringToFront()
        ptbFoto.Image = WebCam1.Imagen

        If MsgBox("Desea guardar la foto?", guardarFoto, Title:="Guardar?") = MsgBoxResult.Yes Then
            Try
                ptbFoto.Image.Save(rutaFoto)
                MsgBox("Se guardo correctamente")
                ptbFoto.SendToBack()
                WebCam1.Start()
            Catch ex As Exception
                MsgBox("No se pudo guardar")
                ptbFoto.SendToBack()
                WebCam1.Start()
            End Try
        Else
            WebCam1.Start()
            ptbFoto.SendToBack()
        End If

    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        WebCam1.Start()
        ptbFoto.SendToBack()
    End Sub
End Class