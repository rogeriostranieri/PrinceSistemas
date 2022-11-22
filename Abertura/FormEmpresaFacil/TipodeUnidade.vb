Imports System.Windows.Forms

Public Class TipodeUnidade

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'limpar antes o TipoUnidadeProdutivaRichTextBox ""
        FrmLegalizacao.TipoUnidadeProdutivaRichTextBox.Text = ""
        'ver qual foi selecionardo no CheckedListBox1 e adicionar
        'se for mais que um, adicionar proximo paragrafo entre eles
        'adicionar no Frmlegalizacao.TipoUnidadeProdutivaRichTextBox.Text
        Dim i As Integer
        Dim s As String = ""
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) Then
                s = s & CheckedListBox1.Items(i).ToString & vbCrLf
            End If
        Next
        FrmLegalizacao.TipoUnidadeProdutivaRichTextBox.Text = s

        If FrmLegalizacao.TipoUnidadeProdutivaRichTextBox.Text.Contains("Unidade Produtiva") Then
            FrmLegalizacao.FormaDeAtuacaoRichTextBox.Visible = True
            FrmLegalizacao.FormaDeAtuacaoLabel.Visible = True

            FormadeAtuacao.ShowDialog()
            'focus
            FormadeAtuacao.Focus()
        Else
            FrmLegalizacao.FormaDeAtuacaoRichTextBox.Visible = False
            FrmLegalizacao.FormaDeAtuacaoLabel.Visible = False
        End If

        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
