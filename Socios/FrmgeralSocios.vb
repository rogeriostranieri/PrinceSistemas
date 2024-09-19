Imports System.Text
Imports System.Data.SqlClient
Imports System.Drawing
Imports Microsoft.Web.WebView2

Public Class FrmSociosGERAL
    Private allSocios As DataTable
    Private toolTip As ToolTip

    ' Permite que o formulário feche quando a tecla ESC é pressionada
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub FrmGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolTip = New ToolTip()
        SetupListView()
        LoadSocios()
    End Sub

    Private Sub SetupListView()
        ' Configurar as colunas do ListView
        ListViewGeral.View = View.Details
        ListViewGeral.Columns.Add("Nome Completo", 280, HorizontalAlignment.Left)
        ListViewGeral.Columns.Add("CPF", 160, HorizontalAlignment.Left) ' Certifique-se que esta linha existe e que o tamanho é adequado

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

    Private Sub ListViewGeral_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListViewGeral.DrawItem
        ' Desenhar os itens normalmente
        e.DrawDefault = True
    End Sub

    Private Sub ListViewGeral_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListViewGeral.DrawSubItem
        ' Desenhar os subitens normalmente
        e.DrawDefault = True
    End Sub

    Private Sub LoadSocios()
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT NomeCompleto, CPF FROM Socios"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            allSocios = New DataTable()
            adapter.Fill(allSocios)

            ListViewGeral.Items.Clear()

            ' Adicionar linhas ao ListView com as colunas correspondentes
            For Each row As DataRow In allSocios.Rows
                Dim nomeCompleto As String = If(Not String.IsNullOrEmpty(row("NomeCompleto").ToString()), row("NomeCompleto").ToString(), "Nome não informado")
                Dim CPF As String = If(Not String.IsNullOrEmpty(row("CPF").ToString()), row("CPF").ToString(), "Sem CPF")

                ' Criar o ListViewItem com o nome completo
                Dim listItem As New ListViewItem(nomeCompleto)

                ' Adicionar o CPF como subitem
                listItem.SubItems.Add(CPF)

                ' Guardar o CPF no Tag
                listItem.Tag = CPF

                ' Adicionar o item ao ListView
                ListViewGeral.Items.Add(listItem)
            Next
            ' Atualizar o Label com o total de sócios
            Label2.Text = "Total: " & ListViewGeral.Items.Count.ToString() & " sócios"
        End Using
    End Sub

    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Se a caixa de busca estiver vazia, recarregar todos os sócios
        If String.IsNullOrEmpty(termoBusca) Then
            LoadSocios()
        Else
            ' Caso contrário, filtrar sócios com base no termo de busca
            BuscarSocios(termoBusca)
        End If

        ' Atualizar o Label com o total de sócios filtrados
        Label2.Text = "Total: " & ListViewGeral.Items.Count.ToString() & " sócios"
    End Sub

    Private Sub BuscarSocios(ByVal termoBusca As String)
        ' Remover acentos e símbolos do termo de busca
        termoBusca = RemoverAcentos(termoBusca.ToLower())

        ' Filtra o DataTable com base no termo de busca
        Dim resultados As DataRow() = allSocios.Select()

        ' Limpar o ListView antes de exibir os resultados filtrados
        ListViewGeral.Items.Clear()

        ' Adicionar os resultados filtrados ao ListView
        For Each row As DataRow In resultados
            ' Normalizar e remover acentos dos dados da linha
            Dim nomeCompleto As String = RemoverAcentos(row("NomeCompleto").ToString().ToLower())
            Dim cpf As String = RemoverSimbolos(row("CPF").ToString()).ToLower()

            ' Remover acentos e símbolos do termo de busca
            Dim termoBuscaNome As String = RemoverAcentos(termoBusca).ToLower()
            Dim termoBuscaCPF As String = RemoverSimbolos(termoBusca).ToLower()

            ' Verificar se o nome ou CPF contém o termo de busca
            If nomeCompleto.Contains(termoBuscaNome) Or cpf.Contains(termoBuscaCPF) Then
                ' Criar o ListViewItem com o nome completo
                Dim listItem As New ListViewItem(row("NomeCompleto").ToString())

                ' Adicionar o CPF como subitem
                Dim cpfFormatado As String = If(Not String.IsNullOrEmpty(row("CPF").ToString()), row("CPF").ToString(), "Sem CPF")
                listItem.SubItems.Add(cpfFormatado)

                ' Guardar o CPF no Tag
                listItem.Tag = row("CPF").ToString()

                ' Adicionar o item ao ListView
                ListViewGeral.Items.Add(listItem)
            End If
        Next
    End Sub



    Private Function RemoverSimbolos(texto As String) As String
        ' Remove pontos, traços e espaços do CPF
        Return texto.Replace(".", "").Replace("-", "").Replace(" ", "")
    End Function


    Private Function RemoverAcentos(texto As String) As String
        Dim normalizedString As String = texto.Normalize(NormalizationForm.FormD)
        Dim sb As New System.Text.StringBuilder()

        For Each c As Char In normalizedString
            If System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) <> System.Globalization.UnicodeCategory.NonSpacingMark Then
                sb.Append(c)
            End If
        Next

        Return sb.ToString().Normalize(NormalizationForm.FormC)
    End Function

    Private Sub ListViewGeral_MouseMove(sender As Object, e As MouseEventArgs) Handles ListViewGeral.MouseMove
        Dim item As ListViewItem = ListViewGeral.GetItemAt(e.X, e.Y)
        If item IsNot Nothing Then
            ' Obtém o texto da subitem na coluna de Nome Completo (índice 0)
            Dim text As String = item.SubItems(0).Text
            ' Configura o tooltip para o texto completo
            toolTip.SetToolTip(ListViewGeral, text)
        Else
            toolTip.SetToolTip(ListViewGeral, String.Empty)
        End If
    End Sub

    Private Sub ListViewGeral_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewGeral.MouseDoubleClick
        If ListViewGeral.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewGeral.SelectedItems(0)
            Dim selectedCPF As String = selectedItem.Tag.ToString() ' Pegar o CPF
            Dim selectedNomeCompleto As String = selectedItem.Text ' Pegar o Nome Completo

            ' Verificar se o FrmSocios já está aberto
            Dim existingForm As FrmSocios = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmSocios Then
                    existingForm = CType(openForm, FrmSocios)
                    Exit For
                End If
            Next

            ' Fechar o formulário existente
            existingForm?.Close()

            FrmSocios.Show()

            ' Preencher o ComboBox com o CPF ou Nome Completo
            If Not String.IsNullOrEmpty(selectedCPF) Then
                FrmSocios.CPFComboBox.Text = selectedCPF
            Else
                FrmSocios.NomeCompletoComboBox.Text = selectedNomeCompleto
            End If

            FrmSocios.CPFComboBox.Focus() ' Dar foco ao ComboBox
        End If
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

End Class
