Imports System.Data.SqlClient
Module ModCon
    Sub ConexaoLaudo()

        Dim Str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim Sql As String = "select count(*) from Laudos where CNPJ=@CNPJ "

        Try

            Using Conn As New SqlConnection(Str)
                Using cmd As New SqlCommand(Sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@CNPJ", Legalizacao.CNPJMaskedTextBox.Text)

                    Dim value = cmd.ExecuteScalar()

                    If value > 0 Then


                        ' MessageBox.Show("Ja existe um Laudo/Alvará cadastrado com o mesmo CNPJ! Abrindo...")
                        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then


                            FrmAlvara.Focus()
                            FrmAlvara.ComboBox3.Text = Legalizacao.CNPJMaskedTextBox.Text
                            'FrmAlvara.ComboBox1.Focus()
                            FrmAlvara.RazaoSocialTextBox.Focus()

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> Legalizacao.RazaoSocialTextBox.Text Then
                                If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                                    FrmAlvara.RazaoSocialTextBox.Text = Legalizacao.RazaoSocialTextBox.Text

                                End If

                            End If
                        Else

                            FrmAlvara.Show()
                            FrmAlvara.ComboBox3.Text = Legalizacao.CNPJMaskedTextBox.Text
                            ' FrmAlvara.ComboBox1.Focus()
                            FrmAlvara.RazaoSocialTextBox.Focus()

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> Legalizacao.RazaoSocialTextBox.Text Then
                                If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                                    FrmAlvara.RazaoSocialTextBox.Text = Legalizacao.RazaoSocialTextBox.Text

                                End If

                            End If

                        End If

                    Else

                        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then


                            MessageBox.Show("Controle de laudos está aberto! Fechando o formulário .....
Tente novamente!", "Prince Ajuda")
                            FrmAlvara.Close()


                        Else
                            If MsgBox("Registro não encontrado.
Adicionar Novo Registro em Laudos/Alvará?", MsgBoxStyle.YesNoCancel, "Prince Sistemas") = MsgBoxResult.Yes Then
                                If MsgBox(" Deseja importar o registro atual como novo registro de laudo?", MsgBoxStyle.YesNoCancel, "Novo Laudo/Alvará") = MsgBoxResult.Yes Then

                                    'TAB PRINCIPAL
                                    FrmAlvara.TabAlvara.SelectTab(0)

                                    ' abrir aba dados para pegar informações
                                    Legalizacao.TabControle.SelectTab(1) 'dados

                                    'tabcontrole dos aba dados
                                    Legalizacao.TabControl2.SelectTab(0)
                                    Legalizacao.TabControl2.SelectTab(1)
                                    Legalizacao.TabControl2.SelectTab(2)
                                    Legalizacao.TabControl2.SelectTab(3)
                                    Legalizacao.TabControl2.SelectTab(4)
                                    Legalizacao.TabControl2.SelectTab(5)
                                    Legalizacao.TabControl2.SelectTab(6)





                                    'Abrir FORM
                                    FrmAlvara.Show()
                                    'Valida e Abre um novo registro
                                    FrmAlvara.Validate()
                                    FrmAlvara.LaudosBindingSource.AddNew()
                                    '  LFrmAlvara.RazaoSocialTextBox.Text = RazaoSocialTextBox.Text


                                    'codigo de copiar entre os form

                                    'COPIA OS DADOS
                                    FrmAlvara.RazaoSocialTextBox.Text = Legalizacao.RazaoSocialTextBox.Text
                                    FrmAlvara.CNPJMaskedTextBox.Text = Legalizacao.CNPJMaskedTextBox.Text

                                    'Não Iniciado
                                    FrmAlvara.SituacaoComboBox.Text = "Não Iniciado"


                                    FrmAlvara.TabControl2.SelectTab(1)
                                    'copia
                                    FrmAlvara.EndCEPMaskedTextBox.Text = Legalizacao.EndCEPMaskedTextBox.Text
                                    FrmAlvara.EnderecoTextBox.Text = Legalizacao.EnderecoTextBox.Text
                                    FrmAlvara.EndNumTextBox.Text = Legalizacao.EndNumeroTextBox.Text
                                    FrmAlvara.EndCompTextBox.Text = Legalizacao.EndComplementoTextBox.Text
                                    FrmAlvara.EndBairroTextBox.Text = Legalizacao.EndBairroTextBox.Text
                                    FrmAlvara.EndCidadeTextBox.Text = Legalizacao.EndCidadeTextBox.Text
                                    FrmAlvara.EndEstadoTextBox.Text = Legalizacao.EndEstadoTextBox.Text

                                    FrmAlvara.AreaTextBox.Text = Legalizacao.AreaTextBox.Text
                                    FrmAlvara.Area2TextBox.Text = Legalizacao.Area2TextBox.Text
                                    FrmAlvara.CadImobTextBox.Text = Legalizacao.CadImobTextBox.Text
                                    FrmAlvara.EndZonaTextBox.Text = Legalizacao.EndZonaTextBox.Text
                                    FrmAlvara.EndQuadraTextBox.Text = Legalizacao.EndQuadraTextBox.Text
                                    FrmAlvara.EndDataTextBox.Text = Legalizacao.EndDataTextBox.Text



                                    FrmAlvara.TabControl2.SelectTab(4)
                                    'copia
                                    FrmAlvara.RequerenteTextBox.Text = Legalizacao.NomeResponsavelTextBox.Text
                                    FrmAlvara.CPFRequerenteMaskedTextBox.Text = Legalizacao.CPFResponsavelMaskedTextBox.Text
                                    FrmAlvara.RGRequerenteTextBox.Text = Legalizacao.RespRGTextBox.Text
                                    FrmAlvara.FoneRequerenteTextBox.Text = Legalizacao.EmpTel1TextBox.Text
                                    FrmAlvara.EmailRequerenteTextBox.Text = Legalizacao.EmpEmailTextBox.Text



                                    FrmAlvara.TabControl2.SelectTab(3)
                                    'copia
                                    FrmAlvara.CNAERichTextBox.Text = "CNAE Primário:  " & Legalizacao.CNAEPrincipalTextBox.Text & "
CNAE Secundários:  " & Legalizacao.CNAESecundarioRichTextBox.Text
                                    FrmAlvara.RamodeatividadeRichTextBox.Text = Legalizacao.RamoDeAtividadeRichTextBox.Text


                                    FrmAlvara.TabControl2.SelectTab(5)

                                    If Legalizacao.ProcessoComboBox.Text = "Abertura" Then
                                        'copia
                                        FrmAlvara.NaturezaDoPedidoRichTextBox.Text = "Nova Empresa;
"

                                    Else
                                        'copia
                                        FrmAlvara.NaturezaDoPedidoRichTextBox.Text = Legalizacao.MotivoRichTextBox.Text

                                    End If
                                    'copia
                                    ' FrmAlvara.NaturezaDoPedidoRichTextBox.Text = Legalizacao.MotivoTextBox.Text

                                    'data de criação e aviso
                                    FrmAlvara.DataCriadoMaskedTextBox.Text = System.DateTime.Now
                                    FrmAlvara.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

                                    'termina as copia e foca
                                    'Focus
                                    FrmAlvara.RazaoSocialTextBox.Focus()
                                    FrmAlvara.TabControl1.SelectTab(0)

                                    'unchek lembrete
                                    FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked

                                    'TAB PRINCIPAL
                                    FrmAlvara.TabAlvara.SelectTab(1)
                                    'Uncheck controle de ligações
                                    FrmAlvara.BombeirosCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.ViabilidadeCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.AmbientalCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.SanitarioCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.SetranCheckBox.CheckState = CheckState.Unchecked

                                    'adiciona dados
                                    FrmAlvara.TabControl2.SelectTab(4)
                                    FrmAlvara.Button23.PerformClick()


                                    'TAB PRINCIPAL volta
                                    FrmAlvara.TabAlvara.SelectTab(0)
                                    'TAB DA NATUREZA DO PEDIDO
                                    FrmAlvara.TabControl2.SelectTab(5)

                                    'Combobox
                                    FrmAlvara.SituacaoComboBox.Text = "Não Iniciado"
                                    FrmAlvara.ModeloSistemaComboBox.SelectedIndex = -1
                                    FrmAlvara.BombeiroSituacaoComboBox.SelectedIndex = -1


                                    FrmAlvara.RazaoSocialTextBox.Focus()

                                    MessageBox.Show("Importação realizada com sucesso",
    "Prince Sistemas Informa")
                                Else

                                    'Abrir FORM
                                    FrmAlvara.Show()
                                    'Valida e Abre um novo registro
                                    FrmAlvara.Validate()
                                    FrmAlvara.LaudosBindingSource.AddNew()
                                    FrmAlvara.TabControl1.SelectTab(0)

                                    FrmAlvara.ComboBox1.Focus()
                                    FrmAlvara.RazaoSocialTextBox.Focus()


                                    'unchek lembrete
                                    FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked

                                    'Uncheck controle de ligações
                                    FrmAlvara.BombeirosCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.ViabilidadeCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.AmbientalCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.SanitarioCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.SetranCheckBox.CheckState = CheckState.Unchecked



                                End If
                            Else
                                'Abrir FORM
                                FrmAlvara.Show()


                            End If
                        End If
                    End If
                    Legalizacao.Focus()
                    Legalizacao.TabControle.SelectTab(0)

                    FrmAlvara.Focus()
                    FrmAlvara.TabAlvara.SelectTab(0)


                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro na conexão!" & ex.Message)

        Finally
            'Whether there is error or not. Close the connection.

        End Try
    End Sub

    Sub ConexaoEmpresa()

        Dim Str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim Sql As String = "select count(*) from Empresas where CNPJ=@CNPJ "

        Try

            Using Conn As New SqlConnection(Str)
                Using cmd As New SqlCommand(Sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@CNPJ", FrmAlvara.CNPJMaskedTextBox.Text)

                    Dim value = cmd.ExecuteScalar()

                    If value > 0 Then


                        ' MessageBox.Show("Ja existe uma Empresa cadastrada! Abrindo...")

                        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
                            Dim Sair As String
                            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                            Legalizacao.Focus()
                            Legalizacao.ComboBoxBuscaEmpresa.Text = FrmAlvara.RazaoSocialTextBox.Text
                            Legalizacao.ComboBoxBuscaEmpresa.Focus()

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> Legalizacao.RazaoSocialTextBox.Text Then

                                Dim Msg As String
                                Msg = MsgBox("Razão Social Diferente, favor deixar os dois formulários com a mesma Razão Social", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                            End If


                        Else

                            Legalizacao.Show()
                            Legalizacao.ComboBoxBuscaEmpresa.Text = FrmAlvara.RazaoSocialTextBox.Text
                            Legalizacao.ComboBoxBuscaEmpresa.Focus()

                            If FrmAlvara.RazaoSocialTextBox.Text <> Legalizacao.RazaoSocialTextBox.Text Then

                                Dim Msg As String
                                Msg = MsgBox("Razão Social Diferente, favor deixar os dois formulários com a mesma Razão Social", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                            End If
                        End If
                    Else
                        MessageBox.Show("Cadastro não encontrado em Geral Empresas!
Verifique se o CNPJ do Alvará, são iguais ao do CNPJ do Cadastro Empresas!")


                    End If


                End Using

            End Using

        Catch ex As Exception
            MsgBox("Erro na conexão!", MsgBoxStyle.Critical, "Prince Sistemas")


        Finally
            'Whether there is error or not. Close the connection.
            'Legalizacao.Close()
        End Try
    End Sub


    Sub Atualizadadadoslaudo()


        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
            '  Dim Sair As String
            ' Sair = MsgBox("O formulário ja está aberto, Importando dados ...", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            If FrmAlvara.RazaoSocialTextBox.Text <> Legalizacao.RazaoSocialTextBox.Text Then

                If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Importacaodadoslaudo()
                End If

            Else
                Importacaodadoslaudo()
            End If

        Else
            ' MsgBox("O formulário não está aberto, Abrir com a empresa que deseja importar!", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            Call ConexaoEmpresa()

            ' Dim Sair As String
            ' Sair = MsgBox("O formulário ja está aberto, Importando dados ...", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            If FrmAlvara.RazaoSocialTextBox.Text <> Legalizacao.RazaoSocialTextBox.Text Then

                If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Importacaodadoslaudo()
                End If

            Else
                Importacaodadoslaudo()
            End If

        End If



    End Sub

    Sub Importacaodadoslaudo()
        Try
            'Atualizar e verificar
            'TAB PRINCIPAL
            FrmAlvara.TabAlvara.SelectTab(0)

            ' abrir aba dados para pegar informações
            Legalizacao.TabControle.SelectTab(1) 'dados

            'tabcontrole dos aba dados
            Legalizacao.TabControl2.SelectTab(0)
            Legalizacao.TabControl2.SelectTab(1)
            Legalizacao.TabControl2.SelectTab(2)
            Legalizacao.TabControl2.SelectTab(3)
            Legalizacao.TabControl2.SelectTab(4)
            Legalizacao.TabControl2.SelectTab(5)
            Legalizacao.TabControl2.SelectTab(6)


            '//


            'codigo de copiar entre os form

            'COPIA OS DADOS
            FrmAlvara.RazaoSocialTextBox.Text = Legalizacao.RazaoSocialTextBox.Text
            FrmAlvara.CNPJMaskedTextBox.Text = Legalizacao.CNPJMaskedTextBox.Text




            FrmAlvara.TabControl2.SelectTab(1)
            'copia
            FrmAlvara.EndCEPMaskedTextBox.Text = Legalizacao.EndCEPMaskedTextBox.Text
            FrmAlvara.EnderecoTextBox.Text = Legalizacao.EnderecoTextBox.Text
            FrmAlvara.EndNumTextBox.Text = Legalizacao.EndNumeroTextBox.Text
            FrmAlvara.EndCompTextBox.Text = Legalizacao.EndComplementoTextBox.Text
            FrmAlvara.EndBairroTextBox.Text = Legalizacao.EndBairroTextBox.Text
            FrmAlvara.EndCidadeTextBox.Text = Legalizacao.EndCidadeTextBox.Text
            FrmAlvara.EndEstadoTextBox.Text = Legalizacao.EndEstadoTextBox.Text

            FrmAlvara.AreaTextBox.Text = Legalizacao.AreaTextBox.Text
            FrmAlvara.Area2TextBox.Text = Legalizacao.Area2TextBox.Text
            FrmAlvara.CadImobTextBox.Text = Legalizacao.CadImobTextBox.Text
            FrmAlvara.EndZonaTextBox.Text = Legalizacao.EndZonaTextBox.Text
            FrmAlvara.EndQuadraTextBox.Text = Legalizacao.EndQuadraTextBox.Text
            FrmAlvara.EndDataTextBox.Text = Legalizacao.EndDataTextBox.Text



            FrmAlvara.TabControl2.SelectTab(4)
            'copia
            FrmAlvara.RequerenteTextBox.Text = Legalizacao.NomeResponsavelTextBox.Text
            FrmAlvara.CPFRequerenteMaskedTextBox.Text = Legalizacao.CPFResponsavelMaskedTextBox.Text
            FrmAlvara.RGRequerenteTextBox.Text = Legalizacao.RespRGTextBox.Text
            FrmAlvara.FoneRequerenteTextBox.Text = Legalizacao.EmpTel1TextBox.Text
            FrmAlvara.EmailRequerenteTextBox.Text = Legalizacao.EmpEmailTextBox.Text




            FrmAlvara.TabControl2.SelectTab(3)
            'copia
            FrmAlvara.CNAERichTextBox.Text = "CNAE Primário:  " & Legalizacao.CNAEPrincipalTextBox.Text & "
CNAE Secundários:  " & Legalizacao.CNAESecundarioRichTextBox.Text
            FrmAlvara.RamodeatividadeRichTextBox.Text = Legalizacao.RamoDeAtividadeRichTextBox.Text


            FrmAlvara.TabControl2.SelectTab(5)

            If Legalizacao.ProcessoComboBox.Text = "Abertura" Then
                'copia
                FrmAlvara.NaturezaDoPedidoRichTextBox.Text = "Nova Empresa;
"

            Else
                'copia
                FrmAlvara.NaturezaDoPedidoRichTextBox.Text = Legalizacao.MotivoRichTextBox.Text

            End If
            'copia
            ' FrmAlvara.NaturezaDoPedidoRichTextBox.Text = Legalizacao.MotivoTextBox.Text

            'data de criação e aviso
            FrmAlvara.DataCriadoMaskedTextBox.Text = System.DateTime.Now
            FrmAlvara.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

            'termina as copia e foca
            'Focus
            FrmAlvara.RazaoSocialTextBox.Focus()
            FrmAlvara.TabControl1.SelectTab(0)

            'unchek lembrete
            FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked

            'TAB PRINCIPAL
            FrmAlvara.TabAlvara.SelectTab(1)
            'Uncheck controle de ligações
            FrmAlvara.BombeirosCheckBox.CheckState = CheckState.Unchecked
            FrmAlvara.ViabilidadeCheckBox.CheckState = CheckState.Unchecked
            FrmAlvara.AmbientalCheckBox.CheckState = CheckState.Unchecked
            FrmAlvara.SanitarioCheckBox.CheckState = CheckState.Unchecked
            FrmAlvara.SetranCheckBox.CheckState = CheckState.Unchecked

            'adiciona dados
            FrmAlvara.TabControl2.SelectTab(4)
            FrmAlvara.Button23.PerformClick()


            'TAB PRINCIPAL volta
            FrmAlvara.TabAlvara.SelectTab(0)
            'TAB DA NATUREZA DO PEDIDO
            FrmAlvara.TabControl2.SelectTab(5)

            MessageBox.Show("Importação realizada com sucesso",
    "Prince Sistemas Informa")

            ' Legalizacao.Close()

        Catch ex As System.InvalidCastException
            MessageBox.Show("Erro ao copiar novos dados, verificar", "Prince Avisa")

        End Try

    End Sub

    Sub Historico()
        FrmAlvara.TabAlvara.SelectTab(3)
        FrmAlvara.TabAlvara.SelectTab(4)
        FrmAlvara.TabAlvara.SelectTab(0)

        FrmAlvara.TabControl2.SelectTab(5)

        'abrir histórico
        FrmAlvara.TabAlvara.SelectTab(4)

        Try
            Dim A = FrmAlvara.NlaudoTextBox.Text.ToString()
            Dim B = FrmAlvara.ModeloSistemaComboBox.Text.ToString()
            Dim C = FrmAlvara.NaturezaDoPedidoRichTextBox.Text.ToString()
            'protocolo
            Dim D = FrmAlvara.DataEntradaMaskedTextBox.Text.ToString()
            Dim E = FrmAlvara.ProtocoloTipoTextBox.Text.ToString()
            Dim F = FrmAlvara.ProtocoloNTextBox.Text.ToString()
            Dim G = FrmAlvara.ProtocoloAnoTextBox.Text.ToString()
            Dim H = FrmAlvara.ProtocoloSenhaTextBox.Text.ToString()




            FrmAlvara.HistoricoRichTextBox.SelectedText &=
"Histórico anterior, Salvo Dia: " & Format(Now, "dd/MM/yyyy") & " as " & Format(Now, "HH:mm") & ", com as seguintes informações:
Nº do Laudo :  " & A & ". 
Sistema da Prefeitura: " & B & ". 
Natureza do Pedido: " & C & ".
Protocolo: Data " & D & "; Tipo:" & E & ", Número:" & F & ", Ano:" & G & ", Senha:" & H & ".

//-----------------//-----------------//-----------------//-----------------//
"
            'Limpando as BOX
            FrmAlvara.NlaudoTextBox.Text = ""
            FrmAlvara.ModeloSistemaComboBox.Text = ""
            FrmAlvara.NaturezaDoPedidoRichTextBox.Text = ""

            FrmAlvara.DataEntradaMaskedTextBox.Text = ""
            FrmAlvara.ProtocoloTipoTextBox.Text = ""
            FrmAlvara.ProtocoloNTextBox.Text = ""
            FrmAlvara.ProtocoloAnoTextBox.Text = ""
            FrmAlvara.ProtocoloSenhaTextBox.Text = ""

            'Não Iniciado
            FrmAlvara.SituacaoComboBox.Text = "Não Iniciado"

            MessageBox.Show("Dados Principais Salvo no Histórico, continuando com a importação ...", "Prince Avisa")
            FrmAlvara.TabAlvara.SelectTab(4)

        Catch ex As System.InvalidCastException
            MessageBox.Show("ERRO", "Prince Avisa")

        End Try


    End Sub


    Sub SalvaProtocolo()
        Try
            'protocolo
            Dim D = FrmAlvara.DataEntradaMaskedTextBox.Text.ToString()
            Dim E = FrmAlvara.ProtocoloTipoTextBox.Text.ToString()
            Dim F = FrmAlvara.ProtocoloNTextBox.Text.ToString()
            Dim G = FrmAlvara.ProtocoloAnoTextBox.Text.ToString()
            Dim H = FrmAlvara.ProtocoloSenhaTextBox.Text.ToString()

            'abrir histórico
            FrmAlvara.TabAlvara.SelectTab(4)


            'Salvar
            FrmAlvara.HistoricoRichTextBox.SelectedText &=
    "Protocolo: Data " & D & "; Tipo:" & E & ", Número:" & F & ", Ano:" & G & ", Senha:" & H & ".

//-----------------//-----------------//-----------------//-----------------//
"

            'Limpando as BOX
            FrmAlvara.DataEntradaMaskedTextBox.Text = ""
            FrmAlvara.ProtocoloTipoTextBox.Text = ""
            FrmAlvara.ProtocoloNTextBox.Text = ""
            FrmAlvara.ProtocoloAnoTextBox.Text = ""
            FrmAlvara.ProtocoloSenhaTextBox.Text = ""

            'menssagem box
            MessageBox.Show("Protocolo Salvo no Histórico", "Prince Avisa")
            FrmAlvara.TabAlvara.SelectTab(4)

        Catch ex As System.InvalidCastException
            MessageBox.Show("ERRO", "Prince Avisa")

        End Try

    End Sub


    Sub SalvaProtocolBomb()
        Try
            'protocolo
            Dim A = FrmAlvara.BombeiroNProcessoMaskedTextBox.Text.ToString()
            Dim B = FrmAlvara.BombeiroDataPedProcessoMaskedTextBox.Text.ToString()


            'abrir histórico
            FrmAlvara.TabAlvara.SelectTab(4)


            'Salvar
            FrmAlvara.HistoricoRichTextBox.SelectedText &=
    "Protocolo do Bombeiro: " & A & "; Data da solicitação:" & B & ".

//-----------------//-----------------//-----------------//-----------------//
"

            'Limpando as BOX
            FrmAlvara.BombeiroNProcessoMaskedTextBox.Text = ""
            FrmAlvara.BombeiroDataPedProcessoMaskedTextBox.Text = ""


            'menssagem box
            MessageBox.Show("Protocolo Salvo no Histórico", "Prince Avisa")
            FrmAlvara.TabAlvara.SelectTab(4)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Erro na conexão!" & vbCrLf & ex.Message)


        End Try

    End Sub
End Module
