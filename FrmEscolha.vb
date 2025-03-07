Imports System.Data.SqlClient

Public Class FrmEscolha
    Private selectedCNPJ As String
    Private selectedRazaoSocial As String
    Private connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

    ' Permite que o formulário feche quando a tecla ESC é pressionada
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Construtor que aceita CNPJ e Razão Social como parâmetros
    Public Sub New(cnpj As String, razaoSocial As String, sourceTables As String, tipoOriginal As String)
        InitializeComponent()
        Me.selectedCNPJ = cnpj
        Me.selectedRazaoSocial = razaoSocial
    End Sub

    ' Carregar o formulário e verificar a existência do CNPJ ou Razão Social
    Private Sub FrmEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCNPJ.Text = selectedCNPJ
        LabelRazaoSocial.Text = selectedRazaoSocial

        ' Verificar a existência do CNPJ ou Razão Social nas tabelas
        Dim existsInEmpresas As Boolean = CheckCNPJOrRazaoSocialExists("Empresas")
        Dim existsInLaudos As Boolean = CheckCNPJOrRazaoSocialExists("Laudos")
        Dim existsInParcelamentos As Boolean = CheckCNPJOrRazaoSocialExists("Parcelamentos")

        ' Mostrar ou ocultar botões com base na existência do CNPJ ou Razão Social
        BtnEmpresa.Visible = existsInEmpresas
        BtnAlvara.Visible = existsInLaudos
        BtnParcelamentos.Visible = existsInParcelamentos

        ' Exibir mensagem se não for encontrado em nenhuma tabela
        If Not existsInEmpresas AndAlso Not existsInLaudos AndAlso Not existsInParcelamentos Then
            MessageBox.Show("O CNPJ ou a Razão Social não foram encontrados em nenhuma das tabelas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Função que verifica a existência do CNPJ ou Razão Social na tabela informada
    ' Função que verifica a existência do CNPJ ou Razão Social na tabela informada
    Private Function CheckCNPJOrRazaoSocialExists(tableName As String) As Boolean
        ' Colunas a serem verificadas
        Dim cnpjColumn As String = "CNPJ"
        Dim razaoSocialColumn As String = "RazaoSocial"
        Dim query As String

        ' Condicional para verificar qual parâmetro deve ser usado na consulta
        If Not String.IsNullOrEmpty(selectedCNPJ) Then
            query = $"SELECT COUNT(*) FROM {tableName} WHERE {cnpjColumn} = @CNPJ"
        ElseIf Not String.IsNullOrEmpty(selectedRazaoSocial) Then
            query = $"SELECT COUNT(*) FROM {tableName} WHERE {razaoSocialColumn} = @RazaoSocial"
        Else
            query = $"SELECT COUNT(*) FROM {tableName} WHERE {cnpjColumn} = @CNPJ OR {razaoSocialColumn} = @RazaoSocial"
        End If

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            If Not String.IsNullOrEmpty(selectedCNPJ) Then
                command.Parameters.AddWithValue("@CNPJ", selectedCNPJ)
            End If

            If Not String.IsNullOrEmpty(selectedRazaoSocial) Then
                command.Parameters.AddWithValue("@RazaoSocial", selectedRazaoSocial)
            End If

            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function


    ' Função que verifica a existência do CNPJ na tabela informada
    Private Function CheckCNPJExists(tableName As String) As Boolean
        Dim columnName As String = "CNPJ"
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @CNPJ"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@CNPJ", selectedCNPJ)

            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    ' Método para abrir o formulário de Empresas (Legalização)
    ' Método para abrir o formulário de Empresas (Legalização)
    Private Sub AbrirEmpresa()
        If CheckCNPJOrRazaoSocialExists("Empresas") Then
            FrmLegalizacao.Show()
            ' Se houver CNPJ, usa ComboBoxBuscaCNPJ; senão, usa ComboBoxBuscaRazaoSocial
            If Not String.IsNullOrEmpty(selectedCNPJ) Then
                FrmLegalizacao.ComboBoxBuscaCNPJ.Text = selectedCNPJ
                FrmLegalizacao.ComboBoxBuscaCNPJ.Select()
            ElseIf Not String.IsNullOrEmpty(selectedRazaoSocial) Then
                FrmLegalizacao.ComboBoxBuscaEmpresa.Text = selectedRazaoSocial
                FrmLegalizacao.ComboBoxBuscaEmpresa.Select()
            End If
            FrmLegalizacao.Focus()
        Else
            MessageBox.Show("O CNPJ ou a Razão Social não foram encontrados nas Empresas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Método para abrir o formulário de Laudos (Alvará)
    Private Sub AbrirAlvara()
        If CheckCNPJOrRazaoSocialExists("Laudos") Then
            FrmAlvara.Show()
            ' Se houver CNPJ, usa ComboBoxBuscaCNPJ; senão, usa ComboBoxBuscaAlvara
            If Not String.IsNullOrEmpty(selectedCNPJ) Then
                FrmAlvara.ComboBoxBuscaCNPJ.Text = selectedCNPJ
                FrmAlvara.ComboBoxBuscaCNPJ.Select()
            ElseIf Not String.IsNullOrEmpty(selectedRazaoSocial) Then
                FrmAlvara.ComboBoxBuscaAlvara.Text = selectedRazaoSocial
                FrmAlvara.ComboBoxBuscaAlvara.Select()
            End If
            FrmAlvara.Focus()
        Else
            MessageBox.Show("O CNPJ ou a Razão Social não foram encontrados no Alvará.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Método para abrir o formulário de Parcelamentos
    Private Sub AbrirParcelamentos()

        If CheckCNPJOrRazaoSocialExists("Parcelamentos") Then
            'verificar antes se FrmParcelamento esta aberto
            FrmParcelamento.MdiParent = MDIPrincipal
            FrmParcelamento.Show()
            ' Se houver CNPJ, usa ComboBoxBuscaCNPJ; senão, usa ComboBoxBuscarRazaoSocial
            If Not String.IsNullOrEmpty(selectedCNPJ) Then
                FrmParcelamento.ComboBoxBuscaCNPJ.Text = selectedCNPJ
                FrmParcelamento.ComboBoxBuscaCNPJ.Select()
            ElseIf Not String.IsNullOrEmpty(selectedRazaoSocial) Then
                FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = selectedRazaoSocial
                FrmParcelamento.ComboBoxBuscarRazaoSocial.Select()
            End If
            FrmParcelamento.Focus()
        Else
            MessageBox.Show("O CNPJ ou a Razão Social não foram encontrados em Parcelamentos.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    ' Clique nos botões
    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        AbrirEmpresa()
    End Sub

    Private Sub BtnAlvara_Click(sender As Object, e As EventArgs) Handles BtnAlvara.Click
        AbrirAlvara()
    End Sub

    Private Sub BtnParcelamentos_Click(sender As Object, e As EventArgs) Handles BtnParcelamentos.Click
        AbrirParcelamentos()
    End Sub

    ' Fechar ao clicar no PictureBox
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    ' Copiar CNPJ ao clicar no LinkLabel
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim result As DialogResult = MessageBox.Show("Deseja copiar o CNPJ sem caracteres especiais (pontos, traços, barras)?", "Confirmar Cópia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim cnpjParaCopiar As String = selectedCNPJ

            If result = DialogResult.Yes Then
                cnpjParaCopiar = selectedCNPJ.Replace(".", "").Replace("-", "").Replace("/", "")
            End If

            Clipboard.SetText(cnpjParaCopiar)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao copiar o CNPJ: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
