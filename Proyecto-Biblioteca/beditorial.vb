Public Class beditorial

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ingresolibro.casa_editorial.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        ingresolibro.TextBox2.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anioe.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consulta = "INSERT INTO editorial (nombre, pais , anio) values ('" + nombree.Text + "', '" + pais.Text + "','" + anioe.Text + "')"
        consultar()
        Consulta = "SELECT * FROM editorial"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub
End Class