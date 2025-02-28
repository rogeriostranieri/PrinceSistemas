Option Explicit On
Option Strict On

Imports System.Configuration
Imports System.Globalization
Imports System.IO

Module ModData

    ' Lê a data de expiração e o formato do arquivo de configuração
    Private ReadOnly LicenseExpirationString As String = ConfigurationManager.AppSettings("LicenseExpiration")
    Private ReadOnly DateFormat As String = ConfigurationManager.AppSettings("DateFormat")

    ' Converte a string de expiração para Date usando ParseExact com tratamento de exceção
    Private Function GetLicenseExpirationDate() As Date
        Try
            'LogError("Lendo LicenseExpirationString: " & LicenseExpirationString)
            ' LogError("Lendo DateFormat: " & DateFormat)

            If String.IsNullOrEmpty(LicenseExpirationString) Then
                Throw New Exception("A chave 'LicenseExpiration' não foi encontrada ou está vazia no App.config.")
            End If
            If String.IsNullOrEmpty(DateFormat) Then
                Throw New Exception("A chave 'DateFormat' não foi encontrada ou está vazia no App.config.")
            End If

            Dim parsedDate As Date = Date.ParseExact(LicenseExpirationString, DateFormat, CultureInfo.InvariantCulture)
            '   LogError("Data de expiração convertida: " & parsedDate.ToString("dd/MM/yyyy"))
            Return parsedDate
        Catch ex As Exception
            ' LogError("Erro na conversão da data de expiração: " & ex.Message)
            MsgBox("Erro na configuração da licença. A aplicação será bloqueada.", MsgBoxStyle.Critical, "Erro de Data")
            Application.Exit()
            Return Date.MinValue
        End Try
    End Function



    ' Registra erros em um arquivo "error.log" na pasta da aplicação
    Public Sub LogError(ByVal message As String)
        Try
            Dim logPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log")
            Dim logMessage As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - " & message & Environment.NewLine
            File.AppendAllText(logPath, logMessage)
        Catch
            ' Se falhar o log, não interrompe a execução
        End Try
    End Sub

    ' Atualiza os dados exibidos na AboutBox
    Public Sub Dados()
        AboutBox.LabelProductName.Text = "Empresa: Prince Games"
        AboutBox.LabelVersion.Text = "Versão: 3.0"
        AboutBox.LabelCopyright.Text = "Produzido por Rogerio Stranieri"
        AboutBox.LabelCompanyName.Text = "Licenciado: BETEL Contabilidade"
        AboutBox.TextBoxDescription.Text = "Novo sistema, dúvidas (44) 9 8809-1766 ou rogeriostran@gmail.com"
    End Sub

    ' Verifica se a licença expirou; se sim, bloqueia a aplicação
    Public Sub FimData()
        Try
            '  LogError("Iniciando verificação de licença em FimData")
            Dim LicenseExpirationDate As Date = GetLicenseExpirationDate()
            ' LogError("Data de expiração obtida: " & LicenseExpirationDate.ToString("dd/MM/yyyy"))
            ' LogError("Data atual: " & Date.Today.ToString("dd/MM/yyyy"))
            If LicenseExpirationDate < Date.Today Then
                Throw New Exception("Licença expirada em " & LicenseExpirationDate.ToString("dd/MM/yyyy"))
            End If
            ' LogError("Licença válida")
        Catch ex As Exception
            ' LogError("Erro na configuração da licença: " & ex.Message)
            MsgBox("Erro na configuração da licença. A aplicação será bloqueada.", MsgBoxStyle.Critical, "Erro de Licença")
            Application.Exit()
        End Try
    End Sub

    ' Notifica o usuário se faltarem poucos dias para a expiração da licença
    Public Sub FimData1()
        Dim agora As Date = DateTime.Now
        Dim expirationDate As Date = GetLicenseExpirationDate()
        Dim diasRestantes As Long = DateDiff(DateInterval.Day, agora, expirationDate)

        If diasRestantes < 0 Then
            MsgBox("Sua licença expirou, favor entrar em contato com suporte!" & vbCrLf &
                   "e-Mail: rogeriostran@gmail.com" & vbCrLf &
                   "Fone/Whats: (44) 9 8809-1766", MsgBoxStyle.Critical, "Licença Expirada")
            Application.Exit()
        ElseIf diasRestantes < 5 Then
            MsgBox("Faltam " & diasRestantes.ToString() & " dias para expirar sua licença!" & vbCrLf &
                   "Favor entrar em contato com suporte!", MsgBoxStyle.Information, "Licença Próxima do Vencimento")
        End If
    End Sub

    ' Atualiza o controle de exibição do prazo restante na AboutBox
    Public Sub Valida()
        Dim agora As Date = DateTime.Now
        Dim expirationDate As Date = GetLicenseExpirationDate()
        Dim diasRestantes As Long = DateDiff(DateInterval.Day, agora, expirationDate)

        AboutBox.Vencimento.Text = "Expira em " & diasRestantes.ToString() & " dias restantes"
    End Sub

    ' Verifica a validade da licença e encerra a aplicação se necessário
    Public Sub VerificaLicenca()
        Dim agora As Date = DateTime.Now
        Dim expirationDate As Date = GetLicenseExpirationDate()
        Dim diasRestantes As Long = DateDiff(DateInterval.Day, agora, expirationDate)

        If diasRestantes < 0 Then
            Application.Exit()
        End If
    End Sub

End Module
