Imports System.Data
Imports System.Data.OleDb
Public Class buscarlibro
    Dim bandera As Integer
    Public estado As Integer
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

    Private Sub buscarlibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            Try
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
                    'Alinear celdas en el datagridview1'
                    Dim z As Integer
                    z = dgvlibros.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid, luego se resta 1 ya que empieza desde 0'
                    For x = 0 To z 'El for recorre cada columna y las va configurando hasta llegar a la columna a'
                        dgvlibros.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Next
                    dgvlibros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Alinea las cabeceras de cada columena'
                    dgvlibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("Accion imposible de realizar, reintente")
                End Try
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            txtbusqueda.ReadOnly = True
            cmbestado.Enabled = False
            cmbdatos.Enabled = False
        End If






    End Sub
    Private Sub cmbestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado.SelectedIndexChanged
        If bandera = 1 Then
            Try
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
            Catch ex As Exception
                MsgBox("Accion imposible de realizar")
            End Try
        Else
            MsgBox("Base de datos no disponible")

        End If



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

                If cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 3"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 1"
                    consultar()
                    dgvlibros.DataSource = Tabla
                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 2"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If

            Case "ocupado"
                Consulta = "UPDATE libro set estado= 1 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 0"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 3"
                    consultar()
                    dgvlibros.DataSource = Tabla
                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 2"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If


            Case "reservado"
                Consulta = "UPDATE libro set estado= 2 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 0"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 1"
                    consultar()
                    dgvlibros.DataSource = Tabla
                ElseIf cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 3"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If

            Case "descontinuado"
                Consulta = "UPDATE libro set estado= 3 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 0"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 1"
                    consultar()
                    dgvlibros.DataSource = Tabla
                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado' from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial where libro.estado = 2"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If
        End Select

        Pactualizar.SendToBack()
        'estado_txt.SendToBack()
        cmbupdate.BringToFront()

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        'Los datos que el usuario selecciono del DataGrid y que luego fueron mostrados en el Panel'
        'Son copiados a un segundo panel donde luego podran ser modificados'
        If bandera = 1 Then
            Try
                cod_libro_txt.Text = cod_libro_label.Text
                titulo_txt.Text = titulo_label.Text
                autor_txt.Text = autor_label.Text
                editorial_txt.Text = editorial_label.Text
                anio_txt.Text = fecha_label.Text
                origen_txt.Text = origen_label.Text
                volumen_txt.Text = volumen_label.Text
                observaciones_txt.Text = observaciones_label.Text

                'Permite seleccionar el estado predeterminado del combobox al momento de modificar los datos'
                '0-disponible,1-ocupado, 2-reservado,3-descontinuado'
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
                Next
                'Envia el primer panel al fondo, mostrando el que contiene la consulta update'
                Pmostrar.SendToBack()

            Catch ex As Exception
                MsgBox("Accion imposible de realizar")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
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
        cmbupdate.BringToFront()
        Pactualizar.SendToBack()

    End Sub
    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If bandera = 1 Then
            Try
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
            Catch ex As Exception
                MsgBox("Accion imposible de realizar")

            End Try
        Else

            MsgBox("Base de datos no disponible")
        End If
    End Sub

End Class
