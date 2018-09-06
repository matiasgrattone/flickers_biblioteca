Public Class IngresoRevistas
    Dim idlibro As Integer '//////////////// VARIABLE QUE VA A CONTENER EL ID DE LIBRO /////////////////////// Esto no se esta utiizando
    Dim cod As Integer = 0
    Dim bandera As Integer
    Dim primeringreso As Integer = 0
    Dim contadoringreso As Integer = 0
    Private Sub IngresoRevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Comprobacion'
        Consulta = "select * from usuarios"
        consultar()
        dgvcomprobar.DataSource = Tabla
        Try
            If dgvcomprobar.Item(0, dgvcomprobar.CurrentRow.Index).Value <> 0 Then
                bandera = 1
            Else
                bandera = 0
            End If
        Catch ex1 As Exception
            MsgBox("Base de datos no disponible")
        End Try


        If bandera = 1 Then

            Dim contadoringreso As Integer = 0
            Consulta = "select titulo,anio,origen,descripcion from revistas"
            consultar()
            dgvrevistas.DataSource = Tabla
            DatagridModulo = dgvrevistas
            Datagrid_Align()
            dgvrevistas.Columns(0).HeaderText = "Titulo"
            dgvrevistas.Columns(1).HeaderText = "Año"
            dgvrevistas.Columns(2).HeaderText = "Pais de Origen"
            dgvrevistas.Columns(3).HeaderText = "Descripcion"

        Else
            txttitulo.ReadOnly = True
            txtorigenr.ReadOnly = True
            txtanior.ReadOnly = True
            txtdescripcion.ReadOnly = True
        End If
    End Sub

    Private Sub btningresarrevista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarrevista.Click
        If bandera = 1 Then
            If Trim(txttitulo.Text) = "" Then
                ErrorProvider1.SetError(txttitulo, "El campo se encuentra vacio")
                contadoringreso = contadoringreso + 1
            End If
            If Trim(txtanior.Text) = "" Then
                ErrorProvider1.SetError(txtanior, "El campo se encuentra vacio")
                contadoringreso = contadoringreso + 1
            End If
            If Trim(txtorigenr.Text) = "" Then
                ErrorProvider1.SetError(txtorigenr, "El campo se encuentra vacio")
                contadoringreso = contadoringreso + 1
            End If
            If Trim(txtdescripcion.Text) = "" Then
                ErrorProvider1.SetError(txtdescripcion, "El campo se encuentra vacio")
                contadoringreso = contadoringreso + 1
            End If

            '//////////////////////////////////////////////////////////////////////
            '//////////////////////Error provider2, Pruebas////////////////////////
            '//////////////////////////////////////////////////////////////////////
            'Buscar la forma de tirar un error utilizando el error provider
            'De tal modo que si el texto ingresado en el textbox es erroneo
            'Se emita el mensaje
            '///////////////////////////////////////////////////////////////////////


            If contadoringreso <> 0 Then
                contadoringreso = 0
                primeringreso = 1
            Else

                Try

                    Consulta = "insert into revistas(titulo,anio,origen,descripcion,estado) values ('" & txttitulo.Text & "', '" & txtanior.Text & "','" + txtorigenr.Text + "','" + txtdescripcion.Text + "', '0')"
                    consultar()


                    Consulta = "select titulo,anio,origen,descripcion from revistas"
                    consultar()
                    dgvrevistas.DataSource = Tabla
                    'DatagridModulo = dgvrevistas
                    'Datagrid_Align()

                    primeringreso = 0
                    ErrorProvider1.SetError(txttitulo, "")
                    ErrorProvider1.SetError(txtorigenr, "")
                    ErrorProvider1.SetError(txtanior, "")
                    ErrorProvider1.SetError(txtdescripcion, "")

                    txttitulo.Clear()
                    txtorigenr.Clear()
                    txtanior.Clear()
                    txtdescripcion.Clear()
                    MsgBox("Se ha ingresado la revista en el inventario")
                Catch ex As Exception
                    MsgBox("Hola")
                End Try
            End If

        Else

            

            MsgBox("Accion Imposible de Realizar, No se ha encontrado la base de datos")
        End If
    End Sub

    Private Sub txttitulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttitulo.TextChanged
        'Activa el mensaje de error al fallar el ingreso.
        If primeringreso = 1 Then
            If txttitulo.Text = "" Then
                ErrorProvider1.SetError(txttitulo, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txttitulo, "")
            End If
        End If
    End Sub

    Private Sub txtanior_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanior.TextChanged
        If primeringreso = 1 Then
            If txtanior.Text = "" Then
                ErrorProvider1.SetError(txtanior, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtanior, "")
            End If
        End If
    End Sub

    Private Sub txtorigenr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtorigenr.TextChanged
        If primeringreso = 1 Then
            If txtorigenr.Text = "" Then
                ErrorProvider1.SetError(txtorigenr, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtorigenr, "")
            End If
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged
        If primeringreso = 1 Then
            If txtdescripcion.Text = "" Then
                ErrorProvider1.SetError(txtdescripcion, "El campo se encuentra vacio")
            Else
                'En caso de escribir algo en el textbox este se desactiva
                ErrorProvider1.SetError(txtdescripcion, "")
            End If
        End If
    End Sub
End Class