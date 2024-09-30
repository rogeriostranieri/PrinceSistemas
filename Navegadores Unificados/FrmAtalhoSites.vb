Imports System.Text
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class FrmAtalhoSites

    Dim connectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755;Encrypt=False"
    ReadOnly Protocolo As String = FrmLegalizacao.ProtocoloJuntaComercialTextBox.Text

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        'mgsbox EM TESTE
        MsgBox("Em desenvolvimento")
    End Sub

    Private Sub BtnInterno_Click(sender As Object, e As EventArgs) Handles BtnInterno.Click
        Try
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
            Dim Junta As String = FrmLegalizacao.EndEstadoTextBox.Text
            '///////////////////////////////////////////////////////////////////////////////////
            'Verifica Navegador interno
            If Application.OpenForms.OfType(Of WebSiteGERAL)().Count() > 0 Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = MDIPrincipal
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = MDIPrincipal
            End If
            '///////////////////////////////////////////////////////////////////////////////////
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(2)
            '///////////////////////////////////////////////////////////////////////////////////
            'inicia processo de abrir
            If Junta = "PR" Then
                WebSiteGERAL.WebView.Source = New Uri("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            ElseIf Junta = "ES" Then
                WebSiteGERAL.WebView.Source = New Uri("https://www.simplifica.es.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            End If
            '///////////////////////////////////////////////////////////////////////////////////
            MDIPrincipal.Focus()
            WebSiteGERAL.Focus()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao abrir o site da Junta Comercial, verificar o  Estado Cadastrado ou informar o administrador")
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
        End Try
    End Sub

    Private Sub BoxJuntaComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BtnExterno_Click(sender As Object, e As EventArgs) Handles BtnExterno.Click
        Try
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
            Dim Junta As String = FrmLegalizacao.EndEstadoTextBox.Text

            If Junta = "PR" Then
                System.Diagnostics.Process.Start("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            ElseIf Junta = "ES" Then
                System.Diagnostics.Process.Start("https://www.simplifica.es.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + Protocolo)
            End If
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(2)
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao abrir o site da Junta Comercial, verificar o  Estado Cadastrado ou informar o administrador")
            'selecionar TabControle  aba 1
            FrmLegalizacao.TabControle.SelectTab(1)
            'selecionar TabControle  aba 2
            FrmLegalizacao.TabControl2.SelectTab(3)
        End Try
    End Sub

    Private Sub BtnLaudo_Click(sender As Object, e As EventArgs) Handles BtnLaudo.Click
        Dim frmLegalizacaoAberto As Boolean = False
        Dim frmAlvaraAberto As Boolean = False

        ' Verificar se FrmLegalizacao está aberto
        For Each frm As Form In Application.OpenForms
            If frm.Name = "FrmLegalizacao" Then
                frmLegalizacaoAberto = True
                frm.Focus() ' Focar no formulário se ele estiver aberto
                Exit For
            End If
        Next

        ' Verificar se FrmAlvara está aberto
        For Each frm As Form In Application.OpenForms
            If frm.Name = "FrmAlvara" Then
                frmAlvaraAberto = True
                frm.Focus() ' Focar no formulário se ele estiver aberto
                Exit For
            End If
        Next

        ' Exibir as mensagens apropriadas
        If frmLegalizacaoAberto AndAlso frmAlvaraAberto Then
            MessageBox.Show("Ambos os formulários 'FrmLegalizacao' e 'FrmAlvara' estão abertos. Não é possível continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf frmLegalizacaoAberto Then
            MessageBox.Show("'FrmLegalizacao' já está aberto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' FrmLegalizacao.Focus()
            FrmLegalizacao.TabControle.SelectTab(0)
            FrmLegalizacao.TabControl2.SelectTab(1)
            FrmLegalizacao.TabControl2.SelectTab(3)

            Dim cidade As String = FrmLegalizacao.EndCidadeTextBox.Text
            Dim Estado As String = FrmLegalizacao.EndEstadoTextBox.Text
            FrmLegalizacao.TabControle.SelectTab(0)
            'EstadoSigla é da tabela Site onde fica sigla do Estado que vai comparar e busca com a string "Estado"
            'aqui usar o Dim connectionString As String ja dito no inicio do form como padrao



        ElseIf frmAlvaraAberto Then
            MessageBox.Show("'FrmAlvara' já está aberto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmAlvara.TabAlvara.SelectTab(2)
            FrmAlvara.TabControl2.SelectTab(1)

            Dim cidade As String = FrmAlvara.EndCidadeTextBox.Text
            Dim Estado As String = FrmAlvara.EndEstadoTextBox.Text
            'EstadoSigla é da tabela Site onde fica sigla do Estado que vai comparar e busca com a string "Estado"


        Else
            MessageBox.Show("Ambos os formulários estão fechados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FrmAtalhoSites_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
