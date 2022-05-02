Public Class BoxConsultaCNPJLaudo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        System.Diagnostics.Process.Start("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/Cnpjreva_Solicitacao2.asp?cnpj=" + CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        Me.Close()
    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        Dim CNPJ As String = FrmAlvara.CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        ConsultaCNPJ.Show()
        ConsultaCNPJ.WebBrowser1.Navigate("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/Cnpjreva_Solicitacao3.asp?cnpj=" + CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        Me.Close()
    End Sub


End Class
