Public Class WebAgenda
    'Mes do ano etenso
    Dim Mes As String



    Private Sub WebAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Me.WindowState = FormWindowState.Maximized


        'Dim texto As String = "Esta é a previsão de como irá ficar o conteúdo do documento se clicar no botão"
        ' Dim textoLimpo As String = CleanText(texto)

        'DATA DE HOJE no textobox

        DiaBox.Text = DateTime.Now.ToString("dd")
        MesBox.Text = DateTime.Now.ToString("MM")
        AnoBox.Text = DateTime.Now.ToString("yyyy")
        'Mes = MonthName(MesBox.Text)

        'termina a DATA



        'exteve no label por extenso
        Label2.Text = (DiaBox.Text & " de " & MonthName(MesBox.Text) & " de " & AnoBox.Text)




        Dim MesExtenso As String = MonthName(MesBox.Text)
        Dim Ano As String = AnoBox.Text
        Dim Dia As String = DiaBox.Text
        Dim Mes As String = MesBox.Text

        'coloca itens na combo
        ComboBox1.Items.Add("Agenda Tributária de " & MesExtenso & " de " & Ano)
        ComboBox1.Items.Add("Agenda para o Dia: " & Dia & " de " & MesExtenso & " de " & Ano)
        ComboBox1.Items.Add("Vencimentos diários")
        ComboBox1.Items.Add("Vencimentos sem dia específico")
        ComboBox1.Items.Add("Prazo de entrega de declarações (obrigações acessórias)")
        ComboBox1.SelectedIndex = 0




    End Sub




    Private Sub MudaCombo()
        Dim MesExtenso As String = MonthName(MesBox.Text)
        Dim Ano As String = AnoBox.Text
        Dim Dia As String = DiaBox.Text
        Dim Mes As String = MesBox.Text

        ' Mes = MonthName(MesBox.Text)

        If ComboBox1.Text = "Agenda Tributária de " & MesExtenso & " de " & Ano Then
            'https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-2022/julho-2022
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Agenda para o Dia: " & Dia & " de " & MesExtenso & " de " & Ano Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/dia-" & Dia & "-" & Mes & "-" & Ano & "")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Vencimentos diários" Then
            'WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/diario")
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/diario")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Vencimentos sem dia específico" Then
            ' WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/outros-vencimentos")
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/vencimentos-sem-dia-especifico")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Prazo de entrega de declarações (obrigações acessórias)" Then
            ' WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/declaracoes-demonstrativos-e-documentos")
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/declaracoes-demonstrativos-e-documentos")
            WebView2.Refresh()

        End If

    End Sub

    Private Sub WebAgenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MudaCombo()
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click

        'exteve no label por extenso
        Label2.Text = (DiaBox.Text & " de " & MonthName(MesBox.Text) & " de " & AnoBox.Text)
        Mes = MonthName(MesBox.Text)


        'Limpar
        ComboBox1.Items.Clear()
        'coloca itens na combo novamente
        ComboBox1.Items.Add("Agenda Tributária de " & AnoBox.Text)
        ComboBox1.Items.Add("Agenda para o Dia: " & DiaBox.Text & " de " & Mes & " de " & AnoBox.Text)
        ComboBox1.Items.Add("Diário - Período do Fato Gerador de " & Mes & " de " & AnoBox.Text)
        ComboBox1.Items.Add("Outros Vencimentos de " & Mes & " de " & AnoBox.Text)
        ComboBox1.Items.Add("Declarações, Demonstrativos e Documentos de " & Mes & " de " & AnoBox.Text)
        ComboBox1.SelectedIndex = 0
        MudaCombo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub WebView2_NavigationStarting(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles WebView2.NavigationStarting
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = True
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregando..."

        'mostrar ProgressBar1 colorido
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1


    End Sub

    Private Sub WebView2_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView2.NavigationCompleted
        'mostrar barra de progresso e mudar LblStatusCarregamento
        ProgressBar1.Visible = False
        LblStatusCarregamento.Visible = True
        LblStatusCarregamento.Text = "Carregamento Completo"

    End Sub
End Class