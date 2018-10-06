<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichaParaImprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FichaParaImprimir))
        Me.DataGridViewRegistro = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelFecha = New Proyecto_Biblioteca.labels_transparentes()
        Me.LabelNombreSocio = New Proyecto_Biblioteca.labels_transparentes()
        Me.Labels_transparentes2 = New Proyecto_Biblioteca.labels_transparentes()
        Me.Labels_transparentes1 = New Proyecto_Biblioteca.labels_transparentes()
        CType(Me.DataGridViewRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewRegistro
        '
        Me.DataGridViewRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRegistro.Location = New System.Drawing.Point(12, 58)
        Me.DataGridViewRegistro.Name = "DataGridViewRegistro"
        Me.DataGridViewRegistro.ReadOnly = True
        Me.DataGridViewRegistro.Size = New System.Drawing.Size(623, 513)
        Me.DataGridViewRegistro.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelFecha)
        Me.Panel1.Controls.Add(Me.LabelNombreSocio)
        Me.Panel1.Controls.Add(Me.Labels_transparentes2)
        Me.Panel1.Controls.Add(Me.Labels_transparentes1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 53)
        Me.Panel1.TabIndex = 1
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LabelFecha
        '
        Me.LabelFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.Color.White
        Me.LabelFecha.Location = New System.Drawing.Point(516, 3)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(120, 23)
        Me.LabelFecha.TabIndex = 6
        Me.LabelFecha.Text = "Fecha:"
        '
        'LabelNombreSocio
        '
        Me.LabelNombreSocio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreSocio.ForeColor = System.Drawing.Color.White
        Me.LabelNombreSocio.Location = New System.Drawing.Point(125, 27)
        Me.LabelNombreSocio.Name = "LabelNombreSocio"
        Me.LabelNombreSocio.Size = New System.Drawing.Size(194, 23)
        Me.LabelNombreSocio.TabIndex = 5
        Me.LabelNombreSocio.Text = """...."""
        '
        'Labels_transparentes2
        '
        Me.Labels_transparentes2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labels_transparentes2.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes2.Location = New System.Drawing.Point(3, 27)
        Me.Labels_transparentes2.Name = "Labels_transparentes2"
        Me.Labels_transparentes2.Size = New System.Drawing.Size(194, 23)
        Me.Labels_transparentes2.TabIndex = 4
        Me.Labels_transparentes2.Text = "Registro del socio:"
        '
        'Labels_transparentes1
        '
        Me.Labels_transparentes1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Labels_transparentes1.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes1.Location = New System.Drawing.Point(3, 3)
        Me.Labels_transparentes1.Name = "Labels_transparentes1"
        Me.Labels_transparentes1.Size = New System.Drawing.Size(194, 23)
        Me.Labels_transparentes1.TabIndex = 4
        Me.Labels_transparentes1.Text = "Biblioteca Municipal"
        '
        'FichaParaImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FichaParaImprimir"
        Me.Text = "FichaParaImprimir"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.DataGridViewRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewRegistro As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelFecha As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents LabelNombreSocio As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents Labels_transparentes2 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents Labels_transparentes1 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
