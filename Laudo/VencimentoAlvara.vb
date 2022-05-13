'Imports System.Data.SqlClientPublic

Class VencimentoAlvara

    Private Sub VencimentoAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

    End Sub



    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'atualizar gridview
        LaudosTableAdapter.Fill(PrinceDBDataSet.Laudos)

    End Sub


    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick


        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmAlvara.Focus()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        Else
            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'filtro entre data DateTimePicker1 e  DateTimePicker2 no gridview
        Dim FilterA As String
        Dim FilterB As String
        ' DateTimePicker1 dd/mm/yyy
        FilterA = DateTimePicker1.Text
        ' DateTimePicker2 dd/mm/yyy
        FilterB = DateTimePicker2.Text
        LaudosBindingSource.Filter = "BombeiroProvisorioDATA >= '" & FilterA & "' AND BombeiroProvisorioDATA <= '" & FilterB & "' OR ViabilidadeProvisorioDATA >= '" & FilterA & "' AND ViabilidadeProvisorioDATA <= '" & FilterB & "' OR AmbientalProvisorioDATA >= '" & FilterA & "' AND AmbientalProvisorioDATA <= '" & FilterB & "' OR SanitarioProvisorioDATA >= '" & FilterA & "' AND SanitarioProvisorioDATA <= '" & FilterB & "' OR SetranProvisorioDATA >= '" & FilterA & "' AND SetranProvisorioDATA <= '" & FilterB & "' "

    End Sub
End Class