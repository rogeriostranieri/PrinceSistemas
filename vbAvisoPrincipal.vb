Public Class VbAvisoPrincipal

    Private Sub VbAvisoPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '//// calendario 
        'Dim Calendario As New MonthCalendar  ' VER ISSO E COLOCA COMO PADRAO
        MonthCalendar2.Visible = False
        'calendario localizado em 187; 421
        MonthCalendar2.Location = New Point(188, 424)



        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


        'LaudosBindingSource.Filter = "BombeiroProvisorioDATA <> '0' OR ViabilidadeProvisorioDATA <> '0' OR AmbientalProvisorioDATA <> '0' OR SanitarioProvisorioDATA <> '0' OR SetranProvisorioDATA <> '0' "
        MaskedTextBox2.Text = Now.ToString("dd/MM/yyyy")

        'FILTRO LAUDO
        FiltroAlvara()


        'nao permitir maximizar
        MaximizeBox = False
        MinimizeBox = False
        MinimizeBox = False
        'sem borda 
        FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub



    Private Sub FiltroAlvara()
        'FILTRO LAUDO
        Dim FilterB As String = MaskedTextBox2.Text
        LaudosBindingSource.Filter = "BombeiroProvisorioDATA = '" & FilterB & "' OR ViabilidadeProvisorioDATA = '" & FilterB & "' OR AmbientalProvisorioDATA = '" & FilterB & "' OR SanitarioProvisorioDATA = '" & FilterB & "' OR SetranProvisorioDATA = '" & FilterB & "' "
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FiltroAlvara

    End Sub

    Private Sub LaudosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView1.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmAlvara.Focus()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView1.CurrentRow.Cells(0).Value.ToString
            'FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView1.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        Else
            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView1.CurrentRow.Cells(0).Value.ToString
            ' FrmAlvara.ComboBoxBuscaAlvara.Text = LaudosDataGridView1.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBoxBuscaAlvara.Focus()
        End If
    End Sub

    '/////////// Inicio do codigo de mostrar calendario
    '///// TEM MAIS NO LOAD 

    Private Sub MaskedTextBox2_Click(sender As Object, e As EventArgs) Handles MaskedTextBox2.Click
        MonthCalendar2.Visible = True
    End Sub

    Private Sub MaskedTextBox2_Leave(sender As Object, e As EventArgs) Handles MaskedTextBox2.Leave
        MonthCalendar2.Visible = False
    End Sub

    Private Sub MonthCalendar2_Leave(sender As Object, e As EventArgs) Handles MonthCalendar2.Leave
        MonthCalendar2.Visible = False

    End Sub

    Private Sub MonthCalendar2_MouseLeave(sender As Object, e As EventArgs) Handles MonthCalendar2.MouseLeave
        MonthCalendar2.Visible = False

    End Sub

    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        MaskedTextBox2.Text = MonthCalendar2.SelectionStart
        Calendar1.Visible = False
        FiltroAlvara()
    End Sub




    '/////////// fim do codigo de mostrar calendario 

    Private Sub ButtonMais7_Click(sender As Object, e As EventArgs) Handles ButtonMais7.Click
        'Abrir vencimentoalvaravb dentro do mdiprincipal e verificar se está aberto
        If Application.OpenForms.OfType(Of VencimentoAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            VencimentoAlvara.Focus()
            'frente
            VencimentoAlvara.BringToFront()
        Else
            VencimentoAlvara.MdiParent = MDIPrincipal
            VencimentoAlvara.Show()
            VencimentoAlvara.Focus()
        End If
    End Sub

    'se for maximizado voltar ao normal
    Private Sub VbAvisoPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BtnControleLigacoes_Click(sender As Object, e As EventArgs) Handles BtnControleLigacoes.Click
        If Application.OpenForms.OfType(Of FrmLigacaoAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmLigacaoAlvara.Focus()
            'para frente
            FrmLigacaoAlvara.BringToFront()
        Else
            FrmLigacaoAlvara.MdiParent = MDIPrincipal
            FrmLigacaoAlvara.Show()
            FrmLigacaoAlvara.Focus()
        End If
    End Sub
End Class
