Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.IO
Imports Lucene.Net.Analysis
Imports Lucene.Net.Analysis.Snowball
Imports Lucene.Net.Analysis.Tokenattributes
Imports System.Collections.Generic
Imports System.Text

Public Class ChatBot
    ' Variável para armazenar a empresa pré-selecionada antes da confirmação
    Private EmpresaPreSelecionada As String = ""

    ' ---------------------- Funções de Normalização e Stemming com Lucene.Net 3.0.3 ----------------------

    ' Remove diacríticos (acentos) de um texto
    Private Function RemoveDiacritics(text As String) As String
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

    ' Normaliza a entrada: converte para minúsculas e remove acentos
    Private Function NormalizeInput(input As String) As String
        Return RemoveDiacritics(input.ToLowerInvariant())
    End Function

    ' Função de stemming utilizando o SnowballAnalyzer para Português
    Private Function GetLuceneStem(word As String) As String
        Dim normalizedWord As String = NormalizeInput(word)
        ' Cria um conjunto vazio de stopwords para passar ao construtor.
        Dim stopWords As ISet(Of String) = New HashSet(Of String)()
        Dim analyzer As Analyzer = New SnowballAnalyzer("Portuguese", stopWords)
        Using reader As New StringReader(normalizedWord)
            Dim tokenStream As TokenStream = analyzer.TokenStream("field", reader)
            tokenStream.Reset()
            ' Em Lucene.Net 3.0.3 usamos ITermAttribute com a sintaxe genérica
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

    ' Compara se o stem da palavra de entrada é semelhante ao do comando alvo
    Private Function IsSimilar(input As String, target As String) As Boolean
        Return GetLuceneStem(input).StartsWith(GetLuceneStem(target))
    End Function

    ' ---------------------- Fim das Funções de Normalização ----------------------

    ' Sub auxiliar para inserir mensagens com prefixo em negrito
    Private Sub AppendMessage(prefix As String, message As String)
        ' Move a seleção para o fim do texto
        RichTextBoxResposta.SelectionStart = RichTextBoxResposta.TextLength
        RichTextBoxResposta.SelectionLength = 0
        ' Insere o prefixo em negrito
        RichTextBoxResposta.SelectionFont = New Font(RichTextBoxResposta.Font, FontStyle.Bold)
        RichTextBoxResposta.AppendText(prefix)
        ' Insere a mensagem em fonte regular
        RichTextBoxResposta.SelectionFont = New Font(RichTextBoxResposta.Font, FontStyle.Regular)
        RichTextBoxResposta.AppendText(message & Environment.NewLine)
    End Sub

    ' Sub para mostrar/ocultar a 3ª linha do TableLayoutPanel1 (onde está o DataGridView)
    Private Sub ShowDataGrid(ByVal show As Boolean)
        If show Then
            ' Define a altura desejada (ajuste conforme necessário)
            TableLayoutPanel1.RowStyles(2).Height = 100
        Else
            TableLayoutPanel1.RowStyles(2).Height = 0
        End If
        DataGridViewResultados.Visible = show
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Dim pergunta As String = TextBoxPergunta.Text.Trim()
        If String.IsNullOrEmpty(pergunta) Then
            MessageBox.Show("Por favor, digite uma pergunta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Normaliza a entrada para comparações
        Dim normalizedPergunta As String = NormalizeInput(pergunta)

        Try
            AppendMessage("Você: ", pergunta)

            ' Verifica confirmação ou rejeição de empresa pré-selecionada
            If normalizedPergunta = "sim" AndAlso Not String.IsNullOrEmpty(EmpresaPreSelecionada) Then
                ChatbotIA_ML.EmpresaSelecionada = EmpresaPreSelecionada
                EmpresaPreSelecionada = ""
                AppendMessage("IA: ", "Beleza! A partir de agora, vou focar na empresa '" & ChatbotIA_ML.EmpresaSelecionada & "'. Pode mandar suas perguntas!")
                Return
            ElseIf (normalizedPergunta = "nao" OrElse normalizedPergunta = "não") AndAlso Not String.IsNullOrEmpty(EmpresaPreSelecionada) Then
                EmpresaPreSelecionada = ""
                AppendMessage("IA: ", "Ok, não vou usar essa empresa. Quer escolher outra ou continuar sem filtro?")
                Return
            ElseIf normalizedPergunta = "nao" OrElse normalizedPergunta = "não" Then
                ChatbotIA_ML.EmpresaSelecionada = ""
                AppendMessage("IA: ", "Certo, desmarquei a empresa. Vamos procurar em tudo agora. O que você quer saber?")
                Return
            End If

            ' Utiliza Regex para detectar comandos de abertura (ex.: "abrir essa empresa", "abrir estaempresa", etc.)
            Dim regexAbrirEmpresa As New Regex("^abrir\s+(?:essa|esta)?\s*empresa", RegexOptions.IgnoreCase)
            Dim regexAbrirLaudo As New Regex("^abrir\s+(?:esse|este|esta)?\s*laudo", RegexOptions.IgnoreCase)
            Dim regexAbrirParcelamento As New Regex("^abrir\s+(?:esse|este|esta)?\s*parcelamento", RegexOptions.IgnoreCase)

            Dim isAbrirEmpresa As Boolean = regexAbrirEmpresa.IsMatch(normalizedPergunta)
            Dim isAbrirLaudo As Boolean = regexAbrirLaudo.IsMatch(normalizedPergunta)
            Dim isAbrirParcelamento As Boolean = regexAbrirParcelamento.IsMatch(normalizedPergunta)

            ' Se for comando de abertura, abre o formulário correspondente utilizando a empresa selecionada
            If isAbrirEmpresa Or isAbrirLaudo Or isAbrirParcelamento Then
                If Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada) Then
                    If isAbrirEmpresa Then
                        FrmLegalizacao.Show()
                        FrmLegalizacao.ComboBoxBuscaEmpresa.Text = ChatbotIA_ML.EmpresaSelecionada
                        FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
                        AppendMessage("IA: ", "A empresa '" & ChatbotIA_ML.EmpresaSelecionada & "' foi aberta.")
                    ElseIf isAbrirLaudo Then
                        FrmAlvara.Show()
                        FrmAlvara.ComboBoxBuscaAlvara.Text = ChatbotIA_ML.EmpresaSelecionada
                        FrmAlvara.ComboBoxBuscaAlvara.Focus()
                        AppendMessage("IA: ", "O laudo para a empresa '" & ChatbotIA_ML.EmpresaSelecionada & "' foi aberto.")
                    ElseIf isAbrirParcelamento Then
                        FrmParcelamento.Show()
                        FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = ChatbotIA_ML.EmpresaSelecionada
                        FrmParcelamento.ComboBoxBuscarRazaoSocial.Focus()
                        AppendMessage("IA: ", "O parcelamento para a empresa '" & ChatbotIA_ML.EmpresaSelecionada & "' foi aberto.")
                    End If
                    Return
                Else
                    MessageBox.Show("Nenhuma empresa foi selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If

            ' Para outras perguntas, extrai parâmetro se houver (apenas se não for comando de abertura)
            Dim parametroBusca As String = Nothing
            If normalizedPergunta.StartsWith("abrir empresa") Then
                parametroBusca = pergunta.Substring("abrir empresa".Length).Trim()
            ElseIf normalizedPergunta.StartsWith("abrir laudo") Then
                parametroBusca = pergunta.Substring("abrir laudo".Length).Trim()
            ElseIf normalizedPergunta.StartsWith("abrir parcelamento") Then
                parametroBusca = pergunta.Substring("abrir parcelamento".Length).Trim()
            End If

            ' Monta a consulta SQL usando o método InterpretarPergunta (o SQL não é exibido para o usuário)
            Dim sqlQuery As String = ChatbotIA_ML.InterpretarPergunta(pergunta, parametroBusca)
            If String.IsNullOrEmpty(sqlQuery) Then
                AppendMessage("IA: ", "Hmm, não entendi direito o que você quer. Pode explicar melhor?")
                ShowDataGrid(False)
                Return
            End If

            ' Define flag de busca para comandos "buscar", "procurar", "localizar" ou "cade"
            Dim isBuscaEmpresa As Boolean = IsSimilar(normalizedPergunta, "buscar") OrElse
                                            IsSimilar(normalizedPergunta, "procurar") OrElse
                                            IsSimilar(normalizedPergunta, "localizar") OrElse
                                            IsSimilar(normalizedPergunta, "cade")
            Dim isBuscaOuAbrir As Boolean = isBuscaEmpresa OrElse isAbrirEmpresa OrElse isAbrirLaudo OrElse isAbrirParcelamento

            ' Aplica filtro de empresa selecionada se houver (exceto para consultas de contagem)
            If Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada) AndAlso
               Not isBuscaEmpresa AndAlso
               Not normalizedPergunta.Contains("quantos") AndAlso
               Not normalizedPergunta.Contains("contar") Then
                If Not sqlQuery.Contains("RazaoSocial =") Then
                    sqlQuery &= " AND RazaoSocial = '" & ChatbotIA_ML.EmpresaSelecionada & "'"
                End If
            End If

            ' Executa a consulta SQL (sem exibir o comando para o usuário)
            Dim resultados As DataTable = ChatbotIA_ML.ExecutarConsulta(sqlQuery)

            Dim formOpened As Boolean = False

            If resultados.Rows.Count > 0 Then
                If isBuscaOuAbrir AndAlso resultados.Columns.Contains("RazaoSocial") Then
                    If resultados.Rows.Count = 1 Then
                        Dim razaoSocial As String = resultados.Rows(0)("RazaoSocial").ToString()
                        Dim cnpj As String = resultados.Rows(0)("CNPJ").ToString()

                        ' Armazena a empresa encontrada
                        EmpresaPreSelecionada = razaoSocial
                        ChatbotIA_ML.EmpresaSelecionada = razaoSocial

                        AppendMessage("IA: ", "Encontrei só uma: '" & razaoSocial & "' (CNPJ: " & cnpj & ").")
                        ShowDataGrid(False)

                        ' Se o comando for de abertura, abre o formulário automaticamente
                        If isAbrirEmpresa Then
                            FrmLegalizacao.Show()
                            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocial
                            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
                            formOpened = True
                        ElseIf isAbrirLaudo Then
                            FrmAlvara.Show()
                            FrmAlvara.ComboBoxBuscaAlvara.Text = razaoSocial
                            FrmAlvara.ComboBoxBuscaAlvara.Focus()
                            formOpened = True
                        ElseIf isAbrirParcelamento Then
                            FrmParcelamento.Show()
                            FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = razaoSocial
                            FrmParcelamento.ComboBoxBuscarRazaoSocial.Focus()
                            formOpened = True
                        Else
                            If MessageBox.Show("Você quer usar essa empresa como filtro para tudo daqui pra frente?", "Confirmação", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                formOpened = True
                            End If
                        End If
                    Else
                        ' Se houver múltiplos resultados, exibe-os no DataGridView para seleção
                        DataGridViewResultados.DataSource = resultados
                        AppendMessage("IA: ", "Achei " & resultados.Rows.Count & " empresas com algo parecido. Dá uma olhada no grid e clique duas vezes na que você quer pra eu usar como filtro!")
                        ShowDataGrid(True)
                    End If
                Else
                    ' Para outras perguntas, exibe resultado único ou múltiplos resultados
                    If resultados.Rows.Count = 1 Then
                        Dim resposta As String = "Aqui está o resultado"
                        For Each col As DataColumn In resultados.Columns
                            resposta &= Environment.NewLine & col.ColumnName & ": " & resultados.Rows(0)(col).ToString()
                        Next
                        AppendMessage("IA: ", resposta)
                        ShowDataGrid(False)
                    Else
                        DataGridViewResultados.DataSource = resultados
                        Dim contexto As String = If(Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada),
                                                   " da '" & ChatbotIA_ML.EmpresaSelecionada & "'",
                                                   " em geral")
                        AppendMessage("IA: ", "Aqui estão " & resultados.Rows.Count & " resultados" & contexto & ". Veja no grid abaixo!")
                        ShowDataGrid(True)
                    End If
                End If
            Else
                AppendMessage("IA: ", "Não achei nada com essa pergunta. Quer tentar de outro jeito?")
                ShowDataGrid(False)
            End If

            ' Ações adicionais: se o comando for de abertura e o formulário ainda não foi aberto
            If isAbrirEmpresa AndAlso Not formOpened Then
                If Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada) Then
                    FrmLegalizacao.Show()
                    FrmLegalizacao.ComboBoxBuscaEmpresa.Text = ChatbotIA_ML.EmpresaSelecionada
                    FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
                Else
                    MessageBox.Show("Nenhuma empresa foi selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            ElseIf isAbrirLaudo AndAlso Not formOpened Then
                If Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada) Then
                    FrmAlvara.Show()
                    FrmAlvara.ComboBoxBuscaAlvara.Text = ChatbotIA_ML.EmpresaSelecionada
                    FrmAlvara.ComboBoxBuscaAlvara.Focus()
                Else
                    MessageBox.Show("Nenhuma empresa foi selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            ElseIf isAbrirParcelamento AndAlso Not formOpened Then
                If Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada) Then
                    FrmParcelamento.Show()
                    FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = ChatbotIA_ML.EmpresaSelecionada
                    FrmParcelamento.ComboBoxBuscarRazaoSocial.Focus()
                Else
                    MessageBox.Show("Nenhuma empresa foi selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ops, algo deu errado: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChatBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxResposta.Clear()
        AppendMessage("IA: ", "Pronto para receber sua pergunta!")
        TextBoxPergunta.Focus()
        ShowDataGrid(False)
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub BtnRecomecar_Click(sender As Object, e As EventArgs) Handles BtnRecomecar.Click
        ' Limpa todo o histórico e reinicia a conversa
        ChatbotIA_ML.EmpresaSelecionada = ""
        EmpresaPreSelecionada = ""
        RichTextBoxResposta.Clear()
        AppendMessage("IA: ", "Pronto para receber sua pergunta!")
        TextBoxPergunta.Clear()
        TextBoxPergunta.Focus()
        ShowDataGrid(False)
    End Sub

    Private Sub TextBoxPergunta_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPergunta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim resposta As String = NormalizeInput(TextBoxPergunta.Text.Trim())
            If resposta = "sim" AndAlso ChatbotIA_ML.EmpresaSelecionada <> "" Then
                AppendMessage("IA: ", "A empresa '" & ChatbotIA_ML.EmpresaSelecionada & "' foi confirmada para buscas futuras.")
            ElseIf resposta = "nao" OrElse resposta = "não" Then
                ChatbotIA_ML.EmpresaSelecionada = ""
                AppendMessage("IA: ", "A empresa escolhida foi desmarcada.")
            End If
        End If
    End Sub

    Private Sub DataGridViewResultados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewResultados.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewResultados.Rows(e.RowIndex)
            Dim razaoSocial As String = selectedRow.Cells("RazaoSocial").Value.ToString()
            EmpresaPreSelecionada = razaoSocial ' Armazena como pré-selecionada
            AppendMessage("IA: ", "Você clicou em '" & razaoSocial & "'. É essa que você quer usar como filtro pra tudo daqui pra frente? (Diga 'sim' ou 'não')")
        End If
    End Sub

End Class
