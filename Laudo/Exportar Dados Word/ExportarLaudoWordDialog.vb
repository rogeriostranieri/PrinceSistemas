Imports Microsoft.Office.Interop.Word
Imports System.Windows.Forms

Public Class ExportarLaudoWordDialog

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
        EscolherArquivo()
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
        '  Try
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        Dim rng As Microsoft.Office.Interop.Word.Range

        'pega dados
        FrmAlvara.TabAlvara.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(0)
        FrmAlvara.TabControl2.SelectTab(1)
        FrmAlvara.TabControl2.SelectTab(2)
        FrmAlvara.TabControl2.SelectTab(3)
        FrmAlvara.TabControl2.SelectTab(4)
        FrmAlvara.TabControl2.SelectTab(5)

        Dim RazaoSocial As String = FrmAlvara.RazaoSocialTextBox.Text
        Dim Cnpj As String = FrmAlvara.CNPJMaskedTextBox.Text

        Dim Endereco As String = FrmAlvara.EnderecoTextBox.Text
        'primeira letra da RUA em minusculo
        Dim Endereco1 As String = Endereco.Substring(0, 1).ToLower() & Endereco.Substring(1)

        Dim Numero As String = FrmAlvara.EndNumTextBox.Text


        Dim Complemento As String = FrmAlvara.EndCompTextBox.Text
        'verificar se Complemento está vazio ou não
        If Complemento <> "" Then
            Complemento = ", " & Complemento
        End If



        Dim Data As String = FrmAlvara.EndDataTextBox.Text
        Dim Quadra As String = FrmAlvara.EndQuadraTextBox.Text
        Dim Zona As String = FrmAlvara.EndZonaTextBox.Text
        Dim CEP As String = FrmAlvara.EndCEPMaskedTextBox.Text

        Dim RamoDeAtividade As String = FrmAlvara.RamodeatividadeRichTextBox.Text

        'data de hoje dd em uma string, depois mmmm em uma string, e depois yyyy em uma string.
        Dim DataHojeDia As String = Date.Now.ToString("dd")
        Dim DataHojeMes As String = Date.Now.ToString("MMMM")
        Dim DataHojeAno As String = Date.Now.ToString("yyyy")


        Dim Requerente As String = FrmAlvara.RequerenteTextBox.Text
        Dim CPF As String = FrmAlvara.CPFRequerenteMaskedTextBox.Text

        Dim EnderecoRequerente As String = FrmAlvara.EndRequerenteTextBox.Text

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
        rng.Find.Replacement.Text = Endereco1
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

    End Sub

    Private Sub ExportarLaudoWordDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
