Imports System.Threading
Imports System.Text.RegularExpressions
Public Class MENU3
    Dim a As Integer = 0 'mouse activado para mover la ventana
    Public xco, yco As Integer 'nueva ubicacion del el cursor
    Dim xc, yc As Integer 'primer ubicacion del cursor
    Dim xf, yf As Integer 'primer ubicacion del formulario
    Dim holax, holay As Integer '

    Dim seleccionado As String = "Inicio" 'variable para verificar que opcion del menu esta seleccionada

    Dim PrimerInicio As Integer = 1 'verificar si es el primer inicio del programa
    Dim ContadorDia As Integer = 0 'contador para poder ingresar los dias en los graficos
    Dim ContadorMes As Integer = 0 'contador para poder ingresar los meses en los graficos
    Public BD_ONLINE As Integer = 0 'verificar si la base de datos esta online
    Dim primeriniciotimer As Integer = 1 'verifcar si es el primer inicio para el timer

    Public F3 As New Seleccion_Libro

    Public cedulaIngre As String ' Variable para actualizar foto de perfil, se carga en el load
    Public cedulaAdmin As String ' Variable para cargar foto de perfil en admin, se carga al abrir config admin
    Dim pictureboxPrestamosSwitch As Integer

    Private Sub inicio() 'metodo para verificar si hay un libro que se tiene que entregar en el dia
        If ERROR1 = 0 Then
            Try
                Chart() 'llama al metodo para cargar los graficos
                Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd") 'variable para filtrar la fecha estimada para entregar el libro
                Consulta = "select titulo from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where fecha_estimada='" + fecha + "'"
                consultar()
                For Each row As DataRow In Tabla.Rows
                    If Not IsDBNull(row("titulo")) Then 'verifica si titulo no es nulo para poder activar el panel de libros que hay que entregar en el dia
                        Pbadvertenciaprestamos.Visible = True
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub MENU3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        xf = Me.Location.X 'obtiene la ubicacion Y del formulario
        yf = Me.Location.Y 'obtiene la ubicacion X del forumario

        Rueda_de_carga1.Visible = False 'desactiva la rueda de carga
        verificarBD() 'llama al metodo para verificar si esta ONLINE la base de datos

        If ERROR1 = 0 Then


            Consulta = "select prestamolibro.cod_libro as ID, libro.titulo , usuarios.nombre from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where fecha_entrada is null"
            consultar()
            DataGridViewLibros.DataSource = Tabla
            DataGridViewLibros.Columns(0).HeaderText = "Nº de inventario"
            DatagridModulo = DataGridViewLibros 'iguala la varible publica de tipo datagrid al datagrid que recibe los datos de la consulta
            Datagrid_Align() 'llama al metodo para alinear las filas y las columnas del datagrid

            cedulaIngre = lbl_cedula.Text ' Variable para actualizar foto de perfil

            Consulta = "select rutaperfil from usuarios where cedula ='" + cedulaIngre + "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                Pbusuario.ImageLocation = (Convert.ToString(row("rutaperfil"))) 'iguala el picturebox de MENU3 con la ubicacion de la imagen guardada en la base
            Next

            Consulta = "select cod_prestamosLive from MenuConfig where cod_usuario = '" & lbl_cedula.Text & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                If row("cod_prestamosLive") = "1" Then
                    PictureBox5.Image = Image.FromFile("imagenes/switch_on.png")
                    pictureboxPrestamosSwitch = 1
                    Timer_Prestamos_LIVE.Enabled = True
                Else
                    PictureBox5.Image = Image.FromFile("imagenes/switch_off.png")
                    pictureboxPrestamosSwitch = 0
                    Timer_Prestamos_LIVE.Enabled = False
                End If
            Next
            If Tabla.Rows.Count = 0 Then
                PictureBox5.Image = Image.FromFile("imagenes/switch_off.png")
                pictureboxPrestamosSwitch = 0
                Timer_Prestamos_LIVE.Enabled = False
            End If

        End If

        If ERROR1 = 0 Then 'si no hay error , llama al metodo chart para cargar las graficas , activa el timer_Prestamos  y llama al metodo inicio para verificar si hay libros para devolver en el dia
            Chart()
            inicio()
            If pictureboxPrestamosSwitch = 1 Then
                Timer_Prestamos_LIVE.Enabled = True
            Else
                Timer_Prestamos_LIVE.Enabled = False
            End If
        End If

        substring = Date.Now.ToString("MM")
        mes()

        For Each item In ComboBox1.Items

            If substring = item Then
                ComboBox1.SelectedIndex = ContadorMes
            End If
            ContadorMes = ContadorMes + 1
        Next

        ComboBox1.Items.Add("Mes")
        ComboBox1.Items.Add("Enero")
        ComboBox1.Items.Add("Febrero")
        ComboBox1.Items.Add("Marzo")
        ComboBox1.Items.Add("Abril")
        ComboBox1.Items.Add("Mayo")
        ComboBox1.Items.Add("Junio")
        ComboBox1.Items.Add("Julio")
        ComboBox1.Items.Add("Agosto")
        ComboBox1.Items.Add("Septiembre")
        ComboBox1.Items.Add("Octubre")
        ComboBox1.Items.Add("Noviembre")
        ComboBox1.Items.Add("Diciembre")
        substring = Date.Now.ToString("MM")
        mes()
        ComboBox1.SelectedItem = substring


        For i As Integer = 1899 To Date.Now.ToString("yyyy")
            If i = 1899 Then
                ComboBox2.Items.Add("Año")
            Else
                ComboBox2.Items.Add(i)
            End If
            ComboBox2.SelectedItem = i
        Next

        '///////////////////VENTANA DE LIBROS QUE SE DEVUELVEN EN EL DIA///////////////////////
        Pbadvertenciaprestamos.Visible = False
        Panel_prestamosdia.Visible = False

        'mueve todos los labels de seleccion al left 72

        label_usuarios.Left = 72
        label_libros.Left = 72
        LabelInicio.Left = 72
        LabelRevistas.Left = 72
        label_prestamos.Left = 72
        label_navegador.Left = 72
        Label_Prestamos_Revistas.Left = 72
        Label_Prestamos_Revistas.Text = "Prestamos" & vbNewLine & " Revistas"
        label_prestamos.Text = "Prestamos" & vbNewLine & " Libros"
        Preparar_Form()

        'todos los paneles de seleccion con backcolor silver

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.LightGray
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Chart()
    End Sub
    '////////////////////////////////Movimiento de Ventana//////////////////////////////////////////////////
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Phoraencabezado.MouseDown
        a = 1
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Phoraencabezado.MouseMove
        If a = 1 Then 'si el mouse esta presionado
            xc = Cursor.Position.X 'iguala la variable xc a la posicion del cursor X
            yc = Cursor.Position.Y 'iguala la varibale yc a la posicion del cursor Y
            holax = xc - xco 'resta la antigua posicion X del mouse con la nueva ubicacion para obtener cuanta distancia se movio el mouse
            holay = yc - yco 'resta la antigua posicion Y del mouse con la nueva ubicacion para obtener cuanta distancia se movio el mouse
            Me.Location = New Point(xf + holax, yf + holay) 'fija la nueva ubicacion del formulario a la suma de la ubicacion del formulario XY con la resta de la ubicacion del mouse XY
            Me.Opacity = 0.9 'cambia la propiedad del opacity del formulario a 0.9
            Timer_Prestamos_LIVE.Enabled = False
        End If
        If a = 0 Then 'si el mouse no esta presionado
            xco = Cursor.Position.X 'nueva posicion del cursor Y
            yco = Cursor.Position.Y 'nueva posicion del cursor X
            Timer_Prestamos_LIVE.Enabled = True 'activa el timer prestamos
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Phoraencabezado.MouseUp
        xf = Me.Location.X 'iguala la variable xf a la ubicacion X del formulario
        yf = Me.Location.Y 'iguala la variable yf a la ubicacion Y del formulario
        a = 0 'si el mouse no esta presionado
        Me.Opacity = 1 'fija la opacidad del fomulario a 1
    End Sub
    Private Sub panel_usuarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseEnter
        If seleccionado = "usuarios" Then 'si esta seleccionado el sector usuarios
        Else
            panel_usuarios.BackColor = Drawing.Color.LightGray 'si no esta seleccionado el sector usuarios
        End If
    End Sub
    Private Sub panel_usuarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseLeave
        If seleccionado = "usuarios" Then 'si esta seleccionado el sector usuarios
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver 'si no esta seleccionado el sector usuarios
        End If
    End Sub
    Private Sub panel_usuarios_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_usuarios.MouseClick
        usuariosForm()
    End Sub
    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseEnter
        If seleccionado = "usuarios" Then 'si esta seleccionado el sector usuarios
        Else
            panel_usuarios.BackColor = Drawing.Color.LightGray 'si no esta seleccionado usuarios , fija el backcolor como lightgray
        End If
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseLeave
        If seleccionado = "usuarios" Then 'si esta seleccionado el sector usuarios
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver 'si no esta seleccionado usuarios , fija el backcolor como silver
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuarios.Click
        usuariosForm()
    End Sub
    Private Sub panel_libros_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseEnter
        If seleccionado = "libros" Then 'selecciona libros
        Else
            panel_libros.BackColor = Drawing.Color.LightGray 'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub
    Private Sub panel_libros_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseLeave
        If seleccionado = "libros" Then 'selecciona libros
        Else
            panel_libros.BackColor = Drawing.Color.Silver 'si no esta seleccionado pone el backcolor en silver
        End If
    End Sub
    Private Sub panel_libros_Mouseclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_libros.MouseClick
        librosForm()
    End Sub
    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseEnter
        If seleccionado = "libros" Then 'si esta seleccioado libros
        Else
            panel_libros.BackColor = Drawing.Color.LightGray 'si no esta seleccionado el panel , pone como backcolor a lightgray
        End If
    End Sub
    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseLeave
        If seleccionado = "libros" Then 'si esta seleccionado libros
        Else
            panel_libros.BackColor = Drawing.Color.Silver 'si no esta seleccioado libros entonces pone el backcolor como silver
        End If
    End Sub
    Public Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pblibros.Click
        librosForm()
    End Sub
    Private Sub panel_prestamos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseEnter
        If seleccionado = "prestamos" Then 'si esta seleccionado prestamos
        Else
            panel_prestamos.BackColor = Drawing.Color.LightGray 'si no esta seleccionado prestamos , el backcolor lo define en lightgray
        End If
    End Sub
    Private Sub panel_prestamos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_prestamos.MouseClick
        prestamosLibrosForm()
    End Sub
    Private Sub panel_prestamos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseLeave
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbprestamos.MouseEnter
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbprestamos.MouseLeave
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbprestamos.Click
        prestamosLibrosForm()
    End Sub
    Private Sub panel_navegador_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_navegador.MouseEnter
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub panel_navegador_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_navegador.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbnavegador.MouseEnter
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbnavegador.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbnavegador.Click
        navegadorForm()
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Wbnavegador.DocumentCompleted
        txtbuscar.Text = Wbnavegador.Document.Url.ToString()
    End Sub
    Public Function ValidarURL(ByVal url As String) As Boolean
        Dim re As Regex = New Regex("^(https?|ftp|file)://[-A-Z0-9+&@#/%?=~_|!:,.;]*[-A-Z0-9+&@#/%=~_|]", RegexOptions.IgnoreCase)
        Dim m As Match = re.Match(url)
        If m.Captures.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub Navegar(ByVal url As String)
        Try
            Wbnavegador.Navigate(url)
        Catch ex As Exception
            MsgBox("Lo siento. Si has llegado hasta este mensaje ocurrió un error, pero tranquilo que no pasa nada", "Genesis Navigator")
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (ValidarURL(txtbuscar.Text) = True) Then
                Navegar(txtbuscar.Text)
            Else
                Navegar("http://" & txtbuscar.Text)
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Wbnavegador.GoBack()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadelante.Click
        Wbnavegador.GoForward()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaginainicio.Click
        Wbnavegador.Navigate("www.ecosia.org")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecargar.Click
        Wbnavegador.Refresh()
    End Sub
    Private Sub panel_navegador_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_navegador.MouseClick
        navegadorForm()
    End Sub
    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbrevistas.Click
        revistasForm()
    End Sub
    Private Sub PictureBox1_MouseEnter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbrevistas.MouseEnter
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PictureBox1_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbrevistas.MouseLeave
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub PanelRevistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        seleccionado = "Revistas"

        Dim F5 As New Seleccion_Revistas
        panel_menu.Controls.Clear()
        F5.TopLevel = False
        F5.Parent = panel_menu
        F5.Show()

        Preparar_Form()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver
    End Sub
    Private Sub PanelRevistas_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel_Revistas.MouseEnter
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PanelRevistas_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel_Revistas.MouseLeave
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub Panel_Revistas_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Revistas.MouseClick
        revistasForm()
    End Sub
    Private Sub PbInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbInicio.Click
        inicioForm()
    End Sub
    Private Sub PbInicio_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbInicio.MouseEnter
        If seleccionado = "Inicio" Then
        Else
            Panel_Inicio.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PbInicio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbInicio.MouseLeave
        If seleccionado = "Inicio" Then
        Else
            Panel_Inicio.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub Panel_Inicio_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel_Inicio.MouseEnter
        If seleccionado = "Inicio" Then
        Else
            Panel_Inicio.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Dim contraseniaAdmin As String
    Private Sub Pbconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbconfig.Click
        If ERROR1 = 0 Then
            Dim open As Integer
            For Each f As Form In Application.OpenForms

                If f.Name = "ConfiguraciónAdmin" Then
                    open = 1
                Else
                    open = 0
                End If

            Next
            Dim cedula As Integer = 0
            If open = 0 Then
                Try

                    contraseniaAdmin = InputBox("Por favor ingrese la cedula de un administrador", Title:="Biblioteca")


                    Consulta = "select * from usuarios where tipo < 2"
                    consultar()
                    For Each row As DataRow In Tabla.Rows
                        If row("cedula") = contraseniaAdmin Then
                            cedula = 1
                            ConfigAdmin.ptbPerfilAdmin.ImageLocation = row("rutaperfil").ToString
                            ConfigAdmin.cedulaFotoPerfil = row("cedula").ToString
                            ConfigAdmin.Lbl_NombreADMIN_TXT.Text = row("nombre") & " " & row("apellido")
                            contraseniaAdmin = "1"
                        End If
                        If row("cedula") Is DBNull.Value And contraseniaAdmin <> vbNull Then
                            cedula = 0
                            MsgBox("Cedula Incorrecta")
                        End If
                    Next
                    If cedula = 1 Then
                        ConfigAdmin.Show()
                    ElseIf cedula = 0 Then
                        MsgBox("Cedula Incorrecta")
                    End If
                Catch ex As Exception
                    If (ex.Message.ToLowerInvariant().Contains("double")) Then
                        MsgBox("Cedula Incorrecta")
                    Else
                        MsgBox(ex.Message)
                    End If
                End Try
            End If
        End If
    End Sub 'Evento clik
    Private Sub Pbconfig_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbconfig.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub 'Evento Mouse enter
    Private Sub Pbconfig_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbconfig.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub 'Evento Mouse leave
    '/////////////////////////////////////// INFORMACION DEL USUARIO LOGEADO ////////////////////////////////////
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  'Evento clik
        info_usuario.Show()
        info_usuario.Text = Nombre.Text
    End Sub
    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)  'Evento Mouse enter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)  'Evento Mouse leave
        Me.Cursor = Cursors.Default
    End Sub
    '////////////////////////////////////////////////////////////TIMER HORA ///////////////////////////////////////////////////////
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = Date.Now.ToString("hh:mm:ss")
        substring = Date.Now.ToString("MM")
        mes()
        lblfecha.Text = fecha
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Preparar_Form()

        Select Case seleccionado

            Case "Inicio"
                Panel_Graficos.Visible = True
                panel_menu.Visible = False
                txtbuscar.Visible = False
                btnatras.Visible = False
                btnadelante.Visible = False
                btnpaginainicio.Visible = False
                btnrecargar.Visible = False
                Pnavegador.Visible = False
                Wbnavegador.Visible = False

            Case "navegador"
                Pnavegador.Visible = True
                panel_navegador.Visible = True
                panel_menu.Visible = False
                Panel_Graficos.Visible = False
                txtbuscar.Visible = True
                btnatras.Visible = True
                btnadelante.Visible = True
                btnpaginainicio.Visible = True
                btnrecargar.Visible = True
                Wbnavegador.Visible = True
                Wbnavegador.Navigate("www.ecosia.org")
        End Select

        If seleccionado <> "navegador" And seleccionado <> "Inicio" Then
            Panel_Graficos.Visible = False
            panel_menu.Visible = True
            txtbuscar.Visible = False
            btnatras.Visible = False
            btnadelante.Visible = False
            btnpaginainicio.Visible = False
            btnrecargar.Visible = False
            Pnavegador.Visible = False
            Wbnavegador.Visible = False
        End If
    End Sub

    Public Sub Chart()
        If ERROR1 = 2 Then

            ChartPrestamosDia.Series.Clear()
            ChartPrestamosDia.ChartAreas.Clear()

            Chart_Prestamos.Series.Clear()
            Chart_Prestamos.ChartAreas.Clear()

            ChartTOP.Series.Clear()
            ChartTOP.ChartAreas.Clear()

            If ComboBox1.Enabled = True And ComboBox2.Enabled = True Then
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
            End If


        Else
            If ComboBox1.Enabled = False And ComboBox2.Enabled = False Then
                ComboBox1.Enabled = True
                ComboBox2.Enabled = True
            End If

            Chart_Prestamos.Series.Clear()
            Chart_Prestamos.ChartAreas.Clear()

            If ComboBox2.SelectedItem = Nothing Then
                substring = Date.Now.ToString("yyyy")
            Else
                substring = ComboBox2.SelectedItem
            End If

            Chart_Prestamos.ChartAreas.Add("Prestamos")
            Chart_Prestamos.Series.Add("Prestamos Por Mes")

            Consulta = "select count(prestamolibro.cod_libro) , month(prestamolibro.fecha_salida) from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where fecha_salida IS NOT NULL and  year(fecha_salida) = '" & substring & "'group by month(fecha_salida)"
            consultar()
            Dim xas As Integer = 0
            For Each row As DataRow In Tabla.Rows
                substring = row("month(prestamolibro.fecha_salida)")
                If substring.Length = 1 Then
                    substring = "0" & row("month(prestamolibro.fecha_salida)")
                End If
                mes()
                Chart_Prestamos.Series("Prestamos Por Mes").Points.AddXY(substring, row("count(prestamolibro.cod_libro)"))
                Chart_Prestamos.Series("Prestamos Por Mes").Label = "Libros : " + "#VALY"
            Next


            Chart_Prestamos.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            Chart_Prestamos.Series("Prestamos Por Mes").Color = Color.FromArgb(150, 1, 233, 1)
            Chart_Prestamos.Series("Prestamos Por Mes").IsVisibleInLegend = False


            Try

                ChartPrestamosDia.Series.Clear()
                ChartPrestamosDia.ChartAreas.Clear()

                ChartPrestamosDia.ChartAreas.Add("Prestamos Del Dia")
                ChartPrestamosDia.Series.Add("Prestamos Del Dia")

                Consulta = "select cod_grafica from MenuConfig where cod_usuario = '" & lbl_cedula.Text & "'"
                consultar()

                For Each row As DataRow In Tabla.Rows
                    Select Case row("cod_grafica")
                        Case 1

                            ChartPrestamosDia.ChartAreas("Prestamos Del Dia").Area3DStyle.Enable3D = False
                            ChartPrestamosDia.Series("Prestamos Del Dia").ChartType = DataVisualization.Charting.SeriesChartType.Column

                        Case 2

                            ChartPrestamosDia.ChartAreas("Prestamos Del Dia").Area3DStyle.Enable3D = True
                            ChartPrestamosDia.Series("Prestamos Del Dia").ChartType = DataVisualization.Charting.SeriesChartType.Column
                            ChartPrestamosDia.ChartAreas("Prestamos Del Dia").Area3DStyle.Rotation = 0

                        Case 3

                            ChartPrestamosDia.ChartAreas("Prestamos Del Dia").Area3DStyle.Enable3D = False
                            ChartPrestamosDia.Series("Prestamos Del Dia").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                        Case 4

                            ChartPrestamosDia.ChartAreas("Prestamos Del Dia").Area3DStyle.Enable3D = True
                            ChartPrestamosDia.ChartAreas("Prestamos Del Dia").Area3DStyle.Rotation = 0
                            ChartPrestamosDia.Series("Prestamos Del Dia").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                    End Select
                Next

                substring = ComboBox1.SelectedItem
                mestonum()
                Consulta = "select count(prestamolibro.cod_libro) , day(prestamolibro.fecha_salida) from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where month(prestamolibro.fecha_salida) = '" & substring & "' group by day(fecha_salida)"
                consultar()

                ContadorDia = 0
                For Each row As DataRow In Tabla.Rows

                    ChartPrestamosDia.Series("Prestamos Del Dia").Points.AddXY(row("day(prestamolibro.fecha_salida)"), row("count(prestamolibro.cod_libro)"))
                    ChartPrestamosDia.Series("Prestamos Del Dia").Points(ContadorDia).AxisLabel = "Dia : " + "#VALX"
                    'ChartPrestamosDia.Series("Prestamos Del Dia").Points(ContadorDia).MarkerStyle = DataVisualization.Charting.MarkerStyle.Triangle
                    'ChartPrestamosDia.Series("Prestamos Del Dia").Points(ContadorDia).MarkerSize = 10

                    ContadorDia = ContadorDia + 1

                Next

                ChartPrestamosDia.Series("Prestamos Del Dia").Label = "Libros : " + "#VALY"
                ChartPrestamosDia.Series("Prestamos Del Dia").IsVisibleInLegend = False
                ChartPrestamosDia.ChartAreas("Prestamos Del Dia").BorderWidth = 0

                ChartPrestamosDia.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                PrimerInicio = 0

                ChartTOP.Series.Clear()
                ChartTOP.ChartAreas.Clear()

                ChartTOP.Series.Add("TOP")
                ChartTOP.ChartAreas.Add("TOP")

                Consulta = "select count(prestamolibro.cod_libro) , libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro group by prestamolibro.cod_libro ORDER BY count(prestamolibro.cod_libro) DESC limit 5"
                consultar()

                Dim X As Integer = 0
                For Each row As DataRow In Tabla.Rows

                    ChartTOP.Series("TOP").Points.AddXY(row("titulo"), row("count(prestamolibro.cod_libro)"))
                    'ChartTOP.Series("TOP").Points(X).AxisLabel = row("count(prestamolibro.cod_libro)")
                    ChartTOP.Series("TOP").Points(X).AxisLabel = " "
                    ChartTOP.Series("TOP").Points(X).LegendText = row("count(prestamolibro.cod_libro)") & ": " & row("titulo")
                    'ChartTOP.Series("TOP").Points(X).Font = New System.Drawing.Font("Arial Black", 10, FontStyle.Bold)

                    X = X + 1

                Next
                ChartTOP.Legends(0).Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
                ChartTOP.Series("TOP").Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent
                ChartTOP.ChartAreas("TOP").Area3DStyle.Enable3D = True
                ChartTOP.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Timer_Prestamos_LIVE_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Prestamos_LIVE.Tick
        If ERROR1 = 2 Then ' SI HAY UN ERROR EN LA BASE NO VA A HACER NADA HASTA QUE SE RETOME LA CONEXIÒN
            Timer_Prestamos_LIVE.Enabled = False
        ElseIf ERROR1 = 0 Then

            If seleccionado = "Inicio" Then
                inicio()
                Chart()
                Timer_BD.Interval = 6000
                Try
                    DataGridViewLibros.Refresh()
                    Consulta = "select prestamolibro.cod_libro as ID, libro.titulo , usuarios.nombre from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro inner join usuarios on usuarios.cedula = prestamolibro.cedula where fecha_entrada is null"
                    consultar()
                    DataGridViewLibros.DataSource = Tabla
                    DataGridViewLibros.Columns(0).HeaderText = "Nº de inventario"
                Catch ex As Exception
                    MsgBox("Error Libros Prestados Timer" & ex.ToString)
                End Try
            Else
            End If
        End If
    End Sub
    Dim x1 As Integer = 1
    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        If x1 = 0 And ERROR1 = 0 Then
            PanelPrestamosLIVE.Left = 1010
            PanelGraph1.Width = 969
            ChartPrestamosDia.Width = 963
            ChartTOP.Width = 462
            PanelPrestamosTOP.Width = 469
            PictureBox1.Left = 970
            Panel1.Width = 499
            Chart_Prestamos.Width = 492
            PanelPrestamosTOP.Left = 525
            x1 = 1
        ElseIf ERROR1 = 0 Then
            PanelPrestamosLIVE.Left = 766
            PictureBox1.Left = 742
            PanelGraph1.Width = 735
            ChartPrestamosDia.Width = 730
            ChartTOP.Width = 326
            PanelPrestamosTOP.Width = 333
            PanelPrestamosTOP.Left = 428
            Panel1.Width = 398
            Chart_Prestamos.Width = 392

            x1 = 0
        End If
    End Sub
    Private Sub Pbadvertenciaprestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbadvertenciaprestamos.Click

        If Panel_prestamosdia.Visible = False Then
            LbPrestamos.Items.Clear()
            Consulta = "select titulo from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where fecha_estimada='" + DateTime.Now.ToString("yyyy/MM/dd") + "' and fecha_entrada IS NULL"
            consultar()
            LbPrestamos.Items.Clear()
            If Tabla.Rows.Count = 0 Then
                Panel_prestamosdia.Visible = False
            Else
                Panel_prestamosdia.Visible = True
                For Each row As DataRow In Tabla.Rows
                    If Not IsDBNull(row("titulo")) Then
                        LbPrestamos.Items.Add(row("titulo"))
                    End If
                Next
            End If
        Else
            Panel_prestamosdia.Visible = False
        End If

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LbPrestamos.Items.Clear()
        Panel_prestamosdia.Visible = False
    End Sub

    Private Sub Pbnube_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbnube.MouseHover

        Select Case BD_ONLINE
            Case 1
                ToolTip1.Show("Base de Datos ONLINE", Pbnube)
            Case 0
                ToolTip1.Show("Base de Datos LOCAL", Pbnube)
        End Select

    End Sub
    Private Sub verificarBD()

        Consulta = "select * from usuarios"
        consultar()
        If Tabla.Rows.Count = 0 Then
            Pbnube.Image = Image.FromFile("imagenes\cloud-error.png")
            ConfigAdmin.Label_BDestadoTXT.Text = lblhora.Text
            ConfigAdmin.Label_BaseDatosTXT.Text = "LOCAL"
            BD_ONLINE = 0
        Else
            Pbnube.Image = Image.FromFile("imagenes\cloud.png")
            ConfigAdmin.Label_BDestadoTXT.Text = lblhora.Text
            ConfigAdmin.Label_BaseDatosTXT.Text = "ONLINE"
            BD_ONLINE = 1
            If ERROR1 = 2 Then
                Timer_BD.Interval = 10
            End If
        End If
    End Sub
    Private Sub Timer_BD_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_BD.Tick
        If primeriniciotimer = 0 Then
            Timer_BD.Interval = 6000
        End If
        primeriniciotimer = 0
        verificarBD()

        Select Case ERROR1
            Case 2
                If pictureboxPrestamosSwitch = 1 Then
                    Timer_Prestamos_LIVE.Enabled = False
                Else
                    Timer_Prestamos_LIVE.Enabled = False
                End If
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Timer_RuedaDeCarga.Enabled = True
                If pictureboxPrestamosSwitch = 1 Then
                    Chart()
                End If
            Case 0

                If seleccionado = "Inicio" Then
                    If pictureboxPrestamosSwitch = 1 Then
                        Timer_Prestamos_LIVE.Enabled = True
                    Else
                        Timer_Prestamos_LIVE.Enabled = False
                    End If
                    ComboBox1.Enabled = True
                    ComboBox2.Enabled = True
                Else
                    Timer_BD.Interval = 6000
                End If

        End Select
    End Sub
    Dim notasopen As Integer
    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If ERROR1 = 2 Then
        ElseIf ERROR1 = 0 Then
            For Each notas As Form In Application.OpenForms
                If notas.Name = "Notas" Then
                    notasopen = 1
                Else
                    notasopen = 0
                End If
            Next
            If notasopen = 0 Then
                NotasUsuario.Show()
            End If
        End If
    End Sub
    Private Sub Panel_Inicio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel_Inicio.MouseLeave
        If seleccionado = "Inicio" Then
        Else
            Panel_Inicio.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Dim contadorAnimacionBD As Integer = 1
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_RuedaDeCarga.Tick
        If contadorAnimacionBD < 5 Then
            Rueda_de_carga1.Start()
            Rueda_de_carga1.Visible = True
        Else
            Rueda_de_carga1.Visible = False
            Rueda_de_carga1.Stop()
            contadorAnimacionBD = 0
            Timer_RuedaDeCarga.Enabled = False
        End If
        contadorAnimacionBD = contadorAnimacionBD + 1
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chart()
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chart()
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chart()
    End Sub
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chart()
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chart()
    End Sub
    Private Sub Pbusuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.Click
        If ERROR1 = 0 And lbl_cedula.Text <> "................" Then
            Consulta = "select cedula , nombre , mail , tipo from usuarios where cedula = '" & lbl_cedula.Text & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                If row("cedula") IsNot DBNull.Value Then
                    info_usuario.LabelCedula.Text = row("cedula")
                    If row("mail") Is DBNull.Value Then
                    Else
                        info_usuario.LabelMail.Text = row("mail")
                    End If
                    info_usuario.LabelNombre.Text = row("nombre")
                    Select Case row("tipo")
                        Case 0
                            info_usuario.LabelTipo.Text = "Administrador"
                        Case 1
                            info_usuario.LabelTipo.Text = "Funcionario"
                    End Select
                End If
            Next
            info_usuario.Show()
        End If
    End Sub

    Private Sub label_usuarios_MouseEnter(sender As System.Object, e As System.EventArgs) Handles label_usuarios.MouseEnter
        If seleccionado = "usuarios" Then 'si esta seleccionado el sector usuarios
        Else
            panel_usuarios.BackColor = Drawing.Color.LightGray 'si no esta seleccionado el sector usuarios
        End If
    End Sub

    Private Sub label_usuarios_MouseLeave(sender As System.Object, e As System.EventArgs) Handles label_usuarios.MouseLeave
        If seleccionado = "usuarios" Then 'si esta seleccionado el sector usuarios
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver 'si no esta seleccionado el sector usuarios
        End If
    End Sub

    Private Sub label_libros_MouseEnter(sender As System.Object, e As System.EventArgs) Handles label_libros.MouseEnter
        If seleccionado = "libros" Then 'selecciona libros
        Else
            panel_libros.BackColor = Drawing.Color.LightGray 'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub

    Private Sub label_libros_MouseLeave(sender As System.Object, e As System.EventArgs) Handles label_libros.MouseLeave
        If seleccionado = "libros" Then 'selecciona libros
        Else
            panel_libros.BackColor = Drawing.Color.LightGray 'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub

    Private Sub label_prestamos_MouseEnter(sender As System.Object, e As System.EventArgs) Handles label_prestamos.MouseEnter
        If seleccionado = "prestamos" Then 'si esta seleccionado prestamos
        Else
            panel_prestamos.BackColor = Drawing.Color.LightGray 'si no esta seleccionado prestamos , el backcolor lo define en lightgray
        End If
    End Sub

    Private Sub label_prestamos_MouseLeave(sender As System.Object, e As System.EventArgs) Handles label_prestamos.MouseLeave
        If seleccionado = "prestamos" Then 'si esta seleccionado prestamos
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver 'si no esta seleccionado prestamos , el backcolor lo define en lightgray
        End If
    End Sub

    Private Sub label_navegador_MouseEnter(sender As System.Object, e As System.EventArgs) Handles label_navegador.MouseEnter
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.LightGray
        End If
    End Sub

    Private Sub label_navegador_MouseLeave(sender As System.Object, e As System.EventArgs) Handles label_navegador.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If
    End Sub

    Private Sub LabelRevistas_MouseEnter(sender As System.Object, e As System.EventArgs) Handles LabelRevistas.MouseEnter
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.LightGray
        End If
    End Sub

    Private Sub LabelRevistas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles LabelRevistas.MouseLeave
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.Silver
        End If
    End Sub

    Private Sub LabelInicio_Click(sender As System.Object, e As System.EventArgs) Handles LabelInicio.Click
        inicioForm()
    End Sub

    Private Sub librosForm()
        seleccionado = "libros" 'seleciona libros
        Timer_Prestamos_LIVE.Enabled = False 'desactiva el timer prestamos

        panel_menu.Controls.Clear() 'limpia el panel_menu
        F3.TopLevel = False 'declara en false el nivel de la variable F3
        F3.Parent = panel_menu 'declara como padre al panel_menu
        F3.Dock = DockStyle.Fill 'completa el panel con la varibale F3
        F3.Show() 'muestra la varible de tipo formulario llamada F3
        'declara todos los backcolor de los paneles de seleccion en silver , menos el seleccionado
        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.LightGray
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver
        Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver
        Preparar_Form() 'prepara el formualario para cargar la variable F3
    End Sub

    Private Sub usuariosForm()
        If ERROR1 = 0 Then
            seleccionado = "usuarios" 'fija seleccion como usuarios

            Timer_Prestamos_LIVE.Enabled = False 'desactiva el timer_Prestamos

            'fija todos los backcolors de los paneles de seleccion como silver , menos el que esta seleccionado
            panel_usuarios.BackColor = Drawing.Color.LightGray
            panel_libros.BackColor = Drawing.Color.Silver
            panel_prestamos.BackColor = Drawing.Color.Silver
            panel_navegador.BackColor = Drawing.Color.Silver
            Panel_Revistas.BackColor = Drawing.Color.Silver
            Panel_Inicio.BackColor = Drawing.Color.Silver
            Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver
            Dim F1 As New Inicio_UsuariosV2 'declara la varibale F1 como tipo formulario en este caso como inicio_usuariosV2
            panel_menu.Controls.Clear() 'limpia el panel donde va a estar alojado el formulario
            F1.TopLevel = False 'pone en tipo false el nivel de la variable
            F1.Parent = panel_menu 'declara como padre al formulario que aloja a la variable F1
            F1.Show() 'mustra la varible F1

            Preparar_Form() 'prepara los formulario para cargar la variable
        End If
    End Sub

    Private Sub inicioForm()
        seleccionado = "Inicio"
        If pictureboxPrestamosSwitch = 1 Then
            Chart()
            Timer_Prestamos_LIVE.Enabled = True
        Else
            Timer_Prestamos_LIVE.Enabled = False
        End If


        Preparar_Form()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.LightGray
        Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub prestamosLibrosForm()
        seleccionado = "prestamos"
        Timer_Prestamos_LIVE.Enabled = False

        Dim F4 As New Prestamos
        panel_menu.Controls.Clear()
        F4.TopLevel = False
        F4.Parent = panel_menu
        F4.Show()

        Preparar_Form()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver
        Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub prestamosRevistasForm()
        seleccionado = "PrestamosRevistas"

        Dim F6 As New PrestamoRevistas
        panel_menu.Controls.Clear()
        F6.TopLevel = False
        F6.Parent = panel_menu

        F6.Show()

        panel_menu.Visible = True
        txtbuscar.Visible = False
        btnatras.Visible = False
        btnadelante.Visible = False
        btnpaginainicio.Visible = False
        btnrecargar.Visible = False
        Pnavegador.Visible = False
        Wbnavegador.Visible = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver
        Panel_PrestamosRevistas.BackColor = Drawing.Color.LightGray

        Panel_Graficos.Visible = False
    End Sub

    Private Sub revistasForm()
        seleccionado = "Revistas"

        Dim F5 As New Seleccion_Revistas
        panel_menu.Controls.Clear()
        F5.TopLevel = False
        F5.Parent = panel_menu

        F5.Show()

        panel_menu.Visible = True
        txtbuscar.Visible = False
        btnatras.Visible = False
        btnadelante.Visible = False
        btnpaginainicio.Visible = False
        btnrecargar.Visible = False
        Pnavegador.Visible = False
        Wbnavegador.Visible = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.LightGray
        Panel_Inicio.BackColor = Drawing.Color.Silver
        Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver

        Panel_Graficos.Visible = False
    End Sub

    Private Sub label_usuarios_Click(sender As System.Object, e As System.EventArgs) Handles label_usuarios.Click
        usuariosForm()
    End Sub

    Private Sub label_libros_Click(sender As System.Object, e As System.EventArgs) Handles label_libros.Click
        librosForm()
    End Sub

    Private Sub label_prestamos_Click(sender As System.Object, e As System.EventArgs) Handles label_prestamos.Click
        prestamosLibrosForm()
    End Sub

    Private Sub PictureBox4_Click_1(sender As System.Object, e As System.EventArgs)
        prestamosRevistasForm()
    End Sub

    Private Sub Label_Prestamos_Revistas_Click(sender As System.Object, e As System.EventArgs) Handles Label_Prestamos_Revistas.Click
        prestamosRevistasForm()
    End Sub

    Private Sub LabelRevistas_Click(sender As System.Object, e As System.EventArgs) Handles LabelRevistas.Click
        revistasForm()
    End Sub

    Private Sub Panel2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel_PrestamosRevistas.MouseClick
        prestamosRevistasForm()
    End Sub

    Private Sub PictureBox_Prestamos_Revistas(sender As System.Object, e As System.EventArgs) Handles pb_PrestamosRevistas.Click
        prestamosRevistasForm()
    End Sub
    Private Sub navegadorForm()
        If ERROR1 = 0 Then
            seleccionado = "navegador"
            Timer_Prestamos_LIVE.Enabled = False

            panel_usuarios.BackColor = Drawing.Color.Silver
            panel_libros.BackColor = Drawing.Color.Silver
            panel_prestamos.BackColor = Drawing.Color.Silver
            panel_navegador.BackColor = Drawing.Color.LightGray
            Panel_Revistas.BackColor = Drawing.Color.Silver
            Panel_Inicio.BackColor = Drawing.Color.Silver
            Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver

            Preparar_Form()
        End If
    End Sub

    Private Sub label_navegador_Click(sender As System.Object, e As System.EventArgs)
        navegadorForm()
    End Sub

    Private Sub label_navegador_Click_1(sender As System.Object, e As System.EventArgs) Handles label_navegador.Click
        navegadorForm()
    End Sub

    Private Sub Panel_PrestamosRevistas_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Panel_PrestamosRevistas.MouseEnter
        If seleccionado = "PrestamosRevistas" Then 'selecciona libros
        Else
            Panel_PrestamosRevistas.BackColor = Drawing.Color.LightGray  'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub

    Private Sub Panel_PrestamosRevistas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Panel_PrestamosRevistas.MouseLeave
        If seleccionado = "PrestamosRevistas" Then 'selecciona libros
        Else
            Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver 'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub
    Private Sub label_Prestamos_Revistas_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label_Prestamos_Revistas.MouseEnter
        If seleccionado = "PrestamosRevistas" Then 'selecciona libros
        Else
            Panel_PrestamosRevistas.BackColor = Drawing.Color.LightGray  'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub

    Private Sub label_Prestamos_Revistas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label_Prestamos_Revistas.MouseLeave
        If seleccionado = "PrestamosRevistas" Then 'selecciona libros
        Else
            Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver 'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub
    Private Sub PictureBox4_MouseEnter_1(sender As System.Object, e As System.EventArgs) Handles pb_PrestamosRevistas.MouseEnter
        If seleccionado = "PrestamosRevistas" Then 'selecciona libros
        Else
            Panel_PrestamosRevistas.BackColor = Drawing.Color.LightGray  'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub

    Private Sub PictureBox4_MouseLeave_1(sender As System.Object, e As System.EventArgs) Handles pb_PrestamosRevistas.MouseLeave
        If seleccionado = "PrestamosRevistas" Then 'selecciona libros
        Else
            Panel_PrestamosRevistas.BackColor = Drawing.Color.Silver 'si no esta seleccionado pone el backcolor en lightgray
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        'Cierra el programa'
        Consulta = "update usuarios set ultimaconexion = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "', online = 0 where cedula = '" & lbl_cedula.Text & "'"
        consultar()
        End

        'Try
        '    For Each f As Form In Application.OpenForms
        '        If f.Name <> "MENU3" Then
        '            f.Close()
        '        End If
        '        Me.Close()
        '    Next
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ComboBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles ComboBox1.MouseEnter
        Timer_Prestamos_LIVE.Enabled = False
        Timer_BD.Enabled = False
    End Sub
    Private Sub ComboBox1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles ComboBox1.MouseLeave
        Timer_Prestamos_LIVE.Enabled = True
        Timer_BD.Enabled = True
    End Sub

    Private Sub PictureBox4_Click_2(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        ConfigAdmin.Dispose()
        info_usuario.Dispose()
        NotasUsuario.Dispose()
        LOGIN.usuario.Clear()
        LOGIN.contrasenia.Clear()

        If lbl_cedula.Text <> "................" Then
            Consulta = "update usuarios set ultimaconexion = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "', online = 0 where cedula = '" & lbl_cedula.Text & "'"
            consultar()
        End If
        Me.Dispose()
        LOGIN.Show()


    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If lbl_cedula.Text <> "................" Then
            Consulta = "update usuarios set ultimaconexion = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' , online = 0 where cedula = '" & lbl_cedula.Text & "'"
            consultar()
            End
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        If pictureboxPrestamosSwitch = 1 Then
            PictureBox5.Image = Image.FromFile("imagenes/switch_off.png")
            Timer_Prestamos_LIVE.Enabled = False
            If lbl_cedula.Text <> "................" Then
                Consulta = "select cod_prestamosLive from MenuConfig where cod_usuario = '" & lbl_cedula.Text & "'"
                consultar()
                For Each row As DataRow In Tabla.Rows
                    If row("cod_prestamosLive") = "0" Then
                    Else
                        Consulta = "update MenuConfig set cod_prestamosLive = 0 where cod_usuario = '" & lbl_cedula.Text & "'"
                        consultar()
                    End If
                Next
            End If
            pictureboxPrestamosSwitch = 0
        ElseIf pictureboxPrestamosSwitch = 0 Then

            PictureBox5.Image = Image.FromFile("imagenes/switch_on.png")
            Timer_Prestamos_LIVE.Enabled = True
            If lbl_cedula.Text <> "................" Then
                Consulta = "select cod_prestamosLive from MenuConfig where cod_usuario = '" & lbl_cedula.Text & "'"
                consultar()
                For Each row As DataRow In Tabla.Rows
                    If row("cod_prestamosLive") = "1" Then
                    Else
                        Consulta = "update MenuConfig set cod_prestamosLive = 1 where cod_usuario = '" & lbl_cedula.Text & "'"
                        consultar()
                    End If
                Next
            End If
            pictureboxPrestamosSwitch = 1
        End If
    End Sub
    Dim mouseentercomboaño As Integer = 0
    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If mouseentercomboaño = 1 Then
            Chart()
        End If
    End Sub

    Private Sub ComboBox2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles ComboBox2.MouseEnter
        mouseentercomboaño = 1
    End Sub

    Private Sub ComboBox2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles ComboBox2.MouseLeave
        mouseentercomboaño = 0
    End Sub
End Class