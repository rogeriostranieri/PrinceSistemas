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

        'juntar as colunas da primeira linha da TableLayoutPanel2
        Dim sb As New System.Text.StringBuilder
        For Each c As Control In Me.TableLayoutPanel2.Controls
            If TypeOf c Is TextBox Then
                sb.Append(c.Text)
            ElseIf TypeOf c Is ComboBox Then
                sb.Append(c.Text)
            End If
        Next
        Me.RichTextBox1.Text = sb.ToString
        sb.Remove(0, sb.Length)

    End Sub


End Class
