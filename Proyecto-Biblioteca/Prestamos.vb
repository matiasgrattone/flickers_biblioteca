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
        Button2.Visible = False
        Label5.Visible = False
        PictureExtraccion1.Visible = False
        PictureDevolucion2.Visible = False
        PictureCrearRes3.Visible = False
        PictureReservacion4.Visible = False
        Label5.Visible = False
        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////
        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If
        '/////////////////////////////////////////////VARIABLES CON DIA Y HORA////////////////////

    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim Es_moroso As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        DataGridView1.DataSource = Tabla

        NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value

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




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Se cambia el label solo cuando haya un valor en el textbox CEDULA

        Try

            If Cedula.Text <> "" Then

                'Consulta a DATAGRIDVIEW oculto

                Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                consultar()
                DataGridView1.DataSource = Tabla

                '////////////////////////////////

                Label5.Visible = True


                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                ReservacionComboBox.Visible = False

                PictureExtraccion1.Visible = True
                PictureDevolucion2.Visible = True
                PictureCrearRes3.Visible = True
                PictureReservacion4.Visible = True
                Label5.Visible = True
            End If

        Catch ex As Exception


            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            ReservacionComboBox.Visible = False
            PictureExtraccion1.Visible = False
            PictureDevolucion2.Visible = False
            PictureCrearRes3.Visible = False
            PictureReservacion4.Visible = False
            Label5.Visible = False
        End Try



        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        '////////////////////////////////

        'Se iguala una variable a un valor de la base de datos para hacer consulta luego

        Aparecer.Enabled = True
    End Sub

    Private Sub VERLIBROSAGG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellClick

    End Sub



    Private Sub VERLIBROSAGG_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentDoubleClick



    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("hh:mm:ss")

        Label4.Text = Date.Now.ToString("yyyy-mm-dd")

    End Sub

    Private Sub Cedula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cedula.KeyDown
        If panelnombre = 0 Then
            If e.KeyCode = Keys.Enter Then

                'Se cambia el label solo cuando haya un valor en el textbox CEDULA

                Try

                    If Cedula.Text <> "" Then

                        '/////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////
                        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                        consultar()
                        DataGridView1.DataSource = Tabla
                        '///////////////////////////////////////////////////////////////////////////////////////////

                        '/////////////////////////////////////////////////////////////////////////////////////////////
                        '////////////////////////////////prepara la interfaz para las funciones///////////////////////
                        '/////////////////////////////////////////////////////////////////////////////////////////////

                        NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                        Label5.Visible = True
                        ExtCombo.Visible = False
                        devoCOMBO.Visible = False
                        ReservacionComboBox.Visible = False
                        PictureExtraccion1.Visible = True
                        PictureDevolucion2.Visible = True
                        PictureCrearRes3.Visible = True
                        PictureReservacion4.Visible = True
                        Label5.Visible = True
                        LIBROSAGG.Items.Clear()
                        IDAGG.Items.Clear()
                        Aparecer.Enabled = True
                        '/////////////////////////////////////////////////////////////////////////////////////////////

                    End If

                Catch ex As Exception




                    '//////////////////////oculta los picturebox y la interfaz de las funciones///////////////////////////////

                    MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion1.Visible = False
                    PictureDevolucion2.Visible = False
                    PictureCrearRes3.Visible = False
                    PictureReservacion4.Visible = False
                    Label5.Visible = False
                    LIBROSAGG.Items.Clear()
                    IDAGG.Items.Clear()
                    Ocultar.Enabled = True
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////


                End Try


                '//////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////////
                Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                consultar()
                OPA.DataSource = Tabla
                '////////////////////////////////////////////////////////////////////////////////////////////////


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
                        DataGridView1.DataSource = Tabla
                        '///////////////////////////////////////////////////////////////////////////////////////////

                        '/////////////////////////////////////////////////////////////////////////////////////////////
                        '////////////////////////////////prepara la interfaz para las funciones///////////////////////
                        '/////////////////////////////////////////////////////////////////////////////////////////////


                        Label5.Visible = True
                        ExtCombo.Visible = False
                        devoCOMBO.Visible = False
                        ReservacionComboBox.Visible = False
                        PictureExtraccion1.Visible = True
                        PictureDevolucion2.Visible = True
                        PictureCrearRes3.Visible = True
                        PictureReservacion4.Visible = True
                        Label5.Visible = True
                        LIBROSAGG.Items.Clear()
                        IDAGG.Items.Clear()
                        Ocultar_Aparecer.Enabled = True


                        '/////////////////////////////////////////////////////////////////////////////////////////////

                    End If

                Catch ex As Exception




                    '//////////////////////oculta los picturebox y la interfaz de las funciones///////////////////////////////

                    ExtCombo.Visible = False
                    devoCOMBO.Visible = False
                    ReservacionComboBox.Visible = False
                    PictureExtraccion1.Visible = False
                    PictureDevolucion2.Visible = False
                    PictureCrearRes3.Visible = False
                    PictureReservacion4.Visible = False
                    Label5.Visible = False
                    Ocultar.Enabled = True
                    LIBROSAGG.Items.Clear()
                    IDAGG.Items.Clear()
                    MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")



                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////


                End Try


                '//////////////////////////Consulta a DATAGRIDVIEW oculto////////////////////////////////////////
                Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                consultar()
                OPA.DataSource = Tabla
                '////////////////////////////////////////////////////////////////////////////////////////////////


            End If
        End If


    End Sub

    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cedula.TextChanged
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

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow


        Dim list, contador, libros As Integer
        contador = 0

        list = 0
        list = IDAGG.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then
            If (OPA.RowCount = 1) Then

                MsgBox("Usted pude RETIRAR UN LIBREO", Title:="PRESTAMO")

                While contador < list
                    contador = Val(contador) + 1


                    Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','')"
                    consultar()


                    Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                    consultar()

                    libros = libros + 1

                End While

                LIBROSAGG.Items.Clear()
                IDAGG.Items.Clear()
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


                        Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','')"
                        consultar()


                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                        consultar()

                        libros = libros + 1

                    End While

                    LIBROSAGG.Items.Clear()
                    IDAGG.Items.Clear()
                    MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                    ExtCombo.Visible = False
                Else
                    MsgBox("Este usuario no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")

                End If

            Else
                MsgBox("La cedula debe estar ingrezada", Title:="PRESTAMOS")
            End If

        Catch ex As Exception
        End Try


        '    1)////////////////////
    End Sub






    Private Sub DataGridAGG_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellContentDoubleClick


    End Sub

    Private Sub LIBROSAGG_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LIBROSAGG.MouseClick

        Dim a1 As String
        Dim Ga1 As String
        Dim MSBOX_Consulta As MsgBoxResult

        Ga1 = LIBROSAGG.SelectedItem

        MSBOX_Consulta = MsgBox("Desea cancelar la extracción del libro? " & Ga1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If MSBOX_Consulta = vbYes Then

            a1 = InputBox("Ingrese la id del libro para verificar", Title:="PRESTAMO")

            If (IDAGG.Items.Contains(a1)) Then

                IDAGG.Items.Remove(a1)
                Ga1 = LIBROSAGG.SelectedItem
                LIBROSAGG.Items.Remove(Ga1)

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
        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where cedula= '" & Cedula.Text & "';"
        consultar()
        DataGridAGG.DataSource = Tabla
        modo = "registro"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        DataGridAGG.DataSource = Tabla
        modo = "devolucion"
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim Es_moroso2 As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        DataGridView1.DataSource = Tabla

        NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value

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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureExtraccion1.Click
        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        Consulta = "select * from libro where estado = 'disponible'"
        consultar()
        VERLIBROSAGG.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        CrearReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If Cedula.Text <> "" Then

            If (OPA.RowCount = 1) Then

                ExtCombo.Visible = True

                Consulta = "select * from libro where estado = 'disponible'"
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

                    Consulta = "select * from libro where estado = 'disponible'"
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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDevolucion2.Click
        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        Consulta = "select * from libro where estado = 'disponible'"
        consultar()
        VERLIBROSAGG.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        ReservacionComboBox.Visible = False
        CrearReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If Cedula.Text <> "" Then
            devoCOMBO.Visible = True

            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
            consultar()

            DataGridAGG.DataSource = Tabla
        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureReservacion4.Click

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        CrearReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        Consulta = "select * from libro where estado = 'Reservado'; "
        consultar()
        VerLibrosReservados.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If Cedula.Text <> "" Then

            If (OPA.RowCount = 1) Then

                ReservacionComboBox.Visible = True

                Consulta = "select * from libro where estado = 'Reservado'; "
                consultar()
                VerLibrosReservados.DataSource = Tabla

            End If

        Else
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Try
            If Cedula.Text <> "" Then
                If (ROWS.Cells(3).Value.ToString) <> "" Then
                    ReservacionComboBox.Visible = True

                    Consulta = "select * from libro where estado = 'Reservado';"
                    consultar()
                    VerLibrosReservados.DataSource = Tabla
                Else
                    ReservacionComboBox.Visible = False
                    MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")
                End If

            Else
                MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
            End If
        Catch ex As Exception
        End Try
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureCrearRes3.Click

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        Consulta = "select * from libro where estado = 'disponible'"
        consultar()
        LibrosParaReservar.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow


        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ReservacionComboBox.Visible = False
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        If Cedula.Text <> "" Then
            CrearReservacionComboBox.Visible = True

            Consulta = "select * from libro where estado = 'disponible'"
            consultar()

            LibrosParaReservar.DataSource = Tabla
        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim goku As String
        goku = InputBox("Ingrese la id del libro para eliminar las reservacion", Title:="RESERVACION")
        Try
            If goku <> "" Then
                Consulta = "update libro set estado = 'Disponible' where cod_libro = '" & goku & "';"
                consultar()
                MsgBox("Se a cancelado la reservacion", Title:="PRESTAMO")

                Consulta = "select * from libro where estado = 'Reservado'; "
                consultar()
                VerLibrosReservados.DataSource = Tabla
            Else
                MsgBox("No se cancelo la reservacion del libro", Title:="ERROR RESERVACION")
            End If
        Catch ex As Exception
            MsgBox("Ah ocurrido un error en la eliminación de las reservacion", Title:="ERROR RESERVACION")
        End Try

        Consulta = "select * from libro where estado = 'Reservado'; "
        consultar()
        VerLibrosReservados.DataSource = Tabla
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow


        Dim list, contador, libros As Integer
        contador = 0

        list = 0
        list = IDAGG.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////

        If Cedula.Text <> "" Then
            If (OPA.RowCount = 1) Then

                While contador < list
                    contador = Val(contador) + 1


                    Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','')"
                    consultar()


                    Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                    consultar()

                    libros = libros + 1

                End While

                LIBROSAGG.Items.Clear()
                IDAGG.Items.Clear()
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")

                Consulta = "select * from libro where estado = 'Reservado';"
                VerLibrosReservados.DataSource = Tabla
                consultar()

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

                        Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','')"
                        consultar()

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                        consultar()

                        libros = libros + 1

                    End While

                    LIBROSAGG.Items.Clear()
                    IDAGG.Items.Clear()
                    MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")

                Else
                    MsgBox("Este usuario no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")

                End If

            Else
                MsgBox("La cedula debe estar ingrezada", Title:="PRESTAMOS")
            End If

        Catch ex As Exception
        End Try


        '    1)////////////////////
    End Sub


    Private Sub VerLibrosReservados_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VerLibrosReservados.CellDoubleClick

        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = VerLibrosReservados.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)


        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = IDAGG.Items.Count

        If VerLibrosReservados.Item(0, VerLibrosReservados.CurrentRow.Index).Value <> list1 Then
            Dim goku As String
            Dim vegeta As String

            goku = VerLibrosReservados.Item(0, VerLibrosReservados.CurrentRow.Index).Value
            vegeta = VerLibrosReservados.Item(1, VerLibrosReservados.CurrentRow.Index).Value

            If (IDAGG.Items.Contains(goku)) Then

                MsgBox("Este libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then

                    IDAGG.Items.Add(goku)
                    LIBROSAGG.Items.Add(goku & "                          " & vegeta)

                End If
            End If
        End If
        If LIBROSAGG.Items.Count <> 0 Then
            Button2.Visible = True
        Else
            Button2.Visible = False
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
            list1 = IDAGG.Items.Count



            If VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value <> list1 Then
                Dim goku As String
                Dim vegeta As String
                goku = VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value
                vegeta = VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value







                If (IDAGG.Items.Contains(goku)) Then

                    MsgBox("Este libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


                Else

                    z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                    If z = vbYes Then


                        IDAGG.Items.Add(goku)
                        LIBROSAGG.Items.Add(goku & "                          " & vegeta)

                        For Each item As String In IDAGG.Items
                            For Each Row As DataGridViewRow In VERLIBROSAGG.Rows
                                If Row.Cells("cod_libro").Value = Val(item) Then
                                    Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                                End If
                            Next
                        Next


                    End If


                End If

            End If

            If LIBROSAGG.Items.Count <> 0 Then

                Button2.Visible = True

            Else

                Button2.Visible = False

            End If





        End If
    End Sub

    Private Sub LIBROS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIBROS.TextChanged
        Try
            Consulta = "select * from libro where estado = 'disponible' and cod_libro like '" & LIBROS.Text & "%'"
            consultar()
            VERLIBROSAGG.DataSource = Tabla
            For Each item As String In IDAGG.Items
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
                NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                Aparecer.Enabled = False
                panelnombre = 1
            End If
        Catch ex As Exception
            Aparecer.Enabled = False

            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            ReservacionComboBox.Visible = False
            PictureExtraccion1.Visible = False
            PictureDevolucion2.Visible = False
            PictureCrearRes3.Visible = False
            PictureReservacion4.Visible = False
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
                NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                Aparecer.Enabled = True
                Ocultar_Aparecer.Enabled = False

            End If
        Catch ex As Exception
            Ocultar.Enabled = True
            Ocultar_Aparecer.Enabled = False
            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            ReservacionComboBox.Visible = False
            PictureExtraccion1.Visible = False
            PictureDevolucion2.Visible = False
            PictureCrearRes3.Visible = False
            PictureReservacion4.Visible = False
            Label5.Visible = False
            MsgBox("Error en el ingreso de cedula", Title:="Error")
        End Try

    End Sub

    Private Sub VERLIBROSAGG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentClick

    End Sub

    Private Sub VERLIBROSAGG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellDoubleClick
        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = VERLIBROSAGG.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)


        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = IDAGG.Items.Count



        If VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value <> list1 Then
            Dim goku As String
            Dim vegeta As String
            goku = VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value
            vegeta = VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value



            If (IDAGG.Items.Contains(goku)) Then

                MsgBox("Este libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then


                    IDAGG.Items.Add(goku)
                    LIBROSAGG.Items.Add(goku & "                          " & vegeta)

                    For Each item As String In IDAGG.Items

                        For Each Row As DataGridViewRow In VERLIBROSAGG.Rows
                            If Row.Cells("cod_libro").Value = Val(item) Then
                                Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
                            End If
                        Next


                    Next




                End If


            End If

        End If

        If LIBROSAGG.Items.Count <> 0 Then

            Button2.Visible = True

        Else

            Button2.Visible = False

        End If





    End Sub

    Private Sub DataGridAGG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellContentClick

    End Sub

    Private Sub DataGridAGG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellDoubleClick


        '////////////////////////////////
        If modo = "devolucion" Then
            'Consulta a DATAGRIDVIEW oculto
            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
            DataGridAGG.DataSource = Tabla
            consultar()
            'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
            If Cedula.Text <> "" Then
                Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                DataGridAGG.DataSource = Tabla

                consultar()

                '////////////////////////////////

                Try

                    Libro1 = DataGridAGG.Item(2, DataGridAGG.CurrentRow.Index).Value
                    cod_libros = DataGridAGG.Item(1, DataGridAGG.CurrentRow.Index).Value

                    If DataGridAGG.Item(4, DataGridAGG.CurrentRow.Index).Value.ToString = "" Then
                        Dim a As MsgBoxResult
                        a = MsgBox("Desea devolver el libro " & Libro1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                        '       1) Si se devuelve el libro y se actualiza la Base da datos 
                        If a = vbYes Then

                            Consulta = "update libro set estado = 'disponible' where cod_libro = '" & cod_libros & "';"
                            consultar()
                            Consulta = "UPDATE prestamo SET fecha_entrada = '" & Label4.Text & "' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros & "';"
                            consultar()
                            MsgBox("se ha devuelto", Title:="PRESTAMO")

                            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                            consultar()
                            DataGridAGG.DataSource = Tabla

                        Else

                            MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

                            Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                            consultar()
                            DataGridAGG.DataSource = Tabla

                        End If
                    End If

                    If a = vbNo Then
                        MsgBox("No", Title:="PRESTAMOS")
                    End If

                Catch ex As Exception

                    MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

                    Consulta = "select p.cedula, p.cod_libro, l.titulo, p.fecha_salida, p.fecha_entrada from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                    consultar()
                    DataGridAGG.DataSource = Tabla


                End Try



                '       1)/////////////////

            End If
            '/////////////////////////////////////////////////
        End If

    End Sub

    Private Sub LibrosParaReservar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LibrosParaReservar.CellDoubleClick

        'Consulta a DATAGRIDVIEW para ver los libros disponibles
        Consulta = "select * from libro where estado = 'disponible';"
        consultar()
        LibrosParaReservar.DataSource = Tabla


        '////////////////////////////////

        'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
        If Cedula.Text <> "" Then
            Consulta = "select * from libro where estado = 'disponible';"
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

                    Consulta = "update libro set estado = 'Reservado' where cod_libro = '" & cod_libros2 & "';"
                    consultar()
                    Consulta = "UPDATE prestamo SET reservacion = 'Reservado' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros2 & "';"
                    consultar()
                    MsgBox("se ha creador la reservacion", Title:="PRESTAMO")

                    Consulta = "select * from libro where estado = 'disponible';"
                    LibrosParaReservar.DataSource = Tabla
                    consultar()

                Else

                    MsgBox("El libro sigue reservado", Title:="RESERVACION")

                    Consulta = "select * from libro where estado = 'disponible';"
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

        Consulta = "select * from libro where estado = 'disponible';"
        LibrosParaReservar.DataSource = Tabla
        consultar()

        '/////////////////////////////////////////////////
    End Sub

    Private Sub VerLibrosReservados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VerLibrosReservados.CellContentClick

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Consulta = "select * from libro where estado = 'disponible' and cod_libro like '" & TextBox3.Text & "%'"
        consultar()
        LibrosParaReservar.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow
    End Sub

    Private Sub LibrosParaReservar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LibrosParaReservar.CellContentClick

    End Sub
End Class