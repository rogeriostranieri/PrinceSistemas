Imports System.Data.SqlClient

Public Class UserADM

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private ReadOnly da As SqlDataAdapter
    Private ReadOnly dr As SqlDataReader



    Private Sub ConnectToSQL()

        Try
            If UsernameTextBox.Text.Length <= 0 Then
                MessageBox.Show("Digite o nome de Usuário!")
            ElseIf PasswordTextBox.Text.Length <= 0 Then
                MessageBox.Show("Digite sua Senha")
            End If
            Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim sql As String = "select count(*) from Login where Usuario=@Usuario and Senha=@Senha"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then
                        'SenhaNova
                        'SenhaNovaRepetida
                        If SenhaNova.Text = SenhaNovaRepetida.Text Then
                            Senha()
                        Else
                            MessageBox.Show("As novas senhas estão diferentes!")

                        End If
                    Else
                        MessageBox.Show("Usuário ou Senha inicial está incorreta!")
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)

        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ConnectToSQL()
    End Sub

    Private Sub BtnLimparSenha_Click(sender As Object, e As EventArgs) Handles BtnLimparSenha.Click
        'limpar dados da senha

        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        SenhaNova.Text = ""
        SenhaNovaRepetida.Text = ""
    End Sub





    ' comando atualizar senha


    Private Sub Senha()
        Try
            conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")

            'Comando para inserir novo registro
            Dim strSQL As String = "UPDATE Login SET Senha = @Senha WHERE Usuario = @Usuario" 'WHERE ID = @ID

            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Senha", SenhaNova.Text.Trim)
            comando.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
            ' comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Senha alterada com Sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try
    End Sub

    Private Sub BtnNomeFinal_Click(sender As Object, e As EventArgs) Handles BtnNomeFinal.Click
        MudarNomeETema()
    End Sub

    Private Sub MudarNomeETema()
        Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim sql As String = "select count(*) from Login where Usuario=@Usuario and Senha=@Senha"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
                Dim value = cmd.ExecuteScalar()
                If value = 1 Then
                    'UPDATE Login SET Tema=@TemaComboBox WHERE NomeCompleto=@NomeCompletoTextBox
                    'Selecionar Usuario e mudar nome completo e tema
                    Dim strSQL As String = "UPDATE Login SET NomeCompleto=@NomeCompleto, Tema=@TemaComboBox WHERE Usuario=@Usuario" 'WHERE ID = @ID
                    Using cmd4 As New SqlCommand(strSQL, Conn)
                        cmd4.Parameters.AddWithValue("@NomeCompleto", NomeCompletoTextBox.Text)
                        cmd4.Parameters.AddWithValue("@TemaComboBox", TemaComboBox.Text)
                        cmd4.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                        cmd4.ExecuteNonQuery()
                    End Using
                    MDIPrincipal.Refresh()



                    MsgBox("Dados alterados com sucesso")

                Else
                    MsgBox("Usuário ou senha incorretos")
                End If
            End Using
        End Using

    End Sub

    Private Sub TESTE()
        'codigo para mudar o tema
        '  Dim sql2 As String = "select NomeCompleto from Login where NomeCompleto=@NomeCompletoTextBox "
        '  Using cmd2 As New SqlCommand(sql2, Conn)
        '  cmd2.Parameters.AddWithValue("@NomeCompletoTextBox", NomeCompletoTextBox.Text)
        ' Dim value2 = cmd2.ExecuteScalar()
        ' End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub UserADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'preencher TemaComboBox
        TemaComboBox.Items.Add("Novo")
        TemaComboBox.Items.Add("Padrão")
        TemaComboBox.Items.Add("Noite")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub



End Class
