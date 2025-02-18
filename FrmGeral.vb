Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmGeral
    Private allEmpresas As DataTable
    Private toolTip As ToolTip



    ' Permite que o formulário feche quando a tecla ESC é pressionada
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub New()
        InitializeComponent()
        ' toolTip = New ToolTip()
    End Sub

    Private Async Sub FrmGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostra o Label e a ProgressBar
        TextBoxBusca.Enabled = False
        LabelCarregando.Visible = True
        LabelCarregando.Text = "Carregando empresas..."
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0

        ' Inicia a animação da ProgressBar (0% a 50%)
        Await AnimarProgressBar()

        ' Chama SetupListView para configurar as colunas
        SetupListView()

        ' Carrega as empresas de forma assíncrona
        Await LoadEmpresasAsync()

        ' Exibe a mensagem de conclusão
        LabelCarregando.Text = "Carregamento concluído!"
        Await Task.Delay(1000) ' Exibe a mensagem por 1 segundo

        ' Oculta o Label e a ProgressBar após a conclusão
        LabelCarregando.Text = "Empresas"
        ProgressBar1.Visible = False
        TextBoxBusca.Enabled = True
    End Sub

    Private Async Function AnimarProgressBar() As Task
        ' Animação da ProgressBar de 0% a 50% (antes do carregamento dos dados)
        For i As Integer = 0 To 50 Step 10
            ProgressBar1.Value = i
            Await Task.Delay(100) ' Atraso de 100ms para cada incremento
        Next
    End Function



    Private Sub SetupListView()
        ' Configurar as colunas do ListView
        ListViewGeral.View = View.Details
        ListViewGeral.Columns.Add("Matriz/Filial", 70, HorizontalAlignment.Left)
        ListViewGeral.Columns.Add("Razão Social", 300, HorizontalAlignment.Left)
        ListViewGeral.Columns.Add("CNPJ", 160, HorizontalAlignment.Left) ' Certifique-se que esta linha existe e que o tamanho é adequado

        ' Habilitar desenho personalizado
        ListViewGeral.OwnerDraw = True

        ListViewGeral.FullRowSelect = True

        ' Aumentar a fonte do ListView
        Dim newFont As New Font("Arial", 12, FontStyle.Regular)
        ListViewGeral.Font = newFont
    End Sub


    Private Sub ListViewGeral_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListViewGeral.DrawColumnHeader
        ' Configurar a cor do título
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim headerBrush As New SolidBrush(Color.White) ' Cor do texto
        Dim backgroundBrush As New SolidBrush(Color.Blue) ' Cor de fundo

        ' Preencher o fundo da coluna
        e.Graphics.FillRectangle(backgroundBrush, e.Bounds)

        ' Desenhar o texto do título da coluna
        e.Graphics.DrawString(e.Header.Text, headerFont, headerBrush, e.Bounds)

        ' Manter o estilo padrão para bordas e outros detalhes
        e.DrawDefault = True
    End Sub



    Private Sub ListViewGeral_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListViewGeral.DrawSubItem
        ' Desenhar os subitens normalmente
        e.DrawDefault = True
    End Sub


    Private Async Function LoadEmpresasAsync() As Task
        ProgressBar1.Value = 20
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "
    WITH CombinedCompanies AS (
        SELECT 'Empresa' AS SourceTable, SEDE AS TipoOriginal, RazaoSocial, CNPJ FROM Empresas WHERE CNPJ IS NOT NULL OR RazaoSocial IS NOT NULL
        UNION ALL
        SELECT 'Laudo' AS SourceTable, Matriz AS TipoOriginal, RazaoSocial, CNPJ FROM Laudos WHERE CNPJ IS NOT NULL OR RazaoSocial IS NOT NULL
        UNION ALL
        SELECT 'Parcelamento' AS SourceTable, NULL AS TipoOriginal, RazaoSocial, CNPJ FROM Parcelamentos WHERE CNPJ IS NOT NULL OR RazaoSocial IS NOT NULL
    )
    SELECT 
        CASE WHEN COUNT(DISTINCT SourceTable) > 1 THEN 'Matriz' ELSE COALESCE(MAX(TipoOriginal), 'Matriz') END AS Tipo,
        MAX(TipoOriginal) AS TipoOriginal,
        RazaoSocial,
        CNPJ,
        STRING_AGG(SourceTable, ',') AS SourceTables
    FROM CombinedCompanies
    GROUP BY RazaoSocial, CNPJ
    HAVING COUNT(*) > 0
    ORDER BY RazaoSocial, CNPJ"

        allEmpresas = New DataTable()

        Try
            ProgressBar1.Value = 30
            Using connection As New SqlConnection(connectionString),
              command As New SqlCommand(query, connection),
              adapter As New SqlDataAdapter(command)

                ' Executa a operação de preenchimento do DataTable de forma assíncrona
                Await Task.Run(Function() adapter.Fill(allEmpresas))
            End Using

            ProgressBar1.Value = 40
            ' Atualiza a interface do usuário na thread principal
            ListViewGeral.Invoke(Sub()
                                     ListViewGeral.Items.Clear()

                                     ' Define as colunas do ListView
                                     '  ListViewGeral.Columns.Clear()
                                     'ListViewGeral.Columns.Add("Tipo", 100)
                                     '  ListViewGeral.Columns.Add("Razão Social", 300)
                                     ' ListViewGeral.Columns.Add("CNPJ", 150)

                                     ' Atualiza a ProgressBar para 50% após o carregamento do DataTable
                                     ProgressBar1.Value = 50

                                     ' Adiciona os itens ao ListView
                                     For Each row As DataRow In allEmpresas.Rows
                                         Dim tipo As String = If(row("TipoOriginal") Is DBNull.Value, "Matriz", row("TipoOriginal").ToString())
                                         Dim razaoSocial As String = If(row("RazaoSocial") Is DBNull.Value, "Sem Razão Social", row("RazaoSocial").ToString())
                                         Dim cnpj As String = If(row("CNPJ") Is DBNull.Value, "Sem CNPJ", row("CNPJ").ToString())
                                         Dim sourceTables As String = row("SourceTables").ToString()

                                         Dim listItem As New ListViewItem(tipo)
                                         listItem.SubItems.Add(razaoSocial)
                                         ProgressBar1.Value = 70
                                         listItem.SubItems.Add(cnpj)
                                         ProgressBar1.Value = 80
                                         ' Guardar informações adicionais no Tag usando Tuple
                                         listItem.Tag = Tuple.Create(cnpj, sourceTables, tipo)
                                         ProgressBar1.Value = 90
                                         ' Adicionar o item ao ListView
                                         ListViewGeral.Items.Add(listItem)
                                     Next

                                     ' Atualiza a ProgressBar para 100% após o processamento
                                     ProgressBar1.Value = 100

                                     Label2.Text = $"Total: {ListViewGeral.Items.Count} empresas"
                                 End Sub)

        Catch ex As Exception
            MessageBox.Show($"Erro ao carregar empresas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            allEmpresas.Clear()
        End Try
    End Function




    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Limpar o ListView antes de exibir os resultados
        ListViewGeral.Items.Clear()

        If String.IsNullOrEmpty(termoBusca) Then
            ' Se não há termo de busca, exibe todas as empresas
            For Each row As DataRow In allEmpresas.Rows
                AdicionarItemListView(row)
            Next
        Else
            ' Divide o termo de busca em palavras e normaliza para facilitar a busca
            Dim termosBusca As String() = termoBusca.Split({" "c}, StringSplitOptions.RemoveEmptyEntries).
                                               Select(Function(t) RemoverSimbolos(RemoverAcentos(t.ToLower()))).
                                               ToArray()

            ' Filtra os resultados antes de adicionar ao ListView
            For Each row As DataRow In allEmpresas.Rows
                Dim razaoSocial As String = If(row("RazaoSocial") IsNot DBNull.Value, row("RazaoSocial").ToString(), "Sem Razão Social")
                Dim cnpj As String = If(row("CNPJ") IsNot DBNull.Value, row("CNPJ").ToString(), "Sem CNPJ")

                ' Normaliza os dados para comparação
                Dim razaoSocialNormalized As String = RemoverSimbolos(RemoverAcentos(razaoSocial.ToLower()))
                Dim cnpjNormalized As String = RemoverSimbolos(cnpj)

                ' Verifica se todos os termos de busca estão na razão social ou no CNPJ
                Dim encontrou As Boolean = termosBusca.All(Function(termo) razaoSocialNormalized.Contains(termo) OrElse cnpjNormalized.Contains(termo))

                If encontrou Then
                    AdicionarItemListView(row)
                End If
            Next
        End If

        ' Atualizar o Label com o total de empresas filtradas
        Label2.Text = $"Total: {ListViewGeral.Items.Count} empresas"
    End Sub
    Private Sub AdicionarItemListView(row As DataRow)
        Dim tipo As String = If(row("TipoOriginal") IsNot DBNull.Value, row("TipoOriginal").ToString(), "Matriz")
        Dim razaoSocial As String = If(row("RazaoSocial") IsNot DBNull.Value, row("RazaoSocial").ToString(), "Sem Razão Social")
        Dim cnpj As String = If(row("CNPJ") IsNot DBNull.Value, row("CNPJ").ToString(), "Sem CNPJ")
        Dim sourceTables As String = row("SourceTables").ToString()

        ' Criar o ListViewItem
        Dim listItem As New ListViewItem(tipo)
        listItem.SubItems.Add(razaoSocial)
        listItem.SubItems.Add(cnpj)

        ' Usando Tuple para armazenar os dados no Tag
        listItem.Tag = Tuple.Create(cnpj, sourceTables, tipo)

        ' Adicionar ao ListView
        ListViewGeral.Items.Add(listItem)
    End Sub




    '//////////////////////////////// TEXT BOX BUSCA
    Private Async Sub BackupTextbox()
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Se a caixa de busca estiver vazia, recarregar todas as empresas
        If String.IsNullOrEmpty(termoBusca) Then
            Await LoadEmpresasAsync()
        Else
            ' Caso contrário, filtrar empresas com base no termo de busca
            BuscarEmpresas(termoBusca)
        End If

        ' Ordenar os itens no ListView em ordem alfabética (ascendente)
        ListViewGeral.Sorting = SortOrder.Ascending
        ListViewGeral.Sort()

        ' Atualizar o Label com o total de empresas filtradas
        Label2.Text = "Total: " & ListViewGeral.Items.Count.ToString() & " empresas"
    End Sub

    Private Sub BuscarEmpresas(ByVal termoBusca As String)
        ' Verifica se a lista de empresas está carregada
        If allEmpresas Is Nothing OrElse allEmpresas.Rows.Count = 0 Then
            MessageBox.Show("Nenhuma empresa carregada. Por favor, carregue as empresas primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Normaliza o termo de busca (remove acentos e símbolos)
        termoBusca = RemoverAcentos(termoBusca.ToLower())
        termoBusca = RemoverSimbolos(termoBusca)

        ' Limpar o ListView antes de exibir os resultados filtrados
        ListViewGeral.Items.Clear()

        ' Adicionar os resultados filtrados ao ListView
        For Each row As DataRow In allEmpresas.Rows
            Dim tipo As String = If(row("TipoOriginal") IsNot DBNull.Value, row("TipoOriginal").ToString(), "Matriz")
            Dim razaoSocial As String = If(row("RazaoSocial") IsNot DBNull.Value, row("RazaoSocial").ToString(), "Sem Razão Social")
            Dim cnpj As String = If(row("CNPJ") IsNot DBNull.Value, row("CNPJ").ToString(), "Sem CNPJ")
            Dim sourceTables As String = row("SourceTables").ToString()

            ' Normaliza os campos para facilitar a busca
            Dim razaoSocialNormalized As String = RemoverAcentos(razaoSocial.ToLower())
            Dim cnpjNormalized As String = RemoverSimbolos(cnpj)

            ' Verifica se o termo de busca está presente na razão social ou no CNPJ
            If razaoSocialNormalized.Contains(termoBusca) OrElse cnpjNormalized.Contains(termoBusca) Then
                ' Criar o ListViewItem com o tipo (SEDE/Matriz)
                Dim listItem As New ListViewItem(tipo)
                ' Adicionar a Razão Social como subitem
                listItem.SubItems.Add(razaoSocial)
                ' Adicionar o CNPJ como subitem
                listItem.SubItems.Add(cnpj)
                ' Guardar informações adicionais no Tag usando Tuple
                listItem.Tag = Tuple.Create(cnpj, sourceTables, tipo)

                ' Adicionar o item ao ListView
                ListViewGeral.Items.Add(listItem)
            End If
        Next

        ' Atualizar o Label com o total de empresas encontradas
        Label2.Text = $"Total: {ListViewGeral.Items.Count} empresas"
    End Sub



    '///////////////////////////////////////     Function //////////////////////////////

    ' Função para remover acentos
    Private Function RemoverAcentos(input As String) As String
        Dim normalizedString As String = input.Normalize(System.Text.NormalizationForm.FormD)
        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In normalizedString
            If Globalization.CharUnicodeInfo.GetUnicodeCategory(c) <> Globalization.UnicodeCategory.NonSpacingMark Then
                sb.Append(c)
            End If
        Next
        Return sb.ToString()
    End Function

    ' Função para remover símbolos (como pontuações, traços, etc.)
    Private Function RemoverSimbolos(input As String) As String
        Return New String(input.Where(Function(c) Char.IsLetterOrDigit(c) OrElse Char.IsWhiteSpace(c)).ToArray())
    End Function



    '///////////////////////////////////////  FIM   Function //////////////////////////////



    ' O código do evento MouseMove atualizado
    ' Declare a variável ToolTip no início do seu formulário
    Private Sub ListViewGeral_MouseMove(sender As Object, e As MouseEventArgs) Handles ListViewGeral.MouseMove
        ' Obtém o item sob o cursor do mouse
        Dim item As ListViewItem = ListViewGeral.GetItemAt(e.X, e.Y)

        ' Verifica se o item é válido e se tem subitens suficientes
        If item IsNot Nothing AndAlso item.SubItems.Count > 1 Then
            ' Obtém o texto da subitem na coluna de Razão Social (índice 1)
            Dim text As String = item.SubItems(1).Text
            ' Configura o tooltip para o texto completo usando ToolTip1
            ToolTip1.SetToolTip(ListViewGeral, text)
        Else
            ' Remove o tooltip se não houver item válido
            ToolTip1.SetToolTip(ListViewGeral, String.Empty)
        End If
    End Sub




    Private Sub ListViewGeral_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewGeral.MouseDoubleClick
        If ListViewGeral.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewGeral.SelectedItems(0)

            ' Definir valores padrão como vazio
            Dim cnpj As String = ""
            Dim razaoSocial As String = ""

            ' Verificar se existem pelo menos 3 colunas
            If selectedItem.SubItems.Count > 2 Then
                ' Pegar CNPJ se disponível
                If Not String.IsNullOrEmpty(selectedItem.SubItems(2).Text) AndAlso selectedItem.SubItems(2).Text <> "Sem CNPJ" Then
                    cnpj = selectedItem.SubItems(2).Text
                End If
            End If

            ' Pegar Razão Social se disponível
            If selectedItem.SubItems.Count > 1 Then
                If Not String.IsNullOrEmpty(selectedItem.SubItems(1).Text) Then
                    razaoSocial = selectedItem.SubItems(1).Text
                End If
            End If

            ' Se não houver CNPJ válido, usar Razão Social no lugar
            If String.IsNullOrEmpty(cnpj) AndAlso Not String.IsNullOrEmpty(razaoSocial) Then
                cnpj = "" ' Mantém o CNPJ vazio
            End If

            ' Capturar outras colunas se existirem
            Dim sourceTables As String = If(selectedItem.SubItems.Count > 3, selectedItem.SubItems(3).Text, "")
            Dim tipoOriginal As String = If(selectedItem.SubItems.Count > 4, selectedItem.SubItems(4).Text, "")

            ' Fechar formulário existente se já estiver aberto
            Dim existingForm As FrmEscolha = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmEscolha Then
                    existingForm = CType(openForm, FrmEscolha)
                    Exit For
                End If
            Next

            existingForm?.Close()

            ' Criar e exibir um novo FrmEscolha
            Dim frmEscolha As New FrmEscolha(cnpj, razaoSocial, sourceTables, tipoOriginal) With {
            .MdiParent = Me.MdiParent
        }
            frmEscolha.Show()
        Else
            MessageBox.Show("Nenhum item selecionado.")
        End If
    End Sub






    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        FrmAtalhoBuscadores.MdiParent = Me.MdiParent ' Definindo o formulário MDI pai
        FrmAtalhoBuscadores.Show()
    End Sub

    Private Async Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        ' Verifica se a TextBox de busca contém texto
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Se houver texto na TextBox, faz a busca e atualiza o ListViewrazaoSocialNormalized.Contains
        If Not String.IsNullOrEmpty(termoBusca) Then
            ' Atualiza a busca com base no termo atual
            BuscarEmpresas(termoBusca)
        Else
            ' Se a TextBox estiver vazia, recarrega todas as empresas de forma assíncrona
            Await LoadEmpresasAsync()
        End If

        ' Mensagem opcional para confirmar que a atualização foi feita
        MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub ListViewGeral_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListViewGeral.ColumnClick
        ' Ordena os itens de acordo com a coluna clicada
        If e.Column = ListViewGeral.Sorting Then
            ListViewGeral.Sorting = If(ListViewGeral.Sorting = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        Else
            ListViewGeral.Sorting = SortOrder.Ascending
        End If
        ListViewGeral.Sort()
    End Sub

    Private Sub ListViewGeral_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListViewGeral.DrawItem

        ' Desenhar os itens normalmente
        e.DrawDefault = True

        If e.Item.Selected Then
            ' Desenhar fundo da linha selecionada
            e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds)
        Else
            ' Desenhar fundo da linha não selecionada
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        End If

        ' Desenha o item normalmente
        e.DrawDefault = True
    End Sub




End Class