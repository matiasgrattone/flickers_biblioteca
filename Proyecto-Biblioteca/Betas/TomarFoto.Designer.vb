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
        Me.WebCam1 = New WebCAM.WebCam()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(52, 12)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(320, 240)
        Me.WebCam1.TabIndex = 0
        '
        'btnCapturar
        '
        Me.btnCapturar.Location = New System.Drawing.Point(110, 269)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(98, 23)
        Me.btnCapturar.TabIndex = 1
        Me.btnCapturar.Text = "Capturar"
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(227, 269)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Tomar de nuevo"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ptbFoto
        '
        Me.ptbFoto.Location = New System.Drawing.Point(52, 12)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(320, 240)
        Me.ptbFoto.TabIndex = 3
        Me.ptbFoto.TabStop = False
        '
        'TomarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 305)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCapturar)
        Me.Controls.Add(Me.WebCam1)
        Me.Controls.Add(Me.ptbFoto)
        Me.Name = "TomarFoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TomarFoto"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebCam1 As WebCAM.WebCam
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents ptbFoto As System.Windows.Forms.PictureBox
End Class
