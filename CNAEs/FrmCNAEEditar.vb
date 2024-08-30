Public Class FrmCNAEEditar

    Private isEditing As Boolean = False
    Private originalValues As DataRowView

    Private Sub FrmCNAEEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Carregar dados na tabela 'PrinceDBDataSet.CNAEprefMaringaPR'.
        Me.CNAEprefMaringaPRTableAdapter.Fill(Me.PrinceDBDataSet.CNAEprefMaringaPR)
        ' Desabilitar campos ao carregar o formulário
        ToggleFields(False)
        BtnEditar.Text = "Editar"
    End Sub

    Private Sub BtnCadastro_Click(sender As Object, e As EventArgs) Handles BtnCadastro.Click
        ' Habilitar campos para adicionar um novo registro
        ToggleFields(True)
        isEditing = True
        ' Limpar campos
        CNAEMaskedTextBox.Clear()
        DescricaoRichTextBox.Clear()
        GrauDeRiscoTextBox.Clear()
        CondicionanteRichTextBox.Clear()
        GrauRiscoDesenqTextBox.Clear()
        CNAEMaskedTextBox.Focus()
        BtnEditar.Text = "Cancelar"
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Not isEditing Then
            ' Modo de edição
            If CNAEprefMaringaPRBindingSource.Current IsNot Nothing Then
                ' Armazenar valores originais
                originalValues = CType(CNAEprefMaringaPRBindingSource.Current, DataRowView)
                ToggleFields(True)
                isEditing = True
                BtnEditar.Text = "Cancelar"
            End If
        Else
            ' Cancelar edição
            Dim result As DialogResult = MessageBox.Show("Você deseja cancelar as alterações? As alterações não salvas serão descartadas.", "Cancelar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Reverter os valores originais
                If originalValues IsNot Nothing Then
                    CNAEprefMaringaPRBindingSource.CancelEdit()
                    Me.CNAEprefMaringaPRTableAdapter.Fill(Me.PrinceDBDataSet.CNAEprefMaringaPR)
                End If
                ToggleFields(False)
                isEditing = False
                BtnEditar.Text = "Editar"
            End If
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If isEditing Then
            Dim result As DialogResult = MessageBox.Show("Você deseja salvar as alterações?", "Salvar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    ' Salvar as alterações
                    Me.Validate()
                    If CNAEprefMaringaPRBindingSource.Current Is Nothing Then
                        ' Adicionar novo registro
                        Me.CNAEprefMaringaPRBindingSource.AddNew()
                    End If
                    ' Atualizar os campos com dados do formulário
                    Dim row As DataRowView = CType(Me.CNAEprefMaringaPRBindingSource.Current, DataRowView)
                    row("CNAE") = CNAEMaskedTextBox.Text
                    row("Descrição da Atividade Econômica") = DescricaoRichTextBox.Text
                    row("Grau de Risco") = GrauDeRiscoTextBox.Text
                    row("Condicionante para baixo Risco") = CondicionanteRichTextBox.Text
                    row("Grau de Risco em caso de desenquadramento do baixo risco") = GrauRiscoDesenqTextBox.Text
                    Me.CNAEprefMaringaPRBindingSource.EndEdit()
                    Me.CNAEprefMaringaPRTableAdapter.Update(Me.PrinceDBDataSet.CNAEprefMaringaPR)
                    MessageBox.Show("Registro salvo com sucesso.", "Salvar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ToggleFields(False)
                    isEditing = False
                    BtnEditar.Text = "Editar"
                Catch ex As Exception
                    MessageBox.Show("Erro ao salvar o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Dim result As DialogResult = MessageBox.Show("Você deseja excluir o registro selecionado?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                ' Excluir o registro selecionado
                Me.CNAEprefMaringaPRBindingSource.RemoveCurrent()
                Me.CNAEprefMaringaPRBindingSource.EndEdit()
                Me.CNAEprefMaringaPRTableAdapter.Update(Me.PrinceDBDataSet.CNAEprefMaringaPR)
                MessageBox.Show("Registro excluído com sucesso.", "Excluir Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ToggleFields(False)
                isEditing = False
                BtnEditar.Text = "Editar"
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Dim result As DialogResult = MessageBox.Show("Você deseja fechar o formulário? As alterações não salvas serão descartadas.", "Fechar Formulário", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ToggleFields(enable As Boolean)
        ' Habilitar ou desabilitar campos
        CNAEMaskedTextBox.Enabled = enable
        DescricaoRichTextBox.Enabled = enable
        GrauDeRiscoTextBox.Enabled = enable
        CondicionanteRichTextBox.Enabled = enable
        GrauRiscoDesenqTextBox.Enabled = enable
        BtnSalvar.Enabled = enable
        BtnExcluir.Enabled = enable
    End Sub

    Private Sub FrmCNAE_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla ESC foi pressionada
        If e.KeyCode = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
        End If
    End Sub

End Class
