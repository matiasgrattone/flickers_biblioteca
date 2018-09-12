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
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Socios")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Director")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funiconarios", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administradoes")
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.PlaceHolder7 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder6 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder5 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder4 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder3 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder2 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder1 = New Proyecto_Biblioteca.PlaceHolder()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        TreeNode5.Name = "Node0"
        TreeNode5.Text = "Socios"
        TreeNode6.Name = "Node8"
        TreeNode6.Text = "Director"
        TreeNode7.BackColor = System.Drawing.Color.Transparent
        TreeNode7.Name = "Node6"
        TreeNode7.Text = "Funiconarios"
        TreeNode8.Name = "Node12"
        TreeNode8.Text = "Administradoes"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode7, TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(214, 446)
        Me.TreeView1.TabIndex = 9
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
        'ConfiguraciònAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 461)
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
End Class
