Imports System.Data.SqlClient
Imports System.Text



Public Class FrmGeralParcelamento

    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"


    Public Property RazaoSocial As String
    Public Property CNPJ As String
    Public Property DataCriacao As String



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmGeralParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar os dados ao carregar o formulário
        CarregarDados()
        ' Adiciona todos os meses por extenso ao ComboBoxMesFechamento
        ComboBoxMesFechamento.Items.AddRange(New String() {
        "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
        "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
    })
        ComboBoxMesFechamento.SelectedIndex = -1 ' Deixar vazio inicialmente
        ConfigurarColunasListView()
        CheckBoxMesFechamento.Checked = False
        MudarMesFechamento()

        CheckBoxMesFechamento.Checked = False
        CheckBoxEmAndamento.Checked = False
        CheckBoxFinalizada.Checked = False
        CheckBoxTodos.Checked = True
        CheckBoxMEI.Checked = False
        CheckBoxINSSAntigo.Checked = False
        CheckBoxINSSNovo.Checked = False
        CheckBoxINSSProcuradoria.Checked = False
    End Sub
    Private Sub ConfigurarColunasListView()
        ' Configurar o ListView para exibição em modo de detalhes (View.Details)
        ListView1.View = View.Details

        ' Permitir que o usuário reorganize as colunas
        ListView1.AllowColumnReorder = True

        ' Limpar as colunas antes de adicionar novas (caso necessário)
        ListView1.Columns.Clear()

        ' Adicionar colunas ao ListView
        ListView1.Columns.Add("Razão Social", 250)
        ListView1.Columns.Add("CNPJ", 150)
        ListView1.Columns.Add("MEI", 100)
        ListView1.Columns.Add("INSS Antigo", 100)
        ListView1.Columns.Add("INSS Novo", 100)
        ListView1.Columns.Add("INSS Procuradoria", 100)
        ListView1.Columns.Add("Finalizado", 100)
        ListView1.Columns.Add("Data-Fim", 120)

        ' Usar AddHandler para adicionar o manipulador do evento ColumnWidthChanged
        AddHandler ListView1.ColumnWidthChanged, AddressOf ListView1_ColumnWidthChanged
    End Sub

    ' Método para lidar com o evento ColumnWidthChanged
    Private Sub ListView1_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs)
        ' Adicionar código aqui para reagir à mudança na largura da coluna, se necessário
    End Sub





    Private Sub CarregarDados()
        ' Configurar as colunas antes de carregar os dados
        ConfigurarColunasListView()

        ' Construir a consulta SQL com base nos filtros aplicados
        Dim query As New StringBuilder("SELECT RazaoSocial, CNPJ, FormaDeEnvio, Responsavel, Whatsapp, Email, Socio, CPF, DataCriacao, DataFinalizado, MEI, InssAntigo, InssNovo, InssProcur, FinalizadoEmpresa, FinalizadoMesGeral FROM Parcelamentos WHERE 1=1")

        ' Verificar se todos os CheckBoxes estão marcados
        Dim todosSelecionados As Boolean = CheckBoxMEI.Checked AndAlso CheckBoxINSSAntigo.Checked AndAlso CheckBoxINSSNovo.Checked AndAlso CheckBoxINSSProcuradoria.Checked

        ' Filtragem para "Finalizado" e "Em Andamento"
        If CheckBoxFinalizada.Checked Then
            ' Filtra apenas os registros onde FinalizadoEmpresa = 'Sim'
            query.Append(" AND FinalizadoEmpresa = 'Sim'")
        ElseIf CheckBoxEmAndamento.Checked Then
            ' Filtra apenas os registros onde FinalizadoEmpresa = 'Não'
            query.Append(" AND FinalizadoEmpresa = 'Não'")

            ' Quando "Em Andamento" estiver marcado, aplica os filtros para MEI, INSS Antigo, INSS Novo e INSS Procuradoria
            If CheckBoxMEI.Checked Then
                query.Append(" AND FinalizadoMEI = 'Não'")
            End If
            If CheckBoxINSSAntigo.Checked Then
                query.Append(" AND FinalizadoINSSAnt = 'Não'")
            End If
            If CheckBoxINSSNovo.Checked Then
                query.Append(" AND FinalizadoINSSNov = 'Não'")
            End If
            If CheckBoxINSSProcuradoria.Checked Then
                query.Append(" AND FinalizadoINSSProc = 'Não'")
            End If
        ElseIf CheckBoxTodos.Checked Then
            ' Quando "Todos" estiver marcado, retorna todos os registros sem filtrar FinalizadoEmpresa
            ' Não faz filtragem específica
        End If

        ' Filtro extra de mês de fechamento (somente para "Em Andamento")
        If CheckBoxEmAndamento.Checked Then
            If ComboBoxMesFechamento.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(ComboBoxMesFechamento.SelectedItem.ToString()) Then
                ' Obter o mês selecionado
                Dim mesSelecionado As String = ComboBoxMesFechamento.SelectedItem.ToString()

                ' Filtra pela coluna FinalizadoMesGeral (mês por extenso)
                query.Append(" AND FinalizadoMesGeral = '" & mesSelecionado & "'")
            End If
        End If

        ' Executar a consulta SQL com o filtro aplicado
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query.ToString(), connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            connection.Open()
            adapter.Fill(dataTable)

            ' Limpar itens anteriores no ListView
            ListView1.Items.Clear()

            ' Preencher o ListView com os dados da consulta
            For Each row As DataRow In dataTable.Rows
                Dim item As New ListViewItem(row("RazaoSocial").ToString())
                item.SubItems.Add(row("CNPJ").ToString())
                item.SubItems.Add(If(IsDBNull(row("MEI")), String.Empty, row("MEI").ToString()))
                item.SubItems.Add(If(IsDBNull(row("InssAntigo")), String.Empty, row("InssAntigo").ToString()))
                item.SubItems.Add(If(IsDBNull(row("InssNovo")), String.Empty, row("InssNovo").ToString()))
                item.SubItems.Add(If(IsDBNull(row("InssProcur")), String.Empty, row("InssProcur").ToString()))
                item.SubItems.Add(If(IsDBNull(row("FinalizadoEmpresa")), String.Empty, row("FinalizadoEmpresa").ToString()))
                item.SubItems.Add(If(IsDBNull(row("DataFinalizado")), String.Empty, CDate(row("DataFinalizado")).ToString("dd/MM/yyyy")))

                ' Adicionar o item ao ListView
                ListView1.Items.Add(item)


            Next

            ' Atualizar o Label com o total de empresas no ListView
            Label2.Text = "Total de Empresas: " & ListView1.Items.Count.ToString()

            ' Após preencher o ListView com os dados, altere os valores de "Checked" e "Unchecked" nas colunas 2, 3, 4, 5, 6 e 7
            For Each item As ListViewItem In ListView1.Items
                ' Verificar e alterar o texto para "Sim" ou "Não" conforme o valor do texto nas colunas 2, 3, 4, 5, 6, e 7
                If item.SubItems(2).Text = "Checked" Then
                    item.SubItems(2).Text = "Sim"
                ElseIf item.SubItems(2).Text = "Unchecked" Then
                    item.SubItems(2).Text = "Não"
                End If

                If item.SubItems(3).Text = "Checked" Then
                    item.SubItems(3).Text = "Sim"
                ElseIf item.SubItems(3).Text = "Unchecked" Then
                    item.SubItems(3).Text = "Não"
                End If

                If item.SubItems(4).Text = "Checked" Then
                    item.SubItems(4).Text = "Sim"
                ElseIf item.SubItems(4).Text = "Unchecked" Then
                    item.SubItems(4).Text = "Não"
                End If

                If item.SubItems(5).Text = "Checked" Then
                    item.SubItems(5).Text = "Sim"
                ElseIf item.SubItems(5).Text = "Unchecked" Then
                    item.SubItems(5).Text = "Não"
                End If

                If item.SubItems(6).Text = "Checked" Then
                    item.SubItems(6).Text = "Sim"
                ElseIf item.SubItems(6).Text = "Unchecked" Then
                    item.SubItems(6).Text = "Não"
                End If

                If item.SubItems(7).Text = "Checked" Then
                    item.SubItems(7).Text = "Sim"
                ElseIf item.SubItems(7).Text = "Unchecked" Then
                    item.SubItems(7).Text = "Não"
                End If
            Next

        End Using
    End Sub








    ' Chamada dos filtros quando um CheckBox for alterado
    Private Sub CheckBoxEmAndamento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmAndamento.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub CheckBoxFinalizada_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFinalizada.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub CheckBoxTodos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTodos.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub CheckBoxMEI_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMEI.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub CheckBoxINSSAntigo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxINSSAntigo.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub CheckBoxINSSNovo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxINSSNovo.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub CheckBoxINSSProcuradoria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxINSSProcuradoria.CheckedChanged
        CarregarDados()
    End Sub

    Private Sub ComboBoxMesFechamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMesFechamento.SelectedIndexChanged
        CarregarDados()
    End Sub

    ' Função para remover acentos
    Private Function RemoveDiacritics(ByVal text As String) As String
        Dim stForm As String = text.Normalize(NormalizationForm.FormD)
        Dim sb As New System.Text.StringBuilder()

        For Each c As Char In stForm
            ' Verificar se o caractere não é uma marca de acento
            If Char.GetUnicodeCategory(c) <> Globalization.UnicodeCategory.NonSpacingMark Then
                sb.Append(c)
            End If
        Next

        Return sb.ToString()
    End Function

    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        ' Obter o texto digitado no TextBox e remover acentos
        Dim busca As String = TextBoxBusca.Text.ToLower()
        busca = RemoveDiacritics(busca)

        ' Recarregar todos os itens antes de aplicar o filtro
        CarregarDados()

        ' Caso o TextBox esteja vazio, não filtra e exibe todos os itens
        If String.IsNullOrWhiteSpace(busca) Then
            Label2.Text = "Total de Empresas Encontradas: " & ListView1.Items.Count.ToString()
            Return
        End If

        ' Criar uma lista para armazenar os itens que não correspondem ao filtro
        Dim itensParaRemover As New List(Of ListViewItem)()

        ' Loop através de todos os itens no ListView
        Dim empresasEncontradas As Integer = 0
        For Each item As ListViewItem In ListView1.Items
            ' Obter o nome da empresa (ou outro campo que você usa no ListView)
            Dim razaoSocial As String = item.SubItems(0).Text.ToLower()
            razaoSocial = RemoveDiacritics(razaoSocial)

            ' Verificar se o nome da empresa contém o texto da busca
            If razaoSocial.Contains(busca) Then
                empresasEncontradas += 1
            Else
                ' Adiciona o item à lista de itens a remover
                itensParaRemover.Add(item)
            End If
        Next

        ' Remover os itens que não correspondem ao filtro
        For Each item As ListViewItem In itensParaRemover
            ListView1.Items.Remove(item)
        Next

        ' Atualizar o Label2 com o número de empresas encontradas
        Label2.Text = "Total de Empresas Encontradas: " & empresasEncontradas.ToString()
    End Sub



    Private Sub CheckBoxMesFechamento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMesFechamento.CheckedChanged
        ' Chama a função para alterar a visibilidade do ComboBox e label
        MudarMesFechamento()
    End Sub

    Private Sub MudarMesFechamento()
        If CheckBoxMesFechamento.Checked Then
            ' Mostrar os controles se estiver marcado
            LabelEscolhaMes.Visible = True
            ComboBoxMesFechamento.Visible = True
            ' Definir o mês atual no ComboBox (mes por extenso)
            Dim mesAtual As String = DateTime.Now.ToString("MMMM", New Globalization.CultureInfo("pt-BR"))
            ComboBoxMesFechamento.SelectedItem = mesAtual
        Else
            ' Ocultar os controles se estiver desmarcado
            LabelEscolhaMes.Visible = False
            ComboBoxMesFechamento.Visible = False
            ComboBoxMesFechamento.Text = ""
        End If
        ' Recarregar os dados após a alteração
        CarregarDados()
    End Sub

    Private Sub PictureBoxFECHAR_Click(sender As Object, e As EventArgs) Handles PictureBoxFECHAR.Click
        Me.Close()
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        ' Verificar se há um item selecionado no ListView
        If ListView1.SelectedItems.Count > 0 Then
            ' Obter o item selecionado
            Dim itemSelecionado As ListViewItem = ListView1.SelectedItems(0)

            ' Extrair informações do item selecionado
            Dim razaoSocial As String = itemSelecionado.SubItems(0).Text
            ' Dim cnpj As String = itemSelecionado.SubItems(1).Text
            ' Dim dataCriacao As String = itemSelecionado.SubItems(8).Text ' Ajuste o índice conforme necessário

            ' Abrir o formulário FrmParcelamento e passar os dados
            ' Dim frmParcelamento As New FrmParcelamento()
            FrmParcelamento.Show()
            ' Passar a RazaoSocial para o ComboBox, verificando se já existe
            ' If frmParcelamento.ComboBoxBuscarRazaoSocial.Items.Contains(razaoSocial) Then
            FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = razaoSocial
            'End If
            'frmParcelamento.CNPJ = cnpj
            'frmParcelamento.DataCriacao = dataCriacao

            ' Exibir o formulário
            ' frmParcelamento.ShowDialog()
            FrmParcelamento.Focus()
            FrmParcelamento.ComboBoxBuscarRazaoSocial.Focus()

        End If
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        ConfigurarColunasListView()
        CheckBoxMesFechamento.Checked = False
        CheckBoxEmAndamento.Checked = False
        CheckBoxFinalizada.Checked = False
        CheckBoxTodos.Checked = True
        CheckBoxMEI.Checked = False
        CheckBoxINSSAntigo.Checked = False
        CheckBoxINSSNovo.Checked = False
        CheckBoxINSSProcuradoria.Checked = False
        MudarMesFechamento()
        CarregarDados()
    End Sub
End Class
