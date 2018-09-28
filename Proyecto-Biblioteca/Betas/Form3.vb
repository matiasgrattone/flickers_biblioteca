Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Consulta = "select nombre , mail from usuarios"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(1).Visible = False
        DatagridModulo = DataGridView1
        Datagrid_Align()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'PlaceHolder1.Text = 
    End Sub
End Class