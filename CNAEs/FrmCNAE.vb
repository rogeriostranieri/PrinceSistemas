Imports System.Data.SqlClient
Imports System.Drawing

Public Class FrmCNAE
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        ' Limpa o RichTextBox de resultado
        RichTextBoxCNAEresultado.Clear()

        ' Divide os CNAEs por linha (cada parágrafo é uma linha)
        Dim cnaeList As String() = RichTextBoxCNAEBusca.Lines

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            For Each cnae As String In cnaeList
                ' Remove espaços extras
                cnae = cnae.Trim()

                ' Evita consultar CNAEs vazios
                If String.IsNullOrWhiteSpace(cnae) Then Continue For

                ' Consulta SQL para obter os dados do CNAE
                Dim query As String = "SELECT CNAE, Descricao, GrauDeRisco, Condicionante, GrauRiscoDesenq FROM CNAEprefMaringaPR WHERE CNAE = @CNAE"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CNAE", cnae)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Monta o texto formatado
                            Dim cnaeInfo As String = $"{reader("CNAE")} / Grau de Risco: {reader("GrauDeRisco")} / Descrição: {reader("Descricao")} / Observação: {reader("Condicionante")} {reader("GrauRiscoDesenq")}"

                            ' Adiciona o parágrafo ao RichTextBox de resultado
                            Dim startIndex As Integer = RichTextBoxCNAEresultado.TextLength
                            RichTextBoxCNAEresultado.AppendText(cnaeInfo & vbCrLf)
                            RichTextBoxCNAEresultado.SelectionStart = startIndex
                            RichTextBoxCNAEresultado.SelectionLength = cnaeInfo.Length

                            ' Aplica a formatação específica ao texto
                            ApplyFormattingToText(startIndex, reader("CNAE").ToString(), Nothing, Color.Black, FontStyle.Bold Or FontStyle.Underline)
                            ApplyFormattingToText(startIndex, "Grau de Risco: ", reader("GrauDeRisco").ToString(), Color.Red, FontStyle.Bold)
                            ApplyFormattingToText(startIndex, "Descrição: ", Nothing, Color.Black, FontStyle.Bold)
                            ApplyFormattingToText(startIndex, "Observação: ", Nothing, Color.Black, FontStyle.Bold)
                            ApplyFormattingToText(startIndex, "/", Nothing, Color.Black, FontStyle.Bold)
                        Else
                            ' Se não encontrar o CNAE, informa ao usuário
                            RichTextBoxCNAEresultado.AppendText($"CNAE {cnae} não encontrado no banco de dados." & vbCrLf)
                        End If
                    End Using
                End Using
            Next
        End Using
    End Sub

    Private Sub ApplyFormattingToText(startIndex As Integer, textToFind As String, appendText As String, color As Color, fontStyle As FontStyle)
        ' Método para encontrar e formatar texto específico dentro do RichTextBox
        Dim fullText As String = RichTextBoxCNAEresultado.Text.Substring(startIndex)
        Dim index As Integer = fullText.IndexOf(textToFind)
        While index >= 0
            Dim globalIndex As Integer = startIndex + index
            RichTextBoxCNAEresultado.Select(globalIndex, textToFind.Length)
            RichTextBoxCNAEresultado.SelectionColor = color
            RichTextBoxCNAEresultado.SelectionFont = New Font(RichTextBoxCNAEresultado.Font, fontStyle)

            If appendText IsNot Nothing Then
                ' Seleciona o valor que vem após o texto
                RichTextBoxCNAEresultado.Select(globalIndex + textToFind.Length, appendText.Length)
                RichTextBoxCNAEresultado.SelectionColor = color
                RichTextBoxCNAEresultado.SelectionFont = New Font(RichTextBoxCNAEresultado.Font, fontStyle)
            End If

            ' Procura a próxima ocorrência
            index = fullText.IndexOf(textToFind, index + textToFind.Length)
        End While

        ' Deselect all to avoid issues
        RichTextBoxCNAEresultado.DeselectAll()
    End Sub

    Private Sub FrmCNAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' Inicializa o RichTextBox de busca
        RichTextBoxCNAEBusca.Clear()

        ' Verifica se FrmLegalizacao está aberto
        Dim frmLegalizacao As FrmLegalizacao = TryCast(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao)
        If frmLegalizacao IsNot Nothing Then
            ' Captura os CNAEs do FrmLegalizacao
            Dim cnaePrincipal As String = frmLegalizacao.CNAEPrincipalTextBox.Text.Trim()
            Dim cnaeSecundario As String = frmLegalizacao.CNAESecundarioRichTextBox.Text.Trim()

            ' Adiciona cada CNAE em uma nova linha no RichTextBox
            If Not String.IsNullOrWhiteSpace(cnaePrincipal) Then
                RichTextBoxCNAEBusca.AppendText(cnaePrincipal & vbCrLf)
            End If
            If Not String.IsNullOrWhiteSpace(cnaeSecundario) Then
                RichTextBoxCNAEBusca.AppendText(cnaeSecundario & vbCrLf)
            End If
        End If

        ' Verifica se FrmAlvara está aberto
        Dim frmAlvara As FrmAlvara = TryCast(Application.OpenForms("FrmAlvara"), FrmAlvara)
        If frmAlvara IsNot Nothing Then
            ' Captura os CNAEs do FrmAlvara
            Dim cnaeAlvara As String = frmAlvara.CNAERichTextBox.Text.Trim()

            ' Adiciona cada CNAE em uma nova linha no RichTextBox
            If Not String.IsNullOrWhiteSpace(cnaeAlvara) Then
                RichTextBoxCNAEBusca.AppendText(cnaeAlvara & vbCrLf)
            End If
        End If

        ' Se nenhum dos formulários estiver aberto, o RichTextBoxCNAEBusca permanecerá vazio
        ' O usuário pode digitar manualmente ou o formulário pode ser usado para outra funcionalidade
    End Sub


    Private Sub FrmCNAE_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla ESC foi pressionada
        If e.KeyCode = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnTodosCNAE_Click(sender As Object, e As EventArgs) Handles BtnTodosCNAE.Click
        FrmBuscaCNAE.Show()
    End Sub
End Class
