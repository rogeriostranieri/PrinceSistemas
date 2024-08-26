<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContadorGeral
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim CRCLabel As System.Windows.Forms.Label
        Dim ExpedicaoCRCLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CMCLabel As System.Windows.Forms.Label
        Dim EndCEPLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim EndNumLabel As System.Windows.Forms.Label
        Dim EndCompLabel As System.Windows.Forms.Label
        Dim EndBairroLabel As System.Windows.Forms.Label
        Dim EndCidadeLabel As System.Windows.Forms.Label
        Dim EndEstadoLabel As System.Windows.Forms.Label
        Dim EstadoCivilLabel As System.Windows.Forms.Label
        Dim DataNascLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim ProfissaoLabel As System.Windows.Forms.Label
        Dim NomePaiLabel As System.Windows.Forms.Label
        Dim NomeMaeLabel As System.Windows.Forms.Label
        Dim Email1Label As System.Windows.Forms.Label
        Dim Email2Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContadorGeral))
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ContadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CRCTextBox = New System.Windows.Forms.TextBox()
        Me.ExpedicaoCRCMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RGTextBox = New System.Windows.Forms.TextBox()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CMCTextBox = New System.Windows.Forms.TextBox()
        Me.EndCEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.EndNumTextBox = New System.Windows.Forms.TextBox()
        Me.EndCompTextBox = New System.Windows.Forms.TextBox()
        Me.EndBairroTextBox = New System.Windows.Forms.TextBox()
        Me.EndCidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EndEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxBusca = New System.Windows.Forms.ToolStripComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.RGSiglaTextBox = New System.Windows.Forms.TextBox()
        Me.Button44 = New System.Windows.Forms.Button()
        Me.EstadoCivilComboBox = New System.Windows.Forms.ComboBox()
        Me.DataNascMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.ProfissaoTextBox = New System.Windows.Forms.TextBox()
        Me.TabControlContador = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NomeMaeTextBox = New System.Windows.Forms.TextBox()
        Me.NomePaiTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Email2TextBox = New System.Windows.Forms.TextBox()
        Me.Email1TextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AnotacoesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ContadorTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ContadorTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.BtnCopiaCEP = New System.Windows.Forms.Button()
        NomeLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        CRCLabel = New System.Windows.Forms.Label()
        ExpedicaoCRCLabel = New System.Windows.Forms.Label()
        RGLabel = New System.Windows.Forms.Label()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CMCLabel = New System.Windows.Forms.Label()
        EndCEPLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        EndNumLabel = New System.Windows.Forms.Label()
        EndCompLabel = New System.Windows.Forms.Label()
        EndBairroLabel = New System.Windows.Forms.Label()
        EndCidadeLabel = New System.Windows.Forms.Label()
        EndEstadoLabel = New System.Windows.Forms.Label()
        EstadoCivilLabel = New System.Windows.Forms.Label()
        DataNascLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        ProfissaoLabel = New System.Windows.Forms.Label()
        NomePaiLabel = New System.Windows.Forms.Label()
        NomeMaeLabel = New System.Windows.Forms.Label()
        Email1Label = New System.Windows.Forms.Label()
        Email2Label = New System.Windows.Forms.Label()
        CType(Me.ContadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControlContador.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Location = New System.Drawing.Point(42, 20)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.BackColor = System.Drawing.Color.Transparent
        CPFLabel.Location = New System.Drawing.Point(50, 73)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 3
        CPFLabel.Text = "CPF:"
        '
        'CRCLabel
        '
        CRCLabel.AutoSize = True
        CRCLabel.BackColor = System.Drawing.Color.Transparent
        CRCLabel.Location = New System.Drawing.Point(48, 151)
        CRCLabel.Name = "CRCLabel"
        CRCLabel.Size = New System.Drawing.Size(32, 13)
        CRCLabel.TabIndex = 5
        CRCLabel.Text = "CRC:"
        '
        'ExpedicaoCRCLabel
        '
        ExpedicaoCRCLabel.AutoSize = True
        ExpedicaoCRCLabel.BackColor = System.Drawing.Color.Transparent
        ExpedicaoCRCLabel.Location = New System.Drawing.Point(191, 151)
        ExpedicaoCRCLabel.Name = "ExpedicaoCRCLabel"
        ExpedicaoCRCLabel.Size = New System.Drawing.Size(85, 13)
        ExpedicaoCRCLabel.TabIndex = 7
        ExpedicaoCRCLabel.Text = "Expedição CRC:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.BackColor = System.Drawing.Color.Transparent
        RGLabel.Location = New System.Drawing.Point(54, 99)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(26, 13)
        RGLabel.TabIndex = 9
        RGLabel.Text = "RG:"
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.BackColor = System.Drawing.Color.Transparent
        RazaoSocialLabel.Location = New System.Drawing.Point(10, 18)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazaoSocialLabel.TabIndex = 11
        RazaoSocialLabel.Text = "Razão Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.BackColor = System.Drawing.Color.Transparent
        CNPJLabel.Location = New System.Drawing.Point(46, 44)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(37, 13)
        CNPJLabel.TabIndex = 13
        CNPJLabel.Text = "CNPJ:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneLabel.Location = New System.Drawing.Point(378, 47)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 15
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(4, 70)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(81, 13)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "e-Mail Principal:"
        '
        'CMCLabel
        '
        CMCLabel.AutoSize = True
        CMCLabel.BackColor = System.Drawing.Color.Transparent
        CMCLabel.Location = New System.Drawing.Point(208, 44)
        CMCLabel.Name = "CMCLabel"
        CMCLabel.Size = New System.Drawing.Size(33, 13)
        CMCLabel.TabIndex = 19
        CMCLabel.Text = "CMC:"
        '
        'EndCEPLabel
        '
        EndCEPLabel.AutoSize = True
        EndCEPLabel.BackColor = System.Drawing.Color.Transparent
        EndCEPLabel.Location = New System.Drawing.Point(52, 161)
        EndCEPLabel.Name = "EndCEPLabel"
        EndCEPLabel.Size = New System.Drawing.Size(31, 13)
        EndCEPLabel.TabIndex = 21
        EndCEPLabel.Text = "CEP:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.BackColor = System.Drawing.Color.Transparent
        EnderecoLabel.Location = New System.Drawing.Point(27, 187)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 23
        EnderecoLabel.Text = "Endereço:"
        '
        'EndNumLabel
        '
        EndNumLabel.AutoSize = True
        EndNumLabel.Location = New System.Drawing.Point(416, 187)
        EndNumLabel.Name = "EndNumLabel"
        EndNumLabel.Size = New System.Drawing.Size(22, 13)
        EndNumLabel.TabIndex = 25
        EndNumLabel.Text = "N°:"
        '
        'EndCompLabel
        '
        EndCompLabel.AutoSize = True
        EndCompLabel.BackColor = System.Drawing.Color.Transparent
        EndCompLabel.Location = New System.Drawing.Point(6, 213)
        EndCompLabel.Name = "EndCompLabel"
        EndCompLabel.Size = New System.Drawing.Size(77, 13)
        EndCompLabel.TabIndex = 27
        EndCompLabel.Text = " Complemento:"
        '
        'EndBairroLabel
        '
        EndBairroLabel.AutoSize = True
        EndBairroLabel.BackColor = System.Drawing.Color.Transparent
        EndBairroLabel.Location = New System.Drawing.Point(247, 213)
        EndBairroLabel.Name = "EndBairroLabel"
        EndBairroLabel.Size = New System.Drawing.Size(37, 13)
        EndBairroLabel.TabIndex = 29
        EndBairroLabel.Text = "Bairro:"
        '
        'EndCidadeLabel
        '
        EndCidadeLabel.AutoSize = True
        EndCidadeLabel.BackColor = System.Drawing.Color.Transparent
        EndCidadeLabel.Location = New System.Drawing.Point(40, 239)
        EndCidadeLabel.Name = "EndCidadeLabel"
        EndCidadeLabel.Size = New System.Drawing.Size(43, 13)
        EndCidadeLabel.TabIndex = 31
        EndCidadeLabel.Text = "Cidade:"
        '
        'EndEstadoLabel
        '
        EndEstadoLabel.AutoSize = True
        EndEstadoLabel.BackColor = System.Drawing.Color.Transparent
        EndEstadoLabel.Location = New System.Drawing.Point(241, 242)
        EndEstadoLabel.Name = "EndEstadoLabel"
        EndEstadoLabel.Size = New System.Drawing.Size(43, 13)
        EndEstadoLabel.TabIndex = 33
        EndEstadoLabel.Text = "Estado:"
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.BackColor = System.Drawing.Color.Transparent
        EstadoCivilLabel.Location = New System.Drawing.Point(15, 177)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(65, 13)
        EstadoCivilLabel.TabIndex = 64
        EstadoCivilLabel.Text = "Estado Civil:"
        '
        'DataNascLabel
        '
        DataNascLabel.AutoSize = True
        DataNascLabel.BackColor = System.Drawing.Color.Transparent
        DataNascLabel.Location = New System.Drawing.Point(268, 46)
        DataNascLabel.Name = "DataNascLabel"
        DataNascLabel.Size = New System.Drawing.Size(76, 13)
        DataNascLabel.TabIndex = 66
        DataNascLabel.Text = "Data de Nasc:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.BackColor = System.Drawing.Color.Transparent
        GeneroLabel.Location = New System.Drawing.Point(35, 46)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 67
        GeneroLabel.Text = "Genero:"
        '
        'ProfissaoLabel
        '
        ProfissaoLabel.AutoSize = True
        ProfissaoLabel.BackColor = System.Drawing.Color.Transparent
        ProfissaoLabel.Location = New System.Drawing.Point(27, 125)
        ProfissaoLabel.Name = "ProfissaoLabel"
        ProfissaoLabel.Size = New System.Drawing.Size(53, 13)
        ProfissaoLabel.TabIndex = 68
        ProfissaoLabel.Text = "Profissão:"
        '
        'NomePaiLabel
        '
        NomePaiLabel.AutoSize = True
        NomePaiLabel.Location = New System.Drawing.Point(14, 204)
        NomePaiLabel.Name = "NomePaiLabel"
        NomePaiLabel.Size = New System.Drawing.Size(71, 13)
        NomePaiLabel.TabIndex = 69
        NomePaiLabel.Text = "Nome do Pai:"
        '
        'NomeMaeLabel
        '
        NomeMaeLabel.AutoSize = True
        NomeMaeLabel.Location = New System.Drawing.Point(9, 230)
        NomeMaeLabel.Name = "NomeMaeLabel"
        NomeMaeLabel.Size = New System.Drawing.Size(77, 13)
        NomeMaeLabel.TabIndex = 70
        NomeMaeLabel.Text = "Nome da Mae:"
        '
        'Email1Label
        '
        Email1Label.AutoSize = True
        Email1Label.Location = New System.Drawing.Point(39, 96)
        Email1Label.Name = "Email1Label"
        Email1Label.Size = New System.Drawing.Size(47, 13)
        Email1Label.TabIndex = 38
        Email1Label.Text = "e-Mail 2:"
        '
        'Email2Label
        '
        Email2Label.AutoSize = True
        Email2Label.Location = New System.Drawing.Point(38, 122)
        Email2Label.Name = "Email2Label"
        Email2Label.Size = New System.Drawing.Size(47, 13)
        Email2Label.TabIndex = 39
        Email2Label.Text = "e-Mail 3:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(86, 17)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(334, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'ContadorBindingSource
        '
        Me.ContadorBindingSource.DataMember = "Contador"
        Me.ContadorBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(86, 70)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(87, 20)
        Me.CPFMaskedTextBox.TabIndex = 4
        '
        'CRCTextBox
        '
        Me.CRCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CRC", True))
        Me.CRCTextBox.Location = New System.Drawing.Point(86, 148)
        Me.CRCTextBox.Name = "CRCTextBox"
        Me.CRCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CRCTextBox.TabIndex = 6
        '
        'ExpedicaoCRCMaskedTextBox
        '
        Me.ExpedicaoCRCMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "ExpedicaoCRC", True))
        Me.ExpedicaoCRCMaskedTextBox.Location = New System.Drawing.Point(282, 148)
        Me.ExpedicaoCRCMaskedTextBox.Mask = "00/00/0000"
        Me.ExpedicaoCRCMaskedTextBox.Name = "ExpedicaoCRCMaskedTextBox"
        Me.ExpedicaoCRCMaskedTextBox.Size = New System.Drawing.Size(68, 20)
        Me.ExpedicaoCRCMaskedTextBox.TabIndex = 8
        Me.ExpedicaoCRCMaskedTextBox.ValidatingType = GetType(Date)
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(86, 96)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RGTextBox.TabIndex = 10
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(89, 15)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(430, 20)
        Me.RazaoSocialTextBox.TabIndex = 12
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(89, 41)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(109, 20)
        Me.CNPJMaskedTextBox.TabIndex = 14
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(436, 44)
        Me.TelefoneMaskedTextBox.Mask = "(99) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(83, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(89, 67)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(290, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'CMCTextBox
        '
        Me.CMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CMC", True))
        Me.CMCTextBox.Location = New System.Drawing.Point(247, 41)
        Me.CMCTextBox.Name = "CMCTextBox"
        Me.CMCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CMCTextBox.TabIndex = 20
        '
        'EndCEPMaskedTextBox
        '
        Me.EndCEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndCEP", True))
        Me.EndCEPMaskedTextBox.Location = New System.Drawing.Point(89, 158)
        Me.EndCEPMaskedTextBox.Mask = "00000-000"
        Me.EndCEPMaskedTextBox.Name = "EndCEPMaskedTextBox"
        Me.EndCEPMaskedTextBox.Size = New System.Drawing.Size(63, 20)
        Me.EndCEPMaskedTextBox.TabIndex = 22
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(89, 184)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(321, 20)
        Me.EnderecoTextBox.TabIndex = 24
        '
        'EndNumTextBox
        '
        Me.EndNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndNum", True))
        Me.EndNumTextBox.Location = New System.Drawing.Point(444, 184)
        Me.EndNumTextBox.Name = "EndNumTextBox"
        Me.EndNumTextBox.Size = New System.Drawing.Size(75, 20)
        Me.EndNumTextBox.TabIndex = 26
        '
        'EndCompTextBox
        '
        Me.EndCompTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndComp", True))
        Me.EndCompTextBox.Location = New System.Drawing.Point(89, 210)
        Me.EndCompTextBox.Name = "EndCompTextBox"
        Me.EndCompTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EndCompTextBox.TabIndex = 28
        '
        'EndBairroTextBox
        '
        Me.EndBairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndBairro", True))
        Me.EndBairroTextBox.Location = New System.Drawing.Point(290, 210)
        Me.EndBairroTextBox.Name = "EndBairroTextBox"
        Me.EndBairroTextBox.Size = New System.Drawing.Size(229, 20)
        Me.EndBairroTextBox.TabIndex = 30
        '
        'EndCidadeTextBox
        '
        Me.EndCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndCidade", True))
        Me.EndCidadeTextBox.Location = New System.Drawing.Point(89, 236)
        Me.EndCidadeTextBox.Name = "EndCidadeTextBox"
        Me.EndCidadeTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EndCidadeTextBox.TabIndex = 32
        '
        'EndEstadoTextBox
        '
        Me.EndEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndEstado", True))
        Me.EndEstadoTextBox.Location = New System.Drawing.Point(290, 239)
        Me.EndEstadoTextBox.Name = "EndEstadoTextBox"
        Me.EndEstadoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.EndEstadoTextBox.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(158, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 22)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Buscar CEP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.Contador1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ComboBoxBusca})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 25)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripLabel1.Text = "Selecionar:"
        '
        'ComboBoxBusca
        '
        Me.ComboBoxBusca.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ComboBoxBusca.Name = "ComboBoxBusca"
        Me.ComboBoxBusca.Size = New System.Drawing.Size(210, 25)
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button16)
        Me.GroupBox5.Controls.Add(Me.Button18)
        Me.GroupBox5.Controls.Add(Me.Button17)
        Me.GroupBox5.Controls.Add(Me.Button19)
        Me.GroupBox5.Location = New System.Drawing.Point(738, 45)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(82, 160)
        Me.GroupBox5.TabIndex = 59
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MENU"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(6, 19)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(69, 22)
        Me.Button16.TabIndex = 46
        Me.Button16.Text = "Novo"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(6, 47)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(69, 23)
        Me.Button18.TabIndex = 48
        Me.Button18.Text = "Salvar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(6, 92)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(69, 23)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "Excluir"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(6, 121)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(69, 23)
        Me.Button19.TabIndex = 49
        Me.Button19.Text = "Fechar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'RGSiglaTextBox
        '
        Me.RGSiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RGSigla", True))
        Me.RGSiglaTextBox.Location = New System.Drawing.Point(192, 96)
        Me.RGSiglaTextBox.Name = "RGSiglaTextBox"
        Me.RGSiglaTextBox.Size = New System.Drawing.Size(63, 20)
        Me.RGSiglaTextBox.TabIndex = 60
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.Transparent
        Me.Button44.BackgroundImage = CType(resources.GetObject("Button44.BackgroundImage"), System.Drawing.Image)
        Me.Button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button44.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(179, 69)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(42, 22)
        Me.Button44.TabIndex = 64
        Me.Button44.Text = "Copiar"
        Me.Button44.UseVisualStyleBackColor = False
        '
        'EstadoCivilComboBox
        '
        Me.EstadoCivilComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoCivilComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoCivilComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EstadoCivil", True))
        Me.EstadoCivilComboBox.FormattingEnabled = True
        Me.EstadoCivilComboBox.Location = New System.Drawing.Point(86, 174)
        Me.EstadoCivilComboBox.Name = "EstadoCivilComboBox"
        Me.EstadoCivilComboBox.Size = New System.Drawing.Size(334, 21)
        Me.EstadoCivilComboBox.TabIndex = 65
        '
        'DataNascMaskedTextBox
        '
        Me.DataNascMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "DataNasc", True))
        Me.DataNascMaskedTextBox.Location = New System.Drawing.Point(345, 43)
        Me.DataNascMaskedTextBox.Mask = "00/00/0000"
        Me.DataNascMaskedTextBox.Name = "DataNascMaskedTextBox"
        Me.DataNascMaskedTextBox.Size = New System.Drawing.Size(75, 20)
        Me.DataNascMaskedTextBox.TabIndex = 67
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GeneroComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Genero", True))
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.GeneroComboBox.Location = New System.Drawing.Point(86, 43)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GeneroComboBox.TabIndex = 68
        '
        'ProfissaoTextBox
        '
        Me.ProfissaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Profissao", True))
        Me.ProfissaoTextBox.Location = New System.Drawing.Point(86, 122)
        Me.ProfissaoTextBox.Name = "ProfissaoTextBox"
        Me.ProfissaoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProfissaoTextBox.TabIndex = 69
        '
        'TabControlContador
        '
        Me.TabControlContador.Controls.Add(Me.TabPage1)
        Me.TabControlContador.Controls.Add(Me.TabPage2)
        Me.TabControlContador.Controls.Add(Me.TabPage3)
        Me.TabControlContador.Location = New System.Drawing.Point(132, 45)
        Me.TabControlContador.Name = "TabControlContador"
        Me.TabControlContador.SelectedIndex = 0
        Me.TabControlContador.Size = New System.Drawing.Size(600, 294)
        Me.TabControlContador.TabIndex = 71
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(NomeMaeLabel)
        Me.TabPage1.Controls.Add(Me.NomeMaeTextBox)
        Me.TabPage1.Controls.Add(NomePaiLabel)
        Me.TabPage1.Controls.Add(Me.NomePaiTextBox)
        Me.TabPage1.Controls.Add(Me.NomeTextBox)
        Me.TabPage1.Controls.Add(NomeLabel)
        Me.TabPage1.Controls.Add(ProfissaoLabel)
        Me.TabPage1.Controls.Add(Me.CPFMaskedTextBox)
        Me.TabPage1.Controls.Add(Me.ProfissaoTextBox)
        Me.TabPage1.Controls.Add(CPFLabel)
        Me.TabPage1.Controls.Add(GeneroLabel)
        Me.TabPage1.Controls.Add(Me.CRCTextBox)
        Me.TabPage1.Controls.Add(Me.GeneroComboBox)
        Me.TabPage1.Controls.Add(CRCLabel)
        Me.TabPage1.Controls.Add(DataNascLabel)
        Me.TabPage1.Controls.Add(Me.ExpedicaoCRCMaskedTextBox)
        Me.TabPage1.Controls.Add(Me.DataNascMaskedTextBox)
        Me.TabPage1.Controls.Add(ExpedicaoCRCLabel)
        Me.TabPage1.Controls.Add(EstadoCivilLabel)
        Me.TabPage1.Controls.Add(Me.RGTextBox)
        Me.TabPage1.Controls.Add(Me.EstadoCivilComboBox)
        Me.TabPage1.Controls.Add(RGLabel)
        Me.TabPage1.Controls.Add(Me.Button44)
        Me.TabPage1.Controls.Add(Me.RGSiglaTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(592, 268)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contador"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NomeMaeTextBox
        '
        Me.NomeMaeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "NomeMae", True))
        Me.NomeMaeTextBox.Location = New System.Drawing.Point(86, 227)
        Me.NomeMaeTextBox.Name = "NomeMaeTextBox"
        Me.NomeMaeTextBox.Size = New System.Drawing.Size(334, 20)
        Me.NomeMaeTextBox.TabIndex = 71
        '
        'NomePaiTextBox
        '
        Me.NomePaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "NomePai", True))
        Me.NomePaiTextBox.Location = New System.Drawing.Point(86, 201)
        Me.NomePaiTextBox.Name = "NomePaiTextBox"
        Me.NomePaiTextBox.Size = New System.Drawing.Size(334, 20)
        Me.NomePaiTextBox.TabIndex = 70
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.BtnCopiaCEP)
        Me.TabPage2.Controls.Add(Email2Label)
        Me.TabPage2.Controls.Add(Me.Email2TextBox)
        Me.TabPage2.Controls.Add(Email1Label)
        Me.TabPage2.Controls.Add(Me.Email1TextBox)
        Me.TabPage2.Controls.Add(Me.RazaoSocialTextBox)
        Me.TabPage2.Controls.Add(RazaoSocialLabel)
        Me.TabPage2.Controls.Add(Me.CNPJMaskedTextBox)
        Me.TabPage2.Controls.Add(CNPJLabel)
        Me.TabPage2.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(TelefoneLabel)
        Me.TabPage2.Controls.Add(EndEstadoLabel)
        Me.TabPage2.Controls.Add(Me.EmailTextBox)
        Me.TabPage2.Controls.Add(Me.EndEstadoTextBox)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(EndCidadeLabel)
        Me.TabPage2.Controls.Add(Me.CMCTextBox)
        Me.TabPage2.Controls.Add(Me.EndCidadeTextBox)
        Me.TabPage2.Controls.Add(CMCLabel)
        Me.TabPage2.Controls.Add(EndBairroLabel)
        Me.TabPage2.Controls.Add(Me.EndCEPMaskedTextBox)
        Me.TabPage2.Controls.Add(Me.EndBairroTextBox)
        Me.TabPage2.Controls.Add(EndCEPLabel)
        Me.TabPage2.Controls.Add(EndCompLabel)
        Me.TabPage2.Controls.Add(Me.EnderecoTextBox)
        Me.TabPage2.Controls.Add(Me.EndCompTextBox)
        Me.TabPage2.Controls.Add(EnderecoLabel)
        Me.TabPage2.Controls.Add(EndNumLabel)
        Me.TabPage2.Controls.Add(Me.EndNumTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(592, 268)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Escritório"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Email2TextBox
        '
        Me.Email2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email2", True))
        Me.Email2TextBox.Location = New System.Drawing.Point(89, 119)
        Me.Email2TextBox.Name = "Email2TextBox"
        Me.Email2TextBox.Size = New System.Drawing.Size(290, 20)
        Me.Email2TextBox.TabIndex = 40
        '
        'Email1TextBox
        '
        Me.Email1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email1", True))
        Me.Email1TextBox.Location = New System.Drawing.Point(89, 93)
        Me.Email1TextBox.Name = "Email1TextBox"
        Me.Email1TextBox.Size = New System.Drawing.Size(290, 20)
        Me.Email1TextBox.TabIndex = 39
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AnotacoesRichTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(592, 268)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Anotações"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AnotacoesRichTextBox
        '
        Me.AnotacoesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Anotacoes", True))
        Me.AnotacoesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnotacoesRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.AnotacoesRichTextBox.Name = "AnotacoesRichTextBox"
        Me.AnotacoesRichTextBox.Size = New System.Drawing.Size(586, 262)
        Me.AnotacoesRichTextBox.TabIndex = 1
        Me.AnotacoesRichTextBox.Text = ""
        '
        'ContadorTableAdapter
        '
        Me.ContadorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Me.ContadorTableAdapter
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnCopiaCEP
        '
        Me.BtnCopiaCEP.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiaCEP.Location = New System.Drawing.Point(237, 158)
        Me.BtnCopiaCEP.Name = "BtnCopiaCEP"
        Me.BtnCopiaCEP.Size = New System.Drawing.Size(73, 22)
        Me.BtnCopiaCEP.TabIndex = 75
        Me.BtnCopiaCEP.Text = "Copiar CEP"
        Me.BtnCopiaCEP.UseVisualStyleBackColor = False
        '
        'ContadorGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(833, 361)
        Me.Controls.Add(Me.TabControlContador)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ContadorGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contadores"
        CType(Me.ContadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControlContador.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ContadorBindingSource As BindingSource
    Friend WithEvents ContadorTableAdapter As PrinceDBDataSetTableAdapters.ContadorTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents CRCTextBox As TextBox
    Friend WithEvents ExpedicaoCRCMaskedTextBox As MaskedTextBox
    Friend WithEvents RGTextBox As TextBox
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CMCTextBox As TextBox
    Friend WithEvents EndCEPMaskedTextBox As MaskedTextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents EndNumTextBox As TextBox
    Friend WithEvents EndCompTextBox As TextBox
    Friend WithEvents EndBairroTextBox As TextBox
    Friend WithEvents EndCidadeTextBox As TextBox
    Friend WithEvents EndEstadoTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBoxBusca As ToolStripComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents RGSiglaTextBox As TextBox
    Friend WithEvents Button44 As Button
    Friend WithEvents EstadoCivilComboBox As ComboBox
    Friend WithEvents DataNascMaskedTextBox As MaskedTextBox
    Friend WithEvents GeneroComboBox As ComboBox
    Friend WithEvents ProfissaoTextBox As TextBox
    Friend WithEvents TabControlContador As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents NomePaiTextBox As TextBox
    Friend WithEvents NomeMaeTextBox As TextBox
    Friend WithEvents Email2TextBox As TextBox
    Friend WithEvents Email1TextBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents AnotacoesRichTextBox As RichTextBox
    Friend WithEvents BtnCopiaCEP As Button
End Class
