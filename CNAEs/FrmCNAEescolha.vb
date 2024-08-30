Public Class FrmCNAEescolha
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        FrmBuscaCNAE.Show()
        Me.Close()
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        FrmCNAE.Show()
        Me.Close()
    End Sub

    Private Sub FrmCNAEescolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class