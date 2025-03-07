﻿Imports System.Data.SqlClient
Module ModCon
    Sub VerificaCNPJemprCOMlaudos()
        Try

            Dim CNPJEMPRESAS As String = FrmLegalizacao.CNPJMaskedTextBox.Text

            'vreificar se o CNPJ de Empresa está cadastrado no laudos
            Dim Str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim Sql As String = "select count(*) from Laudos where CNPJ=@CNPJEMPRESAS"

            Dim Cn As New SqlConnection(Str)
            Dim Cmd As New SqlCommand(Sql, Cn)
            Cn.Open()
            Cmd.Parameters.Add("@CNPJEMPRESAS", SqlDbType.VarChar).Value = CNPJEMPRESAS
            Dim Cont As Integer = Cmd.ExecuteScalar
            Cn.Close()

            If Cont = 0 Then
                '////////////////////// QUANDO ENCOTRAR O CNPJ ////////////////////////////////////
                MsgBox("CNPJ não encontrado no Laudos")
                If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
                    MessageBox.Show("Controle de laudos está aberto! Fechando o formulário ....." + vbCrLf + "
Tente novamente!", "Prince Ajuda")
                    FrmAlvara.Close()
                Else
                    If MsgBox("Registro não encontrado." + vbCrLf + "Adicionar Novo Registro em Laudos/Alvará?", MsgBoxStyle.YesNoCancel, "Prince Sistemas") = MsgBoxResult.Yes Then
                        If MsgBox(" Deseja importar o registro atual como novo registro de laudo?", MsgBoxStyle.YesNoCancel, "Novo Laudo/Alvará") = MsgBoxResult.Yes Then

                            'TAB PRINCIPAL
                            FrmAlvara.TabAlvara.SelectTab(0)

                            ' abrir aba dados para pegar informações
                            FrmLegalizacao.TabControle.SelectTab(1) 'dados

                            'tabcontrole dos aba dados
                            FrmLegalizacao.TabControl2.SelectTab(0)
                            FrmLegalizacao.TabControl2.SelectTab(1)
                            FrmLegalizacao.TabControl2.SelectTab(2)
                            FrmLegalizacao.TabControl2.SelectTab(3)
                            FrmLegalizacao.TabControl2.SelectTab(4)
                            FrmLegalizacao.TabControl2.SelectTab(5)
                            FrmLegalizacao.TabControl2.SelectTab(6)
                            FrmLegalizacao.TabControl2.SelectTab(7)





                            ' Abre o formulário FrmAlvara
                            FrmAlvara.Show()

                            ' Adiciona um novo registro
                            FrmAlvara.LaudosBindingSource.AddNew()

                            ' Finaliza a edição para que o registro seja tratado como uma alteração
                            FrmAlvara.LaudosBindingSource.EndEdit()

                            '  LFrmAlvara.RazaoSocialTextBox.Text = RazaoSocialTextBox.Text


                            'codigo de copiar entre os form

                            'COPIA OS DADOS
                            FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text
                            FrmAlvara.CNPJMaskedTextBox.Text = FrmLegalizacao.CNPJMaskedTextBox.Text

                            'Não Iniciado
                            FrmAlvara.SituacaoComboBox.Text = "Não Iniciado"


                            FrmAlvara.TabControl2.SelectTab(1)
                            'copia
                            FrmAlvara.EndCEPMaskedTextBox.Text = FrmLegalizacao.EndCEPMaskedTextBox.Text
                            FrmAlvara.EnderecoTextBox.Text = FrmLegalizacao.EnderecoTextBox.Text
                            FrmAlvara.EndNumTextBox.Text = FrmLegalizacao.EndNumeroTextBox.Text
                            FrmAlvara.EndCompTextBox.Text = FrmLegalizacao.EndComplementoTextBox.Text
                            FrmAlvara.EndBairroTextBox.Text = FrmLegalizacao.EndBairroTextBox.Text
                            FrmAlvara.EndCidadeTextBox.Text = FrmLegalizacao.EndCidadeTextBox.Text
                            FrmAlvara.EndEstadoTextBox.Text = FrmLegalizacao.EndEstadoTextBox.Text

                            FrmAlvara.AreaTextBox.Text = FrmLegalizacao.AreaTextBox.Text
                            FrmAlvara.Area2TextBox.Text = FrmLegalizacao.Area2TextBox.Text
                            FrmAlvara.CadImobTextBox.Text = FrmLegalizacao.CadImobTextBox.Text
                            FrmAlvara.EndZonaTextBox.Text = FrmLegalizacao.EndZonaTextBox.Text
                            FrmAlvara.EndQuadraTextBox.Text = FrmLegalizacao.EndQuadraTextBox.Text
                            FrmAlvara.EndDataTextBox.Text = FrmLegalizacao.EndDataTextBox.Text
                            FrmAlvara.MatrizComboBox.Text = FrmLegalizacao.SEDEComboBox.Text



                            FrmAlvara.TabControl2.SelectTab(4)
                            'copia
                            FrmAlvara.RequerenteTextBox.Text = FrmLegalizacao.NomeResponsavelTextBox.Text
                            FrmAlvara.CPFRequerenteMaskedTextBox.Text = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text
                            FrmAlvara.RGRequerenteTextBox.Text = FrmLegalizacao.RespRGTextBox.Text
                            FrmAlvara.OrgaoRGRequerenteTextBox.Text = FrmLegalizacao.ResponsavelOrgaoRGTextBox.Text
                            FrmAlvara.EstadoOrgaoRGRequerenteTextBox.Text = FrmLegalizacao.ResponsavelEstadoOrgaoRGTextBox.Text
                            FrmAlvara.FoneRequerenteTextBox.Text = FrmLegalizacao.EmpTel1TextBox.Text
                            FrmAlvara.EmailRequerenteTextBox.Text = FrmLegalizacao.EmpEmailTextBox.Text



                            FrmAlvara.TabControl2.SelectTab(3)
                            'copia
                            '  FrmAlvara.CNAERichTextBox.Text = "CNAE Primário:  " & FrmLegalizacao.CNAEPrincipalTextBox.Text & " CNAE Secundários:  " & FrmLegalizacao.CNAESecundarioRichTextBox.Text
                            FrmAlvara.CNAEPrimarioTextBox.Text = FrmLegalizacao.CNAEPrincipalTextBox.Text
                            FrmAlvara.CNAERichTextBox.Text = FrmLegalizacao.CNAESecundarioRichTextBox.Text
                            FrmAlvara.RamodeatividadeRichTextBox.Text = FrmLegalizacao.RamoDeAtividadeRichTextBox.Text


                            FrmAlvara.TabControl2.SelectTab(5)

                            If FrmLegalizacao.ProcessoComboBox.Text = "Abertura" Then
                                'copia
                                FrmAlvara.NaturezaDoPedidoRichTextBox.Text = "Nova Empresa;
"

                            Else
                                'copia
                                FrmAlvara.NaturezaDoPedidoRichTextBox.Text = FrmLegalizacao.MotivoRichTextBox.Text

                            End If
                            'copia
                            ' FrmAlvara.NaturezaDoPedidoRichTextBox.Text = FrmLegalizacao.MotivoTextBox.Text

                            'data de criação e aviso
                            FrmAlvara.DataCriadoMaskedTextBox.Text = System.DateTime.Now
                            FrmAlvara.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

                            'termina as copia e foca
                            'Focus
                            FrmAlvara.RazaoSocialTextBox.Focus()
                            FrmAlvara.TabControlAcompanhamento.SelectTab(0)

                            'unchek lembrete
                            FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked
                            FrmAlvara.PrioridadeCheckBox.CheckState = CheckState.Unchecked


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

                            ' Abre o formulário FrmAlvara
                            FrmAlvara.Show()

                            ' Adiciona um novo registro
                            FrmAlvara.LaudosBindingSource.AddNew()

                            ' Finaliza a edição para que o registro seja tratado como uma alteração
                            FrmAlvara.LaudosBindingSource.EndEdit()

                            FrmAlvara.TabControlAcompanhamento.SelectTab(0)

                            FrmAlvara.ComboBoxBuscaAlvara.Focus()
                            FrmAlvara.RazaoSocialTextBox.Focus()


                            'unchek lembrete
                            FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked
                            FrmAlvara.PrioridadeCheckBox.CheckState = CheckState.Unchecked


                            'Uncheck controle de ligações
                            FrmAlvara.BombeirosCheckBox.CheckState = CheckState.Unchecked
                            FrmAlvara.ViabilidadeCheckBox.CheckState = CheckState.Unchecked
                            FrmAlvara.AmbientalCheckBox.CheckState = CheckState.Unchecked
                            FrmAlvara.SanitarioCheckBox.CheckState = CheckState.Unchecked
                            FrmAlvara.SetranCheckBox.CheckState = CheckState.Unchecked



                        End If

                    ElseIf MsgBoxResult.No Then
                        'e cancel
                        Exit Sub
                    Else
                        'Abrir FORM
                        FrmAlvara.Show()


                    End If
                End If

                FrmLegalizacao.Focus()
                FrmLegalizacao.TabControle.SelectTab(0)

                FrmAlvara.Focus()
                FrmAlvara.TabAlvara.SelectTab(0)

                '////////////////////// QUANDO NAO ENCOTRAR O CNPJ ////////////////////////////////////
            Else
                MsgBox("CNPJ encontrado no Laudos")
                ' MessageBox.Show("Ja existe um Laudo/Alvará cadastrado com o mesmo CNPJ! Abrindo...")
                If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then

                    'FrmAlvara encontrar o CNPJ igual do FrmLegalizacao.CNPJMaskedTextBox.Text
                    FrmAlvara.ComboBoxBuscaCNPJ.Text = FrmLegalizacao.CNPJMaskedTextBox.Text
                    FrmAlvara.ComboBoxBuscaCNPJ.Focus()
                    FrmAlvara.ComboBoxBuscaCNPJ.SelectAll()


                    'apos carregar formulario Verifica Razao Social são iguais FrmLegalizacao.RazaoSocial

                    If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then
                        If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                            FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text
                        End If
                    End If
                Else

                    FrmAlvara.Show()
                    FrmAlvara.ComboBoxBuscaCNPJ.Text = FrmLegalizacao.CNPJMaskedTextBox.Text
                    FrmAlvara.ComboBoxBuscaCNPJ.Focus()
                    FrmAlvara.ComboBoxBuscaCNPJ.SelectAll()

                    'apos carregar formulario Verifica Razao Social são iguais FrmLegalizacao.RazaoSocial

                    If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then
                        If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                            FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text
                        End If
                    End If

                End If

            End If


        Catch ex As Exception
            MessageBox.Show("Erro na conexão!" & ex.Message)

        Finally
            'Whether there is error or not. Close the connection.

        End Try

    End Sub

    Sub ConexaoLaudo()

        Dim Str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim Sql As String = "select count(*) from Laudos where CNPJ=@CNPJ "

        Try

            Using Conn As New SqlConnection(Str)
                Using cmd As New SqlCommand(Sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@CNPJ", FrmLegalizacao.CNPJMaskedTextBox.Text)

                    Dim value = cmd.ExecuteScalar()

                    If value > 0 Then


                        ' MessageBox.Show("Ja existe um Laudo/Alvará cadastrado com o mesmo CNPJ! Abrindo...")
                        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then

                            'Abre o alvara ja cadastrado com a busca CNPJ
                            FrmAlvara.Focus()
                            FrmAlvara.ComboBoxBuscaCNPJ.Text = FrmLegalizacao.CNPJMaskedTextBox.Text
                            FrmAlvara.ComboBoxBuscaCNPJ.Focus()
                            FrmAlvara.RazaoSocialTextBox.Focus()
                            'FIM  abre o alvara ja cadastrado com a busca CNPJ

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then
                                If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                                    FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text

                                End If

                            End If
                        Else

                            FrmAlvara.Show()
                            FrmAlvara.ComboBoxBuscaCNPJ.Text = FrmLegalizacao.CNPJMaskedTextBox.Text
                            FrmAlvara.ComboBoxBuscaCNPJ.Focus()
                            FrmAlvara.RazaoSocialTextBox.Focus()

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then
                                If MessageBox.Show("Razão Social Diferentes, deseja atualizar?", "Prince Sistemas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                                    FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text

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
                                    FrmLegalizacao.TabControle.SelectTab(1) 'dados

                                    'tabcontrole dos aba dados
                                    FrmLegalizacao.TabControl2.SelectTab(0)
                                    FrmLegalizacao.TabControl2.SelectTab(1)
                                    FrmLegalizacao.TabControl2.SelectTab(2)
                                    FrmLegalizacao.TabControl2.SelectTab(3)
                                    FrmLegalizacao.TabControl2.SelectTab(4)
                                    FrmLegalizacao.TabControl2.SelectTab(5)
                                    FrmLegalizacao.TabControl2.SelectTab(6)
                                    FrmLegalizacao.TabControl2.SelectTab(7)





                                    ' Abre o formulário FrmAlvara
                                    FrmAlvara.Show()

                                    ' Adiciona um novo registro
                                    FrmAlvara.LaudosBindingSource.AddNew()

                                    ' Finaliza a edição para que o registro seja tratado como uma alteração
                                    FrmAlvara.LaudosBindingSource.EndEdit()

                                    '  LFrmAlvara.RazaoSocialTextBox.Text = RazaoSocialTextBox.Text


                                    'codigo de copiar entre os form

                                    'COPIA OS DADOS
                                    FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text
                                    FrmAlvara.CNPJMaskedTextBox.Text = FrmLegalizacao.CNPJMaskedTextBox.Text

                                    'Não Iniciado
                                    FrmAlvara.SituacaoComboBox.Text = "Não Iniciado"


                                    FrmAlvara.TabControl2.SelectTab(1)
                                    'copia
                                    FrmAlvara.EndCEPMaskedTextBox.Text = FrmLegalizacao.EndCEPMaskedTextBox.Text
                                    FrmAlvara.EnderecoTextBox.Text = FrmLegalizacao.EnderecoTextBox.Text
                                    FrmAlvara.EndNumTextBox.Text = FrmLegalizacao.EndNumeroTextBox.Text
                                    FrmAlvara.EndCompTextBox.Text = FrmLegalizacao.EndComplementoTextBox.Text
                                    FrmAlvara.EndBairroTextBox.Text = FrmLegalizacao.EndBairroTextBox.Text
                                    FrmAlvara.EndCidadeTextBox.Text = FrmLegalizacao.EndCidadeTextBox.Text
                                    FrmAlvara.EndEstadoTextBox.Text = FrmLegalizacao.EndEstadoTextBox.Text

                                    FrmAlvara.AreaTextBox.Text = FrmLegalizacao.AreaTextBox.Text
                                    FrmAlvara.Area2TextBox.Text = FrmLegalizacao.Area2TextBox.Text
                                    FrmAlvara.CadImobTextBox.Text = FrmLegalizacao.CadImobTextBox.Text
                                    FrmAlvara.EndZonaTextBox.Text = FrmLegalizacao.EndZonaTextBox.Text
                                    FrmAlvara.EndQuadraTextBox.Text = FrmLegalizacao.EndQuadraTextBox.Text
                                    FrmAlvara.EndDataTextBox.Text = FrmLegalizacao.EndDataTextBox.Text
                                    FrmAlvara.MatrizComboBox.Text = FrmLegalizacao.SEDEComboBox.Text



                                    FrmAlvara.TabControl2.SelectTab(4)
                                    'copia
                                    FrmAlvara.RequerenteTextBox.Text = FrmLegalizacao.NomeResponsavelTextBox.Text
                                    FrmAlvara.CPFRequerenteMaskedTextBox.Text = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text
                                    FrmAlvara.RGRequerenteTextBox.Text = FrmLegalizacao.RespRGTextBox.Text
                                    FrmAlvara.OrgaoRGRequerenteTextBox.Text = FrmLegalizacao.ResponsavelOrgaoRGTextBox.Text
                                    FrmAlvara.EstadoOrgaoRGRequerenteTextBox.Text = FrmLegalizacao.ResponsavelEstadoOrgaoRGTextBox.Text
                                    FrmAlvara.FoneRequerenteTextBox.Text = FrmLegalizacao.EmpTel1TextBox.Text
                                    FrmAlvara.EmailRequerenteTextBox.Text = FrmLegalizacao.EmpEmailTextBox.Text



                                    FrmAlvara.TabControl2.SelectTab(3)
                                    'copia
                                    FrmAlvara.CNAEPrimarioTextBox.Text = FrmLegalizacao.CNAEPrincipalTextBox.Text
                                    FrmAlvara.CNAERichTextBox.Text = FrmLegalizacao.CNAESecundarioRichTextBox.Text
                                    FrmAlvara.RamodeatividadeRichTextBox.Text = FrmLegalizacao.RamoDeAtividadeRichTextBox.Text


                                    FrmAlvara.TabControl2.SelectTab(5)

                                    If FrmLegalizacao.ProcessoComboBox.Text = "Abertura" Then
                                        'copia
                                        FrmAlvara.NaturezaDoPedidoRichTextBox.Text = "Nova Empresa;
"

                                    Else
                                        'copia
                                        FrmAlvara.NaturezaDoPedidoRichTextBox.Text = FrmLegalizacao.MotivoRichTextBox.Text

                                    End If
                                    'copia
                                    ' FrmAlvara.NaturezaDoPedidoRichTextBox.Text = FrmLegalizacao.MotivoTextBox.Text

                                    'data de criação e aviso
                                    FrmAlvara.DataCriadoMaskedTextBox.Text = System.DateTime.Now
                                    FrmAlvara.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

                                    'termina as copia e foca
                                    'Focus
                                    FrmAlvara.RazaoSocialTextBox.Focus()
                                    FrmAlvara.TabControlAcompanhamento.SelectTab(0)

                                    'unchek lembrete
                                    FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.PrioridadeCheckBox.CheckState = CheckState.Unchecked


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
                                    ' Abre o formulário FrmAlvara
                                    FrmAlvara.Show()

                                    ' Adiciona um novo registro
                                    FrmAlvara.LaudosBindingSource.AddNew()

                                    ' Finaliza a edição para que o registro seja tratado como uma alteração
                                    FrmAlvara.LaudosBindingSource.EndEdit()


                                    FrmAlvara.TabControlAcompanhamento.SelectTab(0)

                                    FrmAlvara.ComboBoxBuscaAlvara.Focus()
                                    FrmAlvara.RazaoSocialTextBox.Focus()


                                    'unchek lembrete
                                    FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked
                                    FrmAlvara.PrioridadeCheckBox.CheckState = CheckState.Unchecked


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
                    FrmLegalizacao.Focus()
                    FrmLegalizacao.TabControle.SelectTab(0)

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

                        'Abre o alvara ja cadastrado com a busca CNPJ
                        FrmLegalizacao.Focus()
                        FrmLegalizacao.ComboBoxBuscaCNPJ.Text = FrmAlvara.CNPJMaskedTextBox.Text
                        FrmLegalizacao.ComboBoxBuscaCNPJ.Focus()
                        FrmLegalizacao.RazaoSocialTextBox.Focus()
                        'FIM  abre o alvara ja cadastrado com a busca CN



                        ' MessageBox.Show("Ja existe uma Empresa cadastrada! Abrindo...")

                        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
                            Dim Sair As String
                            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                            FrmLegalizacao.Focus()
                            FrmLegalizacao.ComboBoxBuscaCNPJ.Text = FrmAlvara.CNPJMaskedTextBox.Text
                            FrmLegalizacao.ComboBoxBuscaCNPJ.Focus()
                            'FrmLegalizacao.RazaoSocialTextBox.Focus()

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then

                                Dim Msg As String
                                Msg = MsgBox("Razão Social Diferente, favor deixar os dois formulários com a mesma Razão Social", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                            End If


                        Else

                            FrmLegalizacao.Show()
                            FrmLegalizacao.ComboBoxBuscaCNPJ.Text = FrmAlvara.CNPJMaskedTextBox.Text
                            FrmLegalizacao.ComboBoxBuscaCNPJ.Focus()
                            FrmLegalizacao.Focus()

                            'Verifica Razao Social
                            If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then

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
            'FrmLegalizacao.Close()
        End Try
    End Sub


    Sub Atualizadadadoslaudo()


        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            '  Dim Sair As String
            ' Sair = MsgBox("O formulário ja está aberto, Importando dados ...", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then

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

            If FrmAlvara.RazaoSocialTextBox.Text <> FrmLegalizacao.RazaoSocialTextBox.Text Then

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
            FrmLegalizacao.TabControle.SelectTab(1) 'dados

            'tabcontrole dos aba dados
            FrmLegalizacao.TabControl2.SelectTab(0)
            FrmLegalizacao.TabControl2.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(2)
            FrmLegalizacao.TabControl2.SelectTab(3)
            FrmLegalizacao.TabControl2.SelectTab(4)
            FrmLegalizacao.TabControl2.SelectTab(5)
            FrmLegalizacao.TabControl2.SelectTab(6)
            FrmLegalizacao.TabControl2.SelectTab(7)

            '//


            'codigo de copiar entre os form

            'COPIA OS DADOS
            FrmAlvara.RazaoSocialTextBox.Text = FrmLegalizacao.RazaoSocialTextBox.Text
            FrmAlvara.CNPJMaskedTextBox.Text = FrmLegalizacao.CNPJMaskedTextBox.Text




            FrmAlvara.TabControl2.SelectTab(1)
            'copia
            FrmAlvara.EndCEPMaskedTextBox.Text = FrmLegalizacao.EndCEPMaskedTextBox.Text
            FrmAlvara.EnderecoTextBox.Text = FrmLegalizacao.EnderecoTextBox.Text
            FrmAlvara.EndNumTextBox.Text = FrmLegalizacao.EndNumeroTextBox.Text
            FrmAlvara.EndCompTextBox.Text = FrmLegalizacao.EndComplementoTextBox.Text
            FrmAlvara.EndBairroTextBox.Text = FrmLegalizacao.EndBairroTextBox.Text
            FrmAlvara.EndCidadeTextBox.Text = FrmLegalizacao.EndCidadeTextBox.Text
            FrmAlvara.EndEstadoTextBox.Text = FrmLegalizacao.EndEstadoTextBox.Text

            FrmAlvara.AreaTextBox.Text = FrmLegalizacao.AreaTextBox.Text
            FrmAlvara.Area2TextBox.Text = FrmLegalizacao.Area2TextBox.Text
            FrmAlvara.CadImobTextBox.Text = FrmLegalizacao.CadImobTextBox.Text
            FrmAlvara.EndZonaTextBox.Text = FrmLegalizacao.EndZonaTextBox.Text
            FrmAlvara.EndQuadraTextBox.Text = FrmLegalizacao.EndQuadraTextBox.Text
            FrmAlvara.EndDataTextBox.Text = FrmLegalizacao.EndDataTextBox.Text
            FrmAlvara.MatrizComboBox.Text = FrmLegalizacao.SEDEComboBox.Text



            FrmAlvara.TabControl2.SelectTab(4)
            'copia
            FrmAlvara.RequerenteTextBox.Text = FrmLegalizacao.NomeResponsavelTextBox.Text
            FrmAlvara.CPFRequerenteMaskedTextBox.Text = FrmLegalizacao.CPFResponsavelMaskedTextBox.Text
            FrmAlvara.RGRequerenteTextBox.Text = FrmLegalizacao.RespRGTextBox.Text
            FrmAlvara.OrgaoRGRequerenteTextBox.Text = FrmLegalizacao.ResponsavelOrgaoRGTextBox.Text
            FrmAlvara.EstadoOrgaoRGRequerenteTextBox.Text = FrmLegalizacao.ResponsavelEstadoOrgaoRGTextBox.Text
            FrmAlvara.FoneRequerenteTextBox.Text = FrmLegalizacao.EmpTel1TextBox.Text
            FrmAlvara.EmailRequerenteTextBox.Text = FrmLegalizacao.EmpEmailTextBox.Text




            FrmAlvara.TabControl2.SelectTab(3)
            'copia
            FrmAlvara.CNAEPrimarioTextBox.Text = FrmLegalizacao.CNAEPrincipalTextBox.Text
            FrmAlvara.CNAERichTextBox.Text = FrmLegalizacao.CNAESecundarioRichTextBox.Text
            FrmAlvara.RamodeatividadeRichTextBox.Text = FrmLegalizacao.RamoDeAtividadeRichTextBox.Text


            FrmAlvara.TabControl2.SelectTab(5)

            If FrmLegalizacao.ProcessoComboBox.Text = "Abertura" Then
                'copia
                FrmAlvara.NaturezaDoPedidoRichTextBox.Text = "Nova Empresa;
"

            Else
                'copia
                FrmAlvara.NaturezaDoPedidoRichTextBox.Text = FrmLegalizacao.MotivoRichTextBox.Text

            End If
            'copia
            ' FrmAlvara.NaturezaDoPedidoRichTextBox.Text = FrmLegalizacao.MotivoTextBox.Text

            'data de criação e aviso
            FrmAlvara.DataCriadoMaskedTextBox.Text = System.DateTime.Now
            FrmAlvara.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

            'termina as copia e foca
            'Focus
            FrmAlvara.RazaoSocialTextBox.Focus()
            FrmAlvara.TabControlAcompanhamento.SelectTab(0)

            'unchek lembrete
            FrmAlvara.LembreteCheckBox.CheckState = CheckState.Unchecked
            FrmAlvara.PrioridadeCheckBox.CheckState = CheckState.Unchecked


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

            ' FrmLegalizacao.Close()

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
            Dim I = FrmAlvara.NumeroProcessoTextBox.Text.ToString()
            Dim J = FrmAlvara.ReciboProcessoTextBox.Text.ToString()

            'abrir histórico
            FrmAlvara.TabAlvara.SelectTab(4)


            'Salvar
            FrmAlvara.HistoricoRichTextBox.SelectedText &=
    "Protocolo: Data " & D & "; Tipo:" & E & ", Número:" & F & ", Ano:" & G & ", Senha:" & H & ".
Nº do processo: " & I & ", com recibo do processo: " & J & ".

//-----------------//-----------------//-----------------//-----------------//
"

            'Limpando as BOX
            FrmAlvara.DataEntradaMaskedTextBox.Text = ""
            FrmAlvara.ProtocoloTipoTextBox.Text = ""
            FrmAlvara.ProtocoloNTextBox.Text = ""
            FrmAlvara.ProtocoloAnoTextBox.Text = ""
            FrmAlvara.ProtocoloSenhaTextBox.Text = ""
            FrmAlvara.NumeroProcessoTextBox.Text = ""
            FrmAlvara.ReciboProcessoTextBox.Text = ""

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
