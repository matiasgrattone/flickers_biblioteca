Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO /////////////////////// Esto no se esta utiizando
    Dim cod As Integer = 0
    Dim activadoE As Integer = 0
    Dim activadoA As Integer = 0
    Dim dvgeditorialW As Integer
    Dim dvgautorW As Integer
    Dim bandera As Integer
    Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click
        If bandera = 1 Then
            Try
                'El if se encarga de comprobar que los campos de cod_libro y titulo no se encuentren vacios.
                'En caso de esto no permitira avanzar la consulta y se lanzara un mensaje de error.
                If Trim(txtcod_libro.Text) = "" Or (txttitulo.Text) = "" Then
                    MsgBox(" Ha ocurrido un error. Compruebe que los campos marcados por un * se hallen completos.")

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
                        MsgBox("este codigo ya existe en el inventario")
                        cod = 0
                    Else

                        Try
                            '/// Permite ingresar un nuevo dato a la tabla libros ///'
                            Consulta = "INSERT INTO libro VALUES('" + txtcod_libro.Text + "',concat(upper(left('" + txttitulo.Text + "',1)),lower(substr('" + txttitulo.Text + "',2))),'" + txtautoroculto.Text + "','" + txteditorialoculto.Text + "','" + txtvolumen.Text + "','" + txtanio.Text + " ',concat(upper(left('" + txtorigen.Text + "',1)),lower(substr('" + txtorigen.Text + "',2))),concat(upper(left('" + txtobservaciones.Text + "',1)),lower(substr('" + txtobservaciones.Text + "',2))), '0')"
                            consultar()

                            '///////////////////////////////////////////
                            '//// Muestra Los Datos en el DataGrid//////
                            '///////////////////////////////////////////
                            Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo' , autor.nombre, libro.volumen as 'Volumen' ,editorial.nombre, libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
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
                            '/////////////////////////////////////////////////////
                            MsgBox("se ha ingresado el libro en el inventario")
                        Catch ex As Exception
                            MsgBox(ex)
                        End Try

                    End If
                End If

            Catch ex As Exception
                MsgBox("Base de datos no disponible")
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
                    Pautor.Visible = True
                    Consulta = "SELECT * FROM autor"
                    consultar()
                    dgvautor.DataSource = Tabla
                    dgvautor.Columns(0).Visible = False
                    dgvautor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Autor")
                End Try
                'El boton se muestra
                btningeditorial.Visible = True
                'El boton se esconde
                btncancelar.Visible = False
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
                    Peditorial.Visible = True
                    Consulta = "SELECT * FROM editorial"
                    consultar()
                    dgveditorial.DataSource = Tabla
                    dgveditorial.Columns(0).Visible = False
                    dgveditorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Editorial")
                End Try

                'El Boton se muestra
                btningeditorial.Visible = True
                'El boton se esconde
                btncancelar.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If

    End Sub

    Private Sub ingresolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pautor.Visible = False
        Peditorial.Visible = False
        'Comprobacion'
        Consulta = "select * from usuarios"
        consultar()
        Try
            dgvcomprobar.DataSource = Tabla
            If dgvcomprobar.Item(0, dgvcomprobar.CurrentRow.Index).Value <> 0 Then
                bandera = 1
            Else
                bandera = 0
            End If
        Catch ex1 As Exception
            MsgBox("Base de datos no disponible")
        End Try

        
        If bandera = 1 Then

            'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid
            Try
                
                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo' , autor.nombre, libro.volumen as 'Volumen' ,editorial.nombre, libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
                consultar()
                dgvlibro.DataSource = Tabla
                dgvlibro.Columns(4).HeaderText = "Nombre Editorial"
                dgvlibro.Columns(2).HeaderText = "Nombre Autor"
                dgvlibro.Columns(0).HeaderText = "Nº de Inventario"
                dgvlibro.Columns(5).HeaderText = "Año"
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try

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

        Else

        End If
    End Sub

    Private Sub btnnwautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwautor.Click
        If bandera = 1 Then
            Try
                If Trim(txtnombreau.Text) = "" Or (txtpaisau.Text) = "" Then
                    MsgBox(" Ha ocurrido un error. Uno de los campos necesarios se encuentra vacio")
                Else
                    'Ingresa un nuevo autor a la Base de Datos.
                    Consulta = "INSERT INTO autor (nombre, nacionalidad) values (concat(upper(left('" + txtnombreau.Text + "',1)),lower(substr('" + txtnombreau.Text + "',2))), concat(upper(left('" + txtpaisau.Text + "',1)),lower(substr('" + txtpaisau.Text + "',2))))"
                    consultar()

                    Consulta = "SELECT * FROM autor"
                    consultar()
                    dgvautor.DataSource = Tabla

                    'El boton se esconde
                    btncancelar2.Visible = False
                    'El boton se muestra
                    btningautor.Visible = True

                    'Limpia los campos de texto'
                    txtnombreau.Clear()
                    txtpaisau.Clear()

                    Timer2.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub btningautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningautor.Click
        If bandera = 1 Then
            Try
                'El boton se esconde
                btningautor.Visible = False
                'El boton se muestra
                btncancelar2.Visible = True

                'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse un nuevo autor.
                Timer2.Enabled = True
            Catch ex As Exception
                MsgBox("No es posible realizar esta accion")
            End Try
        Else
            MsgBox("Esta accion es imposible de realizar actualmente")
        End If
    End Sub
    Private Sub btncancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar2.Click

        'El boton se esconde.
        btncancelar2.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'Limpia los campos de texto'
        txtnombreau.Clear()
        txtpaisau.Clear()

        'El Datagrid se redimensiona y a su vez el panel se mueve a su posicion inicial.
        Timer2.Enabled = True

    End Sub

    Private Sub btningeditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningeditorial.Click
        'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse una nueva editorial.
        Timer1.Enabled = True
        'El boton se esconde
        btningeditorial.Visible = False
        'El boton se muestra
        btncancelar.Visible = True

    End Sub
    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        'El panel editorial se oculta.
        Peditorial.Visible = False

        'El boton se esconde
        btncancelar.Visible = False
        'El boton se muestra
        btningeditorial.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
        Timer1.Enabled = True
    End Sub

    Private Sub dgvautor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvautor.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre del autor.
        txtautor.Text = dgvautor.Item(1, dgvautor.CurrentRow.Index).Value
        txtautoroculto.Text = dgvautor.Item(0, dgvautor.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Pautor.Visible = False
    End Sub

    Private Sub dgveditorial_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgveditorial.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre de la editorial.
        txtcasa_editorial.Text = dgveditorial.Item(1, dgveditorial.CurrentRow.Index).Value
        txteditorialoculto.Text = dgveditorial.Item(0, dgveditorial.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Peditorial.Visible = False
    End Sub
    Private Sub btnvolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        'El panel autor se oculta.
        Pautor.Visible = False

        'El boton se esconde
        btncancelar2.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'El contenido de los textbox es eliminado.
        txtnombreau.Clear()
        txtpaisau.Clear()

        'El datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
        Timer2.Enabled = True
    End Sub
    Private Sub btnnweditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnweditorial.Click

        If Trim(txtnombree.Text) = "" Or (txtpais.Text) = "" Or (txtanioe.Text) = "" Then
            MsgBox(" Ha ocurrido un error. Uno de los campos necesarios se encuentra vacio")

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
            btncancelar.Visible = False
            btningeditorial.Visible = True

            'Limpia los campos de texto'
            txtnombree.Clear()
            txtpais.Clear()
            txtanioe.Clear()

            Timer1.Enabled = True

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
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click

        'El boton se esconde
        btncancelar.Visible = False
        'El boton se muestra
        btningeditorial.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion inicial.
        Timer1.Enabled = True

    End Sub

    Private Sub txtbuscareditorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscareditorial.TextChanged
        'Busqueda de editoriales
        Consulta = "select * from editorial where nombre like '" & txtbuscareditorial.Text & "%'"
        consultar()
        dgveditorial.DataSource = Tabla
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Select Case activadoE
            Case 0
                If Paneleditorial.Left > 245 Then
                    Paneleditorial.Left -= 5

                Else
                    dgveditorial.Width = dgveditorial.Width - Paneleditorial.Width
                    activadoE = 1
                    Timer1.Enabled = False
                End If
            Case 1
                If Paneleditorial.Left < 429 Then
                    Paneleditorial.Left += 5

                Else
                    dgveditorial.Width = dvgeditorialW
                    activadoE = 0
                    Timer1.Enabled = False
                End If
        End Select



    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Select Case activadoE
            Case 0
                If panelautor.Left > 255 Then
                    panelautor.Left -= 5

                Else
                    dgvautor.Width = dgvautor.Width - panelautor.Width
                    activadoE = 1
                    Timer2.Enabled = False
                End If
            Case 1
                If panelautor.Left < 419 Then
                    panelautor.Left += 5

                Else
                    dgvautor.Width = dvgautorW
                    activadoE = 0
                    Timer2.Enabled = False
                End If
        End Select
    End Sub

    Private Sub Peditorial_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Peditorial.Paint

    End Sub
End Class
