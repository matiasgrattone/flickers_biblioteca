Public Class ConfigAdmin
    Dim a As Integer
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer

    Dim ced_ingresar As Integer
    Dim nom_ingresar As String
    Dim ape_ingresar As String
    Dim tel_ingresar As Integer
    Dim dir_ingresar As String
    Dim tipo_ingresar As Integer
    Dim pass_ingresar As String
    Dim cont_ingresar As String

    Dim nom_editar, ape_editar, ced_editar, dir_editar, tel_editar, dia_editar, mes_editar, anio_editar, cedu_editar, dia, mes, anio As String

    Public cedulaFotoPerfil As String

    Dim i_ingresar As Integer = 0 ' Variable bandera para avisar que existe un error en ingresar
    Dim i_editar As Integer = 0 ' Variable bandera para avisar que existe un error en editar

    Dim dia_ingresar As String
    Dim mes_ingresar As String
    Dim año_ingresar As String

    Dim confirmacion As String
    Dim cedulaAdmin As String
    Dim cedulaUser As String

    '///////////// Variable para verificar cedula y nombre para sacar foto ///////////
    Public error12 As Integer = 0

    '//////////// Variable para ver si cargo o saco la foto del socio ////////////
    Public opcion As Integer ' 0 - Tomo la foto / 1 - Cargo la foto
    Dim opcionEoI As Integer ' 0 - Desde ingresar / 1 - Desde editar
    Dim cargarFoto As Integer = 0 ' Variable para el timer

    Dim graficaseleccionada As Integer 'que grafica selecciono el usuario para guardarla

    Private Sub listboxcarga()
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("Funcionarios")
        TreeView1.Nodes.Add("Administradores")
        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo < '2'"
        consultar()
        For Each row As DataRow In Tabla.Rows

            Select Case row("tipo").ToString

                Case 1

                    TreeView1.Nodes(0).Nodes.Add(row("nombre") & " " & row("apellido"))

                Case 0

                    TreeView1.Nodes(1).Nodes.Add(row("nombre") & " " & row("apellido"))

            End Select

        Next

        TreeView1.ExpandAll()
    End Sub
    Private Sub ConfiguraciònAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Administrador 0
        'Funcionarios 1
        'Socios 2
        MENU3.Timer_Prestamos_LIVE.Enabled = False
        chartVistaPrevia()
        a = 0
        PictureBox1.Visible = True
        xf = Me.Location.X
        yf = Me.Location.Y

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo = '1'"
        consultar()
        DataGridView1.DataSource = Tabla
        DatagridModulo = DataGridView1
        Datagrid_Align()
        DataGridView1.Columns.Item("Tipo").Visible = False

        listboxcarga()
        cargar()


        Consulta = "select cod_grafica from MenuConfig where cod_usuario = '" & cedulaFotoPerfil & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            Select Case row("cod_grafica")
                Case 1
                    RadioButton1.Checked = True
                Case 2
                    RadioButton2.Checked = True
                Case 3
                    RadioButton3.Checked = True
                Case 4
                    RadioButton4.Checked = True
            End Select
        Next

        '/////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////// Rellernar ComboBoxs Ingresar Usuarios //////////////////////////////
        '/////////////////////////////////////////////////////////////////////////////////////////////

        For i As Integer = 0 To 31
            If i = 0 Then
                cb_dia.Items.Add("Dia")
                cb_dia.SelectedIndex = 0
            Else
                cb_dia.Items.Add(i)
            End If
        Next

        cb_mes.Items.Add("Mes")
        cb_mes.SelectedIndex = 0
        cb_mes.Items.Add("Enero")
        cb_mes.Items.Add("Febrero")
        cb_mes.Items.Add("Marzo")
        cb_mes.Items.Add("Abril")
        cb_mes.Items.Add("Mayo")
        cb_mes.Items.Add("Junio")
        cb_mes.Items.Add("Julio")
        cb_mes.Items.Add("Agosto")
        cb_mes.Items.Add("Septiembre")
        cb_mes.Items.Add("Octubre")
        cb_mes.Items.Add("Noviembre")
        cb_mes.Items.Add("Diciembre")

        For i As Integer = 1899 To Date.Now.ToString("yyyy")
            If i = 1899 Then
                cb_anio.Items.Add("Año")
                cb_anio.SelectedIndex = 0
            Else
                cb_anio.Items.Add(i)
            End If
        Next

        '/////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////// Rellernar ComboBoxs Editar Usuarios ////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////////////////////////

        For i As Integer = 0 To 31
            If i = 0 Then
                cb_dia_editar.Items.Add("Dia")
                cb_dia_editar.SelectedIndex = 0
            Else
                cb_dia_editar.Items.Add(i)
            End If
        Next

        cb_mes_editar.Items.Add("Mes")
        cb_mes_editar.SelectedIndex = 0
        cb_mes_editar.Items.Add("Enero")
        cb_mes_editar.Items.Add("Febrero")
        cb_mes_editar.Items.Add("Marzo")
        cb_mes_editar.Items.Add("Abril")
        cb_mes_editar.Items.Add("Mayo")
        cb_mes_editar.Items.Add("Junio")
        cb_mes_editar.Items.Add("Julio")
        cb_mes_editar.Items.Add("Agosto")
        cb_mes_editar.Items.Add("Septiembre")
        cb_mes_editar.Items.Add("Octubre")
        cb_mes_editar.Items.Add("Noviembre")
        cb_mes_editar.Items.Add("Diciembre")

        For i As Integer = 1899 To Date.Now.ToString("yyyy")
            If i = 1899 Then
                cb_anio_editar.Items.Add("Año")
                cb_anio_editar.SelectedIndex = 0
            Else
                cb_anio_editar.Items.Add(i)
            End If
        Next

        'Llenar DataGrid de Editar
        Consulta = "select cedula As 'Cedula', nombre As 'Nombre' from usuarios where tipo = 1"
        consultar()
        dgveditar.DataSource = Tabla
        DatagridModulo = dgveditar
        Datagrid_Align()

        btn_guardar_editar.Visible = False
        btn_editar_perfil.Visible = False

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo = '1'"
        consultar()
        Dgv_Baja.DataSource = Tabla
        DatagridModulo = Dgv_Baja
        Datagrid_Align()
        Dgv_Baja.Columns.Item("Tipo").Visible = False

        TimerFoto.Enabled = False

    End Sub


    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i_ingresar = 0

        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre_txt, "Nombre no puede estar vacío")
            i_ingresar = 1
        Else
            nom_ingresar = nombre_txt.Text
        End If



        If LTrim$(apellido_txt.Text) = "" Then ' Verifica si esta vacio apellido
            ErrorProvider1.SetError(apellido_txt, "Apellido no puede estar vacío")
            i_ingresar = 1
        Else
            ape_ingresar = apellido_txt.Text
        End If

        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            ErrorProvider1.SetError(cedula_txt, "Cedula no puede estar vacío")
            i_ingresar = 1
        End If


        If i_ingresar = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then
                Modulo.Verificar_Cedula(cedula_txt.Text)
                If Modulo.correcto = 0 Then
                    ced_ingresar = cedula_txt.Text
                Else
                    i_ingresar = 1
                    ErrorProvider1.SetError(cedula_txt, "Cedula no valida")
                End If
            Else
                i_ingresar = 1
                ErrorProvider1.SetError(cedula_txt, "No valido, ingrese solo numeros")
            End If
        End If

        If IsNumeric(telefono_txt.Text) = True Then
            tel_ingresar = telefono_txt.Text
        Else
            i_ingresar = 1
            ErrorProvider1.SetError(telefono_txt, "No valido, ingrese solo numeros")
        End If

        dir_ingresar = direccion_txt.Text

        If LTrim$(contrasenia_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(contrasenia_txt, "Debe de tener una contraseña")
            i_ingresar = 1
        Else

            cont_ingresar = Encriptar(contrasenia_txt.Text)

        End If

        If cb_dia.Text = "Dia" Then
            ErrorProvider1.SetError(cb_dia, "selecione el dia de nacimiento")
            i_ingresar = 1
        End If

        If cb_mes.Text = "Mes" Then
            ErrorProvider1.SetError(cb_mes, "seleccione el mes de nacimiento")
            i_ingresar = 1
        End If


        If cb_anio.Text = "Año" Then
            ErrorProvider1.SetError(cb_anio, "seleccione el año de nacimiento")
            i_ingresar = 1
        End If


        If i_ingresar = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try

                If cb_dia.SelectedItem.ToString.Length = 1 Then
                    dia_ingresar = "0" + cb_dia.SelectedItem.ToString
                Else
                    dia_ingresar = cb_dia.Text
                End If

                substring = cb_mes.SelectedItem
                mestonum()

                Dim nacimiento_ingresar As String = Str(cb_anio.SelectedItem).Substring(1, 4) + "-" + substring + "-" + dia_ingresar '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT

                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo, nacimiento, estado, contrasenia, moroso, rutaperfil) values (concat(upper(left('" + nom_ingresar + "',1)), lower(substr('" + nom_ingresar + "',2))), concat(upper(left('" + ape_ingresar + "',1)), lower(substr('" + ape_ingresar + "',2))), '" + Str(ced_ingresar) + "', '" + Str(tel_ingresar) + "', '" + dir_ingresar + "', '1', '" + nacimiento_ingresar + "','1', '" + cont_ingresar + "', 0, '" + rutaFoto + "');"
                consultar()
                Consulta = "insert into MenuConfig (cod_usuario,cod_grafica) values ('" & ced_ingresar & "' , 1)"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo='0'"
                consultar()
                DataGridView1.DataSource = Tabla

                If ERROR1 = 1 Then


                    MsgBox("Error al agregar usuario", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Title:="Biblioteca")
                    ERROR1 = 0

                Else


                    MsgBox("Usuario agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Title:="Biblioteca")
                    ERROR1 = 0

                End If

                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

                cb_dia.SelectedIndex = 0
                cb_mes.SelectedIndex = 0
                cb_anio.SelectedIndex = 0

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Existen errores en el formulario, revisar los campos remarcados")
        End If
    End Sub

    Private Sub buscar_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscar_txt.TextChanged

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where nombre like '" & buscar_txt.Text & "%' and estado='1' and tipo = '1'"
        consultar()
        DataGridView1.DataSource = Tabla

    End Sub

    Private Sub dgv_buscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If MsgBox("Desea borrar este usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Title:="Desea borrar?") = MsgBoxResult.Yes Then

            cedulaUser = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            cedulaAdmin = InputBox("Ingrese una cedula de un administrador", Title:="Cedula Administrador")
            Consulta = "select cedula from usuarios where tipo = 0 and cedula = '" & cedulaAdmin & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                confirmacion = row("cedula").ToString
            Next
            If confirmacion = cedulaAdmin Then

                Consulta = "update usuarios set estado = 0 where cedula = '" & cedulaUser & "'"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo ='1'"
                consultar()
                DataGridView1.DataSource = Tabla
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo = '1'"
                consultar()
                Dgv_Baja.DataSource = Tabla
                listboxcarga()
            Else
                MsgBox("La cedula ingresada no coincide con ningun administrador", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, Title:="Error")
            End If
        Else
            MsgBox("No se dio de baja")
        End If
    End Sub


    Private Sub Dgv_Baja_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Baja.CellDoubleClick
        If MsgBox("Desea activar a este usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Title:="Desea activarlo?") = MsgBoxResult.Yes Then

            cedulaUser = Dgv_Baja.Item(2, Dgv_Baja.CurrentRow.Index).Value
            cedulaAdmin = InputBox("Ingrese una cedula de un administrador", Title:="Cedula Administrador")
            Consulta = "select cedula from usuarios where tipo = 0 and cedula = '" & cedulaAdmin & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                confirmacion = row("cedula").ToString
            Next
            If confirmacion = cedulaAdmin Then

                Consulta = "update usuarios set estado = 1 where cedula = '" & cedulaUser & "'"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo ='1'"
                consultar()
                Dgv_Baja.DataSource = Tabla
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo='1'"
                consultar()
                DataGridView1.DataSource = Tabla
                listboxcarga()
            Else
                MsgBox("La cedula ingresada no coincide con ningun administrador", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, Title:="Error")
            End If
        Else
            MsgBox("No se Activo")
        End If
    End Sub

    Private Sub PlaceHolder8_TextChanged(sender As System.Object, e As System.EventArgs) Handles Buscar_Baja_txt.TextChanged

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where nombre like '" & Buscar_Baja_txt.Text & "%' and estado='0' and tipo = '1'"
        consultar()
        Dgv_Baja.DataSource = Tabla

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
            MENU3.Timer_Prestamos_LIVE.Enabled = False
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
            MENU3.Timer_Prestamos_LIVE.Enabled = True
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        MENU3.Timer_Prestamos_LIVE.Enabled = True
        Me.Close()
    End Sub
    Private Sub ptbPerfilAdmin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptbPerfilAdmin.DoubleClick
        Dim nombreArchivo As String

        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Imágenes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar imágenes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicación en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de diálogo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            ptbPerfilAdmin.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posición en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            nombreArchivo = "Fotos de perfil/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            Try
                Consulta = "update usuarios set rutaperfil = '" & nombreArchivo & "' where cedula='" + cedulaFotoPerfil + "'"
                consultar()
                MsgBox("Cambio de perfil exitoso")
                If MENU3.lbl_cedula.Text = cedulaFotoPerfil Then
                    MENU3.Pbusuario.ImageLocation = nombreArchivo
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                ptbPerfilAdmin.ImageLocation = nombreArchivo
                'cargar()
            Else
                My.Computer.FileSystem.CopyFile(rutaArchivo, nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                cargar()
            End If
        End If
    End Sub

    Private Sub cargar()
        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" + cedulaAdmin + "'"
            consultar()

            For Each row As DataRow In Tabla.Rows
                ptbPerfilAdmin.ImageLocation = Convert.ToString(row("rutaperfil"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargar2() ' Para editar
        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" + cedu_editar + "'"
            consultar()

            For Each row As DataRow In Tabla.Rows
                ptb_perfil_editar.ImageLocation = Convert.ToString(row("rutaperfil"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar_editar.Click
        '///////////////////////////////////////////////////////////////////
        '//////////////////// EDITAR USUARIOS //////////////////////////////
        '///////////////////////////////////////////////////////////////////

        i_editar = 0

        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre, "Nombre no puede estar vacío") 'Label invisible debajo de nombre
            i_editar = 1
        Else
            nom_editar = nombre.Text
        End If

        ape_editar = apellido.Text

        ' Verifica si esta vacio cedula
        If LTrim$(cedula.Text) <> "" Then
            If IsNumeric(cedula.Text) = True Then
                Modulo.Verificar_Cedula(cedula.Text)
                If Modulo.correcto = 0 Then
                    ced_editar = cedula.Text
                Else
                    i_editar = 1
                    ErrorProvider1.SetError(cedula, "Cedula no valida")
                End If
            Else
                i_editar = 1
                ErrorProvider1.SetError(cedula, "No valido, ingrese solo numeros")
            End If
        End If


        If IsNumeric(telefono.Text) = True Then
            tel_editar = telefono.Text
        Else
            i_editar = 1
            ErrorProvider1.SetError(telefono, "No valido, ingrese solo numeros")
        End If

        dir_editar = direccion.Text


        If cb_dia_editar.Text = "Dia" Then
            ErrorProvider1.SetError(cb_dia_editar, "seleccione un dia")
            i_editar = 1
        Else
            dia_editar = ""
            If cb_dia_editar.SelectedItem.ToString.Length = 1 Then
                dia_editar = "0" & cb_dia_editar.SelectedItem
            Else
                dia_editar = cb_dia_editar.SelectedItem
            End If
        End If
        If cb_mes_editar.Text = "Mes" Then
            ErrorProvider1.SetError(cb_mes_editar, "seleccione un mes")
            i_editar = 1
        Else
            mes_editar = cb_mes_editar.SelectedIndex
        End If
        If cb_anio_editar.Text = "Año" Then
            ErrorProvider1.SetError(cb_anio_editar, "seleccione un año")
            i_editar = 1
        Else
            anio_editar = cb_anio_editar.SelectedIndex
        End If

        substring = cb_mes_editar.SelectedItem
        mestonum()

        If i_editar = 0 Then
            Dim nacimiento_editar As String = anio_editar + "-" + mes_editar + "-" + dia_editar
            Try
                Consulta = "update usuarios set cedula='" & Str(ced_editar) & "' , nombre='" & nom_editar & "', apellido='" & ape_editar & "', direccion='" & dir_editar & "', telefono='" & tel_editar & "', nacimiento='" & nacimiento_editar & "' , tipo='2' where cedula = '" & Str(ced_editar) & "'"
                consultar()

                MsgBox("Edición guardada satisfactoriamente")

                '//////////////////Mostrar los datos actualizados en el datagrid///////////////////////
                Try
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 2;"
                    consultar()
                    DataGridView1.DataSource = Tabla

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If

        '//////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub btn_editar_perfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar_perfil.Click
        Dim nombreArchivo As String

        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Imágenes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar imágenes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicación en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de diálogo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            ptbPerfilAdmin.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posición en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            nombreArchivo = "Fotos de perfil/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            Try
                Consulta = "update usuarios set rutaperfil = '" & nombreArchivo & "' where cedula='" + cedu_editar + "'"
                consultar()
                MsgBox("Cambio de perfil exitoso")
                cargar2()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                ptbPerfilAdmin.ImageLocation = nombreArchivo
                'cargar()
            Else
                My.Computer.FileSystem.CopyFile(rutaArchivo, nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                cargar()
            End If
        End If
    End Sub

    Private Sub dgveditar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgveditar.CellDoubleClick
        cedu_editar = dgveditar.Item(0, dgveditar.CurrentRow.Index).Value

        Consulta = "select * from usuarios where cedula = '" + cedu_editar + "'"
        consultar()
        For Each row As DataRow In Tabla.Rows

            dia = row("nacimiento").ToString.Substring(0, 2)
            mes = row("nacimiento").ToString.Substring(3, 2)
            anio = row("nacimiento").ToString.Substring(6, 4)

            nombre.Text = row("nombre").ToString
            apellido.Text = row("apellido").ToString
            cedula.Text = row("cedula").ToString
            direccion.Text = row("direccion").ToString
            telefono.Text = row("telefono").ToString
            cb_dia_editar.SelectedIndex = (Val(dia) + 1)
            cb_mes_editar.SelectedIndex = (Val(mes) + 1)
            Dim x As Integer = 0
            For Each item In cb_anio_editar.Items
                If item = anio Then
                    cb_anio_editar.SelectedIndex = x
                End If
                x = x + 1
            Next
            cargar2()

            btn_guardar_editar.Visible = True
            btn_editar_perfil.Visible = True
        Next

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Consulta = "update MenuConfig  set cod_grafica ='" & graficaseleccionada & "' where cod_usuario = '" & cedulaFotoPerfil & "' "
        consultar()
        If cedulaFotoPerfil = MENU3.lbl_cedula.Text Then
            MENU3.Chart()
        End If
    End Sub

    Private Sub ptbPerfilAdmin_Click(sender As System.Object, e As System.EventArgs) Handles ptbPerfilAdmin.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        graficaseleccionada = 1
        chartVistaPrevia()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        graficaseleccionada = 2
        chartVistaPrevia()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        graficaseleccionada = 3
        chartVistaPrevia()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        graficaseleccionada = 4
        chartVistaPrevia()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        TreeView1.Visible = False
        DGV_ONLINE.Visible = True
        Consulta = "select nombre , online , substring(ultimaconexion,11) as 'ultima conexion' from usuarios where tipo < 2"
        consultar()
        DGV_ONLINE.DataSource = Tabla
        DatagridModulo = DGV_ONLINE
        Datagrid_Align()



        For x As Integer = 0 To DGV_ONLINE.Rows.Count - 1


            If DGV_ONLINE.Rows(x).Cells(2).Value = "1" Then
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/online1.png")
                DGV_ONLINE.Rows(x).Cells(3).Value = " "
            Else
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/offline.png")
            End If

        Next

        DGV_ONLINE.Columns(2).Visible = False
        DGV_ONLINE.Rows(0).Cells(0).Selected = True
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        TreeView1.Visible = True
        DGV_ONLINE.Visible = False
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If LTrim$(nombre_txt.Text) = "" Then
            error12 = 1
        End If
        If LTrim$(cedula_txt.Text) = "" Then
            error12 = 1
        End If

        If error12 = 0 Then

            opcionConfigUsers = 0

            nombreFoto = nombre_txt.Text
            cedulaFoto = cedula_txt.Text

            opcion = 0

            TomarFoto.Show()

            opcionEoI = 0

            TimerFoto.Enabled = True

        Else
            MsgBox("Los campos de nombre y cedula deben de estar completos para realizar esto")
        End If

    End Sub

    Private Sub TimerFoto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFoto.Tick

        If cargarFoto < 5 Then
            For Each f In Application.OpenForms

                If f.name = "TomarFoto" Then

                    cargarFoto = 0

                Else

                    cargarFoto = 5

                End If

            Next

        Else

            Select Case opcionEoI
                Case 0
                    ptbFuncio.ImageLocation = rutaFoto
                    ptbFuncio.Refresh()
                    TimerFoto.Enabled = False
                Case 1
                    ptb_perfil_editar.ImageLocation = rutaFoto
                    ptb_perfil_editar.Refresh()
                    TimerFoto.Enabled = False
            End Select


        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Imágenes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar imágenes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicación en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de diálogo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            ptbPerfilAdmin.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posición en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            rutaFoto = "Fotos de perfil/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            If My.Computer.FileSystem.FileExists(rutaFoto) Then
                ptbFuncio.ImageLocation = rutaFoto
                ptbFuncio.Refresh()
            Else
                My.Computer.FileSystem.CopyFile(rutaArchivo, rutaFoto) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                ptbFuncio.ImageLocation = rutaFoto
                ptbFuncio.Refresh()
            End If
        End If
    End Sub
    Dim contraseniarestablecer As String = ""
    Dim correctocontraseña As Integer = 0
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        contraseniarestablecer = InputBox("ingrese su contraseña anterior")
        Consulta = "select contrasenia from usuarios where cedula = '" & cedulaFotoPerfil & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            If row("contrasenia").ToString = Encriptar(contraseniarestablecer) Then
                correctocontraseña = 1
            Else
                correctocontraseña = 0
            End If
        Next

        If correctocontraseña = 1 Then
            contraseniarestablecer = InputBox("ingrese su nueva contraseña")
            Consulta = "update usuarios set contrasenia = '" & Encriptar(contraseniarestablecer) & "' where cedula = '" & cedulaFotoPerfil & "'"
            consultar()
            MsgBox("se ha cambiado sastifactoriamente su contraseña", MsgBoxStyle.OkOnly, Title:="Biblioteca")
        Else
            MsgBox("la contraseña introducida es incorrecta")
        End If
    End Sub

    Private Sub DGV_ONLINE_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_ONLINE.CellClick
        TreeView1.Visible = False
        DGV_ONLINE.Visible = True
        Consulta = "select nombre , online , substring(ultimaconexion,11) as 'ultima conexion' from usuarios where tipo < 2"
        consultar()
        DGV_ONLINE.DataSource = Tabla
        DatagridModulo = DGV_ONLINE
        Datagrid_Align()


        For x As Integer = 0 To DGV_ONLINE.Rows.Count - 1


            If DGV_ONLINE.Rows(x).Cells(2).Value = "1" Then
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/online1.png")
                DGV_ONLINE.Rows(x).Cells(3).Value = " "
            Else
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/offline.png")
            End If

        Next

        DGV_ONLINE.Columns(2).Visible = False
    End Sub

    Private Sub DGV_ONLINE_ColumnHeaderMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_ONLINE.ColumnHeaderMouseDoubleClick
        TreeView1.Visible = False
        DGV_ONLINE.Visible = True
        Consulta = "select nombre , online , substring(ultimaconexion,11) as 'ultima conexion' from usuarios where tipo < 2"
        consultar()
        DGV_ONLINE.DataSource = Tabla
        DatagridModulo = DGV_ONLINE
        Datagrid_Align()


        For x As Integer = 0 To DGV_ONLINE.Rows.Count - 1


            If DGV_ONLINE.Rows(x).Cells(2).Value = "1" Then
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/online1.png")
                DGV_ONLINE.Rows(x).Cells(3).Value = " "
            Else
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/offline.png")
            End If

        Next

        DGV_ONLINE.Columns(2).Visible = False
    End Sub

    Private Sub DGV_ONLINE_ColumnHeaderMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_ONLINE.ColumnHeaderMouseClick
        TreeView1.Visible = False
        DGV_ONLINE.Visible = True
        Consulta = "select nombre , online , substring(ultimaconexion,11) as 'ultima conexion' from usuarios where tipo < 2"
        consultar()
        DGV_ONLINE.DataSource = Tabla
        DatagridModulo = DGV_ONLINE
        Datagrid_Align()


        For x As Integer = 0 To DGV_ONLINE.Rows.Count - 1


            If DGV_ONLINE.Rows(x).Cells(2).Value = "1" Then
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/online1.png")
                DGV_ONLINE.Rows(x).Cells(3).Value = " "
            Else
                DGV_ONLINE.Rows(x).Cells(0).Value = Image.FromFile("imagenes/offline.png")
            End If

        Next

        DGV_ONLINE.Columns(2).Visible = False
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
            Button6.Text = "Ocultar Configuracion"
            Consulta = "select * from usuarios where cedula = '" & cedulaFotoPerfil & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                PlaceHolder5.Text = row("nombre")
                PlaceHolder4.Text = row("apellido")
                PlaceHolder3.Text = row("cedula")
                PlaceHolder2.Text = row("telefono")
                PlaceHolder6.Text = row("direccion")
            Next
        Else
            GroupBox1.Visible = True
            PlaceHolder2.Enabled = False
            PlaceHolder3.Enabled = False
            PlaceHolder4.Enabled = False
            PlaceHolder5.Enabled = False
            PlaceHolder6.Enabled = False
            Button7.Text = "Editar"
            Button6.Text = "Mostrar Configuracion"
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If Button7.Text = "Editar" Then
            InputBoxForm.Show()
        Else
            If PlaceHolder2.Text = "" Or PlaceHolder3.Text = "" Or PlaceHolder4.Text = "" Or PlaceHolder5.Text = "" Or PlaceHolder6.Text = "" Then

                If PlaceHolder2.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder2, "el campo no puede estar vacio")
                End If
                If PlaceHolder3.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder3, "el campo no puede estar vacio")
                End If
                If PlaceHolder4.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder4, "el campo no puede estar vacio")
                End If
                If PlaceHolder5.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder5, "el campo no puede estar vacio")
                End If
                If PlaceHolder6.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder6, "el campo no puede estar vacio")
                End If

            Else
                Try
                    Consulta_dataset = "update usuarios set nombre = '" & PlaceHolder5.Text & "' , apellido = '" & PlaceHolder4.Text & "' , cedula = '" & PlaceHolder3.Text & "' , telefono = '" & PlaceHolder2.Text & "' , direccion = '" & PlaceHolder6.Text & "' where cedula = '" & cedulaFotoPerfil & "';select * from usuarios where cedula = '" & cedulaFotoPerfil & "'"
                    consultar_DataSet()
                    MsgBox("Cambios Guardados Correctamente")
                    For Each row As DataRow In Tabla_dataset.Tables(0).Rows
                        Lbl_NombreADMIN_TXT.Text = row("nombre") & " " & row("apellido")
                    Next
                    PlaceHolder2.Enabled = False
                    PlaceHolder3.Enabled = False
                    PlaceHolder4.Enabled = False
                    PlaceHolder5.Enabled = False
                    PlaceHolder6.Enabled = False
                    Button7.Text = "Editar"
                Catch ex As Exception

                End Try

            End If

        End If
    End Sub
    Public Sub guardarmodificacion()
        If Button7.Text = "Editar" Then
            InputBoxForm.Show()
        Else
            If PlaceHolder2.Text = "" Or PlaceHolder3.Text = "" Or PlaceHolder4.Text = "" Or PlaceHolder5.Text = "" Or PlaceHolder6.Text = "" Then

                If PlaceHolder2.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder2, "el campo no puede estar vacio")
                End If
                If PlaceHolder3.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder3, "el campo no puede estar vacio")
                End If
                If PlaceHolder4.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder4, "el campo no puede estar vacio")
                End If
                If PlaceHolder5.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder5, "el campo no puede estar vacio")
                End If
                If PlaceHolder6.Text = "" Then
                    ErrorProvider1.SetError(PlaceHolder6, "el campo no puede estar vacio")
                End If

            Else

                Consulta_dataset = "update usuarios set nombre = '" & PlaceHolder5.Text & "' , apellido = '" & PlaceHolder4.Text & "' , cedula = '" & PlaceHolder3.Text & "' , telefono = '" & PlaceHolder2.Text & "' , direccion = '" & PlaceHolder6.Text & "' where cedula = '" & cedulaFotoPerfil & "';select * from usuarios where cedula = '" & cedulaFotoPerfil & "'"
                consultar_DataSet()
                MsgBox("Cambios Guardados Correctamente")
                For Each row As DataRow In Tabla_dataset.Tables(0).Rows
                    Lbl_NombreADMIN_TXT.Text = row("nombre") & " " & row("apellido")
                Next
                PlaceHolder2.Enabled = False
                PlaceHolder3.Enabled = False
                PlaceHolder4.Enabled = False
                PlaceHolder5.Enabled = False
                PlaceHolder6.Enabled = False
                Button7.Text = "Editar"

            End If

        End If
    End Sub
    Private Sub ConfigAdmin_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MENU3.Timer_Prestamos_LIVE.Enabled = True
    End Sub
    Public Sub chartVistaPrevia()
        Chart1.ChartAreas.Clear()
        Chart1.Series.Clear()
        Chart1.ChartAreas.Add("ejemplo")
        Chart1.Series.Add("ejemplo")
        Chart1.Series("ejemplo").Points.AddXY(" ", 1)

        If RadioButton1.Checked = True Then
            Chart1.ChartAreas("ejemplo").Area3DStyle.Enable3D = False
            Chart1.Series("ejemplo").ChartType = DataVisualization.Charting.SeriesChartType.Column
        End If

        If RadioButton2.Checked = True Then
            Chart1.ChartAreas("ejemplo").Area3DStyle.Enable3D = True
            Chart1.Series("ejemplo").ChartType = DataVisualization.Charting.SeriesChartType.Column
        End If

        If RadioButton3.Checked = True Then
            Chart1.ChartAreas("ejemplo").Area3DStyle.Enable3D = False
            Chart1.Series("ejemplo").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        End If

        If RadioButton4.Checked = True Then
            Chart1.ChartAreas("ejemplo").Area3DStyle.Enable3D = True
            Chart1.Series("ejemplo").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        End If

        Chart1.Series("ejemplo").IsVisibleInLegend = False

    End Sub

    Private Sub PlaceHolder5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder5.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarmodificacion()
        End If
    End Sub

    Private Sub PlaceHolder6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder6.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarmodificacion()
        End If
    End Sub
    Private Sub PlaceHolder4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder4.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarmodificacion()
        End If
    End Sub
    Private Sub PlaceHolder3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder3.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarmodificacion()
        End If
    End Sub
    Private Sub PlaceHolder2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder2.KeyDown
        If e.KeyCode = Keys.Enter Then
            guardarmodificacion()
        End If
    End Sub
    Private Sub PlaceHolder5_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder5.TextChanged
        ErrorProvider1.SetError(PlaceHolder5, "")
    End Sub

    Private Sub PlaceHolder4_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder4.TextChanged
        ErrorProvider1.SetError(PlaceHolder4, "")
    End Sub

    Private Sub PlaceHolder3_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder3.TextChanged
        ErrorProvider1.SetError(PlaceHolder3, "")
    End Sub

    Private Sub PlaceHolder2_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder2.TextChanged
        ErrorProvider1.SetError(PlaceHolder2, "")
    End Sub

    Private Sub PlaceHolder6_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder6.TextChanged
        ErrorProvider1.SetError(PlaceHolder6, "")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        PlaceHolder2.Enabled = False
        PlaceHolder3.Enabled = False
        PlaceHolder4.Enabled = False
        PlaceHolder5.Enabled = False
        PlaceHolder6.Enabled = False
        Button7.Text = "Editar"
    End Sub
End Class