Public Class FrmProtocolados


    Private Sub FrmProtocolados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)


        EmpresasBindingSource.Filter = "Status = 'Junta Comercial - Protocolado' OR Status = 'Receita Federal - DBE' OR Status = 'Receita Estadual - Protocolado' OR Status = 'Simples Nacional - Protocolado' OR Status = 'Receita Federal - e-Processo' OR Status = 'Pêndencia Sistema Externo' "


    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub EmpresasDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            Legalizacao.Focus()
            Legalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            Legalizacao.Show()
            Legalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        Me.Refresh()
    End Sub
End Class