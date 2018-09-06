<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOTAS
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Nota = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdelantarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionarTodoElTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarTodoElTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ABRIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Nota
        '
        Me.Nota.Location = New System.Drawing.Point(128, 41)
        Me.Nota.Multiline = True
        Me.Nota.Name = "Nota"
        Me.Nota.Size = New System.Drawing.Size(429, 239)
        Me.Nota.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.FormulaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ToolStripMenuItem3, Me.AbrirToolStripMenuItem1, Me.GuardarComoToolStripMenuItem1, Me.ToolStripMenuItem4, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(147, 6)
        '
        'AbrirToolStripMenuItem1
        '
        Me.AbrirToolStripMenuItem1.Name = "AbrirToolStripMenuItem1"
        Me.AbrirToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.AbrirToolStripMenuItem1.Text = "Abrir"
        '
        'GuardarComoToolStripMenuItem1
        '
        Me.GuardarComoToolStripMenuItem1.Name = "GuardarComoToolStripMenuItem1"
        Me.GuardarComoToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.GuardarComoToolStripMenuItem1.Text = "Guardar como"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(147, 6)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtrasToolStripMenuItem, Me.AdelantarToolStripMenuItem, Me.ToolStripMenuItem1, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.ToolStripMenuItem2, Me.SeleccionarTodoElTextoToolStripMenuItem, Me.LimpiarTodoElTextoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'AtrasToolStripMenuItem
        '
        Me.AtrasToolStripMenuItem.Name = "AtrasToolStripMenuItem"
        Me.AtrasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AtrasToolStripMenuItem.Text = "Atras"
        '
        'AdelantarToolStripMenuItem
        '
        Me.AdelantarToolStripMenuItem.Name = "AdelantarToolStripMenuItem"
        Me.AdelantarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AdelantarToolStripMenuItem.Text = "Adelantar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar "
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(200, 6)
        '
        'SeleccionarTodoElTextoToolStripMenuItem
        '
        Me.SeleccionarTodoElTextoToolStripMenuItem.Name = "SeleccionarTodoElTextoToolStripMenuItem"
        Me.SeleccionarTodoElTextoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SeleccionarTodoElTextoToolStripMenuItem.Text = "Seleccionar todo el texto"
        '
        'LimpiarTodoElTextoToolStripMenuItem
        '
        Me.LimpiarTodoElTextoToolStripMenuItem.Name = "LimpiarTodoElTextoToolStripMenuItem"
        Me.LimpiarTodoElTextoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.LimpiarTodoElTextoToolStripMenuItem.Text = "Limpiar todo el texto"
        '
        'FormulaToolStripMenuItem
        '
        Me.FormulaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.FormulaToolStripMenuItem.Name = "FormulaToolStripMenuItem"
        Me.FormulaToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FormulaToolStripMenuItem.Text = "Formula"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'NOTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.Nota)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NOTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Nota As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdelantarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeleccionarTodoElTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarTodoElTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormulaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AbrirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
