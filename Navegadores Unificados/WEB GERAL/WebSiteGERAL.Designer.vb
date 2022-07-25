<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WebSiteGERAL
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebSiteGERAL))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TxtCarregamento = New System.Windows.Forms.ToolStripLabel()
        Me.WebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnIR = New System.Windows.Forms.PictureBox()
        Me.BtnVoltar = New System.Windows.Forms.PictureBox()
        Me.BtnAvancar = New System.Windows.Forms.PictureBox()
        Me.BtnAtualizar = New System.Windows.Forms.PictureBox()
        Me.BtnHome = New System.Windows.Forms.PictureBox()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BtnSimplesNacionalSolicitação = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSimplesNacionalPrimeiraParteInício = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSimplesNacionalSegundasParteDados = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BtnRedeSimAbertura = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnREDESIMAlteracao = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnREDESIMBaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnAddFavoritos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnFavoritos = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.WebView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAvancar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.TxtCarregamento})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 606)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(788, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 22)
        '
        'TxtCarregamento
        '
        Me.TxtCarregamento.Name = "TxtCarregamento"
        Me.TxtCarregamento.Size = New System.Drawing.Size(19, 22)
        Me.TxtCarregamento.Text = "..."
        '
        'WebView
        '
        Me.WebView.AllowExternalDrop = True
        Me.WebView.CreationProperties = Nothing
        Me.WebView.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView.Location = New System.Drawing.Point(3, 3)
        Me.WebView.Name = "WebView"
        Me.WebView.Size = New System.Drawing.Size(768, 472)
        Me.WebView.TabIndex = 3
        Me.WebView.ZoomFactor = 1.0R
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 99)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 504)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnIR, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnVoltar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAvancar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAtualizar, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnHome, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtURL, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 7, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 29)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(782, 37)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'BtnIR
        '
        Me.BtnIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIR.Image = Global.PrinceSistemas.My.Resources.Resources.acessar
        Me.BtnIR.Location = New System.Drawing.Point(686, 3)
        Me.BtnIR.Name = "BtnIR"
        Me.BtnIR.Size = New System.Drawing.Size(32, 30)
        Me.BtnIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnIR.TabIndex = 0
        Me.BtnIR.TabStop = False
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVoltar.Image = Global.PrinceSistemas.My.Resources.Resources.voltar
        Me.BtnVoltar.Location = New System.Drawing.Point(11, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(32, 30)
        Me.BtnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnVoltar.TabIndex = 1
        Me.BtnVoltar.TabStop = False
        '
        'BtnAvancar
        '
        Me.BtnAvancar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAvancar.Image = Global.PrinceSistemas.My.Resources.Resources.avancar
        Me.BtnAvancar.Location = New System.Drawing.Point(54, 3)
        Me.BtnAvancar.Name = "BtnAvancar"
        Me.BtnAvancar.Size = New System.Drawing.Size(32, 30)
        Me.BtnAvancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAvancar.TabIndex = 2
        Me.BtnAvancar.TabStop = False
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAtualizar.Image = Global.PrinceSistemas.My.Resources.Resources.atualizar_azu
        Me.BtnAtualizar.Location = New System.Drawing.Point(97, 3)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(32, 30)
        Me.BtnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAtualizar.TabIndex = 3
        Me.BtnAtualizar.TabStop = False
        '
        'BtnHome
        '
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.Image = Global.PrinceSistemas.My.Resources.Resources.home
        Me.BtnHome.Location = New System.Drawing.Point(141, 3)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(32, 30)
        Me.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnHome.TabIndex = 4
        Me.BtnHome.TabStop = False
        '
        'TxtURL
        '
        Me.TxtURL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtURL.Location = New System.Drawing.Point(181, 3)
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(499, 26)
        Me.TxtURL.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.Fechar_Icone
        Me.PictureBox1.Location = New System.Drawing.Point(747, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(788, 631)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator2, Me.ToolStripDropDownButton2, Me.ToolStripSeparator3, Me.ToolStripDropDownButton3})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(788, 26)
        Me.ToolStrip3.TabIndex = 9
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(60, 23)
        Me.ToolStripDropDownButton1.Text = "Opções"
        Me.ToolStripDropDownButton1.ToolTipText = "Opções"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem1.Text = "Pagina Inicial"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 23)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSimplesNacionalSolicitação, Me.BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso, Me.AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem, Me.ToolStripSeparator4})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(111, 23)
        Me.ToolStripDropDownButton2.Text = "Simples Nacional"
        '
        'BtnSimplesNacionalSolicitação
        '
        Me.BtnSimplesNacionalSolicitação.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSimplesNacionalPrimeiraParteInício, Me.BtnSimplesNacionalSegundasParteDados})
        Me.BtnSimplesNacionalSolicitação.Name = "BtnSimplesNacionalSolicitação"
        Me.BtnSimplesNacionalSolicitação.Size = New System.Drawing.Size(437, 22)
        Me.BtnSimplesNacionalSolicitação.Text = "Solicitação de Opção pelo Simples Nacional"
        '
        'BtnSimplesNacionalPrimeiraParteInício
        '
        Me.BtnSimplesNacionalPrimeiraParteInício.Name = "BtnSimplesNacionalPrimeiraParteInício"
        Me.BtnSimplesNacionalPrimeiraParteInício.Size = New System.Drawing.Size(191, 22)
        Me.BtnSimplesNacionalPrimeiraParteInício.Text = "Primeira Parte - Início"
        '
        'BtnSimplesNacionalSegundasParteDados
        '
        Me.BtnSimplesNacionalSegundasParteDados.Name = "BtnSimplesNacionalSegundasParteDados"
        Me.BtnSimplesNacionalSegundasParteDados.Size = New System.Drawing.Size(234, 22)
        Me.BtnSimplesNacionalSegundasParteDados.Text = "Exportar Data Final do Simples"
        '
        'BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso
        '
        Me.BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarDadosToolStripMenuItem, Me.ExportarCódigoToolStripMenuItem})
        Me.BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso.Name = "BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso"
        Me.BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso.Size = New System.Drawing.Size(437, 22)
        Me.BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso.Text = "Criar ou Alterar seu Código de Acesso"
        '
        'ImportarDadosToolStripMenuItem
        '
        Me.ImportarDadosToolStripMenuItem.Name = "ImportarDadosToolStripMenuItem"
        Me.ImportarDadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImportarDadosToolStripMenuItem.Text = "Importar Dados"
        '
        'ExportarCódigoToolStripMenuItem
        '
        Me.ExportarCódigoToolStripMenuItem.Name = "ExportarCódigoToolStripMenuItem"
        Me.ExportarCódigoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportarCódigoToolStripMenuItem.Text = "Exportar Código"
        '
        'AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem
        '
        Me.AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem.Name = "AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem"
        Me.AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem.Size = New System.Drawing.Size(437, 22)
        Me.AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem.Text = "Acompanhamento da Formalização da Opção pelo Simples Nacional"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(434, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRedeSimAbertura, Me.BtnREDESIMAlteracao, Me.BtnREDESIMBaixa, Me.ToolStripSeparator5})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(67, 23)
        Me.ToolStripDropDownButton3.Text = "REDESIM"
        '
        'BtnRedeSimAbertura
        '
        Me.BtnRedeSimAbertura.Name = "BtnRedeSimAbertura"
        Me.BtnRedeSimAbertura.Size = New System.Drawing.Size(124, 22)
        Me.BtnRedeSimAbertura.Text = "Abertura"
        '
        'BtnREDESIMAlteracao
        '
        Me.BtnREDESIMAlteracao.Name = "BtnREDESIMAlteracao"
        Me.BtnREDESIMAlteracao.Size = New System.Drawing.Size(124, 22)
        Me.BtnREDESIMAlteracao.Text = "Alteração"
        '
        'BtnREDESIMBaixa
        '
        Me.BtnREDESIMBaixa.Name = "BtnREDESIMBaixa"
        Me.BtnREDESIMBaixa.Size = New System.Drawing.Size(124, 22)
        Me.BtnREDESIMBaixa.Text = "Baixa"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(121, 6)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddFavoritos, Me.ToolStripSeparator1, Me.BtnFavoritos})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 69)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(788, 27)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAddFavoritos
        '
        Me.BtnAddFavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddFavoritos.Image = Global.PrinceSistemas.My.Resources.Resources.favoritos_add
        Me.BtnAddFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddFavoritos.Name = "BtnAddFavoritos"
        Me.BtnAddFavoritos.Size = New System.Drawing.Size(23, 24)
        Me.BtnAddFavoritos.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BtnFavoritos
        '
        Me.BtnFavoritos.Image = Global.PrinceSistemas.My.Resources.Resources.favorito
        Me.BtnFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFavoritos.Name = "BtnFavoritos"
        Me.BtnFavoritos.Size = New System.Drawing.Size(87, 24)
        Me.BtnFavoritos.Text = "Favoritos"
        '
        'WebSiteGERAL
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(788, 631)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "WebSiteGERAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebSiteGERAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.WebView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.BtnIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAvancar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents TxtCarregamento As ToolStripLabel
    Friend WithEvents WebView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnIR As PictureBox
    Friend WithEvents BtnVoltar As PictureBox
    Friend WithEvents BtnAvancar As PictureBox
    Friend WithEvents BtnAtualizar As PictureBox
    Friend WithEvents BtnHome As PictureBox
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents BtnFavoritos As ToolStripSplitButton
    Friend WithEvents BtnAddFavoritos As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents BtnSimplesNacionalCriarOuAlterarSeuCódigoDeAcesso As ToolStripMenuItem
    Friend WithEvents AcompanhamentoDaFormalizaçãoDaOpçãoPeloSimplesNacionalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnSimplesNacionalSolicitação As ToolStripMenuItem
    Friend WithEvents BtnSimplesNacionalPrimeiraParteInício As ToolStripMenuItem
    Friend WithEvents BtnSimplesNacionalSegundasParteDados As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents BtnRedeSimAbertura As ToolStripMenuItem
    Friend WithEvents BtnREDESIMAlteracao As ToolStripMenuItem
    Friend WithEvents BtnREDESIMBaixa As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ImportarDadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarCódigoToolStripMenuItem As ToolStripMenuItem
End Class
