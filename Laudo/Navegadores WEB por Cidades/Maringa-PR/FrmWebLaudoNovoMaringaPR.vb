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

    Private Sub WebView21_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregamento Completo"

    End Sub



    Private Sub ImportarCNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarCNPJToolStripMenuItem.Click
        Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text.Replace("/", "").Replace(".", "").Replace("-", "") & "'"
        WebView21.ExecuteScriptAsync("document.getElementById('form:maskCpfResp:maskCpfResp').value = '" & CNPJ)

    End Sub

    Private Sub CadastroImobiliarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroImobiliarioToolStripMenuItem.Click
        'ativar TabAlvara 0
        FrmAlvara.TabAlvara.SelectedIndex = 0
        'TabControl2
        FrmAlvara.TabControl2.SelectedIndex = 1
        Dim CADIMOB As String = FrmAlvara.CadImobTextBox.Text
        Me.Focus()
        'WebView21 Id('formCadastroImobiliario:codImobiliario') 
        WebView21.ExecuteScriptAsync("document.getElementById('formCadastroImobiliario:codImobiliario').value = '" & CADIMOB & "'")
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

        Dim Area1 As String = FrmAlvara.AreaTextBox.Text
        Dim Area2 As String = FrmAlvara.Area2TextBox.Text


        Me.Focus()
        'id="form:areaConstruida_input"
        'AreaTextBox
        WebView21.ExecuteScriptAsync("document.getElementById('form:areaConstruida_input').value = '" & Area1 & "'")
        'id="form:areaPatio_input"
        'Area2TextBox
        WebView21.ExecuteScriptAsync("document.getElementById('form:areaPatio_input').value = '" & Area2 & "'")

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

    'ao fechar form tambem fechar webview2
    Private Sub FrmWebLaudoNovoMaringaPR_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WebView21.Dispose()
    End Sub



    Private Sub FrmWebLaudoNovoMaringaPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class