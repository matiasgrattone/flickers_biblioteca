Public Class ingresolibro
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO ///////////////////////
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click

        '/// Permite ingresar un nuevo dato a la tabla libros ///'

        Consulta = "INSERT INTO libro VALUES('" + cod_libro.Text + "','" + titulo.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "','" + volumen.Text + "','" + fecha.Text + "','" + origen.Text + "','" + observaciones.Text + "','" + estado.Text + "')"
        consultar()
        '///////////////////////////////////////////
        '//// Muestra Los Datos en el DataGrid//////
        '///////////////////////////////////////////

        Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , libro.volumen ,editorial.nombre, libro.fecha , libro.origen , libro.observaciones , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
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
        estado.Clear()

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


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Boton que al dar click sobre el actualiza el textbox volumen a S/V
        volumen.Text = "S/V"
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Boton que al dar click sobre el actualiza el textbox origen a S/O
        origen.Text = "S/O"
    End Sub

    Private Sub autor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub casa_editorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles casa_editorial.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        bautor.Show()
        Consulta = "SELECT * FROM autor"
        consultar()
        bautor.DataGridView1.DataSource = Tabla
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        beditorial.Show()
        Consulta = "SELECT * FROM editorial"
        consultar()
        beditorial.DataGridView1.DataSource = Tabla
    End Sub

    Private Sub ingresolibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid
        Consulta = " SELECT libro.cod_libro , libro.titulo , autor.nombre , libro.volumen ,editorial.nombre, libro.fecha , libro.origen , libro.observaciones , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(4).HeaderText = "nombre editorial"
        DataGridView1.Columns(2).HeaderText = "nombre autor"
        DataGridView1.Columns(0).HeaderText = "nº libro"
        DataGridView1.Columns(5).HeaderText = "Año"
    End Sub
End Class
