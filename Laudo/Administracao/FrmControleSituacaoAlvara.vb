Public Class FrmControleSituacaoAlvara

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmControleSituacaoAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.CADSituacaoAlvara'. Você pode movê-la ou removê-la conforme necessário.
        Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)

    End Sub

    Private Sub Salvar()

        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.CADSituacaoAlvaraBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.CADSituacaoAlvara.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'MOSTRA MENSAGM BOX
            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

            'mostra mensagem box SIM OU NAO OU CANCELA
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                ' e.Cancel = True
            ElseIf result = DialogResult.No Then
                'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
                Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)

            ElseIf result = DialogResult.Yes Then


                Try

                    'Salva alterações
                    Me.Validate()
                    Me.CADSituacaoAlvaraBindingSource.EndEdit()
                    Me.CADSituacaoAlvaraTableAdapter.Update(Me.PrinceDBDataSet.CADSituacaoAlvara)







                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If

        Else



        End If




    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.CADSituacaoAlvaraBindingSource.AddNew()
        Else

        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.CADSituacaoAlvaraBindingSource.RemoveCurrent()
            Me.CADSituacaoAlvaraTableAdapter.Update(Me.PrinceDBDataSet.CADSituacaoAlvara)
            Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
        Me.Refresh()
    End Sub
End Class