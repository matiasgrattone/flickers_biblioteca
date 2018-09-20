Public Class RegistroSocio
    Public FichaCedulaSocio As String

    Private Sub RegistroSocio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Consulta = "select * from prestamolibro where cedula = '" & FichaCedulaSocio & "'"
        consultar()
        DataGridView1.DataSource = Tabla
        DatagridModulo = DataGridView1
        Datagrid_Align()



        Consulta = "select cedula , nombre , apellido , direccion , mail from usuarios where cedula = '" & FichaCedulaSocio & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            LabelCedulatxt.Text = row("cedula")
            LabelApellidotxt.Text = row("apellido")
            LabelDirecciontxt.Text = row("direccion")
            LabelNombretxt.Text = row("nombre")
            LabelMailtxt.Text = row("mail")
        Next


        Consulta = "select prestamolibro.cod_libro , libro.titulo from prestamolibro inner join libro on prestamolibro.cod_libro = libro.cod_libro where cedula = '" & FichaCedulaSocio & "' and fecha_entrada is NULL"
        consultar()
        ListBoxLibros.Items.Clear()
        For Each row As DataRow In Tabla.Rows
            ListBoxLibros.Items.Add(row("titulo"))
        Next
    End Sub
End Class