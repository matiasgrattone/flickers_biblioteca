<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichaSocio
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.LabelNombretxt = New System.Windows.Forms.Label()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_TIPO_txt = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(738, 423)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(91, 26)
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.HolaToolStripMenuItem.Text = "Ver"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.boss
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.Location = New System.Drawing.Point(146, 66)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(94, 20)
        Me.LabelDireccion.TabIndex = 4
        Me.LabelDireccion.Text = "Direccion :"
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMail.Location = New System.Drawing.Point(146, 115)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(56, 20)
        Me.LabelMail.TabIndex = 5
        Me.LabelMail.Text = "Mail : "
        '
        'LabelCedula
        '
        Me.LabelCedula.AutoSize = True
        Me.LabelCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedula.Location = New System.Drawing.Point(146, 43)
        Me.LabelCedula.Name = "LabelCedula"
        Me.LabelCedula.Size = New System.Drawing.Size(75, 20)
        Me.LabelCedula.TabIndex = 6
        Me.LabelCedula.Text = "Cedula :"
        '
        'LabelNombretxt
        '
        Me.LabelNombretxt.AutoSize = True
        Me.LabelNombretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombretxt.Location = New System.Drawing.Point(145, 8)
        Me.LabelNombretxt.Name = "LabelNombretxt"
        Me.LabelNombretxt.Size = New System.Drawing.Size(88, 24)
        Me.LabelNombretxt.TabIndex = 7
        Me.LabelNombretxt.Text = "............."
        '
        'LabelDirecciontxt
        '
        Me.LabelDirecciontxt.AutoSize = True
        Me.LabelDirecciontxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDirecciontxt.Location = New System.Drawing.Point(237, 66)
        Me.LabelDirecciontxt.Name = "LabelDirecciontxt"
        Me.LabelDirecciontxt.Size = New System.Drawing.Size(74, 20)
        Me.LabelDirecciontxt.TabIndex = 9
        Me.LabelDirecciontxt.Text = "............."
        '
        'LabelMailtxt
        '
        Me.LabelMailtxt.AutoSize = True
        Me.LabelMailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMailtxt.Location = New System.Drawing.Point(195, 116)
        Me.LabelMailtxt.Name = "LabelMailtxt"
        Me.LabelMailtxt.Size = New System.Drawing.Size(74, 20)
        Me.LabelMailtxt.TabIndex = 10
        Me.LabelMailtxt.Text = "............."
        '
        'LabelCedulatxt
        '
        Me.LabelCedulatxt.AutoSize = True
        Me.LabelCedulatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedulatxt.Location = New System.Drawing.Point(220, 43)
        Me.LabelCedulatxt.Name = "LabelCedulatxt"
        Me.LabelCedulatxt.Size = New System.Drawing.Size(74, 20)
        Me.LabelCedulatxt.TabIndex = 11
        Me.LabelCedulatxt.Text = "............."
        '
        'LabelEstadotxt
        '
        Me.LabelEstadotxt.AutoSize = True
        Me.LabelEstadotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadotxt.Location = New System.Drawing.Point(852, 11)
        Me.LabelEstadotxt.Name = "LabelEstadotxt"
        Me.LabelEstadotxt.Size = New System.Drawing.Size(81, 20)
        Me.LabelEstadotxt.TabIndex = 12
        Me.LabelEstadotxt.Text = "ESTADO"
        '
        'PictureBoxEstado
        '
        Me.PictureBoxEstado.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxEstado.Location = New System.Drawing.Point(860, 38)
        Me.PictureBoxEstado.Name = "PictureBoxEstado"
        Me.PictureBoxEstado.Size = New System.Drawing.Size(66, 68)
        Me.PictureBoxEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEstado.TabIndex = 13
        Me.PictureBoxEstado.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(612, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ultima Vez Moroso : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(7, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 428)
        Me.Panel1.TabIndex = 15
        '
        'ListBoxLibros
        '
        Me.ListBoxLibros.FormattingEnabled = True
        Me.ListBoxLibros.Location = New System.Drawing.Point(759, 135)
        Me.ListBoxLibros.Name = "ListBoxLibros"
        Me.ListBoxLibros.Size = New System.Drawing.Size(184, 485)
        Me.ListBoxLibros.TabIndex = 16
        '
        'LabelLibrosPoder
        '
        Me.LabelLibrosPoder.AutoSize = True
        Me.LabelLibrosPoder.Location = New System.Drawing.Point(858, 117)
        Me.LabelLibrosPoder.Name = "LabelLibrosPoder"
        Me.LabelLibrosPoder.Size = New System.Drawing.Size(82, 13)
        Me.LabelLibrosPoder.TabIndex = 17
        Me.LabelLibrosPoder.Text = "Libros En Poder"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(7, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 146)
        Me.Panel2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Historial : "
        '
        'LabelFechaUltimaVez
        '
        Me.LabelFechaUltimaVez.AutoSize = True
        Me.LabelFechaUltimaVez.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaUltimaVez.Location = New System.Drawing.Point(745, 4)
        Me.LabelFechaUltimaVez.Name = "LabelFechaUltimaVez"
        Me.LabelFechaUltimaVez.Size = New System.Drawing.Size(95, 15)
        Me.LabelFechaUltimaVez.TabIndex = 20
        Me.LabelFechaUltimaVez.Text = "......................"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(756, 132)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 501)
        Me.Panel3.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 6000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Enviar Mail"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label_TIPO_txt
        '
        Me.Label_TIPO_txt.AutoSize = True
        Me.Label_TIPO_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TIPO_txt.Location = New System.Drawing.Point(149, 92)
        Me.Label_TIPO_txt.Name = "Label_TIPO_txt"
        Me.Label_TIPO_txt.Size = New System.Drawing.Size(109, 20)
        Me.Label_TIPO_txt.TabIndex = 26
        Me.Label_TIPO_txt.Text = "...................."
        '
        'cmbaño
        '
        Me.cmbaño.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Location = New System.Drawing.Point(683, 163)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(68, 23)
        Me.cmbaño.TabIndex = 21
        '
        'cmbmes
        '
        Me.cmbmes.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Location = New System.Drawing.Point(561, 163)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(116, 23)
        Me.cmbmes.TabIndex = 22
        '
        'cmbdia
        '
        Me.cmbdia.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Location = New System.Drawing.Point(497, 163)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(58, 23)
        Me.cmbdia.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Filtrado por fecha"
        '
        'FichaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 622)
        Me.Controls.Add(Me.Label_TIPO_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbdia)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.cmbaño)
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
        Me.Controls.Add(Me.LabelNombretxt)
        Me.Controls.Add(Me.LabelCedula)
        Me.Controls.Add(Me.LabelMail)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FichaSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroSocio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelMail As System.Windows.Forms.Label
    Friend WithEvents LabelCedula As System.Windows.Forms.Label
    Friend WithEvents LabelNombretxt As System.Windows.Forms.Label
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label_TIPO_txt As System.Windows.Forms.Label
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
