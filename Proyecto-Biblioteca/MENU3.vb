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

    Public cedulaIngre As String ' Variable para actualizar foto de perfil, se carga en el load
    Public cedulaAdmin As String ' Variable para cargar foto de perfil en admin, se carga al abrir config admin
    Private Sub inicio()
        If ERROR1 = 0 Then
            Try
                Chart()
                Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
                Consulta = "select titulo from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where fecha_estimada='" + fecha + "'"
                consultar()
                For Each row As DataRow In Tabla.Rows
                    If Not IsDBNull(row("titulo")) Then
                        Pbadvertenciaprestamos.Visible = True
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub MENU3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        xf = Me.Location.X
        yf = Me.Location.Y

        Rueda_de_carga1.Visible = False
        verificarBD()

        Consulta = "select prestamolibro.cod_libro as Libros, libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where fecha_entrada is null"
        consultar()
        DataGridViewLibros.DataSource = Tabla
        DatagridModulo = DataGridViewLibros
        Datagrid_Align()

        cedulaIngre = lbl_cedula.Text ' Variable para actualizar foto de perfil

        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" + cedulaIngre + "'"
            consultar()

            For Each row As DataRow In Tabla.Rows
                Pbusuario.ImageLocation = Convert.ToString(row("rutaperfil"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If ERROR1 = 0 Then
            Chart()
            inicio()
            Timer_Prestamos_LIVE.Enabled = True
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
                ComboBox2.Items.Add("A�o")
            Else
                ComboBox2.Items.Add(i)
            End If
            ComboBox2.SelectedItem = i
        Next

        '///////////////////VENTANA DE LIBROS QUE SE DEVUELVEN EN EL DIA///////////////////////
        Pbadvertenciaprestamos.Visible = False
        Panel_prestamosdia.Visible = False

        label_usuarios.Left = 72
        label_libros.Left = 72
        LabelInicio.Left = 72
        LabelRevistas.Left = 72
        label_prestamos.Left = 72
        label_navegador.Left = 72

        Preparar_Form()

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
        If a = 1 Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
            Me.Opacity = 0.9
            Timer_Prestamos_LIVE.Enabled = False
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
            Timer_Prestamos_LIVE.Enabled = True
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Phoraencabezado.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub
    Private Sub panel_usuarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseEnter
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub panel_usuarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseLeave
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub panel_usuarios_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_usuarios.MouseClick
        seleccionado = "usuarios"

        Dim F1 As New Inicio_UsuariosV2
        panel_menu.Controls.Clear()
        F1.TopLevel = False
        F1.Parent = panel_menu
        F1.Show()

        Preparar_Form()

        panel_usuarios.BackColor = Drawing.Color.LightGray
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

    End Sub
    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseEnter
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseLeave
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuarios.Click
        seleccionado = "usuarios"

        Timer_Prestamos_LIVE.Enabled = False

        panel_usuarios.BackColor = Drawing.Color.LightGray
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

        Dim F1 As New Inicio_UsuariosV2
        panel_menu.Controls.Clear()
        F1.TopLevel = False
        F1.Parent = panel_menu
        F1.Show()

        Preparar_Form()
    End Sub
    Private Sub panel_libros_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseEnter
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub panel_libros_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseLeave
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Private Sub panel_libros_Mouseclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_libros.MouseClick
        Dim F3 As New Seleccion_Libro
        seleccionado = "libros"
        Timer_Prestamos_LIVE.Enabled = False

        panel_menu.Controls.Clear()
        F3.TopLevel = False
        F3.Parent = panel_menu
        F3.Dock = DockStyle.Fill
        F3.Show()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.LightGray
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

        Preparar_Form()
    End Sub
    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseEnter
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseLeave
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.Silver
        End If
    End Sub
    Public Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pblibros.Click
        Dim F3 As Seleccion_Libro
        seleccionado = "libros"
        Timer_Prestamos_LIVE.Enabled = False

        panel_menu.Controls.Clear()
        F3.TopLevel = False
        F3.Parent = panel_menu
        F3.Dock = DockStyle.Fill
        F3.Show()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.LightGray
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

        Preparar_Form()
    End Sub
    Private Sub panel_prestamos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseEnter
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.LightGray
        End If
    End Sub
    Private Sub panel_prestamos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_prestamos.MouseClick
        seleccionado = "prestamos"

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
        seleccionado = "navegador"
        Timer_Prestamos_LIVE.Enabled = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.LightGray
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

        Preparar_Form()
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
            MsgBox("Lo siento. Si has llegado hasta este mensaje ocurri� un error, pero tranquilo que no pasa nada", "Genesis Navigator")
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
        seleccionado = "navegador"
        Timer_Prestamos_LIVE.Enabled = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.LightGray
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

        Preparar_Form()
    End Sub
    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbrevistas.Click
        seleccionado = "Revistas"
        Timer_Prestamos_LIVE.Enabled = False

        Dim F5 As New Seleccion_Revistas
        panel_menu.Controls.Clear()
        F5.TopLevel = False
        F5.Parent = panel_menu
        F5.Show()

        Preparar_Form()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.LightGray
        Panel_Inicio.BackColor = Drawing.Color.Silver
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


        Panel_Graficos.Visible = False
    End Sub
    Private Sub PbInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbInicio.Click
        seleccionado = "Inicio"
        Chart()
        Timer_Prestamos_LIVE.Enabled = True

        Preparar_Form()

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.LightGray
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
    Private Sub Pbconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbconfig.Click
        Dim open As Integer
        For Each f As Form In Application.OpenForms

            If f.Name = "Configuraci�nAdmin" Then
                open = 1
            Else
                open = 0
            End If

        Next
        Dim cedula As Integer = 0
        If open = 0 Then
            Try
                Dim contraseniaAdmin As String
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
                    If row("cedula") Is DBNull.Value Then
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
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False

        Else

            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Chart_Prestamos.Series.Clear()
            Chart_Prestamos.ChartAreas.Clear()
            If ComboBox2.SelectedItem = Nothing Then
                substring = Date.Now.ToString("yyyy")
            Else
                substring = ComboBox2.SelectedItem
            End If
            '/////////////////////////////// CHART DE PRESTAMOS Y USUARIOS //////////////////////////////////
            Consulta = "select count(prestamolibro.cod_libro) , month(prestamolibro.fecha_salida) from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where fecha_salida IS NOT NULL and  year(fecha_salida) = '" & substring & "'group by month(fecha_salida)"
            consultar()
            Chart_Prestamos.ChartAreas.Add("Prestamos")
            Chart_Prestamos.Series.Add("Prestamos")
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            For Each row As DataRow In Tabla.Rows
                substring = row("month(prestamolibro.fecha_salida)")
                If substring.Length = 1 Then
                    substring = "0" & row("month(prestamolibro.fecha_salida)")
                End If
                mes()
                Chart_Prestamos.Series("Prestamos").Points.AddXY(substring, row("count(prestamolibro.cod_libro)"))
            Next
            '////////////////////////////////////////////////////////////////////////////////////////////////

            Chart_Prestamos.Series("Prestamos").Label = "Libros : " + "#VALY"
            Chart_Prestamos.ChartAreas(0).AxisX.MajorGrid.Enabled = False

            '//////////////////////////////////////////////////////////////////////////////////////////////////

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
                    ContadorDia = ContadorDia + 1
                Next

                ChartPrestamosDia.Series("Prestamos Del Dia").Label = "Libros : " + "#VALY"

                ChartPrestamosDia.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                PrimerInicio = 0

                ChartTOP.Series.Clear()
                ChartTOP.ChartAreas.Clear()

                ChartTOP.Series.Add("TOP")
                ChartTOP.ChartAreas.Add("TOP")

                Consulta = "select count(prestamolibro.cod_libro) , libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro group by prestamolibro.cod_libro ORDER BY count(prestamolibro.cod_libro) DESC limit 5"
                consultar()

                For Each row As DataRow In Tabla.Rows
                    ChartTOP.Series("TOP").Points.AddXY(row("titulo"), row("count(prestamolibro.cod_libro)"))
                Next

                ChartTOP.Series("TOP").Label = "#VALY"
                ChartTOP.ChartAreas(0).AxisX.MajorGrid.Enabled = False

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If
    End Sub
    Private Sub Timer_Prestamos_LIVE_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Prestamos_LIVE.Tick
        If ERROR1 = 2 Then ' SI HAY UN ERROR EN LA BASE NO VA A HACER NADA HASTA QUE SE RETOME LA CONEXI�N
            Timer_Prestamos_LIVE.Enabled = False
        ElseIf ERROR1 = 0 Then

            If seleccionado = "Inicio" Then
                inicio()
                Chart()
                Timer_BD.Interval = 6000
                Try
                    DataGridViewLibros.Refresh()
                    Consulta = "select prestamolibro.cod_libro as Libros, libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where fecha_entrada is null"
                    consultar()
                    DataGridViewLibros.DataSource = Tabla
                Catch ex As Exception
                    MsgBox("Error Libros Prestados Timer" & ex.ToString)
                End Try
            Else
            End If
        End If
    End Sub
    Dim x1 As Integer = 1
    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        If x1 = 0 Then
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
        Else
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
            Panel_prestamosdia.Visible = True
            Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
            Consulta = "select titulo from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where fecha_estimada='" + fecha + "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                If Not IsDBNull(row("titulo")) Then
                    LbPrestamos.Items.Add(row("titulo"))
                End If
            Next
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
        DataGridView1.DataSource = Tabla
        If DataGridView1.Rows.Count() = 0 Then
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

                Timer_Prestamos_LIVE.Enabled = False
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Timer_RuedaDeCarga.Enabled = True
                Chart()

            Case 0

                If seleccionado = "Inicio" Then
                    Timer_Prestamos_LIVE.Enabled = True
                Else
                    Timer_BD.Interval = 6000
                End If

        End Select
    End Sub
    Dim notasopen As Integer
    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
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
        Consulta = "select cedula , nombre , mail , tipo from usuarios where cedula = '" & lbl_cedula.Text & "'"
        consultar()
        For Each row As DataRow In Tabla.Rows
            If row("cedula") IsNot DBNull.Value Then
                info_usuario.LabelCedula.Text = row("cedula")
                info_usuario.LabelMail.Text = row("mail")
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
    End Sub

    Private Sub PictureBox3_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class