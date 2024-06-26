﻿Public Class Inicio_UsuariosV2
    '////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////

    Dim seleccionado As Integer = 0
    Dim activo As Integer = 0


    Dim animacion As Integer = 0
    Dim mouse As Integer = 0

    '///////////// Variable para verificar cedula y nombre para sacar foto ///////////
    Public error12 As Integer = 0

    '//////////// Variable para ver si cargo o saco la foto del socio ////////////
    Public opcion As Integer ' 0 - Tomo la foto / 1 - Cargo la foto
    Dim opcionEoI As Integer ' 0 - Desde ingresar / 1 - Desde editar

    '//////////// Variable para guardar ruta del archivo para ingresar y editar //////////////
    Public nombreArchivo As String = rutaGuardadoFotos & "/" & "Fotos de socio/student.png"
    Dim cargarFoto As Integer = 0

    '/////////////////////variables para editar usuarios//////////////

    Dim ced_editar As Integer = Nothing
    Dim nom_editar As String = Nothing
    Dim ape_editar As String = Nothing
    Dim tel_editar As String = Nothing
    Dim dir_editar As String = Nothing
    Dim tipo_editar As Integer = Nothing
    Dim contra_editar As String = Nothing
    Dim i_editar As Integer ' Variable bandera para avisar que existe un error

    Dim dia_editar As String
    Dim mes_editar As String
    Dim año_editar As String

    '//////////////////////////////////////////////////////////////////

    '//////////////////////////// variables para ingresar usuarios ////////////////

    Dim ced_ingresar As Integer = Nothing
    Dim nom_ingresar As String = Nothing
    Dim ape_ingresar As String = Nothing
    Dim tel_ingresar As Integer = Nothing
    Dim dir_ingresar As String = Nothing
    Dim tipo_ingresar As Integer = Nothing
    Dim pass_ingresar As String = Nothing
    Dim i_ingresar As Integer = 0 ' Variable bandera para avisar que existe un error
    Dim MsgStyle As MsgBoxStyle

    Dim dia_ingresar As String
    Dim mes_ingresar As String
    Dim año_ingresar As String
    '////////////////////////////////////////////////////////////////////////////////



    '////////////////////////////// variables para el datagrid //////////////////////

    Dim styleMSG_datagrid As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Question
    Dim styleMSGOK_datagrid As MsgBoxStyle = MsgBoxStyle.OkOnly + MsgBoxStyle.Question
    Dim confirmacion As String = 0
    Dim cedulaAdmin As String
    Dim cedulaUser As String
    Dim dia_datagrid As String = ""
    Dim mes_datagrid As String = ""
    Dim año_datagrid As String = ""

    Dim modoVista As Integer = 0 ' 0 disponible , 1 descontinuado
    '////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////

    Private Sub Inicio_UsuariosV2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bt_FichaSocio.Visible = False

        Button4.Visible = False
        Consulta = "select cedula as 'Cedula', nombre as 'Nombre', apellido as 'Apellido', direccion as 'Direccion', telefono 'Telefono', nacimiento as 'Nacimiento' from usuarios where estado = 1 and tipo = 2;"
        consultar()
        DataGridView1.DataSource = Tabla

        DatagridModulo = DataGridView1
        Datagrid_Align()

        'DataGridView1.Columns.Add(DataGridView1.Columns.Count - 1, "Ficha")
        rutafoto1 = ""
        TimerFoto.Enabled = False

        PlaceHolder1.Select()
    End Sub
    Public contadordatagrid As Integer = 0
    Private Sub PlaceHolder1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PlaceHolder1.KeyDown
        If modoVista = 0 Then
            If e.KeyCode = Keys.Enter And Menu_Panel.Left = 954 And seleccionado <> 3 And DataGridView1.Rows.Count > 0 Then
                FichaSocio.FichaCedulaSocio = DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value
                FichaSocio.Show()
            End If
            If e.KeyCode = Keys.Right And DataGridView1.Rows.Count > 0 Then
                seleccionado = 2
                PanelMenu()
            End If
            If e.KeyCode = Keys.Up And contadordatagrid > 0 And DataGridView1.Rows.Count > 0 Then
                DataGridView1.Rows(contadordatagrid - 1).Selected = True
                contadordatagrid = contadordatagrid - 1

                If seleccionado = 2 Then
                    PlaceHolder_Mail_Editar.Clear()
                    Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        nombre.Text = row("nombre").ToString
                        apellido.Text = row("apellido").ToString
                        cedula.Text = row("cedula").ToString
                        telefono.Text = row("telefono").ToString
                        direccion.Text = row("direccion").ToString
                        If row("mail") IsNot DBNull.Value Then
                            PlaceHolder_Mail_Editar.Text = row("mail")
                        End If

                        dia_datagrid = row("nacimiento").ToString.Substring(0, 2)
                        mes_datagrid = row("nacimiento").ToString.Substring(3, 2)
                        año_datagrid = row("nacimiento").ToString.Substring(6, 4)

                        If row("rutaperfil") Is DBNull.Value Then
                            rutaFoto = rutaGuardadoFotos & "/" & Convert.ToString("Fotos de socio\student.jpg")
                        Else
                            rutaFoto = rutaGuardadoFotos & "/" & row("rutaperfil")
                        End If

                    Next

                    Dim x = 1

                    substring = mes_datagrid
                    mes()
                    mes_datagrid = substring

                    For Each item In ComboBox4.Items
                        If item.ToString = dia_datagrid Then
                            ComboBox4.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next


                    ComboBox4.SelectedText = dia_datagrid.ToString

                    x = 1

                    For Each item In ComboBox5.Items
                        If item = mes_datagrid Then
                            ComboBox5.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next

                    x = 1

                    For Each item In ComboBox6.Items
                        If item.ToString = año_datagrid Then
                            ComboBox6.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next
                    ' Inactivo.Enabled = True
                    Button4.Visible = False
                    cargar2()
                End If
            End If
            If e.KeyCode = Keys.Down And contadordatagrid < DataGridView1.Rows.Count - 1 And DataGridView1.Rows.Count > 0 Then
                DataGridView1.Rows(contadordatagrid + 1).Selected = True

                contadordatagrid = contadordatagrid + 1
                If seleccionado = 2 Then
                    PlaceHolder_Mail_Editar.Clear()
                    Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        nombre.Text = row("nombre").ToString
                        apellido.Text = row("apellido").ToString
                        cedula.Text = row("cedula").ToString
                        telefono.Text = row("telefono").ToString
                        direccion.Text = row("direccion").ToString
                        If row("mail") IsNot DBNull.Value Then
                            PlaceHolder_Mail_Editar.Text = row("mail")
                        End If

                        dia_datagrid = row("nacimiento").ToString.Substring(0, 2)
                        mes_datagrid = row("nacimiento").ToString.Substring(3, 2)
                        año_datagrid = row("nacimiento").ToString.Substring(6, 4)

                        If row("rutaperfil") Is DBNull.Value Then
                            rutaFoto = rutaGuardadoFotos & "/" & Convert.ToString("Fotos de socio\student.jpg")
                        Else
                            rutaFoto = rutaGuardadoFotos & "/" & row("rutaperfil")
                        End If

                    Next

                    Dim x = 1

                    substring = mes_datagrid
                    mes()
                    mes_datagrid = substring

                    For Each item In ComboBox4.Items
                        If item.ToString = dia_datagrid Then
                            ComboBox4.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next


                    ComboBox4.SelectedText = dia_datagrid.ToString

                    x = 1

                    For Each item In ComboBox5.Items
                        If item = mes_datagrid Then
                            ComboBox5.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next

                    x = 1

                    For Each item In ComboBox6.Items
                        If item.ToString = año_datagrid Then
                            ComboBox6.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next
                    ' Inactivo.Enabled = True
                    Button4.Visible = False
                    cargar2()
                End If
            End If
        End If
    End Sub

    Private Sub PlaceHolder1_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder1.TextChanged
        Select Case modoVista
            Case 1
                If Not IsNumeric(PlaceHolder1.Text) Then
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 0 and tipo = 2"
                    consultar()
                    DataGridView1.DataSource = Tabla
                Else
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where cedula like '" & PlaceHolder1.Text & "%' and estado = 0 and tipo = 2"
                    consultar()
                    DataGridView1.DataSource = Tabla
                    DatagridModulo = DataGridView1
                    Datagrid_Align()
                    contadordatagrid = 0
                    If DataGridView1.Rows.Count > 0 Then
                        DataGridView1.Rows(0).Selected = True
                    End If
                End If
            Case 0
                If Not IsNumeric(PlaceHolder1.Text) Then
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 2"
                    consultar()
                    DataGridView1.DataSource = Tabla
                Else
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where cedula like '" & PlaceHolder1.Text & "%' and estado = 1 and tipo = 2"
                    consultar()
                    DataGridView1.DataSource = Tabla
                    DatagridModulo = DataGridView1
                    Datagrid_Align()
                    contadordatagrid = 0
                    If DataGridView1.Rows.Count > 0 Then
                        DataGridView1.Rows(0).Selected = True
                    End If
                End If
        End Select

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        seleccionado = 1
        PanelMenu()
        nombre_txt.Clear()
        apellido_txt.Clear()
        cedula_txt.Clear()
        telefono_txt.Clear()
        direccion_txt.Clear()
        PlaceHolderMail.Clear()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        seleccionado = 2
        PanelMenu()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

        If seleccionado <> 3 And activo = 0 Then
            seleccionado = 3
            PanelMenu()
        ElseIf seleccionado = 3 And activo = 1 Then
            seleccionado = 3
            PanelMenu()
        End If

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
                        RadioButton3.Visible = False
                        RadioButton4.Visible = False
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
                        ComboBox2.Items.Add("Septiembre")
                        ComboBox2.Items.Add("Octubre")
                        ComboBox2.Items.Add("Noviembre")
                        ComboBox2.Items.Add("Diciembre")

                        For i As Integer = 1899 To Date.Now.ToString("yyyy")
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
                        RadioButton3.Visible = False
                        RadioButton4.Visible = False
                        mouse = 0
                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 650

                        Editar_Panel.Visible = True
                        Ingresar_Panel.Visible = False

                        DataGridView1.Width = 631

                        '///////////////////////////////////RELLENAR COMBOBOX//////////////////////////////////
                        '///////////////////////////////////////DIA////////////////////////////////////////////
                        For i As Integer = 0 To 31
                            If i = 0 Then

                                ComboBox4.Items.Add("Dia")
                            Else
                                If i.ToString.Length = 1 Then
                                    ComboBox4.Items.Add("0" & i)
                                Else
                                    ComboBox4.Items.Add(i)
                                End If

                            End If
                        Next
                        '//////////////////////////////////////////////////////////////////////////////////////////
                        '////////////////////////////////MES///////////////////////////////////////////////////////
                        ComboBox5.Items.Add("Mes")
                        ComboBox5.Items.Add("Enero")
                        ComboBox5.Items.Add("Febrero")
                        ComboBox5.Items.Add("Marzo")
                        ComboBox5.Items.Add("Abril")
                        ComboBox5.Items.Add("Mayo")
                        ComboBox5.Items.Add("Junio")
                        ComboBox5.Items.Add("Julio")
                        ComboBox5.Items.Add("Agosto")
                        ComboBox5.Items.Add("Septiembre")
                        ComboBox5.Items.Add("Octubre")
                        ComboBox5.Items.Add("Noviembre")
                        ComboBox5.Items.Add("Diciembre")
                        '//////////////////////////////////////////////////////////////////////////////////////////
                        '///////////////////////////////AÑO////////////////////////////////////////////////////////
                        For i As Integer = 1899 To Date.Now.ToString("yyyy")
                            If i = 1899 Then
                                ComboBox6.Items.Add("Año")
                            Else
                                ComboBox6.Items.Add(i)
                            End If
                        Next
                        '//////////////////////////////////////////////////////////////////////////////////////////

                        activo = 1

                        '//////////////////SELECCIONAR EL PRIMER ITEM DE CADA COMBOBOX OSEA EL TEXTO CORRESPONDIENTE EJ: DIA , MES , AÑO
                        ComboBox4.SelectedIndex = 0
                        ComboBox5.SelectedIndex = 0
                        ComboBox6.SelectedIndex = 0
                        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        PlaceHolder_Mail_Editar.Clear()
                        Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                        consultar()

                        For Each row As DataRow In Tabla.Rows

                            nombre.Text = row("nombre").ToString
                            apellido.Text = row("apellido").ToString
                            cedula.Text = row("cedula").ToString
                            telefono.Text = row("telefono").ToString
                            direccion.Text = row("direccion").ToString
                            If row("mail") IsNot DBNull.Value Then
                                PlaceHolder_Mail_Editar.Text = row("mail")
                            End If
                            dia_datagrid = row("nacimiento").ToString.Substring(0, 2)
                            mes_datagrid = row("nacimiento").ToString.Substring(3, 2)
                            año_datagrid = row("nacimiento").ToString.Substring(6, 4)
                            If row("rutaperfil") Is DBNull.Value Then
                                rutaFoto = rutaGuardadoFotos & "/" & Convert.ToString("Fotos de socio\student.jpg")
                            Else
                                rutaFoto = rutaGuardadoFotos & "/" & row("rutaperfil")
                            End If
                        Next
                        cargar2()

                        Dim x = 1

                        substring = mes_datagrid
                        mes()
                        mes_datagrid = substring

                        For Each item In ComboBox4.Items
                            If item.ToString = dia_datagrid Then
                                ComboBox4.SelectedIndex = x - 1
                            End If
                            x = x + 1
                        Next


                        ComboBox4.SelectedText = dia_datagrid.ToString

                        x = 1

                        For Each item In ComboBox5.Items
                            If item = mes_datagrid Then
                                ComboBox5.SelectedIndex = x - 1
                            End If
                            x = x + 1
                        Next

                        x = 1

                        For Each item In ComboBox6.Items
                            If item.ToString = año_datagrid Then
                                ComboBox6.SelectedIndex = x - 1
                            End If
                            x = x + 1
                        Next




                    Case 3
                        RadioButton3.Visible = False
                        RadioButton4.Visible = False

                        '//////LLAMA A COMBOCLEAR PARA LIMPIAR TODOS LOS COMBOBOX///////
                        ComboClear()
                        '///////////////////////////////////////////////////////////////

                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920
                        Menu_Panel.BackColor = Color.Red
                        Panel1.BackColor = Color.Red
                        activo = 1

                End Select





            Case 1
                

                Select Case seleccionado

                    Case 1
                        RadioButton3.Visible = True
                        RadioButton4.Visible = True
                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 937

                        activo = 0
                        seleccionado = 4
                    Case 2
                        RadioButton3.Visible = True
                        RadioButton4.Visible = True
                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 937

                        activo = 0
                        seleccionado = 4
                    Case 3
                        RadioButton3.Visible = True
                        RadioButton4.Visible = True
                        ComboClear()
                        Menu_Panel.Left = 954
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 937
                        Menu_Panel.BackColor = Color.Silver
                        Panel1.BackColor = Color.Silver
                        activo = 0
                        seleccionado = 4
                End Select





        End Select
    End Sub

    Private Sub ComboClear()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '///////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////

        Select modoVista


            Case 1
                cedulaUser = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

                If MsgBox("desea activar a este usuario", styleMSG_datagrid, Title:="Activar?") = MsgBoxResult.Yes Then

                    cedulaAdmin = InputBox("ingrese una cedula de un administrador", Title:=" ")
                    Consulta = "select cedula from usuarios where tipo = 0 and cedula = '" & cedulaAdmin & "'"
                    consultar()

                    For Each row As DataRow In Tabla.Rows
                        confirmacion = row("cedula").ToString
                    Next
                    If confirmacion = cedulaAdmin Then
                        Consulta_dataset = "update usuarios set estado = 1 where cedula = '" & cedulaUser & "' ; select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 0 and tipo = 2"
                        consultar_DataSet()
                        DataGridView1.DataSource = Tabla_dataset.Tables(0)
                    Else
                        MsgBox("la cedula ingresada no coincide con ningun administrador", styleMSGOK_datagrid, Title:="Error")
                    End If
                End If
            Case 0
                bt_FichaSocio.Visible = True
                cedulaUser = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

                mouse = 0

                contadordatagrid = DataGridView1.CurrentRow.Index

                Select Case seleccionado


                    Case 2
                        PlaceHolder_Mail_Editar.Clear()
                        Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                        consultar()

                        For Each row As DataRow In Tabla.Rows

                            nombre.Text = row("nombre").ToString
                            apellido.Text = row("apellido").ToString
                            cedula.Text = row("cedula").ToString
                            telefono.Text = row("telefono").ToString
                            direccion.Text = row("direccion").ToString
                            If row("mail") IsNot DBNull.Value Then
                                PlaceHolder_Mail_Editar.Text = row("mail")
                            End If

                            dia_datagrid = row("nacimiento").ToString.Substring(0, 2)
                            mes_datagrid = row("nacimiento").ToString.Substring(3, 2)
                            año_datagrid = row("nacimiento").ToString.Substring(6, 4)

                            If row("rutaperfil") Is DBNull.Value Or row("rutaperfil") Is "" Then
                                rutaFoto = rutaGuardadoFotos & "\" & Convert.ToString("Fotos de socio\student.jpg")
                            Else
                                rutaFoto = rutaGuardadoFotos & "\" & row("rutaperfil")
                            End If

                        Next

                        Dim x = 1

                        substring = mes_datagrid
                        mes()
                        mes_datagrid = substring

                        For Each item In ComboBox4.Items
                            If item.ToString = dia_datagrid Then
                                ComboBox4.SelectedIndex = x - 1
                            End If
                            x = x + 1
                        Next


                        ComboBox4.SelectedText = dia_datagrid.ToString

                        x = 1

                        For Each item In ComboBox5.Items
                            If item = mes_datagrid Then
                                ComboBox5.SelectedIndex = x - 1
                            End If
                            x = x + 1
                        Next

                        x = 1

                        For Each item In ComboBox6.Items
                            If item.ToString = año_datagrid Then
                                ComboBox6.SelectedIndex = x - 1
                            End If
                            x = x + 1
                        Next
                        ' Inactivo.Enabled = True
                        Button4.Visible = False
                        cargar2()




                    Case 3

                        If MsgBox("desea borrar este usuario", styleMSG_datagrid, Title:="desea borrar?") = MsgBoxResult.Yes Then

                            cedulaAdmin = InputBox("ingrese una cedula de un administrador", Title:=" ")
                            Consulta = "select cedula from usuarios where tipo = 0 and cedula = '" & cedulaAdmin & "'"
                            consultar()

                            For Each row As DataRow In Tabla.Rows
                                confirmacion = row("cedula").ToString
                            Next
                            If confirmacion = cedulaAdmin Then

                                Consulta_dataset = "update usuarios set estado = 0 where cedula = '" & cedulaUser & "' ; select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 2"
                                consultar_DataSet()
                                DataGridView1.DataSource = Tabla_dataset.Tables(0)
                            Else
                                MsgBox("la cedula ingresada no coincide con ningun administrador", styleMSGOK_datagrid, Title:="Error")
                            End If
                        End If
                End Select
        End Select

        '///////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        '///////////////////////////////////////////////////////////////////
        '//////////////////// EDITAR USUARIOS //////////////////////////////
        '///////////////////////////////////////////////////////////////////

        i_editar = 0

        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre, "Nombre no puede estar vacío") 'Label invisible debajo de nombre
            i_editar = 1
        Else
            nom_editar = nombre.Text
        End If

        ape_editar = apellido.Text

        ' Verifica si esta vacio cedula
        If LTrim$(cedula.Text) <> "" Then
            If IsNumeric(cedula.Text) = True Then
                Modulo.Verificar_Cedula(cedula.Text)
                If Modulo.correcto = 0 Then
                    ced_editar = cedula.Text
                    i_editar = 0
                Else
                    i_editar = 1
                    ErrorProvider1.SetError(cedula, "Cedula no valida")
                End If
            Else
                i_editar = 1
                ErrorProvider1.SetError(cedula, "No valido, ingrese solo numeros")
            End If
        End If


        If IsNumeric(telefono.Text) = True Then
            tel_editar = telefono.Text
        Else
            i_editar = 1
            ErrorProvider1.SetError(telefono, "No valido, ingrese solo numeros")
        End If

        dir_editar = direccion.Text


        If ComboBox4.Text = "Dia" Then
            ErrorProvider1.SetError(ComboBox4, "seleccione un dia")
            i_editar = 1
        Else
            dia_editar = ""
            If ComboBox4.SelectedItem.ToString.Length = 1 Then
                dia_editar = "0" & ComboBox4.SelectedItem
            Else
                dia_editar = ComboBox4.SelectedItem
            End If
        End If
        If ComboBox5.Text = "Mes" Then
            ErrorProvider1.SetError(ComboBox5, "seleccione un mes")
            i_editar = 1
        Else



        End If
        If ComboBox6.Text = "Año" Then
            ErrorProvider1.SetError(ComboBox6, "seleccione un año")
            i_editar = 1
        Else

        End If



        substring = ComboBox5.SelectedItem
        mestonum()

        If i_editar = 0 Then
            Dim nacimiento_editar As String = Str(ComboBox6.SelectedItem).Substring(1, 4) + "-" + substring + "-" + dia_editar
            Try
                Consulta = "update usuarios set cedula='" & Str(ced_editar) & "' , nombre='" & nom_editar & "', apellido='" & ape_editar & "', direccion='" & dir_editar & "', telefono='" & tel_editar & "', nacimiento='" & nacimiento_editar & "' ,mail = '" & PlaceHolder_Mail_Editar.Text & "', tipo='2' where cedula = '" & Str(ced_editar) & "'"
                consultar()

                MsgBox("Edición guardada satisfactoriamente")

                '//////////////////Mostrar los datos actualizados en el datagrid///////////////////////
                Try
                    Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 2;"
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
        '///////////////////////////////////////////////////////////////////
        '//////////////////// AGREGAR USUARIOS /////////////////////////////
        '///////////////////////////////////////////////////////////////////
        i_ingresar = 0
        ' Verificar campos
        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre_txt, "Nombre no puede estar vacío")
            i_ingresar = 1
        Else
            nom_ingresar = nombre_txt.Text
        End If



        If LTrim$(apellido_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(apellido_txt, "Apellido no puede estar vacío")
            i_ingresar = 1
        Else
            ape_ingresar = apellido_txt.Text
        End If

        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            ErrorProvider1.SetError(cedula_txt, "Cedula no puede estar vacío")
            i_ingresar = 1
        End If


        If i_ingresar = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then
                Modulo.Verificar_Cedula(cedula_txt.Text)
                If Modulo.correcto = 0 Then
                    ced_ingresar = cedula_txt.Text
                Else
                    i_ingresar = 1
                    ErrorProvider1.SetError(cedula_txt, "Cedula no valida")
                End If
            Else
                i_ingresar = 1
                ErrorProvider1.SetError(cedula_txt, "No valido, ingrese solo numeros")
            End If
        End If



        If IsNumeric(telefono_txt.Text) = True Then
            tel_ingresar = telefono_txt.Text
        Else
            i_ingresar = 1
            ErrorProvider1.SetError(telefono_txt, "No valido, ingrese solo numeros")
        End If

        dir_ingresar = direccion_txt.Text

        If ComboBox1.Text = "Dia" Then
            ErrorProvider1.SetError(Label12, "selecione el dia de nacimiento")
            i_ingresar = 1
        End If

        If ComboBox2.Text = "Mes" Then
            ErrorProvider1.SetError(Label12, "seleccione el mes de nacimiento")
            i_ingresar = 1
        End If


        If ComboBox3.Text = "Año" Then
            ErrorProvider1.SetError(Label12, "seleccione el año de nacimiento")
            i_ingresar = 1
        End If


        If i_ingresar = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try

                If ComboBox1.SelectedItem.ToString.Length = 1 Then
                    dia_ingresar = "0" + ComboBox1.SelectedItem.ToString
                Else
                    dia_ingresar = ComboBox1.Text
                End If

                substring = ComboBox2.SelectedItem
                mestonum()

                Dim nacimiento_ingresar As String = Str(ComboBox3.SelectedItem).Substring(1, 4) + "-" + substring + "-" + dia_ingresar '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT

                If opcion = 0 Then
                    Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo , nacimiento, estado , moroso , fecha_ingreso, rutaperfil) values (concat(upper(left('" + nom_ingresar + "',1)), lower(substr('" + nom_ingresar + "',2))), concat(upper(left('" + ape_ingresar + "',1)), lower(substr('" + ape_ingresar + "',2))), '" + Str(ced_ingresar) + "', '" + Str(tel_ingresar) + "', '" + dir_ingresar + "', '2', '" + nacimiento_ingresar + "','1',0,'" & Date.Now.ToString("yyyy-MM-dd") & "', '" & rutaFoto & "')"
                    consultar()
                End If

                If opcion = 1 Then
                    Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo , nacimiento, estado , moroso , fecha_ingreso, rutaperfil) values (concat(upper(left('" + nom_ingresar + "',1)), lower(substr('" + nom_ingresar + "',2))), concat(upper(left('" + ape_ingresar + "',1)), lower(substr('" + ape_ingresar + "',2))), '" + Str(ced_ingresar) + "', '" + Str(tel_ingresar) + "', '" + dir_ingresar + "', '2', '" + nacimiento_ingresar + "','1',0,'" & Date.Now.ToString("yyyy-MM-dd") & "', '" & nombreArchivo & "')"
                    consultar()
                End If

                If ERROR1 = 1 Then

                    MsgStyle = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
                    MsgBox("Error al agregar usuario", MsgStyle, Title:="Biblioteca")
                    ERROR1 = 0

                Else

                    MsgStyle = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
                    MsgBox("Usuario agregado con exito", MsgStyle, Title:="Biblioteca")
                    ERROR1 = 0

                End If




                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

                ComboBox1.SelectedIndex = 0
                ComboBox2.SelectedIndex = 0
                ComboBox3.SelectedIndex = 0

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' MsgBox("Existen errores en el formulario, revisar los campos remarcados")
        End If
        Try
            Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 2;"
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
    End Sub

    Private Sub apellido_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles apellido_txt.TextChanged
        ErrorProvider1.SetError(apellido_txt, "")
    End Sub

    Private Sub cedula_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles cedula_txt.TextChanged
        ErrorProvider1.SetError(cedula_txt, "")

        If cedula_txt.TextLength = 8 Then
            Verificar_Cedula(cedula_txt.Text)
        End If

        If correcto = 0 Then
            error12 = 0
            ErrorProvider1.SetError(cedula_txt, "")
        Else
            error12 = 1
            ErrorProvider1.SetError(cedula_txt, "La cedula no esta correcta")
        End If

    End Sub

    Private Sub telefono_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles telefono_txt.TextChanged
        ErrorProvider1.SetError(telefono_txt, "")
    End Sub

    Private Sub direccion_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles direccion_txt.TextChanged
        ErrorProvider1.SetError(direccion, "")
    End Sub

    Private Sub cedula_TextChanged(sender As System.Object, e As System.EventArgs) Handles cedula.TextChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(cedula, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(cedula, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub nombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles nombre.TextChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(nombre, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(nombre, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub
    Public rutafoto1 As String = "0"
    Public Sub VerificarModificacion()
        Try
            If mouse = 0 Then

                Dim nombre1 As String = "0"
                Dim apellido1 As String = "0"
                Dim cedula1 As String = "0"
                Dim telefono1 As String = "0"
                Dim direccion1 As String = "0"
                Dim dia2 As String = "0"
                Dim mes2 As String = "0"
                Dim año2 As String = "0"
                Dim dianum As String = "0"
                Dim Mail As String = "0"
                rutafoto1 = "0"

                Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                consultar()

                For Each row As DataRow In Tabla.Rows

                    ' //////////////////FECHA NACIMIENTO////////////////////

                    '/////////////////DIA//////////////////////////


                    If ComboBox4.SelectedItem.ToString.Length = 1 Then

                        dianum = "0" & ComboBox4.SelectedItem


                        If dianum = row("nacimiento").ToString.Substring(0, 2) Then
                            dia2 = "0"
                        Else
                            dia2 = "1"
                        End If

                    Else
                        dianum = ComboBox4.SelectedItem

                        If dianum = row("nacimiento").ToString.Substring(0, 2) Then
                            dia2 = "0"
                        Else
                            dia2 = "1"
                        End If
                    End If
                    '///////////////////////////////////////////////

                    '/////////////////MES//////////////////////////
                    substring = ComboBox5.SelectedItem
                    mestonum()

                    If substring = row("nacimiento").ToString.Substring(3, 2) Then
                        mes2 = "0"
                    Else
                        mes2 = "1"
                    End If
                    '/////////////////////////////////////////////

                    '//////////////////AÑO////////////////////////
                    If ComboBox6.SelectedItem = row("nacimiento").ToString.Substring(6, 4) Then
                        año2 = "0"
                    Else
                        año2 = "1"
                    End If
                    '/////////////////////////////////////////////

                    '/////////////////////////////////////////////////////////////////

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

                    If row("rutaperfil") Is "" Or row("rutaperfil") Is DBNull.Value Then
                        rutafoto1 = "0"
                    Else
                        If (rutaGuardadoFotos & "\" & row("rutaperfil")) = rutaFoto Then
                            rutafoto1 = "0"
                        Else
                            rutafoto1 = "1"
                        End If
                    End If

                    If row("mail") Is DBNull.Value Then
                        Mail = "0"
                    End If

                    If row("mail").ToString = PlaceHolder_Mail_Editar.Text Then
                        Mail = "0"
                    Else
                        Mail = "1"
                    End If



                Next
                If nombre1 = "0" And apellido1 = "0" And cedula1 = "0" And telefono1 = "0" And direccion1 = "0" And dia2 = "0" And mes2 = "0" And año2 = "0" And rutafoto1 = "0" And Mail = "0" Then
                    Button4.Visible = False
                Else
                    Button4.Visible = True
                End If

            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub apellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles apellido.TextChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(apellido, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(apellido, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub telefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles telefono.TextChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(telefono, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(telefono, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub direccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles direccion.TextChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(direccion, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(direccion, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(ComboBox4, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(ComboBox4, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(ComboBox5, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(ComboBox5, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                ErrorProvider1.SetError(ComboBox6, "")
                contador = 0
                Inactivo.Enabled = True
            Case 2
                ErrorProvider1.SetError(ComboBox6, "")
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub
    Dim contador = 0
    Private Sub Inactivo_Tick(sender As System.Object, e As System.EventArgs) Handles Inactivo.Tick
        If seleccionado = 2 Then
            contador = contador + 1

            If contador > 1 Then
                contador = 0
                mouse = 0
                VerificarModificacion()
                Inactivo.Enabled = False
            End If
        Else
            Inactivo.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Imágenes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar imágenes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicación en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de diálogo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            ptbFotoSocio.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posición en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            nombreArchivo = rutaGuardadoFotos & "/" & "Fotos de socio/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            Try
                opcion = 1
                cargar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                ptbFotoSocio.ImageLocation = nombreArchivo
                'cargar()
            Else
                My.Computer.FileSystem.CopyFile(rutaArchivo, nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                cargar()
            End If
        End If
    End Sub

    Private Sub cargar()
        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" & ced_ingresar & "'"
            consultar()

            For Each row As DataRow In Tabla.Rows
                ptbFotoSocio.ImageLocation = rutaGuardadoFotos & "/" & Convert.ToString(row("rutaperfil"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargar2()
        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" & cedula.Text & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                ptbFotoEditar.Refresh()
                ptbFotoEditar.ImageLocation = Convert.ToString("Fotos de socio\student.png")
                If row("rutaperfil") Is DBNull.Value Or row("rutaperfil") Is "" Then
                    ptbFotoEditar.Refresh()
                    ptbFotoEditar.ImageLocation = rutaGuardadoFotos & "/" & Convert.ToString("Fotos de socio\student.jpg")
                Else
                    ptbFotoEditar.Refresh()
                    ptbFotoEditar.ImageLocation = rutaGuardadoFotos & "/" & Convert.ToString(row("rutaperfil"))
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Imágenes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar imágenes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicación en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de diálogo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            ptbFotoEditar.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posición en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            nombreArchivo = rutaGuardadoFotos & "/" & "Fotos de socio/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            Try
                Consulta = "update usuarios set rutaperfil = '" & nombreArchivo & "' where cedula='" + cedula.Text + "'"
                consultar()
                cargar2()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                ptbFotoEditar.ImageLocation = nombreArchivo
                'cargar()
            Else
                My.Computer.FileSystem.CopyFile(rutaArchivo, nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                cargar()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If LTrim$(nombre_txt.Text) = "" Then
            error12 = 1
        End If
        If LTrim$(cedula_txt.Text) = "" Then
            error12 = 1
        End If

            If error12 = 0 Then

            opcionConfigUsers = 1

                nombreFoto = nombre_txt.Text
                cedulaFoto = cedula_txt.Text

            opcion = 0

            TomarFoto.Show()

            opcionEoI = 0

            TimerFoto.Enabled = True

        Else
            MsgBox("Los campos de nombre y cedula deben de estar completos para realizar esto")
        End If

    End Sub
    Private Sub VerFichaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerFichaToolStripMenuItem.Click
        FichaSocio.FichaCedulaSocio = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        FichaSocio.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        PlaceHolderMail.Visible = False
        Label_Mail.Visible = False
    End Sub
    Private Sub RadioButton1_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        PlaceHolderMail.Visible = True
        Label_Mail.Visible = True
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles bt_FichaSocio.Click
        FichaSocio.FichaCedulaSocio = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        FichaSocio.Show()
    End Sub

    Private Sub Inicio_UsuariosV2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        bt_FichaSocio.Visible = False
    End Sub

    Private Sub Panel3_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseClick
        bt_FichaSocio.Visible = False
    End Sub

    Private Sub Panel4_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick
        bt_FichaSocio.Visible = False
    End Sub

    Private Sub PlaceHolder1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PlaceHolder1.MouseClick
        bt_FichaSocio.Visible = False
    End Sub

    Private Sub Panel1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        bt_FichaSocio.Visible = False
    End Sub

    Private Sub Panel2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        bt_FichaSocio.Visible = False
    End Sub

    Private Sub Label10_MouseHover(sender As System.Object, e As System.EventArgs) Handles Label10.MouseHover
        ToolTip1.Show("Campo Opcional", Label10)
    End Sub

    Private Sub Label3_MouseHover(sender As System.Object, e As System.EventArgs) Handles Label3.MouseHover
        ToolTip1.Show("Campo Opcional", Label13)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TimerFoto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFoto.Tick

        If cargarFoto < 5 Then
            For Each f In Application.OpenForms

                If f.name = "TomarFoto" Then

                    cargarFoto = 0

                Else

                    cargarFoto = 5

                End If

            Next

        Else

            Select Case opcionEoI
                Case 0
                    ptbFotoSocio.ImageLocation = rutaFoto
                    ptbFotoSocio.Refresh()
                    Inactivo.Enabled = True
                    TimerFoto.Enabled = False
                Case 1
                    ptbFotoEditar.ImageLocation = rutaFoto
                    ptbFotoEditar.Refresh()
                    TimerFoto.Enabled = False
                    Inactivo.Enabled = True
            End Select


        End If

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If LTrim$(nombre.Text) = "" Then
            error12 = 1
        End If
        If LTrim$(cedula.Text) = "" Then
            error12 = 1
        End If

        If error12 = 0 Then

            nombreFoto = nombre.Text
            cedulaFoto = cedula.Text

            opcion = 0

            TomarFoto.Show()

            opcionEoI = 1

            TimerFoto.Enabled = True

        Else
            MsgBox("Los campos de nombre y cedula deben de estar completos para realizar esto")
        End If

    End Sub
    Private Sub PlaceHolder_Mail_Editar_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder_Mail_Editar.TextChanged
        contador = 0
        Inactivo.Enabled = True
        Select Case seleccionado
            Case 1
                contador = 0
                Inactivo.Enabled = True
            Case 2
                contador = 0
                Inactivo.Enabled = True
        End Select
    End Sub

    Private Sub DataGridView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If modoVista = 0 Then
            If e.KeyCode = Keys.Enter And Menu_Panel.Left = 954 And seleccionado <> 3 Then
                FichaSocio.FichaCedulaSocio = DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value
                FichaSocio.Show()
            End If
            If e.KeyCode = Keys.Right Then
                seleccionado = 2
                PanelMenu()
            End If
            If e.KeyCode = Keys.Enter And Menu_Panel.Left = 650 Then
                DataGridView1.Rows(contadordatagrid).Selected = True
                contadordatagrid = contadordatagrid
            End If

            If e.KeyCode = Keys.Up And contadordatagrid > 0 Then
                DataGridView1.Rows(contadordatagrid - 1).Selected = True
                contadordatagrid = contadordatagrid - 1

                If seleccionado = 2 Then
                    PlaceHolder_Mail_Editar.Clear()
                    Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        nombre.Text = row("nombre").ToString
                        apellido.Text = row("apellido").ToString
                        cedula.Text = row("cedula").ToString
                        telefono.Text = row("telefono").ToString
                        direccion.Text = row("direccion").ToString
                        If row("mail") IsNot DBNull.Value Then
                            PlaceHolder_Mail_Editar.Text = row("mail")
                        End If

                        dia_datagrid = row("nacimiento").ToString.Substring(0, 2)
                        mes_datagrid = row("nacimiento").ToString.Substring(3, 2)
                        año_datagrid = row("nacimiento").ToString.Substring(6, 4)

                        If row("rutaperfil") Is DBNull.Value Then
                            rutaFoto = Convert.ToString("Fotos de socio\student.jpg")
                        Else
                            rutaFoto = row("rutaperfil")
                        End If

                    Next

                    Dim x = 1

                    substring = mes_datagrid
                    mes()
                    mes_datagrid = substring

                    For Each item In ComboBox4.Items
                        If item.ToString = dia_datagrid Then
                            ComboBox4.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next


                    ComboBox4.SelectedText = dia_datagrid.ToString

                    x = 1

                    For Each item In ComboBox5.Items
                        If item = mes_datagrid Then
                            ComboBox5.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next

                    x = 1

                    For Each item In ComboBox6.Items
                        If item.ToString = año_datagrid Then
                            ComboBox6.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next
                    ' Inactivo.Enabled = True
                    Button4.Visible = False
                    cargar2()
                End If
            End If
            If e.KeyCode = Keys.Down And contadordatagrid < DataGridView1.Rows.Count - 1 Then
                DataGridView1.Rows(contadordatagrid + 1).Selected = True

                contadordatagrid = contadordatagrid + 1
                If seleccionado = 2 Then
                    PlaceHolder_Mail_Editar.Clear()
                    Consulta = "select * from usuarios where cedula = '" & DataGridView1.Item(0, DataGridView1.Rows(contadordatagrid).Index).Value & "'"
                    consultar()

                    For Each row As DataRow In Tabla.Rows

                        nombre.Text = row("nombre").ToString
                        apellido.Text = row("apellido").ToString
                        cedula.Text = row("cedula").ToString
                        telefono.Text = row("telefono").ToString
                        direccion.Text = row("direccion").ToString
                        If row("mail") IsNot DBNull.Value Then
                            PlaceHolder_Mail_Editar.Text = row("mail")
                        End If

                        dia_datagrid = row("nacimiento").ToString.Substring(0, 2)
                        mes_datagrid = row("nacimiento").ToString.Substring(3, 2)
                        año_datagrid = row("nacimiento").ToString.Substring(6, 4)

                        If row("rutaperfil") Is DBNull.Value Then
                            rutaFoto = Convert.ToString("Fotos de socio\student.jpg")
                        Else
                            rutaFoto = row("rutaperfil")
                        End If

                    Next

                    Dim x = 1

                    substring = mes_datagrid
                    mes()
                    mes_datagrid = substring

                    For Each item In ComboBox4.Items
                        If item.ToString = dia_datagrid Then
                            ComboBox4.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next


                    ComboBox4.SelectedText = dia_datagrid.ToString

                    x = 1

                    For Each item In ComboBox5.Items
                        If item = mes_datagrid Then
                            ComboBox5.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next

                    x = 1

                    For Each item In ComboBox6.Items
                        If item.ToString = año_datagrid Then
                            ComboBox6.SelectedIndex = x - 1
                        End If
                        x = x + 1
                    Next
                    ' Inactivo.Enabled = True
                    Button4.Visible = False
                    cargar2()
                End If
            End If
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 1 and tipo = 2"
        consultar()
        DataGridView1.DataSource = Tabla
        seleccionado = 0
        modoVista = 0
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        bt_FichaSocio.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Consulta = "select cedula , nombre , apellido , direccion , telefono , nacimiento from usuarios where estado = 0 and tipo = 2"
        consultar()
        DataGridView1.DataSource = Tabla
        seleccionado = 0
        modoVista = 1
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Panel1.BackColor = Drawing.Color.Silver
        bt_FichaSocio.Visible = False
    End Sub
End Class