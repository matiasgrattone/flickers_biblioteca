Public Class Form4

    '//////////////VARIABLE ESPECIAL PARA REALIZAR CONSULTAS (preguntarle a Gastesi su función)//////////
    Dim z As MsgBoxResult
    Dim h As String
    Dim a As String
    Dim Libro1 As String
    Dim Libro2 As String
    Dim Contador As Integer = 0
    '/////////////////////////////////////////////////////////


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ComboBoxMORTAL.Visible = False

        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////
        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If
        '/////////////////////////////////////////////VARIABLES CON DIA Y HORA////////////////////

    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Consulta = "update usuarios set (tipo = ""libre"") where cedulaU = '" & Cedula.Text & "';" Then
            consultar()


        Else

            MsgBox("No se encontraron los datos")

        End If

    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        DataGridView1.DataSource = Tabla

        '////////////////////////////SE TOMA EL LIBRO MANDADO DEL TEXTBOX Y SE LO PASA A OCUPADO EN LA TABLA LIBROS///////////////////////  
        If Cedula.Text <> "" Then

            ComboBoxMORTAL.Visible = True

        End If

    End Sub



    Private Sub VERLIBROSAGG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentClick


        'Se iguala una variable a un valor de la base de datos
        OPA.DataSource = Tabla
        Dim TransoformarDBSDaVariable As DataGridViewRow = VERLIBROSAGG.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)



        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        '1)if
        If IDAGG.Items.Count < 10 Then   '1- Controlar cuántos elementos ya tiene el listbox

            z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo)

            '1)a - if
            If z = vbYes Then
                IDAGG.Items.Add(VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value)
            End If


        ElseIf IDAGG.Items.Count > 10 Then

            MsgBox("Se llegó al máximo de elementos")

        End If


        If LIBROSAGG.Items.Count < 10 Then    '1- Controlar cuántos elementos ya tiene el listbox

            If z = vbYes Then
                LIBROSAGG.Items.Add(VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value)
            End If

        End If
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("hh:mm:ss")

        Label4.Text = Date.Now.ToString("yy / MM / dd")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub






    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cedula.TextChanged





        '  If lista <> 0 Then
        'NOMBRE.Text = datos.Tables("usuarios").Rows(0).Item("Nombre")
        ' ESTADO.Text = datos.Tables("usuarios").Rows(0).Item("observacion")
        'End If

        'If ESTADO.Text = "Moroso" Then
        'ESTADO.BackColor = color.FromArgb(255, 0, 0)
        '
        'ElseIf ESTADO.Text <> "Moroso" Then
        'ESTADO.BackColor = color.FromArgb(0, 255, 33)

        ' End If
    End Sub







    Private Sub ComboBoxMORTAL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMORTAL.SelectedIndexChanged

        'Consulta a DATAGRIDVIEW oculto
        Consulta = "select * from prestamo where cedula = '" & Cedula.Text & " ';"
        consultar()
        OPA.DataSource = Tabla
        '////////////////////////////////

        '////////////////////////////SI EL COMBOBOX = EXTREACCION ----- SE MUESTRA EL GRUPOBOX1///////////////////////  

        If ComboBoxMORTAL.Text = "Extraccion" Then
            ExtCombo.Visible = True

            If OPA.Rows.Count > 0 Then

                MsgBox("/////////Usted puede RETIRAR un libro 0//////////")

                Consulta = "select * from libro where estado = 'disponible'"
                consultar()
                VERLIBROSAGG.DataSource = Tabla

            ElseIf OPA.Rows.Count <> 0 Then

                ExtCombo.Visible = False
                MsgBox("Usted NO puede retirar un libro hasta devolver los ya prestados")

            End If

        ElseIf ComboBoxMORTAL.Text <> "Extraccion" Then
            ExtCombo.Visible = False


        End If



        '////////////////////////////SI EL COMBOBOX = DEVOLUCION ----- SE MUESTRA EL GRUPOBOX2///////////////////////  
        If ComboBoxMORTAL.Text = "Devolucion" Then
            devoCOMBO.Visible = True

            Consulta = "select * from prestamo where cedula = '" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'" '// falta join
            consultar()
            DataGridAGG.DataSource = Tabla

        ElseIf ComboBoxMORTAL.Text <> "Devolucion" Then
            devoCOMBO.Visible = False
        End If
    End Sub










    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Se cambia el label solo cuando haya un valor en el textbox CEDULA

        Try

            If Cedula.Text <> "" Then
                NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value

            End If

        Catch ex As Exception

            MsgBox("Debe ingresar una cedula valida")

        End Try

    End Sub




    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Consulta a DATAGRIDVIEW oculto
        Consulta = "select * from prestamo where cedula = '" & Cedula.Text & " ';"
        consultar()
        OPA.DataSource = Tabla
        '////////////////////////////////

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        If OPA.Rows.Count > 0 Then

            Dim L2 As String
            Dim L3 As String
            Dim L4 As String
            Dim L5 As String
            Dim L6 As String
            Dim L7 As String
            Dim L8 As String
            Dim L9 As String
            Dim L10 As String

            ComboBoxMORTAL.Visible = True
            MsgBox("Usted puede retirar un libro 0")

            If Cedula.Text <> "" Then

                If Contador = 1 Then
                    Libro1 = IDAGG.Items(0)
                    'h = Libro1 + "<-- 1Libro /// Cedula:" + Cedula.Text + " fecha de extraccion" + Label4.Text
                    'MsgBox(h)

                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0

                    Catch ex As Exception

                        MsgBox("NO SE A INGRESADOOOOOOOO")

                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 2 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 3 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 4 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 5 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    L5 = IDAGG.Items(4)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L5 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L5 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 6 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    L5 = IDAGG.Items(4)
                    L6 = IDAGG.Items(5)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L5 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L6 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L5 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L6 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 7 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    L5 = IDAGG.Items(4)
                    L6 = IDAGG.Items(5)
                    L7 = IDAGG.Items(6)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L5 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L6 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L7 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L5 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L6 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L7 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 8 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    L5 = IDAGG.Items(4)
                    L6 = IDAGG.Items(5)
                    L7 = IDAGG.Items(6)
                    L8 = IDAGG.Items(7)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L5 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L6 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L7 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L8 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L5 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L6 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L7 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L8 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 9 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    L5 = IDAGG.Items(4)
                    L6 = IDAGG.Items(5)
                    L7 = IDAGG.Items(6)
                    L8 = IDAGG.Items(7)
                    L9 = IDAGG.Items(8)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L5 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L6 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L7 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L8 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L9 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L5 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L6 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L7 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L8 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L9 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                ElseIf Contador = 10 Then
                    Libro1 = IDAGG.Items(0)
                    L2 = IDAGG.Items(1)
                    L3 = IDAGG.Items(2)
                    L4 = IDAGG.Items(3)
                    L5 = IDAGG.Items(4)
                    L6 = IDAGG.Items(5)
                    L7 = IDAGG.Items(6)
                    L8 = IDAGG.Items(7)
                    L9 = IDAGG.Items(8)
                    L10 = IDAGG.Items(9)
                    Try
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & Libro1 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L2 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L3 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L4 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L5 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L6 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L7 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L8 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L9 & "','" & Label4.Text & "','')"
                        Consulta = "insert into prestamo values ('" & Cedula.Text & "','" & L10 & "','" & Label4.Text & "','')"

                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & Libro1 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L2 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L3 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L4 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L5 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L6 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L7 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L8 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L9 & "';"
                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & L10 & "';"
                        consultar()

                        MsgBox("se ha ingresado")

                        IDAGG.Items.RemoveAt(IDAGG.SelectedIndex)
                        LIBROSAGG.Items.RemoveAt(LIBROSAGG.SelectedIndex)
                        Contador = 0
                    Catch ex As Exception
                        MsgBox("NO SE A INGRESADOOOOOOOO")
                    End Try
                    '/////////////////////////////////////////////////////////////////////
                End If

            End If
            '1) En caso que el usuario tenga LIBROS EN PODER no le dejara realizar la tarea (extraccion)  

        ElseIf OPA.Rows.Count <> 0 Then

            MsgBox("Usted no puede retirar libros")

        End If
        '    1)////////////////////
    End Sub






    Private Sub DataGridAGG_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellContentClick
        'Consulta a DATAGRIDVIEW oculto
        Consulta = "select * from prestamo where cedula = '" & Cedula.Text & " ';"
        consultar()
        OPA.DataSource = Tabla
        '////////////////////////////////

        'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
        If Cedula.Text <> "" Then
            Consulta = "select * from prestamo where cedula = '" & Cedula.Text & " ';"
            consultar()

            ComboBoxMORTAL.Visible = True

            '////////////////////

            Libro1 = DataGridAGG.Item(1, DataGridAGG.CurrentRow.Index).Value
            Dim a As MsgBoxResult
            a = MsgBox("Desea devolver el libro " & Libro1 & " ?", MsgBoxStyle.YesNo)

            '       1) Si se devuelve el libro y se actualiza la Base da datos 
            If a = vbYes Then
                Consulta = "update libro set estado = 'libre' where cod_libro = '" & Libro1 & "';"
                consultar()
                MsgBox("se ha devuelto")
                Consulta = "select * from prestamo where estado = ocupado"
                consultar()

            End If

            If a = vbNo Then
                MsgBox("no")
            End If
            '       1)/////////////////

        End If
        '/////////////////////////////////////////////////
    End Sub

End Class