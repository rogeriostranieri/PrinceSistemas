Imports System.Threading ' Necessário para usar Mutex

Namespace My
    Partial Friend Class MyApplication
        ' Mutex para garantir uma única instância da aplicação
        Private Shared appMutex As Mutex

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Define um nome único para o Mutex (baseado no nome da aplicação)
            Dim mutexName As String = "PrinceSistemasSingleInstance"
            Dim createdNew As Boolean ' Declara a variável fora do construtor
            appMutex = New Mutex(True, mutexName, createdNew) ' Passa createdNew como parâmetro de saída

            ' Verifica se esta é a primeira instância
            If Not createdNew Then
                MsgBox("Outra instância do Prince Sistemas já está em execução.", MsgBoxStyle.Information, "Aplicação Já Aberta")
                System.Environment.Exit(0) ' Encerra esta instância se outra já estiver rodando
                Return
            End If

            Try
                ' Cria e exibe a SplashScreen
                Dim splash As New SplashScreen()
                splash.Show()

                ' Cria o Login, mas não o exibe ainda
                Dim loginForm As New Login()

                ' Usa o evento FormClosed da SplashScreen para exibir e focar o Login
                AddHandler splash.FormClosed, Sub(senderSplash, eSplash)
                                                  loginForm.Show() ' Exibe o Login
                                                  loginForm.TopMost = True ' Garante que o Login fique acima de todas as janelas temporariamente
                                                  loginForm.BringToFront() ' Traz para a frente
                                                  loginForm.Activate() ' Dá foco ao Login
                                                  loginForm.Visible = True ' Garante visibilidade
                                                  loginForm.TopMost = False ' Remove TopMost após foco para comportamento normal
                                              End Sub

                ' Inicia o loop de eventos com o Login como formulário principal
                System.Windows.Forms.Application.Run(loginForm)
            Catch ex As Exception
                MsgBox("Erro durante a inicialização: " & ex.Message, MsgBoxStyle.Critical, "Erro de Inicialização")
                System.Environment.Exit(1)
            Finally
                ' Libera o Mutex ao encerrar a aplicação
                If appMutex IsNot Nothing Then
                    appMutex.ReleaseMutex()
                    appMutex.Dispose()
                End If
            End Try
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MsgBox("Ocorreu um erro inesperado: " & e.Exception.Message, MsgBoxStyle.Critical, "Erro Fatal")
            e.ExitApplication = True
        End Sub
    End Class
End Namespace