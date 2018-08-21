Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO ///////////////////////
    Dim cod As Integer = 0
    Dim activadoE As Integer = 0
    Dim activadoA As Integer = 0
    Dim dvgeditorialW As Integer
    Dim dvgautorW As Integer

     Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click

        If Trim(txtcod_libro.Text) = "" Or (txttitulo.Text) = "" Then
            MsgBox(" Ha ocurrido un error. Compruebe que los campos marcados por un * se hallen completos.")

        Else

            For Each Row As DataGridViewRow In dgvlibro.Rows
                If Row.Cells("Codigo de Libro").Value = txtcod_libro.Text Then
                    cod = 1
                End If
            Next

            If cod = 1 Then
                MsgBox("este codigo ya existe en el inventario")
                cod = 0
            Else

                Try
                    '/// Permite ingresar un nuevo dato a la tabla libros ///'
                    Consulta = "INSERT INTO libro VALUES('" + txtcod_libro.Text + "','" + txttitulo.Text + "','" + txtautoroculto.Text + "','" + txteditorialoculto.Text + "','" + txtvolumen.Text + "','" + txtanio.Text + " ','" + txtorigen.Text + "','" + txtobservaciones.Text + "', 'disponible')"
                    consultar()
                    '///////////////////////////////////////////
                    '//// Muestra Los Datos en el DataGrid//////
                    '///////////////////////////////////////////
                    Consulta = "SELECT libro.cod_libro as 'Codigo de Libro' , libro.titulo as 'Titulo' , autor.nombre as 'Autor' , libro.volumen as 'Volumen' ,editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
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


    End Sub

    Private Sub btnselectautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectautor.Click
        'bautor.Show()
        Pautor.Visible = True
        Consulta = "SELECT * FROM autor"
        consultar()
        dgvautor.DataSource = Tabla
        dgvautor.Columns(0).Visible = False
        dgvautor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
    End Sub

    Private Sub btnselecteditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselecteditorial.Click
        'beditorial.Show()
        Peditorial.Visible = True
        Consulta = "SELECT * FROM editorial"
        consultar()
        dgveditorial.DataSource = Tabla
        dgveditorial.Columns(0).Visible = False
        dgveditorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
    End Sub

    Private Sub ingresolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid

        Try
            Pautor.Visible = False
            Peditorial.Visible = False
            Consulta = "SELECT libro.cod_libro as 'Codigo de Libro' , libro.titulo as 'Titulo' , autor.nombre as 'Autor' , libro.volumen as 'Volumen' ,editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
            consultar()
            dgvlibro.DataSource = Tabla
            dgvlibro.Columns(4).HeaderText = "Nombre Editorial"
            dgvlibro.Columns(2).HeaderText = "Nombre Autor"
            dgvlibro.Columns(0).HeaderText = "Nº de Inventario"
            dgvlibro.Columns(5).HeaderText = "Año"

        Catch ex As Exception
            MsgBox(ex.ToString)
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
    End Sub

    Private Sub btnnwautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwautor.Click
        Consulta = "INSERT INTO autor (nombre, nacionalidad) values ('" + txtnombreau.Text + "', '" + txtpaisau.Text + "')"
        consultar()

        Consulta = "SELECT * FROM autor"
        consultar()
        dgvautor.DataSource = Tabla
        btncancelar2.SendToBack()

        txtnombreau.Clear()
        txtpaisau.Clear()

    End Sub

    Private Sub btningautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningautor.Click

        btningautor.SendToBack()
        Timer2.Enabled = True
    End Sub
    Private Sub btncancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar2.Click

        btncancelar2.SendToBack()
        Timer2.Enabled = True
    End Sub

    Private Sub btningeditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningeditorial.Click

        Paneleditorial.BringToFront()
        Timer1.Enabled = True

        btningeditorial.SendToBack()

    End Sub
    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Peditorial.Visible = False
        btncancelar.SendToBack()
    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvautor.CellDoubleClick
        txtautor.Text = dgvlibro.Item(2, dgvlibro.CurrentRow.Index).Value
        txtautoroculto.Text = dgvlibro.Item(0, dgvlibro.CurrentRow.Index).Value
        Pautor.Visible = False
    End Sub

    Private Sub DataGridView3_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgveditorial.CellDoubleClick
        txtcasa_editorial.Text = dgvlibro.Item(1, dgvlibro.CurrentRow.Index).Value
        txteditorialoculto.Text = dgvlibro.Item(0, dgvlibro.CurrentRow.Index).Value
        Peditorial.Visible = False
    End Sub
    Private Sub btnvolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        Pautor.Visible = False
        btncancelar2.SendToBack()
    End Sub
    Private Sub btnnweditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnweditorial.Click
        Consulta = "INSERT INTO editorial (nombre, pais, anio) values ('" + txtnombree.Text + "', '" + txtpais.Text + "','" + txtanioe.Text + "')"
        consultar()

        Consulta = "SELECT * FROM editorial"
        consultar()
        dgveditorial.DataSource = Tabla
        btncancelar.SendToBack()

        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()
    End Sub
    Private Sub txtbuscarautor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarautor.TextChanged
        'Busuqeda de autor
        Consulta = "select * from autor where nombre like '" & txtbuscarautor.Text & "%'"
        consultar()
        dgvautor.DataSource = Tabla

    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        'Ocultar paneles y boton

        btncancelar.SendToBack()
        btningeditorial.BringToFront()
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
                If Paneleditorial.Left > 249 Then
                    Paneleditorial.Left -= 5

                Else
                    dgveditorial.Width = dgveditorial.Width - Paneleditorial.Width
                    activadoE = 1
                    Timer1.Enabled = False
                End If
            Case 1
                If Paneleditorial.Left < 434 Then
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
                If panelautor.Left > 251 Then
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
End Class
