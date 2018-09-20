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

    '/////////////////////////////////////////////////////////


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridParaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ajusta las columnas al tamaño del datagrid
        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        CrearReservacionComboBox.Visible = False
        ButonParaExtreaer.Visible = False
        LabelSELECCION_DE_FUNCION.Visible = False
        PictureExtraccion.Visible = False
        PictureDevolucion.Visible = False
        PictureCrearReservacion.Visible = False
        PictureReservacion.Visible = False
        LabelCI.Visible = False
        LabelParaAlmacenarLaCedulaIngresada.Visible = False
        ButtonLiberar.Visible = False
        ButtonMoroso.Visible = False
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
        For Each row As DataRow In Tabla.Rows
            NOMBRE.Text = row("nombre")
        Next

        '////////////////////////////////

        Es_moroso = MsgBox("Desea que el usuario " & NOMBRE.Text & " deje de ser moroso?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        Try

            If Cedula.Text <> "" Then

                '////////////////////////////////
                If Es_moroso = vbYes Then

                    Consulta = "update usuarios set (tipo = ""0"") where cedulaU = '" & Cedula.Text & "';"
                    consultar()

                    MsgBox("El socios " & NOMBRE.Text & " esta libre ahora", Title:="PRESTAMOS")
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
    Dim errorcedula As Integer = 0

    Private Sub BotonParaBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParaBuscarCedula.Click

        'Se cambia el label solo cuando haya un valor en el textbox CEDULA


        If Cedula.Text = "" Then
            '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            ReservacionComboBox.Visible = False
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            PictureCrearReservacion.Visible = False
            PictureReservacion.Visible = False
            LabelCI.Visible = False
            LabelParaAlmacenarLaCedulaIngresada.Visible = False
            LabelParaAlmacenarLaCedulaIngresada.Text = ""
            LabelSELECCION_DE_FUNCION.Visible = False
            CarritoDeLibros.Items.Clear()
            ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
            PanelDelCarrito.Left = -268
            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
            '/////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else


            Consulta = "select cedula from usuarios where cedula like '" & Cedula.Text & "'"
            consultar()

            If Tabla.Rows.Count = 0 Then ' VERFICAR SI ES NULO EL RESULTADO DE LA CONSULTA
                '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                LabelCI.Visible = False
                LabelParaAlmacenarLaCedulaIngresada.Visible = False
                LabelParaAlmacenarLaCedulaIngresada.Text = ""
                LabelSELECCION_DE_FUNCION.Visible = False
                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                PanelDelCarrito.Left = -268
                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////
            Else



                Consulta = "select cedula , nombre , tipo from usuarios where cedula like '" & Cedula.Text & "'"
                consultar()
                Try
                    For Each row As DataRow In Tabla.Rows
                        NOMBRE.Text = row("nombre")
                        Label12.Text = row("tipo")
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                '/////////////////////////////////////////////////////////////////////////////////////////////
                '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                '/////////////////////////////////////////////////////////////////////////////////////////////

                LabelSELECCION_DE_FUNCION.Visible = True
                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False
                PictureExtraccion.Visible = True
                PictureDevolucion.Visible = True
                PictureCrearReservacion.Visible = True
                PictureReservacion.Visible = True
                LabelCI.Visible = True
                LabelParaAlmacenarLaCedulaIngresada.Visible = True
                '///////////////////LABEL PARA HACER LAS FUNCIONES CON LA CEDULA///////////////////////////
                LabelParaAlmacenarLaCedulaIngresada.Text = Cedula.Text
                '/////////////////////////////////////////////////////////////////////////////////////////
                LabelSELECCION_DE_FUNCION.Visible = True
                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                PanelDelCarrito.Left = -5

                If Label12.Text = 2 Then
                    ButtonLiberar.Visible = True
                ElseIf Label12.Text = 0 Then
                    ButtonMoroso.Visible = True
                End If
                '/////////////////////////////////////////////////////////////////////////////////////////////

            End If

        End If

    End Sub



    'Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cedula.TextChanged

    '    Try
    '        Cedula.AutoCompleteMode = AutoCompleteMode.Suggest
    '        Cedula.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        Dim DataCollection As New AutoCompleteStringCollection()
    '        Consulta = "select cedula from usuarios"
    '        consultar()
    '        getData(DataCollection)
    '        Cedula.AutoCompleteCustomSource = DataCollection

    '    Catch ex As OutOfMemoryException

    '    End Try


    'End Sub

    'Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection)
    '    Try
    '        For Each row As DataRow In Tabla.Rows
    '            dataCollection.Add(row(0).ToString())
    '        Next
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub ButonParaExtreaer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButonParaExtreaer.Click

        Dim list, contador, libros As Integer
        contador = 0

        list = 0
        list = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then



            Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
            consultar()

            If (Tabla.Rows.Count = 0) Then

                While contador < list
                    contador = Val(contador) + 1

                    'REVISAR ESTO'
                    Consulta = "insert into prestamolibro(cedula,cod_libro,fecha_salida) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "')"
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


                For Each row As DataRow In Tabla.Rows
                    If row("fecha_entrada") Is DBNull.Value Then
                        FechaEntradaPrestamo = 0
                    Else
                        FechaEntradaPrestamo = 1
                    End If
                Next

                Select Case FechaEntradaPrestamo
                    Case 1

                        While contador < list
                            contador = Val(contador) + 1


                            Consulta = "insert into prestamolibro (cedula, cod_libro, fecha_salida) values ('" & Cedula.Text & "','" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "','" & Date.Now.ToString("yyyy-MM-dd") & "')"
                            consultar()


                            Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                            consultar()

                            libros = libros + 1

                        End While

                        CarritoDeLibros.Items.Clear()
                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                        MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                        ExtCombo.Visible = False


                    Case 0

                        MsgBox("Este socios no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")
                End Select
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where cedula= '" & Cedula.Text & "'"
        consultar()
        DataGridParaDevolucion.DataSource = Tabla
        modo = "registro"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and p.cedula= '" & Cedula.Text & "'"
        consultar()
        DataGridParaDevolucion.DataSource = Tabla
        modo = "devolucion"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMoroso.Click

        Dim Es_moroso2 As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        For Each row As DataRow In Tabla.Rows
            NOMBRE.Text = row("nombre")
        Next

        '////////////////////////////////

        Es_moroso2 = MsgBox("Desea volver moroso al socios " & NOMBRE.Text & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        Try

            If Cedula.Text <> "" Then

                '////////////////////////////////
                If Es_moroso2 = vbYes Then

                    Consulta = "update usuarios set (tipo = ""2"") where cedulaU = '" & Cedula.Text & "';"
                    consultar()

                    MsgBox("El socios " & NOMBRE.Text & " es moroso ahora", Title:="PRESTAMOS")
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
    Dim FechaEntradaPrestamo As Integer
    Private Sub PictureBoxDeExtraccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureExtraccion.Click

        If CarritoDeLibros.Items.Count = 0 Then

            If Cedula.Text <> "" Then


                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False
                CrearReservacionComboBox.Visible = False
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                Consulta = "select * from prestamolibro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                If (Tabla.Rows.Count = 0) Then
                    ExtCombo.Visible = True
                    Consulta = "select * from libro where estado = '0'"
                    consultar()
                    DataGridViewlllllVerLibrosEnExtraccionlllll.DataSource = Tabla
                Else

                    For Each row As DataRow In Tabla.Rows
                        If row("fecha_entrada") Is DBNull.Value Then
                            FechaEntradaPrestamo = 1
                        Else
                            FechaEntradaPrestamo = 0
                        End If
                    Next

                    Select Case FechaEntradaPrestamo
                        Case 1
                            MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")
                        Case 0
                            Consulta = "select * from libro where estado = '0'"
                            consultar()
                            DataGridViewlllllVerLibrosEnExtraccionlllll.DataSource = Tabla
                            ExtCombo.Visible = True
                    End Select
                End If
            Else
            End If
        End If
    End Sub

    Private Sub PictureBoxParaDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDevolucion.Click
        If CarritoDeLibros.Items.Count = 0 Then



            'Dim ROWS As DataGridView = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow

            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            DataGridParaDevolucion.DataSource = Tabla


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExtCombo.Visible = False
            ReservacionComboBox.Visible = False
            CrearReservacionComboBox.Visible = False



            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            devoCOMBO.Visible = True

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub

    Private Sub PictureBoxParaReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureReservacion.Click

        If CarritoDeLibros.Items.Count = 0 Then

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            CrearReservacionComboBox.Visible = False
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow

            Consulta = "select * from libro where estado = 2"
            consultar()
            VerLibrosReservados2.DataSource = Tabla


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            If (DatagridviewOcultolllllParaFuncionesPrestmolllll.RowCount = 1) Then

                ReservacionComboBox.Visible = True

                Consulta = "select * from libro where estado = 2"
                consultar()
                VerLibrosReservados2.DataSource = Tabla

            End If
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Try
                If (ROWS.Cells(3).Value.ToString) <> "" Then
                    ReservacionComboBox.Visible = True

                    Consulta = "select * from libro where estado = 2"
                    consultar()
                    VerLibrosReservados2.DataSource = Tabla
                Else
                    ReservacionComboBox.Visible = False
                    MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")

                End If
            Catch ex As Exception
            End Try
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If

    End Sub



    Private Sub PictureBoxCrearReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureCrearReservacion.Click
        If CarritoDeLibros.Items.Count = 0 Then
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


        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub

    Private Sub ButonEliminarReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminarReservacion.Click

        Dim IdLibro As String
        IdLibro = InputBox("Ingrese la id del libro para eliminar las reservación", Title:="RESERVACIÓN")
        Try
            If Consulta <> "" Then
                Consulta = "update libro set estado = 0 where cod_libro ='" & IdLibro & "'"
                consultar()
                MsgBox("Se a cancelado la reservacion", Title:="PRESTAMO")

                Consulta = "select * from libro where estado = 2"
                consultar()
                VerLibrosReservados2.DataSource = Tabla
            Else
                MsgBox("No se canceló la reservación del libro", Title:="ERROR RESERVACIÓN")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la eliminación de las reservación", Title:="ERROR RESERVACIÓN")
        End Try

        Consulta = "select * from libro where estado = 2"
        consultar()
        VerLibrosReservados2.DataSource = Tabla
    End Sub

    Private Sub BotonExtrearReservados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonExtrearReservados.Click

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


                While contador < list
                    contador = Val(contador) + 1

                    'REVISAR ESTO'
                    Consulta = "insert into prestamolibro(cedula,cod_libro,fecha_salida) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "')"
                    consultar()

                    Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                    consultar()

                    libros = libros + 1

                End While

                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                ReservacionComboBox.Visible = False
            End If


        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If


        '/////////////////////CASO DOS///////////////////
        Try
            If Cedula.Text <> "" Then

                If (ROWS.Cells(3).Value.ToString) <> "" Then

                    While contador < list
                        contador = Val(contador) + 1


                        Consulta = "insert into prestamolibro (cedula, cod_libro, fecha_salida) values ('" & Cedula.Text & "','" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "','" & Date.Now.ToString("yyyy-MM-dd") & "')"
                        consultar()


                        Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                        consultar()

                        libros = libros + 1

                    End While

                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                    ReservacionComboBox.Visible = False
                Else
                    MsgBox("Este socios no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")

                End If

            Else
                MsgBox("La cedula debe estar ingresada", Title:="PRESTAMOS")
            End If

        Catch ex As Exception
        End Try


        '    1)////////////////////
    End Sub




    Private Sub LIBROS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextboxBuscador.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Se iguala una variable a un valor de la base de datos
            Dim TransoformarDBSDaVariable As DataGridViewRow = DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow
            Dim NOMBREdelLIBRO As String
            NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)

            '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

            Dim list1 As Integer
            list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count

            If DataGridViewlllllVerLibrosEnExtraccionlllll.Item(0, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value <> list1 Then

                Dim NomLibro As String
                Dim IdLibro As String
                NomLibro = DataGridViewlllllVerLibrosEnExtraccionlllll.Item(0, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value
                IdLibro = DataGridViewlllllVerLibrosEnExtraccionlllll.Item(1, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value



                If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(NomLibro)) Then

                    MsgBox("El libro " & NomLibro & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")
                Else
                    z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                    If z = vbYes Then

                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(NomLibro)
                        CarritoDeLibros.Items.Add(NomLibro & "                          " & IdLibro)

                        For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items
                            For Each Row As DataGridViewRow In DataGridViewlllllVerLibrosEnExtraccionlllll.Rows
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
    '///////////////////////////Algunos timers////////////////////////////////////////
    Private Sub TextboxBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextboxBuscador.TextChanged
        Try
            Consulta = "select * from libro where estado = 0 and cod_libro like '" & TextboxBuscador.Text & "%'"
            consultar()
            DataGridViewlllllVerLibrosEnExtraccionlllll.DataSource = Tabla

            For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items
                For Each Row As DataGridViewRow In DataGridViewlllllVerLibrosEnExtraccionlllll.Rows

                    If Row.Cells("cod_libro").Value = Val(item) Then
                        Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                    End If
                Next
            Next

        Catch ex As Exception

        End Try

    End Sub

    '/////////////////////////////////////////////////////////////////////////////////
    Private Sub DataGridViewlllllVerLibrosEnExtraccionlllll_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewlllllVerLibrosEnExtraccionlllll.CellDoubleClick
        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)


        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count



        If DataGridViewlllllVerLibrosEnExtraccionlllll.Item(0, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value <> list1 Then
            Dim NomLibros As String
            Dim IdLibros As String
            NomLibros = DataGridViewlllllVerLibrosEnExtraccionlllll.Item(0, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value
            IdLibros = DataGridViewlllllVerLibrosEnExtraccionlllll.Item(1, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value



            If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(NomLibros)) Then

                MsgBox("Este libro " & NomLibros & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then


                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(NomLibros)
                    CarritoDeLibros.Items.Add(NomLibros & "                          " & IdLibros)
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items

                        For Each Row As DataGridViewRow In DataGridViewlllllVerLibrosEnExtraccionlllll.Rows
                            If Row.Cells("cod_libro").Value = Val(item) Then
                                Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                            End If

                        Next
                    Next
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                End If
            End If
        End If

        If CarritoDeLibros.Items.Count <> 0 Then

            ButonParaExtreaer.Visible = True
        Else
            ButonParaExtreaer.Visible = False

        End If
    End Sub

    Private Sub DataGridParaDevolucion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridParaDevolucion.CellDoubleClick
        If modo = "devolucion" Then

            Try

                Libro1 = DataGridParaDevolucion.Item(2, DataGridParaDevolucion.CurrentRow.Index).Value

                cod_libros = DataGridParaDevolucion.Item(1, DataGridParaDevolucion.CurrentRow.Index).Value



                Dim a As MsgBoxResult
                a = MsgBox("Desea devolver el libro " & Libro1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")


                '       1) Si se devuelve el libro y se actualiza la Base da datos 
                If a = vbYes Then

                    Consulta = "update libro set estado = 0 where cod_libro = '" & cod_libros & "'"
                    consultar()
                    Consulta = "UPDATE prestamolibro SET fecha_entrada = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros & "'"
                    consultar()
                    MsgBox("se ha devuelto", Title:="PRESTAMO")

                    Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                    consultar()
                    DataGridParaDevolucion.DataSource = Tabla

                Else

                    MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

                    Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and cedula= '" & Cedula.Text & "'"
                    consultar()
                    DataGridParaDevolucion.DataSource = Tabla

                End If

                If a = vbNo Then

                End If

            Catch ex As Exception

                MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

            End Try
        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Consulta = "select * from libro where estado = 0 and cod_libro like '" & TextBox3.Text & "%'"
        consultar()
        LibrosParaReservar.DataSource = Tabla
        Dim ROWS As DataGridViewRow = DatagridviewOcultolllllParaFuncionesPrestmolllll.CurrentRow
    End Sub


    Private Sub CarritoDeLibros_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CarritoDeLibros.MouseClick

        '/////////////////////////////////////////////
        Dim IdLibro As String
        Dim NomLibro As String
        Dim MSBOX_Consulta As MsgBoxResult
        '//////////////////////////////////////////////

        NomLibro = CarritoDeLibros.SelectedItem


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        MSBOX_Consulta = MsgBox("Desea cancelar la extracción del libro? " & NomLibro & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If MSBOX_Consulta = vbYes Then
            IdLibro = InputBox("Ingrese la id del libro para verificar", Title:="PRESTAMO")

            If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(IdLibro)) Then

                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Remove(IdLibro)
                NomLibro = CarritoDeLibros.SelectedItem
                CarritoDeLibros.Items.Remove(NomLibro)
            Else
                MsgBox("La id del libro no es correcta", Title:="PRESTAMO ERROR")
            End If
        End If

    End Sub

    Private Sub PictureExtraccion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureExtraccion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Extraccion"
    End Sub

    Private Sub PictureDevolucion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureDevolucion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Devolucion"
    End Sub

    Private Sub PictureReservacion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureReservacion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "ExtreaerLibro" + vbCrLf + "Reservado"
    End Sub

    Private Sub PictureCrearReservacion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureCrearReservacion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Crear" + vbCrLf + "Reservacion"
    End Sub

    Private Sub Panel3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "SELECCION " + vbCrLf + "DE" + vbCrLf + "FUNCION"

    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Panel4.Left = 1018 Then
            Panel4.Left -= 10
        Else
            Panel4.Left = 1018
        End If
    End Sub


    Private Sub Panel4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "SELECCION " + vbCrLf + "DE" + vbCrLf + "FUNCION"
    End Sub



    Private Sub VerLibrosReservados2_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VerLibrosReservados2.CellContentDoubleClick

        'Se iguala una variable a un valor de la base de datos
        Dim list1 As Integer

        list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count - 1
        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 





        If VerLibrosReservados2.Item(0, VerLibrosReservados2.CurrentRow.Index).Value <> list1 Then

            Dim NomLibro As String
            Dim IdLibro As String
            NomLibro = VerLibrosReservados2.Item(1, VerLibrosReservados2.CurrentRow.Index).Value
            IdLibro = VerLibrosReservados2.Item(0, VerLibrosReservados2.CurrentRow.Index).Value



            If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(NomLibro)) Then

                MsgBox("El libro " & NomLibro & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")
            Else
                z = MsgBox("Desea llevar al carrito el libro " & NomLibro & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then

                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(IdLibro)
                    CarritoDeLibros.Items.Add(IdLibro & "                          " & NomLibro)

                    For Each item As String In ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items
                        For Each Row As DataGridViewRow In VerLibrosReservados2.Rows
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

    Public Sub LibrosParaReservar_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LibrosParaReservar.CellContentDoubleClick

        'Se iguala una variable a un valor de la base de datos
        Dim list1 As Integer

        list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count - 1
        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 




        Try

            If LibrosParaReservar.Item(0, LibrosParaReservar.CurrentRow.Index).Value <> list1 Then

                Dim NomLibro As String
                Dim IdLibro As String
                NomLibro = LibrosParaReservar.Item(1, LibrosParaReservar.CurrentRow.Index).Value
                IdLibro = LibrosParaReservar.Item(0, LibrosParaReservar.CurrentRow.Index).Value


                a = MsgBox("Desea reservar el libro " & NomLibro & " ?", MsgBoxStyle.YesNoCancel, Title:="PRESTAMOS")
                If a = vbYes Then

                    Consulta = "update libro set estado = 2 where cod_libro = '" & IdLibro & "'"
                    consultar()

                    '///A REVISAR////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    Consulta = "UPDATE prestamolibro SET reservacion = 'Reservado' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & IdLibro & "'"
                    consultar()
                    MsgBox("se ha creador la reservacion", Title:="PRESTAMO")
                    Consulta = "select * from libro where estado = 0"
                    LibrosParaReservar.DataSource = Tabla
                    consultar()
                    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Consulta = "select * from libro where estado = 0"
                    LibrosParaReservar.DataSource = Tabla
                    consultar()

                Else



                    Consulta = "select * from libro where estado = 0"
                    LibrosParaReservar.DataSource = Tabla
                    consultar()
                End If


                If a = vbNo Then

                End If
            End If

        Catch ex As Exception

            MsgBox("El libro sigue reservado", Title:="RESERVACION")

        End Try

        '/////////////////////////////////////////////////
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a As String

        a = MsgBox("Desea vaciar el carrito ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If a = vbYes Then
            MsgBox("Carrito vaciado", Title:="PRESTAMO")
            CarritoDeLibros.Items.Clear()
            ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()

            Consulta = "select * from libro where estado = '0'"
            consultar()
            DataGridViewlllllVerLibrosEnExtraccionlllll.DataSource = Tabla

            Consulta = "select * from libro where estado = 2"
            consultar()
            VerLibrosReservados2.DataSource = Tabla

        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Registroprestamos.Show()
    End Sub

    Private Sub Cedula_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cedula.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Cedula.Text = "" Then
                '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                LabelSELECCION_DE_FUNCION.Visible = False
                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                PanelDelCarrito.Left = -268
                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////
            Else


                Consulta = "select cedula from usuarios where cedula like '" & Cedula.Text & "'"
                consultar()

                If Tabla.Rows.Count = 0 Then ' VERFICAR SI ES NULO EL RESULTADO DE LA CONSULTA
                    '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion.Visible = False
                    PictureDevolucion.Visible = False
                    PictureCrearReservacion.Visible = False
                    PictureReservacion.Visible = False
                    LabelSELECCION_DE_FUNCION.Visible = False
                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    PanelDelCarrito.Left = -268
                    MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
                Else

                    Consulta = "select cedula , nombre , tipo from usuarios where cedula like '" & Cedula.Text & "'"
                    consultar()
                    Try
                        For Each row As DataRow In Tabla.Rows
                            NOMBRE.Text = row("nombre")
                            Label12.Text = row("tipo")
                        Next
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                    '/////////////////////////////////////////////////////////////////////////////////////////////
                    '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                    '/////////////////////////////////////////////////////////////////////////////////////////////


                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion.Visible = True
                    PictureDevolucion.Visible = True
                    PictureCrearReservacion.Visible = True
                    PictureReservacion.Visible = True
                    LabelSELECCION_DE_FUNCION.Visible = True
                    CarritoDeLibros.Items.Clear()
                    ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                    PanelDelCarrito.Left = -5

                    If Label12.Text = 2 Then
                        ButtonLiberar.Visible = True
                    ElseIf Label12.Text = 0 Then
                        ButtonMoroso.Visible = True
                    End If
                    '/////////////////////////////////////////////////////////////////////////////////////////////

                End If

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrestamoRevistas.Show()
    End Sub

    Private Sub DataGridParaDevolucion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridParaDevolucion.CellContentClick

    End Sub
End Class