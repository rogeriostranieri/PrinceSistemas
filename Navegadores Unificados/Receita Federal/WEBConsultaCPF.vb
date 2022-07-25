Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class WEBConsultaCPF
    Private Sub WEBConsultaCPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WEBConsultaCPF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
    Private Sub WEBConsultaCPF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WebView21.Dispose()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'procura o id="txtCPF", e preencher com o CPF
        Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text
        Dim DN As String = FrmSocios.DatadeNascMaskedTextBox.Text
        WebView21.ExecuteScriptAsync("document.getElementById('txtCPF').value = '" & CPF & "'")
        'id="txtDataNascimento"
        WebView21.ExecuteScriptAsync("document.getElementById('txtDataNascimento').value = '" & DN & "'")
    End Sub




    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        '     FrmSocios.NomeCompletoTextBox.Text
        'mgs box informando que está em teste
        MsgBox("Esta função está em teste, por favor, não use para nenhum outro propósito.")
    End Sub
End Class