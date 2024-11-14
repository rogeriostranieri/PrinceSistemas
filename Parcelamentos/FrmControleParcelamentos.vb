Imports System.Data.SqlClient

Public Class FrmControleParcelamentos
    ReadOnly str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub FrmControleParcelamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Parcelamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)

        BtnEditar.Text = "Cancelar"

        ' Verifica o estado das CheckBox e exibe/esconde os DateTimePickers
        ' AtualizarDateTimePickers()
        ' Atualiza a visibilidade das TabPages com base nas CheckBoxes
        '  AtualizarVisibilidadeTabs()

        GroupBoxSalvando.Visible = False

        ' Itera sobre todos os controles do formulário
        For Each ctrl As Control In Me.Controls
            ' Verifica se o controle é um DateTimePicker
            If TypeOf ctrl Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = CType(ctrl, DateTimePicker)
                ' Define o formato para exibir data e hora
                dateTimePicker.Format = DateTimePickerFormat.Custom
                dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm"
            End If
        Next

        HistoricoEnvioMEIRichTextBox.ReadOnly = True
        HistoricoEnvioINSSAntigoRichTextBox.ReadOnly = True
        HistoricoEnvioINSSNovoRichTextBox.ReadOnly = True
        HistoricoEnvioINSSProcRichTextBox.ReadOnly = True
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
        Dim cnpjSomenteNumeros As New String(CNPJMaskedTextBox.Text.Where(AddressOf Char.IsDigit).ToArray())

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
        'Principal
        TemDataLembreteCheckBox.Checked = False
        TemDataFimParcelamentoCheckBox.Checked = False
        MEICheckBox.Checked = False
        INSSAntigoCheckBox.Checked = False
        INSSNovoCheckBox.Checked = False
        INSSProcuradoriaCheckBox.Checked = False

        ' Desmarcar todas as CheckBoxes principais
        MEICheckBox.Checked = False
        INSSAntigoCheckBox.Checked = False
        INSSNovoCheckBox.Checked = False
        INSSProcuradoriaCheckBox.Checked = False

        ' Desmarcar CheckBoxes de controle de datas para MEI
        TemDataEntradaMEICheckBox.Checked = False
        TemDataFimMEICheckBox.Checked = False
        TemDataEnvioMEICheckBox.Checked = False

        ' Desmarcar CheckBoxes de controle de datas para INSS Antigo
        TemDataEntradaINSSAntigoCheckBox.Checked = False
        TemDataFimINSSAntigoCheckBox.Checked = False
        TemDataEnvioINSSAntigoCheckBox.Checked = False

        ' Desmarcar CheckBoxes de controle de datas para INSS Novo
        TemDataEntradaINSSNovoCheckBox.Checked = False
        TemDataFimINSSNovoCheckBox.Checked = False
        TemDataEnvioINSSNovoCheckBox.Checked = False

        ' Desmarcar CheckBoxes de controle de datas para INSS Procuração
        TemDataEntradaINSSProcuCheckBox.Checked = False
        TemDataFimINSSProcurCheckBox.Checked = False
        TemDataEnvioINSSProcurCheckBox.Checked = False

        ' Adicione aqui mais CheckBoxes que precisar resetar, se necessário.
    End Sub

    '//////////////// verifica dataepick antes de salva
    Private Sub VerificarCampos()
        ' Verificar MEI
        If TemDataEntradaMEICheckBox.Checked AndAlso DataParcMEIDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Parcelamento MEI está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataFimMEICheckBox.Checked AndAlso DataFimParcMEIDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Fim MEI está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataEnvioMEICheckBox.Checked AndAlso MesEnviadoMEIDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Mês Enviado MEI está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Verificar INSS Antigo
        If TemDataEntradaINSSAntigoCheckBox.Checked AndAlso DataParcelINSSantigoDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Parcelamento INSS Antigo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataFimINSSAntigoCheckBox.Checked AndAlso FinalizadoINSSAntigoDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Fim INSS Antigo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataEnvioINSSAntigoCheckBox.Checked AndAlso MesEnviadoINSSAntigoDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Mês Enviado INSS Antigo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Verificar INSS Novo
        If TemDataEntradaINSSNovoCheckBox.Checked AndAlso DataParcelINSSnovoDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Parcelamento INSS Novo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataFimINSSNovoCheckBox.Checked AndAlso FinalizadoINSSNovoDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Fim INSS Novo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataEnvioINSSNovoCheckBox.Checked AndAlso MesEnviadoINSSNovoDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Mês Enviado INSS Novo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Verificar INSS Procuração
        If TemDataEntradaINSSProcuCheckBox.Checked AndAlso DataParcelINSSprocDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Parcelamento INSS Procuração está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataFimINSSProcurCheckBox.Checked AndAlso FinalizadoINSSProcDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Data de Fim INSS Procuração está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TemDataEnvioINSSProcurCheckBox.Checked AndAlso MesEnviadoINSSProcDateTimePicker.Value = Nothing Then
            MessageBox.Show("O campo Mês Enviado INSS Procuração está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub


    '////////////////////////////////////  MENU ////////////////////////////////////////
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        VerificarCampos() 'verficia se o cehckbox esta marcado e se o datackpik esta vazio
        Salvar() ' continua com salvar
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'Pergunta ao usuário se deseja excluir o registro selecionado
        Dim result = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ParcelamentosBindingSource.RemoveCurrent()
            'Salvar()
        End If
    End Sub


    Private camposOriginais As New Dictionary(Of String, Object)
    Private precisaSalvar As Boolean = False


    ' Carregar valores iniciais ao abrir o formulário
    Private Sub CarregarValoresIniciais()
        If Me.PrinceDBDataSet.Parcelamentos.Rows.Count > 0 Then
            Dim currentRow As DataRow = Me.PrinceDBDataSet.Parcelamentos.Rows(0)

            ' Carregar os valores iniciais dos campos MEI
            camposOriginais("DataParcMEI") = If(IsDBNull(currentRow("DataParcMEI")), Nothing, currentRow("DataParcMEI"))
            camposOriginais("DataFimParcMEI") = If(IsDBNull(currentRow("DataFimParcMEI")), Nothing, currentRow("DataFimParcMEI"))
            camposOriginais("MesEnviadoMEI") = If(IsDBNull(currentRow("MesEnviadoMEI")), Nothing, currentRow("MesEnviadoMEI"))

            ' Carregar os valores iniciais dos campos INSS Antigo
            camposOriginais("DataParcelINSSAntigo") = If(IsDBNull(currentRow("DataParcelINSSAntigo")), Nothing, currentRow("DataParcelINSSAntigo"))
            camposOriginais("FinalizadoINSSAntigo") = If(IsDBNull(currentRow("FinalizadoINSSAntigo")), Nothing, currentRow("FinalizadoINSSAntigo"))
            camposOriginais("MesEnviadoINSSAntigo") = If(IsDBNull(currentRow("MesEnviadoINSSAntigo")), Nothing, currentRow("MesEnviadoINSSAntigo"))

            ' Carregar os valores iniciais dos campos INSS Novo
            camposOriginais("DataParcelINSSNovo") = If(IsDBNull(currentRow("DataParcelINSSNovo")), Nothing, currentRow("DataParcelINSSNovo"))
            camposOriginais("FinalizadoINSSNovo") = If(IsDBNull(currentRow("FinalizadoINSSNovo")), Nothing, currentRow("FinalizadoINSSNovo"))
            camposOriginais("MesEnviadoINSSNovo") = If(IsDBNull(currentRow("MesEnviadoINSSNovo")), Nothing, currentRow("MesEnviadoINSSNovo"))

            ' Carregar os valores iniciais dos campos INSS Procuração
            camposOriginais("DataParcelINSSproc") = If(IsDBNull(currentRow("DataParcelINSSproc")), Nothing, currentRow("DataParcelINSSproc"))
            camposOriginais("FinalizadoINSSProc") = If(IsDBNull(currentRow("FinalizadoINSSProc")), Nothing, currentRow("FinalizadoINSSProc"))
            camposOriginais("MesEnviadoINSSProc") = If(IsDBNull(currentRow("MesEnviadoINSSProc")), Nothing, currentRow("MesEnviadoINSSProc"))

            ' Adicione quaisquer outros campos que precise carregar aqui da mesma forma
        End If
    End Sub


    ' Função auxiliar para comparar valores e atualizar campos somente se houver mudança
    Private Sub AtualizarCampo(campo As String, valorNovo As Object)
        If camposOriginais.ContainsKey(campo) AndAlso Not Object.Equals(camposOriginais(campo), valorNovo) Then
            Me.PrinceDBDataSet.Parcelamentos.Rows(0)(campo) = If(valorNovo, DBNull.Value)
            precisaSalvar = True
            camposOriginais(campo) = valorNovo ' Atualiza o valor no dicionário de originais
        End If
    End Sub

    ' Método otimizado para atualizar somente se houver mudanças
    Private Sub CheckBoxSalvar()
        ' MEI
        AtualizarCampo("DataParcMEI", If(TemDataEntradaMEICheckBox.Checked, DataParcMEIDateTimePicker.Value, Nothing))
        AtualizarCampo("DataFimParcMEI", If(TemDataFimMEICheckBox.Checked, DataFimParcMEIDateTimePicker.Value, Nothing))
        AtualizarCampo("MesEnviadoMEI", If(TemDataEnvioMEICheckBox.Checked, MesEnviadoMEIDateTimePicker.Value, Nothing))

        ' INSS Antigo
        AtualizarCampo("DataParcelINSSAntigo", If(TemDataEntradaINSSAntigoCheckBox.Checked, DataParcelINSSantigoDateTimePicker.Value, Nothing))
        AtualizarCampo("FinalizadoINSSAntigo", If(TemDataFimINSSAntigoCheckBox.Checked, FinalizadoINSSAntigoDateTimePicker.Value, Nothing))
        AtualizarCampo("MesEnviadoINSSAntigo", If(TemDataEnvioINSSAntigoCheckBox.Checked, MesEnviadoINSSAntigoDateTimePicker.Value, Nothing))

        ' INSS Novo
        AtualizarCampo("DataParcelINSSNovo", If(TemDataEntradaINSSNovoCheckBox.Checked, DataParcelINSSnovoDateTimePicker.Value, Nothing))
        AtualizarCampo("FinalizadoINSSNovo", If(TemDataFimINSSNovoCheckBox.Checked, FinalizadoINSSNovoDateTimePicker.Value, Nothing))
        AtualizarCampo("MesEnviadoINSSNovo", If(TemDataEnvioINSSNovoCheckBox.Checked, MesEnviadoINSSNovoDateTimePicker.Value, Nothing))

        ' INSS Procuração
        AtualizarCampo("DataParcelINSSproc", If(TemDataEntradaINSSProcuCheckBox.Checked, DataParcelINSSprocDateTimePicker.Value, Nothing))
        AtualizarCampo("FinalizadoINSSProc", If(TemDataFimINSSProcurCheckBox.Checked, FinalizadoINSSProcDateTimePicker.Value, Nothing))
        AtualizarCampo("MesEnviadoINSSProc", If(TemDataEnvioINSSProcurCheckBox.Checked, MesEnviadoINSSProcDateTimePicker.Value, Nothing))
    End Sub

    ' Método otimizado de salvamento
    Private Sub Salvar()
        ' Finaliza qualquer edição pendente para garantir que as alterações sejam reconhecidas
        Me.ParcelamentosBindingSource.EndEdit()

        ' Verifica se há alterações para evitar operações desnecessárias
        If Me.PrinceDBDataSet.HasChanges(DataRowState.Modified Or DataRowState.Added) Then
            ' Pede confirmação antes de salvar
            Dim result As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    ' Inicia o indicador de salvamento e progresso
                    IniciarIndicadorSalvamento()

                    ' Atualiza os campos baseados nas CheckBoxes apenas se houver alterações
                    CheckBoxSalvar()

                    ' Simulação do processo de salvamento com progresso
                    For i As Integer = 1 To 100
                        ' Simulação de salvamento (substitua com seu código real de salvamento)
                        Threading.Thread.Sleep(10) ' Ajuste conforme necessário
                        AtualizarProgressoSalvamento(i) ' Atualiza o progresso
                    Next

                    ' Salva as alterações
                    ParcelamentosTableAdapter.Update(Me.PrinceDBDataSet.Parcelamentos)

                    ' Aceita as alterações no dataset após o salvamento
                    Me.PrinceDBDataSet.Parcelamentos.AcceptChanges()

                    MessageBox.Show("Alterações salvas com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnEditar.PerformClick()

                Catch ex As Exception
                    MessageBox.Show("Erro ao salvar as alterações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Para o indicador de salvamento e exibe "Finalizado!"
                    PararIndicadorSalvamento()
                End Try
            End If
        Else
            ' Exibe mensagem se não houver alterações
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

    Private Sub TemDataEnvioCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        ' Atualiza a exibição do DateTimePicker de Envio
        AtualizarDateTimePickers()
    End Sub
    Private Sub AtualizarDateTimePickers()
        ' Controle de visibilidade dos DateTimePickers GERAL
        DataLembreteDateTimePicker.Visible = TemDataLembreteCheckBox.Checked
        FinalizadoParcelamentosDateTimePicker.Visible = TemDataFimParcelamentoCheckBox.Checked

        ' Controle de visibilidade dos DateTimePickers de MEI
        DataParcMEIDateTimePicker.Visible = TemDataEntradaMEICheckBox.Checked
        DataFimParcMEIDateTimePicker.Visible = TemDataFimMEICheckBox.Checked
        MesEnviadoMEIDateTimePicker.Visible = TemDataEnvioMEICheckBox.Checked
        'Motivo 
        MotivoParcMEIRichTextBox.Visible = TemDataFimMEICheckBox.Checked
        MotivoParcMEILabel.Visible = TemDataFimMEICheckBox.Checked

        ' Controle de visibilidade dos DateTimePickers de INSS Antigo
        DataParcelINSSantigoDateTimePicker.Visible = TemDataEntradaINSSAntigoCheckBox.Checked
        FinalizadoINSSAntigoDateTimePicker.Visible = TemDataFimINSSAntigoCheckBox.Checked
        MesEnviadoINSSAntigoDateTimePicker.Visible = TemDataEnvioINSSAntigoCheckBox.Checked
        'Motivo 
        MotivoParcINSSAntigoRichTextBox.Visible = TemDataFimINSSAntigoCheckBox.Checked
        MotivoParcINSSAntigoLabel.Visible = TemDataFimINSSAntigoCheckBox.Checked

        ' Controle de visibilidade dos DateTimePickers de INSS Novo
        DataParcelINSSnovoDateTimePicker.Visible = TemDataEntradaINSSNovoCheckBox.Checked
        FinalizadoINSSNovoDateTimePicker.Visible = TemDataFimINSSNovoCheckBox.Checked
        MesEnviadoINSSNovoDateTimePicker.Visible = TemDataEnvioINSSNovoCheckBox.Checked
        'Motivo 
        MotivoParcINSSNovoRichTextBox.Visible = TemDataFimINSSNovoCheckBox.Checked
        MotivoParcINSSNovoLabel.Visible = TemDataFimINSSNovoCheckBox.Checked

        ' Controle de visibilidade dos DateTimePickers de INSS Procuração
        DataParcelINSSprocDateTimePicker.Visible = TemDataEntradaINSSProcuCheckBox.Checked
        FinalizadoINSSProcDateTimePicker.Visible = TemDataFimINSSProcurCheckBox.Checked
        MesEnviadoINSSProcDateTimePicker.Visible = TemDataEnvioINSSProcurCheckBox.Checked
        'Motivo 
        MotivoParcINSSProcRichTextBox.Visible = TemDataFimINSSProcurCheckBox.Checked
        MotivoParcINSSProcLabel.Visible = TemDataFimINSSProcurCheckBox.Checked
    End Sub

    Private Sub TemDataEntradaMEICheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEntradaMEICheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataFimMEICheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataFimMEICheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEnvioMEICheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEnvioMEICheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEntradaINSSAntigoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEntradaINSSAntigoCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataFimINSSAntigoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataFimINSSAntigoCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEnvioINSSAntigoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEnvioINSSAntigoCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEntradaINSSNovoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEntradaINSSNovoCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataFimINSSNovoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataFimINSSNovoCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEnvioINSSNovoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEnvioINSSNovoCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEntradaINSSProcuCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEntradaINSSProcuCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataFimINSSProcurCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataFimINSSProcurCheckBox.CheckedChanged
        AtualizarDateTimePickers()
    End Sub

    Private Sub TemDataEnvioINSSProcurCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TemDataEnvioINSSProcurCheckBox.CheckedChanged
        AtualizarDateTimePickers()
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
    '///////////////////////////  BARRA DE PROGRESSO ///////////////////////////////////
    ' Variável para o temporizador do Label e controle de cor
    Private WithEvents timerLabelSalvando As New Timer()
    Private isLabelYellow As Boolean = True ' Alterna entre amarelo e vermelho

    Private Sub IniciarIndicadorSalvamento()
        ' Exibe o GroupBox, Label e ProgressBar
        GroupBoxSalvando.Visible = True
        LabelSalvando.Text = "Aguarde, Salvando..."
        LabelSalvando.ForeColor = Color.Yellow
        LabelSalvando.Visible = True

        ProgressBarSalvando.Visible = True
        ProgressBarSalvando.Value = 0
        ProgressBarSalvando.Style = ProgressBarStyle.Continuous
        ProgressBarSalvando.Maximum = 100

        ' Inicia o temporizador para piscar o Label
        timerLabelSalvando.Interval = 500
        timerLabelSalvando.Start()

        ' Garante a atualização da interface antes de iniciar o salvamento
        Application.DoEvents()
    End Sub

    Private Sub PararIndicadorSalvamento()
        ' Para o temporizador e altera o texto para "Finalizado!"
        timerLabelSalvando.Stop()
        LabelSalvando.Text = "Finalizado!"
        LabelSalvando.ForeColor = Color.Green

        ' Aguardar um pouco para mostrar o "Finalizado!"
        Threading.Thread.Sleep(1000)
        Application.DoEvents()

        ' Oculta o GroupBox após uma pausa
        GroupBoxSalvando.Visible = False
    End Sub

    Private Sub timerLabelSalvando_Tick(sender As Object, e As EventArgs) Handles timerLabelSalvando.Tick
        ' Alterna a cor do Label entre amarelo e vermelho
        If isLabelYellow Then
            LabelSalvando.ForeColor = Color.Red
        Else
            LabelSalvando.ForeColor = Color.Yellow
        End If
        isLabelYellow = Not isLabelYellow
    End Sub

    ' Método de atualização da ProgressBar
    Private Sub AtualizarProgressoSalvamento(progresso As Integer)
        If progresso >= 0 AndAlso progresso <= ProgressBarSalvando.Maximum Then
            ProgressBarSalvando.Value = progresso
            Application.DoEvents()
        End If
    End Sub

    '//////////////////////// BOTAO REGISTRO


    Private Sub RegistrarEnvioMEI()
        If MEICheckBox.Checked Then
            If String.IsNullOrWhiteSpace(ParcelaEnviadaMEITextBox.Text) OrElse String.IsNullOrWhiteSpace(QtoParcelasMEITextBox.Text) Then
                MessageBox.Show("Os campos 'Parcela Enviada' e 'Quantidade de Parcelas' são obrigatórios para o MEI.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            TabControlPrincipal.SelectTab(2)
            TabControleParcelamentos.SelectTab(TabPageMEI)
            TabControlMEI.SelectTab(1)

            Dim dataEnvio = MesEnviadoMEIDateTimePicker.Value
            Dim parcelaEnviada = CInt(ParcelaEnviadaMEITextBox.Text)
            Dim qtoParcelas = CInt(QtoParcelasMEITextBox.Text)
            Dim MeioDeEnvio = CInt(FormaEnvioComboBox.Text)

            Dim mensagemHistorico = $"{dataEnvio:dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm} - Foi enviado, por: {MeioDeEnvio}, a Parcela nº: {parcelaEnviada} de {qtoParcelas} parcelas do parcelamento MEI."
            TabControlMEI.SelectTab(1) ' Aba de histórico
            TabControlPrincipal.SelectTab(0)
            HistoricoEnvioMEIRichTextBox.AppendText(mensagemHistorico & Environment.NewLine)
        End If
    End Sub

    Private Sub RegistrarEnvioINSSAntigo()
        If INSSAntigoCheckBox.Checked Then
            If String.IsNullOrWhiteSpace(ParcelaEnviadaINSSAntigoTextBox.Text) OrElse String.IsNullOrWhiteSpace(QtoParcelasINSSAntigoTextBox.Text) Then
                MessageBox.Show("Os campos 'Parcela Enviada' e 'Quantidade de Parcelas' são obrigatórios para o INSS Antigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            TabControlPrincipal.SelectTab(2)
            TabControleParcelamentos.SelectTab(TabPageINSSAntigo)
            TabControlInssAntigo.SelectTab(1)

            Dim dataEnvio = MesEnviadoINSSAntigoDateTimePicker.Value
            Dim parcelaEnviada = CInt(ParcelaEnviadaINSSAntigoTextBox.Text)
            Dim qtoParcelas = CInt(QtoParcelasINSSAntigoTextBox.Text)
            Dim MeioDeEnvio = CInt(FormaEnvioComboBox.Text)

            Dim mensagemHistorico = $"{dataEnvio:dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm} - Foi enviado, por: {MeioDeEnvio}, a Parcela nº: {parcelaEnviada} de {qtoParcelas} parcelas do parcelamento INSS Antigo."
            TabControlInssAntigo.SelectTab(1) ' Aba de histórico
            TabControlPrincipal.SelectTab(0)
            HistoricoEnvioINSSAntigoRichTextBox.AppendText(mensagemHistorico & Environment.NewLine)
        End If
    End Sub

    Private Sub RegistrarEnvioINSSNovo()
        If INSSNovoCheckBox.Checked Then
            If String.IsNullOrWhiteSpace(ParcelaEnviadaINSSNovoTextBox.Text) OrElse String.IsNullOrWhiteSpace(QtoParcelasINSSNovoTextBox.Text) Then
                MessageBox.Show("Os campos 'Parcela Enviada' e 'Quantidade de Parcelas' são obrigatórios para o INSS Novo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            TabControlPrincipal.SelectTab(2)
            TabControleParcelamentos.SelectTab(TabPageINSSNovo)
            TabControlInssNovo.SelectTab(1)

            Dim dataEnvio = MesEnviadoINSSNovoDateTimePicker.Value
            Dim parcelaEnviada = CInt(ParcelaEnviadaINSSNovoTextBox.Text)
            Dim qtoParcelas = CInt(QtoParcelasINSSNovoTextBox.Text)
            Dim MeioDeEnvio = CInt(FormaEnvioComboBox.Text)

            Dim mensagemHistorico = $"{dataEnvio:dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm} - Foi enviado, por: {MeioDeEnvio}, a Parcela nº: {parcelaEnviada} de {qtoParcelas} parcelas do parcelamento INSS Novo."
            TabControlInssNovo.SelectTab(1) ' Aba de histórico
            TabControlPrincipal.SelectTab(0)
            HistoricoEnvioINSSNovoRichTextBox.AppendText(mensagemHistorico & Environment.NewLine)
        End If
    End Sub

    Private Sub RegistrarEnvioINSSProcuradoria()
        If INSSProcuradoriaCheckBox.Checked Then
            If String.IsNullOrWhiteSpace(ParcelaEnviadaINSSProcuradoriaTextBox.Text) OrElse String.IsNullOrWhiteSpace(QtoParcelasINSSProcuradoriaTextBox.Text) Then
                MessageBox.Show("Os campos 'Parcela Enviada' e 'Quantidade de Parcelas' são obrigatórios para o INSS Procuradoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            TabControlPrincipal.SelectTab(2)
            TabControleParcelamentos.SelectTab(TabPageINSSProcuradoria)
            TabControlInssProcuradoria.SelectTab(1)

            Dim dataEnvio = MesEnviadoINSSProcDateTimePicker.Value
            Dim parcelaEnviada = CInt(ParcelaEnviadaINSSProcuradoriaTextBox.Text)
            Dim qtoParcelas = CInt(QtoParcelasINSSProcuradoriaTextBox.Text)
            Dim MeioDeEnvio = CInt(FormaEnvioComboBox.Text)

            Dim mensagemHistorico = $"{dataEnvio:dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm} - Foi enviado, por: {MeioDeEnvio}, a Parcela nº: {parcelaEnviada} de {qtoParcelas} parcelas do parcelamento INSS Procuradoria."
            TabControlInssProcuradoria.SelectTab(1) ' Aba de histórico
            TabControlPrincipal.SelectTab(0)
            HistoricoEnvioINSSProcRichTextBox.AppendText(mensagemHistorico & Environment.NewLine)
        End If
    End Sub



    Private Sub BtnRegistrarEnvioMEI_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioMEI.Click
        RegistrarEnvioMEI()
    End Sub

    Private Sub BtnRegistrarEnvioINSSantigo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioINSSantigo.Click
        RegistrarEnvioINSSAntigo()
    End Sub

    Private Sub BtnRegistrarEnvioINSSnovo_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioINSSnovo.Click
        RegistrarEnvioINSSNovo()
    End Sub

    Private Sub BtnRegistrarEnvioINSSProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEnvioINSSProcuradoria.Click
        RegistrarEnvioINSSProcuradoria()
    End Sub


    '////////////////////////////////// BOTAO VER DETALHES ///////////////////////////////
    Private Sub BtnVerDetalhesMEI_Click(sender As Object, e As EventArgs) Handles BtnVerDetalhesMEI.Click
        ' Garante que o TabControl principal esteja na aba MEI
        TabControlPrincipal.SelectedTab = TabPageMEIGeral

        ' Muda o TabControl interno para a aba Observacoes
        TabControlMEI.SelectedTab = TabPageMEIObservacoes
    End Sub

    Private Sub BtnVerDetalhesINSSAntigo_Click(sender As Object, e As EventArgs) Handles BtnVerDetalhesINSSAntigo.Click
        ' Garante que o TabControl principal esteja na aba MEI
        TabControlPrincipal.SelectedTab = TabPageINSSAntigoGeral

        ' Muda o TabControl interno para a aba Observacoes
        TabControlInssAntigo.SelectedTab = TabPageINSSAntigoObservacoes
    End Sub

    Private Sub BtnVerDetalhesINSSNovo_Click(sender As Object, e As EventArgs) Handles BtnVerDetalhesINSSNovo.Click
        ' Garante que o TabControl principal esteja na aba MEI
        TabControlPrincipal.SelectedTab = TabPageINSSNovoGeral

        ' Muda o TabControl interno para a aba Observacoes
        TabControlInssNovo.SelectedTab = TabPageINSSNovoObservacoes
    End Sub

    Private Sub BtnVerDetalhesINSSProcuradoria_Click(sender As Object, e As EventArgs) Handles BtnVerDetalhesINSSProcuradoria.Click
        ' Garante que o TabControl principal esteja na aba MEI
        TabControlPrincipal.SelectedTab = TabPageINSSProcuradoriaGeral

        ' Muda o TabControl interno para a aba Observacoes
        TabControlInssNovo.SelectedTab = TabPageINSSProcuradoriaObservacoes
    End Sub
    '//////////////////////////////////////////////////
    Private Sub HistoricoEnvioMEIRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles HistoricoEnvioMEIRichTextBox.MouseDoubleClick
        If HistoricoEnvioMEIRichTextBox.ReadOnly = True Then
            HistoricoEnvioMEIRichTextBox.ReadOnly = False
        Else
            HistoricoEnvioMEIRichTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub HistoricoEnvioINSSAntigoRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles HistoricoEnvioINSSAntigoRichTextBox.MouseDoubleClick
        If HistoricoEnvioINSSAntigoRichTextBox.ReadOnly = True Then
            HistoricoEnvioINSSAntigoRichTextBox.ReadOnly = False
        Else
            HistoricoEnvioINSSAntigoRichTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub HistoricoEnvioINSSNovoRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles HistoricoEnvioINSSNovoRichTextBox.MouseDoubleClick
        If HistoricoEnvioINSSNovoRichTextBox.ReadOnly = True Then
            HistoricoEnvioINSSNovoRichTextBox.ReadOnly = False
        Else
            HistoricoEnvioINSSNovoRichTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub HistoricoEnvioINSSProcRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles HistoricoEnvioINSSProcRichTextBox.MouseDoubleClick
        If HistoricoEnvioINSSProcRichTextBox.ReadOnly = True Then
            HistoricoEnvioINSSProcRichTextBox.ReadOnly = False
        Else
            HistoricoEnvioINSSProcRichTextBox.ReadOnly = True
        End If
    End Sub
End Class