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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Socios")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funcionarios")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administradoes")
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_buscar = New System.Windows.Forms.DataGridView()
        Me.buscar_txt = New Proyecto_Biblioteca.PlaceHolder()
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
        Me.contrasenia_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.telefono_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.cedula_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.apellido_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.nombre_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.direccion_txt = New Proyecto_Biblioteca.PlaceHolder()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PlaceHolder7 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder6 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder5 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder4 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder3 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder2 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder1 = New Proyecto_Biblioteca.PlaceHolder()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 428)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 401)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(284, 6)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node0"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Text = "Socios"
        TreeNode2.BackColor = System.Drawing.Color.Transparent
        TreeNode2.Name = "Node6"
        TreeNode2.Text = "Funcionarios"
        TreeNode3.Name = "Node12"
        TreeNode3.Text = "Administradoes"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Me.TreeView1.Size = New System.Drawing.Size(214, 446)
        Me.TreeView1.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1"})
        Me.ComboBox3.Location = New System.Drawing.Point(74, 294)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Animaciòn"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
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
        Me.dgv_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_buscar.Location = New System.Drawing.Point(29, 62)
        Me.dgv_buscar.Name = "dgv_buscar"
        Me.dgv_buscar.Size = New System.Drawing.Size(400, 338)
        Me.dgv_buscar.TabIndex = 0
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
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(458, 432)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Editar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PlaceHolder7
        '
        Me.PlaceHolder7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder7.Location = New System.Drawing.Point(12, 214)
        Me.PlaceHolder7.Name = "PlaceHolder7"
        Me.PlaceHolder7.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder7.TabIndex = 6
        Me.PlaceHolder7.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder7.WaterMarkText = "Water Mark"
        '
        'PlaceHolder6
        '
        Me.PlaceHolder6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder6.Location = New System.Drawing.Point(12, 188)
        Me.PlaceHolder6.Name = "PlaceHolder6"
        Me.PlaceHolder6.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder6.TabIndex = 5
        Me.PlaceHolder6.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder6.WaterMarkText = "Water Mark"
        '
        'PlaceHolder5
        '
        Me.PlaceHolder5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder5.Location = New System.Drawing.Point(12, 162)
        Me.PlaceHolder5.Name = "PlaceHolder5"
        Me.PlaceHolder5.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder5.TabIndex = 4
        Me.PlaceHolder5.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder5.WaterMarkText = "Water Mark"
        '
        'PlaceHolder4
        '
        Me.PlaceHolder4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder4.Location = New System.Drawing.Point(12, 136)
        Me.PlaceHolder4.Name = "PlaceHolder4"
        Me.PlaceHolder4.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder4.TabIndex = 3
        Me.PlaceHolder4.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder4.WaterMarkText = "Water Mark"
        '
        'PlaceHolder3
        '
        Me.PlaceHolder3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder3.Location = New System.Drawing.Point(12, 110)
        Me.PlaceHolder3.Name = "PlaceHolder3"
        Me.PlaceHolder3.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder3.TabIndex = 2
        Me.PlaceHolder3.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder3.WaterMarkText = "Water Mark"
        '
        'PlaceHolder2
        '
        Me.PlaceHolder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder2.Location = New System.Drawing.Point(12, 84)
        Me.PlaceHolder2.Name = "PlaceHolder2"
        Me.PlaceHolder2.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder2.TabIndex = 1
        Me.PlaceHolder2.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder2.WaterMarkText = "Water Mark"
        '
        'PlaceHolder1
        '
        Me.PlaceHolder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder1.Location = New System.Drawing.Point(12, 58)
        Me.PlaceHolder1.Name = "PlaceHolder1"
        Me.PlaceHolder1.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder1.TabIndex = 0
        Me.PlaceHolder1.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder1.WaterMarkText = "Water Mark"
        '
        'ConfiguraciònAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PlaceHolder7)
        Me.Controls.Add(Me.PlaceHolder6)
        Me.Controls.Add(Me.PlaceHolder5)
        Me.Controls.Add(Me.PlaceHolder4)
        Me.Controls.Add(Me.PlaceHolder3)
        Me.Controls.Add(Me.PlaceHolder2)
        Me.Controls.Add(Me.PlaceHolder1)
        Me.Name = "ConfiguraciònAdmin"
        Me.Text = "ConfiguraciònAdmin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlaceHolder1 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder2 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder3 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder4 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder5 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder6 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder7 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
End Class
