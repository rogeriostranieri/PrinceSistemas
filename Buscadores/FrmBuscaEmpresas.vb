﻿

Public Class FrmBuscaEmpresas
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmBuscaEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'Esconder todos dados do EmpresasDataGridView
        Organizar()


    End Sub

    Private Sub Organizar()
        'auto organizar tamanho da coluna
        EmpresasDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EmpresasDataGridView.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub EmpresasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentClick
        AbrirEmpresa()


    End Sub

    Private Sub AbrirEmpresa()
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmLegalizacao.Focus()
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.CurrentRow.Cells(0).Value.ToString
            'FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmLegalizacao.Show()
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.CurrentRow.Cells(0).Value.ToString
            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub TxtPesquisaRazaoSocial_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaRazaoSocial.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()
        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "RazaoSocial like '%" & TxtPesquisaRazaoSocial.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtPesquisaCNPJ_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaCNPJ.TextChanged
        ' Limpar antes e reiniciar o filtro
        EmpresasBindingSource.RemoveFilter()

        ' Variável para armazenar o texto do TextBox
        Dim textoBusca As String = TxtPesquisaCNPJ.Text

        ' Verifica se o texto contém apenas números e tem 14 dígitos
        If IsNumeric(textoBusca) AndAlso textoBusca.Length = 14 Then
            ' Formata o texto como CNPJ
            textoBusca = FormatCNPJ(textoBusca)
        End If

        ' Filtra o DataGridView usando o valor formatado
        EmpresasBindingSource.Filter = "CNPJ LIKE '%" & textoBusca & "%'"

        ' Esconde as colunas especificadas
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False

        ' Organizar automaticamente o tamanho da coluna
        Organizar()
    End Sub

    ' Função para formatar o texto como CNPJ no formato XX.XXX.XXX/XXXX-XX
    Private Function FormatCNPJ(cnpj As String) As String
        Return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}"
    End Function




    Private Sub TextBoxResponsavel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxResponsavel.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "NomeResponsavel like '%" & TextBoxResponsavel.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = True
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtPesquisaProtJunta_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaProtJunta.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "ProtocoloJuntaComercial like '%" & TxtPesquisaProtJunta.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = True
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtPesquisaProtRedeSim_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaProtRedeSim.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "ProtocoloREDESIM like '%" & TxtPesquisaProtRedeSim.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = True
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtPesquisaCompEstado_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaCompEstado.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "IEComprovante like '%" & TxtPesquisaCompEstado.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = True
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtPesquisaProtEstado_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisaProtEstado.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "IEeProcNum like '%" & TxtPesquisaProtEstado.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = True
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()
        Organizar()
        'Mostrar colunas
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = True
        EmpresasDataGridView.Columns(3).Visible = True
        EmpresasDataGridView.Columns(4).Visible = True
        EmpresasDataGridView.Columns(5).Visible = True
        EmpresasDataGridView.Columns(6).Visible = True
        EmpresasDataGridView.Columns(7).Visible = True

        '        limpar todas txtbox
        TxtPesquisaRazaoSocial.Clear()
        TxtPesquisaCNPJ.Clear()
        TextBoxResponsavel.Clear()
        TxtPesquisaProtJunta.Clear()
        TxtPesquisaProtRedeSim.Clear()
        TxtPesquisaCompEstado.Clear()
        TxtPesquisaProtEstado.Clear()
        TxtNomeFantasia.Clear()
        TextBoxHistorico.Clear()
    End Sub

    Private Sub TxtCidade_TextChanged(sender As Object, e As EventArgs) Handles TxtCidade.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "EndCidade like '%" & TxtCidade.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = True
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtEstado_TextChanged(sender As Object, e As EventArgs) Handles TxtEstado.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "EndEstado like '%" & TxtEstado.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = True
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TxtNomeFantasia_TextChanged(sender As Object, e As EventArgs) Handles TxtNomeFantasia.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()
        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "NomeFantasia like '%" & TxtNomeFantasia.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = False
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = True
        'auto organizar tamanho da coluna
        Organizar()
    End Sub

    Private Sub TextBoxHistorico_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHistorico.TextChanged
        'Limpar Antes e reinicia o filtro
        EmpresasBindingSource.RemoveFilter()

        'Filtra o DataGridView
        EmpresasBindingSource.Filter = "Historico like '%" & TextBoxHistorico.Text & "%'"
        'esconder aa coluna 
        EmpresasDataGridView.Columns(1).Visible = True
        EmpresasDataGridView.Columns(2).Visible = False
        EmpresasDataGridView.Columns(3).Visible = True
        EmpresasDataGridView.Columns(4).Visible = False
        EmpresasDataGridView.Columns(5).Visible = False
        EmpresasDataGridView.Columns(6).Visible = False
        EmpresasDataGridView.Columns(7).Visible = False
        'auto organizar tamanho da coluna
        Organizar()
    End Sub
End Class