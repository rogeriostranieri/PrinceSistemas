Public Class FrmEventos

    Private Sub BtnEventos_Click(sender As Object, e As EventArgs) Handles BtnEventos.Click
        ' verifica se exitem itens marcados
        If CheckedListBoxEventosJunta.CheckedItems.Count <> 0 Then

            'pecorre os itens marcados e exibe o titulo e o estado do item

            For Each i As Object In CheckedListBoxEventosJunta.CheckedItems




                Legalizacao.MotivoRichTextBox.Text += i.ToString() + Environment.NewLine



            Next
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckedListBoxEventosJunta.CheckedItems.Count <> 0 Then

            'pecorre os itens marcados e exibe o titulo e o estado do item

            For Each i As Object In CheckedListBoxEventosJunta.CheckedItems
                'limpar

                Legalizacao.MotivoRichTextBox.Clear()
                Me.Close()
            Next


        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ' Dim items = From it In CheckedListBoxEventosJunta.Items.Cast(Of Object)()
        '             Where it.ToString().IndexOf(TextBox1.Text, StringComparison.CurrentCultureIgnoreCase) >= 0


        ' Dim matchingItemList As List(Of Object) = items.ToList()
        'CheckedListBoxEventosJunta.BeginUpdate()
        'CheckedListBoxEventosJunta.Items.Clear()


        'For Each item In matchingItemList

        '   CheckedListBoxEventosJunta.Items.Add(item)

        ' Next

        ' CheckedListBoxEventosJunta.EndUpdate()


        Dim i As Integer = CheckedListBoxEventosJunta.FindString(TextBox1.Text)



        CheckedListBoxEventosJunta.SelectedIndex = i



    End Sub


End Class