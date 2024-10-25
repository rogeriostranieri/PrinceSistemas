Public Class FrmEventos

    Private listaOriginal As List(Of DataRowView)
    Private tabelaOriginal As DataTable


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

        ' Armazena a lista original dos dados
        listaOriginal = Me.EventosEmpresaBindingSource.List.Cast(Of DataRowView)().ToList()
        ' Clona o DataTable do BindingSource para manter a lista original
        tabelaOriginal = CType(Me.PrinceDBDataSet.Tables("EventosEmpresa"), DataTable).Copy()

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
        Organizar()
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
        Organizar()
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
        Organizar()
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
        Organizar()
    End Sub

    '//////////////////////////////////// FIM CHECK BOX //////////////////////////

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Carrega o texto de busca sem acentos
        Dim textoBusca As String = RemoverAcentos(TextBox1.Text).ToLower()

        ' Define o filtro de acordo com as CheckBoxes
        Dim filtroColuna As String = ""
        If EmpresaFacil.Checked Then
            filtroColuna = "EmpresaFacil"
        ElseIf ReceitaFederal.Checked Then
            filtroColuna = "ReceitaFederal"
        ElseIf ReceitaEstadual.Checked Then
            filtroColuna = "ReceitaEstadual"
        ElseIf PrefeituraMunicipal.Checked Then
            filtroColuna = "PrefeituraMunicipal"
        End If

        ' Aplica o filtro somente se uma das CheckBoxes estiver marcada
        If filtroColuna <> "" Then
            ' Cria um filtro para o BindingSource usando o DataTable original
            Dim filtro = $"{filtroColuna} = 'Checked' AND CONVERT(Eventos, 'System.String') LIKE '%{textoBusca}%'"

            ' Atualiza o BindingSource com o filtro
            Me.EventosEmpresaBindingSource.Filter = filtro
        Else
            ' Se nenhuma checkbox estiver marcada, remove o filtro e restaura todos os dados
            Me.EventosEmpresaBindingSource.RemoveFilter()
        End If

        Me.EventosEmpresaDataGridView.Refresh()
        Organizar()
    End Sub

    ' Função para organizar (ordenar) a lista ao aplicar o filtro
    Private Sub Organizar()
        ' Verifique se a coluna com DataPropertyName "Eventos" existe
        Dim colunaEventos = EventosEmpresaDataGridView.Columns.Cast(Of DataGridViewColumn)().FirstOrDefault(Function(c) c.DataPropertyName = "Eventos")

        If colunaEventos IsNot Nothing Then
            ' Ordena automaticamente pela coluna "Eventos" em ordem crescente
            EventosEmpresaDataGridView.Sort(colunaEventos, System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    '///////////////////////////////////////////////


    ' Função para remover acentos
    Private Function RemoverAcentos(texto As String) As String
        Dim caracteresAcentuados As Char() = {"á", "é", "í", "ó", "ú", "ã", "õ", "â", "ê", "î", "ô", "û", "ç"}
        Dim caracteresSemAcento As Char() = {"a", "e", "i", "o", "u", "a", "o", "a", "e", "i", "o", "u", "c"}

        For i As Integer = 0 To caracteresAcentuados.Length - 1
            texto = texto.Replace(caracteresAcentuados(i), caracteresSemAcento(i))
        Next

        Return texto
    End Function


    Private Sub EventosEmpresaDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventosEmpresaDataGridView.CellContentDoubleClick
        ' Adiciona o Evento dentro do FrmLegalizacao.MotivoRichTextBox
        ' Verifica antes se tem texto no FrmLegalizacao.MotivoRichTextBox e adiciona na próxima linha
        Dim textoEvento As String = EventosEmpresaDataGridView.CurrentRow.Cells(0).Value.ToString()

        If FrmLegalizacao.MotivoRichTextBox.Text = "" Then
            FrmLegalizacao.MotivoRichTextBox.Text = textoEvento
        Else
            FrmLegalizacao.MotivoRichTextBox.Text = FrmLegalizacao.MotivoRichTextBox.Text & vbCrLf & textoEvento
        End If

        ' Mensagem de confirmação
        MessageBox.Show("Texto adicionado: " & textoEvento, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Me.Close()
    End Sub
End Class