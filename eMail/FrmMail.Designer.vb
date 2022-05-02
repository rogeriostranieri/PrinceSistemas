<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMail
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
        Dim EMailLabel As System.Windows.Forms.Label
        Dim SenhaEmailLabel As System.Windows.Forms.Label
        Dim SmtpClientLabel As System.Windows.Forms.Label
        Dim SmtpPortLabel As System.Windows.Forms.Label
        Dim ClientSslLabel As System.Windows.Forms.Label
        Dim ParaGeralLabel As System.Windows.Forms.Label
        Dim HabilitaSslLabel As System.Windows.Forms.Label
        Dim CredencialLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMail))
        Me.LabelDe = New System.Windows.Forms.Label()
        Me.LabelPara = New System.Windows.Forms.Label()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.RichTextBoxMensagem = New System.Windows.Forms.RichTextBox()
        Me.TextBoxAssunto = New System.Windows.Forms.TextBox()
        Me.TabControle = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblAnexo = New System.Windows.Forms.Label()
        Me.ButtonAnexar = New System.Windows.Forms.Button()
        Me.ButtonGeral = New System.Windows.Forms.Button()
        Me.ButtonContatos = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.TextBoxPara = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxEmailSelecionar = New System.Windows.Forms.ComboBox()
        Me.EMailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonExcluirSaida = New System.Windows.Forms.Button()
        Me.EMailCaixaDeSaidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailCaixaDeSaidaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CredencialComboBox = New System.Windows.Forms.ComboBox()
        Me.HabilitaSslComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ParaGeralRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ButtonExcluirConfig = New System.Windows.Forms.Button()
        Me.ButtonSalvarConfig = New System.Windows.Forms.Button()
        Me.ButtonNovoConfig = New System.Windows.Forms.Button()
        Me.ClientSslComboBox = New System.Windows.Forms.ComboBox()
        Me.SmtpPortTextBox = New System.Windows.Forms.TextBox()
        Me.SmtpClientTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaEmailTextBox = New System.Windows.Forms.TextBox()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.EMailTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.eMailTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EMailCaixaDeSaidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMailCaixaDeSaidaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.eMailCaixaDeSaidaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        EMailLabel = New System.Windows.Forms.Label()
        SenhaEmailLabel = New System.Windows.Forms.Label()
        SmtpClientLabel = New System.Windows.Forms.Label()
        SmtpPortLabel = New System.Windows.Forms.Label()
        ClientSslLabel = New System.Windows.Forms.Label()
        ParaGeralLabel = New System.Windows.Forms.Label()
        HabilitaSslLabel = New System.Windows.Forms.Label()
        CredencialLabel = New System.Windows.Forms.Label()
        Me.TabControle.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.EMailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.EMailCaixaDeSaidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMailCaixaDeSaidaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(15, 43)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(124, 13)
        EMailLabel.TabIndex = 0
        EMailLabel.Text = "e-Mail/Usuário de saída:"
        '
        'SenhaEmailLabel
        '
        SenhaEmailLabel.AutoSize = True
        SenhaEmailLabel.Location = New System.Drawing.Point(25, 69)
        SenhaEmailLabel.Name = "SenhaEmailLabel"
        SenhaEmailLabel.Size = New System.Drawing.Size(114, 13)
        SenhaEmailLabel.TabIndex = 2
        SenhaEmailLabel.Text = "Senha Email de saída:"
        '
        'SmtpClientLabel
        '
        SmtpClientLabel.AutoSize = True
        SmtpClientLabel.Location = New System.Drawing.Point(8, 95)
        SmtpClientLabel.Name = "SmtpClientLabel"
        SmtpClientLabel.Size = New System.Drawing.Size(131, 13)
        SmtpClientLabel.TabIndex = 4
        SmtpClientLabel.Text = "Servidor de saída (e-Mail):"
        '
        'SmtpPortLabel
        '
        SmtpPortLabel.AutoSize = True
        SmtpPortLabel.Location = New System.Drawing.Point(83, 121)
        SmtpPortLabel.Name = "SmtpPortLabel"
        SmtpPortLabel.Size = New System.Drawing.Size(56, 13)
        SmtpPortLabel.TabIndex = 6
        SmtpPortLabel.Text = "Smtp Port:"
        '
        'ClientSslLabel
        '
        ClientSslLabel.AutoSize = True
        ClientSslLabel.Location = New System.Drawing.Point(54, 201)
        ClientSslLabel.Name = "ClientSslLabel"
        ClientSslLabel.Size = New System.Drawing.Size(85, 13)
        ClientSslLabel.TabIndex = 8
        ClientSslLabel.Text = "Segurança SSL:"
        ClientSslLabel.Visible = False
        '
        'ParaGeralLabel
        '
        ParaGeralLabel.AutoSize = True
        ParaGeralLabel.Location = New System.Drawing.Point(6, 235)
        ParaGeralLabel.Name = "ParaGeralLabel"
        ParaGeralLabel.Size = New System.Drawing.Size(135, 13)
        ParaGeralLabel.TabIndex = 50
        ParaGeralLabel.Text = "E-mail padrão para destino:"
        '
        'HabilitaSslLabel
        '
        HabilitaSslLabel.AutoSize = True
        HabilitaSslLabel.Location = New System.Drawing.Point(71, 147)
        HabilitaSslLabel.Name = "HabilitaSslLabel"
        HabilitaSslLabel.Size = New System.Drawing.Size(68, 13)
        HabilitaSslLabel.TabIndex = 52
        HabilitaSslLabel.Text = "Habilita SSL:"
        '
        'CredencialLabel
        '
        CredencialLabel.AutoSize = True
        CredencialLabel.Location = New System.Drawing.Point(79, 174)
        CredencialLabel.Name = "CredencialLabel"
        CredencialLabel.Size = New System.Drawing.Size(60, 13)
        CredencialLabel.TabIndex = 53
        CredencialLabel.Text = "Credencial:"
        '
        'LabelDe
        '
        Me.LabelDe.AutoSize = True
        Me.LabelDe.Location = New System.Drawing.Point(14, 28)
        Me.LabelDe.Name = "LabelDe"
        Me.LabelDe.Size = New System.Drawing.Size(108, 13)
        Me.LabelDe.TabIndex = 1
        Me.LabelDe.Text = "E-mail que vai enviar:"
        '
        'LabelPara
        '
        Me.LabelPara.AutoSize = True
        Me.LabelPara.Location = New System.Drawing.Point(90, 57)
        Me.LabelPara.Name = "LabelPara"
        Me.LabelPara.Size = New System.Drawing.Size(32, 13)
        Me.LabelPara.TabIndex = 3
        Me.LabelPara.Text = "Para:"
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.ForeColor = System.Drawing.Color.Green
        Me.ButtonEnviar.Location = New System.Drawing.Point(459, 318)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEnviar.TabIndex = 4
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'RichTextBoxMensagem
        '
        Me.RichTextBoxMensagem.Location = New System.Drawing.Point(17, 151)
        Me.RichTextBoxMensagem.Name = "RichTextBoxMensagem"
        Me.RichTextBoxMensagem.Size = New System.Drawing.Size(421, 140)
        Me.RichTextBoxMensagem.TabIndex = 5
        Me.RichTextBoxMensagem.Text = "Seu texto ...."
        '
        'TextBoxAssunto
        '
        Me.TextBoxAssunto.Location = New System.Drawing.Point(17, 125)
        Me.TextBoxAssunto.Name = "TextBoxAssunto"
        Me.TextBoxAssunto.Size = New System.Drawing.Size(421, 20)
        Me.TextBoxAssunto.TabIndex = 6
        Me.TextBoxAssunto.Text = "Digite aqui o assunto..."
        '
        'TabControle
        '
        Me.TabControle.Controls.Add(Me.TabPage1)
        Me.TabControle.Controls.Add(Me.TabPage2)
        Me.TabControle.Controls.Add(Me.TabPage3)
        Me.TabControle.Location = New System.Drawing.Point(12, 48)
        Me.TabControle.Name = "TabControle"
        Me.TabControle.SelectedIndex = 0
        Me.TabControle.Size = New System.Drawing.Size(548, 373)
        Me.TabControle.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblAnexo)
        Me.TabPage1.Controls.Add(Me.ButtonAnexar)
        Me.TabPage1.Controls.Add(Me.ButtonGeral)
        Me.TabPage1.Controls.Add(Me.ButtonContatos)
        Me.TabPage1.Controls.Add(Me.ButtonLimpar)
        Me.TabPage1.Controls.Add(Me.TextBoxPara)
        Me.TabPage1.Controls.Add(Me.ComboBoxEmailSelecionar)
        Me.TabPage1.Controls.Add(Me.RichTextBoxMensagem)
        Me.TabPage1.Controls.Add(Me.TextBoxAssunto)
        Me.TabPage1.Controls.Add(Me.LabelDe)
        Me.TabPage1.Controls.Add(Me.ButtonEnviar)
        Me.TabPage1.Controls.Add(Me.LabelPara)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(540, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Enviar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblAnexo
        '
        Me.LblAnexo.AutoSize = True
        Me.LblAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnexo.Location = New System.Drawing.Point(85, 302)
        Me.LblAnexo.Name = "LblAnexo"
        Me.LblAnexo.Size = New System.Drawing.Size(54, 16)
        Me.LblAnexo.TabIndex = 52
        Me.LblAnexo.Text = "Anexo..."
        '
        'ButtonAnexar
        '
        Me.ButtonAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAnexar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnexar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAnexar.Location = New System.Drawing.Point(17, 297)
        Me.ButtonAnexar.Name = "ButtonAnexar"
        Me.ButtonAnexar.Size = New System.Drawing.Size(62, 23)
        Me.ButtonAnexar.TabIndex = 51
        Me.ButtonAnexar.Text = "Anexar"
        Me.ButtonAnexar.UseVisualStyleBackColor = True
        '
        'ButtonGeral
        '
        Me.ButtonGeral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGeral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonGeral.Location = New System.Drawing.Point(67, 87)
        Me.ButtonGeral.Name = "ButtonGeral"
        Me.ButtonGeral.Size = New System.Drawing.Size(55, 23)
        Me.ButtonGeral.TabIndex = 49
        Me.ButtonGeral.Text = "Geral"
        Me.ButtonGeral.UseVisualStyleBackColor = True
        '
        'ButtonContatos
        '
        Me.ButtonContatos.BackgroundImage = CType(resources.GetObject("ButtonContatos.BackgroundImage"), System.Drawing.Image)
        Me.ButtonContatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonContatos.ForeColor = System.Drawing.Color.Green
        Me.ButtonContatos.Location = New System.Drawing.Point(465, 6)
        Me.ButtonContatos.Name = "ButtonContatos"
        Me.ButtonContatos.Size = New System.Drawing.Size(69, 22)
        Me.ButtonContatos.TabIndex = 48
        Me.ButtonContatos.Text = "Contatos"
        Me.ButtonContatos.UseVisualStyleBackColor = True
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonLimpar.Location = New System.Drawing.Point(459, 289)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpar.TabIndex = 9
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'TextBoxPara
        '
        Me.TextBoxPara.Location = New System.Drawing.Point(128, 54)
        Me.TextBoxPara.Name = "TextBoxPara"
        Me.TextBoxPara.Size = New System.Drawing.Size(310, 56)
        Me.TextBoxPara.TabIndex = 8
        Me.TextBoxPara.Text = ""
        '
        'ComboBoxEmailSelecionar
        '
        Me.ComboBoxEmailSelecionar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxEmailSelecionar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEmailSelecionar.DataSource = Me.EMailBindingSource
        Me.ComboBoxEmailSelecionar.DisplayMember = "eMail"
        Me.ComboBoxEmailSelecionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEmailSelecionar.FormattingEnabled = True
        Me.ComboBoxEmailSelecionar.Location = New System.Drawing.Point(126, 23)
        Me.ComboBoxEmailSelecionar.Name = "ComboBoxEmailSelecionar"
        Me.ComboBoxEmailSelecionar.Size = New System.Drawing.Size(195, 21)
        Me.ComboBoxEmailSelecionar.TabIndex = 7
        Me.ComboBoxEmailSelecionar.ValueMember = "eMail"
        '
        'EMailBindingSource
        '
        Me.EMailBindingSource.DataMember = "eMail"
        Me.EMailBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ButtonExcluirSaida)
        Me.TabPage2.Controls.Add(Me.EMailCaixaDeSaidaDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(540, 347)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caixa de Saída"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonExcluirSaida
        '
        Me.ButtonExcluirSaida.BackgroundImage = CType(resources.GetObject("ButtonExcluirSaida.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExcluirSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExcluirSaida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonExcluirSaida.Location = New System.Drawing.Point(465, 318)
        Me.ButtonExcluirSaida.Name = "ButtonExcluirSaida"
        Me.ButtonExcluirSaida.Size = New System.Drawing.Size(69, 23)
        Me.ButtonExcluirSaida.TabIndex = 48
        Me.ButtonExcluirSaida.Text = "Excluir"
        Me.ButtonExcluirSaida.UseVisualStyleBackColor = True
        '
        'EMailCaixaDeSaidaDataGridView
        '
        Me.EMailCaixaDeSaidaDataGridView.AllowUserToAddRows = False
        Me.EMailCaixaDeSaidaDataGridView.AutoGenerateColumns = False
        Me.EMailCaixaDeSaidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMailCaixaDeSaidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EMailCaixaDeSaidaDataGridView.DataSource = Me.EMailCaixaDeSaidaBindingSource1
        Me.EMailCaixaDeSaidaDataGridView.Location = New System.Drawing.Point(12, 25)
        Me.EMailCaixaDeSaidaDataGridView.MultiSelect = False
        Me.EMailCaixaDeSaidaDataGridView.Name = "EMailCaixaDeSaidaDataGridView"
        Me.EMailCaixaDeSaidaDataGridView.ReadOnly = True
        Me.EMailCaixaDeSaidaDataGridView.Size = New System.Drawing.Size(522, 287)
        Me.EMailCaixaDeSaidaDataGridView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_eMailCaixaDeSaida"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "eMailPrincipal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "eMail"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "eMailDestino"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Assunto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Assunto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CaixaDeSaidaTexto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Texto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DataEnviado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data de Envio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'EMailCaixaDeSaidaBindingSource1
        '
        Me.EMailCaixaDeSaidaBindingSource1.DataMember = "eMail_eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource1.DataSource = Me.EMailBindingSource
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(CredencialLabel)
        Me.TabPage3.Controls.Add(Me.CredencialComboBox)
        Me.TabPage3.Controls.Add(HabilitaSslLabel)
        Me.TabPage3.Controls.Add(Me.HabilitaSslComboBox)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(ParaGeralLabel)
        Me.TabPage3.Controls.Add(Me.ParaGeralRichTextBox)
        Me.TabPage3.Controls.Add(Me.ButtonExcluirConfig)
        Me.TabPage3.Controls.Add(Me.ButtonSalvarConfig)
        Me.TabPage3.Controls.Add(Me.ButtonNovoConfig)
        Me.TabPage3.Controls.Add(ClientSslLabel)
        Me.TabPage3.Controls.Add(Me.ClientSslComboBox)
        Me.TabPage3.Controls.Add(SmtpPortLabel)
        Me.TabPage3.Controls.Add(Me.SmtpPortTextBox)
        Me.TabPage3.Controls.Add(SmtpClientLabel)
        Me.TabPage3.Controls.Add(Me.SmtpClientTextBox)
        Me.TabPage3.Controls.Add(SenhaEmailLabel)
        Me.TabPage3.Controls.Add(Me.SenhaEmailTextBox)
        Me.TabPage3.Controls.Add(EMailLabel)
        Me.TabPage3.Controls.Add(Me.EMailTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(540, 347)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Configurações"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "* True"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "* False"
        '
        'CredencialComboBox
        '
        Me.CredencialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "Credencial", True))
        Me.CredencialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CredencialComboBox.FormattingEnabled = True
        Me.CredencialComboBox.Items.AddRange(New Object() {"", "False", "True"})
        Me.CredencialComboBox.Location = New System.Drawing.Point(145, 171)
        Me.CredencialComboBox.Name = "CredencialComboBox"
        Me.CredencialComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CredencialComboBox.TabIndex = 54
        '
        'HabilitaSslComboBox
        '
        Me.HabilitaSslComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "HabilitaSsl", True))
        Me.HabilitaSslComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HabilitaSslComboBox.FormattingEnabled = True
        Me.HabilitaSslComboBox.Items.AddRange(New Object() {"", "False", "True"})
        Me.HabilitaSslComboBox.Location = New System.Drawing.Point(145, 144)
        Me.HabilitaSslComboBox.Name = "HabilitaSslComboBox"
        Me.HabilitaSslComboBox.Size = New System.Drawing.Size(100, 21)
        Me.HabilitaSslComboBox.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Utilizar "" , "" (vírgula) para separar cada e-mail, e sem espaõs, tudo junto!"
        '
        'ParaGeralRichTextBox
        '
        Me.ParaGeralRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "ParaGeral", True))
        Me.ParaGeralRichTextBox.Location = New System.Drawing.Point(145, 232)
        Me.ParaGeralRichTextBox.Name = "ParaGeralRichTextBox"
        Me.ParaGeralRichTextBox.Size = New System.Drawing.Size(367, 91)
        Me.ParaGeralRichTextBox.TabIndex = 51
        Me.ParaGeralRichTextBox.Text = ""
        '
        'ButtonExcluirConfig
        '
        Me.ButtonExcluirConfig.BackgroundImage = CType(resources.GetObject("ButtonExcluirConfig.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExcluirConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExcluirConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonExcluirConfig.Location = New System.Drawing.Point(443, 95)
        Me.ButtonExcluirConfig.Name = "ButtonExcluirConfig"
        Me.ButtonExcluirConfig.Size = New System.Drawing.Size(69, 23)
        Me.ButtonExcluirConfig.TabIndex = 50
        Me.ButtonExcluirConfig.Text = "Excluir"
        Me.ButtonExcluirConfig.UseVisualStyleBackColor = True
        '
        'ButtonSalvarConfig
        '
        Me.ButtonSalvarConfig.BackgroundImage = CType(resources.GetObject("ButtonSalvarConfig.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSalvarConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalvarConfig.Location = New System.Drawing.Point(443, 66)
        Me.ButtonSalvarConfig.Name = "ButtonSalvarConfig"
        Me.ButtonSalvarConfig.Size = New System.Drawing.Size(69, 23)
        Me.ButtonSalvarConfig.TabIndex = 49
        Me.ButtonSalvarConfig.Text = "Salvar"
        Me.ButtonSalvarConfig.UseVisualStyleBackColor = True
        '
        'ButtonNovoConfig
        '
        Me.ButtonNovoConfig.BackgroundImage = CType(resources.GetObject("ButtonNovoConfig.BackgroundImage"), System.Drawing.Image)
        Me.ButtonNovoConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNovoConfig.ForeColor = System.Drawing.Color.Green
        Me.ButtonNovoConfig.Location = New System.Drawing.Point(443, 38)
        Me.ButtonNovoConfig.Name = "ButtonNovoConfig"
        Me.ButtonNovoConfig.Size = New System.Drawing.Size(69, 22)
        Me.ButtonNovoConfig.TabIndex = 47
        Me.ButtonNovoConfig.Text = "Novo"
        Me.ButtonNovoConfig.UseVisualStyleBackColor = True
        '
        'ClientSslComboBox
        '
        Me.ClientSslComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "clientSsl", True))
        Me.ClientSslComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientSslComboBox.FormattingEnabled = True
        Me.ClientSslComboBox.Items.AddRange(New Object() {"", "False", "True"})
        Me.ClientSslComboBox.Location = New System.Drawing.Point(145, 198)
        Me.ClientSslComboBox.Name = "ClientSslComboBox"
        Me.ClientSslComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ClientSslComboBox.Sorted = True
        Me.ClientSslComboBox.TabIndex = 9
        Me.ClientSslComboBox.Visible = False
        '
        'SmtpPortTextBox
        '
        Me.SmtpPortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SmtpPort", True))
        Me.SmtpPortTextBox.Location = New System.Drawing.Point(145, 118)
        Me.SmtpPortTextBox.Name = "SmtpPortTextBox"
        Me.SmtpPortTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SmtpPortTextBox.TabIndex = 7
        '
        'SmtpClientTextBox
        '
        Me.SmtpClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SmtpClient", True))
        Me.SmtpClientTextBox.Location = New System.Drawing.Point(145, 92)
        Me.SmtpClientTextBox.Name = "SmtpClientTextBox"
        Me.SmtpClientTextBox.Size = New System.Drawing.Size(226, 20)
        Me.SmtpClientTextBox.TabIndex = 5
        '
        'SenhaEmailTextBox
        '
        Me.SenhaEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SenhaEmail", True))
        Me.SenhaEmailTextBox.Location = New System.Drawing.Point(145, 66)
        Me.SenhaEmailTextBox.Name = "SenhaEmailTextBox"
        Me.SenhaEmailTextBox.Size = New System.Drawing.Size(226, 20)
        Me.SenhaEmailTextBox.TabIndex = 3
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "eMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(145, 40)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(226, 20)
        Me.EMailTextBox.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 433)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(567, 23)
        Me.ProgressBar1.TabIndex = 53
        '
        'EMailTableAdapter
        '
        Me.EMailTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.eMailTableAdapter = Me.EMailTableAdapter
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMailCaixaDeSaidaBindingSource
        '
        Me.EMailCaixaDeSaidaBindingSource.DataMember = "eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EMailCaixaDeSaidaTableAdapter
        '
        Me.EMailCaixaDeSaidaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(491, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "e-Mail"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.backupfundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 458)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControle.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.EMailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.EMailCaixaDeSaidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMailCaixaDeSaidaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDe As Label
    Friend WithEvents LabelPara As Label
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents RichTextBoxMensagem As RichTextBox
    Friend WithEvents TextBoxAssunto As TextBox
    Friend WithEvents TabControle As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EMailBindingSource As BindingSource
    Friend WithEvents EMailTableAdapter As PrinceDBDataSetTableAdapters.eMailTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMailCaixaDeSaidaBindingSource As BindingSource
    Friend WithEvents EMailCaixaDeSaidaTableAdapter As PrinceDBDataSetTableAdapters.eMailCaixaDeSaidaTableAdapter
    Friend WithEvents EMailCaixaDeSaidaDataGridView As DataGridView
    Friend WithEvents EMailCaixaDeSaidaBindingSource1 As BindingSource
    Friend WithEvents ClientSslComboBox As ComboBox
    Friend WithEvents SmtpPortTextBox As TextBox
    Friend WithEvents SmtpClientTextBox As TextBox
    Friend WithEvents SenhaEmailTextBox As TextBox
    Friend WithEvents EMailTextBox As TextBox
    Friend WithEvents ComboBoxEmailSelecionar As ComboBox
    Friend WithEvents ButtonExcluirSaida As Button
    Friend WithEvents ButtonNovoConfig As Button
    Friend WithEvents ButtonSalvarConfig As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonExcluirConfig As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLimpar As Button
    Friend WithEvents ButtonContatos As Button
    Friend WithEvents ParaGeralRichTextBox As RichTextBox
    Friend WithEvents ButtonGeral As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPara As RichTextBox
    Friend WithEvents CredencialComboBox As ComboBox
    Friend WithEvents HabilitaSslComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonAnexar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblAnexo As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
