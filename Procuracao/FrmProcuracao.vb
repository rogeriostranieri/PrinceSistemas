Public Class FrmProcuracao
    Private Sub FrmProcuracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebView21.Source = New Uri("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        If MsgBox("Alterou o tipo de CPF ou CNPJ em Dados do Outorgante?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then


            Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
            CNPJ = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            'mudar para WebView21 Document.GetElementById("delegID").SetAttribute("value", CNPJ)
            WebView21.ExecuteScriptAsync("document.getElementById('delegID').value = '" & CNPJ & "'")






            'WebBrowser1.Document.GetElementById("delegID").SetAttribute("value", CNPJ)

            'Carrega dados do formulario empresas
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(2)
            'mudar para WebView21 .Document.GetElementById("delegEnderecoLogradouro").SetAttribute("value", FrmLegalizacao.EnderecoTextBox.Text + ", " + FrmLegalizacao.EndNumeroTextBox.Text + ", " + FrmLegalizacao.EndBairroTextBox.Text)
            WebView21.ExecuteScriptAsync("document.getElementById('delegEnderecoLogradouro').value = '" & FrmLegalizacao.EnderecoTextBox.Text & ", " & FrmLegalizacao.EndNumeroTextBox.Text & ", " & FrmLegalizacao.EndBairroTextBox.Text & "'")
            'mudar para WebView21 .Document.GetElementById("delegEnderecoCidade").SetAttribute("value", FrmLegalizacao.EndCidadeTextBox.Text)
            WebView21.ExecuteScriptAsync("document.getElementById('delegEnderecoCidade').value = '" & FrmLegalizacao.EndCidadeTextBox.Text & "'")

            'mudar para WebView21 .Document.GetElementById("delegEnderecoEstado").SetAttribute("value", "PR")
            WebView21.ExecuteScriptAsync("document.getElementById('delegEnderecoEstado').value = 'PR'")

            'Carrega dados do formulario empresas
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(3)
            Dim TEL As String = FrmLegalizacao.EmpTel1TextBox.Text
            TEL = TEL.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(" ", "").Replace("(", "").Replace(")", "")
            'mudar para WebView21 .Document.GetElementById("delegTelefone").SetAttribute("value", TEL)
            WebView21.ExecuteScriptAsync("document.getElementById('delegTelefone').value = '" & TEL & "'")

            'Carrega dados do formulario empresas
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(0)
            Dim CPF As String = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text
            CPF = CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            'mudar para WebView21 .Document.GetElementById("cpfRespLegalDelegante").SetAttribute("value", CPF)
            'mudar para WebView21

            Dim RG As String = FrmLegalizacao.RespRGTextBox.Text
            RG = RG.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            'mudar para WebView21 .Document.GetElementById("delegRg").SetAttribute("value", RG)
            WebView21.ExecuteScriptAsync("document.getElementById('delegRg').value = '" & RG & "'")
            'mudar para WebView21 .Document.GetElementById("delegOrgaoExpedidor").SetAttribute("value", FrmLegalizacao.RespRgSiglaTextBox.Text)
            WebView21.ExecuteScriptAsync("document.getElementById('delegOrgaoExpedidor').value = '" & FrmLegalizacao.RespRgSiglaTextBox.Text & "'")

            'WebBrowser1.Document.GetElementById("nacionalidadeDelegante").SetAttribute("value", "Brasileiro")


            'Form Contador
            Contador.Show()

            Dim CPF1 As String = Contador.CPFMaskedTextBox.Text
            CPF1 = CPF1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            'mudar para WebView21 .Document.GetElementById("procID").SetAttribute("value", CPF1)
            WebView21.ExecuteScriptAsync("document.getElementById('procID').value = '" & CPF1 & "'")
            'mudar para WebView21 .Document.GetElementById("procEnderecoLogradouro").SetAttribute("value", Contador.EnderecoTextBox.Text + ", " + Contador.EndNumTextBox.Text + ", " + Contador.EndBairroTextBox.Text)
            WebView21.ExecuteScriptAsync("document.getElementById('procEnderecoLogradouro').value = '" & Contador.EnderecoTextBox.Text & ", " & Contador.EndNumTextBox.Text & ", " & Contador.EndBairroTextBox.Text & "'")
            'mudar para WebView21 .Document.GetElementById("procEnderecoCidade").SetAttribute("value", Contador.EndCidadeTextBox.Text)
            WebView21.ExecuteScriptAsync("document.getElementById('procEnderecoCidade').value = '" & Contador.EndCidadeTextBox.Text & "'")
            'mudar para WebView21 .Document.GetElementById("procEnderecoEstado").SetAttribute("value", "PR")
            WebView21.ExecuteScriptAsync("document.getElementById('procEnderecoEstado').value = 'PR'")

            Dim TEL1 As String = Contador.TelefoneMaskedTextBox.Text
            TEL1 = TEL1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(" ", "").Replace("(", "").Replace(")", "")
            'mudar para WebView21   .Document.GetElementById("procTelefone").SetAttribute("value", TEL1)
            WebView21.ExecuteScriptAsync("document.getElementById('procTelefone').value = '" & TEL1 & "'")

            Dim RG1 As String = Contador.RGTextBox.Text
            RG1 = RG1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            'mudar para WebView21 .Document.GetElementById("procRg").SetAttribute("value", RG1)
            WebView21.ExecuteScriptAsync("document.getElementById('procRg').value = '" & RG1 & "'")
            'mudar para WebView21 .Document.GetElementById("procOrgaoExpedidor").SetAttribute("value", Contador.RGSiglaTextBox.Text)
            WebView21.ExecuteScriptAsync("document.getElementById('procOrgaoExpedidor').value = '" & Contador.RGSiglaTextBox.Text & "'")
            'mudar para WebView21 .Document.GetElementById("nacionalidadeProcurador").SetAttribute("value", "Brasileiro")
            WebView21.ExecuteScriptAsync("document.getElementById('nacionalidadeProcurador').value = 'Brasileiro'")

            'Form Contador
            Contador.Close()
            'Form carregamento


            'focus
            Me.Focus()

            MsgBox("Importação Completa", MsgBoxStyle.Information, "Prince Sistemas Informa!")

        End If


    End Sub


    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)

        'progresso e mudando TxtCarregar do  WebView21
        If e.CurrentProgress > 0 Then
            Dim porcentagem As Integer = (e.CurrentProgress / e.MaximumProgress) * 100
            'mudar para WebView21 .Document.GetElementById("txtCarregar").SetAttribute("value", porcentagem)
            WebView21.ExecuteScriptAsync("document.getElementById('txtCarregar').value = '" & porcentagem & "'")
        End If

    End Sub


End Class