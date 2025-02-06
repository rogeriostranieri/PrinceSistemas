Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Text
Imports System
Imports System.Drawing
Imports System.Linq



Public Class FrmParcelamento
    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub FrmParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os dados da tabela Parcelamentos
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)

        ' Forçar a aceitação das alterações e garantir que o DataSet está atualizado
        PrinceDBDataSet.AcceptChanges()

        ' Permitir edições em todas as colunas da tabela Parcelamentos
        For Each col As DataColumn In Me.PrinceDBDataSet.Parcelamentos.Columns
            col.ReadOnly = False
        Next


        ' Se estiver em modo de edição, cancelar as alterações
        ParcelamentosBindingSource.CancelEdit()
        BloqueiaTudo() ' Bloqueia os campos novamente
        BtnEditar.Text = "Editar" ' Muda o texto do botão para "Editar"


        ' Vincula o evento CurrentChanged do BindingSource para detectar mudanças na empresa
        AddHandler ParcelamentosBindingSource.CurrentChanged, AddressOf ParcelamentosBindingSource_CurrentChanged

    End Sub
    Private Sub ParcelamentosBindingSource_CurrentChanged(sender As Object, e As EventArgs)
        VerificaAbaChecked()
    End Sub


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Salvar()
        Me.ParcelamentosBindingSource.AddNew() ' Adiciona um novo registro
        DesBloqueiaTudo() ' Habilita os campos para edição
        BtnEditar.Enabled = True ' Desabilita o botão Editar enquanto está no modo Novo
        MEICheckBox.CheckState = CheckState.Unchecked
        InssAntigoCheckBox.CheckState = CheckState.Unchecked
        InssNovoCheckBox.CheckState = CheckState.Unchecked
        InssProcurCheckBox.CheckState = CheckState.Unchecked
        ParaFazerCheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub


    '//////////////////////// SALVAR /////////////////////////////////////////////////////
    ' Variável para controlar o fechamento do formulário
    Private cancelarFechamento As Boolean = False

    Private Sub salvar()
        ' Finaliza a edição dos dados vinculados ao BindingSource
        Me.ParcelamentosBindingSource.EndEdit()

        ' Obtém as alterações feitas na tabela Parcelamentos
        Dim changedRecords As DataTable = PrinceDBDataSet.Parcelamentos.GetChanges()

        ' Verifica se há alterações
        If changedRecords IsNot Nothing Then
            ' Exibe as alterações para o usuário
            Dim changes As String = "As seguintes alterações foram feitas:" & Environment.NewLine

            For Each row As DataRow In changedRecords.Rows
                Select Case row.RowState
                    Case DataRowState.Added
                        changes &= "Registro Adicionado: " & String.Join(", ", row.ItemArray) & Environment.NewLine
                    Case DataRowState.Modified
                        changes &= "Registro Modificado: " & String.Join(", ", row.ItemArray) & Environment.NewLine
                    Case DataRowState.Deleted
                        changes &= "Registro Excluído" & Environment.NewLine
                End Select
            Next

            ' Pergunta ao usuário se deseja salvar as alterações
            Dim result As DialogResult = MessageBox.Show(changes & Environment.NewLine & "Deseja salvar essas alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    ' Salva as alterações no banco de dados
                    Me.ParcelamentosTableAdapter.Update(PrinceDBDataSet.Parcelamentos)

                    ' Aceita as alterações feitas
                    PrinceDBDataSet.Parcelamentos.AcceptChanges()

                    ' Mensagem de confirmação
                    MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnEditar.PerformClick()
                    AtualizarFiltro()
                Catch ex As Exception
                    ' Trata erros durante o salvamento
                    MessageBox.Show("Erro ao salvar as alterações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ' Rejeita as alterações se o usuário optar por não salvar
                PrinceDBDataSet.Parcelamentos.RejectChanges()
                MessageBox.Show("Alterações descartadas.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AtualizarFiltro()
            End If
        Else
            ' Mensagem caso não haja alterações
            MessageBox.Show("Nenhuma alteração foi feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub BackupSalvar()
        Try
            ' Finalizar edição e obter registros alterados
            Me.ParcelamentosBindingSource.EndEdit()
            Dim changedRecords As DataTable = PrinceDBDataSet.Parcelamentos.GetChanges()

            ' Verificar se há alterações para salvar
            If changedRecords IsNot Nothing AndAlso changedRecords.Rows.Count > 0 Then
                Dim changesDescription As New StringBuilder()
                Dim detailedChanges As New StringBuilder()

                ' Iterar sobre as linhas alteradas para gerar um resumo
                For Each row As DataRow In changedRecords.Rows
                    Dim columnChangesCount As Integer = 0
                    changesDescription.AppendLine($"Alterações na linha com ID: {row("ID_Parcel")}")

                    For Each column As DataColumn In changedRecords.Columns
                        ' Verificar mudanças para linhas não adicionadas
                        If row.RowState <> DataRowState.Added Then
                            Dim originalValue = row(column, DataRowVersion.Original)?.ToString()
                            Dim currentValue = row(column, DataRowVersion.Current)?.ToString()

                            If originalValue <> currentValue Then
                                columnChangesCount += 1
                                detailedChanges.AppendLine($"  - {column.ColumnName}: {originalValue} => {currentValue}")
                            End If
                        Else
                            ' Para novas linhas
                            columnChangesCount += 1
                            detailedChanges.AppendLine($"  - {column.ColumnName}: Novo valor: {row(column, DataRowVersion.Current)?.ToString()}")
                        End If
                    Next

                    changesDescription.AppendLine($"  ({columnChangesCount} mudanças)")
                Next

                ' Perguntar ao usuário se deseja ver detalhes
                If MessageBox.Show("Deseja ver os detalhes das alterações?", "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    MessageBox.Show(detailedChanges.ToString(), "Detalhes das Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Exibir resumo das alterações e perguntar se deseja salvar
                Dim message As String = $"Foram feitas {changedRecords.Rows.Count} alterações.{vbCrLf}Deseja salvar as alterações?{vbCrLf}{vbCrLf}{changesDescription}"
                Dim result As DialogResult = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

                Select Case result
                    Case DialogResult.Cancel
                        ' Não faz nada, permite o retorno ao formulário
                        Exit Sub

                    Case DialogResult.No
                        ' Rejeitar alterações e atualizar interface
                        PrinceDBDataSet.Parcelamentos.RejectChanges()
                        AtualizarInterfaceAposRejeitar()

                    Case DialogResult.Yes
                        ' Salvar as alterações
                        SalvarAlteracoes(changedRecords)
                End Select
            Else
                ' Não há alterações
                MessageBox.Show("Nenhuma alteração foi detectada para salvar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AtualizarInterfaceAposRejeitar()
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocorreu um erro ao salvar:{vbCrLf}{ex.Message}", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' Método para salvar alterações e exibir ProgressBar
    Private Sub SalvarAlteracoes(changedRecords As DataTable)
        Try
            ' Exibir ProgressBar
            ProgressBarSalvar.Visible = True
            ProgressBarSalvar.Value = 0
            ProgressBarSalvar.Style = ProgressBarStyle.Marquee

            ' Validar alterações
            Me.Validate()

            ' Salvar alterações no banco de dados
            Dim rowsAffected As Integer = Me.ParcelamentosTableAdapter.Update(changedRecords)

            ' Mensagens de feedback
            If rowsAffected > 0 Then
                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhuma alteração foi salva. Verifique os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Finalizar ProgressBar
            ProgressBarSalvar.Style = ProgressBarStyle.Blocks
            ProgressBarSalvar.Value = 100
            ProgressBarSalvar.Visible = False

            ' Aceitar mudanças no DataSet
            PrinceDBDataSet.Parcelamentos.AcceptChanges()

            ' Atualizar interface após salvar
            AtualizarInterfaceAposSalvar()
        Catch ex As Exception
            ProgressBarSalvar.Visible = False
            MessageBox.Show($"Erro ao salvar alterações:{vbCrLf}{ex.Message}", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    ' Atualiza interface após rejeitar mudanças
    Private Sub AtualizarInterfaceAposRejeitar()
        BtnEditar.Text = "Editar"
        BtnExcluir.Enabled = True
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)
        cancelarFechamento = False
    End Sub

    ' Atualiza interface após salvar com sucesso
    Private Sub AtualizarInterfaceAposSalvar()
        BtnEditar.Text = "Editar"
        BtnExcluir.Enabled = True
        cancelarFechamento = False
    End Sub


    '//////////////////////////////////////////////////

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If BtnEditar.Text = "Editar" Then
            ' Se não estiver em modo de edição, entrar no modo de edição
            DesBloqueiaTudo() ' Habilita os campos para edição
            BtnEditar.Text = "Cancelar" ' Muda o texto do botão para "Cancelar"

        Else
            ' Se estiver em modo de edição, cancelar as alterações
            ParcelamentosBindingSource.CancelEdit()
            BloqueiaTudo() ' Bloqueia os campos novamente
            BtnEditar.Text = "Editar" ' Muda o texto do botão para "Editar"

        End If
    End Sub

    Private Sub BloqueiaTudo()
        TabControlGeral.Enabled = False
        TabControlParcelamento.Enabled = False
        BtnSalvar.Enabled = False
        BtnExcluir.Enabled = True
        BtnEditar.Text = "Editar"
        BtnEditar.Enabled = True
    End Sub

    Private Sub DesBloqueiaTudo()
        TabControlGeral.Enabled = True
        TabControlParcelamento.Enabled = True
        BtnSalvar.Enabled = True
        BtnExcluir.Enabled = False
        BtnEditar.Text = "Cancelar"
        BtnEditar.Enabled = True
    End Sub



    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MessageBox.Show("Deseja realmente excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Me.ParcelamentosBindingSource.RemoveCurrent() ' Remove o registro atual
                Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
                MessageBox.Show("Registro excluído com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        ' Verifica se há alterações na tabela específica associada ao formulário
        If Me.PrinceDBDataSet.Parcelamentos.GetChanges() IsNot Nothing Then
            If MessageBox.Show("Há alterações não salvas na tabela atual. Deseja salvar antes de sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                BtnSalvar.PerformClick() ' Chama o evento do botão Salvar
            End If
        End If
        Me.Close() ' Fecha o formulário
    End Sub



    Private Sub FinalizadoEmpresaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoEmpresaComboBox.SelectedIndexChanged
        ' Verifica se a seleção é "Sim"
        If FinalizadoEmpresaComboBox.Text = "Sim" Then
            ' Torna visíveis o rótulo e o campo de data
            LabelDataFinalizado.Visible = True
            DataFinalizadoMaskedTextBox.Visible = True
            LinkLabelAgoraFinal.Visible = True

            ' Solicita confirmação antes de desmarcar os CheckBoxes
            Dim confirmResult As DialogResult = MessageBox.Show(
            "Você tem certeza de que deseja finalizar e desmarcar todas as opções?",
            "Confirmação de Finalização",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If confirmResult = DialogResult.Yes Then
                ' Desmarca todos os CheckBoxes
                MEICheckBox.CheckState = CheckState.Unchecked
                InssAntigoCheckBox.CheckState = CheckState.Unchecked
                InssNovoCheckBox.CheckState = CheckState.Unchecked
                InssProcurCheckBox.CheckState = CheckState.Unchecked
                ParaFazerCheckBox.CheckState = CheckState.Unchecked
            Else
                ' Reverte o ComboBox para o estado anterior
                FinalizadoEmpresaComboBox.SelectedIndex = -1
            End If

        Else
            ' Oculta o rótulo e o campo de data se "Sim" não for selecionado
            LabelDataFinalizado.Visible = False
            DataFinalizadoMaskedTextBox.Visible = False
            LinkLabelAgoraFinal.Visible = False
        End If
    End Sub


    Private Sub FinalizadoMEIComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoMEIComboBox.SelectedIndexChanged
        If FinalizadoMEIComboBox.Text = "Sim" Then
            LblFinalizadoDataMEI.Visible = True
            DataFinalMEIMaskedTextBox.Visible = True
            LabelMotivoMEI.Visible = True
            MotivoMEIRichTextBox.Visible = True
        Else
            LblFinalizadoDataMEI.Visible = False
            DataFinalMEIMaskedTextBox.Visible = False
            LabelMotivoMEI.Visible = False
            MotivoMEIRichTextBox.Visible = False
        End If
    End Sub

    Private Sub FinalizadoINSSAntComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSAntComboBox.SelectedIndexChanged
        If FinalizadoINSSAntComboBox.Text = "Sim" Then
            LblFinalizadoDataINSSAntigo.Visible = True
            DataFinalAntigoMaskedTextBox.Visible = True
            LabelMotivoINSSAntigo.Visible = True
            MotivoAntigoRichTextBox.Visible = True
        Else
            LblFinalizadoDataINSSAntigo.Visible = False
            DataFinalAntigoMaskedTextBox.Visible = False
            LabelMotivoINSSAntigo.Visible = False
            MotivoAntigoRichTextBox.Visible = False
        End If
    End Sub

    Private Sub FinalizadoINSSNovComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSNovComboBox.SelectedIndexChanged
        If FinalizadoINSSNovComboBox.Text = "Sim" Then
            LblFinalizadoDataINSSNovo.Visible = True
            DataFinalNovoMaskedTextBox.Visible = True
            LabelMotivoINSSNovo.Visible = True
            MotivoNovoRichTextBox.Visible = True
        Else
            LblFinalizadoDataINSSNovo.Visible = False
            DataFinalNovoMaskedTextBox.Visible = False
            LabelMotivoINSSNovo.Visible = False
            MotivoNovoRichTextBox.Visible = False
        End If
    End Sub

    Private Sub FinalizadoINSSProcComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoINSSProcComboBox.SelectedIndexChanged
        If FinalizadoINSSProcComboBox.Text = "Sim" Then
            LblFinalizadoDataINSSProcuradoria.Visible = True
            DataFinalProcMaskedTextBox.Visible = True
            LabelMotivoINSSProc.Visible = True
            MotivoProcRichTextBox.Visible = True
        Else
            LblFinalizadoDataINSSProcuradoria.Visible = False
            DataFinalProcMaskedTextBox.Visible = False
            LabelMotivoINSSProc.Visible = False
            MotivoProcRichTextBox.Visible = False
        End If
    End Sub


    Private Sub BtnAgoraMEI_Click(sender As Object, e As EventArgs) Handles BtnAgoraMEI.Click
        ' Define a data e hora atuais para o campo DataEnviaMEIMaskedTextBox
        DataEnviaMEIMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub BtnAgoraINSSAntigo_Click(sender As Object, e As EventArgs) Handles BtnAgoraINSSAntigo.Click
        ' Define a data e hora atuais para o campo DataEnviaAntigoMaskedTextBox
        DataEnviaAntigoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub BtnAgoraINSSNovo_Click(sender As Object, e As EventArgs) Handles BtnAgoraINSSNovo.Click
        ' Define a data e hora atuais para o campo DataEnvioNovoMaskedTextBox
        DataEnvioNovoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub BtnAgoraINSSProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnAgoraINSSProcuradoria.Click
        ' Define a data e hora atuais para o campo DataEnvioProcuradoriaMaskedTextBox
        DataEnviaProcMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub


    Private Sub BtnRegistrarMEI_Click(sender As Object, e As EventArgs) Handles BtnRegistrarMEI.Click
        AbrirEscolhaParcelamentoEnvio()

    End Sub

    Private Sub BtnRegistrarINSSAntigo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSAntigo.Click
        AbrirEscolhaParcelamentoEnvio()

    End Sub

    Private Sub BtnRegistrarINSSNovo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSNovo.Click
        AbrirEscolhaParcelamentoEnvio()
    End Sub

    Private Sub BtnRegistrarINSSProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSProcuradoria.Click
        AbrirEscolhaParcelamentoEnvio()

    End Sub

    Private Sub BtnCopiarCNPJ_Click(sender As Object, e As EventArgs) Handles BtnCopiarCNPJ.Click
        Try
            Dim CNPJ As String = CNPJMaskedTextBox.Text
            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        ' Inicializar a ProgressBar
        ProgressBarSalvar.Value = 0
        ProgressBarSalvar.Visible = True
        ProgressBarSalvar.Maximum = 100
        ProgressBarSalvar.Step = 25
        ProgressBarSalvar.Value = 15

        ' Verificar se o CNPJMaskedTextBox está vazio
        If String.IsNullOrWhiteSpace(CNPJMaskedTextBox.Text) Then
            MessageBox.Show("Por favor, insira um CNPJ válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ProgressBarSalvar.Visible = False
            Return
        End If

        ' Obter o CNPJ formatado
        Dim cnpjFormatado As String = CNPJMaskedTextBox.Text.Trim()

        ' Conexão com o banco de dados
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

        ' Verificar o CNPJ em Parcelamentos
        If VerificarCNPJParcelamento(cnpjFormatado) Then
            ProgressBarSalvar.Value = 100
            MessageBox.Show("CNPJ encontrado na tabela Parcelamentos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBarSalvar.Visible = False
            BtnEditar.PerformClick()
            Return
        End If

        ' Se o CNPJ não foi encontrado em Parcelamentos, verificar na tabela Empresas
        Dim queryImportar As String = "SELECT RazaoSocial, NomeResponsavel, CPFResponsavel, SenhaGov FROM Empresas WHERE CNPJ = @CNPJ"

        Using connection As New SqlClient.SqlConnection(connectionString)
            Using command As New SqlClient.SqlCommand(queryImportar, connection)
                command.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                Try
                    connection.Open()

                    ' Executar a consulta
                    Using reader As SqlClient.SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Atualizar a ProgressBar
                            ProgressBarSalvar.Value = 50

                            ' Preencher os campos com os dados encontrados
                            TabControlGeral.SelectedIndex = -1
                            RazaoSocialTextBox.Text = reader("RazaoSocial").ToString()

                            TabControlGeral.SelectedIndex = 2
                            SocioTextBox.Text = reader("NomeResponsavel").ToString()
                            CPFMaskedTextBox.Text = reader("CPFResponsavel").ToString()
                            SenhaGovTextBox.Text = reader("SenhaGov").ToString()

                            TabControlGeral.SelectedIndex = -1

                            ' Atualizar a ProgressBar
                            ProgressBarSalvar.Value = 100

                            MessageBox.Show("Dados importados com sucesso para um novo cadastro.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' Se o CNPJ não foi encontrado em Parcelamentos nem em Empresas
                            ProgressBarSalvar.Value = 0
                            MessageBox.Show("CNPJ não encontrado na base de dados. Por favor, realize a importação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            ' Verifica se o formulário já está aberto
                            For Each frm As Form In Application.OpenForms
                                If TypeOf frm Is FrmExtraiCNPJ Then
                                    frm.Close() ' Fecha o formulário se ele já estiver aberto
                                    Exit For
                                End If
                            Next

                            ' Abre o formulário
                            FrmExtraiCNPJ.Show()
                        End If
                    End Using
                Catch ex As Exception
                    ProgressBarSalvar.Value = 0
                    MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Function VerificarCNPJParcelamento(cnpj As String) As Boolean
        ' Conexão com o banco de dados
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim queryParcelamento As String = "SELECT COUNT(*) FROM Parcelamentos WHERE CNPJ = @CNPJ"

        Using connection As New SqlClient.SqlConnection(connectionString)
            Using command As New SqlClient.SqlCommand(queryParcelamento, connection)
                command.Parameters.AddWithValue("@CNPJ", cnpj)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0 ' Retorna verdadeiro se encontrou o CNPJ
                Catch ex As Exception
                    MessageBox.Show($"Erro ao verificar o CNPJ em Parcelamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function



    Private Sub BtnDataCriacao_Click(sender As Object, e As EventArgs) Handles BtnDataCriacao.Click
        DataCriacaoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub FormaDeEnvioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FormaDeEnvioComboBox.SelectedIndexChanged

    End Sub

    Private Sub FormaDeEnvioLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FinalizadoMesGeralComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalizadoMesGeralComboBox.SelectedIndexChanged
        MesfechamentoCOR()
    End Sub

    Private Sub FinalizadoMesGeralComboBox_Validated(sender As Object, e As EventArgs) Handles FinalizadoMesGeralComboBox.Validated
        MesfechamentoCOR()
    End Sub


    Private Sub MesfechamentoCOR()
        ' Obter o mês atual por extenso em português (exemplo: "novembro")
        Dim mesAtual As String = DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")).ToLower()

        ' Verificar se há um item selecionado no ComboBox
        If FinalizadoMesGeralComboBox.SelectedItem IsNot Nothing Then
            ' Obter o texto do item selecionado e converter para minúsculas para comparação
            Dim mesSelecionado As String = FinalizadoMesGeralComboBox.SelectedItem.ToString().Trim().ToLower()

            ' Verificar se o mês selecionado é o mesmo que o mês atual
            If mesSelecionado = mesAtual Then
                ' Se for igual ao mês atual, mudar o fundo para verde
                FinalizadoMesGeralComboBox.BackColor = Color.Green
            Else
                ' Se for diferente, mudar o fundo para amarelo
                FinalizadoMesGeralComboBox.BackColor = Color.Yellow
            End If
        Else
            ' Caso não haja item selecionado, você pode exibir uma mensagem ou lidar com a situação como necessário
            MessageBox.Show("Nenhum mês selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    '/////////////////////////////////////////////

    Private Sub FrmParcelamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            ' Finalizar a edição e verificar se há alterações
            Me.ParcelamentosBindingSource.EndEdit()

            ' Verificar se há alterações no DataSet (ou no DataTable associado ao BindingSource)
            If Me.PrinceDBDataSet.HasChanges Then
                ' Perguntar ao usuário se deseja salvar as alterações
                Dim result As DialogResult = MessageBox.Show("Você tem alterações não salvas. Deseja salvar antes de fechar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Chamar o método Salvar se o usuário escolher 'Sim'
                    Salvar()
                ElseIf result = DialogResult.No Then
                    ' Descartar alterações
                    Me.ParcelamentosBindingSource.CancelEdit()
                ElseIf result = DialogResult.Cancel Then
                    ' Cancelar o fechamento do formulário se o usuário escolher 'Cancelar'
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            ' Tratamento de erros
            MessageBox.Show($"Ocorreu um erro ao verificar as alterações:{vbCrLf}{ex.Message}", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnConsultaSimplesNacional_Click(sender As Object, e As EventArgs) Handles BtnConsultaSimplesNacional.Click
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        If WebSiteGERAL.Visible = True Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")
            MsgBox("CNPJ copiado, use CTRL+V para colar no local desejado")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.Focus()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")
            MsgBox("CNPJ copiado, use CTRL+V para colar no local desejado")
        End If
    End Sub

    Private Sub AbrirEscolhaParcelamentoEnvio()
        ' Abrir FrmParcEscolha e transferir dados com base na aba ativa
        ' Criar instância do FrmParcEscolha
        Dim frmEscolha As New FrmParcEscolha()

        ' Verificar qual aba está selecionada
        Select Case TabControlParcelamento.SelectedTab.Name
            Case "TabPageINSSNovo"
                ' Transferir dados da aba Novo
                frmEscolha.DadosProt = ProtNovoRichTextBox.Text
                frmEscolha.DadosTotal = TotalParcNovoTextBox.Text
                frmEscolha.DadosParcelamento = "Registro para INSS - Novo"
                frmEscolha.DataEnviado = DataEnvioNovoMaskedTextBox.Text

            Case "TabPageINSSProcuradoria"
                ' Transferir dados da aba Procuradoria
                frmEscolha.DadosProt = ProtprocRichTextBox.Text
                frmEscolha.DadosTotal = TotalParcProcTextBox.Text
                frmEscolha.DadosParcelamento = "Registro para INSS - Procuradoria"
                frmEscolha.DataEnviado = DataEnviaProcMaskedTextBox.Text

            Case "TabPageINSSAntigo"
                ' Transferir dados da aba Antigo
                frmEscolha.DadosProt = ProtAntigoRichTextBox.Text
                frmEscolha.DadosTotal = TotalParcAntigoTextBox.Text
                frmEscolha.DadosParcelamento = "Registro para INSS - Antigo"
                frmEscolha.DataEnviado = DataEnviaAntigoMaskedTextBox.Text

            Case "TabPageMei"
                ' Transferir dados da aba MEI
                frmEscolha.DadosProt = ProtMEITextBox.Text
                frmEscolha.DadosTotal = TotalParcMEITextBox.Text
                frmEscolha.DadosParcelamento = "Registro para MEI"
                frmEscolha.DataEnviado = DataEnviaMEIMaskedTextBox.Text
        End Select

        TabControlGeral.SelectedIndex = 1


        'verifica antes se tem forma de envio
        If Not String.IsNullOrEmpty(FormaDeEnvioComboBox.Text) Then
            'nao faz nada e segue
        Else
            MessageBox.Show($"Ocorreu um erro: FORMA DE ENVIO NAO LOCALIZADA", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        frmEscolha.FormaDeEnvio = FormaDeEnvioComboBox.Text

        ' Abrir o formulário FrmParcEscolha
        frmEscolha.Show()
        frmEscolha.MdiParent = MDIPrincipal
    End Sub


    '/////////// CALENDARIO


    Private Sub DataLembreteMaskedTextBox_Click(sender As Object, e As EventArgs) Handles DataLembreteMaskedTextBox.Click
        FrmCalendarioParcelamento.Show()
        FrmCalendarioParcelamento.Focus()
        'abrir no local do mouse
        FrmCalendarioParcelamento.Location = New Point(MousePosition.X, MousePosition.Y)
    End Sub

    '/////// FIM CALENDARIO
    Private Sub VerificaAbaChecked()
        ' Primeiro, remove todas as abas
        TabControlParcelamento.TabPages.Clear()

        ' Adiciona sempre a aba Geral
        TabControlParcelamento.TabPages.Add(TabPageGeral)

        ' Adiciona somente a aba correspondente ao CheckBox marcado
        If MEICheckBox.Checked Then
            TabControlParcelamento.TabPages.Add(TabPageMei)
        End If

        If InssAntigoCheckBox.Checked Then
            TabControlParcelamento.TabPages.Add(TabPageINSSAntigo)
        End If

        If InssNovoCheckBox.Checked Then
            TabControlParcelamento.TabPages.Add(TabPageINSSNovo)
        End If

        If InssProcurCheckBox.Checked Then
            TabControlParcelamento.TabPages.Add(TabPageINSSProcuradoria)
        End If

        ' Seleciona a aba Geral como padrão se nenhuma outra aba foi adicionada além dela
        If TabControlParcelamento.TabPages.Count = 1 Then
            TabControlParcelamento.SelectedTab = TabPageGeral
        End If
    End Sub

    Private Sub CheckBox_Validated(sender As Object, e As EventArgs) Handles MEICheckBox.Validated, InssAntigoCheckBox.Validated, InssNovoCheckBox.Validated, InssProcurCheckBox.Validated
        VerificaAbaChecked()
    End Sub

    Private Sub CheckBox_Changed(sender As Object, e As EventArgs) Handles MEICheckBox.CheckedChanged, InssAntigoCheckBox.CheckedChanged, InssNovoCheckBox.CheckedChanged, InssProcurCheckBox.CheckedChanged
        VerificaAbaChecked()
    End Sub

    Private Sub ButtonAtualizar_Click(sender As Object, e As EventArgs) Handles ButtonAtualizar.Click
        ' Verifica se o formulário já está aberto
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmExtraiCNPJ Then
                frm.Close() ' Fecha o formulário se ele já estiver aberto
                Exit For
            End If
        Next

        ' Abre o formulário
        FrmExtraiCNPJ.Show()
    End Sub

    Private Sub RazaoSocialTextBox_TextChanged(sender As Object, e As EventArgs) Handles RazaoSocialTextBox.TextChanged
        If RazaoSocialTextBox.Text <> "" Then
            ButtonAtualizar.Visible = True
        Else
            ButtonAtualizar.Visible = False
        End If

    End Sub

    Private Sub CheckBoxNaoEnviado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNaoEnviado.CheckedChanged
        AtualizarFiltro()
    End Sub

    Private Sub CheckBoxFiltroEmAndamento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFiltroEmAndamento.CheckedChanged
        AtualizarFiltro()
    End Sub

    Private Sub AtualizarFiltro()
        ' Variáveis para armazenar os filtros
        Dim filtroMes As String = String.Empty
        Dim filtroEmpresa As String = String.Empty
        Dim filtroParaFazer As String = String.Empty

        ' Verifica se a opção "Não Enviado" está marcada
        If CheckBoxNaoEnviado.Checked Then
            ' Obtém o mês atual com a primeira letra maiúscula e o restante minúscula
            Dim mesAtual As String = Char.ToUpper(MonthName(DateTime.Now.Month)(0)) & MonthName(DateTime.Now.Month).Substring(1).ToLower()

            ' Verifica se o mês na coluna "FinalizadoMesGeral" é diferente do mês atual
            filtroMes = $"FinalizadoMesGeral <> '{mesAtual}'"

            ' Adiciona a regra adicional para considerar "FinalizadoEmpresa = 'Não'" para meses diferentes
            filtroMes &= " AND FinalizadoEmpresa = 'Não'"
        End If

        ' Verifica se o filtro "Em Andamento" está marcado
        If CheckBoxFiltroEmAndamento.Checked Then
            filtroEmpresa = "FinalizadoEmpresa = 'Não'"
        End If

        ' Verifica se o filtro "Para Fazer" está marcado
        If CheckBoxParaFazer.Checked Then
            filtroParaFazer = "ParaFazer = 'Checked'"
        End If

        ' Montando o filtro final
        Dim filtroFinal As String = String.Empty

        ' Combina os filtros existentes
        If Not String.IsNullOrEmpty(filtroMes) AndAlso Not String.IsNullOrEmpty(filtroEmpresa) AndAlso Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = $"{filtroMes} AND {filtroEmpresa} AND {filtroParaFazer}"
        ElseIf Not String.IsNullOrEmpty(filtroMes) AndAlso Not String.IsNullOrEmpty(filtroEmpresa) Then
            filtroFinal = $"{filtroMes} AND {filtroEmpresa}"
        ElseIf Not String.IsNullOrEmpty(filtroMes) AndAlso Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = $"{filtroMes} AND {filtroParaFazer}"
        ElseIf Not String.IsNullOrEmpty(filtroEmpresa) AndAlso Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = $"{filtroEmpresa} AND {filtroParaFazer}"
        ElseIf Not String.IsNullOrEmpty(filtroMes) Then
            filtroFinal = filtroMes
        ElseIf Not String.IsNullOrEmpty(filtroEmpresa) Then
            filtroFinal = filtroEmpresa
        ElseIf Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = filtroParaFazer
        End If

        ' Aplica o filtro final
        If Not String.IsNullOrEmpty(filtroFinal) Then
            ParcelamentosBindingSource.Filter = filtroFinal
        Else
            ' Caso nenhum filtro seja configurado, limpa o filtro
            ParcelamentosBindingSource.Filter = String.Empty
        End If

        ' Exibe o filtro final para depuração (opcional)
        ' MessageBox.Show("Filtro Final: " & filtroFinal, "Depuração", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '//////////////////////////
    Private Sub BAckupAPAGARAtualizarFiltro()
        ' Variáveis para armazenar os filtros
        Dim filtroMes As String = String.Empty
        Dim filtroEmpresa As String = String.Empty
        Dim filtroParaFazer As String = String.Empty

        ' Verifica se a opção "Não Enviado" está marcada
        If CheckBoxNaoEnviado.Checked Then
            ' Obtém o mês atual com a primeira letra maiúscula e o restante minúscula
            Dim mesAtual As String = Char.ToUpper(MonthName(DateTime.Now.Month)(0)) & MonthName(DateTime.Now.Month).Substring(1).ToLower()

            ' Exibe o mês atual para depuração
            '  MessageBox.Show("Mês Atual: " & mesAtual, "Depuração", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Aplica o filtro para ocultar registros que já foram enviados no mês atual
            filtroMes = $"FinalizadoMesGeral <> '{mesAtual}'"
        End If

        ' Verifica se o filtro "Em Andamento" está marcado
        If CheckBoxFiltroEmAndamento.Checked Then
            filtroEmpresa = "FinalizadoEmpresa = 'Não'"
        End If
        'colocar aqui o CheckBoxParaFazer.checked SIM e se for marcado vai filtrar tambem "ParaFazer" 
        If CheckBoxParaFazer.Checked Then
            filtroParaFazer = "ParaFazer = 'Checked'"
        End If


        ' Montando o filtro final
        Dim filtroFinal As String = String.Empty

        ' Se todos os filtros existirem, combina com "AND"
        If Not String.IsNullOrEmpty(filtroMes) AndAlso Not String.IsNullOrEmpty(filtroEmpresa) AndAlso Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = $"{filtroMes} AND {filtroEmpresa} AND {filtroParaFazer}"
        ElseIf Not String.IsNullOrEmpty(filtroMes) AndAlso Not String.IsNullOrEmpty(filtroEmpresa) Then
            filtroFinal = $"{filtroEmpresa} AND {filtroMes}"
        ElseIf Not String.IsNullOrEmpty(filtroMes) AndAlso Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = $"{filtroMes} AND {filtroParaFazer}"
        ElseIf Not String.IsNullOrEmpty(filtroEmpresa) AndAlso Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = $"{filtroEmpresa} AND {filtroParaFazer}"
        ElseIf Not String.IsNullOrEmpty(filtroMes) Then
            filtroFinal = filtroMes
        ElseIf Not String.IsNullOrEmpty(filtroEmpresa) Then
            filtroFinal = filtroEmpresa
        ElseIf Not String.IsNullOrEmpty(filtroParaFazer) Then
            filtroFinal = filtroParaFazer
        End If

        ' Aplica o filtro final
        If Not String.IsNullOrEmpty(filtroFinal) Then
            ParcelamentosBindingSource.Filter = filtroFinal
        Else
            ' Caso nenhum filtro seja configurado, exibe mensagem de depuração
            '  MessageBox.Show("Nenhum filtro foi aplicado.", "Depuração", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ParcelamentosBindingSource.Filter = String.Empty
        End If

        ' Exibe o filtro final para depuração
        ' MessageBox.Show("Filtro Final: " & filtroFinal, "Depuração", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabelAgoraFinal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAgoraFinal.LinkClicked
        DataFinalizadoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub CheckBoxParaFazer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxParaFazer.CheckedChanged
        AtualizarFiltro()
    End Sub
    'Botao de agora para nova solicitacao
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataSolicMEIMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        FinalizadoMEIComboBox.SelectedIndex = 1
        AtrasoParcelaMEICheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataSolicAntigoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        FinalizadoINSSAntComboBox.SelectedIndex = 1
        AtrasoParcelaINSSAntigoCheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataSolicNovoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        FinalizadoINSSNovComboBox.SelectedIndex = 1
        AtrasoParcelaINSSNovoCheckBox.CheckState = CheckState.Unchecked

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataSolicProcMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        FinalizadoINSSProcComboBox.SelectedIndex = 1
        AtrasoParcelaINSSProcuCheckBox.CheckState = CheckState.Unchecked
    End Sub
    '//////////////////////////////////////////////
    Private Function FormatarNumeroWhatsapp(numeroCompleto As String) As String
        ' Remove o "+55", os espaços e o traço
        Dim numeroFormatado As String = numeroCompleto.Replace("+55", "").Replace(" ", "").Replace("-", "")

        ' Retorna o número formatado
        Return numeroFormatado
    End Function
    Private Sub SalvarNumeroWhatsapp()
        Dim numeroCompleto As String = WhatsappMaskedTextBox.Text
        Dim numeroFormatado As String = FormatarNumeroWhatsapp(numeroCompleto)

        ' Agora você pode salvar ou usar o número formatado
        MessageBox.Show("Número formatado: " & numeroFormatado, "Número WhatsApp", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WhatsappMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles WhatsappMaskedTextBox.TextChanged
        ' Chama a função para formatar o número
        Dim numeroFormatado As String = FormatarNumeroWhatsapp(WhatsappMaskedTextBox.Text)

        ' Atualiza o TextBox com o número formatado (opcional)
        WhatsappMaskedTextBox.Text = numeroFormatado
    End Sub
End Class
