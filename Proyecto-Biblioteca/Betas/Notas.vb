Public Class Notas

    Private Sub Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Dim Ubicacion1 As String = vbNull
        Dim Ubicacion2 As String = vbNull
        Dim Ubicacion3 As String = vbNull

        Consulta = "Select * from notas where cedula ='" & MENU3.Cedula.Text & "' and recordar = 1"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Ubicacion1 = row("texto")
            Fecha1.Text = row("fecha")
        Next

        Consulta = "Select * from notas where cedula ='" & MENU3.Cedula.Text & "' and recordar = 2"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Ubicacion2 = row("texto")
            Fecha2.Text = row("fecha")
        Next

        Consulta = "Select * from notas where cedula ='" & MENU3.Cedula.Text & "' and recordar = 3"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Ubicacion3 = row("texto")
            Fecha3.Text = row("fecha")

        Next


        '///////Ah  los recordatorios se le asigna una ruta del archivo.txt gurdada con anterioridad en la base de datos///////
        Consulta = "select * from notas where cedula= '" & MENU3.Cedula.Text & "'"
        consultar()
        If (Tabla.Rows.Count = 0) Then

        Else

            If Ubicacion1 <> "" Then
                Dim Recordatorio1 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion1, System.Text.Encoding.[Default])
                TextoParaRecordar1.Text = Recordatorio1.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                Recordatorio1.Close()

                '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
            End If
            If Ubicacion2 <> "" Then
                Dim Recordatorio2 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion2, System.Text.Encoding.[Default])
                TextoParaRecordar2.Text = Recordatorio2.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                Recordatorio2.Close()

                '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
            End If
            If Ubicacion3 <> "" Then
                Dim Recordatorio3 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion3, System.Text.Encoding.[Default])
                TextoParaRecordar3.Text = Recordatorio3.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                Recordatorio3.Close()

                '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
            End If
            '/////////////////
        End If

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        '////////Borramos el contenido seleccionado del EditorDeTexto
        EditorDeTexto.Clear()

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        '////////Creamos las variables con teminalidad OpenFile Y StreamReader
        Dim AbrirArchivo As New OpenFileDialog() 'Para abrir el menu para busar el archivo
        Dim myStreamReader As System.IO.StreamReader 'Para leer el contenido del archivo 

        '////////Se abre una ventana para poder busar el archivo que quieras (Un .txt)
        AbrirArchivo.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
        AbrirArchivo.CheckFileExists = True
        AbrirArchivo.Title = "Abrir Archivo" 'Titulo de la ventana 
        AbrirArchivo.ShowDialog(Me)
        Try

            AbrirArchivo.OpenFile() 'Abrimos le archivo seleccionado con anterioridad
            myStreamReader = System.IO.File.OpenText(AbrirArchivo.FileName) 'Pasamos el contenido del archivo de texto para poder pasarlo al textbox
            EditorDeTexto.Text = myStreamReader.ReadToEnd() 'Igualamos el ontenido del archivo al EditorDeTexto

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click

        '////////Creamos las variables con teminalidad SaveFileDialogo Y StreamWiter

        Dim GuardarArchivo As New SaveFileDialog()  'Para poder guardar el contenido del archivo en un .txt
        Dim myStreamWriter As System.IO.StreamWriter  'Para poder guardar el texto en el archivoen un .txt

        '////////Se abre una ventana para poder busar el archivo que quieras (Un .txt)
        GuardarArchivo.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        GuardarArchivo.CheckPathExists = True
        GuardarArchivo.Title = "Guardar como"   'Titulo de la ventana 
        GuardarArchivo.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(GuardarArchivo.FileName) 'Guardarmos el archivo con el nombre deseado
            myStreamWriter.Write(EditorDeTexto.Text) 'Guarda el contenido del archivo 
            myStreamWriter.Flush()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        'Corta el texto seleccionado
        EditorDeTexto.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        'Copia el texto seleccionado
        EditorDeTexto.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        'Pega el texto seleccionado
        EditorDeTexto.Paste()
    End Sub

    Private Sub SeleccionarTodoElTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarTodoElTextoToolStripMenuItem.Click
        'Selecciona todo el texto
        EditorDeTexto.SelectAll()
    End Sub

    Private Sub LimpiarTodoElTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarTodoElTextoToolStripMenuItem.Click
        'Borra el texto seleccionado
        EditorDeTexto.Clear()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim ParaCambiarLaFuente As FontDialog = New FontDialog   'Creamos variable con terminacion FontDialog 
            ParaCambiarLaFuente.Font = EditorDeTexto.Font 'Igualamos la fuente de la variable al predeterminado por el textbox

            'Se nos abre una ventana para elegir la fuente 
            If ParaCambiarLaFuente.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                EditorDeTexto.Font = ParaCambiarLaFuente.Font 'Igualamos la fuente del textbox a la que seleccionamos con anterioridad en la ventana de fuentes 
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Try
            Dim ParaCambiarElColor As ColorDialog = New ColorDialog 'Creamos variable con terminacion ColorDialog 
            ParaCambiarElColor.Color = EditorDeTexto.ForeColor 'Igualamos la fuente de la variable al predeterminado por el textbox

            'Se nos abre una ventana para elegir el color 
            If ParaCambiarElColor.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                EditorDeTexto.ForeColor = ParaCambiarElColor.Color 'Igualamos el color del textbox a la que seleccionamos con anterioridad en la ventana de Colores 

            End If
        Catch ex As Exception

        End Try
    End Sub

    '/////////////////////CREAR RECORDATORIOS////////////////////////////


    Private Sub CrearRecordatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio.Click

        Dim Ubicacion As String
        Dim A As String
        '////////Creamos las variables con teminalidad OpenFile
        Dim AbrirArchivo As New OpenFileDialog() 'Para abrir el menu para busar el archivo 

        '////////// Msgbox que se comunica con el funcionario para saber si! Si o no quiere recordar alguna nota ya creada 
        If TextoParaRecordar1.Text = "" Then
            A = MsgBox("Desea recordar alguna nota ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then


                '////////Se abre una ventana para poder busar el archivo que quieras (Un .txt)
                AbrirArchivo.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
                AbrirArchivo.CheckFileExists = True
                AbrirArchivo.Title = "Seleccione el archivo que desea recordar" 'Titulo de la ventana 
                AbrirArchivo.ShowDialog(Me)


                Ubicacion = AbrirArchivo.FileName 'Igualamos la variable Ubicacion a la URL del archivo 
                TextOculto.Text = Ubicacion

                Dim a1 As String
                a1 = TextOculto.Text



                If (a1.Contains("\")) Then 'Detectamos si la variable tiene una barrita  
                    a1 = Replace(a1, "\", "\\") 'Remplazamos la barrita por 2  
                End If

                Consulta = "Insert into notas (cod_texto ,texto, cedula, recordar, fecha) VALUES ('1','" & a1 & "', '" & MENU3.Cedula.Text & "', '1','" & Date.Now.ToString("yyyy-MM-dd") & "')" 'Guardamos en la base de datos 
                consultar()
            End If

        End If
        ActualizarNotas()
    End Sub

    Private Sub CrearRecordatorio2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio2.Click
        Dim Ubicacion As String
        Dim A As String
        '////////Creamos las variables con teminalidad OpenFile
        Dim AbrirArchivo As New OpenFileDialog() 'Para abrir el menu para busar el archivo 

        '////////// Msgbox que se comunica con el funcionario para saber si! Si o no quiere recordar alguna nota ya creada 
        If TextoParaRecordar2.Text = "" Then
            A = MsgBox("Desea recordar alguna nota ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then


                '////////Se abre una ventana para poder busar el archivo que quieras (Un .txt)
                AbrirArchivo.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
                AbrirArchivo.CheckFileExists = True
                AbrirArchivo.Title = "Seleccione el archivo que desea recordar" 'Titulo de la ventana 
                AbrirArchivo.ShowDialog(Me)


                Ubicacion = AbrirArchivo.FileName 'Igualamos la variable Ubicacion a la URL del archivo 
                TextOculto.Text = Ubicacion

                Dim a1 As String
                a1 = TextOculto.Text



                If (a1.Contains("\")) Then 'Detectamos si la variable tiene una barrita  
                    a1 = Replace(a1, "\", "\\") 'Remplazamos la barrita por 2  
                End If

                Consulta = "Insert into notas (cod_texto ,texto, cedula, recordar,fecha) VALUES ('2','" & a1 & "', '" & MENU3.Cedula.Text & "', '2', '" & Date.Now.ToString("yyyy-MM-dd") & "')" 'Guardamos en la base de datos 
                consultar()

            End If
        End If
        ActualizarNotas()
    End Sub

    Private Sub CrearRecordatorio3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio3.Click
        Dim Ubicacion As String
        Dim A As String
        '////////Creamos las variables con teminalidad OpenFile
        Dim AbrirArchivo As New OpenFileDialog() 'Para abrir el menu para busar el archivo 

        '////////// Msgbox que se comunica con el funcionario para saber si! Si o no quiere recordar alguna nota ya creada 
        If TextoParaRecordar3.Text = "" Then
            A = MsgBox("Desea recordar alguna nota ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then


                '////////Se abre una ventana para poder busar el archivo que quieras (Un .txt)
                AbrirArchivo.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
                AbrirArchivo.CheckFileExists = True
                AbrirArchivo.Title = "Seleccione el archivo que desea recordar" 'Titulo de la ventana 
                AbrirArchivo.ShowDialog(Me)


                Ubicacion = AbrirArchivo.FileName 'Igualamos la variable Ubicacion a la URL del archivo 
                TextOculto.Text = Ubicacion

                Dim a1 As String
                a1 = TextOculto.Text



                If (a1.Contains("\")) Then 'Detectamos si la variable tiene una barrita  
                    a1 = Replace(a1, "\", "\\") 'Remplazamos la barrita por 2  
                End If

                Consulta = "Insert into notas (cod_texto ,texto, cedula, recordar,fecha) VALUES ('3','" & a1 & "', '" & MENU3.Cedula.Text & "', '3','" & Date.Now.ToString("yyyy-MM-dd") & "')" 'Guardamos en la base de datos 
                consultar()
            End If
        End If
        ActualizarNotas()
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub EliminarRecordatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRecordatorio.Click
        If TextoParaRecordar1.Text <> "" Then
            Dim A As String
            A = MsgBox("Desea eliminar el recordatorio ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                Consulta = "delete from notas WHERE recordar = 1 and cedula = '" & MENU3.Cedula.Text & "';"
                consultar()
                TextoParaRecordar1.Clear()
                Fecha1.Text = " "
            End If
        End If
        ActualizarNotas()
    End Sub

    Private Sub EliminarRecordatorio2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRecordatorio2.Click
        Dim A As String
        If TextoParaRecordar2.Text <> "" Then
            A = MsgBox("Desea eliminar el recordatorio ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                Consulta = "delete from notas WHERE recordar = 2 and cedula = '" & MENU3.Cedula.Text & "';"
                consultar()
                TextoParaRecordar2.Clear()
                Fecha2.Text = " "
            End If
        End If
        ActualizarNotas()
    End Sub

    Private Sub EliminarRecordatorio3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRecordatorio3.Click
        Dim A As String
        If TextoParaRecordar3.Text <> "" Then
            A = MsgBox("Desea eliminar el recordatorio ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                Consulta = "delete from notas WHERE recordar = 3 and cedula = '" & MENU3.Cedula.Text & "';"
                consultar()
                TextoParaRecordar3.Clear()
                Fecha3.Text = " "
            End If
        End If
    End Sub

    '//////////////////////////FUNCION////////////////////////////////
    Public Sub ActualizarNotas()
        Dim Ubicacion1 As String
        Dim Ubicacion2 As String
        Dim Ubicacion3 As String


        Consulta = "Select * from notas where cedula ='" & MENU3.Cedula.Text & "' and recordar = 1"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Ubicacion1 = row("texto")
            Fecha1.Text = row("fecha")
        Next

        Consulta = "Select * from notas where cedula ='" & MENU3.Cedula.Text & "' and recordar = 2"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Ubicacion2 = row("texto")
            Fecha2.Text = row("fecha")
        Next

        Consulta = "Select * from notas where cedula ='" & MENU3.Cedula.Text & "' and recordar = 3"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Ubicacion3 = row("texto")
            Fecha3.Text = row("fecha")
        Next


        '///////Ah  los recordatorios se le asigna una ruta del archivo.txt gurdada con anterioridad en la base de datos///////
        If Ubicacion1 <> "" Then
            Dim Recordatorio1 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion1, System.Text.Encoding.[Default])
            TextoParaRecordar1.Text = Recordatorio1.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
            Recordatorio1.Close()

            '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
        End If
        If Ubicacion2 <> "" Then
            Dim Recordatorio2 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion2, System.Text.Encoding.[Default])
            TextoParaRecordar2.Text = Recordatorio2.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
            Recordatorio2.Close()

            '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
        End If
        If Ubicacion3 <> "" Then
            Dim Recordatorio3 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion3, System.Text.Encoding.[Default])
            TextoParaRecordar3.Text = Recordatorio3.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
            Recordatorio3.Close()

            '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
        End If
        '/////////////////


    End Sub
    '//////////////////////////FUNCION////////////////////////////////

    Private Sub CrearRecordatorio_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio.Click

    End Sub
End Class