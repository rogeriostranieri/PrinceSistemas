Imports System.Data.SqlClient
Public Class Login

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub ConnectToSQL()


        If txtUsername.Text.Length <= 0 Then
            MessageBox.Show("Digite o nome de Usuário!")
        ElseIf txtPassword.Text.Length <= 0 Then
            MessageBox.Show("Digite sua Senha")
        End If

        Try
            Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim sql As String = "select count(*) from Login where Usuario=@Usuario and Senha=@Senha"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@Usuario", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Senha", txtPassword.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then

                        'MessageBox.Show("Seja Bem Vindo!")
                        FimData1()

                        MDIPrincipal.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Usuário ou Senha incorreta!")
                    End If
                End Using

            End Using
        Catch error_t As Exception
            'MsgBox(error_t.ToString)
            MessageBox.Show("Erro ao conectar com o Banco de Dados!")
        End Try

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ConnectToSQL()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chama validação da expiração
        Call ModData.FimData()
        'continua



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Está com erro de conexão no banco de dados?") = DialogResult.Yes Then
            Dim psi As New ProcessStartInfo With {
                .Verb = "runas", ' aka run as administrator
                .FileName = "cmd.exe",
                .Arguments = "/c net start ""SQL Server (PRINCE)""
ECHO %batchName% Arguments: P1=%1 P2=%2 P3=%3 P4=%4 P5=%5 P6=%6 P7=%7 P8=%8 P9=%9
cmd /k" ' <- pass arguments for the command you want to run
                }

            Try
                Process.Start(psi) ' <- run the process (user will be prompted to run with administrator access)
            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try
        Else
            'nao faz nada   
        End If

    End Sub
End Class
