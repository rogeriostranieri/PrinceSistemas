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
        'LaudosBindingSource.Filter = "BombeiroProvisorioDATA <> '0' OR ViabilidadeProvisorioDATA <> '0' OR AmbientalProvisorioDATA <> '0' OR SanitarioProvisorioDATA <> '0' OR SetranProvisorioDATA <> '0' "

        'LaudosBindingSource.Filter = "BombeiroProvisorioDATA <> '' OR ViabilidadeProvisorioDATA <> '' OR AmbientalProvisorioDATA <> '' OR SanitarioProvisorioDATA <> '' OR SetranProvisorioDATA <> '' "

        ' esteja em andamento e finalizado 

        LaudosBindingSource.Filter = "
BombeiroProvisorioDATA <> '0' 
OR ViabilidadeProvisorioDATA <> '0' 
OR AmbientalProvisorioDATA <> '0' 
OR SanitarioProvisorioDATA <> '0' 
OR SetranProvisorioDATA <> '0' 

OR BombeiroProvisorioDATA <> '' 
OR ViabilidadeProvisorioDATA <> '' 
OR AmbientalProvisorioDATA <> '' 
OR SanitarioProvisorioDATA <> '' 
OR SetranProvisorioDATA <> '' 

OR BombeiroProvisorioDATA = 'Finalizado Definitivo' 
OR BombeiroProvisorioDATA = 'Finalizado Provisório'
OR ViabilidadeProvisorioDATA = 'Finalizado Definitivo' 
OR ViabilidadeProvisorioDATA = 'Finalizado Provisório'
OR AmbientalProvisorioDATA = 'Finalizado Definitivo'  
OR AmbientalProvisorioDATA = 'Finalizado Provisório' 
OR SanitarioProvisorioDATA = 'Finalizado Definitivo'  
OR SanitarioProvisorioDATA = 'Finalizado Provisório' 
OR SetranProvisorioDATA = 'Finalizado Definitivo'  
OR SetranProvisorioDATA = 'Finalizado Provisório' 
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
        LaudosBindingSource.Filter = "BombeiroProvisorioDATA = '" & FilterA & "' OR ViabilidadeProvisorioDATA = '" & FilterA & "' OR AmbientalProvisorioDATA = '" & FilterA & "' OR SanitarioProvisorioDATA = '" & FilterA & "' OR SetranProvisorioDATA = '" & FilterA & "' "

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        Me.Refresh()
        LaudosBindingSource.Filter = "BombeiroProvisorioDATA <> '0' OR ViabilidadeProvisorioDATA <> '0' OR AmbientalProvisorioDATA <> '0' OR SanitarioProvisorioDATA <> '0' OR SetranProvisorioDATA <> '0' "


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