Public Class VbAvisoPrincipal

    Private Sub VbAvisoPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


        'LaudosBindingSource.Filter = "BombeiroProvisorioDATA <> '0' OR ViabilidadeProvisorioDATA <> '0' OR AmbientalProvisorioDATA <> '0' OR SanitarioProvisorioDATA <> '0' OR SetranProvisorioDATA <> '0' "
        MaskedTextBox2.Text = Now.ToString("dd/MM/yyyy")

        'FILTRO LAUDO
        'FiltroAlvara()
        'FILTRO LAUDO
        Dim FilterB As String = MaskedTextBox2.Text
        LaudosBindingSource.Filter = "BombeiroProvisorioDATA = '" & FilterB & "' OR ViabilidadeProvisorioDATA = '" & FilterB & "' OR AmbientalProvisorioDATA = '" & FilterB & "' OR SanitarioProvisorioDATA = '" & FilterB & "' OR SetranProvisorioDATA = '" & FilterB & "' "

        Me.Refresh()

        'nao permitir maximizar
        MaximizeBox = False
        MinimizeBox = False
        MinimizeBox = False
        'sem borda 
        FormBorderStyle = FormBorderStyle.FixedSingle

        '//// calendario 
        'Dim Calendario As New MonthCalendar  ' VER ISSO E COLOCA COMO PADRAO
        MonthCalendar2.Visible = False
        MonthCalendar2.Location = New Point(188, 424)
        '////// fim calencario    



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
            FrmAlvara.ComboBox1.Text = LaudosDataGridView1.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        Else
            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView1.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        End If
    End Sub

    '/////////// Inicio do codigo de mostrar calendario
    '///// TEM MAIS NO LOAD 

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected
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

End Class
