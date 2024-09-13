Public Class FrmRichTextCompleto

    ' Variável para armazenar a referência ao RichTextBox de origem
    Public RichTextBoxOrigem As RichTextBox

    Private Sub FrmRichTextCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche o ToolStripComboBoxFontes com as fontes instaladas no sistema
        For Each fonte As FontFamily In FontFamily.Families
            ToolStripComboBoxFontes.Items.Add(fonte.Name)
        Next

        ' Definir fonte padrão como "Microsoft Sans Serif"
        ToolStripComboBoxFontes.SelectedItem = "Microsoft Sans Serif"

        ' Definir tamanho padrão como 12
        ToolStripComboBoxTamanho.Items.AddRange(New String() {"8", "10", "12", "14", "16", "18", "20", "24", "28", "36", "48", "72"})
        ToolStripComboBoxTamanho.SelectedItem = "12" ' Valor padrão

        ' Definir a fonte e o tamanho padrão no RichTextBox
        RichTextBoxCompleto.Font = New Font("Microsoft Sans Serif", 12)

        ' Armazena o texto original quando o formulário é carregado (se necessário)
        RichTextBoxOrigem.Text = RichTextBoxCompleto.Text
    End Sub

    Private Sub FrmRichTextCompleto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Verifica se o texto foi alterado
        If RichTextBoxCompleto.Text <> RichTextBoxOrigem.Text Then
            ' Pergunta ao usuário se deseja salvar as alterações
            Dim result As DialogResult = MessageBox.Show("O texto foi alterado. Deseja salvar as alterações?", "Salvar Alterações", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Se o usuário optar por salvar, chama o método de salvar
                SalvarAlteracoes()
            ElseIf result = DialogResult.No Then
                ' Se o usuário optar por não salvar, permite o fechamento sem salvar
                e.Cancel = False
            ElseIf result = DialogResult.Cancel Then
                ' Se o usuário cancelar, interrompe o fechamento do formulário
                e.Cancel = True
            End If
        End If
    End Sub

    ' Método para salvar as alterações (pode ser customizado conforme necessário)
    Private Sub SalvarAlteracoes()
        ' Verifica se a referência do RichTextBoxOrigem foi definida
        If RichTextBoxOrigem IsNot Nothing Then
            ' Atualiza o RichTextBox de origem com o texto do RichTextBoxCompleto
            RichTextBoxOrigem.Text = RichTextBoxCompleto.Text

            ' Fecha o formulário após salvar
            MessageBox.Show("As alterações foram salvas.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nenhuma origem de texto foi definida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Close()
    End Sub

    '////////////////////// CODIGOS
    ' Captura o evento KeyDown do formulário
    Private Sub FrmRichTextCompleto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla ESC foi pressionada
        If e.KeyCode = Keys.Escape Then
            Me.Close() ' Fecha o formulário
        End If
    End Sub

    ' Botão para salvar as alterações no RichTextBox
    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        ' Verifica se a referência do RichTextBoxOrigem foi definida
        If RichTextBoxOrigem IsNot Nothing Then
            ' Atualiza o RichTextBox de origem com o texto do RichTextBoxCompleto
            RichTextBoxOrigem.Text = RichTextBoxCompleto.Text

            ' Fecha o formulário após salvar
            Me.Close()
        Else
            MessageBox.Show("Nenhuma origem de texto foi definida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        ' Pergunta ao usuário se ele realmente deseja limpar o conteúdo
        Dim resultado As DialogResult = MessageBox.Show("Deseja limpar todo o texto?",
                                                        "Confirmar Limpeza",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        ' Se o usuário clicar em 'Sim', o conteúdo será limpo
        If resultado = DialogResult.Yes Then
            RichTextBoxCompleto.Clear()
            MessageBox.Show("Campo limpo. Agora você pode adicionar um novo texto.",
                            "Novo Texto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        Try
            ' Configura o conteúdo que será impresso
            PrintDocument1.DocumentName = "Impressão de Texto Completo"

            ' Associar o evento PrintPage ao método PrintDocument1_PrintPage
            AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage

            ' Mostra a caixa de diálogo de visualização de impressão
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Erro ao tentar imprimir: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Definir a fonte e o layout do texto para impressão
        Dim fonteImpressao As New Font("Arial", 12, FontStyle.Regular)
        Dim textoParaImpressao As String = RichTextBoxCompleto.Text
        Dim margemEsquerda As Single = e.MarginBounds.Left
        Dim margemSuperior As Single = e.MarginBounds.Top

        ' Desenha o texto na página a ser impressa
        e.Graphics.DrawString(textoParaImpressao, fonteImpressao, Brushes.Black, margemEsquerda, margemSuperior)

        ' Indica que não há mais páginas a serem impressas
        e.HasMorePages = False
    End Sub

    ' Recortar texto selecionado
    Private Sub RecortarToolStripButton_Click(sender As Object, e As EventArgs) Handles RecortarToolStripButton.Click
        If RichTextBoxCompleto.SelectedText <> "" Then
            RichTextBoxCompleto.Cut() ' Recorta o texto selecionado
        Else
            MessageBox.Show("Nenhum texto selecionado para recortar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Copiar texto selecionado
    Private Sub CopiarToolStripButton_Click(sender As Object, e As EventArgs) Handles CopiarToolStripButton.Click
        If RichTextBoxCompleto.SelectedText <> "" Then
            RichTextBoxCompleto.Copy() ' Copia o texto selecionado
        Else
            MessageBox.Show("Nenhum texto selecionado para copiar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Colar texto da área de transferência
    Private Sub ColarToolStripButton_Click(sender As Object, e As EventArgs) Handles ColarToolStripButton.Click
        If Clipboard.ContainsText() Then
            RichTextBoxCompleto.Paste() ' Cola o texto da área de transferência
        Else
            MessageBox.Show("Não há texto disponível na área de transferência para colar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AjudaToolStripButton_Click(sender As Object, e As EventArgs) Handles AjudaToolStripButton.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    ' ///////////////// EDITOR DE FONTES
    ' Evento para mudar a fonte
    Private Sub ToolStripComboBoxFontes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxFontes.SelectedIndexChanged
        MudarFonteOuTamanho()
    End Sub

    ' Evento para mudar o tamanho da fonte
    Private Sub ToolStripComboBoxTamanho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxTamanho.SelectedIndexChanged
        MudarFonteOuTamanho()
    End Sub

    ' Método para alterar a fonte e o tamanho
    Private Sub MudarFonteOuTamanho()
        If RichTextBoxCompleto.SelectionLength > 0 Then
            ' Pega a fonte e o tamanho selecionados
            Dim fonteSelecionada As String = If(ToolStripComboBoxFontes.SelectedItem IsNot Nothing, ToolStripComboBoxFontes.SelectedItem.ToString(), "Microsoft Sans Serif")
            Dim tamanhoSelecionado As Single = If(ToolStripComboBoxTamanho.SelectedItem IsNot Nothing, Single.Parse(ToolStripComboBoxTamanho.SelectedItem.ToString()), 12)
            RichTextBoxCompleto.SelectionFont = New Font(fonteSelecionada, tamanhoSelecionado)
        End If
    End Sub

End Class
