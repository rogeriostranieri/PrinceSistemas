Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FrmCNAEtexto
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub FrmCNAEtexto_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmCNAEtexto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmCNAEtexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosCNAE()
    End Sub

    Private Sub CarregarDadosCNAE()
        If FormulariosAbertos() Then
            Dim cnaes As String() = PegarCNAEsDosFormularios()
            ProcurarCNAEsNoBanco(cnaes)
            PreencherCheckedListBoxCNAE(cnaes) ' Chama o novo método para preencher a CheckedListBox
            ' Atualiza o CheckedListBoxCNAE conforme o valor do ComboBox no FrmLegalizacao
            AtualizarEstadoCheckedListBox()
        End If
    End Sub

    Private Sub PreencherCheckedListBoxCNAE(cnaes As String())
        ' Limpa os itens existentes na CheckedListBoxCNAE antes de adicionar os novos
        CheckedListBoxCNAE.Items.Clear()

        ' Adiciona cada CNAE na CheckedListBox sem marcar
        For Each cnae As String In cnaes
            If Not String.IsNullOrWhiteSpace(cnae) Then
                CheckedListBoxCNAE.Items.Add(cnae, False) ' False para adicionar sem marcar
            End If
        Next
    End Sub

    Private Function FormulariosAbertos() As Boolean
        Return (CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao) IsNot Nothing Or
                CType(Application.OpenForms("FrmAlvara"), FrmAlvara) IsNot Nothing)
    End Function

    Private Function PegarCNAEsDosFormularios() As String()
        Dim cnaes As New List(Of String)

        ' Verificar se o formulário FrmLegalizacao está aberto
        If Application.OpenForms("FrmLegalizacao") IsNot Nothing Then
            Dim frmLegalizacao As FrmLegalizacao = CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao)

            ' Adicionar o CNAE principal e secundário de FrmLegalizacao
            cnaes.Add(frmLegalizacao.CNAEPrincipalTextBox.Text)
            cnaes.AddRange(frmLegalizacao.CNAESecundarioRichTextBox.Lines)
        End If

        ' Verificar se o formulário FrmAlvara está aberto
        If Application.OpenForms("FrmAlvara") IsNot Nothing Then
            Dim frmAlvara As FrmAlvara = CType(Application.OpenForms("FrmAlvara"), FrmAlvara)

            ' Adicionar o CNAE primário e secundário de FrmAlvara
            cnaes.Add(frmAlvara.CNAEPrimarioTextBox.Text)
            cnaes.AddRange(frmAlvara.CNAERichTextBox.Lines)
        End If

        ' Retorna os CNAEs encontrados
        Return cnaes.ToArray()
    End Function

    Private Sub AtualizarEstadoCheckedListBox()
        ' Verificar se o formulário FrmLegalizacao está aberto
        If Application.OpenForms("FrmLegalizacao") IsNot Nothing Then
            Dim frmLegalizacao As FrmLegalizacao = CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao)

            ' Verificar o valor selecionado em CNAEAtividadeNoLocalComboBox
            Select Case frmLegalizacao.CNAEAtividadeNoLocalComboBox.Text
                Case "Todos", "Parcial"
                    ' Marcar todos os itens no CheckedListBoxCNAEs
                    For i As Integer = 0 To CheckedListBoxCNAE.Items.Count - 1
                        CheckedListBoxCNAE.SetItemChecked(i, True)
                    Next
                Case "Não"
                    ' Desmarcar todos os itens no CheckedListBoxCNAEs
                    For i As Integer = 0 To CheckedListBoxCNAE.Items.Count - 1
                        CheckedListBoxCNAE.SetItemChecked(i, False)
                    Next
            End Select
        End If
    End Sub

    Private Sub ProcurarCNAEsNoBanco(cnaes As String())
        Using conexao As New SqlConnection(connectionString)
            conexao.Open()

            For Each cnae As String In cnaes
                Using comando As New SqlCommand("SELECT Subclasse, descrição FROM CNAESubclasses23 WHERE Subclasse = @cnae", conexao)
                    comando.Parameters.AddWithValue("@cnae", cnae)

                    Dim resultado As SqlDataReader = comando.ExecuteReader()

                    If resultado.Read() Then
                        AdicionarCNAENoRichTextBox(cnae, resultado("descrição").ToString())
                    Else
                        AdicionarCNAENaoEncontradoNoBanco(cnae)
                    End If

                    resultado.Close()
                End Using
            Next
        End Using
    End Sub

    Private Sub AdicionarCNAENoRichTextBox(cnae As String, descrição As String)
        With RichTextBox1
            .AppendText(cnae)
            .SelectionColor = Color.Black
            .AppendText(" - ")
            .SelectionFont = New Font(.Font, FontStyle.Bold)
            .SelectionColor = Color.Black
            .SelectionFont = New Font(.Font, FontStyle.Regular)
            .AppendText(descrição & vbCrLf)
        End With
    End Sub

    Private Sub AdicionarCNAENaoEncontradoNoBanco(cnae As String)
        With RichTextBox1
            .AppendText("CNAE não encontrado no banco de dados: ")
            .SelectionColor = Color.Red
            .AppendText(cnae & vbCrLf)
        End With
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        ' Não é necessário fazer nada aqui
    End Sub

    ' Função para verificar se o CNAE está marcado como "Sim" ou "Não" no CheckedListBox
    ' Função para verificar se o CNAE está marcado como "Sim" ou "Não" no CheckedListBoxCNAEs
    Private Function IsCnaeSelected(cnaeDescricao As String) As Boolean
        ' Percorre todos os itens no CheckedListBoxCNAEs para verificar se está marcado
        For i As Integer = 0 To CheckedListBoxCNAE.Items.Count - 1
            ' Verifica se o item atual corresponde à descrição do CNAE e está marcado
            If CheckedListBoxCNAE.Items(i).ToString().Trim() = cnaeDescricao AndAlso CheckedListBoxCNAE.GetItemChecked(i) Then
                Return True ' Retorna True se o item estiver marcado
            End If
        Next
        Return False ' Retorna False se o item não estiver marcado
    End Function



    Private Sub BtnExportAtiv_Click(sender As Object, e As EventArgs) Handles BtnExportAtiv.Click
        ' Obter o texto completo do RichTextBox1
        Dim textoCNAE As String = RichTextBox1.Text

        ' Dividir o texto em linhas
        Dim linhas As String() = Regex.Split(textoCNAE, vbCrLf & "|" & vbLf)
        Dim resultado As New List(Of String)

        ' Função auxiliar para verificar se o CNAE está marcado no CheckedListBoxCNAE
        Dim IsCnaeChecked As Func(Of String, Boolean) = Function(cnaeCodigo As String) As Boolean
                                                            For i As Integer = 0 To CheckedListBoxCNAE.Items.Count - 1
                                                                If CheckedListBoxCNAE.Items(i).ToString().Trim() = cnaeCodigo AndAlso CheckedListBoxCNAE.GetItemChecked(i) Then
                                                                    Return True
                                                                End If
                                                            Next
                                                            Return False
                                                        End Function

        ' Processar cada linha para adicionar "Sim" ou "Não" com base no CheckedListBoxCNAE
        For Each linha As String In linhas
            ' Captura o código CNAE da linha usando regex (formato XXXX-X/XX)
            Dim cnaeMatch As Match = Regex.Match(linha, "^(\d{4}-\d/\d{2})\s-\s(.+)")
            If cnaeMatch.Success Then
                ' Código CNAE sem a descrição
                Dim cnaeCodigo As String = cnaeMatch.Groups(1).Value.Trim()
                ' Descrição completa da linha
                Dim descricaoCompleta As String = cnaeMatch.Groups(2).Value.Trim()

                ' Verifica se o CNAE está marcado no CheckedListBoxCNAE
                Dim statusCnae As String = If(IsCnaeChecked(cnaeCodigo), "(Sim) - ", "(Não) - ")

                ' Adiciona o status e a descrição completa ao resultado
                resultado.Add(statusCnae & cnaeCodigo & " - " & descricaoCompleta)
            End If
        Next

        ' Separar a descrição principal das secundárias
        Dim descricaoPrincipal As String = If(resultado.Count > 0, resultado(0), String.Empty)
        Dim descricoesSecundarias As String = String.Join("; " & Environment.NewLine, resultado.Skip(1)) & "; "

        ' Verificar se o formulário FrmLegalizacao está aberto
        Dim frmLegalizacao = Application.OpenForms.OfType(Of FrmLegalizacao).FirstOrDefault()
        If frmLegalizacao IsNot Nothing Then
            frmLegalizacao.Focus()

            ' Verificar se o CNAEAtvLocalPrincipalTextBox já contém texto
            If Not String.IsNullOrWhiteSpace(frmLegalizacao.CNAEAtvLocalPrincipalTextBox.Text) Then
                Dim resultadoLimpar As DialogResult = MessageBox.Show("Os campos já contêm texto. Deseja limpar e substituir pelo novo conteúdo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultadoLimpar = DialogResult.Yes Then
                    frmLegalizacao.CNAEAtvLocalPrincipalTextBox.Clear()
                    frmLegalizacao.CNAEAtvLocalSEcundariosRichTextBox.Clear()
                    frmLegalizacao.CNAEAtvLocalPrincipalTextBox.Text = descricaoPrincipal
                    frmLegalizacao.CNAEAtvLocalSEcundariosRichTextBox.Text = descricoesSecundarias
                    Me.Close()
                Else
                    Exit Sub
                End If
            Else
                frmLegalizacao.CNAEAtvLocalPrincipalTextBox.Text = descricaoPrincipal
                frmLegalizacao.CNAEAtvLocalSEcundariosRichTextBox.Text = descricoesSecundarias
                Me.Close()
            End If
        Else
            MsgBox("O Formulário Empresas não está aberto.", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub



End Class
