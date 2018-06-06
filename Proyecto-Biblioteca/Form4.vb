Public Class Form4

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        '/////////////////////////////////////////////VARIABLES CON DIA Y HORA////////////////////


    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Consulta = "update usuarios set (tipo = libre) where cedulaU = '" & Cedula.Text & "';" Then
            consultar()
            VERLIBROSAGG.DataSource = Tabla

        Else
            MsgBox("No se encontraron los datos")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '////////////////////////////SE TOMA EL LIBRO MANDADO DEL TEXTBOX Y SE LO PASA A OCUPADO EN LA TABLA LIBROS///////////////////////  

        If Consulta = "update libro set (estado = ocupado) where cod_libros = '" & LIBROS.Text & "';" Then
            consultar()
        Else
            MsgBox("No se encontraron los datos")
        End If

    End Sub


    Private Sub VERLIBROSAGG_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentClick

        '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 


        If IDAGG.Items.Count > 9 Then   '1- Controlar cuántos elementos ya tiene el listbox
            MsgBox("Se llegó al máximo de elementos")

        ElseIf IDAGG.Items.Count < 9 Then
            IDAGG.Items.Add(VERLIBROSAGG.Item(0, VERLIBROSAGG.CurrentRow.Index).Value)
        End If





        If LIBROSAGG.Items.Count > 9 Then    '1- Controlar cuántos elementos ya tiene el listbox
            MsgBox("Se llegó al máximo de elementos")

        ElseIf LIBROSAGG.Items.Count < 9 Then
            LIBROSAGG.Items.Add(VERLIBROSAGG.Item(1, VERLIBROSAGG.CurrentRow.Index).Value)
        End If


        MsgBox("Usted no puede hacer su devolucion hasta que devuelba los libros (agregar consulta aqui luego)")


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("hh:mm:ss")

        Label4.Text = Date.Now.ToString("yy / MM / dd")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Dim a As String
    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cedula.TextChanged

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        DataGridView1.DataSource = Tabla






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
            Consulta = "select * from libro"
            consultar()
            VERLIBROSAGG.DataSource = Tabla

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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NOMBRE.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
    End Sub
    Dim libro As String
    Dim h As String

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        libro = IDAGG.Items(0)
        h = libro + " " + Cedula.Text + " " + Label4.Text
        MsgBox(h)
        Try
            Consulta = "insert into prestamo  values ('" & Cedula.Text & "','" & libro & "','" & Label4.Text & "','')"
            consultar()

            Consulta = "update libro set estado = 'ocupado' where cod_libro = '" & libro & "';"
            consultar()
            MsgBox("se ha ingresado")



        Catch ex As Exception
            MsgBox("se ha ingresasdsddosdfasdfsdfsdfsdfsdfsdfs")
        End Try

    End Sub

    Private Sub DataGridAGG_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAGG.CellContentClick
        'Consulta a DATAGRIDVIEW oculto
        Consulta = "select * from prestamo;"
        consultar()
        OPA.DataSource = Tabla
        '////////////////////////////////

        'Para que si o si se tenga que ingresar una cedula para realizar las funciones 
        If Cedula.Text <> "" Then
            Consulta = "select * from prestamo where CI = '" & Cedula.Text & " ';"
            consultar()
            '////////////////////

            'Se iguala una variable a un valor de la base de datos
            OPA.DataSource = Tabla
            Dim TransoformarDBSDaVariable As DataGridViewRow = OPA.CurrentRow
            Dim VALIDADOR As String
            VALIDADOR = CStr(TransoformarDBSDaVariable.Cells(4).Value)
            '//////////////////////////////////////////////////////////

            '1) Len dice al usario si quiere devolver el libro SI ESTE NO TIENE NINGUN LIBROS EN PODER AHORA
            If VALIDADOR = 0 Then
                MsgBox("Usted puede retirar un libro 0")

                libro = DataGridAGG.Item(1, DataGridAGG.CurrentRow.Index).Value
                Dim a As MsgBoxResult
                a = MsgBox("Desea devolver el libro " & libro & " ?", MsgBoxStyle.YesNo)

                '       2) Se devuelve el libro y se actualiza la Base da datos 
                If a = vbYes Then
                    Consulta = "update libro set estado = 'libre' where cod_libro = '" & libro & "';"
                    consultar()
                    MsgBox("se ha devuelto")
                    Consulta = "select * from prestamo where estado = ocupado"
                    consultar()

                End If

                If a = vbNo Then
                    MsgBox("no")
                End If
                '       2)/////////////////


                '1) En caso que el usuario tenga LIBROS EN PODER no le dejara realizar la tarea  
            ElseIf VALIDADOR = 1 Then
                MsgBox("Usted no puede retirar libros")

            End If
            '    1)////////////////////
        End If
        '/////////////////////////////////////////////////
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OPA.CellContentClick

    End Sub

End Class