Public Class FrmBuscaResponsavelLaudo
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmBuscaResponsavelLaudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles BtnAbrir.Click
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            FrmAlvara.Focus()
            'pega o texto da RazaoSocialTextBox e coloca FrmAlvara.ComboBoxBuscaAlvara
            FrmAlvara.ComboBoxBuscaAlvara.Text = RazaoSocialTextBox.Text.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBoxBuscaAlvara.Text = RazaoSocialTextBox.Text.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        End If
    End Sub
End Class