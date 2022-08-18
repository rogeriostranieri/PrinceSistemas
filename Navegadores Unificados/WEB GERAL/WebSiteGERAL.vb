Imports Microsoft.Web.WebView2.Core
Imports System.IO
Public Class WebSiteGERAL
    Private Sub Titulo()
        TabControl1.TabPages(0).Text = "aguarde"
        TxtURL.Text = WebView.Source.ToString
        'Document Title Changed na barra de titulo
        Dim TituloSite As String = WebView.CoreWebView2.DocumentTitle
        Me.Text = TituloSite
        'tabcontrol TabPage1 para o titulo da pagina
        TabControl1.TabPages(0).Text = TituloSite

    End Sub

    '//////////////////////////////////////////////////////////////////////////////
    Private Sub WebView_NavigationStarting_1(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles WebView.NavigationStarting
        'mostrar barra de progresso e mudar LblStatusCarregamento
        Titulo()

        ProgressBar1.Visible = True
        TxtCarregamento.Visible = True
        TxtCarregamento.Text = "Carregando..."

        'mostrar ProgressBar1 colorido
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1
    End Sub


    '//////////////////////////////////////////////////////////////////////////////
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'abrir sempre como MDI FIlho
        MdiParent = MDIPrincipal

        LogMsg("MS Edge Version: " + CoreWebView2Environment.GetAvailableBrowserVersionString())

        If Not String.IsNullOrEmpty(TxtURL.Text) Then
            'navigate to URL
            'WebView.Source = New Uri(TxtURL.Text)
            WebsiteNavigate(TxtURL.Text)
        End If

        'ao altera o site salvar no txt da primeira linha inciando com "pagina_inicial:" e site depois
        Dim path As String = Application.StartupPath & "\PaginaInicial.txt"

        '"pagina_inicial:" e pega o site depois e coloca no ToolStripTextBox1.Tex
        If File.Exists(path) Then
            Dim lines As String() = File.ReadAllLines(path)
            Dim line As String = lines(0)
            Dim site As String = line.Substring(15)
            ToolStripTextBox1.Text = site
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'unsubscribe from CoreWebView2 event(s) (remove event handlers) 
        'verificar antes se o WebView está vazio
        If WebView.CoreWebView2 IsNot Nothing Then
            RemoveHandler WebView.CoreWebView2.HistoryChanged, AddressOf CoreWebView2_HistoryChanged
        End If

        'dispose of WebView
        WebView.Dispose()
    End Sub

    Private Sub LogMsg(msg As String, Optional addTimestamp As Boolean = True)
        'ToDo: add desired code

        If addTimestamp Then
            msg = String.Format("{0} - {1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), msg)
        End If

        Debug.WriteLine(msg)
    End Sub

    Private Sub UpdateAddressBar()
        'if necessary, update address bar
        If TxtURL.Text <> WebView.Source.ToString() Then
            TxtURL.Text = WebView.Source.ToString()

            'move cursor to end of text
            TxtURL.SelectionStart = TxtURL.Text.Length
            TxtURL.SelectionLength = 0
        End If
    End Sub

    Friend Sub WebsiteNavigate(ByVal dest As String)
        If WebView IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(dest) Then
            'se no TxtURL for digitado algo separado " " pesquisar no google
            '"https://www.google.com.br/search?q="  Replace(" ", "+")
            If dest.Contains(" ") Then
                dest = "https://www.google.com.br/search?q=" + dest.Replace(" ", "+")
            ElseIf dest.Contains(".") Then
                If Not dest = "about:blank" AndAlso
                 Not dest.StartsWith("edge://") AndAlso
                 Not dest.StartsWith("file://") AndAlso
                 Not dest.StartsWith("http://") AndAlso
                 Not dest.StartsWith("https://") AndAlso
                 Not System.Text.RegularExpressions.Regex.IsMatch(dest, "^([A-Z]|[a-z]):") Then

                    'set value
                    dest = "https://" & dest

                End If
            Else
                dest = "https://www.google.com.br/search?q=" + dest.Replace(" ", "+")
            End If


            'URL must start with one of the specified strings
            'if Not, pre-pend with "https://"
            If Not dest = "about:blank" AndAlso
                   Not dest.StartsWith("edge://") AndAlso
                   Not dest.StartsWith("file://") AndAlso
                   Not dest.StartsWith("http://") AndAlso
                   Not dest.StartsWith("https://") AndAlso
                   Not System.Text.RegularExpressions.Regex.IsMatch(dest, "^([A-Z]|[a-z]):") Then

                'set value
                dest = "https://" & dest

            End If
            '            
            'option 1
            WebView.Source = New Uri(dest, UriKind.Absolute)

            'option 2
            'Caso contrário, irá realizar a pesquisa no google
            'WebView.CoreWebView2.Navigate("https://www.google.com.br/search?q=" + dest.Replace(" ", "+"))
            '  WebView.CoreWebView2.Navigate(dest)


            'update address bar
            UpdateAddressBar()
        End If
    End Sub

    Private Sub TxtURL_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebsiteNavigate(TxtURL.Text)
        End If
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        If WebView IsNot Nothing AndAlso WebView.CanGoBack Then
            WebView.GoBack()
        End If
    End Sub

    Private Sub BtnAvancar_Click(sender As Object, e As EventArgs) Handles BtnAvancar.Click
        If WebView IsNot Nothing AndAlso WebView.CanGoForward Then
            WebView.GoForward()
        End If
    End Sub

    Private Sub BtnIR_Click(sender As Object, e As EventArgs) Handles BtnIR.Click
        WebsiteNavigate(TxtURL.Text)
        'atualizar pagina
        ' WebView.Refresh()
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        If WebView IsNot Nothing Then
            'atualizar pagina
            WebView.Reload()
        End If
    End Sub

    Private Sub WebView_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView.CoreWebView2InitializationCompleted
        LogMsg("WebView_CoreWebView2InitializationCompleted")
        LogMsg("UserDataFolder: " & WebView.CoreWebView2.Environment.UserDataFolder.ToString())

        'subscribe to CoreWebView2 event(s) (add event handlers) 
        AddHandler WebView.CoreWebView2.HistoryChanged, AddressOf CoreWebView2_HistoryChanged

    End Sub

    Private Sub CoreWebView2_HistoryChanged(sender As Object, e As Object)
        'LogMsg("CoreWebView2_HistoryChanged")
        BtnVoltar.Enabled = WebView.CoreWebView2.CanGoBack
        BtnAvancar.Enabled = WebView.CoreWebView2.CanGoForward

        'update address bar
        UpdateAddressBar()
    End Sub

    Private Sub WebView_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView.NavigationCompleted
        LogMsg("WebView_NavigationCompleted")
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        TxtCarregamento.Visible = True
        TxtCarregamento.Text = "Carregamento Completo"

        Titulo()
    End Sub

    Private Sub WebView_WebMessageReceived(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs) Handles WebView.WebMessageReceived
        LogMsg("WebView_WebMessageReceived")
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click, SairToolStripMenuItem.Click
        WebView.Dispose()
        Me.Close()
    End Sub


    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        'ao altera o site salvar no txt da primeira linha inciando com "pagina_inicial:" e site depois
        Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
        Dim sw As New StreamWriter(path)
        sw.WriteLine("pagina_inicial:" & ToolStripTextBox1.Text)
        sw.Close()
        'mgsbox
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Try
            'ler o txt e pegar o site inicial que está na frente "pagina_inicial:" do txt
            Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
            Dim sr As New StreamReader(path)
            Dim line As String = sr.ReadLine()
            Dim site As String = ""
            While line IsNot Nothing
                If line.Contains("pagina_inicial:") Then
                    site = line.Replace("pagina_inicial:", "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()
            WebsiteNavigate(site)

        Catch ex As Exception
            'abrir o site do google no lugar
            WebsiteNavigate("https://www.google.com.br/")
        End Try

    End Sub

    '//////////////////////////////////////////////////////////////////////
    Private Sub AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem.Click
        Try
            If WebView.Source.ToString.Contains("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40") Then
            Else
                'abrir o site do google no lugar
                WebsiteNavigate("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")
                'mgsbox esperar carrega site
                MsgBox("Aguarde o carregamento do site e tente novamente!")
                Exit Sub
            End If


            'verificar se o frmlegalizacao está aberto
            If FrmLegalizacao Is Nothing Then
                FrmLegalizacao = New FrmLegalizacao
                FrmLegalizacao.Show()
                MsgBox("Favor, abrir na empresa desejada o preenchimento!")
                Exit Sub
            Else
                'ativa TabControle 0
                Dim RazaoSocial As String = FrmLegalizacao.CNPJMaskedTextBox.Text
                FrmLegalizacao.TabControle.SelectedIndex = 1
                FrmLegalizacao.TabControl2.SelectedIndex = 0
                Dim CPF As String = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text

                FrmLegalizacao.TabControle.SelectedIndex = 5
                Dim CodigoSimples As String = FrmLegalizacao.CodigoSimplesTextBox.Text

                FrmLegalizacao.TabControle.SelectedIndex = 0

                'procurar no webviewl o texto e colocar no campo
                WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCNPJ').value = '" & RazaoSocial & "'")
                WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCPFResponsavel').value = '" & CPF & "'")
                WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCodigoAcesso').value = '" & CodigoSimples & "'")

                Me.Focus()

            End If
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub BtnSimplesNacionalPrimeiraParteInício_Click(sender As Object, e As EventArgs) Handles BtnSimplesNacionalPrimeiraParteInício.Click
        Try
            If WebView.Source.ToString.Contains("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39") Then
            Else
                'abrir o site do google no lugar
                WebsiteNavigate("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39")
            MsgBox("Aguarde o carregamento do site e tente novamente!")

            Exit Sub

        End If

        'verificar se o frmlegalizacao está aberto
        If FrmLegalizacao Is Nothing Then
            FrmLegalizacao = New FrmLegalizacao
            FrmLegalizacao.Show()
            MsgBox("Favor, abrir na empresa desejada o preenchimento!")
            Exit Sub
        Else
            'ativa TabControle 0
            Dim RazaoSocial As String = FrmLegalizacao.CNPJMaskedTextBox.Text
            FrmLegalizacao.TabControle.SelectedIndex = 1
            FrmLegalizacao.TabControl2.SelectedIndex = 0
            Dim CPF As String = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text

            FrmLegalizacao.TabControle.SelectedIndex = 5
            Dim CodigoSimples As String = FrmLegalizacao.CodigoSimplesTextBox.Text

            FrmLegalizacao.TabControle.SelectedIndex = 0

            'procurar no webviewl o texto e colocar no campo
            WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCNPJ').value = '" & RazaoSocial & "'")
            WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCPFResponsavel').value = '" & CPF & "'")
            WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCodigoAcesso').value = '" & CodigoSimples & "'")

            Me.Focus()

        End If
        Catch ex As Exception
        'MsgBox formulario nao esta aberto + a Message
        MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub



    Private Sub BtnRedeSimAbertura_Click(sender As Object, e As EventArgs) Handles BtnRedeSimAbertura.Click
        WebsiteNavigate("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")

    End Sub

    Private Sub BtnREDESIMAlteracao_Click(sender As Object, e As EventArgs) Handles BtnREDESIMAlteracao.Click
        Try
            If WebView.Source.ToString.Contains("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral") Then
            Else
                'abrir o site do google no lugar
                WebsiteNavigate("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral")
                MsgBox("Aguarde o carregamento do site e tente novamente!")
                Exit Sub

            End If

            'verificar se o frmlegalizacao está aberto
            If FrmLegalizacao Is Nothing Then
                FrmLegalizacao = New FrmLegalizacao
                FrmLegalizacao.Show()
                'mgsbox abrir na empresa
                MsgBox("Favor, abrir na empresa desejada o preenchimento!")
                Exit Sub
            Else
                'ativa TabControle 0

                FrmLegalizacao.TabControle.SelectedIndex = 2
                FrmLegalizacao.TabControle.SelectedIndex = 3

                'ProtocoloREDESIMTextBox
                'ProtocoloJuntaComercialTextBox
                'verificar se os dois estão preenchidos
                If FrmLegalizacao.ProtocoloREDESIMTextBox.Text = "" Or FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text = "" Then
                    MsgBox("Favor, preencher os dois protocolos!")
                    Exit Sub
                Else
                    If FrmLegalizacao.ProtocoloREDESIMTextBox.Text <> "" Then
                        Dim ProtocoloREDESIM As String = FrmLegalizacao.ProtocoloREDESIMTextBox.Text
                        WebView.ExecuteScriptAsync("document.getElementById('id='protocoloViabilidadeAlteracaoInput').value = '" & ProtocoloREDESIM & "'")
                        Me.Focus()
                        Exit Sub
                    Else
                        ' FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text <> "" 
                        Dim ProtocoloREDESIM As String = FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text
                        'procurar no webviewl o texto e colocar no campo
                        WebView.ExecuteScriptAsync("document.getElementById('id='protocoloViabilidadeAlteracaoInput').value = '" & ProtocoloREDESIM & "'")
                        Me.Focus()
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub BtnREDESIMBaixa_Click(sender As Object, e As EventArgs) Handles BtnREDESIMBaixa.Click
        Try
            If WebView.Source.ToString.Contains("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa") Then
            Else
                'abrir o site do google no lugar
                WebsiteNavigate("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa")
                MsgBox("Aguarde o carregamento do site e tente novamente!")
                Exit Sub
            End If

            'verificar se o frmlegalizacao está aberto
            If FrmLegalizacao Is Nothing Then
                FrmLegalizacao = New FrmLegalizacao
                FrmLegalizacao.Show()
                'mgsbox abrir na empresa
                MsgBox("Favor, abrir na empresa desejada o preenchimento!")
                Exit Sub
            Else
                Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

                If FrmLegalizacao.CNPJMaskedTextBox.Text = "" Then
                    MsgBox("CNPJ vazio!")
                    Exit Sub
                End If

                'procurar no webviewl o texto e colocar no campo id="cpfCnpj"
                WebView.ExecuteScriptAsync("document.getElementById('id='cpfCnpj').value = '" & CNPJ & "'")
                Me.Focus()
            End If
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub


    Private Sub BtnSimplesNacionalSegundasParteDados_Click(sender As Object, e As EventArgs)
        Try
            Dim DataSimples As String = WebView.ExecuteScriptAsync("GetElementById('ctl00_ContentPlaceHolder1_pnlMensagem_lblMensagem')").ToString
            'pegar apenas os numeros "consultado a partir do dia " e antes ", no Portal do Simples Nacional "...
            'frmlegalizacao.DataSimplesMaskedTextBox.text
            Dim DataSimples2 As String = DataSimples.Substring(DataSimples.IndexOf("consultado a partir do dia ") + "consultado a partir do dia ".Length, DataSimples.IndexOf(", no Portal do Simples Nacional ...") - DataSimples.IndexOf("consultado a partir do dia ") - "consultado a partir do dia ".Length)
            FrmLegalizacao.TabControle.SelectedIndex = 5
            FrmLegalizacao.DataSimplesMaskedTextBox.Text = DataSimples2
            FrmLegalizacao.AvisarDiaMaskedTextBox.Text = DataSimples2
            'DataSimples2 em formato extenso dd, de mmmm de yyyy
            Dim DataSimples3 As String = DataSimples2.Substring(0, 2) & " de " & DataSimples2.Substring(3, 3) & " de " & DataSimples2.Substring(7, 4)
            MsgBox("Data Final finaliza em: " & DataSimples3)
            FrmLegalizacao.Focus()
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub ImportarDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarDadosToolStripMenuItem.Click
        Try
            If WebView.Source.ToString.Contains("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx") Then
            Else
                'abrir o site do google no lugar
                WebsiteNavigate("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")
            MsgBox("Aguarde o carregamento do site e tente novamente!")

            Exit Sub

        End If


        'verificar se o frmlegalizacao está aberto
        If FrmLegalizacao Is Nothing Then
            FrmLegalizacao = New FrmLegalizacao
            FrmLegalizacao.Show()
            MsgBox("Favor, abrir na empresa desejada o preenchimento!")
            Exit Sub
        Else
            'ativa TabControle 0
            Dim RazaoSocial As String = FrmLegalizacao.CNPJMaskedTextBox.Text
            FrmLegalizacao.TabControle.SelectedIndex = 1
            FrmLegalizacao.TabControl2.SelectedIndex = 0
            Dim CPF As String = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text

            FrmLegalizacao.TabControle.SelectedIndex = 0

            'procurar no webviewl o texto e colocar no campo
            WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCNPJ').value = '" & RazaoSocial & "'")
            WebView.ExecuteScriptAsync("document.getElementById('ctl00_ContentPlaceHolder_txtCPFResponsavel').value = '" & CPF & "'")

            Me.Focus()

        End If
        Catch ex As Exception
        'MsgBox formulario nao esta aberto + a Message
        MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub ExportarCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim CodigoSimples As String = WebView.ExecuteScriptAsync("GetElementById('ctl00_ContentPlaceHolder_lblResultado')").ToString
            '<span id="ctl00_ContentPlaceHolder_lblResultado" class="label resultado">Código de acesso gerado com sucesso. Seu código é: <span style="color:Red;font-size:13px;">788566192115</span>.<br>Esse código é uma senha, portanto é sigiloso. Anote-o e guarde-o em lugar seguro e de fácil recuperação para futuros acessos.</span>
            'pegar apenas os numeros "apos Seu código é: "
            Dim CodigoSimples2 As String = CodigoSimples.Substring(CodigoSimples.IndexOf("Seu código é: ") + 14)
            'pegar apenas os numeros "apos <span style="color:Red;font-size:13px;">"
            'Dim CodigoSimples3 As String = CodigoSimples2.Substring(CodigoSimples2.IndexOf("<span style=") + 15)

            FrmLegalizacao.TabControle.SelectedIndex = 5
            FrmLegalizacao.CodigoSimplesTextBox.Text = CodigoSimples2
            FrmLegalizacao.Focus()
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub ImportarPRNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarPRNToolStripMenuItem.Click
        'mgs box "teste"
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub PaginaInicialToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MaringaProtocoloPaginaInicialToolStripMenuItem2.Click
        'abrir o site http://venus.maringa.pr.gov.br:9900/protocolo/
        WebsiteNavigate("http://venus.maringa.pr.gov.br:9900/protocolo/")
    End Sub

    Private Sub ALvaraOnlinePaginaInicialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ALvaraOnlinePaginaInicialToolStripMenuItem1.Click
        'venus.maringa.pr.gov.br:9900/fazendaonline/
        WebsiteNavigate("http://venus.maringa.pr.gov.br:9900/fazendaonline/")
    End Sub

    Private Sub AlvaraAntigoPaginaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlvaraAntigoPaginaInicialToolStripMenuItem.Click
        'https://venus.maringa.pr.gov.br/laudosnew/
        WebsiteNavigate("https://venus.maringa.pr.gov.br/laudosnew/")
    End Sub

    Private Sub ProtocoloImportarParaConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtocoloImportarParaConsultaToolStripMenuItem.Click
        'ver se o site aberto é http://venus.maringa.pr.gov.br:9900/protocolo/ ou abrir
        If WebView.Source.ToString.Contains("http://venus.maringa.pr.gov.br:9900/protocolo/") Then
            Try
                If FrmAlvara Is Nothing Then
                    FrmAlvara = New FrmAlvara
                    FrmAlvara.Show()
                    MsgBox("Favor, abrir na empresa desejada o preenchimento!")
                    Exit Sub
                Else
                    ' FrmAlvara.Focus()
                    'ativa TabAlvara 3
                    FrmAlvara.TabAlvara.SelectedIndex = 3
                    Dim Tipo As String = FrmAlvara.ProtocoloTipoTextBox.Text
                    Dim Numero As String = FrmAlvara.ProtocoloNTextBox.Text
                    Dim Ano As String = FrmAlvara.ProtocoloAnoTextBox.Text
                    Dim Senha As String = FrmAlvara.ProtocoloSenhaTextBox.Text
                    'procurar campo id="tipo" e id="numero"  e id="ano" e id="senha" e colocar no campo
                    WebView.ExecuteScriptAsync("document.getElementById('tipo').value = '" & Tipo & "'")
                    WebView.ExecuteScriptAsync("document.getElementById('numero').value = '" & Numero & "'")
                    WebView.ExecuteScriptAsync("document.getElementById('ano').value = '" & Ano & "'")
                    WebView.ExecuteScriptAsync("document.getElementById('senha').value = '" & Senha & "'")
                End If
            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            'abrir o site http://venus.maringa.pr.gov.br:9900/protocolo/
            WebsiteNavigate("http://venus.maringa.pr.gov.br:9900/protocolo/")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub ImportarNºDoLaudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarNºDoLaudoToolStripMenuItem.Click
        Try
            Dim Nlaudo As String = FrmAlvara.NlaudoTextBox.Text
            WebView.ExecuteScriptAsync("document.getElementById('form:numeroSolicitacao').value = '" & Nlaudo & "'")
            'clicar no botao form:btnPesquisar
            WebView.ExecuteScriptAsync("document.getElementById('form:btnPesquisar').click()")
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub CNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNPJToolStripMenuItem.Click
        Try
            Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text.Replace("/", "").Replace(".", "").Replace("-", "") & "'"
            WebView.ExecuteScriptAsync("document.getElementById('form:maskCpfResp:maskCpfResp').value = '" & CNPJ)
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub CadastroImobiliarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroImobiliarioToolStripMenuItem.Click
        Try
            FrmAlvara.TabAlvara.SelectedIndex = 0
            'TabControl2
            FrmAlvara.TabControl2.SelectedIndex = 1
            Dim CADIMOB As String = FrmAlvara.CadImobTextBox.Text
            Me.Focus()
            'WebView21 Id('formCadastroImobiliario:codImobiliario') 
            WebView.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:codImobiliario').value = '" & CADIMOB & "'")
            'clicar em id=formCadastroImobiliario:btnConsultaCadastro
            WebView.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:btnConsultaCadastro').click()")
            End
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub OuEndereçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuEndereçoToolStripMenuItem.Click
        Try
            Dim Rua As String = FrmAlvara.EnderecoTextBox.Text
            Dim N As String = FrmAlvara.EndNumTextBox.Text
            'selecionar TabAlvara, TabControl2 do  FrmAlvara
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(0)
            'selecionar aba FrmAlvara.TabControl2 1
            FrmAlvara.TabControl2.SelectTab(1)
            'voltar
            Me.Focus()
            WebView.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:pesqEndereco_input').value = '" & Rua & ", " & N & "'")
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub ÁreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaToolStripMenuItem.Click
        Try
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(0)
            'selecionar aba FrmAlvara.TabControl2 1
            FrmAlvara.TabControl2.SelectTab(1)

            Dim Area1 As String = FrmAlvara.AreaTextBox.Text
            Dim Area2 As String = FrmAlvara.Area2TextBox.Text


            Me.Focus()
            'id="form:areaConstruida_input"
            'AreaTextBox
            WebView.ExecuteScriptAsync("document.getElementById('form:areaConstruida_input').value = '" & Area1 & "'")
            'id="form:areaPatio_input"
            'Area2TextBox
            WebView.ExecuteScriptAsync("document.getElementById('form:areaPatio_input').value = '" & Area2 & "'")
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub CnaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CnaeToolStripMenuItem.Click
        Try
            'selecionar TabAlvara, TabControl2 do  FrmAlvara
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(0)
            'selecionar aba FrmAlvara.TabControl2 1
            FrmAlvara.TabControl2.SelectTab(3)

            'mostar form
            FrmAlvara.Focus()
        Catch ex As Exception
            'MsgBox formulario nao esta aberto + a Message
            MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub NúmeroDoLaudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmeroDoLaudoToolStripMenuItem.Click
        'verificar se a pagina é  https://venus.maringa.pr.gov.br/laudosnew/consultar.php ou abrir
        If WebView.Source.ToString.Contains("https://venus.maringa.pr.gov.br/laudosnew/consultar.php") Then
            Try
                Dim NLaudo As String = FrmAlvara.NlaudoTextBox.Text.Replace(" ", "")
                'procura o name="protocolo"
                WebView.ExecuteScriptAsync("document.getElementsByName('protocolo')[0].value = '" & NLaudo & "'")
                'procura name="next01" e clicar
                WebView.ExecuteScriptAsync("document.getElementsByName('next01')[0].click()")
            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            'abrir o site https://venus.maringa.pr.gov.br/laudosnew/consultar.php
            WebsiteNavigate("https://venus.maringa.pr.gov.br/laudosnew/consultar.php")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub ImportarDadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImportarDadosToolStripMenuItem1.Click
        If WebView.Source.ToString.Contains("https://venus.maringa.pr.gov.br/laudosnew/requerimentos.php") Then
            'perguntar se foi "alterado TIPO PESSOA para jurídico"
            If MsgBox("Deseja alterar o tipo de pessoa para jurídica?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    ImportarDadosLaudoAntigoMaringaPR()
                Catch ex As Exception
                    'MsgBox formulario nao esta aberto + a Message
                    MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
                End Try
            Else
                'mgsBox
                MsgBox("Mudar o campo antes de importar os dados!")
            End If
        Else
            'abrir o site https://venus.maringa.pr.gov.br/laudosnew/requerimentos.php
            WebsiteNavigate("https://venus.maringa.pr.gov.br/laudosnew/requerimentos.php")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If

    End Sub

    Private Sub ImportarDadosLaudoAntigoMaringaPR()
        'Form carregamento
        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(1)
        FrmAlvara.TabControl2.SelectTab(2)
        FrmAlvara.TabControl2.SelectTab(3)
        FrmAlvara.TabControl2.SelectTab(4)
        FrmAlvara.TabControl2.SelectTab(5)

        Dim RazaoSocial As String = FrmAlvara.RazaoSocialTextBox.Text
        Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text
        Dim EndNum As String = FrmAlvara.EndNumTextBox.Text
        Dim EndCEP As String = FrmAlvara.EndCEPMaskedTextBox.Text
        Dim EndComp As String = FrmAlvara.EndCompTextBox.Text
        Dim EndZona As String = FrmAlvara.EndZonaTextBox.Text
        Dim EndQuadra As String = FrmAlvara.EndQuadraTextBox.Text
        Dim EndData As String = FrmAlvara.EndDataTextBox.Text
        Dim CadImob As String = FrmAlvara.CadImobTextBox.Text
        Dim EndBairro As String = FrmAlvara.EndBairroTextBox.Text
        Dim FoneRequerente As String = FrmAlvara.FoneRequerenteTextBox.Text
        Dim Resptecnico As String = FrmAlvara.ResptecnicoTextBox.Text
        Dim ResptecnicoNumero As String = FrmAlvara.ResptecnicoNumeroTextBox.Text
        Dim NaturezaDoPedido As String = FrmAlvara.NaturezaDoPedidoOBSRichTextBox.Text
        Dim Ramodeatividade As String = FrmAlvara.RamodeatividadeRichTextBox.Text
        Dim Area As String = FrmAlvara.AreaTextBox.Text

        Dim RequerenteNome As String = FrmAlvara.RequerenteTextBox.Text
        Dim RequerenteFone As String = FrmAlvara.FoneRequerenteTextBox.Text
        Dim RequerenteCNPJ As String = FrmAlvara.CNPJRequerenteMaskedTextBox.Text
        Dim RequerenteCPF As String = FrmAlvara.CPFRequerenteMaskedTextBox.Text
        Dim RequerenteRG As String = FrmAlvara.RGRequerenteTextBox.Text
        Dim RequerenteEmail As String = FrmAlvara.EmailRequerenteTextBox.Text
        Dim RequerenteEnd As String = FrmAlvara.EndRequerenteTextBox.Text

        WebView.ExecuteScriptAsync("document.getElementsByName('razao')[0].value = '" & RazaoSocial & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('cnpj_empresa')[0].value = '" & CNPJ & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('num')[0].value = '" & EndNum & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('cep')[0].value = '" & EndCEP & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('complemento')[0].value = '" & EndComp & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('zona')[0].value = '" & EndZona & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('quadra')[0].value = '" & EndQuadra & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('data_data')[0].value = '" & EndData & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('lote')[0].value = '" & EndData & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('cad_imobiliario')[0].value = '" & CadImob & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('bairro')[0].value = '" & EndBairro & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('telefone')[0].value = '" & FoneRequerente & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('resp_tec')[0].value = '" & Resptecnico & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('cons_classe')[0].value = '" & ResptecnicoNumero & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('obs')[0].value = '" & NaturezaDoPedido & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('ramo')[0].value = '" & Ramodeatividade & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('area')[0].value = '" & Area & "'")

        If FrmAlvara.EndRequerenteTextBox.Text = "" Then
            FrmAlvara.Button23.PerformClick()
            WebView.ExecuteScriptAsync("document.getElementsByName('razao_requerente')[0].value = '" & RequerenteNome & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('telefone_requerente')[0].value = '" & RequerenteFone & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('cnpj_requerente')[0].value = '" & RequerenteCNPJ & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('cpf_requerente')[0].value = '" & RequerenteCPF & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('rg_requerente')[0].value = '" & RequerenteRG & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('email_requerente')[0].value = '" & RequerenteEmail & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('endereco_requerente')[0].value = '" & RequerenteEnd & "'")
        Else
            WebView.ExecuteScriptAsync("document.getElementsByName('razao_requerente')[0].value = '" & RequerenteNome & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('telefone_requerente')[0].value = '" & RequerenteFone & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('cnpj_requerente')[0].value = '" & RequerenteCNPJ & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('cpf_requerente')[0].value = '" & RequerenteCPF & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('rg_requerente')[0].value = '" & RequerenteRG & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('email_requerente')[0].value = '" & RequerenteEmail & "'")
            WebView.ExecuteScriptAsync("document.getElementsByName('endereco_requerente')[0].value = '" & RequerenteEnd & "'")
        End If

        'parte do contador 1 cadastro apenas
        Contador.Show()
        Dim ContadorRazaoSocial As String = Contador.RazaoSocialTextBox.Text
        Dim ContadorTelefone As String = Contador.TelefoneMaskedTextBox.Text
        Dim ContadorEmail As String = Contador.EmailTextBox.Text
        Dim ContadorCNPJ As String = Contador.CNPJMaskedTextBox.Text
        Dim ContadorRG As String = Contador.RGTextBox.Text

        WebView.ExecuteScriptAsync("document.getElementsByName('escritorio_nome')[0].value = '" & ContadorRazaoSocial & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('escritorio_fone')[0].value = '" & ContadorTelefone & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('escritorio_email')[0].value = '" & ContadorEmail & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('escritorio_cpfcnpj')[0].value = '" & ContadorCNPJ & "'")
        WebView.ExecuteScriptAsync("document.getElementsByName('escritorio_rg')[0].value = '" & ContadorRG & "'")
        Contador.Close()


        Me.Focus()
        WebView.Focus()
    End Sub

    Private Sub BtnSobre_Click(sender As Object, e As EventArgs) Handles BtnSobre.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub PaginaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaginaInicialToolStripMenuItem.Click
        'abrir http://www.prevfogo.pr.gov.br/
        WebView.Source = New Uri("http://www.prevfogo.pr.gov.br/")
    End Sub

    Private Sub AcompanharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcompanharToolStripMenuItem.Click
        'verificar se esta aberto o site contenha "prevfogo.sesp.pr.gov.br" ou abrir "https://www.prevfogo.sesp.pr.gov.br/vcbinternet/acompanharProcesso.do?action=informacoesProcesso" Then

        If WebView.Source.ToString.Contains("prevfogo.sesp.pr.gov.br") Then
            WebView.Focus()
            Try
                FrmAlvara.TabAlvara.SelectTab(1)
                Dim NProcesso As String = FrmAlvara.BombeiroNProcessoMaskedTextBox.Text.Replace(".", "").Replace("-", "")
                'name="edicao.numeroProcesso"
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.numeroProcesso').click()")
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.numeroProcesso')[0].value = '" & NProcesso & "'")
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.numeroProcesso').click()")

                Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "")
                WebView.ExecuteScriptAsync("document.getElementById('documento').click()")
                WebView.ExecuteScriptAsync("document.getElementById('documento').value = '" & CNPJ & "'")

                'Dim MudarCNPJ As String = "w-150 cpfCnpj validate[required, custom[cnpj]]"
                'Dim MudarCPF As String = "w-150 cpfCnpj validate[required, custom[cpf]]"
                'procurar campo class= "w-150 cpfCnpj validate[required]"
                'WebView.ExecuteScriptAsync("document.getElementsByClassName('" & MudarCNPJ & "')[0].click()")

                MsgBox("Clicar nos campos e usar espaço para validar os caratecteres")

            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            WebView.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/acompanharProcesso.do?action=informacoesProcesso")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If

    End Sub

    Private Sub CNPJToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CNPJToolStripMenuItem1.Click

        If WebView.Source.ToString.Contains("prevfogo.sesp.pr.gov.br") Then
            WebView.Focus()
            Try
                'procura o txt_rg e coloca dados do RG do form Contador na RGTextBox.text
                Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text
                'id="documento"
                WebView.ExecuteScriptAsync("document.getElementById('documento').click()")
                WebView.ExecuteScriptAsync("document.getElementById('documento').value = '" & CNPJ & "'")

            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            WebView.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/solicitarVistoria.do?action=iniciarProcesso")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub DadosSolicitanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadosSolicitanteToolStripMenuItem.Click
        If WebView.Source.ToString.Contains("prevfogo.sesp.pr.gov.br") Then
            WebView.Focus()
            Try
                'abrir Contador escondido   
                Contador.Show()
                Contador.WindowState = FormWindowState.Minimized
                Contador.WindowState = FormWindowState.Normal
                Contador.Focus()
                Contador.BringToFront()

                'procura o txt_rg e coloca dados do RG do form Contador na RGTextBox.text
                Dim RG As String = Contador.RGTextBox.Text
                Dim CPF As String = Contador.CPFMaskedTextBox.Text
                Dim Nome As String = Contador.NomeTextBox.Text
                Dim Email As String = Contador.EmailTextBox.Text
                'telefone pegar o numero dentro do "(44)" e colocar na string DDDTELEFONE os dois digitos
                Dim DDDTELEFONE As String = Contador.TelefoneMaskedTextBox.Text.Substring(1, 2)
                'telefone pegar o numero depois do "(44)" e do espaço, e colocar na string TELEFONE depois dos dois digitos 3228-8785
                Dim TELEFONE As String = Contador.TelefoneMaskedTextBox.Text.Substring(Contador.TelefoneMaskedTextBox.Text.IndexOf("(44)") + 4, 9).Replace(" ", "").Replace("-", "")


                'procura a id=txt_rg no site 
                '  Id('txt_rg') usar RG
                WebView.ExecuteScriptAsync("document.getElementById('txt_rg').value = '" & RG & "'")
                'procura o name=edicao.solicitante.cpf e coloca o CPF
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.solicitante.cpf')[0].value = '" & CPF & "'")
                'name="edicao.solicitante.nome" com nome completo
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.solicitante.nome')[0].value = '" & Nome & "'")
                'DDD do telefone name="edicao.solicitante.dddTelefone"
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.solicitante.dddTelefone')[0].value = '" & DDDTELEFONE & "'")
                'telefone name="edicao.solicitante.telefone"
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.solicitante.telefone')[0].value = '" & TELEFONE & "'")
                'name="edicao.solicitante.email"
                WebView.ExecuteScriptAsync("document.getElementsByName('edicao.solicitante.email')[0].value = '" & Email & "'")
                'fechar Contador
                Contador.Close()

            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            WebView.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/solicitarVistoria.do?action=iniciarProcesso")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub ÁreaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÁreaToolStripMenuItem1.Click
        If WebView.Source.ToString.Contains("prevfogo.sesp.pr.gov.br") Then
            WebView.Focus()
            Try
                'ativar FrmAlvara TabAlvara
                FrmAlvara.TabAlvara.SelectTab(0)
                'TabControl2
                FrmAlvara.TabControl2.SelectTab(1)


                'pegar areas total =  Area2TextBox.text
                Dim areas As String = FrmAlvara.Area2TextBox.Text
                'pegar areas Estabelecimento =  AreaTextBox.text  
                Dim areas2 As String = FrmAlvara.AreaTextBox.Text

                'pegar areas total=  name="edicao.areaTotalVistoria"
                Dim script = "document.getElementsByName('edicao.areaTotalVistoria')[0].value = '" & areas & "';"
                WebView.ExecuteScriptAsync(script)

                'pegar areas Estabelecimento=  name="edicao.areaTotalEdificacao"
                script = "document.getElementsByName('edicao.areaTotalEdificacao')[0].value = '" & areas2 & "';"
                WebView.ExecuteScriptAsync(script)

                'voltar TabAlvara 1
                FrmAlvara.TabAlvara.SelectTab(1)
                Me.Focus()

            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            WebView.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/solicitarVistoria.do?action=iniciarProcesso")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub ConsultaPorNomeEPreencherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorNomeEPreencherToolStripMenuItem.Click
        If WebView.Source.ToString.Contains("tse.jus.br") Then
            WebView.Focus()
            'id="LV_NomeTituloCPF"
            'id="LV_DataNascimento"
            'id="LV_NomeMae"
            'click id="consultar-local-votacao-form-submit"
            Try
                If FrmLegalizacao.Visible = True Then
                    Dim NomeCompleto As String = FrmLegalizacao.NomeResponsavelTextBox.Text
                    Dim DataNascimento As String = FrmLegalizacao.RespDataNascMaskedTextBox.Text
                    Dim NomeDaMae As String = FrmLegalizacao.RespMaeTextBox.Text

                    'id="LV_NomeTituloCPF"
                    WebView.ExecuteScriptAsync("document.getElementById('LV_NomeTituloCPF').value = '" & NomeCompleto & "'")
                    'id="LV_DataNascimento"
                    WebView.ExecuteScriptAsync("document.getElementById('LV_DataNascimento').value = '" & DataNascimento & "'")
                    'id="LV_NomeMae"
                    WebView.ExecuteScriptAsync("document.getElementById('LV_NomeMae').value = '" & NomeDaMae & "'")
                    'click id="consultar-local-votacao-form-submit"
                    WebView.ExecuteScriptAsync("document.getElementById('consultar-local-votacao-form-submit').click()")

                ElseIf FrmSocios.Visible = True Then
                    Dim NomeCompleto As String = FrmSocios.NomeCompletoTextBox.Text
                    Dim DataNascimento As String = FrmSocios.DatadeNascMaskedTextBox.Text
                    Dim NomeDaMae As String = FrmSocios.NomeMaeTextBox.Text

                    'id="LV_NomeTituloCPF"
                    WebView.ExecuteScriptAsync("document.getElementById('LV_NomeTituloCPF').value = '" & NomeCompleto & "'")
                    'id="LV_DataNascimento"
                    WebView.ExecuteScriptAsync("document.getElementById('LV_DataNascimento').value = '" & DataNascimento & "'")
                    'id="LV_NomeMae"
                    WebView.ExecuteScriptAsync("document.getElementById('LV_NomeMae').value = '" & NomeDaMae & "'")
                    'click id="consultar-local-votacao-form-submit"
                    WebView.ExecuteScriptAsync("document.getElementById('consultar-local-votacao-form-submit').click()")

                End If

            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            WebView.Source = New Uri("http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub PaginaInicialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaginaInicialToolStripMenuItem1.Click
        WebView.Source = New Uri("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")
    End Sub

    Private Sub PreencherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreencherToolStripMenuItem.Click
        If MsgBox("Alterou o tipo de CPF ou CNPJ em Dados do Outorgante?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            'id="tipoDelegante" click  value=2

            Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
            CNPJ = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            WebView.ExecuteScriptAsync("document.getElementById('delegID').value = '" & CNPJ & "'")

            'Carrega dados do formulario empresas
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(0)
            FrmLegalizacao.TabControl2.SelectTab(3)
            FrmLegalizacao.TabControl2.SelectTab(4)
            FrmLegalizacao.TabControl2.SelectTab(0)
            FrmLegalizacao.TabControle.SelectTab(8)

            WebView.ExecuteScriptAsync("document.getElementById('delegEnderecoLogradouro').value = '" & FrmLegalizacao.EnderecoTextBox.Text & ", " & FrmLegalizacao.EndNumeroTextBox.Text & ", " & FrmLegalizacao.EndBairroTextBox.Text & "'")
            WebView.ExecuteScriptAsync("document.getElementById('delegEnderecoCidade').value = '" & FrmLegalizacao.EndCidadeTextBox.Text & "'")
            WebView.ExecuteScriptAsync("document.getElementById('delegEnderecoEstado').value = 'PR'")

            Dim TEL As String = FrmLegalizacao.EmpTel1TextBox.Text
            TEL = TEL.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(" ", "").Replace("(", "").Replace(")", "")
            TEL = ApenasNumeros(TEL)
            WebView.ExecuteScriptAsync("document.getElementById('delegTelefone').value = '" & TEL & "'")

            Dim CPF As String = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text
            Dim CPF1 As String = CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            CPF1 = ApenasNumeros(CPF1)
            WebView.ExecuteScriptAsync("document.getElementById('cpfRespLegalDelegante').value = '" & CPF1 & "'")

            Dim RG As String = FrmLegalizacao.RespRGTextBox.Text
            RG = RG.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            RG = ApenasNumeros(RG)
            WebView.ExecuteScriptAsync("document.getElementById('delegRg').value = '" & RG & "'")
            Dim OrgaoRG As String = FrmLegalizacao.ResponsavelOrgaoRGTextBox.Text
            Dim EstadoRG As String = FrmLegalizacao.ResponsavelEstadoOrgaoRGTextBox.Text
            WebView.ExecuteScriptAsync("document.getElementById('delegOrgaoExpedidor').value = '" & OrgaoRG + " " & EstadoRG & "'")

            'Form Contador
            Contador.Show()
            Dim CPF2 As String = Contador.CPFMaskedTextBox.Text
            Dim CPF3 As String = CPF2.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(",", "")
            Dim unused As String = ApenasNumeros(CPF3)
            WebView.ExecuteScriptAsync("document.getElementById('procID').value = '" & CPF3 & "'")
            WebView.ExecuteScriptAsync("document.getElementById('procEnderecoLogradouro').value = '" & Contador.EnderecoTextBox.Text & ", " & Contador.EndNumTextBox.Text & ", " & Contador.EndBairroTextBox.Text & "'")
            WebView.ExecuteScriptAsync("document.getElementById('procEnderecoCidade').value = '" & Contador.EndCidadeTextBox.Text & "'")
            WebView.ExecuteScriptAsync("document.getElementById('procEnderecoEstado').value = 'PR'")

            Dim TEL1 As String = Contador.TelefoneMaskedTextBox.Text
            TEL1 = TEL1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "").Replace(" ", "").Replace("(", "").Replace(")", "")
            WebView.ExecuteScriptAsync("document.getElementById('procTelefone').value = '" & TEL1 & "'")

            Dim RG1 As String = Contador.RGTextBox.Text
            RG1 = RG1.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
            RG1 = ApenasNumeros(RG1)
            WebView.ExecuteScriptAsync("document.getElementById('procRg').value = '" & RG1 & "'")
            WebView.ExecuteScriptAsync("document.getElementById('procOrgaoExpedidor').value = '" & Contador.RGSiglaTextBox.Text & "'")
            WebView.ExecuteScriptAsync("document.getElementById('nacionalidadeProcurador').value = 'Brasileiro'")

            Contador.Close()

            'id="dataVigenciaInicio"
            'Data de hoje dd/mm/yyyy
            Dim data As String = DateTime.Now.ToString("dd/MM/yyyy")
            WebView.ExecuteScriptAsync("document.getElementById('dataVigenciaInicio').value = '" & data & "'")

            'id="dataVigenciaFim"
            'Data de hoje dd/mm/yyyy + 5 anos e - 1 mês
            Dim data1 As String = DateTime.Now.AddYears(5).AddMonths(-1).ToString("dd/MM/yyyy")
            WebView.ExecuteScriptAsync("document.getElementById('dataVigenciaFim').value = '" & data1 & "'")

            'clicar no id="opcoesAtendimento"
            WebView.ExecuteScriptAsync("document.getElementById('opcoesAtendimento').click()")

            'inputbox perguntando senha
            'id="codigoAcesso" e no id="codigoAcessoRepeticao" iguais
            Dim senha As String = InputBox("Digite a Senha", "Senha")
            WebView.ExecuteScriptAsync("document.getElementById('codigoAcesso').value = '" & senha & "'")
            WebView.ExecuteScriptAsync("document.getElementById('codigoAcessoRepeticao').value = '" & senha & "'")

            'focus
            MsgBox("Importação Completa", MsgBoxStyle.Information, "Prince Sistemas Informa!")

            'focar no form
            WebView.Focus()
        End If

    End Sub

    Private Sub AcompanhamentoDaSolicitaçãoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AcompanhamentoDaSolicitaçãoToolStripMenuItem2.Click
        If WebView.Source.ToString.Contains("venus.maringa") Then
            WebView.Focus()
            Try
                Dim NLaudo As String = FrmAlvara.NlaudoTextBox.Text
                'imput no id  "form:numeroSolicitacao"  com os dados do FrmAlvara.NlaudoTextBox.Text
                WebView.ExecuteScriptAsync("document.getElementById('form:numeroSolicitacao').value = '" & NLaudo & "'")
                'clicar no botao form:btnPesquisar
                WebView.ExecuteScriptAsync("document.getElementById('form:btnPesquisar').click()")
            Catch ex As Exception
                'MsgBox formulario nao esta aberto + a Message
                MsgBox("Formulario não está aberto" & vbNewLine & ex.Message)
            End Try
        Else
            WebView.Source = New Uri("http://venus.maringa.pr.gov.br:9900/fazendaonline/app/acompanhamento?execution=e2s1")
            MsgBox("Aguarde o carregamento do site e tente novamente!")
            Exit Sub
        End If
    End Sub

    Private Sub BtnSoltar_Click(sender As Object, e As EventArgs) Handles BtnSoltar.Click
        For Each child In MDIPrincipal.MdiChildren
            If TypeOf child Is WebSiteGERAL Then
                Me.MdiParent = Nothing
                ' child.WindowState = FormWindowState.Maximized
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.MdiParent = MDIPrincipal
                'maximizar child
                Me.WindowState = FormWindowState.Maximized
            End If
        Next
    End Sub

    Private Sub PaginaInicialToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles PaginaInicialToolStripMenuItem2.Click
        WebsiteNavigate("https://servicos.receita.fazenda.gov.br/servicos/cpf/consultasituacao/consultapublica.asp")
    End Sub

    Private Sub PáginaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaInicialToolStripMenuItem.Click
        WebsiteNavigate("https://servicos.receita.fazenda.gov.br/servicos/cnpjreva/cnpjreva_solicitacao.asp")
    End Sub

    Private Sub PreencherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PreencherToolStripMenuItem1.Click
        If FrmSocios.Visible = True Then
            Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text
            Dim DataNascimento As String = FrmSocios.DatadeNascMaskedTextBox.Text

            'id="txtCPF"
            WebView.ExecuteScriptAsync("document.getElementById('txtCPF').value = '" & CPF & "'")
            'id="txtDataNascimento"
            WebView.ExecuteScriptAsync("document.getElementById('txtDataNascimento').value = '" & DataNascimento & "'")
        Else
            'mgsbox Form nao aberto
            MsgBox("Formulario Sócios, não está aberto")
        End If
    End Sub

    Private Sub PreencherToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PreencherToolStripMenuItem2.Click
        If FrmLegalizacao.Visible = True Then
            Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
            'id="cnpj"
            WebView.ExecuteScriptAsync("document.getElementById('cnpj').value = '" & CNPJ & "'")
        ElseIf FrmAlvara.Visible = True Then
            Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text
            'id="cnpj"
            WebView.ExecuteScriptAsync("document.getElementById('cnpj').value = '" & CNPJ & "'")
        Else
            'mgsbox Form nao aberto
            MsgBox("Formulario Empresas ou Alvará, não está aberto")
        End If
    End Sub
End Class