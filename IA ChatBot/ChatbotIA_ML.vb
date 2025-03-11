Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Data
Imports System.Text.RegularExpressions
Imports Microsoft.ML
Imports Microsoft.ML.Data
Imports Lucene.Net.Analysis
Imports Lucene.Net.Analysis.Snowball
Imports Lucene.Net.Analysis.Tokenattributes
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports Lucene.Net.Analysis.Common
Imports Lucene.Net.Util



Public Class ChatbotIA_ML
    ' Propriedade para armazenar a empresa atualmente selecionada.
    Public Shared EmpresaSelecionada As String = ""
    ' Lista para armazenar os dados transformados do CSV.
    Private Shared ReadOnly perguntasTransformadas As New List(Of PerguntaTransformed)()
    Private Shared mlContext As New MLContext()
    ' Pipeline treinado para transformar os textos em vetores.
    Private Shared textTransformer As ITransformer

    Shared Sub New()
        CarregarPerguntasDoCSV_ML()
    End Sub

    ' Carrega o CSV embutido e transforma os dados.
    Private Shared Sub CarregarPerguntasDoCSV_ML()
        Dim path = CarregarArquivoCSV()
        Console.WriteLine("Carregando dados de: " & path)

        ' Configura as opções do TextLoader.
        Dim options = New TextLoader.Options With {
        .HasHeader = True,
        .Separators = New Char() {","c},
        .AllowQuoting = True,
        .TrimWhitespace = True
    }
        Dim loader = mlContext.Data.CreateTextLoader(Of PerguntaData)(options)
        Dim data = loader.Load(path)

        ' Cria um pipeline para featurizar o texto da pergunta.
        Dim pipeline = mlContext.Transforms.Text.FeaturizeText(outputColumnName:="Features", inputColumnName:="Pergunta")
        textTransformer = pipeline.Fit(data)
        Dim transformedData = textTransformer.Transform(data)

        ' Converte os dados transformados para uma lista.
        Dim perguntasData = mlContext.Data.CreateEnumerable(Of PerguntaTransformed)(transformedData, reuseRowObject:=False).ToList()
        perguntasTransformadas.AddRange(perguntasData)
        Console.WriteLine($"Total de perguntas carregadas e transformadas: {perguntasTransformadas.Count}")

        ' Log para verificar os dados carregados
        For Each pergunta In perguntasTransformadas
            Console.WriteLine($"Pergunta: {pergunta.Pergunta}, SQLQuery: {pergunta.SQLQuery}")
        Next
    End Sub



    ' Função para pré-processar o texto, aplicando o stemming a cada palavra.
    Private Shared Function PreprocessText(input As String) As String
        Dim words() As String = input.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim stemmedWords = words.Select(Function(w) GetLuceneStem(w))
        Return String.Join(" ", stemmedWords)
    End Function


    ' Remove diacríticos (acentos) de um texto.
    Private Shared Function RemoveDiacritics(text As String) As String
        Dim normalizedString As String = text.Normalize(NormalizationForm.FormD)
        Dim stringBuilder As New System.Text.StringBuilder()

        For Each c As Char In normalizedString
            Dim uc As UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c)
            If uc <> UnicodeCategory.NonSpacingMark Then
                stringBuilder.Append(c)
            End If
        Next

        Return stringBuilder.ToString().Normalize(NormalizationForm.FormC)
    End Function

    ' Normaliza a entrada: converte para minúsculas e remove acentos.
    Private Shared Function NormalizeInput(input As String) As String
        Return RemoveDiacritics(input.ToLowerInvariant())
    End Function

    ' Função de stemming utilizando o SnowballAnalyzer para Português.
    ' Agora utiliza o construtor que aceita a versão do Lucene.Net.
    Private Shared Function GetLuceneStem(word As String) As String
        Dim normalizedWord As String = NormalizeInput(word)
        Dim analyzer As New SnowballAnalyzer(Version.LUCENE_30, "Portuguese")


        Using reader As New StringReader(normalizedWord)
            Dim tokenStream As TokenStream = analyzer.TokenStream("field", reader)
            tokenStream.Reset()
            Dim termAttr As ITermAttribute = tokenStream.GetAttribute(Of ITermAttribute)()
            Dim stem As String = ""
            If tokenStream.IncrementToken() Then
                stem = termAttr.Term
            End If
            tokenStream.End()
            tokenStream.Dispose()
            Return stem
        End Using
    End Function



    ' Calcula a similaridade de cosseno entre dois vetores.
    Private Shared Function CalcularSimilaridadeCoseno(vetorA As Single(), vetorB As Single()) As Single
        Dim dotProd As Single = 0
        Dim normA As Single = 0
        Dim normB As Single = 0
        For i As Integer = 0 To vetorA.Length - 1
            dotProd += vetorA(i) * vetorB(i)
            normA += vetorA(i) * vetorA(i)
            normB += vetorB(i) * vetorB(i)
        Next
        If normA = 0 Or normB = 0 Then Return 0
        Return dotProd / (CSng(Math.Sqrt(normA)) * CSng(Math.Sqrt(normB)))
    End Function

    ' Interpreta a pergunta do usuário utilizando similaridade de cosseno.
    Public Shared Function InterpretarPergunta(perguntaUsuario As String, Optional parametro As String = Nothing) As String
        perguntaUsuario = perguntaUsuario.Trim().ToLower()
        Dim userData = New List(Of PerguntaData) From {
        New PerguntaData With {.Pergunta = perguntaUsuario}
    }
        Dim userDataView = mlContext.Data.LoadFromEnumerable(userData)
        Dim transformedUserData = textTransformer.Transform(userDataView)
        Dim userTransformed = mlContext.Data.CreateEnumerable(Of PerguntaTransformed)(transformedUserData, reuseRowObject:=False).FirstOrDefault()

        If userTransformed Is Nothing Then
            Console.WriteLine("Falha ao transformar a pergunta do usuário.")
            Return Nothing
        End If

        Dim userVector = userTransformed.Features
        Dim melhorSimilaridade As Single = -1
        Dim sqlSelecionada As String = Nothing

        For Each item In perguntasTransformadas
            Dim similaridade = CalcularSimilaridadeCoseno(userVector, item.Features)
            If similaridade > melhorSimilaridade Then
                melhorSimilaridade = similaridade
                sqlSelecionada = item.SQLQuery
            End If
        Next

        ' Se a similaridade for baixa, aplica fallback se o texto pré-processado contiver "busc".
        If melhorSimilaridade < 0.7 Then
            Dim preprocessed As String = PreprocessText(perguntaUsuario)
            If preprocessed.Contains("busc") Then
                Dim fallbackQuery As String = "SELECT ID_Empresas, RazaoSocial, CNPJ FROM Empresas WHERE RazaoSocial LIKE '@Busca'"
                Return AplicarParametro(fallbackQuery, Nothing)
            End If
            Return Nothing
        End If

        ' Extrai o termo de busca, se aplicável.
        Dim termoBusca As String = parametro
        If String.IsNullOrEmpty(termoBusca) AndAlso sqlSelecionada.Contains("@Busca") Then
            Dim palavras() As String = perguntaUsuario.Split(" "c)
            termoBusca = palavras.LastOrDefault(Function(p) Not String.IsNullOrWhiteSpace(p))
        End If

        Console.WriteLine($"SQL Selecionada: {sqlSelecionada}")
        Console.WriteLine($"Termo de Busca: {termoBusca}")

        Return AplicarParametro(sqlSelecionada, termoBusca)
    End Function




    ' Substitui os placeholders na consulta SQL.
    Private Shared Function AplicarParametro(sqlQuery As String, parametro As String) As String
        If String.IsNullOrEmpty(parametro) Then parametro = EmpresaSelecionada
        If String.IsNullOrEmpty(parametro) Then Return sqlQuery
        Return sqlQuery.Replace("@CNPJ", $"'{parametro}'") _
               .Replace("@Cidade", $"'{parametro}'") _
               .Replace("@Responsavel", $"'{parametro}'") _
               .Replace("@CNAE", $"'{parametro}'") _
               .Replace("@Estado", $"'{parametro}'") _
               .Replace("@Requerente", $"'{parametro}'") _
               .Replace("@Protocolo", $"'{parametro}'") _
               .Replace("@Empresa", $"'{parametro}'") _
               .Replace("@Busca", $"%{parametro}%")
    End Function


    ' Executa a consulta SQL e retorna um DataTable com os resultados.
    Public Shared Function ExecutarConsulta(sqlQuery As String) As DataTable
        Dim dt As New DataTable()
        Try
            Console.WriteLine("Executando consulta: " & sqlQuery)
            Dim startTime As DateTime = DateTime.Now
            Using conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False")
                conexao.Open()
                Dim comando As New SqlCommand(sqlQuery, conexao)
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)
            End Using
            Console.WriteLine($"Consulta executada em {(DateTime.Now - startTime).TotalSeconds} segundos. Linhas retornadas: {dt.Rows.Count}")
        Catch ex As Exception
            Console.WriteLine("Erro ao executar consulta: " & ex.Message)
        End Try
        Return dt
    End Function


    ' Carrega o arquivo CSV embutido e o salva em um caminho temporário.
    Private Shared Function CarregarArquivoCSV() As String
        Dim assembly As Assembly = Assembly.GetExecutingAssembly()
        Dim resourceName As String = "PrinceSistemas.perguntas_sql.csv" ' Verifique se o nome do recurso está correto
        Using stream As Stream = assembly.GetManifestResourceStream(resourceName)
            If stream Is Nothing Then
                Throw New Exception("Recurso não encontrado: " & resourceName)
            End If
            Using reader As New StreamReader(stream)
                Dim csvContent = reader.ReadToEnd()
                Dim tempCsvPath = Path.Combine(Path.GetTempPath(), "perguntas_sql_temp.csv")
                File.WriteAllText(tempCsvPath, csvContent)
                Console.WriteLine("CSV temporário salvo em: " & tempCsvPath)
                Return tempCsvPath
            End Using
        End Using
    End Function

End Class