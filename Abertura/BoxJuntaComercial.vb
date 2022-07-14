Imports System.Windows.Forms

Public Class BoxJuntaComercial
    Dim Protocolo As String = FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        'mgsbox EM TESTE
        MsgBox("Em desenvolvimento")
    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click

        'verificar FrmWBEmpresaFacilPR está aberto ou abrir
        Dim frm As New FrmWBEmpresaFacilPR
        '            frm.WebView21.Source = New Uri("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)

        If frm.Visible = True Then
            'coloca focus e frente
            frm.Focus()
            frm.BringToFront()
            frm.WebView21.Source = New Uri("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
        Else
            frm.Show()
            frm.BringToFront()
            frm.WebView21.Source = New Uri("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
        End If
        Me.Close()
    End Sub

    Private Sub BoxJuntaComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        System.Diagnostics.Process.Start("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
        Me.Close()
    End Sub
End Class
