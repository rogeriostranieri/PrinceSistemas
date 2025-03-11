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

            ' Ativar abas nos formulários
            FrmLegalizacao.TabControl1.SelectedIndex = 1
            FrmLegalizacao.TabControl2.SelectedIndex = 1

            ' Dados do Sócio
            Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text
            Dim NomeCompleto As String = FrmSocios.NomeCompletoTextBox.Text
            Dim NomeDaMae As String = FrmSocios.NomeMaeTextBox.Text
            Dim NomeDaPai As String = FrmSocios.NomePaiTextBox.Text

            ' Formatação da Data de Nascimento (por extenso)
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

            ' Endereço
            Dim RUA As String = FrmSocios.RUATextBox.Text
            If RUA = "" Then
                RUA = ""
            Else
                RUA = RUA.Substring(0, 1).ToLower() & RUA.Substring(1)
            End If
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

            ' Determinar os termos de acordo com o gênero
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

            ' EXTRA: Preparar string de registro se houver valor em RegistroNumeroTextBox
            Dim extraRegistro As String = ""
            If Not String.IsNullOrEmpty(FrmSocios.RegistroNumeroTextBox.Text) Then
                Dim registroDataFormatada As String = ""
                If Not String.IsNullOrEmpty(FrmSocios.RegistroDataMaskedTextBox.Text) Then
                    registroDataFormatada = Format(CDate(FrmSocios.RegistroDataMaskedTextBox.Text), "dd 'de' MMMM 'de' yyyy")
                    ' Remover eventuais quebras de linha para manter a informação em uma única linha
                    registroDataFormatada = registroDataFormatada.Replace(vbCrLf, " ")
                End If
                extraRegistro = ", com registro na " & FrmSocios.RegistroOrgaoComboBox.Text.Trim() & "-" & FrmSocios.RegistroEstadoComboBox.Text.Trim() &
                            " nº " & FrmSocios.RegistroNumeroTextBox.Text.Trim() & " registrado em " & registroDataFormatada.Trim()
            End If

            ' Verificar menor de idade e incluir representante legal se necessário
            Dim RepresentanteLegal As String = ""
            If FrmSocios.MenorIdadeComboBox.Text <> "" Then
                Dim MenorTexto As String = FrmSocios.MenorIdadeComboBox.Text
                NomeCompleto &= ", " & MenorTexto
                RepresentanteLegal = "neste ato representado por seu responsável legal"
                MsgBox("Por favor, insira o responsável legal pelo menor de idade.", MsgBoxStyle.Information, "Atenção")
            End If

            ' Ajusta estado civil conforme o texto
            If EstadoCivil = "solteira" Then
                EstadoCivil = "maior, solteira"
            ElseIf EstadoCivil = "solteiro" Then
                EstadoCivil = "maior, solteiro"
            End If

            ' Se não houver complemento, mantém vazio; caso contrário, adiciona vírgula
            If Compl = "" Then
                Compl = ""
            Else
                Compl = ", " & FrmSocios.ComplementoTextBox.Text
            End If

            Dim ehAdministrador As String = ComboBoxTipoSocio.Text
            Dim saidaDeSocio As String = ComboBoxEntrada.Text

            ' Verifica se o campo "Administrador" está preenchido
            If String.IsNullOrEmpty(ehAdministrador) Then
                MessageBox.Show("O campo 'Administrador' não pode estar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Se saída for "Alteração", continua sem alteração
            If saidaDeSocio = "Alteração" Then
                saidaDeSocio = "Continua"
            End If

            '///////////////////////////////////////////////////////////////////////////////////
            ' Verifica se o CPF já está cadastrado
            Dim QuantidadeSocios As Integer
            If FrmLegalizacao.DadosSociosRichTextBox.Text.Contains(CPF) Then
                MsgBox("CPF já cadastrado", MsgBoxStyle.Exclamation, "Atenção")

                If MsgBox("Deseja adicionar o novo cadastro?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    Dim Posição As Integer = FrmLegalizacao.DadosSociosRichTextBox.Find(CPF)
                    ' Remove o CPF existente
                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Remove(Posição, CPF.Length)
                    ' Insere os novos dados com a string extra de registro (sem nova linha)
                    FrmLegalizacao.DadosSociosRichTextBox.Text = FrmLegalizacao.DadosSociosRichTextBox.Text.Insert(Posição,
                    "Novos dados:" & vbCrLf &
                    saidaDeSocio & ": Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////" & vbCrLf &
                    ehAdministrador & vbCrLf & vbCrLf &
                    NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", n.º " & N & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado &
                    extraRegistro & ", " & Portador & " da Cédula da Identidade Civil RG n.º " & RG & "-" & OrgaoRG & "/" & EstadoRG & " e do CPF n.º " & CPF & "." & RepresentanteLegal & vbCrLf &
                    "//////////////////////////////////////////////////////////////////////" & vbCrLf)
                End If
            Else
                ' Contagem de Sócios
                If FrmLegalizacao.QuantidadeSociosTextBox.Text = "" Then
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = "1"
                Else
                    FrmLegalizacao.QuantidadeSociosTextBox.Text = FrmLegalizacao.QuantidadeSociosTextBox.Text + 1
                End If
                QuantidadeSocios = CInt(FrmLegalizacao.QuantidadeSociosTextBox.Text)

                ' Monta a string final com o extraRegistro incluído antes dos dados do RG
                FrmLegalizacao.DadosSociosRichTextBox.SelectedText &=
                saidaDeSocio & ": Sócio Nº:" & QuantidadeSocios & " //////////////////////////////////////////////////////////" & vbCrLf &
                ehAdministrador & vbCrLf & vbCrLf &
                NomeCompleto & ", " & Brasileiro & ", " & EstadoCivil & ", " & Nascido & " " & DataDeNascimento & ", " & Empresario & ", residente e " & domiciliado & " na " & RUA1 & ", n.º " & N & Compl & ", " & Bairro & ", CEP: " & CEP & ", na cidade de " & Cidade & "-" & Estado &
                extraRegistro & ", " & Portador & " da Cédula da Identidade Civil RG n.º " & RG & "-" & OrgaoRG & "/" & EstadoRG & " e do CPF n.º " & CPF & "." & RepresentanteLegal & vbCrLf &
                "//////////////////////////////////////////////////////////////////////" & vbCrLf
            End If

            ' Focar no formulário de Legalização e no RichTextBox
            FrmLegalizacao.Focus()
            FrmLegalizacao.DadosSociosRichTextBox.Focus()

            FrmSocios.Close()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            ' Exibe mensagem de erro informando para preencher os campos obrigatórios
            MsgBox(ex.Message & " Preencha todos os campos obrigatórios", MsgBoxStyle.Critical, "Atenção")
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
