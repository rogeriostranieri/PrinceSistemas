Option Explicit On
Option Strict On

Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Module Security

    ' Constantes para SetWindowDisplayAffinity
    Private Const WDA_NONE As UInteger = 0
    Private Const WDA_MONITOR As UInteger = 1

    ' Importa a função SetWindowDisplayAffinity da user32.dll
    <DllImport("user32.dll")>
    Private Function SetWindowDisplayAffinity(ByVal hWnd As IntPtr, ByVal dwAffinity As UInteger) As Boolean
    End Function

    ''' <summary>
    ''' Aplica ou remove proteção contra captura de tela (PrintScreen) utilizando a API SetWindowDisplayAffinity.
    ''' Quando ativado, impede que a janela seja capturada por screenshots ou gravações.
    ''' Nota: Pode não funcionar em todas as versões ou configurações do Windows.
    ''' </summary>
    ''' <param name="targetForm">Formulário que receberá a proteção.</param>
    ''' <param name="enable">True para ativar, False para desativar.</param>
    Public Sub AplicarProtecaoContraPrintScreen(targetForm As Form, enable As Boolean)
        Try
            If enable Then
                Dim result As Boolean = SetWindowDisplayAffinity(targetForm.Handle, WDA_MONITOR)
                If Not result Then
                    Debug.WriteLine("Falha ao aplicar proteção contra PrintScreen.")
                End If
            Else
                Dim result As Boolean = SetWindowDisplayAffinity(targetForm.Handle, WDA_NONE)
                If Not result Then
                    Debug.WriteLine("Falha ao remover proteção contra PrintScreen.")
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("Erro na proteção contra PrintScreen: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Limpa o conteúdo da área de transferência.
    ''' Pode ser usado para prevenir que informações sensíveis sejam copiadas.
    ''' </summary>
    Public Sub ClearClipboard()
        Try
            Clipboard.Clear()
        Catch ex As Exception
            Debug.WriteLine("Erro ao limpar a área de transferência: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Monitoramento da área de transferência.
    ''' Pode ser utilizado para detectar e limpar automaticamente conteúdo de imagem ou outros dados sensíveis.
    ''' </summary>
    Public Sub MonitorClipboard()
        Try
            If Clipboard.ContainsImage() Then
                ClearClipboard()
                Debug.WriteLine("Imagem detectada e removida da área de transferência.")
            End If
        Catch ex As Exception
            Debug.WriteLine("Erro ao monitorar a área de transferência: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Verifica a expiração da licença com base na configuração do App.config.
    ''' </summary>
    ''' <returns>True se a licença for válida, False se estiver expirada.</returns>
    Public Function VerificarLicenca() As Boolean
        Try
            Dim dataExpiracaoStr As String = System.Configuration.ConfigurationManager.AppSettings("LicenseExpiration")
            Dim dataExpiracao As Date

            If Date.TryParseExact(dataExpiracaoStr, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataExpiracao) Then
                If Date.Today > dataExpiracao Then
                    Debug.WriteLine("Licença expirada! Aplicação bloqueada.")
                    Return False
                Else
                    Return True
                End If
            Else
                Debug.WriteLine("Erro na configuração da licença. Formato inválido.")
                Return False
            End If
        Catch ex As Exception
            Debug.WriteLine("Erro ao verificar licença: " & ex.Message)
            Return False
        End Try
    End Function

End Module
