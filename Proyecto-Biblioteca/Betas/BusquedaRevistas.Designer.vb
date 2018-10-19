<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaRevistas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaRevistas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pactualizar = New System.Windows.Forms.Panel()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.desc_txt = New System.Windows.Forms.TextBox()
        Me.cmbupdate = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.origen_txt = New System.Windows.Forms.TextBox()
        Me.anio_txt = New System.Windows.Forms.TextBox()
        Me.titulo_txt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.cmbdatos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblorigenmostrar = New System.Windows.Forms.Label()
        Me.aniolabel = New System.Windows.Forms.Label()
        Me.origenlabel = New System.Windows.Forms.Label()
        Me.titulolabel = New System.Windows.Forms.Label()
        Me.estadolabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Pmostrar = New System.Windows.Forms.Panel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.labelid = New System.Windows.Forms.Label()
        Me.estado_label = New System.Windows.Forms.Label()
        Me.txtdescmostrar = New System.Windows.Forms.TextBox()
        Me.lblaniomostrar = New System.Windows.Forms.Label()
        Me.lbltitulomostrar = New System.Windows.Forms.Label()
        Me.desclabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvcomprobar = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvrevistas = New System.Windows.Forms.DataGridView()
        Me.txtbusqueda = New Proyecto_Biblioteca.PlaceHolder()
        Me.Pactualizar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pmostrar.SuspendLayout()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pactualizar
        '
        Me.Pactualizar.BackColor = System.Drawing.Color.DarkViolet
        Me.Pactualizar.Controls.Add(Me.id_txt)
        Me.Pactualizar.Controls.Add(Me.Label1)
        Me.Pactualizar.Controls.Add(Me.lbldesc)
        Me.Pactualizar.Controls.Add(Me.desc_txt)
        Me.Pactualizar.Controls.Add(Me.cmbupdate)
        Me.Pactualizar.Controls.Add(Me.btnback)
        Me.Pactualizar.Controls.Add(Me.btnupdate)
        Me.Pactualizar.Controls.Add(Me.origen_txt)
        Me.Pactualizar.Controls.Add(Me.anio_txt)
        Me.Pactualizar.Controls.Add(Me.titulo_txt)
        Me.Pactualizar.Controls.Add(Me.Label15)
        Me.Pactualizar.Controls.Add(Me.Label12)
        Me.Pactualizar.Controls.Add(Me.Label18)
        Me.Pactualizar.Controls.Add(Me.Label26)
        Me.Pactualizar.Controls.Add(Me.PictureBox2)
        Me.Pactualizar.Location = New System.Drawing.Point(632, 100)
        Me.Pactualizar.Name = "Pactualizar"
        Me.Pactualizar.Size = New System.Drawing.Size(275, 461)
        Me.Pactualizar.TabIndex = 35
        '
        'id_txt
        '
        Me.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_txt.Enabled = False
        Me.id_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_txt.Location = New System.Drawing.Point(84, 116)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(160, 17)
        Me.id_txt.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ID: "
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(3, 281)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(91, 18)
        Me.lbldesc.TabIndex = 26
        Me.lbldesc.Text = "Descripcion:"
        '
        'desc_txt
        '
        Me.desc_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_txt.Location = New System.Drawing.Point(102, 281)
        Me.desc_txt.Multiline = True
        Me.desc_txt.Name = "desc_txt"
        Me.desc_txt.Size = New System.Drawing.Size(160, 86)
        Me.desc_txt.TabIndex = 25
        '
        'cmbupdate
        '
        Me.cmbupdate.FormattingEnabled = True
        Me.cmbupdate.Items.AddRange(New Object() {"Disponible", "Ocupado", "Reservado", "Discontinuado"})
        Me.cmbupdate.Location = New System.Drawing.Point(87, 377)
        Me.cmbupdate.Name = "cmbupdate"
        Me.cmbupdate.Size = New System.Drawing.Size(158, 21)
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
        'origen_txt
        '
        Me.origen_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.origen_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen_txt.Location = New System.Drawing.Point(84, 239)
        Me.origen_txt.Name = "origen_txt"
        Me.origen_txt.Size = New System.Drawing.Size(160, 17)
        Me.origen_txt.TabIndex = 21
        '
        'anio_txt
        '
        Me.anio_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.anio_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anio_txt.Location = New System.Drawing.Point(84, 196)
        Me.anio_txt.Name = "anio_txt"
        Me.anio_txt.Size = New System.Drawing.Size(160, 17)
        Me.anio_txt.TabIndex = 21
        '
        'titulo_txt
        '
        Me.titulo_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.titulo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_txt.Location = New System.Drawing.Point(84, 156)
        Me.titulo_txt.Name = "titulo_txt"
        Me.titulo_txt.Size = New System.Drawing.Size(160, 17)
        Me.titulo_txt.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 18)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Estado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Origen:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(36, 197)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 18)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Año:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(25, 155)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 18)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Titulo:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(94, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'cmbestado
        '
        Me.cmbestado.BackColor = System.Drawing.Color.DarkOrchid
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestado.ForeColor = System.Drawing.Color.Black
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Disponible", "Prestado", "Reservado", "Discontinuado"})
        Me.cmbestado.Location = New System.Drawing.Point(453, 65)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(172, 28)
        Me.cmbestado.TabIndex = 50
        '
        'cmbdatos
        '
        Me.cmbdatos.BackColor = System.Drawing.Color.DarkOrchid
        Me.cmbdatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdatos.ForeColor = System.Drawing.Color.Black
        Me.cmbdatos.FormattingEnabled = True
        Me.cmbdatos.Items.AddRange(New Object() {"Titulo", "Año", "Origen", "Descripcion"})
        Me.cmbdatos.Location = New System.Drawing.Point(275, 65)
        Me.cmbdatos.Name = "cmbdatos"
        Me.cmbdatos.Size = New System.Drawing.Size(172, 28)
        Me.cmbdatos.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 42)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Buscar una Revista:"
        '
        'lblorigenmostrar
        '
        Me.lblorigenmostrar.AutoSize = True
        Me.lblorigenmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorigenmostrar.Location = New System.Drawing.Point(99, 238)
        Me.lblorigenmostrar.Name = "lblorigenmostrar"
        Me.lblorigenmostrar.Size = New System.Drawing.Size(0, 18)
        Me.lblorigenmostrar.TabIndex = 14
        '
        'aniolabel
        '
        Me.aniolabel.AutoSize = True
        Me.aniolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aniolabel.Location = New System.Drawing.Point(53, 196)
        Me.aniolabel.Name = "aniolabel"
        Me.aniolabel.Size = New System.Drawing.Size(38, 18)
        Me.aniolabel.TabIndex = 20
        Me.aniolabel.Text = "Año:"
        '
        'origenlabel
        '
        Me.origenlabel.AutoSize = True
        Me.origenlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origenlabel.Location = New System.Drawing.Point(38, 240)
        Me.origenlabel.Name = "origenlabel"
        Me.origenlabel.Size = New System.Drawing.Size(56, 18)
        Me.origenlabel.TabIndex = 15
        Me.origenlabel.Text = "Origen:"
        '
        'titulolabel
        '
        Me.titulolabel.AutoSize = True
        Me.titulolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulolabel.Location = New System.Drawing.Point(46, 155)
        Me.titulolabel.Name = "titulolabel"
        Me.titulolabel.Size = New System.Drawing.Size(48, 18)
        Me.titulolabel.TabIndex = 12
        Me.titulolabel.Text = "Titulo:"
        '
        'estadolabel
        '
        Me.estadolabel.AutoSize = True
        Me.estadolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadolabel.Location = New System.Drawing.Point(35, 376)
        Me.estadolabel.Name = "estadolabel"
        Me.estadolabel.Size = New System.Drawing.Size(59, 18)
        Me.estadolabel.TabIndex = 17
        Me.estadolabel.Text = "Estado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        'Pmostrar
        '
        Me.Pmostrar.BackColor = System.Drawing.Color.DarkOrchid
        Me.Pmostrar.Controls.Add(Me.lblid)
        Me.Pmostrar.Controls.Add(Me.labelid)
        Me.Pmostrar.Controls.Add(Me.estado_label)
        Me.Pmostrar.Controls.Add(Me.txtdescmostrar)
        Me.Pmostrar.Controls.Add(Me.lblaniomostrar)
        Me.Pmostrar.Controls.Add(Me.lbltitulomostrar)
        Me.Pmostrar.Controls.Add(Me.desclabel)
        Me.Pmostrar.Controls.Add(Me.btnmodificar)
        Me.Pmostrar.Controls.Add(Me.PictureBox1)
        Me.Pmostrar.Controls.Add(Me.estadolabel)
        Me.Pmostrar.Controls.Add(Me.titulolabel)
        Me.Pmostrar.Controls.Add(Me.origenlabel)
        Me.Pmostrar.Controls.Add(Me.aniolabel)
        Me.Pmostrar.Controls.Add(Me.lblorigenmostrar)
        Me.Pmostrar.Location = New System.Drawing.Point(632, 101)
        Me.Pmostrar.Name = "Pmostrar"
        Me.Pmostrar.Size = New System.Drawing.Size(275, 459)
        Me.Pmostrar.TabIndex = 53
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(100, 116)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 18)
        Me.lblid.TabIndex = 34
        '
        'labelid
        '
        Me.labelid.AutoSize = True
        Me.labelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelid.Location = New System.Drawing.Point(64, 116)
        Me.labelid.Name = "labelid"
        Me.labelid.Size = New System.Drawing.Size(30, 18)
        Me.labelid.TabIndex = 33
        Me.labelid.Text = "ID: "
        '
        'estado_label
        '
        Me.estado_label.AutoSize = True
        Me.estado_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado_label.Location = New System.Drawing.Point(99, 377)
        Me.estado_label.Name = "estado_label"
        Me.estado_label.Size = New System.Drawing.Size(0, 18)
        Me.estado_label.TabIndex = 32
        '
        'txtdescmostrar
        '
        Me.txtdescmostrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescmostrar.Location = New System.Drawing.Point(102, 281)
        Me.txtdescmostrar.Multiline = True
        Me.txtdescmostrar.Name = "txtdescmostrar"
        Me.txtdescmostrar.ReadOnly = True
        Me.txtdescmostrar.Size = New System.Drawing.Size(160, 86)
        Me.txtdescmostrar.TabIndex = 31
        '
        'lblaniomostrar
        '
        Me.lblaniomostrar.AutoSize = True
        Me.lblaniomostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaniomostrar.Location = New System.Drawing.Point(99, 195)
        Me.lblaniomostrar.Name = "lblaniomostrar"
        Me.lblaniomostrar.Size = New System.Drawing.Size(0, 18)
        Me.lblaniomostrar.TabIndex = 30
        '
        'lbltitulomostrar
        '
        Me.lbltitulomostrar.AutoSize = True
        Me.lbltitulomostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulomostrar.Location = New System.Drawing.Point(99, 157)
        Me.lbltitulomostrar.Name = "lbltitulomostrar"
        Me.lbltitulomostrar.Size = New System.Drawing.Size(0, 18)
        Me.lbltitulomostrar.TabIndex = 29
        '
        'desclabel
        '
        Me.desclabel.AutoSize = True
        Me.desclabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desclabel.Location = New System.Drawing.Point(3, 281)
        Me.desclabel.Name = "desclabel"
        Me.desclabel.Size = New System.Drawing.Size(91, 18)
        Me.desclabel.TabIndex = 27
        Me.desclabel.Text = "Descripcion:"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(783, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 30)
        Me.Panel1.TabIndex = 55
        '
        'dgvcomprobar
        '
        Me.dgvcomprobar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcomprobar.Location = New System.Drawing.Point(795, 9)
        Me.dgvcomprobar.Name = "dgvcomprobar"
        Me.dgvcomprobar.Size = New System.Drawing.Size(82, 30)
        Me.dgvcomprobar.TabIndex = 54
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvrevistas
        '
        Me.dgvrevistas.AllowUserToAddRows = False
        Me.dgvrevistas.AllowUserToDeleteRows = False
        Me.dgvrevistas.AllowUserToResizeColumns = False
        Me.dgvrevistas.AllowUserToResizeRows = False
        Me.dgvrevistas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvrevistas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrevistas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvrevistas.ColumnHeadersHeight = 40
        Me.dgvrevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvrevistas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvrevistas.EnableHeadersVisualStyles = False
        Me.dgvrevistas.Location = New System.Drawing.Point(8, 96)
        Me.dgvrevistas.MultiSelect = False
        Me.dgvrevistas.Name = "dgvrevistas"
        Me.dgvrevistas.ReadOnly = True
        Me.dgvrevistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrevistas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvrevistas.RowHeadersVisible = False
        Me.dgvrevistas.RowHeadersWidth = 50
        Me.dgvrevistas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvrevistas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvrevistas.RowTemplate.Height = 32
        Me.dgvrevistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvrevistas.Size = New System.Drawing.Size(616, 461)
        Me.dgvrevistas.TabIndex = 67
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(12, 64)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(257, 29)
        Me.txtbusqueda.TabIndex = 51
        Me.txtbusqueda.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtbusqueda.WaterMarkText = "Buscar"
        '
        'BusquedaRevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(919, 573)
        Me.Controls.Add(Me.dgvrevistas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvcomprobar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.cmbdatos)
        Me.Controls.Add(Me.Pmostrar)
        Me.Controls.Add(Me.Pactualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BusquedaRevistas"
        Me.Text = "BusquedaRevistas"
        Me.Pactualizar.ResumeLayout(False)
        Me.Pactualizar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pmostrar.ResumeLayout(False)
        Me.Pmostrar.PerformLayout()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pactualizar As System.Windows.Forms.Panel
    Friend WithEvents cmbupdate As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents origen_txt As System.Windows.Forms.TextBox
    Friend WithEvents anio_txt As System.Windows.Forms.TextBox
    Friend WithEvents titulo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents desc_txt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtbusqueda As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
    Private WithEvents cmbdatos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblorigenmostrar As System.Windows.Forms.Label
    Friend WithEvents aniolabel As System.Windows.Forms.Label
    Friend WithEvents origenlabel As System.Windows.Forms.Label
    Friend WithEvents titulolabel As System.Windows.Forms.Label
    Friend WithEvents estadolabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Pmostrar As System.Windows.Forms.Panel
    Friend WithEvents txtdescmostrar As System.Windows.Forms.TextBox
    Friend WithEvents lblaniomostrar As System.Windows.Forms.Label
    Friend WithEvents lbltitulomostrar As System.Windows.Forms.Label
    Friend WithEvents desclabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvcomprobar As System.Windows.Forms.DataGridView
    Friend WithEvents estado_label As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents labelid As System.Windows.Forms.Label
    Friend WithEvents id_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvrevistas As System.Windows.Forms.DataGridView
End Class
