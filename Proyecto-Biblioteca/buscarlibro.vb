Imports System.Data
Imports System.Data.OleDb
Public Class buscarlibro

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Al dar click al boton, el formulario se cierra y se abre el menu'
        Me.Close()
        Form3.Show()


    End Sub


    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick

        '///El usuario selecciona una fila de datos en el DataGrid y estos son copiados a un Panel///'
        'Permite al usuario una mejor visualizacion de los datos del libro que busca'

        cod_libro_label.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        autor_label.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        titulo_label.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        editorial_label.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        fecha_label.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        origen_label.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        estado_label.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value

        observaciones_label.Text = DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value
        volumen_label.Text = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        'Consultas usando Case para la busqueda mediante un textbox relacionado a un combobox'

        Select Case ComboBox1.SelectedItem

            Case "Autor"
                Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & TextBox1.Text & "%'"
                consultar()
                DataGridView1.DataSource = Tabla
            Case "Editorial"
                Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & TextBox1.Text & "%'"
                consultar()
                DataGridView1.DataSource = Tabla
            Case "Fecha"
                Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.fecha like '" & TextBox1.Text & "%'"
                consultar()
                DataGridView1.DataSource = Tabla
            Case "Titulo"
                Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & TextBox1.Text & "%'"
                consultar()
                DataGridView1.DataSource = Tabla
            Case "Codigo"
                Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & TextBox1.Text & "%'"
                consultar()
                DataGridView1.DataSource = Tabla
            Case "Origen"
                Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & TextBox1.Text & "%'"
                consultar()
                DataGridView1.DataSource = Tabla

        End Select



    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Los datos que el usuario selecciono del DataGrid y que luego fueron mostrados en el Panel'
        'Son copiados a un segundo panel donde luego podran ser modificados'
        cod_libro_label2.Text = cod_libro_label.Text
        autor_txt.Text = autor_label.Text
        titulo_txt.Text = titulo_label.Text
        volumen_txt.Text = volumen_label.Text
        editorial_txt.Text = editorial_label.Text
        fecha_txt.Text = fecha_label.Text
        origen_txt.Text = origen_label.Text
        observaciones_txt.Text = observaciones_label.Text
        estado_txt.Text = estado_label.Text

        'Envia el primer panel al fondo, mostrando el que contiene la consulta update'
        Panel1.SendToBack()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Consulta Update Para la Tabla Libros en la Base'
        'Realiza la consulta, se actualizan los datos por los que el usuario indica y al momento el Datagrid se actualiza'
        Consulta = "UPDATE libros SET autor = ('" + autor_txt.Text + "') , titulo = ('" + titulo_txt.Text + "') , volumen = ('" + volumen_txt.Text + "'), casa_editorial = ('" + editorial_txt.Text + "') , fecha = ('" + fecha_txt.Text + "') , origen = ('" + origen_txt.Text + "') , observaciones = ('" + observaciones_txt.Text + "') , estado = ('" + estado_txt.Text + "') WHERE cod_libro = ('" + cod_libro_label2.Text + "')"
        consultar()
        Panel3.SendToBack()

        Consulta = "SELECT cod_libro as Codigo,autor as Autor, titulo as Titulo, casa_editorial as Editorial,fecha as Fecha,origen as Origen,estado as Estado FROM LIBROS"
        consultar()
        DataGridView1.DataSource = Tabla
        autor_label.Text = ""

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub cod_libro_label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cod_libro_label2.Click

    End Sub

    Private Sub buscarlibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Invocamos al modulo para conectar el programa con la base de datos llamada Libros, y luego lo mostramos en el DataGrid'
        Consulta = "SELECT libro.cod_libro , libro.titulo , autor.nombre , editorial.nombre, libro.fecha , libro.origen , libro.estado from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
        consultar()
        DataGridView1.DataSource = Tabla


        Consulta = "SELECT volumen as Volumen, observaciones as Observaciones FROM libro"
        consultar()
        DataGridView2.DataSource = Tabla
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class