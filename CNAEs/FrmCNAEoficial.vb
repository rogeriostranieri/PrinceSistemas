Imports System.Data.SqlClient

Public Class FrmCNAEoficial
    ' String de conexão com o banco de dados
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Verifica se a tecla pressionada é a tecla Esc
        If keyData = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
            Return True
        End If

        ' Se não for a tecla Esc, usa o comportamento padrão
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub FrmCNAEoficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura o ListView no modo de exibição de detalhes (colunas)
        ListViewCNAEs.View = View.Details
        ListViewCNAEs.FullRowSelect = True ' Seleciona a linha inteira ao clicar
        ListViewCNAEs.GridLines = True ' Exibe linhas de grade para separar visualmente as colunas
        ListViewCNAEs.HideSelection = False ' Mantém a seleção visível mesmo quando o ListView não está focado

        ' Limpa e adiciona colunas ao ListView
        ListViewCNAEs.Columns.Clear()
        ListViewCNAEs.Columns.Add("Descrição", 200, HorizontalAlignment.Left)
        ListViewCNAEs.Columns.Add("Subclasse", 100, HorizontalAlignment.Left)
        ListViewCNAEs.Columns.Add("Seção", 80, HorizontalAlignment.Left)
        ListViewCNAEs.Columns.Add("Divisão", 80, HorizontalAlignment.Left)
        ListViewCNAEs.Columns.Add("Grupo", 80, HorizontalAlignment.Left)
        ListViewCNAEs.Columns.Add("Classe", 80, HorizontalAlignment.Left)

        ' Configuração do ComboBox para escolher o tipo de CNAE (Principal ou Secundário)
        ComboBoxTipoCNAE.Items.Clear()
        ComboBoxTipoCNAE.Items.AddRange(New String() {"Principal", "Secundário"})
        ComboBoxTipoCNAE.SelectedIndex = 0 ' Define "Principal" como o valor padrão

        ' Adiciona a mensagem inicial no ListView
        Dim noResultItem As New ListViewItem("Sem resultado... favor digitar e clicar em buscar")
        noResultItem.ForeColor = Color.Gray ' Exibe o texto inicial em cinza
        ListViewCNAEs.Items.Add(noResultItem)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ' Chama o método para buscar os CNAEs ao clicar no botão
        Dim searchText As String = TextBoxBusca.Text.Trim()

        ' Verifica se o texto contém apenas números
        If searchText.All(Function(c) Char.IsDigit(c)) Then
            ' Remove todos os caracteres que não sejam números (só por segurança)
            searchText = New String(searchText.Where(Function(c) Char.IsDigit(c)).ToArray())

            ' Se o texto tiver exatamente 7 dígitos, formata como XXXX-X/XX
            If searchText.Length = 7 Then
                searchText = searchText.Substring(0, 4) & "-" & searchText.Substring(4, 1) & "/" & searchText.Substring(5, 2)
            End If

            ' Atualiza o TextBoxBusca com o texto formatado
            TextBoxBusca.Text = searchText
        End If

        ' Chama o método para fazer a busca com o texto (numérico ou não)
        SearchCNAE(searchText)
    End Sub


    Private Sub SearchCNAE(searchText As String)
        ' Limpa todos os itens atuais antes de realizar a busca
        ListViewCNAEs.Items.Clear()

        ' Verifica se o texto de busca está vazio
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Por favor, insira um texto para buscar.", "Busca Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Adiciona a mensagem inicial de volta se a busca estiver vazia
            Dim noResultItem As New ListViewItem("Sem resultado... favor digitar e clicar em buscar")
            noResultItem.ForeColor = Color.Gray
            ListViewCNAEs.Items.Add(noResultItem)
            Return
        End If

        ' Conecta ao banco de dados e executa a busca
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Seção, Divisão, Grupo, Classe, Subclasse, Descrição " &
                                  "FROM CNAESubclasses23 " &
                                  "WHERE Seção COLLATE Latin1_General_CI_AI LIKE @search OR " &
                                  "Divisão COLLATE Latin1_General_CI_AI LIKE @search OR " &
                                  "Grupo COLLATE Latin1_General_CI_AI LIKE @search OR " &
                                  "Classe COLLATE Latin1_General_CI_AI LIKE @search OR " &
                                  "Subclasse COLLATE Latin1_General_CI_AI LIKE @search OR " &
                                  "Descrição COLLATE Latin1_General_CI_AI LIKE @search"

            Using command As New SqlCommand(query, connection)
                ' Parâmetro de busca com "%" para buscar qualquer parte do texto
                command.Parameters.AddWithValue("@search", "%" & searchText & "%")

                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim count As Integer = 0

                    ' Itera pelas linhas retornadas e adiciona ao ListView
                    While reader.Read()
                        Dim item As New ListViewItem(reader("Descrição").ToString()) ' Primeira coluna (Descrição)
                        item.SubItems.Add(reader("Subclasse").ToString()) ' Segunda coluna (Subclasse)
                        item.SubItems.Add(reader("Seção").ToString()) ' Terceira coluna (Seção)
                        item.SubItems.Add(reader("Divisão").ToString()) ' Quarta coluna (Divisão)
                        item.SubItems.Add(reader("Grupo").ToString()) ' Quinta coluna (Grupo)
                        item.SubItems.Add(reader("Classe").ToString()) ' Sexta coluna (Classe)
                        ListViewCNAEs.Items.Add(item)
                        count += 1
                    End While

                    ' Atualiza o label com o total de resultados encontrados
                    Label2.Text = $"Foram encontrados {count} resultados."

                    ' Se não houver resultados, mostra a mensagem padrão
                    If count = 0 Then
                        Dim noResultItem As New ListViewItem("Nenhum resultado encontrado para a busca.")
                        noResultItem.ForeColor = Color.Gray
                        ListViewCNAEs.Items.Add(noResultItem)
                    End If
                End Using
            End Using
        End Using

        ' Ajusta a largura das colunas automaticamente com base no conteúdo encontrado
        For Each col As ColumnHeader In ListViewCNAEs.Columns
            col.Width = -2 ' Auto-ajustar largura ao conteúdo
        Next
    End Sub

    '///////////////////////////// DUPLO CLICK LIST VIEW
    '                AdicionarCnae(richTextContent, tipoCNAE, cnaeTexto)

    Private Sub ListViewCNAEs_DoubleClick(sender As Object, e As EventArgs) Handles ListViewCNAEs.DoubleClick
        ' Verifica se há um item selecionado
        If ListViewCNAEs.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewCNAEs.SelectedItems(0)
            Dim descricao As String = selectedItem.Text
            Dim subclasse As String = selectedItem.SubItems(1).Text

            ' Verifica se a subclasse é nula ou vazia
            If String.IsNullOrEmpty(subclasse) Then
                MessageBox.Show("Este CNAE não pode ser utilizado, pois a Subclasse é nula.", "Subclasse Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            '//////////////// inicio posicionamento

            ' Verifica se o formulário FrmCNAEOficialEscolha já está aberto e ativa o formulário
            If Application.OpenForms.OfType(Of FrmCNAEOficialEscolha)().Any() Then
                FrmCNAEOficialEscolha.BringToFront()
                FrmCNAEOficialEscolha.Focus()
            Else
                ' Se não estiver aberto, abre o formulário FrmCNAEOficialEscolha diretamente
                FrmCNAEOficialEscolha.Show()
            End If

            ' Define ambos os formulários como StartPosition.Manual para permitir ajustes manuais
            Me.StartPosition = FormStartPosition.Manual
            FrmCNAEOficialEscolha.StartPosition = FormStartPosition.Manual

            ' Calcula o tamanho total dos dois formulários lado a lado
            Dim totalWidth As Integer = Me.Width + FrmCNAEOficialEscolha.Width
            Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

            ' Calcula a posição inicial para que ambos os formulários fiquem centralizados como um conjunto
            Dim startingX As Integer = (screenWidth - totalWidth) \ 2
            Dim startingY As Integer = (screenHeight - Me.Height) \ 2

            ' Posiciona o formulário atual (Me) à esquerda
            Me.Location = New Point(startingX, startingY)

            ' Posiciona o FrmCNAEOficialEscolha à direita do formulário atual (Me)
            FrmCNAEOficialEscolha.Location = New Point(Me.Location.X + Me.Width, startingY)
            '//////////////// fim posicionamento

            ' Obtém o conteúdo atual do RichTextBox
            Dim tipoCNAE As String = ComboBoxTipoCNAE.SelectedItem.ToString()
            Dim cnaeTexto As String = $"{subclasse} {descricao}"

            ' Verifica se o CNAE já existe antes de adicionar
            If VerificaCnae(cnaeTexto) Then
                Return ' Se o CNAE já existe, sai do método
            End If

            ' Chame a função sem o parâmetro richTextContent
            AdicionarCnae(tipoCNAE, cnaeTexto)


            ' Atualiza o RichTextBox
            FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text
        End If
    End Sub

    Private Function VerificaCnae(cnaeTexto As String) As Boolean
        ' Obtém o conteúdo do RichTextBox e separa em linhas
        Dim linhas As String() = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.Split(New String() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries)

        ' Verifica se o CNAE já existe nas linhas
        For Each linha As String In linhas
            If linha.Trim() <> "" Then ' Ignora linhas vazias
                ' Compara se a linha contém o texto do CNAE
                If linha.Contains(cnaeTexto) Then
                    ' Mensagem informando que o CNAE já está registrado
                    MessageBox.Show($"Este CNAE já está registrado.", "CNAE Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return True ' CNAE já existe
                End If
            End If
        Next

        Return False ' CNAE não existe
    End Function

    Private Sub AdicionarCnae(tipoCNAE As String, cnaeTexto As String)
        ' Adiciona o CNAE na seção correta (Principal ou Secundário)

        If tipoCNAE = "Principal" Then
            Dim posPrincipal As Integer = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.IndexOf("Principal:")

            ' Se "Principal:" não existe, cria a seção
            If posPrincipal = -1 Then
                FrmCNAEOficialEscolha.TodosCNAERichTextBox.AppendText("Principal:" & vbCrLf & cnaeTexto & vbCrLf)
            Else
                ' Obtém o conteúdo atual do RichTextBox
                Dim conteudoAtual As String = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text

                ' Armazena a seção Secundário
                Dim posSecundario As Integer = conteudoAtual.IndexOf("Secundário:")
                Dim secaoSecundario As String = String.Empty

                If posSecundario <> -1 Then
                    ' Obtém a seção "Secundário:" e tudo que vem depois dela
                    secaoSecundario = conteudoAtual.Substring(posSecundario)
                End If

                ' Cria o novo conteúdo, substituindo o CNAE principal
                Dim novoConteudo As String = "Principal:" & vbCrLf & cnaeTexto & vbCrLf & secaoSecundario

                ' Define o novo conteúdo no RichTextBox
                FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text = novoConteudo
            End If
        ElseIf tipoCNAE = "Secundário" Then
            Dim posSecundario As Integer = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.IndexOf("Secundário:")

            ' Se "Secundário:" não existe, cria a seção
            If posSecundario = -1 Then
                If FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.Contains("Principal:") Then
                    FrmCNAEOficialEscolha.TodosCNAERichTextBox.AppendText(vbCrLf & "Secundário:" & vbCrLf & cnaeTexto & vbCrLf)
                Else
                    FrmCNAEOficialEscolha.TodosCNAERichTextBox.AppendText("Principal:" & vbCrLf & vbCrLf & "Secundário:" & vbCrLf & cnaeTexto & vbCrLf)
                End If
            Else
                ' Encontra a posição do final da seção "Secundário:"
                Dim inicioLinhaSecundario As Integer = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.IndexOf(vbCrLf, posSecundario) + vbCrLf.Length
                Dim fimLinhaSecundario As Integer = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.IndexOf(vbCrLf, inicioLinhaSecundario)

                ' Se não houver CNAEs secundários ainda, apenas adiciona o novo CNAE
                If fimLinhaSecundario = -1 Then
                    FrmCNAEOficialEscolha.TodosCNAERichTextBox.AppendText(cnaeTexto & vbCrLf)
                Else
                    ' Adiciona o novo CNAE Secundário ao final da seção
                    FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text = FrmCNAEOficialEscolha.TodosCNAERichTextBox.Text.Insert(inicioLinhaSecundario, cnaeTexto & vbCrLf)
                End If
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click, Cancel_Button.Click, OK_Button.Click
        Me.Close()
    End Sub

    Private Sub TextBoxBusca_MouseEnter(sender As Object, e As EventArgs) Handles TextBoxBusca.MouseEnter
        If TextBoxBusca.Text = "Digite aqui o que deseja busca" Then
            TextBoxBusca.Text = ""
        End If
    End Sub
End Class
