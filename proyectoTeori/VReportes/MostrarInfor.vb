Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Public Class MostrarInfor
	Dim Cn As New SqlConnection("Data Source=DESKTOP-OQV1GKC\LOCALHOST;initial catalog=DB_Juzgado;integrated security=True")
	Dim cm As New SqlCommand
	Dim ds As New DataSet
	Dim dt As New SqlDataAdapter
	Dim Parametros As New ParameterFields()
	Dim PrimerParametro As New ParameterField()
	Dim discreteValue As New ParameterDiscreteValue()
	Private Sub MostrarInfor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Cn.Open()

		cm.Connection = Cn
		cm.CommandTimeout = 15
		cm.Parameters.Clear()
		cm.CommandType = CommandType.StoredProcedure
		cm.CommandText = "Mostrar_Info"

		PrimerParametro.ParameterValueType = ParameterValueKind.StringParameter
		PrimerParametro.ParameterFieldName = "@Nabogado"
		discreteValue.Value = txtCodigo.Text
		PrimerParametro.CurrentValues.Add(discreteValue)
		Parametros.Add(PrimerParametro)
		CrystalReportViewer1.ParameterFieldInfo = Parametros


		Dim Rpt As New MostrarInfo
		Rpt.SetDataSource(ds)
		CrystalReportViewer1.ReportSource = Rpt
		Cn.Close()
	End Sub
End Class