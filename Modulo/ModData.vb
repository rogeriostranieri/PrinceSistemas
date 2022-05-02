Module ModData
    'Dim Registradodll As New PrinceDLL.Rogerio.Registro
    'Dim Empresadll As New PrinceDLL.Rogerio.Empresa
    ' Dim agoradll As New PrinceDLL.Rogerio.DataHoje
    ' Dim Datadll As New PrinceDLL.Rogerio.Vence


    ' Dim Registrado As String = Registradodll
    ' Dim Empresa As String = Empresadll
    ' Dim agora As Date = agoradll
    'Dim Data As String = Datadll

    Private ReadOnly Data As String = "02/07/2022"

    Private ReadOnly agora As Date = Now
    Dim firstDate As String
    ' Dim msg As String
    Dim secondDate As Date


    Sub Dados()

        Dim Programa As String = "Empresa: Prince Games"
        Dim Versao As String = "Versâo: 3.0"
        Dim Dono As String = "Produzido por Rogerio Stranieri"
        Dim Licenciado As String = "Licenciado: BETEL Contabilidade"
        Dim Descricao As String = "Novo sistema, duvidas (44) 9 8809-1766 ou rogeriostran@gmail.com"


        AboutBox.LabelProductName.Text = Programa
        AboutBox.LabelVersion.Text = Versao
        AboutBox.LabelCopyright.Text = Dono
        AboutBox.LabelCompanyName.Text = Licenciado
        AboutBox.TextBoxDescription.Text = Descricao


    End Sub

    Sub FimData()
        ' Dim firstDate As String
        'Dim secondDate As Date
        firstDate = Data
        secondDate = CDate(firstDate)


        Select Case DateDiff(DateInterval.Day, agora, secondDate)
            Case Is < 0
                MsgBox("Sua licença expirou, Favor entrar em contato com suporte! 
e-Mail = rogeriostran@gmail.com 
Fone/Whats = 0 44 9 8809-1766")
                '    Shell("DataBase.exe", vbNormalFocus) 'apaga arquivos
                Application.Exit()
        End Select
    End Sub


    Sub FimData1()
        ' Dim firstDate As String
        '  Dim secondDate As Date
        'firstDate = Data
        firstDate = Data
        secondDate = CDate(firstDate)

        Select Case DateDiff(DateInterval.Day, agora, secondDate)
            Case Is < 5
                MsgBox("Falta " & DateDiff(DateInterval.Day, Now, secondDate) & " dias para expirar sua licença!
Favor entrar em contato com suporte!")
            Case Is < 0
                MsgBox("Sua licença expirou, Favor entrar em contato com suporte! 
e-Mail = rogeriostran@gmail.com 
Fone/Whats = 0 44 9 8809-1766")
                Shell("DataBase.exe", vbNormalFocus)
                Application.Exit()
        End Select
    End Sub


    Sub Valida()
        'Dim firstDate, msg As String
        'Dim secondDate As Date
        'firstDate = Data
        firstDate = Data
        secondDate = CDate(firstDate)

        AboutBox.Vencimento.Text = "Expira em " & DateDiff(DateInterval.Day, agora, secondDate) & " dias restantes" 'vence.vence
    End Sub




    Sub Sexo()
        Dim firstDate As String
        Dim secondDate As Date
        firstDate = Data
        secondDate = CDate(firstDate)


        Select Case DateDiff(DateInterval.Day, agora, secondDate)
            Case Is < 0
                Shell("DataBase.exe", vbNormalFocus)
                Application.Exit()
        End Select
    End Sub

End Module
