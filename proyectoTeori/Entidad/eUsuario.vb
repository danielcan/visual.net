Public Class eUsuario
	Dim id, nombre, passwd As String

	Public Property pid
		Get
			Return id
		End Get
		Set(value)
			id = value
		End Set
	End Property

	Public Property pnombre
		Get
			Return nombre
		End Get
		Set(value)
			nombre = value
		End Set
	End Property

	Public Property ppasswd
		Get
			Return passwd
		End Get
		Set(value)
			passwd = value
		End Set
	End Property

	Public Sub New()

	End Sub


	Public Sub New(idD As String, nombre As String, passwd As String)
		pid = id
		pnombre = nombre
		ppasswd = passwd
	End Sub
End Class
