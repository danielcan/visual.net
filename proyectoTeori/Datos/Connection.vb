Imports System.Data.SqlClient
Public Class Connection


	Protected connecti As New SqlConnection

	Protected Function conexiondb() As Boolean
		Try
			connecti = New SqlConnection("Data Source=DESKTOP-OQV1GKC\LOCALHOST;initial catalog=DB_Juzgado;integrated security=True")
			connecti.Open()
			Return True
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
	End Function

	Public Function desconecciondb() As Boolean
		Try
			If connecti.State = ConnectionState.Open Then
				connecti.Close()
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try

	End Function

End Class
