Public Class WebAgenda
    'Mes do ano etenso
    Dim Mes As String

    'ao fechar form tambem fechar WebView2
    Private Sub WebAgenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WebView2.Dispose()
    End Sub


    Private Sub WebAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'abrir form como MDI FILHO
        Me.MdiParent = MDIPrincipal
        'maximizado form
        Me.WindowState = FormWindowState.Maximized

        DiaBox.Text = DateTime.Now.ToString("dd")
        MesBox.Text = DateTime.Now.ToString("MM")
        AnoBox.Text = DateTime.Now.ToString("yyyy")

        AddCombo()

        'exteve no label por extenso
        Label2.Text = (DiaBox.Text & " de " & MonthName(MesBox.Text) & " de " & AnoBox.Text)

    End Sub

    Private Sub AddCombo()

        Dim MesExtenso As String = MonthName(MesBox.Text)
        Dim Ano As String = AnoBox.Text
        Dim Dia As String = DiaBox.Text
        Dim Mes As String = MesBox.Text

        'coloca itens na combo
        ComboBox1.Items.Add("Agenda Tributária todos meses")
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


        If ComboBox1.Text = "Agenda Tributária de " & MesExtenso & " de " & Ano Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso)
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Agenda para o Dia: " & Dia & " de " & MesExtenso & " de " & Ano Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "/dia-" & Dia & "-" & Mes & "-" & Ano & "")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Vencimentos diários" Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "/diario")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Vencimentos sem dia específico" Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "/vencimentos-sem-dia-especifico")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Prazo de entrega de declarações (obrigações acessórias)" Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "/prazo-de-entrega-de-declaracoes")
            WebView2.Refresh()

        ElseIf ComboBox1.Text = "Agenda Tributária todos meses" Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria")
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
        AddCombo()
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