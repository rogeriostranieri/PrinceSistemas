Public Class RelatorioLaudos


    Private Sub RelatorioLaudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.CADSituacaoAlvara'. Você pode movê-la ou removê-la conforme necessário.
        Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        '   ModCombobox.ComboboxRelatorioAlvara()
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' PESQUISA COM FILTRO POR DATA AVISO
        'FILTRO LAUDO
        If SituacaoComboBox.Text <> "TODAS" Then
            Dim FilterA As String
            FilterA = SituacaoComboBox.Text
            LaudosBindingSource.Filter = "Situacao = '" & FilterA & " ' "
        Else
            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
            Me.LaudosBindingSource.RemoveFilter()
            ' Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
            ' Me.Refresh()



        End If

    End Sub

    'Comando de Impressão


    Dim mRow As Integer = 0
    Dim newpage As Boolean = True


    Private Sub PrintDocument1_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        mRow = 0
        newpage = True
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With LaudosDataGridView
            Dim fmt As New StringFormat(StringFormatFlags.LineLimit) With {
                .LineAlignment = StringAlignment.Center,
                .Trimming = StringTrimming.EllipsisCharacter
            }
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(LaudosDataGridView.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(LaudosDataGridView.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                If newpage Then
                    newpage = False
                Else
                    mRow += 1
                End If
                y += h
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    'mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub


    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BbtnPrint.Click

        PrintPreviewDialog1.Document = PrintDocument1
        ' PrintDocument1.Print()
        ' PrintPreviewDialog1.Show()
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        Me.Refresh()

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            FrmAlvara.Focus()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        End If
    End Sub
End Class