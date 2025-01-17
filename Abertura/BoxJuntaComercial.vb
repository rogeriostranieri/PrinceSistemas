Imports System.Data.SqlClient

Public Class BoxJuntaComercial
    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

    ReadOnly Protocolo As String = FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text
    ReadOnly ProtocoloRedesim As String = FrmLegalizacao.ProtocoloREDESIMTextBox.Text

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
        AbrirJuntaLegalizacaoInterno()
    End Sub

    Private Sub BoxJuntaComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        AbrirJunta()
    End Sub
    Private Sub AchaCidade()
        If FrmLegalizacao.EndCidadeLabel2.Text = "" Then
            ' Selecionar a aba correta nos TabControles
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(4)
            FrmLegalizacao.TabControle.SelectTab(2)
            LblCidade.Text = FrmLegalizacao.EndEstadoTextBox.Text
            LblEstado.Text = FrmLegalizacao.EndCidadeTextBox.Text

        Else
            LblCidade.Text = FrmLegalizacao.EndCidadeLabel2.Text
            LblEstado.Text = FrmLegalizacao.EndEstadoLabel2.Text
        End If
    End Sub
    Private Sub AbrirJunta()
        Try

            ' Obter Estado e Cidade do formulário
            Dim estado As String = LblEstado.Text
            Dim cidade As String = LblCidade.Text

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

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir o navegador
                    If Not String.IsNullOrEmpty(siteJuntaUnificada) Then
                        ' Concatenar o protocolo à URL do site
                        ' Selecionar a aba 2 após a operação
                        FrmLegalizacao.TabControle.SelectTab(2)

                        Dim url As String = siteJuntaUnificada & "" & protocolo
                        System.Diagnostics.Process.Start(url)
                    Else
                        ' Se não for encontrado, mostrar mensagem de erro
                        MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                        FrmSites.Focus()
                    End If
                End Using
            End Using


            Me.Close()

        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao abrir o site da Junta Comercial, verificar o Estado e Cidade cadastrados ou informar o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Selecionar as abas em caso de erro
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(4)
        End Try
    End Sub

    Private Sub AbrirJuntaLegalizacaoInterno()
        Try
            ' Obter Estado e Cidade do formulário
            Dim estado As String = LblEstado.Text
            Dim cidade As String = LblCidade.Text

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

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir o navegador interno
                    If Not String.IsNullOrEmpty(siteJuntaUnificada) Then
                        ' Verificar se o formulário WebSiteGERAL já está aberto
                        'Dim siteForm As WebSiteGERAL
                        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                            ' Trazer o formulário já aberto para o foco
                            WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().First()
                            WebSiteGERAL.Focus()
                        Else
                            ' Criar uma nova instância do formulário WebSiteGERAL
                            'WebSiteGERAL = New WebSiteGERAL()
                            WebSiteGERAL.MdiParent = MDIPrincipal
                            WebSiteGERAL.Show()
                        End If

                        ' Verifique se o controle WebView está disponível e atribua a URL
                        If WebSiteGERAL.WebView IsNot Nothing Then
                            ' Selecionar a aba 2 após a operação
                            FrmLegalizacao.TabControle.SelectTab(2)
                            ' Concatenar o protocolo à URL do site
                            WebSiteGERAL.WebView.Source = New Uri(siteJuntaUnificada & "" & Protocolo)
                            WebSiteGERAL.Focus()
                        Else
                            MessageBox.Show("O controle WebView não foi encontrado no formulário WebSiteGERAL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ' Se não for encontrado, mostrar mensagem de erro
                        MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                        FrmSites.Focus()
                    End If
                End Using
            End Using


            Me.Close()

        Catch ex As Exception
            ' Tratamento de erro
            MessageBox.Show("Erro ao abrir o site da Junta Comercial, verificar o Estado e Cidade cadastrados ou informar o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Selecionar as abas em caso de erro
            FrmLegalizacao.TabControle.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(4)
        End Try
    End Sub

    Private Sub BtnCopiaPRP_Click(sender As Object, e As EventArgs) Handles BtnCopiaPRP.Click
        If ComboBoxEscolhaProtocolo.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um protocolo ao lado.")
            Exit Sub
        End If

        Dim protocoloSelecionado As String = ComboBoxEscolhaProtocolo.SelectedItem.ToString()

        Try
            Select Case protocoloSelecionado
                Case "Empresa Fácil"
                    FrmLegalizacao.TabControle.SelectTab(2)
                    Clipboard.SetText(Protocolo)
                    MessageBox.Show("Protocolo copiado para a área de transferência")
                Case "Redesim"
                    FrmLegalizacao.TabControle.SelectTab(3)
                    Clipboard.SetText(ProtocoloRedesim)
                    MessageBox.Show("Protocolo copiado para a área de transferência")
            End Select
            Me.Focus()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro inesperado: " & ex.Message)
        End Try
    End Sub
    Private Sub BoxJuntaComercial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adiciona as opções ao ComboBox
        ComboBoxEscolhaProtocolo.Items.Add("Empresa Fácil")
        ComboBoxEscolhaProtocolo.Items.Add("Redesim")

        ' Seleciona o primeiro item por padrão (índice 0)
        ComboBoxEscolhaProtocolo.SelectedIndex = 0
        ' Ou selecione um item específico pelo valor:
        ' ComboBoxEscolhaProtocolo.SelectedItem = "Redesim"
        Try
            AchaCidade()

        Catch ex As Exception
            MessageBox.Show("Erro ao encontrar a cidade e estado, favor preencher no cadastro da empresa, erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
