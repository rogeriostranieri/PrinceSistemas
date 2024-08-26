Imports System.Data.SqlClient
Imports System.IO

Public Class FrmLegalizacao
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"


    'Bloqueando para edição
    Private Sub Bloquear()
        Dim o As Object
        For Each o In Me.Controls
            If TypeOf o Is TextBox Then
                DirectCast(o, TextBox).Enabled = False
            End If
        Next
    End Sub

    Private Sub Desbloquear()
        Dim o As Object
        For Each o In Me.Controls
            If TypeOf o Is TextBox Then
                DirectCast(o, TextBox).Enabled = True
            End If
        Next
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' SEMPRE MAIUSCULO - inicio

    Private Sub RazaoSocialTextBox_TextChanged(sender As Object, e As EventArgs) Handles RazaoSocialTextBox.TextChanged
        'se for maior do que Caracteres: 63, mostrar o botao BtnAvancoRazao, se nao esconder
        If RazaoSocialTextBox.Text.Length > 63 Then
            BtnAvancoRazao.Visible = True
        Else
            BtnAvancoRazao.Visible = False
        End If
        'maiusculo
        Dim selectionStart As Integer = RazaoSocialTextBox.SelectionStart
        Dim selectionLength As Integer = RazaoSocialTextBox.SelectionLength

        ' Converte o texto para maiúsculas
        RazaoSocialTextBox.Text = RazaoSocialTextBox.Text.ToUpper()

        ' Restaura a posição do cursor e a seleção
        RazaoSocialTextBox.SelectionStart = selectionStart
        RazaoSocialTextBox.SelectionLength = selectionLength
    End Sub


    'FIM maiusculo


    Private Sub Salvar()
        Try
            ' Finalizar edição e obter registros alterados
            Me.EmpresasBindingSource.EndEdit()
            Dim changedRecords As System.Data.DataTable = PrinceDBDataSet.Empresas.GetChanges()

            ' Verificar se há alterações para salvar
            If changedRecords IsNot Nothing AndAlso changedRecords.Rows.Count > 0 Then
                Dim message As String = "Foram feitas " & changedRecords.Rows.Count.ToString() & " alterações." & vbCrLf & "Deseja salvar as alterações?"
                Dim result As DialogResult = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

                Select Case result
                    Case DialogResult.Cancel
                        ' Ação para Cancelar
                        Return

                    Case DialogResult.No
                        ' Reverter mudanças e desativar edição
                        PrinceDBDataSet.Empresas.RejectChanges()
                        BtnEditar.Text = "Editar"
                        BtnExcluir.Enabled = True
                        GroupBox2.Enabled = False
                        GroupBox10.Enabled = False

                        ' Recarregar dados
                        Me.NaturezajuridicaTableAdapter.Fill(Me.PrinceDBDataSet.Naturezajuridica)
                        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

                    Case DialogResult.Yes
                        ' Salvar alterações
                        Try
                            MudarStatusFinalizado() ' Verifica o status de finalização e aplica as mudanças

                            Me.Validate()
                            Me.EmpresasBindingSource.EndEdit()
                            Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)

                            ' Ajustar a interface após salvar
                            BtnEditar.Text = "Editar"
                            GroupBox2.Enabled = False
                            GroupBox10.Enabled = False
                            BtnExcluir.Enabled = True

                            ' Focar na empresa atual no combobox de busca
                            Dim NomeEmpresa As String = RazaoSocialTextBox.Text
                            ComboBoxBuscaEmpresa.Text = NomeEmpresa
                            ComboBoxBuscaEmpresa.Focus()
                            RazaoSocialTextBox.Focus()

                        Catch exc As Exception
                            MessageBox.Show("Ocorreu um erro ao atualizar" & vbCrLf & exc.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try
                End Select
            Else
                ' Não há alterações, apenas desativar edição
                BtnEditar.Text = "Editar"
                GroupBox2.Enabled = False
                GroupBox10.Enabled = False
                BtnExcluir.Enabled = True

                ' Focar na empresa atual
                Dim NomeEmpresa As String = RazaoSocialTextBox.Text
                ComboBoxBuscaEmpresa.Text = NomeEmpresa
                ComboBoxBuscaEmpresa.Focus()
                RazaoSocialTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar" & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    ' LOAD INICIAL

    Public Property RazaoSocialSelecionada As String

    Private Sub FrmLegalizacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CADstatusTableAdapter.Fill(Me.PrinceDBDataSet.CADstatus)
            StatusComboBox.DataSource = Me.CADstatusBindingSource
            StatusComboBox.DisplayMember = "Descricao"
            StatusComboBox.ValueMember = "Descricao"

            Me.NaturezajuridicaTableAdapter.Fill(Me.PrinceDBDataSet.Naturezajuridica)
            Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)


            Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)


            BtnEditar.Text = "Cancelar"
            Editar()
            ModCombobox.ComboboxLegalizacaoProcesso()
            Me.ComboBoxBuscaEmpresa.Focus()
            StatusOrdenado()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao carregar o formulário" + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        ' Forçar a aceitação das alterações e garantir que o DataSet está atualizado
        PrinceDBDataSet.AcceptChanges()

        ' Atualizar o BindingSource após aplicar o filtro
        AtualizarBindingSource()


        For Each col As DataColumn In Me.PrinceDBDataSet.Empresas.Columns
            col.ReadOnly = False
        Next
    End Sub

    Private Sub AtualizarBindingSource()
        ' Forçar a atualização do BindingSource
        EmpresasBindingSource.EndEdit()
        EmpresasBindingSource.ResetBindings(False)
    End Sub



    Private Sub StatusOrdenado()
        ' Obter a fonte de dados original do ComboBox
        Dim bindingSource As BindingSource = DirectCast(StatusComboBox.DataSource, BindingSource)

        ' Verificar se o BindingSource não é Nothing
        If bindingSource IsNot Nothing Then
            ' Obter a DataView da fonte de dados do BindingSource
            Dim dataView As DataView = DirectCast(bindingSource.List, DataView)

            ' Verificar se a DataView não é Nothing
            If dataView IsNot Nothing Then
                ' Ordenar a DataView pela coluna desejada
                dataView.Sort = "Descricao ASC" ' Substitua "ColumnName" pelo nome da coluna que você deseja ordenar

                ' Atualizar o BindingSource com a DataView ordenada
                bindingSource.DataSource = dataView
            End If
        End If
    End Sub

    Private Sub ProcessoMudar()
        Try
            If ProcessoComboBox.Text = "Abertura" Then
                'MotivoRichTextBox.Visible = False
                ' MotivoLabel.Visible = False
                NAlteracaoComboBox.Visible = False
                NAlteracaoLabel.Visible = False
                AltConsolidadaComboBox.Visible = False
                LabelConsolidar.Visible = False
                GroupBox5.Visible = False

                NovaRazaoSocialLabel.Visible = False
                NovaRazaoSocialComboBox.Visible = False

            ElseIf ProcessoComboBox.Text = "Alteração" Then
                NAlteracaoComboBox.Visible = True
                NAlteracaoLabel.Visible = True
                AltConsolidadaComboBox.Visible = True
                LabelConsolidar.Visible = True
                GroupBox5.Visible = True


                NovaRazaoSocialLabel.Visible = True
                NovaRazaoSocialComboBox.Visible = True


            ElseIf ProcessoComboBox.Text = "Baixa" Then
                ' MotivoRichTextBox.Visible = False
                ' MotivoLabel.Visible = False
                NAlteracaoComboBox.Visible = False
                NAlteracaoLabel.Visible = False
                AltConsolidadaComboBox.Visible = False
                LabelConsolidar.Visible = False
                GroupBox5.Visible = True

                NovaRazaoSocialLabel.Visible = False
                NovaRazaoSocialComboBox.Visible = False


            Else
                'MotivoRichTextBox.Visible = True
                'MotivoLabel.Visible = True
                NAlteracaoComboBox.Visible = True
                NAlteracaoLabel.Visible = True
                AltConsolidadaComboBox.Visible = True
                LabelConsolidar.Visible = True

                NovaRazaoSocialLabel.Visible = True
                NovaRazaoSocialComboBox.Visible = True

            End If

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Mudar o Processo" + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Private Sub StatusMudar()
        Try
            Select Case True

           ' Select Case StatusComboBox.Text'.Trim()


                Case StatusComboBox.Text.Contains("Finalizado")


                    '  If MsgBox("Foi alterado no seu Sistema Particular?", MsgBoxStyle.YesNo, "Notificação") = MsgBoxResult.Yes Then
                    If ProcessoComboBox.Text = "Baixa" Then
                        StatusComboBox.BackColor = Color.Green
                        StatusComboBox.ForeColor = Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.fechadaempresa

                    ElseIf ProcessoComboBox.Text = "Finalizado" Then
                        StatusComboBox.BackColor = Color.Green
                        StatusComboBox.ForeColor = Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA

                    Else

                        StatusComboBox.BackColor = Color.Green
                        StatusComboBox.ForeColor = Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA

                    End If


                Case StatusComboBox.Text.Contains("Pêndencia Sistema Externo")
                    StatusComboBox.BackColor = Color.Red
                    StatusComboBox.ForeColor = Color.Black
                    ' AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources.check
                    PictureBox2.Image = Nothing
                    ' SistemaExternoComboBox.SelectedText = "Não"
                    AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()


                Case StatusComboBox.Text.Contains("Paralisado")
                    StatusComboBox.BackColor = Color.Red
                    StatusComboBox.ForeColor = Color.White
                    AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources._Stop
                    PictureBox2.Image = Nothing

                Case StatusComboBox.Text.Contains("Cancelado")
                    StatusComboBox.BackColor = Color.Red
                    StatusComboBox.ForeColor = Color.White
                    AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources.Cancel
                    PictureBox2.Image = Nothing

                Case StatusComboBox.Text.Contains("Em Andamento")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.empresa_facil
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Aguardando Pagamento das Taxas")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.emandamento
                    PictureBox2.Image = My.Resources.pagamento


                Case StatusComboBox.Text.Contains("Taxas")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.emandamento
                    PictureBox2.Image = My.Resources.pagamento

                '//////////////////////////////////////////////
                ' Empresa Fácil
                '//////////////////////////////////////////////
                Case StatusComboBox.Text.Contains("Empresa Fácil - Prefeitura: EM ANÁLISE")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.empresa_facil
                    PictureBox1.Image = My.Resources.emandamento
                Case StatusComboBox.Text.Contains("Empresa Fácil - Busca de Nome")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.empresa_facil
                    PictureBox1.Image = My.Resources.emandamento
                Case StatusComboBox.Text.Contains("Empresa Fácil - Aguardando Atualização")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.empresa_facil
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Empresa Fácil - Protocolado")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.empresa_facil
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Empresa Fácil")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.empresa_facil
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Receita Federal")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.redeSim_Divulgação
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Receita Estadual - Protocolado")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.governo2019_400x173px
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Receita Estadual")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.governo2019_400x173px
                    PictureBox1.Image = My.Resources.emandamento


                Case StatusComboBox.Text.Contains("Receita Estadual - Em Andamento")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.governo2019_400x173px
                    PictureBox1.Image = My.Resources.emandamento
                '

                Case StatusComboBox.Text.Contains("Simples Nacional - Protocolado")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.logo_simples_nacional_810x455
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Simples Nacional")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox2.Image = My.Resources.logo_simples_nacional_810x455
                    PictureBox1.Image = My.Resources.emandamento

                Case StatusComboBox.Text.Contains("Prefeitura/Alvará - Em Andamento")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.emandamento
                    PictureBox2.Image = My.Resources.alvara

                Case StatusComboBox.Text.Contains("Prefeitura")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.emandamento
                    PictureBox2.Image = My.Resources.alvara
                '
                Case StatusComboBox.Text.Contains("Aguardando Cliente")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.emandamento
                    PictureBox2.Image = Nothing

                Case StatusComboBox.Text.Contains("Aguardando")
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = My.Resources.emandamento
                    PictureBox2.Image = Nothing

                Case Else
                    StatusComboBox.BackColor = Color.White
                    StatusComboBox.ForeColor = Color.Black
                    PictureBox1.Image = Nothing
                    PictureBox2.Image = Nothing
                    'Protocolado Receita Estadual

            End Select




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsultaJunta.Click
        Dim frm As New BoxJuntaComercial

        If frm.Visible = True Then
            'coloca focus e frente
            frm.Focus()
            frm.BringToFront()

        Else
            frm.Show()
            frm.BringToFront()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Application.OpenForms.OfType(Of BoxConsultaCNPJEmpresa)().Count() > 0 Then
            BoxConsultaCNPJEmpresa.Focus()
        Else
            BoxConsultaCNPJEmpresa.Show()
        End If
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            'EmpCriadoMaskedTextBox

            'MessageBox.Show(DateTime.Now.ToLongDateString())

            Dim a As DateTime
            a = EmpCriadoMaskedTextBox.Text

            'just show time only
            '  MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim a As DateTime
            a = DataProtJuntaComercialMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim a As DateTime

            a = DataProtREDESIMMaskedTextBox.Text
            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://concla.ibge.gov.br/busca-online-cnae.html")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://concla.ibge.gov.br/busca-online-cnae.html")
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControle.SelectTab(2)
        TabControl1.SelectTab(0)



        Try

            'Soma de data e ano bisexto 

            Dim iDias, iMes, iAno As Integer
            Dim sData As String

            'Compara a data atual com uma data anterior, no caso utilizei 01/01/1990 e vê a quantidade de 
            'dias do intervalo
            iDias = DateDiff("d", "01/01/1990", NireDataMaskedTextBox.Text)

            'Soma a quantidade de dias que quer somar e adiciona mais 1 para que de certo
            iDias = iDias + 1 + txtDataASomar.Text

            'coloca o ano que foi indicado acima na variavel que vai armazenar o ano
            iAno = 1990

            'faz um loop para saber quantos anos existem dentro da quantidade de dias achados
            Do While iDias >= 365
                iDias -= 365
                iAno += 1
                've se o ano é bissexto
                If iAno Mod 4 = 0 Then
                    iDias -= 1
                End If
            Loop

            'adiciona 1 na variavel que vai receber o mes
            iMes = 1

            'faz a mesma coisa que no ano, com um case no meio para ver os meses que não tem 31 dias
            'e corrigir as quantidades de dias a subtrair
            Do While iDias > 31
                iDias -= 31
                iMes += 1
                Select Case iMes
                    Case 3
                        If iAno Mod 4 = 0 Then
                            iDias += 2
                        Else
                            iDias += 3
                        End If
                    Case 5
                        iDias += 1
                    Case 7
                        iDias += 1
                    Case 8
                        iDias += 1
                    Case 10
                        iDias += 1
                    Case 12
                        iDias += 1
                End Select
            Loop

            'aqui pega os resultados e transforma em data.
            sData = iDias & "/" & iMes & "/" & iAno
            '& Format(sData, "dd/mm/yy")

            ' PrazoSimplesMaskedTextBox.Text = sData

            PrazoSimplesMaskedTextBox.Text = CDate(sData).ToString("dd/MM/yyyy")
            TabControle.SelectTab(5)

        Catch
            MessageBox.Show(" Data do NIRE está vazia! ", "Prince Ajuda")
            TabControle.SelectTab(2)
            TabControl1.SelectTab(0)

        End Try

    End Sub
    Private Sub Ajuda1()
        MessageBox.Show(" LEI 8934/94
Dispõe sobre o Registro Público de Empresas Mercantis e Atividades Afins e dá outras providências.
Art. 60. A firma individual ou a sociedade que não proceder a qualquer arquivamento no período de 10 (dez) anos consecutivos deverá comunicar à Empresa Fácil que deseja manter-se em funcionamento.

§ 1º Na ausência dessa comunicação, a empresa mercantil será considerada inativa, promovendo a Empresa Fácil o cancelamento do registro, com a perda automática da proteção ao nome empresarial.

§ 2º A empresa mercantil deverá ser notificada previamente pela Empresa Fácil, mediante comunicação direta ou por edital, para os fins deste artigo.

§ 3º A Empresa Fácil fará comunicação do cancelamento às autoridades arrecadadoras, no prazo de até dez dias.

§ 4º A reativação da empresa obedecerá aos mesmos procedimentos requeridos para sua constituição. ", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Ajuda1()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BtnConsultaRedeSim.Click
        Dim frm As New WebSiteGERAL

        Try
            If ProtocoloREDESIMTextBox.Text <> "" Then
                'perguntar
                Dim resposta As DialogResult = MessageBox.Show("Deseja abrir o site para consultar?", "Pergunta", MessageBoxButtons.YesNo)
                If resposta = DialogResult.Yes Then
                    ' Verifica se o formulário WebSiteGERAL já está aberto
                    Dim webForm As WebSiteGERAL = Nothing

                    For Each form As Form In Application.OpenForms
                        If TypeOf form Is WebSiteGERAL Then
                            webForm = DirectCast(form, WebSiteGERAL)
                            Exit For
                        End If
                    Next

                    ' Se o formulário estiver aberto, foca nele. Caso contrário, cria uma nova instância e abre.
                    If webForm IsNot Nothing Then
                        webForm.Focus()
                        webForm.BringToFront()
                    Else
                        webForm = New WebSiteGERAL()
                        webForm.Show()
                    End If

                    ' Define a URL para o WebView
                    Dim ProtocoloREDESIM As String = ProtocoloREDESIMTextBox.Text
                    webForm.WebView.Source = New Uri("https://servicos.receita.fazenda.gov.br/Servicos/fcpj/consulta.asp?Cod=&Ident=&prot=" & ProtocoloREDESIM)

                    webForm.Focus()
                    webForm.BringToFront()
                Else
                    ' Código para lidar com a resposta "Não"
                End If


            Else
                '  BtnConsultaRedeSim.Text = "Solicitar"
                Dim resposta As DialogResult = MessageBox.Show("Deseja abrir o site para Solicitar?", "Pergunta", MessageBoxButtons.YesNo)
                If resposta = DialogResult.Yes Then
                    ' Verifica se o formulário WebSiteGERAL já está aberto
                    Dim webForm As WebSiteGERAL = Nothing

                    For Each form As Form In Application.OpenForms
                        If TypeOf form Is WebSiteGERAL Then
                            webForm = DirectCast(form, WebSiteGERAL)
                            Exit For
                        End If
                    Next

                    ' Se o formulário estiver aberto, foca nele. Caso contrário, cria uma nova instância e abre.
                    If webForm IsNot Nothing Then
                        webForm.Focus()
                        webForm.BringToFront()
                    Else
                        webForm = New WebSiteGERAL()
                        webForm.Show()
                    End If
                    ' Define a URL para o WebView

                    webForm.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/meu-cnpj")
                Else
                    ' Código para lidar com a resposta "Não"
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o site ou no codigo, verifique com o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Ajuda2()
        MessageBox.Show(" Foi informado um dos eventos de viabilidade abaixo?

*Alteração de endereço dentro do mesmo município
*Alteração do nome empresarial
*Alteração de natureza jurídica
*Alteração de atividades econômicas (principal e secundárias)
*Alteração do tipo de unidade
*Alteração da forma de atuação

Se for SIM, 
Precisa do Protocolo de Viabilidade da Empresa Fácil", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Ajuda2()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Ajuda1()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Ajuda2()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click



        ' MsgBox("Protocolo Copiado e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        ' Clipboard.SetText(ProtocoloREDESIMTextBox.Text)
        System.Diagnostics.Process.Start("http://www.fazenda.pr.gov.br/")

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        'System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")


        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        '  System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked


        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www8.receita.fazenda.gov.br/SimplesNacional/Servicos/Grupo.aspx?grp=t&area=1")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www8.receita.fazenda.gov.br/SimplesNacional/Servicos/Grupo.aspx?grp=t&area=1")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            System.Diagnostics.Process.Start(ArquivoContratoTextBox.Text)
        Catch
            MsgBox("Campo Vazio", MsgBoxStyle.Critical, "Prince Sistemas")
        End Try
    End Sub








    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        Dim Arquivo As String
        Dim Local As String

        Try
            OpenFileDialog1.ShowDialog()
            Arquivo = OpenFileDialog1.SafeFileName
            Local = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = ""
            ArquivoContratoTextBox.Text = Local


        Catch ex As Exception
            MsgBox("ERRO, Selecione algum arquivo para salvar o local da pasta", MsgBoxStyle.Critical, "Prince Sistemas")
            ArquivoContratoTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Try
            If BtnEditar.Text = "Editar" Then

                If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
                    Me.Validate()
                    Me.EmpresasBindingSource.AddNew()
                    'unchek lembrete

                    LembreteCheckBox.CheckState = CheckState.Unchecked
                    PrioridadeCheckBox.CheckState = CheckState.Unchecked

                    'Cadastro
                    TipoDeEmpresaComboBox.SelectedIndex = -1
                    PorteDaEmpresaComboBox.SelectedIndex = -1
                    RegimeFederalComboBox.SelectedIndex = -1
                    NaturezaJuridicaComboBox.SelectedIndex = -1

                    'que faltou
                    'RegimeFederalComboBox.SelectedText = "Pendência"
                    RegimeFederalComboBox.SelectedIndex = 4


                    'procedimentos
                    StatusComboBox.SelectedText = "Não Iniciado"

                    ProcessoComboBox.SelectedIndex = -1
                    'SistemaExternoComboBox.SelectedText = "Não"
                    SistemaExternoComboBox.SelectedIndex = 1
                    EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
                    AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
                    Editar()
                Else

                End If

            ElseIf BtnEditar.Text = "Cancelar" Then
                If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
                    Me.Validate()
                    Me.EmpresasBindingSource.AddNew()
                    'unchek lembrete

                    LembreteCheckBox.CheckState = CheckState.Unchecked
                    PrioridadeCheckBox.CheckState = CheckState.Unchecked

                    'Cadastro
                    TipoDeEmpresaComboBox.SelectedIndex = -1
                    PorteDaEmpresaComboBox.SelectedIndex = -1
                    RegimeFederalComboBox.SelectedIndex = -1
                    NaturezaJuridicaComboBox.SelectedIndex = -1

                    'que faltou
                    'RegimeFederalComboBox.SelectedText = "Pendência"
                    RegimeFederalComboBox.SelectedIndex = 4


                    'procedimentos

                    StatusComboBox.SelectedText = "Não Iniciado"

                    ProcessoComboBox.SelectedIndex = -1
                    'SistemaExternoComboBox.SelectedText = "Não"
                    SistemaExternoComboBox.SelectedIndex = 1
                    EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
                    AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
                Else

                End If

            End If

        Catch ex As Exception
            MsgBox("ERRO, Verifique se os campos estão preenchidos corretamente", MsgBoxStyle.Critical, "Prince Sistemas")
        End Try

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            If MsgBox("Tem certeza que deseja apagar o registo ?", MsgBoxStyle.YesNo, "A T E N Ç Ã O") = MsgBoxResult.Yes Then
                Me.Validate()
                Me.EmpresasBindingSource.RemoveCurrent()
                Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)
                Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
                MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
        Salvar()
        ' Else

        ' End If


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub




    Private Sub Legalizacao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        Me.EmpresasBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.Empresas.GetChanges()

        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then
            Dim message As String
            message = "Foram feitas " & changedRecords.Rows.Count & " alterações." & vbCrLf & "Deseja salvar as alterações?"

            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try
                    EmpresasTableAdapter.Update(PrinceDBDataSet.Empresas)
                Catch exc As Exception
                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            End If


        End If

        'verificar se FrmEventos está aberto e fechar
        If FrmEventos.Visible = True Then
            FrmEventos.Close()
        End If
        'DialogCalendarioEmpresas
        If DialogCalendarioEmpresas.Visible = True Then
            DialogCalendarioEmpresas.Close()
        End If
        'FrmControleEventosEmpresa
        If FrmControleEventosEmpresa.Visible = True Then
            FrmControleEventosEmpresa.Close()
        End If


        'fechar os complementos
        'fechar FormaDeAtuacao
        If FormadeAtuacao.Visible = True Then
            FormadeAtuacao.Close()
        End If
        'TipodeUnidade
        If TipodeUnidade.Visible = True Then
            TipodeUnidade.Close()
        End If
        'DialogAjudaFormaAtuacao fechar
        If DialogAjudaFormaAtuacao.Visible = True Then
            DialogAjudaFormaAtuacao.Close()
        End If
        'DialogAjudaTipoUnidade
        If DialogAjudaTipoUnidade.Visible = True Then
            DialogAjudaTipoUnidade.Close()
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TabControle.SelectTab(2)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TabControle.SelectTab(3)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControle.SelectTab(5)
    End Sub



    Private Sub ProcessoComboBox_Validated(sender As Object, e As EventArgs) Handles ProcessoComboBox.Validated

        If ProcessoComboBox.Text = "Abertura" Then
            SistemaExternoLabel.Text = "Cadastro no Sistema Externo:"
        Else
            SistemaExternoLabel.Text = "Atualização no Sistema Externo:"

        End If
    End Sub


    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor")

        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            Dim a As DateTime
            a = DataPedidoIEMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/quero-ser-mei/atividades-permitidas")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/quero-ser-mei/atividades-permitidas")

        End If
    End Sub

    Private Sub TipoDeEmpresaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoDeEmpresaComboBox.SelectedIndexChanged
        If TipoDeEmpresaComboBox.Text = "Microempreendedor Indivual ( MEI )" Then
            Button24.Visible = True
            Button20.Visible = False
            Button25.Visible = True

        Else
            Button24.Visible = False
            Button20.Visible = True
            Button25.Visible = False
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TabControle.SelectTab(5)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TabControle.SelectTab(4)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TabControle.SelectTab(6)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Application.OpenForms.OfType(Of BoxConsultaIEEmpresa)().Count() > 0 Then
            BoxConsultaIEEmpresa.Focus()
        Else
            BoxConsultaIEEmpresa.Show()
        End If
    End Sub

    Private Sub IEjuntaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IEjuntaComboBox.SelectedIndexChanged
        If IEjuntaComboBox.Text = "Vinculado na Empresa Fácil" Then
            GroupBox12.Visible = False
            Button33.Visible = True


        Else
            GroupBox12.Visible = True
            Button33.Visible = False

        End If
    End Sub


    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            Dim a As DateTime
            a = ProtJuntaFinalMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub



    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

        ' Call ConexaoLaudo()
        Call VerificaCNPJemprCOMlaudos()

        'chamar mod teste
        'Call teste123456()

    End Sub


    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TabControle.SelectTab(2)

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs)
        Try

            If Trim(CNPJMaskedTextBox.Text) = "" Then

                MsgBox("O Campo CNPJ está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            Else

                Dim CNPJ As String = CNPJMaskedTextBox.Text

                Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
                ' MsgBox("CNPJ Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs)
        Try
            TabControle.SelectTab(1)
            TabControl2.SelectTab(0)
            If Trim(CPFResponsavelMaskedTextBox.Text) = "" Then

                MsgBox("O Campo CPF está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                TabControle.SelectTab(5)
            Else

                Dim CPF As String = CPFResponsavelMaskedTextBox.Text

                Clipboard.SetText(CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
                TabControle.SelectTab(5)
                ' MsgBox("CPF Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CPF" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)
        Try

            If Trim(CodigoSimplesTextBox.Text) = "" Then

                MsgBox("O Campo Código do Simples Nacional está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            Else

                Dim CodSimples As String = CodigoSimplesTextBox.Text

                Clipboard.SetText(CodSimples.Replace("/", "").Replace(",", "").Replace("-", "").Replace(" ", ""))
                ' MsgBox("Código do Simples Nacional Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao copiar Código do Simples Nacional" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub
    Private Sub BtnCopiaDataDeNasc_Click(sender As Object, e As EventArgs)
        Try
            TabControle.SelectTab(1)
            TabControl2.SelectTab(0)
            If Trim(RespDataNascMaskedTextBox.Text) = "" Then

                MsgBox("O Campo Data de Nascimento está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                TabControle.SelectTab(5)
            Else

                Dim DATANASC As String = RespDataNascMaskedTextBox.Text

                Clipboard.SetText(DATANASC.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
                TabControle.SelectTab(5)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar Data de Nascimento" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub


    Private Sub Button37_Click(sender As Object, e As EventArgs)
        Try

            TabControle.SelectTab(1)
            TabControl2.SelectTab(0)
            If Trim(TituloeleitorTextBox.Text) = "" Then

                MsgBox("O Campo Título de Eleitor está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
                TabControle.SelectTab(5)
            Else

                Dim TituloDeEleitor As String = TituloeleitorTextBox.Text

                Clipboard.SetText(TituloDeEleitor.Replace("/", "").Replace(",", "").Replace("-", "").Replace(" ", ""))
                TabControle.SelectTab(5)
                ' MsgBox("Título de Eleitor Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar Título de Eleitor" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39")
        End If

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim Arquivo As String
        Dim Local As String

        'GetDirectoryName pega o diretorio apenas e nao o arquivo
        Try
            MsgBox("Selecione um arquivo para salvar o local da Pasta", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            OpenFileDialog1.ShowDialog()


            Arquivo = OpenFileDialog1.SafeFileName
            Local = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)

            PastaDocumentosTextBox.Text = Local




        Catch ex As Exception
            MsgBox("ERRO, Selecione algum arquivo para salvar o local da pasta", MsgBoxStyle.Critical, "Prince Sistemas")
            PastaDocumentosTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Try
            System.Diagnostics.Process.Start(PastaDocumentosTextBox.Text)
        Catch
            MsgBox("Campo Vazio", MsgBoxStyle.Critical, "Prince Sistemas")
            ' MessageBox.Show("Campo Vazio", "Prince Alerta")
        End Try
    End Sub

    Private Sub BtnAlteracao_Click(sender As Object, e As EventArgs) Handles BtnAlteracao.Click
        Try
            If MsgBox("Limpar o Procedimento e salvar no Histórico?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
                ' Alternar entre as guias
                Dim tabsToSelect = {0, 2, 3, 4, 7}
                For Each index In tabsToSelect
                    TabControle.SelectTab(index)
                Next

                ' Capturar os valores dos campos
                Dim A = NAlteracaoComboBox.Text.ToString()
                Dim B = ProcessoComboBox.Text.ToString()
                Dim C = EmpCriadoMaskedTextBox.Text.ToString()
                Dim D = MotivoRichTextBox.Text.ToString()
                Dim F = ProtocoloJuntaComercialTextBox.Text.ToString()
                Dim G = ProtocoloREDESIMTextBox.Text.ToString()

                ' Atualizar o histórico
                HistoricoRichTextBox.AppendText(
                "Histórico anterior, Salvo Dia: " & Format(Now, "dd/MM/yyyy") & " às " & Format(Now, "HH:mm") & ", com as seguintes informações:" & vbCrLf &
                "Processo: " & A & " " & B & "." & vbCrLf &
                "Iniciado o processo em: " & C & "." & vbCrLf &
                "Motivo: " & D & "." & vbCrLf &
                "Protocolo Empresa Fácil: " & F & "." & vbCrLf &
                "Protocolo RedeSim: " & G & "." & vbCrLf &
                "//-----------------//-----------------//-----------------//-----------------//" & vbCrLf
            )

                MessageBox.Show("Dados Principais Salvos no Histórico", "Prince Avisa")

                ' Verificar se é uma nova alteração ou mudar o status
                HandleProcessStatus(A, B, C, D, F, G)

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar no Histórico" & vbCrLf & ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ClearFields()
        ' Limpar campos
        EmpCriadoMaskedTextBox.Text = ""
        MotivoRichTextBox.Text = ""
        GeralRichTextBox.Text = ""
        ProcedimentoRichTextBox.Text = ""
        AvisarDiaMaskedTextBox.Text = ""
        DataProtJuntaComercialMaskedTextBox.Text = ""
        ProtocoloJuntaComercialTextBox.Text = ""
        ProtJuntaFinalMaskedTextBox.Text = ""
        JuntaObsRichTextBox.Text = ""
        DataProtREDESIMMaskedTextBox.Text = ""
        ProtocoloREDESIMTextBox.Text = ""
        RedeSimObsRichTextBox.Text = ""
        IEjuntaComboBox.Text = ""
        DataPedidoIEMaskedTextBox.Text = ""
        IEInicioAtividadeMaskedTextBox.Text = ""
        IEComprovanteTextBox.Text = ""
        IEVencPedidoMaskedTextBox.Text = ""
        EstadualObsRichTextBox.Text = ""
        ProcessoComboBox.SelectedIndex = -1
        EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString()
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
        LembreteCheckBox.CheckState = CheckState.Unchecked
        PrioridadeCheckBox.CheckState = CheckState.Unchecked
        SistemaExternoComboBox.SelectedIndex = 1
    End Sub

    Private Sub HandleProcessStatus(A As String, B As String, C As String, D As String, F As String, G As String)
        ' Verifica se o campo ProcessoComboBox.Text contém "Alteração"
        If ProcessoComboBox.Text.Equals("Alteração", StringComparison.OrdinalIgnoreCase) Then
            ' Incrementa o número de alteração
            Dim alteracaoNumber As Integer
            If Integer.TryParse(NAlteracaoComboBox.Text, alteracaoNumber) Then
                NAlteracaoComboBox.Text = (alteracaoNumber + 1).ToString()
            Else
                NAlteracaoComboBox.Text = "1"
            End If
            ClearFields()
            ProcessoComboBox.Text = "Alteração"
            StatusComboBox.Text = "Não Iniciado"

            MsgBox("Número de Alteração incrementado. Verifique conforme a Empresa Fácil.", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        Else
            ' Não é uma alteração, apenas salvar os dados e mudar o status
            ClearFields()
            StatusComboBox.Text = "Não Iniciado"
            MsgBox("Nenhum dado encontrado para alteração. Status alterado para 'Não Iniciado'.", MsgBoxStyle.Information, "Prince Sistemas Informa!")

        End If
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TabControle.SelectTab(0)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs)
        'http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome
        'verificar se form WebSiteGERAL está aberto ou abrir
        If WebSiteGERAL.Visible = False Then
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome")
        Else
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome")
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        PastaDocumentosTextBox.Text = ""
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        ArquivoContratoTextBox.Text = ""
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Try
            Dim CNPJ As String = CNPJMaskedTextBox.Text
            'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

        Catch ex As Exception
            MessageBox.Show("Erro ao copiar CNPJ" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral")
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")
        End If
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Dim Protocolo As String = ProtocoloREDESIMTextBox.Text

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")
            If WebSiteGERAL.TxtCarregamento.Text = "Carregamento Completo" Then
                'id="prot"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementById('prot').value = '" + Protocolo + "'")
            End If
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")
        End If
    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Dim Protocolo As String = ProtocoloREDESIMTextBox.Text

        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/cancela.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")

            If WebSiteGERAL.TxtCarregamento.Text = "Carregamento Completo" Then
                'id="prot"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementById('prot').value = '" + Protocolo + "'")
                'class="btn btn-primary"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementsByClassName('btn btn-primary')[0].click()")
            End If
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/cancela.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")
            If WebSiteGERAL.TxtCarregamento.Text = "Carregamento Completo" Then
                'id="prot"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementById('prot').value = '" + Protocolo + "'")
                'class="btn btn-primary"
                WebSiteGERAL.WebView.ExecuteScriptAsync("document.getElementsByClassName('btn btn-primary')[0].click()")
            End If
        End If
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        If WebSiteGERAL.Visible = True Then
            'coloca focus e frente
            WebSiteGERAL.Focus()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.BringToFront()
            WebSiteGERAL.WebView.Source = New Uri("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa")
        End If
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim CNPJ As String = CPFResponsavelMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Try

            If WebSiteGERAL.Visible = False Then
                WebSiteGERAL.Show()
                WebSiteGERAL.BringToFront()
                WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")
            Else
                WebSiteGERAL.BringToFront()
                WebSiteGERAL.WebView.Source = New Uri("http://www.receita.fazenda.gov.br/Aplicacoes/ATSDR/procuracoesrfb/controlador/controlePrincipal.asp?acao=telaInicial")
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o navegador" + vbCrLf + ex.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub BtnVerEventos_Click(sender As Object, e As EventArgs) Handles BtnVerEventos.Click, Button48.Click, Button47.Click
        TabControle.SelectTab(0)

    End Sub

    Private Sub BtnListaEventos_Click(sender As Object, e As EventArgs) Handles BtnListaEventos.Click
        If Application.OpenForms.OfType(Of FrmEventos)().Count() > 0 Then
            FrmEventos.Focus()
        Else
            FrmEventos.Show()
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click

        'limpar

        MotivoRichTextBox.Clear()


    End Sub

    Private Sub NomeFantasiaTextBox_TextChanged(sender As Object, e As EventArgs)
        Try
            NomeFantasiaTextBox1.Text = NomeFantasiaTextBox.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NomeFantasiaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NomeFantasiaTextBox1.TextChanged
        Try
            NomeFantasiaTextBox.Text = NomeFantasiaTextBox1.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCopiarSenhaGov_Click(sender As Object, e As EventArgs) Handles BtnCopiarSenhaGov.Click
        Dim Senha As String = SenhaGovTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(Senha) '
    End Sub



    Private Sub Editar()
        Try
            If BtnEditar.Text = "Editar" Then
                BtnEditar.Text = "Cancelar"
                GroupBox2.Enabled = True
                GroupBox10.Enabled = True

                BtnExcluir.Enabled = False

                BtnAlteracao.Enabled = True

            ElseIf BtnEditar.Text = "Cancelar" Then

                BtnEditar.Text = "Editar"
                GroupBox2.Enabled = False
                GroupBox10.Enabled = False

                Dim NomeEmpresa As String = RazaoSocialTextBox.Text
                Salvar()
                ComboBoxBuscaEmpresa.Text = NomeEmpresa
                ComboBoxBuscaEmpresa.Focus()
                RazaoSocialTextBox.Focus()

                BtnExcluir.Enabled = True
                BtnAlteracao.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao editar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()


    End Sub

    Private Sub NovaRazaoSocialComboBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialComboBox.TextChanged
        ' RazaoSocialTextBox
        ' NovaRazaoSocialFinalTextBox
        Try
            Select Case NovaRazaoSocialComboBox.Text'.Trim()
                Case "Abertura"
                    ' RazaoSocialLabel.BackColor = Color.SeaGreen
                    ' If NovaRazaoSocialFinalTextBox.Text = NovaRazaoSocialFinalTextBox.Text Then

                    'RazaoSocialLabel.ForeColor = Color.Black
                    'PictureBox6.Image = My.Resources.V
                    ' Else
                    RazaoSocialLabel.ForeColor = Color.Red
                    PictureBox6.Image = My.Resources._Stop
                    ' End If
                    LabelNovaRazaoFinal.Visible = True
                    NovaRazaoSocialFinalTextBox.Visible = True
                    LinkLabelMudarRazaoSocial.Visible = True


                Case "Alteração"

                    RazaoSocialLabel.ForeColor = Color.Red
                    PictureBox6.Image = My.Resources.refresh_512

                    LabelNovaRazaoFinal.Visible = True
                    NovaRazaoSocialFinalTextBox.Visible = True
                    LinkLabelMudarRazaoSocial.Visible = True


                Case "Não Mudar"
                    'RazaoSocialLabel.BackColor = Color.SeaGreen
                    RazaoSocialLabel.ForeColor = Color.Black

                    PictureBox6.Image = My.Resources.V

                    LabelNovaRazaoFinal.Visible = False
                    NovaRazaoSocialFinalTextBox.Visible = False
                    LinkLabelMudarRazaoSocial.Visible = True

                Case Else


                    'RazaoSocialLabel.BackColor = Color.SeaGreen
                    RazaoSocialLabel.ForeColor = Color.Black
                    PictureBox6.Image = My.Resources.V

                    LabelNovaRazaoFinal.Visible = False
                    NovaRazaoSocialFinalTextBox.Visible = False
                    LinkLabelMudarRazaoSocial.Visible = False
            End Select

        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ProtocoloJuntaComercialTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocoloJuntaComercialTextBox.TextChanged
        If ProtocoloJuntaComercialTextBox.Text = "" Then

            BtnConsultaJunta.Text = "Solicitar"

        Else
            BtnConsultaJunta.Text = "Consultar"
        End If
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelMudarRazaoSocial.LinkClicked
        RazaoSocialTextBox.Text = NovaRazaoSocialFinalTextBox.Text
    End Sub

    Private Sub ProtocoloREDESIMTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocoloREDESIMTextBox.TextChanged
        'BtnConsultaRedeSim

        If ProtocoloREDESIMTextBox.Text = "" Then

            BtnConsultaRedeSim.Text = "Solicitar"

        Else
            BtnConsultaRedeSim.Text = "Consultar"
        End If
    End Sub


    Private Sub IETipoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IETipoComboBox.SelectedIndexChanged
        Try
            Select Case IETipoComboBox.Text
                Case "Abertura"
                    DatadeInicioIE.Visible = True
                    IEInicioAtividadeMaskedTextBox.Visible = True

                Case "Alteração"
                    DatadeInicioIE.Visible = False
                    IEInicioAtividadeMaskedTextBox.Visible = False

                Case "Baixa"
                    DatadeInicioIE.Visible = False
                    IEInicioAtividadeMaskedTextBox.Visible = False

                Case "Reativação"
                    DatadeInicioIE.Visible = True
                    IEInicioAtividadeMaskedTextBox.Visible = True

            End Select

        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub CnaeSimples_Click(sender As Object, e As EventArgs) Handles CnaeSimples.Click

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.contabeis.com.br/ferramentas/simples-nacional/")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://www.contabeis.com.br/ferramentas/simples-nacional/")

        End If

    End Sub

    Private Sub BtnData1_Click(sender As Object, e As EventArgs) Handles BtnData1.Click
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
    End Sub

    Private Sub BtnData2_Click(sender As Object, e As EventArgs) Handles BtnData2.Click
        DataProtJuntaComercialMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub BtnData3_Click(sender As Object, e As EventArgs) Handles BtnData3.Click
        ProtJuntaFinalMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()

        'procurar "Empresa Fácil - Protocolado"no StatusComboBox e selecionar
        Try
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact("Empresa Fácil - Protocolado")
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar" + vbCrLf + ex.Message, "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'selecionar select all
            StatusComboBox.SelectedText = "Não Iniciado"
        End Try

    End Sub

    Private Sub BtnData4_Click(sender As Object, e As EventArgs) Handles BtnData4.Click
        DataProtREDESIMMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub BtnConsultaeProcessoEstado_Click(sender As Object, e As EventArgs) Handles BtnConsultaeProcessoEstado.Click

        Dim IE As String = IEeProcNumTextBox.Text

        If Trim(IEeProcNumTextBox.Text) = "" Then
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")
            End If
        Else
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
                WebSiteGERAL.WebView.Source = New Uri("https://www.eprotocolo.pr.gov.br/spiweb/consultarProtocoloDigital.do?action=pesquisar&numeroProtocolo=" + IE)
            End If
        End If

    End Sub

    Private Sub IEeProcNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles IEeProcNumTextBox.TextChanged
        If Trim(IEeProcNumTextBox.Text) = "" Then
            BtnConsultaeProcessoEstado.Text = "Solicitar"

        Else
            BtnConsultaeProcessoEstado.Text = "Consultar"

        End If
    End Sub

    Private Sub SistemaExternoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SistemaExternoComboBox.SelectedIndexChanged
        Try
            SistemaExternoComboBox.Font = New Font(SistemaExternoComboBox.Font, FontStyle.Bold)


            If Me.SistemaExternoComboBox.Text = "Sim" Then
                Me.SistemaExternoComboBox.BackColor = Color.SeaGreen
                'Me.SistemaExternoComboBox.Font = Ita
                Me.SistemaExternoComboBox.ForeColor = Color.White
                PictureBoxSistemaExterno.Image = My.Resources.check



            End If


            If Me.SistemaExternoComboBox.Text = "Não" Then
                Me.SistemaExternoComboBox.BackColor = Color.Red
                ' Me.SistemaExternoComboBox.Font = Bold
                Me.SistemaExternoComboBox.ForeColor = Color.White
                PictureBoxSistemaExterno.Image = My.Resources.Cancel

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RegimeFederalComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegimeFederalComboBox.SelectedIndexChanged
        '        RegimeFederalComboBox.Font = New Font(RegimeFederalComboBox.Font, FontStyle.Bold)

        If RegimeFederalComboBox.Text = "Pendência" Then
            RegimeFederalComboBox.BackColor = Color.Yellow
            RegimeFederalComboBox.ForeColor = Color.Black


        Else
            RegimeFederalComboBox.BackColor = Color.SeaGreen
            RegimeFederalComboBox.ForeColor = Color.White


        End If
    End Sub

    Private Sub BtnAdicionarSocio_Click(sender As Object, e As EventArgs) Handles BtnAdicionarSocio.Click
        'ativa TabControl2 inicia 0
        TabControl2.SelectedIndex = 0
        'verifica se esta vazio NomeResponsavelTextBox

        If NomeResponsavelTextBox.Text = "" Then
            MsgBox("Preencha o campo Nome do Responsável", MsgBoxStyle.Information, "Atenção")
            NomeResponsavelTextBox.Focus()
            Exit Sub

        Else
            TabControl2.SelectedIndex = 1
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                'pegar NomeResponsavelTextBox e coloca no FrmSocio.NomeResponsavelTextBox
                FrmSocios.Focus()
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            End If
        End If


    End Sub

    Private Sub BtnLimparSocio_Click(sender As Object, e As EventArgs) Handles BtnLimparSocio.Click
        If QuantidadeSociosTextBox.Text = "" Then
            QuantidadeSociosTextBox.Text = "0"
        Else
            QuantidadeSociosTextBox.Text = QuantidadeSociosTextBox.Text - 1

        End If

        If QuantidadeSociosTextBox.Text < "0" Then
            QuantidadeSociosTextBox.Text = "0"
        End If
    End Sub


    Private Sub BtnAddmaisSocio_Click(sender As Object, e As EventArgs) Handles BtnAddmaisSocio.Click
        If QuantidadeSociosTextBox.Text = "" Then
            QuantidadeSociosTextBox.Text = "0"
        Else
            QuantidadeSociosTextBox.Text = QuantidadeSociosTextBox.Text + 1

        End If

        If QuantidadeSociosTextBox.Text < "0" Then
            QuantidadeSociosTextBox.Text = "0"
        End If
    End Sub



    Private Sub BtnLimparSocios_Click(sender As Object, e As EventArgs) Handles BtnLimparSocios.Click
        If MsgBox("Deseja limpar todos Sócios?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
            DadosSociosRichTextBox.Text = ""
            QuantidadeSociosTextBox.Text = "0"
        End If


    End Sub


    '/////////// Inicio do codigo de mostrar calendario
    '//
    Private Sub AvisarDiaMaskedTextBox_Click(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Click

        'DialogCalendarioEmpresas abrir proximo ao AvisarDiaMaskedTextBox
        'DialogCalendarioEmpresas.Location = New Point(AvisarDiaMaskedTextBox.Location.X, AvisarDiaMaskedTextBox.Location.Y)
        DialogCalendarioEmpresas.Show()
        DialogCalendarioEmpresas.Focus()
        'abrir no local do mouse
        DialogCalendarioEmpresas.Location = New Point(MousePosition.X, MousePosition.Y)

    End Sub



    Private Sub AvisarDiaMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Leave
        DialogCalendarioEmpresas.Close()

    End Sub




    '/////////// fim do codigo de mostrar calendario

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        If Application.OpenForms.OfType(Of FrmAtalhoBuscadores)().Count() > 0 Then

            FrmAtalhoBuscadores.Focus()
            FrmAtalhoBuscadores.Close()
            ' FrmAtalhoBuscadores.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAtalhoBuscadores.Show()
            'Me.Close()

        Else

            'FrmAtalhoBuscadores.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAtalhoBuscadores.Show()
            ' Me.Close()
        End If
    End Sub

    Private Sub BtnContador_Click(sender As Object, e As EventArgs) Handles BtnContador.Click
        If Application.OpenForms.OfType(Of ContadorGeral)().Count() > 0 Then
            ContadorGeral.Focus()
            '   Contador.MdiParent = MDIPrincipal

        Else
            ' Contador.MdiParent = MDIPrincipal
            ContadorGeral.Show()
        End If
    End Sub

    'gerar CancelEventArgs e

    Private Sub EMAIL()
        Try
            'If StatusComboBox.Text = "Finalizado" Then
            'selecioanr Index 0
            If SistemaExternoComboBox.SelectedIndex = 0 Then
                EnviarEmail()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnviarEmail()
        Try
            Dim message As String
            'message Deseja enviar por e-mail toda alteração feita?
            message = "Deseja enviar por e-mail toda alteração feita?"
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNo)
            If result = DialogResult.Cancel Then
                'nao fazer nada

            ElseIf result = DialogResult.No Then
                'perguntar se deseja abrir o Form FrmEmail
                Dim message2 As String
                message2 = "Deseja abrir o e-Mail?"
                Dim result2 As Integer = MessageBox.Show(message2, "Prince Alerta", MessageBoxButtons.YesNo)
                If result2 = DialogResult.Yes Then
                    If Application.OpenForms.OfType(Of FrmMail)().Count() > 0 Then
                        FrmMail.BringToFront()
                        FrmMail.Focus()
                    Else
                        FrmMail.Show()
                        FrmMail.BringToFront()
                        FrmMail.Focus()
                    End If
                End If

            ElseIf result = DialogResult.Yes Then
                If Application.OpenForms.OfType(Of FrmMail)().Count() > 0 Then
                    SistemaExternoComboBox.SelectedIndex = 0
                    Dim Sair As String
                    Sair = MsgBox("O e-Mail ja está aberto, exportando . . .", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                    'SistemaExternoComboBox muda para Sim
                    SistemaExternoComboBox.SelectedIndex = 0

                    FrmMail.MdiParent = MDIPrincipal
                    FrmMail.Show()
                    'abrir a automação
                    ModeMail.Enviaremaillegalizao()
                    FrmMail.BringToFront()
                    FrmMail.Focus()

                Else
                    'SistemaExternoComboBox muda para Sim
                    SistemaExternoComboBox.SelectedIndex = 0

                    FrmMail.MdiParent = MDIPrincipal
                    FrmMail.Show()
                    ModeMail.Enviaremaillegalizao()
                    FrmMail.BringToFront()
                    FrmMail.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SistemaExternoComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SistemaExternoComboBox.SelectionChangeCommitted
        EMAIL()
    End Sub

    Private Sub ButtoneMail_Click(sender As Object, e As EventArgs) Handles ButtoneMail.Click
        EnviarEmail()
    End Sub

    Private Sub NovaRazaoSocialComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialComboBox.SelectedIndexChanged
        'RazaoSocialTextBox.Text = NovaRazaoSocialFinalTextBox.Text
        'LinkLabel17
        If NovaRazaoSocialComboBox.Text = "Sim" Then
            NovaRazaoSocialFinalTextBox.Visible = True
            LabelNovaRazaoFinal.Visible = True
            LinkLabelMudarRazaoSocial.Visible = True

        Else
            NovaRazaoSocialFinalTextBox.Visible = False
            LabelNovaRazaoFinal.Visible = False
            LinkLabelMudarRazaoSocial.Visible = False
        End If


    End Sub

    Private Sub BtnAnotacoesLEgalizacao_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesLEgalizacao.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()
        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Legalização"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "FrmLegalizacao"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesFederal_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesFederal.Click, BtnAnotacoesSimples.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()
        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Receita Federal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Federal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesEstadual_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesEstadual.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()
        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Receita Estadual"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Estadual"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesPrefeitura_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesPrefeitura.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()
        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Prefeitura Municipal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesDemais_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesDemais.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()
        End If
        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Demais Assuntos"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Demais"))
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try

    End Sub




    'anexar documento

    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private ReadOnly da As SqlDataAdapter
    Private dr As SqlDataReader




    Private Sub BtnSalvarDoc_Click(sender As Object, e As EventArgs) Handles BtnSalvarDoc.Click
        If MsgBox("Deseja anexar o documento?", MsgBoxStyle.YesNo, "Salvar Anexo") = MsgBoxResult.Yes Then
            Try
                'procurar e salvar no banco de dados DocContratos varbinary aray    
                Dim dialogo As New OpenFileDialog With {
            .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
            .Title = "Selecione o arquivo de texto",
            .InitialDirectory = "C:\"
        }
                dialogo.ShowDialog()
                'DocContratosLinkLabel.Text = dialogo.FileName
                'salvar no banco de dados SQL SERVER Banco Empresas varbinary aray

                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                'tabela empresas e coluna DocContratos por razao social
                comando = New SqlCommand("UPDATE Empresas SET DocContratos = @DocContratos WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@DocContratos", SqlDbType.VarBinary).Value = File.ReadAllBytes(dialogo.FileName)
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                MsgBox("Documento salvo com sucesso!")
                DocContratosLinkLabel.Text = "Contrato Anexado"
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
                ' DocContratosLinkLabel.Text = ""
            End Try
        End If
    End Sub


    Private Sub AbrirAnexo()
        'save a file in .docx format, which was saved as VarBinary, in the database table companies and column DocContratos for corporate reasons
        If MsgBox("Deseja abrir o documento anexado?", MsgBoxStyle.YesNo, "Abrir Anexo") = MsgBoxResult.Yes Then
            Try
                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                comando = New SqlCommand("SELECT DocContratos FROM Empresas WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                'SqlDataReader

                dr = comando.ExecuteReader
                If dr.Read Then

                    Dim doc As Byte() = DirectCast(dr("DocContratos"), Byte())
                    'opendialog  para salvar o arquivo FileStream do banco de dados
                    'mudar local de salvamento do doc
                    Dim saveFileDialog1 As New SaveFileDialog With {
                        .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
                        .Title = "Salvar Arquivo de Texto"
                    }
                    saveFileDialog1.ShowDialog()
                    Dim fs As New FileStream(saveFileDialog1.FileName, FileMode.Create)
                    'escreve o arquivo no banco de dados
                    fs.Write(doc, 0, doc.Length)
                    'fecha o arquivo
                    fs.Close()
                    'perguntas antes de abrir o arquivo
                    Dim result As DialogResult = MessageBox.Show("Deseja abrir o arquivo?", "Abrir Arquivo", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Process.Start(saveFileDialog1.FileName)
                    End If
                End If
                conexao.Close()


            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
            End Try
        End If


    End Sub
    Private Sub BtnAbrirDoc_Click(sender As Object, e As EventArgs) Handles BtnAbrirDoc.Click

        AbrirAnexo()

    End Sub




    Private Sub BtnApagaAnexo_Click(sender As Object, e As EventArgs) Handles BtnApagaAnexo.Click
        Dim result As DialogResult = MessageBox.Show("Deseja apagar o anexo?", "Apagar Arquivo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                comando = New SqlCommand("UPDATE Empresas SET DocContratos = NULL WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                MsgBox("Documento apagado com sucesso!")
                DocContratosLinkLabel.Text = ""
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
            End Try
        End If

    End Sub

    Private Sub DocContratosLinkLabel_TextChanged(sender As Object, e As EventArgs) Handles DocContratosLinkLabel.TextChanged
        If DocContratosLinkLabel.Text = "" Then
            'DocContratosLinkLabel.Text = "Sem Anexo"
            AnexoBoxPicture.Image = My.Resources.off
            'muda tamanho da imagem
            AnexoBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            DocContratosLinkLabel.Text = "Contrato Anexado"
            'muda AnexoBoxPicture com imagem _on
            AnexoBoxPicture.Image = My.Resources._on
            AnexoBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub DocContratosLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DocContratosLinkLabel.LinkClicked
        If DocContratosLinkLabel.Text = "Contrato Anexado" Then
            AbrirAnexo()
        Else
            'mostrar menssagem "A empresa atual não contém anexo?"
            MsgBox("A empresa atual não contém anexo!")
        End If
    End Sub

    Private Sub BtnArrumar_Click(sender As Object, e As EventArgs) Handles BtnArrumar.Click
        'ArquivoContratoTextBox.Text = PastaDocumentosTextBox.Text

        PastaDocumentosTextBox.Text = ArquivoContratoTextBox.Text

        'PastaDocumentosTextBox apagar até o ultimo BARRA 
        Dim i As Integer
        For i = Len(PastaDocumentosTextBox.Text) To 1 Step -1
            If Mid(PastaDocumentosTextBox.Text, i, 1) = "\" Then
                PastaDocumentosTextBox.Text = Mid(PastaDocumentosTextBox.Text, 1, i)
                Exit For
            End If
        Next




    End Sub

    Private Sub BtnImportarAnexo_Click(sender As Object, e As EventArgs) Handles BtnImportarAnexo.Click
        If MsgBox("Deseja importar o documento?", MsgBoxStyle.YesNo, "Importar Contrato") = MsgBoxResult.Yes Then
            Try
                TabControl1.Focus()
                TabControl1.SelectedIndex = 1

                If ArquivoContratoTextBox.Text = "" Then
                    MsgBox("Erro! Campo do caminho do documento está vazio")
                Else
                    Dim ArquivoContrato As String = ArquivoContratoTextBox.Text
                    'pega o ArquivoContrato e salva no banco de dados

                    conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                    comando = New SqlCommand("UPDATE Empresas SET DocContratos = @DocContratos WHERE RazaoSocial = @RazaoSocial", conexao)
                    comando.Parameters.Add("@DocContratos", SqlDbType.VarBinary).Value = IO.File.ReadAllBytes(ArquivoContrato)
                    comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                    conexao.Open()
                    comando.ExecuteNonQuery()
                    conexao.Close()
                    MsgBox("Documento importado com sucesso!")
                    DocContratosLinkLabel.Text = "Contrato Anexado"

                End If
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
                'DocContratosLinkLabel.Text = ""
            End Try
        End If

    End Sub

    Private Sub StatusComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StatusComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub ProcessoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProcessoComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub AltConsolidadaComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AltConsolidadaComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub NovaRazaoSocialComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NovaRazaoSocialComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub SistemaExternoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SistemaExternoComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub



    Private Sub ProcessoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProcessoComboBox.SelectedIndexChanged

        ProcessoMudar()
        StatusMudar()

    End Sub


    Private Sub StatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusComboBox.SelectedIndexChanged

        ProcessoMudar()
        StatusMudar()
        'MudarStatusFinalizado()
    End Sub
    Private Sub MudarStatusFinalizado()

        'statuscombobox contendo Finalizado
        If StatusComboBox.Text.Contains("Finalizado") Then

            'If StatusComboBox.Text = "Finalizado" Then
            If SistemaExternoComboBox.SelectedIndex = 1 Then
                If MsgBox("Foi alterado no seu Sistema Particular?", MsgBoxStyle.YesNo, "Notificação") = MsgBoxResult.Yes Then
                    If ProcessoComboBox.Text = "Baixa" Then
                        StatusComboBox.BackColor = Color.Green
                        StatusComboBox.ForeColor = Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.fechadaempresa
                        SistemaExternoComboBox.SelectedIndex = 0
                        EMAIL()

                    ElseIf ProcessoComboBox.Text = "Abertura" Then
                        StatusComboBox.BackColor = Color.Green
                        StatusComboBox.ForeColor = Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
                        SistemaExternoComboBox.SelectedIndex = 0
                        EMAIL()
                    Else

                        StatusComboBox.BackColor = Color.Green
                        StatusComboBox.ForeColor = Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
                        SistemaExternoComboBox.SelectedIndex = 0
                        EMAIL()
                    End If
                Else
                    StatusComboBox.Text = "Pêndencia Sistema Externo"
                    StatusComboBox.BackColor = Color.Red
                    StatusComboBox.ForeColor = Color.Black
                    ' AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources.check
                    PictureBox2.Image = Nothing
                    SistemaExternoComboBox.SelectedIndex = 1
                End If

            ElseIf SistemaExternoComboBox.SelectedIndex = 0 Then

                If ProcessoComboBox.Text = "Baixa" Then
                    StatusComboBox.BackColor = Color.Green
                    StatusComboBox.ForeColor = Color.White

                    PictureBox1.Image = My.Resources.check
                    PictureBox2.Image = My.Resources.fechadaempresa


                ElseIf ProcessoComboBox.Text = "Abertura" Then
                    StatusComboBox.BackColor = Color.Green
                    StatusComboBox.ForeColor = Color.White
                    AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources.check
                    PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA


                Else
                    StatusComboBox.BackColor = Color.Green
                    StatusComboBox.ForeColor = Color.White
                    AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources.check
                    PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA

                End If

            Else
                'Antigo codigo
                StatusComboBox.BackColor = Color.Green
                StatusComboBox.ForeColor = Color.White
                AvisarDiaMaskedTextBox.Text = ""
                PictureBox1.Image = My.Resources.check
            End If


        End If


    End Sub


    Private Sub BtnImportarRazaoSocial_Click(sender As Object, e As EventArgs) Handles BtnImportarRazaoSocial.Click
        'pega a razaosocialtextbox e coloca no RazaoSocialAntigaTextBox 
        RazaoSocialAntigaTextBox.Text = RazaoSocialTextBox.Text
    End Sub

    'Razao Social 1
    Private Sub BtnUsarRazao1_Click(sender As Object, e As EventArgs) Handles BtnUsarRazao1.Click
        'pega NovaRazaoSocial1TextBox e coloca no NovaRazaoSocialFinalTextBox
        'ativa a TabControle 2 e retorna
        TabControle.SelectedIndex = 2
        NovaRazaoSocialFinalTextBox.Text = NovaRazaoSocial1TextBox.Text
    End Sub
    'Razao Social 2
    Private Sub BtnUsarRazao2_Click(sender As Object, e As EventArgs) Handles BtnUsarRazao2.Click
        'pega NovaRazaoSocial2TextBox e coloca no NovaRazaoSocialFinalTextBox
        'ativa a TabControle 2 e retorna
        TabControle.SelectedIndex = 2
        NovaRazaoSocialFinalTextBox.Text = NovaRazaoSocial2TextBox.Text
    End Sub
    'Razao Social 3
    Private Sub BtnUsarRazao3_Click(sender As Object, e As EventArgs) Handles BtnUsarRazao3.Click
        'pega NovaRazaoSocial3TextBox e coloca no NovaRazaoSocialFinalTextBox
        'ativa a TabControle 2 e retorna
        TabControle.SelectedIndex = 2
        NovaRazaoSocialFinalTextBox.Text = NovaRazaoSocial3TextBox.Text
    End Sub

    Private Sub BtnUsarNomeFantasia_Click(sender As Object, e As EventArgs) Handles BtnUsarNomeFantasia.Click
        'pega NomeFantasiaTextBox1 e  coloca no NomeFantasiaTextBox
        NomeFantasiaTextBox.Text = NomeFantasiaTextBox1.Text
    End Sub

    Private Sub BtnImportarSocioAdm_Click(sender As Object, e As EventArgs) Handles BtnImportarSocioAdm.Click
        'verifica se tem NomeResponsavelTextBox preenchido ou abre
        If NomeResponsavelTextBox.Text = "" Then
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
            Else
                FrmSocios.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
                FrmSocios.Focus()
                'igual do frmsocios.NomeCompletoComboBox.text
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            Else
                FrmSocios.Show()
                FrmSocios.NomeCompletoComboBox.Text = NomeResponsavelTextBox.Text
            End If

        End If


    End Sub

    Private Sub BtnWord_Click(sender As Object, e As EventArgs) Handles BtnWord.Click
        If ExportarContratoWordDialog.Visible = True Then
            ExportarContratoWordDialog.Focus()
        Else
            ExportarContratoWordDialog.ShowDialog()
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnAddSocios.Click
        'pergunta se deseja add manual
        If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
            FrmSocios.Focus()

            FrmSocios.BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social"
            FrmSocios.GroupBoxCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Enabled = True
            FrmSocios.GroupBoxCapitalSocial.Enabled = True

            Dim CapitalSocialEmpresas As String = CapitalSTextBox.Text
            'exporta para frmsocios.TextBoxCapitalSocial.text
            FrmSocios.TextBoxCapitalSocial.Text = CapitalSocialEmpresas
        Else
            FrmSocios.Show()

            FrmSocios.BtnCapitalSocial.Text = "Fechar Calculadora Capítal Social"
            FrmSocios.GroupBoxCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Visible = True
            FrmSocios.GroupBoxMenuCapitalSocial.Enabled = True
            FrmSocios.GroupBoxCapitalSocial.Enabled = True

            Dim CapitalSocialEmpresas As String = CapitalSTextBox.Text
            'exporta para frmsocios.TextBoxCapitalSocial.text
            FrmSocios.TextBoxCapitalSocial.Text = CapitalSocialEmpresas
        End If


    End Sub

    'CapitalSTextBox usar mascara em reais
    Private Sub CapitalSTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitalSTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'CapitalSTextBox validar em reais
    Private Sub CapitalSTextBox_LostFocus(sender As Object, e As EventArgs) Handles CapitalSTextBox.LostFocus, CapitalSTextBox.Leave
        If CapitalSTextBox.Text = "" Then
            CapitalSTextBox.Text = "0,00"
        Else
            CapitalSTextBox.Text = FormatCurrency(CapitalSTextBox.Text)
        End If
    End Sub

    'CapitalITextBox
    Private Sub CapitalITextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitalITextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'CapitalITextBox validar em reais
    Private Sub CapitalITextBox_LostFocus(sender As Object, e As EventArgs) Handles CapitalITextBox.LostFocus
        If CapitalITextBox.Text = "" Then
            CapitalITextBox.Text = "0,00"
        Else
            CapitalITextBox.Text = FormatCurrency(CapitalITextBox.Text)
        End If
    End Sub
    'CapitalQuotaValorTextBox.Text  validar em reais
    Private Sub CapitalQuotaValorTextBox_LostFocus(sender As Object, e As EventArgs) Handles CapitalQuotaValorTextBox.LostFocus
        If CapitalQuotaValorTextBox.Text = "" Then
            CapitalQuotaValorTextBox.Text = "0,00"
        Else
            CapitalQuotaValorTextBox.Text = FormatCurrency(CapitalQuotaValorTextBox.Text)
        End If
    End Sub

    Private Sub CapitalQuotaValorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitalQuotaValorTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'CapitaQuotaTotalTextBox  validar sem os reais, apenas numeros sem ",00"
    Private Sub CapitaQuotaTotalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapitaQuotaTotalTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "," OrElse e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub BtnPreencherCapital_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnPreencherCapital.LinkClicked
        'verificar se tem valor dentro do CapitalSTextBox
        'CapitalITextBox colocar igual CapitalSTextBox
        'CapitalQuotaValorTextBox colocar valor R$ 1,00
        'CapitaQuotaTotalTextBox igual CapitalSTextBox mas sem os "R$ " e apos ",00"
        If CapitalSTextBox.Text = "" Then
            'mgsbox add valor
            MsgBox("Adicione o valor do capital social", MsgBoxStyle.Exclamation, "Atenção")
            'focus
            CapitalSTextBox.Focus()
        Else
            'tirar ".00"
            'CapitalSTextBox.Text = CapitalSTextBox.Text.Replace(",00", "").Replace(".00", "").Replace(" ", "")
            'CapitalITextBox colocar igual CapitalSTextBox
            CapitalITextBox.Text = CapitalSTextBox.Text
            'CapitalQuotaValorTextBox colocar valor R$ 1,00
            CapitalQuotaValorTextBox.Text = "R$ 1,00"
            'CapitaQuotaTotalTextBox igual CapitalSTextBox mas sem os "R$ " e apos ",00"
            ' Dim CapitalSemNada As String = CapitalSTextBox.Text.Replace("R$ ", "").Replace(",00", "")
            CapitaQuotaTotalTextBox.Text = CapitalSTextBox.Text

            'mudar para reais
            CapitalSTextBox.Text = FormatCurrency(CapitalSTextBox.Text)
            CapitalITextBox.Text = FormatCurrency(CapitalITextBox.Text)
            CapitaQuotaTotalTextBox.Text = FormatCurrency(CapitaQuotaTotalTextBox.Text)
            DataExcSocialMaskedTextBox.Text = "31/12"
        End If
    End Sub

    Private Sub BtnRemoveSocios_Click(sender As Object, e As EventArgs) Handles BtnRemoveSocios.Click
        'perguntar se deseja limpar os dados
        If MsgBox("Deseja limpar a Divisão de Capital Social?", MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.Yes Then
            'limpar os dados
            DivisaoCapitalSociosRichTextBox.Text = ""
        Else
            'não faz nada
        End If

    End Sub

    Private Sub BtnCorreios_Click(sender As Object, e As EventArgs) Handles BtnCorreios.Click
        'vers e WebCorreios esta aberto

        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://buscacepinter.correios.com.br/app/endereco/index.php")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://buscacepinter.correios.com.br/app/endereco/index.php")

        End If

    End Sub

    Private Sub LblLinkAjudaSimples_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLinkAjudaSimples.LinkClicked
        MessageBox.Show("A solicitação de opção pelo Simples Nacional somente pode ser realizada no mês de janeiro, até o seu último dia útil. Uma vez deferida, produz efeitos a partir do primeiro dia do ano calendário da opção." & vbCrLf & "
Para empresas em início de atividade, o prazo para soliticação de opção é de 30 dias contados do último deferimento de inscrição (municipal ou estadual, caso exigíveis), desde que não tenham decorridos 60 dias da inscrição do CNPJ. Se deferida, a opção produz efeitos a partir da data da abertura do CNPJ. Após esse prazo, a opção somente será possível no mês de janeiro do ano-calendário seguinte.")

    End Sub

    Private Sub BtnMgsBoxDataSimples_Click(sender As Object, e As EventArgs) Handles BtnMgsBoxDataSimples.Click
        'DataSimplesMaskedTextBox em extenso por mgsbox
        Try
            Dim a As DateTime
            a = DataSimplesMaskedTextBox.Text
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try

    End Sub

    Private Sub BtnMgsBoxAvisarDia_Click(sender As Object, e As EventArgs) Handles BtnMgsBoxAvisarDia.Click
        'AvisarDiaMaskedTextBox
        Try
            Dim a As DateTime
            a = AvisarDiaMaskedTextBox.Text
            MsgBox(a.ToLongDateString)
            'avisar que cai no final de semana
            If a.DayOfWeek = DayOfWeek.Saturday Or a.DayOfWeek = DayOfWeek.Sunday Then
                MsgBox("Cai no fim de semana, alterando para proximo dia útil")
                'se for domingo ou sabado , mudar data do AvisarDiaMaskedTextBox para segunda feira
                If a.DayOfWeek = DayOfWeek.Sunday Then
                    AvisarDiaMaskedTextBox.Text = a.AddDays(1)
                ElseIf a.DayOfWeek = DayOfWeek.Saturday Then
                    AvisarDiaMaskedTextBox.Text = a.AddDays(2)
                End If
            End If
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub BtnRemovCaract_Click(sender As Object, e As EventArgs) Handles BtnRemovCaract.Click
        'usar ModTexto Function TirarCaracteres sText dentro do RamoDeAtividadeRichTextBox
        ' RamoDeAtividadeRichTextBox.Text = ModTexto.LimpaTexto(RamoDeAtividadeRichTextBox.Text)
        RamoDeAtividadeRichTextBox.Text = ModTexto.LimpaEnter(RamoDeAtividadeRichTextBox.Text)
        'LimpaCaracteres
        ' RamoDeAtividadeRichTextBox.Text = ModTexto.LimpaCaracteres(RamoDeAtividadeRichTextBox.Text)

    End Sub

    Private Sub BtnConsultaOptante_Click(sender As Object, e As EventArgs) Handles BtnConsultaOptante.Click
        ' System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
        If WebSiteGERAL.Visible = True Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")
            MsgBox("CNPJ copiado, use CTRL+V para colar no local desejado")
        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.Focus()
            WebSiteGERAL.WebView.Source = New Uri("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")
            MsgBox("CNPJ copiado, use CTRL+V para colar no local desejado")
        End If
    End Sub

    Private Sub BtnAvancoRazao_Click(sender As Object, e As EventArgs) Handles BtnAvancoRazao.Click
        'mostrar por mgsbox a RazaoSocialTextBox completa, mgsbox alerta
        '"A razão social da empresa completa é: "
        MessageBox.Show("A razão social da empresa completa é: " & RazaoSocialTextBox.Text, "Prince Ajuda")
    End Sub





    Private Sub SEDEComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SEDEComboBox.SelectionChangeCommitted
        'verificar se existe empresas com o mesmo nome e informar por mgsbox
        Dim con As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        Dim cmd As New SqlCommand("SELECT * FROM Empresas WHERE SEDE = @SEDE AND RazaoSocial = @RazaoSocial", con)
        cmd.Parameters.AddWithValue("@SEDE", SEDEComboBox.Text)
        cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim Sede As String = SEDEComboBox.Text
            MessageBox.Show("Existe uma empresa com a mesma razão social e sede: " & Sede, "Prince Ajuda")
            'SEDEComboBox seleciona o qual estava antes ou se for null
            SEDEComboBox.SelectedIndex = SEDEComboBox.FindString(SEDEComboBox.Text)

            BoxEmpresasIguais()
        End If

    End Sub

    Private Sub BoxEmpresasIguais()
        Dim Filtro As String = RazaoSocialTextBox.Text
        DialogEmpresasIguais.EmpresasBindingSource.Filter = String.Format("Status LIKE '%{0}%'", Filtro)
    End Sub

    Private Sub BtnDadosComplementares_Click(sender As Object, e As EventArgs) Handles BtnDadosComplementares.Click
        'TabControl2 ir para tab6
        TabControl2.SelectedIndex = 7
    End Sub

    Private Sub BtnAtividadeLocal_Click(sender As Object, e As EventArgs) Handles BtnAtividadeLocal.Click
        'TabControl2 ir para tab6
        TabControl2.SelectedIndex = 7
    End Sub

    Private Sub BtnAjudaAréa_Click(sender As Object, e As EventArgs) Handles BtnAjudaAréa.Click
        'mgsbox ajudando informando = " IMPORTANTE SABER!
        MessageBox.Show("IMPORTANTE SABER!
A metragem deve ser preenchida com exatidão pois esta informação impacta nos demais órgãos:

Área do Imóvel = é a área total da edificação.

Área do Estabelecimento = é a área exata (em metros quadrados) do local onde é realizada a atividade econômica dentro de um imóvel, podendo ocupar toda ou apenas uma parte da área do imóvel. Essa área nunca poderá ser zero ou maior que o imóvel.
")

        ' Mensagem de pergunta ao usuário
        Dim result As DialogResult = MessageBox.Show("Deseja ver no mapa?", "Ver Mapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verifica a resposta do usuário
        If result = DialogResult.Yes Then
            ' Chama o método Mapa
            Mapa()
        End If

    End Sub

    Private Sub BtnAjudaEmpresaFacilTipoUnidade_Click(sender As Object, e As EventArgs) Handles BtnAjudaEmpresaFacilTipoUnidade.Click
        'abrir AjudaEmpresaFacilTipoUnidade mas verificando se esta aberta
        If DialogAjudaTipoUnidade.Visible = True Then
            DialogAjudaTipoUnidade.Close()
            'trazer para frente 
            DialogAjudaTipoUnidade.BringToFront()
        Else
            DialogAjudaTipoUnidade.Show()
            DialogAjudaTipoUnidade.BringToFront()
        End If
    End Sub

    Private Sub BtnAjudaEmpresaFacilFormaAtuacao_Click(sender As Object, e As EventArgs) Handles BtnAjudaEmpresaFacilFormaAtuacao.Click
        'abrir AjudaEmpresaFacilTipoUnidade mas verificando se esta aberta
        If DialogAjudaFormaAtuacao.Visible = True Then
            DialogAjudaFormaAtuacao.Close()
            'trazer para frente 
            DialogAjudaFormaAtuacao.BringToFront()
        Else
            DialogAjudaFormaAtuacao.Show()
            DialogAjudaFormaAtuacao.BringToFront()
        End If
    End Sub

    Private Sub TipoUnidadeProdutivaRichTextBox_Click(sender As Object, e As EventArgs) Handles TipoUnidadeProdutivaRichTextBox.Click
        If TipodeUnidade.Visible = True Then
            TipodeUnidade.Close()
            'trazer para frente 
            TipodeUnidade.BringToFront()
        Else
            TipodeUnidade.Show()
            TipodeUnidade.BringToFront()
        End If
    End Sub

    Private Sub FormaDeAtuacaoRichTextBox_Click(sender As Object, e As EventArgs) Handles FormaDeAtuacaoRichTextBox.Click
        If FormadeAtuacao.Visible = True Then
            FormadeAtuacao.Close()
            'trazer para frente 
            FormadeAtuacao.BringToFront()
        Else
            FormadeAtuacao.Show()
            FormadeAtuacao.BringToFront()
        End If
    End Sub

    Private Sub TipoUnidadeProdutivaRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoUnidadeProdutivaRichTextBox.TextChanged
        If TipoUnidadeProdutivaRichTextBox.Text.Contains("Unidade Produtiva") Then
            FormaDeAtuacaoRichTextBox.Visible = True
            FormaDeAtuacaoLabel.Visible = True
        Else
            FormaDeAtuacaoRichTextBox.Visible = False
            FormaDeAtuacaoLabel.Visible = False
        End If
    End Sub

    Private Sub BtnCopiarRamo_Click(sender As Object, e As EventArgs) Handles BtnCopiarRamo.Click
        'copiar para area de trabalho RamoDeAtividadeRichTextBox
        Clipboard.SetText(RamoDeAtividadeRichTextBox.Text)
    End Sub

    Private Sub BtnCopiaEndereco_Click(sender As Object, e As EventArgs) Handles BtnCopiaEndereco.Click
        'copiar no formato "avenida Pioneiro Antônio Franco de Morais, Nº 1373, Sala 02, Jardim Brasil, CEP: 87083-260, Maringá-PR"
        Dim Endereco As String = EnderecoTextBox.Text
        Dim Numero As String = EndNumeroTextBox.Text
        Dim Complemento As String = EndComplementoTextBox.Text
        Dim Bairro As String = EndBairroTextBox.Text
        Dim CEP As String = EndCEPMaskedTextBox.Text
        Dim Cidade As String = EndCidadeTextBox.Text
        Dim UF As String = EndEstadoTextBox.Text

        'se tiver complemento ou retirar o complemento
        If Complemento = "" Then
            Clipboard.SetText(Endereco & ", n.º " & Numero & ", " & Bairro & ", CEP: " & CEP & ", " & Cidade & "-" & UF)
        Else
            Clipboard.SetText(Endereco & ", n.º " & Numero & ", " & Complemento & ", " & Bairro & ", CEP: " & CEP & ", " & Cidade & "-" & UF)
        End If

        'mgsbox
        MessageBox.Show("Endereço copiado com sucesso!")
    End Sub

    Private Sub BtnLimpaCaractRazao_Click(sender As Object, e As EventArgs) Handles BtnLimpaCaractRazao.Click
        'trocar ç por c, Ç por C, . "", , "", õ por o, Õ por O.
        NovaRazaoSocial1TextBox.Text = NovaRazaoSocial1TextBox.Text.Replace("ç", "c").Replace("Ç", "C").Replace("õ", "o").Replace("Õ", "O").Replace("Ã", "A").Replace("ã", "a")
        NovaRazaoSocial2TextBox.Text = NovaRazaoSocial2TextBox.Text.Replace("ç", "c").Replace("Ç", "C").Replace("õ", "o").Replace("Õ", "O").Replace("Ã", "A").Replace("ã", "a")
        NovaRazaoSocial3TextBox.Text = NovaRazaoSocial3TextBox.Text.Replace("ç", "c").Replace("Ç", "C").Replace("õ", "o").Replace("Õ", "O").Replace("Ã", "A").Replace("ã", "a")
        'retirar ponto e virgulas apenas do final
        NovaRazaoSocial1TextBox.Text = NovaRazaoSocial1TextBox.Text.TrimEnd(New Char() {";"c, "."c, ","c})
        NovaRazaoSocial2TextBox.Text = NovaRazaoSocial2TextBox.Text.TrimEnd(New Char() {";"c, "."c, ","c})
        NovaRazaoSocial3TextBox.Text = NovaRazaoSocial3TextBox.Text.TrimEnd(New Char() {";"c, "."c, ","c})
    End Sub

    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        ' Chamar o método de verificação
        VerificarCNPJ(CNPJMaskedTextBox.Text)
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

    Private Async Sub BtnBuscaCEP_Click(sender As Object, e As EventArgs) Handles BtnBuscaCEP.Click
        Try
            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(EndCEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                EnderecoTextBox.Text = resultado.logradouro
                EndComplementoTextBox.Text = resultado.complemento
                EndCidadeTextBox.Text = resultado.localidade
                EndBairroTextBox.Text = resultado.bairro
                EndEstadoTextBox.Text = resultado.uf
            Else
                MessageBox.Show("CEP não encontrado.")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar informações de CEP: " & ex.Message)
        End Try
    End Sub

    Private Sub TabControle_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControle.Selecting
        ' Verifique se o índice da aba selecionada é 3 (PAGE4 é a quarta aba, então o índice é 3)
        If e.TabPageIndex = 3 Then
            ' Coloque aqui o código que você deseja executar quando entrar na PAGE4
            ' Por exemplo:
            TabControle.SelectTab(2)
            TabControle.SelectTab(3)

            'mudar
            Try
                If ProtocoloREDESIMTextBox.Text <> "" Then
                    BtnConsultaRedeSim.Text = "Consultar"
                ElseIf ProtocoloREDESIMTextBox.Text = "" Then
                    If ProtocoloJuntaComercialTextBox.Text <> "" Then
                        BtnConsultaRedeSim.Text = "Consultar"
                        ProtocoloREDESIMTextBox.Text = ProtocoloJuntaComercialTextBox.Text
                    End If

                Else
                    BtnConsultaRedeSim.Text = "Solicitar"
                End If
            Catch ex As Exception
                MessageBox.Show("Erro! Verifique com o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub LinkLabeLPrazoEmpresaFacil_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabeLPrazoEmpresaFacil.LinkClicked
        ' Extrair apenas a parte da data do texto
        Dim dataText As String = DataProtJuntaComercialMaskedTextBox.Text.Substring(0, 10)
        ' Verificar se a data extraída é válida
        Dim dataProt As DateTime
        If DateTime.TryParseExact(dataText, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataProt) Then
            ' Adicionar 90 dias à data
            Dim prazoFinal As DateTime = dataProt.AddDays(90)
            ' Exibir a mensagem com a data calculada
            MessageBox.Show("O processo Empresa Fácil é cancelado por inatividade, automaticamente, após 90 dias. Após esse período, cancelado o processo, o nome empresarial deverá passar por nova consulta prévia." & vbCrLf & vbCrLf & "Prazo Final = " & prazoFinal.ToString("dd/MM/yyyy"))
        Else
            ' Se a data não for válida, exibir uma mensagem de erro
            MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy HH:mm.")
        End If

    End Sub

    Private Sub BtnMapa_Click(sender As Object, e As EventArgs) Handles BtnMapa.Click
        Mapa()
    End Sub

    Private Sub Mapa()
        ' Obtém o número do cadastro imobiliário a partir do TextBox
        Dim cadastroImobiliario As String = CadImobTextBox.Text.Trim()

        ' Verifica se o campo está vazio
        If String.IsNullOrEmpty(cadastroImobiliario) Then
            MessageBox.Show("Por favor, insira um número de cadastro imobiliário.", "Número de Cadastro Imobiliário Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Copia o número do cadastro imobiliário para a área de transferência
        Clipboard.SetText(cadastroImobiliario)

        ' Mensagem de pergunta ao usuário
        Dim result As DialogResult = MessageBox.Show("Deseja abrir o mapa da cidade com o cadastro imobiliário " & cadastroImobiliario & "?", "Abrir Mapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verifica a resposta do usuário
        If result = DialogResult.Yes Then
            If WebSiteGERAL.Visible = True Then
                ' Coloca foco e frente
                WebSiteGERAL.Focus()
                WebSiteGERAL.BringToFront()
            Else
                ' Mostra a janela
                WebSiteGERAL.Show()
                WebSiteGERAL.BringToFront()
            End If

            ' Define a URL com o número do cadastro imobiliário
            WebSiteGERAL.WebView.Source = New Uri("http://geoproc.maringa.pr.gov.br:8090/SIGMARINGA/")
        End If
    End Sub

    Private Sub BtnCopiaCEP_Click(sender As Object, e As EventArgs) Handles BtnCopiaCEP.Click
        ' Obter o texto do CEPMaskedTextBox
        Dim cep As String = EndCEPMaskedTextBox.Text

        ' Remover o hífen
        Dim cepSemHifen As String = cep.Replace("-", "")

        ' Copiar o resultado para a área de transferência
        Clipboard.SetText(cepSemHifen)

        ' Informar ao usuário que o CEP foi copiado
        'MessageBox.Show("CEP copiado para a área de transferência: " & cepSemHifen, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
