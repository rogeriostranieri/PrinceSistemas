Public Class FrmBuscaAnotacoes

    Private Sub FrmBuscaAnotacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'FrmAnotacoes.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True

        Me.Focus()
        Me.CenterToScreen()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim index As Integer = 0
        'Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find((TextBoxLocalizar.Text, RichTextBoxFinds.Reverse)
        Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizar.Text, 0, RichTextBoxFinds.Reverse)
        While index < lastIndex
            index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizar.Text, index, RichTextBoxFinds.None)
            FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.Yellow
            FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Red
            index += 1
        End While
    End Sub

    Private Sub ButtonLimparSelecao_Click(sender As Object, e As EventArgs) Handles ButtonLimparSelecao.Click
        Dim index As Integer = 0
        'Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find((TextBoxLocalizar.Text, RichTextBoxFinds.Reverse)
        Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizar.Text, 0, RichTextBoxFinds.Reverse)
        While index < lastIndex
            index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizar.Text, index, RichTextBoxFinds.None)
            FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.White
            FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Black
            index += 1
        End While
    End Sub

    Private Sub ButtonSubstituir_Click(sender As Object, e As EventArgs) Handles ButtonSubstituir.Click

        Try
            'mensagem para subistituir 

            Dim message As String

            'MOSTRA MENSAGM BOX
            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Deseja realmente substituir: " & TextBoxLocalizaSub.Text & " = por: " & TextBoxSubstituir.Text & ", em todo texto que está aberto?")

            'mostra mensagem box SIM OU NAO OU CANCELA
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                'nao faz nada
            ElseIf result = DialogResult.Yes Then
                Try
                    Dim index As Integer = 0
                    Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizaSub.Text, 0, RichTextBoxFinds.Reverse)
                    While index < lastIndex
                        index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizaSub.Text, index, RichTextBoxFinds.None)
                        FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.Yellow
                        FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Red
                        FrmAnotacoes.RichTextBoxAnotacao.SelectedText = TextBoxSubstituir.Text
                        index += 1
                    End While
                    MessageBox.Show(TextBoxLocalizaSub.Text & " foi Substituido por: " & TextBoxSubstituir.Text & ", em todo texto!")

                Catch error_t As Exception
                    MsgBox(error_t.ToString)
                End Try

            End If

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try


    End Sub

    Private Sub BtnBuscaSub_Click(sender As Object, e As EventArgs) Handles BtnBuscaSub.Click
        Dim index As Integer = 0
        'Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find((TextBoxLocalizar.Text, RichTextBoxFinds.Reverse)
        Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizaSub.Text, 0, RichTextBoxFinds.Reverse)
        While index < lastIndex
            index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizaSub.Text, index, RichTextBoxFinds.None)
            FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.Yellow
            FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Red
            index += 1
        End While
    End Sub

    Private Sub BtnLimpaSub_Click(sender As Object, e As EventArgs) Handles BtnLimpaSub.Click
        Dim index As Integer = 0
        'Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find((TextBoxLocalizar.Text, RichTextBoxFinds.Reverse)
        Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizaSub.Text, 0, RichTextBoxFinds.Reverse)
        Dim lastIndex1 As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxSubstituir.Text, 0, RichTextBoxFinds.Reverse)

        If index < lastIndex Then
            While index < lastIndex
                index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizaSub.Text, index, RichTextBoxFinds.None)
                FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.White
                FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Black
                index += 1
            End While
        Else
            While index < lastIndex1
                index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxSubstituir.Text, index, RichTextBoxFinds.None)
                FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.White
                FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Black
                index += 1
            End While
        End If

    End Sub


End Class