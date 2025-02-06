Imports System.Windows.Forms

Public Class AlertaCentral

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ' Me.Close()
        SalvarAvisos()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AvisosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AvisosBindingNavigatorSaveItem.Click
        SalvarAvisos()

    End Sub

    Private Function SalvarAlteracoes() As Boolean
        ' Força a aplicação das alterações ao DataSet
        Me.AvisosBindingSource.EndEdit()

        ' Verifica se há alterações pendentes no DataSet
        If Me.PrinceDBDataSet.HasChanges() Then
            ' Pergunta ao usuário se deseja salvar as alterações
            Dim resultado As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Salvar Alterações", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            Select Case resultado
                Case DialogResult.Yes
                    Try
                        ' Valida e finaliza a edição no BindingSource
                        Me.Validate()
                        Me.AvisosBindingSource.EndEdit()

                        ' Salva as alterações no banco de dados
                        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

                        ' Exibe mensagem de sucesso
                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True ' Indica que as alterações foram salvas com sucesso

                    Catch ex As Exception
                        ' Exibe mensagem de erro
                        MessageBox.Show("Erro ao salvar os dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False ' Indica que ocorreu um erro ao salvar
                    End Try

                Case DialogResult.No
                    Return True ' Indica que o usuário optou por não salvar, mas o processo pode continuar

                Case DialogResult.Cancel
                    Return False ' Indica que o usuário cancelou a operação
            End Select
        Else
            ' Se não houver alterações, retorna True indicando que está tudo certo
            Return True ' Indica que não há alterações pendentes
        End If

        ' Retorno de segurança para cobrir todos os caminhos de código
        Return False
    End Function


    Private Sub AlertaCentral_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Chama a função para salvar alterações
        Dim salvouComSucesso As Boolean = SalvarAlteracoes()

        ' Se o usuário cancelou ou ocorreu um erro, cancela o fechamento do formulário
        If Not salvouComSucesso Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SalvarAvisos()
        ' Chama a função para salvar alterações
        Dim salvouComSucesso As Boolean = SalvarAlteracoes()

        ' Se as alterações foram salvas com sucesso, pergunta se o usuário deseja fechar o formulário
        If salvouComSucesso Then
            Dim fecharFormulario As DialogResult = MessageBox.Show("Deseja fechar o formulário?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If fecharFormulario = DialogResult.Yes Then
                Me.Close() ' Fecha o formulário
            End If
        End If
    End Sub



    Private Sub AlertaCentral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Avisos'. Você pode movê-la ou removê-la conforme necessário.
        Me.AvisosTableAdapter.Fill(Me.PrinceDBDataSet.Avisos)
        AtualizarContador()
    End Sub
    Private Sub AtualizarContador()
        Dim totalCaracteres As Integer = TextoAvisoRichTextBox.TextLength
        Dim totalLinhas As Integer = TextoAvisoRichTextBox.Lines.Length
        Dim totalParagrafos As Integer = TextoAvisoRichTextBox.Text.Split({Environment.NewLine + Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).Length

        LblContadorTexto.Text = $"Caracteres: {totalCaracteres} | Linhas: {totalLinhas} | Parágrafos: {totalParagrafos}"
    End Sub

    Private Sub TextoAvisoRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles TextoAvisoRichTextBox.TextChanged
        AtualizarContador()
    End Sub


    Private Sub BtnEmpresas_Click(sender As Object, e As EventArgs) Handles BtnEmpresas.Click
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            FrmLegalizacao.Focus()
            FrmLegalizacao.Close()
            '  FrmLegalizacao.MdiParent = MDIPrincipal
            FrmLegalizacao.Show()
            FrmLegalizacao.BtnEditar.PerformClick()
        Else
            ' FrmLegalizacao.MdiParent = MDIPrincipal
            FrmLegalizacao.Show()
            FrmLegalizacao.BtnEditar.PerformClick()
        End If
    End Sub

    Private Sub BtnLaudos_Click(sender As Object, e As EventArgs) Handles BtnLaudos.Click
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            FrmAlvara.Focus()
            FrmAlvara.Close()
            ' FrmAlvara.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.BtnEditar.PerformClick()
        Else
            ' FrmAlvara.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.BtnEditar.PerformClick()

        End If
    End Sub

    Private Sub BtnSocios_Click(sender As Object, e As EventArgs) Handles BtnSocios.Click
        If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
            FrmSocios.Focus()
            FrmSocios.Close()
            'FrmSocios.MdiParent = MDIPrincipal
            FrmSocios.Show()
        Else
            ' FrmSocios.MdiParent = MDIPrincipal
            FrmSocios.Show()
        End If
    End Sub

    Private Sub BtnParcelamentos_Click(sender As Object, e As EventArgs) Handles BtnParcelamentos.Click
        If Application.OpenForms.OfType(Of FrmParcelamento)().Count() > 0 Then
            FrmParcelamento.Focus()
            FrmParcelamento.Close()
            FrmParcelamento.MdiParent = MDIPrincipal
            FrmParcelamento.Show()
        Else
            FrmParcelamento.MdiParent = MDIPrincipal
            FrmParcelamento.Show()
        End If
    End Sub


End Class
