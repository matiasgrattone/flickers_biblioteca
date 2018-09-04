Public Class Inicio_UsuariosV2
    Dim seleccionado As Integer = 0
    Dim activo As Integer = 0
    Dim animacion As Integer = 0



    Private Sub Inicio_UsuariosV2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Consulta = "select * from usuarios"
        consultar()
        DataGridView1.DataSource = Tabla

        DatagridModulo = DataGridView1
        Datagrid_Align()




    End Sub

    Private Sub PlaceHolder1_TextChanged(sender As System.Object, e As System.EventArgs) Handles PlaceHolder1.TextChanged
        Consulta = "select * from usuarios where cedula like '" & PlaceHolder1.Text & "%' "
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




                    If Menu_Panel.Left < 940 Then
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
                                ComboBox1.Text = "Dia"
                            Else
                                ComboBox1.Items.Add(i)
                            End If
                        Next

                        ComboBox2.Text = "Mes"
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
                                ComboBox3.Text = "Año"
                            Else
                                ComboBox3.Items.Add(i)
                            End If
                        Next

                        activo = 1

                    Case 2

                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 650
                        Editar_Panel.Visible = True
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 631

                        For i As Integer = 0 To 31
                            If i = 0 Then
                                ComboBox4.Text = "Dia"
                            Else
                                ComboBox4.Items.Add(i)
                            End If
                        Next

                        ComboBox5.Text = "Mes"
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
                                ComboBox6.Text = "Año"
                            Else
                                ComboBox6.Items.Add(i)
                            End If
                        Next

                        activo = 1

                    Case 3

                        ComboClear()
                        Menu_Panel.Left = 940
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
                        Menu_Panel.Left = 940
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920

                        activo = 0

                    Case 2

                        ComboClear()

                        Menu_Panel.BackColor = Color.Silver
                        Menu_Panel.Left = 940
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920

                        activo = 0

                    Case 3

                        ComboClear()
                        Menu_Panel.Left = 940
                        Editar_Panel.Visible = False
                        Ingresar_Panel.Visible = False
                        DataGridView1.Width = 920
                        Menu_Panel.BackColor = Color.Silver
                        activo = 0

                End Select





        End Select
    End Sub

    Private Sub ComboClear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""

    End Sub
End Class