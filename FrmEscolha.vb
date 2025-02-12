Imports System.Data.SqlClient

Public Class FrmEscolha
    Private selectedCNPJ As String
    Private connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

    ' Permite que o formulário feche quando a tecla ESC é pressionada
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Construtor que aceita o CNPJ como parâmetro
    Public Sub New(cnpj As String, sourceTables As String, tipoOriginal As String)
        InitializeComponent()
        Me.selectedCNPJ = cnpj
    End Sub

    ' Carregar o formulário e verificar a existência do CNPJ
    ' Carregar o formulário e verificar a existência do CNPJ ou Razão Social
    Private Sub FrmEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCNPJ.Text = selectedCNPJ

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
    Private Function CheckCNPJOrRazaoSocialExists(tableName As String) As Boolean
        ' Colunas a serem verificadas
        Dim cnpjColumn As String = "CNPJ"
        Dim razaoSocialColumn As String = "RazaoSocial"
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE {cnpjColumn} = @CNPJ OR {razaoSocialColumn} = @RazaoSocial"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@CNPJ", selectedCNPJ)
            command.Parameters.AddWithValue("@RazaoSocial", selectedCNPJ) ' Usando selectedCNPJ para procurar pela Razão Social, caso necessário

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
            ' Verificar se o CNPJ existe na empresa, se sim, usa ComboBoxBuscaCNPJ, se não, usa ComboBoxBuscaRazaoSocial
            If CheckCNPJExists("Empresas") Then
                FrmLegalizacao.ComboBoxBuscaCNPJ.Text = selectedCNPJ
                FrmLegalizacao.ComboBoxBuscaCNPJ.Select()
            Else
                FrmLegalizacao.ComboBoxBuscaEmpresa.Text = selectedCNPJ
                FrmLegalizacao.ComboBoxBuscaEmpresa.Select()
            End If
            'Me.Close()
            FrmLegalizacao.Focus()
        Else
            MessageBox.Show("O CNPJ ou a Razão Social não foram encontrados nas Empresas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Método para abrir o formulário de Laudos (Alvará)
    Private Sub AbrirAlvara()
        If CheckCNPJOrRazaoSocialExists("Laudos") Then
            FrmAlvara.Show()
            ' Verificar se o CNPJ existe no Alvará, se sim, usa ComboBoxBuscaCNPJ, se não, usa ComboBoxBuscaRazaoSocial
            If CheckCNPJExists("Laudos") Then
                FrmAlvara.ComboBoxBuscaCNPJ.Text = selectedCNPJ
                FrmAlvara.ComboBoxBuscaCNPJ.Select()
            Else
                FrmAlvara.ComboBoxBuscaAlvara.Text = selectedCNPJ
                FrmAlvara.ComboBoxBuscaAlvara.Select()
            End If
            'Me.Close()
            FrmAlvara.Focus()
        Else
            MessageBox.Show("O CNPJ ou a Razão Social não foram encontrados no Alvará.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Método para abrir o formulário de Parcelamentos
    Private Sub AbrirParcelamentos()
        If CheckCNPJOrRazaoSocialExists("Parcelamentos") Then
            FrmParcelamento.Show()
            ' Verificar se o CNPJ existe nos Parcelamentos, se sim, usa ComboBoxBuscaCNPJ, se não, usa ComboBoxBuscaRazaoSocial
            If CheckCNPJExists("Parcelamentos") Then
                FrmParcelamento.ComboBoxBuscaCNPJ.Text = selectedCNPJ
                FrmParcelamento.ComboBoxBuscaCNPJ.Select()
            Else
                FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = selectedCNPJ
                FrmParcelamento.ComboBoxBuscarRazaoSocial.Select()
            End If
            ' Me.Close()
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
