Imports System.Data.SqlClient
Imports System.IO


Public Class MDIPrincipal

    Private Sub BuscaLogin()
        Dim conexao As SqlConnection
        Dim comando As SqlCommand
        Dim da As SqlDataAdapter
        Dim dr As SqlDataReader

        conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        conexao.Open()

        ' Busca o login do usuário logado
        comando = New SqlCommand("SELECT * FROM LOGIN WHERE USUARIO = @Usuario", conexao)
        comando.Parameters.AddWithValue("@Usuario", Login.txtUsername.Text)
        da = New SqlDataAdapter(comando)
        dr = comando.ExecuteReader()

        If dr.Read() Then
            Dim nomeCompleto As String = dr("NomeCompleto").ToString()
            Dim dataNascimento As DateTime = Convert.ToDateTime(dr("DataNascimento"))

            ' Verifica se hoje é o aniversário
            If dataNascimento.Month = DateTime.Now.Month And dataNascimento.Day = DateTime.Now.Day Then
                ' Abre o formulário de parabéns
                Dim frmParabens As New FrmParabens With {
                    .UsuarioLogado = nomeCompleto,
                    .MdiParent = Me
                }
                ' Posiciona o formulário abaixo do ButtonEmpresas
                Dim btnEmpresasPos As Point = ButtonEmpresas.PointToScreen(Point.Empty)
                frmParabens.StartPosition = FormStartPosition.Manual
                frmParabens.Location = New Point(btnEmpresasPos.X, btnEmpresasPos.Y + ButtonEmpresas.Height)

                frmParabens.Show()
            End If

            ' Atualiza o nome completo e tema no MDI principal
            LblNomeCompleto.Text = "Bem vindo Sr(a). " & nomeCompleto & "!"
            LbTema.Text = dr("Tema").ToString()

            ' Mudar a cor dos labels
            LblNomeCompleto.ForeColor = Color.White
            LbTema.ForeColor = Color.Black

            ' Configurar o plano de fundo de acordo com o tema
            Try
                For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
                    Dim imgName As String = IO.Path.GetFileName(img)
                    If imgName.StartsWith(dr("Tema").ToString()) Then
                        BackgroundImage = Image.FromFile(img)
                        BackgroundImageLayout = ImageLayout.Stretch
                    End If
                Next
            Catch ex As Exception
                MsgBox("Erro ao carregar imagem de fundo")
            End Try
        End If

        conexao.Close()
    End Sub


    'fim do codigo do TEMA


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
        Login.Close()
    End Sub




    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chama validação da expiração
        Call ModData.FimData()
        Call ModData.Valida()
        'continua

        Me.WindowState = FormWindowState.Maximized

        'fundo padrao inicial


        BuscaLogin()

        'fim do fundo

        'Inicio Aviso
        VbAvisoPrincipal.MdiParent = Me
        VbAvisoPrincipal.Show()

        'fim do aviso

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch


        'Mudança do MENU COR
        ToolStrip.ForeColor = Color.Black
        ToolStrip.BackColor = Color.White


        MenuStrip.ForeColor = Color.Black
        MenuStrip.BackColor = Color.White



        'COR MENU PRINCIPAÇ
        MenuToolStripMenuItem.ForeColor = Color.Black
        'EmpresasToolStripMenuItem.ForeColor = Color.Black
        'AlvaráToolStripMenuItem.ForeColor = Color.Black
        TelefonesToolStripMenuItem.ForeColor = Color.Black
        ConsultaToolStripMenuItem.ForeColor = Color.Black
        RelatóriosToolStripMenuItem.ForeColor = Color.Black
        AgendaToolStripMenuItem.ForeColor = Color.Black
        HelpMenu.ForeColor = Color.Black


        MenuToolStripMenuItem.BackColor = Color.White
        ' EmpresasToolStripMenuItem.BackColor = Color.White
        'AlvaráToolStripMenuItem.BackColor = Color.White
        TelefonesToolStripMenuItem.BackColor = Color.White
        ConsultaToolStripMenuItem.BackColor = Color.White
        RelatóriosToolStripMenuItem.BackColor = Color.White
        AgendaToolStripMenuItem.BackColor = Color.White
        HelpMenu.BackColor = Color.White

        'MENU  BARRA 2
        ToolStripButton1.ForeColor = Color.Black
        ToolStripButton2.ForeColor = Color.Black
        ToolStripButton3.ForeColor = Color.Black
        ToolStripButton4.ForeColor = Color.Black

        ToolStripButton1.BackColor = Color.White
        ToolStripButton2.BackColor = Color.White
        ToolStripButton3.BackColor = Color.White
        ToolStripButton4.BackColor = Color.White


        'MUDANÇA DE CORES

        'Menu
        SairToolStripMenuItem1.ForeColor = Color.Black

        'Empresas
        'ControleLegalizaçãoToolStripMenuItem.ForeColor = Color.Black

        'Laudos
        'LaudosGeralToolStripMenuItem.ForeColor = Color.Black
        OrToolStripMenuItem.ForeColor = Color.Black

        'Contatos
        ContatosToolStripMenuItem.ForeColor = Color.Black

        'Consulta
        ProtocoladosToolStripMenuItem.ForeColor = Color.Black
        'EmpresasPendênteToolStripMenuItem.ForeColor = Color.Black
        VencimentoAlvaráToolStripMenuItem.ForeColor = Color.Black
        'AlvarásPendenteToolStripMenuItem.ForeColor = Color.Black
        ControleLigaçãoLaudosToolStripMenuItem.ForeColor = Color.Black
        RegimeFederalToolStripMenuItem.ForeColor = Color.Black

        'Agenda
        TributáriaToolStripMenuItem.ForeColor = Color.Black

        'Relatórios
        'EmpresasToolStripMenuItem.ForeColor = Color.Black
        AlvarásLaudosToolStripMenuItem.ForeColor = Color.Black


        'Ajuda
        AboutToolStripMenuItem.ForeColor = Color.Black



        'OUTRA PARTE FUNDO COR

        'Menu
        SairToolStripMenuItem1.BackColor = Color.White

        'Empresas
        'ControleLegalizaçãoToolStripMenuItem.BackColor = Color.White

        'Laudos
        'LaudosGeralToolStripMenuItem.BackColor = Color.White
        OrToolStripMenuItem.BackColor = Color.White

        'Contatos
        ContatosToolStripMenuItem.BackColor = Color.White

        'Consulta
        ProtocoladosToolStripMenuItem.BackColor = Color.White
        ' EmpresasPendênteToolStripMenuItem.BackColor = Color.White
        VencimentoAlvaráToolStripMenuItem.BackColor = Color.White
        ' AlvarásPendenteToolStripMenuItem.BackColor = Color.White
        ControleLigaçãoLaudosToolStripMenuItem.BackColor = Color.White
        RegimeFederalToolStripMenuItem.BackColor = Color.White

        'Relatórios
        'EmpresasToolStripMenuItem.BackColor = Color.White
        AlvarásLaudosToolStripMenuItem.BackColor = Color.White

        'Agenda
        TributáriaToolStripMenuItem.BackColor = Color.White


        'Ajuda

        AboutToolStripMenuItem.BackColor = Color.White




        MenuStrip.AutoSize = True
        MenuStrip.Dock = DockStyle.Top


        ' No Load do MDIPAI ou no evento de abertura do formulário filho
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.SendToBack()
            End If
        Next

        Me.IsMdiContainer = True


    End Sub




    Private Sub MDIPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ' Verificar se WebSiteGERAL está aberto e fechar
            If Application.OpenForms.OfType(Of WebSiteGERAL).Count() > 0 Then
                WebSiteGERAL.Close()
            End If

            ' Excluir pasta "\PrinceSistemas.exe.WebView2" onde fica salvo todo cache
            Dim dir As String = Application.StartupPath & "\PrinceSistemas.exe.WebView2"
            Dim di As New IO.DirectoryInfo(dir)

            ' Verificar se a pasta do WebView existe
            If di.Exists Then
                For Each fi As IO.FileInfo In di.GetFiles()
                    Try
                        fi.Delete()
                    Catch ex As UnauthorizedAccessException
                        MsgBox("Erro ao excluir arquivo: " & fi.Name & " - " & ex.Message)
                    End Try
                Next

                For Each dii As IO.DirectoryInfo In di.GetDirectories()
                    Try
                        dii.Delete(True)
                    Catch ex As UnauthorizedAccessException
                        MsgBox("Erro ao excluir diretório: " & dii.Name & " - " & ex.Message)
                    End Try
                Next

                Try
                    di.Delete()
                Catch ex As UnauthorizedAccessException
                    MsgBox("Erro ao excluir diretório principal: " & di.FullName & " - " & ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Fim do código de apagar a pasta
        Application.Exit()
    End Sub




    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        If Application.OpenForms.OfType(Of LembreteInicial)().Count() > 0 Then

            LembreteInicial.Focus()
            LembreteInicial.Close()
            LembreteInicial.MdiParent = Me
            LembreteInicial.Show()

        Else

            LembreteInicial.MdiParent = Me
            LembreteInicial.Show()


        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        If Application.OpenForms.OfType(Of VbAvisoPrincipal)().Count() > 0 Then

            VbAvisoPrincipal.Focus()
            VbAvisoPrincipal.Close()
            VbAvisoPrincipal.MdiParent = Me
            VbAvisoPrincipal.Show()

        Else

            VbAvisoPrincipal.MdiParent = Me
            VbAvisoPrincipal.Show()

        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of AboutBox)().Count() > 0 Then

            AboutBox.Focus()
            AboutBox.Close()
            AboutBox.MdiParent = Me
            AboutBox.Show()

        Else

            AboutBox.MdiParent = Me
            AboutBox.Show()

        End If
    End Sub



    Private Sub OrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of Telefones)().Count() > 0 Then

            Telefones.Focus()
            Telefones.Close()
            Telefones.MdiParent = Me
            Telefones.Show()

        Else

            Telefones.MdiParent = Me
            Telefones.Show()

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        If Application.OpenForms.OfType(Of PrioridadeAviso)().Count() > 0 Then

            PrioridadeAviso.Focus()
            PrioridadeAviso.Close()
            PrioridadeAviso.MdiParent = Me
            PrioridadeAviso.Show()

        Else

            PrioridadeAviso.MdiParent = Me
            PrioridadeAviso.Show()

        End If
    End Sub



    Private Sub ProtocoladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtocoladosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmProtocolados)().Count() > 0 Then

            FrmProtocolados.Focus()
            FrmProtocolados.Close()
            FrmProtocolados.MdiParent = Me
            FrmProtocolados.Show()

        Else

            FrmProtocolados.MdiParent = Me
            FrmProtocolados.Show()

        End If
    End Sub

    Private Sub VencimentoAlvaráToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VencimentoAlvaráToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of VencimentoAlvara)().Count() > 0 Then

            VencimentoAlvara.Focus()
            VencimentoAlvara.Close()
            VencimentoAlvara.MdiParent = Me
            VencimentoAlvara.Show()

        Else

            VencimentoAlvara.MdiParent = Me
            VencimentoAlvara.Show()

        End If
    End Sub

    Private Sub EmpresasPendênteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Application.OpenForms.OfType(Of FrmEmpresaEmAndamento)().Count() > 0 Then

            FrmEmpresaEmAndamento.Focus()
            FrmEmpresaEmAndamento.Close()
            FrmEmpresaEmAndamento.MdiParent = Me
            FrmEmpresaEmAndamento.Show()

        Else

            FrmEmpresaEmAndamento.MdiParent = Me
            FrmEmpresaEmAndamento.Show()

        End If
    End Sub

    Private Sub AlvarásPendenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Application.OpenForms.OfType(Of LaudosPendentes)().Count() > 0 Then

            LaudosPendentes.Focus()
            LaudosPendentes.Close()
            LaudosPendentes.MdiParent = Me
            LaudosPendentes.Show()

        Else

            LaudosPendentes.MdiParent = Me
            LaudosPendentes.Show()

        End If
    End Sub


    Private Sub TributáriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TributáriaToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of WebAgenda)().Count() > 0 Then
            WebAgenda.Close()
            WebAgenda.Show()
        Else
            WebAgenda.Show()
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If Application.OpenForms.OfType(Of WebAgenda)().Count() > 0 Then

            WebAgenda.Focus()
            WebAgenda.Close()
            WebAgenda.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            WebAgenda.Show()


        Else

            WebAgenda.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            WebAgenda.Show()

        End If
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        'Me.Close()
        'Login.Close()
        Application.Exit()

    End Sub

    Private Sub ControleLigaçãoLaudosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleLigaçãoLaudosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmLigacaoAlvara)().Count() > 0 Then

            FrmLigacaoAlvara.Focus()
            FrmLigacaoAlvara.Close()
            FrmLigacaoAlvara.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmLigacaoAlvara.Show()


        Else

            FrmLigacaoAlvara.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmLigacaoAlvara.Show()

        End If
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of BackupERestore)().Count() > 0 Then

            BackupERestore.Focus()
            BackupERestore.Close()
            BackupERestore.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            BackupERestore.Show()


        Else

            BackupERestore.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            BackupERestore.Show()

        End If
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        If Application.OpenForms.OfType(Of RelatorioEmpresas)().Count() > 0 Then

            RelatorioEmpresas.Focus()
            RelatorioEmpresas.Close()
            RelatorioEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioEmpresas.Show()


        Else

            RelatorioEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioEmpresas.Show()

        End If
    End Sub

    Private Sub AlvarásLaudosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlvarásLaudosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of RelatorioLaudos)().Count() > 0 Then

            RelatorioLaudos.Focus()
            RelatorioLaudos.Close()
            RelatorioLaudos.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioEmpresas.Show()


        Else

            RelatorioLaudos.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioLaudos.Show()

        End If
    End Sub

    Private Sub RegimeFederalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegimeFederalToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmRelSimples)().Count() > 0 Then

            FrmRelSimples.Focus()
            FrmRelSimples.Close()
            FrmRelSimples.MdiParent = Me
            FrmRelSimples.Show()


        Else

            FrmRelSimples.MdiParent = Me
            FrmRelSimples.Show()

        End If
    End Sub

    Private Sub ContatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContatosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmContatos)().Count() > 0 Then

            FrmContatos.Focus()
            FrmContatos.Close()
            FrmContatos.MdiParent = Me
            FrmContatos.Show()


        Else

            FrmContatos.MdiParent = Me
            FrmContatos.Show()

        End If
    End Sub

    Private Sub AlvarásProtocoladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlvarásProtocoladosToolStripMenuItem.Click

        If Application.OpenForms.OfType(Of RelacaoAlvaraProtocolado)().Count() > 0 Then

            RelacaoAlvaraProtocolado.Focus()
            RelacaoAlvaraProtocolado.Close()
            RelacaoAlvaraProtocolado.MdiParent = Me
            RelacaoAlvaraProtocolado.Show()


        Else

            RelacaoAlvaraProtocolado.MdiParent = Me
            RelacaoAlvaraProtocolado.Show()

        End If
    End Sub


    Private Sub PadrãoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.BackgroundImage = My.Resources.FundoNovo
        Me.Refresh()
    End Sub

    Private Sub NoiteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.BackgroundImage = My.Resources.noite
        Me.Refresh()
    End Sub

    Private Sub PrevFogoBombeiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevFogoBombeiroToolStripMenuItem.Click

        If Application.OpenForms.OfType(Of FrmBombeiro)().Count() > 0 Then

            FrmBombeiro.Focus()
            FrmBombeiro.Close()
            FrmBombeiro.MdiParent = Me
            FrmBombeiro.Show()

        Else

            FrmBombeiro.MdiParent = Me
            FrmBombeiro.Show()

        End If
    End Sub

    Private Sub TipoDeEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeEmpresasToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of RlTipoEmpresa)().Count() > 0 Then

            RlTipoEmpresa.Focus()
            RlTipoEmpresa.Close()
            RlTipoEmpresa.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RlTipoEmpresa.Show()


        Else

            RlTipoEmpresa.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RlTipoEmpresa.Show()

        End If
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.BackgroundImage = My.Resources._1
        Me.Refresh()
    End Sub

    Private Sub NovasEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovasEmpresasToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of RelEmpresasDatas)().Count() > 0 Then

            RelEmpresasDatas.Focus()
            RelEmpresasDatas.Close()
            RelEmpresasDatas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelEmpresasDatas.Show()


        Else

            RelEmpresasDatas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelEmpresasDatas.Show()

        End If
    End Sub



    Private Sub BuscaEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscaEmpresaToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmBuscaEmpresas)().Count() > 0 Then

            FrmBuscaEmpresas.Focus()
            FrmBuscaEmpresas.Close()
            FrmBuscaEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmBuscaEmpresas.Show()


        Else

            FrmBuscaEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmBuscaEmpresas.Show()

        End If
    End Sub

    Private Sub ControleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmControleEmpresas)().Count() > 0 Then

            FrmControleEmpresas.Focus()
            FrmControleEmpresas.Close()
            FrmControleEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmControleEmpresas.Show()


        Else

            FrmControleEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmControleEmpresas.Show()

        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If Application.OpenForms.OfType(Of FrmMail)().Count() > 0 Then

            FrmMail.Focus()
            FrmMail.Close()
            FrmMail.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmMail.Show()


        Else

            FrmMail.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmMail.Show()

        End If
    End Sub





    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAnotacoes.Show()


        Else

            FrmAnotacoes.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAnotacoes.Show()

        End If
    End Sub

    Private Sub UsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuárioToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmAdmPrincipal)().Count() > 0 Then

            FrmAdmPrincipal.Focus()
            FrmAdmPrincipal.Close()
            FrmAdmPrincipal.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAdmPrincipal.Show()


        Else

            FrmAdmPrincipal.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAdmPrincipal.Show()

        End If
    End Sub

    Private Sub ContadorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContadorToolStripMenuItem1.Click
        If Application.OpenForms.OfType(Of ContadorGeral)().Count() > 0 Then

            ContadorGeral.Focus()
            ContadorGeral.MdiParent = Me


        Else

            ContadorGeral.MdiParent = Me
            ContadorGeral.Show()


        End If
    End Sub

    Private Sub CalculadoraDeCapitalSocialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraDeCapitalSocialToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmCalculadoraCapital)().Count() > 0 Then

            FrmCalculadoraCapital.Focus()
            FrmCalculadoraCapital.MdiParent = Me


        Else

            FrmCalculadoraCapital.MdiParent = Me
            FrmCalculadoraCapital.Show()


        End If
    End Sub

    Private Sub AlvaráToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlvaráToolStripMenuItem1.Click
        If Application.OpenForms.OfType(Of FrmBuscaAlvara)().Count() > 0 Then

            FrmBuscaAlvara.Focus()
            FrmBuscaAlvara.MdiParent = Me


        Else

            FrmBuscaAlvara.MdiParent = Me
            FrmBuscaAlvara.Show()


        End If
    End Sub




    Private Sub MDIPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'nao permitir fechar o form quando os outros estiver abertos
        'FrmLegalizacao e FrmAlvara
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            e.Cancel = True
            'mgsbox e focus
            MsgBox("Feche o formulário de Legalização Empresas antes de fechar o programa", MsgBoxStyle.Information, "Aviso")
            FrmLegalizacao.Focus()
        ElseIf Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            e.Cancel = True
            'mgsbox e focus
            MsgBox("Feche o formulário de Alvara antes de fechar o programa", MsgBoxStyle.Information, "Aviso")
            FrmAlvara.Focus()

        ElseIf Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
            e.Cancel = True
            'mgsbox e focus
            MsgBox("Feche o formulário de Sócios antes de fechar o programa", MsgBoxStyle.Information, "Aviso")
            FrmSocios.Focus()
        ElseIf Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then
            e.Cancel = True
            'mgsbox e focus
            MsgBox("Feche o formulário de Anotações antes de fechar o programa", MsgBoxStyle.Information, "Aviso")
            FrmAnotacoes.Focus()
        ElseIf Application.OpenForms.OfType(Of FrmAdmPrincipal)().Count() > 0 Then
            e.Cancel = True
            'mgsbox e focus
            MsgBox("Feche o formulário de Administrador antes de fechar o programa", MsgBoxStyle.Information, "Aviso")
            FrmAdmPrincipal.Focus()
        End If
    End Sub



    Private Sub SóciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SóciosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmSocios)().Count() > 0 Then
            FrmSocios.Focus()
        Else
            FrmSocios.Show()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        If Application.OpenForms.OfType(Of FrmGeral)().Count() > 0 Then
            FrmGeral.Focus()
            FrmGeral.MdiParent = Me
        Else
            FrmGeral.MdiParent = Me
            FrmGeral.Show()
        End If
    End Sub

    Private Sub NavegadorWEBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavegadorWEBToolStripMenuItem.Click
        Try
            'ler o txt e pegar o site inicial que está na frente "pagina_inicial:" do txt
            Dim path As String = Application.StartupPath & "\PaginaInicial.txt"
            Dim sr As New StreamReader(path)
            Dim line As String = sr.ReadLine()
            Dim site As String = ""
            While line IsNot Nothing
                If line.Contains("pagina_inicial:") Then
                    site = line.Replace("pagina_inicial:", "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()


            '  Dim WebSiteGeral As New WebSiteGERAL
            Dim URLsite As String = WebSiteGERAL.TxtURL.Text

            'abrir o WebSiteGERAL
            If WebSiteGERAL.Visible = True Then
                WebSiteGERAL.Focus()
                WebSiteGERAL.MdiParent = Me
                'site WebView com site
                WebSiteGERAL.WebsiteNavigate(site)
            Else
                WebSiteGERAL.Show()
                WebSiteGERAL.MdiParent = Me
                WebSiteGERAL.WebsiteNavigate(site)
            End If
            'maximizar
            WebSiteGERAL.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            'abrir o site do google no lugar
            WebSiteGERAL.WebsiteNavigate("https://www.google.com.br/")
        End Try
    End Sub

    Private Sub MaringáPRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaringáPRToolStripMenuItem.Click
        ' Verificar se o formulário já está aberto
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmBuscaCNAE Then
                frm.BringToFront()
                frm.Focus()
                Return ' Sai do método sem abrir uma nova instância
            End If
        Next

        ' Se o formulário não estiver aberto, criar uma nova instância e mostrar
        Dim novoForm As New FrmBuscaCNAE()
        novoForm.Show()
    End Sub

    Private Sub ButtonEmpresas_Click(sender As Object, e As EventArgs) Handles ButtonEmpresas.Click
        If Application.OpenForms.OfType(Of FrmGeral)().Count() > 0 Then
            FrmGeral.Focus()
            FrmGeral.MdiParent = Me
        Else
            FrmGeral.MdiParent = Me
            FrmGeral.Show()
        End If
    End Sub

    Private Sub MDIPrincipal_MdiChildActivate(sender As Object, e As EventArgs) Handles MyBase.MdiChildActivate
        Me.BringToFront()

    End Sub

    Private Sub TodosSóciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosSóciosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmSociosGERAL)().Count() > 0 Then
            FrmSociosGERAL.Focus()
            FrmSociosGERAL.MdiParent = Me
        Else
            FrmSociosGERAL.MdiParent = Me
            FrmSociosGERAL.Show()
        End If
    End Sub



    Private Sub TodasCidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasCidadesToolStripMenuItem.Click
        FrmBrasilCidadesGeral.Show()
    End Sub

    Private Sub SitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SitesToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmSites)().Count() > 0 Then
            FrmSites.Focus()
        Else
            FrmSites.Show()
        End If
    End Sub

    Private Sub IBGECONCLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IBGECONCLAToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmCNAEoficial)().Count() > 0 Then
            FrmCNAEoficial.Focus()
        Else
            FrmCNAEoficial.Show()
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            FrmLegalizacao.Focus()
        Else
            FrmLegalizacao.Show()
            FrmLegalizacao.BtnEditar.PerformClick()
        End If
    End Sub

    Private Sub NovoCadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoCadastroToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmLegalizacao)().Count() > 0 Then
            FrmLegalizacao.Focus()
            FrmLegalizacao.BtnNovo.PerformClick()
        Else
            FrmLegalizacao.Show()
            FrmLegalizacao.BtnNovo.PerformClick()
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            FrmAlvara.Focus()
        Else
            FrmAlvara.Show()
            FrmAlvara.BtnEditar.PerformClick()
        End If
    End Sub

    Private Sub NovoCadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NovoCadastroToolStripMenuItem1.Click
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            FrmAlvara.Focus()
            FrmAlvara.BtnNovo.PerformClick()
        Else
            FrmAlvara.Show()
            FrmAlvara.BtnNovo.PerformClick()
        End If
    End Sub


    Private Sub AvisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvisoToolStripMenuItem.Click
        'FrmAvisoParcelamento
        If Application.OpenForms.OfType(Of FrmAvisoParcelamento)().Count() > 0 Then
            FrmAvisoParcelamento.Focus()
            FrmAvisoParcelamento.MdiParent = Me
        Else
            FrmAvisoParcelamento.Show()
            FrmAvisoParcelamento.MdiParent = Me
        End If
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmGeralParcelamento)().Count() > 0 Then
            FrmGeralParcelamento.Focus()
            FrmGeralParcelamento.MdiParent = Me
        Else
            FrmGeralParcelamento.Show()
            FrmGeralParcelamento.MdiParent = Me
        End If
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmParcelamento)().Count() > 0 Then
            FrmParcelamento.Focus()
            FrmParcelamento.MdiParent = Me
        Else
            FrmParcelamento.Show()
            FrmParcelamento.MdiParent = Me
        End If
    End Sub
End Class
