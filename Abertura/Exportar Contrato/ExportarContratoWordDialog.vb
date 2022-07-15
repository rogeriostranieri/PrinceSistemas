Imports Microsoft.Office.Interop.Word

Public Class ExportarContratoWordDialog

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

            'Dados
            Dim CPF As String = FrmSocios.CPFMaskedTextBox.Text
            Dim NomeCompleto As String = FrmSocios.NomeCompletoTextBox.Text
            Dim NomeDaMae As String = FrmSocios.NomeMaeTextBox.Text
            Dim NomeDaPai As String = FrmSocios.NomePaiTextBox.Text

            'clicar no BtnExtensoDN
            Dim DataDeNascimento As String = FrmSocios.DatadeNascMaskedTextBox.Text
            Dim DataDeNascimentoFormatada As String = Format(CDate(DataDeNascimento), "dd 'de' MMMM 'de' yyyy")
            Dim DataNascimento As String = DataDeNascimentoFormatada



            Dim RG As String = FrmSocios.RGTextBox.Text
            Dim OrgaoRG As String = FrmSocios.OrgaoRGTextBox.Text
            Dim EstadoRG As String = FrmSocios.EstadoRGTextBox.Text
            Dim SenhaGOV As String = FrmSocios.SenhaGOVTextBox.Text
            Dim TituloDeEleitor As String = FrmSocios.TituloDeEleitorTextBox.Text
            Dim CNH As String = FrmSocios.CNHTextBox.Text
            Dim ExpediçãoCNH As String = FrmSocios.CNHExpedicaoTextBox.Text
            Dim DataExpediçãoCNH As String = FrmSocios.CNHDataExpTextBox.Text
            Dim EstadoCivil As String = FrmSocios.CivilComboBox.Text
            Dim Empresario As String
            Dim Genero As String = FrmSocios.GeneroComboBox.Text
            Dim domiciliado As String

            'endereço
            Dim RUA As String = FrmSocios.RUATextBox.Text
            'primeira letra da RUA em minusculo
            Dim RUA1 As String = RUA.Substring(0, 1).ToLower() & RUA.Substring(1)
            Dim N As String = FrmSocios.NumTextBox.Text

            'For Each next
            Dim Compl As String = FrmSocios.ComplementoTextBox.Text
            For Each Compl In FrmSocios.ComplementoTextBox.Text
                'verificar se tem complemento FrmSocios.ComplementoTextBox.Text, 
                'se tiver, adicionar "," antes do complemento
                If Compl <> "" Then
                    Compl = "," & Compl
                End If
            Next



            Dim Bairro As String = FrmSocios.BairroTextBox.Text
            Dim CEP As String = FrmSocios.CEPMaskedTextBox.Text
            Dim Cidade As String = FrmSocios.CidadeTextBox.Text
            Dim Estado As String = FrmSocios.EstadoTextBox.Text
            Dim Portador As String
            Dim Brasileiro As String
            Dim Nascido As String
            Dim Genero1 As String
            Dim Genero2 As String

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




            'verificar se está no masculino ou feminio no campo GeneroComboBox
            If Genero = "Masculino" Then
                'verificar se está no masculino e mudar para solteiro do  CivilComboBox da lista
                ' EstadoCivil = "solteiro"
                Empresario = "empresário"
                domiciliado = "domiciliado"
                Portador = "portador"
                Brasileiro = "brasileiro"
                Nascido = "nascido em"
                Genero1 = "Sócio"
                Genero2 = "o sócio"
                AdministradorMaiuscula = "Administrador"
                OAdministradorMaiuscula = "O administrador"
                AdministradorMinuscula = "administrador"
                OAdministradorMinuscula = "o administrador"
                AdministradoresMaiuscula = "Administradores"
                OAdministradoresMinuscula = "Os administradores"
                AdministradoresMinuscula = "administradores"
                OAdministradoresMaiuscula = "os administradores"

            ElseIf Genero = "Feminino" Then
                'EstadoCivil = "solteira"
                Empresario = "empresária"
                domiciliado = "domiciliada"
                Portador = "portadora"
                Brasileiro = "brasileira"
                Nascido = "nascida em"
                Genero1 = "Sócia"
                Genero2 = "a sócia"
                AdministradorMaiuscula = "Administradora"
                OAdministradorMaiuscula = "A administradora"
                AdministradorMinuscula = "administradora"
                OAdministradorMinuscula = "a administradora"
                AdministradoresMaiuscula = "Administradoras"
                OAdministradoresMinuscula = "As administradoras"
                AdministradoresMinuscula = "administradoras"
                OAdministradoresMaiuscula = "as administradoras"

            End If

            Dim NumeroSocio As String = FrmSocios.ComboBox1.Text

            'caminho do documento que vai ser modificado
            Dim Caminho As String = TextBoxCaminho.Text

            doc = word.Documents.Open(Caminho)
            rng = doc.Range(0, doc.Characters.Count)
            rng.Find.ClearFormatting()

            'CPF
            rng.Find.Text = "@" & NumeroSocio & "CPF"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CPF
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'NomeCompleto"
            rng.Find.Text = "@" & NumeroSocio & "Socio"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NomeCompleto
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'DataDeNascimento
            rng.Find.Text = "@" & NumeroSocio & "DataDeNascimento"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = DataNascimento
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'RG
            rng.Find.Text = "@" & NumeroSocio & "RG"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'OrgaoRG
            rng.Find.Text = "@" & NumeroSocio & "OrgaoRG"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = OrgaoRG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'EstadoRG
            rng.Find.Text = "@" & NumeroSocio & "EstadoRG"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EstadoRG
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'EstadoCivil
            rng.Find.Text = "@" & NumeroSocio & "EstadoCivil"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = EstadoCivil
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Genero
            rng.Find.Text = "@" & NumeroSocio & "Genero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Genero
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Empresario
            rng.Find.Text = "@" & NumeroSocio & "Empresario"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Empresario
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'domiciliado
            rng.Find.Text = "@" & NumeroSocio & "domiciliado"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = domiciliado
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Portador
            rng.Find.Text = "@" & NumeroSocio & "Portador"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Portador
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Brasileiro
            rng.Find.Text = "@" & NumeroSocio & "Brasileiro"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Brasileiro
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Nascido
            rng.Find.Text = "@" & NumeroSocio & "Nascido"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Nascido
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'RUA
            rng.Find.Text = "@" & NumeroSocio & "Rua"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = RUA1
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Numero
            rng.Find.Text = "@" & NumeroSocio & "Numero"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = N
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Complemento
            rng.Find.Text = "@" & NumeroSocio & "Complemento"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Compl
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Bairro
            rng.Find.Text = "@" & NumeroSocio & "Bairro"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Bairro
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Cidade
            rng.Find.Text = "@" & NumeroSocio & "Cidade"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Cidade
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'Estado
            rng.Find.Text = "@" & NumeroSocio & "Estado"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Estado
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

            'CEP
            rng.Find.Text = "@" & NumeroSocio & "CEP"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = CEP
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)




            '////////////////////// NOME PEQUENO DO SOCIO ///////////////////////////////   
            'com a 1 letra ToUpper e o resto ToLower
            'e depois @NomeCompleto
            Dim NomePequeno As String = FrmSocios.NomeCompletoTextBox.Text
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

            'NomeCompleto
            rng.Find.Text = "@" & NumeroSocio & "NomeCompleto"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = NomePequeno2
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)



            '//////////////////////////////////  GENERO  /////////////////////////
            'Verificar Masculino e Feminino no Contrato em geral
            'Genero1 maisculo
            rng.Find.Text = "@" & NumeroSocio & "Genero1"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Genero1
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)
            'Genero2 minúsculo
            rng.Find.Text = "@" & NumeroSocio & "Genero2"
            rng.Find.Replacement.ClearFormatting()
            rng.Find.Replacement.Text = Genero2
            rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)




            '/////////////////////// + de 2 Socios  Capital Social TABELA ///////////////////////////
            'dados 
            ' FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Text
            'pegar nome do socio da primeira linha
            Dim PegarLinha As New List(Of String)
            PegarLinha = FrmLegalizacao.DivisaoCapitalSociosRichTextBox.Lines.ToList()
            Dim Nlinha As String = NumeroSocio
            'se a resposta do Nlinha for vazia, não faz nada
            If Nlinha = "" Then
                'Exit Sub
            Else
                'se a resposta do Nlinha for um numero, remove a linha
                If IsNumeric(Nlinha) Then
                    'PegarLinha.RemoveAt(Nlinha - 1)
                    'DivisaoCapitalSociosRichTextBox.Text = String.Join(vbCrLf, PegarLinha)
                    'pegar nome do socio antes da virgula "," da linha Nlinha
                    Dim SocioTabela As String = PegarLinha(Nlinha - 1).Substring(0, PegarLinha(Nlinha - 1).IndexOf(" - "))
                    'pegar o valor em Reais do socio depois da virgula "," da linha Nlinha
                    Dim CapitalSocialTabela As String = PegarLinha(Nlinha - 1).Substring(PegarLinha(Nlinha - 1).IndexOf(" - ") + 1)
                    'Pegar valor sem os reais e com os centavos
                    Dim CapitalQuotaTabela As String
                    'CapitalSocialTabela sem os R$ e ,00
                    CapitalQuotaTabela = CapitalSocialTabela.Replace("R$", "").Replace(",", "").Replace(" - ", "").Replace(" ", "")


                    'SocioTabela
                    rng.Find.Text = "@" & NumeroSocio & "SocioTabela"
                    rng.Find.Replacement.ClearFormatting()
                    rng.Find.Replacement.Text = SocioTabela
                    rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                    'CapitalSocialTabela
                    rng.Find.Text = "@" & NumeroSocio & "CapitalSocialTabela"
                    rng.Find.Replacement.ClearFormatting()
                    rng.Find.Replacement.Text = CapitalSocialTabela
                    rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                    'CapitalQuotaTabela
                    rng.Find.Text = "@" & NumeroSocio & "CapitalQuotaTabela"
                    rng.Find.Replacement.ClearFormatting()
                    rng.Find.Replacement.Text = CapitalQuotaTabela
                    rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                    'Total de Capital Social
                    Dim TotalCapitalSocial As String = ""
                    For i = 0 To PegarLinha.Count - 1
                        TotalCapitalSocial += PegarLinha(i).Substring(PegarLinha(i).IndexOf(" - ") + 1)
                    Next
                    TotalCapitalSocial = TotalCapitalSocial.Replace("R$", "").Replace(",", "").Replace(" - ", "").Replace(" ", "")
                    'TotalCapitalSocial
                    rng.Find.Text = "@" & NumeroSocio & "TotalCapitalSocial"
                    rng.Find.Replacement.ClearFormatting()
                    rng.Find.Replacement.Text = "R$ " & TotalCapitalSocial
                    rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                    'Total de Capital Social Quotas
                    Dim TotalCapitalSocialQuotas As String = ""
                    For i = 0 To PegarLinha.Count - 1
                        TotalCapitalSocialQuotas += PegarLinha(i).Substring(PegarLinha(i).IndexOf(",") + 1).Replace("R$", "").Replace(",", "").Replace(" - ", "").Replace(" ", "")
                    Next
                    TotalCapitalSocialQuotas = TotalCapitalSocialQuotas.Replace("R$", "").Replace(",", "").Replace(" - ", "").Replace(" ", "")
                    'TotalCapitalSocialQuotas
                    rng.Find.Text = "@" & NumeroSocio & "TotalCapitalSocialQuotas"
                    rng.Find.Replacement.ClearFormatting()
                    rng.Find.Replacement.Text = TotalCapitalSocialQuotas
                    rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                Else
                    'se a resposta do Nlinha for uma letra, não faz nada
                    MsgBox("Erro em achar socios na tabela", MsgBoxStyle.Exclamation, "Atenção")
                End If
            End If

            '//////////////////////////////////////////////////////////////////////////////////////////////









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
            MsgBox(ex.Message)
        End Try
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
        If TextBoxCaminho.Text.Substring(TextBoxCaminho.Text.Length - 5, 5) = ".docx" Then
            If MsgBox("Deseja exportar os dados da empresa aberto para o Contrato Social?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
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
        'pega dados
        FrmLegalizacao.TabControle.SelectTab(2)

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


        'endereço
        Dim RUA As String = FrmLegalizacao.EnderecoTextBox.Text
        'primeira letra da RUA em minusculo
        Dim RUA1 As String = RUA.Substring(0, 1).ToLower() & RUA.Substring(1)
        Dim Numero As String = FrmLegalizacao.EndNumeroTextBox.Text
        'verificar se tem complemento EndComplementoTextBox
        'For Each next
        Dim Complemento As String = FrmLegalizacao.EndComplementoTextBox.Text
        For Each Complemento In FrmLegalizacao.EndComplementoTextBox.Text
            'verificar se tem complemento FrmSocios.ComplementoTextBox.Text, 
            'se tiver, adicionar "," antes do complemento
            If Complemento <> "" Then
                Complemento = "," & Complemento
            End If
        Next
        Dim Bairro As String = FrmLegalizacao.EndBairroTextBox.Text
        Dim CEP As String = FrmLegalizacao.EndCEPMaskedTextBox.Text
        Dim Cidade As String = FrmLegalizacao.EndCidadeTextBox.Text
        Dim UF As String = FrmLegalizacao.EndEstadoTextBox.Text


        'EmpInicioAtividade 
        Dim EmpInicioAtividade As String = FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text
        Dim EmpInicioAtividadeFormatada As String = Format(CDate(EmpInicioAtividade), "dd 'de' MMMM 'de' yyyy")
        Dim InicioDeAtividadeFinal As String = EmpInicioAtividadeFormatada

        'EmpInicioAtividade 
        Dim DataAssinatura As String = FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text
        Dim DataAssinatura1 As String = Format(CDate(DataAssinatura), "" & Cidade & "'-'" & UF & "',' dd 'de' MMMM 'de' yyyy'.'")
        Dim DataAssinaturaFinal As String = DataAssinatura1


        'RamoDeAtividadeRichTextBox 
        Dim RamoDeAtividade As String = FrmLegalizacao.RamoDeAtividadeRichTextBox.Text


        'CapitalSocial(tambem extenso)
        Dim CapitalSocialNumero As String = FrmLegalizacao.CapitalSTextBox.Text
        'CapitalSocialNumero em decimal
        Dim CapitalSocialDecimal As Decimal = CDec(CapitalSocialNumero)
        'CapitalSocialNumero em extenso
        Dim CapitalSocialExtenso As String = NumberToEuro(CapitalSocialDecimal)



        '/////////////////////////////// INICIO CODIGO /////////////////////////////////
        'caminho do documento que vai ser modificado
        Dim Caminho As String = TextBoxCaminho.Text

        doc = word.Documents.Open(Caminho)
        rng = doc.Range(0, doc.Characters.Count)
        rng.Find.ClearFormatting()

        'AntigaRazaoSocial
        rng.Find.Text = "@AntigaRazaoSocial"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = AntigaRazaoSocial
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'NovaRazaoSocial
        rng.Find.Text = "@NovaRazaoSocial"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = NovaRazaoSocial
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'RUA
        rng.Find.Text = "@RUA"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = RUA1
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'Numero
        rng.Find.Text = "@Numero"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = Numero
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'Complemento
        rng.Find.Text = "@Complemento"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = Complemento
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'Bairro
        rng.Find.Text = "@Bairro"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = Bairro
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'CEP
        rng.Find.Text = "@CEP"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = CEP
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'Cidade
        rng.Find.Text = "@Cidade"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = Cidade
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'UF
        rng.Find.Text = "@UF"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = UF
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'InicioDeAtividadeFinal
        rng.Find.Text = "@InicioDeAtividade"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = InicioDeAtividadeFinal
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'InicioDeAtividadeFinal1
        rng.Find.Text = "@DataAssinatura"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = DataAssinaturaFinal
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'RamoDeAtividade
        rng.Find.Text = "@RamoDeAtividade"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = RamoDeAtividade
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'CapitalSocialExtenso
        rng.Find.Text = "@CapitalSocialExtenso"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = CapitalSocialExtenso
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        'CapitalSocialNumero
        rng.Find.Text = "@CapitalSocialNumero"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = CapitalSocialNumero
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)



        '/////////////////////////////// FIM CODIGO /////////////////////////////////


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


End Class
