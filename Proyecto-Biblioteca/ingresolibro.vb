Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO /////////////////////// Esto no se esta utiizando
    Dim cod As Integer = 0

    Dim activadoEdi As Integer = 0
    Dim activadoAut As Integer = 0
    Dim activadoclas As Integer = 0

    Dim dvgeditorialW As Integer
    Dim dvgautorW As Integer
    Dim dgvclas As Integer
    Dim bandera As Integer

    Dim primeringreso As Integer = 0
    Dim primeringresoedi As Integer = 0
    Dim primeringresoau As Integer = 0
    Dim primeringresoclas As Integer = 0

    Dim contadoringreso As Integer = 0
    Dim contadoringresoedi As Integer = 0
    Dim contadoringresoau As Integer = 0
    Dim contadoringresoclas As Integer = 0

    Dim errocodigo As Integer

    Dim autor As Integer
    Dim editorial As Integer
    Dim clasificacion As String

    Dim seleccionado As Integer = 0
    Dim error10 As Integer = 0
    Dim errorau As Integer = 0

    Dim ensala As Integer
    Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click
        If bandera = 1 Then
            Try
                If Trim(txtcod_libro.Text) = "" Then
                    ErrorProvider1.SetError(txtcod_libro, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txttitulo.Text) = "" Then
                    ErrorProvider1.SetError(txttitulo, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtanio.Text) = "" Then
                    ErrorProvider1.SetError(txtanio, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtorigen.Text) = "" Then
                    ErrorProvider1.SetError(txtorigen, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtautor.Text) = "" Then
                    ErrorProvider1.SetError(txtautor, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtclasificacion.Text) = "" Then
                    ErrorProvider1.SetError(txtclasificacion, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtvolumen.Text) = "" Then
                    ErrorProvider1.SetError(txtvolumen, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtcasa_editorial.Text) = "" Then
                    ErrorProvider1.SetError(txtcasa_editorial, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If
                If Trim(txtubicacion.Text) = "" Then
                    ErrorProvider1.SetError(txtubicacion, "El campo se encuentra vacio")
                    contadoringreso = contadoringreso + 1
                End If

                If error10 = 0 Then
                    If contadoringreso <> 0 Then
                        contadoringreso = 0
                        primeringreso = 1

                        '////////////
                        errocodigo = 1
                        '/////////////
                    Else
                        For Each Row As DataGridViewRow In dgvlibro.Rows
                            'El if se encarga de preguntar si el cod_libro ingresado no se encuentra ya en la tabla libro.
                            'Si no lo esta permite avanzar la consulta.
                            If Row.Cells("cod_libro").Value = txtcod_libro.Text Then
                                cod = 1
                            End If
                        Next
                        If cod = 1 Then
                            'En caso de estarlo envia un mensaje de error.
                            ErrorProvider1.SetError(txtcod_libro, "El Codigo Ya Existe En El Inventario")
                            cod = 0
                        Else
                            Try
                                '/// Permite ingresar un nuevo dato a la tabla libros ///
                                '/// Dependiendo si el usuario eligio No (0) o Si(1) en el combobox en sala, se realiza el if que le dara el valor de 0 o 1 al ingresarlo///
                                If cmbsala.SelectedItem = "No" Then
                                    Consulta = "insert into libro values('" + txtcod_libro.Text + "',concat(upper(left('" + txttitulo.Text + "',1)),lower(substr('" + txttitulo.Text + "',2))), concat(upper(left('" & autor & "',1)),lower(substr('" & autor & "',2))), concat(upper(left('" & editorial & "',1)),lower(substr('" & editorial & "',2))),'" + txtvolumen.Text + "','" + txtanio.Text + "', concat(upper(left('" + txtorigen.Text + "',1)),lower(substr('" + txtorigen.Text + "',2))), concat(upper(left('" + txtobservaciones.Text + "' ,1)),lower(substr('" + txtobservaciones.Text + "' ,2))),'0', concat(upper(left('" & clasificacion & "',1)),lower(substr('" & clasificacion & "',2))),concat(upper(left('" + txtubicacion.Text + "',1)),lower(substr('" + txtubicacion.Text + "',2))),'0')"
                                    consultar()
                                ElseIf cmbsala.SelectedItem = "Si" Then
                                    Consulta = "insert into libro values('" + txtcod_libro.Text + "',concat(upper(left('" + txttitulo.Text + "',1)),lower(substr('" + txttitulo.Text + "',2))), concat(upper(left('" & autor & "',1)),lower(substr('" & autor & "',2))), concat(upper(left('" & editorial & "',1)),lower(substr('" & editorial & "',2))),'" + txtvolumen.Text + "','" + txtanio.Text + "', concat(upper(left('" + txtorigen.Text + "',1)),lower(substr('" + txtorigen.Text + "',2))), concat(upper(left('" + txtobservaciones.Text + "' ,1)),lower(substr('" + txtobservaciones.Text + "' ,2))),'0', concat(upper(left('" & clasificacion & "',1)),lower(substr('" & clasificacion & "',2))),concat(upper(left('" + txtubicacion.Text + "',1)),lower(substr('" + txtubicacion.Text + "',2))),'1')"
                                    consultar()
                                End If
                                '///////////////////////////////////////////
                                '//// Muestra Los Datos en el DataGrid//////
                                '///////////////////////////////////////////
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo' , autor.nombre, libro.volumen as 'Volumen' ,editorial.nombre, libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones',libro.cod_clas,clasificacion.nom_clas from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas"
                                consultar()
                                dgvlibro.DataSource = Tabla
                                '///////////////////////////////////////////////////////////////////////////// 
                                '/// Al haberse ingresado un nuevo dato, limpia los textbox del formulario ///
                                '/////////////////////////////////////////////////////////////////////////////
                                txtcod_libro.Clear()
                                txtautor.Clear()
                                txttitulo.Clear()
                                txtvolumen.Clear()
                                txtcasa_editorial.Clear()
                                txtanio.Clear()
                                txtorigen.Clear()
                                txtobservaciones.Clear()
                                txtclasificacion.Clear()
                                txtubicacion.Clear()
                                '/////////////////////////////////////////////////////

                                primeringreso = 0
                                ErrorProvider1.SetError(txtcod_libro, "")
                                ErrorProvider1.SetError(txttitulo, "")
                                ErrorProvider1.SetError(txtanio, "")
                                ErrorProvider1.SetError(txtorigen, "")
                                ErrorProvider1.SetError(txtautor, "")
                                ErrorProvider1.SetError(txtvolumen, "")
                                ErrorProvider1.SetError(txtcasa_editorial, "")
                                ErrorProvider1.SetError(txtclasificacion, "")
                                ErrorProvider1.SetError(txtubicacion, "")

                                MsgBox("se ha ingresado el libro en el inventario")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try

                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                'MsgBox("Error 01234: Imposible Ingresar el libro. Reintente")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub btnselectautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectautor.Click
        If bandera = 1 Then
            Try
                'Este boton muestra un panel donde podremos seleccionar un autor o ingresar uno nuevo.
                Try
                    '1 autor , 2 editorial, 3 clasificacion
                    seleccionado = 1
                    Select Case seleccionado
                        Case 1
                            Pautor.Visible = True
                            Peditorial.Visible = False
                            Pclasificacion.Visible = False
                        Case 2
                            Peditorial.Visible = False
                            Pautor.Visible = False
                            Pclasificacion.Visible = True
                        Case 3
                            Pclasificacion.Visible = False
                            Pautor.Visible = False
                            Peditorial.Visible = True
                    End Select

                    ErrorProvider1.SetError(txtautor, "")
                    Consulta = "SELECT * FROM autor"
                    consultar()
                    dgvautor.DataSource = Tabla
                    dgvautor.Columns(0).Visible = False
                    dgvautor.Columns(1).HeaderText = "Nombre de Autor"
                    dgvautor.Columns(2).HeaderText = "Nacionalidad"
                    dgvautor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Autor")
                End Try
                'El boton se muestra
                btningautor.Visible = True
                'El boton se esconde
                btncancelaredi.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If

    End Sub

    Private Sub btnselecteditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselecteditorial.Click
        If bandera = 1 Then
            Try
                'Este boton muestra un panel donde podremos seleccionar una editorial o ingresar una nueva.
                Try
                    '1 autor , 2 editorial, 3 clasificacion
                    seleccionado = 3
                    Select Case seleccionado
                        Case 1
                            Pautor.Visible = True
                            Peditorial.Visible = False
                            Pclasificacion.Visible = False
                        Case 2
                            Peditorial.Visible = False
                            Pautor.Visible = False
                            Pclasificacion.Visible = True
                        Case 3
                            Pclasificacion.Visible = False
                            Pautor.Visible = False
                            Peditorial.Visible = True
                    End Select

                    ErrorProvider1.SetError(txtcasa_editorial, "")
                    Consulta = "SELECT * FROM editorial"
                    consultar()
                    dgveditorial.DataSource = Tabla
                    dgveditorial.Columns(1).HeaderText = "Nombre de Editorial"
                    dgveditorial.Columns(2).HeaderText = "Pais"
                    dgveditorial.Columns(3).HeaderText = "Año"
                    dgveditorial.Columns(0).Visible = False
                    dgveditorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Editorial")
                End Try

                'El Boton se muestra
                btningeditorial.Visible = True
                'El boton se esconde
                btncancelaredi.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If

    End Sub

    Private Sub ingresolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim contadoringreso As Integer = 0
        Pautor.Visible = False
        Peditorial.Visible = False
        Pclasificacion.Visible = False
        cmbclasificacion.SelectedIndex = 0
        txtorigen.Text = "Sin Origen"
        txtvolumen.Text = "0"

        'Comprobacion'

        Consulta = "select * from usuarios"
        consultar()
        Try
            For Each row As DataRow In Tabla.Rows
                If row("nombre").ToString <> "" Then
                    bandera = 1
                Else
                    bandera = 0
                End If
            Next
        Catch ex1 As Exception
            MsgBox("Base de datos no disponible")
        End Try


        If bandera = 1 Then

            'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid
            Try

                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo' , autor.nombre, libro.volumen as 'Volumen' ,editorial.nombre, libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones',libro.cod_clas,clasificacion.nom_clas from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas"
                consultar()
                dgvlibro.DataSource = Tabla
                dgvlibro.Columns(4).HeaderText = "Nombre Editorial"
                dgvlibro.Columns(2).HeaderText = "Nombre Autor"
                dgvlibro.Columns(0).HeaderText = "Nº de Inventario"
                dgvlibro.Columns(5).HeaderText = "Año"
                dgvlibro.Columns(8).HeaderText = "Codigo de Clasificacion"
                dgvlibro.Columns(9).HeaderText = "Clasificacion"
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try

            cmbsala.SelectedIndex = 0

            'Alinear celdas en el datagridview1'
            Dim z As Integer
            z = dgvlibro.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid, luego se resta 1 ya que empieza desde 0'
            For x = 0 To z 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
                dgvlibro.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next
            dgvlibro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
            dgvlibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'

            dvgeditorialW = dgveditorial.Width
            dvgautorW = dgvautor.Width
            dgvclas = dgvclasificacion.Width

        Else
            txtcod_libro.ReadOnly = True
            txttitulo.ReadOnly = True
            txtanio.ReadOnly = True
            txtorigen.ReadOnly = True
            txtautor.ReadOnly = True
            txtvolumen.ReadOnly = True
            txtcasa_editorial.ReadOnly = True
            txtobservaciones.ReadOnly = True


        End If
    End Sub

    Private Sub btnnwautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwautor.Click
        If bandera = 1 Then
            Try
                If Trim(txtnombreau.Text) = "" Or errorau = 1 Then
                    ErrorProvider1.SetError(txtnombreau, "Compruebe que los datos ingresados son validos")
                    contadoringresoau = contadoringresoau + 1
                End If
                If Trim(txtpaisau.Text) = "" Or errorau = 1 Then
                    ErrorProvider1.SetError(txtpaisau, "Compruebe que los datos ingresados son validos")
                    contadoringresoau = contadoringresoau + 1
                End If
                If errorau = 0 Then
                    If contadoringresoau <> 0 Then
                        contadoringresoau = 0
                        primeringresoau = 1

                    Else
                        'Ingresa un nuevo autor a la Base de Datos.
                        Consulta = "INSERT INTO autor (nombre, nacionalidad) values (concat(upper(left('" + txtnombreau.Text + "',1)),lower(substr('" + txtnombreau.Text + "',2))), concat(upper(left('" + txtpaisau.Text + "',1)),lower(substr('" + txtpaisau.Text + "',2))))"
                        consultar()

                        Consulta = "SELECT * FROM autor"
                        consultar()
                        dgvautor.DataSource = Tabla

                        'El boton se esconde
                        btncancelarautor.Visible = False
                        'El boton se muestra
                        btningautor.Visible = True

                        'Limpia los campos de texto'
                        txtnombreau.Clear()
                        txtpaisau.Clear()

                        timerautor.Enabled = True

                        primeringresoau = 0
                        ErrorProvider1.SetError(txtnombreau, "")
                        ErrorProvider1.SetError(txtpaisau, "")
                    End If
                End If

                

            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        End If


    End Sub

    Private Sub btningautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningautor.Click
        If bandera = 1 Then
            Try
                'El boton se esconde
                btningautor.Visible = False
                'El boton se muestra
                btncancelarautor.Visible = True

                'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse un nuevo autor.
                timerautor.Enabled = True
            Catch ex As Exception
                MsgBox("No es posible realizar esta accion")
            End Try
        Else
            MsgBox("Esta accion es imposible de realizar actualmente")
        End If
    End Sub

    Private Sub btncancelarautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarautor.Click

        'El boton se esconde.
        btncancelarautor.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'Limpia los campos de texto'
        txtnombreau.Clear()
        txtpaisau.Clear()

        'Desactiva los errorprovider
        ErrorProvider1.SetError(txtnombreau, "")
        ErrorProvider1.SetError(txtpaisau, "")

        'El Datagrid se redimensiona y a su vez el panel se mueve a su posicion inicial.
        timerautor.Enabled = True

    End Sub

    Private Sub btningeditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningeditorial.Click
        'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse una nueva editorial.
        timereditorial.Enabled = True
        'El boton se esconde
        btningeditorial.Visible = False
        'El boton se muestra
        btncancelaredi.Visible = True

    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click

        If activadoEdi = 1 Then
            'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            timereditorial.Enabled = True
        End If

        'El boton se esconde
        btncancelaredi.Visible = False
        'El boton se muestra
        btningeditorial.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'Si no se escoge ningun dato y el campo se mantiene vacio, el errorprovider es activado.
        If txtcasa_editorial.Text = "" Then
            ErrorProvider1.SetError(txtcasa_editorial, "El Campo Se encuentra vacio")
        End If

        'El panel editorial se oculta.
        Peditorial.Visible = False


    End Sub

    Private Sub dgvautor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvautor.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre del autor.
        txtautor.Text = dgvautor.Item(1, dgvautor.CurrentRow.Index).Value
        autor = dgvautor.Item(0, dgvautor.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Pautor.Visible = False
    End Sub

    Private Sub dgveditorial_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgveditorial.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre de la editorial.
        txtcasa_editorial.Text = dgveditorial.Item(1, dgveditorial.CurrentRow.Index).Value
        editorial = dgveditorial.Item(0, dgveditorial.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Peditorial.Visible = False
    End Sub

    Private Sub btnvolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        If activadoAut = 1 Then
            'El datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            timerautor.Enabled = True
        End If

        'El boton se esconde
        btncancelarautor.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'El contenido de los textbox es eliminado.
        txtnombreau.Clear()
        txtpaisau.Clear()

        'Si no se escoge ningun dato y el campo se mantiene vacio, el errorprovider es activado.
        If txtautor.Text = "" Then
            ErrorProvider1.SetError(txtautor, "El Campo Se encuentra vacio")
        End If

        'El panel autor se oculta.
        Pautor.Visible = False
    End Sub

    Private Sub btnnweditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnweditorial.Click

        If Trim(txtnombree.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtnombree, "El campo se encuentra vacio")
            contadoringresoedi = contadoringresoedi + 1
        End If
        If Trim(txtpais.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtpais, "El campo se encuentra vacio")
            contadoringresoedi = contadoringresoedi + 1
        End If
        If Trim(txtanioe.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtanioe, "El campo se encuentra vacio")
            contadoringresoedi = contadoringresoedi + 1
        End If

        If error10 = 0 Then
            If contadoringresoedi <> 0 Then
                contadoringresoedi = 0
                primeringresoedi = 1

            Else
                'Ingresa una nueva editorial a la Base de datos.
                Consulta = "INSERT INTO editorial (nombre, pais, anio) values (concat(upper(left('" + txtnombree.Text + "',1)),lower(substr('" + txtnombree.Text + "',2))),concat(upper(left('" + txtpais.Text + "',1)),lower(substr('" + txtpais.Text + "',2))),'" + txtanioe.Text + "')"
                consultar()

                Try
                    Consulta = "SELECT * FROM editorial"
                    consultar()
                    dgveditorial.DataSource = Tabla

                Catch ex As Exception
                    MsgBox(ex)
                End Try

                'El boton se esconde
                btncancelaredi.Visible = False
                btningeditorial.Visible = True

                'Limpia los campos de texto'
                txtnombree.Clear()
                txtpais.Clear()
                txtanioe.Clear()

                primeringresoedi = 0
                ErrorProvider1.SetError(txtnombree, "")
                ErrorProvider1.SetError(txtpais, "")
                ErrorProvider1.SetError(txtanioe, "")

                timereditorial.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtbuscarautor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarautor.TextChanged
        'Busuqeda de autor
        Try
            Consulta = "select * from autor where nombre like '" & txtbuscarautor.Text & "%'"
            consultar()
            dgvautor.DataSource = Tabla
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btncancelaredi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelaredi.Click

        'El boton se esconde
        btncancelaredi.Visible = False
        'El boton se muestra
        btningeditorial.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'Desactiva los errorprovider
        ErrorProvider1.SetError(txtnombree, "")
        ErrorProvider1.SetError(txtpais, "")
        ErrorProvider1.SetError(txtanioe, "")

        'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion inicial.
        timereditorial.Enabled = True

    End Sub

    Private Sub txtbuscareditorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscareditorial.TextChanged
        'Busqueda de editoriales
        Consulta = "select * from editorial where nombre like '" & txtbuscareditorial.Text & "%'"
        consultar()
        dgveditorial.DataSource = Tabla
    End Sub

    Private Sub timerautor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerautor.Tick
        Select Case activadoAut
            Case 0
                If panelautor.Left > 255 Then
                    panelautor.Left -= 5

                Else
                    dgvautor.Width = dgvautor.Width - panelautor.Width
                    activadoAut = 1
                    timerautor.Enabled = False
                End If
            Case 1
                If panelautor.Left < 419 Then
                    panelautor.Left += 5

                Else
                    dgvautor.Width = dvgautorW
                    activadoAut = 0
                    timerautor.Enabled = False
                End If
        End Select
    End Sub

    Private Sub txtcod_libro_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod_libro.KeyUp
        If Not IsNumeric(txtcod_libro.Text) And txtcod_libro.Text <> "" Then
            ErrorProvider1.SetError(txtcod_libro, "ingrese solo numeros")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtcod_libro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod_libro.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtcod_libro.Text = "" Then
                ErrorProvider1.SetError(txtcod_libro, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtcod_libro, "")
            End If
        Else
            ErrorProvider1.SetError(txtcod_libro, "")
        End If
    End Sub

    Private Sub txttitulo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttitulo.KeyUp
        txttitulo.MaxLength = 30

    End Sub

    Private Sub txttitulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttitulo.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txttitulo.Text = "" Then
                ErrorProvider1.SetError(txttitulo, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txttitulo, "")
            End If
        Else
            ErrorProvider1.SetError(txttitulo, "")
        End If
    End Sub

    Private Sub txtanio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtanio.KeyUp
        txtanio.MaxLength = 4
        If Not IsNumeric(txtanio.Text) And txtanio.Text <> "" Then
            ErrorProvider1.SetError(txtanio, "ingrese solo numeros")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtanio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanio.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtanio.Text = "" Then
                ErrorProvider1.SetError(txtanio, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtanio, "")
            End If
        Else
            ErrorProvider1.SetError(txtanio, "")
        End If


    End Sub

    Private Sub txtorigen_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtorigen.KeyUp
        txtorigen.MaxLength = 20
        If IsNumeric(txtorigen.Text) And txtorigen.Text <> "" Then
            ErrorProvider1.SetError(txtorigen, "ingrese solo letras")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtorigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtorigen.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtorigen.Text = "" Then
                ErrorProvider1.SetError(txtorigen, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtorigen, "")
            End If
        Else
            ErrorProvider1.SetError(txtorigen, "")
        End If
    End Sub

    Private Sub txtvolumen_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvolumen.KeyUp
        txtvolumen.MaxLength = 3
        If Not IsNumeric(txtvolumen.Text) And txtvolumen.Text <> "" Then
            ErrorProvider1.SetError(txtvolumen, "ingrese solo numeros")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtvolumen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvolumen.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtvolumen.Text = "" Then
                ErrorProvider1.SetError(txtvolumen, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtvolumen, "")
            End If
        Else
            ErrorProvider1.SetError(txtvolumen, "")
        End If
    End Sub

    Private Sub txtobservaciones_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtobservaciones.KeyUp
        txtobservaciones.MaxLength = 255
    End Sub

    Private Sub txtobservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtobservaciones.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtvolumen.Text = "" Then
                ErrorProvider1.SetError(txtvolumen, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtvolumen, "")
            End If
        Else
            ErrorProvider1.SetError(txtobservaciones, "")
        End If
    End Sub

    Private Sub autor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If autor = "" Then
                ErrorProvider1.SetError(txtautor, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtautor, "")
            End If
            ErrorProvider1.SetError(txtautor, "")
        End If
    End Sub

    Private Sub btnselectclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectclas.Click
        If bandera = 1 Then
            Try
                'Este boton muestra un panel donde podremos seleccionar un autor o ingresar uno nuevo.
                Try
                    '1 autor , 2 editorial, 3 clasificacion
                    seleccionado = 2
                    Select Case seleccionado
                        Case 1
                            Pautor.Visible = True
                            Peditorial.Visible = False
                            Pclasificacion.Visible = False
                        Case 2
                            Peditorial.Visible = False
                            Pautor.Visible = False
                            Pclasificacion.Visible = True
                        Case 3
                            Pclasificacion.Visible = False
                            Pautor.Visible = False
                            Peditorial.Visible = True
                    End Select

                    ErrorProvider1.SetError(txtclasificacion, "")
                    Consulta = "SELECT * FROM clasificacion"
                    consultar()
                    dgvclasificacion.DataSource = Tabla
                    dgvclasificacion.Columns(0).HeaderText = "Codigo de Clasificacion"
                    dgvclasificacion.Columns(1).HeaderText = "Clasificacion"
                    dgvclasificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Clasificacion")
                End Try
                'El boton se muestra
                btninclas.Visible = True
                'El boton se esconde
                btncancelarclas.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub btninclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninclas.Click
        If bandera = 1 Then
            Try
                'El boton se esconde
                btninclas.Visible = False
                'El boton se muestra
                btncancelarclas.Visible = True

                'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse un nuevo autor.
                timerclasificacion.Enabled = True
            Catch ex As Exception
                MsgBox("No es posible realizar esta accion")
            End Try
        Else
            MsgBox("Esta accion es imposible de realizar actualmente")
        End If
    End Sub

    Private Sub btncancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarautor.Click

        'El boton se esconde.
        btncancelarautor.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'Limpia los campos de texto'
        txtnombreau.Clear()
        txtpaisau.Clear()

        'El Datagrid se redimensiona y a su vez el panel se mueve a su posicion inicial.
        timerautor.Enabled = True

    End Sub

    Private Sub timereditorial_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timereditorial.Tick
        Select Case activadoEdi
            Case 0
                If Paneleditorial.Left > 245 Then
                    Paneleditorial.Left -= 5

                Else
                    dgveditorial.Width = dgveditorial.Width - Paneleditorial.Width
                    activadoEdi = 1
                    timereditorial.Enabled = False
                End If
            Case 1
                If Paneleditorial.Left < 429 Then
                    Paneleditorial.Left += 5

                Else
                    dgveditorial.Width = dvgeditorialW
                    activadoEdi = 0
                    timereditorial.Enabled = False
                End If
        End Select
    End Sub

    Private Sub timerclasificacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerclasificacion.Tick
        Select Case activadoclas
            Case 0
                If panelclasificacion.Left > 245 Then
                    panelclasificacion.Left -= 5

                Else
                    dgvclasificacion.Width = dgvclasificacion.Width - panelclasificacion.Width
                    activadoclas = 1
                    timerclasificacion.Enabled = False
                End If
            Case 1
                If panelclasificacion.Left < 423 Then
                    panelclasificacion.Left += 5

                Else
                    dgvclasificacion.Width = dgvclas
                    activadoclas = 0
                    timerclasificacion.Enabled = False
                End If
        End Select
    End Sub

    Private Sub btnvolver3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver3.Click

        If activadoclas = 1 Then
            'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            timerclasificacion.Enabled = True
        End If

        'El boton se esconde
        btncancelarclas.Visible = False
        'El boton se muestra
        btninclas.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'Si no se escoge ningun dato y el campo se mantiene vacio, el errorprovider es activado.
        If txtclasificacion.Text = "" Then
            ErrorProvider1.SetError(txtclasificacion, "El Campo Se encuentra vacio")
        End If

        'El panel editorial se oculta.
        Pclasificacion.Visible = False
    End Sub

    Private Sub btncancelarclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarclas.Click

        'El boton se esconde.
        btncancelarclas.Visible = False
        'El boton se muestra
        btninclas.Visible = True

        'Limpia los campos de texto'
        txtnombreclas.Clear()
        txtcodclas.Clear()

        'Desactiva los errorprovider
        ErrorProvider1.SetError(txtcodclas, "")
        ErrorProvider1.SetError(txtnombreclas, "")

        'El Datagrid se redimensiona y a su vez el panel se mueve a su posicion inicial.
        timerclasificacion.Enabled = True
    End Sub

    Private Sub btnnwclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwclas.Click
        If Trim(txtcodclas.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtcodclas, "El campo se encuentra vacio")
            contadoringresoclas = contadoringresoclas + 1
        End If
        If Trim(txtnombreclas.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtnombreclas, "El campo se encuentra vacio")
            contadoringresoclas = contadoringresoclas + 1
        End If
        If error10 = 0 Then
            If contadoringresoclas <> 0 Then
                contadoringresoclas = 0
                primeringresoclas = 1

            Else
                'Ingresa una nueva editorial a la Base de datos.
                'Consulta = "INSERT INTO clasificacion values ('" + txtcodclas.Text + "',concat(upper(left('" + txtnombreclas.Text + "',1))),lower(substr('" + txtnombreclas.Text + "',2)))"
                Consulta = "insert into clasificacion values('" & txtcodclas.Text & "','" & txtnombreclas.Text & "')"
                consultar()

                ErrorProvider1.SetError(txtcodclas, "")
                ErrorProvider1.SetError(txtnombreclas, "")
                Try
                    Consulta = "SELECT * FROM clasificacion"
                    consultar()
                    dgvclasificacion.DataSource = Tabla

                Catch ex As Exception
                    MsgBox(ex)
                End Try

                'El boton se esconde
                btncancelarclas.Visible = False
                btninclas.Visible = True

                'Limpia los campos de texto'
                txtcodclas.Clear()
                txtnombreclas.Clear()

                primeringresoclas = 0
                ErrorProvider1.SetError(txtcodclas, "")
                ErrorProvider1.SetError(txtnombreclas, "")

                timerclasificacion.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvclasificacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclasificacion.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre del autor.
        txtclasificacion.Text = dgvclasificacion.Item(1, dgvclasificacion.CurrentRow.Index).Value
        clasificacion = dgvclasificacion.Item(0, dgvclasificacion.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Pclasificacion.Visible = False
    End Sub

    Private Sub txtcodclas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodclas.KeyUp
        txtcodclas.MaxLength = 255
        If Not IsNumeric(txtcodclas.Text) And txtcodclas.Text <> "" Then
            ErrorProvider1.SetError(txtcodclas, "ingrese solo numeros")
            error10 = 1
        Else
            ErrorProvider1.SetError(txtcodclas, "")
            error10 = 0
        End If

        '/////////////////////////
        'Asquii . = e.KeyCode = 46
        '////////////////////////
    End Sub

    Private Sub txtcodclas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodclas.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringresoclas = 1 Then
            If txtcodclas.Text = "" Then
                ErrorProvider1.SetError(txtcodclas, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtcodclas, "")
            End If
        Else

        End If
    End Sub

    Private Sub txtanioe_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtanioe.KeyUp
        txtanioe.MaxLength = 4
        If Not IsNumeric(txtanioe.Text) And txtanioe.Text <> "" Then
            ErrorProvider1.SetError(txtanioe, "ingrese solo numeros")
            error10 = 1
        Else
            ErrorProvider1.SetError(txtanioe, "")
            error10 = 0
        End If
    End Sub

    Private Sub txtbuscarclas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarclas.TextChanged
        'Busqueda de Clasificaciones
        Select Case cmbclasificacion.SelectedIndex
            Case 0
                Consulta = "select * from clasificacion where cod_clas like '" & txtbuscarclas.Text & "%'"
                consultar()
                dgvclasificacion.DataSource = Tabla
            Case 1
                Consulta = "select * from clasificacion where nom_clas like '" & txtbuscarclas.Text & "%'"
                consultar()
                dgvclasificacion.DataSource = Tabla
            Case Else
                Consulta = "select * from clasificacion"
                consultar()
                dgvclasificacion.DataSource = Tabla
        End Select
        
    End Sub

    Private Sub txtpaisau_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpaisau.KeyUp
        txtpaisau.MaxLength = 20
        If IsNumeric(txtpaisau.Text) And txtpaisau.Text <> "" Then
            ErrorProvider1.SetError(txtpaisau, "ingrese solo letras")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtnombree_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnombree.KeyUp
        txtnombree.MaxLength = 30
        If IsNumeric(txtnombree.Text) And txtnombree.Text <> "" Then
            ErrorProvider1.SetError(txtnombree, "ingrese solo letras")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtnombreclas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnombreclas.KeyUp
        txtnombreclas.MaxLength = 50
        If IsNumeric(txtnombreclas.Text) And txtnombreclas.Text <> "" Then
            ErrorProvider1.SetError(txtnombreclas, "ingrese solo letras")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtnombreau_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnombreau.KeyUp
        txtnombreau.MaxLength = 50
        If IsNumeric(txtnombreau.Text) And txtnombreau.Text <> "" Then
            ErrorProvider1.SetError(txtnombreau, "ingrese solo letras")
            error10 = 1
        Else
            error10 = 0
        End If

    End Sub

    Private Sub txtpais_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpais.KeyUp
        txtpais.MaxLength = 20
        If IsNumeric(txtpais.Text) And txtpais.Text <> "" Then
            ErrorProvider1.SetError(txtpais, "ingrese solo letras")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub txtpais_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpais.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringresoedi = 1 Then
            If txtpais.Text = "" Then
                ErrorProvider1.SetError(txtpais, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtpais, "")
            End If
        Else
            ErrorProvider1.SetError(txtpais, "")
        End If
    End Sub

    Private Sub txtnombreau_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombreau.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringresoau = 1 Then
            If txtnombreau.Text = "" Then
                ErrorProvider1.SetError(txtnombreau, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtnombreau, "")
            End If
        Else
            ErrorProvider1.SetError(txtnombreau, "")
        End If
    End Sub

    Private Sub txtnombreclas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombreclas.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringresoclas = 1 Then
            If txtnombreclas.Text = "" Then
                ErrorProvider1.SetError(txtnombreclas, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtnombreclas, "")
            End If
        Else
            ErrorProvider1.SetError(txtnombreclas, "")
        End If
    End Sub

    Private Sub txtnombree_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombree.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringresoedi = 1 Then
            If txtnombree.Text = "" Then
                ErrorProvider1.SetError(txtnombree, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtnombree, "")
            End If
        Else
            ErrorProvider1.SetError(txtnombree, "")
        End If
    End Sub

    Private Sub txtpaisau_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpaisau.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringresoau = 1 Then
            If txtpaisau.Text = "" Then
                ErrorProvider1.SetError(txtpaisau, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtpaisau, "")
            End If
        Else
            ErrorProvider1.SetError(txtpaisau, "")
        End If
    End Sub

    Private Sub txtcasa_editorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcasa_editorial.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtcasa_editorial.Text = "" Then
                ErrorProvider1.SetError(txtcasa_editorial, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtcasa_editorial, "")
            End If
        Else
            ErrorProvider1.SetError(txtcasa_editorial, "")
        End If
    End Sub

    Private Sub txtubicacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtubicacion.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txtubicacion.Text = "" Then
                ErrorProvider1.SetError(txtubicacion, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtubicacion, "")
            End If
        Else
            ErrorProvider1.SetError(txtubicacion, "")
        End If
    End Sub

    Private Sub txtubicacion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtubicacion.KeyUp
        txtubicacion.MaxLength = 50
        If IsNumeric(txtubicacion.Text) And txtubicacion.Text <> "" Then
            ErrorProvider1.SetError(txtubicacion, "ingrese solo numeros")
            error10 = 1
        Else
            error10 = 0
        End If
    End Sub

    Private Sub cmbsala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsala.SelectedIndexChanged
        Select Case cmbsala.SelectedIndex
            Case 0
                ensala = 0
            Case 1
                ensala = 1
        End Select
    End Sub
End Class
