Public Class FrmControleEventosEmpresa
    'evento esc
    Private Sub FrmControleEventosEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Salvar()
        End If
    End Sub


    Private Sub Salvar()

        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.EventosEmpresaBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.EventosEmpresa.GetChanges()


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
                'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
                Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)
            ElseIf result = DialogResult.Yes Then
                Try                    'Salva alterações
                    Me.Validate()
                    Me.EventosEmpresaBindingSource.EndEdit()
                    Me.EventosEmpresaTableAdapter.Update(Me.PrinceDBDataSet.EventosEmpresa)
                Catch exc As Exception
                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        Else
        End If
    End Sub

    'verificar se teve alteração, se tiver ai pergunta se vai salvar
    Private Sub FrmControleEventosEmpresa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Tag = "Alterar" Then
            If MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Tag = "Salvar"
            End If
        End If
    End Sub

    Private Sub FrmControleEventosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.EventosEmpresa'. Você pode movê-la ou removê-la conforme necessário.
        Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.EventosEmpresa'. Você pode movê-la ou removê-la conforme necessário.
        Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)

    End Sub


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        'adicionar novo registro e pergunta antes
        If MessageBox.Show("Deseja adicionar um novo registro?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.EventosEmpresaBindingSource.AddNew()
            'desmarcar todos checkbox
            EmpresaFacil.Checked = False
            ReceitaFederal.Checked = False
            ReceitaEstadual.Checked = False
            PrefeituraMunicipal.Checked = False
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
        'atualizar
        Dim Nome As String = EventosTextBox.Text
        Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)
        'coloca no combobox
        EventosComboBox.Text = Nome
        'select
        EventosComboBox.SelectedValue = Nome
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'pergunta se deseja excluir
        If MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.EventosEmpresaBindingSource.RemoveCurrent()
            Me.Validate()
            Me.EventosEmpresaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
        End If
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub
End Class