Public Class FrmEmailCaixaDeSaida

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub FrmMail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.EMailCaixaDeSaidaBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.eMailCaixaDeSaida.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)


            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try

                    EMailCaixaDeSaidaTableAdapter.Update(PrinceDBDataSet.eMailCaixaDeSaida)

                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If


        End If
    End Sub


    Private Sub FrmEmailCaixaDeSaida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.eMailCaixaDeSaida'. Você pode movê-la ou removê-la conforme necessário.
        Me.EMailCaixaDeSaidaTableAdapter.Fill(Me.PrinceDBDataSet.eMailCaixaDeSaida)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class