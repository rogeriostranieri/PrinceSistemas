Imports System.Data.SqlClient

Public Class FrmProtocoladosGeral


    Private Sub FrmProtocoladosGeral_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla ESC foi pressionada
        If e.KeyCode = Keys.Escape Then
            Me.Close() ' Fecha o formulário
        End If
    End Sub



    Private Sub FrmProtocoladosGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Configurar as colunas da DataGridViewEmpresas
        DataGridViewEmpresas.AutoGenerateColumns = False
        DataGridViewEmpresas.Columns.Clear()
        DataGridViewEmpresas.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "RazaoSocial", .HeaderText = "Razão Social", .Name = "RazaoSocial"})
        DataGridViewEmpresas.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Status", .HeaderText = "Status", .Name = "Status"})
        DataGridViewEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Configurar as colunas da DataGridViewLaudos
        DataGridViewLaudos.AutoGenerateColumns = False
        DataGridViewLaudos.Columns.Clear()
        DataGridViewLaudos.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "RazaoSocial", .HeaderText = "Razão Social", .Name = "RazaoSocial"})
        DataGridViewLaudos.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Situacao", .HeaderText = "Situação", .Name = "Situacao"})
        DataGridViewLaudos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Carregar os dados quando o formulário for carregado
        CarregarDados()
    End Sub

    ' Método para carregar os dados nos DataGridViews
    Private Sub CarregarDados()
        ' Definir a connection string
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

        ' Conectar ao banco de dados e carregar os dados para Empresas
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Consulta para a tabela Empresas
            Dim queryEmpresas As String = "SELECT RazaoSocial, Status FROM Empresas WHERE Status LIKE '%protocolado%' OR Status LIKE '%processo%'"
            Dim adapterEmpresas As New SqlDataAdapter(queryEmpresas, connection)
            Dim tableEmpresas As New DataTable()
            adapterEmpresas.Fill(tableEmpresas)

            ' Atualizar a fonte de dados do DataGridViewEmpresas sem recriar as colunas
            DataGridViewEmpresas.DataSource = tableEmpresas

            ' Atualizar o total de empresas encontradas
            LblTotalEmpresa.Text = tableEmpresas.Rows.Count.ToString()

            ' Consulta para a tabela Laudos
            Dim queryLaudos As String = "SELECT RazaoSocial, Situacao FROM Laudos WHERE Situacao LIKE '%protocolado%' OR Situacao LIKE '%processo%'"
            Dim adapterLaudos As New SqlDataAdapter(queryLaudos, connection)
            Dim tableLaudos As New DataTable()
            adapterLaudos.Fill(tableLaudos)

            ' Atualizar a fonte de dados do DataGridViewLaudos sem recriar as colunas
            DataGridViewLaudos.DataSource = tableLaudos

            ' Atualizar o total de laudos encontrados
            LblTotallaudos.Text = tableLaudos.Rows.Count.ToString()
        End Using
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        ' Chamar o método para recarregar os dados ao clicar no botão
        CarregarDados()
    End Sub

    ' Comportamento dos Grid

    Private Sub DataGridViewEmpresas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmpresas.CellDoubleClick
        AbrirEmpresa(e)
    End Sub

    Private Sub AbrirEmpresa(ByVal e As DataGridViewCellEventArgs)
        ' Verificar se a célula clicada é válida
        If e.RowIndex >= 0 Then
            ' Obter a razão social da linha selecionada
            Dim selectedRow As DataGridViewRow = DataGridViewEmpresas.Rows(e.RowIndex)
            Dim razaoSocial As String = selectedRow.Cells("RazaoSocial").Value.ToString()

            ' Verificar se o FrmLegalizacao já está aberto
            Dim frmLegalizacao As FrmLegalizacao = Application.OpenForms.OfType(Of FrmLegalizacao)().FirstOrDefault()

            If frmLegalizacao IsNot Nothing Then
                ' Se FrmLegalizacao já está aberto, trazê-lo para frente
                frmLegalizacao.BringToFront()
            Else
                ' Se FrmLegalizacao não estiver aberto, criar nova instância e abrir o formulário
                frmLegalizacao = New FrmLegalizacao()
                frmLegalizacao.MdiParent = MDIPrincipal ' Se for um formulário MDI
                frmLegalizacao.Show()
                frmLegalizacao.BringToFront()
            End If

            ' Atualizar o ComboBox com a Razão Social
            frmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocial
            frmLegalizacao.ComboBoxBuscaEmpresa.Select()
        End If
    End Sub


    Private Sub DataGridViewLaudos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLaudos.CellDoubleClick
        AbrirLaudo(e)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnAtualizar1_Click(sender As Object, e As EventArgs) Handles BtnAtualizar1.Click
        CarregarDados()
    End Sub

    Private Sub DataGridViewLaudos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLaudos.CellContentDoubleClick
        AbrirLaudo(e)
    End Sub

    Private Sub AbrirLaudo(ByVal e As DataGridViewCellEventArgs)
        ' Verificar se a célula clicada é válida
        If e.RowIndex >= 0 Then
            ' Obter a razão social da linha selecionada
            Dim selectedRow As DataGridViewRow = DataGridViewLaudos.Rows(e.RowIndex)
            Dim razaoSocial As String = selectedRow.Cells("RazaoSocial").Value.ToString()

            ' Verificar se o FrmAlvara já está aberto
            Dim frmAlvara As FrmAlvara = Application.OpenForms.OfType(Of FrmAlvara)().FirstOrDefault()

            If frmAlvara IsNot Nothing Then
                ' Se FrmAlvara já está aberto, trazê-lo para frente
                frmAlvara.BringToFront()
            Else
                ' Se FrmAlvara não estiver aberto, criar nova instância e abrir o formulário
                frmAlvara = New FrmAlvara()
                frmAlvara.MdiParent = MDIPrincipal ' Se for um formulário MDI
                frmAlvara.Show()
                frmAlvara.BringToFront()
            End If

            ' Atualizar o ComboBox com a Razão Social
            frmAlvara.ComboBoxBuscaAlvara.Text = razaoSocial
            frmAlvara.ComboBoxBuscaAlvara.Select()
        End If
    End Sub

    Private Sub DataGridViewEmpresas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmpresas.CellContentDoubleClick
        AbrirEmpresa(e)
    End Sub
End Class
