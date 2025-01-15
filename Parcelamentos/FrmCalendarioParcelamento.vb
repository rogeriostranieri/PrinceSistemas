Public Class FrmCalendarioParcelamento
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Pega a data selecionada no Calendar1
        Dim dataSelecionada As Date = Calendar1.SelectionStart

        ' Pega a hora e os minutos selecionados nos ComboBox
        Dim hora As String = ComboBoxHora.SelectedItem.ToString()
        Dim minuto As String = ComboBoxMinuto.SelectedItem.ToString()

        ' Formata a data e a hora no formato 00/00/0000 90:00
        Dim dataHora As String = dataSelecionada.ToString("dd/MM/yyyy") & " " & hora & ":" & minuto

        ' Define o valor formatado no MaskedTextBox
        FrmParcelamento.DataLembreteMaskedTextBox.Text = dataHora

        ' Fecha o calendário
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub FrmCalendarioParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preencher ComboBoxHora com valores de 00 a 23 (hora)
        For i As Integer = 0 To 23
            ComboBoxHora.Items.Add(i.ToString("D2"))
        Next

        ' Preencher ComboBoxMinuto com valores de 00 a 59 (minutos)
        For i As Integer = 0 To 59
            ComboBoxMinuto.Items.Add(i.ToString("D2"))
        Next

        ' Selecionar a primeira opção por padrão
        ComboBoxHora.SelectedIndex = 0
        ComboBoxMinuto.SelectedIndex = 0
    End Sub

    Private Sub FrmCalendarioParcelamento_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub
    Private Sub LinkLabelAgora_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAgora.LinkClicked
        ' Obtém a data e hora atual
        Dim dataHoraAtual As DateTime = DateTime.Now

        ' Preenche o ComboBox de hora com a hora atual (formato de 24 horas)
        ComboBoxHora.SelectedItem = dataHoraAtual.ToString("HH")

        ' Preenche o ComboBox de minuto com os minutos atuais
        ComboBoxMinuto.SelectedItem = dataHoraAtual.ToString("mm")


    End Sub

End Class