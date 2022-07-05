
Public Class ConsultaCNPJ
    Private Sub ConsultaCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)

        'barra de progresso e % no TxtCarregar do WebView21
        If e.CurrentProgress > 0 And e.MaximumProgress > 0 Then
            Dim pct As Integer = CInt(e.CurrentProgress / e.MaximumProgress * 100)
            If pct > 100 Then pct = 100
            TxtCarregar.Text = pct & "%"
            ProgressBar1.Value = pct
        End If


    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        'procura campo lagradouro e pega o endereço do site

    End Sub
End Class