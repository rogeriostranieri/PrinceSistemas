Imports System.Data.SqlClient


Module ModeMail
    Sub EmailCaixaDeSaida()
        Dim Str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim Sql As String = "select count(*) from eMail where eMail=@EMailPrincipal"

        Try

            Using Conn As New SqlConnection(Str)
                Using cmd As New SqlCommand(Sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@EMailPrincipal", FrmEmailCaixaDeSaida.ComboBoxBusca.Text)

                    Dim value = cmd.ExecuteScalar()

                    If value > 0 Then


                    Else

                        ' abrir aba dados para pegar informações
                        FrmMail.TabControle.SelectTab(1) 'dados

                        'tabcontrole dos aba dados
                        FrmMail.TabControle.SelectTab(0)


                        'Abrir FORM
                        FrmEmailCaixaDeSaida.MdiParent = MDIPrincipal
                        FrmEmailCaixaDeSaida.Show()

                        'Valida e Abre um novo registro
                        FrmEmailCaixaDeSaida.Validate()
                        FrmEmailCaixaDeSaida.EMailCaixaDeSaidaBindingSource.AddNew()
                        '  LFrmEmailCaixaDeSaida.RazaoSocialTextBox.Text = RazaoSocialTextBox.Text


                        FrmEmailCaixaDeSaida.Focus()
                        'codigo de copiar entre os form

                        'COPIA OS DADOS
                        Dim A = FrmMail.ComboBoxEmailSelecionar.Text.ToString()
                        Dim B = FrmMail.TextBoxPara.Text.ToString()
                        Dim C = FrmMail.TextBoxAssunto.Text.ToString()
                        Dim D = FrmMail.RichTextBoxMensagem.Text.ToString()




                        FrmEmailCaixaDeSaida.EMailPrincipalTextBox.Text = A
                        FrmEmailCaixaDeSaida.EMailDestinoTextBox.Text = B
                        FrmEmailCaixaDeSaida.AssuntoTextBox.Text = C
                        FrmEmailCaixaDeSaida.CaixaDeSaidaTextoRichTextBox.Text = D



                        'data de criação e aviso
                        '  FrmEmailCaixaDeSaida.DataCriadoMaskedTextBox.Text = System.DateTime.Now
                        '  FrmEmailCaixaDeSaida.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

                        'adicionar data

                        FrmEmailCaixaDeSaida.DataEnviadoMaskedTextBox.Text = DateTime.Now.AddMinutes(55).ToString("dd'/'MM'/'yyyy HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))



                        'MessageBox.Show("Importação realizada com sucesso","Prince Sistemas Informa")
                        FrmEmailCaixaDeSaida.Validate()
                        FrmEmailCaixaDeSaida.EMailCaixaDeSaidaBindingSource.EndEdit()
                        FrmEmailCaixaDeSaida.EMailCaixaDeSaidaTableAdapter.Update(FrmEmailCaixaDeSaida.PrinceDBDataSet.eMailCaixaDeSaida)
                        FrmEmailCaixaDeSaida.Close()


                    End If

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro na conexão!" & vbCrLf & ex.Message)

        Finally
            'Whether there is error or not. Close the connection.

        End Try
    End Sub

    Sub Enviaremaillegalizacao()
        FrmAvisoEmpresa.Show()
        FrmAvisoEmpresa.Focus()

        FrmLegalizacao.TabControle.SelectTab(0)
        FrmLegalizacao.TabControle.SelectTab(1)
        ' Loop para percorrer todas as abas do TabControl2
        For i As Integer = 0 To FrmLegalizacao.TabControl2.TabPages.Count - 1
            FrmLegalizacao.TabControl2.SelectTab(i)
            ' Aqui você pode adicionar alguma lógica para trabalhar com cada aba, se necessário.
        Next

        'retorna
        FrmLegalizacao.TabControle.SelectTab(0)

        'abrir histórico
        FrmMail.TabControle.SelectTab(0)

        FrmMail.TextBoxAssunto.Text = ""
        FrmMail.RichTextBoxMensagem.Text = ""

        'igual esta no comando no formulario FrmLegalizacao
        FrmLegalizacao.SistemaExternoComboBox.SelectedIndex = -1



        Try
            Dim Filial = FrmLegalizacao.SEDEComboBox.Text.ToString()
            Dim A = FrmLegalizacao.RazaoSocialTextBox.Text.ToString()
            Dim B = FrmLegalizacao.CNPJMaskedTextBox.Text.ToString()
            Dim C = FrmLegalizacao.ProcessoComboBox.Text.ToString()
            Dim D = FrmLegalizacao.MotivoRichTextBox.Text.ToString()
            Dim E = "Sim" 'FrmLegalizacao.SistemaExternoComboBox.Text.ToString()
            Dim F = FrmLegalizacao.IETextBox.Text.ToString()
            Dim H = FrmLegalizacao.RazaoSocialAntigaTextBox.Text.ToString()
            'TipoDeEmpresaComboBox
            Dim I = FrmLegalizacao.TipoDeEmpresaComboBox.Text.ToString()
            'NaturezaJuridicaComboBox
            Dim J = FrmLegalizacao.NaturezaJuridicaComboBox.Text.ToString()
            'data de hoje dd/mm/aaaa as 00:00:00
            Dim K = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
            'RegimeFederalComboBox
            Dim Regime = FrmLegalizacao.RegimeFederalComboBox.Text.ToString



            'verificar se C tem "transformação" e mostrar caixa de editar o texto antes de colocar
            ' If C = "Transformação" Then
            If C.Contains("Transformação") Then
                'caixa MsgBox VBA e InputBox
                Dim G = InputBox("Digite qual tipo Processo de Transformação", "Processo de Transformação")
                C = "Transformação de " + G
            End If

            'Nome Antigo
            Dim NomeAntigo As String = ""
            If H = "" Then
                NomeAntigo = "<br>"
            Else
                NomeAntigo = "<b>Com Nome Empresarial Antigo = </b> " & H & ". <br><br>"

            End If

            'IE ESTADUAL
            Dim IE As String = ""
            If F = "" Then
                IE = "<br>"
            Else
                IE = ", e <b>inscrita no Estado com Nº = </b>" & F & ". <br>"
            End If

            'Regime da Empresa
            Dim RegimeFinal As String = ""
            If Regime <> "Pendência" Then
                RegimeFinal = Regime
            Else
                RegimeFinal = "Em andamento Simples Nacional"
            End If

            'Nome Do usuário
            Dim Nome As String
            'apagar "Bem vindo Sr(a). ", do  MDIPrincipal.LblNomeCompleto.Text
            Nome = MDIPrincipal.LblNomeCompleto.Text.Replace("Bem vindo Sr(a). ", "")
            'apagar "!"
            Nome = Nome.Replace("!", "")

            'Nome Do sistema
            'ApplicationTitle  - ProductName
            Dim NomeSistema As String = My.Application.Info.ProductName


            FrmAvisoEmpresa.Close()

            '///////////// CODIGO DO SISTEMA EXTERNO
            Dim SistemaExternoCodigo = FrmLegalizacao.CodSistemaExternoTextBox.Text.ToString()

            Dim CodigoSistemaExterno As String = ""
            Dim TextoSistemaExterno As String = ""

            ' Verifica se já há algum código no CodSistemaExternoTextBox
            If String.IsNullOrEmpty(SistemaExternoCodigo) OrElse Not IsNumeric(SistemaExternoCodigo) Then
                ' Pergunta ao usuário se deseja adicionar o número da empresa
                Dim resposta As DialogResult
                resposta = MessageBox.Show("Deseja adicionar o número da empresa do sistema externo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resposta = DialogResult.Yes Then
                    ' Mostra o campo para o usuário digitar o número
                    Dim numeroEmpresa As String = InputBox("Digite o número da empresa:", "Número da Empresa")

                    ' Verifica se o usuário clicou em "Cancelar" ou deixou o campo em branco
                    If String.IsNullOrEmpty(numeroEmpresa) Then
                        MessageBox.Show("Nenhum número foi inserido ou operação cancelada. O processo será continuado sem o número.")
                    Else
                        ' Se o usuário inseriu um número, usa o código
                        CodigoSistemaExterno = numeroEmpresa
                        TextoSistemaExterno = " - Código da Empresa: "

                        ' Preenche o campo CodSistemaExternoTextBox com o número inserido
                        FrmLegalizacao.CodSistemaExternoTextBox.Text = CodigoSistemaExterno
                    End If
                End If
            Else
                ' Se já houver um código válido, apenas adiciona o número sem perguntar
                CodigoSistemaExterno = SistemaExternoCodigo
                TextoSistemaExterno = " - Código da Empresa: "
                FrmLegalizacao.CodSistemaExternoTextBox.Text = CodigoSistemaExterno
            End If


            FrmAvisoEmpresa.Show()
            FrmAvisoEmpresa.Focus()

            '/////////////////////////// INICIO CAIXA DO EMAIL ////////////////////////////////////////////////
            'assunto
            'FrmMail.TextBoxAssunto.Text = C & " da Empresa " & Filial & " = " & A & ""

            'verificar se C tem "transformação" e mostrar caixa de editar o texto antes de colocar

            If C.Contains("Transformação") Then
                FrmMail.TextBoxAssunto.Text = C & " da Empresa " & Filial & " = " & H & ""
            Else
                FrmMail.TextBoxAssunto.Text = C & " da Empresa " & Filial & " = " & A & ""
            End If

            '///////////////////////// COPO DO EMAIL //////////////////////////////////

            'corpo do email
            FrmMail.RichTextBoxMensagem.SelectedText &=
"<html><body><br>
<br>
<b>Com o processo = </b> " & C & ".<br>
<br>
<b>Nome Empresarial = </b> " & A & ".<br>
" & NomeAntigo & "
<b>Inscrita no CNPJ Nº = </b> " & B & "" & IE & "<br>
<b>Natureza jurídica = </b> " & I & " - " & J & ".<br>
<br>
<b>Teve como objetivo = </b> " & D & ".<br>
<br>
<br>
<b>A Empresa vai ser = </b> " & RegimeFinal & "<br>
<br>
<br>
<b>Sistema externo atualizado = </b> " & E & "<b> " & TextoSistemaExterno & "</b>" & CodigoSistemaExterno & ".<br>
<br>
<br>           
//-----------------//-----------------//-----------------//-----------------//<br>
<br>
<b>" & Nome & " </b><br>
<br>
<br>
<b>Enviado pelo sistema: " & NomeSistema & " </b><br>
</b><i>Em: " & K & "</i><br>
<br>
<br>
</body></html>
"

            '/////////////////////////// FIM CAIXA DO EMAIL ////////////////////////////////////////////////
            FrmAvisoEmpresa.Close()

            FrmMail.BringToFront()
            FrmMail.Focus()


        Catch ex As System.InvalidCastException
            MessageBox.Show("ERRO" & vbCrLf & ex.Message, "Prince Avisa")

        End Try


    End Sub

    '///////////////////////////////////////////////////////////////////////////




End Module
