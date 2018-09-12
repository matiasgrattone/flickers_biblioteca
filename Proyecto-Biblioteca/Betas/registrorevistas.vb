Public Class registrorevistas

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        Select Case cmbbusqueda.SelectedIndex
            Case 0
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where usuarios.cedula like '" & txtbusqueda.Text & "%' and prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where usuarios.cedula like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 1
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where usuarios.nombre like '" & txtbusqueda.Text & "%' and prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where usuarios.nombre like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 2
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where libro.cod_libro like '" & txtbusqueda.Text & "%' and prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where libro.cod_libro like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 3
                If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where libro.titulo like '" & txtbusqueda.Text & "%' and prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where libro.titulo like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case Else

                Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where libro.titulo like '" & txtbusqueda.Text & "%'"
                consultar()
                dgvregistro.DataSource = Tabla


        End Select
    End Sub

    Private Sub cmbbusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbusqueda.SelectedIndexChanged

    End Sub

    Private Sub cmbdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then

            Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
            consultar()
            dgvregistro.DataSource = Tabla

        Else
            Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where libro.titulo like '" & txtbusqueda.Text & "%'"
            consultar()
            dgvregistro.DataSource = Tabla
        End If
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmes.SelectedIndexChanged
        If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then

            Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
            consultar()
            dgvregistro.DataSource = Tabla

        End If
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaño.SelectedIndexChanged
        If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" Then

            Consulta = "Select libro.cod_libro, libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula=prestamolibro.cedula where prestamolibro.fecha_salida ='" & cmbaño.SelectedItem + "-" + cmbmes.SelectedItem + "-" + cmbdia.SelectedItem & "'"
            consultar()
            dgvregistro.DataSource = Tabla

        End If
    End Sub
End Class