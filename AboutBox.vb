Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ModData.FimData()
        Call ModData.Valida()
        Call ModData.Dados()


        ' Configura o titulo do formulário.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Sobre {0}", ApplicationTitle)
        ' Inicializa todo o texto exibido na About Box.
        ' TODO: Personalize o assembly da aplicação no painel "Application" das propriedades do projeto 
        '    (abaixo do menu"Project").
        ' Me.LabelProductName.Text = 

        'Me.LabelVersion.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
        'Me.LabelCopyright.Text = My.Application.Info.Copyright
        'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        ' Me.TextBoxDescription.Text = My.Application.Info.Description




    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


End Class
