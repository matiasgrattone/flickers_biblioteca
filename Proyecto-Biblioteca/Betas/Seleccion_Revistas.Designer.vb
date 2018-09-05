<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_Revistas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcbox3 = New System.Windows.Forms.PictureBox()
        Me.pcbox2 = New System.Windows.Forms.PictureBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pcbox1 = New System.Windows.Forms.PictureBox()
        Me.pcbox4 = New System.Windows.Forms.PictureBox()
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer20 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer30 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer40 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.books
        Me.PictureBox1.Location = New System.Drawing.Point(350, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(94, 256)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(197, 39)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "INGRESAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pcbox1)
        Me.Panel1.Controls.Add(Me.pcbox3)
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 664)
        Me.Panel1.TabIndex = 0
        '
        'pcbox3
        '
        Me.pcbox3.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.right_arrow1
        Me.pcbox3.Location = New System.Drawing.Point(11, 245)
        Me.pcbox3.Name = "pcbox3"
        Me.pcbox3.Size = New System.Drawing.Size(38, 50)
        Me.pcbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox3.TabIndex = 8
        Me.pcbox3.TabStop = False
        '
        'pcbox2
        '
        Me.pcbox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.books
        Me.pcbox2.Location = New System.Drawing.Point(359, 181)
        Me.pcbox2.Name = "pcbox2"
        Me.pcbox2.Size = New System.Drawing.Size(133, 125)
        Me.pcbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox2.TabIndex = 11
        Me.pcbox2.TabStop = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(635, 256)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(161, 39)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "BUSCAR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel2.Controls.Add(Me.pcbox2)
        Me.Panel2.Controls.Add(Me.pcbox4)
        Me.Panel2.Controls.Add(Me.lbl2)
        Me.Panel2.Location = New System.Drawing.Point(54, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 651)
        Me.Panel2.TabIndex = 1
        '
        'pcbox1
        '
        Me.pcbox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.books
        Me.pcbox1.Location = New System.Drawing.Point(410, 181)
        Me.pcbox1.Name = "pcbox1"
        Me.pcbox1.Size = New System.Drawing.Size(133, 125)
        Me.pcbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox1.TabIndex = 10
        Me.pcbox1.TabStop = False
        '
        'pcbox4
        '
        Me.pcbox4.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.back
        Me.pcbox4.Location = New System.Drawing.Point(907, 256)
        Me.pcbox4.Name = "pcbox4"
        Me.pcbox4.Size = New System.Drawing.Size(35, 50)
        Me.pcbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbox4.TabIndex = 9
        Me.pcbox4.TabStop = False
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
        'Seleccion_Revistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 649)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Seleccion_Revistas"
        Me.Text = "Seleccion_Revistas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pcbox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer10 As System.Windows.Forms.Timer
    Friend WithEvents Timer20 As System.Windows.Forms.Timer
    Friend WithEvents Timer30 As System.Windows.Forms.Timer
    Friend WithEvents Timer40 As System.Windows.Forms.Timer
End Class
