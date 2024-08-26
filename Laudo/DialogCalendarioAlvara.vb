Public Class DialogCalendarioAlvara

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateSelected
        ' Obter a data selecionada no formato DD/MM/YYYY
        Dim selectedDate As String = Calendar1.SelectionStart.ToString("dd/MM/yyyy")

        FrmAlvara.AvisarDiaMaskedTextBox.Text = ""
        ' Atualizar o AvisarDiaMaskedTextBox com a data formatada como string
        FrmAlvara.AvisarDiaMaskedTextBox.Text = selectedDate

        ' Fechar o formulário de calendário
        Me.Close()
    End Sub


    Private Sub Calendar1_Leave(sender As Object, e As EventArgs) Handles Calendar1.Leave
        Me.Close()
    End Sub

    Private Sub Calendar1_MouseLeave(sender As Object, e As EventArgs) Handles Calendar1.MouseLeave
        Me.Close()
    End Sub

    Private Sub DialogCalendarioAlvara_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
