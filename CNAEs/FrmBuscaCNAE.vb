Imports System.Data.SqlClient

Public Class FrmBuscaCNAE
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub FrmBuscaCNAE_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla ESC foi pressionada
        If e.KeyCode = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmBuscaCNAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' Configurar o ListView
        ListViewCNAEs.View = View.Details
        ListViewCNAEs.Columns.Add("CNAE", 100, HorizontalAlignment.Left)
        ListViewCNAEs.Columns.Add("Grau de Risco", 30, HorizontalAlignment.Left) ' Tamanho fixo para a coluna de Grau de Risco
        ListViewCNAEs.Columns.Add("Descrição", 300, HorizontalAlignment.Left) ' Tamanho inicial para a coluna de descrição
        ' Opcional: Inicializar o ListView com todos os CNAEs
        CarregarCNAEs("")
    End Sub

    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim termoBusca As String = TextBoxBusca.Text.Trim()
        CarregarCNAEs(termoBusca)
    End Sub

    Private Sub CarregarCNAEs(termoBusca As String)
        ListViewCNAEs.Items.Clear()

        Dim query As String = "SELECT CNAE, Descricao, GrauDeRisco FROM CNAEprefMaringaPR WHERE CNAE LIKE @termoBusca OR Descricao LIKE @termoBusca"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@termoBusca", "%" & termoBusca & "%")
                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim cnae As String = reader("CNAE").ToString()
                        Dim descricao As String = reader("Descricao").ToString()
                        Dim grauDeRisco As String = reader("GrauDeRisco").ToString()

                        Dim item As New ListViewItem(cnae)
                        item.SubItems.Add(grauDeRisco)
                        item.SubItems.Add(descricao)
                        ListViewCNAEs.Items.Add(item)
                    End While
                End Using
            End Using
        End Using

        ' Ajustar a largura das colunas com base no conteúdo
        ListViewCNAEs.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent) ' Ajustar a coluna CNAE
        ListViewCNAEs.Columns(2).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent) ' Ajustar a coluna Descrição
    End Sub

    Private Sub ListViewCNAEs_DoubleClick(sender As Object, e As EventArgs) Handles ListViewCNAEs.DoubleClick
        If ListViewCNAEs.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = ListViewCNAEs.SelectedItems(0)
            Dim cnae As String = item.Text
            Dim descricao As String = item.SubItems(2).Text

            ' Verificar se o FrmLegalizacao está aberto
            For Each form As Form In Application.OpenForms
                If TypeOf form Is FrmLegalizacao Then
                    Dim frmLegalizacao As FrmLegalizacao = CType(form, FrmLegalizacao)
                    Dim resultado As DialogResult = MessageBox.Show("O CNAE é primário?", "Pergunta", MessageBoxButtons.YesNo)
                    If resultado = DialogResult.Yes Then
                        frmLegalizacao.CNAEPrincipalTextBox.Text = cnae
                    Else
                        frmLegalizacao.CNAESecundarioRichTextBox.AppendText(cnae & Environment.NewLine)
                    End If
                    frmLegalizacao.RamoDeAtividadeRichTextBox.AppendText(descricao & ";")
                    Return
                ElseIf TypeOf form Is FrmAlvara Then
                    Dim frmAlvara As FrmAlvara = CType(form, FrmAlvara)
                    frmAlvara.CNAERichTextBox.AppendText(cnae & Environment.NewLine)
                    frmAlvara.RamodeatividadeRichTextBox.AppendText(descricao & "; ")
                    Return
                End If
            Next

            ' Se nenhum formulário estiver aberto, você pode optar por exibir uma mensagem ou qualquer outra ação
            MessageBox.Show("Nenhum dos formulários necessários está aberto.")
        End If
    End Sub

    Private Sub ListViewCNAEs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewCNAEs.SelectedIndexChanged
        ' Implementar a lógica quando um item for selecionado, se necessário
    End Sub

    Private Sub LinkLabelEditor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditor.LinkClicked
        FrmCNAEEditar.Show()
        Me.Close()
    End Sub
End Class
