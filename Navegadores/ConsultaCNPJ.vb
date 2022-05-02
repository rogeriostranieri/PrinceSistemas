
Public Class ConsultaCNPJ
    Private Sub ConsultaCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged

        ProgressBar1.Visible = True

        Dim d, t As Integer

        d = e.CurrentProgress

        t = e.MaximumProgress

        If d <= 0 Then

            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            TxtCarregar.Text = "Completo"
            ToolStripLabel4.Visible = False

        Else


            ProgressBar1.Value = Math.Min(ProgressBar1.Maximum, Convert.ToInt32(Math.Floor(ProgressBar1.Maximum * (d / t))))
            TxtCarregar.Text = "Carregando..."
            ToolStripLabel4.Visible = True
            ToolStripLabel4.Text = "Aguarde Carregar a página a baixo"
        End If

    End Sub

    Private Sub ConsultaCNPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCarregar.Text = "Carregando..."


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class