<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarlibro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buscarlibro))
        Me.dgvdatos2 = New System.Windows.Forms.DataGridView()
        Me.cmbdatos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvlibros = New System.Windows.Forms.DataGridView()
        Me.Pmostrar = New System.Windows.Forms.Panel()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.volumen_label = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.titulo_label = New System.Windows.Forms.Label()
        Me.cod_libro_label = New System.Windows.Forms.Label()
        Me.autor_label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.editorial_label = New System.Windows.Forms.Label()
        Me.estado_label = New System.Windows.Forms.Label()
        Me.fecha_label = New System.Windows.Forms.Label()
        Me.observaciones_label = New System.Windows.Forms.Label()
        Me.origen_label = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Pactualizar = New System.Windows.Forms.Panel()
        Me.cmbupdate = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.observaciones_txt = New System.Windows.Forms.TextBox()
        Me.origen_txt = New System.Windows.Forms.TextBox()
        Me.anio_txt = New System.Windows.Forms.TextBox()
        Me.editorial_txt = New System.Windows.Forms.TextBox()
        Me.volumen_txt = New System.Windows.Forms.TextBox()
        Me.titulo_txt = New System.Windows.Forms.TextBox()
        Me.cod_libro_txt = New System.Windows.Forms.TextBox()
        Me.autor_txt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Poculto = New System.Windows.Forms.Panel()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.txtbusqueda = New Proyecto_Biblioteca.PlaceHolder()
        CType(Me.dgvdatos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pmostrar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pactualizar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdatos2
        '
        Me.dgvdatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos2.Location = New System.Drawing.Point(13, 6)
        Me.dgvdatos2.Name = "dgvdatos2"
        Me.dgvdatos2.Size = New System.Drawing.Size(129, 28)
        Me.dgvdatos2.TabIndex = 32
        '
        'cmbdatos
        '
        Me.cmbdatos.BackColor = System.Drawing.Color.LimeGreen
        Me.cmbdatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdatos.ForeColor = System.Drawing.Color.Black
        Me.cmbdatos.FormattingEnabled = True
        Me.cmbdatos.Items.AddRange(New Object() {"Codigo", "Autor", "Titulo", "Editorial", "Año", "Origen"})
        Me.cmbdatos.Location = New System.Drawing.Point(276, 88)
        Me.cmbdatos.Name = "cmbdatos"
        Me.cmbdatos.Size = New System.Drawing.Size(172, 28)
        Me.cmbdatos.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Buscar un libro"
        '
        'dgvlibros
        '
        Me.dgvlibros.AllowUserToAddRows = False
        Me.dgvlibros.AllowUserToDeleteRows = False
        Me.dgvlibros.AllowUserToResizeColumns = False
        Me.dgvlibros.AllowUserToResizeRows = False
        Me.dgvlibros.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvlibros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlibros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvlibros.Location = New System.Drawing.Point(12, 123)
        Me.dgvlibros.Name = "dgvlibros"
        Me.dgvlibros.ReadOnly = True
        Me.dgvlibros.RowHeadersVisible = False
        Me.dgvlibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlibros.Size = New System.Drawing.Size(614, 461)
        Me.dgvlibros.TabIndex = 25
        '
        'Pmostrar
        '
        Me.Pmostrar.BackColor = System.Drawing.Color.LimeGreen
        Me.Pmostrar.Controls.Add(Me.btnmodificar)
        Me.Pmostrar.Controls.Add(Me.PictureBox1)
        Me.Pmostrar.Controls.Add(Me.volumen_label)
        Me.Pmostrar.Controls.Add(Me.Label8)
        Me.Pmostrar.Controls.Add(Me.titulo_label)
        Me.Pmostrar.Controls.Add(Me.cod_libro_label)
        Me.Pmostrar.Controls.Add(Me.autor_label)
        Me.Pmostrar.Controls.Add(Me.Label5)
        Me.Pmostrar.Controls.Add(Me.Label14)
        Me.Pmostrar.Controls.Add(Me.Label6)
        Me.Pmostrar.Controls.Add(Me.Label13)
        Me.Pmostrar.Controls.Add(Me.Label7)
        Me.Pmostrar.Controls.Add(Me.Label9)
        Me.Pmostrar.Controls.Add(Me.Label17)
        Me.Pmostrar.Controls.Add(Me.Label11)
        Me.Pmostrar.Controls.Add(Me.editorial_label)
        Me.Pmostrar.Controls.Add(Me.estado_label)
        Me.Pmostrar.Controls.Add(Me.fecha_label)
        Me.Pmostrar.Controls.Add(Me.observaciones_label)
        Me.Pmostrar.Controls.Add(Me.origen_label)
        Me.Pmostrar.Location = New System.Drawing.Point(636, 91)
        Me.Pmostrar.Name = "Pmostrar"
        Me.Pmostrar.Size = New System.Drawing.Size(290, 464)
        Me.Pmostrar.TabIndex = 31
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(91, 422)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(118, 25)
        Me.btnmodificar.TabIndex = 24
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'volumen_label
        '
        Me.volumen_label.AutoSize = True
        Me.volumen_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumen_label.Location = New System.Drawing.Point(143, 226)
        Me.volumen_label.Name = "volumen_label"
        Me.volumen_label.Size = New System.Drawing.Size(74, 17)
        Me.volumen_label.TabIndex = 23
        Me.volumen_label.Text = "Volumen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Volumen:"
        '
        'titulo_label
        '
        Me.titulo_label.AutoSize = True
        Me.titulo_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_label.Location = New System.Drawing.Point(143, 192)
        Me.titulo_label.Name = "titulo_label"
        Me.titulo_label.Size = New System.Drawing.Size(51, 17)
        Me.titulo_label.TabIndex = 22
        Me.titulo_label.Text = "Titulo"
        '
        'cod_libro_label
        '
        Me.cod_libro_label.AutoSize = True
        Me.cod_libro_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_libro_label.Location = New System.Drawing.Point(143, 135)
        Me.cod_libro_label.Name = "cod_libro_label"
        Me.cod_libro_label.Size = New System.Drawing.Size(61, 17)
        Me.cod_libro_label.TabIndex = 11
        Me.cod_libro_label.Text = "Codigo"
        '
        'autor_label
        '
        Me.autor_label.AutoSize = True
        Me.autor_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autor_label.Location = New System.Drawing.Point(143, 162)
        Me.autor_label.Name = "autor_label"
        Me.autor_label.Size = New System.Drawing.Size(48, 17)
        Me.autor_label.TabIndex = 21
        Me.autor_label.Text = "Autor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Codigo de libro:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(75, 394)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Autor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Observaciones:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Titulo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Casa Editorial:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(75, 332)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 17)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Origen:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(95, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Año:"
        '
        'editorial_label
        '
        Me.editorial_label.AutoSize = True
        Me.editorial_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorial_label.Location = New System.Drawing.Point(143, 262)
        Me.editorial_label.Name = "editorial_label"
        Me.editorial_label.Size = New System.Drawing.Size(68, 17)
        Me.editorial_label.TabIndex = 9
        Me.editorial_label.Text = "Editorial"
        '
        'estado_label
        '
        Me.estado_label.AutoSize = True
        Me.estado_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado_label.Location = New System.Drawing.Point(146, 394)
        Me.estado_label.Name = "estado_label"
        Me.estado_label.Size = New System.Drawing.Size(55, 17)
        Me.estado_label.TabIndex = 19
        Me.estado_label.Text = "Estado"
        '
        'fecha_label
        '
        Me.fecha_label.AutoSize = True
        Me.fecha_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_label.Location = New System.Drawing.Point(144, 299)
        Me.fecha_label.Name = "fecha_label"
        Me.fecha_label.Size = New System.Drawing.Size(51, 17)
        Me.fecha_label.TabIndex = 8
        Me.fecha_label.Text = "Fecha"
        '
        'observaciones_label
        '
        Me.observaciones_label.AutoSize = True
        Me.observaciones_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observaciones_label.Location = New System.Drawing.Point(144, 364)
        Me.observaciones_label.Name = "observaciones_label"
        Me.observaciones_label.Size = New System.Drawing.Size(115, 17)
        Me.observaciones_label.TabIndex = 18
        Me.observaciones_label.Text = "Observaciones"
        '
        'origen_label
        '
        Me.origen_label.AutoSize = True
        Me.origen_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen_label.Location = New System.Drawing.Point(144, 332)
        Me.origen_label.Name = "origen_label"
        Me.origen_label.Size = New System.Drawing.Size(57, 17)
        Me.origen_label.TabIndex = 14
        Me.origen_label.Text = "Origen"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(66, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Origen:"
        '
        'Pactualizar
        '
        Me.Pactualizar.BackColor = System.Drawing.Color.LimeGreen
        Me.Pactualizar.Controls.Add(Me.cmbupdate)
        Me.Pactualizar.Controls.Add(Me.btnback)
        Me.Pactualizar.Controls.Add(Me.btnupdate)
        Me.Pactualizar.Controls.Add(Me.observaciones_txt)
        Me.Pactualizar.Controls.Add(Me.origen_txt)
        Me.Pactualizar.Controls.Add(Me.anio_txt)
        Me.Pactualizar.Controls.Add(Me.editorial_txt)
        Me.Pactualizar.Controls.Add(Me.volumen_txt)
        Me.Pactualizar.Controls.Add(Me.titulo_txt)
        Me.Pactualizar.Controls.Add(Me.cod_libro_txt)
        Me.Pactualizar.Controls.Add(Me.autor_txt)
        Me.Pactualizar.Controls.Add(Me.Label15)
        Me.Pactualizar.Controls.Add(Me.Label16)
        Me.Pactualizar.Controls.Add(Me.Label12)
        Me.Pactualizar.Controls.Add(Me.Label18)
        Me.Pactualizar.Controls.Add(Me.Label24)
        Me.Pactualizar.Controls.Add(Me.Label25)
        Me.Pactualizar.Controls.Add(Me.Label26)
        Me.Pactualizar.Controls.Add(Me.Label27)
        Me.Pactualizar.Controls.Add(Me.Label28)
        Me.Pactualizar.Controls.Add(Me.PictureBox2)
        Me.Pactualizar.Location = New System.Drawing.Point(636, 91)
        Me.Pactualizar.Name = "Pactualizar"
        Me.Pactualizar.Size = New System.Drawing.Size(290, 464)
        Me.Pactualizar.TabIndex = 34
        '
        'cmbupdate
        '
        Me.cmbupdate.FormattingEnabled = True
        Me.cmbupdate.Items.AddRange(New Object() {"disponible", "ocupado", "reservado", "descontinuado"})
        Me.cmbupdate.Location = New System.Drawing.Point(137, 390)
        Me.cmbupdate.Name = "cmbupdate"
        Me.cmbupdate.Size = New System.Drawing.Size(136, 21)
        Me.cmbupdate.TabIndex = 24
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(151, 421)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 26)
        Me.btnback.TabIndex = 23
        Me.btnback.Text = "Volver"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(26, 421)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(119, 26)
        Me.btnupdate.TabIndex = 22
        Me.btnupdate.Text = "Actualizar"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'observaciones_txt
        '
        Me.observaciones_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.observaciones_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observaciones_txt.Location = New System.Drawing.Point(137, 362)
        Me.observaciones_txt.Name = "observaciones_txt"
        Me.observaciones_txt.Size = New System.Drawing.Size(136, 18)
        Me.observaciones_txt.TabIndex = 21
        '
        'origen_txt
        '
        Me.origen_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.origen_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen_txt.Location = New System.Drawing.Point(137, 330)
        Me.origen_txt.Name = "origen_txt"
        Me.origen_txt.Size = New System.Drawing.Size(136, 18)
        Me.origen_txt.TabIndex = 21
        '
        'anio_txt
        '
        Me.anio_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.anio_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anio_txt.Location = New System.Drawing.Point(137, 297)
        Me.anio_txt.Name = "anio_txt"
        Me.anio_txt.Size = New System.Drawing.Size(136, 18)
        Me.anio_txt.TabIndex = 21
        '
        'editorial_txt
        '
        Me.editorial_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editorial_txt.Enabled = False
        Me.editorial_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorial_txt.Location = New System.Drawing.Point(137, 260)
        Me.editorial_txt.Name = "editorial_txt"
        Me.editorial_txt.ReadOnly = True
        Me.editorial_txt.Size = New System.Drawing.Size(136, 18)
        Me.editorial_txt.TabIndex = 21
        '
        'volumen_txt
        '
        Me.volumen_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.volumen_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumen_txt.Location = New System.Drawing.Point(137, 224)
        Me.volumen_txt.Name = "volumen_txt"
        Me.volumen_txt.Size = New System.Drawing.Size(136, 18)
        Me.volumen_txt.TabIndex = 21
        '
        'titulo_txt
        '
        Me.titulo_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.titulo_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_txt.Location = New System.Drawing.Point(137, 191)
        Me.titulo_txt.Name = "titulo_txt"
        Me.titulo_txt.Size = New System.Drawing.Size(136, 18)
        Me.titulo_txt.TabIndex = 21
        '
        'cod_libro_txt
        '
        Me.cod_libro_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cod_libro_txt.Enabled = False
        Me.cod_libro_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_libro_txt.Location = New System.Drawing.Point(137, 135)
        Me.cod_libro_txt.Name = "cod_libro_txt"
        Me.cod_libro_txt.ReadOnly = True
        Me.cod_libro_txt.Size = New System.Drawing.Size(136, 18)
        Me.cod_libro_txt.TabIndex = 21
        '
        'autor_txt
        '
        Me.autor_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.autor_txt.Enabled = False
        Me.autor_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autor_txt.Location = New System.Drawing.Point(137, 161)
        Me.autor_txt.Name = "autor_txt"
        Me.autor_txt.ReadOnly = True
        Me.autor_txt.Size = New System.Drawing.Size(136, 18)
        Me.autor_txt.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 397)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Estado:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 362)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Observaciones:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(88, 298)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Año:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(23, 260)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 17)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Casa Editorial:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(55, 224)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 17)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Volumen:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(81, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 17)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Titulo:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(84, 160)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 17)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Autor:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 134)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(127, 17)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "Codigo de libro:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(84, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Poculto
        '
        Me.Poculto.Location = New System.Drawing.Point(12, 6)
        Me.Poculto.Name = "Poculto"
        Me.Poculto.Size = New System.Drawing.Size(149, 28)
        Me.Poculto.TabIndex = 33
        '
        'cmbestado
        '
        Me.cmbestado.BackColor = System.Drawing.Color.LimeGreen
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestado.ForeColor = System.Drawing.Color.Black
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"disponible", "ocupado", "reservado", "descontinuado"})
        Me.cmbestado.Location = New System.Drawing.Point(454, 88)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(172, 28)
        Me.cmbestado.TabIndex = 30
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(13, 87)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(257, 30)
        Me.txtbusqueda.TabIndex = 48
        Me.txtbusqueda.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtbusqueda.WaterMarkText = "Buscar"
        '
        'buscarlibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(935, 612)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Poculto)
        Me.Controls.Add(Me.dgvdatos2)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.cmbdatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvlibros)
        Me.Controls.Add(Me.Pactualizar)
        Me.Controls.Add(Me.Pmostrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "buscarlibro"
        Me.Text = "Form2"
        CType(Me.dgvdatos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pmostrar.ResumeLayout(False)
        Me.Pmostrar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pactualizar.ResumeLayout(False)
        Me.Pactualizar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdatos2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvlibros As System.Windows.Forms.DataGridView
    Friend WithEvents Pmostrar As System.Windows.Forms.Panel
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents volumen_label As System.Windows.Forms.Label
    Friend WithEvents titulo_label As System.Windows.Forms.Label
    Friend WithEvents autor_label As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents estado_label As System.Windows.Forms.Label
    Friend WithEvents observaciones_label As System.Windows.Forms.Label
    Friend WithEvents origen_label As System.Windows.Forms.Label
    Friend WithEvents fecha_label As System.Windows.Forms.Label
    Friend WithEvents editorial_label As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cod_libro_label As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pactualizar As System.Windows.Forms.Panel
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents observaciones_txt As System.Windows.Forms.TextBox
    Friend WithEvents origen_txt As System.Windows.Forms.TextBox
    Friend WithEvents anio_txt As System.Windows.Forms.TextBox
    Friend WithEvents editorial_txt As System.Windows.Forms.TextBox
    Friend WithEvents volumen_txt As System.Windows.Forms.TextBox
    Friend WithEvents titulo_txt As System.Windows.Forms.TextBox
    Friend WithEvents autor_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cod_libro_txt As System.Windows.Forms.TextBox
    Friend WithEvents Poculto As System.Windows.Forms.Panel
    Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
    Private WithEvents cmbdatos As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents cmbupdate As System.Windows.Forms.ComboBox
    Friend WithEvents txtbusqueda As Proyecto_Biblioteca.PlaceHolder
End Class
