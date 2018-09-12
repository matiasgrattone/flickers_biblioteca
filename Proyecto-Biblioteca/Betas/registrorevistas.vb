Public Class registrorevistas
    Dim cero As String
    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        Select Case cmbbusqueda.SelectedIndex
            Case 0
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where usuarios.cedula like '" & txtbusqueda.Text & "%' and prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where usuarios.cedula like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 1
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where usuarios.nombre like '" & txtbusqueda.Text & "%' and prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where usuarios.nombre like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 2
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where revistas.id_revistas like '" & txtbusqueda.Text & "%' and prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where revistas.id_revistas like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 3
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where revistas.titulo like '" & txtbusqueda.Text & "%' and prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where revistas.titulo like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case Else

                Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where revistas.titulo like '" & txtbusqueda.Text & "%'"
                consultar()
                dgvregistro.DataSource = Tabla
        End Select
    End Sub

    Private Sub cmbdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If cmbdia.SelectedItem.ToString.Length = 1 Then
            cero = "0" & cmbdia.SelectedItem
        End If

        If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then

            Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
            consultar()
            dgvregistro.DataSource = Tabla

        Else
            Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where revistas.titulo like '" & txtbusqueda.Text & "%'"
            consultar()
            dgvregistro.DataSource = Tabla
        End If
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmes.SelectedIndexChanged
        substring = cmbmes.SelectedItem
        mestonum()

        If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then

            Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
            consultar()
            dgvregistro.DataSource = Tabla

        End If
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaño.SelectedIndexChanged
        If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then

            Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula where prestamorevistas.fecha_salida ='" & cmbaño.SelectedItem & "-" & substring & "-" & cmbdia.SelectedItem & "'"
            consultar()
            MsgBox(Consulta)
            dgvregistro.DataSource = Tabla
        End If
    End Sub

    Private Sub registrorevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "Select revistas.id_revistas, revistas.titulo, usuarios.cedula, usuarios.nombre, prestamorevistas.fecha_salida, prestamorevistas.fecha_entrada from revistas inner join prestamorevistas on revistas.id_revistas = prestamorevistas.id_revistas inner join usuarios on usuarios.cedula=prestamorevistas.cedula"
        consultar()
        dgvregistro.DataSource = Tabla
        DatagridModulo = dgvregistro
        Datagrid_Align()
        dgvregistro.Columns(0).HeaderText = "Codigo de Inventario"
        dgvregistro.Columns(1).HeaderText = "Titulo"
        dgvregistro.Columns(2).HeaderText = "Cedula de Socio"
        dgvregistro.Columns(3).HeaderText = "Nombre"
        dgvregistro.Columns(4).HeaderText = "Fecha de Prestamo"
        dgvregistro.Columns(5).HeaderText = "Fecha de Devolucion"
        cmbbusqueda.SelectedIndex = 0


        'Ingresa los datos de Meses al cmbmes
        cmbmes.Items.Add("Enero")
        cmbmes.Items.Add("Febrero")
        cmbmes.Items.Add("Marzo")
        cmbmes.Items.Add("Abril")
        cmbmes.Items.Add("Mayo")
        cmbmes.Items.Add("Junio")
        cmbmes.Items.Add("Julio")
        cmbmes.Items.Add("Agosto")
        cmbmes.Items.Add("Septiembre")
        cmbmes.Items.Add("Octubre")
        cmbmes.Items.Add("Noviembre")
        cmbmes.Items.Add("Diciembre")

        For i As Integer = 1999 To Date.Now.ToString("yyyy")
            If i = 1899 Then
            Else
                cmbaño.Items.Add(i)
            End If
        Next

        cmbaño.SelectedItem = Date.Now.Year
        cmbdia.SelectedItem = Date.Now.Day

        If Date.Now.Month.ToString.Length = 1 Then
            cero = "0" & Date.Now.Month
        End If
        substring = cero
        mes()
        cmbmes.SelectedItem = substring



    End Sub
End Class