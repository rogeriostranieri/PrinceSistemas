﻿Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class BoxConsultaCNPJEmpresa

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        System.Diagnostics.Process.Start("http://servicos.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?cnpj=" + CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        Me.Close()
    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))

        ConsultaCNPJ.Show()
        ConsultaCNPJ.WebView21.Source = New Uri("http://servicos.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?cnpj=" + CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        Me.Close()

    End Sub

    Private Async Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        '        MsgBox("Em testes")

        'FrmLegalizacao.CNPJMaskedTextBox.Text
        'consulta https://www.receitaws.com.br/v1/cnpj/
        Dim CNPJ As String = FrmLegalizacao.CNPJMaskedTextBox.Text
        Dim CNPJ_Limpo As String = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        'conectar no site https://www.receitaws.com.br/v1/cnpj/
        Dim client As New HttpClient
        Dim response As HttpResponseMessage = Await client.GetAsync("https://www.receitaws.com.br/v1/cnpj/" + CNPJ_Limpo)
        Dim json As String = Await response.Content.ReadAsStringAsync
        'nome, natureza_juridica, data_abertura,fantasia,porte,logradouro,numero,complemento,bairro,municipio,uf,cep,telefone,email,capital_social,atividade_principal,atividades_secundarias
        Dim json_obj As JObject = JObject.Parse(json)
        Dim nome As String = json_obj.Item("nome").ToString
        Dim natureza_juridica As String = json_obj.Item("natureza_juridica").ToString
        Dim data_abertura As String = json_obj.Item("abertura").ToString
        Dim fantasia As String = json_obj.Item("fantasia").ToString
        Dim porte As String = json_obj.Item("porte").ToString
        'verificar se for MICRO EMPRESA mudar para Microempresa
        If porte = "MICRO EMPRESA" Then
            porte = "Microempresa"
        End If
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



        'ENDEREÇo //////////////////////////////////////////////////


        FrmLegalizacao.EnderecoTextBox.Text = logradouro
        FrmLegalizacao.EndNumeroTextBox.Text = numero
        FrmLegalizacao.EndComplementoTextBox.Text = complemento
        FrmLegalizacao.EndBairroTextBox.Text = bairro
        FrmLegalizacao.EndCidadeTextBox.Text = municipio
        FrmLegalizacao.EndEstadoTextBox.Text = uf
        FrmLegalizacao.EndCEPMaskedTextBox.Text = cep

        'TELEFONE E EMAIL //////////////////////////////////////////////////

        'telefone
        FrmLegalizacao.EmpTel1TextBox.Text = telefone
        FrmLegalizacao.EmpEmailTextBox.Text = email

        'Capital Social
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
            FrmLegalizacao.RamoDeAtividadeRichTextBox.Text = atividade_principal_text + vbCrLf + "; " + atividades_secundarias_text + vbCrLf + "; "
        End If


        'FINALIZAR //////////////////////////////////////////////////

        FrmLegalizacao.TabControl2.SelectedIndex = 0
        FrmLegalizacao.TabControl1.SelectedIndex = 0

        Me.Close()
    End Sub

    Private Sub BoxConsultaCNPJEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Visible = False
        Label2.Visible = False
    End Sub
End Class
