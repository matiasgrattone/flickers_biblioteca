<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionAdminV2
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
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.PictureboxBordesRedondos1 = New Proyecto_Biblioteca.PictureboxBordesRedondos()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PbFondo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureboxBordesRedondos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.Location = New System.Drawing.Point(1038, -2)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(108, 656)
        Me.PanelOpciones.TabIndex = 0
        '
        'PictureboxBordesRedondos1
        '
        Me.PictureboxBordesRedondos1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureboxBordesRedondos1.Location = New System.Drawing.Point(12, 12)
        Me.PictureboxBordesRedondos1.Name = "PictureboxBordesRedondos1"
        Me.PictureboxBordesRedondos1.Size = New System.Drawing.Size(177, 180)
        Me.PictureboxBordesRedondos1.TabIndex = 1
        Me.PictureboxBordesRedondos1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'PbFondo
        '
        Me.PbFondo.Location = New System.Drawing.Point(-1, -2)
        Me.PbFondo.Name = "PbFondo"
        Me.PbFondo.Size = New System.Drawing.Size(1144, 656)
        Me.PbFondo.TabIndex = 6
        Me.PbFondo.TabStop = False
        '
        'ConfiguracionAdminV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 651)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureboxBordesRedondos1)
        Me.Controls.Add(Me.PanelOpciones)
        Me.Controls.Add(Me.PbFondo)
        Me.Name = "ConfiguracionAdminV2"
        Me.Text = "ConfiguracionAdminV2"
        CType(Me.PictureboxBordesRedondos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelOpciones As System.Windows.Forms.Panel
    Friend WithEvents PictureboxBordesRedondos1 As Proyecto_Biblioteca.PictureboxBordesRedondos
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PbFondo As System.Windows.Forms.PictureBox
End Class
