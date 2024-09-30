Imports System.Data.SqlClient

Public Class BoxJuntaComercialLaudo
    ReadOnly Protocolo As String = FrmAlvara.NlaudoTextBox.Text

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        'mgsbox EM TESTE
        MsgBox("Em desenvolvimento")
    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        AbrirJuntaInterno()
        FrmAlvara.ALVARAEsconderAtalhosNavegadorPadrao()
    End Sub

    Private Sub BoxJuntaComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        AbrirJuntaAlvara()
    End Sub

    Private Sub AbrirJuntaAlvara()
        Try
            ' Selecionar a aba correta nos TabControles do FrmAlvara
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)

            ' Obter Estado e Cidade do formulário FrmAlvara
            Dim estado As String = FrmAlvara.EndEstadoTextBox.Text
            Dim cidade As String = FrmAlvara.EndCidadeTextBox.Text

            ' Certifique-se de que o estado e cidade não estão vazios
            If String.IsNullOrEmpty(estado) Or String.IsNullOrEmpty(cidade) Then
                MessageBox.Show("Estado ou cidade não podem estar vazios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Connection string para acessar o banco de dados
            Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

            ' Definir a query para buscar o site baseado no Estado e Cidade
            Dim query As String = "SELECT SiteJuntaUnificada FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"

            ' Usar a conexão SQL para realizar a consulta
            Using connection As New SqlConnection(connectionString)
                ' Abrir a conexão
                connection.Open()

                ' Usar comando SQL com parâmetros para evitar SQL Injection
                Using command As New SqlCommand(query, connection)
                    ' Adicionar os parâmetros estado e cidade
                    command.Parameters.AddWithValue("@estado", estado)
                    command.Parameters.AddWithValue("@cidade", cidade)

                    ' Executar a consulta e obter o site
                    Dim siteJuntaUnificada As String = Convert.ToString(command.ExecuteScalar())

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir o navegador
                    If Not String.IsNullOrEmpty(siteJuntaUnificada) Then
                        ' Concatenar o protocolo à URL do site
                        Dim url As String = siteJuntaUnificada & "" & Protocolo
                        System.Diagnostics.Process.Start(url)
                    Else
                        ' Se não for encontrado, mostrar mensagem de erro
                        MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                    End If
                End Using
            End Using

            ' Selecionar a aba 1 após a operação
            FrmAlvara.TabAlvara.SelectTab(2)
            Me.Close()

        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao abrir o site da Junta Comercial, verificar o Estado e Cidade cadastrados ou informar o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Selecionar as abas em caso de erro
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)
        End Try
    End Sub


    Private Sub AbrirJuntaInterno()
        Try
            ' Selecionar a aba correta nos TabControles do FrmAlvara
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)

            ' Obter Estado e Cidade do formulário FrmAlvara
            Dim estado As String = FrmAlvara.EndEstadoTextBox.Text
            Dim cidade As String = FrmAlvara.EndCidadeTextBox.Text

            ' Connection string para acessar o banco de dados
            Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

            ' Definir a query para buscar o site baseado no Estado e Cidade
            Dim query As String = "SELECT SiteJuntaUnificada FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"

            ' Usar a conexão SQL para realizar a consulta
            Using connection As New SqlConnection(connectionString)
                ' Abrir a conexão
                connection.Open()

                ' Usar comando SQL com parâmetros para evitar SQL Injection
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@estado", estado)
                    command.Parameters.AddWithValue("@cidade", cidade)

                    ' Executar a consulta e obter o site
                    Dim siteJuntaUnificada As String = Convert.ToString(command.ExecuteScalar())

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir no navegador interno
                    If Not String.IsNullOrEmpty(siteJuntaUnificada) Then
                        ' Verificar se o navegador interno está aberto
                        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                            ' Traz o WebSiteGERAL para o foco
                            WebSiteGERAL.Focus()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                        Else
                            ' Abre o WebSiteGERAL se não estiver aberto
                            ' Dim siteForm As New WebSiteGERAL()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                            WebSiteGERAL.Show()
                        End If

                        ' Concatenar o protocolo à URL do site e abrir no controle WebView do WebSiteGERAL
                        WebSiteGERAL.WebView.Source = New Uri(siteJuntaUnificada & Protocolo)

                        WebSiteGERAL.Focus()
                    Else
                        ' Se não for encontrado, mostrar mensagem de erro
                        MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                    End If
                End Using
            End Using

            ' Selecionar a aba 1 após a operação
            FrmAlvara.TabAlvara.SelectTab(2)
            Me.Close()

        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao abrir o site da Junta Comercial, verificar o Estado e Cidade cadastrados ou informar o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Selecionar as abas em caso de erro
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)
        End Try
    End Sub

    Private Sub BtnAlvaraInterno_Click(sender As Object, e As EventArgs) Handles BtnAlvaraInterno.Click
        Try
            ' Selecionar a aba correta nos TabControles do FrmAlvara
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)

            ' Obter o estado, cidade e o modelo de sistema do formulário FrmAlvara
            Dim estado As String = FrmAlvara.EndEstadoTextBox.Text
            Dim cidade As String = FrmAlvara.EndCidadeTextBox.Text
            Dim modeloSistema As String = FrmAlvara.ModeloSistemaComboBox.Text

            ' Connection string para acessar o banco de dados
            Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

            ' Definir a query baseada no modelo do sistema
            Dim query As String = ""
            If modeloSistema = "Alvará Antigo" Then
                query = "SELECT SiteAlvara1 FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"
            ElseIf modeloSistema = "Alvará Online" Then
                query = "SELECT SiteAlvara2 FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"
            Else
                MessageBox.Show("Modelo de sistema desconhecido. Por favor, verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Usar a conexão SQL para realizar a consulta
            Using connection As New SqlConnection(connectionString)
                ' Abrir a conexão
                connection.Open()

                ' Usar comando SQL com parâmetros para evitar SQL Injection
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@estado", estado)
                    command.Parameters.AddWithValue("@cidade", cidade)

                    ' Executar a consulta e obter o site
                    Dim siteAlvara As String = Convert.ToString(command.ExecuteScalar())

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir o navegador
                    If Not String.IsNullOrEmpty(siteAlvara) Then
                        ' Concatenar o protocolo à URL do site
                        Dim url As String = siteAlvara '& "" & Protocolo
                        ' Copiar o número do laudo para a área de transferência
                        Clipboard.SetText(Protocolo)
                        MessageBox.Show("Número do Laudo Copiado = " & Protocolo, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                            ' Traz o WebSiteGERAL para o foco
                            WebSiteGERAL.Focus()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                        Else
                            ' Abre o WebSiteGERAL se não estiver aberto
                            ' Dim siteForm As New WebSiteGERAL()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                            WebSiteGERAL.Show()
                        End If

                        ' Concatenar o protocolo à URL do site e abrir no controle WebView do WebSiteGERAL
                        WebSiteGERAL.WebView.Source = New Uri(siteAlvara)

                        WebSiteGERAL.Focus()

                    Else
                        ' Se não for encontrado, mostrar mensagem de erro
                        MessageBox.Show("Site para Alvará não encontrado na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                    End If
                End Using
            End Using

            ' Selecionar a aba 1 após a operação
            FrmAlvara.TabAlvara.SelectTab(2)

        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao abrir o site do Alvará. Verifique o Estado e Cidade cadastrados ou informe o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Selecionar as abas em caso de erro
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)
        End Try
        FrmAlvara.ALVARAEsconderAtalhosNavegadorPadrao()
    End Sub

    Private Sub BtnAlvaraExterno_Click(sender As Object, e As EventArgs) Handles BtnAlvaraExterno.Click
        Try
            ' Obter o estado, cidade e o modelo de sistema do formulário FrmAlvara
            Dim estado As String = FrmAlvara.EndEstadoTextBox.Text
            Dim cidade As String = FrmAlvara.EndCidadeTextBox.Text
            Dim modeloSistema As String = FrmAlvara.ModeloSistemaComboBox.Text

            ' Connection string para acessar o banco de dados
            Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

            ' Definir a query baseada no modelo do sistema
            Dim query As String = ""
            If modeloSistema = "Alvará Antigo" Then
                query = "SELECT SiteAlvara1 FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"
            ElseIf modeloSistema = "Alvará Online" Then
                query = "SELECT SiteAlvara2 FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"
            Else
                MessageBox.Show("Modelo de sistema desconhecido. Por favor, verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Usar a conexão SQL para realizar a consulta
            Using connection As New SqlConnection(connectionString)
                ' Abrir a conexão
                connection.Open()

                ' Usar comando SQL com parâmetros para evitar SQL Injection
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@estado", estado)
                    command.Parameters.AddWithValue("@cidade", cidade)

                    ' Executar a consulta e obter o site
                    Dim siteAlvara As String = Convert.ToString(command.ExecuteScalar())

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir o navegador externo
                    If Not String.IsNullOrEmpty(siteAlvara) Then
                        ' Concatenar o protocolo à URL do site
                        Dim url As String = siteAlvara '& "" & Protocolo
                        ' Copiar o número do laudo para a área de transferência
                        Clipboard.SetText(Protocolo)
                        MessageBox.Show("Número do Laudo Copiado = " & Protocolo, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        ' Abrir o navegador externo
                        System.Diagnostics.Process.Start(url)
                    Else
                        ' Se não for encontrado, mostrar mensagem de erro
                        MessageBox.Show("Site para Alvará não encontrado na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                    End If
                End Using
            End Using

        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao abrir o site do Alvará. Verifique o Estado e Cidade cadastrados ou informe o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BoxJuntaComercialLaudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nao tem nada
    End Sub
End Class