Imports System.Windows.Forms

Public Class InputDialog
    Inherits Form

    Private txtNumeroParcela As TextBox
    Private btnOK As Button
    Private lblTexto As Label

    Public Property NumeroParcela As String
    Public Property LabelText As String
    Public Property TextBoxText As String

    Public Sub New()
        Me.Size = New Size(300, 150)
        Me.Text = "Informe o número da parcela"
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterScreen

        lblTexto = New Label With {
            .Text = "Número da parcela:",
            .AutoSize = True,
            .Location = New Point(10, 10)
        }
        Me.Controls.Add(lblTexto)

        txtNumeroParcela = New TextBox With {
            .Location = New Point(10, 30),
            .Size = New Size(260, 20)
        }
        Me.Controls.Add(txtNumeroParcela)

        btnOK = New Button With {
            .Text = "OK",
            .DialogResult = DialogResult.OK,
            .Location = New Point(100, 60)
        }
        Me.Controls.Add(btnOK)

        Me.AcceptButton = btnOK

        AddHandler Me.FormClosing, AddressOf Me_FormClosing
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
        NumeroParcela = txtNumeroParcela.Text
        TextBoxText = txtNumeroParcela.Text
    End Sub
End Class