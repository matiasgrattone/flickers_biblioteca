Public Class FichaParaImprimirNumero2


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim contador As Integer = 0


        Consulta = "SELECT concat(usuarios1.nombre,' ',usuarios1.apellido) as 'Nombre Socio', `cod_libro` as 'Numero de inventario', fecha_salida as 'Fecha del prestamo', `fecha_entrada` as 'Fecha de devoluciòn', concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaSocio.FichaCedulaSocio & "' and year(fecha_salida) = '" & FichaSocio.cmbaño.SelectedItem & "' and month(fecha_salida) = '" & substring & "'"
        consultar()
        DataGridViewRegistro.DataSource = Tabla

        DatagridModulo = DataGridViewRegistro
        Datagrid_Align()
        Try
            If DataGridViewRegistro.RowCount > 47 Then
                While contador <> 48
                    contador = contador + 1

                    If contador <> 48 Then
                        DataGridViewRegistro.Rows(contador).Visible = False
                    End If

                End While


                DataGridViewRegistro.Rows(0).Visible = False
            End If

            With PrintForm1
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
            End With
            PrintForm1.Print()
            Me.Close()

        Catch ex As Exception
            Me.Close()
        End Try

    End Sub
End Class