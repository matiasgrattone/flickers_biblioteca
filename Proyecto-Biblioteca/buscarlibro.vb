Imports System.Data
Imports System.Data.OleDb
Public Class buscarlibro
    Private Sub dgvlibros_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvlibros.MouseClick
        Try
            '///El usuario selecciona una fila de datos en el DataGrid y estos son copiados a un Panel///'
            'Permite al usuario una mejor visualizacion de los datos del libro que busca'
            Consulta = "SELECT volumen as Volumen, observaciones as Observaciones FROM libro where cod_libro = '" & dgvlibros.Item(0, dgvlibros.CurrentRow.Index).Value & "'"
            consultar()
            dgvdatos2.DataSource = Tabla
            volumen_label.Text = dgvdatos2.Item(0, dgvdatos2.CurrentRow.Index).Value
            observaciones_label.Text = dgvdatos2.Item(1, dgvdatos2.CurrentRow.Index).Value

            cod_libro_label.Text = dgvlibros.Item(0, dgvlibros.CurrentRow.Index).Value
            titulo_label.Text = dgvlibros.Item(1, dgvlibros.CurrentRow.Index).Value
            autor_label.Text = dgvlibros.Item(2, dgvlibros.CurrentRow.Index).Value
            editorial_label.Text = dgvlibros.Item(3, dgvlibros.CurrentRow.Index).Value
            fecha_label.Text = dgvlibros.Item(4, dgvlibros.CurrentRow.Index).Value
            origen_label.Text = dgvlibros.Item(5, dgvlibros.CurrentRow.Index).Value
            estado_label.Text = dgvlibros.Item(6, dgvlibros.CurrentRow.Index).Value
        Catch ex As Exception

        End Try




    End Sub
    Public estado As Integer
    Private Sub buscarlibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Invocamos al modulo para conectar el programa con la base de datos llamada Libros, y luego lo mostramos en el DataGrid'
        Try
            Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial;"
            consultar()
            dgvlibros.DataSource = Tabla
            dgvlibros.Columns(0).Width = 45
            dgvlibros.Columns(1).Width = 100
            dgvlibros.Columns(2).Width = 100
            dgvlibros.Columns(3).Width = 100
            dgvlibros.Columns(4).Width = 52
            dgvlibros.Columns(5).Width = 100
            dgvlibros.Columns(6).Width = 100

            dgvlibros.Columns(4).HeaderText = "Año"
            dgvlibros.Columns(3).HeaderText = "Nombre Editorial"
            dgvlibros.Columns(2).HeaderText = "Nombre Autor"
            dgvlibros.Columns(0).HeaderText = "Nº de Inventario"


            cmbestado.SelectedIndex = 0
            cmbdatos.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'Alinear celdas en el datagridview1'
        Dim z As Integer
        z = dgvlibros.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid, luego se resta 1 ya que empieza desde 0'
        For x = 0 To z 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
            dgvlibros.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        dgvlibros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
        dgvlibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'

       



    End Sub
    Private Sub cmbestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado.SelectedIndexChanged

        Select Case cmbestado.SelectedItem
            Case "ocupado"
                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '1'"
                consultar()
                dgvlibros.DataSource = Tabla

            Case "disponible"
                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '0'"
                consultar()
                dgvlibros.DataSource = Tabla

            Case "reservado"
                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '2'"
                consultar()
                dgvlibros.DataSource = Tabla

            Case "descontinuado"
                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '3'"
                consultar()
                dgvlibros.DataSource = Tabla
        End Select



    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        'Consulta Update Para la Tabla Libros en la Base'
        'Realiza la consulta, se actualizan los datos por los que el usuario indica y al momento el Datagrid se actualiza
        Consulta = "UPDATE libro SET titulo=('" + titulo_txt.Text + "'), volumen=('" + volumen_txt.Text + "'), anio=('" + anio_txt.Text + "'), origen=('" + origen_txt.Text + "'), observaciones=('" + observaciones_txt.Text + "') WHERE cod_libro=('" + cod_libro_txt.Text + "')"
        consultar()

        Select Case cmbupdate.SelectedItem
            Case "disponible"
                Consulta = "UPDATE libro set estado= 0 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '" + cmbestado.SelectedItem + "'"
                consultar()
                dgvlibros.DataSource = Tabla

            Case "ocupado"
                Consulta = "UPDATE libro set estado= 1 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '" + cmbestado.SelectedItem + "'"
                consultar()
                dgvlibros.DataSource = Tabla

            Case "reservado"
                Consulta = "UPDATE libro set estado= 2 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '" + cmbestado.SelectedItem + "'"
                consultar()
                dgvlibros.DataSource = Tabla

            Case "descontinuado"
                Consulta = "UPDATE libro set estado= 3 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado like '" + cmbestado.SelectedItem + "'"
                consultar()
                dgvlibros.DataSource = Tabla
        End Select

        Pactualizar.SendToBack()
        'estado_txt.SendToBack()
        cmbupdate.BringToFront()

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
        'estado_txt.Text = estado_label.Text
        volumen_txt.Text = volumen_label.Text
        observaciones_txt.Text = observaciones_label.Text


        'Permite seleccionar el estado predeterminado del combobox al momento de modificar los datos'
        '1-disponible, 2-descontinuado, 3-ocupado, 4-reservado'
        For Each row In dgvlibros.Rows
            If dgvlibros.Item(6, dgvlibros.CurrentRow.Index).Value = 0 Then
                cmbupdate.SelectedIndex = 0
            ElseIf dgvlibros.Item(6, dgvlibros.CurrentRow.Index).Value = 1 Then
                cmbupdate.SelectedIndex = 1
            ElseIf dgvlibros.Item(6, dgvlibros.CurrentRow.Index).Value = 2 Then
                cmbupdate.SelectedIndex = 2
            ElseIf dgvlibros.Item(6, dgvlibros.CurrentRow.Index).Value = 3 Then
                cmbupdate.SelectedIndex = 3
            End If


            'ElseIf estado_label.Text = "descontinuado" Then
            'cmbupdate.SelectedIndex = 1
            'estado = 1
            'ElseIf estado_label.Text = "ocupado" Then
            'estado = 2
            'cmbupdate.SendToBack()
            ''estado_txt.BringToFront()
            'ElseIf estado_label.Text = "reservado" Then
            'estado = 3
            'cmbupdate.SendToBack()
            ''estado_txt.BringToFront()
            'End If
        Next


        'Envia el primer panel al fondo, mostrando el que contiene la consulta update'
        Pmostrar.SendToBack()


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
        'estado_txt.SendToBack()
        cmbupdate.BringToFront()
        Pactualizar.SendToBack()

    End Sub
    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged

        'Consultas usando Case para la busqueda mediante un textbox relacionado a un combobox'

        Select Case cmbdatos.SelectedItem

            Case "Autor"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '2'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '3'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select

            Case "Editorial"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '2'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '3'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select

            Case "Año"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '2'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '3'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select

            Case "Titulo"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '2'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '3'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select

            Case "Codigo"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '2'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '3'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select

            Case "Origen"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '2'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '3'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select
        End Select
    End Sub

End Class
