Imports System.Data
Imports System.Data.OleDb
Public Class buscarlibro
    Dim bandera As Integer
    Public estado As Integer
    Dim activadoEdi As Integer = 0
    Dim activadoAut As Integer = 0
    Dim dvgeditorialW As Integer
    Dim dvgautorW As Integer
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
        Pautor.Visible = False
        Peditorial.Visible = False
        Consulta = "select * from usuarios"
        consultar()
        dgvcomprobar.DataSource = Tabla
        Try
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

                    dvgeditorialW = dgveditorial.Width
                    dvgautorW = dgvautor.Width
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
            autor_txt.ReadOnly = True
            titulo_txt.ReadOnly = True
            volumen_txt.ReadOnly = True
            editorial_txt.ReadOnly = True
            anio_txt.ReadOnly = True
            origen_txt.ReadOnly = True
            observaciones_txt.ReadOnly = True
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
        Consulta = "UPDATE libro SET titulo=('" + titulo_txt.Text + "'), volumen=('" + volumen_txt.Text + "'),cod_autor='" + autoroculto_txt.Text + "',cod_editorial='" + editorialoculto_txt.Text + "', anio=('" + anio_txt.Text + "'), origen=('" + origen_txt.Text + "'), observaciones=('" + observaciones_txt.Text + "') WHERE cod_libro=('" + cod_libro_txt.Text + "')"
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

    Private Sub btnselectautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectautor.Click
        If bandera = 1 Then
            Try
                'Este boton muestra un panel donde podremos seleccionar un autor o ingresar uno nuevo.
                Try
                    Pautor.Visible = True
                    Consulta = "SELECT * FROM autor"
                    consultar()
                    dgvautor.DataSource = Tabla
                    dgvautor.Columns(0).Visible = False
                    dgvautor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Autor")
                End Try
                'El boton se muestra
                btningautor.Visible = True
                'El boton se esconde
                btncancelar.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case activadoEdi
            Case 0
                If Paneleditorial.Left > 245 Then
                    Paneleditorial.Left -= 5

                Else
                    dgveditorial.Width = dgveditorial.Width - Paneleditorial.Width
                    activadoEdi = 1
                    Timer1.Enabled = False
                End If
            Case 1
                If Paneleditorial.Left < 429 Then
                    Paneleditorial.Left += 5

                Else
                    dgveditorial.Width = dvgeditorialW
                    activadoEdi = 0
                    Timer1.Enabled = False
                End If
        End Select

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Select Case activadoAut
            Case 0
                If panelautor.Left > 255 Then
                    panelautor.Left -= 5

                Else
                    dgvautor.Width = dgvautor.Width - panelautor.Width
                    activadoAut = 1
                    Timer2.Enabled = False
                End If
            Case 1
                If panelautor.Left < 419 Then
                    panelautor.Left += 5

                Else
                    dgvautor.Width = dvgautorW
                    activadoAut = 0
                    Timer2.Enabled = False
                End If
        End Select
    End Sub

    Private Sub txtbuscareditorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscareditorial.TextChanged
        'Busqueda de editoriales
        Consulta = "select * from editorial where nombre like '" & txtbuscareditorial.Text & "%'"
        consultar()
        dgveditorial.DataSource = Tabla
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        'El boton se esconde
        btncancelar.Visible = False
        'El boton se muestra
        btningeditorial.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion inicial.
        Timer1.Enabled = True
    End Sub

    Private Sub txtbuscarautor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarautor.TextChanged
        'Busuqeda de autor
        Try
            Consulta = "select * from autor where nombre like '" & txtbuscarautor.Text & "%'"
            consultar()
            dgvautor.DataSource = Tabla
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnweditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnweditorial.Click
        If Trim(txtnombree.Text) = "" Or (txtpais.Text) = "" Or (txtanioe.Text) = "" Then
            MsgBox(" Ha ocurrido un error. Uno de los campos necesarios se encuentra vacio")

        Else
            'Ingresa una nueva editorial a la Base de datos.
            Consulta = "INSERT INTO editorial (nombre, pais, anio) values (concat(upper(left('" + txtnombree.Text + "',1)),lower(substr('" + txtnombree.Text + "',2))),concat(upper(left('" + txtpais.Text + "',1)),lower(substr('" + txtpais.Text + "',2))),'" + txtanioe.Text + "')"
            consultar()

            Try
                Consulta = "SELECT * FROM editorial"
                consultar()
                dgveditorial.DataSource = Tabla

            Catch ex As Exception
                MsgBox(ex)
            End Try

            'El boton se esconde
            btncancelar.Visible = False
            btningeditorial.Visible = True

            'Limpia los campos de texto'
            txtnombree.Clear()
            txtpais.Clear()
            txtanioe.Clear()

            Timer1.Enabled = True

        End If
    End Sub

    Private Sub btnvolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        If activadoAut = 1 Then
            'El datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            Timer2.Enabled = True
        End If

        'El boton se esconde
        btncancelar2.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'El contenido de los textbox es eliminado.
        txtnombreau.Clear()
        txtpaisau.Clear()

        'El panel autor se oculta.
        Pautor.Visible = False
    End Sub

    Private Sub dgveditorial_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgveditorial.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre de la editorial.
        editorial_txt.Text = dgveditorial.Item(1, dgveditorial.CurrentRow.Index).Value
        editorialoculto_txt.Text = dgveditorial.Item(0, dgveditorial.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Peditorial.Visible = False
    End Sub

    Private Sub dgvautor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvautor.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre del autor.
        autor_txt.Text = dgvautor.Item(1, dgvautor.CurrentRow.Index).Value
        autoroculto_txt.Text = dgvautor.Item(0, dgvautor.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Pautor.Visible = False
    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click

        If activadoEdi = 1 Then
            'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            Timer1.Enabled = True
        End If

        'El boton se esconde
        btncancelar.Visible = False
        'El boton se muestra
        btningeditorial.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'El panel editorial se oculta.
        Peditorial.Visible = False



    End Sub

    Private Sub btningeditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningeditorial.Click
        'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse una nueva editorial.
        Timer1.Enabled = True
        'El boton se esconde
        btningeditorial.Visible = False
        'El boton se muestra
        btncancelar.Visible = True
    End Sub

    Private Sub btncancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar2.Click
        'El boton se esconde.
        btncancelar2.Visible = False
        'El boton se muestra
        btningautor.Visible = True

        'Limpia los campos de texto'
        txtnombreau.Clear()
        txtpaisau.Clear()

        'El Datagrid se redimensiona y a su vez el panel se mueve a su posicion inicial.
        Timer2.Enabled = True
    End Sub

    Private Sub btningautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningautor.Click
        If bandera = 1 Then
            Try
                'El boton se esconde
                btningautor.Visible = False
                'El boton se muestra
                btncancelar2.Visible = True

                'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse un nuevo autor.
                Timer2.Enabled = True
            Catch ex As Exception
                MsgBox("No es posible realizar esta accion")
            End Try
        Else
            MsgBox("Esta accion es imposible de realizar actualmente")
        End If
    End Sub

    Private Sub btnnwautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwautor.Click
        If bandera = 1 Then
            Try
                If Trim(txtnombreau.Text) = "" Or (txtpaisau.Text) = "" Then
                    MsgBox(" Ha ocurrido un error. Uno de los campos necesarios se encuentra vacio")
                Else
                    'Ingresa un nuevo autor a la Base de Datos.
                    Consulta = "INSERT INTO autor (nombre, nacionalidad) values (concat(upper(left('" + txtnombreau.Text + "',1)),lower(substr('" + txtnombreau.Text + "',2))), concat(upper(left('" + txtpaisau.Text + "',1)),lower(substr('" + txtpaisau.Text + "',2))))"
                    consultar()

                    Consulta = "SELECT * FROM autor"
                    consultar()
                    dgvautor.DataSource = Tabla

                    'El boton se esconde
                    btncancelar2.Visible = False
                    'El boton se muestra
                    btningautor.Visible = True

                    'Limpia los campos de texto'
                    txtnombreau.Clear()
                    txtpaisau.Clear()

                    Timer2.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub btnselecteditorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselecteditorial.Click
        If bandera = 1 Then
            Try
                'Este boton muestra un panel donde podremos seleccionar una editorial o ingresar una nueva.
                Try
                    Peditorial.Visible = True
                    Consulta = "SELECT * FROM editorial"
                    consultar()
                    dgveditorial.DataSource = Tabla
                    dgveditorial.Columns(0).Visible = False
                    dgveditorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Editorial")
                End Try

                'El Boton se muestra
                btningeditorial.Visible = True
                'El boton se esconde
                btncancelar.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub
End Class
