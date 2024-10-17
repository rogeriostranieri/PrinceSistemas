Imports System.Data.SqlClient
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq

Public Class BoxConsultaCNPJEmpresa
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        ' Verifica se o formulário FrmLegalizacao está aberto
        If Not IsFormOpen("FrmLegalizacao") Then
            MessageBox.Show("O formulário FrmLegalizacao está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            FrmLegalizacao.Visible = True
        End If

        Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        System.Diagnostics.Process.Start("https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp?cnpj=" + CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        Me.Close()

    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        ' Verifica se o formulário FrmLegalizacao está aberto
        If Not IsFormOpen("FrmLegalizacao") Then
            MessageBox.Show("O formulário FrmLegalizacao está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            FrmLegalizacao.Visible = True
        End If

        Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp?cnpj=" + CNPJ)
            Me.Close()
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://solucoes.receita.fazenda.gov.br/Servicos/cnpjreva/cnpjreva_Solicitacao.asp?cnpj=" + CNPJ)
            Me.Close()
        End If

    End Sub

    Private Async Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Try

            ' Verifica se o formulário FrmLegalizacao está aberto
            If Not IsFormOpen("FrmLegalizacao") Then
                MessageBox.Show("O formulário FrmLegalizacao está fechado. Por favor, abra-o para continuar.", "Formulário Fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                FrmLegalizacao.Visible = True
            End If


            If FrmLegalizacao.CNPJMaskedTextBox.Text = "" Then
                ' mensagme vazio CNPJ
                MessageBox.Show("O campo CNPJ esta vazio, nao sendo possivel continuar!", "CNPJ não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            ElseIf Len(FrmLegalizacao.CNPJMaskedTextBox.Text.Replace(".", "").Replace("/", "").Replace("-", "")) < 14 Then
                ' Mensagem de CNPJ incompleto
                MessageBox.Show("O CNPJ informado está incompleto. Verifique e preencha corretamente.", "CNPJ incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else

                ' Chamar o método de verificação
                VerificarCNPJ(FrmLegalizacao.CNPJMaskedTextBox.Text)


                'pergunta se deseja importar o CNPJ
                Dim result As DialogResult = MessageBox.Show("Deseja importar dados cadastrais do CNPJ? Isto irá sobrepor os dados existentes...", "Importar CNPJ", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    'mudar lavel para AGUARDE...
                    BtnImportar.Text = "AGUARDE..."
                    BtnImportar.Enabled = False

                    'pegar CNPJ
                    'FrmLegalizacao.CNPJMaskedTextBox.Text
                    'consulta https://www.receitaws.com.br/v1/cnpj/
                    Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
                    Dim CNPJ_Limpo As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

                    'conectar no site https://www.receitaws.com.br/v1/cnpj/
                    Dim client As New HttpClient
                    client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                    Dim response As HttpResponseMessage = Await client.GetAsync("https://www.receitaws.com.br/v1/cnpj/" + CNPJ_Limpo)
                    Dim json As String = Await response.Content.ReadAsStringAsync
                    'nome, natureza_juridica, data_abertura,fantasia,porte,logradouro,numero,complemento,bairro,municipio,uf,cep,telefone,email,capital_social,atividade_principal,atividades_secundarias
                    Dim json_obj As JObject = JObject.Parse(json)

                    ' Verifica se a resposta é bem-sucedida
                    If Not response.IsSuccessStatusCode Then
                        MessageBox.Show("Erro ao acessar o serviço da Receita Federal. Código de status: " & response.StatusCode.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BtnImportar.Text = "Importar"
                        BtnImportar.Enabled = True
                        Exit Sub
                    End If

                    'se der erro no Nome finaliza o sub
                    If json_obj("nome") Is Nothing Then
                        MessageBox.Show("CNPJ não encontrado no site da Receita Federal...", "CNPJ não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BtnImportar.Text = "Importar"
                        BtnImportar.Enabled = True
                        Exit Sub
                    End If

                    '/////// PROCESSO IMPORTACAO
                    Dim nome As String = json_obj.Item("nome").ToString

                    Dim natureza_juridica As String = json_obj.Item("natureza_juridica").ToString
                    Dim data_abertura As String = json_obj.Item("abertura").ToString
                    Dim fantasia As String = json_obj.Item("fantasia").ToString
                    Dim porte As String = json_obj.Item("porte").ToString
                    'verificar se for MICRO EMPRESA mudar para Microempresa
                    If porte = "MICRO EMPRESA" Then
                        porte = "Microempresa"
                    End If
                    'Situação cadastral	
                    Dim situacao_cadastral As String = json_obj.Item("situacao").ToString
                    Dim logradouro As String = json_obj.Item("logradouro").ToString
                    Dim numero As String = json_obj.Item("numero").ToString
                    Dim complemento As String = json_obj.Item("complemento").ToString
                    Dim bairro As String = json_obj.Item("bairro").ToString
                    Dim municipio As String = json_obj.Item("municipio").ToString
                    Dim uf As String = json_obj.Item("uf").ToString
                    Dim cep As String = json_obj.Item("cep").ToString

                    Dim telefone As String = json_obj.Item("telefone").ToString

                    Dim email As String = json_obj.Item("email").ToString
                    Dim capital_social As String = json_obj.Item("capital_social").ToString
                    Dim capital_social_str As String = capital_social.Replace(".", ",")
                    Dim capital_social_str_2 As String = capital_social_str.Replace("R$", "")


                    Dim DataAtualizacao As String = json_obj.Item("ultima_atualizacao").ToString

                    '//////////////////////////////// ATIVIDADE PRINCIPAL ///////////////////////////////////////

                    ' "atividade_principal" object Atividade Principal
                    ' code String Código da atividade principal
                    ' text String Descrição da atividade principal
                    ''Newtonsoft.Json.Linq.JArray'
                    Dim atividade_principal As Newtonsoft.Json.Linq.JArray = json_obj.Item("atividade_principal")
                    Dim atividade_principal_code As String = atividade_principal(0).Item("code").ToString
                    Dim atividade_principal_text As String = atividade_principal(0).Item("text").ToString




                    '//////////////////////////////// ATIVIDADE SECUNDÁRIA ///////////////////////////////////////
                    ' "atividades_secundarias" object Atividades Secundárias
                    ' code String Código da atividade secundária
                    ' text String Descrição da atividade secundária
                    ''Newtonsoft.Json.Linq.JArray'
                    ''se tiver vazio array
                    Dim atividades_secundarias As Newtonsoft.Json.Linq.JArray = json_obj.Item("atividades_secundarias")
                    Dim atividades_secundarias_code As String = ""
                    Dim atividades_secundarias_text As String = ""

                    If atividades_secundarias.Count > 0 Then
                        atividades_secundarias_code = atividades_secundarias(0).Item("code").ToString.ToString.Replace("-", "").Replace(".", "").Insert(4, "-").Insert(6, "/")
                        atividades_secundarias_text = atividades_secundarias(0).Item("text").ToString

                        'pegar todas as atividades secundárias texto e código
                        For i = 1 To atividades_secundarias.Count - 1
                            'NOVA LINHA atividades_secundarias_code = atividades_secundarias_code + vbCrLf + atividades_secundarias(i).Item("code").ToString
                            ' atividades_secundarias_text = atividades_secundarias_text + vbNewLine + atividades_secundarias(i).Item("text").ToString
                            '  'apenas numeros e mudar formato para 9999-9/99
                            atividades_secundarias_code = atividades_secundarias_code + vbNewLine + atividades_secundarias(i).Item("code").ToString.Replace("-", "").Replace(".", "").Insert(4, "-").Insert(6, "/")
                            atividades_secundarias_text = atividades_secundarias_text + vbNewLine + atividades_secundarias(i).Item("text").ToString
                            'para cada CODE colocar no formato 9999-9/99
                            ' atividades_secundarias_code = atividades_secundarias_code.Replace("-", "").Replace(".", "")
                            'atividades_secundarias_code = atividades_secundarias_code.Insert(4, "-").Insert(6, "/")

                        Next

                    End If

                    '////// FIM DO CODIGO DO CNAE ///////

                    '//////////////////////////////////   IMPORTAÇÂO  ///////////////////////////////////////

                    'INICIA A LEGALIZAÇÃO
                    FrmLegalizacao.TabControle.SelectedIndex = 0
                    FrmLegalizacao.TabControle.SelectedIndex = 1
                    'TabControl2 3
                    FrmLegalizacao.TabControl2.SelectedIndex = 0
                    FrmLegalizacao.TabControl2.SelectedIndex = 1
                    FrmLegalizacao.TabControl2.SelectedIndex = 2
                    FrmLegalizacao.TabControl2.SelectedIndex = 3
                    FrmLegalizacao.TabControl2.SelectedIndex = 4
                    FrmLegalizacao.TabControl2.SelectedIndex = 5

                    FrmLegalizacao.TabControle.SelectedIndex = 0
                    FrmLegalizacao.TabControl2.SelectedIndex = 0
                    'FIM




                    'atualizar campos do formulario
                    FrmLegalizacao.RazaoSocialTextBox.Text = nome
                    FrmLegalizacao.NaturezaJuridicaComboBox.Text = natureza_juridica
                    FrmLegalizacao.EmpInicioAtividadeMaskedTextBox.Text = data_abertura
                    FrmLegalizacao.NomeFantasiaTextBox.Text = fantasia
                    FrmLegalizacao.PorteDaEmpresaComboBox.Text = porte
                    FrmLegalizacao.SituacaoCadastralComboBox.Text = situacao_cadastral


                    'ENDEREÇo //////////////////////////////////////////////////


                    FrmLegalizacao.EnderecoTextBox.Text = logradouro
                    FrmLegalizacao.EndNumeroTextBox.Text = numero
                    FrmLegalizacao.EndComplementoTextBox.Text = complemento
                    FrmLegalizacao.EndBairroTextBox.Text = bairro
                    FrmLegalizacao.EndCidadeTextBox.Text = municipio
                    FrmLegalizacao.EndEstadoTextBox.Text = uf
                    FrmLegalizacao.EndCEPMaskedTextBox.Text = cep

                    'TELEFONE E EMAIL //////////////////////////////////////////////////

                    'verificar se tem "/" entre os telefones, e dividir em dois campos EmpTel1TextBox e EmpTel2TextBox
                    'formato (44) 3035-0111/ (44) 3035-0111

                    Dim tel_1 As String = telefone.Replace("-", "")
                    Dim tel_2 As String = ""
                    If telefone.Contains("/") Then
                        tel_1 = telefone.Split("/")(0)
                        tel_2 = telefone.Split("/ ")(1)
                    End If
                    'ignorar tel_1 e tel_2 for = "(0000) 0000-0000"
                    If tel_1 <> "(0000) 0000-0000" Then
                        FrmLegalizacao.EmpTel1TextBox.Text = tel_1
                    End If
                    If tel_2 <> "(0000) 0000-0000" Then
                        FrmLegalizacao.EmpTel2TextBox.Text = tel_2.TrimStart(" ")
                    End If

                    'FrmLegalizacao.EmpTel1TextBox.Text = tel_1
                    ' FrmLegalizacao.EmpTel2TextBox.Text = tel_2.TrimStart(" ")


                    'EMAIL //////////////////////////////////////////////////
                    FrmLegalizacao.EmpEmailTextBox.Text = email

                    'CAPITAL SOCIAL //////////////////////////////////////////////////

                    FrmLegalizacao.TabControl2.SelectedIndex = 5
                    FrmLegalizacao.CapitalSTextBox.Text = capital_social_str_2


                    'RAMO DE ATIVIDADE //////////////////////////////////////////////////

                    'CNAEPrincipalTextBox e CNAESecundarioRichTextBox

                    'atividade_principal_code_str apenas numeros
                    Dim atividade_principal_code_str As String = atividade_principal_code.Replace(".", "")
                    Dim atividade_principal_code_str_2 As String = atividade_principal_code_str.Replace("-", "")

                    'atividade_principal_code_str_2 0000000 para formato 9999-9/99
                    Dim atividade_principal_code_str_3 As String = atividade_principal_code_str_2.Insert(4, "-")
                    Dim atividade_principal_code_str_4 As String = atividade_principal_code_str_3.Insert(6, "/")
                    FrmLegalizacao.CNAEPrincipalTextBox.Text = atividade_principal_code_str_4

                    'Atividade secundaria FrmLegalizacao.CNAESecundarioRichTextBox.Text CODE
                    FrmLegalizacao.CNAESecundarioRichTextBox.Text = atividades_secundarias_code





                    'verificar se tem texto dentro RamoDeAtividadeRichTextBox, se nao tiver, preencher com atividade_principal_text + atividades_secundarias_text
                    If FrmLegalizacao.RamoDeAtividadeRichTextBox.Text = "" Then
                        FrmLegalizacao.RamoDeAtividadeRichTextBox.Text = atividade_principal_text + "; " + vbCrLf + atividades_secundarias_text + "; " + vbCrLf
                    End If


                    'FINALIZAR //////////////////////////////////////////////////

                    FrmLegalizacao.TabControl2.SelectedIndex = 0
                    FrmLegalizacao.TabControl1.SelectedIndex = 0

                    'mostrar mgs de sucesso
                    MsgBox("Importação realizada com sucesso! Ultima atualização em:" & DataAtualizacao, MsgBoxStyle.Information, "Importação")
                    'fechar formulario
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            'mostrar mgs de erro
            MsgBox("Erro ao importar: " + ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

        Me.Close()
    End Sub



    Private Sub BoxConsultaCNPJEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function IsFormOpen(formName As String) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = formName Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BoxConsultaCNPJEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub




    Private Sub VerificarCNPJ(cnpj As String)
        ' O CNPJ está no formato já formatado com máscara
        Dim cnpjFormatado As String = cnpj

        Using connection As New SqlConnection(Str)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando CNPJ: " & cnpjFormatado)

                ' Consultar o CNPJ na tabela "Laudos"
                Dim query As String = "SELECT CNPJ FROM Empresas WHERE CNPJ = @CNPJ"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        ' Log do resultado encontrado
                        Debug.WriteLine("CNPJ encontrado na tabela Laudos: " & cnpjFormatado)

                        ' Se o CNPJ estiver cadastrado, buscar a razão social
                        Dim queryRazaoSocial As String = "SELECT RazaoSocial FROM Empresas WHERE CNPJ = @CNPJ"
                        Using cmdRazaoSocial As New SqlCommand(queryRazaoSocial, connection)
                            cmdRazaoSocial.Parameters.AddWithValue("@CNPJ", cnpjFormatado)

                            Dim razaoSocial As String = Convert.ToString(cmdRazaoSocial.ExecuteScalar())
                            MessageBox.Show("Empresa já cadastrada!" & vbCrLf & "CNPJ: " & cnpjFormatado & vbCrLf & "Razão Social: " & razaoSocial)
                            'Exit Sub
                        End Using
                    Else
                        MessageBox.Show("CNPJ não cadastrado.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnImportarFederal_Click(sender As Object, e As EventArgs) Handles BtnImportarFederal.Click
        ' Verifica se o formulário já está aberto
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmExtraiCNPJ Then
                frm.Close() ' Fecha o formulário se ele já estiver aberto
                Exit For
            End If
        Next

        ' Abre o formulário
        FrmExtraiCNPJ.Show()

        ' Fecha o formulário atual
        Me.Close()
    End Sub

End Class
