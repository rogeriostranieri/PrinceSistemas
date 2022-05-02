Public Class FrmProcedimentos




    Private Sub FrmProcedimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Municipio'. Você pode movê-la ou removê-la conforme necessário.
        Me.MunicipioTableAdapter.Fill(Me.PrinceDBDataSet.Municipio)

        'ORDEM ALFABETICA
        '   Try
        ' Me.MunicipioTableAdapter.FillByCidadeAlfab(Me.PrinceDBDataSet.Municipio)
        '  Catch ex As System.Exception
        '  System.Windows.Forms.MessageBox.Show(ex.Message)
        '  End Try
        ProcedimentoRichTextBox.Visible = False
        Label2.Visible = False
        ' TxtEstado.Text = UfLabel1.Text
        ' TxtCidade.Text = NomeLabel1.Text

    End Sub

    Private Sub Salvar()
        Me.Validate()
        Me.MunicipioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub





    Private Sub BtnBusca_Click(sender As Object, e As EventArgs) Handles BtnBusca.Click
        Try
            'FILTRO LAUDO
            Dim FilterA As String
            Dim FilterB As String
            FilterA = TxtCidade.Text
            FilterB = TxtEstado.Text

            If FilterA = "" Then
                ProcedimentoRichTextBox.Visible = False
            Else
                ' MunicipioBindingSource.Filter = "Nome like '" & FilterA & "%'"

                MunicipioBindingSource.Filter = "Nome Like '" & FilterA & "%' and  Uf Like '" & FilterB & "%'"
                ProcedimentoRichTextBox.Visible = True
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()

    End Sub

    Private Sub UfLabel1_TextChanged(sender As Object, e As EventArgs) Handles UfLabel1.TextChanged
        TxtEstado.Text = UfLabel1.Text
    End Sub

    Private Sub FrmProcedimentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.MunicipioBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.Municipio.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            ' message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)


            If MessageBox.Show(message, "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Try

                    MunicipioTableAdapter.Update(PrinceDBDataSet.Municipio)


                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



                End Try

            End If

        Else

            ' MessageBox.Show("Não há alterações na tabela para atualizar.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class