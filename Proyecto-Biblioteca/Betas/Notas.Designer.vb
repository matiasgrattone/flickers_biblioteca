<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelDelEditor = New System.Windows.Forms.Label()
        Me.EditorDeTexto = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionarTodoElTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarTodoElTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EliminarRecordatorio3 = New System.Windows.Forms.Button()
        Me.CrearRecordatorio3 = New System.Windows.Forms.Button()
        Me.Fecha3 = New System.Windows.Forms.Label()
        Me.Recordatorio3 = New System.Windows.Forms.Label()
        Me.TextoParaRecordar3 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EliminarRecordatorio2 = New System.Windows.Forms.Button()
        Me.CrearRecordatorio2 = New System.Windows.Forms.Button()
        Me.Fecha2 = New System.Windows.Forms.Label()
        Me.TextoParaRecordar2 = New System.Windows.Forms.TextBox()
        Me.Recordatorio2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.fecha = New System.Windows.Forms.Label()
        Me.EliminarRecordatorio = New System.Windows.Forms.Button()
        Me.Fecha1 = New System.Windows.Forms.Label()
        Me.CrearRecordatorio = New System.Windows.Forms.Button()
        Me.TextoParaRecordar1 = New System.Windows.Forms.TextBox()
        Me.Recordatorio1 = New System.Windows.Forms.Label()
        Me.TextOculto = New System.Windows.Forms.TextBox()
        Me.RECORDATORIOS = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.LabelDelEditor)
        Me.Panel1.Controls.Add(Me.EditorDeTexto)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(421, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 605)
        Me.Panel1.TabIndex = 0
        '
        'LabelDelEditor
        '
        Me.LabelDelEditor.AutoSize = True
        Me.LabelDelEditor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.LabelDelEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDelEditor.Location = New System.Drawing.Point(465, 0)
        Me.LabelDelEditor.Name = "LabelDelEditor"
        Me.LabelDelEditor.Size = New System.Drawing.Size(144, 24)
        Me.LabelDelEditor.TabIndex = 2
        Me.LabelDelEditor.Text = "EditorDeTexto"
        '
        'EditorDeTexto
        '
        Me.EditorDeTexto.Location = New System.Drawing.Point(3, 29)
        Me.EditorDeTexto.Multiline = True
        Me.EditorDeTexto.Name = "EditorDeTexto"
        Me.EditorDeTexto.Size = New System.Drawing.Size(615, 568)
        Me.EditorDeTexto.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.FormatoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripMenuItem1})
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
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar como"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 6)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.ToolStripMenuItem3, Me.SeleccionarTodoElTextoToolStripMenuItem, Me.LimpiarTodoElTextoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
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
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(200, 6)
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
        'FormatoToolStripMenuItem
        '
        Me.FormatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        Me.FormatoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.FormatoToolStripMenuItem.Text = "Formato"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Controls.Add(Me.EliminarRecordatorio3)
        Me.Panel3.Controls.Add(Me.CrearRecordatorio3)
        Me.Panel3.Controls.Add(Me.Fecha3)
        Me.Panel3.Controls.Add(Me.Recordatorio3)
        Me.Panel3.Controls.Add(Me.TextoParaRecordar3)
        Me.Panel3.Location = New System.Drawing.Point(2, 417)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 197)
        Me.Panel3.TabIndex = 2
        '
        'EliminarRecordatorio3
        '
        Me.EliminarRecordatorio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarRecordatorio3.Location = New System.Drawing.Point(383, 146)
        Me.EliminarRecordatorio3.Name = "EliminarRecordatorio3"
        Me.EliminarRecordatorio3.Size = New System.Drawing.Size(30, 38)
        Me.EliminarRecordatorio3.TabIndex = 11
        Me.EliminarRecordatorio3.Text = "x"
        Me.EliminarRecordatorio3.UseVisualStyleBackColor = True
        '
        'CrearRecordatorio3
        '
        Me.CrearRecordatorio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrearRecordatorio3.Location = New System.Drawing.Point(334, 146)
        Me.CrearRecordatorio3.Name = "CrearRecordatorio3"
        Me.CrearRecordatorio3.Size = New System.Drawing.Size(33, 38)
        Me.CrearRecordatorio3.TabIndex = 10
        Me.CrearRecordatorio3.Text = "+"
        Me.CrearRecordatorio3.UseVisualStyleBackColor = True
        '
        'Fecha3
        '
        Me.Fecha3.AutoSize = True
        Me.Fecha3.Location = New System.Drawing.Point(345, 9)
        Me.Fecha3.Name = "Fecha3"
        Me.Fecha3.Size = New System.Drawing.Size(0, 13)
        Me.Fecha3.TabIndex = 5
        '
        'Recordatorio3
        '
        Me.Recordatorio3.AutoSize = True
        Me.Recordatorio3.Location = New System.Drawing.Point(3, 9)
        Me.Recordatorio3.Name = "Recordatorio3"
        Me.Recordatorio3.Size = New System.Drawing.Size(74, 13)
        Me.Recordatorio3.TabIndex = 4
        Me.Recordatorio3.Text = "Recordatorio3"
        '
        'TextoParaRecordar3
        '
        Me.TextoParaRecordar3.Location = New System.Drawing.Point(10, 25)
        Me.TextoParaRecordar3.Multiline = True
        Me.TextoParaRecordar3.Name = "TextoParaRecordar3"
        Me.TextoParaRecordar3.ReadOnly = True
        Me.TextoParaRecordar3.Size = New System.Drawing.Size(400, 153)
        Me.TextoParaRecordar3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.EliminarRecordatorio2)
        Me.Panel2.Controls.Add(Me.CrearRecordatorio2)
        Me.Panel2.Controls.Add(Me.Fecha2)
        Me.Panel2.Controls.Add(Me.TextoParaRecordar2)
        Me.Panel2.Controls.Add(Me.Recordatorio2)
        Me.Panel2.Location = New System.Drawing.Point(2, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 193)
        Me.Panel2.TabIndex = 3
        '
        'EliminarRecordatorio2
        '
        Me.EliminarRecordatorio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarRecordatorio2.Location = New System.Drawing.Point(383, 152)
        Me.EliminarRecordatorio2.Name = "EliminarRecordatorio2"
        Me.EliminarRecordatorio2.Size = New System.Drawing.Size(30, 38)
        Me.EliminarRecordatorio2.TabIndex = 9
        Me.EliminarRecordatorio2.Text = "x"
        Me.EliminarRecordatorio2.UseVisualStyleBackColor = True
        '
        'CrearRecordatorio2
        '
        Me.CrearRecordatorio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrearRecordatorio2.Location = New System.Drawing.Point(334, 152)
        Me.CrearRecordatorio2.Name = "CrearRecordatorio2"
        Me.CrearRecordatorio2.Size = New System.Drawing.Size(33, 38)
        Me.CrearRecordatorio2.TabIndex = 8
        Me.CrearRecordatorio2.Text = "+"
        Me.CrearRecordatorio2.UseVisualStyleBackColor = True
        '
        'Fecha2
        '
        Me.Fecha2.AutoSize = True
        Me.Fecha2.Location = New System.Drawing.Point(345, 9)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(0, 13)
        Me.Fecha2.TabIndex = 4
        '
        'TextoParaRecordar2
        '
        Me.TextoParaRecordar2.Location = New System.Drawing.Point(10, 25)
        Me.TextoParaRecordar2.Multiline = True
        Me.TextoParaRecordar2.Name = "TextoParaRecordar2"
        Me.TextoParaRecordar2.ReadOnly = True
        Me.TextoParaRecordar2.Size = New System.Drawing.Size(400, 153)
        Me.TextoParaRecordar2.TabIndex = 2
        '
        'Recordatorio2
        '
        Me.Recordatorio2.AutoSize = True
        Me.Recordatorio2.Location = New System.Drawing.Point(3, 9)
        Me.Recordatorio2.Name = "Recordatorio2"
        Me.Recordatorio2.Size = New System.Drawing.Size(74, 13)
        Me.Recordatorio2.TabIndex = 3
        Me.Recordatorio2.Text = "Recordatorio2"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel4.Controls.Add(Me.EliminarRecordatorio)
        Me.Panel4.Controls.Add(Me.Fecha1)
        Me.Panel4.Controls.Add(Me.CrearRecordatorio)
        Me.Panel4.Controls.Add(Me.TextoParaRecordar1)
        Me.Panel4.Controls.Add(Me.Recordatorio1)
        Me.Panel4.Controls.Add(Me.TextOculto)
        Me.Panel4.Controls.Add(Me.fecha)
        Me.Panel4.Location = New System.Drawing.Point(2, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(416, 193)
        Me.Panel4.TabIndex = 4
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Location = New System.Drawing.Point(229, 65)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(10, 13)
        Me.fecha.TabIndex = 6
        Me.fecha.Text = " "
        '
        'EliminarRecordatorio
        '
        Me.EliminarRecordatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarRecordatorio.Location = New System.Drawing.Point(383, 152)
        Me.EliminarRecordatorio.Name = "EliminarRecordatorio"
        Me.EliminarRecordatorio.Size = New System.Drawing.Size(30, 38)
        Me.EliminarRecordatorio.TabIndex = 7
        Me.EliminarRecordatorio.Text = "x"
        Me.EliminarRecordatorio.UseVisualStyleBackColor = True
        '
        'Fecha1
        '
        Me.Fecha1.AutoSize = True
        Me.Fecha1.Location = New System.Drawing.Point(347, 12)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(0, 13)
        Me.Fecha1.TabIndex = 3
        '
        'CrearRecordatorio
        '
        Me.CrearRecordatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrearRecordatorio.Location = New System.Drawing.Point(334, 152)
        Me.CrearRecordatorio.Name = "CrearRecordatorio"
        Me.CrearRecordatorio.Size = New System.Drawing.Size(33, 38)
        Me.CrearRecordatorio.TabIndex = 6
        Me.CrearRecordatorio.Text = "+"
        Me.CrearRecordatorio.UseVisualStyleBackColor = True
        '
        'TextoParaRecordar1
        '
        Me.TextoParaRecordar1.Location = New System.Drawing.Point(10, 28)
        Me.TextoParaRecordar1.Multiline = True
        Me.TextoParaRecordar1.Name = "TextoParaRecordar1"
        Me.TextoParaRecordar1.ReadOnly = True
        Me.TextoParaRecordar1.Size = New System.Drawing.Size(400, 153)
        Me.TextoParaRecordar1.TabIndex = 0
        '
        'Recordatorio1
        '
        Me.Recordatorio1.AutoSize = True
        Me.Recordatorio1.Location = New System.Drawing.Point(3, 12)
        Me.Recordatorio1.Name = "Recordatorio1"
        Me.Recordatorio1.Size = New System.Drawing.Size(74, 13)
        Me.Recordatorio1.TabIndex = 2
        Me.Recordatorio1.Text = "Recordatorio1"
        '
        'TextOculto
        '
        Me.TextOculto.Location = New System.Drawing.Point(10, 58)
        Me.TextOculto.Name = "TextOculto"
        Me.TextOculto.Size = New System.Drawing.Size(100, 20)
        Me.TextOculto.TabIndex = 8
        '
        'RECORDATORIOS
        '
        Me.RECORDATORIOS.AutoSize = True
        Me.RECORDATORIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RECORDATORIOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RECORDATORIOS.Location = New System.Drawing.Point(7, 9)
        Me.RECORDATORIOS.Name = "RECORDATORIOS"
        Me.RECORDATORIOS.Size = New System.Drawing.Size(208, 25)
        Me.RECORDATORIOS.TabIndex = 5
        Me.RECORDATORIOS.Text = "RECORDATORIOS"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1045, 608)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.RECORDATORIOS)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Notas"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EditorDeTexto As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeleccionarTodoElTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarTodoElTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Recordatorio3 As System.Windows.Forms.Label
    Friend WithEvents TextoParaRecordar3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextoParaRecordar2 As System.Windows.Forms.TextBox
    Friend WithEvents Recordatorio2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextoParaRecordar1 As System.Windows.Forms.TextBox
    Friend WithEvents Recordatorio1 As System.Windows.Forms.Label
    Friend WithEvents RECORDATORIOS As System.Windows.Forms.Label
    Friend WithEvents LabelDelEditor As System.Windows.Forms.Label
    Friend WithEvents Fecha3 As System.Windows.Forms.Label
    Friend WithEvents Fecha2 As System.Windows.Forms.Label
    Friend WithEvents Fecha1 As System.Windows.Forms.Label
    Friend WithEvents CrearRecordatorio As System.Windows.Forms.Button
    Friend WithEvents EliminarRecordatorio As System.Windows.Forms.Button
    Friend WithEvents EliminarRecordatorio3 As System.Windows.Forms.Button
    Friend WithEvents CrearRecordatorio3 As System.Windows.Forms.Button
    Friend WithEvents EliminarRecordatorio2 As System.Windows.Forms.Button
    Friend WithEvents CrearRecordatorio2 As System.Windows.Forms.Button
    Friend WithEvents TextOculto As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
