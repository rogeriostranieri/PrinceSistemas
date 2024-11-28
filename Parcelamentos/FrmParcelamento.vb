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
        BtnSalvar.Enabled = False
        BtnExcluir.Enabled = True

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
        BtnSalvar.Enabled = True ' Habilita o botão Salvar
        BtnEditar.Enabled = False ' Desabilita o botão Editar enquanto está no modo Novo
        BtnExcluir.Enabled = False ' Desabilita o botão Excluir

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub


    '//////////////////////// SALVAR /////////////////////////////////////////////////////
    ' Variável para controlar o fechamento do formulário
    Private cancelarFechamento As Boolean = False

    Private Sub Salvar()
        Try
            ' Perguntar ao usuário se deseja salvar
            Dim result As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
            Else
                ' Caso o usuário escolha "Não"
                MessageBox.Show("As alterações não foram salvas.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            BtnSalvar.Enabled = True ' Habilita o botão Salvar
            BtnExcluir.Enabled = False ' Desabilita o botão Excluir
        Else
            ' Se estiver em modo de edição, cancelar as alterações
            ParcelamentosBindingSource.CancelEdit()
            BloqueiaTudo() ' Bloqueia os campos novamente
            BtnEditar.Text = "Editar" ' Muda o texto do botão para "Editar"
            BtnSalvar.Enabled = False
            BtnExcluir.Enabled = True
        End If
    End Sub

    Private Sub BloqueiaTudo()
        TabControlGeral.Enabled = False
        TabControlParcelamento.Enabled = False
    End Sub

    Private Sub DesBloqueiaTudo()
        TabControlGeral.Enabled = True
        TabControlParcelamento.Enabled = True
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

        If FinalizadoEmpresaComboBox.Text = "Sim" Then
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
        If FinalizadoEmpresaComboBox.Text = "Sim" Then
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
        If FinalizadoEmpresaComboBox.Text = "Sim" Then
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
        If FinalizadoEmpresaComboBox.Text = "Sim" Then
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
        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            TabControlGeral.SelectedIndex = 1
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            TabControlGeral.SelectedIndex = 0

            TabControlMei.SelectedIndex = 0
            Dim TotalParcelamento As String = TotalParcMEITextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvMEITextBox.Text
            If DataEnviaMEIMaskedTextBox.Text = "" Then
                DataEnviaMEIMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnviaMEIMaskedTextBox.Text

            TabControlMei.SelectedIndex = 1
            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcMEIRichTextBox.Text <> "" Then
                EnviaParcMEIRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcMEIRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine
        End If
    End Sub

    Private Sub BtnRegistrarINSSAntigo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSAntigo.Click
        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            TabControlGeral.SelectedIndex = 1
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            TabControlGeral.SelectedIndex = 0

            TabControlINSSAntigo.SelectedIndex = 0
            Dim TotalParcelamento As String = TotalParcAntigoTextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvINSSAntTextBox.Text
            If DataEnviaAntigoMaskedTextBox.Text = "" Then
                DataEnviaAntigoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnviaAntigoMaskedTextBox.Text

            TabControlINSSAntigo.SelectedIndex = 1
            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcAntigoRichTextBox.Text <> "" Then
                EnviaParcAntigoRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcAntigoRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine

            ' Volta para a primeira aba do TabControlINSSAntigo (0)
            TabControlINSSAntigo.SelectedIndex = 0
        End If
    End Sub

    Private Sub BtnRegistrarINSSNovo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSNovo.Click
        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            TabControlGeral.SelectedIndex = 1
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            TabControlGeral.SelectedIndex = 0

            TabControlINSSNovo.SelectedIndex = 0
            Dim TotalParcelamento As String = TotalParcNovoTextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvINSSNovTextBox.Text
            If DataEnvioNovoMaskedTextBox.Text = "" Then
                DataEnvioNovoMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnvioNovoMaskedTextBox.Text

            TabControlINSSNovo.SelectedIndex = 1
            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcNovoRichTextBox.Text <> "" Then
                EnviaParcNovoRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcNovoRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine
        End If
    End Sub

    Private Sub BtnRegistrarINSSProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnRegistrarINSSProcuradoria.Click
        ' Perguntar se deseja registrar o envio
        Dim result As DialogResult = MessageBox.Show("Deseja registrar o envio?", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            TabControlGeral.SelectedIndex = 1
            Dim FormaDeEnvio As String = FormaDeEnvioComboBox.Text
            TabControlGeral.SelectedIndex = 0

            TabControlINSSProcuradoria.SelectedIndex = 0
            Dim TotalParcelamento As String = TotalParcProcTextBox.Text
            Dim ParcelaParcelamento As String = ParcelEnvINSSProcTextBox.Text
            If DataEnviaProcMaskedTextBox.Text = "" Then
                DataEnviaProcMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            End If
            Dim DataEnvio As String = DataEnviaProcMaskedTextBox.Text

            TabControlINSSProcuradoria.SelectedIndex = 1
            ' Verificar se tem texto e colocar abaixo sem apagar os antigos textos dentro do RichTextBox
            If EnviaParcProcRichTextBox.Text <> "" Then
                EnviaParcProcRichTextBox.Text += Environment.NewLine ' Adiciona nova linha
            End If
            EnviaParcProcRichTextBox.Text += "Foi enviado a parcela " + ParcelaParcelamento + " do total de " + TotalParcelamento + " parcelas, " + "enviado via " + FormaDeEnvio + ", no dia " + DataEnvio + "." + Environment.NewLine
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

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click

        ' Verificar se o CNPJMaskedTextBox está vazio
        If String.IsNullOrWhiteSpace(CNPJMaskedTextBox.Text) Then
            MessageBox.Show("Por favor, insira um CNPJ válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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
                    connection.Open()

                    ' Mostrar mensagem indicando a conexão com o banco
                    ' MessageBox.Show("Conectado ao banco de dados 'PrinceDB'. Realizando consulta...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Executar a consulta
                    Using reader As SqlClient.SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
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

                            MessageBox.Show("Dados importados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' Caso não encontre o CNPJ no banco de dados
                            MessageBox.Show("CNPJ não encontrado na base de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Tratamento de erros
                    MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    '/////////////////////////////////////////////

End Class