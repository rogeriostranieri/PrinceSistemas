<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmParcelamentos
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
        Dim DataLembreteLabel As System.Windows.Forms.Label
        Dim DataCriacaoLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim RazaoSocialLabel1 As System.Windows.Forms.Label
        Dim CNPJLabel1 As System.Windows.Forms.Label
        Dim FormaEnvioLabel As System.Windows.Forms.Label
        Dim WhatsAppLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim RuaLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim DataEnvioLabel As System.Windows.Forms.Label
        Dim FinalizadoParcelamentosLabel As System.Windows.Forms.Label
        Dim SocioResponsavelLabel As System.Windows.Forms.Label
        Dim CPFsocioResponsavelLabel As System.Windows.Forms.Label
        Dim GovSenhaLabel As System.Windows.Forms.Label
        Dim NomeResponsavelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParcelamentos))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GroupBoxBusca = New System.Windows.Forms.GroupBox()
        Me.CNPJComboBox = New System.Windows.Forms.ComboBox()
        Me.RazaoSocialComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBoxDados = New System.Windows.Forms.GroupBox()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataEnvioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.BtnCopiarCNPJ = New System.Windows.Forms.Button()
        Me.BtnDuplicidade = New System.Windows.Forms.Button()
        Me.FinalizadoParcelamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.ObservacaoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataLembreteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataCriacaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.BtnVerDetalhesParcelamento = New System.Windows.Forms.Button()
        Me.GroupBoxINSSParcelamento = New System.Windows.Forms.GroupBox()
        Me.MEICheckBox = New System.Windows.Forms.CheckBox()
        Me.INSSProcuradoriaCheckBox = New System.Windows.Forms.CheckBox()
        Me.INSSNovoCheckBox = New System.Windows.Forms.CheckBox()
        Me.INSSAntigoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BtnImportaSocio = New System.Windows.Forms.Button()
        Me.NomeResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAbriremail = New System.Windows.Forms.Button()
        Me.BtnAbrirWhatsApp = New System.Windows.Forms.Button()
        Me.FormaEnvioComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WhatsAppTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GovSenhaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CPFsocioResponsavelMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SocioResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.BtnImportarSocioAdm = New System.Windows.Forms.Button()
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
        Me.BtnBImportarEmpresa = New System.Windows.Forms.Button()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        DataLembreteLabel = New System.Windows.Forms.Label()
        DataCriacaoLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        RazaoSocialLabel1 = New System.Windows.Forms.Label()
        CNPJLabel1 = New System.Windows.Forms.Label()
        FormaEnvioLabel = New System.Windows.Forms.Label()
        WhatsAppLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        RuaLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        DataEnvioLabel = New System.Windows.Forms.Label()
        FinalizadoParcelamentosLabel = New System.Windows.Forms.Label()
        SocioResponsavelLabel = New System.Windows.Forms.Label()
        CPFsocioResponsavelLabel = New System.Windows.Forms.Label()
        GovSenhaLabel = New System.Windows.Forms.Label()
        NomeResponsavelLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxMenu.SuspendLayout()
        Me.GroupBoxBusca.SuspendLayout()
        Me.GroupBoxDados.SuspendLayout()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxINSSParcelamento.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParcelamentosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(12, 15)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(101, 18)
        RazaoSocialLabel.TabIndex = 0
        RazaoSocialLabel.Text = "Razao Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(61, 45)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(52, 18)
        CNPJLabel.TabIndex = 2
        CNPJLabel.Text = "CNPJ:"
        '
        'DataLembreteLabel
        '
        DataLembreteLabel.AutoSize = True
        DataLembreteLabel.Location = New System.Drawing.Point(4, 105)
        DataLembreteLabel.Name = "DataLembreteLabel"
        DataLembreteLabel.Size = New System.Drawing.Size(109, 18)
        DataLembreteLabel.TabIndex = 4
        DataLembreteLabel.Text = "Data Lembrete:"
        '
        'DataCriacaoLabel
        '
        DataCriacaoLabel.AutoSize = True
        DataCriacaoLabel.Location = New System.Drawing.Point(14, 75)
        DataCriacaoLabel.Name = "DataCriacaoLabel"
        DataCriacaoLabel.Size = New System.Drawing.Size(99, 18)
        DataCriacaoLabel.TabIndex = 6
        DataCriacaoLabel.Text = "Data Criacao:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(13, 185)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(93, 18)
        ObservacaoLabel.TabIndex = 8
        ObservacaoLabel.Text = "Observacao:"
        '
        'RazaoSocialLabel1
        '
        RazaoSocialLabel1.AutoSize = True
        RazaoSocialLabel1.Location = New System.Drawing.Point(6, 31)
        RazaoSocialLabel1.Name = "RazaoSocialLabel1"
        RazaoSocialLabel1.Size = New System.Drawing.Size(107, 19)
        RazaoSocialLabel1.TabIndex = 0
        RazaoSocialLabel1.Text = "Razao Social:"
        '
        'CNPJLabel1
        '
        CNPJLabel1.AutoSize = True
        CNPJLabel1.Location = New System.Drawing.Point(456, 32)
        CNPJLabel1.Name = "CNPJLabel1"
        CNPJLabel1.Size = New System.Drawing.Size(53, 19)
        CNPJLabel1.TabIndex = 2
        CNPJLabel1.Text = "CNPJ:"
        '
        'FormaEnvioLabel
        '
        FormaEnvioLabel.AutoSize = True
        FormaEnvioLabel.Location = New System.Drawing.Point(20, 109)
        FormaEnvioLabel.Name = "FormaEnvioLabel"
        FormaEnvioLabel.Size = New System.Drawing.Size(97, 18)
        FormaEnvioLabel.TabIndex = 0
        FormaEnvioLabel.Text = "Forma Envio:"
        '
        'WhatsAppLabel
        '
        WhatsAppLabel.AutoSize = True
        WhatsAppLabel.Location = New System.Drawing.Point(33, 141)
        WhatsAppLabel.Name = "WhatsAppLabel"
        WhatsAppLabel.Size = New System.Drawing.Size(84, 18)
        WhatsAppLabel.TabIndex = 2
        WhatsAppLabel.Text = "Whats App:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(68, 176)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 18)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(6, 115)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(58, 18)
        CidadeLabel.TabIndex = 0
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(359, 115)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(59, 18)
        EstadoLabel.TabIndex = 2
        EstadoLabel.Text = "Estado:"
        '
        'RuaLabel
        '
        RuaLabel.AutoSize = True
        RuaLabel.Location = New System.Drawing.Point(25, 25)
        RuaLabel.Name = "RuaLabel"
        RuaLabel.Size = New System.Drawing.Size(39, 18)
        RuaLabel.TabIndex = 4
        RuaLabel.Text = "Rua:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(489, 25)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(66, 18)
        NumeroLabel.TabIndex = 6
        NumeroLabel.Text = "Numero:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(19, 55)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(106, 18)
        ComplementoLabel.TabIndex = 8
        ComplementoLabel.Text = "Complemento:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(12, 85)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(52, 18)
        BairroLabel.TabIndex = 10
        BairroLabel.Text = "Bairro:"
        '
        'DataEnvioLabel
        '
        DataEnvioLabel.AutoSize = True
        DataEnvioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataEnvioLabel.Location = New System.Drawing.Point(137, 367)
        DataEnvioLabel.Name = "DataEnvioLabel"
        DataEnvioLabel.Size = New System.Drawing.Size(102, 20)
        DataEnvioLabel.TabIndex = 15
        DataEnvioLabel.Text = "Data Envio:"
        '
        'FinalizadoParcelamentosLabel
        '
        FinalizadoParcelamentosLabel.AutoSize = True
        FinalizadoParcelamentosLabel.Location = New System.Drawing.Point(5, 156)
        FinalizadoParcelamentosLabel.Name = "FinalizadoParcelamentosLabel"
        FinalizadoParcelamentosLabel.Size = New System.Drawing.Size(204, 18)
        FinalizadoParcelamentosLabel.TabIndex = 16
        FinalizadoParcelamentosLabel.Text = "Finalizado os Parcelamentos:"
        '
        'SocioResponsavelLabel
        '
        SocioResponsavelLabel.AutoSize = True
        SocioResponsavelLabel.Location = New System.Drawing.Point(73, 38)
        SocioResponsavelLabel.Name = "SocioResponsavelLabel"
        SocioResponsavelLabel.Size = New System.Drawing.Size(53, 18)
        SocioResponsavelLabel.TabIndex = 0
        SocioResponsavelLabel.Text = "Nome:"
        '
        'CPFsocioResponsavelLabel
        '
        CPFsocioResponsavelLabel.AutoSize = True
        CPFsocioResponsavelLabel.Location = New System.Drawing.Point(84, 68)
        CPFsocioResponsavelLabel.Name = "CPFsocioResponsavelLabel"
        CPFsocioResponsavelLabel.Size = New System.Drawing.Size(42, 18)
        CPFsocioResponsavelLabel.TabIndex = 2
        CPFsocioResponsavelLabel.Text = "CPF:"
        '
        'GovSenhaLabel
        '
        GovSenhaLabel.AutoSize = True
        GovSenhaLabel.Location = New System.Drawing.Point(15, 98)
        GovSenhaLabel.Name = "GovSenhaLabel"
        GovSenhaLabel.Size = New System.Drawing.Size(111, 18)
        GovSenhaLabel.TabIndex = 4
        GovSenhaLabel.Text = "Senha Gov.BR:"
        '
        'NomeResponsavelLabel
        '
        NomeResponsavelLabel.AutoSize = True
        NomeResponsavelLabel.Location = New System.Drawing.Point(11, 50)
        NomeResponsavelLabel.Name = "NomeResponsavelLabel"
        NomeResponsavelLabel.Size = New System.Drawing.Size(164, 18)
        NomeResponsavelLabel.TabIndex = 68
        NomeResponsavelLabel.Text = "Nome do Responsável:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.34584!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65416!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenu, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxBusca, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxDados, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71004!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.28996!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 593)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxMenu
        '
        Me.GroupBoxMenu.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMenu.Controls.Add(Me.BtnFechar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnNovo)
        Me.GroupBoxMenu.Controls.Add(Me.BtnEditar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnSalvar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnExcluir)
        Me.GroupBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxMenu.Location = New System.Drawing.Point(732, 72)
        Me.GroupBoxMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxMenu.Size = New System.Drawing.Size(117, 518)
        Me.GroupBoxMenu.TabIndex = 57
        Me.GroupBoxMenu.TabStop = False
        '
        'BtnFechar
        '
        Me.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(8, 149)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(88, 27)
        Me.BtnFechar.TabIndex = 10
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
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
        'GroupBoxBusca
        '
        Me.GroupBoxBusca.Controls.Add(Me.CNPJComboBox)
        Me.GroupBoxBusca.Controls.Add(Me.RazaoSocialComboBox)
        Me.GroupBoxBusca.Controls.Add(CNPJLabel1)
        Me.GroupBoxBusca.Controls.Add(RazaoSocialLabel1)
        Me.GroupBoxBusca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxBusca.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBusca.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxBusca.Name = "GroupBoxBusca"
        Me.GroupBoxBusca.Size = New System.Drawing.Size(722, 63)
        Me.GroupBoxBusca.TabIndex = 58
        Me.GroupBoxBusca.TabStop = False
        Me.GroupBoxBusca.Text = "Buscar"
        '
        'CNPJComboBox
        '
        Me.CNPJComboBox.FormattingEnabled = True
        Me.CNPJComboBox.Location = New System.Drawing.Point(515, 29)
        Me.CNPJComboBox.Name = "CNPJComboBox"
        Me.CNPJComboBox.Size = New System.Drawing.Size(200, 27)
        Me.CNPJComboBox.TabIndex = 4
        '
        'RazaoSocialComboBox
        '
        Me.RazaoSocialComboBox.FormattingEnabled = True
        Me.RazaoSocialComboBox.Location = New System.Drawing.Point(119, 28)
        Me.RazaoSocialComboBox.Name = "RazaoSocialComboBox"
        Me.RazaoSocialComboBox.Size = New System.Drawing.Size(331, 27)
        Me.RazaoSocialComboBox.TabIndex = 3
        '
        'GroupBoxDados
        '
        Me.GroupBoxDados.Controls.Add(Me.TabControlPrincipal)
        Me.GroupBoxDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxDados.Location = New System.Drawing.Point(3, 72)
        Me.GroupBoxDados.Name = "GroupBoxDados"
        Me.GroupBoxDados.Size = New System.Drawing.Size(722, 518)
        Me.GroupBoxDados.TabIndex = 59
        Me.GroupBoxDados.TabStop = False
        Me.GroupBoxDados.Text = "Dados da Empresa"
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlPrincipal.Controls.Add(Me.TabPage3)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage4)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage5)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage6)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipal.Location = New System.Drawing.Point(3, 20)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(716, 495)
        Me.TabControlPrincipal.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.BtnBImportarEmpresa)
        Me.TabPage3.Controls.Add(Me.DataEnvioDateTimePicker)
        Me.TabPage3.Controls.Add(Me.BtnCopiarCNPJ)
        Me.TabPage3.Controls.Add(Me.BtnDuplicidade)
        Me.TabPage3.Controls.Add(Me.FinalizadoParcelamentoComboBox)
        Me.TabPage3.Controls.Add(Me.ObservacaoRichTextBox)
        Me.TabPage3.Controls.Add(Me.DataLembreteDateTimePicker)
        Me.TabPage3.Controls.Add(Me.DataCriacaoDateTimePicker)
        Me.TabPage3.Controls.Add(Me.CNPJMaskedTextBox)
        Me.TabPage3.Controls.Add(Me.RazaoSocialTextBox)
        Me.TabPage3.Controls.Add(FinalizadoParcelamentosLabel)
        Me.TabPage3.Controls.Add(DataEnvioLabel)
        Me.TabPage3.Controls.Add(Me.BtnVerDetalhesParcelamento)
        Me.TabPage3.Controls.Add(Me.GroupBoxINSSParcelamento)
        Me.TabPage3.Controls.Add(RazaoSocialLabel)
        Me.TabPage3.Controls.Add(ObservacaoLabel)
        Me.TabPage3.Controls.Add(DataCriacaoLabel)
        Me.TabPage3.Controls.Add(CNPJLabel)
        Me.TabPage3.Controls.Add(DataLembreteLabel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(708, 461)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Geral"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataEnvioDateTimePicker
        '
        Me.DataEnvioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataEnvio", True))
        Me.DataEnvioDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DataEnvioDateTimePicker.Location = New System.Drawing.Point(243, 362)
        Me.DataEnvioDateTimePicker.Name = "DataEnvioDateTimePicker"
        Me.DataEnvioDateTimePicker.Size = New System.Drawing.Size(378, 26)
        Me.DataEnvioDateTimePicker.TabIndex = 68
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
        'BtnCopiarCNPJ
        '
        Me.BtnCopiarCNPJ.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiarCNPJ.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnCopiarCNPJ.FlatAppearance.BorderSize = 2
        Me.BtnCopiarCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiarCNPJ.Location = New System.Drawing.Point(388, 40)
        Me.BtnCopiarCNPJ.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiarCNPJ.Name = "BtnCopiarCNPJ"
        Me.BtnCopiarCNPJ.Size = New System.Drawing.Size(114, 29)
        Me.BtnCopiarCNPJ.TabIndex = 67
        Me.BtnCopiarCNPJ.Text = "Copiar CNPJ"
        Me.BtnCopiarCNPJ.UseVisualStyleBackColor = False
        '
        'BtnDuplicidade
        '
        Me.BtnDuplicidade.BackColor = System.Drawing.Color.Azure
        Me.BtnDuplicidade.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnDuplicidade.FlatAppearance.BorderSize = 2
        Me.BtnDuplicidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDuplicidade.Location = New System.Drawing.Point(271, 40)
        Me.BtnDuplicidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnDuplicidade.Name = "BtnDuplicidade"
        Me.BtnDuplicidade.Size = New System.Drawing.Size(114, 29)
        Me.BtnDuplicidade.TabIndex = 66
        Me.BtnDuplicidade.Text = "Verifica CNPJ"
        Me.BtnDuplicidade.UseVisualStyleBackColor = False
        '
        'FinalizadoParcelamentoComboBox
        '
        Me.FinalizadoParcelamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FinalizadoParcelamento", True))
        Me.FinalizadoParcelamentoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalizadoParcelamentoComboBox.FormattingEnabled = True
        Me.FinalizadoParcelamentoComboBox.Items.AddRange(New Object() {"Em Andamento", "Não Realizado", "Cancelado", "Indeferido", "Para Fazer", "Aguardando Cliente"})
        Me.FinalizadoParcelamentoComboBox.Location = New System.Drawing.Point(215, 153)
        Me.FinalizadoParcelamentoComboBox.Name = "FinalizadoParcelamentoComboBox"
        Me.FinalizadoParcelamentoComboBox.Size = New System.Drawing.Size(228, 28)
        Me.FinalizadoParcelamentoComboBox.TabIndex = 26
        '
        'ObservacaoRichTextBox
        '
        Me.ObservacaoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Observacao", True))
        Me.ObservacaoRichTextBox.Location = New System.Drawing.Point(112, 185)
        Me.ObservacaoRichTextBox.Name = "ObservacaoRichTextBox"
        Me.ObservacaoRichTextBox.Size = New System.Drawing.Size(577, 96)
        Me.ObservacaoRichTextBox.TabIndex = 24
        Me.ObservacaoRichTextBox.Text = ""
        '
        'DataLembreteDateTimePicker
        '
        Me.DataLembreteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataLembrete", True))
        Me.DataLembreteDateTimePicker.Location = New System.Drawing.Point(119, 102)
        Me.DataLembreteDateTimePicker.Name = "DataLembreteDateTimePicker"
        Me.DataLembreteDateTimePicker.Size = New System.Drawing.Size(324, 24)
        Me.DataLembreteDateTimePicker.TabIndex = 23
        '
        'DataCriacaoDateTimePicker
        '
        Me.DataCriacaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParcelamentosBindingSource, "DataCriacao", True))
        Me.DataCriacaoDateTimePicker.Location = New System.Drawing.Point(119, 72)
        Me.DataCriacaoDateTimePicker.Name = "DataCriacaoDateTimePicker"
        Me.DataCriacaoDateTimePicker.Size = New System.Drawing.Size(324, 24)
        Me.DataCriacaoDateTimePicker.TabIndex = 22
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(119, 42)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(145, 24)
        Me.CNPJMaskedTextBox.TabIndex = 21
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(119, 12)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(577, 24)
        Me.RazaoSocialTextBox.TabIndex = 20
        '
        'BtnVerDetalhesParcelamento
        '
        Me.BtnVerDetalhesParcelamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVerDetalhesParcelamento.FlatAppearance.BorderSize = 5
        Me.BtnVerDetalhesParcelamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerDetalhesParcelamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerDetalhesParcelamento.Location = New System.Drawing.Point(200, 394)
        Me.BtnVerDetalhesParcelamento.Name = "BtnVerDetalhesParcelamento"
        Me.BtnVerDetalhesParcelamento.Size = New System.Drawing.Size(309, 58)
        Me.BtnVerDetalhesParcelamento.TabIndex = 15
        Me.BtnVerDetalhesParcelamento.Text = "Detalhes dos parcelamentos"
        Me.BtnVerDetalhesParcelamento.UseVisualStyleBackColor = True
        '
        'GroupBoxINSSParcelamento
        '
        Me.GroupBoxINSSParcelamento.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBoxINSSParcelamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxINSSParcelamento.Controls.Add(Me.MEICheckBox)
        Me.GroupBoxINSSParcelamento.Controls.Add(Me.INSSProcuradoriaCheckBox)
        Me.GroupBoxINSSParcelamento.Controls.Add(Me.INSSNovoCheckBox)
        Me.GroupBoxINSSParcelamento.Controls.Add(Me.INSSAntigoCheckBox)
        Me.GroupBoxINSSParcelamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxINSSParcelamento.Location = New System.Drawing.Point(0, 284)
        Me.GroupBoxINSSParcelamento.Name = "GroupBoxINSSParcelamento"
        Me.GroupBoxINSSParcelamento.Size = New System.Drawing.Size(708, 64)
        Me.GroupBoxINSSParcelamento.TabIndex = 14
        Me.GroupBoxINSSParcelamento.TabStop = False
        Me.GroupBoxINSSParcelamento.Text = "Parcelamentos em andamento"
        '
        'MEICheckBox
        '
        Me.MEICheckBox.BackColor = System.Drawing.Color.Transparent
        Me.MEICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "MEI", True))
        Me.MEICheckBox.Location = New System.Drawing.Point(576, 26)
        Me.MEICheckBox.Name = "MEICheckBox"
        Me.MEICheckBox.Size = New System.Drawing.Size(56, 24)
        Me.MEICheckBox.TabIndex = 4
        Me.MEICheckBox.Text = "MEI"
        Me.MEICheckBox.UseVisualStyleBackColor = False
        '
        'INSSProcuradoriaCheckBox
        '
        Me.INSSProcuradoriaCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.INSSProcuradoriaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "INSSProcuradoria", True))
        Me.INSSProcuradoriaCheckBox.Location = New System.Drawing.Point(356, 26)
        Me.INSSProcuradoriaCheckBox.Name = "INSSProcuradoriaCheckBox"
        Me.INSSProcuradoriaCheckBox.Size = New System.Drawing.Size(173, 24)
        Me.INSSProcuradoriaCheckBox.TabIndex = 3
        Me.INSSProcuradoriaCheckBox.Text = "INSS Procuradoria"
        Me.INSSProcuradoriaCheckBox.UseVisualStyleBackColor = False
        '
        'INSSNovoCheckBox
        '
        Me.INSSNovoCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.INSSNovoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "INSSNovo", True))
        Me.INSSNovoCheckBox.Location = New System.Drawing.Point(195, 26)
        Me.INSSNovoCheckBox.Name = "INSSNovoCheckBox"
        Me.INSSNovoCheckBox.Size = New System.Drawing.Size(125, 24)
        Me.INSSNovoCheckBox.TabIndex = 2
        Me.INSSNovoCheckBox.Text = "INSS Novo"
        Me.INSSNovoCheckBox.UseVisualStyleBackColor = False
        '
        'INSSAntigoCheckBox
        '
        Me.INSSAntigoCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.INSSAntigoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ParcelamentosBindingSource, "INSSAntigo", True))
        Me.INSSAntigoCheckBox.Location = New System.Drawing.Point(37, 26)
        Me.INSSAntigoCheckBox.Name = "INSSAntigoCheckBox"
        Me.INSSAntigoCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.INSSAntigoCheckBox.TabIndex = 1
        Me.INSSAntigoCheckBox.Text = "INSS Antigo"
        Me.INSSAntigoCheckBox.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.BairroTextBox)
        Me.TabPage4.Controls.Add(Me.ComplementoTextBox)
        Me.TabPage4.Controls.Add(Me.NumeroTextBox)
        Me.TabPage4.Controls.Add(Me.RuaTextBox)
        Me.TabPage4.Controls.Add(Me.EstadoTextBox)
        Me.TabPage4.Controls.Add(Me.CidadeTextBox)
        Me.TabPage4.Controls.Add(BairroLabel)
        Me.TabPage4.Controls.Add(ComplementoLabel)
        Me.TabPage4.Controls.Add(NumeroLabel)
        Me.TabPage4.Controls.Add(RuaLabel)
        Me.TabPage4.Controls.Add(EstadoLabel)
        Me.TabPage4.Controls.Add(CidadeLabel)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(708, 465)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Endereço"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(70, 82)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(413, 24)
        Me.BairroTextBox.TabIndex = 23
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(131, 52)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(352, 24)
        Me.ComplementoTextBox.TabIndex = 21
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(561, 22)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 24)
        Me.NumeroTextBox.TabIndex = 19
        '
        'RuaTextBox
        '
        Me.RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Rua", True))
        Me.RuaTextBox.Location = New System.Drawing.Point(70, 22)
        Me.RuaTextBox.Name = "RuaTextBox"
        Me.RuaTextBox.Size = New System.Drawing.Size(413, 24)
        Me.RuaTextBox.TabIndex = 17
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(424, 112)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(59, 24)
        Me.EstadoTextBox.TabIndex = 15
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(70, 112)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(283, 24)
        Me.CidadeTextBox.TabIndex = 13
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.BtnImportaSocio)
        Me.TabPage5.Controls.Add(NomeResponsavelLabel)
        Me.TabPage5.Controls.Add(Me.NomeResponsavelTextBox)
        Me.TabPage5.Controls.Add(Me.BtnAbriremail)
        Me.TabPage5.Controls.Add(Me.BtnAbrirWhatsApp)
        Me.TabPage5.Controls.Add(Me.FormaEnvioComboBox)
        Me.TabPage5.Controls.Add(Me.EmailTextBox)
        Me.TabPage5.Controls.Add(Me.WhatsAppTextBox)
        Me.TabPage5.Controls.Add(EmailLabel)
        Me.TabPage5.Controls.Add(WhatsAppLabel)
        Me.TabPage5.Controls.Add(FormaEnvioLabel)
        Me.TabPage5.Location = New System.Drawing.Point(4, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(708, 465)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Formar de Envio"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'BtnImportaSocio
        '
        Me.BtnImportaSocio.BackColor = System.Drawing.Color.Azure
        Me.BtnImportaSocio.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnImportaSocio.FlatAppearance.BorderSize = 2
        Me.BtnImportaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportaSocio.Location = New System.Drawing.Point(542, 45)
        Me.BtnImportaSocio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnImportaSocio.Name = "BtnImportaSocio"
        Me.BtnImportaSocio.Size = New System.Drawing.Size(135, 29)
        Me.BtnImportaSocio.TabIndex = 70
        Me.BtnImportaSocio.Text = "Importar Socio"
        Me.BtnImportaSocio.UseVisualStyleBackColor = False
        '
        'NomeResponsavelTextBox
        '
        Me.NomeResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "NomeResponsavel", True))
        Me.NomeResponsavelTextBox.Location = New System.Drawing.Point(181, 47)
        Me.NomeResponsavelTextBox.Name = "NomeResponsavelTextBox"
        Me.NomeResponsavelTextBox.Size = New System.Drawing.Size(354, 24)
        Me.NomeResponsavelTextBox.TabIndex = 69
        '
        'BtnAbriremail
        '
        Me.BtnAbriremail.BackColor = System.Drawing.Color.Azure
        Me.BtnAbriremail.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAbriremail.FlatAppearance.BorderSize = 2
        Me.BtnAbriremail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbriremail.Location = New System.Drawing.Point(543, 171)
        Me.BtnAbriremail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAbriremail.Name = "BtnAbriremail"
        Me.BtnAbriremail.Size = New System.Drawing.Size(135, 29)
        Me.BtnAbriremail.TabIndex = 68
        Me.BtnAbriremail.Text = "Abrir e-Mail"
        Me.BtnAbriremail.UseVisualStyleBackColor = False
        '
        'BtnAbrirWhatsApp
        '
        Me.BtnAbrirWhatsApp.BackColor = System.Drawing.Color.Azure
        Me.BtnAbrirWhatsApp.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnAbrirWhatsApp.FlatAppearance.BorderSize = 2
        Me.BtnAbrirWhatsApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrirWhatsApp.Location = New System.Drawing.Point(542, 136)
        Me.BtnAbrirWhatsApp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAbrirWhatsApp.Name = "BtnAbrirWhatsApp"
        Me.BtnAbrirWhatsApp.Size = New System.Drawing.Size(135, 29)
        Me.BtnAbrirWhatsApp.TabIndex = 67
        Me.BtnAbrirWhatsApp.Text = "Abrir WhatsApp"
        Me.BtnAbrirWhatsApp.UseVisualStyleBackColor = False
        '
        'FormaEnvioComboBox
        '
        Me.FormaEnvioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "FormaEnvio", True))
        Me.FormaEnvioComboBox.FormattingEnabled = True
        Me.FormaEnvioComboBox.Items.AddRange(New Object() {"Whatsapp", "e-Mail", "Presencial"})
        Me.FormaEnvioComboBox.Location = New System.Drawing.Point(123, 106)
        Me.FormaEnvioComboBox.Name = "FormaEnvioComboBox"
        Me.FormaEnvioComboBox.Size = New System.Drawing.Size(157, 26)
        Me.FormaEnvioComboBox.TabIndex = 11
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(123, 173)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(413, 24)
        Me.EmailTextBox.TabIndex = 9
        '
        'WhatsAppTextBox
        '
        Me.WhatsAppTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "WhatsApp", True))
        Me.WhatsAppTextBox.Location = New System.Drawing.Point(123, 138)
        Me.WhatsAppTextBox.Name = "WhatsAppTextBox"
        Me.WhatsAppTextBox.Size = New System.Drawing.Size(413, 24)
        Me.WhatsAppTextBox.TabIndex = 7
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.GovSenhaMaskedTextBox)
        Me.TabPage6.Controls.Add(Me.CPFsocioResponsavelMaskedTextBox)
        Me.TabPage6.Controls.Add(Me.SocioResponsavelTextBox)
        Me.TabPage6.Controls.Add(Me.BtnImportarSocioAdm)
        Me.TabPage6.Controls.Add(GovSenhaLabel)
        Me.TabPage6.Controls.Add(CPFsocioResponsavelLabel)
        Me.TabPage6.Controls.Add(SocioResponsavelLabel)
        Me.TabPage6.Location = New System.Drawing.Point(4, 30)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(708, 465)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Sócio/Responsável"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GovSenhaMaskedTextBox
        '
        Me.GovSenhaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "GovSenha", True))
        Me.GovSenhaMaskedTextBox.Location = New System.Drawing.Point(132, 95)
        Me.GovSenhaMaskedTextBox.Name = "GovSenhaMaskedTextBox"
        Me.GovSenhaMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.GovSenhaMaskedTextBox.Size = New System.Drawing.Size(214, 24)
        Me.GovSenhaMaskedTextBox.TabIndex = 12
        '
        'CPFsocioResponsavelMaskedTextBox
        '
        Me.CPFsocioResponsavelMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "CPFsocioResponsavel", True))
        Me.CPFsocioResponsavelMaskedTextBox.Location = New System.Drawing.Point(132, 65)
        Me.CPFsocioResponsavelMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFsocioResponsavelMaskedTextBox.Name = "CPFsocioResponsavelMaskedTextBox"
        Me.CPFsocioResponsavelMaskedTextBox.Size = New System.Drawing.Size(123, 24)
        Me.CPFsocioResponsavelMaskedTextBox.TabIndex = 10
        '
        'SocioResponsavelTextBox
        '
        Me.SocioResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosBindingSource, "SocioResponsavel", True))
        Me.SocioResponsavelTextBox.Location = New System.Drawing.Point(132, 35)
        Me.SocioResponsavelTextBox.Name = "SocioResponsavelTextBox"
        Me.SocioResponsavelTextBox.Size = New System.Drawing.Size(370, 24)
        Me.SocioResponsavelTextBox.TabIndex = 9
        '
        'BtnImportarSocioAdm
        '
        Me.BtnImportarSocioAdm.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnImportarSocioAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImportarSocioAdm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnImportarSocioAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnImportarSocioAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportarSocioAdm.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnImportarSocioAdm.Location = New System.Drawing.Point(562, 19)
        Me.BtnImportarSocioAdm.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnImportarSocioAdm.Name = "BtnImportarSocioAdm"
        Me.BtnImportarSocioAdm.Size = New System.Drawing.Size(128, 57)
        Me.BtnImportarSocioAdm.TabIndex = 8
        Me.BtnImportarSocioAdm.Text = "Adicionar/Abrir Socio"
        Me.BtnImportarSocioAdm.UseVisualStyleBackColor = True
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
        Me.ParcelamentosBindingNavigator.Size = New System.Drawing.Size(853, 25)
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
        'BtnBImportarEmpresa
        '
        Me.BtnBImportarEmpresa.BackColor = System.Drawing.Color.Azure
        Me.BtnBImportarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnBImportarEmpresa.FlatAppearance.BorderSize = 2
        Me.BtnBImportarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBImportarEmpresa.Location = New System.Drawing.Point(605, 42)
        Me.BtnBImportarEmpresa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBImportarEmpresa.Name = "BtnBImportarEmpresa"
        Me.BtnBImportarEmpresa.Size = New System.Drawing.Size(91, 29)
        Me.BtnBImportarEmpresa.TabIndex = 69
        Me.BtnBImportarEmpresa.Text = "Importar"
        Me.BtnBImportarEmpresa.UseVisualStyleBackColor = False
        '
        'FrmParcelamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnFechar
        Me.ClientSize = New System.Drawing.Size(853, 593)
        Me.Controls.Add(Me.ParcelamentosBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmParcelamentos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Parcelamentos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.GroupBoxBusca.ResumeLayout(False)
        Me.GroupBoxBusca.PerformLayout()
        Me.GroupBoxDados.ResumeLayout(False)
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxINSSParcelamento.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.ParcelamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParcelamentosBindingNavigator.ResumeLayout(False)
        Me.ParcelamentosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxMenu As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GroupBoxBusca As GroupBox
    Friend WithEvents GroupBoxDados As GroupBox
    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBoxINSSParcelamento As GroupBox
    Friend WithEvents BtnVerDetalhesParcelamento As Button
    Friend WithEvents RazaoSocialComboBox As ComboBox
    Friend WithEvents CNPJComboBox As ComboBox
    Friend WithEvents BtnImportarSocioAdm As Button
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
    Friend WithEvents DataLembreteDateTimePicker As DateTimePicker
    Friend WithEvents DataCriacaoDateTimePicker As DateTimePicker
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents ObservacaoRichTextBox As RichTextBox
    Friend WithEvents MEICheckBox As CheckBox
    Friend WithEvents INSSProcuradoriaCheckBox As CheckBox
    Friend WithEvents INSSNovoCheckBox As CheckBox
    Friend WithEvents INSSAntigoCheckBox As CheckBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents RuaTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents FormaEnvioComboBox As ComboBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents WhatsAppTextBox As TextBox
    Friend WithEvents SocioResponsavelTextBox As TextBox
    Friend WithEvents GovSenhaMaskedTextBox As MaskedTextBox
    Friend WithEvents CPFsocioResponsavelMaskedTextBox As MaskedTextBox
    Friend WithEvents FinalizadoParcelamentoComboBox As ComboBox
    Friend WithEvents BtnDuplicidade As Button
    Friend WithEvents BtnCopiarCNPJ As Button
    Friend WithEvents BtnAbrirWhatsApp As Button
    Friend WithEvents BtnAbriremail As Button
    Friend WithEvents NomeResponsavelTextBox As TextBox
    Friend WithEvents BtnImportaSocio As Button
    Friend WithEvents DataEnvioDateTimePicker As DateTimePicker
    Friend WithEvents BtnBImportarEmpresa As Button
End Class
