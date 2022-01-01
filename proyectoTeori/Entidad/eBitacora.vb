Public Class eBitacora
    Dim id As Integer
    Dim ingreso_sistemaIngreso, cierre_sistemaIngreso, fechaIngreso As Date
	Dim horaAccion As Date
	Dim usuario_sistema, nombre_PC, acción_realizada As String

	Public Property bid
		Get
			Return id
		End Get
		Set(value)
			id = value
		End Set
	End Property


	Public Property bingreso_sistemaIngreso
		Get
			Return ingreso_sistemaIngreso
		End Get
		Set(value)
			ingreso_sistemaIngreso = value
		End Set
	End Property

	Public Property bcierre_sistemaIngreso
		Get
			Return cierre_sistemaIngreso
		End Get
		Set(value)
			cierre_sistemaIngreso = value
		End Set
	End Property

	Public Property bfechaIngreso
		Get
			Return fechaIngreso
		End Get
		Set(value)
			fechaIngreso = value
		End Set
	End Property

	Public Property bhoraAccion
		Get
			Return horaAccion
		End Get
		Set(value)
			horaAccion = value
		End Set
	End Property

	Public Property busuario_sistema
		Get
			Return usuario_sistema
		End Get
		Set(value)
			usuario_sistema = value
		End Set
	End Property



	Public Property bnombre_PC
		Get
			Return nombre_PC
		End Get
		Set(value)
			nombre_PC = value
		End Set
	End Property

	Public Property bacción_realizada
		Get
			Return acción_realizada
		End Get
		Set(value)
			acción_realizada = value
		End Set
	End Property

	Public Sub Bitacora()

	End Sub

	Public Sub Bitacora(id As Integer, ingreso_sistemaIngreso As Date, cierre_sistemaIngreso As Date,
						fechaIngreso As Date, horaAccion As Date, usuario_sistema As String,
						nombre_PC As String, acción_realizada As String)

		bid = id
		bingreso_sistemaIngreso = ingreso_sistemaIngreso
		bcierre_sistemaIngreso = cierre_sistemaIngreso
		bfechaIngreso = fechaIngreso
		bhoraAccion = horaAccion
		busuario_sistema = usuario_sistema
		bnombre_PC = nombre_PC
		bacción_realizada = acción_realizada
	End Sub

End Class
