<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.estado = New System.Windows.Forms.TextBox()
        Me.observaciones = New System.Windows.Forms.TextBox()
        Me.origen = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.casa_editorial = New System.Windows.Forms.TextBox()
        Me.volumen = New System.Windows.Forms.TextBox()
        Me.titulo = New System.Windows.Forms.TextBox()
        Me.autor = New System.Windows.Forms.TextBox()
        Me.cod_libro = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ingresar_boton = New System.Windows.Forms.Button()
        Me.Editorial_label = New System.Windows.Forms.Label()
        Me.estado_label = New System.Windows.Forms.Label()
        Me.observaciones_label = New System.Windows.Forms.Label()
        Me.origen_label = New System.Windows.Forms.Label()
        Me.fecha_label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.titulo_label = New System.Windows.Forms.Label()
        Me.autor_label = New System.Windows.Forms.Label()
        Me.id_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'estado
        '
        Me.estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.Location = New System.Drawing.Point(181, 362)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(178, 29)
        Me.estado.TabIndex = 32
        '
        'observaciones
        '
        Me.observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observaciones.Location = New System.Drawing.Point(181, 327)
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Size = New System.Drawing.Size(178, 29)
        Me.observaciones.TabIndex = 33
        '
        'origen
        '
        Me.origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen.Location = New System.Drawing.Point(181, 292)
        Me.origen.Name = "origen"
        Me.origen.Size = New System.Drawing.Size(178, 29)
        Me.origen.TabIndex = 30
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(181, 257)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(178, 29)
        Me.fecha.TabIndex = 31
        '
        'casa_editorial
        '
        Me.casa_editorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.casa_editorial.Location = New System.Drawing.Point(181, 222)
        Me.casa_editorial.Name = "casa_editorial"
        Me.casa_editorial.Size = New System.Drawing.Size(178, 29)
        Me.casa_editorial.TabIndex = 34
        '
        'volumen
        '
        Me.volumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumen.Location = New System.Drawing.Point(181, 187)
        Me.volumen.Name = "volumen"
        Me.volumen.Size = New System.Drawing.Size(178, 29)
        Me.volumen.TabIndex = 37
        '
        'titulo
        '
        Me.titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Location = New System.Drawing.Point(181, 152)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(178, 29)
        Me.titulo.TabIndex = 38
        '
        'autor
        '
        Me.autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autor.Location = New System.Drawing.Point(181, 120)
        Me.autor.Name = "autor"
        Me.autor.Size = New System.Drawing.Size(178, 29)
        Me.autor.TabIndex = 35
        '
        'cod_libro
        '
        Me.cod_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_libro.Location = New System.Drawing.Point(181, 85)
        Me.cod_libro.Name = "cod_libro"
        Me.cod_libro.Size = New System.Drawing.Size(178, 29)
        Me.cod_libro.TabIndex = 36
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(365, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 24)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "S/O"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(365, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 24)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "S/E"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(365, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 24)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "S/V"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(365, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 24)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "S/A"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(417, 46)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(944, 430)
        Me.DataGridView1.TabIndex = 21
        '
        'ingresar_boton
        '
        Me.ingresar_boton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresar_boton.Location = New System.Drawing.Point(181, 415)
        Me.ingresar_boton.Name = "ingresar_boton"
        Me.ingresar_boton.Size = New System.Drawing.Size(183, 61)
        Me.ingresar_boton.TabIndex = 20
        Me.ingresar_boton.Text = "Ingresar"
        Me.ingresar_boton.UseVisualStyleBackColor = True
        '
        'Editorial_label
        '
        Me.Editorial_label.AutoSize = True
        Me.Editorial_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editorial_label.Location = New System.Drawing.Point(31, 222)
        Me.Editorial_label.Name = "Editorial_label"
        Me.Editorial_label.Size = New System.Drawing.Size(144, 24)
        Me.Editorial_label.TabIndex = 13
        Me.Editorial_label.Text = "Casa Editorial:"
        '
        'estado_label
        '
        Me.estado_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado_label.Location = New System.Drawing.Point(91, 358)
        Me.estado_label.Name = "estado_label"
        Me.estado_label.Size = New System.Drawing.Size(81, 24)
        Me.estado_label.TabIndex = 14
        Me.estado_label.Text = "Estado:"
        '
        'observaciones_label
        '
        Me.observaciones_label.AutoSize = True
        Me.observaciones_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observaciones_label.Location = New System.Drawing.Point(28, 323)
        Me.observaciones_label.Name = "observaciones_label"
        Me.observaciones_label.Size = New System.Drawing.Size(156, 24)
        Me.observaciones_label.TabIndex = 11
        Me.observaciones_label.Text = "Observaciones:"
        '
        'origen_label
        '
        Me.origen_label.AutoSize = True
        Me.origen_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen_label.Location = New System.Drawing.Point(95, 291)
        Me.origen_label.Name = "origen_label"
        Me.origen_label.Size = New System.Drawing.Size(80, 24)
        Me.origen_label.TabIndex = 17
        Me.origen_label.Text = "Origen:"
        '
        'fecha_label
        '
        Me.fecha_label.AutoSize = True
        Me.fecha_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_label.Location = New System.Drawing.Point(100, 257)
        Me.fecha_label.Name = "fecha_label"
        Me.fecha_label.Size = New System.Drawing.Size(75, 24)
        Me.fecha_label.TabIndex = 12
        Me.fecha_label.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Volumen:"
        '
        'titulo_label
        '
        Me.titulo_label.AutoSize = True
        Me.titulo_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_label.Location = New System.Drawing.Point(107, 152)
        Me.titulo_label.Name = "titulo_label"
        Me.titulo_label.Size = New System.Drawing.Size(68, 24)
        Me.titulo_label.TabIndex = 19
        Me.titulo_label.Text = "Titulo:"
        '
        'autor_label
        '
        Me.autor_label.AutoSize = True
        Me.autor_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autor_label.Location = New System.Drawing.Point(109, 118)
        Me.autor_label.Name = "autor_label"
        Me.autor_label.Size = New System.Drawing.Size(66, 24)
        Me.autor_label.TabIndex = 18
        Me.autor_label.Text = "Autor:"
        '
        'id_label
        '
        Me.id_label.AutoSize = True
        Me.id_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_label.Location = New System.Drawing.Point(140, 85)
        Me.id_label.Name = "id_label"
        Me.id_label.Size = New System.Drawing.Size(35, 24)
        Me.id_label.TabIndex = 16
        Me.id_label.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ingresar Nuevo Libro"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1234, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 28)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1272, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 28)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1312, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 28)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1325, 31)
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 516)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.observaciones)
        Me.Controls.Add(Me.origen)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.casa_editorial)
        Me.Controls.Add(Me.volumen)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.autor)
        Me.Controls.Add(Me.cod_libro)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ingresar_boton)
        Me.Controls.Add(Me.Editorial_label)
        Me.Controls.Add(Me.estado_label)
        Me.Controls.Add(Me.observaciones_label)
        Me.Controls.Add(Me.origen_label)
        Me.Controls.Add(Me.fecha_label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.titulo_label)
        Me.Controls.Add(Me.autor_label)
        Me.Controls.Add(Me.id_label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents estado As System.Windows.Forms.TextBox
    Friend WithEvents observaciones As System.Windows.Forms.TextBox
    Friend WithEvents origen As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents casa_editorial As System.Windows.Forms.TextBox
    Friend WithEvents volumen As System.Windows.Forms.TextBox
    Friend WithEvents titulo As System.Windows.Forms.TextBox
    Friend WithEvents autor As System.Windows.Forms.TextBox
    Friend WithEvents cod_libro As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ingresar_boton As System.Windows.Forms.Button
    Friend WithEvents Editorial_label As System.Windows.Forms.Label
    Friend WithEvents estado_label As System.Windows.Forms.Label
    Friend WithEvents observaciones_label As System.Windows.Forms.Label
    Friend WithEvents origen_label As System.Windows.Forms.Label
    Friend WithEvents fecha_label As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents titulo_label As System.Windows.Forms.Label
    Friend WithEvents autor_label As System.Windows.Forms.Label
    Friend WithEvents id_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
