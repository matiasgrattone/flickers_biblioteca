Public Class ConfiguraciònAdmin

    Private Sub ConfiguraciònAdmin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Socios 0
        'Funcionarios 1
        'Administrador 2



        Consulta = "select * from usuarios"
        consultar()
        For Each row As DataRow In Tabla.Rows

            Select Case row("tipo").ToString

                Case 1

                    TreeView1.Nodes(0).Nodes.Add(row("nombre"))

                Case 0

                    TreeView1.Nodes(1).Nodes.Add(row("nombre"))

            End Select

        Next

        TreeView1.ExpandAll()
        ComboBox3.SelectedIndex = 0



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ANIMACION = ComboBox3.SelectedItem
        If ComboBox3.SelectedItem = 1 Then
            MENU3.Timer_InicioLabel.Enabled = True
            MENU3.Timer_LibrosLabel.Enabled = True
            MENU3.Timer_NvegadorLabel.Enabled = True
            MENU3.Timer_PrestamosLabel.Enabled = True
            MENU3.Timer_UsuariosLabel.Enabled = True
            MENU3.Timer_RevistasLabel.Enabled = True
        Else
            MENU3.label_usuarios.Left = 72
            MENU3.label_libros.Left = 72
            MENU3.LabelInicio.Left = 72
            MENU3.LabelRevistas.Left = 72
            MENU3.label_prestamos.Left = 72
            MENU3.label_navegador.Left = 72

        End If
    End Sub
End Class