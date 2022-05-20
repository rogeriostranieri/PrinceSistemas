Public Class FrmCalculadoraCapital
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'pegal total capital social e calcula porcentagem do  DataGridView1 na coluna "Porcentagem"
        'verificar se o valor do capital social é maior que zero
        'verificar linha preenchida no campo porceentagem

        Dim valor As Double
        Dim porcentagem As Double
        Dim total As Double
        total = CDbl(TextBox1.Text)

        If DataGridView1.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value <> "" Then
                    valor = total
                    porcentagem = row.Cells(1).Value
                    row.Cells(2).Value = valor * (porcentagem / 100)
                End If
            Next
        End If

    End Sub
End Class