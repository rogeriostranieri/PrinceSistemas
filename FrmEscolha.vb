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
    Public Sub New(cnpj As String)
        InitializeComponent()
        Me.selectedCNPJ = cnpj
    End Sub

    ' Construtor padrão sem parâmetros
    Public Sub New()
        InitializeComponent()
        Me.selectedCNPJ = String.Empty
    End Sub

    ' Carregar o formulário e verificar a existência do CNPJ
    Private Sub FrmEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCNPJ.Text = selectedCNPJ

        ' Verificar a existência do CNPJ nas tabelas "Empresas" e "Laudos"
        Dim existsInEmpresas As Boolean = CheckCNPJExists("Empresas")
        Dim existsInLaudos As Boolean = CheckCNPJExists("Laudos")

        ' Mostrar ou ocultar botões com base na existência do CNPJ
        BtnEmpresa.Visible = existsInEmpresas
        BtnAlvara.Visible = existsInLaudos

        ' Exibir mensagem se não for encontrado em nenhuma tabela
        If Not existsInEmpresas AndAlso Not existsInLaudos Then
            MessageBox.Show("O CNPJ não foi encontrado em nenhuma das tabelas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Função que verifica a existência do CNPJ
    Private Function CheckCNPJExists(tableName As String) As Boolean
        Dim columnName As String = "CNPJ"

        ' Query para verificar a existência do CNPJ
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @CNPJ"

        ' Executa a consulta no banco de dados
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@CNPJ", selectedCNPJ)

            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    ' Método para abrir o formulário de Empresas (Legalização)
    Private Sub AbrirEmpresa()
        If CheckCNPJExists("Empresas") Then
            Dim existingForm As FrmLegalizacao = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmLegalizacao Then
                    existingForm = CType(openForm, FrmLegalizacao)
                    Exit For
                End If
            Next

            If existingForm IsNot Nothing Then
                Dim result As DialogResult = MessageBox.Show("O formulário 'Legalização' já está aberto. Deseja fechá-lo antes de abrir uma nova instância?", "Formulário Aberto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    existingForm.Close()
                Else
                    Exit Sub
                End If
            End If

            FrmLegalizacao.Show()

            ' Configura o ComboBox com o CNPJ selecionado
            FrmLegalizacao.ComboBoxBuscaCNPJ.Text = selectedCNPJ
            FrmLegalizacao.ComboBoxBuscaCNPJ.Select()

            Me.Close()
            FrmLegalizacao.Focus()
        Else
            MessageBox.Show("O CNPJ não foi encontrado nas Empresas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Método para abrir o formulário de Laudos (Alvará)
    Private Sub AbrirAlvara()
        If CheckCNPJExists("Laudos") Then
            Dim existingForm As FrmAlvara = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmAlvara Then
                    existingForm = CType(openForm, FrmAlvara)
                    Exit For
                End If
            Next

            If existingForm IsNot Nothing Then
                Dim result As DialogResult = MessageBox.Show("O formulário 'Alvará' já está aberto. Deseja fechá-lo antes de abrir uma nova instância?", "Formulário Aberto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    existingForm.Close()
                Else
                    Exit Sub
                End If
            End If

            FrmAlvara.Show()

            ' Configura o ComboBox com o CNPJ selecionado
            FrmAlvara.ComboBoxBuscaCNPJ.Text = selectedCNPJ
            FrmAlvara.ComboBoxBuscaCNPJ.Select()

            Me.Close()
            FrmAlvara.Focus()
        Else
            MessageBox.Show("O CNPJ não foi encontrado no Alvará.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Clique no botão Empresa
    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        AbrirEmpresa()
    End Sub

    ' Clique no botão Alvará
    Private Sub BtnAlvara_Click(sender As Object, e As EventArgs) Handles BtnAlvara.Click
        AbrirAlvara()
    End Sub

    ' Fechar ao clicar no PictureBox
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
