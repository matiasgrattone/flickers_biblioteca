Public Class IngresoRevistas

    Private Sub IngresoRevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select titulo,anio,origen,descripcion from revistas"
        consultar()
        dgvrevistas.DataSource = Tabla
        DatagridModulo = dgvrevistas
        Datagrid_Align()
        dgvrevistas.Columns(0).HeaderText = "Titulo"
        dgvrevistas.Columns(1).HeaderText = "Año"
        dgvrevistas.Columns(2).HeaderText = "Pais de Origen"
        dgvrevistas.Columns(3).HeaderText = "Descripcion"

    End Sub

    Private Sub btningresarrevista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarrevista.Click
        Consulta = "insert into revistas(titulo,anio,origen,descripcion) values ('" & txttitulo.Text & "', '" & txtanior.Text & "','" + txtorigenr.Text + "','" + txtdescripcion.Text + "')"
        consultar()


        Consulta = "select titulo,anio,origen,descripcion from revistas"
        consultar()
        dgvrevistas.DataSource = Tabla
        DatagridModulo = dgvrevistas
        Datagrid_Align()
    End Sub
End Class