Public Class ChatBot
    ' Evento do botão "Procurar"
    ' Variável para armazenar a empresa pré-selecionada antes da confirmação
    Private EmpresaPreSelecionada As String = ""

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Dim pergunta As String = TextBoxPergunta.Text.Trim()
        If String.IsNullOrEmpty(pergunta) Then
            MessageBox.Show("Por favor, digite uma pergunta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            RichTextBoxResposta.AppendText($"{Environment.NewLine}Você: {pergunta}")

            ' Verifica confirmação ou rejeição de empresa pré-selecionada
            If pergunta.ToLower() = "sim" AndAlso Not String.IsNullOrEmpty(EmpresaPreSelecionada) Then
                ChatbotIA_ML.EmpresaSelecionada = EmpresaPreSelecionada
                EmpresaPreSelecionada = ""
                RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Beleza! A partir de agora, vou focar na empresa '{ChatbotIA_ML.EmpresaSelecionada}'. Pode mandar suas perguntas!")
                Return
            ElseIf pergunta.ToLower() = "não" OrElse pergunta.ToLower() = "nao" AndAlso Not String.IsNullOrEmpty(EmpresaPreSelecionada) Then
                EmpresaPreSelecionada = ""
                RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Ok, não vou usar essa empresa. Quer escolher outra ou continuar sem filtro?")
                Return
            ElseIf pergunta.ToLower() = "não" OrElse pergunta.ToLower() = "nao" Then
                ChatbotIA_ML.EmpresaSelecionada = ""
                RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Certo, desmarquei a empresa. Vamos procurar em tudo agora. O que você quer saber?")
                Return
            End If

            ' Interpreta a pergunta
            Dim sqlQuery As String = ChatbotIA_ML.InterpretarPergunta(pergunta)
            If String.IsNullOrEmpty(sqlQuery) Then
                RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Hmm, não entendi direito o que você quer. Pode explicar melhor?")
                Return
            End If

            ' Verifica se é uma busca inicial de empresa
            Dim isBuscaEmpresa As Boolean = pergunta.ToLower().Contains("buscar") OrElse
                                        pergunta.ToLower().Contains("procurar") OrElse
                                        pergunta.ToLower().Contains("localiza") OrElse
                                        pergunta.ToLower().Contains("cadê")

            ' Aplica o filtro de EmpresaSelecionada apenas se NÃO for busca inicial e não for contagem
            If Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada) AndAlso
           Not isBuscaEmpresa AndAlso
           Not pergunta.ToLower().Contains("quantos") AndAlso
           Not pergunta.ToLower().Contains("contar") Then
                If Not sqlQuery.Contains("RazaoSocial =") Then
                    sqlQuery = sqlQuery & " AND RazaoSocial = '" & ChatbotIA_ML.EmpresaSelecionada & "'"
                End If
            End If

            RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Aqui está o que eu montei pra buscar:{Environment.NewLine}{sqlQuery}")
            Dim resultados As DataTable = ChatbotIA_ML.ExecutarConsulta(sqlQuery)

            If resultados.Rows.Count > 0 Then
                If isBuscaEmpresa AndAlso resultados.Columns.Contains("RazaoSocial") Then
                    If resultados.Rows.Count = 1 Then
                        ' Mostra resultado único no RichTextBox
                        Dim razaoSocial As String = resultados.Rows(0)("RazaoSocial").ToString()
                        Dim cnpj As String = resultados.Rows(0)("CNPJ").ToString()
                        EmpresaPreSelecionada = razaoSocial
                        RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Encontrei só uma: '{razaoSocial}' (CNPJ: {cnpj}). Quer que eu use ela como filtro pra tudo daqui pra frente? (Diga 'sim' ou 'não')")
                    Else
                        ' Mostra múltiplos resultados no DataGridView
                        DataGridViewResultados.DataSource = resultados
                        RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Achei {resultados.Rows.Count} empresas com algo parecido. Dá uma olhada no grid e clica duas vezes na que você quer pra eu usar como filtro!")
                    End If
                Else
                    ' Outras perguntas: usa grid para múltiplos, texto para único
                    If resultados.Rows.Count = 1 Then
                        Dim resposta As String = "IA: Aqui está o resultado"
                        For Each col As DataColumn In resultados.Columns
                            resposta &= $"{Environment.NewLine}{col.ColumnName}: {resultados.Rows(0)(col).ToString()}"
                        Next
                        RichTextBoxResposta.AppendText($"{Environment.NewLine}{resposta}")
                    Else
                        DataGridViewResultados.DataSource = resultados
                        Dim contexto As String = If(Not String.IsNullOrEmpty(ChatbotIA_ML.EmpresaSelecionada),
                                               $" da '{ChatbotIA_ML.EmpresaSelecionada}'",
                                               " em geral")
                        RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Aqui estão {resultados.Rows.Count} resultados{contexto}. Veja no grid abaixo!")
                    End If
                End If
            Else
                RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Não achei nada com essa pergunta. Quer tentar de outro jeito?")
            End If
        Catch ex As Exception
            MessageBox.Show($"Ops, algo deu errado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento de clique duplo no DataGridView
    Private Sub DataGridViewResultados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewResultados.CellContentDoubleClick
        If DataGridViewResultados.SelectedRows.Count > 0 Then
            Dim razaoSocial As String = DataGridViewResultados.SelectedRows(0).Cells("RazaoSocial").Value.ToString()
            EmpresaPreSelecionada = razaoSocial ' Armazena como pré-selecionada
            RichTextBoxResposta.AppendText($"{Environment.NewLine}IA: Você clicou em '{razaoSocial}'. É essa que você quer usar como filtro pra tudo daqui pra frente? (Diga 'sim' ou 'não')")
        End If
    End Sub

    ' Evento de carregamento do formulário
    Private Sub ChatBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxResposta.Text = "Pronto para receber sua pergunta!"
        TextBoxPergunta.Focus()
    End Sub

    ' Evento do botão "Fechar"
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub
    Private Sub TextBoxPergunta_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPergunta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim resposta As String = TextBoxPergunta.Text.Trim().ToLower()

            ' Se o usuário digitar "sim", confirmar empresa
            If resposta = "sim" And ChatbotIA_ML.EmpresaSelecionada <> "" Then
                RichTextBoxResposta.AppendText($"{Environment.NewLine}A empresa '{ChatbotIA_ML.EmpresaSelecionada}' foi confirmada para buscas futuras.")
            ElseIf resposta = "não" OrElse resposta = "nao" Then
                ChatbotIA_ML.EmpresaSelecionada = "" ' Limpa a seleção
                RichTextBoxResposta.AppendText($"{Environment.NewLine}A empresa escolhida foi desmarcada.")
            End If
        End If
    End Sub


End Class