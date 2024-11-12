Imports System.Data.SqlClient

Public Class FrmControleParcelamentos
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub FrmControleParcelamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Parcelamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)

        BtnEditar.Text = "Cancelar"

        ' Verifica o estado das CheckBox e exibe/esconde os DateTimePickers
        AtualizarDateTimePickers()
        ' Atualiza a visibilidade das TabPages com base nas CheckBoxes
        AtualizarVisibilidadeTabs()
    End Sub

    Private Sub BtnDuplicidade_Click(sender As Object, e As EventArgs) Handles BtnDuplicidade.Click
        VerificarDuplicidadeCNPJ(CNPJMaskedTextBox.Text)
    End Sub

    Private Sub VerificarDuplicidadeCNPJ(cnpjOuCpf As String)
        ' Remove a máscara para garantir que o CNPJ ou CPF seja consultado no formato correto
        Dim documentoFormatado As String = cnpjOuCpf '.Replace(".", "").Replace("/", "").Replace("-", "")

        Using connection As New SqlConnection(Str)
            Try
                connection.Open()

                ' Log da consulta
                Debug.WriteLine("Consultando duplicidade de CNPJ ou CPF: " & documentoFormatado)

                ' Consulta para verificar o CNPJ ou CPF na tabela "Parcelamentos"
                Dim query As String = "SELECT RazaoSocial FROM Parcelamentos WHERE CNPJ = @Documento"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Documento", documentoFormatado)

                    Dim razaoSocial As Object = cmd.ExecuteScalar()
                    If razaoSocial IsNot Nothing Then
                        ' Documento já existe na tabela Parcelamentos, exibe a razão social
                        MessageBox.Show("Documento já cadastrado na tabela Parcelamentos!" & vbCrLf & vbCrLf &
                                    "CNPJ/CPF: " & documentoFormatado & vbCrLf &
                                    "Nome / Razão Social: " & razaoSocial.ToString())
                        Exit Sub
                    Else
                        ' Caso o documento (CNPJ ou CPF) não exista na tabela
                        MessageBox.Show("Documento não cadastrado na tabela Parcelamentos.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnCopiarCNPJ_Click(sender As Object, e As EventArgs) Handles BtnCopiarCNPJ.Click
        ' Obtém o texto do CNPJMaskedTextBox e remove qualquer caractere que não seja número
        Dim cnpjSomenteNumeros As String = New String(CNPJMaskedTextBox.Text.Where(AddressOf Char.IsDigit).ToArray())

        ' Copia o CNPJ sem máscara para a área de transferência
        If Not String.IsNullOrEmpty(cnpjSomenteNumeros) Then
            Clipboard.SetText(cnpjSomenteNumeros)
            ' MessageBox.Show("CNPJ copiado para a área de transferência: " & cnpjSomenteNumeros, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("CNPJ está vazio ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnBImportarEmpresa_Click(sender As Object, e As EventArgs) Handles BtnBImportarEmpresa.Click
        If CNPJMaskedTextBox.Text = "" Then
            MessageBox.Show("CNPJ Vazio, informar CNPJ Antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNPJMaskedTextBox.Focus()
        Else

            VerificarDuplicidadeCNPJ(CNPJMaskedTextBox.Text)

            ' Pergunta ao usuário se ele deseja realmente importar os dados
            Dim resposta As DialogResult = MessageBox.Show("Deseja importar os dados da empresa?", "Confirmação de Importação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Se o usuário selecionar "Não", sai do método
            If resposta = DialogResult.No Then
                Exit Sub
            End If

            ' Define a string de conexão
            Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

            ' Abre a conexão com o banco de dados
            Using conn As New SqlConnection(str)
                Try
                    conn.Open()

                    ' Obtém o CNPJ a ser pesquisado
                    Dim cnpj As String = CNPJMaskedTextBox.Text

                    ' Cria o comando SQL para buscar a empresa pelo CNPJ
                    Dim query As String = "SELECT RazaoSocial, CNPJ, NomeResponsavel, CPFResponsavel, SenhaGov, Endereco, EndNumero, EndBairro, EndComplemento, EndCEP, EndCidade, EndEstado " &
                                          "FROM Empresas WHERE CNPJ = @CNPJ"

                    Using cmd As New SqlCommand(query, conn)
                        ' Adiciona o parâmetro CNPJ à consulta
                        cmd.Parameters.AddWithValue("@CNPJ", cnpj)

                        ' Executa a consulta e obtém os dados
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.HasRows Then
                                ' Ativa as abas necessárias no TabControl
                                TabControlPrincipal.SelectedIndex = 0
                                TabControlPrincipal.SelectedIndex = 1
                                TabControlPrincipal.SelectedIndex = 2
                                TabControlPrincipal.SelectedIndex = 3

                                ' Se encontrar a empresa, preenche os campos do formulário
                                reader.Read()

                                RazaoSocialTextBox.Text = reader("RazaoSocial").ToString()
                                CNPJMaskedTextBox.Text = reader("CNPJ").ToString()
                                SocioResponsavelTextBox.Text = reader("NomeResponsavel").ToString()
                                CPFsocioResponsavelMaskedTextBox.Text = reader("CPFResponsavel").ToString()
                                GovSenhaMaskedTextBox.Text = reader("SenhaGov").ToString()
                                RuaTextBox.Text = reader("Endereco").ToString()
                                NumeroTextBox.Text = reader("EndNumero").ToString()
                                ComplementoTextBox.Text = reader("EndComplemento").ToString()
                                BairroTextBox.Text = reader("EndBairro").ToString()
                                CidadeTextBox.Text = reader("EndCidade").ToString()
                                EstadoTextBox.Text = reader("EndEstado").ToString()

                                TabControlPrincipal.SelectedIndex = 0
                                ' Exibe mensagem de sucesso após a importação
                                MessageBox.Show("Dados importados com sucesso!", "Importação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Else
                                ' Se não encontrar, exibe uma mensagem de erro
                                MessageBox.Show("Empresa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                FrmLegalizacao.Show()
                                FrmLegalizacao.BtnNovo.PerformClick()
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    ' Em caso de erro, exibe a mensagem de erro
                    MessageBox.Show("Erro ao conectar com o banco de dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

            End Using

        End If
    End Sub

    Private Sub BtnImportaSocio_Click(sender As Object, e As EventArgs) Handles BtnImportaSocio.Click
        TabControlPrincipal.SelectedIndex = 3
        If SocioResponsavelTextBox.Text <> "" Then
            NomeResponsavelTextBox.Text = SocioResponsavelTextBox.Text
        Else
            MessageBox.Show("O campo: Sócio/Responsável está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnAbrirWhatsApp_Click(sender As Object, e As EventArgs) Handles BtnAbrirWhatsApp.Click
        ' Obter o telefone do WhatsAppTextBox
        Dim phoneNumber As String = WhatsAppTextBox.Text.Trim()

        ' Remover todos os caracteres não numéricos (apenas números)
        phoneNumber = System.Text.RegularExpressions.Regex.Replace(phoneNumber, "[^\d]", "")

        ' Verificar se o número tem DDI (55 para Brasil ou outro país)
        If phoneNumber.StartsWith("55") Then
            ' Se o número começar com 55 (Brasil), o código irá tratar
            If phoneNumber.Length > 2 Then
                ' Extrair o DDD (2 dígitos após o 55)
                Dim ddd As String = phoneNumber.Substring(2, 2)
                ' O restante é o número de telefone (pode ser 8 ou 9 dígitos)
                Dim phone As String = phoneNumber.Substring(4)

                ' Verificar se o número tem o tamanho correto (8 ou 9 dígitos)
                If phone.Length >= 8 AndAlso phone.Length <= 9 Then
                    ' Formatar o número corretamente para o Brasil
                    phoneNumber = $"55{ddd}{phone}"
                Else
                    MessageBox.Show("O número de telefone no Brasil deve ter 8 ou 9 dígitos após o DDD.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else
            ' Caso não seja 55 (Brasil), verificar se é DDI de outro país
            If phoneNumber.Length >= 10 Then
                ' Validar a estrutura geral do número internacional
                phoneNumber = phoneNumber ' Considera o número completo com DDI
            Else
                MessageBox.Show("Número de telefone inválido. Verifique o DDI e o número.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        ' Verificar se o número está vazio ou inválido
        If String.IsNullOrEmpty(phoneNumber) OrElse phoneNumber.Length < 10 Then
            MessageBox.Show("Número de telefone inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Montar o link do WhatsApp
        Dim whatsappLink As String = $"https://wa.me/{phoneNumber}"

        ' Abrir o WhatsApp com o número formatado
        Try
            System.Diagnostics.Process.Start(whatsappLink)
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir o WhatsApp: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAbriremail_Click(sender As Object, e As EventArgs) Handles BtnAbriremail.Click
        ' Obter o endereço de e-mail do EmailTextBox
        Dim email As String = EmailTextBox.Text.Trim()

        ' Verifica se o e-mail não está vazio
        If Not String.IsNullOrEmpty(email) Then
            ' Formatar o e-mail com o prefixo "mailto:"
            Dim mailtoLink As String = "mailto:" & email

            Try
                ' Tentar abrir o cliente de e-mail do sistema
                System.Diagnostics.Process.Start(mailtoLink)
            Catch ex As Exception
                MessageBox.Show("Não foi possível abrir o cliente de e-mail. Verifique se há um cliente de e-mail configurado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        ' Pergunta ao usuário se deseja criar um novo registro
        Dim result = MessageBox.Show("Deseja criar um novo registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Adiciona um novo registro
            ParcelamentosBindingSource.AddNew()

            ' Chama o método para resetar as CheckBox
            ResetarCheckBoxes()
        End If
    End Sub

    ' Método para resetar as CheckBox
    Private Sub ResetarCheckBoxes()
        ' Desmarcar todas as CheckBoxes
        MEICheckBox.Checked = False
        INSSAntigoCheckBox.Checked = False
        INSSNovoCheckBox.Checked = False
        INSSProcuradoriaCheckBox.Checked = False

        ' Se você tiver mais CheckBoxes para resetar, adicione-os aqui.
    End Sub


    '////////////////////////////////////  MENU ////////////////////////////////////////
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'Pergunta ao usuário se deseja salvar as alterações
        Dim result = MessageBox.Show("Deseja salvar as alterações?", "Salvar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Salvar()
        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'Pergunta ao usuário se deseja excluir o registro selecionado
        Dim result = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ParcelamentosBindingSource.RemoveCurrent()
            Salvar()
        End If
    End Sub

    Private Sub Salvar()
        ' Atualiza o DataRow com o valor dos DateTimePickers, lidando com datas nulas
        If Me.PrinceDBDataSet.Parcelamentos.Rows.Count > 0 Then
            Dim currentRow As DataRow = Me.PrinceDBDataSet.Parcelamentos.Rows(0)

            ' Verifica o estado da CheckBox TemDataLembreteCheckBox e define a data ou NULL
            If TemDataLembreteCheckBox.Checked = False Then
                currentRow("TemDataLembrete") = DBNull.Value
            Else
                currentRow("TemDataLembrete") = DataLembreteDateTimePicker.Value
            End If

            ' Verifica o estado da CheckBox TemDataEnvioCheckBox e define a data ou NULL
            If TemDataEnvioCheckBox.Checked = False Then
                currentRow("TemDataEnvio") = DBNull.Value
            Else
                currentRow("TemDataEnvio") = DataEnvioDateTimePicker.Value
            End If
        End If

        ' Verifica se houve alterações e pergunta ao usuário se deseja salvar
        Me.Validate()
        ParcelamentosBindingSource.EndEdit()

        If PrinceDBDataSet.HasChanges() Then
            ' Solicita confirmação ao usuário
            Dim result As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    ParcelamentosTableAdapter.Update(Me.PrinceDBDataSet.Parcelamentos)
                    MessageBox.Show("Alterações salvas com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Erro ao salvar as alterações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Nenhuma alteração detectada para salvar.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        'Verifica se há alterações e pergunta se deseja salvar antes de fechar
        If PrinceDBDataSet.HasChanges() Then
            Dim result = MessageBox.Show("Deseja salvar as alterações antes de fechar?", "Salvar Alterações", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Salvar()
                Me.Close()
            ElseIf result = DialogResult.No Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Verifica o texto atual do botão para alternar entre os modos Editar e Cancelar
        If BtnEditar.Text = "Editar" Then
            ' Muda o texto do botão para "Cancelar" e habilita o modo de edição
            BtnEditar.Text = "Cancelar"

            ' Libera o TabControlPrincipal para edição
            TabControlPrincipal.Enabled = True

            ' Aqui você pode adicionar o código para ativar campos ou controles adicionais, se necessário
            ' Por exemplo: TextBoxNome.Enabled = True
        Else
            ' Muda o texto do botão de volta para "Editar" e bloqueia o modo de edição
            BtnEditar.Text = "Editar"

            ' Bloqueia o TabControlPrincipal para impedir edição
            TabControlPrincipal.Enabled = False

            ' Aqui você pode adicionar o código para desativar campos ou controles, se necessário
            ' Por exemplo: TextBoxNome.Enabled = False
        End If
    End Sub


    '////////////////////////////////////  FIM MENU ////////////////////////////////////////

    Private Sub EditarAtivo()

    End Sub

    Private Sub CancelarAtivo()

    End Sub


    '///////////////////////////   DateTimePicker ///////////////////////////////////////////

    Private Sub TemDataLembreteCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataLembreteCheckBox.CheckedChanged
        ' Atualiza a exibição do DateTimePicker de Lembrete
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEnvioCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEnvioCheckBox.CheckedChanged
        ' Atualiza a exibição do DateTimePicker de Envio
        AtualizarDateTimePickers()
    End Sub

    Private Sub AtualizarDateTimePickers()
        ' Verifica o estado da CheckBox e mostra/esconde o DateTimePicker
        DataLembreteDateTimePicker.Visible = TemDataLembreteCheckBox.Checked
        DataEnvioDateTimePicker.Visible = TemDataEnvioCheckBox.Checked
    End Sub

    '///////////////////////////   FIM  DateTimePicker ///////////////////////////////////////////

    '///////////////////////////   Check Parcelamento  ///////////////////////////////////////////

    Private Sub MEICheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MEICheckBox.CheckedChanged
        ' Atualiza a visibilidade das TabPages quando a CheckBox MEI for alterada
        AtualizarVisibilidadeTabs()
    End Sub

    Private Sub INSSAntigoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles INSSAntigoCheckBox.CheckedChanged
        ' Atualiza a visibilidade das TabPages quando a CheckBox INSSAntigo for alterada
        AtualizarVisibilidadeTabs()
    End Sub

    Private Sub INSSNovoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles INSSNovoCheckBox.CheckedChanged
        ' Atualiza a visibilidade das TabPages quando a CheckBox INSSNovo for alterada
        AtualizarVisibilidadeTabs()
    End Sub

    Private Sub INSSProcuradoriaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles INSSProcuradoriaCheckBox.CheckedChanged
        ' Atualiza a visibilidade das TabPages quando a CheckBox INSSProcuradoria for alterada
        AtualizarVisibilidadeTabs()
    End Sub

    Private Sub AtualizarVisibilidadeTabs()
        ' Limpa todas as abas do controle de guias
        TabControleParcelamentos.TabPages.Clear()

        ' Adiciona as abas ao controle de guias com base nas CheckBox selecionadas
        If MEICheckBox.Checked AndAlso TabControleParcelamentos.TabPages.Contains(TabPageMEI) = False Then
            TabControleParcelamentos.TabPages.Add(TabPageMEI) ' MEI
        End If
        If INSSAntigoCheckBox.Checked AndAlso TabControleParcelamentos.TabPages.Contains(TabPageINSSAntigo) = False Then
            TabControleParcelamentos.TabPages.Add(TabPageINSSAntigo) ' INSS Antigo
        End If
        If INSSNovoCheckBox.Checked AndAlso TabControleParcelamentos.TabPages.Contains(TabPageINSSNovo) = False Then
            TabControleParcelamentos.TabPages.Add(TabPageINSSNovo) ' INSS Novo
        End If
        If INSSProcuradoriaCheckBox.Checked AndAlso TabControleParcelamentos.TabPages.Contains(TabPageINSSProcuradoria) = False Then
            TabControleParcelamentos.TabPages.Add(TabPageINSSProcuradoria) ' INSS Procuradoria
        End If

        ' Verifica se há pelo menos uma aba visível e seleciona a primeira
        If TabControleParcelamentos.TabPages.Count > 0 Then
            TabControleParcelamentos.SelectedTab = TabControleParcelamentos.TabPages(0)
        End If
    End Sub

    '///////////////////////////   FIM Check Parcelamento   ///////////////////////////////////////////
End Class