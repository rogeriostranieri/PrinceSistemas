﻿Imports System.IO
Imports System.Net.Mail

Public Class FrmMail
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub FrmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.eMailCaixaDeSaida'. Você pode movê-la ou removê-la conforme necessário.
        Me.EMailCaixaDeSaidaTableAdapter.Fill(Me.PrinceDBDataSet.eMailCaixaDeSaida)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.eMail'. Você pode movê-la ou removê-la conforme necessário.
        Me.EMailTableAdapter.Fill(Me.PrinceDBDataSet.eMail)

        ProgressBar1.Value = 0
        ProgressBar1.BackColor = Color.Green
        'inicia selecionando ComboBoxCaixaSaida primeiro item
        ComboBoxCaixaSaida.SelectedIndex = -1

    End Sub



    Private Sub Salvar()

        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.EMailBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.eMail.GetChanges()


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
                Me.EMailTableAdapter.Fill(Me.PrinceDBDataSet.eMail)

            ElseIf result = DialogResult.Yes Then
                Try
                    'Salva alterações
                    Me.Validate()
                    Me.EMailBindingSource.EndEdit()
                    Me.EMailTableAdapter.Update(Me.PrinceDBDataSet.eMail)

                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If
        Else



        End If

    End Sub




    'tem que configurar no cliente POP/IMAP e habilitar e ter os dados"
    Private Sub EnviarEmail()
        If MsgBox(" Deseja enviar este e-Mail?", MsgBoxStyle.YesNo, "Enviar") = MsgBoxResult.Yes Then
            'inicia o ProgressBar1
            ProgressBar1.Value = 0

            ProgressBar1.BackColor = Color.Green
            TabControle.SelectedIndex = 2
            TabControle.SelectedIndex = -1

            'codigo de entrada de dados 
            Dim UserName As String = EMailTextBox.Text
            Dim Destinatario As String = TextBoxPara.Text
            Dim UserSenha As String = SenhaEmailTextBox.Text
            Dim destinatarios As String = Destinatario
            Dim Enviar As New System.Net.Mail.MailMessage '= New System.Net.Mail.MailMessage()

            ProgressBar1.Value = 50

            Enviar.From = New System.Net.Mail.MailAddress(UserName)

            For Each mail As String In destinatarios.Split(New Char() {","c})
                Enviar.To.Add(New System.Net.Mail.MailAddress(mail))
            Next

            Enviar.Subject = TextBoxAssunto.Text
            Enviar.Body = RichTextBoxMensagem.Text
            Enviar.IsBodyHtml = True
            Enviar.Priority = System.Net.Mail.MailPriority.High

            ProgressBar1.Value = 80

            'anexos
            'atribui caminhos dos anexos

            For Each filePath As String In OpenFileDialog1.FileNames
                If File.Exists(filePath) Then
                    Dim fileName As String = Path.GetFileName(filePath)
                    Enviar.Attachments.Add(New Attachment(filePath))
                End If
            Next

            'fim codigo de entrada de dados 
            'inicio da confg para envio


            Dim client As New SmtpClient With {
                .Host = SmtpClientTextBox.Text,
                .Port = SmtpPortTextBox.Text,
                .EnableSsl = HabilitaSslComboBox.Text,
                .UseDefaultCredentials = CredencialComboBox.Text
            }

            'Arquivos que vão em anexo dentro de um ListBox
            ProgressBar1.Value = 50

            client.Credentials = New System.Net.NetworkCredential(UserName, UserSenha)
            client.DeliveryMethod = SmtpDeliveryMethod.Network



            Try
                ProgressBar1.Value = 90

                'envia o email
                client.Send(Enviar)

                'anexa na caixa de saida os dados
                ModeMail.EmailCaixaDeSaida()
                'atualiza a caixa de saida neste form
                Me.EMailCaixaDeSaidaTableAdapter.Fill(Me.PrinceDBDataSet.eMailCaixaDeSaida)
                Me.Refresh()



                'limpa tudo
                TextBoxPara.Text = ""
                TextBoxAssunto.Text = "Digite aqui o assunto..."
                RichTextBoxMensagem.Text = "Seu texto ...."
                LblAnexo.Text = "Anexo..."



                'finaliza mostrando que está tudo ok
                '    Timer1.Stop()
                '    Timer1.Enabled = False
                ProgressBar1.BackColor = Color.Green

                ProgressBar1.Value = 100

                'mgs "E-mail enviado com sucesso" com titulo Email
                MsgBox("E-mail enviado com sucesso", MsgBoxStyle.Information, "Prince Sistemas - e-Mail")

            Catch ex As Exception
                ProgressBar1.Value = 100
                ProgressBar1.BackColor = Color.Red
                MessageBox.Show("Erro ao enviar o e-mail ,tente novamente ou configure corretamente os dados nas configurações")
                'mostrar erro
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Prince Sistemas - e-Mail")
            End Try
        End If
    End Sub

    Private Sub EMailCaixaDeSaidaDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EMailCaixaDeSaidaDataGridView.CellContentDoubleClick
        'nao importa onde clicar na coluna,sempre usar a coluna DataGridViewTextBoxColumn7
        'sempre usar a coluna DataGridViewTextBoxColumn7
        If e.RowIndex >= 0 Then
            'seleciona o registro que foi clicado
            Dim row As DataGridViewRow = EMailCaixaDeSaidaDataGridView.CurrentRow
            'pega o valor da coluna
            'Dim valor As String = row.Cells(DataGridViewTextBoxColumn7.Index).Value.ToString
            Dim valor As String = row.Cells(DataGridViewTextBoxColumn7.Index).Value.ToString
            'abre o form de visualização
            Dim frm As New FrmEmailCaixaDeSaida
            'converter em datatime
            'filter "DataEnviado
            Dim data As DateTime = Convert.ToDateTime(valor)
            'filter "DataEnviado
            frm.EMailCaixaDeSaidaBindingSource.Filter = "DataEnviado = '" & data & "'"
            'mostra o form de visualização
            frm.ShowDialog()
        End If
    End Sub

    Private Sub ButtonExcluirSaida_Click(sender As Object, e As EventArgs) Handles ButtonExcluirSaida.Click

        Try
            If MsgBox(" Deseja apagar o e-mail enviado selecionado na caixa de saída?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
                'EMailCaixaDeSaida
                Try
                    EMailCaixaDeSaidaDataGridView.Rows.RemoveAt(EMailCaixaDeSaidaDataGridView.CurrentRow.Index)
                Catch ex As Exception
                    MsgBox("ERRO " & vbCrLf & ex.Message)
                End Try

                Me.Validate()
                '  Me.EMailCaixaDeSaidaBindingSource.RemoveCurrent()
                Me.EMailCaixaDeSaidaTableAdapter.Update(Me.PrinceDBDataSet.eMailCaixaDeSaida)
                Me.EMailCaixaDeSaidaTableAdapter.Fill(Me.PrinceDBDataSet.eMailCaixaDeSaida)

                'Dim indexLinha As Integer
                'indexLinha = EMailCaixaDeSaidaDataGridView.CurrentCell.RowIndex

                ' EMailCaixaDeSaidaDataGridView.Rows.RemoveAt(indexLinha)

                ' MessageBox.Show("Atualizando . . . !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("ERRO " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub FrmMail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.EMailBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.eMail.GetChanges()


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

                    EMailTableAdapter.Update(PrinceDBDataSet.eMail)

                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If


        End If
    End Sub


    Private Sub ButtonExcluirConfig_Click(sender As Object, e As EventArgs) Handles ButtonExcluirConfig.Click
        Try
            If MsgBox(" Deseja apagar a configuração atual?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
                Me.Validate()
                Me.EMailBindingSource.RemoveCurrent()
                Me.EMailTableAdapter.Update(Me.PrinceDBDataSet.eMail)
                Me.EMailTableAdapter.Fill(Me.PrinceDBDataSet.eMail)
                MessageBox.Show("Atualizando . . . !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        If MsgBox(" Deseja limpar tudo que foi escrito sem enviar?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            TextBoxPara.Text = ""
            TextBoxAssunto.Text = "Digite aqui o assunto..."
            RichTextBoxMensagem.Text = "Seu texto ...."
        End If

    End Sub

    Private Sub ButtonContatos_Click(sender As Object, e As EventArgs) Handles ButtonContatos.Click
        If Application.OpenForms.OfType(Of FrmContatos)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("Contatos ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            FrmContatos.MdiParent = MDIPrincipal
            FrmContatos.Focus()
        Else

            FrmContatos.MdiParent = MDIPrincipal
            FrmContatos.Show()

        End If
    End Sub

    Private Sub ButtonGeral_Click(sender As Object, e As EventArgs) Handles ButtonGeral.Click
        TabControle.SelectedIndex = 2
        TabControle.SelectedIndex = -1
        TextBoxPara.Text = ParaGeralRichTextBox.Text

    End Sub

    'inicio de checagem se o textbox foi alterado para salvar
    Dim Texto_Modificado As Boolean

    Private Sub ParaGeralRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles ParaGeralRichTextBox.TextChanged
        Texto_Modificado = True

    End Sub

    Private Sub ParaGeralRichTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParaGeralRichTextBox.LostFocus
        If Texto_Modificado = True Then
            'MsgBox("Texto Modificado!")
            Salvar()
            Texto_Modificado = False
        Else
            'MsgBox("Texto Não Modificado!")
            Texto_Modificado = False
        End If
    End Sub

    'fim do codigo



    Private Sub ButtonNovoConfig_Click(sender As Object, e As EventArgs) Handles ButtonNovoConfig.Click
        Try
            'Salva alterações
            'Me.Validate()
            Me.EMailBindingSource.AddNew()

        Catch exc As Exception

            MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub ButtonSalvarConfig_Click(sender As Object, e As EventArgs) Handles ButtonSalvarConfig.Click
        Salvar()
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'ativar Acesso a app menos seguro

    End Sub


    Private Sub ButtonAnexar_Click(sender As Object, e As EventArgs) Handles ButtonAnexar.Click
        OpenFileDialog1.ShowDialog()



    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try

            For Each filePath As String In OpenFileDialog1.FileNames
                If File.Exists(filePath) Then
                    Dim fileName As String = Path.GetFileName(filePath)
                    LblAnexo.Text += fileName + Environment.NewLine
                End If
            Next

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub LinkLabelGmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGmail.LinkClicked
        'mgsbox 
        MsgBox("A partir de 30 de maio de 2022, o Google não autorizará mais o uso de apps ou dispositivos de terceiros que exigem apenas nome de usuário e senha para fazer login na Conta do Google . Essa mudança tem como objetivo proteger sua conta.")
    End Sub
    '//////////////////////// FILTRO CAIXA DE SAIDA ////////////////////////////////

    Private Sub FiltroSaida()
        If ComboBoxCaixaSaida.Text = "Data de Envio" Then
            DateTimePicker1.Visible = True
            DateTimePicker2.Visible = True
            Label1.Visible = True
            TextBoxBuscaCaixaSaida.Visible = False
        ElseIf ComboBoxCaixaSaida.Text = "Assunto" Then
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label1.Visible = False
            TextBoxBuscaCaixaSaida.Visible = True
            EMailCaixaDeSaidaBindingSource1.RemoveFilter()
            EMailCaixaDeSaidaBindingSource1.Filter = "Assunto LIKE '%" + TextBoxBuscaCaixaSaida.Text + "%'"
        ElseIf ComboBoxCaixaSaida.Text = "Texto" Then
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label1.Visible = False
            TextBoxBuscaCaixaSaida.Visible = True
            EMailCaixaDeSaidaBindingSource1.RemoveFilter()
            EMailCaixaDeSaidaBindingSource1.Filter = "CaixaDeSaidaTexto LIKE '%" + TextBoxBuscaCaixaSaida.Text + "%'"
        ElseIf ComboBoxCaixaSaida.Text = "Destino" Then
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label1.Visible = False
            TextBoxBuscaCaixaSaida.Visible = True
            EMailCaixaDeSaidaBindingSource1.RemoveFilter()
            EMailCaixaDeSaidaBindingSource1.Filter = "eMailDestino LIKE '%" + TextBoxBuscaCaixaSaida.Text + "%'"
        ElseIf ComboBoxCaixaSaida.Text = "eMail" Then
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label1.Visible = False
            TextBoxBuscaCaixaSaida.Visible = True
            EMailCaixaDeSaidaBindingSource1.RemoveFilter()
            EMailCaixaDeSaidaBindingSource1.Filter = "eMailPrincipal LIKE '%" + TextBoxBuscaCaixaSaida.Text + "%'"
        Else
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label1.Visible = False
            TextBoxBuscaCaixaSaida.Visible = False
        End If
    End Sub
    Private Sub TextBoxBuscaCaixaSaida_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscaCaixaSaida.TextChanged
        FiltroSaida()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If ComboBoxCaixaSaida.Text = "Data de Envio" Then
            EMailCaixaDeSaidaBindingSource1.RemoveFilter()
            EMailCaixaDeSaidaBindingSource1.Filter = "DataEnviado >= '" + DateTimePicker1.Value + "' AND DataEnviado <= '" + DateTimePicker2.Value + "'"
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If ComboBoxCaixaSaida.Text = "Data de Envio" Then
            EMailCaixaDeSaidaBindingSource1.RemoveFilter()
            EMailCaixaDeSaidaBindingSource1.Filter = "DataEnviado >= '" + DateTimePicker1.Value + "' AND DataEnviado <= '" + DateTimePicker2.Value + "'"
        End If
    End Sub

    Private Sub ComboBoxCaixaSaida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCaixaSaida.SelectedIndexChanged
        FiltroSaida()
    End Sub


    Private Sub EnviarGmail()
        'mgsbox aviso manutencao
        MsgBox("A partir de 30 de maio de 2022, o Google não autorizará mais o uso de apps ou dispositivos de terceiros que exigem apenas nome de usuário e senha para fazer login na Conta do Google . Essa mudança tem como objetivo proteger sua conta.")
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        'EmailComboBox.Text contenha gmail
        If ComboBoxEmailSelecionar.Text.Contains("gmail") Then
            EnviarGmail()
        Else
            EnviarEmail()
        End If

    End Sub
End Class