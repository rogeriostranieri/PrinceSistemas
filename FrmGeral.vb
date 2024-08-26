Imports System.Data.SqlClient

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
        LoadEmpresas()
    End Sub

    Private Sub LoadEmpresas()
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT DISTINCT RazaoSocial FROM (
                                SELECT RazaoSocial FROM Laudos
                                UNION
                                SELECT RazaoSocial FROM Empresas
                               ) AS EmpresasUnificadas"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            allEmpresas = New DataTable()
            adapter.Fill(allEmpresas)

            ListBoxEmpresas.DataSource = allEmpresas
            ListBoxEmpresas.DisplayMember = "RazaoSocial"
        End Using
    End Sub

    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim searchTerm As String = TextBoxBusca.Text.Trim().ToLower()

        If String.IsNullOrEmpty(searchTerm) Then
            ' Quando a busca está vazia, exiba todas as empresas
            ListBoxEmpresas.DataSource = allEmpresas
        Else
            Dim filteredRows = allEmpresas.AsEnumerable().Where(Function(row) row.Field(Of String)("RazaoSocial").ToLower().Contains(searchTerm))

            If filteredRows.Any() Then
                ListBoxEmpresas.DataSource = filteredRows.CopyToDataTable()
            Else
                ' Se não houver resultados, exiba uma lista vazia
                Dim emptyTable As New DataTable()
                emptyTable.Columns.Add("RazaoSocial", GetType(String))
                ListBoxEmpresas.DataSource = emptyTable
            End If
        End If

        ' Limpe qualquer seleção anterior
        ListBoxEmpresas.ClearSelected()
    End Sub

    Private Sub ListBoxEmpresas_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBoxEmpresas.MouseMove
        Dim index As Integer = ListBoxEmpresas.IndexFromPoint(e.Location)
        If index >= 0 AndAlso index < ListBoxEmpresas.Items.Count Then
            Dim item As DataRowView = CType(ListBoxEmpresas.Items(index), DataRowView)
            Dim itemText As String = item("RazaoSocial").ToString()
            toolTip.SetToolTip(ListBoxEmpresas, itemText)
        Else
            toolTip.SetToolTip(ListBoxEmpresas, String.Empty)
        End If
    End Sub

    Private Sub ListBoxEmpresas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxEmpresas.MouseDoubleClick
        Dim selectedItem As DataRowView = CType(ListBoxEmpresas.SelectedItem, DataRowView)
        If selectedItem IsNot Nothing Then
            Dim selectedRazaoSocial As String = selectedItem("RazaoSocial").ToString()

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

            ' Criar e mostrar uma nova instância do FrmEscolha
            Dim frmEscolha As New FrmEscolha(selectedRazaoSocial) With {
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
End Class
