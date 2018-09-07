Public Class Inicio_UsuariosV2
    Dim seleccionado As Integer = 0
    Dim activo As Integer = 0
    Dim animacion As Integer = 0
    Dim dia As String
    Dim mes1 As String
    Dim mouse As Integer = 0
    Dim mouse1 As Integer

    Private Sub Inicio_UsuariosV2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Button4.Visible = False
        Label18.Visible = False 'label conytraseña funcionario
        contrasenia.Visible = False 'textbox contraseña funcionario

        Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 1;"
        consultar()
        DataGridView1.DataSource = Tabla

        DatagridModulo = DataGridView1
        Datagrid_Align()


    End Sub

    Private Sub PlaceHolder1_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder1.TextChanged
        Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where cedula like '" & PlaceHolder1.Text & "%' and estado = 1 and tipo = 1"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        seleccionado = 1
        PanelMenu()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        seleccionado = 2
        PanelMenu()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        seleccionado = 3
        PanelMenu()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles TimerMenu.Tick

        If animacion = 1 Then
            Select Case activo

                Case 0



                    If Menu_Panel.Left > 650 Then
                        Menu_Panel.Left -= 10
                    Else
                        activo = 1
                        TimerMenu.Enabled = False
                    End If




                Case 1




                    If Menu_Panel.Left < 954 Then
                        Menu_Panel.Left += 10
                    Else
                        activo = 0
                        TimerMenu.Enabled = False
                    End If




            End Select
        Else
            TimerMenu.Enabled = False
        End If

    End Sub

    Private Sub PanelMenu()

        Select Case activo
            Case 0

                Select Case seleccionado
                    Case 1

                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 650
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = True
                        DataGridView1.Width = 631

                        For i As Integer = 0 To 31
                            If i = 0 Then
                                ComboBox1.Items.Add("Dia")
                            Else
                                ComboBox1.Items.Add(i)
                            End If
                        Next

                        ComboBox2.Items.Add("Mes")
                        ComboBox2.Items.Add("Enero")
                        ComboBox2.Items.Add("Febrero")
                        ComboBox2.Items.Add("Marzo")
                        ComboBox2.Items.Add("Abril")
                        ComboBox2.Items.Add("Mayo")
                        ComboBox2.Items.Add("Junio")
                        ComboBox2.Items.Add("Julio")
                        ComboBox2.Items.Add("Agosto")
                        ComboBox2.Items.Add("Setiembre")
                        ComboBox2.Items.Add("Octubre")
                        ComboBox2.Items.Add("Noviembre")
                        ComboBox2.Items.Add("Diciembre")

                        For i As Integer = 1899 To 2000
                            If i = 1899 Then
                                ComboBox3.Items.Add("Año")
                            Else
                                ComboBox3.Items.Add(i)
                            End If
                        Next

                        activo = 1

                        ComboBox1.SelectedIndex = 0
                        ComboBox2.SelectedIndex = 0
                        ComboBox3.SelectedIndex = 0

                    Case 2

                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 650
                        Editar_Panel.Visible = True
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 631

                        For i As Integer = 0 To 31
                            If i = 0 Then
                                ComboBox4.Items.Add("Dia")
                            Else
                                ComboBox4.Items.Add(i)
                            End If
                        Next

                        ComboBox5.Items.Add("Mes")
                        ComboBox5.Items.Add("Enero")
                        ComboBox5.Items.Add("Febrero")
                        ComboBox5.Items.Add("Marzo")
                        ComboBox5.Items.Add("Abril")
                        ComboBox5.Items.Add("Mayo")
                        ComboBox5.Items.Add("Junio")
                        ComboBox5.Items.Add("Julio")
                        ComboBox5.Items.Add("Agosto")
                        ComboBox5.Items.Add("Setiembre")
                        ComboBox5.Items.Add("Octubre")
                        ComboBox5.Items.Add("Noviembre")
                        ComboBox5.Items.Add("Diciembre")


                        For i As Integer = 1899 To 2000
                            If i = 1899 Then
                                ComboBox6.Items.Add("Año")
                            Else
                                ComboBox6.Items.Add(i)
                            End If
                        Next

                        activo = 1

                        ComboBox4.SelectedIndex = 0
                        ComboBox5.SelectedIndex = 0
                        ComboBox6.SelectedIndex = 0

                    Case 3

                        ComboClear()
                        Menu_Panel.Left = 955
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920
                        Menu_Panel.BackColor = Color.Red
                        activo = 1


                End Select





            Case 1

                Select Case seleccionado

                    Case 1

                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920

                        activo = 0

                    Case 2

                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920

                        activo = 0

                    Case 3

                        ComboClear()
                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920
                        Menu_Panel.BackColor = Color.Silver
                        activo = 0

                End Select





        End Select
    End Sub

    Private Sub ComboClear()


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim styleMSG As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Question
        Dim styleMSGOK As MsgBoxStyle = MsgBoxStyle.OkOnly + MsgBoxStyle.Question
        Dim confirmacion As String = 0
        Dim cedulaAdmin As String
        Dim cedulaUser As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim dia As String = ""
        Dim mes1 As String = ""
        Dim año As String = ""

        mouse = 0

        Select Case seleccionado

            Case 2

                Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento , tipo from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
                consultar()

                For Each row As DataRow In Tabla.Rows

                    nombre.Text = row("nombre").ToString
                    apellido.Text = row("apellido").ToString
                    cedula.Text = row("cedula").ToString
                    telefono.Text = row("telefono").ToString
                    direccion.Text = row("direccion").ToString

                    dia = row("nacimiento").ToString.Substring(0, 2)
                    mes1 = row("nacimiento").ToString.Substring(3, 2)
                    año = row("nacimiento").ToString.Substring(6, 4)


                    Select Case row("tipo").ToString
                        Case 0 'funcionario

                            RadioButton5.Select()
                            Label18.Visible = True
                            contrasenia.Visible = True
                            contrasenia.Text = row("contrasenia").ToString

                        Case 1 'socio

                            RadioButton6.Select()
                            Label18.Visible = False
                            contrasenia.Visible = False

                    End Select
                Next
                Dim x = 1

                substring = mes1
                mes()
                mes1 = substring



                For Each item In ComboBox4.Items

                    If item = dia Then
                        ComboBox4.SelectedIndex = x - 1
                    End If
                    x = x + 1
                Next
                x = 1
                For Each item In ComboBox5.Items

                    If item = mes1 Then
                        ComboBox5.SelectedIndex = x - 1
                    End If
                    x = x + 1
                Next
                x = 1
                For Each item In ComboBox6.Items

                    If item = año Then
                        ComboBox6.SelectedIndex = x - 1
                    End If
                    x = x + 1
                Next


            Case 3

                If MsgBox("desea borrar este usuario", styleMSG, Title:="desea borrar?") = MsgBoxResult.Yes Then

                    cedulaAdmin = InputBox("ingrese una cedula de un administrador", Title:=" ")

                    Consulta = "select cedula from usuarios where tipo = 1 and cedula = '" & cedulaAdmin & "' and tipo = 1"
                    consultar()


                    For Each row As DataRow In Tabla.Rows

                        confirmacion = row("cedula").ToString

                    Next

                    If confirmacion = cedulaAdmin Then

                        Consulta = "update usuarios set estado = 0 where cedula = '" & cedulaUser & "'"
                        consultar()
                        Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 1"
                        consultar()
                        DataGridView1.DataSource = Tabla
                    Else
                        MsgBox("la cedula ingresada no coincide con ningun administrador", styleMSGOK, Title:="Error")
                    End If


                End If


        End Select
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click




        ' Crear Variables

        Dim ced1 As Integer = Nothing
        Dim nom As String = Nothing
        Dim ape As String = Nothing
        Dim tel As Integer = Nothing
        Dim dir As String = Nothing
        Dim tipo As Integer = Nothing
        Dim contra As String = Nothing
        Dim i As Integer ' Variable bandera para avisar que existe un error

        i = 0



        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre, "Nombre no puede estar vacío") 'Label invisible debajo de nombre
            i = 1
        Else
            nom = nombre.Text
        End If


        ape = apellido.Text




        ' Verifica si esta vacio cedula
        If LTrim$(cedula.Text) <> "" Then
            If IsNumeric(cedula.Text) = True Then
                Modulo.Verificar_Cedula(cedula.Text)
                If Modulo.correcto = 0 Then
                    ced1 = cedula.Text
                Else
                    i = 1
                    ErrorProvider1.SetError(cedula, "Cedula no valida")
                End If
            Else
                i = 1
                ErrorProvider1.SetError(cedula, "No valido, ingrese solo numeros")
            End If
        End If




        If IsNumeric(telefono.Text) = True Then
            tel = telefono.Text
        Else
            i = 1
            ErrorProvider1.SetError(telefono, "No valido, ingrese solo numeros")
        End If

        dir = direccion.Text

        If RadioButton5.Checked Then
            tipo = 0
        Else
            tipo = 1
        End If


        If ComboBox4.Text = "Dia" Then
            ErrorProvider1.SetError(ComboBox4, "seleccione un dia")
            i = 1
        Else
            dia = ""
            If ComboBox4.SelectedItem.ToString.Length = 1 Then
                dia = "0" & ComboBox4.SelectedItem
            End If
        End If
        If ComboBox5.Text = "Mes" Then
            ErrorProvider1.SetError(ComboBox5, "seleccione un mes")
            i = 1
        Else

            substring = ComboBox5.SelectedItem
            mestonum()

        End If
        If ComboBox6.Text = "Año" Then
            ErrorProvider1.SetError(ComboBox6, "seleccione un año")
            i = 1
        Else

        End If





       

        If i = 0 Then
            Dim nacimiento As String = Str(ComboBox6.SelectedItem).Substring(1, 4) + "-" + substring + "-" + dia
            Try
                Consulta = "update usuarios set cedula='" & Str(ced1) & "' , nombre='" & nom & "', apellido='" & ape & "', direccion='" & dir & "', telefono='" & Str(tel) & "', nacimiento='" & nacimiento & "' , tipo='" & Str(tipo) & "' where cedula = '" & Str(ced1) & "'"
                'Consulta = "update usuarios set nacimiento = '" & nacimiento & "' where cedula = '" & Str(ced1) & "'"
                'Consulta = "update usuarios (cedula,nombre,apellido,direccion,telefono,)"
                consultar()

                MsgBox("Edición guardada satisfactoriamente")

                '//////////////////Mostrar los datos actualizados en el datagrid///////////////////////
                Try
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 1;"
                    consultar()
                    DataGridView1.DataSource = Tabla

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If


        '//////////////////////////////////////////////////////////////////////////////////////





    End Sub

    Private Sub guardar_Click(sender As System.Object, e As System.EventArgs) Handles guardar.Click
        '//////////////////// AGREGAR USUARIOS /////////////////////////////

        ' Crear Variables

        Dim ced As Integer = Nothing
        Dim nom As String = Nothing
        Dim ape As String = Nothing
        Dim tel As Integer = Nothing
        Dim dir As String = Nothing
        Dim tipo As Integer = Nothing
        Dim pass As String = Nothing
        Dim i As Integer = 0 ' Variable bandera para avisar que existe un error
        Dim MsgStyle As MsgBoxStyle



        ' Verificar campos
        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre_txt, "Nombre no puede estar vacío")
            i = 1
        Else
            nom = nombre_txt.Text
        End If



        If LTrim$(apellido_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(apellido_txt, "Apellido no puede estar vacío")
            i = 1
        Else
            ape = apellido_txt.Text
        End If





        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            ErrorProvider1.SetError(cedula_txt, "Cedula no puede estar vacío")
            i = 1
        End If


        If i = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then


                Modulo.Verificar_Cedula(cedula_txt.Text)
                If Modulo.correcto = 0 Then
                    ced = cedula_txt.Text
                Else
                    i = 1
                    ErrorProvider1.SetError(cedula_txt, "Cedula no valida")
                End If
            Else
                i = 1
                ErrorProvider1.SetError(cedula_txt, "No valido, ingrese solo numeros")
            End If
            End If



        If IsNumeric(telefono_txt.Text) = True Then
            tel = telefono_txt.Text
        Else
            i = 1
            ErrorProvider1.SetError(telefono_txt, "No valido, ingrese solo numeros")
        End If



        dir = direccion_txt.Text


        If RadioButton3.Checked = False And RadioButton4.Checked = False Then
            ErrorProvider1.SetError(Label11, "seleccione un tipo de usuario")
            i = 1
        End If




        If ComboBox1.Text = "Dia" Then
            ErrorProvider1.SetError(ComboBox1, "selecione el dia de nacimiento")
            i = 1
        End If

        If ComboBox2.Text = "Mes" Then
            ErrorProvider1.SetError(ComboBox2, "seleccione el mes de nacimiento")
            i = 1
        End If


        If ComboBox3.Text = "Año" Then
            ErrorProvider1.SetError(ComboBox3, "seleccione el año de nacimiento")
            i = 1
        End If

        If i = 0 Then
            If RadioButton3.Checked Then
                tipo = 0
                pass = InputBox("Ingrese una Contraseña").ToString
            Else
                tipo = 1
            End If
        End If

        If i = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try

                If ComboBox1.SelectedItem.ToString.Length = 1 Then
                    dia = "0" + ComboBox1.SelectedItem.ToString
                Else
                    dia = ComboBox1.Text
                End If

                substring = ComboBox2.SelectedItem
                mestonum()

                Dim nacimiento As String = Str(ComboBox3.SelectedItem).Substring(1, 4) + "-" + substring + "-" + dia '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT

                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo , nacimiento, estado, contrasenia) values (concat(upper(left('" + nom + "',1)), lower(substr('" + nom + "',2))), concat(upper(left('" + ape + "',1)), lower(substr('" + ape + "',2))), '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "', '" + nacimiento + "','1', '" + pass + "');"
                consultar()
                MsgStyle = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
                MsgBox("Usuario agregado con exito", MsgStyle, Title:="Biblioteca")



                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                ComboBox4.Text = ""
                ComboBox5.Text = ""
                ComboBox6.Text = ""


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' MsgBox("Existen errores en el formulario, revisar los campos remarcados")
        End If



        Try
            Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 1;"
            consultar()
            DataGridView1.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '///////////////////////////////////////////////////////////////////
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.TextChanged
        ErrorProvider1.SetError(ComboBox1, "")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ErrorProvider1.SetError(ComboBox2, "")
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ErrorProvider1.SetError(ComboBox3, "")
    End Sub

    Private Sub nombre_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles nombre_txt.TextChanged
        ErrorProvider1.SetError(nombre_txt, "")
        VerificarModificacion()
    End Sub

    Private Sub apellido_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles apellido_txt.TextChanged
        ErrorProvider1.SetError(apellido_txt, "")
    End Sub

    Private Sub cedula_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles cedula_txt.TextChanged
        ErrorProvider1.SetError(cedula_txt, "")
    End Sub

    Private Sub telefono_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles telefono_txt.TextChanged
        ErrorProvider1.SetError(telefono_txt, "")
    End Sub

    Private Sub direccion_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles direccion_txt.TextChanged
        ErrorProvider1.SetError(direccion, "")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        ErrorProvider1.SetError(Label11, "")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ErrorProvider1.SetError(Label11, "")
    End Sub

    Private Sub cedula_TextChanged(sender As System.Object, e As System.EventArgs) Handles cedula.TextChanged
        ErrorProvider1.SetError(cedula, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub nombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles nombre.TextChanged
        ErrorProvider1.SetError(nombre, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True

    End Sub
    Private Sub VerificarModificacion()

        If mouse = 0 Then

            Dim nombre1 As String = ""
            Dim apellido1 As String = ""
            Dim cedula1 As String = ""
            Dim telefono1 As String = ""
            Dim direccion1 As String = ""
            Dim dia2 As String = ""
            Dim mes2 As String = ""
            Dim año2 As String = ""
            Dim dianum As String
            Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento , tipo from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
            consultar()

            For Each row As DataRow In Tabla.Rows

                dianum = row("nacimiento").ToString.Substring(0, 2)
                If ComboBox4.SelectedItem.ToString.Length = 1 Then '----------------BUG------------------
                    If dianum = row("nacimiento").ToString.Substring(0, 2) Then
                        dia2 = "0"
                    Else
                        dia2 = "1"
                    End If

                Else
                    If dianum = row("nacimiento").ToString.Substring(0, 2) Then
                        dia2 = "0"
                        dianum = "0"
                    Else
                        dia2 = "1"
                        dianum = "0"
                    End If
                End If


                substring = ComboBox5.SelectedItem
                mestonum()

                If substring = row("nacimiento").ToString.Substring(3, 2) Then
                    mes2 = "0"
                Else
                    mes2 = "1"
                End If

                If ComboBox6.SelectedItem = row("nacimiento").ToString.Substring(6, 4) Then
                    año2 = "0"
                Else
                    año2 = "1"
                End If
                If nombre.Text = row("nombre").ToString Then
                    nombre1 = "0"
                Else
                    nombre1 = "1"
                End If
                If apellido.Text = row("apellido").ToString Then
                    apellido1 = "0"
                Else
                    apellido1 = "1"
                End If
                If cedula.Text = row("cedula").ToString Then
                    cedula1 = "0"
                Else
                    cedula1 = "1"
                End If
                If telefono.Text = row("telefono").ToString Then
                    telefono1 = "0"
                Else
                    telefono1 = "1"
                End If
                If direccion.Text = row("direccion").ToString Then
                    direccion1 = "0"
                Else
                    direccion1 = "1"
                End If
            Next

            
            If nombre1 = "0" And apellido1 = "0" And cedula1 = "0" And telefono1 = "0" And direccion1 = "0" And dia2 = "0" And mes2 = "0" And año2 = "0" Then
                Button4.Visible = False
            Else
                Button4.Visible = True
            End If

        End If

    End Sub

    Private Sub apellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles apellido.TextChanged
        ErrorProvider1.SetError(apellido, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub telefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles telefono.TextChanged
        ErrorProvider1.SetError(telefono, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub direccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles direccion.TextChanged
        ErrorProvider1.SetError(direccion, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        ErrorProvider1.SetError(ComboBox4, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        ErrorProvider1.SetError(ComboBox5, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        ErrorProvider1.SetError(ComboBox6, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub
    Dim contador = 0
    Private Sub Inactivo_Tick(sender As System.Object, e As System.EventArgs) Handles Inactivo.Tick

        contador = contador + 1

        If contador > 1 Then
            contador = 0
            Inactivo.Enabled = False
            mouse = 0
            VerificarModificacion()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        ErrorProvider1.SetError(Label11, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        ErrorProvider1.SetError(Label11, "")
        mouse1 = 1
        contador = 0
        Inactivo.Enabled = True
    End Sub

    Private Sub contrasenia_TextChanged(sender As System.Object, e As System.EventArgs) Handles contrasenia.TextChanged

    End Sub
End Class