Imports System.Data.SqlClient

Public Class FrmParabens
    ' Nome do label para evitar ambiguidade
    Public Property UsuarioLogado As String

    Private Sub FrmParabens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define o texto com formatação
        Dim textoFormatado As String = "Feliz Aniversário, " & vbCrLf & UsuarioLogado & "! " & vbCrLf &
                                       "Hoje é um dia especial," & vbCrLf &
                                       "e você merece toda a alegria do mundo!"

        ' Habilita a detecção de negrito e quebras de linha
        RichTextBox1.Clear()
        RichTextBox1.SelectionFont = New Font("Arial", 14, FontStyle.Bold)
        RichTextBox1.AppendText("Feliz Aniversário, " & vbCrLf & UsuarioLogado & "! " & vbCrLf & vbCrLf)

        ' Adiciona o texto normal
        RichTextBox1.SelectionFont = New Font("Arial", 12, FontStyle.Regular)
        RichTextBox1.AppendText("Hoje é um dia especial," & vbCrLf & "e você merece toda a alegria do mundo!")

        ' Centraliza o texto no RichTextBox
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center

        ' Remove a possibilidade de editar o RichTextBox
        RichTextBox1.ReadOnly = True
        RichTextBox1.BorderStyle = BorderStyle.None

        ' Configura a PictureBox para preencher a célula corretamente
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        ' Ajusta as configurações do TableLayoutPanel
        ' Definir a primeira linha como AutoSize (altura baseada no conteúdo)
        TableLayoutPanel1.RowStyles(0).SizeType = SizeType.AutoSize
        ' Definir a segunda linha para ocupar o restante do espaço
        TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Percent
        TableLayoutPanel1.RowStyles(1).Height = 100

        ' Configura o layout da coluna para preencher horizontalmente
        TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
        TableLayoutPanel1.ColumnStyles(0).Width = 100

        ' Define a janela como maximizada
        Me.WindowState = FormWindowState.Maximized

        ' Ativa a captura de teclas
        Me.KeyPreview = True
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    ' Captura o evento KeyDown para detectar quando o usuário pressionar a tecla ESC
    Private Sub FrmParabens_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close() ' Fecha o formulário ao pressionar ESC
        End If
    End Sub
End Class
