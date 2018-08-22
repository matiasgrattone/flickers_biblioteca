Public Class NOTAS
    Dim Datos As Object
    Dim ArchivoTexto As Object
    Dim Texto As String = TextBox1.Text

    Private Sub Button1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress
        Texto = Texto.ToString + "" + vbCrLf

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NombreDelArchivo As Integer
        NombreDelArchivo = InputBox("Ingrese el nombre del archivo", Title:="Notas")
        Datos = CreateObject("Scripting.FileSystemObject")
        ArchivoTexto = Datos.CreateTextFile("C:\Users\usuario\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\Resources\Notas guardadas\" & NombreDelArchivo & ".txt", True)
        ArchivoTexto.WriteLine(Texto)
        ArchivoTexto.close()

    End Sub

End Class