Namespace My
    ' Os seguintes eventos estão disponíveis para MyApplication:
    ' Inicialização: Ocorre quando o aplicativo é iniciado, antes da criação do formulário de inicialização.
    ' Desligamento: Ocorre após todos os formulários de aplicativo serem fechados.  Esse evento não ocorrerá se o aplicativo for encerrado de forma anormal.
    ' UnhandledException: Ocorre se o aplicativo encontra uma exceção sem tratamento.
    ' StartupNextInstance: Ocorre durante a inicialização de um aplicativo de instância única quando o aplicativo já está ativo. 
    ' NetworkAvailabilityChanged: Ocorre quando a conexão de rede é conectada ou desconectada.
    Partial Friend Class MyApplication


        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Verifica o número de instancias da aplicação já a correr
            Dim p() As Process = Process.GetProcessesByName(My.Application.Info.AssemblyName)

            ' Caso sejam mais do que 1
            If p.Length > 1 Then
                '  MessageBox.Show("A aplicação já está em execução no computador!", "Prince Sistemas Informa")


                MessageBox.Show("A aplicação já está em execução no computador!", "Prince Sistemas Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                ' Cancela o processo de inicialização
                e.Cancel = True
                System.Windows.Forms.Application.Exit()
            End If
        End Sub





    End Class
End Namespace
