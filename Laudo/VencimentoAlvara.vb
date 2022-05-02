'Imports System.Data.SqlClientPublic

Class VencimentoAlvara
    Private Sub LaudosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LaudosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub

    Private Sub VencimentoAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        MaskedTextBox1.Text = Now.ToString("dd/MM/yyyy")



        ' antigo e funciona
        'LaudosBindingSource.Filter = "BombeiroDataProvisorio <> '0' OR ViabilidadeDataProvisorio <> '0' OR AmbientalDataProvisorio <> '0' OR SanitarioDataProvisorio <> '0' OR SetranDataProvisorio <> '0' "

        'LaudosBindingSource.Filter = "BombeiroDataProvisorio <> '' OR ViabilidadeDataProvisorio <> '' OR AmbientalDataProvisorio <> '' OR SanitarioDataProvisorio <> '' OR SetranDataProvisorio <> '' "

        ' esteja em andamento e finalizado 

        LaudosBindingSource.Filter = "
BombeiroDataProvisorio <> '0' 
OR ViabilidadeDataProvisorio <> '0' 
OR AmbientalDataProvisorio <> '0' 
OR SanitarioDataProvisorio <> '0' 
OR SetranDataProvisorio <> '0' 

OR BombeiroDataProvisorio <> '' 
OR ViabilidadeDataProvisorio <> '' 
OR AmbientalDataProvisorio <> '' 
OR SanitarioDataProvisorio <> '' 
OR SetranDataProvisorio <> '' 

OR BombeiroDataProvisorio = 'Finalizado Definitivo' 
OR BombeiroDataProvisorio = 'Finalizado Provisório'
OR ViabilidadeDataProvisorio = 'Finalizado Definitivo' 
OR ViabilidadeDataProvisorio = 'Finalizado Provisório'
OR AmbientalDataProvisorio = 'Finalizado Definitivo'  
OR AmbientalDataProvisorio = 'Finalizado Provisório' 
OR SanitarioDataProvisorio = 'Finalizado Definitivo'  
OR SanitarioDataProvisorio = 'Finalizado Provisório' 
OR SetranDataProvisorio = 'Finalizado Definitivo'  
OR SetranDataProvisorio = 'Finalizado Provisório' 
"

    End Sub



    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' PESQUISA COM FILTRO POR DATA AVISO
        'FILTRO LAUDO
        Dim FilterA As String
        FilterA = MaskedTextBox1.Text
        LaudosBindingSource.Filter = "BombeiroDataProvisorio = '" & FilterA & "' OR ViabilidadeDataProvisorio = '" & FilterA & "' OR AmbientalDataProvisorio = '" & FilterA & "' OR SanitarioDataProvisorio = '" & FilterA & "' OR SetranDataProvisorio = '" & FilterA & "' "

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        Me.Refresh()
        LaudosBindingSource.Filter = "BombeiroDataProvisorio <> '0' OR ViabilidadeDataProvisorio <> '0' OR AmbientalDataProvisorio <> '0' OR SanitarioDataProvisorio <> '0' OR SetranDataProvisorio <> '0' "


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


End Class