Public Class FrmBombeiroPR
    Private Sub ConsultaCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub WebView2_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs)
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregamento Completo"

    End Sub

    Private Sub FrmBombeiroPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WebView21.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Acompanhar-Processo")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub


    Private Sub WebView2_NavigationStarting(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles WebView21.NavigationStarting
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
    Private Sub FrmBombeiroPR_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WebView21.Dispose()
    End Sub

    Private Sub ImportarCNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarCNPJToolStripMenuItem.Click
        'BombeiroNProcessoMaskedTextBox string sem . e -
        Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text '.Replace(".", "").Replace("-", "").Replace("/", "")
        'copiar e colar no local onde foi selecionado
        Clipboard.SetText(CNPJ)

    End Sub

    Private Sub ProcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessoToolStripMenuItem.Click
        'ativa TabAlvara
        FrmAlvara.TabAlvara.SelectTab(1)

        'BombeiroNProcessoMaskedTextBox string sem . e -
        Dim NProcesso As String = FrmAlvara.BombeiroNProcessoMaskedTextBox.Text.Replace(".", "").Replace("-", "")

        'procura "name=edicao.numeroProcesso" dentro do WebView21, script e coloca value = NProcesso
        Dim script As String = "document.getElementsByName('edicao.numeroProcesso')[0].value = '" & NProcesso & "';"
        WebView21.ExecuteScriptAsync(script)
    End Sub

    Private Sub CNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNPJToolStripMenuItem.Click
        'BombeiroNProcessoMaskedTextBox string sem . e -
        Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text '.Replace(".", "").Replace("-", "").Replace("/", "")
        'copiar e colar no local onde foi selecionado
        Clipboard.SetText(CNPJ)

    End Sub

    Private Sub DadosSolicitanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadosSolicitanteToolStripMenuItem.Click
        'mgsbox perguntando se foi selecionado do estado PR, se sim continuar

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
        Dim TELEFONE As String = Contador.TelefoneMaskedTextBox.Text.Substring(Contador.TelefoneMaskedTextBox.Text.IndexOf("(44)") + 4, 9)


        'procura a id=txt_rg no site 
        Dim script As String = "document.getElementById('txt_rg').value = '" & RG & "';"
        WebView21.ExecuteScriptAsync(script)
        'procura o name=edicao.solicitante.cpf e coloca o CPF
        script = "document.getElementsByName('edicao.solicitante.cpf')[0].value = '" & CPF & "';"
        WebView21.ExecuteScriptAsync(script)
        'name="edicao.solicitante.nome" com nome completo
        script = "document.getElementsByName('edicao.solicitante.nome')[0].value = '" & Nome & "';"
        WebView21.ExecuteScriptAsync(script)
        'DDD do telefone name="edicao.solicitante.dddTelefone"
        script = "document.getElementsByName('edicao.solicitante.dddTelefone')[0].value = '" & DDDTELEFONE & "';"
        WebView21.ExecuteScriptAsync(script)
        'telefone name="edicao.solicitante.telefone"
        script = "document.getElementsByName('edicao.solicitante.telefone')[0].value = '" & TELEFONE & "';"
        WebView21.ExecuteScriptAsync(script)
        'name="edicao.solicitante.email"
        script = "document.getElementsByName('edicao.solicitante.email')[0].value = '" & Email & "';"
        WebView21.ExecuteScriptAsync(script)
        'fechar Contador
        Contador.Close()

    End Sub

    Private Sub ÁreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaToolStripMenuItem.Click
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
        WebView21.ExecuteScriptAsync(script)

        'pegar areas Estabelecimento=  name="edicao.areaTotalEdificacao"
        script = "document.getElementsByName('edicao.areaTotalEdificacao')[0].value = '" & areas2 & "';"
        WebView21.ExecuteScriptAsync(script)

        'voltar TabAlvara 1
        FrmAlvara.TabAlvara.SelectTab(1)
        Me.Focus()

    End Sub

    Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesteToolStripMenuItem.Click

        ModCon.SalvaProtocolBomb()


        'procura a id="modalSucessoVistoria", depois o texto "Processo n°" PEGAR numero depois "Processo n°", e coloca depois na BombeiroNProcessoMaskedTextBox
        Dim script = "document.getElementById('modalSucessoVistoria').innerText.substring(document.getElementById('modalSucessoVistoria').innerText.indexOf('Processo n°') + 12, document.getElementById('modalSucessoVistoria').innerText.indexOf('Processo n°') + 22);"
        Dim BombeiroNProcesso As String = WebView21.ExecuteScriptAsync(script).ToString
        'copiar e colar no local onde foi selecionado
        Clipboard.SetText(BombeiroNProcesso)
        'colocar dentro da BombeiroNProcessoMaskedTextBox.text
        FrmAlvara.BombeiroNProcessoMaskedTextBox.Text = Clipboard.GetText
        'e tambem dentro do BombeiroExigenciaRichTextBox
        FrmAlvara.BombeiroExigenciaRichTextBox.Text = Clipboard.GetText


        FrmAlvara.BombeiroDataPedProcessoMaskedTextBox.Text = DateTime.Now.ToString()

        'BombeiroSituacaoComboBox selecionar o texto "Aguardando Pagamento"
        FrmAlvara.BombeiroSituacaoComboBox.SelectedIndex = 3



    End Sub
End Class