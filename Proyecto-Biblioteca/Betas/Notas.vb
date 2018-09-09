Public Class Notas

    Private Sub Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Ubicacion As System.IO.StreamReader = New System.IO.StreamReader("C:\Users\usuario\Documents\GitHub\flickers_biblioteca\Proyecto-Biblioteca\Importante.txt", System.Text.Encoding.[Default])
        Dim Texto As String
        Texto = Ubicacion.ReadToEnd()
        Ubicacion.Close()
        TextBox1.Text = Texto

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        EditorDeTexto.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim AbrirArchivo As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        AbrirArchivo.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
        AbrirArchivo.CheckFileExists = True
        AbrirArchivo.Title = "Abrir Archivo"
        AbrirArchivo.ShowDialog(Me)
        Try
            AbrirArchivo.OpenFile()
            myStreamReader = System.IO.File.OpenText(AbrirArchivo.FileName)
            EditorDeTexto.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim GuardarArchivo As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        GuardarArchivo.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        GuardarArchivo.CheckPathExists = True
        GuardarArchivo.Title = "Guardar como"
        GuardarArchivo.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(GuardarArchivo.FileName)
            myStreamWriter.Write(EditorDeTexto.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        EditorDeTexto.Undo()
    End Sub

    Private Sub AdelanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdelanteToolStripMenuItem.Click

    End Sub

    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        EditorDeTexto.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        EditorDeTexto.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        EditorDeTexto.Paste()
    End Sub

    Private Sub SeleccionarTodoElTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarTodoElTextoToolStripMenuItem.Click
        EditorDeTexto.SelectAll()
    End Sub

    Private Sub LimpiarTodoElTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarTodoElTextoToolStripMenuItem.Click
        EditorDeTexto.Clear()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim ParaCambiarLaFuente As FontDialog = New FontDialog
            ParaCambiarLaFuente.Font = EditorDeTexto.Font
            If ParaCambiarLaFuente.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                EditorDeTexto.Font = ParaCambiarLaFuente.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Try
            Dim ParaCambiarElColor As ColorDialog = New ColorDialog
            ParaCambiarElColor.Color = EditorDeTexto.ForeColor

            If ParaCambiarElColor.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                EditorDeTexto.ForeColor = ParaCambiarElColor.Color

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RECORDATORIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECORDATORIOS.Click

    End Sub
End Class