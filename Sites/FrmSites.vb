Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FrmSites
    Private originalData As DataTable
    Private dadosAlterados As Boolean = False ' Variável para detectar alterações


    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
    Private Sub FrmSites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Sites'. Você pode movê-la ou removê-la conforme necessário.
        Me.SitesTableAdapter.Fill(Me.PrinceDBDataSet.Sites)
        ' Marcar o DataSet como não modificado ao abrir o formulário
        Me.PrinceDBDataSet.Sites.AcceptChanges()

        ' Desabilitar o GroupBox2 ao iniciar
        GroupBox2.Enabled = False
        originalData = Me.PrinceDBDataSet.Sites.Copy() ' Copiar dados originais
        Me.KeyPreview = True

    End Sub
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If MsgBox("Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            ' Adicionar um novo registro no BindingSource
            Me.Validate()
            Me.SitesBindingSource.AddNew()

            Dim frmCidades As New FrmBrasilCidadesGeral()
            frmCidades.ShowDialog(Me) ' Abre o formulário como modal

            ' Verificar se o usuário selecionou uma cidade ou distrito
            If frmCidades.CidadeSelecionada IsNot Nothing Then
                ' Preencher os campos no FrmSites com os dados selecionados
                CidadeTextBox.Text = frmCidades.CidadeSelecionada
                EstadoTextBox.Text = frmCidades.EstadoSelecionado ' Preencher o nome do estado

                ' Se houver um distrito selecionado, preencha o campo correspondente
                Dim distritoSelecionado = frmCidades.DistritoSelecionado
                If Not String.IsNullOrEmpty(distritoSelecionado) Then
                    DistritoTextBox.Text = distritoSelecionado
                End If

                ' Habilitar o GroupBox2 para edição
                GroupBox2.Enabled = True
                BtnEditar.Text = "Cancelar" ' Resetar texto do botão

            End If
        End If
    End Sub






    Private Function VerificarSeJaExiste(cidadeSelecionada As String) As Boolean
        Dim existe As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Sites WHERE Cidade = @cidade"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cidade", cidadeSelecionada)
                conn.Open()
                existe = CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using

        Return existe
    End Function




    ' botao 

    Private Sub Salvar()
        Try
            ' Verifica se houve alterações
            Dim result As DialogResult = MessageBox.Show("Deseja salvar a alteração?", "Salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Adicionar ou atualizar registro
                Me.Validate()
                Me.SitesBindingSource.EndEdit()
                Me.SitesTableAdapter.Update(Me.PrinceDBDataSet.Sites)
                MessageBox.Show("Registro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Desativar o grupo de edição
                GroupBox2.Enabled = False

                ' Atualizar dados originais
                originalData = Me.PrinceDBDataSet.Sites.Copy()

                ' Resetar o botão para o modo de edição
                BtnEditar.Text = "Editar"

            ElseIf result = DialogResult.No Then
                ' Desfazer as alterações e recarregar os dados originais
                Me.PrinceDBDataSet.Sites.Clear()
                Me.SitesTableAdapter.Fill(Me.PrinceDBDataSet.Sites)

                ' Desativar o grupo de edição
                GroupBox2.Enabled = False
                BtnEditar.Text = "Editar"

                ' Se o usuário clicar em Cancelar, não faz nada
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento ao fechar o formulário
    Private Sub FrmSites_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Verifica se há alterações no DataSet
        If Me.PrinceDBDataSet.HasChanges() Then
            ' Pergunta ao usuário se deseja salvar as alterações
            Dim result As DialogResult = MessageBox.Show("Há alterações não salvas. Deseja salvar antes de sair?", "Alterações Detectadas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Chama o método Salvar
                Salvar()

                ' Verifica se o DataSet ainda tem mudanças após salvar
                If Me.PrinceDBDataSet.HasChanges() Then
                    ' Impede o fechamento se o salvamento não for bem-sucedido
                    e.Cancel = True
                End If
            ElseIf result = DialogResult.Cancel Then
                ' Cancela o fechamento do formulário
                e.Cancel = True
            End If
        End If
    End Sub

    ' Evento para o botão de salvar
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar() ' Chama o método de salvar
    End Sub




    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Verifica se o GroupBox2 está habilitado (em modo de edição)
        If GroupBox2.Enabled Then
            ' Verificar se houve alterações antes de cancelar a edição
            If Not originalData.Equals(Me.PrinceDBDataSet.Sites) Then
                ' Se houver alterações, chama o método Salvar
                Salvar()
            End If

            ' Cancelar edição e voltar para o estado original
            GroupBox2.Enabled = False
            BtnEditar.Text = "Editar"

            ' Limpa os dados e recarrega os dados originais do banco de dados
            Me.PrinceDBDataSet.Sites.Clear()
            Me.SitesTableAdapter.Fill(Me.PrinceDBDataSet.Sites)
        Else
            ' Habilitar o GroupBox2 para edição
            GroupBox2.Enabled = True
            BtnEditar.Text = "Cancelar"
        End If
    End Sub


    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                ' Remover o registro selecionado do BindingSource
                Dim row As DataRowView = CType(SitesBindingSource.Current, DataRowView)
                If row IsNot Nothing Then
                    row.Delete()
                    Me.SitesTableAdapter.Update(Me.PrinceDBDataSet.Sites)
                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close() ' Fechar o formulário
    End Sub

    Private Sub SitesDataGridView_SelectionChanged(sender As Object, e As EventArgs)
        ' Habilitar GroupBox2 ao selecionar um item
        If SitesBindingSource.Current IsNot Nothing Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False ' Desabilitar se não houver seleção
        End If
    End Sub


    Private Sub BtnAddNovamente_Click(sender As Object, e As EventArgs) Handles BtnAddNovamente.Click
        Dim frmCidades As New FrmBrasilCidadesGeral()
        frmCidades.ShowDialog(Me) ' Abre o formulário como modal

        ' Verificar se o usuário selecionou uma cidade ou distrito
        If frmCidades.CidadeSelecionada IsNot Nothing Then
            ' Preencher os campos no FrmSites com os dados selecionados
            CidadeTextBox.Text = frmCidades.CidadeSelecionada
            EstadoTextBox.Text = frmCidades.EstadoSelecionado ' Preencher o nome do estado

            ' Se houver um distrito selecionado, preencha o campo correspondente
            Dim distritoSelecionado = frmCidades.DistritoSelecionado
            If Not String.IsNullOrEmpty(distritoSelecionado) Then
                DistritoTextBox.Text = distritoSelecionado
            End If

            ' Habilitar o GroupBox2 para edição, se não estiver habilitado
            If Not GroupBox2.Enabled Then
                GroupBox2.Enabled = True
                BtnEditar.Text = "Cancelar" ' Ajustar texto do botão de edição
            End If
        End If
    End Sub






    '////////////////////////////// BOTAO ABRIR SITES
    Private Sub BtnAbrir1_Click(sender As Object, e As EventArgs) Handles BtnAbrir1.Click
        ' Verifica se o campo SiteEstadoTextBox não está vazio
        If Not String.IsNullOrEmpty(SiteEstadoTextBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(SiteEstadoTextBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAbrir2_Click(sender As Object, e As EventArgs) Handles BtnAbrir2.Click
        If Not String.IsNullOrEmpty(SiteCidadeTextBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(SiteCidadeTextBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAbrir3_Click(sender As Object, e As EventArgs) Handles BtnAbrir3.Click
        If Not String.IsNullOrEmpty(SiteJuntaUnificadaTextBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(SiteJuntaUnificadaTextBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAbrir4_Click(sender As Object, e As EventArgs) Handles BtnAbrir4.Click
        If Not String.IsNullOrEmpty(SiteJuntaAntigaTextBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(SiteJuntaAntigaTextBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAbrir5_Click(sender As Object, e As EventArgs) Handles BtnAbrir5.Click
        If Not String.IsNullOrEmpty(SiteAlvara1TextBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(SiteAlvara1TextBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAbrir6_Click(sender As Object, e As EventArgs) Handles BtnAbrir6.Click
        If Not String.IsNullOrEmpty(SiteAlvara2TextBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(SiteAlvara2TextBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    '///////////////////// FIM BOTAO

    Private Sub TextBoxBuscaGeral_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscaGeral.TextChanged
        ' Obter o texto digitado no TextBoxBuscaGeral
        Dim busca As String = TextBoxBuscaGeral.Text.Trim()


        ' Aplicar o filtro se houver texto de busca, caso contrário, limpar o filtro
        If Not String.IsNullOrEmpty(busca) Then
            ' Filtro usando Estado, Cidade ou Distrito (insensível a maiúsculas/minúsculas)
            SitesBindingSource.Filter = $"Estado LIKE '%{busca}%' OR Cidade LIKE '%{busca}%' OR Distrito LIKE '%{busca}%'"
        Else
            ' Se não houver texto, remover o filtro
            SitesBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub BtnCidades_Click(sender As Object, e As EventArgs) Handles BtnCidades.Click
        Dim frmCidades As New FrmBrasilCidadesGeral()
        frmCidades.ShowDialog(Me) ' Abre o formulário como modal
    End Sub


    Private estadosSiglas As New Dictionary(Of String, String) From {
    {"Acre", "AC"},
    {"Alagoas", "AL"},
    {"Amazonas", "AM"},
    {"Bahia", "BA"},
    {"Ceará", "CE"},
    {"Distrito Federal", "DF"},
    {"Espírito Santo", "ES"},
    {"Goiás", "GO"},
    {"Maranhão", "MA"},
    {"Mato Grosso", "MT"},
    {"Mato Grosso do Sul", "MS"},
    {"Minas Gerais", "MG"},
    {"Pará", "PA"},
    {"Paraíba", "PB"},
    {"Paraná", "PR"},
    {"Pernambuco", "PE"},
    {"Piauí", "PI"},
    {"Rio de Janeiro", "RJ"},
    {"Rio Grande do Norte", "RN"},
    {"Rio Grande do Sul", "RS"},
    {"Rondônia", "RO"},
    {"Roraima", "RR"},
    {"Santa Catarina", "SC"},
    {"São Paulo", "SP"},
    {"Sergipe", "SE"},
    {"Tocantins", "TO"}
}


    Private Sub EstadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EstadoTextBox.TextChanged
        Dim estadoNome As String = EstadoTextBox.Text.Trim()
        If estadosSiglas.ContainsKey(estadoNome) Then
            EstadoSiglaTextBox.Text = estadosSiglas(estadoNome)
        Else
            EstadoSiglaTextBox.Text = String.Empty ' Limpa o campo se o estado não for encontrado
        End If
    End Sub

End Class