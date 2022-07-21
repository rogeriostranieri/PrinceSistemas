Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2
Imports System.IO
Public Class WebSiteGERAL
    Private Sub Titulo()
        TxtURL.Text = WebView.Source.ToString
        'Document Title Changed na barra de titulo
        Dim TituloSite As String = WebView.CoreWebView2.DocumentTitle
        Me.Text = TituloSite
        'tabcontrol TabPage1 para o titulo da pagina
        TabControl1.TabPages(0).Text = TituloSite

    End Sub

    '//////////////////////////////////////////////////////////////////////////////
    Private Sub WebView_NavigationStarting_1(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles WebView.NavigationStarting
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = True
        TxtCarregamento.Visible = True
        TxtCarregamento.Text = "Carregando..."

        'mostrar ProgressBar1 colorido
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1

    End Sub


    '//////////////////////////////////////////////////////////////////////////////
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogMsg("MS Edge Version: " + CoreWebView2Environment.GetAvailableBrowserVersionString())

        If Not String.IsNullOrEmpty(TxtURL.Text) Then
            'navigate to URL
            'WebView.Source = New Uri(TxtURL.Text)
            WebsiteNavigate(TxtURL.Text)
            'click no botao

        End If

        'ao altera o site salvar no txt da primeira linha inciando com "pagina_inicial:" e site depois
        Dim path As String = Application.StartupPath & "\PaginaInicial.txt"

        '"pagina_inicial:" e pega o site depois e coloca no ToolStripTextBox1.Tex
        If File.Exists(path) Then
            Dim lines As String() = File.ReadAllLines(path)
            Dim line As String = lines(0)
            Dim site As String = line.Substring(15)
            ToolStripTextBox1.Text = site
        End If


        '//////////////////////////////////////////////////////////////////////////////
        'abrir uma nova aba no TabControl1, ao clicar no botao TabPage2 + 





    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'unsubscribe from CoreWebView2 event(s) (remove event handlers) 
        'verificar antes se o WebView está vazio
        If WebView.CoreWebView2 IsNot Nothing Then


            RemoveHandler WebView.CoreWebView2.HistoryChanged, AddressOf CoreWebView2_HistoryChanged
        End If

        'dispose of WebView
        WebView.Dispose()
    End Sub

    Private Sub LogMsg(msg As String, Optional addTimestamp As Boolean = True)
        'ToDo: add desired code

        If addTimestamp Then
            msg = String.Format("{0} - {1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), msg)
        End If

        Debug.WriteLine(msg)
    End Sub

    Private Sub UpdateAddressBar()
        'if necessary, update address bar
        If TxtURL.Text <> WebView.Source.ToString() Then
            TxtURL.Text = WebView.Source.ToString()

            'move cursor to end of text
            TxtURL.SelectionStart = TxtURL.Text.Length
            TxtURL.SelectionLength = 0
        End If
    End Sub

    Friend Sub WebsiteNavigate(ByVal dest As String)
        If WebView IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(dest) Then
            'se no TxtURL for digitado algo separado " " pesquisar no google
            '"https://www.google.com.br/search?q="  Replace(" ", "+")
            If dest.Contains(" ") Then
                dest = "https://www.google.com.br/search?q=" + dest.Replace(" ", "+")
            ElseIf dest.Contains(".") Then
                If Not dest = "about:blank" AndAlso
                 Not dest.StartsWith("edge://") AndAlso
                 Not dest.StartsWith("file://") AndAlso
                 Not dest.StartsWith("http://") AndAlso
                 Not dest.StartsWith("https://") AndAlso
                 Not System.Text.RegularExpressions.Regex.IsMatch(dest, "^([A-Z]|[a-z]):") Then

                    'set value
                    dest = "https://" & dest

                End If
            Else
                dest = "https://www.google.com.br/search?q=" + dest.Replace(" ", "+")
            End If


            'URL must start with one of the specified strings
            'if Not, pre-pend with "https://"
            If Not dest = "about:blank" AndAlso
                   Not dest.StartsWith("edge://") AndAlso
                   Not dest.StartsWith("file://") AndAlso
                   Not dest.StartsWith("http://") AndAlso
                   Not dest.StartsWith("https://") AndAlso
                   Not System.Text.RegularExpressions.Regex.IsMatch(dest, "^([A-Z]|[a-z]):") Then

                'set value
                dest = "https://" & dest

            End If
            '            
            'option 1
            WebView.Source = New Uri(dest, UriKind.Absolute)

            'option 2
            'Caso contrário, irá realizar a pesquisa no google
            'WebView.CoreWebView2.Navigate("https://www.google.com.br/search?q=" + dest.Replace(" ", "+"))
            '  WebView.CoreWebView2.Navigate(dest)


            'update address bar
            UpdateAddressBar()

        End If



    End Sub

    Private Sub TxtURL_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebsiteNavigate(TxtURL.Text)
        End If
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        If WebView IsNot Nothing AndAlso WebView.CanGoBack Then
            WebView.GoBack()
        End If
    End Sub

    Private Sub BtnAvancar_Click(sender As Object, e As EventArgs) Handles BtnAvancar.Click
        If WebView IsNot Nothing AndAlso WebView.CanGoForward Then
            WebView.GoForward()
        End If
    End Sub

    Private Sub BtnIR_Click(sender As Object, e As EventArgs) Handles BtnIR.Click
        WebsiteNavigate(TxtURL.Text)
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        If WebView IsNot Nothing Then
            WebView.Refresh()
        End If
    End Sub

    Private Sub WebView_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView.CoreWebView2InitializationCompleted
        LogMsg("WebView_CoreWebView2InitializationCompleted")
        LogMsg("UserDataFolder: " & WebView.CoreWebView2.Environment.UserDataFolder.ToString())

        'subscribe to CoreWebView2 event(s) (add event handlers) 
        AddHandler WebView.CoreWebView2.HistoryChanged, AddressOf CoreWebView2_HistoryChanged

    End Sub

    Private Sub CoreWebView2_HistoryChanged(sender As Object, e As Object)
        'LogMsg("CoreWebView2_HistoryChanged")
        BtnVoltar.Enabled = WebView.CoreWebView2.CanGoBack
        BtnAvancar.Enabled = WebView.CoreWebView2.CanGoForward

        'update address bar
        UpdateAddressBar()
    End Sub

    Private Sub WebView_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView.NavigationCompleted
        LogMsg("WebView_NavigationCompleted")
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        TxtCarregamento.Visible = True
        TxtCarregamento.Text = "Carregamento Completo"

        Titulo()
    End Sub

    Private Sub WebView_WebMessageReceived(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs) Handles WebView.WebMessageReceived
        LogMsg("WebView_WebMessageReceived")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'fechar
        Me.Close()
    End Sub


    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        'ao altera o site salvar no txt da primeira linha inciando com "pagina_inicial:" e site depois
        Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
        Dim sw As New StreamWriter(path)
        sw.WriteLine("pagina_inicial:" & ToolStripTextBox1.Text)
        sw.Close()


    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Try
            'ler o txt e pegar o site inicial que está na frente "pagina_inicial:" do txt
            Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
            Dim sr As New StreamReader(path)
            Dim line As String = sr.ReadLine()
            Dim site As String = ""
            While line IsNot Nothing
                If line.Contains("pagina_inicial:") Then
                    site = line.Replace("pagina_inicial:", "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()
            WebsiteNavigate(site)

        Catch ex As Exception
            'abrir o site do google no lugar
            WebsiteNavigate("https://www.google.com.br/")
        End Try

    End Sub



End Class