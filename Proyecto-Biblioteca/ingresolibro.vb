Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO ///////////////////////
    Dim cod As Integer = 0
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
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'bautor.Show()
        Pautor.Visible = True
        Consulta = "SELECT * FROM autor"
        consultar()
        dgvautor.DataSource = Tabla
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'beditorial.Show()
        Peditorial.Visible = True
        Consulta = "SELECT * FROM editorial"
        consultar()
        dgveditorial.DataSource = Tabla
    End Sub

    Private Sub ingresolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid
        Paneleditorial.Visible = False
        Pautor.Visible = False
        Try
            panelautor.Visible = False
            Peditorial.Visible = False
            Consulta = "SELECT libro.cod_libro as 'Codigo de Libro' , libro.titulo as 'Titulo' , autor.nombre as 'Autor' , libro.volumen as 'Volumen' ,editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
            consultar()
            dgvlibro.DataSource = Tabla
            dgvlibro.Columns(4).HeaderText = "Nombre Editorial"
            dgvlibro.Columns(2).HeaderText = "Nombre Autor"
            dgvlibro.Columns(0).HeaderText = "Nº de Inventario"
            dgvlibro.Columns(5).HeaderText = "Año"

        Catch ex As Exception

        End Try

        'Alinear celdas en el datagridview1'
        Dim z As Integer
        z = dgvlibro.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid, luego se resta 1 ya que empieza desde 0'
        For x = 0 To z 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
            dgvlibro.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        dgvlibro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
        dgvlibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'

    End Sub
    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgveditorial.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Paneleditorial.Visible = False
        ingeditorial.BringToFront()
    End Sub

    Private Sub nwautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwautor.Click
        Consulta = "INSERT INTO autor (nombre, nacionalidad) values ('" + aunombre.Text + "', '" + aupais.Text + "')"
        consultar()

        Consulta = "SELECT * FROM autor"
        consultar()
        dgvautor.DataSource = Tabla
        panelautor.Visible = False
        auvolver.SendToBack()

    End Sub

    Private Sub ingautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingautor.Click
        panelautor.Visible = True
        panelautor.BringToFront()
        If panelautor.Visible = True Then
            ingautor.SendToBack()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnweditorial.Click
        Consulta = "INSERT INTO editorial (nombre, pais, anio) values ('" + nombree.Text + "', '" + pais.Text + "','" + anioe.Text + "')"
        consultar()

        Consulta = "SELECT * FROM editorial"
        consultar()
        dgveditorial.DataSource = Tabla
        Paneleditorial.Visible = False
        Button4.SendToBack()
    End Sub

    Private Sub DataGridView2_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvautor.CellContentClick

    End Sub

    Private Sub auvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auvolver.Click
        panelautor.Visible = False
        panelautor.SendToBack()
        auvolver.SendToBack()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingeditorial.Click
        Paneleditorial.Visible = True
        Paneleditorial.BringToFront()
        If Paneleditorial.Visible = True Then
            ingeditorial.SendToBack()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        Pautor.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Peditorial.Visible = False
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

End Class

