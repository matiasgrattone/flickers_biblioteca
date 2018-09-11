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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaRevistas))
        Me.dgvrevistas = New System.Windows.Forms.DataGridView()
        Me.Pactualizar = New System.Windows.Forms.Panel()
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
        Me.estado_label = New System.Windows.Forms.Label()
        Me.txtdescmostrar = New System.Windows.Forms.TextBox()
        Me.lblaniomostrar = New System.Windows.Forms.Label()
        Me.lbltitulomostrar = New System.Windows.Forms.Label()
        Me.desclabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvcomprobar = New System.Windows.Forms.DataGridView()
        Me.txtbusqueda = New Proyecto_Biblioteca.PlaceHolder()
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pactualizar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pmostrar.SuspendLayout()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvrevistas
        '
        Me.dgvrevistas.AllowUserToAddRows = False
        Me.dgvrevistas.AllowUserToDeleteRows = False
        Me.dgvrevistas.AllowUserToResizeColumns = False
        Me.dgvrevistas.AllowUserToResizeRows = False
        Me.dgvrevistas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvrevistas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvrevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrevistas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvrevistas.Location = New System.Drawing.Point(12, 100)
        Me.dgvrevistas.Name = "dgvrevistas"
        Me.dgvrevistas.ReadOnly = True
        Me.dgvrevistas.RowHeadersVisible = False
        Me.dgvrevistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvrevistas.Size = New System.Drawing.Size(614, 461)
        Me.dgvrevistas.TabIndex = 26
        '
        'Pactualizar
        '
        Me.Pactualizar.BackColor = System.Drawing.Color.DarkViolet
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
        Me.cmbupdate.Items.AddRange(New Object() {"disponible", "ocupado", "reservado", "descontinuado"})
        Me.cmbupdate.Location = New System.Drawing.Point(102, 377)
        Me.cmbupdate.Name = "cmbupdate"
        Me.cmbupdate.Size = New System.Drawing.Size(160, 21)
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
        Me.origen_txt.Location = New System.Drawing.Point(102, 239)
        Me.origen_txt.Name = "origen_txt"
        Me.origen_txt.Size = New System.Drawing.Size(160, 17)
        Me.origen_txt.TabIndex = 21
        '
        'anio_txt
        '
        Me.anio_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.anio_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anio_txt.Location = New System.Drawing.Point(102, 196)
        Me.anio_txt.Name = "anio_txt"
        Me.anio_txt.Size = New System.Drawing.Size(160, 17)
        Me.anio_txt.TabIndex = 21
        '
        'titulo_txt
        '
        Me.titulo_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.titulo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_txt.Location = New System.Drawing.Point(102, 156)
        Me.titulo_txt.Name = "titulo_txt"
        Me.titulo_txt.Size = New System.Drawing.Size(160, 17)
        Me.titulo_txt.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 18)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Estado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Origen:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(54, 197)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 18)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Año:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(41, 156)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 18)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Titulo:"
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
        'cmbestado
        '
        Me.cmbestado.BackColor = System.Drawing.Color.DarkOrchid
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestado.ForeColor = System.Drawing.Color.Black
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"disponible", "ocupado", "reservado", "descontinuado"})
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
        Me.lblorigenmostrar.Location = New System.Drawing.Point(93, 240)
        Me.lblorigenmostrar.Name = "lblorigenmostrar"
        Me.lblorigenmostrar.Size = New System.Drawing.Size(52, 18)
        Me.lblorigenmostrar.TabIndex = 14
        Me.lblorigenmostrar.Text = "Origen"
        '
        'aniolabel
        '
        Me.aniolabel.AutoSize = True
        Me.aniolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aniolabel.Location = New System.Drawing.Point(38, 196)
        Me.aniolabel.Name = "aniolabel"
        Me.aniolabel.Size = New System.Drawing.Size(38, 18)
        Me.aniolabel.TabIndex = 20
        Me.aniolabel.Text = "Año:"
        '
        'origenlabel
        '
        Me.origenlabel.AutoSize = True
        Me.origenlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origenlabel.Location = New System.Drawing.Point(32, 239)
        Me.origenlabel.Name = "origenlabel"
        Me.origenlabel.Size = New System.Drawing.Size(56, 18)
        Me.origenlabel.TabIndex = 15
        Me.origenlabel.Text = "Origen:"
        '
        'titulolabel
        '
        Me.titulolabel.AutoSize = True
        Me.titulolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulolabel.Location = New System.Drawing.Point(38, 156)
        Me.titulolabel.Name = "titulolabel"
        Me.titulolabel.Size = New System.Drawing.Size(48, 18)
        Me.titulolabel.TabIndex = 12
        Me.titulolabel.Text = "Titulo:"
        '
        'estadolabel
        '
        Me.estadolabel.AutoSize = True
        Me.estadolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadolabel.Location = New System.Drawing.Point(34, 377)
        Me.estadolabel.Name = "estadolabel"
        Me.estadolabel.Size = New System.Drawing.Size(59, 18)
        Me.estadolabel.TabIndex = 17
        Me.estadolabel.Text = "Estado:"
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
        Me.Pmostrar.Location = New System.Drawing.Point(635, 100)
        Me.Pmostrar.Name = "Pmostrar"
        Me.Pmostrar.Size = New System.Drawing.Size(275, 458)
        Me.Pmostrar.TabIndex = 53
        '
        'estado_label
        '
        Me.estado_label.AutoSize = True
        Me.estado_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado_label.Location = New System.Drawing.Point(109, 377)
        Me.estado_label.Name = "estado_label"
        Me.estado_label.Size = New System.Drawing.Size(55, 18)
        Me.estado_label.TabIndex = 32
        Me.estado_label.Text = "Estado"
        '
        'txtdescmostrar
        '
        Me.txtdescmostrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescmostrar.Location = New System.Drawing.Point(99, 281)
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
        Me.lblaniomostrar.Location = New System.Drawing.Point(83, 196)
        Me.lblaniomostrar.Name = "lblaniomostrar"
        Me.lblaniomostrar.Size = New System.Drawing.Size(34, 18)
        Me.lblaniomostrar.TabIndex = 30
        Me.lblaniomostrar.Text = "Año"
        '
        'lbltitulomostrar
        '
        Me.lbltitulomostrar.AutoSize = True
        Me.lbltitulomostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulomostrar.Location = New System.Drawing.Point(99, 157)
        Me.lbltitulomostrar.Name = "lbltitulomostrar"
        Me.lbltitulomostrar.Size = New System.Drawing.Size(44, 18)
        Me.lbltitulomostrar.TabIndex = 29
        Me.lbltitulomostrar.Text = "Titulo"
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvcomprobar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.cmbdatos)
        Me.Controls.Add(Me.dgvrevistas)
        Me.Controls.Add(Me.Pactualizar)
        Me.Controls.Add(Me.Pmostrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BusquedaRevistas"
        Me.Text = "BusquedaRevistas"
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pactualizar.ResumeLayout(False)
        Me.Pactualizar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pmostrar.ResumeLayout(False)
        Me.Pmostrar.PerformLayout()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvrevistas As System.Windows.Forms.DataGridView
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
End Class
