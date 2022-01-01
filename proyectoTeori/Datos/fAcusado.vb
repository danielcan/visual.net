Imports System.Data.SqlClient


Public Class fAcusado
	Inherits Connection
	Dim cmd As New SqlCommand

	Public Function mostrar() As DataTable
		Try
			conexiondb()
			cmd = New SqlCommand("mTBL_Acusados")
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

	Public Function insertar(dats As eAcusado) As Boolean
		Try
			conexiondb()
			cmd = New SqlCommand("iTBL_Acusados")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			cmd.Parameters.AddWithValue("@Acu_Nombre", dats.pAcu_Nombre)
			cmd.Parameters.AddWithValue("@Acu_Genero", dats.pAcu_Genero)
			cmd.Parameters.AddWithValue("@Acu_Estatura", dats.pAcu_Estatura)
			cmd.Parameters.AddWithValue("@Acu_Peso", dats.pAcu_Peso)
			cmd.Parameters.AddWithValue("@Acu_Ciudad_nacimiento", dats.pAcu_Ciudad_nacimiento)
			cmd.Parameters.AddWithValue("@Acu_Departamento_nacimiento", dats.pAcu_Departamento_nacimiento)
			cmd.Parameters.AddWithValue("@Acu_País_nacimiento", dats.pAcu_País_nacimiento)
			cmd.Parameters.AddWithValue("@Acu_Edad", dats.pAcu_Edad)
			cmd.Parameters.AddWithValue("@Acu_fechaNacimiento", dats.pAcu_fechaNacimiento)
			cmd.Parameters.AddWithValue("@Acu_Nivel_educacion", dats.pAcu_Nivel_educacion)
			cmd.Parameters.AddWithValue("@Acu_Estado_Civil", dats.pAcu_Estado_Civil)
			cmd.Parameters.AddWithValue("@Acu_Color_piel", dats.pAcu_Color_piel)
			cmd.Parameters.AddWithValue("@Acu_Color_ojos", dats.pAcu_Color_ojos)
			cmd.Parameters.AddWithValue("@Acu_Color_pelo", dats.pAcu_Color_pelo)
			cmd.Parameters.AddWithValue("@Acu_Identidad", dats.pAcu_Identidad)
			cmd.Parameters.AddWithValue("@Acu_Direccion", dats.pAcu_Direccion)

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


	Public Function actualizar(dats As eAcusado) As Boolean
		Try
			conexiondb()
			cmd = New SqlCommand("uTBL_Acusados")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			cmd.Parameters.AddWithValue("@Acu_Nombre", dats.pAcu_Nombre)
			cmd.Parameters.AddWithValue("@Acu_Genero", dats.pAcu_Genero)
			cmd.Parameters.AddWithValue("@Acu_Estatura", dats.pAcu_Estatura)
			cmd.Parameters.AddWithValue("@Acu_Peso", dats.pAcu_Peso)
			cmd.Parameters.AddWithValue("@Acu_Ciudad_nacimiento", dats.pAcu_Ciudad_nacimiento)
			cmd.Parameters.AddWithValue("@Acu_Departamento_nacimiento", dats.pAcu_Departamento_nacimiento)
			cmd.Parameters.AddWithValue("@Acu_País_nacimiento", dats.pAcu_País_nacimiento)
			cmd.Parameters.AddWithValue("@Acu_Edad", dats.pAcu_Edad)
			cmd.Parameters.AddWithValue("@Acu_fechaNacimiento", dats.pAcu_fechaNacimiento)
			cmd.Parameters.AddWithValue("@Acu_Nivel_educacion", dats.pAcu_Nivel_educacion)
			cmd.Parameters.AddWithValue("@Acu_Estado_Civil", dats.pAcu_Estado_Civil)
			cmd.Parameters.AddWithValue("@Acu_Color_piel", dats.pAcu_Color_piel)
			cmd.Parameters.AddWithValue("@Acu_Color_ojos", dats.pAcu_Color_ojos)
			cmd.Parameters.AddWithValue("@Acu_Color_pelo", dats.pAcu_Color_pelo)
			cmd.Parameters.AddWithValue("@Acu_Identidad", dats.pAcu_Identidad)
			cmd.Parameters.AddWithValue("@Acu_Direccion", dats.pAcu_Direccion)

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

	Public Function eliminar(dats As eAcusado) As Boolean
		Try
			conexiondb()
			cmd = New SqlCommand("dTBL_Acusados")
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Connection = connecti
			cmd.Parameters.Add("@Acu_Codigo", SqlDbType.NVarChar, 50).Value = dats.pAcu_Codigo
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

	'Public Function validarusuario(ByVal dts As eAcusado) As DataTable

	'	conexiondb()
	'	cmd = New SqlCommand("inicio")
	'	cmd.CommandType = CommandType.StoredProcedure
	'	cmd.Connection = connecti

	'	cmd.Parameters.AddWithValue("@Can_Usuario", dts.pCan_Usuario)
	'	cmd.Parameters.AddWithValue("@Can_Contra", dts.pCan_Contra)

	'	If cmd.ExecuteNonQuery Then
	'		Using dt As New DataTable
	'			Using da As New SqlDataAdapter(cmd)
	'				da.Fill(dt)
	'				Return dt
	'			End Using
	'		End Using
	'	Else
	'		Return Nothing
	'	End If
	'End Function

End Class
