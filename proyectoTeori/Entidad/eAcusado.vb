
Public Class eAcusado
    Dim Acu_Nombre As String, Acu_Genero As Char
	Dim Acu_Ciudad_nacimiento, Acu_Departamento_nacimiento, Acu_País_nacimiento As String
	Dim Acu_Edad, Acu_Peso, Acu_Estatura, Acu_Codigo As Integer
	Dim Acu_fechaNacimiento As Date, Acu_Nivel_educacion As String, Acu_Estado_Civil As Char, Acu_Color_piel As String
	Dim Acu_Color_ojos, Acu_Color_pelo, Acu_Identidad, Acu_Direccion As String

	Public Property pAcu_Codigo
		Get
			Return Acu_Codigo
		End Get
		Set(value)
			Acu_Codigo = value
		End Set
	End Property

	Public Property pAcu_Nombre
		Get
			Return Acu_Nombre
		End Get
		Set(value)
			Acu_Nombre = value
		End Set
	End Property

	Public Property pAcu_Genero
		Get
			Return Acu_Genero
		End Get
		Set(value)
			Acu_Genero = value
		End Set
	End Property

	Public Property pAcu_Ciudad_nacimiento
		Get
			Return Acu_Ciudad_nacimiento
		End Get
		Set(value)
			Acu_Ciudad_nacimiento = value
		End Set
	End Property


	Public Property pAcu_Departamento_nacimiento
		Get
			Return Acu_Departamento_nacimiento
		End Get
		Set(value)
			Acu_Departamento_nacimiento = value
		End Set
	End Property

	Public Property pAcu_País_nacimiento
		Get
			Return Acu_País_nacimiento
		End Get
		Set(value)
			Acu_País_nacimiento = value
		End Set
	End Property


	Public Property pAcu_Edad
		Get
			Return Acu_Edad
		End Get
		Set(value)
			Acu_Edad = value
		End Set
	End Property


	Public Property pAcu_Peso
		Get
			Return Acu_Peso
		End Get
		Set(value)
			Acu_Peso = value
		End Set
	End Property

	Public Property pAcu_Estatura
		Get
			Return Acu_Estatura
		End Get
		Set(value)
			Acu_Estatura = value
		End Set
	End Property


	Public Property pAcu_fechaNacimiento
		Get
			Return Acu_fechaNacimiento
		End Get
		Set(value)
			Acu_fechaNacimiento = value
		End Set
	End Property

	Public Property pAcu_Nivel_educacion
		Get
			Return Acu_Nivel_educacion
		End Get
		Set(value)
			Acu_Nivel_educacion = value
		End Set
	End Property

	Public Property pAcu_Estado_Civil
		Get
			Return Acu_Estado_Civil
		End Get
		Set(value)
			Acu_Estado_Civil = value
		End Set
	End Property


	Public Property pAcu_Color_piel
		Get
			Return Acu_Color_piel
		End Get
		Set(value)
			Acu_Color_piel = value
		End Set
	End Property

	Public Property pAcu_Color_ojos
		Get
			Return Acu_Color_ojos
		End Get
		Set(value)
			Acu_Color_ojos = value
		End Set
	End Property

	Public Property pAcu_Color_pelo
		Get
			Return Acu_Color_pelo
		End Get
		Set(value)
			Acu_Color_pelo = value
		End Set
	End Property

	Public Property pAcu_Identidad
		Get
			Return Acu_Identidad
		End Get
		Set(value)
			Acu_Identidad = value
		End Set
	End Property

	Public Property pAcu_Direccion
		Get
			Return Acu_Direccion
		End Get
		Set(value)
			Acu_Direccion = value
		End Set
	End Property

	'Metodo Constructor vacio
	Public Sub New()

	End Sub

	'Metodo Constructor
	Public Sub New(Acu_Nombre As String, Acu_Genero As Char,
	Acu_Ciudad_nacimiento As String, Acu_Departamento_nacimiento As String, Acu_País_nacimiento As String,
		Acu_Edad As Integer, Acu_Peso As Integer, Acu_Estatura As Integer, Acu_Codigo As Integer,
		 Acu_fechaNacimiento As Date, Acu_Nivel_educacion As String, Acu_Estado_Civil As Char, Acu_Color_piel As String,
		 Acu_Color_ojos As String, Acu_Color_pelo As String, Acu_Identidad As String, Acu_Direccion As String)
		pAcu_Codigo = Acu_Codigo
		pAcu_Nombre = Acu_Nombre
		pAcu_Genero = Acu_Genero
		pAcu_Estatura = Acu_Estatura
		pAcu_Peso = Acu_Peso
		pAcu_Ciudad_nacimiento = Acu_Ciudad_nacimiento
		pAcu_Departamento_nacimiento = Acu_Departamento_nacimiento
		pAcu_País_nacimiento = Acu_País_nacimiento
		pAcu_Edad = Acu_Edad
		pAcu_fechaNacimiento = Acu_fechaNacimiento
		pAcu_Nivel_educacion = Acu_Nivel_educacion
		pAcu_Estado_Civil = Acu_Estado_Civil
		pAcu_Color_piel = Acu_Color_piel
		pAcu_Color_ojos = Acu_Color_ojos
		pAcu_Color_pelo = Acu_Color_pelo
		pAcu_Identidad = Acu_Identidad
		pAcu_Direccion = Acu_Direccion
	End Sub


End Class










