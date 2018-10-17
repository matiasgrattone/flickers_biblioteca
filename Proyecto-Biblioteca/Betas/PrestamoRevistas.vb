Public Class PrestamoRevistas

    Dim z As MsgBoxResult
    Dim h As String
    Dim a As String
    Dim Revista1 As String
    Dim ID_Revista1 As String
    Dim Contador As Integer = 0
    Dim VALIDADOR As String
    Dim modo As String = "devolucion"
    Dim panelnombre As Integer = 0

    '//////////////VARIABLE PARA GUARDAR TEMPORALMENTE LA ID DEL LIBRO MAS ADELANTE//////////


    Dim revisarenovar As String

    Dim fecha_actual As Date
    Dim fecha_estimada As String
    Dim dia, mes, anio, diferenciaDia As Integer

    Dim FechaEntradaPrestamo As Integer

    Dim errorcedula As Integer = 0

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtGrup.Visible = False
        devoCOMBO.Visible = False
        ButonParaExtreaer.Visible = False
        LabelREVISTAS.Visible = False
        PictureExtraccion.Visible = False
        PictureDevolucion.Visible = False
        LabelAlmacenTemporalParaLaCedula.Text = ""
        LabelSELECCION_DE_FUNCION.Visible = False
        ButtonLiberar.Visible = False
        ButtonMoroso.Visible = False
        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////
        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If
    End Sub
    Private Sub BotonParaBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParaBuscarCedula.Click

        'Se cambia el label solo cuando haya un valor en el textbox CEDULA


        If Cedula.Text = "" Then
            '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

            ExtGrup.Visible = False
            devoCOMBO.Visible = False
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            LabelAlmacenTemporalParaLaCedula.Text = ""
            LabelREVISTAS.Visible = False
            LabelSELECCION_DE_FUNCION.Visible = False
            CarritoDeRevistas.Items.Clear()
            ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Clear()
            PanelDelCarrito.Left = -268
            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
            '/////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else


            Consulta = "select cedula from usuarios where cedula like '" & Cedula.Text & "'"
            consultar()

            If Tabla.Rows.Count = 0 Then ' VERFICAR SI ES NULO EL RESULTADO DE LA CONSULTA
                '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                ExtGrup.Visible = False
                devoCOMBO.Visible = False
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                LabelAlmacenTemporalParaLaCedula.Text = ""
                LabelREVISTAS.Visible = False
                LabelSELECCION_DE_FUNCION.Visible = False
                CarritoDeRevistas.Items.Clear()
                ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Clear()
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

                LabelREVISTAS.Visible = True
                ExtGrup.Visible = False
                devoCOMBO.Visible = False
                PictureExtraccion.Visible = True
                PictureDevolucion.Visible = True
                '///////////////////LABEL PARA HACER LAS FUNCIONES CON LA CEDULA///////////////////////////
                LabelAlmacenTemporalParaLaCedula.Text = Cedula.Text
                '/////////////////////////////////////////////////////////////////////////////////////////
                LabelREVISTAS.Visible = True
                LabelSELECCION_DE_FUNCION.Visible = True
                CarritoDeRevistas.Items.Clear()
                ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Clear()
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
    Private Sub PictureExtraccion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureExtraccion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Extraccion"
    End Sub

    Private Sub PictureDevolucion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureDevolucion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Devolucion"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerRegistro.Click
        Registroprestamos.Show()
    End Sub
    Private Sub ButonLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLiberar.Click

        Dim Es_moroso As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & LabelAlmacenTemporalParaLaCedula.Text & "'  "
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

                    Consulta = "update usuarios set (tipo = ""0"") where cedulaU = '" & LabelAlmacenTemporalParaLaCedula.Text & "';"
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


    '/////////////////////////////////////////////////////////EXTRACCION///////////////////////////////////////////////////////////////
    '///PARA VERFIFICAR SI PUEDE RETIRAR UNA REVISTA ///
    Private Sub PictureExtraccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureExtraccion.Click
        If CarritoDeRevistas.Items.Count = 0 Then

            If LabelAlmacenTemporalParaLaCedula.Text <> "" Then


                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                devoCOMBO.Visible = False
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                Consulta = "select * from prestamorevistas where fecha_entrada is NULL and cedula= '" & LabelAlmacenTemporalParaLaCedula.Text & "'"
                consultar()
                If (Tabla.Rows.Count = 0) Then
                    ExtGrup.Visible = True
                    Consulta = "select id_revistas as 'Codigo de Revista', titulo as 'Titulo', descripcion as 'Descripcion' from revistas where estado = '0'"
                    consultar()
                    DataGridView_VerRevistasEnExtraccion_.DataSource = Tabla

                    DatagridModulo = DataGridView_VerRevistasEnExtraccion_
                    Datagrid_Align()
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
                            MsgBox("Este socio NO puede retirar ninguna revista hasta devolver las ya prestadas", Title:="ERROR")
                        Case 0
                            Consulta = "select * from libro where estado = '0'"
                            consultar()
                            DataGridView_VerRevistasEnExtraccion_.DataSource = Tabla
                            ExtGrup.Visible = True
                    End Select
                End If
            Else
            End If
        End If
    End Sub
    '///PARA EXTRAER LAS REVISTAS DEL CARRTIO///
    Private Sub ButonParaExtreaer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButonParaExtreaer.Click
        Dim list, contador, libros As Integer
        contador = 0

        '///////////////////////////////////////////////////////////////////////////////////
        '///////////////Calcula la fecha en que deberia entregarse el libro/////////////////
        '///////////////////////////////////////////////////////////////////////////////////
        fecha_actual = DateTime.Now.ToString("yyyy/MM/dd")

        dia = Val(DateTime.Now.ToString("dd")) + 14
        mes = Val(DateTime.Now.ToString("MM"))
        anio = Val(DateTime.Now.ToString("yyyy"))

        If mes = 1 Then ' Mes de Enero
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 2 Then ' Mes de febrero
            If dia >= 28 Then
                diferenciaDia = dia - 28
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 3 Then ' Mes de marzo
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 4 Then ' Mes de abril
            If dia >= 30 Then
                diferenciaDia = dia - 30
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 5 Then ' Mes de mayo
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 6 Then ' Mes de junio
            If dia >= 30 Then
                diferenciaDia = dia - 30
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 7 Then ' Mes de julio
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 8 Then ' Mes de agosto
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 9 Then ' Mes de setiembre
            If dia >= 30 Then
                diferenciaDia = dia - 30
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 10 Then ' Mes de octubre
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 11 Then ' Mes de noviembre
            If dia >= 30 Then
                diferenciaDia = dia - 30
                dia = dia - diferenciaDia
                mes = mes + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        If mes = 12 Then ' Mes de diciembre
            If dia >= 31 Then
                diferenciaDia = dia - 31
                dia = dia - diferenciaDia
                mes = 1
                anio = anio + 1
                fecha_estimada = anio & "-" & mes & "-" & dia
            Else
                fecha_estimada = anio & "-" & mes & "-" & dia
            End If
        End If
        '////////////////////////////////////////////////////////////////////////

        list = 0
        list = ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then



            Consulta = "select * from prestamorevistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()

            If (Tabla.Tables(0).Rows.Count = 0) Then

                While contador < list
                    contador = Val(contador) + 1


                    Consulta = "insert into prestamorevistas(cedula, cod_libro, fecha_salida, fecha_estimada, cod_prestado) values('" + Cedula.Text + "','" + ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items(Revista1) + "','" + Date.Now.ToString("yyyy-MM-dd") + "', '" + fecha_estimada + "','" + MENU3.lbl_cedula.Text + "')"
                    consultar()

                    Consulta = "update revistas set estado = 1 where id_revistas = '" & ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items(Revista1) & "';"
                    consultar()

                    libros = libros + 1

                End While

                CarritoDeRevistas.Items.Clear()
                ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Clear()
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                ExtGrup.Visible = False


            Else


                For Each row As DataRow In Tabla.Tables(0).Rows
                    If row("fecha_estimada") Is DBNull.Value Then
                        FechaEntradaPrestamo = 0
                    Else
                        FechaEntradaPrestamo = 1
                    End If
                Next

                Select Case FechaEntradaPrestamo
                    Case 1

                        While contador < list
                            contador = Val(contador) + 1


                            Consulta = "insert into prestamorevistas(cedula, cod_libro, fecha_salida, fecha_estimada, cod_prestado) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "', '" + fecha_estimada + "','" + MENU3.lbl_cedula.Text + "')"
                            consultar()


                            Consulta = "update revistas set estado = 1 where id_revistas = '" & ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items(libros) & "';"
                            consultar()

                            libros = libros + 1

                        End While

                        CarritoDeRevistas.Items.Clear()
                        ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Clear()
                        MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                        ExtGrup.Visible = False


                    Case 0

                        MsgBox("Este socios no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")
                End Select
            End If
        End If
    End Sub
    '///PARA LLEVAR LAS REVISTAS AL CARRTIO///
    Private Sub DataGridView_VerRevistasEnExtraccion__CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_VerRevistasEnExtraccion_.CellDoubleClick

        '////////////////////////////SI LA CEDULA ES CORRECTA SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 
        Dim list1 As Integer
        list1 = ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Count



        If DataGridView_VerRevistasEnExtraccion_.Item(0, DataGridView_VerRevistasEnExtraccion_.CurrentRow.Index).Value <> list1 Then

            Dim NomREVISTA As String
            Dim IdREVISTA As String

            NomREVISTA = DataGridView_VerRevistasEnExtraccion_.Item(1, DataGridView_VerRevistasEnExtraccion_.CurrentRow.Index).Value
            IdREVISTA = DataGridView_VerRevistasEnExtraccion_.Item(0, DataGridView_VerRevistasEnExtraccion_.CurrentRow.Index).Value



            If (ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Contains(IdREVISTA)) Then

                MsgBox("La revista " & NomREVISTA & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito la revista " & NomREVISTA & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                If z = vbYes Then


                    ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Add(IdREVISTA)
                    CarritoDeRevistas.Items.Add(IdREVISTA & "                          " & NomREVISTA)

                End If
            End If
        End If

        If CarritoDeRevistas.Items.Count <> 0 Then

            ButonParaExtreaer.Visible = True
        Else
            ButonParaExtreaer.Visible = False

        End If
    End Sub
    '/////////////////////////////////////////////////////////FIN DE EXTRACCION///////////////////////////////////////////////////////////////


    '/////////////////////////////////////////////////////////DEVOLUCION///////////////////////////////////////////////////////////////
    '///PARA INICIAR FUNCIONES DE DEVOLUCION///
    Private Sub PictureDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDevolucion.Click

        If CarritoDeRevistas.Items.Count = 0 Then


            Consulta = "select p.cedula as 'Cedula de Socio', p.id_revistas as 'Codigo de Revista', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Prestamo', p.fecha_entrada as 'Fecha de Devolucion' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and cedula= '" & LabelAlmacenTemporalParaLaCedula.Text & "'"
            consultar()
            DataGridParaDevolucion.DataSource = Tabla

            DatagridModulo = DataGridParaDevolucion
            Datagrid_Align()

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExtGrup.Visible = False
            devoCOMBO.Visible = True
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else

            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub
    '///PARA DEVOLVER LAS REVISTAS EXTRAIDAS///
    Private Sub DataGridParaDevolucion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridParaDevolucion.CellDoubleClick
        If modo = "devolucion" Then
            Try

                Revista1 = DataGridParaDevolucion.Item(2, DataGridParaDevolucion.CurrentRow.Index).Value

                ID_Revista1 = DataGridParaDevolucion.Item(1, DataGridParaDevolucion.CurrentRow.Index).Value

                Dim a As MsgBoxResult
                a = MsgBox("Desea devolver la revista " & Revista1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")


                '       1) Si se devuelve el libro y se actualiza la Base da datos 
                If a = vbYes Then

                    Consulta = "update revistas set estado = 0 where id_revistas = '" & ID_Revista1 & "'"
                    consultar()
                    Consulta = "UPDATE prestamorevistas SET fecha_entrada = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE cedula = '" & LabelAlmacenTemporalParaLaCedula.Text & "' and id_revistas ='" & ID_Revista1 & "'"
                    consultar()
                    MsgBox("Se ha devuelto correctamente", Title:="PRESTAMO")

                    Consulta = "select p.cedula as 'Cedula de Socio', p.id_revistas as 'Codigo de Revista', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Prestamo', p.fecha_entrada as 'Fecha de Devolucion' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and cedula= '" & LabelAlmacenTemporalParaLaCedula.Text & "'"
                    consultar()
                    DataGridParaDevolucion.DataSource = Tabla

                Else

                    MsgBox("No se a devuelto la revista ", Title:="PRESTAMOS")

                    Consulta = "select p.cedula as 'Cedula de Socio', p.id_revistas as 'Codigo de Revista', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Prestamo', p.fecha_entrada as 'Fecha de Devolucion' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and cedula= '" & LabelAlmacenTemporalParaLaCedula.Text & "'"
                    consultar()
                    DataGridParaDevolucion.DataSource = Tabla

                End If

                If a = vbNo Then

                End If

            Catch ex As Exception

                MsgBox("No se devolvera la revista ", Title:="PRESTAMOS")

            End Try
        End If
    End Sub
    '///PARA IR A MODO "VER REGISTRO DEL SOCIO"///
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consulta = "select p.cedula as 'Cedula de Socio', p.id_revistas as 'Codigo de Revista', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Prestamo', p.fecha_entrada as 'Fecha de Devolucion' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where cedula= '" & LabelAlmacenTemporalParaLaCedula.Text & "'"
        consultar()
        DataGridParaDevolucion.DataSource = Tabla
        modo = "registro"
    End Sub
    '///PARA IR A MODO "VER REGISTRO DEL SOCIO"///
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Consulta = "select p.cedula as 'Cedula de Socio', p.id_revistas as 'Codigo de Revista', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Prestamo', p.fecha_entrada as 'Fecha de Devolucion' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and cedula= '" & LabelAlmacenTemporalParaLaCedula.Text & "'"
        consultar()
        DataGridParaDevolucion.DataSource = Tabla
        modo = "devolucion"
    End Sub
    '/////////////////////////////////////////////////////////FIN DE DEVOLUCION///////////////////////////////////////////////////////////////

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CarritoDeRevistas.Items.Clear()
        ListboxOculto_ParaGuardarLasIdDeLasRevistasEnElCarrito_.Items.Clear()
    End Sub

    Private Sub ButtonVerFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerFicha.Click
        FichaSocio.FichaCedulaSocio = Cedula.Text
        FichaSocio.Show()
    End Sub
End Class