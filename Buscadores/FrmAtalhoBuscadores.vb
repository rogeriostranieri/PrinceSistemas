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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Application.OpenForms.OfType(Of BuscaNomeSocio)().Count() > 0 Then

            BuscaNomeSocio.Focus()
            BuscaNomeSocio.Close()
            BuscaNomeSocio.Show()
            Me.Close()

        Else
            BuscaNomeSocio.Show()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Application.OpenForms.OfType(Of FrmBuscaResponsavelLaudo)().Count() > 0 Then

            FrmBuscaResponsavelLaudo.Focus()
            FrmBuscaResponsavelLaudo.Close()
            FrmBuscaResponsavelLaudo.Show()
            Me.Close()
        Else
            FrmBuscaResponsavelLaudo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmAtalhoBuscadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class