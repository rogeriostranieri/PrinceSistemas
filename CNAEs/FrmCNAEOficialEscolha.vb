Imports System.Text.RegularExpressions

Public Class FrmCNAEOficialEscolha
    Private Sub FrmCNAEOficialEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Verifica se a tecla pressionada é a tecla Esc
        If keyData = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
            Return True
        End If

        ' Se não for a tecla Esc, usa o comportamento padrão
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Método para processar o CNAE Principal
    Private Sub ProcessarCNAEPrincipal()
        ' Obter o texto completo do RichTextBox TodosCNAERichTextBox
        Dim textoCNAE As String = TodosCNAERichTextBox.Text

        ' Expressão regular para capturar a seção "Principal:" com CNAE e descrição
        Dim regexPrincipal As New Regex("Principal:\s*(?<CNAE>[\d/-]+)\s*(?<Descricao>[^\n\r]+)")
        Dim matchPrincipal As Match = regexPrincipal.Match(textoCNAE)

        If matchPrincipal.Success Then
            ' Extrair o CNAE e a Descrição do Principal
            Dim cnaePrincipal As String = matchPrincipal.Groups("CNAE").Value.Trim()
            Dim descricaoPrincipal As String = matchPrincipal.Groups("Descricao").Value.Trim()

            ' Preencher os campos correspondentes
            CNAEPrincipalTextBox.Text = cnaePrincipal
            RamoDeAtividadeRichTextBox.Text = descricaoPrincipal & vbCrLf
        Else
            ' Se não encontrar o CNAE Principal, limpa os campos
            CNAEPrincipalTextBox.Clear()
            RamoDeAtividadeRichTextBox.Clear()
        End If
    End Sub

    ' Método para processar os CNAEs Secundários
    Private Sub ProcessarCNAESecundarios()
        ' Obter o texto completo do RichTextBox TodosCNAERichTextBox
        Dim textoCNAE As String = TodosCNAERichTextBox.Text

        ' Procurar o índice do texto "Secundário:"
        Dim indiceSecundario As Integer = textoCNAE.IndexOf("Secundário:")
        If indiceSecundario >= 0 Then
            ' Extrair todas as linhas após "Secundário:"
            Dim textoSecundario As String = textoCNAE.Substring(indiceSecundario + "Secundário:".Length).Trim()

            ' Dividir o texto em linhas e processar cada linha
            Dim linhasSecundarias As String() = Regex.Split(textoSecundario, vbCrLf & "|" & vbLf)

            ' Limpar o RichTextBox de CNAEs Secundários antes de começar a preencher
            CNAESecundarioRichTextBox.Clear()

            ' Processar cada linha abaixo de "Secundário:"
            For Each linha As String In linhasSecundarias
                linha = linha.Trim() ' Remover espaços em branco extras

                ' Verificar se a linha não está vazia
                If Not String.IsNullOrWhiteSpace(linha) Then
                    ' Expressão regular para capturar o CNAE e a descrição em cada linha
                    Dim cnaeMatch As Match = Regex.Match(linha, "^(?<CNAE>[\d/-]+)\s*(?<Descricao>.+)")
                    If cnaeMatch.Success Then
                        ' Capturar o CNAE e a descrição da linha atual
                        Dim cnaeAtual As String = cnaeMatch.Groups("CNAE").Value.Trim()
                        Dim descricaoAtual As String = cnaeMatch.Groups("Descricao").Value.Trim()

                        ' Adicionar o CNAE ao RichTextBox de CNAE Secundário
                        CNAESecundarioRichTextBox.AppendText(cnaeAtual & vbCrLf)

                        ' Adicionar a descrição ao RichTextBox de Ramo de Atividade, após o texto do principal
                        RamoDeAtividadeRichTextBox.AppendText(descricaoAtual & vbCrLf)
                    End If
                End If
            Next
            ' Verificar se o formulário FrmCNAEoficial está aberto e fechá-lo
            If Application.OpenForms.OfType(Of FrmCNAEoficial).Any Then
                Application.OpenForms.OfType(Of FrmCNAEoficial).First.Close()
            End If

            ' Fechar o formulário atual
            Me.Close()
        End If
    End Sub

    Private Sub Adicionar_Button_Click(sender As Object, e As EventArgs) Handles Adicionar_Button.Click

        If RamoDeAtividadeRichTextBox.Text <> "" Then
            ' Pergunta se deseja exportar após o processamento
            Dim resposta As DialogResult = MessageBox.Show("Deseja exportar?", "Exportar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Se o usuário desejar exportar
            If resposta = DialogResult.Yes Then
                ' Verifica se o formulário FrmLegalizacao está ativo e visível
                If FrmLegalizacao.Visible Then
                    ' Foco no formulário FrmLegalizacao
                    FrmLegalizacao.Focus()

                    ' Focar na aba 1 do TabControl
                    FrmLegalizacao.TabControle.SelectedIndex = 1
                    FrmLegalizacao.TabControl2.SelectedIndex = 2

                    ' Exporta os dados do FrmCNAEOficialEscolha para o FrmLegalizacao
                    If FrmLegalizacao.RamoDeAtividadeRichTextBox.Text = "" Then
                        FrmLegalizacao.RamoDeAtividadeRichTextBox.Text = Me.RamoDeAtividadeRichTextBox.Text
                    End If

                    FrmLegalizacao.CNAEPrincipalTextBox.Text = Me.CNAEPrincipalTextBox.Text
                        FrmLegalizacao.CNAESecundarioRichTextBox.Text = Me.CNAESecundarioRichTextBox.Text
                        FrmLegalizacao.Focus()
                        'MessageBox.Show("Dados exportados com sucesso!", "Exportação Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Se o FrmLegalizacao não estiver aberto, exibe mensagem
                        MessageBox.Show("O formulário FrmLegalizacao não está aberto. Abra o formulário para exportar os dados.", "FrmLegalizacao Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Campos vazios, negado a exportação!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        ' Primeiro, processa o CNAE Principal
        ProcessarCNAEPrincipal()

        ' Em seguida, processa os CNAEs Secundários
        ProcessarCNAESecundarios()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
End Class