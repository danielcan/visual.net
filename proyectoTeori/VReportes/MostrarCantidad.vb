Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Public Class MostrarCantidad

	Dim Cn As New SqlConnection("Data Source=DESKTOP-OQV1GKC\LOCALHOST;initial catalog=DB_Juzgado;integrated security=True")
	Dim cm As New SqlCommand
	Dim ds As New DataSet
	Dim dt As New SqlDataAdapter
	Dim Parametros As New ParameterFields()
	Dim PrimerParametro As New ParameterField()
	Dim discreteValue As New ParameterDiscreteValue()
	Private Sub MostrarCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buscar.Click
		Cn.Open()

		cm.Connection = Cn
		cm.CommandTimeout = 15
		cm.Parameters.Clear()
		cm.CommandType = CommandType.StoredProcedure
		cm.CommandText = "Mostrar_canti"

		PrimerParametro.ParameterValueType = ParameterValueKind.StringParameter
		PrimerParametro.ParameterFieldName = " @Ndelito"
		discreteValue.Value = txtNombre.Text
		PrimerParametro.CurrentValues.Add(discreteValue)
		Parametros.Add(PrimerParametro)
		CrystalReportViewer1.ParameterFieldInfo = Parametros


		Dim Rpt As New MostrarCanti
		Rpt.SetDataSource(ds)
		CrystalReportViewer1.ReportSource = Rpt
		Cn.Close()
	End Sub
End Class