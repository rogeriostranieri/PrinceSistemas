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
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CPFComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeCompletoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SociosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.SociosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFecharMenu = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDadosPessoais = New System.Windows.Forms.GroupBox()
        Me.BtnAtalhoConjuge = New System.Windows.Forms.Button()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.CivilTextBox = New System.Windows.Forms.TextBox()
        Me.BtnConsultarTituloDeEleitor = New System.Windows.Forms.Button()
        Me.CNHDataExpMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ListBoxEstadoCivil = New System.Windows.Forms.ListBox()
        Me.ProfissãoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnConsultaCPF = New System.Windows.Forms.Button()
        Me.BtnAtalhoEndereco = New System.Windows.Forms.Button()
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
        Me.BtnAtalhoEndereco3 = New System.Windows.Forms.Button()
        Me.BtnAtablhoSocio3 = New System.Windows.Forms.Button()
        Me.GroupBoxConjuge = New System.Windows.Forms.GroupBox()
        Me.NOMEdoCONJUGETextBox = New System.Windows.Forms.TextBox()
        Me.CPFdoCONJUGEMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCapitalSocial = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnAddSocios = New System.Windows.Forms.Button()
        Me.BtnWord = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxDadosPessoais.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBoxOutrosDados.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBoxConjuge.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxMenuCapitalSocial.SuspendLayout()
        Me.GroupBoxCapitalSocial.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        RUALabel.Size = New System.Drawing.Size(30, 13)
        RUALabel.TabIndex = 31
        RUALabel.Text = "Rua:"
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
        EstadoLabel.Location = New System.Drawing.Point(261, 134)
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
        EMailLabel.Text = "e-Mail:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(78, 27)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.Location = New System.Drawing.Point(23, 53)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(85, 13)
        NomeCompletoLabel.TabIndex = 3
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'NomeMaeLabel
        '
        NomeMaeLabel.AutoSize = True
        NomeMaeLabel.Location = New System.Drawing.Point(31, 79)
        NomeMaeLabel.Name = "NomeMaeLabel"
        NomeMaeLabel.Size = New System.Drawing.Size(77, 13)
        NomeMaeLabel.TabIndex = 5
        NomeMaeLabel.Text = "Nome da Mae:"
        '
        'NomePaiLabel
        '
        NomePaiLabel.AutoSize = True
        NomePaiLabel.Location = New System.Drawing.Point(37, 105)
        NomePaiLabel.Name = "NomePaiLabel"
        NomePaiLabel.Size = New System.Drawing.Size(71, 13)
        NomePaiLabel.TabIndex = 7
        NomePaiLabel.Text = "Nome do Pai:"
        '
        'DatadeNascLabel
        '
        DatadeNascLabel.AutoSize = True
        DatadeNascLabel.Location = New System.Drawing.Point(1, 130)
        DatadeNascLabel.Name = "DatadeNascLabel"
        DatadeNascLabel.Size = New System.Drawing.Size(107, 13)
        DatadeNascLabel.TabIndex = 9
        DatadeNascLabel.Text = "Data de Nascimento:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Location = New System.Drawing.Point(82, 214)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(26, 13)
        RGLabel.TabIndex = 11
        RGLabel.Text = "RG:"
        '
        'OrgaoRGLabel
        '
        OrgaoRGLabel.AutoSize = True
        OrgaoRGLabel.Location = New System.Drawing.Point(238, 214)
        OrgaoRGLabel.Name = "OrgaoRGLabel"
        OrgaoRGLabel.Size = New System.Drawing.Size(58, 13)
        OrgaoRGLabel.TabIndex = 13
        OrgaoRGLabel.Text = "Orgao RG:"
        '
        'EstadoRGLabel
        '
        EstadoRGLabel.AutoSize = True
        EstadoRGLabel.Location = New System.Drawing.Point(362, 214)
        EstadoRGLabel.Name = "EstadoRGLabel"
        EstadoRGLabel.Size = New System.Drawing.Size(62, 13)
        EstadoRGLabel.TabIndex = 15
        EstadoRGLabel.Text = "Estado RG:"
        '
        'TituloDeEleitorLabel
        '
        TituloDeEleitorLabel.AutoSize = True
        TituloDeEleitorLabel.Location = New System.Drawing.Point(23, 240)
        TituloDeEleitorLabel.Name = "TituloDeEleitorLabel"
        TituloDeEleitorLabel.Size = New System.Drawing.Size(85, 13)
        TituloDeEleitorLabel.TabIndex = 17
        TituloDeEleitorLabel.Text = "Titulo De Eleitor:"
        '
        'SenhaGOVLabel
        '
        SenhaGOVLabel.AutoSize = True
        SenhaGOVLabel.Location = New System.Drawing.Point(41, 184)
        SenhaGOVLabel.Name = "SenhaGOVLabel"
        SenhaGOVLabel.Size = New System.Drawing.Size(67, 13)
        SenhaGOVLabel.TabIndex = 19
        SenhaGOVLabel.Text = "Senha GOV:"
        '
        'CNHLabel
        '
        CNHLabel.AutoSize = True
        CNHLabel.Location = New System.Drawing.Point(75, 266)
        CNHLabel.Name = "CNHLabel"
        CNHLabel.Size = New System.Drawing.Size(33, 13)
        CNHLabel.TabIndex = 21
        CNHLabel.Text = "CNH:"
        '
        'CNHExpedicaoLabel
        '
        CNHExpedicaoLabel.AutoSize = True
        CNHExpedicaoLabel.Location = New System.Drawing.Point(357, 266)
        CNHExpedicaoLabel.Name = "CNHExpedicaoLabel"
        CNHExpedicaoLabel.Size = New System.Drawing.Size(39, 13)
        CNHExpedicaoLabel.TabIndex = 23
        CNHExpedicaoLabel.Text = "Orgão:"
        '
        'CNHDataExpLabel
        '
        CNHDataExpLabel.AutoSize = True
        CNHDataExpLabel.Location = New System.Drawing.Point(232, 266)
        CNHDataExpLabel.Name = "CNHDataExpLabel"
        CNHDataExpLabel.Size = New System.Drawing.Size(54, 13)
        CNHDataExpLabel.TabIndex = 25
        CNHDataExpLabel.Text = "Data Exp:"
        '
        'CivilLabel
        '
        CivilLabel.AutoSize = True
        CivilLabel.Location = New System.Drawing.Point(43, 157)
        CivilLabel.Name = "CivilLabel"
        CivilLabel.Size = New System.Drawing.Size(65, 13)
        CivilLabel.TabIndex = 27
        CivilLabel.Text = "Estado Civil:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(314, 27)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 28
        GeneroLabel.Text = "Genero:"
        '
        'CPFdoCONJUGELabel
        '
        CPFdoCONJUGELabel.AutoSize = True
        CPFdoCONJUGELabel.Location = New System.Drawing.Point(22, 17)
        CPFdoCONJUGELabel.Name = "CPFdoCONJUGELabel"
        CPFdoCONJUGELabel.Size = New System.Drawing.Size(103, 13)
        CPFdoCONJUGELabel.TabIndex = 0
        CPFdoCONJUGELabel.Text = "CPF DO CÔNJUGE:"
        '
        'NOMEdoCONJUGELabel
        '
        NOMEdoCONJUGELabel.AutoSize = True
        NOMEdoCONJUGELabel.Location = New System.Drawing.Point(10, 43)
        NOMEdoCONJUGELabel.Name = "NOMEdoCONJUGELabel"
        NOMEdoCONJUGELabel.Size = New System.Drawing.Size(115, 13)
        NOMEdoCONJUGELabel.TabIndex = 2
        NOMEdoCONJUGELabel.Text = "NOME DO CÔNJUGE:"
        '
        'ProfissãoLabel
        '
        ProfissãoLabel.AutoSize = True
        ProfissãoLabel.Location = New System.Drawing.Point(266, 184)
        ProfissãoLabel.Name = "ProfissãoLabel"
        ProfissãoLabel.Size = New System.Drawing.Size(53, 13)
        ProfissãoLabel.TabIndex = 56
        ProfissãoLabel.Text = "Profissão:"
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
        Me.CPFComboBox.FormattingEnabled = True
        Me.CPFComboBox.Location = New System.Drawing.Point(281, 67)
        Me.CPFComboBox.Name = "CPFComboBox"
        Me.CPFComboBox.Size = New System.Drawing.Size(116, 21)
        Me.CPFComboBox.TabIndex = 8
        Me.CPFComboBox.ValueMember = "CPF"
        '
        'NomeCompletoComboBox
        '
        Me.NomeCompletoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NomeCompletoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomeCompletoComboBox.DataSource = Me.SociosBindingSource
        Me.NomeCompletoComboBox.DisplayMember = "NomeCompleto"
        Me.NomeCompletoComboBox.FormattingEnabled = True
        Me.NomeCompletoComboBox.Location = New System.Drawing.Point(42, 67)
        Me.NomeCompletoComboBox.Name = "NomeCompletoComboBox"
        Me.NomeCompletoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NomeCompletoComboBox.TabIndex = 7
        Me.NomeCompletoComboBox.ValueMember = "NomeCompleto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CPF's:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomes:"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnFecharMenu)
        Me.GroupBox1.Controls.Add(Me.BtnNovo)
        Me.GroupBox1.Controls.Add(Me.BtnEditar)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(602, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 333)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'BtnFecharMenu
        '
        Me.BtnFecharMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFecharMenu.Location = New System.Drawing.Point(7, 152)
        Me.BtnFecharMenu.Name = "BtnFecharMenu"
        Me.BtnFecharMenu.Size = New System.Drawing.Size(75, 23)
        Me.BtnFecharMenu.TabIndex = 10
        Me.BtnFecharMenu.Text = "Fechar"
        Me.BtnFecharMenu.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNovo.Location = New System.Drawing.Point(7, 19)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNovo.TabIndex = 5
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Location = New System.Drawing.Point(7, 45)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalvar.Location = New System.Drawing.Point(7, 71)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 7
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Location = New System.Drawing.Point(7, 97)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Crimson
        Me.BtnExcluir.Location = New System.Drawing.Point(7, 123)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluir.TabIndex = 9
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 333)
        Me.TabControl1.TabIndex = 61
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBoxDadosPessoais)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sócio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBoxDadosPessoais
        '
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnAtalhoConjuge)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.NomeCompletoTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CivilTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnConsultarTituloDeEleitor)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.CNHDataExpMaskedTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.ListBoxEstadoCivil)
        Me.GroupBoxDadosPessoais.Controls.Add(ProfissãoLabel)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.ProfissãoTextBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnConsultaCPF)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.BtnAtalhoEndereco)
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
        Me.GroupBoxDadosPessoais.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxDadosPessoais.Name = "GroupBoxDadosPessoais"
        Me.GroupBoxDadosPessoais.Size = New System.Drawing.Size(577, 301)
        Me.GroupBoxDadosPessoais.TabIndex = 52
        Me.GroupBoxDadosPessoais.TabStop = False
        Me.GroupBoxDadosPessoais.Text = "Dados Pessoais"
        '
        'BtnAtalhoConjuge
        '
        Me.BtnAtalhoConjuge.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnAtalhoConjuge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtalhoConjuge.Location = New System.Drawing.Point(485, 260)
        Me.BtnAtalhoConjuge.Name = "BtnAtalhoConjuge"
        Me.BtnAtalhoConjuge.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtalhoConjuge.TabIndex = 64
        Me.BtnAtalhoConjuge.Text = "Cônjuge"
        Me.BtnAtalhoConjuge.UseVisualStyleBackColor = False
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeCompleto", True))
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(114, 50)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomeCompletoTextBox.TabIndex = 63
        '
        'CivilTextBox
        '
        Me.CivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Civil", True))
        Me.CivilTextBox.Location = New System.Drawing.Point(114, 155)
        Me.CivilTextBox.Name = "CivilTextBox"
        Me.CivilTextBox.ReadOnly = True
        Me.CivilTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CivilTextBox.TabIndex = 62
        '
        'BtnConsultarTituloDeEleitor
        '
        Me.BtnConsultarTituloDeEleitor.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnConsultarTituloDeEleitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultarTituloDeEleitor.Location = New System.Drawing.Point(235, 237)
        Me.BtnConsultarTituloDeEleitor.Name = "BtnConsultarTituloDeEleitor"
        Me.BtnConsultarTituloDeEleitor.Size = New System.Drawing.Size(61, 20)
        Me.BtnConsultarTituloDeEleitor.TabIndex = 61
        Me.BtnConsultarTituloDeEleitor.Text = "Consultar"
        Me.BtnConsultarTituloDeEleitor.UseVisualStyleBackColor = False
        '
        'CNHDataExpMaskedTextBox
        '
        Me.CNHDataExpMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNHDataExp", True))
        Me.CNHDataExpMaskedTextBox.Location = New System.Drawing.Point(286, 263)
        Me.CNHDataExpMaskedTextBox.Mask = "00/00/0000"
        Me.CNHDataExpMaskedTextBox.Name = "CNHDataExpMaskedTextBox"
        Me.CNHDataExpMaskedTextBox.Size = New System.Drawing.Size(69, 20)
        Me.CNHDataExpMaskedTextBox.TabIndex = 60
        Me.CNHDataExpMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ListBoxEstadoCivil
        '
        Me.ListBoxEstadoCivil.FormattingEnabled = True
        Me.ListBoxEstadoCivil.Location = New System.Drawing.Point(237, 155)
        Me.ListBoxEstadoCivil.Name = "ListBoxEstadoCivil"
        Me.ListBoxEstadoCivil.Size = New System.Drawing.Size(39, 17)
        Me.ListBoxEstadoCivil.TabIndex = 59
        '
        'ProfissãoTextBox
        '
        Me.ProfissãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Profissão", True))
        Me.ProfissãoTextBox.Location = New System.Drawing.Point(320, 181)
        Me.ProfissãoTextBox.Name = "ProfissãoTextBox"
        Me.ProfissãoTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ProfissãoTextBox.TabIndex = 57
        '
        'BtnConsultaCPF
        '
        Me.BtnConsultaCPF.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnConsultaCPF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultaCPF.Location = New System.Drawing.Point(221, 22)
        Me.BtnConsultaCPF.Name = "BtnConsultaCPF"
        Me.BtnConsultaCPF.Size = New System.Drawing.Size(65, 23)
        Me.BtnConsultaCPF.TabIndex = 56
        Me.BtnConsultaCPF.Text = "Consultar"
        Me.BtnConsultaCPF.UseVisualStyleBackColor = False
        '
        'BtnAtalhoEndereco
        '
        Me.BtnAtalhoEndereco.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnAtalhoEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtalhoEndereco.Location = New System.Drawing.Point(485, 231)
        Me.BtnAtalhoEndereco.Name = "BtnAtalhoEndereco"
        Me.BtnAtalhoEndereco.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtalhoEndereco.TabIndex = 54
        Me.BtnAtalhoEndereco.Text = "Endereço"
        Me.BtnAtalhoEndereco.UseVisualStyleBackColor = False
        '
        'TextBoxExtensoDN
        '
        Me.TextBoxExtensoDN.Location = New System.Drawing.Point(256, 128)
        Me.TextBoxExtensoDN.Name = "TextBoxExtensoDN"
        Me.TextBoxExtensoDN.Size = New System.Drawing.Size(213, 20)
        Me.TextBoxExtensoDN.TabIndex = 53
        '
        'BtnExtensoDN
        '
        Me.BtnExtensoDN.BackColor = System.Drawing.Color.White
        Me.BtnExtensoDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExtensoDN.Location = New System.Drawing.Point(192, 127)
        Me.BtnExtensoDN.Name = "BtnExtensoDN"
        Me.BtnExtensoDN.Size = New System.Drawing.Size(60, 21)
        Me.BtnExtensoDN.TabIndex = 52
        Me.BtnExtensoDN.Text = "Extenso"
        Me.BtnExtensoDN.UseVisualStyleBackColor = False
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Genero", True))
        Me.GeneroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(365, 24)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(104, 21)
        Me.GeneroComboBox.TabIndex = 29
        '
        'CNHExpedicaoTextBox
        '
        Me.CNHExpedicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNHExpedicao", True))
        Me.CNHExpedicaoTextBox.Location = New System.Drawing.Point(397, 263)
        Me.CNHExpedicaoTextBox.Name = "CNHExpedicaoTextBox"
        Me.CNHExpedicaoTextBox.Size = New System.Drawing.Size(72, 20)
        Me.CNHExpedicaoTextBox.TabIndex = 24
        '
        'CNHTextBox
        '
        Me.CNHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CNH", True))
        Me.CNHTextBox.Location = New System.Drawing.Point(114, 263)
        Me.CNHTextBox.Name = "CNHTextBox"
        Me.CNHTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CNHTextBox.TabIndex = 22
        '
        'SenhaGOVTextBox
        '
        Me.SenhaGOVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "SenhaGOV", True))
        Me.SenhaGOVTextBox.Location = New System.Drawing.Point(114, 181)
        Me.SenhaGOVTextBox.Name = "SenhaGOVTextBox"
        Me.SenhaGOVTextBox.Size = New System.Drawing.Size(118, 20)
        Me.SenhaGOVTextBox.TabIndex = 20
        '
        'TituloDeEleitorTextBox
        '
        Me.TituloDeEleitorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "TituloDeEleitor", True))
        Me.TituloDeEleitorTextBox.Location = New System.Drawing.Point(114, 237)
        Me.TituloDeEleitorTextBox.Name = "TituloDeEleitorTextBox"
        Me.TituloDeEleitorTextBox.Size = New System.Drawing.Size(118, 20)
        Me.TituloDeEleitorTextBox.TabIndex = 18
        '
        'EstadoRGTextBox
        '
        Me.EstadoRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "EstadoRG", True))
        Me.EstadoRGTextBox.Location = New System.Drawing.Point(430, 211)
        Me.EstadoRGTextBox.Name = "EstadoRGTextBox"
        Me.EstadoRGTextBox.Size = New System.Drawing.Size(39, 20)
        Me.EstadoRGTextBox.TabIndex = 16
        '
        'OrgaoRGTextBox
        '
        Me.OrgaoRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "OrgaoRG", True))
        Me.OrgaoRGTextBox.Location = New System.Drawing.Point(302, 211)
        Me.OrgaoRGTextBox.Name = "OrgaoRGTextBox"
        Me.OrgaoRGTextBox.Size = New System.Drawing.Size(54, 20)
        Me.OrgaoRGTextBox.TabIndex = 14
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(114, 211)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(118, 20)
        Me.RGTextBox.TabIndex = 12
        '
        'DatadeNascMaskedTextBox
        '
        Me.DatadeNascMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "DatadeNasc", True))
        Me.DatadeNascMaskedTextBox.Location = New System.Drawing.Point(114, 128)
        Me.DatadeNascMaskedTextBox.Mask = "00/00/0000"
        Me.DatadeNascMaskedTextBox.Name = "DatadeNascMaskedTextBox"
        Me.DatadeNascMaskedTextBox.Size = New System.Drawing.Size(72, 20)
        Me.DatadeNascMaskedTextBox.TabIndex = 10
        Me.DatadeNascMaskedTextBox.ValidatingType = GetType(Date)
        '
        'NomePaiTextBox
        '
        Me.NomePaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomePai", True))
        Me.NomePaiTextBox.Location = New System.Drawing.Point(114, 102)
        Me.NomePaiTextBox.Name = "NomePaiTextBox"
        Me.NomePaiTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomePaiTextBox.TabIndex = 8
        '
        'NomeMaeTextBox
        '
        Me.NomeMaeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NomeMae", True))
        Me.NomeMaeTextBox.Location = New System.Drawing.Point(114, 76)
        Me.NomeMaeTextBox.Name = "NomeMaeTextBox"
        Me.NomeMaeTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomeMaeTextBox.TabIndex = 6
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(114, 24)
        Me.CPFMaskedTextBox.Mask = "999,999,999-99"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFMaskedTextBox.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBoxOutrosDados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Endereço"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBoxOutrosDados
        '
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
        Me.GroupBoxOutrosDados.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxOutrosDados.Name = "GroupBoxOutrosDados"
        Me.GroupBoxOutrosDados.Size = New System.Drawing.Size(577, 301)
        Me.GroupBoxOutrosDados.TabIndex = 52
        Me.GroupBoxOutrosDados.TabStop = False
        Me.GroupBoxOutrosDados.Text = "Outros Dados"
        '
        'BtnAtalhoConjuge2
        '
        Me.BtnAtalhoConjuge2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnAtalhoConjuge2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtalhoConjuge2.Location = New System.Drawing.Point(485, 260)
        Me.BtnAtalhoConjuge2.Name = "BtnAtalhoConjuge2"
        Me.BtnAtalhoConjuge2.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtalhoConjuge2.TabIndex = 65
        Me.BtnAtalhoConjuge2.Text = "Cônjuge"
        Me.BtnAtalhoConjuge2.UseVisualStyleBackColor = False
        '
        'BtnAtablhoSocio
        '
        Me.BtnAtablhoSocio.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnAtablhoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtablhoSocio.Location = New System.Drawing.Point(485, 231)
        Me.BtnAtablhoSocio.Name = "BtnAtablhoSocio"
        Me.BtnAtablhoSocio.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtablhoSocio.TabIndex = 56
        Me.BtnAtablhoSocio.Text = "Dados"
        Me.BtnAtablhoSocio.UseVisualStyleBackColor = False
        '
        'BtnCorreios
        '
        Me.BtnCorreios.BackColor = System.Drawing.Color.White
        Me.BtnCorreios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorreios.Location = New System.Drawing.Point(159, 26)
        Me.BtnCorreios.Name = "BtnCorreios"
        Me.BtnCorreios.Size = New System.Drawing.Size(73, 22)
        Me.BtnCorreios.TabIndex = 51
        Me.BtnCorreios.Text = "Preencher"
        Me.BtnCorreios.UseVisualStyleBackColor = False
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "eMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(81, 235)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(271, 20)
        Me.EMailTextBox.TabIndex = 50
        '
        'Telefone2MaskedTextBox
        '
        Me.Telefone2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Telefone2", True))
        Me.Telefone2MaskedTextBox.Location = New System.Drawing.Point(81, 209)
        Me.Telefone2MaskedTextBox.Name = "Telefone2MaskedTextBox"
        Me.Telefone2MaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefone2MaskedTextBox.TabIndex = 48
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Telefone1", True))
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(81, 183)
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefone1MaskedTextBox.TabIndex = 46
        '
        'PaísTextBox
        '
        Me.PaísTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "País", True))
        Me.PaísTextBox.Location = New System.Drawing.Point(81, 157)
        Me.PaísTextBox.Name = "PaísTextBox"
        Me.PaísTextBox.Size = New System.Drawing.Size(124, 20)
        Me.PaísTextBox.TabIndex = 44
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(310, 131)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(42, 20)
        Me.EstadoTextBox.TabIndex = 42
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(81, 131)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(174, 20)
        Me.CidadeTextBox.TabIndex = 40
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(232, 79)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ComplementoTextBox.TabIndex = 38
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(81, 105)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(271, 20)
        Me.BairroTextBox.TabIndex = 36
        '
        'NumTextBox
        '
        Me.NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "Num", True))
        Me.NumTextBox.Location = New System.Drawing.Point(81, 79)
        Me.NumTextBox.Name = "NumTextBox"
        Me.NumTextBox.Size = New System.Drawing.Size(65, 20)
        Me.NumTextBox.TabIndex = 34
        '
        'RUATextBox
        '
        Me.RUATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "RUA", True))
        Me.RUATextBox.Location = New System.Drawing.Point(81, 53)
        Me.RUATextBox.Name = "RUATextBox"
        Me.RUATextBox.Size = New System.Drawing.Size(271, 20)
        Me.RUATextBox.TabIndex = 32
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(81, 27)
        Me.CEPMaskedTextBox.Mask = "99999-999"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(72, 20)
        Me.CEPMaskedTextBox.TabIndex = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnAtalhoEndereco3)
        Me.TabPage3.Controls.Add(Me.BtnAtablhoSocio3)
        Me.TabPage3.Controls.Add(Me.GroupBoxConjuge)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(583, 307)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Cônjuge"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnAtalhoEndereco3
        '
        Me.BtnAtalhoEndereco3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnAtalhoEndereco3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtalhoEndereco3.Location = New System.Drawing.Point(485, 260)
        Me.BtnAtalhoEndereco3.Name = "BtnAtalhoEndereco3"
        Me.BtnAtalhoEndereco3.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtalhoEndereco3.TabIndex = 67
        Me.BtnAtalhoEndereco3.Text = "Endereço"
        Me.BtnAtalhoEndereco3.UseVisualStyleBackColor = False
        '
        'BtnAtablhoSocio3
        '
        Me.BtnAtablhoSocio3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnAtablhoSocio3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtablhoSocio3.Location = New System.Drawing.Point(485, 231)
        Me.BtnAtablhoSocio3.Name = "BtnAtablhoSocio3"
        Me.BtnAtablhoSocio3.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtablhoSocio3.TabIndex = 66
        Me.BtnAtablhoSocio3.Text = "Dados"
        Me.BtnAtablhoSocio3.UseVisualStyleBackColor = False
        '
        'GroupBoxConjuge
        '
        Me.GroupBoxConjuge.Controls.Add(NOMEdoCONJUGELabel)
        Me.GroupBoxConjuge.Controls.Add(Me.NOMEdoCONJUGETextBox)
        Me.GroupBoxConjuge.Controls.Add(CPFdoCONJUGELabel)
        Me.GroupBoxConjuge.Controls.Add(Me.CPFdoCONJUGEMaskedTextBox)
        Me.GroupBoxConjuge.Location = New System.Drawing.Point(4, 12)
        Me.GroupBoxConjuge.Name = "GroupBoxConjuge"
        Me.GroupBoxConjuge.Size = New System.Drawing.Size(528, 101)
        Me.GroupBoxConjuge.TabIndex = 4
        Me.GroupBoxConjuge.TabStop = False
        '
        'NOMEdoCONJUGETextBox
        '
        Me.NOMEdoCONJUGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "NOMEdoCONJUGE", True))
        Me.NOMEdoCONJUGETextBox.Location = New System.Drawing.Point(131, 40)
        Me.NOMEdoCONJUGETextBox.Name = "NOMEdoCONJUGETextBox"
        Me.NOMEdoCONJUGETextBox.Size = New System.Drawing.Size(319, 20)
        Me.NOMEdoCONJUGETextBox.TabIndex = 3
        '
        'CPFdoCONJUGEMaskedTextBox
        '
        Me.CPFdoCONJUGEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "CPFdoCONJUGE", True))
        Me.CPFdoCONJUGEMaskedTextBox.Location = New System.Drawing.Point(131, 14)
        Me.CPFdoCONJUGEMaskedTextBox.Mask = "999,999,999-99"
        Me.CPFdoCONJUGEMaskedTextBox.Name = "CPFdoCONJUGEMaskedTextBox"
        Me.CPFdoCONJUGEMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFdoCONJUGEMaskedTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BtnCapitalSocial)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.BtnAddSocios)
        Me.GroupBox2.Controls.Add(Me.BtnWord)
        Me.GroupBox2.Controls.Add(Me.BtnExportar)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 442)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 64)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exportação"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(409, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Nº do sócio:"
        '
        'BtnCapitalSocial
        '
        Me.BtnCapitalSocial.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnCapitalSocial.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnCapitalSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCapitalSocial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCapitalSocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCapitalSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCapitalSocial.Location = New System.Drawing.Point(245, 19)
        Me.BtnCapitalSocial.Name = "BtnCapitalSocial"
        Me.BtnCapitalSocial.Size = New System.Drawing.Size(128, 40)
        Me.BtnCapitalSocial.TabIndex = 54
        Me.BtnCapitalSocial.Text = "Abrir Calculadora Capítal Social"
        Me.BtnCapitalSocial.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "+ Digitar"})
        Me.ComboBox1.Location = New System.Drawing.Point(419, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(58, 21)
        Me.ComboBox1.TabIndex = 54
        '
        'BtnAddSocios
        '
        Me.BtnAddSocios.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnAddSocios.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnAddSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddSocios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddSocios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddSocios.Location = New System.Drawing.Point(147, 19)
        Me.BtnAddSocios.Name = "BtnAddSocios"
        Me.BtnAddSocios.Size = New System.Drawing.Size(92, 40)
        Me.BtnAddSocios.TabIndex = 53
        Me.BtnAddSocios.Text = "Exportar Sócio"
        Me.BtnAddSocios.UseVisualStyleBackColor = False
        '
        'BtnWord
        '
        Me.BtnWord.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnWord.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnWord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWord.Location = New System.Drawing.Point(483, 18)
        Me.BtnWord.Name = "BtnWord"
        Me.BtnWord.Size = New System.Drawing.Size(98, 43)
        Me.BtnWord.TabIndex = 53
        Me.BtnWord.Text = "Exportar Sócio para o Word"
        Me.BtnWord.UseVisualStyleBackColor = False
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnExportar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportar.Location = New System.Drawing.Point(8, 19)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(136, 40)
        Me.BtnExportar.TabIndex = 52
        Me.BtnExportar.Text = "Exportar Responsavel da Federal"
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.FlatAppearance.BorderSize = 0
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Location = New System.Drawing.Point(602, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(93, 52)
        Me.BtnFechar.TabIndex = 57
        Me.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.81662!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18338!))
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.67509!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.41651!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.88368!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(698, 778)
        Me.TableLayoutPanel1.TabIndex = 51
        '
        'GroupBoxMenuCapitalSocial
        '
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.BtnCapitalEmpresas)
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.BtnADDSocioCapital)
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.ButtonLimpar)
        Me.GroupBoxMenuCapitalSocial.Controls.Add(Me.ButtonPorcentagem)
        Me.GroupBoxMenuCapitalSocial.Location = New System.Drawing.Point(602, 512)
        Me.GroupBoxMenuCapitalSocial.Name = "GroupBoxMenuCapitalSocial"
        Me.GroupBoxMenuCapitalSocial.Size = New System.Drawing.Size(93, 218)
        Me.GroupBoxMenuCapitalSocial.TabIndex = 63
        Me.GroupBoxMenuCapitalSocial.TabStop = False
        Me.GroupBoxMenuCapitalSocial.Text = "Menu do Capital Social"
        '
        'BtnCapitalEmpresas
        '
        Me.BtnCapitalEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCapitalEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCapitalEmpresas.Location = New System.Drawing.Point(7, 151)
        Me.BtnCapitalEmpresas.Name = "BtnCapitalEmpresas"
        Me.BtnCapitalEmpresas.Size = New System.Drawing.Size(76, 60)
        Me.BtnCapitalEmpresas.TabIndex = 40
        Me.BtnCapitalEmpresas.Text = "Exportar para Empresas"
        Me.BtnCapitalEmpresas.UseVisualStyleBackColor = True
        '
        'BtnADDSocioCapital
        '
        Me.BtnADDSocioCapital.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnADDSocioCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnADDSocioCapital.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnADDSocioCapital.Location = New System.Drawing.Point(6, 33)
        Me.BtnADDSocioCapital.Name = "BtnADDSocioCapital"
        Me.BtnADDSocioCapital.Size = New System.Drawing.Size(75, 44)
        Me.BtnADDSocioCapital.TabIndex = 8
        Me.BtnADDSocioCapital.Text = "Adicionar Sócio"
        Me.BtnADDSocioCapital.UseVisualStyleBackColor = True
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.Red
        Me.ButtonLimpar.Location = New System.Drawing.Point(7, 116)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(76, 29)
        Me.ButtonLimpar.TabIndex = 39
        Me.ButtonLimpar.Text = "Limpar Tudo"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'ButtonPorcentagem
        '
        Me.ButtonPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPorcentagem.Location = New System.Drawing.Point(6, 81)
        Me.ButtonPorcentagem.Name = "ButtonPorcentagem"
        Me.ButtonPorcentagem.Size = New System.Drawing.Size(76, 29)
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
        Me.GroupBoxCapitalSocial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxCapitalSocial.Location = New System.Drawing.Point(3, 512)
        Me.GroupBoxCapitalSocial.Name = "GroupBoxCapitalSocial"
        Me.GroupBoxCapitalSocial.Size = New System.Drawing.Size(593, 263)
        Me.GroupBoxCapitalSocial.TabIndex = 64
        Me.GroupBoxCapitalSocial.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 15)
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
        Me.DataGridView1.Location = New System.Drawing.Point(14, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 179)
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
        Me.LblCapTotal.Location = New System.Drawing.Point(14, 48)
        Me.LblCapTotal.Name = "LblCapTotal"
        Me.LblCapTotal.Size = New System.Drawing.Size(127, 16)
        Me.LblCapTotal.TabIndex = 37
        Me.LblCapTotal.Text = "Capital Social Total:"
        '
        'TextBoxCapitalSocial
        '
        Me.TextBoxCapitalSocial.Location = New System.Drawing.Point(147, 44)
        Me.TextBoxCapitalSocial.Name = "TextBoxCapitalSocial"
        Me.TextBoxCapitalSocial.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxCapitalSocial.TabIndex = 35
        Me.TextBoxCapitalSocial.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CPFComboBox)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.NomeCompletoComboBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(593, 94)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "CADASTRO DOS SOCIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(698, 778)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmSocios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sócios"
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBoxDadosPessoais.ResumeLayout(False)
        Me.GroupBoxDadosPessoais.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBoxOutrosDados.ResumeLayout(False)
        Me.GroupBoxOutrosDados.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBoxConjuge.ResumeLayout(False)
        Me.GroupBoxConjuge.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxMenuCapitalSocial.ResumeLayout(False)
        Me.GroupBoxCapitalSocial.ResumeLayout(False)
        Me.GroupBoxCapitalSocial.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnExcluir As Button
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
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCapitalSocial As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnAddSocios As Button
    Friend WithEvents BtnWord As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxMenuCapitalSocial As GroupBox
    Friend WithEvents BtnADDSocioCapital As Button
    Friend WithEvents GroupBoxCapitalSocial As GroupBox
    Friend WithEvents ButtonLimpar As Button
    Friend WithEvents ButtonPorcentagem As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnSocio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPorcentagem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAntigo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNovo As DataGridViewTextBoxColumn
    Friend WithEvents GanhaEPerca As DataGridViewTextBoxColumn
    Friend WithEvents LblCapTotal As Label
    Friend WithEvents TextBoxCapitalSocial As TextBox
    Friend WithEvents BtnCapitalEmpresas As Button
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
    Friend WithEvents BtnFecharMenu As Button
    Friend WithEvents BtnAtalhoConjuge As Button
    Friend WithEvents BtnAtalhoConjuge2 As Button
    Friend WithEvents BtnAtalhoEndereco3 As Button
    Friend WithEvents BtnAtablhoSocio3 As Button
End Class
