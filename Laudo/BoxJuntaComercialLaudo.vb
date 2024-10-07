Imports System.Data.SqlClient

Public Class BoxJuntaComercialLaudo
    ReadOnly Protocolo As String = FrmAlvara.NlaudoTextBox.Text
    Private connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BoxJuntaComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BoxJuntaComercialLaudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adicionar opções ao ComboBox
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Junta Comercial")
        ComboBox1.Items.Add("Consulta Alvara Antigo")
        ComboBox1.Items.Add("Consulta Alvara Novo")
        ComboBox1.Items.Add("Solicitar Alvara Antigo")
        ComboBox1.Items.Add("Solicitar Alvara Novo")
        ComboBox1.Items.Add("Protocolar Prefeitura")

        ' Verificar se o formulário FrmAlvara está aberto
        Dim frmAlvara = Application.OpenForms().OfType(Of FrmAlvara)().FirstOrDefault()

        If frmAlvara IsNot Nothing Then
            ' Verificar o valor do ModeloSistemaComboBox no FrmAlvara
            Dim modeloSistema As String = frmAlvara.ModeloSistemaComboBox.Text.ToLower()
            Dim situacao As String = frmAlvara.SituacaoComboBox.Text.ToLower()

            ' Configurar seleção inicial do ComboBox1 conforme o modelo do sistema
            If modeloSistema.Contains("junta comercial") Or modeloSistema.Contains("empresa fácil") Then
                ComboBox1.SelectedItem = "Junta Comercial"
            ElseIf modeloSistema.Contains("alvará antigo") Or modeloSistema.Contains("alvará manual") Then
                ComboBox1.SelectedItem = "Consulta Alvara Antigo"
            ElseIf modeloSistema.Contains("alvará online") Then
                ComboBox1.SelectedItem = "Consulta Alvara Novo"
            ElseIf modeloSistema.Contains("mei") Then
                ComboBox1.SelectedItem = "Protocolar Prefeitura"
            Else
                ' Seleção padrão caso nenhuma condição seja atendida
                ComboBox1.SelectedIndex = 0
            End If

            ' Verificar se o SituacaoComboBox contém o texto "Não iniciado"
            If situacao = "não iniciado" Then
                ' Ajustar o ComboBox1 para Solicitar Alvara conforme o modelo do sistema
                If modeloSistema.Contains("alvará antigo") Or modeloSistema.Contains("alvará manual") Then
                    ComboBox1.SelectedItem = "Solicitar Alvara Antigo"
                ElseIf modeloSistema.Contains("alvará novo") Or modeloSistema.Contains("alvará unificado") Then
                    ComboBox1.SelectedItem = "Solicitar Alvara Novo"
                End If
            End If

            ' Verificar se o ButtonSolicitar do FrmAlvara está configurado como "Solicitar"
            If frmAlvara.ButtonSolicitar.Text = "Solicitar" Then
                If modeloSistema.Contains("alvará antigo") Or modeloSistema.Contains("alvará manual") Then
                    ComboBox1.SelectedItem = "Solicitar Alvara Antigo"
                ElseIf modeloSistema.Contains("alvará novo") Or modeloSistema.Contains("alvará unificado") Then
                    ComboBox1.SelectedItem = "Solicitar Alvara Novo"
                End If
            End If

        Else
            ' Se o FrmAlvara não estiver aberto, mostrar mensagem de erro
            MessageBox.Show("O formulário FrmAlvara não está aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Definir seleção padrão do ComboBox
            ComboBox1.SelectedIndex = 0
        End If
    End Sub



    '///////////////////////////////////////////


    ' Função genérica para abrir links baseado na seleção e no botão clicado
    Private Sub AbrirSite(interno As Boolean)
        Try
            ' Selecionar a aba correta no formulário FrmAlvara
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

            ' Obter a seleção do ComboBox1 para definir o campo da consulta SQL
            Dim campoConsulta As String = String.Empty
            Select Case ComboBox1.Text
                Case "Junta Comercial"
                    campoConsulta = "SiteJuntaUnificada"
                Case "Consulta Alvara Antigo"
                    campoConsulta = "SiteAlvara1"
                Case "Consulta Alvara Novo"
                    campoConsulta = "SiteAlvara2"
                Case "Solicitar Alvara Antigo"
                    campoConsulta = "SiteAlvaraPedido1"
                Case "Solicitar Alvara Novo"
                    campoConsulta = "SiteAlvaraPedido2"
                Case "Protocolar Prefeitura"
                    campoConsulta = "SitePrefProtocolo"
                Case Else
                    MessageBox.Show("Seleção inválida no ComboBox1.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select

            ' Definir a query para buscar o site baseado no Estado e Cidade, e no campo selecionado
            Dim query As String = $"SELECT {campoConsulta} FROM Sites WHERE EstadoSigla = @estado AND Cidade = @cidade"

            ' Usar a conexão SQL para realizar a consulta
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@estado", estado)
                    command.Parameters.AddWithValue("@cidade", cidade)

                    ' Executar a consulta e obter o site
                    Dim siteJuntaUnificada As String = Convert.ToString(command.ExecuteScalar())

                    ' Se o site foi encontrado, concatenar o Protocolo e abrir o link
                    If Not String.IsNullOrEmpty(siteJuntaUnificada) Then
                        ' Concatenar o protocolo à URL do site
                        Dim url As String = siteJuntaUnificada & "" & Protocolo

                        If interno Then
                            ' Abrir no WebSiteGERAL se for interno
                            AbrirNoNavegadorInterno(url)
                        Else
                            ' Abrir no navegador externo se for externo
                            System.Diagnostics.Process.Start(url)
                        End If
                    Else
                        MessageBox.Show("Estado ou cidade não encontrados na tabela Sites.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        FrmSites.Show()
                    End If
                End Using
            End Using

            ' Selecionar a aba 1 após a operação
            FrmAlvara.TabAlvara.SelectTab(2)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o site da Junta Comercial, verificar o Estado e Cidade cadastrados ou informar o administrador. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmAlvara.TabAlvara.SelectTab(0)
            FrmAlvara.TabControl2.SelectTab(1)
        End Try
    End Sub


    ' Função para abrir o WebSiteGERAL
    Private Sub AbrirNoNavegadorInterno(url As String)
            Try
                ' Verificar se o WebSiteGERAL está aberto
                If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                    WebSiteGERAL.Focus()
                Else
                    ' Abrir o WebSiteGERAL se não estiver aberto
                    WebSiteGERAL.MdiParent = MDIPrincipal
                    WebSiteGERAL.Show()
                End If

                ' Navegar para a URL no controle WebView do WebSiteGERAL
                WebSiteGERAL.WebView.Source = New Uri(url)
                WebSiteGERAL.Focus()
            Catch ex As Exception
                MessageBox.Show("Erro ao abrir o site no navegador interno. " & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ' Evento do botão BtnExterno para abrir no navegador externo
        Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
            AbrirSite(False) ' Abrir no navegador externo
        End Sub

        ' Evento do botão BtnInterno para abrir no WebSiteGERAL
        Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
            AbrirSite(True) ' Abrir no navegador interno
        End Sub


End Class


