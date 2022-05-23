Public Class FrmCalculadoraCapital

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPorcentagem.Click
        Try
            ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
            If TextBoxCapitalSocial.Text = "" Then
                MsgBox("Digite o valor do capital social")
                TextBoxCapitalSocial.Focus()
                Exit Sub
            End If

            'cada linha tem seu calculo de porcentagem cell 1,sob o valor da TextBoxCapitalSocial 
            'conveter Double
            Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)


            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(1).Value = "" Then
                    row.Cells(1).Value = 0
                End If
                'calculo da porcentagem
                'Cells(3) porcentagem
                row.Cells(3).Value = (row.Cells(1).Value * valor) / 100
                'coluna 3 converte em Double
                row.Cells(3).Value = CDbl(row.Cells(3).Value)
                'coluna 3 converte em String
                row.Cells(3).Value = FormatCurrency(row.Cells(3).Value)

            Next





            'depois totalizar o valores das em uma nova linha, e nao repetir o calculo
            'se tiver TOTAL limpas e fazer calculo novamente
            If DataGridView1.Rows.Count > 0 Then
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells(0).Value = "TOTAL" Then
                        DataGridView1.Rows.Remove(row)
                    End If
                Next
            End If


            'double
            Dim total As Double = 0
            For i = 0 To DataGridView1.Rows.Count - 2

                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
                'em negrito
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""




                total = total + DataGridView1.Rows(i).Cells(3).Value

                'Valor da porcentagem ultrapassou o valor do capital social
                If total > valor Then
                    MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                    Exit Sub
                End If

                'DataGridView1 Cells(1), nao passar de 100, conveter em doble
                If DataGridView1.Rows(i).Cells(1).Value > 100 Then
                    MsgBox("Valor da porcentagem ultrapassou o valor do capital social")
                    Exit Sub
                End If
            Next






            'no final converte Double em reais a cell 3
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total)

            For i = 0 To DataGridView1.Rows.Count - 1
                'DataGridView1.Rows(i).Cells(3).Value = FormatCurrency(DataGridView1.Rows(i).Cells(3).Value)
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total)

            Next


            'verificar se tem valor preenchido na cell2
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(2).Value <> "" Then
                    PercaGanho()
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PercaGanho()
        Try


            'coluna 2 e 3 nao podem ser vazio
            If DataGridView1.Rows(0).Cells(2).Value = "" Then
                MsgBox("Coluna 2 não pode ser vazia")
                Exit Sub
            End If



            If DataGridView1.Rows(0).Cells(3).Value = "" Then
                MsgBox("Coluna 3 não pode ser vazia")
                Exit Sub
            End If


            For Each row As DataGridViewRow In DataGridView1.Rows
                'Coluna2 converter string e Double
                Dim coluna2 As Double = CDbl(DataGridView1.Rows(0).Cells(2).Value)
                Dim coluna3 As Double = CDbl(DataGridView1.Rows(0).Cells(3).Value)


                'coluna 4 = coluna 3 - coluna 2 de
                'todas as Rows



                row.Cells(4).Value = coluna3 - coluna2
                '  DataGridView1.Rows(0).Cells(4).Value = coluna3 - coluna2





                'coluna4 converte em Double
                DataGridView1.Rows(0).Cells(4).Value = CDbl(DataGridView1.Rows(0).Cells(4).Value)
                'coluna4 converte em String
                DataGridView1.Rows(0).Cells(4).Value = FormatCurrency(DataGridView1.Rows(0).Cells(4).Value)
                'letra negrito
                DataGridView1.Rows(0).Cells(4).Style.Font = New Font("Arial", 10, FontStyle.Bold)
                'coluna2 converte em Double
                DataGridView1.Rows(0).Cells(2).Value = CDbl(DataGridView1.Rows(0).Cells(2).Value)
                'coluna2 converte em String
                DataGridView1.Rows(0).Cells(2).Value = FormatCurrency(DataGridView1.Rows(0).Cells(2).Value)





                'pintar em vermelho o valor negativo
                If row.Cells(4).Value < 0 Then
                        row.Cells(4).Style.BackColor = Color.Red
                        'letra branca
                        row.Cells(4).Style.ForeColor = Color.White
                        'negrito
                        row.Cells(4).Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    End If
                    'pintar em verde valor positivo
                    If row.Cells(4).Value > 0 Then
                        row.Cells(4).Style.BackColor = Color.Green
                        'letra branca
                        row.Cells(4).Style.ForeColor = Color.White
                        'negrito
                        row.Cells(4).Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    End If
                Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ButtonDistribuir_Click(sender As Object, e As EventArgs) Handles ButtonDistribuir.Click

        PercaGanho()

    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        'limpaar
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
    End Sub
End Class