Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO ///////////////////////
    Dim cod As Integer = 0
    Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click


   




        If Trim(cod_libro.Text) = "" Or (titulo.Text) = "" Then
            MsgBox(" Ha ocurrido un error. Compruebe que los campos marcados por un * se hallen completos.")

        Else

            For Each Row As DataGridViewRow In DataGridView1.Rows
                If Row.Cells("Codigo de Libro").Value = cod_libro.Text Then
                    cod = 1
                End If
            Next

            If cod = 1 Then
                MsgBox("este codigo ya existe en el inventario")
                cod = 0
            Else

                Try
                    '/// Permite ingresar un nuevo dato a la tabla libros ///'
                    Consulta = "INSERT INTO libro VALUES('" + cod_libro.Text + "','" + titulo.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + volumen.Text + "','" + fecha.Text + " ','" + origen.Text + "','" + observaciones.Text + "', 'disponible')"
                    consultar()
                    '///////////////////////////////////////////
                    '//// Muestra Los Datos en el DataGrid//////
                    '///////////////////////////////////////////
                    Consulta = "SELECT libro.cod_libro as 'Codigo de Libro' , libro.titulo as 'Titulo' , autor.nombre as 'Autor' , libro.volumen as 'Volumen' ,editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
                    consultar()
                    DataGridView1.DataSource = Tabla
                    '/////////////////////////////////////////////////// 
                    '/// Al haberse ingresado un nuevo dato, limpia los textbox del formulario ///
                    cod_libro.Clear()
                    autor.Clear()
                    titulo.Clear()
                    volumen.Clear()
                    casa_editorial.Clear()
                    fecha.Clear()
                    origen.Clear()
                    observaciones.Clear()
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
        Panel4.Visible = True
        Consulta = "SELECT * FROM autor"
        consultar()
        DataGridView2.DataSource = Tabla
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'beditorial.Show()
        Panel2.Visible = True
        Consulta = "SELECT * FROM editorial"
        consultar()
        DataGridView3.DataSource = Tabla
    End Sub

    Private Sub ingresolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid
        Panel3.Visible = False
        Panel4.Visible = False
        Try
            panelautor.Visible = False
            Panel2.Visible = False
            Consulta = "SELECT libro.cod_libro as 'Codigo de Libro' , libro.titulo as 'Titulo' , autor.nombre as 'Autor' , libro.volumen as 'Volumen' ,editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen', libro.observaciones as 'Observaciones', libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
            consultar()
            DataGridView1.DataSource = Tabla
            DataGridView1.Columns(4).HeaderText = "Nombre Editorial"
            DataGridView1.Columns(2).HeaderText = "Nombre Autor"
            DataGridView1.Columns(0).HeaderText = "Nº de Inventario"
            DataGridView1.Columns(5).HeaderText = "Año"

        Catch ex As Exception

        End Try

        'Alinear celdas en el datagridview1'
        Dim z As Integer
        z = DataGridView1.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid, luego se resta 1 ya que empieza desde 0'
        For x = 0 To z 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
            DataGridView1.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'

    End Sub
    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
      
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel3.Visible = False
        Button3.BringToFront()
    End Sub

    Private Sub nwautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nwautor.Click
        Consulta = "INSERT INTO autor (nombre, nacionalidad) values ('" + aunombre.Text + "', '" + aupais.Text + "')"
        consultar()

        Consulta = "SELECT * FROM autor"
        consultar()
        DataGridView2.DataSource = Tabla
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Consulta = "INSERT INTO editorial (nombre, pais, anio) values ('" + nombree.Text + "', '" + pais.Text + "','" + anioe.Text + "')"
        consultar()

        Consulta = "SELECT * FROM editorial"
        consultar()
        DataGridView3.DataSource = Tabla
        Panel3.Visible = False
        Button4.SendToBack()
    End Sub

    Private Sub DataGridView2_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
    
    End Sub

    Private Sub auvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auvolver.Click
        panelautor.Visible = False
        panelautor.SendToBack()
        auvolver.SendToBack()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel3.Visible = True
        Panel3.BringToFront()
        If Panel3.Visible = True Then
            Button3.SendToBack()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel4.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel2.Visible = False
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        autor.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        TextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Panel4.Visible = False
    End Sub

    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        casa_editorial.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        TextBox2.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Panel2.Visible = False
    End Sub
End Class
