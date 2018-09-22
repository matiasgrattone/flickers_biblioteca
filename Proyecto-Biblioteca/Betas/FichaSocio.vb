Public Class FichaSocio
    Public FichaCedulaSocio As String

    Private Sub RegistroSocio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Consulta = "select prestamolibro.cod_libro , libro.titulo from prestamolibro inner join libro on prestamolibro.cod_libro = libro.cod_libro where cedula = '" & FichaCedulaSocio & "' and fecha_entrada is NULL"
        consultar()
        ListBoxLibros.Items.Clear()
        For Each row As DataRow In Tabla.Rows
            ListBoxLibros.Items.Add(row("titulo"))
        Next

        Consulta = "SELECT concat(usuarios1.nombre,' ',usuarios1.apellido) as 'Nombre Socio', `cod_libro`, fecha_salida as 'Fecha Prestamo', `fecha_entrada`, concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE 1"
        consultar()
        DataGridView1.DataSource = Tabla
        DatagridModulo = DataGridView1
        Datagrid_Align()

        DataGridView1.Columns(1).HeaderText = "Nº de Inventario"
        DataGridView1.Columns(3).HeaderText = "Fecha Devoluciòn"
        DataGridView1.Columns(5).HeaderText = "Funcionario Devoluciòn"

        Consulta = "select cedula , nombre , apellido , direccion , mail , moroso , tipo , fecha_moroso from usuarios where cedula = '" & FichaCedulaSocio & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            LabelCedulatxt.Text = row("cedula").ToString.Substring(0, 1) & "." & row("cedula").ToString.Substring(1, 3) & "." & row("cedula").ToString.Substring(4, 3) & "-" & row("cedula").ToString.Substring(7, 1)
            Select Case row("tipo")
                Case 0
                    Label_TIPO_txt.Text = "Administrador"
                Case 1
                    Label_TIPO_txt.Text = "Funcionario"
                Case 2
                    Label_TIPO_txt.Text = "Socio"
            End Select
            LabelDirecciontxt.Text = row("direccion")
            LabelNombretxt.Text = row("nombre") & " " & row("apellido")
            If row("mail") Is DBNull.Value Then
            Else
                LabelMailtxt.Text = row("mail")
            End If
            If row("fecha_moroso") Is DBNull.Value Then
            Else
                LabelFechaUltimaVez.Text = row("fecha_moroso")
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