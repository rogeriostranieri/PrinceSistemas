Imports System.Windows.Forms

Public Class FrmSociosExportar

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            ' Verifica se FrmLegalizacao está aberto
            If Application.OpenForms().OfType(Of FrmLegalizacao).Any() = False Then
                MsgBox("O formulário FrmLegalizacao não está aberto.", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            ' Verifica se FrmSocios está aberto
            If Application.OpenForms().OfType(Of FrmSocios).Any() = False Then
                MsgBox("O formulário FrmSocios não está aberto.", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If


            'ativar TabControle 1
            FrmLegalizacao.TabControl1.SelectedIndex = 1

            'ativar TabControl2 0
            FrmLegalizacao.TabControl2.SelectedIndex = 1

            'Dados
            Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text
            Dim NomeCompleto As String = FrmSocios.NomeCompletoTextBox.Text
            Dim NomeDaMae As String = FrmSocios.NomeMaeTextBox.Text
            Dim NomeDaPai As String = FrmSocios.NomePaiTextBox.Text

            'clicar no BtnExtensoDN

            'se tiver vazio DataDeNascExtenso deixar em branco
            Dim DataDeNascimento As String = FrmSocios.DatadeNascMaskedTextBox.Text

            If DataDeNascimento = "" Then
                DataDeNascimento = ""
            Else
                Dim DataDeNascimentoFormatada As String = Format(CDate(DataDeNascimento), "dd 'de' MMMM 'de' yyyy")
                DataDeNascimento = DataDeNascimentoFormatada
            End If

            Dim RG As String = FrmSocios.RGTextBox.Text
            Dim OrgaoRG As String = FrmSocios.OrgaoRGTextBox.Text
            Dim EstadoRG As String = FrmSocios.EstadoRGTextBox.Text
            Dim SenhaGOV As String = FrmSocios.SenhaGOVTextBox.Text
            Dim TituloDeEleitor As String = FrmSocios.TituloDeEleitorTextBox.Text
            Dim CNH As String = FrmSocios.CNHTextBox.Text
            Dim ExpediçãoCNH As String = FrmSocios.CNHExpedicaoTextBox.Text
            Dim DataExpediçãoCNH As String = FrmSocios.CNHDataExpMaskedTextBox.Text
            Dim EstadoCivil As String = FrmSocios.CivilTextBox.Text
            Dim Empresario As String = FrmSocios.ProfissãoTextBox.Text
            Dim Genero As String = FrmSocios.GeneroComboBox.Text
            Dim domiciliado As String

            'endereço
            Dim RUA As String = FrmSocios.RUATextBox.Text
            If RUA = "" Then
                RUA = ""
            Else
                RUA = RUA.Substring(0, 1).ToLower() & RUA.Substring(1)
            End If
            'primeira letra da RUA em minusculo
            Dim RUA1 As String = RUA

            Dim N As String = FrmSocios.NumTextBox.Text
            Dim Compl As String = FrmSocios.ComplementoTextBox.Text
            Dim Bairro As String = FrmSocios.BairroTextBox.Text
            Dim CEP As String = FrmSocios.CEPMaskedTextBox.Text
            Dim Cidade As String = FrmSocios.CidadeTextBox.Text
            Dim Estado As String = FrmSocios.EstadoTextBox.Text
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
            If FrmSocios.MenorIdadeComboBox.Text <> "" Then
                ' Alterar o texto para menor de idade
                Dim MenorTexto As String = FrmSocios.MenorIdadeComboBox.Text
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
                Compl = ", " & FrmSocios.ComplementoTextBox.Text
            End If

            Dim ehAdministrador As String = ComboBoxTipoSocio.Text
            Dim saidaDeSocio As String = ComboBoxEntrada.Text

            ' Verifica se ehAdministrador está nulo ou vazio
            If String.IsNullOrEmpty(ehAdministrador) Then
                MessageBox.Show("O campo 'Administrador' não pode estar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Se saidaDeSocio for "Alteração", não faz nada e continua a execução normal
            If saidaDeSocio = "Alteração" Then
                ' Nenhuma ação necessária
                saidaDeSocio = "Continua"
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



                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Insert(Posição, "
Novos dados:
" & saidaDeSocio & ": Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////" & vbCrLf &
ehAdministrador & vbCrLf & vbCrLf &
NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", n.º " & N & "" & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG n.º " & RG & "-" & OrgaoRG & "/" & EstadoRG & " e do CPF n.º " & CPF & "." & RepresentanteLegal & vbCrLf &
"//////////////////////////////////////////////////////////////////////") & vbCrLf
                End If

            Else
                'Contagem de Sócios
                If FrmLegalizacao.QuantidadeSociosTextBox.Text = "" Then
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = "1"
                Else
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = FrmLegalizacao.QuantidadeSociosTextBox.Text + 1
                End If
                QuantidadeSocios = CInt(FrmLegalizacao.QuantidadeSociosTextBox.Text)


                'FORMA FINAL
                FrmLegalizacao.DadosSociosRichTextBox.SelectedText &=
        saidaDeSocio & ": Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////" & vbCrLf &
                ehAdministrador & vbCrLf & vbCrLf &
        NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", n.º " & N & "" & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado & ", " & Portador & " da Cédula da Identidade Civil RG n.º " & RG & "-" & OrgaoRG & "/" & EstadoRG & " e do CPF n.º " & CPF & "." & RepresentanteLegal & vbCrLf &
        "//////////////////////////////////////////////////////////////////////" & vbCrLf
            End If

            'Focar na frente o FrmLegalizacao
            FrmLegalizacao.Focus()
            FrmLegalizacao.DadosSociosRichTextBox.Focus()

            FrmSocios.Close()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            'mostra mgs do local do erro + "Preencha todos os campos obrigatórios"
            MsgBox(ex.Message & "Preencha todos os campos obrigatórios", MsgBoxStyle.Critical, "Atenção")
            Me.Focus()
        End Try


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FrmSociosExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
