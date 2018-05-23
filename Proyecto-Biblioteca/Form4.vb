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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        '////////////////////////////SE TOMA EL LIBRO MANDADO DEL TEXTBOX Y SE LO PASA A OCUPADO EN LA TABLA LIBROS///////////////////////  

        If Consulta = "update libro set (estado = ocupado) where cod_libros = '" & LIBROS.Text & "';" Then
            consultar()
        Else
            MsgBox("No se encontraron los datos")
        End If

    End Sub

    Private Sub LIBROS_TextChanged(sender As System.Object, e As System.EventArgs) Handles LIBROS.TextChanged

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

        ElseIf ComboBoxMORTAL.Text <> "Devolucion" Then
            devoCOMBO.Visible = False
        End If

    End Sub


    Private Sub VERLIBROSAGG_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VERLIBROSAGG.CellContentClick

        If Cedula.Text <> "" Then '////////////////////////////SI CEDULA.TEXT TIENE LA CEDULA PUESTA AHI SI SE PODRA AGREGAR LIBROS O REALIZAR OTRAS FUNCIONES  /////////////////////// 
            Dim I As Integer
            I = VERLIBROSAGG.CurrentRow.Index

            IDAGG.Items.Add(VERLIBROSAGG.Item(0, I).Value())
            LIBROSAGG.Items.Add(VERLIBROSAGG.Item(3, I).Value())
            EXTRACCIONAGG.Items.Add(Label4.Text)

        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("hh:mm:ss")

        Label4.Text = Date.Now.ToString("dd / MM / yy")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class