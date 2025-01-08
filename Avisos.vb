Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports System.Data


Public Class Avisos
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private WithEvents timerParcelamentos As New Timer()
    Private contador As Integer = 0
    Private cores() As Color = {Color.White, Color.Yellow, Color.Red}


    Private Sub Avisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Parcelamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosTableAdapter.Fill(Me.PrinceDBDataSet.Parcelamentos)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.ParcelamentosAviso'. Você pode movê-la ou removê-la conforme necessário.
        Me.ParcelamentosAvisoTableAdapter.Fill(Me.PrinceDBDataSet.ParcelamentosAviso)

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

        VerificaParcelamentos()
    End Sub



    Private Sub Avisos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Verifica se já existe uma instância aberta de FrmAvisoParcelamentos
        If Application.OpenForms.OfType(Of FrmAvisoParcelamento)().Count() > 0 Then
            FrmAvisoParcelamento.Focus()
            FrmAvisoParcelamento.MdiParent = MDIPrincipal
            FrmAvisoParcelamento.BringToFront()
        End If
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

        'FILTRO  Parcelamentos
        Dim FilterC As String = MaskedTextBox1.Text
        ParcelamentosBindingSource.Filter = "DataLembrete like '" & FilterC & "%'"


        'igual do venc laudos
        VbAvisoPrincipal.MaskedTextBox2.Text = MaskedTextBox1.Text
        VbAvisoPrincipal.Button2.PerformClick()

        Me.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Filtro()
        VerificaParcelamentos()
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

            VerificaParcelamentos()
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
        ' Verifica se já existe uma instância aberta de FrmProtocoladosGeral
        Dim Protocolos As FrmProtocoladosGeral = Application.OpenForms.OfType(Of FrmProtocoladosGeral)().FirstOrDefault()

        ' Se já existir uma instância, foca no formulário
        If Protocolos IsNot Nothing Then
            Protocolos.Focus()
        Else
            ' Se não existir, cria uma nova instância e define o MDI parent
            Protocolos = New FrmProtocoladosGeral()
            Protocolos.MdiParent = MDIPrincipal
            Protocolos.Show()
        End If
    End Sub


    '/////////// fim do codigo de mostrar calendario
    '

    Private Sub timerParcelamentos_Tick(sender As Object, e As EventArgs) Handles timerParcelamentos.Tick
        contador += 1
        LblParcelamentosAviso.ForeColor = cores(contador Mod 3)
    End Sub

    Private Sub LblParcelamentosAviso_Click(sender As Object, e As EventArgs) Handles LblParcelamentosAviso.Click
        ' Verifica se já existe uma instância aberta de FrmProtocoladosGeral
        Dim AvisoProtocolo As FrmAvisoParcelamentos = Application.OpenForms.OfType(Of FrmAvisoParcelamentos)().FirstOrDefault()
        If AvisoProtocolo IsNot Nothing Then
            FrmAvisoParcelamentos.Focus()
            FrmAvisoParcelamentos.MdiParent = MDIPrincipal
        Else
            FrmAvisoParcelamentos.Show()
            FrmAvisoParcelamentos.MdiParent = MDIPrincipal
        End If
    End Sub

    'FIM parcelamentos









    '//////////////////////////// ver parcelamentos
    Private Sub VerificaParcelamentos()

        ' Verifica se está no modo de design, e sai da função se estiver
        If Me.DesignMode Then Return

        ' Verifica se o valor em MaskedTextBox1.Text é uma data válida
        Dim dataSelecionada As DateTime
        If Not DateTime.TryParseExact(VbAvisoPrincipal.MaskedTextBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dataSelecionada) Then
            MessageBox.Show("Data inválida. Verifique a data e tente novamente.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Mostra a data selecionada para verificação
        '   MessageBox.Show("Data selecionada: " & dataSelecionada.ToString("dd/MM/yyyy"), "Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Extrai o mês da data selecionada para comparação
        Dim mesSelecionado As Integer = dataSelecionada.Month

        ' Listas para armazenar os lembretes e parcelamentos com mês diferente
        Dim listaLembretes As New List(Of DateTime)
        Dim listaMensalDiferente As New List(Of DateTime)

        Using conexão As New SqlConnection(connectionString)
            conexão.Open()

            ' Verificar lembretes para a data selecionada
            Dim temLembrete As Boolean = VerificarLembreteParaDia(conexão, dataSelecionada, listaLembretes)

            ' Exibir mensagem sobre a verificação de lembretes
            If temLembrete Then
                ' MessageBox.Show("Parcelamento = Lembretes encontrados para a data selecionada.", "Resultado da Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Application.OpenForms.OfType(Of FrmAvisoParcelamento)().Count() > 0 Then
                    FrmAvisoParcelamento.Focus()
                    FrmAvisoParcelamento.MdiParent = MDIPrincipal
                Else
                    FrmAvisoParcelamento.Show()
                    FrmAvisoParcelamento.MdiParent = MDIPrincipal
                End If
            Else
                ' MessageBox.Show("Nenhum lembrete encontrado para a data selecionada.", "Resultado da Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Verificar se algum DataEnvio possui mês diferente
            Dim mesEnvioDiferente As Boolean = VerificarMesEnvioDiferente(conexão, mesSelecionado, listaMensalDiferente)

            ' Exibir mensagem sobre o mês de envio diferente
            If mesEnvioDiferente Then
                '  MessageBox.Show("Mês Diferente do atual.", "Mês de Envio Diferente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' MessageBox.Show("Não foram encontrados parcelamentos com mês diferente.", "Mês de Envio Diferente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Exibir o resultado no Label
            ExibirAviso(temLembrete, mesEnvioDiferente)


        End Using
    End Sub

    Private Function VerificarLembreteParaDia(ByVal conexão As SqlConnection, ByVal dataSelecionada As DateTime, ByRef listaLembretes As List(Of DateTime)) As Boolean
        ' SQL para selecionar os lembretes com a data sem hora
        Dim sql As String = "SELECT DataLembrete FROM Parcelamentos WHERE DataLembrete IS NOT NULL"

        Using comando As New SqlCommand(sql, conexão)
            Using leitor As SqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    ' Pegando a data de lembrete
                    Dim dataLembrete As String = leitor("DataLembrete").ToString().Trim()

                    ' Verifica se a dataLembrete não está vazia ou em formato inválido
                    If Not String.IsNullOrWhiteSpace(dataLembrete) Then
                        ' Tenta converter dataLembrete para DateTime
                        Dim dataLembreteFormatada As DateTime
                        If DateTime.TryParseExact(dataLembrete.Substring(0, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dataLembreteFormatada) Then
                            ' Adiciona a data formatada na lista
                            listaLembretes.Add(dataLembreteFormatada)
                        End If
                    End If
                End While
            End Using
        End Using

        ' Verifica se a dataSelecionada está presente na lista de lembretes
        If listaLembretes.Contains(dataSelecionada.Date) Then
            Return True
        Else
            Return False
        End If
    End Function





    Private Function VerificarMesEnvioDiferente(conexao As SqlConnection, mesSelecionado As Integer, ByRef listaMensalDiferente As List(Of DateTime)) As Boolean
        ' Verifica se algum parcelamento tem FinalizadoMesGeral em um mês diferente do mês da data selecionada
        Dim comando As New SqlCommand("SELECT FinalizadoMesGeral FROM Parcelamentos", conexao)
        Dim leitor As SqlDataReader = comando.ExecuteReader()

        Dim mesEnvioDiferente As Boolean = False

        ' Dicionário para mapear o nome do mês para o número correspondente
        Dim meses As New Dictionary(Of String, Integer) From {
        {"Janeiro", 1}, {"Fevereiro", 2}, {"Março", 3}, {"Abril", 4},
        {"Maio", 5}, {"Junho", 6}, {"Julho", 7}, {"Agosto", 8},
        {"Setembro", 9}, {"Outubro", 10}, {"Novembro", 11}, {"Dezembro", 12}
    }

        While leitor.Read()
            ' Pegando o valor de FinalizadoMesGeral, que pode ser o nome do mês
            Dim mesFinalizado As String = leitor("FinalizadoMesGeral").ToString()

            ' Mostrar o nome do mês extraído do banco de dados para depuração
            ' MessageBox.Show("Mês Finalizado (do banco): " & mesFinalizado)

            ' Verifica se o mês está no dicionário e converte para número
            If meses.ContainsKey(mesFinalizado) Then
                Dim mesFinalizadoNumero As Integer = meses(mesFinalizado)

                ' Verifica se o mês extraído do banco de dados é diferente do mês selecionado
                If mesFinalizadoNumero <> mesSelecionado Then
                    listaMensalDiferente.Add(New DateTime(DateTime.Now.Year, mesFinalizadoNumero, 1)) ' Cria uma data com o mês e o ano atual
                    mesEnvioDiferente = True
                End If
            End If
        End While
        leitor.Close()

        Return mesEnvioDiferente
    End Function


    ' Função para converter o nome do mês em número
    Private Function ObterNumeroMes(mesNome As String) As Integer
        Select Case mesNome
            Case "janeiro"
                Return 1
            Case "fevereiro"
                Return 2
            Case "março", "marco"
                Return 3
            Case "abril"
                Return 4
            Case "maio"
                Return 5
            Case "junho"
                Return 6
            Case "julho"
                Return 7
            Case "agosto"
                Return 8
            Case "setembro"
                Return 9
            Case "outubro"
                Return 10
            Case "novembro"
                Return 11
            Case "dezembro"
                Return 12
            Case Else
                Return 0 ' Caso o mês não seja encontrado
        End Select
    End Function


    Private Sub ExibirAviso(temLembrete As Boolean, mesEnvioDiferente As Boolean)
        ' Atualiza o label com base nos resultados
        If temLembrete AndAlso mesEnvioDiferente Then
            LblParcelamentosAviso.Text = "Parcelamento Mensal e Lembrete"
            LblParcelamentosAviso.Visible = True
            IniciarPiscarLabel()
        ElseIf temLembrete Then
            LblParcelamentosAviso.Text = "Lembrete Parcelamento"
            LblParcelamentosAviso.Visible = True
            IniciarPiscarLabel()
        ElseIf mesEnvioDiferente Then
            LblParcelamentosAviso.Text = "Parcelamento Mensal"
            LblParcelamentosAviso.Visible = True
            IniciarPiscarLabel()
        Else
            LblParcelamentosAviso.Visible = False
        End If
    End Sub

    Private Sub IniciarPiscarLabel()
        ' Configura o Timer para piscar o texto do label
        Timer1.Interval = 400 ' Intervalo de 500ms para alternar as cores
        Timer1.Start()
    End Sub

    ' Timer que alterna as cores do label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If LblParcelamentosAviso.ForeColor = Color.Red Then
            LblParcelamentosAviso.ForeColor = Color.White
        ElseIf LblParcelamentosAviso.ForeColor = Color.White Then
            LblParcelamentosAviso.ForeColor = Color.Yellow
        Else
            LblParcelamentosAviso.ForeColor = Color.Red
        End If
    End Sub

End Class