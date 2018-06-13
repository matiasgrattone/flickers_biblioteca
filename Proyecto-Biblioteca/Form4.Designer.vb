<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LIBROSAGG = New System.Windows.Forms.ListBox()
        Me.devoCOMBO = New System.Windows.Forms.GroupBox()
        Me.DataGridAGG = New System.Windows.Forms.DataGridView()
        Me.ENPODER = New System.Windows.Forms.Label()
        Me.ExtCombo = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LIBROS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VERLIBROSAGG = New System.Windows.Forms.DataGridView()
        Me.ComboBoxMORTAL = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.IDAGG = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ESTADO = New System.Windows.Forms.Label()
        Me.NOMBRE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OPA = New System.Windows.Forms.DataGridView()
        Me.devoCOMBO.SuspendLayout()
        CType(Me.DataGridAGG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExtCombo.SuspendLayout()
        CType(Me.VERLIBROSAGG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(504, 575)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(288, 80)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 21)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(342, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 168)
        Me.Panel1.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1126, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1251, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Label2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "LIBRO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "ID "
        '
        'LIBROSAGG
        '
        Me.LIBROSAGG.FormattingEnabled = True
        Me.LIBROSAGG.Location = New System.Drawing.Point(185, 237)
        Me.LIBROSAGG.Name = "LIBROSAGG"
        Me.LIBROSAGG.Size = New System.Drawing.Size(116, 238)
        Me.LIBROSAGG.TabIndex = 68
        '
        'devoCOMBO
        '
        Me.devoCOMBO.Controls.Add(Me.DataGridAGG)
        Me.devoCOMBO.Controls.Add(Me.ENPODER)
        Me.devoCOMBO.Location = New System.Drawing.Point(923, 71)
        Me.devoCOMBO.Name = "devoCOMBO"
        Me.devoCOMBO.Size = New System.Drawing.Size(413, 460)
        Me.devoCOMBO.TabIndex = 67
        Me.devoCOMBO.TabStop = False
        Me.devoCOMBO.Text = "DEVOLUCION"
        '
        'DataGridAGG
        '
        Me.DataGridAGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAGG.Location = New System.Drawing.Point(17, 130)
        Me.DataGridAGG.Name = "DataGridAGG"
        Me.DataGridAGG.Size = New System.Drawing.Size(390, 314)
        Me.DataGridAGG.TabIndex = 0
        '
        'ENPODER
        '
        Me.ENPODER.AutoSize = True
        Me.ENPODER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENPODER.Location = New System.Drawing.Point(13, 94)
        Me.ENPODER.Name = "ENPODER"
        Me.ENPODER.Size = New System.Drawing.Size(119, 20)
        Me.ENPODER.TabIndex = 61
        Me.ENPODER.Text = "Libros en poder"
        '
        'ExtCombo
        '
        Me.ExtCombo.Controls.Add(Me.Label10)
        Me.ExtCombo.Controls.Add(Me.Label7)
        Me.ExtCombo.Controls.Add(Me.LIBROS)
        Me.ExtCombo.Controls.Add(Me.Label6)
        Me.ExtCombo.Controls.Add(Me.VERLIBROSAGG)
        Me.ExtCombo.Location = New System.Drawing.Point(484, 71)
        Me.ExtCombo.Name = "ExtCombo"
        Me.ExtCombo.Size = New System.Drawing.Size(413, 460)
        Me.ExtCombo.TabIndex = 66
        Me.ExtCombo.TabStop = False
        Me.ExtCombo.Text = "EXTRACCION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "NOMBRE LIBRO"
        '
        'LIBROS
        '
        Me.LIBROS.Location = New System.Drawing.Point(41, 51)
        Me.LIBROS.Name = "LIBROS"
        Me.LIBROS.Size = New System.Drawing.Size(95, 20)
        Me.LIBROS.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "BUSCAR LIBRO"
        '
        'VERLIBROSAGG
        '
        Me.VERLIBROSAGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VERLIBROSAGG.Location = New System.Drawing.Point(20, 130)
        Me.VERLIBROSAGG.Name = "VERLIBROSAGG"
        Me.VERLIBROSAGG.Size = New System.Drawing.Size(376, 314)
        Me.VERLIBROSAGG.TabIndex = 17
        '
        'ComboBoxMORTAL
        '
        Me.ComboBoxMORTAL.FormattingEnabled = True
        Me.ComboBoxMORTAL.Items.AddRange(New Object() {"Extraccion", "Devolucion"})
        Me.ComboBoxMORTAL.Location = New System.Drawing.Point(484, 29)
        Me.ComboBoxMORTAL.Name = "ComboBoxMORTAL"
        Me.ComboBoxMORTAL.Size = New System.Drawing.Size(156, 21)
        Me.ComboBoxMORTAL.TabIndex = 65
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(41, 626)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 29)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Moroso"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'IDAGG
        '
        Me.IDAGG.FormattingEnabled = True
        Me.IDAGG.Location = New System.Drawing.Point(71, 237)
        Me.IDAGG.Name = "IDAGG"
        Me.IDAGG.Size = New System.Drawing.Size(118, 238)
        Me.IDAGG.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "--------------------------"
        '
        'ESTADO
        '
        Me.ESTADO.AutoSize = True
        Me.ESTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADO.Location = New System.Drawing.Point(311, 116)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ESTADO.Size = New System.Drawing.Size(74, 24)
        Me.ESTADO.TabIndex = 62
        Me.ESTADO.Text = "Estado"
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSize = True
        Me.NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE.ForeColor = System.Drawing.Color.Black
        Me.NOMBRE.Location = New System.Drawing.Point(36, 116)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(87, 25)
        Me.NOMBRE.TabIndex = 60
        Me.NOMBRE.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "INGRESE LA CEDULA DEL USUARIO "
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(15, 30)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(190, 20)
        Me.Cedula.TabIndex = 57
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(377, 409)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(34, 30)
        Me.DataGridView1.TabIndex = 56
        '
        'OPA
        '
        Me.OPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OPA.Location = New System.Drawing.Point(356, 409)
        Me.OPA.Name = "OPA"
        Me.OPA.Size = New System.Drawing.Size(29, 30)
        Me.OPA.TabIndex = 77
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Proyecto_Biblioteca.My.Resources.Resources._302c8eb1f942e4312e3dc37f61f468c6
        Me.ClientSize = New System.Drawing.Size(1362, 683)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LIBROSAGG)
        Me.Controls.Add(Me.devoCOMBO)
        Me.Controls.Add(Me.ExtCombo)
        Me.Controls.Add(Me.ComboBoxMORTAL)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.IDAGG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ESTADO)
        Me.Controls.Add(Me.NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.OPA)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form4"
        Me.Text = "PRESTAMOS"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.devoCOMBO.ResumeLayout(False)
        Me.devoCOMBO.PerformLayout()
        CType(Me.DataGridAGG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExtCombo.ResumeLayout(False)
        Me.ExtCombo.PerformLayout()
        CType(Me.VERLIBROSAGG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LIBROS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VERLIBROSAGG As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxMORTAL As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents IDAGG As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ESTADO As System.Windows.Forms.Label
    Friend WithEvents ENPODER As System.Windows.Forms.Label
    Friend WithEvents NOMBRE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OPA As System.Windows.Forms.DataGridView
End Class
