Imports System.Data.SqlClient

Public Class FrmAlvara
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' inicio LOAD

    ' Propriedade pública para receber a RazaoSocialSelecionada
    Public Property RazaoSocialSelecionada As String
    ' Declaração da variável no nível do formulário



    Private Sub FrmAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Carregar os dados da tabela CADSituacaoAlvara
            Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
            SituacaoComboBox.DataSource = Me.CADSituacaoAlvaraBindingSource
            SituacaoComboBox.DisplayMember = "Descricao"
            SituacaoComboBox.ValueMember = "Descricao"

            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

            ' Forçar a aceitação das alterações e garantir que o DataSet está atualizado
            PrinceDBDataSet.AcceptChanges()

            ' Atualizar o BindingSource após aplicar o filtro
            AtualizarBindingSource()

            ' Configurar o valor do ComboBox com base no valor salvo em Laudos
            ConfigurarComboBox()

            ' Configurar estado inicial dos controles
            BtnEditar.Text = "Editar"
            CheckBoxPrioridade.Enabled = False
            GroupBox4.Enabled = False
            DesativaDataProvisorio()

            ' Tirar borda do TableLayoutPanel1
            TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None

            ' Ordenar Situações
            SituacaoOrdenado()


        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao carregar o formulário" & vbCrLf & ex.Message & vbCrLf & vbCrLf & "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try



        ' Forçar a aceitação das alterações e garantir que o DataSet está atualizado
        PrinceDBDataSet.AcceptChanges()

        ' Atualizar o BindingSource após aplicar o filtro
        AtualizarBindingSource()

        ' Configurar o valor do ComboBox com base no valor salvo em Laudos
        ConfigurarComboBox()

        For Each col As DataColumn In Me.PrinceDBDataSet.Laudos.Columns
            col.ReadOnly = False
        Next
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
    Private Sub Salvar()
        Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text

        Try
            ' Forçar a validação e finalizar edição nos controles ligados ao BindingSource
            Me.Validate()
            Me.LaudosBindingSource.EndEdit()

            ' Forçar atualização do DataTable para garantir que alterações são refletidas
            Dim changedRecords As System.Data.DataTable = PrinceDBDataSet.Laudos.GetChanges(DataRowState.Modified)

            ' Verificar se há alterações para salvar
            If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then
                Dim message As String = "Foram feitas " & changedRecords.Rows.Count & " alterações." & vbCrLf & "Deseja salvar as alterações?"
                Dim result As DialogResult = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

                Select Case result
                    Case DialogResult.Cancel
                        ' Não faça nada, apenas sair do método
                        Exit Sub

                    Case DialogResult.No
                        ' Reverter mudanças e desativar edição
                        BtnEditar.Text = "Editar"
                        Button17.Enabled = True
                        CheckBoxPrioridade.Enabled = False
                        GroupBox4.Enabled = False
                        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

                        ' Permitir que o sistema processe os eventos pendentes
                        Application.DoEvents()

                        ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                        ComboBoxBuscaCNPJ.Select()
                        DesativaDataProvisorio()

                    Case DialogResult.Yes
                        Try
                            ' Salvar alterações
                            Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)

                            ' Recarregar os dados para garantir que tudo está sincronizado
                            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

                            ' Permitir que o sistema processe os eventos pendentes
                            Application.DoEvents()

                            ' Desativar edição após salvar
                            BtnEditar.Text = "Editar"
                            CheckBoxPrioridade.Enabled = False
                            GroupBox4.Enabled = False
                            ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                            ComboBoxBuscaCNPJ.Select()
                            DesativaDataProvisorio()
                            MessageBox.Show("Alterações salvas com sucesso.", "Prince Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch exc As Exception
                            MessageBox.Show("Ocorreu um erro ao atualizar" & vbCrLf & exc.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try

                End Select
            Else
                ' Não há alterações, apenas desativar edição
                BtnEditar.Text = "Editar"
                CheckBoxPrioridade.Enabled = False
                GroupBox4.Enabled = False
                Button17.Enabled = True
                ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                ComboBoxBuscaCNPJ.Select()
                DesativaDataProvisorio()
                MessageBox.Show("Nenhuma alteração foi detectada.", "Prince Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar" & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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

    Private Sub ALVARAEsconderAtalhosNavegadorPadrao()
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
            Dim NLaudo As String = NlaudoTextBox.Text '.Replace(" ", "").Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")


            'copiar
            ' Remover caracteres especiais e copiar o número para a área de transferência
            Clipboard.SetText(NLaudo)

            ' Exibir mensagem de sucesso
            MessageBox.Show("Número do Laudo Copiado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)



            If ModeloSistemaComboBox.Text = "Alvará Antigo" Then
                If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                    WebSiteGERAL.Focus()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    If EndCidadeLabel2.Text.Contains("Maring") Then
                        WebSiteGERAL.WebView.Source = New Uri("http://venus.maringa.pr.gov.br/laudosnew/consultar.php")
                    End If
                Else
                    WebSiteGERAL.Show()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    If EndCidadeLabel2.Text.Contains("Maring") Then
                        WebSiteGERAL.WebView.Source = New Uri("https://venus.maringa.pr.gov.br/laudosnew/consultar.php")
                    End If
                End If
                ALVARAEsconderAtalhosNavegadorPadrao()

            ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then
                If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                    WebSiteGERAL.Focus()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    If EndCidadeLabel2.Text.Contains("Maring") Then
                        WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                    ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                        WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                    End If
                Else
                    WebSiteGERAL.Show()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    If EndCidadeLabel2.Text.Contains("Maring") Then
                        WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                    ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                        WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                    End If
                End If
                ALVARAEsconderAtalhosNavegadorPadrao()

            ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then
                MessageBox.Show("Ligar ou Comparecer na Prefeitura da cidade onde foi solicitado", "Prince Ajuda")
            ElseIf ModeloSistemaComboBox.Text = "Consulta Prévia" Then
                MessageBox.Show("Consulta Prévia solicitada antes do pedido de alvará na Prefeitura", "Prince Ajuda")
            ElseIf ModeloSistemaComboBox.Text = "Empresa Fácil" Then
                Select Case EndEstadoLabel2.Text.Trim()
                    Case "PR"
                        BoxJuntaComercialLaudo.Show()
                    Case "SC"
                        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                            WebSiteGERAL.Focus()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                            WebSiteGERAL.WebView.Source = New Uri("http://regin.jucesc.sc.gov.br/requerimentoUniversal/Viabilidades.aspx")
                        Else
                            WebSiteGERAL.Show()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                            WebSiteGERAL.WebView.Source = New Uri("http://regin.jucesc.sc.gov.br/requerimentoUniversal/Viabilidades.aspx")
                        End If
                    Case ""
                        TabAlvara.SelectTab(0)
                        TabControl2.SelectTab(1)
                        If EndEstadoTextBox.Text = "" Then
                            MessageBox.Show("Preencher o endereço completo e salvar para atualizar o formulário", "Prince Ajuda")
                        Else
                            MessageBox.Show("Estado Não cadastrado, favor contatar o administrador do sistema", "Prince Ajuda")
                        End If
                End Select

                ALVARAEsconderAtalhosNavegadorPadrao()

            ElseIf ModeloSistemaComboBox.Text = "MEI - Dispensa de Alvará" Then
                If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                    WebSiteGERAL.Focus()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                    If EndCidadeLabel2.Text.Contains("Maring") Then
                        WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                    ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                        MessageBox.Show("Manual na prefeitura com documento assinado!", "Prince Ajuda")
                    End If
                End If
                ALVARAEsconderAtalhosNavegadorPadrao()

            ElseIf ModeloSistemaComboBox.Text = "MEI - Alvará Online" Then
                If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                    WebSiteGERAL.Focus()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    If EndCidadeLabel2.Text.Contains("Maring") Then
                        WebSiteGERAL.WebView.Source = New Uri("http://venus.maringa.pr.gov.br:9900/fazendaonline/app/consultaPrevia?execution=e5s1")
                    ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                        WebSiteGERAL.WebView.Source = New Uri("http://200.233.108.153:8080/WebEloAlvaraOnline/app/consultaPrevia?execution=e3s1")
                    End If
                End If
                ALVARAEsconderAtalhosNavegadorPadrao()

            Else
                MessageBox.Show("Sem sistema para consulta", "Prince Sistemas - Alerta")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Prince Sistemas - Alerta")
        End Try

    End Sub

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


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.LaudosBindingSource.AddNew()

            SituacaoComboBox.SelectedIndex = 0

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
        Salvar()
        '  PreSalvar()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Me.Close()

    End Sub

    Private Sub LaudosConsulta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        Me.LaudosBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.Laudos.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then
            Dim message As String
            message = "Foram feitas " & changedRecords.Rows.Count & " alterações." & vbCrLf & "Deseja salvar as alterações?"


            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try

                    LaudosTableAdapter.Update(PrinceDBDataSet.Laudos)

                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If


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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If WebSiteGERAL.Visible = False Then
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/solicitarVistoria.do?action=iniciarProcesso")
        Else
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.prevfogo.sesp.pr.gov.br/vcbinternet/solicitarVistoria.do?action=iniciarProcesso")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If FrmProtegeFacil.Visible = False Then
            FrmProtegeFacil.Show()
            FrmProtegeFacil.MdiParent = MDIPrincipal
        Else
            FrmProtegeFacil.Focus()
            FrmProtegeFacil.MdiParent = MDIPrincipal
        End If
    End Sub



    Private Sub NlaudoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NlaudoTextBox.TextChanged
        NlaudoTextBox.Text = NlaudoTextBox.Text.Replace(" ", "")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'verificar CNPJLabel contem a palavra "CNPJ"
        'verificar se esta aberto BoxConsultaCNPJLaudo ou abrir
        If BoxConsultaCNPJLaudo.Visible = False Then
            ' BoxConsultaCNPJLaudo.Show()
            If CNPJLabel.Text = "CNPJ:" Then
                BoxConsultaCNPJLaudo.Show()
            End If
        Else
            'BoxConsultaCNPJLaudo.Focus()
            If CNPJLabel.Text = "CNPJ:" Then
                BoxConsultaCNPJLaudo.Focus()
            End If
        End If


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
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

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
                EndCompTextBox.Text = resultado.complemento
                EndCidadeTextBox.Text = resultado.localidade
                EndBairroTextBox.Text = resultado.bairro
                EndEstadoTextBox.Text = resultado.uf
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
        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://venus.maringa.pr.gov.br/laudosnew/requerimentos.php")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    MessageBox.Show("Alvará precisa ser manualmente solicitado para o município de Sarandi", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://venus.maringa.pr.gov.br/laudosnew/requerimentos.php")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    MessageBox.Show("Alvará precisa ser manualmente solicitado para o município de Sarandi", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                End If
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://www.maringa.pr.gov.br/fazendaonline")
                End If
            End If

        ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then
            MessageBox.Show("Documentos Manuais da Prefeitura da cidade onde a empresa se localiza", "Prince Ajuda")

        ElseIf ModeloSistemaComboBox.Text = "Consulta Prévia" Then
            MessageBox.Show("Consulta Prévia realizada no site da prefeitura, antecipa a liberação do alvará ou  Cadastro Imobiliário", "Prince Ajuda")


        ElseIf ModeloSistemaComboBox.Text = "Bombeiro Certificado" Then
            TabAlvara.SelectTab(1)

        ElseIf ModeloSistemaComboBox.Text = "MEI - Dispensa de Alvará" Then
            'https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    WebSiteGERAL.WebView.Source = New Uri("http://200.233.108.153:8080/WebEloAlvaraOnline/app/consultaPrevia?execution=e5s1")
                End If
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    WebSiteGERAL.WebView.Source = New Uri("http://200.233.108.153:8080/WebEloAlvaraOnline/app/consultaPrevia?execution=e5s1")
                End If
            End If
        ElseIf ModeloSistemaComboBox.Text = "MEI - Alvará Online" Then
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    WebSiteGERAL.WebView.Source = New Uri("http://200.233.108.153:8080/WebEloAlvaraOnline/app/consultaPrevia?execution=e5s1")
                End If
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                If EndCidadeLabel2.Text.Contains("Maring") Then
                    WebSiteGERAL.WebView.Source = New Uri("https://sei.maringa.pr.gov.br/sei//controlador_externo.php?acao=usuario_externo_logar&id_orgao_acesso_externo=0")
                ElseIf EndCidadeLabel2.Text.Contains("Sarandi") Then
                    WebSiteGERAL.WebView.Source = New Uri("http://200.233.108.153:8080/WebEloAlvaraOnline/app/consultaPrevia?execution=e5s1")
                End If
            End If
        Else
            MessageBox.Show("Informar qual tipo de sistema utilizado na solicitação do laudo - alvará de localização", "Prince Sistemas - Alerta")
        End If
    End Sub

    Private Sub SituacaoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SituacaoComboBox.TextChanged, SituacaoComboBox.SelectedIndexChanged


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
                SituacaoComboBox.SelectedIndex = 0
                'Limpando as BOX
                NlaudoTextBox.Text = ""
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

    End Sub

    Private Sub ModeloSistemaComboBox_TextChanged(sender As Object, e As EventArgs) Handles ModeloSistemaComboBox.TextChanged
        If ModeloSistemaComboBox.Text = "Consulta Prévia" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Empresa Fácil" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = False

        ElseIf ModeloSistemaComboBox.Text = "MEI - Dispensa de Alvará" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "MEI - Alvará Online" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        Else
            NlaudoLabel.Visible = False
            NlaudoTextBox.Visible = False
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
        Dim Processo As String = BombeiroNProcessoMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(Processo.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) ''

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
        Dim result As DialogResult = MessageBox.Show("Deseja abrir o mapa da cidade com o cadastro imobiliário " & cadastroImobiliario & "?", "Abrir Mapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verifica a resposta do usuário
        If result = DialogResult.Yes Then
            If WebSiteGERAL.Visible = True Then
                ' Coloca foco e frente
                WebSiteGERAL.Focus()
                WebSiteGERAL.BringToFront()
            Else
                ' Mostra a janela
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
        'MessageBox.Show("CEP copiado para a área de transferência: " & cepSemHifen, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

                MsgBox("Data provisória apagada e alterações salvas com sucesso.", MsgBoxStyle.Information, "Sucesso")

            Catch ex As Exception
                MessageBox.Show("Erro ao apagar a data provisória: " & ex.Message)
            End Try

            DesativaDataProvisorio()
        End If
    End Sub

    '//////////////////////////////////////// FIM DATA PROVISORIO ////////////////////////////////////////////////////////////////


End Class