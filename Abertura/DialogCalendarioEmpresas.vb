Imports System.Windows.Forms

Public Class DialogCalendarioEmpresas

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateSelected
        Legalizacao.AvisarDiaMaskedTextBox.Text = Calendar1.SelectionStart
        Me.Close()
    End Sub

    Private Sub Calendar1_Leave(sender As Object, e As EventArgs) Handles Calendar1.Leave
        Me.Close()
    End Sub

    Private Sub Calendar1_MouseLeave(sender As Object, e As EventArgs) Handles Calendar1.MouseLeave
        Me.Close()
    End Sub


End Class
