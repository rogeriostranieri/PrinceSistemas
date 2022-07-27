Public Class WebConsultaTituloDeEleitor
    Private Sub WebConsultaTituloDeEleitor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

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

    Private Sub WebView2_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregamento Completo"

    End Sub

    'ao fechar form tambem fechar webview2
    Private Sub WebConsultaTituloDeEleitor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WebView21.Dispose()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'procura o campo  
        'preencher com os dados do FrmSocios.CPFMaskedTextBox
        'Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text.Replace(".", "").Replace("-", "")
        Dim NomeCompleto As String = FrmSocios.NomeCompletoTextBox.Text
        Dim DataNascimento As String = FrmSocios.DatadeNascMaskedTextBox.Text
        Dim NomeMae As String = FrmSocios.NomeMaeTextBox.Text
        'id="LV_NomeTituloCPF"
        WebView21.ExecuteScriptAsync("document.getElementById('LV_NomeTituloCPF').value = '" & NomeCompleto & "'")
        'id="LV_DataNascimento"
        WebView21.ExecuteScriptAsync("document.getElementById('LV_DataNascimento').value = '" & DataNascimento & "'")
        'id="LV_NomeMae"
        WebView21.ExecuteScriptAsync("document.getElementById('LV_NomeMae').value = '" & NomeMae & "'")
        'id="consultar-local-votacao-form-submit"
        ' WebView21.ExecuteScriptAsync("document.getElementById('consultar-local-votacao-form-submit').click()")
    End Sub

End Class