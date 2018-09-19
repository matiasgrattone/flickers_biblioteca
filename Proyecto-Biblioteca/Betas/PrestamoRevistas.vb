Public Class PrestamoRevistas

    Dim z As MsgBoxResult
    Dim h As String
    Dim a As String
    Dim Libro1 As String
    Dim Libro2 As String
    Dim libro3 As String
    Dim cod_libros As String
    Dim cod_libros2 As String
    Dim Contador As Integer = 0
    Dim VALIDADOR As String
    Dim modo As String = "devolucion"
    Dim panelnombre As Integer = 0

    '/////////////////////////////////////////////////////////


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridParaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ajusta las columnas al tamaño del datagrid
        '/////////////////////////////////////////////GRUPBOX OCULTOS////////////////////
        ExtCombo.Visible = False
        devoCOMBO.Visible = False
        ButonParaExtreaer.Visible = False
        Label5.Visible = False
        PictureExtraccion.Visible = False
        PictureDevolucion.Visible = False
        Label4.Visible = False
        ButtonLiberar.Visible = False
        ButtonMoroso.Visible = False
        '//////////////////////////////////////VARIABLES PARA RALIZAR "CONSULTAS Y IFs" SIN ERRORES///////////////////////
        Dim Contador As Integer = 0
        If z = vbYes Then
            Contador = 1 + Contador
        End If
        '/////////////////////////////////////////////VARIABLES CON DIA Y HORA////////////////////

    End Sub

    Private Sub ButonLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLiberar.Click

        Dim Es_moroso As MsgBoxResult

        'Consulta a DATAGRIDVIEW oculto

        Consulta = "select cedula , nombre from usuarios where cedula like '" & Cedula.Text & "'  "
        consultar()
        For Each row As DataRow In Tabla.Rows
            NOMBRE.Text = row("nombre")
        Next

        '////////////////////////////////

        Es_moroso = MsgBox("Desea que el usuario " & NOMBRE.Text & " deje de ser moroso?", MsgBoxStyle.YesNo, Title:="PRESTAMOS")

        Try

            If Cedula.Text <> "" Then

                '////////////////////////////////
                If Es_moroso = vbYes Then

                    Consulta = "update usuarios set (tipo = ""0"") where cedulaU = '" & Cedula.Text & "';"
                    consultar()

                    MsgBox("El socios " & NOMBRE.Text & " esta libre ahora", Title:="PRESTAMOS")
                Else
                    MsgBox("No se encontraron los datos", Title:="PRESTAMOS")
                End If
                '////////////////////////////////

            Else

                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

            End If

        Catch ex As Exception

            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")

        End Try



    End Sub
    Dim errorcedula As Integer = 0

    Private Sub BotonParaBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParaBuscarCedula.Click

        'Se cambia el label solo cuando haya un valor en el textbox CEDULA


        If Cedula.Text = "" Then
            '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

            ExtCombo.Visible = False
            devoCOMBO.Visible = False
            PictureExtraccion.Visible = False
            PictureDevolucion.Visible = False
            Label5.Visible = False
            Label4.Visible = False
            CarritoDeRevistas.Items.Clear()
            ListboxOcultollllParaGuardarLasIdDeLasRevistasEnElCarritollll.Items.Clear()
            PanelDelCarrito.Left = -268
            MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
            '/////////////////////////////////////////////////////////////////////////////////////////////////////////
        Else


            Consulta = "select cedula from usuarios where cedula like '" & Cedula.Text & "'"
            consultar()

            If Tabla.Rows.Count = 0 Then ' VERFICAR SI ES NULO EL RESULTADO DE LA CONSULTA
                '//////////////////////Oculta los picturebox y la interfaz de las funciones///////////////////////////////

                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                PictureExtraccion.Visible = False
                PictureDevolucion.Visible = False
                Label5.Visible = False
                Label4.Visible = False
                CarritoDeRevistas.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLasRevistasEnElCarritollll.Items.Clear()
                PanelDelCarrito.Left = -268
                MsgBox("Cedula no valida, intente otra vez", Title:="ERROR EN PRESTAMOS")
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////
            Else



                Consulta = "select cedula , nombre , tipo from usuarios where cedula like '" & Cedula.Text & "'"
                consultar()
                Try
                    For Each row As DataRow In Tabla.Rows
                        NOMBRE.Text = row("nombre")
                        Label12.Text = row("tipo")
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                '/////////////////////////////////////////////////////////////////////////////////////////////
                '////////////////////////////////Muestra los picturebox y la interfaz de las funciones///////////////////////
                '/////////////////////////////////////////////////////////////////////////////////////////////

                Label5.Visible = True
                ExtCombo.Visible = False
                devoCOMBO.Visible = False
                PictureExtraccion.Visible = True
                PictureDevolucion.Visible = True
                Label5.Visible = True
                Label4.Visible = True
                CarritoDeRevistas.Items.Clear()
                ListboxOcultollllParaGuardarLasIdDeLasRevistasEnElCarritollll.Items.Clear()
                PanelDelCarrito.Left = -5

                If Label12.Text = 2 Then
                    ButtonLiberar.Visible = True
                ElseIf Label12.Text = 0 Then
                    ButtonMoroso.Visible = True
                End If
                '/////////////////////////////////////////////////////////////////////////////////////////////

            End If

        End If

    End Sub




    Private Sub PictureExtraccion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureExtraccion.MouseHover
        Label4.Text = "Extraccion"
    End Sub

    Private Sub PictureDevolucion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureDevolucion.MouseHover
        Label4.Text = "Devolucion"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Registroprestamos.Show()
    End Sub
End Class