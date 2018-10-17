Public Class FichaSocio

    Public FichaCedulaSocio As String 'cedula para cargar los datos en el formulario
    Dim a As Integer = 0 've si el mouse esta en click
    Public xco, yco As Integer 'nueva ubicacion del cursor
    Dim xc, yc As Integer 'primer ubicacion del cursor
    Dim xf, yf As Integer 'primer ubicacion del formulario
    Dim holax, holay As Integer 'calculo para la ubicacion del formulario
    Public cedulaSocio As String 'Variable para consulta de libro favorito

    Dim primerinicio As Integer = 0

    Public registro_de_libros As DataTable
    Public registro_de_prestamos As DataTable

    Public librofavorito As String
    Public morosoultimavez As String
    Public cedulatext As String
    Public tipo As String
    Public telefono As String
    Public direccion As String
    Public nombrecompleto As String
    Public fechaingreso As String
    Public mailtext As String



    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = 1950 To Date.Now.ToString("yyyy")
            If i = 1950 Then
                cmbaño.Items.Add("Año")
            Else
                cmbaño.Items.Add(i)
            End If
            cmbaño.SelectedItem = i
        Next

        cmbmes.Items.Add("Mes")
        cmbmes.Items.Add("Enero")
        cmbmes.Items.Add("Febrero")
        cmbmes.Items.Add("Marzo")
        cmbmes.Items.Add("Abril")
        cmbmes.Items.Add("Mayo")
        cmbmes.Items.Add("Junio")
        cmbmes.Items.Add("Julio")
        cmbmes.Items.Add("Agosto")
        cmbmes.Items.Add("Septiembre")
        cmbmes.Items.Add("Octubre")
        cmbmes.Items.Add("Noviembre")
        cmbmes.Items.Add("Diciembre")
        substring = Date.Now.ToString("MM")
        mes()
        cmbmes.SelectedItem = substring


    End Sub

    Private Sub RegistroSocio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        xf = Me.Location.X 'coordenadas X de la ventana
        yf = Me.Location.Y 'coordenadas Y de la ventana

        Consulta_dataset = "select rutaperfil from usuarios where cedula ='" + FichaCedulaSocio + "' ; select prestamolibro.cod_libro , libro.titulo from prestamolibro inner join libro on prestamolibro.cod_libro = libro.cod_libro where cedula = '" & FichaCedulaSocio & "' and fecha_entrada is NULL;SELECT concat(usuarios1.nombre,' ',usuarios1.apellido) as 'Nombre Socio', `cod_libro`, fecha_salida as 'Fecha Prestamo', `fecha_entrada`, concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaCedulaSocio & "';select p.cod_libro, cedula, l.titulo, count(*) as 'total' from prestamolibro p inner join libro l on p.cod_libro=l.cod_libro where cedula = '" + FichaCedulaSocio + "' group by 1 order by total desc limit 1 ; select * from usuarios where cedula = '" & FichaCedulaSocio & "'"
        consultar_DataSet()
        'Primer Consulta
        For Each row As DataRow In Tabla_dataset.Tables(Tabla_dataset.Tables.Count - 1).Rows
            PictureBox1.ImageLocation = Convert.ToString(row("rutaperfil"))
        Next
        'Segunda Consulta
        registro_de_libros = Tabla_dataset.Tables(1)
        'Tercer Consulta
        registro_de_prestamos = Tabla_dataset.Tables(2)
        'Cuarta Consulta
        For Each row As DataRow In Tabla_dataset.Tables(3).Rows
            librofavorito = Convert.ToString(row("titulo"))
        Next
        'Quinta Consulta
        For Each row As DataRow In Tabla_dataset.Tables(4).Rows
            cedulatext = row("cedula").ToString.Substring(0, 1) & "." & row("cedula").ToString.Substring(1, 3) & "." & row("cedula").ToString.Substring(4, 3) & "-" & row("cedula").ToString.Substring(7, 1)
            Select Case row("tipo")
                Case 0
                    tipo = "Administrador"
                Case 1
                    tipo = "Funcionario"
                Case 2
                    tipo = "Socio"
            End Select
            cedulaSocio = Str(row("cedula"))
            telefono = row("telefono")
            direccion = row("direccion")
            nombrecompleto = row("nombre") & " " & row("apellido")
            fechaingreso = row("fecha_Ingreso")
            If row("mail") Is DBNull.Value Then
            Else
                mailtext = row("mail")
            End If
            If row("fecha_moroso") Is DBNull.Value Then
            Else
                morosoultimavez = row("fecha_moroso")
            End If
            If row("moroso") = 0 Then
                PictureBoxEstado.Image = Image.FromFile("imagenes\checked.png")
            Else
                PictureBoxEstado.Image = Image.FromFile("imagenes\delete.png")
            End If
        Next
        BackgroundWorker1.RunWorkerAsync()
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Consulta = "select prestamolibro.cod_libro , libro.titulo from prestamolibro inner join libro on prestamolibro.cod_libro = libro.cod_libro where cedula = '" & FichaCedulaSocio & "' and fecha_entrada is NULL"
        consultar()
        DataGridViewLibros.DataSource = Tabla
    End Sub
    Private Sub Panel4_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown
        a = 1
    End Sub
    Private Sub Panel4_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove
        If a = 1 Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
            Me.Opacity = 0.9
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
        End If
    End Sub
    Private Sub Panel4_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBox3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        FichaParaImprimir2.Show()
        FichaParaImprimir2.Hide()
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Mail.Txt_Destino.Text = LabelMailtxt.Text
        Mail.Show()
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbmes.SelectedIndexChanged
        If primerinicio = 4 Then
            substring = cmbmes.SelectedItem
            mestonum()
            Consulta = "SELECT concat(usuarios1.nombre,' ',usuarios1.apellido) as 'Nombre Socio', `cod_libro`, fecha_salida as 'Fecha Prestamo', `fecha_entrada`, concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaCedulaSocio & "' and year(fecha_salida) = '" & cmbaño.SelectedItem & "' and month(fecha_salida) = '" & substring & "'"
            consultar()
            DataGridView1.DataSource = Tabla
        End If
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbaño.SelectedIndexChanged
        If primerinicio = 4 Then
            substring = cmbmes.SelectedItem
            mestonum()
            Consulta = "SELECT concat(usuarios1.nombre,' ',usuarios1.apellido) as 'Nombre Socio', `cod_libro`, fecha_salida as 'Fecha Prestamo', `fecha_entrada`, concat(usuarios2.nombre,' ',usuarios2.apellido) as 'Funcionario Prestamo', concat(usuarios3.nombre,' ',usuarios3.apellido) as 'Funcionario Devolucion' FROM prestamolibro as prestamolibro1 inner join usuarios as usuarios1 on usuarios1.cedula = prestamolibro1.cedula inner join usuarios as usuarios2 on usuarios2.cedula = prestamolibro1.cod_prestado inner join usuarios as usuarios3 on usuarios3.cedula = prestamolibro1.cod_devuelto WHERE usuarios1.cedula = '" & FichaCedulaSocio & "' and year(fecha_salida) = '" & cmbaño.SelectedItem & "' and month(fecha_salida) = '" & substring & "'"
            consultar()
            DataGridView1.DataSource = Tabla
        End If
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If primerinicio = 0 Then
            LabelCedulatxt.Text = cedulatext
            LabelNombretxt.Text = nombrecompleto
            LabelDirecciontxt.Text = direccion
            Label_TIPO_txt.Text = tipo
            LabelMailtxt.Text = mailtext
            Label_Telefono_txt.Text = telefono
            LabelFechaUltimaVez.Text = morosoultimavez
            LabelFecha_Ingreso.Text = fechaingreso
            labelLibroFavorito.Text = librofavorito
            DataGridViewLibros.DataSource = registro_de_libros
            DataGridView1.DataSource = registro_de_prestamos

            DatagridModulo = DataGridViewLibros
            Datagrid_Align()
            DataGridViewLibros.Columns(0).HeaderText = "Nº de inventario"


            DatagridModulo = DataGridView1
            Datagrid_Align()
            DataGridView1.Columns(1).HeaderText = "Libro"
            DataGridView1.Columns(3).HeaderText = "Fecha Devoluciòn"
            DataGridView1.Columns(5).HeaderText = "Funcionario Devoluciòn"


            Timer2.Enabled = False
            Timer2.Stop()
        End If
    End Sub
End Class