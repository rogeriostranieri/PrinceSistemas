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
        Dim IEescritorioLabel As System.Windows.Forms.Label
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
        Me.IEescritorioTextBox = New System.Windows.Forms.TextBox()
        Me.BtnCopiaCEP = New System.Windows.Forms.Button()
        Me.Email2TextBox = New System.Windows.Forms.TextBox()
        Me.Email1TextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AnotacoesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ContadorTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ContadorTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
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
        IEescritorioLabel = New System.Windows.Forms.Label()
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
        NomeLabel.Location = New System.Drawing.Point(56, 25)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(47, 16)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.BackColor = System.Drawing.Color.Transparent
        CPFLabel.Location = New System.Drawing.Point(67, 90)
        CPFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(36, 16)
        CPFLabel.TabIndex = 3
        CPFLabel.Text = "CPF:"
        '
        'CRCLabel
        '
        CRCLabel.AutoSize = True
        CRCLabel.BackColor = System.Drawing.Color.Transparent
        CRCLabel.Location = New System.Drawing.Point(64, 186)
        CRCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CRCLabel.Name = "CRCLabel"
        CRCLabel.Size = New System.Drawing.Size(38, 16)
        CRCLabel.TabIndex = 5
        CRCLabel.Text = "CRC:"
        '
        'ExpedicaoCRCLabel
        '
        ExpedicaoCRCLabel.AutoSize = True
        ExpedicaoCRCLabel.BackColor = System.Drawing.Color.Transparent
        ExpedicaoCRCLabel.Location = New System.Drawing.Point(255, 186)
        ExpedicaoCRCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ExpedicaoCRCLabel.Name = "ExpedicaoCRCLabel"
        ExpedicaoCRCLabel.Size = New System.Drawing.Size(106, 16)
        ExpedicaoCRCLabel.TabIndex = 7
        ExpedicaoCRCLabel.Text = "Expedição CRC:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.BackColor = System.Drawing.Color.Transparent
        RGLabel.Location = New System.Drawing.Point(72, 122)
        RGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(30, 16)
        RGLabel.TabIndex = 9
        RGLabel.Text = "RG:"
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.BackColor = System.Drawing.Color.Transparent
        RazaoSocialLabel.Location = New System.Drawing.Point(13, 22)
        RazaoSocialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(91, 16)
        RazaoSocialLabel.TabIndex = 11
        RazaoSocialLabel.Text = "Razão Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.BackColor = System.Drawing.Color.Transparent
        CNPJLabel.Location = New System.Drawing.Point(61, 54)
        CNPJLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(45, 16)
        CNPJLabel.TabIndex = 13
        CNPJLabel.Text = "CNPJ:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneLabel.Location = New System.Drawing.Point(504, 58)
        TelefoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(64, 16)
        TelefoneLabel.TabIndex = 15
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(5, 297)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(102, 16)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "e-Mail Principal:"
        '
        'CMCLabel
        '
        CMCLabel.AutoSize = True
        CMCLabel.BackColor = System.Drawing.Color.Transparent
        CMCLabel.Location = New System.Drawing.Point(277, 54)
        CMCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CMCLabel.Name = "CMCLabel"
        CMCLabel.Size = New System.Drawing.Size(39, 16)
        CMCLabel.TabIndex = 19
        CMCLabel.Text = "CMC:"
        '
        'EndCEPLabel
        '
        EndCEPLabel.AutoSize = True
        EndCEPLabel.BackColor = System.Drawing.Color.Transparent
        EndCEPLabel.Location = New System.Drawing.Point(69, 129)
        EndCEPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCEPLabel.Name = "EndCEPLabel"
        EndCEPLabel.Size = New System.Drawing.Size(37, 16)
        EndCEPLabel.TabIndex = 21
        EndCEPLabel.Text = "CEP:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.BackColor = System.Drawing.Color.Transparent
        EnderecoLabel.Location = New System.Drawing.Point(36, 161)
        EnderecoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(69, 16)
        EnderecoLabel.TabIndex = 23
        EnderecoLabel.Text = "Endereço:"
        '
        'EndNumLabel
        '
        EndNumLabel.AutoSize = True
        EndNumLabel.Location = New System.Drawing.Point(555, 161)
        EndNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndNumLabel.Name = "EndNumLabel"
        EndNumLabel.Size = New System.Drawing.Size(24, 16)
        EndNumLabel.TabIndex = 25
        EndNumLabel.Text = "N°:"
        '
        'EndCompLabel
        '
        EndCompLabel.AutoSize = True
        EndCompLabel.BackColor = System.Drawing.Color.Transparent
        EndCompLabel.Location = New System.Drawing.Point(8, 193)
        EndCompLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCompLabel.Name = "EndCompLabel"
        EndCompLabel.Size = New System.Drawing.Size(97, 16)
        EndCompLabel.TabIndex = 27
        EndCompLabel.Text = " Complemento:"
        '
        'EndBairroLabel
        '
        EndBairroLabel.AutoSize = True
        EndBairroLabel.BackColor = System.Drawing.Color.Transparent
        EndBairroLabel.Location = New System.Drawing.Point(329, 193)
        EndBairroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndBairroLabel.Name = "EndBairroLabel"
        EndBairroLabel.Size = New System.Drawing.Size(46, 16)
        EndBairroLabel.TabIndex = 29
        EndBairroLabel.Text = "Bairro:"
        '
        'EndCidadeLabel
        '
        EndCidadeLabel.AutoSize = True
        EndCidadeLabel.BackColor = System.Drawing.Color.Transparent
        EndCidadeLabel.Location = New System.Drawing.Point(53, 225)
        EndCidadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCidadeLabel.Name = "EndCidadeLabel"
        EndCidadeLabel.Size = New System.Drawing.Size(54, 16)
        EndCidadeLabel.TabIndex = 31
        EndCidadeLabel.Text = "Cidade:"
        '
        'EndEstadoLabel
        '
        EndEstadoLabel.AutoSize = True
        EndEstadoLabel.BackColor = System.Drawing.Color.Transparent
        EndEstadoLabel.Location = New System.Drawing.Point(321, 229)
        EndEstadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndEstadoLabel.Name = "EndEstadoLabel"
        EndEstadoLabel.Size = New System.Drawing.Size(53, 16)
        EndEstadoLabel.TabIndex = 33
        EndEstadoLabel.Text = "Estado:"
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.BackColor = System.Drawing.Color.Transparent
        EstadoCivilLabel.Location = New System.Drawing.Point(20, 218)
        EstadoCivilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(81, 16)
        EstadoCivilLabel.TabIndex = 64
        EstadoCivilLabel.Text = "Estado Civil:"
        '
        'DataNascLabel
        '
        DataNascLabel.AutoSize = True
        DataNascLabel.BackColor = System.Drawing.Color.Transparent
        DataNascLabel.Location = New System.Drawing.Point(357, 57)
        DataNascLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataNascLabel.Name = "DataNascLabel"
        DataNascLabel.Size = New System.Drawing.Size(93, 16)
        DataNascLabel.TabIndex = 66
        DataNascLabel.Text = "Data de Nasc:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.BackColor = System.Drawing.Color.Transparent
        GeneroLabel.Location = New System.Drawing.Point(47, 57)
        GeneroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(55, 16)
        GeneroLabel.TabIndex = 67
        GeneroLabel.Text = "Genero:"
        '
        'ProfissaoLabel
        '
        ProfissaoLabel.AutoSize = True
        ProfissaoLabel.BackColor = System.Drawing.Color.Transparent
        ProfissaoLabel.Location = New System.Drawing.Point(36, 154)
        ProfissaoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProfissaoLabel.Name = "ProfissaoLabel"
        ProfissaoLabel.Size = New System.Drawing.Size(67, 16)
        ProfissaoLabel.TabIndex = 68
        ProfissaoLabel.Text = "Profissão:"
        '
        'NomePaiLabel
        '
        NomePaiLabel.AutoSize = True
        NomePaiLabel.Location = New System.Drawing.Point(19, 251)
        NomePaiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomePaiLabel.Name = "NomePaiLabel"
        NomePaiLabel.Size = New System.Drawing.Size(89, 16)
        NomePaiLabel.TabIndex = 69
        NomePaiLabel.Text = "Nome do Pai:"
        '
        'NomeMaeLabel
        '
        NomeMaeLabel.AutoSize = True
        NomeMaeLabel.Location = New System.Drawing.Point(12, 283)
        NomeMaeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeMaeLabel.Name = "NomeMaeLabel"
        NomeMaeLabel.Size = New System.Drawing.Size(96, 16)
        NomeMaeLabel.TabIndex = 70
        NomeMaeLabel.Text = "Nome da Mae:"
        '
        'Email1Label
        '
        Email1Label.AutoSize = True
        Email1Label.Location = New System.Drawing.Point(52, 329)
        Email1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Email1Label.Name = "Email1Label"
        Email1Label.Size = New System.Drawing.Size(57, 16)
        Email1Label.TabIndex = 38
        Email1Label.Text = "e-Mail 2:"
        '
        'Email2Label
        '
        Email2Label.AutoSize = True
        Email2Label.Location = New System.Drawing.Point(51, 361)
        Email2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Email2Label.Name = "Email2Label"
        Email2Label.Size = New System.Drawing.Size(57, 16)
        Email2Label.TabIndex = 39
        Email2Label.Text = "e-Mail 3:"
        '
        'IEescritorioLabel
        '
        IEescritorioLabel.AutoSize = True
        IEescritorioLabel.Location = New System.Drawing.Point(13, 86)
        IEescritorioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IEescritorioLabel.Name = "IEescritorioLabel"
        IEescritorioLabel.Size = New System.Drawing.Size(120, 16)
        IEescritorioLabel.TabIndex = 75
        IEescritorioLabel.Text = "Inscrição Estadual:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(115, 21)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(444, 22)
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
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(115, 86)
        Me.CPFMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(115, 22)
        Me.CPFMaskedTextBox.TabIndex = 4
        '
        'CRCTextBox
        '
        Me.CRCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CRC", True))
        Me.CRCTextBox.Location = New System.Drawing.Point(115, 182)
        Me.CRCTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CRCTextBox.Name = "CRCTextBox"
        Me.CRCTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CRCTextBox.TabIndex = 6
        '
        'ExpedicaoCRCMaskedTextBox
        '
        Me.ExpedicaoCRCMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "ExpedicaoCRC", True))
        Me.ExpedicaoCRCMaskedTextBox.Location = New System.Drawing.Point(376, 182)
        Me.ExpedicaoCRCMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExpedicaoCRCMaskedTextBox.Mask = "00/00/0000"
        Me.ExpedicaoCRCMaskedTextBox.Name = "ExpedicaoCRCMaskedTextBox"
        Me.ExpedicaoCRCMaskedTextBox.Size = New System.Drawing.Size(89, 22)
        Me.ExpedicaoCRCMaskedTextBox.TabIndex = 8
        Me.ExpedicaoCRCMaskedTextBox.ValidatingType = GetType(Date)
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(115, 118)
        Me.RGTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(132, 22)
        Me.RGTextBox.TabIndex = 10
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(119, 18)
        Me.RazaoSocialTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(572, 22)
        Me.RazaoSocialTextBox.TabIndex = 12
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(119, 50)
        Me.CNPJMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(144, 22)
        Me.CNPJMaskedTextBox.TabIndex = 14
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(581, 54)
        Me.TelefoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TelefoneMaskedTextBox.Mask = "(99) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(109, 22)
        Me.TelefoneMaskedTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(119, 293)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(385, 22)
        Me.EmailTextBox.TabIndex = 18
        '
        'CMCTextBox
        '
        Me.CMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CMC", True))
        Me.CMCTextBox.Location = New System.Drawing.Point(329, 50)
        Me.CMCTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMCTextBox.Name = "CMCTextBox"
        Me.CMCTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CMCTextBox.TabIndex = 20
        '
        'EndCEPMaskedTextBox
        '
        Me.EndCEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndCEP", True))
        Me.EndCEPMaskedTextBox.Location = New System.Drawing.Point(119, 126)
        Me.EndCEPMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndCEPMaskedTextBox.Mask = "00000-000"
        Me.EndCEPMaskedTextBox.Name = "EndCEPMaskedTextBox"
        Me.EndCEPMaskedTextBox.Size = New System.Drawing.Size(83, 22)
        Me.EndCEPMaskedTextBox.TabIndex = 22
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(119, 158)
        Me.EnderecoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(427, 22)
        Me.EnderecoTextBox.TabIndex = 24
        '
        'EndNumTextBox
        '
        Me.EndNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndNum", True))
        Me.EndNumTextBox.Location = New System.Drawing.Point(592, 158)
        Me.EndNumTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndNumTextBox.Name = "EndNumTextBox"
        Me.EndNumTextBox.Size = New System.Drawing.Size(99, 22)
        Me.EndNumTextBox.TabIndex = 26
        '
        'EndCompTextBox
        '
        Me.EndCompTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndComp", True))
        Me.EndCompTextBox.Location = New System.Drawing.Point(119, 190)
        Me.EndCompTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndCompTextBox.Name = "EndCompTextBox"
        Me.EndCompTextBox.Size = New System.Drawing.Size(164, 22)
        Me.EndCompTextBox.TabIndex = 28
        '
        'EndBairroTextBox
        '
        Me.EndBairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndBairro", True))
        Me.EndBairroTextBox.Location = New System.Drawing.Point(387, 190)
        Me.EndBairroTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndBairroTextBox.Name = "EndBairroTextBox"
        Me.EndBairroTextBox.Size = New System.Drawing.Size(304, 22)
        Me.EndBairroTextBox.TabIndex = 30
        '
        'EndCidadeTextBox
        '
        Me.EndCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndCidade", True))
        Me.EndCidadeTextBox.Location = New System.Drawing.Point(119, 222)
        Me.EndCidadeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndCidadeTextBox.Name = "EndCidadeTextBox"
        Me.EndCidadeTextBox.Size = New System.Drawing.Size(164, 22)
        Me.EndCidadeTextBox.TabIndex = 32
        '
        'EndEstadoTextBox
        '
        Me.EndEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndEstado", True))
        Me.EndEstadoTextBox.Location = New System.Drawing.Point(387, 225)
        Me.EndEstadoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndEstadoTextBox.Name = "EndEstadoTextBox"
        Me.EndEstadoTextBox.Size = New System.Drawing.Size(159, 22)
        Me.EndEstadoTextBox.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(211, 126)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 27)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Preencher"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.Contador1
        Me.PictureBox1.Location = New System.Drawing.Point(4, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ComboBoxBusca})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1001, 25)
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
        Me.ComboBoxBusca.Size = New System.Drawing.Size(332, 25)
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button16)
        Me.GroupBox5.Controls.Add(Me.Button18)
        Me.GroupBox5.Controls.Add(Me.Button17)
        Me.GroupBox5.Controls.Add(Me.Button19)
        Me.GroupBox5.Location = New System.Drawing.Point(896, 73)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(101, 197)
        Me.GroupBox5.TabIndex = 59
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MENU"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(5, 23)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(92, 27)
        Me.Button16.TabIndex = 46
        Me.Button16.Text = "Novo"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(5, 58)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(92, 28)
        Me.Button18.TabIndex = 48
        Me.Button18.Text = "Salvar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(5, 113)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(92, 28)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "Excluir"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(5, 149)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(92, 28)
        Me.Button19.TabIndex = 49
        Me.Button19.Text = "Fechar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'RGSiglaTextBox
        '
        Me.RGSiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RGSigla", True))
        Me.RGSiglaTextBox.Location = New System.Drawing.Point(256, 118)
        Me.RGSiglaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RGSiglaTextBox.Name = "RGSiglaTextBox"
        Me.RGSiglaTextBox.Size = New System.Drawing.Size(83, 22)
        Me.RGSiglaTextBox.TabIndex = 60
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.Transparent
        Me.Button44.BackgroundImage = CType(resources.GetObject("Button44.BackgroundImage"), System.Drawing.Image)
        Me.Button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button44.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(239, 85)
        Me.Button44.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(56, 27)
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
        Me.EstadoCivilComboBox.Location = New System.Drawing.Point(115, 214)
        Me.EstadoCivilComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EstadoCivilComboBox.Name = "EstadoCivilComboBox"
        Me.EstadoCivilComboBox.Size = New System.Drawing.Size(444, 24)
        Me.EstadoCivilComboBox.TabIndex = 65
        '
        'DataNascMaskedTextBox
        '
        Me.DataNascMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "DataNasc", True))
        Me.DataNascMaskedTextBox.Location = New System.Drawing.Point(460, 53)
        Me.DataNascMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataNascMaskedTextBox.Mask = "00/00/0000"
        Me.DataNascMaskedTextBox.Name = "DataNascMaskedTextBox"
        Me.DataNascMaskedTextBox.Size = New System.Drawing.Size(99, 22)
        Me.DataNascMaskedTextBox.TabIndex = 67
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GeneroComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Genero", True))
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.GeneroComboBox.Location = New System.Drawing.Point(115, 53)
        Me.GeneroComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(160, 24)
        Me.GeneroComboBox.TabIndex = 68
        '
        'ProfissaoTextBox
        '
        Me.ProfissaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Profissao", True))
        Me.ProfissaoTextBox.Location = New System.Drawing.Point(115, 150)
        Me.ProfissaoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProfissaoTextBox.Name = "ProfissaoTextBox"
        Me.ProfissaoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ProfissaoTextBox.TabIndex = 69
        '
        'TabControlContador
        '
        Me.TabControlContador.Controls.Add(Me.TabPage1)
        Me.TabControlContador.Controls.Add(Me.TabPage2)
        Me.TabControlContador.Controls.Add(Me.TabPage3)
        Me.TabControlContador.Location = New System.Drawing.Point(176, 48)
        Me.TabControlContador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlContador.Name = "TabControlContador"
        Me.TabControlContador.SelectedIndex = 0
        Me.TabControlContador.Size = New System.Drawing.Size(716, 434)
        Me.TabControlContador.TabIndex = 71
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(708, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contador"
        '
        'NomeMaeTextBox
        '
        Me.NomeMaeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "NomeMae", True))
        Me.NomeMaeTextBox.Location = New System.Drawing.Point(115, 279)
        Me.NomeMaeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomeMaeTextBox.Name = "NomeMaeTextBox"
        Me.NomeMaeTextBox.Size = New System.Drawing.Size(444, 22)
        Me.NomeMaeTextBox.TabIndex = 71
        '
        'NomePaiTextBox
        '
        Me.NomePaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "NomePai", True))
        Me.NomePaiTextBox.Location = New System.Drawing.Point(115, 247)
        Me.NomePaiTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomePaiTextBox.Name = "NomePaiTextBox"
        Me.NomePaiTextBox.Size = New System.Drawing.Size(444, 22)
        Me.NomePaiTextBox.TabIndex = 70
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(IEescritorioLabel)
        Me.TabPage2.Controls.Add(Me.IEescritorioTextBox)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(708, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Escritório"
        '
        'IEescritorioTextBox
        '
        Me.IEescritorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "IEescritorio", True))
        Me.IEescritorioTextBox.Location = New System.Drawing.Point(151, 82)
        Me.IEescritorioTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IEescritorioTextBox.Name = "IEescritorioTextBox"
        Me.IEescritorioTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IEescritorioTextBox.TabIndex = 76
        '
        'BtnCopiaCEP
        '
        Me.BtnCopiaCEP.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiaCEP.Location = New System.Drawing.Point(316, 126)
        Me.BtnCopiaCEP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCopiaCEP.Name = "BtnCopiaCEP"
        Me.BtnCopiaCEP.Size = New System.Drawing.Size(97, 27)
        Me.BtnCopiaCEP.TabIndex = 75
        Me.BtnCopiaCEP.Text = "Copiar CEP"
        Me.BtnCopiaCEP.UseVisualStyleBackColor = False
        '
        'Email2TextBox
        '
        Me.Email2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email2", True))
        Me.Email2TextBox.Location = New System.Drawing.Point(119, 357)
        Me.Email2TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Email2TextBox.Name = "Email2TextBox"
        Me.Email2TextBox.Size = New System.Drawing.Size(385, 22)
        Me.Email2TextBox.TabIndex = 40
        '
        'Email1TextBox
        '
        Me.Email1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email1", True))
        Me.Email1TextBox.Location = New System.Drawing.Point(119, 325)
        Me.Email1TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Email1TextBox.Name = "Email1TextBox"
        Me.Email1TextBox.Size = New System.Drawing.Size(385, 22)
        Me.Email1TextBox.TabIndex = 39
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AnotacoesRichTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(708, 405)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Anotações"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AnotacoesRichTextBox
        '
        Me.AnotacoesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Anotacoes", True))
        Me.AnotacoesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnotacoesRichTextBox.Location = New System.Drawing.Point(4, 4)
        Me.AnotacoesRichTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AnotacoesRichTextBox.Name = "AnotacoesRichTextBox"
        Me.AnotacoesRichTextBox.Size = New System.Drawing.Size(700, 397)
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
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ContadorGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 501)
        Me.Controls.Add(Me.TabControlContador)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents IEescritorioTextBox As TextBox
End Class
