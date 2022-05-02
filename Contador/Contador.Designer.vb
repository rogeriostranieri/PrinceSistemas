<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contador))
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
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
        Me.ContadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.ContadorTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ContadorTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.RGSiglaTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ContadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Location = New System.Drawing.Point(136, 67)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.BackColor = System.Drawing.Color.Transparent
        CPFLabel.Location = New System.Drawing.Point(144, 93)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 3
        CPFLabel.Text = "CPF:"
        '
        'CRCLabel
        '
        CRCLabel.AutoSize = True
        CRCLabel.BackColor = System.Drawing.Color.Transparent
        CRCLabel.Location = New System.Drawing.Point(142, 145)
        CRCLabel.Name = "CRCLabel"
        CRCLabel.Size = New System.Drawing.Size(32, 13)
        CRCLabel.TabIndex = 5
        CRCLabel.Text = "CRC:"
        '
        'ExpedicaoCRCLabel
        '
        ExpedicaoCRCLabel.AutoSize = True
        ExpedicaoCRCLabel.BackColor = System.Drawing.Color.Transparent
        ExpedicaoCRCLabel.Location = New System.Drawing.Point(285, 145)
        ExpedicaoCRCLabel.Name = "ExpedicaoCRCLabel"
        ExpedicaoCRCLabel.Size = New System.Drawing.Size(85, 13)
        ExpedicaoCRCLabel.TabIndex = 7
        ExpedicaoCRCLabel.Text = "Expedição CRC:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.BackColor = System.Drawing.Color.Transparent
        RGLabel.Location = New System.Drawing.Point(148, 119)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(26, 13)
        RGLabel.TabIndex = 9
        RGLabel.Text = "RG:"
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.BackColor = System.Drawing.Color.Transparent
        RazaoSocialLabel.Location = New System.Drawing.Point(5, 212)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazaoSocialLabel.TabIndex = 11
        RazaoSocialLabel.Text = "Razão Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.BackColor = System.Drawing.Color.Transparent
        CNPJLabel.Location = New System.Drawing.Point(41, 238)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(37, 13)
        CNPJLabel.TabIndex = 13
        CNPJLabel.Text = "CNPJ:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneLabel.Location = New System.Drawing.Point(373, 241)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 15
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(44, 264)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "e-Mail:"
        '
        'CMCLabel
        '
        CMCLabel.AutoSize = True
        CMCLabel.BackColor = System.Drawing.Color.Transparent
        CMCLabel.Location = New System.Drawing.Point(203, 238)
        CMCLabel.Name = "CMCLabel"
        CMCLabel.Size = New System.Drawing.Size(33, 13)
        CMCLabel.TabIndex = 19
        CMCLabel.Text = "CMC:"
        '
        'EndCEPLabel
        '
        EndCEPLabel.AutoSize = True
        EndCEPLabel.BackColor = System.Drawing.Color.Transparent
        EndCEPLabel.Location = New System.Drawing.Point(47, 325)
        EndCEPLabel.Name = "EndCEPLabel"
        EndCEPLabel.Size = New System.Drawing.Size(31, 13)
        EndCEPLabel.TabIndex = 21
        EndCEPLabel.Text = "CEP:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.BackColor = System.Drawing.Color.Transparent
        EnderecoLabel.Location = New System.Drawing.Point(22, 351)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 23
        EnderecoLabel.Text = "Endereço:"
        '
        'EndNumLabel
        '
        EndNumLabel.AutoSize = True
        EndNumLabel.Location = New System.Drawing.Point(411, 351)
        EndNumLabel.Name = "EndNumLabel"
        EndNumLabel.Size = New System.Drawing.Size(22, 13)
        EndNumLabel.TabIndex = 25
        EndNumLabel.Text = "N°:"
        '
        'EndCompLabel
        '
        EndCompLabel.AutoSize = True
        EndCompLabel.BackColor = System.Drawing.Color.Transparent
        EndCompLabel.Location = New System.Drawing.Point(1, 377)
        EndCompLabel.Name = "EndCompLabel"
        EndCompLabel.Size = New System.Drawing.Size(77, 13)
        EndCompLabel.TabIndex = 27
        EndCompLabel.Text = " Complemento:"
        '
        'EndBairroLabel
        '
        EndBairroLabel.AutoSize = True
        EndBairroLabel.BackColor = System.Drawing.Color.Transparent
        EndBairroLabel.Location = New System.Drawing.Point(242, 377)
        EndBairroLabel.Name = "EndBairroLabel"
        EndBairroLabel.Size = New System.Drawing.Size(37, 13)
        EndBairroLabel.TabIndex = 29
        EndBairroLabel.Text = "Bairro:"
        '
        'EndCidadeLabel
        '
        EndCidadeLabel.AutoSize = True
        EndCidadeLabel.BackColor = System.Drawing.Color.Transparent
        EndCidadeLabel.Location = New System.Drawing.Point(35, 403)
        EndCidadeLabel.Name = "EndCidadeLabel"
        EndCidadeLabel.Size = New System.Drawing.Size(43, 13)
        EndCidadeLabel.TabIndex = 31
        EndCidadeLabel.Text = "Cidade:"
        '
        'EndEstadoLabel
        '
        EndEstadoLabel.AutoSize = True
        EndEstadoLabel.BackColor = System.Drawing.Color.Transparent
        EndEstadoLabel.Location = New System.Drawing.Point(236, 406)
        EndEstadoLabel.Name = "EndEstadoLabel"
        EndEstadoLabel.Size = New System.Drawing.Size(43, 13)
        EndEstadoLabel.TabIndex = 33
        EndEstadoLabel.Text = "Estado:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(180, 64)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(334, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(180, 90)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(87, 20)
        Me.CPFMaskedTextBox.TabIndex = 4
        '
        'CRCTextBox
        '
        Me.CRCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CRC", True))
        Me.CRCTextBox.Location = New System.Drawing.Point(180, 142)
        Me.CRCTextBox.Name = "CRCTextBox"
        Me.CRCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CRCTextBox.TabIndex = 6
        '
        'ExpedicaoCRCMaskedTextBox
        '
        Me.ExpedicaoCRCMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "ExpedicaoCRC", True))
        Me.ExpedicaoCRCMaskedTextBox.Location = New System.Drawing.Point(376, 142)
        Me.ExpedicaoCRCMaskedTextBox.Mask = "00/00/0000"
        Me.ExpedicaoCRCMaskedTextBox.Name = "ExpedicaoCRCMaskedTextBox"
        Me.ExpedicaoCRCMaskedTextBox.Size = New System.Drawing.Size(68, 20)
        Me.ExpedicaoCRCMaskedTextBox.TabIndex = 8
        Me.ExpedicaoCRCMaskedTextBox.ValidatingType = GetType(Date)
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(180, 116)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RGTextBox.TabIndex = 10
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(84, 209)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(430, 20)
        Me.RazaoSocialTextBox.TabIndex = 12
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(84, 235)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(109, 20)
        Me.CNPJMaskedTextBox.TabIndex = 14
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(431, 238)
        Me.TelefoneMaskedTextBox.Mask = "(99) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(83, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(84, 261)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(290, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'CMCTextBox
        '
        Me.CMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "CMC", True))
        Me.CMCTextBox.Location = New System.Drawing.Point(242, 235)
        Me.CMCTextBox.Name = "CMCTextBox"
        Me.CMCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CMCTextBox.TabIndex = 20
        '
        'EndCEPMaskedTextBox
        '
        Me.EndCEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndCEP", True))
        Me.EndCEPMaskedTextBox.Location = New System.Drawing.Point(84, 322)
        Me.EndCEPMaskedTextBox.Mask = "00000-000"
        Me.EndCEPMaskedTextBox.Name = "EndCEPMaskedTextBox"
        Me.EndCEPMaskedTextBox.Size = New System.Drawing.Size(63, 20)
        Me.EndCEPMaskedTextBox.TabIndex = 22
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(84, 348)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(321, 20)
        Me.EnderecoTextBox.TabIndex = 24
        '
        'EndNumTextBox
        '
        Me.EndNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndNum", True))
        Me.EndNumTextBox.Location = New System.Drawing.Point(439, 348)
        Me.EndNumTextBox.Name = "EndNumTextBox"
        Me.EndNumTextBox.Size = New System.Drawing.Size(75, 20)
        Me.EndNumTextBox.TabIndex = 26
        '
        'EndCompTextBox
        '
        Me.EndCompTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndComp", True))
        Me.EndCompTextBox.Location = New System.Drawing.Point(84, 374)
        Me.EndCompTextBox.Name = "EndCompTextBox"
        Me.EndCompTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EndCompTextBox.TabIndex = 28
        '
        'EndBairroTextBox
        '
        Me.EndBairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndBairro", True))
        Me.EndBairroTextBox.Location = New System.Drawing.Point(285, 374)
        Me.EndBairroTextBox.Name = "EndBairroTextBox"
        Me.EndBairroTextBox.Size = New System.Drawing.Size(229, 20)
        Me.EndBairroTextBox.TabIndex = 30
        '
        'EndCidadeTextBox
        '
        Me.EndCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndCidade", True))
        Me.EndCidadeTextBox.Location = New System.Drawing.Point(84, 400)
        Me.EndCidadeTextBox.Name = "EndCidadeTextBox"
        Me.EndCidadeTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EndCidadeTextBox.TabIndex = 32
        '
        'EndEstadoTextBox
        '
        Me.EndEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "EndEstado", True))
        Me.EndEstadoTextBox.Location = New System.Drawing.Point(285, 403)
        Me.EndEstadoTextBox.Name = "EndEstadoTextBox"
        Me.EndEstadoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.EndEstadoTextBox.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(153, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 19)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Buscar CEP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.Contador1
        Me.PictureBox1.Location = New System.Drawing.Point(4, 28)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
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
        Me.GroupBox5.Location = New System.Drawing.Point(530, 28)
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
        'ContadorTableAdapter
        '
        Me.ContadorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Me.ContadorTableAdapter
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RGSiglaTextBox
        '
        Me.RGSiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContadorBindingSource, "RGSigla", True))
        Me.RGSiglaTextBox.Location = New System.Drawing.Point(286, 116)
        Me.RGSiglaTextBox.Name = "RGSiglaTextBox"
        Me.RGSiglaTextBox.Size = New System.Drawing.Size(40, 20)
        Me.RGSiglaTextBox.TabIndex = 60
        '
        'Contador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 443)
        Me.Controls.Add(Me.RGSiglaTextBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(EndEstadoLabel)
        Me.Controls.Add(Me.EndEstadoTextBox)
        Me.Controls.Add(EndCidadeLabel)
        Me.Controls.Add(Me.EndCidadeTextBox)
        Me.Controls.Add(EndBairroLabel)
        Me.Controls.Add(Me.EndBairroTextBox)
        Me.Controls.Add(EndCompLabel)
        Me.Controls.Add(Me.EndCompTextBox)
        Me.Controls.Add(EndNumLabel)
        Me.Controls.Add(Me.EndNumTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(EndCEPLabel)
        Me.Controls.Add(Me.EndCEPMaskedTextBox)
        Me.Controls.Add(CMCLabel)
        Me.Controls.Add(Me.CMCTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(CNPJLabel)
        Me.Controls.Add(Me.CNPJMaskedTextBox)
        Me.Controls.Add(RazaoSocialLabel)
        Me.Controls.Add(Me.RazaoSocialTextBox)
        Me.Controls.Add(RGLabel)
        Me.Controls.Add(Me.RGTextBox)
        Me.Controls.Add(ExpedicaoCRCLabel)
        Me.Controls.Add(Me.ExpedicaoCRCMaskedTextBox)
        Me.Controls.Add(CRCLabel)
        Me.Controls.Add(Me.CRCTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Contador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contadores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.ContadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
