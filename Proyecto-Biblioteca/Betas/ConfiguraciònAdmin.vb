Public Class ConfiguraciònAdmin

    Dim ced_ingresar As Integer = Nothing
    Dim nom_ingresar As String = Nothing
    Dim ape_ingresar As String = Nothing
    Dim tel_ingresar As Integer = Nothing
    Dim dir_ingresar As String = Nothing
    Dim tipo_ingresar As Integer = Nothing
    Dim pass_ingresar As String = Nothing
    Dim cont_ingresar As String = Nothing
    Dim i_ingresar As Integer = 0 ' Variable bandera para avisar que existe un error
    Dim MsgStyle As MsgBoxStyle

    Dim dia_ingresar As String
    Dim mes_ingresar As String
    Dim año_ingresar As String

    Dim styleMSG_datagrid As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Question
    Dim styleMSGOK_datagrid As MsgBoxStyle = MsgBoxStyle.OkOnly + MsgBoxStyle.Question
    Dim confirmacion As String = 0
    Dim cedulaAdmin As String
    Dim cedulaUser As String
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


        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo = '1'"
        consultar()
        dgv_buscar.DataSource = Tabla
        DatagridModulo = dgv_buscar
        Datagrid_Align()
        dgv_buscar.Columns.Item("Tipo").Visible = False

        listboxcarga()

        ComboBox3.SelectedIndex = 0

        '/////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////////// Rellernar ComboBoxs ////////////////////////////////////////
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



        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo = '1'"
        consultar()
        Dgv_Baja.DataSource = Tabla
        DatagridModulo = Dgv_Baja
        Datagrid_Align()
        Dgv_Baja.Columns.Item("Tipo").Visible = False

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ANIMACION = ComboBox3.SelectedItem
        If ComboBox3.SelectedItem = 1 Then
            MENU3.Timer_InicioLabel.Enabled = True
            MENU3.Timer_LibrosLabel.Enabled = True
            MENU3.Timer_NvegadorLabel.Enabled = True
            MENU3.Timer_PrestamosLabel.Enabled = True
            MENU3.Timer_UsuariosLabel.Enabled = True
            MENU3.Timer_RevistasLabel.Enabled = True
        Else
            MENU3.label_usuarios.Left = 72
            MENU3.label_libros.Left = 72
            MENU3.LabelInicio.Left = 72
            MENU3.LabelRevistas.Left = 72
            MENU3.label_prestamos.Left = 72
            MENU3.label_navegador.Left = 72

        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            cont_ingresar = contrasenia_txt.Text
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

                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo, nacimiento, estado, contrasenia, moroso) values (concat(upper(left('" + nom_ingresar + "',1)), lower(substr('" + nom_ingresar + "',2))), concat(upper(left('" + ape_ingresar + "',1)), lower(substr('" + ape_ingresar + "',2))), '" + Str(ced_ingresar) + "', '" + Str(tel_ingresar) + "', '" + dir_ingresar + "', '1', '" + nacimiento_ingresar + "','1', '" + cont_ingresar + "', 0);"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo='0'"
                consultar()
                dgv_buscar.DataSource = Tabla

                If ERROR1 = 1 Then

                    MsgStyle = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
                    MsgBox("Error al agregar usuario", MsgStyle, Title:="Biblioteca")
                    ERROR1 = 0

                Else

                    MsgStyle = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
                    MsgBox("Usuario agregado con exito", MsgStyle, Title:="Biblioteca")
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
        dgv_buscar.DataSource = Tabla

    End Sub

    Private Sub dgv_buscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_buscar.CellDoubleClick
        If MsgBox("Desea borrar este usuario", styleMSG_datagrid, Title:="Desea borrar?") = MsgBoxResult.Yes Then

            cedulaUser = dgv_buscar.Item(2, dgv_buscar.CurrentRow.Index).Value
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
                dgv_buscar.DataSource = Tabla
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo = '1'"
                consultar()
                Dgv_Baja.DataSource = Tabla
                listboxcarga()
            Else
                MsgBox("La cedula ingresada no coincide con ningun administrador", styleMSGOK_datagrid, Title:="Error")
            End If
        Else
            MsgBox("No se dio de baja")
        End If
    End Sub


    Private Sub Dgv_Baja_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Baja.CellDoubleClick
        If MsgBox("Desea activar a este usuario", styleMSG_datagrid, Title:="Desea activarlo?") = MsgBoxResult.Yes Then

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
                dgv_buscar.DataSource = Tabla
                listboxcarga()
            Else
                MsgBox("La cedula ingresada no coincide con ningun administrador", styleMSGOK_datagrid, Title:="Error")
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
End Class