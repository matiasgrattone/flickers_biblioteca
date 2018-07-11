Public Class Form4

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

            MsgBox("No se encontraron los datos", Title:="ERROR")

        End If

    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Se cambia el label solo cuando haya un valor en el textbox CEDULA

        Try

            If Cedula.Text <> "" Then

                'Consulta a DATAGRIDVIEW oculto

                Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
                consultar()
                DataGridView1.DataSource = Tabla

                '////////////////////////////////

                ComboBoxMORTAL.Visible = True
                Label5.Visible = True
                NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value

            End If

        Catch ex As Exception

            ComboBoxMORTAL.Visible = False
            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

        End Try



        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        '////////////////////////////////

        'Se iguala una variable a un valor de la base de datos para hacer consulta luego


    End Sub



    Private Sub VERLIBROSAGG_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentDoubleClick


        'Se iguala una variable a un valor de la base de datos
        Dim TransoformarDBSDaVariable As DataGridViewRow = VERLIBROSAGG.CurrentRow
        Dim NOMBREdelLIBRO As String
        NOMBREdelLIBRO = CStr(TransoformarDBSDaVariable.Cells(1).Value)


        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 

        Dim list1 As Integer
        list1 = IDAGG.Items.Count



        If VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value <> list1 Then
            Dim goku As String
            Dim vegeta As String
            goku = VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value
            vegeta = VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value







            If (IDAGG.Items.Contains(goku)) Then

                MsgBox("Este libro " & goku & " ya se encuentra en el carrito de extracción ", Title:="PRESTAMOS")


            Else

                z = MsgBox("Desea llevar al carrito el libro " & NOMBREdelLIBRO & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

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
        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla

        Consulta = "select * from libro where estado = 'disponible'"
        consultar()
        VERLIBROSAGG.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow











        '////////////////////////////SI EL COMBOBOX = EXTREACCION ----- SE MUESTRA EL GRUPOBOX1///////////////////////  

        If ComboBoxMORTAL.Text = "Extraccion" Then


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            If Cedula.Text <> "" Then

                If (OPA.RowCount = 1) Then

                    ExtCombo.Visible = True
                    MsgBox("/////////Usted puede RETIRAR un libro 0//////////")

                    Consulta = "select * from libro where estado = 'disponible'"
                    consultar()
                    VERLIBROSAGG.DataSource = Tabla

                End If

            Else
                MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
            End If
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Try
                If Cedula.Text <> "" Then
                    If (ROWS.Cells(3).Value.ToString) <> "" Then
                        ExtCombo.Visible = True
                        MsgBox("Usted pude RETIRAR UN LIBREO", Title:="CASO DOS")

                        Consulta = "select * from libro where estado = 'disponible'"
                        consultar()
                        VERLIBROSAGG.DataSource = Tabla
                    Else
                        ExtCombo.Visible = False
                        MsgBox("Usted NO puede retirar un libro hasta devolver los ya prestados", Title:="ERROR")
                    End If

                Else
                    MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
                End If
            Catch ex As Exception
            End Try
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        ElseIf ComboBoxMORTAL.Text <> "Extraccion" Then
            ExtCombo.Visible = False

        End If



            '////////////////////////////SI EL COMBOBOX = DEVOLUCION ----- SE MUESTRA EL GRUPOBOX2///////////////////////  
        If ComboBoxMORTAL.Text = "Devolucion" Then

            If Cedula.Text <> "" Then
                devoCOMBO.Visible = True

                Consulta = "select * from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
                consultar()

                DataGridAGG.DataSource = Tabla
            Else
                MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
            End If


        ElseIf ComboBoxMORTAL.Text <> "Devolucion" Then
            devoCOMBO.Visible = False

        End If


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    End Sub




    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Consulta = "select * from prestamo where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()
        OPA.DataSource = Tabla
        Dim ROWS As DataGridViewRow = OPA.CurrentRow


        Dim list, contador, libros As Integer
        contador = 0

        list = 0
        list = IDAGG.Items.Count
        list = list

        '1) El usario que puede extraer un libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
        '/////////////////////CASO UNO///////////////////
        If Cedula.Text <> "" Then
            If (OPA.RowCount = 1) Then

                MsgBox("Usted pude RETIRAR UN LIBREO", Title:="PRESTAMO")

                While contador < list
                    contador = Val(contador) + 1


                    Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','')"
                    consultar()


                    Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                    consultar()


                    MsgBox(IDAGG.Items.Count)
                    MsgBox(contador)
                    libros = libros + 1

                End While

                LIBROSAGG.Items.Clear()
                IDAGG.Items.Clear()
            End If


        Else
            MsgBox("La cedula debe estar ingrezada correctamente", Title:="PRESTAMOS")
        End If


        '/////////////////////CASO DOS///////////////////
        Try
            If Cedula.Text <> "" Then

                If (ROWS.Cells(3).Value.ToString) <> "" Then
                    MsgBox("Usted pude RETIRAR UN LIBREO", Title:="PRESTAMO")

                    While contador < list
                        contador = Val(contador) + 1


                        Consulta = "insert into prestamo (cedula, cod_libro, fecha_salida, fecha_entrada) values ('" & Cedula.Text & "','" & IDAGG.Items(libros) & "','" & Label4.Text & "','')"
                        consultar()


                        Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & IDAGG.Items(libros) & "';"
                        consultar()


                        MsgBox(IDAGG.Items.Count)
                        MsgBox(contador)
                        libros = libros + 1

                    End While

                    LIBROSAGG.Items.Clear()
                    IDAGG.Items.Clear()
                Else
                    MsgBox("Este usuario no puede retirar libros hasta devolver los prestados", Title:="PRESTAMOS")

                End If

            Else
                MsgBox("La cedula debe estar ingrezada", Title:="PRESTAMOS")
            End If

        Catch ex As Exception
        End Try


        '    1)////////////////////
    End Sub






    Private Sub DataGridAGG_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellContentDoubleClick
        'Consulta a DATAGRIDVIEW oculto
        Consulta = "select * from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()

        DataGridAGG.DataSource = Tabla
        '////////////////////////////////

        'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
        If Cedula.Text <> "" Then
            Consulta = "select * from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
            DataGridAGG.DataSource = Tabla

            consultar()

            ComboBoxMORTAL.Visible = True
            '////////////////////////////////

            Libro1 = DataGridAGG.Item(1, DataGridAGG.CurrentRow.Index).Value


            If DataGridAGG.Item(3, DataGridAGG.CurrentRow.Index).Value.ToString = "" Then
                Dim a As MsgBoxResult
                a = MsgBox("Desea devolver el libro " & Libro1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

                '       1) Si se devuelve el libro y se actualiza la Base da datos 
                If a = vbYes Then

                    Consulta = "update libro set estado = 'disponible' where cod_libro = '" & Libro1 & "';"
                    consultar()
                    Consulta = "UPDATE prestamo SET fecha_entrada = '" & Label4.Text & "' WHERE cedula = '" & Cedula.Text & "' and cod_libro ='" & Libro1 & "';"
                    consultar()
                    MsgBox("se ha devuelto", Title:="PRESTAMO")

                    Consulta = "select * from prestamo where cedula = '" & Cedula.Text & " ';"
                    VERLIBROSAGG.DataSource = Tabla
                    consultar()

                Else

                    MsgBox("Este libro ya fue devuelto", Title:="PRESTAMOS")

                End If
            End If

            If a = vbNo Then
                MsgBox("No", Title:="PRESTAMOS")
            End If
            '       1)/////////////////

        End If
        '/////////////////////////////////////////////////
    End Sub

    Private Sub LIBROSAGG_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LIBROSAGG.MouseClick

        Dim a1 As String
        Dim Ga1 As String
        Dim MSBOX_Consulta As MsgBoxResult

        Ga1 = LIBROSAGG.SelectedItem

        MSBOX_Consulta = MsgBox("Desea cancelar la extracción del libro? " & Ga1 & " ?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If MSBOX_Consulta = vbYes Then

            a1 = InputBox("Ingrese la id del libro para verificar", Title:="PRESTAMO")

            If (IDAGG.Items.Contains(a1)) Then

                IDAGG.Items.Remove(a1)
                Ga1 = LIBROSAGG.SelectedItem
                LIBROSAGG.Items.Remove(Ga1)

            Else
                MsgBox("Error al ingresar la id", Title:="PRESTAMO ERROR")
            End If

        End If

    End Sub



    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Dim MSBOX_Consulta As MsgBoxResult
        MSBOX_Consulta = MsgBox("Desea volver al menú de inicio?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        If MSBOX_Consulta = vbYes Then
            MENU3.Show()



        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consulta = "select * from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where cedula= '" & Cedula.Text & "';"
        consultar()
        DataGridAGG.DataSource = Tabla
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Consulta = "select * from prestamo p INNER JOIN libro l on p.cod_libro=l.cod_libro where `fecha_entrada` = '' and cedula= '" & Cedula.Text & "';"
        consultar()

        DataGridAGG.DataSource = Tabla
    End Sub
End Class