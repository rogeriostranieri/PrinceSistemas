Public Class FrmBuscaAlvara
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmBuscaAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

    End Sub

    Private Sub LaudosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            FrmAlvara.Focus()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.CurrentRow.Cells(0).Value.ToString
            ' FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView.CurrentRow.Cells(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Organizar()
        'auto organizar tamanho da coluna
        LaudosDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LaudosDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LaudosDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LaudosDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LaudosDataGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LaudosDataGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LaudosDataGridView.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        Organizar()
        'Mostrar colunas
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = True
        LaudosDataGridView.Columns(3).Visible = True
        LaudosDataGridView.Columns(4).Visible = True
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True
        '        limpar todas txtbox
        TxtPesquisaRazaoSocial.Clear()
        TxtPesquisaCNPJ.Clear()
        TextBoxRequerente.Clear()
        TxtCMC.Clear()
        TxtNumLaudo.Clear()

    End Sub

    '/////////////// txt busca ///////////////
    Private Sub TxtPesquisaRazaoSocial_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaRazaoSocial.TextChanged
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "RazaoSocial like '%" & TxtPesquisaRazaoSocial.Text & "%'"
        'esconder aa coluna
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = False
        LaudosDataGridView.Columns(3).Visible = False
        LaudosDataGridView.Columns(4).Visible = False
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True

        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtPesquisaCNPJ_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaCNPJ.TextChanged
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "CNPJ like '%" & TxtPesquisaCNPJ.Text & "%'"
        'esconder aa coluna 
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = False
        LaudosDataGridView.Columns(3).Visible = False
        LaudosDataGridView.Columns(4).Visible = False
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True

        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TextBoxRequerente_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRequerente.TextChanged
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "Requerente like '%" & TextBoxRequerente.Text & "%'"
        'esconder aa coluna 
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = True
        LaudosDataGridView.Columns(3).Visible = False
        LaudosDataGridView.Columns(4).Visible = False
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True

        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtCMC_TextChanged(sender As Object, e As EventArgs) Handles TxtCMC.TextChanged
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "CMC like '%" & TxtCMC.Text & "%'"
        'esconder aa coluna 
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = False
        LaudosDataGridView.Columns(3).Visible = True
        LaudosDataGridView.Columns(4).Visible = False
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True

        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtNumLaudo_TextChanged(sender As Object, e As EventArgs) Handles TxtNumLaudo.TextChanged
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "Nlaudo like '%" & TxtNumLaudo.Text & "%'"
        'esconder aa coluna 
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = False
        LaudosDataGridView.Columns(3).Visible = False
        LaudosDataGridView.Columns(4).Visible = True
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True

        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtCidade_TextChanged(sender As Object, e As EventArgs) Handles TxtCidade.TextChanged
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "EndCidade like '%" & TxtCidade.Text & "%'"
        'esconder aa coluna 
        LaudosDataGridView.Columns(0).Visible = True
        LaudosDataGridView.Columns(1).Visible = True
        LaudosDataGridView.Columns(2).Visible = False
        LaudosDataGridView.Columns(3).Visible = False
        LaudosDataGridView.Columns(4).Visible = True
        LaudosDataGridView.Columns(5).Visible = True
        LaudosDataGridView.Columns(6).Visible = True

        'auto organizar tamanho da coluna
        Organizar()
    End Sub
End Class