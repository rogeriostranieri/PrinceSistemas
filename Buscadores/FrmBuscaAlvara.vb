Public Class FrmBuscaAlvara
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmBuscaAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.CADSituacaoAlvara'. Você pode movê-la ou removê-la conforme necessário.
        Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


        'CheckBoxSituacao marcar
        CheckBoxSituacao.Checked = True
        'CheckBoxSituacao desmarcar
        CheckBoxSituacao.Checked = False

        'bloquear LaudosDataGridView para edições
        LaudosDataGridView.ReadOnly = True

        'combobox1 coloca nos itens "Descricao" do banco de dados CADSituacaoAlvara
        ComboBox1.DataSource = Me.PrinceDBDataSet.CADSituacaoAlvara
        ComboBox1.DisplayMember = "Descricao"
        ComboBox1.ValueMember = "Descricao"

    End Sub

    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick
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
        LaudosDataGridView.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        CheckBoxSituacao.Checked = False
    End Sub

    Private Sub RemoverFiltro()
        'atualizar db
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        'Limpar Antes e reinicia o filtro
        LaudosBindingSource.RemoveFilter()
    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        RemoverFiltro()
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
        TxtCidade.Clear()
        TextBoxHistorico.Clear()

    End Sub

    '/////////////// txt busca ///////////////
    Private Sub TxtPesquisaRazaoSocial_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaRazaoSocial.TextChanged
        RemoverFiltro()
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
        RemoverFiltro()
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
        RemoverFiltro()
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
        RemoverFiltro()
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
        RemoverFiltro()
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
        RemoverFiltro()
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


    Private Sub FiltroSituacao()
        If TxtPesquisaRazaoSocial.Text <> "" Then
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%' and RazaoSocial like '%" & TxtPesquisaRazaoSocial.Text & "%'"
        ElseIf TxtPesquisaCNPJ.Text <> "" Then
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%' and CNPJ like '%" & TxtPesquisaCNPJ.Text & "%'"
        ElseIf TextBoxRequerente.Text <> "" Then
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%' and Requerent like '%" & TextBoxRequerente.Text & "%'"
        ElseIf TxtCMC.Text <> "" Then
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%' and CMC like '%" & TxtCMC.Text & "%'"
        ElseIf TxtNumLaudo.Text <> "" Then
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%' and NumLaudo like '%" & TxtNumLaudo.Text & "%'"
        ElseIf TxtCidade.Text <> "" Then
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%' and EndCidade like '%" & TxtCidade.Text & "%'"
        Else
            LaudosBindingSource.Filter = "Situacao like '%" & ComboBox1.Text & "%'"
        End If
    End Sub
    Private Sub BtnFiltroSituacao_Click(sender As Object, e As EventArgs) Handles BtnFiltroSituacao.Click
        FiltroSituacao()
    End Sub

    Private Sub CheckBoxSituacao_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSituacao.CheckedChanged
        ' Verifica se a CheckBoxSituacao está marcada
        If CheckBoxSituacao.Checked = True Then
            ' Exibe os controles relacionados à situação
            GroupBox2.Visible = True
        Else
            ' Oculta os controles relacionados à situação
            GroupBox2.Visible = False
            ' Remove o filtro da LaudosBindingSource
            LaudosBindingSource.RemoveFilter()
        End If
    End Sub


    Private Sub TxtEstado_TextChanged(sender As Object, e As EventArgs) Handles TxtEstado.TextChanged
        RemoverFiltro()
        LaudosBindingSource.Filter = "EndEstado like '%" & TxtEstado.Text & "%'"

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

    Private Sub TextBoxHistorico_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHistorico.TextChanged
        RemoverFiltro()
        'Filtra o DataGridView
        LaudosBindingSource.Filter = "Historico like '%" & TextBoxHistorico.Text & "%'"
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