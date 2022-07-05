Public Class BuscaCNAE

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)

        If e.CurrentProgress > 0 And e.MaximumProgress > 0 Then
            Dim pct As Integer = CInt(e.CurrentProgress / e.MaximumProgress * 100)
            If pct > 100 Then pct = 100
            TxtCarregar.Text = pct & "%"
            ProgressBar1.Value = pct
        End If
    End Sub



    Private Sub WebAgenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub BuscaCNAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Source = New Uri("https://concla.ibge.gov.br/busca-online-cnae.html")

    End Sub
End Class