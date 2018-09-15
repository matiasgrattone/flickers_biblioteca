Imports System.Threading
Imports System.Text.RegularExpressions
Public Class MENU3
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer
    Dim seleccionado As String = "Inicio"
    Dim mouse As Integer
    Dim mouse2 As Integer
    Dim mouse3 As Integer
    Dim mouse4 As Integer
    Dim mouse5 As Integer
    Dim mouse6 As Integer
    Public F3 As New Seleccion_Libro
    Dim PrimerInicio As Integer = 1
    Dim ContadorDia As Integer = 0
    Dim ContadorMes As Integer = 0


    Private Sub MENU3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        xf = Me.Location.X
        yf = Me.Location.Y


        '///////////////////VENTANA DE LIBROS QUE SE DEVUELVEN EN EL DIA///////////////////////
        'Aviso_de_prestamos.Show()
        Pbadvertenciaprestamos.Visible = False
        Panel_prestamosdia.Visible = False

        Try
            Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
            Consulta = "select titulo from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where fecha_salida='" + fecha + "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                If Not IsDBNull(row("titulo")) Then
                    Pbadvertenciaprestamos.Visible = True
                End If
            Next
        Catch ex As Exception
        End Try





            verificarBD()




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
            ComboBox1.SelectedIndex = 0


            For i As Integer = 1899 To Date.Now.ToString("yyyy")
                If i = 1899 Then
                    ComboBox2.Items.Add("Año")
                Else
                    ComboBox2.Items.Add(i)
                End If
                ComboBox2.SelectedItem = i
            Next




            '////////////////////////////////////////////////////////////////////////////////////////////////
            Chart()
            '////////////////////////////////////////////////////////////////////////////////////////////////


            Select Case ANIMACION


                Case 1



                Case 0

                    label_usuarios.Left = 72
                    label_libros.Left = 72
                    LabelInicio.Left = 72
                    LabelRevistas.Left = 72
                    label_prestamos.Left = 72
                    label_navegador.Left = 72

            End Select

            '//////////////// PRESTAMOS EN VIVO ///////////////
            Timer_Prestamos_LIVE.Enabled = True
            '/////////////////////////////////////////////////


            Preparar_Form()


            panel_usuarios.BackColor = Drawing.Color.Silver
            panel_libros.BackColor = Drawing.Color.Silver
            panel_prestamos.BackColor = Drawing.Color.Silver
            panel_navegador.BackColor = Drawing.Color.Silver
            Panel_Revistas.BackColor = Drawing.Color.Silver
            Panel_Inicio.BackColor = Drawing.Color.LightGray

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
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

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////ANIMACION LABELS Y PANELES EN MENU3 //////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    '///////////////////////////////////////////////////// USUARIOS/////////////////////////////////////////////////////////////

    Private Sub panel_usuarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseEnter

        Select Case ANIMACION

            Case 1

                If seleccionado = "usuarios" Then
                Else
                    panel_usuarios.BackColor = Drawing.Color.LightGray
                End If

                If ANIMACION = 1 Then
                    mouse = 1
                    mouse2 = 0
                    mouse3 = 0
                    mouse4 = 0
                    mouse5 = 0
                    mouse6 = 0
                    Timer_UsuariosLabel.Enabled = True
                Else

                End If

            Case 0

                If seleccionado = "usuarios" Then
                Else
                    panel_usuarios.BackColor = Drawing.Color.LightGray
                End If

        End Select



    End Sub

    Private Sub panel_usuarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.MouseLeave
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver
        End If
    End Sub

    Private Sub panel_usuarios_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_usuarios.MouseClick
        seleccionado = "usuarios"
        Select Case ANIMACION
            Case 1

                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True


            Case 0



        End Select

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



    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseEnter


        Select Case ANIMACION
            Case 1
                If seleccionado = "usuarios" Then
                Else
                    panel_usuarios.BackColor = Drawing.Color.LightGray
                End If

                mouse = 1
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0
                Timer_UsuariosLabel.Enabled = True

            Case 0

                If seleccionado = "usuarios" Then
                Else
                    panel_usuarios.BackColor = Drawing.Color.LightGray
                End If

        End Select




    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbusuarios.MouseLeave

        Select Case ANIMACION
            Case 1

                If seleccionado = "usuarios" Then
                Else
                    panel_usuarios.BackColor = Drawing.Color.Silver
                End If
                mouse = 0
                Timer_UsuariosLabel.Enabled = True

            Case 0

                If seleccionado = "usuarios" Then
                Else
                    panel_usuarios.BackColor = Drawing.Color.Silver
                End If

        End Select





    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuarios.Click
        seleccionado = "usuarios"

        Select Case ANIMACION
            Case 1

                mouse = 1
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0

                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True
                Timer_RevistasLabel.Enabled = True
                Timer_InicioLabel.Enabled = True

            Case 0


        End Select



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


    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    '//////////////////////////////////////////////////// LIBROS /////////////////////////////////////////////////////////////

    Private Sub panel_libros_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.LightGray
                End If
                If ANIMACION = 1 Then
                    mouse = 0
                    mouse2 = 1
                    mouse3 = 0
                    mouse4 = 0
                    mouse5 = 0
                    mouse6 = 0
                    Timer_LibrosLabel.Enabled = True
                End If

            Case 0

                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.LightGray
                End If

        End Select


    End Sub

    Private Sub panel_libros_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_libros.MouseLeave
        Select Case ANIMACION


            Case 1

                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.Silver
                End If
                mouse = 0
                label_libros.Enabled = True

            Case 0


                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.Silver
                End If

        End Select


    End Sub

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

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 1
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0
                Timer_LibrosLabel.Enabled = True

            Case 0

                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.LightGray
                End If

        End Select

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pblibros.MouseLeave
        Select Case ANIMACION


            Case 1


                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.Silver
                End If
                mouse2 = 0
                Timer_LibrosLabel.Enabled = True

            Case 0

                If seleccionado = "libros" Then
                Else
                    panel_libros.BackColor = Drawing.Color.Silver
                End If

        End Select

    End Sub

    Public Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pblibros.Click

        seleccionado = "libros"

        Select Case ANIMACION
            Case 1

                mouse = 0
                mouse2 = 1
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0
                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True
                Timer_RevistasLabel.Enabled = True
                Timer_InicioLabel.Enabled = True

            Case 0


        End Select


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


    '/////////////////////////////////////////////  PRESTAMOS ///////////////////////////////////////////////////////////


    Private Sub panel_prestamos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseEnter
        Select Case ANIMACION

            Case 1

                If seleccionado = "prestamos" Then
                Else
                    panel_prestamos.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 1
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0
                Timer_PrestamosLabel.Enabled = True


            Case 0

                If seleccionado = "prestamos" Then
                Else
                    panel_prestamos.BackColor = Drawing.Color.LightGray
                End If

        End Select


    End Sub

    Private Sub panel_prestamos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_prestamos.MouseClick
        seleccionado = "prestamos"

        Dim F4 As New Prestamos
        panel_menu.Controls.Clear()
        F4.TopLevel = False
        F4.Parent = panel_menu
        F4.Show()

        Select Case ANIMACION
            Case 1

                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True

            Case 0


        End Select


        Preparar_Form()


        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub panel_prestamos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_prestamos.MouseLeave
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver
        End If

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbprestamos.MouseEnter
        Select Case ANIMACION

            Case 1

                If seleccionado = "prestamos" Then
                Else
                    panel_prestamos.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 1
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0
                Timer_PrestamosLabel.Enabled = True

            Case 0

                If seleccionado = "prestamos" Then
                Else
                    panel_prestamos.BackColor = Drawing.Color.LightGray
                End If

        End Select


    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbprestamos.MouseLeave
        Select Case ANIMACION

            Case 1

                If seleccionado = "prestamos" Then
                Else
                    panel_prestamos.BackColor = Drawing.Color.Silver
                End If
                mouse3 = 0
                Timer_PrestamosLabel.Enabled = True

            Case 0

                If seleccionado = "prestamos" Then
                Else
                    panel_prestamos.BackColor = Drawing.Color.Silver
                End If

        End Select


    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbprestamos.Click
        seleccionado = "prestamos"
        Select Case ANIMACION
            Case 1

                mouse = 0
                mouse2 = 0
                mouse3 = 1
                mouse4 = 0
                mouse5 = 0
                mouse6 = 0
                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True
                Timer_RevistasLabel.Enabled = True
                Timer_InicioLabel.Enabled = True

            Case 0


        End Select

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


    '/////////////////////////////////////////////////// PANEL NAVEGADOR ////////////////////////////////////////////////////////////


    Private Sub panel_navegador_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_navegador.MouseEnter

        Select Case ANIMACION
            Case 1

                If seleccionado = "navegador" Then
                Else
                    panel_navegador.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 1
                mouse5 = 0
                mouse6 = 0
                Timer_NvegadorLabel.Enabled = True

            Case 0

                If seleccionado = "navegador" Then
                Else
                    panel_navegador.BackColor = Drawing.Color.LightGray
                End If

        End Select

    End Sub


    Private Sub panel_navegador_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_navegador.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If

    End Sub

    '////////////////////////////////////////////////// PICTUREBOX NAVEGADOR //////////////////////////////////////////////////////

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbnavegador.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "navegador" Then
                Else
                    panel_navegador.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 1
                mouse5 = 0
                mouse6 = 0
                Timer_NvegadorLabel.Enabled = True

            Case 0

                If seleccionado = "navegador" Then
                Else
                    panel_navegador.BackColor = Drawing.Color.LightGray
                End If

        End Select

    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pbnavegador.MouseLeave
        Select Case ANIMACION

            Case 1

                If seleccionado = "navegador" Then
                Else
                    panel_navegador.BackColor = Drawing.Color.Silver
                End If
                mouse4 = 0
                Timer_NvegadorLabel.Enabled = True

            Case 0

                If seleccionado = "navegador" Then
                Else
                    panel_navegador.BackColor = Drawing.Color.Silver
                End If

        End Select


    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbnavegador.Click
        seleccionado = "navegador"

        Select Case ANIMACION
            Case 1

                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 1
                mouse5 = 0
                mouse6 = 0

                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True
                Timer_RevistasLabel.Enabled = True
                Timer_InicioLabel.Enabled = True


            Case 0


        End Select




        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.LightGray
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.Silver

        Preparar_Form()



    End Sub


    '///////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////// NAVEGADOR /////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaginainicio.Click
        Wbnavegador.Navigate("www.ecosia.org")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecargar.Click
        Wbnavegador.Refresh()
    End Sub

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



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub PictureBox1_Click_2(sender As System.Object, e As System.EventArgs) Handles Pbrevistas.Click
        seleccionado = "Revistas"
        Select Case ANIMACION
            Case 1

                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 1
                mouse6 = 0

                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True
                Timer_RevistasLabel.Enabled = True
                Timer_InicioLabel.Enabled = True

            Case 2


        End Select



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

    Private Sub PictureBox1_MouseEnter1(sender As Object, e As System.EventArgs) Handles Pbrevistas.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 1
                mouse6 = 0
                Timer_RevistasLabel.Enabled = True

            Case 0

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.LightGray
                End If

        End Select

    End Sub

    Private Sub PictureBox1_MouseLeave_1(sender As System.Object, e As System.EventArgs) Handles Pbrevistas.MouseLeave
        Select Case ANIMACION

            Case 1

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.Silver
                End If
                mouse5 = 0
                Timer_RevistasLabel.Enabled = True

            Case 0

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.Silver
                End If

        End Select

    End Sub

    Private Sub PanelRevistas_Click(sender As System.Object, e As System.EventArgs)
        seleccionado = "Revistas"
        Select Case ANIMACION


            Case 1

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

            Case 0




        End Select


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

    Private Sub PanelRevistas_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Panel_Revistas.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 1
                mouse6 = 0
                Timer_RevistasLabel.Enabled = True

            Case 0

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.LightGray
                End If

        End Select


    End Sub

    Private Sub PanelRevistas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Panel_Revistas.MouseLeave
        Select Case ANIMACION


            Case 1

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.Silver
                End If
                mouse5 = 0
                LabelRevistas.Enabled = True

            Case 0

                If seleccionado = "Revistas" Then
                Else
                    Panel_Revistas.BackColor = Drawing.Color.Silver
                End If

        End Select


    End Sub

    Private Sub Panel_Revistas_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel_Revistas.MouseClick
        seleccionado = "Revistas"

        Select Case ANIMACION


            Case 1

                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 1
                mouse6 = 0
                Timer_LibrosLabel.Enabled = True
                Timer_NvegadorLabel.Enabled = True
                Timer_PrestamosLabel.Enabled = True
                Timer_UsuariosLabel.Enabled = True
                Timer_RevistasLabel.Enabled = True

            Case 0


        End Select

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





    Private Sub PbInicio_Click(sender As System.Object, e As System.EventArgs) Handles PbInicio.Click
        seleccionado = "Inicio"
        Chart()

        Select Case ANIMACION
            Case 1
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 1
                Timer_InicioLabel.Enabled = True
            Case 0

        End Select



        Preparar_Form()


        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
        Panel_Revistas.BackColor = Drawing.Color.Silver
        Panel_Inicio.BackColor = Drawing.Color.LightGray




    End Sub

    Private Sub PbInicio_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PbInicio.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "Inicio" Then
                Else
                    Panel_Inicio.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 1
                Timer_InicioLabel.Enabled = True

            Case 0

                If seleccionado = "Inicio" Then
                Else
                    Panel_Inicio.BackColor = Drawing.Color.LightGray
                End If

        End Select



    End Sub

    Private Sub PbInicio_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PbInicio.MouseLeave

        Select Case ANIMACION
            Case 1

                If seleccionado = "Inicio" Then
                Else
                    Panel_Inicio.BackColor = Drawing.Color.Silver
                End If
                mouse = 0
                Timer_InicioLabel.Enabled = True

            Case 0

                If seleccionado = "Inicio" Then
                Else
                    Panel_Inicio.BackColor = Drawing.Color.Silver
                End If

        End Select



    End Sub

    Private Sub Panel_Inicio_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Panel_Inicio.MouseEnter
        Select Case ANIMACION
            Case 1

                If seleccionado = "Inicio" Then
                Else
                    Panel_Inicio.BackColor = Drawing.Color.LightGray
                End If
                mouse = 0
                mouse2 = 0
                mouse3 = 0
                mouse4 = 0
                mouse5 = 0
                mouse6 = 1
                Timer_InicioLabel.Enabled = True

            Case 0

                If seleccionado = "Inicio" Then
                Else
                    Panel_Inicio.BackColor = Drawing.Color.LightGray
                End If

        End Select


    End Sub



    '/////////////////////// CONFIGURACION ADMINISTRADOR ///////////////////////////////////////////////////////

    Private Sub Pbconfig_Click(sender As System.Object, e As System.EventArgs) Handles Pbconfig.Click

        Dim open As Integer
        For Each f As Form In Application.OpenForms

            If f.Name = "ConfiguraciònAdmin" Then
                open = 1
            Else
                open = 0
            End If




        Next

        If open = 0 Then

            Try
                Dim contraseñaAdmin As String

                contraseñaAdmin = InputBox("Por favor ingrese contraseña de un funcionario", Title:="Biblioteca")
                Consulta = "select * from usuarios where tipo = 0"
                consultar()

                For Each row As DataRow In Tabla.Rows


                    If row("cedula") = contraseñaAdmin Then
                        contraseñaAdmin = "1"
                    Else
                    End If

                Next


                If contraseñaAdmin = "1" Then
                    ConfiguraciònAdmin.Show()
                Else
                    MsgBox("contraseña no valida", Title:="Biblioteca")
                End If
            Catch ex As Exception
            End Try
        Else
        End If

    End Sub 'Evento clik

    Private Sub Pbconfig_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Pbconfig.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub 'Evento Mouse enter

    Private Sub Pbconfig_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Pbconfig.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub 'Evento Mouse leave

    '/////////////////////////////////////// INFORMACION DEL USUARIO LOGEADO ////////////////////////////////////

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.Click 'Evento clik
        info_usuario.Show()
        info_usuario.Text = Nombre.Text
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.MouseEnter 'Evento Mouse enter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbusuario.MouseLeave 'Evento Mouse leave
        Me.Cursor = Cursors.Default
    End Sub

    '///////////////////////////////////////////////// TIMERS /////////////////////////////////////////////////////////////////////////////////


    Public Sub TimerInicio_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_InicioLabel.Tick 'Timer Inicio

        Select Case mouse6
            Case 1
                If LabelInicio.Left < 70 Then
                    LabelInicio.Left += 10
                Else
                End If
            Case 0
                If LabelInicio.Left > 12 And seleccionado <> "Inicio" Then
                    LabelInicio.Left -= 10
                Else
                    Timer_InicioLabel.Enabled = False
                End If
        End Select
    End Sub
    Public Sub Timer_RevistasLabel_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_RevistasLabel.Tick 'Timer Revistas

        Select Case mouse5
            Case 1
                If LabelRevistas.Left < 70 Then
                    LabelRevistas.Left += 10
                Else
                End If
            Case 0
                If LabelRevistas.Left > 12 And seleccionado <> "Revistas" Then
                    LabelRevistas.Left -= 10
                Else
                    Timer_RevistasLabel.Enabled = False
                End If
        End Select
    End Sub
    Public Sub Timer_UsuariosLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UsuariosLabel.Tick 'Timer Usuarios

        Select Case mouse
            Case 1
                If label_usuarios.Left < 75 Then
                    label_usuarios.Left += 10
                Else
                End If

            Case 0
                If label_usuarios.Left > 11 And seleccionado <> "usuarios" Then
                    label_usuarios.Left -= 10
                Else
                    Timer_UsuariosLabel.Enabled = False
                End If
        End Select



    End Sub

    Public Sub Timer_LibrosLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_LibrosLabel.Tick 'Timer Libros
        Select Case mouse2
            Case 1
                If label_libros.Left < 79 Then
                    label_libros.Left += 10
                Else
                End If
            Case 0
                If label_libros.Left > 20 And seleccionado <> "libros" Then
                    label_libros.Left -= 10
                Else
                    Timer_LibrosLabel.Enabled = False
                End If
        End Select
    End Sub

    Public Sub Timer_PrestamosLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_PrestamosLabel.Tick 'Timer Prestamos
        Select Case mouse3
            Case 1
                If label_prestamos.Left < 71 Then
                    label_prestamos.Left += 10
                Else
                End If
            Case 0
                If label_prestamos.Left > 7 And seleccionado <> "prestamos" Then
                    label_prestamos.Left -= 10
                Else
                    Timer_PrestamosLabel.Enabled = False
                End If
        End Select
    End Sub

    Public Sub Timer_NavgadorLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_NvegadorLabel.Tick 'Timer Navegador
        Select Case mouse4
            Case 1
                If label_navegador.Left < 70 Then
                    label_navegador.Left += 10
                Else
                End If
            Case 0
                If label_navegador.Left > 12 And seleccionado <> "navegador" Then
                    label_navegador.Left -= 10
                Else
                    Timer_NvegadorLabel.Enabled = False
                End If
        End Select
    End Sub




    '////////////////////////////////////////////////////////////TIMER HORA ///////////////////////////////////////////////////////

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

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


    Private Sub Chart()

        Chart_Prestamos.Series.Clear()
        Chart_Prestamos.ChartAreas.Clear()

        '/////////////////////////////// CHART DE PRESTAMOS Y USUARIOS //////////////////////////////////
        Consulta = "select count(prestamolibro.cod_libro) , month(prestamolibro.fecha_salida) from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro group by month(fecha_salida)"
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
        'Chart_Prestamos.ChartAreas(0).AxisY.MajorGrid.Enabled = False

        '//////////////////////////////////////////////////////////////////////////////////////////////////
        Select Case PrimerInicio
            Case 1

                Try
                    substring = Date.Now.ToString("MM")
                    Consulta = "select count(prestamolibro.cod_libro) , day(prestamolibro.fecha_salida) from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where month(prestamolibro.fecha_salida) = '" & substring & "' group by day(fecha_salida)"
                    consultar()

                    substring = Date.Now.ToString("MM")
                    mes()

                    For Each item In ComboBox1.Items

                        If substring = item Then
                            ComboBox1.SelectedIndex = ContadorMes
                        End If
                        ContadorMes = ContadorMes + 1
                    Next

                    ContadorMes = 0

                    ChartPrestamosDia.Series.Clear()
                    ChartPrestamosDia.ChartAreas.Clear()

                    ChartPrestamosDia.ChartAreas.Add("Prestamos Del Dia")
                    ChartPrestamosDia.Series.Add("Prestamos Del Dia")

                    For Each row As DataRow In Tabla.Rows

                        ChartPrestamosDia.Series("Prestamos Del Dia").Points.AddXY(row("day(prestamolibro.fecha_salida)"), row("count(prestamolibro.cod_libro)"))
                        ChartPrestamosDia.Series("Prestamos Del Dia").Points(ContadorDia).AxisLabel = "Dia : " + "#VALX"
                        ContadorDia = ContadorDia + 1

                    Next

                    ChartPrestamosDia.Series("Prestamos Del Dia").Label = "Libros : " + "#VALY"

                    ChartPrestamosDia.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                    'Chart_Prestamos.ChartAreas(0).AxisY.MajorGrid.Enabled = False 
                    PrimerInicio = 0

                    ChartTOP.Series.Clear()
                    ChartTOP.ChartAreas.Clear()

                    ChartTOP.Series.Add("TOP")
                    ChartTOP.ChartAreas.Add("TOP")

                    Consulta = "select count(prestamolibro.cod_libro) , libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro group by prestamolibro.cod_libro limit 5"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        ChartTOP.Series("TOP").Points.AddXY(row("titulo"), row("count(prestamolibro.cod_libro)"))

                    Next

                Catch ex As Exception

                End Try

            Case 0

                Try
                    substring = ComboBox1.SelectedItem
                    mestonum()
                    If substring.Substring(0, 1) = 0 Then
                        substring.Remove(0)
                    End If

                    Consulta = "select count(prestamolibro.cod_libro) , day(prestamolibro.fecha_salida) from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where month(prestamolibro.fecha_salida) = '" & substring & "' group by day(fecha_salida)"
                    consultar()

                    ChartPrestamosDia.Series.Clear()
                    ChartPrestamosDia.ChartAreas.Clear()

                    ChartPrestamosDia.ChartAreas.Add("Prestamos Del Dia")
                    ChartPrestamosDia.Series.Add("Prestamos Del Dia")

                    Dim x As Integer = 0
                    For Each row As DataRow In Tabla.Rows

                        ChartPrestamosDia.Series("Prestamos Del Dia").Points.AddXY(row("day(prestamolibro.fecha_salida)"), row("count(prestamolibro.cod_libro)"))
                        ChartPrestamosDia.Series("Prestamos Del Dia").Points(x).AxisLabel = "Dia : " + "#VALX"
                        x = x + 1
                    Next

                    ChartPrestamosDia.Series("Prestamos Del Dia").Label = "Libros : " + "#VALY"

                    ChartPrestamosDia.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                    'Chart_Prestamos.ChartAreas(0).AxisY.MajorGrid.Enabled = False


                    ChartTOP.Series.Clear()
                    ChartTOP.ChartAreas.Clear()

                    ChartTOP.Series.Add("TOP")
                    ChartTOP.ChartAreas.Add("TOP")

                    Consulta = "select count(prestamolibro.cod_libro) , libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro group by prestamolibro.cod_libro limit 5"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        ChartTOP.Series("TOP").Points.AddXY(row("titulo"), row("count(prestamolibro.cod_libro)"))

                    Next

                Catch ex As Exception

                End Try

        End Select
 


    End Sub

    Private Sub Timer_Prestamos_LIVE_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Prestamos_LIVE.Tick
        If seleccionado = "Inicio" Then
            Try
                ListBox1.Items.Clear()
                Consulta = "select libro.titulo from libro inner join prestamolibro on libro.cod_libro = prestamolibro.cod_libro where fecha_entrada is null"
                consultar()
                For Each row As DataRow In Tabla.Rows
                    ListBox1.Items.Add(row("titulo"))
                Next
            Catch ex As Exception
                MsgBox("Error Libros Prestados Timer")
            End Try
        Else
        End If



    End Sub
    Dim x As Integer = 1
    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        If x = 0 Then
            PanelPrestamosLIVE.Left = 1010
            PanelGraph1.Width = 969
            ChartPrestamosDia.Width = 963
            ChartTOP.Width = 462
            PanelPrestamosTOP.Width = 469
            PictureBox1.Left = 970
            x = 1
        Else
            PanelPrestamosLIVE.Left = 860
            PictureBox1.Left = 835
            PanelGraph1.Width = 833
            ChartPrestamosDia.Width = 827
            ChartTOP.Width = 326
            PanelPrestamosTOP.Width = 333
            x = 0
        End If



    End Sub

    Private Sub Pbadvertenciaprestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbadvertenciaprestamos.Click
        If Panel_prestamosdia.Visible = False Then
            LbPrestamos.Items.Clear()
            Panel_prestamosdia.Visible = True
            Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
            Consulta = "select titulo from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where fecha_salida='" + fecha + "'"
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

    Private Sub Pbnube_MouseHover(sender As System.Object, e As System.EventArgs) Handles Pbnube.MouseHover
        verificarBD()
    End Sub

    Private Sub verificarBD()
        Consulta = "select * from usuarios"
        consultar()
        DataGridView1.DataSource = Tabla


        If DataGridView1.Rows.Count() = 0 Then

            Pbnube.Image = Image.FromFile("imagenes\cloud-error.png")
            ToolTip1.Show("Base de Datos LOCAL", Pbnube)

        Else
            Pbnube.Image = Image.FromFile("imagenes\cloud.png")
            ToolTip1.Show("Base de Datos ONLINE", Pbnube)
        End If

    End Sub
End Class