Public Class FrmEmailCaixaDeSaida

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub



    Private Sub FrmEmailCaixaDeSaida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.eMailCaixaDeSaida'. Você pode movê-la ou removê-la conforme necessário.
        Me.EMailCaixaDeSaidaTableAdapter.Fill(Me.PrinceDBDataSet.eMailCaixaDeSaida)

        'nao permitir edicao CaixaDeSaidaTextoRichTextBox
        Me.CaixaDeSaidaTextoRichTextBox.ReadOnly = True


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class