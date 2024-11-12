<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalhesParcelamento
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
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim DataParcelINSSantigoLabel As System.Windows.Forms.Label
        Dim DataParcelINSSnovoLabel As System.Windows.Forms.Label
        Dim DataParcelINSSprocLabel As System.Windows.Forms.Label
        Dim INSSAntigoProtLabel As System.Windows.Forms.Label
        Dim INSSAntigoObsLabel As System.Windows.Forms.Label
        Dim INSSNovoProtLabel As System.Windows.Forms.Label
        Dim INSSNovoObsLabel As System.Windows.Forms.Label
        Dim INSSProcProtLabel As System.Windows.Forms.Label
        Dim INSSProcObsLabel As System.Windows.Forms.Label
        Dim FinalizadoINSSAntigoLabel As System.Windows.Forms.Label
        Dim DataParcMEILabel As System.Windows.Forms.Label
        Dim GeralMEILabel As System.Windows.Forms.Label
        Dim MeiProtocoloLabel As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CNPJLabel1 = New System.Windows.Forms.Label()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.RazaoSocialLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SubTabControlINSSAntigo = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBoxFimINSSantigo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFimParcINSSAntigoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistrarEnvioInssAntigo = New System.Windows.Forms.Button()
        Me.MotivoParcINSSAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoINSSAntigoComboBox = New System.Windows.Forms.ComboBox()
        Me.DataParcelINSSantigoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INSSAntigoObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.INSSAntigoProtTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblFechamentoMesAntigo = New System.Windows.Forms.Label()
        Me.MesEnviadoINSSAntigoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HistoricoEnvioINSSAntigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SubTabControlINSSNovo = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBoxFimINSSnovo = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataFimParcINSSNovoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRegistrarEnvioInssNovo = New System.Windows.Forms.Button()
        Me.MotivoParcINSSNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoINSSNovoComboBox = New System.Windows.Forms.ComboBox()
        Me.DataParcelINSSnovoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INSSNovoObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.INSSNovoProtTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.MesEnviadoINSSNovoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HistoricoEnvioINSSNovoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SubTabControlINSSProcuradoria = New System.Windows.Forms.TabControl()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.GroupBoxFimINSSProc = New System.Windows.Forms.GroupBox()
        Me.DataFimParcINSSProcDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegistrarEnvioInssProcuradoria = New System.Windows.Forms.Button()
        Me.MotivoParcINSSProcRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoINSSProcComboBox = New System.Windows.Forms.ComboBox()
        Me.DataParcelINSSprocDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INSSProcObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.INSSProcProtTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.MesEnviadoINSSProcDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.HistoricoEnvioINSSProcRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SubTabControlMEI = New System.Windows.Forms.TabControl()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.GroupBoxFimMEI = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataFimParcMEIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrarEnvioMEI = New System.Windows.Forms.Button()
        Me.MeiProtocoloTextBox = New System.Windows.Forms.TextBox()
        Me.GeralMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FinalizadoMEIComboBox = New System.Windows.Forms.ComboBox()
        Me.DataParcMEIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotivoParcMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.MesEnviadoMEIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.HistoricoEnvioMEIRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        DataParcelINSSantigoLabel = New System.Windows.Forms.Label()
        DataParcelINSSnovoLabel = New System.Windows.Forms.Label()
        DataParcelINSSprocLabel = New System.Windows.Forms.Label()
        INSSAntigoProtLabel = New System.Windows.Forms.Label()
        INSSAntigoObsLabel = New System.Windows.Forms.Label()
        INSSNovoProtLabel = New System.Windows.Forms.Label()
        INSSNovoObsLabel = New System.Windows.Forms.Label()
        INSSProcProtLabel = New System.Windows.Forms.Label()
        INSSProcObsLabel = New System.Windows.Forms.Label()
        FinalizadoINSSAntigoLabel = New System.Windows.Forms.Label()
        DataParcMEILabel = New System.Windows.Forms.Label()
        GeralMEILabel = New System.Windows.Forms.Label()
        MeiProtocoloLabel = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SubTabControlINSSAntigo.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBoxFimINSSantigo.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SubTabControlINSSNovo.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBoxFimINSSnovo.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SubTabControlINSSProcuradoria.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBoxFimINSSProc.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SubTabControlMEI.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.GroupBoxFimMEI.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.GroupBoxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(16, 31)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(107, 19)
        RazaoSocialLabel.TabIndex = 0
        RazaoSocialLabel.Text = "Razao Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(577, 31)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(53, 19)
        CNPJLabel.TabIndex = 2
        CNPJLabel.Text = "CNPJ:"
        '
        'DataParcelINSSantigoLabel
        '
        DataParcelINSSantigoLabel.AutoSize = True
        DataParcelINSSantigoLabel.Location = New System.Drawing.Point(6, 13)
        DataParcelINSSantigoLabel.Name = "DataParcelINSSantigoLabel"
        DataParcelINSSantigoLabel.Size = New System.Drawing.Size(138, 18)
        DataParcelINSSantigoLabel.TabIndex = 0
        DataParcelINSSantigoLabel.Text = "Data de solicitação:"
        '
        'DataParcelINSSnovoLabel
        '
        DataParcelINSSnovoLabel.AutoSize = True
        DataParcelINSSnovoLabel.Location = New System.Drawing.Point(6, 13)
        DataParcelINSSnovoLabel.Name = "DataParcelINSSnovoLabel"
        DataParcelINSSnovoLabel.Size = New System.Drawing.Size(138, 18)
        DataParcelINSSnovoLabel.TabIndex = 0
        DataParcelINSSnovoLabel.Text = "Data de solicitação:"
        '
        'DataParcelINSSprocLabel
        '
        DataParcelINSSprocLabel.AutoSize = True
        DataParcelINSSprocLabel.Location = New System.Drawing.Point(6, 13)
        DataParcelINSSprocLabel.Name = "DataParcelINSSprocLabel"
        DataParcelINSSprocLabel.Size = New System.Drawing.Size(138, 18)
        DataParcelINSSprocLabel.TabIndex = 0
        DataParcelINSSprocLabel.Text = "Data de solicitação:"
        '
        'INSSAntigoProtLabel
        '
        INSSAntigoProtLabel.AutoSize = True
        INSSAntigoProtLabel.Location = New System.Drawing.Point(66, 47)
        INSSAntigoProtLabel.Name = "INSSAntigoProtLabel"
        INSSAntigoProtLabel.Size = New System.Drawing.Size(78, 18)
        INSSAntigoProtLabel.TabIndex = 2
        INSSAntigoProtLabel.Text = "Protocolo:"
        '
        'INSSAntigoObsLabel
        '
        INSSAntigoObsLabel.AutoSize = True
        INSSAntigoObsLabel.Location = New System.Drawing.Point(5, 165)
        INSSAntigoObsLabel.Name = "INSSAntigoObsLabel"
        INSSAntigoObsLabel.Size = New System.Drawing.Size(101, 18)
        INSSAntigoObsLabel.TabIndex = 4
        INSSAntigoObsLabel.Text = "Observações:"
        '
        'INSSNovoProtLabel
        '
        INSSNovoProtLabel.AutoSize = True
        INSSNovoProtLabel.Location = New System.Drawing.Point(66, 47)
        INSSNovoProtLabel.Name = "INSSNovoProtLabel"
        INSSNovoProtLabel.Size = New System.Drawing.Size(78, 18)
        INSSNovoProtLabel.TabIndex = 2
        INSSNovoProtLabel.Text = "Protocolo:"
        '
        'INSSNovoObsLabel
        '
        INSSNovoObsLabel.AutoSize = True
        INSSNovoObsLabel.Location = New System.Drawing.Point(5, 165)
        INSSNovoObsLabel.Name = "INSSNovoObsLabel"
        INSSNovoObsLabel.Size = New System.Drawing.Size(101, 18)
        INSSNovoObsLabel.TabIndex = 4
        INSSNovoObsLabel.Text = "Observações:"
        '
        'INSSProcProtLabel
        '
        INSSProcProtLabel.AutoSize = True
        INSSProcProtLabel.Location = New System.Drawing.Point(66, 47)
        INSSProcProtLabel.Name = "INSSProcProtLabel"
        INSSProcProtLabel.Size = New System.Drawing.Size(78, 18)
        INSSProcProtLabel.TabIndex = 2
        INSSProcProtLabel.Text = "Protocolo:"
        '
        'INSSProcObsLabel
        '
        INSSProcObsLabel.AutoSize = True
        INSSProcObsLabel.Location = New System.Drawing.Point(5, 165)
        INSSProcObsLabel.Name = "INSSProcObsLabel"
        INSSProcObsLabel.Size = New System.Drawing.Size(101, 18)
        INSSProcObsLabel.TabIndex = 4
        INSSProcObsLabel.Text = "Observações:"
        '
        'FinalizadoINSSAntigoLabel
        '
        FinalizadoINSSAntigoLabel.AutoSize = True
        FinalizadoINSSAntigoLabel.Location = New System.Drawing.Point(565, 13)
        FinalizadoINSSAntigoLabel.Name = "FinalizadoINSSAntigoLabel"
        FinalizadoINSSAntigoLabel.Size = New System.Drawing.Size(54, 18)
        FinalizadoINSSAntigoLabel.TabIndex = 6
        FinalizadoINSSAntigoLabel.Text = "Status:"
        '
        'DataParcMEILabel
        '
        DataParcMEILabel.AutoSize = True
        DataParcMEILabel.Location = New System.Drawing.Point(6, 13)
        DataParcMEILabel.Name = "DataParcMEILabel"
        DataParcMEILabel.Size = New System.Drawing.Size(138, 18)
        DataParcMEILabel.TabIndex = 2
        DataParcMEILabel.Text = "Data de solicitação:"
        '
        'GeralMEILabel
        '
        GeralMEILabel.AutoSize = True
        GeralMEILabel.Location = New System.Drawing.Point(6, 165)
        GeralMEILabel.Name = "GeralMEILabel"
        GeralMEILabel.Size = New System.Drawing.Size(101, 18)
        GeralMEILabel.TabIndex = 8
        GeralMEILabel.Text = "Observações:"
        '
        'MeiProtocoloLabel
        '
        MeiProtocoloLabel.AutoSize = True
        MeiProtocoloLabel.Location = New System.Drawing.Point(66, 47)
        MeiProtocoloLabel.Name = "MeiProtocoloLabel"
        MeiProtocoloLabel.Size = New System.Drawing.Size(78, 18)
        MeiProtocoloLabel.TabIndex = 9
        MeiProtocoloLabel.Text = "Protocolo:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(565, 13)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(54, 18)
        Label16.TabIndex = 17
        Label16.Text = "Status:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(565, 13)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(54, 18)
        Label17.TabIndex = 18
        Label17.Text = "Status:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(565, 13)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(54, 18)
        Label18.TabIndex = 18
        Label18.Text = "Status:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64098!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35903!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenu, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.10791!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.89209!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(986, 556)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(CNPJLabel)
        Me.GroupBox1.Controls.Add(Me.CNPJLabel1)
        Me.GroupBox1.Controls.Add(RazaoSocialLabel)
        Me.GroupBox1.Controls.Add(Me.RazaoSocialLabel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes do Parcelamento da Empresa:"
        '
        'CNPJLabel1
        '
        Me.CNPJLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CNPJ", True))
        Me.CNPJLabel1.Location = New System.Drawing.Point(635, 31)
        Me.CNPJLabel1.Name = "CNPJLabel1"
        Me.CNPJLabel1.Size = New System.Drawing.Size(207, 23)
        Me.CNPJLabel1.TabIndex = 3
        Me.CNPJLabel1.Text = "Label1"
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
        'RazaoSocialLabel1
        '
        Me.RazaoSocialLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialLabel1.Location = New System.Drawing.Point(123, 31)
        Me.RazaoSocialLabel1.Name = "RazaoSocialLabel1"
        Me.RazaoSocialLabel1.Size = New System.Drawing.Size(448, 23)
        Me.RazaoSocialLabel1.TabIndex = 1
        Me.RazaoSocialLabel1.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.TabControlPrincipal)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(867, 467)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parcelamentos"
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlPrincipal.Controls.Add(Me.TabPage1)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage2)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage3)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage4)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage5)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipal.Location = New System.Drawing.Point(3, 20)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(861, 444)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SubTabControlINSSAntigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(853, 410)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INSS - Antigo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SubTabControlINSSAntigo
        '
        Me.SubTabControlINSSAntigo.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.SubTabControlINSSAntigo.Controls.Add(Me.TabPage6)
        Me.SubTabControlINSSAntigo.Controls.Add(Me.TabPage7)
        Me.SubTabControlINSSAntigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubTabControlINSSAntigo.Location = New System.Drawing.Point(3, 3)
        Me.SubTabControlINSSAntigo.Name = "SubTabControlINSSAntigo"
        Me.SubTabControlINSSAntigo.SelectedIndex = 0
        Me.SubTabControlINSSAntigo.Size = New System.Drawing.Size(847, 404)
        Me.SubTabControlINSSAntigo.TabIndex = 6
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.GroupBoxFimINSSantigo)
        Me.TabPage6.Controls.Add(Me.Label1)
        Me.TabPage6.Controls.Add(Me.BtnRegistrarEnvioInssAntigo)
        Me.TabPage6.Controls.Add(Me.MotivoParcINSSAntigoRichTextBox)
        Me.TabPage6.Controls.Add(FinalizadoINSSAntigoLabel)
        Me.TabPage6.Controls.Add(Me.FinalizadoINSSAntigoComboBox)
        Me.TabPage6.Controls.Add(DataParcelINSSantigoLabel)
        Me.TabPage6.Controls.Add(INSSAntigoObsLabel)
        Me.TabPage6.Controls.Add(Me.DataParcelINSSantigoDateTimePicker)
        Me.TabPage6.Controls.Add(Me.INSSAntigoObsRichTextBox)
        Me.TabPage6.Controls.Add(Me.INSSAntigoProtTextBox)
        Me.TabPage6.Controls.Add(INSSAntigoProtLabel)
        Me.TabPage6.Location = New System.Drawing.Point(4, 30)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(839, 370)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Geral"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBoxFimINSSantigo
        '
        Me.GroupBoxFimINSSantigo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBoxFimINSSantigo.Controls.Add(Me.Label5)
        Me.GroupBoxFimINSSantigo.Controls.Add(Me.DataFimParcINSSAntigoDateTimePicker)
        Me.GroupBoxFimINSSantigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFimINSSantigo.Location = New System.Drawing.Point(6, 97)
        Me.GroupBoxFimINSSantigo.Name = "GroupBoxFimINSSantigo"
        Me.GroupBoxFimINSSantigo.Size = New System.Drawing.Size(822, 63)
        Me.GroupBoxFimINSSantigo.TabIndex = 16
        Me.GroupBoxFimINSSantigo.TabStop = False
        Me.GroupBoxFimINSSantigo.Text = "ATENÇÃO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Data do fim do parcelamento:"
        '
        'DataFimParcINSSAntigoDateTimePicker
        '
        Me.DataFimParcINSSAntigoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataFimParcINSSAntigo", True))
        Me.DataFimParcINSSAntigoDateTimePicker.Location = New System.Drawing.Point(241, 24)
        Me.DataFimParcINSSAntigoDateTimePicker.Name = "DataFimParcINSSAntigoDateTimePicker"
        Me.DataFimParcINSSAntigoDateTimePicker.Size = New System.Drawing.Size(359, 24)
        Me.DataFimParcINSSAntigoDateTimePicker.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Motivo Deferimento:"
        '
        'BtnRegistrarEnvioInssAntigo
        '
        Me.BtnRegistrarEnvioInssAntigo.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioInssAntigo.Location = New System.Drawing.Point(672, 58)
        Me.BtnRegistrarEnvioInssAntigo.Name = "BtnRegistrarEnvioInssAntigo"
        Me.BtnRegistrarEnvioInssAntigo.Size = New System.Drawing.Size(156, 38)
        Me.BtnRegistrarEnvioInssAntigo.TabIndex = 10
        Me.BtnRegistrarEnvioInssAntigo.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioInssAntigo.UseVisualStyleBackColor = True
        '
        'MotivoParcINSSAntigoRichTextBox
        '
        Me.MotivoParcINSSAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcINSSAntigo", True))
        Me.MotivoParcINSSAntigoRichTextBox.Location = New System.Drawing.Point(587, 165)
        Me.MotivoParcINSSAntigoRichTextBox.Name = "MotivoParcINSSAntigoRichTextBox"
        Me.MotivoParcINSSAntigoRichTextBox.Size = New System.Drawing.Size(241, 198)
        Me.MotivoParcINSSAntigoRichTextBox.TabIndex = 9
        Me.MotivoParcINSSAntigoRichTextBox.Text = ""
        '
        'FinalizadoINSSAntigoComboBox
        '
        Me.FinalizadoINSSAntigoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoINSSAntigo", True))
        Me.FinalizadoINSSAntigoComboBox.FormattingEnabled = True
        Me.FinalizadoINSSAntigoComboBox.Location = New System.Drawing.Point(625, 10)
        Me.FinalizadoINSSAntigoComboBox.Name = "FinalizadoINSSAntigoComboBox"
        Me.FinalizadoINSSAntigoComboBox.Size = New System.Drawing.Size(203, 26)
        Me.FinalizadoINSSAntigoComboBox.TabIndex = 7
        '
        'DataParcelINSSantigoDateTimePicker
        '
        Me.DataParcelINSSantigoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcelINSSantigo", True))
        Me.DataParcelINSSantigoDateTimePicker.Location = New System.Drawing.Point(150, 10)
        Me.DataParcelINSSantigoDateTimePicker.Name = "DataParcelINSSantigoDateTimePicker"
        Me.DataParcelINSSantigoDateTimePicker.Size = New System.Drawing.Size(320, 24)
        Me.DataParcelINSSantigoDateTimePicker.TabIndex = 1
        '
        'INSSAntigoObsRichTextBox
        '
        Me.INSSAntigoObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSAntigoObs", True))
        Me.INSSAntigoObsRichTextBox.Location = New System.Drawing.Point(112, 165)
        Me.INSSAntigoObsRichTextBox.Name = "INSSAntigoObsRichTextBox"
        Me.INSSAntigoObsRichTextBox.Size = New System.Drawing.Size(320, 199)
        Me.INSSAntigoObsRichTextBox.TabIndex = 5
        Me.INSSAntigoObsRichTextBox.Text = ""
        '
        'INSSAntigoProtTextBox
        '
        Me.INSSAntigoProtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSAntigoProt", True))
        Me.INSSAntigoProtTextBox.Location = New System.Drawing.Point(150, 47)
        Me.INSSAntigoProtTextBox.Name = "INSSAntigoProtTextBox"
        Me.INSSAntigoProtTextBox.Size = New System.Drawing.Size(320, 24)
        Me.INSSAntigoProtTextBox.TabIndex = 3
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Controls.Add(Me.Label9)
        Me.TabPage7.Controls.Add(Me.LblFechamentoMesAntigo)
        Me.TabPage7.Controls.Add(Me.MesEnviadoINSSAntigoDateTimePicker)
        Me.TabPage7.Controls.Add(Me.HistoricoEnvioINSSAntigoRichTextBox)
        Me.TabPage7.Location = New System.Drawing.Point(4, 30)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(839, 370)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Histórico de Envio"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Histórico de Envios"
        '
        'LblFechamentoMesAntigo
        '
        Me.LblFechamentoMesAntigo.AutoSize = True
        Me.LblFechamentoMesAntigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechamentoMesAntigo.Location = New System.Drawing.Point(6, 13)
        Me.LblFechamentoMesAntigo.Name = "LblFechamentoMesAntigo"
        Me.LblFechamentoMesAntigo.Size = New System.Drawing.Size(228, 18)
        Me.LblFechamentoMesAntigo.TabIndex = 3
        Me.LblFechamentoMesAntigo.Text = "Fechamento do Mês-Enviado"
        '
        'MesEnviadoINSSAntigoDateTimePicker
        '
        Me.MesEnviadoINSSAntigoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoINSSAntigo", True))
        Me.MesEnviadoINSSAntigoDateTimePicker.Location = New System.Drawing.Point(9, 34)
        Me.MesEnviadoINSSAntigoDateTimePicker.Name = "MesEnviadoINSSAntigoDateTimePicker"
        Me.MesEnviadoINSSAntigoDateTimePicker.Size = New System.Drawing.Size(319, 24)
        Me.MesEnviadoINSSAntigoDateTimePicker.TabIndex = 2
        '
        'HistoricoEnvioINSSAntigoRichTextBox
        '
        Me.HistoricoEnvioINSSAntigoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSAntigo", True))
        Me.HistoricoEnvioINSSAntigoRichTextBox.Location = New System.Drawing.Point(3, 103)
        Me.HistoricoEnvioINSSAntigoRichTextBox.Name = "HistoricoEnvioINSSAntigoRichTextBox"
        Me.HistoricoEnvioINSSAntigoRichTextBox.ReadOnly = True
        Me.HistoricoEnvioINSSAntigoRichTextBox.Size = New System.Drawing.Size(833, 264)
        Me.HistoricoEnvioINSSAntigoRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSAntigoRichTextBox.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SubTabControlINSSNovo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(853, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INSS - Novo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SubTabControlINSSNovo
        '
        Me.SubTabControlINSSNovo.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.SubTabControlINSSNovo.Controls.Add(Me.TabPage8)
        Me.SubTabControlINSSNovo.Controls.Add(Me.TabPage9)
        Me.SubTabControlINSSNovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubTabControlINSSNovo.Location = New System.Drawing.Point(3, 3)
        Me.SubTabControlINSSNovo.Name = "SubTabControlINSSNovo"
        Me.SubTabControlINSSNovo.SelectedIndex = 0
        Me.SubTabControlINSSNovo.Size = New System.Drawing.Size(847, 404)
        Me.SubTabControlINSSNovo.TabIndex = 6
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.Controls.Add(Label16)
        Me.TabPage8.Controls.Add(Me.GroupBoxFimINSSnovo)
        Me.TabPage8.Controls.Add(Me.Label2)
        Me.TabPage8.Controls.Add(Me.BtnRegistrarEnvioInssNovo)
        Me.TabPage8.Controls.Add(Me.MotivoParcINSSNovoRichTextBox)
        Me.TabPage8.Controls.Add(Me.FinalizadoINSSNovoComboBox)
        Me.TabPage8.Controls.Add(DataParcelINSSnovoLabel)
        Me.TabPage8.Controls.Add(INSSNovoObsLabel)
        Me.TabPage8.Controls.Add(Me.DataParcelINSSnovoDateTimePicker)
        Me.TabPage8.Controls.Add(Me.INSSNovoObsRichTextBox)
        Me.TabPage8.Controls.Add(Me.INSSNovoProtTextBox)
        Me.TabPage8.Controls.Add(INSSNovoProtLabel)
        Me.TabPage8.Location = New System.Drawing.Point(4, 30)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(839, 370)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Geral"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'GroupBoxFimINSSnovo
        '
        Me.GroupBoxFimINSSnovo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBoxFimINSSnovo.Controls.Add(Me.Label6)
        Me.GroupBoxFimINSSnovo.Controls.Add(Me.DataFimParcINSSNovoDateTimePicker)
        Me.GroupBoxFimINSSnovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFimINSSnovo.Location = New System.Drawing.Point(6, 97)
        Me.GroupBoxFimINSSnovo.Name = "GroupBoxFimINSSnovo"
        Me.GroupBoxFimINSSnovo.Size = New System.Drawing.Size(822, 63)
        Me.GroupBoxFimINSSnovo.TabIndex = 17
        Me.GroupBoxFimINSSnovo.TabStop = False
        Me.GroupBoxFimINSSnovo.Text = "ATENÇÃO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Data do fim do parcelamento:"
        '
        'DataFimParcINSSNovoDateTimePicker
        '
        Me.DataFimParcINSSNovoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataFimParcINSSNovo", True))
        Me.DataFimParcINSSNovoDateTimePicker.Location = New System.Drawing.Point(241, 24)
        Me.DataFimParcINSSNovoDateTimePicker.Name = "DataFimParcINSSNovoDateTimePicker"
        Me.DataFimParcINSSNovoDateTimePicker.Size = New System.Drawing.Size(359, 24)
        Me.DataFimParcINSSNovoDateTimePicker.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Motivo Deferimento:"
        '
        'BtnRegistrarEnvioInssNovo
        '
        Me.BtnRegistrarEnvioInssNovo.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioInssNovo.Location = New System.Drawing.Point(672, 58)
        Me.BtnRegistrarEnvioInssNovo.Name = "BtnRegistrarEnvioInssNovo"
        Me.BtnRegistrarEnvioInssNovo.Size = New System.Drawing.Size(156, 38)
        Me.BtnRegistrarEnvioInssNovo.TabIndex = 11
        Me.BtnRegistrarEnvioInssNovo.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioInssNovo.UseVisualStyleBackColor = True
        '
        'MotivoParcINSSNovoRichTextBox
        '
        Me.MotivoParcINSSNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcINSSNovo", True))
        Me.MotivoParcINSSNovoRichTextBox.Location = New System.Drawing.Point(587, 165)
        Me.MotivoParcINSSNovoRichTextBox.Name = "MotivoParcINSSNovoRichTextBox"
        Me.MotivoParcINSSNovoRichTextBox.Size = New System.Drawing.Size(242, 199)
        Me.MotivoParcINSSNovoRichTextBox.TabIndex = 9
        Me.MotivoParcINSSNovoRichTextBox.Text = ""
        '
        'FinalizadoINSSNovoComboBox
        '
        Me.FinalizadoINSSNovoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoINSSNovo", True))
        Me.FinalizadoINSSNovoComboBox.FormattingEnabled = True
        Me.FinalizadoINSSNovoComboBox.Location = New System.Drawing.Point(625, 10)
        Me.FinalizadoINSSNovoComboBox.Name = "FinalizadoINSSNovoComboBox"
        Me.FinalizadoINSSNovoComboBox.Size = New System.Drawing.Size(203, 26)
        Me.FinalizadoINSSNovoComboBox.TabIndex = 7
        '
        'DataParcelINSSnovoDateTimePicker
        '
        Me.DataParcelINSSnovoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcelINSSnovo", True))
        Me.DataParcelINSSnovoDateTimePicker.Location = New System.Drawing.Point(150, 10)
        Me.DataParcelINSSnovoDateTimePicker.Name = "DataParcelINSSnovoDateTimePicker"
        Me.DataParcelINSSnovoDateTimePicker.Size = New System.Drawing.Size(320, 24)
        Me.DataParcelINSSnovoDateTimePicker.TabIndex = 1
        '
        'INSSNovoObsRichTextBox
        '
        Me.INSSNovoObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSNovoObs", True))
        Me.INSSNovoObsRichTextBox.Location = New System.Drawing.Point(112, 165)
        Me.INSSNovoObsRichTextBox.Name = "INSSNovoObsRichTextBox"
        Me.INSSNovoObsRichTextBox.Size = New System.Drawing.Size(320, 199)
        Me.INSSNovoObsRichTextBox.TabIndex = 5
        Me.INSSNovoObsRichTextBox.Text = ""
        '
        'INSSNovoProtTextBox
        '
        Me.INSSNovoProtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSNovoProt", True))
        Me.INSSNovoProtTextBox.Location = New System.Drawing.Point(150, 47)
        Me.INSSNovoProtTextBox.Name = "INSSNovoProtTextBox"
        Me.INSSNovoProtTextBox.Size = New System.Drawing.Size(320, 24)
        Me.INSSNovoProtTextBox.TabIndex = 3
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.Controls.Add(Me.MesEnviadoINSSNovoDateTimePicker)
        Me.TabPage9.Controls.Add(Me.Label10)
        Me.TabPage9.Controls.Add(Me.Label11)
        Me.TabPage9.Controls.Add(Me.HistoricoEnvioINSSNovoRichTextBox)
        Me.TabPage9.Location = New System.Drawing.Point(4, 30)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(839, 374)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "Histórico de Envio"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'MesEnviadoINSSNovoDateTimePicker
        '
        Me.MesEnviadoINSSNovoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoINSSNovo", True))
        Me.MesEnviadoINSSNovoDateTimePicker.Location = New System.Drawing.Point(9, 34)
        Me.MesEnviadoINSSNovoDateTimePicker.Name = "MesEnviadoINSSNovoDateTimePicker"
        Me.MesEnviadoINSSNovoDateTimePicker.Size = New System.Drawing.Size(319, 24)
        Me.MesEnviadoINSSNovoDateTimePicker.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Histórico de Envios"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(228, 18)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Fechamento do Mês-Enviado"
        '
        'HistoricoEnvioINSSNovoRichTextBox
        '
        Me.HistoricoEnvioINSSNovoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSNovo", True))
        Me.HistoricoEnvioINSSNovoRichTextBox.Location = New System.Drawing.Point(3, 103)
        Me.HistoricoEnvioINSSNovoRichTextBox.Name = "HistoricoEnvioINSSNovoRichTextBox"
        Me.HistoricoEnvioINSSNovoRichTextBox.ReadOnly = True
        Me.HistoricoEnvioINSSNovoRichTextBox.Size = New System.Drawing.Size(833, 264)
        Me.HistoricoEnvioINSSNovoRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSNovoRichTextBox.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SubTabControlINSSProcuradoria)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(853, 410)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "INSS - Procuradoria"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SubTabControlINSSProcuradoria
        '
        Me.SubTabControlINSSProcuradoria.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.SubTabControlINSSProcuradoria.Controls.Add(Me.TabPage10)
        Me.SubTabControlINSSProcuradoria.Controls.Add(Me.TabPage11)
        Me.SubTabControlINSSProcuradoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubTabControlINSSProcuradoria.Location = New System.Drawing.Point(3, 3)
        Me.SubTabControlINSSProcuradoria.Name = "SubTabControlINSSProcuradoria"
        Me.SubTabControlINSSProcuradoria.SelectedIndex = 0
        Me.SubTabControlINSSProcuradoria.Size = New System.Drawing.Size(847, 404)
        Me.SubTabControlINSSProcuradoria.TabIndex = 6
        '
        'TabPage10
        '
        Me.TabPage10.AutoScroll = True
        Me.TabPage10.Controls.Add(Label17)
        Me.TabPage10.Controls.Add(Me.GroupBoxFimINSSProc)
        Me.TabPage10.Controls.Add(Me.Label3)
        Me.TabPage10.Controls.Add(Me.BtnRegistrarEnvioInssProcuradoria)
        Me.TabPage10.Controls.Add(Me.MotivoParcINSSProcRichTextBox)
        Me.TabPage10.Controls.Add(Me.FinalizadoINSSProcComboBox)
        Me.TabPage10.Controls.Add(DataParcelINSSprocLabel)
        Me.TabPage10.Controls.Add(INSSProcObsLabel)
        Me.TabPage10.Controls.Add(Me.DataParcelINSSprocDateTimePicker)
        Me.TabPage10.Controls.Add(Me.INSSProcObsRichTextBox)
        Me.TabPage10.Controls.Add(Me.INSSProcProtTextBox)
        Me.TabPage10.Controls.Add(INSSProcProtLabel)
        Me.TabPage10.Location = New System.Drawing.Point(4, 30)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(839, 370)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Geral"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'GroupBoxFimINSSProc
        '
        Me.GroupBoxFimINSSProc.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBoxFimINSSProc.Controls.Add(Me.DataFimParcINSSProcDateTimePicker)
        Me.GroupBoxFimINSSProc.Controls.Add(Me.Label7)
        Me.GroupBoxFimINSSProc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFimINSSProc.Location = New System.Drawing.Point(6, 97)
        Me.GroupBoxFimINSSProc.Name = "GroupBoxFimINSSProc"
        Me.GroupBoxFimINSSProc.Size = New System.Drawing.Size(822, 63)
        Me.GroupBoxFimINSSProc.TabIndex = 17
        Me.GroupBoxFimINSSProc.TabStop = False
        Me.GroupBoxFimINSSProc.Text = "ATENÇÃO"
        '
        'DataFimParcINSSProcDateTimePicker
        '
        Me.DataFimParcINSSProcDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataFimParcINSSProc", True))
        Me.DataFimParcINSSProcDateTimePicker.Location = New System.Drawing.Point(241, 24)
        Me.DataFimParcINSSProcDateTimePicker.Name = "DataFimParcINSSProcDateTimePicker"
        Me.DataFimParcINSSProcDateTimePicker.Size = New System.Drawing.Size(359, 24)
        Me.DataFimParcINSSProcDateTimePicker.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Data do fim do parcelamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(438, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Motivo Deferimento:"
        '
        'BtnRegistrarEnvioInssProcuradoria
        '
        Me.BtnRegistrarEnvioInssProcuradoria.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioInssProcuradoria.Location = New System.Drawing.Point(672, 58)
        Me.BtnRegistrarEnvioInssProcuradoria.Name = "BtnRegistrarEnvioInssProcuradoria"
        Me.BtnRegistrarEnvioInssProcuradoria.Size = New System.Drawing.Size(156, 38)
        Me.BtnRegistrarEnvioInssProcuradoria.TabIndex = 11
        Me.BtnRegistrarEnvioInssProcuradoria.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioInssProcuradoria.UseVisualStyleBackColor = True
        '
        'MotivoParcINSSProcRichTextBox
        '
        Me.MotivoParcINSSProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcINSSProc", True))
        Me.MotivoParcINSSProcRichTextBox.Location = New System.Drawing.Point(587, 165)
        Me.MotivoParcINSSProcRichTextBox.Name = "MotivoParcINSSProcRichTextBox"
        Me.MotivoParcINSSProcRichTextBox.Size = New System.Drawing.Size(242, 199)
        Me.MotivoParcINSSProcRichTextBox.TabIndex = 9
        Me.MotivoParcINSSProcRichTextBox.Text = ""
        '
        'FinalizadoINSSProcComboBox
        '
        Me.FinalizadoINSSProcComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoINSSProc", True))
        Me.FinalizadoINSSProcComboBox.FormattingEnabled = True
        Me.FinalizadoINSSProcComboBox.Location = New System.Drawing.Point(625, 10)
        Me.FinalizadoINSSProcComboBox.Name = "FinalizadoINSSProcComboBox"
        Me.FinalizadoINSSProcComboBox.Size = New System.Drawing.Size(203, 26)
        Me.FinalizadoINSSProcComboBox.TabIndex = 7
        '
        'DataParcelINSSprocDateTimePicker
        '
        Me.DataParcelINSSprocDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcelINSSproc", True))
        Me.DataParcelINSSprocDateTimePicker.Location = New System.Drawing.Point(150, 10)
        Me.DataParcelINSSprocDateTimePicker.Name = "DataParcelINSSprocDateTimePicker"
        Me.DataParcelINSSprocDateTimePicker.Size = New System.Drawing.Size(320, 24)
        Me.DataParcelINSSprocDateTimePicker.TabIndex = 1
        '
        'INSSProcObsRichTextBox
        '
        Me.INSSProcObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSProcObs", True))
        Me.INSSProcObsRichTextBox.Location = New System.Drawing.Point(112, 165)
        Me.INSSProcObsRichTextBox.Name = "INSSProcObsRichTextBox"
        Me.INSSProcObsRichTextBox.Size = New System.Drawing.Size(320, 199)
        Me.INSSProcObsRichTextBox.TabIndex = 5
        Me.INSSProcObsRichTextBox.Text = ""
        '
        'INSSProcProtTextBox
        '
        Me.INSSProcProtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "INSSProcProt", True))
        Me.INSSProcProtTextBox.Location = New System.Drawing.Point(150, 47)
        Me.INSSProcProtTextBox.Name = "INSSProcProtTextBox"
        Me.INSSProcProtTextBox.Size = New System.Drawing.Size(320, 24)
        Me.INSSProcProtTextBox.TabIndex = 3
        '
        'TabPage11
        '
        Me.TabPage11.AutoScroll = True
        Me.TabPage11.Controls.Add(Me.MesEnviadoINSSProcDateTimePicker)
        Me.TabPage11.Controls.Add(Me.Label12)
        Me.TabPage11.Controls.Add(Me.Label13)
        Me.TabPage11.Controls.Add(Me.HistoricoEnvioINSSProcRichTextBox)
        Me.TabPage11.Location = New System.Drawing.Point(4, 30)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(839, 370)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "Histórico de Envio"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'MesEnviadoINSSProcDateTimePicker
        '
        Me.MesEnviadoINSSProcDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoINSSProc", True))
        Me.MesEnviadoINSSProcDateTimePicker.Location = New System.Drawing.Point(9, 34)
        Me.MesEnviadoINSSProcDateTimePicker.Name = "MesEnviadoINSSProcDateTimePicker"
        Me.MesEnviadoINSSProcDateTimePicker.Size = New System.Drawing.Size(319, 24)
        Me.MesEnviadoINSSProcDateTimePicker.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Histórico de Envios"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 18)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Fechamento do Mês-Enviado"
        '
        'HistoricoEnvioINSSProcRichTextBox
        '
        Me.HistoricoEnvioINSSProcRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioINSSProc", True))
        Me.HistoricoEnvioINSSProcRichTextBox.Location = New System.Drawing.Point(3, 103)
        Me.HistoricoEnvioINSSProcRichTextBox.Name = "HistoricoEnvioINSSProcRichTextBox"
        Me.HistoricoEnvioINSSProcRichTextBox.ReadOnly = True
        Me.HistoricoEnvioINSSProcRichTextBox.Size = New System.Drawing.Size(833, 264)
        Me.HistoricoEnvioINSSProcRichTextBox.TabIndex = 1
        Me.HistoricoEnvioINSSProcRichTextBox.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SubTabControlMEI)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(853, 410)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "MEI"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SubTabControlMEI
        '
        Me.SubTabControlMEI.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.SubTabControlMEI.Controls.Add(Me.TabPage12)
        Me.SubTabControlMEI.Controls.Add(Me.TabPage13)
        Me.SubTabControlMEI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubTabControlMEI.Location = New System.Drawing.Point(3, 3)
        Me.SubTabControlMEI.Name = "SubTabControlMEI"
        Me.SubTabControlMEI.SelectedIndex = 0
        Me.SubTabControlMEI.Size = New System.Drawing.Size(847, 404)
        Me.SubTabControlMEI.TabIndex = 0
        '
        'TabPage12
        '
        Me.TabPage12.AutoScroll = True
        Me.TabPage12.Controls.Add(Label18)
        Me.TabPage12.Controls.Add(Me.GroupBoxFimMEI)
        Me.TabPage12.Controls.Add(Me.Label4)
        Me.TabPage12.Controls.Add(Me.BtnRegistrarEnvioMEI)
        Me.TabPage12.Controls.Add(MeiProtocoloLabel)
        Me.TabPage12.Controls.Add(Me.MeiProtocoloTextBox)
        Me.TabPage12.Controls.Add(GeralMEILabel)
        Me.TabPage12.Controls.Add(Me.GeralMEIRichTextBox)
        Me.TabPage12.Controls.Add(Me.FinalizadoMEIComboBox)
        Me.TabPage12.Controls.Add(DataParcMEILabel)
        Me.TabPage12.Controls.Add(Me.DataParcMEIDateTimePicker)
        Me.TabPage12.Controls.Add(Me.MotivoParcMEIRichTextBox)
        Me.TabPage12.Location = New System.Drawing.Point(4, 30)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(839, 370)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Geral"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'GroupBoxFimMEI
        '
        Me.GroupBoxFimMEI.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBoxFimMEI.Controls.Add(Me.Label8)
        Me.GroupBoxFimMEI.Controls.Add(Me.DataFimParcMEIDateTimePicker)
        Me.GroupBoxFimMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFimMEI.Location = New System.Drawing.Point(6, 97)
        Me.GroupBoxFimMEI.Name = "GroupBoxFimMEI"
        Me.GroupBoxFimMEI.Size = New System.Drawing.Size(822, 63)
        Me.GroupBoxFimMEI.TabIndex = 17
        Me.GroupBoxFimMEI.TabStop = False
        Me.GroupBoxFimMEI.Text = "ATENÇÃO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Data do fim do parcelamento:"
        '
        'DataFimParcMEIDateTimePicker
        '
        Me.DataFimParcMEIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataFimParcMEI", True))
        Me.DataFimParcMEIDateTimePicker.Location = New System.Drawing.Point(241, 24)
        Me.DataFimParcMEIDateTimePicker.Name = "DataFimParcMEIDateTimePicker"
        Me.DataFimParcMEIDateTimePicker.Size = New System.Drawing.Size(359, 24)
        Me.DataFimParcMEIDateTimePicker.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Motivo Deferimento:"
        '
        'BtnRegistrarEnvioMEI
        '
        Me.BtnRegistrarEnvioMEI.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarEnvioMEI.Location = New System.Drawing.Point(672, 58)
        Me.BtnRegistrarEnvioMEI.Name = "BtnRegistrarEnvioMEI"
        Me.BtnRegistrarEnvioMEI.Size = New System.Drawing.Size(156, 38)
        Me.BtnRegistrarEnvioMEI.TabIndex = 11
        Me.BtnRegistrarEnvioMEI.Text = "Registrar Envio"
        Me.BtnRegistrarEnvioMEI.UseVisualStyleBackColor = True
        '
        'MeiProtocoloTextBox
        '
        Me.MeiProtocoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MeiProtocolo", True))
        Me.MeiProtocoloTextBox.Location = New System.Drawing.Point(150, 47)
        Me.MeiProtocoloTextBox.Name = "MeiProtocoloTextBox"
        Me.MeiProtocoloTextBox.Size = New System.Drawing.Size(320, 24)
        Me.MeiProtocoloTextBox.TabIndex = 10
        '
        'GeralMEIRichTextBox
        '
        Me.GeralMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "GeralMEI", True))
        Me.GeralMEIRichTextBox.Location = New System.Drawing.Point(112, 165)
        Me.GeralMEIRichTextBox.Name = "GeralMEIRichTextBox"
        Me.GeralMEIRichTextBox.Size = New System.Drawing.Size(320, 199)
        Me.GeralMEIRichTextBox.TabIndex = 9
        Me.GeralMEIRichTextBox.Text = ""
        '
        'FinalizadoMEIComboBox
        '
        Me.FinalizadoMEIComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoMEI", True))
        Me.FinalizadoMEIComboBox.FormattingEnabled = True
        Me.FinalizadoMEIComboBox.Location = New System.Drawing.Point(625, 10)
        Me.FinalizadoMEIComboBox.Name = "FinalizadoMEIComboBox"
        Me.FinalizadoMEIComboBox.Size = New System.Drawing.Size(203, 26)
        Me.FinalizadoMEIComboBox.TabIndex = 7
        '
        'DataParcMEIDateTimePicker
        '
        Me.DataParcMEIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataParcMEI", True))
        Me.DataParcMEIDateTimePicker.Location = New System.Drawing.Point(150, 10)
        Me.DataParcMEIDateTimePicker.Name = "DataParcMEIDateTimePicker"
        Me.DataParcMEIDateTimePicker.Size = New System.Drawing.Size(320, 24)
        Me.DataParcMEIDateTimePicker.TabIndex = 3
        '
        'MotivoParcMEIRichTextBox
        '
        Me.MotivoParcMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "MotivoParcMEI", True))
        Me.MotivoParcMEIRichTextBox.Location = New System.Drawing.Point(587, 165)
        Me.MotivoParcMEIRichTextBox.Name = "MotivoParcMEIRichTextBox"
        Me.MotivoParcMEIRichTextBox.Size = New System.Drawing.Size(241, 199)
        Me.MotivoParcMEIRichTextBox.TabIndex = 1
        Me.MotivoParcMEIRichTextBox.Text = ""
        '
        'TabPage13
        '
        Me.TabPage13.AutoScroll = True
        Me.TabPage13.Controls.Add(Me.MesEnviadoMEIDateTimePicker)
        Me.TabPage13.Controls.Add(Me.Label14)
        Me.TabPage13.Controls.Add(Me.Label15)
        Me.TabPage13.Controls.Add(Me.HistoricoEnvioMEIRichTextBox)
        Me.TabPage13.Location = New System.Drawing.Point(4, 30)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(839, 374)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "Histórico de Envio"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'MesEnviadoMEIDateTimePicker
        '
        Me.MesEnviadoMEIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "MesEnviadoMEI", True))
        Me.MesEnviadoMEIDateTimePicker.Location = New System.Drawing.Point(9, 34)
        Me.MesEnviadoMEIDateTimePicker.Name = "MesEnviadoMEIDateTimePicker"
        Me.MesEnviadoMEIDateTimePicker.Size = New System.Drawing.Size(319, 24)
        Me.MesEnviadoMEIDateTimePicker.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 18)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Histórico de Envios"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(228, 18)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Fechamento do Mês-Enviado"
        '
        'HistoricoEnvioMEIRichTextBox
        '
        Me.HistoricoEnvioMEIRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "HistoricoEnvioMEI", True))
        Me.HistoricoEnvioMEIRichTextBox.Location = New System.Drawing.Point(3, 103)
        Me.HistoricoEnvioMEIRichTextBox.Name = "HistoricoEnvioMEIRichTextBox"
        Me.HistoricoEnvioMEIRichTextBox.ReadOnly = True
        Me.HistoricoEnvioMEIRichTextBox.Size = New System.Drawing.Size(833, 264)
        Me.HistoricoEnvioMEIRichTextBox.TabIndex = 1
        Me.HistoricoEnvioMEIRichTextBox.Text = ""
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Location = New System.Drawing.Point(4, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(853, 414)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Historicos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBoxMenu
        '
        Me.GroupBoxMenu.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMenu.Controls.Add(Me.BtnFechar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnSalvar)
        Me.GroupBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxMenu.Location = New System.Drawing.Point(877, 86)
        Me.GroupBoxMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxMenu.Size = New System.Drawing.Size(105, 467)
        Me.GroupBoxMenu.TabIndex = 58
        Me.GroupBoxMenu.TabStop = False
        '
        'BtnFechar
        '
        Me.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnFechar.FlatAppearance.BorderSize = 3
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(8, 56)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(88, 30)
        Me.BtnFechar.TabIndex = 10
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.BorderSize = 3
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(8, 23)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(88, 30)
        Me.BtnSalvar.TabIndex = 7
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
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
        'FrmDetalhesParcelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.ClientSize = New System.Drawing.Size(986, 556)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDetalhesParcelamento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes do Parcelamento"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SubTabControlINSSAntigo.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.GroupBoxFimINSSantigo.ResumeLayout(False)
        Me.GroupBoxFimINSSantigo.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SubTabControlINSSNovo.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.GroupBoxFimINSSnovo.ResumeLayout(False)
        Me.GroupBoxFimINSSnovo.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.SubTabControlINSSProcuradoria.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.GroupBoxFimINSSProc.ResumeLayout(False)
        Me.GroupBoxFimINSSProc.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.SubTabControlMEI.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.GroupBoxFimMEI.ResumeLayout(False)
        Me.GroupBoxFimMEI.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents ParcelamentosTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CNPJLabel1 As Label
    Friend WithEvents RazaoSocialLabel1 As Label
    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataParcelINSSantigoDateTimePicker As DateTimePicker
    Friend WithEvents DataParcelINSSnovoDateTimePicker As DateTimePicker
    Friend WithEvents DataParcelINSSprocDateTimePicker As DateTimePicker
    Friend WithEvents INSSAntigoProtTextBox As TextBox
    Friend WithEvents INSSAntigoObsRichTextBox As RichTextBox
    Friend WithEvents INSSNovoObsRichTextBox As RichTextBox
    Friend WithEvents INSSNovoProtTextBox As TextBox
    Friend WithEvents INSSProcObsRichTextBox As RichTextBox
    Friend WithEvents INSSProcProtTextBox As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents SubTabControlINSSAntigo As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents HistoricoEnvioINSSAntigoRichTextBox As RichTextBox
    Friend WithEvents SubTabControlINSSNovo As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents HistoricoEnvioINSSNovoRichTextBox As RichTextBox
    Friend WithEvents SubTabControlINSSProcuradoria As TabControl
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents HistoricoEnvioINSSProcRichTextBox As RichTextBox
    Friend WithEvents FinalizadoINSSAntigoComboBox As ComboBox
    Friend WithEvents FinalizadoINSSNovoComboBox As ComboBox
    Friend WithEvents FinalizadoINSSProcComboBox As ComboBox
    Friend WithEvents MotivoParcINSSAntigoRichTextBox As RichTextBox
    Friend WithEvents MotivoParcINSSNovoRichTextBox As RichTextBox
    Friend WithEvents MotivoParcINSSProcRichTextBox As RichTextBox
    Friend WithEvents SubTabControlMEI As TabControl
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents GeralMEIRichTextBox As RichTextBox
    Friend WithEvents FinalizadoMEIComboBox As ComboBox
    Friend WithEvents DataParcMEIDateTimePicker As DateTimePicker
    Friend WithEvents MotivoParcMEIRichTextBox As RichTextBox
    Friend WithEvents MeiProtocoloTextBox As TextBox
    Friend WithEvents BtnRegistrarEnvioInssAntigo As Button
    Friend WithEvents BtnRegistrarEnvioInssNovo As Button
    Friend WithEvents BtnRegistrarEnvioInssProcuradoria As Button
    Friend WithEvents BtnRegistrarEnvioMEI As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataFimParcINSSAntigoDateTimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataFimParcINSSNovoDateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataFimParcMEIDateTimePicker As DateTimePicker
    Friend WithEvents GroupBoxFimINSSantigo As GroupBox
    Friend WithEvents GroupBoxFimINSSnovo As GroupBox
    Friend WithEvents GroupBoxFimINSSProc As GroupBox
    Friend WithEvents GroupBoxFimMEI As GroupBox
    Friend WithEvents MesEnviadoINSSAntigoDateTimePicker As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents LblFechamentoMesAntigo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents HistoricoEnvioMEIRichTextBox As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents MesEnviadoINSSNovoDateTimePicker As DateTimePicker
    Friend WithEvents MesEnviadoINSSProcDateTimePicker As DateTimePicker
    Friend WithEvents MesEnviadoMEIDateTimePicker As DateTimePicker
    Friend WithEvents GroupBoxMenu As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents DataFimParcINSSProcDateTimePicker As DateTimePicker
End Class
