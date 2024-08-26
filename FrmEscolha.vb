Imports System.Data.SqlClient

Public Class FrmEscolha

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


    ' Construtor que aceita a RazaoSocial como parâmetro
    Public Sub New(razaoSocial As String)
        ' Esta chamada é necessária pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.selectedRazaoSocial = razaoSocial
    End Sub

    ' Construtor padrão sem parâmetros
    Public Sub New()
        ' Esta chamada é necessária pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.selectedRazaoSocial = String.Empty ' Ou outra inicialização padrão
    End Sub

    ' Adicione o evento Deactivate


    Private Sub FrmEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atualize o Label com o valor da RazaoSocial
        LabelRazaoSocial.Text = selectedRazaoSocial

        ' Verificar a existência da RazaoSocial nas tabelas "Empresas" e "Laudos"
        Dim existsInEmpresas As Boolean = CheckRazaoSocialExists("Empresas")
        Dim existsInLaudos As Boolean = CheckRazaoSocialExists("Laudos")

        ' Mostrar ou ocultar botões com base na existência da RazaoSocial
        BtnEmpresa.Visible = existsInEmpresas
        BtnAlvara.Visible = existsInLaudos

        ' Exibir mensagem se não for encontrada em nenhuma tabela
        If Not existsInEmpresas AndAlso Not existsInLaudos Then
            MessageBox.Show("A Razão Social não foi encontrada em nenhuma das tabelas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub





    Private Sub FrmEscolha_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        ' Feche o formulário quando ele perder o foco
        Me.Close()
    End Sub


    Private Sub AbrirEmpresa()

        If CheckRazaoSocialExists("Empresas") Then
            ' Verificar se o formulário já está aberto
            Dim existingForm As FrmLegalizacao = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmLegalizacao Then
                    existingForm = CType(openForm, FrmLegalizacao)
                    Exit For
                End If
            Next

            If existingForm IsNot Nothing Then
                ' Exibir uma mensagem informando que o formulário já está aberto
                Dim result As DialogResult = MessageBox.Show("O formulário 'Legalização' já está aberto. Deseja fechá-lo antes de abrir uma nova instância?", "Formulário Aberto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    ' Fechar o formulário existente
                    existingForm.Close()
                Else
                    ' Não fechar o formulário existente, sair do método
                    Exit Sub
                End If
            End If

            ' Criar e mostrar uma nova instância do formulário
            Dim FrmLegalizacao As New FrmLegalizacao()

            FrmLegalizacao.Show()

            '' Configurar o ComboBoxBuscaAlvara com a razão social selecionada
            FrmLegalizacao.ComboBoxBuscaEmpresa.Text = LabelRazaoSocial.Text
            FrmLegalizacao.ComboBoxBuscaEmpresa.Select() ' Focar no ComboBox


            Me.Close()
            FrmLegalizacao.Focus()

        Else
            MessageBox.Show("A Razão Social não foi encontrada nas Empresas.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub AbrirAlvara()
        If CheckRazaoSocialExists("Laudos") Then
            ' Verificar se o formulário já está aberto
            Dim existingForm As FrmAlvara = Nothing
            For Each openForm As Form In Application.OpenForms
                If TypeOf openForm Is FrmAlvara Then
                    existingForm = CType(openForm, FrmAlvara)
                    Exit For
                End If
            Next

            If existingForm IsNot Nothing Then
                ' Exibir uma mensagem informando que o formulário já está aberto
                Dim result As DialogResult = MessageBox.Show("O formulário 'Alvará' já está aberto. Deseja fechá-lo antes de abrir uma nova instância?", "Formulário Aberto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    ' Fechar o formulário existente
                    existingForm.Close()
                Else
                    ' Não fechar o formulário existente, sair do método
                    Exit Sub
                End If
            End If

            ' Criar e mostrar uma nova instância do formulário
            Dim frmAlvara As New FrmAlvara()

            frmAlvara.Show()

            '' Configurar o ComboBoxBuscaAlvara com a razão social selecionada
            frmAlvara.ComboBoxBuscaAlvara.Text = LabelRazaoSocial.Text
            frmAlvara.ComboBoxBuscaAlvara.Select() ' Focar no ComboBox


            Me.Close()
            frmAlvara.Focus()

        Else
            MessageBox.Show("A Razão Social não foi encontrada no Alvará.", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Function CheckRazaoSocialExists(tableName As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE RazaoSocial = @RazaoSocial"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@RazaoSocial", selectedRazaoSocial)

            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        AbrirEmpresa()
    End Sub

    Private Sub BtnAlvara_Click(sender As Object, e As EventArgs) Handles BtnAlvara.Click
        AbrirAlvara()
    End Sub
End Class
