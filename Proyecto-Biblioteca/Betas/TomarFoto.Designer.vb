<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TomarFoto
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
        Me.WebCam1 = New WebCAM.WebCam()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        Me.timer_Guardado = New System.Windows.Forms.Timer(Me.components)
        Me.lbProce = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rd_Procesando = New Proyecto_Biblioteca.OptProgressControl.Rueda_de_carga()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(70, 18)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(320, 240)
        Me.WebCam1.TabIndex = 0
        '
        'btnCapturar
        '
        Me.btnCapturar.Location = New System.Drawing.Point(183, 276)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(98, 23)
        Me.btnCapturar.TabIndex = 1
        Me.btnCapturar.Text = "Capturar"
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'ptbFoto
        '
        Me.ptbFoto.Location = New System.Drawing.Point(70, 18)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(320, 240)
        Me.ptbFoto.TabIndex = 3
        Me.ptbFoto.TabStop = False
        '
        'timer_Guardado
        '
        '
        'lbProce
        '
        Me.lbProce.AutoSize = True
        Me.lbProce.Location = New System.Drawing.Point(402, 136)
        Me.lbProce.Name = "lbProce"
        Me.lbProce.Size = New System.Drawing.Size(73, 13)
        Me.lbProce.TabIndex = 5
        Me.lbProce.Text = "Procesando..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 35)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lbProce)
        Me.Panel2.Controls.Add(Me.rd_Procesando)
        Me.Panel2.Controls.Add(Me.btnCapturar)
        Me.Panel2.Controls.Add(Me.WebCam1)
        Me.Panel2.Controls.Add(Me.ptbFoto)
        Me.Panel2.Location = New System.Drawing.Point(1, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 311)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(481, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'rd_Procesando
        '
        Me.rd_Procesando.BackColor = System.Drawing.Color.Transparent
        Me.rd_Procesando.Interval = 60
        Me.rd_Procesando.Location = New System.Drawing.Point(415, 85)
        Me.rd_Procesando.MinimumSize = New System.Drawing.Size(28, 28)
        Me.rd_Procesando.Name = "rd_Procesando"
        Me.rd_Procesando.Rotation = Proyecto_Biblioteca.OptProgressControl.Rueda_de_carga.Direction.CLOCKWISE
        Me.rd_Procesando.Size = New System.Drawing.Size(48, 48)
        Me.rd_Procesando.StartAngle = 270
        Me.rd_Procesando.TabIndex = 4
        Me.rd_Procesando.TickColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        '
        'TomarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(514, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TomarFoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TomarFoto"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebCam1 As WebCAM.WebCam
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents ptbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents rd_Procesando As Proyecto_Biblioteca.OptProgressControl.Rueda_de_carga
    Friend WithEvents timer_Guardado As System.Windows.Forms.Timer
    Friend WithEvents lbProce As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
