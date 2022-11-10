Imports System.Windows.Forms

Public Class BoxJuntaComercial
    ReadOnly Protocolo As String = FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text

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
        Try
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
            Dim Junta As String = FrmLegalizacao.EndEstadoTextBox.Text
            '///////////////////////////////////////////////////////////////////////////////////
            'Verifica Navegador interno
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
            End If
            '///////////////////////////////////////////////////////////////////////////////////
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(2)
            '///////////////////////////////////////////////////////////////////////////////////
            'inicia processo de abrir
            If Junta = "PR" Then
                WebSiteGERAL.WebView.Source = New Uri("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            ElseIf Junta = "ES" Then
                WebSiteGERAL.WebView.Source = New Uri("https://www.simplifica.es.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            End If
            '///////////////////////////////////////////////////////////////////////////////////
            MDIPrincipal.Focus()
            WebSiteGERAL.Focus()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao abrir o site da Junta Comercial, verificar o  Estado Cadastrado ou informar o administrador")
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
        End Try
    End Sub

    Private Sub BoxJuntaComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        Try
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
            Dim Junta As String = FrmLegalizacao.EndEstadoTextBox.Text

            If Junta = "PR" Then
                System.Diagnostics.Process.Start("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            ElseIf Junta = "ES" Then
                System.Diagnostics.Process.Start("https://www.simplifica.es.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            End If
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(2)
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao abrir o site da Junta Comercial, verificar o  Estado Cadastrado ou informar o administrador")
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
        End Try
    End Sub
End Class
