Public Class LOGIN

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        inicio_usuarios.Label1.Text = TextBox1.Text
        Me.Hide()
        inicio_usuarios.Show()
    End Sub
End Class