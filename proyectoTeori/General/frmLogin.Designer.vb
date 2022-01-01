<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassw = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.proyectoTeori.My.Resources.Resources.fondo_libros_azul_2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(420, 296)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnEntrada
        '
        Me.btnEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrada.Location = New System.Drawing.Point(96, 182)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(85, 62)
        Me.btnEntrada.TabIndex = 4
        Me.btnEntrada.Text = "Entrar"
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(217, 182)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 62)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(204, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'txtPassw
        '
        Me.txtPassw.Location = New System.Drawing.Point(204, 121)
        Me.txtPassw.Name = "txtPassw"
        Me.txtPassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassw.Size = New System.Drawing.Size(100, 20)
        Me.txtPassw.TabIndex = 7
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.SteelBlue
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.Color.Black
        Me.Usuario.Location = New System.Drawing.Point(92, 57)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(64, 20)
        Me.Usuario.TabIndex = 8
        Me.Usuario.Text = "Usuario"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.SteelBlue
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(92, 119)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(78, 20)
        Me.Password.TabIndex = 9
        Me.Password.Text = "Password"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 296)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.txtPassw)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassw As TextBox
    Friend WithEvents Usuario As Label
    Friend WithEvents Password As Label
End Class
