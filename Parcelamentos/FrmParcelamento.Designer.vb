<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmParcelamento
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
        Dim SocioLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim SenhaGovLabel As System.Windows.Forms.Label
        Dim FormaDeEnvioLabel As System.Windows.Forms.Label
        Dim ResponsavelLabel As System.Windows.Forms.Label
        Dim WhatsappLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim DataCriacaoLabel As System.Windows.Forms.Label
        Dim DataLembreteLabel As System.Windows.Forms.Label
        Dim DataSolicProcLabel As System.Windows.Forms.Label
        Dim DataEnviaProcLabel As System.Windows.Forms.Label
        Dim ProtprocLabel As System.Windows.Forms.Label
        Dim TotalParcProcLabel As System.Windows.Forms.Label
        Dim ParcelEnvINSSProcLabel As System.Windows.Forms.Label
        Dim DataSolicNovoLabel As System.Windows.Forms.Label
        Dim ProtNovoLabel As System.Windows.Forms.Label
        Dim TotalParcNovoLabel As System.Windows.Forms.Label
        Dim DataEnvioNovoLabel As System.Windows.Forms.Label
        Dim ParcelEnvINSSNovLabel As System.Windows.Forms.Label
        Dim DataSolicAntigoLabel As System.Windows.Forms.Label
        Dim DataEnviaAntigoLabel As System.Windows.Forms.Label
        Dim ProtAntigoLabel As System.Windows.Forms.Label
        Dim TotalParcAntigoLabel As System.Windows.Forms.Label
        Dim ParcelEnvINSSAntLabel As System.Windows.Forms.Label
        Dim DataSolicMEILabel As System.Windows.Forms.Label
        Dim DataEnviaMEILabel As System.Windows.Forms.Label
        Dim ProtMEILabel As System.Windows.Forms.Label
        Dim TotalParcMEILabel As System.Windows.Forms.Label
        Dim ParcelEnvMEILabel As System.Windows.Forms.Label
        Dim FinalizadoEmpresaLabel As System.Windows.Forms.Label
        Dim FinalizadoMEILabel As System.Windows.Forms.Label
        Dim FinalizadoINSSAntLabel As System.Windows.Forms.Label
        Dim FinalizadoINSSNovLabel As System.Windows.Forms.Label
        Dim FinalizadoINSSProcLabel As System.Windows.Forms.Label
        Dim FinalizadoMesGeralLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParcelamento))
        Me.ProgressBarSalvar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.ComboBoxBuscarRazaoSocial = New System.Windows.Forms.ComboBox()
        Me.RazaoSocialTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControlGeral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnConsultaSimplesNacional = New System.Windows.Forms.Button()
        Me.BtnDataCriacao = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FinalizadoMesGeralComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.BtnCopiarCNPJ = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MEICheckBox = New System.Windows.Forms.CheckBox()
        Me.InssAntigoCheckBox = New System.Windows.Forms.CheckBox()
        Me.InssNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.InssProcurCheckBox = New System.Windows.Forms.CheckBox()
        Me.LabelDataFinalizado = New System.Windows.Forms.Label()
        Me.FinalizadoEmpresaComboBox = New System.Windows.Forms.ComboBox()
        Me.DataFinalizadoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataLembreteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataCriacaoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WhatsappMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.FormaDeEnvioComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SenhaGovTextBox = New System.Windows.Forms.TextBox()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SocioTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabControlParcelamento = New System.Windows.Forms.TabControl()
        Me.TabPageMei = New System.Windows.Forms.TabPage()
        Me.TabControlMei = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.BtnAgoraMEI = New System.Windows.Forms.Button()
        Me.BtnRegistrarMEI = New System.Windows.Forms.Button()
        Me.LblFinalizadoDataMEI = New System.Windows.Forms.Label()
        Me.LabelMotivoMEI = New System.Windows.Forms.Label()
        Me.FinalizadoMEIComboBox = New System.Windows.Forms.ComboBox()
        Me.ParcelEnvMEITextBox = New System.Windows.Forms.TextBox()
        Me.TotalParcMEITextBox = New System.Windows.Forms.TextBox()
        Me.ProtMEITextBox = New System.Windows.Forms.TextBox()
        Me.MotivoMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataFinalMEIMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataEnviaMEIMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataSolicMEIMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.EnviaParcMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSAntigo = New System.Windows.Forms.TabPage()
        Me.TabControlINSSAntigo = New System.Windows.Forms.TabControl()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.ProtAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnAgoraINSSAntigo = New System.Windows.Forms.Button()
        Me.BtnRegistrarINSSAntigo = New System.Windows.Forms.Button()
        Me.LblFinalizadoDataINSSAntigo = New System.Windows.Forms.Label()
        Me.LabelMotivoINSSAntigo = New System.Windows.Forms.Label()
        Me.FinalizadoINSSAntComboBox = New System.Windows.Forms.ComboBox()
        Me.ParcelEnvINSSAntTextBox = New System.Windows.Forms.TextBox()
        Me.TotalParcAntigoTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataFinalAntigoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataEnviaAntigoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataSolicAntigoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.EnviaParcAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSNovo = New System.Windows.Forms.TabPage()
        Me.TabControlINSSNovo = New System.Windows.Forms.TabControl()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.ProtNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnAgoraINSSNovo = New System.Windows.Forms.Button()
        Me.BtnRegistrarINSSNovo = New System.Windows.Forms.Button()
        Me.LblFinalizadoDataINSSNovo = New System.Windows.Forms.Label()
        Me.LabelMotivoINSSNovo = New System.Windows.Forms.Label()
        Me.FinalizadoINSSNovComboBox = New System.Windows.Forms.ComboBox()
        Me.ParcelEnvINSSNovTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataFinalNovoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataEnvioNovoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TotalParcNovoTextBox = New System.Windows.Forms.TextBox()
        Me.DataSolicNovoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.EnviaParcNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPageINSSProcuradoria = New System.Windows.Forms.TabPage()
        Me.TabControlINSSProcuradoria = New System.Windows.Forms.TabControl()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.ProtprocRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnAgoraINSSProcuradoria = New System.Windows.Forms.Button()
        Me.BtnRegistrarINSSProcuradoria = New System.Windows.Forms.Button()
        Me.LblFinalizadoDataINSSProcuradoria = New System.Windows.Forms.Label()
        Me.LabelMotivoINSSProc = New System.Windows.Forms.Label()
        Me.FinalizadoINSSProcComboBox = New System.Windows.Forms.ComboBox()
        Me.ParcelEnvINSSProcTextBox = New System.Windows.Forms.TextBox()
        Me.TotalParcProcTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoProcRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataFinalProcMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataEnviaProcMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataSolicProcMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.EnviaParcProcRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ParcelamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        SocioLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        SenhaGovLabel = New System.Windows.Forms.Label()
        FormaDeEnvioLabel = New System.Windows.Forms.Label()
        ResponsavelLabel = New System.Windows.Forms.Label()
        WhatsappLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        DataCriacaoLabel = New System.Windows.Forms.Label()
        DataLembreteLabel = New System.Windows.Forms.Label()
        DataSolicProcLabel = New System.Windows.Forms.Label()
        DataEnviaProcLabel = New System.Windows.Forms.Label()
        ProtprocLabel = New System.Windows.Forms.Label()
        TotalParcProcLabel = New System.Windows.Forms.Label()
        ParcelEnvINSSProcLabel = New System.Windows.Forms.Label()
        DataSolicNovoLabel = New System.Windows.Forms.Label()
        ProtNovoLabel = New System.Windows.Forms.Label()
        TotalParcNovoLabel = New System.Windows.Forms.Label()
        DataEnvioNovoLabel = New System.Windows.Forms.Label()
        ParcelEnvINSSNovLabel = New System.Windows.Forms.Label()
        DataSolicAntigoLabel = New System.Windows.Forms.Label()
        DataEnviaAntigoLabel = New System.Windows.Forms.Label()
        ProtAntigoLabel = New System.Windows.Forms.Label()
        TotalParcAntigoLabel = New System.Windows.Forms.Label()
        ParcelEnvINSSAntLabel = New System.Windows.Forms.Label()
        DataSolicMEILabel = New System.Windows.Forms.Label()
        DataEnviaMEILabel = New System.Windows.Forms.Label()
        ProtMEILabel = New System.Windows.Forms.Label()
        TotalParcMEILabel = New System.Windows.Forms.Label()
        ParcelEnvMEILabel = New System.Windows.Forms.Label()
        FinalizadoEmpresaLabel = New System.Windows.Forms.Label()
        FinalizadoMEILabel = New System.Windows.Forms.Label()
        FinalizadoINSSAntLabel = New System.Windows.Forms.Label()
        FinalizadoINSSNovLabel = New System.Windows.Forms.Label()
        FinalizadoINSSProcLabel = New System.Windows.Forms.Label()
        FinalizadoMesGeralLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControlGeral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControlParcelamento.SuspendLayout()
        Me.TabPageMei.SuspendLayout()
        Me.TabControlMei.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPageINSSAntigo.SuspendLayout()
        Me.TabControlINSSAntigo.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPageINSSNovo.SuspendLayout()
        Me.TabControlINSSNovo.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPageINSSProcuradoria.SuspendLayout()
        Me.TabControlINSSProcuradoria.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        Me.TabPage16.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParcelamentosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SocioLabel
        '
        SocioLabel.AutoSize = True
        SocioLabel.Location = New System.Drawing.Point(69, 35)
        SocioLabel.Name = "SocioLabel"
        SocioLabel.Size = New System.Drawing.Size(51, 18)
        SocioLabel.TabIndex = 0
        SocioLabel.Text = "Socio:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(78, 65)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(42, 18)
        CPFLabel.TabIndex = 2
        CPFLabel.Text = "CPF:"
        '
        'SenhaGovLabel
        '
        SenhaGovLabel.AutoSize = True
        SenhaGovLabel.Location = New System.Drawing.Point(34, 95)
        SenhaGovLabel.Name = "SenhaGovLabel"
        SenhaGovLabel.Size = New System.Drawing.Size(86, 18)
        SenhaGovLabel.TabIndex = 4
        SenhaGovLabel.Text = "Senha Gov:"
        '
        'FormaDeEnvioLabel
        '
        FormaDeEnvioLabel.AutoSize = True
        FormaDeEnvioLabel.Location = New System.Drawing.Point(40, 80)
        FormaDeEnvioLabel.Name = "FormaDeEnvioLabel"
        FormaDeEnvioLabel.Size = New System.Drawing.Size(120, 18)
        FormaDeEnvioLabel.TabIndex = 0
        FormaDeEnvioLabel.Text = "Forma De Envio:"
        AddHandler FormaDeEnvioLabel.Click, AddressOf Me.FormaDeEnvioLabel_Click
        '
        'ResponsavelLabel
        '
        ResponsavelLabel.AutoSize = True
        ResponsavelLabel.Location = New System.Drawing.Point(62, 28)
        ResponsavelLabel.Name = "ResponsavelLabel"
        ResponsavelLabel.Size = New System.Drawing.Size(98, 18)
        ResponsavelLabel.TabIndex = 2
        ResponsavelLabel.Text = "Responsavel:"
        '
        'WhatsappLabel
        '
        WhatsappLabel.AutoSize = True
        WhatsappLabel.Location = New System.Drawing.Point(81, 112)
        WhatsappLabel.Name = "WhatsappLabel"
        WhatsappLabel.Size = New System.Drawing.Size(79, 18)
        WhatsappLabel.TabIndex = 4
        WhatsappLabel.Text = "Whatsapp:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(111, 142)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 18)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(60, 48)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(52, 18)
        CNPJLabel.TabIndex = 2
        CNPJLabel.Text = "CNPJ:"
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(11, 15)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(101, 18)
        RazaoSocialLabel.TabIndex = 0
        RazaoSocialLabel.Text = "Razao Social:"
        '
        'DataCriacaoLabel
        '
        DataCriacaoLabel.AutoSize = True
        DataCriacaoLabel.Location = New System.Drawing.Point(407, 49)
        DataCriacaoLabel.Name = "DataCriacaoLabel"
        DataCriacaoLabel.Size = New System.Drawing.Size(99, 18)
        DataCriacaoLabel.TabIndex = 4
        DataCriacaoLabel.Text = "Data Criacao:"
        '
        'DataLembreteLabel
        '
        DataLembreteLabel.AutoSize = True
        DataLembreteLabel.Location = New System.Drawing.Point(13, 99)
        DataLembreteLabel.Name = "DataLembreteLabel"
        DataLembreteLabel.Size = New System.Drawing.Size(109, 18)
        DataLembreteLabel.TabIndex = 6
        DataLembreteLabel.Text = "Data Lembrete:"
        '
        'DataSolicProcLabel
        '
        DataSolicProcLabel.AutoSize = True
        DataSolicProcLabel.Location = New System.Drawing.Point(8, 13)
        DataSolicProcLabel.Name = "DataSolicProcLabel"
        DataSolicProcLabel.Size = New System.Drawing.Size(140, 18)
        DataSolicProcLabel.TabIndex = 0
        DataSolicProcLabel.Text = "Data de Solicitação:"
        '
        'DataEnviaProcLabel
        '
        DataEnviaProcLabel.AutoSize = True
        DataEnviaProcLabel.Location = New System.Drawing.Point(38, 175)
        DataEnviaProcLabel.Name = "DataEnviaProcLabel"
        DataEnviaProcLabel.Size = New System.Drawing.Size(104, 18)
        DataEnviaProcLabel.TabIndex = 2
        DataEnviaProcLabel.Text = "Data de Envio:"
        '
        'ProtprocLabel
        '
        ProtprocLabel.AutoSize = True
        ProtprocLabel.Location = New System.Drawing.Point(62, 41)
        ProtprocLabel.Name = "ProtprocLabel"
        ProtprocLabel.Size = New System.Drawing.Size(86, 18)
        ProtprocLabel.TabIndex = 8
        ProtprocLabel.Text = "Protocolos:"
        '
        'TotalParcProcLabel
        '
        TotalParcProcLabel.AutoSize = True
        TotalParcProcLabel.Location = New System.Drawing.Point(21, 117)
        TotalParcProcLabel.Name = "TotalParcProcLabel"
        TotalParcProcLabel.Size = New System.Drawing.Size(127, 18)
        TotalParcProcLabel.TabIndex = 10
        TotalParcProcLabel.Text = "Total de Parcelas:"
        '
        'ParcelEnvINSSProcLabel
        '
        ParcelEnvINSSProcLabel.AutoSize = True
        ParcelEnvINSSProcLabel.Location = New System.Drawing.Point(40, 205)
        ParcelEnvINSSProcLabel.Name = "ParcelEnvINSSProcLabel"
        ParcelEnvINSSProcLabel.Size = New System.Drawing.Size(102, 18)
        ParcelEnvINSSProcLabel.TabIndex = 12
        ParcelEnvINSSProcLabel.Text = "Nº da Parcela:"
        '
        'DataSolicNovoLabel
        '
        DataSolicNovoLabel.AutoSize = True
        DataSolicNovoLabel.Location = New System.Drawing.Point(8, 14)
        DataSolicNovoLabel.Name = "DataSolicNovoLabel"
        DataSolicNovoLabel.Size = New System.Drawing.Size(140, 18)
        DataSolicNovoLabel.TabIndex = 0
        DataSolicNovoLabel.Text = "Data de Solicitação:"
        '
        'ProtNovoLabel
        '
        ProtNovoLabel.AutoSize = True
        ProtNovoLabel.Location = New System.Drawing.Point(62, 44)
        ProtNovoLabel.Name = "ProtNovoLabel"
        ProtNovoLabel.Size = New System.Drawing.Size(86, 18)
        ProtNovoLabel.TabIndex = 2
        ProtNovoLabel.Text = "Protocolos:"
        '
        'TotalParcNovoLabel
        '
        TotalParcNovoLabel.AutoSize = True
        TotalParcNovoLabel.Location = New System.Drawing.Point(21, 118)
        TotalParcNovoLabel.Name = "TotalParcNovoLabel"
        TotalParcNovoLabel.Size = New System.Drawing.Size(127, 18)
        TotalParcNovoLabel.TabIndex = 4
        TotalParcNovoLabel.Text = "Total de Parcelas:"
        '
        'DataEnvioNovoLabel
        '
        DataEnvioNovoLabel.AutoSize = True
        DataEnvioNovoLabel.Location = New System.Drawing.Point(38, 175)
        DataEnvioNovoLabel.Name = "DataEnvioNovoLabel"
        DataEnvioNovoLabel.Size = New System.Drawing.Size(104, 18)
        DataEnvioNovoLabel.TabIndex = 6
        DataEnvioNovoLabel.Text = "Data de Envio:"
        '
        'ParcelEnvINSSNovLabel
        '
        ParcelEnvINSSNovLabel.AutoSize = True
        ParcelEnvINSSNovLabel.Location = New System.Drawing.Point(40, 205)
        ParcelEnvINSSNovLabel.Name = "ParcelEnvINSSNovLabel"
        ParcelEnvINSSNovLabel.Size = New System.Drawing.Size(102, 18)
        ParcelEnvINSSNovLabel.TabIndex = 12
        ParcelEnvINSSNovLabel.Text = "Nº da Parcela:"
        '
        'DataSolicAntigoLabel
        '
        DataSolicAntigoLabel.AutoSize = True
        DataSolicAntigoLabel.Location = New System.Drawing.Point(8, 14)
        DataSolicAntigoLabel.Name = "DataSolicAntigoLabel"
        DataSolicAntigoLabel.Size = New System.Drawing.Size(140, 18)
        DataSolicAntigoLabel.TabIndex = 0
        DataSolicAntigoLabel.Text = "Data de Solicitação:"
        '
        'DataEnviaAntigoLabel
        '
        DataEnviaAntigoLabel.AutoSize = True
        DataEnviaAntigoLabel.Location = New System.Drawing.Point(38, 175)
        DataEnviaAntigoLabel.Name = "DataEnviaAntigoLabel"
        DataEnviaAntigoLabel.Size = New System.Drawing.Size(104, 18)
        DataEnviaAntigoLabel.TabIndex = 2
        DataEnviaAntigoLabel.Text = "Data de Envio:"
        '
        'ProtAntigoLabel
        '
        ProtAntigoLabel.AutoSize = True
        ProtAntigoLabel.Location = New System.Drawing.Point(62, 44)
        ProtAntigoLabel.Name = "ProtAntigoLabel"
        ProtAntigoLabel.Size = New System.Drawing.Size(86, 18)
        ProtAntigoLabel.TabIndex = 8
        ProtAntigoLabel.Text = "Protocolos:"
        '
        'TotalParcAntigoLabel
        '
        TotalParcAntigoLabel.AutoSize = True
        TotalParcAntigoLabel.Location = New System.Drawing.Point(21, 118)
        TotalParcAntigoLabel.Name = "TotalParcAntigoLabel"
        TotalParcAntigoLabel.Size = New System.Drawing.Size(127, 18)
        TotalParcAntigoLabel.TabIndex = 10
        TotalParcAntigoLabel.Text = "Total de Parcelas:"
        '
        'ParcelEnvINSSAntLabel
        '
        ParcelEnvINSSAntLabel.AutoSize = True
        ParcelEnvINSSAntLabel.Location = New System.Drawing.Point(40, 205)
        ParcelEnvINSSAntLabel.Name = "ParcelEnvINSSAntLabel"
        ParcelEnvINSSAntLabel.Size = New System.Drawing.Size(102, 18)
        ParcelEnvINSSAntLabel.TabIndex = 12
        ParcelEnvINSSAntLabel.Text = "Nº da Parcela:"
        '
        'DataSolicMEILabel
        '
        DataSolicMEILabel.AutoSize = True
        DataSolicMEILabel.Location = New System.Drawing.Point(20, 25)
        DataSolicMEILabel.Name = "DataSolicMEILabel"
        DataSolicMEILabel.Size = New System.Drawing.Size(140, 18)
        DataSolicMEILabel.TabIndex = 0
        DataSolicMEILabel.Text = "Data de Solicitação:"
        '
        'DataEnviaMEILabel
        '
        DataEnviaMEILabel.AutoSize = True
        DataEnviaMEILabel.Location = New System.Drawing.Point(27, 149)
        DataEnviaMEILabel.Name = "DataEnviaMEILabel"
        DataEnviaMEILabel.Size = New System.Drawing.Size(104, 18)
        DataEnviaMEILabel.TabIndex = 2
        DataEnviaMEILabel.Text = "Data de Envio:"
        '
        'ProtMEILabel
        '
        ProtMEILabel.AutoSize = True
        ProtMEILabel.Location = New System.Drawing.Point(82, 55)
        ProtMEILabel.Name = "ProtMEILabel"
        ProtMEILabel.Size = New System.Drawing.Size(78, 18)
        ProtMEILabel.TabIndex = 8
        ProtMEILabel.Text = "Protocolo:"
        '
        'TotalParcMEILabel
        '
        TotalParcMEILabel.AutoSize = True
        TotalParcMEILabel.Location = New System.Drawing.Point(33, 85)
        TotalParcMEILabel.Name = "TotalParcMEILabel"
        TotalParcMEILabel.Size = New System.Drawing.Size(127, 18)
        TotalParcMEILabel.TabIndex = 10
        TotalParcMEILabel.Text = "Total de Parcelas:"
        '
        'ParcelEnvMEILabel
        '
        ParcelEnvMEILabel.AutoSize = True
        ParcelEnvMEILabel.Location = New System.Drawing.Point(29, 179)
        ParcelEnvMEILabel.Name = "ParcelEnvMEILabel"
        ParcelEnvMEILabel.Size = New System.Drawing.Size(102, 18)
        ParcelEnvMEILabel.TabIndex = 12
        ParcelEnvMEILabel.Text = "Nº da Parcela:"
        '
        'FinalizadoEmpresaLabel
        '
        FinalizadoEmpresaLabel.AutoSize = True
        FinalizadoEmpresaLabel.Location = New System.Drawing.Point(259, 97)
        FinalizadoEmpresaLabel.Name = "FinalizadoEmpresaLabel"
        FinalizadoEmpresaLabel.Size = New System.Drawing.Size(175, 18)
        FinalizadoEmpresaLabel.TabIndex = 17
        FinalizadoEmpresaLabel.Text = "Finalizado Parcelamento:"
        '
        'FinalizadoMEILabel
        '
        FinalizadoMEILabel.AutoSize = True
        FinalizadoMEILabel.Location = New System.Drawing.Point(550, 9)
        FinalizadoMEILabel.Name = "FinalizadoMEILabel"
        FinalizadoMEILabel.Size = New System.Drawing.Size(109, 18)
        FinalizadoMEILabel.TabIndex = 14
        FinalizadoMEILabel.Text = "Finalizado MEI:"
        '
        'FinalizadoINSSAntLabel
        '
        FinalizadoINSSAntLabel.AutoSize = True
        FinalizadoINSSAntLabel.Location = New System.Drawing.Point(501, 9)
        FinalizadoINSSAntLabel.Name = "FinalizadoINSSAntLabel"
        FinalizadoINSSAntLabel.Size = New System.Drawing.Size(162, 18)
        FinalizadoINSSAntLabel.TabIndex = 14
        FinalizadoINSSAntLabel.Text = "Finalizado INSS Antigo:"
        '
        'FinalizadoINSSNovLabel
        '
        FinalizadoINSSNovLabel.AutoSize = True
        FinalizadoINSSNovLabel.Location = New System.Drawing.Point(505, 9)
        FinalizadoINSSNovLabel.Name = "FinalizadoINSSNovLabel"
        FinalizadoINSSNovLabel.Size = New System.Drawing.Size(157, 18)
        FinalizadoINSSNovLabel.TabIndex = 14
        FinalizadoINSSNovLabel.Text = "Finalizado INSS Novo:"
        '
        'FinalizadoINSSProcLabel
        '
        FinalizadoINSSProcLabel.AutoSize = True
        FinalizadoINSSProcLabel.Location = New System.Drawing.Point(456, 9)
        FinalizadoINSSProcLabel.Name = "FinalizadoINSSProcLabel"
        FinalizadoINSSProcLabel.Size = New System.Drawing.Size(207, 18)
        FinalizadoINSSProcLabel.TabIndex = 14
        FinalizadoINSSProcLabel.Text = "Finalizado INSS Procuradoria:"
        '
        'FinalizadoMesGeralLabel
        '
        FinalizadoMesGeralLabel.AutoSize = True
        FinalizadoMesGeralLabel.BackColor = System.Drawing.Color.Transparent
        FinalizadoMesGeralLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        FinalizadoMesGeralLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FinalizadoMesGeralLabel.ForeColor = System.Drawing.Color.Black
        FinalizadoMesGeralLabel.Location = New System.Drawing.Point(453, 20)
        FinalizadoMesGeralLabel.Name = "FinalizadoMesGeralLabel"
        FinalizadoMesGeralLabel.Size = New System.Drawing.Size(167, 18)
        FinalizadoMesGeralLabel.TabIndex = 22
        FinalizadoMesGeralLabel.Text = "Fechamento do Mês:"
        '
        'ProgressBarSalvar
        '
        Me.ProgressBarSalvar.Location = New System.Drawing.Point(3, 701)
        Me.ProgressBarSalvar.Name = "ProgressBarSalvar"
        Me.ProgressBarSalvar.Size = New System.Drawing.Size(783, 14)
        Me.ProgressBarSalvar.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBuscarRazaoSocial)
        Me.GroupBox1.Controls.Add(Me.RazaoSocialTextBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Razão Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(527, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CNPJ:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.ParcelamentosBindingSource
        Me.ComboBox1.DisplayMember = "CNPJ"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(585, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 26)
        Me.ComboBox1.TabIndex = 4
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
        'ComboBoxBuscarRazaoSocial
        '
        Me.ComboBoxBuscarRazaoSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscarRazaoSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscarRazaoSocial.DataSource = Me.ParcelamentosBindingSource
        Me.ComboBoxBuscarRazaoSocial.DisplayMember = "RazaoSocial"
        Me.ComboBoxBuscarRazaoSocial.FormattingEnabled = True
        Me.ComboBoxBuscarRazaoSocial.Location = New System.Drawing.Point(122, 36)
        Me.ComboBoxBuscarRazaoSocial.Name = "ComboBoxBuscarRazaoSocial"
        Me.ComboBoxBuscarRazaoSocial.Size = New System.Drawing.Size(382, 26)
        Me.ComboBoxBuscarRazaoSocial.TabIndex = 3
        '
        'RazaoSocialTextBox1
        '
        Me.RazaoSocialTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RazaoSocialTextBox1.Name = "RazaoSocialTextBox1"
        Me.RazaoSocialTextBox1.Size = New System.Drawing.Size(100, 24)
        Me.RazaoSocialTextBox1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.TabControlGeral)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 91)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(789, 289)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados"
        '
        'TabControlGeral
        '
        Me.TabControlGeral.Controls.Add(Me.TabPage1)
        Me.TabControlGeral.Controls.Add(Me.TabPage2)
        Me.TabControlGeral.Controls.Add(Me.TabPage5)
        Me.TabControlGeral.Controls.Add(Me.TabPage6)
        Me.TabControlGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlGeral.Location = New System.Drawing.Point(3, 20)
        Me.TabControlGeral.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlGeral.Name = "TabControlGeral"
        Me.TabControlGeral.SelectedIndex = 0
        Me.TabControlGeral.Size = New System.Drawing.Size(783, 266)
        Me.TabControlGeral.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.BtnConsultaSimplesNacional)
        Me.TabPage1.Controls.Add(Me.BtnDataCriacao)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.BtnImportar)
        Me.TabPage1.Controls.Add(Me.BtnCopiarCNPJ)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.LabelDataFinalizado)
        Me.TabPage1.Controls.Add(FinalizadoEmpresaLabel)
        Me.TabPage1.Controls.Add(Me.FinalizadoEmpresaComboBox)
        Me.TabPage1.Controls.Add(Me.DataFinalizadoMaskedTextBox)
        Me.TabPage1.Controls.Add(DataLembreteLabel)
        Me.TabPage1.Controls.Add(Me.DataLembreteMaskedTextBox)
        Me.TabPage1.Controls.Add(DataCriacaoLabel)
        Me.TabPage1.Controls.Add(Me.DataCriacaoMaskedTextBox)
        Me.TabPage1.Controls.Add(RazaoSocialLabel)
        Me.TabPage1.Controls.Add(CNPJLabel)
        Me.TabPage1.Controls.Add(Me.RazaoSocialTextBox)
        Me.TabPage1.Controls.Add(Me.CNPJMaskedTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(775, 235)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empresa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnConsultaSimplesNacional
        '
        Me.BtnConsultaSimplesNacional.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnConsultaSimplesNacional.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.LOGOsimplesnacional
        Me.BtnConsultaSimplesNacional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConsultaSimplesNacional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultaSimplesNacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaSimplesNacional.Location = New System.Drawing.Point(647, 136)
        Me.BtnConsultaSimplesNacional.Name = "BtnConsultaSimplesNacional"
        Me.BtnConsultaSimplesNacional.Size = New System.Drawing.Size(123, 43)
        Me.BtnConsultaSimplesNacional.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BtnConsultaSimplesNacional, "Consultar na Federal o Simples Nacional da Empresa Atual")
        Me.BtnConsultaSimplesNacional.UseVisualStyleBackColor = False
        '
        'BtnDataCriacao
        '
        Me.BtnDataCriacao.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDataCriacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDataCriacao.Location = New System.Drawing.Point(643, 46)
        Me.BtnDataCriacao.Name = "BtnDataCriacao"
        Me.BtnDataCriacao.Size = New System.Drawing.Size(75, 26)
        Me.BtnDataCriacao.TabIndex = 25
        Me.BtnDataCriacao.Text = "Agora"
        Me.BtnDataCriacao.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.Fundo
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(FinalizadoMesGeralLabel)
        Me.GroupBox2.Controls.Add(Me.FinalizadoMesGeralComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(769, 52)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'FinalizadoMesGeralComboBox
        '
        Me.FinalizadoMesGeralComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoMesGeral", True))
        Me.FinalizadoMesGeralComboBox.FormattingEnabled = True
        Me.FinalizadoMesGeralComboBox.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.FinalizadoMesGeralComboBox.Location = New System.Drawing.Point(620, 17)
        Me.FinalizadoMesGeralComboBox.Name = "FinalizadoMesGeralComboBox"
        Me.FinalizadoMesGeralComboBox.Size = New System.Drawing.Size(143, 26)
        Me.FinalizadoMesGeralComboBox.TabIndex = 23
        '
        'BtnImportar
        '
        Me.BtnImportar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImportar.Location = New System.Drawing.Point(643, 15)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(78, 26)
        Me.BtnImportar.TabIndex = 22
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.UseVisualStyleBackColor = False
        '
        'BtnCopiarCNPJ
        '
        Me.BtnCopiarCNPJ.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCopiarCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopiarCNPJ.Location = New System.Drawing.Point(267, 45)
        Me.BtnCopiarCNPJ.Name = "BtnCopiarCNPJ"
        Me.BtnCopiarCNPJ.Size = New System.Drawing.Size(75, 26)
        Me.BtnCopiarCNPJ.TabIndex = 21
        Me.BtnCopiarCNPJ.Text = "Copiar"
        Me.BtnCopiarCNPJ.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox6.Controls.Add(Me.MEICheckBox)
        Me.GroupBox6.Controls.Add(Me.InssAntigoCheckBox)
        Me.GroupBox6.Controls.Add(Me.InssNovoCheckBox)
        Me.GroupBox6.Controls.Add(Me.InssProcurCheckBox)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(115, 133)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox6.Size = New System.Drawing.Size(508, 54)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Parcelamentos Ativos"
        '
        'MEICheckBox
        '
        Me.MEICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "MEI", True))
        Me.MEICheckBox.Location = New System.Drawing.Point(6, 22)
        Me.MEICheckBox.Name = "MEICheckBox"
        Me.MEICheckBox.Size = New System.Drawing.Size(69, 24)
        Me.MEICheckBox.TabIndex = 11
        Me.MEICheckBox.Text = "MEI"
        Me.MEICheckBox.UseVisualStyleBackColor = True
        '
        'InssAntigoCheckBox
        '
        Me.InssAntigoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "InssAntigo", True))
        Me.InssAntigoCheckBox.Location = New System.Drawing.Point(81, 22)
        Me.InssAntigoCheckBox.Name = "InssAntigoCheckBox"
        Me.InssAntigoCheckBox.Size = New System.Drawing.Size(124, 24)
        Me.InssAntigoCheckBox.TabIndex = 13
        Me.InssAntigoCheckBox.Text = "INSS Antigo"
        Me.InssAntigoCheckBox.UseVisualStyleBackColor = True
        '
        'InssNovoCheckBox
        '
        Me.InssNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "InssNovo", True))
        Me.InssNovoCheckBox.Location = New System.Drawing.Point(211, 22)
        Me.InssNovoCheckBox.Name = "InssNovoCheckBox"
        Me.InssNovoCheckBox.Size = New System.Drawing.Size(111, 24)
        Me.InssNovoCheckBox.TabIndex = 15
        Me.InssNovoCheckBox.Text = "INSS Novo"
        Me.InssNovoCheckBox.UseVisualStyleBackColor = True
        '
        'InssProcurCheckBox
        '
        Me.InssProcurCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "InssProcur", True))
        Me.InssProcurCheckBox.Location = New System.Drawing.Point(329, 22)
        Me.InssProcurCheckBox.Name = "InssProcurCheckBox"
        Me.InssProcurCheckBox.Size = New System.Drawing.Size(173, 24)
        Me.InssProcurCheckBox.TabIndex = 17
        Me.InssProcurCheckBox.Text = "INSS Procuradoria"
        Me.InssProcurCheckBox.UseVisualStyleBackColor = True
        '
        'LabelDataFinalizado
        '
        Me.LabelDataFinalizado.AutoSize = True
        Me.LabelDataFinalizado.Location = New System.Drawing.Point(550, 99)
        Me.LabelDataFinalizado.Name = "LabelDataFinalizado"
        Me.LabelDataFinalizado.Size = New System.Drawing.Size(43, 18)
        Me.LabelDataFinalizado.TabIndex = 19
        Me.LabelDataFinalizado.Text = "Data:"
        '
        'FinalizadoEmpresaComboBox
        '
        Me.FinalizadoEmpresaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoEmpresa", True))
        Me.FinalizadoEmpresaComboBox.FormattingEnabled = True
        Me.FinalizadoEmpresaComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.FinalizadoEmpresaComboBox.Location = New System.Drawing.Point(440, 94)
        Me.FinalizadoEmpresaComboBox.Name = "FinalizadoEmpresaComboBox"
        Me.FinalizadoEmpresaComboBox.Size = New System.Drawing.Size(105, 26)
        Me.FinalizadoEmpresaComboBox.TabIndex = 18
        '
        'DataFinalizadoMaskedTextBox
        '
        Me.DataFinalizadoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataFinalizado", True))
        Me.DataFinalizadoMaskedTextBox.Location = New System.Drawing.Point(596, 96)
        Me.DataFinalizadoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataFinalizadoMaskedTextBox.Name = "DataFinalizadoMaskedTextBox"
        Me.DataFinalizadoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataFinalizadoMaskedTextBox.TabIndex = 9
        Me.DataFinalizadoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataLembreteMaskedTextBox
        '
        Me.DataLembreteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataLembrete", True))
        Me.DataLembreteMaskedTextBox.Location = New System.Drawing.Point(128, 96)
        Me.DataLembreteMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataLembreteMaskedTextBox.Name = "DataLembreteMaskedTextBox"
        Me.DataLembreteMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataLembreteMaskedTextBox.TabIndex = 7
        Me.DataLembreteMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataCriacaoMaskedTextBox
        '
        Me.DataCriacaoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataCriacao", True))
        Me.DataCriacaoMaskedTextBox.Location = New System.Drawing.Point(512, 46)
        Me.DataCriacaoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataCriacaoMaskedTextBox.Name = "DataCriacaoMaskedTextBox"
        Me.DataCriacaoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataCriacaoMaskedTextBox.TabIndex = 5
        Me.DataCriacaoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(118, 15)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(519, 24)
        Me.RazaoSocialTextBox.TabIndex = 1
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(118, 45)
        Me.CNPJMaskedTextBox.Mask = "99,999,999/9999-99"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(143, 24)
        Me.CNPJMaskedTextBox.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(Me.EmailTextBox)
        Me.TabPage2.Controls.Add(WhatsappLabel)
        Me.TabPage2.Controls.Add(Me.WhatsappMaskedTextBox)
        Me.TabPage2.Controls.Add(ResponsavelLabel)
        Me.TabPage2.Controls.Add(Me.ResponsavelTextBox)
        Me.TabPage2.Controls.Add(FormaDeEnvioLabel)
        Me.TabPage2.Controls.Add(Me.FormaDeEnvioComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(775, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Envio"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(166, 139)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(389, 24)
        Me.EmailTextBox.TabIndex = 7
        '
        'WhatsappMaskedTextBox
        '
        Me.WhatsappMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Whatsapp", True))
        Me.WhatsappMaskedTextBox.Location = New System.Drawing.Point(166, 109)
        Me.WhatsappMaskedTextBox.Name = "WhatsappMaskedTextBox"
        Me.WhatsappMaskedTextBox.Size = New System.Drawing.Size(194, 24)
        Me.WhatsappMaskedTextBox.TabIndex = 5
        '
        'ResponsavelTextBox
        '
        Me.ResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Responsavel", True))
        Me.ResponsavelTextBox.Location = New System.Drawing.Point(166, 25)
        Me.ResponsavelTextBox.Name = "ResponsavelTextBox"
        Me.ResponsavelTextBox.Size = New System.Drawing.Size(389, 24)
        Me.ResponsavelTextBox.TabIndex = 3
        '
        'FormaDeEnvioComboBox
        '
        Me.FormaDeEnvioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FormaDeEnvio", True))
        Me.FormaDeEnvioComboBox.FormattingEnabled = True
        Me.FormaDeEnvioComboBox.Items.AddRange(New Object() {"WhatsApp", "e-Mail", "Impresso", "Pessoalmente"})
        Me.FormaDeEnvioComboBox.Location = New System.Drawing.Point(166, 77)
        Me.FormaDeEnvioComboBox.Name = "FormaDeEnvioComboBox"
        Me.FormaDeEnvioComboBox.Size = New System.Drawing.Size(121, 26)
        Me.FormaDeEnvioComboBox.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(SenhaGovLabel)
        Me.TabPage5.Controls.Add(Me.SenhaGovTextBox)
        Me.TabPage5.Controls.Add(CPFLabel)
        Me.TabPage5.Controls.Add(Me.CPFMaskedTextBox)
        Me.TabPage5.Controls.Add(SocioLabel)
        Me.TabPage5.Controls.Add(Me.SocioTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(775, 235)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Responsável"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SenhaGovTextBox
        '
        Me.SenhaGovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "SenhaGov", True))
        Me.SenhaGovTextBox.Location = New System.Drawing.Point(126, 92)
        Me.SenhaGovTextBox.Name = "SenhaGovTextBox"
        Me.SenhaGovTextBox.Size = New System.Drawing.Size(224, 24)
        Me.SenhaGovTextBox.TabIndex = 5
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(126, 62)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(118, 24)
        Me.CPFMaskedTextBox.TabIndex = 3
        '
        'SocioTextBox
        '
        Me.SocioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Socio", True))
        Me.SocioTextBox.Location = New System.Drawing.Point(126, 32)
        Me.SocioTextBox.Name = "SocioTextBox"
        Me.SocioTextBox.Size = New System.Drawing.Size(348, 24)
        Me.SocioTextBox.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 27)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(775, 235)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Endereço"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.Controls.Add(Me.BtnFechar)
        Me.GroupBox4.Controls.Add(Me.BtnExcluir)
        Me.GroupBox4.Controls.Add(Me.BtnEditar)
        Me.GroupBox4.Controls.Add(Me.BtnSalvar)
        Me.GroupBox4.Controls.Add(Me.BtnNovo)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(789, 91)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 289)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Menu"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(7, 228)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(103, 41)
        Me.BtnFechar.TabIndex = 7
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.Location = New System.Drawing.Point(7, 176)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(103, 41)
        Me.BtnExcluir.TabIndex = 6
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(7, 72)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(103, 41)
        Me.BtnEditar.TabIndex = 5
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(7, 124)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(103, 41)
        Me.BtnSalvar.TabIndex = 4
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.Location = New System.Drawing.Point(7, 20)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(103, 41)
        Me.BtnNovo.TabIndex = 3
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.Controls.Add(Me.TabControlParcelamento)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 380)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Size = New System.Drawing.Size(789, 318)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'TabControlParcelamento
        '
        Me.TabControlParcelamento.Controls.Add(Me.TabPageMei)
        Me.TabControlParcelamento.Controls.Add(Me.TabPageINSSAntigo)
        Me.TabControlParcelamento.Controls.Add(Me.TabPageINSSNovo)
        Me.TabControlParcelamento.Controls.Add(Me.TabPageINSSProcuradoria)
        Me.TabControlParcelamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlParcelamento.Location = New System.Drawing.Point(0, 17)
        Me.TabControlParcelamento.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlParcelamento.Name = "TabControlParcelamento"
        Me.TabControlParcelamento.SelectedIndex = 0
        Me.TabControlParcelamento.Size = New System.Drawing.Size(789, 301)
        Me.TabControlParcelamento.TabIndex = 5
        '
        'TabPageMei
        '
        Me.TabPageMei.Controls.Add(Me.TabControlMei)
        Me.TabPageMei.Location = New System.Drawing.Point(4, 27)
        Me.TabPageMei.Name = "TabPageMei"
        Me.TabPageMei.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMei.Size = New System.Drawing.Size(781, 270)
        Me.TabPageMei.TabIndex = 0
        Me.TabPageMei.Text = "MEI"
        Me.TabPageMei.UseVisualStyleBackColor = True
        '
        'TabControlMei
        '
        Me.TabControlMei.Controls.Add(Me.TabPage9)
        Me.TabControlMei.Controls.Add(Me.TabPage10)
        Me.TabControlMei.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMei.Location = New System.Drawing.Point(3, 3)
        Me.TabControlMei.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlMei.Name = "TabControlMei"
        Me.TabControlMei.SelectedIndex = 0
        Me.TabControlMei.Size = New System.Drawing.Size(775, 264)
        Me.TabControlMei.TabIndex = 0
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.Controls.Add(Me.BtnAgoraMEI)
        Me.TabPage9.Controls.Add(Me.BtnRegistrarMEI)
        Me.TabPage9.Controls.Add(Me.LblFinalizadoDataMEI)
        Me.TabPage9.Controls.Add(Me.LabelMotivoMEI)
        Me.TabPage9.Controls.Add(FinalizadoMEILabel)
        Me.TabPage9.Controls.Add(Me.FinalizadoMEIComboBox)
        Me.TabPage9.Controls.Add(ParcelEnvMEILabel)
        Me.TabPage9.Controls.Add(Me.ParcelEnvMEITextBox)
        Me.TabPage9.Controls.Add(TotalParcMEILabel)
        Me.TabPage9.Controls.Add(Me.TotalParcMEITextBox)
        Me.TabPage9.Controls.Add(ProtMEILabel)
        Me.TabPage9.Controls.Add(Me.ProtMEITextBox)
        Me.TabPage9.Controls.Add(Me.MotivoMEIRichTextBox)
        Me.TabPage9.Controls.Add(Me.DataFinalMEIMaskedTextBox)
        Me.TabPage9.Controls.Add(DataEnviaMEILabel)
        Me.TabPage9.Controls.Add(Me.DataEnviaMEIMaskedTextBox)
        Me.TabPage9.Controls.Add(DataSolicMEILabel)
        Me.TabPage9.Controls.Add(Me.DataSolicMEIMaskedTextBox)
        Me.TabPage9.Location = New System.Drawing.Point(4, 27)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(767, 233)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Parcelamento"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'BtnAgoraMEI
        '
        Me.BtnAgoraMEI.Location = New System.Drawing.Point(268, 144)
        Me.BtnAgoraMEI.Name = "BtnAgoraMEI"
        Me.BtnAgoraMEI.Size = New System.Drawing.Size(75, 28)
        Me.BtnAgoraMEI.TabIndex = 20
        Me.BtnAgoraMEI.Text = "Agora"
        Me.BtnAgoraMEI.UseVisualStyleBackColor = True
        '
        'BtnRegistrarMEI
        '
        Me.BtnRegistrarMEI.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.FundoBotaoNormal
        Me.BtnRegistrarMEI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistrarMEI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarMEI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegistrarMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarMEI.Location = New System.Drawing.Point(350, 144)
        Me.BtnRegistrarMEI.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegistrarMEI.Name = "BtnRegistrarMEI"
        Me.BtnRegistrarMEI.Size = New System.Drawing.Size(155, 56)
        Me.BtnRegistrarMEI.TabIndex = 19
        Me.BtnRegistrarMEI.Text = "Registrar Envio"
        Me.BtnRegistrarMEI.UseVisualStyleBackColor = True
        '
        'LblFinalizadoDataMEI
        '
        Me.LblFinalizadoDataMEI.AutoSize = True
        Me.LblFinalizadoDataMEI.Location = New System.Drawing.Point(516, 41)
        Me.LblFinalizadoDataMEI.Name = "LblFinalizadoDataMEI"
        Me.LblFinalizadoDataMEI.Size = New System.Drawing.Size(104, 18)
        Me.LblFinalizadoDataMEI.TabIndex = 18
        Me.LblFinalizadoDataMEI.Text = "Finalizado em:"
        '
        'LabelMotivoMEI
        '
        Me.LabelMotivoMEI.AutoSize = True
        Me.LabelMotivoMEI.Location = New System.Drawing.Point(520, 73)
        Me.LabelMotivoMEI.Name = "LabelMotivoMEI"
        Me.LabelMotivoMEI.Size = New System.Drawing.Size(57, 18)
        Me.LabelMotivoMEI.TabIndex = 17
        Me.LabelMotivoMEI.Text = "Motivo:"
        '
        'FinalizadoMEIComboBox
        '
        Me.FinalizadoMEIComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoMEI", True))
        Me.FinalizadoMEIComboBox.FormattingEnabled = True
        Me.FinalizadoMEIComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.FinalizadoMEIComboBox.Location = New System.Drawing.Point(665, 6)
        Me.FinalizadoMEIComboBox.Name = "FinalizadoMEIComboBox"
        Me.FinalizadoMEIComboBox.Size = New System.Drawing.Size(86, 26)
        Me.FinalizadoMEIComboBox.TabIndex = 15
        '
        'ParcelEnvMEITextBox
        '
        Me.ParcelEnvMEITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelEnvMEI", True))
        Me.ParcelEnvMEITextBox.Location = New System.Drawing.Point(137, 176)
        Me.ParcelEnvMEITextBox.Name = "ParcelEnvMEITextBox"
        Me.ParcelEnvMEITextBox.Size = New System.Drawing.Size(206, 24)
        Me.ParcelEnvMEITextBox.TabIndex = 13
        '
        'TotalParcMEITextBox
        '
        Me.TotalParcMEITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "TotalParcMEI", True))
        Me.TotalParcMEITextBox.Location = New System.Drawing.Point(162, 82)
        Me.TotalParcMEITextBox.Name = "TotalParcMEITextBox"
        Me.TotalParcMEITextBox.Size = New System.Drawing.Size(235, 24)
        Me.TotalParcMEITextBox.TabIndex = 11
        '
        'ProtMEITextBox
        '
        Me.ProtMEITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ProtMEI", True))
        Me.ProtMEITextBox.Location = New System.Drawing.Point(162, 52)
        Me.ProtMEITextBox.Name = "ProtMEITextBox"
        Me.ProtMEITextBox.Size = New System.Drawing.Size(235, 24)
        Me.ProtMEITextBox.TabIndex = 9
        '
        'MotivoMEIRichTextBox
        '
        Me.MotivoMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoMEI", True))
        Me.MotivoMEIRichTextBox.Location = New System.Drawing.Point(523, 94)
        Me.MotivoMEIRichTextBox.Name = "MotivoMEIRichTextBox"
        Me.MotivoMEIRichTextBox.Size = New System.Drawing.Size(228, 124)
        Me.MotivoMEIRichTextBox.TabIndex = 7
        Me.MotivoMEIRichTextBox.Text = ""
        '
        'DataFinalMEIMaskedTextBox
        '
        Me.DataFinalMEIMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataFinalMEI", True))
        Me.DataFinalMEIMaskedTextBox.Location = New System.Drawing.Point(626, 38)
        Me.DataFinalMEIMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataFinalMEIMaskedTextBox.Name = "DataFinalMEIMaskedTextBox"
        Me.DataFinalMEIMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataFinalMEIMaskedTextBox.TabIndex = 5
        Me.DataFinalMEIMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataEnviaMEIMaskedTextBox
        '
        Me.DataEnviaMEIMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataEnviaMEI", True))
        Me.DataEnviaMEIMaskedTextBox.Location = New System.Drawing.Point(137, 146)
        Me.DataEnviaMEIMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataEnviaMEIMaskedTextBox.Name = "DataEnviaMEIMaskedTextBox"
        Me.DataEnviaMEIMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataEnviaMEIMaskedTextBox.TabIndex = 3
        Me.DataEnviaMEIMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataSolicMEIMaskedTextBox
        '
        Me.DataSolicMEIMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataSolicMEI", True))
        Me.DataSolicMEIMaskedTextBox.Location = New System.Drawing.Point(162, 22)
        Me.DataSolicMEIMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataSolicMEIMaskedTextBox.Name = "DataSolicMEIMaskedTextBox"
        Me.DataSolicMEIMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataSolicMEIMaskedTextBox.TabIndex = 1
        Me.DataSolicMEIMaskedTextBox.ValidatingType = GetType(Date)
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.EnviaParcMEIRichTextBox)
        Me.TabPage10.Location = New System.Drawing.Point(4, 27)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(767, 233)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Histórico de Envio"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'EnviaParcMEIRichTextBox
        '
        Me.EnviaParcMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "EnviaParcMEI", True))
        Me.EnviaParcMEIRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnviaParcMEIRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.EnviaParcMEIRichTextBox.Name = "EnviaParcMEIRichTextBox"
        Me.EnviaParcMEIRichTextBox.Size = New System.Drawing.Size(761, 227)
        Me.EnviaParcMEIRichTextBox.TabIndex = 1
        Me.EnviaParcMEIRichTextBox.Text = ""
        '
        'TabPageINSSAntigo
        '
        Me.TabPageINSSAntigo.Controls.Add(Me.TabControlINSSAntigo)
        Me.TabPageINSSAntigo.Location = New System.Drawing.Point(4, 27)
        Me.TabPageINSSAntigo.Name = "TabPageINSSAntigo"
        Me.TabPageINSSAntigo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageINSSAntigo.Size = New System.Drawing.Size(781, 275)
        Me.TabPageINSSAntigo.TabIndex = 1
        Me.TabPageINSSAntigo.Text = "INSS Antigo"
        Me.TabPageINSSAntigo.UseVisualStyleBackColor = True
        '
        'TabControlINSSAntigo
        '
        Me.TabControlINSSAntigo.Controls.Add(Me.TabPage11)
        Me.TabControlINSSAntigo.Controls.Add(Me.TabPage12)
        Me.TabControlINSSAntigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlINSSAntigo.Location = New System.Drawing.Point(3, 3)
        Me.TabControlINSSAntigo.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlINSSAntigo.Name = "TabControlINSSAntigo"
        Me.TabControlINSSAntigo.SelectedIndex = 0
        Me.TabControlINSSAntigo.Size = New System.Drawing.Size(775, 269)
        Me.TabControlINSSAntigo.TabIndex = 1
        '
        'TabPage11
        '
        Me.TabPage11.AutoScroll = True
        Me.TabPage11.Controls.Add(Me.ProtAntigoRichTextBox)
        Me.TabPage11.Controls.Add(Me.BtnAgoraINSSAntigo)
        Me.TabPage11.Controls.Add(Me.BtnRegistrarINSSAntigo)
        Me.TabPage11.Controls.Add(Me.LblFinalizadoDataINSSAntigo)
        Me.TabPage11.Controls.Add(Me.LabelMotivoINSSAntigo)
        Me.TabPage11.Controls.Add(FinalizadoINSSAntLabel)
        Me.TabPage11.Controls.Add(Me.FinalizadoINSSAntComboBox)
        Me.TabPage11.Controls.Add(ParcelEnvINSSAntLabel)
        Me.TabPage11.Controls.Add(Me.ParcelEnvINSSAntTextBox)
        Me.TabPage11.Controls.Add(TotalParcAntigoLabel)
        Me.TabPage11.Controls.Add(Me.TotalParcAntigoTextBox)
        Me.TabPage11.Controls.Add(ProtAntigoLabel)
        Me.TabPage11.Controls.Add(Me.MotivoAntigoRichTextBox)
        Me.TabPage11.Controls.Add(Me.DataFinalAntigoMaskedTextBox)
        Me.TabPage11.Controls.Add(DataEnviaAntigoLabel)
        Me.TabPage11.Controls.Add(Me.DataEnviaAntigoMaskedTextBox)
        Me.TabPage11.Controls.Add(DataSolicAntigoLabel)
        Me.TabPage11.Controls.Add(Me.DataSolicAntigoMaskedTextBox)
        Me.TabPage11.Location = New System.Drawing.Point(4, 27)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(767, 238)
        Me.TabPage11.TabIndex = 0
        Me.TabPage11.Text = "Parcelamento"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'ProtAntigoRichTextBox
        '
        Me.ProtAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ProtAntigo", True))
        Me.ProtAntigoRichTextBox.Location = New System.Drawing.Point(150, 41)
        Me.ProtAntigoRichTextBox.Name = "ProtAntigoRichTextBox"
        Me.ProtAntigoRichTextBox.Size = New System.Drawing.Size(286, 68)
        Me.ProtAntigoRichTextBox.TabIndex = 23
        Me.ProtAntigoRichTextBox.Text = ""
        '
        'BtnAgoraINSSAntigo
        '
        Me.BtnAgoraINSSAntigo.Location = New System.Drawing.Point(279, 170)
        Me.BtnAgoraINSSAntigo.Name = "BtnAgoraINSSAntigo"
        Me.BtnAgoraINSSAntigo.Size = New System.Drawing.Size(75, 28)
        Me.BtnAgoraINSSAntigo.TabIndex = 22
        Me.BtnAgoraINSSAntigo.Text = "Agora"
        Me.BtnAgoraINSSAntigo.UseVisualStyleBackColor = True
        '
        'BtnRegistrarINSSAntigo
        '
        Me.BtnRegistrarINSSAntigo.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.FundoBotaoNormal
        Me.BtnRegistrarINSSAntigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistrarINSSAntigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarINSSAntigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegistrarINSSAntigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarINSSAntigo.Location = New System.Drawing.Point(361, 170)
        Me.BtnRegistrarINSSAntigo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegistrarINSSAntigo.Name = "BtnRegistrarINSSAntigo"
        Me.BtnRegistrarINSSAntigo.Size = New System.Drawing.Size(155, 56)
        Me.BtnRegistrarINSSAntigo.TabIndex = 21
        Me.BtnRegistrarINSSAntigo.Text = "Registrar Envio"
        Me.BtnRegistrarINSSAntigo.UseVisualStyleBackColor = True
        '
        'LblFinalizadoDataINSSAntigo
        '
        Me.LblFinalizadoDataINSSAntigo.AutoSize = True
        Me.LblFinalizadoDataINSSAntigo.Location = New System.Drawing.Point(516, 41)
        Me.LblFinalizadoDataINSSAntigo.Name = "LblFinalizadoDataINSSAntigo"
        Me.LblFinalizadoDataINSSAntigo.Size = New System.Drawing.Size(104, 18)
        Me.LblFinalizadoDataINSSAntigo.TabIndex = 19
        Me.LblFinalizadoDataINSSAntigo.Text = "Finalizado em:"
        '
        'LabelMotivoINSSAntigo
        '
        Me.LabelMotivoINSSAntigo.AutoSize = True
        Me.LabelMotivoINSSAntigo.Location = New System.Drawing.Point(520, 73)
        Me.LabelMotivoINSSAntigo.Name = "LabelMotivoINSSAntigo"
        Me.LabelMotivoINSSAntigo.Size = New System.Drawing.Size(57, 18)
        Me.LabelMotivoINSSAntigo.TabIndex = 16
        Me.LabelMotivoINSSAntigo.Text = "Motivo:"
        '
        'FinalizadoINSSAntComboBox
        '
        Me.FinalizadoINSSAntComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoINSSAnt", True))
        Me.FinalizadoINSSAntComboBox.FormattingEnabled = True
        Me.FinalizadoINSSAntComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.FinalizadoINSSAntComboBox.Location = New System.Drawing.Point(665, 6)
        Me.FinalizadoINSSAntComboBox.Name = "FinalizadoINSSAntComboBox"
        Me.FinalizadoINSSAntComboBox.Size = New System.Drawing.Size(86, 26)
        Me.FinalizadoINSSAntComboBox.TabIndex = 15
        '
        'ParcelEnvINSSAntTextBox
        '
        Me.ParcelEnvINSSAntTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelEnvINSSAnt", True))
        Me.ParcelEnvINSSAntTextBox.Location = New System.Drawing.Point(148, 202)
        Me.ParcelEnvINSSAntTextBox.Name = "ParcelEnvINSSAntTextBox"
        Me.ParcelEnvINSSAntTextBox.Size = New System.Drawing.Size(206, 24)
        Me.ParcelEnvINSSAntTextBox.TabIndex = 13
        '
        'TotalParcAntigoTextBox
        '
        Me.TotalParcAntigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "TotalParcAntigo", True))
        Me.TotalParcAntigoTextBox.Location = New System.Drawing.Point(150, 115)
        Me.TotalParcAntigoTextBox.Name = "TotalParcAntigoTextBox"
        Me.TotalParcAntigoTextBox.Size = New System.Drawing.Size(286, 24)
        Me.TotalParcAntigoTextBox.TabIndex = 11
        '
        'MotivoAntigoRichTextBox
        '
        Me.MotivoAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoAntigo", True))
        Me.MotivoAntigoRichTextBox.Location = New System.Drawing.Point(523, 94)
        Me.MotivoAntigoRichTextBox.Name = "MotivoAntigoRichTextBox"
        Me.MotivoAntigoRichTextBox.Size = New System.Drawing.Size(228, 132)
        Me.MotivoAntigoRichTextBox.TabIndex = 7
        Me.MotivoAntigoRichTextBox.Text = ""
        '
        'DataFinalAntigoMaskedTextBox
        '
        Me.DataFinalAntigoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataFinalAntigo", True))
        Me.DataFinalAntigoMaskedTextBox.Location = New System.Drawing.Point(626, 38)
        Me.DataFinalAntigoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataFinalAntigoMaskedTextBox.Name = "DataFinalAntigoMaskedTextBox"
        Me.DataFinalAntigoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataFinalAntigoMaskedTextBox.TabIndex = 5
        Me.DataFinalAntigoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataEnviaAntigoMaskedTextBox
        '
        Me.DataEnviaAntigoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataEnviaAntigo", True))
        Me.DataEnviaAntigoMaskedTextBox.Location = New System.Drawing.Point(148, 172)
        Me.DataEnviaAntigoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataEnviaAntigoMaskedTextBox.Name = "DataEnviaAntigoMaskedTextBox"
        Me.DataEnviaAntigoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataEnviaAntigoMaskedTextBox.TabIndex = 3
        Me.DataEnviaAntigoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataSolicAntigoMaskedTextBox
        '
        Me.DataSolicAntigoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataSolicAntigo", True))
        Me.DataSolicAntigoMaskedTextBox.Location = New System.Drawing.Point(150, 11)
        Me.DataSolicAntigoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataSolicAntigoMaskedTextBox.Name = "DataSolicAntigoMaskedTextBox"
        Me.DataSolicAntigoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataSolicAntigoMaskedTextBox.TabIndex = 1
        Me.DataSolicAntigoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.EnviaParcAntigoRichTextBox)
        Me.TabPage12.Location = New System.Drawing.Point(4, 27)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(767, 238)
        Me.TabPage12.TabIndex = 1
        Me.TabPage12.Text = "Histórico de Envio"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'EnviaParcAntigoRichTextBox
        '
        Me.EnviaParcAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "EnviaParcAntigo", True))
        Me.EnviaParcAntigoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnviaParcAntigoRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.EnviaParcAntigoRichTextBox.Name = "EnviaParcAntigoRichTextBox"
        Me.EnviaParcAntigoRichTextBox.Size = New System.Drawing.Size(761, 232)
        Me.EnviaParcAntigoRichTextBox.TabIndex = 1
        Me.EnviaParcAntigoRichTextBox.Text = ""
        '
        'TabPageINSSNovo
        '
        Me.TabPageINSSNovo.Controls.Add(Me.TabControlINSSNovo)
        Me.TabPageINSSNovo.Location = New System.Drawing.Point(4, 27)
        Me.TabPageINSSNovo.Name = "TabPageINSSNovo"
        Me.TabPageINSSNovo.Size = New System.Drawing.Size(781, 275)
        Me.TabPageINSSNovo.TabIndex = 2
        Me.TabPageINSSNovo.Text = "INSS Novo"
        Me.TabPageINSSNovo.UseVisualStyleBackColor = True
        '
        'TabControlINSSNovo
        '
        Me.TabControlINSSNovo.Controls.Add(Me.TabPage13)
        Me.TabControlINSSNovo.Controls.Add(Me.TabPage14)
        Me.TabControlINSSNovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlINSSNovo.Location = New System.Drawing.Point(0, 0)
        Me.TabControlINSSNovo.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlINSSNovo.Name = "TabControlINSSNovo"
        Me.TabControlINSSNovo.SelectedIndex = 0
        Me.TabControlINSSNovo.Size = New System.Drawing.Size(781, 275)
        Me.TabControlINSSNovo.TabIndex = 1
        '
        'TabPage13
        '
        Me.TabPage13.AutoScroll = True
        Me.TabPage13.Controls.Add(Me.ProtNovoRichTextBox)
        Me.TabPage13.Controls.Add(Me.BtnAgoraINSSNovo)
        Me.TabPage13.Controls.Add(Me.BtnRegistrarINSSNovo)
        Me.TabPage13.Controls.Add(Me.LblFinalizadoDataINSSNovo)
        Me.TabPage13.Controls.Add(Me.LabelMotivoINSSNovo)
        Me.TabPage13.Controls.Add(FinalizadoINSSNovLabel)
        Me.TabPage13.Controls.Add(Me.FinalizadoINSSNovComboBox)
        Me.TabPage13.Controls.Add(ParcelEnvINSSNovLabel)
        Me.TabPage13.Controls.Add(Me.ParcelEnvINSSNovTextBox)
        Me.TabPage13.Controls.Add(Me.MotivoNovoRichTextBox)
        Me.TabPage13.Controls.Add(Me.DataFinalNovoMaskedTextBox)
        Me.TabPage13.Controls.Add(DataEnvioNovoLabel)
        Me.TabPage13.Controls.Add(Me.DataEnvioNovoMaskedTextBox)
        Me.TabPage13.Controls.Add(TotalParcNovoLabel)
        Me.TabPage13.Controls.Add(Me.TotalParcNovoTextBox)
        Me.TabPage13.Controls.Add(ProtNovoLabel)
        Me.TabPage13.Controls.Add(DataSolicNovoLabel)
        Me.TabPage13.Controls.Add(Me.DataSolicNovoMaskedTextBox)
        Me.TabPage13.Location = New System.Drawing.Point(4, 27)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(773, 244)
        Me.TabPage13.TabIndex = 0
        Me.TabPage13.Text = "Parcelamento"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'ProtNovoRichTextBox
        '
        Me.ProtNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ProtNovo", True))
        Me.ProtNovoRichTextBox.Location = New System.Drawing.Point(150, 41)
        Me.ProtNovoRichTextBox.Name = "ProtNovoRichTextBox"
        Me.ProtNovoRichTextBox.Size = New System.Drawing.Size(286, 68)
        Me.ProtNovoRichTextBox.TabIndex = 23
        Me.ProtNovoRichTextBox.Text = ""
        '
        'BtnAgoraINSSNovo
        '
        Me.BtnAgoraINSSNovo.Location = New System.Drawing.Point(279, 170)
        Me.BtnAgoraINSSNovo.Name = "BtnAgoraINSSNovo"
        Me.BtnAgoraINSSNovo.Size = New System.Drawing.Size(75, 28)
        Me.BtnAgoraINSSNovo.TabIndex = 22
        Me.BtnAgoraINSSNovo.Text = "Agora"
        Me.BtnAgoraINSSNovo.UseVisualStyleBackColor = True
        '
        'BtnRegistrarINSSNovo
        '
        Me.BtnRegistrarINSSNovo.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.FundoBotaoNormal
        Me.BtnRegistrarINSSNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistrarINSSNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarINSSNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegistrarINSSNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarINSSNovo.Location = New System.Drawing.Point(361, 170)
        Me.BtnRegistrarINSSNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegistrarINSSNovo.Name = "BtnRegistrarINSSNovo"
        Me.BtnRegistrarINSSNovo.Size = New System.Drawing.Size(155, 56)
        Me.BtnRegistrarINSSNovo.TabIndex = 21
        Me.BtnRegistrarINSSNovo.Text = "Registrar Envio"
        Me.BtnRegistrarINSSNovo.UseVisualStyleBackColor = True
        '
        'LblFinalizadoDataINSSNovo
        '
        Me.LblFinalizadoDataINSSNovo.AutoSize = True
        Me.LblFinalizadoDataINSSNovo.Location = New System.Drawing.Point(516, 41)
        Me.LblFinalizadoDataINSSNovo.Name = "LblFinalizadoDataINSSNovo"
        Me.LblFinalizadoDataINSSNovo.Size = New System.Drawing.Size(104, 18)
        Me.LblFinalizadoDataINSSNovo.TabIndex = 19
        Me.LblFinalizadoDataINSSNovo.Text = "Finalizado em:"
        '
        'LabelMotivoINSSNovo
        '
        Me.LabelMotivoINSSNovo.AutoSize = True
        Me.LabelMotivoINSSNovo.Location = New System.Drawing.Point(520, 73)
        Me.LabelMotivoINSSNovo.Name = "LabelMotivoINSSNovo"
        Me.LabelMotivoINSSNovo.Size = New System.Drawing.Size(57, 18)
        Me.LabelMotivoINSSNovo.TabIndex = 17
        Me.LabelMotivoINSSNovo.Text = "Motivo:"
        '
        'FinalizadoINSSNovComboBox
        '
        Me.FinalizadoINSSNovComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoINSSNov", True))
        Me.FinalizadoINSSNovComboBox.FormattingEnabled = True
        Me.FinalizadoINSSNovComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.FinalizadoINSSNovComboBox.Location = New System.Drawing.Point(665, 6)
        Me.FinalizadoINSSNovComboBox.Name = "FinalizadoINSSNovComboBox"
        Me.FinalizadoINSSNovComboBox.Size = New System.Drawing.Size(86, 26)
        Me.FinalizadoINSSNovComboBox.TabIndex = 15
        '
        'ParcelEnvINSSNovTextBox
        '
        Me.ParcelEnvINSSNovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelEnvINSSNov", True))
        Me.ParcelEnvINSSNovTextBox.Location = New System.Drawing.Point(148, 202)
        Me.ParcelEnvINSSNovTextBox.Name = "ParcelEnvINSSNovTextBox"
        Me.ParcelEnvINSSNovTextBox.Size = New System.Drawing.Size(206, 24)
        Me.ParcelEnvINSSNovTextBox.TabIndex = 13
        '
        'MotivoNovoRichTextBox
        '
        Me.MotivoNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoNovo", True))
        Me.MotivoNovoRichTextBox.Location = New System.Drawing.Point(523, 94)
        Me.MotivoNovoRichTextBox.Name = "MotivoNovoRichTextBox"
        Me.MotivoNovoRichTextBox.Size = New System.Drawing.Size(228, 132)
        Me.MotivoNovoRichTextBox.TabIndex = 11
        Me.MotivoNovoRichTextBox.Text = ""
        '
        'DataFinalNovoMaskedTextBox
        '
        Me.DataFinalNovoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataFinalNovo", True))
        Me.DataFinalNovoMaskedTextBox.Location = New System.Drawing.Point(626, 38)
        Me.DataFinalNovoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataFinalNovoMaskedTextBox.Name = "DataFinalNovoMaskedTextBox"
        Me.DataFinalNovoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataFinalNovoMaskedTextBox.TabIndex = 9
        Me.DataFinalNovoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataEnvioNovoMaskedTextBox
        '
        Me.DataEnvioNovoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataEnvioNovo", True))
        Me.DataEnvioNovoMaskedTextBox.Location = New System.Drawing.Point(148, 172)
        Me.DataEnvioNovoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataEnvioNovoMaskedTextBox.Name = "DataEnvioNovoMaskedTextBox"
        Me.DataEnvioNovoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataEnvioNovoMaskedTextBox.TabIndex = 7
        Me.DataEnvioNovoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'TotalParcNovoTextBox
        '
        Me.TotalParcNovoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "TotalParcNovo", True))
        Me.TotalParcNovoTextBox.Location = New System.Drawing.Point(150, 115)
        Me.TotalParcNovoTextBox.Name = "TotalParcNovoTextBox"
        Me.TotalParcNovoTextBox.Size = New System.Drawing.Size(283, 24)
        Me.TotalParcNovoTextBox.TabIndex = 5
        '
        'DataSolicNovoMaskedTextBox
        '
        Me.DataSolicNovoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataSolicNovo", True))
        Me.DataSolicNovoMaskedTextBox.Location = New System.Drawing.Point(150, 11)
        Me.DataSolicNovoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataSolicNovoMaskedTextBox.Name = "DataSolicNovoMaskedTextBox"
        Me.DataSolicNovoMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataSolicNovoMaskedTextBox.TabIndex = 1
        Me.DataSolicNovoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.EnviaParcNovoRichTextBox)
        Me.TabPage14.Location = New System.Drawing.Point(4, 27)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(773, 244)
        Me.TabPage14.TabIndex = 1
        Me.TabPage14.Text = "Histórico de Envio"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'EnviaParcNovoRichTextBox
        '
        Me.EnviaParcNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoNovo", True))
        Me.EnviaParcNovoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnviaParcNovoRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.EnviaParcNovoRichTextBox.Name = "EnviaParcNovoRichTextBox"
        Me.EnviaParcNovoRichTextBox.Size = New System.Drawing.Size(767, 238)
        Me.EnviaParcNovoRichTextBox.TabIndex = 1
        Me.EnviaParcNovoRichTextBox.Text = ""
        '
        'TabPageINSSProcuradoria
        '
        Me.TabPageINSSProcuradoria.Controls.Add(Me.TabControlINSSProcuradoria)
        Me.TabPageINSSProcuradoria.Location = New System.Drawing.Point(4, 27)
        Me.TabPageINSSProcuradoria.Name = "TabPageINSSProcuradoria"
        Me.TabPageINSSProcuradoria.Size = New System.Drawing.Size(781, 275)
        Me.TabPageINSSProcuradoria.TabIndex = 3
        Me.TabPageINSSProcuradoria.Text = "INSS Procuradoria"
        Me.TabPageINSSProcuradoria.UseVisualStyleBackColor = True
        '
        'TabControlINSSProcuradoria
        '
        Me.TabControlINSSProcuradoria.Controls.Add(Me.TabPage15)
        Me.TabControlINSSProcuradoria.Controls.Add(Me.TabPage16)
        Me.TabControlINSSProcuradoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlINSSProcuradoria.Location = New System.Drawing.Point(0, 0)
        Me.TabControlINSSProcuradoria.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlINSSProcuradoria.Name = "TabControlINSSProcuradoria"
        Me.TabControlINSSProcuradoria.SelectedIndex = 0
        Me.TabControlINSSProcuradoria.Size = New System.Drawing.Size(781, 275)
        Me.TabControlINSSProcuradoria.TabIndex = 1
        '
        'TabPage15
        '
        Me.TabPage15.AutoScroll = True
        Me.TabPage15.Controls.Add(Me.ProtprocRichTextBox)
        Me.TabPage15.Controls.Add(Me.BtnAgoraINSSProcuradoria)
        Me.TabPage15.Controls.Add(Me.BtnRegistrarINSSProcuradoria)
        Me.TabPage15.Controls.Add(Me.LblFinalizadoDataINSSProcuradoria)
        Me.TabPage15.Controls.Add(Me.LabelMotivoINSSProc)
        Me.TabPage15.Controls.Add(FinalizadoINSSProcLabel)
        Me.TabPage15.Controls.Add(Me.FinalizadoINSSProcComboBox)
        Me.TabPage15.Controls.Add(ParcelEnvINSSProcLabel)
        Me.TabPage15.Controls.Add(Me.ParcelEnvINSSProcTextBox)
        Me.TabPage15.Controls.Add(TotalParcProcLabel)
        Me.TabPage15.Controls.Add(Me.TotalParcProcTextBox)
        Me.TabPage15.Controls.Add(ProtprocLabel)
        Me.TabPage15.Controls.Add(Me.MotivoProcRichTextBox)
        Me.TabPage15.Controls.Add(Me.DataFinalProcMaskedTextBox)
        Me.TabPage15.Controls.Add(DataEnviaProcLabel)
        Me.TabPage15.Controls.Add(Me.DataEnviaProcMaskedTextBox)
        Me.TabPage15.Controls.Add(DataSolicProcLabel)
        Me.TabPage15.Controls.Add(Me.DataSolicProcMaskedTextBox)
        Me.TabPage15.Location = New System.Drawing.Point(4, 27)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(773, 244)
        Me.TabPage15.TabIndex = 0
        Me.TabPage15.Text = "Parcelamento"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'ProtprocRichTextBox
        '
        Me.ProtprocRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Protproc", True))
        Me.ProtprocRichTextBox.Location = New System.Drawing.Point(150, 41)
        Me.ProtprocRichTextBox.Name = "ProtprocRichTextBox"
        Me.ProtprocRichTextBox.Size = New System.Drawing.Size(286, 68)
        Me.ProtprocRichTextBox.TabIndex = 23
        Me.ProtprocRichTextBox.Text = ""
        '
        'BtnAgoraINSSProcuradoria
        '
        Me.BtnAgoraINSSProcuradoria.Location = New System.Drawing.Point(279, 170)
        Me.BtnAgoraINSSProcuradoria.Name = "BtnAgoraINSSProcuradoria"
        Me.BtnAgoraINSSProcuradoria.Size = New System.Drawing.Size(75, 28)
        Me.BtnAgoraINSSProcuradoria.TabIndex = 22
        Me.BtnAgoraINSSProcuradoria.Text = "Agora"
        Me.BtnAgoraINSSProcuradoria.UseVisualStyleBackColor = True
        '
        'BtnRegistrarINSSProcuradoria
        '
        Me.BtnRegistrarINSSProcuradoria.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.FundoBotaoNormal
        Me.BtnRegistrarINSSProcuradoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistrarINSSProcuradoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarINSSProcuradoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegistrarINSSProcuradoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarINSSProcuradoria.Location = New System.Drawing.Point(361, 170)
        Me.BtnRegistrarINSSProcuradoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegistrarINSSProcuradoria.Name = "BtnRegistrarINSSProcuradoria"
        Me.BtnRegistrarINSSProcuradoria.Size = New System.Drawing.Size(155, 56)
        Me.BtnRegistrarINSSProcuradoria.TabIndex = 21
        Me.BtnRegistrarINSSProcuradoria.Text = "Registrar Envio"
        Me.BtnRegistrarINSSProcuradoria.UseVisualStyleBackColor = True
        '
        'LblFinalizadoDataINSSProcuradoria
        '
        Me.LblFinalizadoDataINSSProcuradoria.AutoSize = True
        Me.LblFinalizadoDataINSSProcuradoria.Location = New System.Drawing.Point(516, 41)
        Me.LblFinalizadoDataINSSProcuradoria.Name = "LblFinalizadoDataINSSProcuradoria"
        Me.LblFinalizadoDataINSSProcuradoria.Size = New System.Drawing.Size(104, 18)
        Me.LblFinalizadoDataINSSProcuradoria.TabIndex = 19
        Me.LblFinalizadoDataINSSProcuradoria.Text = "Finalizado em:"
        '
        'LabelMotivoINSSProc
        '
        Me.LabelMotivoINSSProc.AutoSize = True
        Me.LabelMotivoINSSProc.Location = New System.Drawing.Point(520, 73)
        Me.LabelMotivoINSSProc.Name = "LabelMotivoINSSProc"
        Me.LabelMotivoINSSProc.Size = New System.Drawing.Size(57, 18)
        Me.LabelMotivoINSSProc.TabIndex = 17
        Me.LabelMotivoINSSProc.Text = "Motivo:"
        '
        'FinalizadoINSSProcComboBox
        '
        Me.FinalizadoINSSProcComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoINSSProc", True))
        Me.FinalizadoINSSProcComboBox.FormattingEnabled = True
        Me.FinalizadoINSSProcComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.FinalizadoINSSProcComboBox.Location = New System.Drawing.Point(665, 6)
        Me.FinalizadoINSSProcComboBox.Name = "FinalizadoINSSProcComboBox"
        Me.FinalizadoINSSProcComboBox.Size = New System.Drawing.Size(86, 26)
        Me.FinalizadoINSSProcComboBox.TabIndex = 15
        '
        'ParcelEnvINSSProcTextBox
        '
        Me.ParcelEnvINSSProcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "ParcelEnvINSSProc", True))
        Me.ParcelEnvINSSProcTextBox.Location = New System.Drawing.Point(148, 202)
        Me.ParcelEnvINSSProcTextBox.Name = "ParcelEnvINSSProcTextBox"
        Me.ParcelEnvINSSProcTextBox.Size = New System.Drawing.Size(206, 24)
        Me.ParcelEnvINSSProcTextBox.TabIndex = 13
        '
        'TotalParcProcTextBox
        '
        Me.TotalParcProcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "TotalParcProc", True))
        Me.TotalParcProcTextBox.Location = New System.Drawing.Point(150, 114)
        Me.TotalParcProcTextBox.Name = "TotalParcProcTextBox"
        Me.TotalParcProcTextBox.Size = New System.Drawing.Size(283, 24)
        Me.TotalParcProcTextBox.TabIndex = 11
        '
        'MotivoProcRichTextBox
        '
        Me.MotivoProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoProc", True))
        Me.MotivoProcRichTextBox.Location = New System.Drawing.Point(523, 94)
        Me.MotivoProcRichTextBox.Name = "MotivoProcRichTextBox"
        Me.MotivoProcRichTextBox.Size = New System.Drawing.Size(228, 132)
        Me.MotivoProcRichTextBox.TabIndex = 7
        Me.MotivoProcRichTextBox.Text = ""
        '
        'DataFinalProcMaskedTextBox
        '
        Me.DataFinalProcMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataFinalProc", True))
        Me.DataFinalProcMaskedTextBox.Location = New System.Drawing.Point(626, 38)
        Me.DataFinalProcMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataFinalProcMaskedTextBox.Name = "DataFinalProcMaskedTextBox"
        Me.DataFinalProcMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataFinalProcMaskedTextBox.TabIndex = 5
        Me.DataFinalProcMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataEnviaProcMaskedTextBox
        '
        Me.DataEnviaProcMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataEnviaProc", True))
        Me.DataEnviaProcMaskedTextBox.Location = New System.Drawing.Point(148, 172)
        Me.DataEnviaProcMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataEnviaProcMaskedTextBox.Name = "DataEnviaProcMaskedTextBox"
        Me.DataEnviaProcMaskedTextBox.Size = New System.Drawing.Size(125, 24)
        Me.DataEnviaProcMaskedTextBox.TabIndex = 3
        Me.DataEnviaProcMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataSolicProcMaskedTextBox
        '
        Me.DataSolicProcMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "DataSolicProc", True))
        Me.DataSolicProcMaskedTextBox.Location = New System.Drawing.Point(150, 10)
        Me.DataSolicProcMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataSolicProcMaskedTextBox.Name = "DataSolicProcMaskedTextBox"
        Me.DataSolicProcMaskedTextBox.Size = New System.Drawing.Size(141, 24)
        Me.DataSolicProcMaskedTextBox.TabIndex = 1
        Me.DataSolicProcMaskedTextBox.ValidatingType = GetType(Date)
        '
        'TabPage16
        '
        Me.TabPage16.AutoScroll = True
        Me.TabPage16.Controls.Add(Me.EnviaParcProcRichTextBox)
        Me.TabPage16.Location = New System.Drawing.Point(4, 27)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage16.Size = New System.Drawing.Size(773, 244)
        Me.TabPage16.TabIndex = 1
        Me.TabPage16.Text = "Histórico de Envio"
        Me.TabPage16.UseVisualStyleBackColor = True
        '
        'EnviaParcProcRichTextBox
        '
        Me.EnviaParcProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "EnviaParcProc", True))
        Me.EnviaParcProcRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnviaParcProcRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.EnviaParcProcRichTextBox.Name = "EnviaParcProcRichTextBox"
        Me.EnviaParcProcRichTextBox.Size = New System.Drawing.Size(767, 238)
        Me.EnviaParcProcRichTextBox.TabIndex = 1
        Me.EnviaParcProcRichTextBox.Text = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBarSalvar, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(907, 718)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ParcelamentosBindingNavigator
        '
        Me.ParcelamentosBindingNavigator.AddNewItem = Nothing
        Me.ParcelamentosBindingNavigator.BindingSource = Me.ParcelamentosBindingSource
        Me.ParcelamentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParcelamentosBindingNavigator.DeleteItem = Nothing
        Me.ParcelamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ParcelamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParcelamentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParcelamentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParcelamentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParcelamentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParcelamentosBindingNavigator.Name = "ParcelamentosBindingNavigator"
        Me.ParcelamentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParcelamentosBindingNavigator.Size = New System.Drawing.Size(907, 25)
        Me.ParcelamentosBindingNavigator.TabIndex = 1
        Me.ParcelamentosBindingNavigator.Text = "BindingNavigator1"
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
        'FrmParcelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(907, 718)
        Me.Controls.Add(Me.ParcelamentosBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmParcelamento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Parcelamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControlGeral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControlParcelamento.ResumeLayout(False)
        Me.TabPageMei.ResumeLayout(False)
        Me.TabControlMei.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPageINSSAntigo.ResumeLayout(False)
        Me.TabControlINSSAntigo.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPageINSSNovo.ResumeLayout(False)
        Me.TabControlINSSNovo.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        Me.TabPage14.ResumeLayout(False)
        Me.TabPageINSSProcuradoria.ResumeLayout(False)
        Me.TabControlINSSProcuradoria.ResumeLayout(False)
        Me.TabPage15.ResumeLayout(False)
        Me.TabPage15.PerformLayout()
        Me.TabPage16.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParcelamentosBindingNavigator.ResumeLayout(False)
        Me.ParcelamentosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBarSalvar As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControlGeral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataFinalizadoMaskedTextBox As MaskedTextBox
    Friend WithEvents DataLembreteMaskedTextBox As MaskedTextBox
    Friend WithEvents DataCriacaoMaskedTextBox As MaskedTextBox
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents WhatsappMaskedTextBox As MaskedTextBox
    Friend WithEvents ResponsavelTextBox As TextBox
    Friend WithEvents FormaDeEnvioComboBox As ComboBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents SenhaGovTextBox As TextBox
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents SocioTextBox As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabControlParcelamento As TabControl
    Friend WithEvents TabPageMei As TabPage
    Friend WithEvents TabControlMei As TabControl
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents ParcelEnvMEITextBox As TextBox
    Friend WithEvents TotalParcMEITextBox As TextBox
    Friend WithEvents ProtMEITextBox As TextBox
    Friend WithEvents MotivoMEIRichTextBox As RichTextBox
    Friend WithEvents DataFinalMEIMaskedTextBox As MaskedTextBox
    Friend WithEvents DataEnviaMEIMaskedTextBox As MaskedTextBox
    Friend WithEvents DataSolicMEIMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents EnviaParcMEIRichTextBox As RichTextBox
    Friend WithEvents TabPageINSSAntigo As TabPage
    Friend WithEvents TabControlINSSAntigo As TabControl
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents ParcelEnvINSSAntTextBox As TextBox
    Friend WithEvents TotalParcAntigoTextBox As TextBox
    Friend WithEvents MotivoAntigoRichTextBox As RichTextBox
    Friend WithEvents DataFinalAntigoMaskedTextBox As MaskedTextBox
    Friend WithEvents DataEnviaAntigoMaskedTextBox As MaskedTextBox
    Friend WithEvents DataSolicAntigoMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents EnviaParcAntigoRichTextBox As RichTextBox
    Friend WithEvents TabPageINSSNovo As TabPage
    Friend WithEvents TabControlINSSNovo As TabControl
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents ParcelEnvINSSNovTextBox As TextBox
    Friend WithEvents MotivoNovoRichTextBox As RichTextBox
    Friend WithEvents DataFinalNovoMaskedTextBox As MaskedTextBox
    Friend WithEvents DataEnvioNovoMaskedTextBox As MaskedTextBox
    Friend WithEvents TotalParcNovoTextBox As TextBox
    Friend WithEvents DataSolicNovoMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents EnviaParcNovoRichTextBox As RichTextBox
    Friend WithEvents TabPageINSSProcuradoria As TabPage
    Friend WithEvents TabControlINSSProcuradoria As TabControl
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents ParcelEnvINSSProcTextBox As TextBox
    Friend WithEvents TotalParcProcTextBox As TextBox
    Friend WithEvents MotivoProcRichTextBox As RichTextBox
    Friend WithEvents DataFinalProcMaskedTextBox As MaskedTextBox
    Friend WithEvents DataEnviaProcMaskedTextBox As MaskedTextBox
    Friend WithEvents DataSolicProcMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage16 As TabPage
    Friend WithEvents EnviaParcProcRichTextBox As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents ParcelamentosTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParcelamentosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RazaoSocialTextBox1 As TextBox
    Friend WithEvents InssProcurCheckBox As CheckBox
    Friend WithEvents InssNovoCheckBox As CheckBox
    Friend WithEvents InssAntigoCheckBox As CheckBox
    Friend WithEvents MEICheckBox As CheckBox
    Friend WithEvents ComboBoxBuscarRazaoSocial As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FinalizadoEmpresaComboBox As ComboBox
    Friend WithEvents FinalizadoMEIComboBox As ComboBox
    Friend WithEvents FinalizadoINSSAntComboBox As ComboBox
    Friend WithEvents FinalizadoINSSNovComboBox As ComboBox
    Friend WithEvents FinalizadoINSSProcComboBox As ComboBox
    Friend WithEvents LabelDataFinalizado As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LabelMotivoINSSAntigo As Label
    Friend WithEvents LabelMotivoMEI As Label
    Friend WithEvents LabelMotivoINSSNovo As Label
    Friend WithEvents LabelMotivoINSSProc As Label
    Friend WithEvents LblFinalizadoDataMEI As Label
    Friend WithEvents LblFinalizadoDataINSSAntigo As Label
    Friend WithEvents LblFinalizadoDataINSSNovo As Label
    Friend WithEvents LblFinalizadoDataINSSProcuradoria As Label
    Friend WithEvents BtnRegistrarMEI As Button
    Friend WithEvents BtnAgoraMEI As Button
    Friend WithEvents BtnAgoraINSSAntigo As Button
    Friend WithEvents BtnRegistrarINSSAntigo As Button
    Friend WithEvents BtnAgoraINSSNovo As Button
    Friend WithEvents BtnRegistrarINSSNovo As Button
    Friend WithEvents BtnAgoraINSSProcuradoria As Button
    Friend WithEvents BtnRegistrarINSSProcuradoria As Button
    Friend WithEvents BtnCopiarCNPJ As Button
    Friend WithEvents BtnImportar As Button
    Friend WithEvents FinalizadoMesGeralComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProtprocRichTextBox As RichTextBox
    Friend WithEvents BtnDataCriacao As Button
    Friend WithEvents ProtAntigoRichTextBox As RichTextBox
    Friend WithEvents ProtNovoRichTextBox As RichTextBox
    Friend WithEvents BtnConsultaSimplesNacional As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
