﻿Public Class FrmProtocolados


    Private Sub FrmProtocolados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

        Filtro()
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub EmpresasDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            FrmLegalizacao.Focus()
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.CurrentRow.Cells(0).Value.ToString
            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmLegalizacao.Show()
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.CurrentRow.Cells(0).Value.ToString
            FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        Me.Refresh()
    End Sub


    Private Sub Filtro()
        Dim filtro As String = "protocolado"
        Dim filtro1 As String = "e-Processo"
        Dim filtro2 As String = "Procuração"

        ''filtrar Status da EmpresasBindingSource que contenha "protocolado" ou "e-Processo""Procuração"
        EmpresasBindingSource.Filter = String.Format("Status LIKE '%{0}%' OR Status LIKE '%{1}%' OR Status LIKE '%{2}%'", filtro, filtro1, filtro2)
        '  Me.EmpresasBindingSource.Filter = "Status like '%" & filtro & "%'"
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub


    ' EmpresasBindingSource.Filter = "Status = 'Junta Comercial - Protocolado' OR Status = 'Receita Federal - DBE' OR Status = 'Receita Estadual - Protocolado' OR Status = 'Simples Nacional - Protocolado' OR Status = 'Receita Federal - e-Processo' OR Status = 'Pêndencia Sistema Externo' "
End Class