Public Class FrmSocios
    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Socios'. Você pode movê-la ou removê-la conforme necessário.
        Me.SociosTableAdapter.Fill(Me.PrinceDBDataSet.Socios)
        BloquearEdicao()

        'coloca CivilComboBox para selecionar comunhão parcial de bens
        CivilComboBox.Items.Add("solteiro")
        CivilComboBox.Items.Add("comunhão parcial de bens")
        CivilComboBox.Items.Add("comunhão universal de bens")
        CivilComboBox.Items.Add("separação convencional de bens")
        CivilComboBox.Items.Add("separação obrigatória de bens")
        CivilComboBox.Items.Add("participação final nos aquestos")

        GeneroComboBox.Items.Add("Masculino")
        GeneroComboBox.Items.Add("Feminino")

    End Sub

    Private Sub BloquearEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = False
        GroupBoxOutrosDados.Enabled = False
    End Sub

    Private Sub LiberarEdicao()
        'bloquear ediçao GroupBoxDadosPessoais
        GroupBoxDadosPessoais.Enabled = True
        GroupBoxOutrosDados.Enabled = True
    End Sub

    Private Sub EstadoCivil()
        'limpar CivilComboBox
        CivilComboBox.Items.Clear()

        If GeneroComboBox.Text = "Masculino" Then
            CivilComboBox.Items.Add("solteiro")
            CivilComboBox.Items.Add("comunhão parcial de bens")
            CivilComboBox.Items.Add("comunhão universal de bens")
            CivilComboBox.Items.Add("separação convencional de bens")
            CivilComboBox.Items.Add("separação obrigatória de bens")
            CivilComboBox.Items.Add("participação final nos aquestos")
        ElseIf GeneroComboBox.Text = "Feminino" Then
            CivilComboBox.Items.Add("solteira")
            CivilComboBox.Items.Add("comunhão parcial de bens")
            CivilComboBox.Items.Add("comunhão universal de bens")
            CivilComboBox.Items.Add("separação convencional de bens")
            CivilComboBox.Items.Add("separação obrigatória de bens")
            CivilComboBox.Items.Add("participação final nos aquestos")
        Else
            CivilComboBox.Items.Add("solteiro")
            CivilComboBox.Items.Add("comunhão parcial de bens")
            CivilComboBox.Items.Add("comunhão universal de bens")
            CivilComboBox.Items.Add("separação convencional de bens")
            CivilComboBox.Items.Add("separação obrigatória de bens")
            CivilComboBox.Items.Add("participação final nos aquestos")
        End If

    End Sub
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        'pergunta, adiciona novo registro
        If MessageBox.Show("Deseja adicionar um novo registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'new register
            SociosBindingSource.AddNew()
            LiberarEdicao()


            'selecionar  index 0 GeneroComboBox e CivilComboBox
            GeneroComboBox.SelectedIndex = 0
            CivilComboBox.SelectedIndex = 0

        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'perguntar, editar ou não
        If MessageBox.Show("Deseja editar o registro?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LiberarEdicao()
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'perguntar, salvar dados
        If MsgBox("Deseja salvar os dados?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'salvar dados
            Me.Validate()
            Me.SociosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            BloquearEdicao()
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'cancelar ediçao
        If MsgBox("Deseja cancelar a edição?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'cancelar ediçao
            Me.SociosBindingSource.CancelEdit()
            BloquearEdicao()
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'perguntar, e excluir dados
        If MsgBox("Deseja excluir os dados?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            'excluir dados
            Me.SociosBindingSource.RemoveCurrent()
            Me.Validate()
            Me.SociosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            BloquearEdicao()
        End If
    End Sub

    'ao digitar no CPFComboBox mudar para formato CPF
    Private Sub CPFComboBox_TextChanged(sender As Object, e As EventArgs) Handles CPFComboBox.TextChanged
        'ao digitar converter para cpf
        CPFComboBox.Text = Format(CPFComboBox.Text, "000\.000\.000\-00")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnCorreios_Click(sender As Object, e As EventArgs) Handles BtnCorreios.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                'Using WS = New WSCorreios.AtendeClienteClient()
                Dim Resultado = WS.consultaCEP(CEPMaskedTextBox.Text)
                RUATextBox.Text = Resultado.[end]
                'EndComplementoTextBox.Text = Resultado.complemento
                ComplementoTextBox.Text = Resultado.complemento2
                CidadeTextBox.Text = Resultado.cidade
                BairroTextBox.Text = Resultado.bairro
                EstadoTextBox.Text = Resultado.uf
                ' mgs de erro

            Catch Ex As Exception
                ' MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])

                If MsgBox(" Deseja Buscar CEP correto no site dos correios?", MsgBoxStyle.YesNo, "Busca CEP") = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start("https://buscacepinter.correios.com.br/app/endereco/index.php")
                Else

                End If
            End Try

        End Using
    End Sub

    Private Sub GeneroComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GeneroComboBox.SelectedIndexChanged
        'ao selecionar feminino mudar o nome solteiro para solteira do  CivilComboBox 
        EstadoCivil()
    End Sub

    Private Sub CivilComboBox_Click(sender As Object, e As EventArgs) Handles CivilComboBox.Click
        'verifica se esta no Feminino e mudar para solteira do  CivilComboBox da lista
        EstadoCivil()
    End Sub
End Class