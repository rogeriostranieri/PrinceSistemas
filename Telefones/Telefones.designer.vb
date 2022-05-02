<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Telefones
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
        Dim Telefone1Label As System.Windows.Forms.Label
        Dim TelefoneOutrosLabel As System.Windows.Forms.Label
        Dim ObsLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SiteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Telefones))
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.Telefone1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelefoneOutrosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SiteTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxBusca = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CboCidadeOrgao = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TelefonesTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.TelefonesTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        NomeLabel = New System.Windows.Forms.Label()
        Telefone1Label = New System.Windows.Forms.Label()
        TelefoneOutrosLabel = New System.Windows.Forms.Label()
        ObsLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SiteLabel = New System.Windows.Forms.Label()
        CType(Me.TelefonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Location = New System.Drawing.Point(34, 50)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'Telefone1Label
        '
        Telefone1Label.AutoSize = True
        Telefone1Label.BackColor = System.Drawing.Color.Transparent
        Telefone1Label.Location = New System.Drawing.Point(20, 73)
        Telefone1Label.Name = "Telefone1Label"
        Telefone1Label.Size = New System.Drawing.Size(52, 13)
        Telefone1Label.TabIndex = 3
        Telefone1Label.Text = "Telefone:"
        '
        'TelefoneOutrosLabel
        '
        TelefoneOutrosLabel.AutoSize = True
        TelefoneOutrosLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneOutrosLabel.Location = New System.Drawing.Point(13, 102)
        TelefoneOutrosLabel.Name = "TelefoneOutrosLabel"
        TelefoneOutrosLabel.Size = New System.Drawing.Size(57, 13)
        TelefoneOutrosLabel.TabIndex = 5
        TelefoneOutrosLabel.Text = "Telefones:"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.BackColor = System.Drawing.Color.Transparent
        ObsLabel.Location = New System.Drawing.Point(167, 76)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(29, 13)
        ObsLabel.TabIndex = 7
        ObsLabel.Text = "Obs:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(46, 25)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 9
        CEPLabel.Text = "CEP:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(13, 51)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(64, 13)
        EndereçoLabel.TabIndex = 11
        EndereçoLabel.Text = "Logradouro:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroLabel.Location = New System.Drawing.Point(344, 51)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 13
        NumeroLabel.Text = "Numero:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComplementoLabel.Location = New System.Drawing.Point(3, 77)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(74, 13)
        ComplementoLabel.TabIndex = 15
        ComplementoLabel.Text = "Complemento:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(260, 77)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 17
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(34, 103)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 19
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(192, 103)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 21
        EstadoLabel.Text = "Estado:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(34, 204)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "e-Mail:"
        '
        'SiteLabel
        '
        SiteLabel.AutoSize = True
        SiteLabel.BackColor = System.Drawing.Color.Transparent
        SiteLabel.Location = New System.Drawing.Point(21, 230)
        SiteLabel.Name = "SiteLabel"
        SiteLabel.Size = New System.Drawing.Size(51, 13)
        SiteLabel.TabIndex = 25
        SiteLabel.Text = "WebSite:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(78, 47)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(382, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'TelefonesBindingSource
        '
        Me.TelefonesBindingSource.DataMember = "Telefones"
        Me.TelefonesBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Telefone1", True))
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(78, 73)
        Me.Telefone1MaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Telefone1MaskedTextBox.TabIndex = 4
        '
        'TelefoneOutrosRichTextBox
        '
        Me.TelefoneOutrosRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "TelefoneOutros", True))
        Me.TelefoneOutrosRichTextBox.Location = New System.Drawing.Point(78, 99)
        Me.TelefoneOutrosRichTextBox.Name = "TelefoneOutrosRichTextBox"
        Me.TelefoneOutrosRichTextBox.Size = New System.Drawing.Size(83, 96)
        Me.TelefoneOutrosRichTextBox.TabIndex = 6
        Me.TelefoneOutrosRichTextBox.Text = ""
        '
        'ObsRichTextBox
        '
        Me.ObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Obs", True))
        Me.ObsRichTextBox.Location = New System.Drawing.Point(202, 76)
        Me.ObsRichTextBox.Name = "ObsRichTextBox"
        Me.ObsRichTextBox.Size = New System.Drawing.Size(258, 119)
        Me.ObsRichTextBox.TabIndex = 8
        Me.ObsRichTextBox.Text = ""
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(83, 22)
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(74, 20)
        Me.CEPMaskedTextBox.TabIndex = 10
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(83, 48)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(260, 20)
        Me.EndereçoTextBox.TabIndex = 12
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.Location = New System.Drawing.Point(391, 48)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(56, 20)
        Me.NumeroTextBox.TabIndex = 14
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(83, 74)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(171, 20)
        Me.ComplementoTextBox.TabIndex = 16
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.Location = New System.Drawing.Point(298, 74)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(149, 20)
        Me.BairroTextBox.TabIndex = 18
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.Location = New System.Drawing.Point(83, 100)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CidadeTextBox.TabIndex = 20
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.Location = New System.Drawing.Point(241, 100)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(78, 201)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(214, 20)
        Me.EmailTextBox.TabIndex = 24
        '
        'SiteTextBox
        '
        Me.SiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "site", True))
        Me.SiteTextBox.Location = New System.Drawing.Point(78, 227)
        Me.SiteTextBox.Name = "SiteTextBox"
        Me.SiteTextBox.Size = New System.Drawing.Size(214, 20)
        Me.SiteTextBox.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(163, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 19)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Buscar CEP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(CidadeLabel)
        Me.GroupBox1.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox1.Controls.Add(ComplementoLabel)
        Me.GroupBox1.Controls.Add(BairroLabel)
        Me.GroupBox1.Controls.Add(Me.BairroTextBox)
        Me.GroupBox1.Controls.Add(Me.ComplementoTextBox)
        Me.GroupBox1.Controls.Add(NumeroLabel)
        Me.GroupBox1.Controls.Add(Me.NumeroTextBox)
        Me.GroupBox1.Controls.Add(EndereçoLabel)
        Me.GroupBox1.Controls.Add(Me.EndereçoTextBox)
        Me.GroupBox1.Controls.Add(CEPLabel)
        Me.GroupBox1.Controls.Add(Me.CEPMaskedTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 143)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endereço"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button16)
        Me.GroupBox5.Controls.Add(Me.Button18)
        Me.GroupBox5.Controls.Add(Me.Button17)
        Me.GroupBox5.Controls.Add(Me.Button19)
        Me.GroupBox5.Location = New System.Drawing.Point(504, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(94, 160)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MENU"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(13, 19)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(69, 22)
        Me.Button16.TabIndex = 46
        Me.Button16.Text = "Novo"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(13, 47)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(69, 23)
        Me.Button18.TabIndex = 48
        Me.Button18.Text = "Salvar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(13, 92)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(69, 23)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "Excluir"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(13, 121)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(69, 23)
        Me.Button19.TabIndex = 49
        Me.Button19.Text = "Fechar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ComboBoxBusca, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CboCidadeOrgao, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(598, 25)
        Me.ToolStrip1.TabIndex = 59
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
        Me.ComboBoxBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBusca.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ComboBoxBusca.Name = "ComboBoxBusca"
        Me.ComboBoxBusca.Size = New System.Drawing.Size(260, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel2.Text = "Filtro:"
        '
        'CboCidadeOrgao
        '
        Me.CboCidadeOrgao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CboCidadeOrgao.Name = "CboCidadeOrgao"
        Me.CboCidadeOrgao.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel3.Text = "Digite Aqui"
        '
        'TelefonesTableAdapter
        '
        Me.TelefonesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TelefonesTableAdapter = Me.TelefonesTableAdapter
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Telefones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 427)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(SiteLabel)
        Me.Controls.Add(Me.SiteTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(ObsLabel)
        Me.Controls.Add(Me.ObsRichTextBox)
        Me.Controls.Add(TelefoneOutrosLabel)
        Me.Controls.Add(Me.TelefoneOutrosRichTextBox)
        Me.Controls.Add(Telefone1Label)
        Me.Controls.Add(Me.Telefone1MaskedTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Telefones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telefones dos Órgãos Governamentais"
        CType(Me.TelefonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents TelefonesBindingSource As BindingSource
    Friend WithEvents TelefonesTableAdapter As PrinceDBDataSetTableAdapters.TelefonesTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Telefone1MaskedTextBox As MaskedTextBox
    Friend WithEvents TelefoneOutrosRichTextBox As RichTextBox
    Friend WithEvents ObsRichTextBox As RichTextBox
    Friend WithEvents CEPMaskedTextBox As MaskedTextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents SiteTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBoxBusca As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents CboCidadeOrgao As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
End Class
