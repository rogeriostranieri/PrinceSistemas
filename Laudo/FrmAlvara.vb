Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text

Public Class FrmAlvara
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' inicio LOAD

    ' Propriedade pública para receber a RazaoSocialSelecionada
    Public Property RazaoSocialSelecionada As String
    ' Declaração da variável no nível do formulário



    Private Sub FrmAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Suspender BindingSource ao carregar dados
            Me.LaudosBindingSource.SuspendBinding()

            ' Carregar os dados das tabelas
            Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
            Me.AlvaraSistemaTableAdapter.Fill(Me.PrinceDBDataSet.AlvaraSistema)
            Me.BombeiroSituacaoTableAdapter.Fill(Me.PrinceDBDataSet.BombeiroSituacao)

            ' Vincular ComboBox de Situação com CADSituacaoAlvara
            SituacaoComboBox.DataSource = Me.CADSituacaoAlvaraBindingSource
            SituacaoComboBox.DisplayMember = "Descricao"
            SituacaoComboBox.ValueMember = "Descricao"

            ' Vincular ComboBox de Bombeiro com BombeiroSituacao
            BombeiroSituacaoComboBox.DataSource = Me.BombeiroSituacaoBindingSource
            BombeiroSituacaoComboBox.DisplayMember = "Descricao"
            BombeiroSituacaoComboBox.ValueMember = "Descricao"

            ' Vincular ComboBox de Modelo de Sistema com AlvaraSistema
            ModeloSistemaComboBox.DataSource = Me.AlvaraSistemaBindingSource
            ModeloSistemaComboBox.DisplayMember = "Descricao"
            ModeloSistemaComboBox.ValueMember = "Descricao"

            ' Ordenar dados dos ComboBoxes
            Dim viewSituacao As DataView = New DataView(Me.PrinceDBDataSet.CADSituacaoAlvara)
            viewSituacao.Sort = "Descricao ASC"
            Me.CADSituacaoAlvaraBindingSource.DataSource = viewSituacao

            Dim viewBombeiro As DataView = New DataView(Me.PrinceDBDataSet.BombeiroSituacao)
            viewBombeiro.Sort = "Descricao ASC"
            Me.BombeiroSituacaoBindingSource.DataSource = viewBombeiro

            Dim viewModeloSistema As DataView = New DataView(Me.PrinceDBDataSet.AlvaraSistema)
            viewModeloSistema.Sort = "Descricao ASC"
            Me.AlvaraSistemaBindingSource.DataSource = viewModeloSistema

            ' Atualizar o BindingSource após aplicar o filtro
            AtualizarBindingSource()

            ' Configurar o valor do ComboBox com base no valor salvo em Laudos
            ConfigurarComboBox()

            ' Configurar estado inicial dos controles
            BtnEditar.Text = "Cancelar"
            DesativaDataProvisorio()

            ' Tirar borda do TableLayoutPanel1
            TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None

            ' Permitir edição em todas as colunas do DataTable Laudos
            For Each col As DataColumn In Me.PrinceDBDataSet.Laudos.Columns
                col.ReadOnly = False
            Next

            ' Vincula o evento CurrentChanged do BindingSource para detectar mudanças na empresa
            AddHandler LaudosBindingSource.CurrentChanged, AddressOf LaudosBindingSource_CurrentChanged

            ' Verificar filiais e outras funções adicionais
            VerificarFiliais()
            BombeiroMulta()

            ' Retomar BindingSource após o carregamento
            Me.LaudosBindingSource.ResumeBinding()

            ArrumarCNPJ()


            ' Configurações adicionais
            InicializarControles()

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao carregar o formulário" & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub




    Public Sub BombeiroMulta()
        Dim dataValida As DateTime

        ' Verifica se o texto do MaskedTextBox está vazio, contém apenas o padrão ou não é uma data válida
        If String.IsNullOrWhiteSpace(BombeiroDataMultaMaskedTextBox.Text) OrElse BombeiroDataMultaMaskedTextBox.Text = "/ /" OrElse Not DateTime.TryParseExact(BombeiroDataMultaMaskedTextBox.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataValida) Then
            ' Se estiver vazio, contiver "/ /" ou não for uma data válida, esconde os controles
            BombeiroDataMultaMaskedTextBox.Visible = False
            LabelBombeiroMulta.Visible = False
        Else
            ' Se contiver uma data válida, mostra os controles
            BombeiroDataMultaMaskedTextBox.Visible = True
            LabelBombeiroMulta.Visible = True
        End If
    End Sub


    Private Sub LaudosBindingSource_CurrentChanged(sender As Object, e As EventArgs)
        ' Sempre que o item atual no BindingSource mudar, chama VerificarFiliais
        VerificarFiliais()
        BombeiroMulta()
    End Sub

    Private Sub InicializarControles()
        Try
            If BtnEditar.Text = "Cancelar" Then
                ' Remover do dock, ocultar e desabilitar o binding navigator
                LaudosBindingNavigator.Dock = DockStyle.None
                LaudosBindingNavigator.Visible = False
                LaudosBindingNavigator.Enabled = False

                ' Oculte os combo boxes também
                ComboBoxBuscaCNPJ.Visible = False
                ComboBoxBuscaAlvara.Visible = False
                Label19.Visible = False
            Else
                ' Se não estiver em modo de edição, habilitar e mostrar o binding navigator
                LaudosBindingNavigator.Dock = DockStyle.Top
                LaudosBindingNavigator.Visible = True
                LaudosBindingNavigator.Enabled = True

                ' Mostrar os combo boxes
                ComboBoxBuscaCNPJ.Visible = True
                ComboBoxBuscaAlvara.Visible = True
                Label19.Visible = True

            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao editar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub AtualizarBindingSource()
        ' Forçar a atualização do BindingSource
        LaudosBindingSource.EndEdit()
        LaudosBindingSource.ResetBindings(False)
    End Sub

    Private Sub ConfigurarComboBox()
        ' Verificar se há dados no BindingSource
        If LaudosBindingSource.Current IsNot Nothing Then
            Dim selectedValue As String = LaudosBindingSource.Current("Situacao").ToString()
            SituacaoComboBox.SelectedValue = selectedValue
        End If
    End Sub



    Private Sub VerificarFiliais()
        Dim cnpjBase As String = "" ' Aqui você vai pegar o CNPJ base do controle correspondente

        ' Supondo que você tenha um MaskedTextBox para o CNPJ no FrmAlvara
        cnpjBase = CNPJMaskedTextBox.Text.Substring(0, 10)

        Dim query As String = "SELECT COUNT(*) FROM Laudos WHERE CNPJ LIKE @CNPJBase + '%' AND CNPJ <> @CNPJAtual"
        Dim filiaisCount As Integer = 0

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CNPJBase", cnpjBase)
                cmd.Parameters.AddWithValue("@CNPJAtual", CNPJMaskedTextBox.Text)
                conn.Open()

                filiaisCount = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        ' Atualiza o texto do BtnFiliais
        If filiaisCount > 0 Then
            BtnFiliais.Text = $"{filiaisCount} Filiais"
            BtnFiliais.Visible = True
            LabelFilial.Visible = False
        Else
            BtnFiliais.Visible = False
            LabelFilial.Visible = True
            LabelFilial.Cursor = Cursors.Hand
            AddHandler LabelFilial.Click, AddressOf LabelFilial_Click
        End If

        ' Ajusta o tamanho do botão
        BtnFiliais.AutoSize = True
    End Sub
    Private Sub LabelFilial_Click(sender As Object, e As EventArgs)
        VerificarFiliais()
    End Sub

    '//// fim load

    'FIM
    Private Sub SituacaoOrdenado()
        ' Obter a fonte de dados original do ComboBox
        Dim bindingSource As BindingSource = DirectCast(SituacaoComboBox.DataSource, BindingSource)

        ' Verificar se o BindingSource não é Nothing
        If bindingSource IsNot Nothing Then
            ' Obter a DataView da fonte de dados do BindingSource
            Dim dataView As DataView = DirectCast(bindingSource.List, DataView)

            ' Verificar se a DataView não é Nothing
            If dataView IsNot Nothing Then
                ' Ordenar a DataView pela coluna desejada
                dataView.Sort = "Descricao ASC" ' Substitua "ColumnName" pelo nome da coluna que você deseja ordenar

                ' Atualizar o BindingSource com a DataView ordenada
                bindingSource.DataSource = dataView
            End If
        End If

    End Sub
    Private Sub Bloquear()
        'Modifica bloqueando td novamente
        BtnEditar.Text = "Editar"
        CheckBoxPrioridade.Enabled = False
        GroupBox4.Enabled = False
    End Sub

    Private Sub Desbloquear()
        'Modifica bloqueando td novamente
        BtnEditar.Text = "Cancelar"
        CheckBoxPrioridade.Enabled = True
        GroupBox4.Enabled = True
    End Sub
    Private Sub DesativaDataProvisorio()
        BombeiroProvisorioDATAMaskedTextBox.ReadOnly = True
        AmbientalProvisorioDATAMaskedTextBox.ReadOnly = True
        ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = True
        SanitarioProvisorioDATAMaskedTextBox.ReadOnly = True
        SetranProvisorioDATAMaskedTextBox.ReadOnly = True

    End Sub

    Private Sub SituacaoCombo()
        Try
            Select Case True
                Case SituacaoComboBox.Text.Contains("Andamento")

                    TabAlvara.SelectTab(1)
                    AvisarDiaMaskedTextBox.Select()
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Pagamento")
                    TabAlvara.SelectTab(1)
                    AvisarDiaMaskedTextBox.Select()
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Paralisado")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = True


                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Baixado")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Não Fazer")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Cancelado")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    ButtonSolicitar.Visible = True
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Finalizado")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    AvisarDiaMaskedTextBox.Text = ""
                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True


                Case SituacaoComboBox.Text.Contains("Provisório")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Protocolado")
                    TabAlvara.SelectTab(3)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Pendência")
                    TabAlvara.SelectTab(1)
                    AvisarDiaMaskedTextBox.Select()
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Não Iniciado")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = False
                    'protocolo
                    GroupBoxProtocolo.Visible = False

                    AvisarDiaMaskedTextBox.Select()
                    ButtonSolicitar.Visible = True
                    ButtonConsultar.Visible = False



                Case SituacaoComboBox.Text.Contains("Finalizado Definitivo")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    AvisarDiaMaskedTextBox.Text = ""
                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True
                    'ambiental
                    If LabelAmbientalDataProvisorio.Text = "" Then
                        LabelAmbientalDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                    'viabilidade
                    If LabelViabilidadeDataProvisorio.Text = "" Then
                        LabelViabilidadeDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                    'sanitario
                    If LabelSanitarioDataProvisorio.Text = "" Then
                        LabelSanitarioDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                    'setran
                    If LabelSetranDataProvisorio.Text = "" Then
                        LabelSetranDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If

                Case Else
                    DataEntradaLabel.Visible = True
                    'protocolo
                    GroupBoxProtocolo.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True
            End Select
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar Situação")
        End Try


    End Sub

    Private Sub PreSalvar()
        Salvar()
    End Sub

    ' INICIO SALVAR
    ' Variável para controlar o fechamento do formulário
    Private cancelarFechamento As Boolean = False
    Private Sub Salvar()
        Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text

        Try
            ' Forçar a validação e finalizar edição nos controles ligados ao BindingSource
            Me.Validate()
            Me.LaudosBindingSource.EndEdit()

            ' Obter as mudanças no DataSet
            Dim changedRecords As System.Data.DataTable = PrinceDBDataSet.Laudos.GetChanges()

            ' Verificar se há alterações reais no DataSet
            If changedRecords IsNot Nothing AndAlso changedRecords.Rows.Count > 0 Then
                ' Criar strings para armazenar o resumo e os detalhes das mudanças
                Dim changesDescription As String = ""
                Dim detailedChanges As String = ""

                ' Iterar sobre as linhas alteradas
                For Each row As DataRow In changedRecords.Rows
                    ' Adiciona o ID do laudo ao resumo
                    changesDescription &= "Alterações na linha com ID: " & row("ID_Laudos").ToString() & vbCrLf

                    Dim columnChangesCount As Integer = 0

                    ' Iterar sobre as colunas para identificar as mudanças
                    For Each column As DataColumn In changedRecords.Columns
                        ' Verificar se o registro não é novo antes de acessar dados originais
                        If row.RowState <> DataRowState.Added Then
                            If Not row(column, DataRowVersion.Original).Equals(row(column, DataRowVersion.Current)) Then
                                columnChangesCount += 1
                                detailedChanges &= "  - " & column.ColumnName & ": " & row(column, DataRowVersion.Original).ToString() & " => " & row(column, DataRowVersion.Current).ToString() & vbCrLf
                            End If
                        Else
                            columnChangesCount += 1
                            detailedChanges &= "  - " & column.ColumnName & ": Novo valor: " & row(column, DataRowVersion.Current).ToString() & vbCrLf
                        End If
                    Next

                    changesDescription &= "  (" & columnChangesCount & " mudanças)" & vbCrLf
                Next

                ' Perguntar ao usuário se deseja ver os detalhes das alterações antes de salvar
                Dim verDetalhes As DialogResult = MessageBox.Show("Deseja ver os detalhes das alterações?", "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If verDetalhes = DialogResult.Yes Then
                    MessageBox.Show(detailedChanges, "Detalhes das Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Perguntar ao usuário se deseja salvar as alterações
                Dim message As String = "Foram feitas " & changedRecords.Rows.Count.ToString() & " alterações." & vbCrLf & "Deseja salvar as alterações?" & vbCrLf & vbCrLf & changesDescription
                Dim result As DialogResult = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

                Select Case result
                    Case DialogResult.Cancel
                        ' Não faça nada, apenas sair do método
                        cancelarFechamento = True

                    Case DialogResult.No
                        ' Reverter mudanças e desativar edição
                        ReverterAlteracoes()
                        cancelarFechamento = False

                    Case DialogResult.Yes
                        Try
                            ' Salvar alterações
                            Dim rowsAffected As Integer = Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)

                            ' Verificar se o salvamento foi bem-sucedido
                            If rowsAffected > 0 Then
                                ' MessageBox.Show("Alterações salvas com sucesso.", "Prince Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Nenhuma alteração foi salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                            ' Sincronizar e desativar edição
                            SincronizarDados()

                        Catch exc As Exception
                            MessageBox.Show("Ocorreu um erro ao salvar." & vbCrLf & exc.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try
                        cancelarFechamento = False
                End Select
            Else
                ' Não há alterações, apenas desativar edição
                DesativarEdicao()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar." & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub






    Private Sub SalvarAntigo()
        Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text

        Try
            ' Forçar a validação e finalizar edição nos controles ligados ao BindingSource
            Me.Validate()
            Me.LaudosBindingSource.EndEdit()

            ' Obter registros adicionados ou modificados no DataTable
            Dim changes As DataTable = PrinceDBDataSet.Laudos.GetChanges()

            ' Verificar se há alterações para salvar (adicionados ou modificados)
            If changes IsNot Nothing AndAlso changes.Rows.Count > 0 Then
                ' Criar uma string para armazenar as mudanças
                Dim changesDescription As String = ObterDescricaoAlteracoes(changes)

                ' Mostrar a quantidade de alterações e as mudanças
                Dim message As String = "Foram detectadas mudanças." & vbCrLf & "Deseja salvar as alterações?" & vbCrLf & vbCrLf & changesDescription
                Dim result As DialogResult = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

                Select Case result
                    Case DialogResult.Cancel
                        ' Não faça nada, apenas sair do método
                        Exit Sub

                    Case DialogResult.No
                        ' Reverter mudanças e desativar edição
                        ReverterAlteracoes()

                    Case DialogResult.Yes
                        Try
                            ' Salvar alterações
                            Dim rowsAffected As Integer = Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)

                            ' Verificar se o salvamento foi bem-sucedido
                            If rowsAffected > 0 Then
                                MessageBox.Show("Alterações salvas com sucesso.", "Prince Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Nenhuma alteração foi salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                            ' Recarregar e desativar edição
                            SincronizarDados()

                        Catch exc As Exception
                            MessageBox.Show("Ocorreu um erro ao salvar." & vbCrLf & exc.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try
                End Select
            Else
                ' Não há alterações, apenas desativar edição
                DesativarEdicao()
                MessageBox.Show("Nenhuma alteração foi detectada.", "Prince Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar." & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' Função para obter descrição das alterações
    Private Function ObterDescricaoAlteracoes(changes As DataTable) As String
        Dim changesDescription As String = ""

        ' Iterar sobre as linhas adicionadas ou modificadas
        For Each row As DataRow In changes.Rows
            If row.RowState = DataRowState.Added Then
                changesDescription &= "Novo registro adicionado com ID: " & row("ID_Laudos").ToString() & vbCrLf
            ElseIf row.RowState = DataRowState.Modified Then
                changesDescription &= "Alterações na linha com ID: " & row("ID_Laudos").ToString() & vbCrLf

                ' Iterar sobre as colunas para identificar as mudanças
                For Each column As DataColumn In changes.Columns
                    If Not row(column, DataRowVersion.Original).Equals(row(column, DataRowVersion.Current)) Then
                        changesDescription &= "  - " & column.ColumnName & ": " &
                        row(column, DataRowVersion.Original).ToString() & " => " &
                        row(column, DataRowVersion.Current).ToString() & vbCrLf
                    End If
                Next
                changesDescription &= vbCrLf
            End If
        Next

        Return changesDescription
    End Function

    ' Função para reverter alterações e recarregar dados
    Private Sub ReverterAlteracoes()
        PrinceDBDataSet.Laudos.RejectChanges()
        SincronizarDados()
    End Sub

    ' Função para recarregar dados e desativar edição
    Private Sub SincronizarDados()
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        DesativarEdicao()
    End Sub

    ' Função para desativar a edição e resetar o estado da interface
    Private Sub DesativarEdicao()
        BtnEditar.Text = "Editar"
        CheckBoxPrioridade.Enabled = False
        GroupBox4.Enabled = False
        Button17.Enabled = True
        ComboBoxBuscaCNPJ.Text = CNPJMaskedTextBox.Text
        ComboBoxBuscaCNPJ.Select()
        DesativaDataProvisorio()
    End Sub



    Public Sub SalvarExterno()
        Salvar()
    End Sub











    ' FIM SALVAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControlAcompanhamento.SelectTab(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControlAcompanhamento.SelectTab(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControlAcompanhamento.SelectTab(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControlAcompanhamento.SelectTab(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControlAcompanhamento.SelectTab(4)
    End Sub

    Public Sub ALVARAEsconderAtalhosNavegadorPadrao()
        'Simples Nacional
        WebSiteGERAL.ToolStripDropDownButton2.Visible = False
        'RedeSim
        WebSiteGERAL.ToolStripDropDownButton3.Visible = False
        'BtnTSE
        WebSiteGERAL.BtnTSE.Visible = False
        'BtnProcuracao
        WebSiteGERAL.BtnProcuracao.Visible = False
        'ToolStripDropDownButton4
        WebSiteGERAL.ToolStripDropDownButton4.Visible = False


        'DIVISORIAS
        'Divisoria Simples e RedeSim 
        'ToolStripSeparator3
        WebSiteGERAL.ToolStripSeparator3.Visible = False
        'RedeSim e Alvara
        'ToolStripSeparator6
        WebSiteGERAL.ToolStripSeparator6.Visible = False
        'Alvará e titulo de eleitor
        'ToolStripSeparator8
        WebSiteGERAL.ToolStripSeparator8.Visible = False
        'titulo de eleitor e procuração
        'ToolStripSeparator9
        WebSiteGERAL.ToolStripSeparator9.Visible = False
        'procuração e receita federal
        'ToolStripSeparator10
        WebSiteGERAL.ToolStripSeparator10.Visible = False
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        Try
            'Abrir anotações direto
            TabAlvara.SelectTab(1)
            TabControlAcompanhamento.SelectTab(0)
            Dim NLaudo As String = NlaudoTextBox.Text

            ' Normalizar o texto da cidade para comparação
            Dim cidadeNormalizada As String = RemoveDiacritics(EndCidadeLabel2.Text).ToLower()

            ' Verificação baseada no modelo do sistema e na cidade
            Select Case ModeloSistemaComboBox.Text
                Case "Alvará Antigo"
                    BoxJuntaComercialLaudo.Show()
                    'ALVARAEsconderAtalhosNavegadorPadrao()

                Case "Alvará Online"
                    BoxJuntaComercialLaudo.Show()
                   ' ALVARAEsconderAtalhosNavegadorPadrao()
                Case "Alvará Manual"
                    MessageBox.Show("Ligar ou Comparecer na Prefeitura da cidade onde foi solicitado", "Prince Ajuda")

                Case "Consulta Prévia"
                    MessageBox.Show("Consulta Prévia solicitada antes do pedido de alvará na Prefeitura", "Prince Ajuda")

                Case "Empresa Fácil"
                    If String.IsNullOrWhiteSpace(EndEstadoLabel2.Text) Then
                        MessageBox.Show("Estado e/ou cidade não cadastrados, favor contatar o administrador do sistema", "Prince Ajuda")
                    Else
                        BoxJuntaComercialLaudo.Show()
                    End If
                    ALVARAEsconderAtalhosNavegadorPadrao()


                Case "MEI - Dispensa de Alvará"
                    If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                        WebSiteGERAL.Focus()
                        WebSiteGERAL.MdiParent = MDIPrincipal
                        WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                        Select Case True
                            Case cidadeNormalizada.Contains("maring")
                                WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                            Case cidadeNormalizada.Contains("sarandi")
                                MessageBox.Show("Manual na prefeitura com documento assinado!", "Prince Ajuda")
                        End Select
                    End If
                    ALVARAEsconderAtalhosNavegadorPadrao()

                Case "MEI - Alvará Online"
                    ' Copiar o número do laudo para a área de transferência
                    Clipboard.SetText(NLaudo)
                    MessageBox.Show("Número do Laudo Copiado = " & NLaudo, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                        WebSiteGERAL.Focus()
                        WebSiteGERAL.MdiParent = MDIPrincipal
                        Select Case True
                            Case cidadeNormalizada.Contains("maring")
                                WebSiteGERAL.WebView.Source = New Uri("http://venus.maringa.pr.gov.br:9900/fazendaonline/app/consultaPrevia?execution=e5s1")
                            Case cidadeNormalizada.Contains("sarandi")
                                WebSiteGERAL.WebView.Source = New Uri("http://200.233.108.153:8080/WebEloAlvaraOnline/app/consultaPrevia?execution=e3s1")
                        End Select
                    End If
                    ALVARAEsconderAtalhosNavegadorPadrao()

                Case Else
                    MessageBox.Show("Sem sistema para consulta", "Prince Sistemas - Alerta")
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Prince Sistemas - Alerta")
        End Try
    End Sub

    Private Function RemoveDiacritics(text As String) As String
        Dim normalizedString As String = text.Normalize(NormalizationForm.FormD)
        Dim stringBuilder As New StringBuilder()

        For Each c As Char In normalizedString
            Dim unicodeCategory As Globalization.UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c)
            If unicodeCategory <> Globalization.UnicodeCategory.NonSpacingMark Then
                stringBuilder.Append(c)
            End If
        Next

        Return stringBuilder.ToString().Normalize(NormalizationForm.FormC)
    End Function


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnCalendarioWindows.Click
        If MsgBox(" Deseja salvar vencimento do Alvará no Calendário do Windows ?", MsgBoxStyle.YesNo, "Prince Sistemas - Pergunta") = MsgBoxResult.Yes Then

            Try
                '  Dim Abrir As New Process
                ' Abrir.StartInfo.FileName = "outlookcal:"
                '  Abrir.Start()
                System.Diagnostics.Process.Start("outlookcal:")
            Catch
                MessageBox.Show("Funciona apenas no Windows 10 ou superior", "Prince Sistema - Informa!")

            End Try


        End If






    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Salvar()

            Me.Validate()
            Me.LaudosBindingSource.AddNew()

            SituacaoComboBox.SelectedIndex = -1

            'unchek lembrete
            LembreteCheckBox.CheckState = CheckState.Unchecked
            PrioridadeCheckBox.CheckState = CheckState.Unchecked

            'Uncheck controle de ligações
            BombeirosCheckBox.CheckState = CheckState.Unchecked
            ViabilidadeCheckBox.CheckState = CheckState.Unchecked
            AmbientalCheckBox.CheckState = CheckState.Unchecked
            SanitarioCheckBox.CheckState = CheckState.Unchecked
            SetranCheckBox.CheckState = CheckState.Unchecked

            'Combobox
            SituacaoComboBox.Text = "Não Iniciado"
            ModeloSistemaComboBox.SelectedIndex = -1
            BombeiroSituacaoComboBox.SelectedIndex = -1

            'data agora
            DataCriadoMaskedTextBox.Text = DateTime.Now.ToString()

            Editar()
            MatrizComboBox.SelectedIndex = -1

        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            If MsgBox("Tem certeza que deseja apagar o registo ?", MsgBoxStyle.YesNo, "A T E N Ç Ã O") = MsgBoxResult.Yes Then
                Me.Validate()
                Me.LaudosBindingSource.RemoveCurrent()
                Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim razaosocial As String = RazaoSocialTextBox.Text
        Salvar()
        If RazaoSocialTextBox.Text <> "" Then
            ComboBoxBuscaAlvara.Text = razaosocial
            ComboBoxBuscaAlvara.Focus()
            InicializarControles()

        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Me.Close()

    End Sub

    Private Sub LaudosConsulta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salvar()

        ' Verifica se o fechamento foi cancelado.
        If cancelarFechamento Then
            ' Cancela o fechamento do formulário.
            e.Cancel = True
            ' Exibe uma mensagem para indicar que o fechamento foi interrompido.
            MessageBox.Show("O fechamento foi cancelado.", "Fechamento Interrompido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If WebSiteGERAL.Visible = False Then
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("http://www.prevfogo.pr.gov.br/")
        Else
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("http://www.prevfogo.pr.gov.br/")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If FrmProtegeFacil.Visible = False Then
            FrmProtegeFacil.Show()
            ' FrmProtegeFacil.MdiParent = MDIPrincipal
        Else
            FrmProtegeFacil.Focus()
            '  FrmProtegeFacil.MdiParent = MDIPrincipal
        End If
    End Sub



    Private Sub NlaudoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NlaudoTextBox.TextChanged
        NlaudoTextBox.Text = NlaudoTextBox.Text.Replace(" ", "")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Application.OpenForms.OfType(Of Telefones)().Count() > 0 Then

            Telefones.Focus()


        Else

            ' Telefones.MdiParent = Me
            Telefones.Show()

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Application.OpenForms.OfType(Of ContadorGeral)().Count() > 0 Then

            ContadorGeral.Focus()
            '   Contador.MdiParent = MDIPrincipal


        Else

            ' Contador.MdiParent = MDIPrincipal
            ContadorGeral.Show()


        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Dim CNPJ As String = CNPJMaskedTextBox.Text
            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br/laudosnew/mostrar_validacao_cod_controle.php?cod_pmm=" & Sanitariocontrole1TextBox.Text & "&cod_controle=" & Sanitariocontrole2TextBox.Text & "&cod_ca=" & Sanitariocontrole3TextBox.Text & "&Submit=Mostrar")
    End Sub




    Private Async Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(EndCEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                EnderecoTextBox.Text = resultado.logradouro
                If EndCompTextBox.Text = "" Then
                    EndCompTextBox.Text = resultado.complemento
                Else
                    'nao faz nada
                End If
                EndCidadeTextBox.Text = resultado.localidade
                EndBairroTextBox.Text = resultado.bairro
                EndEstadoTextBox.Text = resultado.uf

                BtnCorrigeCidade.PerformClick() 'corrige a cidade com acentos
            Else
                MessageBox.Show("CEP não encontrado.")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar informações de CEP: " & ex.Message)
        End Try
    End Sub


    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br:9900/fazendaonline/")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TabControl2.SelectTab(1)
        TabControl2.SelectTab(4)
        CNPJRequerenteMaskedTextBox.Text = CNPJMaskedTextBox.Text
        EndRequerenteTextBox.Text = EnderecoTextBox.Text & ", Nº: " & EndNumTextBox.Text & ", " & EndCompTextBox.Text & ", " & EndBairroTextBox.Text & ", CEP: " & EndCEPMaskedTextBox.Text & ", " & EndCidadeTextBox.Text & "-" & EndEstadoTextBox.Text
        'FoneRequerenteTextBox.Text = TelefoneMaskedTextBox.Text
        'EmailRequerenteTextBox.Text = "legalizacaobetel@gmail.com"

        If Trim(FoneRequerenteTextBox.Text) = "" Then
            ContadorGeral.Show() ' pégando apenas o 1 cadastro
            FoneRequerenteTextBox.Text = ContadorGeral.TelefoneMaskedTextBox.Text
        End If

        If Trim(EmailRequerenteTextBox.Text) = "" Then
            ContadorGeral.Show() ' pégando apenas o 1 cadastro
            EmailRequerenteTextBox.Text = ContadorGeral.EmailTextBox.Text
        End If

        ContadorGeral.Close()

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            Button9.Visible = True


        Else
            Button9.Visible = False


        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles ButtonSolicitar.Click
        GroupBox4.Text = "Dados Cadastrais"
        Dim url As String = String.Empty
        Dim showWebSiteGERAL As Boolean = True
        Dim showMessage As Boolean = False
        Dim messageText As String = String.Empty

        Select Case ModeloSistemaComboBox.Text
            Case "Alvará Antigo"
                BoxJuntaComercialLaudo.Show()

            Case "Alvará Online"
                BoxJuntaComercialLaudo.Show()

            Case "Alvará Manual"
                showMessage = True
                messageText = "Documentos Manuais da Prefeitura da cidade onde a empresa se localiza"
                showWebSiteGERAL = False

            Case "Consulta Prévia"
                showMessage = True
                messageText = "Consulta Prévia realizada no site da prefeitura ou Junta-Unificada"
                showWebSiteGERAL = False

            Case "Bombeiro Certificado"
                TabAlvara.SelectTab(1)
                showWebSiteGERAL = False

            Case "MEI - Dispensa de Alvará"
                BoxJuntaComercialLaudo.Show()


            Case "MEI - Alvará Online"
                BoxJuntaComercialLaudo.Show()


            Case Else
                showMessage = True
                messageText = "Informar qual tipo de sistema utilizado na solicitação do laudo - alvará de localização"
                showWebSiteGERAL = False
        End Select

        If showMessage Then
            MessageBox.Show(messageText, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If showWebSiteGERAL AndAlso Not String.IsNullOrEmpty(url) Then
            Dim webSiteForm As WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().FirstOrDefault()

            If webSiteForm IsNot Nothing Then
                webSiteForm.Focus()
            Else
                webSiteForm = New WebSiteGERAL()
                webSiteForm.MdiParent = MDIPrincipal
                webSiteForm.Show()
            End If

            webSiteForm.WebView.Source = New Uri(url)
        End If
    End Sub


    Private Sub SituacaoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SituacaoComboBox.TextChanged, SituacaoComboBox.SelectedIndexChanged
        ' Chama o método SituacaoCombo quando o valor for alterado
        SituacaoCombo()
    End Sub


    Private Sub Btnempresa_Click(sender As Object, e As EventArgs) Handles Btnempresa.Click
        Call ConexaoEmpresa()

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabAlvara.SelectTab(0)
        TabControl2.SelectTab(1)

        FrmProcedimentos.Show()
        If EndCidadeTextBox.Text = "" Then

            MessageBox.Show("Campo em Dados Cadastrais/Endereço/Cidade está vazio", "Prince Sistemas - Alerta")

        ElseIf EndEstadoTextBox.Text = "" Then
            MessageBox.Show("Campo em Dados Cadastrais/Endereço/Estado está vazio", "Prince Sistemas - Alerta")

        End If

        FrmProcedimentos.TxtCidade.Text = EndCidadeTextBox.Text
        FrmProcedimentos.TxtEstado.Text = EndEstadoTextBox.Text
        FrmProcedimentos.BtnBusca.PerformClick()
    End Sub




    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        NaturezaDoPedidoRichTextBox.Text &= "
" & NaturezaListBox.SelectedItem & " / "

    End Sub

    Private Sub CMCLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CMCLabel.LinkClicked
        MessageBox.Show("Nº. do Cadastro Municipal", "Prince Sistemas - Informa")

    End Sub

    Private Sub BtnAtualizarDados_Click(sender As Object, e As EventArgs) Handles BtnAtualizarDados.Click
        If MessageBox.Show("Deseja efetuar a atualização dos dados apenas?", "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'ModCon.Historico()
            ModCon.Atualizadadadoslaudo()
        End If

    End Sub


    Private Sub BtnNovaAlteracao_Click(sender As Object, e As EventArgs) Handles BtnNovaAlteracao.Click


        If MessageBox.Show("Deseja fazer nova alteração no Laudo?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ModCon.Historico()
            ' ModCon.Atualizadadadoslaudo()

        ElseIf System.Windows.Forms.DialogResult.No Then
            If MessageBox.Show("Tem certeza que deseja limpar os dados do andamento geral?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                SituacaoComboBox.SelectedIndex = -1
                'Limpando as BOX
                NlaudoTextBox.Text = ""
                NlaudoSecundarioTextBox.Text = ""
                ModeloSistemaComboBox.Text = ""
                NaturezaDoPedidoRichTextBox.Text = ""

                DataEntradaMaskedTextBox.Text = ""
                ProtocoloTipoTextBox.Text = ""
                ProtocoloNTextBox.Text = ""
                ProtocoloAnoTextBox.Text = ""
                ProtocoloSenhaTextBox.Text = ""
            Else
            End If

        Else

        End If

    End Sub

    Private Sub BtnBombVer_Click(sender As Object, e As EventArgs) Handles BtnBombVer.Click
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)
    End Sub


    Private Sub BombeiroSituacaoComboBox_Enter(sender As Object, e As EventArgs) Handles BombeiroSituacaoComboBox.Enter
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)
    End Sub

    Private Sub Editar()
        If BtnEditar.Text = "Editar" Then
            BtnEditar.Text = "Cancelar"
            CheckBoxPrioridade.Enabled = True
            GroupBox4.Enabled = True
            Button17.Enabled = False

        ElseIf BtnEditar.Text = "Cancelar" Then
            ' Perguntar se o usuário deseja cancelar
            Dim resultado As DialogResult = MessageBox.Show("Deseja cancelar as alterações e reverter os dados?",
                                                         "Cancelar Edição", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                Dim RazaoSocial As String = RazaoSocialTextBox.Text

                ' Cancelar as alterações feitas
                Me.LaudosBindingSource.CancelEdit()

                ' Atualizar os dados da tabela
                Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

                ' Permitir que o sistema processe os eventos pendentes
                Application.DoEvents()

                ' Reposicionar o foco
                BtnEditar.Text = "Editar"
                CheckBoxPrioridade.Enabled = False
                GroupBox4.Enabled = False
                Button17.Enabled = True

                ComboBoxBuscaAlvara.Text = RazaoSocial
                ComboBoxBuscaAlvara.Focus()
            Else
                ' Manter o modo de edição
                BtnEditar.Text = "Cancelar"
                CheckBoxPrioridade.Enabled = True
                GroupBox4.Enabled = True
                Button17.Enabled = False
            End If
        End If
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()
        InicializarControles()
        VerificarFiliais()
    End Sub

    Private Sub ModeloSistemaComboBox_TextChanged(sender As Object, e As EventArgs) Handles ModeloSistemaComboBox.TextChanged
        If ModeloSistemaComboBox.Text = "Consulta Prévia" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Empresa Fácil" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = False

        ElseIf ModeloSistemaComboBox.Text = "MEI - Dispensa de Alvará" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "MEI - Alvará Online" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            NlaudoSecundarioTextBox.Visible = True
            ButtonConsultar.Visible = True
        Else
            NlaudoLabel.Visible = False
            NlaudoTextBox.Visible = False
            NlaudoSecundarioTextBox.Visible = False
            ButtonConsultar.Visible = False

        End If

    End Sub

    Private Sub BtnNovoProtocolo_Click(sender As Object, e As EventArgs) Handles BtnNovoProtocolo.Click
        If MessageBox.Show("Deseja salvar o protocolo no histórico?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ModCon.SalvaProtocolo()
            ' ModCon.Atualizadadadoslaudo()
        ElseIf System.Windows.Forms.DialogResult.No Then
            If MessageBox.Show("Tem certeza que deseja limpar o protocolo?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                'Limpando as BOX
                DataEntradaMaskedTextBox.Text = ""
                ProtocoloTipoTextBox.Text = ""
                ProtocoloNTextBox.Text = ""
                ProtocoloAnoTextBox.Text = ""
                ProtocoloSenhaTextBox.Text = ""
                NumeroProcessoTextBox.Text = ""
                ReciboProcessoTextBox.Text = ""
            Else
            End If

        Else

        End If

    End Sub

    Private Sub BtnProcotBomb_Click(sender As Object, e As EventArgs) Handles BtnProcotBomb.Click
        If MessageBox.Show("Deseja salvar o protocolo no histórico?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ModCon.SalvaProtocolBomb()

            ' ModCon.Atualizadadadoslaudo()
        ElseIf System.Windows.Forms.DialogResult.No Then
            If MessageBox.Show("Tem certeza que deseja limpar o protocolo?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                'Limpando as BOX
                BombeiroNProcessoMaskedTextBox.Text = ""
                BombeiroDataPedProcessoMaskedTextBox.Text = ""

            Else
            End If

        Else

        End If
    End Sub

    Private Sub BtnData1_Click(sender As Object, e As EventArgs) Handles BtnData1.Click
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        BombeiroDataPedProcessoMaskedTextBox.Text = DateTime.Now.ToString()

    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Try
            ' Obter o valor do campo
            Dim Processo As String = BombeiroNProcessoMaskedTextBox.Text

            ' Verifica se o campo está vazio ou nulo
            If String.IsNullOrWhiteSpace(Processo) Then
                MessageBox.Show("O campo de número de processo está vazio. Por favor, preencha o campo para copiar.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Copiar o valor para a área de transferência, removendo caracteres indesejados
            Clipboard.SetText(Processo.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

            ' Informar ao usuário que o processo foi copiado
            MessageBox.Show("Número do processo copiado para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Tratar erros inesperados
            MessageBox.Show("Ocorreu um erro ao copiar o número do processo: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    '/////////// Inicio do codigo de mostrar calendario
    '///// TEM MAIS NO LOAD 
    Private Sub AvisarDiaMaskedTextBox_Click(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Click
        DialogCalendarioAlvara.Show()
        DialogCalendarioAlvara.Focus()
        'abrir no local onde está o mouse
        DialogCalendarioAlvara.Location = New Point(MousePosition.X, MousePosition.Y)

    End Sub


    Private Sub AvisarDiaMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Leave
        DialogCalendarioAlvara.Close()

    End Sub



    '/////////// fim do codigo de mostrar calendario


    Private Sub BtnAnotacoes_Click(sender As Object, e As EventArgs) Handles BtnAnotacoes.Click
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)
    End Sub

    Private Sub BtnContLigacao_Click(sender As Object, e As EventArgs) Handles BtnContLigacao.Click
        If Application.OpenForms.OfType(Of FrmLigacaoAlvara)().Count() > 0 Then

            FrmLigacaoAlvara.Focus()


        Else

            FrmLigacaoAlvara.MdiParent = MDIPrincipal
            FrmLigacaoAlvara.Show()

        End If
    End Sub

    Private Sub EndCidadeLabel2_Click(sender As Object, e As EventArgs) Handles EndCidadeLabel2.Click
        If EndCidadeLabel2.Text = "" Then

        Else
            TabAlvara.SelectTab(2)

        End If
    End Sub

    Private Sub BtnAnotacoesPref_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesPref.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Prefeitura Municipal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesLEgalizacao_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesLEgalizacao.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Prefeitura Municipal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Erro!" & vbCrLf & ex.Message)
        End Try
    End Sub

    '  Private Sub SituacaoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SituacaoComboBox.KeyPress
    '    e.Handled = True 'nao permitir escrita
    '  End Sub

    'Private Sub ModeloSistemaComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ModeloSistemaComboBox.KeyPress
    '    e.Handled = True 'nao permitir escrita
    ' End Sub




    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        If Application.OpenForms.OfType(Of FrmAtalhoBuscadores)().Count() > 0 Then

            FrmAtalhoBuscadores.Focus()
            FrmAtalhoBuscadores.Close()
            ' FrmAtalhoBuscadores.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAtalhoBuscadores.Show()
            'Me.Close()

        Else

            'FrmAtalhoBuscadores.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAtalhoBuscadores.Show()
            ' Me.Close()
        End If
    End Sub




    '////////////////////////////// INICIO LABEL DATA PROVISORIO ////////////////////////////////////////////////
    'Bombeiro
    Private Sub LabelBombeiroDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelBombeiroDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelBombeiroDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelBombeiroDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelBombeiroDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelBombeiroDataProvisorio.Text = OrderDateExtenso
            Else
                'verifica se o campo está vazio
                If LabelBombeiroDataProvisorio.Text = "" Then
                    'verifica se o BombeiroSituacaoComboBox está como "Finalizado Definitivo"
                    If BombeiroSituacaoComboBox.Text = "Finalizado Definitivo" Then
                        LabelBombeiroDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                End If
            End If
        End If

    End Sub

    'Ambiental
    Private Sub LabelAmbientalDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelAmbientalDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelAmbientalDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelAmbientalDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelAmbientalDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelAmbientalDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub


    'Viabilidade
    Private Sub LabelViabilidadeDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelViabilidadeDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelViabilidadeDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelViabilidadeDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelViabilidadeDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelViabilidadeDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub

    'Sanitario
    Private Sub LabelSanitarioDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelSanitarioDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelSanitarioDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelSanitarioDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelSanitarioDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelSanitarioDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub

    'Setran
    Private Sub LabelSetranDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelSetranDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelSetranDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelSetranDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelSetranDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelSetranDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub


    '//////////////////////////////////////// FIM DATA PROVISORIO //////////////////////////////////////////////


    Private Sub BombeiroSituacaoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BombeiroSituacaoComboBox.SelectedIndexChanged
        If BombeiroSituacaoComboBox.Text = "Finalizado Definitivo" Then
            LabelBombeiroDataProvisorio.Text = "Liberado - Alvará Definitivo"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked, LinkLabel2.LinkClicked
        'abri o link externo http://www.maringa.pr.gov.br/site/index.php?sessao=37549ccd71a237&artigo=25
        System.Diagnostics.Process.Start("http://www.maringa.pr.gov.br/site/index.php?sessao=37549ccd71a237&artigo=25")
    End Sub

    Private Sub BtnMgsBoxAvisarDia_Click(sender As Object, e As EventArgs) Handles BtnMgsBoxAvisarDia.Click
        Try
            Dim a As DateTime
            a = AvisarDiaMaskedTextBox.Text
            MsgBox(a.ToLongDateString)
            'avisar que cai no final de semana
            If a.DayOfWeek = DayOfWeek.Saturday Or a.DayOfWeek = DayOfWeek.Sunday Then
                MsgBox("Cai no fim de semana, alterando para proximo dia útil")
                'se for domingo ou sabado , mudar data do AvisarDiaMaskedTextBox para segunda feira
                If a.DayOfWeek = DayOfWeek.Sunday Then
                    AvisarDiaMaskedTextBox.Text = a.AddDays(1)
                ElseIf a.DayOfWeek = DayOfWeek.Saturday Then
                    AvisarDiaMaskedTextBox.Text = a.AddDays(2)
                End If
            End If
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub BtnExportarWord_Click(sender As Object, e As EventArgs) Handles BtnExportarWord.Click
        If ExportarLaudoWordDialog.Visible = True Then
            ExportarLaudoWordDialog.Focus()
        Else
            ExportarLaudoWordDialog.Show()
        End If
    End Sub

    Private Sub BtnImportaSocio_Click(sender As Object, e As EventArgs) Handles BtnImportaSocio.Click
        'verifica se tem RequerenteTextBox preenchido ou abre
        If RequerenteTextBox.Text = "" Then
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
            Else
                FrmSocios.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
                'igual do frmsocios.RequerenteTextBox.text
                FrmSocios.NomeCompletoComboBox.Text = RequerenteTextBox.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = RequerenteTextBox.Text
            End If

        End If
    End Sub

    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        ' Chamar o método de verificação
        VerificarCNPJ(CNPJMaskedTextBox.Text)
    End Sub

    Private Sub VerificarCNPJ(cnpj As String)
        ' O CNPJ está no formato já formatado com máscara
        Dim cnpjFormatado As String = cnpj

        Using connection As New SqlConnection(str)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando CNPJ: " & cnpjFormatado)

                ' Consultar o CNPJ na tabela "Laudos"
                Dim query As String = "SELECT CNPJ FROM Laudos WHERE CNPJ = @CNPJ"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        ' Log do resultado encontrado
                        Debug.WriteLine("CNPJ encontrado na tabela Laudos: " & cnpjFormatado)

                        ' Se o CNPJ estiver cadastrado, buscar a razão social
                        Dim queryRazaoSocial As String = "SELECT RazaoSocial FROM Empresas WHERE CNPJ = @CNPJ"
                        Using cmdRazaoSocial As New SqlCommand(queryRazaoSocial, connection)
                            cmdRazaoSocial.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                            Dim razaoSocial As String = Convert.ToString(cmdRazaoSocial.ExecuteScalar())
                            MessageBox.Show("Empresa já cadastrada!" & vbCrLf & "CNPJ: " & cnpjFormatado & vbCrLf & "Razão Social: " & razaoSocial)
                        End Using
                    Else
                        MessageBox.Show("CNPJ não cadastrado.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnMapa_Click(sender As Object, e As EventArgs) Handles BtnMapa.Click

        Mapa()
    End Sub

    Private Sub Mapa()
        ' Obtém o número do cadastro imobiliário a partir do TextBox
        Dim cadastroImobiliario As String = CadImobTextBox.Text.Trim()

        ' Verifica se o campo está vazio
        If String.IsNullOrEmpty(cadastroImobiliario) Then
            MessageBox.Show("Por favor, insira um número de cadastro imobiliário.", "Número de Cadastro Imobiliário Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Copia o número do cadastro imobiliário para a área de transferência
        Clipboard.SetText(cadastroImobiliario)

        ' Mensagem de pergunta ao usuário
        Dim result As DialogResult = MessageBox.Show(
        String.Format("Deseja abrir o mapa da cidade com o cadastro imobiliário {0}?", cadastroImobiliario),
        "Abrir Mapa",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        ' Verifica a resposta do usuário
        If result = DialogResult.Yes Then
            ' Verifica se a janela do site já está visível
            If WebSiteGERAL.Visible Then
                ' Coloca foco e traz para a frente
                WebSiteGERAL.Focus()
                WebSiteGERAL.BringToFront()
            Else
                ' Mostra a janela do site
                WebSiteGERAL.Show()
                WebSiteGERAL.BringToFront()
            End If

            ' Define a URL com o número do cadastro imobiliário
            WebSiteGERAL.WebView.Source = New Uri("http://geoproc.maringa.pr.gov.br:8090/SIGMARINGA/")
        End If
    End Sub

    Private Sub BtnCopiaCEP_Click(sender As Object, e As EventArgs) Handles BtnCopiaCEP.Click
        ' Obter o texto do CEPMaskedTextBox
        Dim cep As String = EndCEPMaskedTextBox.Text

        ' Remover o hífen
        Dim cepSemHifen As String = cep.Replace("-", "")

        ' Copiar o resultado para a área de transferência
        Clipboard.SetText(cepSemHifen)

        ' Informar ao usuário que o CEP foi copiado
        MessageBox.Show("CEP copiado para a área de transferência: " & cepSemHifen, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '//////////////////////////////////////// INICIO DATA PROVISORIO ////////////////////////////////////////////////////////////////
    Private Sub SalvarAlteracoes()
        Try
            Me.LaudosBindingSource.EndEdit()
            Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
            MsgBox("Alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar alterações: " & ex.Message)
        End Try
    End Sub


    'VIABILIDADE
    Private Sub ButtonAddDataViabilidade_Click(sender As Object, e As EventArgs) Handles ButtonAddDataViabilidade.Click
        'pergunta se deseja adicionar
        If MsgBox("Deseja Adicionar uma nova data provisório do Viabilidade?" & vbCrLf &
      "Salvar empresa antes de alterar para outra empresa",
      MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Adicionar data Viabilidade") = MsgBoxResult.Yes Then
            'visible true AmbientalProvisorioDATAMaskedTextBox
            ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = False
            'limpar AmbientalProvisorioDATAMaskedTextBox
            ViabilidadeProvisorioDATAMaskedTextBox.Text = ""
        Else
            'visible true AmbientalProvisorioDATAMaskedTextBox
            ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = True
        End If
    End Sub

    ' Adicionar Data Ambiental
    Private Sub ButtonAddDataAmbiental_Click(sender As Object, e As EventArgs) Handles ButtonAddDataAmbiental.Click
        If MsgBox("Deseja Adicionar uma nova data provisório do Ambiental?", MsgBoxStyle.YesNo, "Adicionar data Ambiental") = MsgBoxResult.Yes Then
            AmbientalProvisorioDATAMaskedTextBox.ReadOnly = False
            AmbientalProvisorioDATAMaskedTextBox.Text = ""
        Else
            AmbientalProvisorioDATAMaskedTextBox.ReadOnly = True
        End If
    End Sub

    ' Adicionar Data Bombeiro
    Private Sub ButtonAddDataBombeiro_Click(sender As Object, e As EventArgs) Handles ButtonAddDataBombeiro.Click
        If MsgBox("Deseja Adicionar uma nova data provisório do Bombeiro?" & vbCrLf &
      "Salvar empresa antes de alterar para outra empresa",
      MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Adicionar data Bombeiro") = MsgBoxResult.Yes Then
            ' Código para adicionar a data
            BombeiroProvisorioDATAMaskedTextBox.ReadOnly = False
            BombeiroProvisorioDATAMaskedTextBox.Text = ""
        Else
            BombeiroProvisorioDATAMaskedTextBox.ReadOnly = True
        End If
    End Sub

    ' Adicionar Data Setran
    Private Sub ButtonAddDataSetran_Click(sender As Object, e As EventArgs) Handles ButtonAddDataSetran.Click
        If MsgBox("Deseja Adicionar uma nova data provisório do Setran?" & vbCrLf &
      "Salvar empresa antes de alterar para outra empresa",
      MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Adicionar data Setran") = MsgBoxResult.Yes Then
            SetranProvisorioDATAMaskedTextBox.ReadOnly = False
            SetranProvisorioDATAMaskedTextBox.Text = ""
        Else
            SetranProvisorioDATAMaskedTextBox.ReadOnly = True
        End If
    End Sub

    ' Adicionar Data Sanitario
    Private Sub ButtonAddDataSanitario_Click(sender As Object, e As EventArgs) Handles ButtonAddDataSanitario.Click
        If MsgBox("Deseja Adicionar uma nova data provisório do Sanitário?" & vbCrLf &
      "Salvar empresa antes de alterar para outra empresa",
      MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Adicionar data Sanitario") = MsgBoxResult.Yes Then
            SanitarioProvisorioDATAMaskedTextBox.ReadOnly = False
            SanitarioProvisorioDATAMaskedTextBox.Text = ""
        Else
            SanitarioProvisorioDATAMaskedTextBox.ReadOnly = True
        End If
    End Sub

    'APAGAR
    Private Sub ButtonApagaDataViabilidade_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataViabilidade.Click
        If MsgBox("Deseja Apagar a data provisório da Viabilidade e Salvar?", MsgBoxStyle.YesNo, "Apagar data da Viabilidade") = MsgBoxResult.Yes Then
            Try
                ' Atualiza o MaskedTextBox e o DataSet
                ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = True
                ViabilidadeProvisorioDATAMaskedTextBox.Text = ""

                ' Atualiza o DataSet para definir o campo como NULL
                Dim row As DataRow = CType(Me.PrinceDBDataSet.Laudos.Rows(Me.LaudosBindingSource.Position), DataRow)
                row("ViabilidadeProvisorioData") = DBNull.Value

                ' Salva as alterações no DataSet
                Me.LaudosBindingSource.EndEdit()
                Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)

                Salvar()

                ' Exibe mensagem informativa
                MsgBox("Data provisória apagada e alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")

            Catch ex As Exception
                MessageBox.Show("Erro ao apagar a data provisória: " & ex.Message)
            End Try

            DesativaDataProvisorio()
        End If
    End Sub

    ' Apagar Data Ambiental
    Private Sub ButtonApagaDataAmbiental_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataAmbiental.Click
        If MsgBox("Deseja Apagar a data provisório do Ambiental e Salvar?", MsgBoxStyle.YesNo, "Apagar data Ambiental") = MsgBoxResult.Yes Then
            Try
                AmbientalProvisorioDATAMaskedTextBox.ReadOnly = True
                AmbientalProvisorioDATAMaskedTextBox.Text = ""

                Dim row As DataRow = CType(Me.PrinceDBDataSet.Laudos.Rows(Me.LaudosBindingSource.Position), DataRow)
                row("AmbientalProvisorioData") = DBNull.Value

                Me.LaudosBindingSource.EndEdit()
                Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                Salvar()

                MsgBox("Data provisória apagada e alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")

            Catch ex As Exception
                MessageBox.Show("Erro ao apagar a data provisória: " & ex.Message)
            End Try

            DesativaDataProvisorio()
        End If
    End Sub

    ' Apagar Data Bombeiro
    Private Sub ButtonApagaDataBombeiro_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataBombeiro.Click
        If MsgBox("Deseja Apagar a data provisório do Bombeiro e Salvar?", MsgBoxStyle.YesNo, "Apagar data Bombeiro") = MsgBoxResult.Yes Then
            Try
                BombeiroProvisorioDATAMaskedTextBox.ReadOnly = True
                BombeiroProvisorioDATAMaskedTextBox.Text = ""

                Dim row As DataRow = CType(Me.PrinceDBDataSet.Laudos.Rows(Me.LaudosBindingSource.Position), DataRow)
                row("BombeiroProvisorioData") = DBNull.Value

                Me.LaudosBindingSource.EndEdit()
                Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                Salvar()

                MsgBox("Data provisória apagada e alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")

            Catch ex As Exception
                MessageBox.Show("Erro ao apagar a data provisória: " & ex.Message)
            End Try

            DesativaDataProvisorio()
        End If
    End Sub

    ' Apagar Data Setran
    Private Sub ButtonApagaDataSetran_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataSetran.Click
        If MsgBox("Deseja Apagar a data provisório do Setran e Salvar?", MsgBoxStyle.YesNo, "Apagar data Setran") = MsgBoxResult.Yes Then
            Try
                SetranProvisorioDATAMaskedTextBox.ReadOnly = True
                SetranProvisorioDATAMaskedTextBox.Text = ""

                Dim row As DataRow = CType(Me.PrinceDBDataSet.Laudos.Rows(Me.LaudosBindingSource.Position), DataRow)
                row("SetranProvisorioData") = DBNull.Value

                Me.LaudosBindingSource.EndEdit()
                Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                Salvar()

                MsgBox("Data provisória apagada e alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")

            Catch ex As Exception
                MessageBox.Show("Erro ao apagar a data provisória: " & ex.Message)
            End Try

            DesativaDataProvisorio()
        End If
    End Sub

    ' Apagar Data Sanitário
    Private Sub ButtonApagaDataSanitario_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataSanitario.Click
        If MsgBox("Deseja Apagar a data provisório do Sanitário e Salvar?", MsgBoxStyle.YesNo, "Apagar data Sanitário") = MsgBoxResult.Yes Then
            Try
                SanitarioProvisorioDATAMaskedTextBox.ReadOnly = True
                SanitarioProvisorioDATAMaskedTextBox.Text = ""

                Dim row As DataRow = CType(Me.PrinceDBDataSet.Laudos.Rows(Me.LaudosBindingSource.Position), DataRow)
                row("SanitarioProvisorioData") = DBNull.Value

                Me.LaudosBindingSource.EndEdit()
                Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                Salvar()

                MsgBox("Data provisória apagada e alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")

            Catch ex As Exception
                MessageBox.Show("Erro ao apagar a data provisória: " & ex.Message)
            End Try

            DesativaDataProvisorio()
        End If
    End Sub



    '//////////////////////////////////////// FIM DATA PROVISORIO ////////////////////////////////////////////////////////////////
    Private Sub BtnAgoraProt_Click(sender As Object, e As EventArgs) Handles BtnAgoraProt.Click
        ' Obtém a data e hora atuais
        Dim dataAtual As DateTime = DateTime.Now

        ' Formata a data e hora no formato desejado
        Dim dataFormatada As String = dataAtual.ToString("dd/MM/yyyy HH:mm")

        ' Atribui a data formatada ao MaskedTextBox
        DataEntradaMaskedTextBox.Text = dataFormatada
    End Sub

    Private Sub BtnGrauDeRisco_Click(sender As Object, e As EventArgs) Handles BtnGrauDeRisco.Click
        ' Verificar se o formulário já está aberto
        If FrmCNAEescolha.Visible Then
            FrmCNAEescolha.Close()
            FrmCNAEescolha.Show()
        Else
            FrmCNAEescolha.Show()
        End If
    End Sub

    Private Sub BtnFiliais_Click(sender As Object, e As EventArgs) Handles BtnFiliais.Click
        ' Obtém o CNPJ do MaskedTextBox no FrmAlvara
        Dim cnpjAtual As String = CNPJMaskedTextBox.Text.Trim()

        ' Verifica se o CNPJ está vazio ou nulo
        If String.IsNullOrEmpty(cnpjAtual) Then
            MessageBox.Show("Por favor, insira um CNPJ válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Extrai a base do CNPJ (antes do "/")
        Dim cnpjBase As String = cnpjAtual.Split("/"c)(0)

        ' Abre o formulário FrmFiliais passando o CNPJ base e o formulário chamador
        Dim frmFiliais As New FrmFiliais(cnpjBase, Me) ' Passa "Me" como chamador
        frmFiliais.ShowDialog()
    End Sub

    Private Sub ComboBoxBuscaAlvara_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBuscaAlvara.SelectedIndexChanged
        VerificarFiliais()
    End Sub

    Private Sub BtnMultaBombeiro_Click(sender As Object, e As EventArgs) Handles BtnMultaBombeiro.Click
        ' Pergunta ao usuário se a empresa teve uma Notificação de Autuação
        Dim resultado As DialogResult = MessageBox.Show("A empresa teve uma Notificação de Autuação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Se o usuário responder "Sim", abre o FrmMultaBombeiro
        If resultado = DialogResult.Yes Then
            Dim frmMultaBombeiro As New FrmMultaBombeiro()
            frmMultaBombeiro.Show()
            BombeiroDataMultaMaskedTextBox.Enabled = True
            BombeiroDataMultaMaskedTextBox.Visible = True
        Else
            BombeiroMulta()
        End If
    End Sub

    Private Sub BtnVerObsGeral_Click(sender As Object, e As EventArgs) Handles BtnVerObsGeral.Click
        'ObservacaoRichTextBox
        ' Cria uma instância do FrmRichTextCompleto
        Dim frmRichTextCompleto As New FrmRichTextCompleto()

        ' Passa a referência do GeralRichTextBox para o FrmRichTextCompleto
        frmRichTextCompleto.RichTextBoxOrigem = ObservacaoRichTextBox

        ' Preenche o RichTextBoxCompleto com o texto atual do GeralRichTextBox
        frmRichTextCompleto.RichTextBoxCompleto.Text = ObservacaoRichTextBox.Text

        ' Exibe o FrmRichTextCompleto
        frmRichTextCompleto.ShowDialog()
    End Sub

    Private Sub BtnCopiarRegistro_Click(sender As Object, e As EventArgs) Handles BtnCopiarRegistro.Click
        Try
            ' Verificar se há um registro selecionado no BindingSource
            If Me.LaudosBindingSource.Current Is Nothing Then
                MessageBox.Show("Nenhum registro selecionado para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obter o registro atual da fonte de dados
            Dim registroAtual As DataRowView = CType(Me.LaudosBindingSource.Current, DataRowView)
            Dim novaLinha As DataRow = PrinceDBDataSet.Laudos.NewRow()

            ' Copiar os dados do registro atual para a nova linha
            For Each column As DataColumn In PrinceDBDataSet.Laudos.Columns
                ' Não copiar o ID (supondo que o ID seja auto-incremento ou gerado automaticamente)
                If column.ColumnName <> "ID_Laudos" Then
                    novaLinha(column.ColumnName) = registroAtual(column.ColumnName)
                End If
            Next

            ' Adicionar a nova linha à tabela
            PrinceDBDataSet.Laudos.Rows.Add(novaLinha)

            ' Ajustar o BindingSource para a nova linha
            Me.LaudosBindingSource.Position = Me.LaudosBindingSource.Count - 1

            MessageBox.Show("Registro copiado com sucesso! Preencha os detalhes adicionais e salve.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCadSite_Click(sender As Object, e As EventArgs) Handles BtnCadSite.Click
        TabAlvara.SelectTab(0)
        TabControl2.SelectTab(1)

        If Application.OpenForms.OfType(Of FrmSites)().Count() > 0 Then

            FrmSites.Focus()
            FrmSites.Close()
            FrmSites.MdiParent = MDIPrincipal
            FrmSites.Show()
            FrmSites.Focus()

        Else

            FrmSites.MdiParent = MDIPrincipal
            FrmSites.Show()

        End If
    End Sub

    Private Sub NlaudoSecundarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles NlaudoSecundarioTextBox.TextChanged
        NlaudoSecundarioTextBox.Text = NlaudoSecundarioTextBox.Text.Replace(" ", "")
    End Sub

    Private Sub BtnCNAEOficial_Click(sender As Object, e As EventArgs) Handles BtnCNAEOficial.Click
        If Application.OpenForms.OfType(Of FrmCNAEAberturaEscolha)().Count() > 0 Then
            FrmCNAEAberturaEscolha.Focus()
        Else
            FrmCNAEAberturaEscolha.Show()
        End If
    End Sub

    Private Sub BtnVerDescricaoCNAE_Click(sender As Object, e As EventArgs) Handles BtnVerDescricaoCNAE.Click
        If Application.OpenForms.OfType(Of FrmCNAEtexto)().Count() > 0 Then
            FrmCNAEtexto.Focus()
        Else
            FrmCNAEtexto.Show()
        End If
    End Sub

    Private Sub LblLinkArrumarCNAE_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLinkArrumarCNAE.LinkClicked
        ' Limpar caracteres e formatar o CNAEPrincipalTextBox
        If CNAEPrimarioTextBox.Text.Length >= 7 Then
            Dim cnaePrincipal As String = CNAEPrimarioTextBox.Text
            ' Manter apenas números e formatar como XXXX-X/XX
            cnaePrincipal = New String(cnaePrincipal.Where(Function(c) Char.IsDigit(c)).ToArray())
            If cnaePrincipal.Length = 7 Then
                CNAERichTextBox.Text = cnaePrincipal.Substring(0, 4) & "-" & cnaePrincipal.Substring(4, 1) & "/" & cnaePrincipal.Substring(5, 2)
            Else
                MessageBox.Show("CNAE Principal inválido. Deve conter 7 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        ' Verificar linha por linha no CNAESecundarioRichTextBox
        Dim linhasSecundarias As String() = CNAERichTextBox.Lines
        Dim cnaesFormatados As New List(Of String)

        For Each linha As String In linhasSecundarias
            ' Manter apenas números e formatar como XXXX-X/XX
            Dim cnaeSecundario As String = New String(linha.Where(Function(c) Char.IsDigit(c)).ToArray())
            If cnaeSecundario.Length = 7 Then
                cnaesFormatados.Add(cnaeSecundario.Substring(0, 4) & "-" & cnaeSecundario.Substring(4, 1) & "/" & cnaeSecundario.Substring(5, 2))
            ElseIf Not String.IsNullOrWhiteSpace(linha) Then
                MessageBox.Show($"CNAE Secundário inválido: {linha}. Deve conter 7 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next

        ' Atualizar o conteúdo do CNAESecundarioRichTextBox com os CNAEs formatados
        CNAERichTextBox.Lines = cnaesFormatados.ToArray()
    End Sub

    Private Sub BtnRemovCaract_Click(sender As Object, e As EventArgs) Handles BtnRemovCaract.Click
        RamodeatividadeRichTextBox.Text = LimparTextoRamo(RamodeatividadeRichTextBox.Text)
    End Sub
    Function LimparTextoRamo(sText As String) As String
        sText = System.Text.RegularExpressions.Regex.Replace(sText, "\s+", " ")
        sText = sText.Replace(Environment.NewLine, ";")
        sText = System.Text.RegularExpressions.Regex.Replace(sText, "\s*;\s*", ";")
        sText = System.Text.RegularExpressions.Regex.Replace(sText, "[*+@!#$%&?]", "")
        Return sText
    End Function

    Private Sub BtnCopiarRamo_Click(sender As Object, e As EventArgs) Handles BtnCopiarRamo.Click
        Try
            ' Obter o texto do RichTextBox
            Dim ramoDeAtividade As String = RamodeatividadeRichTextBox.Text

            ' Verifica se o campo está vazio ou nulo
            If String.IsNullOrWhiteSpace(ramoDeAtividade) Then
                MessageBox.Show("O campo Ramo de Atividade está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Copiar o texto para a área de transferência
            Clipboard.SetText(ramoDeAtividade)

            ' Informar ao usuário que o texto foi copiado
            MessageBox.Show("Texto copiado para a área de transferência!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Tratar qualquer erro inesperado
            MessageBox.Show("Ocorreu um erro ao copiar o texto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub EndCidadeTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndCidadeTextBox.TextChanged
        If EndCidadeTextBox.Text = "MARINGA" Then
            EndCidadeTextBox.Text = "Maringá"
        ElseIf EndCidadeTextBox.Text = "PAICANDU" Then
            EndCidadeTextBox.Text = "Paiçandu"
        ElseIf EndCidadeTextBox.Text = "NOVA ESPERANCA" Then
            EndCidadeTextBox.Text = "Nova Esperança"
        End If
    End Sub


    'CPF ou CNPJ no textbox

    Private Sub ArrumarCNPJ()
        ' Remove caracteres de formatação temporariamente para verificar a quantidade de dígitos

        Dim input As String = CNPJMaskedTextBox.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "").Trim()

        ' Alterna a máscara com base na quantidade de dígitos
        If input.Length = 11 Then
            ' Se for CPF (11 dígitos), muda a máscara para CPF
            CNPJMaskedTextBox.Mask = "000,000,000-00"
            CNPJRequerenteMaskedTextBox.Mask = "000,000,000-00"
        ElseIf input.Length = 14 Then
            ' Se for CNPJ (14 dígitos), muda a máscara para CNPJ
            CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
            CNPJRequerenteMaskedTextBox.Mask = "00,000,000/0000-00"
        Else

        End If
    End Sub

    Private Sub CNPJRequerenteMaskedTextBox_Validated(sender As Object, e As EventArgs) Handles CNPJRequerenteMaskedTextBox.Validated
        ArrumarCNPJ()
    End Sub

    Private Sub CNPJMaskedTextBox_Validated(sender As Object, e As EventArgs) Handles CNPJMaskedTextBox.Validated
        ArrumarCNPJ()
    End Sub

    Private Sub CNPJMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CNPJMaskedTextBox.TextChanged
        ArrumarCNPJ()
    End Sub

    Private Sub CNPJRequerenteMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CNPJRequerenteMaskedTextBox.TextChanged
        ArrumarCNPJ()
    End Sub
    'FIM ARRUMA CNPJ
    Private Sub BtnCopiaEndereco_Click(sender As Object, e As EventArgs) Handles BtnCopiaEndereco.Click
        Try
            ' Obter os valores dos campos
            Dim Endereco As String = EnderecoTextBox.Text
            Dim Numero As String = EndNumTextBox.Text
            Dim Complemento As String = EndCompTextBox.Text
            Dim Bairro As String = EndBairroTextBox.Text
            Dim CEP As String = EndCEPMaskedTextBox.Text
            Dim Cidade As String = EndCidadeTextBox.Text
            Dim UF As String = EndEstadoTextBox.Text

            ' Verifica se os campos principais estão vazios ou nulos
            If String.IsNullOrWhiteSpace(Endereco) OrElse String.IsNullOrWhiteSpace(Numero) OrElse String.IsNullOrWhiteSpace(Bairro) OrElse String.IsNullOrWhiteSpace(CEP) OrElse String.IsNullOrWhiteSpace(Cidade) OrElse String.IsNullOrWhiteSpace(UF) Then
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios (Endereço, Número, Bairro, CEP, Cidade e UF).", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Formatar o endereço
            Dim enderecoCompleto As String
            If String.IsNullOrWhiteSpace(Complemento) Then
                enderecoCompleto = String.Format("{0}, n.º {1}, {2}, CEP: {3}, na cidade de {4}-{5}", Endereco, Numero, Bairro, CEP, Cidade, UF)
            Else
                enderecoCompleto = String.Format("{0}, n.º {1}, {2}, {3}, CEP: {4}, na cidade de {5}-{6}", Endereco, Numero, Complemento, Bairro, CEP, Cidade, UF)
            End If

            ' Copiar para a área de transferência
            Clipboard.SetText(enderecoCompleto)

            ' Informar o sucesso
            MessageBox.Show("Endereço copiado para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Tratar erros inesperados
            MessageBox.Show("Ocorreu um erro ao copiar o endereço: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCorrigeCidade_Click(sender As Object, e As EventArgs) Handles BtnCorrigeCidade.Click
        Try
            ' Obter o nome da cidade inserida no campo
            Dim CidadeInserida As String = EndCidadeTextBox.Text.Trim()

            ' Verificar se o campo de cidade não está vazio
            If String.IsNullOrWhiteSpace(CidadeInserida) Then
                MessageBox.Show("O campo de cidade está vazio. Por favor, insira uma cidade para corrigir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Conectar ao banco de dados para buscar a cidade correta
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Consulta SQL ajustada para ignorar acentos
                Dim query As String = "
                SELECT TOP 1 nome
                FROM BrasilMunicipios
                WHERE nome COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%' + @cidade + '%'
            "

                Using cmd As New SqlCommand(query, conn)
                    ' Adicionar o parâmetro para a consulta
                    cmd.Parameters.AddWithValue("@cidade", CidadeInserida)

                    ' Executar a consulta
                    Dim resultado As Object = cmd.ExecuteScalar()

                    ' Verificar se a cidade foi encontrada
                    If resultado IsNot Nothing Then
                        Dim cidadeCorrigida As String = resultado.ToString()
                        EndCidadeTextBox.Text = cidadeCorrigida
                        MessageBox.Show($"Cidade corrigida para: {cidadeCorrigida}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Cidade não encontrada na tabela 'BrasilMunicipios'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao corrigir a cidade! " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AlvaraComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlvaraComboBox.SelectedIndexChanged
        Select Case AlvaraComboBox.Text
            Case "Alvará Definitivo"
                AlvaraComboBox.BackColor = Color.Green
                AlvaraComboBox.ForeColor = Color.White
            Case "Alvará Provisório"
                AlvaraComboBox.BackColor = Color.Yellow
                AlvaraComboBox.ForeColor = Color.Black ' Letras pretas para contraste
            Case "Alvará Vencido"
                AlvaraComboBox.BackColor = Color.Red
                AlvaraComboBox.ForeColor = Color.White
            Case Else
                ' Define cores padrão se nenhum dos casos for atendido
                AlvaraComboBox.BackColor = SystemColors.Window
                AlvaraComboBox.ForeColor = SystemColors.WindowText
        End Select
    End Sub


End Class