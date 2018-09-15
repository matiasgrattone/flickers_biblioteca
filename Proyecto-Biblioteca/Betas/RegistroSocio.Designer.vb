<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroSocio
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.LabelNombretxt = New System.Windows.Forms.Label()
        Me.LabelApellidotxt = New System.Windows.Forms.Label()
        Me.LabelDirecciontxt = New System.Windows.Forms.Label()
        Me.LabelMailtxt = New System.Windows.Forms.Label()
        Me.LabelCedulatxt = New System.Windows.Forms.Label()
        Me.LabelEstadotxt = New System.Windows.Forms.Label()
        Me.PictureBoxEstado = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBoxLibros = New System.Windows.Forms.ListBox()
        Me.LabelLibrosPoder = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelFechaUltimaVez = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(536, 428)
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 142)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(549, 11)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(50, 13)
        Me.LabelNombre.TabIndex = 2
        Me.LabelNombre.Text = "Nombre :"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Location = New System.Drawing.Point(549, 35)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(50, 13)
        Me.LabelApellido.TabIndex = 3
        Me.LabelApellido.Text = "Apellido :"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Location = New System.Drawing.Point(549, 62)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(58, 13)
        Me.LabelDireccion.TabIndex = 4
        Me.LabelDireccion.Text = "Direccion :"
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Location = New System.Drawing.Point(549, 88)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(35, 13)
        Me.LabelMail.TabIndex = 5
        Me.LabelMail.Text = "Mail : "
        '
        'LabelCedula
        '
        Me.LabelCedula.AutoSize = True
        Me.LabelCedula.Location = New System.Drawing.Point(549, 114)
        Me.LabelCedula.Name = "LabelCedula"
        Me.LabelCedula.Size = New System.Drawing.Size(46, 13)
        Me.LabelCedula.TabIndex = 6
        Me.LabelCedula.Text = "Cedula :"
        '
        'LabelNombretxt
        '
        Me.LabelNombretxt.AutoSize = True
        Me.LabelNombretxt.Location = New System.Drawing.Point(627, 11)
        Me.LabelNombretxt.Name = "LabelNombretxt"
        Me.LabelNombretxt.Size = New System.Drawing.Size(46, 13)
        Me.LabelNombretxt.TabIndex = 7
        Me.LabelNombretxt.Text = "............."
        '
        'LabelApellidotxt
        '
        Me.LabelApellidotxt.AutoSize = True
        Me.LabelApellidotxt.Location = New System.Drawing.Point(627, 35)
        Me.LabelApellidotxt.Name = "LabelApellidotxt"
        Me.LabelApellidotxt.Size = New System.Drawing.Size(46, 13)
        Me.LabelApellidotxt.TabIndex = 8
        Me.LabelApellidotxt.Text = "............."
        '
        'LabelDirecciontxt
        '
        Me.LabelDirecciontxt.AutoSize = True
        Me.LabelDirecciontxt.Location = New System.Drawing.Point(627, 62)
        Me.LabelDirecciontxt.Name = "LabelDirecciontxt"
        Me.LabelDirecciontxt.Size = New System.Drawing.Size(46, 13)
        Me.LabelDirecciontxt.TabIndex = 9
        Me.LabelDirecciontxt.Text = "............."
        '
        'LabelMailtxt
        '
        Me.LabelMailtxt.AutoSize = True
        Me.LabelMailtxt.Location = New System.Drawing.Point(627, 88)
        Me.LabelMailtxt.Name = "LabelMailtxt"
        Me.LabelMailtxt.Size = New System.Drawing.Size(46, 13)
        Me.LabelMailtxt.TabIndex = 10
        Me.LabelMailtxt.Text = "............."
        '
        'LabelCedulatxt
        '
        Me.LabelCedulatxt.AutoSize = True
        Me.LabelCedulatxt.Location = New System.Drawing.Point(627, 114)
        Me.LabelCedulatxt.Name = "LabelCedulatxt"
        Me.LabelCedulatxt.Size = New System.Drawing.Size(46, 13)
        Me.LabelCedulatxt.TabIndex = 11
        Me.LabelCedulatxt.Text = "............."
        '
        'LabelEstadotxt
        '
        Me.LabelEstadotxt.AutoSize = True
        Me.LabelEstadotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadotxt.Location = New System.Drawing.Point(9, 4)
        Me.LabelEstadotxt.Name = "LabelEstadotxt"
        Me.LabelEstadotxt.Size = New System.Drawing.Size(81, 20)
        Me.LabelEstadotxt.TabIndex = 12
        Me.LabelEstadotxt.Text = "ESTADO"
        '
        'PictureBoxEstado
        '
        Me.PictureBoxEstado.Location = New System.Drawing.Point(13, 35)
        Me.PictureBoxEstado.Name = "PictureBoxEstado"
        Me.PictureBoxEstado.Size = New System.Drawing.Size(66, 68)
        Me.PictureBoxEstado.TabIndex = 13
        Me.PictureBoxEstado.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ultima Vez Moroso : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(7, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 394)
        Me.Panel1.TabIndex = 15
        '
        'ListBoxLibros
        '
        Me.ListBoxLibros.FormattingEnabled = True
        Me.ListBoxLibros.Location = New System.Drawing.Point(636, 194)
        Me.ListBoxLibros.Name = "ListBoxLibros"
        Me.ListBoxLibros.Size = New System.Drawing.Size(185, 394)
        Me.ListBoxLibros.TabIndex = 16
        '
        'LabelLibrosPoder
        '
        Me.LabelLibrosPoder.AutoSize = True
        Me.LabelLibrosPoder.Location = New System.Drawing.Point(739, 171)
        Me.LabelLibrosPoder.Name = "LabelLibrosPoder"
        Me.LabelLibrosPoder.Size = New System.Drawing.Size(82, 13)
        Me.LabelLibrosPoder.TabIndex = 17
        Me.LabelLibrosPoder.Text = "Libros En Poder"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(685, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 146)
        Me.Panel2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Historial : "
        '
        'LabelFechaUltimaVez
        '
        Me.LabelFechaUltimaVez.AutoSize = True
        Me.LabelFechaUltimaVez.Location = New System.Drawing.Point(117, 124)
        Me.LabelFechaUltimaVez.Name = "LabelFechaUltimaVez"
        Me.LabelFechaUltimaVez.Size = New System.Drawing.Size(73, 13)
        Me.LabelFechaUltimaVez.TabIndex = 20
        Me.LabelFechaUltimaVez.Text = "......................"
        '
        'RegistroSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 588)
        Me.Controls.Add(Me.LabelFechaUltimaVez)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelLibrosPoder)
        Me.Controls.Add(Me.ListBoxLibros)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxEstado)
        Me.Controls.Add(Me.LabelEstadotxt)
        Me.Controls.Add(Me.LabelCedulatxt)
        Me.Controls.Add(Me.LabelMailtxt)
        Me.Controls.Add(Me.LabelDirecciontxt)
        Me.Controls.Add(Me.LabelApellidotxt)
        Me.Controls.Add(Me.LabelNombretxt)
        Me.Controls.Add(Me.LabelCedula)
        Me.Controls.Add(Me.LabelMail)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Name = "RegistroSocio"
        Me.Text = "RegistroSocio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelApellido As System.Windows.Forms.Label
    Friend WithEvents LabelDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelMail As System.Windows.Forms.Label
    Friend WithEvents LabelCedula As System.Windows.Forms.Label
    Friend WithEvents LabelNombretxt As System.Windows.Forms.Label
    Friend WithEvents LabelApellidotxt As System.Windows.Forms.Label
    Friend WithEvents LabelDirecciontxt As System.Windows.Forms.Label
    Friend WithEvents LabelMailtxt As System.Windows.Forms.Label
    Friend WithEvents LabelCedulatxt As System.Windows.Forms.Label
    Friend WithEvents LabelEstadotxt As System.Windows.Forms.Label
    Friend WithEvents PictureBoxEstado As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBoxLibros As System.Windows.Forms.ListBox
    Friend WithEvents LabelLibrosPoder As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelFechaUltimaVez As System.Windows.Forms.Label
End Class
