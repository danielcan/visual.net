Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Public Class MostrarAbogados
	Dim Cn As New SqlConnection("Data Source=DESKTOP-OQV1GKC\LOCALHOST;initial catalog=DB_Juzgado;integrated security=True")
	Dim cm As New SqlCommand
	Dim ds As New DataSet
	Dim dt As New SqlDataAdapter
	Dim Parametros As New ParameterFields()
	Dim Parametros1 As New ParameterFields()
	Dim PrimerParametro As New ParameterField()
	Dim PrimerParametro1 As New ParameterField()
	Dim SegundoParametro As New ParameterField()
	Dim discreteValue As New ParameterDiscreteValue()
	Private Sub MostrarAbogados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Cn.Open()

		cm.Connection = Cn
		cm.CommandTimeout = 15
		cm.Parameters.Clear()
		cm.CommandType = CommandType.StoredProcedure
		cm.CommandText = "Mostrar_Abogado"

		PrimerParametro.ParameterValueType = ParameterValueKind.StringParameter
		PrimerParametro.ParameterFieldName = "@cod_Abogado"
		'	SegundoParametro.ParameterValueType = ParameterValueKind.StringParameter
		'SegundoParametro.ParameterFieldName = "null"
		discreteValue.Value = txtCodigo.Text
		PrimerParametro.CurrentValues.Add(discreteValue)
		'PrimerParametro1.CurrentValues.Add(SegundoParametro)
		Parametros.Add(PrimerParametro)
		'Parametros1.Add(PrimerParametro1)
		CrystalReportViewer1.ParameterFieldInfo = Parametros


		Dim Rpt As New MostrarAbogado
		Rpt.SetDataSource(ds)
		CrystalReportViewer1.ReportSource = Rpt
		Cn.Close()
	End Sub
End Class