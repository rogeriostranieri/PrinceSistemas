<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSites
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
        Dim EstadoLabel1 As System.Windows.Forms.Label
        Dim CidadeLabel1 As System.Windows.Forms.Label
        Dim SiteEstadoLabel As System.Windows.Forms.Label
        Dim SiteCidadeLabel As System.Windows.Forms.Label
        Dim SiteJuntaUnificadaLabel As System.Windows.Forms.Label
        Dim SiteJuntaAntigaLabel As System.Windows.Forms.Label
        Dim SiteAlvara1Label As System.Windows.Forms.Label
        Dim SiteAlvara2Label As System.Windows.Forms.Label
        Dim DistritoLabel As System.Windows.Forms.Label
        Dim EstadoSiglaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSites))
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.SitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.SiteEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.SiteCidadeTextBox = New System.Windows.Forms.TextBox()
        Me.SiteJuntaUnificadaTextBox = New System.Windows.Forms.TextBox()
        Me.SiteJuntaAntigaTextBox = New System.Windows.Forms.TextBox()
        Me.SiteAlvara1TextBox = New System.Windows.Forms.TextBox()
        Me.SiteAlvara2TextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBuscaGeral = New System.Windows.Forms.TextBox()
        Me.SitesDataGridView = New System.Windows.Forms.DataGridView()
        Me.EstadoSigla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EstadoSiglaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAddNovamente = New System.Windows.Forms.Button()
        Me.BtnAbrir6 = New System.Windows.Forms.Button()
        Me.BtnAbrir5 = New System.Windows.Forms.Button()
        Me.BtnAbrir4 = New System.Windows.Forms.Button()
        Me.BtnAbrir3 = New System.Windows.Forms.Button()
        Me.BtnAbrir2 = New System.Windows.Forms.Button()
        Me.BtnAbrir1 = New System.Windows.Forms.Button()
        Me.DistritoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCidades = New System.Windows.Forms.Button()
        Me.SitesTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.SitesTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        EstadoLabel1 = New System.Windows.Forms.Label()
        CidadeLabel1 = New System.Windows.Forms.Label()
        SiteEstadoLabel = New System.Windows.Forms.Label()
        SiteCidadeLabel = New System.Windows.Forms.Label()
        SiteJuntaUnificadaLabel = New System.Windows.Forms.Label()
        SiteJuntaAntigaLabel = New System.Windows.Forms.Label()
        SiteAlvara1Label = New System.Windows.Forms.Label()
        SiteAlvara2Label = New System.Windows.Forms.Label()
        DistritoLabel = New System.Windows.Forms.Label()
        EstadoSiglaLabel = New System.Windows.Forms.Label()
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.SitesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EstadoLabel1
        '
        EstadoLabel1.AutoSize = True
        EstadoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel1.Location = New System.Drawing.Point(12, 35)
        EstadoLabel1.Name = "EstadoLabel1"
        EstadoLabel1.Size = New System.Drawing.Size(59, 18)
        EstadoLabel1.TabIndex = 5
        EstadoLabel1.Text = "Estado:"
        '
        'CidadeLabel1
        '
        CidadeLabel1.AutoSize = True
        CidadeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel1.Location = New System.Drawing.Point(12, 61)
        CidadeLabel1.Name = "CidadeLabel1"
        CidadeLabel1.Size = New System.Drawing.Size(58, 18)
        CidadeLabel1.TabIndex = 7
        CidadeLabel1.Text = "Cidade:"
        '
        'SiteEstadoLabel
        '
        SiteEstadoLabel.AutoSize = True
        SiteEstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteEstadoLabel.Location = New System.Drawing.Point(37, 149)
        SiteEstadoLabel.Name = "SiteEstadoLabel"
        SiteEstadoLabel.Size = New System.Drawing.Size(109, 18)
        SiteEstadoLabel.TabIndex = 9
        SiteEstadoLabel.Text = "Site do Estado:"
        '
        'SiteCidadeLabel
        '
        SiteCidadeLabel.AutoSize = True
        SiteCidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteCidadeLabel.Location = New System.Drawing.Point(37, 179)
        SiteCidadeLabel.Name = "SiteCidadeLabel"
        SiteCidadeLabel.Size = New System.Drawing.Size(107, 18)
        SiteCidadeLabel.TabIndex = 11
        SiteCidadeLabel.Text = "Site da Cidade:"
        '
        'SiteJuntaUnificadaLabel
        '
        SiteJuntaUnificadaLabel.AutoSize = True
        SiteJuntaUnificadaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteJuntaUnificadaLabel.Location = New System.Drawing.Point(2, 209)
        SiteJuntaUnificadaLabel.Name = "SiteJuntaUnificadaLabel"
        SiteJuntaUnificadaLabel.Size = New System.Drawing.Size(142, 18)
        SiteJuntaUnificadaLabel.TabIndex = 13
        SiteJuntaUnificadaLabel.Text = "Site Junta Unificada:"
        '
        'SiteJuntaAntigaLabel
        '
        SiteJuntaAntigaLabel.AutoSize = True
        SiteJuntaAntigaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteJuntaAntigaLabel.Location = New System.Drawing.Point(23, 239)
        SiteJuntaAntigaLabel.Name = "SiteJuntaAntigaLabel"
        SiteJuntaAntigaLabel.Size = New System.Drawing.Size(121, 18)
        SiteJuntaAntigaLabel.TabIndex = 15
        SiteJuntaAntigaLabel.Text = "Site Junta Antiga:"
        '
        'SiteAlvara1Label
        '
        SiteAlvara1Label.AutoSize = True
        SiteAlvara1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteAlvara1Label.Location = New System.Drawing.Point(51, 269)
        SiteAlvara1Label.Name = "SiteAlvara1Label"
        SiteAlvara1Label.Size = New System.Drawing.Size(93, 18)
        SiteAlvara1Label.TabIndex = 17
        SiteAlvara1Label.Text = "Site Alvara 1:"
        '
        'SiteAlvara2Label
        '
        SiteAlvara2Label.AutoSize = True
        SiteAlvara2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteAlvara2Label.Location = New System.Drawing.Point(51, 299)
        SiteAlvara2Label.Name = "SiteAlvara2Label"
        SiteAlvara2Label.Size = New System.Drawing.Size(93, 18)
        SiteAlvara2Label.TabIndex = 19
        SiteAlvara2Label.Text = "Site Alvara 2:"
        '
        'DistritoLabel
        '
        DistritoLabel.AutoSize = True
        DistritoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DistritoLabel.Location = New System.Drawing.Point(12, 88)
        DistritoLabel.Name = "DistritoLabel"
        DistritoLabel.Size = New System.Drawing.Size(59, 18)
        DistritoLabel.TabIndex = 20
        DistritoLabel.Text = "Distrito:"
        '
        'EstadoSiglaLabel
        '
        EstadoSiglaLabel.AutoSize = True
        EstadoSiglaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoSiglaLabel.Location = New System.Drawing.Point(286, 35)
        EstadoSiglaLabel.Name = "EstadoSiglaLabel"
        EstadoSiglaLabel.Size = New System.Drawing.Size(44, 18)
        EstadoSiglaLabel.TabIndex = 54
        EstadoSiglaLabel.Text = "Sigla:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.Location = New System.Drawing.Point(77, 32)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(189, 24)
        Me.EstadoTextBox.TabIndex = 6
        '
        'SitesBindingSource
        '
        Me.SitesBindingSource.DataMember = "Sites"
        Me.SitesBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.Location = New System.Drawing.Point(77, 58)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(312, 24)
        Me.CidadeTextBox.TabIndex = 8
        '
        'SiteEstadoTextBox
        '
        Me.SiteEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteEstado", True))
        Me.SiteEstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteEstadoTextBox.Location = New System.Drawing.Point(150, 146)
        Me.SiteEstadoTextBox.Name = "SiteEstadoTextBox"
        Me.SiteEstadoTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteEstadoTextBox.TabIndex = 10
        '
        'SiteCidadeTextBox
        '
        Me.SiteCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteCidade", True))
        Me.SiteCidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteCidadeTextBox.Location = New System.Drawing.Point(150, 176)
        Me.SiteCidadeTextBox.Name = "SiteCidadeTextBox"
        Me.SiteCidadeTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteCidadeTextBox.TabIndex = 12
        '
        'SiteJuntaUnificadaTextBox
        '
        Me.SiteJuntaUnificadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteJuntaUnificada", True))
        Me.SiteJuntaUnificadaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteJuntaUnificadaTextBox.Location = New System.Drawing.Point(150, 206)
        Me.SiteJuntaUnificadaTextBox.Name = "SiteJuntaUnificadaTextBox"
        Me.SiteJuntaUnificadaTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteJuntaUnificadaTextBox.TabIndex = 14
        '
        'SiteJuntaAntigaTextBox
        '
        Me.SiteJuntaAntigaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteJuntaAntiga", True))
        Me.SiteJuntaAntigaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteJuntaAntigaTextBox.Location = New System.Drawing.Point(150, 236)
        Me.SiteJuntaAntigaTextBox.Name = "SiteJuntaAntigaTextBox"
        Me.SiteJuntaAntigaTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteJuntaAntigaTextBox.TabIndex = 16
        '
        'SiteAlvara1TextBox
        '
        Me.SiteAlvara1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteAlvara1", True))
        Me.SiteAlvara1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteAlvara1TextBox.Location = New System.Drawing.Point(150, 266)
        Me.SiteAlvara1TextBox.Name = "SiteAlvara1TextBox"
        Me.SiteAlvara1TextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteAlvara1TextBox.TabIndex = 18
        '
        'SiteAlvara2TextBox
        '
        Me.SiteAlvara2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteAlvara2", True))
        Me.SiteAlvara2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteAlvara2TextBox.Location = New System.Drawing.Point(150, 296)
        Me.SiteAlvara2TextBox.Name = "SiteAlvara2TextBox"
        Me.SiteAlvara2TextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteAlvara2TextBox.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.43578!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56421!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.15118!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.84882!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(693, 549)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.BtnEditar)
        Me.GroupBox5.Controls.Add(Me.BtnNovo)
        Me.GroupBox5.Controls.Add(Me.BtnSalvar)
        Me.GroupBox5.Controls.Add(Me.BtnExcluir)
        Me.GroupBox5.Controls.Add(Me.BtnFechar)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(602, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(88, 175)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MENU"
        '
        'BtnEditar
        '
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(13, 72)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(69, 23)
        Me.BtnEditar.TabIndex = 77
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(13, 15)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(69, 22)
        Me.BtnNovo.TabIndex = 46
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Location = New System.Drawing.Point(13, 43)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 23)
        Me.BtnSalvar.TabIndex = 48
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = CType(resources.GetObject("BtnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(13, 117)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(69, 23)
        Me.BtnExcluir.TabIndex = 47
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Location = New System.Drawing.Point(13, 146)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 23)
        Me.BtnFechar.TabIndex = 49
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.TextBoxBuscaGeral)
        Me.GroupBox.Controls.Add(Me.SitesDataGridView)
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(593, 175)
        Me.GroupBox.TabIndex = 59
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Geral"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar:"
        '
        'TextBoxBuscaGeral
        '
        Me.TextBoxBuscaGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscaGeral.Location = New System.Drawing.Point(77, 23)
        Me.TextBoxBuscaGeral.Name = "TextBoxBuscaGeral"
        Me.TextBoxBuscaGeral.Size = New System.Drawing.Size(483, 24)
        Me.TextBoxBuscaGeral.TabIndex = 1
        '
        'SitesDataGridView
        '
        Me.SitesDataGridView.AllowUserToAddRows = False
        Me.SitesDataGridView.AllowUserToDeleteRows = False
        Me.SitesDataGridView.AutoGenerateColumns = False
        Me.SitesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SitesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SitesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EstadoSigla, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10})
        Me.SitesDataGridView.DataSource = Me.SitesBindingSource
        Me.SitesDataGridView.Location = New System.Drawing.Point(15, 54)
        Me.SitesDataGridView.Name = "SitesDataGridView"
        Me.SitesDataGridView.ReadOnly = True
        Me.SitesDataGridView.Size = New System.Drawing.Size(545, 116)
        Me.SitesDataGridView.TabIndex = 0
        '
        'EstadoSigla
        '
        Me.EstadoSigla.DataPropertyName = "EstadoSigla"
        Me.EstadoSigla.HeaderText = "Sigla"
        Me.EstadoSigla.Name = "EstadoSigla"
        Me.EstadoSigla.ReadOnly = True
        Me.EstadoSigla.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cidade"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cidade"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Distrito"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Distrito"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 64
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(EstadoSiglaLabel)
        Me.GroupBox2.Controls.Add(Me.EstadoSiglaTextBox)
        Me.GroupBox2.Controls.Add(Me.BtnAddNovamente)
        Me.GroupBox2.Controls.Add(Me.BtnAbrir6)
        Me.GroupBox2.Controls.Add(Me.BtnAbrir5)
        Me.GroupBox2.Controls.Add(Me.BtnAbrir4)
        Me.GroupBox2.Controls.Add(Me.BtnAbrir3)
        Me.GroupBox2.Controls.Add(Me.BtnAbrir2)
        Me.GroupBox2.Controls.Add(Me.BtnAbrir1)
        Me.GroupBox2.Controls.Add(DistritoLabel)
        Me.GroupBox2.Controls.Add(Me.DistritoTextBox)
        Me.GroupBox2.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox2.Controls.Add(CidadeLabel1)
        Me.GroupBox2.Controls.Add(Me.SiteEstadoTextBox)
        Me.GroupBox2.Controls.Add(EstadoLabel1)
        Me.GroupBox2.Controls.Add(SiteAlvara2Label)
        Me.GroupBox2.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox2.Controls.Add(SiteEstadoLabel)
        Me.GroupBox2.Controls.Add(Me.SiteAlvara2TextBox)
        Me.GroupBox2.Controls.Add(Me.SiteCidadeTextBox)
        Me.GroupBox2.Controls.Add(SiteAlvara1Label)
        Me.GroupBox2.Controls.Add(SiteCidadeLabel)
        Me.GroupBox2.Controls.Add(Me.SiteAlvara1TextBox)
        Me.GroupBox2.Controls.Add(Me.SiteJuntaUnificadaTextBox)
        Me.GroupBox2.Controls.Add(SiteJuntaAntigaLabel)
        Me.GroupBox2.Controls.Add(SiteJuntaUnificadaLabel)
        Me.GroupBox2.Controls.Add(Me.SiteJuntaAntigaTextBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 362)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'EstadoSiglaTextBox
        '
        Me.EstadoSiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "EstadoSigla", True))
        Me.EstadoSiglaTextBox.Enabled = False
        Me.EstadoSiglaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoSiglaTextBox.Location = New System.Drawing.Point(336, 29)
        Me.EstadoSiglaTextBox.Name = "EstadoSiglaTextBox"
        Me.EstadoSiglaTextBox.ReadOnly = True
        Me.EstadoSiglaTextBox.Size = New System.Drawing.Size(53, 24)
        Me.EstadoSiglaTextBox.TabIndex = 55
        '
        'BtnAddNovamente
        '
        Me.BtnAddNovamente.BackgroundImage = CType(resources.GetObject("BtnAddNovamente.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNovamente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNovamente.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnAddNovamente.Location = New System.Drawing.Point(491, 16)
        Me.BtnAddNovamente.Name = "BtnAddNovamente"
        Me.BtnAddNovamente.Size = New System.Drawing.Size(69, 37)
        Me.BtnAddNovamente.TabIndex = 54
        Me.BtnAddNovamente.Text = "Adicionar Cidade"
        Me.BtnAddNovamente.UseVisualStyleBackColor = True
        '
        'BtnAbrir6
        '
        Me.BtnAbrir6.BackgroundImage = CType(resources.GetObject("BtnAbrir6.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir6.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir6.Location = New System.Drawing.Point(513, 297)
        Me.BtnAbrir6.Name = "BtnAbrir6"
        Me.BtnAbrir6.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir6.TabIndex = 53
        Me.BtnAbrir6.Text = "Abrir"
        Me.BtnAbrir6.UseVisualStyleBackColor = True
        '
        'BtnAbrir5
        '
        Me.BtnAbrir5.BackgroundImage = CType(resources.GetObject("BtnAbrir5.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir5.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir5.Location = New System.Drawing.Point(513, 267)
        Me.BtnAbrir5.Name = "BtnAbrir5"
        Me.BtnAbrir5.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir5.TabIndex = 52
        Me.BtnAbrir5.Text = "Abrir"
        Me.BtnAbrir5.UseVisualStyleBackColor = True
        '
        'BtnAbrir4
        '
        Me.BtnAbrir4.BackgroundImage = CType(resources.GetObject("BtnAbrir4.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir4.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir4.Location = New System.Drawing.Point(513, 237)
        Me.BtnAbrir4.Name = "BtnAbrir4"
        Me.BtnAbrir4.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir4.TabIndex = 51
        Me.BtnAbrir4.Text = "Abrir"
        Me.BtnAbrir4.UseVisualStyleBackColor = True
        '
        'BtnAbrir3
        '
        Me.BtnAbrir3.BackgroundImage = CType(resources.GetObject("BtnAbrir3.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir3.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir3.Location = New System.Drawing.Point(513, 207)
        Me.BtnAbrir3.Name = "BtnAbrir3"
        Me.BtnAbrir3.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir3.TabIndex = 50
        Me.BtnAbrir3.Text = "Abrir"
        Me.BtnAbrir3.UseVisualStyleBackColor = True
        '
        'BtnAbrir2
        '
        Me.BtnAbrir2.BackgroundImage = CType(resources.GetObject("BtnAbrir2.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir2.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir2.Location = New System.Drawing.Point(513, 177)
        Me.BtnAbrir2.Name = "BtnAbrir2"
        Me.BtnAbrir2.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir2.TabIndex = 49
        Me.BtnAbrir2.Text = "Abrir"
        Me.BtnAbrir2.UseVisualStyleBackColor = True
        '
        'BtnAbrir1
        '
        Me.BtnAbrir1.BackgroundImage = CType(resources.GetObject("BtnAbrir1.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir1.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir1.Location = New System.Drawing.Point(513, 146)
        Me.BtnAbrir1.Name = "BtnAbrir1"
        Me.BtnAbrir1.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir1.TabIndex = 48
        Me.BtnAbrir1.Text = "Abrir"
        Me.BtnAbrir1.UseVisualStyleBackColor = True
        '
        'DistritoTextBox
        '
        Me.DistritoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Distrito", True))
        Me.DistritoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistritoTextBox.Location = New System.Drawing.Point(77, 85)
        Me.DistritoTextBox.Name = "DistritoTextBox"
        Me.DistritoTextBox.Size = New System.Drawing.Size(312, 24)
        Me.DistritoTextBox.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(602, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 362)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.BtnCidades)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(82, 343)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extra"
        '
        'BtnCidades
        '
        Me.BtnCidades.BackgroundImage = CType(resources.GetObject("BtnCidades.BackgroundImage"), System.Drawing.Image)
        Me.BtnCidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCidades.Location = New System.Drawing.Point(10, 18)
        Me.BtnCidades.Name = "BtnCidades"
        Me.BtnCidades.Size = New System.Drawing.Size(69, 23)
        Me.BtnCidades.TabIndex = 77
        Me.BtnCidades.Text = "Cidades"
        Me.BtnCidades.UseVisualStyleBackColor = True
        '
        'SitesTableAdapter
        '
        Me.SitesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BombeiroSituacaoTableAdapter = Nothing
        Me.TableAdapterManager.BrasilDistritosTableAdapter = Nothing
        Me.TableAdapterManager.BrasilEstadoTableAdapter = Nothing
        Me.TableAdapterManager.BrasilMunicipiosTableAdapter = Nothing
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAEprefMaringaPRTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Me.SitesTableAdapter
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmSites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(693, 549)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSites"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle Sites"
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.SitesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents SitesBindingSource As BindingSource
    Friend WithEvents SitesTableAdapter As PrinceDBDataSetTableAdapters.SitesTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents SiteEstadoTextBox As TextBox
    Friend WithEvents SiteCidadeTextBox As TextBox
    Friend WithEvents SiteJuntaUnificadaTextBox As TextBox
    Friend WithEvents SiteJuntaAntigaTextBox As TextBox
    Friend WithEvents SiteAlvara1TextBox As TextBox
    Friend WithEvents SiteAlvara2TextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DistritoTextBox As TextBox
    Friend WithEvents BtnAbrir1 As Button
    Friend WithEvents BtnAbrir6 As Button
    Friend WithEvents BtnAbrir5 As Button
    Friend WithEvents BtnAbrir4 As Button
    Friend WithEvents BtnAbrir3 As Button
    Friend WithEvents BtnAbrir2 As Button
    Friend WithEvents BtnAddNovamente As Button
    Friend WithEvents SitesDataGridView As DataGridView
    Friend WithEvents TextBoxBuscaGeral As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCidades As Button
    Friend WithEvents EstadoSiglaTextBox As TextBox
    Friend WithEvents EstadoSigla As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
