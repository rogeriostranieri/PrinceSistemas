Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FrmSites
    Private originalData As DataTable
    Private dadosAlterados As Boolean = False ' Variável para detectar alterações
    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

    ' Substitui o método ProcessCmdKey para capturar a tecla ESC
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Verifica se a tecla pressionada é ESC
        If keyData = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
            ' Retorna true para indicar que a tecla foi processada
            Return True
        End If
        ' Chama o método base para qualquer outra tecla
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


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

    Private Sub AbrirLink(textBox As TextBox)
        If Not String.IsNullOrEmpty(textBox.Text) Then
            Try
                ' Abre o link no navegador padrão
                Process.Start(textBox.Text)
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Não foi possível abrir o link. Verifique se o URL está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Informa o usuário que o campo está vazio
            MessageBox.Show("O campo do link está vazio. Insira um URL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


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
        AbrirLink(SiteEstadoTextBox)
    End Sub

    Private Sub BtnAbrir2_Click(sender As Object, e As EventArgs) Handles BtnAbrir2.Click
        AbrirLink(SiteCidadeTextBox)
    End Sub

    Private Sub BtnAbrir3_Click(sender As Object, e As EventArgs) Handles BtnAbrir3.Click
        AbrirLink(SiteJuntaUnificadaTextBox)
    End Sub

    Private Sub BtnAbrir4_Click(sender As Object, e As EventArgs) Handles BtnAbrir4.Click
        AbrirLink(SiteJuntaAntigaTextBox)
    End Sub

    Private Sub BtnAbrir5_Click(sender As Object, e As EventArgs) Handles BtnAbrir5.Click
        AbrirLink(SiteAlvara1TextBox)
    End Sub

    Private Sub BtnAbrir6_Click(sender As Object, e As EventArgs) Handles BtnAbrir6.Click
        AbrirLink(SiteAlvara2TextBox)
    End Sub

    Private Sub BtnAlvaraPedido1_Click(sender As Object, e As EventArgs) Handles BtnAlvaraPedido1.Click
        'SiteAlvaraPedido1TextBox
        AbrirLink(SiteAlvaraPedido1TextBox)

    End Sub

    Private Sub BtnAlvaraPedido2_Click(sender As Object, e As EventArgs) Handles BtnAlvaraPedido2.Click
        'SiteAlvaraPedido2TextBox
        AbrirLink(SiteAlvaraPedido2TextBox)

    End Sub

    Private Sub BtnPrefProtocolo_Click(sender As Object, e As EventArgs) Handles BtnPrefProtocolo.Click
        'SitePrefProtocoloTextBox
        AbrirLink(SitePrefProtocoloTextBox)
    End Sub

    Private Sub BtnSiteREDESIMProtocolo_Click(sender As Object, e As EventArgs)
        AbrirLink(SiteREDESIMProtocoloTextBox)
    End Sub

    Private Sub BtnSiteREDESIMConsultaCNPJ_Click(sender As Object, e As EventArgs)
        AbrirLink(SiteREDESIMConsultaCNPJTextBox)
    End Sub

    Private Sub BtnSiteREDESIMAbrirCNPJ_Click(sender As Object, e As EventArgs)
        AbrirLink(SiteREDESIMAbrirCNPJTextBox)
    End Sub

    Private Sub BtnSiteREDESIMMeuCNPJ_Click(sender As Object, e As EventArgs)
        AbrirLink(SiteREDESIMMeuCNPJTextBox)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        SiteREDESIMProtocoloTextBox.Text = "https://servicos.receita.fazenda.gov.br/Servicos/fcpj/consulta.asp?Cod=&Ident=&prot="
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        SiteREDESIMConsultaCNPJTextBox.Text = "https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp"
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        SiteREDESIMAbrirCNPJTextBox.Text = "https://www.gov.br/empresas-e-negocios/pt-br/redesim/abrir-cnpj"
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        SiteREDESIMMeuCNPJTextBox.Text = "https://www.gov.br/empresas-e-negocios/pt-br/redesim/meu-cnpj"
    End Sub

    Private Sub BtnBombeiroSolicita_Click(sender As Object, e As EventArgs) Handles BtnBombeiroSolicita.Click
        AbrirLink(BombeiroSolicitaTextBox)

    End Sub

    Private Sub BtnBombeiroConsulta_Click(sender As Object, e As EventArgs) Handles BtnBombeiroConsulta.Click
        AbrirLink(BombeiroConsultaTextBox)

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        BombeiroSolicitaTextBox.Text = "https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Solicitacao-de-Vistoria"

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        BombeiroConsultaTextBox.Text = "https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Acompanhar-Processo"

    End Sub

    Private Sub BtnBombeiroUnificado_Click(sender As Object, e As EventArgs) Handles BtnBombeiroUnificado.Click
        AbrirLink(BombeiroUnificadoTextBox)

    End Sub

    Private Sub BtnBombeiroREDESIM_Click(sender As Object, e As EventArgs) Handles BtnBombeiroREDESIM.Click
        AbrirLink(BombeiroREDESIMTextBox)

    End Sub

    '///////////////////// FIM BOTAO


End Class