Public Class FrmWebLaudoAntigoMaringaPR
    Private Sub FrmWebLaudoAntigoMaringaPR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
    Private Sub WebView21_NavigationStarting(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles WebView21.NavigationStarting
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = True
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregando..."

        'mostrar ProgressBar1 colorido
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebView21.Source = New Uri("http://venus.maringa.pr.gov.br/laudosnew/")
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

        WebView21.ExecuteScriptAsync("document.getElementById('razao').value = '" & FrmAlvara.RazaoSocialTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('cnpj_empresa').value = '" & FrmAlvara.CNPJMaskedTextBox.Text & "'")

        WebView21.ExecuteScriptAsync("document.getElementById('num').value = '" & FrmAlvara.EndNumTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('cep').value = '" & FrmAlvara.EndCEPMaskedTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('complemento').value = '" & FrmAlvara.EndCompTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('zona').value = '" & FrmAlvara.EndZonaTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('quadra').value = '" & FrmAlvara.EndQuadraTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('data_data').value = '" & FrmAlvara.EndDataTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('lote').value = '" & FrmAlvara.EndDataTextBox.Text & "'")



        WebView21.ExecuteScriptAsync("document.getElementById('cad_imobiliario').value = '" & FrmAlvara.CadImobTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('bairro').value = '" & FrmAlvara.EndBairroTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('telefone').value = '" & FrmAlvara.FoneRequerenteTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('resp_tec').value = '" & FrmAlvara.ResptecnicoTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('cons_classe').value = '" & FrmAlvara.ResptecnicoNumeroTextBox.Text & "'")



        WebView21.ExecuteScriptAsync("document.getElementById('obs').value = '" & FrmAlvara.NaturezaDoPedidoOBSRichTextBox.Text & "'")

        WebView21.ExecuteScriptAsync("document.getElementById('ramo').value = '" & FrmAlvara.RamodeatividadeRichTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('area').value = '" & FrmAlvara.AreaTextBox.Text & "'")




        If FrmAlvara.EndRequerenteTextBox.Text = "" Then

            FrmAlvara.TabControl2.SelectTab(4)
            FrmAlvara.Button23.PerformClick()
            WebView21.ExecuteScriptAsync("document.getElementById('razao_requerente').value = '" & FrmAlvara.RequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('telefone_requerente').value = '" & FrmAlvara.FoneRequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('cnpj_requerente').value = '" & FrmAlvara.CNPJRequerenteMaskedTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('cpf_requerente').value = '" & FrmAlvara.CPFRequerenteMaskedTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('rg_requerente').value = '" & FrmAlvara.RGRequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('email_requerente').value = '" & FrmAlvara.EmailRequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('endereco_requerente').value = '" & FrmAlvara.EndRequerenteTextBox.Text & "'")



        Else
            WebView21.ExecuteScriptAsync("document.getElementById('razao_requerente').value = '" & FrmAlvara.RequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('telefone_requerente').value = '" & FrmAlvara.FoneRequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('cnpj_requerente').value = '" & FrmAlvara.CNPJRequerenteMaskedTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('cpf_requerente').value = '" & FrmAlvara.CPFRequerenteMaskedTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('rg_requerente').value = '" & FrmAlvara.RGRequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('email_requerente').value = '" & FrmAlvara.EmailRequerenteTextBox.Text & "'")
            WebView21.ExecuteScriptAsync("document.getElementById('endereco_requerente').value = '" & FrmAlvara.EndRequerenteTextBox.Text & "'")


        End If

        'parte do contador 1 cadastro apenas
        Contador.Show()
        WebView21.ExecuteScriptAsync("document.getElementById('escritorio_nome').value = '" & Contador.RazaoSocialTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('escritorio_fone').value = '" & Contador.TelefoneMaskedTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('escritorio_email').value = '" & Contador.EmailTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('escritorio_cpfcnpj').value = '" & Contador.CNPJMaskedTextBox.Text & "'")
        WebView21.ExecuteScriptAsync("document.getElementById('escritorio_rg').value = '" & Contador.RGTextBox.Text & "'")
        Contador.Close()


        Me.Focus()

        'fechamento form carregando



    End Sub


    Private Sub CNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNPJToolStripMenuItem.Click
        WebView21.ExecuteScriptAsync("document.getElementById('cnpj_empresa').value = '" & FrmAlvara.CNPJMaskedTextBox.Text & "'")

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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        FrmAlvara.Focus()

    End Sub
    Private Sub WebView21_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregamento Completo"

    End Sub

    Private Sub FrmWebLaudoAntigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WebView21 acessar a "http://venus.maringa.pr.gov.br/laudosnew/"

    End Sub



    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs)
        'perguntar se copiou o numero do laduo
        If MsgBox("Copiou o Número do laudo corretamente?", MsgBoxStyle.YesNo, "Copiar número do laudo") = MsgBoxResult.Yes Then
            'inputbox para digitar laudo antigo
            Dim laudo As String = InputBox("Digite o número do laudo antigo:", "Laudo Antigo")

            'se cancelar o inputbox nao fazer nada
            If laudo = "" Then
                'mgsbox "copiar laudo e colar novamente"
                MsgBox("Copie o Número do Laudo e cole novamente")
                Exit Sub
            End If

            FrmAlvara.NlaudoTextBox.Text = laudo

            FrmAlvara.Focus()


            If MsgBox("Foi copiado corretamente?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
                FrmAlvara.SituacaoComboBox.Text = "Aguardando Pagamento"
                Me.Focus()
                Me.Close()
            Else

                MsgBox("Copiar no campo específico no Menu onde foi solicitado o alvará e clicar após em 'Exportar Nº. do Laudo'", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                ' FrmAlvara.SituacaoComboBox.Text = "Aguardando Pagamento"
                Me.Focus()
            End If
        Else

        End If

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Normal()
    End Sub

    'ao fechar form tambem fechar webview2
    Private Sub FrmWebLaudoAntigo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        WebView21.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim NLaudo As String = FrmAlvara.NlaudoTextBox.Text.Replace(" ", "")
        'copiar Nlaudo e mostra mgs de copiado
        Clipboard.SetText(NLaudo)
        MsgBox("Número do Laudo copiado, favor insira no campo indicado no site!", MsgBoxStyle.Information, "Copiado")
    End Sub
End Class