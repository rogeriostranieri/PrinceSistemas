Public Class FrmCalendarioParcelamento
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Pega a data selecionada no Calendar1
        Dim dataSelecionada As Date = Calendar1.SelectionStart

        ' Pega a hora e os minutos selecionados nos ComboBox
        Dim hora As String = ComboBoxHora.SelectedItem?.ToString()
        Dim minuto As String = ComboBoxMinuto.SelectedItem?.ToString()

        ' Se a hora ou minuto não forem selecionados, atribui "00" como valor padrão
        If String.IsNullOrEmpty(hora) Then
            hora = "00"
        End If

        If String.IsNullOrEmpty(minuto) Then
            minuto = "00"
        End If

        ' Valida a entrada de hora e minuto
        If hora.Length <> 2 Or minuto.Length <> 2 Then
            MessageBox.Show("Hora e minuto devem ter 2 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsNumeric(hora) Or Not IsNumeric(minuto) Then
            MessageBox.Show("Hora e minuto devem ser números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim horaInt As Integer = CInt(hora)
        Dim minutoInt As Integer = CInt(minuto)

        If horaInt < 0 Or horaInt > 23 Then
            MessageBox.Show("Hora inválida. Deve estar entre 00 e 23.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If minutoInt < 0 Or minutoInt > 59 Then
            MessageBox.Show("Minuto inválido. Deve estar entre 00 e 59.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Formata a data e a hora no formato 00/00/0000 00:00
        Dim dataHora As String = dataSelecionada.ToString("dd/MM/yyyy") & " " & hora.PadLeft(2, "0"c) & ":" & minuto.PadLeft(2, "0"c)

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
        ComboBoxHora.SelectedIndex = -1
        ComboBoxMinuto.SelectedIndex = -1
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