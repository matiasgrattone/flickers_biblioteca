Public Class Configuracion_ADMIN

    Private Sub Configuracion_ADMIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select nombre from usuarios where tipo = 0"
        consultar()
        DataGridView1.DataSource = Tabla

    End Sub
End Class