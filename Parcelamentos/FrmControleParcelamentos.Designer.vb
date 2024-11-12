<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControleParcelamentos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim DataCriacaoLabel As System.Windows.Forms.Label
        Dim RuaLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim FormaEnvioLabel As System.Windows.Forms.Label
        Dim NomeResponsavelLabel As System.Windows.Forms.Label
        Dim WhatsAppLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SocioResponsavelLabel As System.Windows.Forms.Label
        Dim CPFsocioResponsavelLabel As System.Windows.Forms.Label
        Dim GovSenhaLabel As System.Windows.Forms.Label
        Dim RazaoSocialLabel1 As System.Windows.Forms.Label
        Dim CNPJLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControleParcelamentos))
        Me.ParcelamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParcelamentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CNPJComboBox = New System.Windows.Forms.ComboBox()
        Me.RazaoSocialComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TemDataEnvioCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataLembreteCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataEnvioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnBImportarEmpresa = New System.Windows.Forms.Button()
        Me.BtnCopiarCNPJ = New System.Windows.Forms.Button()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDuplicidade = New System.Windows.Forms.Button()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MEICheckBox = New System.Windows.Forms.CheckBox()
        Me.INSSProcuradoriaCheckBox = New System.Windows.Forms.CheckBox()
        Me.INSSNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.INSSAntigoCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataLembreteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataCriacaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnAbriremail = New System.Windows.Forms.Button()
        Me.BtnAbrirWhatsApp = New System.Windows.Forms.Button()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WhatsAppTextBox = New System.Windows.Forms.TextBox()
        Me.BtnImportaSocio = New System.Windows.Forms.Button()
        Me.NomeResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.FormaEnvioComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GovSenhaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CPFsocioResponsavelMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SocioResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControleParcelamentos = New System.Windows.Forms.TabControl()
        Me.TabPageMEI = New System.Windows.Forms.TabPage()
        Me.TabControlMEI = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.HistoricoEnvioMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSAntigo = New System.Windows.Forms.TabPage()
        Me.TabControlInssAntigo = New System.Windows.Forms.TabControl()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.HistoricoEnvioINSSAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSNovo = New System.Windows.Forms.TabPage()
        Me.TabControlInssNovo = New System.Windows.Forms.TabControl()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.TabPageINSSProcuradoria = New System.Windows.Forms.TabPage()
        Me.TabControlInssProcuradoria = New System.Windows.Forms.TabControl()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.HistoricoEnvioINSSNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.HistoricoEnvioINSSProcRichTextBox = New System.Windows.Forms.RichTextBox()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        DataCriacaoLabel = New System.Windows.Forms.Label()
        RuaLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        FormaEnvioLabel = New System.Windows.Forms.Label()
        NomeResponsavelLabel = New System.Windows.Forms.Label()
        WhatsAppLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SocioResponsavelLabel = New System.Windows.Forms.Label()
        CPFsocioResponsavelLabel = New System.Windows.Forms.Label()
        GovSenhaLabel = New System.Windows.Forms.Label()
        RazaoSocialLabel1 = New System.Windows.Forms.Label()
        CNPJLabel1 = New System.Windows.Forms.Label()
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParcelamentosBindingNavigator.SuspendLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControleParcelamentos.SuspendLayout()
        Me.TabPageMEI.SuspendLayout()
        Me.TabControlMEI.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPageINSSAntigo.SuspendLayout()
        Me.TabControlInssAntigo.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPageINSSNovo.SuspendLayout()
        Me.TabControlInssNovo.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPageINSSProcuradoria.SuspendLayout()
        Me.TabControlInssProcuradoria.SuspendLayout()
        Me.TabPage16.SuspendLayout()
        Me.GroupBoxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(6, 16)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(101, 18)
        RazaoSocialLabel.TabIndex = 0
        RazaoSocialLabel.Text = "Razao Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(55, 46)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(52, 18)
        CNPJLabel.TabIndex = 2
        CNPJLabel.Text = "CNPJ:"
        '
        'DataCriacaoLabel
        '
        DataCriacaoLabel.AutoSize = True
        DataCriacaoLabel.Location = New System.Drawing.Point(16, 114)
        DataCriacaoLabel.Name = "DataCriacaoLabel"
        DataCriacaoLabel.Size = New System.Drawing.Size(99, 18)
        DataCriacaoLabel.TabIndex = 6
        DataCriacaoLabel.Text = "Data Criacao:"
        '
        'RuaLabel
        '
        RuaLabel.AutoSize = True
        RuaLabel.Location = New System.Drawing.Point(80, 33)
        RuaLabel.Name = "RuaLabel"
        RuaLabel.Size = New System.Drawing.Size(39, 18)
        RuaLabel.TabIndex = 0
        RuaLabel.Text = "Rua:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(53, 63)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(66, 18)
        NumeroLabel.TabIndex = 2
        NumeroLabel.Text = "Numero:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(13, 93)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(106, 18)
        ComplementoLabel.TabIndex = 4
        ComplementoLabel.Text = "Complemento:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(67, 123)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(52, 18)
        BairroLabel.TabIndex = 6
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(61, 153)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(58, 18)
        CidadeLabel.TabIndex = 8
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(60, 183)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(59, 18)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado:"
        '
        'FormaEnvioLabel
        '
        FormaEnvioLabel.AutoSize = True
        FormaEnvioLabel.Location = New System.Drawing.Point(16, 27)
        FormaEnvioLabel.Name = "FormaEnvioLabel"
        FormaEnvioLabel.Size = New System.Drawing.Size(117, 18)
        FormaEnvioLabel.TabIndex = 0
        FormaEnvioLabel.Text = "Forma de Envio:"
        '
        'NomeResponsavelLabel
        '
        NomeResponsavelLabel.AutoSize = True
        NomeResponsavelLabel.Location = New System.Drawing.Point(16, 99)
        NomeResponsavelLabel.Name = "NomeResponsavelLabel"
        NomeResponsavelLabel.Size = New System.Drawing.Size(235, 18)
        NomeResponsavelLabel.TabIndex = 2
        NomeResponsavelLabel.Text = "Nome do Responsavel pelo envio:"
        '
        'WhatsAppLabel
        '
        WhatsAppLabel.AutoSize = True
        WhatsAppLabel.Location = New System.Drawing.Point(167, 129)
        WhatsAppLabel.Name = "WhatsAppLabel"
        WhatsAppLabel.Size = New System.Drawing.Size(84, 18)
        WhatsAppLabel.TabIndex = 71
        WhatsAppLabel.Text = "Whats App:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(202, 159)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 18)
        EmailLabel.TabIndex = 72
        EmailLabel.Text = "e-Mail:"
        '
        'SocioResponsavelLabel
        '
        SocioResponsavelLabel.AutoSize = True
        SocioResponsavelLabel.Location = New System.Drawing.Point(20, 33)
        SocioResponsavelLabel.Name = "SocioResponsavelLabel"
        SocioResponsavelLabel.Size = New System.Drawing.Size(141, 18)
        SocioResponsavelLabel.TabIndex = 0
        SocioResponsavelLabel.Text = "Socio Responsavel:"
        '
        'CPFsocioResponsavelLabel
        '
        CPFsocioResponsavelLabel.AutoSize = True
        CPFsocioResponsavelLabel.Location = New System.Drawing.Point(119, 63)
        CPFsocioResponsavelLabel.Name = "CPFsocioResponsavelLabel"
        CPFsocioResponsavelLabel.Size = New System.Drawing.Size(42, 18)
        CPFsocioResponsavelLabel.TabIndex = 2
        CPFsocioResponsavelLabel.Text = "CPF:"
        '
        'GovSenhaLabel
        '
        GovSenhaLabel.AutoSize = True
        GovSenhaLabel.Location = New System.Drawing.Point(50, 93)
        GovSenhaLabel.Name = "GovSenhaLabel"
        GovSenhaLabel.Size = New System.Drawing.Size(111, 18)
        GovSenhaLabel.TabIndex = 4
        GovSenhaLabel.Text = "Senha Gov.BR:"
        '
        'RazaoSocialLabel1
        '
        RazaoSocialLabel1.AutoSize = True
        RazaoSocialLabel1.Location = New System.Drawing.Point(14, 27)
        RazaoSocialLabel1.Name = "RazaoSocialLabel1"
        RazaoSocialLabel1.Size = New System.Drawing.Size(101, 18)
        RazaoSocialLabel1.TabIndex = 0
        RazaoSocialLabel1.Text = "Razao Social:"
        '
        'CNPJLabel1
        '
        CNPJLabel1.AutoSize = True
        CNPJLabel1.Location = New System.Drawing.Point(560, 27)
        CNPJLabel1.Name = "CNPJLabel1"
        CNPJLabel1.Size = New System.Drawing.Size(52, 18)
        CNPJLabel1.TabIndex = 2
        CNPJLabel1.Text = "CNPJ:"
        '
        'ParcelamentosBindingNavigator
        '
        Me.ParcelamentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ParcelamentosBindingNavigator.BindingSource = Me.ParcelamentosBindingSource
        Me.ParcelamentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParcelamentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ParcelamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ParcelamentosBindingNavigatorSaveItem})
        Me.ParcelamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParcelamentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParcelamentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParcelamentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParcelamentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParcelamentosBindingNavigator.Name = "ParcelamentosBindingNavigator"
        Me.ParcelamentosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ParcelamentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParcelamentosBindingNavigator.Size = New System.Drawing.Size(986, 25)
        Me.ParcelamentosBindingNavigator.TabIndex = 1
        Me.ParcelamentosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'ParcelamentosBindingSource
        '
        Me.ParcelamentosBindingSource.DataMember = "Parcelamentos"
        Me.ParcelamentosBindingSource.DataSource = Me.PrinceDBDataSet
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
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
        'ParcelamentosBindingNavigatorSaveItem
        '
        Me.ParcelamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ParcelamentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParcelamentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParcelamentosBindingNavigatorSaveItem.Name = "ParcelamentosBindingNavigatorSaveItem"
        Me.ParcelamentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ParcelamentosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.67816!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32184!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenu, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.519966!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.53258!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.94746!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(986, 691)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CNPJLabel1)
        Me.GroupBox1.Controls.Add(Me.CNPJComboBox)
        Me.GroupBox1.Controls.Add(RazaoSocialLabel1)
        Me.GroupBox1.Controls.Add(Me.RazaoSocialComboBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(825, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'CNPJComboBox
        '
        Me.CNPJComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CNPJ", True))
        Me.CNPJComboBox.FormattingEnabled = True
        Me.CNPJComboBox.Location = New System.Drawing.Point(618, 24)
        Me.CNPJComboBox.Name = "CNPJComboBox"
        Me.CNPJComboBox.Size = New System.Drawing.Size(180, 26)
        Me.CNPJComboBox.TabIndex = 3
        '
        'RazaoSocialComboBox
        '
        Me.RazaoSocialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialComboBox.FormattingEnabled = True
        Me.RazaoSocialComboBox.Location = New System.Drawing.Point(121, 24)
        Me.RazaoSocialComboBox.Name = "RazaoSocialComboBox"
        Me.RazaoSocialComboBox.Size = New System.Drawing.Size(422, 26)
        Me.RazaoSocialComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.TabControlPrincipal)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 65)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(825, 286)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPage1)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage2)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage3)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage4)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipal.Location = New System.Drawing.Point(4, 21)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(817, 261)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.TemDataEnvioCheckBox)
        Me.TabPage1.Controls.Add(Me.TemDataLembreteCheckBox)
        Me.TabPage1.Controls.Add(Me.DataEnvioDateTimePicker)
        Me.TabPage1.Controls.Add(Me.BtnBImportarEmpresa)
        Me.TabPage1.Controls.Add(RazaoSocialLabel)
        Me.TabPage1.Controls.Add(Me.BtnCopiarCNPJ)
        Me.TabPage1.Controls.Add(Me.RazaoSocialTextBox)
        Me.TabPage1.Controls.Add(Me.BtnDuplicidade)
        Me.TabPage1.Controls.Add(Me.CNPJMaskedTextBox)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(CNPJLabel)
        Me.TabPage1.Controls.Add(DataCriacaoLabel)
        Me.TabPage1.Controls.Add(Me.DataLembreteDateTimePicker)
        Me.TabPage1.Controls.Add(Me.DataCriacaoDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(809, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Geral"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TemDataEnvioCheckBox
        '
        Me.TemDataEnvioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEnvio", True))
        Me.TemDataEnvioCheckBox.Location = New System.Drawing.Point(6, 183)
        Me.TemDataEnvioCheckBox.Name = "TemDataEnvioCheckBox"
        Me.TemDataEnvioCheckBox.Size = New System.Drawing.Size(214, 24)
        Me.TemDataEnvioCheckBox.TabIndex = 75
        Me.TemDataEnvioCheckBox.Text = "Data Mensal de Finalização:"
        Me.TemDataEnvioCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataLembreteCheckBox
        '
        Me.TemDataLembreteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataLembrete", True))
        Me.TemDataLembreteCheckBox.Location = New System.Drawing.Point(6, 150)
        Me.TemDataLembreteCheckBox.Name = "TemDataLembreteCheckBox"
        Me.TemDataLembreteCheckBox.Size = New System.Drawing.Size(130, 24)
        Me.TemDataLembreteCheckBox.TabIndex = 74
        Me.TemDataLembreteCheckBox.Text = "Data Lembrete:"
        Me.TemDataLembreteCheckBox.UseVisualStyleBackColor = True
        '
        'DataEnvioDateTimePicker
        '
        Me.DataEnvioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataEnvio", True))
        Me.DataEnvioDateTimePicker.Location = New System.Drawing.Point(226, 183)
        Me.DataEnvioDateTimePicker.Name = "DataEnvioDateTimePicker"
        Me.DataEnvioDateTimePicker.Size = New System.Drawing.Size(301, 24)
        Me.DataEnvioDateTimePicker.TabIndex = 73
        '
        'BtnBImportarEmpresa
        '
        Me.BtnBImportarEmpresa.BackColor = System.Drawing.Color.Azure
        Me.BtnBImportarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnBImportarEmpresa.FlatAppearance.BorderSize = 2
        Me.BtnBImportarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBImportarEmpresa.Location = New System.Drawing.Point(569, 11)
        Me.BtnBImportarEmpresa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBImportarEmpresa.Name = "BtnBImportarEmpresa"
        Me.BtnBImportarEmpresa.Size = New System.Drawing.Size(146, 29)
        Me.BtnBImportarEmpresa.TabIndex = 72
        Me.BtnBImportarEmpresa.Text = "Importar Empresa"
        Me.BtnBImportarEmpresa.UseVisualStyleBackColor = False
        '
        'BtnCopiarCNPJ
        '
        Me.BtnCopiarCNPJ.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiarCNPJ.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnCopiarCNPJ.FlatAppearance.BorderSize = 2
        Me.BtnCopiarCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiarCNPJ.Location = New System.Drawing.Point(266, 41)
        Me.BtnCopiarCNPJ.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiarCNPJ.Name = "BtnCopiarCNPJ"
        Me.BtnCopiarCNPJ.Size = New System.Drawing.Size(65, 29)
        Me.BtnCopiarCNPJ.TabIndex = 71
        Me.BtnCopiarCNPJ.Text = "Copiar"
        Me.BtnCopiarCNPJ.UseVisualStyleBackColor = False
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(113, 13)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(449, 24)
        Me.RazaoSocialTextBox.TabIndex = 1
        '
        'BtnDuplicidade
        '
        Me.BtnDuplicidade.BackColor = System.Drawing.Color.Azure
        Me.BtnDuplicidade.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnDuplicidade.FlatAppearance.BorderSize = 2
        Me.BtnDuplicidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDuplicidade.Location = New System.Drawing.Point(339, 41)
        Me.BtnDuplicidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnDuplicidade.Name = "BtnDuplicidade"
        Me.BtnDuplicidade.Size = New System.Drawing.Size(74, 29)
        Me.BtnDuplicidade.TabIndex = 70
        Me.BtnDuplicidade.Text = "Verificar"
        Me.BtnDuplicidade.UseVisualStyleBackColor = False
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(113, 43)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(146, 24)
        Me.CNPJMaskedTextBox.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MEICheckBox)
        Me.GroupBox4.Controls.Add(Me.INSSProcuradoriaCheckBox)
        Me.GroupBox4.Controls.Add(Me.INSSNovoCheckBox)
        Me.GroupBox4.Controls.Add(Me.INSSAntigoCheckBox)
        Me.GroupBox4.Location = New System.Drawing.Point(569, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(188, 154)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parcelamentos ATIVOS"
        '
        'MEICheckBox
        '
        Me.MEICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "MEI", True))
        Me.MEICheckBox.Location = New System.Drawing.Point(6, 23)
        Me.MEICheckBox.Name = "MEICheckBox"
        Me.MEICheckBox.Size = New System.Drawing.Size(56, 24)
        Me.MEICheckBox.TabIndex = 12
        Me.MEICheckBox.Text = "MEI"
        Me.MEICheckBox.UseVisualStyleBackColor = True
        '
        'INSSProcuradoriaCheckBox
        '
        Me.INSSProcuradoriaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "INSSProcuradoria", True))
        Me.INSSProcuradoriaCheckBox.Location = New System.Drawing.Point(6, 113)
        Me.INSSProcuradoriaCheckBox.Name = "INSSProcuradoriaCheckBox"
        Me.INSSProcuradoriaCheckBox.Size = New System.Drawing.Size(160, 24)
        Me.INSSProcuradoriaCheckBox.TabIndex = 11
        Me.INSSProcuradoriaCheckBox.Text = "INSS - Procuradoria"
        Me.INSSProcuradoriaCheckBox.UseVisualStyleBackColor = True
        '
        'INSSNovoCheckBox
        '
        Me.INSSNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "INSSNovo", True))
        Me.INSSNovoCheckBox.Location = New System.Drawing.Point(6, 83)
        Me.INSSNovoCheckBox.Name = "INSSNovoCheckBox"
        Me.INSSNovoCheckBox.Size = New System.Drawing.Size(123, 24)
        Me.INSSNovoCheckBox.TabIndex = 10
        Me.INSSNovoCheckBox.Text = "INSS - Novo"
        Me.INSSNovoCheckBox.UseVisualStyleBackColor = True
        '
        'INSSAntigoCheckBox
        '
        Me.INSSAntigoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "INSSAntigo", True))
        Me.INSSAntigoCheckBox.Location = New System.Drawing.Point(6, 53)
        Me.INSSAntigoCheckBox.Name = "INSSAntigoCheckBox"
        Me.INSSAntigoCheckBox.Size = New System.Drawing.Size(123, 24)
        Me.INSSAntigoCheckBox.TabIndex = 9
        Me.INSSAntigoCheckBox.Text = "INSS - Antigo"
        Me.INSSAntigoCheckBox.UseVisualStyleBackColor = True
        '
        'DataLembreteDateTimePicker
        '
        Me.DataLembreteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataLembrete", True))
        Me.DataLembreteDateTimePicker.Location = New System.Drawing.Point(142, 150)
        Me.DataLembreteDateTimePicker.Name = "DataLembreteDateTimePicker"
        Me.DataLembreteDateTimePicker.Size = New System.Drawing.Size(319, 24)
        Me.DataLembreteDateTimePicker.TabIndex = 5
        '
        'DataCriacaoDateTimePicker
        '
        Me.DataCriacaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataCriacao", True))
        Me.DataCriacaoDateTimePicker.Location = New System.Drawing.Point(121, 110)
        Me.DataCriacaoDateTimePicker.Name = "DataCriacaoDateTimePicker"
        Me.DataCriacaoDateTimePicker.Size = New System.Drawing.Size(319, 24)
        Me.DataCriacaoDateTimePicker.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(EstadoLabel)
        Me.TabPage2.Controls.Add(Me.EstadoTextBox)
        Me.TabPage2.Controls.Add(CidadeLabel)
        Me.TabPage2.Controls.Add(Me.CidadeTextBox)
        Me.TabPage2.Controls.Add(BairroLabel)
        Me.TabPage2.Controls.Add(Me.BairroTextBox)
        Me.TabPage2.Controls.Add(ComplementoLabel)
        Me.TabPage2.Controls.Add(Me.ComplementoTextBox)
        Me.TabPage2.Controls.Add(NumeroLabel)
        Me.TabPage2.Controls.Add(Me.NumeroTextBox)
        Me.TabPage2.Controls.Add(RuaLabel)
        Me.TabPage2.Controls.Add(Me.RuaTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(809, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Endereço"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(125, 180)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.EstadoTextBox.TabIndex = 11
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(125, 150)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(247, 24)
        Me.CidadeTextBox.TabIndex = 9
        '
        'BairroTextBox
        '
        Me.BairroTextBox.Location = New System.Drawing.Point(125, 120)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(467, 24)
        Me.BairroTextBox.TabIndex = 7
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(125, 90)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(467, 24)
        Me.ComplementoTextBox.TabIndex = 5
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(125, 60)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(149, 24)
        Me.NumeroTextBox.TabIndex = 3
        '
        'RuaTextBox
        '
        Me.RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Rua", True))
        Me.RuaTextBox.Location = New System.Drawing.Point(125, 30)
        Me.RuaTextBox.Name = "RuaTextBox"
        Me.RuaTextBox.Size = New System.Drawing.Size(467, 24)
        Me.RuaTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnAbriremail)
        Me.TabPage3.Controls.Add(Me.BtnAbrirWhatsApp)
        Me.TabPage3.Controls.Add(EmailLabel)
        Me.TabPage3.Controls.Add(Me.EmailTextBox)
        Me.TabPage3.Controls.Add(WhatsAppLabel)
        Me.TabPage3.Controls.Add(Me.WhatsAppTextBox)
        Me.TabPage3.Controls.Add(Me.BtnImportaSocio)
        Me.TabPage3.Controls.Add(NomeResponsavelLabel)
        Me.TabPage3.Controls.Add(Me.NomeResponsavelTextBox)
        Me.TabPage3.Controls.Add(FormaEnvioLabel)
        Me.TabPage3.Controls.Add(Me.FormaEnvioComboBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(809, 234)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Forma de Envio"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnAbriremail
        '
        Me.BtnAbriremail.BackColor = System.Drawing.Color.Azure
        Me.BtnAbriremail.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAbriremail.FlatAppearance.BorderSize = 2
        Me.BtnAbriremail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbriremail.Location = New System.Drawing.Point(653, 154)
        Me.BtnAbriremail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAbriremail.Name = "BtnAbriremail"
        Me.BtnAbriremail.Size = New System.Drawing.Size(135, 29)
        Me.BtnAbriremail.TabIndex = 75
        Me.BtnAbriremail.Text = "Abrir e-Mail"
        Me.BtnAbriremail.UseVisualStyleBackColor = False
        '
        'BtnAbrirWhatsApp
        '
        Me.BtnAbrirWhatsApp.BackColor = System.Drawing.Color.Azure
        Me.BtnAbrirWhatsApp.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAbrirWhatsApp.FlatAppearance.BorderSize = 2
        Me.BtnAbrirWhatsApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrirWhatsApp.Location = New System.Drawing.Point(653, 124)
        Me.BtnAbrirWhatsApp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAbrirWhatsApp.Name = "BtnAbrirWhatsApp"
        Me.BtnAbrirWhatsApp.Size = New System.Drawing.Size(135, 29)
        Me.BtnAbrirWhatsApp.TabIndex = 74
        Me.BtnAbrirWhatsApp.Text = "Abrir WhatsApp"
        Me.BtnAbrirWhatsApp.UseVisualStyleBackColor = False
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(257, 156)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(389, 24)
        Me.EmailTextBox.TabIndex = 73
        '
        'WhatsAppTextBox
        '
        Me.WhatsAppTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "WhatsApp", True))
        Me.WhatsAppTextBox.Location = New System.Drawing.Point(257, 126)
        Me.WhatsAppTextBox.Name = "WhatsAppTextBox"
        Me.WhatsAppTextBox.Size = New System.Drawing.Size(389, 24)
        Me.WhatsAppTextBox.TabIndex = 72
        '
        'BtnImportaSocio
        '
        Me.BtnImportaSocio.BackColor = System.Drawing.Color.Azure
        Me.BtnImportaSocio.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnImportaSocio.FlatAppearance.BorderSize = 2
        Me.BtnImportaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportaSocio.Location = New System.Drawing.Point(653, 94)
        Me.BtnImportaSocio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnImportaSocio.Name = "BtnImportaSocio"
        Me.BtnImportaSocio.Size = New System.Drawing.Size(135, 29)
        Me.BtnImportaSocio.TabIndex = 71
        Me.BtnImportaSocio.Text = "Importar Sócio"
        Me.BtnImportaSocio.UseVisualStyleBackColor = False
        '
        'NomeResponsavelTextBox
        '
        Me.NomeResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "NomeResponsavel", True))
        Me.NomeResponsavelTextBox.Location = New System.Drawing.Point(257, 96)
        Me.NomeResponsavelTextBox.Name = "NomeResponsavelTextBox"
        Me.NomeResponsavelTextBox.Size = New System.Drawing.Size(389, 24)
        Me.NomeResponsavelTextBox.TabIndex = 3
        '
        'FormaEnvioComboBox
        '
        Me.FormaEnvioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FormaEnvio", True))
        Me.FormaEnvioComboBox.FormattingEnabled = True
        Me.FormaEnvioComboBox.Items.AddRange(New Object() {"Whatsapp", "e-Mail", "Presencial"})
        Me.FormaEnvioComboBox.Location = New System.Drawing.Point(139, 24)
        Me.FormaEnvioComboBox.Name = "FormaEnvioComboBox"
        Me.FormaEnvioComboBox.Size = New System.Drawing.Size(121, 26)
        Me.FormaEnvioComboBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(GovSenhaLabel)
        Me.TabPage4.Controls.Add(Me.GovSenhaMaskedTextBox)
        Me.TabPage4.Controls.Add(CPFsocioResponsavelLabel)
        Me.TabPage4.Controls.Add(Me.CPFsocioResponsavelMaskedTextBox)
        Me.TabPage4.Controls.Add(SocioResponsavelLabel)
        Me.TabPage4.Controls.Add(Me.SocioResponsavelTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(809, 234)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sócio/Responsável"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(570, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 29)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Adicionar Sócio"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GovSenhaMaskedTextBox
        '
        Me.GovSenhaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "GovSenha", True))
        Me.GovSenhaMaskedTextBox.Location = New System.Drawing.Point(167, 90)
        Me.GovSenhaMaskedTextBox.Name = "GovSenhaMaskedTextBox"
        Me.GovSenhaMaskedTextBox.Size = New System.Drawing.Size(251, 24)
        Me.GovSenhaMaskedTextBox.TabIndex = 5
        '
        'CPFsocioResponsavelMaskedTextBox
        '
        Me.CPFsocioResponsavelMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CPFsocioResponsavel", True))
        Me.CPFsocioResponsavelMaskedTextBox.Location = New System.Drawing.Point(167, 60)
        Me.CPFsocioResponsavelMaskedTextBox.Mask = "000.000.000-00"
        Me.CPFsocioResponsavelMaskedTextBox.Name = "CPFsocioResponsavelMaskedTextBox"
        Me.CPFsocioResponsavelMaskedTextBox.Size = New System.Drawing.Size(122, 24)
        Me.CPFsocioResponsavelMaskedTextBox.TabIndex = 3
        '
        'SocioResponsavelTextBox
        '
        Me.SocioResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "SocioResponsavel", True))
        Me.SocioResponsavelTextBox.Location = New System.Drawing.Point(167, 30)
        Me.SocioResponsavelTextBox.Name = "SocioResponsavelTextBox"
        Me.SocioResponsavelTextBox.Size = New System.Drawing.Size(396, 24)
        Me.SocioResponsavelTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.TabControleParcelamentos)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 351)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(825, 340)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'TabControleParcelamentos
        '
        Me.TabControleParcelamentos.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageMEI)
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageINSSAntigo)
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageINSSNovo)
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageINSSProcuradoria)
        Me.TabControleParcelamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControleParcelamentos.Location = New System.Drawing.Point(4, 21)
        Me.TabControleParcelamentos.Name = "TabControleParcelamentos"
        Me.TabControleParcelamentos.SelectedIndex = 0
        Me.TabControleParcelamentos.Size = New System.Drawing.Size(817, 315)
        Me.TabControleParcelamentos.TabIndex = 0
        '
        'TabPageMEI
        '
        Me.TabPageMEI.Controls.Add(Me.TabControlMEI)
        Me.TabPageMEI.Location = New System.Drawing.Point(4, 30)
        Me.TabPageMEI.Name = "TabPageMEI"
        Me.TabPageMEI.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMEI.Size = New System.Drawing.Size(809, 281)
        Me.TabPageMEI.TabIndex = 0
        Me.TabPageMEI.Text = "MEI"
        Me.TabPageMEI.UseVisualStyleBackColor = True
        '
        'TabControlMEI
        '
        Me.TabControlMEI.Controls.Add(Me.TabPage9)
        Me.TabControlMEI.Controls.Add(Me.TabPage10)
        Me.TabControlMEI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMEI.Location = New System.Drawing.Point(3, 3)
        Me.TabControlMEI.Name = "TabControlMEI"
        Me.TabControlMEI.SelectedIndex = 0
        Me.TabControlMEI.Size = New System.Drawing.Size(803, 275)
        Me.TabControlMEI.TabIndex = 0
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 27)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(795, 244)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Geral"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.HistoricoEnvioMEIRichTextBox)
        Me.TabPage10.Location = New System.Drawing.Point(4, 27)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(795, 244)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Histórico"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'HistoricoEnvioMEIRichTextBox
        '
        Me.HistoricoEnvioMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioMEI", True))
        Me.HistoricoEnvioMEIRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioMEIRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioMEIRichTextBox.Name = "HistoricoEnvioMEIRichTextBox"
        Me.HistoricoEnvioMEIRichTextBox.Size = New System.Drawing.Size(789, 238)
        Me.HistoricoEnvioMEIRichTextBox.TabIndex = 1
        Me.HistoricoEnvioMEIRichTextBox.Text = ""
        '
        'TabPageINSSAntigo
        '
        Me.TabPageINSSAntigo.Controls.Add(Me.TabControlInssAntigo)
        Me.TabPageINSSAntigo.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSAntigo.Name = "TabPageINSSAntigo"
        Me.TabPageINSSAntigo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSAntigo.Size = New System.Drawing.Size(809, 281)
        Me.TabPageINSSAntigo.TabIndex = 1
        Me.TabPageINSSAntigo.Text = "INSS - Antigo"
        Me.TabPageINSSAntigo.UseVisualStyleBackColor = True
        '
        'TabControlInssAntigo
        '
        Me.TabControlInssAntigo.Controls.Add(Me.TabPage11)
        Me.TabControlInssAntigo.Controls.Add(Me.TabPage12)
        Me.TabControlInssAntigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlInssAntigo.Location = New System.Drawing.Point(3, 3)
        Me.TabControlInssAntigo.Name = "TabControlInssAntigo"
        Me.TabControlInssAntigo.SelectedIndex = 0
        Me.TabControlInssAntigo.Size = New System.Drawing.Size(803, 275)
        Me.TabControlInssAntigo.TabIndex = 1
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 27)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(795, 244)
        Me.TabPage11.TabIndex = 0
        Me.TabPage11.Text = "Geral"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.HistoricoEnvioINSSAntigoRichTextBox)
        Me.TabPage12.Location = New System.Drawing.Point(4, 27)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(795, 244)
        Me.TabPage12.TabIndex = 1
        Me.TabPage12.Text = "Histórico"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'HistoricoEnvioINSSAntigoRichTextBox
        '
        Me.HistoricoEnvioINSSAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSAntigo", True))
        Me.HistoricoEnvioINSSAntigoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioINSSAntigoRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioINSSAntigoRichTextBox.Name = "HistoricoEnvioINSSAntigoRichTextBox"
        Me.HistoricoEnvioINSSAntigoRichTextBox.Size = New System.Drawing.Size(789, 238)
        Me.HistoricoEnvioINSSAntigoRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSAntigoRichTextBox.Text = ""
        '
        'TabPageINSSNovo
        '
        Me.TabPageINSSNovo.Controls.Add(Me.TabControlInssNovo)
        Me.TabPageINSSNovo.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSNovo.Name = "TabPageINSSNovo"
        Me.TabPageINSSNovo.Size = New System.Drawing.Size(809, 281)
        Me.TabPageINSSNovo.TabIndex = 2
        Me.TabPageINSSNovo.Text = "INSS - Novo"
        Me.TabPageINSSNovo.UseVisualStyleBackColor = True
        '
        'TabControlInssNovo
        '
        Me.TabControlInssNovo.Controls.Add(Me.TabPage13)
        Me.TabControlInssNovo.Controls.Add(Me.TabPage14)
        Me.TabControlInssNovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlInssNovo.Location = New System.Drawing.Point(0, 0)
        Me.TabControlInssNovo.Name = "TabControlInssNovo"
        Me.TabControlInssNovo.SelectedIndex = 0
        Me.TabControlInssNovo.Size = New System.Drawing.Size(809, 281)
        Me.TabControlInssNovo.TabIndex = 1
        '
        'TabPage13
        '
        Me.TabPage13.Location = New System.Drawing.Point(4, 27)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(801, 250)
        Me.TabPage13.TabIndex = 0
        Me.TabPage13.Text = "Geral"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'TabPage14
        '
        Me.TabPage14.AutoScroll = True
        Me.TabPage14.Controls.Add(Me.HistoricoEnvioINSSNovoRichTextBox)
        Me.TabPage14.Location = New System.Drawing.Point(4, 27)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(801, 250)
        Me.TabPage14.TabIndex = 1
        Me.TabPage14.Text = "Histórico"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'TabPageINSSProcuradoria
        '
        Me.TabPageINSSProcuradoria.Controls.Add(Me.TabControlInssProcuradoria)
        Me.TabPageINSSProcuradoria.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSProcuradoria.Name = "TabPageINSSProcuradoria"
        Me.TabPageINSSProcuradoria.Size = New System.Drawing.Size(809, 281)
        Me.TabPageINSSProcuradoria.TabIndex = 3
        Me.TabPageINSSProcuradoria.Text = "INSS - Procuradoria"
        Me.TabPageINSSProcuradoria.UseVisualStyleBackColor = True
        '
        'TabControlInssProcuradoria
        '
        Me.TabControlInssProcuradoria.Controls.Add(Me.TabPage15)
        Me.TabControlInssProcuradoria.Controls.Add(Me.TabPage16)
        Me.TabControlInssProcuradoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlInssProcuradoria.Location = New System.Drawing.Point(0, 0)
        Me.TabControlInssProcuradoria.Name = "TabControlInssProcuradoria"
        Me.TabControlInssProcuradoria.SelectedIndex = 0
        Me.TabControlInssProcuradoria.Size = New System.Drawing.Size(809, 281)
        Me.TabControlInssProcuradoria.TabIndex = 1
        '
        'TabPage15
        '
        Me.TabPage15.Location = New System.Drawing.Point(4, 27)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(801, 250)
        Me.TabPage15.TabIndex = 0
        Me.TabPage15.Text = "Geral"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'TabPage16
        '
        Me.TabPage16.Controls.Add(Me.HistoricoEnvioINSSProcRichTextBox)
        Me.TabPage16.Location = New System.Drawing.Point(4, 27)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage16.Size = New System.Drawing.Size(801, 250)
        Me.TabPage16.TabIndex = 1
        Me.TabPage16.Text = "Histórico"
        Me.TabPage16.UseVisualStyleBackColor = True
        '
        'GroupBoxMenu
        '
        Me.GroupBoxMenu.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMenu.Controls.Add(Me.BtnFechar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnNovo)
        Me.GroupBoxMenu.Controls.Add(Me.BtnEditar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnSalvar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnExcluir)
        Me.GroupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxMenu.Location = New System.Drawing.Point(831, 69)
        Me.GroupBoxMenu.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBoxMenu.Size = New System.Drawing.Size(149, 255)
        Me.GroupBoxMenu.TabIndex = 58
        Me.GroupBoxMenu.TabStop = False
        Me.GroupBoxMenu.Text = "MENU"
        '
        'BtnFechar
        '
        Me.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(12, 206)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(132, 37)
        Me.BtnFechar.TabIndex = 10
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNovo.FlatAppearance.BorderSize = 2
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Black
        Me.BtnNovo.Location = New System.Drawing.Point(12, 30)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(132, 37)
        Me.BtnNovo.TabIndex = 5
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(12, 72)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(132, 37)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(12, 114)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(132, 37)
        Me.BtnSalvar.TabIndex = 7
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnExcluir.FlatAppearance.BorderSize = 2
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Black
        Me.BtnExcluir.Location = New System.Drawing.Point(12, 159)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(132, 37)
        Me.BtnExcluir.TabIndex = 9
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'ParcelamentosTableAdapter
        '
        Me.ParcelamentosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CNAESubclasses23TableAdapter = Nothing
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
        Me.TableAdapterManager.ParcelamentosAvisoTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosTableAdapter = Me.ParcelamentosTableAdapter
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HistoricoEnvioINSSNovoRichTextBox
        '
        Me.HistoricoEnvioINSSNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSNovo", True))
        Me.HistoricoEnvioINSSNovoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioINSSNovoRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioINSSNovoRichTextBox.Name = "HistoricoEnvioINSSNovoRichTextBox"
        Me.HistoricoEnvioINSSNovoRichTextBox.Size = New System.Drawing.Size(795, 244)
        Me.HistoricoEnvioINSSNovoRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSNovoRichTextBox.Text = ""
        '
        'HistoricoEnvioINSSProcRichTextBox
        '
        Me.HistoricoEnvioINSSProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSProc", True))
        Me.HistoricoEnvioINSSProcRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioINSSProcRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioINSSProcRichTextBox.Name = "HistoricoEnvioINSSProcRichTextBox"
        Me.HistoricoEnvioINSSProcRichTextBox.Size = New System.Drawing.Size(795, 244)
        Me.HistoricoEnvioINSSProcRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSProcRichTextBox.Text = ""
        '
        'FrmControleParcelamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(986, 716)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ParcelamentosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmControleParcelamentos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle dos Parcelamentos"
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParcelamentosBindingNavigator.ResumeLayout(False)
        Me.ParcelamentosBindingNavigator.PerformLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControleParcelamentos.ResumeLayout(False)
        Me.TabPageMEI.ResumeLayout(False)
        Me.TabControlMEI.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPageINSSAntigo.ResumeLayout(False)
        Me.TabControlInssAntigo.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPageINSSNovo.ResumeLayout(False)
        Me.TabControlInssNovo.ResumeLayout(False)
        Me.TabPage14.ResumeLayout(False)
        Me.TabPageINSSProcuradoria.ResumeLayout(False)
        Me.TabControlInssProcuradoria.ResumeLayout(False)
        Me.TabPage16.ResumeLayout(False)
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents ParcelamentosTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParcelamentosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ParcelamentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBoxMenu As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents DataCriacaoDateTimePicker As DateTimePicker
    Friend WithEvents DataLembreteDateTimePicker As DateTimePicker
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MEICheckBox As CheckBox
    Friend WithEvents INSSProcuradoriaCheckBox As CheckBox
    Friend WithEvents INSSNovoCheckBox As CheckBox
    Friend WithEvents INSSAntigoCheckBox As CheckBox
    Friend WithEvents BtnBImportarEmpresa As Button
    Friend WithEvents BtnCopiarCNPJ As Button
    Friend WithEvents BtnDuplicidade As Button
    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents RuaTextBox As TextBox
    Friend WithEvents FormaEnvioComboBox As ComboBox
    Friend WithEvents NomeResponsavelTextBox As TextBox
    Friend WithEvents BtnImportaSocio As Button
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents WhatsAppTextBox As TextBox
    Friend WithEvents BtnAbriremail As Button
    Friend WithEvents BtnAbrirWhatsApp As Button
    Friend WithEvents SocioResponsavelTextBox As TextBox
    Friend WithEvents GovSenhaMaskedTextBox As MaskedTextBox
    Friend WithEvents CPFsocioResponsavelMaskedTextBox As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RazaoSocialComboBox As ComboBox
    Friend WithEvents CNPJComboBox As ComboBox
    Friend WithEvents DataEnvioDateTimePicker As DateTimePicker
    Friend WithEvents TabControleParcelamentos As TabControl
    Friend WithEvents TabPageMEI As TabPage
    Friend WithEvents TabPageINSSAntigo As TabPage
    Friend WithEvents TemDataEnvioCheckBox As CheckBox
    Friend WithEvents TemDataLembreteCheckBox As CheckBox
    Friend WithEvents TabPageINSSNovo As TabPage
    Friend WithEvents TabPageINSSProcuradoria As TabPage
    Friend WithEvents TabControlMEI As TabControl
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabControlInssAntigo As TabControl
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabControlInssNovo As TabControl
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents TabControlInssProcuradoria As TabControl
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents TabPage16 As TabPage
    Friend WithEvents HistoricoEnvioMEIRichTextBox As RichTextBox
    Friend WithEvents HistoricoEnvioINSSAntigoRichTextBox As RichTextBox
    Friend WithEvents HistoricoEnvioINSSNovoRichTextBox As RichTextBox
    Friend WithEvents HistoricoEnvioINSSProcRichTextBox As RichTextBox
End Class
