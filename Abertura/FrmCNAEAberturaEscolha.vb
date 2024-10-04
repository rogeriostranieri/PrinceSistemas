Public Class FrmCNAEAberturaEscolha
    ' Evento que ocorre quando o formulário é carregado

    ' Sobrescrevendo o método para detectar teclas pressionadas
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Verifica se a tecla pressionada é a tecla Esc
        If keyData = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
            Return True
        End If

        ' Se não for a tecla Esc, usa o comportamento padrão
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
            WebSiteGERAL.Focus()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://concla.ibge.gov.br/busca-online-cnae.html")

        Else
            WebSiteGERAL.Show()
            WebSiteGERAL.MdiParent = MDIPrincipal
            WebSiteGERAL.WebView.Source = New Uri("https://concla.ibge.gov.br/busca-online-cnae.html")
        End If
        Me.Close()
    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        If Application.OpenForms.OfType(Of FrmCNAEoficial)().Count() > 0 Then
            FrmCNAEoficial.Focus()
        Else
            FrmCNAEoficial.Show()
        End If
        Me.Close()
    End Sub

    Private Sub FrmCNAEAberturaEscolha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
