Public Class FrmBombeiroPR
    Private Sub ConsultaCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub FrmBombeiroPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/acompanharProcesso.do?action=informacoesProcesso")
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


End Class