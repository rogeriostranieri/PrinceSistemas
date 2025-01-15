Public Class FrmParcEscolha
    ' Propriedades para receber dados do FrmParcelamento
    Public Property DadosProt As String
    Public Property DadosTotal As String

    Public Property DadosParcelamento As String

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
            'deixa N parcela enviada 
            Dim NParcela As String = TextBoxNparcEnviada.Text

            ' Obter valores para registro de frmParcelamento
            Dim razaoSocial As String = LabelGeral.Text

            ' Obter valores de FrmParcEscolha
            Dim totalParcelamento As Integer
            Dim parcelaAtual As String ' Agora aceita texto ou número
            Dim Protocol As String ' Agora aceita texto ou número

            ' Verificar se o ComboBox tem um valor válido para totalParcelamento
            If Not Integer.TryParse(ComboBoxTotalParc.SelectedItem?.ToString(), totalParcelamento) Then
                MessageBox.Show("O total de parcelamento não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Verificar se o TextBoxNparcEnviada contém um valor válido (aceita números ou texto)
            parcelaAtual = TextBoxNparcEnviada.Text.Trim()
            If String.IsNullOrWhiteSpace(parcelaAtual) Then
                MessageBox.Show("A parcela atual não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Verificar se o ComboBoxProtParc contém um valor válido (aceita números ou texto)
            Protocol = ComboBoxProtParc.SelectedItem?.ToString().Trim()
            If String.IsNullOrWhiteSpace(Protocol) Then
                MessageBox.Show("O protocolo de parcelamento não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            ' Obter aba principal selecionada no TabControlParcelamento
            Dim abaSelecionada As String = ""
            Dim richTextBoxSelecionado As RichTextBox = Nothing
            Dim HoraEnvio As String = ""


            'pegar forma de envio
            ' Selecionar a aba 1
            FrmParcelamento.TabControlGeral.SelectedIndex = 1

            ' Voltar para a aba 0
            FrmParcelamento.TabControlGeral.SelectedIndex = 0

            Dim FormaDeEnvio As String = FrmParcelamento.FormaDeEnvioComboBox.Text


            ' Verificar qual aba principal está selecionada no TabControlParcelamento
            Select Case FrmParcelamento.TabControlParcelamento.SelectedTab.Name

                Case "TabPageGeral"
                    abaSelecionada = "Geral"
                ' Aba Geral não tem sub-abas, portanto richTextBoxSelecionado permanece Nothing.

                Case "TabPageMei"
                    abaSelecionada = "MEI"
                    ' Selecionar a sub-aba 1 para registro
                    FrmParcelamento.TabControlMei.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcMEIRichTextBox
                    HoraEnvio = FrmParcelamento.DataEnviaMEIMaskedTextBox.Text

                Case "TabPageINSSAntigo"
                    abaSelecionada = "INSS Antigo"
                    ' Selecionar a sub-aba 1 para registro
                    FrmParcelamento.TabControlINSSAntigo.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcAntigoRichTextBox
                    HoraEnvio = FrmParcelamento.DataFinalAntigoMaskedTextBox.Text
                Case "TabPageINSSNovo"
                    abaSelecionada = "INSS Novo"
                    ' Selecionar a sub-aba 1 para registro
                    FrmParcelamento.TabControlINSSNovo.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcNovoRichTextBox
                    HoraEnvio = FrmParcelamento.DataFinalNovoMaskedTextBox.Text

                Case "TabPageINSSProcuradoria"
                    abaSelecionada = "INSS Procuradoria"
                    ' Selecionar a sub-aba 1 para registro
                    FrmParcelamento.TabControlINSSProcuradoria.SelectedIndex = 1
                    richTextBoxSelecionado = FrmParcelamento.EnviaParcProcRichTextBox
                    HoraEnvio = FrmParcelamento.DataFinalProcMaskedTextBox.Text

                Case Else
                    abaSelecionada = "Indefinida"
            End Select

            'Adiciona data de agora se tiver vazio
            If HoraEnvio = "" Then
                HoraEnvio = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If

            ' Validar os valores capturados
            If String.IsNullOrWhiteSpace(razaoSocial) Then
                MessageBox.Show("A razão social não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Exemplo de uso: registrar os dados (simulação de salvamento no banco de dados)
            Dim mensagem As String = $"==========================================" & Environment.NewLine &
                         $"Foi enviado via {FormaDeEnvio} no dia {HoraEnvio}, referente ao {Protocol}, a parcela {parcelaAtual} de um total de {totalParcelamento}."


            ' Verificar se richTextBoxSelecionado está associado a algum campo e registrar a mensagem
            If richTextBoxSelecionado IsNot Nothing Then
                richTextBoxSelecionado.AppendText(mensagem & Environment.NewLine)
            Else
                MessageBox.Show("Nenhuma sub-aba válida foi selecionada para registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Exibição da mensagem de sucesso
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' levar dados para o parcelamento apos
            ' Verificar qual aba principal está selecionada no TabControlParcelamento
            Select Case FrmParcelamento.TabControlParcelamento.SelectedIndex
                Case 0
                    abaSelecionada = "Geral"
                ' Aba Geral não tem sub-abas, portanto richTextBoxSelecionado permanece Nothing.

                Case 1
                    abaSelecionada = "MEI"
                    ' envia o numero da parcela
                    NParcela = FrmParcelamento.ParcelEnvMEITextBox.Text

                Case 2
                    abaSelecionada = "INSS Antigo"
                    'envia o numero da parcela
                    NParcela = FrmParcelamento.ParcelEnvINSSAntTextBox.Text

                Case 3
                    abaSelecionada = "INSS Novo"
                    ' envia o numero da parcela
                    NParcela = FrmParcelamento.ParcelEnvINSSNovTextBox.Text

                Case 4
                    abaSelecionada = "INSS Procuradoria"
                    'envia o numero da parcela
                    NParcela = FrmParcelamento.ParcelEnvINSSProcTextBox.Text

                Case Else
                    abaSelecionada = "Indefinida"
            End Select



            If ConfirmarFechamento() Then
                Me.Close()
            End If

        Catch ex As Exception
            ' Tratamento de erros
            MessageBox.Show($"Ocorreu um erro ao registrar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






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
