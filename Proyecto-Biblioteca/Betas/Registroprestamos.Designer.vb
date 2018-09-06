<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registroprestamos
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
        Me.dgvregistro = New System.Windows.Forms.DataGridView()
        Me.cmbbusqueda = New System.Windows.Forms.ComboBox()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbusqueda = New Proyecto_Biblioteca.PlaceHolder()
        CType(Me.dgvregistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvregistro
        '
        Me.dgvregistro.AllowUserToAddRows = False
        Me.dgvregistro.AllowUserToDeleteRows = False
        Me.dgvregistro.AllowUserToResizeColumns = False
        Me.dgvregistro.AllowUserToResizeRows = False
        Me.dgvregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvregistro.Location = New System.Drawing.Point(12, 52)
        Me.dgvregistro.Name = "dgvregistro"
        Me.dgvregistro.ReadOnly = True
        Me.dgvregistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvregistro.Size = New System.Drawing.Size(844, 522)
        Me.dgvregistro.TabIndex = 0
        '
        'cmbbusqueda
        '
        Me.cmbbusqueda.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbusqueda.FormattingEnabled = True
        Me.cmbbusqueda.Items.AddRange(New Object() {"Cedula de Socio", "Nombre de Socio", "Codigo de Inventario", "Titulo de Libro"})
        Me.cmbbusqueda.Location = New System.Drawing.Point(292, 23)
        Me.cmbbusqueda.Name = "cmbbusqueda"
        Me.cmbbusqueda.Size = New System.Drawing.Size(194, 23)
        Me.cmbbusqueda.TabIndex = 2
        '
        'cmbdia
        '
        Me.cmbdia.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "29"})
        Me.cmbdia.Location = New System.Drawing.Point(602, 24)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(58, 23)
        Me.cmbdia.TabIndex = 8
        '
        'cmbmes
        '
        Me.cmbmes.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "09"})
        Me.cmbmes.Location = New System.Drawing.Point(666, 24)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(116, 23)
        Me.cmbmes.TabIndex = 7
        '
        'cmbaño
        '
        Me.cmbaño.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2000", "2001", "2002", "2018"})
        Me.cmbaño.Location = New System.Drawing.Point(788, 24)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(68, 23)
        Me.cmbaño.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(678, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Filtrado por fecha"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(12, 23)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(274, 23)
        Me.txtbusqueda.TabIndex = 1
        Me.txtbusqueda.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtbusqueda.WaterMarkText = "Ingrese"
        '
        'Registroprestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 586)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbdia)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.cmbbusqueda)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.dgvregistro)
        Me.Name = "Registroprestamos"
        Me.Text = "Registroprestamos"
        CType(Me.dgvregistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvregistro As System.Windows.Forms.DataGridView
    Friend WithEvents txtbusqueda As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents cmbbusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
