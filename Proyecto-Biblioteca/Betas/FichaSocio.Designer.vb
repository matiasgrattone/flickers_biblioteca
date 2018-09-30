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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.LabelNombretxt = New System.Windows.Forms.Label()
        Me.LabelDirecciontxt = New System.Windows.Forms.Label()
        Me.LabelMailtxt = New System.Windows.Forms.Label()
        Me.LabelCedulatxt = New System.Windows.Forms.Label()
        Me.LabelEstadotxt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelLibrosPoder = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelFechaUltimaVez = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewLibros = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_TIPO_txt = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_Telefono_txt = New System.Windows.Forms.Label()
        Me.Label_Telefono = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxEstado = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelFecha_Ingreso = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(753, 422)
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
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.Location = New System.Drawing.Point(185, 63)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(94, 20)
        Me.LabelDireccion.TabIndex = 4
        Me.LabelDireccion.Text = "Direccion :"
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMail.Location = New System.Drawing.Point(185, 116)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(56, 20)
        Me.LabelMail.TabIndex = 5
        Me.LabelMail.Text = "Mail : "
        '
        'LabelCedula
        '
        Me.LabelCedula.AutoSize = True
        Me.LabelCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedula.Location = New System.Drawing.Point(185, 40)
        Me.LabelCedula.Name = "LabelCedula"
        Me.LabelCedula.Size = New System.Drawing.Size(75, 20)
        Me.LabelCedula.TabIndex = 6
        Me.LabelCedula.Text = "Cedula :"
        '
        'LabelNombretxt
        '
        Me.LabelNombretxt.AutoSize = True
        Me.LabelNombretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombretxt.Location = New System.Drawing.Point(184, 5)
        Me.LabelNombretxt.Name = "LabelNombretxt"
        Me.LabelNombretxt.Size = New System.Drawing.Size(88, 24)
        Me.LabelNombretxt.TabIndex = 7
        Me.LabelNombretxt.Text = "............."
        '
        'LabelDirecciontxt
        '
        Me.LabelDirecciontxt.AutoSize = True
        Me.LabelDirecciontxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDirecciontxt.Location = New System.Drawing.Point(276, 63)
        Me.LabelDirecciontxt.Name = "LabelDirecciontxt"
        Me.LabelDirecciontxt.Size = New System.Drawing.Size(74, 20)
        Me.LabelDirecciontxt.TabIndex = 9
        Me.LabelDirecciontxt.Text = "............."
        '
        'LabelMailtxt
        '
        Me.LabelMailtxt.AutoSize = True
        Me.LabelMailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMailtxt.Location = New System.Drawing.Point(234, 117)
        Me.LabelMailtxt.Name = "LabelMailtxt"
        Me.LabelMailtxt.Size = New System.Drawing.Size(74, 20)
        Me.LabelMailtxt.TabIndex = 10
        Me.LabelMailtxt.Text = "............."
        '
        'LabelCedulatxt
        '
        Me.LabelCedulatxt.AutoSize = True
        Me.LabelCedulatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedulatxt.Location = New System.Drawing.Point(259, 40)
        Me.LabelCedulatxt.Name = "LabelCedulatxt"
        Me.LabelCedulatxt.Size = New System.Drawing.Size(74, 20)
        Me.LabelCedulatxt.TabIndex = 11
        Me.LabelCedulatxt.Text = "............."
        '
        'LabelEstadotxt
        '
        Me.LabelEstadotxt.AutoSize = True
        Me.LabelEstadotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadotxt.Location = New System.Drawing.Point(857, 8)
        Me.LabelEstadotxt.Name = "LabelEstadotxt"
        Me.LabelEstadotxt.Size = New System.Drawing.Size(81, 20)
        Me.LabelEstadotxt.TabIndex = 12
        Me.LabelEstadotxt.Text = "ESTADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(617, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ultima Vez Moroso : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(5, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 428)
        Me.Panel1.TabIndex = 15
        '
        'LabelLibrosPoder
        '
        Me.LabelLibrosPoder.AutoSize = True
        Me.LabelLibrosPoder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLibrosPoder.Location = New System.Drawing.Point(847, 119)
        Me.LabelLibrosPoder.Name = "LabelLibrosPoder"
        Me.LabelLibrosPoder.Size = New System.Drawing.Size(97, 13)
        Me.LabelLibrosPoder.TabIndex = 17
        Me.LabelLibrosPoder.Text = "Libros En Poder"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(46, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 146)
        Me.Panel2.TabIndex = 18
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Historial : "
        '
        'LabelFechaUltimaVez
        '
        Me.LabelFechaUltimaVez.AutoSize = True
        Me.LabelFechaUltimaVez.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaUltimaVez.Location = New System.Drawing.Point(750, 1)
        Me.LabelFechaUltimaVez.Name = "LabelFechaUltimaVez"
        Me.LabelFechaUltimaVez.Size = New System.Drawing.Size(95, 15)
        Me.LabelFechaUltimaVez.TabIndex = 20
        Me.LabelFechaUltimaVez.Text = "......................"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.DataGridViewLibros)
        Me.Panel3.Location = New System.Drawing.Point(767, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(188, 489)
        Me.Panel3.TabIndex = 16
        '
        'DataGridViewLibros
        '
        Me.DataGridViewLibros.AllowUserToAddRows = False
        Me.DataGridViewLibros.AllowUserToDeleteRows = False
        Me.DataGridViewLibros.AllowUserToResizeColumns = False
        Me.DataGridViewLibros.AllowUserToResizeRows = False
        Me.DataGridViewLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLibros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewLibros.ColumnHeadersHeight = 35
        Me.DataGridViewLibros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewLibros.EnableHeadersVisualStyles = False
        Me.DataGridViewLibros.Location = New System.Drawing.Point(2, 1)
        Me.DataGridViewLibros.Name = "DataGridViewLibros"
        Me.DataGridViewLibros.ReadOnly = True
        Me.DataGridViewLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLibros.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewLibros.RowHeadersVisible = False
        Me.DataGridViewLibros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.DataGridViewLibros.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewLibros.Size = New System.Drawing.Size(185, 486)
        Me.DataGridViewLibros.TabIndex = 29
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 6000
        '
        'Label_TIPO_txt
        '
        Me.Label_TIPO_txt.AutoSize = True
        Me.Label_TIPO_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TIPO_txt.Location = New System.Drawing.Point(188, 89)
        Me.Label_TIPO_txt.Name = "Label_TIPO_txt"
        Me.Label_TIPO_txt.Size = New System.Drawing.Size(109, 20)
        Me.Label_TIPO_txt.TabIndex = 26
        Me.Label_TIPO_txt.Text = "...................."
        '
        'cmbaño
        '
        Me.cmbaño.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Location = New System.Drawing.Point(688, 172)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(68, 23)
        Me.cmbaño.TabIndex = 21
        '
        'cmbmes
        '
        Me.cmbmes.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Location = New System.Drawing.Point(566, 172)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(116, 23)
        Me.cmbmes.TabIndex = 22
        '
        'cmbdia
        '
        Me.cmbdia.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Location = New System.Drawing.Point(502, 172)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(58, 23)
        Me.cmbdia.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Filtrado por fecha"
        '
        'Label_Telefono_txt
        '
        Me.Label_Telefono_txt.AutoSize = True
        Me.Label_Telefono_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Telefono_txt.Location = New System.Drawing.Point(271, 144)
        Me.Label_Telefono_txt.Name = "Label_Telefono_txt"
        Me.Label_Telefono_txt.Size = New System.Drawing.Size(74, 20)
        Me.Label_Telefono_txt.TabIndex = 28
        Me.Label_Telefono_txt.Text = "............."
        '
        'Label_Telefono
        '
        Me.Label_Telefono.AutoSize = True
        Me.Label_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Telefono.Location = New System.Drawing.Point(183, 144)
        Me.Label_Telefono.Name = "Label_Telefono"
        Me.Label_Telefono.Size = New System.Drawing.Size(89, 20)
        Me.Label_Telefono.TabIndex = 27
        Me.Label_Telefono.Text = "Telefono :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(957, 33)
        Me.Panel4.TabIndex = 29
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PictureBox4.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.cancel
        Me.PictureBox4.Location = New System.Drawing.Point(926, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.printer_
        Me.PictureBox3.Location = New System.Drawing.Point(5, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.gmail_logo
        Me.PictureBox2.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBoxEstado
        '
        Me.PictureBoxEstado.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxEstado.Location = New System.Drawing.Point(865, 35)
        Me.PictureBoxEstado.Name = "PictureBoxEstado"
        Me.PictureBoxEstado.Size = New System.Drawing.Size(66, 68)
        Me.PictureBoxEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEstado.TabIndex = 13
        Me.PictureBoxEstado.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.LabelFecha_Ingreso)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Label_Telefono_txt)
        Me.Panel5.Controls.Add(Me.Label_Telefono)
        Me.Panel5.Controls.Add(Me.Label_TIPO_txt)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cmbdia)
        Me.Panel5.Controls.Add(Me.cmbmes)
        Me.Panel5.Controls.Add(Me.cmbaño)
        Me.Panel5.Controls.Add(Me.LabelFechaUltimaVez)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.LabelLibrosPoder)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.PictureBoxEstado)
        Me.Panel5.Controls.Add(Me.LabelEstadotxt)
        Me.Panel5.Controls.Add(Me.LabelCedulatxt)
        Me.Panel5.Controls.Add(Me.LabelMailtxt)
        Me.Panel5.Controls.Add(Me.LabelDirecciontxt)
        Me.Panel5.Controls.Add(Me.LabelNombretxt)
        Me.Panel5.Controls.Add(Me.LabelCedula)
        Me.Panel5.Controls.Add(Me.LabelMail)
        Me.Panel5.Controls.Add(Me.LabelDireccion)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Location = New System.Drawing.Point(1, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(957, 628)
        Me.Panel5.TabIndex = 32
        '
        'LabelFecha_Ingreso
        '
        Me.LabelFecha_Ingreso.AutoSize = True
        Me.LabelFecha_Ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha_Ingreso.Location = New System.Drawing.Point(753, 20)
        Me.LabelFecha_Ingreso.Name = "LabelFecha_Ingreso"
        Me.LabelFecha_Ingreso.Size = New System.Drawing.Size(95, 15)
        Me.LabelFecha_Ingreso.TabIndex = 33
        Me.LabelFecha_Ingreso.Text = "......................"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(645, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Fecha_Ingreso : "
        '
        'FichaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(959, 662)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FichaSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents LabelLibrosPoder As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelFechaUltimaVez As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_TIPO_txt As System.Windows.Forms.Label
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_Telefono_txt As System.Windows.Forms.Label
    Friend WithEvents Label_Telefono As System.Windows.Forms.Label
    Friend WithEvents DataGridViewLibros As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LabelFecha_Ingreso As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
