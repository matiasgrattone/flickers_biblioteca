﻿Public Class Form4

    '//////////////VARIABLE ESPECIAL PARA REALIZAR CONSULTAS (preguntarle a Gastesi su función)//////////
    Dim z As MsgBoxResult
    Dim h As String
    Dim a As String
    Dim Libro1 As String
    Dim Libro2 As String
    Dim Contador As Integer = 0
    Dim VALIDADOR As String
    '/////////////////////////////////////////////////////////


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ComboBoxMORTAL.Visible = False
        Button2.Visible = False
        Label5.Visible = False
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

        'Consulta a DATAGRIDVIEW oculto
        Consulta = "select * from prestamo where cedula = '" & Cedula.Text & " ';"
        consultar()
        OPA.DataSource = Tabla
        '////////////////////////////////

        '////////////////////////////SE TOMA EL LIBRO MANDADO DEL TEXTBOX Y SE LO PASA A OCUPADO EN LA TABLA LIBROS///////////////////////  

    End Sub



    Private Sub VERLIBROSAGG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentClick


        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = VERLIBROSAGG.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)

        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable2 As DataGridViewRow = OPA.CurrentRow
        VALIDADOR = CStr(TransoformarDBSDaVariable.Cells(2).Value)

        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = IDAGG.Items.Count



                If VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value <> list1 Then
            Dim goku As String
            Dim vegeta As String
            goku = VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value
            vegeta = VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value







            If (IDAGG.Items.Contains(goku)) Then

                MsgBox("Ah donde cree que va loquillo", , "Your King Is Bleeding")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo)

                If z = vbYes Then


                    IDAGG.Items.Add(goku)
                    LIBROSAGG.Items.Add(goku & "                          " & vegeta)


                End If


        End If

        End If

        If LIBROSAGG.Items.Count <> 0 Then

            Button2.Visible = True

        Else

            Button2.Visible = False

        End If





    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("hh:mm:ss")

        Label4.Text = Date.Now.ToString("yyyy-mm-dd")

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



        '////////////////////////////SI EL COMBOBOX = EXTREACCION ----- SE MUESTRA EL GRUPOBOX1///////////////////////  

        If ComboBoxMORTAL.Text = "Extraccion" Then
            ExtCombo.Visible = True




            If VALIDADOR <> 0 Then

                ExtCombo.Visible = False
                MsgBox("Usted NO puede retirar un libro hasta devolver los ya prestados")

            ElseIf OPA.Rows.Count > 0 Then

                MsgBox("/////////Usted puede RETIRAR un libro 0//////////")

                Consulta = "select * from libro where estado = 'disponible'"
                consultar()
                VERLIBROSAGG.DataSource = Tabla

            End If

        ElseIf ComboBoxMORTAL.Text <> "Extraccion" Then
            ExtCombo.Visible = False


        End If



        '////////////////////////////SI EL COMBOBOX = DEVOLUCION ----- SE MUESTRA EL GRUPOBOX2///////////////////////  
        If ComboBoxMORTAL.Text = "Devolucion" Then
            devoCOMBO.Visible = True

            Consulta = "select * from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where cedula = '" & Cedula.Text & "';"
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
                Label5.Visible = True
                ComboBoxMORTAL.Visible = True

            End If

        Catch ex As Exception

            ComboBoxMORTAL.Visible = False
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

            MsgBox("Usted pude RETIRAR UN LIBREO")

            Dim list, contador, libros As Integer
            contador = 0

            list = 0
            list = IDAGG.Items.Count
            list = list
            While contador < list
                contador = Val(contador) + 1



                Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada, tipo) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','','0')"
                consultar()




                Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                consultar()


                MsgBox(IDAGG.Items.Count)
                MsgBox(contador)
                libros = libros + 1
            End While

        ElseIf VALIDADOR <> 0 Then

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
                Consulta = "update libro set estado = 'disponible' where cod_libro = '" & Libro1 & "';"
                consultar()
                Consulta = "delete from prestamo where cod_libro = '" & Libro1 & "'"
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


    Private Sub LIBROSAGG_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIBROSAGG.SelectedIndexChanged

        Dim G As String
        Dim Ga1 As String
        Ga1 = LIBROSAGG.SelectedItem


        G = MsgBox("Desea cancelar la extracción del libro? " & Ga1 & " ?", MsgBoxStyle.YesNo)

        If G = vbYes Then

            LIBROSAGG.Items.Remove(Ga1)


        End If

    End Sub


End Class