Public Class FrmLigacaoAlvara

    Private Sub FrmSetorAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        ComboBox1.SelectedIndex = ComboBox1.FindString("Bom")
        Button2.PerformClick()
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
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' PESQUISA COM FILTRO POR DATA AVISO
        'FILTRO LAUDO
        Dim FilterA As String
        FilterA = ComboBox1.Text
        LaudosBindingSource.Filter = "" & FilterA & " = 'Checked' "

        Filtro()
    End Sub


    Private Sub Filtro()

        Dim FilterA As String
        FilterA = ComboBox1.Text
        Select Case FilterA
            Case "Bombeiros"
                LaudosDataGridView.Columns("BombeiroExigencia").Visible = True
                LaudosDataGridView.Columns("AmbientalExigencia").Visible = False
                LaudosDataGridView.Columns("ViabilidadeExigencia").Visible = False
                LaudosDataGridView.Columns("SanitarioExigencia").Visible = False
                LaudosDataGridView.Columns("SetranExigencia").Visible = False
            Case "Ambiental"
                LaudosDataGridView.Columns("BombeiroExigencia").Visible = False
                LaudosDataGridView.Columns("AmbientalExigencia").Visible = True
                LaudosDataGridView.Columns("ViabilidadeExigencia").Visible = False
                LaudosDataGridView.Columns("SanitarioExigencia").Visible = False
                LaudosDataGridView.Columns("SetranExigencia").Visible = False
            Case "Viabilidade"
                LaudosDataGridView.Columns("BombeiroExigencia").Visible = False
                LaudosDataGridView.Columns("AmbientalExigencia").Visible = False
                LaudosDataGridView.Columns("ViabilidadeExigencia").Visible = True
                LaudosDataGridView.Columns("SanitarioExigencia").Visible = False
                LaudosDataGridView.Columns("SetranExigencia").Visible = False
            Case "Sanitario"
                LaudosDataGridView.Columns("BombeiroExigencia").Visible = False
                LaudosDataGridView.Columns("AmbientalExigencia").Visible = False
                LaudosDataGridView.Columns("ViabilidadeExigencia").Visible = False
                LaudosDataGridView.Columns("SanitarioExigencia").Visible = True
                LaudosDataGridView.Columns("SetranExigencia").Visible = False
            Case "Setran"
                LaudosDataGridView.Columns("BombeiroExigencia").Visible = False
                LaudosDataGridView.Columns("AmbientalExigencia").Visible = False
                LaudosDataGridView.Columns("ViabilidadeExigencia").Visible = False
                LaudosDataGridView.Columns("SanitarioExigencia").Visible = False
                LaudosDataGridView.Columns("SetranExigencia").Visible = True

            Case Else

                LaudosDataGridView.Columns("BombeiroExigencia").Visible = False
                LaudosDataGridView.Columns("AmbientalExigencia").Visible = False
                LaudosDataGridView.Columns("ViabilidadeExigencia").Visible = False
                LaudosDataGridView.Columns("SanitarioExigencia").Visible = False
                LaudosDataGridView.Columns("SetranExigencia").Visible = False

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        Me.Refresh()
        Filtro()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Application.OpenForms.OfType(Of Telefones)().Count() > 0 Then

            Telefones.Focus()


        Else

            Telefones.MdiParent = MDIPrincipal
            Telefones.Show()

        End If
    End Sub
End Class