Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO ///////////////////////
    Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click

        '/// Permite ingresar un nuevo dato a la tabla libros ///'
        Try
            Consulta = "INSERT INTO libro VALUES('" + cod_libro.Text + "','" + titulo.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + volumen.Text + "','" + fecha.Text + " ','" + origen.Text + "','" + observaciones.Text + "', 'disponible')"
            consultar()
        Catch ex As Exception
            MsgBox(ex)
        End Try

        '///////////////////////////////////////////
        '//// Muestra Los Datos en el DataGrid//////
        '///////////////////////////////////////////

        Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , libro.volumen ,editorial.nombre, libro.anio , libro.origen , libro.observaciones , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
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




    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Cerrar
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Maximizar

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'Minimizar
        Me.Hide()

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'bautor.Show()
        Panel1.Visible = True
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
        Try
            Panel1.Visible = False
            Panel2.Visible = False
            Consulta = " SELECT libro.cod_libro , libro.titulo , autor.nombre , libro.volumen ,editorial.nombre, libro.anio , libro.origen , libro.observaciones , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
            consultar()
            DataGridView1.DataSource = Tabla
            DataGridView1.Columns(4).HeaderText = "nombre editorial"
            DataGridView1.Columns(2).HeaderText = "nombre autor"
            DataGridView1.Columns(0).HeaderText = "nº libro"
            DataGridView1.Columns(5).HeaderText = "Año"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub autor_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autor_label.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        autor.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        TextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Panel1.Visible = False

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        casa_editorial.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        TextBox2.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Panel2.Visible = False
    End Sub
End Class
