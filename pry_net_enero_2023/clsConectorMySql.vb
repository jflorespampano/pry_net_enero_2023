'
' Created by SharpDevelop.
' User: Docente
' Date: 02/02/2023
' Time: 07:56 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsConectorMySql
	Private Shared cadCon As String= _ 
		"server=localhost;user id=root; password=; database=provpar2; pooling=false"

	public shared function cadenaConexion As string 
			return cadCon
	End function
End Class
