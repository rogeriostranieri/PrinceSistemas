Imports System.Windows.Forms

Public Class DadosExportacao

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DadosExportacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nao permitir editar apenas copiar
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox2.ReadOnly = True



    End Sub


End Class
