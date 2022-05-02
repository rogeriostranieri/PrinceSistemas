Public Class LembreteInicial
    Private Sub EmpresasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub



    Private Sub LembreteInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

        ' Dim FilterA As String
        ' FilterA = "Checked"
        EmpresasBindingSource.Filter = "Lembrete = 'Checked' "

        LaudosBindingSource.Filter = "Lembrete = 'Checked' "

    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        Me.Refresh()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Application.OpenForms.OfType(Of VbAvisoPrincipal)().Count() > 0 Then

            VbAvisoPrincipal.Focus()
            VbAvisoPrincipal.MdiParent = MDIPrincipal


        Else

            VbAvisoPrincipal.MdiParent = MDIPrincipal
            VbAvisoPrincipal.Show()


        End If
    End Sub

    Private Sub EmpresasDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            '  Dim novoEmpresa As New Legalizacao
            Legalizacao.Focus()
            Legalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
        Else
            ' Dim novoEmpresa As New Legalizacao
            ' novoEmpresa.MdiParent = MDIPrincipal
            Legalizacao.Show()
            Legalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
        End If
    End Sub

    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            '  Dim NovoLaudo As New LaudosCadastro
            FrmAlvara.Focus()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        Else
            ' Dim NovoLaudo As New LaudosCadastro
            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        End If
    End Sub
End Class