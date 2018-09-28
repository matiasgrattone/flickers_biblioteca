<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaDeBloqueo
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
        Me.Rueda_de_carga1 = New Proyecto_Biblioteca.OptProgressControl.Rueda_de_carga()
        Me.SuspendLayout()
        '
        'Rueda_de_carga1
        '
        Me.Rueda_de_carga1.BackColor = System.Drawing.Color.Transparent
        Me.Rueda_de_carga1.Interval = 60
        Me.Rueda_de_carga1.Location = New System.Drawing.Point(490, 225)
        Me.Rueda_de_carga1.MinimumSize = New System.Drawing.Size(28, 28)
        Me.Rueda_de_carga1.Name = "Rueda_de_carga1"
        Me.Rueda_de_carga1.Rotation = Proyecto_Biblioteca.OptProgressControl.Rueda_de_carga.Direction.CLOCKWISE
        Me.Rueda_de_carga1.Size = New System.Drawing.Size(150, 150)
        Me.Rueda_de_carga1.StartAngle = 270
        Me.Rueda_de_carga1.TabIndex = 0
        Me.Rueda_de_carga1.TickColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        '
        'PantallaDeBloqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 653)
        Me.Controls.Add(Me.Rueda_de_carga1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaDeBloqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaDeBloqueo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rueda_de_carga1 As Proyecto_Biblioteca.OptProgressControl.Rueda_de_carga
End Class
