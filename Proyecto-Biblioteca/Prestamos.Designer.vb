﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestamos
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LIBROSAGG = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NOMBRE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDAGG = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OPA = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.devoCOMBO = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridAGG = New System.Windows.Forms.DataGridView()
        Me.ENPODER = New System.Windows.Forms.Label()
        Me.ExtCombo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LIBROS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VERLIBROSAGG = New System.Windows.Forms.DataGridView()
        Me.ReservacionComboBox = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.VerLibrosReservados = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureCrearRes3 = New System.Windows.Forms.PictureBox()
        Me.PictureReservacion4 = New System.Windows.Forms.PictureBox()
        Me.PictureDevolucion2 = New System.Windows.Forms.PictureBox()
        Me.PictureExtraccion1 = New System.Windows.Forms.PictureBox()
        Me.CrearReservacionComboBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LibrosParaReservar = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Aparecer = New System.Windows.Forms.Timer(Me.components)
        Me.Ocultar = New System.Windows.Forms.Timer(Me.components)
        Me.Ocultar_Aparecer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.devoCOMBO.SuspendLayout()
        CType(Me.DataGridAGG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExtCombo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VERLIBROSAGG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReservacionComboBox.SuspendLayout()
        CType(Me.VerLibrosReservados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureCrearRes3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureReservacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureDevolucion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureExtraccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CrearReservacionComboBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosParaReservar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(628, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 52)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "EXTRAER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 21)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.LIBROSAGG)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.NOMBRE)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.IDAGG)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.OPA)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(-265, -28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 676)
        Me.Panel1.TabIndex = 73
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(17, 631)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 29)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Moroso"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LIBROSAGG
        '
        Me.LIBROSAGG.FormattingEnabled = True
        Me.LIBROSAGG.Location = New System.Drawing.Point(9, 228)
        Me.LIBROSAGG.Name = "LIBROSAGG"
        Me.LIBROSAGG.Size = New System.Drawing.Size(249, 381)
        Me.LIBROSAGG.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Label4"
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSize = True
        Me.NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.NOMBRE.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE.ForeColor = System.Drawing.Color.Black
        Me.NOMBRE.Location = New System.Drawing.Point(18, 144)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(90, 29)
        Me.NOMBRE.TabIndex = 60
        Me.NOMBRE.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Label2"
        '
        'IDAGG
        '
        Me.IDAGG.FormattingEnabled = True
        Me.IDAGG.Location = New System.Drawing.Point(111, 384)
        Me.IDAGG.Name = "IDAGG"
        Me.IDAGG.Size = New System.Drawing.Size(33, 30)
        Me.IDAGG.TabIndex = 64
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(171, 631)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 29)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Liberar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 384)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(34, 30)
        Me.DataGridView1.TabIndex = 56
        '
        'OPA
        '
        Me.OPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OPA.Location = New System.Drawing.Point(71, 343)
        Me.OPA.Name = "OPA"
        Me.OPA.Size = New System.Drawing.Size(32, 23)
        Me.OPA.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(124, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "LIBRO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(19, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 20)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "ID "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "INGRESE LA CEDULA DEL USUARIO "
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(6, 53)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(259, 20)
        Me.Cedula.TabIndex = 57
        '
        'devoCOMBO
        '
        Me.devoCOMBO.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.devoCOMBO.Controls.Add(Me.Button4)
        Me.devoCOMBO.Controls.Add(Me.Button5)
        Me.devoCOMBO.Controls.Add(Me.Label11)
        Me.devoCOMBO.Controls.Add(Me.DataGridAGG)
        Me.devoCOMBO.Controls.Add(Me.ENPODER)
        Me.devoCOMBO.Location = New System.Drawing.Point(263, 98)
        Me.devoCOMBO.Name = "devoCOMBO"
        Me.devoCOMBO.Size = New System.Drawing.Size(738, 547)
        Me.devoCOMBO.TabIndex = 67
        Me.devoCOMBO.TabStop = False
        Me.devoCOMBO.Text = "DEVOLUCION"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(622, 290)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 34)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Ver registro"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(622, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 34)
        Me.Button5.TabIndex = 63
        Me.Button5.Text = "Modo devolucion"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.Label11.Location = New System.Drawing.Point(567, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 34)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "DEVOLUCION"
        '
        'DataGridAGG
        '
        Me.DataGridAGG.AllowUserToAddRows = False
        Me.DataGridAGG.AllowUserToDeleteRows = False
        Me.DataGridAGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAGG.Location = New System.Drawing.Point(5, 75)
        Me.DataGridAGG.Name = "DataGridAGG"
        Me.DataGridAGG.ReadOnly = True
        Me.DataGridAGG.RowHeadersVisible = False
        Me.DataGridAGG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAGG.Size = New System.Drawing.Size(603, 466)
        Me.DataGridAGG.TabIndex = 0
        '
        'ENPODER
        '
        Me.ENPODER.AutoSize = True
        Me.ENPODER.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENPODER.ForeColor = System.Drawing.Color.DarkViolet
        Me.ENPODER.Location = New System.Drawing.Point(12, 20)
        Me.ENPODER.Name = "ENPODER"
        Me.ENPODER.Size = New System.Drawing.Size(187, 34)
        Me.ENPODER.TabIndex = 61
        Me.ENPODER.Text = "Libros en poder"
        '
        'ExtCombo
        '
        Me.ExtCombo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExtCombo.Controls.Add(Me.PictureBox1)
        Me.ExtCombo.Controls.Add(Me.Label7)
        Me.ExtCombo.Controls.Add(Me.Label3)
        Me.ExtCombo.Controls.Add(Me.Label10)
        Me.ExtCombo.Controls.Add(Me.Button2)
        Me.ExtCombo.Controls.Add(Me.LIBROS)
        Me.ExtCombo.Controls.Add(Me.Label6)
        Me.ExtCombo.Controls.Add(Me.VERLIBROSAGG)
        Me.ExtCombo.Location = New System.Drawing.Point(263, 98)
        Me.ExtCombo.Name = "ExtCombo"
        Me.ExtCombo.Size = New System.Drawing.Size(737, 550)
        Me.ExtCombo.TabIndex = 66
        Me.ExtCombo.TabStop = False
        Me.ExtCombo.Text = "EXTRACCION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.busqueda
        Me.PictureBox1.Location = New System.Drawing.Point(458, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.Label7.Location = New System.Drawing.Point(566, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 34)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "EXTRACCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label3.Location = New System.Drawing.Point(14, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 34)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Libros disponibles "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(17, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ID"
        '
        'LIBROS
        '
        Me.LIBROS.Location = New System.Drawing.Point(44, 49)
        Me.LIBROS.Name = "LIBROS"
        Me.LIBROS.Size = New System.Drawing.Size(413, 20)
        Me.LIBROS.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(17, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "BUSCAR LIBRO"
        '
        'VERLIBROSAGG
        '
        Me.VERLIBROSAGG.AllowUserToAddRows = False
        Me.VERLIBROSAGG.AllowUserToDeleteRows = False
        Me.VERLIBROSAGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VERLIBROSAGG.Location = New System.Drawing.Point(4, 140)
        Me.VERLIBROSAGG.Name = "VERLIBROSAGG"
        Me.VERLIBROSAGG.ReadOnly = True
        Me.VERLIBROSAGG.RowHeadersVisible = False
        Me.VERLIBROSAGG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VERLIBROSAGG.Size = New System.Drawing.Size(618, 401)
        Me.VERLIBROSAGG.TabIndex = 17
        '
        'ReservacionComboBox
        '
        Me.ReservacionComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReservacionComboBox.Controls.Add(Me.Button8)
        Me.ReservacionComboBox.Controls.Add(Me.Label18)
        Me.ReservacionComboBox.Controls.Add(Me.Label19)
        Me.ReservacionComboBox.Controls.Add(Me.Button7)
        Me.ReservacionComboBox.Controls.Add(Me.VerLibrosReservados)
        Me.ReservacionComboBox.Location = New System.Drawing.Point(263, 99)
        Me.ReservacionComboBox.Name = "ReservacionComboBox"
        Me.ReservacionComboBox.Size = New System.Drawing.Size(737, 546)
        Me.ReservacionComboBox.TabIndex = 77
        Me.ReservacionComboBox.TabStop = False
        Me.ReservacionComboBox.Text = "RESERVADOS"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(590, 233)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(138, 44)
        Me.Button8.TabIndex = 80
        Me.Button8.Text = "Eliminar Reservacion"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.Label18.Location = New System.Drawing.Point(582, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 34)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "RESERVADOS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.Label19.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label19.Location = New System.Drawing.Point(14, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(217, 34)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "Libros reservados"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(590, 157)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(138, 52)
        Me.Button7.TabIndex = 75
        Me.Button7.Text = "EXTRAER"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'VerLibrosReservados
        '
        Me.VerLibrosReservados.AllowUserToAddRows = False
        Me.VerLibrosReservados.AllowUserToDeleteRows = False
        Me.VerLibrosReservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerLibrosReservados.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.VerLibrosReservados.Location = New System.Drawing.Point(4, 57)
        Me.VerLibrosReservados.Name = "VerLibrosReservados"
        Me.VerLibrosReservados.ReadOnly = True
        Me.VerLibrosReservados.RowHeadersVisible = False
        Me.VerLibrosReservados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VerLibrosReservados.Size = New System.Drawing.Size(576, 483)
        Me.VerLibrosReservados.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(924, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 45)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "SELECCION " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FUNCION "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Cedula)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.PictureCrearRes3)
        Me.Panel3.Controls.Add(Me.PictureReservacion4)
        Me.Panel3.Controls.Add(Me.PictureDevolucion2)
        Me.Panel3.Controls.Add(Me.PictureExtraccion1)
        Me.Panel3.Location = New System.Drawing.Point(-2, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1016, 112)
        Me.Panel3.TabIndex = 75
        '
        'PictureCrearRes3
        '
        Me.PictureCrearRes3.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.crear_reserva
        Me.PictureCrearRes3.Location = New System.Drawing.Point(763, 14)
        Me.PictureCrearRes3.Name = "PictureCrearRes3"
        Me.PictureCrearRes3.Size = New System.Drawing.Size(82, 85)
        Me.PictureCrearRes3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureCrearRes3.TabIndex = 3
        Me.PictureCrearRes3.TabStop = False
        '
        'PictureReservacion4
        '
        Me.PictureReservacion4.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.reservar
        Me.PictureReservacion4.Location = New System.Drawing.Point(624, 14)
        Me.PictureReservacion4.Name = "PictureReservacion4"
        Me.PictureReservacion4.Size = New System.Drawing.Size(82, 85)
        Me.PictureReservacion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureReservacion4.TabIndex = 2
        Me.PictureReservacion4.TabStop = False
        '
        'PictureDevolucion2
        '
        Me.PictureDevolucion2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.devolcion
        Me.PictureDevolucion2.Location = New System.Drawing.Point(485, 14)
        Me.PictureDevolucion2.Name = "PictureDevolucion2"
        Me.PictureDevolucion2.Size = New System.Drawing.Size(82, 85)
        Me.PictureDevolucion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureDevolucion2.TabIndex = 1
        Me.PictureDevolucion2.TabStop = False
        '
        'PictureExtraccion1
        '
        Me.PictureExtraccion1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.extraccion
        Me.PictureExtraccion1.Location = New System.Drawing.Point(346, 14)
        Me.PictureExtraccion1.Name = "PictureExtraccion1"
        Me.PictureExtraccion1.Size = New System.Drawing.Size(82, 85)
        Me.PictureExtraccion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureExtraccion1.TabIndex = 0
        Me.PictureExtraccion1.TabStop = False
        '
        'CrearReservacionComboBox
        '
        Me.CrearReservacionComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CrearReservacionComboBox.Controls.Add(Me.PictureBox2)
        Me.CrearReservacionComboBox.Controls.Add(Me.Label22)
        Me.CrearReservacionComboBox.Controls.Add(Me.TextBox3)
        Me.CrearReservacionComboBox.Controls.Add(Me.Label23)
        Me.CrearReservacionComboBox.Controls.Add(Me.Label24)
        Me.CrearReservacionComboBox.Controls.Add(Me.LibrosParaReservar)
        Me.CrearReservacionComboBox.Controls.Add(Me.Label25)
        Me.CrearReservacionComboBox.Location = New System.Drawing.Point(263, 99)
        Me.CrearReservacionComboBox.Name = "CrearReservacionComboBox"
        Me.CrearReservacionComboBox.Size = New System.Drawing.Size(738, 549)
        Me.CrearReservacionComboBox.TabIndex = 80
        Me.CrearReservacionComboBox.TabStop = False
        Me.CrearReservacionComboBox.Text = "CREAR RESERVACION"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.busqueda
        Me.PictureBox2.Location = New System.Drawing.Point(369, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(18, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 15)
        Me.Label22.TabIndex = 79
        Me.Label22.Text = "ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(45, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(323, 20)
        Me.TextBox3.TabIndex = 78
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(18, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 15)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = "BUSCAR LIBRO"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.Label24.Location = New System.Drawing.Point(473, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(237, 34)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "CREAR RESERVACION"
        '
        'LibrosParaReservar
        '
        Me.LibrosParaReservar.AllowUserToAddRows = False
        Me.LibrosParaReservar.AllowUserToDeleteRows = False
        Me.LibrosParaReservar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibrosParaReservar.Location = New System.Drawing.Point(5, 139)
        Me.LibrosParaReservar.Name = "LibrosParaReservar"
        Me.LibrosParaReservar.ReadOnly = True
        Me.LibrosParaReservar.RowHeadersVisible = False
        Me.LibrosParaReservar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibrosParaReservar.Size = New System.Drawing.Size(726, 401)
        Me.LibrosParaReservar.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label25.Location = New System.Drawing.Point(15, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(220, 34)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Libros Disponibles"
        '
        'Aparecer
        '
        Me.Aparecer.Interval = 5
        '
        'Ocultar
        '
        Me.Ocultar.Interval = 5
        '
        'Ocultar_Aparecer
        '
        Me.Ocultar_Aparecer.Interval = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Location = New System.Drawing.Point(-5, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 38)
        Me.Panel2.TabIndex = 78
        '
        'Prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1061, 646)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReservacionComboBox)
        Me.Controls.Add(Me.ExtCombo)
        Me.Controls.Add(Me.devoCOMBO)
        Me.Controls.Add(Me.CrearReservacionComboBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prestamos"
        Me.Text = "PRESTAMOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.devoCOMBO.ResumeLayout(False)
        Me.devoCOMBO.PerformLayout()
        CType(Me.DataGridAGG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExtCombo.ResumeLayout(False)
        Me.ExtCombo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VERLIBROSAGG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReservacionComboBox.ResumeLayout(False)
        Me.ReservacionComboBox.PerformLayout()
        CType(Me.VerLibrosReservados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureCrearRes3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureReservacion4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureDevolucion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureExtraccion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CrearReservacionComboBox.ResumeLayout(False)
        Me.CrearReservacionComboBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosParaReservar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LIBROSAGG As System.Windows.Forms.ListBox
    Friend WithEvents devoCOMBO As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridAGG As System.Windows.Forms.DataGridView
    Friend WithEvents ExtCombo As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LIBROS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VERLIBROSAGG As System.Windows.Forms.DataGridView
    Friend WithEvents IDAGG As System.Windows.Forms.ListBox
    Friend WithEvents ENPODER As System.Windows.Forms.Label
    Friend WithEvents NOMBRE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OPA As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureExtraccion1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureDevolucion2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureCrearRes3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureReservacion4 As System.Windows.Forms.PictureBox
    Friend WithEvents ReservacionComboBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents VerLibrosReservados As System.Windows.Forms.DataGridView
    Friend WithEvents CrearReservacionComboBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LibrosParaReservar As System.Windows.Forms.DataGridView
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Aparecer As System.Windows.Forms.Timer
    Friend WithEvents Ocultar As System.Windows.Forms.Timer
    Friend WithEvents Ocultar_Aparecer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
