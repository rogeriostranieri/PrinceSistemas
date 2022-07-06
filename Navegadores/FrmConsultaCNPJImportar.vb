Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class FrmConsultaCNPJImportar
    Private Sub FrmConsultaCNPJImportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Source = New Uri("https://minhareceita.org/")

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'consulta cnpj TextBox1 e mostra razão social TextBox2
        Dim cnpj As String = TextBox1.Text
        Dim url As String = "https://www.receitaws.com.br/v1/cnpj/" & cnpj
        Dim client As New HttpClient
        Dim response As HttpResponseMessage = Await client.GetAsync(url)
        Dim json As String = Await response.Content.ReadAsStringAsync
        Dim jsonObj As JObject = JObject.Parse(json)
        TextBox2.Text = jsonObj.SelectToken("nome").ToString
        'consulta cnpj TextBox1 e mostra endereço TextBox3


    End Sub

End Class