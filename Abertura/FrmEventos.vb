Public Class FrmEventos

    Private Sub BtnEventos_Click(sender As Object, e As EventArgs) Handles BtnEventos.Click
        ' verifica se exitem itens marcados
        If CheckedListBoxEventosJunta.CheckedItems.Count <> 0 Then

            'pecorre os itens marcados e exibe o titulo e o estado do item

            For Each i As Object In CheckedListBoxEventosJunta.CheckedItems




                FrmLegalizacao.MotivoRichTextBox.Text += i.ToString() + Environment.NewLine



            Next
            'Me.Close()

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckedListBoxEventosJunta.CheckedItems.Count <> 0 Then

            'pecorre os itens marcados e exibe o titulo e o estado do item

            For Each i As Object In CheckedListBoxEventosJunta.CheckedItems
                'limpar

                FrmLegalizacao.MotivoRichTextBox.Clear()
                ' Me.Close()
            Next


        End If
    End Sub


    'ao digitar no  TextBox1 vai filtrar dentro da CheckedListBoxEventosJunta
    'nao diferenciando minuscula ou maiuscula
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim i As Integer
        For i = 0 To CheckedListBoxEventosJunta.Items.Count - 1
            If CheckedListBoxEventosJunta.Items(i).ToString().ToLower().Contains(TextBox1.Text.ToLower()) Then
                CheckedListBoxEventosJunta.SetItemChecked(i, True)
            Else
                CheckedListBoxEventosJunta.SetItemChecked(i, False)
            End If
        Next
    End Sub


    Private Sub CheckedListBoxEventosJunta_Click(sender As Object, e As EventArgs) Handles CheckedListBoxEventosJunta.Click
        'selecionar apenas onde for clicado e desmarcar o resto do ListBox
        Dim i As Integer
        Dim item As String
        Dim texto As String
        texto = CheckedListBoxEventosJunta.SelectedItem.ToString
        For i = 0 To CheckedListBoxEventosJunta.Items.Count - 1
            item = CheckedListBoxEventosJunta.Items(i).ToString
            If item.Contains(texto) Then
                CheckedListBoxEventosJunta.SetItemChecked(i, True)
            Else
                CheckedListBoxEventosJunta.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub
End Class