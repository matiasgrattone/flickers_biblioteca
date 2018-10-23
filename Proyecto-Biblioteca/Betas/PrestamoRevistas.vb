Public Class PrestamoRevistas

    Dim z As MsgBoxResult
    Dim h As String
    Dim a As String
    Dim Revista1 As String
    Dim ID_Revista1 As String
    Dim Contador As Integer = 0
    Dim VALIDADOR As String
    Dim panelnombre As Integer = 0

    '//////////////VARIABLE PARA GUARDAR TEMPORALMENTE LA ID DEL LAS REVISTAS MAS ADELANTE//////////

    Dim revisarenovar As String

    Dim fecha_actual As Date
    Dim fecha_estimada As String
    Dim dia, mes, anio, diferenciaDia, diferenciaDia1 As Integer

    Dim FechaEntradaPrestamo As Integer

    Dim errorcedula As Integer = 0

    '///PARA QUE LA CEDULA SE PUEDA EDITAR///
    Dim ModoCedula As String = "Buscar"
    'Dim panelnombre As Integer = 0

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ButtonVerFicha.Visible = False
        PictureRenovacion.Visible = False
        GroupBoxRenovacion.Visible = False
        ExtGrup.Visible = False
        DevoGRUP.Visible = False
        ButonParaExtreaer.Visible = False
        PictureExtraccion.Visible = False
        PictureDevolucion.Visible = False
        LabelParaAlmacenarLaCedulaIngresada.Text = ""
        LabelSELECCION_DE_FUNCION.Visible = False
        ButtonMoroso.Visible = False
        LblREVISTAS.Visible = True
        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////
        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If
    End Sub
    Private Sub BotonParaBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParaBuscarCedula.Click
        'Si el ModoCedula esta en modo "Buscar" ahi se llamara a ActuaizarCedula para poder iniciar las funciones de el menu 
        If ModoCedula = "Buscar" And ERROR1 = 0 Then
            ActualizarCedula()
        ElseIf ERROR1 = 0 Then 'En caso que no este en "Buscar" se le preguntara al usuario si quiere cambiar la cedula ya ingresada 
            z = 0
            z = MsgBox("Editar la cedula reiniciara lo echo hasta el momento, desea continuar ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            If z = MsgBoxResult.Yes Then 'Si dice que si todas las funciones volveran a las del inicio, como si nada hubiera pasado
                Cedula.ReadOnly = False
                ModoCedula = "Buscar"
                BotonParaBuscarCedula.Text = "Buscar"

                '///REINICIO DE FUNCIONES///
                CarritoDeRevistas.Items.Clear() 'Borra los items del ListBox carrito de libros 
                ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
                Cedula.Clear() 'Borramos el contenido del textbox cedula 
                PanelDelCarrito.Left = -268 'Regresamos el carrito a la ubicacion del inicio

                'Ocultamos los grupbox por seguridad
                GroupBoxRenovacion.Visible = False
                ExtGrup.Visible = False
                DevoGRUP.Visible = False

                'Ocultamos los botones del menu con las funciones 
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureRenovacion.Visible = False

                'Ocultamos el label que muestra la cedula del socio en el carrio
                LabelParaAlmacenarLaCedulaIngresada.Visible = False

                'Ocultamos el boton de ver ficha
                ButtonVerFicha.Visible = False
            End If
        End If
    End Sub
    Private Sub PictureExtraccion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureExtraccion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Extraccion"
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureRenovacion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Renovación"
    End Sub

    Private Sub PictureDevolucion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureDevolucion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Devolucion"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerRegistro.Click
        If ERROR1 = 0 Then
            registrorevistas.Show()
        End If
    End Sub
    Private Sub ButonLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Es_moroso As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & LabelParaAlmacenarLaCedulaIngresada.Text & "'  "
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

                    Consulta = "update usuarios set (tipo = ""0"") where cedulaU = '" & LabelParaAlmacenarLaCedulaIngresada.Text & "';"
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

            If LabelParaAlmacenarLaCedulaIngresada.Text <> "" Then


                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                DevoGRUP.Visible = False
                GroupBoxRenovacion.Visible = False
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                Consulta = "select * from prestamorevistas where fecha_entrada is NULL and cedula= '" & LabelParaAlmacenarLaCedulaIngresada.Text & "'"
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
                            Consulta = "select id_revistas as 'Codigo de Revista', titulo as 'Titulo', descripcion as 'Descripcion' from revistas where estado = '0'"
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
        Dim list, contador, revistas As Integer
        contador = 0

        '///////////////////////////////////////////////////////////////////////////////////
        '///////////////Calcula la fecha en que deberia entregarse la revista/////////////////
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
        list = ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Count
        list = list

        '1) El usario que puede extraer una revista SI ESTE NO TIENE NINGUNA REVISTAS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then



            Consulta = "select * from prestamorevistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()

            If (Tabla.Rows.Count = 0) Then

                While contador < list
                    contador = Val(contador) + 1

                    Consulta = "insert into prestamorevistas(cedula, id_revistas, fecha_estimada, cod_prestado) values('" + Cedula.Text + "','" + ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items(revistas) + "', '" + fecha_estimada + "','" + MENU3.lbl_cedula.Text + "')"
                    consultar()
                    Consulta = "update prestamorevistas set fecha_salida = '" + Date.Now.ToString("yyyy-MM-dd") + "' where id_revistas= '" & ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items(revistas) & "' and cedula='" + Cedula.Text + "'"
                    consultar()

                    Consulta = "update revistas set estado = 1 where id_revistas = '" & ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items(revistas) & "'"
                    consultar()

                    revistas = revistas + 1
                End While

                CarritoDeRevistas.Items.Clear()
                ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear()
                MsgBox("Se extrajo correctamente las revistas", Title:="PRESTAMO")
                ExtGrup.Visible = False


            Else


                For Each row As DataRow In Tabla.Rows
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


                            Consulta = "insert into prestamorevistas(cedula, id_revistas, fecha_salida, fecha_estimada, cod_prestado) values('" + Cedula.Text + "','" + ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items(revistas) + "','" + Date.Now.ToString("yyyy-MM-dd") + "', '" + fecha_estimada + "','" + MENU3.lbl_cedula.Text + "')"
                            consultar()


                            Consulta = "update revistas set estado = 1 where id_revistas = '" & ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items(revistas) & "';"
                            consultar()

                            revistas = revistas + 1

                        End While

                        CarritoDeRevistas.Items.Clear()
                        ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear()
                        MsgBox("Se extrajo correctamente las revistas", Title:="PRESTAMO")
                        ExtGrup.Visible = False


                    Case 0

                        MsgBox("Este socios no puede retirar revistas hasta devolver los prestados", Title:="PRESTAMOS")
                End Select
            End If
            revistas = 0
        End If
    End Sub
    '///PARA LLEVAR LAS REVISTAS AL CARRTIO///
    Private Sub DataGridView_VerRevistasEnExtraccion__CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_VerRevistasEnExtraccion_.CellDoubleClick

        '////////////////////////////SI LA CEDULA ES CORRECTA SE PODRA AGREGAR REVISTAS O REALIZAR OTRAS FUNCIONES  /////////////////////// 
        Dim list1 As Integer
        list1 = ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Count

        If list1 <= 2 Then

            If DataGridView_VerRevistasEnExtraccion_.Item(0, DataGridView_VerRevistasEnExtraccion_.CurrentRow.Index).Value <> list1 Then

                Dim NomREVISTA As String
                Dim IdREVISTA As String

                NomREVISTA = DataGridView_VerRevistasEnExtraccion_.Item(1, DataGridView_VerRevistasEnExtraccion_.CurrentRow.Index).Value
                IdREVISTA = DataGridView_VerRevistasEnExtraccion_.Item(0, DataGridView_VerRevistasEnExtraccion_.CurrentRow.Index).Value



                If (ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Contains(IdREVISTA)) Then

                    MsgBox("La revista " & NomREVISTA & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


                Else

                    z = MsgBox("Desea llevar al carrito la revista " & NomREVISTA & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                    If z = vbYes Then


                        ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Add(IdREVISTA)
                        CarritoDeRevistas.Items.Add(IdREVISTA & "                          " & NomREVISTA)

                    End If
                End If
            End If

            If CarritoDeRevistas.Items.Count <> 0 Then

                ButonParaExtreaer.Visible = True
            Else
                ButonParaExtreaer.Visible = False

            End If
        End If
    End Sub
    '/////////////////////////////////////////////////////////FIN DE EXTRACCION///////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////RENOVACIÓN///////////////////////////////////////////////////////////////
    '///PARA INICIAR FUNCIONES DE RENOVACIÓN///
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureRenovacion.Click
        If CarritoDeRevistas.Items.Count = 0 Then

            Consulta = "select r.id_revistas as 'Numero de Inventario', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            dgvRenovacion.DataSource = Tabla

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExtGrup.Visible = False
            DevoGRUP.Visible = False
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            GroupBoxRenovacion.Visible = True

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub
    '///PARA RENOVAR LAS REVISTAS EXTRAIDAS///
    Private Sub dgvRenovacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRenovacion.CellContentClick
        revisarenovar = dgvRenovacion.Item(0, dgvRenovacion.CurrentRow.Index).Value

        If MsgBox("Desea renovar el libro " & dgvRenovacion.Item(1, dgvRenovacion.CurrentRow.Index).Value & "?", MsgBoxStyle.YesNo, Title:="PRESTAMOS") = vbYes Then

            '///////////////////////////////////////////////////////////////////////////////////
            '///////////////Calcula la fecha en que deberia entregarse el libro/////////////////
            '///////////////////////////////////////////////////////////////////////////////////
            fecha_actual = DateTime.Now.ToString("yyyy/MM/dd")

            dia = Val(DateTime.Now.ToString("dd")) + 7
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

            Try
                'Renovacion sera 1 en la base de datos, 0 para cuando no lo se lo haya hecho
                Consulta = "update prestamorevistas set fecha_estimada = '" + fecha_estimada + "', cod_prestado = '" + MENU3.cedulaIngre + "', renovacion = 1 where fecha_entrada is NULL and cedula = '" + Cedula.Text + "' and id_revistas = '" + revisarenovar + "'"
                consultar()
                MsgBox("Se renovo el prestamo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Consulta = "select r.id_revistas as 'Numero de Inventario', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
        consultar()
        dgvRenovacion.DataSource = Tabla
    End Sub
    '/////////////////////////////////////////////////////////FIN DE RENOVACIÓN///////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////DEVOLUCION///////////////////////////////////////////////////////////////
    '///PARA INICIAR FUNCIONES DE DEVOLUCION///
    Private Sub PictureDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDevolucion.Click

        If CarritoDeRevistas.Items.Count = 0 Then


            Consulta = "select p.id_revistas as 'Numero de Inventario', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            DataGridParaDevolucion.DataSource = Tabla

            DatagridModulo = DataGridParaDevolucion
            Datagrid_Align()

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ExtGrup.Visible = False
            DevoGRUP.Visible = True
            GroupBoxRenovacion.Visible = False
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else

            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub
    '///PARA DEVOLVER LAS REVISTAS EXTRAIDAS///
    Private Sub DataGridParaDevolucion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridParaDevolucion.CellDoubleClick
        Try

            Revista1 = DataGridParaDevolucion.Item(1, DataGridParaDevolucion.CurrentRow.Index).Value
            ID_Revista1 = DataGridParaDevolucion.Item(0, DataGridParaDevolucion.CurrentRow.Index).Value

            fecha_actual = DateTime.Now.ToString("yyyy/MM/dd")

            dia = (DataGridParaDevolucion.Item(4, DataGridParaDevolucion.CurrentRow.Index).Value).ToString.Substring(0, 2)
            mes = (DataGridParaDevolucion.Item(4, DataGridParaDevolucion.CurrentRow.Index).Value).ToString.Substring(3, 2)
            anio = Val(DateTime.Now.ToString("yyyy"))

            fecha_estimada = DataGridParaDevolucion.Item(4, DataGridParaDevolucion.CurrentRow.Index).Value

            If mes > fecha_actual.ToString.Substring(3, 2) Then

                If dia >= 31 Then
                    diferenciaDia = dia - 31
                    dia = dia - diferenciaDia
                    mes = mes + 1
                    fecha_estimada = anio & "-" & mes & "-" & dia
                Else
                    fecha_estimada = anio & "-" & mes & "-" & dia
                End If

            Else

                diferenciaDia = dia - fecha_actual.ToString.Substring(0, 2)

            End If

            If diferenciaDia < 0 Then

                diferenciaDia = diferenciaDia * (-2)

                If diferenciaDia >= 31 Then
                    diferenciaDia1 = diferenciaDia - 31
                    diferenciaDia1 = diferenciaDia - diferenciaDia1
                    mes = mes + 1
                    dia = fecha_actual.ToString.Substring(0, 2) + diferenciaDia1
                    fecha_estimada = anio & "-" & mes & "-" & dia
                Else
                    dia = fecha_actual.ToString.Substring(0, 2) + diferenciaDia
                    fecha_estimada = anio & "-" & mes & "-" & dia
                End If

                Try
                    Consulta = "update usuarios set moroso = '1', fecha_moroso = '" + fecha_estimada + "' where cedula = '" + Cedula.Text + "'"
                    consultar()
                    MsgBox("El usuario es ahora moroso hasta " & fecha_estimada & " por devolver la revista fuera de la fecha máxima")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

            z = 0
            z = MsgBox("Desea devolver la revista " & Revista1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            '       1) Si se devuelve la revistas con un si, se actualiza la Base da datos 
            If z = vbYes Then


                Consulta = "update revistas set estado = 0 where id_revistas = '" & ID_Revista1 & "'"
                consultar()
                Consulta = "UPDATE prestamorevistas SET cod_devuelto = '" & MENU3.lbl_cedula.Text & "', fecha_entrada = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE cedula = '" & Cedula.Text & "' and id_revistas ='" & ID_Revista1 & "'"
                consultar()
                'Consulta = "UPDATE prestamorevistas SET fecha_entrada = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE cedula = '" & Cedula.Text & "' and id_revistas ='" & id_revistas1 & "'"
                'consultar()
                MsgBox("Se ha devuelto", Title:="PRESTAMO")

                Consulta = "select p.id_revistas as 'Numero de Inventario', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                DataGridParaDevolucion.DataSource = Tabla

            Else

                MsgBox("Esta revista no se devolvio", Title:="PRESTAMOS")

                Consulta = "select p.id_revistas as 'Numero de Inventario', r.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamorevistas p INNER JOIN revistas r on p.id_revistas=r.id_revistas where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                DataGridParaDevolucion.DataSource = Tabla

            End If
        Catch ex As Exception

            MsgBox("Esta revista no se devolvio", Title:="PRESTAMOS")

        End Try
    End Sub

    '/////////////////////////////////////////////////////////FIN DE DEVOLUCION///////////////////////////////////////////////////////////////

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CarritoDeRevistas.Items.Clear()
        ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear()
    End Sub

    Private Sub ButtonVerFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerFicha.Click
        If ERROR1 = 0 Then
            FichaSocio.FichaCedulaSocio = Cedula.Text
            FichaSocio.Show()
        End If
    End Sub

    Private Sub Cedula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cedula.KeyDown
        If ModoCedula = "Buscar" And ERROR1 = 0 Then 'Si el ModoCedula esta en modo "Buscar" ahi se llamara a ActuaizarCedula para poder iniciar las funciones de el menu 
            If e.KeyCode = Keys.Enter Then
                ActualizarCedula()
            End If

        ElseIf ERROR1 = 0 Then 'En caso que no este en "Buscar" se le preguntara al usuario si quiere cambiar la cedula ya ingresada 
            z = 0
            z = MsgBox("Editar la cedula reiniciara lo echo hasta el momento, desea continuar ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            If z = MsgBoxResult.Yes Then 'Si dice que si todas las funciones volveran a las del inicio, como si nada hubiera pasado
                Cedula.ReadOnly = False
                ModoCedula = "Buscar"
                BotonParaBuscarCedula.Text = "Buscar"

                '///REINICIO DE FUNCIONES///
                CarritoDeRevistas.Items.Clear() 'Borra los items del ListBox carrito de libros 
                ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
                Cedula.Clear() 'Borramos el contenido del textbox cedula 
                PanelDelCarrito.Left = -268 'Regresamos el carrito a la ubicacion del inicio

                'Ocultamos los grupbox por seguridad
                GroupBoxRenovacion.Visible = False
                ExtGrup.Visible = False
                DevoGRUP.Visible = False

                'Ocultamos los botones del menu con las funciones 
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureRenovacion.Visible = False

                'Ocultamos el label que muestra la cedula del socio en el carrio
                LabelParaAlmacenarLaCedulaIngresada.Visible = False

                'Ocultamos el boton de ver ficha
                ButtonVerFicha.Visible = False
                LabelSELECCION_DE_FUNCION.Visible = False
            End If
        End If
    End Sub

    Private Sub TextboxBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextboxBuscador.TextChanged
        Try
            Consulta = "select id_revistas as 'Codigo de Revista', titulo as 'Titulo', descripcion as 'Descripcion' from revistas where estado = '0' and id_revistas LIKE '" & TextboxBuscador.Text & "%'"
            consultar()
            DataGridView_VerRevistasEnExtraccion_.DataSource = Tabla
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CarritoDeRevistas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CarritoDeRevistas.MouseClick
        '/////////////////////////////////////////////
        Dim IdRevistas As String
        Dim NomRevistas As String

        NomRevistas = CarritoDeRevistas.SelectedItem
        z = 0
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If CarritoDeRevistas.Items.Count <> 0 And CarritoDeRevistas.SelectedIndex <> vbNull And CarritoDeRevistas.SelectedItem <> "" Then
            z = MsgBox("Desea cancelar la extracción de la revista? " & NomRevistas & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            If z = vbYes Then
                IdRevistas = (ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.SelectedIndex = CarritoDeRevistas.SelectedIndex)

                ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.RemoveAt(CarritoDeRevistas.SelectedIndex)
                NomRevistas = CarritoDeRevistas.SelectedItem
                CarritoDeRevistas.Items.RemoveAt(CarritoDeRevistas.SelectedIndex)
            Else
                MsgBox("La id del la revista no es correcta", Title:="PRESTAMO ERROR")
            End If
        End If
    End Sub

    '///ACTUALIZAR CEDULA///
    Public Sub ActualizarCedula()
        'Si la cedula esta vacia se ocultan los Grupbox, Botones y se regresan las funciones como al inicio
        If Cedula.Text = "" Then

            'Ocultamos los grupbox por seguridad
            ExtGrup.Visible = False
            DevoGRUP.Visible = False
            GroupBoxRenovacion.Visible = False

            'Ocultamos los botones del menu con las funciones 
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            PictureRenovacion.Visible = False

            'Ocultamos el label que muestra la cedula del socio en el carrio
            LabelParaAlmacenarLaCedulaIngresada.Visible = False

            '///PARA QUE SE PUEDA EDITAR LA CEDULA LA PONEMOS EN READONLY = FALSE///
            Cedula.ReadOnly = False
            LabelSELECCION_DE_FUNCION.Visible = False
            '///////////////////////////////////////////

            CarritoDeRevistas.Items.Clear() 'Borra los items del ListBox carrito de libros 
            ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
            Cedula.Clear() 'Borramos el contenido del textbox cedula 
            PanelDelCarrito.Left = -268 'Regresamos el carrito a la ubicacion del inicio

            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
            'Ocultamos el boton de ver ficha
            ButtonVerFicha.Visible = False
            '/////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            Consulta = "select cedula from usuarios where cedula like '" & Cedula.Text & "'"
            consultar()

            If Tabla.Rows.Count = 0 Then ' VERFICAR SI ES NULO EL RESULTADO DE LA CONSULTA


                'Ocultamos los grupbox por seguridad
                ExtGrup.Visible = False
                DevoGRUP.Visible = False
                GroupBoxRenovacion.Visible = False

                'Ocultamos los botones del menu con las funciones 
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureRenovacion.Visible = False

                'Ocultamos el label que muestra la cedula del socio en el carrio
                LabelParaAlmacenarLaCedulaIngresada.Visible = False

                '///PARA QUE SE PUEDA EDITAR LA CEDULA LA PONEMOS EN READONLY = FALSE///
                Cedula.ReadOnly = False
                LabelSELECCION_DE_FUNCION.Visible = False
                '///////////////////////////////////////////

                CarritoDeRevistas.Items.Clear() 'Borra los items del ListBox carrito de libros 
                ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
                Cedula.Clear() 'Borramos el contenido del textbox cedula 
                PanelDelCarrito.Left = -268 'Regresamos el carrito a la ubicacion del inicio

                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
                'Ocultamos el boton de ver ficha
                ButtonVerFicha.Visible = False

            Else

                'Hacemos una consulta a usuarios cuando la cedula sea igual a la ingresada por el programa
                Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'"
                consultar()
                Try
                    For Each row As DataRow In Tabla.Rows
                        NOMBRE.Text = row("nombre") 'Hacemos un for each y iguaamos el label nombre al nombre dado por la consulta echa ya
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                '////////////////////////////////////////////////////////////////////////////////////////////////////////
                '///////////////////////Muestra los picturebox y la prepara la interfaz de las funciones/////////////////
                '////////////////////////////////////////////////////////////////////////////////////////////////////////
                'Ocultamos los grupbox por evitar errores
                ExtGrup.Visible = False
                DevoGRUP.Visible = False
                GroupBoxRenovacion.Visible = False

                'Mostramos los botones para reaizar las funcioes 
                PictureExtraccion.Visible = True
                PictureDevolucion.Visible = True
                PictureRenovacion.Visible = True
                LabelSELECCION_DE_FUNCION.Visible = True

                CarritoDeRevistas.Items.Clear() 'Borramos los items de listbox carrito de libros 
                ListboxParaGuardarLasIdDeLasRevistasEnElCarrito.Items.Clear() 'Borramos los items de listbox carrito de libros 
                PanelDelCarrito.Left = -5 'Mostramos el carrito

                BotonParaBuscarCedula.Text = "Editar" 'Ponemos el texto de buscar cedula en "editar"
                ModoCedula = "Editar" 'Ponemos el ModoCedula en modo "editar"
                Cedula.ReadOnly = True 'Ponemos el textbox para la cedula en modo readOnly
                ButtonVerFicha.Visible = True 'Mostramos el boton para ver la ficha
                LabelParaAlmacenarLaCedulaIngresada.Visible = True 'Mostramos el label que muestra la cedula ingresada con la cual hacer las funciones
                LabelParaAlmacenarLaCedulaIngresada.Text = Cedula.Text 'Lo igualamos al textbox 

                '/////////////////////////////////////////////////////////////////////////////////////////////
            End If
        End If
    End Sub

    Private Sub DataGridParaDevolucion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridParaDevolucion.CellContentClick

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PanelDelLeft.Left -= 5
        If PanelDelLeft.Left <= -Width Then
            PanelDelLeft.Left = Width
        End If

        If PanelDelLeft.Location.X < 795 Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub
End Class