<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GDatos = New System.Windows.Forms.GroupBox()
        Me.RBupdate = New System.Windows.Forms.RadioButton()
        Me.RbMInsert = New System.Windows.Forms.RadioButton()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cbxEliminar = New System.Windows.Forms.CheckBox()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbbBuscar = New System.Windows.Forms.ComboBox()
        Me.RBDelete = New System.Windows.Forms.RadioButton()
        Me.BnLimpiar = New System.Windows.Forms.Button()
        Me.GDatos.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GDatos
        '
        Me.GDatos.Controls.Add(Me.BnLimpiar)
        Me.GDatos.Controls.Add(Me.RBDelete)
        Me.GDatos.Controls.Add(Me.RBupdate)
        Me.GDatos.Controls.Add(Me.RbMInsert)
        Me.GDatos.Controls.Add(Me.btnEliminar)
        Me.GDatos.Controls.Add(Me.cbxEliminar)
        Me.GDatos.Controls.Add(Me.dataListado)
        Me.GDatos.Controls.Add(Me.txtBuscar)
        Me.GDatos.Controls.Add(Me.cbbBuscar)
        Me.GDatos.Location = New System.Drawing.Point(28, 21)
        Me.GDatos.Name = "GDatos"
        Me.GDatos.Size = New System.Drawing.Size(710, 437)
        Me.GDatos.TabIndex = 8
        Me.GDatos.TabStop = False
        Me.GDatos.Text = "Datos"
        '
        'RBupdate
        '
        Me.RBupdate.AutoSize = True
        Me.RBupdate.Location = New System.Drawing.Point(363, 39)
        Me.RBupdate.Name = "RBupdate"
        Me.RBupdate.Size = New System.Drawing.Size(159, 17)
        Me.RBupdate.TabIndex = 6
        Me.RBupdate.TabStop = True
        Me.RBupdate.Text = "Mostrar solo Actualizaciones"
        Me.RBupdate.UseVisualStyleBackColor = True
        '
        'RbMInsert
        '
        Me.RbMInsert.AutoSize = True
        Me.RbMInsert.Location = New System.Drawing.Point(363, 19)
        Me.RbMInsert.Name = "RbMInsert"
        Me.RbMInsert.Size = New System.Drawing.Size(139, 17)
        Me.RbMInsert.TabIndex = 5
        Me.RbMInsert.TabStop = True
        Me.RbMInsert.Text = "Mostrar solo Inserciones"
        Me.RbMInsert.UseVisualStyleBackColor = True
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
        Me.dataListado.Location = New System.Drawing.Point(7, 88)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(681, 288)
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
        'RBDelete
        '
        Me.RBDelete.AutoSize = True
        Me.RBDelete.Location = New System.Drawing.Point(363, 62)
        Me.RBDelete.Name = "RBDelete"
        Me.RBDelete.Size = New System.Drawing.Size(149, 17)
        Me.RBDelete.TabIndex = 7
        Me.RBDelete.TabStop = True
        Me.RBDelete.Text = "Mostrar solo Eliminaciones"
        Me.RBDelete.UseVisualStyleBackColor = True
        '
        'BnLimpiar
        '
        Me.BnLimpiar.Location = New System.Drawing.Point(575, 39)
        Me.BnLimpiar.Name = "BnLimpiar"
        Me.BnLimpiar.Size = New System.Drawing.Size(89, 40)
        Me.BnLimpiar.TabIndex = 8
        Me.BnLimpiar.Text = "Limpiar"
        Me.BnLimpiar.UseVisualStyleBackColor = True
        '
        'Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 484)
        Me.Controls.Add(Me.GDatos)
        Me.Name = "Bitacora"
        Me.Text = "Bitacora"
        Me.GDatos.ResumeLayout(False)
        Me.GDatos.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GDatos As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents cbxEliminar As CheckBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbbBuscar As ComboBox
    Friend WithEvents RBupdate As RadioButton
    Friend WithEvents RbMInsert As RadioButton
    Friend WithEvents RBDelete As RadioButton
    Friend WithEvents BnLimpiar As Button
End Class
