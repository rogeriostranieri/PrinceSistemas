Public Class FrmControleEmpresas
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        If Application.OpenForms.OfType(Of FrmEmpresaAltStatus)().Count() > 0 Then

            FrmEmpresaAltStatus.Focus()
            FrmEmpresaAltStatus.Close()
            FrmEmpresaAltStatus.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmEmpresaAltStatus.Show()


        Else

            FrmEmpresaAltStatus.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmEmpresaAltStatus.Show()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Application.OpenForms.OfType(Of FrmControleSituacaoAlvara)().Count() > 0 Then

            FrmControleSituacaoAlvara.Focus()
            FrmControleSituacaoAlvara.Close()
            FrmControleSituacaoAlvara.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmControleSituacaoAlvara.Show()


        Else

            FrmControleSituacaoAlvara.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmControleSituacaoAlvara.Show()

        End If
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BtnEventos_Click(sender As Object, e As EventArgs) Handles BtnEventos.Click
        'FrmCadastroEventosEmpresa
        If Application.OpenForms.OfType(Of FrmControleEventosEmpresa)().Count() > 0 Then
            FrmControleEventosEmpresa.Focus()
            FrmControleEventosEmpresa.Close()
            FrmControleEventosEmpresa.MdiParent = MDIPrincipal
            FrmControleEventosEmpresa.Show()
        Else
            FrmControleEventosEmpresa.MdiParent = MDIPrincipal
            FrmControleEventosEmpresa.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'FrmAlvaraSistema
        If Application.OpenForms.OfType(Of FrmAlvaraSistema)().Count() > 0 Then
            FrmAlvaraSistema.Focus()
            FrmAlvaraSistema.Close()
            FrmAlvaraSistema.MdiParent = MDIPrincipal
            FrmAlvaraSistema.Show()
        Else
            FrmAlvaraSistema.MdiParent = MDIPrincipal
            FrmAlvaraSistema.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Application.OpenForms.OfType(Of FrmBombeiroSistema)().Count() > 0 Then
            FrmBombeiroSistema.Focus()
            FrmBombeiroSistema.Close()
            FrmBombeiroSistema.MdiParent = MDIPrincipal
            FrmBombeiroSistema.Show()
        Else
            FrmBombeiroSistema.MdiParent = MDIPrincipal
            FrmBombeiroSistema.Show()
        End If
    End Sub

    Private Sub BtnSites_Click(sender As Object, e As EventArgs) Handles BtnSites.Click
        If Application.OpenForms.OfType(Of FrmSites)().Count() > 0 Then
            FrmSites.Focus()
            FrmSites.Close()
            FrmSites.MdiParent = MDIPrincipal
            FrmSites.Show()
        Else
            FrmSites.MdiParent = MDIPrincipal
            FrmSites.Show()
        End If
    End Sub
End Class