
Public Class RelEmpresasDatas

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub RelEmpresasDatas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'onde mostrar os dados em: EmpresasDataGridView
        'Banco de dados onde tem as datas SQL formato DATE chamado de NireData


        Try

            'EmpresasBindingSource.Filter = "DataNire > #" & DateTimePicker1.Value & "# and DataNire < #" & DateTimePicker2.Value & "#"

            Me.EmpresasBindingSource.Filter = "NireData >= " + "'" + Convert.ToDateTime(DateTimePicker1.Value) + "'" + " AND NireData <=" + "'" + Convert.ToDateTime(DateTimePicker2.Value) + "'"


        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message, "Consultar Registros")
        Finally

        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        Me.Refresh()
    End Sub


    'Comando de Impressão


    Dim mRow As Integer = 0
    Dim newpage As Boolean = True


    Private Sub PrintDocument1_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        mRow = 0
        newpage = True
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With EmpresasDataGridView
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
                        e.Graphics.DrawString(EmpresasDataGridView.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(EmpresasDataGridView.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
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

End Class