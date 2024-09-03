Public Class FrmMultaBombeiro
    Private Sub FrmMultaBombeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurando o RichTextBox para ser somente leitura
        RichTextBox1.ReadOnly = True

        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, 14) ' Aumenta a fonte para 14 pontos


        ' Definindo o texto principal
        RichTextBox1.Text = "Fica NOTIFICADO das infrações administrativas incididas, podendo, em até 20 dias úteis (a partir da data de recebimento da Notificação de Autuação), optar por uma das seguintes ações:" & vbCrLf & vbCrLf

        ' Adicionando o texto dos itens numerados
        RichTextBox1.AppendText("1) Efetuar o pagamento do valor da multa imposta. Sanar as infrações no prazo máximo de 20 (vinte) dias úteis da notificação e declarar o saneamento via sítio eletrônico do Corpo de Bombeiros;" & vbCrLf & vbCrLf)
        RichTextBox1.AppendText("2) Efetuar o pagamento do valor da multa imposta. Manifestar-se pelo interesse de sanar as infrações desta notificação mediante Termo de Compromisso de Ajustamento de Conduta (TCAC);" & vbCrLf & vbCrLf)
        RichTextBox1.AppendText("3) Apresentar recurso contra a aplicação da multa e/ou medida acautelatória, recorrendo dos itens que constam na Notificação;")

        ' Aplicando formatação ao texto
        ' Negrito e cor para a palavra "NOTIFICADO"
        RichTextBox1.Select(5, 10) ' Seleciona "NOTIFICADO"
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.Blue

        ' Negrito e cor para "infrações administrativas"
        RichTextBox1.Select(15, 31) ' Seleciona "infrações administrativas incididas"
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.Red

        ' Cor para "20 dias úteis"
        RichTextBox1.Select(66, 20) ' Seleciona "20 dias úteis"
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionColor = Color.Green

        ' Aplicando formatação aos itens numerados
        ' Negrito para "1)"
        RichTextBox1.Select(RichTextBox1.GetFirstCharIndexFromLine(3), 2) ' Linha onde o "1)" começa
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        ' Negrito para "2)"
        RichTextBox1.Select(RichTextBox1.GetFirstCharIndexFromLine(8), 2) ' Linha onde o "2)" começa
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        ' Negrito para "3)"
        RichTextBox1.Select(RichTextBox1.GetFirstCharIndexFromLine(11), 2) ' Linha onde o "3)" começa
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        ' Remover a seleção para evitar que o texto fique selecionado
        RichTextBox1.Select(0, 0)

    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        ' Verificar se o FrmAlvara está aberto
        Dim frmAlvaraAberto As FrmAlvara = Nothing
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmAlvara Then
                frmAlvaraAberto = CType(frm, FrmAlvara)
                Exit For
            End If
        Next

        ' Se FrmAlvara não estiver aberto, exibir uma mensagem
        If frmAlvaraAberto Is Nothing Then
            MessageBox.Show("O formulário FrmAlvara está fechado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Verificar se BoxMultaDataFinal está vazio
        If String.IsNullOrWhiteSpace(BoxMultaDataFinal.Text) Then
            ' Se BoxMultaDataFinal estiver vazio, verificar se BoxDataMulta tem uma data válida
            Dim dataInicial As DateTime
            If DateTime.TryParseExact(BoxDataMulta.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataInicial) Then
                ' Adicionar 20 dias úteis à data inicial
                Dim dataFinalCalculada As DateTime = AdicionarDiasUteis(dataInicial, 20)

                ' Definir o valor de BoxMultaDataFinal com a nova data
                BoxMultaDataFinal.Text = dataFinalCalculada.ToString("dd/MM/yyyy")
                MessageBox.Show($"Data final calculada com sucesso: {BoxMultaDataFinal.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Se BoxDataMulta também estiver vazio ou inválido, exibir uma mensagem de erro
                MessageBox.Show("Data inicial inválida ou não informada. Por favor, insira uma data válida no campo 'Data da Multa'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Verificar se a data em BoxMultaDataFinal é válida
        Dim dataFinal As DateTime
        If DateTime.TryParseExact(BoxMultaDataFinal.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataFinal) Then
            ' Se a data for válida, transferir para o campo BombeiroDataMultaMaskedTextBox no FrmAlvara
            frmAlvaraAberto.BombeiroDataMultaMaskedTextBox.Text = dataFinal.ToString("dd/MM/yyyy")
            MessageBox.Show("Data transferida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmAlvara.BombeiroMulta()
            Me.Close()
        Else
            ' Se a data não for válida, exibir uma mensagem
            MessageBox.Show("Data inválida. Por favor, Calcular a o PRAZO.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




    Private Function AdicionarDiasUteis(data As DateTime, diasUteis As Integer) As DateTime
        Dim diasAdicionados As Integer = 0
        Dim dataAtual As DateTime = data

        While diasAdicionados < diasUteis
            dataAtual = dataAtual.AddDays(1)

            ' Verifica se o dia da semana não é sábado (6) ou domingo (0)
            If dataAtual.DayOfWeek <> DayOfWeek.Saturday AndAlso dataAtual.DayOfWeek <> DayOfWeek.Sunday Then
                diasAdicionados += 1
            End If
        End While

        Return dataAtual
    End Function

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        ' Verificar se a data em BoxDataMulta é válida
        Dim dataInicial As DateTime
        If DateTime.TryParseExact(BoxDataMulta.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataInicial) Then
            ' Adicionar 20 dias úteis à data inicial
            Dim dataFinal As DateTime = AdicionarDiasUteis(dataInicial, 20)

            ' Definir o valor de BoxMultaDataFinal com a nova data
            BoxMultaDataFinal.Text = dataFinal.ToString("dd/MM/yyyy")
            MessageBox.Show("Data final calculada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Se a data não for válida, exibir uma mensagem
            MessageBox.Show("Data inválida. Por favor, insira uma data válida no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class