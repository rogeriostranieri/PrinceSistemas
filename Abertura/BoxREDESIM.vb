Imports System.Data.SqlClient

Public Class BoxREDESIM
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


    Private Sub BoxREDESIM_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla pressionada é o ESC
        If e.KeyCode = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
        End If
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
                    ' Verificar se o Protocolo não está vazio ou nulo
                    If Not String.IsNullOrEmpty(Protocolo) Then
                        Clipboard.SetText(Protocolo)
                        ' MessageBox.Show("Protocolo copiado para a área de transferência")
                    Else
                        MessageBox.Show("O protocolo 'Empresa Fácil' está vazio.")
                    End If
                Case "Redesim"
                    FrmLegalizacao.TabControle.SelectTab(3)
                    ' Verificar se o ProtocoloRedesim não está vazio ou nulo
                    If Not String.IsNullOrEmpty(ProtocoloRedesim) Then
                        Clipboard.SetText(ProtocoloRedesim)
                        ' MessageBox.Show("Protocolo copiado para a área de transferência")
                    Else
                        MessageBox.Show("O protocolo 'Redesim' está vazio.")
                    End If
            End Select

            Me.Focus()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro inesperado: " & ex.Message)
        End Try
    End Sub


    ' Evento de carregamento do formulário
    Private Sub BoxREDESIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adiciona as opções ao ComboBox
        ComboBoxEscolhaProtocolo.Items.Add("Empresa Fácil")
        ComboBoxEscolhaProtocolo.Items.Add("Redesim")
        ComboBoxEscolhaProtocolo.SelectedIndex = -1

        ' Adiciona as opções ao ComboBox1
        ComboBox1.Items.Add("Consultar DBE")
        ComboBox1.Items.Add("Abrir CNPJ")
        ComboBox1.Items.Add("Meu CNPJ")
        ComboBox1.SelectedIndex = -1
        Try
            AchaCidade()

        Catch ex As Exception
            MessageBox.Show("Erro ao encontrar a cidade e estado, favor preencher no cadastro da empresa, erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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



    ' Função genérica para obter o site correto com base no ComboBox1
    Private Function ObterSiteProtocolo() As String

        ' Obter Estado e Cidade do formulário
        Dim estado As String = LblEstado.Text
        Dim cidade As String = LblCidade.Text

        Dim siteColumn As String = ""

        ' Definir a coluna do site no banco de dados com base na seleção do ComboBox1
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Consultar DBE"
                siteColumn = "SiteREDESIMProtocolo"
            Case "Abrir CNPJ"
                siteColumn = "SiteREDESIMAbrirCNPJ"
            Case "Meu CNPJ"
                siteColumn = "SiteREDESIMMeuCNPJ"
            Case Else
                siteColumn = "SiteREDESIMProtocolo" ' Valor padrão
        End Select

        ' Connection string para acessar o banco de dados
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = $"SELECT {siteColumn} FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"

        ' Consultar o banco de dados para obter o site correto
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@estado", estado)
                command.Parameters.AddWithValue("@cidade", cidade)

                ' Retornar o site encontrado
                Dim site As String = Convert.ToString(command.ExecuteScalar())
                Return If(String.IsNullOrEmpty(site), "", site)
            End Using
        End Using
    End Function

    ' Evento de clique do botão para abrir no navegador externo
    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        Try
            Dim site As String = ObterSiteProtocolo()
            If Not String.IsNullOrEmpty(site) Then
                ' Concatenar o Protocolo ao site, caso necessário
                Dim url As String = site & ProtocoloRedesim
                ' Abrir no navegador externo
                System.Diagnostics.Process.Start(url)

            Else
                MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                FrmSites.Show()
                FrmSites.Focus()
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o site no navegador externo: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento de clique do botão para abrir no navegador interno (WebView)
    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        Try
            Dim site As String = ObterSiteProtocolo()
            If Not String.IsNullOrEmpty(site) Then
                ' Verificar se o formulário WebSiteGERAL já está aberto
                If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                    WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().First()
                    WebSiteGERAL.Focus()
                Else
                    WebSiteGERAL = New WebSiteGERAL()
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    WebSiteGERAL.Show()
                    Me.Close()
                End If

                ' Concatenar o Protocolo ao site e abrir no WebView
                If WebSiteGERAL.WebView IsNot Nothing Then
                    WebSiteGERAL.WebView.Source = New Uri(site & ProtocoloRedesim)
                    WebSiteGERAL.Focus()
                Else
                    MessageBox.Show("O controle WebView não foi encontrado no formulário WebSiteGERAL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                FrmSites.Show()
                FrmSites.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o site no navegador interno: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class