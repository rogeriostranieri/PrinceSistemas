Imports Microsoft.Web.WebView2.WinForms
Imports System.Net
Imports System.Web


Public Class FrmExtraiCNPJ


    '  Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)
    ' Limpa todos os \t do RichTextBox após a extração
    '   RichTextBox1.Text = RichTextBox1.Text.Replace("\t", "").Trim()
    '  End Sub
    Private Function IsFormOpen(formName As String) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = formName Then
                Return True
            End If
        Next
        Return False
    End Function


    '//////////////////////////////////////////////////////////////////
    Private Async Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        ' Verifica se o formulário FrmLegalizacao está aberto
        If Not IsFormOpen("FrmLegalizacao") Then
            MessageBox.Show("O formulário FrmLegalizacao está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            ' FrmLegalizacao.Visible = True
        End If

        ' Certifique-se de que o WebView está totalmente carregado
        If WebView21.CoreWebView2 IsNot Nothing Then

            ' Dicionário contendo os XPaths utilizados para diferentes elementos da página
            Dim xpaths As New Dictionary(Of String, String) From {
            {"CNPJ", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[2]/tbody/tr/td[1]/font[2]/b[1]"}
        }

            ' Extrai o CNPJ da página usando o XPath do dicionário
            Dim scriptCNPJ As String = $"document.evaluate(""{xpaths("CNPJ")}"", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.textContent;"
            Dim cnpjExtraido As String = Await WebView21.CoreWebView2.ExecuteScriptAsync(scriptCNPJ)

            ' Remove aspas duplas e espaços do valor extraído
            cnpjExtraido = cnpjExtraido.Replace("""", "").Trim()

            ' Remove todos os caracteres não numéricos do CNPJ extraído (deixa só números)
            cnpjExtraido = System.Text.RegularExpressions.Regex.Replace(cnpjExtraido, "[^\d]", "")

            ' Pega o CNPJ do MaskedTextBox e remove os caracteres não numéricos
            Dim cnpjMasked As String = CNPJMaskedTextBox.Text.Trim()
            cnpjMasked = System.Text.RegularExpressions.Regex.Replace(cnpjMasked, "[^\d]", "")
            'SITETextBox.Text = cnpjExtraido + cnpjMasked
            ' Verifica se o CNPJ extraído corresponde ao CNPJ no MaskedTextBox
            If cnpjExtraido = cnpjMasked Then
                ' Certifique-se de que o WebView está totalmente carregado
                If WebView21.CoreWebView2 IsNot Nothing Then
                    Dim resultado As String = Await ExtrairDadosCNPJ()
                    '  RichTextBox1.Text = resultado

                    ' Chama o método para limpar e formatar os dados
                    LimparDados()

                    ' Arruma o CNAE Principal
                    FrmLegalizacao.ArrumaCNAEPrincipal()

                    ' Arruma o CNAE Secundário
                    FrmLegalizacao.ArrumaCNAESecundario()

                    Me.Close()
                Else
                    MessageBox.Show("O WebView não está carregado corretamente.")
                End If
            Else
                MessageBox.Show("Consultar antes de exportar!")

            End If
        Else
            MessageBox.Show("O WebView não está carregado corretamente.")
        End If
    End Sub



    Private Sub LimparDados()
        ' Limpa e formata os dados no CNAESecundarioRichTextBox, RamoDeAtividadeRichTextBox e CNAEPrincipalTextBox
        FrmLegalizacao.RamoDeAtividadeRichTextBox.Text = CleanText(FrmLegalizacao.RamoDeAtividadeRichTextBox.Text, True)
        FrmLegalizacao.CNAEPrincipalTextBox.Text = CleanCNAE(FrmLegalizacao.CNAEPrincipalTextBox.Text)
        FrmLegalizacao.CNAESecundarioRichTextBox.Text = CleanCNAE(FrmLegalizacao.CNAESecundarioRichTextBox.Text)

        ' Aplica a formatação correta aos campos de CNAE
        FrmLegalizacao.CNAEPrincipalTextBox.Text = FormataCNAE(FrmLegalizacao.CNAEPrincipalTextBox.Text)
        FormatarCNAESecundarios()


    End Sub

    Private Function CleanText(text As String, Optional replaceQuotesWithComma As Boolean = False) As String
        ' Remove caracteres indesejados como \t e aspas
        Dim cleanedText As String = text.Replace("\t", "").Replace("""", If(replaceQuotesWithComma, ",", "")).Trim()
        Return cleanedText
    End Function

    Private Function CleanCNAE(cnae As String) As String
        ' Remove aspas, hifens, barras e tabs do CNAE
        Return cnae.Replace("""", "").Replace("-", "").Replace("\t", "").Replace(vbTab, "").Trim()
    End Function

    Private Function FormataCNAE(cnae As String) As String
        ' Remove quaisquer espaços ou caracteres invisíveis e garante que o CNAE tenha 7 dígitos
        cnae = cnae.Trim()

        ' Verifica se a string CNAE tem exatamente 7 dígitos e é numérica
        If cnae.Length = 7 AndAlso IsNumeric(cnae) Then
            ' Separar a string em partes e formatar corretamente
            Dim parte1 As String = cnae.Substring(0, 4) ' Primeiros 4 dígitos
            Dim parte2 As String = cnae.Substring(4, 1) ' Quinto dígito
            Dim parte3 As String = cnae.Substring(5, 2) ' Últimos 2 dígitos

            ' Retorna a string formatada no padrão XXXX-X/XX
            Return parte1 & "-"
        Else
            ' Retorna a string original caso não tenha o número correto de dígitos
            Return cnae
        End If

        ' Verifica se a string CNAE tem exatamente 7 dígitos e é numérica
        If cnae.Length = 7 AndAlso IsNumeric(cnae) Then
            ' Separar a string em partes e formatar corretamente
            Dim parte1 As String = cnae.Substring(0, 4) ' Primeiros 4 dígitos
            Dim parte2 As String = cnae.Substring(4, 1) ' Quinto dígito
            Dim parte3 As String = cnae.Substring(5, 2) ' Últimos 2 dígitos

            ' Retorna a string formatada no padrão XXXX-X/XX
            Return parte1 & "-" & parte2 & "/" & parte3
        Else
            ' Retorna a string original caso não tenha o número correto de dígitos
            Return cnae
        End If
    End Function



    Private Sub FormatarCNAESecundarios()
        ' Obtém todas as linhas do RichTextBox
        Dim linhas As String() = FrmLegalizacao.CNAESecundarioRichTextBox.Lines
        For i As Integer = 0 To linhas.Length - 1
            ' Limpa e formata cada linha se tiver 7 dígitos
            If Not String.IsNullOrWhiteSpace(linhas(i)) Then
                Dim cnaeLimpo As String = CleanCNAE(linhas(i).Trim())

                ' Verifica se a linha contém um CNAE válido e formata
                If cnaeLimpo.Length = 7 AndAlso IsNumeric(cnaeLimpo) Then
                    linhas(i) = FormataCNAE(cnaeLimpo)
                End If
            End If
        Next
        ' Atualiza o RichTextBox com as linhas formatadas
        FrmLegalizacao.CNAESecundarioRichTextBox.Lines = linhas
    End Sub


    '//////////////////////////////////////////////////////////////////


    '//////////////////////////////////// limpar




    '//////////////////////////////////// antigo ExtrairDadosCNPJ
    Private Async Function ExtrairDadosCNPJ() As Task(Of String)

        'INICIA A LEGALIZAÇÃO
        FrmLegalizacao.TabControle.SelectedIndex = 0
        FrmLegalizacao.TabControle.SelectedIndex = 1
        'TabControl2 3
        FrmLegalizacao.TabControl2.SelectedIndex = 0
        FrmLegalizacao.TabControl2.SelectedIndex = 1
        FrmLegalizacao.TabControl2.SelectedIndex = 2
        FrmLegalizacao.TabControl2.SelectedIndex = 3
        FrmLegalizacao.TabControl2.SelectedIndex = 4
        FrmLegalizacao.TabControl2.SelectedIndex = 5

        FrmLegalizacao.TabControle.SelectedIndex = 0
        FrmLegalizacao.TabControl2.SelectedIndex = 0
        'FIM

        Dim dados As String = ""

        Try
            ' Adiciona os campos que você quer extrair
            Dim xpaths As New Dictionary(Of String, String) From {
            {"Nome Empresarial", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[3]/tbody/tr/td/font[2]/b/text()"},
            {"CNPJ", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[2]/tbody/tr/td[1]/font[2]/b[1]"},
            {"Data de Abertura", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[2]/tbody/tr/td[3]/font[2]/b"},
            {"Título do Estabelecimento", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[4]/tbody/tr/td[1]/font[2]/b"},
            {"Porte", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[4]/tbody/tr/td[3]/font[2]/b"},
            {"Código e Descrição da Natureza Jurídica", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[7]/tbody/tr/td/font[2]/b"},
            {"Logradouro", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[8]/tbody/tr/td[1]/font[2]/b/text()"},
            {"Número", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[8]/tbody/tr/td[3]/font[2]/b"},
            {"Complemento", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[8]/tbody/tr/td[5]/font[2]/b"},
            {"CEP", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[9]/tbody/tr/td[1]/font[2]/b"},
            {"Bairro/Distrito", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[9]/tbody/tr/td[3]/font[2]/b"},
            {"Município", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[9]/tbody/tr/td[5]/font[2]/b"},
            {"UF", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[9]/tbody/tr/td[7]/font[2]/b"},
            {"Endereço Eletrônico", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[10]/tbody/tr/td[1]/font[2]/b/text()"},
            {"Telefone", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[10]/tbody/tr/td[3]/font[2]/b"},
            {"Situação Cadastral", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[12]/tbody/tr/td[1]/font[2]/b"},
            {"Data da Situação Cadastral", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[12]/tbody/tr/td[3]/font[2]/b"},
            {"Motivo de Situação Cadastral", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[12]/tbody/tr/td[5]/font[2]/b"}
        }

            ' Loop para processar os campos exceto CNAE e Ramo
            For Each item In xpaths
                Dim campo As String = item.Key
                Dim xpath As String = item.Value
                Dim valorExtraido As String = Await ExtrairValorPorXPath(xpath)
                valorExtraido = valorExtraido.Trim().Replace(vbTab, "").Replace("""", "").Trim()
                dados &= $"{campo}: {If(String.IsNullOrEmpty(valorExtraido) OrElse valorExtraido = "null", "Não encontrado", valorExtraido)}{Environment.NewLine}"

                ' Atualiza os campos do FrmLegalizacao diretamente
                AtualizarCamposFormulario(campo, valorExtraido)
            Next

            ' Chama as funções separadas para CNAE e Ramo
            Await ExtrairCNAEPrincipalAsync()
            Await ExtrairCNAESecundarioAsync()

        Catch ex As Exception
            dados = "Erro ao extrair dados: " & ex.Message
        End Try

        Return dados
    End Function

    '/////////////////////Função para Extrair o CNAE Principal

    Private Async Function ExtrairCNAEPrincipalAsync() As Task
        Dim xpathPrincipal As String = "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[5]/tbody/tr/td/font[2]/b"
        Dim valorCampo As String = Await ExtrairValorPorXPath(xpathPrincipal)

        ' Limpa os valores extraídos
        valorCampo = valorCampo.Trim().Replace(vbTab, "").Replace("""", "").Trim()

        ' Divide o valor por "-"
        Dim partes As String() = valorCampo.Split("-"c)

        ' Verifica se há pelo menos três partes, que indicam o formato esperado
        If partes.Length >= 3 Then
            'Limpa cnae 
            FrmLegalizacao.CNAEPrincipalTextBox.Clear()

            ' Concatena as partes correspondentes ao número do CNAE (antes dos três "-")
            Dim cnaePrincipal As String = $"{partes(0).Trim()}{partes(1).Trim()}-{partes(2).Trim()}" ' Concatena as primeiras partes
            cnaePrincipal = cnaePrincipal.Replace(".", "").Replace("-", "/") ' Remove os pontos e ajusta o formato

            ' Captura a descrição que vem após o terceiro "-"
            Dim descricaoPrincipal As String = valorCampo.Substring(valorCampo.IndexOf("-", valorCampo.IndexOf("-", valorCampo.IndexOf("-"c) + 1) + 1) + 1).Trim()

            ' Atualiza o TextBox de CNAE Principal
            FrmLegalizacao.CNAEPrincipalTextBox.Text = cnaePrincipal

            ' Atualiza o ramo de atividade com a descrição
            FrmLegalizacao.RamoDeAtividadeRichTextBox.AppendText($"{descricaoPrincipal}, ")
        End If
    End Function



    '////////////////////////////////Função para Extrair o CNAE Secundário
    Private Async Function ExtrairCNAESecundarioAsync() As Task
        Dim index As Integer = 2
        Dim maxTentativas As Integer = 100 ' Limite de tentativas para evitar loop infinito
        Dim tentativas As Integer = 0

        While tentativas < maxTentativas
            Dim atividadeXPath As String = $"/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[6]/tbody/tr/td/font[{index}]/b"
            Dim valor As String = Await ExtrairValorPorXPath(atividadeXPath)

            If String.IsNullOrEmpty(valor) Then
                Exit While ' Sai do loop se não houver mais valor
            End If

            ' Limpa e formata o valor extraído
            valor = valor.Trim().Replace(vbTab, "").Replace(vbCrLf, "").Replace(vbLf, "").Replace(vbCr, "").Replace("\t", "")

            ' Divide o valor em partes usando o "-"
            Dim partes As String() = valor.Split("-"c)

            ' Verifica se há pelo menos quatro partes para o formato correto
            If partes.Length >= 4 Then
                'Limpa cnae 
                FrmLegalizacao.CNAESecundarioRichTextBox.Clear()

                ' Captura os números do CNAE que vêm antes do terceiro "-"
                Dim cnae As String = $"{partes(0).Trim()}.{partes(1).Trim()}-{partes(2).Trim()}"
                cnae = cnae.Replace(".", "").Replace("-", "/") ' Formata o CNAE para "9999-9/99"

                ' Captura a descrição que vem após o terceiro "-"
                Dim descricao As String = String.Join("-", partes.Skip(3)).Trim()

                ' Atualiza o CNAESecundarioRichTextBox com o CNAE
                FrmLegalizacao.CNAESecundarioRichTextBox.AppendText($"{cnae}{Environment.NewLine}")

                ' Atualiza o RamoDeAtividadeRichTextBox com a descrição
                FrmLegalizacao.RamoDeAtividadeRichTextBox.AppendText($"{descricao}{Environment.NewLine}")
            End If

            index += 1 ' Incrementa o índice para a próxima tentativa
            tentativas += 1 ' Incrementa o contador de tentativas
        End While

        ' Verifica se foram encontradas atividades
        If index <= 2 Then
            FrmLegalizacao.CNAESecundarioRichTextBox.Text = "Nenhum CNAE secundário encontrado."
        End If
    End Function




    '////////////////////////////// Atualizar Campos Formulario


    Private Sub AtualizarCamposFormulario(campo As String, valor As String)
        ' Limpa caracteres indesejados
        valor = valor.Replace("\t", "").Replace("""", "").Trim()


        Select Case campo
            Case "CNPJ"
                ' Remove todos os caracteres que não são dígitos do valor atual no MaskedTextBox
                'Dim CNPJdoExtrair As String = System.Text.RegularExpressions.Regex.Replace(FrmLegalizacao.CNPJMaskedTextBox.Text, "[^\d]", "")
                Dim CNPJdoExtrair As String = FrmLegalizacao.CNPJMaskedTextBox.Text
                ' Verifica se o campo está vazio ou se contém menos de 14 dígitos (CNPJ incompleto)
                If String.IsNullOrEmpty(valor) OrElse CNPJdoExtrair.Length < 14 Then
                    ' Aqui você pode exibir uma mensagem de erro ou ajustar o campo como desejar
                    MessageBox.Show("CNPJ inválido ou incompleto. Por favor, insira um CNPJ válido." + valor)
                Else
                    'valor = System.Text.RegularExpressions.Regex.Replace(valor, "[^\d]", "")

                    ' Se o valor é válido, remove a máscara e define o valor no MaskedTextBox
                    FrmLegalizacao.CNPJMaskedTextBox.Text = valor
                End If

            Case "Nome Empresarial"
                FrmLegalizacao.RazaoSocialTextBox.Text = valor
            Case "Código e Descrição da Natureza Jurídica"
                FrmLegalizacao.NaturezaJuridicaComboBox.Text = valor
            Case "Data de Abertura"
                FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text = valor
            Case "Título do Estabelecimento"
                FrmLegalizacao.NomeFantasiaTextBox.Text = valor
            Case "Porte"
                FrmLegalizacao.PorteDaEmpresaComboBox.Text = valor
            Case "Situação Cadastral"
                FrmLegalizacao.SituacaoCadastralComboBox.Text = valor
            Case "Logradouro"
                FrmLegalizacao.EnderecoTextBox.Text = valor
            Case "Número"
                FrmLegalizacao.EndNumeroTextBox.Text = valor
            Case "Complemento"
                FrmLegalizacao.EndComplementoTextBox.Text = valor
            Case "Bairro/Distrito"
                FrmLegalizacao.EndBairroTextBox.Text = valor
            Case "Município"
                FrmLegalizacao.EndCidadeTextBox.Text = valor
            Case "UF"
                FrmLegalizacao.EndEstadoTextBox.Text = valor
            Case "CEP"
                FrmLegalizacao.EndCEPMaskedTextBox.Text = valor
            Case "Telefone"
                ' Verificar se há "/" entre os telefones
                Dim tel_1 As String = valor.Replace("-", "").Split("/"c)(0).Trim()
                Dim tel_2 As String = If(valor.Contains("/"), valor.Replace("-", "").Split("/"c)(1).Trim(), "")
                If tel_1 <> "(0000) 0000-0000" Then
                    FrmLegalizacao.EmpTel1TextBox.Text = tel_1
                End If
                If tel_2 <> "(0000) 0000-0000" Then
                    FrmLegalizacao.EmpTel2TextBox.Text = tel_2
                End If
            Case "Data da Situação Cadastral"
                FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text = valor
                ' Adicione mais casos conforme necessário
        End Select
        'Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text




    End Sub





    Private Async Function ExtrairValorPorXPath(xpath As String) As Task(Of String)
        ' Função para extrair um valor com base no XPath fornecido
        Dim script As String = $"var xpath = '{xpath}'; var result = document.evaluate(xpath, document, null, XPathResult.STRING_TYPE, null); result.stringValue;"
        Dim valor As String = Await WebView21.CoreWebView2.ExecuteScriptAsync(script)
        Return WebUtility.HtmlDecode(valor)
    End Function

    Private Sub FrmExtraiCNPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Código para inicialização, se necessário
        Try
            CNPJMaskedTextBox.Text = FrmLegalizacao.CNPJMaskedTextBox.Text
            Abrir()
        Catch ex As Exception
            MessageBox.Show("Abra o Formulário de Empresas")
        End Try
    End Sub

    Private Async Sub Abrir()
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        ' URL do site que você colocou na TextBox
        Dim url As String = SITETextBox.Text.Trim() + CNPJ

        Try
            ' Certifica-se de que o WebView2 está inicializado
            Await WebView21.EnsureCoreWebView2Async(Nothing)
            ' Navega para a URL
            WebView21.Source = New Uri(url)
        Catch ex As Exception
            MessageBox.Show("Erro ao navegar: " & ex.Message)
        End Try
    End Sub




    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Abrir()
    End Sub

    Private Sub LinkLabelImportar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelImportar.LinkClicked
        ' Verifica se o formulário FrmLegalizacao está aberto
        If Not IsFormOpen("FrmLegalizacao") Then
            MessageBox.Show("O formulário FrmLegalizacao está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            CNPJMaskedTextBox.Text = FrmLegalizacao.CNPJMaskedTextBox.Text
        End If
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub
End Class
