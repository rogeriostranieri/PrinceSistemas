Public Class ConsultaIE
    Private Sub ConsultaCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
    Private Sub ConsultaIE_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WebView21.Dispose()
    End Sub

End Class