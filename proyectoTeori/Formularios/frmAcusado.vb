Public Class frmAcusado


    Private dt As New DataTable
    Public bandera As New Integer

    Private Sub frmproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbBuscar.Items.Add("Acu_Codigo")
        cbbBuscar.Items.Add("Acu_Nombre")
        cbbBuscar.Items.Add("Acu_Genero")
        cbbBuscar.Items.Add("Acu_Codigo")

        CbNivelEdu.Items.Add("Profesional")
        CbNivelEdu.Items.Add("Primaria")
        CbNivelEdu.Items.Add("Secundaria")
        txtCodigo.Enabled = False
        '  txtNombre.Enabled = False
        '  txtPrecioCompra.TextAlign = HorizontalAlignment.Right
        '  txtPrecioVenta.TextAlign = HorizontalAlignment.Right
        '  txtExistencia.TextAlign = HorizontalAlignment.Right
        btnCancelar.Visible = True
        If bandera = 9 Then
            btnLimpiar.Visible = False
            Tedad.Visible = True
            nudEdad.Visible = True
            '   Tedad.Text = "Venta"
            nudEdad.Value = 0
            '     txtExistencia.Text = 0
        Else
            btnLimpiar.Visible = True
            '  Tedad.Visible = False
            nudEdad.Visible = False
        End If
        mostrar()
        limpiar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fAcusado
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
        'Try
        '    Dim ConjuntoDatos As New DataSet 'variable para almacenar daros
        '    ConjuntoDatos.Tables.Add(dt.Copy) 'copia lo de la tabla original
        '    Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0)) 'variable para filtrado de informacion
        '    VistaDatos.RowFilter = cbbBuscar.Text & " like '" & txtBuscar.Text & "%'" 'secuencia SQL de busqueda
        '    If VistaDatos.Count <> 0 Then 'validacion si se encuentra algun dato en la busqueda
        '        dataListado.DataSource = VistaDatos
        '        ocultarColumna()
        '    Else
        '        dataListado.DataSource = Nothing
        '    End If
        'Catch Evento As Exception
        '    MsgBox(Evento.Message) 'mensaje de error
        'End Try
    End Sub

    Private Sub ocultarColumna()
        ' dataListado.Columns(1).Visible = False
        '  dataListado.Columns(2).Visible = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub limpiar()
        txtCodigo.Text = ""
        txtColorPiel.Text = ""
        txtNombre.Text = ""
        txtPeso.Text = ""
        txtCiudadN.Text = ""
        txtDepartNaci.Text = ""
        txtPaisN.Text = ""
        txtIdentidad.Text = ""
        '  CheckedListGenero.Enabled = False
        txtColorOjo.Enabled = False
        txtDireccion.Enabled = False
        txtIdentidad.Enabled = False
        'txtRasgos.Enabled = False
        '  txtTelefono.Enabled = False
        ' txtOcupacion.Enabled = False
        '  txtHistorial.Enabled = False
        '  txtFoto.Enabled = False
        ' txtCorreo.Enabled = False
        '  txtAlias.Enabled = False
        txtPeso.Enabled = False
        txtPaisN.Enabled = False
        txtDepartNaci.Enabled = False
        txtCiudadN.Enabled = False
        CbNivelEdu.Enabled = False
        nudEdad.Enabled = False
        txtNombre.Enabled = False
        nudEstaturaAcu.Enabled = False
        'CheckedEstadoCivil.Enabled = False
        txtBuscar.Text = ""
        nudEdad.Value = 10
        'nudEstaturaAcu.Value = 100
        nudEstaturaAcu.Maximum = 210
        nudEdad.Visible = True
        ' txtExistencia.Text = 0


        dtpFechaNaci.Text = ""
        cbbBuscar.Text = ""
        dtpFechaNaci.Value = DateTime.Now
        '   dtpFechaVencimiento.Value = DateTime.Now.AddDays(15)
        txtColorPiel.Enabled = False
        ' txtOcupacion.Enabled = False
        dtpFechaNaci.Enabled = False
        btnActualizar.Visible = False
        btnGuardar.Visible = False
        btnEliminar.Visible = False
        ' btnBuscarOcupacion.Visible = False
        If bandera <> 9 Then
            btnInsertar.Visible = True
        Else
            btnInsertar.Visible = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        Dim dts As New eAcusado
        txtCodigo.Text = dataListado.SelectedCells.Item(1).Value
        txtNombre.Text = dataListado.SelectedCells.Item(2).Value
        Dim datr As String = dataListado.SelectedCells.Item(3).Value.ToString

        'aqui
        If (datr <> "Masculino") Then
            ckbMasculino.Checked = True
            'RBcasado.Checked = True
        ElseIf (datr <> "Femenino") Then
            ckbFemenino.Checked = True
        End If

        nudEstaturaAcu.TabIndex = dataListado.SelectedCells.Item(4).Value
        txtPeso.Text = dataListado.SelectedCells.Item(5).Value
        txtCiudadN.Text = dataListado.SelectedCells.Item(6).Value
        txtDepartNaci.Text = dataListado.SelectedCells.Item(7).Value
        txtPaisN.Text = dataListado.SelectedCells.Item(8).Value
        nudEdad.Value = dataListado.SelectedCells.Item(9).Value
        dtpFechaNaci.Value = dataListado.SelectedCells.Item(10).Value
        CbNivelEdu.Text = dataListado.SelectedCells.Item(11).Value
        Dim data As String = dataListado.SelectedCells.Item(12).Value.ToString


        If data <> "casado" Then
            RBcasado.Checked = True
        ElseIf data = "soltero" Then
            RBSoltero.Checked = True
        ElseIf data = "divorsiado" Then
            RBDivorciado.Checked = True
        End If



        txtColorPiel.Text = dataListado.SelectedCells.Item(13).Value
        txtColorOjo.Text = dataListado.SelectedCells.Item(14).Value
        txtCabello.Text = dataListado.SelectedCells.Item(15).Value
        txtIdentidad.Text = dataListado.SelectedCells.Item(16).Value
        txtDireccion.Text = dataListado.SelectedCells.Item(17).Value

        If bandera <> 9 Then
            btnActualizar.Visible = True
        Else
            btnActualizar.Visible = False
        End If
        btnInsertar.Visible = False
        habilitar()
    End Sub

    Private Sub habilitar()
        txtColorPiel.Enabled = True
        ' txtPrecioCompra.Enabled = True
        ' txtPrecioVenta.Enabled = True
        '  txtOcupacion.Enabled = True
        '     txtCatCodigo.Enabled = True
        dtpFechaNaci.Enabled = True
        'dtpFechaVencimiento.Enabled = True
        '  btnBuscarOcupacion.Visible = True
        'txtExistencia.Enabled = True
        ''  CheckedListGenero.Enabled = True
        txtColorOjo.Enabled = True
        txtDireccion.Enabled = True
        txtIdentidad.Enabled = True

        '  txtOcupacion.Enabled = True

        txtPeso.Enabled = True
        txtPaisN.Enabled = True
        txtDepartNaci.Enabled = True
        txtCiudadN.Enabled = True
        CbNivelEdu.Enabled = True
        btnActualizar.Enabled = True
        txtNombre.Enabled = True
        nudEstaturaAcu.Enabled = True
        ' CheckedEstadoCivil.Enabled = True
        nudEdad.Enabled = True
        nudEdad.Visible = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        limpiar()
        habilitar()
        btnGuardar.Visible = True
        btnInsertar.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtColorPiel.Text <> "" And
            txtNombre.Text <> "" And
            txtIdentidad.Text <> "" And
            txtDepartNaci.Text <> "" Then
            Try
                Dim dts As New eAcusado
                Dim func As New fAcusado

                dts.pAcu_Nombre = txtNombre.Text
                dts.pAcu_Peso = txtPeso.Text
                dts.pAcu_Ciudad_nacimiento = txtCiudadN.Text
                dts.pAcu_Departamento_nacimiento = txtDepartNaci.Text
                dts.pAcu_País_nacimiento = txtPaisN.Text
                dts.pAcu_Edad = nudEdad.Value
                dts.pAcu_fechaNacimiento = dtpFechaNaci.Value
                dts.pAcu_Nivel_educacion = CbNivelEdu.Text

                dts.pAcu_Color_piel = txtColorPiel.Text

                dts.pAcu_Color_ojos = txtColorOjo.Text
                dts.pAcu_Color_pelo = txtCabello.Text
                dts.pAcu_Identidad = txtIdentidad.Text

                dts.pAcu_Direccion = txtDireccion.Text
                dts.pAcu_Estatura = nudEstaturaAcu.Value

                If RBcasado.Checked = True Then
                    dts.pAcu_Estado_Civil = "casado"
                ElseIf RBDivorciado.Checked = True Then
                    dts.pAcu_Estado_Civil = "divorciado"
                ElseIf RBSoltero.Checked = True Then
                    dts.pAcu_Estado_Civil = "soltero"
                End If

                If ckbMasculino.Checked = True Then
                    dts.pAcu_Genero = "Masculino"
                ElseIf ckbFemenino.Checked = True Then
                    dts.pAcu_Genero = "Femenino"
                End If

                ' dts.gcatCodigo = txtCatCodigo.Text
                ' dts.gproDescripcion = txtDescripcion.Text
                ' dts.gproPrecioCompra = txtPrecioCompra.Text
                ' dts.gproFechaCompra = dtpFechaCompra.Value
                'dts.gproPrecioVenta = txtPrecioVenta.Text
                ' dts.gproFechaVencimiento = dtpFechaVencimiento.Value
                ' dts.gproExistencia = txtExistencia.Text
                If func.insertar(dts) Then
                    MessageBox.Show("Acusado fue registrado correctamente",
                                    "Guardando registro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Acusado no fue registrado correctamente",
                                    "Guardando registro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End If
                mostrar()
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar",
                            "Guardando registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtColorPiel.Text <> "" And
            txtCodigo.Text <> "" And
            txtNombre.Text <> "" Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Desea modificar los datos",
                            "Actualizando registro", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question)
            If resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim dts As New eAcusado
                    Dim func As New fAcusado
                    dts.pAcu_Nombre = txtNombre.Text
                    dts.pAcu_Peso = txtPeso.Text
                    dts.pAcu_Ciudad_nacimiento = txtCiudadN.Text
                    dts.pAcu_Departamento_nacimiento = txtDepartNaci.Text
                    dts.pAcu_País_nacimiento = txtPaisN.Text
                    dts.pAcu_Edad = nudEdad.Value
                    dts.pAcu_fechaNacimiento = dtpFechaNaci.Value
                    dts.pAcu_Nivel_educacion = CbNivelEdu.Text

                    dts.pAcu_Color_piel = txtColorPiel.Text

                    dts.pAcu_Color_ojos = txtColorOjo.Text
                    dts.pAcu_Color_pelo = txtCabello.Text
                    dts.pAcu_Identidad = txtIdentidad.Text

                    dts.pAcu_Direccion = txtDireccion.Text
                    dts.pAcu_Estatura = nudEstaturaAcu.Value

                    If RBcasado.Checked = True Then
                        dts.pAcu_Estado_Civil = "casado"
                    ElseIf RBDivorciado.Checked = True Then
                        dts.pAcu_Estado_Civil = "divorciado"
                    ElseIf RBSoltero.Checked = True Then
                        dts.pAcu_Estado_Civil = "soltero"
                    End If

                    If ckbMasculino.Checked = True Then
                        dts.pAcu_Genero = "Masculino"
                    ElseIf ckbFemenino.Checked = True Then
                        dts.pAcu_Genero = "Femenino"
                    End If

                    If func.actualizar(dts) Then
                        MessageBox.Show("Acusado fue actualizado correctamente",
                                        "Actualizando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Acusado no fue actualizado correctamente",
                                        "Actualizando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                    mostrar()
                    limpiar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando actualizado por el usuario",
                                "Actualizando registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta informacion para almacenar",
                            "Actualizando registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbxEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEliminar.CheckedChanged
        If cbxEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("eliminar").Visible = True
            btnEliminar.Visible = True
            btnInsertar.Visible = False
        Else
            dataListado.Columns.Item("eliminar").Visible = False
            btnEliminar.Visible = False
            btnInsertar.Visible = True
        End If
    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar los datos",
                        "Eliminando registro", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question)
        If resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim lineaMarcada As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If lineaMarcada Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("Acu_Codigo").Value)
                        Dim dts As New eAcusado
                        Dim func As New fAcusado
                        dts.pAcu_Codigo = llavePrimaria
                        If func.eliminar(dts) Then
                            MessageBox.Show("Acusado fue eliminado correctamente",
                                            "Eliminando registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Acusado no fue eliminado correctamente",
                                            "Elimando registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error)
                        End If
                    End If
                Next
                Call mostrar()
                Call limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion por el usuario",
                         "Eliminando registro", MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
            mostrar()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        mostrar()
        limpiar()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Private Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCategoria.Click
    '    frmcategoria.bandera = 9
    '    frmcategoria.ShowDialog()
    '    txtCatCodigo.Text = frmcategoria.txtCodigo.Text
    '    txtCategoria.Text = frmcategoria.txtDescripcion.Text
    'End Sub

    'Private Sub nudCompraVenta_ValueChanged(sender As Object, e As EventArgs) Handles nudEdadAcu.ValueChanged
    '    'If nudEdadAcu.Value > txtExistencia.Text Then
    '    '    nudEdadAcu.BackColor = Color.LightPink
    '    'ElseIf nudEdadAcu.Value <1 Then
    '    '    nudEdadAcu.BackColor = Color.LightPink
    '    'Else
    '    '    nudEdadAcu.BackColor = Color.White
    '    'End If
    'End Sub

    Private Sub btnBuscarOcupacion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpFechaNaci_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNaci.ValueChanged

    End Sub
End Class