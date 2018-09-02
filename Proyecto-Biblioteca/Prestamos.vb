Public Class Prestamos

    '//////////////VARIABLE ESPECIAL PARA REALIZAR CONSULTAS (preguntarle a Gastesi su función)//////////
    Dim z As MsgBoxResult
    Dim h As String
    Dim a As String
    Dim Libro1 As String
    Dim Libro2 As String
    Dim libro3 As String
    Dim cod_libros As String
    Dim cod_libros2 As String
    Dim Contador As Integer = 0
    Dim VALIDADOR As String
    Dim modo As String = "devolucion"
    Dim panelnombre As Integer = 0
    Dim error1 As Integer = 0
    '/////////////////////////////////////////////////////////


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridAGG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ajusta las columnas al tamaño del datagrid
        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        CrearReservacionComboBox.Visible = False
        ButonParaExtreaer.Visible = False
        Label5.Visible = False
        PictureExtraccion.Visible = False
        PictureDevolucion.Visible = False
        PictureCrearReservacion.Visible = False
        PictureReservacion.Visible = False
        Label5.Visible = False
        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////
        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If
        '/////////////////////////////////////////////VARIABLES CON DIA Y HORA////////////////////

    End Sub
    Private Sub ButonLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLiberar.Click

        Dim Es_moroso As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.DataSource = Tabla

        NOMBRE.Text = DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.Item(1, DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.CurrentRow.Index).Value

        '////////////////////////////////

        Es_moroso = MsgBox("Desea que el usuario " & NOMBRE.Text & " deje de ser moroso?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        Try

            If Cedula.Text <> "" Then

                '////////////////////////////////
                If Es_moroso = vbYes Then

                    Consulta = "update usuarios set (tipo = ""libre"") where cedulaU = '" & Cedula.Text & "';"
                    consultar()

                    MsgBox("El usuario " & NOMBRE.Text & " esta libre ahora", Title:="PRESTAMOS")
                Else
                    MsgBox("No se encontraron los datos", Title:="PRESTAMOS")
                End If
                '////////////////////////////////

            Else

                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

            End If

        Catch ex As Exception

            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

        End Try



    End Sub

    Private Sub BotonParaBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParaBuscarCedula.Click

        If panelnombre = 0 Then
            'Se cambia el label solo cuando haya un valor en el textbox CEDULA

            Try

                If Cedula.Text <> "" Then

                    '/////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////
                    Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                    consultar()
                    DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.DataSource = Tabla
                    '///////////////////////////////////////////////////////////////////////////////////////////
                    '//////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////////
                    Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                    consultar()
                    DatagridviewOcultolllllParaFuncionesPrestmolllll.DataSource = Tabla
                    '////////////////////////////////////////////////////////////////////////////////////////////////


                    '/////////////////////////////////////////////////////////////////////////////////////////////
                    '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                    '/////////////////////////////////////////////////////////////////////////////////////////////

                    NOMBRE.Text = DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.Item(1, DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.CurrentRow.Index).Value
                    Label5.Visible = True
                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion.Visible = True
                    PictureDevolucion.Visible = True
                    PictureCrearReservacion.Visible = True
                    PictureReservacion.Visible = True
                    Label5.Visible = True
                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    Aparecer.Enabled = True
                    '/////////////////////////////////////////////////////////////////////////////////////////////

                End If

            Catch ex As Exception




                '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                Label5.Visible = False
                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                Ocultar.Enabled = True
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////


            End Try

        End If

        If panelnombre = 1 Then

            'Se cambia el label solo cuando haya un valor en el textbox CEDULA

            Try

                If Cedula.Text <> "" Then

                    '/////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////
                    Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                    consultar()
                    DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.DataSource = Tabla
                    '///////////////////////////////////////////////////////////////////////////////////////////
                    '//////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////////
                    Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                    consultar()
                    DatagridviewOcultolllllParaFuncionesPrestmolllll.DataSource = Tabla
                    '////////////////////////////////////////////////////////////////////////////////////////////////

                    '/////////////////////////////////////////////////////////////////////////////////////////////
                    '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                    '/////////////////////////////////////////////////////////////////////////////////////////////


                    Label5.Visible = True
                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion.Visible = True
                    PictureDevolucion.Visible = True
                    PictureCrearReservacion.Visible = True
                    PictureReservacion.Visible = True
                    Label5.Visible = True
                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    Ocultar_Aparecer.Enabled = True


                    '/////////////////////////////////////////////////////////////////////////////////////////////

                End If

            Catch ex As Exception




                '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                Label5.Visible = False
                Ocultar.Enabled = True
                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")



                '/////////////////////////////////////////////////////////////////////////////////////////////////////////


            End Try

        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        '///////////////Variables igualdas a hora y fecha////////////////
        Label2.Text = Date.Now.ToString("hh:mm:ss")

        Label4.Text = Date.Now.ToString("yyyy-MM-dd")
        '////////////////////////////////////////////////////////////////


    End Sub

    Private Sub Cedula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If panelnombre = 0 Then
            If e.KeyCode = Keys.Enter Then

                'Se cambia el label solo cuando haya un valor en el textbox CEDULA

                Try

                    If Cedula.Text <> "" Then

                        '/////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////
                        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                        consultar()
                        DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.DataSource = Tabla
                        '///////////////////////////////////////////////////////////////////////////////////////////
                        '//////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////////
                        Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                        consultar()
                        DatagridviewOcultolllllParaFuncionesPrestmolllll.DataSource = Tabla
                        '////////////////////////////////////////////////////////////////////////////////////////////////


                        '/////////////////////////////////////////////////////////////////////////////////////////////
                        '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                        '/////////////////////////////////////////////////////////////////////////////////////////////

                        NOMBRE.Text = DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.Item(1, DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.CurrentRow.Index).Value
                        Label5.Visible = True
                        ExtCombo.Visible = False
                        devoCOMBO.Visible = False
                        ReservacionComboBox.Visible = False
                        PictureExtraccion.Visible = True
                        PictureDevolucion.Visible = True
                        PictureCrearReservacion.Visible = True
                        PictureReservacion.Visible = True
                        Label5.Visible = True
                        CarritoDeLibros.Items.Clear()
                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                        Aparecer.Enabled = True
                        '/////////////////////////////////////////////////////////////////////////////////////////////

                    End If

                Catch ex As Exception




                    '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                    MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion.Visible = False
                    PictureDevolucion.Visible = False
                    PictureCrearReservacion.Visible = False
                    PictureReservacion.Visible = False
                    Label5.Visible = False
                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    Ocultar.Enabled = True
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////


                End Try

            End If
        End If

        If panelnombre = 1 Then
            If e.KeyCode = Keys.Enter Then

                'Se cambia el label solo cuando haya un valor en el textbox CEDULA

                Try

                    If Cedula.Text <> "" Then

                        '/////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////
                        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                        consultar()
                        DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.DataSource = Tabla
                        '///////////////////////////////////////////////////////////////////////////////////////////
                        '//////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////////
                        Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                        consultar()
                        DatagridviewOcultolllllParaFuncionesPrestmolllll.DataSource = Tabla
                        '////////////////////////////////////////////////////////////////////////////////////////////////

                        '/////////////////////////////////////////////////////////////////////////////////////////////
                        '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                        '/////////////////////////////////////////////////////////////////////////////////////////////


                        Label5.Visible = True
                        ExtCombo.Visible = False
                        devoCOMBO.Visible = False
                        ReservacionComboBox.Visible = False
                        PictureExtraccion.Visible = True
                        PictureDevolucion.Visible = True
                        PictureCrearReservacion.Visible = True
                        PictureReservacion.Visible = True
                        Label5.Visible = True
                        CarritoDeLibros.Items.Clear()
                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                        Ocultar_Aparecer.Enabled = True


                        '/////////////////////////////////////////////////////////////////////////////////////////////

                    End If

                Catch ex As Exception




                    '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion.Visible = False
                    PictureDevolucion.Visible = False
                    PictureCrearReservacion.Visible = False
                    PictureReservacion.Visible = False
                    Label5.Visible = False
                    Ocultar.Enabled = True
                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")



                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////


                End Try

            End If
        End If


    End Sub

    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Cedula.AutoCompleteMode = AutoCompleteMode.Suggest
            Cedula.AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim DataCollection As New AutoCompleteStringCollection()
            Consulta = "select cedula from usuarios"
            consultar()
            getData(DataCollection)
            Cedula.AutoCompleteCustomSource = DataCollection
        Catch ex As OutOfMemoryException

        End Try


    End Sub

    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection)
        Try
            For Each row As DataRow In Tabla.Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButonParaExtreaer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButonParaExtreaer.Click
        'Igualamos una variable al valor de la fecha de la tabla, del datagridview oculto
        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow

        Dim list, contador, libros As Integer
        contador = 0

        list = 0
        list = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then
            If (DatagridviewOcultolllllParaFuncionesPrestmolllll.RowCount = 1) Then

                MsgBox("Usted puede retirar un libro ", Title:="PRESTAMO")

                While contador < list
                    contador = Val(contador) + 1

                    'REVISAR ESTO'
                    Consulta = "insert into prestamolibro(cedula,cod_libro,fecha_salida) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Label4.Text + "')"
                    MsgBox(Consulta)
                    consultar()

                    Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                    consultar()

                    libros = libros + 1

                End While

                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                ExtCombo.Visible = False
            End If


        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If


        '/////////////////////CASO DOS///////////////////
        Try
            If Cedula.Text <> "" Then

                If (ROWS.Cells(3).Value.ToString) <> "" Then
                    MsgBox("Usted pude RETIRAR UN LIBREO", Title:="PRESTAMO")

                    While contador < list
                        contador = Val(contador) + 1


                        Consulta = "insert into prestamolibro (cedula, cod_libro, fecha_salida) values ('" & Cedula.Text & "','" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "','" & Label4.Text & "')"
                        consultar()


                        Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                        consultar()

                        libros = libros + 1

                    End While

                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                    ExtCombo.Visible = False
                Else
                    MsgBox("Este usuario no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")

                End If

            Else
                MsgBox("La cedula debe estar ingresada", Title:="PRESTAMOS")
            End If

        Catch ex As Exception
        End Try


        '    1)////////////////////
    End Sub

    Private Sub LIBROSAGG_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CarritoDeLibros.MouseClick

        Dim a1 As String
        Dim Ga1 As String
        Dim MSBOX_Consulta As MsgBoxResult

        Ga1 = CarritoDeLibros.SelectedItem

        MSBOX_Consulta = MsgBox("Desea cancelar la extracción del libro? " & Ga1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If MSBOX_Consulta = vbYes Then

            a1 = InputBox("Ingrese la id del libro para verificar", Title:="PRESTAMO")

            If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(a1)) Then

                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Remove(a1)
                Ga1 = CarritoDeLibros.SelectedItem
                CarritoDeLibros.Items.Remove(Ga1)

            Else
                MsgBox("Error al ingresar la id", Title:="PRESTAMO ERROR")
            End If

        End If

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MSBOX_Consulta As MsgBoxResult
        MSBOX_Consulta = MsgBox("Desea volver al menú de inicio?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If MSBOX_Consulta = vbYes Then
            MENU3.Show()
        End If
    End Sub





    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where cedula= '" & Cedula.Text & "'"
        consultar()
        DataGridAGG.DataSource = Tabla
        modo = "registro"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and p.cedula= '" & Cedula.Text & "'"
        consultar()
        DataGridAGG.DataSource = Tabla
        modo = "devolucion"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim Es_moroso2 As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.DataSource = Tabla

        NOMBRE.Text = DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.Item(1, DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.CurrentRow.Index).Value

        '////////////////////////////////

        Es_moroso2 = MsgBox("Desea volver moroso al usuario " & NOMBRE.Text & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")
        Try

            If Cedula.Text <> "" Then

                '////////////////////////////////
                If Es_moroso2 = vbYes Then

                    Consulta = "update usuarios set (tipo = ""moroso"") where cedulaU = '" & Cedula.Text & "';"
                    consultar()

                    MsgBox("El usuario " & NOMBRE.Text & " es moroso ahora", Title:="PRESTAMOS")
                Else
                    MsgBox("No se encontraron los datos", Title:="PRESTAMOS")
                End If

                '////////////////////////////////

            Else

                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
            End If

        Catch ex As Exception

            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

        End Try

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureExtraccion.Click
        Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
        consultar()
        DatagridviewOcultolllllParaFuncionesPrestmolllll.DataSource = Tabla

        Consulta = "select * from libro where estado = '0'"
        consultar()
        VERLIBROSAGG.DataSource = Tabla
        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        CrearReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If Cedula.Text <> "" Then

            If (DatagridviewOcultolllllParaFuncionesPrestmolllll.RowCount = 1) Then

                ExtCombo.Visible = True

                Consulta = "select * from libro where estado = '0'"
                consultar()
                VERLIBROSAGG.DataSource = Tabla

            End If

        Else
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Try
            If Cedula.Text <> "" Then
                If (ROWS.Cells(3).Value.ToString) <> "" Then
                    ExtCombo.Visible = True

                    Consulta = "select * from libro where estado = '0'"
                    consultar()
                    VERLIBROSAGG.DataSource = Tabla
                Else
                    ExtCombo.Visible = False
                    MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")
                End If

            Else
                MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
            End If
        Catch ex As Exception
        End Try
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    End Sub

    Private Sub PictureBoxParaDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDevolucion.Click


        'Dim ROWS As DataGridView = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow

        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
        consultar()
        DataGridAGG.DataSource = Tabla


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        ReservacionComboBox.Visible = False
        CrearReservacionComboBox.Visible = False



        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If Cedula.Text <> "" Then
            devoCOMBO.Visible = True
            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            DataGridAGG.DataSource = Tabla
        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    End Sub

    Private Sub PictureBoxParaReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureReservacion.Click

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        CrearReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow

        Consulta = "select * from libro where estado = 2"
        consultar()
        VerLibrosReservados.DataSource = Tabla


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        If (DatagridviewOcultolllllParaFuncionesPrestmolllll.RowCount = 1) Then

            ReservacionComboBox.Visible = True

            Consulta = "select * from libro where estado = 2"
            consultar()
            VerLibrosReservados.DataSource = Tabla

        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Try
            If (ROWS.Cells(3).Value.ToString) <> "" Then
                ReservacionComboBox.Visible = True

                Consulta = "select * from libro where estado = 2"
                consultar()
                VerLibrosReservados.DataSource = Tabla
            Else
                ReservacionComboBox.Visible = False
                MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")

            End If
        Catch ex As Exception
        End Try
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    End Sub



    Private Sub PictureBoxCrearReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureCrearReservacion.Click

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'Variable que se iguala al valor del datagridview oculto para hacer ocnsultas
        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow


        Consulta = "select * from libro where estado = '0'"
        consultar()
        LibrosParaReservar.DataSource = Tabla


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            CrearReservacionComboBox.Visible = True

            Consulta = "select * from libro where estado = '0'"
            consultar()

            LibrosParaReservar.DataSource = Tabla

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    End Sub

    Private Sub ButonEliminarReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminarReservacion.Click

        Dim Consulta As String
        Consulta = InputBox("Ingrese la id del libro para eliminar las reservacion", Title:="RESERVACION")
        Try
            If Consulta <> "" Then
                Consulta = "update libro set estado = 0 where cod_libro = '" & Consulta & "'"
                consultar()
                MsgBox("Se a cancelado la reservacion", Title:="PRESTAMO")

                Consulta = "select * from libro where estado = 2"
                consultar()
                VerLibrosReservados.DataSource = Tabla
            Else
                MsgBox("No se cancelo la reservacion del libro", Title:="ERROR RESERVACION")
            End If
        Catch ex As Exception
            MsgBox("Ah ocurrido un error en la eliminación de las reservacion", Title:="ERROR RESERVACION")
        End Try

        Consulta = "select * from libro where estado = 2"
        consultar()
        VerLibrosReservados.DataSource = Tabla
    End Sub

    Private Sub BotonExtrearReservados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonExtrearReservados.Click

        'Igualamos una variable al valor de la tabla, del datagridview oculto
        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow

        Dim list, contador, libros As String
        contador = 0

        list = 0
        list = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count - 1
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then
            If (DatagridviewOcultolllllParaFuncionesPrestmolllll.RowCount = 1) Then

                MsgBox("Este usuario puede retirar un libro", Title:="PRESTAMO")

                While contador < list
                    contador = Val(contador) + 1

                    Consulta = "insert into prestamolibro(cedula,cod:libro,fecha_salida) values ('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Label4.Text + "')"
                    MsgBox(Consulta)
                    consultar()

                    Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                    consultar()

                    libros = libros + 1

                End While

                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                ExtCombo.Visible = False

            End If

        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If

        '/////////////////////CASO DOS///////////////////
        Try
            If Cedula.Text <> "" Then

                If (ROWS.Cells(3).Value.ToString) <> "" Then
                    MsgBox("Usted pude RETIRAR UN LIBREO", Title:="PRESTAMO")

                    While contador < list
                        contador = Val(contador) + 1


                        Consulta = "insert into prestamolibro (cedula, cod_libro, fecha_salida) values ('" & Cedula.Text & "','" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "','" & Label4.Text & "')"
                        consultar()

                        Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                        consultar()

                        libros = libros + 1

                    End While

                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                    ExtCombo.Visible = False
                Else
                    MsgBox("Este usuario no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")

                End If

            Else
                MsgBox("La cedula debe estar ingresada", Title:="PRESTAMOS")
            End If

        Catch ex As Exception
        End Try


    End Sub


    Private Sub VerLibrosReservados_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VerLibrosReservados.CellDoubleClick

        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = VerLibrosReservados.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)


        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count

        If VerLibrosReservados.Item(0, VerLibrosReservados.CurrentRow.Index).Value <> list1 Then
            Dim goku As String
            Dim vegeta As String

            goku = VerLibrosReservados.Item(0, VerLibrosReservados.CurrentRow.Index).Value
            vegeta = VerLibrosReservados.Item(1, VerLibrosReservados.CurrentRow.Index).Value

            If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(goku)) Then

                MsgBox("Este libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then

                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(goku)
                    CarritoDeLibros.Items.Add(goku & "                          " & vegeta)

                End If
            End If
        End If
        If CarritoDeLibros.Items.Count <> 0 Then
            ButonParaExtreaer.Visible = True
        Else
            ButonParaExtreaer.Visible = False
        End If

    End Sub

    Private Sub LIBROS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LIBROS.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Se iguala una variable a un valor de la base de datos
            Dim TransoformarDBSDaVariable As DataGridViewRow = VERLIBROSAGG.CurrentRow
            Dim NOMBREdelLIBRO As String
            NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)

            '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

            Dim list1 As Integer
            list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count

            If VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value <> list1 Then
                Dim goku As String
                Dim vegeta As String
                goku = VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value
                vegeta = VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value

                If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(goku)) Then

                    MsgBox("El libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")
                Else
                    z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                    If z = vbYes Then

                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(goku)
                        CarritoDeLibros.Items.Add(goku & "                          " & vegeta)

                        For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items
                            For Each Row As DataGridViewRow In VERLIBROSAGG.Rows
                                If Row.Cells("cod_libro").Value = Val(item) Then
                                    Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                                End If

                            Next
                        Next

                    End If
                End If
            End If
            If CarritoDeLibros.Items.Count <> 0 Then

                ButonParaExtreaer.Visible = True

            Else

                ButonParaExtreaer.Visible = False

            End If
        End If
    End Sub

    Private Sub LIBROS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIBROS.TextChanged
        Try
            Consulta = "select * from libro where estado = 0 and cod_libro like '" & LIBROS.Text & "%'"
            consultar()
            VERLIBROSAGG.DataSource = Tabla
            For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items
                For Each Row As DataGridViewRow In VERLIBROSAGG.Rows
                    If Row.Cells("cod_libro").Value = Val(item) Then
                        Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                    End If
                Next
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aparecer.Tick
        Try
            If Panel1.Left < -5 Then
                Panel1.Left += 10
            Else
                NOMBRE.Text = DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.Item(1, DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.CurrentRow.Index).Value
                Aparecer.Enabled = False
                panelnombre = 1
            End If
        Catch ex As Exception
            Aparecer.Enabled = False

            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            ReservacionComboBox.Visible = False
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            PictureCrearReservacion.Visible = False
            PictureReservacion.Visible = False
            Label5.Visible = False
            Ocultar.Enabled = True
            MsgBox("La cedula ingresada no es correcta", Title:="Error")

        End Try


    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ocultar.Tick
        If Panel1.Left > -265 Then
            Panel1.Left -= 10
        Else
            Ocultar.Enabled = False

        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ocultar_Aparecer.Tick
        Try
            If Panel1.Left > -265 Then
                Panel1.Left -= 10
            Else
                NOMBRE.Text = DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.Item(1, DataGridViewOcultolllllParaSacarElNombreDelUsuariolllll.CurrentRow.Index).Value
                Aparecer.Enabled = True
                Ocultar_Aparecer.Enabled = False

            End If
        Catch ex As Exception
            Ocultar.Enabled = True
            Ocultar_Aparecer.Enabled = False
            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            ReservacionComboBox.Visible = False
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            PictureCrearReservacion.Visible = False
            PictureReservacion.Visible = False
            Label5.Visible = False
            MsgBox("Error en el ingreso de cedula", Title:="Error")
        End Try

    End Sub

    Private Sub VERLIBROSAGG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellDoubleClick
        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = VERLIBROSAGG.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)


        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count



        If VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value <> list1 Then
            Dim goku As String
            Dim vegeta As String
            goku = VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value
            vegeta = VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value



            If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(goku)) Then

                MsgBox("Este libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then


                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(goku)
                    CarritoDeLibros.Items.Add(goku & "                          " & vegeta)

                    For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items

                        For Each Row As DataGridViewRow In VERLIBROSAGG.Rows
                            If Row.Cells("cod_libro").Value = Val(item) Then
                                Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                            End If

                        Next
                    Next

                End If
            End If
        End If

        If CarritoDeLibros.Items.Count <> 0 Then

            ButonParaExtreaer.Visible = True
        Else
            ButonParaExtreaer.Visible = False

        End If
    End Sub

    Private Sub DataGridAGG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellDoubleClick


        '////////////////////////////////
        '///////7No tiene sentido'//////
        '//////////////////////////////

        If modo = "devolucion" Then
            'Consulta a DATAGRIDVIEW oculto
            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            DataGridAGG.DataSource = Tabla
            'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
            If Cedula.Text <> "" Then
                Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                DataGridAGG.DataSource = Tabla

                consultar()

                '////////////////////////////////

                Try
                    Libro1 = DataGridAGG.Item(2, DataGridAGG.CurrentRow.Index).Value
                    cod_libros = DataGridAGG.Item(1, DataGridAGG.CurrentRow.Index).Value

                    'rEVISAR'
                    If DataGridAGG.Item(4, DataGridAGG.CurrentRow.Index).Value.ToString = "" Then
                        Dim a As MsgBoxResult
                        a = MsgBox("Desea devolver el libro " & Libro1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                        '       1) Si se devuelve el libro y se actualiza la Base da datos 
                        If a = vbYes Then

                            Consulta = "update libro set estado = 0 where cod_libro = '" & cod_libros & "'"
                            consultar()
                            Consulta = "UPDATE prestamolibro SET fecha_entrada = '" & Label4.Text & "' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros & "'"
                            consultar()
                            MsgBox("se ha devuelto", Title:="PRESTAMO")

                            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                            consultar()
                            DataGridAGG.DataSource = Tabla

                        Else

                            MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

                            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                            consultar()
                            DataGridAGG.DataSource = Tabla

                        End If
                    End If

                    If a = vbNo Then
                        MsgBox("No", Title:="PRESTAMOS")
                    End If

                Catch ex As Exception

                    MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

                    Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                    consultar()
                    DataGridAGG.DataSource = Tabla
                End Try
            End If
        End If
    End Sub

    Private Sub LibrosParaReservar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LibrosParaReservar.CellDoubleClick

        'Consulta a DATAGRIDVIEW para ver los libros disponibles
        Consulta = "select * from libro where estado = 0"
        consultar()
        LibrosParaReservar.DataSource = Tabla

        '////////////////////////////////

        'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
        If Cedula.Text <> "" Then
            Consulta = "select * from libro where estado = 0"
            LibrosParaReservar.DataSource = Tabla
            consultar()

            '////////////////////////////////

            Try

                libro3 = LibrosParaReservar.Item(1, LibrosParaReservar.CurrentRow.Index).Value
                cod_libros2 = LibrosParaReservar.Item(0, LibrosParaReservar.CurrentRow.Index).Value

                Dim a As MsgBoxResult
                a = MsgBox("Desea reservar el libro " & libro3 & " ?", MsgBoxStyle.YesNo, Title:="RESERVACION")

                '       1) Si se devuelve el libro y se actualiza la Base da datos 
                If a = vbYes Then

                    Consulta = "update libro set estado = 2 where cod_libro = '" & cod_libros2 & "'"
                    consultar()

                    '///A REVISAR////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    Consulta = "UPDATE prestamolibro SET reservacion = 'Reservado' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros2 & "'"
                    consultar()
                    MsgBox("se ha creador la reservacion", Title:="PRESTAMO")
                    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Consulta = "select * from libro where estado = 0"
                    LibrosParaReservar.DataSource = Tabla
                    consultar()

                Else

                    MsgBox("El libro sigue reservado", Title:="RESERVACION")

                    Consulta = "select * from libro where estado = 0"
                    LibrosParaReservar.DataSource = Tabla
                    consultar()
                End If


                If a = vbNo Then
                    MsgBox("No", Title:="RESERVACION")
                End If

            Catch ex As Exception

                MsgBox("El libro sigue reservado", Title:="RESERVACION")

            End Try
        End If

        Consulta = "select * from libro where estado = 0"
        LibrosParaReservar.DataSource = Tabla
        consultar()

        '/////////////////////////////////////////////////
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Consulta = "select * from libro where estado = 0 and cod_libro like '" & TextBox3.Text & "%'"
        consultar()
        LibrosParaReservar.DataSource = Tabla
        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow
    End Sub

    Private Sub PictureExtraccion1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureExtraccion.MouseHover
        '////A Revisar///////////////
        'PictureExtraccion1.Image = Image.FromFile("C:\Users\Cristina.DESKTOP-QPL135E\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\Resources\devolcion.png")

    End Sub

    Private Sub DataGridAGG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellContentClick

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class