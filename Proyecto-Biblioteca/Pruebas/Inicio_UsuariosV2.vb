Public Class Inicio_UsuariosV2
    Dim activado As Integer = 0
    Dim tamaño As Integer
    Dim animaciones As Integer = 0
    Dim seleccionado As String
    Private Sub Inicio_UsuariosV2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////iNGRESAR USUARIOS//////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        '///Cargar ComboBox DIA///

        'Como ahorre lineas con este for xdxdxd

        For i As Integer = 0 To 31
            If i = 0 Then
                ComboBox1.Items.Add("Dia")
                ComboBox1.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
            Else
                ComboBox1.Items.Add(i)
            End If
        Next

        '///Cargar ComboBox DIA///

        ComboBox2.Items.Add("Mes")
        ComboBox2.SelectedIndex = 0

        ComboBox2.Items.Add("Enero")
        ComboBox2.Items.Add("Febrero")
        ComboBox2.Items.Add("Marzo")
        ComboBox2.Items.Add("Abril")
        ComboBox2.Items.Add("Mayo")
        ComboBox2.Items.Add("Junio")
        ComboBox2.Items.Add("Julio")
        ComboBox2.Items.Add("Agosto")
        ComboBox2.Items.Add("Setiembre")
        ComboBox2.Items.Add("Octubre")
        ComboBox2.Items.Add("Noviembre")
        ComboBox2.Items.Add("Diciembre")

        '/////////////////

        '///Cargar ComboBox DIA///

        For i As Integer = 1899 To 2000
            If i = 1899 Then
                ComboBox3.Items.Add("Año")
                ComboBox3.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
            Else
                ComboBox3.Items.Add(i)
            End If
        Next

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////EDITAR USUARIOS//////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        For i As Integer = 0 To 31
            If i = 0 Then
                Dia_Combo.Items.Add("Dia")
                Dia_Combo.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
            Else
                Dia_Combo.Items.Add(i)
            End If
        Next

        '///Cargar ComboBox DIA///

        Mes_Combo.Items.Add("Mes")
        Mes_Combo.SelectedIndex = 0

        Mes_Combo.Items.Add("Enero")
        Mes_Combo.Items.Add("Febrero")
        Mes_Combo.Items.Add("Marzo")
        Mes_Combo.Items.Add("Abril")
        Mes_Combo.Items.Add("Mayo")
        Mes_Combo.Items.Add("Junio")
        Mes_Combo.Items.Add("Julio")
        Mes_Combo.Items.Add("Agosto")
        Mes_Combo.Items.Add("Setiembre")
        Mes_Combo.Items.Add("Octubre")
        Mes_Combo.Items.Add("Noviembre")
        Mes_Combo.Items.Add("Diciembre")

        '/////////////////

        '///Cargar ComboBox DIA///

        For i As Integer = 1899 To 2000
            If i = 1899 Then
                Año_Combo.Items.Add("Año")
                Año_Combo.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
            Else
                Año_Combo.Items.Add(i)
            End If
        Next

        '/////////////////
    End Sub
    Private Sub PlaceHolder1_TextChanged(sender As System.Object, e As System.EventArgs) Handles Busqueda_Txt.TextChanged
        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo' and nombre like '" & Busqueda_Txt.Text & "%';"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Select Case activado
            Case 1
                If Panel1.Left < 890 Then
                    Panel1.Left += 5
                    tamaño = tamaño + 5
                Else
                    activado = 0
                    DataGridView1.Width = DataGridView1.Width + tamaño
                    Timer1.Enabled = False
                    tamaño = 0
                End If
            Case 0
                If Panel1.Left > 640 Then
                    Panel1.Left -= 5
                    tamaño = tamaño + 5

                Else
                    activado = 1
                    MsgBox(tamaño)
                    DataGridView1.Width = DataGridView1.Width - tamaño
                    Timer1.Enabled = False
                    tamaño = 0
                End If
        End Select


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        seleccionado = 0
        animaciones1()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxEditar.Click
        seleccionado = "editar"
        animaciones1()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxAgregar.Click
        seleccionado = "agregar"
        animaciones1()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxEliminar.Click
        seleccionado = "eliminar"
        animaciones1()
    End Sub


    Private Sub animaciones1()
        Select Case animaciones
            Case 1
                Timer1.Enabled = True
            Case 0
                Select Case activado
                    Case 1
                        If DataGridView1.Width = 621 Then
                            DataGridView1.Width = DataGridView1.Width + 300
                        Else

                        End If


                        Select Case seleccionado
                            Case "editar"

                                Panel1.Left = 943

                                Panel2.BackColor = Drawing.Color.Silver
                                PictureBoxEditar.Location = New Point(-5, 98)
                                PictureBoxAgregar.Location = New Point(-5, 203)
                                PictureBoxEliminar.Location = New Point(-5, 300)
                                PanelEditar.Visible = False
                                PanelAgregar.Visible = False

                                activado = 0

                            Case "agregar"

                                Panel1.Left = 943
                                Panel2.BackColor = Drawing.Color.Silver
                                PictureBoxEditar.Location = New Point(-5, 98)
                                PictureBoxAgregar.Location = New Point(-5, 203)
                                PictureBoxEliminar.Location = New Point(-5, 300)
                                PanelEditar.Visible = False
                                PanelAgregar.Visible = False

                                activado = 0

                            Case "eliminar"

                                Panel1.Left = 943
                                Panel2.BackColor = Drawing.Color.Red

                                PictureBoxEditar.Location = New Point(-5, 98)
                                PictureBoxAgregar.Location = New Point(-5, 203)
                                PictureBoxEliminar.Location = New Point(-5, 300)
                                PanelEditar.Visible = False
                                PanelAgregar.Visible = False

                                activado = 0

                        End Select
                    Case 0
                        If DataGridView1.Width = 921 And seleccionado <> "eliminar" Then
                            DataGridView1.Width = DataGridView1.Width - 300
                        Else

                        End If


                        Select Case seleccionado
                            Case "editar"

                                Panel1.Left = 640

                                Panel2.BackColor = Drawing.Color.Silver
                                PictureBoxEditar.Location = New Point(144, 28)
                                PictureBoxAgregar.Location = New Point(-5, 203)
                                PictureBoxEliminar.Location = New Point(-5, 300)
                                PanelEditar.Visible = True
                                PanelAgregar.Visible = False

                                activado = 1

                            Case "agregar"

                                Panel1.Left = 640
                                Panel2.BackColor = Drawing.Color.Silver
                                PictureBoxAgregar.Location = New Point(144, 28)
                                PictureBoxEditar.Location = New Point(-5, 98)
                                PictureBoxEliminar.Location = New Point(-5, 300)
                                PanelEditar.Visible = False
                                PanelAgregar.Visible = True

                                activado = 1

                            Case "eliminar"

                                'Panel1.Left = 640
                                Panel2.BackColor = Drawing.Color.Red

                                PictureBoxEliminar.Location = New Point(-5, 300)
                                PictureBoxAgregar.Location = New Point(-5, 203)
                                PictureBoxEditar.Location = New Point(-5, 98)
                                PanelEditar.Visible = False
                                PanelAgregar.Visible = False

                                activado = 1

                        End Select
                End Select

        End Select
    End Sub

    Private Sub PictureBoxEditarM_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxEditarM.Click
        seleccionado = "editar"
        animaciones1()
    End Sub

    Private Sub PictureBoxAgregarM_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxAgregarM.Click
        seleccionado = "agregar"
        animaciones1()
    End Sub

    Private Sub PictureBoxEliminarM_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxEliminarM.Click
        seleccionado = "eliminar"
        animaciones1()
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////COLORES////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub PictureBoxEditarM_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBoxEditarM.MouseEnter
        Panel3.BackColor = Drawing.Color.LightGray
    End Sub

    Private Sub PictureBoxEditarM_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBoxEditarM.MouseLeave
        Panel3.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub PictureBoxAgregarM_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBoxAgregarM.MouseEnter
        Panel4.BackColor = Drawing.Color.LightGray
    End Sub

    Private Sub PictureBoxAgregarM_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBoxAgregarM.MouseLeave
        Panel4.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub PictureBoxEliminarM_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBoxEliminarM.MouseLeave
        Panel5.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub PictureBoxEliminarM_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBoxEliminarM.MouseEnter
        Panel5.BackColor = Drawing.Color.LightGray
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    Private Sub guardar_Click(sender As System.Object, e As System.EventArgs) Handles guardar.Click
        '//////////////////// AGREGAR USUARIOS /////////////////////////////

        ' Crear Variables

        Dim ced As Integer = Nothing
        Dim nom As String = Nothing
        Dim ape As String = Nothing
        Dim tel As Integer = Nothing
        Dim dir As String = Nothing
        Dim tipo As Integer = Nothing
        Dim pass As String = Nothing
        Dim i As Integer ' Variable bandera para avisar que existe un error
        i = 0

        ' Verificar campos
        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre.Text = "Nombre no puede estar vacío"
            i = 1
        Else
            nom = nombre_txt.Text
        End If
        ape = apellido_txt.Text

        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula.Text = "Cedula no puede estar vacío"
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then
                'Modulo.Verificar_Cedula(cedula_txt.Text)
                'If Modulo.Correcto = 0 Then
                ced = cedula_txt.Text
                'Else
                '    i = 1
                'End If
            Else
                errorcedula.Text = "No valido, ingrese solo numeros"
            End If
        End If
        If IsNumeric(telefono_txt.Text) = True Then
            tel = telefono_txt.Text
        Else
            errortelefono.Text = "No valido, ingrese solo numeros"
        End If

        dir = direccion_txt.Text
        If RadioButton3.Checked Then
            tipo = 0
            pass = InputBox("Ingrese una Contraseña", "Contraseña")
        Else
            tipo = 1
        End If

        If i = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try
                'Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo) values ('" + nom + "', " + ape + "', '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "');

                'Dim nacimiento1 As String = dtpfecha.Value.ToString("yyyy-MM-dd")
                fechaMesNum = ComboBox2.SelectedItem.ToString 'envio el dato a la variable publica para poder llamar al metodo
                MesNum() 'llamo al metodo para obtener el numero de un mes texto , ahora fechaMesNum ya contiene el numero del Mes
                Dim nacimiento As String = ComboBox3.SelectedItem.ToString + "-" + fechaMesNum + "-" + ComboBox1.SelectedItem.ToString '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT
                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo , nacimiento, estado, contrasenia) values (concat(upper(left('" + nom + "',1)), lower(substr('" + nom + "',2))), concat(upper(left('" + ape + "',1)), lower(substr('" + ape + "',2))), '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "', '" + nacimiento + "', 'Activo', '" + pass + "');"
                consultar()

                MsgBox("Usuario agregado con exito")

                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Existen errores en el formulario, revisar los campos remarcados")
        End If
        Try
            Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
            consultar()
            DataGridView1.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '///////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ' Crear Variables

        Dim ced1 As Integer
        Dim nom As String = Nothing
        Dim ape As String
        Dim tel As Integer
        Dim dir As String
        Dim tipo As Integer
        Dim contra As String = Nothing
        Dim i As Integer ' Variable bandera para avisar que existe un error
        i = 0

        ced1 = cedula.Text

        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre1.Text = "Nombre no puede estar vacío" 'Label invisible debajo de nombre
            i = 1
        Else
            nom = nombre.Text
        End If
        ape = apellido.Text
        If LTrim$(cedula.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula1.Text = "Cedula no puede estar vacío" 'Label invisible debajo de cedula
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula.Text) = True Then
                ced1 = cedula.Text
            Else
                errorcedula1.Text = "No valido, ingrese solo numeros" 'Label invisible debajo de cedula
            End If
        End If
        If IsNumeric(telefono.Text) = True Then
            tel = telefono.Text
        Else
            errortelefono1.Text = "No valido, ingrese solo numeros" 'Label invisible debajo de telefono
        End If
        dir = direccion.Text
        If RadioButton5.Checked Then
            tipo = 0
        Else
            tipo = 1
        End If

        fechaMesNum = Mes_Combo.SelectedItem.ToString 'envio el dato a la variable publica para poder llamar al metodo
        MesNum() 'llamo al metodo para obtener el numero de un mes texto , ahora fechaMesNum ya contiene el numero del Mes
        Dim nacimiento As String = Dia_Combo.SelectedItem.text.ToString + "-" + fechaMesNum + "-" + Año_Combo.SelectedItem.text.ToString '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT
        MsgBox(nacimiento)
        Try
            Consulta = "update usuarios set nombre='" + nom + "', apellido='" + ape + "', cedula='" + Str(ced1) + "', telefono='" + Str(tel) + "', direccion='" + dir + "', tipo='" + Str(tipo) + "', nacimiento='" + nacimiento + "' where cedula='" + Str(ced1) + "';"
            consultar()
            MsgBox("Edición guardada satisfactoriamente")

            '//////////////////Mostrar los datos actualizados en el datagrid///////////////////////
            Try
                Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
                consultar()
                DataGridView1.DataSource = Tabla
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '//////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            cedula.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            nombre.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            apellido.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            direccion.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
            telefono.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
            Dia_Combo.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString.Substring(0, 2)
            substring = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString.Substring(3, 2)
            mes()
            Mes_Combo.Text = substring
            Año_Combo.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString.Substring(6, 4)
            'contraseña.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class