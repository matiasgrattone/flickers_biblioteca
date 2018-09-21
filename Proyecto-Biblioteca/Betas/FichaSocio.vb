Public Class FichaSocio
    Public FichaCedulaSocio As String

    Private Sub RegistroSocio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Consulta = "SELECT cedula, cod_libro, fecha_salida as 'Fecha Salida', fecha_entrada as 'Fecha Entrada', cod_prestado as 'Funcionario Prestamo', cod_devuelto as 'Funcionario Devuelto' FROM prestamolibro WHERE cedula = '" & FichaCedulaSocio & "'"
        consultar()
        DataGridView1.DataSource = Tabla
        DatagridModulo = DataGridView1
        Datagrid_Align()
        DataGridView1.Columns(0).HeaderText = "Nº de Inventario"



        Consulta = "select cedula , nombre , apellido , direccion , mail , moroso from usuarios where cedula = '" & FichaCedulaSocio & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            LabelCedulatxt.Text = row("cedula").ToString.Substring(0, 1) & "." & row("cedula").ToString.Substring(1, 3) & "." & row("cedula").ToString.Substring(4, 3) & "-" & row("cedula").ToString.Substring(7, 1)

            LabelDirecciontxt.Text = row("direccion")
            LabelNombretxt.Text = row("nombre") & " " & row("apellido")
            If row("mail") Is DBNull.Value Then
            Else
                LabelMailtxt.Text = row("mail")
            End If
            If row("moroso") = 0 Then
                PictureBoxEstado.Image = Image.FromFile("imagenes\checked.png")
            Else
                PictureBoxEstado.Image = Image.FromFile("imagenes\delete.png")
            End If
        Next

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
        substring = Date.Now.ToString("MM")
        mes()
        cmbmes.SelectedItem = substring

        For i As Integer = 1899 To Date.Now.ToString("yyyy")
            If i = 1899 Then
                cmbaño.Items.Add("Año")
            Else
                cmbaño.Items.Add(i)
            End If
            cmbaño.SelectedItem = i
        Next

        For i As Integer = 0 To 31
            If i = 0 Then
                cmbdia.Items.Add("Dia")
            Else
                cmbdia.Items.Add(i)
            End If

        Next

        cmbdia.SelectedText = Date.Now.ToString("dd")

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Consulta = "select prestamolibro.cod_libro , libro.titulo from prestamolibro inner join libro on prestamolibro.cod_libro = libro.cod_libro where cedula = '" & FichaCedulaSocio & "' and fecha_entrada is NULL"
        consultar()
        ListBoxLibros.Items.Clear()
        For Each row As DataRow In Tabla.Rows
            ListBoxLibros.Items.Add(row("titulo"))
        Next
    End Sub
End Class