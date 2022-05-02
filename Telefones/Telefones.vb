Public Class Telefones


    Private Sub Salvar()
        Me.Validate()
        Me.TelefonesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)


    End Sub

    Private Sub Telefones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Telefones'. Você pode movê-la ou removê-la conforme necessário.
        Me.TelefonesTableAdapter.Fill(Me.PrinceDBDataSet.Telefones)

        'Combobox do toolstrip
        With Me.ComboBoxBusca.ComboBox
            .DisplayMember = "Nome"
            .ValueMember = "ID"
            .DataSource = Me.TelefonesBindingSource
        End With

        'CboCidadeOrgao
        'If IsNull(CboCidadeOrgao) Then


    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                'Using WS = New WSCorreios.AtendeClienteClient()
                Dim Resultado = WS.consultaCEP(CEPMaskedTextBox.Text)
                EndereçoTextBox.Text = Resultado.[end]
                'EndComplementoTextBox.Text = Resultado.complemento
                ComplementoTextBox.Text = Resultado.complemento2
                CidadeTextBox.Text = Resultado.cidade
                BairroTextBox.Text = Resultado.bairro
                EstadoTextBox.Text = Resultado.uf
                ' mgs de erro

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try

        End Using
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.TelefonesBindingSource.AddNew()
        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.TelefonesBindingSource.RemoveCurrent()
            Me.TelefonesTableAdapter.Update(Me.PrinceDBDataSet.Telefones)
            Me.TelefonesTableAdapter.Fill(Me.PrinceDBDataSet.Telefones)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
            Salvar()
        Else

        End If


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Me.Close()

    End Sub

    ' Private Sub Telefones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    ' Dim result As Integer = MessageBox.Show("Deseja Salvar as Alterações antes de fechar o formulário?", "Prince Alerta", MessageBoxButtons.YesNoCancel)
    ' If result = DialogResult.Cancel Then
    '    e.Cancel = True
    ' ElseIf result = DialogResult.No Then

    ' ElseIf result = DialogResult.Yes Then
    '  Me.Validate()
    '  Me.TelefonesBindingSource.EndEdit()
    '  Me.TelefonesTableAdapter.Update(Me.PrinceDBDataSet.Telefones)

    '  End If
    'End Sub



    Private Sub Telefones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.TelefonesBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.Telefones.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            ' message = String.Format("Você teve = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

            If MessageBox.Show(message, "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Try

                    TelefonesTableAdapter.Update(PrinceDBDataSet.Telefones)


                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



                End Try

            End If

        Else

            ' MessageBox.Show("Não há alterações na tabela para atualizar.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub CboCidadeOrgao_TextChanged(sender As Object, e As EventArgs) Handles CboCidadeOrgao.TextChanged
        Me.TelefonesBindingSource.Filter = "Nome LIKE '%" & Me.CboCidadeOrgao.Text & "%' "
        'Me.TelefonesBindingSource.Filter = "OrgaoCidade LIKE '%" & Me.CboCidadeOrgao.Text & "%' "
    End Sub
End Class