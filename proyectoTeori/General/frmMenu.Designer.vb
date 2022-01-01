<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Acusados = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAcuDelito = New System.Windows.Forms.ToolStripMenuItem()
        Me.MExpedien = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mcantidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAbogados = New System.Windows.Forms.ToolStripMenuItem()
        Me.MInformacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.meBitacoraUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 23)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "BarraMenu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem8, Me.MenuBitacora, Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(69, 19)
        Me.ToolStripMenuItem1.Text = "Opciones"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Acusados, Me.Usuarios})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "Mantenimiento"
        '
        'Acusados
        '
        Me.Acusados.Name = "Acusados"
        Me.Acusados.Size = New System.Drawing.Size(125, 22)
        Me.Acusados.Text = "Acusados"
        '
        'Usuarios
        '
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(125, 22)
        Me.Usuarios.Text = "Usuarios"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAcuDelito, Me.MExpedien, Me.Mcantidad, Me.MAbogados, Me.MInformacion})
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem8.Text = "Reportes"
        '
        'MAcuDelito
        '
        Me.MAcuDelito.Name = "MAcuDelito"
        Me.MAcuDelito.Size = New System.Drawing.Size(183, 22)
        Me.MAcuDelito.Text = "Acusado más delito"
        '
        'MExpedien
        '
        Me.MExpedien.Name = "MExpedien"
        Me.MExpedien.Size = New System.Drawing.Size(183, 22)
        Me.MExpedien.Text = "Mostrar Expediente"
        '
        'Mcantidad
        '
        Me.Mcantidad.Name = "Mcantidad"
        Me.Mcantidad.Size = New System.Drawing.Size(183, 22)
        Me.Mcantidad.Text = "Mostrar Cantidad"
        '
        'MAbogados
        '
        Me.MAbogados.Name = "MAbogados"
        Me.MAbogados.Size = New System.Drawing.Size(183, 22)
        Me.MAbogados.Text = "Mostrar Abogados"
        '
        'MInformacion
        '
        Me.MInformacion.Name = "MInformacion"
        Me.MInformacion.Size = New System.Drawing.Size(183, 22)
        Me.MInformacion.Text = "Mostrar Informacion"
        '
        'MenuBitacora
        '
        Me.MenuBitacora.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.meBitacoraUs})
        Me.MenuBitacora.Name = "MenuBitacora"
        Me.MenuBitacora.Size = New System.Drawing.Size(180, 22)
        Me.MenuBitacora.Text = "Bitacora"
        '
        'meBitacoraUs
        '
        Me.meBitacoraUs.Name = "meBitacoraUs"
        Me.meBitacoraUs.Size = New System.Drawing.Size(168, 22)
        Me.meBitacoraUs.Text = "Bitacora Acciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.proyectoTeori.My.Resources.Resources.fondo_libros_azul_2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 427)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Juzgado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Acusados As ToolStripMenuItem
    Friend WithEvents Usuarios As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents MAcuDelito As ToolStripMenuItem
    Friend WithEvents MExpedien As ToolStripMenuItem
    Friend WithEvents Mcantidad As ToolStripMenuItem
    Friend WithEvents MenuBitacora As ToolStripMenuItem
    Friend WithEvents meBitacoraUs As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAbogados As ToolStripMenuItem
    Friend WithEvents MInformacion As ToolStripMenuItem
End Class
