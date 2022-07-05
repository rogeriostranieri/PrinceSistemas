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

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)

        'barra de progresso para WebView2
        ProgressBar1.Maximum = e.MaximumProgress
        ProgressBar1.Value = e.CurrentProgress
        'mostrar no Label5 o progresso da pagina
        Label5.Text = e.CurrentProgress & " %"



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
            TextBox1.Text = WebView2.Source.ToString

        ElseIf ComboBox1.Text = "Agenda para o Dia: " & Dia & " de " & MesExtenso & " de " & Ano Then
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/dia-" & Dia & "-" & Mes & "-" & Ano & "")
            WebView2.Refresh()
            TextBox1.Text = WebView2.Source.ToString

        ElseIf ComboBox1.Text = "Vencimentos diários" Then
            'WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/diario")
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/diario")
            WebView2.Refresh()
            TextBox1.Text = WebView2.Source.ToString

        ElseIf ComboBox1.Text = "Vencimentos sem dia específico" Then
            ' WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/outros-vencimentos")
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/vencimentos-sem-dia-especifico")
            WebView2.Refresh()
            TextBox1.Text = WebView2.Source.ToString

        ElseIf ComboBox1.Text = "Prazo de entrega de declarações (obrigações acessórias)" Then
            ' WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/declaracoes-demonstrativos-e-documentos")
            WebView2.Source = New Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & Ano & "/" & MesExtenso & "-" & Ano & "/declaracoes-demonstrativos-e-documentos")
            WebView2.Refresh()
            TextBox1.Text = WebView2.Source.ToString

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'atualiza a pagina
        WebView2.Refresh()

    End Sub
End Class