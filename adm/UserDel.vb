Imports System.Data.SqlClient
Public Class UserDel
    'Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755

    Private Sub BtnNoMostrar_Click(sender As Object, e As EventArgs) Handles BtnNoMostrar.Click
        'Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        'select count(*) from Login where Usuario=@Usuario and Senha=@Senha"

        'verificar login e senha e preencher com nomedousuario o ComboBoxUser
        Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        Dim comando As New SqlCommand("select count(*) from Login where Usuario=@Usuario and Senha=@Senha", conexao)
        comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = UsernameTextBox.Text
        comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = PasswordTextBox.Text
        Dim contador As Integer
        Try
            conexao.Open()
            contador = comando.ExecuteScalar()
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If contador = 1 Then
            'preencher combobox com todos usuarios da tabela    
            Dim conexao2 As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
            Dim comando2 As New SqlCommand("select Usuario from Login", conexao2)
            Dim leitor As SqlDataReader
            Try
                conexao2.Open()
                leitor = comando2.ExecuteReader()
                While leitor.Read()
                    ComboBoxUser.Items.Add(leitor("Usuario"))
                End While
                conexao2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("Usuário ou senha incorretos")
        End If



    End Sub

    Private Sub ComboBoxUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUser.SelectedIndexChanged
        'ao selecionar um usuario do ComboBoxUser, preencher o TextBoxNome com o nomeCompleto
        Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        Dim comando As New SqlCommand("select NomeCompleto from Login where Usuario=@Usuario", conexao)
        comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = ComboBoxUser.Text
        Dim nomeCompleto As String
        'mostrar o nomeCompleto no TextBoxNome de acordo com o usuario selecionado no ComboBoxUser
        'se estiver vazio , mostrar mensagem de erro
        Try
            conexao.Open()
            nomeCompleto = comando.ExecuteScalar()
            conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If nomeCompleto = "" Then
            'MsgBox("Usuário não encontrado")
        Else
            TextBoxNome.Text = nomeCompleto
        End If



    End Sub

    Private Sub BtnApagar_Click(sender As Object, e As EventArgs) Handles BtnApagar.Click
        'ao selecionar usuario no ComboBoxUser apagar o usuario da tabela Login
        Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        Dim comando As New SqlCommand("delete from Login where Usuario=@Usuario", conexao)
        comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = ComboBoxUser.Text
        Try
            'perguntar se deseja apagar o usuario
            If MsgBox("Deseja apagar o usuario " & ComboBoxUser.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                MsgBox("Usuário apagado com sucesso")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'apagar o usuario do combobox
        ComboBoxUser.Items.Remove(ComboBoxUser.Text)
        'limpar os textbox
        TextBoxNome.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Clear()
        'limpar ComboBoxUser
        ComboBoxUser.Items.Clear()
    End Sub
End Class
