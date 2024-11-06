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

    Private Sub ParcelamentosAvisoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ParcelamentosAvisoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ParcelamentosAvisoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

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

        Dim meses() As String = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"}

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

    Private Sub FiltroParcelamentos()
        'FILTRO  EMPRESA
        Dim FilterA As String = LblDataAviso.Text
        ParcelamentosBindingSource.Filter = "DataLembrete like '" & FilterA & "%'"
    End Sub
End Class
