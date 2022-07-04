Public Class FrmSocios
    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Socios'. Você pode movê-la ou removê-la conforme necessário.
        Me.SociosTableAdapter.Fill(Me.PrinceDBDataSet.Socios)
        BloquearEdicao()

        'coloca CivilComboBox para selecionar comunhão parcial de bens
        CivilComboBox.Items.Add("solteiro")
        CivilComboBox.Items.Add("comunhão parcial de bens")
        CivilComboBox.Items.Add("comunhão universal de bens")
        CivilComboBox.Items.Add("separação convencional de bens")
        CivilComboBox.Items.Add("separação obrigatória de bens")
        CivilComboBox.Items.Add("participação final nos aquestos")

        GeneroComboBox.Items.Add("Masculino")
        GeneroComboBox.Items.Add("Feminino")

        TextBoxExtensoDN.Visible = False

    End Sub

    Private Sub BloquearEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = False
        GroupBoxOutrosDados.Enabled = False

    End Sub

    Private Sub LiberarEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = True
        GroupBoxOutrosDados.Enabled = True
    End Sub

    Private Sub EstadoCivil()
        'limpar CivilComboBox
        CivilComboBox.Items.Clear()

        If GeneroComboBox.Text = "Masculino" Then
            CivilComboBox.Items.Add("solteiro")
            CivilComboBox.Items.Add("comunhão parcial de bens")
            CivilComboBox.Items.Add("comunhão universal de bens")
            CivilComboBox.Items.Add("separação convencional de bens")
            CivilComboBox.Items.Add("separação obrigatória de bens")
            CivilComboBox.Items.Add("participação final nos aquestos")
        ElseIf GeneroComboBox.Text = "Feminino" Then
            CivilComboBox.Items.Add("solteira")
            CivilComboBox.Items.Add("comunhão parcial de bens")
            CivilComboBox.Items.Add("comunhão universal de bens")
            CivilComboBox.Items.Add("separação convencional de bens")
            CivilComboBox.Items.Add("separação obrigatória de bens")
            CivilComboBox.Items.Add("participação final nos aquestos")
        Else
            CivilComboBox.Items.Add("solteiro")
            CivilComboBox.Items.Add("comunhão parcial de bens")
            CivilComboBox.Items.Add("comunhão universal de bens")
            CivilComboBox.Items.Add("separação convencional de bens")
            CivilComboBox.Items.Add("separação obrigatória de bens")
            CivilComboBox.Items.Add("participação final nos aquestos")
        End If

    End Sub
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        'pergunta, adiciona novo registro
        If MessageBox.Show("Deseja adicionar um novo registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'new register
            SociosBindingSource.AddNew()
            LiberarEdicao()


            'selecionar  index 0 GeneroComboBox e CivilComboBox
            GeneroComboBox.SelectedIndex = 0
            CivilComboBox.SelectedIndex = 0

            TextBoxExtensoDN.Visible = False
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'perguntar, editar ou não
        If MessageBox.Show("Deseja editar o registro?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LiberarEdicao()
            TextBoxExtensoDN.Visible = False
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'perguntar, salvar dados
        If MsgBox("Deseja salvar os dados?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'salvar dados
            Me.Validate()
            Me.SociosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
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

    Private Sub CivilComboBox_Click(sender As Object, e As EventArgs) Handles CivilComboBox.Click
        'verifica se esta no Feminino e mudar para solteira do  CivilComboBox da lista
        EstadoCivil()
    End Sub

    Private Sub BtnExtensoDN_Click(sender As Object, e As EventArgs) Handles BtnExtensoDN.Click
        Dim DataDeNascimento As String = DatadeNascMaskedTextBox.Text
        Dim DataDeNascimentoFormatada As String = Format(CDate(DataDeNascimento), "dd 'de' MMMM 'de' yyyy")
        'TextBoxExtensoDN
        TextBoxExtensoDN.Visible = True
        TextBoxExtensoDN.Text = DataDeNascimentoFormatada
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
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
        FrmLegalizacao.RespRgSiglaTextBox.Text = OrgaoRGTextBox.Text + " " + EstadoRGTextBox.Text
        FrmLegalizacao.SenhaGovTextBox.Text = SenhaGOVTextBox.Text
        FrmLegalizacao.TituloeleitorTextBox.Text = TituloDeEleitorTextBox.Text
        FrmLegalizacao.CNHnumeroTextBox.Text = CNHTextBox.Text
        FrmLegalizacao.CNHexpTextBox.Text = CNHExpedicaoTextBox.Text
        FrmLegalizacao.CNHdataexpMaskedTextBox.Text = CNHDataExpTextBox.Text
    End Sub
    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        'perguntar antes
        If MsgBox("Deseja exportar os dados do sócio para Empresa em aberto?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            If FrmLegalizacao.Visible = True Then
                FrmLegalizacao.Focus()
                ExportarDados()
            Else
                FrmLegalizacao.Show()
                ExportarDados()
            End If
        End If

    End Sub



    Private Sub AddSocios()

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
        BtnExtensoDN.PerformClick()
        Dim DataDeNascimento As String = TextBoxExtensoDN.Text


        Dim RG As String = RGTextBox.Text
        Dim OrgaoRG As String = OrgaoRGTextBox.Text
        Dim EstadoRG As String = EstadoRGTextBox.Text
        Dim SenhaGOV As String = SenhaGOVTextBox.Text
        Dim TituloDeEleitor As String = TituloDeEleitorTextBox.Text
        Dim CNH As String = CNHTextBox.Text
        Dim ExpediçãoCNH As String = CNHExpedicaoTextBox.Text
        Dim DataExpediçãoCNH As String = CNHDataExpTextBox.Text
        Dim EstadoCivil As String = CivilComboBox.Text
        Dim Empresario As String
        Dim Genero As String = GeneroComboBox.Text
        Dim domiciliado As String

        'endereço
        Dim RUA As String = RUATextBox.Text
        Dim N As String = NumTextBox.Text
        Dim Compl As String = ComplementoTextBox.Text
        Dim Bairro As String = BairroTextBox.Text
        Dim CEP As String = CEPMaskedTextBox.Text
        Dim Cidade As String = CidadeTextBox.Text
        Dim Estado As String = EstadoTextBox.Text
        Dim Portador As String


        'verificar se está no masculino ou feminio no campo GeneroComboBox
        If Genero = "Masculino" Then
            'verificar se está no masculino e mudar para solteiro do  CivilComboBox da lista
            EstadoCivil = "Solteiro"
            Empresario = "Empresario"
            domiciliado = "domiciliado"
            Portador = "Portador"
        Else
            EstadoCivil = "Solteira"
            Empresario = "Empresaria"
            domiciliado = "domiciliada"
            Portador = "Portadora"
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

" & NomeCompleto & ", brasileiro, " & EstadoCivil & ", " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA & ", " & N & ", " & Bairro & "," & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG Nº " & RG & " " & OrgaoRG & "/" & EstadoRG & ", e do CPF Nº " & CPF & "." & vbCrLf & "


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



            'com complemento
            If Compl = "" Then
                FrmLegalizacao.DadosSociosRichTextBox.SelectedText &=
" Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////

" & NomeCompleto & ", brasileiro, " & EstadoCivil & ", " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA & ", " & N & ", " & Bairro & "," & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG Nº " & RG & " " & OrgaoRG & "/" & EstadoRG & ", e do CPF Nº " & CPF & "." & vbCrLf & "


//////////////////////////////////////////////////////////////////////
"
            Else ' Sem complemento
                FrmLegalizacao.DadosSociosRichTextBox.SelectedText &=
" Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////

" & NomeCompleto & ", brasileiro, " & EstadoCivil & ", " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA & ", " & N & ", " & Compl & "," & Bairro & "," & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG Nº " & RG & " " & OrgaoRG & "/" & EstadoRG & ", e do CPF Nº " & CPF & "." & vbCrLf & "


//////////////////////////////////////////////////////////////////////
"
            End If

        End If

        'Focar na frente o FrmLegalizacao
        FrmLegalizacao.Focus()
        FrmLegalizacao.DadosSociosRichTextBox.Focus()


    End Sub
    Private Sub BtnAddSocios_Click(sender As Object, e As EventArgs) Handles BtnAddSocios.Click
        AddSocios()
    End Sub

End Class