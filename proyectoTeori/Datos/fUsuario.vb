Imports System.Data.SqlClient
Public Class fUsuario
	Inherits Connection
	Dim cmd As New SqlCommand

	Public Function mostrar() As DataTable
		Try
			conexiondb()
			cmd = New SqlCommand("mTBL_usuarios")
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

	Public Function insertar(dats As eUsuario) As Boolean
		Try
			conexiondb()
			cmd = New SqlCommand("iTBL_usuarios")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			cmd.Parameters.AddWithValue("@id", dats.pid)
			cmd.Parameters.AddWithValue("@nombre", dats.pnombre)
			cmd.Parameters.AddWithValue("@passwd", dats.ppasswd)

			If cmd.ExecuteNonQuery Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		Finally
			desconecciondb()
		End Try
	End Function


	Public Function actualizar(dats As eUsuario) As Boolean
		Try
			conexiondb()
			cmd = New SqlCommand("uTBL_usuarios")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			cmd.Parameters.AddWithValue("@id", dats.pid)
			cmd.Parameters.AddWithValue("@nombre", dats.pnombre)
			cmd.Parameters.AddWithValue("@passwd", dats.ppasswd)

			If cmd.ExecuteNonQuery Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		Finally
			desconecciondb()
		End Try
	End Function

	Public Function eliminar(dats As eUsuario) As Boolean
		Try
			conexiondb()
			cmd = New SqlCommand("dTBL_usuarios")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dats.pid
			If cmd.ExecuteNonQuery Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		Finally
			desconecciondb()
		End Try
	End Function

End Class
