Imports System.Data.SqlClient
Imports System.Globalization

Public Class UserAltDados
    Private Sub BtnNomeFinal_Click(sender As Object, e As EventArgs) Handles BtnNomeFinal.Click
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
                    MsgBox("Dados alterados com sucesso")
                    'Mudar dados da MDIPrincipal buscalogin
                    MDIAtualiza()

                Else
                    MsgBox("Usuário ou senha incorretos")
                End If
            End Using
        End Using



    End Sub

    Private Sub UserAltDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adicionar no TemaComboBox, todas imagens com nome iniciando "planodefundo" da pasta "...\Imagens\Plano de Fundo"
        'For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
        Try
            For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
                Dim imgName As String = IO.Path.GetFileName(img)
                If imgName.StartsWith("planodefundo") Then
                    TemaComboBox.Items.Add(imgName)
                End If

            Next
        Catch ex As Exception
            MsgBox("Erro ao carregar imagens")
        End Try

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        'limpar campos
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        NomeCompletoTextBox.Text = ""
        TemaComboBox.Text = ""

    End Sub

    Private Sub BtnMostrarDados_Click(sender As Object, e As EventArgs) Handles BtnMostrarDados.Click
        'mostrar NomeCompletoTextBox, TemaComboBox.Text de acordo com usuario e senha
        Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim sql As String = "select * from Login where Usuario=@Usuario and Senha=@Senha"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
                Dim reader = cmd.ExecuteReader()
                If reader.Read() Then
                    NomeCompletoTextBox.Text = reader("NomeCompleto")
                    TemaComboBox.Text = reader("Tema")
                Else
                    MsgBox("Usuário ou senha incorretos")
                End If
            End Using
        End Using
    End Sub


    Private Sub MDIAtualiza()
        'ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755
        'conectar e modificar os label conforme o banco de dados, tabela LOGIN usuario do formulario LOGIN, pegando seu usuario logado e modifica os label tema e nome completo 
        Dim conexao As SqlConnection
        Dim comando As SqlCommand
        Dim da As SqlDataAdapter
        Dim dr As SqlDataReader

        conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        conexao.Open()
        comando = New SqlCommand("SELECT * FROM LOGIN WHERE USUARIO = '" & Login.txtUsername.Text & "'", conexao)
        da = New SqlDataAdapter(comando)
        dr = comando.ExecuteReader()
        'pegar nome completo e tema da tabela e modificar LbTema e lblnomecompleto
        While dr.Read()
            MDIPrincipal.LblNomeCompleto.Text = "Bem vindo Sr(a). " & dr("NomeCompleto") & "!"
            MDIPrincipal.LbTema.Text = dr("Tema")
            'mudar lblnomecompleto e lbtema para cor branca
            MDIPrincipal.LblNomeCompleto.ForeColor = Color.White
            MDIPrincipal.LbTema.ForeColor = Color.Black

            Try
                'pegar pnd da pasta \Imagens\Plano de Fundo\ e coloca como plano de fundo
                'BackgroundImage = Image.FromFile("\Imagens\Plano de Fundo\" & dr("Tema")) '& ".png")

                For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo\")
                    Dim imgName As String = IO.Path.GetFileName(img)
                    If imgName.StartsWith(dr("Tema")) Then
                        MDIPrincipal.BackgroundImage = Image.FromFile(img)
                        MDIPrincipal.BackgroundImageLayout = ImageLayout.Stretch
                    End If
                Next

            Catch ex As Exception
                MsgBox("Erro ao carregar imagem de fundo")
                conexao.Close()
            End Try

        End While
        conexao.Close()
    End Sub

    Private Sub TemaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TemaComboBox.SelectedIndexChanged
        'mostra a imagem no TemaPictureBox
        Try
            For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
                Dim imgName As String = IO.Path.GetFileName(img)
                If imgName.StartsWith(TemaComboBox.Text) Then
                    TemaPictureBox.Image = Image.FromFile(img)
                    TemaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Next
        Catch ex As Exception
            MsgBox("Erro ao carregar imagem de fundo")
        End Try
    End Sub
End Class
