Public Class FrmParcelamentos

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
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)

        EditarAtivado()
        ConfigurarDataEnvioNulo() ' Inicializa a exibição do DataEnvioDateTimePicker como "vazio"

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
        RazaoSocialTextBox.ReadOnly = True
        CNPJMaskedTextBox.ReadOnly = True
        DataCriacaoMaskedTextBox.ReadOnly = True
        DataLembreteMaskedTextBox.ReadOnly = True
        ObservacaoRichTextBox.ReadOnly = True
        BtnEditar.Text = "Editar"
    End Sub

    Private Sub EditarAtivado()
        RazaoSocialTextBox.ReadOnly = False
        CNPJMaskedTextBox.ReadOnly = False
        DataCriacaoMaskedTextBox.ReadOnly = False
        DataLembreteMaskedTextBox.ReadOnly = False
        ObservacaoRichTextBox.ReadOnly = False
        BtnEditar.Text = "Cancelar"
    End Sub

    ' Fecha o formulário
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    ' Exclui o registro atual com confirmação
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmar Exclusão", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            ' Lógica para excluir o registro
            ' Exemplo: ParcelamentosBindingSource.RemoveCurrent()
            MessageBox.Show("Registro excluído com sucesso.")
        End If
    End Sub

    ' Salva as alterações no banco de dados
    Private Sub Salvar()
        Try
            ' Verifica se DataEnvioDateTimePicker está com a data mínima (representando "nulo")
            If DataEnvioDateTimePicker.Value = DataEnvioDateTimePicker.MinDate Then
                ' Define o valor do campo DataEnvio como DBNull, para salvar como NULL no banco de dados
                CType(ParcelamentosBindingSource.Current, DataRowView)("DataEnvio") = DBNull.Value
            Else
                ' Caso contrário, salva o valor da data normalmente
                CType(ParcelamentosBindingSource.Current, DataRowView)("DataEnvio") = DataEnvioDateTimePicker.Value
            End If

            ' Força a atualização dos controles vinculados para garantir que todas as edições pendentes sejam aplicadas
            Me.Validate()
            Me.ParcelamentosBindingSource.EndEdit()

            ' Verifica se há mudanças no DataSet
            If Me.PrinceDBDataSet.HasChanges() Then
                ' Pergunta ao usuário se deseja ver as alterações realizadas
                Dim confirmSave As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Confirmar Salvar", MessageBoxButtons.YesNo)
                If confirmSave = DialogResult.Yes Then
                    ' Salva as mudanças
                    Dim totalChanges As Integer = Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
                    MessageBox.Show($"Alterações salvas com sucesso. Total de alterações: {totalChanges}")

                    ' Retorna ao modo de visualização e desativa a edição
                    EditarDesativado()
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

    Private Sub SalvarBACKUP()
        Try
            ' Força a atualização dos controles vinculados para garantir que todas as edições pendentes sejam aplicadas
            Me.Validate()
            Me.ParcelamentosBindingSource.EndEdit()

            ' Verifica se há mudanças no DataSet
            If Me.PrinceDBDataSet.HasChanges() Then
                ' Pergunta ao usuário se deseja ver as alterações realizadas
                Dim confirmViewChanges As DialogResult = MessageBox.Show("Deseja ver todas as alterações realizadas?", "Visualizar Alterações", MessageBoxButtons.YesNo)

                If confirmViewChanges = DialogResult.Yes Then
                    ' Obtém as mudanças e cria uma lista das alterações realizadas
                    Dim changes As DataSet = Me.PrinceDBDataSet.GetChanges()
                    Dim changesSummary As String = "Alterações feitas:" & vbCrLf

                    ' Percorre as tabelas e registra as alterações
                    For Each table As DataTable In changes.Tables
                        For Each row As DataRow In table.Rows
                            If row.RowState = DataRowState.Modified Then
                                changesSummary &= $"Modificado: {String.Join(", ", row.ItemArray)}" & vbCrLf
                            ElseIf row.RowState = DataRowState.Added Then
                                changesSummary &= $"Adicionado: {String.Join(", ", row.ItemArray)}" & vbCrLf
                            ElseIf row.RowState = DataRowState.Deleted Then
                                changesSummary &= $"Excluído: {String.Join(", ", row.ItemArray)}" & vbCrLf
                            End If
                        Next
                    Next

                    ' Exibe a mensagem com o resumo das alterações
                    MessageBox.Show(changesSummary, "Alterações Realizadas")
                End If

                ' Pergunta se o usuário deseja salvar as alterações
                Dim confirmSave As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Confirmar Salvar", MessageBoxButtons.YesNo)
                If confirmSave = DialogResult.Yes Then
                    ' Salva as mudanças
                    Dim totalChanges As Integer = Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
                    MessageBox.Show($"Alterações salvas com sucesso. Total de alterações: {totalChanges}")

                    ' Retorna ao modo de visualização e desativa a edição
                    EditarDesativado()
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
            EditarAtivado() ' Ativa o modo de edição para o novo registro
        End If
    End Sub

    ' Salva as alterações ao fechar o formulário, se houver mudanças
    Private Sub FrmParcelamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.PrinceDBDataSet.HasChanges() Then
            Dim confirmCloseSave As DialogResult = MessageBox.Show("Deseja salvar as alterações antes de sair?", "Salvar Alterações", MessageBoxButtons.YesNoCancel)
            If confirmCloseSave = DialogResult.Yes Then
                Salvar()
            ElseIf confirmCloseSave = DialogResult.Cancel Then
                e.Cancel = True ' Cancela o fechamento do formulário
            End If
        End If
    End Sub

    Private Sub DataCriacaoMaskedTextBox_Click(sender As Object, e As EventArgs) Handles DataCriacaoMaskedTextBox.Click
        DialogCalendarioParcelamento.campoDestino = DataCriacaoMaskedTextBox
        MostraCalendario()
    End Sub

    Private Sub DataCriacaoMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles DataCriacaoMaskedTextBox.Leave
        DialogCalendarioParcelamento.Close()
    End Sub

    Private Sub DataLembreteMaskedTextBox_Click(sender As Object, e As EventArgs) Handles DataLembreteMaskedTextBox.Click
        DialogCalendarioParcelamento.campoDestino = DataLembreteMaskedTextBox
        MostraCalendario()
    End Sub

    Private Sub DataLembreteMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles DataLembreteMaskedTextBox.Leave
        DialogCalendarioParcelamento.Close()

    End Sub

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
        Dim parcelamentoID As Integer = CType(Me.ParcelamentosBindingSource.Current, DataRowView)("ID_Parcelamentos")

        ' Verifique se parcelamentoID é válido
        If parcelamentoID > 0 Then
            ' Abra o formulário de detalhes com o ID do parcelamento
            Dim frmDetalhes As New FrmDetalhesParcelamento(parcelamentoID) With {
                .MdiParent = Me.MdiParent ' Define o formulário pai, se necessário
                }
            frmDetalhes.Show()
        Else
            MessageBox.Show("Nenhum parcelamento válido selecionado.")
        End If
    End Sub



    ' Configura o DataEnvioDateTimePicker para exibir o campo "vazio"
    Private Sub ConfigurarDataEnvioNulo()
        DataEnvioDateTimePicker.Format = DateTimePickerFormat.Custom
        DataEnvioDateTimePicker.CustomFormat = " " ' Exibe espaço em branco para simular campo vazio
        DataEnvioDateTimePicker.ForeColor = Color.Gray ' Cor do texto em cinza para indicar vazio
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



End Class
