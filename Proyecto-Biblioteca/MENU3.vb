Imports System.Threading
Imports System.Text.RegularExpressions
Public Class MENU3
    Dim a As Integer = 0
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer


    Private Sub MENU3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
        WebBrowser1.Visible = False
        Panel3.Visible = False

        '-------------------VERIFICAR SI ESTA CONECTADO A LA BASE , SI DA ERROR APARECE LA IMAGEN DE OK (LA QUE ESTA ADENTRO DEL TRY) , SI DA ERROR APARECE LA IMAGEN DE ERROR (LA QUE ESTA ADENTRO DEL CATCH)

        Try

            Consulta = "select * from usuarios"
            consultar()
            DataGridView1.DataSource = Tabla

            PictureBox8.Image = Image.FromFile("imagenes\cloud.png")

        Catch ex As Exception

            PictureBox8.Image = Image.FromFile("imagenes\cloud-error.png")

        End Try

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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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



        panel_usuarios.BackColor = Drawing.Color.Aqua
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

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
        panel_libros.BackColor = Drawing.Color.Aqua
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

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
        panel_prestamos.BackColor = Drawing.Color.Aqua
        panel_navegador.BackColor = Drawing.Color.Silver
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////// NAVEGADOR /////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Aqua

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


    Private Sub panel_libros_Mouseclick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles panel_libros.MouseClick


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
        panel_libros.BackColor = Drawing.Color.Aqua
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub panel_prestamos_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles panel_prestamos.MouseClick

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
        panel_prestamos.BackColor = Drawing.Color.Aqua
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////// NAVEGADOR /////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub panel_navegador_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles panel_navegador.MouseClick



        panel_usuarios.BackColor = Drawing.Color.Silver
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver



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



    Private Sub panel_usuarios_LostFocus(sender As Object, e As System.EventArgs) Handles panel_usuarios.LostFocus

    End Sub

    Private Sub panel_usuarios_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles panel_usuarios.MouseClick


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



        panel_usuarios.BackColor = Drawing.Color.Aqua
        panel_libros.BackColor = Drawing.Color.Silver
        panel_prestamos.BackColor = Drawing.Color.Silver
        panel_navegador.BackColor = Drawing.Color.Silver

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("www.ecosia.org")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

End Class