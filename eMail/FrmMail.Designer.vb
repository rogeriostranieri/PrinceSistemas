<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMail
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxBuscaCaixaSaida = New System.Windows.Forms.TextBox()
        Me.ComboBoxCaixaSaida = New System.Windows.Forms.ComboBox()
        Me.ButtonExcluirSaida = New System.Windows.Forms.Button()
        Me.EMailCaixaDeSaidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailCaixaDeSaidaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LinkLabelGmail = New System.Windows.Forms.LinkLabel()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(20, 53)
        EMailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(154, 16)
        EMailLabel.TabIndex = 0
        EMailLabel.Text = "e-Mail/Usuário de saída:"
        '
        'SenhaEmailLabel
        '
        SenhaEmailLabel.AutoSize = True
        SenhaEmailLabel.Location = New System.Drawing.Point(33, 85)
        SenhaEmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SenhaEmailLabel.Name = "SenhaEmailLabel"
        SenhaEmailLabel.Size = New System.Drawing.Size(142, 16)
        SenhaEmailLabel.TabIndex = 2
        SenhaEmailLabel.Text = "Senha Email de saída:"
        '
        'SmtpClientLabel
        '
        SmtpClientLabel.AutoSize = True
        SmtpClientLabel.Location = New System.Drawing.Point(11, 117)
        SmtpClientLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SmtpClientLabel.Name = "SmtpClientLabel"
        SmtpClientLabel.Size = New System.Drawing.Size(165, 16)
        SmtpClientLabel.TabIndex = 4
        SmtpClientLabel.Text = "Servidor de saída (e-Mail):"
        '
        'SmtpPortLabel
        '
        SmtpPortLabel.AutoSize = True
        SmtpPortLabel.Location = New System.Drawing.Point(111, 149)
        SmtpPortLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SmtpPortLabel.Name = "SmtpPortLabel"
        SmtpPortLabel.Size = New System.Drawing.Size(68, 16)
        SmtpPortLabel.TabIndex = 6
        SmtpPortLabel.Text = "Smtp Port:"
        '
        'ClientSslLabel
        '
        ClientSslLabel.AutoSize = True
        ClientSslLabel.Location = New System.Drawing.Point(72, 247)
        ClientSslLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ClientSslLabel.Name = "ClientSslLabel"
        ClientSslLabel.Size = New System.Drawing.Size(104, 16)
        ClientSslLabel.TabIndex = 8
        ClientSslLabel.Text = "Segurança SSL:"
        ClientSslLabel.Visible = False
        '
        'ParaGeralLabel
        '
        ParaGeralLabel.AutoSize = True
        ParaGeralLabel.Location = New System.Drawing.Point(8, 289)
        ParaGeralLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ParaGeralLabel.Name = "ParaGeralLabel"
        ParaGeralLabel.Size = New System.Drawing.Size(173, 16)
        ParaGeralLabel.TabIndex = 50
        ParaGeralLabel.Text = "E-mail padrão para destino:"
        '
        'HabilitaSslLabel
        '
        HabilitaSslLabel.AutoSize = True
        HabilitaSslLabel.Location = New System.Drawing.Point(95, 181)
        HabilitaSslLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HabilitaSslLabel.Name = "HabilitaSslLabel"
        HabilitaSslLabel.Size = New System.Drawing.Size(84, 16)
        HabilitaSslLabel.TabIndex = 52
        HabilitaSslLabel.Text = "Habilita SSL:"
        '
        'CredencialLabel
        '
        CredencialLabel.AutoSize = True
        CredencialLabel.Location = New System.Drawing.Point(105, 214)
        CredencialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CredencialLabel.Name = "CredencialLabel"
        CredencialLabel.Size = New System.Drawing.Size(75, 16)
        CredencialLabel.TabIndex = 53
        CredencialLabel.Text = "Credencial:"
        '
        'LabelDe
        '
        Me.LabelDe.AutoSize = True
        Me.LabelDe.Location = New System.Drawing.Point(19, 34)
        Me.LabelDe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDe.Name = "LabelDe"
        Me.LabelDe.Size = New System.Drawing.Size(135, 16)
        Me.LabelDe.TabIndex = 1
        Me.LabelDe.Text = "E-mail que vai enviar:"
        '
        'LabelPara
        '
        Me.LabelPara.AutoSize = True
        Me.LabelPara.Location = New System.Drawing.Point(120, 70)
        Me.LabelPara.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPara.Name = "LabelPara"
        Me.LabelPara.Size = New System.Drawing.Size(39, 16)
        Me.LabelPara.TabIndex = 3
        Me.LabelPara.Text = "Para:"
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.ForeColor = System.Drawing.Color.Green
        Me.ButtonEnviar.Location = New System.Drawing.Point(612, 391)
        Me.ButtonEnviar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonEnviar.TabIndex = 4
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'RichTextBoxMensagem
        '
        Me.RichTextBoxMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RichTextBoxMensagem.Location = New System.Drawing.Point(23, 186)
        Me.RichTextBoxMensagem.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxMensagem.Name = "RichTextBoxMensagem"
        Me.RichTextBoxMensagem.Size = New System.Drawing.Size(560, 171)
        Me.RichTextBoxMensagem.TabIndex = 5
        Me.RichTextBoxMensagem.Text = "Seu texto ...."
        '
        'TextBoxAssunto
        '
        Me.TextBoxAssunto.Location = New System.Drawing.Point(23, 154)
        Me.TextBoxAssunto.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxAssunto.Name = "TextBoxAssunto"
        Me.TextBoxAssunto.Size = New System.Drawing.Size(560, 22)
        Me.TextBoxAssunto.TabIndex = 6
        Me.TextBoxAssunto.Text = "Digite aqui o assunto..."
        '
        'TabControle
        '
        Me.TabControle.Controls.Add(Me.TabPage1)
        Me.TabControle.Controls.Add(Me.TabPage2)
        Me.TabControle.Controls.Add(Me.TabPage3)
        Me.TabControle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControle.Location = New System.Drawing.Point(4, 90)
        Me.TabControle.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControle.Name = "TabControle"
        Me.TabControle.SelectedIndex = 0
        Me.TabControle.Size = New System.Drawing.Size(748, 458)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(740, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Enviar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblAnexo
        '
        Me.LblAnexo.AutoSize = True
        Me.LblAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnexo.Location = New System.Drawing.Point(113, 372)
        Me.LblAnexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.ButtonAnexar.Location = New System.Drawing.Point(23, 366)
        Me.ButtonAnexar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAnexar.Name = "ButtonAnexar"
        Me.ButtonAnexar.Size = New System.Drawing.Size(83, 28)
        Me.ButtonAnexar.TabIndex = 51
        Me.ButtonAnexar.Text = "Anexar"
        Me.ButtonAnexar.UseVisualStyleBackColor = True
        '
        'ButtonGeral
        '
        Me.ButtonGeral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGeral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonGeral.Location = New System.Drawing.Point(89, 107)
        Me.ButtonGeral.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGeral.Name = "ButtonGeral"
        Me.ButtonGeral.Size = New System.Drawing.Size(73, 28)
        Me.ButtonGeral.TabIndex = 49
        Me.ButtonGeral.Text = "Geral"
        Me.ButtonGeral.UseVisualStyleBackColor = True
        '
        'ButtonContatos
        '
        Me.ButtonContatos.BackgroundImage = CType(resources.GetObject("ButtonContatos.BackgroundImage"), System.Drawing.Image)
        Me.ButtonContatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonContatos.ForeColor = System.Drawing.Color.Green
        Me.ButtonContatos.Location = New System.Drawing.Point(620, 7)
        Me.ButtonContatos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonContatos.Name = "ButtonContatos"
        Me.ButtonContatos.Size = New System.Drawing.Size(92, 27)
        Me.ButtonContatos.TabIndex = 48
        Me.ButtonContatos.Text = "Contatos"
        Me.ButtonContatos.UseVisualStyleBackColor = True
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonLimpar.Location = New System.Drawing.Point(612, 356)
        Me.ButtonLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonLimpar.TabIndex = 9
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'TextBoxPara
        '
        Me.TextBoxPara.Location = New System.Drawing.Point(171, 66)
        Me.TextBoxPara.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPara.Name = "TextBoxPara"
        Me.TextBoxPara.Size = New System.Drawing.Size(412, 68)
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
        Me.ComboBoxEmailSelecionar.Location = New System.Drawing.Point(168, 28)
        Me.ComboBoxEmailSelecionar.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEmailSelecionar.Name = "ComboBoxEmailSelecionar"
        Me.ComboBoxEmailSelecionar.Size = New System.Drawing.Size(259, 24)
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
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.TextBoxBuscaCaixaSaida)
        Me.TabPage2.Controls.Add(Me.ComboBoxCaixaSaida)
        Me.TabPage2.Controls.Add(Me.ButtonExcluirSaida)
        Me.TabPage2.Controls.Add(Me.EMailCaixaDeSaidaDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(740, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caixa de Saída"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Localizar e-mail enviado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "a"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(376, 81)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(335, 22)
        Me.DateTimePicker2.TabIndex = 53
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(16, 81)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(335, 22)
        Me.DateTimePicker1.TabIndex = 52
        '
        'TextBoxBuscaCaixaSaida
        '
        Me.TextBoxBuscaCaixaSaida.Location = New System.Drawing.Point(185, 48)
        Me.TextBoxBuscaCaixaSaida.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBuscaCaixaSaida.Name = "TextBoxBuscaCaixaSaida"
        Me.TextBoxBuscaCaixaSaida.Size = New System.Drawing.Size(525, 22)
        Me.TextBoxBuscaCaixaSaida.TabIndex = 51
        '
        'ComboBoxCaixaSaida
        '
        Me.ComboBoxCaixaSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCaixaSaida.FormattingEnabled = True
        Me.ComboBoxCaixaSaida.Items.AddRange(New Object() {"Clique Aqui", "Data de Envio", "Assunto", "Texto", "Destino", "eMail"})
        Me.ComboBoxCaixaSaida.Location = New System.Drawing.Point(16, 48)
        Me.ComboBoxCaixaSaida.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCaixaSaida.Name = "ComboBoxCaixaSaida"
        Me.ComboBoxCaixaSaida.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxCaixaSaida.TabIndex = 50
        '
        'ButtonExcluirSaida
        '
        Me.ButtonExcluirSaida.BackgroundImage = CType(resources.GetObject("ButtonExcluirSaida.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExcluirSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExcluirSaida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonExcluirSaida.Location = New System.Drawing.Point(620, 391)
        Me.ButtonExcluirSaida.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonExcluirSaida.Name = "ButtonExcluirSaida"
        Me.ButtonExcluirSaida.Size = New System.Drawing.Size(92, 28)
        Me.ButtonExcluirSaida.TabIndex = 48
        Me.ButtonExcluirSaida.Text = "Excluir"
        Me.ButtonExcluirSaida.UseVisualStyleBackColor = True
        '
        'EMailCaixaDeSaidaDataGridView
        '
        Me.EMailCaixaDeSaidaDataGridView.AllowUserToAddRows = False
        Me.EMailCaixaDeSaidaDataGridView.AutoGenerateColumns = False
        Me.EMailCaixaDeSaidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMailCaixaDeSaidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3})
        Me.EMailCaixaDeSaidaDataGridView.DataSource = Me.EMailCaixaDeSaidaBindingSource1
        Me.EMailCaixaDeSaidaDataGridView.Location = New System.Drawing.Point(16, 112)
        Me.EMailCaixaDeSaidaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.EMailCaixaDeSaidaDataGridView.MultiSelect = False
        Me.EMailCaixaDeSaidaDataGridView.Name = "EMailCaixaDeSaidaDataGridView"
        Me.EMailCaixaDeSaidaDataGridView.ReadOnly = True
        Me.EMailCaixaDeSaidaDataGridView.Size = New System.Drawing.Size(696, 272)
        Me.EMailCaixaDeSaidaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DataEnviado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data de Envio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "eMailDestino"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "eMailPrincipal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "eMail"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'EMailCaixaDeSaidaBindingSource1
        '
        Me.EMailCaixaDeSaidaBindingSource1.DataMember = "eMail_eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource1.DataSource = Me.EMailBindingSource
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.LinkLabelGmail)
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(740, 429)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Configurações"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LinkLabelGmail
        '
        Me.LinkLabelGmail.AutoSize = True
        Me.LinkLabelGmail.Location = New System.Drawing.Point(503, 53)
        Me.LinkLabelGmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabelGmail.Name = "LinkLabelGmail"
        Me.LinkLabelGmail.Size = New System.Drawing.Size(49, 16)
        Me.LinkLabelGmail.TabIndex = 57
        Me.LinkLabelGmail.TabStop = True
        Me.LinkLabelGmail.Text = "Gmail?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "* True"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 214)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "* False"
        '
        'CredencialComboBox
        '
        Me.CredencialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "Credencial", True))
        Me.CredencialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CredencialComboBox.FormattingEnabled = True
        Me.CredencialComboBox.Items.AddRange(New Object() {"", "False", "True"})
        Me.CredencialComboBox.Location = New System.Drawing.Point(193, 210)
        Me.CredencialComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CredencialComboBox.Name = "CredencialComboBox"
        Me.CredencialComboBox.Size = New System.Drawing.Size(132, 24)
        Me.CredencialComboBox.TabIndex = 54
        '
        'HabilitaSslComboBox
        '
        Me.HabilitaSslComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "HabilitaSsl", True))
        Me.HabilitaSslComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HabilitaSslComboBox.FormattingEnabled = True
        Me.HabilitaSslComboBox.Items.AddRange(New Object() {"", "False", "True"})
        Me.HabilitaSslComboBox.Location = New System.Drawing.Point(193, 177)
        Me.HabilitaSslComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.HabilitaSslComboBox.Name = "HabilitaSslComboBox"
        Me.HabilitaSslComboBox.Size = New System.Drawing.Size(132, 24)
        Me.HabilitaSslComboBox.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 401)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(433, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Utilizar "" , "" (vírgula) para separar cada e-mail, e sem espaõs, tudo junto!"
        '
        'ParaGeralRichTextBox
        '
        Me.ParaGeralRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "ParaGeral", True))
        Me.ParaGeralRichTextBox.Location = New System.Drawing.Point(193, 286)
        Me.ParaGeralRichTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ParaGeralRichTextBox.Name = "ParaGeralRichTextBox"
        Me.ParaGeralRichTextBox.Size = New System.Drawing.Size(488, 111)
        Me.ParaGeralRichTextBox.TabIndex = 51
        Me.ParaGeralRichTextBox.Text = ""
        '
        'ButtonExcluirConfig
        '
        Me.ButtonExcluirConfig.BackgroundImage = CType(resources.GetObject("ButtonExcluirConfig.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExcluirConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExcluirConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonExcluirConfig.Location = New System.Drawing.Point(591, 117)
        Me.ButtonExcluirConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonExcluirConfig.Name = "ButtonExcluirConfig"
        Me.ButtonExcluirConfig.Size = New System.Drawing.Size(92, 28)
        Me.ButtonExcluirConfig.TabIndex = 50
        Me.ButtonExcluirConfig.Text = "Excluir"
        Me.ButtonExcluirConfig.UseVisualStyleBackColor = True
        '
        'ButtonSalvarConfig
        '
        Me.ButtonSalvarConfig.BackgroundImage = CType(resources.GetObject("ButtonSalvarConfig.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSalvarConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalvarConfig.Location = New System.Drawing.Point(591, 81)
        Me.ButtonSalvarConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSalvarConfig.Name = "ButtonSalvarConfig"
        Me.ButtonSalvarConfig.Size = New System.Drawing.Size(92, 28)
        Me.ButtonSalvarConfig.TabIndex = 49
        Me.ButtonSalvarConfig.Text = "Salvar"
        Me.ButtonSalvarConfig.UseVisualStyleBackColor = True
        '
        'ButtonNovoConfig
        '
        Me.ButtonNovoConfig.BackgroundImage = CType(resources.GetObject("ButtonNovoConfig.BackgroundImage"), System.Drawing.Image)
        Me.ButtonNovoConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNovoConfig.ForeColor = System.Drawing.Color.Green
        Me.ButtonNovoConfig.Location = New System.Drawing.Point(591, 47)
        Me.ButtonNovoConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonNovoConfig.Name = "ButtonNovoConfig"
        Me.ButtonNovoConfig.Size = New System.Drawing.Size(92, 27)
        Me.ButtonNovoConfig.TabIndex = 47
        Me.ButtonNovoConfig.Text = "Novo"
        Me.ButtonNovoConfig.UseVisualStyleBackColor = True
        '
        'ClientSslComboBox
        '
        Me.ClientSslComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "clientSsl", True))
        Me.ClientSslComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientSslComboBox.FormattingEnabled = True
        Me.ClientSslComboBox.Items.AddRange(New Object() {"", "False", "SSL", "TLS", "True"})
        Me.ClientSslComboBox.Location = New System.Drawing.Point(193, 244)
        Me.ClientSslComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ClientSslComboBox.Name = "ClientSslComboBox"
        Me.ClientSslComboBox.Size = New System.Drawing.Size(132, 24)
        Me.ClientSslComboBox.Sorted = True
        Me.ClientSslComboBox.TabIndex = 9
        Me.ClientSslComboBox.Visible = False
        '
        'SmtpPortTextBox
        '
        Me.SmtpPortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SmtpPort", True))
        Me.SmtpPortTextBox.Location = New System.Drawing.Point(193, 145)
        Me.SmtpPortTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SmtpPortTextBox.Name = "SmtpPortTextBox"
        Me.SmtpPortTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SmtpPortTextBox.TabIndex = 7
        '
        'SmtpClientTextBox
        '
        Me.SmtpClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SmtpClient", True))
        Me.SmtpClientTextBox.Location = New System.Drawing.Point(193, 113)
        Me.SmtpClientTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SmtpClientTextBox.Name = "SmtpClientTextBox"
        Me.SmtpClientTextBox.Size = New System.Drawing.Size(300, 22)
        Me.SmtpClientTextBox.TabIndex = 5
        '
        'SenhaEmailTextBox
        '
        Me.SenhaEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SenhaEmail", True))
        Me.SenhaEmailTextBox.Location = New System.Drawing.Point(193, 81)
        Me.SenhaEmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SenhaEmailTextBox.Name = "SenhaEmailTextBox"
        Me.SenhaEmailTextBox.Size = New System.Drawing.Size(300, 22)
        Me.SenhaEmailTextBox.TabIndex = 3
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "eMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(193, 49)
        Me.EMailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(300, 22)
        Me.EMailTextBox.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 556)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(748, 18)
        Me.ProgressBar1.TabIndex = 53
        '
        'EMailTableAdapter
        '
        Me.EMailTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.eMailTableAdapter = Me.EMailTableAdapter
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
        'EMailCaixaDeSaidaBindingSource
        '
        Me.EMailCaixaDeSaidaBindingSource.DataMember = "eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EMailCaixaDeSaidaTableAdapter
        '
        Me.EMailCaixaDeSaidaTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.57219!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.56064!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.43936!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(756, 578)
        Me.TableLayoutPanel1.TabIndex = 55
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnFechar, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(748, 78)
        Me.TableLayoutPanel2.TabIndex = 54
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnFechar.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.Location = New System.Drawing.Point(595, 4)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(149, 70)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 17
        Me.BtnFechar.TabStop = False
        '
        'FrmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 578)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "e-Mail"
        Me.TabControle.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.EMailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.EMailCaixaDeSaidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMailCaixaDeSaidaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents ButtonExcluirConfig As Button
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnFechar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabelGmail As LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxCaixaSaida As ComboBox
    Friend WithEvents TextBoxBuscaCaixaSaida As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
