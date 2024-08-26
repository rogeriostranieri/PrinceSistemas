Imports Microsoft.Office.Interop.Word

Public Class ExportarContratoWordDialog
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        ' Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub ExportarSocios()
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        Dim rng As Microsoft.Office.Interop.Word.Range

        Try
            'mostra PictureBoxAguarde com imagem "aguarde"
            PictureBoxAguarde.Visible = True
            PictureBoxAguarde.Image = My.Resources.Aguarde
            'PictureBoxAguarde fill
            PictureBoxAguarde.SizeMode = PictureBoxSizeMode.StretchImage
            'dock fill
            PictureBoxAguarde.Dock = DockStyle.Fill
            'bloqueia os botao de abrir ok e cancelar e fechar
            BtnAbrir.Enabled = False
            BtnAdicionar.Enabled = False
            BtnContrato.Enabled = False
            BtnDados.Enabled = False
            OK_Button.Enabled = False
            Cancel_Button.Enabled = False


            'Dados
            Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text
            Dim NomeCompleto As String = FrmSocios.NomeCompletoTextBox.Text
            Dim NomeDaMae As String = FrmSocios.NomeMaeTextBox.Text
            Dim NomeDaPai As String = FrmSocios.NomePaiTextBox.Text

            'clicar no BtnExtensoDN
            Dim DataDeNascimento As String = FrmSocios.DatadeNascMaskedTextBox.Text
            If DataDeNascimento <> "" Then
                DataDeNascimento = Format(CDate(DataDeNascimento), "dd 'de' MMMM 'de' yyyy")
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
            If EstadoCivil = "solteiro" Then
                EstadoCivil = "maior, solteiro"
            ElseIf EstadoCivil = "solteira" Then
                EstadoCivil = "maior, solteira"
            End If

            Dim Empresario As String
            Dim Genero As String = FrmSocios.GeneroComboBox.Text
            Dim Domiciliado As String

            'endereço
            Dim Rua As String = FrmSocios.RUATextBox.Text
            'primeira letra da RUA em minusculo
            Rua = Strings.StrConv(Rua, VbStrConv.ProperCase)
            Rua = Rua.Substring(0, 1).ToLower() & Rua.Substring(1)

            Dim N As String = FrmSocios.NumTextBox.Text

            'For Each next
            Dim Compl As String = FrmSocios.ComplementoTextBox.Text
            'For Each Compl In FrmSocios.ComplementoTextBox.Text
            'verificar se tem complemento FrmSocios.ComplementoTextBox.Text, 
            'se tiver, adicionar "," antes do complemento
            If Compl <> "" Then
                Compl = ", " & Compl
            End If
            'Next



            Dim Bairro As String = FrmSocios.BairroTextBox.Text
            Dim CEP As String = FrmSocios.CEPMaskedTextBox.Text
            Dim CidadeSocio As String = FrmSocios.CidadeTextBox.Text
            Dim EstadoSocio As String = FrmSocios.EstadoTextBox.Text
            Dim Portador As String
            Dim Brasileiro As String
            Dim Nascido As String


            'GENEROS /////////////////////////////
            Dim SocioGenero As String
            Dim OsocioGenero As String
            Dim SociosGenero As String
            Dim OssociosGenero As String

            Dim ZOsocioGeneroInicio As String
            Dim AoSocioGrande As String
            Dim AoSocioMinusculo As String
            Dim ADMINISTRADORGrande As String
            Dim OtitularGrande As String
            Dim OtitularMinusculo As String

            'Administrador
            Dim AdministradorMaiuscula As String
            'O administrador
            Dim OAdministradorMaiuscula As String
            'administrador
            Dim AdministradorMinuscula As String
            'o administrador
            Dim OAdministradorMinuscula As String
            'Administradores
            Dim AdministradoresMaiuscula As String
            'Os administradores
            Dim OAdministradoresMinuscula As String
            'administradores
            Dim AdministradoresMinuscula As String
            'os administradores
            Dim OAdministradoresMaiuscula As String
            '//////////////////////////////////////////////////////



            'verificar se está no masculino ou feminio no campo GeneroComboBox
            If Genero = "Masculino" Then
                'verificar se está no masculino e mudar para solteiro do  CivilComboBox da lista
                ' EstadoCivil = "solteiro"
                Empresario = "empresário"
                Domiciliado = "domiciliado"
                Portador = "portador"
                Brasileiro = "brasileiro"
                Nascido = "nascido em"
                SocioGenero = "sócio"
                OsocioGenero = "o sócio"
                SociosGenero = "Sócios"
                OssociosGenero = "Os sócios"
                AdministradorMaiuscula = "Administrador"
                OAdministradorMaiuscula = "O administrador"
                AdministradorMinuscula = "administrador"
                OAdministradorMinuscula = "o administrador"
                AdministradoresMaiuscula = "Administradores"
                OAdministradoresMinuscula = "Os administradores"
                AdministradoresMinuscula = "administradores"
                OAdministradoresMaiuscula = "os administradores"
                ZOsocioGeneroInicio = "O sócio"
                AoSocioGrande = "Ao sócio"
                AoSocioMinusculo = "ao sócio"
                ADMINISTRADORGrande = "ADMINISTRADOR"
                OtitularGrande = "O titular"
                OtitularMinusculo = "o titular"

            ElseIf Genero = "Feminino" Then
                'EstadoCivil = "solteira"
                Empresario = "empresária"
                Domiciliado = "domiciliada"
                Portador = "portadora"
                Brasileiro = "brasileira"
                Nascido = "nascida em"
                SocioGenero = "sócia"
                OsocioGenero = "a sócia"
                SociosGenero = "Sócias"
                OssociosGenero = "As sócias"
                AdministradorMaiuscula = "Administradora"
                OAdministradorMaiuscula = "A administradora"
                AdministradorMinuscula = "administradora"
                OAdministradorMinuscula = "a administradora"
                AdministradoresMaiuscula = "Administradoras"
                OAdministradoresMinuscula = "As administradoras"
                AdministradoresMinuscula = "administradoras"
                OAdministradoresMaiuscula = "as administradoras"
                ZOsocioGeneroInicio = "A sócia"
                AoSocioGrande = "A sócia"
                AoSocioMinusculo = "a sócia"
                ADMINISTRADORGrande = "ADMINISTRADORA"
                OtitularGrande = "A titular"
                OtitularMinusculo = "a titular"

            End If

            Dim NumeroSocio As String = FrmSocios.ComboBox1.Text

            'caminho do documento que vai ser modificado
            Dim Caminho As String = TextBoxCaminho.Text

            '////////////////////////////////// DADOS DO SOCIO //////////////////////////////////////
            doc = word.Documents.Open(Caminho)
            rng = doc.Range(0, doc.Characters.Count)
            rng.Find.ClearFormatting()

            'CPF
            rng.Find.Text = "@" & NumeroSocio & "SocioCPF"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CPF
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'NomeCompleto"
            rng.Find.Text = "@" & NumeroSocio & "SocioNomeCompleto"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NomeCompleto
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'DataDeNascimento
            rng.Find.Text = "@" & NumeroSocio & "SocioDataDeNascimento"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataDeNascimento
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'RG
            rng.Find.Text = "@" & NumeroSocio & "SocioRG"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OrgaoRG
            rng.Find.Text = "@" & NumeroSocio & "SocioOrgaoRG"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OrgaoRG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'EstadoRG
            rng.Find.Text = "@" & NumeroSocio & "SocioEstadoRG"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EstadoRG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'EstadoCivil
            rng.Find.Text = "@" & NumeroSocio & "SocioEstadoCivil"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EstadoCivil
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Genero
            rng.Find.Text = "@" & NumeroSocio & "SocioGenero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Genero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Empresario
            rng.Find.Text = "@" & NumeroSocio & "SocioEmpresario"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Empresario
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'domiciliado
            rng.Find.Text = "@" & NumeroSocio & "Sociodomiciliado"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Domiciliado
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Portador
            rng.Find.Text = "@" & NumeroSocio & "SocioPortador"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Portador
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Brasileiro
            rng.Find.Text = "@" & NumeroSocio & "SocioBrasileiro"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Brasileiro
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Nascido
            rng.Find.Text = "@" & NumeroSocio & "SocioNascido"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Nascido
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'RUA
            rng.Find.Text = "@" & NumeroSocio & "SocioRua"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RUA
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Numero
            rng.Find.Text = "@" & NumeroSocio & "SocioNumero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = N
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Complemento
            rng.Find.Text = "@" & NumeroSocio & "Complemento"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Compl
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Bairro
            rng.Find.Text = "@" & NumeroSocio & "SocioBairro"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Bairro
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Cidade
            rng.Find.Text = "@" & NumeroSocio & "SocioCidade"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CidadeSocio
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Estado
            rng.Find.Text = "@" & NumeroSocio & "SocioEstado"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EstadoSocio
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'CEP
            rng.Find.Text = "@" & NumeroSocio & "SocioCEP"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CEP
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OsocioGeneroInicio = "O sócio"
            rng.Find.Text = "@" & NumeroSocio & "SocioGeneroInicio"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = ZOsocioGeneroInicio
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AoSocioGrande = "Ao sócio"
            rng.Find.Text = "@" & NumeroSocio & "SocioGrande"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AoSocioGrande
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AoSocioMinusculo = "ao sócio"
            rng.Find.Text = "@" & NumeroSocio & "SocioMinusculo"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AoSocioMinusculo
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'ADMINISTRADORGrande = "ADMINISTRADOR"
            rng.Find.Text = "@" & NumeroSocio & "AdministradorGrande"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = ADMINISTRADORGrande
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OtitularGrande = "O titular"
            rng.Find.Text = "@" & NumeroSocio & "TitularGrande"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OtitularGrande
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OtitularMinusculo = "o titular"
            rng.Find.Text = "@" & NumeroSocio & "TitularMinusculo"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OtitularMinusculo
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)



            '////////////////////// NOME PEQUENO DO SOCIO ///////////////////////////////   
            'com a 1 letra ToUpper e o resto ToLower
            'e depois @NomeCompleto
            Dim NomePequeno As String = FrmSocios.NomeCompletoTextBox.Text
            NomePequeno = Strings.StrConv(NomePequeno, VbStrConv.ProperCase)

            'substituir @NomeCompleto pelo nome pequeno do socio
            rng.Find.Text = "@" & NumeroSocio & "SocioNomePequeno"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NomePequeno
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)



            '//////////////////////////////////  GENERO  /////////////////////////
            'Verificar Masculino e Feminino no Contrato em geral
            'Genero1 maisculo
            rng.Find.Text = "@" & NumeroSocio & "SociGenero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = SocioGenero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)
            'Genero2 minúsculo
            rng.Find.Text = "@" & NumeroSocio & "OsocioGenero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OsocioGenero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Genero1
            rng.Find.Text = "@" & NumeroSocio & "SocisGenero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = SociosGenero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)
            'Genero2
            rng.Find.Text = "@" & NumeroSocio & "OssociosGenero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OssociosGenero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AdministradorMaiuscula = "Administrador"
            rng.Find.Text = "@" & NumeroSocio & "Socio1Administrador"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AdministradorMaiuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)


            'OAdministradorMaiuscula = "O administrador"
            rng.Find.Text = "@" & NumeroSocio & "Socio2OAdministrador"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OAdministradorMaiuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AdministradorMinuscula = "administrador"
            rng.Find.Text = "@" & NumeroSocio & "Socio3administrador"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AdministradorMinuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OAdministradorMinuscula = "o administrador"
            rng.Find.Text = "@" & NumeroSocio & "Socio4oAdministrador"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OAdministradorMinuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AdministradoresMaiuscula = "Administradores"
            rng.Find.Text = "@" & NumeroSocio & "Socio5Administradores"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AdministradoresMaiuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OAdministradoresMinuscula = "Os administradores"
            rng.Find.Text = "@" & NumeroSocio & "Socio6OAdministradores"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OAdministradoresMaiuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AdministradoresMinuscula = "administradores"
            rng.Find.Text = "@" & NumeroSocio & "Socio7administradores"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AdministradoresMinuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OAdministradoresMaiuscula = "os administradores"
            rng.Find.Text = "@" & NumeroSocio & "Socio8oAdministradores"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OAdministradoresMaiuscula
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)



            '/////////////////////// SALVAR //////////////////////////////////////
            'perguntar se deseja escolher local diferente para salvar ou sobreescrever o mesmo que foi selecionado
            'se sim, abrir o dialogo de salvar e salvar no local escolhido
            'se nao, sobreescrever o arquivo que foi selecionado

            Dim Message As String = "Deseja escolher novo local para salvar o arquivo?"
            Dim result As Integer = MessageBox.Show(Message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Dim saveFileDialog1 As New SaveFileDialog With {
                    .Filter = "Word Documents (*.docx)|*.docx",
                    .FilterIndex = 2,
                    .RestoreDirectory = True
                }
                saveFileDialog1.ShowDialog()
                If (saveFileDialog1.FileName <> "") Then
                    doc.SaveAs(saveFileDialog1.FileName)
                    doc.Close()
                    doc = Nothing
                End If
            ElseIf result = DialogResult.No Then
                doc.Save()
                doc.Close()
                doc = Nothing
            ElseIf result = DialogResult.Cancel Then
                doc.Close()
                doc = Nothing
            End If


        Catch ex As Exception
            'mostra onde está o erro
            MessageBox.Show(ex.Message)
            doc.Save()
            doc.Close()
            doc = Nothing
        End Try


        'esconder PictureBoxAguarde com imagem "aguarde"
        PictureBoxAguarde.Visible = False
        PictureBoxAguarde.Image = Nothing
        'Mostra os botao de abrir ok e cancelar e fechar
        BtnAbrir.Enabled = True
        BtnAdicionar.Enabled = True
        BtnContrato.Enabled = True
        BtnDados.Enabled = True
        OK_Button.Enabled = True
    End Sub
    Private Sub ExportarWordSocios()

        'verificar se FrmSocios está aberto ou abrir form
        If FrmSocios.Visible = True Then
            If MsgBox("Está selecionado o Sócio correto para exportar, e qual Numero de Sócio?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'verificar se TextBoxCaminho.Text está vazio ou não, e com arquivo docx selecionado
                If TextBoxCaminho.Text = "" Then
                    MsgBox("Selecione o arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
                    Exit Sub
                Else
                    'verificar se tem ".docx" no final do caminho
                    If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
                        ExportarSocios()
                    Else
                        MsgBox("Selecione um arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
                        Exit Sub
                    End If

                End If

            End If

        Else
            'mostra mgsbox avisando que o form não está aberto
            'MsgBox("O formulário de Socios não está aberto. Por favor, abra o formulário de Socios e tente novamente.", MsgBoxStyle.Critical, "Erro")
            'perguntar se deseja abrir o form
            If MsgBox("O formulário de Socios não está aberto. Deseja abrir o formulário de Socios?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'verificar se o form está aberto, se sim, abrir o form
                If FrmSocios.Visible = True Then
                    FrmSocios.Focus()
                Else
                    'se não, abrir o form
                    FrmSocios.Show()
                End If
            End If
        End If

    End Sub
    Private Sub BtnSocios_Click(sender As Object, e As EventArgs) Handles BtnSocios.Click
        'verificar se o campo TextBoxCaminho contem ".docx"
        If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
            If MsgBox("Deseja exportar os dados do sócio para o Word?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                ExportarWordSocios()
            End If
        Else
            MsgBox("Selecione um arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
        End If



    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles BtnAbrir.Click
        'pegar o caminho onde foi salvo e abrir
        ' Dim Abrir As String = MsgBox("Deseja abrir o arquivo?", MsgBoxStyle.YesNo, "Abrir")
        'If Abrir = vbYes Then
        Dim AbrirArquivo As New OpenFileDialog With {
            .Filter = "Word Document (*.docx)|*.docx"
        }
        AbrirArquivo.ShowDialog()
        If AbrirArquivo.FileName <> "" Then
            Process.Start(AbrirArquivo.FileName)
        End If
        ' End If

    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        EscolherArquivo()
    End Sub

    Private Sub BtnContrato_Click(sender As Object, e As EventArgs) Handles BtnContrato.Click
        'verificar se o campo TextBoxCaminho contem ".docx"
        Dim AntigaRazaoSocial As String = FrmLegalizacao.RazaoSocialTextBox.Text

        If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
            If MsgBox("Deseja exportar os dados da empresa " & AntigaRazaoSocial & " para o Contrato Social no WORD?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                ExportarWordContrato()
            End If
        Else
            MsgBox("Selecione um arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
        End If

    End Sub
    Private Sub ExportarContrato()
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        Dim rng As Microsoft.Office.Interop.Word.Range

        Try

            'mostra PictureBoxAguarde com imagem "aguarde"
            PictureBoxAguarde.Visible = True
            PictureBoxAguarde.Image = My.Resources.Aguarde
            'PictureBoxAguarde fill
            PictureBoxAguarde.SizeMode = PictureBoxSizeMode.StretchImage
            'dock fill
            PictureBoxAguarde.Dock = DockStyle.Fill
            'bloqueia os botao de abrir ok e cancelar e fechar
            BtnAbrir.Enabled = False
            BtnAdicionar.Enabled = False
            BtnContrato.Enabled = False
            BtnDados.Enabled = False
            OK_Button.Enabled = False
            Cancel_Button.Enabled = False


            'pega dados
            FrmLegalizacao.TabControle.SelectTab(0)
            FrmLegalizacao.TabControle.SelectTab(2)
            'Empresa facil NIRE
            FrmLegalizacao.TabControl1.SelectTab(0)
            'volta pros dados
            FrmLegalizacao.TabControle.SelectTab(1)
            'Pega dados TabControl2
            FrmLegalizacao.TabControl2.SelectTab(0)
            FrmLegalizacao.TabControl2.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(2)
            FrmLegalizacao.TabControl2.SelectTab(3)
            FrmLegalizacao.TabControl2.SelectTab(4)
            FrmLegalizacao.TabControl2.SelectTab(5)
            FrmLegalizacao.TabControl2.SelectTab(6)

            'Volta
            FrmLegalizacao.TabControl2.SelectTab(0)
            FrmLegalizacao.TabControle.SelectTab(0)

            '/////////////////////////////////// DADOS /////////////////////////////////////
            Dim AntigaRazaoSocial As String = FrmLegalizacao.RazaoSocialTextBox.Text
            Dim NovaRazaoSocial As String = FrmLegalizacao.NovaRazaoSocialFinalTextBox.Text
            Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text

            'endereço
            Dim Rua As String = FrmLegalizacao.EnderecoTextBox.Text
            'primeira letra da RUA em minusculo
            Rua = Strings.StrConv(Rua, VbStrConv.ProperCase)
            Rua = Rua.Substring(0, 1).ToLower() & Rua.Substring(1)

            Dim Numero As String = FrmLegalizacao.EndNumeroTextBox.Text
            'verificar se tem complemento EndComplementoTextBox
            'For Each next
            Dim Complemento As String = FrmLegalizacao.EndComplementoTextBox.Text
            ' For Each Complemento In FrmLegalizacao.EndComplementoTextBox.Text
            'verificar se tem complemento FrmSocios.ComplementoTextBox.Text, 
            'se tiver, adicionar "," antes do complemento
            If Complemento <> "" Then
                Complemento = ", " & Complemento
            End If
            'Next
            Dim Bairro As String = FrmLegalizacao.EndBairroTextBox.Text
            Dim CEP As String = FrmLegalizacao.EndCEPMaskedTextBox.Text
            Dim Cidade As String = FrmLegalizacao.EndCidadeTextBox.Text
            Dim UF As String = FrmLegalizacao.EndEstadoTextBox.Text
            Dim NIRE As String = FrmLegalizacao.NIRETextBox.Text
            Dim AltAbertBaixa As String = FrmLegalizacao.ProcessoComboBox.Text
            Dim NAlteracao As String = FrmLegalizacao.NAlteracaoComboBox.Text


            'EmpInicioAtividade 
            Dim EmpInicioAtividade As String = FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text
            If EmpInicioAtividade <> "" Then
                EmpInicioAtividade = Format(CDate(EmpInicioAtividade), "dd 'de' MMMM 'de' yyyy")
            End If
            'EmpInicioAtividade 
            Dim DataAssinatura As String = FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text
            If DataAssinatura <> "" Then
                DataAssinatura = Format(CDate(DataAssinatura), "" & Cidade & "'-'" & UF & "',' dd 'de' MMMM 'de' yyyy'.'")
            End If

            'RamoDeAtividadeRichTextBox 
            Dim RamoDeAtividade As String = FrmLegalizacao.RamoDeAtividadeRichTextBox.Text


            'CapitalSocial(tambem extenso)
            Dim CapitalSocialNumero As String = FrmLegalizacao.CapitalSTextBox.Text
            'CapitalSocialNumero em decimal
            Dim CapitalSocialDecimal As Decimal = CDec(CapitalSocialNumero)
            'CapitalSocialNumero em extenso
            Dim CapitalSocialExtenso As String = NumberToEuro(CapitalSocialDecimal)


            Dim DataNire As String = FrmLegalizacao.NireDataMaskedTextBox.Text
            'DataNire formato dd 'de' MMMM 'de' yyyy
            If DataNire <> "" Then
                DataNire = Format(CDate(DataNire), "dd 'de' MMMM 'de' yyyy")
            End If



            '/////////////////////////////// INICIO CODIGO /////////////////////////////////
            'caminho do documento que vai ser modificado
            Dim Caminho As String = TextBoxCaminho.Text

            doc = word.Documents.Open(Caminho)
            rng = doc.Range(0, doc.Characters.Count)
            rng.Find.ClearFormatting()

            'AntigaRazaoSocial
            rng.Find.Text = "@EmpresaRazaoSocialNormal"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AntigaRazaoSocial
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'NovaRazaoSocial
            rng.Find.Text = "@EmpresaNovaRazaoSocial"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NovaRazaoSocial
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'RUA
            rng.Find.Text = "@EmpresaRua"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Rua
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Numero
            rng.Find.Text = "@EmpresaNumero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Numero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Complemento
            rng.Find.Text = "@EmpresaComplemento"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Complemento
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Bairro
            rng.Find.Text = "@EmpresaBairro"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Bairro
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'CEP
            rng.Find.Text = "@EmpresaCEP"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CEP
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Cidade
            'colocar apenas primeira letra maiscula de cada palavra
            Dim Cidade1 As String = Cidade.Substring(0, 1).ToUpper() & Cidade.Substring(1)

            rng.Find.Text = "@EmpresaCidade"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Cidade1
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'UF
            rng.Find.Text = "@EmpresaUF"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = UF
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'InicioDeAtividadeFinal
            rng.Find.Text = "@EmpresaInicioDeAtividade"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EmpInicioAtividade
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'InicioDeAtividadeFinal1
            rng.Find.Text = "@EmpresaDataAssinatura"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataAssinatura
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'RamoDeAtividade
            rng.Find.Text = "@EmpresaRamoDeAtividade"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RamoDeAtividade
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'CapitalSocialExtenso
            rng.Find.Text = "@EmpresaCapitalSocialExtenso"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CapitalSocialExtenso
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'CapitalSocialNumero
            rng.Find.Text = "@EmpresaCapitalSocialNumero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CapitalSocialNumero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)


            'Nire
            rng.Find.Text = "@EmpresaNire"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NIRE
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'DataNire
            rng.Find.Text = "@EmpresaDataNire"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataNire
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)


            'AltAbertBaixa
            rng.Find.Text = "@EmpresaAltAbertBaixa"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = AltAbertBaixa
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'AltAbertBaixa
            rng.Find.Text = "@EmpresaNAlteracao"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NAlteracao
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'CNPJ
            rng.Find.Text = "@EmpresaCNPJ"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CNPJ
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'alterar cabeçalho do word




            '/////////////////////// + de 2 Socios  Capital Social TABELA ///////////////////////////
            'dados 
            '"@" & Linha & "TabelaSocio"
            Dim TabelaRS As New List(Of String)
            TabelaRS = FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Lines.ToList()
            'para toda linha da TabelaRS, pegar o nome do socio apenas antes do " - "
            Dim LinhaTabelaRS As String
            Dim CapitalSocialTabelaRS As Integer = 0
            Dim NomeSocioTabelaRS As String

            'pegar apenas linhas TabelaRS

            For Each LinhaTabelaRS In TabelaRS
                If LinhaTabelaRS.Contains("-") Then
                    NomeSocioTabelaRS = LinhaTabelaRS.Substring(0, LinhaTabelaRS.IndexOf("-"))
                    CapitalSocialTabelaRS += Val(LinhaTabelaRS.Substring(LinhaTabelaRS.IndexOf("-") + 2))
                    'pega numero da linha onde ta o socio + nome dele
                    Dim LinhaTabelaRS1 As String = LinhaTabelaRS.Substring(LinhaTabelaRS.IndexOf("-") + 2)
                    Dim LinhaTabelaRS2 As String = LinhaTabelaRS1.Substring(0, LinhaTabelaRS1.IndexOf(" "))

                    'pegar o nome do socio apenas antes do " - "
                    Dim NomeSocioTabelaRS1 As String = LinhaTabelaRS.Substring(0, LinhaTabelaRS.IndexOf("-"))

                    'coloca word depois
                    rng.Find.Text = "@" & LinhaTabelaRS2 & "EmpresaTabelaSocio"
                    rng.Find.Replacement.ClearFormatting()
                    rng.Find.Replacement.Text = NomeSocioTabelaRS1
                    rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                End If
            Next


            '//////////////////////////////////////////////////////////////////////////////////////////////
            '/////////////////////////////// FIM CODIGO /////////////////////////////////


            '/////////////////////// SALVAR //////////////////////////////////////
            'perguntar se deseja escolher local diferente para salvar ou sobreescrever o mesmo que foi selecionado
            'se sim, abrir o dialogo de salvar e salvar no local escolhido
            'se nao, sobreescrever o arquivo que foi selecionado

            Dim Message As String = "Deseja escolher novo local para salvar o arquivo?"
            Dim result As Integer = MessageBox.Show(Message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Dim saveFileDialog1 As New SaveFileDialog With {
                .Filter = "Word Documents (*.docx)|*.docx",
                .FilterIndex = 2,
                .RestoreDirectory = True
            }
                saveFileDialog1.ShowDialog()
                If (saveFileDialog1.FileName <> "") Then
                    doc.SaveAs(saveFileDialog1.FileName)
                    doc.Close()
                    doc = Nothing
                End If
            ElseIf result = DialogResult.No Then
                doc.Save()
                doc.Close()
                doc = Nothing
            ElseIf result = DialogResult.Cancel Then
                doc.Close()
                doc = Nothing
            End If




        Catch ex As Exception
            'mostra onde está o erro
            MessageBox.Show(ex.Message)
            doc.Save()
            doc.Close()
            doc = Nothing
        End Try


        'esconder PictureBoxAguarde com imagem "aguarde"
        PictureBoxAguarde.Visible = False
        PictureBoxAguarde.Image = Nothing
        'Mostra os botao de abrir ok e cancelar e fechar
        BtnAbrir.Enabled = True
        BtnAdicionar.Enabled = True
        BtnContrato.Enabled = True
        BtnDados.Enabled = True
        OK_Button.Enabled = True
    End Sub

    Private Sub BtnDados_Click(sender As Object, e As EventArgs) Handles BtnDados.Click
        'verificar se form DadosExportacao esta aberto e abrir
        If DadosExportacao.Visible = True Then
            DadosExportacao.Focus()
        Else
            DadosExportacao.Show()
        End If

    End Sub

    Private Sub ExportarWordContrato()

        'verificar se FrmSocios está aberto ou abrir form
        If FrmLegalizacao.Visible = True Then
            If MsgBox("Está selecionado o Empresa correta para exportar?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'verificar se TextBoxCaminho.Text está vazio ou não, e com arquivo docx selecionado
                If TextBoxCaminho.Text = "" Then
                    MsgBox("Selecione o arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
                    Exit Sub
                Else
                    'verificar se tem ".docx" no final do caminho
                    If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
                        ExportarContrato()
                    Else
                        MsgBox("Selecione um arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
                        Exit Sub
                    End If

                End If

            End If

        Else
            'mostra mgsbox avisando que o form não está aberto
            'MsgBox("O formulário de Socios não está aberto. Por favor, abra o formulário de Socios e tente novamente.", MsgBoxStyle.Critical, "Erro")
            'perguntar se deseja abrir o form
            If MsgBox("O formulário de Empresas não está aberto. Deseja abrir o formulário de Empresas?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'verificar se o form está aberto, se sim, abrir o form
                If FrmLegalizacao.Visible = True Then
                    FrmLegalizacao.Focus()
                Else
                    'se não, abrir o form
                    FrmLegalizacao.Show()
                End If
            End If
        End If

    End Sub

    Private Sub EscolherArquivo()
        'procurar um aquivo e adcionar caminho completo dentro do TextBoxCaminho
        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "c:\",
            .Filter = "Word files (*.docx)|*.docx|All files (*.*)|*.*",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }


        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxCaminho.Text = openFileDialog1.FileName
        End If

    End Sub

    Private Sub ExportarContratoWordDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'desabilita PictureBoxAguarde
        PictureBoxAguarde.Visible = False
    End Sub
End Class
