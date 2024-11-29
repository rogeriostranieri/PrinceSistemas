Imports System.Text
Imports System.Data.SqlClient
Imports System.Drawing
Imports Microsoft.Web.WebView2


Public Class FrmGeralParcelamento
    Private allParcelamentos As DataTable
    Private toolTip As ToolTip
    ' Declarar uma variável para controlar a ordenação
    Private listViewColumnSorter As ListViewColumnSorter

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
        toolTip = New ToolTip()
        SetupListView()
        LoadParcelamentos()
        ' Configurar o ListView para suportar ordenação
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.OwnerDraw = True

        ' Inicializar o ListViewColumnSorter e atribuí-lo ao ListView
        listViewColumnSorter = New ListViewColumnSorter()
        ListView1.ListViewItemSorter = listViewColumnSorter

        ' Configurar CheckBoxes
        CheckBoxTodos.Checked = True
        CheckBoxEmAndamento.Checked = False
        CheckBoxFinalizada.Checked = False

        ' Configurar os eventos
        AddHandler CheckBoxTodos.CheckedChanged, AddressOf CheckBox_CheckedChanged
        AddHandler CheckBoxEmAndamento.CheckedChanged, AddressOf CheckBox_CheckedChanged
        AddHandler CheckBoxFinalizada.CheckedChanged, AddressOf CheckBox_CheckedChanged
        AddHandler CheckBoxMEI.CheckedChanged, AddressOf CheckBoxFiltrar_CheckedChanged
        AddHandler CheckBoxINSSAntigo.CheckedChanged, AddressOf CheckBoxFiltrar_CheckedChanged
        AddHandler CheckBoxINSSNovo.CheckedChanged, AddressOf CheckBoxFiltrar_CheckedChanged
        AddHandler CheckBoxINSSProcuradoria.CheckedChanged, AddressOf CheckBoxFiltrar_CheckedChanged



        ' Configurar ListView e carregar dados
        SetupListView()

        ' Inicializa os meses por extenso no ComboBoxMesFechamento
        Dim meses As String() = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"}
        ComboBoxMesFechamento.DataSource = meses

        ' Seleciona o mês atual
        Dim mesAtual As String = meses(DateTime.Now.Month - 1)
        ComboBoxMesFechamento.SelectedItem = mesAtual

        ' Atualiza o filtro ao carregar


    End Sub
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        ' Verificar se a coluna clicada já está sendo usada para ordenar
        If e.Column = listViewColumnSorter.SortColumn Then
            ' Alternar a ordem de classificação (ascendente/descendente)
            If listViewColumnSorter.Order = SortOrder.Ascending Then
                listViewColumnSorter.Order = SortOrder.Descending
            Else
                listViewColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Configurar nova coluna para ordenar e definir a ordem como ascendente
            listViewColumnSorter.SortColumn = e.Column
            listViewColumnSorter.Order = SortOrder.Ascending
        End If

        ' Realizar a ordenação
        ListView1.Sort()
    End Sub



    Private Sub SetupListView()
        ' Evitar a duplicação de colunas
        If ListView1.Columns.Count = 0 Then
            ListView1.View = View.Details
            ListView1.Columns.Add("Razão Social", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("MEI", 80, HorizontalAlignment.Left)
            ListView1.Columns.Add("INSS Antigo", 100, HorizontalAlignment.Left)
            ListView1.Columns.Add("INSS Novo", 100, HorizontalAlignment.Left)
            ListView1.Columns.Add("INSS Procuradoria", 120, HorizontalAlignment.Left)

            ' Habilitar desenho personalizado
            ListView1.OwnerDraw = True
            ListView1.FullRowSelect = True

            ' Aumentar a fonte do ListView
            Dim newFont As New Font("Arial", 12, FontStyle.Regular)
            ListView1.Font = newFont
        End If
    End Sub



    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
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

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        ' Alternar cores das colunas
        Dim columnIndex As Integer = e.ColumnIndex

        ' Escolher a cor de fundo baseada no índice da coluna
        Dim backColor As Brush = If(columnIndex Mod 2 = 0, Brushes.White, Brushes.LightGray)

        ' Preencher o fundo da célula
        e.Graphics.FillRectangle(backColor, e.Bounds)

        ' Desenhar o texto do subitem
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, ListView1.Font, e.Bounds, Color.Black, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    Private Sub LoadParcelamentos()
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT RazaoSocial, MEI, InssAntigo, InssNovo, InssProcur FROM Parcelamentos"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            allParcelamentos = New DataTable()
            adapter.Fill(allParcelamentos)

            ListView1.Items.Clear()

            ' Adicionar as linhas ao ListView
            For Each row As DataRow In allParcelamentos.Rows
                Dim razaoSocial As String = If(Not String.IsNullOrEmpty(row("RazaoSocial").ToString()), row("RazaoSocial").ToString(), "Razão Social não informada")

                ' Verificar os valores de MEI, InssAntigo, InssNovo, InssProcur
                Dim mei As String = If(row("MEI") IsNot DBNull.Value, row("MEI").ToString(), "Não")
                Dim inssAntigo As String = If(row("InssAntigo") IsNot DBNull.Value, row("InssAntigo").ToString(), "Não")
                Dim inssNovo As String = If(row("InssNovo") IsNot DBNull.Value, row("InssNovo").ToString(), "Não")
                Dim inssProcur As String = If(row("InssProcur") IsNot DBNull.Value, row("InssProcur").ToString(), "Não")

                ' Verificando se o valor é "Checked" ou "Unchecked"
                mei = If(mei.ToLower() = "checked", "Sim", If(mei.ToLower() = "unchecked", "Não", "Não"))
                inssAntigo = If(inssAntigo.ToLower() = "checked", "Sim", If(inssAntigo.ToLower() = "unchecked", "Não", "Não"))
                inssNovo = If(inssNovo.ToLower() = "checked", "Sim", If(inssNovo.ToLower() = "unchecked", "Não", "Não"))
                inssProcur = If(inssProcur.ToLower() = "checked", "Sim", If(inssProcur.ToLower() = "unchecked", "Não", "Não"))

                ' Criar um item do ListView com a Razão Social e os outros valores
                Dim listItem As New ListViewItem(razaoSocial)
                listItem.SubItems.Add(mei)
                listItem.SubItems.Add(inssAntigo)
                listItem.SubItems.Add(inssNovo)
                listItem.SubItems.Add(inssProcur)

                ' Adicionar o item ao ListView
                ListView1.Items.Add(listItem)
            Next

            ' Atualizar o Label com o total de registros
            Label2.Text = "Total: " & ListView1.Items.Count.ToString() & " Parcelamentos"
        End Using
    End Sub






    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Se a caixa de busca estiver vazia, recarregar todos os registros
        If String.IsNullOrEmpty(termoBusca) Then
            LoadParcelamentos()
        Else
            ' Caso contrário, filtrar os registros com base no termo de busca
            BuscarParcelamentos(termoBusca)
        End If

        ' Atualizar o Label com o total de registros filtrados
        Label2.Text = "Total: " & ListView1.Items.Count.ToString() & " Parcelamentos"
    End Sub


    Private Sub BuscarParcelamentos(ByVal termoBusca As String)
        termoBusca = RemoverAcentos(termoBusca.ToLower())
        Dim resultados As DataRow() = allParcelamentos.Select()

        ListView1.Items.Clear()

        ' Adicionar os resultados filtrados ao ListView
        For Each row As DataRow In resultados
            Dim razaoSocial As String = RemoverAcentos(row("RazaoSocial").ToString().ToLower())

            If razaoSocial.Contains(termoBusca) Then
                Dim mei As String = If(Convert.ToBoolean(row("MEI")), "Sim", "Não")
                Dim inssAntigo As String = If(Convert.ToBoolean(row("InssAntigo")), "Sim", "Não")
                Dim inssNovo As String = If(Convert.ToBoolean(row("InssNovo")), "Sim", "Não")
                Dim inssProcur As String = If(Convert.ToBoolean(row("InssProcur")), "Sim", "Não")

                Dim listItem As New ListViewItem(row("RazaoSocial").ToString())
                listItem.SubItems.Add(mei)
                listItem.SubItems.Add(inssAntigo)
                listItem.SubItems.Add(inssNovo)
                listItem.SubItems.Add(inssProcur)
                listItem.Tag = row("RazaoSocial").ToString()
                ListView1.Items.Add(listItem)
            End If
        Next
    End Sub


    Private Function RemoverAcentos(texto As String) As String
        Dim normalizedString As String = texto.Normalize(NormalizationForm.FormD)
        Dim sb As New StringBuilder()

        For Each c As Char In normalizedString
            If System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) <> System.Globalization.UnicodeCategory.NonSpacingMark Then
                sb.Append(c)
            End If
        Next

        Return sb.ToString().Normalize(NormalizationForm.FormC)
    End Function

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            ' Verificar o item selecionado
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ' Acessar os subitens do ListView
            Dim razaoSocial As String = selectedItem.Text
            Dim mei As String = selectedItem.SubItems(1).Text
            Dim inssAntigo As String = selectedItem.SubItems(2).Text
            Dim inssNovo As String = selectedItem.SubItems(3).Text
            Dim inssProcur As String = selectedItem.SubItems(4).Text

            ' Abrir o formulário FrmParcelamento
            Dim frmParcelamento As New FrmParcelamento()


            ' Mostrar o formulário
            frmParcelamento.Show()

            ' Passar os valores para o ComboBox do FrmParcelamento
            frmParcelamento.ComboBoxBuscarRazaoSocial.Text = razaoSocial
            frmParcelamento.ComboBoxBuscarRazaoSocial.Focus()
        End If
    End Sub


    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        If Not String.IsNullOrEmpty(termoBusca) Then
            BuscarParcelamentos(termoBusca)
        Else
            LoadParcelamentos()
        End If

        MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Label2.Text = $"Total: {ListView1.Items.Count} Parcelamentos"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        ' Recarregar os dados de parcelamentos com base nas opções selecionadas
        Dim filtro As String = ""

        ' Verificar se o CheckBox "Todos" foi marcado
        If CheckBoxTodos.Checked Then
            filtro = "" ' Se Todos estiver selecionado, exibe todos os parcelamentos
            CheckBoxEmAndamento.Checked = False ' Desmarcar "Em Andamento" se "Todos" for marcado
            CheckBoxFinalizada.Checked = False ' Também desmarcar "Finalizada" se "Todos" for marcado
        Else
            ' Se "Em Andamento" for marcado, desmarcar "Todos" automaticamente
            If CheckBoxEmAndamento.Checked Then
                CheckBoxTodos.Checked = False
            End If

            ' Se "Finalizada" for marcado, desmarcar "Todos" automaticamente
            If CheckBoxFinalizada.Checked Then
                CheckBoxTodos.Checked = False
            End If

            ' Aplica os filtros com base nas opções selecionadas
            If CheckBoxEmAndamento.Checked Then
                filtro &= " AND FinalizadoEmpresa = 'Não'" ' Considerando que FinalizadoEmpresa armazena o status dos parcelamentos
            End If
            If CheckBoxFinalizada.Checked Then
                filtro &= " AND FinalizadoEmpresa = 'Sim'"
            End If
        End If

        ' Obter o mês atual por extenso
        Dim mesAtual As String = MonthName(Now.Month, False) ' Retorna o mês atual por extenso

        ' Adiciona filtro para o mês selecionado no ComboBoxMesFechamento, se houver valor selecionado
        If Not String.IsNullOrEmpty(ComboBoxMesFechamento.Text) Then
            ' Exclui empresas do mês atual
            filtro &= $" AND (FinalizadoMesGeral IS NULL OR FinalizadoMesGeral <> '{mesAtual}')"
        End If

        ' Filtra os dados de parcelamentos
        FiltrarParcelamentos(filtro)
    End Sub



    Private Sub FiltrarParcelamentos(filtro As String)
        ' Atualiza a query com base no filtro
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT RazaoSocial, MEI, InssAntigo, InssNovo, InssProcur FROM Parcelamentos WHERE 1=1" & filtro

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            allParcelamentos = New DataTable()
            adapter.Fill(allParcelamentos)

            ListView1.Items.Clear()

            ' Adicionar as linhas filtradas ao ListView
            For Each row As DataRow In allParcelamentos.Rows
                Dim razaoSocial As String = If(Not String.IsNullOrEmpty(row("RazaoSocial").ToString()), row("RazaoSocial").ToString(), "Razão Social não informada")
                Dim mei As String = If(row("MEI") IsNot DBNull.Value, row("MEI").ToString(), "Não")
                Dim inssAntigo As String = If(row("InssAntigo") IsNot DBNull.Value, row("InssAntigo").ToString(), "Não")
                Dim inssNovo As String = If(row("InssNovo") IsNot DBNull.Value, row("InssNovo").ToString(), "Não")
                Dim inssProcur As String = If(row("InssProcur") IsNot DBNull.Value, row("InssProcur").ToString(), "Não")

                ' Criar item no ListView
                Dim listItem As New ListViewItem(razaoSocial)
                listItem.SubItems.Add(mei)
                listItem.SubItems.Add(inssAntigo)
                listItem.SubItems.Add(inssNovo)
                listItem.SubItems.Add(inssProcur)

                ListView1.Items.Add(listItem)
            Next

            ' Atualizar o total de registros
            Label2.Text = "Total: " & ListView1.Items.Count.ToString() & " Parcelamentos"
        End Using
    End Sub


    Private Sub CheckBoxFiltrar_CheckedChanged(sender As Object, e As EventArgs)
        ' Refiltrar os resultados ao alterar subfiltros
        If CheckBoxEmAndamento.Checked Then
            FiltrarPorEmAndamento()
        End If
    End Sub

    Private Sub FiltrarPorEmAndamento()
        ' Remover dependência da coluna FinalizadoEmpresa
        ' Aqui não estamos mais usando "FinalizadoEmpresa", apenas verificando os outros filtros.
        Dim resultados As DataRow() = allParcelamentos.Select() ' Carregar todos os parcelamentos sem considerar FinalizadoEmpresa

        ListView1.Items.Clear()

        ' Verificar quantos checkboxes estão selecionados
        Dim checkboxesSelecionados As Integer = 0

        If CheckBoxMEI.Checked Then checkboxesSelecionados += 1
        If CheckBoxINSSAntigo.Checked Then checkboxesSelecionados += 1
        If CheckBoxINSSNovo.Checked Then checkboxesSelecionados += 1
        If CheckBoxINSSProcuradoria.Checked Then checkboxesSelecionados += 1

        ' Verificar se o número de checkboxes selecionados ultrapassa o limite permitido (ex: 2)
        If checkboxesSelecionados > 2 Then
            MessageBox.Show("Você pode selecionar no máximo 2 opções.", "Limite de Seleções", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Desmarcar a última seleção para não ultrapassar o limite
            If CheckBoxINSSProcuradoria.Checked Then CheckBoxINSSProcuradoria.Checked = False
            If CheckBoxINSSNovo.Checked Then CheckBoxINSSNovo.Checked = False
            If CheckBoxINSSAntigo.Checked Then CheckBoxINSSAntigo.Checked = False
            If CheckBoxMEI.Checked Then CheckBoxMEI.Checked = False
            checkboxesSelecionados = 2 ' Limitar para 2 seleções
        End If

        For Each row As DataRow In resultados
            ' Filtrar pelos CheckBox secundários
            Dim incluir As Boolean = True
            If CheckBoxMEI.Checked Then
                incluir = incluir AndAlso Not IsDBNull(row("MEI")) AndAlso row("MEI").ToString().ToLower() = "checked"
            End If
            If CheckBoxINSSAntigo.Checked Then
                incluir = incluir AndAlso Not IsDBNull(row("InssAntigo")) AndAlso row("InssAntigo").ToString().ToLower() = "checked"
            End If
            If CheckBoxINSSNovo.Checked Then
                incluir = incluir AndAlso Not IsDBNull(row("InssNovo")) AndAlso row("InssNovo").ToString().ToLower() = "checked"
            End If
            If CheckBoxINSSProcuradoria.Checked Then
                incluir = incluir AndAlso Not IsDBNull(row("InssProcur")) AndAlso row("InssProcur").ToString().ToLower() = "checked"
            End If

            ' Adicionar apenas os itens que passaram na filtragem
            If incluir Then
                AdicionarItemListView(row)
            End If
        Next

        AtualizarContador()
    End Sub


    Private Sub FiltrarPorFinalizada()
        ' Não estamos mais usando a coluna "FinalizadoEmpresa"
        Dim resultados As DataRow() = allParcelamentos.Select() ' Carregar todos os parcelamentos

        ListView1.Items.Clear()

        For Each row As DataRow In resultados
            AdicionarItemListView(row)
        Next

        AtualizarContador()
    End Sub

    Private Sub AdicionarItemListView(row As DataRow)
        ' Adicionar linha ao ListView com as informações filtradas
        Dim razaoSocial As String = If(Not String.IsNullOrEmpty(row("RazaoSocial").ToString()), row("RazaoSocial").ToString(), "Razão Social não informada")
        Dim mei As String = If(row("MEI") IsNot DBNull.Value AndAlso row("MEI").ToString().ToLower() = "checked", "Sim", "Não")
        Dim inssAntigo As String = If(row("InssAntigo") IsNot DBNull.Value AndAlso row("InssAntigo").ToString().ToLower() = "checked", "Sim", "Não")
        Dim inssNovo As String = If(row("InssNovo") IsNot DBNull.Value AndAlso row("InssNovo").ToString().ToLower() = "checked", "Sim", "Não")
        Dim inssProcur As String = If(row("InssProcur") IsNot DBNull.Value AndAlso row("InssProcur").ToString().ToLower() = "checked", "Sim", "Não")

        ' Criar item do ListView com subitens
        Dim listItem As New ListViewItem(razaoSocial)
        listItem.SubItems.Add(mei)
        listItem.SubItems.Add(inssAntigo)
        listItem.SubItems.Add(inssNovo)
        listItem.SubItems.Add(inssProcur)

        ListView1.Items.Add(listItem)
    End Sub

    Private Sub AtualizarContador()
        ' Atualizar o Label com o total de registros encontrados
        Label2.Text = "Total: " & ListView1.Items.Count.ToString() & " Parcelamentos"
    End Sub
    '/////////////////////

    Private Sub AtualizarCorComboBoxMes()
        ' Obter o mês atual por extenso
        Dim mesAtual As String = MonthName(Now.Month, True) ' Retorna o mês atual por extenso

        ' Comparar o valor selecionado no ComboBox com o mês atual
        If ComboBoxMesFechamento.Text.Equals(mesAtual, StringComparison.OrdinalIgnoreCase) Then
            ' Se o mês selecionado for igual ao mês atual
            ComboBoxMesFechamento.BackColor = Color.Green
            ComboBoxMesFechamento.ForeColor = Color.White
        Else
            ' Se o mês selecionado for diferente do mês atual
            ComboBoxMesFechamento.BackColor = Color.Yellow
            ComboBoxMesFechamento.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBoxMesFechamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMesFechamento.SelectedIndexChanged
        ' Atualizar a cor do ComboBox sempre que o mês for alterado
        AtualizarCorComboBoxMes()
    End Sub


End Class
