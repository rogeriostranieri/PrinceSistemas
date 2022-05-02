Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail


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

    Sub Enviaremaillegalizao()
        Legalizacao.TabControle.SelectTab(0)

        'abrir histórico
        FrmMail.TabControle.SelectTab(0)

        FrmMail.TextBoxAssunto.Text = ""
        FrmMail.RichTextBoxMensagem.Text = ""

        'igual esta no comando no formulario legalizacao
        Legalizacao.SistemaExternoComboBox.SelectedIndex = 0

        Try
            Dim A = Legalizacao.RazaoSocialTextBox.Text.ToString()
            Dim B = Legalizacao.CNPJMaskedTextBox.Text.ToString()
            Dim C = Legalizacao.ProcessoComboBox.Text.ToString()
            Dim D = Legalizacao.MotivoRichTextBox.Text.ToString()
            Dim E = Legalizacao.SistemaExternoComboBox.Text.ToString()
            Dim F = Legalizacao.IETextBox.Text.ToString()
            If E = "" Then
                F = "Não tem Inscrição Estadual"
            End If

            'assunto
            FrmMail.TextBoxAssunto.Text = C & " - da Empresa: " & A & ""

            If F = "" Then
                'corpo do email
                FrmMail.RichTextBoxMensagem.SelectedText &=
"<html><body><b>A Empresa:</b> " & A & ", <br/>
<b>Inscrita no CNPJ</b> Nº: " & B & ".<br/>
<br/>
<b>Com o processo de:</b> " & C & ", <br/>
<b>Teve como objetivo de:</b> " & D & ",<br/>
<br/>
<b>E no Sistema ja foi atualizado:</b> " & E & ".<br/>
<br/>
<br/>            
//-----------------//-----------------//-----------------//-----------------//<br/>
</body></html>
"
            Else
                'corpo do email
                FrmMail.RichTextBoxMensagem.SelectedText &=
"<html><body><b>A Empresa:</b> " & A & ", <br/>
<b>Inscrita no CNPJ</b> Nº: " & B & ", e <b>inscrita no Estado</b> com Nº: " & F & ". <br/>
<br/>
<b>Com o processo de:</b> " & C & ", <br/>
<b>Teve como objetivo de:</b> " & D & ",<br/>
<br />
<b>E no Sistema ja foi atualizado:</b> " & E & ".<br/>
<br/>
<br/>            
//-----------------//-----------------//-----------------//-----------------//<br />
</body></html>
"
            End If


        Catch ex As System.InvalidCastException
            MessageBox.Show("ERRO" & vbCrLf & ex.Message, "Prince Avisa")

        End Try


    End Sub



End Module
