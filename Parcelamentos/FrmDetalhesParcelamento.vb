Public Class FrmDetalhesParcelamento
    ' Definindo a variável para armazenar o ID da empresa (em vez de parcelamentoID)
    Private empresaID As Integer

    ' Construtor que recebe o ID da empresa
    Public Sub New(id As Integer)
        InitializeComponent()
        empresaID = id
    End Sub

    Private Sub FrmDetalhesParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os detalhes do parcelamento usando o empresaID
        If empresaID > 0 Then
            ' Preencher os dados relacionados à empresa selecionada
            'Me.ParcelamentosTableAdapter.FillByEmpresaID(Me.PrinceDBDataSet.Parcelamentos, empresaID)
        Else
            MessageBox.Show("ID de empresa inválido.")
        End If

        ' Define os itens a serem adicionados nos ComboBoxes
        Dim itens As String() = {"Finalizado", "Em Andamento", "Cancelado", "Indeferido", "Sem Dívidas"}

        ' Adiciona os itens a cada ComboBox
        AdicionarItensComboBox(FinalizadoINSSAntigoComboBox, itens)
        AdicionarItensComboBox(FinalizadoINSSNovoComboBox, itens)
        AdicionarItensComboBox(FinalizadoINSSProcComboBox, itens)
        AdicionarItensComboBox(FinalizadoMEIComboBox, itens)

        ' Chama DataNula para realizar alguma ação de verificação ou limpeza
        DataNula()
    End Sub

    Private Sub DataNula()
        ' Configura todos os DateTimePickers com a função ConfigurarDataNula
        ConfigurarDataNula(DataParcelINSSantigoDateTimePicker)
        ConfigurarDataNula(DataFimParcINSSAntigoDateTimePicker)
        ConfigurarDataNula(MesEnviadoINSSAntigoDateTimePicker)

        ConfigurarDataNula(DataParcelINSSnovoDateTimePicker)
        ConfigurarDataNula(MesEnviadoINSSNovoDateTimePicker)
        ConfigurarDataNula(DataFimParcINSSNovoDateTimePicker)

        ConfigurarDataNula(DataParcelINSSprocDateTimePicker)
        ConfigurarDataNula(DataFimParcINSSProcDateTimePicker)
        ConfigurarDataNula(MesEnviadoINSSProcDateTimePicker)

        ConfigurarDataNula(DataParcMEIDateTimePicker)
        ConfigurarDataNula(DataFimParcMEIDateTimePicker)
        ConfigurarDataNula(MesEnviadoMEIDateTimePicker)
    End Sub
    Private Sub AdicionarItensComboBox(combo As ComboBox, itens As String())
        combo.Items.Clear() ' Limpa itens existentes, se necessário
        combo.Items.AddRange(itens) ' Adiciona os itens definidos
        combo.SelectedIndex = 0 ' Define o item padrão como o primeiro (opcional)
    End Sub
    '/////////////////////////////// DATA PICK ao finalizar
    Private Sub FinalizadoINSSAntigoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSAntigoComboBox.SelectedIndexChanged
        HandleFinalizadoComboBox(FinalizadoINSSAntigoComboBox, 0, Label1, MotivoParcINSSAntigoRichTextBox, GroupBoxFimINSSantigo, "DataParcelINSSantigo", "MesEnviadoINSSAntigo")
    End Sub

    Private Sub FinalizadoINSSNovoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSNovoComboBox.SelectedIndexChanged
        HandleFinalizadoComboBox(FinalizadoINSSNovoComboBox, 1, Label2, MotivoParcINSSNovoRichTextBox, GroupBoxFimINSSnovo, "DataParcelINSSnovo", "MesEnviadoINSSNovo")
    End Sub

    Private Sub FinalizadoINSSProcComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSProcComboBox.SelectedIndexChanged
        HandleFinalizadoComboBox(FinalizadoINSSProcComboBox, 2, Label3, MotivoParcINSSProcRichTextBox, GroupBoxFimINSSProc, "DataParcelINSSproc", "MesEnviadoINSSProc")
    End Sub

    Private Sub FinalizadoMEIComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoMEIComboBox.SelectedIndexChanged
        HandleFinalizadoComboBox(FinalizadoMEIComboBox, 3, Label4, MotivoParcMEIRichTextBox, GroupBoxFimMEI, "DataParcMEI", "MesEnviadoMEI")
    End Sub

    ' Função genérica para lidar com a lógica de finalizar, definir DateTimePicker como NULL se necessário, e ajustar visibilidade dos controles
    Private Sub HandleFinalizadoComboBox(comboBox As ComboBox, tabIndex As Integer, label As Label, motivoTextBox As RichTextBox, groupBoxFim As GroupBox, ParamArray dateFields() As String)
        ' Ajuste de visibilidade dos controles
        If comboBox.Text = "Indeferido" OrElse comboBox.Text = "Finalizado" Then
            label.Visible = True
            motivoTextBox.Visible = True
            groupBoxFim.Visible = True
        ElseIf String.IsNullOrEmpty(comboBox.Text) Then
            label.Visible = False
            motivoTextBox.Visible = False
            groupBoxFim.Visible = False
        Else
            label.Visible = False
            motivoTextBox.Visible = False
            groupBoxFim.Visible = False
        End If

        ' Verifica se o ComboBox está marcado como "Finalizado" e está na aba correta
        If comboBox.Text = "Finalizado" AndAlso TabControlPrincipal.SelectedIndex = tabIndex Then
            Dim dataAlterada As Boolean = False

            GroupBoxFimINSSantigo.Visible = False

            ' Itera sobre os campos e define como NULL se ainda não estiverem nulos
            For Each field As String In dateFields
                Dim datePicker As DateTimePicker = CType(Me.Controls.Find(field & "DateTimePicker", True).FirstOrDefault(), DateTimePicker)
                If datePicker IsNot Nothing AndAlso datePicker.Value <> datePicker.MinDate Then
                    CType(ParcelamentosBindingSource.Current, DataRowView)(field) = DBNull.Value
                    datePicker.Value = datePicker.MinDate ' Apenas visualmente
                    dataAlterada = True
                End If
            Next

            ' Salva as alterações apenas se algum valor foi alterado para NULL
            If dataAlterada Then
                Salvar()
                MessageBox.Show("Campos de data salvos como nulo com sucesso.")
            End If

        Else
            GroupBoxFimINSSantigo.Visible = True
        End If
    End Sub


    '/////////////////////////////// FIM DATA PICK ao finalizar


    '///////////////// DATA  NULO

    ' Configura um DateTimePicker para exibir o campo "vazio" e o formato extenso
    Private Sub ConfigurarDataNula(datePicker As DateTimePicker)
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.CustomFormat = " " ' Exibe espaço em branco para simular campo vazio
        datePicker.ForeColor = Color.Gray ' Cor do texto em cinza para indicar vazio
    End Sub

    ' Evento para detectar quando o usuário seleciona uma data e exibir o formato extenso
    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DataParcelINSSantigoDateTimePicker.ValueChanged, DataParcelINSSnovoDateTimePicker.ValueChanged, DataParcelINSSprocDateTimePicker.ValueChanged, DataParcMEIDateTimePicker.ValueChanged
        Dim datePicker As DateTimePicker = DirectCast(sender, DateTimePicker)
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.CustomFormat = "dddd, d 'de' MMMM 'de' yyyy" ' Formato extenso
        datePicker.ForeColor = Color.Black ' Muda a cor do texto para preto
    End Sub

    ' Reseta o DateTimePicker para o estado vazio quando perde o foco e o valor é considerado nulo
    Private Sub DatePicker_Leave(sender As Object, e As EventArgs) Handles DataParcelINSSantigoDateTimePicker.Leave, DataParcelINSSnovoDateTimePicker.Leave, DataParcelINSSprocDateTimePicker.Leave, DataParcMEIDateTimePicker.Leave
        Dim datePicker As DateTimePicker = DirectCast(sender, DateTimePicker)
        If datePicker.Value = datePicker.MinDate Then
            ConfigurarDataNula(datePicker)
        End If
    End Sub

    ' Função para "limpar" qualquer DateTimePicker manualmente, simulando um valor nulo
    Private Sub LimparData(datePicker As DateTimePicker)
        datePicker.Value = datePicker.MinDate ' Define como a data mínima ou de referência
        ConfigurarDataNula(datePicker)
    End Sub

    '////////////////// REGISTRAR ENVIO
    Private Sub BtnRegistrarEnvioInssAntigo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioInssAntigo.Click
        '    SubTabControlINSSAntigo.SelectedIndex = 1
        ' Pergunta se o usuário deseja registrar o envio
        Dim confirmacao As DialogResult = MessageBox.Show("Deseja registrar o envio do INSS Antigo?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Se o usuário clicar em "Sim", executa o código
        If confirmacao = DialogResult.Yes Then
            ' Seleciona a guia "Histórico de Envio"
            SubTabControlINSSAntigo.SelectedIndex = 1
            ' Chama o método para registrar o envio
            RegistrarEnvio("INSS Antigo", MesEnviadoINSSAntigoDateTimePicker, HistoricoEnvioINSSAntigoRichTextBox)
        Else
            MessageBox.Show("Registro de envio cancelado.")
        End If
    End Sub

    Private Sub BtnRegistrarEnvioInssNovo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioInssNovo.Click
        ' Pergunta se o usuário deseja registrar o envio
        Dim confirmacao As DialogResult = MessageBox.Show("Deseja registrar o envio do INSS Novo?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Se o usuário clicar em "Sim", executa o código
        If confirmacao = DialogResult.Yes Then
            ' Seleciona a guia "Histórico de Envio"
            SubTabControlINSSNovo.SelectedIndex = 1
            ' Chama o método para registrar o envio
            RegistrarEnvio("INSS Novo", MesEnviadoINSSNovoDateTimePicker, HistoricoEnvioINSSNovoRichTextBox)
        Else
            MessageBox.Show("Registro de envio cancelado.")
        End If
    End Sub

    Private Sub BtnRegistrarEnvioInssProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioInssProcuradoria.Click

        ' Pergunta se o usuário deseja registrar o envio
        Dim confirmacao As DialogResult = MessageBox.Show("Deseja registrar o envio do INSS Procuradoria?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Se o usuário clicar em "Sim", executa o código
        If confirmacao = DialogResult.Yes Then
            ' Seleciona a guia "Histórico de Envio"
            SubTabControlINSSProcuradoria.SelectedIndex = 1
            ' Chama o método para registrar o envio
            RegistrarEnvio("INSS Procuradoria", MesEnviadoINSSProcDateTimePicker, HistoricoEnvioINSSProcRichTextBox)
        Else
            MessageBox.Show("Registro de envio cancelado.")
        End If
    End Sub

    Private Sub BtnRegistrarEnvioMEI_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioMEI.Click
        ' Pergunta se o usuário deseja registrar o envio
        Dim confirmacao As DialogResult = MessageBox.Show("Deseja registrar o envio do MEI?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Se o usuário clicar em "Sim", executa o código
        If confirmacao = DialogResult.Yes Then
            ' Seleciona a guia "Histórico de Envio"
            SubTabControlMEI.SelectedIndex = 1
            ' Chama o método para registrar o envio
            RegistrarEnvio("MEI", MesEnviadoMEIDateTimePicker, HistoricoEnvioMEIRichTextBox)
        Else
            MessageBox.Show("Registro de envio cancelado.")
        End If
    End Sub

    Private Sub RegistrarEnvio(tipoParcelamento As String, dataPicker As DateTimePicker, historicoRichTextBox As RichTextBox)
        Dim formaEnvio As String = CType(FrmParcelamentos.TabControlPrincipal.TabPages(2).Controls("FormaEnvioComboBox"), ComboBox).Text
        Dim detalheEnvio As String = ""
        Dim numParcela As String = ""

        ' Solicita o número da parcela
        Using dialog As New InputDialog
            dialog.LabelText = "Informe o número da parcela enviada:"
            If dialog.ShowDialog = DialogResult.OK Then
                numParcela = dialog.TextBoxText
            Else
                Exit Sub
            End If
        End Using

        Select Case formaEnvio
            Case "WhatsApp"
                detalheEnvio = CType(FrmParcelamentos.TabControlPrincipal.TabPages(2).Controls("WhatsAppTextBox"), TextBox).Text
            Case "E-Mail"
                detalheEnvio = CType(FrmParcelamentos.TabControlPrincipal.TabPages(2).Controls("EmailTextBox"), TextBox).Text
            Case "Impresso"
                detalheEnvio = ""
        End Select

        Dim textoHistorico As String = $"{DateTime.Now.ToString("dddd, dd MMMM yyyy 'ás' HH:mm")}, foi enviado via {formaEnvio} - {detalheEnvio} - referente ao parcelamento {tipoParcelamento} (Parcela {numParcela})"
        historicoRichTextBox.Text &= textoHistorico & vbCrLf
        dataPicker.Value = DateTime.Now
    End Sub


    '//////////////// FIM DATA NULO

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()

    End Sub

    ' Função auxiliar para verificar DateTimePickers e definir valores nulos
    Private Sub VerificarDataNula(datePicker As DateTimePicker, colunaNome As String)
        If datePicker.Value = datePicker.MinDate Then
            CType(ParcelamentosBindingSource.Current, DataRowView)(colunaNome) = DBNull.Value
        Else
            CType(ParcelamentosBindingSource.Current, DataRowView)(colunaNome) = datePicker.Value
        End If
    End Sub
    Private Sub Salvar()
        Try
            ' Verificar todas as datas
            VerificarDatas()

            ' Força a atualização dos controles vinculados
            Me.Validate()
            Me.ParcelamentosBindingSource.EndEdit()

            ' Verificar se há alterações
            If Me.PrinceDBDataSet.HasChanges() Then
                Dim confirmSave As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Confirmar Salvar", MessageBoxButtons.YesNo)
                If confirmSave = DialogResult.Yes Then
                    ' Desabilitar temporariamente o BindingSource
                    ParcelamentosBindingSource.RaiseListChangedEvents = False

                    ' Salvar as alterações apenas na tabela Parcelamentos
                    Me.ParcelamentosTableAdapter.Update(Me.PrinceDBDataSet.Parcelamentos)

                    ' Reabilitar o BindingSource
                    ParcelamentosBindingSource.RaiseListChangedEvents = True

                    ' Mensagem de sucesso
                    MessageBox.Show("Alterações salvas com sucesso.")
                Else
                    MessageBox.Show("Alterações não foram salvas.")
                End If
            Else
                MessageBox.Show("Nenhuma alteração foi realizada.")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar as alterações: " & ex.Message)
        End Try
    End Sub


    Private Sub VerificarDatas()
        Dim dateFields As New Dictionary(Of DateTimePicker, String) From {
        {DataParcelINSSantigoDateTimePicker, "DataParcelINSSantigo"},
        {DataFimParcINSSAntigoDateTimePicker, "DataFimParcINSSAntigo"},
        {MesEnviadoINSSAntigoDateTimePicker, "MesEnviadoINSSAntigo"},
        {DataParcelINSSnovoDateTimePicker, "DataParcelINSSnovo"},
        {MesEnviadoINSSNovoDateTimePicker, "MesEnviadoINSSNovo"},
        {DataFimParcINSSNovoDateTimePicker, "DataFimParcINSSNovo"},
        {DataParcelINSSprocDateTimePicker, "DataParcelINSSproc"},
        {DataFimParcINSSProcDateTimePicker, "DataFimParcINSSProc"},
        {MesEnviadoINSSProcDateTimePicker, "MesEnviadoINSSProc"},
        {DataParcMEIDateTimePicker, "DataParcMEI"},
        {DataFimParcMEIDateTimePicker, "DataFimParcMEI"},
        {MesEnviadoMEIDateTimePicker, "MesEnviadoMEI"}
    }

        For Each entry As KeyValuePair(Of DateTimePicker, String) In dateFields
            VerificarDataNula(entry.Key, entry.Value)
        Next
    End Sub






    Private Sub FrmDetalhesParcelamento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Salvar()
        ' Reabrir o FrmParcelamentos e passar o ID_Empresa
        Dim frmParcelamentos As New FrmParcelamentos()
        frmParcelamentos.CarregarEmpresaPorID(Me.empresaID) ' Passa o parcelamentoID ou o ID da empresa
        frmParcelamentos.Show()
    End Sub


End Class
