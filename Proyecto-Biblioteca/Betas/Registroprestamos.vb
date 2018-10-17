Public Class Registroprestamos
    Dim cero As String
    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        Select Case cmbbusqueda.SelectedIndex
            Case 0
                Dim mesdesde, meshasta As String
                If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                    substring = cmbmes.SelectedItem.ToString
                    mestonum()
                    mesdesde = substring
                    substring = cmbmes2.SelectedItem.ToString
                    mestonum()
                    meshasta = substring

                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and usuarios.cedula like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla

                Else
                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where usuarios.cedula like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case 1
                Dim mesdesde, meshasta As String
                If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                    substring = cmbmes.SelectedItem.ToString
                    mestonum()
                    mesdesde = substring
                    substring = cmbmes2.SelectedItem.ToString
                    mestonum()
                    meshasta = substring

                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and usuarios.nombre like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where usuarios.nombre like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If
            Case 2
                Dim mesdesde, meshasta As String
                If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                    substring = cmbmes.SelectedItem.ToString
                    mestonum()
                    mesdesde = substring
                    substring = cmbmes2.SelectedItem.ToString
                    mestonum()
                    meshasta = substring
                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and libro.cod_libro like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                Else
                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where libro.titulo like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If
            Case 3
                Dim mesdesde, meshasta As String
                If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                    substring = cmbmes.SelectedItem.ToString
                    mestonum()
                    mesdesde = substring
                    substring = cmbmes2.SelectedItem.ToString
                    mestonum()
                    meshasta = substring
                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and libro.titulo like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla

                Else
                    Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where libro.titulo like '" & txtbusqueda.Text & "%'"
                    consultar()
                    dgvregistro.DataSource = Tabla
                End If

            Case Else

                Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula"
                consultar()
                dgvregistro.DataSource = Tabla
        End Select
    End Sub

    Private Sub cmbdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If cmbdia.SelectedItem.ToString.Length = 1 Then
            cero = "0" & cmbdia.SelectedItem
        End If
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmes.SelectedIndexChanged
        substring = cmbmes.SelectedItem
        mestonum()
    End Sub

    Private Sub registroprestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula"
        consultar()
        dgvregistro.DataSource = Tabla
        DatagridModulo = dgvregistro
        Datagrid_Align()
        dgvregistro.Columns(0).HeaderText = "Codigo de inventario"
        dgvregistro.Columns(1).HeaderText = "Titulo"
        dgvregistro.Columns(2).HeaderText = "Cedula de Socio"
        dgvregistro.Columns(3).HeaderText = "Nombre"
        dgvregistro.Columns(4).HeaderText = "Fecha de Prestamo"
        dgvregistro.Columns(5).HeaderText = "Fecha de Devolucion"
        dgvregistro.Columns(6).HeaderText = "Quien Presta"
        dgvregistro.Columns(7).HeaderText = "Quien Recibe"

        cmbbusqueda.SelectedIndex = 0

        'Ingresa los dias a cmbdia
        For i As Integer = 0 To 31
            If i = 0 Then
                cmbdia.Items.Add("Dia")
                cmbdia.SelectedIndex = 0
            Else
                cmbdia.Items.Add(i)
            End If
        Next

        'Ingresa los datos de Meses al cmbmes
        cmbmes.Items.Add("Mes")
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
        cmbmes.SelectedIndex = 0

        'Ingresa los datos cmbaño2
        For i As Integer = 1999 To Date.Now.ToString("yyyy")
            If i = 1999 Then
                cmbaño.Items.Add("Año")
                cmbaño.SelectedIndex = 0
            Else
                cmbaño.Items.Add(i)
            End If
        Next
        '//////////////////////////////////////////////////////

        'Ingresa los dias a cmbdia2
        For i As Integer = 0 To 31
            If i = 0 Then
                cmbdia2.Items.Add("Dia")
                cmbdia2.SelectedIndex = 0
            Else
                cmbdia2.Items.Add(i)
            End If
        Next

        'Ingresa los datos de Meses al cmbmes2
        cmbmes2.Items.Add("Mes")
        cmbmes2.Items.Add("Enero")
        cmbmes2.Items.Add("Febrero")
        cmbmes2.Items.Add("Marzo")
        cmbmes2.Items.Add("Abril")
        cmbmes2.Items.Add("Mayo")
        cmbmes2.Items.Add("Junio")
        cmbmes2.Items.Add("Julio")
        cmbmes2.Items.Add("Agosto")
        cmbmes2.Items.Add("Septiembre")
        cmbmes2.Items.Add("Octubre")
        cmbmes2.Items.Add("Noviembre")
        cmbmes2.Items.Add("Diciembre")
        cmbmes2.SelectedIndex = 0

        'Ingresa los datos cmbaño2
        For i As Integer = 1999 To Date.Now.ToString("yyyy")
            If i = 1999 Then
                cmbaño2.Items.Add("Año")
                cmbaño2.SelectedIndex = 0
            Else
                cmbaño2.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub cmbmes2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmes2.SelectedIndexChanged
        substring = cmbmes2.SelectedItem
        mestonum()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtbusqueda.Text <> "" Then
            Select cmbbusqueda.SelectedIndex
                Case 0
                    Dim mesdesde, meshasta As String
                    If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                        substring = cmbmes.SelectedItem.ToString
                        mestonum()
                        mesdesde = substring
                        substring = cmbmes2.SelectedItem.ToString
                        mestonum()
                        meshasta = substring

                        Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and usuarios.cedula like '" & txtbusqueda.Text & "%'"
                        consultar()
                        dgvregistro.DataSource = Tabla
                    End If
                Case 1
                    Dim mesdesde, meshasta As String
                    If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                        substring = cmbmes.SelectedItem.ToString
                        mestonum()
                        mesdesde = substring
                        substring = cmbmes2.SelectedItem.ToString
                        mestonum()
                        meshasta = substring

                        Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and usuarios.nombre like '" & txtbusqueda.Text & "%'"
                        consultar()
                        dgvregistro.DataSource = Tabla
                    End If
                Case 2
                    Dim mesdesde, meshasta As String
                    If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                        substring = cmbmes.SelectedItem.ToString
                        mestonum()
                        mesdesde = substring
                        substring = cmbmes2.SelectedItem.ToString
                        mestonum()
                        meshasta = substring
                        Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and libro.cod_libro like '" & txtbusqueda.Text & "%'"
                        consultar()
                        dgvregistro.DataSource = Tabla
                    End If
                Case 3
                    Dim mesdesde, meshasta As String
                    If cmbdia.Text <> "Dia" And cmbmes.Text <> "Mes" And cmbaño.Text <> "Año" And cmbdia2.Text <> "Dia" And cmbmes2.Text <> "Mes" And cmbaño2.Text <> "Año" Then
                        substring = cmbmes.SelectedItem.ToString
                        mestonum()
                        mesdesde = substring
                        substring = cmbmes2.SelectedItem.ToString
                        mestonum()
                        meshasta = substring
                        Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "' and libro.titulo like '" & txtbusqueda.Text & "%'"
                        consultar()
                        dgvregistro.DataSource = Tabla
                    End If
            End Select

        Else

            Dim mesdesde, meshasta As String
            If cmbdia.Text <> "" And cmbmes.Text <> "" And cmbaño.Text <> "" And cmbdia2.Text <> "" And cmbmes2.Text <> "" And cmbaño2.Text <> "" Then
                substring = cmbmes.SelectedItem.ToString
                mestonum()
                mesdesde = substring
                substring = cmbmes2.SelectedItem.ToString
                mestonum()
                meshasta = substring
                Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where prestamolibro.fecha_salida >= '" & cmbaño.SelectedItem & "-" & mesdesde & "-" & cmbdia.SelectedItem & "' and prestamolibro.fecha_salida <= '" & cmbaño2.SelectedItem & "-" & meshasta & "-" & cmbdia2.SelectedItem & "'"
                consultar()
                dgvregistro.DataSource = Tabla
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtbusqueda.Clear()

        cmbbusqueda.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbdia2.SelectedIndex = 0
        cmbmes.SelectedIndex = 0
        cmbmes2.SelectedIndex = 0
        cmbaño.SelectedIndex = 0
        cmbaño2.SelectedIndex = 0


        Consulta = "Select libro.cod_libro,libro.titulo, usuarios.cedula, usuarios.nombre, prestamolibro.fecha_salida, prestamolibro.fecha_entrada, prestamolibro.cod_prestado, prestamolibro.cod_devuelto from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula"
        consultar()
        dgvregistro.DataSource = Tabla
    End Sub

    Private Sub cmbbusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbusqueda.SelectedIndexChanged
        Select Case cmbbusqueda.SelectedIndex
            Case 0
                txtbusqueda.Text = ""
            Case 1
                txtbusqueda.Text = ""
            Case 2
                txtbusqueda.Text = ""
        End Select
    End Sub
End Class