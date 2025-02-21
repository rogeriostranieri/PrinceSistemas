Imports PrinceSistemas.PrinceDBDataSet

Public Class FrmBrasilCidadesGeral
    Public Property CidadeSelecionada As String
        Get
            Return _cidadeSelecionada
        End Get
        Set(value As String)
            _cidadeSelecionada = value
        End Set
    End Property

    Public Property DistritoSelecionado As String
        Get
            Return _distritoSelecionado
        End Get
        Set(value As String)
            _distritoSelecionado = value
        End Set
    End Property

    Private _cidadeSelecionada As String
    Private _distritoSelecionado As String

    Public Property EstadoSelecionado As String
        Get
            ' Retorna o nome do estado baseado na seleção atual do ComboBox
            If ComboBox1.SelectedItem IsNot Nothing Then
                Dim estadoRow As BrasilEstadoRow = CType(ComboBox1.SelectedItem, BrasilEstadoRow)
                Return estadoRow.nome ' Acesse diretamente a propriedade 'nome' da linha
            End If
            Return String.Empty
        End Get
        Set(value As String)
            ' Você pode deixar vazio, pois não será usado para configuração
        End Set
    End Property





    Private Sub FrmBrasilCidadesGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar os estados no ComboBox
        Me.BrasilEstadoTableAdapter.Fill(Me.PrinceDBDataSet.BrasilEstado)

        ' Ordenar estados em ordem alfabética
        Dim estadosOrdenados = From estado In Me.PrinceDBDataSet.BrasilEstado
                               Order By estado.nome
                               Select estado

        ' Preencher ComboBox com os estados
        ComboBox1.DisplayMember = "nome"  ' Nome do estado
        ComboBox1.ValueMember = "codigo_uf"  ' Código do estado
        ComboBox1.DataSource = estadosOrdenados.ToList()

        ' Configurar ListView
        ListView1.View = View.Details
        ListView1.Columns.Add("Cidade", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Distrito", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Estado", 100, HorizontalAlignment.Left)

        ' Configurar AutoComplete
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Function RemoverAcentos(texto As String) As String
        If String.IsNullOrEmpty(texto) Then Return texto ' Verifica se o texto é nulo ou vazio

        Dim acentuado As Char() = {"á", "à", "ã", "â", "é", "ê", "í", "ó", "ô", "ú", "ç"}
        Dim semAcento As Char() = {"a", "a", "a", "a", "e", "e", "i", "o", "o", "u", "c"}

        For i As Integer = 0 To acentuado.Length - 1
            texto = texto.Replace(acentuado(i), semAcento(i))
            texto = texto.Replace(acentuado(i).ToString().ToUpper(), semAcento(i).ToString().ToUpper()) ' Para maiúsculas
        Next

        Return texto.ToLower()
    End Function



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Limpar ListView e TextBox ao mudar o estado
        ListView1.Items.Clear()
        TextBox1.Text = ""

        ' Obter o código do estado selecionado
        Dim codigoUF As Integer = CInt(ComboBox1.SelectedValue)

        ' Carregar as cidades e distritos correspondentes ao estado selecionado
        Me.BrasilMunicipiosTableAdapter.FillByCodigoUF(Me.PrinceDBDataSet.BrasilMunicipios, codigoUF)
        Me.BrasilDistritosTableAdapter.FillByCodigoUF(Me.PrinceDBDataSet.BrasilDistritos, codigoUF)

        ' Preencher o ListView com as cidades e distritos desse estado
        PreencherListView(codigoUF)
    End Sub

    Private Sub PreencherListView(codigoUF As Integer, Optional filtro As String = "")
        Try
            ListView1.Items.Clear()
            TxtEncontrado.Text = ""

            Dim estadoSelecionado = Me.PrinceDBDataSet.BrasilEstado.FindBycodigo_uf(codigoUF)

            Dim cidades = From municipio In Me.PrinceDBDataSet.BrasilMunicipios
                          Join distrito In Me.PrinceDBDataSet.BrasilDistritos
                      On municipio.codigo_ibge Equals distrito.id_municipio
                          Where municipio.codigo_uf = codigoUF AndAlso
                            (RemoverAcentos(municipio.nome.ToLower()).Contains(filtro) Or
                             RemoverAcentos(distrito.nome.ToLower()).Contains(filtro))
                          Select New With {
                          .NomeCidade = municipio.nome,
                          .NomeDistrito = If(distrito.nome <> municipio.nome, distrito.nome, Nothing),
                          .NomeEstado = estadoSelecionado.nome
                      }

            Dim resultadoCount As Integer = 0

            For Each cidade In cidades
                Dim item As New ListViewItem(cidade.NomeCidade)
                item.SubItems.Add(If(String.IsNullOrEmpty(cidade.NomeDistrito), "", cidade.NomeDistrito))
                item.SubItems.Add(cidade.NomeEstado)

                ListView1.Items.Add(item)
                resultadoCount += 1
            Next

            TxtEncontrado.Text = $"Encontrado {resultadoCount} resultados"
            AjustarTamanhoColunas()
            AjustarTamanhoFormulario()

        Catch ex As Exception
            ' Exibir uma mensagem de erro, sem fechar o aplicativo
            MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub AjustarTamanhoFormulario()
        ' Manter o tamanho padrão do formulário
        Dim newWidth As Integer = Math.Max(424, ListView1.Width + 20) ' Adiciona margem
        Me.Size = New Size(newWidth, 489)

        ' Ajustar a largura do TableLayoutPanel
        TableLayoutPanel1.Width = Me.ClientSize.Width - 20 ' Margem para bordas
    End Sub




    Private Sub AjustarTamanhoColunas()
        ' Ajustar automaticamente o tamanho das colunas
        For Each column As ColumnHeader In ListView1.Columns
            column.Width = -2 ' -2 faz o auto resize
        Next
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim codigoUF As Integer = CInt(ComboBox1.SelectedValue)
        Dim filtro As String = RemoverAcentos(TextBox1.Text)

        ' Filtrar cidades e distritos
        PreencherListView(codigoUF, filtro)
    End Sub


    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim filtro As String = ComboBox1.Text.ToLower()

        ' Filtrar os estados conforme o texto digitado
        Dim estadosFiltrados = From estado In Me.PrinceDBDataSet.BrasilEstado
                               Where estado.nome.ToLower().Contains(filtro) Or estado.uf.ToLower().Contains(filtro)
                               Select estado

        ' Atualizar a DataSource do ComboBox
        If estadosFiltrados.Any() Then
            ComboBox1.DataSource = estadosFiltrados.ToList()
            ComboBox1.DisplayMember = "nome"
            ComboBox1.ValueMember = "codigo_uf"

            ' Selecionar o primeiro item se houver resultados
            ComboBox1.SelectedIndex = -1
        Else
            ComboBox1.DataSource = Nothing
        End If
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim itemSelecionado = ListView1.SelectedItems(0)
            Dim cidade = itemSelecionado.Text
            Dim distrito = itemSelecionado.SubItems(1).Text

            ' Defina as cidades e distritos selecionados
            CidadeSelecionada = cidade
            DistritoSelecionado = If(distrito <> cidade, distrito, String.Empty) ' Não define o distrito se for igual à cidade

            ' Fechar o formulário
            Me.Close()
        End If
    End Sub


End Class
