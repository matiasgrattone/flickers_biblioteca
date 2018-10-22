Public Class InputBoxForm
    Dim confirmacionEdicionAdmin As String
    Dim a As Integer
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer

    Private Sub PlaceHolder5_Keyup(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder5.KeyUp
        If e.KeyCode = Keys.Enter Then
            confirmacionEdicionAdmin = PlaceHolder5.Text
            Consulta = "select contrasenia from usuarios where cedula = '" & ConfigAdmin.cedulaFotoPerfil & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                If row("contrasenia") = Encriptar(confirmacionEdicionAdmin) Then
                    confirmacionEdicionAdmin = 1
                Else
                    confirmacionEdicionAdmin = 0
                End If
            Next
            If confirmacionEdicionAdmin = 1 Then
                ConfigAdmin.PlaceHolder6.Enabled = True
                ConfigAdmin.PlaceHolder2.Enabled = True
                ConfigAdmin.PlaceHolder3.Enabled = True
                ConfigAdmin.PlaceHolder4.Enabled = True
                ConfigAdmin.PlaceHolder5.Enabled = True
                ConfigAdmin.Button7.Text = "Guardar"
                Me.Close()
            Else
                MsgBox("Contraseña Incorrecta", MsgBoxStyle.OkOnly, Title:="Configuracion")
                Me.Close()
                ConfigAdmin.Button7.Text = "Editar"
            End If
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
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
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class