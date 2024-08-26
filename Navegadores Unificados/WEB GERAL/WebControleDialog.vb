Imports System.IO

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
        Try
            '/////////////////////////// GERAL ///////////////////////////////////////////
            'verificar a tab aberta 1 ou 2 da TabControleGeral
            If TabControleGeral.SelectedTab Is TabPage1 Then
                If TextBoxPaginaInicial.Text <> "" Then
                    'ao altera o site salvar no txt da primeira linha inciando com "pagina_inicial:" e site depois
                    Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
                    Dim sw As New StreamWriter(path)
                    sw.WriteLine("pagina_inicial:" & TextBoxPaginaInicial.Text)
                    sw.Close()
                End If


                '/////////////////////////// PRIVACIDADE ///////////////////////////////////////////
            ElseIf TabControleGeral.SelectedTab Is TabPage2 Then
                'Apagar tudo
                If CheckedListBox.GetItemChecked(5) = True Then
                    LimparTudo()

                    'Histórico de navegação
                ElseIf CheckedListBox.GetItemChecked(0) = True Then
                    'mgsbox "em desenvolvimento"
                    MsgBox("Em desenvolvimento")


                    ' Histórico de downloads
                ElseIf CheckedListBox.GetItemChecked(1) = True Then
                    'mgsbox "em desenvolvimento"
                    MsgBox("Em desenvolvimento")


                    'Histórico de cookies
                ElseIf CheckedListBox.GetItemChecked(2) = True Then
                    'mgsbox "em desenvolvimento"
                    MsgBox("Em desenvolvimento")


                    'Histórico de armazenamento de cache
                ElseIf CheckedListBox.GetItemChecked(3) = True Then
                    'mgsbox "em desenvolvimento"
                    MsgBox("Em desenvolvimento")

                    'Histórico de senhas e privacidade
                ElseIf CheckedListBox.GetItemChecked(4) = True Then
                    'mgsbox "em desenvolvimento"
                    MsgBox("Em desenvolvimento")


                Else

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LimparTudo()
        Try
            'perguntar se deseja apagar
            Dim result As Integer = MessageBox.Show("Deseja apagar tudo?", "Apagar", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub BtnPagInicialPadrao_Click(sender As Object, e As EventArgs) Handles BtnPagInicialPadrao.Click
        'mudar TextBoxPaginaInicial para "https://www.google.com.br/"
        TextBoxPaginaInicial.Text = "https://www.google.com.br/"
    End Sub

    Private Sub BtnPagInicialAtual_Click(sender As Object, e As EventArgs) Handles BtnPagInicialAtual.Click
        Try
            'verificar se WebSiteGeral está aberto e pegar a TxtURL.Text e coloca na TextBoxPaginaInicial
            If Not IsNothing(WebSiteGERAL) Then
                TextBoxPaginaInicial.Text = WebSiteGERAL.TxtURL.Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub WebControleDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'verificar se WebSiteGeral está aberto 
            If Not IsNothing(WebSiteGERAL) Then


                '"pagina_inicial:" e pega o site depois e coloca no TexT
                Dim path As String = Application.StartupPath & "\PaginaInicial.txt"

                If File.Exists(Path) Then
                    Dim lines As String() = File.ReadAllLines(Path)
                    Dim line As String = lines(0)
                    Dim site As String = line.Substring(15)
                    TextBoxPaginaInicial.Text = site
                End If
            Else
                'mgsbox navegador não está aberto
                MsgBox("Navegador não está aberto!", MsgBoxStyle.Exclamation, "Navegador não está aberto")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
