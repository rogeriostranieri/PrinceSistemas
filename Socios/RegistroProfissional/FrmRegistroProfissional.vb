Public Class FrmRegistroProfissional
    Private Sub FrmRegistroProfissional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega todos os registros ao abrir o formulário
        Me.RegistroProfissionalTableAdapter.Fill(Me.PrinceDBDataSet.RegistroProfissional)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ' Filtra os dados conforme o texto digitado no TextBox de pesquisa
        Dim filtro As String = TxtBuscar.Text.Trim()

        If filtro = "" Then
            ' Se o campo de busca estiver vazio, exibe todos os registros
            Me.RegistroProfissionalTableAdapter.Fill(Me.PrinceDBDataSet.RegistroProfissional)
        Else
            ' Aplica o filtro
            Me.RegistroProfissionalBindingSource.Filter = "Sigla LIKE '%" & filtro & "%' OR " &
                                                          "Extenso LIKE '%" & filtro & "%' OR " &
                                                          "Area LIKE '%" & filtro & "%'"
        End If
    End Sub

    Private Sub RegistroProfissionalDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegistroProfissionalDataGridView.CellDoubleClick
        Try
            ' Verifica se há uma linha válida selecionada
            If e.RowIndex >= 0 Then
                ' Obtém o índice correto da coluna "Sigla"
                Dim colunaSigla As Integer = RegistroProfissionalDataGridView.Columns("Sigla").Index
                Dim siglaSelecionada As String = RegistroProfissionalDataGridView.Rows(e.RowIndex).Cells(colunaSigla).Value.ToString()

                ' Verifica se o formulário FrmSocios está aberto
                Dim frm As FrmSocios = Application.OpenForms().OfType(Of FrmSocios)().FirstOrDefault()

                If frm IsNot Nothing Then
                    ' Envia a sigla para o ComboBox do FrmSocios
                    frm.RegistroOrgaoComboBox.Text = siglaSelecionada
                    ' Fecha este formulário
                    Me.Close()
                Else
                    MessageBox.Show("O formulário de Sócios não está aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao selecionar o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonFechar_Click(sender As Object, e As EventArgs) Handles ButtonFechar.Click
        Me.Close()
    End Sub
End Class
