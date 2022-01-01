Public Class Bitacora
    Private dt As New DataTable
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbBuscar.Items.Add("nombre_PC")
        cbbBuscar.Items.Add("fechaIngreso")
        cbbBuscar.Items.Add("hora")
        cbbBuscar.Items.Add("usuario_sistema")
        cbbBuscar.Items.Add("accion")
        cbbBuscar.Text = "nombre_PC"

        mostrar()
        limpiar()
    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fBitacora

            dt = func.mostrar
            dataListado.Columns.Item("eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                dataListado.ColumnHeadersVisible = True
            Else
                dataListado.DataSource = Nothing
                dataListado.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscar()

    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = cbbBuscar.Text & " like '" & txtBuscar.Text & "%'"
            If dv.Count <> 0 Then
                dataListado.DataSource = dv
                ocultarColumna()
            Else
                dataListado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ocultarColumna()

        'dataListado.Columns(1).Visible = False

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        buscar()

    End Sub

    Private Sub limpiar()
        txtBuscar.Text = ""
        cbbBuscar.Text = "nombre_PC"
        RbMInsert.Checked = False
        RBDelete.Checked = False
        RBupdate.Checked = False
    End Sub


    Private Sub RbMInsert_CheckedChanged(sender As Object, e As EventArgs) Handles RbMInsert.CheckedChanged
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "accion" & " like '" & "Inserción" & "%'"
            If dv.Count <> 0 Then
                dataListado.DataSource = dv
                ocultarColumna()
            Else
                dataListado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RBupdate_CheckedChanged(sender As Object, e As EventArgs) Handles RBupdate.CheckedChanged
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "accion" & " like '" & "Actualización" & "%'"
            If dv.Count <> 0 Then
                dataListado.DataSource = dv
                ocultarColumna()
            Else
                dataListado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RBDelete_CheckedChanged(sender As Object, e As EventArgs) Handles RBDelete.CheckedChanged
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "accion" & " like '" & "eliminación" & "%'"
            If dv.Count <> 0 Then
                dataListado.DataSource = dv
                ocultarColumna()
            Else
                dataListado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BnLimpiar_Click(sender As Object, e As EventArgs) Handles BnLimpiar.Click
        limpiar()
        mostrar()
    End Sub
End Class