Public Class beditorial

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ingresolibro.casa_editorial.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        ingresolibro.TextBox2.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Me.Close()
    End Sub
End Class