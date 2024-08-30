<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCNAEEditar
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
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim GrauDeRiscoLabel As System.Windows.Forms.Label
        Dim GrauRiscoDesenqLabel As System.Windows.Forms.Label
        Dim CondicionanteLabel As System.Windows.Forms.Label
        Dim CNAELabel As System.Windows.Forms.Label
        Dim CNAELabel1 As System.Windows.Forms.Label
        Dim DescricaoLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCNAEEditar))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CNAEprefMaringaPRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CNAEprefMaringaPRTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CNAEprefMaringaPRTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.CNAEprefMaringaPRBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DescricaoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GrauDeRiscoTextBox = New System.Windows.Forms.TextBox()
        Me.GrauRiscoDesenqTextBox = New System.Windows.Forms.TextBox()
        Me.CondicionanteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CNAEMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BtnCadastro = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.DescricaoComboBox = New System.Windows.Forms.ComboBox()
        Me.CNAEComboBox = New System.Windows.Forms.ComboBox()
        DescricaoLabel = New System.Windows.Forms.Label()
        GrauDeRiscoLabel = New System.Windows.Forms.Label()
        GrauRiscoDesenqLabel = New System.Windows.Forms.Label()
        CondicionanteLabel = New System.Windows.Forms.Label()
        CNAELabel = New System.Windows.Forms.Label()
        CNAELabel1 = New System.Windows.Forms.Label()
        DescricaoLabel1 = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CNAEprefMaringaPRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CNAEprefMaringaPRBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CNAEprefMaringaPRBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.Location = New System.Drawing.Point(75, 122)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(80, 18)
        DescricaoLabel.TabIndex = 3
        DescricaoLabel.Text = "Descricao:"
        '
        'GrauDeRiscoLabel
        '
        GrauDeRiscoLabel.AutoSize = True
        GrauDeRiscoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrauDeRiscoLabel.Location = New System.Drawing.Point(44, 203)
        GrauDeRiscoLabel.Name = "GrauDeRiscoLabel"
        GrauDeRiscoLabel.Size = New System.Drawing.Size(111, 18)
        GrauDeRiscoLabel.TabIndex = 5
        GrauDeRiscoLabel.Text = "Grau De Risco:"
        '
        'GrauRiscoDesenqLabel
        '
        GrauRiscoDesenqLabel.AutoSize = True
        GrauRiscoDesenqLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrauRiscoDesenqLabel.Location = New System.Drawing.Point(12, 282)
        GrauRiscoDesenqLabel.Name = "GrauRiscoDesenqLabel"
        GrauRiscoDesenqLabel.Size = New System.Drawing.Size(143, 18)
        GrauRiscoDesenqLabel.TabIndex = 9
        GrauRiscoDesenqLabel.Text = "Grau Risco Desenq:"
        '
        'CondicionanteLabel
        '
        CondicionanteLabel.AutoSize = True
        CondicionanteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CondicionanteLabel.Location = New System.Drawing.Point(48, 233)
        CondicionanteLabel.Name = "CondicionanteLabel"
        CondicionanteLabel.Size = New System.Drawing.Size(107, 18)
        CondicionanteLabel.TabIndex = 10
        CondicionanteLabel.Text = "Condicionante:"
        '
        'CNAELabel
        '
        CNAELabel.AutoSize = True
        CNAELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNAELabel.Location = New System.Drawing.Point(102, 82)
        CNAELabel.Name = "CNAELabel"
        CNAELabel.Size = New System.Drawing.Size(53, 18)
        CNAELabel.TabIndex = 11
        CNAELabel.Text = "CNAE:"
        '
        'CNAELabel1
        '
        CNAELabel1.AutoSize = True
        CNAELabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNAELabel1.Location = New System.Drawing.Point(16, 31)
        CNAELabel1.Name = "CNAELabel1"
        CNAELabel1.Size = New System.Drawing.Size(99, 18)
        CNAELabel1.TabIndex = 16
        CNAELabel1.Text = "Busca CNAE:"
        '
        'DescricaoLabel1
        '
        DescricaoLabel1.AutoSize = True
        DescricaoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel1.Location = New System.Drawing.Point(251, 31)
        DescricaoLabel1.Name = "DescricaoLabel1"
        DescricaoLabel1.Size = New System.Drawing.Size(80, 18)
        DescricaoLabel1.TabIndex = 17
        DescricaoLabel1.Text = "Descricao:"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CNAEprefMaringaPRBindingSource
        '
        Me.CNAEprefMaringaPRBindingSource.DataMember = "CNAEprefMaringaPR"
        Me.CNAEprefMaringaPRBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'CNAEprefMaringaPRTableAdapter
        '
        Me.CNAEprefMaringaPRTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAEprefMaringaPRTableAdapter = Me.CNAEprefMaringaPRTableAdapter
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
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CNAEprefMaringaPRBindingNavigator
        '
        Me.CNAEprefMaringaPRBindingNavigator.AddNewItem = Nothing
        Me.CNAEprefMaringaPRBindingNavigator.BindingSource = Me.CNAEprefMaringaPRBindingSource
        Me.CNAEprefMaringaPRBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CNAEprefMaringaPRBindingNavigator.DeleteItem = Nothing
        Me.CNAEprefMaringaPRBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CNAEprefMaringaPRBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CNAEprefMaringaPRBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CNAEprefMaringaPRBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CNAEprefMaringaPRBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CNAEprefMaringaPRBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CNAEprefMaringaPRBindingNavigator.Name = "CNAEprefMaringaPRBindingNavigator"
        Me.CNAEprefMaringaPRBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CNAEprefMaringaPRBindingNavigator.Size = New System.Drawing.Size(924, 25)
        Me.CNAEprefMaringaPRBindingNavigator.TabIndex = 0
        Me.CNAEprefMaringaPRBindingNavigator.Text = "BindingNavigator1"
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
        'DescricaoRichTextBox
        '
        Me.DescricaoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CNAEprefMaringaPRBindingSource, "Descricao", True))
        Me.DescricaoRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoRichTextBox.Location = New System.Drawing.Point(161, 122)
        Me.DescricaoRichTextBox.Name = "DescricaoRichTextBox"
        Me.DescricaoRichTextBox.Size = New System.Drawing.Size(526, 72)
        Me.DescricaoRichTextBox.TabIndex = 4
        Me.DescricaoRichTextBox.Text = ""
        '
        'GrauDeRiscoTextBox
        '
        Me.GrauDeRiscoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CNAEprefMaringaPRBindingSource, "GrauDeRisco", True))
        Me.GrauDeRiscoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrauDeRiscoTextBox.Location = New System.Drawing.Point(161, 200)
        Me.GrauDeRiscoTextBox.Name = "GrauDeRiscoTextBox"
        Me.GrauDeRiscoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.GrauDeRiscoTextBox.TabIndex = 6
        '
        'GrauRiscoDesenqTextBox
        '
        Me.GrauRiscoDesenqTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CNAEprefMaringaPRBindingSource, "GrauRiscoDesenq", True))
        Me.GrauRiscoDesenqTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrauRiscoDesenqTextBox.Location = New System.Drawing.Point(161, 279)
        Me.GrauRiscoDesenqTextBox.Name = "GrauRiscoDesenqTextBox"
        Me.GrauRiscoDesenqTextBox.Size = New System.Drawing.Size(100, 24)
        Me.GrauRiscoDesenqTextBox.TabIndex = 10
        '
        'CondicionanteRichTextBox
        '
        Me.CondicionanteRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CNAEprefMaringaPRBindingSource, "Condicionante", True))
        Me.CondicionanteRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CondicionanteRichTextBox.Location = New System.Drawing.Point(161, 230)
        Me.CondicionanteRichTextBox.Name = "CondicionanteRichTextBox"
        Me.CondicionanteRichTextBox.Size = New System.Drawing.Size(511, 43)
        Me.CondicionanteRichTextBox.TabIndex = 11
        Me.CondicionanteRichTextBox.Text = ""
        '
        'CNAEMaskedTextBox
        '
        Me.CNAEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CNAEprefMaringaPRBindingSource, "CNAE", True))
        Me.CNAEMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNAEMaskedTextBox.Location = New System.Drawing.Point(161, 79)
        Me.CNAEMaskedTextBox.Mask = "0000-0/00"
        Me.CNAEMaskedTextBox.Name = "CNAEMaskedTextBox"
        Me.CNAEMaskedTextBox.Size = New System.Drawing.Size(81, 24)
        Me.CNAEMaskedTextBox.TabIndex = 12
        '
        'BtnCadastro
        '
        Me.BtnCadastro.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastro.Location = New System.Drawing.Point(757, 104)
        Me.BtnCadastro.Name = "BtnCadastro"
        Me.BtnCadastro.Size = New System.Drawing.Size(134, 36)
        Me.BtnCadastro.TabIndex = 13
        Me.BtnCadastro.Text = "Cadastrar"
        Me.BtnCadastro.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.Location = New System.Drawing.Point(757, 230)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(134, 36)
        Me.BtnExcluir.TabIndex = 14
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(757, 272)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(134, 36)
        Me.BtnFechar.TabIndex = 15
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(757, 188)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(134, 36)
        Me.BtnSalvar.TabIndex = 16
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(757, 146)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(134, 36)
        Me.BtnEditar.TabIndex = 19
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'DescricaoComboBox
        '
        Me.DescricaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DescricaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DescricaoComboBox.DataSource = Me.CNAEprefMaringaPRBindingSource
        Me.DescricaoComboBox.DisplayMember = "Descricao"
        Me.DescricaoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoComboBox.FormattingEnabled = True
        Me.DescricaoComboBox.Location = New System.Drawing.Point(337, 28)
        Me.DescricaoComboBox.Name = "DescricaoComboBox"
        Me.DescricaoComboBox.Size = New System.Drawing.Size(402, 26)
        Me.DescricaoComboBox.TabIndex = 20
        Me.DescricaoComboBox.ValueMember = "Descricao"
        '
        'CNAEComboBox
        '
        Me.CNAEComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CNAEComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CNAEComboBox.DataSource = Me.CNAEprefMaringaPRBindingSource
        Me.CNAEComboBox.DisplayMember = "CNAE"
        Me.CNAEComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNAEComboBox.FormattingEnabled = True
        Me.CNAEComboBox.Location = New System.Drawing.Point(121, 28)
        Me.CNAEComboBox.Name = "CNAEComboBox"
        Me.CNAEComboBox.Size = New System.Drawing.Size(121, 26)
        Me.CNAEComboBox.TabIndex = 21
        Me.CNAEComboBox.ValueMember = "CNAE"
        '
        'FrmCNAEEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(924, 334)
        Me.Controls.Add(Me.CNAEComboBox)
        Me.Controls.Add(Me.DescricaoComboBox)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(DescricaoLabel1)
        Me.Controls.Add(CNAELabel1)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnCadastro)
        Me.Controls.Add(CNAELabel)
        Me.Controls.Add(Me.CNAEMaskedTextBox)
        Me.Controls.Add(CondicionanteLabel)
        Me.Controls.Add(Me.CondicionanteRichTextBox)
        Me.Controls.Add(GrauRiscoDesenqLabel)
        Me.Controls.Add(Me.GrauRiscoDesenqTextBox)
        Me.Controls.Add(GrauDeRiscoLabel)
        Me.Controls.Add(Me.GrauDeRiscoTextBox)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoRichTextBox)
        Me.Controls.Add(Me.CNAEprefMaringaPRBindingNavigator)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCNAEEditar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle CNAE"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CNAEprefMaringaPRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CNAEprefMaringaPRBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CNAEprefMaringaPRBindingNavigator.ResumeLayout(False)
        Me.CNAEprefMaringaPRBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents CNAEprefMaringaPRBindingSource As BindingSource
    Friend WithEvents CNAEprefMaringaPRTableAdapter As PrinceDBDataSetTableAdapters.CNAEprefMaringaPRTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CNAEprefMaringaPRBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DescricaoRichTextBox As RichTextBox
    Friend WithEvents GrauDeRiscoTextBox As TextBox
    Friend WithEvents GrauRiscoDesenqTextBox As TextBox
    Friend WithEvents CondicionanteRichTextBox As RichTextBox
    Friend WithEvents CNAEMaskedTextBox As MaskedTextBox
    Friend WithEvents BtnCadastro As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents DescricaoComboBox As ComboBox
    Friend WithEvents CNAEComboBox As ComboBox
End Class
