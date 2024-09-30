Imports System.Data.SqlClient

Public Class FrmFiliais
    Private _cnpjBase As String

    Private _chamador As Form ' Referência ao formulário chamador

    ' Construtor que recebe o CNPJ base e o formulário chamador
    Public Sub New(cnpjBase As String, chamador As Form)
        InitializeComponent()
        _cnpjBase = cnpjBase
        _chamador = chamador
    End Sub


    ' Evento Load do Formulário
    ' Evento Load do Formulário
    Private Sub FrmFiliais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TypeOf _chamador Is FrmLegalizacao Then
            ' A lógica quando o formulário chamador é o FrmLegalizacao
            CarregarEmpresas()
        ElseIf TypeOf _chamador Is FrmAlvara Then
            ' A lógica quando o formulário chamador é o FrmAlvara
            CarregarAlvara()
        End If

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

    Private Sub CarregarAlvara()
        Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
        Dim query As String = "SELECT RazaoSocial, CNPJ FROM Laudos WHERE CNPJ LIKE @CNPJBase + '%'"

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

            If TypeOf _chamador Is FrmLegalizacao Then
                ' Se o FrmLegalizacao estiver aberto, atualiza os ComboBox e traz o formulário para frente
                Dim frmLegalizacao As FrmLegalizacao = DirectCast(_chamador, FrmLegalizacao)
                frmLegalizacao.SalvarExterno()
                frmLegalizacao.ComboBoxBuscaEmpresa.Text = razaoSocial
                frmLegalizacao.ComboBoxBuscaCNPJ.Text = cnpj
                frmLegalizacao.BringToFront()
            ElseIf TypeOf _chamador Is FrmAlvara Then
                ' Se o FrmAlvara estiver aberto, atualiza os ComboBox e traz o formulário para frente
                Dim frmAlvara As FrmAlvara = DirectCast(_chamador, FrmAlvara)
                frmAlvara.SalvarExterno()
                frmAlvara.ComboBoxBuscaAlvara.Text = razaoSocial
                frmAlvara.ComboBoxBuscaCNPJ.Text = cnpj
                frmAlvara.BringToFront()
            End If
            FrmLegalizacao.BtnEditar.PerformClick()
            Me.Close()
        End If
    End Sub


    ' Ajuste o tamanho do DataGridView para mostrar os dados encontrados
    Private Sub AjustarTamanhoDataGridView()
        DataGridViewEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewEmpresa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DataGridViewEmpresa.Columns("RazaoSocial").MinimumWidth = 150
        DataGridViewEmpresa.Columns("CNPJ").MinimumWidth = 100

        Dim totalWidth As Integer = 0
        For Each column As DataGridViewColumn In DataGridViewEmpresa.Columns
            totalWidth += column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, True)
        Next

        DataGridViewEmpresa.Width = totalWidth + 20 ' Adiciona uma margem

        Dim totalHeight As Integer = 0
        For Each row As DataGridViewRow In DataGridViewEmpresa.Rows
            totalHeight += row.Height
        Next

        DataGridViewEmpresa.Height = totalHeight + 40 ' Adiciona uma margem

        DataGridViewEmpresa.Dock = DockStyle.None ' Remover o preenchimento para ajustar manualmente
    End Sub

    Private Sub AjustarTamanhoFormulario()
        ' Desativar a exibição do cabeçalho de linha
        DataGridViewEmpresa.RowHeadersVisible = False

        ' Ajustar o tamanho do formulário com base no DataGridView
        Dim width As Integer = DataGridViewEmpresa.Width + 40
        Dim height As Integer = DataGridViewEmpresa.Height + 100

        ' Definir valores máximos para largura e altura do formulário
        Dim maxWidth As Integer = 800 ' Ajuste conforme necessário
        Dim maxHeight As Integer = 600 ' Ajuste conforme necessário

        ' Limitar largura e altura ao máximo permitido
        width = Math.Min(width, maxWidth)
        height = Math.Min(height, maxHeight)

        ' Ajustar o tamanho do formulário
        Me.Size = New Size(width, height)

        ' Permitir o ajuste automático do tamanho do formulário
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

End Class
