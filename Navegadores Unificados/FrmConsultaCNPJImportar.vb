Imports System.Net.Http

Public Class FrmConsultaCNPJImportar

    Private url As String = "https://www.microsoft.com"
    Dim fns As Boolean = False




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BtnImportar_ClickAsync()

    End Sub


    Private Sub BtnImportar_ClickAsync()

        'mostrar WebBrowser1
        WebView21.Visible = True

        'DAdos doCNPJ
        Dim CNPJ As String = TextBox1.Text
        Dim CNPJ_Limpo As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        'Consulta automatizada do CNPJ no site da receita federal 
        Dim urlBaseReceitaFederal = "http://servicos.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?"
        Dim url As String = urlBaseReceitaFederal & "cnpj=" & CNPJ_Limpo

        'Consulta o site da receita federal
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = client.GetAsync(url).Result
        Dim result As String = response.Content.ReadAsStringAsync().Result

        'mostrar o site para digitar
        WebView21.Source = New Uri(url)
        WebView21.Refresh()

        'Pegar o HTML da pagina



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'abrir o site https://www.cnpj.ws/ , preencher o CNPJ na class=input_1JKQ, 
        'DAdos doCNPJ
        Dim CNPJ As String = TextBox1.Text
        Dim CNPJ_Limpo As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        'Consulta automatizada do CNPJ no site da receita federal 
        Dim urlBaseReceitaFederal = "http://servicos.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?"
        Dim url As String = urlBaseReceitaFederal & "cnpj=" & CNPJ_Limpo



    End Sub
End Class