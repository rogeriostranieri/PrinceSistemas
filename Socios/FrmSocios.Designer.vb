﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim CPFdoCONJUGELabel As System.Windows.Forms.Label
        Dim NOMEdoCONJUGELabel As System.Windows.Forms.Label
        Dim ProfissãoLabel As System.Windows.Forms.Label
        Dim OutrosDadosLabel As System.Windows.Forms.Label
        Dim RegistroOrgaoLabel As System.Windows.Forms.Label
        Dim RegistroEstadoLabel As System.Windows.Forms.Label
        Dim RegistroNumeroLabel As System.Windows.Forms.Label
        Dim RegistroDataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSocios))
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CPFComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeCompletoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SociosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.SociosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDadosPessoais = New System.Windows.Forms.GroupBox()
        Me.RegistroDataMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BtnConsultaRegistroEntidades = New System.Windows.Forms.Button()
        Me.RegistroNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.RegistroEstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.RegistroOrgaoComboBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabelArrumaOrgaoRG = New System.Windows.Forms.LinkLabel()
        Me.LblMenorIdade = New System.Windows.Forms.Label()
        Me.MenorIdadeComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnCopiarCPF = New System.Windows.Forms.Button()
        Me.BtnAtalhoConjuge = New System.Windows.Forms.Button()
        Me.BtnAtalhoEndereco = New System.Windows.Forms.Button()
        Me.BtnCopiarSenhaGov = New System.Windows.Forms.Button()
        Me.BtnDuplicidade = New System.Windows.Forms.Button()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.CivilTextBox = New System.Windows.Forms.TextBox()
        Me.BtnConsultarTituloDeEleitor = New System.Windows.Forms.Button()
        Me.CNHDataExpMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ListBoxEstadoCivil = New System.Windows.Forms.ListBox()
        Me.ProfissãoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnConsultaCPF = New System.Windows.Forms.Button()
        Me.TextBoxExtensoDN = New System.Windows.Forms.TextBox()
        Me.BtnExtensoDN = New System.Windows.Forms.Button()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.CNHExpedicaoTextBox = New System.Windows.Forms.TextBox()
        Me.CNHTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaGOVTextBox = New System.Windows.Forms.TextBox()
        Me.TituloDeEleitorTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoRGTextBox = New System.Windows.Forms.TextBox()
        Me.OrgaoRGTextBox = New System.Windows.Forms.TextBox()
        Me.RGTextBox = New System.Windows.Forms.TextBox()
        Me.DatadeNascMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NomePaiTextBox = New System.Windows.Forms.TextBox()
        Me.NomeMaeTextBox = New System.Windows.Forms.TextBox()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBoxOutrosDados = New System.Windows.Forms.GroupBox()
        Me.BtnCorrigeCidade = New System.Windows.Forms.Button()
        Me.BtnArrumaEnd = New System.Windows.Forms.Button()
        Me.BtnCopiaCEP = New System.Windows.Forms.Button()
        Me.BtnAtalhoConjuge2 = New System.Windows.Forms.Button()
        Me.BtnAtablhoSocio = New System.Windows.Forms.Button()
        Me.BtnCorreios = New System.Windows.Forms.Button()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.Telefone2MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PaísTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.NumTextBox = New System.Windows.Forms.TextBox()
        Me.RUATextBox = New System.Windows.Forms.TextBox()
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBoxConjuge = New System.Windows.Forms.GroupBox()
        Me.BtnAtalhoEndereco3 = New System.Windows.Forms.Button()
        Me.BtnAtablhoSocio3 = New System.Windows.Forms.Button()
        Me.NOMEdoCONJUGETextBox = New System.Windows.Forms.TextBox()
        Me.CPFdoCONJUGEMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OutrosDadosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.LblContaEmpresa = New System.Windows.Forms.Label()
        Me.DataGridViewEmpresa = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarEmpresa = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnParcelamentos = New System.Windows.Forms.Button()
        Me.BtnExportaSocioLaudo = New System.Windows.Forms.Button()
        Me.BtnCapitalSocial = New System.Windows.Forms.Button()
        Me.BtnAddSocios = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnFecharMenu = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnWord = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GroupBoxMenuCapitalSocial = New System.Windows.Forms.GroupBox()
        Me.BtnCapitalEmpresas = New System.Windows.Forms.Button()
        Me.BtnADDSocioCapital = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.ButtonPorcentagem = New System.Windows.Forms.Button()
        Me.GroupBoxCapitalSocial = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnSocio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPorcentagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAntigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNovo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GanhaEPerca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblCapTotal = New System.Windows.Forms.Label()
        Me.TextBoxCapitalSocial = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
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
        GeneroLabel = New System.Windows.Forms.Label()
        CPFdoCONJUGELabel = New System.Windows.Forms.Label()
        NOMEdoCONJUGELabel = New System.Windows.Forms.Label()
        ProfissãoLabel = New System.Windows.Forms.Label()
        OutrosDadosLabel = New System.Windows.Forms.Label()
        RegistroOrgaoLabel = New System.Windows.Forms.Label()
        RegistroEstadoLabel = New System.Windows.Forms.Label()
        RegistroNumeroLabel = New System.Windows.Forms.Label()
        RegistroDataLabel = New System.Windows.Forms.Label()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxDadosPessoais.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBoxOutrosDados.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBoxConjuge.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridViewEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxMenuCapitalSocial.SuspendLayout()
        Me.GroupBoxCapitalSocial.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SociosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SociosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(51, 35)
        CEPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(34, 15)
        CEPLabel.TabIndex = 29
        CEPLabel.Text = "CEP:"
        '
        'RUALabel
        '
        RUALabel.AutoSize = True
        RUALabel.Location = New System.Drawing.Point(49, 65)
        RUALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RUALabel.Name = "RUALabel"
        RUALabel.Size = New System.Drawing.Size(33, 15)
        RUALabel.TabIndex = 31
        RUALabel.Text = "Rua:"
        '
        'NumLabel
        '
        NumLabel.AutoSize = True
        NumLabel.Location = New System.Drawing.Point(50, 95)
        NumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumLabel.Name = "NumLabel"
        NumLabel.Size = New System.Drawing.Size(37, 15)
        NumLabel.TabIndex = 33
        NumLabel.Text = "Num:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(44, 125)
        BairroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(43, 15)
        BairroLabel.TabIndex = 35
        BairroLabel.Text = "Bairro:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(177, 95)
        ComplementoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(88, 15)
        ComplementoLabel.TabIndex = 37
        ComplementoLabel.Text = "Complemento:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(37, 155)
        CidadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(49, 15)
        CidadeLabel.TabIndex = 39
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(304, 155)
        EstadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(48, 15)
        EstadoLabel.TabIndex = 41
        EstadoLabel.Text = "Estado:"
        '
        'PaísLabel
        '
        PaísLabel.AutoSize = True
        PaísLabel.Location = New System.Drawing.Point(50, 185)
        PaísLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaísLabel.Name = "PaísLabel"
        PaísLabel.Size = New System.Drawing.Size(34, 15)
        PaísLabel.TabIndex = 43
        PaísLabel.Text = "País:"
        '
        'Telefone1Label
        '
        Telefone1Label.AutoSize = True
        Telefone1Label.Location = New System.Drawing.Point(16, 215)
        Telefone1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone1Label.Name = "Telefone1Label"
        Telefone1Label.Size = New System.Drawing.Size(68, 15)
        Telefone1Label.TabIndex = 45
        Telefone1Label.Text = "Telefone 1:"
        '
        'Telefone2Label
        '
        Telefone2Label.AutoSize = True
        Telefone2Label.Location = New System.Drawing.Point(16, 245)
        Telefone2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone2Label.Name = "Telefone2Label"
        Telefone2Label.Size = New System.Drawing.Size(68, 15)
        Telefone2Label.TabIndex = 47
        Telefone2Label.Text = "Telefone 2:"
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(43, 275)
        EMailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(45, 15)
        EMailLabel.TabIndex = 49
        EMailLabel.Text = "e-Mail:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(99, 31)
        CPFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(33, 15)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.Location = New System.Drawing.Point(35, 61)
        NomeCompletoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(100, 15)
        NomeCompletoLabel.TabIndex = 3
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'NomeMaeLabel
        '
        NomeMaeLabel.AutoSize = True
        NomeMaeLabel.Location = New System.Drawing.Point(44, 91)
        NomeMaeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeMaeLabel.Name = "NomeMaeLabel"
        NomeMaeLabel.Size = New System.Drawing.Size(89, 15)
        NomeMaeLabel.TabIndex = 5
        NomeMaeLabel.Text = "Nome da Mae:"
        '
        'NomePaiLabel
        '
        NomePaiLabel.AutoSize = True
        NomePaiLabel.Location = New System.Drawing.Point(51, 121)
        NomePaiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomePaiLabel.Name = "NomePaiLabel"
        NomePaiLabel.Size = New System.Drawing.Size(82, 15)
        NomePaiLabel.TabIndex = 7
        NomePaiLabel.Text = "Nome do Pai:"
        '
        'DatadeNascLabel
        '
        DatadeNascLabel.AutoSize = True
        DatadeNascLabel.Location = New System.Drawing.Point(9, 150)
        DatadeNascLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DatadeNascLabel.Name = "DatadeNascLabel"
        DatadeNascLabel.Size = New System.Drawing.Size(122, 15)
        DatadeNascLabel.TabIndex = 9
        DatadeNascLabel.Text = "Data de Nascimento:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Location = New System.Drawing.Point(104, 269)
        RGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(28, 15)
        RGLabel.TabIndex = 11
        RGLabel.Text = "RG:"
        '
        'OrgaoRGLabel
        '
        OrgaoRGLabel.AutoSize = True
        OrgaoRGLabel.Location = New System.Drawing.Point(286, 269)
        OrgaoRGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OrgaoRGLabel.Name = "OrgaoRGLabel"
        OrgaoRGLabel.Size = New System.Drawing.Size(65, 15)
        OrgaoRGLabel.TabIndex = 13
        OrgaoRGLabel.Text = "Orgao RG:"
        '
        'EstadoRGLabel
        '
        EstadoRGLabel.AutoSize = True
        EstadoRGLabel.Location = New System.Drawing.Point(430, 269)
        EstadoRGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EstadoRGLabel.Name = "EstadoRGLabel"
        EstadoRGLabel.Size = New System.Drawing.Size(69, 15)
        EstadoRGLabel.TabIndex = 15
        EstadoRGLabel.Text = "Estado RG:"
        '
        'TituloDeEleitorLabel
        '
        TituloDeEleitorLabel.AutoSize = True
        TituloDeEleitorLabel.Location = New System.Drawing.Point(35, 299)
        TituloDeEleitorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TituloDeEleitorLabel.Name = "TituloDeEleitorLabel"
        TituloDeEleitorLabel.Size = New System.Drawing.Size(97, 15)
        TituloDeEleitorLabel.TabIndex = 17
        TituloDeEleitorLabel.Text = "Titulo De Eleitor:"
        '
        'SenhaGOVLabel
        '
        SenhaGOVLabel.AutoSize = True
        SenhaGOVLabel.Location = New System.Drawing.Point(56, 234)
        SenhaGOVLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SenhaGOVLabel.Name = "SenhaGOVLabel"
        SenhaGOVLabel.Size = New System.Drawing.Size(74, 15)
        SenhaGOVLabel.TabIndex = 19
        SenhaGOVLabel.Text = "Senha GOV:"
        '
        'CNHLabel
        '
        CNHLabel.AutoSize = True
        CNHLabel.Location = New System.Drawing.Point(96, 329)
        CNHLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNHLabel.Name = "CNHLabel"
        CNHLabel.Size = New System.Drawing.Size(36, 15)
        CNHLabel.TabIndex = 21
        CNHLabel.Text = "CNH:"
        '
        'CNHExpedicaoLabel
        '
        CNHExpedicaoLabel.AutoSize = True
        CNHExpedicaoLabel.Location = New System.Drawing.Point(424, 329)
        CNHExpedicaoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNHExpedicaoLabel.Name = "CNHExpedicaoLabel"
        CNHExpedicaoLabel.Size = New System.Drawing.Size(44, 15)
        CNHExpedicaoLabel.TabIndex = 23
        CNHExpedicaoLabel.Text = "Orgão:"
        '
        'CNHDataExpLabel
        '
        CNHDataExpLabel.AutoSize = True
        CNHDataExpLabel.Location = New System.Drawing.Point(279, 329)
        CNHDataExpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNHDataExpLabel.Name = "CNHDataExpLabel"
        CNHDataExpLabel.Size = New System.Drawing.Size(60, 15)
        CNHDataExpLabel.TabIndex = 25
        CNHDataExpLabel.Text = "Data Exp:"
        '
        'CivilLabel
        '
        CivilLabel.AutoSize = True
        CivilLabel.Location = New System.Drawing.Point(58, 203)
        CivilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CivilLabel.Name = "CivilLabel"
        CivilLabel.Size = New System.Drawing.Size(73, 15)
        CivilLabel.TabIndex = 27
        CivilLabel.Text = "Estado Civil:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(374, 31)
        GeneroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(51, 15)
        GeneroLabel.TabIndex = 28
        GeneroLabel.Text = "Genero:"
        '
        'CPFdoCONJUGELabel
        '
        CPFdoCONJUGELabel.AutoSize = True
        CPFdoCONJUGELabel.Location = New System.Drawing.Point(70, 32)
        CPFdoCONJUGELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CPFdoCONJUGELabel.Name = "CPFdoCONJUGELabel"
        CPFdoCONJUGELabel.Size = New System.Drawing.Size(99, 15)
        CPFdoCONJUGELabel.TabIndex = 0
        CPFdoCONJUGELabel.Text = "CPF do Cônjuge:"
        '
        'NOMEdoCONJUGELabel
        '
        NOMEdoCONJUGELabel.AutoSize = True
        NOMEdoCONJUGELabel.Location = New System.Drawing.Point(9, 63)
        NOMEdoCONJUGELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMEdoCONJUGELabel.Name = "NOMEdoCONJUGELabel"
        NOMEdoCONJUGELabel.Size = New System.Drawing.Size(166, 15)
        NOMEdoCONJUGELabel.TabIndex = 2
        NOMEdoCONJUGELabel.Text = "Nome Completo do Cônjuge:"
        '
        'ProfissãoLabel
        '
        ProfissãoLabel.AutoSize = True
        ProfissãoLabel.Location = New System.Drawing.Point(340, 234)
        ProfissãoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProfissãoLabel.Name = "ProfissãoLabel"
        ProfissãoLabel.Size = New System.Drawing.Size(61, 15)
        ProfissãoLabel.TabIndex = 56
        ProfissãoLabel.Text = "Profissão:"
        '
        'OutrosDadosLabel
        '
        OutrosDadosLabel.AutoSize = True
        OutrosDadosLabel.Location = New System.Drawing.Point(8, 18)
        OutrosDadosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OutrosDadosLabel.Name = "OutrosDadosLabel"
        OutrosDadosLabel.Size = New System.Drawing.Size(85, 15)
        OutrosDadosLabel.TabIndex = 0
        OutrosDadosLabel.Text = "Outros Dados:"
        '
        'RegistroOrgaoLabel
        '
        RegistroOrgaoLabel.AutoSize = True
        RegistroOrgaoLabel.Location = New System.Drawing.Point(10, 357)
        RegistroOrgaoLabel.Name = "RegistroOrgaoLabel"
        RegistroOrgaoLabel.Size = New System.Drawing.Size(123, 15)
        RegistroOrgaoLabel.TabIndex = 70
        RegistroOrgaoLabel.Text = "Registro Profissional:"
        '
        'RegistroEstadoLabel
        '
        RegistroEstadoLabel.AutoSize = True
        RegistroEstadoLabel.Location = New System.Drawing.Point(260, 355)
        RegistroEstadoLabel.Name = "RegistroEstadoLabel"
        RegistroEstadoLabel.Size = New System.Drawing.Size(48, 15)
        RegistroEstadoLabel.TabIndex = 71
        RegistroEstadoLabel.Text = "Estado:"
        '
        'RegistroNumeroLabel
        '
        RegistroNumeroLabel.AutoSize = True
        RegistroNumeroLabel.Location = New System.Drawing.Point(382, 355)
        RegistroNumeroLabel.Name = "RegistroNumeroLabel"
        RegistroNumeroLabel.Size = New System.Drawing.Size(55, 15)
        RegistroNumeroLabel.TabIndex = 72
        RegistroNumeroLabel.Text = "Numero:"
        '
        'RegistroDataLabel
        '
        RegistroDataLabel.AutoSize = True
        RegistroDataLabel.Location = New System.Drawing.Point(6, 384)
        RegistroDataLabel.Name = "RegistroDataLabel"
        RegistroDataLabel.Size = New System.Drawing.Size(134, 15)
        RegistroDataLabel.TabIndex = 74
        RegistroDataLabel.Text = "Data de Inscrição Reg.:"
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "Socios"
        Me.SociosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CPFComboBox
        '
        Me.CPFComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CPFComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CPFComboBox.DataSource = Me.SociosBindingSource
        Me.CPFComboBox.DisplayMember = "CPF"
        Me.CPFComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFComboBox.FormattingEnabled = True
        Me.CPFComboBox.Location = New System.Drawing.Point(392, 67)
        Me.CPFComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CPFComboBox.Name = "CPFComboBox"
        Me.CPFComboBox.Size = New System.Drawing.Size(135, 24)
        Me.CPFComboBox.TabIndex = 8
        Me.CPFComboBox.ValueMember = "CPF"
        '
        'NomeCompletoComboBox
        '
        Me.NomeCompletoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NomeCompletoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomeCompletoComboBox.DataSource = Me.SociosBindingSource
        Me.NomeCompletoComboBox.DisplayMember = "NomeCompleto"
        Me.NomeCompletoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCompletoComboBox.FormattingEnabled = True
        Me.NomeCompletoComboBox.Location = New System.Drawing.Point(49, 67)
        Me.NomeCompletoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NomeCompletoComboBox.Name = "NomeCompletoComboBox"
        Me.NomeCompletoComboBox.Size = New System.Drawing.Size(294, 24)
        Me.NomeCompletoComboBox.TabIndex = 7
        Me.NomeCompletoComboBox.ValueMember = "NomeCompleto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CPF's:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomes:"
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
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
        Me.TableAdapterManager.ParcelamentosTableAdapter = Nothing
        Me.TableAdapterManager.RegistroProfissionalTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Me.SociosTableAdapter
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(4, 109)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(697, 446)
        Me.TabControl1.TabIndex = 61
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBoxDadosPessoais)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(689, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sócio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBoxDadosPessoais
        '
        Me.GroupBoxDadosPessoais.AutoSize = True
        Me.GroupBoxDadosPessoais.Controls.Add(RegistroDataLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.RegistroDataMaskedTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnConsultaRegistroEntidades)
        Me.GroupBoxDadosPessoais.Controls.Add(RegistroNumeroLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.RegistroNumeroTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(RegistroEstadoLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.RegistroEstadoComboBox)
        Me.GroupBoxDadosPessoais.Controls.Add(RegistroOrgaoLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.RegistroOrgaoComboBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.LinkLabelArrumaOrgaoRG)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.LblMenorIdade)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.MenorIdadeComboBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnCopiarCPF)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnAtalhoConjuge)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnAtalhoEndereco)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnCopiarSenhaGov)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnDuplicidade)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.NomeCompletoTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CivilTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnConsultarTituloDeEleitor)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CNHDataExpMaskedTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.ListBoxEstadoCivil)
        Me.GroupBoxDadosPessoais.Controls.Add(ProfissãoLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.ProfissãoTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnConsultaCPF)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.TextBoxExtensoDN)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnExtensoDN)
        Me.GroupBoxDadosPessoais.Controls.Add(GeneroLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.GeneroComboBox)
        Me.GroupBoxDadosPessoais.Controls.Add(CivilLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(CNHDataExpLabel)
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
        Me.GroupBoxDadosPessoais.Controls.Add(CPFLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CPFMaskedTextBox)
        Me.GroupBoxDadosPessoais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxDadosPessoais.Location = New System.Drawing.Point(4, 3)
        Me.GroupBoxDadosPessoais.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDadosPessoais.Name = "GroupBoxDadosPessoais"
        Me.GroupBoxDadosPessoais.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDadosPessoais.Size = New System.Drawing.Size(681, 409)
        Me.GroupBoxDadosPessoais.TabIndex = 52
        Me.GroupBoxDadosPessoais.TabStop = False
        Me.GroupBoxDadosPessoais.Text = "Dados Pessoais"
        '
        'RegistroDataMaskedTextBox
        '
        Me.RegistroDataMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RegistroData", True))
        Me.RegistroDataMaskedTextBox.Location = New System.Drawing.Point(141, 381)
        Me.RegistroDataMaskedTextBox.Mask = "00/00/0000"
        Me.RegistroDataMaskedTextBox.Name = "RegistroDataMaskedTextBox"
        Me.RegistroDataMaskedTextBox.Size = New System.Drawing.Size(83, 21)
        Me.RegistroDataMaskedTextBox.TabIndex = 75
        Me.RegistroDataMaskedTextBox.ValidatingType = GetType(Date)
        '
        'BtnConsultaRegistroEntidades
        '
        Me.BtnConsultaRegistroEntidades.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.interrogacao
        Me.BtnConsultaRegistroEntidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConsultaRegistroEntidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultaRegistroEntidades.FlatAppearance.BorderSize = 0
        Me.BtnConsultaRegistroEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaRegistroEntidades.Location = New System.Drawing.Point(226, 349)
        Me.BtnConsultaRegistroEntidades.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsultaRegistroEntidades.Name = "BtnConsultaRegistroEntidades"
        Me.BtnConsultaRegistroEntidades.Size = New System.Drawing.Size(31, 27)
        Me.BtnConsultaRegistroEntidades.TabIndex = 74
        Me.BtnConsultaRegistroEntidades.UseVisualStyleBackColor = True
        '
        'RegistroNumeroTextBox
        '
        Me.RegistroNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RegistroNumero", True))
        Me.RegistroNumeroTextBox.Location = New System.Drawing.Point(443, 354)
        Me.RegistroNumeroTextBox.Name = "RegistroNumeroTextBox"
        Me.RegistroNumeroTextBox.Size = New System.Drawing.Size(111, 21)
        Me.RegistroNumeroTextBox.TabIndex = 73
        '
        'RegistroEstadoComboBox
        '
        Me.RegistroEstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RegistroEstado", True))
        Me.RegistroEstadoComboBox.FormattingEnabled = True
        Me.RegistroEstadoComboBox.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.RegistroEstadoComboBox.Location = New System.Drawing.Point(314, 352)
        Me.RegistroEstadoComboBox.Name = "RegistroEstadoComboBox"
        Me.RegistroEstadoComboBox.Size = New System.Drawing.Size(61, 23)
        Me.RegistroEstadoComboBox.TabIndex = 72
        '
        'RegistroOrgaoComboBox
        '
        Me.RegistroOrgaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RegistroOrgao", True))
        Me.RegistroOrgaoComboBox.FormattingEnabled = True
        Me.RegistroOrgaoComboBox.Items.AddRange(New Object() {"OAB", "CRA", "CFA", "CAU", "CFESS", "CRESS", "CFB", "CRB", "CFBio", "CRBio", "CFBM", "CRBM", "CFC", "CRC", "COFECI", "CRECI", "COFECON", "CORECON", "CFED", "CRED", "CONFEF", "CREF", "COFEN", "COREN", "CONFEA", "CREA", "CONFE", "CONRE", "CFF", "CRF", "COFFITO", "CREFITO", "CFFa", "CREFONO", "CFM", "CRM", "CFMV", "CRMV", "COFEM", "COREM", "OMB", "CFN", "CRN", "CFO", "CRO", "CFP", "CRP", "CFQ", "CRQ", "CONFERP", "CONRERP", "CONFERE", "CORE", "CONTER", "CRTR", "CFT", "CRT", "CFTA", "CRTA"})
        Me.RegistroOrgaoComboBox.Location = New System.Drawing.Point(141, 352)
        Me.RegistroOrgaoComboBox.Name = "RegistroOrgaoComboBox"
        Me.RegistroOrgaoComboBox.Size = New System.Drawing.Size(83, 23)
        Me.RegistroOrgaoComboBox.TabIndex = 71
        '
        'LinkLabelArrumaOrgaoRG
        '
        Me.LinkLabelArrumaOrgaoRG.AutoSize = True
        Me.LinkLabelArrumaOrgaoRG.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelArrumaOrgaoRG.Location = New System.Drawing.Point(374, 286)
        Me.LinkLabelArrumaOrgaoRG.Name = "LinkLabelArrumaOrgaoRG"
        Me.LinkLabelArrumaOrgaoRG.Size = New System.Drawing.Size(51, 15)
        Me.LinkLabelArrumaOrgaoRG.TabIndex = 70
        Me.LinkLabelArrumaOrgaoRG.TabStop = True
        Me.LinkLabelArrumaOrgaoRG.Text = "Arrumar"
        '
        'LblMenorIdade
        '
        Me.LblMenorIdade.AutoSize = True
        Me.LblMenorIdade.Location = New System.Drawing.Point(232, 150)
        Me.LblMenorIdade.Name = "LblMenorIdade"
        Me.LblMenorIdade.Size = New System.Drawing.Size(97, 15)
        Me.LblMenorIdade.TabIndex = 69
        Me.LblMenorIdade.Text = "Menor de Idade:"
        '
        'MenorIdadeComboBox
        '
        Me.MenorIdadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "MenorIdade", True))
        Me.MenorIdadeComboBox.FormattingEnabled = True
        Me.MenorIdadeComboBox.Items.AddRange(New Object() {"menor impúbere", "menor púbere", "menor emancipado", "menor absoluto", "incapaz"})
        Me.MenorIdadeComboBox.Location = New System.Drawing.Point(331, 147)
        Me.MenorIdadeComboBox.Name = "MenorIdadeComboBox"
        Me.MenorIdadeComboBox.Size = New System.Drawing.Size(155, 23)
        Me.MenorIdadeComboBox.TabIndex = 68
        '
        'BtnCopiarCPF
        '
        Me.BtnCopiarCPF.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCopiarCPF.Location = New System.Drawing.Point(265, 27)
        Me.BtnCopiarCPF.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiarCPF.Name = "BtnCopiarCPF"
        Me.BtnCopiarCPF.Size = New System.Drawing.Size(54, 23)
        Me.BtnCopiarCPF.TabIndex = 67
        Me.BtnCopiarCPF.Text = "Copiar"
        Me.BtnCopiarCPF.UseVisualStyleBackColor = False
        '
        'BtnAtalhoConjuge
        '
        Me.BtnAtalhoConjuge.BackColor = System.Drawing.Color.Azure
        Me.BtnAtalhoConjuge.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAtalhoConjuge.FlatAppearance.BorderSize = 2
        Me.BtnAtalhoConjuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtalhoConjuge.Location = New System.Drawing.Point(566, 300)
        Me.BtnAtalhoConjuge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtalhoConjuge.Name = "BtnAtalhoConjuge"
        Me.BtnAtalhoConjuge.Size = New System.Drawing.Size(88, 27)
        Me.BtnAtalhoConjuge.TabIndex = 64
        Me.BtnAtalhoConjuge.Text = "Cônjuge"
        Me.BtnAtalhoConjuge.UseVisualStyleBackColor = False
        '
        'BtnAtalhoEndereco
        '
        Me.BtnAtalhoEndereco.BackColor = System.Drawing.Color.Azure
        Me.BtnAtalhoEndereco.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAtalhoEndereco.FlatAppearance.BorderSize = 2
        Me.BtnAtalhoEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtalhoEndereco.Location = New System.Drawing.Point(566, 267)
        Me.BtnAtalhoEndereco.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtalhoEndereco.Name = "BtnAtalhoEndereco"
        Me.BtnAtalhoEndereco.Size = New System.Drawing.Size(88, 27)
        Me.BtnAtalhoEndereco.TabIndex = 54
        Me.BtnAtalhoEndereco.Text = "Endereço"
        Me.BtnAtalhoEndereco.UseVisualStyleBackColor = False
        '
        'BtnCopiarSenhaGov
        '
        Me.BtnCopiarSenhaGov.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiarSenhaGov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCopiarSenhaGov.Location = New System.Drawing.Point(280, 231)
        Me.BtnCopiarSenhaGov.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiarSenhaGov.Name = "BtnCopiarSenhaGov"
        Me.BtnCopiarSenhaGov.Size = New System.Drawing.Size(54, 23)
        Me.BtnCopiarSenhaGov.TabIndex = 66
        Me.BtnCopiarSenhaGov.Text = "Copiar"
        Me.BtnCopiarSenhaGov.UseVisualStyleBackColor = False
        '
        'BtnDuplicidade
        '
        Me.BtnDuplicidade.BackColor = System.Drawing.Color.Azure
        Me.BtnDuplicidade.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnDuplicidade.FlatAppearance.BorderSize = 2
        Me.BtnDuplicidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDuplicidade.Location = New System.Drawing.Point(566, 14)
        Me.BtnDuplicidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnDuplicidade.Name = "BtnDuplicidade"
        Me.BtnDuplicidade.Size = New System.Drawing.Size(100, 48)
        Me.BtnDuplicidade.TabIndex = 65
        Me.BtnDuplicidade.Text = "Verifica CPF"
        Me.BtnDuplicidade.UseVisualStyleBackColor = False
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeCompleto", True))
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(141, 58)
        Me.NomeCompletoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(414, 21)
        Me.NomeCompletoTextBox.TabIndex = 63
        '
        'CivilTextBox
        '
        Me.CivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Civil", True))
        Me.CivilTextBox.Location = New System.Drawing.Point(141, 201)
        Me.CivilTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CivilTextBox.Name = "CivilTextBox"
        Me.CivilTextBox.ReadOnly = True
        Me.CivilTextBox.Size = New System.Drawing.Size(137, 21)
        Me.CivilTextBox.TabIndex = 62
        '
        'BtnConsultarTituloDeEleitor
        '
        Me.BtnConsultarTituloDeEleitor.BackColor = System.Drawing.Color.Azure
        Me.BtnConsultarTituloDeEleitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultarTituloDeEleitor.Location = New System.Drawing.Point(282, 295)
        Me.BtnConsultarTituloDeEleitor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsultarTituloDeEleitor.Name = "BtnConsultarTituloDeEleitor"
        Me.BtnConsultarTituloDeEleitor.Size = New System.Drawing.Size(71, 23)
        Me.BtnConsultarTituloDeEleitor.TabIndex = 61
        Me.BtnConsultarTituloDeEleitor.Text = "Consultar"
        Me.BtnConsultarTituloDeEleitor.UseVisualStyleBackColor = False
        '
        'CNHDataExpMaskedTextBox
        '
        Me.CNHDataExpMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNHDataExp", True))
        Me.CNHDataExpMaskedTextBox.Location = New System.Drawing.Point(342, 325)
        Me.CNHDataExpMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CNHDataExpMaskedTextBox.Mask = "00/00/0000"
        Me.CNHDataExpMaskedTextBox.Name = "CNHDataExpMaskedTextBox"
        Me.CNHDataExpMaskedTextBox.Size = New System.Drawing.Size(80, 21)
        Me.CNHDataExpMaskedTextBox.TabIndex = 60
        Me.CNHDataExpMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ListBoxEstadoCivil
        '
        Me.ListBoxEstadoCivil.FormattingEnabled = True
        Me.ListBoxEstadoCivil.ItemHeight = 15
        Me.ListBoxEstadoCivil.Location = New System.Drawing.Point(284, 201)
        Me.ListBoxEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListBoxEstadoCivil.Name = "ListBoxEstadoCivil"
        Me.ListBoxEstadoCivil.Size = New System.Drawing.Size(45, 19)
        Me.ListBoxEstadoCivil.TabIndex = 59
        '
        'ProfissãoTextBox
        '
        Me.ProfissãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Profissão", True))
        Me.ProfissãoTextBox.Location = New System.Drawing.Point(406, 231)
        Me.ProfissãoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProfissãoTextBox.Name = "ProfissãoTextBox"
        Me.ProfissãoTextBox.Size = New System.Drawing.Size(149, 21)
        Me.ProfissãoTextBox.TabIndex = 57
        '
        'BtnConsultaCPF
        '
        Me.BtnConsultaCPF.BackColor = System.Drawing.Color.Azure
        Me.BtnConsultaCPF.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnConsultaCPF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultaCPF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnConsultaCPF.Location = New System.Drawing.Point(566, 67)
        Me.BtnConsultaCPF.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsultaCPF.Name = "BtnConsultaCPF"
        Me.BtnConsultaCPF.Size = New System.Drawing.Size(100, 46)
        Me.BtnConsultaCPF.TabIndex = 56
        Me.BtnConsultaCPF.Text = "Consultar CPF na Federal"
        Me.BtnConsultaCPF.UseVisualStyleBackColor = False
        '
        'TextBoxExtensoDN
        '
        Me.TextBoxExtensoDN.Location = New System.Drawing.Point(141, 174)
        Me.TextBoxExtensoDN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxExtensoDN.Name = "TextBoxExtensoDN"
        Me.TextBoxExtensoDN.Size = New System.Drawing.Size(248, 21)
        Me.TextBoxExtensoDN.TabIndex = 53
        '
        'BtnExtensoDN
        '
        Me.BtnExtensoDN.BackColor = System.Drawing.Color.White
        Me.BtnExtensoDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExtensoDN.Location = New System.Drawing.Point(66, 173)
        Me.BtnExtensoDN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExtensoDN.Name = "BtnExtensoDN"
        Me.BtnExtensoDN.Size = New System.Drawing.Size(70, 24)
        Me.BtnExtensoDN.TabIndex = 52
        Me.BtnExtensoDN.Text = "Extenso"
        Me.BtnExtensoDN.UseVisualStyleBackColor = False
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GeneroComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Genero", True))
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(434, 28)
        Me.GeneroComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(121, 23)
        Me.GeneroComboBox.TabIndex = 29
        '
        'CNHExpedicaoTextBox
        '
        Me.CNHExpedicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNHExpedicao", True))
        Me.CNHExpedicaoTextBox.Location = New System.Drawing.Point(471, 325)
        Me.CNHExpedicaoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CNHExpedicaoTextBox.Name = "CNHExpedicaoTextBox"
        Me.CNHExpedicaoTextBox.Size = New System.Drawing.Size(83, 21)
        Me.CNHExpedicaoTextBox.TabIndex = 24
        '
        'CNHTextBox
        '
        Me.CNHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNH", True))
        Me.CNHTextBox.Location = New System.Drawing.Point(141, 325)
        Me.CNHTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CNHTextBox.Name = "CNHTextBox"
        Me.CNHTextBox.Size = New System.Drawing.Size(137, 21)
        Me.CNHTextBox.TabIndex = 22
        '
        'SenhaGOVTextBox
        '
        Me.SenhaGOVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "SenhaGOV", True))
        Me.SenhaGOVTextBox.Location = New System.Drawing.Point(141, 231)
        Me.SenhaGOVTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SenhaGOVTextBox.Name = "SenhaGOVTextBox"
        Me.SenhaGOVTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaGOVTextBox.Size = New System.Drawing.Size(137, 21)
        Me.SenhaGOVTextBox.TabIndex = 20
        '
        'TituloDeEleitorTextBox
        '
        Me.TituloDeEleitorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "TituloDeEleitor", True))
        Me.TituloDeEleitorTextBox.Location = New System.Drawing.Point(141, 295)
        Me.TituloDeEleitorTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TituloDeEleitorTextBox.Name = "TituloDeEleitorTextBox"
        Me.TituloDeEleitorTextBox.Size = New System.Drawing.Size(137, 21)
        Me.TituloDeEleitorTextBox.TabIndex = 18
        '
        'EstadoRGTextBox
        '
        Me.EstadoRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "EstadoRG", True))
        Me.EstadoRGTextBox.Location = New System.Drawing.Point(510, 265)
        Me.EstadoRGTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EstadoRGTextBox.Name = "EstadoRGTextBox"
        Me.EstadoRGTextBox.Size = New System.Drawing.Size(45, 21)
        Me.EstadoRGTextBox.TabIndex = 16
        '
        'OrgaoRGTextBox
        '
        Me.OrgaoRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "OrgaoRG", True))
        Me.OrgaoRGTextBox.Location = New System.Drawing.Point(360, 265)
        Me.OrgaoRGTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OrgaoRGTextBox.Name = "OrgaoRGTextBox"
        Me.OrgaoRGTextBox.Size = New System.Drawing.Size(62, 21)
        Me.OrgaoRGTextBox.TabIndex = 14
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(141, 265)
        Me.RGTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(137, 21)
        Me.RGTextBox.TabIndex = 12
        '
        'DatadeNascMaskedTextBox
        '
        Me.DatadeNascMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "DatadeNasc", True))
        Me.DatadeNascMaskedTextBox.Location = New System.Drawing.Point(141, 148)
        Me.DatadeNascMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DatadeNascMaskedTextBox.Mask = "00/00/0000"
        Me.DatadeNascMaskedTextBox.Name = "DatadeNascMaskedTextBox"
        Me.DatadeNascMaskedTextBox.Size = New System.Drawing.Size(83, 21)
        Me.DatadeNascMaskedTextBox.TabIndex = 10
        Me.DatadeNascMaskedTextBox.ValidatingType = GetType(Date)
        '
        'NomePaiTextBox
        '
        Me.NomePaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomePai", True))
        Me.NomePaiTextBox.Location = New System.Drawing.Point(141, 118)
        Me.NomePaiTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NomePaiTextBox.Name = "NomePaiTextBox"
        Me.NomePaiTextBox.Size = New System.Drawing.Size(414, 21)
        Me.NomePaiTextBox.TabIndex = 8
        '
        'NomeMaeTextBox
        '
        Me.NomeMaeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeMae", True))
        Me.NomeMaeTextBox.Location = New System.Drawing.Point(141, 88)
        Me.NomeMaeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NomeMaeTextBox.Name = "NomeMaeTextBox"
        Me.NomeMaeTextBox.Size = New System.Drawing.Size(414, 21)
        Me.NomeMaeTextBox.TabIndex = 6
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(141, 28)
        Me.CPFMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CPFMaskedTextBox.Mask = "999,999,999-99"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(116, 21)
        Me.CPFMaskedTextBox.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBoxOutrosDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Size = New System.Drawing.Size(689, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Endereço"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBoxOutrosDados
        '
        Me.GroupBoxOutrosDados.Controls.Add(Me.BtnCorrigeCidade)
        Me.GroupBoxOutrosDados.Controls.Add(Me.BtnArrumaEnd)
        Me.GroupBoxOutrosDados.Controls.Add(Me.BtnCopiaCEP)
        Me.GroupBoxOutrosDados.Controls.Add(Me.BtnAtalhoConjuge2)
        Me.GroupBoxOutrosDados.Controls.Add(Me.BtnAtablhoSocio)
        Me.GroupBoxOutrosDados.Controls.Add(Me.BtnCorreios)
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
        Me.GroupBoxOutrosDados.Location = New System.Drawing.Point(4, 3)
        Me.GroupBoxOutrosDados.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxOutrosDados.Name = "GroupBoxOutrosDados"
        Me.GroupBoxOutrosDados.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxOutrosDados.Size = New System.Drawing.Size(681, 409)
        Me.GroupBoxOutrosDados.TabIndex = 52
        Me.GroupBoxOutrosDados.TabStop = False
        Me.GroupBoxOutrosDados.Text = "Outros Dados"
        '
        'BtnCorrigeCidade
        '
        Me.BtnCorrigeCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorrigeCidade.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnCorrigeCidade.Location = New System.Drawing.Point(439, 92)
        Me.BtnCorrigeCidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCorrigeCidade.Name = "BtnCorrigeCidade"
        Me.BtnCorrigeCidade.Size = New System.Drawing.Size(119, 29)
        Me.BtnCorrigeCidade.TabIndex = 78
        Me.BtnCorrigeCidade.Text = "Arrumar Cidade"
        Me.BtnCorrigeCidade.UseVisualStyleBackColor = True
        '
        'BtnArrumaEnd
        '
        Me.BtnArrumaEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArrumaEnd.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnArrumaEnd.Location = New System.Drawing.Point(439, 57)
        Me.BtnArrumaEnd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnArrumaEnd.Name = "BtnArrumaEnd"
        Me.BtnArrumaEnd.Size = New System.Drawing.Size(119, 29)
        Me.BtnArrumaEnd.TabIndex = 77
        Me.BtnArrumaEnd.Text = "Arrumar Endereço"
        Me.BtnArrumaEnd.UseVisualStyleBackColor = True
        '
        'BtnCopiaCEP
        '
        Me.BtnCopiaCEP.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiaCEP.Location = New System.Drawing.Point(326, 30)
        Me.BtnCopiaCEP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiaCEP.Name = "BtnCopiaCEP"
        Me.BtnCopiaCEP.Size = New System.Drawing.Size(85, 25)
        Me.BtnCopiaCEP.TabIndex = 66
        Me.BtnCopiaCEP.Text = "Copiar CEP"
        Me.BtnCopiaCEP.UseVisualStyleBackColor = False
        '
        'BtnAtalhoConjuge2
        '
        Me.BtnAtalhoConjuge2.BackColor = System.Drawing.Color.Azure
        Me.BtnAtalhoConjuge2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAtalhoConjuge2.FlatAppearance.BorderSize = 2
        Me.BtnAtalhoConjuge2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtalhoConjuge2.Location = New System.Drawing.Point(566, 300)
        Me.BtnAtalhoConjuge2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtalhoConjuge2.Name = "BtnAtalhoConjuge2"
        Me.BtnAtalhoConjuge2.Size = New System.Drawing.Size(88, 27)
        Me.BtnAtalhoConjuge2.TabIndex = 65
        Me.BtnAtalhoConjuge2.Text = "Cônjuge"
        Me.BtnAtalhoConjuge2.UseVisualStyleBackColor = False
        '
        'BtnAtablhoSocio
        '
        Me.BtnAtablhoSocio.BackColor = System.Drawing.Color.Azure
        Me.BtnAtablhoSocio.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAtablhoSocio.FlatAppearance.BorderSize = 2
        Me.BtnAtablhoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtablhoSocio.Location = New System.Drawing.Point(566, 267)
        Me.BtnAtablhoSocio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtablhoSocio.Name = "BtnAtablhoSocio"
        Me.BtnAtablhoSocio.Size = New System.Drawing.Size(88, 27)
        Me.BtnAtablhoSocio.TabIndex = 56
        Me.BtnAtablhoSocio.Text = "Dados"
        Me.BtnAtablhoSocio.UseVisualStyleBackColor = False
        '
        'BtnCorreios
        '
        Me.BtnCorreios.BackColor = System.Drawing.Color.Azure
        Me.BtnCorreios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorreios.Location = New System.Drawing.Point(186, 30)
        Me.BtnCorreios.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCorreios.Name = "BtnCorreios"
        Me.BtnCorreios.Size = New System.Drawing.Size(85, 25)
        Me.BtnCorreios.TabIndex = 51
        Me.BtnCorreios.Text = "Preencher"
        Me.BtnCorreios.UseVisualStyleBackColor = False
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "eMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(94, 271)
        Me.EMailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(316, 21)
        Me.EMailTextBox.TabIndex = 50
        '
        'Telefone2MaskedTextBox
        '
        Me.Telefone2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Telefone2", True))
        Me.Telefone2MaskedTextBox.Location = New System.Drawing.Point(94, 241)
        Me.Telefone2MaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Telefone2MaskedTextBox.Name = "Telefone2MaskedTextBox"
        Me.Telefone2MaskedTextBox.Size = New System.Drawing.Size(116, 21)
        Me.Telefone2MaskedTextBox.TabIndex = 48
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Telefone1", True))
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(94, 211)
        Me.Telefone1MaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(116, 21)
        Me.Telefone1MaskedTextBox.TabIndex = 46
        '
        'PaísTextBox
        '
        Me.PaísTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "País", True))
        Me.PaísTextBox.Location = New System.Drawing.Point(94, 181)
        Me.PaísTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PaísTextBox.Name = "PaísTextBox"
        Me.PaísTextBox.Size = New System.Drawing.Size(144, 21)
        Me.PaísTextBox.TabIndex = 44
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(362, 151)
        Me.EstadoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(48, 21)
        Me.EstadoTextBox.TabIndex = 42
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(94, 151)
        Me.CidadeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(202, 21)
        Me.CidadeTextBox.TabIndex = 40
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(271, 91)
        Me.ComplementoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(139, 21)
        Me.ComplementoTextBox.TabIndex = 38
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(94, 121)
        Me.BairroTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(316, 21)
        Me.BairroTextBox.TabIndex = 36
        '
        'NumTextBox
        '
        Me.NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Num", True))
        Me.NumTextBox.Location = New System.Drawing.Point(94, 91)
        Me.NumTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumTextBox.Name = "NumTextBox"
        Me.NumTextBox.Size = New System.Drawing.Size(75, 21)
        Me.NumTextBox.TabIndex = 34
        '
        'RUATextBox
        '
        Me.RUATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RUA", True))
        Me.RUATextBox.Location = New System.Drawing.Point(94, 61)
        Me.RUATextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RUATextBox.Name = "RUATextBox"
        Me.RUATextBox.Size = New System.Drawing.Size(316, 21)
        Me.RUATextBox.TabIndex = 32
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(94, 31)
        Me.CEPMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CEPMaskedTextBox.Mask = "99999-999"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(83, 21)
        Me.CEPMaskedTextBox.TabIndex = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBoxConjuge)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(689, 415)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Cônjuge"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBoxConjuge
        '
        Me.GroupBoxConjuge.Controls.Add(Me.BtnAtalhoEndereco3)
        Me.GroupBoxConjuge.Controls.Add(NOMEdoCONJUGELabel)
        Me.GroupBoxConjuge.Controls.Add(Me.BtnAtablhoSocio3)
        Me.GroupBoxConjuge.Controls.Add(Me.NOMEdoCONJUGETextBox)
        Me.GroupBoxConjuge.Controls.Add(CPFdoCONJUGELabel)
        Me.GroupBoxConjuge.Controls.Add(Me.CPFdoCONJUGEMaskedTextBox)
        Me.GroupBoxConjuge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxConjuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxConjuge.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxConjuge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxConjuge.Name = "GroupBoxConjuge"
        Me.GroupBoxConjuge.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxConjuge.Size = New System.Drawing.Size(689, 415)
        Me.GroupBoxConjuge.TabIndex = 4
        Me.GroupBoxConjuge.TabStop = False
        Me.GroupBoxConjuge.Text = "Dado do Cônjuge"
        '
        'BtnAtalhoEndereco3
        '
        Me.BtnAtalhoEndereco3.BackColor = System.Drawing.Color.Azure
        Me.BtnAtalhoEndereco3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAtalhoEndereco3.FlatAppearance.BorderSize = 2
        Me.BtnAtalhoEndereco3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtalhoEndereco3.Location = New System.Drawing.Point(569, 303)
        Me.BtnAtalhoEndereco3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtalhoEndereco3.Name = "BtnAtalhoEndereco3"
        Me.BtnAtalhoEndereco3.Size = New System.Drawing.Size(88, 27)
        Me.BtnAtalhoEndereco3.TabIndex = 67
        Me.BtnAtalhoEndereco3.Text = "Endereço"
        Me.BtnAtalhoEndereco3.UseVisualStyleBackColor = False
        '
        'BtnAtablhoSocio3
        '
        Me.BtnAtablhoSocio3.BackColor = System.Drawing.Color.Azure
        Me.BtnAtablhoSocio3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAtablhoSocio3.FlatAppearance.BorderSize = 2
        Me.BtnAtablhoSocio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtablhoSocio3.Location = New System.Drawing.Point(569, 270)
        Me.BtnAtablhoSocio3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtablhoSocio3.Name = "BtnAtablhoSocio3"
        Me.BtnAtablhoSocio3.Size = New System.Drawing.Size(88, 27)
        Me.BtnAtablhoSocio3.TabIndex = 66
        Me.BtnAtablhoSocio3.Text = "Dados"
        Me.BtnAtablhoSocio3.UseVisualStyleBackColor = False
        '
        'NOMEdoCONJUGETextBox
        '
        Me.NOMEdoCONJUGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NOMEdoCONJUGE", True))
        Me.NOMEdoCONJUGETextBox.Location = New System.Drawing.Point(178, 60)
        Me.NOMEdoCONJUGETextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NOMEdoCONJUGETextBox.Name = "NOMEdoCONJUGETextBox"
        Me.NOMEdoCONJUGETextBox.Size = New System.Drawing.Size(355, 21)
        Me.NOMEdoCONJUGETextBox.TabIndex = 3
        '
        'CPFdoCONJUGEMaskedTextBox
        '
        Me.CPFdoCONJUGEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CPFdoCONJUGE", True))
        Me.CPFdoCONJUGEMaskedTextBox.Location = New System.Drawing.Point(178, 29)
        Me.CPFdoCONJUGEMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CPFdoCONJUGEMaskedTextBox.Mask = "999,999,999-99"
        Me.CPFdoCONJUGEMaskedTextBox.Name = "CPFdoCONJUGEMaskedTextBox"
        Me.CPFdoCONJUGEMaskedTextBox.Size = New System.Drawing.Size(116, 21)
        Me.CPFdoCONJUGEMaskedTextBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Size = New System.Drawing.Size(689, 415)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Outros Dados"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(OutrosDadosLabel)
        Me.GroupBox4.Controls.Add(Me.OutrosDadosRichTextBox)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(681, 409)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'OutrosDadosRichTextBox
        '
        Me.OutrosDadosRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "OutrosDados", True))
        Me.OutrosDadosRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutrosDadosRichTextBox.Location = New System.Drawing.Point(9, 37)
        Me.OutrosDadosRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OutrosDadosRichTextBox.Name = "OutrosDadosRichTextBox"
        Me.OutrosDadosRichTextBox.Size = New System.Drawing.Size(546, 269)
        Me.OutrosDadosRichTextBox.TabIndex = 1
        Me.OutrosDadosRichTextBox.Text = ""
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.LblContaEmpresa)
        Me.TabPage5.Controls.Add(Me.DataGridViewEmpresa)
        Me.TabPage5.Controls.Add(Me.BtnBuscarEmpresa)
        Me.TabPage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(689, 415)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Empresas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'LblContaEmpresa
        '
        Me.LblContaEmpresa.AutoSize = True
        Me.LblContaEmpresa.Location = New System.Drawing.Point(12, 324)
        Me.LblContaEmpresa.Name = "LblContaEmpresa"
        Me.LblContaEmpresa.Size = New System.Drawing.Size(13, 18)
        Me.LblContaEmpresa.TabIndex = 2
        Me.LblContaEmpresa.Text = "-"
        '
        'DataGridViewEmpresa
        '
        Me.DataGridViewEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridViewEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridViewEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmpresa.Location = New System.Drawing.Point(15, 74)
        Me.DataGridViewEmpresa.Name = "DataGridViewEmpresa"
        Me.DataGridViewEmpresa.ReadOnly = True
        Me.DataGridViewEmpresa.Size = New System.Drawing.Size(642, 247)
        Me.DataGridViewEmpresa.TabIndex = 1
        '
        'BtnBuscarEmpresa
        '
        Me.BtnBuscarEmpresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarEmpresa.Location = New System.Drawing.Point(15, 25)
        Me.BtnBuscarEmpresa.Name = "BtnBuscarEmpresa"
        Me.BtnBuscarEmpresa.Size = New System.Drawing.Size(264, 31)
        Me.BtnBuscarEmpresa.TabIndex = 0
        Me.BtnBuscarEmpresa.Text = "Buscar Empresa no qual faz parte"
        Me.BtnBuscarEmpresa.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnParcelamentos)
        Me.GroupBox2.Controls.Add(Me.BtnExportaSocioLaudo)
        Me.GroupBox2.Controls.Add(Me.BtnCapitalSocial)
        Me.GroupBox2.Controls.Add(Me.BtnAddSocios)
        Me.GroupBox2.Controls.Add(Me.BtnExportar)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 561)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(697, 78)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EXPORTAÇÕES DE DADOS"
        '
        'BtnParcelamentos
        '
        Me.BtnParcelamentos.BackColor = System.Drawing.Color.Azure
        Me.BtnParcelamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnParcelamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnParcelamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnParcelamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnParcelamentos.Location = New System.Drawing.Point(413, 16)
        Me.BtnParcelamentos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnParcelamentos.Name = "BtnParcelamentos"
        Me.BtnParcelamentos.Size = New System.Drawing.Size(119, 54)
        Me.BtnParcelamentos.TabIndex = 56
        Me.BtnParcelamentos.Text = "Parcelamentos"
        Me.BtnParcelamentos.UseVisualStyleBackColor = False
        '
        'BtnExportaSocioLaudo
        '
        Me.BtnExportaSocioLaudo.BackColor = System.Drawing.Color.Azure
        Me.BtnExportaSocioLaudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExportaSocioLaudo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportaSocioLaudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExportaSocioLaudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportaSocioLaudo.Location = New System.Drawing.Point(286, 16)
        Me.BtnExportaSocioLaudo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExportaSocioLaudo.Name = "BtnExportaSocioLaudo"
        Me.BtnExportaSocioLaudo.Size = New System.Drawing.Size(119, 54)
        Me.BtnExportaSocioLaudo.TabIndex = 55
        Me.BtnExportaSocioLaudo.Text = "Alvará: Requerente"
        Me.BtnExportaSocioLaudo.UseVisualStyleBackColor = False
        '
        'BtnCapitalSocial
        '
        Me.BtnCapitalSocial.BackColor = System.Drawing.Color.Azure
        Me.BtnCapitalSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCapitalSocial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCapitalSocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCapitalSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCapitalSocial.Location = New System.Drawing.Point(540, 16)
        Me.BtnCapitalSocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCapitalSocial.Name = "BtnCapitalSocial"
        Me.BtnCapitalSocial.Size = New System.Drawing.Size(142, 54)
        Me.BtnCapitalSocial.TabIndex = 54
        Me.BtnCapitalSocial.Text = "Abrir Calculadora Capítal Social"
        Me.BtnCapitalSocial.UseVisualStyleBackColor = False
        '
        'BtnAddSocios
        '
        Me.BtnAddSocios.BackColor = System.Drawing.Color.Azure
        Me.BtnAddSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddSocios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddSocios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddSocios.Location = New System.Drawing.Point(159, 16)
        Me.BtnAddSocios.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAddSocios.Name = "BtnAddSocios"
        Me.BtnAddSocios.Size = New System.Drawing.Size(119, 54)
        Me.BtnAddSocios.TabIndex = 53
        Me.BtnAddSocios.Text = "Empresa: Sócios"
        Me.BtnAddSocios.UseVisualStyleBackColor = False
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.Azure
        Me.BtnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportar.Location = New System.Drawing.Point(9, 16)
        Me.BtnExportar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(142, 54)
        Me.BtnExportar.TabIndex = 52
        Me.BtnExportar.Text = "Empresa: Responsavel da Federal"
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.BtnFechar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenuCapitalSocial, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxCapitalSocial, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(831, 842)
        Me.TableLayoutPanel1.TabIndex = 51
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.FlatAppearance.BorderSize = 0
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Location = New System.Drawing.Point(709, 3)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(122, 60)
        Me.BtnFechar.TabIndex = 57
        Me.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnFecharMenu)
        Me.GroupBox1.Controls.Add(Me.BtnNovo)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.BtnEditar)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnWord)
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(709, 109)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(122, 446)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Nº:"
        '
        'BtnFecharMenu
        '
        Me.BtnFecharMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFecharMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFecharMenu.Location = New System.Drawing.Point(8, 149)
        Me.BtnFecharMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFecharMenu.Name = "BtnFecharMenu"
        Me.BtnFecharMenu.Size = New System.Drawing.Size(88, 27)
        Me.BtnFecharMenu.TabIndex = 10
        Me.BtnFecharMenu.Text = "Fechar"
        Me.BtnFecharMenu.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNovo.FlatAppearance.BorderSize = 2
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Black
        Me.BtnNovo.Location = New System.Drawing.Point(8, 22)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(88, 27)
        Me.BtnNovo.TabIndex = 5
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "+ Digitar"})
        Me.ComboBox1.Location = New System.Drawing.Point(38, 287)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(55, 23)
        Me.ComboBox1.TabIndex = 54
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(8, 52)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(88, 27)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(8, 82)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(88, 27)
        Me.BtnSalvar.TabIndex = 7
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnWord
        '
        Me.BtnWord.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnWord.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnWord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWord.Location = New System.Drawing.Point(8, 318)
        Me.BtnWord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnWord.Name = "BtnWord"
        Me.BtnWord.Size = New System.Drawing.Size(86, 48)
        Me.BtnWord.TabIndex = 53
        Me.BtnWord.Text = "Exportar para Word"
        Me.BtnWord.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnExcluir.FlatAppearance.BorderSize = 2
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Black
        Me.BtnExcluir.Location = New System.Drawing.Point(8, 115)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(88, 27)
        Me.BtnExcluir.TabIndex = 9
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'GroupBoxMenuCapitalSocial
        '
        Me.GroupBoxMenuCapitalSocial.AutoSize = True
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.BtnCapitalEmpresas)
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.BtnADDSocioCapital)
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.ButtonLimpar)
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.ButtonPorcentagem)
        Me.GroupBoxMenuCapitalSocial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMenuCapitalSocial.Location = New System.Drawing.Point(709, 645)
        Me.GroupBoxMenuCapitalSocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxMenuCapitalSocial.Name = "GroupBoxMenuCapitalSocial"
        Me.GroupBoxMenuCapitalSocial.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxMenuCapitalSocial.Size = New System.Drawing.Size(122, 244)
        Me.GroupBoxMenuCapitalSocial.TabIndex = 63
        Me.GroupBoxMenuCapitalSocial.TabStop = False
        Me.GroupBoxMenuCapitalSocial.Text = "Sub-Menu"
        '
        'BtnCapitalEmpresas
        '
        Me.BtnCapitalEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCapitalEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCapitalEmpresas.Location = New System.Drawing.Point(8, 155)
        Me.BtnCapitalEmpresas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCapitalEmpresas.Name = "BtnCapitalEmpresas"
        Me.BtnCapitalEmpresas.Size = New System.Drawing.Size(103, 69)
        Me.BtnCapitalEmpresas.TabIndex = 40
        Me.BtnCapitalEmpresas.Text = "Exportar para Empresas"
        Me.BtnCapitalEmpresas.UseVisualStyleBackColor = True
        '
        'BtnADDSocioCapital
        '
        Me.BtnADDSocioCapital.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnADDSocioCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnADDSocioCapital.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnADDSocioCapital.Location = New System.Drawing.Point(7, 19)
        Me.BtnADDSocioCapital.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnADDSocioCapital.Name = "BtnADDSocioCapital"
        Me.BtnADDSocioCapital.Size = New System.Drawing.Size(102, 51)
        Me.BtnADDSocioCapital.TabIndex = 8
        Me.BtnADDSocioCapital.Text = "Adicionar Sócio"
        Me.BtnADDSocioCapital.UseVisualStyleBackColor = True
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.Red
        Me.ButtonLimpar.Location = New System.Drawing.Point(8, 115)
        Me.ButtonLimpar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(103, 33)
        Me.ButtonLimpar.TabIndex = 39
        Me.ButtonLimpar.Text = "Limpar Tudo"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'ButtonPorcentagem
        '
        Me.ButtonPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPorcentagem.Location = New System.Drawing.Point(7, 74)
        Me.ButtonPorcentagem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonPorcentagem.Name = "ButtonPorcentagem"
        Me.ButtonPorcentagem.Size = New System.Drawing.Size(103, 33)
        Me.ButtonPorcentagem.TabIndex = 36
        Me.ButtonPorcentagem.Text = "Calcular"
        Me.ButtonPorcentagem.UseVisualStyleBackColor = True
        '
        'GroupBoxCapitalSocial
        '
        Me.GroupBoxCapitalSocial.Controls.Add(Me.Label5)
        Me.GroupBoxCapitalSocial.Controls.Add(Me.DataGridView1)
        Me.GroupBoxCapitalSocial.Controls.Add(Me.LblCapTotal)
        Me.GroupBoxCapitalSocial.Controls.Add(Me.TextBoxCapitalSocial)
        Me.GroupBoxCapitalSocial.Location = New System.Drawing.Point(4, 645)
        Me.GroupBoxCapitalSocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxCapitalSocial.Name = "GroupBoxCapitalSocial"
        Me.GroupBoxCapitalSocial.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxCapitalSocial.Size = New System.Drawing.Size(689, 213)
        Me.GroupBoxCapitalSocial.TabIndex = 64
        Me.GroupBoxCapitalSocial.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 24)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Calculadora de Capital Social"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSocio, Me.ColumnPorcentagem, Me.ColumnAntigo, Me.ColumnNovo, Me.GanhaEPerca})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 69)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 138)
        Me.DataGridView1.TabIndex = 38
        '
        'ColumnSocio
        '
        Me.ColumnSocio.HeaderText = "Socio"
        Me.ColumnSocio.Name = "ColumnSocio"
        '
        'ColumnPorcentagem
        '
        Me.ColumnPorcentagem.HeaderText = "%"
        Me.ColumnPorcentagem.Name = "ColumnPorcentagem"
        Me.ColumnPorcentagem.Width = 60
        '
        'ColumnAntigo
        '
        Me.ColumnAntigo.HeaderText = "Capital Antigo"
        Me.ColumnAntigo.Name = "ColumnAntigo"
        '
        'ColumnNovo
        '
        Me.ColumnNovo.HeaderText = "Capital Novo"
        Me.ColumnNovo.Name = "ColumnNovo"
        '
        'GanhaEPerca
        '
        Me.GanhaEPerca.HeaderText = "Ganhou/Perdeu"
        Me.GanhaEPerca.Name = "GanhaEPerca"
        '
        'LblCapTotal
        '
        Me.LblCapTotal.AutoSize = True
        Me.LblCapTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblCapTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapTotal.Location = New System.Drawing.Point(16, 46)
        Me.LblCapTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCapTotal.Name = "LblCapTotal"
        Me.LblCapTotal.Size = New System.Drawing.Size(127, 16)
        Me.LblCapTotal.TabIndex = 37
        Me.LblCapTotal.Text = "Capital Social Total:"
        '
        'TextBoxCapitalSocial
        '
        Me.TextBoxCapitalSocial.Location = New System.Drawing.Point(172, 42)
        Me.TextBoxCapitalSocial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxCapitalSocial.Name = "TextBoxCapitalSocial"
        Me.TextBoxCapitalSocial.Size = New System.Drawing.Size(163, 21)
        Me.TextBoxCapitalSocial.TabIndex = 35
        Me.TextBoxCapitalSocial.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SociosBindingNavigator)
        Me.GroupBox3.Controls.Add(Me.CPFComboBox)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.NomeCompletoComboBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(697, 100)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'SociosBindingNavigator
        '
        Me.SociosBindingNavigator.AddNewItem = Nothing
        Me.SociosBindingNavigator.BindingSource = Me.SociosBindingSource
        Me.SociosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SociosBindingNavigator.DeleteItem = Nothing
        Me.SociosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SociosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.SociosBindingNavigator.Location = New System.Drawing.Point(0, 5)
        Me.SociosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SociosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SociosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SociosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SociosBindingNavigator.Name = "SociosBindingNavigator"
        Me.SociosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SociosBindingNavigator.Size = New System.Drawing.Size(207, 25)
        Me.SociosBindingNavigator.TabIndex = 56
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(46, 23)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(-1, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "CADASTRO DOS SOCIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 842)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmSocios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sócios"
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBoxDadosPessoais.ResumeLayout(False)
        Me.GroupBoxDadosPessoais.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBoxOutrosDados.ResumeLayout(False)
        Me.GroupBoxOutrosDados.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBoxConjuge.ResumeLayout(False)
        Me.GroupBoxConjuge.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridViewEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxMenuCapitalSocial.ResumeLayout(False)
        Me.GroupBoxCapitalSocial.ResumeLayout(False)
        Me.GroupBoxCapitalSocial.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SociosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SociosBindingNavigator.ResumeLayout(False)
        Me.SociosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents SociosBindingSource As BindingSource
    Friend WithEvents SociosTableAdapter As PrinceDBDataSetTableAdapters.SociosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NomeCompletoComboBox As ComboBox
    Friend WithEvents CPFComboBox As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBoxDadosPessoais As GroupBox
    Friend WithEvents TextBoxExtensoDN As TextBox
    Friend WithEvents BtnExtensoDN As Button
    Friend WithEvents GeneroComboBox As ComboBox
    Friend WithEvents CNHExpedicaoTextBox As TextBox
    Friend WithEvents CNHTextBox As TextBox
    Friend WithEvents SenhaGOVTextBox As TextBox
    Friend WithEvents TituloDeEleitorTextBox As TextBox
    Friend WithEvents EstadoRGTextBox As TextBox
    Friend WithEvents OrgaoRGTextBox As TextBox
    Friend WithEvents RGTextBox As TextBox
    Friend WithEvents DatadeNascMaskedTextBox As MaskedTextBox
    Friend WithEvents NomePaiTextBox As TextBox
    Friend WithEvents NomeMaeTextBox As TextBox
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBoxOutrosDados As GroupBox
    Friend WithEvents BtnCorreios As Button
    Friend WithEvents EMailTextBox As TextBox
    Friend WithEvents Telefone2MaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone1MaskedTextBox As MaskedTextBox
    Friend WithEvents PaísTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents RUATextBox As TextBox
    Friend WithEvents CEPMaskedTextBox As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCapitalSocial As Button
    Friend WithEvents BtnAddSocios As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxCapitalSocial As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnSocio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPorcentagem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAntigo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNovo As DataGridViewTextBoxColumn
    Friend WithEvents GanhaEPerca As DataGridViewTextBoxColumn
    Friend WithEvents LblCapTotal As Label
    Friend WithEvents TextBoxCapitalSocial As TextBox
    Friend WithEvents BtnAtalhoEndereco As Button
    Friend WithEvents BtnAtablhoSocio As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConsultaCPF As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents NOMEdoCONJUGETextBox As TextBox
    Friend WithEvents CPFdoCONJUGEMaskedTextBox As MaskedTextBox
    Friend WithEvents ProfissãoTextBox As TextBox
    Friend WithEvents GroupBoxConjuge As GroupBox
    Friend WithEvents ListBoxEstadoCivil As ListBox
    Friend WithEvents CNHDataExpMaskedTextBox As MaskedTextBox
    Friend WithEvents BtnConsultarTituloDeEleitor As Button
    Friend WithEvents CivilTextBox As TextBox
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents BtnAtalhoConjuge As Button
    Friend WithEvents BtnAtalhoConjuge2 As Button
    Friend WithEvents BtnAtalhoEndereco3 As Button
    Friend WithEvents BtnAtablhoSocio3 As Button
    Friend WithEvents BtnDuplicidade As Button
    Friend WithEvents BtnCopiarSenhaGov As Button
    Friend WithEvents BtnExportaSocioLaudo As Button
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
    Friend WithEvents BtnFechar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnFecharMenu As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnWord As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GroupBoxMenuCapitalSocial As GroupBox
    Friend WithEvents BtnCapitalEmpresas As Button
    Friend WithEvents BtnADDSocioCapital As Button
    Friend WithEvents ButtonLimpar As Button
    Friend WithEvents ButtonPorcentagem As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OutrosDadosRichTextBox As RichTextBox
    Friend WithEvents BtnCopiaCEP As Button
    Friend WithEvents BtnCopiarCPF As Button
    Friend WithEvents BtnParcelamentos As Button
    Friend WithEvents MenorIdadeComboBox As ComboBox
    Friend WithEvents LblMenorIdade As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridViewEmpresa As DataGridView
    Friend WithEvents BtnBuscarEmpresa As Button
    Friend WithEvents LblContaEmpresa As Label
    Friend WithEvents BtnArrumaEnd As Button
    Friend WithEvents BtnCorrigeCidade As Button
    Friend WithEvents LinkLabelArrumaOrgaoRG As LinkLabel
    Friend WithEvents RegistroNumeroTextBox As TextBox
    Friend WithEvents RegistroEstadoComboBox As ComboBox
    Friend WithEvents RegistroOrgaoComboBox As ComboBox
    Friend WithEvents BtnConsultaRegistroEntidades As Button
    Friend WithEvents RegistroDataMaskedTextBox As MaskedTextBox
End Class
