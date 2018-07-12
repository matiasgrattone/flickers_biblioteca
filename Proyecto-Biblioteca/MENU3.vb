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


    Private Sub MENU3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
        WebBrowser1.Visible = False
        Panel3.Visible = False

        '-------------------VERIFICAR SI ESTA CONECTADO A LA BASE , SI DA ERROR APARECE LA IMAGEN DE OK (LA QUE ESTA ADENTRO DEL TRY) , SI DA ERROR APARECE LA IMAGEN DE ERROR (LA QUE ESTA ADENTRO DEL CATCH)

        PictureBox8.Image = Image.FromFile("imagenes\cloud-error.png")

        Consulta = "select * from usuarios"
        consultar()
        DataGridView1.DataSource = Tabla

        If DataGridView1.Rows.Count() = 0 Then

            PictureBox8.Image = Image.FromFile("imagenes\cloud-error.png")

        Else
            PictureBox8.Image = Image.FromFile("imagenes\cloud.png")
        End If









        '----------------------------------------------------------------------------


    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
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

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = WebBrowser1.Document.Url.ToString()
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
            WebBrowser1.Navigate(url)
        Catch ex As Exception
            MessageBox.Show("Lo siento. Si has llegado hasta este mensaje ocurrió un error, pero tranquilo que no pasa nada", "Genesis Navigator")
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (ValidarURL(TextBox1.Text) = True) Then
                Navegar(TextBox1.Text)
            Else
                Navegar("http://" & TextBox1.Text)
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        seleccionado = "usuarios"
        mouse = 1
        mouse2 = 0
        mouse3 = 0
        mouse4 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        panel_usuarios.BackColor = Drawing.Color.LightGray
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

        Dim F1 As New inicio_usuarios
        panel_menu.Controls.Clear()
        F1.TopLevel = False
        F1.Parent = panel_menu

        F1.Show()

        panel_menu.Visible = True
        TextBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Panel3.Visible = False
        WebBrowser1.Visible = False




    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        seleccionado = "libros"
        mouse = 0
        mouse2 = 1
        mouse3 = 0
        mouse4 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Dim F3 As New Seleccion_Libro
        panel_menu.Controls.Clear()
        F3.TopLevel = False
        F3.Parent = panel_menu
        F3.Dock = DockStyle.Fill

        F3.Show()

        panel_menu.Visible = True
        TextBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Panel3.Visible = False
        WebBrowser1.Visible = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.LightGray
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        seleccionado = "prestamos"
        mouse = 0
        mouse2 = 0
        mouse3 = 1
        mouse4 = 0
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Dim F4 As New Form4
        panel_menu.Controls.Clear()
        F4.TopLevel = False
        F4.Parent = panel_menu

        F4.Show()

        panel_menu.Visible = True
        TextBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Panel3.Visible = False
        WebBrowser1.Visible = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver


    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////// NAVEGADOR /////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        seleccionado = "navegador"
        mouse = 0
        mouse2 = 0
        mouse3 = 0
        mouse4 = 1
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.LightGray

        Try
            Panel3.Visible = True
            panel_menu.Visible = False
            TextBox1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button1.Visible = True
            Button4.Visible = True
            WebBrowser1.Visible = True
            WebBrowser1.Navigate("www.ecosia.org")

        Catch ex As Exception

        End Try
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
        TextBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Panel3.Visible = False
        WebBrowser1.Visible = False



    End Sub

    Private Sub panel_prestamos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_prestamos.MouseClick
        seleccionado = "prestamos"
        Dim F4 As New Form4
        panel_menu.Controls.Clear()
        F4.TopLevel = False
        F4.Parent = panel_menu
        F4.Show()
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        panel_menu.Visible = True
        TextBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Panel3.Visible = False
        WebBrowser1.Visible = False

        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.LightGray
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub panel_navegador_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs)

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


        Panel3.Visible = True
        panel_menu.Visible = False
        TextBox1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button1.Visible = True
        Button4.Visible = True
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("www.ecosia.org")

    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////// 



    Private Sub panel_usuarios_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel_usuarios.LostFocus

    End Sub

    Private Sub panel_usuarios_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel_usuarios.MouseClick
        seleccionado = "usuarios"
        Timer_LibrosLabel.Enabled = True
        Timer_NvegadorLabel.Enabled = True
        Timer_PrestamosLabel.Enabled = True
        Timer_UsuariosLabel.Enabled = True
        Dim F1 As New inicio_usuarios
        panel_menu.Controls.Clear()
        F1.TopLevel = False
        F1.Parent = panel_menu
        F1.Show()

        panel_menu.Visible = True
        TextBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Panel3.Visible = False
        WebBrowser1.Visible = False



        panel_usuarios.BackColor = Drawing.Color.LightGray
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("www.ecosia.org")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        substring = Date.Now.ToString("MM")
        mes()
        Label1.Text = fecha


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

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
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

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        If seleccionado = "usuarios" Then
        Else
            panel_usuarios.BackColor = Drawing.Color.Silver
        End If
        mouse = 0
        Timer_UsuariosLabel.Enabled = True
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
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

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        If seleccionado = "libros" Then
        Else
            panel_libros.BackColor = Drawing.Color.Silver
        End If
        mouse2 = 0
        Timer_LibrosLabel.Enabled = True
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
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

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        If seleccionado = "prestamos" Then
        Else
            panel_prestamos.BackColor = Drawing.Color.Silver
        End If
        mouse3 = 0
        Timer_PrestamosLabel.Enabled = True
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
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

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        If seleccionado = "navegador" Then
        Else
            panel_navegador.BackColor = Drawing.Color.Silver
        End If
        mouse4 = 0
        Timer_NvegadorLabel.Enabled = True
    End Sub

    Private Sub panel_libros_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

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

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class