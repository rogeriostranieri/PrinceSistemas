﻿Imports System.Data.SqlClient
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

        'Carrega Combobox situação
        'Dim n As New ComboBox

        ' ModCombobox.ComboboxAlvara()

        '

        '///////////////////////INICIO DATA PROVISORIO ////////////////////////////////////////
        'Padrão
        'Location 22; 149
        'Size 115; 13

        'Location 137; 146
        'Size 66; 20

        'Location 205; 144
        'Size 28; 23
        '///////////////BOMBEIRO/////////////////
        'BombeiroDataProvisorioLabel Location
        BombeiroDataProvisorioLabel.Location = New Point(22, 149)
        'BombeiroDataProvisorioLabel tamanho
        BombeiroDataProvisorioLabel.Size = New Size(115, 13)
        'BombeiroProvisorioDATAMaskedTextBox1 Location
        BombeiroProvisorioDATAMaskedTextBox1.Location = New Point(137, 146)
        'BombeiroProvisorioDATAMaskedTextBox1 tamanho
        BombeiroProvisorioDATAMaskedTextBox1.Size = New Size(66, 20)
        'ButtonApagaDataBombeiro Label Location
        ButtonApagaDataBombeiro.Location = New Point(205, 144)
        'ButtonApagaDataBombeiro Label tamanho
        ButtonApagaDataBombeiro.Size = New Size(28, 23)

        '///////////////Ambiental/////////////////
        'AmbientalDataProvisorioLabel Location
        AmbientalDataProvisorioLabel1.Location = New Point(22, 149)
        'AmbientalDataProvisorioLabel tamanho
        AmbientalDataProvisorioLabel1.Size = New Size(115, 13)
        'AmbientalProvisorioDATAMaskedTextBox1 Location
        AmbientalProvisorioDATAMaskedTextBox1.Location = New Point(137, 146)
        'AmbientalProvisorioDATAMaskedTextBox1 tamanho
        AmbientalProvisorioDATAMaskedTextBox1.Size = New Size(66, 20)
        'ButtonApagaDataAmbiental Label Location
        ButtonApagaDataAmbiental.Location = New Point(205, 144)
        'ButtonApagaDataAmbiental Label tamanho
        ButtonApagaDataAmbiental.Size = New Size(28, 23)


        '///////////////Viabilidade/////////////////
        'ViabilidadeDataProvisorioLabel Location
        ViabilidadeDataProvisorioLabel.Location = New Point(22, 149)
        'ViabilidadeDataProvisorioLabel tamanho
        ViabilidadeDataProvisorioLabel.Size = New Size(115, 13)
        'ViabilidadeProvisorioDATAMaskedTextBox1 Location
        ViabilidadeProvisorioDATAMaskedTextBox1.Location = New Point(137, 146)
        'ViabilidadeProvisorioDATAMaskedTextBox1 tamanho
        ViabilidadeProvisorioDATAMaskedTextBox1.Size = New Size(66, 20)
        'ButtonApagaDataViabilidade Label Location
        ButtonApagaDataViabilidade.Location = New Point(205, 144)
        'ButtonApagaDataViabilidade Label tamanho
        ButtonApagaDataViabilidade.Size = New Size(28, 23)

        '///////////////Sanitario/////////////////
        'SanitarioDataProvisorioLabel Location
        SanitarioDataProvisorioLabel.Location = New Point(22, 149)
        'SanitarioDataProvisorioLabel tamanho
        SanitarioDataProvisorioLabel.Size = New Size(115, 13)
        'SanitarioProvisorioDATAMaskedTextBox1 Location
        SanitarioProvisorioDATAMaskedTextBox1.Location = New Point(137, 146)
        'SanitarioProvisorioDATAMaskedTextBox1 tamanho
        SanitarioProvisorioDATAMaskedTextBox1.Size = New Size(66, 20)
        'ButtonApagaDataSanitario Label Location
        ButtonApagaDataSanitario.Location = New Point(205, 144)
        'ButtonApagaDataSanitario Label tamanho
        ButtonApagaDataSanitario.Size = New Size(28, 23)


        '///////////////Setran/////////////////
        'SetranDataProvisorioLabel Location
        SetranDataProvisorioLabel.Location = New Point(22, 149)
        'SetranDataProvisorioLabel tamanho
        SetranDataProvisorioLabel.Size = New Size(115, 13)
        'SetranProvisorioDATAMaskedTextBox1 Location
        SetranProvisorioDATAMaskedTextBox1.Location = New Point(137, 146)
        'SetranProvisorioDATAMaskedTextBox1 tamanho
        SetranProvisorioDATAMaskedTextBox1.Size = New Size(66, 20)
        'ButtonApagaDataSetran Label Location
        ButtonApagaDataSetran.Location = New Point(205, 144)
        'ButtonApagaDataSetran Label tamanho
        ButtonApagaDataSetran.Size = New Size(28, 23)


        '/////////////////////// FIM ////////////////////////////////////////



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
    Private Sub Salvar()
        'arrumar o CNPJ ou CPF

        CNPJouCPF()


        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.LaudosBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.Laudos.GetChanges()


            If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

                Dim message As String

                'MOSTRA MENSAGM BOX
                'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
                message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

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

                ElseIf result = DialogResult.Yes Then
                    Try
                        'Salva alterações
                        Me.Validate()
                        Me.LaudosBindingSource.EndEdit()
                        Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)

                        'Modifica bloqueando td novamente
                        BtnEditar.Text = "Editar"
                        GroupBox9.Enabled = False
                        GroupBox4.Enabled = False

                        Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text
                        RazaoSocialTextBox.Focus()

                        'Verifica se foi alterado para finalizado e alterar Form Empresas
                        Select Case SituacaoComboBox.Text.Trim()
                            Case "Finalizado Definitivo"
                                If MsgBox("Deseja atualizar o status no cadastro da empresa?", MsgBoxStyle.YesNoCancel, "Atualização...") = MsgBoxResult.Yes Then
                                    Call ConexaoEmpresa()
                                End If
                            Case "Finalizado Provisório"
                                If MsgBox("Deseja atualizar o status no cadastro da empresa?", MsgBoxStyle.YesNoCancel, "Atualização...") = MsgBoxResult.Yes Then
                                    Call ConexaoEmpresa()
                                End If
                            Case Else
                        End Select
                        'Fim do codigo

                    Catch exc As Exception

                        MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                End If
            Else
                BtnEditar.Text = "Editar"
                GroupBox9.Enabled = False
                GroupBox4.Enabled = False

                Dim CNPJdaEmpresa As String = CNPJMaskedTextBox.Text
                ' Salvar() não precisa salvar pq nao teve alteração
                'ComboBox3.Text = CNPJdaEmpresa
                ' ComboBox3.Focus()
                RazaoSocialTextBox.Focus()

                Button17.Enabled = True

            End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectTab(4)
    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click

        'Abrir anotações direto
        TabAlvara.SelectTab(1)
        TabControl1.SelectTab(0)


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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
        Salvar()
        '  Else

        ' End If

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

    Private Sub BombeiroProvisorioDATAMaskedTextBox1_Validated(sender As Object, e As EventArgs) Handles BombeiroProvisorioDATAMaskedTextBox1.Validated
        Try
            BombeiroProvisorioDATAMaskedTextBox.Text = BombeiroProvisorioDATAMaskedTextBox1.Text

        Catch ex As Exception
            '      'mmenssagme "Ocorreu um erro ao preencher a data"
            MessageBox.Show("Ocorreu um erro ao preencher a data", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub AmbientalProvisorioDATAMaskedTextBox1_Validated(sender As Object, e As EventArgs) Handles AmbientalProvisorioDATAMaskedTextBox1.Validated
        Try
            'AmbientalDataProvisorioMaskedTextBox1.Text = AmbientalDataProvisorioMaskedTextBox.Text
            AmbientalProvisorioDATAMaskedTextBox.Text = AmbientalProvisorioDATAMaskedTextBox1.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViabilidadeProvisorioDATAMaskedTextBox1_Validated(sender As Object, e As EventArgs) Handles ViabilidadeProvisorioDATAMaskedTextBox1.Validated
        Try
            'ViabilidadeDataProvisorioMaskedTextBox1.Text = ViabilidadeDataProvisorioMaskedTextBox.Text
            ViabilidadeProvisorioDATAMaskedTextBox.Text = ViabilidadeProvisorioDATAMaskedTextBox1.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SanitarioProvisorioDATAMaskedTextBox1_Validated(sender As Object, e As EventArgs) Handles SanitarioProvisorioDATAMaskedTextBox1.Validated
        Try
            'SanitarioDataProvisorioMaskedTextBox1.Text = SanitarioDataProvisorioMaskedTextBox.Text
            SanitarioProvisorioDATAMaskedTextBox.Text = SanitarioProvisorioDATAMaskedTextBox1.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetranProvisorioDATAMaskedTextBox1_Validated(sender As Object, e As EventArgs) Handles SetranProvisorioDATAMaskedTextBox1.Validated
        Try
            'SetranDataProvisorioMaskedTextBox1.Text = SetranDataProvisorioMaskedTextBox.Text
            SetranProvisorioDATAMaskedTextBox.Text = SetranProvisorioDATAMaskedTextBox1.Text

        Catch ex As Exception

        End Try
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
        TabControl1.SelectTab(0)
    End Sub


    Private Sub BombeiroSituacaoComboBox_Enter(sender As Object, e As EventArgs) Handles BombeiroSituacaoComboBox.Enter
        TabAlvara.SelectTab(1)
        TabControl1.SelectTab(0)
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
        TabControl1.SelectTab(0)
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


    Private Sub LimparCNPJ()
        CNPJMaskedTextBox.Text = CNPJMaskedTextBox.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "").Replace(Environment.NewLine, "")
        '        permitir apenas numeros
        CNPJMaskedTextBox.Text = CNPJMaskedTextBox.Text.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "").Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "").Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "")

    End Sub

    Private Sub CNPJouCPF()
        LimparCNPJ()

        If CNPJMaskedTextBox.Text.Length = 14 Then
            LimparCNPJ()
            'CNPJMaskedTextBox.Text = CNPJMaskedTextBox.Text.Insert(2, "/").Insert(6, "/").Insert(10, "-")
            CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
            CNPJLabel.Text = "CNPJ:"
            'label localização  55; 63
            CNPJLabel.Location = New Point(46, 63)
        ElseIf CNPJMaskedTextBox.Text.Length = 11 Then
            LimparCNPJ()
            'CNPJMaskedTextBox.Text = CNPJMaskedTextBox.Text.Insert(3, "-").Insert(7, "-")
            CNPJMaskedTextBox.Mask = "000,000,000-00"
            CNPJLabel.Text = "CPF:"
            'label localizacao 48; 63
            CNPJLabel.Location = New Point(48, 63)
        Else
            LimparCNPJ()
            CNPJMaskedTextBox.Mask = ""
            CNPJLabel.Text = "Outro Doc:"
            'label localizacao 26; 63
            CNPJLabel.Location = New Point(26, 63)
        End If

        'apagar a máscara de um Textbox ao deletar os caracteres
        'CNPJMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals




    End Sub
    Private Sub CNPJMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles CNPJMaskedTextBox.Leave
        'verifica se os numeros e muda cnpj ou cpf, e não contar caracteres
        CNPJouCPF()

    End Sub

    Private Sub CNPJMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles CNPJMaskedTextBox.MaskInputRejected
        CNPJouCPF()
    End Sub
    'CNPJMaskedTextBox ao  apertar delete
    Private Sub CNPJMaskedTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CNPJMaskedTextBox.KeyDown
        If e.KeyCode = Keys.Delete Then
            'LimparCNPJ()
            CNPJMaskedTextBox.Text = ""
            CNPJLabel.Text = "CNPJ:"
            CNPJLabel.Location = New Point(46, 63)
        End If

        If e.KeyCode = Keys.Back Then
            CNPJMaskedTextBox.Text = ""
            CNPJLabel.Text = "CNPJ:"
            CNPJLabel.Location = New Point(46, 63)
        End If

        'ao colar
        If e.KeyCode = Keys.V And e.Control Then
            CNPJMaskedTextBox.Text = ""
            CNPJouCPF()
        End If
    End Sub


    Private Sub ButtonApagaDataBombeiro_Click_1(sender As Object, e As EventArgs) Handles ButtonApagaDataBombeiro.Click
        'apagar valor do BombeiroDATA do banco de dado Laudos where RazaoSocial
        'perguntar se deseja apagar
        If MsgBox("Deseja apagar a data do Bombeiro?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                Dim comando As New SqlCommand("UPDATE Laudos SET BombeiroProvisorioDATA = NULL WHERE RazaoSocial = '" & RazaoSocialTextBox.Text & "'", conexao)
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                'atualizar form
                ' Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                'mgsbox apagar
                MsgBox("Data do Bombeiro apagada com sucesso!")
                'LIMPAR AmbientalDATAMaskedTextBox1
                BombeiroProvisorioDATAMaskedTextBox.Text = ""
                BombeiroProvisorioDATAMaskedTextBox1.Text = ""
            Catch ex As Exception
                MsgBox("Erro!" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonApagaDataAmbiental_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataAmbiental.Click
        'apagar valor do AmbientalDATA do banco de dado Laudos where RazaoSocial
        'perguntar se deseja apagar
        If MsgBox("Deseja apagar a data do Ambiental?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                Dim comando As New SqlCommand("UPDATE Laudos SET AmbientalProvisorioDATA = NULL WHERE RazaoSocial = '" & RazaoSocialTextBox.Text & "'", conexao)
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                'atualizar form
                ' Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                'mgsbox apagar
                MsgBox("Data do Ambiental apagada com sucesso!")
                'LIMPAR AmbientalDATAMaskedTextBox1
                AmbientalProvisorioDATAMaskedTextBox.Text = ""
                AmbientalProvisorioDATAMaskedTextBox1.Text = ""
            Catch ex As Exception
                MsgBox("Erro!" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonApagaDataViabilidade_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataViabilidade.Click
        'apagar valor do ViabilidadeDATA do banco de dado Laudos where RazaoSocial
        'perguntar se deseja apagar
        If MsgBox("Deseja apagar a data de Viabilidade?", MsgBoxStyle.YesNo, "Apagar Data Viabilidade") = MsgBoxResult.Yes Then
            Try
                Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                Dim comando As New SqlCommand("UPDATE Laudos SET ViabilidadeProvisorioDATA = NULL WHERE RazaoSocial = '" & RazaoSocialTextBox.Text & "'", conexao)
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                'atualizar form
                ' Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                'mgsbox apagar
                MsgBox("Data do Viabilidade apagada com sucesso!")
                'LIMPAR ViabilidadeDATAMaskedTextBox1
                ViabilidadeProvisorioDATAMaskedTextBox.Text = ""
                ViabilidadeProvisorioDATAMaskedTextBox1.Text = ""
            Catch ex As Exception
                MsgBox("Erro!" & vbCrLf & ex.Message)
            End Try
        End If

    End Sub

    Private Sub ButtonApagaDataSanitario_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataSanitario.Click
        'apanhar valor do SanitarioDATA do banco de dado Laudos where RazaoSocial
        'perguntar se quer apagar
        If MsgBox("Deseja apagar a data de Sanitário?", vbYesNo, "Apagar") = vbYes Then
            Try
                Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                Dim comando As New SqlCommand("UPDATE Laudos SET SanitarioProvisorioDATA = NULL WHERE RazaoSocial = '" & RazaoSocialTextBox.Text & "'", conexao)
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                'atualizar form
                ' Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                'mgsbox apagar
                MsgBox("Data do Sanitário apagada com sucesso!")
                'LIMPAR SanitarioDATAMaskedTextBox1
                SanitarioProvisorioDATAMaskedTextBox.Text = ""
                SanitarioProvisorioDATAMaskedTextBox1.Text = ""
            Catch ex As Exception
                MsgBox("Erro!" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonApagaDataSetran_Click(sender As Object, e As EventArgs) Handles ButtonApagaDataSetran.Click
        'apagar valor do SetranDATA do banco de dado Laudos where RazaoSocial
        'perguntar antes de apagar
        If MessageBox.Show("Deseja apagar a data do Setran?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                Dim comando As New SqlCommand("UPDATE Laudos SET SetranProvisorioDATA = NULL WHERE RazaoSocial = '" & RazaoSocialTextBox.Text & "'", conexao)
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                'atualizar form
                ' Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
                'mgsbox apagar
                MsgBox("Data do Setran apagada com sucesso!")
                'LIMPAR SetranDATAMaskedTextBox1
                SetranProvisorioDATAMaskedTextBox.Text = ""
                SetranProvisorioDATAMaskedTextBox1.Text = ""
            Catch ex As Exception
                MsgBox("Erro!" & vbCrLf & ex.Message)
            End Try
        End If
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
End Class