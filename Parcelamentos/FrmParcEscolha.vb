Public Class FrmParcEscolha
    ' Propriedades para receber dados do FrmParcelamento
    Public Property DadosProt As String
    Public Property DadosTotal As String
    Public Property DadosParcelamento As String
    Public Property ParcelaEnviada As String
    Public Property DataEnviado As String
    Public Property FormaDeEnvio As String
    ' Evento de carregamento do formulário

    ' Variável para rastrear o estado atual da cor
    Private CorAtual As Integer = 0
    Private Sub FrmParcEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.KeyPreview = True


            ' Preencher os comboboxes com os dados recebidos
            PreencherComboBox(ComboBoxProtParc, DadosProt)
            PreencherComboBox(ComboBoxTotalParc, DadosTotal)
            LabelGeral.Text = FrmParcelamento.RazaoSocialTextBox.Text
            Lbltexto.Text = DadosParcelamento

            ' Ativa o KeyPreview para capturar eventos de tecla no formulário
            Me.KeyPreview = True

            'COLOCA SELECIONAR O PRIMEIRO SE TIVER NO COMBOBOX 
            ' Verifica e seleciona o primeiro item do ComboBoxProtParc
            If ComboBoxProtParc.Items.Count > 0 Then
                ComboBoxProtParc.SelectedIndex = 0
            End If

            ' Verifica e seleciona o primeiro item do ComboBoxTotalParc
            If ComboBoxTotalParc.Items.Count > 0 Then
                ComboBoxTotalParc.SelectedIndex = 0
            End If

            ' Verificar se DataEnviado tem valor no formato correto
            If Not String.IsNullOrEmpty(DataEnviado) AndAlso DateTime.TryParseExact(DataEnviado, "dd/MM/yyyy HH:mm", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, Nothing) Then
                ' Se DataEnviado estiver no formato correto, coloca no MaskedTextBox
                MaskedTextBoxData.Text = DataEnviado
            Else
                ' Se não estiver no formato correto, coloca a data atual no formato desejado
                MaskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            End If


            ' consultar a aba e colocar os dados 
            Select Case FrmParcelamento.TabControlParcelamento.SelectedTab.Name
                Case "TabPageGeral"

                Case "TabPageMei"
                    If FrmParcelamento.ParcelEnvMEITextBox.Text <> "" Then
                        TextBoxNparcEnviada.Text = FrmParcelamento.ParcelEnvMEITextBox.Text
                    End If '

                Case "TabPageINSSAntigo"
                    If FrmParcelamento.ParcelEnvINSSAntTextBox.Text <> "" Then
                        TextBoxNparcEnviada.Text = FrmParcelamento.ParcelEnvINSSAntTextBox.Text
                    End If '

                Case "TabPageINSSNovo"
                    If FrmParcelamento.ParcelEnvINSSNovTextBox.Text <> "" Then
                        TextBoxNparcEnviada.Text = FrmParcelamento.ParcelEnvINSSNovTextBox.Text
                    End If '


                Case "TabPageINSSProcuradoria"
                    If FrmParcelamento.ParcelEnvINSSProcTextBox.Text <> "" Then
                        TextBoxNparcEnviada.Text = FrmParcelamento.ParcelEnvINSSProcTextBox.Text
                    End If '

                Case Else
                    TextBoxNparcEnviada.Text = ""
            End Select

            LabelFormaDeEnvio.Text = FormaDeEnvio
            ' Verificar se o Label tem texto antes de iniciar o piscar
            If Not String.IsNullOrEmpty(LabelFormaDeEnvio.Text) Then
                ' Se houver texto, iniciar o Timer
                Timer1.Enabled = True
            Else
                MessageBox.Show($"Ocorreu um erro: FORMA DE ENVIO NAO LOCALIZADA", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            ' Tratamento de erros caso algo falhe ao carregar os dados
            LabelGeral.Text = "Erro ao carregar parcelamento."
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmParcEscolha_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Verificar se a tecla pressionada foi o "Esc"
        If e.KeyCode = Keys.Escape Then
            ' Fechar o formulário
            Me.Close()
        End If
    End Sub

    'PISCAR FORMA DE ENVIO ///////////

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Alterne entre as cores
        Select Case CorAtual
            Case 0
                LabelFormaDeEnvio.ForeColor = Color.Black
                CorAtual = 1
            Case 1
                LabelFormaDeEnvio.ForeColor = Color.Yellow
                CorAtual = 2
            Case 2
                LabelFormaDeEnvio.ForeColor = Color.Red
                CorAtual = 0
        End Select
    End Sub

    Private Sub LabelFormaDeEnvio_Click(sender As Object, e As EventArgs) Handles LabelFormaDeEnvio.Click
        ' Iniciar ou parar o timer ao clicar no label
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    '///////////////////////////

    ' Método para preencher os ComboBox dividindo os itens pelo separador "/"
    Private Sub PreencherComboBox(comboBox As ComboBox, dados As String)
        ' Limpar o ComboBox
        comboBox.Items.Clear()

        ' Dividir os dados pelo separador e adicionar ao ComboBox
        If Not String.IsNullOrEmpty(dados) Then
            Dim itens As String() = dados.Split("/"c)
            For Each item In itens
                comboBox.Items.Add(item.Trim()) ' Adicionar itens sem o separador
            Next
        End If
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            Dim cultura As New Globalization.CultureInfo("pt-BR")
            ' Obter valores iniciais
            Dim NParcela As String = TextBoxNparcEnviada.Text
            Dim razaoSocial As String = LabelGeral.Text
            Dim totalParcelamento As Integer
            Dim parcelaAtual As String
            Dim Protocol As String
            Dim HoraEnvio As String = DateTime.Now.ToString("'no dia' dd 'de' MMMM 'de' yyyy, dddd 'às' HH:mm:ss", cultura)

            ' Validar total de parcelamento
            If Not Integer.TryParse(ComboBoxTotalParc.SelectedItem?.ToString(), totalParcelamento) Then
                MessageBox.Show("O total de parcelamento não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Validar parcela atual
            parcelaAtual = TextBoxNparcEnviada.Text.Trim()
            If String.IsNullOrWhiteSpace(parcelaAtual) Then
                MessageBox.Show("A parcela atual não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Validar protocolo
            Protocol = ComboBoxProtParc.SelectedItem?.ToString().Trim()
            If String.IsNullOrWhiteSpace(Protocol) Then
                MessageBox.Show("O protocolo de parcelamento não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Identificar aba e controles associados
            Dim abaSelecionada As String = ""
            Dim richTextBoxSelecionado As RichTextBox = Nothing
            Dim Atrasado As String = ""

            Select Case FrmParcelamento.TabControlParcelamento.SelectedTab.Name
                Case "TabPageGeral"
                    abaSelecionada = "Geral"

                Case "TabPageMei"
                    abaSelecionada = "MEI"
                    FrmParcelamento.TabControlMei.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcMEIRichTextBox
                    HoraEnvio = ValidarHoraEnvio(MaskedTextBoxData.Text, cultura)
                    ' FrmParcelamento.ParcelEnvMEITextBox.Text = parcelaAtual
                    If FrmParcelamento.AtrasoParcelaMEICheckBox.Checked Then
                        Atrasado = "Parcelamento em atraso! O não pagamento pode resultar na perda."
                    End If

                Case "TabPageINSSAntigo"
                    abaSelecionada = "INSS Antigo"
                    FrmParcelamento.TabControlINSSAntigo.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcAntigoRichTextBox
                    HoraEnvio = ValidarHoraEnvio(MaskedTextBoxData.Text, cultura)
                    '  FrmParcelamento.ParcelEnvINSSAntTextBox.Text = parcelaAtual
                    If FrmParcelamento.AtrasoParcelaINSSAntigoCheckBox.Checked Then
                        Atrasado = "Parcelamento em atraso! O não pagamento pode resultar na perda."
                    End If

                Case "TabPageINSSNovo"
                    abaSelecionada = "INSS Novo"
                    FrmParcelamento.TabControlINSSNovo.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcNovoRichTextBox
                    HoraEnvio = ValidarHoraEnvio(MaskedTextBoxData.Text, cultura)
                    'FrmParcelamento.ParcelEnvINSSNovTextBox.Text = parcelaAtual
                    If FrmParcelamento.AtrasoParcelaINSSNovoCheckBox.Checked Then
                        Atrasado = "Parcelamento em atraso! O não pagamento pode resultar na perda."
                    End If

                Case "TabPageINSSProcuradoria"
                    abaSelecionada = "INSS Procuradoria"
                    FrmParcelamento.TabControlINSSProcuradoria.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcProcRichTextBox
                    HoraEnvio = ValidarHoraEnvio(MaskedTextBoxData.Text, cultura)
                    '  FrmParcelamento.ParcelEnvINSSProcTextBox.Text = parcelaAtual
                    If FrmParcelamento.AtrasoParcelaINSSProcuCheckBox.Checked Then
                        Atrasado = "Parcelamento em atraso! O não pagamento pode resultar na perda."
                    End If
                Case Else
                    abaSelecionada = "Indefinida"
            End Select

            ' Gerar mensagem para registro
            Dim FormaDeEnvio As String = FrmParcelamento.FormaDeEnvioComboBox.Text
            Dim mensagem As String = $"==========================================" & Environment.NewLine &
                          $"Foi enviado via {FormaDeEnvio}, {HoraEnvio}, referente ao {Protocol}, a parcela {parcelaAtual} de um total de {totalParcelamento}."

            ' Registrar mensagem no RichTextBox correspondente
            If richTextBoxSelecionado IsNot Nothing Then
                ' Verificar se já existe texto no RichTextBox
                If Not String.IsNullOrEmpty(richTextBoxSelecionado.Text) Then
                    ' Se já houver texto, adicionar uma linha em branco antes da nova mensagem
                    richTextBoxSelecionado.AppendText(Environment.NewLine)
                End If

                ' Adicionar a nova mensagem
                richTextBoxSelecionado.AppendText(mensagem & Environment.NewLine)

            Else
                MessageBox.Show("Nenhum RichTextBox foi encontrado para registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            ' Exibir mensagem de sucesso
            MessageBox.Show(mensagem, "Registro com Sucesso! Texto copiado para área de trabalho!", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ' Gerar texto para copiar////////////////////////////////////////
            Dim mesAnoReferencia As String = ""
            If Not String.IsNullOrWhiteSpace(HoraEnvio) Then
                Try
                    ' Extrair apenas a data e hora do texto de HoraEnvio
                    Dim partesHoraEnvio As String = HoraEnvio.Substring(HoraEnvio.IndexOf("no dia") + 7).Split(","c)(0).Trim()
                    Dim dataEnvio As DateTime = DateTime.ParseExact(partesHoraEnvio, "dd 'de' MMMM 'de' yyyy", cultura)
                    mesAnoReferencia = $"{dataEnvio:MMMM/yyyy}" ' Formato: mês por extenso/ano
                Catch ex As Exception
                    mesAnoReferencia = "mês desconhecido" ' Fallback caso a data seja inválida
                End Try
            Else
                mesAnoReferencia = "mês desconhecido" ' Fallback caso HoraEnvio esteja vazio
            End If

            Dim textoCopiar As String = ""

            'EM ATRASO??

            If Atrasado = "" Then
                If parcelaAtual = "1" Then
                    textoCopiar = $"Olá,
Segue o DARF mensal, referente ao *parcelamento INCIAL* do *{abaSelecionada}* da Empresa: *{razaoSocial}*.

Recibo/Prot.: {Protocol}.
Parcela: {parcelaAtual} do total de: {totalParcelamento} parcelas referente a *PRIMEIRA PARCELA* deste mês de {mesAnoReferencia}.

Atenciosamente,
Rogerio"
                Else
                    textoCopiar = $"Olá,
Segue o DARF mensal, referente ao parcelamento do *{abaSelecionada}* da Empresa: *{razaoSocial}*.

Recibo/Prot.: {Protocol}.
Parcela: {parcelaAtual} do total de: {totalParcelamento} parcelas referente ao de mês de {mesAnoReferencia}.

Atenciosamente,
Rogerio"
                End If
            Else
                    textoCopiar = $"Olá,
Segue o DARF mensal, referente ao parcelamento do *{abaSelecionada}* da Empresa: *{razaoSocial}*.

Recibo/Prot.: {Protocol}.
Parcela: {parcelaAtual} do total de: {totalParcelamento} parcelas referente ao de mês de {mesAnoReferencia}.
*ATENÇÃO: Parcelamento em atraso! O não pagamento pode resultar na perda.*

Atenciosamente,
Rogerio"
            End If


            ' Copiar para a área de transferência
            Clipboard.SetText(textoCopiar)

            '///////////////////////////


            ' Confirmar fechamento
            'If ConfirmarFechamento() Then
            Me.Close()
            'End' If

        Catch ex As Exception
            ' Tratamento de erros
            MessageBox.Show($"Ocorreu um erro ao registrar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Valida o campo de data e hora para garantir que esteja no formato correto ou use a hora atual.
    ''' </summary>
    ''' <param name="dataCampo">Texto do campo de data.</param>
    ''' <param name="cultura">Cultura para formatação da hora.</param>
    ''' <returns>String formatada com data e hora válidas.</returns>
    Private Function ValidarHoraEnvio(dataCampo As String, cultura As Globalization.CultureInfo) As String
        Dim dataValida As DateTime
        If String.IsNullOrWhiteSpace(dataCampo) OrElse dataCampo.Trim() = "  /  /" OrElse Not DateTime.TryParse(dataCampo, dataValida) Then
            Return DateTime.Now.ToString("'no dia' dd 'de' MMMM 'de' yyyy, dddd 'às' HH:mm:ss", cultura)
        Else
            Return dataValida.ToString("'no dia' dd 'de' MMMM 'de' yyyy, dddd 'às' HH:mm:ss", cultura)
        End If
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////////



    ' Método auxiliar para adicionar texto ao RichTextBox
    Private Sub AdicionarTextoRichTextBox(richTextBox As RichTextBox, texto As String)
        If Not String.IsNullOrWhiteSpace(richTextBox.Text) Then
            richTextBox.AppendText(Environment.NewLine) ' Adicionar nova linha se já houver texto
        End If
        richTextBox.AppendText(texto & Environment.NewLine)
    End Sub

    Private Function ConfirmarFechamento() As Boolean
        Dim result As DialogResult = MessageBox.Show("Deseja realmente fechar o formulário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return result = DialogResult.Yes
    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmarFechamento() Then
            ' Cancela o fechamento do formulário
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla pressionada é a tecla ESC
        If e.KeyCode = Keys.Escape Then
            ' Chama o método ConfirmarFechamento
            If ConfirmarFechamento() Then
                ' Fecha o formulário se confirmado
                Me.Close()
            End If
        End If
    End Sub



    Sub ProcessarTexto()
        Dim textoOriginal As String = "Olá," & vbCrLf &
        "Segue o DARF mensal, referente ao parcelamento do INSS Procuradoria da Empresa: LEANDRO KIOSHI HORAGUTI - ARMARINHOS." & vbCrLf &
        "Parcela:  11 do total de:  34 parcelas  referente ao de mês de novembro/2024" & vbCrLf &
        "Atenciosamente," & vbCrLf &
        "Rogerio"

        Dim empresa As String = ExtrairValor(textoOriginal, "Procuradoria da Empresa: (.+?)\.")
        Dim parcelaAtual As String = ExtrairValor(textoOriginal, "Parcela:\s+(\d+)")
        Dim totalParcelas As String = ExtrairValor(textoOriginal, "total de:\s+(\d+)")
        Dim mesAnoReferencia As String = ExtrairValor(textoOriginal, "referente ao de mês de (.+)")

        ' Recria o texto no formato original, mas com os dados atualizados
        Dim textoFormatado As String = $"Olá," & vbCrLf &
        $"Segue o DARF mensal, referente ao parcelamento do INSS Procuradoria da Empresa: {empresa}." & vbCrLf &
        $"Parcela:  {parcelaAtual} do total de:  {totalParcelas} parcelas  referente ao de mês de {mesAnoReferencia}" & vbCrLf &
        "Atenciosamente," & vbCrLf &
        "Rogerio"

        ' Copia o texto formatado para a área de transferência
        Clipboard.SetText(textoFormatado)

        ' Exibe o texto formatado para verificação
        MessageBox.Show("Texto processado e copiado para a área de transferência:" & vbCrLf & vbCrLf & textoFormatado)
    End Sub

    Function ExtrairValor(ByVal texto As String, ByVal padrao As String) As String
        Dim regex As New System.Text.RegularExpressions.Regex(padrao)
        Dim match As System.Text.RegularExpressions.Match = regex.Match(texto)
        If match.Success Then
            Return match.Groups(1).Value.Trim()
        Else
            Return "Não encontrado"
        End If
    End Function

    Private Sub ButtonAgora_Click(sender As Object, e As EventArgs) Handles ButtonAgora.Click
        ' Verificar se o MaskedTextBoxData já contém algum valor
        If Not String.IsNullOrWhiteSpace(MaskedTextBoxData.Text) Then
            ' Perguntar ao usuário se deseja substituir a data atual
            Dim result As DialogResult = MessageBox.Show("Já existe uma data. Deseja substituir pela data atual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Se o usuário confirmar, colocar a data atual no MaskedTextBoxData
            If result = DialogResult.Yes Then
                MaskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            End If
        Else
            ' Se não houver data, coloca a data atual diretamente
            MaskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        End If
    End Sub


End Class
