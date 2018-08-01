﻿Imports System.Data
Imports System.Data.OleDb
Public Class buscarlibro
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            '///El usuario selecciona una fila de datos en el DataGrid y estos son copiados a un Panel///'
            'Permite al usuario una mejor visualizacion de los datos del libro que busca'
            Consulta = "SELECT volumen as Volumen, observaciones as Observaciones FROM libro where cod_libro = '" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
            consultar()
            DataGridView2.DataSource = Tabla
            volumen_label.Text = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value
            observaciones_label.Text = DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value

            cod_libro_label.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
            titulo_label.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            autor_label.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            editorial_label.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
            fecha_label.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
            origen_label.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
            estado_label.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        Catch ex As Exception

        End Try




    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        'Consultas usando Case para la busqueda mediante un textbox relacionado a un combobox'

        Select Case ComboBox1.SelectedItem

            Case "Autor"
                Select Case ComboBox2.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & TextBox1.Text & "%' and libro.estado like 'ocupado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & TextBox1.Text & "%' and libro.estado like 'disponible'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & TextBox1.Text & "%' and libro.estado like 'descontinuado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                End Select

            Case "Editorial"
                Select Case ComboBox2.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & TextBox1.Text & "%' and libro.estado like 'ocupado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & TextBox1.Text & "%' and libro.estado like 'disponible'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & TextBox1.Text & "%' and libro.estado like 'descontinuado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                End Select

            Case "Año"
                Select Case ComboBox2.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & TextBox1.Text & "%' and libro.estado like 'ocupado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & TextBox1.Text & "%' and libro.estado like 'disponible'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & TextBox1.Text & "%' and libro.estado like 'descontinuado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                End Select

            Case "Titulo"
                Select Case ComboBox2.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & TextBox1.Text & "%' and libro.estado like 'ocupado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & TextBox1.Text & "%' and libro.estado like 'disponible'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & TextBox1.Text & "%' and libro.estado like 'descontinuado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                End Select

            Case "Codigo"
                Select Case ComboBox2.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & TextBox1.Text & "%' and libro.estado like 'ocupado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & TextBox1.Text & "%' and libro.estado like 'disponible'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & TextBox1.Text & "%' and libro.estado like 'descontinuado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                End Select

            Case "Origen"
                Select Case ComboBox2.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & TextBox1.Text & "%' and libro.estado like 'ocupado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & TextBox1.Text & "%' and libro.estado like 'disponible'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & TextBox1.Text & "%' and libro.estado like 'descontinuado'"
                        consultar()
                        DataGridView1.DataSource = Tabla
                End Select








        End Select



    End Sub


    Private Sub buscarlibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Invocamos al modulo para conectar el programa con la base de datos llamada Libros, y luego lo mostramos en el DataGrid'
        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 52
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(4).HeaderText = "Año"
        ComboBox2.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        'Alinear celdas en el datagridview1'
        Dim z As Integer
        z = DataGridView1.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid, luego se resta 1 ya que empieza desde 0'
        For x = 0 To z 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
            DataGridView1.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'


    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        Select Case ComboBox2.SelectedItem

            Case "ocupado"

                Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like 'ocupado'"
                consultar()
                DataGridView1.DataSource = Tabla

            Case "disponible"

                Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like 'disponible'"
                consultar()
                DataGridView1.DataSource = Tabla

            Case "descontinuado"

                Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like 'descontinuado'"
                consultar()
                DataGridView1.DataSource = Tabla

            Case "reservado"

                Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like 'reservado'"
                consultar()
                DataGridView1.DataSource = Tabla
        End Select



    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        'Consulta Update Para la Tabla Libros en la Base'
        'Realiza la consulta, se actualizan los datos por los que el usuario indica y al momento el Datagrid se actualiza'
        Consulta = "UPDATE libro SET titulo=('" + titulo_txt.Text + "'), volumen=('" + volumen_txt.Text + "'), anio=('" + anio_txt.Text + "'), origen=('" + origen_txt.Text + "'), observaciones=('" + observaciones_txt.Text + "') WHERE cod_libro=('" + cod_libro_txt.Text + "')"
        consultar()
        Panel3.SendToBack()


        Consulta = "SELECT libro.cod_libro as 'Codigo de Libro', libro.titulo as 'Titulo', autor.nombre as 'Autor' , editorial.nombre as 'Editorial', libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click

        'Los datos que el usuario selecciono del DataGrid y que luego fueron mostrados en el Panel'
        'Son copiados a un segundo panel donde luego podran ser modificados'
        cod_libro_txt.Text = cod_libro_label.Text
        titulo_txt.Text = titulo_label.Text
        autor_txt.Text = autor_label.Text
        editorial_txt.Text = editorial_label.Text
        anio_txt.Text = fecha_label.Text
        origen_txt.Text = origen_label.Text
        estado_txt.Text = estado_label.Text

        volumen_txt.Text = volumen_label.Text
        observaciones_txt.Text = observaciones_label.Text


        'Envia el primer panel al fondo, mostrando el que contiene la consulta update'
        Panel1.SendToBack()


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click

        cod_libro_txt.Clear()
        autor_txt.Clear()
        titulo_txt.Clear()
        volumen_txt.Clear()
        editorial_txt.Clear()
        anio_txt.Clear()
        origen_txt.Clear()
        observaciones_txt.Clear()
        Panel3.SendToBack()

    End Sub
End Class
