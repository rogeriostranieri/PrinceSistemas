<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSocios
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
        Dim CPFLabel As System.Windows.Forms.Label
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim NomeMaeLabel As System.Windows.Forms.Label
        Dim NomePaiLabel As System.Windows.Forms.Label
        Dim DatadeNascLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim OrgaoRGLabel As System.Windows.Forms.Label
        Dim EstadoRGLabel As System.Windows.Forms.Label
        Dim TituloDeEleitorLabel As System.Windows.Forms.Label
        Dim SenhaGOVLabel As System.Windows.Forms.Label
        Dim CNHLabel As System.Windows.Forms.Label
        Dim CNHExpedicaoLabel As System.Windows.Forms.Label
        Dim CNHDataExpLabel As System.Windows.Forms.Label
        Dim CivilLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim RUALabel As System.Windows.Forms.Label
        Dim NumLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaísLabel As System.Windows.Forms.Label
        Dim Telefone1Label As System.Windows.Forms.Label
        Dim Telefone2Label As System.Windows.Forms.Label
        Dim EMailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSocios))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.SociosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.SociosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeMaeTextBox = New System.Windows.Forms.TextBox()
        Me.NomePaiTextBox = New System.Windows.Forms.TextBox()
        Me.DatadeNascMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RGTextBox = New System.Windows.Forms.TextBox()
        Me.OrgaoRGTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoRGTextBox = New System.Windows.Forms.TextBox()
        Me.TituloDeEleitorTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaGOVTextBox = New System.Windows.Forms.TextBox()
        Me.CNHTextBox = New System.Windows.Forms.TextBox()
        Me.CNHExpedicaoTextBox = New System.Windows.Forms.TextBox()
        Me.CNHDataExpTextBox = New System.Windows.Forms.TextBox()
        Me.CivilComboBox = New System.Windows.Forms.ComboBox()
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RUATextBox = New System.Windows.Forms.TextBox()
        Me.NumTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.PaísTextBox = New System.Windows.Forms.TextBox()
        Me.Telefone1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone2MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxOutrosDados = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDadosPessoais = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CPFComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeCompletoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.PictureBox()
        Me.BtnExcluir = New System.Windows.Forms.PictureBox()
        Me.BtnEditar = New System.Windows.Forms.PictureBox()
        Me.BtnSalvar = New System.Windows.Forms.PictureBox()
        Me.BtnNovo = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CPFLabel = New System.Windows.Forms.Label()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        NomeMaeLabel = New System.Windows.Forms.Label()
        NomePaiLabel = New System.Windows.Forms.Label()
        DatadeNascLabel = New System.Windows.Forms.Label()
        RGLabel = New System.Windows.Forms.Label()
        OrgaoRGLabel = New System.Windows.Forms.Label()
        EstadoRGLabel = New System.Windows.Forms.Label()
        TituloDeEleitorLabel = New System.Windows.Forms.Label()
        SenhaGOVLabel = New System.Windows.Forms.Label()
        CNHLabel = New System.Windows.Forms.Label()
        CNHExpedicaoLabel = New System.Windows.Forms.Label()
        CNHDataExpLabel = New System.Windows.Forms.Label()
        CivilLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        RUALabel = New System.Windows.Forms.Label()
        NumLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        PaísLabel = New System.Windows.Forms.Label()
        Telefone1Label = New System.Windows.Forms.Label()
        Telefone2Label = New System.Windows.Forms.Label()
        EMailLabel = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SociosBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxOutrosDados.SuspendLayout()
        Me.GroupBoxDadosPessoais.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BtnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnExcluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSalvar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(68, 27)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.Location = New System.Drawing.Point(13, 53)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(85, 13)
        NomeCompletoLabel.TabIndex = 3
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'NomeMaeLabel
        '
        NomeMaeLabel.AutoSize = True
        NomeMaeLabel.Location = New System.Drawing.Point(36, 79)
        NomeMaeLabel.Name = "NomeMaeLabel"
        NomeMaeLabel.Size = New System.Drawing.Size(62, 13)
        NomeMaeLabel.TabIndex = 5
        NomeMaeLabel.Text = "Nome Mae:"
        '
        'NomePaiLabel
        '
        NomePaiLabel.AutoSize = True
        NomePaiLabel.Location = New System.Drawing.Point(42, 105)
        NomePaiLabel.Name = "NomePaiLabel"
        NomePaiLabel.Size = New System.Drawing.Size(56, 13)
        NomePaiLabel.TabIndex = 7
        NomePaiLabel.Text = "Nome Pai:"
        '
        'DatadeNascLabel
        '
        DatadeNascLabel.AutoSize = True
        DatadeNascLabel.Location = New System.Drawing.Point(25, 131)
        DatadeNascLabel.Name = "DatadeNascLabel"
        DatadeNascLabel.Size = New System.Drawing.Size(73, 13)
        DatadeNascLabel.TabIndex = 9
        DatadeNascLabel.Text = "Datade Nasc:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Location = New System.Drawing.Point(72, 214)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(26, 13)
        RGLabel.TabIndex = 11
        RGLabel.Text = "RG:"
        '
        'OrgaoRGLabel
        '
        OrgaoRGLabel.AutoSize = True
        OrgaoRGLabel.Location = New System.Drawing.Point(228, 214)
        OrgaoRGLabel.Name = "OrgaoRGLabel"
        OrgaoRGLabel.Size = New System.Drawing.Size(58, 13)
        OrgaoRGLabel.TabIndex = 13
        OrgaoRGLabel.Text = "Orgao RG:"
        '
        'EstadoRGLabel
        '
        EstadoRGLabel.AutoSize = True
        EstadoRGLabel.Location = New System.Drawing.Point(352, 214)
        EstadoRGLabel.Name = "EstadoRGLabel"
        EstadoRGLabel.Size = New System.Drawing.Size(62, 13)
        EstadoRGLabel.TabIndex = 15
        EstadoRGLabel.Text = "Estado RG:"
        '
        'TituloDeEleitorLabel
        '
        TituloDeEleitorLabel.AutoSize = True
        TituloDeEleitorLabel.Location = New System.Drawing.Point(13, 240)
        TituloDeEleitorLabel.Name = "TituloDeEleitorLabel"
        TituloDeEleitorLabel.Size = New System.Drawing.Size(85, 13)
        TituloDeEleitorLabel.TabIndex = 17
        TituloDeEleitorLabel.Text = "Titulo De Eleitor:"
        '
        'SenhaGOVLabel
        '
        SenhaGOVLabel.AutoSize = True
        SenhaGOVLabel.Location = New System.Drawing.Point(268, 157)
        SenhaGOVLabel.Name = "SenhaGOVLabel"
        SenhaGOVLabel.Size = New System.Drawing.Size(67, 13)
        SenhaGOVLabel.TabIndex = 19
        SenhaGOVLabel.Text = "Senha GOV:"
        '
        'CNHLabel
        '
        CNHLabel.AutoSize = True
        CNHLabel.Location = New System.Drawing.Point(65, 266)
        CNHLabel.Name = "CNHLabel"
        CNHLabel.Size = New System.Drawing.Size(33, 13)
        CNHLabel.TabIndex = 21
        CNHLabel.Text = "CNH:"
        '
        'CNHExpedicaoLabel
        '
        CNHExpedicaoLabel.AutoSize = True
        CNHExpedicaoLabel.Location = New System.Drawing.Point(210, 292)
        CNHExpedicaoLabel.Name = "CNHExpedicaoLabel"
        CNHExpedicaoLabel.Size = New System.Drawing.Size(60, 13)
        CNHExpedicaoLabel.TabIndex = 23
        CNHExpedicaoLabel.Text = "Expedicao:"
        '
        'CNHDataExpLabel
        '
        CNHDataExpLabel.AutoSize = True
        CNHDataExpLabel.Location = New System.Drawing.Point(44, 292)
        CNHDataExpLabel.Name = "CNHDataExpLabel"
        CNHDataExpLabel.Size = New System.Drawing.Size(54, 13)
        CNHDataExpLabel.TabIndex = 25
        CNHDataExpLabel.Text = "Data Exp:"
        '
        'CivilLabel
        '
        CivilLabel.AutoSize = True
        CivilLabel.Location = New System.Drawing.Point(33, 157)
        CivilLabel.Name = "CivilLabel"
        CivilLabel.Size = New System.Drawing.Size(65, 13)
        CivilLabel.TabIndex = 27
        CivilLabel.Text = "Estado Civil:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(44, 30)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 29
        CEPLabel.Text = "CEP:"
        '
        'RUALabel
        '
        RUALabel.AutoSize = True
        RUALabel.Location = New System.Drawing.Point(42, 56)
        RUALabel.Name = "RUALabel"
        RUALabel.Size = New System.Drawing.Size(33, 13)
        RUALabel.TabIndex = 31
        RUALabel.Text = "RUA:"
        '
        'NumLabel
        '
        NumLabel.AutoSize = True
        NumLabel.Location = New System.Drawing.Point(43, 82)
        NumLabel.Name = "NumLabel"
        NumLabel.Size = New System.Drawing.Size(32, 13)
        NumLabel.TabIndex = 33
        NumLabel.Text = "Num:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(38, 108)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 35
        BairroLabel.Text = "Bairro:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(152, 82)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(74, 13)
        ComplementoLabel.TabIndex = 37
        ComplementoLabel.Text = "Complemento:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(32, 134)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 39
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(261, 126)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 41
        EstadoLabel.Text = "Estado:"
        '
        'PaísLabel
        '
        PaísLabel.AutoSize = True
        PaísLabel.Location = New System.Drawing.Point(43, 160)
        PaísLabel.Name = "PaísLabel"
        PaísLabel.Size = New System.Drawing.Size(32, 13)
        PaísLabel.TabIndex = 43
        PaísLabel.Text = "País:"
        '
        'Telefone1Label
        '
        Telefone1Label.AutoSize = True
        Telefone1Label.Location = New System.Drawing.Point(14, 186)
        Telefone1Label.Name = "Telefone1Label"
        Telefone1Label.Size = New System.Drawing.Size(61, 13)
        Telefone1Label.TabIndex = 45
        Telefone1Label.Text = "Telefone 1:"
        '
        'Telefone2Label
        '
        Telefone2Label.AutoSize = True
        Telefone2Label.Location = New System.Drawing.Point(14, 212)
        Telefone2Label.Name = "Telefone2Label"
        Telefone2Label.Size = New System.Drawing.Size(61, 13)
        Telefone2Label.TabIndex = 47
        Telefone2Label.Text = "Telefone 2:"
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(37, 238)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(38, 13)
        EMailLabel.TabIndex = 49
        EMailLabel.Text = "e Mail:"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "Socios"
        Me.SociosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Me.SociosTableAdapter
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SociosBindingNavigator
        '
        Me.SociosBindingNavigator.AddNewItem = Nothing
        Me.SociosBindingNavigator.BindingSource = Me.SociosBindingSource
        Me.SociosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SociosBindingNavigator.DeleteItem = Nothing
        Me.SociosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.SociosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SociosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SociosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SociosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SociosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SociosBindingNavigator.Name = "SociosBindingNavigator"
        Me.SociosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SociosBindingNavigator.Size = New System.Drawing.Size(1067, 25)
        Me.SociosBindingNavigator.TabIndex = 0
        Me.SociosBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(104, 24)
        Me.CPFMaskedTextBox.Mask = "999,999,999-99"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFMaskedTextBox.TabIndex = 2
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeCompleto", True))
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(104, 50)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomeCompletoTextBox.TabIndex = 4
        '
        'NomeMaeTextBox
        '
        Me.NomeMaeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeMae", True))
        Me.NomeMaeTextBox.Location = New System.Drawing.Point(104, 76)
        Me.NomeMaeTextBox.Name = "NomeMaeTextBox"
        Me.NomeMaeTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomeMaeTextBox.TabIndex = 6
        '
        'NomePaiTextBox
        '
        Me.NomePaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomePai", True))
        Me.NomePaiTextBox.Location = New System.Drawing.Point(104, 102)
        Me.NomePaiTextBox.Name = "NomePaiTextBox"
        Me.NomePaiTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomePaiTextBox.TabIndex = 8
        '
        'DatadeNascMaskedTextBox
        '
        Me.DatadeNascMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "DatadeNasc", True))
        Me.DatadeNascMaskedTextBox.Location = New System.Drawing.Point(104, 128)
        Me.DatadeNascMaskedTextBox.Mask = "00/00/0000"
        Me.DatadeNascMaskedTextBox.Name = "DatadeNascMaskedTextBox"
        Me.DatadeNascMaskedTextBox.Size = New System.Drawing.Size(72, 20)
        Me.DatadeNascMaskedTextBox.TabIndex = 10
        Me.DatadeNascMaskedTextBox.ValidatingType = GetType(Date)
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(104, 211)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(118, 20)
        Me.RGTextBox.TabIndex = 12
        '
        'OrgaoRGTextBox
        '
        Me.OrgaoRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "OrgaoRG", True))
        Me.OrgaoRGTextBox.Location = New System.Drawing.Point(292, 211)
        Me.OrgaoRGTextBox.Name = "OrgaoRGTextBox"
        Me.OrgaoRGTextBox.Size = New System.Drawing.Size(54, 20)
        Me.OrgaoRGTextBox.TabIndex = 14
        '
        'EstadoRGTextBox
        '
        Me.EstadoRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "EstadoRG", True))
        Me.EstadoRGTextBox.Location = New System.Drawing.Point(420, 211)
        Me.EstadoRGTextBox.Name = "EstadoRGTextBox"
        Me.EstadoRGTextBox.Size = New System.Drawing.Size(39, 20)
        Me.EstadoRGTextBox.TabIndex = 16
        '
        'TituloDeEleitorTextBox
        '
        Me.TituloDeEleitorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "TituloDeEleitor", True))
        Me.TituloDeEleitorTextBox.Location = New System.Drawing.Point(104, 237)
        Me.TituloDeEleitorTextBox.Name = "TituloDeEleitorTextBox"
        Me.TituloDeEleitorTextBox.Size = New System.Drawing.Size(118, 20)
        Me.TituloDeEleitorTextBox.TabIndex = 18
        '
        'SenhaGOVTextBox
        '
        Me.SenhaGOVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "SenhaGOV", True))
        Me.SenhaGOVTextBox.Location = New System.Drawing.Point(341, 154)
        Me.SenhaGOVTextBox.Name = "SenhaGOVTextBox"
        Me.SenhaGOVTextBox.Size = New System.Drawing.Size(118, 20)
        Me.SenhaGOVTextBox.TabIndex = 20
        '
        'CNHTextBox
        '
        Me.CNHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNH", True))
        Me.CNHTextBox.Location = New System.Drawing.Point(104, 263)
        Me.CNHTextBox.Name = "CNHTextBox"
        Me.CNHTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CNHTextBox.TabIndex = 22
        '
        'CNHExpedicaoTextBox
        '
        Me.CNHExpedicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNHExpedicao", True))
        Me.CNHExpedicaoTextBox.Location = New System.Drawing.Point(276, 289)
        Me.CNHExpedicaoTextBox.Name = "CNHExpedicaoTextBox"
        Me.CNHExpedicaoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNHExpedicaoTextBox.TabIndex = 24
        '
        'CNHDataExpTextBox
        '
        Me.CNHDataExpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNHDataExp", True))
        Me.CNHDataExpTextBox.Location = New System.Drawing.Point(104, 289)
        Me.CNHDataExpTextBox.Name = "CNHDataExpTextBox"
        Me.CNHDataExpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNHDataExpTextBox.TabIndex = 26
        '
        'CivilComboBox
        '
        Me.CivilComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Civil", True))
        Me.CivilComboBox.FormattingEnabled = True
        Me.CivilComboBox.Location = New System.Drawing.Point(104, 154)
        Me.CivilComboBox.Name = "CivilComboBox"
        Me.CivilComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CivilComboBox.TabIndex = 28
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(81, 27)
        Me.CEPMaskedTextBox.Mask = "99,999-999"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(72, 20)
        Me.CEPMaskedTextBox.TabIndex = 30
        '
        'RUATextBox
        '
        Me.RUATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RUA", True))
        Me.RUATextBox.Location = New System.Drawing.Point(81, 53)
        Me.RUATextBox.Name = "RUATextBox"
        Me.RUATextBox.Size = New System.Drawing.Size(271, 20)
        Me.RUATextBox.TabIndex = 32
        '
        'NumTextBox
        '
        Me.NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Num", True))
        Me.NumTextBox.Location = New System.Drawing.Point(81, 79)
        Me.NumTextBox.Name = "NumTextBox"
        Me.NumTextBox.Size = New System.Drawing.Size(65, 20)
        Me.NumTextBox.TabIndex = 34
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(81, 105)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(208, 20)
        Me.BairroTextBox.TabIndex = 36
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(232, 79)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ComplementoTextBox.TabIndex = 38
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(81, 131)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(174, 20)
        Me.CidadeTextBox.TabIndex = 40
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(310, 123)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(42, 20)
        Me.EstadoTextBox.TabIndex = 42
        '
        'PaísTextBox
        '
        Me.PaísTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "País", True))
        Me.PaísTextBox.Location = New System.Drawing.Point(81, 157)
        Me.PaísTextBox.Name = "PaísTextBox"
        Me.PaísTextBox.Size = New System.Drawing.Size(124, 20)
        Me.PaísTextBox.TabIndex = 44
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Telefone1", True))
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(81, 183)
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefone1MaskedTextBox.TabIndex = 46
        '
        'Telefone2MaskedTextBox
        '
        Me.Telefone2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Telefone2", True))
        Me.Telefone2MaskedTextBox.Location = New System.Drawing.Point(81, 209)
        Me.Telefone2MaskedTextBox.Name = "Telefone2MaskedTextBox"
        Me.Telefone2MaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefone2MaskedTextBox.TabIndex = 48
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "eMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(81, 235)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(271, 20)
        Me.EMailTextBox.TabIndex = 50
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.26523!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.73477!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxOutrosDados, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxDadosPessoais, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.68182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.31818!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 446)
        Me.TableLayoutPanel1.TabIndex = 51
        '
        'GroupBoxOutrosDados
        '
        Me.GroupBoxOutrosDados.Controls.Add(EMailLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.EMailTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(Telefone2Label)
        Me.GroupBoxOutrosDados.Controls.Add(Me.Telefone2MaskedTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(Telefone1Label)
        Me.GroupBoxOutrosDados.Controls.Add(Me.Telefone1MaskedTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(PaísLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.PaísTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(EstadoLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.EstadoTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(CidadeLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.CidadeTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(ComplementoLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.ComplementoTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(BairroLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.BairroTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(NumLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.NumTextBox)
        Me.GroupBoxOutrosDados.Controls.Add(RUALabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.RUATextBox)
        Me.GroupBoxOutrosDados.Controls.Add(CEPLabel)
        Me.GroupBoxOutrosDados.Controls.Add(Me.CEPMaskedTextBox)
        Me.GroupBoxOutrosDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxOutrosDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxOutrosDados.Location = New System.Drawing.Point(550, 118)
        Me.GroupBoxOutrosDados.Name = "GroupBoxOutrosDados"
        Me.GroupBoxOutrosDados.Size = New System.Drawing.Size(514, 325)
        Me.GroupBoxOutrosDados.TabIndex = 52
        Me.GroupBoxOutrosDados.TabStop = False
        Me.GroupBoxOutrosDados.Text = "Outros Dados"
        '
        'GroupBoxDadosPessoais
        '
        Me.GroupBoxDadosPessoais.Controls.Add(CivilLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CivilComboBox)
        Me.GroupBoxDadosPessoais.Controls.Add(CNHDataExpLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CNHDataExpTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(CNHExpedicaoLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CNHExpedicaoTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(CNHLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CNHTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(SenhaGOVLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.SenhaGOVTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(TituloDeEleitorLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.TituloDeEleitorTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(EstadoRGLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.EstadoRGTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(OrgaoRGLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.OrgaoRGTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(RGLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.RGTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(DatadeNascLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.DatadeNascMaskedTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(NomePaiLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.NomePaiTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(NomeMaeLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.NomeMaeTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(NomeCompletoLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.NomeCompletoTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(CPFLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CPFMaskedTextBox)
        Me.GroupBoxDadosPessoais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxDadosPessoais.Location = New System.Drawing.Point(3, 118)
        Me.GroupBoxDadosPessoais.Name = "GroupBoxDadosPessoais"
        Me.GroupBoxDadosPessoais.Size = New System.Drawing.Size(541, 325)
        Me.GroupBoxDadosPessoais.TabIndex = 52
        Me.GroupBoxDadosPessoais.TabStop = False
        Me.GroupBoxDadosPessoais.Text = "Dados Pessoais"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(934, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Fechar")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 64)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "DADOS CADASTRAIS DOS SOCIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CPFComboBox)
        Me.GroupBox3.Controls.Add(Me.NomeCompletoComboBox)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(3, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 45)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Localizar Sócio"
        '
        'CPFComboBox
        '
        Me.CPFComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CPFComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CPFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CPF", True))
        Me.CPFComboBox.FormattingEnabled = True
        Me.CPFComboBox.Location = New System.Drawing.Point(414, 13)
        Me.CPFComboBox.Name = "CPFComboBox"
        Me.CPFComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CPFComboBox.TabIndex = 4
        '
        'NomeCompletoComboBox
        '
        Me.NomeCompletoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NomeCompletoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomeCompletoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeCompleto", True))
        Me.NomeCompletoComboBox.FormattingEnabled = True
        Me.NomeCompletoComboBox.Location = New System.Drawing.Point(110, 13)
        Me.NomeCompletoComboBox.Name = "NomeCompletoComboBox"
        Me.NomeCompletoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NomeCompletoComboBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Localizar por CPF ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Localiar por Nome ="
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Controls.Add(Me.BtnEditar)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnNovo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(550, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 45)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Image = Global.PrinceSistemas.My.Resources.Resources.icone_alerta
        Me.BtnCancelar.Location = New System.Drawing.Point(395, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(52, 45)
        Me.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar Tudo")
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.Image = Global.PrinceSistemas.My.Resources.Resources.icone_delete
        Me.BtnExcluir.Location = New System.Drawing.Point(453, 0)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(52, 45)
        Me.BtnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnExcluir.TabIndex = 3
        Me.BtnExcluir.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnExcluir, "Excluir Registro Corrente")
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Image = Global.PrinceSistemas.My.Resources.Resources.icone_editar
        Me.BtnEditar.Location = New System.Drawing.Point(279, 0)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(52, 45)
        Me.BtnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnEditar, "Editar Registo Corrente")
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Image = Global.PrinceSistemas.My.Resources.Resources.icone_ok
        Me.BtnSalvar.Location = New System.Drawing.Point(337, 0)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(52, 45)
        Me.BtnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSalvar.TabIndex = 1
        Me.BtnSalvar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnSalvar, "Salvar Registros")
        '
        'BtnNovo
        '
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.Image = Global.PrinceSistemas.My.Resources.Resources.icone_adicionar
        Me.BtnNovo.Location = New System.Drawing.Point(221, 0)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(52, 45)
        Me.BtnNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnNovo.TabIndex = 0
        Me.BtnNovo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnNovo, "Novo Registro")
        '
        'FrmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 471)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.SociosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSocios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sócios"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SociosBindingNavigator.ResumeLayout(False)
        Me.SociosBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBoxOutrosDados.ResumeLayout(False)
        Me.GroupBoxOutrosDados.PerformLayout()
        Me.GroupBoxDadosPessoais.ResumeLayout(False)
        Me.GroupBoxDadosPessoais.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BtnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExcluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSalvar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNovo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents SociosBindingSource As BindingSource
    Friend WithEvents SociosTableAdapter As PrinceDBDataSetTableAdapters.SociosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SociosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents NomeMaeTextBox As TextBox
    Friend WithEvents NomePaiTextBox As TextBox
    Friend WithEvents DatadeNascMaskedTextBox As MaskedTextBox
    Friend WithEvents RGTextBox As TextBox
    Friend WithEvents OrgaoRGTextBox As TextBox
    Friend WithEvents EstadoRGTextBox As TextBox
    Friend WithEvents TituloDeEleitorTextBox As TextBox
    Friend WithEvents SenhaGOVTextBox As TextBox
    Friend WithEvents CNHTextBox As TextBox
    Friend WithEvents CNHExpedicaoTextBox As TextBox
    Friend WithEvents CNHDataExpTextBox As TextBox
    Friend WithEvents CivilComboBox As ComboBox
    Friend WithEvents CEPMaskedTextBox As MaskedTextBox
    Friend WithEvents RUATextBox As TextBox
    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents PaísTextBox As TextBox
    Friend WithEvents Telefone1MaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone2MaskedTextBox As MaskedTextBox
    Friend WithEvents EMailTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxOutrosDados As GroupBox
    Friend WithEvents GroupBoxDadosPessoais As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CPFComboBox As ComboBox
    Friend WithEvents NomeCompletoComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnNovo As PictureBox
    Friend WithEvents BtnSalvar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCancelar As PictureBox
    Friend WithEvents BtnExcluir As PictureBox
    Friend WithEvents BtnEditar As PictureBox
End Class
