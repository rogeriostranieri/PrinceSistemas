Public Class FrmProcuracao
    Private Sub FrmProcuracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebBrowser1.Navigate("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        If MsgBox("Alterou o tipo de CPF ou CNPJ em Dados do Outorgante?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then




            'WebBrowser1.Document.GetElementById("tipoDelegante").SetAttribute("checked", True)


            Dim CNPJ As String = Legalizacao.CNPJMaskedTextBox.Text
            CNPJ = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            WebBrowser1.Document.GetElementById("delegID").SetAttribute("value", CNPJ)


            'Carrega dados do formulario empresas
            Legalizacao.TabControle.SelectTab(1)
            Legalizacao.TabControl2.SelectTab(2)
            WebBrowser1.Document.GetElementById("delegEnderecoLogradouro").SetAttribute("value", Legalizacao.EnderecoTextBox.Text + ", " + Legalizacao.EndNumeroTextBox.Text + ", " + Legalizacao.EndBairroTextBox.Text)
            WebBrowser1.Document.GetElementById("delegEnderecoCidade").SetAttribute("value", Legalizacao.EndCidadeTextBox.Text)
            WebBrowser1.Document.GetElementById("delegEnderecoEstado").SetAttribute("value", "PR")

            'Carrega dados do formulario empresas
            Legalizacao.TabControle.SelectTab(1)
            Legalizacao.TabControl2.SelectTab(3)
            Dim TEL As String = Legalizacao.EmpTel1TextBox.Text
            TEL = TEL.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(" ", "").Replace("(", "").Replace(")", "")
            WebBrowser1.Document.GetElementById("delegTelefone").SetAttribute("value", TEL)

            'Carrega dados do formulario empresas
            Legalizacao.TabControle.SelectTab(1)
            Legalizacao.TabControl2.SelectTab(0)
            Dim CPF As String = Legalizacao.CPFResponsavelMaskedTextBox.Text
            CPF = CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            WebBrowser1.Document.GetElementById("cpfRespLegalDelegante").SetAttribute("value", CPF)

            Dim RG As String = Legalizacao.RespRGTextBox.Text
            RG = RG.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            WebBrowser1.Document.GetElementById("delegRg").SetAttribute("value", RG)
            WebBrowser1.Document.GetElementById("delegOrgaoExpedidor").SetAttribute("value", Legalizacao.RespRgSiglaTextBox.Text)

            'WebBrowser1.Document.GetElementById("nacionalidadeDelegante").SetAttribute("value", "Brasileiro")


            'Form Contador
            Contador.Show()

            Dim CPF1 As String = Contador.CPFMaskedTextBox.Text
            CPF1 = CPF1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            WebBrowser1.Document.GetElementById("procID").SetAttribute("value", CPF1)

            WebBrowser1.Document.GetElementById("procEnderecoLogradouro").SetAttribute("value", Contador.EnderecoTextBox.Text + ", " + Contador.EndNumTextBox.Text + ", " + Contador.EndBairroTextBox.Text)
            WebBrowser1.Document.GetElementById("procEnderecoCidade").SetAttribute("value", Contador.EndCidadeTextBox.Text)
            WebBrowser1.Document.GetElementById("procEnderecoEstado").SetAttribute("value", "PR")

            Dim TEL1 As String = Contador.TelefoneMaskedTextBox.Text
            TEL1 = TEL1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(" ", "").Replace("(", "").Replace(")", "")
            WebBrowser1.Document.GetElementById("procTelefone").SetAttribute("value", TEL1)

            Dim RG1 As String = Contador.RGTextBox.Text
            RG1 = RG1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            WebBrowser1.Document.GetElementById("procRg").SetAttribute("value", RG1)
            WebBrowser1.Document.GetElementById("procOrgaoExpedidor").SetAttribute("value", Contador.RGSiglaTextBox.Text)
            WebBrowser1.Document.GetElementById("nacionalidadeProcurador").SetAttribute("value", "Brasileiro")

            'Form Contador
            Contador.Close()
            'Form carregamento


            'focus
            Me.Focus()

            MsgBox("Importação Completa", MsgBoxStyle.Information, "Prince Sistemas Informa!")

        End If


    End Sub


    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged

        ProgressBar1.Visible = True

        Dim d, t As Integer

        d = e.CurrentProgress

        t = e.MaximumProgress

        If d <= 0 Then



            ProgressBar1.Value = 0

            ProgressBar1.Visible = False
            TxtCarregar.Text = "Completo"



        Else


            ProgressBar1.Value = Math.Min(ProgressBar1.Maximum, Convert.ToInt32(Math.Floor(ProgressBar1.Maximum * (d / t))))
            TxtCarregar.Text = "Carregando..."

        End If


    End Sub


End Class