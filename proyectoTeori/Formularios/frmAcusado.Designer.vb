<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAcusado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GDatos = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cbxEliminar = New System.Windows.Forms.CheckBox()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbbBuscar = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GRegistro = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCabello = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtColorOjo = New System.Windows.Forms.TextBox()
        Me.GroupEstado = New System.Windows.Forms.GroupBox()
        Me.RBDivorciado = New System.Windows.Forms.RadioButton()
        Me.RBcasado = New System.Windows.Forms.RadioButton()
        Me.RBSoltero = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CbNivelEdu = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNaci = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPaisN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDepartNaci = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCiudadN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudEstaturaAcu = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckbMasculino = New System.Windows.Forms.CheckBox()
        Me.ckbFemenino = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Tedad = New System.Windows.Forms.Label()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtColorPiel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GDatos.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRegistro.SuspendLayout()
        Me.GroupEstado.SuspendLayout()
        CType(Me.nudEstaturaAcu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GDatos
        '
        Me.GDatos.Controls.Add(Me.btnEliminar)
        Me.GDatos.Controls.Add(Me.cbxEliminar)
        Me.GDatos.Controls.Add(Me.dataListado)
        Me.GDatos.Controls.Add(Me.txtBuscar)
        Me.GDatos.Controls.Add(Me.cbbBuscar)
        Me.GDatos.Location = New System.Drawing.Point(645, 32)
        Me.GDatos.Name = "GDatos"
        Me.GDatos.Size = New System.Drawing.Size(584, 649)
        Me.GDatos.TabIndex = 7
        Me.GDatos.TabStop = False
        Me.GDatos.Text = "Datos"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(118, 382)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'cbxEliminar
        '
        Me.cbxEliminar.AutoSize = True
        Me.cbxEliminar.Location = New System.Drawing.Point(7, 386)
        Me.cbxEliminar.Name = "cbxEliminar"
        Me.cbxEliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbxEliminar.TabIndex = 3
        Me.cbxEliminar.Text = "Eliminar"
        Me.cbxEliminar.UseVisualStyleBackColor = True
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.dataListado.Location = New System.Drawing.Point(7, 54)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(553, 322)
        Me.dataListado.TabIndex = 2
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(135, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(150, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'cbbBuscar
        '
        Me.cbbBuscar.FormattingEnabled = True
        Me.cbbBuscar.Location = New System.Drawing.Point(7, 20)
        Me.cbbBuscar.Name = "cbbBuscar"
        Me.cbbBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbbBuscar.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(457, 607)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GRegistro
        '
        Me.GRegistro.Controls.Add(Me.Label3)
        Me.GRegistro.Controls.Add(Me.txtCabello)
        Me.GRegistro.Controls.Add(Me.Label18)
        Me.GRegistro.Controls.Add(Me.txtDireccion)
        Me.GRegistro.Controls.Add(Me.Label17)
        Me.GRegistro.Controls.Add(Me.txtIdentidad)
        Me.GRegistro.Controls.Add(Me.Label16)
        Me.GRegistro.Controls.Add(Me.txtColorOjo)
        Me.GRegistro.Controls.Add(Me.GroupEstado)
        Me.GRegistro.Controls.Add(Me.Label15)
        Me.GRegistro.Controls.Add(Me.CbNivelEdu)
        Me.GRegistro.Controls.Add(Me.dtpFechaNaci)
        Me.GRegistro.Controls.Add(Me.Label14)
        Me.GRegistro.Controls.Add(Me.txtPaisN)
        Me.GRegistro.Controls.Add(Me.Label4)
        Me.GRegistro.Controls.Add(Me.Label13)
        Me.GRegistro.Controls.Add(Me.txtDepartNaci)
        Me.GRegistro.Controls.Add(Me.Label12)
        Me.GRegistro.Controls.Add(Me.txtCiudadN)
        Me.GRegistro.Controls.Add(Me.Label11)
        Me.GRegistro.Controls.Add(Me.txtPeso)
        Me.GRegistro.Controls.Add(Me.Label10)
        Me.GRegistro.Controls.Add(Me.nudEstaturaAcu)
        Me.GRegistro.Controls.Add(Me.GroupBox1)
        Me.GRegistro.Controls.Add(Me.Label9)
        Me.GRegistro.Controls.Add(Me.txtNombre)
        Me.GRegistro.Controls.Add(Me.Tedad)
        Me.GRegistro.Controls.Add(Me.btnCerrar)
        Me.GRegistro.Controls.Add(Me.nudEdad)
        Me.GRegistro.Controls.Add(Me.btnCancelar)
        Me.GRegistro.Controls.Add(Me.btnLimpiar)
        Me.GRegistro.Controls.Add(Me.btnGuardar)
        Me.GRegistro.Controls.Add(Me.btnActualizar)
        Me.GRegistro.Controls.Add(Me.btnInsertar)
        Me.GRegistro.Controls.Add(Me.Label2)
        Me.GRegistro.Controls.Add(Me.txtColorPiel)
        Me.GRegistro.Controls.Add(Me.Label1)
        Me.GRegistro.Controls.Add(Me.txtCodigo)
        Me.GRegistro.Location = New System.Drawing.Point(30, 32)
        Me.GRegistro.Name = "GRegistro"
        Me.GRegistro.Size = New System.Drawing.Size(609, 649)
        Me.GRegistro.TabIndex = 6
        Me.GRegistro.TabStop = False
        Me.GRegistro.Text = "Mantenimiento de Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Color Cabello"
        '
        'txtCabello
        '
        Me.txtCabello.Location = New System.Drawing.Point(420, 238)
        Me.txtCabello.Multiline = True
        Me.txtCabello.Name = "txtCabello"
        Me.txtCabello.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCabello.Size = New System.Drawing.Size(159, 49)
        Me.txtCabello.TabIndex = 82
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(343, 356)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(423, 338)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(159, 49)
        Me.txtDireccion.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(340, 308)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Identidad"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(423, 308)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIdentidad.Size = New System.Drawing.Size(156, 20)
        Me.txtIdentidad.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(341, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Color Ojos"
        '
        'txtColorOjo
        '
        Me.txtColorOjo.Location = New System.Drawing.Point(420, 183)
        Me.txtColorOjo.Multiline = True
        Me.txtColorOjo.Name = "txtColorOjo"
        Me.txtColorOjo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtColorOjo.Size = New System.Drawing.Size(159, 49)
        Me.txtColorOjo.TabIndex = 52
        '
        'GroupEstado
        '
        Me.GroupEstado.Controls.Add(Me.RBDivorciado)
        Me.GroupEstado.Controls.Add(Me.RBcasado)
        Me.GroupEstado.Controls.Add(Me.RBSoltero)
        Me.GroupEstado.Location = New System.Drawing.Point(346, 20)
        Me.GroupEstado.Name = "GroupEstado"
        Me.GroupEstado.Size = New System.Drawing.Size(135, 83)
        Me.GroupEstado.TabIndex = 40
        Me.GroupEstado.TabStop = False
        Me.GroupEstado.Text = "Estado Civil"
        '
        'RBDivorciado
        '
        Me.RBDivorciado.AutoSize = True
        Me.RBDivorciado.Location = New System.Drawing.Point(12, 59)
        Me.RBDivorciado.Name = "RBDivorciado"
        Me.RBDivorciado.Size = New System.Drawing.Size(88, 17)
        Me.RBDivorciado.TabIndex = 86
        Me.RBDivorciado.TabStop = True
        Me.RBDivorciado.Text = "Divorciado(a)"
        Me.RBDivorciado.UseVisualStyleBackColor = True
        '
        'RBcasado
        '
        Me.RBcasado.AutoSize = True
        Me.RBcasado.Location = New System.Drawing.Point(12, 38)
        Me.RBcasado.Name = "RBcasado"
        Me.RBcasado.Size = New System.Drawing.Size(73, 17)
        Me.RBcasado.TabIndex = 85
        Me.RBcasado.TabStop = True
        Me.RBcasado.Text = "Casado(a)"
        Me.RBcasado.UseVisualStyleBackColor = True
        '
        'RBSoltero
        '
        Me.RBSoltero.AutoSize = True
        Me.RBSoltero.Location = New System.Drawing.Point(12, 19)
        Me.RBSoltero.Name = "RBSoltero"
        Me.RBSoltero.Size = New System.Drawing.Size(70, 17)
        Me.RBSoltero.TabIndex = 84
        Me.RBSoltero.TabStop = True
        Me.RBSoltero.Text = "Soltero(a)"
        Me.RBSoltero.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(39, 410)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Nivel Educacion"
        '
        'CbNivelEdu
        '
        Me.CbNivelEdu.FormattingEnabled = True
        Me.CbNivelEdu.Location = New System.Drawing.Point(172, 407)
        Me.CbNivelEdu.Name = "CbNivelEdu"
        Me.CbNivelEdu.Size = New System.Drawing.Size(100, 21)
        Me.CbNivelEdu.TabIndex = 50
        '
        'dtpFechaNaci
        '
        Me.dtpFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNaci.Location = New System.Drawing.Point(173, 367)
        Me.dtpFechaNaci.Name = "dtpFechaNaci"
        Me.dtpFechaNaci.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaNaci.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Pais Nacimiento"
        '
        'txtPaisN
        '
        Me.txtPaisN.Location = New System.Drawing.Point(173, 284)
        Me.txtPaisN.Name = "txtPaisN"
        Me.txtPaisN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPaisN.Size = New System.Drawing.Size(100, 20)
        Me.txtPaisN.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Departamento Nacimiento"
        '
        'txtDepartNaci
        '
        Me.txtDepartNaci.Location = New System.Drawing.Point(173, 251)
        Me.txtDepartNaci.Name = "txtDepartNaci"
        Me.txtDepartNaci.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDepartNaci.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartNaci.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Ciudad Nacimiento"
        '
        'txtCiudadN
        '
        Me.txtCiudadN.Location = New System.Drawing.Point(173, 226)
        Me.txtCiudadN.Name = "txtCiudadN"
        Me.txtCiudadN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCiudadN.Size = New System.Drawing.Size(100, 20)
        Me.txtCiudadN.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Peso"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(173, 202)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Estatura"
        '
        'nudEstaturaAcu
        '
        Me.nudEstaturaAcu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudEstaturaAcu.Location = New System.Drawing.Point(95, 164)
        Me.nudEstaturaAcu.Name = "nudEstaturaAcu"
        Me.nudEstaturaAcu.Size = New System.Drawing.Size(58, 20)
        Me.nudEstaturaAcu.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckbMasculino)
        Me.GroupBox1.Controls.Add(Me.ckbFemenino)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 66)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'ckbMasculino
        '
        Me.ckbMasculino.AutoSize = True
        Me.ckbMasculino.Location = New System.Drawing.Point(6, 14)
        Me.ckbMasculino.Name = "ckbMasculino"
        Me.ckbMasculino.Size = New System.Drawing.Size(74, 17)
        Me.ckbMasculino.TabIndex = 1
        Me.ckbMasculino.Text = "Masculino"
        Me.ckbMasculino.UseVisualStyleBackColor = True
        '
        'ckbFemenino
        '
        Me.ckbFemenino.AutoSize = True
        Me.ckbFemenino.Location = New System.Drawing.Point(6, 39)
        Me.ckbFemenino.Name = "ckbFemenino"
        Me.ckbFemenino.Size = New System.Drawing.Size(72, 17)
        Me.ckbFemenino.TabIndex = 0
        Me.ckbFemenino.Text = "Femenino"
        Me.ckbFemenino.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(111, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 32
        '
        'Tedad
        '
        Me.Tedad.AutoSize = True
        Me.Tedad.Location = New System.Drawing.Point(40, 326)
        Me.Tedad.Name = "Tedad"
        Me.Tedad.Size = New System.Drawing.Size(32, 13)
        Me.Tedad.TabIndex = 31
        Me.Tedad.Text = "Edad"
        '
        'nudEdad
        '
        Me.nudEdad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudEdad.Location = New System.Drawing.Point(102, 324)
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(58, 20)
        Me.nudEdad.TabIndex = 30
        Me.nudEdad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(319, 567)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(400, 567)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(236, 567)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(154, 567)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(72, 567)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 14
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Color Piel"
        '
        'txtColorPiel
        '
        Me.txtColorPiel.Location = New System.Drawing.Point(420, 119)
        Me.txtColorPiel.Multiline = True
        Me.txtColorPiel.Name = "txtColorPiel"
        Me.txtColorPiel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtColorPiel.Size = New System.Drawing.Size(159, 49)
        Me.txtColorPiel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(111, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'frmAcusado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyectoTeori.My.Resources.Resources.fondo_libros_azul_2
        Me.ClientSize = New System.Drawing.Size(1260, 712)
        Me.Controls.Add(Me.GDatos)
        Me.Controls.Add(Me.GRegistro)
        Me.Name = "frmAcusado"
        Me.Text = "frmAcusado"
        Me.GDatos.ResumeLayout(False)
        Me.GDatos.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRegistro.ResumeLayout(False)
        Me.GRegistro.PerformLayout()
        Me.GroupEstado.ResumeLayout(False)
        Me.GroupEstado.PerformLayout()
        CType(Me.nudEstaturaAcu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GDatos As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents cbxEliminar As CheckBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbbBuscar As ComboBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GRegistro As GroupBox
    Friend WithEvents Tedad As Label
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents dtpFechaNaci As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtColorPiel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtColorOjo As TextBox
    Friend WithEvents GroupEstado As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CbNivelEdu As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPaisN As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDepartNaci As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCiudadN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nudEstaturaAcu As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCabello As TextBox
    Friend WithEvents RBSoltero As RadioButton
    Friend WithEvents RBDivorciado As RadioButton
    Friend WithEvents RBcasado As RadioButton
    Friend WithEvents ckbMasculino As CheckBox
    Friend WithEvents ckbFemenino As CheckBox
End Class
