Public Class Prestamos
    '//////////////VARIABLE ESPECIAL PARA REALIZAR MSGBOX YES O NO//////////
    Dim z As MsgBoxResult

    '//////////////VARIABLE PARA GUARDAR TEMPORALMENTE EL NOMBRE DEL LIBRO MAS ADELANTE//////////
    Dim Libro1 As String

    '//////////////VARIABLE PARA GUARDAR TEMPORALMENTE LA ID DEL LIBRO MAS ADELANTE//////////
    Dim cod_libros As String


    Dim Contador As Integer = 0

    Dim librorenovar As String

    Dim fecha_actual As Date
    Dim fecha_estimada As String
    Dim dia, mes, anio, diferenciaDia As Integer

    Dim VALIDADOR As String

    '///PARA QUE LA CEDULA SE PUEDA EDITAR///
    Dim ModoCedula As String = "Buscar"
    'Dim panelnombre As Integer = 0
  
    Private Sub Prestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Alineamos todo los datagridviews para que queden mas lindos :3
        DatagridModulo = VerLibrosReservados2
        Datagrid_Align()
        DatagridModulo = DataGridViewlllllVerLibrosEnExtraccionlllll
        Datagrid_Align()
        DatagridModulo = DataGridParaDevolucion
        Datagrid_Align()
        DatagridModulo = LibrosParaReservar
        Datagrid_Align()
        DatagridModulo = dgvRenovacion
        Datagrid_Align()

        ButtonVerFicha.Visible = False
        DataGridParaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ajusta las columnas al tamaño del datagrid

        '/////////////////////////////////////////////GRUPBOX CON FUNCIONES////////////////////
        'OCULTAMOS LOS GRUPOBOX
        GrupBoxExtraccion.Visible = False
        GrupBoxDevolucion.Visible = False
        ReservacionGrupBox.Visible = False
        CrearReservacionGrupBox.Visible = False
        GroupBoxRenovacion.Visible = False
        '//////////IMAGENES DEL MENU DE OPCIONES/////////

        'OCULTAMOS LAS IMAAGENES DEL MENU DE POCIONES
        PictureExtraccion.Visible = False
        PictureDevolucion.Visible = False
        PictureCrearReservacion.Visible = False
        PictureReservacion.Visible = False
        ptbRenovar.Visible = False

        'Ocultamos el boton de ver ficha
        ButtonVerFicha.Visible = False

        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////

        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If

    End Sub


    '//////////////////////////////////PARA BUSCAR CEDULA//////////////////////////////
    '///BUSCAR CEDULA CON EL BOTON///

    Dim errorcedula As Integer = 0
    Private Sub BotonParaBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParaBuscarCedula.Click
        'Si el ModoCedula esta en modo "Buscar" ahi se llamara a ActuaizarCedula para poder iniciar las funciones de el menu 
        If ModoCedula = "Buscar" Then
            ActualizarCedula()
        Else 'En caso que no este en "Buscar" se le preguntara al usuario si quiere cambiar la cedula ya ingresada 
            z = 0
            z = MsgBox("Editar la cedula reiniciara lo echo hasta el momento, desea continuar ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            If z = MsgBoxResult.Yes Then 'Si dice que si todas las funciones volveran a las del inicio, como si nada hubiera pasado
                Cedula.ReadOnly = False
                ModoCedula = "Buscar"
                BotonParaBuscarCedula.Text = "Buscar"

                '///REINICIO DE FUNCIONES///
                CarritoDeLibros.Items.Clear() 'Borra los items del ListBox carrito de libros 
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
                Cedula.Clear() 'Borramos el contenido del textbox cedula 
                PanelDelCarrito.Left = -268 'Regresamos el carrito a la ubicacion del inicio

                'Ocultamos los grupbox por seguridad
                ReservacionGrupBox.Visible = False
                GrupBoxExtraccion.Visible = False
                GrupBoxDevolucion.Visible = False
                CrearReservacionGrupBox.Visible = False
                GroupBoxRenovacion.Visible = False

                'Ocultamos los botones del menu con las funciones 
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                ptbRenovar.Visible = False

                'Ocultamos el label que muestra la cedula del socio en el carrio
                LabelParaAlmacenarLaCedulaIngresada.Visible = False

                'Ocultamos el boton de ver ficha
                ButtonVerFicha.Visible = False
            End If
        End If

    End Sub

    '///BUSCAR CEDULA AL PRECIONAR ENTER///
    Private Sub Cedula_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cedula.KeyDown
        If ModoCedula = "Buscar" Then 'Si el ModoCedula esta en modo "Buscar" ahi se llamara a ActuaizarCedula para poder iniciar las funciones de el menu 
            If e.KeyCode = Keys.Enter Then
                ActualizarCedula()
            End If

        Else 'En caso que no este en "Buscar" se le preguntara al usuario si quiere cambiar la cedula ya ingresada 
            z = 0
            z = MsgBox("Editar la cedula reiniciara lo echo hasta el momento, desea continuar ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            If z = MsgBoxResult.Yes Then 'Si dice que si todas las funciones volveran a las del inicio, como si nada hubiera pasado
                Cedula.ReadOnly = False
                ModoCedula = "Buscar"
                BotonParaBuscarCedula.Text = "Buscar"

                '///REINICIO DE FUNCIONES///
                CarritoDeLibros.Items.Clear() 'Borra los items del ListBox carrito de libros 
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
                Cedula.Clear() 'Borramos el contenido del textbox cedula 
                PanelDelCarrito.Left = -268 'Regresamos el carrito a la ubicacion del inicio

                'Ocultamos los grupbox por seguridad
                ReservacionGrupBox.Visible = False
                GrupBoxExtraccion.Visible = False
                GrupBoxDevolucion.Visible = False
                CrearReservacionGrupBox.Visible = False
                GroupBoxRenovacion.Visible = False

                'Ocultamos los botones del menu con las funciones 
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                ptbRenovar.Visible = False

                'Ocultamos el label que muestra la cedula del socio en el carrio
                LabelParaAlmacenarLaCedulaIngresada.Visible = False

                'Ocultamos el boton de ver ficha
                ButtonVerFicha.Visible = False
        End If
    End Sub

    '///ACTUALIZAR CEDULA///
    Public Sub ActualizarCedula()
        'Si la cedula esta vacia se ocultan los Grupbox, Botones y se regresan las funciones como al inicio
        If Cedula.Text = "" Then

            'Ocultamos los grupbox por seguridad
            ReservacionGrupBox.Visible = False
            GrupBoxExtraccion.Visible = False
            GrupBoxDevolucion.Visible = False
            CrearReservacionGrupBox.Visible = False
            GroupBoxRenovacion.Visible = False

            'Ocultamos los botones del menu con las funciones 
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            PictureCrearReservacion.Visible = False
            PictureReservacion.Visible = False
            ptbRenovar.Visible = False

            'Ocultamos el label que muestra la cedula del socio en el carrio
            LabelParaAlmacenarLaCedulaIngresada.Visible = False

            '///PARA QUE SE PUEDA EDITAR LA CEDULA LA PONEMOS EN READONLY = FALSE///
            Cedula.ReadOnly = False
            '///////////////////////////////////////////

            CarritoDeLibros.Items.Clear() 'Borra los items del ListBox carrito de libros 
            ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
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
                ReservacionGrupBox.Visible = False
                GrupBoxExtraccion.Visible = False
                GrupBoxDevolucion.Visible = False
                CrearReservacionGrupBox.Visible = False
                GroupBoxRenovacion.Visible = False

                'Ocultamos los botones del menu con las funciones 
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                PictureCrearReservacion.Visible = False
                PictureReservacion.Visible = False
                ptbRenovar.Visible = False

                'Ocultamos el label que muestra la cedula del socio en el carrio
                LabelParaAlmacenarLaCedulaIngresada.Visible = False

                '///PARA QUE SE PUEDA EDITAR LA CEDULA LA PONEMOS EN READONLY = FALSE///
                Cedula.ReadOnly = False
                '///////////////////////////////////////////

                CarritoDeLibros.Items.Clear() 'Borra los items del ListBox carrito de libros 
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear() 'Borra los items del ListBox carrito para almacenar ids
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
                'Ocultamos los grupbox para evitar errores
                GrupBoxExtraccion.Visible = False
                GrupBoxDevolucion.Visible = False
                ReservacionGrupBox.Visible = False
                CrearReservacionGrupBox.Visible = False
                GroupBoxRenovacion.Visible = False

                'Mostramos los botones para reaizar las funcioes 
                PictureExtraccion.Visible = True
                PictureDevolucion.Visible = True
                PictureCrearReservacion.Visible = True
                PictureReservacion.Visible = True
                ptbRenovar.Visible = True


                CarritoDeLibros.Items.Clear() 'Borramos los items de listbox carrito de libros 
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear() 'Borramos los items de listbox carrito de libros 
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


    '///////////////////////EXTRACCION///////////////////
    '///BUSCAR LIBROS PARA EXTRAER///
    Dim FechaEntradaPrestamo As Integer
    Public Sub PictureExtraccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureExtraccion.Click
        If CarritoDeLibros.Items.Count = 0 Then

            If Cedula.Text <> "" Then


                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                GrupBoxDevolucion.Visible = False
                ReservacionGrupBox.Visible = False
                CrearReservacionGrupBox.Visible = False
                GroupBoxRenovacion.Visible = False
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                Consulta = "select * from prestamolibro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                If (Tabla.Rows.Count = 0) Then
                    GrupBoxExtraccion.Visible = True
                    Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0'"
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
                            Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0'"
                            consultar()
                            DataGridViewlllllVerLibrosEnExtraccionlllll.DataSource = Tabla
                            GrupBoxExtraccion.Visible = True
                    End Select
                End If
            Else
            End If
        End If
    End Sub

    '///BUSCAR LIBRO POR ID///
    Private Sub TextboxBuscador_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextboxBuscador.TextChanged
        Try
            Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0' and cod_libro LIKE '" & TextboxBuscador.Text & "%'"
            consultar()
            DataGridViewlllllVerLibrosEnExtraccionlllll.DataSource = Tabla
        Catch ex As Exception
        End Try
    End Sub

    '///MANDAR LIBROS AL CARRITO///
    Private Sub DataGridViewlllllVerLibrosEnExtraccionlllll_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewlllllVerLibrosEnExtraccionlllll.CellDoubleClick
        'Se iguala una variable a un valor de la base de datos
        z = 0
        Dim NomLibros As String
        Dim IdLibros As String
        NomLibros = DataGridViewlllllVerLibrosEnExtraccionlllll.Item(1, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value
        IdLibros = DataGridViewlllllVerLibrosEnExtraccionlllll.Item(0, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value


        Dim list1 As Integer
        list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count

        If list1 <= 2 Then



            If DataGridViewlllllVerLibrosEnExtraccionlllll.Item(0, DataGridViewlllllVerLibrosEnExtraccionlllll.CurrentRow.Index).Value <> list1 Then
                If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(NomLibros)) Then

                    MsgBox("El libro " & NomLibros & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


                Else

                    z = MsgBox("Desea llevar al carrito el libro " & NomLibros & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")
                    If z = vbYes Then

                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(IdLibros)
                        CarritoDeLibros.Items.Add(IdLibros & "                          " & NomLibros)
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

    '///EXTREAER LIBROS CON EL BOTON///
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
        list = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then



            Consulta = "select * from prestamolibro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()

            If (Tabla.Rows.Count = 0) Then

                While contador < list
                    contador = Val(contador) + 1

                    'REVISAR ESTO'
                    Consulta = "insert into prestamolibro(cedula, cod_libro, fecha_salida, fecha_estimada, cod_prestado) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "', '" + fecha_estimada + "','" + MENU3.lbl_cedula.Text + "')"
                    consultar()

                    Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                    consultar()

                    libros = libros + 1

                End While

                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                GrupBoxExtraccion.Visible = False


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


                            Consulta = "insert into prestamolibro(cedula, cod_libro, fecha_salida, fecha_estimada, cod_prestado) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "', '" + fecha_estimada + "','" + MENU3.lbl_cedula.Text + "')"
                            consultar()


                            Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                            consultar()

                            libros = libros + 1

                        End While

                        CarritoDeLibros.Items.Clear()
                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                        MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                        GrupBoxExtraccion.Visible = False


                    Case 0

                        MsgBox("Este socios no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")
                End Select
            End If
        End If
    End Sub

    '///////////////////////DEVOLUCION///////////////////
    '///BUSCAR QUE SOCIO TIENE LIBROS PARA DEVOLVER///
    Private Sub PictureDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDevolucion.Click
        If CarritoDeLibros.Items.Count = 0 Then

            Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            DataGridParaDevolucion.DataSource = Tabla


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            GrupBoxExtraccion.Visible = False
            ReservacionGrupBox.Visible = False
            CrearReservacionGrupBox.Visible = False
            GroupBoxRenovacion.Visible = False


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            GrupBoxDevolucion.Visible = True

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub

    '///PARA DEVOLVER EL LIBRO///
    Private Sub DataGridParaDevolucion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridParaDevolucion.CellDoubleClick


        Try

            Libro1 = DataGridParaDevolucion.Item(1, DataGridParaDevolucion.CurrentRow.Index).Value
            cod_libros = DataGridParaDevolucion.Item(0, DataGridParaDevolucion.CurrentRow.Index).Value



            z = 0
            z = MsgBox("Desea devolver el libro " & Libro1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            '       1) Si se devuelve el libro con un si, se actualiza la Base da datos 
            If z = vbYes Then

                Consulta = "update libro set estado = 0 where cod_libro = '" & cod_libros & "'"
                consultar()
                Consulta = "UPDATE prestamolibro SET cod_devuelto = '" & MENU3.lbl_cedula.Text & "' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros & "'"
                consultar()
                Consulta = "UPDATE prestamolibro SET fecha_entrada = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & cod_libros & "'"
                consultar()
                MsgBox("Se ha devuelto", Title:="PRESTAMO")

                Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion' from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                DataGridParaDevolucion.DataSource = Tabla

            Else

                MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

                Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion' from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                DataGridParaDevolucion.DataSource = Tabla

            End If
        Catch ex As Exception

            MsgBox("Este libro no se devolvio", Title:="PRESTAMOS")

        End Try

    End Sub

    '///////////////////////CREAR RESERVACION///////////////////
    '///BUSCAR LIBROS PARA EXTRAER///
    Private Sub PictureCrearReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureCrearReservacion.Click
        If CarritoDeLibros.Items.Count = 0 Then

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            GrupBoxExtraccion.Visible = False
            GrupBoxDevolucion.Visible = False
            ReservacionGrupBox.Visible = False
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            CrearReservacionGrupBox.Visible = True
            Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0'"
            consultar()
            LibrosParaReservar.DataSource = Tabla

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If
    End Sub

    '///BUSCAR LIBRO POR ID///
    Private Sub TextBoxEnCrearReservaciones_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxEnCrearReservaciones.TextChanged
        Try
            Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0' and cod_libro LIKE '" & TextBoxEnCrearReservaciones.Text & "%'"
            consultar()
            LibrosParaReservar.DataSource = Tabla
        Catch ex As Exception
        End Try
    End Sub

    '///PARA RESERVAR EL LIBRO///
    Private Sub LibrosParaReservar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LibrosParaReservar.CellDoubleClick


        Libro1 = LibrosParaReservar.Item(1, LibrosParaReservar.CurrentRow.Index).Value
        cod_libros = LibrosParaReservar.Item(0, LibrosParaReservar.CurrentRow.Index).Value


        z = 0
        z = MsgBox("Desea reservar el libro " & Libro1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        '       1) Si se devuelve el libro con un si, se actualiza la Base da datos 
        If z = vbYes Then

            Consulta = "update libro set estado = 2 where cod_libro = '" & cod_libros & "'"
            consultar()
            Consulta = "insert into prestamolibro (cedula, cod_libro) VALUES ('" & Cedula.Text & "','" & cod_libros & "')"
            consultar()

            MsgBox("Se reservo el libro con exito", Title:="PRESTAMO")

            Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0'"
            consultar()
            LibrosParaReservar.DataSource = Tabla

        Else

            MsgBox("Este libro no se a reservado", Title:="PRESTAMOS")

            Consulta = "select cod_libro as 'Numero de Inventario', titulo as 'Titulo', volumen as 'Volumen', ubicacion as 'Ubicacion' from libro where estado ='0'"
            consultar()
            LibrosParaReservar.DataSource = Tabla

        End If

    End Sub

    '///////////////////////EXTRAER O ELIMINAR RESERVACIONES///////////////////
    '///BUSCAR LIBROS PARA EXTRAER///
    Dim modoExtraer As String = "On"
    Private Sub PictureReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureReservacion.Click
        If CarritoDeLibros.Items.Count = 0 Then
            If Cedula.Text <> "" Then

                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                GrupBoxDevolucion.Visible = False
                GrupBoxExtraccion.Visible = False
                CrearReservacionGrupBox.Visible = False
                ReservacionGrupBox.Visible = True
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                Consulta = "select * from prestamolibro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()
                If (Tabla.Rows.Count = 0) Then

                    Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', l.volumen as 'Volumen' from libro l inner join prestamolibro p on l.cod_libro=p.cod_libro where estado = '2' and cedula = '" + Cedula.Text + "' and p.fecha_salida is NULL and p.fecha_entrada is NULL"
                    consultar()
                    VerLibrosReservados2.DataSource = Tabla
                    modoExtraer = "On"
                    BotonExtrearReservados.Visible = True
                Else

                    MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")

                    Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', l.volumen as 'Volumen' from libro l inner join prestamolibro p on l.cod_libro=p.cod_libro where estado = '2' and cedula = '" + Cedula.Text + "' and p.fecha_salida is NULL and p.fecha_entrada is NULL"
                    consultar()
                    VerLibrosReservados2.DataSource = Tabla
                    modoExtraer = "Off"
                    BotonExtrearReservados.Visible = False
                End If
            End If
        End If
    End Sub

    '///MANDAR LIBROS AL CARRITO///
    Private Sub VerLibrosReservados2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VerLibrosReservados2.CellDoubleClick
        If modoExtraer <> "Off" Then
            'Se iguala una variable a un valor de la base de datos
            z = 0
            Dim NomLibros As String
            Dim IdLibros As String
            NomLibros = VerLibrosReservados2.Item(1, VerLibrosReservados2.CurrentRow.Index).Value
            IdLibros = VerLibrosReservados2.Item(0, VerLibrosReservados2.CurrentRow.Index).Value


            Dim list1 As Integer
            list1 = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count



            If VerLibrosReservados2.Item(0, VerLibrosReservados2.CurrentRow.Index).Value <> list1 Then
                If (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Contains(NomLibros)) Then

                    MsgBox("El libro " & NomLibros & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


                Else

                    z = MsgBox("Desea llevar al carrito el libro " & NomLibros & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")
                    If z = vbYes Then

                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Add(IdLibros)
                        CarritoDeLibros.Items.Add(IdLibros & "                          " & NomLibros)

                    End If
                End If
            End If

            If CarritoDeLibros.Items.Count <> 0 Then

                ButonParaExtreaer.Visible = True
            Else
                ButonParaExtreaer.Visible = False

            End If
        Else
            MsgBox("Este socio NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")
        End If
    End Sub

    '///ELIMINAR RESERVACION///
    Private Sub ButtonEliminarReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminarReservacion.Click
        Dim IDLIBRO As String
        IDLIBRO = InputBox("Ingrese el código del libro que desea eliminar", Title:="PRESTAMOS")
        Try
            If IDLIBRO <> "" Then

                Consulta = "update libro set estado = 0 where cod_libro ='" & IDLIBRO & "'"
                consultar()
                Consulta = "DELETE FROM `prestamolibro` WHERE cedula = '" + Cedula.Text + "' and cod_libro = '" + IDLIBRO + "'"
                consultar()
                MsgBox("Se a cancelado la reservacion", Title:="PRESTAMO")

                Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', l.volumen as 'Volumen' from libro l inner join prestamolibro p on l.cod_libro=p.cod_libro where estado = '2' and cedula = '" + Cedula.Text + "' and p.fecha_salida is NULL and p.fecha_entrada is NULL"
                consultar()
                VerLibrosReservados2.DataSource = Tabla
            Else
                MsgBox("No se canceló la reservación del libro", Title:="ERROR RESERVACIÓN")
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la eliminación de las reservación", Title:="ERROR RESERVACIÓN")
        End Try

        Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', l.volumen as 'Volumen' from libro l inner join prestamolibro p on l.cod_libro=p.cod_libro where estado = '2' and cedula = '" + Cedula.Text + "' and p.fecha_salida is NULL and p.fecha_entrada is NULL"
        consultar()
        VerLibrosReservados2.DataSource = Tabla

    End Sub

    '///EXTREAER LIBROS CON EL BOTON///
    Private Sub BotonExtrearReservados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonExtrearReservados.Click
        Dim list, contador, libros As Integer
        contador = 0

        list = 0
        list = ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
            If Cedula.Text <> "" Then



            Consulta = "select * from prestamolibro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
                consultar()

                If (Tabla.Rows.Count = 0) Then

                    While contador < list
                        contador = Val(contador) + 1


                        Consulta = "insert into prestamolibro(cedula,cod_libro,fecha_salida,cod_prestado) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "','" + MENU3.lbl_cedula.Text + "')"
                        consultar()

                        Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                        consultar()

                        libros = libros + 1

                    End While

                    CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', l.volumen as 'Volumen' from libro l inner join prestamolibro p on l.cod_libro=p.cod_libro where estado = '2' and cedula = '" + Cedula.Text + "' and p.fecha_salida is NULL and p.fecha_entrada is NULL"
                consultar()
                VerLibrosReservados2.DataSource = Tabla
                MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                    GrupBoxExtraccion.Visible = False


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


                                Consulta = "insert into prestamolibro(cedula,cod_libro,fecha_salida,cod_prestado) values('" + Cedula.Text + "','" + ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) + "','" + Date.Now.ToString("yyyy-MM-dd") + "','" + MENU3.lbl_cedula.Text + "')"
                                consultar()


                                Consulta = "update libro set estado = 1 where cod_libro = '" & ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items(libros) & "';"
                                consultar()

                                libros = libros + 1

                            End While

                            CarritoDeLibros.Items.Clear()
                        ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
                        Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', l.volumen as 'Volumen' from libro l inner join prestamolibro p on l.cod_libro=p.cod_libro where estado = '2' and cedula = '" + Cedula.Text + "' and p.fecha_salida is NULL and p.fecha_entrada is NULL"
                        consultar()
                        VerLibrosReservados2.DataSource = Tabla
                            MsgBox("Se extrajo correctamente los libros", Title:="PRESTAMO")
                            GrupBoxExtraccion.Visible = False


                        Case 0

                            MsgBox("Este socios no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")
                    End Select
                End If
            End If
    End Sub


    '///////////////////////////////MOUSE HOVER////////////////////
    '///EXTRACCION///
    Private Sub PictureExtraccion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureExtraccion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Extraccion"
    End Sub
    '///DEVOLUCION///
    Private Sub PictureDevolucion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureDevolucion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Devolucion"
    End Sub
    '///RESERVACIONES///
    Private Sub PictureReservacion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureReservacion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "ExtreaerLibro" + vbCrLf + "Reservado"
    End Sub
    '///CREAR RESERVACIONES///
    Private Sub PictureCrearReservacion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureCrearReservacion.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Crear" + vbCrLf + "Reservacion"
    End Sub
    '///PANEL X///
    Private Sub Panel3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "SELECCION " + vbCrLf + "DE" + vbCrLf + "FUNCION"
    End Sub
    '///PANEL X///
    Private Sub Panel4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "SELECCION " + vbCrLf + "DE" + vbCrLf + "FUNCION"
    End Sub

    '///////////////////////////CARRITO DE LIBROS Y IDS/////////////////////////////
    '///Eliminar un libro del carrito///
    Private Sub CarritoDeLibros_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CarritoDeLibros.MouseClick

        '/////////////////////////////////////////////
        Dim IdLibro As String
        Dim NomLibro As String

        NomLibro = CarritoDeLibros.SelectedItem
        z = 0
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If CarritoDeLibros.Items.Count <> 0 And CarritoDeLibros.SelectedIndex <> vbNull And CarritoDeLibros.SelectedItem <> "" Then
            z = MsgBox("Desea cancelar la extracción del libro? " & NomLibro & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

            If z = vbYes Then
                IdLibro = (ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.SelectedIndex = CarritoDeLibros.SelectedIndex)

                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.RemoveAt(CarritoDeLibros.SelectedIndex)
                NomLibro = CarritoDeLibros.SelectedItem
                CarritoDeLibros.Items.RemoveAt(CarritoDeLibros.SelectedIndex)
            Else
                MsgBox("La id del libro no es correcta", Title:="PRESTAMO ERROR")
            End If
        End If

    End Sub

    '///VACIAR EL CARRITO///
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        z = 0
        If CarritoDeLibros.Items.Count <> 0 Then
            z = MsgBox("Esta seguro que quiere vaciar el carrito de libros?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")
            If z = vbYes Then
                CarritoDeLibros.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLosLibrosEnElCarritollll.Items.Clear()
            End If
        End If
    End Sub

    '///////////////////////////VER FICHA/////////////////////////////
    Private Sub ButtonVerFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerFicha.Click
        FichaSocio.FichaCedulaSocio = Cedula.Text
        FichaSocio.Show()
    End Sub

    '///////////////////////////VER REGISTRO DE SOCIOS/////////////////////////////
    Private Sub ButtonVERREGISTRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVERREGISTRO.Click
        Registroprestamos.Show()
    End Sub

    '///////////////////////////IR A MODO REVISTAS/////////////////////////////
    Private Sub ButtonRevistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRevistas.Click
        PrestamoRevistas.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FichaParaImprimir2.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbRenovar.Click

        If CarritoDeLibros.Items.Count = 0 Then

            Consulta = "select p.cod_libro as 'Numero de Inventario', l.titulo as 'Titulo', p.fecha_salida as 'Fecha de Extraccion', p.fecha_entrada as 'Fecha de Devolucion', fecha_estimada as 'Fecha Maxima de Prestamo' from prestamolibro p INNER JOIN libro l on p.cod_libro=l.cod_libro where fecha_entrada is NULL and fecha_salida is NOT NULL and cedula= '" & Cedula.Text & "'"
            consultar()
            dgvRenovacion.DataSource = Tabla

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            GrupBoxExtraccion.Visible = False
            ReservacionGrupBox.Visible = False
            CrearReservacionGrupBox.Visible = False
            GrupBoxDevolucion.Visible = False

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            GroupBoxRenovacion.Visible = True

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            MsgBox("Para cambiar de tarea debe tener el carrito vacio", Title:="Error")

        End If

    End Sub

    Private Sub dgvRenovacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRenovacion.CellDoubleClick
        librorenovar = dgvRenovacion.Item(0, dgvRenovacion.CurrentRow.Index).Value

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
                Consulta = "update prestamolibro set fecha_estimada = '" + fecha_estimada + "', cod_prestado = '" + MENU3.cedulaIngre + "', renovacion = 1 where fecha_entrada is NULL and cedula = '" + Cedula.Text + "' and cod_libro = '" + librorenovar + "'"
                consultar()
                MsgBox("Se renovo el prestamo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub ptbRenovar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptbRenovar.MouseHover
        LabelSELECCION_DE_FUNCION.Text = "Renovar Libros"
    End Sub
End Class
