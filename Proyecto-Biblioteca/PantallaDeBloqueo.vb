Public Class PantallaDeBloqueo

    Private Sub PantallaDeBloqueo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Consulta = "select * from usuarios"
        consultar()
        For Each row As DataRow In Tabla.Rows
            MsgBox(row("nombre"))
        Next
    End Sub
End Class