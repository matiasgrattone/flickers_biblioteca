Public Class FichaParaImprimir2


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SegundaParte As Integer
        Consulta = "SELECT count(*) as 'Cuantos' FROM prestamolibro WHERE cedula = '" & FichaSocio.FichaCedulaSocio & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            SegundaParte = row("Cuantos")
        Next

        'Consulta = "SELECT `cod_libro` as 'Numero de inventario', fecha_salida as 'Fecha Prestamo', `fecha_entrada` as 'Fecha devolucion', concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaSocio.FichaCedulaSocio & "'"
        'consultar()
        'DataGridViewRegistro.DataSource = Tabla

        substring = FichaSocio.cmbmes.SelectedItem
        mestonum()
        Consulta = "SELECT concat(usuarios1.nombre,' ',usuarios1.apellido) as 'Nombre Socio', `cod_libro` as 'Numero de inventario', fecha_salida as 'Fecha del prestamo', `fecha_entrada` as 'Fecha de devoluciòn', concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaSocio.FichaCedulaSocio & "' and year(fecha_salida) = '" & FichaSocio.cmbaño.SelectedItem & "' and month(fecha_salida) = '" & substring & "'"
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
        Try
            With PrintForm1
                .PrintAction = Printing.PrintAction.PrintToPreview
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
            End With
            PrintForm1.Print()
            If SegundaParte > 47 Then
                FichaParaImprimirNumero2.Show()
                FichaParaImprimirNumero2.Hide()
            End If
            Me.Close()

        Catch ex As Exception

            Me.Close()
        End Try
    End Sub

End Class