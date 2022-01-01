

Public Class frmMenu

    Dim pSalir As New Connection

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frlogin As New frmLogin
        frlogin.Close()

    End Sub

    Private Sub Acusados_Click(sender As Object, e As EventArgs) Handles Acusados.Click
        Dim frmcategoriaObjeto As New frmAcusado
        frmcategoriaObjeto.bandera = 0
        frmcategoriaObjeto.ShowDialog()
        'frmAcusado.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs)
        Application.Exit()
        pSalir.desconecciondb()
    End Sub

    Private Sub Usuarios_Click(sender As Object, e As EventArgs) Handles Usuarios.Click
        Dim frmUsuarioObjeto As New frmUsuario
        frmUsuarioObjeto.bandera = 0
        frmUsuarioObjeto.ShowDialog()
    End Sub

    Private Sub meBitacoraUs_Click(sender As Object, e As EventArgs) Handles meBitacoraUs.Click
        Dim frmBitacora As New Bitacora
        frmBitacora.ShowDialog()
    End Sub

    Private Sub MAcuDelito_Click(sender As Object, e As EventArgs) Handles MAcuDelito.Click
        Dim PAcusado As New PAcusado
        PAcusado.ShowDialog()
    End Sub

    Private Sub MExpedien_Click(sender As Object, e As EventArgs) Handles MExpedien.Click
        Dim MExped As New MostrarExpedi
        MExped.ShowDialog()
    End Sub

    Private Sub Mcantidad_Click(sender As Object, e As EventArgs) Handles Mcantidad.Click
        Dim Mcan As New MostrarCantidad
        Mcan.ShowDialog()
    End Sub

    Private Sub MAbogados_Click(sender As Object, e As EventArgs) Handles MAbogados.Click
        Dim Mabo As New MostrarAbogados
        Mabo.ShowDialog()
    End Sub

    Private Sub MInformacion_Click(sender As Object, e As EventArgs) Handles MInformacion.Click
        Dim Minform As New MostrarInfor
        Minform.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class