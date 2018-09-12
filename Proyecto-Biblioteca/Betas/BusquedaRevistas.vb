Public Class BusquedaRevistas
    Dim bandera As Integer
    Public estado As Integer
    Dim id As Integer ' Variable usada en modificar revistas

    Private Sub cmbestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado.SelectedIndexChanged
        If bandera = 1 Then
            Try
                Select Case cmbestado.SelectedItem
                    Case "ocupado"
                        Consulta = "select titulo,anio,origen,descripcion,estado from revistas where revistas.estado like '1'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "disponible"
                        Consulta = "select titulo,anio,origen,descripcion,estado from revistas where revistas.estado like '0'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "reservado"
                        Consulta = "select titulo,anio,origen,descripcion,estado from revistas where revistas.estado like '2'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "descontinuado"
                        Consulta = "select titulo,anio,origen,descripcion,estado from revistas where revistas.estado like '3'"
                        consultar()
                        dgvrevistas.DataSource = Tabla
                End Select
            Catch ex As Exception
                MsgBox("Accion imposible de realizar")
            End Try
        Else
            MsgBox("Base de datos no disponible")

        End If
    End Sub

    Private Sub BusquedaRevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Comprobacion'
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
            Dim contadoringreso As Integer = 0
            Consulta = "select titulo,anio,origen,descripcion,estado from revistas"
            consultar()
            dgvrevistas.DataSource = Tabla
            DatagridModulo = dgvrevistas
            Datagrid_Align()
            dgvrevistas.Columns(0).HeaderText = "Titulo"
            dgvrevistas.Columns(1).HeaderText = "Año"
            dgvrevistas.Columns(2).HeaderText = "Pais de Origen"
            dgvrevistas.Columns(3).HeaderText = "Descripcion"
            dgvrevistas.Columns(4).HeaderText = "Estado"
            cmbestado.SelectedIndex = 0
            cmbdatos.SelectedIndex = 0

        Else
            titulo_txt.ReadOnly = True
            origen_txt.ReadOnly = True
            anio_txt.ReadOnly = True
            desc_txt.ReadOnly = True
        End If
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        'Los datos que el usuario selecciono del DataGrid y que luego fueron mostrados en el Panel'
        'Son copiados a un segundo panel donde luego podran ser modificados'

        If bandera = 1 Then
            Try
                titulo_txt.Text = lbltitulomostrar.Text
                anio_txt.Text = lblaniomostrar.Text
                origen_txt.Text = lblorigenmostrar.Text
                desc_txt.Text = txtdescmostrar.Text



                'Permite seleccionar el estado predeterminado del combobox al momento de modificar los datos'
                '0-disponible,1-ocupado, 2-reservado,3-descontinuado'
                For Each row In dgvrevistas.Rows
                    If dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 0 Then
                        cmbupdate.SelectedIndex = 0
                    ElseIf dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 1 Then
                        cmbupdate.SelectedIndex = 1
                    ElseIf dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 2 Then
                        cmbupdate.SelectedIndex = 2
                    ElseIf dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 3 Then
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

    Private Sub dgvrevistas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvrevistas.CellDoubleClick

        Consulta = "select * from revistas"
        consultar()
        For Each row As DataRow In Tabla.Rows
            titulo_txt.Text = row("titulo").ToString
            anio_txt.Text = row("anio").ToString
            origen_txt.Text = row("origen").ToString
            desc_txt.Text = row("descripcion").ToString
            Select Case row("estado")
                Case 0
                    cmbupdate.SelectedIndex = 0
                Case 1
                    cmbupdate.SelectedIndex = 1
                Case 2
                    cmbupdate.SelectedIndex = 2
                Case 3
                    cmbupdate.SelectedIndex = 3
            End Select
        Next

    End Sub

    Private Sub dgvrevistas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvrevistas.MouseClick
        Try
            '///El usuario selecciona una fila de datos en el DataGrid y estos son copiados a un Panel///'
            'Permite al usuario una mejor visualizacion de los datos del libro que busca'
            lbltitulomostrar.Text = dgvrevistas.Item(0, dgvrevistas.CurrentRow.Index).Value
            lblaniomostrar.Text = dgvrevistas.Item(1, dgvrevistas.CurrentRow.Index).Value
            lblorigenmostrar.Text = dgvrevistas.Item(2, dgvrevistas.CurrentRow.Index).Value
            txtdescmostrar.Text = dgvrevistas.Item(3, dgvrevistas.CurrentRow.Index).Value

            estado_label.Text = dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If bandera = 1 Then
            Try
                'Consultas usando Case para la busqueda mediante un textbox relacionado a un combobox'

                Select Case cmbdatos.SelectedItem
                    Case "Titulo"
                        Select Case cmbestado.SelectedItem
                            Case "disponible"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '0' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "ocupado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '1' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "reservado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '2' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "descontinuado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '3' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select

                    Case "Año"
                        Select Case cmbestado.SelectedItem
                            Case "disponible"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '0' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "ocupado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '1' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "reservado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '2' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "descontinuado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '3' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select

                    Case "Origen"
                        Select Case cmbestado.SelectedItem
                            Case "disponible"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '0' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "ocupado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '1' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "reservado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '2' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "descontinuado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '3' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select

                    Case "Descripcion"
                        Select Case cmbestado.SelectedItem
                            Case "disponible"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '0' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "ocupado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '1' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "reservado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '2' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "descontinuado"
                                Consulta = "select titulo,anio,origen,descripcion,estado from revistas where estado like '3' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select
                        End Select
            Catch ex As Exception
                MsgBox("Accion imposible de realizar")

            End Try
        Else

            MsgBox("Base de datos no disponible")
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        titulo_txt.Clear()
        anio_txt.Clear()
        origen_txt.Clear()
        desc_txt.Clear()
        cmbupdate.BringToFront()
        Pactualizar.SendToBack()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        '-------------Variables-----------------------
        Dim titulo As String = Nothing
        Dim año As Integer = Nothing
        Dim origen As String = Nothing
        Dim descripcion As String = Nothing
        Dim estado As Integer = Nothing
        Dim errorr As Integer = 0
        '----------------------------------------------
        '-------Obtener el codigo de la revista--------
        Consulta = "select * from revistas"
        consultar()
        For Each row As DataRow In Tabla.Rows
            id = Val(row("id_revistas"))
        Next
        '----------------------------------------------
        '-----------Comprobacion de campos-------------
        If LTrim$(titulo_txt.Text) = "" Then
            ErrorProvider1.SetError(titulo_txt, "No puede dejar este espacio en blanco")
            errorr = 1
        Else
            titulo = titulo_txt.Text
        End If
        If LTrim$(anio_txt.Text) = "" Then
            ErrorProvider1.SetError(anio_txt, "No se puede dejar este espacio en blanco")
            errorr = 1
        Else
            año = anio_txt.Text
        End If
        If LTrim$(origen_txt.Text) = "" Then
            ErrorProvider1.SetError(origen_txt, "No se puede dejar este espacio en blanco")
            errorr = 1
        Else
            origen = origen_txt.Text
        End If

        descripcion = desc_txt.Text

        Select Case cmbupdate.SelectedIndex
            Case 0
                estado = 0
            Case 1
                estado = 1
            Case 2
                estado = 2
            Case 3
                estado = 3
        End Select
        '--------------------------------------------------------
        '------------Se actualizan los datos en la BD------------
        If errorr = 0 Then
            Try
                Consulta = "update table revistas set titulo='" & titulo & "' where id_revistas='" & id & "'"
                consultar()
            Catch ex As Exception
                MsgBox("No se pudo actualizar la informacion")
            End Try
        Else
            MsgBox("No se pudo actualizar la informacion, revise los campos marcados")
        End If

    End Sub

End Class