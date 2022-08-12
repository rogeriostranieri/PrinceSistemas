Public Class FrmAtalhoBuscadores

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Application.OpenForms.OfType(Of FrmBuscaEmpresas)().Count() > 0 Then

            FrmBuscaEmpresas.Focus()
            FrmBuscaEmpresas.Close()
            FrmBuscaEmpresas.Show()
            Me.Close()
        Else
            FrmBuscaEmpresas.Show()
            Me.Close()
        End If
    End Sub



    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Application.OpenForms.OfType(Of FrmBuscaAlvara)().Count() > 0 Then

            FrmBuscaAlvara.Focus()
            FrmBuscaAlvara.Close()
            FrmBuscaAlvara.Show()
            Me.Close()
        Else
            FrmBuscaAlvara.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmAtalhoBuscadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class