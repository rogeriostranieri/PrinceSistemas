Imports System.Runtime.InteropServices

Module ModProtecaoPrint

    Private Const WDA_NONE As UInteger = &H0
        Private Const WDA_MONITOR As UInteger = &H1

    <DllImport("user32.dll")>
    Private Function SetWindowDisplayAffinity(ByVal hWnd As IntPtr, ByVal dwAffinity As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Public Function ProtecaoContraPrintScreen(ByVal winForm As Form, ByVal Protege As Boolean) As Boolean
        Dim resultado As Boolean = False
        If winForm IsNot Nothing Then
            If Protege Then
                resultado = SetWindowDisplayAffinity(winForm.Handle, WDA_MONITOR)
            Else
                resultado = SetWindowDisplayAffinity(winForm.Handle, WDA_NONE)
            End If
        End If
        Return resultado
    End Function
End Module
