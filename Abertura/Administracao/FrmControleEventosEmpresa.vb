Public Class FrmControleEventosEmpresa
    'evento esc
    Private Sub FrmControleEventosEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub Salvar()
        Dim changedRecords As System.Data.DataTable
        Me.EventosEmpresaBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.EventosEmpresa.GetChanges()

        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then
            Dim message As String = "Você realizou as seguintes alterações:" & vbCrLf

            ' Iterar sobre as linhas alteradas para exibir detalhes
            For Each row As DataRow In changedRecords.Rows
                Select Case row.RowState
                    Case DataRowState.Added
                        message &= "- Novo registro adicionado." & vbCrLf
                    Case DataRowState.Modified
                        message &= "- Registro modificado:" & vbCrLf

                        ' Exibir valores alterados
                        For Each column As DataColumn In changedRecords.Columns
                            Dim originalValue = row(column, DataRowVersion.Original)
                            Dim currentValue = row(column, DataRowVersion.Current)
                            If Not Equals(originalValue, currentValue) Then
                                message &= $"  {column.ColumnName}: '{originalValue}' -> '{currentValue}'" & vbCrLf
                            End If
                        Next
                    Case DataRowState.Deleted
                        message &= "- Registro excluído." & vbCrLf
                End Select
            Next

            ' Mostrar mensagem com opções para salvar alterações
            message &= vbCrLf & "Deseja salvar essas alterações?"
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Cancel Then
                ' Usuário cancelou
            ElseIf result = DialogResult.No Then
                ' Recarregar dados originais
                Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)
            ElseIf result = DialogResult.Yes Then
                Try
                    ' Salvar alterações
                    Me.Validate()
                    Me.EventosEmpresaBindingSource.EndEdit()
                    Me.EventosEmpresaTableAdapter.Update(Me.PrinceDBDataSet.EventosEmpresa)
                Catch exc As Exception
                    MessageBox.Show("Ocorreu um erro ao atualizar:" & vbCrLf & exc.Message, "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        End If
    End Sub


    'verificar se teve alteração, se tiver ai pergunta se vai salvar
    Private Sub FrmControleEventosEmpresa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Salvar()
    End Sub

    Private Sub FrmControleEventosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.EventosEmpresa'. Você pode movê-la ou removê-la conforme necessário.
        Me.EventosEmpresaTableAdapter.Fill(Me.PrinceDBDataSet.EventosEmpresa)
        EmpresaFacil.Checked = True
        ReceitaFederal.Checked = False
        ReceitaEstadual.Checked = False
        PrefeituraMunicipal.Checked = False



        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.MinimumSize = New Size(929, 570) ' Tamanho mínimo para evitar o encolhimento excessivo


        TableLayoutPanel1.RowStyles(0).SizeType = SizeType.Percent
        TableLayoutPanel1.RowStyles(0).Height = 100 ' Primeira linha visível (100%)

        TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Absolute
        TableLayoutPanel1.RowStyles(1).Height = 0 ' Segunda linha oculta inicialmente

        ' Configurar as linhas do TableLayoutPanel
        TableLayoutPanel1.RowStyles(0).SizeType = SizeType.AutoSize ' Ajusta a altura automaticamente
        TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Absolute ' Inicialmente oculta
        TableLayoutPanel1.RowStyles(1).Height = 0 ' Altura da segunda linha é zero

        GroupBoxMeio.Enabled = False
        GroupBoxTopo.Enabled = True

    End Sub


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Salvar()
        ' Perguntar antes de adicionar novo registro
        If MessageBox.Show("Deseja adicionar um novo registro?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Configurar a altura da segunda linha para exibir
            TableLayoutPanel1.RowStyles(1).Height = TableLayoutPanel1.RowStyles(0).Height

            ' Atualizar o layout do TableLayoutPanel e do formulário
            TableLayoutPanel1.PerformLayout()
            AdjustFormHeight()


            EmpresaFacil.CheckState = CheckState.Unchecked
            ReceitaFederal.CheckState = CheckState.Unchecked
            ReceitaEstadual.CheckState = CheckState.Unchecked
            PrefeituraMunicipal.CheckState = CheckState.Unchecked

            ' Remover o filtro temporariamente antes de adicionar o novo registro
            EventosEmpresaBindingSource.RemoveFilter()

            GroupBoxMeio.Enabled = True
            GroupBoxTopo.Enabled = False

            ' Adicionar novo registro ao BindingSource
            Me.Validate()
            Me.EventosEmpresaBindingSource.AddNew()

            ' Recarregar para o novo registro
            EventosEmpresaBindingSource.MoveLast()


        End If
    End Sub


    Private Sub AdjustFormHeight()
        ' Ajusta a altura do formulário com base no conteúdo do TableLayoutPanel
        Dim totalHeight As Integer = TableLayoutPanel1.PreferredSize.Height
        Dim extraHeight As Integer = Me.Height - Me.ClientSize.Height ' Altura adicional (borda, título, etc.)
        Me.Height = totalHeight + extraHeight
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
        EventosEmpresaDataGridView.Visible = True
        EventosComboBox.Visible = True
        EmpresaFacil.Checked = True
        ReceitaFederal.Checked = False
        ReceitaEstadual.Checked = False
        PrefeituraMunicipal.Checked = False


        ' Configurar a altura da segunda linha para ocultar
        TableLayoutPanel1.RowStyles(1).Height = 0

        ' Atualizar o layout do TableLayoutPanel e do formulário
        TableLayoutPanel1.PerformLayout()
        AdjustFormHeight()

        GroupBoxMeio.Enabled = False
        GroupBoxTopo.Enabled = True
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'pergunta se deseja excluir
        If MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.EventosEmpresaBindingSource.RemoveCurrent()
            Me.Validate()
            Me.EventosEmpresaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            GroupBoxMeio.Enabled = False
            GroupBoxTopo.Enabled = True
        End If
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EmpresaFacil.CheckedChanged, ReceitaFederal.CheckedChanged, ReceitaEstadual.CheckedChanged, PrefeituraMunicipal.CheckedChanged
        ' Verifica qual CheckBox foi marcado
        Dim currentCheckBox As CheckBox = CType(sender, CheckBox)

        ' Desmarca os outros CheckBoxes
        If currentCheckBox.Checked Then
            If currentCheckBox IsNot EmpresaFacil Then EmpresaFacil.Checked = False
            If currentCheckBox IsNot ReceitaFederal Then ReceitaFederal.Checked = False
            If currentCheckBox IsNot ReceitaEstadual Then ReceitaEstadual.Checked = False
            If currentCheckBox IsNot PrefeituraMunicipal Then PrefeituraMunicipal.Checked = False
        End If

        ' Aplica o filtro após a alteração
        AplicarFiltroEventos()
    End Sub


    Private Sub AplicarFiltroEventos()
        ' Cria uma string para o filtro
        Dim filter As String = String.Empty

        ' Adiciona condições ao filtro baseado nos CheckBoxes
        If EmpresaFacil.Checked Then
            filter &= "EmpresaFacil = 'Checked' "
        End If
        If ReceitaFederal.Checked Then
            If filter.Length > 0 Then filter &= "AND "
            filter &= "ReceitaFederal = 'Checked' "
        End If
        If ReceitaEstadual.Checked Then
            If filter.Length > 0 Then filter &= "AND "
            filter &= "ReceitaEstadual = 'Checked' "
        End If
        If PrefeituraMunicipal.Checked Then
            If filter.Length > 0 Then filter &= "AND "
            filter &= "PrefeituraMunicipal = 'Checked' "
        End If

        ' Aplica o filtro ao BindingSource
        If filter.Length > 0 Then
            EventosEmpresaBindingSource.Filter = filter
        Else
            EventosEmpresaBindingSource.RemoveFilter()
        End If
    End Sub







End Class