Imports System.Data.SqlClient

Public Class FrmSocios

    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

    Private Sub AtivarTab()
        'ativar TabControl1 1
        TabControl1.SelectedTab = TabPage1
        'ativar TabControl1 2
        TabControl1.SelectedTab = TabPage2
        'ativar TabControl1 3
        TabControl1.SelectedTab = TabPage3
        'ativar TabControl1 1
        TabControl1.SelectedTab = TabPage1

    End Sub
    Private Sub FrmSocios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Oculta a última linha do TableLayoutPanel
            TableLayoutPanel1.RowCount = 4  ' Certifica-se de que tem 4 linhas
            TableLayoutPanel1.RowStyles(3).SizeType = SizeType.Absolute
            TableLayoutPanel1.RowStyles(3).Height = 0

            ' Ajusta o tamanho do formulário para se adaptar ao TableLayoutPanel
            Me.Height = TableLayoutPanel1.Height + Me.ClientSize.Height - TableLayoutPanel1.ClientSize.Height

        Catch ex As Exception
            MsgBox("Erro ao carregar o formulário: " & ex.Message)
        End Try


        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Socios'. Você pode movê-la ou removê-la conforme necessário.
        Me.SociosTableAdapter.Fill(Me.PrinceDBDataSet.Socios)


        'listbox invisivel
        ListBoxEstadoCivil.Visible = False
        CivilTextBox.Visible = True
        'listbox invisivel

        BloquearEdicao()

        GeneroComboBox.Items.Add("Masculino")
        GeneroComboBox.Items.Add("Feminino")

        TextBoxExtensoDN.Visible = False


        GroupBoxCapitalSocial.Visible = False
        GroupBoxMenuCapitalSocial.Visible = False
        'desabilita
        GroupBoxMenuCapitalSocial.Enabled = False
        GroupBoxCapitalSocial.Enabled = False

        'seleciona o primeiro do ComboBox1
        ComboBox1.SelectedIndex = -1

        BtnDuplicidade.Visible = False

        BtnEditar.Text = "Editar"


        ' Vincula o evento CurrentChanged do BindingSource para detectar mudanças na empresa
        AddHandler SociosBindingSource.CurrentChanged, AddressOf SociosBindingSource_CurrentChanged

        ValidaIdadeMenor()

    End Sub

    Private Sub AtualizarDataGridView()
        ' Vincular novamente o DataGridView ao BindingSource
        '  DataGridViewEmpresa.DataSource = SociosBindingSource

        ' Atualizar a contagem de registros no DataGridView
        If SociosBindingSource.Count > 0 Then
            LblContaEmpresa.Text = "Total de Empresas Encontradas: " & SociosBindingSource.Count.ToString()
        Else
            LblContaEmpresa.Text = "Total de Empresas Encontradas: Nenhuma - clique em buscar"
        End If
    End Sub



    Private Sub BloquearEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = False
        GroupBoxOutrosDados.Enabled = False
        GroupBoxConjuge.Enabled = False

        'nao habilita o botao exlcuir
        BtnSalvar.Enabled = False
        BtnExcluir.Enabled = False
        ' habilitar, botao novo, fechar 
        BtnNovo.Enabled = True
        BtnFecharMenu.Enabled = True
        BtnFechar.Enabled = True
        BtnEditar.Text = "Editar"
    End Sub

    Private Sub LiberarEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = True
        GroupBoxOutrosDados.Enabled = True
        GroupBoxConjuge.Enabled = True

        'habilita o botao exlcuir
        BtnSalvar.Enabled = True
        BtnExcluir.Enabled = True
        'nao habilitar, botao novo, fechar 
        BtnNovo.Enabled = False
        BtnFecharMenu.Enabled = False
        BtnFechar.Enabled = False
        BtnEditar.Text = "Cancelar"
    End Sub

    Private Sub EstadoCivil()
        'verificar se está preenchido ou nao
        'If CivilTextBox.Text = "" Then
        If GeneroComboBox.Text = "Masculino" Then
            ListBoxEstadoCivil.Items.Clear()
            'adicionar itens ao listbox solteiro
            ListBoxEstadoCivil.Items.Add("solteiro")
            ListBoxEstadoCivil.Items.Add("separado")
            ListBoxEstadoCivil.Items.Add("divorciado")
            ListBoxEstadoCivil.Items.Add("casado em regime de comunhão parcial de bens")
            ListBoxEstadoCivil.Items.Add("casado em regime de comunhão universal de bens")
            ListBoxEstadoCivil.Items.Add("casado em regime de separação obrigatória de bens")
            ListBoxEstadoCivil.Items.Add("casado em regime de participação final nos aquestos")
            ListBoxEstadoCivil.Items.Add("viúvo")
            If ProfissãoTextBox.Text = "" Then
                ProfissãoTextBox.Text = "empresário"
            End If

        ElseIf GeneroComboBox.Text = "Feminino" Then
            ListBoxEstadoCivil.Items.Clear()
            ListBoxEstadoCivil.Items.Add("solteira")
            ListBoxEstadoCivil.Items.Add("separada")
            ListBoxEstadoCivil.Items.Add("divorciada")
            ListBoxEstadoCivil.Items.Add("casada em regime de comunhão parcial de bens")
            ListBoxEstadoCivil.Items.Add("casada em regime de comunhão universal de bens")
            ListBoxEstadoCivil.Items.Add("casada em regime de separação obrigatória de bens")
            ListBoxEstadoCivil.Items.Add("casada em regime de participação final nos aquestos")
            ListBoxEstadoCivil.Items.Add("viúva")
            If ProfissãoTextBox.Text = "" Then
                ProfissãoTextBox.Text = "empresária"
            End If
        Else
            ListBoxEstadoCivil.Items.Clear()
            ListBoxEstadoCivil.Items.Add("solteiro")
            ListBoxEstadoCivil.Items.Add("separado")
            ListBoxEstadoCivil.Items.Add("divorciado")
            ListBoxEstadoCivil.Items.Add("casado em regime de comunhão parcial de bens")
            ListBoxEstadoCivil.Items.Add("casado em regime de comunhão universal de bens")
            ListBoxEstadoCivil.Items.Add("casado em regime de separação obrigatória de bens")
            ListBoxEstadoCivil.Items.Add("casado em regime de participação final nos aquestos")
            ListBoxEstadoCivil.Items.Add("viúvo")
            If ProfissãoTextBox.Text = "" Then
                ProfissãoTextBox.Text = "empresário"
            End If
        End If
        '  End If
    End Sub
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        'pergunta, adiciona novo registro
        If MessageBox.Show("Deseja adicionar um novo registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'new register
            SociosBindingSource.AddNew()
            LiberarEdicao()


            'selecionar  index 0 GeneroComboBox e CivilComboBox
            GeneroComboBox.SelectedIndex = -1
            ListBoxEstadoCivil.SelectedIndex = -1

            TextBoxExtensoDN.Visible = False
            BtnDuplicidade.Visible = True
            '  BtnEditar.Text = "Cancelar"
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If BtnEditar.Text = "Cancelar" Then
            'cancelar ediçao
            If MsgBox("Deseja cancelar a edição?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'cancelar ediçao
                Me.SociosBindingSource.CancelEdit()
                BloquearEdicao()
                TextBoxExtensoDN.Visible = False
                BtnDuplicidade.Visible = False
                BtnEditar.Text = "Editar"
            End If
        ElseIf BtnEditar.Text = "Editar" Then
            LiberarEdicao()
            TextBoxExtensoDN.Visible = False
            'muda o nome do botao para "Cancelar"
            BtnEditar.Text = "Cancelar"
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        ' Finalizar edição e obter registros alterados
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Dim changedRecords As System.Data.DataTable = PrinceDBDataSet.Socios.GetChanges()

        ' Verificar se há alterações para salvar
        If changedRecords IsNot Nothing AndAlso changedRecords.Rows.Count > 0 Then
            ' Criar uma string para armazenar as mudanças
            Dim changesDescription As String = ""
            Dim detailedChanges As String = ""

            ' Iterar sobre as linhas alteradas
            For Each row As DataRow In changedRecords.Rows
                changesDescription &= "Alterações na linha com ID: " & row("ID_Socios").ToString() & vbCrLf

                Dim columnChangesCount As Integer = 0

                ' Iterar sobre as colunas para identificar as mudanças
                For Each column As DataColumn In changedRecords.Columns
                    ' Verificar se a linha é nova (adicionada) ou modificada
                    If row.RowState <> DataRowState.Added Then
                        ' Apenas verificar diferenças entre as versões original e atual se a linha não for nova
                        If Not row(column, DataRowVersion.Original).Equals(row(column, DataRowVersion.Current)) Then
                            columnChangesCount += 1
                            detailedChanges &= "  - " & column.ColumnName & ": " & row(column, DataRowVersion.Original).ToString() & " => " & row(column, DataRowVersion.Current).ToString() & vbCrLf
                        End If
                    Else
                        ' Para novas linhas, apenas listar os valores atuais
                        columnChangesCount += 1
                        detailedChanges &= "  - " & column.ColumnName & ": " & row(column, DataRowVersion.Current).ToString() & vbCrLf
                    End If
                Next
                changesDescription &= "  (" & columnChangesCount & " mudanças)" & vbCrLf
            Next

            ' Perguntar se deseja salvar os dados, exibindo as mudanças detectadas
            Dim message As String = "Foram detectadas alterações." & vbCrLf & "Deseja salvar as alterações?" & vbCrLf & vbCrLf & changesDescription
            Dim result As DialogResult = MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNoCancel)

            Select Case result
                Case DialogResult.Cancel
                    ' Não fazer nada, apenas sair do método
                    Exit Sub

                Case DialogResult.No
                    ' Reverter mudanças se o usuário escolher não salvar
                    PrinceDBDataSet.Socios.RejectChanges()
                    BloquearEdicao()
                    TextBoxExtensoDN.Visible = False
                    BtnEditar.Text = "Editar"

                Case DialogResult.Yes
                    ' Salvar dados
                    Try
                        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
                        MessageBox.Show("Dados salvos com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        BloquearEdicao()
                        TextBoxExtensoDN.Visible = False
                        BtnEditar.Text = "Editar"

                        ' Perguntar se deseja ver os detalhes das alterações
                        If MessageBox.Show("Deseja ver os detalhes das alterações?", "Detalhes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            MessageBox.Show(detailedChanges, "Detalhes das Alterações", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch exc As Exception
                        MessageBox.Show("Ocorreu um erro ao salvar os dados." & vbCrLf & exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
            End Select
        Else
            ' Se não houver alterações, informar ao usuário
            MessageBox.Show("Nenhuma alteração foi detectada.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BloquearEdicao()
            TextBoxExtensoDN.Visible = False
            BtnEditar.Text = "Editar"
        End If
    End Sub




    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        'cancelar ediçao
        If MsgBox("Deseja cancelar a edição?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'cancelar ediçao
            Me.SociosBindingSource.CancelEdit()
            BloquearEdicao()
            TextBoxExtensoDN.Visible = False
            BtnDuplicidade.Visible = False
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'perguntar, e excluir dados
        If MsgBox("Deseja excluir os dados?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'excluir dados
            If MsgBox("Tem certeza que deseja excluir os dados?", MsgBoxStyle.YesNo, "A T E N Ç Ã O") = MsgBoxResult.Yes Then

                Me.SociosBindingSource.RemoveCurrent()
                Me.Validate()
                Me.SociosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
                BloquearEdicao()
                TextBoxExtensoDN.Visible = False
                BtnEditar.Text = "Editar"
            End If
        End If
    End Sub

    'ao digitar no CPFComboBox mudar para formato CPF
    Private Sub CPFComboBox_TextChanged(sender As Object, e As EventArgs)
        'ao digitar converter para cpf
        CPFComboBox.Text = Format(CPFComboBox.Text, "000\.000\.000\-00")

    End Sub

    Private Async Sub BtnCorreios_Click(sender As Object, e As EventArgs) Handles BtnCorreios.Click
        Try
            BtnCorreios.Text = "AGUARDE..."
            BtnCorreios.Enabled = False
            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(CEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                RUATextBox.Text = resultado.logradouro
                If ComplementoTextBox.Text = "" Then
                    ComplementoTextBox.Text = resultado.complemento
                Else
                    'nao faz nada
                End If
                CidadeTextBox.Text = resultado.localidade
                BairroTextBox.Text = resultado.bairro
                EstadoTextBox.Text = resultado.uf
            Else
                MessageBox.Show("CEP não encontrado.")
            End If
            BtnCorreios.Text = "Preencher"
            BtnCorreios.Enabled = True

        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar informações de CEP: " & ex.Message)
        End Try
    End Sub

    Private Sub GeneroComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GeneroComboBox.SelectedIndexChanged
        'ao selecionar feminino mudar o nome solteiro para solteira do  CivilComboBox 
        EstadoCivil()
    End Sub

    Private Sub CivilComboBox_Click(sender As Object, e As EventArgs)
        'verifica se esta no Feminino e mudar para solteira do  CivilComboBox da lista
        EstadoCivil()
    End Sub

    Private Sub DataDeNascExtenso()
        Dim DataDeNascimento As String = DatadeNascMaskedTextBox.Text
        Dim DataDeNascimentoFormatada As String = Format(CDate(DataDeNascimento), "dd 'de' MMMM 'de' yyyy")
        'TextBoxExtensoDN
        TextBoxExtensoDN.Visible = True
        TextBoxExtensoDN.Text = DataDeNascimentoFormatada
    End Sub
    Private Sub BtnExtensoDN_Click(sender As Object, e As EventArgs) Handles BtnExtensoDN.Click
        DataDeNascExtenso()
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click, BtnFecharMenu.Click
        Me.Close()
    End Sub


    Private Sub ExportarDados()
        'ativar TabControle 1
        FrmLegalizacao.TabControl1.SelectedIndex = 1

        'aativar TabControl2 0
        FrmLegalizacao.TabControl2.SelectedIndex = 0

        'pega CPFMaskedTextBox e copa para  frmLegalizacao.CPFResponsavelMaskedTextBox.text
        FrmLegalizacao.CPFResponsavelMaskedTextBox.Text = CPFMaskedTextBox.Text
        FrmLegalizacao.NomeResponsavelTextBox.Text = NomeCompletoTextBox.Text
        FrmLegalizacao.RespMaeTextBox.Text = NomeMaeTextBox.Text
        FrmLegalizacao.RespPaiTextBox.Text = NomePaiTextBox.Text
        FrmLegalizacao.RespDataNascMaskedTextBox.Text = DatadeNascMaskedTextBox.Text
        FrmLegalizacao.RespRGTextBox.Text = RGTextBox.Text
        FrmLegalizacao.ResponsavelOrgaoRGTextBox.Text = OrgaoRGTextBox.Text
        FrmLegalizacao.ResponsavelEstadoOrgaoRGTextBox.Text = EstadoRGTextBox.Text
        FrmLegalizacao.SenhaGovTextBox.Text = SenhaGOVTextBox.Text
        FrmLegalizacao.TituloeleitorTextBox.Text = TituloDeEleitorTextBox.Text
        FrmLegalizacao.CNHnumeroTextBox.Text = CNHTextBox.Text
        FrmLegalizacao.CNHexpTextBox.Text = CNHExpedicaoTextBox.Text
        FrmLegalizacao.CNHdataexpMaskedTextBox.Text = CNHDataExpMaskedTextBox.Text


    End Sub
    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Try
            ' Verifica se o formulário já está aberto
            Dim frmLegalizacaoAberto As Boolean = False

            ' Procura pelo formulário entre os forms abertos
            For Each form In Application.OpenForms
                If TypeOf form Is FrmLegalizacao Then
                    frmLegalizacaoAberto = True
                    FrmLegalizacao = CType(form, FrmLegalizacao)
                    Exit For
                End If
            Next

            If frmLegalizacaoAberto Then
                ' Se o formulário estiver aberto, focar nele e exportar dados
                FrmLegalizacao.Focus()
                Dim NomeEmpresa As String = FrmLegalizacao.RazaoSocialTextBox.Text
                Dim NomeSocio As String = NomeCompletoTextBox.Text
                If MsgBox("Deseja exportar os dados do " & NomeSocio & " para Empresa " & NomeEmpresa & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    AtivarTab()
                    ExportarDados()
                    Me.Close()
                End If
            Else
                ' Se o formulário não estiver aberto, abrir o formulário e exibir mensagem
                FrmLegalizacao = New FrmLegalizacao()
                FrmLegalizacao.Show()
                MsgBox("Abrir a empresa onde deseja exportar!")
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub




    Private Sub AddSocios()
        Try
            'ativar TabControle 1
            FrmLegalizacao.TabControl1.SelectedIndex = 1

            'ativar TabControl2 0
            FrmLegalizacao.TabControl2.SelectedIndex = 1

            'Dados
            Dim CPF As String = CPFMaskedTextBox.Text
            Dim NomeCompleto As String = NomeCompletoTextBox.Text
            Dim NomeDaMae As String = NomeMaeTextBox.Text
            Dim NomeDaPai As String = NomePaiTextBox.Text

            'clicar no BtnExtensoDN

            'se tiver vazio DataDeNascExtenso deixar em branco
            Dim DataDeNascimento As String = DatadeNascMaskedTextBox.Text

            If DataDeNascimento = "" Then
                DataDeNascimento = ""
            Else
                Dim DataDeNascimentoFormatada As String = Format(CDate(DataDeNascimento), "dd 'de' MMMM 'de' yyyy")
                DataDeNascimento = DataDeNascimentoFormatada
            End If

            Dim RG As String = RGTextBox.Text
            Dim OrgaoRG As String = OrgaoRGTextBox.Text
            Dim EstadoRG As String = EstadoRGTextBox.Text
            Dim SenhaGOV As String = SenhaGOVTextBox.Text
            Dim TituloDeEleitor As String = TituloDeEleitorTextBox.Text
            Dim CNH As String = CNHTextBox.Text
            Dim ExpediçãoCNH As String = CNHExpedicaoTextBox.Text
            Dim DataExpediçãoCNH As String = CNHDataExpMaskedTextBox.Text
            Dim EstadoCivil As String = CivilTextBox.Text
            Dim Empresario As String = ProfissãoTextBox.Text
            Dim Genero As String = GeneroComboBox.Text
            Dim domiciliado As String

            'endereço
            Dim RUA As String = RUATextBox.Text
            If RUA = "" Then
                RUA = ""
            Else
                RUA = RUA.Substring(0, 1).ToLower() & RUA.Substring(1)
            End If
            'primeira letra da RUA em minusculo
            Dim RUA1 As String = RUA

            Dim N As String = NumTextBox.Text
            Dim Compl As String = ComplementoTextBox.Text
            Dim Bairro As String = BairroTextBox.Text
            Dim CEP As String = CEPMaskedTextBox.Text
            Dim Cidade As String = CidadeTextBox.Text
            Dim Estado As String = EstadoTextBox.Text
            Dim Portador As String
            Dim Brasileiro As String
            Dim Nascido As String

            'verificar se está no masculino ou feminino no campo GeneroComboBox
            If Genero = "Masculino" Then
                domiciliado = "domiciliado"
                Portador = "portador"
                Brasileiro = "brasileiro"
                Nascido = "nascido em"

            ElseIf Genero = "Feminino" Then
                domiciliado = "domiciliada"
                Portador = "portadora"
                Brasileiro = "brasileira"
                Nascido = "nascida em"
            End If

            'Verificar menor de idade
            Dim RepresentanteLegal As String = ""
            If MenorIdadeComboBox.Text <> "" Then
                ' Alterar o texto para menor de idade
                Dim MenorTexto As String = MenorIdadeComboBox.Text
                NomeCompleto &= ", " & MenorTexto

                ' Incluir representação legal
                RepresentanteLegal = "neste ato representado por seu responsável legal"

                ' Exibir mensagem solicitando o responsável
                MsgBox("Por favor, insira o responsável legal pelo menor de idade.", MsgBoxStyle.Information, "Atenção")
            End If

            'continua
            If EstadoCivil = "solteira" Then
                EstadoCivil = "maior, solteira"
            ElseIf EstadoCivil = "solteiro" Then
                EstadoCivil = "maior, solteiro"
            End If

            'se Compl está vazio ou não, então não adicionar o complemento
            If Compl = "" Then
                Compl = ""
            Else
                Compl = ", " & ComplementoTextBox.Text
            End If

            '///////////////////////////////////////////////////////////////////////////////////
            'não permitir o mesmo CPF dentro do FrmLegalizacao.DadosSociosRichTextBox
            Dim QuantidadeSocios As Integer

            If FrmLegalizacao.DadosSociosRichTextBox.Text.Contains(CPF) Then
                MsgBox("CPF já cadastrado", MsgBoxStyle.Exclamation, "Atenção")

                If MsgBox("Deseja adicionar o novo cadastro?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    'procurar o CPF no FrmLegalizacao.DadosSociosRichTextBox
                    Dim Posição As Integer = FrmLegalizacao.DadosSociosRichTextBox.Find(CPF)
                    'Novos dados na linha de baixo
                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Remove(Posição, CPF.Length)

                    ' Pergunta sobre saída de sócio
                    Dim saidaDeSocio As String = ""
                    If MsgBox("O sócio está saindo da empresa?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                        saidaDeSocio = "Saída de Sócio "
                        FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Replace("Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////", saidaDeSocio & "//////////////////////////////////////////////////////////")
                    End If

                    ' Perguntar se é sócio-administrador ou sócio
                    Dim ehAdministrador As String = ""
                    If MsgBox("O sócio é administrador?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                        ehAdministrador = "Sócio-Administrador"
                    Else
                        ehAdministrador = "Sócio"
                    End If

                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Insert(Posição, "
Novos dados:
" & saidaDeSocio & "Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////" & vbCrLf &
ehAdministrador & vbCrLf & vbCrLf &
NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", n.º " & N & "" & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG n.º " & RG & "-" & OrgaoRG & "/" & EstadoRG & " e do CPF n.º " & CPF & "." & RepresentanteLegal & vbCrLf &
"//////////////////////////////////////////////////////////////////////")
                End If

            Else
                'Contagem de Sócios
                If FrmLegalizacao.QuantidadeSociosTextBox.Text = "" Then
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = "1"
                Else
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = FrmLegalizacao.QuantidadeSociosTextBox.Text + 1
                End If
                QuantidadeSocios = CInt(FrmLegalizacao.QuantidadeSociosTextBox.Text)

                ' Perguntar se é sócio-administrador ou sócio
                Dim ehAdministrador As String = ""
                If MsgBox("O sócio é administrador?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    ehAdministrador = "Sócio-Administrador"
                Else
                    ehAdministrador = "Sócio"
                End If

                'FORMA FINAL
                FrmLegalizacao.DadosSociosRichTextBox.SelectedText &=
        " Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////" & vbCrLf &
        ehAdministrador & vbCrLf & vbCrLf &
        NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", n.º " & N & "" & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG n.º " & RG & "-" & OrgaoRG & "/" & EstadoRG & " e do CPF n.º " & CPF & "." & RepresentanteLegal & vbCrLf &
        "//////////////////////////////////////////////////////////////////////"
            End If

            'Focar na frente o FrmLegalizacao
            FrmLegalizacao.Focus()
            FrmLegalizacao.DadosSociosRichTextBox.Focus()
            Me.Close()

        Catch ex As Exception
            'mostra mgs do local do erro + "Preencha todos os campos obrigatórios"
            MsgBox(ex.Message & "Preencha todos os campos obrigatórios", MsgBoxStyle.Critical, "Atenção")
            Me.Focus()
        End Try

    End Sub

    Private Sub BtnAddSocios_Click(sender As Object, e As EventArgs) Handles BtnAddSocios.Click
        Try
            ' Verifica se FrmLegalizacao está visível
            If FrmLegalizacao.Visible = True Then
                FrmLegalizacao.Focus() ' Coloca o foco no FrmLegalizacao
                Dim NomeEmpresa As String = FrmLegalizacao.RazaoSocialTextBox.Text
                Dim NomeSocio As String = NomeCompletoTextBox.Text

                ' Pergunta ao usuário se deseja exportar os dados
                If MsgBox("Deseja exportar os dados do " & NomeSocio & " para Empresa " & NomeEmpresa & " ?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    AtivarTab() ' Ativa a tabulação (se necessário)

                    ' Verifica se FrmSocios está aberto
                    If Application.OpenForms().OfType(Of FrmSociosExportar).Any() Then
                        MsgBox("O formulário FrmSocios Exportar já está aberto.", MsgBoxStyle.Information, "Atenção")
                        FrmSociosExportar.Focus() ' Coloca o foco no FrmSocios
                    Else
                        FrmSociosExportar.Show() ' Abre o FrmSocios se não estiver aberto
                    End If
                End If
            Else
                ' Se FrmLegalizacao não estiver visível, abre e exibe uma mensagem
                FrmLegalizacao.Show()
                MsgBox("Abra a empresa onde deseja exportar os dados!", MsgBoxStyle.Information, "Atenção")
            End If
        Catch ex As Exception
            ' Exibe mensagem de erro caso ocorra uma exceção
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    'ao fechar PrinceDBDataSet.Socios.GetChanges() verificar se teve alterações
    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'verificar se teve alterações no formulario atual compadado ao que tem no banco de dados
        Dim changedRecords As System.Data.DataTable
        Me.SociosBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.Socios.GetChanges()

        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then
            Dim message As String
            'mostrar quantas alterações foram feitas e id
            message = "Foram feitas " & changedRecords.Rows.Count & " alterações no cadastro dos Sócios." & vbCrLf & "Deseja salvar as alterações?"
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    'salvar alterações
                    Me.Validate()
                    Me.SociosBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

                Catch exc As Exception
                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        End If



    End Sub


    Private Sub BtnWord_Click(sender As Object, e As EventArgs) Handles BtnWord.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Selecione um número de sócio", MsgBoxStyle.Exclamation, "Atenção")
            ComboBox1.Focus()
            Exit Sub

        Else
            If ExportarContratoWordDialog.Visible = True Then
                AtivarTab()
                ExportarContratoWordDialog.Focus()
            ElseIf ExportarLaudoWordDialog.Visible = True Then
                AtivarTab()
                ExportarContratoWordDialog.Focus()
            Else
                MsgBox("Favor, abrir o formulário para exportação empresas ou alvará!")
            End If
        End If
    End Sub
    Private Sub BtnCapitalSocial_Click(sender As Object, e As EventArgs) Handles BtnCapitalSocial.Click
        Try
            ' Verifica o estado do botão e alterna entre abrir e fechar
            If BtnCapitalSocial.Text = "Abrir Calculadora Capítal Social" Then
                AtivarTab()
                BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social"

                ' Exibe o GroupBox
                GroupBoxCapitalSocial.Visible = True
                GroupBoxMenuCapitalSocial.Visible = True
                GroupBoxMenuCapitalSocial.Enabled = True
                GroupBoxCapitalSocial.Enabled = True

                ' Configura o TableLayoutPanel para ajustar o tamanho automaticamente
                TableLayoutPanel1.RowCount = 4  ' Ajusta para ter 4 linhas se necessário
                TableLayoutPanel1.RowStyles(3).SizeType = SizeType.Percent
                TableLayoutPanel1.RowStyles(3).Height = 100 ' Ajusta a última linha para ocupar o espaço necessário

                ' Ajusta automaticamente o tamanho do Form com base no conteúdo
                Me.AutoSize = True
                Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
                Me.CenterToScreen()

            ElseIf BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social" Then
                BtnCapitalSocial.Text = "Abrir Calculadora Capítal Social"

                ' Oculta o GroupBox
                GroupBoxCapitalSocial.Visible = False
                GroupBoxMenuCapitalSocial.Visible = False
                GroupBoxMenuCapitalSocial.Enabled = False
                GroupBoxCapitalSocial.Enabled = False

                ' Retorna o tamanho original do formulário
                Me.AutoSize = False
                Me.Size = New Size(840, 619) ' Ajuste os valores de tamanho de acordo com o tamanho original do formulário
                Me.CenterToScreen()


                ' Oculta a última linha do TableLayoutPanel
                TableLayoutPanel1.RowStyles(3).Height = 0  ' Oculta a última linha
                TableLayoutPanel1.RowStyles(3).SizeType = SizeType.Absolute
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub






    '//////////////////////////////////////////// INICIO CALCULADORA DE CAPITAL ///////////////
    Private Sub Porcentagem()
        Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)


        ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
        If TextBoxCapitalSocial.Text = "" Then
            MsgBox("Digite o valor do capital social")
            TextBoxCapitalSocial.Focus()
            Exit Sub
        End If

        'cada linha tem seu calculo de porcentagem cell 1,sob o valor da TextBoxCapitalSocial 
        'conveter Double


        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(1).Value = "" Then
                row.Cells(1).Value = 0
            End If
            'calculo da porcentagem
            'Cells(3) porcentagem
            row.Cells(3).Value = (row.Cells(1).Value * valor) / 100
            'coluna 3 converte em Double
            row.Cells(3).Value = CDbl(row.Cells(3).Value)
            'coluna 3 converte em String
            row.Cells(3).Value = FormatCurrency(row.Cells(3).Value)

        Next





        'depois totalizar o valores das em uma nova linha, e nao repetir o calculo
        'se tiver TOTAL limpas e fazer calculo novamente
        If DataGridView1.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = "TOTAL" Then
                    DataGridView1.Rows.Remove(row)
                End If
            Next
        End If

        '////////////////////////////    TOTAL   ////////////////////////
        'double
        Dim total As Double = 0
        Dim total1 As Double = 0

        For i = 0 To DataGridView1.Rows.Count - 2

            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
            'em negrito
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""



            'total da coluna 3 - NOVO CAPITAL SOCIAL
            total += DataGridView1.Rows(i).Cells(3).Value

            'total de coluna 1 - Porcentagem
            total1 += DataGridView1.Rows(i).Cells(1).Value
            'mudar para % porcentagem
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = total1
            'adiciona %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value & "%"





            '////////////////////////////    FIM TOTAL   ////////////////////////

            'Valor da porcentagem ultrapassou o valor do capital social
            If total > valor Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                Exit Sub
            End If

            'DataGridView1 Cells(1), nao passar de 100, conveter em doble
            If DataGridView1.Rows(i).Cells(1).Value > 100 Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                Exit Sub
            End If
        Next



        'CONVERTER EM REAIS E %
        For i = 0 To DataGridView1.Rows.Count - 1
            'DataGridView1.Rows(i).Cells(3).Value = FormatCurrency(DataGridView1.Rows(i).Cells(3).Value)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total)

        Next




    End Sub
    Private Sub PercaGanho()
        Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)

        ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
        If TextBoxCapitalSocial.Text = "" Then
            MsgBox("Digite o valor do capital social")
            TextBoxCapitalSocial.Focus()
            Exit Sub
        End If

        'coluna 2 e 3 nao podem ser vazio
        If DataGridView1.Rows(0).Cells(2).Value = "" Then
            MsgBox("Coluna 2 não pode ser vazia")
            Exit Sub
        End If



        If DataGridView1.Rows(0).Cells(3).Value = "" Then
            MsgBox("Coluna 3 não pode ser vazia")
            Exit Sub
        End If




        ' cada linha calcular a coluna3 - coluna2 individualmente e converter string para double
        For Each row As DataGridViewRow In DataGridView1.Rows
            'Converter em double em DIM 
            'A cadeia de caracteres 
            'e convertida para um valor double.

            Dim valor1 As Double = CDbl(row.Cells(2).Value)
            Dim valor2 As Double = CDbl(row.Cells(3).Value)



            'calculo da porcentagem
            row.Cells(4).Value = (valor2 - valor1)

            'coluna 3 converte em Double
            row.Cells(4).Value = CDbl(row.Cells(4).Value)
            'converter em reais
            row.Cells(4).Value = FormatCurrency(row.Cells(4).Value)
            'conveter coluna 2 em reais
            row.Cells(2).Value = FormatCurrency(row.Cells(2).Value)




            'pintar em vermelho o valor negativo
            If row.Cells(4).Value < 0 Then
                row.Cells(4).Style.BackColor = Color.Red
                'letra branca
                row.Cells(4).Style.ForeColor = Color.White
                'negrito
                row.Cells(4).Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End If
            'pintar em verde valor positivo
            If row.Cells(4).Value > 0 Then
                row.Cells(4).Style.BackColor = Color.Green
                'letra branca
                row.Cells(4).Style.ForeColor = Color.White
                'negrito
                row.Cells(4).Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End If
        Next


        '// porcentagem //////////////

        For Each row As DataGridViewRow In DataGridView1.Rows
            'calculo da porcentagem na coluna 1
            row.Cells(1).Value = (row.Cells(3).Value / valor) * 100

        Next


        '////////////////////////////    TOTAL   ////////////////////////
        'double
        Dim total1 As Double = 0
        Dim total2 As Double = 0
        Dim total3 As Double = 0
        Dim total4 As Double = 0
        For i = 0 To DataGridView1.Rows.Count - 2

            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
            'em negrito
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""


            'total da coluna 1
            total1 += DataGridView1.Rows(i).Cells(1).Value
            'coloca no final total e colocar %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = total1
            'adiciona %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value & "%"


            'total da coluna 2 - Antigo CAPITAL SOCIAL
            total2 += DataGridView1.Rows(i).Cells(2).Value
            'coloca no final total
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = FormatCurrency(total2)

            'total da coluna 3 - NOVO CAPITAL SOCIAL
            total3 += DataGridView1.Rows(i).Cells(3).Value
            'coloca no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total3)


            'total de coluna 4 - Perda Ganho
            total4 += DataGridView1.Rows(i).Cells(4).Value
            'coloca no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value = FormatCurrency(total4)




            '////////////////////////////    FIM TOTAL   ////////////////////////

            'Valor da porcentagem ultrapassou o valor do capital social
            If total1 > valor Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")
                Exit Sub
            End If

            'DataGridView1 Cells(1), nao passar de 100, conveter em doble
            If DataGridView1.Rows(i).Cells(1).Value > 100 Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                Exit Sub
            End If
        Next




    End Sub

    Private Sub Todos()
        Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)

        'Porcentagem/////////////////////////////////////////////////////////////////////////////////
        ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
        If TextBoxCapitalSocial.Text = "" Then
            MsgBox("Digite o valor do capital social")
            TextBoxCapitalSocial.Focus()
            Exit Sub
        End If

        'cada linha tem seu calculo de porcentagem cell 1,sob o valor da TextBoxCapitalSocial 
        'conveter Double




        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(1).Value = "" Then
                row.Cells(1).Value = 0
            End If


            'calculo da porcentagem
            'Cells(3) porcentagem
            row.Cells(3).Value = (row.Cells(1).Value * valor) / 100
            '///////////////////////////////////////

            'verifica se a coluna esta em reais e deixa apenas numeros
            If row.Cells(1).Value.ToString.Contains("R$") Then
                row.Cells(1).Value = row.Cells(1).Value.ToString.Replace("R$", "")
            End If
            'pega o valor da  coluna 3 - coluna 2 e coloca na coluna 4
            row.Cells(4).Value = row.Cells(3).Value - row.Cells(2).Value
            '///////////////////////////////////////
            'coluna 3 converte em Double
            row.Cells(3).Value = CDbl(row.Cells(3).Value)


            'pega o valor integer da coluna 3 e diminui da coluna 2 e coloca resultado na coluna 4
            ' usar tryparse

            ' 

            'coluna 4 converte em Double
            row.Cells(4).Value = CDbl(row.Cells(4).Value)
            'coluna 4 converte em String
            row.Cells(4).Value = FormatCurrency(row.Cells(4).Value)
            'coluna 3 converte em String
            row.Cells(3).Value = FormatCurrency(row.Cells(3).Value)

        Next





        'depois totalizar o valores das em uma nova linha, e nao repetir o calculo
        'se tiver TOTAL limpas e fazer calculo novamente
        If DataGridView1.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = "TOTAL" Then
                    DataGridView1.Rows.Remove(row)
                End If
            Next
        End If


        '////////////////////////////    TOTAL   ////////////////////////
        'double
        Dim total1 As Double = 0
        Dim total2 As Double = 0
        Dim total3 As Double = 0
        Dim total4 As Double = 0

        For i = 0 To DataGridView1.Rows.Count - 2

            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
            'em negrito
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""

            'total de coluna 1 - Porcentagem
            total1 += DataGridView1.Rows(i).Cells(1).Value
            'mudar para % porcentagem
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = total1
            'adiciona %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value & "%"


            'total da coluna 2 - Antigo CAPITAL SOCIAL
            total2 += DataGridView1.Rows(i).Cells(2).Value
            'coloca no final total
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = FormatCurrency(total2)


            'total da coluna 3 - NOVO CAPITAL SOCIAL
            total3 += DataGridView1.Rows(i).Cells(3).Value
            'total3 no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total3)


            'total de coluna 4 - Perda Ganho
            total4 += DataGridView1.Rows(i).Cells(4).Value
            'em reais o total no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value = FormatCurrency(total4)





            '////////////////////////////    FIM TOTAL   ////////////////////////

            'Valor da porcentagem ultrapassou o valor do capital social
            If total1 > valor Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")
                Exit Sub
            End If

            'DataGridView1 Cells(1), nao passar de 100, conveter em doble
            If DataGridView1.Rows(i).Cells(1).Value > 100 Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                Exit Sub
            End If
        Next





        'PERCA E GANHA///////////////////////////////////////////////////////////////////////////
        'coluna 2 e 3 nao podem ser vazio
        If DataGridView1.Rows(0).Cells(2).Value = "" Then
            MsgBox("Coluna 2 não pode ser vazia")
            Exit Sub
        End If



        If DataGridView1.Rows(0).Cells(3).Value = "" Then
            MsgBox("Coluna 3 não pode ser vazia")
            Exit Sub
        End If




        ' cada linha calcular a coluna3 - coluna2 individualmente e converter string para double
        For Each row As DataGridViewRow In DataGridView1.Rows
            'Converter em double em DIM 


            'pintar em vermelho o valor negativo
            If row.Cells(4).Value < 0 Then
                row.Cells(4).Style.BackColor = Color.Red
                'letra branca
                row.Cells(4).Style.ForeColor = Color.White
                'negrito
                row.Cells(4).Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End If
            'pintar em verde valor positivo
            If row.Cells(4).Value > 0 Then
                row.Cells(4).Style.BackColor = Color.Green
                'letra branca
                row.Cells(4).Style.ForeColor = Color.White
                'negrito
                row.Cells(4).Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End If
        Next


    End Sub


    Private Sub Limpar()
        'limpaar
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        'limpa a formatação do datagridview
    End Sub

    Private Sub ButtonPorcentagem_Click(sender As Object, e As EventArgs) Handles ButtonPorcentagem.Click

        'Porcentagem
        'PercaGanho
        'Todos
        Try
            TextBoxCapitalSocial.Text = TextBoxCapitalSocial.Text.Replace("R$", "")
            TextBoxCapitalSocial.Text = TextBoxCapitalSocial.Text.Replace(".", "")
            TextBoxCapitalSocial.Text = TextBoxCapitalSocial.Text.Replace(" ", "")

            'verifica se tem apenas valor na coluna 1 e as outras colunas vazias , e chama Porcentagem
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.Rows(0).Cells(1).Value <> "" And DataGridView1.Rows(0).Cells(2).Value = "" And DataGridView1.Rows(0).Cells(3).Value = "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    Porcentagem()
                    'verifica se tem apenas valor na coluna 2  e 3 e as outras colunas vazias, e chama PercaGanho
                ElseIf DataGridView1.Rows(0).Cells(1).Value = "" And DataGridView1.Rows(0).Cells(2).Value <> "" And DataGridView1.Rows(0).Cells(3).Value <> "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    PercaGanho()
                ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" And DataGridView1.Rows(0).Cells(2).Value <> "" And DataGridView1.Rows(0).Cells(3).Value = "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    Todos()
                ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" And DataGridView1.Rows(0).Cells(2).Value <> "" And DataGridView1.Rows(0).Cells(3).Value <> "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    DataGridView1.Refresh()
                    'Todos()
                    'mgs ação nao permitida após calculo feito
                    MsgBox("Não é possivel realizar mais de um calculo, após o calculo ser realizado, não é possivel realizar outro calculo", MsgBoxStyle.Information, "Aviso")

                End If

            End If

            'muda novamente reais
            TextBoxCapitalSocial.Text = FormatCurrency(TextBoxCapitalSocial.Text)

        Catch ex As Exception
            MsgBox("Um calculo não foi realizado, verifique se todos os campos estão preenchidos corretamente", MsgBoxStyle.Information, "Aviso")
            'limpar todas colunas e linhas, menos a primeira coluna 
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For j As Integer = 1 To DataGridView1.Columns.Count - 1
                    DataGridView1.Rows(i).Cells(j).Value = ""
                Next
            Next
            DataGridView1.Refresh()
        End Try

    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        Limpar()
    End Sub


    Private Sub BtnADDSocioCapital_Click(sender As Object, e As EventArgs) Handles BtnADDSocioCapital.Click
        Dim NomeCompleto As String = NomeCompletoTextBox.Text

        If MsgBox("Deseja adicionar " & NomeCompleto & " na calculadora de capital social?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'copiar NomeCompletoTextBox e adicionar
            'DataGridView1 adicionar uma nova linha nomecompleto
            'verificar se tem preenchido a linha e adicionar uma nova
            If DataGridView1.Rows.Count = 0 Then
                DataGridView1.Rows.Add(NomeCompleto)
            Else
                'verificar se o nome já existe
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells(0).Value = NomeCompleto Then
                        MsgBox("Nome já existe", MsgBoxStyle.Exclamation, "Atenção")
                        Exit Sub
                    End If
                Next
                DataGridView1.Rows.Add(NomeCompleto)
            End If
        Else

        End If

    End Sub



    'TextBoxCapitalSocial usar mascara em reais
    Private Sub TextBoxCapitalSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCapitalSocial.KeyPress
        ' If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
        ' e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        'e.Handled = False
        ' Else
        'e.Handled = True
        ' End If
    End Sub
    'CapitalSTextBox validar em reais
    Private Sub TextBoxCapitalSocial_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCapitalSocial.LostFocus
        If TextBoxCapitalSocial.Text = "" Then
            TextBoxCapitalSocial.Text = "0,00"
        Else
            TextBoxCapitalSocial.Text = FormatCurrency(TextBoxCapitalSocial.Text)
        End If
    End Sub

    Private Sub BtnCapitalEmpresas_Click(sender As Object, e As EventArgs) Handles BtnCapitalEmpresas.Click
        '////////////////////// NOME DO SOCIO + CAPITAL ///////////////////////////////
        ''verificar se frmEmpresas esta aberto
        If FrmLegalizacao.Visible = True Then
            FrmLegalizacao.Focus()
            'ativar TabControle 1
            FrmLegalizacao.TabControl1.SelectedIndex = 1
            'TabControl2 5
            FrmLegalizacao.TabControl2.SelectedIndex = 6

            For Each row As DataGridViewRow In DataGridView1.Rows
                ''para cada linha pegar nome do socio da coluna 0 e capital da coluna 3 da datagridview1
                'colocar dentro frmlegalizacao.DivisaoCapitalSociosRichTextBox.text
                If row.Cells(0).Value <> "" Then
                    If row.Cells(0).Value <> "Total:" Then
                        Dim NomeSocio As String = row.Cells(0).Value
                        Dim CapitalSocio As String = row.Cells(3).Value

                        '////////////////////// INICIO NOME PEQUENO DO SOCIO ///////////////////////////////   
                        'mudar de "ROGERIO STRANIERI SILVA" para "Rogerio Stranieri Silva" 
                        Dim NomePequeno2 As String = NomeSocio.ToLower
                        'mudar de "rogerio stranieri silva" para "Rogerio Stranieri Silva"
                        NomePequeno2 = StrConv(NomePequeno2, VbStrConv.ProperCase)
                        'mudar de "Rogerio Stranieri Silva" para "Rogerio Stranieri Silva"


                        '////////////////////// FIM NOME PEQUENO DO SOCIO ///////////////////////////////   

                        'EXPORTAR /////////////////////////
                        FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text = FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text & NomePequeno2 & " - " & CapitalSocio & vbCrLf
                        'FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text = FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text & row.Cells(0).Value & " - " & row.Cells(3).Value & vbNewLine

                        'excluir a linha que tem excreito "TOTAL:" do FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text
                        If row.Cells(0).Value = "Total:" Then
                            FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text = FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text.Substring(0, FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text.Length - 2)
                        End If

                    Else
                        'mgsbox para não adicionar linha total
                        MsgBox("Efetuar o calculo antes de exportar", MsgBoxStyle.Information, "Aviso")
                    End If
                End If
            Next
        Else
            'mgsbox abrir formulario empresas
            MsgBox("Impossivel exportar pois o formulario empresas não está aberto!", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub GeneroComboBox_TextUpdate(sender As Object, e As EventArgs) Handles GeneroComboBox.TextUpdate
        EstadoCivil()
    End Sub

    Private Sub RGTextBox_Validated(sender As Object, e As EventArgs) Handles RGTextBox.Validated
        RGTextBox.Text = ApenasNumeros(RGTextBox.Text)

        Dim RG As String = RGTextBox.Text
        If RGTextBox.Text.Length = 8 Then
            RG = RG.Substring(0, 1) & "." & RG.Substring(1, 3) & "." & RG.Substring(4, 3) & "-" & RG.Substring(7, 1)
            RGTextBox.Text = RG
        ElseIf RGTextBox.Text.Length = 9 Then

            RG = RG.Substring(0, 2) & "." & RG.Substring(2, 3) & "." & RG.Substring(5, 3) & "-" & RG.Substring(8, 1)
            RGTextBox.Text = RG
        End If

    End Sub

    Private Sub BtnConsultaCPF_Click(sender As Object, e As EventArgs) Handles BtnConsultaCPF.Click
        'verificar se tem CPF e Data de nascimento preenchido
        If CPFMaskedTextBox.Text <> "   .   .   -" And DatadeNascMaskedTextBox.Text <> "  /  /" Then
            'verificar se o CPF é valido
            'verificar se o WEBConsultaCPF está aberto
            If WebSiteGERAL.Visible = True Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.WebView.Source = New Uri("https://servicos.receita.fazenda.gov.br/servicos/cpf/consultasituacao/consultapublica.asp")
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.Focus()
                WebSiteGERAL.WebView.Source = New Uri("https://servicos.receita.fazenda.gov.br/servicos/cpf/consultasituacao/consultapublica.asp")

            End If
        Else
            'mgsbox preencher
            MsgBox("Preencher o CPF e a data de nascimento", MsgBoxStyle.Information, "Aviso")
        End If


    End Sub

    Private Sub CivilTextBox_Click(sender As Object, e As EventArgs) Handles CivilTextBox.Click
        'abrir a ListBoxEstadoCivil de baixo do CivilTextBox
        ListBoxEstadoCivil.Visible = True
        ListBoxEstadoCivil.Top = CivilTextBox.Top + CivilTextBox.Height + 5
        ListBoxEstadoCivil.Left = CivilTextBox.Left
        ListBoxEstadoCivil.Width = CivilTextBox.Width
        ListBoxEstadoCivil.Height = CivilTextBox.Height
        ListBoxEstadoCivil.BringToFront()
        ListBoxEstadoCivil.Focus()
        ListBoxEstadoCivil.Items.Clear()
        'carregar os itens "empresario" "empresaria"
        EstadoCivil()
        'auto size para o tamanho do ListBoxEstadoCivil
        ListBoxEstadoCivil.AutoSize = True

        'clicar na seleção no ListBoxGeral e mudar o ProfissãoTextBox.text
        AddHandler ListBoxEstadoCivil.Click, AddressOf ListBoxEstadoCivil_Click
    End Sub

    Private Sub ListBoxEstadoCivil_Click(sender As Object, e As EventArgs) Handles ListBoxEstadoCivil.Click
        'CivilTextBox
        CivilTextBox.Text = ListBoxEstadoCivil.Text
        'fechar o ListBoxGeral  
        ListBoxEstadoCivil.Visible = False
    End Sub


    Private Sub ListBoxEstadoCivil_Leave(sender As Object, e As EventArgs) Handles ListBoxEstadoCivil.Leave
        ListBoxEstadoCivil.Visible = False
    End Sub



    Private Sub OrgaoRGTextBox_Validated(sender As Object, e As EventArgs) Handles OrgaoRGTextBox.Validated
        'OrgaoRGTextBox.Text   ModTexto.TodoMaiusculo
        OrgaoRGTextBox.Text = OrgaoRGTextBox.Text.ToUpper()
        'LimpaTexto
        LimpaTexto(OrgaoRGTextBox.Text)
    End Sub

    Private Sub EstadoRGTextBox_Validated(sender As Object, e As EventArgs) Handles EstadoRGTextBox.Validated
        'OrgaoRGTextBox.Text   ModTexto.TodoMaiusculo
        EstadoRGTextBox.Text = EstadoRGTextBox.Text.ToUpper()
        'LimpaTexto
        LimpaTexto(EstadoRGTextBox.Text)
    End Sub

    Private Sub BtnConsultarTituloDeEleitor_Click(sender As Object, e As EventArgs) Handles BtnConsultarTituloDeEleitor.Click
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

    Private Sub NomeCompletoTextBox_Validated(sender As Object, e As EventArgs) Handles NomeCompletoTextBox.Validated
        '   ModTexto.TodoMaiusculo
        NomeCompletoTextBox.Text = NomeCompletoTextBox.Text.ToUpper()
        'tirar todos caraceteres especiais
        LimpaTexto(NomeCompletoTextBox.Text)
    End Sub

    Private Sub NomeMaeTextBox_Validated(sender As Object, e As EventArgs) Handles NomeMaeTextBox.Validated
        'ToUpper
        NomeMaeTextBox.Text = NomeMaeTextBox.Text.ToUpper()
        'LimpaTexto
        LimpaTexto(NomeMaeTextBox.Text)
    End Sub

    Private Sub NomePaiTextBox_Validated(sender As Object, e As EventArgs) Handles NomePaiTextBox.Validated
        'ToUpper
        NomePaiTextBox.Text = NomePaiTextBox.Text.ToUpper()
        'LimpaTexto
        LimpaTexto(NomePaiTextBox.Text)
    End Sub

    Private Sub CivilTextBox_Validated(sender As Object, e As EventArgs) Handles CivilTextBox.Validated
        'aumentar tamanho CivilTextBox conforme tamanho do texto
        If CivilTextBox.Text = "" Then
            CivilTextBox.Width = 118
        Else
            CivilTextBox.Width = CivilTextBox.Text.Length * 6
        End If
    End Sub

    Private Sub TituloDeEleitorTextBox_Validated(sender As Object, e As EventArgs) Handles TituloDeEleitorTextBox.Validated
        TituloDeEleitorTextBox.Text = ApenasNumeros(TituloDeEleitorTextBox.Text)

    End Sub

    Private Sub CivilTextBox_TextChanged(sender As Object, e As EventArgs) Handles CivilTextBox.TextChanged
        'aumentar tamanho CivilTextBox conforme tamanho do texto
        If CivilTextBox.Text = "" Then
            CivilTextBox.Width = 118
        Else
            CivilTextBox.Width = CivilTextBox.Text.Length * 7
        End If
    End Sub

    Private Sub BtnAtalhoEndereco_Click(sender As Object, e As EventArgs) Handles BtnAtalhoEndereco.Click, BtnAtalhoEndereco3.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BtnAtalhoConjuge_Click(sender As Object, e As EventArgs) Handles BtnAtalhoConjuge.Click, BtnAtalhoConjuge2.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub BtnAtablhoSocio_Click(sender As Object, e As EventArgs) Handles BtnAtablhoSocio.Click, BtnAtablhoSocio3.Click
        TabControl1.SelectedIndex = -1
    End Sub

    Private Sub TextBoxCapitalSocial_Validated(sender As Object, e As EventArgs) Handles TextBoxCapitalSocial.Validated
        'transforma em reais
        TextBoxCapitalSocial.Text = FormatCurrency(TextBoxCapitalSocial.Text)
    End Sub


    Private Sub ConsultarCPFNoBanco()
        'verificar se o CPF contem no banco de dados PrinceDBDataSet.Socios
        If CPFMaskedTextBox.Text <> "" Then
            Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim sql As String = "select count(*) from Socios where CPF=@CPF"
            Dim con As New SqlConnection(str)
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@CPF", CPFMaskedTextBox.Text)
            con.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()
            If count > 0 Then
                'ver duplicidade de cpf
                MsgBox("CPF já cadastrado no banco de dados", MsgBoxStyle.Critical, "CPF Duplicado")
                BtnDuplicidade.Visible = False
                Dim CPF As String = CPFMaskedTextBox.Text
                ' cancelar
                Me.SociosBindingSource.CancelEdit()
                BloquearEdicao()
                TextBoxExtensoDN.Visible = False
                'mostrar o CPF que ja tem cadastrado
                'CPFComboBox
                CPFComboBox.Text = CPF
                CPFComboBox.Focus()
            Else
                MessageBox.Show("CPF não cadastrado no banco de dados")
            End If
        Else
            MessageBox.Show("CPF está vazio")
        End If

    End Sub

    Private Sub BtnDuplicidade_Click(sender As Object, e As EventArgs) Handles BtnDuplicidade.Click
        ConsultarCPFNoBanco()

    End Sub

    Private Sub BtnCopiarSenhaGov_Click(sender As Object, e As EventArgs) Handles BtnCopiarSenhaGov.Click
        Try
            ' Obter o texto da SenhaGOVTextBox
            Dim senha As String = SenhaGOVTextBox.Text

            ' Verificar se o campo está vazio
            If String.IsNullOrEmpty(senha) Then
                MessageBox.Show("O campo de senha está vazio. Por favor, insira uma senha válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Remover os asteriscos (*) da senha
            Dim senhaSemAsterisco As String = senha.Replace("*", "")

            ' Copiar a senha sem os asteriscos para a área de transferência
            Clipboard.SetText(senhaSemAsterisco)

            ' Informar ao usuário que a senha foi copiada
            MessageBox.Show("Senha copiada para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Tratar qualquer erro inesperado
            MessageBox.Show("Ocorreu um erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SenhaGOVTextBox_Click(sender As Object, e As EventArgs) Handles SenhaGOVTextBox.Click
        'mostrar senha sem os *
        SenhaGOVTextBox.PasswordChar = ""

    End Sub

    Private Sub SenhaGOVTextBox_Leave(sender As Object, e As EventArgs) Handles SenhaGOVTextBox.Leave
        'mudar para senha
        SenhaGOVTextBox.PasswordChar = "*"
    End Sub



    '//////////////////////////////////////////  exportar socio para alvara //////////////////////////////
    Private Sub AddSocioRequerente()
        Dim Nome As String = NomeCompletoTextBox.Text
        Dim CPF As String = CPFMaskedTextBox.Text
        Dim RG As String = RGTextBox.Text
        Dim OrgaoRG As String = OrgaoRGTextBox.Text
        Dim EstRG As String = EstadoRGTextBox.Text

        FrmAlvara.RequerenteTextBox.Text = Nome
        FrmAlvara.RGRequerenteTextBox.Text = RG
        FrmAlvara.CPFRequerenteMaskedTextBox.Text = CPF
        FrmAlvara.OrgaoRGRequerenteTextBox.Text = OrgaoRG
        FrmAlvara.EstadoOrgaoRGRequerenteTextBox.Text = EstRG
    End Sub

    Private Sub BtnExportaSocioLaudo_Click(sender As Object, e As EventArgs) Handles BtnExportaSocioLaudo.Click
        Try
            If FrmAlvara.Visible = True Then
                FrmAlvara.Focus()
                Dim NomeEmpresa As String = FrmAlvara.RazaoSocialTextBox.Text
                Dim NomeSocio As String = NomeCompletoTextBox.Text

                If MsgBox("Deseja exportar os dados do " & NomeSocio & " para Empresa " & NomeEmpresa & " ?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    AddSocioRequerente()
                End If
            Else
                FrmAlvara.Show()
                ' ExportarDados()
                'mgsbox abrir a empresa onde deseja exportar
                MsgBox("Abrir a empresa onde deseja exportar!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCopiaCEP_Click(sender As Object, e As EventArgs) Handles BtnCopiaCEP.Click
        Try
            ' Obter o texto do CEPMaskedTextBox
            Dim cep As String = CEPMaskedTextBox.Text.Trim()

            ' Verificar se o campo está vazio
            If String.IsNullOrEmpty(cep) Then
                MessageBox.Show("O campo de CEP está vazio. Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Remover o hífen
            Dim cepSemHifen As String = cep.Replace("-", "")

            ' Copiar o resultado para a área de transferência
            Clipboard.SetText(cepSemHifen)

            ' Informar ao usuário que o CEP foi copiado
            '  MessageBox.Show("CEP copiado para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Tratar qualquer erro inesperado
            MessageBox.Show("Ocorreu um erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnCopiarCPF_Click(sender As Object, e As EventArgs) Handles BtnCopiarCPF.Click
        Try
            ' Obter o texto do CPFMaskedTextBox
            Dim CPF As String = CPFMaskedTextBox.Text.Trim()

            ' Verificar se o CPF está vazio ou inválido
            If String.IsNullOrEmpty(CPF) Then
                MessageBox.Show("O campo de CPF está vazio. Por favor, insira um CPF válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Remover o hífen e os pontos
            Dim CPFLimpo As String = CPF.Replace("-", "").Replace(".", "")

            ' Verificar se o CPF tem o tamanho correto (11 dígitos)
            If CPFLimpo.Length <> 11 Then
                MessageBox.Show("CPF inválido. Um CPF deve ter 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Copiar o CPF limpo para a área de transferência
            Clipboard.SetText(CPFLimpo)

            ' Informar ao usuário que o CPF foi copiado
            '  MessageBox.Show("CPF copiado para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Tratar qualquer erro inesperado
            MessageBox.Show("Ocorreu um erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnParcelamentos_Click(sender As Object, e As EventArgs) Handles BtnParcelamentos.Click
        Try
            ' Verifica se o FrmParcelamentos já está aberto
            Dim frmParcelamentosAberto As Boolean = False
            Dim formParcelamentosInstanciado As FrmParcelamento = Nothing

            ' Procura pelo formulário entre os forms abertos
            For Each form In Application.OpenForms
                If TypeOf form Is FrmParcelamento Then
                    frmParcelamentosAberto = True
                    formParcelamentosInstanciado = CType(form, FrmParcelamento)
                    Exit For
                End If
            Next

            If frmParcelamentosAberto Then
                ' Se o formulário estiver aberto, foca nele e ativa a aba
                formParcelamentosInstanciado.Focus()

                ' Pega as informações do FrmSocio
                Dim NomeSocio As String = NomeCompletoTextBox.Text
                Dim CPF As String = CPFMaskedTextBox.Text
                Dim SenhaGOV As String = SenhaGOVTextBox.Text

                ' Ativa a aba 3 do TabControlPrincipal no FrmParcelamentos
                'formParcelamentosInstanciado.TabControlPrincipal.SelectedTab = formParcelamentosInstanciado.TabControlPrincipal.TabPages(3)

                ' Preenche os campos do FrmParcelamentos
                ' formParcelamentosInstanciado.SocioResponsavelTextBox.Text = NomeSocio
                ' formParcelamentosInstanciado.CPFsocioResponsavelMaskedTextBox.Text = CPF
                ' formParcelamentosInstanciado.GovSenhaMaskedTextBox.Text = SenhaGOV
            Else
                ' Se o formulário não estiver aberto, cria e abre o formulário
                'Dim newFrmParcelamentos As New FrmParcelamentos()
                ' newFrmParcelamentos.Show()

                ' Mensagem de aviso
                MsgBox("Abrir o formulário de Parcelamentos antes de prosseguir.")
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub


    Private Sub ValidaIdadeMenor()
        ' Limpar estado inicial
        LblMenorIdade.Visible = False
        MenorIdadeComboBox.Visible = False
        If Not String.IsNullOrEmpty(MenorIdadeComboBox.Text) Then
            MenorIdadeComboBox.Text = ""
        End If

        ' Verificar se a data é válida
        Dim dataNascimento As Date
        If Date.TryParse(DatadeNascMaskedTextBox.Text, dataNascimento) Then
            ' Obter a data atual
            Dim dataAtual As Date = Date.Now

            ' Calcular a idade
            Dim idade As Integer = dataAtual.Year - dataNascimento.Year

            ' Verificar se o aniversário ainda não ocorreu neste ano
            If dataAtual < dataNascimento.AddYears(idade) Then
                idade -= 1
            End If

            ' Verificar se é menor de idade
            If idade < 18 Then
                LblMenorIdade.Visible = True
                MenorIdadeComboBox.Visible = True
            End If
        Else
            ' Caso a data seja inválida
            MessageBox.Show("Por favor, insira uma data de nascimento válida.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DatadeNascMaskedTextBox.Focus()
        End If
    End Sub

    Private Sub DatadeNascMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles DatadeNascMaskedTextBox.Leave
        ValidaIdadeMenor()
    End Sub

    Private Sub SociosBindingSource_CurrentChanged(sender As Object, e As EventArgs)
        ValidaIdadeMenor()
        AtualizarDataGridView()
    End Sub


    Private Sub BtnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles BtnBuscarEmpresa.Click
        ConsultaEmpresa()
    End Sub

    Private Sub ConsultaEmpresa()
        Dim nomeSocio As String = NomeCompletoTextBox.Text.Trim()

        If String.IsNullOrWhiteSpace(nomeSocio) Then
            MessageBox.Show("Por favor, insira o nome do sócio para a busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Alterando a consulta para incluir a coluna "Processo"
                Dim query As String = "SELECT Processo, RazaoSocial, CNPJ, DadosSocios FROM Empresas WHERE DadosSocios LIKE @NomeSocio OR ResponsavelNome LIKE @NomeSocio OR NomeResponsavel LIKE @NomeSocio ORDER BY RazaoSocial ASC"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NomeSocio", "%" & nomeSocio & "%")

                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Criar nova coluna "Status"
                    If Not dataTable.Columns.Contains("Status") Then
                        dataTable.Columns.Add("Status", GetType(String))
                    End If

                    ' Percorre cada linha para calcular o Status
                    For Each row As DataRow In dataTable.Rows
                        Dim dadosSocios As String = row("DadosSocios").ToString()
                        row("Status") = ExtrairStatus(dadosSocios, nomeSocio)
                    Next

                    ' Exibir os dados no DataGridView
                    DataGridViewEmpresa.DataSource = dataTable
                    DataGridViewEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    DataGridViewEmpresa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    DataGridViewEmpresa.Sort(DataGridViewEmpresa.Columns("RazaoSocial"), System.ComponentModel.ListSortDirection.Ascending)

                    ' Esconder a coluna "DadosSocios"
                    If DataGridViewEmpresa.Columns.Contains("DadosSocios") Then
                        DataGridViewEmpresa.Columns("DadosSocios").Visible = False
                    End If

                    ' Esconder a coluna "Processo" se necessário, ou apenas para exibição
                    If DataGridViewEmpresa.Columns.Contains("Processo") Then
                        ' Opcional: Ajuste conforme necessário, se quiser esconder ou alterar algo específico
                        DataGridViewEmpresa.Columns("Processo").Visible = True
                    End If

                    ' Atualizar contagem de empresas encontradas
                    LblContaEmpresa.Text = "Total de Empresas Encontradas: " & dataTable.Rows.Count.ToString()

                    If dataTable.Rows.Count = 0 Then
                        MessageBox.Show("Nenhuma empresa encontrada para o sócio informado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar empresas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Função para extrair o status correto baseado no nome
    Private Function ExtrairStatus(dados As String, nome As String) As String
        ' Verifica se os dados não são nulos ou vazios
        If String.IsNullOrEmpty(dados) Then Return "Desconhecido"

        ' Encontrar a posição do nome dentro do texto
        Dim posNome As Integer = dados.IndexOf(nome, StringComparison.OrdinalIgnoreCase)
        If posNome = -1 Then Return "Desconhecido" ' Nome não encontrado

        ' Declara a variável statusTexto uma única vez
        Dim statusTexto As String

        ' Verifica se o nome está no início dos dados (caso do primeiro sócio)
        If posNome = 0 Then
            ' Extrai o status diretamente, assumindo que o status está no início
            statusTexto = dados.Substring(0, dados.IndexOf(": Sócio Nº")).Trim()
            Return statusTexto
        End If

        ' Agora buscamos o texto que vem antes do nome do sócio
        ' Vamos procurar o padrão ': Sócio Nº' que marca o início do bloco de informações do sócio
        Dim posSocioN As Integer = dados.LastIndexOf(": Sócio Nº", posNome)
        If posSocioN = -1 Then Return "Desconhecido" ' Não encontrou o bloco do sócio

        ' Agora buscamos o marcador "/////" que indica o início da linha com a informação de status
        Dim posBarra As Integer = dados.LastIndexOf("/////", posSocioN)
        If posBarra = -1 Then
            ' Se não encontrar o marcador "/////", assume que o status está no início
            statusTexto = dados.Substring(0, posSocioN).Trim()
            Return statusTexto
        End If

        ' Extrai o texto entre o marcador "/////" e o texto ": Sócio Nº", que é o status
        statusTexto = dados.Substring(posBarra + 5, posSocioN - (posBarra + 5)).Trim()

        ' Retorna o texto encontrado (status)
        Return statusTexto
    End Function





    Private Sub DataGridViewEmpresa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmpresa.CellDoubleClick
        ' Verifica se a célula clicada é válida
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cnpjValue As String = DataGridViewEmpresa.Rows(e.RowIndex).Cells(2).Value.ToString().Trim()
            Dim razaoSocialValue As String = DataGridViewEmpresa.Rows(e.RowIndex).Cells(1).Value.ToString().Trim()

            ' Verifica se o formulário já está aberto
            If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
                MsgBox("O formulário já está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
                FrmLegalizacao.Focus()
            Else
                FrmLegalizacao.Show()
            End If

            ' Apenas define o ComboBox se houver itens nele
            If FrmLegalizacao.ComboBoxBuscaEmpresa.Items.Count > 0 Then
                FrmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocialValue
                FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
            End If

            If FrmLegalizacao.ComboBoxBuscaCNPJ.Items.Count > 0 Then
                FrmLegalizacao.ComboBoxBuscaCNPJ.Text = cnpjValue
                FrmLegalizacao.ComboBoxBuscaCNPJ.Focus()
            End If
        End If
    End Sub
End Class