Public Class FrmAtalhoBuscadores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Application.OpenForms.OfType(Of FrmBuscaEmpresas)().Count() > 0 Then

            FrmBuscaEmpresas.Focus()
            FrmBuscaEmpresas.Close()
            ' FrmBuscaEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmBuscaEmpresas.Show()
            Me.Close()

        Else

            'FrmBuscaEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmBuscaEmpresas.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Application.OpenForms.OfType(Of BuscaNomeSocio)().Count() > 0 Then

            BuscaNomeSocio.Focus()
            BuscaNomeSocio.Close()
            '  BuscaNomeSocio.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            BuscaNomeSocio.Show()
            Me.Close()

        Else

            ' BuscaNomeSocio.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            BuscaNomeSocio.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class