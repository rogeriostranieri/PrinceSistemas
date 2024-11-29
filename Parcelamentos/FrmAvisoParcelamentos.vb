Public Class FrmAvisoParcelamento

    Private Sub FrmAvisoParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Parcelamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.ParcelamentosAviso'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosAvisoTableAdapter.Fill(Me.PrinceDBDataSet.ParcelamentosAviso)

        CarregaMeses()
        CarregaAnos()

        LblDataAviso.Text = VbAvisoPrincipal.MaskedTextBox1.Text
        VerificarDataAviso()

        FiltroParcelamentos()

        ' Configurações iniciais do DataGridView
        ConfigurarParcelamentosDataGridView()
    End Sub
    Private Sub CarregaMeses()
        MesRealizadoComboBox.Items.Clear()
        For i As Integer = 1 To 12
            MesRealizadoComboBox.Items.Add(MonthName(i))
        Next
    End Sub

    Private Sub CarregaAnos()
        AnoComboBox.Items.Clear()
        Dim anoAtual As Integer = Today.Year
        For i As Integer = anoAtual - 3 To anoAtual + 3
            AnoComboBox.Items.Add(i)
        Next
    End Sub



    Private Sub Salvar()
        Me.Validate()
        Me.ParcelamentosAvisoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
    End Sub
    Private Sub MesRealizadoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MesRealizadoComboBox.SelectedIndexChanged
        VerificarDataAviso()
        Salvar()
    End Sub

    Private Sub AnoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnoComboBox.SelectedIndexChanged
        VerificarDataAviso()
        Salvar()
    End Sub

    Private Sub VerificarDataAviso()
        Dim dataAviso As String = LblDataAviso.Text
        Dim mesAviso As Integer = Integer.Parse(dataAviso.Split("/")(1))
        Dim anoAviso As Integer = Integer.Parse(dataAviso.Split("/")(2))

        Dim meses() As String = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"}

        If MesRealizadoComboBox.SelectedItem IsNot Nothing Then
            If MesRealizadoComboBox.SelectedItem.ToString.ToLower <> meses(mesAviso - 1).ToLower Then
                MesRealizadoComboBox.ForeColor = Color.White
                MesRealizadoComboBox.BackColor = Color.Red
            Else
                MesRealizadoComboBox.ForeColor = Color.White
                MesRealizadoComboBox.BackColor = Color.Green
            End If
        Else
            ' Nenhum item foi selecionado, você pode definir uma cor padrão aqui
            MesRealizadoComboBox.ForeColor = Color.White
            MesRealizadoComboBox.BackColor = Color.White
        End If

        If Integer.Parse(AnoComboBox.Text) <> anoAviso Then
            AnoComboBox.ForeColor = Color.White
            AnoComboBox.BackColor = Color.Red
        Else
            AnoComboBox.ForeColor = Color.White
            AnoComboBox.BackColor = Color.Green
        End If
    End Sub

    Private Sub LblDataAviso_TextChanged(sender As Object, e As EventArgs) Handles LblDataAviso.TextChanged
        FiltroParcelamentos()
    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FiltroParcelamentos()
        'FILTRO  EMPRESA
        Dim FilterA As String = LblDataAviso.Text
        ParcelamentosBindingSource.Filter = "DataLembrete like '" & FilterA & "%'"
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Salvar()
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
End Class
