Imports System.Net.Http

Module ModuloBuscaCEP
    Public Async Function BuscarCEPAsync(cep As String) As Task(Of ViaCEP)
        ' Remover qualquer caractere não numérico do CEP
        Dim CepLimpo As New String(cep.Where(AddressOf Char.IsDigit).ToArray())

        If CepLimpo.Length <> 8 Then
            Throw New ArgumentException("CEP inválido. Por favor, insira um CEP válido.")
        End If

        Dim url As String = $"https://viacep.com.br/ws/{cepLimpo}/json/"

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            response.EnsureSuccessStatusCode()

            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim resultado = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ViaCEP)(responseBody)

            If resultado IsNot Nothing AndAlso String.IsNullOrEmpty(resultado.erro) Then
                Return resultado
            Else
                Return Nothing
            End If
        End Using
    End Function

    Public Class ViaCEP
        Public Property Cep As String
        Public Property Logradouro As String
        Public Property Complemento As String
        Public Property Bairro As String
        Public Property Localidade As String
        Public Property Uf As String
        Public Property Erro As String
    End Class
End Module

