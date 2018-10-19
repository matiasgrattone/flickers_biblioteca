<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoRevistas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btningresarrevista = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lblanio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvcomprobar = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtdescripcion = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtorigenr = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtanior = New Proyecto_Biblioteca.PlaceHolder()
        Me.txttitulo = New Proyecto_Biblioteca.PlaceHolder()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvrevistas = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btningresarrevista
        '
        Me.btningresarrevista.Location = New System.Drawing.Point(359, 195)
        Me.btningresarrevista.Name = "btningresarrevista"
        Me.btningresarrevista.Size = New System.Drawing.Size(122, 42)
        Me.btningresarrevista.TabIndex = 1
        Me.btningresarrevista.Text = "Ingresar"
        Me.btningresarrevista.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(137, 68)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(46, 15)
        Me.lbltitulo.TabIndex = 6
        Me.lbltitulo.Text = "Titulo:"
        '
        'lblanio
        '
        Me.lblanio.AutoSize = True
        Me.lblanio.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanio.Location = New System.Drawing.Point(146, 114)
        Me.lblanio.Name = "lblanio"
        Me.lblanio.Size = New System.Drawing.Size(37, 15)
        Me.lblanio.TabIndex = 7
        Me.lblanio.Text = "Año:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pais de origen:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvcomprobar
        '
        Me.dgvcomprobar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcomprobar.Location = New System.Drawing.Point(762, 12)
        Me.dgvcomprobar.Name = "dgvcomprobar"
        Me.dgvcomprobar.Size = New System.Drawing.Size(94, 27)
        Me.dgvcomprobar.TabIndex = 10
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider2.ContainerControl = Me
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(515, 109)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(294, 76)
        Me.txtdescripcion.TabIndex = 5
        Me.txtdescripcion.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtdescripcion.WaterMarkText = "Ingrese Descripcion"
        '
        'txtorigenr
        '
        Me.txtorigenr.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorigenr.Location = New System.Drawing.Point(515, 63)
        Me.txtorigenr.Name = "txtorigenr"
        Me.txtorigenr.Size = New System.Drawing.Size(173, 20)
        Me.txtorigenr.TabIndex = 4
        Me.txtorigenr.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtorigenr.WaterMarkText = "Pais de Origen"
        '
        'txtanior
        '
        Me.txtanior.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanior.Location = New System.Drawing.Point(191, 109)
        Me.txtanior.Name = "txtanior"
        Me.txtanior.Size = New System.Drawing.Size(173, 20)
        Me.txtanior.TabIndex = 3
        Me.txtanior.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtanior.WaterMarkText = "Ingrese Año:"
        '
        'txttitulo
        '
        Me.txttitulo.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitulo.Location = New System.Drawing.Point(191, 66)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(173, 20)
        Me.txttitulo.TabIndex = 2
        Me.txttitulo.WaterMarkColor = System.Drawing.Color.Gray
        Me.txttitulo.WaterMarkText = "Ingrese Titulo"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(762, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 27)
        Me.Panel1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ingreso de Revistas:"
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
        Me.dgvrevistas.Location = New System.Drawing.Point(8, 272)
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
        Me.dgvrevistas.Size = New System.Drawing.Size(881, 299)
        Me.dgvrevistas.TabIndex = 69
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(2, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(894, 314)
        Me.Panel2.TabIndex = 70
        '
        'IngresoRevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 586)
        Me.Controls.Add(Me.dgvrevistas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvcomprobar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblanio)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtorigenr)
        Me.Controls.Add(Me.txtanior)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.btningresarrevista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IngresoRevistas"
        Me.Text = "IngresoRevistas"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btningresarrevista As System.Windows.Forms.Button
    Friend WithEvents txttitulo As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtanior As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtorigenr As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtdescripcion As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblanio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvcomprobar As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvrevistas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
