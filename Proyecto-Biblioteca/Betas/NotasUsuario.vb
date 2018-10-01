Public Class NotasUsuario

    Dim RecordatorioValor As String
    Dim modo As String
    Dim cedula As String
    Private Sub Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DatagridModulo = DataGridViewParaVerNotasDisponibles
        Datagrid_Align()

        cedula = MENU3.lbl_cedula.Text
        Consulta = "Select NombreNota, texto from notas where cedula= '" + MENU3.lbl_cedula.Text + "'"
        consultar()

        DataGridViewParaVerNotasDisponibles.DataSource = Tabla
        DataGridViewParaVerNotasDisponibles.Columns(1).Visible = False

        Dim RutaDeGuardadoDeNotas As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\DATOS\Notas" 'Ruta en la que se guardarán las imágenes cargadas: "Documentos\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\DATOS\Notas"
        My.Computer.FileSystem.CreateDirectory(RutaDeGuardadoDeNotas) 'Crea la carpeta "Notas" en la ruta especificada si esta no existe


        Dim Ubicacion1 As String = ""
        Dim Ubicacion2 As String = ""
        Dim Ubicacion3 As String = ""

        Consulta = "Select * from notas where cedula ='" & MENU3.lbl_cedula.Text & "' and recordar = 1"
        consultar()
        If (Tabla.Rows.Count <> 0) Then
            For Each row As DataRow In Tabla.Rows
                Ubicacion1 = row("texto")
                Ubicacion1 = RutaDeDocumentos + Ubicacion1.ToString
                Fecha1.Text = row("fecha")
            Next
        End If

        Consulta = "Select * from notas where cedula ='" & MENU3.lbl_cedula.Text & "' and recordar = 2"
        consultar()
        If (Tabla.Rows.Count <> 0) Then
            For Each row As DataRow In Tabla.Rows
                Ubicacion2 = row("texto")
                Ubicacion2 = RutaDeDocumentos + Ubicacion2.ToString
                Fecha2.Text = row("fecha")
            Next
        End If


        Consulta = "Select * from notas where cedula ='" & MENU3.lbl_cedula.Text & "' and recordar = 3"
        consultar()
        If (Tabla.Rows.Count <> 0) Then
            For Each row As DataRow In Tabla.Rows
                Ubicacion3 = row("texto")
                Ubicacion3 = RutaDeDocumentos + Ubicacion3.ToString
                Fecha3.Text = row("fecha")
            Next
        End If

        '///////Ah  los recordatorios se le asigna una ruta del archivo.txt gurdada con anterioridad en la base de datos///////
        Consulta = "select recordar from notas where cedula = '" & MENU3.lbl_cedula.Text & "' and recordar is NOT NULL"
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
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.lbl_cedula.Text & "' and recordar = 1"
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
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.lbl_cedula.Text & "' and recordar = 2"
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
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.lbl_cedula.Text & "' and recordar = 3"
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
        ActualizarNotas()
    End Sub
    Dim RutaDeDocumentos As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim NombreDelArchivo As String
        Dim Intru As Object
        Dim Archivo As Object
        Dim UbicacionParaLaBaseDeDatos As String = "\\GitHub\\flickers_biblioteca\\Proyecto-Biblioteca\\bin\\Debug\\DATOS\\Notas\\"

        NombreDelArchivo = InputBox("Ingrese el nombre de su nota", Title:="Notas")
        If NombreDelArchivo = "" Then

        Else

            NombreDelArchivo = NombreDelArchivo + ".txt"
            UbicacionParaLaBaseDeDatos = UbicacionParaLaBaseDeDatos + NombreDelArchivo.ToString
            RutaDeDocumentos = RutaDeDocumentos + "\GitHub\flickers_biblioteca\Proyecto-Biblioteca\bin\Debug\DATOS\Notas\" + NombreDelArchivo.ToString
            RutaDeDocumentos = RutaDeDocumentos

            Intru = CreateObject("Scripting.FileSystemObject")


            Archivo = Intru.CreateTextFile(RutaDeDocumentos, True)
            Archivo.WriteLine(EditorDeTexto.Text)
            Archivo.Close()

            Consulta = "INSERT INTO notas (NombreNota, texto, cedula, fecha) VALUES ( '" + NombreDelArchivo + "', '" + UbicacionParaLaBaseDeDatos.ToString + "', '" + MENU3.lbl_cedula.Text + "','" + Date.Now.ToString("yyyy-MM-dd") + "')"
            consultar()
            ActualizarNotas()
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
                RecordatorioValor = "1"
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
                RecordatorioValor = "2"
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
                RecordatorioValor = "3"
            End If
        End If


    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub EliminarRecordatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRecordatorio.Click
        If TextoParaRecordar1.Text <> "" Then
            Dim A As String
            A = MsgBox("Desea eliminar el recordatorio ?", MsgBoxStyle.YesNoCancel, Title:="NOTAS")
            If A = vbYes Then
                Consulta = "delete from notas WHERE recordar = 1 and cedula = '" & MENU3.lbl_cedula.Text & "';"
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
                Consulta = "delete from notas WHERE recordar = 2 and cedula = '" & MENU3.lbl_cedula.Text & "';"
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
                Consulta = "delete from notas WHERE recordar = 3 and cedula = '" & MENU3.lbl_cedula.Text & "';"
                consultar()
                TextoParaRecordar3.Clear()
                Fecha3.Text = " "
            End If
        End If
    End Sub

    '//////////////////////////FUNCION////////////////////////////////
    Public Sub ActualizarNotas()
        DatagridModulo = DataGridViewParaVerNotasDisponibles
        Datagrid_Align()

        Consulta = "Select NombreNota, texto from notas where cedula= '" + MENU3.lbl_cedula.Text + "'"
        consultar()

        DataGridViewParaVerNotasDisponibles.DataSource = Tabla
        DataGridViewParaVerNotasDisponibles.Columns(1).Visible = False

        Dim Ubicacion1 As String = ""
        Dim Ubicacion2 As String = ""
        Dim Ubicacion3 As String = ""

        Consulta = "Select * from notas where cedula ='" & MENU3.lbl_cedula.Text & "' and recordar = 1"
        consultar()
        If (Tabla.Rows.Count <> 0) Then
            For Each row As DataRow In Tabla.Rows
                Ubicacion1 = row("texto")
                Ubicacion1 = RutaDeDocumentos + Ubicacion1.ToString
                Fecha1.Text = row("fecha")
            Next
        End If

        Consulta = "Select * from notas where cedula ='" & MENU3.lbl_cedula.Text & "' and recordar = 2"
        consultar()
        If (Tabla.Rows.Count <> 0) Then
            For Each row As DataRow In Tabla.Rows
                Ubicacion2 = row("texto")
                Ubicacion2 = RutaDeDocumentos + Ubicacion2.ToString
                Fecha2.Text = row("fecha")
            Next
        End If


        Consulta = "Select * from notas where cedula ='" & MENU3.lbl_cedula.Text & "' and recordar = 3"
        consultar()
        If (Tabla.Rows.Count <> 0) Then
            For Each row As DataRow In Tabla.Rows
                Ubicacion3 = row("texto")
                Ubicacion3 = RutaDeDocumentos + Ubicacion3.ToString
                Fecha3.Text = row("fecha")
            Next
        End If

        '///////Ah  los recordatorios se le asigna una ruta del archivo.txt gurdada con anterioridad en la base de datos///////
        Consulta = "select recordar from notas where cedula = '" & MENU3.lbl_cedula.Text & "' and recordar is NOT NULL"
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
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.lbl_cedula.Text & "' and recordar = 1"
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
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.lbl_cedula.Text & "' and recordar = 2"
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
                        Consulta = "DELETE FROM notas WHERE cedula = '" & MENU3.lbl_cedula.Text & "' and recordar = 3"
                        consultar()
                    End If
                End Try

                '////////Igualamos El textbox1 a el contenido de la variabe "Texto"
            End If
            '/////////////////
        End If

    End Sub
    '//////////////////////////FUNCION////////////////////////////////

    Private Sub DataGridViewParaVerNotasDisponibles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewParaVerNotasDisponibles.CellDoubleClick
        Dim TEXTOUbicacion As String
        Dim a As String

        NombreDeLaNotaParaRecordar = DataGridViewParaVerNotasDisponibles.Item(0, DataGridViewParaVerNotasDisponibles.CurrentRow.Index).Value
        TEXTOUbicacion = DataGridViewParaVerNotasDisponibles.Item(1, DataGridViewParaVerNotasDisponibles.CurrentRow.Index).Value


        If modo = "recordar" Then



            a = MsgBox("Desea recordar la nota " + NombreDeLaNotaParaRecordar + "?", MsgBoxStyle.YesNoCancel, Title:="Recordatorios")
            If a = vbYes Then

                TEXTOUbicacion = DataGridViewParaVerNotasDisponibles.Item(1, DataGridViewParaVerNotasDisponibles.CurrentRow.Index).Value
                If (TEXTOUbicacion.Contains("\")) Then 'Detectamos si la variable tiene una barrita  
                    TEXTOUbicacion = Replace(TEXTOUbicacion, "\", "\\") 'Remplazamos la barrita por 2  
                End If
                Consulta = "UPDATE notas SET recordar ='" + RecordatorioValor.ToString + "' WHERE cedula = '" + cedula.ToString + "' and texto ='" + TEXTOUbicacion.ToString + "';"
                consultar()
                ActualizarNotas()

                PanelNotas.Top = -305
            End If
            ActualizarNotas()
        End If

        If modo = "Abrir" Then

            a = MsgBox("Desea abrir el archivo " + NombreDeLaNotaParaRecordar + "?", MsgBoxStyle.YesNoCancel, Title:="Recordatorios")
            If a = vbYes Then
                RutaDeDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                TEXTOUbicacion = RutaDeDocumentos + TEXTOUbicacion
                Dim Recordar As System.IO.StreamReader = New System.IO.StreamReader(TEXTOUbicacion, System.Text.Encoding.[Default])
                EditorDeTexto.Text = Recordar.ReadToEnd() 'Igualamos la variable "Texto" ah a el contenido del archivo con el comando ReadToEnd del archivo que ya buscamos con anterioridad con la variable "Ubicacion" 
                Recordar.Close()


                PanelNotas.Top = -305

            End If
        End If
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PanelNotas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelNotas.Paint

    End Sub

    Private Sub ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX.Click
        PanelNotas.Top = 0
        modo = "NULL"
    End Sub
End Class
