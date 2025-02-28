Imports System.Data.SqlClient

Public Class Login

    ' Variável pública para armazenar o nome do usuário logado
    Public Shared UsuarioLogado As String

    ' Connection string – para produção, armazene em um arquivo de configuração com segurança
    Private Const connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    ''' <summary>
    ''' Efetua a autenticação do usuário, validando as entradas e consultando o banco de dados.
    ''' </summary>
    Private Sub ConnectToSQL()
        ' Valida os campos de entrada
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Digite o nome de Usuário!")
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Digite sua Senha!")
            txtPassword.Focus()
            Return
        End If

        Try
            ' Consulta para autenticação com validação de usuário e senha
            Dim sqlQuery As String = "SELECT COUNT(*) FROM Login WHERE Usuario = @Usuario AND Senha = @Senha"
            ' Consulta para verificar se o usuário existe (usada em caso de senha incorreta)
            Dim userExistsQuery As String = "SELECT COUNT(*) FROM Login WHERE Usuario = @Usuario"

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand(sqlQuery, conn)
                    cmd.Parameters.AddWithValue("@Usuario", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Senha", txtPassword.Text.Trim())
                    Dim loginCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If loginCount > 0 Then
                        ' Armazena o nome do usuário logado na variável global
                        UsuarioLogado = txtUsername.Text.Trim()

                        ' Autenticação bem-sucedida: verifica a expiração da licença e abre a tela principal
                        ModData.FimData1()  ' Verifica se há poucos dias para expiração ou se já expirou
                        '  Dim mdiPrincipalForm As New MDIPrincipal()
                        MDIPrincipal.Show() ' Exibe o formulário principal
                        Me.Hide() ' Oculta o formulário de login
                    Else
                        ' Se a autenticação falhar, verifica se o usuário existe para informar corretamente o erro
                        Using cmdUser As New SqlCommand(userExistsQuery, conn)
                            cmdUser.Parameters.AddWithValue("@Usuario", txtUsername.Text.Trim())
                            Dim userCount As Integer = Convert.ToInt32(cmdUser.ExecuteScalar())
                            If userCount > 0 Then
                                MessageBox.Show("Senha incorreta!")
                            Else
                                MessageBox.Show("Usuário não existe!")
                            End If
                        End Using
                    End If
                End Using
            End Using

        Catch ex As Exception
            ' Em produção, registrar o erro detalhado em log para análise
            MessageBox.Show("Erro ao conectar com o Banco de Dados!")
        End Try
    End Sub

    ' Evento do botão OK (Login)
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ConnectToSQL()

    End Sub

    ' Evento do botão Cancel – encerra a aplicação
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    ' Evento do botão para exibir a AboutBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox.ShowDialog()
    End Sub

    ' Evento de carregamento do formulário de Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  ModData.LogError("Login_Load chamado")
        Try
            ' ModData.FimData()
            ' ModData.LogError("FimData executado com sucesso no Login_Load")
            ProtecaoContraPrintScreen(Me, True)
            '  ModData.LogError("ProtecaoContraPrintScreen executado com sucesso no Login_Load")
        Catch ex As Exception
            ' ModData.LogError("Erro no Login_Load: " & ex.Message)
            MessageBox.Show("Erro ao carregar o Login: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento do botão que tenta iniciar o serviço SQL se houver erro de conexão
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Está com erro de conexão no banco de dados?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim psi As New ProcessStartInfo With {
                .Verb = "runas", ' Executa como administrador
                .FileName = "cmd.exe",
                .Arguments = "/c net start ""SQL Server (PRINCE)"" & pause"
            }

            Try
                Process.Start(psi)
            Catch ex As Exception
                MessageBox.Show("Erro ao tentar iniciar o serviço SQL: " & ex.Message)
            End Try
        End If
    End Sub

    ' Evento para alternar a visibilidade da senha digitada
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar ' Exibe a senha
        Else
            txtPassword.PasswordChar = "*"c ' Oculta a senha
        End If
    End Sub

End Class
