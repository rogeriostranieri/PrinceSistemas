Public Class FrmProtegeFacil
    Private Sub BtnAcompanhar_Click(sender As Object, e As EventArgs) Handles BtnAcompanhar.Click
        ' Verifica se o formulário WebSiteGERAL já está aberto
        Dim form As WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().SingleOrDefault()

        If form Is Nothing Then
            ' Se não estiver aberto, cria uma nova instância do formulário
            form = New WebSiteGERAL()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Acompanhar-Processo")
            form.Show()
        Else
            ' Se já estiver aberto, apenas foca no formulário
            form.Focus()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Acompanhar-Processo")
        End If
        Me.Close()

    End Sub

    Private Sub BtnRenovacao_Click(sender As Object, e As EventArgs) Handles BtnRenovacao.Click
        ' Verifica se o formulário WebSiteGERAL já está aberto
        Dim form As WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().SingleOrDefault()

        If form Is Nothing Then
            ' Se não estiver aberto, cria uma nova instância do formulário
            form = New WebSiteGERAL()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Solicitacao-de-Vistoria")
            form.Show()
        Else
            ' Se já estiver aberto, apenas foca no formulário
            form.Focus()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo/Pagina/Solicitacao-de-Vistoria")
        End If
        Me.Close()
    End Sub

    Private Sub BtnProtegeFacil_Click(sender As Object, e As EventArgs) Handles BtnProtegeFacil.Click
        ' Verifica se o formulário WebSiteGERAL já está aberto
        Dim form As WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().SingleOrDefault()

        If form Is Nothing Then
            ' Se não estiver aberto, cria uma nova instância do formulário
            form = New WebSiteGERAL()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://protegefacil.paas.pr.gov.br/")
            form.Show()
        Else
            ' Se já estiver aberto, apenas foca no formulário
            form.Focus()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://protegefacil.paas.pr.gov.br/")
        End If
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verifica se o formulário WebSiteGERAL já está aberto
        Dim form As WebSiteGERAL = Application.OpenForms.OfType(Of WebSiteGERAL)().SingleOrDefault()

        If form Is Nothing Then
            ' Se não estiver aberto, cria uma nova instância do formulário
            form = New WebSiteGERAL()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo")
            form.Show()
        Else
            ' Se já estiver aberto, apenas foca no formulário
            form.Focus()
            form.MdiParent = MDIPrincipal
            form.WebView.Source = New Uri("https://www.bombeiros.pr.gov.br/PrevFogo")
        End If
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Para o alvará na residência do socio não precisa dos bombeiros, so quando não é na casa do socio que precisa dos bombeiros")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("Para pedir isenção para lugar sem fins lucrativos precisa: dizer no topo da mgs: 'Ao corpo de bombeiros' + documento de Comprovatório da isenção (pode ser ata, estatuto e CNPJ apenas ou outro documento que prova que é sem fins lucrativos) + número do pedido do site + procuração.")
    End Sub
End Class