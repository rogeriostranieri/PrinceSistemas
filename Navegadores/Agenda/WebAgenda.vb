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
        Mes = MonthName(MesBox.Text)

        'termina a DATA



        'exteve no label por extenso
        Label2.Text = (DiaBox.Text & " de " & MonthName(MesBox.Text) & " de " & AnoBox.Text)




        'coloca itens na combo
        ComboBox1.Items.Add("Agenda Tributária de " & AnoBox.Text)
        ComboBox1.Items.Add("Agenda para o Dia: " & DiaBox.Text & " de " & Mes & " de " & AnoBox.Text)
        ComboBox1.Items.Add("Diário - Período do Fato Gerador de " & Mes & " de " & AnoBox.Text)
        ComboBox1.Items.Add("Outros Vencimentos de " & Mes & " de " & AnoBox.Text)
        ComboBox1.Items.Add("Declarações, Demonstrativos e Documentos de " & Mes & " de " & AnoBox.Text)
        ComboBox1.SelectedIndex = 0


    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged




        ProgressBar1.Visible = True

        Dim d, t As Integer

        d = e.CurrentProgress

        t = e.MaximumProgress

        If d <= 0 Then



            ProgressBar1.Value = 0

            ProgressBar1.Visible = False
            TxtCarregar.Text = "Completo"
            Label5.Visible = False

        Else


            ProgressBar1.Value = Math.Min(ProgressBar1.Maximum, Convert.ToInt32(Math.Floor(ProgressBar1.Maximum * (d / t))))
            TxtCarregar.Text = "Carregando..."
            Label5.Visible = True
            Label5.Text = "Aguarde Carregar a página a baixo"
        End If







    End Sub
    Private Sub MudaCombo()
        Mes = MonthName(MesBox.Text)
        If ComboBox1.Text = "Agenda Tributária de " & AnoBox.Text Then
            WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/agenda-tributaria-" & CleanText(Mes) & "-" & AnoBox.Text & "")

        ElseIf ComboBox1.Text = "Agenda para o Dia: " & DiaBox.Text & " de " & Mes & " de " & AnoBox.Text Then
            WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/dia-" & DiaBox.Text & "-" & Mes & "-" & AnoBox.Text & "")

        ElseIf ComboBox1.Text = "Diário - Período do Fato Gerador de " & Mes & " de " & AnoBox.Text Then
            WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/diario")

        ElseIf ComboBox1.Text = "Outros Vencimentos de " & Mes & " de " & AnoBox.Text Then
            WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/outros-vencimentos")

        ElseIf ComboBox1.Text = "Declarações, Demonstrativos e Documentos de " & Mes & " de " & AnoBox.Text Then
            WebBrowser1.Navigate("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributaria-" & AnoBox.Text & "/" & CleanText(Mes) & "-" & AnoBox.Text & "/declaracoes-demonstrativos-e-documentos")
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


End Class