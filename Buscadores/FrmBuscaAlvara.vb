Public Class FrmBuscaAlvara
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmBuscaAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

    End Sub

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        LaudosBindingSource.Filter = "RazaoSocial like '%" & TxtPesquisa.Text & "%'"

    End Sub

    Private Sub LaudosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            FrmAlvara.Focus()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class