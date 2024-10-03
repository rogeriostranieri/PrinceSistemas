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
        Dim SiteAlvaraPedido1Label As System.Windows.Forms.Label
        Dim SiteAlvaraPedido2Label As System.Windows.Forms.Label
        Dim SitePrefProtocoloLabel As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim SiteREDESIMMeuCNPJLabel As System.Windows.Forms.Label
        Dim SiteREDESIMAbrirCNPJLabel As System.Windows.Forms.Label
        Dim SiteREDESIMConsultaCNPJLabel As System.Windows.Forms.Label
        Dim SiteREDESIMProtocoloLabel As System.Windows.Forms.Label
        Dim BombeiroConsultaLabel As System.Windows.Forms.Label
        Dim BombeiroSolicitaLabel As System.Windows.Forms.Label
        Dim BombeiroUnificadoLabel As System.Windows.Forms.Label
        Dim BombeiroREDESIMLabel As System.Windows.Forms.Label
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ObservacoesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnSiteREDESIMMeuCNPJ = New System.Windows.Forms.Button()
        Me.BtnSiteREDESIMProtocolo = New System.Windows.Forms.Button()
        Me.BtnSiteREDESIMAbrirCNPJ = New System.Windows.Forms.Button()
        Me.BtnSiteREDESIMConsultaCNPJ = New System.Windows.Forms.Button()
        Me.SiteREDESIMMeuCNPJTextBox = New System.Windows.Forms.TextBox()
        Me.SiteREDESIMAbrirCNPJTextBox = New System.Windows.Forms.TextBox()
        Me.SiteREDESIMConsultaCNPJTextBox = New System.Windows.Forms.TextBox()
        Me.SiteREDESIMProtocoloTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnBombeiroREDESIM = New System.Windows.Forms.Button()
        Me.BtnBombeiroUnificado = New System.Windows.Forms.Button()
        Me.BombeiroREDESIMTextBox = New System.Windows.Forms.TextBox()
        Me.BombeiroUnificadoTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.BtnBombeiroConsulta = New System.Windows.Forms.Button()
        Me.BtnBombeiroSolicita = New System.Windows.Forms.Button()
        Me.BombeiroSolicitaTextBox = New System.Windows.Forms.TextBox()
        Me.BombeiroConsultaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAbrir1 = New System.Windows.Forms.Button()
        Me.BtnAbrir4 = New System.Windows.Forms.Button()
        Me.BtnAbrir3 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnPrefProtocolo = New System.Windows.Forms.Button()
        Me.SitePrefProtocoloTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAlvaraPedido2 = New System.Windows.Forms.Button()
        Me.BtnAlvaraPedido1 = New System.Windows.Forms.Button()
        Me.SiteAlvaraPedido2TextBox = New System.Windows.Forms.TextBox()
        Me.SiteAlvaraPedido1TextBox = New System.Windows.Forms.TextBox()
        Me.BtnAbrir2 = New System.Windows.Forms.Button()
        Me.BtnAbrir6 = New System.Windows.Forms.Button()
        Me.BtnAbrir5 = New System.Windows.Forms.Button()
        Me.EstadoSiglaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAddNovamente = New System.Windows.Forms.Button()
        Me.DistritoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCidades = New System.Windows.Forms.Button()
        Me.SitesTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.SitesTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
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
        SiteAlvaraPedido1Label = New System.Windows.Forms.Label()
        SiteAlvaraPedido2Label = New System.Windows.Forms.Label()
        SitePrefProtocoloLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        SiteREDESIMMeuCNPJLabel = New System.Windows.Forms.Label()
        SiteREDESIMAbrirCNPJLabel = New System.Windows.Forms.Label()
        SiteREDESIMConsultaCNPJLabel = New System.Windows.Forms.Label()
        SiteREDESIMProtocoloLabel = New System.Windows.Forms.Label()
        BombeiroConsultaLabel = New System.Windows.Forms.Label()
        BombeiroSolicitaLabel = New System.Windows.Forms.Label()
        BombeiroUnificadoLabel = New System.Windows.Forms.Label()
        BombeiroREDESIMLabel = New System.Windows.Forms.Label()
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.SitesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        SiteEstadoLabel.Location = New System.Drawing.Point(84, 13)
        SiteEstadoLabel.Name = "SiteEstadoLabel"
        SiteEstadoLabel.Size = New System.Drawing.Size(109, 18)
        SiteEstadoLabel.TabIndex = 9
        SiteEstadoLabel.Text = "Site do Estado:"
        '
        'SiteCidadeLabel
        '
        SiteCidadeLabel.AutoSize = True
        SiteCidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteCidadeLabel.Location = New System.Drawing.Point(12, 22)
        SiteCidadeLabel.Name = "SiteCidadeLabel"
        SiteCidadeLabel.Size = New System.Drawing.Size(107, 18)
        SiteCidadeLabel.TabIndex = 11
        SiteCidadeLabel.Text = "Site da Cidade:"
        '
        'SiteJuntaUnificadaLabel
        '
        SiteJuntaUnificadaLabel.AutoSize = True
        SiteJuntaUnificadaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteJuntaUnificadaLabel.Location = New System.Drawing.Point(49, 43)
        SiteJuntaUnificadaLabel.Name = "SiteJuntaUnificadaLabel"
        SiteJuntaUnificadaLabel.Size = New System.Drawing.Size(142, 18)
        SiteJuntaUnificadaLabel.TabIndex = 13
        SiteJuntaUnificadaLabel.Text = "Site Junta Unificada:"
        '
        'SiteJuntaAntigaLabel
        '
        SiteJuntaAntigaLabel.AutoSize = True
        SiteJuntaAntigaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteJuntaAntigaLabel.Location = New System.Drawing.Point(70, 73)
        SiteJuntaAntigaLabel.Name = "SiteJuntaAntigaLabel"
        SiteJuntaAntigaLabel.Size = New System.Drawing.Size(121, 18)
        SiteJuntaAntigaLabel.TabIndex = 15
        SiteJuntaAntigaLabel.Text = "Site Junta Antiga:"
        '
        'SiteAlvara1Label
        '
        SiteAlvara1Label.AutoSize = True
        SiteAlvara1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteAlvara1Label.Location = New System.Drawing.Point(26, 92)
        SiteAlvara1Label.Name = "SiteAlvara1Label"
        SiteAlvara1Label.Size = New System.Drawing.Size(93, 18)
        SiteAlvara1Label.TabIndex = 17
        SiteAlvara1Label.Text = "Site Alvara 1:"
        '
        'SiteAlvara2Label
        '
        SiteAlvara2Label.AutoSize = True
        SiteAlvara2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteAlvara2Label.Location = New System.Drawing.Point(26, 122)
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
        'SiteAlvaraPedido1Label
        '
        SiteAlvaraPedido1Label.AutoSize = True
        SiteAlvaraPedido1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteAlvaraPedido1Label.Location = New System.Drawing.Point(8, 152)
        SiteAlvaraPedido1Label.Name = "SiteAlvaraPedido1Label"
        SiteAlvaraPedido1Label.Size = New System.Drawing.Size(114, 18)
        SiteAlvaraPedido1Label.TabIndex = 53
        SiteAlvaraPedido1Label.Text = "Alvara Pedido 1:"
        '
        'SiteAlvaraPedido2Label
        '
        SiteAlvaraPedido2Label.AutoSize = True
        SiteAlvaraPedido2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteAlvaraPedido2Label.Location = New System.Drawing.Point(8, 182)
        SiteAlvaraPedido2Label.Name = "SiteAlvaraPedido2Label"
        SiteAlvaraPedido2Label.Size = New System.Drawing.Size(114, 18)
        SiteAlvaraPedido2Label.TabIndex = 54
        SiteAlvaraPedido2Label.Text = "Alvara Pedido 2:"
        '
        'SitePrefProtocoloLabel
        '
        SitePrefProtocoloLabel.AutoSize = True
        SitePrefProtocoloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SitePrefProtocoloLabel.Location = New System.Drawing.Point(41, 52)
        SitePrefProtocoloLabel.Name = "SitePrefProtocoloLabel"
        SitePrefProtocoloLabel.Size = New System.Drawing.Size(78, 18)
        SitePrefProtocoloLabel.TabIndex = 57
        SitePrefProtocoloLabel.Text = "Protocolo:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(6, 14)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(145, 18)
        ObservacoesLabel.TabIndex = 0
        ObservacoesLabel.Text = "Observações Gerais"
        '
        'SiteREDESIMMeuCNPJLabel
        '
        SiteREDESIMMeuCNPJLabel.AutoSize = True
        SiteREDESIMMeuCNPJLabel.Location = New System.Drawing.Point(30, 115)
        SiteREDESIMMeuCNPJLabel.Name = "SiteREDESIMMeuCNPJLabel"
        SiteREDESIMMeuCNPJLabel.Size = New System.Drawing.Size(157, 18)
        SiteREDESIMMeuCNPJLabel.TabIndex = 68
        SiteREDESIMMeuCNPJLabel.Text = "REDESIM Meu CNPJ:"
        '
        'SiteREDESIMAbrirCNPJLabel
        '
        SiteREDESIMAbrirCNPJLabel.AutoSize = True
        SiteREDESIMAbrirCNPJLabel.Location = New System.Drawing.Point(29, 86)
        SiteREDESIMAbrirCNPJLabel.Name = "SiteREDESIMAbrirCNPJLabel"
        SiteREDESIMAbrirCNPJLabel.Size = New System.Drawing.Size(158, 18)
        SiteREDESIMAbrirCNPJLabel.TabIndex = 66
        SiteREDESIMAbrirCNPJLabel.Text = "REDESIM Abrir CNPJ:"
        '
        'SiteREDESIMConsultaCNPJLabel
        '
        SiteREDESIMConsultaCNPJLabel.AutoSize = True
        SiteREDESIMConsultaCNPJLabel.Location = New System.Drawing.Point(3, 55)
        SiteREDESIMConsultaCNPJLabel.Name = "SiteREDESIMConsultaCNPJLabel"
        SiteREDESIMConsultaCNPJLabel.Size = New System.Drawing.Size(187, 18)
        SiteREDESIMConsultaCNPJLabel.TabIndex = 64
        SiteREDESIMConsultaCNPJLabel.Text = "REDESIM Consulta CNPJ:"
        '
        'SiteREDESIMProtocoloLabel
        '
        SiteREDESIMProtocoloLabel.AutoSize = True
        SiteREDESIMProtocoloLabel.Location = New System.Drawing.Point(37, 25)
        SiteREDESIMProtocoloLabel.Name = "SiteREDESIMProtocoloLabel"
        SiteREDESIMProtocoloLabel.Size = New System.Drawing.Size(150, 18)
        SiteREDESIMProtocoloLabel.TabIndex = 63
        SiteREDESIMProtocoloLabel.Text = "REDESIM Protocolo:"
        '
        'BombeiroConsultaLabel
        '
        BombeiroConsultaLabel.AutoSize = True
        BombeiroConsultaLabel.Location = New System.Drawing.Point(41, 134)
        BombeiroConsultaLabel.Name = "BombeiroConsultaLabel"
        BombeiroConsultaLabel.Size = New System.Drawing.Size(149, 18)
        BombeiroConsultaLabel.TabIndex = 51
        BombeiroConsultaLabel.Text = "Bombeiro - Consulta:"
        '
        'BombeiroSolicitaLabel
        '
        BombeiroSolicitaLabel.AutoSize = True
        BombeiroSolicitaLabel.Location = New System.Drawing.Point(27, 104)
        BombeiroSolicitaLabel.Name = "BombeiroSolicitaLabel"
        BombeiroSolicitaLabel.Size = New System.Drawing.Size(163, 18)
        BombeiroSolicitaLabel.TabIndex = 52
        BombeiroSolicitaLabel.Text = "Bombeiro - Solicitação:"
        '
        'BombeiroUnificadoLabel
        '
        BombeiroUnificadoLabel.AutoSize = True
        BombeiroUnificadoLabel.Location = New System.Drawing.Point(47, 164)
        BombeiroUnificadoLabel.Name = "BombeiroUnificadoLabel"
        BombeiroUnificadoLabel.Size = New System.Drawing.Size(143, 18)
        BombeiroUnificadoLabel.TabIndex = 78
        BombeiroUnificadoLabel.Text = "Bombeiro Unificado:"
        '
        'BombeiroREDESIMLabel
        '
        BombeiroREDESIMLabel.AutoSize = True
        BombeiroREDESIMLabel.Location = New System.Drawing.Point(41, 194)
        BombeiroREDESIMLabel.Name = "BombeiroREDESIMLabel"
        BombeiroREDESIMLabel.Size = New System.Drawing.Size(149, 18)
        BombeiroREDESIMLabel.TabIndex = 79
        BombeiroREDESIMLabel.Text = "Bombeiro REDESIM:"
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
        Me.SiteEstadoTextBox.Location = New System.Drawing.Point(196, 11)
        Me.SiteEstadoTextBox.Name = "SiteEstadoTextBox"
        Me.SiteEstadoTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteEstadoTextBox.TabIndex = 10
        '
        'SiteCidadeTextBox
        '
        Me.SiteCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteCidade", True))
        Me.SiteCidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteCidadeTextBox.Location = New System.Drawing.Point(125, 19)
        Me.SiteCidadeTextBox.Name = "SiteCidadeTextBox"
        Me.SiteCidadeTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteCidadeTextBox.TabIndex = 12
        '
        'SiteJuntaUnificadaTextBox
        '
        Me.SiteJuntaUnificadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteJuntaUnificada", True))
        Me.SiteJuntaUnificadaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteJuntaUnificadaTextBox.Location = New System.Drawing.Point(196, 41)
        Me.SiteJuntaUnificadaTextBox.Name = "SiteJuntaUnificadaTextBox"
        Me.SiteJuntaUnificadaTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteJuntaUnificadaTextBox.TabIndex = 14
        '
        'SiteJuntaAntigaTextBox
        '
        Me.SiteJuntaAntigaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteJuntaAntiga", True))
        Me.SiteJuntaAntigaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteJuntaAntigaTextBox.Location = New System.Drawing.Point(196, 71)
        Me.SiteJuntaAntigaTextBox.Name = "SiteJuntaAntigaTextBox"
        Me.SiteJuntaAntigaTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteJuntaAntigaTextBox.TabIndex = 16
        '
        'SiteAlvara1TextBox
        '
        Me.SiteAlvara1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteAlvara1", True))
        Me.SiteAlvara1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteAlvara1TextBox.Location = New System.Drawing.Point(125, 89)
        Me.SiteAlvara1TextBox.Name = "SiteAlvara1TextBox"
        Me.SiteAlvara1TextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteAlvara1TextBox.TabIndex = 18
        '
        'SiteAlvara2TextBox
        '
        Me.SiteAlvara2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteAlvara2", True))
        Me.SiteAlvara2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteAlvara2TextBox.Location = New System.Drawing.Point(125, 119)
        Me.SiteAlvara2TextBox.Name = "SiteAlvara2TextBox"
        Me.SiteAlvara2TextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteAlvara2TextBox.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.56097!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43902!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.00506!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.99494!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(820, 593)
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
        Me.GroupBox5.Location = New System.Drawing.Point(721, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(96, 166)
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
        Me.BtnExcluir.Location = New System.Drawing.Point(13, 109)
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
        Me.BtnFechar.Location = New System.Drawing.Point(13, 138)
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
        Me.GroupBox.Size = New System.Drawing.Size(712, 166)
        Me.GroupBox.TabIndex = 59
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Geral"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar:"
        '
        'TextBoxBuscaGeral
        '
        Me.TextBoxBuscaGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscaGeral.Location = New System.Drawing.Point(77, 16)
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
        Me.SitesDataGridView.Location = New System.Drawing.Point(15, 47)
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
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(EstadoSiglaLabel)
        Me.GroupBox2.Controls.Add(Me.EstadoSiglaTextBox)
        Me.GroupBox2.Controls.Add(Me.BtnAddNovamente)
        Me.GroupBox2.Controls.Add(DistritoLabel)
        Me.GroupBox2.Controls.Add(Me.DistritoTextBox)
        Me.GroupBox2.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox2.Controls.Add(CidadeLabel1)
        Me.GroupBox2.Controls.Add(EstadoLabel1)
        Me.GroupBox2.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 415)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(689, 300)
        Me.TabControl1.TabIndex = 56
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(ObservacoesLabel)
        Me.TabPage1.Controls.Add(Me.ObservacoesRichTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(681, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ObservacoesRichTextBox
        '
        Me.ObservacoesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Observacoes", True))
        Me.ObservacoesRichTextBox.Location = New System.Drawing.Point(9, 35)
        Me.ObservacoesRichTextBox.Name = "ObservacoesRichTextBox"
        Me.ObservacoesRichTextBox.Size = New System.Drawing.Size(573, 166)
        Me.ObservacoesRichTextBox.TabIndex = 1
        Me.ObservacoesRichTextBox.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LinkLabel4)
        Me.TabPage4.Controls.Add(Me.LinkLabel3)
        Me.TabPage4.Controls.Add(Me.LinkLabel2)
        Me.TabPage4.Controls.Add(Me.LinkLabel1)
        Me.TabPage4.Controls.Add(Me.BtnSiteREDESIMMeuCNPJ)
        Me.TabPage4.Controls.Add(Me.BtnSiteREDESIMProtocolo)
        Me.TabPage4.Controls.Add(Me.BtnSiteREDESIMAbrirCNPJ)
        Me.TabPage4.Controls.Add(Me.BtnSiteREDESIMConsultaCNPJ)
        Me.TabPage4.Controls.Add(SiteREDESIMMeuCNPJLabel)
        Me.TabPage4.Controls.Add(Me.SiteREDESIMMeuCNPJTextBox)
        Me.TabPage4.Controls.Add(SiteREDESIMAbrirCNPJLabel)
        Me.TabPage4.Controls.Add(Me.SiteREDESIMAbrirCNPJTextBox)
        Me.TabPage4.Controls.Add(SiteREDESIMConsultaCNPJLabel)
        Me.TabPage4.Controls.Add(Me.SiteREDESIMConsultaCNPJTextBox)
        Me.TabPage4.Controls.Add(SiteREDESIMProtocoloLabel)
        Me.TabPage4.Controls.Add(Me.SiteREDESIMProtocoloTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(681, 269)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Federal"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(614, 117)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel4.TabIndex = 78
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Padrão"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(614, 87)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel3.TabIndex = 77
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Padrão"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(614, 57)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel2.TabIndex = 76
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Padrão"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(614, 28)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel1.TabIndex = 72
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Padrão"
        '
        'BtnSiteREDESIMMeuCNPJ
        '
        Me.BtnSiteREDESIMMeuCNPJ.BackgroundImage = CType(resources.GetObject("BtnSiteREDESIMMeuCNPJ.BackgroundImage"), System.Drawing.Image)
        Me.BtnSiteREDESIMMeuCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiteREDESIMMeuCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiteREDESIMMeuCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiteREDESIMMeuCNPJ.ForeColor = System.Drawing.Color.Blue
        Me.BtnSiteREDESIMMeuCNPJ.Location = New System.Drawing.Point(561, 113)
        Me.BtnSiteREDESIMMeuCNPJ.Name = "BtnSiteREDESIMMeuCNPJ"
        Me.BtnSiteREDESIMMeuCNPJ.Size = New System.Drawing.Size(47, 24)
        Me.BtnSiteREDESIMMeuCNPJ.TabIndex = 75
        Me.BtnSiteREDESIMMeuCNPJ.Text = "Abrir"
        Me.BtnSiteREDESIMMeuCNPJ.UseVisualStyleBackColor = True
        '
        'BtnSiteREDESIMProtocolo
        '
        Me.BtnSiteREDESIMProtocolo.BackgroundImage = CType(resources.GetObject("BtnSiteREDESIMProtocolo.BackgroundImage"), System.Drawing.Image)
        Me.BtnSiteREDESIMProtocolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiteREDESIMProtocolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiteREDESIMProtocolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiteREDESIMProtocolo.ForeColor = System.Drawing.Color.Blue
        Me.BtnSiteREDESIMProtocolo.Location = New System.Drawing.Point(561, 23)
        Me.BtnSiteREDESIMProtocolo.Name = "BtnSiteREDESIMProtocolo"
        Me.BtnSiteREDESIMProtocolo.Size = New System.Drawing.Size(47, 24)
        Me.BtnSiteREDESIMProtocolo.TabIndex = 71
        Me.BtnSiteREDESIMProtocolo.Text = "Abrir"
        Me.BtnSiteREDESIMProtocolo.UseVisualStyleBackColor = True
        '
        'BtnSiteREDESIMAbrirCNPJ
        '
        Me.BtnSiteREDESIMAbrirCNPJ.BackgroundImage = CType(resources.GetObject("BtnSiteREDESIMAbrirCNPJ.BackgroundImage"), System.Drawing.Image)
        Me.BtnSiteREDESIMAbrirCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiteREDESIMAbrirCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiteREDESIMAbrirCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiteREDESIMAbrirCNPJ.ForeColor = System.Drawing.Color.Blue
        Me.BtnSiteREDESIMAbrirCNPJ.Location = New System.Drawing.Point(561, 84)
        Me.BtnSiteREDESIMAbrirCNPJ.Name = "BtnSiteREDESIMAbrirCNPJ"
        Me.BtnSiteREDESIMAbrirCNPJ.Size = New System.Drawing.Size(47, 24)
        Me.BtnSiteREDESIMAbrirCNPJ.TabIndex = 74
        Me.BtnSiteREDESIMAbrirCNPJ.Text = "Abrir"
        Me.BtnSiteREDESIMAbrirCNPJ.UseVisualStyleBackColor = True
        '
        'BtnSiteREDESIMConsultaCNPJ
        '
        Me.BtnSiteREDESIMConsultaCNPJ.BackgroundImage = CType(resources.GetObject("BtnSiteREDESIMConsultaCNPJ.BackgroundImage"), System.Drawing.Image)
        Me.BtnSiteREDESIMConsultaCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiteREDESIMConsultaCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiteREDESIMConsultaCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiteREDESIMConsultaCNPJ.ForeColor = System.Drawing.Color.Blue
        Me.BtnSiteREDESIMConsultaCNPJ.Location = New System.Drawing.Point(561, 54)
        Me.BtnSiteREDESIMConsultaCNPJ.Name = "BtnSiteREDESIMConsultaCNPJ"
        Me.BtnSiteREDESIMConsultaCNPJ.Size = New System.Drawing.Size(47, 24)
        Me.BtnSiteREDESIMConsultaCNPJ.TabIndex = 73
        Me.BtnSiteREDESIMConsultaCNPJ.Text = "Abrir"
        Me.BtnSiteREDESIMConsultaCNPJ.UseVisualStyleBackColor = True
        '
        'SiteREDESIMMeuCNPJTextBox
        '
        Me.SiteREDESIMMeuCNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteREDESIMMeuCNPJ", True))
        Me.SiteREDESIMMeuCNPJTextBox.Location = New System.Drawing.Point(193, 112)
        Me.SiteREDESIMMeuCNPJTextBox.Name = "SiteREDESIMMeuCNPJTextBox"
        Me.SiteREDESIMMeuCNPJTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteREDESIMMeuCNPJTextBox.TabIndex = 70
        '
        'SiteREDESIMAbrirCNPJTextBox
        '
        Me.SiteREDESIMAbrirCNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteREDESIMAbrirCNPJ", True))
        Me.SiteREDESIMAbrirCNPJTextBox.Location = New System.Drawing.Point(193, 82)
        Me.SiteREDESIMAbrirCNPJTextBox.Name = "SiteREDESIMAbrirCNPJTextBox"
        Me.SiteREDESIMAbrirCNPJTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteREDESIMAbrirCNPJTextBox.TabIndex = 69
        '
        'SiteREDESIMConsultaCNPJTextBox
        '
        Me.SiteREDESIMConsultaCNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteREDESIMConsultaCNPJ", True))
        Me.SiteREDESIMConsultaCNPJTextBox.Location = New System.Drawing.Point(193, 52)
        Me.SiteREDESIMConsultaCNPJTextBox.Name = "SiteREDESIMConsultaCNPJTextBox"
        Me.SiteREDESIMConsultaCNPJTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteREDESIMConsultaCNPJTextBox.TabIndex = 67
        '
        'SiteREDESIMProtocoloTextBox
        '
        Me.SiteREDESIMProtocoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteREDESIMProtocolo", True))
        Me.SiteREDESIMProtocoloTextBox.Location = New System.Drawing.Point(193, 22)
        Me.SiteREDESIMProtocoloTextBox.Name = "SiteREDESIMProtocoloTextBox"
        Me.SiteREDESIMProtocoloTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteREDESIMProtocoloTextBox.TabIndex = 65
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.LinkLabel8)
        Me.TabPage2.Controls.Add(Me.LinkLabel7)
        Me.TabPage2.Controls.Add(Me.BtnBombeiroREDESIM)
        Me.TabPage2.Controls.Add(Me.BtnBombeiroUnificado)
        Me.TabPage2.Controls.Add(BombeiroREDESIMLabel)
        Me.TabPage2.Controls.Add(Me.BombeiroREDESIMTextBox)
        Me.TabPage2.Controls.Add(BombeiroUnificadoLabel)
        Me.TabPage2.Controls.Add(Me.BombeiroUnificadoTextBox)
        Me.TabPage2.Controls.Add(Me.LinkLabel6)
        Me.TabPage2.Controls.Add(Me.LinkLabel5)
        Me.TabPage2.Controls.Add(Me.BtnBombeiroConsulta)
        Me.TabPage2.Controls.Add(Me.BtnBombeiroSolicita)
        Me.TabPage2.Controls.Add(BombeiroSolicitaLabel)
        Me.TabPage2.Controls.Add(Me.BombeiroSolicitaTextBox)
        Me.TabPage2.Controls.Add(BombeiroConsultaLabel)
        Me.TabPage2.Controls.Add(Me.BombeiroConsultaTextBox)
        Me.TabPage2.Controls.Add(SiteEstadoLabel)
        Me.TabPage2.Controls.Add(Me.BtnAbrir1)
        Me.TabPage2.Controls.Add(Me.SiteEstadoTextBox)
        Me.TabPage2.Controls.Add(SiteJuntaUnificadaLabel)
        Me.TabPage2.Controls.Add(Me.SiteJuntaAntigaTextBox)
        Me.TabPage2.Controls.Add(SiteJuntaAntigaLabel)
        Me.TabPage2.Controls.Add(Me.BtnAbrir4)
        Me.TabPage2.Controls.Add(Me.SiteJuntaUnificadaTextBox)
        Me.TabPage2.Controls.Add(Me.BtnAbrir3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(681, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnBombeiroREDESIM
        '
        Me.BtnBombeiroREDESIM.BackgroundImage = CType(resources.GetObject("BtnBombeiroREDESIM.BackgroundImage"), System.Drawing.Image)
        Me.BtnBombeiroREDESIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBombeiroREDESIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBombeiroREDESIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBombeiroREDESIM.ForeColor = System.Drawing.Color.Blue
        Me.BtnBombeiroREDESIM.Location = New System.Drawing.Point(564, 191)
        Me.BtnBombeiroREDESIM.Name = "BtnBombeiroREDESIM"
        Me.BtnBombeiroREDESIM.Size = New System.Drawing.Size(47, 24)
        Me.BtnBombeiroREDESIM.TabIndex = 82
        Me.BtnBombeiroREDESIM.Text = "Abrir"
        Me.BtnBombeiroREDESIM.UseVisualStyleBackColor = True
        '
        'BtnBombeiroUnificado
        '
        Me.BtnBombeiroUnificado.BackgroundImage = CType(resources.GetObject("BtnBombeiroUnificado.BackgroundImage"), System.Drawing.Image)
        Me.BtnBombeiroUnificado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBombeiroUnificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBombeiroUnificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBombeiroUnificado.ForeColor = System.Drawing.Color.Blue
        Me.BtnBombeiroUnificado.Location = New System.Drawing.Point(564, 161)
        Me.BtnBombeiroUnificado.Name = "BtnBombeiroUnificado"
        Me.BtnBombeiroUnificado.Size = New System.Drawing.Size(47, 24)
        Me.BtnBombeiroUnificado.TabIndex = 81
        Me.BtnBombeiroUnificado.Text = "Abrir"
        Me.BtnBombeiroUnificado.UseVisualStyleBackColor = True
        '
        'BombeiroREDESIMTextBox
        '
        Me.BombeiroREDESIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "BombeiroREDESIM", True))
        Me.BombeiroREDESIMTextBox.Location = New System.Drawing.Point(196, 191)
        Me.BombeiroREDESIMTextBox.Name = "BombeiroREDESIMTextBox"
        Me.BombeiroREDESIMTextBox.Size = New System.Drawing.Size(357, 24)
        Me.BombeiroREDESIMTextBox.TabIndex = 80
        '
        'BombeiroUnificadoTextBox
        '
        Me.BombeiroUnificadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "BombeiroUnificado", True))
        Me.BombeiroUnificadoTextBox.Location = New System.Drawing.Point(196, 161)
        Me.BombeiroUnificadoTextBox.Name = "BombeiroUnificadoTextBox"
        Me.BombeiroUnificadoTextBox.Size = New System.Drawing.Size(357, 24)
        Me.BombeiroUnificadoTextBox.TabIndex = 79
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.Location = New System.Drawing.Point(617, 136)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel6.TabIndex = 78
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Padrão"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(617, 106)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel5.TabIndex = 77
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Padrão"
        '
        'BtnBombeiroConsulta
        '
        Me.BtnBombeiroConsulta.BackgroundImage = CType(resources.GetObject("BtnBombeiroConsulta.BackgroundImage"), System.Drawing.Image)
        Me.BtnBombeiroConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBombeiroConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBombeiroConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBombeiroConsulta.ForeColor = System.Drawing.Color.Blue
        Me.BtnBombeiroConsulta.Location = New System.Drawing.Point(564, 132)
        Me.BtnBombeiroConsulta.Name = "BtnBombeiroConsulta"
        Me.BtnBombeiroConsulta.Size = New System.Drawing.Size(47, 24)
        Me.BtnBombeiroConsulta.TabIndex = 55
        Me.BtnBombeiroConsulta.Text = "Abrir"
        Me.BtnBombeiroConsulta.UseVisualStyleBackColor = True
        '
        'BtnBombeiroSolicita
        '
        Me.BtnBombeiroSolicita.BackgroundImage = CType(resources.GetObject("BtnBombeiroSolicita.BackgroundImage"), System.Drawing.Image)
        Me.BtnBombeiroSolicita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBombeiroSolicita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBombeiroSolicita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBombeiroSolicita.ForeColor = System.Drawing.Color.Blue
        Me.BtnBombeiroSolicita.Location = New System.Drawing.Point(564, 102)
        Me.BtnBombeiroSolicita.Name = "BtnBombeiroSolicita"
        Me.BtnBombeiroSolicita.Size = New System.Drawing.Size(47, 24)
        Me.BtnBombeiroSolicita.TabIndex = 54
        Me.BtnBombeiroSolicita.Text = "Abrir"
        Me.BtnBombeiroSolicita.UseVisualStyleBackColor = True
        '
        'BombeiroSolicitaTextBox
        '
        Me.BombeiroSolicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "BombeiroSolicita", True))
        Me.BombeiroSolicitaTextBox.Location = New System.Drawing.Point(196, 101)
        Me.BombeiroSolicitaTextBox.Name = "BombeiroSolicitaTextBox"
        Me.BombeiroSolicitaTextBox.Size = New System.Drawing.Size(357, 24)
        Me.BombeiroSolicitaTextBox.TabIndex = 53
        '
        'BombeiroConsultaTextBox
        '
        Me.BombeiroConsultaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "BombeiroConsulta", True))
        Me.BombeiroConsultaTextBox.Location = New System.Drawing.Point(196, 131)
        Me.BombeiroConsultaTextBox.Name = "BombeiroConsultaTextBox"
        Me.BombeiroConsultaTextBox.Size = New System.Drawing.Size(357, 24)
        Me.BombeiroConsultaTextBox.TabIndex = 52
        '
        'BtnAbrir1
        '
        Me.BtnAbrir1.BackgroundImage = CType(resources.GetObject("BtnAbrir1.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir1.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir1.Location = New System.Drawing.Point(564, 11)
        Me.BtnAbrir1.Name = "BtnAbrir1"
        Me.BtnAbrir1.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir1.TabIndex = 48
        Me.BtnAbrir1.Text = "Abrir"
        Me.BtnAbrir1.UseVisualStyleBackColor = True
        '
        'BtnAbrir4
        '
        Me.BtnAbrir4.BackgroundImage = CType(resources.GetObject("BtnAbrir4.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir4.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir4.Location = New System.Drawing.Point(564, 72)
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
        Me.BtnAbrir3.Location = New System.Drawing.Point(564, 42)
        Me.BtnAbrir3.Name = "BtnAbrir3"
        Me.BtnAbrir3.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir3.TabIndex = 50
        Me.BtnAbrir3.Text = "Abrir"
        Me.BtnAbrir3.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.BtnPrefProtocolo)
        Me.TabPage3.Controls.Add(SitePrefProtocoloLabel)
        Me.TabPage3.Controls.Add(Me.SitePrefProtocoloTextBox)
        Me.TabPage3.Controls.Add(Me.BtnAlvaraPedido2)
        Me.TabPage3.Controls.Add(Me.BtnAlvaraPedido1)
        Me.TabPage3.Controls.Add(SiteAlvaraPedido2Label)
        Me.TabPage3.Controls.Add(Me.SiteAlvaraPedido2TextBox)
        Me.TabPage3.Controls.Add(SiteAlvaraPedido1Label)
        Me.TabPage3.Controls.Add(Me.SiteAlvaraPedido1TextBox)
        Me.TabPage3.Controls.Add(SiteCidadeLabel)
        Me.TabPage3.Controls.Add(Me.BtnAbrir2)
        Me.TabPage3.Controls.Add(Me.SiteCidadeTextBox)
        Me.TabPage3.Controls.Add(SiteAlvara1Label)
        Me.TabPage3.Controls.Add(Me.BtnAbrir6)
        Me.TabPage3.Controls.Add(Me.SiteAlvara1TextBox)
        Me.TabPage3.Controls.Add(Me.BtnAbrir5)
        Me.TabPage3.Controls.Add(Me.SiteAlvara2TextBox)
        Me.TabPage3.Controls.Add(SiteAlvara2Label)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(681, 269)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cidade"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnPrefProtocolo
        '
        Me.BtnPrefProtocolo.BackgroundImage = CType(resources.GetObject("BtnPrefProtocolo.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrefProtocolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrefProtocolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrefProtocolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrefProtocolo.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrefProtocolo.Location = New System.Drawing.Point(488, 49)
        Me.BtnPrefProtocolo.Name = "BtnPrefProtocolo"
        Me.BtnPrefProtocolo.Size = New System.Drawing.Size(47, 24)
        Me.BtnPrefProtocolo.TabIndex = 59
        Me.BtnPrefProtocolo.Text = "Abrir"
        Me.BtnPrefProtocolo.UseVisualStyleBackColor = True
        '
        'SitePrefProtocoloTextBox
        '
        Me.SitePrefProtocoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SitePrefProtocolo", True))
        Me.SitePrefProtocoloTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SitePrefProtocoloTextBox.Location = New System.Drawing.Point(125, 49)
        Me.SitePrefProtocoloTextBox.Name = "SitePrefProtocoloTextBox"
        Me.SitePrefProtocoloTextBox.Size = New System.Drawing.Size(357, 24)
        Me.SitePrefProtocoloTextBox.TabIndex = 58
        '
        'BtnAlvaraPedido2
        '
        Me.BtnAlvaraPedido2.BackgroundImage = CType(resources.GetObject("BtnAlvaraPedido2.BackgroundImage"), System.Drawing.Image)
        Me.BtnAlvaraPedido2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAlvaraPedido2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlvaraPedido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlvaraPedido2.ForeColor = System.Drawing.Color.Blue
        Me.BtnAlvaraPedido2.Location = New System.Drawing.Point(488, 179)
        Me.BtnAlvaraPedido2.Name = "BtnAlvaraPedido2"
        Me.BtnAlvaraPedido2.Size = New System.Drawing.Size(47, 24)
        Me.BtnAlvaraPedido2.TabIndex = 57
        Me.BtnAlvaraPedido2.Text = "Abrir"
        Me.BtnAlvaraPedido2.UseVisualStyleBackColor = True
        '
        'BtnAlvaraPedido1
        '
        Me.BtnAlvaraPedido1.BackgroundImage = CType(resources.GetObject("BtnAlvaraPedido1.BackgroundImage"), System.Drawing.Image)
        Me.BtnAlvaraPedido1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAlvaraPedido1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlvaraPedido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlvaraPedido1.ForeColor = System.Drawing.Color.Blue
        Me.BtnAlvaraPedido1.Location = New System.Drawing.Point(488, 149)
        Me.BtnAlvaraPedido1.Name = "BtnAlvaraPedido1"
        Me.BtnAlvaraPedido1.Size = New System.Drawing.Size(47, 24)
        Me.BtnAlvaraPedido1.TabIndex = 56
        Me.BtnAlvaraPedido1.Text = "Abrir"
        Me.BtnAlvaraPedido1.UseVisualStyleBackColor = True
        '
        'SiteAlvaraPedido2TextBox
        '
        Me.SiteAlvaraPedido2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteAlvaraPedido2", True))
        Me.SiteAlvaraPedido2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteAlvaraPedido2TextBox.Location = New System.Drawing.Point(125, 179)
        Me.SiteAlvaraPedido2TextBox.Name = "SiteAlvaraPedido2TextBox"
        Me.SiteAlvaraPedido2TextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteAlvaraPedido2TextBox.TabIndex = 55
        '
        'SiteAlvaraPedido1TextBox
        '
        Me.SiteAlvaraPedido1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SiteAlvaraPedido1", True))
        Me.SiteAlvaraPedido1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteAlvaraPedido1TextBox.Location = New System.Drawing.Point(125, 149)
        Me.SiteAlvaraPedido1TextBox.Name = "SiteAlvaraPedido1TextBox"
        Me.SiteAlvaraPedido1TextBox.Size = New System.Drawing.Size(357, 24)
        Me.SiteAlvaraPedido1TextBox.TabIndex = 54
        '
        'BtnAbrir2
        '
        Me.BtnAbrir2.BackgroundImage = CType(resources.GetObject("BtnAbrir2.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir2.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir2.Location = New System.Drawing.Point(488, 20)
        Me.BtnAbrir2.Name = "BtnAbrir2"
        Me.BtnAbrir2.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir2.TabIndex = 49
        Me.BtnAbrir2.Text = "Abrir"
        Me.BtnAbrir2.UseVisualStyleBackColor = True
        '
        'BtnAbrir6
        '
        Me.BtnAbrir6.BackgroundImage = CType(resources.GetObject("BtnAbrir6.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbrir6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir6.ForeColor = System.Drawing.Color.Blue
        Me.BtnAbrir6.Location = New System.Drawing.Point(488, 120)
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
        Me.BtnAbrir5.Location = New System.Drawing.Point(488, 90)
        Me.BtnAbrir5.Name = "BtnAbrir5"
        Me.BtnAbrir5.Size = New System.Drawing.Size(47, 24)
        Me.BtnAbrir5.TabIndex = 52
        Me.BtnAbrir5.Text = "Abrir"
        Me.BtnAbrir5.UseVisualStyleBackColor = True
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
        Me.BtnAddNovamente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNovamente.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnAddNovamente.Location = New System.Drawing.Point(395, 27)
        Me.BtnAddNovamente.Name = "BtnAddNovamente"
        Me.BtnAddNovamente.Size = New System.Drawing.Size(82, 52)
        Me.BtnAddNovamente.TabIndex = 54
        Me.BtnAddNovamente.Text = "Adicionar Cidade"
        Me.BtnAddNovamente.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(721, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 415)
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
        Me.GroupBox1.Size = New System.Drawing.Size(90, 396)
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
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.Location = New System.Drawing.Point(617, 167)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel7.TabIndex = 83
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Padrão"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.Location = New System.Drawing.Point(617, 197)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(47, 15)
        Me.LinkLabel8.TabIndex = 84
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Padrão"
        '
        'FrmSites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(820, 593)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BtnAlvaraPedido2 As Button
    Friend WithEvents BtnAlvaraPedido1 As Button
    Friend WithEvents SiteAlvaraPedido2TextBox As TextBox
    Friend WithEvents SiteAlvaraPedido1TextBox As TextBox
    Friend WithEvents SitePrefProtocoloTextBox As TextBox
    Friend WithEvents BtnPrefProtocolo As Button
    Friend WithEvents ObservacoesRichTextBox As RichTextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnSiteREDESIMMeuCNPJ As Button
    Friend WithEvents BtnSiteREDESIMProtocolo As Button
    Friend WithEvents BtnSiteREDESIMAbrirCNPJ As Button
    Friend WithEvents BtnSiteREDESIMConsultaCNPJ As Button
    Friend WithEvents SiteREDESIMMeuCNPJTextBox As TextBox
    Friend WithEvents SiteREDESIMAbrirCNPJTextBox As TextBox
    Friend WithEvents SiteREDESIMConsultaCNPJTextBox As TextBox
    Friend WithEvents SiteREDESIMProtocoloTextBox As TextBox
    Friend WithEvents BtnBombeiroConsulta As Button
    Friend WithEvents BtnBombeiroSolicita As Button
    Friend WithEvents BombeiroSolicitaTextBox As TextBox
    Friend WithEvents BombeiroConsultaTextBox As TextBox
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents BtnBombeiroREDESIM As Button
    Friend WithEvents BtnBombeiroUnificado As Button
    Friend WithEvents BombeiroREDESIMTextBox As TextBox
    Friend WithEvents BombeiroUnificadoTextBox As TextBox
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
End Class
