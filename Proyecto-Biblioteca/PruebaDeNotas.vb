Public Class NOTAS
    'Dim Datos As Object
    'Dim ArchivoTexto As Object
    'Dim Texto As String = Nota.Text

    'Private Sub Button1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress
    'Texto = Texto.ToString + "" + vbCrLf

    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'Dim NombreDelArchivo As Integer
    'NombreDelArchivo = InputBox("Ingrese el nombre del archivo", Title:="Notas")
    'Datos = CreateObject("Scripting.FileSystemObject")
    'ArchivoTexto = Datos.CreateTextFile("C:\Users\usuario\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\Resources\Notas guardadas\" & NombreDelArchivo & ".txt", True)
    'ArchivoTexto.WriteLine(Texto)
    'ArchivoTexto.close()

    'End Sub


    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nota.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem1.Click
        Dim AbrirNotaGuardada As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        AbrirNotaGuardada.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
        AbrirNotaGuardada.CheckFileExists = True
        AbrirNotaGuardada.Title = "Abrir Archivo"
        AbrirNotaGuardada.ShowDialog(Me)
        Try
            AbrirNotaGuardada.OpenFile()
            myStreamReader = System.IO.File.OpenText(AbrirNotaGuardada.FileName)
            Nota.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem1.Click
        Dim GuardarNota As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        GuardarNota.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        GuardarNota.CheckPathExists = True
        GuardarNota.Title = "Guardar como"
        GuardarNota.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(GuardarNota.FileName)
            myStreamWriter.Write(Nota.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Nota.Undo()
    End Sub

    Private Sub AdelantarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdelantarToolStripMenuItem.Click
        Nota.Redo()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        Nota.Cut()

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        Nota.Copy()

    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        Nota.Paste()

    End Sub

    Private Sub SeleccionarTodoElTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarTodoElTextoToolStripMenuItem.Click
        Nota.SelectAll()

    End Sub

    Private Sub LimpiarTodoElTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarTodoElTextoToolStripMenuItem.Click
        Nota.Clear()

    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim Letras As FontDialog = New FontDialog
            Letras.Font = Nota.Font

            If Letras.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Nota.Font = Letras.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Try
            Dim ColorDeLetras As ColorDialog = New ColorDialog
            ColorDeLetras.Color = Nota.ForeColor
            If ColorDeLetras.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Nota.ForeColor = ColorDeLetras.Color
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class