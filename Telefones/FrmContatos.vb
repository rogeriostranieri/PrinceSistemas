﻿Public Class FrmContatos


    Private Sub Contatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Contatos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ContatosTableAdapter.Fill(Me.PrinceDBDataSet.Contatos)

        Desabilitatudo()



    End Sub

    Private Sub HabilitaTudo()

        NomeTextBox.ReadOnly = False
        'SobrenomeTextBox.ReadOnly = False
        Telefone_ResidencialMaskedTextBox.ReadOnly = False
        Telefone_TrabalhoMaskedTextBox.ReadOnly = False
        Telefone_Celular_ParticularMaskedTextBox.ReadOnly = False
        Telefone_Celular_ContatoMaskedTextBox.ReadOnly = False
        EmailTextBox.ReadOnly = False
        End_CEPMaskedTextBox.ReadOnly = False
        End_RuaTextBox.ReadOnly = False
        End_NumeroTextBox.ReadOnly = False
        End_CompTextBox.ReadOnly = False
        End_BairroTextBox.ReadOnly = False
        End_CidadeTextBox.ReadOnly = False
        End_EstadoTextBox.ReadOnly = False
        End_PaisTextBox.ReadOnly = False
        DataMaskedTextBox.ReadOnly = False
        Outras_InformacoesRichTextBox.ReadOnly = False

        BtnPreencher.Enabled = True

        BtnCancelar.Enabled = True
        BtnEditar.Enabled = False




    End Sub

    Private Sub Desabilitatudo()
        NomeTextBox.ReadOnly = True
        '  SobrenomeTextBox.ReadOnly = True
        Telefone_ResidencialMaskedTextBox.ReadOnly = True
        Telefone_TrabalhoMaskedTextBox.ReadOnly = True
        Telefone_Celular_ParticularMaskedTextBox.ReadOnly = True
        Telefone_Celular_ContatoMaskedTextBox.ReadOnly = True
        EmailTextBox.ReadOnly = True
        End_CEPMaskedTextBox.ReadOnly = True
        End_RuaTextBox.ReadOnly = True
        End_NumeroTextBox.ReadOnly = True
        End_CompTextBox.ReadOnly = True
        End_BairroTextBox.ReadOnly = True
        End_CidadeTextBox.ReadOnly = True
        End_EstadoTextBox.ReadOnly = True
        End_PaisTextBox.ReadOnly = True
        DataMaskedTextBox.ReadOnly = True
        Outras_InformacoesRichTextBox.ReadOnly = True

        BtnPreencher.Enabled = False

        BtnCancelar.Enabled = False
        BtnEditar.Enabled = True

    End Sub

    Private Async Sub BtnPreenchers_Click(sender As Object, e As EventArgs) Handles BtnPreencher.Click
        Try
            ' Chamar o método de busca de CEP no módulo
            Dim resultado = Await ModuloBuscaCEP.BuscarCEPAsync(End_CEPMaskedTextBox.Text)

            If resultado IsNot Nothing Then
                End_RuaTextBox.Text = resultado.logradouro
                End_CompTextBox.Text = resultado.complemento
                End_CidadeTextBox.Text = resultado.localidade
                End_BairroTextBox.Text = resultado.bairro
                End_EstadoTextBox.Text = resultado.uf
            Else
                MessageBox.Show("CEP não encontrado.")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar informações de CEP: " & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/")
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.ContatosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)
            Desabilitatudo()
        Else

        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If MsgBox(" Deseja editar?", MsgBoxStyle.YesNo, "Editar") = MsgBoxResult.Yes Then
            HabilitaTudo()

        Else

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        If MsgBox(" Deseja cancelar as alterações?", MsgBoxStyle.YesNo, "Cancelar") = MsgBoxResult.Yes Then

            Desabilitatudo()
            Me.Validate()
            Me.ContatosTableAdapter.Update(Me.PrinceDBDataSet.Contatos)
            Me.ContatosTableAdapter.Fill(Me.PrinceDBDataSet.Contatos)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Else

        End If
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            HabilitaTudo()
            Me.Validate()
            Me.ContatosBindingSource.AddNew()

        Else

        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.ContatosBindingSource.RemoveCurrent()
            Me.ContatosTableAdapter.Update(Me.PrinceDBDataSet.Contatos)
            Me.ContatosTableAdapter.Fill(Me.PrinceDBDataSet.Contatos)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Desabilitatudo()
        End If
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub
End Class