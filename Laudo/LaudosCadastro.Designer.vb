<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaudosCadastro
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
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim EndNumLabel As System.Windows.Forms.Label
        Dim EndCompLabel As System.Windows.Forms.Label
        Dim EndBairroLabel As System.Windows.Forms.Label
        Dim EndCEPLabel As System.Windows.Forms.Label
        Dim EndCidadeLabel As System.Windows.Forms.Label
        Dim EndEstadoLabel As System.Windows.Forms.Label
        Dim ResptecnicoLabel As System.Windows.Forms.Label
        Dim ResptecnicoNumeroLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim NaturezaDoPedidoLabel As System.Windows.Forms.Label
        Dim NaturezaDoPedidoOBSLabel As System.Windows.Forms.Label
        Dim CNAELabel As System.Windows.Forms.Label
        Dim RequerenteLabel As System.Windows.Forms.Label
        Dim EndRequerenteLabel As System.Windows.Forms.Label
        Dim FoneRequerenteLabel As System.Windows.Forms.Label
        Dim EmailRequerenteLabel As System.Windows.Forms.Label
        Dim CPFRequerenteLabel As System.Windows.Forms.Label
        Dim RGRequerenteLabel As System.Windows.Forms.Label
        Dim CNPJRequerenteLabel As System.Windows.Forms.Label
        Dim RamodeatividadeLabel As System.Windows.Forms.Label
        Dim NlaudoLabel As System.Windows.Forms.Label
        Dim SituacaoLabel As System.Windows.Forms.Label
        Dim DataCriadoLabel As System.Windows.Forms.Label
        Dim ModeloSistemaLabel As System.Windows.Forms.Label
        Dim EndZonaLabel As System.Windows.Forms.Label
        Dim EndQuadraLabel As System.Windows.Forms.Label
        Dim EndDataLabel As System.Windows.Forms.Label
        Dim CadImobLabel As System.Windows.Forms.Label
        Dim CMCLabel As System.Windows.Forms.Label
        Dim AvisarDiaLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim Area2Label As System.Windows.Forms.Label
        Dim PontoRefLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaudosCadastro))
        Me.LaudosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.EndNumTextBox = New System.Windows.Forms.TextBox()
        Me.EndCompTextBox = New System.Windows.Forms.TextBox()
        Me.EndBairroTextBox = New System.Windows.Forms.TextBox()
        Me.EndCEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EndCidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EndEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.ResptecnicoTextBox = New System.Windows.Forms.TextBox()
        Me.ResptecnicoNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.LembreteCheckBox = New System.Windows.Forms.CheckBox()
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NaturezaDoPedidoOBSRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PontoRefTextBox = New System.Windows.Forms.TextBox()
        Me.Area2TextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.CadImobTextBox = New System.Windows.Forms.TextBox()
        Me.CMCTextBox = New System.Windows.Forms.TextBox()
        Me.EndDataTextBox = New System.Windows.Forms.TextBox()
        Me.EndQuadraTextBox = New System.Windows.Forms.TextBox()
        Me.EndZonaTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CNPJRequerenteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RGRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.CPFRequerenteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.FoneRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.EndRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.RequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RamodeatividadeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CNAERichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.NaturezaDoPedidoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NlaudoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ModeloSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataEntradaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.DataCriadoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AvisarDiaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataEntradaLabel = New System.Windows.Forms.Label()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        EndNumLabel = New System.Windows.Forms.Label()
        EndCompLabel = New System.Windows.Forms.Label()
        EndBairroLabel = New System.Windows.Forms.Label()
        EndCEPLabel = New System.Windows.Forms.Label()
        EndCidadeLabel = New System.Windows.Forms.Label()
        EndEstadoLabel = New System.Windows.Forms.Label()
        ResptecnicoLabel = New System.Windows.Forms.Label()
        ResptecnicoNumeroLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        NaturezaDoPedidoLabel = New System.Windows.Forms.Label()
        NaturezaDoPedidoOBSLabel = New System.Windows.Forms.Label()
        CNAELabel = New System.Windows.Forms.Label()
        RequerenteLabel = New System.Windows.Forms.Label()
        EndRequerenteLabel = New System.Windows.Forms.Label()
        FoneRequerenteLabel = New System.Windows.Forms.Label()
        EmailRequerenteLabel = New System.Windows.Forms.Label()
        CPFRequerenteLabel = New System.Windows.Forms.Label()
        RGRequerenteLabel = New System.Windows.Forms.Label()
        CNPJRequerenteLabel = New System.Windows.Forms.Label()
        RamodeatividadeLabel = New System.Windows.Forms.Label()
        NlaudoLabel = New System.Windows.Forms.Label()
        SituacaoLabel = New System.Windows.Forms.Label()
        DataCriadoLabel = New System.Windows.Forms.Label()
        ModeloSistemaLabel = New System.Windows.Forms.Label()
        EndZonaLabel = New System.Windows.Forms.Label()
        EndQuadraLabel = New System.Windows.Forms.Label()
        EndDataLabel = New System.Windows.Forms.Label()
        CadImobLabel = New System.Windows.Forms.Label()
        CMCLabel = New System.Windows.Forms.Label()
        AvisarDiaLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        Area2Label = New System.Windows.Forms.Label()
        PontoRefLabel = New System.Windows.Forms.Label()
        CType(Me.LaudosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LaudosBindingNavigator.SuspendLayout()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(10, 78)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazaoSocialLabel.TabIndex = 1
        RazaoSocialLabel.Text = "Razão Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(46, 104)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(37, 13)
        CNPJLabel.TabIndex = 3
        CNPJLabel.Text = "CNPJ:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(21, 49)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 5
        EnderecoLabel.Text = "Endereço:"
        '
        'EndNumLabel
        '
        EndNumLabel.AutoSize = True
        EndNumLabel.Location = New System.Drawing.Point(55, 75)
        EndNumLabel.Name = "EndNumLabel"
        EndNumLabel.Size = New System.Drawing.Size(22, 13)
        EndNumLabel.TabIndex = 7
        EndNumLabel.Text = "Nº:"
        '
        'EndCompLabel
        '
        EndCompLabel.AutoSize = True
        EndCompLabel.Location = New System.Drawing.Point(150, 75)
        EndCompLabel.Name = "EndCompLabel"
        EndCompLabel.Size = New System.Drawing.Size(74, 13)
        EndCompLabel.TabIndex = 9
        EndCompLabel.Text = "Complemento:"
        '
        'EndBairroLabel
        '
        EndBairroLabel.AutoSize = True
        EndBairroLabel.Location = New System.Drawing.Point(40, 127)
        EndBairroLabel.Name = "EndBairroLabel"
        EndBairroLabel.Size = New System.Drawing.Size(37, 13)
        EndBairroLabel.TabIndex = 11
        EndBairroLabel.Text = "Bairro:"
        '
        'EndCEPLabel
        '
        EndCEPLabel.AutoSize = True
        EndCEPLabel.Location = New System.Drawing.Point(46, 23)
        EndCEPLabel.Name = "EndCEPLabel"
        EndCEPLabel.Size = New System.Drawing.Size(31, 13)
        EndCEPLabel.TabIndex = 13
        EndCEPLabel.Text = "CEP:"
        '
        'EndCidadeLabel
        '
        EndCidadeLabel.AutoSize = True
        EndCidadeLabel.Location = New System.Drawing.Point(34, 153)
        EndCidadeLabel.Name = "EndCidadeLabel"
        EndCidadeLabel.Size = New System.Drawing.Size(43, 13)
        EndCidadeLabel.TabIndex = 17
        EndCidadeLabel.Text = "Cidade:"
        '
        'EndEstadoLabel
        '
        EndEstadoLabel.AutoSize = True
        EndEstadoLabel.Location = New System.Drawing.Point(206, 153)
        EndEstadoLabel.Name = "EndEstadoLabel"
        EndEstadoLabel.Size = New System.Drawing.Size(43, 13)
        EndEstadoLabel.TabIndex = 18
        EndEstadoLabel.Text = "Estado:"
        '
        'ResptecnicoLabel
        '
        ResptecnicoLabel.AutoSize = True
        ResptecnicoLabel.Location = New System.Drawing.Point(15, 25)
        ResptecnicoLabel.Name = "ResptecnicoLabel"
        ResptecnicoLabel.Size = New System.Drawing.Size(80, 13)
        ResptecnicoLabel.TabIndex = 20
        ResptecnicoLabel.Text = "Resp. Técnico:"
        '
        'ResptecnicoNumeroLabel
        '
        ResptecnicoNumeroLabel.AutoSize = True
        ResptecnicoNumeroLabel.Location = New System.Drawing.Point(34, 55)
        ResptecnicoNumeroLabel.Name = "ResptecnicoNumeroLabel"
        ResptecnicoNumeroLabel.Size = New System.Drawing.Size(61, 13)
        ResptecnicoNumeroLabel.TabIndex = 22
        ResptecnicoNumeroLabel.Text = "Nº Carteira:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(369, 156)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 25
        TelefoneLabel.Text = "Telefone:"
        '
        'NaturezaDoPedidoLabel
        '
        NaturezaDoPedidoLabel.AutoSize = True
        NaturezaDoPedidoLabel.Location = New System.Drawing.Point(14, 14)
        NaturezaDoPedidoLabel.Name = "NaturezaDoPedidoLabel"
        NaturezaDoPedidoLabel.Size = New System.Drawing.Size(106, 13)
        NaturezaDoPedidoLabel.TabIndex = 27
        NaturezaDoPedidoLabel.Text = "Natureza Do Pedido:"
        '
        'NaturezaDoPedidoOBSLabel
        '
        NaturezaDoPedidoOBSLabel.AutoSize = True
        NaturezaDoPedidoOBSLabel.Location = New System.Drawing.Point(14, 19)
        NaturezaDoPedidoOBSLabel.Name = "NaturezaDoPedidoOBSLabel"
        NaturezaDoPedidoOBSLabel.Size = New System.Drawing.Size(32, 13)
        NaturezaDoPedidoOBSLabel.TabIndex = 29
        NaturezaDoPedidoOBSLabel.Text = "OBS:"
        '
        'CNAELabel
        '
        CNAELabel.AutoSize = True
        CNAELabel.Location = New System.Drawing.Point(12, 16)
        CNAELabel.Name = "CNAELabel"
        CNAELabel.Size = New System.Drawing.Size(36, 13)
        CNAELabel.TabIndex = 23
        CNAELabel.Text = "CNAE"
        '
        'RequerenteLabel
        '
        RequerenteLabel.AutoSize = True
        RequerenteLabel.Location = New System.Drawing.Point(39, 33)
        RequerenteLabel.Name = "RequerenteLabel"
        RequerenteLabel.Size = New System.Drawing.Size(38, 13)
        RequerenteLabel.TabIndex = 24
        RequerenteLabel.Text = "Nome:"
        '
        'EndRequerenteLabel
        '
        EndRequerenteLabel.AutoSize = True
        EndRequerenteLabel.Location = New System.Drawing.Point(21, 107)
        EndRequerenteLabel.Name = "EndRequerenteLabel"
        EndRequerenteLabel.Size = New System.Drawing.Size(56, 13)
        EndRequerenteLabel.TabIndex = 26
        EndRequerenteLabel.Text = "Endereço:"
        '
        'FoneRequerenteLabel
        '
        FoneRequerenteLabel.AutoSize = True
        FoneRequerenteLabel.Location = New System.Drawing.Point(25, 133)
        FoneRequerenteLabel.Name = "FoneRequerenteLabel"
        FoneRequerenteLabel.Size = New System.Drawing.Size(52, 13)
        FoneRequerenteLabel.TabIndex = 27
        FoneRequerenteLabel.Text = "Telefone:"
        '
        'EmailRequerenteLabel
        '
        EmailRequerenteLabel.AutoSize = True
        EmailRequerenteLabel.Location = New System.Drawing.Point(214, 133)
        EmailRequerenteLabel.Name = "EmailRequerenteLabel"
        EmailRequerenteLabel.Size = New System.Drawing.Size(38, 13)
        EmailRequerenteLabel.TabIndex = 28
        EmailRequerenteLabel.Text = "e-Mail:"
        '
        'CPFRequerenteLabel
        '
        CPFRequerenteLabel.AutoSize = True
        CPFRequerenteLabel.Location = New System.Drawing.Point(47, 59)
        CPFRequerenteLabel.Name = "CPFRequerenteLabel"
        CPFRequerenteLabel.Size = New System.Drawing.Size(30, 13)
        CPFRequerenteLabel.TabIndex = 31
        CPFRequerenteLabel.Text = "CPF:"
        '
        'RGRequerenteLabel
        '
        RGRequerenteLabel.AutoSize = True
        RGRequerenteLabel.Location = New System.Drawing.Point(185, 59)
        RGRequerenteLabel.Name = "RGRequerenteLabel"
        RGRequerenteLabel.Size = New System.Drawing.Size(26, 13)
        RGRequerenteLabel.TabIndex = 32
        RGRequerenteLabel.Text = "RG:"
        '
        'CNPJRequerenteLabel
        '
        CNPJRequerenteLabel.AutoSize = True
        CNPJRequerenteLabel.Location = New System.Drawing.Point(340, 59)
        CNPJRequerenteLabel.Name = "CNPJRequerenteLabel"
        CNPJRequerenteLabel.Size = New System.Drawing.Size(37, 13)
        CNPJRequerenteLabel.TabIndex = 33
        CNPJRequerenteLabel.Text = "CNPJ:"
        '
        'RamodeatividadeLabel
        '
        RamodeatividadeLabel.AutoSize = True
        RamodeatividadeLabel.Location = New System.Drawing.Point(12, 106)
        RamodeatividadeLabel.Name = "RamodeatividadeLabel"
        RamodeatividadeLabel.Size = New System.Drawing.Size(97, 13)
        RamodeatividadeLabel.TabIndex = 24
        RamodeatividadeLabel.Text = "Ramo de Atividade"
        '
        'NlaudoLabel
        '
        NlaudoLabel.AutoSize = True
        NlaudoLabel.Location = New System.Drawing.Point(292, 19)
        NlaudoLabel.Name = "NlaudoLabel"
        NlaudoLabel.Size = New System.Drawing.Size(70, 13)
        NlaudoLabel.TabIndex = 36
        NlaudoLabel.Text = "Nº do Laudo:"
        '
        'SituacaoLabel
        '
        SituacaoLabel.AutoSize = True
        SituacaoLabel.Location = New System.Drawing.Point(318, 104)
        SituacaoLabel.Name = "SituacaoLabel"
        SituacaoLabel.Size = New System.Drawing.Size(52, 13)
        SituacaoLabel.TabIndex = 0
        SituacaoLabel.Text = "Situação:"
        '
        'DataCriadoLabel
        '
        DataCriadoLabel.AutoSize = True
        DataCriadoLabel.Location = New System.Drawing.Point(37, 131)
        DataCriadoLabel.Name = "DataCriadoLabel"
        DataCriadoLabel.Size = New System.Drawing.Size(46, 13)
        DataCriadoLabel.TabIndex = 6
        DataCriadoLabel.Text = "Criação:"
        '
        'ModeloSistemaLabel
        '
        ModeloSistemaLabel.AutoSize = True
        ModeloSistemaLabel.Location = New System.Drawing.Point(315, 46)
        ModeloSistemaLabel.Name = "ModeloSistemaLabel"
        ModeloSistemaLabel.Size = New System.Drawing.Size(47, 13)
        ModeloSistemaLabel.TabIndex = 37
        ModeloSistemaLabel.Text = "Sistema:"
        '
        'EndZonaLabel
        '
        EndZonaLabel.AutoSize = True
        EndZonaLabel.Location = New System.Drawing.Point(42, 101)
        EndZonaLabel.Name = "EndZonaLabel"
        EndZonaLabel.Size = New System.Drawing.Size(35, 13)
        EndZonaLabel.TabIndex = 26
        EndZonaLabel.Text = "Zona:"
        '
        'EndQuadraLabel
        '
        EndQuadraLabel.AutoSize = True
        EndQuadraLabel.Location = New System.Drawing.Point(120, 101)
        EndQuadraLabel.Name = "EndQuadraLabel"
        EndQuadraLabel.Size = New System.Drawing.Size(45, 13)
        EndQuadraLabel.TabIndex = 27
        EndQuadraLabel.Text = "Quadra:"
        '
        'EndDataLabel
        '
        EndDataLabel.AutoSize = True
        EndDataLabel.Location = New System.Drawing.Point(201, 101)
        EndDataLabel.Name = "EndDataLabel"
        EndDataLabel.Size = New System.Drawing.Size(33, 13)
        EndDataLabel.TabIndex = 28
        EndDataLabel.Text = "Data:"
        '
        'CadImobLabel
        '
        CadImobLabel.AutoSize = True
        CadImobLabel.Location = New System.Drawing.Point(277, 101)
        CadImobLabel.Name = "CadImobLabel"
        CadImobLabel.Size = New System.Drawing.Size(101, 13)
        CadImobLabel.TabIndex = 39
        CadImobLabel.Text = "Cadastro Imobiliário:"
        '
        'CMCLabel
        '
        CMCLabel.AutoSize = True
        CMCLabel.Location = New System.Drawing.Point(406, 23)
        CMCLabel.Name = "CMCLabel"
        CMCLabel.Size = New System.Drawing.Size(33, 13)
        CMCLabel.TabIndex = 39
        CMCLabel.Text = "CMC:"
        '
        'AvisarDiaLabel
        '
        AvisarDiaLabel.AutoSize = True
        AvisarDiaLabel.Location = New System.Drawing.Point(432, 127)
        AvisarDiaLabel.Name = "AvisarDiaLabel"
        AvisarDiaLabel.Size = New System.Drawing.Size(58, 13)
        AvisarDiaLabel.TabIndex = 39
        AvisarDiaLabel.Text = "Avisar Dia:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(21, 183)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(101, 13)
        AreaLabel.TabIndex = 40
        AreaLabel.Text = "Área do Imóvel (m²):"
        '
        'Area2Label
        '
        Area2Label.AutoSize = True
        Area2Label.Location = New System.Drawing.Point(177, 183)
        Area2Label.Name = "Area2Label"
        Area2Label.Size = New System.Drawing.Size(148, 13)
        Area2Label.TabIndex = 41
        Area2Label.Text = "Área do Estabelecimento (m²):"
        '
        'PontoRefLabel
        '
        PontoRefLabel.AutoSize = True
        PontoRefLabel.Location = New System.Drawing.Point(235, 127)
        PontoRefLabel.Name = "PontoRefLabel"
        PontoRefLabel.Size = New System.Drawing.Size(108, 13)
        PontoRefLabel.TabIndex = 51
        PontoRefLabel.Text = "Ponto de Referência:"
        '
        'LaudosBindingNavigator
        '
        Me.LaudosBindingNavigator.AddNewItem = Nothing
        Me.LaudosBindingNavigator.BindingSource = Me.LaudosBindingSource
        Me.LaudosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LaudosBindingNavigator.DeleteItem = Nothing
        Me.LaudosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.LaudosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LaudosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LaudosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LaudosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LaudosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LaudosBindingNavigator.Name = "LaudosBindingNavigator"
        Me.LaudosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LaudosBindingNavigator.Size = New System.Drawing.Size(691, 25)
        Me.LaudosBindingNavigator.TabIndex = 0
        Me.LaudosBindingNavigator.Text = "BindingNavigator1"
        '
        'LaudosBindingSource
        '
        Me.LaudosBindingSource.DataMember = "Laudos"
        Me.LaudosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(25, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(89, 75)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(472, 20)
        Me.RazaoSocialTextBox.TabIndex = 2
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(89, 101)
        Me.CNPJMaskedTextBox.Mask = "99.999.999/9999-99"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(108, 20)
        Me.CNPJMaskedTextBox.TabIndex = 4
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(83, 46)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(444, 20)
        Me.EnderecoTextBox.TabIndex = 6
        '
        'EndNumTextBox
        '
        Me.EndNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndNum", True))
        Me.EndNumTextBox.Location = New System.Drawing.Point(83, 72)
        Me.EndNumTextBox.Name = "EndNumTextBox"
        Me.EndNumTextBox.Size = New System.Drawing.Size(64, 20)
        Me.EndNumTextBox.TabIndex = 8
        '
        'EndCompTextBox
        '
        Me.EndCompTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndComp", True))
        Me.EndCompTextBox.Location = New System.Drawing.Point(223, 72)
        Me.EndCompTextBox.Name = "EndCompTextBox"
        Me.EndCompTextBox.Size = New System.Drawing.Size(304, 20)
        Me.EndCompTextBox.TabIndex = 10
        '
        'EndBairroTextBox
        '
        Me.EndBairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndBairro", True))
        Me.EndBairroTextBox.Location = New System.Drawing.Point(83, 124)
        Me.EndBairroTextBox.Name = "EndBairroTextBox"
        Me.EndBairroTextBox.Size = New System.Drawing.Size(151, 20)
        Me.EndBairroTextBox.TabIndex = 12
        '
        'EndCEPMaskedTextBox
        '
        Me.EndCEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndCEP", True))
        Me.EndCEPMaskedTextBox.Location = New System.Drawing.Point(83, 20)
        Me.EndCEPMaskedTextBox.Mask = "00000-000"
        Me.EndCEPMaskedTextBox.Name = "EndCEPMaskedTextBox"
        Me.EndCEPMaskedTextBox.Size = New System.Drawing.Size(64, 20)
        Me.EndCEPMaskedTextBox.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(153, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 19)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Buscar CEP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LaudosTableAdapter
        '
        Me.LaudosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Me.LaudosTableAdapter
        ' Me.TableAdapterManiger.LoginTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EndCidadeTextBox
        '
        Me.EndCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndCidade", True))
        Me.EndCidadeTextBox.Location = New System.Drawing.Point(83, 150)
        Me.EndCidadeTextBox.Name = "EndCidadeTextBox"
        Me.EndCidadeTextBox.Size = New System.Drawing.Size(117, 20)
        Me.EndCidadeTextBox.TabIndex = 18
        '
        'EndEstadoTextBox
        '
        Me.EndEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndEstado", True))
        Me.EndEstadoTextBox.Location = New System.Drawing.Point(255, 150)
        Me.EndEstadoTextBox.Name = "EndEstadoTextBox"
        Me.EndEstadoTextBox.Size = New System.Drawing.Size(38, 20)
        Me.EndEstadoTextBox.TabIndex = 19
        '
        'ResptecnicoTextBox
        '
        Me.ResptecnicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Resptecnico", True))
        Me.ResptecnicoTextBox.Location = New System.Drawing.Point(101, 22)
        Me.ResptecnicoTextBox.Name = "ResptecnicoTextBox"
        Me.ResptecnicoTextBox.Size = New System.Drawing.Size(420, 20)
        Me.ResptecnicoTextBox.TabIndex = 21
        '
        'ResptecnicoNumeroTextBox
        '
        Me.ResptecnicoNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ResptecnicoNumero", True))
        Me.ResptecnicoNumeroTextBox.Location = New System.Drawing.Point(101, 48)
        Me.ResptecnicoNumeroTextBox.Name = "ResptecnicoNumeroTextBox"
        Me.ResptecnicoNumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResptecnicoNumeroTextBox.TabIndex = 23
        '
        'LembreteCheckBox
        '
        Me.LembreteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Lembrete", True))
        Me.LembreteCheckBox.Location = New System.Drawing.Point(497, 55)
        Me.LembreteCheckBox.Name = "LembreteCheckBox"
        Me.LembreteCheckBox.Size = New System.Drawing.Size(70, 20)
        Me.LembreteCheckBox.TabIndex = 25
        Me.LembreteCheckBox.Text = "Lembrete"
        Me.LembreteCheckBox.UseVisualStyleBackColor = True
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(427, 153)
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 26
        '
        'NaturezaDoPedidoOBSRichTextBox
        '
        Me.NaturezaDoPedidoOBSRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "NaturezaDoPedidoOBS", True))
        Me.NaturezaDoPedidoOBSRichTextBox.Location = New System.Drawing.Point(17, 35)
        Me.NaturezaDoPedidoOBSRichTextBox.Name = "NaturezaDoPedidoOBSRichTextBox"
        Me.NaturezaDoPedidoOBSRichTextBox.Size = New System.Drawing.Size(514, 129)
        Me.NaturezaDoPedidoOBSRichTextBox.TabIndex = 30
        Me.NaturezaDoPedidoOBSRichTextBox.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(15, 290)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(557, 233)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(NaturezaDoPedidoOBSLabel)
        Me.TabPage5.Controls.Add(Me.NaturezaDoPedidoOBSRichTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(549, 207)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Geral"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(PontoRefLabel)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.PontoRefTextBox)
        Me.TabPage1.Controls.Add(Area2Label)
        Me.TabPage1.Controls.Add(Me.Area2TextBox)
        Me.TabPage1.Controls.Add(AreaLabel)
        Me.TabPage1.Controls.Add(Me.AreaTextBox)
        Me.TabPage1.Controls.Add(CMCLabel)
        Me.TabPage1.Controls.Add(Me.CadImobTextBox)
        Me.TabPage1.Controls.Add(Me.CMCTextBox)
        Me.TabPage1.Controls.Add(CadImobLabel)
        Me.TabPage1.Controls.Add(EndDataLabel)
        Me.TabPage1.Controls.Add(Me.EndDataTextBox)
        Me.TabPage1.Controls.Add(EndQuadraLabel)
        Me.TabPage1.Controls.Add(Me.EndQuadraTextBox)
        Me.TabPage1.Controls.Add(EndZonaLabel)
        Me.TabPage1.Controls.Add(Me.EndZonaTextBox)
        Me.TabPage1.Controls.Add(EndCEPLabel)
        Me.TabPage1.Controls.Add(Me.EnderecoTextBox)
        Me.TabPage1.Controls.Add(EnderecoLabel)
        Me.TabPage1.Controls.Add(Me.EndNumTextBox)
        Me.TabPage1.Controls.Add(EndNumLabel)
        Me.TabPage1.Controls.Add(TelefoneLabel)
        Me.TabPage1.Controls.Add(Me.EndCompTextBox)
        Me.TabPage1.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.TabPage1.Controls.Add(EndCompLabel)
        Me.TabPage1.Controls.Add(Me.EndBairroTextBox)
        Me.TabPage1.Controls.Add(EndBairroLabel)
        Me.TabPage1.Controls.Add(Me.EndCEPMaskedTextBox)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.EndCidadeTextBox)
        Me.TabPage1.Controls.Add(EndEstadoLabel)
        Me.TabPage1.Controls.Add(EndCidadeLabel)
        Me.TabPage1.Controls.Add(Me.EndEstadoTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(549, 207)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Endereço"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(473, 98)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 19)
        Me.Button9.TabIndex = 51
        Me.Button9.Text = "Buscar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PontoRefTextBox
        '
        Me.PontoRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "PontoRef", True))
        Me.PontoRefTextBox.Location = New System.Drawing.Point(343, 124)
        Me.PontoRefTextBox.Name = "PontoRefTextBox"
        Me.PontoRefTextBox.Size = New System.Drawing.Size(184, 20)
        Me.PontoRefTextBox.TabIndex = 52
        '
        'Area2TextBox
        '
        Me.Area2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "area2", True))
        Me.Area2TextBox.Location = New System.Drawing.Point(331, 180)
        Me.Area2TextBox.Name = "Area2TextBox"
        Me.Area2TextBox.Size = New System.Drawing.Size(49, 20)
        Me.Area2TextBox.TabIndex = 42
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(124, 180)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(49, 20)
        Me.AreaTextBox.TabIndex = 41
        '
        'CadImobTextBox
        '
        Me.CadImobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CadImob", True))
        Me.CadImobTextBox.Location = New System.Drawing.Point(378, 98)
        Me.CadImobTextBox.Name = "CadImobTextBox"
        Me.CadImobTextBox.Size = New System.Drawing.Size(89, 20)
        Me.CadImobTextBox.TabIndex = 40
        '
        'CMCTextBox
        '
        Me.CMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CMC", True))
        Me.CMCTextBox.Location = New System.Drawing.Point(445, 20)
        Me.CMCTextBox.Name = "CMCTextBox"
        Me.CMCTextBox.Size = New System.Drawing.Size(82, 20)
        Me.CMCTextBox.TabIndex = 40
        '
        'EndDataTextBox
        '
        Me.EndDataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndData", True))
        Me.EndDataTextBox.Location = New System.Drawing.Point(234, 98)
        Me.EndDataTextBox.Name = "EndDataTextBox"
        Me.EndDataTextBox.Size = New System.Drawing.Size(35, 20)
        Me.EndDataTextBox.TabIndex = 29
        '
        'EndQuadraTextBox
        '
        Me.EndQuadraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndQuadra", True))
        Me.EndQuadraTextBox.Location = New System.Drawing.Point(165, 98)
        Me.EndQuadraTextBox.Name = "EndQuadraTextBox"
        Me.EndQuadraTextBox.Size = New System.Drawing.Size(35, 20)
        Me.EndQuadraTextBox.TabIndex = 28
        '
        'EndZonaTextBox
        '
        Me.EndZonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndZona", True))
        Me.EndZonaTextBox.Location = New System.Drawing.Point(83, 98)
        Me.EndZonaTextBox.Name = "EndZonaTextBox"
        Me.EndZonaTextBox.Size = New System.Drawing.Size(35, 20)
        Me.EndZonaTextBox.TabIndex = 27
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ResptecnicoTextBox)
        Me.TabPage2.Controls.Add(ResptecnicoLabel)
        Me.TabPage2.Controls.Add(Me.ResptecnicoNumeroTextBox)
        Me.TabPage2.Controls.Add(ResptecnicoNumeroLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(549, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Técnico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(549, 207)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Requerente"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(CNPJRequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.CNPJRequerenteMaskedTextBox)
        Me.GroupBox1.Controls.Add(RGRequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.RGRequerenteTextBox)
        Me.GroupBox1.Controls.Add(CPFRequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.CPFRequerenteMaskedTextBox)
        Me.GroupBox1.Controls.Add(EmailRequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.EmailRequerenteTextBox)
        Me.GroupBox1.Controls.Add(FoneRequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.FoneRequerenteTextBox)
        Me.GroupBox1.Controls.Add(EndRequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.EndRequerenteTextBox)
        Me.GroupBox1.Controls.Add(RequerenteLabel)
        Me.GroupBox1.Controls.Add(Me.RequerenteTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 167)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requerente do Laudo"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(82, 80)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(69, 23)
        Me.Button10.TabIndex = 46
        Me.Button10.Text = "Importar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CNPJRequerenteMaskedTextBox
        '
        Me.CNPJRequerenteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CNPJRequerente", True))
        Me.CNPJRequerenteMaskedTextBox.Location = New System.Drawing.Point(383, 56)
        Me.CNPJRequerenteMaskedTextBox.Mask = "00.000.000/0000-00"
        Me.CNPJRequerenteMaskedTextBox.Name = "CNPJRequerenteMaskedTextBox"
        Me.CNPJRequerenteMaskedTextBox.Size = New System.Drawing.Size(107, 20)
        Me.CNPJRequerenteMaskedTextBox.TabIndex = 34
        '
        'RGRequerenteTextBox
        '
        Me.RGRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "RGRequerente", True))
        Me.RGRequerenteTextBox.Location = New System.Drawing.Point(217, 56)
        Me.RGRequerenteTextBox.Name = "RGRequerenteTextBox"
        Me.RGRequerenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RGRequerenteTextBox.TabIndex = 33
        '
        'CPFRequerenteMaskedTextBox
        '
        Me.CPFRequerenteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CPFRequerente", True))
        Me.CPFRequerenteMaskedTextBox.Location = New System.Drawing.Point(83, 56)
        Me.CPFRequerenteMaskedTextBox.Mask = "000.000.000-00"
        Me.CPFRequerenteMaskedTextBox.Name = "CPFRequerenteMaskedTextBox"
        Me.CPFRequerenteMaskedTextBox.Size = New System.Drawing.Size(86, 20)
        Me.CPFRequerenteMaskedTextBox.TabIndex = 32
        '
        'EmailRequerenteTextBox
        '
        Me.EmailRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EmailRequerente", True))
        Me.EmailRequerenteTextBox.Location = New System.Drawing.Point(258, 130)
        Me.EmailRequerenteTextBox.Name = "EmailRequerenteTextBox"
        Me.EmailRequerenteTextBox.Size = New System.Drawing.Size(232, 20)
        Me.EmailRequerenteTextBox.TabIndex = 29
        '
        'FoneRequerenteTextBox
        '
        Me.FoneRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "FoneRequerente", True))
        Me.FoneRequerenteTextBox.Location = New System.Drawing.Point(83, 130)
        Me.FoneRequerenteTextBox.Name = "FoneRequerenteTextBox"
        Me.FoneRequerenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FoneRequerenteTextBox.TabIndex = 28
        '
        'EndRequerenteTextBox
        '
        Me.EndRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndRequerente", True))
        Me.EndRequerenteTextBox.Location = New System.Drawing.Point(83, 104)
        Me.EndRequerenteTextBox.Name = "EndRequerenteTextBox"
        Me.EndRequerenteTextBox.Size = New System.Drawing.Size(407, 20)
        Me.EndRequerenteTextBox.TabIndex = 27
        '
        'RequerenteTextBox
        '
        Me.RequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Requerente", True))
        Me.RequerenteTextBox.Location = New System.Drawing.Point(83, 30)
        Me.RequerenteTextBox.Name = "RequerenteTextBox"
        Me.RequerenteTextBox.Size = New System.Drawing.Size(407, 20)
        Me.RequerenteTextBox.TabIndex = 25
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(RamodeatividadeLabel)
        Me.TabPage4.Controls.Add(Me.RamodeatividadeRichTextBox)
        Me.TabPage4.Controls.Add(CNAELabel)
        Me.TabPage4.Controls.Add(Me.CNAERichTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(549, 207)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ramo de Atividade"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'RamodeatividadeRichTextBox
        '
        Me.RamodeatividadeRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Ramodeatividade", True))
        Me.RamodeatividadeRichTextBox.Location = New System.Drawing.Point(13, 122)
        Me.RamodeatividadeRichTextBox.Name = "RamodeatividadeRichTextBox"
        Me.RamodeatividadeRichTextBox.Size = New System.Drawing.Size(503, 72)
        Me.RamodeatividadeRichTextBox.TabIndex = 25
        Me.RamodeatividadeRichTextBox.Text = ""
        '
        'CNAERichTextBox
        '
        Me.CNAERichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CNAE", True))
        Me.CNAERichTextBox.Location = New System.Drawing.Point(15, 32)
        Me.CNAERichTextBox.Name = "CNAERichTextBox"
        Me.CNAERichTextBox.Size = New System.Drawing.Size(503, 71)
        Me.CNAERichTextBox.TabIndex = 24
        Me.CNAERichTextBox.Text = ""
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.NaturezaDoPedidoRichTextBox)
        Me.TabPage6.Controls.Add(NaturezaDoPedidoLabel)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(549, 207)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Natureza do Pedido"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'NaturezaDoPedidoRichTextBox
        '
        Me.NaturezaDoPedidoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "NaturezaDoPedido", True))
        Me.NaturezaDoPedidoRichTextBox.Location = New System.Drawing.Point(17, 30)
        Me.NaturezaDoPedidoRichTextBox.Name = "NaturezaDoPedidoRichTextBox"
        Me.NaturezaDoPedidoRichTextBox.Size = New System.Drawing.Size(495, 155)
        Me.NaturezaDoPedidoRichTextBox.TabIndex = 37
        Me.NaturezaDoPedidoRichTextBox.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DataSource = Me.LaudosBindingSource
        Me.ComboBox1.DisplayMember = "RazaoSocial"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(239, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(231, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "RazaoSocial"
        '
        'NlaudoTextBox
        '
        Me.NlaudoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Nlaudo", True))
        Me.NlaudoTextBox.Location = New System.Drawing.Point(362, 16)
        Me.NlaudoTextBox.Name = "NlaudoTextBox"
        Me.NlaudoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NlaudoTextBox.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(ModeloSistemaLabel)
        Me.GroupBox2.Controls.Add(Me.ModeloSistemaComboBox)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(NlaudoLabel)
        Me.GroupBox2.Controls.Add(Me.NlaudoTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 72)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(468, 41)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 24)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "Solicitar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'ModeloSistemaComboBox
        '
        Me.ModeloSistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ModeloSistema", True))
        Me.ModeloSistemaComboBox.FormattingEnabled = True
        Me.ModeloSistemaComboBox.Items.AddRange(New Object() {"Alvará Online", "Alvará Antigo", "Alvará Primitivo"})
        Me.ModeloSistemaComboBox.Location = New System.Drawing.Point(362, 42)
        Me.ModeloSistemaComboBox.Name = "ModeloSistemaComboBox"
        Me.ModeloSistemaComboBox.Size = New System.Drawing.Size(101, 21)
        Me.ModeloSistemaComboBox.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(468, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 24)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Acompanhar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataEntradaMaskedTextBox
        '
        Me.DataEntradaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "DataEntrada", True))
        Me.DataEntradaMaskedTextBox.Location = New System.Drawing.Point(89, 153)
        Me.DataEntradaMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataEntradaMaskedTextBox.Name = "DataEntradaMaskedTextBox"
        Me.DataEntradaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataEntradaMaskedTextBox.TabIndex = 5
        Me.DataEntradaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'SituacaoComboBox
        '
        Me.SituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Situacao", True))
        Me.SituacaoComboBox.FormattingEnabled = True
        Me.SituacaoComboBox.Items.AddRange(New Object() {"Não Iniciado", "Aguardando Pagamento", "Em Andamento", "Pendência", "Paralisado", "Baixado", "Não Fazer", "Cancelado", "Finalizado Definitivo", "Finalizado Provisório"})
        Me.SituacaoComboBox.Location = New System.Drawing.Point(376, 101)
        Me.SituacaoComboBox.Name = "SituacaoComboBox"
        Me.SituacaoComboBox.Size = New System.Drawing.Size(185, 21)
        Me.SituacaoComboBox.TabIndex = 1
        '
        'DataCriadoMaskedTextBox
        '
        Me.DataCriadoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "DataCriado", True))
        Me.DataCriadoMaskedTextBox.Location = New System.Drawing.Point(89, 127)
        Me.DataCriadoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataCriadoMaskedTextBox.Name = "DataCriadoMaskedTextBox"
        Me.DataCriadoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataCriadoMaskedTextBox.TabIndex = 7
        Me.DataCriadoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 22)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AvisarDiaMaskedTextBox
        '
        Me.AvisarDiaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "AvisarDia", True))
        Me.AvisarDiaMaskedTextBox.Location = New System.Drawing.Point(496, 124)
        Me.AvisarDiaMaskedTextBox.Mask = "00/00/0000"
        Me.AvisarDiaMaskedTextBox.Name = "AvisarDiaMaskedTextBox"
        Me.AvisarDiaMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.AvisarDiaMaskedTextBox.TabIndex = 40
        Me.AvisarDiaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(14, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 23)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Empresas"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(14, 118)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(69, 23)
        Me.Button19.TabIndex = 45
        Me.Button19.Text = "Fechar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(14, 47)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(69, 23)
        Me.Button18.TabIndex = 44
        Me.Button18.Text = "Salvar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.ForeColor = System.Drawing.Color.Red
        Me.Button17.Location = New System.Drawing.Point(14, 89)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(69, 23)
        Me.Button17.TabIndex = 43
        Me.Button17.Text = "Excluir"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.ForeColor = System.Drawing.Color.Green
        Me.Button16.Location = New System.Drawing.Point(14, 19)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(69, 22)
        Me.Button16.TabIndex = 42
        Me.Button16.Text = "Novo"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button19)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button18)
        Me.GroupBox3.Controls.Add(Me.Button17)
        Me.GroupBox3.Location = New System.Drawing.Point(574, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(97, 495)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MENU"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(14, 313)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 23)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Telefones"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(14, 284)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 23)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Contador"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nº Laudo:"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.LaudosBindingSource
        Me.ComboBox2.DisplayMember = "Nlaudo"
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(537, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox2.TabIndex = 49
        Me.ComboBox2.ValueMember = "Nlaudo"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(266, 99)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 22)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "Copiar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DataEntradaLabel
        '
        Me.DataEntradaLabel.AutoSize = True
        Me.DataEntradaLabel.Location = New System.Drawing.Point(3, 158)
        Me.DataEntradaLabel.Name = "DataEntradaLabel"
        Me.DataEntradaLabel.Size = New System.Drawing.Size(84, 13)
        Me.DataEntradaLabel.TabIndex = 51
        Me.DataEntradaLabel.Text = "Protocolado dia:"
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.alvara1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'LaudosCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(691, 543)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataEntradaLabel)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(AvisarDiaLabel)
        Me.Controls.Add(Me.AvisarDiaMaskedTextBox)
        Me.Controls.Add(Me.DataEntradaMaskedTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(DataCriadoLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataCriadoMaskedTextBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(SituacaoLabel)
        Me.Controls.Add(Me.LembreteCheckBox)
        Me.Controls.Add(Me.SituacaoComboBox)
        Me.Controls.Add(CNPJLabel)
        Me.Controls.Add(Me.CNPJMaskedTextBox)
        Me.Controls.Add(RazaoSocialLabel)
        Me.Controls.Add(Me.RazaoSocialTextBox)
        Me.Controls.Add(Me.LaudosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaudosCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laudos - Cadastro"
        CType(Me.LaudosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LaudosBindingNavigator.ResumeLayout(False)
        Me.LaudosBindingNavigator.PerformLayout()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LaudosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents EndNumTextBox As TextBox
    Friend WithEvents EndCompTextBox As TextBox
    Friend WithEvents EndBairroTextBox As TextBox
    Friend WithEvents EndCEPMaskedTextBox As MaskedTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents EndCidadeTextBox As TextBox
    Friend WithEvents EndEstadoTextBox As TextBox
    Friend WithEvents ResptecnicoTextBox As TextBox
    Friend WithEvents ResptecnicoNumeroTextBox As TextBox
    Friend WithEvents LembreteCheckBox As CheckBox
    Friend WithEvents TelefoneMaskedTextBox As MaskedTextBox
    Friend WithEvents NaturezaDoPedidoOBSRichTextBox As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents EmailRequerenteTextBox As TextBox
    Friend WithEvents FoneRequerenteTextBox As TextBox
    Friend WithEvents EndRequerenteTextBox As TextBox
    Friend WithEvents RequerenteTextBox As TextBox
    Friend WithEvents CNAERichTextBox As RichTextBox
    Friend WithEvents RamodeatividadeRichTextBox As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CNPJRequerenteMaskedTextBox As MaskedTextBox
    Friend WithEvents RGRequerenteTextBox As TextBox
    Friend WithEvents CPFRequerenteMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NlaudoTextBox As TextBox
    Friend WithEvents NaturezaDoPedidoRichTextBox As RichTextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataCriadoMaskedTextBox As MaskedTextBox
    Friend WithEvents DataEntradaMaskedTextBox As MaskedTextBox
    Friend WithEvents SituacaoComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ModeloSistemaComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents EndZonaTextBox As TextBox
    Friend WithEvents EndDataTextBox As TextBox
    Friend WithEvents EndQuadraTextBox As TextBox
    Friend WithEvents CadImobTextBox As TextBox
    Friend WithEvents CMCTextBox As TextBox
    Friend WithEvents AvisarDiaMaskedTextBox As MaskedTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Area2TextBox As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents DataEntradaLabel As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents PontoRefTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
