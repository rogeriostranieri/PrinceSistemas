Public Class Avisos


    Private Sub Avisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '//// calendario 
        'Dim Calendario As New MonthCalendar  ' VER ISSO E COLOCA COMO PADRAO
        Calendar1.Visible = False
        Calendar1.Location = New Point(258, 107)
        '////// fim calencario   


        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)



        'Data de Hoje convertendo   
        MaskedTextBox1.Text = Now.ToString("dd/MM/yyyy")

        '--------------------------------------


        Filtro()

        'nao permitir maximizar
        MaximizeBox = False
        MinimizeBox = False
        'sem borda 

        FormBorderStyle = FormBorderStyle.FixedSingle



    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub Filtro()
        ' PESQUISA COM FILTRO POR DATA AVISO

        'FILTRO  EMPRESA
        Dim FilterA As String = MaskedTextBox1.Text
        EmpresasBindingSource.Filter = "AvisarDia like '" & FilterA & "%'"

        'FILTRO LAUDO
        Dim FilterB As String = MaskedTextBox1.Text
        LaudosBindingSource.Filter = "AvisarDia like '" & FilterB & "%'"


        'igual do venc laudos
        VbAvisoPrincipal.MaskedTextBox2.Text = MaskedTextBox1.Text
        VbAvisoPrincipal.Button2.PerformClick()

        Me.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Filtro()
    End Sub





    Private Sub EmpresasDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentDoubleClick
        ' Verifica se a célula clicada é a primeira (índice 0)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cnpjValue As String = EmpresasDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString().Trim()
            Dim razaoSocialValue As String = EmpresasDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()

            If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
                Dim Sair As String
                Sair = MsgBox("O formulário já está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
                FrmLegalizacao.Focus()

                If String.IsNullOrEmpty(cnpjValue) Then
                    FrmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocialValue
                    FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
                Else
                    FrmLegalizacao.ComboBoxBuscaCNPJ.Text = cnpjValue
                    FrmLegalizacao.ComboBoxBuscaCNPJ.Focus()
                End If

            Else
                FrmLegalizacao.Show()

                If String.IsNullOrEmpty(cnpjValue) Then
                    FrmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocialValue
                    FrmLegalizacao.ComboBoxBuscaEmpresa.Focus()
                Else
                    FrmLegalizacao.ComboBoxBuscaCNPJ.Text = cnpjValue
                    FrmLegalizacao.ComboBoxBuscaCNPJ.Focus()
                End If


            End If
        End If
    End Sub

    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick
        ' Verifica se a célula clicada é a primeira (índice 0)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cnpjValue As String = LaudosDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString().Trim()
            Dim razaoSocialValue As String = LaudosDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()

            If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
                Dim Sair As String
                Sair = MsgBox("O formulário já está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
                FrmAlvara.Focus()

                If String.IsNullOrEmpty(cnpjValue) Then
                    FrmAlvara.ComboBoxBuscaAlvara.Text = razaoSocialValue
                    FrmAlvara.ComboBoxBuscaAlvara.Focus()
                Else
                    FrmAlvara.ComboBoxBuscaCNPJ.Text = cnpjValue
                    FrmAlvara.ComboBoxBuscaCNPJ.Focus()
                End If


            Else
                FrmAlvara.Show()

                If String.IsNullOrEmpty(cnpjValue) Then
                    FrmAlvara.ComboBoxBuscaAlvara.Text = razaoSocialValue
                    FrmAlvara.ComboBoxBuscaAlvara.Focus()
                Else
                    FrmAlvara.ComboBoxBuscaCNPJ.Text = cnpjValue
                    FrmAlvara.ComboBoxBuscaCNPJ.Focus()
                End If

                FrmAlvara.ComboBoxBuscaCNPJ.Focus()
            End If
        End If
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
            'Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)
            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
            'reload TableAdapter do vbAvisoPrincipal
            VbAvisoPrincipal.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
        Finally
        End Try

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Application.OpenForms.OfType(Of LembreteInicial)().Count() > 0 Then

            LembreteInicial.Focus()
            LembreteInicial.Close()
            LembreteInicial.MdiParent = MDIPrincipal
            LembreteInicial.Show()

        Else

            LembreteInicial.MdiParent = MDIPrincipal
            LembreteInicial.Show()


        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Application.OpenForms.OfType(Of PrioridadeAviso)().Count() > 0 Then

            PrioridadeAviso.Focus()
            PrioridadeAviso.Close()
            PrioridadeAviso.MdiParent = MDIPrincipal
            PrioridadeAviso.Show()

        Else

            PrioridadeAviso.MdiParent = MDIPrincipal
            PrioridadeAviso.Show()

        End If
    End Sub


    '/////////// Inicio do codigo de mostrar calendario
    '///// TEM MAIS NO LOAD 
    Private Sub MaskedTextBox1_Click(sender As Object, e As EventArgs) Handles MaskedTextBox1.Click
        Calendar1.Visible = True
    End Sub


    Private Sub MaskedTextBox1_Leave(sender As Object, e As EventArgs) Handles MaskedTextBox1.Leave
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar1_Leave(sender As Object, e As EventArgs) Handles Calendar1.Leave
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar1_MouseLeave(sender As Object, e As EventArgs) Handles Calendar1.MouseLeave
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateSelected
        MaskedTextBox1.Text = Calendar1.SelectionStart
        Calendar1.Visible = False
        Filtro()

    End Sub

    Private Sub BtnProtocolados_Click(sender As Object, e As EventArgs) Handles BtnProtocolados.Click
        Dim Protocolos As New FrmProtocoladosGeral

        If Application.OpenForms.OfType(Of FrmProtocoladosGeral)().Count() > 0 Then

            Protocolos.Focus()
            Protocolos.Close()
            Protocolos.MdiParent = MDIPrincipal
            Protocolos.Show()

        Else

            Protocolos.MdiParent = MDIPrincipal
            Protocolos.Show()


        End If
    End Sub

    '/////////// fim do codigo de mostrar calendario        
End Class