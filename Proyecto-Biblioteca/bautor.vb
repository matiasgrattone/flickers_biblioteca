Public Class bautor

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'ingresolibro.autor.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        'ingresolibro.TextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        'Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Consulta = "INSERT INTO autor (nombre, nacionalidad) values ('" + nombrea.Text + "', '" + nacionalidad.Text + "')"
            consultar()
            Consulta = "SELECT * FROM autor"
            consultar()
            DataGridView1.DataSource = Tabla


        Catch ex As Exception

        End Try

    End Sub

    Private Sub bautor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class