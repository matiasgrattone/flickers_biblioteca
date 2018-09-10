Imports System.Threading
Imports System.Text.RegularExpressions
Public Class MENU3
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer
    Dim seleccionado As String
    Dim mouse As Integer
    Dim mouse2 As Integer
    Dim mouse3 As Integer
    Dim mouse4 As Integer
    Dim mouse5 As Integer
    Public F3 As New Seleccion_Libro


    Private Sub MENU3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
        Wbnavegador.Visible = False
        Pnavegador.Visible = False

        '////////////////////VERIFICAR SI ESTA CONECTADO A LA BASE //////////////////////////////////

        Pbnube.Image = Image.FromFile("imagenes\cloud-error.png")

        Consulta = "select * from usuarios"
        consultar()
        DataGridView1.DataSource = Tabla

        If DataGridView1.Rows.Count() = 0 Then

            Pbnube.Image = Image.FromFile("imagenes\cloud-error.png")

        Else
            Pbnube.Image = Image.FromFile("imagenes\cloud.png")
        End If
        '////////////////////////////////////////////////////////////////////////////////////////////////

        '/////////////////////////////// CHART DE PRESTAMOS Y USUARIOS //////////////////////////////////
        Consulta = "select count(prestamolibro.cod_libro) , prestamolibro.fecha_salida from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro group by fecha_salida"
        consultar()

        Chart_Prestamos.Series.Add("Prestamos")
        Chart_Prestamos.Series.RemoveAt(0)
        For Each row As DataRow In Tabla.Rows
            If row("fecha_salida").ToString.Substring(6, 4) = "2018" Then
                Chart_Prestamos.Series("Prestamos").Points.AddXY(2018, row("count(prestamolibro.cod_libro)"))
            Else

            End If


        Next
        '////////////////////////////////////////////////////////////////////////////////////////////////


    End Sub

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
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y

        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Phoraencabezado.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = Date.Now.ToString("hh:mm:ss")
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
            MessageBox.Show("Lo siento. Si has llegado hasta este mensaje ocurrió un error, pero tranquilo que no pasa nada", "Genesis Navigator")
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaginainicio.Click
        Dim timer As Integer = 0
        Select Case timer

            Case 0
                timer = 1
                Timer2.Start()
            Case 1
                timer = 0
                Timer2.Stop()
        End Select


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuarios.Click
        seleccionado = "usuarios"
        mouse = 1
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        mouse5 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True
        panel_usuarios.BackColor = Drawing.Color.LightGray
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver

        Panel_Graficos.Visible = False

        Dim F1 As New Inicio_UsuariosV2
        panel_menu.Controls.Clear()
        F1.TopLevel = False
        F1.Parent = panel_menu
        F1.Show()

        panel_menu.Visible = True
        txtbuscar.Visible = False
        btnatras.Visible = False
        btnadelante.Visible = False
        btnpaginainicio.Visible = False
        btnrecargar.Visible = False
        Pnavegador.Visible = False
        Wbnavegador.Visible = False




    End Sub

    Public Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pblibros.Click
        seleccionado = "libros"
        mouse = 0
        mouse2 = 1
        mouse3 = 0
        mouse4 = 0
        mouse5 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True

        panel_menu.Controls.Clear()
        F3.TopLevel = False
        F3.Parent = panel_menu
        F3.Dock = DockStyle.Fill

        F3.Show()

        panel_menu.Visible = True
        txtbuscar.Visible = False
        btnatras.Visible = False
        btnadelante.Visible = False
        btnpaginainicio.Visible = False
        btnrecargar.Visible = False
        Pnavegador.Visible = False
        Wbnavegador.Visible = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.LightGray
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver

        Panel_Graficos.Visible = False
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbprestamos.Click
        seleccionado = "prestamos"
        mouse = 0
        mouse2 = 0
        mouse3 = 1
        mouse4 = 0
        mouse5 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True
        Dim F4 As New Prestamos
        panel_menu.Controls.Clear()
        F4.TopLevel = False
        F4.Parent = panel_menu

        F4.Show()

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
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver

        Panel_Graficos.Visible = False

    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////// NAVEGADOR /////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbnavegador.Click
        seleccionado = "navegador"
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 1
        mouse5 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True
        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.LightGray
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Try
            Pnavegador.Visible = True
            panel_menu.Visible = False
            txtbuscar.Visible = True
            btnatras.Visible = True
            btnadelante.Visible = True
            btnpaginainicio.Visible = True
            btnrecargar.Visible = True
            Wbnavegador.Visible = True
            Wbnavegador.Navigate("www.ecosia.org")

        Catch ex As Exception

        End Try

        Panel_Graficos.Visible = False


    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub panel_libros_Mouseclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_libros.MouseClick
        seleccionado = "libros"
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.LightGray
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

        Dim F3 As New Seleccion_Libro
        panel_menu.Controls.Clear()
        F3.TopLevel = False
        F3.Parent = panel_menu
        F3.Dock = DockStyle.Fill
        F3.Show()

        panel_menu.Visible = True
        txtbuscar.Visible = False
        btnatras.Visible = False
        btnadelante.Visible = False
        btnpaginainicio.Visible = False
        btnrecargar.Visible = False
        Pnavegador.Visible = False
        Wbnavegador.Visible = False

        Panel_Graficos.Visible = False

    End Sub

    Private Sub panel_prestamos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_prestamos.MouseClick
        seleccionado = "prestamos"
        Dim F4 As New Prestamos
        panel_menu.Controls.Clear()
        F4.TopLevel = False
        F4.Parent = panel_menu
        F4.Show()
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
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
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver

        Panel_Graficos.Visible = False

    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////// NAVEGADOR /////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub panel_navegador_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_navegador.MouseClick
        seleccionado = "navegador"


        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.LightGray
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True


        Pnavegador.Visible = True
        panel_menu.Visible = False
        txtbuscar.Visible = True
        btnatras.Visible = True
        btnadelante.Visible = True
        btnpaginainicio.Visible = True
        btnrecargar.Visible = True
        Wbnavegador.Visible = True
        Wbnavegador.Navigate("www.ecosia.org")


        Panel_Graficos.Visible = False


    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////// 

    Private Sub panel_usuarios_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_usuarios.MouseClick
        seleccionado = "usuarios"
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Dim F1 As New Inicio_UsuariosV2
        panel_menu.Controls.Clear()
        F1.TopLevel = False
        F1.Parent = panel_menu
        F1.Show()

        panel_menu.Visible = True
        txtbuscar.Visible = False
        btnatras.Visible = False
        btnadelante.Visible = False
        btnpaginainicio.Visible = False
        btnrecargar.Visible = False
        Pnavegador.Visible = False
        Wbnavegador.Visible = False



        panel_usuarios.BackColor = Drawing.Color.LightGray
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

        Panel_Graficos.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaginainicio.Click
        Wbnavegador.Navigate("www.ecosia.org")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecargar.Click
        Wbnavegador.Refresh()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Phoraencabezado.Paint

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        substring = Date.Now.ToString("MM")
        mes()
        lblfecha.Text = fecha


    End Sub
    Private Sub panel_usuarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseEnter
        panel_usuarios.BackColor = Drawing.Color.LightGray
    End Sub
    Private Sub panel_libros_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseEnter
        panel_libros.BackColor = Drawing.Color.LightGray

    End Sub
    Private Sub panel_prestamos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseEnter
        panel_prestamos.BackColor = Drawing.Color.LightGray

    End Sub
    Private Sub panel_navegador_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_navegador.MouseEnter
        panel_navegador.BackColor = Drawing.Color.LightGray
    End Sub

    Private Sub panel_usuarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseLeave
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver
        End If

    End Sub

    Private Sub panel_libros_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseLeave
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.Silver
        End If
        mouse = 0
        label_libros.Enabled = True
    End Sub

    Private Sub panel_prestamos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseLeave
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver
        End If

    End Sub

    Private Sub panel_navegador_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_navegador.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseEnter
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.LightGray
        End If
        mouse = 1
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        Timer_UsuariosLabel.Enabled = True

    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseLeave
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver
        End If
        mouse = 0
        Timer_UsuariosLabel.Enabled = True
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseEnter
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.LightGray
        End If
        mouse = 0
        mouse2 = 1
        mouse3 = 0
        mouse4 = 0
        Timer_LibrosLabel.Enabled = True
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseLeave
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.Silver
        End If
        mouse2 = 0
        Timer_LibrosLabel.Enabled = True
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbprestamos.MouseEnter
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.LightGray
        End If
        mouse = 0
        mouse2 = 0
        mouse3 = 1
        mouse4 = 0
        Timer_PrestamosLabel.Enabled = True
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbprestamos.MouseLeave
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver
        End If
        mouse3 = 0
        Timer_PrestamosLabel.Enabled = True
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbnavegador.MouseEnter
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.LightGray
        End If
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 1
        Timer_NvegadorLabel.Enabled = True
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbnavegador.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If
        mouse4 = 0
        Timer_NvegadorLabel.Enabled = True
    End Sub


    Private Sub Timer_UsuariosLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UsuariosLabel.Tick

        Select Case mouse
            Case 1
                If label_usuarios.Left < 75 Then
                    label_usuarios.Left += 10
                Else
                    '  Timer_UsuariosLabel.Enabled = False
                End If

            Case 0
                If label_usuarios.Left > 11 And seleccionado <> "usuarios" Then
                    label_usuarios.Left -= 10
                Else
                    Timer_UsuariosLabel.Enabled = False
                End If
        End Select



    End Sub

    Private Sub Timer_LibrosLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_LibrosLabel.Tick
        Select Case mouse2
            Case 1
                If label_libros.Left < 79 Then
                    label_libros.Left += 10
                Else
                    'Timer_LibrosLabel.Enabled = False
                End If
            Case 0
                If label_libros.Left > 20 And seleccionado <> "libros" Then
                    label_libros.Left -= 10
                Else
                    Timer_LibrosLabel.Enabled = False
                End If
        End Select
    End Sub

    Private Sub Timer_PrestamosLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_PrestamosLabel.Tick
        Select Case mouse3
            Case 1
                If label_prestamos.Left < 71 Then
                    label_prestamos.Left += 10
                Else
                    '  Timer_PrestamosLabel.Enabled = False
                End If
            Case 0
                If label_prestamos.Left > 7 And seleccionado <> "prestamos" Then
                    label_prestamos.Left -= 10
                Else
                    Timer_PrestamosLabel.Enabled = False
                End If
        End Select
    End Sub

    Private Sub Timer_NavgadorLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_NvegadorLabel.Tick
        Select Case mouse4
            Case 1
                If label_navegador.Left < 70 Then
                    label_navegador.Left += 10
                Else
                    ' Timer_NavgadorLabel.Enabled = False
                End If
            Case 0
                If label_navegador.Left > 12 And seleccionado <> "navegador" Then
                    label_navegador.Left -= 10
                Else
                    Timer_NvegadorLabel.Enabled = False
                End If
        End Select
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.Click
        info_usuario.Show()
        info_usuario.Text = Nombre.Text
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer_RevistasLabel_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_RevistasLabel.Tick
        Select Case mouse5
            Case 1
                If LabelRevistas.Left < 70 Then
                    LabelRevistas.Left += 10
                Else
                    ' Timer_NavgadorLabel.Enabled = False
                End If
            Case 0
                If LabelRevistas.Left > 12 And seleccionado <> "Revistas" Then
                    LabelRevistas.Left -= 10
                Else
                    Timer_RevistasLabel.Enabled = False
                End If
        End Select
    End Sub

    Private Sub PictureBox1_Click_2(sender As System.Object, e As System.EventArgs) Handles Pbrevistas.Click
        seleccionado = "Revistas"
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        mouse5 = 1
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True
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

        Panel_Graficos.Visible = False

    End Sub

    Private Sub PictureBox1_MouseEnter1(sender As Object, e As System.EventArgs) Handles Pbrevistas.MouseEnter
        If seleccionado = "Rev" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.LightGray
        End If
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        mouse5 = 1
        Timer_RevistasLabel.Enabled = True
    End Sub

    Private Sub PictureBox1_MouseLeave_1(sender As System.Object, e As System.EventArgs) Handles Pbrevistas.MouseLeave
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.Silver
        End If
        mouse5 = 0
        Timer_RevistasLabel.Enabled = True
    End Sub

    Private Sub PanelRevistas_Click(sender As System.Object, e As System.EventArgs)
        seleccionado = "Revistas"
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        mouse5 = 1
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True
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
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub PanelRevistas_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Panel_Revistas.MouseEnter
        Panel_Revistas.BackColor = Drawing.Color.LightGray
    End Sub

    Private Sub PanelRevistas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Panel_Revistas.MouseLeave
        If seleccionado = "Revistas" Then
        Else
            Panel_Revistas.BackColor = Drawing.Color.Silver
        End If
        mouse5 = 0
        LabelRevistas.Enabled = True
    End Sub

    Private Sub Pbconfig_Click(sender As System.Object, e As System.EventArgs) Handles Pbconfig.Click
        ConfiguraciònAdmin.Show()
    End Sub

    Private Sub Pbconfig_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Pbconfig.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Pbconfig_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Pbconfig.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Panel_Revistas_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel_Revistas.MouseClick
        seleccionado = "Revistas"
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        mouse5 = 1
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Timer_RevistasLabel.Enabled = True
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

        Panel_Graficos.Visible = False

    End Sub
End Class