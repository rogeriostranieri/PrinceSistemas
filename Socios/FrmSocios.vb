Public Class FrmSocios
    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Socios'. Você pode movê-la ou removê-la conforme necessário.
        Me.SociosTableAdapter.Fill(Me.PrinceDBDataSet.Socios)
        BloquearEdicao()

        'tirar as borda dos groupbox

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

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        'pergunta, adiciona novo registro
        If MessageBox.Show("Deseja adicionar um novo registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'new register
            SociosBindingSource.AddNew()
            LiberarEdicao()
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
End Class