﻿Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Text



Public Class FrmLegalizacao
    ' ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"


    '//////////////////////// importar FEDERAL CNPJ



    '/////////////////// FIM IMPORTAR FEDERAL




    ' Método para bloquear ou desbloquear TextBox
    Private Sub SetTextBoxEnabled(enabled As Boolean)
        For Each txt As System.Windows.Forms.TextBox In Me.Controls.OfType(Of System.Windows.Forms.TextBox)()
            txt.Enabled = enabled
        Next
    End Sub

    Private Sub Bloquear()
        SetTextBoxEnabled(False)
    End Sub

    Private Sub Desbloquear()
        SetTextBoxEnabled(True)
    End Sub



    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' SEMPRE MAIUSCULO - inicio

    Private Sub RazaoSocialTextBox_TextChanged(sender As Object, e As EventArgs) Handles RazaoSocialTextBox.TextChanged
        'se for maior do que Caracteres: 63, mostrar o botao BtnAvancoRazao, se nao esconder
        If RazaoSocialTextBox.Text.Length > 63 Then
            BtnAvancoRazao.Visible = True
        Else
            BtnAvancoRazao.Visible = False
        End If
        'maiusculo
        Dim selectionStart As Integer = RazaoSocialTextBox.SelectionStart
        Dim selectionLength As Integer = RazaoSocialTextBox.SelectionLength

        ' Converte o texto para maiúsculas
        RazaoSocialTextBox.Text = RazaoSocialTextBox.Text.ToUpper()

        ' Restaura a posição do cursor e a seleção
        RazaoSocialTextBox.SelectionStart = selectionStart
        RazaoSocialTextBox.SelectionLength = selectionLength
    End Sub


    'FIM maiusculo
    '///////////////////// SALVAR PRIVATE E PUBLIC
    Public Sub SalvarExterno()
        Salvar()
    End Sub
    ' Variável para controlar o fechamento do formulário
    Private cancelarFechamento As Boolean = False
    Private Sub Salvar()
        Try
            ' Finalizar edição e obter registros alterados
            Me.EmpresasBindingSource.EndEdit()
            Dim changedRecords As System.Data.DataTable = PrinceDBDataSet.Empresas.GetChanges()

            ' Verificar se há alterações para salvar
            If changedRecords IsNot Nothing AndAlso changedRecords.Rows.Count > 0 Then
                ' Criar strings para armazenar o resumo e os detalhes das mudanças
                Dim changesDescription As String = ""
                Dim detailedChanges As String = ""

                ' Iterar sobre as linhas alteradas
                For Each row As DataRow In changedRecords.Rows
                    ' Adiciona o ID da empresa ao resumo
                    changesDescription &= "Alterações na linha com ID: " & row("ID_Empresas").ToString() & vbCrLf

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

                ' Perguntar ao usuário se deseja ver detalhes das alterações
                If MessageBox.Show("Deseja ver os detalhes das alterações?", "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    MessageBox.Show(detailedChanges, "Detalhes das Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Mostrar a quantidade de alterações e o resumo das mudanças
                Dim message As String = "Foram feitas " & changedRecords.Rows.Count.ToString() & " alterações." & vbCrLf & "Deseja salvar as alterações?" & vbCrLf & vbCrLf & changesDescription
                Dim result As DialogResult = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

                Select Case result
                    Case DialogResult.Cancel
                        ' Ação para Cancelar
                        cancelarFechamento = True

                    Case DialogResult.No
                        ' Reverter mudanças e desativar edição
                        PrinceDBDataSet.Empresas.RejectChanges()
                        Application.DoEvents()

                        BtnEditar.Text = "Editar"
                        BtnExcluir.Enabled = True
                        GroupBox2.Enabled = False
                        GroupBox10.Enabled = False

                        ' Recarregar dados
                        Me.NaturezajuridicaTableAdapter.Fill(Me.PrinceDBDataSet.Naturezajuridica)
                        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
                        cancelarFechamento = False

                    Case DialogResult.Yes
                        ' Salvar alterações
                        Try
                            '  MudarStatusFinalizado() ' Verifica o status de finalização e aplica as mudanças

                            Me.Validate()
                            Me.EmpresasBindingSource.EndEdit()

                            ' Tente atualizar o DataSet
                            Dim rowsAffected As Integer = Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)

                            If rowsAffected > 0 Then
                                ' MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Nenhuma alteração foi salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                            Application.DoEvents()

                            ' Ajustar a interface após salvar
                            BtnEditar.Text = "Editar"
                            GroupBox2.Enabled = False
                            GroupBox10.Enabled = False
                            BtnExcluir.Enabled = True

                            ' Focar na empresa atual no combobox de busca
                            Dim NomeEmpresa As String = RazaoSocialTextBox.Text
                            ComboBoxBuscaEmpresa.Text = NomeEmpresa
                            ComboBoxBuscaEmpresa.Focus()
                            RazaoSocialTextBox.Focus()

                        Catch exc As Exception
                            MessageBox.Show("Ocorreu um erro ao atualizar" & vbCrLf & exc.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try

                        cancelarFechamento = False
                End Select
            Else
                ' Não há alterações, apenas desativar edição
                BtnEditar.Text = "Editar"
                GroupBox2.Enabled = False
                GroupBox10.Enabled = False
                BtnExcluir.Enabled = True

                ' Focar na empresa atual
                Dim NomeEmpresa As String = RazaoSocialTextBox.Text
                ComboBoxBuscaEmpresa.Text = NomeEmpresa
                ComboBoxBuscaEmpresa.Focus()
                RazaoSocialTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar" & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub







    Private Sub HabilitaEdicao()
        BtnEditar.Text = "Cancelar"
        BtnExcluir.Enabled = False
        GroupBox2.Enabled = True
        GroupBox10.Enabled = True
    End Sub

    Private Sub DesabilitaEdicao()
        BtnEditar.Text = "Editar"
        BtnExcluir.Enabled = True
        GroupBox2.Enabled = False
        GroupBox10.Enabled = False
    End Sub


    Private Sub VerificarFiliais()

        ' Obtém o CNPJ atual e remove a máscara, se houver
        Dim cnpjAtual As String = CNPJMaskedTextBox.Text.Trim()

        ' Verifica se o CNPJ é válido e extrai a base do CNPJ (primeiros 8 dígitos)
        If Not String.IsNullOrEmpty(cnpjAtual) AndAlso cnpjAtual.Length >= 10 Then
            ' Extraímos os primeiros 10 caracteres incluindo pontos e barra
            Dim cnpjBase As String = cnpjAtual.Substring(0, 10)

            ' Consulta SQL para contar o número de filiais com o mesmo CNPJ base
            Dim query As String = "SELECT COUNT(*) FROM Empresas WHERE CNPJ LIKE @CNPJBase + '%000%' AND CNPJ <> @CNPJAtual"
            Dim filiaisCount As Integer = 0

            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CNPJBase", cnpjBase)
                    cmd.Parameters.AddWithValue("@CNPJAtual", cnpjAtual)
                    conn.Open()

                    filiaisCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            ' Atualiza o botão BtnFiliais conforme o número de filiais encontradas
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
            AjustarTamanhoBtnFiliais()
        End If
    End Sub

    Private Sub LabelFilial_Click(sender As Object, e As EventArgs)
        VerificarFiliais()
    End Sub


    Private Sub AjustarTamanhoBtnFiliais()
        ' Define o texto do botão (você pode substituir isso pelo valor real a ser exibido)
        Dim texto As String = BtnFiliais.Text

        ' Calcula o tamanho do texto com base na fonte do botão
        Dim tamanhoTexto As Size = TextRenderer.MeasureText(texto, BtnFiliais.Font)

        ' Define a nova largura do botão com base na largura do texto, adicionando um pequeno padding
        BtnFiliais.Width = tamanhoTexto.Width + 20 ' Adicione um padding para ajustar a borda

        ' Opcional: Se você quiser que o botão se expanda para a direita, sem alterar a posição à esquerda
        ' Descomente a linha abaixo e comente a linha anterior
        ' BtnFiliais.Width = tamanhoTexto.Width + BtnFiliais.Padding.Horizontal
    End Sub



    ' LOAD INICIAL

    Public Property RazaoSocialSelecionada As String
    Private Sub FrmLegalizacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Preenche os dados das tabelas relacionadas
            CADstatusTableAdapter.Fill(PrinceDBDataSet.CADstatus)
            NaturezajuridicaTableAdapter.Fill(PrinceDBDataSet.Naturezajuridica)
            EmpresasTableAdapter.Fill(PrinceDBDataSet.Empresas)

            ' Configuração do ComboBox Status
            ConfigurarStatusComboBox()

            ' Configurações iniciais
            ModCombobox.ComboboxLegalizacaoProcesso()
            ComboBoxBuscaEmpresa.Focus()
            StatusOrdenado()

            ' Permitir edições nas colunas da tabela Empresas
            For Each col As DataColumn In PrinceDBDataSet.Empresas.Columns
                col.ReadOnly = False
            Next

            ' Vincular evento ao BindingSource (evita múltiplas assinaturas)
            RemoveHandler EmpresasBindingSource.CurrentChanged, AddressOf EmpresasBindingSource_CurrentChanged
            AddHandler EmpresasBindingSource.CurrentChanged, AddressOf EmpresasBindingSource_CurrentChanged

            ' Atualiza dados
            AtualizaDados()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao carregar o formulário." & vbCrLf & ex.Message,
                        "Prince Sistemas - Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ConfigurarStatusComboBox()
        With StatusComboBox
            .DataSource = CADstatusBindingSource
            .DisplayMember = "Descricao"
            .ValueMember = "Descricao"
            .SelectedIndex = If(.Items.Count > 0, 0, -1)
        End With
    End Sub

    Private Sub EmpresasBindingSource_CurrentChanged(sender As Object, e As EventArgs)
        AtualizaDados()
    End Sub

    Private Sub FrmLegalizacao_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TipodeEmpresa()
    End Sub

    Private Sub AtualizaDados()
        Try
            ' Definir o texto do botão Editar
            BtnEditar.Text = "Editar"

            ' Chamar métodos auxiliares para atualizar os dados e a interface
            Editar()
            InicializarControles()
            VerificarFiliais()
            VerificarAvisoEmpresa()
            StatusMudar()
            MudaContratoAviso()

            ' Chamar ProcessoMudar apenas se houver item selecionado
            If EmpresasBindingSource.Current IsNot Nothing Then
                ProcessoMudar()
                TipodeEmpresa()
            End If
        Catch ex As Exception
            ' Tratar erros e exibir mensagem ao usuário
            MessageBox.Show("Erro ao atualizar dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub InicializarControles()
        Try
            If BtnEditar.Text = "Cancelar" Then
                ' Remover do dock, ocultar e desabilitar o binding navigator
                EmpresasBindingNavigator.Dock = DockStyle.None
                EmpresasBindingNavigator.Visible = False
                EmpresasBindingNavigator.Enabled = False

                ' Oculte os combo boxes também
                ComboBoxBuscaCNPJ.Visible = False
                ComboBoxBuscaEmpresa.Visible = False
            Else
                ' Se não estiver em modo de edição, habilitar e mostrar o binding navigator
                EmpresasBindingNavigator.Dock = DockStyle.Top
                EmpresasBindingNavigator.Visible = True
                EmpresasBindingNavigator.Enabled = True

                ' Mostrar os combo boxes
                ComboBoxBuscaCNPJ.Visible = True
                ComboBoxBuscaEmpresa.Visible = True

            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao editar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub StatusOrdenado()
        ' Obter a fonte de dados original do ComboBox
        Dim bindingSource As BindingSource = DirectCast(StatusComboBox.DataSource, BindingSource)

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

    Private Sub ProcessoMudar()
        Try
            ' Oculta todos os controles inicialmente
            HideAllControls()

            ' Exibe os controles conforme o tipo de processo selecionado
            Select Case ProcessoComboBox.Text.Trim()
                Case "Abertura"
                    SetupAbertura()
                Case "Alteração"
                    SetupAlteracao()
                Case "Baixa"
                    SetupBaixa()
                Case Else
                    SetupOutro()
            End Select
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Mudar o Processo" & vbCrLf & ex.Message,
                        "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub HideAllControls()
        ' Lista todos os controles que devem ser ocultados
        Dim controles() As Control = {NAlteracaoComboBox, NAlteracaoLabel, AltConsolidadaComboBox,
                                  LabelConsolidar, GroupBox5, NovaRazaoSocialLabel,
                                  NovaRazaoSocialComboBox, CapitalAntigoMudouLabel,
                                  CapitalAntigoMudouComboBox, PictureBoxCentralProcesso, BtnVerNovoNome}
        For Each ctrl As Control In controles
            ctrl.Visible = False
        Next
    End Sub

    Private Sub SetupAbertura()
        ' Configurações para "Abertura"
        CapitalAntigoMudouLabel.Visible = True
        CapitalAntigoMudouComboBox.Visible = True

        ConfigurePictureBox(My.Resources.AberturaEmpresa, True)

        ConfigureButton(BtnVerNovoNome, True, "Busca de Nome", New Point(208, 111), New Size(120, 24))
    End Sub

    Private Sub SetupAlteracao()
        ' Configurações para "Alteração"
        NAlteracaoComboBox.Visible = True
        NAlteracaoLabel.Visible = True
        AltConsolidadaComboBox.Visible = True
        LabelConsolidar.Visible = True
        GroupBox5.Visible = True
        NovaRazaoSocialLabel.Visible = True
        NovaRazaoSocialComboBox.Visible = True
        CapitalAntigoMudouLabel.Visible = True
        CapitalAntigoMudouComboBox.Visible = True

        ConfigurePictureBox(My.Resources.AlteracaoEmpresa, True)

        ConfigureButton(BtnVerNovoNome, True, "Ver", New Point(391, 143), New Size(50, 24))
    End Sub

    Private Sub SetupBaixa()
        ' Configurações para "Baixa"
        CapitalAntigoMudouLabel.Visible = True
        CapitalAntigoMudouComboBox.Visible = True

        ConfigurePictureBox(My.Resources.baixaEmpresa, True)
        ' Em "Baixa", o botão não é exibido e os demais controles permanecem ocultos
    End Sub

    Private Sub SetupOutro()
        ' Configurações para outro processo
        NAlteracaoComboBox.Visible = True
        NAlteracaoLabel.Visible = True
        AltConsolidadaComboBox.Visible = True
        LabelConsolidar.Visible = True
        NovaRazaoSocialLabel.Visible = True
        NovaRazaoSocialComboBox.Visible = True
        CapitalAntigoMudouLabel.Visible = True
        CapitalAntigoMudouComboBox.Visible = True

        ConfigureButton(BtnVerNovoNome, True, "Ver", New Point(391, 143), New Size(50, 24))

        ' Neste caso, a PictureBox não será exibida
        PictureBoxCentralProcesso.Visible = False
    End Sub

    ' Método auxiliar para configurar a PictureBox
    Private Sub ConfigurePictureBox(imagem As Image, exibir As Boolean)
        PictureBoxCentralProcesso.Visible = exibir
        If exibir Then
            PictureBoxCentralProcesso.Image = imagem
            PictureBoxCentralProcesso.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ' Método auxiliar para configurar o botão
    Private Sub ConfigureButton(btn As Button, exibir As Boolean, texto As String, pos As Point, tam As Size)
        btn.Visible = exibir
        If exibir Then
            btn.Text = texto
            btn.Location = pos
            btn.Size = tam
        End If
    End Sub


    Private Sub StatusMudar()
        Try
            Dim statusText As String = StatusComboBox.Text.Trim()
            Dim processoText As String = ProcessoComboBox.Text.Trim()

            ' Definição padrão (evita repetições)
            StatusComboBox.BackColor = Color.White
            StatusComboBox.ForeColor = Color.Black
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing

            Select Case True
                Case statusText.Contains("Finalizado")
                    StatusComboBox.BackColor = Color.Green
                    StatusComboBox.ForeColor = Color.White
                    PictureBox1.Image = My.Resources.check
                    PictureBox2.Image = If(processoText = "Baixa", My.Resources.fechadaempresa, My.Resources.ABERTURA_DE_EMPRESA)
                    SituacaoCadastralComboBox.Text = If(processoText = "Baixa", "BAIXADA", SituacaoCadastralComboBox.Text)
                    AvisarDiaMaskedTextBox.Text = "" ' Só apaga quando finaliza tudo

                Case statusText.Contains("Pêndencia Sistema Externo")
                    StatusComboBox.BackColor = Color.Red
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.check
                    AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()

                Case statusText.Contains("Paralisado"), statusText.Contains("Cancelado")
                    StatusComboBox.BackColor = Color.Red
                    StatusComboBox.ForeColor = Color.White
                    PictureBox1.Image = If(statusText.Contains("Paralisado"), My.Resources._Stop, My.Resources.Cancel)

                Case statusText.Contains("Em Andamento"), statusText.Contains("Taxas"), statusText.Contains("Empresa Fácil"), statusText.Contains("Federal"), statusText.Contains("Estadual"), statusText.Contains("Simples"), statusText.Contains("Prefeitura")
                    PictureBox1.Image = My.Resources.emandamento
                    Select Case statusText
                        Case "Taxas" : PictureBox2.Image = My.Resources.pagamento
                        Case "Empresa Fácil" : PictureBox2.Image = My.Resources.empresa_facil
                        Case "Federal" : PictureBox2.Image = My.Resources.redeSim_Divulgação
                        Case "Estadual" : PictureBox2.Image = My.Resources.governo2019_400x173px
                        Case "Simples" : PictureBox2.Image = My.Resources.logo_simples_nacional_810x455
                        Case "Prefeitura" : PictureBox2.Image = My.Resources.alvara
                    End Select

                Case statusText.Contains("Cliente") OrElse statusText.Contains("Aguardando")
                    PictureBox1.Image = My.Resources.emandamento
            End Select

            ' Mantém a data de aviso se for "Protocolado", apaga apenas se for "Finalizado"
            If Not statusText.Contains("Protocolado") Then
                '  AvisarDiaMaskedTextBox.Text = ""
            End If

            ' Abre a aba correspondente se for "Simples Nacional - Em Andamento"
            If statusText = "Simples Nacional - Em Andamento" Then
                TabControle.SelectTab(5)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsultaJunta.Click
        Dim frm As New BoxJuntaComercial

        If frm.Visible = True Then
            'coloca focus e frente
            frm.Focus()
            frm.BringToFront()

        Else
            frm.Show()
            frm.BringToFront()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If Application.OpenForms.OfType(Of BoxConsultaCNPJEmpresa)().Count() > 0 Then
        'BoxConsultaCNPJEmpresa.Focus()
        ' Else
        '  BoxConsultaCNPJEmpresa.Show()
        '  End If

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



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            'EmpCriadoMaskedTextBox

            'MessageBox.Show(DateTime.Now.ToLongDateString())

            Dim a As DateTime
            a = EmpCriadoMaskedTextBox.Text

            'just show time only
            '  MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim a As DateTime
            a = DataProtJuntaComercialMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim a As DateTime

            a = DataProtREDESIMMaskedTextBox.Text
            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        If Application.OpenForms.OfType(Of FrmCNAEAberturaEscolha)().Count() > 0 Then
            FrmCNAEAberturaEscolha.Focus()
        Else
            FrmCNAEAberturaEscolha.Show()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControle.SelectTab(2)
        TabControl1.SelectTab(0)



        Try

            'Soma de data e ano bisexto 

            Dim iDias, iMes, iAno As Integer
            Dim sData As String

            'Compara a data atual com uma data anterior, no caso utilizei 01/01/1990 e vê a quantidade de 
            'dias do intervalo
            iDias = DateDiff("d", "01/01/1990", NireDataMaskedTextBox.Text)

            'Soma a quantidade de dias que quer somar e adiciona mais 1 para que de certo
            iDias = iDias + 1 + txtDataASomar.Text

            'coloca o ano que foi indicado acima na variavel que vai armazenar o ano
            iAno = 1990

            'faz um loop para saber quantos anos existem dentro da quantidade de dias achados
            Do While iDias >= 365
                iDias -= 365
                iAno += 1
                've se o ano é bissexto
                If iAno Mod 4 = 0 Then
                    iDias -= 1
                End If
            Loop

            'adiciona 1 na variavel que vai receber o mes
            iMes = 1

            'faz a mesma coisa que no ano, com um case no meio para ver os meses que não tem 31 dias
            'e corrigir as quantidades de dias a subtrair
            Do While iDias > 31
                iDias -= 31
                iMes += 1
                Select Case iMes
                    Case 3
                        If iAno Mod 4 = 0 Then
                            iDias += 2
                        Else
                            iDias += 3
                        End If
                    Case 5
                        iDias += 1
                    Case 7
                        iDias += 1
                    Case 8
                        iDias += 1
                    Case 10
                        iDias += 1
                    Case 12
                        iDias += 1
                End Select
            Loop

            'aqui pega os resultados e transforma em data.
            sData = iDias & "/" & iMes & "/" & iAno
            '& Format(sData, "dd/mm/yy")

            ' PrazoSimplesMaskedTextBox.Text = sData

            PrazoSimplesMaskedTextBox.Text = CDate(sData).ToString("dd/MM/yyyy")
            TabControle.SelectTab(5)

        Catch
            MessageBox.Show(" Data do NIRE está vazia! ", "Prince Ajuda")
            TabControle.SelectTab(2)
            TabControl1.SelectTab(0)

        End Try

    End Sub
    Private Sub Ajuda1()
        MessageBox.Show(" LEI 8934/94
Dispõe sobre o Registro Público de Empresas Mercantis e Atividades Afins e dá outras providências.
Art. 60. A firma individual ou a sociedade que não proceder a qualquer arquivamento no período de 10 (dez) anos consecutivos deverá comunicar à Empresa Fácil que deseja manter-se em funcionamento.

§ 1º Na ausência dessa comunicação, a empresa mercantil será considerada inativa, promovendo a Empresa Fácil o cancelamento do registro, com a perda automática da proteção ao nome empresarial.

§ 2º A empresa mercantil deverá ser notificada previamente pela Empresa Fácil, mediante comunicação direta ou por edital, para os fins deste artigo.

§ 3º A Empresa Fácil fará comunicação do cancelamento às autoridades arrecadadoras, no prazo de até dez dias.

§ 4º A reativação da empresa obedecerá aos mesmos procedimentos requeridos para sua constituição. ", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Ajuda1()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BtnConsultaRedeSim.Click
        Try
            If ProtocoloREDESIMTextBox.Text <> "" Then
                BoxREDESIM.Show()
            Else
                BoxREDESIM.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o site ou no codigo, verifique com o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Ajuda2()
        MessageBox.Show(" Foi informado um dos eventos de viabilidade abaixo?

*Alteração de endereço dentro do mesmo município
*Alteração do nome empresarial
*Alteração de natureza jurídica
*Alteração de atividades econômicas (principal e secundárias)
*Alteração do tipo de unidade
*Alteração da forma de atuação

Se for SIM, 
Precisa do Protocolo de Viabilidade da Empresa Fácil", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Ajuda2()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Ajuda1()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Ajuda2()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click



        ' MsgBox("Protocolo Copiado e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        ' Clipboard.SetText(ProtocoloREDESIMTextBox.Text)
        System.Diagnostics.Process.Start("http://www.fazenda.pr.gov.br/")

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        'System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")


        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        '  System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked


        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www8.receita.fazenda.gov.br/SimplesNacional/Servicos/Grupo.aspx?grp=t&area=1")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www8.receita.fazenda.gov.br/SimplesNacional/Servicos/Grupo.aspx?grp=t&area=1")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            System.Diagnostics.Process.Start(ArquivoContratoTextBox.Text)
        Catch
            MsgBox("Campo Vazio", MsgBoxStyle.Critical, "Prince Sistemas")
        End Try
    End Sub








    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        Dim Arquivo As String
        Dim Local As String

        Try
            OpenFileDialog1.ShowDialog()
            Arquivo = OpenFileDialog1.SafeFileName
            Local = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = ""
            ArquivoContratoTextBox.Text = Local


        Catch ex As Exception
            MsgBox("ERRO, Selecione algum arquivo para salvar o local da pasta", MsgBoxStyle.Critical, "Prince Sistemas")
            ArquivoContratoTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Try
            Salvar()

            If BtnEditar.Text = "Editar" Or BtnEditar.Text = "Cancelar" Then
                If MsgBox("Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
                    Me.Validate()
                    Me.EmpresasBindingSource.AddNew()

                    ' Uncheck Lembrete e Prioridade
                    LembreteCheckBox.CheckState = CheckState.Unchecked
                    PrioridadeCheckBox.CheckState = CheckState.Unchecked

                    ' Configurações de Cadastro
                    TipoDeEmpresaComboBox.SelectedIndex = 0
                    PorteDaEmpresaComboBox.SelectedIndex = -1
                    RegimeFederalComboBox.SelectedIndex = 0


                    SituacaoCadastralComboBox.SelectedText = "ATIVO"
                    SEDEComboBox.SelectedIndex = 1

                    ' Definir valores padrão
                    RegimeFederalComboBox.SelectedIndex = 4  ' RegimeFederal = Pendência
                    StatusComboBox.SelectedText = "Não Iniciado"
                    ProcessoComboBox.SelectedIndex = -1
                    SistemaExternoComboBox.SelectedIndex = 1  ' SistemaExterno = Não

                    ' Preencher campos com a data e hora atuais
                    EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()
                    AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
                    SEDEComboBox.SelectedIndex = 0
                    HabilitaEdicao()


                End If
            End If

        Catch ex As Exception
            MsgBox("ERRO, Verifique se os campos estão preenchidos corretamente", MsgBoxStyle.Critical, "Prince Sistemas")
        End Try
    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            If MsgBox("Tem certeza que deseja apagar o registo ?", MsgBoxStyle.YesNo, "A T E N Ç Ã O") = MsgBoxResult.Yes Then
                Me.Validate()
                Me.EmpresasBindingSource.RemoveCurrent()
                Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)
                Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
                MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
        Salvar()
        InicializarControles()
        ' Else

        ' End If


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub




    Private Sub Legalizacao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salvar()
        ' Verifica se o fechamento foi cancelado.
        If cancelarFechamento Then
            ' Cancela o fechamento do formulário.
            e.Cancel = True
            ' Exibe uma mensagem para indicar que o fechamento foi interrompido.
            MessageBox.Show("O fechamento foi cancelado.", "Fechamento Interrompido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        ' Fechar formulários e diálogos auxiliares se estiverem abertos
        If FrmEventos.Visible Then FrmEventos.Close()
        If DialogCalendarioEmpresas.Visible Then DialogCalendarioEmpresas.Close()
        If FrmControleEventosEmpresa.Visible Then FrmControleEventosEmpresa.Close()
        If FormadeAtuacao.Visible Then FormadeAtuacao.Close()
        If TipodeUnidade.Visible Then TipodeUnidade.Close()
        If DialogAjudaFormaAtuacao.Visible Then DialogAjudaFormaAtuacao.Close()
        If DialogAjudaTipoUnidade.Visible Then DialogAjudaTipoUnidade.Close()
    End Sub


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TabControle.SelectTab(2)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TabControle.SelectTab(3)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControle.SelectTab(5)
    End Sub



    Private Sub ProcessoComboBox_Validated(sender As Object, e As EventArgs) Handles ProcessoComboBox.Validated

        If ProcessoComboBox.Text = "Abertura" Then
            SistemaExternoLabel.Text = "Cadastro no Sistema Externo:"
        Else
            SistemaExternoLabel.Text = "Atualização no Sistema Externo:"

        End If
    End Sub


    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor")

        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            Dim a As DateTime
            a = DataPedidoIEMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles BtnCNAEMEI.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/quero-ser-mei/atividades-permitidas")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/quero-ser-mei/atividades-permitidas")

        End If
    End Sub

    Private Sub TipoDeEmpresaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoDeEmpresaComboBox.SelectedIndexChanged
        TipodeEmpresa()

    End Sub


    Private Sub TipodeEmpresa()
        Dim tiposCartorio As String() = {
        "Igreja",
        "Comunidade e Similares",
        "Associação Privada"
    }

        Dim tipoSelecionado As String = TipoDeEmpresaComboBox.Text

        ' Configuração para MEI (exclusivo)
        If tipoSelecionado = "Microempreendedor Indivual ( MEI )" Then
            Button24.Visible = True
            BtnCNAEMEI.Visible = False

            NAlteracaoComboBox.Visible = False
            NAlteracaoLabel.Visible = False
            LabelConsolidar.Visible = False
            AltConsolidadaComboBox.Visible = False
            NovaRazaoSocialLabel.Visible = False
            NovaRazaoSocialComboBox.Visible = False
            BtnVerNovoNome.Visible = False
            Button24.Visible = True
            LabelTipoEmpresa.Text = "MEI"
            BtnCNAEMEI.Visible = True

            ' Configuração para os outros tipos de cartório
        ElseIf tiposCartorio.Contains(tipoSelecionado) Then
            Button24.Visible = True
            BtnCNAEMEI.Visible = True

            NAlteracaoComboBox.Visible = False
            NAlteracaoLabel.Visible = True
            LabelConsolidar.Visible = False
            AltConsolidadaComboBox.Visible = False
            NovaRazaoSocialLabel.Visible = False
            NovaRazaoSocialComboBox.Visible = False
            BtnVerNovoNome.Visible = False
            Button24.Visible = False
            NAlteracaoLabel.Text = "Cartório"
            BtnCNAEMEI.Visible = False
            ' Define o LabelTipoEmpresa para os tipos de cartório
            LabelTipoEmpresa.Text = tipoSelecionado

            ' Configuração para os demais tipos
        Else
            Button24.Visible = False
            BtnCNAEMEI.Visible = False

            NAlteracaoComboBox.Visible = True
            NAlteracaoLabel.Visible = True
            LabelConsolidar.Visible = True
            AltConsolidadaComboBox.Visible = True
            NovaRazaoSocialLabel.Visible = True
            NovaRazaoSocialComboBox.Visible = True
            BtnVerNovoNome.Visible = True
            Button24.Visible = False
            NAlteracaoLabel.Text = "Nº.:"

            ' Define o LabelTipoEmpresa com base nos outros tipos
            Select Case tipoSelecionado
                Case "Sociedade Empresária Limitada ( Ltda. )"
                    LabelTipoEmpresa.Text = "Limitada - LTDA"
                Case "Empresa Individual de Responsabilidade Limitada ( Eireli )"
                    LabelTipoEmpresa.Text = "Eireli"
                Case "Empresa individual(RE)"
                    LabelTipoEmpresa.Text = "Empresa individual"
                Case "Sociedade Anônima(SA)"
                    LabelTipoEmpresa.Text = "Sociedade Anônima"
                Case "Sociedade Simples"
                    LabelTipoEmpresa.Text = "Sociedade Simples"
                Case Else
                    LabelTipoEmpresa.Text = ""
            End Select
        End If
    End Sub





    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TabControle.SelectTab(5)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TabControle.SelectTab(4)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TabControle.SelectTab(6)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Application.OpenForms.OfType(Of BoxConsultaIEEmpresa)().Count() > 0 Then
            BoxConsultaIEEmpresa.Focus()
        Else
            BoxConsultaIEEmpresa.Show()
        End If
    End Sub

    Private Sub IEjuntaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IEjuntaComboBox.SelectedIndexChanged
        If IEjuntaComboBox.Text = "Vinculado na Empresa Fácil" Then
            GroupBox12.Visible = False
            Button33.Visible = True


        Else
            GroupBox12.Visible = True
            Button33.Visible = False

        End If
    End Sub


    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            Dim a As DateTime
            a = ProtJuntaFinalMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub



    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

        ' Call ConexaoLaudo()
        Call VerificaCNPJemprCOMlaudos()

        'chamar mod teste
        'Call teste123456()

    End Sub


    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TabControle.SelectTab(2)

    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs)
        Try
            ' Verifica se o campo CNPJ está vazio
            If Trim(CNPJMaskedTextBox.Text) = "" Then
                MsgBox("O Campo CNPJ está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            Else
                ' Remove caracteres especiais do CNPJ e copia para a área de transferência
                Dim CNPJ As String = CNPJMaskedTextBox.Text
                Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

                ' Notifica o usuário que o CNPJ foi copiado
                MsgBox("CNPJ Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If
        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub Button35_Click(sender As Object, e As EventArgs)
        Try
            TabControle.SelectTab(1)
            TabControl2.SelectTab(0)
            If Trim(CPFResponsavelMaskedTextBox.Text) = "" Then

                MsgBox("O Campo CPF está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                TabControle.SelectTab(5)
            Else

                Dim CPF As String = CPFResponsavelMaskedTextBox.Text

                Clipboard.SetText(CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
                TabControle.SelectTab(5)
                ' MsgBox("CPF Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CPF" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)
        Try

            If Trim(CodigoSimplesTextBox.Text) = "" Then

                MsgBox("O Campo Código do Simples Nacional está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            Else

                Dim CodSimples As String = CodigoSimplesTextBox.Text

                Clipboard.SetText(CodSimples.Replace("/", "").Replace(",", "").Replace("-", "").Replace(" ", ""))
                ' MsgBox("Código do Simples Nacional Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao copiar Código do Simples Nacional" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub
    Private Sub BtnCopiaDataDeNasc_Click(sender As Object, e As EventArgs)
        Try
            TabControle.SelectTab(1)
            TabControl2.SelectTab(0)
            If Trim(RespDataNascMaskedTextBox.Text) = "" Then

                MsgBox("O Campo Data de Nascimento está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                TabControle.SelectTab(5)
            Else

                Dim DATANASC As String = RespDataNascMaskedTextBox.Text

                Clipboard.SetText(DATANASC.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
                TabControle.SelectTab(5)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar Data de Nascimento" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub


    Private Sub Button37_Click(sender As Object, e As EventArgs)
        Try

            TabControle.SelectTab(1)
            TabControl2.SelectTab(0)
            If Trim(TituloeleitorTextBox.Text) = "" Then

                MsgBox("O Campo Título de Eleitor está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                TabControle.SelectTab(5)
            Else

                Dim TituloDeEleitor As String = TituloeleitorTextBox.Text

                Clipboard.SetText(TituloDeEleitor.Replace("/", "").Replace(",", "").Replace("-", "").Replace(" ", ""))
                TabControle.SelectTab(5)
                ' MsgBox("Título de Eleitor Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar Título de Eleitor" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39")
        End If

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim Arquivo As String
        Dim Local As String

        'GetDirectoryName pega o diretorio apenas e nao o arquivo
        Try
            MsgBox("Selecione um arquivo para salvar o local da Pasta", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            OpenFileDialog1.ShowDialog()


            Arquivo = OpenFileDialog1.SafeFileName
            Local = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)

            PastaDocumentosTextBox.Text = Local




        Catch ex As Exception
            MsgBox("ERRO, Selecione algum arquivo para salvar o local da pasta", MsgBoxStyle.Critical, "Prince Sistemas")
            PastaDocumentosTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Try
            System.Diagnostics.Process.Start(PastaDocumentosTextBox.Text)
        Catch
            MsgBox("Campo Vazio", MsgBoxStyle.Critical, "Prince Sistemas")
            ' MessageBox.Show("Campo Vazio", "Prince Alerta")
        End Try
    End Sub

    Private Sub BtnAlteracao_Click(sender As Object, e As EventArgs) Handles BtnAlteracao.Click
        Try
            If MsgBox("Limpar o Procedimento e salvar no Histórico?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
                ' Percorrer todas as abas do TabControle
                For Each tab As TabPage In TabControle.TabPages
                    TabControle.SelectTab(tab)
                Next

                ' Selecionar a TabPage específica onde o histórico será salvo
                Dim tabPageHistorico As TabPage = tabPageHistorico
                If tabPageHistorico IsNot Nothing Then
                    TabControle.SelectTab(tabPageHistorico)
                End If

                ' Capturar os valores dos campos
                Dim A = NAlteracaoComboBox.Text.ToString()
                Dim B = ProcessoComboBox.Text.ToString()
                Dim C = EmpCriadoMaskedTextBox.Text.ToString()
                Dim D = MotivoRichTextBox.Text.ToString()
                Dim F = ProtocoloJuntaComercialTextBox.Text.ToString()
                Dim G = ProtocoloREDESIMTextBox.Text.ToString()
                Dim RazaoAntiga = RazaoSocialAntigaTextBox.Text.ToString()
                Dim RazaoAtual = RazaoSocialTextBox.Text.ToString()

                ' Atualizar o histórico
                HistoricoRichTextBox.AppendText(
                "Histórico anterior, Salvo Dia: " & Format(Now, "dd/MM/yyyy") & " às " & Format(Now, "HH:mm") & ", com as seguintes informações:" & vbCrLf &
                "Razao Social Atual: " & RazaoAtual & vbCrLf &
                "Razao Social Antiga: " & RazaoAntiga & vbCrLf &
                "Processo: " & A & " " & B & "." & vbCrLf &
                "Iniciado o processo em: " & C & "." & vbCrLf &
                "Motivo: " & D & "." & vbCrLf &
                "Protocolo Empresa Fácil: " & F & "." & vbCrLf &
                "Protocolo RedeSim: " & G & "." & vbCrLf &
                "//-----------------//-----------------//-----------------//-----------------//" & vbCrLf
            )

                MessageBox.Show("Dados Principais Salvos no Histórico", "Prince Avisa")

                ' Verificar se é uma nova alteração ou mudar o status
                HandleProcessStatus(A, B, C, D, F, G)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar no Histórico" & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub ClearFields()
        ' Limpar campos
        EmpCriadoMaskedTextBox.Text = ""
        MotivoRichTextBox.Text = ""
        GeralRichTextBox.Text = ""
        ProcedimentoRichTextBox.Text = ""
        AvisarDiaMaskedTextBox.Text = ""
        DataProtJuntaComercialMaskedTextBox.Text = ""
        ProtocoloJuntaComercialTextBox.Text = ""
        ProtJuntaFinalMaskedTextBox.Text = ""
        JuntaObsRichTextBox.Text = ""
        DataProtREDESIMMaskedTextBox.Text = ""
        ProtocoloREDESIMTextBox.Text = ""
        RedeSimObsRichTextBox.Text = ""
        IEjuntaComboBox.Text = ""
        DataPedidoIEMaskedTextBox.Text = ""
        IEInicioAtividadeMaskedTextBox.Text = ""
        IEComprovanteTextBox.Text = ""
        IEVencPedidoMaskedTextBox.Text = ""
        EstadualObsRichTextBox.Text = ""
        ProcessoComboBox.SelectedIndex = -1
        EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString()
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
        LembreteCheckBox.CheckState = CheckState.Unchecked
        PrioridadeCheckBox.CheckState = CheckState.Unchecked
        SistemaExternoComboBox.SelectedIndex = 1
    End Sub

    Private Sub HandleProcessStatus(A As String, B As String, C As String, D As String, F As String, G As String)
        ' Verifica se o campo ProcessoComboBox.Text contém "Alteração"
        If ProcessoComboBox.Text.Equals("Alteração", StringComparison.OrdinalIgnoreCase) Then
            ' Incrementa o número de alteração
            Dim alteracaoNumber As Integer
            If Integer.TryParse(NAlteracaoComboBox.Text, alteracaoNumber) Then
                NAlteracaoComboBox.Text = (alteracaoNumber + 1).ToString()
            Else
                NAlteracaoComboBox.Text = "1"
            End If
            ClearFields()
            ProcessoComboBox.Text = "Alteração"
            StatusComboBox.Text = "Não Iniciado"

            MsgBox("Número de Alteração incrementado. Verifique conforme a Empresa Fácil.", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        Else
            ' Não é uma alteração, apenas salvar os dados e mudar o status
            ClearFields()
            StatusComboBox.Text = "Não Iniciado"
            MsgBox("Nenhum dado encontrado para alteração. Status alterado para 'Não Iniciado'.", MsgBoxStyle.Information, "Prince Sistemas Informa!")

        End If
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TabControle.SelectTab(0)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs)
        'http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome
        'verificar se form WebSiteGERAL está aberto ou abrir
        If WebSiteGERAL.Visible = False Then
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome")
        Else
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome")
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        PastaDocumentosTextBox.Text = ""
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        ArquivoContratoTextBox.Text = ""
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Try
            ' Obtém o CNPJ e remove os caracteres especiais
            Dim CNPJ As String = CNPJMaskedTextBox.Text
            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

            '  ' Mensagem de confirmação
            ' MessageBox.Show("CNPJ copiado para a área de transferência!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Trata qualquer erro que possa ocorrer
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral")
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")
        End If
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Dim Protocolo As String = ProtocoloREDESIMTextBox.Text

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")
            If WebSiteGERAL.TxtCarregamento.Text = "Carregamento Completo" Then
                'id="prot"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementById('prot').value = '" + Protocolo + "'")
            End If
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")
        End If
    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Dim Protocolo As String = ProtocoloREDESIMTextBox.Text

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/cancela.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")

            If WebSiteGERAL.TxtCarregamento.Text = "Carregamento Completo" Then
                'id="prot"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementById('prot').value = '" + Protocolo + "'")
                'class="btn btn-primary"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementsByClassName('btn btn-primary')[0].click()")
            End If
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/cancela.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")
            If WebSiteGERAL.TxtCarregamento.Text = "Carregamento Completo" Then
                'id="prot"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementById('prot').value = '" + Protocolo + "'")
                'class="btn btn-primary"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementsByClassName('btn btn-primary')[0].click()")
            End If
        End If
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa")
        End If
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Try
            ' Obtém o CNPJ ou CPF e remove os caracteres especiais
            Dim CNPJ As String = CPFResponsavelMaskedTextBox.Text
            ' Descomente se você desejar substituir os caracteres especiais de forma diferente
            ' CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")

            ' Copia o valor tratado para a área de transferência
            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

            ' Mensagem de confirmação
            'MessageBox.Show("CPF copiado para a área de transferência!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Trata qualquer erro que possa ocorrer
            MessageBox.Show("Erro ao copiar CPF" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Try

            If WebSiteGERAL.Visible = False Then
                WebSiteGERAL.Show()
                WebSiteGERAL.BringToFront()
                WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")
            Else
                WebSiteGERAL.BringToFront()
                WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o navegador" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub BtnVerEventos_Click(sender As Object, e As EventArgs) Handles BtnVerEventos.Click, Button48.Click, Button47.Click
        TabControle.SelectTab(0)

    End Sub

    Private Sub BtnListaEventos_Click(sender As Object, e As EventArgs) Handles BtnListaEventos.Click
        If Application.OpenForms.OfType(Of FrmEventos)().Count() > 0 Then
            FrmEventos.Focus()
        Else
            FrmEventos.Show()
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click

        'limpar

        MotivoRichTextBox.Clear()


    End Sub


    Private Sub BtnCopiarSenhaGov_Click(sender As Object, e As EventArgs) Handles BtnCopiarSenhaGov.Click
        ' Verifica se o campo SenhaGovTextBox não está vazio
        Dim Senha As String = SenhaGovTextBox.Text
        If Not String.IsNullOrEmpty(Senha) Then
            ' Copia o conteúdo de SenhaGovTextBox para a área de transferência
            Clipboard.SetText(Senha)

            ' Exibe uma mensagem de confirmação ao usuário
            MessageBox.Show("Senha copiada para a área de transferência!", "Copiar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Exibe uma mensagem de alerta caso o campo esteja vazio
            MessageBox.Show("O campo Senha está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub Editar()
        Try
            If BtnEditar.Text = "Editar" Then
                BtnEditar.Text = "Cancelar"
                GroupBox2.Enabled = True
                GroupBox10.Enabled = True

                BtnExcluir.Enabled = False
                BtnAlteracao.Enabled = True

            ElseIf BtnEditar.Text = "Cancelar" Then
                ' Perguntar se o usuário deseja cancelar as alterações
                Dim resultado As DialogResult = MessageBox.Show("Deseja cancelar as alterações e reverter os dados?",
                                                         "Cancelar Edição", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then
                    ' Cancelar as alterações feitas e reverter os dados
                    Me.EmpresasBindingSource.CancelEdit()

                    ' Reverter o texto do botão e desabilitar os campos de edição
                    BtnEditar.Text = "Editar"
                    GroupBox2.Enabled = False
                    GroupBox10.Enabled = False

                    ' Reposicionar o foco nos controles
                    ' Reposicionar o foco nos controles
                    Dim NomeEmpresa As String = RazaoSocialTextBox.Text

                    ' Verificar se o ComboBox tem itens e o valor da empresa é válido
                    If ComboBoxBuscaEmpresa.Items.Count > 0 AndAlso NomeEmpresa IsNot Nothing Then
                        ComboBoxBuscaEmpresa.Text = NomeEmpresa
                    End If

                    ComboBoxBuscaEmpresa.Focus()
                    RazaoSocialTextBox.Focus()

                    ' Habilitar botões relevantes
                    BtnExcluir.Enabled = True
                    BtnAlteracao.Enabled = False
                Else
                    ' Manter o modo de edição
                    BtnEditar.Text = "Cancelar"
                    GroupBox2.Enabled = True
                    GroupBox10.Enabled = True

                    BtnExcluir.Enabled = False
                    BtnAlteracao.Enabled = True
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao editar: " & ex.Message & vbCrLf & "Detalhes: " & ex.StackTrace,
                             "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()
        InicializarControles()
        ' AtualizaDados2()

    End Sub


    Private Sub NovaRazaoSocialComboBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialComboBox.TextChanged
        ' RazaoSocialTextBox
        ' NovaRazaoSocialFinalTextBox
        Try
            Select Case NovaRazaoSocialComboBox.Text'.Trim()
                Case "Abertura"
                    ' RazaoSocialLabel.BackColor = Color.SeaGreen
                    ' If NovaRazaoSocialFinalTextBox.Text = NovaRazaoSocialFinalTextBox.Text Then

                    'RazaoSocialLabel.ForeColor = Color.Black
                    'PictureBox6.Image = My.Resources.V
                    ' Else
                    RazaoSocialLabel.ForeColor = Color.Red
                    PictureBox6.Image = My.Resources._Stop
                    ' End If
                    LabelNovaRazaoFinal.Visible = True
                    NovaRazaoSocialFinalTextBox.Visible = True
                    LinkLabelMudarRazaoSocial.Visible = True


                Case "Alteração"

                    RazaoSocialLabel.ForeColor = Color.Red
                    PictureBox6.Image = My.Resources.refresh_512

                    LabelNovaRazaoFinal.Visible = True
                    NovaRazaoSocialFinalTextBox.Visible = True
                    LinkLabelMudarRazaoSocial.Visible = True


                Case "Não Mudar"
                    'RazaoSocialLabel.BackColor = Color.SeaGreen
                    RazaoSocialLabel.ForeColor = Color.Black

                    PictureBox6.Image = My.Resources.V

                    LabelNovaRazaoFinal.Visible = False
                    NovaRazaoSocialFinalTextBox.Visible = False
                    LinkLabelMudarRazaoSocial.Visible = True

                Case Else


                    'RazaoSocialLabel.BackColor = Color.SeaGreen
                    RazaoSocialLabel.ForeColor = Color.Black
                    PictureBox6.Image = My.Resources.V

                    LabelNovaRazaoFinal.Visible = False
                    NovaRazaoSocialFinalTextBox.Visible = False
                    LinkLabelMudarRazaoSocial.Visible = False
            End Select

        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ProtocoloJuntaComercialTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocoloJuntaComercialTextBox.TextChanged
        If ProtocoloJuntaComercialTextBox.Text = "" Then

            BtnConsultaJunta.Text = "Solicitar"

        Else
            BtnConsultaJunta.Text = "Consultar"
        End If
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelMudarRazaoSocial.LinkClicked
        RazaoSocialTextBox.Text = NovaRazaoSocialFinalTextBox.Text
    End Sub

    Private Sub ProtocoloREDESIMTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocoloREDESIMTextBox.TextChanged
        'BtnConsultaRedeSim

        If ProtocoloREDESIMTextBox.Text = "" Then

            BtnConsultaRedeSim.Text = "Solicitar"

        Else
            BtnConsultaRedeSim.Text = "Consultar"
        End If
    End Sub


    Private Sub IETipoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IETipoComboBox.SelectedIndexChanged
        Try
            Select Case IETipoComboBox.Text
                Case "Abertura"
                    DatadeInicioIE.Visible = True
                    IEInicioAtividadeMaskedTextBox.Visible = True

                Case "Alteração"
                    DatadeInicioIE.Visible = False
                    IEInicioAtividadeMaskedTextBox.Visible = False

                Case "Baixa"
                    DatadeInicioIE.Visible = False
                    IEInicioAtividadeMaskedTextBox.Visible = False

                Case "Reativação"
                    DatadeInicioIE.Visible = True
                    IEInicioAtividadeMaskedTextBox.Visible = True

            End Select

        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub CnaeSimples_Click(sender As Object, e As EventArgs) Handles CnaeSimples.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.contabeis.com.br/ferramentas/simples-nacional/")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.contabeis.com.br/ferramentas/simples-nacional/")

        End If

    End Sub

    Private Sub BtnData1_Click(sender As Object, e As EventArgs) Handles BtnData1.Click
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
    End Sub

    Private Sub BtnData2_Click(sender As Object, e As EventArgs) Handles BtnData2.Click
        DataProtJuntaComercialMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
        'no status selecionar o texto =Empresa Fácil - Prefeitura: EM ANÁLISE
        Try
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact("Empresa Fácil - Prefeitura: EM ANÁLISE")
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'selecionar select all
            '  StatusComboBox.SelectedText = "Não Iniciado"
        End Try
    End Sub

    Private Sub BtnData3_Click(sender As Object, e As EventArgs) Handles BtnData3.Click
        ProtJuntaFinalMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()

        'procurar "Empresa Fácil - Protocolado"no StatusComboBox e selecionar
        Try
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact("Empresa Fácil - Protocolado")
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'selecionar select all
            StatusComboBox.SelectedText = "Não Iniciado"
        End Try

    End Sub

    Private Sub BtnData4_Click(sender As Object, e As EventArgs) Handles BtnData4.Click
        DataProtREDESIMMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub BtnConsultaeProcessoEstado_Click(sender As Object, e As EventArgs) Handles BtnConsultaeProcessoEstado.Click

        Dim IE As String = IEeProcNumTextBox.Text

        If Trim(IEeProcNumTextBox.Text) = "" Then
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")
            End If
        Else
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/consultarProtocoloDigital.do?action=pesquisar&numeroProtocolo=" + IE)
            End If
        End If

    End Sub

    Private Sub IEeProcNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles IEeProcNumTextBox.TextChanged
        If Trim(IEeProcNumTextBox.Text) = "" Then
            BtnConsultaeProcessoEstado.Text = "Solicitar"

        Else
            BtnConsultaeProcessoEstado.Text = "Consultar"

        End If
    End Sub

    Private Sub SistemaExternoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SistemaExternoComboBox.SelectedIndexChanged
        Try
            ' Define a fonte do ComboBox como negrito
            SistemaExternoComboBox.Font = New Font(SistemaExternoComboBox.Font, FontStyle.Bold)

            Select Case SistemaExternoComboBox.Text
                Case "Sim"
                    SistemaExternoComboBox.BackColor = Color.SeaGreen
                    SistemaExternoComboBox.ForeColor = Color.White
                    PictureBoxSistemaExterno.Image = My.Resources.check
                    CodSistemaExternoTextBox.Focus()

                    ' Se o campo estiver vazio, inicia o Timer para piscar a fonte
                    If String.IsNullOrWhiteSpace(CodSistemaExternoTextBox.Text) Then
                        If Not TimerCodEmpresa.Enabled Then TimerCodEmpresa.Start()
                    Else
                        TimerCodEmpresa.Stop()
                        CodSistemaExternoLabel.ForeColor = Color.Black ' Mantém preto quando preenchido
                    End If

                Case "Não"
                    SistemaExternoComboBox.BackColor = Color.Red
                    SistemaExternoComboBox.ForeColor = Color.White
                    PictureBoxSistemaExterno.Image = My.Resources.Cancel
                    TimerCodEmpresa.Stop() ' Para o piscar se mudar para "Não"
                    CodSistemaExternoLabel.ForeColor = Color.Black ' Mantém preto

                Case Else
                    ' Caso inesperado, define um padrão
                    SistemaExternoComboBox.BackColor = SystemColors.Window
                    SistemaExternoComboBox.ForeColor = SystemColors.ControlText
                    PictureBoxSistemaExterno.Image = Nothing
                    TimerCodEmpresa.Stop()
                    CodSistemaExternoLabel.ForeColor = Color.Black
            End Select

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "Erro no ComboBox")
        End Try
    End Sub

    Private Sub TimerCodEmpresa_Tick(sender As Object, e As EventArgs) Handles TimerCodEmpresa.Tick
        ' Alterna apenas a cor da fonte do label entre preto, amarelo e vermelho
        Select Case CodSistemaExternoLabel.ForeColor
            Case Color.Black
                CodSistemaExternoLabel.ForeColor = Color.Yellow
            Case Color.Yellow
                CodSistemaExternoLabel.ForeColor = Color.Red
            Case Else
                CodSistemaExternoLabel.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub CodSistemaExternoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodSistemaExternoTextBox.TextChanged
        ' Para o piscar e define a cor do texto como preto quando o campo for preenchido
        If Not String.IsNullOrWhiteSpace(CodSistemaExternoTextBox.Text) Then
            TimerCodEmpresa.Stop()
            CodSistemaExternoLabel.ForeColor = Color.Black ' Mantém a fonte preta
        Else
            TimerCodEmpresa.Start() ' Se apagar o texto, volta a piscar
        End If
    End Sub





    Private Sub RegimeFederalComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegimeFederalComboBox.SelectedIndexChanged
        '        RegimeFederalComboBox.Font = New Font(RegimeFederalComboBox.Font, FontStyle.Bold)

        If RegimeFederalComboBox.Text = "Pendência" Then
            RegimeFederalComboBox.BackColor = Color.Yellow
            RegimeFederalComboBox.ForeColor = Color.Black


        Else
            RegimeFederalComboBox.BackColor = Color.SeaGreen
            RegimeFederalComboBox.ForeColor = Color.White


        End If
    End Sub

    Private Sub BtnAdicionarSocio_Click(sender As Object, e As EventArgs) Handles BtnAdicionarSocio.Click
        'ativa TabControl2 inicia 0
        TabControl2.SelectedIndex = -1
        'verifica se esta vazio NomeResponsavelTextBox

        If NomeResponsavelTextBox.Text = "" Then
            MsgBox("Preencha o campo Nome do Responsável", MsgBoxStyle.Information, "Atenção")
            NomeResponsavelTextBox.Focus()
            Exit Sub

        Else
            TabControl2.SelectedIndex = 1
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                'pegar NomeResponsavelTextBox e coloca no FrmSocio.NomeResponsavelTextBox
                FrmSocios.Focus()
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            End If
        End If


    End Sub

    Private Sub BtnLimparSocio_Click(sender As Object, e As EventArgs) Handles BtnLimparSocio.Click
        If QuantidadeSociosTextBox.Text = "" Then
            QuantidadeSociosTextBox.Text = "0"
        Else
            QuantidadeSociosTextBox.Text = QuantidadeSociosTextBox.Text - 1

        End If

        If QuantidadeSociosTextBox.Text < "0" Then
            QuantidadeSociosTextBox.Text = "0"
        End If
    End Sub


    Private Sub BtnAddmaisSocio_Click(sender As Object, e As EventArgs) Handles BtnAddmaisSocio.Click
        If QuantidadeSociosTextBox.Text = "" Then
            QuantidadeSociosTextBox.Text = "0"
        Else
            QuantidadeSociosTextBox.Text = QuantidadeSociosTextBox.Text + 1

        End If

        If QuantidadeSociosTextBox.Text < "0" Then
            QuantidadeSociosTextBox.Text = "0"
        End If
    End Sub



    Private Sub BtnLimparSocios_Click(sender As Object, e As EventArgs) Handles BtnLimparSocios.Click
        If MsgBox("Deseja limpar todos Sócios?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
            DadosSociosRichTextBox.Text = ""
            QuantidadeSociosTextBox.Text = "0"
        End If


    End Sub


    '/////////// Inicio do codigo de mostrar calendario
    '//
    Private Sub AvisarDiaMaskedTextBox_Click(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Click

        'DialogCalendarioEmpresas abrir proximo ao AvisarDiaMaskedTextBox
        'DialogCalendarioEmpresas.Location = New Point(AvisarDiaMaskedTextBox.Location.X, AvisarDiaMaskedTextBox.Location.Y)
        DialogCalendarioEmpresas.Show()
        DialogCalendarioEmpresas.Focus()
        'abrir no local do mouse
        DialogCalendarioEmpresas.Location = New Point(MousePosition.X, MousePosition.Y)

    End Sub



    Private Sub AvisarDiaMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Leave
        DialogCalendarioEmpresas.Close()

    End Sub




    '/////////// fim do codigo de mostrar calendario

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

    Private Sub BtnContador_Click(sender As Object, e As EventArgs) Handles BtnContador.Click
        If Application.OpenForms.OfType(Of ContadorGeral)().Count() > 0 Then
            ContadorGeral.Focus()
            '   Contador.MdiParent = MDIPrincipal

        Else
            ' Contador.MdiParent = MDIPrincipal
            ContadorGeral.Show()
        End If
    End Sub

    'gerar CancelEventArgs e

    Private Sub EMAIL()
        Try
            ' Verifica se o item selecionado ainda é "Não"
            If SistemaExternoComboBox.SelectedItem IsNot Nothing AndAlso
           SistemaExternoComboBox.SelectedItem.ToString() = "Não" Then
                Return ' Sai do método se ainda estiver como "Não"
            End If

            ' Pergunta se deseja enviar o e-mail
            Dim resposta As DialogResult = MessageBox.Show("Foi enviado por email? Deseja enviar agora?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resposta = DialogResult.Yes Then
                EnviarEmail()
                SistemaExternoComboBox.SelectedItem = "Sim" ' Define como "Sim" após o envio
            End If

        Catch ex As Exception
            MsgBox("Erro ao tentar enviar o e-mail: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EnviarEmail()
        Try
            ' Pergunta ao usuário se deseja enviar a alteração por e-mail
            Dim result As DialogResult = MessageBox.Show("Deseja enviar por e-mail toda alteração feita?", "Prince Alerta", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Cancel Then
                Exit Sub ' Cancela e não faz nada
            ElseIf result = DialogResult.No Then
                ' Pergunta se deseja abrir o formulário de e-mail manualmente
                Dim abrirEmail As DialogResult = MessageBox.Show("Deseja abrir o e-Mail?", "Prince Alerta", MessageBoxButtons.YesNo)
                If abrirEmail = DialogResult.Yes Then
                    AbrirOuCriarFrmMail()
                End If
            ElseIf result = DialogResult.Yes Then
                ' Envia e-mail automaticamente
                SistemaExternoComboBox.SelectedItem = "Sim"

                '  MsgBox("O e-Mail será enviado automaticamente...", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                AbrirOuCriarFrmMail()
                ModeMail.Enviaremaillegalizacao()

            End If
        Catch ex As Exception
            MsgBox("Erro ao enviar e-mail: " & ex.Message, MsgBoxStyle.Critical)
            FrmAvisoEmpresa.Close()
        End Try
    End Sub

    Private Sub AbrirOuCriarFrmMail()
        ' Função para evitar repetição de código ao abrir ou criar FrmMail
        If Application.OpenForms.OfType(Of FrmMail)().Any() Then
            FrmMail.BringToFront()
            FrmMail.Focus()
        Else
            FrmMail.MdiParent = MDIPrincipal
            FrmMail.Show()
            FrmMail.BringToFront()
            FrmMail.Focus()
        End If
    End Sub

    Private Sub SistemaExternoComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SistemaExternoComboBox.SelectionChangeCommitted
        EMAIL()
    End Sub

    Private Sub ButtoneMail_Click(sender As Object, e As EventArgs) Handles ButtoneMail.Click
        'EnviarEmail()
        EMAIL()
    End Sub

    Private Sub NovaRazaoSocialComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialComboBox.SelectedIndexChanged
        'RazaoSocialTextBox.Text = NovaRazaoSocialFinalTextBox.Text
        'LinkLabel17
        If NovaRazaoSocialComboBox.Text = "Sim" Then
            NovaRazaoSocialFinalTextBox.Visible = True
            LabelNovaRazaoFinal.Visible = True
            LinkLabelMudarRazaoSocial.Visible = True
            BtnVerNovoNome.Visible = True
            BtnNovaRazao.Visible = True

        Else
            NovaRazaoSocialFinalTextBox.Visible = False
            LabelNovaRazaoFinal.Visible = False
            LinkLabelMudarRazaoSocial.Visible = False
            BtnVerNovoNome.Visible = False
            BtnNovaRazao.Visible = False
        End If


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

            FrmAnotacoes.lblMudaTexto.Text = "Legalização"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "FrmLegalizacao"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesFederal_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesFederal.Click, BtnAnotacoesSimples.Click
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

            FrmAnotacoes.lblMudaTexto.Text = "Receita Federal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Federal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesEstadual_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesEstadual.Click
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

            FrmAnotacoes.lblMudaTexto.Text = "Receita Estadual"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Estadual"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesPrefeitura_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesPrefeitura.Click
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
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesDemais_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesDemais.Click
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

            FrmAnotacoes.lblMudaTexto.Text = "Demais Assuntos"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Demais"))
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try

    End Sub




    'anexar documento

    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private ReadOnly da As SqlDataAdapter
    Private dr As SqlDataReader




    Private Sub BtnSalvarDoc_Click(sender As Object, e As EventArgs) Handles BtnSalvarDoc.Click
        If MsgBox("Deseja anexar o documento?", MsgBoxStyle.YesNo, "Salvar Anexo") = MsgBoxResult.Yes Then
            Try
                'procurar e salvar no banco de dados DocContratos varbinary aray    
                Dim dialogo As New OpenFileDialog With {
            .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
            .Title = "Selecione o arquivo de texto",
            .InitialDirectory = "C:\"
        }
                dialogo.ShowDialog()
                'DocContratosLinkLabel.Text = dialogo.FileName
                'salvar no banco de dados SQL SERVER Banco Empresas varbinary aray

                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                'tabela empresas e coluna DocContratos por razao social
                comando = New SqlCommand("UPDATE Empresas SET DocContratos = @DocContratos WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@DocContratos", SqlDbType.VarBinary).Value = File.ReadAllBytes(dialogo.FileName)
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                MsgBox("Documento salvo com sucesso!")
                DocContratosLinkLabel.Text = "Contrato Anexado"
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
                ' DocContratosLinkLabel.Text = ""
            End Try
        End If
    End Sub


    Private Sub AbrirAnexo()
        'save a file in .docx format, which was saved as VarBinary, in the database table companies and column DocContratos for corporate reasons
        If MsgBox("Deseja abrir o documento anexado?", MsgBoxStyle.YesNo, "Abrir Anexo") = MsgBoxResult.Yes Then
            Try
                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                comando = New SqlCommand("SELECT DocContratos FROM Empresas WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                'SqlDataReader

                dr = comando.ExecuteReader
                If dr.Read Then

                    Dim doc As Byte() = DirectCast(dr("DocContratos"), Byte())
                    'opendialog  para salvar o arquivo FileStream do banco de dados
                    'mudar local de salvamento do doc
                    Dim saveFileDialog1 As New SaveFileDialog With {
                        .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
                        .Title = "Salvar Arquivo de Texto"
                    }
                    saveFileDialog1.ShowDialog()
                    Dim fs As New FileStream(saveFileDialog1.FileName, FileMode.Create)
                    'escreve o arquivo no banco de dados
                    fs.Write(doc, 0, doc.Length)
                    'fecha o arquivo
                    fs.Close()
                    'perguntas antes de abrir o arquivo
                    Dim result As DialogResult = MessageBox.Show("Deseja abrir o arquivo?", "Abrir Arquivo", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Process.Start(saveFileDialog1.FileName)
                    End If
                End If
                conexao.Close()


            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
            End Try
        End If


    End Sub
    Private Sub BtnAbrirDoc_Click(sender As Object, e As EventArgs) Handles BtnAbrirDoc.Click

        AbrirAnexo()

    End Sub




    Private Sub BtnApagaAnexo_Click(sender As Object, e As EventArgs) Handles BtnApagaAnexo.Click
        Dim result As DialogResult = MessageBox.Show("Deseja apagar o anexo?", "Apagar Arquivo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                comando = New SqlCommand("UPDATE Empresas SET DocContratos = NULL WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                MsgBox("Documento apagado com sucesso!")
                DocContratosLinkLabel.Text = ""
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
            End Try
        End If

    End Sub

    Private Sub DocContratosLinkLabel_TextChanged(sender As Object, e As EventArgs) Handles DocContratosLinkLabel.TextChanged
        If DocContratosLinkLabel.Text = "" Then
            'DocContratosLinkLabel.Text = "Sem Anexo"
            AnexoBoxPicture.Image = My.Resources.off
            'muda tamanho da imagem
            AnexoBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            DocContratosLinkLabel.Text = "Contrato Anexado"
            'muda AnexoBoxPicture com imagem _on
            AnexoBoxPicture.Image = My.Resources._on
            AnexoBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub DocContratosLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DocContratosLinkLabel.LinkClicked
        If DocContratosLinkLabel.Text = "Contrato Anexado" Then
            AbrirAnexo()
        Else
            'mostrar menssagem "A empresa atual não contém anexo?"
            MsgBox("A empresa atual não contém anexo!")
        End If
    End Sub

    Private Sub BtnArrumar_Click(sender As Object, e As EventArgs) Handles BtnArrumar.Click
        'ArquivoContratoTextBox.Text = PastaDocumentosTextBox.Text

        PastaDocumentosTextBox.Text = ArquivoContratoTextBox.Text

        'PastaDocumentosTextBox apagar até o ultimo BARRA 
        Dim i As Integer
        For i = Len(PastaDocumentosTextBox.Text) To 1 Step -1
            If Mid(PastaDocumentosTextBox.Text, i, 1) = "\" Then
                PastaDocumentosTextBox.Text = Mid(PastaDocumentosTextBox.Text, 1, i)
                Exit For
            End If
        Next




    End Sub

    Private Sub BtnImportarAnexo_Click(sender As Object, e As EventArgs) Handles BtnImportarAnexo.Click
        If MsgBox("Deseja importar o documento?", MsgBoxStyle.YesNo, "Importar Contrato") = MsgBoxResult.Yes Then
            Try
                TabControl1.Focus()
                TabControl1.SelectedIndex = 1

                If ArquivoContratoTextBox.Text = "" Then
                    MsgBox("Erro! Campo do caminho do documento está vazio")
                Else
                    Dim ArquivoContrato As String = ArquivoContratoTextBox.Text
                    'pega o ArquivoContrato e salva no banco de dados

                    conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                    comando = New SqlCommand("UPDATE Empresas SET DocContratos = @DocContratos WHERE RazaoSocial = @RazaoSocial", conexao)
                    comando.Parameters.Add("@DocContratos", SqlDbType.VarBinary).Value = IO.File.ReadAllBytes(ArquivoContrato)
                    comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                    conexao.Open()
                    comando.ExecuteNonQuery()
                    conexao.Close()
                    MsgBox("Documento importado com sucesso!")
                    DocContratosLinkLabel.Text = "Contrato Anexado"

                End If
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
                'DocContratosLinkLabel.Text = ""
            End Try
        End If

    End Sub

    Private Sub StatusComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StatusComboBox.KeyPress
        'e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub ProcessoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProcessoComboBox.KeyPress
        ' e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub AltConsolidadaComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AltConsolidadaComboBox.KeyPress
        '  e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub NovaRazaoSocialComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NovaRazaoSocialComboBox.KeyPress
        ' e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub SistemaExternoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SistemaExternoComboBox.KeyPress
        'e.Handled = True 'nao permitir escrita
    End Sub



    Private Sub ProcessoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProcessoComboBox.SelectedIndexChanged

        '  ProcessoMudar()
        StatusMudar()
        MudaContratoAviso()
        TipodeEmpresa()
        ProcessoMudar()
    End Sub

    Private Sub MudaContratoAviso()
        ProcessoLabel2.Text = ProcessoComboBox.Text
        NAlteracaoLabel2.Text = NAlteracaoComboBox.Text
    End Sub

    Private Sub StatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusComboBox.SelectedIndexChanged

        ' ProcessoMudar()
        StatusMudar()
        MudarStatusFinalizado()
        TipodeEmpresa()
        ProcessoMudar()
    End Sub
    Private Sub MudarStatusFinalizado()
        Dim isFinalizado As Boolean = StatusComboBox.Text.Contains("Finalizado")
        Dim isSimplesNacional As Boolean = StatusComboBox.Text.Contains("Simples Nacional")

        ' Se o status for Finalizado ou Simples Nacional E o Sistema Externo estiver como "Não"
        If (isFinalizado OrElse isSimplesNacional) AndAlso SistemaExternoComboBox.SelectedItem.ToString() = "Não" Then
            ' Pergunta se foi alterado no sistema externo
            Dim respostaSistema As DialogResult = MessageBox.Show("Foi alterado no seu Sistema Particular?", "Notificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respostaSistema = DialogResult.Yes Then
                ' Pergunta se deseja enviar por e-mail
                Dim respostaEmail As DialogResult = MessageBox.Show("Foi enviado por email? Deseja enviar agora?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respostaEmail = DialogResult.Yes Then
                    EnviarEmail()
                End If

                ' Muda o campo para "Sim" após confirmação
                SistemaExternoComboBox.SelectedItem = "Sim"
                AtualizarInterface()

            Else
                ' Se não foi atualizado no sistema externo, marca como pendente
                StatusComboBox.Text = "Pêndencia Sistema Externo"
                StatusComboBox.BackColor = Color.Red
                StatusComboBox.ForeColor = Color.Black
                PictureBox1.Image = My.Resources.check
                PictureBox2.Image = Nothing
                SistemaExternoComboBox.SelectedItem = "Não"
            End If

        ElseIf SistemaExternoComboBox.SelectedItem.ToString() = "Sim" Then
            ' Se já está como "Sim", apenas atualiza a interface sem perguntar novamente
            AtualizarInterface()
        Else
            ' Configuração padrão se não atender às outras condições
            StatusComboBox.BackColor = Color.Green
            StatusComboBox.ForeColor = Color.White
            PictureBox1.Image = My.Resources.check
        End If
    End Sub



    Private Sub AtualizarInterface()
        StatusComboBox.BackColor = Color.Green
        StatusComboBox.ForeColor = Color.White
        '  AvisarDiaMaskedTextBox.Text = ""
        PictureBox1.Image = My.Resources.check

        If ProcessoComboBox.Text = "Baixa" Then
            PictureBox2.Image = My.Resources.fechadaempresa
        Else
            PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
        End If
    End Sub



    Private Sub BtnImportarRazaoSocial_Click(sender As Object, e As EventArgs) Handles BtnImportarRazaoSocial.Click
        'pega a razaosocialtextbox e coloca no RazaoSocialAntigaTextBox 
        RazaoSocialAntigaTextBox.Text = RazaoSocialTextBox.Text
    End Sub

    'Razao Social 1
    Private Sub BtnUsarRazao1_Click(sender As Object, e As EventArgs) Handles BtnUsarRazao1.Click
        'pega NovaRazaoSocial1TextBox e coloca no NovaRazaoSocialFinalTextBox
        'ativa a TabControle 2 e retorna
        ' TabControle.SelectedIndex = 2
        RazaoSocialTextBox.Text = NovaRazaoSocial1TextBox.Text
    End Sub
    'Razao Social 2
    Private Sub BtnUsarRazao2_Click(sender As Object, e As EventArgs) Handles BtnUsarRazao2.Click
        'pega NovaRazaoSocial2TextBox e coloca no NovaRazaoSocialFinalTextBox
        'ativa a TabControle 2 e retorna
        'TabControle.SelectedIndex = 2
        RazaoSocialTextBox.Text = NovaRazaoSocial2TextBox.Text
    End Sub
    'Razao Social 3
    Private Sub BtnUsarRazao3_Click(sender As Object, e As EventArgs) Handles BtnUsarRazao3.Click
        'pega NovaRazaoSocial3TextBox e coloca no NovaRazaoSocialFinalTextBox
        'ativa a TabControle 2 e retorna
        ' TabControle.SelectedIndex = 2
        RazaoSocialTextBox.Text = NovaRazaoSocial3TextBox.Text
    End Sub

    Private Sub BtnUsarNomeFantasia_Click(sender As Object, e As EventArgs) Handles BtnUsarNomeFantasia.Click
        'pega NomeFantasiaTextBox1 e  coloca no NomeFantasiaTextBox
        NomeFantasiaTextBox.Text = NomeFantasiaTextBox1.Text
    End Sub

    Private Sub BtnImportarSocioAdm_Click(sender As Object, e As EventArgs) Handles BtnImportarSocioAdm.Click
        'verifica se tem NomeResponsavelTextBox preenchido ou abre
        If NomeResponsavelTextBox.Text = "" Then
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
            Else
                FrmSocios.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
                'igual do frmsocios.NomeCompletoComboBox.text
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            End If

        End If


    End Sub

    Private Sub BtnWord_Click(sender As Object, e As EventArgs) Handles BtnWord.Click
        If ExportarContratoWordDialog.Visible = True Then
            ExportarContratoWordDialog.Focus()
        Else
            ExportarContratoWordDialog.ShowDialog()
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnAddSocios.Click
        'pergunta se deseja add manual
        If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
            FrmSocios.Focus()
            FrmSocios.BtnCapitalSocial.PerformClick()
            FrmSocios.BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social"
            FrmSocios.GroupBoxCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Enabled = True
            FrmSocios.GroupBoxCapitalSocial.Enabled = True

            Dim CapitalSocialEmpresas As String = CapitalSTextBox.Text
            'exporta para frmsocios.TextBoxCapitalSocial.text
            FrmSocios.TextBoxCapitalSocial.Text = CapitalSocialEmpresas
        Else
            FrmSocios.Show()
            FrmSocios.BtnCapitalSocial.PerformClick()
            FrmSocios.BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social"
            FrmSocios.GroupBoxCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Enabled = True
            FrmSocios.GroupBoxCapitalSocial.Enabled = True

            Dim CapitalSocialEmpresas As String = CapitalSTextBox.Text
            'exporta para frmsocios.TextBoxCapitalSocial.text
            FrmSocios.TextBoxCapitalSocial.Text = CapitalSocialEmpresas
        End If


    End Sub

    'CapitalSTextBox usar mascara em reais
    Private Sub CapitalSTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitalSTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'CapitalITextBox
    Private Sub CapitalITextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitalITextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'CapitalITextBox validar em reais
    Private Sub CapitalITextBox_LostFocus(sender As Object, e As EventArgs) Handles CapitalITextBox.LostFocus
        If CapitalITextBox.Text = "" Then
            CapitalITextBox.Text = "0,00"
        Else
            CapitalITextBox.Text = FormatCurrency(CapitalITextBox.Text)
        End If
    End Sub
    'CapitalQuotaValorTextBox.Text  validar em reais
    Private Sub CapitalQuotaValorTextBox_LostFocus(sender As Object, e As EventArgs) Handles CapitalQuotaValorTextBox.LostFocus
        If CapitalQuotaValorTextBox.Text = "" Then
            CapitalQuotaValorTextBox.Text = "0,00"
        Else
            CapitalQuotaValorTextBox.Text = FormatCurrency(CapitalQuotaValorTextBox.Text)
        End If
    End Sub

    Private Sub CapitalQuotaValorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitalQuotaValorTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'CapitaQuotaTotalTextBox  validar sem os reais, apenas numeros sem ",00"
    Private Sub CapitaQuotaTotalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitaQuotaTotalTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnPreencherCapital_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnPreencherCapital.LinkClicked
        Static valorFormatado As Boolean = False ' Flag para controlar se o valor já foi formatado

        ' Verifica se o valor foi alterado e formata se necessário
        If CapitalSTextBox.Text <> "" Then
            Dim valorCapital As Decimal

            ' Tenta analisar o valor no formato brasileiro (com vírgula para decimais)
            Dim culturaBR As Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("pt-BR")

            If Decimal.TryParse(CapitalSTextBox.Text.Replace("R$", "").Trim(),
                            Globalization.NumberStyles.Currency,
                            culturaBR,
                            valorCapital) Then

                ' Formata o valor atual do capital
                CapitalSTextBox.Text = valorCapital.ToString("C2", culturaBR) ' Formata como moeda com 2 casas decimais
                CapitalITextBox.Text = valorCapital.ToString("C2", culturaBR) ' Formata como moeda com 2 casas decimais
                CapitalQuotaValorTextBox.Text = "R$ 1,00"
                CapitaQuotaTotalTextBox.Text = valorCapital.ToString("N0", culturaBR) ' Formata como número inteiro

                ' Verifica se o CapitalAntigoMudouCheckBox está marcado
                If CapitalAntigoMudouComboBox.Text = "Sim" Then
                    ' Exibe e formata o campo de capital antigo
                    CapitalSocialAntigoLabel.Visible = True
                    CapitalSocialAntigoTextBox.Visible = True

                    ' Mantém o valor antigo sem alterar
                    ' Adiciona a formatação "R$" ao valor antigo, se necessário
                    If Not CapitalSocialAntigoTextBox.Text.Contains("R$") Then
                        Dim valorAntigo As Decimal
                        If Decimal.TryParse(CapitalSocialAntigoTextBox.Text.Replace("R$", "").Trim(),
                                        Globalization.NumberStyles.Currency,
                                        culturaBR,
                                        valorAntigo) Then
                            ' Atualiza o valor no campo antigo, se necessário
                            CapitalSocialAntigoTextBox.Text = valorAntigo.ToString("C2", culturaBR)
                        End If
                    End If
                End If

                valorFormatado = True ' Marca o valor como formatado
            Else
                MessageBox.Show("Digite um valor numérico válido para o Capital Social.", "Erro", CType(MsgBoxStyle.Exclamation, MessageBoxButtons))
                CapitalSTextBox.Focus()
            End If
        End If
    End Sub



    Private Sub BtnRemoveSocios_Click(sender As Object, e As EventArgs) Handles BtnRemoveSocios.Click
        'perguntar se deseja limpar os dados
        If MsgBox("Deseja limpar a Divisão de Capital Social?", MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.Yes Then
            'limpar os dados
            DivisaoCapitalSociosRichTextBox.Text = ""
        Else
            'não faz nada
        End If

    End Sub

    Private Sub BtnCorreios_Click(sender As Object, e As EventArgs) Handles BtnCorreios.Click
        'vers e WebCorreios esta aberto

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://buscacepinter.correios.com.br/app/endereco/index.php")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://buscacepinter.correios.com.br/app/endereco/index.php")

        End If

    End Sub

    Private Sub LblLinkAjudaSimples_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLinkAjudaSimples.LinkClicked
        MessageBox.Show("A solicitação de opção pelo Simples Nacional somente pode ser realizada no mês de janeiro, até o seu último dia útil. Uma vez deferida, produz efeitos a partir do primeiro dia do ano calendário da opção." & vbCrLf & "
Para empresas em início de atividade, o prazo para soliticação de opção é de 30 dias contados do último deferimento de inscrição (municipal ou estadual, caso exigíveis), desde que não tenham decorridos 60 dias da inscrição do CNPJ. Se deferida, a opção produz efeitos a partir da data da abertura do CNPJ. Após esse prazo, a opção somente será possível no mês de janeiro do ano-calendário seguinte.")

    End Sub

    Private Sub BtnMgsBoxDataSimples_Click(sender As Object, e As EventArgs) Handles BtnMgsBoxDataSimples.Click
        'DataSimplesMaskedTextBox em extenso por mgsbox
        Try
            Dim a As DateTime
            a = DataSimplesMaskedTextBox.Text
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try

    End Sub

    Private Sub BtnMgsBoxAvisarDia_Click(sender As Object, e As EventArgs) Handles BtnMgsBoxAvisarDia.Click
        'AvisarDiaMaskedTextBox
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

    Private Sub BtnRemovCaract_Click(sender As Object, e As EventArgs) Handles BtnRemovCaract.Click
        RamoDeAtividadeRichTextBox.Text = LimparTextoRamo(RamoDeAtividadeRichTextBox.Text)
        ObjetoDOEstabelecimentoRichTextBox.Text = LimparTextoRamo(ObjetoDOEstabelecimentoRichTextBox.Text)

    End Sub
    Function LimparTextoRamo(sText As String) As String
        sText = System.Text.RegularExpressions.Regex.Replace(sText, "\s+", " ")
        sText = sText.Replace(Environment.NewLine, ";")
        sText = System.Text.RegularExpressions.Regex.Replace(sText, "\s*;\s*", ";")
        sText = System.Text.RegularExpressions.Regex.Replace(sText, "[*+@!#$%&?]", "")
        sText = sText.ToLower() ' Converte todo o texto para minúsculas
        Return sText
    End Function

    Private Sub BtnConsultaOptante_Click(sender As Object, e As EventArgs) Handles BtnConsultaOptante.Click
        ' Obtém o CNPJ do campo e remove os caracteres especiais
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        ' Verifica se o WebSiteGERAL está visível e atualiza a URL
        If WebSiteGERAL.Visible Then
            WebSiteGERAL.Focus()
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.Focus()
        End If

        ' Atualiza o WebView com a URL de consulta
        WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")

        ' Exibe mensagem informando que o CNPJ foi copiado
        MsgBox("CNPJ copiado, use CTRL+V para colar no local desejado")
    End Sub


    Private Sub BtnAvancoRazao_Click(sender As Object, e As EventArgs) Handles BtnAvancoRazao.Click
        'mostrar por mgsbox a RazaoSocialTextBox completa, mgsbox alerta
        '"A razão social da empresa completa é: "
        MessageBox.Show("A razão social da empresa completa é: " & RazaoSocialTextBox.Text, "Prince Ajuda")
    End Sub





    Private Sub SEDEComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SEDEComboBox.SelectionChangeCommitted
        ' Verificar se existe empresas com o mesmo nome e informar via MessageBox
        Dim con As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        Dim cmd As New SqlCommand("SELECT * FROM Empresas WHERE SEDE = @SEDE AND RazaoSocial = @RazaoSocial", con)
        cmd.Parameters.AddWithValue("@SEDE", SEDEComboBox.Text)
        cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim Sede As String = SEDEComboBox.Text
            Dim result As DialogResult = MessageBox.Show("Existe uma empresa com a mesma razão social e sede: " & Sede & vbCrLf & "Deseja continuar com a mudança?", "Prince Ajuda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                ' Reverter para a seleção anterior
                SEDEComboBox.SelectedIndex = SEDEComboBox.FindString(SEDEComboBox.Text)
            Else
                ' Continuar e executar a lógica adicional
                BoxEmpresasIguais()
            End If
        End If
    End Sub

    Private Sub BoxEmpresasIguais()
        Dim Filtro As String = RazaoSocialTextBox.Text
        DialogEmpresasIguais.EmpresasBindingSource.Filter = String.Format("Status LIKE '%{0}%'", Filtro)
    End Sub

    Private Sub BtnDadosComplementares_Click(sender As Object, e As EventArgs) Handles BtnDadosComplementares.Click
        'TabControl2 ir para tab6
        TabControl2.SelectedIndex = 7
    End Sub



    Private Sub BtnAjudaAréa_Click(sender As Object, e As EventArgs) Handles BtnAjudaAréa.Click
        'mgsbox ajudando informando = " IMPORTANTE SABER!
        MessageBox.Show("IMPORTANTE SABER!
A metragem deve ser preenchida com exatidão pois esta informação impacta nos demais órgãos:

Área do Imóvel = é a área total da edificação.

Área do Estabelecimento = é a área exata (em metros quadrados) do local onde é realizada a atividade econômica dentro de um imóvel, podendo ocupar toda ou apenas uma parte da área do imóvel. Essa área nunca poderá ser zero ou maior que o imóvel.
")

        ' Mensagem de pergunta ao usuário
        Dim result As DialogResult = MessageBox.Show("Deseja ver no mapa?", "Ver Mapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verifica a resposta do usuário
        If result = DialogResult.Yes Then
            ' Chama o método Mapa
            Mapa()
        End If

    End Sub

    Private Sub BtnAjudaEmpresaFacilTipoUnidade_Click(sender As Object, e As EventArgs) Handles BtnAjudaEmpresaFacilTipoUnidade.Click
        'abrir AjudaEmpresaFacilTipoUnidade mas verificando se esta aberta
        If DialogAjudaTipoUnidade.Visible = True Then
            DialogAjudaTipoUnidade.Close()
            'trazer para frente 
            DialogAjudaTipoUnidade.BringToFront()
        Else
            DialogAjudaTipoUnidade.Show()
            DialogAjudaTipoUnidade.BringToFront()
        End If
    End Sub

    Private Sub BtnAjudaEmpresaFacilFormaAtuacao_Click(sender As Object, e As EventArgs) Handles BtnAjudaEmpresaFacilFormaAtuacao.Click
        'abrir AjudaEmpresaFacilTipoUnidade mas verificando se esta aberta
        If DialogAjudaFormaAtuacao.Visible = True Then
            DialogAjudaFormaAtuacao.Close()
            'trazer para frente 
            DialogAjudaFormaAtuacao.BringToFront()
        Else
            DialogAjudaFormaAtuacao.Show()
            DialogAjudaFormaAtuacao.BringToFront()
        End If
    End Sub

    Private Sub TipoUnidadeProdutivaRichTextBox_Click(sender As Object, e As EventArgs) Handles TipoUnidadeProdutivaRichTextBox.Click
        If TipodeUnidade.Visible = True Then
            TipodeUnidade.Close()
            'trazer para frente 
            TipodeUnidade.BringToFront()
        Else
            TipodeUnidade.Show()
            TipodeUnidade.BringToFront()
        End If
    End Sub

    Private Sub FormaDeAtuacaoRichTextBox_Click(sender As Object, e As EventArgs) Handles FormaDeAtuacaoRichTextBox.Click
        If FormadeAtuacao.Visible = True Then
            FormadeAtuacao.Close()
            'trazer para frente 
            FormadeAtuacao.BringToFront()
        Else
            FormadeAtuacao.Show()
            FormadeAtuacao.BringToFront()
        End If
    End Sub

    Private Sub TipoUnidadeProdutivaRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoUnidadeProdutivaRichTextBox.TextChanged
        If TipoUnidadeProdutivaRichTextBox.Text.Contains("Unidade Produtiva") Then
            FormaDeAtuacaoRichTextBox.Visible = True
            FormaDeAtuacaoLabel.Visible = True
        Else
            FormaDeAtuacaoRichTextBox.Visible = False
            FormaDeAtuacaoLabel.Visible = False
        End If
    End Sub
    Private Sub BtnCopiarRamo_Click(sender As Object, e As EventArgs) Handles BtnCopiarRamo.Click
        ' Verifica se o RichTextBox não está vazio
        If Not String.IsNullOrEmpty(RamoDeAtividadeRichTextBox.Text) Then
            ' Copia o conteúdo do RamoDeAtividadeRichTextBox para a área de transferência
            Clipboard.SetText(RamoDeAtividadeRichTextBox.Text)

            ' Exibe uma mensagem de confirmação ao usuário
            ' MessageBox.Show("Texto copiado para a área de transferência!", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Exibe uma mensagem de alerta caso o campo esteja vazio
            MessageBox.Show("O campo Ramo de Atividade está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub BtnCopiaEndereco_Click(sender As Object, e As EventArgs) Handles BtnCopiaEndereco.Click
        'copiar no formato "avenida Pioneiro Antônio Franco de Morais, Nº 1373, Sala 02, Jardim Brasil, CEP: 87083-260, Maringá-PR"
        Dim Endereco As String = EnderecoTextBox.Text
        Dim Numero As String = EndNumeroTextBox.Text
        Dim Complemento As String = EndComplementoTextBox.Text
        Dim Bairro As String = EndBairroTextBox.Text
        Dim CEP As String = EndCEPMaskedTextBox.Text
        Dim Cidade As String = EndCidadeTextBox.Text
        Dim UF As String = EndEstadoTextBox.Text

        'se tiver complemento ou retirar o complemento
        If Complemento = "" Then
            Clipboard.SetText(Endereco & ", n.º " & Numero & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & UF)
        Else
            Clipboard.SetText(Endereco & ", n.º " & Numero & ", " & Complemento & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & UF)
        End If

        'mgsbox
        ' MessageBox.Show("Endereço copiado com sucesso!")
    End Sub

    Private Sub BtnLimpaCaractRazao_Click(sender As Object, e As EventArgs) Handles BtnLimpaCaractRazao.Click
        ' Converte o texto para maiúsculas e remove espaços extras e quebras de linha
        NovaRazaoSocial1TextBox.Text = LimparTexto(NovaRazaoSocial1TextBox.Text)
        NovaRazaoSocial2TextBox.Text = LimparTexto(NovaRazaoSocial2TextBox.Text)
        NovaRazaoSocial3TextBox.Text = LimparTexto(NovaRazaoSocial3TextBox.Text)
        NomeFantasiaTextBox1.Text = LimparTexto(NomeFantasiaTextBox1.Text)
        NovaRazaoSocialFinalTextBox.Text = LimparTexto(NovaRazaoSocialFinalTextBox.Text)
        RazaoSocialAntigaTextBox.Text = LimparTexto(RazaoSocialAntigaTextBox.Text)
    End Sub

    ' Função auxiliar para converter o texto para maiúsculas e remover espaços e quebras de linha
    Private Function LimparTexto(texto As String) As String
        Return texto.ToUpper().Trim().Replace(vbCr, "").Replace(vbLf, "")
    End Function


    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        ' Chamar o método de verificação
        VerificarCNPJ(CNPJMaskedTextBox.Text)
    End Sub

    Private Sub VerificarCNPJ(cnpj As String)
        ' O CNPJ está no formato já formatado com máscara
        Dim cnpjFormatado As String = cnpj

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando CNPJ: " & cnpjFormatado)

                ' Consultar o CNPJ na tabela "Laudos"
                Dim query As String = "SELECT CNPJ FROM Empresas WHERE CNPJ = @CNPJ"
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

    Private Async Sub BtnBuscaCEP_Click(sender As Object, e As EventArgs) Handles BtnBuscaCEP.Click
        Try
            BtnBuscaCEP.Enabled = False
            BtnBuscaCEP.Text = "AGUARDE..."

            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(EndCEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                ' Modificar apenas a primeira letra para minúscula
                EnderecoTextBox.Text = PrimeiraLetraMinuscula(resultado.logradouro)

                ' Preencher complemento caso esteja vazio
                If String.IsNullOrWhiteSpace(EndComplementoTextBox.Text) Then
                    EndComplementoTextBox.Text = resultado.complemento
                End If

                EndCidadeTextBox.Text = resultado.localidade
                EndBairroTextBox.Text = resultado.bairro
                EndEstadoTextBox.Text = resultado.uf

                BtnCorrigeCidade.PerformClick() ' Corrigir o nome da cidade sem acentos

                ' Buscar o nome correto da cidade na tabela BrasilMunicipios
                Dim cidadeCorrigida As String = CorrigirNomeCidade(EndCidadeTextBox.Text)

                ' Atualizar o campo com o nome corrigido, se encontrado
                If Not String.IsNullOrEmpty(cidadeCorrigida) Then
                    EndCidadeTextBox.Text = cidadeCorrigida
                End If

                BtnBuscaCEP.Text = "Preencher"
                BtnBuscaCEP.Enabled = True
            Else
                MessageBox.Show("CEP não encontrado.")
                BtnBuscaCEP.Enabled = True
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar informações de CEP: " & ex.Message)
        End Try
    End Sub


    Private Function CorrigirNomeCidade(nomeCidade As String) As String
        Dim cidadeCorrigida As String = nomeCidade ' Retorna o próprio nome caso não encontre

        ' Criar a conexão com o SQL Server
        Using conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False")
            Try
                conexao.Open()

                ' Consulta SQL usando collation acento-insensível e curingas
                Dim sql As String = "SELECT Nome FROM BrasilMunicipios WHERE Nome COLLATE Latin1_General_CI_AI LIKE @Cidade ORDER BY LEN(Nome) ASC"

                Using cmd As New SqlCommand(sql, conexao)
                    ' Adiciona curingas para permitir a busca parcial
                    cmd.Parameters.AddWithValue("@Cidade", "%" & nomeCidade & "%")

                    Dim resultado As Object = cmd.ExecuteScalar()
                    If resultado IsNot Nothing Then
                        cidadeCorrigida = resultado.ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao buscar nome da cidade: " & ex.Message)
            End Try
        End Using

        Return cidadeCorrigida
    End Function



    ' Função que converte a primeira letra de um texto para minúscula
    Private Function PrimeiraLetraMinuscula(texto As String) As String
        ' Verificar se o texto não está vazio
        If String.IsNullOrEmpty(texto) Then Return texto

        ' Converter a primeira letra para minúscula e manter o restante do texto inalterado
        Return Char.ToLower(texto(0)) & texto.Substring(1)
    End Function


    Private avisoExibido As Boolean = False

    Private Sub TabControle_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControle.Selecting
        ' Verifique se o índice da aba selecionada é 3 (PAGE4 é a quarta aba, então o índice é 3)
        If e.TabPageIndex = 3 Then
            ' Alternar para a aba correta
            TabControle.SelectTab(2)
            TabControle.SelectTab(3)

            ' Alterar texto do botão
            Try
                Dim protocoloREDESIM As String = If(ProtocoloREDESIMTextBox.Text?.Trim(), "")
                Dim protocoloJunta As String = If(ProtocoloJuntaComercialTextBox.Text?.Trim(), "")

                If Not String.IsNullOrEmpty(protocoloREDESIM) Then
                    BtnConsultaRedeSim.Text = "Consultar"
                ElseIf Not String.IsNullOrEmpty(protocoloJunta) Then
                    BtnConsultaRedeSim.Text = "Consultar"
                    ProtocoloREDESIMTextBox.Text = protocoloJunta
                Else
                    BtnConsultaRedeSim.Text = "Solicitar"
                End If

                ' Verificar se os protocolos são diferentes, ignorando valores vazios
                If Not String.IsNullOrEmpty(protocoloREDESIM) AndAlso
               Not String.IsNullOrEmpty(protocoloJunta) AndAlso
               protocoloREDESIM <> protocoloJunta AndAlso
               Not avisoExibido Then

                    MessageBox.Show("Atenção! Os protocolos são diferentes. Verifique!", "Protocolos Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    avisoExibido = True
                End If
            Catch ex As Exception
                MessageBox.Show("Erro! Verifique com o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            avisoExibido = False
        End If
    End Sub



    Private Sub LinkLabeLPrazoEmpresaFacil_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabeLPrazoEmpresaFacil.LinkClicked
        ' Extrair apenas a parte da data do texto
        Dim dataText As String = DataProtJuntaComercialMaskedTextBox.Text.Substring(0, 10)
        ' Verificar se a data extraída é válida
        Dim dataProt As DateTime
        If DateTime.TryParseExact(dataText, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataProt) Then
            ' Adicionar 90 dias à data
            Dim prazoFinal As DateTime = dataProt.AddDays(90)
            ' Exibir a mensagem com a data calculada
            MessageBox.Show("O processo Empresa Fácil é cancelado por inatividade, automaticamente, após 90 dias. Após esse período, cancelado o processo, o nome empresarial deverá passar por nova consulta prévia." & vbCrLf & vbCrLf & "Prazo Final = " & prazoFinal.ToString("dd/MM/yyyy"))
        Else
            ' Se a data não for válida, exibir uma mensagem de erro
            MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy HH:mm.")
        End If

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
            Dim url As String = "http://geoproc.maringa.pr.gov.br:8090/SIGMARINGA/" & cadastroImobiliario
            WebSiteGERAL.WebView.Source = New Uri(url)
        End If
    End Sub


    Private Sub BtnCopiaCEP_Click(sender As Object, e As EventArgs) Handles BtnCopiaCEP.Click
        Dim cep = New String(EndCEPMaskedTextBox.Text.Where(AddressOf Char.IsDigit).ToArray())
        If cep <> "" Then Clipboard.SetText(cep) Else MessageBox.Show("Nenhum CEP válido foi inserido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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


    Private Sub BtnGrauDeRisco_Click(sender As Object, e As EventArgs) Handles BtnGrauDeRisco.Click
        ArrumaCnae()
        ' Verificar se o formulário já está aberto
        If FrmCNAEescolha.Visible Then
            FrmCNAEescolha.Close()
            FrmCNAEescolha.Show()
        Else
            FrmCNAEescolha.Show()
        End If
    End Sub

    Private Sub ComboBoxBuscaEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBuscaEmpresa.SelectedIndexChanged
        VerificarFiliais()
    End Sub



    Private Sub BtnVerProcedimento_Click(sender As Object, e As EventArgs) Handles BtnVerProcedimento.Click
        ' Cria uma instância do FrmRichTextCompleto
        ' Passa a referência do ProcedimentoRichTextBox para o FrmRichTextCompleto
        Dim frmRichTextCompleto As New FrmRichTextCompleto With {
            .RichTextBoxOrigem = ProcedimentoRichTextBox
        }

        ' Preenche o RichTextBoxCompleto com o texto atual do ProcedimentoRichTextBox
        frmRichTextCompleto.RichTextBoxCompleto.Text = ProcedimentoRichTextBox.Text

        ' Exibe o FrmRichTextCompleto
        frmRichTextCompleto.ShowDialog()
    End Sub

    Private Sub BtnVerObsGeral_Click(sender As Object, e As EventArgs) Handles BtnVerObsGeral.Click
        ' Cria uma instância do FrmRichTextCompleto
        ' Passa a referência do GeralRichTextBox para o FrmRichTextCompleto
        Dim frmRichTextCompleto As New FrmRichTextCompleto With {
            .RichTextBoxOrigem = GeralRichTextBox
        }

        ' Preenche o RichTextBoxCompleto com o texto atual do GeralRichTextBox
        frmRichTextCompleto.RichTextBoxCompleto.Text = GeralRichTextBox.Text

        ' Exibe o FrmRichTextCompleto
        frmRichTextCompleto.ShowDialog()
    End Sub

    Private Sub BtnVerEmpresaFacil_Click(sender As Object, e As EventArgs) Handles BtnVerEmpresaFacil.Click
        'JuntaObsRichTextBox
        ' Cria uma instância do FrmRichTextCompleto
        ' Passa a referência do GeralRichTextBox para o FrmRichTextCompleto
        Dim frmRichTextCompleto As New FrmRichTextCompleto With {
            .RichTextBoxOrigem = JuntaObsRichTextBox
        }

        ' Preenche o RichTextBoxCompleto com o texto atual do GeralRichTextBox
        frmRichTextCompleto.RichTextBoxCompleto.Text = JuntaObsRichTextBox.Text

        ' Exibe o FrmRichTextCompleto
        frmRichTextCompleto.ShowDialog()
    End Sub

    Private Sub BtnVerFederal_Click(sender As Object, e As EventArgs) Handles BtnVerFederal.Click
        'RedeSimObsRichTextBox
        ' Passa a referência do GeralRichTextBox para o FrmRichTextCompleto
        Dim frmRichTextCompleto As New FrmRichTextCompleto With {
            .RichTextBoxOrigem = RedeSimObsRichTextBox()
        }

        ' Preenche o RichTextBoxCompleto com o texto atual do GeralRichTextBox
        frmRichTextCompleto.RichTextBoxCompleto.Text = RedeSimObsRichTextBox.Text

        ' Exibe o FrmRichTextCompleto
        frmRichTextCompleto.ShowDialog()
    End Sub

    Private Sub BtnVerNovoNome_Click(sender As Object, e As EventArgs) Handles BtnVerNovoNome.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(7)
    End Sub

    Private Sub SituacaoCadastralComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SituacaoCadastralComboBox.SelectedIndexChanged
        Select Case SituacaoCadastralComboBox.Text
            Case "ATIVO"
                SituacaoCadastralComboBox.BackColor = Color.DarkGreen
                SituacaoCadastralComboBox.ForeColor = Color.White
            Case "BAIXADA"
                SituacaoCadastralComboBox.BackColor = Color.DarkRed
                SituacaoCadastralComboBox.ForeColor = Color.White
            Case "INAPTA"
                SituacaoCadastralComboBox.BackColor = Color.Yellow
                SituacaoCadastralComboBox.ForeColor = Color.Black
            Case Else
                ' Caso padrão para outras situações
                SituacaoCadastralComboBox.BackColor = SystemColors.Window
                SituacaoCadastralComboBox.ForeColor = SystemColors.WindowText
        End Select
    End Sub

    Private registroCopiado As DataRow = Nothing

    Private Sub BtnCopiarRegistroEmpresa_Click(sender As Object, e As EventArgs) Handles BtnCopiarRegistroEmpresa.Click
        Try
            ' Verificar se há um registro selecionado
            If Me.EmpresasBindingSource.Current Is Nothing Then
                MessageBox.Show("Nenhum registro selecionado para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Confirmar se deseja criar um novo registro
            Dim resultado = MessageBox.Show("Deseja copiar o registro atual e criar um novo?",
                                        "Copiar Registro",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' Obter o registro atual da fonte de dados
                Dim registroAtual As DataRowView = CType(Me.EmpresasBindingSource.Current, DataRowView)
                Dim novaLinha As DataRow = PrinceDBDataSet.Empresas.NewRow()

                ' Copiar os dados do registro atual para a nova linha
                For Each column As DataColumn In PrinceDBDataSet.Empresas.Columns
                    If column.ColumnName <> "ID_Empresas" Then
                        novaLinha(column.ColumnName) = registroAtual(column.ColumnName)
                    End If
                Next

                ' Adicionar a nova linha à tabela
                PrinceDBDataSet.Empresas.Rows.Add(novaLinha)

                ' Posicionar no novo registro
                Me.EmpresasBindingSource.Position = Me.EmpresasBindingSource.Count - 1

                ' Perguntar ao usuário o novo CNPJ
                Dim novoCNPJ As String = InputBox("Digite o novo CNPJ para a filial:", "Novo CNPJ", "")

                If Not String.IsNullOrWhiteSpace(novoCNPJ) Then
                    novaLinha("CNPJ") = novoCNPJ
                End If

                ' Chamar o método Salvar
                Salvar()

                MessageBox.Show("Novo registro criado e salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao copiar o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDataProtFedDBE_Click(sender As Object, e As EventArgs) Handles BtnDataProtFedDBE.Click
        DBEDataMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()

    End Sub

    Private Sub BtnLimparRedeSimProt_Click(sender As Object, e As EventArgs) Handles BtnLimparRedeSimProt.Click
        Try
            If MsgBox("Deseja limpar o protocolo na Redesim/Federal?", MsgBoxStyle.YesNo, "Limpar") = MsgBoxResult.Yes Then
                DBEProtocoloTextBox.Clear()
                FederalProtocoloTextBox.Clear()
                DBEDataMaskedTextBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao Limpar!" & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnArrumaEnd_Click(sender As Object, e As EventArgs) Handles BtnArrumaEnd.Click
        Try
            ' Obter os valores dos TextBoxes
            Dim Endereco As String = EnderecoTextBox.Text
            Dim Numero As String = EndNumeroTextBox.Text
            Dim Complemento As String = EndComplementoTextBox.Text
            Dim Bairro As String = EndBairroTextBox.Text
            Dim CEP As String = EndCEPMaskedTextBox.Text
            Dim Cidade As String = EndCidadeTextBox.Text
            Dim UF As String = EndEstadoTextBox.Text

            ' Formatar cada parte do endereço com a primeira letra das palavras em maiúscula
            ' Para o endereço, vamos manter a primeira letra minúscula
            Endereco = FormatarEnderecoComPrimeiraLetraMinuscula(Endereco)

            ' Formatar as outras partes normalmente
            Bairro = FormatTexto(Bairro)
            Cidade = FormatTexto(Cidade)
            Complemento = FormatTexto(Complemento) ' Formatar complemento se não estiver vazio

            ' Atualizar os TextBoxes com os valores formatados
            EnderecoTextBox.Text = Endereco
            EndBairroTextBox.Text = Bairro
            EndCidadeTextBox.Text = Cidade
            EndCEPMaskedTextBox.Text = CEP ' O CEP não requer formatação adicional
            EndEstadoTextBox.Text = UF ' O UF não requer formatação adicional

            ' Formatar o complemento e o número, se existirem, e atualizar
            If Not String.IsNullOrWhiteSpace(Numero) Then
                EndNumeroTextBox.Text = Numero.Trim()
            End If

            If Not String.IsNullOrWhiteSpace(Complemento) Then
                EndComplementoTextBox.Text = Complemento.Trim()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao Formatar endereço!" & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Função que formata o endereço mantendo a primeira letra minúscula e as palavras seguintes em maiúsculas
    Private Function FormatarEnderecoComPrimeiraLetraMinuscula(endereco As String) As String
        Try
            ' Transformar todas as palavras em minúsculas
            Dim palavras As String() = endereco.ToLower().Split(" "c)

            ' Formatar cada palavra com inicial maiúscula, exceto a primeira palavra
            For i As Integer = 1 To palavras.Length - 1
                If palavras(i).Length > 0 Then ' Verifica se a palavra não está vazia antes de acessar o índice
                    palavras(i) = Char.ToUpper(palavras(i)(0)) & palavras(i).Substring(1)
                End If
            Next

            ' Reunir as palavras em uma única string com a primeira palavra em minúscula
            Return String.Join(" ", palavras)
        Catch ex As Exception
            MessageBox.Show("Erro ao formatar o endereço mantendo a primeira letra minúscula e as palavras seguintes em maiúsculas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Retornar uma string vazia ou o valor original em caso de erro
            Return endereco ' ou Return String.Empty
        End Try
    End Function


    ' Função para formatar a primeira letra de cada palavra como maiúscula (exceto palavras comuns)
    Private Function FormatTexto(texto As String) As String
        Try
            ' Converter o texto para minúsculas e depois formatar as iniciais
            Dim palavrasComuns As String() = {"de", "do", "da", "dos", "das"} ' Palavras que não devem ter a inicial maiúscula
            Dim palavras As String() = texto.ToLower().Split(" "c) ' Dividir o texto em palavras
            For i As Integer = 0 To palavras.Length - 1
                If palavras(i).Length > 0 AndAlso Not palavrasComuns.Contains(palavras(i)) Then ' Verifica se a palavra não está vazia
                    palavras(i) = Char.ToUpper(palavras(i)(0)) & palavras(i).Substring(1) ' Capitalizar a primeira letra
                End If
            Next
            Return String.Join(" ", palavras) ' Reunir as palavras novamente em uma única string
        Catch ex As Exception
            MessageBox.Show("Erro ao formatar a primeira letra de cada palavra como maiúscula (exceto palavras comuns): " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Retornar o valor original ou uma string vazia em caso de erro
            Return texto ' ou Return String.Empty
        End Try
    End Function


    '/////////////////////////////////////////////////////////////////////


    Private Sub BtnCopiarCapital_Click(sender As Object, e As EventArgs) Handles BtnCopiarCapital.Click
        ' Obtém os valores dos TextBox
        Dim capitalString As String = CapitalSTextBox.Text
        Dim quotaString As String = CapitaQuotaTotalTextBox.Text ' Valor total de quotas
        Dim quotaValorString As String = CapitalQuotaValorTextBox.Text ' Valor nominal das quotas

        ' Extraindo os valores numéricos
        Dim capitalValor As Decimal = ExtractNumericValue(capitalString)
        Dim quotaTotal As Decimal = ExtractNumericValue(quotaString)
        Dim quotaValor As Decimal = ExtractNumericValue(quotaValorString)

        ' Convertendo para texto por extenso com moeda
        Dim capitalExtenso As String = NumberToWordsWithCurrency(capitalValor)
        Dim quotaExtenso As String = NumberToWords(quotaTotal) ' Extenso do número de quotas, sem unidade de moeda
        Dim quotaValorExtenso As String = NumberToWordsWithCurrency(quotaValor) ' Extenso com unidade monetária

        ' Verifica se o CapitalAntigoMudouCheckBox está marcado
        If CapitalAntigoMudouComboBox.Text = "Sim" Then
            ' Se o capital mudou, incluir a informação do capital antigo
            Dim capitalAntigoString As String = CapitalSocialAntigoTextBox.Text
            Dim capitalAntigoValor As Decimal = ExtractNumericValue(capitalAntigoString)
            Dim capitalAntigoExtenso As String = NumberToWordsWithCurrency(capitalAntigoValor)

            ' Remover o símbolo de reais do capital antigo para a parte "dividido em"
            Dim capitalAntigoSemMoeda As String = capitalAntigoValor.ToString("N2")

            ' Montagem do texto com capital antigo e o novo
            Dim resultado As String = $"O capital social era de {capitalAntigoString} ({capitalAntigoExtenso}), " &
                              $"dividido em {capitalAntigoSemMoeda} quotas de valor nominal {quotaValorString} ({quotaValorExtenso}), " &
                              $"foi aumentado para {capitalString} ({capitalExtenso}), " &
                              $"dividido em {quotaString} ({quotaExtenso}) quotas de valor nominal {quotaValorString} ({quotaValorExtenso})"

            ' Exibir o resultado e copiar para a área de transferência
            MessageBox.Show(resultado)
            My.Computer.Clipboard.SetText(resultado)
        Else
            ' Montagem do texto normal sem capital antigo
            Dim resultado As String = $"O capital social será {capitalString} ({capitalExtenso}) " &
                              $"dividido em {quotaString} ({quotaExtenso}) quotas de valor nominal " &
                              $"{quotaValorString} ({quotaValorExtenso})"

            ' Exibir o resultado e copiar para a área de transferência
            MessageBox.Show(resultado)
            My.Computer.Clipboard.SetText(resultado)
        End If
    End Sub



    ' Função para extrair o valor numérico de uma string com formato de moeda
    Private Function ExtractNumericValue(moeda As String) As Decimal
        ' Remover o símbolo da moeda e formatar o número para Decimal
        Dim valor As String = moeda.Replace("R$", "").Trim().Replace(".", "").Replace(",", ".")
        Return Decimal.Parse(valor, CultureInfo.InvariantCulture)
    End Function

    ' Função para converter números em texto por extenso com unidade monetária
    Private Function NumberToWordsWithCurrency(value As Decimal) As String
        Dim inteiro As Long = CLng(Math.Floor(value))
        Dim valorExtenso As String = NumberToWords(inteiro)

        ' Se o valor inteiro for 1, usar "real", caso contrário, "reais"
        Dim unidadeMonetaria As String = If(inteiro = 1, "real", "reais")

        ' Adicionar extenso de centavos, se houver
        Dim centavos As Long = CLng((value - inteiro) * 100)
        If centavos > 0 Then
            valorExtenso &= $" e {NumberToWords(centavos)} centavos"
        End If

        Return valorExtenso & $" {unidadeMonetaria}"
    End Function

    ' Função para converter números em texto por extenso
    Private Function NumberToWords(value As Decimal) As String
        Dim unidades As String() = {"", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove"}
        Dim dezenas As String() = {"", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa"}
        Dim especiais As String() = {"dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove"}
        Dim centenas As String() = {"", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos"}

        If value = 0 Then Return "zero"

        Dim inteiro As Long = CLng(Math.Floor(value))
        Dim partes As New List(Of String)

        ' Processar milhões
        If inteiro >= 1000000 Then
            Dim milhoes As Long = inteiro \ 1000000
            partes.Add(If(milhoes = 1, "um milhão", NumberToWords(milhoes) & " milhões"))
            inteiro -= milhoes * 1000000
        End If

        ' Processar milhares
        If inteiro >= 1000 Then
            Dim milhar As Long = inteiro \ 1000
            If milhar = 1 Then
                partes.Add("mil")
            Else
                partes.Add(NumberToWords(milhar) & " mil")
            End If
            inteiro -= milhar * 1000
        End If

        ' Processar centenas
        If inteiro >= 100 Then
            Dim centena As Long = inteiro \ 100
            If centena = 1 AndAlso inteiro Mod 100 = 0 Then
                partes.Add("cem")
            Else
                partes.Add(centenas(centena))
            End If
            inteiro -= centena * 100
        End If

        ' Processar dezenas e unidades
        If inteiro >= 20 Then
            partes.Add(dezenas(inteiro \ 10))
            inteiro -= (inteiro \ 10) * 10
        ElseIf inteiro >= 10 Then
            partes.Add(especiais(inteiro - 10))
            inteiro = 0
        End If

        ' Processar unidades
        If inteiro > 0 Then
            partes.Add(unidades(inteiro))
        End If

        ' Construção final garantindo a separação correta com "e"
        Dim resultado As String

        If partes.Count = 1 Then
            resultado = partes(0)
        Else
            resultado = String.Join(" e ", partes)
        End If

        Return resultado.Trim()
    End Function




    ' //////////////////// FIM CAPITAL SOCIAL 
    Private Sub CNAESecundarioRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles CNAESecundarioRichTextBox.TextChanged
        ' Conta as linhas dividindo o texto por quebras de linha (cobrindo todos os tipos de delimitadores)
        Dim linhas As Integer = CNAESecundarioRichTextBox.Text.Split({vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries).Length

        ' Verifica se há linhas e atualiza o Label com o total de linhas
        LblTotalCnae.Text = If(linhas > 0, linhas.ToString(), "0") & " -"
    End Sub




    Private Sub BtnCopiarPRP_Click(sender As Object, e As EventArgs) Handles BtnCopiarPRP.Click
        ' Verifica se o campo ProtocoloJuntaComercialTextBox não está vazio
        If Not String.IsNullOrEmpty(ProtocoloJuntaComercialTextBox.Text) Then
            ' Copia o conteúdo do TextBox para a área de transferência
            Clipboard.SetText(ProtocoloJuntaComercialTextBox.Text)

            ' Exibe uma mensagem informando que o texto foi copiado com sucesso
            'MessageBox.Show("Texto copiado para a área de transferência!", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Exibe uma mensagem de alerta caso o campo esteja vazio
            MessageBox.Show("O campo Protocolo Junta Comercial está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub BtnCopiarREDESIM_Click(sender As Object, e As EventArgs) Handles BtnCopiarREDESIM.Click
        ' Copia o conteúdo de ProtocoloREDESIMTextBox para a área de transferência
        If Not String.IsNullOrEmpty(ProtocoloREDESIMTextBox.Text) Then
            Clipboard.SetText(ProtocoloREDESIMTextBox.Text)
            ' MessageBox.Show("Texto copiado para a área de transferência!", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("O campo Protocolo REDESIM está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function RemoverCaracteresInvisiveis(texto As String) As String
        ' Normaliza o texto para remover combinações de caracteres
        Dim normalizedString As String = texto.Normalize(NormalizationForm.FormD)

        ' Filtra os caracteres invisíveis (caracteres de controle e outros não imprimíveis)
        Dim resultado As New StringBuilder()

        For Each c As Char In normalizedString
            ' Adiciona o caractere ao resultado se não for um caractere de controle
            If Not Char.IsControl(c) Then
                resultado.Append(c)
            End If
        Next

        ' Retorna o texto com os caracteres invisíveis removidos, mantendo os outros
        Return resultado.ToString().ToUpper()
    End Function


    Private Sub RazaoSocialAntigaTextBox_TextChanged(sender As Object, e As EventArgs) Handles RazaoSocialAntigaTextBox.TextChanged
        '  RazaoSocialAntigaTextBox.Text = RemoverCaracteresInvisiveis(RazaoSocialAntigaTextBox.Text)
        ' RazaoSocialAntigaTextBox.SelectionStart = RazaoSocialAntigaTextBox.Text.Length ' Manter o cursor no final
    End Sub

    Private Sub NovaRazaoSocial1TextBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocial1TextBox.TextChanged
        'NovaRazaoSocial1TextBox.Text = RemoverCaracteresInvisiveis(NovaRazaoSocial1TextBox.Text)
        '  NovaRazaoSocial1TextBox.SelectionStart = NovaRazaoSocial1TextBox.Text.Length
    End Sub

    Private Sub NovaRazaoSocial2TextBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocial2TextBox.TextChanged
        ' NovaRazaoSocial2TextBox.Text = RemoverCaracteresInvisiveis(NovaRazaoSocial2TextBox.Text)
        ' NovaRazaoSocial2TextBox.SelectionStart = NovaRazaoSocial2TextBox.Text.Length
    End Sub

    Private Sub NovaRazaoSocial3TextBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocial3TextBox.TextChanged
        'NovaRazaoSocial3TextBox.Text = RemoverCaracteresInvisiveis(NovaRazaoSocial3TextBox.Text)
        ' NovaRazaoSocial3TextBox.SelectionStart = NovaRazaoSocial3TextBox.Text.Length
    End Sub

    Private Sub NomeFantasiaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NomeFantasiaTextBox1.TextChanged
        ' NomeFantasiaTextBox1.Text = RemoverCaracteresInvisiveis(NomeFantasiaTextBox1.Text)
        ' NomeFantasiaTextBox1.SelectionStart = NomeFantasiaTextBox1.Text.Length
    End Sub

    Private Sub NovaRazaoSocialFinalTextBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialFinalTextBox.TextChanged
        ' NovaRazaoSocialFinalTextBox.Text = RemoverCaracteresInvisiveis(NovaRazaoSocialFinalTextBox.Text)
        '  NovaRazaoSocialFinalTextBox.SelectionStart = NovaRazaoSocialFinalTextBox.Text.Length
    End Sub

    Private Sub RamoDeAtividadeRichTextBox_TextChanged(sender As Object, e As EventArgs)
        ' Contar o número de caracteres no RichTextBox
        Dim totalCaracteres As Integer = RamoDeAtividadeRichTextBox.Text.Length

        ' Exibir o total de caracteres no label
        LblContagemRamo.Text = "Total: " & totalCaracteres.ToString() & " / 7000" & " caracteres."

        ' Verificar se o número de caracteres excede 7000
        If totalCaracteres > 7000 Then
            ' Mudar a cor do texto do label para vermelho
            LblContagemRamo.ForeColor = Color.Red
        Else
            ' Caso contrário, manter a cor do texto preta
            LblContagemRamo.ForeColor = Color.Black
        End If
    End Sub


    '////////////////////////// ARRUMAR CNAE PRINCIPAL E SECUNDARIO'


    Public Sub ArrumaCNAEPrincipal()
        ' Remove espaços extras
        Dim cnae As String = CNAEPrincipalTextBox.Text.Trim()

        ' Verifica se já está formatado corretamente (no padrão XXXX-X/XX)
        If Not System.Text.RegularExpressions.Regex.IsMatch(cnae, "^\d{4}-\d/\d{2}$") Then
            ' Remove todos os caracteres que não são números
            cnae = New String(cnae.Where(AddressOf Char.IsDigit).ToArray())

            ' Verifica se o CNAE tem pelo menos 7 dígitos
            If cnae.Length >= 7 Then
                ' Aplica o formato XXXX-X/XX
                Dim cnaeFormatado As String = cnae.Substring(0, 4) & "-" & cnae.Substring(4, 1) & "/" & cnae.Substring(5, 2)

                ' Atualiza o TextBox com o CNAE formatado
                CNAEPrincipalTextBox.Text = cnaeFormatado
            End If
        End If
    End Sub


    Public Sub ArrumaCNAESecundario()
        ' Divide o texto por linhas
        Dim cnaes As String() = CNAESecundarioRichTextBox.Text.Split({vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)

        ' Variável para armazenar os CNAEs formatados
        Dim cnaesFormatados As New List(Of String)

        ' Loop para formatar cada linha
        For Each cnae In cnaes
            ' Remove espaços extras
            cnae = cnae.Trim()

            ' Verifica se já está formatado corretamente (no padrão XXXX-X/XX)
            If Not System.Text.RegularExpressions.Regex.IsMatch(cnae, "^\d{4}-\d/\d{2}$") Then
                ' Remove todos os caracteres que não são números
                cnae = New String(cnae.Where(AddressOf Char.IsDigit).ToArray())

                ' Verifica se o CNAE tem pelo menos 7 dígitos
                If cnae.Length >= 7 Then
                    ' Aplica o formato XXXX-X/XX
                    Dim cnaeFormatado As String = cnae.Substring(0, 4) & "-" & cnae.Substring(4, 1) & "/" & cnae.Substring(5, 2)
                    cnaesFormatados.Add(cnaeFormatado)
                Else
                    ' Se o CNAE for inválido, simplesmente adiciona o texto sem formatação
                    cnaesFormatados.Add(cnae)
                End If
            Else
                ' Se já estiver formatado corretamente, apenas adiciona
                cnaesFormatados.Add(cnae)
            End If
        Next

        ' Atualiza o conteúdo do RichTextBox com os CNAEs formatados
        CNAESecundarioRichTextBox.Text = String.Join(Environment.NewLine, cnaesFormatados)

        ' Atualiza o Label com o total de linhas (CNAEs)
        LblTotalCnae.Text = cnaesFormatados.Count.ToString()
    End Sub

    Private Sub LblLinkArrumarCNAE_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLinkArrumarCNAE.LinkClicked
        ArrumaCnae()
    End Sub

    Private Sub ArrumaCnae()
        ' Limpar caracteres e formatar o CNAEPrincipalTextBox
        If CNAEPrincipalTextBox.Text.Length >= 7 Then
            Dim cnaePrincipal As String = CNAEPrincipalTextBox.Text
            ' Manter apenas números e formatar como XXXX-X/XX
            cnaePrincipal = New String(cnaePrincipal.Where(Function(c) Char.IsDigit(c)).ToArray())
            If cnaePrincipal.Length = 7 Then
                CNAEPrincipalTextBox.Text = cnaePrincipal.Substring(0, 4) & "-" & cnaePrincipal.Substring(4, 1) & "/" & cnaePrincipal.Substring(5, 2)
            Else
                MessageBox.Show("CNAE Principal inválido. Deve conter 7 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        ' Verificar linha por linha no CNAESecundarioRichTextBox
        Dim linhasSecundarias As String() = CNAESecundarioRichTextBox.Lines
        Dim cnaesFormatados As New List(Of String)

        For Each linha As String In linhasSecundarias
            ' Manter apenas números e formatar como XXXX-X/XX
            Dim cnaeSecundario As New String(linha.Where(Function(c) Char.IsDigit(c)).ToArray())
            If cnaeSecundario.Length = 7 Then
                cnaesFormatados.Add(cnaeSecundario.Substring(0, 4) & "-" & cnaeSecundario.Substring(4, 1) & "/" & cnaeSecundario.Substring(5, 2))
            ElseIf Not String.IsNullOrWhiteSpace(linha) Then
                MessageBox.Show($"CNAE Secundário inválido: {linha}. Deve conter 7 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next

        ' Atualizar o conteúdo do CNAESecundarioRichTextBox com os CNAEs formatados
        CNAESecundarioRichTextBox.Lines = cnaesFormatados.ToArray()
    End Sub

    '////////////////////////// FIM ARRUMAR CNAE PRINCIPAL E SECUNDARIO



    Private Sub BtnCopiarCapitalFinal_Click(sender As Object, e As EventArgs) Handles BtnCopiarCapitalFinal.Click
        ' Obtém os valores dos TextBox
        Dim capitalString As String = CapitalSTextBox.Text
        Dim quotaString As String = CapitaQuotaTotalTextBox.Text ' Valor total de quotas
        Dim quotaValorString As String = CapitalQuotaValorTextBox.Text ' Valor nominal das quotas

        ' Extraindo os valores numéricos
        Dim capitalValor As Decimal = ExtractNumericValue(capitalString)
        Dim quotaTotal As Decimal = ExtractNumericValue(quotaString)
        Dim quotaValor As Decimal = ExtractNumericValue(quotaValorString)

        ' Convertendo para texto por extenso com moeda
        Dim capitalExtenso As String = NumberToWordsWithCurrency(capitalValor)
        Dim quotaExtenso As String = NumberToWords(quotaTotal) ' Extenso do número de quotas, sem unidade de moeda
        Dim quotaValorExtenso As String = NumberToWordsWithCurrency(quotaValor) ' Extenso com unidade monetária

        ' Verifica se o CapitalAntigoMudouCheckBox está marcado

        ' Montagem do texto normal sem capital antigo
        Dim resultado As String = $"O capital social será {capitalString} ({capitalExtenso}) " &
                              $"dividido em {quotaString} ({quotaExtenso}) quotas de valor nominal " &
                              $"{quotaValorString} ({quotaValorExtenso})"

        ' Exibir o resultado e copiar para a área de transferência
        MessageBox.Show(resultado)
        My.Computer.Clipboard.SetText(resultado)

    End Sub

    Private Sub BtnVerDescricaoCNAE_Click(sender As Object, e As EventArgs) Handles BtnVerDescricaoCNAE.Click
        ArrumaCnae()

        If Application.OpenForms.OfType(Of FrmCNAEtexto)().Count() > 0 Then
            FrmCNAEtexto.Focus()
        Else
            FrmCNAEtexto.Show()
        End If
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        ' Verificar se a aba selecionada é a de índice 5
        If TabControl2.SelectedIndex = 5 Then
            ' Verificar se o CapitalAntigoMudouComboBox está vazio
            If String.IsNullOrWhiteSpace(CapitalAntigoMudouComboBox.Text) Then
                ' Alterar a seleção para o item de índice 1 do ComboBox
                CapitalAntigoMudouComboBox.SelectedText = "Não"
            End If
        End If
    End Sub
    Private Sub LinkLabelLimparRamo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLimparRamo.LinkClicked
        ' Perguntar ao usuário se deseja limpar o RamoDeAtividadeRichTextBox
        Dim resultado As DialogResult = MessageBox.Show("Deseja limpar o conteúdo do campo Ramo de Atividade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Se o usuário escolher "Sim", limpar o RamoDeAtividadeRichTextBox
        If resultado = DialogResult.Yes Then
            RamoDeAtividadeRichTextBox.Clear()
        End If
    End Sub


    Private Sub PontoDeReferenciaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PontoDeReferenciaComboBox.SelectedIndexChanged
        ' Verifica o texto selecionado no ComboBox
        If PontoDeReferenciaComboBox.Text = "Sim" Then
            ' Define a cor de fundo como verde e a cor do texto como branco
            PontoDeReferenciaComboBox.BackColor = Color.Green
            PontoDeReferenciaComboBox.ForeColor = Color.White
        ElseIf PontoDeReferenciaComboBox.Text = "Não" Then
            ' Define a cor de fundo como vermelho e a cor do texto como branco
            PontoDeReferenciaComboBox.BackColor = Color.Red
            PontoDeReferenciaComboBox.ForeColor = Color.Black
        Else
            ' Redefine para as cores padrão quando não for "Sim" ou "Não"
            PontoDeReferenciaComboBox.BackColor = SystemColors.Window
            PontoDeReferenciaComboBox.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub CapitalAntigoMudouComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CapitalAntigoMudouComboBox.SelectedIndexChanged
        If CapitalAntigoMudouComboBox.Text = "" Then
            ' Define o estado como Unchecked
            CapitalAntigoMudouComboBox.Text = "Sim"
        End If

        ' Verifica se o checkbox está marcado
        If CapitalAntigoMudouComboBox.Text = "Sim" Then
            ' Se marcado, torna os controles visíveis
            CapitalSocialAntigoLabel.Visible = True
            CapitalSocialAntigoTextBox.Visible = True
            BtnCopiarCapitalFinal.Visible = True
        Else
            ' Se desmarcado, oculta os controles
            CapitalSocialAntigoLabel.Visible = False
            CapitalSocialAntigoTextBox.Visible = False
            BtnCopiarCapitalFinal.Visible = False
        End If
    End Sub

    Private Sub CNAEAtividadeNoLocalComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CNAEAtividadeNoLocalComboBox.SelectedIndexChanged
        ' Verifica o texto selecionado no ComboBox
        If CNAEAtividadeNoLocalComboBox.Text = "Todos" Or CNAEAtividadeNoLocalComboBox.Text = "Parcial" Then
            ' Define a cor de fundo como verde e a cor do texto como branco
            CNAEAtividadeNoLocalComboBox.BackColor = Color.Green
            CNAEAtividadeNoLocalComboBox.ForeColor = Color.White
        ElseIf CNAEAtividadeNoLocalComboBox.Text = "Não" Then
            ' Define a cor de fundo como vermelho e a cor do texto como branco
            CNAEAtividadeNoLocalComboBox.BackColor = Color.Red
            CNAEAtividadeNoLocalComboBox.ForeColor = Color.Black
        Else
            ' Redefine para as cores padrão quando não for "Sim" ou "Não"
            CNAEAtividadeNoLocalComboBox.BackColor = SystemColors.Window
            CNAEAtividadeNoLocalComboBox.ForeColor = SystemColors.WindowText
        End If
    End Sub

    ' Variável para manter uma referência do formulário DialogAjudaObjetoEmpresa
    Private dialogAjuda As DialogAjudaObjetoEmpresa = Nothing

    Private Sub BtnAjudaRamoObjeto_Click(sender As Object, e As EventArgs) Handles BtnAjudaRamoObjeto1.Click, BtnAjudaRamoObjeto2.Click
        ' Verifica se o formulário já está aberto
        If dialogAjuda IsNot Nothing AndAlso dialogAjuda.Visible Then
            ' Se o formulário já estiver aberto, apenas traz para o foco
            dialogAjuda.Focus()
        Else
            ' Caso contrário, cria uma nova instância e exibe como diálogo
            dialogAjuda = New DialogAjudaObjetoEmpresa()
            dialogAjuda.ShowDialog()
            dialogAjuda = Nothing  ' Limpa a referência após o formulário ser fechado
        End If
    End Sub

    Private Sub LinkLabelCopiarRamo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopiarRamo.LinkClicked
        ObjetoDOEstabelecimentoRichTextBox.Text = RamoDeAtividadeRichTextBox.Text
    End Sub

    '/////////// ARRUMA ENDEREÇO ///////
    Private Sub EndBairroTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndBairroTextBox.TextChanged
        EndBairroTextBox.Text = StrConv(EndBairroTextBox.Text, VbStrConv.ProperCase)
        EndBairroTextBox.SelectionStart = EndBairroTextBox.Text.Length
    End Sub

    Private Sub EndComplementoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndComplementoTextBox.TextChanged
        EndComplementoTextBox.Text = StrConv(EndComplementoTextBox.Text, VbStrConv.ProperCase)
        EndComplementoTextBox.SelectionStart = EndComplementoTextBox.Text.Length
    End Sub

    Private Sub EndCidadeTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndCidadeTextBox.TextChanged
        EndCidadeTextBox.Text = StrConv(EndCidadeTextBox.Text, VbStrConv.ProperCase)
        EndCidadeTextBox.SelectionStart = EndCidadeTextBox.Text.Length

        If EndCidadeLabel2.Text = "" Then 'EndEstadoLabel2
            EndCidadeLabel2.Text = EndCidadeTextBox.Text
        End If
    End Sub

    ' Evento TextChanged para converter o conteúdo para maiúsculas e definir o país como Brasil
    Private Sub EndEstadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EndEstadoTextBox.TextChanged
        ' Lista de estados brasileiros
        Dim estadosBrasileiros As New List(Of String) From {
        "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS",
        "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC",
        "SP", "SE", "TO"
    }

        ' Converte o texto para maiúsculas
        EndEstadoTextBox.Text = EndEstadoTextBox.Text.ToUpper()
        EndEstadoTextBox.SelectionStart = EndEstadoTextBox.Text.Length ' Mantém o cursor no final do texto

        ' Verifica se o estado é brasileiro
        If estadosBrasileiros.Contains(EndEstadoTextBox.Text) Then
            EndPaisTextBox.Text = "Brasil"
        Else
            EndPaisTextBox.Clear() ' Limpa o campo se o estado não for válido
        End If

        If EndEstadoLabel2.Text = "" Then 'EndEstadoLabel2
            EndEstadoLabel2.Text = EndEstadoTextBox.Text
        End If
    End Sub
    '/////////////////////////////////
    Private Sub NomeFantasiaTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomeFantasiaTextBox.TextChanged

        ' Converte o texto para maiúsculas
        NomeFantasiaTextBox.Text = StrConv(NomeFantasiaTextBox.Text, VbStrConv.ProperCase)
        NomeFantasiaTextBox.SelectionStart = NomeFantasiaTextBox.Text.Length
    End Sub

    Private Sub BtnAtividadeLocal_Click(sender As Object, e As EventArgs) Handles BtnAtividadeLocal.Click
        TabControl2.SelectedIndex = 8
    End Sub


    '//////////////////////////////////////


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

    Private Sub SimplesEcacComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SimplesEcacComboBox.SelectedIndexChanged
        If SimplesEcacComboBox.Text = "eCAC" Then
            GroupBoxSimples.Visible = False
        Else
            GroupBoxSimples.Visible = True
        End If
    End Sub
    Private Sub BtnCopiarEmail_Click(sender As Object, e As EventArgs) Handles BtnCopiarEmail.Click
        ' Verifica se o campo de email não está vazio
        If Not String.IsNullOrEmpty(EmpEmailTextBox.Text) Then
            ' Copia o conteúdo do TextBox para a área de transferência
            Clipboard.SetText(EmpEmailTextBox.Text)

            ' Exibe uma mensagem informando que o email foi copiado
            '   MessageBox.Show("Email copiado para a área de transferência!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Exibe uma mensagem caso o campo esteja vazio
            MessageBox.Show("O campo de email está vazio. Não foi possível copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub AvisarEmpresaCheckBox_Click(sender As Object, e As EventArgs) Handles AvisarEmpresaCheckBox.Click
        TabControle.SelectTab(10)

    End Sub
    Private Sub VerificarAvisoEmpresa()
        Try
            ' Verifica o estado atual do CheckBox
            If AvisarEmpresaCheckBox.CheckState = CheckState.Indeterminate Then
                ' Define como não marcado (Unchecked) se estiver no estado indeterminado (valor nulo no banco)
                AvisarEmpresaCheckBox.CheckState = CheckState.Unchecked
            End If

            ' Se o checkbox estiver marcado, exibe o alerta
            If AvisarEmpresaCheckBox.CheckState = CheckState.Checked Then
                ' Seleciona a aba correspondente no TabControl
                TabControle.SelectTab(10)
                ' Exibe o alerta com o texto do campo AvisarEmpresaTextoRichTextBox
                Dim mensagemAlerta As String = AvisarEmpresaTextoRichTextBox.Text
                MessageBox.Show(mensagemAlerta, "Aviso da Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                BtnVerAviso.Visible = True
            Else
                BtnVerAviso.Visible = False
            End If
        Catch ex As Exception
            ' Tratar erros para evitar falhas
            MessageBox.Show("Erro ao verificar o aviso da empresa." & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub BtnLimpaAviso_Click(sender As Object, e As EventArgs) Handles BtnLimpaAviso.Click
        Try
            ' Exibe uma mensagem de confirmação
            Dim resposta As DialogResult = MessageBox.Show("Deseja realmente limpar todo o aviso?",
                                                           "Confirmação",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question)
            ' Verifica a resposta do usuário
            If resposta = DialogResult.Yes Then
                ' Limpa o conteúdo do AvisarEmpresaTextoRichTextBox
                AvisarEmpresaTextoRichTextBox.Clear()

                ' Exibe mensagem de confirmação de limpeza
                MessageBox.Show("O aviso foi limpo com sucesso.",
                                "Confirmação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Dim MarcaAviso As DialogResult = MessageBox.Show("Deseja desativar o AVISO ?",
                                                           "Confirmação",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question)
                If MarcaAviso = DialogResult.Yes Then
                    AvisarEmpresaCheckBox.CheckState = CheckState.Unchecked

                End If

            End If
        Catch ex As Exception
            ' Trata possíveis erros
            MessageBox.Show("Erro ao tentar limpar o aviso." & vbCrLf & ex.Message,
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCopiarNIRE_Click(sender As Object, e As EventArgs) Handles BtnCopiarNIRE.Click
        ' Copia o conteúdo de ProtocoloJuntaComercialTextBox para a área de transferência
        If Not String.IsNullOrEmpty(NIRETextBox.Text) Then
            Clipboard.SetText(NIRETextBox.Text)
        Else
            MessageBox.Show("O campo NIRE Junta Comercial está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnCopiarDataNire_Click(sender As Object, e As EventArgs) Handles BtnCopiarDataNire.Click
        ' Verifica se o campo contém uma data válida
        Dim dataTexto As String = NireDataMaskedTextBox.Text
        Dim data As DateTime

        If DateTime.TryParse(dataTexto, data) Then
            ' Converte a data para o formato por extenso e transforma em minúsculas
            Dim dataPorExtenso As String = $"{data.Day} de {data:MMMM} de {data:yyyy}".ToLower()

            ' Copia o texto para a área de transferência
            Clipboard.SetText(dataPorExtenso)
        Else
            ' Exibe mensagem de erro caso a data seja inválida
            MessageBox.Show("Por favor, insira uma data válida no campo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TipoDeEmpresaComboBox_Validated(sender As Object, e As EventArgs) Handles TipoDeEmpresaComboBox.Validated
        TipodeEmpresa()
    End Sub

    Private Sub BtnVerAviso_Click(sender As Object, e As EventArgs) Handles BtnVerAviso.Click
        TabControle.SelectTab(10)
    End Sub

    Private Sub BtnVoltarInicio_Click(sender As Object, e As EventArgs) Handles BtnVoltarInicio.Click
        TabControle.SelectTab(0)
    End Sub

    Private Sub BtnNovaRazao_Click(sender As Object, e As EventArgs) Handles BtnNovaRazao.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(7)
    End Sub

    Private Sub BtnFormaDeAtuaCNAE_Click(sender As Object, e As EventArgs) Handles BtnFormaDeAtuaCNAE.Click
        TabControl2.SelectedIndex = 8
    End Sub

    Private Sub ProcessoComboBox_TextUpdate(sender As Object, e As EventArgs) Handles ProcessoComboBox.TextUpdate
        StatusMudar()
        MudaContratoAviso()
        ProcessoMudar()
    End Sub

    ' registrar endereço antigo /////////////////////////////////

    Private Sub ButtonRegistrarEndAntigo_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarEndAntigo.Click
        Try
            If MessageBox.Show("Deseja registrar o antigo endereço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                LiberaHistoricoEndereco()

                ' Verifica se os campos estão visíveis
                If EnderecoAntigoEmpLabel.Visible AndAlso EnderecoAntigoEmpRichTextBox.Visible Then
                    Dim enderecoParts As New List(Of String)
                    If Not String.IsNullOrWhiteSpace(EnderecoTextBox.Text) Then enderecoParts.Add(EnderecoTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndNumeroTextBox.Text) Then enderecoParts.Add("n.º " & EndNumeroTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndComplementoTextBox.Text) Then enderecoParts.Add(EndComplementoTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndBairroTextBox.Text) Then enderecoParts.Add(EndBairroTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndCEPMaskedTextBox.Text) Then enderecoParts.Add("CEP: " & EndCEPMaskedTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndCidadeTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(EndEstadoTextBox.Text) Then enderecoParts.Add("na cidade de " & EndCidadeTextBox.Text & "-" & EndEstadoTextBox.Text)

                    Dim enderecoLinha As String = String.Join(", ", enderecoParts)
                    Dim detalhesParts As New List(Of String)
                    If Not String.IsNullOrWhiteSpace(CadImobTextBox.Text) Then detalhesParts.Add("Cadastro Imobiliário: " & CadImobTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(PontoDeReferenciaComboBox.Text) Then detalhesParts.Add("Atividade no local: " & PontoDeReferenciaComboBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndZonaTextBox.Text) Then detalhesParts.Add("Zona: " & EndZonaTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndQuadraTextBox.Text) Then detalhesParts.Add("Quadra: " & EndQuadraTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(EndDataTextBox.Text) Then detalhesParts.Add("Data: " & EndDataTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(AreaTextBox.Text) Then detalhesParts.Add("Área do Imóvel (m²): " & AreaTextBox.Text)
                    If Not String.IsNullOrWhiteSpace(Area2TextBox.Text) Then detalhesParts.Add("Área do Estabelecimento (m²): " & Area2TextBox.Text)

                    Dim detalhesLinha As String = String.Join(" / ", detalhesParts)

                    Dim novoEndereco As String = $"{DateTime.Now:dd/MM/yyyy 'às' HH:mm} - Antigo Endereço.{vbCrLf}{enderecoLinha}{vbCrLf}{vbCrLf}{detalhesLinha}{vbCrLf}"

                    If Not String.IsNullOrWhiteSpace(EnderecoAntigoEmpRichTextBox.Text) Then
                        EnderecoAntigoEmpRichTextBox.AppendText(vbCrLf & "=====================================================" & vbCrLf & novoEndereco)
                    Else
                        EnderecoAntigoEmpRichTextBox.Text = novoEndereco
                    End If

                    If MessageBox.Show("Deseja limpar o histórico de endereço antigo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        LimparCamposEndereco()
                    End If

                Else
                    MessageBox.Show("Os campos do endereço antigo não estão visíveis.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao registrar o endereço: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimparCamposEndereco()
        Dim ControlesEndereco As Control() = {
        CadImobTextBox, EndCEPMaskedTextBox, EnderecoTextBox, EndNumeroTextBox,
        EndBairroTextBox, EndComplementoTextBox, EndCidadeTextBox, EndEstadoTextBox,
        EndPaisTextBox, EndZonaTextBox, EndQuadraTextBox, EndDataTextBox,
        AreaTextBox, Area2TextBox
    }

        For Each ctrl As Control In ControlesEndereco
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                DirectCast(ctrl, MaskedTextBox).Clear()
            End If
        Next
        PontoDeReferenciaComboBox.SelectedIndex = -1
    End Sub

    ' Método para bloquear os campos de endereço
    Private Sub BloquearEndereco()
        Dim ControlesEndereco As Control() = {
        CadImobTextBox, EndCEPMaskedTextBox, EnderecoTextBox, EndNumeroTextBox,
        EndBairroTextBox, EndComplementoTextBox, EndCidadeTextBox, EndEstadoTextBox,
        EndPaisTextBox, EndZonaTextBox, EndQuadraTextBox, EndDataTextBox,
        AreaTextBox, Area2TextBox
    }

        For Each ctrl As Control In ControlesEndereco
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is MaskedTextBox Then
                ctrl.Enabled = False
                ctrl.BackColor = SystemColors.Control
            End If
        Next
        PontoDeReferenciaComboBox.Enabled = False
    End Sub

    ' Método para desbloquear os campos de endereço
    Private Sub DesbloquearEndereco()
        Dim ControlesEndereco As Control() = {
        CadImobTextBox, EndCEPMaskedTextBox, EnderecoTextBox, EndNumeroTextBox,
        EndBairroTextBox, EndComplementoTextBox, EndCidadeTextBox, EndEstadoTextBox,
        EndPaisTextBox, EndZonaTextBox, EndQuadraTextBox, EndDataTextBox,
        AreaTextBox, Area2TextBox
    }

        For Each ctrl As Control In ControlesEndereco
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is MaskedTextBox Then
                ctrl.Enabled = True
                ctrl.BackColor = SystemColors.Window
            End If
        Next
        PontoDeReferenciaComboBox.Enabled = True
    End Sub



    ' Método para limpar os campos de endereço

    '/////////////////////////////////////////////////////////////
    Private Sub LinkLabelVerEndAntigo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelVerEndAntigo.LinkClicked
        'foca no EnderecoAntigoEmpRichTextBox
        EnderecoAntigoEmpRichTextBox.Focus()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles ButtonEndAntigoVoltar.Click
        TemEnderecoAntigoEmpComboBox.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonLimpaEndAntigo.Click
        Try
            'perguntas se deja limpar tudo do EnderecoAntigoEmpRichTextBox
            If MessageBox.Show("Deseja limpar o campo de endereço antigo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EnderecoAntigoEmpRichTextBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TemEnderecoAntigoEmpComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TemEnderecoAntigoEmpComboBox.SelectedIndexChanged
        If TemEnderecoAntigoEmpComboBox.Text = "Sim" Then
            ButtonRegistrarEndAntigo.Visible = True
            LinkLabelVerEndAntigo.Visible = True
            DesbloquearEndereco()
            LiberaHistoricoEndereco()

        ElseIf TemEnderecoAntigoEmpComboBox.Text = "Não" Then
            ButtonRegistrarEndAntigo.Visible = False
            LinkLabelVerEndAntigo.Visible = False
            DesbloquearEndereco()
            BloqueiaHistoricoEndereco()
        Else
            BloquearEndereco()
            BloqueiaHistoricoEndereco()

        End If
    End Sub

    Private Sub LiberaHistoricoEndereco()
        EnderecoAntigoEmpRichTextBox.Visible = True
        EnderecoAntigoEmpLabel.Visible = True
        ButtonEndAntigoVoltar.Visible = True
        ButtonLimpaEndAntigo.Visible = True
    End Sub

    Private Sub BloqueiaHistoricoEndereco()
        EnderecoAntigoEmpRichTextBox.Visible = False
        EnderecoAntigoEmpLabel.Visible = False
        ButtonEndAntigoVoltar.Visible = False
        ButtonLimpaEndAntigo.Visible = False
    End Sub

    Private Sub LinkLabelCopiarPastaDocEmpfacil_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopiarPastaDocEmpfacil.LinkClicked
        'usar try e colocar no meu copiar o PastaDocumentosTextBox
        Try
            ' Verifica se o campo de pasta de documentos não está vazio
            If Not String.IsNullOrEmpty(PastaDocumentosTextBox.Text) Then
                ' Copia o conteúdo do TextBox para a área de transferência
                Clipboard.SetText(PastaDocumentosTextBox.Text)
            Else
                ' Exibe uma mensagem caso o campo esteja vazio
                MessageBox.Show("O campo de pasta de documentos está vazio. Não há nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao copiar a pasta de documentos: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCopiarEmpresaTexto_Click(sender As Object, e As EventArgs) Handles ButtonCopiarEmpresaTexto.Click
        Try
            ' Verifica se houve alteração de razão social
            If NovaRazaoSocialComboBox.Text = "Sim" Then
            MsgBox("Houve alteração de razão social. Por favor, realize a alteração manualmente.")
            Exit Sub
        End If

        ' Captura os dados de razão social
        Dim RazaoSocial As String = RazaoSocialTextBox.Text

        ' Selecionar e mudar para tab dos controles
        TabControle.SelectedTab = TabPageDadosEmpresa
        TabControl2.SelectedTab = TabPageEndereco
        TabControle.SelectedTab = TabPageEmpresaFacil

        ' Verifica se houve alteração de endereço
        If PontoDeReferenciaComboBox.Text = "Sim" Then
            MsgBox("Houve alteração de endereço. Por favor, realize a alteração manualmente.")
            Exit Sub
        End If

        ' Captura os dados do endereço
        Dim Endereco As String = EnderecoTextBox.Text
        Dim Numero As String = EndNumeroTextBox.Text
        Dim Complemento As String = EndComplementoTextBox.Text
        Dim Bairro As String = EndBairroTextBox.Text
        Dim CEP As String = EndCEPMaskedTextBox.Text
        Dim Cidade As String = EndCidadeTextBox.Text
        Dim UF As String = EndEstadoTextBox.Text

        ' Verifica se há complemento no endereço
        If Complemento = "" Then
            Clipboard.SetText(Endereco & ", n.º " & Numero & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & UF)
        Else
            Clipboard.SetText(Endereco & ", n.º " & Numero & ", " & Complemento & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & UF)
        End If

        ' Verifica o estado para incluir na Junta Comercial
        Dim Estado As String = EndEstadoLabel2.Text
        Dim JuntaComercial As String = "Junta Comercial do " & GetEstadoNome(Estado)

        ' Captura o número de NIRE e a data
        Dim NIRE As String = NIRETextBox.Text
            Dim NireData As String = Format(Date.Parse(NireDataMaskedTextBox.Text), "dd \d\e MMMM \d\e yyyy")

            ' Captura o CNPJ
            Dim CNPJ As String = CNPJMaskedTextBox.Text

        ' Verifica se algum campo está vazio e avisa o usuário
        Try
            If String.IsNullOrEmpty(RazaoSocial) Or String.IsNullOrEmpty(Endereco) Or String.IsNullOrEmpty(Numero) Or String.IsNullOrEmpty(CEP) Or String.IsNullOrEmpty(Cidade) Or String.IsNullOrEmpty(UF) Or String.IsNullOrEmpty(NIRE) Or String.IsNullOrEmpty(NireData) Or String.IsNullOrEmpty(CNPJ) Then
                Throw New Exception("Há campos obrigatórios não preenchidos. Por favor, preencha todos os campos.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

            ' Formata os dados para copiar no formato desejado
            Dim TextoCopiado As String = RazaoSocial & ", com sede e foro na " & Endereco & ", nº " & Numero & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & UF & ", com Contrato Social registrado na " & JuntaComercial & ", sob nº " & NIRE & ", por despacho em sessão de " & NireData & " e inscrita no CNPJ nº " & CNPJ

            ' Copia o texto formatado para a área de transferência
            ' Clipboard.SetText(TextoCopiado)

            ' Formatar a razão social em RTF para mantê-la em negrito ao colar no Word ou Excel
            Dim RTFTexto As String = "{\rtf1\ansi \b " & RazaoSocial & "\b0 , com sede e foro na " & Endereco & ", nº " & Numero & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & UF & ", com Contrato Social registrado na " & JuntaComercial & ", sob nº " & NIRE & ", por despacho em sessão de " & NireData & " e inscrita no CNPJ nº " & CNPJ & "}"

            ' Copia o texto formatado para a área de transferência
            Dim dataObject As New DataObject()
            dataObject.SetData(DataFormats.Rtf, RTFTexto)
            Clipboard.SetDataObject(dataObject, True)

            ' Exibe mensagem de sucesso
            '     MsgBox("Texto copiado para a área de transferência com sucesso.")
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao copiar o texto da empresa: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Função para obter o nome completo do estado a partir da sigla
    Private Function GetEstadoNome(estadoSigla As String) As String
        Select Case estadoSigla.ToUpper()
            Case "AC" : Return "Acre"
            Case "AL" : Return "Alagoas"
            Case "AP" : Return "Amapá"
            Case "AM" : Return "Amazonas"
            Case "BA" : Return "Bahia"
            Case "CE" : Return "Ceará"
            Case "DF" : Return "Distrito Federal"
            Case "ES" : Return "Espírito Santo"
            Case "GO" : Return "Goiás"
            Case "MA" : Return "Maranhão"
            Case "MT" : Return "Mato Grosso"
            Case "MS" : Return "Mato Grosso do Sul"
            Case "MG" : Return "Minas Gerais"
            Case "PA" : Return "Pará"
            Case "PB" : Return "Paraíba"
            Case "PR" : Return "Paraná"
            Case "PE" : Return "Pernambuco"
            Case "PI" : Return "Piauí"
            Case "RJ" : Return "Rio de Janeiro"
            Case "RN" : Return "Rio Grande do Norte"
            Case "RS" : Return "Rio Grande do Sul"
            Case "RO" : Return "Rondônia"
            Case "RR" : Return "Roraima"
            Case "SC" : Return "Santa Catarina"
            Case "SP" : Return "São Paulo"
            Case "SE" : Return "Sergipe"
            Case "TO" : Return "Tocantins"
            Case Else : Return "Estado Desconhecido"
        End Select
    End Function

    Private Sub LinkLabelCopiarMEtxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopiarMEtxt.LinkClicked
        Try
            ' Verifica o porte da empresa
            Dim PorteEmpresa As String = PorteDaEmpresaComboBox.Text
            Dim PorteTexto As String = ""

            Select Case PorteEmpresa
                Case "Microempresa"
                    PorteTexto = "Microempresa"
                Case "Empresa de Pequeno Porte"
                    PorteTexto = "Empresa de Pequeno Porte"
                Case "Demais"
                    MsgBox("Atenção! Para empresas classificadas como 'Demais', é necessário consultar um contador para verificar o correto enquadramento.", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                    'Outros
                Case "Outros"
                    MsgBox("Atenção! Para empresas classificadas como 'Outros', é necessário consultar um contador para verificar o correto enquadramento.", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                Case Else
                    MsgBox("Porte da empresa não identificado. Verifique se a informação está correta.", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
            End Select

            ' Pergunta se há mais de um sócio
            Dim resposta As DialogResult = MessageBox.Show("A empresa possui mais de um sócio?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Dim TextoCopiado As String

            If resposta = DialogResult.Yes Then
                TextoCopiado = "Os sócios declaram que a sociedade, sob as penas da Lei, se enquadra na condição de " & PorteTexto & ", nos termos da Lei Complementar nº 123, de 14/12/2006."
            Else
                TextoCopiado = "O sócio declara que a sociedade, sob as penas da Lei, se enquadra na condição de " & PorteTexto & ", nos termos da Lei Complementar nº 123, de 14/12/2006."
            End If


            ' Formatar em RTF para manter o negrito ao colar no Word ou Excel
            Dim RTFTexto As String = "{\rtf1\ansi Os sócios declaram que a sociedade, sob as penas da Lei, se enquadra na condição de \b " & PorteTexto & "\b0 , nos termos da Lei Complementar nº 123, de 14/12/2006.}"

            ' Copia o texto formatado para a área de transferência
            Dim dataObject As New DataObject()
            dataObject.SetData(DataFormats.Rtf, RTFTexto)
            Clipboard.SetDataObject(dataObject, True)

            ' Exibe mensagem de sucesso
            ' MsgBox("Texto copiado para a área de transferência com sucesso!", MsgBoxStyle.Information, "Sucesso")

        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao copiar o texto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
