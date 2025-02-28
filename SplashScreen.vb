Public NotInheritable Class SplashScreen
    Private WithEvents splashTimer As New Timer()

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            '   ModData.LogError("SplashScreen_Load chamado")
            splashTimer.Interval = 3000
            splashTimer.Start()
            ModData.FimData()
            'ModData.LogError("FimData executado com sucesso na SplashScreen")
        Catch ex As Exception
            ' ModData.LogError("Erro no SplashScreen_Load: " & ex.Message)
            MessageBox.Show("Erro ao verificar licença: " & ex.Message)
            System.Environment.Exit(1)
        End Try
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        ' ModData.LogError("Fechando SplashScreen")
        splashTimer.Stop()
        Me.Close()
    End Sub
End Class