Public Class FormadeAtuacao

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'limpar Frmlegalizacao.FormaDeAtuacaoTextBox.Text
        FrmLegalizacao.FormaDeAtuacaoRichTextBox.Text = ""

        'ver qual foi selecionardo no CheckedListBox1 e adicionar
        'se for mais que um, adicionar "/" entre eles
        'adicionar no Frmlegalizacao.FormaDeAtuacaoTextBox.Text
        Dim i As Integer
        Dim s As String = ""
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) Then
                s = s & CheckedListBox1.Items(i).ToString & vbCrLf
            End If
        Next
        FrmLegalizacao.FormaDeAtuacaoRichTextBox.Text = s
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
