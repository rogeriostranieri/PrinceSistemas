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
        Dim MeiProtocoloLabel As System.Windows.Forms.Label
        Dim INSSAntigoProtLabel As System.Windows.Forms.Label
        Dim INSSNovoProtLabel As System.Windows.Forms.Label
        Dim INSSProcProtLabel As System.Windows.Forms.Label
        Dim QtoParcelasMEILabel As System.Windows.Forms.Label
        Dim ParcelaEnviadaMEILabel As System.Windows.Forms.Label
        Dim QtoParcelasINSSAntigoLabel As System.Windows.Forms.Label
        Dim ParcelaEnviadaINSSAntigoLabel As System.Windows.Forms.Label
        Dim QtoParcelasINSSNovoLabel As System.Windows.Forms.Label
        Dim ParcelaEnviadaINSSNovoLabel As System.Windows.Forms.Label
        Dim QtoParcelasINSSProcuradoriaLabel As System.Windows.Forms.Label
        Dim ParcelaEnviadaINSSProcuradoriaLabel As System.Windows.Forms.Label
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
        Me.Geral = New System.Windows.Forms.TabPage()
        Me.TemDataFimParcelamentoCheckBox = New System.Windows.Forms.CheckBox()
        Me.FinalizadoParcelamentosDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TemDataLembreteCheckBox = New System.Windows.Forms.CheckBox()
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
        Me.Endereço = New System.Windows.Forms.TabPage()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.FormadeEnvio = New System.Windows.Forms.TabPage()
        Me.BtnAbriremail = New System.Windows.Forms.Button()
        Me.BtnAbrirWhatsApp = New System.Windows.Forms.Button()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WhatsAppTextBox = New System.Windows.Forms.TextBox()
        Me.BtnImportaSocio = New System.Windows.Forms.Button()
        Me.NomeResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.FormaEnvioComboBox = New System.Windows.Forms.ComboBox()
        Me.Responsável = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GovSenhaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CPFsocioResponsavelMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SocioResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControleParcelamentos = New System.Windows.Forms.TabControl()
        Me.TabPageMEI = New System.Windows.Forms.TabPage()
        Me.TabControlMEI = New System.Windows.Forms.TabControl()
        Me.TabPageMEIGeral = New System.Windows.Forms.TabPage()
        Me.BtnVerDetalhesMEI = New System.Windows.Forms.Button()
        Me.MotivoParcMEILabel = New System.Windows.Forms.Label()
        Me.ParcelaEnviadaMEITextBox = New System.Windows.Forms.TextBox()
        Me.QtoParcelasMEITextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegistrarEnvioMEI = New System.Windows.Forms.Button()
        Me.TemDataEntradaMEICheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataEnvioMEICheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataFimMEICheckBox = New System.Windows.Forms.CheckBox()
        Me.DataFimParcMEIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotivoParcMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataParcMEIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MesEnviadoMEIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MeiProtocoloTextBox = New System.Windows.Forms.TextBox()
        Me.TabPageMEIHistorico = New System.Windows.Forms.TabPage()
        Me.HistoricoEnvioMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageMEIObservacoes = New System.Windows.Forms.TabPage()
        Me.GeralMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSAntigo = New System.Windows.Forms.TabPage()
        Me.TabControlInssAntigo = New System.Windows.Forms.TabControl()
        Me.TabPageINSSAntigoGeral = New System.Windows.Forms.TabPage()
        Me.BtnVerDetalhesINSSAntigo = New System.Windows.Forms.Button()
        Me.MotivoParcINSSAntigoLabel = New System.Windows.Forms.Label()
        Me.ParcelaEnviadaINSSAntigoTextBox = New System.Windows.Forms.TextBox()
        Me.QtoParcelasINSSAntigoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegistrarEnvioINSSantigo = New System.Windows.Forms.Button()
        Me.TemDataEntradaINSSAntigoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataFimINSSAntigoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataEnvioINSSAntigoCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataParcelINSSantigoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INSSAntigoProtTextBox = New System.Windows.Forms.TextBox()
        Me.MesEnviadoINSSAntigoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotivoParcINSSAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoINSSAntigoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPageINSSAntigoHistorico = New System.Windows.Forms.TabPage()
        Me.HistoricoEnvioINSSAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSAntigoObservacoes = New System.Windows.Forms.TabPage()
        Me.INSSAntigoObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSNovo = New System.Windows.Forms.TabPage()
        Me.TabControlInssNovo = New System.Windows.Forms.TabControl()
        Me.TabPageINSSNovoGeral = New System.Windows.Forms.TabPage()
        Me.BtnVerDetalhesINSSNovo = New System.Windows.Forms.Button()
        Me.MotivoParcINSSNovoLabel = New System.Windows.Forms.Label()
        Me.ParcelaEnviadaINSSNovoTextBox = New System.Windows.Forms.TextBox()
        Me.QtoParcelasINSSNovoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegistrarEnvioINSSnovo = New System.Windows.Forms.Button()
        Me.TemDataEntradaINSSNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataFimINSSNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataEnvioINSSNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MesEnviadoINSSNovoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotivoParcINSSNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoINSSNovoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INSSNovoProtTextBox = New System.Windows.Forms.TextBox()
        Me.DataParcelINSSnovoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPageINSSNovoHistorico = New System.Windows.Forms.TabPage()
        Me.HistoricoEnvioINSSNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSNovoObservacoes = New System.Windows.Forms.TabPage()
        Me.INSSNovoObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSProcuradoria = New System.Windows.Forms.TabPage()
        Me.TabControlInssProcuradoria = New System.Windows.Forms.TabControl()
        Me.TabPageINSSProcuradoriaGeral = New System.Windows.Forms.TabPage()
        Me.BtnVerDetalhesINSSProcuradoria = New System.Windows.Forms.Button()
        Me.MotivoParcINSSProcLabel = New System.Windows.Forms.Label()
        Me.ParcelaEnviadaINSSProcuradoriaTextBox = New System.Windows.Forms.TextBox()
        Me.QtoParcelasINSSProcuradoriaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegistrarEnvioINSSProcuradoria = New System.Windows.Forms.Button()
        Me.TemDataEntradaINSSProcuCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataFimINSSProcurCheckBox = New System.Windows.Forms.CheckBox()
        Me.TemDataEnvioINSSProcurCheckBox = New System.Windows.Forms.CheckBox()
        Me.MesEnviadoINSSProcDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotivoParcINSSProcRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoINSSProcDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INSSProcProtTextBox = New System.Windows.Forms.TextBox()
        Me.DataParcelINSSprocDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPageINSSProcuradoriaHistorico = New System.Windows.Forms.TabPage()
        Me.HistoricoEnvioINSSProcRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSProcuradoriaObservacoes = New System.Windows.Forms.TabPage()
        Me.INSSProcObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GroupBoxSalvando = New System.Windows.Forms.GroupBox()
        Me.ProgressBarSalvando = New System.Windows.Forms.ProgressBar()
        Me.LabelSalvando = New System.Windows.Forms.Label()
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
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
        MeiProtocoloLabel = New System.Windows.Forms.Label()
        INSSAntigoProtLabel = New System.Windows.Forms.Label()
        INSSNovoProtLabel = New System.Windows.Forms.Label()
        INSSProcProtLabel = New System.Windows.Forms.Label()
        QtoParcelasMEILabel = New System.Windows.Forms.Label()
        ParcelaEnviadaMEILabel = New System.Windows.Forms.Label()
        QtoParcelasINSSAntigoLabel = New System.Windows.Forms.Label()
        ParcelaEnviadaINSSAntigoLabel = New System.Windows.Forms.Label()
        QtoParcelasINSSNovoLabel = New System.Windows.Forms.Label()
        ParcelaEnviadaINSSNovoLabel = New System.Windows.Forms.Label()
        QtoParcelasINSSProcuradoriaLabel = New System.Windows.Forms.Label()
        ParcelaEnviadaINSSProcuradoriaLabel = New System.Windows.Forms.Label()
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParcelamentosBindingNavigator.SuspendLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControlPrincipal.SuspendLayout()
        Me.Geral.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Endereço.SuspendLayout()
        Me.FormadeEnvio.SuspendLayout()
        Me.Responsável.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControleParcelamentos.SuspendLayout()
        Me.TabPageMEI.SuspendLayout()
        Me.TabControlMEI.SuspendLayout()
        Me.TabPageMEIGeral.SuspendLayout()
        Me.TabPageMEIHistorico.SuspendLayout()
        Me.TabPageMEIObservacoes.SuspendLayout()
        Me.TabPageINSSAntigo.SuspendLayout()
        Me.TabControlInssAntigo.SuspendLayout()
        Me.TabPageINSSAntigoGeral.SuspendLayout()
        Me.TabPageINSSAntigoHistorico.SuspendLayout()
        Me.TabPageINSSAntigoObservacoes.SuspendLayout()
        Me.TabPageINSSNovo.SuspendLayout()
        Me.TabControlInssNovo.SuspendLayout()
        Me.TabPageINSSNovoGeral.SuspendLayout()
        Me.TabPageINSSNovoHistorico.SuspendLayout()
        Me.TabPageINSSNovoObservacoes.SuspendLayout()
        Me.TabPageINSSProcuradoria.SuspendLayout()
        Me.TabControlInssProcuradoria.SuspendLayout()
        Me.TabPageINSSProcuradoriaGeral.SuspendLayout()
        Me.TabPageINSSProcuradoriaHistorico.SuspendLayout()
        Me.TabPageINSSProcuradoriaObservacoes.SuspendLayout()
        Me.GroupBoxMenu.SuspendLayout()
        Me.GroupBoxSalvando.SuspendLayout()
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
        'MeiProtocoloLabel
        '
        MeiProtocoloLabel.AutoSize = True
        MeiProtocoloLabel.Location = New System.Drawing.Point(160, 50)
        MeiProtocoloLabel.Name = "MeiProtocoloLabel"
        MeiProtocoloLabel.Size = New System.Drawing.Size(78, 18)
        MeiProtocoloLabel.TabIndex = 0
        MeiProtocoloLabel.Text = "Protocolo:"
        '
        'INSSAntigoProtLabel
        '
        INSSAntigoProtLabel.AutoSize = True
        INSSAntigoProtLabel.Location = New System.Drawing.Point(160, 50)
        INSSAntigoProtLabel.Name = "INSSAntigoProtLabel"
        INSSAntigoProtLabel.Size = New System.Drawing.Size(78, 18)
        INSSAntigoProtLabel.TabIndex = 8
        INSSAntigoProtLabel.Text = "Protocolo:"
        '
        'INSSNovoProtLabel
        '
        INSSNovoProtLabel.AutoSize = True
        INSSNovoProtLabel.Location = New System.Drawing.Point(160, 50)
        INSSNovoProtLabel.Name = "INSSNovoProtLabel"
        INSSNovoProtLabel.Size = New System.Drawing.Size(78, 18)
        INSSNovoProtLabel.TabIndex = 2
        INSSNovoProtLabel.Text = "Protocolo:"
        '
        'INSSProcProtLabel
        '
        INSSProcProtLabel.AutoSize = True
        INSSProcProtLabel.Location = New System.Drawing.Point(160, 50)
        INSSProcProtLabel.Name = "INSSProcProtLabel"
        INSSProcProtLabel.Size = New System.Drawing.Size(78, 18)
        INSSProcProtLabel.TabIndex = 4
        INSSProcProtLabel.Text = "Protocolo:"
        '
        'QtoParcelasMEILabel
        '
        QtoParcelasMEILabel.AutoSize = True
        QtoParcelasMEILabel.Location = New System.Drawing.Point(111, 80)
        QtoParcelasMEILabel.Name = "QtoParcelasMEILabel"
        QtoParcelasMEILabel.Size = New System.Drawing.Size(127, 18)
        QtoParcelasMEILabel.TabIndex = 16
        QtoParcelasMEILabel.Text = "Total de Parcelas:"
        '
        'ParcelaEnviadaMEILabel
        '
        ParcelaEnviadaMEILabel.AutoSize = True
        ParcelaEnviadaMEILabel.Location = New System.Drawing.Point(152, 177)
        ParcelaEnviadaMEILabel.Name = "ParcelaEnviadaMEILabel"
        ParcelaEnviadaMEILabel.Size = New System.Drawing.Size(158, 18)
        ParcelaEnviadaMEILabel.TabIndex = 17
        ParcelaEnviadaMEILabel.Text = "Nº da Parcela Enviada:"
        '
        'QtoParcelasINSSAntigoLabel
        '
        QtoParcelasINSSAntigoLabel.AutoSize = True
        QtoParcelasINSSAntigoLabel.Location = New System.Drawing.Point(111, 80)
        QtoParcelasINSSAntigoLabel.Name = "QtoParcelasINSSAntigoLabel"
        QtoParcelasINSSAntigoLabel.Size = New System.Drawing.Size(127, 18)
        QtoParcelasINSSAntigoLabel.TabIndex = 18
        QtoParcelasINSSAntigoLabel.Text = "Total de Parcelas:"
        '
        'ParcelaEnviadaINSSAntigoLabel
        '
        ParcelaEnviadaINSSAntigoLabel.AutoSize = True
        ParcelaEnviadaINSSAntigoLabel.Location = New System.Drawing.Point(152, 177)
        ParcelaEnviadaINSSAntigoLabel.Name = "ParcelaEnviadaINSSAntigoLabel"
        ParcelaEnviadaINSSAntigoLabel.Size = New System.Drawing.Size(158, 18)
        ParcelaEnviadaINSSAntigoLabel.TabIndex = 19
        ParcelaEnviadaINSSAntigoLabel.Text = "Nº da Parcela Enviada:"
        '
        'QtoParcelasINSSNovoLabel
        '
        QtoParcelasINSSNovoLabel.AutoSize = True
        QtoParcelasINSSNovoLabel.Location = New System.Drawing.Point(111, 80)
        QtoParcelasINSSNovoLabel.Name = "QtoParcelasINSSNovoLabel"
        QtoParcelasINSSNovoLabel.Size = New System.Drawing.Size(127, 18)
        QtoParcelasINSSNovoLabel.TabIndex = 18
        QtoParcelasINSSNovoLabel.Text = "Total de Parcelas:"
        '
        'ParcelaEnviadaINSSNovoLabel
        '
        ParcelaEnviadaINSSNovoLabel.AutoSize = True
        ParcelaEnviadaINSSNovoLabel.Location = New System.Drawing.Point(153, 177)
        ParcelaEnviadaINSSNovoLabel.Name = "ParcelaEnviadaINSSNovoLabel"
        ParcelaEnviadaINSSNovoLabel.Size = New System.Drawing.Size(158, 18)
        ParcelaEnviadaINSSNovoLabel.TabIndex = 19
        ParcelaEnviadaINSSNovoLabel.Text = "Nº da Parcela Enviada:"
        '
        'QtoParcelasINSSProcuradoriaLabel
        '
        QtoParcelasINSSProcuradoriaLabel.AutoSize = True
        QtoParcelasINSSProcuradoriaLabel.Location = New System.Drawing.Point(111, 80)
        QtoParcelasINSSProcuradoriaLabel.Name = "QtoParcelasINSSProcuradoriaLabel"
        QtoParcelasINSSProcuradoriaLabel.Size = New System.Drawing.Size(127, 18)
        QtoParcelasINSSProcuradoriaLabel.TabIndex = 18
        QtoParcelasINSSProcuradoriaLabel.Text = "Total de Parcelas:"
        '
        'ParcelaEnviadaINSSProcuradoriaLabel
        '
        ParcelaEnviadaINSSProcuradoriaLabel.AutoSize = True
        ParcelaEnviadaINSSProcuradoriaLabel.Location = New System.Drawing.Point(153, 177)
        ParcelaEnviadaINSSProcuradoriaLabel.Name = "ParcelaEnviadaINSSProcuradoriaLabel"
        ParcelaEnviadaINSSProcuradoriaLabel.Size = New System.Drawing.Size(158, 18)
        ParcelaEnviadaINSSProcuradoriaLabel.TabIndex = 19
        ParcelaEnviadaINSSProcuradoriaLabel.Text = "Nº da Parcela Enviada:"
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
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxSalvando, 1, 2)
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
        Me.TabControlPrincipal.Controls.Add(Me.Geral)
        Me.TabControlPrincipal.Controls.Add(Me.Endereço)
        Me.TabControlPrincipal.Controls.Add(Me.FormadeEnvio)
        Me.TabControlPrincipal.Controls.Add(Me.Responsável)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipal.Location = New System.Drawing.Point(4, 21)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(817, 261)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'Geral
        '
        Me.Geral.AutoScroll = True
        Me.Geral.Controls.Add(Me.TemDataFimParcelamentoCheckBox)
        Me.Geral.Controls.Add(Me.FinalizadoParcelamentosDateTimePicker)
        Me.Geral.Controls.Add(Me.TemDataLembreteCheckBox)
        Me.Geral.Controls.Add(Me.BtnBImportarEmpresa)
        Me.Geral.Controls.Add(RazaoSocialLabel)
        Me.Geral.Controls.Add(Me.BtnCopiarCNPJ)
        Me.Geral.Controls.Add(Me.RazaoSocialTextBox)
        Me.Geral.Controls.Add(Me.BtnDuplicidade)
        Me.Geral.Controls.Add(Me.CNPJMaskedTextBox)
        Me.Geral.Controls.Add(Me.GroupBox4)
        Me.Geral.Controls.Add(CNPJLabel)
        Me.Geral.Controls.Add(DataCriacaoLabel)
        Me.Geral.Controls.Add(Me.DataLembreteDateTimePicker)
        Me.Geral.Controls.Add(Me.DataCriacaoDateTimePicker)
        Me.Geral.Location = New System.Drawing.Point(4, 27)
        Me.Geral.Name = "Geral"
        Me.Geral.Padding = New System.Windows.Forms.Padding(3)
        Me.Geral.Size = New System.Drawing.Size(809, 230)
        Me.Geral.TabIndex = 0
        Me.Geral.Text = "Geral"
        Me.Geral.UseVisualStyleBackColor = True
        '
        'TemDataFimParcelamentoCheckBox
        '
        Me.TemDataFimParcelamentoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataFimParcelamento", True))
        Me.TemDataFimParcelamentoCheckBox.Location = New System.Drawing.Point(6, 186)
        Me.TemDataFimParcelamentoCheckBox.Name = "TemDataFimParcelamentoCheckBox"
        Me.TemDataFimParcelamentoCheckBox.Size = New System.Drawing.Size(225, 24)
        Me.TemDataFimParcelamentoCheckBox.TabIndex = 75
        Me.TemDataFimParcelamentoCheckBox.Text = "Data Fim dos Parcelamentos:"
        Me.TemDataFimParcelamentoCheckBox.UseVisualStyleBackColor = True
        '
        'FinalizadoParcelamentosDateTimePicker
        '
        Me.FinalizadoParcelamentosDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "FinalizadoParcelamentos", True))
        Me.FinalizadoParcelamentosDateTimePicker.Location = New System.Drawing.Point(237, 183)
        Me.FinalizadoParcelamentosDateTimePicker.Name = "FinalizadoParcelamentosDateTimePicker"
        Me.FinalizadoParcelamentosDateTimePicker.Size = New System.Drawing.Size(294, 24)
        Me.FinalizadoParcelamentosDateTimePicker.TabIndex = 9
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
        'Endereço
        '
        Me.Endereço.Controls.Add(EstadoLabel)
        Me.Endereço.Controls.Add(Me.EstadoTextBox)
        Me.Endereço.Controls.Add(CidadeLabel)
        Me.Endereço.Controls.Add(Me.CidadeTextBox)
        Me.Endereço.Controls.Add(BairroLabel)
        Me.Endereço.Controls.Add(Me.BairroTextBox)
        Me.Endereço.Controls.Add(ComplementoLabel)
        Me.Endereço.Controls.Add(Me.ComplementoTextBox)
        Me.Endereço.Controls.Add(NumeroLabel)
        Me.Endereço.Controls.Add(Me.NumeroTextBox)
        Me.Endereço.Controls.Add(RuaLabel)
        Me.Endereço.Controls.Add(Me.RuaTextBox)
        Me.Endereço.Location = New System.Drawing.Point(4, 27)
        Me.Endereço.Name = "Endereço"
        Me.Endereço.Padding = New System.Windows.Forms.Padding(3)
        Me.Endereço.Size = New System.Drawing.Size(809, 234)
        Me.Endereço.TabIndex = 1
        Me.Endereço.Text = "Endereço"
        Me.Endereço.UseVisualStyleBackColor = True
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
        'FormadeEnvio
        '
        Me.FormadeEnvio.Controls.Add(Me.BtnAbriremail)
        Me.FormadeEnvio.Controls.Add(Me.BtnAbrirWhatsApp)
        Me.FormadeEnvio.Controls.Add(EmailLabel)
        Me.FormadeEnvio.Controls.Add(Me.EmailTextBox)
        Me.FormadeEnvio.Controls.Add(WhatsAppLabel)
        Me.FormadeEnvio.Controls.Add(Me.WhatsAppTextBox)
        Me.FormadeEnvio.Controls.Add(Me.BtnImportaSocio)
        Me.FormadeEnvio.Controls.Add(NomeResponsavelLabel)
        Me.FormadeEnvio.Controls.Add(Me.NomeResponsavelTextBox)
        Me.FormadeEnvio.Controls.Add(FormaEnvioLabel)
        Me.FormadeEnvio.Controls.Add(Me.FormaEnvioComboBox)
        Me.FormadeEnvio.Location = New System.Drawing.Point(4, 27)
        Me.FormadeEnvio.Name = "FormadeEnvio"
        Me.FormadeEnvio.Size = New System.Drawing.Size(809, 234)
        Me.FormadeEnvio.TabIndex = 2
        Me.FormadeEnvio.Text = "Forma de Envio"
        Me.FormadeEnvio.UseVisualStyleBackColor = True
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
        'Responsável
        '
        Me.Responsável.Controls.Add(Me.Button1)
        Me.Responsável.Controls.Add(GovSenhaLabel)
        Me.Responsável.Controls.Add(Me.GovSenhaMaskedTextBox)
        Me.Responsável.Controls.Add(CPFsocioResponsavelLabel)
        Me.Responsável.Controls.Add(Me.CPFsocioResponsavelMaskedTextBox)
        Me.Responsável.Controls.Add(SocioResponsavelLabel)
        Me.Responsável.Controls.Add(Me.SocioResponsavelTextBox)
        Me.Responsável.Location = New System.Drawing.Point(4, 27)
        Me.Responsável.Name = "Responsável"
        Me.Responsável.Size = New System.Drawing.Size(809, 234)
        Me.Responsável.TabIndex = 3
        Me.Responsável.Text = "Sócio/Responsável"
        Me.Responsável.UseVisualStyleBackColor = True
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
        Me.TabControleParcelamentos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageMEI)
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageINSSAntigo)
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageINSSNovo)
        Me.TabControleParcelamentos.Controls.Add(Me.TabPageINSSProcuradoria)
        Me.TabControleParcelamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControleParcelamentos.Location = New System.Drawing.Point(4, 21)
        Me.TabControleParcelamentos.Margin = New System.Windows.Forms.Padding(0)
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
        Me.TabControlMEI.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlMEI.Controls.Add(Me.TabPageMEIGeral)
        Me.TabControlMEI.Controls.Add(Me.TabPageMEIHistorico)
        Me.TabControlMEI.Controls.Add(Me.TabPageMEIObservacoes)
        Me.TabControlMEI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMEI.Location = New System.Drawing.Point(3, 3)
        Me.TabControlMEI.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlMEI.Name = "TabControlMEI"
        Me.TabControlMEI.SelectedIndex = 0
        Me.TabControlMEI.Size = New System.Drawing.Size(803, 275)
        Me.TabControlMEI.TabIndex = 0
        '
        'TabPageMEIGeral
        '
        Me.TabPageMEIGeral.AutoScroll = True
        Me.TabPageMEIGeral.Controls.Add(Me.BtnVerDetalhesMEI)
        Me.TabPageMEIGeral.Controls.Add(Me.MotivoParcMEILabel)
        Me.TabPageMEIGeral.Controls.Add(ParcelaEnviadaMEILabel)
        Me.TabPageMEIGeral.Controls.Add(Me.ParcelaEnviadaMEITextBox)
        Me.TabPageMEIGeral.Controls.Add(QtoParcelasMEILabel)
        Me.TabPageMEIGeral.Controls.Add(Me.QtoParcelasMEITextBox)
        Me.TabPageMEIGeral.Controls.Add(Me.BtnRegistrarEnvioMEI)
        Me.TabPageMEIGeral.Controls.Add(Me.TemDataEntradaMEICheckBox)
        Me.TabPageMEIGeral.Controls.Add(Me.TemDataEnvioMEICheckBox)
        Me.TabPageMEIGeral.Controls.Add(Me.TemDataFimMEICheckBox)
        Me.TabPageMEIGeral.Controls.Add(Me.DataFimParcMEIDateTimePicker)
        Me.TabPageMEIGeral.Controls.Add(Me.MotivoParcMEIRichTextBox)
        Me.TabPageMEIGeral.Controls.Add(Me.DataParcMEIDateTimePicker)
        Me.TabPageMEIGeral.Controls.Add(Me.MesEnviadoMEIDateTimePicker)
        Me.TabPageMEIGeral.Controls.Add(MeiProtocoloLabel)
        Me.TabPageMEIGeral.Controls.Add(Me.MeiProtocoloTextBox)
        Me.TabPageMEIGeral.Location = New System.Drawing.Point(4, 30)
        Me.TabPageMEIGeral.Name = "TabPageMEIGeral"
        Me.TabPageMEIGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMEIGeral.Size = New System.Drawing.Size(795, 241)
        Me.TabPageMEIGeral.TabIndex = 0
        Me.TabPageMEIGeral.Text = "Geral"
        Me.TabPageMEIGeral.UseVisualStyleBackColor = True
        '
        'BtnVerDetalhesMEI
        '
        Me.BtnVerDetalhesMEI.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesMEI.FlatAppearance.BorderSize = 2
        Me.BtnVerDetalhesMEI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerDetalhesMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerDetalhesMEI.ForeColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesMEI.Location = New System.Drawing.Point(6, 197)
        Me.BtnVerDetalhesMEI.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnVerDetalhesMEI.Name = "BtnVerDetalhesMEI"
        Me.BtnVerDetalhesMEI.Size = New System.Drawing.Size(102, 37)
        Me.BtnVerDetalhesMEI.TabIndex = 20
        Me.BtnVerDetalhesMEI.Text = "Detalhes"
        Me.BtnVerDetalhesMEI.UseVisualStyleBackColor = True
        '
        'MotivoParcMEILabel
        '
        Me.MotivoParcMEILabel.AutoSize = True
        Me.MotivoParcMEILabel.Location = New System.Drawing.Point(560, 19)
        Me.MotivoParcMEILabel.Name = "MotivoParcMEILabel"
        Me.MotivoParcMEILabel.Size = New System.Drawing.Size(57, 18)
        Me.MotivoParcMEILabel.TabIndex = 19
        Me.MotivoParcMEILabel.Text = "Motivo:"
        '
        'ParcelaEnviadaMEITextBox
        '
        Me.ParcelaEnviadaMEITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelaEnviadaMEI", True))
        Me.ParcelaEnviadaMEITextBox.Location = New System.Drawing.Point(316, 174)
        Me.ParcelaEnviadaMEITextBox.Name = "ParcelaEnviadaMEITextBox"
        Me.ParcelaEnviadaMEITextBox.Size = New System.Drawing.Size(100, 24)
        Me.ParcelaEnviadaMEITextBox.TabIndex = 18
        '
        'QtoParcelasMEITextBox
        '
        Me.QtoParcelasMEITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "QtoParcelasMEI", True))
        Me.QtoParcelasMEITextBox.Location = New System.Drawing.Point(244, 77)
        Me.QtoParcelasMEITextBox.Name = "QtoParcelasMEITextBox"
        Me.QtoParcelasMEITextBox.Size = New System.Drawing.Size(100, 24)
        Me.QtoParcelasMEITextBox.TabIndex = 17
        '
        'BtnRegistrarEnvioMEI
        '
        Me.BtnRegistrarEnvioMEI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistrarEnvioMEI.FlatAppearance.BorderSize = 2
        Me.BtnRegistrarEnvioMEI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarEnvioMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioMEI.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnRegistrarEnvioMEI.Location = New System.Drawing.Point(425, 168)
        Me.BtnRegistrarEnvioMEI.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnRegistrarEnvioMEI.Name = "BtnRegistrarEnvioMEI"
        Me.BtnRegistrarEnvioMEI.Size = New System.Drawing.Size(132, 37)
        Me.BtnRegistrarEnvioMEI.TabIndex = 16
        Me.BtnRegistrarEnvioMEI.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioMEI.UseVisualStyleBackColor = True
        '
        'TemDataEntradaMEICheckBox
        '
        Me.TemDataEntradaMEICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEntradaMEI", True))
        Me.TemDataEntradaMEICheckBox.Location = New System.Drawing.Point(9, 17)
        Me.TemDataEntradaMEICheckBox.Name = "TemDataEntradaMEICheckBox"
        Me.TemDataEntradaMEICheckBox.Size = New System.Drawing.Size(234, 24)
        Me.TemDataEntradaMEICheckBox.TabIndex = 15
        Me.TemDataEntradaMEICheckBox.Text = "Data Entrada do Parcelamento:"
        Me.TemDataEntradaMEICheckBox.UseVisualStyleBackColor = True
        '
        'TemDataEnvioMEICheckBox
        '
        Me.TemDataEnvioMEICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEnvioMEI", True))
        Me.TemDataEnvioMEICheckBox.Location = New System.Drawing.Point(124, 137)
        Me.TemDataEnvioMEICheckBox.Name = "TemDataEnvioMEICheckBox"
        Me.TemDataEnvioMEICheckBox.Size = New System.Drawing.Size(118, 24)
        Me.TemDataEnvioMEICheckBox.TabIndex = 14
        Me.TemDataEnvioMEICheckBox.Text = "Mes Enviado:"
        Me.TemDataEnvioMEICheckBox.UseVisualStyleBackColor = True
        '
        'TemDataFimMEICheckBox
        '
        Me.TemDataFimMEICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataFimMEI", True))
        Me.TemDataFimMEICheckBox.Location = New System.Drawing.Point(68, 107)
        Me.TemDataFimMEICheckBox.Name = "TemDataFimMEICheckBox"
        Me.TemDataFimMEICheckBox.Size = New System.Drawing.Size(174, 24)
        Me.TemDataFimMEICheckBox.TabIndex = 13
        Me.TemDataFimMEICheckBox.Text = "Fim do Parcelamento:"
        Me.TemDataFimMEICheckBox.UseVisualStyleBackColor = True
        '
        'DataFimParcMEIDateTimePicker
        '
        Me.DataFimParcMEIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataFimParcMEI", True))
        Me.DataFimParcMEIDateTimePicker.Location = New System.Drawing.Point(244, 107)
        Me.DataFimParcMEIDateTimePicker.Name = "DataFimParcMEIDateTimePicker"
        Me.DataFimParcMEIDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.DataFimParcMEIDateTimePicker.TabIndex = 11
        '
        'MotivoParcMEIRichTextBox
        '
        Me.MotivoParcMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcMEI", True))
        Me.MotivoParcMEIRichTextBox.Location = New System.Drawing.Point(618, 17)
        Me.MotivoParcMEIRichTextBox.Name = "MotivoParcMEIRichTextBox"
        Me.MotivoParcMEIRichTextBox.Size = New System.Drawing.Size(165, 220)
        Me.MotivoParcMEIRichTextBox.TabIndex = 9
        Me.MotivoParcMEIRichTextBox.Text = ""
        '
        'DataParcMEIDateTimePicker
        '
        Me.DataParcMEIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcMEI", True))
        Me.DataParcMEIDateTimePicker.Location = New System.Drawing.Point(244, 17)
        Me.DataParcMEIDateTimePicker.Name = "DataParcMEIDateTimePicker"
        Me.DataParcMEIDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.DataParcMEIDateTimePicker.TabIndex = 7
        '
        'MesEnviadoMEIDateTimePicker
        '
        Me.MesEnviadoMEIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoMEI", True))
        Me.MesEnviadoMEIDateTimePicker.Location = New System.Drawing.Point(244, 137)
        Me.MesEnviadoMEIDateTimePicker.Name = "MesEnviadoMEIDateTimePicker"
        Me.MesEnviadoMEIDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.MesEnviadoMEIDateTimePicker.TabIndex = 3
        '
        'MeiProtocoloTextBox
        '
        Me.MeiProtocoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MeiProtocolo", True))
        Me.MeiProtocoloTextBox.Location = New System.Drawing.Point(244, 47)
        Me.MeiProtocoloTextBox.Name = "MeiProtocoloTextBox"
        Me.MeiProtocoloTextBox.Size = New System.Drawing.Size(313, 24)
        Me.MeiProtocoloTextBox.TabIndex = 1
        '
        'TabPageMEIHistorico
        '
        Me.TabPageMEIHistorico.Controls.Add(Me.HistoricoEnvioMEIRichTextBox)
        Me.TabPageMEIHistorico.Location = New System.Drawing.Point(4, 30)
        Me.TabPageMEIHistorico.Name = "TabPageMEIHistorico"
        Me.TabPageMEIHistorico.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMEIHistorico.Size = New System.Drawing.Size(795, 241)
        Me.TabPageMEIHistorico.TabIndex = 1
        Me.TabPageMEIHistorico.Text = "Histórico"
        Me.TabPageMEIHistorico.UseVisualStyleBackColor = True
        '
        'HistoricoEnvioMEIRichTextBox
        '
        Me.HistoricoEnvioMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioMEI", True))
        Me.HistoricoEnvioMEIRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioMEIRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioMEIRichTextBox.Name = "HistoricoEnvioMEIRichTextBox"
        Me.HistoricoEnvioMEIRichTextBox.ReadOnly = True
        Me.HistoricoEnvioMEIRichTextBox.Size = New System.Drawing.Size(789, 235)
        Me.HistoricoEnvioMEIRichTextBox.TabIndex = 1
        Me.HistoricoEnvioMEIRichTextBox.Text = ""
        '
        'TabPageMEIObservacoes
        '
        Me.TabPageMEIObservacoes.Controls.Add(Me.GeralMEIRichTextBox)
        Me.TabPageMEIObservacoes.Location = New System.Drawing.Point(4, 30)
        Me.TabPageMEIObservacoes.Name = "TabPageMEIObservacoes"
        Me.TabPageMEIObservacoes.Size = New System.Drawing.Size(795, 241)
        Me.TabPageMEIObservacoes.TabIndex = 2
        Me.TabPageMEIObservacoes.Text = "Detalhes"
        Me.TabPageMEIObservacoes.UseVisualStyleBackColor = True
        '
        'GeralMEIRichTextBox
        '
        Me.GeralMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "GeralMEI", True))
        Me.GeralMEIRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeralMEIRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.GeralMEIRichTextBox.Name = "GeralMEIRichTextBox"
        Me.GeralMEIRichTextBox.Size = New System.Drawing.Size(795, 241)
        Me.GeralMEIRichTextBox.TabIndex = 6
        Me.GeralMEIRichTextBox.Text = ""
        '
        'TabPageINSSAntigo
        '
        Me.TabPageINSSAntigo.Controls.Add(Me.TabControlInssAntigo)
        Me.TabPageINSSAntigo.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSAntigo.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageINSSAntigo.Name = "TabPageINSSAntigo"
        Me.TabPageINSSAntigo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSAntigo.Size = New System.Drawing.Size(809, 281)
        Me.TabPageINSSAntigo.TabIndex = 1
        Me.TabPageINSSAntigo.Text = "INSS - Antigo"
        Me.TabPageINSSAntigo.UseVisualStyleBackColor = True
        '
        'TabControlInssAntigo
        '
        Me.TabControlInssAntigo.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlInssAntigo.Controls.Add(Me.TabPageINSSAntigoGeral)
        Me.TabControlInssAntigo.Controls.Add(Me.TabPageINSSAntigoHistorico)
        Me.TabControlInssAntigo.Controls.Add(Me.TabPageINSSAntigoObservacoes)
        Me.TabControlInssAntigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlInssAntigo.Location = New System.Drawing.Point(3, 3)
        Me.TabControlInssAntigo.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlInssAntigo.Name = "TabControlInssAntigo"
        Me.TabControlInssAntigo.SelectedIndex = 0
        Me.TabControlInssAntigo.Size = New System.Drawing.Size(803, 275)
        Me.TabControlInssAntigo.TabIndex = 1
        '
        'TabPageINSSAntigoGeral
        '
        Me.TabPageINSSAntigoGeral.AutoScroll = True
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.BtnVerDetalhesINSSAntigo)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.MotivoParcINSSAntigoLabel)
        Me.TabPageINSSAntigoGeral.Controls.Add(ParcelaEnviadaINSSAntigoLabel)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.ParcelaEnviadaINSSAntigoTextBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(QtoParcelasINSSAntigoLabel)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.QtoParcelasINSSAntigoTextBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.BtnRegistrarEnvioINSSantigo)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.TemDataEntradaINSSAntigoCheckBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.TemDataFimINSSAntigoCheckBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.TemDataEnvioINSSAntigoCheckBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.DataParcelINSSantigoDateTimePicker)
        Me.TabPageINSSAntigoGeral.Controls.Add(INSSAntigoProtLabel)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.INSSAntigoProtTextBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.MesEnviadoINSSAntigoDateTimePicker)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.MotivoParcINSSAntigoRichTextBox)
        Me.TabPageINSSAntigoGeral.Controls.Add(Me.FinalizadoINSSAntigoDateTimePicker)
        Me.TabPageINSSAntigoGeral.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSAntigoGeral.Name = "TabPageINSSAntigoGeral"
        Me.TabPageINSSAntigoGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSAntigoGeral.Size = New System.Drawing.Size(795, 241)
        Me.TabPageINSSAntigoGeral.TabIndex = 0
        Me.TabPageINSSAntigoGeral.Text = "Geral"
        Me.TabPageINSSAntigoGeral.UseVisualStyleBackColor = True
        '
        'BtnVerDetalhesINSSAntigo
        '
        Me.BtnVerDetalhesINSSAntigo.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesINSSAntigo.FlatAppearance.BorderSize = 2
        Me.BtnVerDetalhesINSSAntigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerDetalhesINSSAntigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerDetalhesINSSAntigo.ForeColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesINSSAntigo.Location = New System.Drawing.Point(6, 197)
        Me.BtnVerDetalhesINSSAntigo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnVerDetalhesINSSAntigo.Name = "BtnVerDetalhesINSSAntigo"
        Me.BtnVerDetalhesINSSAntigo.Size = New System.Drawing.Size(102, 37)
        Me.BtnVerDetalhesINSSAntigo.TabIndex = 22
        Me.BtnVerDetalhesINSSAntigo.Text = "Detalhes"
        Me.BtnVerDetalhesINSSAntigo.UseVisualStyleBackColor = True
        '
        'MotivoParcINSSAntigoLabel
        '
        Me.MotivoParcINSSAntigoLabel.AutoSize = True
        Me.MotivoParcINSSAntigoLabel.Location = New System.Drawing.Point(560, 19)
        Me.MotivoParcINSSAntigoLabel.Name = "MotivoParcINSSAntigoLabel"
        Me.MotivoParcINSSAntigoLabel.Size = New System.Drawing.Size(57, 18)
        Me.MotivoParcINSSAntigoLabel.TabIndex = 21
        Me.MotivoParcINSSAntigoLabel.Text = "Motivo:"
        '
        'ParcelaEnviadaINSSAntigoTextBox
        '
        Me.ParcelaEnviadaINSSAntigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelaEnviadaINSSAntigo", True))
        Me.ParcelaEnviadaINSSAntigoTextBox.Location = New System.Drawing.Point(316, 174)
        Me.ParcelaEnviadaINSSAntigoTextBox.Name = "ParcelaEnviadaINSSAntigoTextBox"
        Me.ParcelaEnviadaINSSAntigoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ParcelaEnviadaINSSAntigoTextBox.TabIndex = 20
        '
        'QtoParcelasINSSAntigoTextBox
        '
        Me.QtoParcelasINSSAntigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "QtoParcelasINSSAntigo", True))
        Me.QtoParcelasINSSAntigoTextBox.Location = New System.Drawing.Point(244, 77)
        Me.QtoParcelasINSSAntigoTextBox.Name = "QtoParcelasINSSAntigoTextBox"
        Me.QtoParcelasINSSAntigoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.QtoParcelasINSSAntigoTextBox.TabIndex = 19
        '
        'BtnRegistrarEnvioINSSantigo
        '
        Me.BtnRegistrarEnvioINSSantigo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistrarEnvioINSSantigo.FlatAppearance.BorderSize = 2
        Me.BtnRegistrarEnvioINSSantigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarEnvioINSSantigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioINSSantigo.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnRegistrarEnvioINSSantigo.Location = New System.Drawing.Point(425, 168)
        Me.BtnRegistrarEnvioINSSantigo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnRegistrarEnvioINSSantigo.Name = "BtnRegistrarEnvioINSSantigo"
        Me.BtnRegistrarEnvioINSSantigo.Size = New System.Drawing.Size(132, 37)
        Me.BtnRegistrarEnvioINSSantigo.TabIndex = 18
        Me.BtnRegistrarEnvioINSSantigo.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioINSSantigo.UseVisualStyleBackColor = True
        '
        'TemDataEntradaINSSAntigoCheckBox
        '
        Me.TemDataEntradaINSSAntigoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEntradaINSSAntigo", True))
        Me.TemDataEntradaINSSAntigoCheckBox.Location = New System.Drawing.Point(9, 17)
        Me.TemDataEntradaINSSAntigoCheckBox.Name = "TemDataEntradaINSSAntigoCheckBox"
        Me.TemDataEntradaINSSAntigoCheckBox.Size = New System.Drawing.Size(234, 24)
        Me.TemDataEntradaINSSAntigoCheckBox.TabIndex = 17
        Me.TemDataEntradaINSSAntigoCheckBox.Text = "Data Entrada do Parcelamento:"
        Me.TemDataEntradaINSSAntigoCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataFimINSSAntigoCheckBox
        '
        Me.TemDataFimINSSAntigoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataFimINSSAntigo", True))
        Me.TemDataFimINSSAntigoCheckBox.Location = New System.Drawing.Point(68, 107)
        Me.TemDataFimINSSAntigoCheckBox.Name = "TemDataFimINSSAntigoCheckBox"
        Me.TemDataFimINSSAntigoCheckBox.Size = New System.Drawing.Size(174, 24)
        Me.TemDataFimINSSAntigoCheckBox.TabIndex = 15
        Me.TemDataFimINSSAntigoCheckBox.Text = "Fim do Parcelamento:"
        Me.TemDataFimINSSAntigoCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataEnvioINSSAntigoCheckBox
        '
        Me.TemDataEnvioINSSAntigoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEnvioINSSAntigo", True))
        Me.TemDataEnvioINSSAntigoCheckBox.Location = New System.Drawing.Point(124, 137)
        Me.TemDataEnvioINSSAntigoCheckBox.Name = "TemDataEnvioINSSAntigoCheckBox"
        Me.TemDataEnvioINSSAntigoCheckBox.Size = New System.Drawing.Size(118, 24)
        Me.TemDataEnvioINSSAntigoCheckBox.TabIndex = 13
        Me.TemDataEnvioINSSAntigoCheckBox.Text = "Mes Enviado:"
        Me.TemDataEnvioINSSAntigoCheckBox.UseVisualStyleBackColor = True
        '
        'DataParcelINSSantigoDateTimePicker
        '
        Me.DataParcelINSSantigoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcelINSSantigo", True))
        Me.DataParcelINSSantigoDateTimePicker.Location = New System.Drawing.Point(244, 17)
        Me.DataParcelINSSantigoDateTimePicker.Name = "DataParcelINSSantigoDateTimePicker"
        Me.DataParcelINSSantigoDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.DataParcelINSSantigoDateTimePicker.TabIndex = 11
        '
        'INSSAntigoProtTextBox
        '
        Me.INSSAntigoProtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSAntigoProt", True))
        Me.INSSAntigoProtTextBox.Location = New System.Drawing.Point(244, 47)
        Me.INSSAntigoProtTextBox.Name = "INSSAntigoProtTextBox"
        Me.INSSAntigoProtTextBox.Size = New System.Drawing.Size(313, 24)
        Me.INSSAntigoProtTextBox.TabIndex = 9
        '
        'MesEnviadoINSSAntigoDateTimePicker
        '
        Me.MesEnviadoINSSAntigoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoINSSAntigo", True))
        Me.MesEnviadoINSSAntigoDateTimePicker.Location = New System.Drawing.Point(244, 137)
        Me.MesEnviadoINSSAntigoDateTimePicker.Name = "MesEnviadoINSSAntigoDateTimePicker"
        Me.MesEnviadoINSSAntigoDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.MesEnviadoINSSAntigoDateTimePicker.TabIndex = 7
        '
        'MotivoParcINSSAntigoRichTextBox
        '
        Me.MotivoParcINSSAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcINSSAntigo", True))
        Me.MotivoParcINSSAntigoRichTextBox.Location = New System.Drawing.Point(618, 17)
        Me.MotivoParcINSSAntigoRichTextBox.Name = "MotivoParcINSSAntigoRichTextBox"
        Me.MotivoParcINSSAntigoRichTextBox.Size = New System.Drawing.Size(165, 220)
        Me.MotivoParcINSSAntigoRichTextBox.TabIndex = 3
        Me.MotivoParcINSSAntigoRichTextBox.Text = ""
        '
        'FinalizadoINSSAntigoDateTimePicker
        '
        Me.FinalizadoINSSAntigoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "FinalizadoINSSAntigo", True))
        Me.FinalizadoINSSAntigoDateTimePicker.Location = New System.Drawing.Point(244, 107)
        Me.FinalizadoINSSAntigoDateTimePicker.Name = "FinalizadoINSSAntigoDateTimePicker"
        Me.FinalizadoINSSAntigoDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.FinalizadoINSSAntigoDateTimePicker.TabIndex = 1
        '
        'TabPageINSSAntigoHistorico
        '
        Me.TabPageINSSAntigoHistorico.Controls.Add(Me.HistoricoEnvioINSSAntigoRichTextBox)
        Me.TabPageINSSAntigoHistorico.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSAntigoHistorico.Name = "TabPageINSSAntigoHistorico"
        Me.TabPageINSSAntigoHistorico.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSAntigoHistorico.Size = New System.Drawing.Size(795, 241)
        Me.TabPageINSSAntigoHistorico.TabIndex = 1
        Me.TabPageINSSAntigoHistorico.Text = "Histórico"
        Me.TabPageINSSAntigoHistorico.UseVisualStyleBackColor = True
        '
        'HistoricoEnvioINSSAntigoRichTextBox
        '
        Me.HistoricoEnvioINSSAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSAntigo", True))
        Me.HistoricoEnvioINSSAntigoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioINSSAntigoRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioINSSAntigoRichTextBox.Name = "HistoricoEnvioINSSAntigoRichTextBox"
        Me.HistoricoEnvioINSSAntigoRichTextBox.ReadOnly = True
        Me.HistoricoEnvioINSSAntigoRichTextBox.Size = New System.Drawing.Size(789, 235)
        Me.HistoricoEnvioINSSAntigoRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSAntigoRichTextBox.Text = ""
        '
        'TabPageINSSAntigoObservacoes
        '
        Me.TabPageINSSAntigoObservacoes.Controls.Add(Me.INSSAntigoObsRichTextBox)
        Me.TabPageINSSAntigoObservacoes.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSAntigoObservacoes.Name = "TabPageINSSAntigoObservacoes"
        Me.TabPageINSSAntigoObservacoes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSAntigoObservacoes.Size = New System.Drawing.Size(795, 241)
        Me.TabPageINSSAntigoObservacoes.TabIndex = 2
        Me.TabPageINSSAntigoObservacoes.Text = "Detalhes"
        Me.TabPageINSSAntigoObservacoes.UseVisualStyleBackColor = True
        '
        'INSSAntigoObsRichTextBox
        '
        Me.INSSAntigoObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSAntigoObs", True))
        Me.INSSAntigoObsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.INSSAntigoObsRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.INSSAntigoObsRichTextBox.Name = "INSSAntigoObsRichTextBox"
        Me.INSSAntigoObsRichTextBox.Size = New System.Drawing.Size(789, 235)
        Me.INSSAntigoObsRichTextBox.TabIndex = 19
        Me.INSSAntigoObsRichTextBox.Text = ""
        '
        'TabPageINSSNovo
        '
        Me.TabPageINSSNovo.Controls.Add(Me.TabControlInssNovo)
        Me.TabPageINSSNovo.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSNovo.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageINSSNovo.Name = "TabPageINSSNovo"
        Me.TabPageINSSNovo.Size = New System.Drawing.Size(809, 281)
        Me.TabPageINSSNovo.TabIndex = 2
        Me.TabPageINSSNovo.Text = "INSS - Novo"
        Me.TabPageINSSNovo.UseVisualStyleBackColor = True
        '
        'TabControlInssNovo
        '
        Me.TabControlInssNovo.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlInssNovo.Controls.Add(Me.TabPageINSSNovoGeral)
        Me.TabControlInssNovo.Controls.Add(Me.TabPageINSSNovoHistorico)
        Me.TabControlInssNovo.Controls.Add(Me.TabPageINSSNovoObservacoes)
        Me.TabControlInssNovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlInssNovo.Location = New System.Drawing.Point(0, 0)
        Me.TabControlInssNovo.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlInssNovo.Name = "TabControlInssNovo"
        Me.TabControlInssNovo.SelectedIndex = 0
        Me.TabControlInssNovo.Size = New System.Drawing.Size(809, 281)
        Me.TabControlInssNovo.TabIndex = 1
        '
        'TabPageINSSNovoGeral
        '
        Me.TabPageINSSNovoGeral.AutoScroll = True
        Me.TabPageINSSNovoGeral.Controls.Add(Me.BtnVerDetalhesINSSNovo)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.MotivoParcINSSNovoLabel)
        Me.TabPageINSSNovoGeral.Controls.Add(ParcelaEnviadaINSSNovoLabel)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.ParcelaEnviadaINSSNovoTextBox)
        Me.TabPageINSSNovoGeral.Controls.Add(QtoParcelasINSSNovoLabel)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.QtoParcelasINSSNovoTextBox)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.BtnRegistrarEnvioINSSnovo)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.TemDataEntradaINSSNovoCheckBox)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.TemDataFimINSSNovoCheckBox)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.TemDataEnvioINSSNovoCheckBox)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.MesEnviadoINSSNovoDateTimePicker)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.MotivoParcINSSNovoRichTextBox)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.FinalizadoINSSNovoDateTimePicker)
        Me.TabPageINSSNovoGeral.Controls.Add(INSSNovoProtLabel)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.INSSNovoProtTextBox)
        Me.TabPageINSSNovoGeral.Controls.Add(Me.DataParcelINSSnovoDateTimePicker)
        Me.TabPageINSSNovoGeral.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSNovoGeral.Name = "TabPageINSSNovoGeral"
        Me.TabPageINSSNovoGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSNovoGeral.Size = New System.Drawing.Size(801, 247)
        Me.TabPageINSSNovoGeral.TabIndex = 0
        Me.TabPageINSSNovoGeral.Text = "Geral"
        Me.TabPageINSSNovoGeral.UseVisualStyleBackColor = True
        '
        'BtnVerDetalhesINSSNovo
        '
        Me.BtnVerDetalhesINSSNovo.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesINSSNovo.FlatAppearance.BorderSize = 2
        Me.BtnVerDetalhesINSSNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerDetalhesINSSNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerDetalhesINSSNovo.ForeColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesINSSNovo.Location = New System.Drawing.Point(6, 197)
        Me.BtnVerDetalhesINSSNovo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnVerDetalhesINSSNovo.Name = "BtnVerDetalhesINSSNovo"
        Me.BtnVerDetalhesINSSNovo.Size = New System.Drawing.Size(102, 37)
        Me.BtnVerDetalhesINSSNovo.TabIndex = 23
        Me.BtnVerDetalhesINSSNovo.Text = "Detalhes"
        Me.BtnVerDetalhesINSSNovo.UseVisualStyleBackColor = True
        '
        'MotivoParcINSSNovoLabel
        '
        Me.MotivoParcINSSNovoLabel.AutoSize = True
        Me.MotivoParcINSSNovoLabel.Location = New System.Drawing.Point(560, 19)
        Me.MotivoParcINSSNovoLabel.Name = "MotivoParcINSSNovoLabel"
        Me.MotivoParcINSSNovoLabel.Size = New System.Drawing.Size(57, 18)
        Me.MotivoParcINSSNovoLabel.TabIndex = 22
        Me.MotivoParcINSSNovoLabel.Text = "Motivo:"
        '
        'ParcelaEnviadaINSSNovoTextBox
        '
        Me.ParcelaEnviadaINSSNovoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelaEnviadaINSSNovo", True))
        Me.ParcelaEnviadaINSSNovoTextBox.Location = New System.Drawing.Point(317, 174)
        Me.ParcelaEnviadaINSSNovoTextBox.Name = "ParcelaEnviadaINSSNovoTextBox"
        Me.ParcelaEnviadaINSSNovoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ParcelaEnviadaINSSNovoTextBox.TabIndex = 20
        '
        'QtoParcelasINSSNovoTextBox
        '
        Me.QtoParcelasINSSNovoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "QtoParcelasINSSNovo", True))
        Me.QtoParcelasINSSNovoTextBox.Location = New System.Drawing.Point(244, 77)
        Me.QtoParcelasINSSNovoTextBox.Name = "QtoParcelasINSSNovoTextBox"
        Me.QtoParcelasINSSNovoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.QtoParcelasINSSNovoTextBox.TabIndex = 19
        '
        'BtnRegistrarEnvioINSSnovo
        '
        Me.BtnRegistrarEnvioINSSnovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistrarEnvioINSSnovo.FlatAppearance.BorderSize = 2
        Me.BtnRegistrarEnvioINSSnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarEnvioINSSnovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioINSSnovo.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnRegistrarEnvioINSSnovo.Location = New System.Drawing.Point(426, 168)
        Me.BtnRegistrarEnvioINSSnovo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnRegistrarEnvioINSSnovo.Name = "BtnRegistrarEnvioINSSnovo"
        Me.BtnRegistrarEnvioINSSnovo.Size = New System.Drawing.Size(132, 37)
        Me.BtnRegistrarEnvioINSSnovo.TabIndex = 18
        Me.BtnRegistrarEnvioINSSnovo.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioINSSnovo.UseVisualStyleBackColor = True
        '
        'TemDataEntradaINSSNovoCheckBox
        '
        Me.TemDataEntradaINSSNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEntradaINSSNovo", True))
        Me.TemDataEntradaINSSNovoCheckBox.Location = New System.Drawing.Point(9, 17)
        Me.TemDataEntradaINSSNovoCheckBox.Name = "TemDataEntradaINSSNovoCheckBox"
        Me.TemDataEntradaINSSNovoCheckBox.Size = New System.Drawing.Size(234, 24)
        Me.TemDataEntradaINSSNovoCheckBox.TabIndex = 17
        Me.TemDataEntradaINSSNovoCheckBox.Text = "Data Entrada do Parcelamento:"
        Me.TemDataEntradaINSSNovoCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataFimINSSNovoCheckBox
        '
        Me.TemDataFimINSSNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataFimINSSNovo", True))
        Me.TemDataFimINSSNovoCheckBox.Location = New System.Drawing.Point(68, 107)
        Me.TemDataFimINSSNovoCheckBox.Name = "TemDataFimINSSNovoCheckBox"
        Me.TemDataFimINSSNovoCheckBox.Size = New System.Drawing.Size(174, 24)
        Me.TemDataFimINSSNovoCheckBox.TabIndex = 15
        Me.TemDataFimINSSNovoCheckBox.Text = "Fim do Parcelamento:"
        Me.TemDataFimINSSNovoCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataEnvioINSSNovoCheckBox
        '
        Me.TemDataEnvioINSSNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEnvioINSSNovo", True))
        Me.TemDataEnvioINSSNovoCheckBox.Location = New System.Drawing.Point(124, 137)
        Me.TemDataEnvioINSSNovoCheckBox.Name = "TemDataEnvioINSSNovoCheckBox"
        Me.TemDataEnvioINSSNovoCheckBox.Size = New System.Drawing.Size(118, 24)
        Me.TemDataEnvioINSSNovoCheckBox.TabIndex = 13
        Me.TemDataEnvioINSSNovoCheckBox.Text = "Mes Enviado:"
        Me.TemDataEnvioINSSNovoCheckBox.UseVisualStyleBackColor = True
        '
        'MesEnviadoINSSNovoDateTimePicker
        '
        Me.MesEnviadoINSSNovoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoINSSNovo", True))
        Me.MesEnviadoINSSNovoDateTimePicker.Location = New System.Drawing.Point(244, 137)
        Me.MesEnviadoINSSNovoDateTimePicker.Name = "MesEnviadoINSSNovoDateTimePicker"
        Me.MesEnviadoINSSNovoDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.MesEnviadoINSSNovoDateTimePicker.TabIndex = 11
        '
        'MotivoParcINSSNovoRichTextBox
        '
        Me.MotivoParcINSSNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcINSSNovo", True))
        Me.MotivoParcINSSNovoRichTextBox.Location = New System.Drawing.Point(618, 17)
        Me.MotivoParcINSSNovoRichTextBox.Name = "MotivoParcINSSNovoRichTextBox"
        Me.MotivoParcINSSNovoRichTextBox.Size = New System.Drawing.Size(165, 220)
        Me.MotivoParcINSSNovoRichTextBox.TabIndex = 9
        Me.MotivoParcINSSNovoRichTextBox.Text = ""
        '
        'FinalizadoINSSNovoDateTimePicker
        '
        Me.FinalizadoINSSNovoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "FinalizadoINSSNovo", True))
        Me.FinalizadoINSSNovoDateTimePicker.Location = New System.Drawing.Point(244, 107)
        Me.FinalizadoINSSNovoDateTimePicker.Name = "FinalizadoINSSNovoDateTimePicker"
        Me.FinalizadoINSSNovoDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.FinalizadoINSSNovoDateTimePicker.TabIndex = 7
        '
        'INSSNovoProtTextBox
        '
        Me.INSSNovoProtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSNovoProt", True))
        Me.INSSNovoProtTextBox.Location = New System.Drawing.Point(244, 47)
        Me.INSSNovoProtTextBox.Name = "INSSNovoProtTextBox"
        Me.INSSNovoProtTextBox.Size = New System.Drawing.Size(313, 24)
        Me.INSSNovoProtTextBox.TabIndex = 3
        '
        'DataParcelINSSnovoDateTimePicker
        '
        Me.DataParcelINSSnovoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcelINSSnovo", True))
        Me.DataParcelINSSnovoDateTimePicker.Location = New System.Drawing.Point(244, 17)
        Me.DataParcelINSSnovoDateTimePicker.Name = "DataParcelINSSnovoDateTimePicker"
        Me.DataParcelINSSnovoDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.DataParcelINSSnovoDateTimePicker.TabIndex = 1
        '
        'TabPageINSSNovoHistorico
        '
        Me.TabPageINSSNovoHistorico.AutoScroll = True
        Me.TabPageINSSNovoHistorico.Controls.Add(Me.HistoricoEnvioINSSNovoRichTextBox)
        Me.TabPageINSSNovoHistorico.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSNovoHistorico.Name = "TabPageINSSNovoHistorico"
        Me.TabPageINSSNovoHistorico.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSNovoHistorico.Size = New System.Drawing.Size(801, 247)
        Me.TabPageINSSNovoHistorico.TabIndex = 1
        Me.TabPageINSSNovoHistorico.Text = "Histórico"
        Me.TabPageINSSNovoHistorico.UseVisualStyleBackColor = True
        '
        'HistoricoEnvioINSSNovoRichTextBox
        '
        Me.HistoricoEnvioINSSNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSNovo", True))
        Me.HistoricoEnvioINSSNovoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioINSSNovoRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioINSSNovoRichTextBox.Name = "HistoricoEnvioINSSNovoRichTextBox"
        Me.HistoricoEnvioINSSNovoRichTextBox.ReadOnly = True
        Me.HistoricoEnvioINSSNovoRichTextBox.Size = New System.Drawing.Size(795, 241)
        Me.HistoricoEnvioINSSNovoRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSNovoRichTextBox.Text = ""
        '
        'TabPageINSSNovoObservacoes
        '
        Me.TabPageINSSNovoObservacoes.Controls.Add(Me.INSSNovoObsRichTextBox)
        Me.TabPageINSSNovoObservacoes.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSNovoObservacoes.Name = "TabPageINSSNovoObservacoes"
        Me.TabPageINSSNovoObservacoes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSNovoObservacoes.Size = New System.Drawing.Size(801, 247)
        Me.TabPageINSSNovoObservacoes.TabIndex = 2
        Me.TabPageINSSNovoObservacoes.Text = "Detalhes"
        Me.TabPageINSSNovoObservacoes.UseVisualStyleBackColor = True
        '
        'INSSNovoObsRichTextBox
        '
        Me.INSSNovoObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSNovoObs", True))
        Me.INSSNovoObsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.INSSNovoObsRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.INSSNovoObsRichTextBox.Name = "INSSNovoObsRichTextBox"
        Me.INSSNovoObsRichTextBox.Size = New System.Drawing.Size(795, 241)
        Me.INSSNovoObsRichTextBox.TabIndex = 6
        Me.INSSNovoObsRichTextBox.Text = ""
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
        Me.TabControlInssProcuradoria.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlInssProcuradoria.Controls.Add(Me.TabPageINSSProcuradoriaGeral)
        Me.TabControlInssProcuradoria.Controls.Add(Me.TabPageINSSProcuradoriaHistorico)
        Me.TabControlInssProcuradoria.Controls.Add(Me.TabPageINSSProcuradoriaObservacoes)
        Me.TabControlInssProcuradoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlInssProcuradoria.Location = New System.Drawing.Point(0, 0)
        Me.TabControlInssProcuradoria.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlInssProcuradoria.Name = "TabControlInssProcuradoria"
        Me.TabControlInssProcuradoria.SelectedIndex = 0
        Me.TabControlInssProcuradoria.Size = New System.Drawing.Size(809, 281)
        Me.TabControlInssProcuradoria.TabIndex = 1
        '
        'TabPageINSSProcuradoriaGeral
        '
        Me.TabPageINSSProcuradoriaGeral.AutoScroll = True
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.BtnVerDetalhesINSSProcuradoria)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.MotivoParcINSSProcLabel)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(ParcelaEnviadaINSSProcuradoriaLabel)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.ParcelaEnviadaINSSProcuradoriaTextBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(QtoParcelasINSSProcuradoriaLabel)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.QtoParcelasINSSProcuradoriaTextBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.BtnRegistrarEnvioINSSProcuradoria)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.TemDataEntradaINSSProcuCheckBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.TemDataFimINSSProcurCheckBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.TemDataEnvioINSSProcurCheckBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.MesEnviadoINSSProcDateTimePicker)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.MotivoParcINSSProcRichTextBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.FinalizadoINSSProcDateTimePicker)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(INSSProcProtLabel)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.INSSProcProtTextBox)
        Me.TabPageINSSProcuradoriaGeral.Controls.Add(Me.DataParcelINSSprocDateTimePicker)
        Me.TabPageINSSProcuradoriaGeral.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSProcuradoriaGeral.Name = "TabPageINSSProcuradoriaGeral"
        Me.TabPageINSSProcuradoriaGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSProcuradoriaGeral.Size = New System.Drawing.Size(801, 247)
        Me.TabPageINSSProcuradoriaGeral.TabIndex = 0
        Me.TabPageINSSProcuradoriaGeral.Text = "Geral"
        Me.TabPageINSSProcuradoriaGeral.UseVisualStyleBackColor = True
        '
        'BtnVerDetalhesINSSProcuradoria
        '
        Me.BtnVerDetalhesINSSProcuradoria.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesINSSProcuradoria.FlatAppearance.BorderSize = 2
        Me.BtnVerDetalhesINSSProcuradoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerDetalhesINSSProcuradoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerDetalhesINSSProcuradoria.ForeColor = System.Drawing.Color.Blue
        Me.BtnVerDetalhesINSSProcuradoria.Location = New System.Drawing.Point(6, 197)
        Me.BtnVerDetalhesINSSProcuradoria.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnVerDetalhesINSSProcuradoria.Name = "BtnVerDetalhesINSSProcuradoria"
        Me.BtnVerDetalhesINSSProcuradoria.Size = New System.Drawing.Size(102, 37)
        Me.BtnVerDetalhesINSSProcuradoria.TabIndex = 22
        Me.BtnVerDetalhesINSSProcuradoria.Text = "Detalhes"
        Me.BtnVerDetalhesINSSProcuradoria.UseVisualStyleBackColor = True
        '
        'MotivoParcINSSProcLabel
        '
        Me.MotivoParcINSSProcLabel.AutoSize = True
        Me.MotivoParcINSSProcLabel.Location = New System.Drawing.Point(560, 19)
        Me.MotivoParcINSSProcLabel.Name = "MotivoParcINSSProcLabel"
        Me.MotivoParcINSSProcLabel.Size = New System.Drawing.Size(57, 18)
        Me.MotivoParcINSSProcLabel.TabIndex = 21
        Me.MotivoParcINSSProcLabel.Text = "Motivo:"
        '
        'ParcelaEnviadaINSSProcuradoriaTextBox
        '
        Me.ParcelaEnviadaINSSProcuradoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelaEnviadaINSSProcuradoria", True))
        Me.ParcelaEnviadaINSSProcuradoriaTextBox.Location = New System.Drawing.Point(317, 174)
        Me.ParcelaEnviadaINSSProcuradoriaTextBox.Name = "ParcelaEnviadaINSSProcuradoriaTextBox"
        Me.ParcelaEnviadaINSSProcuradoriaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ParcelaEnviadaINSSProcuradoriaTextBox.TabIndex = 20
        '
        'QtoParcelasINSSProcuradoriaTextBox
        '
        Me.QtoParcelasINSSProcuradoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "QtoParcelasINSSProcuradoria", True))
        Me.QtoParcelasINSSProcuradoriaTextBox.Location = New System.Drawing.Point(244, 77)
        Me.QtoParcelasINSSProcuradoriaTextBox.Name = "QtoParcelasINSSProcuradoriaTextBox"
        Me.QtoParcelasINSSProcuradoriaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.QtoParcelasINSSProcuradoriaTextBox.TabIndex = 19
        '
        'BtnRegistrarEnvioINSSProcuradoria
        '
        Me.BtnRegistrarEnvioINSSProcuradoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistrarEnvioINSSProcuradoria.FlatAppearance.BorderSize = 2
        Me.BtnRegistrarEnvioINSSProcuradoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarEnvioINSSProcuradoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioINSSProcuradoria.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnRegistrarEnvioINSSProcuradoria.Location = New System.Drawing.Point(426, 168)
        Me.BtnRegistrarEnvioINSSProcuradoria.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnRegistrarEnvioINSSProcuradoria.Name = "BtnRegistrarEnvioINSSProcuradoria"
        Me.BtnRegistrarEnvioINSSProcuradoria.Size = New System.Drawing.Size(132, 37)
        Me.BtnRegistrarEnvioINSSProcuradoria.TabIndex = 18
        Me.BtnRegistrarEnvioINSSProcuradoria.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioINSSProcuradoria.UseVisualStyleBackColor = True
        '
        'TemDataEntradaINSSProcuCheckBox
        '
        Me.TemDataEntradaINSSProcuCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEntradaINSSProcu", True))
        Me.TemDataEntradaINSSProcuCheckBox.Location = New System.Drawing.Point(9, 17)
        Me.TemDataEntradaINSSProcuCheckBox.Name = "TemDataEntradaINSSProcuCheckBox"
        Me.TemDataEntradaINSSProcuCheckBox.Size = New System.Drawing.Size(234, 24)
        Me.TemDataEntradaINSSProcuCheckBox.TabIndex = 17
        Me.TemDataEntradaINSSProcuCheckBox.Text = "Data Entrada do Parcelamento:"
        Me.TemDataEntradaINSSProcuCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataFimINSSProcurCheckBox
        '
        Me.TemDataFimINSSProcurCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataFimINSSProcur", True))
        Me.TemDataFimINSSProcurCheckBox.Location = New System.Drawing.Point(68, 107)
        Me.TemDataFimINSSProcurCheckBox.Name = "TemDataFimINSSProcurCheckBox"
        Me.TemDataFimINSSProcurCheckBox.Size = New System.Drawing.Size(174, 24)
        Me.TemDataFimINSSProcurCheckBox.TabIndex = 15
        Me.TemDataFimINSSProcurCheckBox.Text = "Fim do Parcelamento:"
        Me.TemDataFimINSSProcurCheckBox.UseVisualStyleBackColor = True
        '
        'TemDataEnvioINSSProcurCheckBox
        '
        Me.TemDataEnvioINSSProcurCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "TemDataEnvioINSSProcur", True))
        Me.TemDataEnvioINSSProcurCheckBox.Location = New System.Drawing.Point(124, 137)
        Me.TemDataEnvioINSSProcurCheckBox.Name = "TemDataEnvioINSSProcurCheckBox"
        Me.TemDataEnvioINSSProcurCheckBox.Size = New System.Drawing.Size(118, 24)
        Me.TemDataEnvioINSSProcurCheckBox.TabIndex = 13
        Me.TemDataEnvioINSSProcurCheckBox.Text = "Mes Enviado:"
        Me.TemDataEnvioINSSProcurCheckBox.UseVisualStyleBackColor = True
        '
        'MesEnviadoINSSProcDateTimePicker
        '
        Me.MesEnviadoINSSProcDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoINSSProc", True))
        Me.MesEnviadoINSSProcDateTimePicker.Location = New System.Drawing.Point(244, 137)
        Me.MesEnviadoINSSProcDateTimePicker.Name = "MesEnviadoINSSProcDateTimePicker"
        Me.MesEnviadoINSSProcDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.MesEnviadoINSSProcDateTimePicker.TabIndex = 11
        '
        'MotivoParcINSSProcRichTextBox
        '
        Me.MotivoParcINSSProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcINSSProc", True))
        Me.MotivoParcINSSProcRichTextBox.Location = New System.Drawing.Point(618, 17)
        Me.MotivoParcINSSProcRichTextBox.Name = "MotivoParcINSSProcRichTextBox"
        Me.MotivoParcINSSProcRichTextBox.Size = New System.Drawing.Size(165, 220)
        Me.MotivoParcINSSProcRichTextBox.TabIndex = 9
        Me.MotivoParcINSSProcRichTextBox.Text = ""
        '
        'FinalizadoINSSProcDateTimePicker
        '
        Me.FinalizadoINSSProcDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "FinalizadoINSSProc", True))
        Me.FinalizadoINSSProcDateTimePicker.Location = New System.Drawing.Point(244, 107)
        Me.FinalizadoINSSProcDateTimePicker.Name = "FinalizadoINSSProcDateTimePicker"
        Me.FinalizadoINSSProcDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.FinalizadoINSSProcDateTimePicker.TabIndex = 7
        '
        'INSSProcProtTextBox
        '
        Me.INSSProcProtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSProcProt", True))
        Me.INSSProcProtTextBox.Location = New System.Drawing.Point(244, 47)
        Me.INSSProcProtTextBox.Name = "INSSProcProtTextBox"
        Me.INSSProcProtTextBox.Size = New System.Drawing.Size(313, 24)
        Me.INSSProcProtTextBox.TabIndex = 5
        '
        'DataParcelINSSprocDateTimePicker
        '
        Me.DataParcelINSSprocDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcelINSSproc", True))
        Me.DataParcelINSSprocDateTimePicker.Location = New System.Drawing.Point(244, 17)
        Me.DataParcelINSSprocDateTimePicker.Name = "DataParcelINSSprocDateTimePicker"
        Me.DataParcelINSSprocDateTimePicker.Size = New System.Drawing.Size(313, 24)
        Me.DataParcelINSSprocDateTimePicker.TabIndex = 1
        '
        'TabPageINSSProcuradoriaHistorico
        '
        Me.TabPageINSSProcuradoriaHistorico.Controls.Add(Me.HistoricoEnvioINSSProcRichTextBox)
        Me.TabPageINSSProcuradoriaHistorico.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSProcuradoriaHistorico.Name = "TabPageINSSProcuradoriaHistorico"
        Me.TabPageINSSProcuradoriaHistorico.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSProcuradoriaHistorico.Size = New System.Drawing.Size(801, 247)
        Me.TabPageINSSProcuradoriaHistorico.TabIndex = 1
        Me.TabPageINSSProcuradoriaHistorico.Text = "Histórico"
        Me.TabPageINSSProcuradoriaHistorico.UseVisualStyleBackColor = True
        '
        'HistoricoEnvioINSSProcRichTextBox
        '
        Me.HistoricoEnvioINSSProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSProc", True))
        Me.HistoricoEnvioINSSProcRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricoEnvioINSSProcRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoricoEnvioINSSProcRichTextBox.Name = "HistoricoEnvioINSSProcRichTextBox"
        Me.HistoricoEnvioINSSProcRichTextBox.ReadOnly = True
        Me.HistoricoEnvioINSSProcRichTextBox.Size = New System.Drawing.Size(795, 241)
        Me.HistoricoEnvioINSSProcRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSProcRichTextBox.Text = ""
        '
        'TabPageINSSProcuradoriaObservacoes
        '
        Me.TabPageINSSProcuradoriaObservacoes.Controls.Add(Me.INSSProcObsRichTextBox)
        Me.TabPageINSSProcuradoriaObservacoes.Location = New System.Drawing.Point(4, 30)
        Me.TabPageINSSProcuradoriaObservacoes.Name = "TabPageINSSProcuradoriaObservacoes"
        Me.TabPageINSSProcuradoriaObservacoes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSProcuradoriaObservacoes.Size = New System.Drawing.Size(801, 247)
        Me.TabPageINSSProcuradoriaObservacoes.TabIndex = 2
        Me.TabPageINSSProcuradoriaObservacoes.Text = "Detalhes"
        Me.TabPageINSSProcuradoriaObservacoes.UseVisualStyleBackColor = True
        '
        'INSSProcObsRichTextBox
        '
        Me.INSSProcObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSProcObs", True))
        Me.INSSProcObsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.INSSProcObsRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.INSSProcObsRichTextBox.Name = "INSSProcObsRichTextBox"
        Me.INSSProcObsRichTextBox.Size = New System.Drawing.Size(795, 241)
        Me.INSSProcObsRichTextBox.TabIndex = 7
        Me.INSSProcObsRichTextBox.Text = ""
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
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Black
        Me.BtnExcluir.Location = New System.Drawing.Point(12, 159)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(132, 37)
        Me.BtnExcluir.TabIndex = 9
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'GroupBoxSalvando
        '
        Me.GroupBoxSalvando.Controls.Add(Me.ProgressBarSalvando)
        Me.GroupBoxSalvando.Controls.Add(Me.LabelSalvando)
        Me.GroupBoxSalvando.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxSalvando.Location = New System.Drawing.Point(825, 351)
        Me.GroupBoxSalvando.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxSalvando.Name = "GroupBoxSalvando"
        Me.GroupBoxSalvando.Size = New System.Drawing.Size(161, 340)
        Me.GroupBoxSalvando.TabIndex = 59
        Me.GroupBoxSalvando.TabStop = False
        '
        'ProgressBarSalvando
        '
        Me.ProgressBarSalvando.Location = New System.Drawing.Point(6, 55)
        Me.ProgressBarSalvando.Name = "ProgressBarSalvando"
        Me.ProgressBarSalvando.Size = New System.Drawing.Size(144, 35)
        Me.ProgressBarSalvando.TabIndex = 1
        '
        'LabelSalvando
        '
        Me.LabelSalvando.AutoSize = True
        Me.LabelSalvando.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSalvando.Location = New System.Drawing.Point(7, 32)
        Me.LabelSalvando.Name = "LabelSalvando"
        Me.LabelSalvando.Size = New System.Drawing.Size(57, 20)
        Me.LabelSalvando.TabIndex = 0
        Me.LabelSalvando.Text = "Label1"
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
        Me.Geral.ResumeLayout(False)
        Me.Geral.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Endereço.ResumeLayout(False)
        Me.Endereço.PerformLayout()
        Me.FormadeEnvio.ResumeLayout(False)
        Me.FormadeEnvio.PerformLayout()
        Me.Responsável.ResumeLayout(False)
        Me.Responsável.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControleParcelamentos.ResumeLayout(False)
        Me.TabPageMEI.ResumeLayout(False)
        Me.TabControlMEI.ResumeLayout(False)
        Me.TabPageMEIGeral.ResumeLayout(False)
        Me.TabPageMEIGeral.PerformLayout()
        Me.TabPageMEIHistorico.ResumeLayout(False)
        Me.TabPageMEIObservacoes.ResumeLayout(False)
        Me.TabPageINSSAntigo.ResumeLayout(False)
        Me.TabControlInssAntigo.ResumeLayout(False)
        Me.TabPageINSSAntigoGeral.ResumeLayout(False)
        Me.TabPageINSSAntigoGeral.PerformLayout()
        Me.TabPageINSSAntigoHistorico.ResumeLayout(False)
        Me.TabPageINSSAntigoObservacoes.ResumeLayout(False)
        Me.TabPageINSSNovo.ResumeLayout(False)
        Me.TabControlInssNovo.ResumeLayout(False)
        Me.TabPageINSSNovoGeral.ResumeLayout(False)
        Me.TabPageINSSNovoGeral.PerformLayout()
        Me.TabPageINSSNovoHistorico.ResumeLayout(False)
        Me.TabPageINSSNovoObservacoes.ResumeLayout(False)
        Me.TabPageINSSProcuradoria.ResumeLayout(False)
        Me.TabControlInssProcuradoria.ResumeLayout(False)
        Me.TabPageINSSProcuradoriaGeral.ResumeLayout(False)
        Me.TabPageINSSProcuradoriaGeral.PerformLayout()
        Me.TabPageINSSProcuradoriaHistorico.ResumeLayout(False)
        Me.TabPageINSSProcuradoriaObservacoes.ResumeLayout(False)
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.GroupBoxSalvando.ResumeLayout(False)
        Me.GroupBoxSalvando.PerformLayout()
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
    Friend WithEvents Geral As TabPage
    Friend WithEvents Endereço As TabPage
    Friend WithEvents FormadeEnvio As TabPage
    Friend WithEvents Responsável As TabPage
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
    Friend WithEvents TabControleParcelamentos As TabControl
    Friend WithEvents TabPageMEI As TabPage
    Friend WithEvents TabPageINSSAntigo As TabPage
    Friend WithEvents TemDataLembreteCheckBox As CheckBox
    Friend WithEvents TabPageINSSNovo As TabPage
    Friend WithEvents TabPageINSSProcuradoria As TabPage
    Friend WithEvents TabControlMEI As TabControl
    Friend WithEvents TabPageMEIGeral As TabPage
    Friend WithEvents TabPageMEIHistorico As TabPage
    Friend WithEvents TabControlInssAntigo As TabControl
    Friend WithEvents TabPageINSSAntigoGeral As TabPage
    Friend WithEvents TabPageINSSAntigoHistorico As TabPage
    Friend WithEvents TabControlInssNovo As TabControl
    Friend WithEvents TabPageINSSNovoGeral As TabPage
    Friend WithEvents TabPageINSSNovoHistorico As TabPage
    Friend WithEvents TabControlInssProcuradoria As TabControl
    Friend WithEvents TabPageINSSProcuradoriaGeral As TabPage
    Friend WithEvents TabPageINSSProcuradoriaHistorico As TabPage
    Friend WithEvents HistoricoEnvioMEIRichTextBox As RichTextBox
    Friend WithEvents HistoricoEnvioINSSAntigoRichTextBox As RichTextBox
    Friend WithEvents HistoricoEnvioINSSNovoRichTextBox As RichTextBox
    Friend WithEvents HistoricoEnvioINSSProcRichTextBox As RichTextBox
    Friend WithEvents DataFimParcMEIDateTimePicker As DateTimePicker
    Friend WithEvents MotivoParcMEIRichTextBox As RichTextBox
    Friend WithEvents DataParcMEIDateTimePicker As DateTimePicker
    Friend WithEvents MesEnviadoMEIDateTimePicker As DateTimePicker
    Friend WithEvents MeiProtocoloTextBox As TextBox
    Friend WithEvents TemDataFimMEICheckBox As CheckBox
    Friend WithEvents DataParcelINSSantigoDateTimePicker As DateTimePicker
    Friend WithEvents INSSAntigoProtTextBox As TextBox
    Friend WithEvents MesEnviadoINSSAntigoDateTimePicker As DateTimePicker
    Friend WithEvents MotivoParcINSSAntigoRichTextBox As RichTextBox
    Friend WithEvents FinalizadoINSSAntigoDateTimePicker As DateTimePicker
    Friend WithEvents TemDataFimINSSAntigoCheckBox As CheckBox
    Friend WithEvents TemDataEnvioINSSAntigoCheckBox As CheckBox
    Friend WithEvents TemDataEnvioMEICheckBox As CheckBox
    Friend WithEvents TemDataEntradaMEICheckBox As CheckBox
    Friend WithEvents TemDataEntradaINSSAntigoCheckBox As CheckBox
    Friend WithEvents MesEnviadoINSSNovoDateTimePicker As DateTimePicker
    Friend WithEvents MotivoParcINSSNovoRichTextBox As RichTextBox
    Friend WithEvents FinalizadoINSSNovoDateTimePicker As DateTimePicker
    Friend WithEvents INSSNovoProtTextBox As TextBox
    Friend WithEvents DataParcelINSSnovoDateTimePicker As DateTimePicker
    Friend WithEvents TemDataEnvioINSSNovoCheckBox As CheckBox
    Friend WithEvents TemDataEntradaINSSNovoCheckBox As CheckBox
    Friend WithEvents TemDataFimINSSNovoCheckBox As CheckBox
    Friend WithEvents FinalizadoParcelamentosDateTimePicker As DateTimePicker
    Friend WithEvents FinalizadoINSSProcDateTimePicker As DateTimePicker
    Friend WithEvents INSSProcProtTextBox As TextBox
    Friend WithEvents DataParcelINSSprocDateTimePicker As DateTimePicker
    Friend WithEvents MesEnviadoINSSProcDateTimePicker As DateTimePicker
    Friend WithEvents MotivoParcINSSProcRichTextBox As RichTextBox
    Friend WithEvents TemDataEntradaINSSProcuCheckBox As CheckBox
    Friend WithEvents TemDataFimINSSProcurCheckBox As CheckBox
    Friend WithEvents TemDataEnvioINSSProcurCheckBox As CheckBox
    Friend WithEvents TemDataFimParcelamentoCheckBox As CheckBox
    Friend WithEvents BtnRegistrarEnvioMEI As Button
    Friend WithEvents TabPageMEIObservacoes As TabPage
    Friend WithEvents GeralMEIRichTextBox As RichTextBox
    Friend WithEvents BtnRegistrarEnvioINSSantigo As Button
    Friend WithEvents TabPageINSSAntigoObservacoes As TabPage
    Friend WithEvents INSSAntigoObsRichTextBox As RichTextBox
    Friend WithEvents BtnRegistrarEnvioINSSnovo As Button
    Friend WithEvents TabPageINSSNovoObservacoes As TabPage
    Friend WithEvents INSSNovoObsRichTextBox As RichTextBox
    Friend WithEvents BtnRegistrarEnvioINSSProcuradoria As Button
    Friend WithEvents TabPageINSSProcuradoriaObservacoes As TabPage
    Friend WithEvents INSSProcObsRichTextBox As RichTextBox
    Friend WithEvents GroupBoxSalvando As GroupBox
    Friend WithEvents LabelSalvando As Label
    Friend WithEvents ProgressBarSalvando As ProgressBar
    Friend WithEvents ParcelaEnviadaMEITextBox As TextBox
    Friend WithEvents QtoParcelasMEITextBox As TextBox
    Friend WithEvents QtoParcelasINSSAntigoTextBox As TextBox
    Friend WithEvents ParcelaEnviadaINSSAntigoTextBox As TextBox
    Friend WithEvents ParcelaEnviadaINSSNovoTextBox As TextBox
    Friend WithEvents QtoParcelasINSSNovoTextBox As TextBox
    Friend WithEvents ParcelaEnviadaINSSProcuradoriaTextBox As TextBox
    Friend WithEvents QtoParcelasINSSProcuradoriaTextBox As TextBox
    Friend WithEvents MotivoParcMEILabel As Label
    Friend WithEvents MotivoParcINSSAntigoLabel As Label
    Friend WithEvents MotivoParcINSSNovoLabel As Label
    Friend WithEvents MotivoParcINSSProcLabel As Label
    Friend WithEvents BtnVerDetalhesMEI As Button
    Friend WithEvents BtnVerDetalhesINSSAntigo As Button
    Friend WithEvents BtnVerDetalhesINSSNovo As Button
    Friend WithEvents BtnVerDetalhesINSSProcuradoria As Button
End Class
