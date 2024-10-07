Imports System.Data.SqlClient

Public Class FrmProtegeFacil

    Private estado As String
    Private cidade As String
    Private NLaudo As String 'NlaudoTextBox

    Private Sub FrmProtegeFacil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar o ComboBox com opções
        ComboBox1.Items.AddRange(New String() {"Acompanhar", "Solicitar", "ProtegeFácil"})
        ComboBox1.SelectedIndex = 0 ' Definir um valor padrão

        Try
            ' Verificar se o formulário FrmAlvara está aberto e selecionar as abas corretas
            FrmAlvara.TabAlvara.SelectTab(0) ' Selecionar a primeira aba do TabAlvara
            FrmAlvara.TabControl2.SelectTab(1) ' Selecionar a segunda aba do TabControl2
            FrmAlvara.TabAlvara.SelectTab(1) ' Selecionar a segunda aba do TabAlvara

            ' Acessar o controle `EndEstadoTextBox`, `EndCidadeTextBox` e `NLaudoTextBox` e pegar o valor do Text
            estado = FrmAlvara.EndEstadoTextBox.Text
            cidade = FrmAlvara.EndCidadeTextBox.Text
            NLaudo = FrmAlvara.NlaudoTextBox.Text

            ' Verificar se as variáveis foram preenchidas
            If String.IsNullOrWhiteSpace(estado) Or String.IsNullOrWhiteSpace(cidade) Then
                MessageBox.Show("O Estado ou Cidade não estão preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            ' Tratar erro se o formulário ou abas não estiverem acessíveis
            MessageBox.Show("Formulário Alvara/Laudo não está aberto! " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    ' Botão para abrir no navegador interno (WebView no WebSiteGERAL)
    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        AbrirURL(False)
        Me.Close()
    End Sub

    ' Botão para abrir no navegador externo
    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        AbrirURL(True)
        Me.Close()
    End Sub

    ' Método principal para abrir a URL no navegador interno ou externo
    Private Sub AbrirURL(isExternal As Boolean)
        Try
            ' Verificar se os valores de Estado e Cidade não estão vazios
            If String.IsNullOrEmpty(estado) OrElse String.IsNullOrEmpty(cidade) Then
                MsgBox("Por favor, preencha os campos de Estado e Cidade corretamente.")
                Return
            End If

            ' Determinar se é "Solicitar" ou "Acompanhar" com base no ComboBox
            Dim tipoSolicitacao As String = ComboBox1.SelectedItem.ToString()

            ' Verificar se o tipo de solicitação é "Solicitar" e se o ModeloSistemaComboBox contém palavras-chave específicas
            Dim modeloSistema As String = FrmAlvara.ModeloSistemaComboBox.Text
            Dim colunaConsulta As String

            If tipoSolicitacao = "Solicitar" AndAlso (modeloSistema.Contains("Empresa Fácil") OrElse modeloSistema.Contains("Unificado") OrElse modeloSistema.Contains("Junta Comercial")) Then
                ' Se o tipo de solicitação for "Solicitar" e contiver palavras-chave específicas, usar a coluna "BombeiroREDESIM"
                colunaConsulta = "BombeiroREDESIM"
            Else
                ' Caso contrário, usar as colunas padrões
                colunaConsulta = If(tipoSolicitacao = "Solicitar", "BombeiroSolicita", "BombeiroConsulta")
            End If

            ' Conectar ao banco de dados para buscar a URL correspondente
            Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
            Dim query As String = $"SELECT {colunaConsulta} FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"
            Dim url As String = String.Empty

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@estado", estado)
                    command.Parameters.AddWithValue("@cidade", cidade)

                    connection.Open()
                    url = TryCast(command.ExecuteScalar(), String)
                End Using
            End Using

            ' Verificar se foi retornada uma URL
            If String.IsNullOrEmpty(url) Then
                MsgBox("URL não encontrada para a cidade e estado informados.")
                Try
                    ' Verificar se o formulário FrmAlvara está aberto e selecionar as abas corretas
                    FrmAlvara.TabAlvara.SelectTab(0) ' Selecionar a primeira aba do TabAlvara
                    FrmAlvara.TabControl2.SelectTab(1) ' Selecionar a segunda aba do TabControl2
                Catch ex As Exception
                    ' Tratar erro se o formulário ou abas não estiverem acessíveis
                    MessageBox.Show("Formulário Alvara/Laudo não está aberto! " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End Try
                'Return
                Me.Close()
            End If

            ' Adicionar o valor de NLaudo à URL se for uma solicitação com modelo específico
            If tipoSolicitacao = "Solicitar" AndAlso colunaConsulta = "BombeiroREDESIM" Then
                url &= NLaudo
            End If

            ' Abrir a URL no formulário interno ou no navegador externo com base na escolha
            If isExternal Then
                ' Abrir no navegador externo
                Process.Start(url)
            Else
                ' Abrir no WebSiteGERAL internamente
                AbrirFormularioInterno(url)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao abrir o site: " & ex.Message)
        End Try
    End Sub


    ' Método auxiliar para abrir o formulário WebSiteGERAL com a URL fornecida
    Private Sub AbrirFormularioInterno(url As String)
        ' Verifica se o formulário WebSiteGERAL já está aberto
        Dim form As WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().SingleOrDefault()

        If form Is Nothing Then
            ' Se não estiver aberto, cria uma nova instância do formulário
            form = New WebSiteGERAL With {
                .MdiParent = MDIPrincipal
            }
            form.WebView.Source = New Uri(url)
            form.Show()
        Else
            ' Se já estiver aberto, apenas foca no formulário e atualiza a URL
            form.Focus()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri(url)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Para o alvará na residência do socio não precisa dos bombeiros, so quando não é na casa do socio que precisa dos bombeiros")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("Para pedir isenção para lugar sem fins lucrativos precisa: dizer no topo da mgs: 'Ao corpo de bombeiros' + documento de Comprovatório da isenção (pode ser ata, estatuto e CNPJ apenas ou outro documento que prova que é sem fins lucrativos) + número do pedido do site + procuração.")
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
