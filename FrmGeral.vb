Imports System.Data.SqlClient
Imports System.Drawing

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

    Private Sub FrmGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolTip = New ToolTip()
        SetupListView()
        LoadEmpresas()
    End Sub

    Private Sub SetupListView()
        ' Configurar as colunas do ListView
        ListViewGeral.View = View.Details
        ListViewGeral.Columns.Add("Matriz/Filial", 90, HorizontalAlignment.Left)
        ListViewGeral.Columns.Add("Razão Social", 280, HorizontalAlignment.Left)
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

    Private Sub ListViewGeral_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListViewGeral.DrawItem
        ' Desenhar os itens normalmente
        e.DrawDefault = True
    End Sub

    Private Sub ListViewGeral_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListViewGeral.DrawSubItem
        ' Desenhar os subitens normalmente
        e.DrawDefault = True
    End Sub


    Private Sub LoadEmpresas()
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT 
                                COALESCE(NULLIF(Matriz, ''), 'Matriz') AS Tipo, 
                                RazaoSocial, 
                                CNPJ 
                           FROM Laudos 
                           UNION 
                           SELECT 
                                COALESCE(NULLIF(Sede, ''), 'Matriz') AS Tipo, 
                                RazaoSocial, 
                                CNPJ 
                           FROM Empresas"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            allEmpresas = New DataTable()
            adapter.Fill(allEmpresas)

            ListViewGeral.Items.Clear()

            ' Adicionar linhas ao ListView com as colunas correspondentes
            For Each row As DataRow In allEmpresas.Rows
                Dim tipo As String = If(Not String.IsNullOrEmpty(row("Tipo").ToString()), row("Tipo").ToString(), "Não informado")
                Dim razaoSocial As String = If(Not String.IsNullOrEmpty(row("RazaoSocial").ToString()), row("RazaoSocial").ToString(), "Sem Razão Social")
                Dim CNPJ As String = If(Not String.IsNullOrEmpty(row("CNPJ").ToString()), row("CNPJ").ToString(), "Sem CNPJ")

                ' Criar o ListViewItem com o tipo (Matriz/Filial)
                Dim listItem As New ListViewItem(tipo)

                ' Adicionar a Razão Social como subitem
                listItem.SubItems.Add(razaoSocial)

                ' Adicionar o CNPJ como subitem
                listItem.SubItems.Add(CNPJ) ' Esta linha garante que o CNPJ será exibido

                ' Guardar o CNPJ no Tag
                listItem.Tag = CNPJ

                ' Adicionar o item ao ListView
                ListViewGeral.Items.Add(listItem)
            Next
        End Using
    End Sub



    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Se a caixa de busca estiver vazia, recarregar todas as empresas
        If String.IsNullOrEmpty(termoBusca) Then
            LoadEmpresas()
        Else
            ' Caso contrário, filtrar empresas com base no termo de busca
            BuscarEmpresas(termoBusca)
        End If
    End Sub

    Private Sub BuscarEmpresas(ByVal termoBusca As String)
        ' Filtra o DataTable com base no termo de busca
        Dim resultados As DataRow() = allEmpresas.Select("RazaoSocial LIKE '%" & termoBusca & "%' OR CNPJ LIKE '%" & termoBusca & "%'")

        ' Limpar o ListView antes de exibir os resultados filtrados
        ListViewGeral.Items.Clear()

        ' Adicionar os resultados filtrados ao ListView
        For Each row As DataRow In resultados
            Dim tipo As String = If(Not String.IsNullOrEmpty(row("Tipo").ToString()), row("Tipo").ToString(), "Não informado")
            Dim razaoSocial As String = If(Not String.IsNullOrEmpty(row("RazaoSocial").ToString()), row("RazaoSocial").ToString(), "Sem Razão Social")
            Dim CNPJ As String = If(Not String.IsNullOrEmpty(row("CNPJ").ToString()), row("CNPJ").ToString(), "Sem CNPJ")

            ' Criar o ListViewItem com o tipo (Matriz/Filial)
            Dim listItem As New ListViewItem(tipo)

            ' Adicionar a Razão Social como subitem
            listItem.SubItems.Add(razaoSocial)

            ' Adicionar o CNPJ como subitem
            listItem.SubItems.Add(CNPJ) ' Garantir que o CNPJ esteja sendo adicionado

            ' Guardar o CNPJ no Tag
            listItem.Tag = CNPJ

            ' Adicionar o item ao ListView
            ListViewGeral.Items.Add(listItem)
        Next
    End Sub


    Private Sub ListViewGeral_MouseMove(sender As Object, e As MouseEventArgs) Handles ListViewGeral.MouseMove
        Dim item As ListViewItem = ListViewGeral.GetItemAt(e.X, e.Y)
        If item IsNot Nothing Then
            ' Obtém o texto da subitem na coluna de Razão Social (índice 1)
            Dim text As String = item.SubItems(1).Text
            ' Configura o tooltip para o texto completo
            toolTip.SetToolTip(ListViewGeral, text)
        Else
            toolTip.SetToolTip(ListViewGeral, String.Empty)
        End If
    End Sub

    Private Sub ListViewGeral_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewGeral.MouseDoubleClick
        If ListViewGeral.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewGeral.SelectedItems(0)
            Dim selectedCNPJ As String = selectedItem.Tag.ToString() ' Pegar o CNPJ

            ' Verificar se o FrmEscolha já está aberto
            Dim existingForm As FrmEscolha = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmEscolha Then
                    existingForm = CType(openForm, FrmEscolha)
                    Exit For
                End If
            Next

            ' Fechar o formulário existente
            existingForm?.Close()

            ' Criar e mostrar uma nova instância do FrmEscolha, passando o CNPJ
            Dim frmEscolha As New FrmEscolha(selectedCNPJ) With {
                .MdiParent = Me.MdiParent ' Definindo o formulário MDI pai
            }
            frmEscolha.Show()
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

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        ' Verifica se a TextBox de busca contém texto
        Dim termoBusca As String = TextBoxBusca.Text.Trim()

        ' Se houver texto na TextBox, faz a busca e atualiza o ListView
        If Not String.IsNullOrEmpty(termoBusca) Then
            ' Atualiza a busca com base no termo atual
            BuscarEmpresas(termoBusca)
        Else
            ' Se a TextBox estiver vazia, apenas recarrega todas as empresas
            LoadEmpresas()
        End If

        ' Mensagem opcional para confirmar que a atualização foi feita
        MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
