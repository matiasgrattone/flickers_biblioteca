Public Class Menu2_1

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Menu2_1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.1
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        inicio_usuarios.Show()
    End Sub
End Class