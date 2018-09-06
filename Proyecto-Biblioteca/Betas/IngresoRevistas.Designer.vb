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
        Me.dgvrevistas = New System.Windows.Forms.DataGridView()
        Me.btningresarrevista = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lblanio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtorigenr = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtanior = New Proyecto_Biblioteca.PlaceHolder()
        Me.txttitulo = New Proyecto_Biblioteca.PlaceHolder()
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvrevistas
        '
        Me.dgvrevistas.AllowUserToAddRows = False
        Me.dgvrevistas.AllowUserToDeleteRows = False
        Me.dgvrevistas.AllowUserToResizeColumns = False
        Me.dgvrevistas.AllowUserToResizeRows = False
        Me.dgvrevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrevistas.Location = New System.Drawing.Point(12, 254)
        Me.dgvrevistas.Name = "dgvrevistas"
        Me.dgvrevistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvrevistas.RowHeadersVisible = False
        Me.dgvrevistas.Size = New System.Drawing.Size(844, 320)
        Me.dgvrevistas.TabIndex = 0
        '
        'btningresarrevista
        '
        Me.btningresarrevista.Location = New System.Drawing.Point(349, 195)
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
        Me.lbltitulo.Location = New System.Drawing.Point(96, 63)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(46, 15)
        Me.lbltitulo.TabIndex = 6
        Me.lbltitulo.Text = "Titulo:"
        '
        'lblanio
        '
        Me.lblanio.AutoSize = True
        Me.lblanio.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanio.Location = New System.Drawing.Point(105, 111)
        Me.lblanio.Name = "lblanio"
        Me.lblanio.Size = New System.Drawing.Size(37, 15)
        Me.lblanio.TabIndex = 7
        Me.lblanio.Text = "Año:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(428, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pais de origen:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(534, 107)
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
        Me.txtorigenr.Location = New System.Drawing.Point(534, 61)
        Me.txtorigenr.Name = "txtorigenr"
        Me.txtorigenr.Size = New System.Drawing.Size(173, 20)
        Me.txtorigenr.TabIndex = 4
        Me.txtorigenr.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtorigenr.WaterMarkText = "Pais de Origen"
        '
        'txtanior
        '
        Me.txtanior.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanior.Location = New System.Drawing.Point(150, 109)
        Me.txtanior.Name = "txtanior"
        Me.txtanior.Size = New System.Drawing.Size(173, 20)
        Me.txtanior.TabIndex = 3
        Me.txtanior.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtanior.WaterMarkText = "Ingrese Año:"
        '
        'txttitulo
        '
        Me.txttitulo.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitulo.Location = New System.Drawing.Point(150, 61)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(173, 20)
        Me.txttitulo.TabIndex = 2
        Me.txttitulo.WaterMarkColor = System.Drawing.Color.Gray
        Me.txttitulo.WaterMarkText = "Ingrese Titulo"
        '
        'IngresoRevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(868, 586)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblanio)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtorigenr)
        Me.Controls.Add(Me.txtanior)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.btningresarrevista)
        Me.Controls.Add(Me.dgvrevistas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IngresoRevistas"
        Me.Text = "IngresoRevistas"
        CType(Me.dgvrevistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvrevistas As System.Windows.Forms.DataGridView
    Friend WithEvents btningresarrevista As System.Windows.Forms.Button
    Friend WithEvents txttitulo As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtanior As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtorigenr As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtdescripcion As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblanio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
