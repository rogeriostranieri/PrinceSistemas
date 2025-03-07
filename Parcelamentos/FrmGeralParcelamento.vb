﻿Imports System.Data.SqlClient
Imports System.Text

Public Class FrmGeralParcelamento

    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"

    Public Property RazaoSocial As String
    Public Property CNPJ As String
    Public Property DataCriacao As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FrmGeralParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar os dados ao carregar o formulário
        CarregarDados()
        ' Adiciona todos os meses por extenso ao ComboBoxMesFechamento
        ComboBoxMesFechamento.Items.AddRange(New String() {
            "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
        })
        ComboBoxMesFechamento.SelectedIndex = -1 ' Deixar vazio inicialmente
        ConfigurarColunasListView()
        CheckBoxMesFechamento.Checked = False
        MudarMesFechamento()

        ' Inicialização dos checkboxes
        CheckBoxEmAndamento.Checked = False
        CheckBoxFinalizada.Checked = False
        CheckBoxTodos.Checked = True
        CheckBoxMEI.Checked = False
        CheckBoxINSSAntigo.Checked = False
        CheckBoxINSSNovo.Checked = False
        CheckBoxINSSProcuradoria.Checked = False
    End Sub

    Private Sub ConfigurarColunasListView()
        ' Configurar o ListView para exibição em modo de detalhes (View.Details)
        ListView1.View = View.Details

        ' Permitir que o usuário reorganize as colunas
        ListView1.AllowColumnReorder = True

        ' Limpar as colunas antes de adicionar novas (caso necessário)
        ListView1.Columns.Clear()

        ' Adicionar colunas ao ListView
        ListView1.Columns.Add("Razão Social", 250)
        ListView1.Columns.Add("CNPJ", 150)
        ListView1.Columns.Add("MEI", 100)
        ListView1.Columns.Add("INSS Antigo", 100)
        ListView1.Columns.Add("INSS Novo", 100)
        ListView1.Columns.Add("INSS Procuradoria", 100)
        ListView1.Columns.Add("Finalizado", 100)
        ListView1.Columns.Add("Data-Fim", 120)

        ' Usar AddHandler para adicionar o manipulador do evento ColumnWidthChanged
        AddHandler ListView1.ColumnWidthChanged, AddressOf ListView1_ColumnWidthChanged
    End Sub

    ' Método para lidar com o evento ColumnWidthChanged
    Private Sub ListView1_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs)
        ' Adicionar código aqui para reagir à mudança na largura da coluna, se necessário
    End Sub

    Private Sub CarregarDados()
        ConfigurarColunasListView()

        Dim query As New StringBuilder("SELECT RazaoSocial, CNPJ, FormaDeEnvio, Responsavel, Whatsapp, Email, Socio, CPF, DataCriacao, DataFinalizado, MEI, InssAntigo, InssNovo, InssProcur, FinalizadoEmpresa, FinalizadoMesGeral FROM Parcelamentos WHERE 1=1")

        ' Verificar se todos os CheckBoxes estão marcados
        Dim todosSelecionados As Boolean = CheckBoxMEI.Checked AndAlso CheckBoxINSSAntigo.Checked AndAlso CheckBoxINSSNovo.Checked AndAlso CheckBoxINSSProcuradoria.Checked

        ' Filtragem para "Finalizado" e "Em Andamento"
        If CheckBoxFinalizada.Checked Then
            query.Append(" AND FinalizadoEmpresa = 'Sim'")
            DesativarCheckBoxesEspecificos()
        ElseIf CheckBoxEmAndamento.Checked Then
            query.Append(" AND FinalizadoEmpresa = 'Não'")
            AtivarCheckBoxesEspecificos()
            If CheckBoxMEI.Checked Then
                query.Append(" AND FinalizadoMEI = 'Não'")
            End If
            If CheckBoxINSSAntigo.Checked Then
                query.Append(" AND FinalizadoINSSAnt = 'Não'")
            End If
            If CheckBoxINSSNovo.Checked Then
                query.Append(" AND FinalizadoINSSNov = 'Não'")
            End If
            If CheckBoxINSSProcuradoria.Checked Then
                query.Append(" AND FinalizadoINSSProc = 'Não'")
            End If
        ElseIf CheckBoxTodos.Checked Then
            AtivarCheckBoxesEspecificos()
        End If

        ' Filtro extra de mês de fechamento (somente para "Em Andamento")
        If CheckBoxEmAndamento.Checked AndAlso ComboBoxMesFechamento.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(ComboBoxMesFechamento.SelectedItem.ToString()) Then
            Dim mesSelecionado As String = ComboBoxMesFechamento.SelectedItem.ToString()
            query.Append(" AND FinalizadoMesGeral = '" & mesSelecionado & "'")
        End If

        ' Executar a consulta SQL com o filtro aplicado
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query.ToString(), connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            connection.Open()
            adapter.Fill(dataTable)

            ' Limpar itens anteriores no ListView
            ListView1.Items.Clear()

            ' Preencher o ListView com os dados da consulta
            For Each row As DataRow In dataTable.Rows
                Dim item As New ListViewItem(row("RazaoSocial").ToString())
                item.SubItems.Add(row("CNPJ").ToString())
                item.SubItems.Add(FormatBoolean(row("MEI")))
                item.SubItems.Add(FormatBoolean(row("InssAntigo")))
                item.SubItems.Add(FormatBoolean(row("InssNovo")))
                item.SubItems.Add(FormatBoolean(row("InssProcur")))
                item.SubItems.Add(FormatBoolean(row("FinalizadoEmpresa")))
                item.SubItems.Add(If(IsDBNull(row("DataFinalizado")), String.Empty, CDate(row("DataFinalizado")).ToString("dd/MM/yyyy")))

                ListView1.Items.Add(item)
            Next

            ' Atualizar o Label com o total de empresas no ListView
            Label2.Text = "Total de Empresas: " & ListView1.Items.Count.ToString()
        End Using
    End Sub

    Private Sub DesativarCheckBoxesEspecificos()
        CheckBoxMEI.Enabled = False
        CheckBoxINSSAntigo.Enabled = False
        CheckBoxINSSNovo.Enabled = False
        CheckBoxINSSProcuradoria.Enabled = False
        CheckBoxMEI.Checked = False
        CheckBoxINSSAntigo.Checked = False
        CheckBoxINSSNovo.Checked = False
        CheckBoxINSSProcuradoria.Checked = False
    End Sub

    Private Sub AtivarCheckBoxesEspecificos()
        CheckBoxMEI.Enabled = True
        CheckBoxINSSAntigo.Enabled = True
        CheckBoxINSSNovo.Enabled = True
        CheckBoxINSSProcuradoria.Enabled = True
    End Sub

    ' Event handlers for checkboxes
    Private Sub CheckBoxStatus_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmAndamento.CheckedChanged, CheckBoxFinalizada.CheckedChanged, CheckBoxTodos.CheckedChanged
        Dim cb As CheckBox = DirectCast(sender, CheckBox)
        If cb.Checked Then
            If cb.Name = "CheckBoxTodos" Then
                CheckBoxEmAndamento.Checked = False
                CheckBoxFinalizada.Checked = False
            Else
                CheckBoxTodos.Checked = False
            End If
        End If
        CarregarDados()
    End Sub

    Private Sub CheckBoxSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMEI.CheckedChanged, CheckBoxINSSAntigo.CheckedChanged, CheckBoxINSSNovo.CheckedChanged, CheckBoxINSSProcuradoria.CheckedChanged
        If CheckBoxEmAndamento.Checked Then
            CarregarDados()
        End If
    End Sub

    Private Sub ComboBoxMesFechamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMesFechamento.SelectedIndexChanged
        CarregarDados()
    End Sub

    ' Função para remover acentos
    Private Function RemoveDiacritics(ByVal text As String) As String
        Dim stForm As String = text.Normalize(NormalizationForm.FormD)
        Dim sb As New StringBuilder()

        For Each c As Char In stForm
            If Char.GetUnicodeCategory(c) <> Globalization.UnicodeCategory.NonSpacingMark Then
                sb.Append(c)
            End If
        Next

        Return sb.ToString()
    End Function

    Private Sub TextBoxBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        Dim busca As String = TextBoxBusca.Text.ToLower()
        busca = RemoveDiacritics(busca)

        CarregarDados()

        If String.IsNullOrWhiteSpace(busca) Then
            Label2.Text = "Total de Empresas Encontradas: " & ListView1.Items.Count.ToString()
            Return
        End If

        Dim empresasEncontradas As Integer = 0
        For i As Integer = ListView1.Items.Count - 1 To 0 Step -1
            Dim item As ListViewItem = ListView1.Items(i)
            Dim razaoSocial As String = item.SubItems(0).Text.ToLower()
            razaoSocial = RemoveDiacritics(razaoSocial)

            If Not razaoSocial.Contains(busca) Then
                ListView1.Items.RemoveAt(i)
            Else
                empresasEncontradas += 1
            End If
        Next

        Label2.Text = "Total de Empresas Encontradas: " & empresasEncontradas.ToString()
    End Sub

    Private Sub CheckBoxMesFechamento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMesFechamento.CheckedChanged
        MudarMesFechamento()
    End Sub

    Private Sub MudarMesFechamento()
        If CheckBoxMesFechamento.Checked Then
            LabelEscolhaMes.Visible = True
            ComboBoxMesFechamento.Visible = True
            Dim mesAtual As String = DateTime.Now.ToString("MMMM", New Globalization.CultureInfo("pt-BR"))
            ComboBoxMesFechamento.SelectedItem = mesAtual
        Else
            LabelEscolhaMes.Visible = False
            ComboBoxMesFechamento.Visible = False
            ComboBoxMesFechamento.Text = ""
        End If
        CarregarDados()
    End Sub

    Private Sub PictureBoxFECHAR_Click(sender As Object, e As EventArgs) Handles PictureBoxFECHAR.Click
        Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim itemSelecionado As ListViewItem = ListView1.SelectedItems(0)
            Dim razaoSocial As String = itemSelecionado.SubItems(0).Text

            FrmParcelamento.Show()
            FrmParcelamento.ComboBoxBuscarRazaoSocial.Text = razaoSocial
            FrmParcelamento.Focus()
            FrmParcelamento.ComboBoxBuscarRazaoSocial.Focus()
        End If
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        ConfigurarColunasListView()
        CheckBoxMesFechamento.Checked = False
        CheckBoxEmAndamento.Checked = False
        CheckBoxFinalizada.Checked = False
        CheckBoxTodos.Checked = True
        CheckBoxMEI.Checked = False
        CheckBoxINSSAntigo.Checked = False
        CheckBoxINSSNovo.Checked = False
        CheckBoxINSSProcuradoria.Checked = False
        MudarMesFechamento()
        CarregarDados()
    End Sub

    ' Helper function to format boolean values in the database as "Sim" or "Não"
    Private Function FormatBoolean(value As Object) As String
        If IsDBNull(value) Then
            Return String.Empty
        ElseIf value.ToString().Equals("True", StringComparison.OrdinalIgnoreCase) OrElse value.ToString().Equals("Checked", StringComparison.OrdinalIgnoreCase) Then
            Return "Sim"
        Else
            Return "Não"
        End If
    End Function

End Class