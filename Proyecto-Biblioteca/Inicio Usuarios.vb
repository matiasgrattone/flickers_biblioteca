Public Class inicio_usuarios

    Dim ced As Integer


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

      

        '//cargar usuarios en registro//

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
        consultar()
        registro.DataSource = Tabla

        '//////////////////





       

    End Sub


    Private Sub Panel5_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseClick
    



        '//-------------BUSCAR USUARIOS PANEL-------------------//

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios;"
        consultar()
        DataGridView1.DataSource = Tabla

        TabControl1.SelectTab("TabPage2")

        Panel4.Height = 42
        Panel5.Height = 45
        Panel6.Height = 42
        Panel7.Height = 42

        '//------------------------------------------------//


        '////////////////// COLOR EN EL DATAGRID DEPENDIENDO DEL VALOR EN UNA FILA DETERMINADA //////////////


        For Each Row As DataGridViewRow In DataGridView1.Rows

            If Row.Cells("nombre").Value = "mateo" Then
                Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
            End If

        Next




        '///////////////////////////////////////////////////////////////////////////////////////////////////


    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick

        '//-------------AGREGAR USUARIOS--------------------//
        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
        consultar()
        registro.DataSource = Tabla

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

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
        consultar()
        DataGridView3.DataSource = Tabla

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

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
        consultar()
        borrar.DataSource = Tabla


        '//------------------------------------------------//

    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        '//------------CONSULTA BUSQUEDA DE USUARIOS---------------//

        Dim a As String = TextBox1.Text

        Consulta = "select * from usuarios where cedula like '" & TextBox1.Text & "%' or nombre like '" & TextBox1.Text & "%'"
        consultar()
        DataGridView1.DataSource = Tabla

        '//-----------------------------------------------//



    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        '//-------------AGREGAR USUARIOS PICTUREBOX--------------------//

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
        consultar()
        registro.DataSource = Tabla

        TabControl1.SelectTab("TabPage1")

        Panel4.Height = 45
        Panel5.Height = 42
        Panel6.Height = 42
        Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click


        '//-------------BUSCAR USUARIOS PICTUREBOX--------------------//

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios;"
        consultar()
        DataGridView1.DataSource = Tabla

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
        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
        consultar()
        DataGridView3.DataSource = Tabla


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

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios;"
        consultar()
        borrar.DataSource = Tabla



        '//------------------------------------------------//
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '//////////////////////////// OCULTAR PANEL IZQUIERDO EN LA PANTALLA /////////////////////////////////////

        '///////////////////////////////////////////////////////////////////////////////////////////////////////////


    End Sub




    '////////////////////////////////////////CONSULTA EDITAR USUARIOS//////////////////////////////////////////
    Function filtro(ByVal busqueda As String) As DataTable
        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento, contrasenia, tipo from usuarios where nombre like '%" + busqueda + "%';"
        consultar()
        Return (Tabla)
    End Function
    '////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////editar usuarios boton cargar //////////////////////
    Public Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim rowindex As Integer = DataGridView3.SelectedRows(0).Index()

        nombre.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(1).Value.ToString())
        apellido.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(2).Value.ToString())
        cedula.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(0).Value.ToString())
        ' ced = Convert.ToString(DataGridView3.Rows(rowindex).Cells(0).Value.ToString())
        telefono.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(3).Value.ToString())
        direccion.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(4).Value.ToString())
        contrasenia.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(6).Value.ToString())

        Try
            'Dim nacimiento1 As String = Convert.ToString(DataGridView3.Rows(rowindex).Cells(5).Value.ToString())
            Dim nacimiento2 As Date = DataGridView3.Rows(rowindex).Cells(5).Value
            DateTimePicker2.Value = nacimiento2
        Catch ex As Exception

        End Try


        If Convert.ToString(DataGridView3.Rows(rowindex).Cells(7).Value.ToString()) = "0" Then
            RadioButton5.Select()
        Else
            RadioButton6.Select()
        End If

        '//////////////////////////////////////////////////////////////////////////////////

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

        nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value
        apellido.Text = DataGridView1.Item(2, DataGridView3.CurrentRow.Index).Value
        cedula.Text = DataGridView1.Item(0, DataGridView3.CurrentRow.Index).Value
        'nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value
        'nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value
        'nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        '//////////////////////////////editar usuarios boton cargar //////////////////////
        Try
            Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
            consultar()
            DataGridView3.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If filtro(TextBox4.Text).Rows.Count > 0 Then
            DataGridView3.DataSource = filtro(TextBox4.Text)
        End If

    End Sub

    '////////////////////////////// editar usuarios boton actualizar datos //////////////////////

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Crear Variables

        Dim ced1 As Integer
        Dim nom As String
        Dim ape As String
        Dim tel As Integer
        Dim dir As String
        Dim tipo As Integer
        Dim contra As String
        Dim i As Integer ' Variable bandera para avisar que existe un error
        i = 0

        ced = cedula.Text

        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre1.Text = "Nombre no puede estar vacío" 'Label invisible debajo de nombre
            i = 1
        Else
            nom = nombre.Text
        End If
        ape = apellido.Text
        If LTrim$(cedula.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula1.Text = "Cedula no puede estar vacío" 'Label invisible debajo de cedula
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula.Text) = True Then
                ced1 = cedula.Text
            Else
                errorcedula1.Text = "No valido, ingrese solo numeros" 'Label invisible debajo de cedula
            End If
        End If
        If IsNumeric(telefono.Text) = True Then
            tel = telefono.Text
        Else
            errortelefono1.Text = "No valido, ingrese solo numeros" 'Label invisible debajo de telefono
        End If
        dir = direccion.Text
        If RadioButton5.Checked Then
            tipo = 0
        Else
            tipo = 1
        End If

        Dim nacimiento As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Try
            Consulta = "update usuarios set nombre='" + nom + "', apellido='" + ape + "', cedula='" + Str(ced1) + "', telefono='" + Str(tel) + "', direccion='" + dir + "', tipo='" + Str(tipo) + "', nacimiento='" + nacimiento + "' where cedula='" + Str(ced) + "';"
            consultar()
            MsgBox("Edición guardada satisfactoriamente")

            '//////////////////Mostrar los datos actualizados en el datagrid///////////////////////
            Try
                Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
                consultar()
                DataGridView3.DataSource = Tabla
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If filtro(TextBox4.Text).Rows.Count > 0 Then
                DataGridView3.DataSource = filtro(TextBox4.Text)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '//////////////////////////////////////////////////////////////////////////////////////
    End Sub



    Private Sub guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar.Click
        '//////////////////// AGREGAR USUARIOS /////////////////////////////

        ' Crear Variables

        Dim ced As Integer
        Dim nom As String
        Dim ape As String
        Dim tel As Integer
        Dim dir As String
        Dim tipo As Integer
        Dim pass As String
        Dim i As Integer ' Variable bandera para avisar que existe un error
        i = 0

        ' Verificar campos
        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre.Text = "Nombre no puede estar vacío"
            i = 1
        Else
            nom = nombre_txt.Text
        End If
        ape = apellido_txt.Text

        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula.Text = "Cedula no puede estar vacío"
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then
                ced = cedula_txt.Text
            Else
                errorcedula.Text = "No valido, ingrese solo numeros"
            End If
        End If
        If IsNumeric(telefono_txt.Text) = True Then
            tel = telefono_txt.Text
        Else
            errortelefono.Text = "No valido, ingrese solo numeros"
        End If

        dir = direccion_txt.Text
        If RadioButton3.Checked Then
            tipo = 0
            pass = InputBox("Ingrese una Contraseña", "Contraseña")
        Else
            tipo = 1
        End If

        If i = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try
                'Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo) values ('" + nom + "', " + ape + "', '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "');

                Dim nacimiento As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")  '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT

                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo , nacimiento, contrasenia) values ('" + nom + "', '" + ape + "', '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "', '" + nacimiento + "', '" + pass + "');"
                consultar()
                MsgBox("Usuario agregado con exito")

                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Try
            Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios;"
            consultar()
            registro.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '///////////////////////////////////////////////////////////////////
    End Sub





    Private Sub DataGridView2_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles borrar.MouseDoubleClick

    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios where nombre like '" & TextBox3.Text & "%'"
        consultar()
        borrar.DataSource = Tabla

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        prueba()
    End Sub


    Private Sub borrar_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles borrar.CellContentDoubleClick

        '////////////////////// ELIMINAR USUARIOS ////////////////////////////////////////////

        Dim nombre As String
        Dim codusuario As Integer
        Dim a As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Critical
        Dim b As MsgBoxResult
        nombre = borrar.Item(1, borrar.CurrentRow.Index).Value

        b = MsgBox("desea eliminar a " + nombre + "?", a, Title:="Eliminar")


        Select Case b

            Case MsgBoxResult.No


            Case MsgBoxResult.Yes

                codusuario = borrar.Item(0, borrar.CurrentRow.Index).Value
                Consulta = "delete from usuarios where cedula = '" & codusuario & "'"
                consultar()


        End Select

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios;"
        consultar()
        borrar.DataSource = Tabla

        '/////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class

