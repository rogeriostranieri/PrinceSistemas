Imports System.Windows.Forms

Public Class WebControleDialog
    'apertar ESC sair
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'verfica se CheckedListBox foi marcado a opção de "Apagar tudo"
        If CheckedListBox.GetItemChecked(0) = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            'apaga o que foi marcado
            If CheckedListBox.GetItemChecked(5) = True Then
                LimparTudo()
            End If

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LimparTudo()
        'verificar se WebGeral está aberto e fechar
        If Not IsNothing(WebSiteGERAL) Then
            WebSiteGERAL.Close()
        End If

        'excluir pasta  "\PrinceSistemas.exe.WebView2" onde fica salvo todo cache
        Dim dir As String = Application.StartupPath & "\PrinceSistemas.exe.WebView2"
        Dim di As New IO.DirectoryInfo(dir)
        'verificar se tem pasta do webview 
        If di.Exists Then
            For Each fi As IO.FileInfo In di.GetFiles()
                fi.Delete()
            Next
            For Each dii As IO.DirectoryInfo In di.GetDirectories()
                dii.Delete(True)
            Next
            di.Delete()
        End If
        'fim do codigo de apagar a pasta
        'mgs
        MsgBox("Arquivos Temporários foi limpo com sucesso!", MsgBoxStyle.Information, "Limpar Total")
    End Sub
End Class
