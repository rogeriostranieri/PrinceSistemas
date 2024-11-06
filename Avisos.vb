Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient


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

        CarregarAvisos()

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
    '//////////////////////////// ver parcelamentos
    Private Sub CarregarAvisos()
        ' Conectar ao banco de dados e carregar dados
        Using conexão As New SqlConnection(connectionString)
            conexão.Open()

            ' Carregar dados de ParcelamentosAviso
            Dim comandoAviso As New SqlCommand("SELECT MesRealizado, Ano FROM ParcelamentosAviso", conexão)
            Dim leitorAviso As SqlDataReader = comandoAviso.ExecuteReader()

            If leitorAviso.Read() Then
                Dim mesRealizado As String = leitorAviso("MesRealizado").ToString()
                Dim ano As String = leitorAviso("Ano").ToString()

                ' Fechar o DataReader
                leitorAviso.Close()

                ' Converter a data do MaskedTextBox1 para Date
                Dim dataLembrete As Date = Date.Parse(MaskedTextBox1.Text)
                Dim mesLembrete As Integer = dataLembrete.Month
                Dim mesLembreteStr As String = dataLembrete.ToString("MMMM", Globalization.CultureInfo.InvariantCulture)

                ' Verificar se o mês de ParcelamentosAviso é diferente do mês atual
                If mesRealizado <> mesLembreteStr Then
                    ' Contar parcelamentos para a data do mês
                    Dim comandoParcelamentos As New SqlCommand("SELECT DataEnvio, FinalizadoParcelamentos FROM Parcelamentos WHERE YEAR(DataEnvio) = @ano AND MONTH(DataEnvio) = @mes", conexão)
                    comandoParcelamentos.Parameters.AddWithValue("@ano", dataLembrete.Year)
                    comandoParcelamentos.Parameters.AddWithValue("@mes", mesLembrete)

                    Dim leitorParcelamentos As SqlDataReader = comandoParcelamentos.ExecuteReader()

                    Dim parcelamentoNaoEnviado As Boolean = False
                    Dim todosEnviados As Boolean = True

                    While leitorParcelamentos.Read()
                        ' Verificar a coluna DataEnvio e FinalizadoParcelamentos
                        Dim dataEnvio As Object = leitorParcelamentos("DataEnvio")
                        Dim finalizado As String = leitorParcelamentos("FinalizadoParcelamentos").ToString()

                        If Not IsDBNull(dataEnvio) Then
                            ' Extrair o mês e ano de DataEnvio ignorando a parte do dia e hora
                            Dim dataEnvioDate As Date = Convert.ToDateTime(dataEnvio)
                            Dim mesEnvio As Integer = dataEnvioDate.Month
                            Dim anoEnvio As Integer = dataEnvioDate.Year

                            ' Verificar se o mês e ano de DataEnvio são diferentes do mês atual
                            If mesEnvio <> mesLembrete OrElse anoEnvio <> dataLembrete.Year Then
                                ' Se não estiver finalizado
                                If finalizado = "Não" Then
                                    parcelamentoNaoEnviado = True
                                End If
                            End If

                            ' Verificar se todos os parcelamentos foram finalizados
                            If finalizado = "Não" Then
                                todosEnviados = False
                            End If
                        End If
                    End While

                    ' Fechar o DataReader de Parcelamentos
                    leitorParcelamentos.Close()

                    ' Se houver parcelamento não enviado, atualizar o label
                    If parcelamentoNaoEnviado Then
                        LblParcelamentosAviso.Text = "X - PARCELAMENTOS NÃO ENVIADOS"
                        LblParcelamentosAviso.Visible = True
                        LblParcelamentosAviso.ForeColor = Color.Red ' Cor de alerta
                        LblParcelamentosAviso.Enabled = True
                    ElseIf todosEnviados Then
                        ' Se todos os parcelamentos estão finalizados, mostrar que tudo foi enviado
                        LblParcelamentosAviso.Text = "PARCELAMENTOS ENVIADOS"
                        LblParcelamentosAviso.Visible = True
                        LblParcelamentosAviso.ForeColor = Color.Green ' Cor positiva
                        LblParcelamentosAviso.Enabled = True
                    Else
                        ' Caso contrário, mostrar uma mensagem de alerta genérica
                        LblParcelamentosAviso.Text = "Alguns parcelamentos não foram finalizados."
                        LblParcelamentosAviso.Visible = True
                        LblParcelamentosAviso.ForeColor = Color.Orange ' Cor de alerta moderado
                        LblParcelamentosAviso.Enabled = True
                    End If
                Else
                    ' Se o mês do ParcelamentosAviso for igual ao mês atual, esconder o aviso
                    LblParcelamentosAviso.Text = ""
                    LblParcelamentosAviso.Visible = False
                    LblParcelamentosAviso.Enabled = False
                End If
            Else
                ' Se não houver dados no ParcelamentosAviso, esconder o aviso
                LblParcelamentosAviso.Text = ""
                LblParcelamentosAviso.Visible = False
                LblParcelamentosAviso.Enabled = False
            End If
        End Using
    End Sub




    ' ///////////// FIM PARCELAMENTO
    Private Sub timerParcelamentos_Tick(sender As Object, e As EventArgs) Handles timerParcelamentos.Tick
        contador += 1
        LblParcelamentosAviso.ForeColor = cores(contador Mod 3)
    End Sub

    Private Sub LblParcelamentosAviso_Click(sender As Object, e As EventArgs) Handles LblParcelamentosAviso.Click
        ' Verifica se já existe uma instância aberta de FrmProtocoladosGeral
        Dim AvisoProtocolo As FrmAvisoParcelamento = Application.OpenForms.OfType(Of FrmAvisoParcelamento)().FirstOrDefault()

        ' Se já existir uma instância, foca no formulário
        If AvisoProtocolo IsNot Nothing Then
            AvisoProtocolo.Focus()
        Else
            ' Se não existir, cria uma nova instância e define o MDI parent
            AvisoProtocolo = New FrmAvisoParcelamento()
            AvisoProtocolo.MdiParent = MDIPrincipal
            AvisoProtocolo.Show()
        End If
    End Sub

    'FIM parcelamentos
End Class