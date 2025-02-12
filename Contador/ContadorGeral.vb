Public Class ContadorGeral
    Private Sub Salvar()
        ' Finalizar edição e obter registros alterados
        Me.Validate()
        Me.ContadorBindingSource.EndEdit()
        Dim changedRecords As System.Data.DataTable = PrinceDBDataSet.Contador.GetChanges()

        ' Verificar se há alterações para salvar
        If changedRecords IsNot Nothing AndAlso changedRecords.Rows.Count > 0 Then
            ' Criar uma string para armazenar as mudanças
            Dim changesDescription As String = ""

            ' Iterar sobre as linhas alteradas
            For Each row As DataRow In changedRecords.Rows
                changesDescription &= "Alterações na linha com ID: " & row("ID_Contador").ToString() & vbCrLf

                ' Iterar sobre as colunas para identificar as mudanças
                For Each column As DataColumn In changedRecords.Columns
                    If Not row(column, DataRowVersion.Original).Equals(row(column, DataRowVersion.Current)) Then
                        changesDescription &= "  - " & column.ColumnName & ": " & row(column, DataRowVersion.Original).ToString() & " => " & row(column, DataRowVersion.Current).ToString() & vbCrLf
                    End If
                Next
                changesDescription &= vbCrLf
            Next

            ' Perguntar se deseja salvar os dados, exibindo as mudanças detectadas
            If MsgBox("Deseja salvar as alterações?" & vbCrLf & vbCrLf & "Alterações detectadas:" & vbCrLf & changesDescription, MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
                ' Salvar dados
                Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            End If
        Else
            ' Se não houver alterações, informar ao usuário
            MessageBox.Show("Nenhuma alteração foi detectada.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub Contador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Contador'. Você pode movê-la ou removê-la conforme necessário.
        Me.ContadorTableAdapter.Fill(Me.PrinceDBDataSet.Contador)

        'Combobox do toolstrip
        With Me.ComboBoxBusca.ComboBox
            .DisplayMember = "Nome"
            .ValueMember = "ID"
            .DataSource = Me.ContadorBindingSource
        End With


    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(EndCEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                EnderecoTextBox.Text = resultado.logradouro
                If EndCompTextBox.Text = "" Then
                    EndCompTextBox.Text = resultado.complemento
                Else
                    'nao faz nada
                End If
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


    Private Sub Contador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.ContadorBindingSource.AddNew()
        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.ContadorBindingSource.RemoveCurrent()
            Me.ContadorTableAdapter.Update(Me.PrinceDBDataSet.Contador)
            Me.ContadorTableAdapter.Fill(Me.PrinceDBDataSet.Contador)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Salvar()


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Me.Close()

    End Sub

    Private Sub Contador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.ContadorBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.Contador.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

            If MessageBox.Show(message, "Prince Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Try

                    ContadorTableAdapter.Update(PrinceDBDataSet.Contador)


                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



                End Try

            End If

        Else

            ' MessageBox.Show("Não há alterações na tabela para atualizar.", "Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Try
            ' Obter o texto do CPFMaskedTextBox
            Dim CPF As String = CPFMaskedTextBox.Text

            ' Verificar se o campo não está vazio
            If String.IsNullOrWhiteSpace(CPF) Then
                MessageBox.Show("O campo CPF está vazio. Por favor, insira um CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Remover caracteres especiais do CPF (como pontos, hífens, etc.)
            Dim CPFFormatado As String = CPF.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "")

            ' Copiar o CPF formatado para a área de transferência
            Clipboard.SetText(CPFFormatado)

            ' Informar ao usuário que o CPF foi copiado
            ' MessageBox.Show("CPF copiado para a área de transferência.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Exibir mensagem de erro caso algo dê errado
            MessageBox.Show("Erro ao copiar CPF: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ESTADO CIVIL DO CONTADOR

    Private Sub EstadoCivil()
        ' Verificar o gênero selecionado e preencher o EstadoCivilComboBox
        EstadoCivilComboBox.Items.Clear()

        If GeneroComboBox.Text = "Masculino" Then
            EstadoCivilComboBox.Items.Add("solteiro")
            EstadoCivilComboBox.Items.Add("separado")
            EstadoCivilComboBox.Items.Add("divorciado")
            EstadoCivilComboBox.Items.Add("casado em regime de comunhão parcial de bens")
            EstadoCivilComboBox.Items.Add("casado em regime de comunhão universal de bens")
            EstadoCivilComboBox.Items.Add("casado em regime de separação obrigatória de bens")
            EstadoCivilComboBox.Items.Add("casado em regime de participação final nos aquestos")
            EstadoCivilComboBox.Items.Add("viúvo")


        ElseIf GeneroComboBox.Text = "Feminino" Then
            EstadoCivilComboBox.Items.Add("solteira")
            EstadoCivilComboBox.Items.Add("separada")
            EstadoCivilComboBox.Items.Add("divorciada")
            EstadoCivilComboBox.Items.Add("casada em regime de comunhão parcial de bens")
            EstadoCivilComboBox.Items.Add("casada em regime de comunhão universal de bens")
            EstadoCivilComboBox.Items.Add("casada em regime de separação obrigatória de bens")
            EstadoCivilComboBox.Items.Add("casada em regime de participação final nos aquestos")
            EstadoCivilComboBox.Items.Add("viúva")

        Else
            EstadoCivilComboBox.Items.Add("solteiro")
            EstadoCivilComboBox.Items.Add("separado")
            EstadoCivilComboBox.Items.Add("divorciado")
            EstadoCivilComboBox.Items.Add("casado em regime de comunhão parcial de bens")
            EstadoCivilComboBox.Items.Add("casado em regime de comunhão universal de bens")
            EstadoCivilComboBox.Items.Add("casado em regime de separação obrigatória de bens")
            EstadoCivilComboBox.Items.Add("casado em regime de participação final nos aquestos")
            EstadoCivilComboBox.Items.Add("viúvo")

        End If
    End Sub


    Private Sub GeneroComboBox_TextChanged(sender As Object, e As EventArgs) Handles GeneroComboBox.TextChanged
        EstadoCivil()
    End Sub

    Private Sub BtnCopiaCEP_Click(sender As Object, e As EventArgs) Handles BtnCopiaCEP.Click
        Try
            ' Obter o texto do CEPMaskedTextBox
            Dim cep As String = EndCEPMaskedTextBox.Text

            ' Verificar se o CEP não está vazio
            If String.IsNullOrWhiteSpace(cep) Then
                MessageBox.Show("O campo CEP está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Remover o hífen
            Dim cepSemHifen As String = cep.Replace("-", "")

            ' Copiar o resultado para a área de transferência
            Clipboard.SetText(cepSemHifen)

            ' Informar ao usuário que o CEP foi copiado
            '  MessageBox.Show("CEP copiado para a área de transferência: " & cepSemHifen, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro
            MessageBox.Show("Erro ao copiar CEP: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class