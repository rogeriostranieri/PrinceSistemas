Public Class FrmCalculadoraCapital

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPorcentagem.Click

        'Porcentagem
        'PercaGanho
        'Todos
        Try
            'verifica se tem apenas valor na coluna 1 e as outras colunas vazias , e chama Porcentagem
            If DataGridView1.Rows.Count > 0 Then
                If DataGridView1.Rows(0).Cells(1).Value <> "" And DataGridView1.Rows(0).Cells(2).Value = "" And DataGridView1.Rows(0).Cells(3).Value = "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    Porcentagem()
                    'verifica se tem apenas valor na coluna 2  e 3 e as outras colunas vazias, e chama PercaGanho
                ElseIf DataGridView1.Rows(0).Cells(1).Value = "" And DataGridView1.Rows(0).Cells(2).Value <> "" And DataGridView1.Rows(0).Cells(3).Value <> "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    PercaGanho()
                ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" And DataGridView1.Rows(0).Cells(2).Value <> "" And DataGridView1.Rows(0).Cells(3).Value = "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                    Todos()
                ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" And DataGridView1.Rows(0).Cells(2).Value <> "" And DataGridView1.Rows(0).Cells(3).Value <> "" And DataGridView1.Rows(0).Cells(4).Value = "" Then
                       DataGridView1.Refresh()
                    'Todos()
                    'mgs ação nao permitida após calculo feito
                    MsgBox("Não é possivel realizar mais de um calculo, após o calculo ser realizado, não é possivel realizar outro calculo", MsgBoxStyle.Information, "Aviso")

                End If

            End If

        Catch ex As Exception
            MsgBox("Um calculo não foi realizado, verifique se todos os campos estão preenchidos corretamente", MsgBoxStyle.Information, "Aviso")
            'limpar todas colunas e linhas, menos a primeira coluna 
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For j As Integer = 1 To DataGridView1.Columns.Count - 1
                    DataGridView1.Rows(i).Cells(j).Value = ""
                Next
            Next
            DataGridView1.Refresh()
        End Try

    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        Limpar()
    End Sub


    'conveter TextBoxCapitalSocial em Moeda local ao digitar
    Private Sub TextBoxCapitalSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCapitalSocial.KeyPress
        If e.KeyChar = "," Then
            e.KeyChar = "."
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "." OrElse e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    'conveter TextBoxCapitalSocial em Moeda local ao digitar
    Private Sub TextBoxCapitalSocial_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCapitalSocial.TextChanged
        TextBoxCapitalSocial.Text = FormatCurrency(TextBoxCapitalSocial.Text, 2)
    End Sub




    Private Sub Porcentagem()
        Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)


        ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
        If TextBoxCapitalSocial.Text = "" Then
            MsgBox("Digite o valor do capital social")
            TextBoxCapitalSocial.Focus()
            Exit Sub
        End If

        'cada linha tem seu calculo de porcentagem cell 1,sob o valor da TextBoxCapitalSocial 
        'conveter Double


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

        '////////////////////////////    TOTAL   ////////////////////////
        'double
        Dim total As Double = 0
        Dim total1 As Double = 0

        For i = 0 To DataGridView1.Rows.Count - 2

            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
            'em negrito
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""



            'total da coluna 3 - NOVO CAPITAL SOCIAL
            total += DataGridView1.Rows(i).Cells(3).Value

            'total de coluna 1 - Porcentagem
            total1 += DataGridView1.Rows(i).Cells(1).Value
            'mudar para % porcentagem
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = total1
            'adiciona %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value & "%"


            


            '////////////////////////////    FIM TOTAL   ////////////////////////

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



        'CONVERTER EM REAIS E %
        For i = 0 To DataGridView1.Rows.Count - 1
            'DataGridView1.Rows(i).Cells(3).Value = FormatCurrency(DataGridView1.Rows(i).Cells(3).Value)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total)

        Next




    End Sub
    Private Sub PercaGanho()
        Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)

        ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
        If TextBoxCapitalSocial.Text = "" Then
            MsgBox("Digite o valor do capital social")
            TextBoxCapitalSocial.Focus()
            Exit Sub
        End If

        'coluna 2 e 3 nao podem ser vazio
        If DataGridView1.Rows(0).Cells(2).Value = "" Then
            MsgBox("Coluna 2 não pode ser vazia")
            Exit Sub
        End If



        If DataGridView1.Rows(0).Cells(3).Value = "" Then
            MsgBox("Coluna 3 não pode ser vazia")
            Exit Sub
        End If




        ' cada linha calcular a coluna3 - coluna2 individualmente e converter string para double
        For Each row As DataGridViewRow In DataGridView1.Rows
            'Converter em double em DIM 
            'A cadeia de caracteres 
            'e convertida para um valor double.

            Dim valor1 As Double = CDbl(row.Cells(2).Value)
            Dim valor2 As Double = CDbl(row.Cells(3).Value)



            'calculo da porcentagem
            row.Cells(4).Value = (valor2 - valor1)

            'coluna 3 converte em Double
            row.Cells(4).Value = CDbl(row.Cells(4).Value)
            'converter em reais
            row.Cells(4).Value = FormatCurrency(row.Cells(4).Value)
            'conveter coluna 2 em reais
            row.Cells(2).Value = FormatCurrency(row.Cells(2).Value)




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


        '// porcentagem //////////////

        For Each row As DataGridViewRow In DataGridView1.Rows
            'calculo da porcentagem na coluna 1
            row.Cells(1).Value = (row.Cells(3).Value / valor) * 100

        Next


        '////////////////////////////    TOTAL   ////////////////////////
        'double
        Dim total1 As Double = 0
        Dim total2 As Double = 0
        Dim total3 As Double = 0
        Dim total4 As Double = 0
        For i = 0 To DataGridView1.Rows.Count - 2

            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
            'em negrito
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""


            'total da coluna 1
            total1 += DataGridView1.Rows(i).Cells(1).Value
            'coloca no final total e colocar %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = total1
            'adiciona %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value & "%"


            'total da coluna 2 - Antigo CAPITAL SOCIAL
            total2 += DataGridView1.Rows(i).Cells(2).Value
            'coloca no final total
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = FormatCurrency(total2)

            'total da coluna 3 - NOVO CAPITAL SOCIAL
            total3 += DataGridView1.Rows(i).Cells(3).Value
            'coloca no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total3)


            'total de coluna 4 - Perda Ganho
            total4 += DataGridView1.Rows(i).Cells(4).Value
            'coloca no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value = FormatCurrency(total4)




            '////////////////////////////    FIM TOTAL   ////////////////////////

            'Valor da porcentagem ultrapassou o valor do capital social
            If total1 > valor Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")
                Exit Sub
            End If

            'DataGridView1 Cells(1), nao passar de 100, conveter em doble
            If DataGridView1.Rows(i).Cells(1).Value > 100 Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                Exit Sub
            End If
        Next




    End Sub

    Private Sub Todos()
        Dim valor As Double = CDbl(TextBoxCapitalSocial.Text)

        'Porcentagem/////////////////////////////////////////////////////////////////////////////////
        ' nao ultrapassar 100% da cell 1 do capital social do TextBoxCapitalSocial
        If TextBoxCapitalSocial.Text = "" Then
            MsgBox("Digite o valor do capital social")
            TextBoxCapitalSocial.Focus()
            Exit Sub
        End If

        'cada linha tem seu calculo de porcentagem cell 1,sob o valor da TextBoxCapitalSocial 
        'conveter Double




        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(1).Value = "" Then
                row.Cells(1).Value = 0
            End If


            'calculo da porcentagem
            'Cells(3) porcentagem
            row.Cells(3).Value = (row.Cells(1).Value * valor) / 100
            '///////////////////////////////////////

            'verifica se a coluna esta em reais e deixa apenas numeros
            If row.Cells(1).Value.ToString.Contains("R$") Then
                row.Cells(1).Value = row.Cells(1).Value.ToString.Replace("R$", "")
            End If
            'pega o valor da  coluna 3 - coluna 2 e coloca na coluna 4
            row.Cells(4).Value = row.Cells(3).Value - row.Cells(2).Value
            '///////////////////////////////////////
            'coluna 3 converte em Double
            row.Cells(3).Value = CDbl(row.Cells(3).Value)


            'pega o valor integer da coluna 3 e diminui da coluna 2 e coloca resultado na coluna 4
            ' usar tryparse

            ' 

            'coluna 4 converte em Double
            row.Cells(4).Value = CDbl(row.Cells(4).Value)
            'coluna 4 converte em String
            row.Cells(4).Value = FormatCurrency(row.Cells(4).Value)
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


        '////////////////////////////    TOTAL   ////////////////////////
        'double
        Dim total1 As Double = 0
        Dim total2 As Double = 0
        Dim total3 As Double = 0
        Dim total4 As Double = 0

        For i = 0 To DataGridView1.Rows.Count - 2

            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "Total"
            'em negrito
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = ""

            'total de coluna 1 - Porcentagem
            total1 += DataGridView1.Rows(i).Cells(1).Value
            'mudar para % porcentagem
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = total1
            'adiciona %
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value & "%"


            'total da coluna 2 - Antigo CAPITAL SOCIAL
            total2 += DataGridView1.Rows(i).Cells(2).Value
            'coloca no final total
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = FormatCurrency(total2)


            'total da coluna 3 - NOVO CAPITAL SOCIAL
            total3 += DataGridView1.Rows(i).Cells(3).Value
            'total3 no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = FormatCurrency(total3)


            'total de coluna 4 - Perda Ganho
            total4 += DataGridView1.Rows(i).Cells(4).Value
            'em reais o total no final
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value = FormatCurrency(total4)





            '////////////////////////////    FIM TOTAL   ////////////////////////

            'Valor da porcentagem ultrapassou o valor do capital social
            If total1 > valor Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")
                Exit Sub
            End If

            'DataGridView1 Cells(1), nao passar de 100, conveter em doble
            If DataGridView1.Rows(i).Cells(1).Value > 100 Then
                MsgBox("Valor da porcentagem ultrapassou o valor do capital social")

                Exit Sub
            End If
        Next





        'PERCA E GANHA///////////////////////////////////////////////////////////////////////////
        'coluna 2 e 3 nao podem ser vazio
        If DataGridView1.Rows(0).Cells(2).Value = "" Then
            MsgBox("Coluna 2 não pode ser vazia")
            Exit Sub
        End If



        If DataGridView1.Rows(0).Cells(3).Value = "" Then
            MsgBox("Coluna 3 não pode ser vazia")
            Exit Sub
        End If




        ' cada linha calcular a coluna3 - coluna2 individualmente e converter string para double
        For Each row As DataGridViewRow In DataGridView1.Rows
            'Converter em double em DIM 


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


    End Sub


    Private Sub Limpar()
        'limpaar
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        'limpa a formatação do datagridview



    End Sub

End Class