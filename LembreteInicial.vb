Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class LembreteInicial
    Private Sub EmpresasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
    End Sub

    Private Sub LembreteInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

        ' Dim FilterA As String
        ' FilterA = "Checked"
        EmpresasBindingSource.Filter = "Lembrete = 'Checked' "

        LaudosBindingSource.Filter = "Lembrete = 'Checked' "
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Application.OpenForms.OfType(Of VbAvisoPrincipal)().Count() > 0 Then
            VbAvisoPrincipal.Focus()
            VbAvisoPrincipal.MdiParent = MDIPrincipal
        Else
            VbAvisoPrincipal.MdiParent = MDIPrincipal
            VbAvisoPrincipal.Show()
        End If
    End Sub

    Private Sub EmpresasDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmLegalizacao.Focus()
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
        Else
            FrmLegalizacao.Show()
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
        End If
    End Sub

    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmAlvara.Focus()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        Else
            FrmAlvara.Show()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        End If
    End Sub

    ' //////////////////////// botao imprimir
    Private Sub ButtonImprimir_Click(sender As Object, e As EventArgs) Handles ButtonImprimir.Click
        ' Configura a pré-visualização da impressão
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fonte As New System.Drawing.Font("Arial", 10)
        Dim pincel As New System.Drawing.SolidBrush(System.Drawing.Color.Black)
        Dim alturaLinha As Integer = 20
        Dim larguraColuna0 As Integer = 400 ' Ajuste a largura da coluna 0 aqui
        Dim larguraColuna3 As Integer = 300 ' Ajuste a largura da coluna 3 aqui
        Dim xInicial As Integer = 50
        Dim y As Integer = 50
        Dim x As Integer = xInicial

        ' Cabeçalhos
        e.Graphics.DrawString(EmpresasDataGridView.Columns(0).HeaderText, fonte, pincel, x, y)
        x += larguraColuna0
        e.Graphics.DrawString(EmpresasDataGridView.Columns(3).HeaderText, fonte, pincel, x, y)

        y += alturaLinha
        x = xInicial

        ' Dados
        For Each linha As DataGridViewRow In EmpresasDataGridView.Rows
            If Not linha.IsNewRow Then
                Dim coluna0 As String = If(linha.Cells(0).Value IsNot Nothing, linha.Cells(0).Value.ToString(), "")
                Dim coluna3 As String = If(linha.Cells(3).Value IsNot Nothing, linha.Cells(3).Value.ToString(), "")

                ' Limita a largura do texto na coluna 0
                Dim tamanhoTexto0 As SizeF = e.Graphics.MeasureString(coluna0, fonte)
                If tamanhoTexto0.Width > larguraColuna0 Then
                    coluna0 = TruncarTexto(coluna0, fonte, larguraColuna0, e.Graphics)
                End If

                ' Limita a largura do texto na coluna 3
                Dim tamanhoTexto3 As SizeF = e.Graphics.MeasureString(coluna3, fonte)
                If tamanhoTexto3.Width > larguraColuna3 Then
                    coluna3 = TruncarTexto(coluna3, fonte, larguraColuna3, e.Graphics)
                End If

                ' Desenha os textos dentro das colunas limitadas
                e.Graphics.DrawString(coluna0, fonte, pincel, x, y)
                x += larguraColuna0
                e.Graphics.DrawString(coluna3, fonte, pincel, x, y)

                y += alturaLinha
                x = xInicial
            End If
        Next
    End Sub

    ' Função para truncar o texto caso ultrapasse o limite da coluna
    Private Function TruncarTexto(texto As String, fonte As System.Drawing.Font, larguraMaxima As Integer, g As Graphics) As String
        Dim textoFinal As String = texto
        Dim tamanhoTexto As SizeF = g.MeasureString(textoFinal, fonte)

        While tamanhoTexto.Width > larguraMaxima AndAlso textoFinal.Length > 0
            textoFinal = textoFinal.Substring(0, textoFinal.Length - 1) ' Remove um caractere
            tamanhoTexto = g.MeasureString(textoFinal & "...", fonte) ' Recalcula o tamanho com "..."
        End While

        Return If(textoFinal.Length < texto.Length, textoFinal & "...", textoFinal)
    End Function

    Private Sub ButtonImprimirLaudo_Click(sender As Object, e As EventArgs) Handles ButtonImprimirLaudo.Click
        ' Configura o PrintDocument para o laudo
        PrintPreviewDialogLaudo.Document = PrintDocumentLaudo
        PrintPreviewDialogLaudo.ShowDialog()
    End Sub

    Private Sub PrintDocumentLaudo_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocumentLaudo.PrintPage
        Dim fonte As New System.Drawing.Font("Arial", 10)
        Dim pincel As New System.Drawing.SolidBrush(System.Drawing.Color.Black)
        Dim alturaLinha As Integer = 20
        Dim larguraColuna0 As Integer = 400 ' Ajuste a largura da coluna 0 aqui
        Dim larguraColuna2 As Integer = 300 ' Ajuste a largura da coluna 2 aqui
        Dim xInicial As Integer = 50
        Dim y As Integer = 50
        Dim x As Integer = xInicial

        ' Cabeçalhos
        e.Graphics.DrawString("Razão Social", fonte, pincel, x, y)
        x += larguraColuna0
        e.Graphics.DrawString("Situação", fonte, pincel, x, y)

        y += alturaLinha
        x = xInicial

        ' Dados
        Dim linhaNumero As Integer = 1
        For Each linha As DataGridViewRow In LaudosDataGridView.Rows
            If Not linha.IsNewRow Then
                Dim razaoSocial As String = If(linha.Cells(0).Value IsNot Nothing, linha.Cells(0).Value.ToString(), "")
                Dim situacao As String = If(linha.Cells(2).Value IsNot Nothing, linha.Cells(2).Value.ToString(), "")

                ' Limita a largura do texto na coluna 0
                Dim tamanhoTexto0 As SizeF = e.Graphics.MeasureString(razaoSocial, fonte)
                If tamanhoTexto0.Width > larguraColuna0 Then
                    razaoSocial = TruncarTexto(razaoSocial, fonte, larguraColuna0, e.Graphics)
                End If

                ' Limita a largura do texto na coluna 2
                Dim tamanhoTexto2 As SizeF = e.Graphics.MeasureString(situacao, fonte)
                If tamanhoTexto2.Width > larguraColuna2 Then
                    situacao = TruncarTexto(situacao, fonte, larguraColuna2, e.Graphics)
                End If

                ' Desenha os textos dentro das colunas limitadas
                e.Graphics.DrawString(razaoSocial, fonte, pincel, x, y)
                x += larguraColuna0
                e.Graphics.DrawString(situacao, fonte, pincel, x, y)

                y += alturaLinha
                x = xInicial
            End If
        Next
    End Sub


    '///////// Salvar Arquivo TXT
    Private Sub ButtonSalvarEmpresa_Click(sender As Object, e As EventArgs) Handles ButtonSalvarEmpresa.Click
        ' Cria o objeto SaveFileDialog
        ' Define o filtro para o tipo de arquivo
        Dim dialog As New SaveFileDialog With {
            .Filter = "Arquivo de Texto (*.txt)|*.txt"
        }

        ' Exibe a caixa de diálogo para o usuário escolher onde salvar
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()

            ' Adiciona os cabeçalhos
            sb.AppendLine(EmpresasDataGridView.Columns(0).HeaderText & " = " & EmpresasDataGridView.Columns(3).HeaderText)

            ' Adiciona as linhas com números sequenciais
            Dim linhaNumero As Integer = 1
            For Each linha As DataGridViewRow In EmpresasDataGridView.Rows
                If Not linha.IsNewRow Then
                    Dim coluna0 As String = If(linha.Cells(0).Value IsNot Nothing, linha.Cells(0).Value.ToString(), "")
                    Dim coluna3 As String = If(linha.Cells(3).Value IsNot Nothing, linha.Cells(3).Value.ToString(), "")

                    ' Adiciona o número da linha e o separador "="
                    sb.AppendLine(linhaNumero.ToString() & " = " & coluna0 & " = " & coluna3)

                    ' Incrementa o número da linha
                    linhaNumero += 1
                End If
            Next

            ' Salva o arquivo no formato selecionado
            If dialog.FileName.EndsWith(".txt") Then
                System.IO.File.WriteAllText(dialog.FileName, sb.ToString())
            End If

            ' Exibe uma mensagem de confirmação
            MessageBox.Show("Arquivo salvo com sucesso em: " & dialog.FileName, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Abre o arquivo salvo
            Process.Start(dialog.FileName)
        End If
    End Sub


    Private Sub ButtonSalvarLaudo_Click(sender As Object, e As EventArgs) Handles ButtonSalvarlaudo.Click
        ' Cria o objeto SaveFileDialog
        ' Define o filtro para o tipo de arquivo
        Dim dialog As New SaveFileDialog With {
            .Filter = "Arquivo de Texto (*.txt)|*.txt"
        }

        ' Exibe a caixa de diálogo para o usuário escolher onde salvar
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()

            ' Adiciona os cabeçalhos
            sb.AppendLine("Razão Social = Situação")

            ' Adiciona as linhas com os dados da razão social e situação
            Dim linhaNumero As Integer = 1
            For Each linha As DataGridViewRow In LaudosDataGridView.Rows
                If Not linha.IsNewRow Then
                    ' Acessando as colunas por índice
                    Dim razaoSocial As String = If(linha.Cells(0).Value IsNot Nothing, linha.Cells(0).Value.ToString(), "") ' Coluna 0
                    Dim situacao As String = If(linha.Cells(2).Value IsNot Nothing, linha.Cells(2).Value.ToString(), "") ' Coluna 2

                    ' Adiciona o número da linha e o separador "="
                    sb.AppendLine(linhaNumero.ToString() & " = " & razaoSocial & " = " & situacao)

                    ' Incrementa o número da linha
                    linhaNumero += 1
                End If
            Next

            ' Salva o arquivo no formato selecionado
            If dialog.FileName.EndsWith(".txt") Then
                System.IO.File.WriteAllText(dialog.FileName, sb.ToString())
            End If

            ' Exibe uma mensagem de confirmação
            MessageBox.Show("Arquivo salvo com sucesso em: " & dialog.FileName, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Abre o arquivo salvo
            Process.Start(dialog.FileName)
        End If
    End Sub



End Class
