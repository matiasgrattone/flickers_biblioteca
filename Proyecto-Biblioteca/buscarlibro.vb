Imports System.Data
Imports System.Data.OleDb
Public Class buscarlibro
    Dim bandera As Integer
    Public estado As Integer

    Dim activadoEdi As Integer = 0
    Dim activadoAut As Integer = 0
    Dim activadoclas As Integer = 0

    Dim dvgeditorialW As Integer
    Dim dvgautorW As Integer
    Dim dgvclas As Integer

    Dim seleccionado As Integer = 0

    Dim autor As Integer
    Dim editorial As Integer

    Dim contadoringresoclas As Integer
    Dim primeringresoclas As Integer
    Dim error10 As Integer = 0
    'Dim clasificacion As Integer


    Private Sub dgvlibros_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvlibros.MouseClick
        Try
            '///El usuario selecciona una fila de datos en el DataGrid y estos son copiados a un Panel///'
            'Permite al usuario una mejor visualizacion de los datos del libro que busca'
            Consulta = "SELECT volumen as Volumen, observaciones as Observaciones FROM libro where cod_libro = '" & dgvlibros.Item(0, dgvlibros.CurrentRow.Index).Value & "'"
            consultar()

            For Each row As DataRow In Tabla.Rows
                volumen_label.Text = row("volumen")
                observaciones_label.Text = row("observaciones")

            Next

            cod_libro_label.Text = dgvlibros.Item(0, dgvlibros.CurrentRow.Index).Value
            titulo_label.Text = dgvlibros.Item(1, dgvlibros.CurrentRow.Index).Value
            autor_label.Text = dgvlibros.Item(2, dgvlibros.CurrentRow.Index).Value
            editorial_label.Text = dgvlibros.Item(3, dgvlibros.CurrentRow.Index).Value
            fecha_label.Text = dgvlibros.Item(4, dgvlibros.CurrentRow.Index).Value
            origen_label.Text = dgvlibros.Item(5, dgvlibros.CurrentRow.Index).Value
            estado_label.Text = dgvlibros.Item(6, dgvlibros.CurrentRow.Index).Value
            clasificacio_label.Text = dgvlibros.Item(7, dgvlibros.CurrentRow.Index).Value

        Catch ex As Exception

        End Try


    End Sub

    Private Sub buscarlibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pautor.Visible = False
        Peditorial.Visible = False
        Pclasificacion.Visible = False
        cmbsala.SelectedIndex = 0
        Consulta = "select * from usuarios"
        consultar()
        Try
            For Each row As DataRow In Tabla.Rows
                If row("nombre").ToString <> "" Then
                    bandera = 1
                Else
                    bandera = 0
                End If
            Next
        Catch ex1 As Exception
            MsgBox("Base de datos no disponible")
        End Try

        If bandera = 1 Then
            Try
                'Invocamos al modulo para conectar el programa con la base de datos llamada Libros, y luego lo mostramos en el DataGrid'
                Try
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.ensala='0'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                    dgvlibros.Columns(4).HeaderText = "Año"
                    dgvlibros.Columns(3).HeaderText = "Nombre Editorial"
                    dgvlibros.Columns(2).HeaderText = "Nombre Autor"
                    dgvlibros.Columns(0).HeaderText = "Nº de Inventario"
                    dgvlibros.Columns(7).HeaderText = "Codigo de Clasificacion"
                    dgvlibros.Columns(8).HeaderText = "Clasificacion"
                    dgvlibros.Columns(7).Visible = False
                    dgvlibros.Columns(9).Visible = False
                    dgvlibros.Columns(10).Visible = False
                    dgvlibros.Columns(11).HeaderText = "Fecha de Ingreso"

                    cmbestado.SelectedIndex = 0
                    cmbdatos.SelectedIndex = 0

                    'Alinea y Ajusta las columnas al tamaño del datagrid.
                    DatagridModulo = dgvlibros
                    Datagrid_Align()
                    '///////////////////////////////////////////////////

                    dvgeditorialW = dgveditorial.Width
                    dvgautorW = dgvautor.Width
                    dgvclas = dgvautor.Width
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
            clasificacion_txt.ReadOnly = True
            observaciones_txt.ReadOnly = True
        End If
    End Sub

    Private Sub cmbestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado.SelectedIndexChanged
        If bandera = 1 Then
            Try
                Select Case cmbsala.SelectedItem
                    Case "No"
                        Select Case cmbestado.SelectedItem
                            Case "ocupado"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1' and libro.ensala='0'"
                                consultar()
                                dgvlibros.DataSource = Tabla

                            Case "disponible"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0' and libro.ensala='0'"
                                consultar()
                                dgvlibros.DataSource = Tabla

                            Case "reservado"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2' and libro.ensala='0'"
                                consultar()
                                dgvlibros.DataSource = Tabla

                            Case "descontinuado"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3' and libro.ensala='0'"
                                consultar()
                                dgvlibros.DataSource = Tabla
                        End Select
                    Case "Si"
                        Select Case cmbestado.SelectedItem
                            Case "ocupado"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1' and libro.ensala='1'"
                                consultar()
                                dgvlibros.DataSource = Tabla

                            Case "disponible"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0' and libro.ensala='1'"
                                consultar()
                                dgvlibros.DataSource = Tabla

                            Case "reservado"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2' and libro.ensala='1'"
                                consultar()
                                dgvlibros.DataSource = Tabla

                            Case "descontinuado"
                                Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3' and libro.ensala='1'"
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

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        'Consulta Update Para la Tabla Libros en la Base'
        'Realiza la consulta, se actualizan los datos por los que el usuario indica y al momento el Datagrid se actualiza
        Consulta = "UPDATE libro SET titulo=('" + titulo_txt.Text + "'), volumen=('" + volumen_txt.Text + "'),cod_autor='" & autor & "',cod_editorial='" & editorial & "', anio=('" + anio_txt.Text + "'), origen=('" + origen_txt.Text + "'), observaciones=('" + observaciones_txt.Text + "'),cod_clas='" + clasificacion_txt.Text + "' WHERE cod_libro=('" + cod_libro_txt.Text + "')"
        consultar()
        'Utilizaremos 2 combobox, cmbupdate y cmbdatos. El primero nombrado, cmbupdate se utilizara para el intercambio de los estados del libro seleccionado.
        'El segundo, cmbdatos sera utilizado para el filtro realizado por el programa despues de actualizar para filtrar los distintos libros segun el estado seleccionado en este.
        Select Case cmbupdate.SelectedItem
            Case "disponible"
                Consulta = "UPDATE libro set estado= 0 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3'"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If

            Case "ocupado"
                Consulta = "UPDATE libro set estado= 1 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3'"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If

            Case "reservado"
                Consulta = "UPDATE libro set estado= 2 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3'"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If

            Case "descontinuado"
                Consulta = "UPDATE libro set estado= 3 WHERE cod_libro=('" + cod_libro_txt.Text + "')"
                consultar()

                If cmbestado.Text = "disponible" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "ocupado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "reservado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2'"
                    consultar()
                    dgvlibros.DataSource = Tabla

                ElseIf cmbestado.Text = "descontinuado" Then
                    Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3'"
                    consultar()
                    dgvlibros.DataSource = Tabla
                End If
        End Select
        Pactualizar.SendToBack()
        cmbupdate.BringToFront()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        If bandera = 1 Then
            Try
                Dim contraseñaAdmin As String
                contraseñaAdmin = InputBox("Por favor ingrese contraseña de un funcionario", Title:="Biblioteca")
                Consulta = "select * from usuarios where tipo = 0"
                consultar()
                For Each row As DataRow In Tabla.Rows
                    If row("cedula") = contraseñaAdmin Then
                        contraseñaAdmin = "1"
                    Else
                    End If
                Next
                If contraseñaAdmin = "1" Then
                    'Los datos que el usuario selecciono del DataGrid y que luego fueron mostrados en el Panel'
                    'Son copiados a un segundo panel donde luego podran ser modificados'
                    cod_libro_txt.Text = cod_libro_label.Text
                    titulo_txt.Text = titulo_label.Text
                    autor_txt.Text = autor_label.Text
                    editorial_txt.Text = editorial_label.Text
                    anio_txt.Text = fecha_label.Text
                    origen_txt.Text = origen_label.Text
                    volumen_txt.Text = volumen_label.Text
                    observaciones_txt.Text = observaciones_label.Text
                    clasificacion_txt.Text = clasificacio_label.Text
                    autor = dgvlibros.Item(9, dgvlibros.CurrentRow.Index).Value
                    editorial = dgvlibros.Item(10, dgvlibros.CurrentRow.Index).Value

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
                Else
                    contraseñaAdmin = "0"
                    MsgBox("contraseña no valida", Title:="Biblioteca")
                End If
            Catch ex As Exception
                MsgBox("Accion imposible de realizar")
            End Try
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
        clasificacion_txt.Clear()
        cmbupdate.BringToFront()
        Pactualizar.SendToBack()
    End Sub
    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If bandera = 1 Then
            Try
                'Consultas usando Case para la busqueda mediante un textbox relacionado a un combobox'
                Select Case cmbsala.SelectedItem
                    Case "No"
                        Select Case cmbdatos.SelectedItem
                            Case "Autor"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Editorial"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Año"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Titulo"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Codigo"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Origen"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='0'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select
                        End Select

                    Case "Si"
                        Select Case cmbdatos.SelectedItem
                            Case "Autor"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where autor.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Editorial"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where editorial.nombre like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Año"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.anio like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Titulo"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.titulo like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Codigo"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.cod_libro like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select

                            Case "Origen"
                                Select Case cmbestado.SelectedItem
                                    Case "ocupado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '1' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "disponible"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '0' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "reservado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '2' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                    Case "descontinuado"
                                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.origen like '" & txtbusqueda.Text & "%' and libro.estado like '3' and ensala='1'"
                                        consultar()
                                        dgvlibros.DataSource = Tabla
                                End Select
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
                    '1 autor , 2 editorial, 3 clasificacion
                    seleccionado = 1
                    Select Case seleccionado
                        Case 1
                            Pautor.Visible = True
                            Peditorial.Visible = False
                            Pclasificacion.Visible = False
                        Case 2
                            Peditorial.Visible = False
                            Pautor.Visible = False
                            Pclasificacion.Visible = True
                        Case 3
                            Pclasificacion.Visible = False
                            Pautor.Visible = False
                            Peditorial.Visible = True
                    End Select

                    If activadoAut = 1 Then
                        'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
                        timereditorial.Enabled = True
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timereditorial.Tick
        Select Case activadoEdi
            Case 0
                If Paneleditorial.Left > 245 Then
                    Paneleditorial.Left -= 5

                Else
                    dgveditorial.Width = dgveditorial.Width - Paneleditorial.Width
                    activadoEdi = 1
                    timereditorial.Enabled = False
                End If
            Case 1
                If Paneleditorial.Left < 429 Then
                    Paneleditorial.Left += 5

                Else
                    dgveditorial.Width = dvgeditorialW
                    activadoEdi = 0
                    timereditorial.Enabled = False
                End If
        End Select

    End Sub

    Private Sub timerautor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerautor.Tick
        Select Case activadoAut
            Case 0
                If panelautor.Left > 255 Then
                    panelautor.Left -= 5

                Else
                    dgvautor.Width = dgvautor.Width - panelautor.Width
                    activadoAut = 1
                    timerautor.Enabled = False
                End If
            Case 1
                If panelautor.Left < 419 Then
                    panelautor.Left += 5

                Else
                    dgvautor.Width = dvgautorW
                    activadoAut = 0
                    timerautor.Enabled = False
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
        timereditorial.Enabled = True
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

            timereditorial.Enabled = True

        End If
    End Sub

    Private Sub btnvolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        If activadoAut = 1 Then
            'El datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            timerautor.Enabled = True
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
        editorial = dgveditorial.Item(0, dgveditorial.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Peditorial.Visible = False
    End Sub

    Private Sub dgvautor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvautor.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre del autor.
        autor_txt.Text = dgvautor.Item(1, dgvautor.CurrentRow.Index).Value
        autor = dgvautor.Item(0, dgvautor.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Pautor.Visible = False
    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        If activadoEdi = 1 Then
            'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            timereditorial.Enabled = True
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
        timereditorial.Enabled = True
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
        timerautor.Enabled = True
    End Sub

    Private Sub btningautor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningautor.Click
        If bandera = 1 Then
            Try
                'El boton se esconde
                btningautor.Visible = False
                'El boton se muestra
                btncancelar2.Visible = True

                'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse un nuevo autor.
                timerautor.Enabled = True
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

                    timerautor.Enabled = True
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
                    If activadoEdi = 1 Then
                        'El datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
                        timerautor.Enabled = True
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
    Private Sub anio_txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles anio_txt.KeyUp
        anio_txt.MaxLength = 4
    End Sub
    Private Sub observaciones_txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles observaciones_txt.KeyUp
        observaciones_txt.MaxLength = 255
    End Sub
    Private Sub titulo_txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles titulo_txt.KeyUp
        titulo_txt.MaxLength = 30
    End Sub
    Private Sub volumen_txt_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles volumen_txt.ModifiedChanged
        volumen_txt.MaxLength = 3
    End Sub
    Private Sub origen_txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles origen_txt.KeyUp
        origen_txt.MaxLength = 20
    End Sub

    Private Sub btnselectclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectclas.Click
        If bandera = 1 Then
            Try
                'Este boton muestra un panel donde podremos seleccionar un autor o ingresar uno nuevo.
                Try
                    '1 autor , 2 editorial, 3 clasificacion
                    seleccionado = 2
                    Select Case seleccionado
                        Case 1
                            Pautor.Visible = True
                            Peditorial.Visible = False
                            Pclasificacion.Visible = False
                        Case 2
                            Peditorial.Visible = False
                            Pautor.Visible = False
                            Pclasificacion.Visible = True
                        Case 3
                            Pclasificacion.Visible = False
                            Pautor.Visible = False
                            Peditorial.Visible = True
                    End Select

                    Consulta = "SELECT * FROM clasificacion"
                    consultar()
                    dgvclasificacion.DataSource = Tabla
                    dgvclasificacion.Columns(0).HeaderText = "Codigo de Clasificacion"
                    dgvclasificacion.Columns(1).HeaderText = "Clasificacion"
                    dgvclasificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill 'Ajusta las columnas al tamaño del datagrid'
                Catch ex As Exception
                    MsgBox("No es posible acceder a la tabla Clasificacion")
                End Try
                'El boton se muestra
                btninclas.Visible = True
                'El boton se esconde
                btncancelarclas.Visible = False
            Catch ex As Exception
                MsgBox("Base de datos no disponible")
            End Try
        Else
            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub txtbuscarclas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarclas.TextChanged
        'Busqueda de Clasificaciones
        Select Case cmbclasificacion.SelectedIndex
            Case 0
                Consulta = "select * from clasificacion where cod_clas like '" & txtbuscarclas.Text & "%'"
                consultar()
                dgvclasificacion.DataSource = Tabla
            Case 1
                Consulta = "select * from clasificacion where nom_clas like '" & txtbuscarclas.Text & "%'"
                consultar()
                dgvclasificacion.DataSource = Tabla
            Case Else
                Consulta = "select * from clasificacion"
                consultar()
                dgvclasificacion.DataSource = Tabla
        End Select
    End Sub

    Private Sub btnvolver3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver3.Click

        If activadoclas = 1 Then
            'El Datagrid se redimensiona y a su vez el panel vuelve a su posicion original.
            timerclasificacion.Enabled = True
        End If

        'El boton se esconde
        btncancelarclas.Visible = False
        'El boton se muestra
        btninclas.Visible = True

        'Limpia los campos de texto'
        txtnombree.Clear()
        txtpais.Clear()
        txtanioe.Clear()

        'El panel editorial se oculta.
        Pclasificacion.Visible = False
    End Sub

    Private Sub timerclasificacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerclasificacion.Tick
        Select Case activadoclas
            Case 0
                If panelclasificacion.Left > 245 Then
                    panelclasificacion.Left -= 5

                Else
                    dgvclasificacion.Width = dgvclasificacion.Width - panelclasificacion.Width
                    activadoclas = 1
                    timerclasificacion.Enabled = False
                End If
            Case 1
                If panelclasificacion.Left < 424 Then
                    panelclasificacion.Left += 5
                Else
                    dgvclasificacion.Width = dgvclas
                    activadoclas = 0
                    timerclasificacion.Enabled = False
                End If
        End Select
    End Sub

    Private Sub btncancelarclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarclas.Click

        'El boton se esconde.
        btncancelarclas.Visible = False
        'El boton se muestra
        btninclas.Visible = True

        'Limpia los campos de texto'
        txtnombreclas.Clear()
        txtcodclas.Clear()

        'Desactiva los errorprovider
        ErrorProvider1.SetError(txtcodclas, "")
        ErrorProvider1.SetError(txtnombreclas, "")

        'El Datagrid se redimensiona y a su vez el panel se mueve a su posicion inicial.
        timerclasificacion.Enabled = True
    End Sub

    Private Sub btninclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninclas.Click
        If bandera = 1 Then
            Try
                'El boton se esconde
                btninclas.Visible = False
                'El boton se muestra
                btncancelarclas.Visible = True

                'El Datagrid se redimensiona y a su vez aparece un panel donde puede ingresarse un nuevo autor.
                timerclasificacion.Enabled = True
            Catch ex As Exception
                MsgBox("No es posible realizar esta accion")
            End Try
        Else
            MsgBox("Esta accion es imposible de realizar actualmente")
        End If
    End Sub


    Private Sub dgvclasificacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclasificacion.CellDoubleClick
        'Al dar doble click sobre la celda del datagrid el campo de texto recibe el dato del nombre del autor.
        clasificacion_txt.Text = dgvclasificacion.Item(0, dgvclasificacion.CurrentRow.Index).Value
        'El panel que contiene el datagrid se esconde.
        Pclasificacion.Visible = False
    End Sub

    Private Sub btnnwclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnwclas.Click
        If Trim(txtcodclas.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtcodclas, "El campo se encuentra vacio")
            contadoringresoclas = contadoringresoclas + 1
        End If
        If Trim(txtnombreclas.Text) = "" Or error10 = 1 Then
            ErrorProvider1.SetError(txtnombreclas, "El campo se encuentra vacio")
            contadoringresoclas = contadoringresoclas + 1
        End If
        If error10 = 0 Then
            If contadoringresoclas <> 0 Then
                contadoringresoclas = 0
                primeringresoclas = 1

            Else
                'Ingresa una nueva editorial a la Base de datos.
                'Consulta = "INSERT INTO clasificacion values ('" + txtcodclas.Text + "',concat(upper(left('" + txtnombreclas.Text + "',1))),lower(substr('" + txtnombreclas.Text + "',2)))"
                Consulta = "insert into clasificacion values('" & txtcodclas.Text & "','" & txtnombreclas.Text & "')"
                consultar()

                ErrorProvider1.SetError(txtcodclas, "")
                ErrorProvider1.SetError(txtnombreclas, "")
                Try
                    Consulta = "SELECT * FROM clasificacion"
                    consultar()
                    dgvclasificacion.DataSource = Tabla

                Catch ex As Exception
                    MsgBox(ex)
                End Try

                'El boton se esconde
                btncancelarclas.Visible = False
                btninclas.Visible = True

                'Limpia los campos de texto'
                txtcodclas.Clear()
                txtnombreclas.Clear()

                primeringresoclas = 0
                ErrorProvider1.SetError(txtcodclas, "")
                ErrorProvider1.SetError(txtnombreclas, "")

                timerclasificacion.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmbsala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsala.SelectedIndexChanged
        Select Case cmbsala.SelectedItem
            Case "No"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1' and libro.ensala='0'"
                        consultar()
                        dgvlibros.DataSource = Tabla

                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0' and libro.ensala='0'"
                        consultar()
                        dgvlibros.DataSource = Tabla

                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2' and libro.ensala='0'"
                        consultar()
                        dgvlibros.DataSource = Tabla

                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3' and libro.ensala='0'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select
            Case "Si"
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre , editorial.nombre, libro.anio, libro.origen as 'Origen' , libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '1' and libro.ensala='1'"
                        consultar()
                        dgvlibros.DataSource = Tabla

                    Case "disponible"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '0' and libro.ensala='1'"
                        consultar()
                        dgvlibros.DataSource = Tabla

                    Case "reservado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '2' and libro.ensala='1'"
                        consultar()
                        dgvlibros.DataSource = Tabla

                    Case "descontinuado"
                        Consulta = "SELECT libro.cod_libro, libro.titulo as 'Titulo', autor.nombre, editorial.nombre, libro.anio, libro.origen as 'Origen',libro.estado as 'Estado', libro.cod_clas,clasificacion.nom_clas, libro.cod_autor, libro.cod_editorial, libro.fecha_ingreso from libro inner join autor on libro.cod_autor = autor.cod_autor inner join editorial on libro.cod_editorial = editorial.cod_editorial inner join clasificacion on libro.cod_clas = clasificacion.cod_clas where libro.estado like '3' and libro.ensala='1'"
                        consultar()
                        dgvlibros.DataSource = Tabla
                End Select
        End Select
    End Sub
End Class
