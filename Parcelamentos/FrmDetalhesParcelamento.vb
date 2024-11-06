Public Class FrmDetalhesParcelamento
    Private parcelamentoID As Integer

    ' Construtor que recebe o ID do parcelamento
    Public Sub New(id As Integer)
        InitializeComponent()
        parcelamentoID = id
    End Sub

    Private Sub FrmDetalhesParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os detalhes do parcelamento usando o parcelamentoID
        Me.ParcelamentosTableAdapter.FillByEmpresaID(Me.PrinceDBDataSet.Parcelamentos, parcelamentoID)

        ' Define os itens a serem adicionados
        Dim itens As String() = {"Sim", "Não", "Cancelado", "Indeferido"}

        ' Adiciona os itens a cada ComboBox
        AdicionarItensComboBox(FinalizadoINSSAntigoComboBox, itens)
        AdicionarItensComboBox(FinalizadoINSSNovoComboBox, itens)
        AdicionarItensComboBox(FinalizadoINSSProcComboBox, itens)
        AdicionarItensComboBox(FinalizadoMEIComboBox, itens)

        ConfigurarDataNula(DataParcelINSSantigoDateTimePicker)
        ConfigurarDataNula(DataParcelINSSnovoDateTimePicker)
        ConfigurarDataNula(DataParcelINSSprocDateTimePicker)
        ConfigurarDataNula(DataParcMEIDateTimePicker)
    End Sub
    Private Sub AdicionarItensComboBox(combo As ComboBox, itens As String())
        combo.Items.Clear() ' Limpa itens existentes, se necessário
        combo.Items.AddRange(itens) ' Adiciona os itens definidos
        combo.SelectedIndex = 0 ' Define o item padrão como o primeiro (opcional)
    End Sub

    Private Sub FinalizadoINSSAntigoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSAntigoComboBox.SelectedIndexChanged
        If FinalizadoINSSAntigoComboBox.Text = "Indeferido" Then
            MotivoParcINSSAntigoRichTextBox.Visible = True
            Label1.Visible = True
        ElseIf FinalizadoINSSAntigoComboBox.Text = "Finalizado" Then
            GroupBoxFimINSSantigo.Visible = True
        Else
            MotivoParcINSSAntigoRichTextBox.Visible = False
            Label1.Visible = False
            GroupBoxFimINSSantigo.Visible = False

        End If
    End Sub

    Private Sub FinalizadoINSSNovoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSNovoComboBox.SelectedIndexChanged
        If FinalizadoINSSNovoComboBox.Text = "Indeferido" Then
            MotivoParcINSSNovoRichTextBox.Visible = True
            Label2.Visible = True
        ElseIf FinalizadoINSSNovoComboBox.Text = "Finalizado" Then
            GroupBoxFimINSSnovo.Visible = True
        Else
            MotivoParcINSSNovoRichTextBox.Visible = False
            Label2.Visible = False
            GroupBoxFimINSSnovo.Visible = False
        End If
    End Sub

    Private Sub FinalizadoINSSProcComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSProcComboBox.SelectedIndexChanged
        If FinalizadoINSSProcComboBox.Text = "Indeferido" Then
            MotivoParcINSSProcRichTextBox.Visible = True
            Label3.Visible = True
        ElseIf FinalizadoINSSProcComboBox.Text = "Finalizado" Then
            GroupBoxFimINSSProc.Visible = True
        Else
            MotivoParcINSSProcRichTextBox.Visible = False
            Label3.Visible = False
            GroupBoxFimINSSProc.Visible = False
        End If
    End Sub

    Private Sub FinalizadoMEIComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoMEIComboBox.SelectedIndexChanged
        If FinalizadoMEIComboBox.Text = "Indeferido" Then
            MotivoParcMEIRichTextBox.Visible = True
            Label4.Visible = True
        ElseIf FinalizadoMEIComboBox.Text = "Finalizado" Then
            GroupBoxFimINSSmei.Visible = True
        Else
            MotivoParcMEIRichTextBox.Visible = False
            Label4.Visible = False
            GroupBoxFimINSSmei.Visible = False

        End If
    End Sub

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
        RegistrarEnvio("INSS Antigo", MesEnviadoINSSAntigoDateTimePicker, HistoricoEnvioINSSAntigoRichTextBox)
    End Sub

    Private Sub BtnRegistrarEnvioInssNovo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioInssNovo.Click
        RegistrarEnvio("INSS Novo", MesEnviadoINSSNovoDateTimePicker, HistoricoEnvioINSSNovoRichTextBox)
    End Sub

    Private Sub BtnRegistrarEnvioInssProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioInssProcuradoria.Click
        RegistrarEnvio("INSS Procuradoria", MesEnviadoINSSProcDateTimePicker, HistoricoEnvioINSSProcRichTextBox)
    End Sub

    Private Sub BtnRegistrarEnvioMEI_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioMEI.Click
        RegistrarEnvio("MEI", MesEnviadoMEIDateTimePicker, HistoricoEnvioMEIRichTextBox)
    End Sub

    Private Sub RegistrarEnvio(tipoParcelamento As String, dataPicker As DateTimePicker, historicoRichTextBox As RichTextBox)
        Dim formaEnvio As String = CType(FrmParcelamentos.TabControlPrincipal.TabPages(2).Controls("FormaEnvioComboBox"), ComboBox).Text
        Dim detalheEnvio As String = ""

        Select Case formaEnvio
            Case "WhatsApp"
                detalheEnvio = CType(FrmParcelamentos.TabControlPrincipal.TabPages(2).Controls("WhatsAppTextBox"), TextBox).Text
            Case "E-Mail"
                detalheEnvio = CType(FrmParcelamentos.TabControlPrincipal.TabPages(2).Controls("EmailTextBox"), TextBox).Text
            Case "Impresso"
                detalheEnvio = ""
        End Select

        Dim textoHistorico As String = $"{DateTime.Now.ToString("dddd, dd MMMM yyyy 'ás' HH:mm")}, foi enviado via {formaEnvio} - {detalheEnvio} - referente ao parcelamento {tipoParcelamento}"
        historicoRichTextBox.Text &= textoHistorico & vbCrLf
        dataPicker.Value = DateTime.Now
    End Sub
    '//////////////// FIM DATA NULO
End Class
