Public Class frmUsuario

    Private TablaDatos As New DataTable
    Public Bandera As New Boolean

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gb_MantenimientoDatos.BackColor = Color.FromArgb(100, 30, 139, 195)
        Gb_Datos.BackColor = Color.FromArgb(100, 30, 139, 195)

        Cmb_Buscar.Items.Add("id") 'llenado de Combobox
        Cmb_Buscar.Text = "id"
        Cmb_Buscar.Text = "nombre"
        Cmb_Buscar.Text = "passwd"
        txtId.Enabled = False 'bloqueo de txt
        If Bandera Then 'Validacion de botones que estaran visibles al abrir el formulario
            Btn_Limpiar.Visible = False
            Btn_Cancelar.Visible = False
        Else
            Btn_Limpiar.Visible = True
            Btn_Cancelar.Visible = True
        End If
        Mostrar() 'llamado de Mostrar al iniciar el programa
        Limpiar() 'llamado del limpiar en caso que hallan datos resagados de procesos anteriores
    End Sub

    Private Sub Mostrar()
        Try
            Dim Funcion As New fUsuario  'intancia
            TablaDatos = Funcion.Mostrar 'llenado de variable
            Dgv_Listado.Columns.Item("eliminar").Visible = False 'comprobacion si hay datos
            If TablaDatos.Rows.Count <> 0 Then
                Dgv_Listado.DataSource = TablaDatos 'en caso que hay datos mostrar 
                Dgv_Listado.ColumnHeadersVisible = True 'encabezados del data
            Else
                Dgv_Listado.DataSource = Nothing 'en caso que no hay datos no llama nada
                Dgv_Listado.ColumnHeadersVisible = False 'encabezados vacios del data
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message) 'mensaje de error
        End Try
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim ConjuntoDatos As New DataSet 'variable para almacenar daros
            ConjuntoDatos.Tables.Add(TablaDatos.Copy) 'copia lo de la tabla original
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0)) 'variable para filtrado de informacion
            VistaDatos.RowFilter = Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'" 'secuencia SQL de busqueda
            If VistaDatos.Count <> 0 Then 'validacion si se encuentra algun dato en la busqueda
                Dgv_Listado.DataSource = VistaDatos
                OcultarColumna()
            Else
                Dgv_Listado.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message) 'mensaje de error
        End Try
    End Sub

    Private Sub OcultarColumna()
        Dgv_Listado.Columns(1).Visible = False 'ocualtar la columna de producto

    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar() 'validacion para que se realice cada vez que cambia el texto
    End Sub

    Private Sub Limpiar() 'procedimiento para limpiar el formulario
        'limpiar 
        txtId.Text = ""
        txtNombre.Text = ""
        txtPasswd.Text = ""
        Txt_Buscar.Text = ""
        Cmb_Buscar.Text = "id"

        'desabilitar

        txtId.Enabled = False
        txtNombre.Enabled = False
        txtPasswd.Enabled = False
        Txt_Buscar.Enabled = False
        Btn_Actualizar.Visible = False
        Btn_Guardar.Visible = False
        Btn_Actualizar.Visible = False
        Btn_Eliminar.Visible = False
        Btn_Insertar.Enabled = True



        If Bandera Then 'comportamiento de Bandera
            Btn_Insertar.Visible = False
        Else
            Btn_Insertar.Visible = True
        End If
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion() 'mover informacion del DataGrid a los TextBox
        If Bandera Then
            Btn_Actualizar.Visible = False 'Desaparecer el boton si no se de a seleccionado una celda
        Else
            Btn_Actualizar.Visible = True 'Hacer visible boton al seleccionar una celda
        End If
        Btn_Insertar.Visible = False 'desaparecer el boton de insertar
        Habilitar() 'hablilitar Txt_Descripcion 
    End Sub

    Private Sub TrasladoInformacion()
        txtId.Text = Dgv_Listado.SelectedCells.Item(1).Value 'mover el codigo del DGV al Txt Codigo

        txtNombre.Text = Dgv_Listado.SelectedCells.Item(2).Value
        txtPasswd.Text = Dgv_Listado.SelectedCells.Item(3).Value


    End Sub

    Private Sub Habilitar()
        'habilitar el txt de descripcion



        txtId.Enabled = True
        txtNombre.Enabled = True
        txtPasswd.Enabled = True



    End Sub

    Private Sub Btn_Insertar_Click(sender As Object, e As EventArgs) Handles Btn_Insertar.Click
        Limpiar()
        Habilitar()
        Btn_Insertar.Enabled = False
        Btn_Guardar.Visible = True
        Btn_Insertar.Visible = True
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If txtId.Text <> "" And
            txtNombre.Text <> "" And 'validacion para que no quede ningun campo vacio
            txtPasswd.Text <> "" Then
            Try
                Dim TablaDatos As New eUsuario
                Dim Funcion As New fUsuario

                TablaDatos.pid = txtId.Text
                TablaDatos.pnombre = txtNombre.Text
                TablaDatos.ppasswd = txtPasswd.Text


                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("El Usuario fue registrado correctamente",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Information) 'mensaje de guardado con exito
                Else
                    MessageBox.Show("El Usuario no fue registrado correctamente",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Error) 'mensaje de error al guardado
                End If
                Mostrar() 'llamar metodo de mostrar
                Limpiar() 'llamar metodo de limpiar
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Information) 'mensaje al usuario de que no puede dejar vacio ningun campo
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If txtId.Text <> "" And
            txtNombre.Text <> "" And 'validacion para que no quede ningun campo vacio
            txtPasswd.Text <> "" Then  'validacion para que no quede en blanco
            Dim Resultado As DialogResult 'mensaje flotante para saber si quiere actualizar
            Resultado = MessageBox.Show("Desea Modificar los datos",
            "Actualizando Registro", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eUsuario
                    Dim Funcion As New fUsuario

                    TablaDatos.pid = txtId.Text
                    TablaDatos.pnombre = txtNombre.Text
                    TablaDatos.ppasswd = txtPasswd.Text


                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Usuario fue actualizado correctamente",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information) 'mensaje de cancelacion de actualizacion
                    Else
                        MessageBox.Show("Usuario no fue actualizado correctamente",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information) 'mensaje de cancelacion de actualizacion
                    End If
                    Mostrar()
                    Limpiar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Usuario",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information) 'mensaje de cancelacion de actualizacion
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information) 'mensaje al usuario de que no puede dejar vacio ningun campo
        End If
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.CheckState = CheckState.Checked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = True 'al marcar el checkbox eliminar habilitar la columna eliminar el botn de eliminar y desabilitar el boton insertar
            Btn_Eliminar.Visible = True
            Btn_Insertar.Visible = False
        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Btn_Eliminar.Visible = False
            Btn_Insertar.Visible = True
        End If
    End Sub

    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim Resultado As DialogResult 'mensaje flotante para saber si quiere Eliminar
        Resultado = MessageBox.Show("Desea Eliminar los datos",
        "Eliminando Registro", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("id").Value)
                        Dim TablaDatos As New eUsuario
                        Dim Funcion As New fUsuario
                        TablaDatos.pid = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Usuario fue eliminado correctamente",
                    "Eliminando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information) 'mensaje de cancelacion de actualizacion
                        Else
                            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information) 'mensaje de cancelacion de actualizacion
                        End If
                    End If
                Next
                Call Mostrar()
                Call Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information) 'mensaje de cancelacion de Eliminacion
            Call Mostrar()
            Call Limpiar()
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Mostrar()
        Limpiar()
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    'Private Sub Btn_Tipo_Click(sender As Object, e As EventArgs)
    '    frmDireccion.Bandera = False
    '    frmDireccion.ShowDialog()
    '    txtdirCodigot.Text = frmDireccion.txtCodigo.Text
    '    txtdireccion1.Text = frmDireccion.txtDireccion1.Text
    'End Sub


End Class