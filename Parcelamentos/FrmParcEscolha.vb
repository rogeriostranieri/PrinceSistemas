Public Class FrmParcEscolha
    ' Propriedades para receber dados do FrmParcelamento
    Public Property DadosProt As String
    Public Property DadosTotal As String
    Public Property DadosParcelamento As String
    Public Property ParcelaEnviada As String
    ' Evento de carregamento do formulário
    Private Sub FrmParcEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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

        Catch ex As Exception
            ' Tratamento de erros caso algo falhe ao carregar os dados
            LabelGeral.Text = "Erro ao carregar parcelamento."
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


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

            Select Case FrmParcelamento.TabControlParcelamento.SelectedTab.Name
                Case "TabPageGeral"
                    abaSelecionada = "Geral"

                Case "TabPageMei"
                    abaSelecionada = "MEI"
                    FrmParcelamento.TabControlMei.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcMEIRichTextBox
                    HoraEnvio = ValidarHoraEnvio(FrmParcelamento.DataEnviaMEIMaskedTextBox.Text, cultura)
                   ' FrmParcelamento.ParcelEnvMEITextBox.Text = parcelaAtual

                Case "TabPageINSSAntigo"
                    abaSelecionada = "INSS Antigo"
                    FrmParcelamento.TabControlINSSAntigo.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcAntigoRichTextBox
                    HoraEnvio = ValidarHoraEnvio(FrmParcelamento.DataEnviaAntigoMaskedTextBox.Text, cultura)
                  '  FrmParcelamento.ParcelEnvINSSAntTextBox.Text = parcelaAtual

                Case "TabPageINSSNovo"
                    abaSelecionada = "INSS Novo"
                    FrmParcelamento.TabControlINSSNovo.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcNovoRichTextBox
                    HoraEnvio = ValidarHoraEnvio(FrmParcelamento.DataEnvioNovoMaskedTextBox.Text, cultura)
                    'FrmParcelamento.ParcelEnvINSSNovTextBox.Text = parcelaAtual

                Case "TabPageINSSProcuradoria"
                    abaSelecionada = "INSS Procuradoria"
                    FrmParcelamento.TabControlINSSProcuradoria.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcProcRichTextBox
                    HoraEnvio = ValidarHoraEnvio(FrmParcelamento.DataEnviaProcMaskedTextBox.Text, cultura)
                    '  FrmParcelamento.ParcelEnvINSSProcTextBox.Text = parcelaAtual
                Case Else
                    abaSelecionada = "Indefinida"
            End Select

            ' Gerar mensagem para registro
            Dim FormaDeEnvio As String = FrmParcelamento.FormaDeEnvioComboBox.Text
            Dim mensagem As String = $"==========================================" & Environment.NewLine &
                              $"Foi enviado via {FormaDeEnvio}, {HoraEnvio}, referente ao {Protocol}, a parcela {parcelaAtual} de um total de {totalParcelamento}."

            ' Registrar mensagem no RichTextBox correspondente
            If richTextBoxSelecionado IsNot Nothing Then
                richTextBoxSelecionado.AppendText(mensagem & Environment.NewLine)

                Select Case FrmParcelamento.TabControlParcelamento.SelectedTab.Name
                    Case "TabPageGeral"
                        'nada
                    Case "TabPageMei"
                        HoraEnvio = DateTime.Now.ToString("dd/MM/yyyy HH:mm", cultura)
                        FrmParcelamento.DataEnviaMEIMaskedTextBox.Text = HoraEnvio
                        FrmParcelamento.ParcelEnvMEITextBox.Text = parcelaAtual

                    Case "TabPageINSSAntigo"
                        HoraEnvio = DateTime.Now.ToString("dd/MM/yyyy HH:mm", cultura)
                        FrmParcelamento.DataEnviaAntigoMaskedTextBox.Text = HoraEnvio
                        FrmParcelamento.ParcelEnvINSSAntTextBox.Text = parcelaAtual

                    Case "TabPageINSSNovo"
                        HoraEnvio = DateTime.Now.ToString("dd/MM/yyyy HH:mm", cultura)
                        FrmParcelamento.DataEnvioNovoMaskedTextBox.Text = HoraEnvio
                        FrmParcelamento.ParcelEnvINSSNovTextBox.Text = parcelaAtual

                    Case "TabPageINSSProcuradoria"
                        HoraEnvio = DateTime.Now.ToString("dd/MM/yyyy HH:mm", cultura)
                        FrmParcelamento.DataEnviaProcMaskedTextBox.Text = HoraEnvio
                        FrmParcelamento.ParcelEnvINSSProcTextBox.Text = parcelaAtual

                    Case Else
                        HoraEnvio = DateTime.Now.ToString("dd/MM/yyyy HH:mm", cultura)
                End Select

            Else
                MessageBox.Show("Nenhum RichTextBox foi encontrado para registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Exibir mensagem de sucesso
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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


End Class
