Imports System.Data.SqlClient
Public Class fBitacora
	Inherits Connection
	Dim cmd As New SqlCommand

	Public Function mostrar() As DataTable
		Try
			conexiondb()
			cmd = New SqlCommand("mBitacora")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			If cmd.ExecuteNonQuery Then
				Dim dt As New DataTable
				Dim da As New SqlDataAdapter(cmd)
				da.Fill(dt)
				Return dt
			Else
				Return Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return Nothing
		Finally
			desconecciondb()
		End Try
	End Function

End Class
