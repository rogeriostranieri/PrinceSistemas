Public Class FrmEventos
    'ao apertar ESC fechar
    Private Sub FrmEventos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub FrmEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.EventosEmpresa'. Você pode movê-la ou removê-la conforme necessário.
        Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)

        Me.EventosEmpresaDataGridView.DataSource = Nothing
        Label2.Visible = False
        TextBox1.Visible = False

        'aumentar a fonte da letra para 11 no data gridview
        EventosEmpresaDataGridView.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
    End Sub

    '////////////////////////////////// CHECK BOX //////////////////////////////
    Private Sub EmpresaFacil_CheckedChanged(sender As Object, e As EventArgs) Handles EmpresaFacil.CheckedChanged
        'deixar apenas Este marcado e desmarcar os outros ReceitaFederal, ReceitaEstadual, PrefeituraMunicipal
        If EmpresaFacil.Checked = True Then
            ReceitaFederal.Checked = False
            ReceitaEstadual.Checked = False
            PrefeituraMunicipal.Checked = False
        End If

        'se estiver marcado, mostrar filtro e desmarca as outras opçções
        If EmpresaFacil.Checked = True Then
            TextBox1.Clear()
            If Label2.Visible = False Then
                Label2.Visible = True
            Else
                Label2.Visible = True
            End If
            If TextBox1.Visible = False Then
                TextBox1.Visible = True
            Else
                TextBox1.Visible = True
            End If

            Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
            Me.EventosEmpresaBindingSource.Filter = "EmpresaFacil = 'Checked'"
            Me.EventosEmpresaDataGridView.Refresh()
            ReceitaFederal.Checked = False
            ReceitaEstadual.Checked = False
            PrefeituraMunicipal.Checked = False
            'se nao limpar 
        Else
            Label2.Visible = False
            TextBox1.Visible = False
            'DataGridView vazio
            Me.EventosEmpresaBindingSource.Filter = ""
            Me.EventosEmpresaDataGridView.Refresh()
            'tirar tudo de dentro do DataGridView
            Me.EventosEmpresaDataGridView.DataSource = Nothing
        End If

    End Sub

    Private Sub ReceitaFederal_CheckedChanged(sender As Object, e As EventArgs) Handles ReceitaFederal.CheckedChanged
        If ReceitaFederal.Checked = True Then
            EmpresaFacil.Checked = False
            ReceitaEstadual.Checked = False
            PrefeituraMunicipal.Checked = False
        End If

        'se estiver marcado, mostrar filtro e desmarca as outras opçções
        If ReceitaFederal.Checked = True Then
            TextBox1.Clear()
            If Label2.Visible = False Then
                Label2.Visible = True
            Else
                Label2.Visible = True
            End If
            If TextBox1.Visible = False Then
                TextBox1.Visible = True
            Else
                TextBox1.Visible = True
            End If

            Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
            Me.EventosEmpresaBindingSource.Filter = "ReceitaFederal = 'Checked'"
            Me.EventosEmpresaDataGridView.Refresh()
            EmpresaFacil.Checked = False
            ReceitaEstadual.Checked = False
            PrefeituraMunicipal.Checked = False
            'se nao limpar 
        Else
            Label2.Visible = False
            TextBox1.Visible = False
            'DataGridView vazio
            Me.EventosEmpresaBindingSource.Filter = ""
            Me.EventosEmpresaDataGridView.Refresh()
            'tirar tudo de dentro do DataGridView
            Me.EventosEmpresaDataGridView.DataSource = Nothing
        End If
    End Sub

    Private Sub ReceitaEstadual_CheckedChanged(sender As Object, e As EventArgs) Handles ReceitaEstadual.CheckedChanged
        If ReceitaEstadual.Checked = True Then
            EmpresaFacil.Checked = False
            ReceitaFederal.Checked = False
            PrefeituraMunicipal.Checked = False
        End If
        'se estiver marcado, mostrar filtro e desmarca as outras opçções
        If ReceitaEstadual.Checked = True Then
            TextBox1.Clear()
            If Label2.Visible = False Then
                Label2.Visible = True
            Else
                Label2.Visible = True
            End If
            If TextBox1.Visible = False Then
                TextBox1.Visible = True
            Else
                TextBox1.Visible = True
            End If

            Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
            Me.EventosEmpresaBindingSource.Filter = "ReceitaEstadual = 'Checked'"
            Me.EventosEmpresaDataGridView.Refresh()
            EmpresaFacil.Checked = False
            ReceitaFederal.Checked = False
            PrefeituraMunicipal.Checked = False
            'se nao limpar 
        Else
            Label2.Visible = False
            TextBox1.Visible = False
            'DataGridView vazio
            Me.EventosEmpresaBindingSource.Filter = ""
            Me.EventosEmpresaDataGridView.Refresh()
            'tirar tudo de dentro do DataGridView
            Me.EventosEmpresaDataGridView.DataSource = Nothing
        End If
    End Sub

    Private Sub PrefeituraMunicipal_CheckedChanged(sender As Object, e As EventArgs) Handles PrefeituraMunicipal.CheckedChanged
        If PrefeituraMunicipal.Checked = True Then
            EmpresaFacil.Checked = False
            ReceitaFederal.Checked = False
            ReceitaEstadual.Checked = False
        End If
        'se estiver marcado, mostrar filtro e desmarca as outras opçções
        If PrefeituraMunicipal.Checked = True Then
            TextBox1.Clear()
            If Label2.Visible = False Then
                Label2.Visible = True
            Else
                Label2.Visible = True
            End If
            If TextBox1.Visible = False Then
                TextBox1.Visible = True
            Else
                TextBox1.Visible = True
            End If

            Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
            Me.EventosEmpresaBindingSource.Filter = "PrefeituraMunicipal = 'Checked'"
            Me.EventosEmpresaDataGridView.Refresh()
            EmpresaFacil.Checked = False
            ReceitaFederal.Checked = False
            ReceitaEstadual.Checked = False
            'se nao limpar 
        Else
            Label2.Visible = False
            TextBox1.Visible = False
            'DataGridView vazio
            Me.EventosEmpresaBindingSource.Filter = ""
            Me.EventosEmpresaDataGridView.Refresh()
            'tirar tudo de dentro do DataGridView
            Me.EventosEmpresaDataGridView.DataSource = Nothing
        End If
    End Sub

    '//////////////////////////////////// FIM CHECK BOX //////////////////////////




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'carrega dados
        'buscar dentro do gridview o texto digitado mas observando quem esta marcado chekbox
        If EmpresaFacil.Checked = True Then
            Me.EventosEmpresaBindingSource.Filter = "EmpresaFacil = 'Checked' AND Eventos LIKE '%" & TextBox1.Text & "%'"
            Me.EventosEmpresaDataGridView.Refresh()
        ElseIf ReceitaFederal.Checked = True Then
            Me.EventosEmpresaBindingSource.Filter = "ReceitaFederal = 'Checked' AND Eventos LIKE '%" & TextBox1.Text & "%'"
            Me.EventosEmpresaDataGridView.Refresh()
        ElseIf ReceitaEstadual.Checked = True Then
            Me.EventosEmpresaBindingSource.Filter = "ReceitaEstadual = 'Checked' AND Eventos LIKE '%" & TextBox1.Text & "%'"
            Me.EventosEmpresaDataGridView.Refresh()
        ElseIf PrefeituraMunicipal.Checked = True Then
            Me.EventosEmpresaBindingSource.Filter = "PrefeituraMunicipal = 'Checked' AND Eventos LIKE '%" & TextBox1.Text & "%'"
            Me.EventosEmpresaDataGridView.Refresh()
            'se nao desfazer filtro
        End If

    End Sub

    Private Sub EventosEmpresaDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventosEmpresaDataGridView.CellContentDoubleClick
        'ao clicar adicionar o Evento dentro do FrmLegalizacao.MotivoRichTextBox,
        'verificar antes se tem texto no FrmLegalizacao.MotivoRichTextBox e adicionar na proxima linha
        If FrmLegalizacao.MotivoRichTextBox.Text = "" Then
            FrmLegalizacao.MotivoRichTextBox.Text = EventosEmpresaDataGridView.CurrentRow.Cells(0).Value
        Else
            FrmLegalizacao.MotivoRichTextBox.Text = FrmLegalizacao.MotivoRichTextBox.Text & vbCrLf & EventosEmpresaDataGridView.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub BtnLimparEventos_Click(sender As Object, e As EventArgs) Handles BtnLimparEventos.Click
        'perguntar se deseja FrmLegalizacao.MotivoRichTextBox.Clear()
        Dim RazaoSocial As String = FrmLegalizacao.RazaoSocialTextBox.Text
        If MessageBox.Show("Deseja limpar todos os eventos adicionados na empresa " & RazaoSocial & "?", "Limpar Eventos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            FrmLegalizacao.MotivoRichTextBox.Clear()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Application.OpenForms.OfType(Of FrmControleEventosEmpresa)().Count() > 0 Then
            FrmControleEventosEmpresa.Focus()
            FrmControleEventosEmpresa.Close()
            FrmControleEventosEmpresa.Show()
        Else
            FrmControleEventosEmpresa.Show()
        End If
    End Sub
End Class