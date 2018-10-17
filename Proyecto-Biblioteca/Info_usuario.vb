Public Class info_usuario
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer
    Dim nombreArchivo As String

    Private Sub info_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        xf = Me.Location.X
        yf = Me.Location.Y



        cargar()

    End Sub

    Private Sub Panel1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
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

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Imágenes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar imágenes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicación en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de diálogo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            'lblNombre.Text = rutaArchivo
            ptbperfil.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posición en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            nombreArchivo = "Fotos de perfil/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            Try
                Consulta = "update usuarios set rutaperfil = '" & nombreArchivo & "' where cedula='" + MENU3.cedulaIngre + "'"
                consultar()
                MsgBox("Cambio de perfil exitoso")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                ptbperfil.ImageLocation = nombreArchivo
                'cargar()
            Else
                'My.Computer.FileSystem.CopyFile(rutaArchivo, rutaGuardadoFotos + "\" + nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                My.Computer.FileSystem.CopyFile(rutaArchivo, nombreArchivo)
                cargar()
            End If
            'My.Computer.FileSystem.CopyFile(rutaArchivo, rutaGuardadoFotos + "\" + nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
            'cargar()
        End If
    End Sub

    Private Sub cargar()
        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" + MENU3.cedulaIngre + "'"
            consultar()

            For Each row As DataRow In Tabla.Tables(0).Rows
                ptbperfil.ImageLocation = Convert.ToString(row("rutaperfil"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Try
        '    Consulta = "update usuarios set rutaperfil = '" & nombreArchivo & "' where cedula='" + MENU3.cedulaIngre + "'"
        '    consultar()
        '    MsgBox("Cambio de perfil exitoso")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
End Class