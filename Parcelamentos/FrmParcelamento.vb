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

        ' Permitir edições em todas as colunas da tabela Empresas
        For Each col As DataColumn In Me.PrinceDBDataSet.Empresas.Columns
            col.ReadOnly = False
        Next

        AtualizarAbasVisibilidade()


        ' Se estiver em modo de edição, cancelar as alterações
        ParcelamentosBindingSource.CancelEdit()
        BloqueiaTudo() ' Bloqueia os campos novamente
        BtnEditar.Text = "Editar" ' Muda o texto do botão para "Editar"

    End Sub

    ' Função para controlar a visibilidade das abas
    Private Sub AtualizarAbasVisibilidade()
        ' Verifica o estado de cada CheckBox e define a visibilidade das TabPages
        TabControlParcelamento.TabPages(0).Visible = MEICheckBox.Checked
        TabControlParcelamento.TabPages(1).Visible = InssAntigoCheckBox.Checked
        TabControlParcelamento.TabPages(2).Visible = InssNovoCheckBox.Checked
        TabControlParcelamento.TabPages(3).Visible = InssProcurCheckBox.Checked
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Me.ParcelamentosBindingSource.AddNew() ' Adiciona um novo registro
        DesBloqueiaTudo() ' Habilita os campos para edição
        BtnEditar.Enabled = True ' Desabilita o botão Editar enquanto está no modo Novo
        MEICheckBox.CheckState = CheckState.Unchecked
        InssAntigoCheckBox.CheckState = CheckState.Unchecked
        InssNovoCheckBox.CheckState = CheckState.Unchecked
        InssProcurCheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub


    '//////////////////////// SALVAR /////////////////////////////////////////////////////
    ' Variável para controlar o fechamento do formulário
    Private cancelarFechamento As Boolean = False

    Private Sub Salvar()
        Try
            ' Perguntar ao usuário se deseja salvar, com opção de Cancelar
            Dim result As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Configurar a ProgressBar
                ProgressBarSalvar.Visible = True
                ProgressBarSalvar.Value = 0
                ProgressBarSalvar.Step = 1
                ProgressBarSalvar.Maximum = 100

                ' Simular progresso
                For i As Integer = 1 To 100
                    Threading.Thread.Sleep(10) ' Apenas para simulação
                    ProgressBarSalvar.PerformStep()
                Next

                ' Finalizar edição e salvar alterações
                Me.Validate()
                Me.ParcelamentosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

                ' Exibir mensagem de sucesso
                MessageBox.Show("Alterações salvas com sucesso.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BloqueiaTudo()

            ElseIf result = DialogResult.No Then
                ' Caso o usuário escolha "Não", desfazer todas as alterações
                ' Cancelar as edições e recarregar os dados
                Me.ParcelamentosBindingSource.CancelEdit()

                ' Recarregar os dados da tabela Parcelamentos usando o TableAdapter
                Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)

                ' Exibir mensagem que as alterações foram descartadas
                MessageBox.Show("As alterações foram descartadas e os dados foram recarregados.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf result = DialogResult.Cancel Then
                ' Caso o usuário escolha "Cancelar"
                MessageBox.Show("A operação foi cancelada.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            ' Tratamento de erros
            MessageBox.Show($"Ocorreu um erro ao salvar:{vbCrLf}{ex.Message}", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Garantir que a ProgressBar esteja oculta ao final do processo
            ProgressBarSalvar.Value = 0
            ProgressBarSalvar.Visible = False
        End Try
    End Sub




    Private Sub SalvarBackup()
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

        If FinalizadoEmpresaComboBox.Text = "Sim" Then
            LabelDataFinalizado.Visible = True
            DataFinalizadoMaskedTextBox.Visible = True

        Else
            LabelDataFinalizado.Visible = False
            DataFinalizadoMaskedTextBox.Visible = False
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
        TabControlGeral.SelectedIndex = 1
        TabControlGeral.SelectedIndex = 0
        TabControlMei.SelectedIndex = 0
        TabControlMei.SelectedIndex = 1

        ' Verificar campos obrigatórios
        If String.IsNullOrWhiteSpace(FormaDeEnvioComboBox.Text) Then
            MessageBox.Show("O campo 'Forma de Envio' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlGeral.SelectedIndex = 1
            TabControlMei.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TotalParcMEITextBox.Text) Then
            MessageBox.Show("O campo 'Total de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlMei.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(ParcelEnvMEITextBox.Text) Then
            MessageBox.Show("O campo 'Parcela de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlMei.SelectedIndex = 0
            Exit Sub
        End If

        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            Dim TotalParcelamento As String = TotalParcMEITextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvMEITextBox.Text
            If String.IsNullOrWhiteSpace(DataEnviaMEIMaskedTextBox.Text.Replace("/", "").Replace(":", "").Trim()) OrElse Not IsDate(DataEnviaMEIMaskedTextBox.Text) Then
                DataEnviaMEIMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnviaMEIMaskedTextBox.Text
            Dim Empresa As String = RazaoSocialTextBox.Text

            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcMEIRichTextBox.Text <> "" Then
                EnviaParcMEIRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcMEIRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine


            ' Perguntar se deseja copiar o texto
            Dim copyResult As DialogResult = MessageBox.Show("Deseja copiar o texto para anexar ao enviar para o cliente?", "Copiar Texto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If copyResult = DialogResult.Yes Then
                Dim textoParaCopiar As String = "Olá, tudo bem?" + Environment.NewLine +
                "Segue o DARF do *Parcelamento do MEI* da empresa: *" + Empresa + "*." + Environment.NewLine +
                    "Parcela(s): " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas." + Environment.NewLine +
                    "Atenciosamente" + Environment.NewLine +
                    "Rogerio"
                Clipboard.SetText(textoParaCopiar)
                ' MessageBox.Show("Texto copiado para a área de transferência!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show(textoParaCopiar, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub BtnRegistrarINSSAntigo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSAntigo.Click
        TabControlGeral.SelectedIndex = 1
        TabControlGeral.SelectedIndex = 0
        TabControlINSSAntigo.SelectedIndex = 0
        TabControlINSSAntigo.SelectedIndex = 1

        ' Verificar campos obrigatórios
        If String.IsNullOrWhiteSpace(FormaDeEnvioComboBox.Text) Then
            MessageBox.Show("O campo 'Forma de Envio' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlGeral.SelectedIndex = 1
            TabControlINSSAntigo.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TotalParcAntigoTextBox.Text) Then
            MessageBox.Show("O campo 'Total de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlINSSAntigo.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(ParcelEnvINSSAntTextBox.Text) Then
            MessageBox.Show("O campo 'Parcela de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlINSSAntigo.SelectedIndex = 0
            Exit Sub
        End If

        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            Dim TotalParcelamento As String = TotalParcAntigoTextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvINSSAntTextBox.Text
            If String.IsNullOrWhiteSpace(DataEnviaAntigoMaskedTextBox.Text.Replace("/", "").Replace(":", "").Trim()) OrElse Not IsDate(DataEnviaAntigoMaskedTextBox.Text) Then
                DataEnviaAntigoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnviaAntigoMaskedTextBox.Text
            Dim Empresa As String = RazaoSocialTextBox.Text

            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcAntigoRichTextBox.Text <> "" Then
                EnviaParcAntigoRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcAntigoRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine


            Dim copyResult As DialogResult = MessageBox.Show("Deseja copiar o texto para anexar ao enviar para o cliente?", "Copiar Texto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If copyResult = DialogResult.Yes Then
                Dim textoParaCopiar As String = "Olá, tudo bem?" + Environment.NewLine +
                "Segue o DARF do *Parcelamento do INSS Antigo* da empresa: *" + Empresa + "*." + Environment.NewLine +
                    "Parcela(s): " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas." + Environment.NewLine +
                    "Atenciosamente" + Environment.NewLine +
                    "Rogerio"
                Clipboard.SetText(textoParaCopiar)
                'MessageBox.Show("Texto copiado para a área de transferência!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show(textoParaCopiar, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If
    End Sub

    Private Sub BtnRegistrarINSSNovo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSNovo.Click
        TabControlGeral.SelectedIndex = 1
        TabControlGeral.SelectedIndex = 0
        TabControlINSSNovo.SelectedIndex = 0
        TabControlINSSNovo.SelectedIndex = 1

        ' Verificar campos obrigatórios
        If String.IsNullOrWhiteSpace(FormaDeEnvioComboBox.Text) Then
            MessageBox.Show("O campo 'Forma de Envio' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlGeral.SelectedIndex = 1
            TabControlINSSNovo.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TotalParcNovoTextBox.Text) Then
            MessageBox.Show("O campo 'Total de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlINSSNovo.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(ParcelEnvINSSNovTextBox.Text) Then
            MessageBox.Show("O campo 'Parcela de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlINSSNovo.SelectedIndex = 0
            Exit Sub
        End If

        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            Dim TotalParcelamento As String = TotalParcNovoTextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvINSSNovTextBox.Text
            If String.IsNullOrWhiteSpace(DataEnvioNovoMaskedTextBox.Text.Replace("/", "").Replace(":", "").Trim()) OrElse Not IsDate(DataEnvioNovoMaskedTextBox.Text) Then
                DataEnvioNovoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnvioNovoMaskedTextBox.Text
            Dim Empresa As String = RazaoSocialTextBox.Text


            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcNovoRichTextBox.Text <> "" Then
                EnviaParcNovoRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcNovoRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine


            Dim copyResult As DialogResult = MessageBox.Show("Deseja copiar o texto para anexar ao enviar para o cliente?", "Copiar Texto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If copyResult = DialogResult.Yes Then
                Dim textoParaCopiar As String = "Olá, tudo bem?" + Environment.NewLine +
                "Segue o DARF do *Parcelamento do INSS Novo* da empresa: *" + Empresa + "*." + Environment.NewLine +
                    "Parcela(s): " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas." + Environment.NewLine +
                    "Atenciosamente" + Environment.NewLine +
                    "Rogerio"
                Clipboard.SetText(textoParaCopiar)
                ' MessageBox.Show("Texto copiado para a área de transferência!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show(textoParaCopiar, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub BtnRegistrarINSSProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSProcuradoria.Click
        TabControlGeral.SelectedIndex = 1
        TabControlGeral.SelectedIndex = 0
        TabControlINSSProcuradoria.SelectedIndex = 0
        TabControlINSSProcuradoria.SelectedIndex = 1

        ' Verificar campos obrigatórios
        If String.IsNullOrWhiteSpace(FormaDeEnvioComboBox.Text) Then
            MessageBox.Show("O campo 'Forma de Envio' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlGeral.SelectedIndex = 1
            TabControlINSSProcuradoria.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TotalParcProcTextBox.Text) Then
            MessageBox.Show("O campo 'Total de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlINSSProcuradoria.SelectedIndex = 0
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(ParcelEnvINSSProcTextBox.Text) Then
            MessageBox.Show("O campo 'Parcela de Parcelamento' está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControlINSSProcuradoria.SelectedIndex = 0
            Exit Sub
        End If

        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            Dim TotalParcelamento As String = TotalParcProcTextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvINSSProcTextBox.Text
            If String.IsNullOrWhiteSpace(DataEnviaProcMaskedTextBox.Text.Replace("/", "").Replace(":", "").Trim()) OrElse Not IsDate(DataEnviaProcMaskedTextBox.Text) Then
                DataEnviaProcMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnviaProcMaskedTextBox.Text
            Dim Empresa As String = RazaoSocialTextBox.Text

            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcProcRichTextBox.Text <> "" Then
                EnviaParcProcRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcProcRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine


            ' Perguntar se deseja copiar o texto para enviar ao cliente
            Dim copyResult As DialogResult = MessageBox.Show("Deseja copiar o texto para anexar ao enviar para o cliente?", "Copiar Texto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If copyResult = DialogResult.Yes Then
                Dim textoParaCopiar As String = "Olá, tudo bem?" + Environment.NewLine +
                "Segue o DARF do *Parcelamento do INSS da Procuradoria* da empresa: *" + Empresa + "*." + Environment.NewLine +
                "Parcela(s): " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas." + Environment.NewLine +
                "Atenciosamente" + Environment.NewLine +
                "Rogerio"
                Clipboard.SetText(textoParaCopiar)
                MessageBox.Show(textoParaCopiar, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Texto copiado para a área de transferência!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub BtnCopiarCNPJ_Click(sender As Object, e As EventArgs) Handles BtnCopiarCNPJ.Click
        Try
            Dim CNPJ As String = CNPJMaskedTextBox.Text
            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function VerificarCNPJParcelamento(cnpj As String) As Boolean
        ' O CNPJ está no formato já formatado com máscara
        Dim cnpjFormatado As String = cnpj

        Using connection As New SqlConnection(str)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando CNPJ: " & cnpjFormatado)

                ' Consultar o CNPJ na tabela "Parcelamento"
                Dim query As String = "SELECT CNPJ FROM Parcelamentos WHERE CNPJ = @CNPJ"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        ' Log do resultado encontrado
                        Debug.WriteLine("CNPJ encontrado na tabela Parcelamentos: " & cnpjFormatado)

                        ' Se o CNPJ estiver cadastrado, buscar a razão social
                        Dim queryRazaoSocial As String = "SELECT RazaoSocial FROM Parcelamentos WHERE CNPJ = @CNPJ"
                        Using cmdRazaoSocial As New SqlCommand(queryRazaoSocial, connection)
                            cmdRazaoSocial.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                            Dim razaoSocial As String = Convert.ToString(cmdRazaoSocial.ExecuteScalar())
                            MessageBox.Show("CNPJ já cadastrado no Parcelamentos!" & vbCrLf & "CNPJ: " & cnpjFormatado & vbCrLf & "Razão Social: " & razaoSocial)
                        End Using

                        Return True ' Retornar True se o CNPJ foi encontrado
                    End If
                End Using

                MessageBox.Show("CNPJ não cadastrado no Parcelamentos.")
                Return False ' Retornar False se o CNPJ não foi encontrado
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
                Return True ' Retornar True para evitar continuar em caso de erro
            End Try
        End Using
    End Function




    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        ' Chamar o método de verificação
        Dim cnpjJaCadastrado As Boolean = VerificarCNPJParcelamento(CNPJMaskedTextBox.Text)

        ' Se o CNPJ já estiver cadastrado, cancelar a execução
        If cnpjJaCadastrado Then
            Exit Sub
        End If

        ' Inicializar a ProgressBar
        ProgressBarSalvar.Value = 0
        ProgressBarSalvar.Visible = True
        ' Atualizar a ProgressBar antes de executar a consulta
        ProgressBarSalvar.Maximum = 100
        ProgressBarSalvar.Step = 25
        ProgressBarSalvar.Value = 15


        TabControlGeral.SelectedIndex = 0
        TabControlGeral.SelectedIndex = 1
        TabControlGeral.SelectedIndex = 2
        TabControlGeral.SelectedIndex = 3
        TabControlGeral.SelectedIndex = 0

        ' Verificar se o CNPJMaskedTextBox está vazio
        If String.IsNullOrWhiteSpace(CNPJMaskedTextBox.Text) Then
            MessageBox.Show("Por favor, insira um CNPJ válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ProgressBarSalvar.Value = 25

        ' Mostrar o CNPJ que será pesquisado
        '  MessageBox.Show($"CNPJ sendo pesquisado: {CNPJMaskedTextBox.Text}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Conexão com o banco de dados
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

        ' Consulta SQL sem usar REPLACE, procurando o CNPJ diretamente
        Dim query As String = "SELECT E.RazaoSocial, E.NomeResponsavel, E.CPFResponsavel, E.SenhaGov 
                         FROM Empresas AS E
                         INNER JOIN Parcelamentos AS P ON E.CNPJ = P.CNPJ
                         WHERE P.CNPJ = @CNPJ"

        Using connection As New SqlClient.SqlConnection(connectionString)
            Using command As New SqlClient.SqlCommand(query, connection)
                ' Adicionar o parâmetro do CNPJ
                command.Parameters.AddWithValue("@CNPJ", CNPJMaskedTextBox.Text)

                Try
                    ' Atualizar a ProgressBar antes de executar a consulta
                    ProgressBarSalvar.Maximum = 100
                    'ProgressBarSalvar.Step = 35
                    ProgressBarSalvar.Value = 35


                    connection.Open()

                    ' Mostrar mensagem indicando a conexão com o banco
                    ' MessageBox.Show("Conectado ao banco de dados 'PrinceDB'. Realizando consulta...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    ' Executar a consulta
                    Using reader As SqlClient.SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Atualizar o progresso
                            ProgressBarSalvar.Value = 50

                            ' Exibir o CNPJ encontrado no banco de dados para referência
                            ' MessageBox.Show($"CNPJ encontrado no cadastro geral de 'Empresas': {reader("RazaoSocial")}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Alterar a aba do TabControl para os campos necessários
                            TabControlGeral.SelectedIndex = 0
                            RazaoSocialTextBox.Text = reader("RazaoSocial").ToString()

                            TabControlGeral.SelectedIndex = 2
                            SocioTextBox.Text = reader("NomeResponsavel").ToString()
                            CPFMaskedTextBox.Text = reader("CPFResponsavel").ToString()
                            SenhaGovTextBox.Text = reader("SenhaGov").ToString()

                            TabControlGeral.SelectedIndex = 0

                            ' Atualizar o progresso
                            ProgressBarSalvar.Value = 100

                            MessageBox.Show("Dados importados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' Caso não encontre o CNPJ no banco de dados
                            ProgressBarSalvar.Value = 0 ' Resetar a barra
                            MessageBox.Show("CNPJ não encontrado na base de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            ' Pergunta se o usuário deseja importar os dados
                            Dim result As DialogResult = MessageBox.Show("Deseja importar os dados do CNPJ de outra forma?", "Importação de CNPJ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            If result = DialogResult.Yes Then
                                ' Verifica se o formulário FrmCNPJimportar já está aberto
                                If Application.OpenForms.OfType(Of FrmCNPJimportar)().Any() Then
                                    ' Fecha o formulário se estiver aberto
                                    FrmCNPJimportar.Close()
                                End If

                                ' Abre o formulário FrmCNPJimportar
                                FrmCNPJimportar.Show()
                            Else
                                ' Se o usuário escolher 'Não', fecha o processo ou realiza outra ação
                                MessageBox.Show("A importação foi cancelada.", "Importação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ProgressBarSalvar.Visible = False
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    ' Tratamento de erros
                    ProgressBarSalvar.Value = 0 ' Resetar a barra em caso de erro
                    MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


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

        ' Mostrar o mês atual em uma MessageBox
        ' MessageBox.Show("Mês atual: " & mesAtual, "Mês Atual", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
End Class