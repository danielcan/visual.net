Public Class frmLogin

	Public connection As SqlClient.SqlConnection
	Dim accion As String, id As String, sql As String
	Dim res As Integer, nom, pass, pass1 As String
	Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
	Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Application.Exit()
	End Sub

	Private Sub btnEntrada_Click_1(sender As Object, e As EventArgs) Handles btnEntrada.Click
		Call Me.verificar()
	End Sub


	Dim ds As DataSet




	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Label1.BackColor = Color.FromArgb(100, 30, 139, 195)
		btnEntrada.BackColor = Color.FromArgb(100, 30, 139, 195)

	End Sub



	'Connection DataBase.
	Public Sub Connect()
		connection = New SqlClient.SqlConnection
		connection.ConnectionString = ("Server=DESKTOP-OQV1GKC\LOCALHOST; database=DB_Juzgado;Integrated Security=True")
		connection.Open()
	End Sub




	Private Sub verificar()
		id = txtUsuario.Text
		pass = txtPassw.Text

		If id <> "" And pass <> "" Then
			sql = "exec ver_users '" + id + "'"
			Connect()
			com = New SqlClient.SqlCommand(sql, connection)
			dr = com.ExecuteReader
			If dr.Read Then
				If id = dr(1) And pass = dr(2) Then
					'MsgBox("Contraseña Correcta", MsgBoxStyle.Exclamation, "Acceso Permitido")
					Dim a As New frmMenu
					a.Show()

				Else
					MsgBox("Contraseña incorrecta", MsgBoxStyle.Exclamation, "Acceso Denegado")
				End If
			Else
				MsgBox("Por favor Registrese", MsgBoxStyle.Exclamation, "Acceso Denegado")
			End If
		End If
	End Sub



End Class