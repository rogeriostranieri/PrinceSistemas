﻿Public Class BoxConsultaIEEmpresa
    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        Dim IE As String = FrmLegalizacao.IETextBox.Text

        Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        If IE = "" Then
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=")
                Me.Close()
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=")
                Me.Close()
            End If
        Else
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=" + IE)
                Me.Close()
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=" + IE)
                Me.Close()
            End If
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        Dim IE As String = FrmLegalizacao.IETextBox.Text

        If IE = "" Then
            Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

            ' Verificar se CNPJ não está vazio antes de copiar
            If Not String.IsNullOrEmpty(CNPJ) Then
                My.Computer.Clipboard.SetText(CNPJ)
                MsgBox("CNPJ copiado, use o CTRL+V para colar no campo do CNPJ")
                Process.Start("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=")
            Else
                MsgBox("CNPJ está vazio. Não foi possível copiar.")
            End If
            Me.Close()
        Else
            Process.Start("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=" + IE)
            Me.Close()
        End If
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        'mgs em teste
        MsgBox("Em teste Importar IE")
    End Sub

    Private Sub BoxConsultaIEEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class