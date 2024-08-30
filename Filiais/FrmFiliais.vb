Imports System.Data.SqlClient

Public Class FrmFiliais
    Private _cnpjBase As String

    Private Sub FrmFiliais_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica se a tecla ESC foi pressionada
        If e.KeyCode = Keys.Escape Then
            ' Fecha o formulário
            Me.Close()
        End If
    End Sub


    ' Construtor que recebe o CNPJ base
    Public Sub New(cnpjBase As String)
        InitializeComponent()
        _cnpjBase = cnpjBase
    End Sub

    ' Evento Load do Formulário
    Private Sub FrmFiliais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os dados das filiais ao iniciar o formulário
        CarregarEmpresas()
        Me.KeyPreview = True

    End Sub

    ' Método para carregar empresas na DataGridView
    Private Sub CarregarEmpresas()
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT RazaoSocial, CNPJ FROM Empresas WHERE CNPJ LIKE @CNPJBase + '%'"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CNPJBase", _cnpjBase)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar dados: " & ex.Message)
                End Try

                DataGridViewEmpresa.DataSource = dt

            End Using
        End Using


        ' Ajustar o DataGridView e o formulário após o carregamento dos dados
        AjustarTamanhoDataGridView()
        AjustarTamanhoFormulario()
    End Sub

    ' Evento de clique duplo na célula do DataGridView
    Private Sub DataGridViewEmpresa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmpresa.CellDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            ' Obtém o valor da Razão Social e CNPJ da célula clicada
            Dim razaoSocial As String = DataGridViewEmpresa.Rows(e.RowIndex).Cells("RazaoSocial").Value.ToString()
            Dim cnpj As String = DataGridViewEmpresa.Rows(e.RowIndex).Cells("CNPJ").Value.ToString()

            ' Verifica se o FrmLegalizacao está aberto
            Dim frmLegalizacao As FrmLegalizacao = Application.OpenForms.OfType(Of FrmLegalizacao)().FirstOrDefault()

            If frmLegalizacao IsNot Nothing Then
                ' Se o FrmLegalizacao estiver aberto, atualiza os ComboBox e traz o formulário para frente
                frmLegalizacao.SalvarExterno()
                frmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocial
                frmLegalizacao.ComboBoxBuscaCNPJ.Text = cnpj
                frmLegalizacao.BringToFront()
            Else
                ' Se o FrmLegalizacao não estiver aberto, cria uma nova instância e exibe
                Dim novoFrmLegalizacao As New FrmLegalizacao()
                novoFrmLegalizacao.Show()
                'frmLegalizacao.SalvarExterno()
                novoFrmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocial
                novoFrmLegalizacao.ComboBoxBuscaCNPJ.Text = cnpj
                novoFrmLegalizacao.BringToFront()
            End If
        End If
    End Sub

    ' ////////////////// TAMANHO FORM adaptativo
    Private Sub AjustarTamanhoDataGridView()
        ' Ajusta o DataGridView para mostrar os dados encontrados
        DataGridViewEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewEmpresa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Ajusta a largura mínima das colunas
        DataGridViewEmpresa.Columns("RazaoSocial").MinimumWidth = 150
        DataGridViewEmpresa.Columns("CNPJ").MinimumWidth = 100

        ' Calcula a largura total das colunas
        Dim totalWidth As Integer = 0
        For Each column As DataGridViewColumn In DataGridViewEmpresa.Columns
            totalWidth += column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, True)
        Next

        ' Define a largura total do DataGridView
        DataGridViewEmpresa.Width = totalWidth + 20 ' Adiciona uma margem

        ' Calcula a altura total das linhas
        Dim totalHeight As Integer = 0
        For Each row As DataGridViewRow In DataGridViewEmpresa.Rows
            totalHeight += row.Height
        Next

        ' Define a altura total do DataGridView
        DataGridViewEmpresa.Height = totalHeight + 40 ' Adiciona uma margem

        ' Ajusta o DataGridView para preencher o formulário pai
        DataGridViewEmpresa.Dock = DockStyle.None ' Remover o preenchimento para ajustar manualmente
    End Sub

    Private Sub AjustarTamanhoFormulario()
        ' Ajusta o tamanho do formulário com base no tamanho do DataGridView
        Dim width As Integer = DataGridViewEmpresa.Width + 40
        Dim height As Integer = DataGridViewEmpresa.Height + 100

        ' Define limites máximos para o tamanho do formulário
        Dim maxWidth As Integer = 800 ' Ajuste conforme necessário
        Dim maxHeight As Integer = 600 ' Ajuste conforme necessário

        width = Math.Min(width, maxWidth)
        height = Math.Min(height, maxHeight)

        ' Define o tamanho do formulário
        Me.Size = New Size(width, height)

        ' Ajusta o formulário para preencher o conteúdo
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub


End Class