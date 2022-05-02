Public Class LaudosCadastro

    Private Sub LaudosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LaudosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
    End Sub

    Private Sub Laudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


    End Sub
    Private Sub Salvar()
        Me.Validate()
        Me.LaudosBindingSource.EndEdit()
        Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                'Using WS = New WSCorreios.AtendeClienteClient()
                Dim Resultado = WS.consultaCEP(EndCEPMaskedTextBox.Text)
                EnderecoTextBox.Text = Resultado.[end]
                'EndComplementoTextBox.Text = Resultado.complemento
                EndCompTextBox.Text = Resultado.complemento2
                EndCidadeTextBox.Text = Resultado.cidade
                EndBairroTextBox.Text = Resultado.bairro
                EndEstadoTextBox.Text = Resultado.uf
                ' mgs de erro

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try

        End Using
    End Sub

    Private Sub AbrirLaudoConsulta()
        'salvar()
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            '  Dim Sair As String
            '  Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            Salvar()
            FrmAlvara.Focus()
            ' FrmContatos.MdiParent = MDIMenu
            FrmAlvara.ComboBox1.Text = ComboBox1.Text
            FrmAlvara.ComboBox1.Focus()
            Me.Close()
        Else
            Salvar()
            'FrmContatos.MdiParent = MDIMenu
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = ComboBox1.Text
            FrmAlvara.ComboBox1.Focus()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AbrirLaudoConsulta() 'chama fechar  


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        CNPJ = CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")

        System.Diagnostics.Process.Start("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/Cnpjreva_Solicitacao2.asp?cnpj=" + CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'salvar()
        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
            '  Dim Sair As String
            '  Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            ' Salvar()
            Legalizacao.Focus()
            ' FrmContatos.MdiParent = MDIMenu
            Legalizacao.ComboBoxBuscaEmpresa.Text = ComboBox1.Text
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
            '  Me.Close()
        Else
            ' Salvar()
            'FrmContatos.MdiParent = MDIMenu
            Legalizacao.Show()
            Legalizacao.ComboBoxBuscaEmpresa.Text = ComboBox1.Text
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
            '   Me.Close()
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.LaudosBindingSource.AddNew()
        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.LaudosBindingSource.RemoveCurrent()
            Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then

            Salvar()
        Else

        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Me.Close()

    End Sub

    Private Sub LaudosCadastro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As Integer = MessageBox.Show("Deseja Salvar as Alterações do 'Cadastro Geral de Laudos' antes de fechar o formulário?", "Prince Alerta", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            e.Cancel = True
        ElseIf result = DialogResult.No Then
            ' Me.Close()
        ElseIf result = DialogResult.Yes Then
            Me.Validate()
            Me.LaudosBindingSource.EndEdit()
            Me.LaudosTableAdapter.Update(Me.PrinceDBDataSet.Laudos)
            '  Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Application.OpenForms.OfType(Of Contador)().Count() > 0 Then

            Contador.Focus()
            '   Contador.MdiParent = MDIPrincipal


        Else

            ' Contador.MdiParent = MDIPrincipal
            Contador.Show()


        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Application.OpenForms.OfType(Of Telefones)().Count() > 0 Then

            Telefones.Focus()
            '   Contador.MdiParent = MDIPrincipal


        Else

            ' Contador.MdiParent = MDIPrincipal
            Telefones.Show()


        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim CNPJ As String = CNPJMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))




    End Sub

    Private Sub SituacaoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SituacaoComboBox.SelectedIndexChanged

        Select Case SituacaoComboBox.Text.Trim()
            Case "Paralisado"
                AvisarDiaMaskedTextBox.Text = ""
                DataEntradaLabel.Visible = False
                DataEntradaMaskedTextBox.Visible = False
                Button8.Visible = False
                Button1.Visible = True

            Case "Baixado"
                AvisarDiaMaskedTextBox.Text = ""
                DataEntradaLabel.Visible = False
                DataEntradaMaskedTextBox.Visible = False
                Button8.Visible = False
                Button1.Visible = True

            Case "Não Fazer"
                AvisarDiaMaskedTextBox.Text = ""
                DataEntradaLabel.Visible = False
                DataEntradaMaskedTextBox.Visible = False
                Button8.Visible = False
                Button1.Visible = True

            Case "Cancelado"
                AvisarDiaMaskedTextBox.Text = ""
                DataEntradaLabel.Visible = False
                DataEntradaMaskedTextBox.Visible = False
                Button8.Visible = False
                Button1.Visible = True

            Case "Finalizado Definitivo"
                DataEntradaLabel.Visible = True
                DataEntradaMaskedTextBox.Visible = True
                Button8.Visible = False
                Button1.Visible = True


            Case "Finalizado Provisório"
                DataEntradaLabel.Visible = True
                DataEntradaMaskedTextBox.Visible = True
                Button8.Visible = False
                Button1.Visible = True

            Case "Não Iniciado"
                DataEntradaLabel.Visible = False
                DataEntradaMaskedTextBox.Visible = False
                Button8.Visible = True
                Button1.Visible = False

            Case Else
                DataEntradaLabel.Visible = False
                DataEntradaMaskedTextBox.Visible = False
                Button8.Visible = False
                Button1.Visible = True
        End Select

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then

            System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br/laudosnew/index.php")


        ElseIf ModeloSistemaComboBox.Text = "Alvará Online" Then

            System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br:9900/fazendaonline/")


        ElseIf ModeloSistemaComboBox.Text = "Alvará Primitivo" Then

            MessageBox.Show("Documentos Manuais da Prefeitura da cidade onde a empresa se localiza", "Prince Ajuda")
        Else

            MessageBox.Show("Informar qual tipo de sistema utilizado na solicitação do laudo - alvará de localização", "Prince Sistemas - Alerta")

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start("http://venus.maringa.pr.gov.br:9900/fazendaonline/")

    End Sub

    Private Sub ModeloSistemaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeloSistemaComboBox.SelectedIndexChanged
        If ModeloSistemaComboBox.Text = "Alvará Antigo" Then
            Button9.Visible = True


        Else
            Button9.Visible = False


        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TabControl1.SelectTab(1)
        TabControl1.SelectTab(3)
        CNPJRequerenteMaskedTextBox.Text = CNPJMaskedTextBox.Text
        EndRequerenteTextBox.Text = EnderecoTextBox.Text & ", " & EndNumTextBox.Text & ", " & EndBairroTextBox.Text & ", " & EndCidadeTextBox.Text & "-" & EndEstadoTextBox.Text
        FoneRequerenteTextBox.Text = TelefoneMaskedTextBox.Text


    End Sub



End Class