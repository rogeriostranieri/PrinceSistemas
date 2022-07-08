Imports System.Data.SqlClient
Imports System.Globalization

Public Class FrmAlvara



    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub



    Private Sub LaudosConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.CADSituacaoAlvara'. Você pode movê-la ou removê-la conforme necessário.
        Me.CADSituacaoAlvaraTableAdapter.Fill(Me.PrinceDBDataSet.CADSituacaoAlvara)
        'carregar statuscombobox com bando de dados CADstatus
        SituacaoComboBox.DataSource = Me.CADSituacaoAlvaraBindingSource
        SituacaoComboBox.DisplayMember = "Descricao"
        SituacaoComboBox.ValueMember = "Descricao"




        ' My.Application.DoEvents()
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


        BtnEditar.Text = "Editar"
        GroupBox9.Enabled = False
        GroupBox4.Enabled = False

        'ativa os provisorio datas
        DesativaDataProvisorio()

        'tirar borda do TableLayoutPanel1
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None
    End Sub

    Private Sub DesativaDataProvisorio()
        BombeiroProvisorioDATAMaskedTextBox.ReadOnly = True
        AmbientalProvisorioDATAMaskedTextBox.ReadOnly = True
        ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = True
        SanitarioProvisorioDATAMaskedTextBox.ReadOnly = True
        SetranProvisorioDATAMaskedTextBox.ReadOnly = True

    End Sub

    Private Sub SituacaoCombo()
        Try
            Select Case True
                Case SituacaoComboBox.Text.Contains("Andamento")

                    TabAlvara.SelectTab(1)
                    AvisarDiaMaskedTextBox.Select()
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Pagamento")
                    TabAlvara.SelectTab(1)
                    AvisarDiaMaskedTextBox.Select()
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Paralisado")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False


                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Baixado")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Não Fazer")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Cancelado")
                    TabAlvara.SelectTab(0)
                    AvisarDiaMaskedTextBox.Text = ""
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    ButtonSolicitar.Visible = True
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Finalizado")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = True
                    ProtocoloTipoTextBox.Visible = True
                    ProtocoloNTextBox.Visible = True
                    ProtocoloAnoTextBox.Visible = True
                    ProtocoloSenhaTextBox.Visible = True

                    AvisarDiaMaskedTextBox.Text = ""
                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True


                Case SituacaoComboBox.Text.Contains("Provisório")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = True
                    ProtocoloTipoTextBox.Visible = True
                    ProtocoloNTextBox.Visible = True
                    ProtocoloAnoTextBox.Visible = True
                    ProtocoloSenhaTextBox.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Protocolado")
                    TabAlvara.SelectTab(3)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = True
                    ProtocoloTipoTextBox.Visible = True
                    ProtocoloNTextBox.Visible = True
                    ProtocoloAnoTextBox.Visible = True
                    ProtocoloSenhaTextBox.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Pendência")
                    TabAlvara.SelectTab(1)
                    AvisarDiaMaskedTextBox.Select()
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True

                Case SituacaoComboBox.Text.Contains("Não Iniciado")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = False
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = False
                    ProtocoloTipoTextBox.Visible = False
                    ProtocoloNTextBox.Visible = False
                    ProtocoloAnoTextBox.Visible = False
                    ProtocoloSenhaTextBox.Visible = False

                    AvisarDiaMaskedTextBox.Select()
                    ButtonSolicitar.Visible = True
                    ButtonConsultar.Visible = False



                Case SituacaoComboBox.Text.Contains("Finalizado Definitivo")
                    TabAlvara.SelectTab(0)
                    DataEntradaLabel.Visible = True
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = True
                    ProtocoloTipoTextBox.Visible = True
                    ProtocoloNTextBox.Visible = True
                    ProtocoloAnoTextBox.Visible = True
                    ProtocoloSenhaTextBox.Visible = True

                    AvisarDiaMaskedTextBox.Text = ""
                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True
                    'ambiental
                    If LabelAmbientalDataProvisorio.Text = "" Then
                        LabelAmbientalDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                    'viabilidade
                    If LabelViabilidadeDataProvisorio.Text = "" Then
                        LabelViabilidadeDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                    'sanitario
                    If LabelSanitarioDataProvisorio.Text = "" Then
                        LabelSanitarioDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                    'setran
                    If LabelSetranDataProvisorio.Text = "" Then
                        LabelSetranDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If

                Case Else
                    DataEntradaLabel.Visible = True
                    'protocolo
                    DataEntradaMaskedTextBox.Visible = True
                    ProtocoloTipoTextBox.Visible = True
                    ProtocoloNTextBox.Visible = True
                    ProtocoloAnoTextBox.Visible = True
                    ProtocoloSenhaTextBox.Visible = True

                    ButtonSolicitar.Visible = False
                    ButtonConsultar.Visible = True


                    ' Case False

            End Select


        Catch ex As Exception
            MessageBox.Show("Erro ao carregar Situação")
        End Try


    End Sub

    Private Sub PreSalvar()
        'ver BOmbeiroProvisoriodata está com valor
        If BombeiroProvisorioDATAMaskedTextBox.Text <> "" Or AmbientalProvisorioDATAMaskedTextBox.Text <> "" Or ViabilidadeProvisorioDATAMaskedTextBox.Text <> "" Or SanitarioProvisorioDATAMaskedTextBox.Text <> "" Or SetranProvisorioDATAMaskedTextBox.Text <> "" Then
            SalvarFinal()
        Else
            Salvar()
        End If
    End Sub
    Private Sub SalvarFinal()

        Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text

        Try
            'pergunta salvar yesnocancel
            Dim message As String
            message = String.Format("Deseja Salvar as alterações realizada?")
            'mostra mensagem box SIM OU NAO OU CANCELA
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                ' e.Cancel = True
            ElseIf result = DialogResult.No Then
                BtnEditar.Text = "Editar"
                Button17.Enabled = True
                GroupBox9.Enabled = False
                GroupBox4.Enabled = False
                Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                'retorna para CNPJMaskedTextBox empresa que estava  
                ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                'focar ComboBoxBuscaCNPJ
                ComboBoxBuscaCNPJ.Select()
                DesativaDataProvisorio()
            ElseIf result = DialogResult.Yes Then
                Try

                    'Salva alterações
                    Me.Validate()
                    Me.LaudosBindingSource.EndEdit()
                    Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                    Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

                    'Modifica bloqueando td novamente
                    BtnEditar.Text = "Editar"
                    GroupBox9.Enabled = False
                    GroupBox4.Enabled = False

                    'retorna para CNPJMaskedTextBox empresa que estava  
                    ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                    'focar ComboBoxBuscaCNPJ
                    ComboBoxBuscaCNPJ.Select()
                    DesativaDataProvisorio()

                Catch exc As Exception

                    MessageBox.Show("2 - Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try
            Else

                BtnEditar.Text = "Editar"
                Button17.Enabled = True
                GroupBox9.Enabled = False
                GroupBox4.Enabled = False
                Button17.Enabled = True
                Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


                'retorna para CNPJMaskedTextBox empresa que estava  
                ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                'focar ComboBoxBuscaCNPJ
                ComboBoxBuscaCNPJ.Select()
                DesativaDataProvisorio()

            End If


        Catch ex As Exception
            MessageBox.Show("2 - Ocorreu um Erro ao Salvar" + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub
    Private Sub Salvar()

        Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text
        Try
            Dim changedRecords As DataTable
            ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
            Me.LaudosBindingSource.EndEdit()
            changedRecords = PrinceDBDataSet.Laudos.GetChanges()


            If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then


                Dim message As String
                message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar as alterações?", changedRecords.Rows.Count)
                'mostra mensagem box SIM OU NAO OU CANCELA
                Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                    ' e.Cancel = True
                ElseIf result = DialogResult.No Then
                    BtnEditar.Text = "Editar"
                    Button17.Enabled = True
                    GroupBox9.Enabled = False
                    GroupBox4.Enabled = False
                    'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Naturezajuridica'. Você pode movê-la ou removê-la conforme necessário.
                    '  Me.NaturezajuridicaTableAdapter.Fill(Me.PrinceDBDataSet.Naturezajuridica)
                    'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
                    Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

                    'retorna para CNPJMaskedTextBox empresa que estava  
                    ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                    'focar ComboBoxBuscaCNPJ
                    ComboBoxBuscaCNPJ.Select()
                    DesativaDataProvisorio()
                ElseIf result = DialogResult.Yes Then
                    Try

                        'Salva alterações
                        Me.Validate()
                        Me.LaudosBindingSource.EndEdit()
                        Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
                        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                        'salvar


                        'Modifica bloqueando td novamente
                        BtnEditar.Text = "Editar"
                        GroupBox9.Enabled = False
                        GroupBox4.Enabled = False

                        'retorna para CNPJMaskedTextBox empresa que estava  
                        ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                        'focar ComboBoxBuscaCNPJ
                        ComboBoxBuscaCNPJ.Select()
                        DesativaDataProvisorio()
                    Catch exc As Exception

                        MessageBox.Show("1 - Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                End If

            Else
                BtnEditar.Text = "Editar"
                GroupBox9.Enabled = False
                GroupBox4.Enabled = False
                Button17.Enabled = True
                'retorna para CNPJMaskedTextBox empresa que estava  
                ComboBoxBuscaCNPJ.Text = CNPJdaEmpresa
                'focar ComboBoxBuscaCNPJ
                ComboBoxBuscaCNPJ.Select()
                DesativaDataProvisorio()
            End If


        Catch ex As Exception
            MessageBox.Show("1 - Ocorreu um Erro ao Salvar" + vbCrLf + ex.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControlAcompanhamento.SelectTab(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControlAcompanhamento.SelectTab(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControlAcompanhamento.SelectTab(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControlAcompanhamento.SelectTab(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControlAcompanhamento.SelectTab(4)
    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click

        'Abrir anotações direto
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)


        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            'tirar espaço do textbox laudo
            NlaudoTextBox.Text = NlaudoTextBox.Text.Replace(" ", "")
            'termina  

            'Copia
            Clipboard.SetText(NlaudoTextBox.Text)

            MsgBox("Protocolo Copiado e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")

            System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br/laudosnew/consultar.php")


        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then
            'tirar espaço do textbox laudo
            NlaudoTextBox.Text = NlaudoTextBox.Text.Replace(" ", "")
            'termina  

            'Copia
            Clipboard.SetText(NlaudoTextBox.Text)

            MsgBox("Protocolo Copiado e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")

            System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br:9900/fazendaonline/")


        ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then

            MessageBox.Show("Ligar ou Comparecer na Prefeitura da cidade onde foi solicitado", "Prince Ajuda")

        ElseIf ModeloSistemaComboBox.Text = "Consulta Prévia" Then

            MessageBox.Show("Consulta Prévia solicitada antes do pedido de alvará na Prefeitura", "Prince Ajuda")


        ElseIf ModeloSistemaComboBox.Text = "Junta Comercial" Then

            Select Case EndEstadoLabel2.Text.Trim()
                Case "PR"
                    System.Diagnostics.Process.Start("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + NlaudoTextBox.Text)
                Case "SC"
                    System.Diagnostics.Process.Start("http://regin.jucesc.sc.gov.br/requerimentoUniversal/Viabilidades.aspx")
                Case ""
                    TabAlvara.SelectTab(0)
                    TabControl2.SelectTab(1)
                    If EndEstadoTextBox.Text = "" Then
                        MessageBox.Show("Preencher o endereço completo e salvar para atualizar o formulário", "Prince Ajuda")
                    Else
                        MessageBox.Show("Estado Não cadastrado, favor contatar o administrador do sistema", "Prince Ajuda")

                    End If


            End Select

        Else

            MessageBox.Show("Sem sistema para consulta", "Prince Sistemas - Alerta")

        End If



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnCalendarioWindows.Click
        If MsgBox(" Deseja salvar vencimento do Alvará no Calendário do Windows ?", MsgBoxStyle.YesNo, "Prince Sistemas - Pergunta") = MsgBoxResult.Yes Then

            Try
                '  Dim Abrir As New Process
                ' Abrir.StartInfo.FileName = "outlookcal:"
                '  Abrir.Start()
                System.Diagnostics.Process.Start("outlookcal:")
            Catch
                MessageBox.Show("Funciona apenas no Windows 10 ou superior", "Prince Sistema - Informa!")

            End Try


        End If






    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.LaudosBindingSource.AddNew()

            SituacaoComboBox.SelectedIndex = 0

            'unchek lembrete
            LembreteCheckBox.CheckState = CheckState.Unchecked

            'Uncheck controle de ligações
            BombeirosCheckBox.CheckState = CheckState.Unchecked
            ViabilidadeCheckBox.CheckState = CheckState.Unchecked
            AmbientalCheckBox.CheckState = CheckState.Unchecked
            SanitarioCheckBox.CheckState = CheckState.Unchecked
            SetranCheckBox.CheckState = CheckState.Unchecked

            'Combobox
            SituacaoComboBox.Text = "Não Iniciado"
            ModeloSistemaComboBox.SelectedIndex = -1
            BombeiroSituacaoComboBox.SelectedIndex = -1

            'data agora
            DataCriadoMaskedTextBox.Text = DateTime.Now.ToString()

            Editar()

        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.LaudosBindingSource.RemoveCurrent()
            Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'Salvar()
        PreSalvar()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Me.Close()

    End Sub

    Private Sub LaudosConsulta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.LaudosBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.Laudos.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)


            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try

                    LaudosTableAdapter.Update(PrinceDBDataSet.Laudos)

                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If


        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


        System.Diagnostics.Process.Start("http://www.prevfogo.pr.gov.br/")


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        System.Diagnostics.Process.Start("http://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Solicitacao-de-Vistoria")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        System.Diagnostics.Process.Start("https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Acompanhar-Processo")

    End Sub



    Private Sub NlaudoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NlaudoTextBox.TextChanged

        NlaudoTextBox.Text = NlaudoTextBox.Text.Replace(" ", "")


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'verificar CNPJLabel contem a palavra "CNPJ"
        If CNPJLabel.Text = "CNPJ:" Then
            BoxConsultaCNPJLaudo.Show()
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Application.OpenForms.OfType(Of Telefones)().Count() > 0 Then

            Telefones.Focus()


        Else

            ' Telefones.MdiParent = Me
            Telefones.Show()

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Application.OpenForms.OfType(Of Contador)().Count() > 0 Then

            Contador.Focus()
            '   Contador.MdiParent = MDIPrincipal


        Else

            ' Contador.MdiParent = MDIPrincipal
            Contador.Show()


        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br/laudosnew/mostrar_validacao_cod_controle.php?cod_pmm=" & Sanitariocontrole1TextBox.Text & "&cod_controle=" & Sanitariocontrole2TextBox.Text & "&cod_ca=" & Sanitariocontrole3TextBox.Text & "&Submit=Mostrar")
    End Sub




    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                'Using WS = New WSCorreios.AtendeClienteClient()
                Dim Resultado = WS.consultaCEP(EndCEPMaskedTextBox.Text)
                EnderecoTextBox.Text = Resultado.[end]
                'EndComplementoTextBox.Text = Resultado.complemento
                EndCompTextBox.Text = Resultado.complemento2
                EndCidadeTextBox.Text = Resultado.cidade
                EndBairroTextBox.Text = Resultado.bairro
                EndEstadoTextBox.Text = Resultado.uf
                ' mgs de erro

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try

        End Using
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br:9900/fazendaonline/")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TabControl2.SelectTab(1)
        TabControl2.SelectTab(4)
        CNPJRequerenteMaskedTextBox.Text = CNPJMaskedTextBox.Text
        EndRequerenteTextBox.Text = EnderecoTextBox.Text & ", Nº: " & EndNumTextBox.Text & ", " & EndCompTextBox.Text & ", " & EndBairroTextBox.Text & ", CEP: " & EndCEPMaskedTextBox.Text & ", " & EndCidadeTextBox.Text & "-" & EndEstadoTextBox.Text
        'FoneRequerenteTextBox.Text = TelefoneMaskedTextBox.Text
        'EmailRequerenteTextBox.Text = "legalizacaobetel@gmail.com"

        If Trim(FoneRequerenteTextBox.Text) = "" Then
            Contador.Show() ' pégando apenas o 1 cadastro
            FoneRequerenteTextBox.Text = Contador.TelefoneMaskedTextBox.Text
        End If

        If Trim(EmailRequerenteTextBox.Text) = "" Then
            Contador.Show() ' pégando apenas o 1 cadastro
            EmailRequerenteTextBox.Text = Contador.EmailTextBox.Text
        End If

        Contador.Close()

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            Button9.Visible = True


        Else
            Button9.Visible = False


        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles ButtonSolicitar.Click
        GroupBox4.Text = "Dados Cadastrais"

        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then

            'System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br/laudosnew/index.php")
            If Application.OpenForms.OfType(Of FrmWebLaudoAntigo)().Count() > 0 Then

                FrmWebLaudoAntigo.Focus()

            Else

                FrmWebLaudoAntigo.Show()

            End If

        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then

            System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br:9900/fazendaonline/")


        ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then

            MessageBox.Show("Documentos Manuais da Prefeitura da cidade onde a empresa se localiza", "Prince Ajuda")

        ElseIf ModeloSistemaComboBox.Text = "Consulta Prévia" Then

            MessageBox.Show("Consulta Prévia realizada no site da prefeitura, antecipa a liberação do alvará ou  Cadastro Imobiliário", "Prince Ajuda")


        ElseIf ModeloSistemaComboBox.Text = "Bombeiro Certificado" Then
            TabAlvara.SelectTab(1)

        Else

            MessageBox.Show("Informar qual tipo de sistema utilizado na solicitação do laudo - alvará de localização", "Prince Sistemas - Alerta")

        End If
    End Sub

    Private Sub SituacaoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SituacaoComboBox.TextChanged, SituacaoComboBox.SelectedIndexChanged


        SituacaoCombo()

    End Sub



    Private Sub Btnempresa_Click(sender As Object, e As EventArgs) Handles Btnempresa.Click
        Call ConexaoEmpresa()

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabAlvara.SelectTab(0)
        TabControl2.SelectTab(1)

        FrmProcedimentos.Show()
        If EndCidadeTextBox.Text = "" Then

            MessageBox.Show("Campo em Dados Cadastrais/Endereço/Cidade está vazio", "Prince Sistemas - Alerta")

        ElseIf EndEstadoTextBox.Text = "" Then
            MessageBox.Show("Campo em Dados Cadastrais/Endereço/Estado está vazio", "Prince Sistemas - Alerta")

        End If

        FrmProcedimentos.TxtCidade.Text = EndCidadeTextBox.Text
        FrmProcedimentos.TxtEstado.Text = EndEstadoTextBox.Text
        FrmProcedimentos.BtnBusca.PerformClick()
    End Sub




    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        NaturezaDoPedidoRichTextBox.Text &= "
" & NaturezaListBox.SelectedItem & " / "

    End Sub

    Private Sub CMCLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CMCLabel.LinkClicked
        MessageBox.Show("Nº. do Cadastro Municipal", "Prince Sistemas - Informa")

    End Sub

    Private Sub BtnAtualizarDados_Click(sender As Object, e As EventArgs) Handles BtnAtualizarDados.Click
        If MessageBox.Show("Deseja efetuar a atualização dos dados apenas?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'ModCon.Historico()
            ModCon.Atualizadadadoslaudo()

        Else
            ModCon.Atualizadadadoslaudo()

        End If

    End Sub


    Private Sub BtnNovaAlteracao_Click(sender As Object, e As EventArgs) Handles BtnNovaAlteracao.Click


        If MessageBox.Show("Deseja fazer nova alteração no Laudo?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ModCon.Historico()
            ' ModCon.Atualizadadadoslaudo()

        ElseIf System.Windows.Forms.DialogResult.No Then
            If MessageBox.Show("Tem certeza que deseja limpar os dados do andamento geral?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                SituacaoComboBox.SelectedIndex = 0
                'Limpando as BOX
                NlaudoTextBox.Text = ""
                ModeloSistemaComboBox.Text = ""
                NaturezaDoPedidoRichTextBox.Text = ""

                DataEntradaMaskedTextBox.Text = ""
                ProtocoloTipoTextBox.Text = ""
                ProtocoloNTextBox.Text = ""
                ProtocoloAnoTextBox.Text = ""
                ProtocoloSenhaTextBox.Text = ""
            Else
            End If

        Else

        End If

    End Sub

    Private Sub BtnBombVer_Click(sender As Object, e As EventArgs) Handles BtnBombVer.Click
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)
    End Sub


    Private Sub BombeiroSituacaoComboBox_Enter(sender As Object, e As EventArgs) Handles BombeiroSituacaoComboBox.Enter
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)
    End Sub

    Private Sub Editar()
        If BtnEditar.Text = "Editar" Then
            BtnEditar.Text = "Cancelar"
            GroupBox9.Enabled = True
            GroupBox4.Enabled = True

            Button17.Enabled = False

        ElseIf BtnEditar.Text = "Cancelar" Then

            BtnEditar.Text = "Editar"
            GroupBox9.Enabled = False
            GroupBox4.Enabled = False

            Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text
            Salvar()
            RazaoSocialTextBox.Focus()

            Button17.Enabled = True

        End If
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()

    End Sub

    Private Sub ModeloSistemaComboBox_TextChanged(sender As Object, e As EventArgs) Handles ModeloSistemaComboBox.TextChanged
        If ModeloSistemaComboBox.Text = "Consulta Prévia" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Junta Comercial" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = True
        ElseIf ModeloSistemaComboBox.Text = "Alvará Manual" Then
            NlaudoLabel.Visible = True
            NlaudoTextBox.Visible = True
            ButtonConsultar.Visible = False
        Else
            NlaudoLabel.Visible = False
            NlaudoTextBox.Visible = False
            ButtonConsultar.Visible = False

        End If

    End Sub

    Private Sub BtnNovoProtocolo_Click(sender As Object, e As EventArgs) Handles BtnNovoProtocolo.Click
        If MessageBox.Show("Deseja salvar o protocolo no histórico?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ModCon.SalvaProtocolo()
            ' ModCon.Atualizadadadoslaudo()
        ElseIf System.Windows.Forms.DialogResult.No Then
            If MessageBox.Show("Tem certeza que deseja limpar o protocolo?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                'Limpando as BOX
                DataEntradaMaskedTextBox.Text = ""
                ProtocoloTipoTextBox.Text = ""
                ProtocoloNTextBox.Text = ""
                ProtocoloAnoTextBox.Text = ""
                ProtocoloSenhaTextBox.Text = ""
            Else
            End If

        Else

        End If

    End Sub

    Private Sub BtnProcotBomb_Click(sender As Object, e As EventArgs) Handles BtnProcotBomb.Click
        If MessageBox.Show("Deseja salvar o protocolo no histórico?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ModCon.SalvaProtocolBomb()

            ' ModCon.Atualizadadadoslaudo()
        ElseIf System.Windows.Forms.DialogResult.No Then
            If MessageBox.Show("Tem certeza que deseja limpar o protocolo?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                'Limpando as BOX
                BombeiroNProcessoMaskedTextBox.Text = ""
                BombeiroDataPedProcessoMaskedTextBox.Text = ""

            Else
            End If

        Else

        End If
    End Sub

    Private Sub BtnData1_Click(sender As Object, e As EventArgs) Handles BtnData1.Click
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        BombeiroDataPedProcessoMaskedTextBox.Text = DateTime.Now.ToString()

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim Processo As String = BombeiroNProcessoMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(Processo.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) ''

    End Sub



    '/////////// Inicio do codigo de mostrar calendario
    '///// TEM MAIS NO LOAD 
    Private Sub AvisarDiaMaskedTextBox_Click(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Click
        DialogCalendarioAlvara.Show()
        DialogCalendarioAlvara.Focus()
        'abrir no local onde está o mouse
        DialogCalendarioAlvara.Location = New Point(MousePosition.X, MousePosition.Y)

    End Sub


    Private Sub AvisarDiaMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Leave
        DialogCalendarioAlvara.Close()

    End Sub



    '/////////// fim do codigo de mostrar calendario


    Private Sub BtnAnotacoes_Click(sender As Object, e As EventArgs) Handles BtnAnotacoes.Click
        TabAlvara.SelectTab(1)
        TabControlAcompanhamento.SelectTab(0)
    End Sub

    Private Sub BtnContLigacao_Click(sender As Object, e As EventArgs) Handles BtnContLigacao.Click
        If Application.OpenForms.OfType(Of FrmLigacaoAlvara)().Count() > 0 Then

            FrmLigacaoAlvara.Focus()


        Else

            FrmLigacaoAlvara.MdiParent = MDIPrincipal
            FrmLigacaoAlvara.Show()

        End If
    End Sub

    Private Sub EndCidadeLabel2_Click(sender As Object, e As EventArgs) Handles EndCidadeLabel2.Click
        If EndCidadeLabel2.Text = "" Then

        Else
            TabAlvara.SelectTab(2)

        End If
    End Sub

    Private Sub BtnAnotacoesPref_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesPref.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

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

            FrmAnotacoes.lblMudaTexto.Text = "Prefeitura Municipal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Erro!" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub SituacaoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SituacaoComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub

    Private Sub ModeloSistemaComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ModeloSistemaComboBox.KeyPress
        e.Handled = True 'nao permitir escrita
    End Sub




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


    '//////////////////////////////////////// INICIO DATA PROVISORIO ////////////////////////////////////////////////////////////////

    Private Sub ButtonApagaDataBombeiro_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataBombeiro.Click
        'perguntar antes 
        If MsgBox("Deseja Alterar a data provisório do Bombeiro?", MsgBoxStyle.YesNo, "Apagar Bombeiro Provisório") = MsgBoxResult.Yes Then
            'limpar
            BombeiroProvisorioDATAMaskedTextBox.Text = ""
        Else

            If MsgBox("Deseja apagar a data de bombeiro provisório?", MsgBoxStyle.YesNo, "Apagar Bombeiro Provisório") = MsgBoxResult.Yes Then
                'Deixa dateTime NULL
                Dim OrderDate As SqlTypes.SqlDateTime = SqlTypes.SqlDateTime.Null
                BombeiroProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()
                'salvar
                Dim con As SqlConnection
                con = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                con.Open()
                Dim cmd As New SqlCommand With {
                .Connection = con,
                .CommandText = "UPDATE Laudos SET BombeiroProvisorioData = @BombeiroProvisorioData WHERE RazaoSocial = @RazaoSocial"
            }
                cmd.Parameters.AddWithValue("@BombeiroProvisorioData", OrderDate)
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                BombeiroProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()

                'BombeiroProvisorioDATAMaskedTextBox readyonly
                BombeiroProvisorioDATAMaskedTextBox.ReadOnly = True

            End If
        End If

    End Sub

    'Apagar Data Provisório Ambiental
    Private Sub ButtonApagaDataAmbiental_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataAmbiental.Click
        'perguntar antes 
        If MsgBox("Deseja Alterar a data provisório do Ambiental?", MsgBoxStyle.YesNo, "Apagar Bombeiro Provisório") = MsgBoxResult.Yes Then
            'limpar
            AmbientalProvisorioDATAMaskedTextBox.Text = ""
        Else
            If MsgBox("Deseja apagar a data de ambiental provisório?", MsgBoxStyle.YesNo, "Apagar Ambiental Provisório") = MsgBoxResult.Yes Then
                'Deixa dateTime NULL
                Dim OrderDate As SqlTypes.SqlDateTime = SqlTypes.SqlDateTime.Null
                AmbientalProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()
                'salvar
                Dim con As SqlConnection
                con = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                con.Open()
                Dim cmd As New SqlCommand With {
                .Connection = con,
                .CommandText = "UPDATE Laudos SET AmbientalProvisorioData = @AmbientalProvisorioData WHERE RazaoSocial = @RazaoSocial"
            }
                cmd.Parameters.AddWithValue("@AmbientalProvisorioData", OrderDate)
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                AmbientalProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()

                AmbientalProvisorioDATAMaskedTextBox.ReadOnly = True
            End If
        End If

    End Sub

    'Apagar Data Provisório Viabilidade
    Private Sub ButtonApagaDataViabilidade_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataViabilidade.Click
        'perguntar antes 
        If MsgBox("Deseja Alterar a data provisório do Viabilidade?", MsgBoxStyle.YesNo, "Apagar Bombeiro Provisório") = MsgBoxResult.Yes Then
            'limpar
            ViabilidadeProvisorioDATAMaskedTextBox.Text = ""
        Else
            If MsgBox("Deseja apagar a data de viabilidade provisório?", MsgBoxStyle.YesNo, "Apagar Viabilidade Provisório") = MsgBoxResult.Yes Then
                'Deixa dateTime NULL
                Dim OrderDate As SqlTypes.SqlDateTime = SqlTypes.SqlDateTime.Null
                ViabilidadeProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()
                'salvar
                Dim con As SqlConnection
                con = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                con.Open()
                Dim cmd As New SqlCommand With {
                    .Connection = con,
                    .CommandText = "UPDATE Laudos SET ViabilidadeProvisorioData = @ViabilidadeProvisorioData WHERE RazaoSocial = @RazaoSocial"
                }
                cmd.Parameters.AddWithValue("@ViabilidadeProvisorioData", OrderDate)
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                ViabilidadeProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()

                ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = True

            End If
        End If
    End Sub

    'Apagar Data Provisório Sanitario
    Private Sub ButtonApagaDataSanitario_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataSanitario.Click
        'perguntar antes 
        If MsgBox("Deseja Alterar a data provisório do Sanitário?", MsgBoxStyle.YesNo, "Apagar Bombeiro Provisório") = MsgBoxResult.Yes Then
            'limpar
            SanitarioProvisorioDATAMaskedTextBox.Text = ""
        Else
            If MsgBox("Deseja apagar a data de sanitário provisório?", MsgBoxStyle.YesNo, "Apagar Sanitário Provisório") = MsgBoxResult.Yes Then
                'Deixa dateTime NULL
                Dim OrderDate As SqlTypes.SqlDateTime = SqlTypes.SqlDateTime.Null
                SanitarioProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()
                'salvar
                Dim con As SqlConnection
                con = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                con.Open()
                Dim cmd As New SqlCommand With {
                    .Connection = con,
                    .CommandText = "UPDATE Laudos SET SanitarioProvisorioData = @SanitarioProvisorioData WHERE RazaoSocial = @RazaoSocial"
                }
                cmd.Parameters.AddWithValue("@SanitarioProvisorioData", OrderDate)
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                SanitarioProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()

                SanitarioProvisorioDATAMaskedTextBox.ReadOnly = True
            End If
        End If
    End Sub

    'Apagar Data Provisório Setran
    Private Sub ButtonApagaDataSetran_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataSetran.Click
        'perguntar antes 
        If MsgBox("Deseja Alterar a data provisório do Setran?", MsgBoxStyle.YesNo, "Apagar Bombeiro Provisório") = MsgBoxResult.Yes Then
            'limpar
            SetranProvisorioDATAMaskedTextBox.Text = ""
        Else
            If MsgBox("Deseja apagar a data de setran provisório?", MsgBoxStyle.YesNo, "Apagar Setran Provisório") = MsgBoxResult.Yes Then
                'Deixa dateTime NULL
                Dim OrderDate As SqlTypes.SqlDateTime = SqlTypes.SqlDateTime.Null
                SetranProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()
                'salvar
                Dim con As SqlConnection
                con = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                con.Open()
                Dim cmd As New SqlCommand With {
                    .Connection = con,
                    .CommandText = "UPDATE Laudos SET SetranProvisorioData = @SetranProvisorioData WHERE RazaoSocial = @RazaoSocial"
                }
                cmd.Parameters.AddWithValue("@SetranProvisorioData", OrderDate)
                cmd.Parameters.AddWithValue("@RazaoSocial", RazaoSocialTextBox.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                SetranProvisorioDATAMaskedTextBox.Text = OrderDate.ToString()

                SetranProvisorioDATAMaskedTextBox.ReadOnly = True
            End If
        End If


    End Sub

    Private Sub ButtonAddDataBombeiro_Click(sender As Object, e As EventArgs) Handles ButtonAddDataBombeiro.Click
        'pergunta se deseja adicionar
        If MsgBox("Deseja Adicionar uma nova data provisório do bombeiro?", MsgBoxStyle.YesNo, "Adicionar Bombeiro") = MsgBoxResult.Yes Then
            'visible true BombeiroProvisorioDATAMaskedTextBox
            BombeiroProvisorioDATAMaskedTextBox.ReadOnly = False
            'limpar BombeiroProvisorioDATAMaskedTextBox
            BombeiroProvisorioDATAMaskedTextBox.Text = ""
        Else
            'visible true BombeiroProvisorioDATAMaskedTextBox
            BombeiroProvisorioDATAMaskedTextBox.ReadOnly = False
        End If
    End Sub

    'Ambiental
    Private Sub ButtonAddDataAmbiental_Click(sender As Object, e As EventArgs) Handles ButtonAddDataAmbiental.Click
        'pergunta se deseja adicionar
        If MsgBox("Deseja Adicionar uma nova data provisório do Ambiental?", MsgBoxStyle.YesNo, "Adicionar Ambiental") = MsgBoxResult.Yes Then
            'visible true AmbientalProvisorioDATAMaskedTextBox
            AmbientalProvisorioDATAMaskedTextBox.ReadOnly = False
            'limpar AmbientalProvisorioDATAMaskedTextBox
            AmbientalProvisorioDATAMaskedTextBox.Text = ""
        Else
            'visible true AmbientalProvisorioDATAMaskedTextBox
            AmbientalProvisorioDATAMaskedTextBox.ReadOnly = False
        End If
    End Sub

    'viabilidade
    Private Sub ButtonAddDataViabilidade_Click(sender As Object, e As EventArgs) Handles ButtonAddDataViabilidade.Click
        'pergunta se deseja adicionar
        If MsgBox("Deseja Adicionar uma nova data provisório do Viabilidade?", MsgBoxStyle.YesNo, "Adicionar Viabilidade") = MsgBoxResult.Yes Then
            'visible true ViabilidadeProvisorioDATAMaskedTextBox
            ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = False
            'limpar ViabilidadeProvisorioDATAMaskedTextBox
            ViabilidadeProvisorioDATAMaskedTextBox.Text = ""
        Else
            'visible true ViabilidadeProvisorioDATAMaskedTextBox
            ViabilidadeProvisorioDATAMaskedTextBox.ReadOnly = False
        End If
    End Sub

    'Sanitario
    Private Sub ButtonAddDataSanitario_Click(sender As Object, e As EventArgs) Handles ButtonAddDataSanitario.Click
        'pergunta se deseja adicionar
        If MsgBox("Deseja Adicionar uma nova data provisório do Sanitário?", MsgBoxStyle.YesNo, "Adicionar Sanitário") = MsgBoxResult.Yes Then
            'visible true SanitarioProvisorioDATAMaskedTextBox
            SanitarioProvisorioDATAMaskedTextBox.ReadOnly = False
            'limpar SanitarioProvisorioDATAMaskedTextBox
            SanitarioProvisorioDATAMaskedTextBox.Text = ""
        Else
            'visible true SanitarioProvisorioDATAMaskedTextBox
            SanitarioProvisorioDATAMaskedTextBox.ReadOnly = False
        End If
    End Sub

    'Setran
    Private Sub ButtonAddDataSetran_Click(sender As Object, e As EventArgs) Handles ButtonAddDataSetran.Click
        'pergunta se deseja adicionar
        If MsgBox("Deseja Adicionar uma nova data provisório do Setran?", MsgBoxStyle.YesNo, "Adicionar Setran") = MsgBoxResult.Yes Then
            'visible true SetranProvisorioDATAMaskedTextBox
            SetranProvisorioDATAMaskedTextBox.ReadOnly = False
            'limpar SetranProvisorioDATAMaskedTextBox
            SetranProvisorioDATAMaskedTextBox.Text = ""
        Else
            'visible true SetranProvisorioDATAMaskedTextBox
            SetranProvisorioDATAMaskedTextBox.ReadOnly = False
        End If
    End Sub


    '////////////////////////////// INICIO LABEL DATA PROVISORIO ////////////////////////////////////////////////
    'Bombeiro
    Private Sub LabelBombeiroDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelBombeiroDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelBombeiroDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelBombeiroDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelBombeiroDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelBombeiroDataProvisorio.Text = OrderDateExtenso
            Else
                'verifica se o campo está vazio
                If LabelBombeiroDataProvisorio.Text = "" Then
                    'verifica se o BombeiroSituacaoComboBox está como "Finalizado Definitivo"
                    If BombeiroSituacaoComboBox.Text = "Finalizado Definitivo" Then
                        LabelBombeiroDataProvisorio.Text = "Liberado - Alvará Definitivo"
                    End If
                End If
            End If
        End If

    End Sub

    'Ambiental
    Private Sub LabelAmbientalDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelAmbientalDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelAmbientalDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelAmbientalDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelAmbientalDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelAmbientalDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub


    'Viabilidade
    Private Sub LabelViabilidadeDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelViabilidadeDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelViabilidadeDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelViabilidadeDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelViabilidadeDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelViabilidadeDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub

    'Sanitario
    Private Sub LabelSanitarioDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelSanitarioDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelSanitarioDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelSanitarioDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelSanitarioDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelSanitarioDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub

    'Setran
    Private Sub LabelSetranDataProvisorio_TextChanged(sender As Object, e As EventArgs) Handles LabelSetranDataProvisorio.TextChanged
        'verificar se tem letras
        If LabelSetranDataProvisorio.Text.Any(Function(c) Char.IsLetter(c)) Then
            'nao faz nada
        Else
            If LabelSetranDataProvisorio.Text <> "" Then
                Dim OrderDate As DateTime = Convert.ToDateTime(LabelSetranDataProvisorio.Text)
                Dim OrderDateExtenso As String = OrderDate.ToString("dddd, dd 'de' MMMM 'de' yyyy")
                LabelSetranDataProvisorio.Text = OrderDateExtenso
            Else

            End If
        End If

    End Sub


    '//////////////////////////////////////// FIM DATA PROVISORIO //////////////////////////////////////////////


    Private Sub BombeiroSituacaoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BombeiroSituacaoComboBox.SelectedIndexChanged
        If BombeiroSituacaoComboBox.Text = "Finalizado Definitivo" Then
            LabelBombeiroDataProvisorio.Text = "Liberado - Alvará Definitivo"
        End If
    End Sub


End Class