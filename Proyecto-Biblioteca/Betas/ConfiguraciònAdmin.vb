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

    End Sub

End Class