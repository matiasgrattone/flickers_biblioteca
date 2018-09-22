<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguraciònAdmin
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label_Animaciòn = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_buscar = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_anio = New System.Windows.Forms.ComboBox()
        Me.cb_mes = New System.Windows.Forms.ComboBox()
        Me.cb_dia = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_Baja = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label_BaseDatos = New System.Windows.Forms.Label()
        Me.Label_BaseDatosTXT = New System.Windows.Forms.Label()
        Me.Label_BDestado = New System.Windows.Forms.Label()
        Me.Label_BDestadoTXT = New System.Windows.Forms.Label()
        Me.Lbl_NombreADMIN_TXT = New System.Windows.Forms.Label()
        Me.buscar_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.contrasenia_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.telefono_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.cedula_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.apellido_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.nombre_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.direccion_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.Buscar_Baja_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Dgv_Baja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(302, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(214, 455)
        Me.TreeView1.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1"})
        Me.ComboBox3.Location = New System.Drawing.Point(74, 376)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'Label_Animaciòn
        '
        Me.Label_Animaciòn.AutoSize = True
        Me.Label_Animaciòn.Location = New System.Drawing.Point(12, 380)
        Me.Label_Animaciòn.Name = "Label_Animaciòn"
        Me.Label_Animaciòn.Size = New System.Drawing.Size(56, 13)
        Me.Label_Animaciòn.TabIndex = 11
        Me.Label_Animaciòn.Text = "Animaciòn"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(518, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(466, 458)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgv_buscar)
        Me.TabPage1.Controls.Add(Me.buscar_txt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(458, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buscar/Eliminar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Para dar de baja a un funcionario dar doble click sobre él"
        '
        'dgv_buscar
        '
        Me.dgv_buscar.AllowUserToAddRows = False
        Me.dgv_buscar.AllowUserToDeleteRows = False
        Me.dgv_buscar.AllowUserToResizeColumns = False
        Me.dgv_buscar.AllowUserToResizeRows = False
        Me.dgv_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_buscar.Location = New System.Drawing.Point(4, 62)
        Me.dgv_buscar.Name = "dgv_buscar"
        Me.dgv_buscar.RowHeadersVisible = False
        Me.dgv_buscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_buscar.Size = New System.Drawing.Size(450, 364)
        Me.dgv_buscar.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.cb_anio)
        Me.TabPage2.Controls.Add(Me.cb_mes)
        Me.TabPage2.Controls.Add(Me.cb_dia)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.contrasenia_txt)
        Me.TabPage2.Controls.Add(Me.telefono_txt)
        Me.TabPage2.Controls.Add(Me.cedula_txt)
        Me.TabPage2.Controls.Add(Me.apellido_txt)
        Me.TabPage2.Controls.Add(Me.nombre_txt)
        Me.TabPage2.Controls.Add(Me.direccion_txt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(458, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registro"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 35)
        Me.Button1.TabIndex = 151
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 26)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Registrar Funcionarios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(109, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Cédula"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(363, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 20)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "*"
        '
        'cb_anio
        '
        Me.cb_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_anio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_anio.FormattingEnabled = True
        Me.cb_anio.Location = New System.Drawing.Point(302, 316)
        Me.cb_anio.Name = "cb_anio"
        Me.cb_anio.Size = New System.Drawing.Size(77, 27)
        Me.cb_anio.TabIndex = 137
        '
        'cb_mes
        '
        Me.cb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_mes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_mes.FormattingEnabled = True
        Me.cb_mes.Location = New System.Drawing.Point(205, 316)
        Me.cb_mes.Name = "cb_mes"
        Me.cb_mes.Size = New System.Drawing.Size(81, 27)
        Me.cb_mes.TabIndex = 136
        '
        'cb_dia
        '
        Me.cb_dia.AccessibleDescription = ""
        Me.cb_dia.AccessibleName = ""
        Me.cb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_dia.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_dia.FormattingEnabled = True
        Me.cb_dia.Location = New System.Drawing.Point(113, 316)
        Me.cb_dia.Name = "cb_dia"
        Me.cb_dia.Size = New System.Drawing.Size(78, 27)
        Me.cb_dia.TabIndex = 135
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(175, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 19)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Fecha de nacimiento"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(93, 210)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 19)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Dirección"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(458, 432)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Editar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.Dgv_Baja)
        Me.TabPage4.Controls.Add(Me.Buscar_Baja_txt)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(458, 432)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ver Dados de baja"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Para activar a un funcionario dar doble click sobre él"
        '
        'Dgv_Baja
        '
        Me.Dgv_Baja.AllowUserToAddRows = False
        Me.Dgv_Baja.AllowUserToDeleteRows = False
        Me.Dgv_Baja.AllowUserToResizeColumns = False
        Me.Dgv_Baja.AllowUserToResizeRows = False
        Me.Dgv_Baja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Baja.Location = New System.Drawing.Point(4, 62)
        Me.Dgv_Baja.Name = "Dgv_Baja"
        Me.Dgv_Baja.ReadOnly = True
        Me.Dgv_Baja.RowHeadersVisible = False
        Me.Dgv_Baja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Baja.Size = New System.Drawing.Size(450, 364)
        Me.Dgv_Baja.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label_BaseDatos
        '
        Me.Label_BaseDatos.AutoSize = True
        Me.Label_BaseDatos.Location = New System.Drawing.Point(12, 420)
        Me.Label_BaseDatos.Name = "Label_BaseDatos"
        Me.Label_BaseDatos.Size = New System.Drawing.Size(86, 13)
        Me.Label_BaseDatos.TabIndex = 13
        Me.Label_BaseDatos.Text = "Base de Datos : "
        '
        'Label_BaseDatosTXT
        '
        Me.Label_BaseDatosTXT.AutoSize = True
        Me.Label_BaseDatosTXT.Location = New System.Drawing.Point(95, 420)
        Me.Label_BaseDatosTXT.Name = "Label_BaseDatosTXT"
        Me.Label_BaseDatosTXT.Size = New System.Drawing.Size(40, 13)
        Me.Label_BaseDatosTXT.TabIndex = 14
        Me.Label_BaseDatosTXT.Text = "..........."
        '
        'Label_BDestado
        '
        Me.Label_BDestado.AutoSize = True
        Me.Label_BDestado.Location = New System.Drawing.Point(12, 435)
        Me.Label_BDestado.Name = "Label_BDestado"
        Me.Label_BDestado.Size = New System.Drawing.Size(105, 13)
        Me.Label_BDestado.TabIndex = 15
        Me.Label_BDestado.Text = "Actualizado Ult Vez :"
        '
        'Label_BDestadoTXT
        '
        Me.Label_BDestadoTXT.AutoSize = True
        Me.Label_BDestadoTXT.Location = New System.Drawing.Point(123, 435)
        Me.Label_BDestadoTXT.Name = "Label_BDestadoTXT"
        Me.Label_BDestadoTXT.Size = New System.Drawing.Size(40, 13)
        Me.Label_BDestadoTXT.TabIndex = 16
        Me.Label_BDestadoTXT.Text = "..........."
        '
        'Lbl_NombreADMIN_TXT
        '
        Me.Lbl_NombreADMIN_TXT.AutoSize = True
        Me.Lbl_NombreADMIN_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NombreADMIN_TXT.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NombreADMIN_TXT.Name = "Lbl_NombreADMIN_TXT"
        Me.Lbl_NombreADMIN_TXT.Size = New System.Drawing.Size(72, 24)
        Me.Lbl_NombreADMIN_TXT.TabIndex = 17
        Me.Lbl_NombreADMIN_TXT.Text = "Label3"
        '
        'buscar_txt
        '
        Me.buscar_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.buscar_txt.Location = New System.Drawing.Point(72, 16)
        Me.buscar_txt.Name = "buscar_txt"
        Me.buscar_txt.Size = New System.Drawing.Size(301, 20)
        Me.buscar_txt.TabIndex = 1
        Me.buscar_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.buscar_txt.WaterMarkText = "Buscar por Nombre"
        '
        'contrasenia_txt
        '
        Me.contrasenia_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrasenia_txt.Location = New System.Drawing.Point(168, 240)
        Me.contrasenia_txt.Name = "contrasenia_txt"
        Me.contrasenia_txt.Size = New System.Drawing.Size(189, 27)
        Me.contrasenia_txt.TabIndex = 150
        Me.contrasenia_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.contrasenia_txt.WaterMarkText = "Contraseña"
        '
        'telefono_txt
        '
        Me.telefono_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_txt.Location = New System.Drawing.Point(168, 169)
        Me.telefono_txt.Name = "telefono_txt"
        Me.telefono_txt.Size = New System.Drawing.Size(189, 27)
        Me.telefono_txt.TabIndex = 147
        Me.telefono_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.telefono_txt.WaterMarkText = "Teléfono"
        '
        'cedula_txt
        '
        Me.cedula_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula_txt.Location = New System.Drawing.Point(168, 136)
        Me.cedula_txt.Name = "cedula_txt"
        Me.cedula_txt.Size = New System.Drawing.Size(189, 27)
        Me.cedula_txt.TabIndex = 146
        Me.cedula_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.cedula_txt.WaterMarkText = "Cédula"
        '
        'apellido_txt
        '
        Me.apellido_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido_txt.Location = New System.Drawing.Point(168, 100)
        Me.apellido_txt.Name = "apellido_txt"
        Me.apellido_txt.Size = New System.Drawing.Size(189, 27)
        Me.apellido_txt.TabIndex = 145
        Me.apellido_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.apellido_txt.WaterMarkText = "Apellido"
        '
        'nombre_txt
        '
        Me.nombre_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_txt.Location = New System.Drawing.Point(168, 64)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(189, 27)
        Me.nombre_txt.TabIndex = 144
        Me.nombre_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.nombre_txt.WaterMarkText = "Nombre"
        '
        'direccion_txt
        '
        Me.direccion_txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_txt.Location = New System.Drawing.Point(168, 207)
        Me.direccion_txt.Name = "direccion_txt"
        Me.direccion_txt.Size = New System.Drawing.Size(189, 27)
        Me.direccion_txt.TabIndex = 138
        Me.direccion_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.direccion_txt.WaterMarkText = "Dirección"
        '
        'Buscar_Baja_txt
        '
        Me.Buscar_Baja_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Buscar_Baja_txt.Location = New System.Drawing.Point(72, 16)
        Me.Buscar_Baja_txt.Name = "Buscar_Baja_txt"
        Me.Buscar_Baja_txt.Size = New System.Drawing.Size(301, 20)
        Me.Buscar_Baja_txt.TabIndex = 3
        Me.Buscar_Baja_txt.WaterMarkColor = System.Drawing.Color.Gray
        Me.Buscar_Baja_txt.WaterMarkText = "Buscar por Nombre"
        '
        'ConfiguraciònAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 461)
        Me.Controls.Add(Me.Lbl_NombreADMIN_TXT)
        Me.Controls.Add(Me.Label_BDestadoTXT)
        Me.Controls.Add(Me.Label_BDestado)
        Me.Controls.Add(Me.Label_BaseDatosTXT)
        Me.Controls.Add(Me.Label_BaseDatos)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label_Animaciòn)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "ConfiguraciònAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Dgv_Baja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Animaciòn As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents buscar_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents dgv_buscar As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents contrasenia_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents telefono_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents cedula_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents apellido_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_anio As System.Windows.Forms.ComboBox
    Friend WithEvents cb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents direccion_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents cb_dia As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_BaseDatosTXT As System.Windows.Forms.Label
    Friend WithEvents Label_BaseDatos As System.Windows.Forms.Label
    Friend WithEvents Label_BDestadoTXT As System.Windows.Forms.Label
    Friend WithEvents Label_BDestado As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Dgv_Baja As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buscar_Baja_txt As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents Lbl_NombreADMIN_TXT As System.Windows.Forms.Label
End Class
