<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.errorpass = New System.Windows.Forms.Label()
        Me.errorusuario = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.contrasenia = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Labels_transparentes3 = New Proyecto_Biblioteca.labels_transparentes()
        Me.Labels_transparentes2 = New Proyecto_Biblioteca.labels_transparentes()
        Me.Labels_transparentes1 = New Proyecto_Biblioteca.labels_transparentes()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'errorpass
        '
        Me.errorpass.AutoSize = True
        Me.errorpass.BackColor = System.Drawing.Color.Black
        Me.errorpass.ForeColor = System.Drawing.Color.White
        Me.errorpass.Location = New System.Drawing.Point(534, 318)
        Me.errorpass.Name = "errorpass"
        Me.errorpass.Size = New System.Drawing.Size(0, 13)
        Me.errorpass.TabIndex = 8
        '
        'errorusuario
        '
        Me.errorusuario.AutoSize = True
        Me.errorusuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.errorusuario.ForeColor = System.Drawing.Color.White
        Me.errorusuario.Location = New System.Drawing.Point(534, 262)
        Me.errorusuario.Name = "errorusuario"
        Me.errorusuario.Size = New System.Drawing.Size(0, 13)
        Me.errorusuario.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(800, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 54)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Iniciar Sesión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'contrasenia
        '
        Me.contrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrasenia.Location = New System.Drawing.Point(537, 278)
        Me.contrasenia.Name = "contrasenia"
        Me.contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contrasenia.Size = New System.Drawing.Size(213, 26)
        Me.contrasenia.TabIndex = 2
        '
        'usuario
        '
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(537, 233)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(213, 26)
        Me.usuario.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(384, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 252)
        Me.Panel2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(189, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(93, 74)
        Me.DataGridView1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.IMG_3252
        Me.PictureBox2.Location = New System.Drawing.Point(103, 191)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(260, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(534, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Olvide mi contraseña"
        '
        'Labels_transparentes3
        '
        Me.Labels_transparentes3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Labels_transparentes3.Location = New System.Drawing.Point(800, 307)
        Me.Labels_transparentes3.Name = "Labels_transparentes3"
        Me.Labels_transparentes3.Size = New System.Drawing.Size(140, 23)
        Me.Labels_transparentes3.TabIndex = 15
        Me.Labels_transparentes3.Text = "Ingresar como invitado"
        '
        'Labels_transparentes2
        '
        Me.Labels_transparentes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labels_transparentes2.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes2.Location = New System.Drawing.Point(407, 278)
        Me.Labels_transparentes2.Name = "Labels_transparentes2"
        Me.Labels_transparentes2.Size = New System.Drawing.Size(95, 23)
        Me.Labels_transparentes2.TabIndex = 12
        Me.Labels_transparentes2.Text = "Contraseña"
        '
        'Labels_transparentes1
        '
        Me.Labels_transparentes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labels_transparentes1.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes1.Location = New System.Drawing.Point(407, 236)
        Me.Labels_transparentes1.Name = "Labels_transparentes1"
        Me.Labels_transparentes1.Size = New System.Drawing.Size(63, 23)
        Me.Labels_transparentes1.TabIndex = 11
        Me.Labels_transparentes1.Text = "Cedula"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Biblioteca.My.Resources.Resources.Sin_título_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(973, 562)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labels_transparentes3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Labels_transparentes2)
        Me.Controls.Add(Me.Labels_transparentes1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.errorpass)
        Me.Controls.Add(Me.errorusuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.contrasenia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents contrasenia As System.Windows.Forms.TextBox
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents errorpass As System.Windows.Forms.Label
    Friend WithEvents errorusuario As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Labels_transparentes1 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents Labels_transparentes2 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Labels_transparentes3 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
