'
' Created by SharpDevelop.
' User: Docente
' Date: 01/02/2023
' Time: 11:14 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.proveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.bajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.buscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.listarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.partesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.bajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.actualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.buscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.tipoParteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.bajasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.actualizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.listarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.clientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.najasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.actualizarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.listarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.proveedoresToolStripMenuItem, Me.partesToolStripMenuItem, Me.tipoParteToolStripMenuItem, Me.clientesToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(604, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'proveedoresToolStripMenuItem
		'
		Me.proveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altaToolStripMenuItem, Me.bajaToolStripMenuItem, Me.buscarToolStripMenuItem, Me.listarToolStripMenuItem})
		Me.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem"
		Me.proveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
		Me.proveedoresToolStripMenuItem.Text = "proveedores"
		'
		'altaToolStripMenuItem
		'
		Me.altaToolStripMenuItem.Name = "altaToolStripMenuItem"
		Me.altaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.altaToolStripMenuItem.Text = "alta"
		'
		'bajaToolStripMenuItem
		'
		Me.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem"
		Me.bajaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.bajaToolStripMenuItem.Text = "baja"
		'
		'buscarToolStripMenuItem
		'
		Me.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem"
		Me.buscarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.buscarToolStripMenuItem.Text = "actualizar"
		'
		'listarToolStripMenuItem
		'
		Me.listarToolStripMenuItem.Name = "listarToolStripMenuItem"
		Me.listarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.listarToolStripMenuItem.Text = "listar"
		'
		'partesToolStripMenuItem
		'
		Me.partesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altasToolStripMenuItem, Me.bajasToolStripMenuItem, Me.actualizarToolStripMenuItem, Me.buscarToolStripMenuItem1, Me.mostrarToolStripMenuItem})
		Me.partesToolStripMenuItem.Name = "partesToolStripMenuItem"
		Me.partesToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
		Me.partesToolStripMenuItem.Text = "partes"
		'
		'altasToolStripMenuItem
		'
		Me.altasToolStripMenuItem.Name = "altasToolStripMenuItem"
		Me.altasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.altasToolStripMenuItem.Text = "altas"
		'
		'bajasToolStripMenuItem
		'
		Me.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem"
		Me.bajasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.bajasToolStripMenuItem.Text = "bajas"
		'
		'actualizarToolStripMenuItem
		'
		Me.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem"
		Me.actualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.actualizarToolStripMenuItem.Text = "actualizar"
		'
		'buscarToolStripMenuItem1
		'
		Me.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1"
		Me.buscarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.buscarToolStripMenuItem1.Text = "buscar"
		'
		'tipoParteToolStripMenuItem
		'
		Me.tipoParteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altasToolStripMenuItem1, Me.bajasToolStripMenuItem1, Me.actualizarToolStripMenuItem1, Me.listarToolStripMenuItem1})
		Me.tipoParteToolStripMenuItem.Name = "tipoParteToolStripMenuItem"
		Me.tipoParteToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
		Me.tipoParteToolStripMenuItem.Text = "tipoParte"
		'
		'altasToolStripMenuItem1
		'
		Me.altasToolStripMenuItem1.Name = "altasToolStripMenuItem1"
		Me.altasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.altasToolStripMenuItem1.Text = "altas"
		'
		'bajasToolStripMenuItem1
		'
		Me.bajasToolStripMenuItem1.Name = "bajasToolStripMenuItem1"
		Me.bajasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.bajasToolStripMenuItem1.Text = "bajas"
		'
		'actualizarToolStripMenuItem1
		'
		Me.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1"
		Me.actualizarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.actualizarToolStripMenuItem1.Text = "actualizar"
		'
		'listarToolStripMenuItem1
		'
		Me.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1"
		Me.listarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.listarToolStripMenuItem1.Text = "listar"
		'
		'clientesToolStripMenuItem
		'
		Me.clientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altasToolStripMenuItem2, Me.najasToolStripMenuItem, Me.actualizarToolStripMenuItem2, Me.listarToolStripMenuItem2})
		Me.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem"
		Me.clientesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
		Me.clientesToolStripMenuItem.Text = "clientes"
		'
		'altasToolStripMenuItem2
		'
		Me.altasToolStripMenuItem2.Name = "altasToolStripMenuItem2"
		Me.altasToolStripMenuItem2.Size = New System.Drawing.Size(124, 22)
		Me.altasToolStripMenuItem2.Text = "altas"
		'
		'najasToolStripMenuItem
		'
		Me.najasToolStripMenuItem.Name = "najasToolStripMenuItem"
		Me.najasToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
		Me.najasToolStripMenuItem.Text = "bajas"
		'
		'actualizarToolStripMenuItem2
		'
		Me.actualizarToolStripMenuItem2.Name = "actualizarToolStripMenuItem2"
		Me.actualizarToolStripMenuItem2.Size = New System.Drawing.Size(124, 22)
		Me.actualizarToolStripMenuItem2.Text = "actualizar"
		'
		'listarToolStripMenuItem2
		'
		Me.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2"
		Me.listarToolStripMenuItem2.Size = New System.Drawing.Size(124, 22)
		Me.listarToolStripMenuItem2.Text = "listar"
		'
		'mostrarToolStripMenuItem
		'
		Me.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem"
		Me.mostrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.mostrarToolStripMenuItem.Text = "mostrar"
		AddHandler Me.mostrarToolStripMenuItem.Click, AddressOf Me.MostrarToolStripMenuItemClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(604, 274)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "pry_net_enero_2023"
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private mostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private listarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private actualizarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private najasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private altasToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private clientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private listarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private actualizarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private bajasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private altasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private tipoParteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private buscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private actualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private bajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private altasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private partesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private listarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private buscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private bajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private altaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private proveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
