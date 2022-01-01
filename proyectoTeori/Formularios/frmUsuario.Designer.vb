<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_id = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Btn_Insertar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lb_Nombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.Lb_Password = New System.Windows.Forms.Label()
        Me.Gb_MantenimientoDatos = New System.Windows.Forms.GroupBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Gb_Datos = New System.Windows.Forms.GroupBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_MantenimientoDatos.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(199, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.proyectoTeori.My.Resources.Resources.fondo_libros_azul_2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(952, 348)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(24, 23)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 0
        Me.Lbl_id.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(144, 20)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        '
        'Btn_Insertar
        '
        Me.Btn_Insertar.Location = New System.Drawing.Point(39, 114)
        Me.Btn_Insertar.Name = "Btn_Insertar"
        Me.Btn_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Insertar.TabIndex = 4
        Me.Btn_Insertar.Text = "Insertar"
        Me.Btn_Insertar.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(135, 114)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Actualizar.TabIndex = 5
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(243, 114)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 6
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Lb_Nombre
        '
        Me.Lb_Nombre.AutoSize = True
        Me.Lb_Nombre.Location = New System.Drawing.Point(24, 48)
        Me.Lb_Nombre.Name = "Lb_Nombre"
        Me.Lb_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Lb_Nombre.TabIndex = 28
        Me.Lb_Nombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(144, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 29
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(144, 68)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswd.TabIndex = 47
        '
        'Lb_Password
        '
        Me.Lb_Password.AutoSize = True
        Me.Lb_Password.Location = New System.Drawing.Point(24, 71)
        Me.Lb_Password.Name = "Lb_Password"
        Me.Lb_Password.Size = New System.Drawing.Size(53, 13)
        Me.Lb_Password.TabIndex = 46
        Me.Lb_Password.Text = "Password"
        '
        'Gb_MantenimientoDatos
        '
        Me.Gb_MantenimientoDatos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Gb_MantenimientoDatos.Controls.Add(Me.Lb_Password)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.txtPasswd)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.txtNombre)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.Lb_Nombre)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.Btn_Guardar)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.Btn_Actualizar)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.Btn_Insertar)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.txtId)
        Me.Gb_MantenimientoDatos.Controls.Add(Me.Lbl_id)
        Me.Gb_MantenimientoDatos.Location = New System.Drawing.Point(31, 30)
        Me.Gb_MantenimientoDatos.Name = "Gb_MantenimientoDatos"
        Me.Gb_MantenimientoDatos.Size = New System.Drawing.Size(397, 201)
        Me.Gb_MantenimientoDatos.TabIndex = 30
        Me.Gb_MantenimientoDatos.TabStop = False
        Me.Gb_MantenimientoDatos.Text = "Mantenimiento de Datos"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(386, 164)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 3
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Location = New System.Drawing.Point(6, 49)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(451, 109)
        Me.Dgv_Listado.TabIndex = 6
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Location = New System.Drawing.Point(18, 20)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Lb_Buscar.TabIndex = 7
        Me.Lb_Buscar.Text = "Buscar"
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(64, 20)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_Buscar.TabIndex = 8
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(191, 20)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(171, 20)
        Me.Txt_Buscar.TabIndex = 9
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(10, 164)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(62, 17)
        Me.Chk_Eliminar.TabIndex = 10
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'Gb_Datos
        '
        Me.Gb_Datos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Gb_Datos.Controls.Add(Me.Chk_Eliminar)
        Me.Gb_Datos.Controls.Add(Me.Txt_Buscar)
        Me.Gb_Datos.Controls.Add(Me.Cmb_Buscar)
        Me.Gb_Datos.Controls.Add(Me.Lb_Buscar)
        Me.Gb_Datos.Controls.Add(Me.Dgv_Listado)
        Me.Gb_Datos.Controls.Add(Me.Btn_Eliminar)
        Me.Gb_Datos.Location = New System.Drawing.Point(460, 30)
        Me.Gb_Datos.Name = "Gb_Datos"
        Me.Gb_Datos.Size = New System.Drawing.Size(467, 201)
        Me.Gb_Datos.TabIndex = 29
        Me.Gb_Datos.TabStop = False
        Me.Gb_Datos.Text = "Datos"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(175, 267)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpiar.TabIndex = 31
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(390, 267)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 32
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Location = New System.Drawing.Point(570, 267)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cerrar.TabIndex = 33
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 348)
        Me.Controls.Add(Me.Gb_Datos)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Gb_MantenimientoDatos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmUsuario"
        Me.Text = "frmUsuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_MantenimientoDatos.ResumeLayout(False)
        Me.Gb_MantenimientoDatos.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Datos.ResumeLayout(False)
        Me.Gb_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Lbl_id As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Btn_Insertar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Lb_Nombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents Lb_Password As Label
    Friend WithEvents Gb_MantenimientoDatos As GroupBox
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents Gb_Datos As GroupBox
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Cerrar As Button
End Class
