Imports Microsoft.Office.Interop.Word
Imports System.Windows.Forms

Public Class ExportarLaudoWordDialog
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
        Dim Mensagem As String = "Deixar aberto o sócio com o número correpondente do seu cadastro, está aberto?"
        Dim Resutlado As Integer = MessageBox.Show(Mensagem, "Prince Alerta", MessageBoxButtons.YesNo)
        If Resutlado = DialogResult.Yes Then
            Me.Focus()
            EscolherArquivo()
        ElseIf Resutlado = DialogResult.No Then
            If FrmSocios.Visible = True Then
                'fechar o FrmSocios
                FrmSocios.Close()
                FrmSocios.Show()
                'pegar o nome do LabelSocio.Text e coloca no FrmSocios.NomeCompletoComboBox.Text  
                FrmSocios.NomeCompletoComboBox.Text = LabelSocio.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = LabelSocio.Text
            End If
        End If
    End Sub

    Private Sub BtnContrato_Click(sender As Object, e As EventArgs) Handles BtnContrato.Click
        'verificar se o campo TextBoxCaminho contem ".docx"
        Dim AntigaRazaoSocial As String = FrmAlvara.RazaoSocialTextBox.Text

        If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
            If MsgBox("Deseja exportar os dados da empresa " & AntigaRazaoSocial & " para o Contrato Social no WORD?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                ExportarWordContrato()
            End If
        Else
            MsgBox("Selecione um arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
        End If

    End Sub

    Private Sub BtnDados_Click(sender As Object, e As EventArgs) Handles BtnDados.Click
        'verificar se form DadosExportacao esta aberto e abrir
        If DadosExportacaoLaudos.Visible = True Then
            DadosExportacaoLaudos.Focus()
        Else
            DadosExportacaoLaudos.Show()
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



    Private Sub ExportarWordContrato()

        'verificar se FrmSocios está aberto ou abrir form
        If FrmAlvara.Visible = True Then
            If MsgBox("Está selecionado o Empresa correta para exportar?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'verificar se TextBoxCaminho.Text está vazio ou não, e com arquivo docx selecionado
                If TextBoxCaminho.Text = "" Then
                    MsgBox("Selecione o arquivo docx para exportar", MsgBoxStyle.OkOnly, "Atenção")
                    Exit Sub
                Else
                    'verificar se tem ".docx" no final do caminho
                    If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
                        ExportarDados()
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
            If MsgBox("O formulário de Alvará não está aberto. Deseja abrir o formulário de Alvará?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                'verificar se o form está aberto, se sim, abrir o form
                If FrmAlvara.Visible = True Then
                    FrmAlvara.Focus()
                Else
                    'se não, abrir o form
                    FrmAlvara.Show()
                End If
            End If
        End If

    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub ExportarDados()
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
            PegaDados

            Dim RazaoSocial As String = FrmAlvara.RazaoSocialTextBox.Text
            'nova razao social, onde as primeiras letras sao maiusculas
            Dim RazaoSocialPequeno As String = Strings.StrConv(RazaoSocial, VbStrConv.ProperCase)



            Dim Cnpj As String = FrmAlvara.CNPJMaskedTextBox.Text

            Dim CEP As String = FrmAlvara.EndCEPMaskedTextBox.Text
            Dim Endereco As String = FrmAlvara.EnderecoTextBox.Text
            Endereco = Strings.StrConv(Endereco, VbStrConv.ProperCase)
            Endereco = Endereco.Substring(0, 1).ToLower() & Endereco.Substring(1)

            Dim Numero As String = FrmAlvara.EndNumTextBox.Text
            Dim Complemento As String = FrmAlvara.EndCompTextBox.Text
            'verificar se Complemento está vazio ou não
            If Complemento <> "" Then
                Complemento = ", " & Complemento
            End If
            Dim Bairro As String = FrmAlvara.EndBairroTextBox.Text
            Dim Cidade As String = FrmAlvara.EndCidadeTextBox.Text
            Dim Estado As String = FrmAlvara.EndEstadoTextBox.Text


            Dim Data As String = FrmAlvara.EndDataTextBox.Text
            Dim Quadra As String = FrmAlvara.EndQuadraTextBox.Text
            Dim Zona As String = FrmAlvara.EndZonaTextBox.Text

            Dim RamoDeAtividade As String = FrmAlvara.RamodeatividadeRichTextBox.Text

            'data de hoje dd em uma string, depois mmmm em uma string, e depois yyyy em uma string.
            Dim DataHojeDia As String = Date.Now.ToString("dd")
            Dim DataHojeMes As String = Date.Now.ToString("MMMM")
            Dim DataHojeAno As String = Date.Now.ToString("yyyy")


            Dim Requerente As String = FrmAlvara.RequerenteTextBox.Text
            'mudar formato de "PANIFICADORA" para "Panificadora".
            Dim ReqPequeno As String = Strings.StrConv(Requerente, VbStrConv.ProperCase)





            Dim CPF As String = FrmAlvara.CPFRequerenteMaskedTextBox.Text
            Dim RG As String = FrmAlvara.RGRequerenteTextBox.Text
            Dim OrgaoRG As String = FrmAlvara.OrgaoRGRequerenteTextBox.Text
            Dim EstadoRG As String = FrmAlvara.EstadoOrgaoRGRequerenteTextBox.Text

            Dim EnderecoRequerente As String = FrmAlvara.EndRequerenteTextBox.Text

            Dim EndCadImob As String = FrmAlvara.CadImobTextBox.Text

            Dim CMC As String = FrmAlvara.CMCTextBox.Text

            'Volta
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(0)
            Me.Focus()


            '/////////////////////////////////// DADOS /////////////////////////////////////
            '/////////////////////////////// INICIO CODIGO /////////////////////////////////
            'caminho do documento que vai ser modificado
            Dim Caminho As String = TextBoxCaminho.Text

            doc = word.Documents.Open(Caminho)
            rng = doc.Range(0, doc.Characters.Count)
            rng.Find.ClearFormatting()

            '@RazaoSocial
            rng.Find.Text = "@RazaoSocial"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RazaoSocial
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@CNPJ
            rng.Find.Text = "@CNPJ"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Cnpj
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Endereco
            rng.Find.Text = "@Endereco"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Endereco
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Bairro
            rng.Find.Text = "@EndBairro"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Bairro
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Complemento
            rng.Find.Text = "@Complemento"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Complemento
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@EndNum
            rng.Find.Text = "@EndNum"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Numero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Cidade
            rng.Find.Text = "@EndCidade"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Cidade
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Estado
            rng.Find.Text = "@EndEstado"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Estado
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@EndData
            rng.Find.Text = "@EndData"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Data
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@EndQuadra 
            rng.Find.Text = "@EndQuadra"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Quadra
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@EndZona
            rng.Find.Text = "@EndZona"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Zona
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@EndCEP
            rng.Find.Text = "@EndCEP"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CEP
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@RamodeatividadeRich
            rng.Find.Text = "@RamodeatividadeRich"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RamoDeAtividade
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Requerente
            rng.Find.Text = "@Requerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Requerente
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@CPFRequerente
            rng.Find.Text = "@CPFRequerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CPF
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@RG
            rng.Find.Text = "@RGRequerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)


            '@EndRequerente
            rng.Find.Text = "@EndRequerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EnderecoRequerente
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)


            '@Dia
            rng.Find.Text = "@Dia"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataHojeDia
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Mes
            rng.Find.Text = "@Mes"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataHojeMes
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@Ano
            rng.Find.Text = "@Ano"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataHojeAno
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@RG
            rng.Find.Text = "@RGRequerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@OrgaoRG
            rng.Find.Text = "@OrgaoRGRequerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OrgaoRG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@EstadoRG
            rng.Find.Text = "@EstadoRGRequerente"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EstadoRG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)


            '@EndCadImob
            rng.Find.Text = "@EndCadImob"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EndCadImob
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@CMC
            rng.Find.Text = "@CMC"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CMC
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@RazaoSocialPequeno
            rng.Find.Text = "@RazaoPequeno"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RazaoSocialPequeno
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '@RequerentePequeno
            rng.Find.Text = "@ReqPequeno"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = ReqPequeno
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            '/////////////////////////////// FIM CODIGO /////////////////////////////////


            '/////////////////////////////// Início sobre tratameto dos socios CODIGO /////////////////////////////////

            Dim NomeSocioPergunta As String = FrmAlvara.RequerenteTextBox.Text
            Dim MessageGenero As String = "Deseja fazer o tratamento do genero do sócio =" & NomeSocioPergunta & "?"
            Dim resultGenero As Integer = MessageBox.Show(MessageGenero, "Prince Alerta", MessageBoxButtons.YesNo)
            If resultGenero = DialogResult.Yes Then
                'verificar se o FrmSocios está aberta
                If FrmSocios.Visible = True Then
                    'fechar o FrmSocios
                    FrmSocios.Close()
                    FrmSocios.Show()
                    FrmSocios.NomeCompletoComboBox.Text = LabelSocio.Text
                    ExportarSocios()

                Else
                    FrmSocios.Show()
                    FrmSocios.NomeCompletoComboBox.Text = LabelSocio.Text
                    ExportarSocios()
                End If

            Else
            End If





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
                    Message = "Arquivo salvo com sucesso!"

                End If
            ElseIf result = DialogResult.No Then
                doc.Save()
                doc.Close()
                doc = Nothing
                'mgs salvo com sucesso
                Message = "Arquivo salvo com sucesso!"
            ElseIf result = DialogResult.Cancel Then
                doc.Close()
                doc = Nothing
            End If

            'esconder PictureBoxAguarde com imagem "aguarde"
            PictureBoxAguarde.Visible = False
            PictureBoxAguarde.Image = Nothing
            'Mostra os botao de abrir ok e cancelar e fechar
            BtnAbrir.Enabled = True
            BtnAdicionar.Enabled = True
            BtnContrato.Enabled = True
            BtnDados.Enabled = True
            OK_Button.Enabled = True
            Cancel_Button.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            doc.Close()
            doc = Nothing
        End Try

    End Sub

    Private Sub PegaDados()
        'pega dados
        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(1)
        FrmAlvara.TabControl2.SelectTab(2)
        FrmAlvara.TabControl2.SelectTab(3)
        FrmAlvara.TabControl2.SelectTab(4)
        FrmAlvara.TabControl2.SelectTab(5)
        Me.Focus()
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

            Dim MaiuSocio As String

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

            'Titular
            'Dim MaiuscTitular As String
            'Dim MinusTitular As String
            'Dim MaiuscOTitular As String
            'Dim MinusOTitular As String

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
                MaiuSocio = "Sócio"

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
                MaiuSocio = "Sócia"

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
            rng.Find.Replacement.Text = Rua
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

            '@MaiuSocio
            rng.Find.Text = "@" & NumeroSocio & "MaiuSocio"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = MaiuSocio
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



        Catch ex As Exception
            'mostra onde está o erro
            MessageBox.Show(ex.Message)
            doc.Save()
            doc.Close()
            doc = Nothing
        End Try


    End Sub



    Private Sub ExportarLaudoWordDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'desabilita PictureBoxAguarde
        PictureBoxAguarde.Visible = False
        PegaDados()
        LabelEmpresa.Text = FrmAlvara.RazaoSocialTextBox.Text
        LabelSocio.Text = FrmAlvara.RequerenteTextBox.Text
    End Sub

    Private Sub BtnAbrirSocio_Click(sender As Object, e As EventArgs) Handles BtnAbrirSocio.Click
        'verificar se o FrmSocios está aberta
        If FrmSocios.Visible = True Then
            'fechar o FrmSocios
            FrmSocios.Close()
            FrmSocios.Show()
            FrmSocios.NomeCompletoComboBox.Text = LabelSocio.Text
        Else
            FrmSocios.Show()
            FrmSocios.NomeCompletoComboBox.Text = LabelSocio.Text
        End If
    End Sub
End Class
