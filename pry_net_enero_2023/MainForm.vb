'
' Created by SharpDevelop.
' User: Docente
' Date: 01/02/2023
' Time: 11:14 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MostrarToolStripMenuItemClick(sender As Object, e As EventArgs)
		My.Forms.frmmostrarPartes.ShowDialog
	End Sub
End Class
