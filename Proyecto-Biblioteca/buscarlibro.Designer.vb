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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.volumen_label = New System.Windows.Forms.Label()
        Me.titulo_label = New System.Windows.Forms.Label()
        Me.autor_label = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.estado_label = New System.Windows.Forms.Label()
        Me.observaciones_label = New System.Windows.Forms.Label()
        Me.origen_label = New System.Windows.Forms.Label()
        Me.fecha_label = New System.Windows.Forms.Label()
        Me.editorial_label = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cod_libro_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cod_libro_label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.estado_txt = New System.Windows.Forms.TextBox()
        Me.observaciones_txt = New System.Windows.Forms.TextBox()
        Me.origen_txt = New System.Windows.Forms.TextBox()
        Me.fecha_txt = New System.Windows.Forms.TextBox()
        Me.editorial_txt = New System.Windows.Forms.TextBox()
        Me.volumen_txt = New System.Windows.Forms.TextBox()
        Me.titulo_txt = New System.Windows.Forms.TextBox()
        Me.autor_txt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(894, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 68)
        Me.Panel2.TabIndex = 33
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(820, 50)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(74, 33)
        Me.DataGridView2.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Codigo", "Autor", "Titulo", "Editorial", "Fecha", "Origen", "Estado"})
        Me.ComboBox1.Location = New System.Drawing.Point(444, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 28)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.Text = "Seleccione"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(663, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 32)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(76, 83)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(362, 28)
        Me.TextBox1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Buscar un libro"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(76, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(694, 413)
        Me.DataGridView1.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.volumen_label)
        Me.Panel1.Controls.Add(Me.titulo_label)
        Me.Panel1.Controls.Add(Me.autor_label)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.estado_label)
        Me.Panel1.Controls.Add(Me.observaciones_label)
        Me.Panel1.Controls.Add(Me.origen_label)
        Me.Panel1.Controls.Add(Me.fecha_label)
        Me.Panel1.Controls.Add(Me.editorial_label)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cod_libro_label)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(787, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 412)
        Me.Panel1.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 24)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'volumen_label
        '
        Me.volumen_label.AutoSize = True
        Me.volumen_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumen_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumen_label.Location = New System.Drawing.Point(130, 211)
        Me.volumen_label.Name = "volumen_label"
        Me.volumen_label.Size = New System.Drawing.Size(74, 22)
        Me.volumen_label.TabIndex = 23
        Me.volumen_label.Text = "Volumen"
        '
        'titulo_label
        '
        Me.titulo_label.AutoSize = True
        Me.titulo_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.titulo_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_label.Location = New System.Drawing.Point(130, 181)
        Me.titulo_label.Name = "titulo_label"
        Me.titulo_label.Size = New System.Drawing.Size(49, 22)
        Me.titulo_label.TabIndex = 22
        Me.titulo_label.Text = "Titulo"
        '
        'autor_label
        '
        Me.autor_label.AutoSize = True
        Me.autor_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.autor_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autor_label.Location = New System.Drawing.Point(130, 155)
        Me.autor_label.Name = "autor_label"
        Me.autor_label.Size = New System.Drawing.Size(50, 22)
        Me.autor_label.TabIndex = 21
        Me.autor_label.Text = "Autor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Estado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 18)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Observaciones:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Origen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Fecha:"
        '
        'estado_label
        '
        Me.estado_label.AutoSize = True
        Me.estado_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estado_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado_label.Location = New System.Drawing.Point(130, 341)
        Me.estado_label.Name = "estado_label"
        Me.estado_label.Size = New System.Drawing.Size(62, 22)
        Me.estado_label.TabIndex = 19
        Me.estado_label.Text = "Estado"
        '
        'observaciones_label
        '
        Me.observaciones_label.AutoSize = True
        Me.observaciones_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.observaciones_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observaciones_label.Location = New System.Drawing.Point(130, 315)
        Me.observaciones_label.Name = "observaciones_label"
        Me.observaciones_label.Size = New System.Drawing.Size(116, 22)
        Me.observaciones_label.TabIndex = 18
        Me.observaciones_label.Text = "Observaciones"
        '
        'origen_label
        '
        Me.origen_label.AutoSize = True
        Me.origen_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.origen_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen_label.Location = New System.Drawing.Point(130, 292)
        Me.origen_label.Name = "origen_label"
        Me.origen_label.Size = New System.Drawing.Size(58, 22)
        Me.origen_label.TabIndex = 14
        Me.origen_label.Text = "Origen"
        '
        'fecha_label
        '
        Me.fecha_label.AutoSize = True
        Me.fecha_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fecha_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_label.Location = New System.Drawing.Point(130, 269)
        Me.fecha_label.Name = "fecha_label"
        Me.fecha_label.Size = New System.Drawing.Size(56, 22)
        Me.fecha_label.TabIndex = 8
        Me.fecha_label.Text = "Fecha"
        '
        'editorial_label
        '
        Me.editorial_label.AutoSize = True
        Me.editorial_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editorial_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorial_label.Location = New System.Drawing.Point(130, 239)
        Me.editorial_label.Name = "editorial_label"
        Me.editorial_label.Size = New System.Drawing.Size(68, 22)
        Me.editorial_label.TabIndex = 9
        Me.editorial_label.Text = "Editorial"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Casa Editorial:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Volumen:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Titulo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Autor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Codigo de libro:"
        '
        'cod_libro_label
        '
        Me.cod_libro_label.AutoSize = True
        Me.cod_libro_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cod_libro_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_libro_label.Location = New System.Drawing.Point(130, 130)
        Me.cod_libro_label.Name = "cod_libro_label"
        Me.cod_libro_label.Size = New System.Drawing.Size(61, 22)
        Me.cod_libro_label.TabIndex = 11
        Me.cod_libro_label.Text = "Codigo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(97, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cod_libro_label2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.estado_txt)
        Me.Panel3.Controls.Add(Me.observaciones_txt)
        Me.Panel3.Controls.Add(Me.origen_txt)
        Me.Panel3.Controls.Add(Me.fecha_txt)
        Me.Panel3.Controls.Add(Me.editorial_txt)
        Me.Panel3.Controls.Add(Me.volumen_txt)
        Me.Panel3.Controls.Add(Me.titulo_txt)
        Me.Panel3.Controls.Add(Me.autor_txt)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(787, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 412)
        Me.Panel3.TabIndex = 34
        '
        'cod_libro_label2
        '
        Me.cod_libro_label2.AutoSize = True
        Me.cod_libro_label2.BackColor = System.Drawing.SystemColors.Window
        Me.cod_libro_label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cod_libro_label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_libro_label2.ForeColor = System.Drawing.Color.Black
        Me.cod_libro_label2.Location = New System.Drawing.Point(126, 133)
        Me.cod_libro_label2.MinimumSize = New System.Drawing.Size(136, 20)
        Me.cod_libro_label2.Name = "cod_libro_label2"
        Me.cod_libro_label2.Size = New System.Drawing.Size(136, 20)
        Me.cod_libro_label2.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(97, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 26)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'estado_txt
        '
        Me.estado_txt.Location = New System.Drawing.Point(126, 345)
        Me.estado_txt.Name = "estado_txt"
        Me.estado_txt.Size = New System.Drawing.Size(136, 20)
        Me.estado_txt.TabIndex = 21
        '
        'observaciones_txt
        '
        Me.observaciones_txt.Location = New System.Drawing.Point(126, 319)
        Me.observaciones_txt.Name = "observaciones_txt"
        Me.observaciones_txt.Size = New System.Drawing.Size(136, 20)
        Me.observaciones_txt.TabIndex = 21
        '
        'origen_txt
        '
        Me.origen_txt.Location = New System.Drawing.Point(126, 291)
        Me.origen_txt.Name = "origen_txt"
        Me.origen_txt.Size = New System.Drawing.Size(136, 20)
        Me.origen_txt.TabIndex = 21
        '
        'fecha_txt
        '
        Me.fecha_txt.Location = New System.Drawing.Point(126, 265)
        Me.fecha_txt.Name = "fecha_txt"
        Me.fecha_txt.Size = New System.Drawing.Size(136, 20)
        Me.fecha_txt.TabIndex = 21
        '
        'editorial_txt
        '
        Me.editorial_txt.Location = New System.Drawing.Point(126, 237)
        Me.editorial_txt.Name = "editorial_txt"
        Me.editorial_txt.Size = New System.Drawing.Size(136, 20)
        Me.editorial_txt.TabIndex = 21
        '
        'volumen_txt
        '
        Me.volumen_txt.Location = New System.Drawing.Point(126, 210)
        Me.volumen_txt.Name = "volumen_txt"
        Me.volumen_txt.Size = New System.Drawing.Size(136, 20)
        Me.volumen_txt.TabIndex = 21
        '
        'titulo_txt
        '
        Me.titulo_txt.Location = New System.Drawing.Point(126, 185)
        Me.titulo_txt.Name = "titulo_txt"
        Me.titulo_txt.Size = New System.Drawing.Size(136, 20)
        Me.titulo_txt.TabIndex = 21
        '
        'autor_txt
        '
        Me.autor_txt.Location = New System.Drawing.Point(126, 159)
        Me.autor_txt.Name = "autor_txt"
        Me.autor_txt.Size = New System.Drawing.Size(136, 20)
        Me.autor_txt.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 18)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Estado:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 316)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 18)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Observaciones:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 293)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 18)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Origen"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 267)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 18)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Fecha:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 240)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 18)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Casa Editorial:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 212)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 18)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Volumen:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 182)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 18)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Titulo:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 156)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 18)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Autor:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 131)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 18)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "Codigo de libro:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(97, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'buscarlibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "buscarlibro"
        Me.Text = "Form2"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cod_libro_label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents estado_txt As System.Windows.Forms.TextBox
    Friend WithEvents observaciones_txt As System.Windows.Forms.TextBox
    Friend WithEvents origen_txt As System.Windows.Forms.TextBox
    Friend WithEvents fecha_txt As System.Windows.Forms.TextBox
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
End Class
