Public Class FrmWebLaudoNovoMaringaPR
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



    Private Sub ImportarCNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarCNPJToolStripMenuItem.Click
        WebView21.ExecuteScriptAsync("document.getElementById('form:maskCpfResp:maskCpfResp').value = '" & FrmAlvara.CNPJMaskedTextBox.Text.Replace("/", "").Replace(".", "").Replace("-", "") & "'")

    End Sub

    Private Sub CadastroImobiliarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroImobiliarioToolStripMenuItem.Click
        WebView21.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:codImobiliario').value = '" & FrmAlvara.CNPJMaskedTextBox.Text.Replace("/", "").Replace(".", "").Replace("-", "") & "'")
        'clicar em id=formCadastroImobiliario:btnConsultaCadastro
        WebView21.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:btnConsultaCadastro').click()")
    End Sub

    Private Sub EndereçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndereçoToolStripMenuItem.Click
        Dim Rua As String = FrmAlvara.EnderecoTextBox.Text
        Dim N As String = FrmAlvara.EndNumTextBox.Text
        'selecionar TabAlvara, TabControl2 do  FrmAlvara
        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        'selecionar aba FrmAlvara.TabControl2 1
        FrmAlvara.TabControl2.SelectTab(1)
        'voltar
        Me.Focus()
        WebView21.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:pesqEndereco_input').value = '" & Rua & ", " & N & "'")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'imput no id  "form:numeroSolicitacao"  com os dados do FrmAlvara.NlaudoTextBox.Text
        WebView21.ExecuteScriptAsync("document.getElementById('form:numeroSolicitacao').value = '" & FrmAlvara.NlaudoTextBox.Text & "'")
        'clicar no botao form:btnPesquisar
        WebView21.ExecuteScriptAsync("document.getElementById('form:btnPesquisar').click()")
    End Sub

    Private Sub ÁreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaToolStripMenuItem.Click

        'selecionar TabAlvara, TabControl2 do  FrmAlvara
        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        'selecionar aba FrmAlvara.TabControl2 1
        FrmAlvara.TabControl2.SelectTab(1)

        'id="form:areaConstruida_input"
        'AreaTextBox
        WebView21.ExecuteScriptAsync("document.getElementById('form:areaConstruida_input').value = '" & FrmAlvara.AreaTextBox.Text & "'")
        'id="form:areaPatio_input"
        'Area2TextBox
        WebView21.ExecuteScriptAsync("document.getElementById('form:areaPatio_input').value = '" & FrmAlvara.Area2TextBox.Text & "'")

    End Sub

    Private Sub CnaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CnaeToolStripMenuItem.Click
        'selecionar TabAlvara, TabControl2 do  FrmAlvara
        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        'selecionar aba FrmAlvara.TabControl2 1
        FrmAlvara.TabControl2.SelectTab(3)

        'mostar form
        FrmAlvara.Focus()
    End Sub
End Class