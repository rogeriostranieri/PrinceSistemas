Imports System.Data.SqlClient
Imports System.Drawing.Text


Public Class FrmAnotacoes


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub FrmAnotacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True


        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Anotacoes'. Você pode movê-la ou removê-la conforme necessário.
        Me.AnotacoesTableAdapter.Fill(Me.PrinceDBDataSet.Anotacoes)

        'carrega fonte
        Fontesinstaladas()

        'carrega

        RichTextBoxAnotacao.Visible = False
        lblMudaTexto.Visible = False


        cbotamanho.DropDownStyle = ComboBoxStyle.DropDownList


        ' Dim Tamanhos As String = "6, 7, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72"


        Dim Tamanhos As String = ("6, 7, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72")

        cbotamanho.Items.AddRange(Tamanhos.Split(","))

        cbotamanho.SelectedIndex = 6

    End Sub

    Private Sub FrmAnotacoes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salvar()
    End Sub

    Private Sub Salvar()

        Dim changedRecords As System.Data.DataTable
        Me.AnotacoesBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.Anotacoes.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'MOSTRA MENSAGM BOX
            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

            'mostra mensagem box SIM OU NAO OU CANCELA
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                ' e.Cancel = True
            ElseIf result = DialogResult.No Then
                ' AnotacoesBindingSource.fill(PrinceDBDataSet.Anotacoes)
                AnotacoesBindingSource.CancelEdit() 'teste pois nao funcionou o modo antigo


            ElseIf result = DialogResult.Yes Then
                Try
                    'Salva alterações
                    Me.Validate()
                    Me.AnotacoesBindingSource.EndEdit()
                    Me.AnotacoesTableAdapter.Update(Me.PrinceDBDataSet.Anotacoes)

                    'Catch exc As Exception
                    'MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Catch error_t As Exception
                    MsgBox(error_t.ToString)
                End Try

            End If
        Else



        End If

    End Sub
    '=================================================================================
    'FIM DO SAVE
    '=================================================================================
    '=================================================================================
    'INicio do carregamento de fontes
    '=================================================================================

    Private Sub Fontesinstaladas()
        Dim InstalledFonts = New InstalledFontCollection
        Dim FontFamilies() As FontFamily = InstalledFonts.Families
        For Each Font As FontFamily In FontFamilies
            cbofonte.Items.Add(Font.Name)
        Next
        ''THE END USER WONT BE ABOUT TO EDIT THE INSTALLED ITEMS IN THE COMBOBOX
        ''THE STARTING FONT IS CONSOLAS
        cbofonte.DropDownStyle = ComboBoxStyle.DropDownList
        cbofonte.Text = "Arial"
    End Sub



    '=================================================================================
    'Editores de texto
    '=================================================================================

    Private Sub MudarCorBotao_Click(sender As Object, e As EventArgs) Handles MudarCorBotao.Click
        'usar colodialog para colorir texto selecionado
        Dim cor As Color = Color.FromArgb(255, 255, 255)
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            cor = ColorDialog1.Color
        End If
        RichTextBoxAnotacao.SelectionColor = cor
    End Sub




    Private Sub Mudafonte()
        Dim fonte As String = cbofonte.Text
        Dim tamanho As Integer = cbotamanho.Text 'cbofonte.SelectedIndex + 1
        Dim estilo As FontStyle = FontStyle.Regular

        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(fonte, tamanho, estilo)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(fonte, tamanho, estilo)

            'RichTextBoxAnotacao.Font = New Font(fonte, tamanho, estilo)
        End If

        'RichTextBoxAnotacao.SelectionFont = New Font(fonte, tamanho, estilo)
    End Sub
    Private Sub Cbofonte_DropDownClosed(sender As Object, e As EventArgs) Handles cbofonte.DropDownClosed
        Mudafonte()
    End Sub
    Private Sub Cbotamanho_DropDownClosed(sender As Object, e As EventArgs) Handles cbotamanho.DropDownClosed
        Mudafonte()
    End Sub


    Private Sub BtnNegrito_Click(sender As Object, e As EventArgs) Handles BtnNegrito.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Bold)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Bold)
        End If

    End Sub

    Private Sub BtnItalico_Click(sender As Object, e As EventArgs) Handles BtnItalico.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Italic)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Italic)
        End If
    End Sub

    Private Sub BtnSublinhado_Click(sender As Object, e As EventArgs) Handles BtnSublinhado.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Underline)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Underline)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles BtnColar.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.Paste()
        Else
            RichTextBoxAnotacao.Paste()
        End If
    End Sub


    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.Copy()
        Else
            RichTextBoxAnotacao.Copy()
        End If
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        If Application.OpenForms.OfType(Of FrmBuscaAnotacoes)().Count() > 0 Then
            FrmBuscaAnotacoes.Focus()
            FrmBuscaAnotacoes.Close()
            '  FrmBuscaAnotacoes.MdiParent = MDIPrincipal
            FrmBuscaAnotacoes.Show()
        Else
            'FrmBuscaAnotacoes.MdiParent = MDIPrincipal
            FrmBuscaAnotacoes.Show()
        End If


    End Sub


    Private Sub BtnDataHoraAgora_Click(sender As Object, e As EventArgs) Handles BtnDataHoraAgora.Click

        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectedText = Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + RichTextBoxAnotacao.SelectedText
        Else
            RichTextBoxAnotacao.SelectedText = Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + RichTextBoxAnotacao.SelectedText

        End If
    End Sub

    Private Sub BtnDesfazer_Click(sender As Object, e As EventArgs) Handles BtnDesfazer.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.Undo()
        Else
            RichTextBoxAnotacao.Undo()
        End If
    End Sub


    Private Sub BtnRefazer_Click(sender As Object, e As EventArgs) Handles BtnRefazer.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.Redo()
        Else
            RichTextBoxAnotacao.Redo()
        End If
    End Sub


    Private Sub BtnRealcar_Click(sender As Object, e As EventArgs) Handles BtnRealcar.Click
        Dim MinhasCores As ColorDialog '= New ColorDialog
        'selecionar uma cor customizada
        MinhasCores.AllowFullOpen = False
        'Permite o usuário obter ajuda 
        MinhasCores.ShowHelp = True
        'Define a cor inicial selecionada para a cor atual
        MinhasCores.Color = RichTextBoxAnotacao.BackColor
        'pinta a seleção do texto

        If (MinhasCores.ShowDialog() = DialogResult.OK) Then
            If RichTextBoxAnotacao.SelectedText.Length > 0 Then
                RichTextBoxAnotacao.SelectionBackColor = MinhasCores.Color
            Else
                RichTextBoxAnotacao.SelectionBackColor = MinhasCores.Color

            End If

        End If
    End Sub


    Private Sub BtnEsquerda_Click(sender As Object, e As EventArgs) Handles BtnEsquerda.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionAlignment = HorizontalAlignment.Left
        Else
            RichTextBoxAnotacao.SelectionAlignment = HorizontalAlignment.Left
        End If
    End Sub

    Private Sub BtnCentral_Click(sender As Object, e As EventArgs) Handles BtnCentral.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionAlignment = HorizontalAlignment.Center
        Else
            RichTextBoxAnotacao.SelectionAlignment = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub BtnDireita_Click(sender As Object, e As EventArgs) Handles BtnDireita.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionAlignment = HorizontalAlignment.Right
        Else
            RichTextBoxAnotacao.SelectionAlignment = HorizontalAlignment.Right
        End If
    End Sub



    '=================================================================================
    'Salvar
    '=================================================================================

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        Salvar()

    End Sub

    '=================================================================================
    'INICIAL botões
    '=================================================================================

    Private Sub ButtonInicial_Click(sender As Object, e As EventArgs) Handles ButtonInicial.Click

        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Inicial"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Inicial"))


            'ANEXOS


        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonLegalizacao_Click(sender As Object, e As EventArgs) Handles ButtonLegalizacao.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Legalização"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Legalizacao"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonFederal_Click(sender As Object, e As EventArgs) Handles ButtonFederal.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Receita Federal"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Federal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonEstadual_Click(sender As Object, e As EventArgs) Handles ButtonEstadual.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Receita Estadual"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Estadual"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonPrefeitura_Click(sender As Object, e As EventArgs) Handles ButtonPrefeitura.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Prefeitura Municipal"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonDemais_Click(sender As Object, e As EventArgs) Handles ButtonDemais.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Demais Assuntos"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Demais"))
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try
    End Sub

    '=================================================================================
    'FIM botões
    '=================================================================================
    Private Sub ButtonFechar_Click(sender As Object, e As EventArgs) Handles ButtonFechar.Click
        Me.Close()

    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        RichTextBoxAnotacao.Clear()

    End Sub
End Class