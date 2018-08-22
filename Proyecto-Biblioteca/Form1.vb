Public Class Form1
    Dim Datos As Object
    Dim ArchivoTexto As Object
    Dim Texto As String
    Dim ruta As String

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Texto = Texto + "" + vbCrLf
            Label1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Texto = TextBox1.Text
        Label1.Text = TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NombreDelArchivo As String
        NombreDelArchivo = InputBox("Ingrese el nombre del archivo", Title:="Notas")
        If NombreDelArchivo = "" Then
            MsgBox("Ingrese un nombre")
        Else
            If ruta = "" Then
                Datos = CreateObject("Scripting.FileSystemObject")
                ArchivoTexto = Datos.CreateTextFile("C:\Users\usuario\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\Resources\Notas guardadas\" & NombreDelArchivo & ".txt", True)
                ArchivoTexto.WriteLine(Texto)
                ArchivoTexto.close()
            Else
                Datos = CreateObject("Scripting.FileSystemObject")
                ArchivoTexto = Datos.CreateTextFile("" & ruta & "\" & NombreDelArchivo & ".txt", True)
                ArchivoTexto.WriteLine(Texto)
                ArchivoTexto.close()
            End If
            End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ruta = InputBox("Ingrese una ruta para guardar el archivo", Title:=1)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick

    End Sub
End Class