Public Class inicio_usuarios


    Dim configuracion As Integer = 1
    Dim notas As Integer = 1



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Panel15.Hide() '// OCULTAR EL PANEL DE CONFIGURACION






        '----------------------------- CONSULTA PARA LA BUSQUEDA DE LOS USUARIOS ----- 

        '-------------------VERIFICAR SI ESTA CONECTADO A LA BASE , SI DA ERROR APARECE LA IMAGEN DE OK (LA QUE ESTA ADENTRO DEL TRY) , SI DA ERROR APARECE LA IMAGEN DE ERROR (LA QUE ESTA ADENTRO DEL CATCH)

        Try

            Consulta = "select * from usuarios"
            consultar()
            DataGridView1.DataSource = Tabla

            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(3).Width = 150

            PictureBox2.Image = Image.FromFile("imagenes\cloud.png")

        Catch ex As Exception

            PictureBox2.Image = Image.FromFile("imagenes\cloud-error.png")

        End Try

        '----------------------------------------------------------------------------



        '----- ACTIVAR EL TIMER PARA LA HORA Y FECHA --------------------------------

        Timer1.Enabled = True

        '----------------------------------------------------------------------------



        '--------------------- OCULTAR EL BOTON PARA "MINIMIZAR EL PANEL" -----------

        Button2.Hide()
        Button1.Location = New Point(214, 618)

        '----------------------------------------------------------------------------




        '/////////////////////////////////////////////////////////////////////////////////////////////////////

    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        '//////////////////////////////////////////// TIMER PARA HORA Y FECHA /////////////////////////////////

        Label5.Text = Date.Now.ToString("hh:mm:ss")

        Label7.Text = Date.Now.ToString("dd / MM / yy")

        '//////////////////////////////////////////////////////////////////////////////////////////////////////

    End Sub

    Private Sub Panel5_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseClick

        '//-------------BUSCAR USUARIOS--------------------//

        'Panel2.BackColor = Drawing.Color.Pink
        TabControl1.SelectTab("TabPage2")
        'Panel9.BackColor = Drawing.Color.Pink

        Panel4.Height = 42
        Panel5.Height = 45
        Panel6.Height = 42
        Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick

        '//-------------AGREGAR USUARIOS--------------------//


        'Panel2.BackColor = Drawing.Color.LightBlue
        TabControl1.SelectTab("TabPage1")
        'Panel10.BackColor = Drawing.Color.LightBlue

        Panel4.Height = 45
        Panel5.Height = 42
        Panel6.Height = 42
        Panel7.Height = 42

        '//-------------------------------------------------//

    End Sub


    Private Sub Panel6_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseClick

        '//-------------EDITAR USUARIOS--------------------//

        'Panel2.BackColor = Drawing.Color.Red
        TabControl1.SelectTab("TabPage3")
        'Panel11.BackColor = Drawing.Color.Red

        Panel4.Height = 42
        Panel5.Height = 42
        Panel6.Height = 45
        Panel7.Height = 42

        '//------------------------------------------------//

    End Sub


    Private Sub Panel7_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel7.MouseClick

        '//-------------BORRAR USUARIOS--------------------//

        'Panel2.BackColor = Drawing.Color.Green
        TabControl1.SelectTab("TabPage4")
        ' Panel12.BackColor = Drawing.Color.Green

        Panel4.Height = 42
        Panel5.Height = 42
        Panel6.Height = 42
        Panel7.Height = 45

        Consulta = "select * from usuarios"
        consultar()
        DataGridView2.DataSource = Tabla


        '//------------------------------------------------//

    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        '//------------CONSULTA BUSQUEDA DE USUARIOS---------------//

        Dim a As String = TextBox1.Text

        Consulta = "select * from usuarios where nombre like '" & TextBox1.Text & "%'"
        consultar()
        DataGridView1.DataSource = Tabla

        '//-----------------------------------------------//



    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        '//-------------BUSCAR USUARIOS PICTUREBOX--------------------//


        TabControl1.SelectTab("TabPage1")

        Panel4.Height = 45
        Panel5.Height = 42
        Panel6.Height = 42
        Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

        '//-------------BUSCAR USUARIOS PICTUREBOX--------------------//


        TabControl1.SelectTab("TabPage2")

        Panel4.Height = 42
        Panel5.Height = 45
        Panel6.Height = 42
        Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

        '//-------------EDITAR USUARIOS PICTUREBOX--------------------//

        TabControl1.SelectTab("TabPage3")


        Panel4.Height = 42
        Panel5.Height = 42
        Panel6.Height = 45
        Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        '//-------------BORRAR USUARIOS PICTUREBOX--------------------//


        TabControl1.SelectTab("TabPage4")

        Panel4.Height = 42
        Panel5.Height = 42
        Panel6.Height = 42
        Panel7.Height = 45

        Consulta = "select * from usuarios"
        consultar()
        DataGridView2.DataSource = Tabla



        '//------------------------------------------------//
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        '//////////////////////////// OCULTAR PANEL IZQUIERDO EN LA PANTALLA /////////////////////////////////////


        Panel1.Width = 106
        Panel1.Height = 749
        MonthCalendar1.Visible = False
        Label1.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        PictureBox2.Visible = False

        Panel1.Location = New Point(172, 12)
        Button2.Location = New Point(0, 618)

        Button1.Hide()
        Button2.Show()



        '///////////////////////////////////////////////////////////////////////////////////////////////////////////


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        '//////////////////////////// MOSTRAR PANEL IZQUIERDO EN LA PANTALLA /////////////////////////////////////

        Panel1.Width = 265
        Panel1.Height = 749
        MonthCalendar1.Visible = True
        Label1.Visible = True
        Label5.Visible = True
        Label7.Visible = True
        PictureBox2.Visible = True

        Panel1.Location = New Point(12, 12)
        Button1.Location = New Point(214, 618)

        Button1.Show()
        Button2.Hide()

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub


    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Select Case configuracion


            Case 1 '/////////////////////////MOSTRAR EL PANEL DE CONFIGUARCION Y OCULTAR EL PANEL DE USUARIOS///////////////////////////////

                Panel15.Show()
                Panel14.Hide()

                configuracion = 0

            Case 0 '/////////////////////////OCULTAR EL PANEL DE CONFIGURACION Y MOSTRAR EL PANEL DE USUARIOS///////////////////////////////

                Panel15.Hide()
                Panel14.Show()

                configuracion = 1

        End Select

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub


    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////


        Select Case notas

            Case 1 '///////////////////////////// ACTIVAR PANEL DE NOTAS /////////////////////////////////////////////////////

                Panel15.Hide()
                Panel14.Hide()
                notas = 0

            Case 0 '///////////////////////////// DESACTIVAR PANEL DE NOTAS /////////////////////////////////////////////////////

                Panel15.Hide()
                Panel14.Show()
                notas = 1

        End Select





        '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click

        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            opcioncolor = ColorDialog1.Color
        End If
        Panel16.BackColor = opcioncolor
        color()

    End Sub

    Private Sub Panel16_Click1(sender As Object, e As System.EventArgs) Handles Panel16.Click

        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            opcioncolor = ColorDialog1.Color
        End If
        Panel16.BackColor = opcioncolor
        color()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        Dim nombre As String
        Dim codlibro As Integer
        Dim a As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Critical
        Dim b As MsgBoxResult
        nombre = DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value

        b = MsgBox("desea eliminar a " + nombre + "?", a, Title:="hola")


        Select Case b

            Case MsgBoxResult.No

                MsgBox("hola")

            Case MsgBoxResult.Yes

                codlibro = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value
                Consulta = "delete from usuarios where cedulaU = '" & codlibro & "'"
                consultar()


        End Select


        Consulta = "select * from usuarios"
        consultar()
        DataGridView2.DataSource = Tabla


    End Sub


    '////////////////////////////////////////CONSULTA EDITAR USUARIOS//////////////////////////////////////////
    Function filtro(ByVal busqueda As String) As DataTable
        Consulta = "select cedulaU, nombre, telefono, direccion, tipo from usuarios where nombre like '%" + busqueda + "%';"
        consultar()
        Return (Tabla)
    End Function
    '////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////editar usuarios boton cargar //////////////////////
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim rowindex As Integer = DataGridView3.SelectedRows(0).Index()

        nombre.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(1).Value.ToString())
        apellido.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(2).Value.ToString())
        cedula.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(0).Value.ToString())
        telefono.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(3).Value.ToString())
        direccion.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(4).Value.ToString())
        ocupacion.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(5).Value.ToString())
        '//////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

        nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        '//////////////////////////////editar usuarios boton cargar //////////////////////
        Try
            Consulta = "select * from usuarios;"
            consultar()
            registro.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If filtro(TextBox4.Text).Rows.Count > 0 Then
            DataGridView3.DataSource = filtro(TextBox4.Text)
        End If


        '//////////////////////////////editar usuarios boton cargar //////////////////////



    End Sub

    Private Sub guardar_Click(sender As System.Object, e As System.EventArgs) Handles guardar.Click
        '//////////////////// AGREGAR USUARIOS /////////////////////////////

        ' Crear Variables

        Dim ced As Double
        Dim nom As String
        Dim ape As String
        Dim tel As Double
        Dim dir As String
        Dim ocu As String
        Dim i As Double ' Variable bandera para avisar que existe un error
        i = 0

        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre.Text = "Nombre no puede estar vacío"
            i = 1
        Else
            nom = nombre.Text
        End If
        ape = apellido.Text
        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula.Text = "Cedula no puede estar vacío"
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula.Text) = True Then
                ced = cedula.Text
            Else
                errorcedula.Text = "No valido, ingrese solo numeros"
            End If
        End If
        If IsNumeric(telefono.Text) = True Then
            tel = telefono.Text
        Else
            errortelefono.Text = "No valido, ingrese solo numeros"
        End If
        dir = direccion.Text
        ocu = ocupacion.Text

        If i = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try


                ' sql = "insert into usuarios (nombre, cedula, telefono, direccion, ocupacion) values '" + nom + "', '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + ocu + "'"
                Consulta = "insert into usuarios (nombre, cedulaU, telefono, direccion, tipo) values ('" + nom + "', '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + ocu + "');"

                consultar()

                MsgBox("Usuario agregado con exito")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
        Try
            Consulta = "select * from usuarios;"

            consultar()

            DataGridView1.Rows.Add(Tabla)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        '///////////////////////////////////////////////////////////////////
    End Sub
End Class
