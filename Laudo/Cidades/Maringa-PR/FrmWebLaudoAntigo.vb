Public Class FrmWebLaudoAntigo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("http://venus.maringa.pr.gov.br/laudosnew/requerimentos.php")
    End Sub

    Private Sub Normal()


        'Form carregamento


        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(1)
        FrmAlvara.TabControl2.SelectTab(2)
        FrmAlvara.TabControl2.SelectTab(3)
        FrmAlvara.TabControl2.SelectTab(4)
        FrmAlvara.TabControl2.SelectTab(5)

        WebBrowser1.Document.GetElementById("razao").SetAttribute("value", FrmAlvara.RazaoSocialTextBox.Text)
        WebBrowser1.Document.GetElementById("cnpj_empresa").SetAttribute("value", FrmAlvara.CNPJMaskedTextBox.Text)

        ' WebBrowser1.Document.GetElementById("tipopessoa").InvokeMember("click")
        ' WebBrowser1.Document.GetElementById("tipopessoa").SetAttribute("value", "J")
        'WebBrowser1.Document.GetElementById("cnpj_empresa").SetAttribute("value", FrmAlvara.CNPJMaskedTextBox.Text)


        WebBrowser1.Document.GetElementById("num").SetAttribute("value", FrmAlvara.EndNumTextBox.Text)
        WebBrowser1.Document.GetElementById("cep").SetAttribute("value", FrmAlvara.EndCEPMaskedTextBox.Text)
        WebBrowser1.Document.GetElementById("complemento").SetAttribute("value", FrmAlvara.EndCompTextBox.Text)
        WebBrowser1.Document.GetElementById("zona").SetAttribute("value", FrmAlvara.EndZonaTextBox.Text)
        WebBrowser1.Document.GetElementById("quadra").SetAttribute("value", FrmAlvara.EndQuadraTextBox.Text)
        WebBrowser1.Document.GetElementById("data_data").SetAttribute("value", FrmAlvara.EndDataTextBox.Text)
        WebBrowser1.Document.GetElementById("lote").SetAttribute("value", FrmAlvara.EndDataTextBox.Text)
        WebBrowser1.Document.GetElementById("cad_imobiliario").SetAttribute("value", FrmAlvara.CadImobTextBox.Text)
        WebBrowser1.Document.GetElementById("bairro").SetAttribute("value", FrmAlvara.EndBairroTextBox.Text)
        WebBrowser1.Document.GetElementById("telefone").SetAttribute("value", FrmAlvara.FoneRequerenteTextBox.Text)
        WebBrowser1.Document.GetElementById("resp_tec").SetAttribute("value", FrmAlvara.ResptecnicoTextBox.Text)
        WebBrowser1.Document.GetElementById("cons_classe").SetAttribute("value", FrmAlvara.ResptecnicoNumeroTextBox.Text)

        WebBrowser1.Document.GetElementById("obs").SetAttribute("value", FrmAlvara.NaturezaDoPedidoOBSRichTextBox.Text)

        WebBrowser1.Document.GetElementById("ramo").SetAttribute("value", FrmAlvara.RamodeatividadeRichTextBox.Text)
        'WebBrowser1.Document.GetElementById("obs").SetAttribute("value", FrmAlvara.RazaoSocialTextBox.Text)
        WebBrowser1.Document.GetElementById("area").SetAttribute("value", FrmAlvara.AreaTextBox.Text)



        If FrmAlvara.EndRequerenteTextBox.Text = "" Then

            FrmAlvara.TabControl2.SelectTab(4)
            FrmAlvara.Button23.PerformClick()

            WebBrowser1.Document.GetElementById("razao_requerente").SetAttribute("value", FrmAlvara.RequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("telefone_requerente").SetAttribute("value", FrmAlvara.FoneRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("cnpj_requerente").SetAttribute("value", FrmAlvara.CNPJRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("cpf_requerente").SetAttribute("value", FrmAlvara.CPFRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("rg_requerente").SetAttribute("value", FrmAlvara.RGRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("email_requerente").SetAttribute("value", FrmAlvara.EmailRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("endereco_requerente").SetAttribute("value", FrmAlvara.EndRequerenteTextBox.Text)


        Else

            WebBrowser1.Document.GetElementById("razao_requerente").SetAttribute("value", FrmAlvara.RequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("telefone_requerente").SetAttribute("value", FrmAlvara.FoneRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("cnpj_requerente").SetAttribute("value", FrmAlvara.CNPJRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("cpf_requerente").SetAttribute("value", FrmAlvara.CPFRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("rg_requerente").SetAttribute("value", FrmAlvara.RGRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("email_requerente").SetAttribute("value", FrmAlvara.EmailRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("endereco_requerente").SetAttribute("value", FrmAlvara.EndRequerenteTextBox.Text)


        End If

        'parte do contador 1 cadastro apenas
        Contador.Show()
        WebBrowser1.Document.GetElementById("escritorio_nome").SetAttribute("value", Contador.RazaoSocialTextBox.Text)
        WebBrowser1.Document.GetElementById("escritorio_fone").SetAttribute("value", Contador.TelefoneMaskedTextBox.Text)
        WebBrowser1.Document.GetElementById("escritorio_email").SetAttribute("value", Contador.EmailTextBox.Text)
        WebBrowser1.Document.GetElementById("escritorio_cpfcnpj").SetAttribute("value", Contador.CNPJMaskedTextBox.Text)
        WebBrowser1.Document.GetElementById("escritorio_rg").SetAttribute("value", Contador.RGTextBox.Text)
        Contador.Close()


        Me.Focus()

        'fechamento form carregando



    End Sub


    Private Sub MEI()


        'Form carregamento


        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(1)
        FrmAlvara.TabControl2.SelectTab(2)
        FrmAlvara.TabControl2.SelectTab(3)
        FrmAlvara.TabControl2.SelectTab(4)
        FrmAlvara.TabControl2.SelectTab(5)

        WebBrowser1.Document.GetElementById("razao").SetAttribute("value", FrmAlvara.RazaoSocialTextBox.Text)
        WebBrowser1.Document.GetElementById("cnpj_empresa").SetAttribute("value", FrmAlvara.CNPJMaskedTextBox.Text)

        ' WebBrowser1.Document.GetElementById("tipopessoa").InvokeMember("click")
        ' WebBrowser1.Document.GetElementById("tipopessoa").SetAttribute("value", "J")
        'WebBrowser1.Document.GetElementById("cnpj_empresa").SetAttribute("value", FrmAlvara.CNPJMaskedTextBox.Text)


        WebBrowser1.Document.GetElementById("num").SetAttribute("value", FrmAlvara.EndNumTextBox.Text)
        WebBrowser1.Document.GetElementById("cep").SetAttribute("value", FrmAlvara.EndCEPMaskedTextBox.Text)
        WebBrowser1.Document.GetElementById("complemento").SetAttribute("value", FrmAlvara.EndCompTextBox.Text)
        WebBrowser1.Document.GetElementById("zona").SetAttribute("value", FrmAlvara.EndZonaTextBox.Text)
        WebBrowser1.Document.GetElementById("quadra").SetAttribute("value", FrmAlvara.EndQuadraTextBox.Text)
        WebBrowser1.Document.GetElementById("data_data").SetAttribute("value", FrmAlvara.EndDataTextBox.Text)
        WebBrowser1.Document.GetElementById("lote").SetAttribute("value", FrmAlvara.EndDataTextBox.Text)
        WebBrowser1.Document.GetElementById("cad_imobiliario").SetAttribute("value", FrmAlvara.CadImobTextBox.Text)
        WebBrowser1.Document.GetElementById("bairro").SetAttribute("value", FrmAlvara.EndBairroTextBox.Text)
        WebBrowser1.Document.GetElementById("telefone").SetAttribute("value", FrmAlvara.FoneRequerenteTextBox.Text)
        WebBrowser1.Document.GetElementById("resp_tec").SetAttribute("value", FrmAlvara.ResptecnicoTextBox.Text)
        WebBrowser1.Document.GetElementById("cons_classe").SetAttribute("value", FrmAlvara.ResptecnicoNumeroTextBox.Text)

        WebBrowser1.Document.GetElementById("obs").SetAttribute("value", FrmAlvara.NaturezaDoPedidoOBSRichTextBox.Text)

        WebBrowser1.Document.GetElementById("ramo").SetAttribute("value", FrmAlvara.RamodeatividadeRichTextBox.Text)
        'WebBrowser1.Document.GetElementById("obs").SetAttribute("value", FrmAlvara.RazaoSocialTextBox.Text)
        WebBrowser1.Document.GetElementById("area").SetAttribute("value", FrmAlvara.AreaTextBox.Text)



        If FrmAlvara.EndRequerenteTextBox.Text = "" Then

            FrmAlvara.TabControl2.SelectTab(4)
            FrmAlvara.Button23.PerformClick()

            WebBrowser1.Document.GetElementById("razao_requerente").SetAttribute("value", FrmAlvara.RequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("telefone_requerente").SetAttribute("value", FrmAlvara.FoneRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("cnpj_requerente").SetAttribute("value", FrmAlvara.CNPJRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("cpf_requerente").SetAttribute("value", FrmAlvara.CPFRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("rg_requerente").SetAttribute("value", FrmAlvara.RGRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("email_requerente").SetAttribute("value", FrmAlvara.EmailRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("endereco_requerente").SetAttribute("value", FrmAlvara.EndRequerenteTextBox.Text)


        Else

            WebBrowser1.Document.GetElementById("razao_requerente").SetAttribute("value", FrmAlvara.RequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("telefone_requerente").SetAttribute("value", FrmAlvara.FoneRequerenteTextBox.Text)
            WebBrowser1.Document.GetElementById("cnpj_requerente").SetAttribute("value", FrmAlvara.CNPJRequerenteMaskedTextBox.Text)
            WebBrowser1.Document.GetElementById("cpf_requerente").SetAttribute("value", FrmAlvara.CPFRequerenteMaskedTextBox.Text)

            'parte do mei
            WebBrowser1.Document.GetElementById("proprietario").SetAttribute("value", FrmAlvara.RequerenteTextBox.Text)

            Dim CPF As String = FrmAlvara.CPFRequerenteMaskedTextBox.Text
            ' Clipboard.SetText(CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '
            WebBrowser1.Document.GetElementById("cpf_propri").SetAttribute("value", CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
            'fim
            WebBrowser1.Document.GetElementById("endereco_requerente").SetAttribute("value", FrmAlvara.EndRequerenteTextBox.Text)


        End If

        'parte do contador 1 cadastro apenas
        ' Contador.Show()
        ' WebBrowser1.Document.GetElementById("escritorio_nome").SetAttribute("value", Contador.RazaoSocialTextBox.Text)
        ' WebBrowser1.Document.GetElementById("escritorio_fone").SetAttribute("value", Contador.TelefoneMaskedTextBox.Text)
        'WebBrowser1.Document.GetElementById("escritorio_email").SetAttribute("value", Contador.EmailTextBox.Text)
        'WebBrowser1.Document.GetElementById("escritorio_cpfcnpj").SetAttribute("value", Contador.CNPJMaskedTextBox.Text)
        'WebBrowser1.Document.GetElementById("escritorio_rg").SetAttribute("value", Contador.RGTextBox.Text)
        'Contador.Close()


        Me.Focus()

        'fechamento form carregando



    End Sub

    Private Sub CNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNPJToolStripMenuItem.Click
        WebBrowser1.Document.GetElementById("cnpj_empresa").SetAttribute("value", FrmAlvara.CNPJMaskedTextBox.Text)

    End Sub

    Private Sub CNAEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNAEToolStripMenuItem.Click
        FrmAlvara.TabControl2.SelectTab(3)
    End Sub

    Private Sub OBJETIVODOPEDIDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OBJETIVODOPEDIDOToolStripMenuItem.Click
        FrmAlvara.TabControl2.SelectTab(5)
    End Sub

    Private Sub ENDEREÇOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENDEREÇOToolStripMenuItem.Click
        FrmAlvara.TabControl2.SelectTab(1)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmAlvara.Focus()

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

            MenuImportar.Visible = True
            Button3.Visible = True

        Else


            ProgressBar1.Value = Math.Min(ProgressBar1.Maximum, Convert.ToInt32(Math.Floor(ProgressBar1.Maximum * (d / t))))
            TxtCarregar.Text = "Carregando..."
            MenuImportar.Visible = False
            Button3.Visible = False
        End If


    End Sub

    Private Sub FrmWebLaudoAntigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://venus.maringa.pr.gov.br/laudosnew/")


    End Sub



    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FrmAlvara.Focus()
        FrmAlvara.NlaudoTextBox.Text = TextBox1.Text


        If MsgBox("Foi copiado corretamente?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
            FrmAlvara.SituacaoComboBox.Text = "Aguardando Pagamento"
            Me.Focus()
            Me.Close()
        Else

            MsgBox("Copiar no campo específico no Menu onde foi solicitado o alvará e clicar após em 'Exportar Nº. do Laudo'", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            ' FrmAlvara.SituacaoComboBox.Text = "Aguardando Pagamento"
            Me.Focus()
        End If



    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Normal()
    End Sub

    Private Sub MEIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEIToolStripMenuItem.Click
        MEI()
    End Sub


End Class