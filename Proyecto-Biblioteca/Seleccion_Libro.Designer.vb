<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_Libro
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcbox4 = New System.Windows.Forms.PictureBox()
        Me.pcbox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pcbox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbox2 = New System.Windows.Forms.PictureBox()
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer20 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer30 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer40 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pcbox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.pcbox4)
        Me.Panel1.Controls.Add(Me.pcbox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(54, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 651)
        Me.Panel1.TabIndex = 0
        '
        'pcbox4
        '
        Me.pcbox4.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.back
        Me.pcbox4.Location = New System.Drawing.Point(907, 246)
        Me.pcbox4.Name = "pcbox4"
        Me.pcbox4.Size = New System.Drawing.Size(35, 50)
        Me.pcbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox4.TabIndex = 4
        Me.pcbox4.TabStop = False
        '
        'pcbox1
        '
        Me.pcbox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.books
        Me.pcbox1.Location = New System.Drawing.Point(356, 215)
        Me.pcbox1.Name = "pcbox1"
        Me.pcbox1.Size = New System.Drawing.Size(133, 125)
        Me.pcbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox1.TabIndex = 3
        Me.pcbox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(573, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BUSCAR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.pcbox3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.pcbox2)
        Me.Panel2.Location = New System.Drawing.Point(1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(482, 664)
        Me.Panel2.TabIndex = 1
        '
        'pcbox3
        '
        Me.pcbox3.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.right_arrow1
        Me.pcbox3.Location = New System.Drawing.Point(3, 225)
        Me.pcbox3.Name = "pcbox3"
        Me.pcbox3.Size = New System.Drawing.Size(38, 50)
        Me.pcbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox3.TabIndex = 3
        Me.pcbox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INGRESAR"
        '
        'pcbox2
        '
        Me.pcbox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.books
        Me.pcbox2.Location = New System.Drawing.Point(411, 215)
        Me.pcbox2.Name = "pcbox2"
        Me.pcbox2.Size = New System.Drawing.Size(133, 125)
        Me.pcbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox2.TabIndex = 1
        Me.pcbox2.TabStop = False
        '
        'Timer10
        '
        Me.Timer10.Interval = 1
        '
        'Timer20
        '
        Me.Timer20.Interval = 1
        '
        'Timer30
        '
        Me.Timer30.Interval = 1
        '
        'Timer40
        '
        Me.Timer40.Interval = 1
        '
        'Seleccion_Libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 649)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Seleccion_Libro"
        Me.Text = "Seleccion_Libro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pcbox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer10 As System.Windows.Forms.Timer
    Friend WithEvents Timer20 As System.Windows.Forms.Timer
    Friend WithEvents Timer30 As System.Windows.Forms.Timer
    Friend WithEvents Timer40 As System.Windows.Forms.Timer
    Friend WithEvents pcbox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbox3 As System.Windows.Forms.PictureBox
End Class
