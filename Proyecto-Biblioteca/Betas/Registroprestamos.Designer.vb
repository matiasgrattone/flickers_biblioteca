﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvregistro = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbdia2 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.cmbaño2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbbusqueda = New System.Windows.Forms.ComboBox()
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
        Me.dgvregistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvregistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvregistro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvregistro.ColumnHeadersHeight = 40
        Me.dgvregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvregistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvregistro.EnableHeadersVisualStyles = False
        Me.dgvregistro.Location = New System.Drawing.Point(5, 88)
        Me.dgvregistro.MultiSelect = False
        Me.dgvregistro.Name = "dgvregistro"
        Me.dgvregistro.ReadOnly = True
        Me.dgvregistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvregistro.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvregistro.RowHeadersVisible = False
        Me.dgvregistro.RowHeadersWidth = 50
        Me.dgvregistro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvregistro.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvregistro.RowTemplate.Height = 32
        Me.dgvregistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvregistro.Size = New System.Drawing.Size(859, 492)
        Me.dgvregistro.TabIndex = 81
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(589, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 23)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "Reiniciar Busqueda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Hasta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Filtrar por fecha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbdia2
        '
        Me.cmbdia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdia2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdia2.FormattingEnabled = True
        Me.cmbdia2.Location = New System.Drawing.Point(303, 59)
        Me.cmbdia2.Name = "cmbdia2"
        Me.cmbdia2.Size = New System.Drawing.Size(58, 23)
        Me.cmbdia2.TabIndex = 77
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Location = New System.Drawing.Point(367, 59)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(116, 23)
        Me.cmbmes2.TabIndex = 76
        '
        'cmbaño2
        '
        Me.cmbaño2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaño2.FormattingEnabled = True
        Me.cmbaño2.Location = New System.Drawing.Point(489, 59)
        Me.cmbaño2.Name = "cmbaño2"
        Me.cmbaño2.Size = New System.Drawing.Size(68, 23)
        Me.cmbaño2.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Desde:"
        '
        'cmbdia
        '
        Me.cmbdia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdia.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Location = New System.Drawing.Point(13, 59)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(58, 23)
        Me.cmbdia.TabIndex = 73
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Location = New System.Drawing.Point(77, 59)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(116, 23)
        Me.cmbmes.TabIndex = 72
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Location = New System.Drawing.Point(199, 59)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(68, 23)
        Me.cmbaño.TabIndex = 71
        '
        'cmbbusqueda
        '
        Me.cmbbusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbusqueda.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbusqueda.FormattingEnabled = True
        Me.cmbbusqueda.Items.AddRange(New Object() {"Cedula de Socio", "Nombre de Socio", "Codigo de Inventario", "Titulo de Libro"})
        Me.cmbbusqueda.Location = New System.Drawing.Point(293, 6)
        Me.cmbbusqueda.Name = "cmbbusqueda"
        Me.cmbbusqueda.Size = New System.Drawing.Size(194, 23)
        Me.cmbbusqueda.TabIndex = 70
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(13, 6)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(274, 23)
        Me.txtbusqueda.TabIndex = 69
        Me.txtbusqueda.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtbusqueda.WaterMarkText = "Ingrese"
        '
        'Registroprestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(868, 586)
        Me.Controls.Add(Me.dgvregistro)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbdia2)
        Me.Controls.Add(Me.cmbmes2)
        Me.Controls.Add(Me.cmbaño2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbdia)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.cmbbusqueda)
        Me.Controls.Add(Me.txtbusqueda)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Registroprestamos"
        Me.Text = "Registroprestamos"
        CType(Me.dgvregistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvregistro As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbdia2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbaño2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents txtbusqueda As Proyecto_Biblioteca.PlaceHolder
End Class
