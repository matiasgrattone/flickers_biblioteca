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




        Consulta = "select prestamolibro.cod_libro , libro.titulo from prestamolibro inner join libro on prestamolibro.cod_libro = libro.cod_libro where cedula = '" & FichaCedulaSocio & "' and fecha_entrada is NULL"
        consultar()
        ListBoxLibros.Items.Clear()
        For Each row As DataRow In Tabla.Rows
            ListBoxLibros.Items.Add(row("titulo"))
        Next
    End Sub
End Class