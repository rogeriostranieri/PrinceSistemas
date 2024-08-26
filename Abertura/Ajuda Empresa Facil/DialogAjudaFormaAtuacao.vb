Public Class DialogAjudaFormaAtuacao

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Salvar()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub AjudaEmpresaFacilTipoUnidade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            'verificar antes se teve alteração de dados
            Me.Close()
        End If
    End Sub

    Private Sub DialogAjudaFormaAtuacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.AjudaEmpresaFacil'. Você pode movê-la ou removê-la conforme necessário.
        Me.AjudaEmpresaFacilTableAdapter.Fill(Me.PrinceDBDataSet.AjudaEmpresaFacil)

    End Sub

    Private Sub Salvar()
        Try
            'verificar se foi modificado AjudaEmpresaFacilTableAdapter 
            Dim changedRecords As System.Data.DataTable
            Me.AjudaEmpresaFacilBindingSource.EndEdit()
            changedRecords = PrinceDBDataSet.AjudaEmpresaFacil.GetChanges()

            If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then
                Dim message As String
                'MOSTRA mgs mostransndo as alterações
                message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

                'mostra mensagem box SIM OU NAO OU CANCELA
                Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                    Dim e As Object = Nothing
                    e.Cancel = True
                ElseIf result = DialogResult.No Then
                    Me.Close()
                ElseIf result = DialogResult.Yes Then
                    Me.Validate()
                    Me.AjudaEmpresaFacilBindingSource.EndEdit()
                    Me.AjudaEmpresaFacilTableAdapter.Update(Me.PrinceDBDataSet.AjudaEmpresaFacil)
                    Me.AjudaEmpresaFacilTableAdapter.Fill(Me.PrinceDBDataSet.AjudaEmpresaFacil)
                End If
            End If

        Catch ex As Exception
            'mgs erro sao salvar MessageBoxIcon.Error
            MessageBox.Show("Erro ao Salvar Alterações" + vbCrLf + ex.Message, "Prince Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
