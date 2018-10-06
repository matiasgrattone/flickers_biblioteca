Public Class FichaParaImprimir


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Consulta = "SELECT `cod_libro` as 'Numero de inventario', fecha_salida as 'Fecha Prestamo', `fecha_entrada` as 'Fecha devolucion', concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaSocio.FichaCedulaSocio & "'"
        consultar()
        DataGridViewRegistro.DataSource = Tabla


        DatagridModulo = DataGridViewRegistro
        Datagrid_Align()

        Consulta = "SELECT nombre,apellido FROM usuarios WHERE cedula ='" + FichaSocio.FichaCedulaSocio + "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            LabelNombreSocio.Text = row("nombre") + " " + row("apellido")
            LabelNombreSocio.Text = LabelNombreSocio.Text + "  CI:" + FichaSocio.FichaCedulaSocio.ToString
        Next
        LabelFecha.Text = Date.Now.ToString("yyyy-MM-dd")
        LabelFecha.Text = "Fecha:" + LabelFecha.Text

        With PrintForm1
            .PrintAction = Printing.PrintAction.PrintToFile
            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        End With
        PrintForm1.Print()

        'Vista previa de impresión'

    End Sub
End Class