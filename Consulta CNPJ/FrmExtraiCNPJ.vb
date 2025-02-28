Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FrmExtraiCNPJ
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub AguardeMostrar()
        PictureBoxAguarde.Visible = True
    End Sub
    Private Sub AguardeEsconder()
        PictureBoxAguarde.Visible = False
    End Sub


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
            MessageBox.Show("O formulário Empresas está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            ' FrmLegalizacao.Visible = True
        End If

        ' Certifique-se de que o WebView está totalmente carregado
        If WebSite.CoreWebView2 IsNot Nothing Then

            AguardeMostrar()


            ' Dicionário contendo os XPaths utilizados para diferentes elementos da página
            Dim xpaths As New Dictionary(Of String, String) From {
            {"CNPJ", "/html/body/div[1]/div/div/div/div/div[2]/div/div/table[1]/tbody/tr/td/table[2]/tbody/tr/td[1]/font[2]/b[1]"}
        }

            ' Extrai o CNPJ da página usando o XPath do dicionário
            Dim scriptCNPJ As String = $"document.evaluate(""{xpaths("CNPJ")}"", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.textContent;"
            Dim cnpjExtraido As String = Await WebSite.CoreWebView2.ExecuteScriptAsync(scriptCNPJ)

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
                If WebSite.CoreWebView2 IsNot Nothing Then
                    Dim resultado As String = Await ExtrairDadosCNPJ()
                    '  RichTextBox1.Text = resultado

                    ' Chama o método para limpar e formatar os dados
                    LimparDados()

                    ' Arruma o CNAE Principal
                    FrmLegalizacao.ArrumaCNAEPrincipal()

                    ' Arruma o CNAE Secundário
                    FrmLegalizacao.ArrumaCNAESecundario()

                    AguardeEsconder()



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
        FrmLegalizacao.TabControle.SelectedIndex = -1
        FrmLegalizacao.TabControle.SelectedIndex = 1
        'TabControl2 3
        FrmLegalizacao.TabControl2.SelectedIndex = -1
        FrmLegalizacao.TabControl2.SelectedIndex = 1
        FrmLegalizacao.TabControl2.SelectedIndex = 2
        FrmLegalizacao.TabControl2.SelectedIndex = 3
        FrmLegalizacao.TabControl2.SelectedIndex = 4
        FrmLegalizacao.TabControl2.SelectedIndex = 5

        FrmLegalizacao.TabControle.SelectedIndex = -1
        FrmLegalizacao.TabControl2.SelectedIndex = -1
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

        FrmLegalizacao.EndCidadeTextBox.Text = ObterNomeCorretoCidade(FrmLegalizacao.EndCidadeTextBox.Text)
        'Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text

    End Sub





    Private Async Function ExtrairValorPorXPath(xpath As String) As Task(Of String)
        ' Função para extrair um valor com base no XPath fornecido
        Dim script As String = $"var xpath = '{xpath}'; var result = document.evaluate(xpath, document, null, XPathResult.STRING_TYPE, null); result.stringValue;"
        Dim valor As String = Await WebSite.CoreWebView2.ExecuteScriptAsync(script)
        Return WebUtility.HtmlDecode(valor)
    End Function

    Private Sub FrmExtraiCNPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Código para inicialização, se necessário
        Try


            AguardeEsconder()

            ' Verifica se os formulários FrmLegalizacao, FrmParcelamento ou FrmAlvara estão abertos
            If Not IsSpecificFormOpen("FrmLegalizacao") AndAlso Not IsSpecificFormOpen("FrmParcelamento") AndAlso Not IsSpecificFormOpen("FrmAlvara") Then
                MessageBox.Show("Nenhum dos formulários (Empresa, Parcelamento ou Alvará) está aberto. Por favor, digite o CNPJ e clique CONSULTAR.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Exit Sub
            Else
                ' Usar o CNPJ do formulário aberto
                If IsSpecificFormOpen("FrmLegalizacao") Then
                    CNPJMaskedTextBox.Text = CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao).CNPJMaskedTextBox.Text
                ElseIf IsSpecificFormOpen("FrmParcelamento") Then
                    CNPJMaskedTextBox.Text = CType(Application.OpenForms("FrmParcelamento"), FrmParcelamento).CNPJMaskedTextBox.Text
                ElseIf IsSpecificFormOpen("FrmAlvara") Then
                    CNPJMaskedTextBox.Text = CType(Application.OpenForms("FrmAlvara"), FrmAlvara).CNPJMaskedTextBox.Text
                End If
            End If




            Abrir()
            InitializeWebViewEvents()
        Catch ex As Exception
            MessageBox.Show("Abra o Formulário de Empresas")
        End Try
    End Sub

    Private Async Sub Abrir()
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        ' URL do site que você colocou na TextBox
        Dim url As String = "https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?cnpj="

        Dim SiteFinal As String = url + CNPJ

        Try
            ' Certifica-se de que o WebView2 está inicializado
            Await WebSite.EnsureCoreWebView2Async(Nothing)
            ' Navega para a URL
            SITETextBox.Text = SiteFinal
            WebSite.Source = New Uri(SiteFinal)
        Catch ex As Exception
            MessageBox.Show("Erro ao navegar: " & ex.Message)
        End Try
    End Sub




    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Abrir()
    End Sub

    Private Sub LinkLabelImportar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelImportar.LinkClicked
        ' Verifica se os formulários FrmLegalizacao, FrmParcelamento ou FrmAlvara estão abertos
        If Not IsSpecificFormOpen("FrmLegalizacao") AndAlso Not IsSpecificFormOpen("FrmParcelamento") AndAlso Not IsSpecificFormOpen("FrmAlvara") Then
            MessageBox.Show("Nenhum dos formulários (Legalização, Parcelamento ou Alvará) está aberto. Por favor, abra um deles para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Usar o CNPJ do formulário aberto
        If IsSpecificFormOpen("FrmLegalizacao") Then
            CNPJMaskedTextBox.Text = CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao).CNPJMaskedTextBox.Text
        ElseIf IsSpecificFormOpen("FrmParcelamento") Then
            CNPJMaskedTextBox.Text = CType(Application.OpenForms("FrmParcelamento"), FrmParcelamento).CNPJMaskedTextBox.Text
        ElseIf IsSpecificFormOpen("FrmAlvara") Then
            CNPJMaskedTextBox.Text = CType(Application.OpenForms("FrmAlvara"), FrmAlvara).CNPJMaskedTextBox.Text
        End If
    End Sub


    ' Função para verificar se um formulário específico está aberto
    Private Function IsSpecificFormOpen(formName As String) As Boolean
        Return Application.OpenForms.OfType(Of Form)().Any(Function(f) f.Name = formName)
    End Function



    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub BtnAbrirExterno_Click(sender As Object, e As EventArgs) Handles BtnAbrirExterno.Click
        Dim CNPJ As String = String.Empty

        ' Verifica se o CNPJ do formulário atual está vazio
        If Not String.IsNullOrWhiteSpace(CNPJMaskedTextBox.Text) Then
            CNPJ = CNPJMaskedTextBox.Text
        Else
            ' Verifica se o formulário FrmLegalizacao está aberto
            If Application.OpenForms.OfType(Of FrmLegalizacao)().Any() Then
                CNPJ = FrmLegalizacao.CNPJMaskedTextBox.Text
                ' Verifica se o formulário FrmParcelamento está aberto
            ElseIf Application.OpenForms.OfType(Of FrmParcelamento)().Any() Then
                CNPJ = FrmParcelamento.CNPJMaskedTextBox.Text
            End If
        End If

        ' Se nenhum CNPJ foi encontrado, avisa o usuário
        If String.IsNullOrWhiteSpace(CNPJ) Then
            MessageBox.Show("Nenhum CNPJ encontrado nos formulários abertos. Por favor, preencha um CNPJ para continuar.", "CNPJ Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Remove caracteres indesejados do CNPJ
        Dim CNPJFormatado As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        ' Copia o CNPJ formatado para a área de transferência
        Clipboard.SetText(CNPJFormatado)

        ' Abre o site com o CNPJ
        Try
            System.Diagnostics.Process.Start("https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp?cnpj=" + CNPJFormatado)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao tentar abrir o site: " & ex.Message, "Erro ao Abrir Site", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Fecha o formulário atual
        Me.Close()
    End Sub

    Private Sub BtnAbrirInterno_Click(sender As Object, e As EventArgs) Handles BtnAbrirInterno.Click
        Dim CNPJ As String = String.Empty

        ' Verifica se ambos os formulários estão abertos
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Any() AndAlso Application.OpenForms.OfType(Of FrmParcelamento)().Any() Then
            MessageBox.Show("Ambos os formulários (Legalização e Parcelamento) estão abertos. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Tenta obter o CNPJ do formulário atual
        If Not String.IsNullOrWhiteSpace(CNPJMaskedTextBox.Text) Then
            CNPJ = CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
        ElseIf Application.OpenForms.OfType(Of FrmLegalizacao)().Any() Then
            ' Caso o formulário FrmLegalizacao esteja aberto
            CNPJ = FrmLegalizacao.CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
        ElseIf Application.OpenForms.OfType(Of FrmParcelamento)().Any() Then
            ' Caso o formulário FrmParcelamento esteja aberto
            CNPJ = FrmParcelamento.CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")
        End If

        ' Se o CNPJ não foi encontrado, exibe uma mensagem
        If String.IsNullOrWhiteSpace(CNPJ) Then
            MessageBox.Show("Nenhum CNPJ encontrado nos formulários abertos. Por favor, preencha um CNPJ para continuar.", "CNPJ Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Verifica se o WebSiteGERAL já está aberto
        If Application.OpenForms.OfType(Of WebSiteGERAL)().Any() Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp?cnpj=" + CNPJ)
            Me.Close()
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp?cnpj=" + CNPJ)
            Me.Close()
        End If
    End Sub

    Private Async Sub BtnImportarAlternativo_Click(sender As Object, e As EventArgs) Handles BtnImportarAlternativo.Click
        Try
            ' Verificar se ambos os formulários estão abertos
            If Application.OpenForms.OfType(Of FrmLegalizacao)().Any() AndAlso Application.OpenForms.OfType(Of FrmParcelamento)().Any() Then
                MessageBox.Show("Ambos os formulários (Legalização e Parcelamento) estão abertos. Não é possível continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            If Application.OpenForms().OfType(Of FrmLegalizacao)().Any() Then
                ' O FrmLegalizacao está aberto, continue com o código para FrmLegalizacao
                Dim frmLegalizacao As FrmLegalizacao = Application.OpenForms.OfType(Of FrmLegalizacao)().First()

                '////////////////////////////////////////////////////////////
                ' Verifica se o formulário FrmLegalizacao está aberto
                If Not IsFormOpen("FrmLegalizacao") Then
                    MessageBox.Show("O formulário FrmLegalizacao está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    frmLegalizacao.Visible = True
                End If


                If frmLegalizacao.CNPJMaskedTextBox.Text = "" Then
                    ' mensagme vazio CNPJ
                    MessageBox.Show("O campo CNPJ esta vazio, nao sendo possivel continuar!", "CNPJ não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                ElseIf Len(frmLegalizacao.CNPJMaskedTextBox.Text.Replace(".", "").Replace("/", "").Replace("-", "")) < 14 Then
                    ' Mensagem de CNPJ incompleto
                    MessageBox.Show("O CNPJ informado está incompleto. Verifique e preencha corretamente.", "CNPJ incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    AguardeMostrar()

                    ' Chamar o método de verificação
                    VerificarCNPJEmpresas(frmLegalizacao.CNPJMaskedTextBox.Text)


                    'pergunta se deseja importar o CNPJ
                    Dim result As DialogResult = MessageBox.Show("Deseja importar dados cadastrais do CNPJ? Isto irá sobrepor os dados existentes...", "Importar CNPJ", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        'mudar lavel para AGUARDE...
                        AguardeMostrar()

                        'pegar CNPJ
                        'FrmLegalizacao.CNPJMaskedTextBox.Text
                        'consulta https://www.receitaws.com.br/v1/cnpj/
                        Dim CNPJ As String = frmLegalizacao.CNPJMaskedTextBox.Text
                        Dim CNPJ_Limpo As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

                        'conectar no site https://www.receitaws.com.br/v1/cnpj/
                        Dim client As New HttpClient
                        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                        Dim response As HttpResponseMessage = Await client.GetAsync("https://www.receitaws.com.br/v1/cnpj/" + CNPJ_Limpo)
                        Dim json As String = Await response.Content.ReadAsStringAsync
                        'nome, natureza_juridica, data_abertura,fantasia,porte,logradouro,numero,complemento,bairro,municipio,uf,cep,telefone,email,capital_social,atividade_principal,atividades_secundarias
                        Dim json_obj As JObject = JObject.Parse(json)

                        ' Verifica se a resposta é bem-sucedida
                        If Not response.IsSuccessStatusCode Then
                            MessageBox.Show("Erro ao acessar o serviço da Receita Federal. Código de status: " & response.StatusCode.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            AguardeEsconder()
                            Exit Sub
                        End If

                        'se der erro no Nome finaliza o sub
                        If json_obj("nome") Is Nothing Then
                            MessageBox.Show("CNPJ não encontrado no site da Receita Federal...", "CNPJ não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            AguardeEsconder()
                            Exit Sub
                        End If

                        '/////// PROCESSO IMPORTACAO
                        Dim nome As String = json_obj.Item("nome").ToString

                        Dim natureza_juridica As String = json_obj.Item("natureza_juridica").ToString
                        Dim data_abertura As String = json_obj.Item("abertura").ToString
                        Dim fantasia As String = json_obj.Item("fantasia").ToString
                        Dim porte As String = json_obj.Item("porte").ToString
                        'verificar se for MICRO EMPRESA mudar para Microempresa
                        If porte = "MICRO EMPRESA" Then
                            porte = "Microempresa"
                        End If
                        'Situação cadastral	
                        Dim situacao_cadastral As String = json_obj.Item("situacao").ToString
                        Dim logradouro As String = json_obj.Item("logradouro").ToString
                        Dim numero As String = json_obj.Item("numero").ToString
                        Dim complemento As String = json_obj.Item("complemento").ToString
                        Dim bairro As String = json_obj.Item("bairro").ToString
                        Dim municipio As String = json_obj.Item("municipio").ToString 'antigo
                        Dim uf As String = json_obj.Item("uf").ToString
                        Dim cep As String = json_obj.Item("cep").ToString

                        Dim telefone As String = json_obj.Item("telefone").ToString

                        Dim email As String = json_obj.Item("email").ToString
                        Dim capital_social As String = json_obj.Item("capital_social").ToString
                        Dim capital_social_str As String = capital_social.Replace(".", ",")
                        Dim capital_social_str_2 As String = capital_social_str.Replace("R$", "")


                        Dim DataAtualizacao As String = json_obj.Item("ultima_atualizacao").ToString

                        '//////////////////////////////// ATIVIDADE PRINCIPAL ///////////////////////////////////////

                        ' "atividade_principal" object Atividade Principal
                        ' code String Código da atividade principal
                        ' text String Descrição da atividade principal
                        ''Newtonsoft.Json.Linq.JArray'
                        Dim atividade_principal As Newtonsoft.Json.Linq.JArray = json_obj.Item("atividade_principal")
                        Dim atividade_principal_code As String = atividade_principal(0).Item("code").ToString
                        Dim atividade_principal_text As String = atividade_principal(0).Item("text").ToString




                        '//////////////////////////////// ATIVIDADE SECUNDÁRIA ///////////////////////////////////////
                        ' "atividades_secundarias" object Atividades Secundárias
                        ' code String Código da atividade secundária
                        ' text String Descrição da atividade secundária
                        ''Newtonsoft.Json.Linq.JArray'
                        ''se tiver vazio array
                        Dim atividades_secundarias As Newtonsoft.Json.Linq.JArray = json_obj.Item("atividades_secundarias")
                        Dim atividades_secundarias_code As String = ""
                        Dim atividades_secundarias_text As String = ""

                        If atividades_secundarias.Count > 0 Then
                            atividades_secundarias_code = atividades_secundarias(0).Item("code").ToString.ToString.Replace("-", "").Replace(".", "").Insert(4, "-").Insert(6, "/")
                            atividades_secundarias_text = atividades_secundarias(0).Item("text").ToString

                            'pegar todas as atividades secundárias texto e código
                            For i = 1 To atividades_secundarias.Count - 1
                                'NOVA LINHA atividades_secundarias_code = atividades_secundarias_code + vbCrLf + atividades_secundarias(i).Item("code").ToString
                                ' atividades_secundarias_text = atividades_secundarias_text + vbNewLine + atividades_secundarias(i).Item("text").ToString
                                '  'apenas numeros e mudar formato para 9999-9/99
                                atividades_secundarias_code = atividades_secundarias_code + vbNewLine + atividades_secundarias(i).Item("code").ToString.Replace("-", "").Replace(".", "").Insert(4, "-").Insert(6, "/")
                                atividades_secundarias_text = atividades_secundarias_text + vbNewLine + atividades_secundarias(i).Item("text").ToString
                                'para cada CODE colocar no formato 9999-9/99
                                ' atividades_secundarias_code = atividades_secundarias_code.Replace("-", "").Replace(".", "")
                                'atividades_secundarias_code = atividades_secundarias_code.Insert(4, "-").Insert(6, "/")

                            Next

                        End If

                        '////// FIM DO CODIGO DO CNAE ///////




                        '//////////////////////////////////   IMPORTAÇÂO  ///////////////////////////////////////

                        'INICIA A LEGALIZAÇÃO
                        frmLegalizacao.TabControle.SelectedIndex = -1
                        frmLegalizacao.TabControle.SelectedIndex = 1
                        'TabControl2 3
                        frmLegalizacao.TabControl2.SelectedIndex = -1
                        frmLegalizacao.TabControl2.SelectedIndex = 1
                        frmLegalizacao.TabControl2.SelectedIndex = 2
                        frmLegalizacao.TabControl2.SelectedIndex = 3
                        frmLegalizacao.TabControl2.SelectedIndex = 4
                        frmLegalizacao.TabControl2.SelectedIndex = 5
                        frmLegalizacao.TabControl2.SelectedIndex = 6

                        frmLegalizacao.TabControle.SelectedIndex = -1
                        frmLegalizacao.TabControl2.SelectedIndex = -1
                        'FIM




                        'atualizar campos do formulario
                        frmLegalizacao.RazaoSocialTextBox.Text = nome
                        frmLegalizacao.NaturezaJuridicaComboBox.Text = natureza_juridica
                        frmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text = data_abertura
                        frmLegalizacao.NomeFantasiaTextBox.Text = fantasia
                        frmLegalizacao.PorteDaEmpresaComboBox.Text = porte
                        frmLegalizacao.SituacaoCadastralComboBox.Text = situacao_cadastral


                        'ENDEREÇo //////////////////////////////////////////////////


                        frmLegalizacao.EnderecoTextBox.Text = logradouro
                        frmLegalizacao.EndNumeroTextBox.Text = numero
                        frmLegalizacao.EndComplementoTextBox.Text = complemento
                        frmLegalizacao.EndBairroTextBox.Text = bairro
                        '////////////  INICIO arruma cidade
                        frmLegalizacao.EndCidadeTextBox.Text = municipio
                        ' Passa o valor da cidade para a função de correção
                        frmLegalizacao.EndCidadeTextBox.Text = ObterNomeCorretoCidade(frmLegalizacao.EndCidadeTextBox.Text)

                        '////////////  FIM arruma cidade
                        frmLegalizacao.EndEstadoTextBox.Text = uf
                        frmLegalizacao.EndCEPMaskedTextBox.Text = cep

                        'TELEFONE E EMAIL //////////////////////////////////////////////////

                        'verificar se tem "/" entre os telefones, e dividir em dois campos EmpTel1TextBox e EmpTel2TextBox
                        'formato (44) 3035-0111/ (44) 3035-0111

                        Dim tel_1 As String = telefone.Replace("-", "")
                        Dim tel_2 As String = ""
                        If telefone.Contains("/") Then
                            tel_1 = telefone.Split("/")(0)
                            tel_2 = telefone.Split("/ ")(1)
                        End If
                        'ignorar tel_1 e tel_2 for = "(0000) 0000-0000"
                        If tel_1 <> "(0000) 0000-0000" Then
                            frmLegalizacao.EmpTel1TextBox.Text = tel_1
                        End If
                        If tel_2 <> "(0000) 0000-0000" Then
                            frmLegalizacao.EmpTel2TextBox.Text = tel_2.TrimStart(" ")
                        End If

                        'FrmLegalizacao.EmpTel1TextBox.Text = tel_1
                        ' FrmLegalizacao.EmpTel2TextBox.Text = tel_2.TrimStart(" ")


                        'EMAIL //////////////////////////////////////////////////
                        frmLegalizacao.EmpEmailTextBox.Text = email

                        'CAPITAL SOCIAL //////////////////////////////////////////////////

                        frmLegalizacao.TabControl2.SelectedIndex = 5
                        frmLegalizacao.CapitalSTextBox.Text = capital_social_str_2


                        'RAMO DE ATIVIDADE //////////////////////////////////////////////////

                        'CNAEPrincipalTextBox e CNAESecundarioRichTextBox

                        'atividade_principal_code_str apenas numeros
                        Dim atividade_principal_code_str As String = atividade_principal_code.Replace(".", "")
                        Dim atividade_principal_code_str_2 As String = atividade_principal_code_str.Replace("-", "")

                        'atividade_principal_code_str_2 0000000 para formato 9999-9/99
                        Dim atividade_principal_code_str_3 As String = atividade_principal_code_str_2.Insert(4, "-")
                        Dim atividade_principal_code_str_4 As String = atividade_principal_code_str_3.Insert(6, "/")
                        frmLegalizacao.CNAEPrincipalTextBox.Text = atividade_principal_code_str_4

                        'Atividade secundaria FrmLegalizacao.CNAESecundarioRichTextBox.Text CODE
                        frmLegalizacao.CNAESecundarioRichTextBox.Text = atividades_secundarias_code





                        'verificar se tem texto dentro RamoDeAtividadeRichTextBox, se nao tiver, preencher com atividade_principal_text + atividades_secundarias_text
                        If frmLegalizacao.RamoDeAtividadeRichTextBox.Text = "" Then
                            frmLegalizacao.RamoDeAtividadeRichTextBox.Text = atividade_principal_text + "; " + vbCrLf + atividades_secundarias_text + "; " + vbCrLf
                        End If


                        'FINALIZAR //////////////////////////////////////////////////

                        frmLegalizacao.TabControl2.SelectedIndex = 1
                        frmLegalizacao.TabControl1.SelectedIndex = 4

                        AguardeEsconder()


                        'mostrar mgs de sucesso
                        MsgBox("Importação realizada com sucesso! Ultima atualização em:" & DataAtualizacao, MsgBoxStyle.Information, "Importação")
                        'fechar formulario
                        Me.Close()
                    End If
                End If

            ElseIf Application.OpenForms().OfType(Of FrmParcelamento)().Any() Then
                ' O FrmParcelamento está aberto, faça algo diferente
                If FrmParcelamento.CNPJMaskedTextBox.Text = "" Then
                    ' Mensagem para campo CNPJ vazio
                    MessageBox.Show("O campo CNPJ está vazio, não sendo possível continuar!", "CNPJ não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf Len(FrmParcelamento.CNPJMaskedTextBox.Text.Replace(".", "").Replace("/", "").Replace("-", "")) < 14 Then
                    ' Mensagem de CNPJ incompleto
                    MessageBox.Show("O CNPJ informado está incompleto. Verifique e preencha corretamente.", "CNPJ incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    ' Chamar o método de verificação
                    VerificarCNPJEmpresas(FrmParcelamento.CNPJMaskedTextBox.Text)

                    ' Pergunta se deseja importar o CNPJ
                    Dim result As DialogResult = MessageBox.Show("Deseja importar dados cadastrais do CNPJ? Isto irá sobrepor os dados existentes...", "Importar CNPJ", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        ' Alterar texto do botão para "AGUARDE..."
                        AguardeMostrar()

                        ' Capturar o CNPJ e limpar formatação
                        Dim CNPJ As String = FrmParcelamento.CNPJMaskedTextBox.Text
                        Dim CNPJ_Limpo As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

                        ' Conectar ao serviço da Receita Federal
                        Dim client As New HttpClient
                        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                        Dim response As HttpResponseMessage = Await client.GetAsync("https://www.receitaws.com.br/v1/cnpj/" + CNPJ_Limpo)
                        Dim json As String = Await response.Content.ReadAsStringAsync
                        Dim json_obj As JObject = JObject.Parse(json)

                        ' Verifica se a resposta é bem-sucedida
                        If Not response.IsSuccessStatusCode Then
                            MessageBox.Show("Erro ao acessar o serviço da Receita Federal. Código de status: " & response.StatusCode.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            AguardeEsconder()
                            Exit Sub
                        End If

                        ' Se der erro no nome, finaliza o processo
                        If json_obj("nome") Is Nothing Then
                            MessageBox.Show("CNPJ não encontrado no site da Receita Federal...", "CNPJ não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            AguardeEsconder()
                            Exit Sub
                        End If

                        AguardeMostrar()

                        ' Processo de importação
                        Dim nome As String = json_obj.Item("nome").ToString()
                        FrmParcelamento.RazaoSocialTextBox.Text = nome
                        FrmParcelamento.CNPJMaskedTextBox.Text = CNPJ

                        ' Mensagem de sucesso
                        MessageBox.Show("Dados importados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                End If


            Else
                ' Nenhum dos dois formulários está aberto, faça algo ou abra um deles
                MessageBox.Show("Nenhum formulário está aberto.")
            End If
        Catch ex As HttpRequestException
            MessageBox.Show("Erro de conexão ao acessar a API: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As JsonReaderException
            MessageBox.Show("Erro ao processar os dados retornados pela API: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erro inesperado: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Private Function ObterNomeCorretoCidade(ByVal nomeCidade As String) As String
        Dim CidadeCorreta As String = nomeCidade ' Retorna o próprio nome caso não encontre

        ' Criar a conexão com o SQL Server
        Using conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False")
            Try
                conexao.Open()

                ' Consulta SQL para buscar o nome correto da cidade na tabela BrasilMunicipios,
                ' usando collation acento-insensível (Latin1_General_CI_AI)
                Dim sql As String = "SELECT Nome FROM BrasilMunicipios WHERE Nome COLLATE Latin1_General_CI_AI LIKE @Cidade ORDER BY LEN(Nome) ASC"

                Using cmd As New SqlCommand(sql, conexao)
                    cmd.Parameters.AddWithValue("@Cidade", "%" & nomeCidade & "%")

                    Dim resultado As Object = cmd.ExecuteScalar()
                    If resultado IsNot Nothing Then
                        CidadeCorreta = resultado.ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao buscar nome da cidade: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Exibir mensagem com a cidade encontrada
        MessageBox.Show("A empresa é da cidade de: " & CidadeCorreta, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Return CidadeCorreta
    End Function






    '//////////////////////////////
    Private Sub VerificarCNPJEmpresas(cnpj As String)
        ' O CNPJ está no formato já formatado com máscara
        Dim cnpjFormatado As String = cnpj

        ' Verifica se o formulário está aberto
        If Not (IsFormOpen("FrmLegalizacao") OrElse IsFormOpen("FrmAlvara") OrElse IsFormOpen("FrmParcelamento")) Then
            MessageBox.Show("Nenhum dos formulários necessários (Legalização, Alvara ou Parcelamento) está aberto. Por favor, abra um deles para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Conexão com o banco de dados
        Using connection As New SqlConnection(str)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando CNPJ: " & cnpjFormatado)

                ' Consultar o CNPJ na tabela "Empresas"
                Dim query As String = "SELECT CNPJ FROM Empresas WHERE CNPJ = @CNPJ"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                    ' Executa a consulta e captura o valor retornado
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        ' Log do resultado encontrado
                        Debug.WriteLine("CNPJ encontrado na tabela Empresas: " & cnpjFormatado)

                        ' Se o CNPJ estiver cadastrado, buscar a razão social
                        Dim queryRazaoSocial As String = "SELECT RazaoSocial FROM Empresas WHERE CNPJ = @CNPJ"
                        Using cmdRazaoSocial As New SqlCommand(queryRazaoSocial, connection)
                            cmdRazaoSocial.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                            ' Executa a consulta para buscar a Razão Social
                            Dim razaoSocial As String = Convert.ToString(cmdRazaoSocial.ExecuteScalar())
                            MessageBox.Show("Empresa já cadastrada na tabela Empresas!" & vbCrLf & "CNPJ: " & cnpjFormatado & vbCrLf & "Razão Social: " & razaoSocial)
                        End Using
                        Exit Sub
                    Else
                        MessageBox.Show("CNPJ não cadastrado na tabela Empresas.")
                    End If
                End Using

                ' Consultar o CNPJ na tabela "Parcelamentos"
                query = "SELECT CNPJ FROM Parcelamentos WHERE CNPJ = @CNPJ"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                    ' Executa a consulta e captura o valor retornado
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        ' Log do resultado encontrado
                        Debug.WriteLine("CNPJ encontrado na tabela Parcelamentos: " & cnpjFormatado)

                        ' Se o CNPJ estiver cadastrado, buscar a razão social
                        Dim queryRazaoSocial As String = "SELECT RazaoSocial FROM Parcelamentos WHERE CNPJ = @CNPJ"
                        Using cmdRazaoSocial As New SqlCommand(queryRazaoSocial, connection)
                            cmdRazaoSocial.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                            ' Executa a consulta para buscar a Razão Social
                            Dim razaoSocial As String = Convert.ToString(cmdRazaoSocial.ExecuteScalar())
                            MessageBox.Show("CNPJ encontrado na tabela Parcelamentos!" & vbCrLf & "CNPJ: " & cnpjFormatado & vbCrLf & "Razão Social: " & razaoSocial)
                        End Using
                    Else
                        MessageBox.Show("CNPJ não cadastrado na tabela Parcelamentos.")
                    End If
                End Using

                ' Consultar o CNPJ na tabela "Laudos"
                query = "SELECT CNPJ FROM Laudos WHERE CNPJ = @CNPJ"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                    ' Executa a consulta e captura o valor retornado
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        ' Log do resultado encontrado
                        Debug.WriteLine("CNPJ encontrado na tabela Laudos: " & cnpjFormatado)

                        ' Se o CNPJ estiver cadastrado, buscar a razão social
                        Dim queryRazaoSocial As String = "SELECT RazaoSocial FROM Laudos WHERE CNPJ = @CNPJ"
                        Using cmdRazaoSocial As New SqlCommand(queryRazaoSocial, connection)
                            cmdRazaoSocial.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                            ' Executa a consulta para buscar a Razão Social
                            Dim razaoSocial As String = Convert.ToString(cmdRazaoSocial.ExecuteScalar())
                            MessageBox.Show("CNPJ encontrado na tabela Laudos!" & vbCrLf & "CNPJ: " & cnpjFormatado & vbCrLf & "Razão Social: " & razaoSocial)
                        End Using
                    Else
                        MessageBox.Show("CNPJ não cadastrado na tabela Laudos.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LinkCadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCadastro.LinkClicked
        ' Verifica se o formulário FrmLegalizacao já está aberto
        If Not IsSpecificFormOpen("FrmLegalizacao") Then
            ' Se o formulário não estiver aberto, abre-o
            Dim frmLegalizacao As New FrmLegalizacao()
            frmLegalizacao.Show()

            ' Aguarda o formulário ser carregado, então clica no botão BtnNovo
            AddHandler frmLegalizacao.Load, Sub()
                                                frmLegalizacao.BtnNovo.PerformClick()
                                            End Sub
        Else
            ' Se o formulário já estiver aberto, apenas foca nele
            Application.OpenForms("FrmLegalizacao").Activate()
        End If
    End Sub


    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        If WebSite IsNot Nothing AndAlso WebSite.CanGoBack Then
            WebSite.GoBack()
        End If
    End Sub

    Private Sub BtnAvancar_Click(sender As Object, e As EventArgs) Handles BtnAvancar.Click
        If WebSite IsNot Nothing AndAlso WebSite.CanGoForward Then
            WebSite.GoForward()
        End If
    End Sub

    Private Sub BtnIR_Click(sender As Object, e As EventArgs) Handles BtnIR.Click
        WebsiteNavigate(SITETextBox.Text)
        'atualizar pagina
        ' WebView.Refresh()
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        Try
            ' Tentar atualizar a página
            WebSite?.Reload()
        Catch ex As Exception
            ' Se ocorrer um erro, não fazer nada para evitar página em branco ou outros imprevistos
            ' Você pode adicionar um log ou mensagem aqui, se necessário, para registrar o erro
        End Try
    End Sub

    Friend Sub WebsiteNavigate(ByVal dest As String)
        If WebSite IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(dest) Then
            Try
                ' Se contiver espaço, considera uma pesquisa no Google
                If dest.Contains(" ") Then
                    dest = "https://www.google.com.br/search?q=" + dest.Replace(" ", "+")
                ElseIf dest.Contains(".") Then
                    ' Se não começar com "http://" ou "https://", adicionar "https://"
                    If Not dest.StartsWith("http://") AndAlso
                   Not dest.StartsWith("https://") AndAlso
                   Not dest.StartsWith("edge://") AndAlso
                   Not dest.StartsWith("file://") AndAlso
                   Not dest = "about:blank" Then

                        dest = "https://" & dest
                    End If
                Else
                    ' Qualquer outro caso, realizar pesquisa no Google
                    dest = "https://www.google.com.br/search?q=" + dest.Replace(" ", "+")
                End If

                ' Validar e criar a URI
                Dim uriResult As Uri = Nothing
                If Uri.TryCreate(dest, UriKind.Absolute, uriResult) AndAlso (uriResult.Scheme = Uri.UriSchemeHttp OrElse uriResult.Scheme = Uri.UriSchemeHttps) Then
                    WebSite.Source = uriResult
                Else
                    MessageBox.Show("A URL informada não é válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                ' Atualizar barra de endereços
                UpdateAddressBar()
            Catch ex As Exception
                MessageBox.Show($"Erro ao navegar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("O endereço informado está vazio ou é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateAddressBar()
        'if necessary, update address bar
        If SITETextBox.Text <> WebSite.Source.ToString() Then
            SITETextBox.Text = WebSite.Source.ToString()

            'move cursor to end of text
            SITETextBox.SelectionStart = SITETextBox.Text.Length
            SITETextBox.SelectionLength = 0
        End If
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Try
            'ler o txt e pegar o site inicial que está na frente "pagina_inicial:" do txt
            Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
            Dim sr As New StreamReader(path)
            Dim line As String = sr.ReadLine()
            Dim site As String = ""
            While line IsNot Nothing
                If line.Contains("pagina_inicial:") Then
                    site = line.Replace("pagina_inicial:", "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()
            WebsiteNavigate(site)

        Catch ex As Exception
            'abrir o site do google no lugar
            WebsiteNavigate("https://www.google.com.br/")
        End Try

    End Sub

    Private Sub BtnSoltar_Click(sender As Object, e As EventArgs) Handles BtnSoltar.Click
        'verificar se está maximizado
        If Me.WindowState = FormWindowState.Maximized Then
            AbrirFora()
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Normal Then
            AbrirFora()
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub AbrirFora()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BtnParar_Click(sender As Object, e As EventArgs) Handles BtnParar.Click
        Try
            ' Interrompe o carregamento do site no controle WebView
            WebSite.Stop()
        Catch ex As Exception
            ' Tratamento de erro caso algo inesperado aconteça
            MessageBox.Show($"Erro ao tentar parar o carregamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub WebView_NavigationStarting_1(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles WebSite.NavigationStarting
        ProgressBar1.Visible = True
        TxtCarregamento.Visible = True
        TxtCarregamento.Text = "Carregando..."

        'mostrar ProgressBar1 colorido
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1
    End Sub


    Private Sub InitializeWebViewEvents()
        If WebSite IsNot Nothing Then
            ' Adicione um manipulador ao evento NavigationCompleted
            AddHandler WebSite.NavigationCompleted, AddressOf WebSite_NavigationCompleted
        End If
    End Sub

    Private Sub WebSite_NavigationCompleted(sender As Object, e As EventArgs)
        Try

            LogMsg("WebView_NavigationCompleted")
            'mostrar barra de progresso e mudar LblStatusCarregamento
            ProgressBar1.Visible = False
            TxtCarregamento.Visible = True
            TxtCarregamento.Text = "Carregamento Completo"

            ' Atualiza o SITETextBox com a URL atual
            If WebSite.Source IsNot Nothing Then
                SITETextBox.Text = WebSite.Source.AbsoluteUri
            End If
        Catch ex As Exception
            MessageBox.Show($"Erro ao atualizar o endereço: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LogMsg(msg As String, Optional addTimestamp As Boolean = True)
        'ToDo: add desired code

        If addTimestamp Then
            msg = String.Format("{0} - {1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), msg)
        End If

        Debug.WriteLine(msg)
    End Sub


End Class
