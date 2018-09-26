Public Class Notas

    Dim RecordatorioValor As Integer
    Dim modo As String
    Dim RutaDeGuardadoDeNotas As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\DATOS\Notas" 'Ruta en la que se guardarán las imágenes cargadas: "Documentos\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\DATOS\Notas"
    Private Sub Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Consulta = "Select NombreNota, texto from notas where cedula= '" + MENU3.Cedula.Text + "'"
        consultar()

        DataGridViewParaVerNotasDisponibles.DataSource = Tabla
        DataGridViewParaVerNotasDisponibles.Columns(1).Visible = False

        My.Computer.FileSystem.CreateDirectory(RutaDeGuardadoDeNotas) 'Crea la carpeta "Notas" en la ruta especificada si esta no existe


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
                Try
                    Dim Recordatorio1 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion1, System.Text.Encoding.[Default])
                    TextoParaRecordar1.Text = Recordatorio1.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                    Recordatorio1.Close()
                Catch ex As Exception
                    Dim ms As String
                    ms = MsgBox("La nota que se desea recordar ya no se encuntra, desea dejar de recordarlas? ", MsgBoxStyle.YesNoCancel, Title:="Notas")
                    If ms = vbYes Then
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.Cedula.Text & "' and recordar = 1"
                        consultar()
                    End If
                End Try



                '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
            End If
            If Ubicacion2 <> "" Then
                Try
                    Dim Recordatorio2 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion2, System.Text.Encoding.[Default])
                    TextoParaRecordar2.Text = Recordatorio2.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                    Recordatorio2.Close()
                Catch ex As Exception
                    Dim ms As String
                    ms = MsgBox("La nota que se desea recordar ya no se encuntra, desea dejar de recordarlas? ", MsgBoxStyle.YesNoCancel, Title:="Notas")
                    If ms = vbYes Then
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.Cedula.Text & "' and recordar = 2"
                        consultar()
                    End If
                End Try

                '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
            End If
            If Ubicacion3 <> "" Then
                Try
                    Dim Recordatorio3 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion3, System.Text.Encoding.[Default])
                    TextoParaRecordar3.Text = Recordatorio3.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                    Recordatorio3.Close()
                Catch ex As Exception
                    Dim ms As String
                    ms = MsgBox("La nota que se desea recordar ya no se encuntra, desea dejar de recordarlas? ", MsgBoxStyle.YesNoCancel, Title:="Notas")
                    If ms = vbYes Then
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.Cedula.Text & "' and recordar = 3"
                        consultar()
                    End If
                End Try

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
        PanelNotas.Top = 0
        modo = "Abrir"

    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click

        Dim NombreDelArchivo As String
        Dim Intru As Object
        Dim Archivo As Object

        NombreDelArchivo = InputBox("Ingrese el nombre de su nota", Title:="Notas")
        NombreDelArchivo = NombreDelArchivo + ".txt"
        If NombreDelArchivo = vbCancel Then
            Intru = CreateObject("Scripting.FileSystemObject")
            Archivo = Intru.CreateTextFile((Environment.SpecialFolder.MyDocuments) + ":\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\DATOS\Notas\'" + NombreDelArchivo + "'", True)
            Archivo.WriteLine(EditorDeTexto.Text)
            Archivo.Close()


        Else

        End If



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

    Dim NombreDeLaNotaParaRecordar As String
    Private Sub CrearRecordatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio.Click

        Dim A As String

        If TextoParaRecordar1.Text = "" Then
            A = MsgBox("Desea recordar alguna nota ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                modo = "recordar"
                PanelNotas.Top = 0
                RecordatorioValor = 1
            End If
        End If

    End Sub

    Private Sub CrearRecordatorio2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio2.Click

        Dim A As String

        If TextoParaRecordar2.Text = "" Then
            A = MsgBox("Desea recordar alguna nota ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                modo = "recordar"
                PanelNotas.Top = 0
                RecordatorioValor = 2
            End If
        End If

    End Sub

    Private Sub CrearRecordatorio3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearRecordatorio3.Click

        Dim A As String

        If TextoParaRecordar3.Text = "" Then
            A = MsgBox("Desea recordar alguna nota ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                modo = "recordar"
                PanelNotas.Top = 0
                RecordatorioValor = 3
            End If
        End If


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

    Private Sub DataGridViewParaVerNotasDisponibles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewParaVerNotasDisponibles.CellDoubleClick
        If modo = "recordar" Then
            Dim a As String
            Dim Ubicacion As String
            NombreDeLaNotaParaRecordar = DataGridViewParaVerNotasDisponibles.Item(0, DataGridViewParaVerNotasDisponibles.CurrentRow.Index).Value
            Ubicacion = DataGridViewParaVerNotasDisponibles.Item(1, DataGridViewParaVerNotasDisponibles.CurrentRow.Index).Value
            a = MsgBox("Desea recordar la nota " + NombreDeLaNotaParaRecordar + "?", MsgBoxStyle.YesNoCancel, Title:="Recordatorios")
            If a = vbYes Then

                If (Ubicacion.Contains("\")) Then 'Detectamos si la variable tiene una barrita  
                    Ubicacion = Replace(Ubicacion, "\", "\\") 'Remplazamos la barrita por 2  
                End If

                Consulta = "UPDATE notas SET recordar = '" + RecordatorioValor + "' WHERE cedula = '" & MENU3.Cedula.Text & "' and texto ='" + Ubicacion + "';"
                consultar()
            End If
            ActualizarNotas()
        End If

        If modo = "Abrir" Then
            Try
                Dim Ubicacion As String
                Ubicacion = DataGridViewParaVerNotasDisponibles.Item(1, DataGridViewParaVerNotasDisponibles.CurrentRow.Index).Value

                Dim Recordatorio2 As System.IO.StreamReader = New System.IO.StreamReader(Ubicacion, System.Text.Encoding.[Default])
                EditorDeTexto.Text = Recordatorio2.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                Recordatorio2.Close()

            Catch ex As Exception

            End Try
        End If
    End Sub


End Class