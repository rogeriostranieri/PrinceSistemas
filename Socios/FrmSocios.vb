Imports System.Data.SqlClient

Public Class FrmSocios
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
        ComboBox1.SelectedIndex = 0


    End Sub

    Private Sub BloquearEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = False
        GroupBoxOutrosDados.Enabled = False
        GroupBoxConjuge.Enabled = False

    End Sub

    Private Sub LiberarEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = True
        GroupBoxOutrosDados.Enabled = True
        GroupBoxConjuge.Enabled = True
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
            GeneroComboBox.SelectedIndex = 0
            ListBoxEstadoCivil.SelectedIndex = 0

            TextBoxExtensoDN.Visible = False
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'perguntar, editar ou não
        ' If MessageBox.Show("Deseja editar o registro?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        LiberarEdicao()
        TextBoxExtensoDN.Visible = False
        ' End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'perguntar, salvar dados
        If MsgBox("Deseja salvar os dados?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'salvar dados
            Me.Validate()
            Me.SociosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            MessageBox.Show("Dados salvos com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BloquearEdicao()
            TextBoxExtensoDN.Visible = False
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'cancelar ediçao
        If MsgBox("Deseja cancelar a edição?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'cancelar ediçao
            Me.SociosBindingSource.CancelEdit()
            BloquearEdicao()
            TextBoxExtensoDN.Visible = False
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'perguntar, e excluir dados
        If MsgBox("Deseja excluir os dados?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'excluir dados
            Me.SociosBindingSource.RemoveCurrent()
            Me.Validate()
            Me.SociosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            BloquearEdicao()
            TextBoxExtensoDN.Visible = False
        End If
    End Sub

    'ao digitar no CPFComboBox mudar para formato CPF
    Private Sub CPFComboBox_TextChanged(sender As Object, e As EventArgs)
        'ao digitar converter para cpf
        CPFComboBox.Text = Format(CPFComboBox.Text, "000\.000\.000\-00")

    End Sub

    Private Sub BtnCorreios_Click(sender As Object, e As EventArgs) Handles BtnCorreios.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                'Using WS = New WSCorreios.AtendeClienteClient()
                Dim Resultado = WS.consultaCEP(CEPMaskedTextBox.Text)
                RUATextBox.Text = Resultado.[end]
                Dim Rua As String = RUATextBox.Text
                'primeira letra minuscula
                Rua = Rua.Substring(0, 1).ToLower() & Rua.Substring(1)
                RUATextBox.Text = Rua

                'EndComplementoTextBox.Text = Resultado.complemento
                ComplementoTextBox.Text = Resultado.complemento2
                CidadeTextBox.Text = Resultado.cidade
                BairroTextBox.Text = Resultado.bairro
                EstadoTextBox.Text = Resultado.uf
                ' mgs de erro

            Catch Ex As Exception
                ' MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])

                If MsgBox(" Deseja Buscar CEP correto no site dos correios?", MsgBoxStyle.YesNo, "Busca CEP") = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start("https://buscacepinter.correios.com.br/app/endereco/index.php")
                Else

                End If
            End Try

        End Using
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
        Dim NomeEmpresa As String = FrmLegalizacao.RazaoSocialTextBox.Text
        Dim NomeSocio As String = NomeCompletoTextBox.Text
        Try
            'perguntar antes
            'mgsbox em negrito
            If MsgBox("Deseja exportar os dados do " & NomeSocio & " para Empresa " & NomeEmpresa & " ?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                AtivarTab()

                If FrmLegalizacao.Visible = True Then
                    FrmLegalizacao.Focus()
                    ExportarDados()
                    Me.Close()
                Else
                    FrmLegalizacao.Show()
                    ' ExportarDados()
                    'mgsbox abrir a empresa onde deseja exportar
                    MsgBox("Abrir a empresa onde deseja exportar!")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub AddSocios()
        Try

            'ativar TabControle 1
            FrmLegalizacao.TabControl1.SelectedIndex = 1

            'aativar TabControl2 0
            FrmLegalizacao.TabControl2.SelectedIndex = 1

            'Dados
            Dim CPF As String = CPFMaskedTextBox.Text
            Dim NomeCompleto As String = NomeCompletoTextBox.Text
            Dim NomeDaMae As String = NomeMaeTextBox.Text
            Dim NomeDaPai As String = NomePaiTextBox.Text

            'clicar no BtnExtensoDN
            DataDeNascExtenso()
            Dim DataDeNascimento As String = TextBoxExtensoDN.Text


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
            'primeira letra da RUA em minusculo
            Dim RUA1 As String = RUA.Substring(0, 1).ToLower() & RUA.Substring(1)
            Dim N As String = NumTextBox.Text
            Dim Compl As String = ComplementoTextBox.Text
            Dim Bairro As String = BairroTextBox.Text
            Dim CEP As String = CEPMaskedTextBox.Text
            Dim Cidade As String = CidadeTextBox.Text
            Dim Estado As String = EstadoTextBox.Text
            Dim Portador As String
            Dim Brasileiro As String
            Dim Nascido As String

            'verificar se está no masculino ou feminio no campo GeneroComboBox
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



            'não permitir o mesmo CPF dentro do FrmLegalizacao.DadosSociosRichTextBox
            If FrmLegalizacao.DadosSociosRichTextBox.Text.Contains(CPF) Then
                MsgBox("CPF já cadastrado", MsgBoxStyle.Exclamation, "Atenção")




                If MsgBox("Deseja adicionar o novo cadastro?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    'procurar o CPF no FrmLegalizacao.DadosSociosRichTextBox
                    Dim Posição As Integer = FrmLegalizacao.DadosSociosRichTextBox.Find(CPF)
                    'Novos dados na linha de baixo
                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Remove(Posição, CPF.Length)

                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Insert(Posição, "

Novos dados:" + " 

" & NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", Nº: " & N & "" & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG Nº " & RG & " " & OrgaoRG & "/" & EstadoRG & ", e do CPF Nº " & CPF & "." & vbCrLf & "
" + vbCrLf)


                End If

            Else



                'Contagem de Socios
                If FrmLegalizacao.QuantidadeSociosTextBox.Text = "" Then
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = "1"
                Else
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = FrmLegalizacao.QuantidadeSociosTextBox.Text + 1
                End If

                Dim QuantidadeSocios As Integer = FrmLegalizacao.QuantidadeSociosTextBox.Text



                'FORMA FINAL
                FrmLegalizacao.DadosSociosRichTextBox.SelectedText &=
" Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////

" & NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", Nº: " & N & "" & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG Nº " & RG & " " & OrgaoRG & "/" & EstadoRG & ", e do CPF Nº " & CPF & "." & vbCrLf & "
//////////////////////////////////////////////////////////////////////
"


            End If

            'Focar na frente o FrmLegalizacao
            FrmLegalizacao.Focus()
            FrmLegalizacao.DadosSociosRichTextBox.Focus()

            Me.Close()



        Catch ex As Exception
            ' MsgBox "Preencha todos os campos obrigatórios" + Message
            MsgBox("Preencha todos os campos obrigatórios", MsgBoxStyle.Exclamation, "Atenção")
            Me.Focus()
        End Try

    End Sub
    Private Sub BtnAddSocios_Click(sender As Object, e As EventArgs) Handles BtnAddSocios.Click
        Dim NomeEmpresa As String = FrmLegalizacao.RazaoSocialTextBox.Text
        Dim NomeSocio As String = NomeCompletoTextBox.Text
        Try
            'perguntar antes
            'mgsbox em negrito
            If MsgBox("Deseja exportar os dados do " & NomeSocio & " para Empresa " & NomeEmpresa & " ?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                AtivarTab()

                If FrmLegalizacao.Visible = True Then
                    AtivarTab()
                    AddSocios()

                Else
                    FrmLegalizacao.Show()
                    ' ExportarDados()
                    'mgsbox abrir a empresa onde deseja exportar
                    MsgBox("Abrir a empresa onde deseja exportar!")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
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
        'verificar se foi selecinado o combobox1
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Selecione um número de sócio", MsgBoxStyle.Exclamation, "Atenção")
            ComboBox1.Focus()
            Exit Sub

        Else
            'verificar se ExportarContratoWordDialog está aberto e focar
            AtivarTab()

            If ExportarContratoWordDialog.Visible = True Then
                ExportarContratoWordDialog.Focus()
            ElseIf ExportarLaudoWordDialog.Visible = True Then
                ExportarContratoWordDialog.Focus()
            Else
                MsgBox("Favor, abrir o formulário para exportação empresas ou alvará!")
            End If


            'ExportarLaudoWordDialog
        End If

    End Sub

    Private Sub BtnCapitalSocial_Click(sender As Object, e As EventArgs) Handles BtnCapitalSocial.Click
        '"Abrir Calculadora Capítal Social" ao apertar fica precionado e com texto alterado para "Fechar Calculadora Capítal Social"
        If BtnCapitalSocial.Text = "Abrir Calculadora Capítal Social" Then
            AtivarTab()
            BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social"
            GroupBoxCapitalSocial.Visible = True
            GroupBoxMenuCapitalSocial.Visible = True
            GroupBoxMenuCapitalSocial.Enabled = True
            GroupBoxCapitalSocial.Enabled = True
            'aumentar tamanho do frmsocios para 748; 631
            Me.Size = New Size(748, 631)

            'deixar botão pressionado
        ElseIf BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social" Then
            BtnCapitalSocial.Text = "Abrir Calculadora Capítal Social"
            GroupBoxCapitalSocial.Visible = False
            GroupBoxMenuCapitalSocial.Visible = False
            GroupBoxMenuCapitalSocial.Enabled = False
            GroupBoxCapitalSocial.Enabled = False
            'retornar para tamanho original do frmscoios

        End If

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
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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
            FrmLegalizacao.TabControl2.SelectedIndex = 5

            For Each row As DataGridViewRow In DataGridView1.Rows
                ''para cada linha pegar nome do socio da coluna 0 e capital da coluna 3 da datagridview1
                'colocar dentro frmlegalizacao.DivisaoCapitalSociosRichTextBox.text
                If row.Cells(0).Value <> "" Then
                    If row.Cells(0).Value <> "Total:" Then
                        Dim NomeSocio As String = row.Cells(0).Value
                        Dim CapitalSocio As String = row.Cells(3).Value

                        '////////////////////// INICIO NOME PEQUENO DO SOCIO ///////////////////////////////   
                        'com a 1 letra ToUpper e o resto ToLower
                        'e depois @NomeCompleto
                        Dim NomePequeno As String = NomeSocio
                        Dim NomePequenoArray() As String = NomePequeno.Split(" ")
                        Dim NomePequenoArray2(NomePequenoArray.Length - 1) As String
                        For i = 0 To NomePequenoArray.Length - 1
                            NomePequenoArray2(i) = NomePequenoArray(i).Substring(0, 1).ToUpper & NomePequenoArray(i).Substring(1, NomePequenoArray(i).Length - 1).ToLower
                        Next
                        Dim NomePequeno2 As String = ""
                        For i = 0 To NomePequenoArray2.Length - 1
                            NomePequeno2 = NomePequeno2 & NomePequenoArray2(i) & " "
                        Next
                        NomePequeno2 = NomePequeno2.Substring(0, NomePequeno2.Length - 1)
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

    Private Sub BtnAtalhoEndereco_Click(sender As Object, e As EventArgs) Handles BtnAtalhoEndereco.Click, BtnAtalhoEndereco2.Click
        'ativar TabControl1 1
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BtnAtalhoContato_Click(sender As Object, e As EventArgs) Handles BtnAtalhoContato.Click, BtnAtalhoContato2.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub BtnAtablhoSocio_Click(sender As Object, e As EventArgs) Handles BtnAtablhoSocio.Click, Button2.Click
        TabControl1.SelectedIndex = 0

    End Sub

    Private Sub GeneroComboBox_TextUpdate(sender As Object, e As EventArgs) Handles GeneroComboBox.TextUpdate
        EstadoCivil()
    End Sub

    Private Sub RGTextBox_Validated(sender As Object, e As EventArgs) Handles RGTextBox.Validated
        'ModTexto usar o  OnlyNumbers
        RGTextBox.Text = ApenasNumeros(RGTextBox.Text)
        ' RGTextBox.Text = RGTextBox.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace(" ", "")

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
            CivilTextBox.Width = CivilTextBox.Text.Length * 6
        End If
    End Sub
End Class