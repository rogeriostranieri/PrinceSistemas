Imports System.Net.Http

Public Class Contador
    Private Sub Salvar()
        Me.Validate()
        Me.ContadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub

    Private Sub Contador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Contador'. Você pode movê-la ou removê-la conforme necessário.
        Me.ContadorTableAdapter.Fill(Me.PrinceDBDataSet.Contador)

        'Combobox do toolstrip
        With Me.ComboBoxBusca.ComboBox
            .DisplayMember = "Nome"
            .ValueMember = "ID"
            .DataSource = Me.ContadorBindingSource
        End With


    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(EndCEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                EnderecoTextBox.Text = resultado.logradouro
                EndCompTextBox.Text = resultado.complemento
                EndCidadeTextBox.Text = resultado.localidade
                EndBairroTextBox.Text = resultado.bairro
                EndEstadoTextBox.Text = resultado.uf
            Else
                MessageBox.Show("CEP não encontrado.")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar informações de CEP: " & ex.Message)
        End Try
    End Sub


    Private Sub Contador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.ContadorBindingSource.AddNew()
        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.ContadorBindingSource.RemoveCurrent()
            Me.ContadorTableAdapter.Update(Me.PrinceDBDataSet.Contador)
            Me.ContadorTableAdapter.Fill(Me.PrinceDBDataSet.Contador)
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

    Private Sub Contador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.ContadorBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.Contador.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

            If MessageBox.Show(message, "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Try

                    ContadorTableAdapter.Update(PrinceDBDataSet.Contador)


                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



                End Try

            End If

        Else

            ' MessageBox.Show("Não há alterações na tabela para atualizar.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class