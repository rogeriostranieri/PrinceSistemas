Imports System.Data.SqlClient

Public Class FrmParcelamentos
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    ' Dentro do FrmParcelamentos:
    Public Sub CarregarEmpresaPorID(empresaID As Integer)
        ' Aqui você faz a busca no banco de dados para carregar os dados da empresa com o ID fornecido
        Me.ParcelamentosTableAdapter.FillByEmpresaID(Me.PrinceDBDataSet.Parcelamentos, empresaID)
    End Sub



    Private Sub MostraCalendario()
        DialogCalendarioParcelamento.Show()
        DialogCalendarioParcelamento.Focus()
        'abrir no local do mouse
        DialogCalendarioParcelamento.Location = New Point(MousePosition.X, MousePosition.Y)
    End Sub


    ' Variável privada para armazenar o ID da empresa atual
    Private empresaID As Integer

    ' Construtor padrão
    Public Sub New()
        InitializeComponent()
        ' Atribui um valor padrão ao empresaID, caso seja necessário
        empresaID = 0
    End Sub

    Private Sub FrmParcelamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os dados da tabela Parcelamentos ao carregar o formulário
        ' Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)
        ' Verifica se um ID foi passado para o formulário
        If empresaID > 0 Then
            ' Carrega os dados da tabela Parcelamentos filtrados pelo ID_Parcelamento
            Me.ParcelamentosTableAdapter.FillByEmpresaID(Me.PrinceDBDataSet.Parcelamentos, empresaID)
        Else
            ' Carrega todos os dados de Parcelamentos, caso o ID_Parcelamento não tenha sido passado
            Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)
        End If

        EditarAtivado()

        CarregarComboBoxes()

        ' Verifica se o campo DataEnvio é DBNull e, se for, reseta o controle para o formato vazio
        If IsDBNull(ParcelamentosBindingSource.Current("DataEnvio")) Then
            LimparDataEnvio()
        Else
            ' Caso contrário, carrega a data normalmente
            DataEnvioDateTimePicker.Value = CType(ParcelamentosBindingSource.Current("DataEnvio"), DateTime)
            DataEnvioDateTimePicker.Format = DateTimePickerFormat.Custom
            DataEnvioDateTimePicker.CustomFormat = "dddd, d 'de' MMMM 'de' yyyy"
            DataEnvioDateTimePicker.ForeColor = Color.Black
        End If

        ' Verifica se os campos relacionados aos CheckBoxes são nulos e desmarca os CheckBoxes se necessário
        DesmarcarCheckBoxesSeNulo("INSSAntigo", INSSAntigoCheckBox)
        DesmarcarCheckBoxesSeNulo("INSSNovo", INSSNovoCheckBox)
        DesmarcarCheckBoxesSeNulo("INSSProcuradoria", INSSProcuradoriaCheckBox)
        DesmarcarCheckBoxesSeNulo("MEI", MEICheckBox)



        FinalizadoParcelamentoComboBox.Items.AddRange(New String() {
        "Em Construção",
        "Aguardando Autorização",
        "Aguardando Parcelar",
        "Aguardando Cliente",
                "Finalizado",
        "Em Andamento",
        "Para Fazer",
        "Não Realizado",
        "Cancelado",
        "Indeferido"
    })

    End Sub

    ' Função para verificar se um campo está nulo e desmarcar o CheckBox correspondente
    ' Função para verificar se um campo está nulo ou contém "Unchecked"/"Checked" e desmarcar o CheckBox correspondente
    Private Sub DesmarcarCheckBoxesSeNulo(campo As String, checkBox As CheckBox)
        If IsDBNull(ParcelamentosBindingSource.Current(campo)) Then
            ' Define o CheckBox como desmarcado se o campo estiver nulo
            checkBox.Checked = False
        Else
            ' Verifica o valor no banco de dados e ajusta o CheckBox de acordo
            Dim valorCampo As String = ParcelamentosBindingSource.Current(campo).ToString()
            If valorCampo = "Checked" Then
                checkBox.Checked = True
            ElseIf valorCampo = "Unchecked" Then
                checkBox.Checked = False
            Else
                ' Caso não esteja em um dos formatos esperados, define como falso para segurança
                checkBox.Checked = False
            End If
        End If
    End Sub



    Private Sub CarregarComboBoxes()
        ' Carregar RazaoSocialComboBox com Razão Social
        Me.RazaoSocialComboBox.DataSource = Me.ParcelamentosBindingSource
        Me.RazaoSocialComboBox.DisplayMember = "RazaoSocial" ' Nome da coluna da Razão Social
        Me.RazaoSocialComboBox.ValueMember = "ID_Parcelamentos" ' Valor da chave primária ou identificador único

        ' Carregar CNPJComboBox com CNPJ
        Me.CNPJComboBox.DataSource = Me.ParcelamentosBindingSource
        Me.CNPJComboBox.DisplayMember = "CNPJ" ' Nome da coluna do CNPJ
        Me.CNPJComboBox.ValueMember = "ID_Parcelamentos" ' Valor da chave primária ou identificador único
    End Sub



    ' Ativa ou desativa os controles de edição
    Private Sub EditarDesativado()
        BtnEditar.Text = "Editar"
        RazaoSocialTextBox.ReadOnly = True
        CNPJMaskedTextBox.ReadOnly = True
        DataCriacaoDateTimePicker.Enabled = False
        DataLembreteDateTimePicker.Enabled = False
        DataEnvioDateTimePicker.Enabled = False
        ObservacaoRichTextBox.ReadOnly = True
        RuaTextBox.ReadOnly = True
        ComplementoTextBox.ReadOnly = True
        NumeroTextBox.ReadOnly = True
        BairroTextBox.ReadOnly = True
        CidadeTextBox.ReadOnly = True
        EstadoTextBox.ReadOnly = True
        FormaEnvioComboBox.Enabled = False
        WhatsAppTextBox.ReadOnly = True
        EmailTextBox.ReadOnly = True
        SocioResponsavelTextBox.ReadOnly = True
        CPFsocioResponsavelMaskedTextBox.ReadOnly = True
        GovSenhaMaskedTextBox.ReadOnly = True
        NomeResponsavelTextBox.ReadOnly = True
        FinalizadoParcelamentoComboBox.Enabled = False
    End Sub

    Private Sub EditarAtivado()
        BtnEditar.Text = "Cancelar"
        RazaoSocialTextBox.ReadOnly = False
        CNPJMaskedTextBox.ReadOnly = False
        DataCriacaoDateTimePicker.Enabled = True
        DataLembreteDateTimePicker.Enabled = True
        DataEnvioDateTimePicker.Enabled = True
        ObservacaoRichTextBox.ReadOnly = False
        RuaTextBox.ReadOnly = False
        ComplementoTextBox.ReadOnly = False
        NumeroTextBox.ReadOnly = False
        BairroTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        EstadoTextBox.ReadOnly = False
        FormaEnvioComboBox.Enabled = False
        WhatsAppTextBox.ReadOnly = False
        EmailTextBox.ReadOnly = False
        SocioResponsavelTextBox.ReadOnly = False
        CPFsocioResponsavelMaskedTextBox.ReadOnly = False
        GovSenhaMaskedTextBox.ReadOnly = False
        NomeResponsavelTextBox.ReadOnly = False
        FinalizadoParcelamentoComboBox.Enabled = True
    End Sub

    ' Fecha o formulário
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    ' Exclui o registro atual com confirmação
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            ' Confirmação de exclusão
            Dim confirmResult As DialogResult = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmar Exclusão", MessageBoxButtons.YesNo)

            If confirmResult = DialogResult.Yes Then
                ' Remove o registro atual do BindingSource
                ParcelamentosBindingSource.RemoveCurrent()

                ' Salva as alterações no banco de dados usando o TableAdapter
                Me.ParcelamentosTableAdapter.Update(Me.PrinceDBDataSet.Parcelamentos)

                MessageBox.Show("Registro excluído com sucesso.")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o registro: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmParcelamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Valida e finaliza a edição antes de verificar alterações
        Me.Validate()
        Me.ParcelamentosBindingSource.EndEdit()

        ' Verifica novamente se há mudanças no DataSet
        If Me.PrinceDBDataSet.HasChanges() Then
            Dim confirmCloseSave As DialogResult = MessageBox.Show("Deseja salvar as alterações antes de sair?", "Salvar Alterações", MessageBoxButtons.YesNoCancel)
            If confirmCloseSave = DialogResult.Yes Then
                Salvar() ' Chama o método para salvar as alterações
            ElseIf confirmCloseSave = DialogResult.Cancel Then
                e.Cancel = True ' Cancela o fechamento do formulário
            End If
        End If
    End Sub

    Private Sub Salvar()
        Try
            ' Configuração das datas para salvar como NULL se estiverem "em branco" (com a data mínima)
            If DataEnvioDateTimePicker.Value = DataEnvioDateTimePicker.MinDate Then
                CType(ParcelamentosBindingSource.Current, DataRowView)("DataEnvio") = DBNull.Value
            Else
                CType(ParcelamentosBindingSource.Current, DataRowView)("DataEnvio") = DataEnvioDateTimePicker.Value
            End If

            If DataLembreteDateTimePicker.Value = DataLembreteDateTimePicker.MinDate Then
                CType(ParcelamentosBindingSource.Current, DataRowView)("DataLembrete") = DBNull.Value
            Else
                CType(ParcelamentosBindingSource.Current, DataRowView)("DataLembrete") = DataLembreteDateTimePicker.Value
            End If

            ' Força a atualização dos controles vinculados
            Me.Validate()
            Me.ParcelamentosBindingSource.EndEdit()

            ' Verifica se ainda há mudanças no DataSet
            If Me.PrinceDBDataSet.HasChanges() Then
                Dim confirmSave As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Confirmar Salvar", MessageBoxButtons.YesNo)
                If confirmSave = DialogResult.Yes Then
                    ' Salva todas as mudanças
                    Dim totalChanges As Integer = Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
                    MessageBox.Show($"Alterações salvas com sucesso. Total de alterações: {totalChanges}", "Salvo com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Retorna ao modo de visualização e desativa a edição
                    EditarDesativado()
                Else
                    MessageBox.Show("Alterações não foram salvas.", "Salvar Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Nenhuma alteração foi realizada.", "Sem Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar as alterações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Botão para chamar o método de salvar
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub

    ' Alterna entre edição e cancelamento
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If BtnEditar.Text = "Editar" Then
            EditarAtivado()
        Else
            Dim cancelEdit As DialogResult = MessageBox.Show("Tem certeza de que deseja cancelar as alterações?", "Cancelar Edição", MessageBoxButtons.YesNo)
            If cancelEdit = DialogResult.Yes Then
                ParcelamentosBindingSource.CancelEdit() ' Cancela as alterações
                EditarDesativado()
            End If
        End If
    End Sub

    ' Cria um novo registro com confirmação
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Dim confirmNew As DialogResult = MessageBox.Show("Deseja criar um novo registro?", "Novo Registro", MessageBoxButtons.YesNo)
        If confirmNew = DialogResult.Yes Then
            ParcelamentosBindingSource.AddNew()

            ' Define a data atual no campo DataCriacaoDateTimePicker
            DataCriacaoDateTimePicker.Value = DateTime.Now

            ' Ativa o modo de edição para o novo registro
            EditarAtivado()

            RazaoSocialTextBox.Focus()

            ' Opcional: define um valor padrão, caso necessário
            FinalizadoParcelamentoComboBox.SelectedIndex = 0

            ' Desmarca as CheckBoxes
            INSSAntigoCheckBox.Checked = False
            INSSNovoCheckBox.Checked = False
            INSSProcuradoriaCheckBox.Checked = False
            MEICheckBox.Checked = False


        End If
    End Sub


    ' Salva as alterações ao fechar o formulário, se houver mudanças



    ' No FrmParcelamento, ao clicar no botão para abrir o FrmDetalhesParcelamento
    ' Construtor do FrmParcelamentos com parâmetro EmpresaID
    ' Construtor do FrmParcelamentos que recebe o ID da empresa

    ' Variável para armazenar o ID da empresa passada ao formulário

    Public Sub New(empresaID As Integer)
        InitializeComponent()
        Me.EmpresaID = empresaID
    End Sub

    Private Sub BtnVerDetalhesParcelamento_Click(sender As Object, e As EventArgs) Handles BtnVerDetalhesParcelamento.Click
        ' Obtém o ID_Parcelamentos do BindingSource
        Dim empresaID As Integer = CType(Me.ParcelamentosBindingSource.Current, DataRowView)("ID_Parcelamentos")

        ' Verificar se o parcelamentoID é válido
        If empresaID > 0 Then
            ' Se o ID for válido, abre o formulário de detalhes
            Dim frmDetalhes As New FrmDetalhesParcelamento(empresaID) With {
            .MdiParent = Me.MdiParent ' Define o formulário pai, se necessário
        }
            frmDetalhes.ShowDialog()
            Me.Close()

        Else
            ' Pergunta ao usuário se deseja salvar o novo registro
            Dim result As DialogResult = MessageBox.Show("Este parece ser um novo registro. Deseja salvar antes de continuar?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Se o usuário confirmar, chama o método Salvar()
                Salvar()

                ' Atualiza o ID_Parcelamentos após o salvamento
                empresaID = CType(Me.ParcelamentosBindingSource.Current, DataRowView)("ID_Parcelamentos")

                ' Verifica se o ID foi atualizado corretamente
                If empresaID > 0 Then
                    ' Abre o formulário de detalhes com o novo ID
                    Dim frmDetalhes As New FrmDetalhesParcelamento(empresaID) With {
                    .MdiParent = Me.MdiParent
                }
                    frmDetalhes.ShowDialog()
                    Me.Close()
                Else
                    ' Caso o ID ainda não esteja correto, exibe uma mensagem de erro
                    MessageBox.Show("Erro ao salvar o registro. Por favor, tente novamente.", "Erro de Salvamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub





    ' Configura o DataEnvioDateTimePicker para exibir o campo "vazio"

    Private Sub FrmParcelamentos_BindingContextChanged(sender As Object, e As EventArgs) Handles MyBase.BindingContextChanged
        ConfigurarDataEnvioNulo()
        ConfigurarDatalembreteNulo()
    End Sub

    Private Sub ConfigurarDataEnvioNulo()
        ' Verifica se DataEnvio está nulo ou se a data está em branco
        If DataEnvioDateTimePicker.Value = Nothing OrElse DataEnvioDateTimePicker.Value = DateTime.MinValue Then
            ' Se estiver vazio, exibe espaço em branco e altera a cor do texto
            DataEnvioDateTimePicker.Format = DateTimePickerFormat.Custom
            DataEnvioDateTimePicker.CustomFormat = " " ' Exibe espaço em branco para simular campo vazio
            DataEnvioDateTimePicker.ForeColor = Color.Gray ' Cor do texto em cinza para indicar vazio
        Else
            ' Caso contrário, exibe o formato normal da data
            DataEnvioDateTimePicker.Format = DateTimePickerFormat.Long
            DataEnvioDateTimePicker.ForeColor = Color.Black ' Cor do texto normal
        End If
    End Sub

    Private Sub ConfigurarDatalembreteNulo()
        ' Verifica se DataLembrete está nulo ou se a data está em branco
        If DataLembreteDateTimePicker.Value = Nothing OrElse DataLembreteDateTimePicker.Value = DateTime.MinValue Then
            ' Se estiver vazio, exibe espaço em branco e altera a cor do texto
            DataLembreteDateTimePicker.Format = DateTimePickerFormat.Custom
            DataLembreteDateTimePicker.CustomFormat = " " ' Exibe espaço em branco para simular campo vazio
            DataLembreteDateTimePicker.ForeColor = Color.Gray ' Cor do texto em cinza para indicar vazio
        Else
            ' Caso contrário, exibe o formato normal da data
            DataLembreteDateTimePicker.Format = DateTimePickerFormat.Long
            DataLembreteDateTimePicker.ForeColor = Color.Black ' Cor do texto normal
        End If
    End Sub


    ' Evento para detectar quando o usuário seleciona uma data e exibir o formato normal
    Private Sub DataEnvioDateTimePicker_ValueChanged(sender As Object, e As EventArgs)
        DataEnvioDateTimePicker.Format = DateTimePickerFormat.Custom
        DataEnvioDateTimePicker.CustomFormat = "dddd, d 'de' MMMM 'de' yyyy"
        DataEnvioDateTimePicker.ForeColor = Color.Black
        ParcelamentosBindingSource.EndEdit() ' Força a detecção de alteração no campo
    End Sub


    ' Reseta o DataEnvioDateTimePicker para o estado vazio quando perde o foco e o valor é considerado nulo
    Private Sub DataEnvioDateTimePicker_Leave(sender As Object, e As EventArgs)
        ' Verifica se o valor é a data mínima usada para representar "nulo"
        If DataEnvioDateTimePicker.Value = DataEnvioDateTimePicker.MinDate Then
            ConfigurarDataEnvioNulo()
        End If
    End Sub

    ' Função para "limpar" o DataEnvioDateTimePicker manualmente, simulando um valor nulo
    Private Sub LimparDataEnvio()
        DataEnvioDateTimePicker.Value = DataEnvioDateTimePicker.MinDate ' Define como a data mínima ou de referência
        ConfigurarDataEnvioNulo()
    End Sub

    Private Sub BtnImportarSocioAdm_Click(sender As Object, e As EventArgs) Handles BtnImportarSocioAdm.Click
        'verifica se tem NomeResponsavelTextBox preenchido ou abre
        If SocioResponsavelTextBox.Text = "" Then
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
            Else
                FrmSocios.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
                'igual do frmsocios.NomeCompletoComboBox.text
                FrmSocios.NomeCompletoComboBox.Text = SocioResponsavelTextBox.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = SocioResponsavelTextBox.Text
            End If

        End If

    End Sub

    Private Sub ParcelamentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ParcelamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub

    Private Sub BtnDuplicidade_Click(sender As Object, e As EventArgs) Handles BtnDuplicidade.Click
        VerificarDuplicidadeCNPJ(CNPJMaskedTextBox.Text)
    End Sub


    Private Sub VerificarDuplicidadeCNPJ(cnpjOuCpf As String)
        ' Remove a máscara para garantir que o CNPJ ou CPF seja consultado no formato correto
        Dim documentoFormatado As String = cnpjOuCpf '.Replace(".", "").Replace("/", "").Replace("-", "")

        Using connection As New SqlConnection(str)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando duplicidade de CNPJ ou CPF: " & documentoFormatado)

                ' Consulta para verificar o CNPJ ou CPF na tabela "Parcelamentos"
                Dim query As String = "SELECT RazaoSocial FROM Parcelamentos WHERE CNPJ = @Documento"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Documento", documentoFormatado)

                    Dim razaoSocial As Object = cmd.ExecuteScalar()
                    If razaoSocial IsNot Nothing Then
                        ' Documento já existe na tabela Parcelamentos, exibe a razão social
                        MessageBox.Show("Documento já cadastrado na tabela Parcelamentos!" & vbCrLf & vbCrLf &
                                    "CNPJ/CPF: " & documentoFormatado & vbCrLf &
                                    "Nome / Razão Social: " & razaoSocial.ToString())
                    Else
                        ' Caso o documento (CNPJ ou CPF) não exista na tabela
                        MessageBox.Show("Documento não cadastrado na tabela Parcelamentos.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub




    Private Sub ArrumarCNPJ()
        ' Remove caracteres de formatação temporariamente para verificar a quantidade de dígitos

        Dim input As String = CNPJMaskedTextBox.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "").Trim()

        ' Alterna a máscara com base na quantidade de dígitos
        If input.Length = 11 Then
            ' Se for CPF (11 dígitos), muda a máscara para CPF
            CNPJMaskedTextBox.Mask = "000,000,000-00"
            ' CNPJRequerenteMaskedTextBox.Mask = "000,000,000-00"
        ElseIf input.Length = 14 Then
            ' Se for CNPJ (14 dígitos), muda a máscara para CNPJ
            CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
            'CNPJRequerenteMaskedTextBox.Mask = "00,000,000/0000-00"
        Else

        End If
    End Sub

    Private Sub CNPJMaskedTextBox_Validated(sender As Object, e As EventArgs) Handles CNPJMaskedTextBox.Validated
        ArrumarCNPJ()
    End Sub

    Private Sub CNPJMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CNPJMaskedTextBox.TextChanged
        ArrumarCNPJ()
    End Sub

    Private Sub CNPJMaskedTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CNPJMaskedTextBox.Validating
        ArrumarCNPJ()

    End Sub

    Private Sub BtnCopiarCNPJ_Click(sender As Object, e As EventArgs) Handles BtnCopiarCNPJ.Click
        ' Obtém o texto do CNPJMaskedTextBox e remove qualquer caractere que não seja número
        Dim cnpjSomenteNumeros As String = New String(CNPJMaskedTextBox.Text.Where(AddressOf Char.IsDigit).ToArray())

        ' Copia o CNPJ sem máscara para a área de transferência
        If Not String.IsNullOrEmpty(cnpjSomenteNumeros) Then
            Clipboard.SetText(cnpjSomenteNumeros)
            ' MessageBox.Show("CNPJ copiado para a área de transferência: " & cnpjSomenteNumeros, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("CNPJ está vazio ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    '////////////////// forma de envio
    Private Sub WhatsAppTextBox_TextChanged(sender As Object, e As EventArgs) Handles WhatsAppTextBox.TextChanged
        ' Obter o texto do TextBox
        Dim phoneNumber As String = WhatsAppTextBox.Text.Trim()

        ' Remover todos os caracteres não numéricos
        phoneNumber = System.Text.RegularExpressions.Regex.Replace(phoneNumber, "[^\d]", "")

        ' Verificar se o número começa com 55 (código DDI do Brasil)
        If phoneNumber.StartsWith("55") Then
            ' Se o número começar com 55, formate o número conforme necessário
            If phoneNumber.Length > 2 Then
                ' Extrair o DDD (2 dígitos após o 55)
                Dim ddd As String = phoneNumber.Substring(2, 2)
                ' O restante é o número de telefone
                Dim phone As String = phoneNumber.Substring(4)

                ' Verificar se o número tem o tamanho correto (8 ou 9 dígitos)
                If phone.Length >= 8 AndAlso phone.Length <= 9 Then
                    ' Formatar o número corretamente
                    phoneNumber = $"55{ddd}{phone}"
                End If
            End If
        Else
            ' Se o número não começar com 55, avise o usuário para corrigir
            MessageBox.Show("O número precisa começar com 55 para o Brasil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Atualiza o conteúdo do TextBox com o número formatado
        WhatsAppTextBox.Text = phoneNumber
        ' Move o cursor para o final do TextBox após a alteração
        WhatsAppTextBox.SelectionStart = WhatsAppTextBox.Text.Length
    End Sub

    Private Sub BtnAbrirWhatsApp_Click(sender As Object, e As EventArgs) Handles BtnAbrirWhatsApp.Click
        ' Obter o telefone do WhatsAppTextBox
        Dim phoneNumber As String = WhatsAppTextBox.Text.Trim()

        ' Remover todos os caracteres não numéricos (apenas números)
        phoneNumber = System.Text.RegularExpressions.Regex.Replace(phoneNumber, "[^\d]", "")

        ' Verificar se o número tem DDI (55 para Brasil ou outro país)
        If phoneNumber.StartsWith("55") Then
            ' Se o número começar com 55 (Brasil), o código irá tratar
            If phoneNumber.Length > 2 Then
                ' Extrair o DDD (2 dígitos após o 55)
                Dim ddd As String = phoneNumber.Substring(2, 2)
                ' O restante é o número de telefone (pode ser 8 ou 9 dígitos)
                Dim phone As String = phoneNumber.Substring(4)

                ' Verificar se o número tem o tamanho correto (8 ou 9 dígitos)
                If phone.Length >= 8 AndAlso phone.Length <= 9 Then
                    ' Formatar o número corretamente para o Brasil
                    phoneNumber = $"55{ddd}{phone}"
                Else
                    MessageBox.Show("O número de telefone no Brasil deve ter 8 ou 9 dígitos após o DDD.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else
            ' Caso não seja 55 (Brasil), verificar se é DDI de outro país
            If phoneNumber.Length >= 10 Then
                ' Validar a estrutura geral do número internacional
                phoneNumber = phoneNumber ' Considera o número completo com DDI
            Else
                MessageBox.Show("Número de telefone inválido. Verifique o DDI e o número.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        ' Verificar se o número está vazio ou inválido
        If String.IsNullOrEmpty(phoneNumber) OrElse phoneNumber.Length < 10 Then
            MessageBox.Show("Número de telefone inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Montar o link do WhatsApp
        Dim whatsappLink As String = $"https://wa.me/{phoneNumber}"

        ' Abrir o WhatsApp com o número formatado
        Try
            System.Diagnostics.Process.Start(whatsappLink)
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o WhatsApp: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAbriremail_Click(sender As Object, e As EventArgs) Handles BtnAbriremail.Click
        ' Obter o endereço de e-mail do EmailTextBox
        Dim email As String = EmailTextBox.Text.Trim()

        ' Verifica se o e-mail não está vazio
        If Not String.IsNullOrEmpty(email) Then
            ' Formatar o e-mail com o prefixo "mailto:"
            Dim mailtoLink As String = "mailto:" & email

            Try
                ' Tentar abrir o cliente de e-mail do sistema
                System.Diagnostics.Process.Start(mailtoLink)
            Catch ex As Exception
                MessageBox.Show("Não foi possível abrir o cliente de e-mail. Verifique se há um cliente de e-mail configurado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnImportaSocio_Click(sender As Object, e As EventArgs) Handles BtnImportaSocio.Click
        TabControlPrincipal.SelectedIndex = 3
        If SocioResponsavelTextBox.Text <> "" Then
            NomeResponsavelTextBox.Text = SocioResponsavelTextBox.Text
        Else
            MessageBox.Show("O campo: Sócio/Responsável está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FinalizadoParcelamentoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoParcelamentoComboBox.SelectedIndexChanged
        ' Define os estados para cada grupo de cor
        Dim estadosVerde As String() = {"Em Andamento", "Finalizado"}
        Dim estadosVermelho As String() = {"Em Construção", "Não Realizado", "Cancelado", "Indeferido"}

        ' Ajusta as cores conforme o grupo do valor selecionado
        If estadosVerde.Contains(FinalizadoParcelamentoComboBox.Text) Then
            FinalizadoParcelamentoComboBox.BackColor = Color.Green
            FinalizadoParcelamentoComboBox.ForeColor = Color.White
        ElseIf estadosVermelho.Contains(FinalizadoParcelamentoComboBox.Text) Then
            FinalizadoParcelamentoComboBox.BackColor = Color.Red
            FinalizadoParcelamentoComboBox.ForeColor = Color.White
        Else
            '"Aguardando Parcelar","Aguardando Autorização", "Aguardando Cliente","Para Fazer"
            ' Configura as cores padrão para qualquer outro valor
            FinalizadoParcelamentoComboBox.BackColor = SystemColors.Window
            FinalizadoParcelamentoComboBox.ForeColor = SystemColors.WindowText
        End If
    End Sub



    Private Sub BtnBImportarEmpresa_Click(sender As Object, e As EventArgs) Handles BtnBImportarEmpresa.Click
        ' Pergunta ao usuário se ele deseja realmente importar os dados
        Dim resposta As DialogResult = MessageBox.Show("Deseja importar os dados da empresa?", "Confirmação de Importação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Se o usuário selecionar "Não", sai do método
        If resposta = DialogResult.No Then
            Exit Sub
        End If

        ' Define a string de conexão
        Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

        ' Abre a conexão com o banco de dados
        Using conn As New SqlConnection(str)
            Try
                conn.Open()

                ' Obtém o CNPJ a ser pesquisado
                Dim cnpj As String = CNPJMaskedTextBox.Text

                ' Cria o comando SQL para buscar a empresa pelo CNPJ
                Dim query As String = "SELECT RazaoSocial, CNPJ, NomeResponsavel, CPFResponsavel, SenhaGov, Endereco, EndNumero, EndBairro, EndComplemento, EndCEP, EndCidade, EndEstado " &
                                      "FROM Empresas WHERE CNPJ = @CNPJ"

                Using cmd As New SqlCommand(query, conn)
                    ' Adiciona o parâmetro CNPJ à consulta
                    cmd.Parameters.AddWithValue("@CNPJ", cnpj)

                    ' Executa a consulta e obtém os dados
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            ' Ativa as abas necessárias no TabControl
                            TabControlPrincipal.SelectedIndex = 0
                            TabControlPrincipal.SelectedIndex = 1
                            TabControlPrincipal.SelectedIndex = 2
                            TabControlPrincipal.SelectedIndex = 3

                            ' Se encontrar a empresa, preenche os campos do formulário
                            reader.Read()

                            RazaoSocialTextBox.Text = reader("RazaoSocial").ToString()
                            CNPJMaskedTextBox.Text = reader("CNPJ").ToString()
                            SocioResponsavelTextBox.Text = reader("NomeResponsavel").ToString()
                            CPFsocioResponsavelMaskedTextBox.Text = reader("CPFResponsavel").ToString()
                            GovSenhaMaskedTextBox.Text = reader("SenhaGov").ToString()
                            RuaTextBox.Text = reader("Endereco").ToString()
                            NumeroTextBox.Text = reader("EndNumero").ToString()
                            ComplementoTextBox.Text = reader("EndComplemento").ToString()
                            BairroTextBox.Text = reader("EndBairro").ToString()
                            CidadeTextBox.Text = reader("EndCidade").ToString()
                            EstadoTextBox.Text = reader("EndEstado").ToString()

                            TabControlPrincipal.SelectedIndex = 0
                            ' Exibe mensagem de sucesso após a importação
                            MessageBox.Show("Dados importados com sucesso!", "Importação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else
                            ' Se não encontrar, exibe uma mensagem de erro
                            MessageBox.Show("Empresa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            FrmLegalizacao.Show()
                            FrmLegalizacao.BtnNovo.PerformClick()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Em caso de erro, exibe a mensagem de erro
                MessageBox.Show("Erro ao conectar com o banco de dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub


End Class

