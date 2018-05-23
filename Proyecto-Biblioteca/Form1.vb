Public Class Form1
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO ///////////////////////
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ingresar_boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar_boton.Click

        '/// Permite ingresar un nuevo dato a la tabla libros ///'

        Consulta = "INSERT INTO libros(cod_libro,autor,titulo,volumen,casa_editorial,fecha,origen,observaciones,estado) VALUES('" + cod_libro.Text + "','" + autor.Text + "','" + titulo.Text + "','" + volumen.Text + "','" + casa_editorial.Text + "','" + fecha.Text + "','" + origen.Text + "','" + observaciones.Text + "','" + estado.Text + "')"
        consultar()

        '///////////////////////////////////////////
        '//// Muestra Los Datos en el DataGrid//////
        '///////////////////////////////////////////

        Consulta = "select * from libros;"
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Carga datos dentro de la tabla Libros en la base de datos en MySql y los muestra en la datagrid
        Consulta = "SELECT cod_libro as Libro,autor as Autor, titulo as Titulo, casa_editorial as Editorial,fecha as Fecha,origen as Origen,estado as Estado,observaciones as Observaciones, volumen as Volumen from libros "
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(7).Width = 140

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Boton que al dar click sobre el actualiza el textbox autor a "Autor Desconocido"
        autor.Text = "Autor Desconocido"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Boton que al dar click sobre el actualiza el textbox volumen a S/V
        volumen.Text = "S/V"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Boton que al dar click sobre el actualiza el textbox casa_Editorial a S/E
        casa_editorial.Text = "S/E"

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Boton que al dar click sobre el actualiza el textbox origen a S/O
        origen.Text = "S/O"
    End Sub

    Private Sub autor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub casa_editorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles casa_editorial.TextChanged

    End Sub
End Class
