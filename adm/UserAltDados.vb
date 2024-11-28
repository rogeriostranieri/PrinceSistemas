Imports System.Data.SqlClient

Public Class UserAltDados

    ' Conexão com o banco de dados
    Private connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    ' Método de salvar as alterações de nome completo, tema e data de nascimento
    Private Sub BtnNomeFinal_Click(sender As Object, e As EventArgs) Handles BtnNomeFinal.Click
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Login WHERE Usuario=@Usuario AND Senha=@Senha"

            Using Conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()

                    ' Adicionar parâmetros
                    cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text.Trim())

                    ' Verificar se o usuário existe
                    Dim value As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If value = 1 Then
                        ' Atualizar nome, tema e data de nascimento
                        Dim updateSQL As String = "UPDATE Login SET NomeCompleto=@NomeCompleto, Tema=@TemaComboBox, DataNascimento=@DataNascimento WHERE Usuario=@Usuario"

                        Using cmdUpdate As New SqlCommand(updateSQL, Conn)
                            cmdUpdate.Parameters.AddWithValue("@NomeCompleto", NomeCompletoTextBox.Text.Trim())
                            cmdUpdate.Parameters.AddWithValue("@TemaComboBox", If(TemaComboBox.SelectedItem IsNot Nothing, TemaComboBox.SelectedItem.ToString(), DBNull.Value))

                            ' Verifica se a data de nascimento está preenchida
                            If String.IsNullOrWhiteSpace(DataNascimentoMaskedTextBox.Text) Then
                                cmdUpdate.Parameters.AddWithValue("@DataNascimento", DBNull.Value)
                            Else
                                cmdUpdate.Parameters.AddWithValue("@DataNascimento", DataNascimentoMaskedTextBox.Text.Trim())
                            End If

                            cmdUpdate.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text.Trim())

                            ' Executa o comando de atualização
                            cmdUpdate.ExecuteNonQuery()

                            MsgBox("Dados alterados com sucesso")
                            MDIAtualiza()
                        End Using
                    Else
                        MsgBox("Usuário ou senha incorretos")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Erro ao acessar o banco de dados: " & ex.Message)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    ' Método para carregar imagens no TemaComboBox
    Private Sub UserAltDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Definir as extensões permitidas
            Dim extensoes As String() = {"*.jpeg", "*.jpg", "*.png", "*.gif"}

            ' Loop por todas as extensões e adicionar os arquivos ao ComboBox
            For Each ext As String In extensoes
                For Each img As String In IO.Directory.EnumerateFiles(Application.StartupPath & "\Imagens\Plano de Fundo", ext)
                    Dim imgName As String = IO.Path.GetFileName(img)
                    TemaComboBox.Items.Add(imgName)
                Next
            Next
        Catch ex As Exception
            MsgBox("Erro ao carregar imagens: " & ex.Message)
        End Try
    End Sub


    ' Limpar os campos
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        NomeCompletoTextBox.Clear()
        TemaComboBox.SelectedIndex = -1 ' Limpa a seleção do ComboBox
        DataNascimentoMaskedTextBox.Clear()
    End Sub

    ' Mostrar dados do usuário ao carregar
    Private Sub BtnMostrarDados_Click(sender As Object, e As EventArgs) Handles BtnMostrarDados.Click
        Try
            Dim sql As String = "SELECT * FROM Login WHERE Usuario=@Usuario AND Senha=@Senha"

            Using Conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()

                    ' Adicionar parâmetros
                    cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text.Trim())

                    ' Executar a leitura de dados
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            NomeCompletoTextBox.Text = If(IsDBNull(reader("NomeCompleto")), String.Empty, reader("NomeCompleto").ToString())
                            TemaComboBox.Text = If(IsDBNull(reader("Tema")), String.Empty, reader("Tema").ToString())
                            DataNascimentoMaskedTextBox.Text = If(IsDBNull(reader("DataNascimento")), String.Empty, reader("DataNascimento").ToString())
                        Else
                            MsgBox("Usuário ou senha incorretos")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Erro ao acessar o banco de dados: " & ex.Message)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    ' Atualiza os dados na MDIPrincipal
    Private Sub MDIAtualiza()
        Try
            Using conexao As New SqlConnection(connectionString)
                conexao.Open()

                Dim sql As String = "SELECT * FROM Login WHERE Usuario=@Usuario"
                Using comando As New SqlCommand(sql, conexao)
                    comando.Parameters.AddWithValue("@Usuario", Login.txtUsername.Text.Trim())

                    Using dr As SqlDataReader = comando.ExecuteReader()
                        If dr.Read() Then
                            MDIPrincipal.LblNomeCompleto.Text = "Bem vindo Sr(a). " & If(IsDBNull(dr("NomeCompleto")), "Usuário", dr("NomeCompleto").ToString()) & "!"
                            MDIPrincipal.LbTema.Text = If(IsDBNull(dr("Tema")), "Tema Padrão", dr("Tema").ToString())
                            MDIPrincipal.LblNomeCompleto.ForeColor = Color.White
                            MDIPrincipal.LbTema.ForeColor = Color.Black

                            ' Definir a imagem de fundo
                            Try
                                For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
                                    Dim imgName As String = IO.Path.GetFileName(img)
                                    If imgName.StartsWith(dr("Tema").ToString()) Then
                                        MDIPrincipal.BackgroundImage = Image.FromFile(img)
                                        MDIPrincipal.BackgroundImageLayout = ImageLayout.Stretch
                                        Exit For
                                    End If
                                Next
                            Catch ex As Exception
                                MsgBox("Erro ao carregar imagem de fundo: " & ex.Message)
                            End Try
                        End If
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Erro ao acessar o banco de dados: " & ex.Message)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    ' Exibir a imagem de fundo selecionada no TemaComboBox
    Private Sub TemaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TemaComboBox.SelectedIndexChanged
        Try
            Dim imgPath As String = IO.Path.Combine(Application.StartupPath, "Imagens\Plano de Fundo", TemaComboBox.Text)
            If IO.File.Exists(imgPath) Then
                TemaPictureBox.Image = Image.FromFile(imgPath)
                TemaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar imagem de fundo: " & ex.Message)
        End Try
    End Sub

    ' Ajudar com instrução de nomeação de imagens
    Private Sub BtnAjudaImage_Click(sender As Object, e As EventArgs) Handles BtnAjudaImage.Click
        MsgBox("Salve a imagem com o nome inicial de ""planodefundo"", por exemplo ""planodefundo2""")
    End Sub

    ' Abrir a pasta de imagens
    Private Sub BtnProcurarPasta_Click(sender As Object, e As EventArgs) Handles BtnProcurarPasta.Click
        Try
            If MsgBox("Deseja abrir a pasta de Imagens\Plano de Fundo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Process.Start(Application.StartupPath & "\Imagens\Plano de Fundo")
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir a pasta: " & ex.Message)
        End Try
    End Sub

End Class
