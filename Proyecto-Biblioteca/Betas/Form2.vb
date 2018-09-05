Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader("C:\Users\usuario\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\Importante.txt", System.Text.Encoding.[Default])
        Dim texto As String
        texto = sr.ReadToEnd()
        sr.Close()
        TextBox1.Text = texto

    End Sub

    Private Sub SurroundingSub()

    End Sub
End Class