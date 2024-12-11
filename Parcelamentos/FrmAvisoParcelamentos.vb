Public Class FrmAvisoParcelamento

    Private Sub FrmAvisoParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Parcelamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.ParcelamentosAviso'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosAvisoTableAdapter.Fill(Me.PrinceDBDataSet.ParcelamentosAviso)
        PegaDataAviso()
        FiltroParcelamentos()
        ' Configurações iniciais do DataGridView
        ConfigurarParcelamentosDataGridView()
    End Sub


    Private Sub LblDataAviso_TextChanged(sender As Object, e As EventArgs)
        FiltroParcelamentos()
    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FiltroParcelamentos()
        'FILTRO  EMPRESA
        Dim Data As String = MaskedTextBox1.Text
        Dim FilterA As String = Data
        ParcelamentosBindingSource.Filter = "DataLembrete like '" & FilterA & "%'"
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub BtnVerParcelamentos_Click(sender As Object, e As EventArgs) Handles BtnVerParcelamentos.Click
        ' Verifica se o formulário já está aberto
        Dim Parcelamentos = Application.OpenForms.OfType(Of FrmParcelamento)().FirstOrDefault()

        If Parcelamentos IsNot Nothing Then
            ' Se o formulário já estiver aberto, traz ele para frente e define o MdiParent, caso necessário
            FrmParcelamento.MdiParent = MDIPrincipal
            FrmParcelamento.BringToFront()
            FrmParcelamento.Focus()
        Else
            ' Caso contrário, cria uma nova instância do formulário, define o MdiParent e exibe o formulário
            FrmParcelamento.Show()
            FrmParcelamento.MdiParent = MDIPrincipal
            FrmParcelamento.BringToFront()
            FrmParcelamento.Focus()
        End If
        '   Me.Close()
    End Sub
    Private Sub ParcelamentosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ParcelamentosDataGridView.CellContentDoubleClick
        Try
            Dim Parcelamento As FrmParcelamento = Application.OpenForms.OfType(Of FrmParcelamento)().FirstOrDefault()
            If Parcelamento IsNot Nothing Then
                Parcelamento.Focus()
                Parcelamento.ComboBoxBuscarRazaoSocial.Text = ParcelamentosDataGridView.SelectedCells.Item(0).Value.ToString()
                Parcelamento.ComboBoxBuscarRazaoSocial.Select()
            Else
                Dim NovoParcelamento As New FrmParcelamento()
                NovoParcelamento.MdiParent = MDIPrincipal
                NovoParcelamento.Show()
                NovoParcelamento.ComboBoxBuscarRazaoSocial.Text = ParcelamentosDataGridView.SelectedCells.Item(0).Value.ToString()
                NovoParcelamento.ComboBoxBuscarRazaoSocial.Select()
            End If
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}")
        End Try
    End Sub


    Private Sub ConfigurarParcelamentosDataGridView()
        ' Certifica-se de que o DataGridView está habilitado
        ParcelamentosDataGridView.Enabled = True

        ' Permite edição e seleção
        ParcelamentosDataGridView.ReadOnly = False
        ParcelamentosDataGridView.AllowUserToAddRows = False ' Opcional: desativa linha de adição automática
        ParcelamentosDataGridView.AllowUserToDeleteRows = False ' Opcional: evita exclusão
        ParcelamentosDataGridView.AllowUserToResizeColumns = True
        ParcelamentosDataGridView.AllowUserToResizeRows = True
        ParcelamentosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Seleção de linha inteira


        ' Garante que o DataGridView é atualizado
        ParcelamentosDataGridView.Refresh()

    End Sub

    Private Sub BtnTodosParcel_Click(sender As Object, e As EventArgs) Handles BtnTodosParcel.Click
        ' Verifica se o formulário já está aberto
        Dim GeralParcelamentos = Application.OpenForms.OfType(Of FrmGeralParcelamento)().FirstOrDefault()

        If GeralParcelamentos IsNot Nothing Then
            ' Se o formulário já estiver aberto, traz ele para frente e define o MdiParent, caso necessário
            FrmGeralParcelamento.MdiParent = MDIPrincipal
            FrmGeralParcelamento.BringToFront()
            FrmGeralParcelamento.Focus()
        Else
            ' Caso contrário, cria uma nova instância do formulário, define o MdiParent e exibe o formulário
            FrmGeralParcelamento.Show()
            FrmGeralParcelamento.MdiParent = MDIPrincipal
            FrmGeralParcelamento.BringToFront()
            FrmGeralParcelamento.Focus()
        End If
    End Sub

    Private Sub ButtonHoje_Click(sender As Object, e As EventArgs) Handles ButtonHoje.Click
        ' Define a data de hoje no formato dd/mm/aaaa
        MaskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy")
        FiltroParcelamentos()
    End Sub

    Private Sub ButtonImportarData_Click(sender As Object, e As EventArgs) Handles ButtonImportarData.Click
        PegaDataAviso()
    End Sub

    Private Sub PegaDataAviso()
        ' Verifica se o formulário VbAvisoPrincipal está aberto
        Dim VbAvisoPrincipalForm As VbAvisoPrincipal = Nothing

        ' Procura o formulário VbAvisoPrincipal entre os filhos do MDI (MDIPrincipal)
        For Each frm As Form In MDIPrincipal.MdiChildren
            If TypeOf frm Is VbAvisoPrincipal Then
                VbAvisoPrincipalForm = CType(frm, VbAvisoPrincipal)
                Exit For
            End If
        Next

        ' Se o formulário VbAvisoPrincipal foi encontrado
        If VbAvisoPrincipalForm IsNot Nothing Then
            ' Obtém a data do MaskedTextBox1 de VbAvisoPrincipal
            Dim Data As String = VbAvisoPrincipalForm.MaskedTextBox1.Text

            ' Verifica se a data não está vazia
            If Not String.IsNullOrEmpty(Data) Then
                ' Tenta analisar a data com o formato brasileiro (dd/MM/yyyy)
                Dim parsedDate As DateTime
                If DateTime.TryParseExact(Data, "dd/MM/yyyy", Globalization.CultureInfo.GetCultureInfo("pt-BR"), Globalization.DateTimeStyles.None, parsedDate) Then
                    ' Se a data for válida, copia para o outro MaskedTextBox1
                    MaskedTextBox1.Text = Data
                Else
                    ' Se a data for inválida, exibe uma mensagem
                    MessageBox.Show("Data inválida no campo VbAvisoPrincipal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                ' Se estiver vazio, avisa o usuário
                MessageBox.Show("Por favor, insira uma data no campo VbAvisoPrincipal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            ' Se o formulário VbAvisoPrincipal não estiver aberto, avisa o usuário
            MessageBox.Show("O formulário VbAvisoPrincipal não está aberto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub MaskedTextBox1_Validated(sender As Object, e As EventArgs) Handles MaskedTextBox1.Validated
        FiltroParcelamentos()
    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        FiltroParcelamentos()
    End Sub
End Class
