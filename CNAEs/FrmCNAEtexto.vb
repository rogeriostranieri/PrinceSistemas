Imports System.Data.SqlClient
Public Class FrmCNAEtexto
    ReadOnly connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

    Private Sub FrmCNAEtexto_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmCNAEtexto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmCNAEtexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosCNAE()
    End Sub

    Private Sub CarregarDadosCNAE()
        If FormulariosAbertos() Then
            Dim cnaes As String() = PegarCNAEsDosFormularios()
            ProcurarCNAEsNoBanco(cnaes)
        End If
    End Sub

    Private Function FormulariosAbertos() As Boolean
        Return (CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao) IsNot Nothing Or
                CType(Application.OpenForms("FrmAlvara"), FrmAlvara) IsNot Nothing)
    End Function

    Private Function PegarCNAEsDosFormularios() As String()
        Dim cnaes As New List(Of String)

        If Application.OpenForms("FrmLegalizacao") IsNot Nothing Then
            Dim frmLegalizacao As FrmLegalizacao = CType(Application.OpenForms("FrmLegalizacao"), FrmLegalizacao)
            cnaes.Add(frmLegalizacao.CNAEPrincipalTextBox.Text)
            cnaes.AddRange(frmLegalizacao.CNAESecundarioRichTextBox.Lines)
        End If

        If Application.OpenForms("FrmAlvara") IsNot Nothing Then
            Dim frmAlvara As FrmAlvara = CType(Application.OpenForms("FrmAlvara"), FrmAlvara)
            cnaes.Add(frmAlvara.CNAEPrimarioTextBox.Text)
            cnaes.AddRange(frmAlvara.CNAERichTextBox.Lines)
        End If

        Return cnaes.ToArray()
    End Function

    Private Sub ProcurarCNAEsNoBanco(cnaes As String())
        Using conexao As New SqlConnection(connectionString)
            conexao.Open()

            For Each cnae As String In cnaes
                Using comando As New SqlCommand("SELECT Subclasse, descrição FROM CNAESubclasses23 WHERE Subclasse = @cnae", conexao)
                    comando.Parameters.AddWithValue("@cnae", cnae)

                    Dim resultado As SqlDataReader = comando.ExecuteReader()

                    If resultado.Read() Then
                        AdicionarCNAENoRichTextBox(cnae, resultado("descrição").ToString())
                    Else
                        AdicionarCNAENaoEncontradoNoBanco(cnae)
                    End If

                    resultado.Close()
                End Using
            Next
        End Using
    End Sub

    Private Sub AdicionarCNAENoRichTextBox(cnae As String, descrição As String)
        With RichTextBox1
            .AppendText(cnae)
            .SelectionColor = Color.Black
            .AppendText(" - ")
            .SelectionFont = New Font(.Font, FontStyle.Bold)
            .SelectionColor = Color.Black
            .SelectionFont = New Font(.Font, FontStyle.Regular)
            .AppendText(descrição & vbCrLf)
        End With
    End Sub

    Private Sub AdicionarCNAENaoEncontradoNoBanco(cnae As String)
        With RichTextBox1
            .AppendText("CNAE não encontrado no banco de dados: ")
            .SelectionColor = Color.Red
            .AppendText(cnae & vbCrLf)
        End With
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        ' Não é necessário fazer nada aqui
    End Sub
End Class
