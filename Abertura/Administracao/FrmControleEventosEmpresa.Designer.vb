<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmControleEventosEmpresa
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
        Dim EventosLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim EventosLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim EventosLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControleEventosEmpresa))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxMeio = New System.Windows.Forms.GroupBox()
        Me.EventosEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.PrefeituraMunicipalCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReceitaEstadualCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReceitaFederalCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmpresaFacilCheckBox = New System.Windows.Forms.CheckBox()
        Me.EventosTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBoxTopo = New System.Windows.Forms.GroupBox()
        Me.PrefeituraMunicipal = New System.Windows.Forms.CheckBox()
        Me.ReceitaEstadual = New System.Windows.Forms.CheckBox()
        Me.ReceitaFederal = New System.Windows.Forms.CheckBox()
        Me.EmpresaFacil = New System.Windows.Forms.CheckBox()
        Me.EventosEmpresaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventosTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EventosComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.EventosEmpresaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EventosEmpresaTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        EventosLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        EventosLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        EventosLabel2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxMeio.SuspendLayout()
        CType(Me.EventosEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTopo.SuspendLayout()
        CType(Me.EventosEmpresaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventosLabel
        '
        EventosLabel.AutoSize = True
        EventosLabel.BackColor = System.Drawing.Color.Transparent
        EventosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EventosLabel.Location = New System.Drawing.Point(9, 311)
        EventosLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EventosLabel.Name = "EventosLabel"
        EventosLabel.Size = New System.Drawing.Size(111, 16)
        EventosLabel.TabIndex = 44
        EventosLabel.Text = "Nome do Evento:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(11, 101)
        Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(244, 18)
        Label5.TabIndex = 46
        Label5.Text = "Orgãos Governal Responsável:"
        '
        'EventosLabel1
        '
        EventosLabel1.AutoSize = True
        EventosLabel1.BackColor = System.Drawing.Color.Transparent
        EventosLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EventosLabel1.Location = New System.Drawing.Point(10, 43)
        EventosLabel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EventosLabel1.Name = "EventosLabel1"
        EventosLabel1.Size = New System.Drawing.Size(125, 20)
        EventosLabel1.TabIndex = 53
        EventosLabel1.Text = "Filtar Eventos:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(11, 19)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 18)
        Label2.TabIndex = 47
        Label2.Text = "Cadastro"
        '
        'EventosLabel2
        '
        EventosLabel2.AutoSize = True
        EventosLabel2.Location = New System.Drawing.Point(11, 49)
        EventosLabel2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EventosLabel2.Name = "EventosLabel2"
        EventosLabel2.Size = New System.Drawing.Size(111, 16)
        EventosLabel2.TabIndex = 47
        EventosLabel2.Text = "Nome do Evento:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMeio, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxTopo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenu, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(913, 531)
        Me.TableLayoutPanel1.TabIndex = 61
        '
        'GroupBoxMeio
        '
        Me.GroupBoxMeio.AutoSize = True
        Me.GroupBoxMeio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxMeio.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMeio.Controls.Add(Me.PrefeituraMunicipalCheckBox)
        Me.GroupBoxMeio.Controls.Add(Me.ReceitaEstadualCheckBox)
        Me.GroupBoxMeio.Controls.Add(Me.ReceitaFederalCheckBox)
        Me.GroupBoxMeio.Controls.Add(Me.EmpresaFacilCheckBox)
        Me.GroupBoxMeio.Controls.Add(EventosLabel2)
        Me.GroupBoxMeio.Controls.Add(Me.EventosTextBox1)
        Me.GroupBoxMeio.Controls.Add(Label2)
        Me.GroupBoxMeio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMeio.Location = New System.Drawing.Point(5, 360)
        Me.GroupBoxMeio.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBoxMeio.Name = "GroupBoxMeio"
        Me.GroupBoxMeio.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBoxMeio.Size = New System.Drawing.Size(782, 195)
        Me.GroupBoxMeio.TabIndex = 61
        Me.GroupBoxMeio.TabStop = False
        '
        'EventosEmpresaBindingSource
        '
        Me.EventosEmpresaBindingSource.DataMember = "EventosEmpresa"
        Me.EventosEmpresaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrefeituraMunicipalCheckBox
        '
        Me.PrefeituraMunicipalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "PrefeituraMunicipal", True))
        Me.PrefeituraMunicipalCheckBox.Location = New System.Drawing.Point(632, 136)
        Me.PrefeituraMunicipalCheckBox.Name = "PrefeituraMunicipalCheckBox"
        Me.PrefeituraMunicipalCheckBox.Size = New System.Drawing.Size(141, 26)
        Me.PrefeituraMunicipalCheckBox.TabIndex = 52
        Me.PrefeituraMunicipalCheckBox.Text = "Prefeitura Municipal"
        Me.PrefeituraMunicipalCheckBox.UseVisualStyleBackColor = True
        '
        'ReceitaEstadualCheckBox
        '
        Me.ReceitaEstadualCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "ReceitaEstadual", True))
        Me.ReceitaEstadualCheckBox.Location = New System.Drawing.Point(632, 104)
        Me.ReceitaEstadualCheckBox.Name = "ReceitaEstadualCheckBox"
        Me.ReceitaEstadualCheckBox.Size = New System.Drawing.Size(141, 26)
        Me.ReceitaEstadualCheckBox.TabIndex = 51
        Me.ReceitaEstadualCheckBox.Text = "Receita Estadual"
        Me.ReceitaEstadualCheckBox.UseVisualStyleBackColor = True
        '
        'ReceitaFederalCheckBox
        '
        Me.ReceitaFederalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "ReceitaFederal", True))
        Me.ReceitaFederalCheckBox.Location = New System.Drawing.Point(632, 72)
        Me.ReceitaFederalCheckBox.Name = "ReceitaFederalCheckBox"
        Me.ReceitaFederalCheckBox.Size = New System.Drawing.Size(141, 26)
        Me.ReceitaFederalCheckBox.TabIndex = 50
        Me.ReceitaFederalCheckBox.Text = "Receita Federal"
        Me.ReceitaFederalCheckBox.UseVisualStyleBackColor = True
        '
        'EmpresaFacilCheckBox
        '
        Me.EmpresaFacilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "EmpresaFacil", True))
        Me.EmpresaFacilCheckBox.Location = New System.Drawing.Point(632, 40)
        Me.EmpresaFacilCheckBox.Name = "EmpresaFacilCheckBox"
        Me.EmpresaFacilCheckBox.Size = New System.Drawing.Size(141, 26)
        Me.EmpresaFacilCheckBox.TabIndex = 49
        Me.EmpresaFacilCheckBox.Text = "Empresa Fácil"
        Me.EmpresaFacilCheckBox.UseVisualStyleBackColor = True
        '
        'EventosTextBox1
        '
        Me.EventosTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventosEmpresaBindingSource, "Eventos", True))
        Me.EventosTextBox1.Location = New System.Drawing.Point(130, 46)
        Me.EventosTextBox1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.EventosTextBox1.Name = "EventosTextBox1"
        Me.EventosTextBox1.Size = New System.Drawing.Size(480, 22)
        Me.EventosTextBox1.TabIndex = 48
        '
        'GroupBoxTopo
        '
        Me.GroupBoxTopo.AutoSize = True
        Me.GroupBoxTopo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxTopo.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTopo.Controls.Add(Me.PrefeituraMunicipal)
        Me.GroupBoxTopo.Controls.Add(Me.ReceitaEstadual)
        Me.GroupBoxTopo.Controls.Add(Me.ReceitaFederal)
        Me.GroupBoxTopo.Controls.Add(Me.EmpresaFacil)
        Me.GroupBoxTopo.Controls.Add(EventosLabel)
        Me.GroupBoxTopo.Controls.Add(Me.EventosEmpresaDataGridView)
        Me.GroupBoxTopo.Controls.Add(Me.EventosTextBox)
        Me.GroupBoxTopo.Controls.Add(Me.Label1)
        Me.GroupBoxTopo.Controls.Add(Me.EventosComboBox)
        Me.GroupBoxTopo.Controls.Add(Label5)
        Me.GroupBoxTopo.Controls.Add(EventosLabel1)
        Me.GroupBoxTopo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxTopo.Location = New System.Drawing.Point(5, 3)
        Me.GroupBoxTopo.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBoxTopo.Name = "GroupBoxTopo"
        Me.GroupBoxTopo.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBoxTopo.Size = New System.Drawing.Size(782, 351)
        Me.GroupBoxTopo.TabIndex = 61
        Me.GroupBoxTopo.TabStop = False
        '
        'PrefeituraMunicipal
        '
        Me.PrefeituraMunicipal.AutoSize = True
        Me.PrefeituraMunicipal.Location = New System.Drawing.Point(416, 122)
        Me.PrefeituraMunicipal.Name = "PrefeituraMunicipal"
        Me.PrefeituraMunicipal.Size = New System.Drawing.Size(143, 20)
        Me.PrefeituraMunicipal.TabIndex = 64
        Me.PrefeituraMunicipal.Text = "Prefeitura Municipal"
        Me.PrefeituraMunicipal.UseVisualStyleBackColor = True
        '
        'ReceitaEstadual
        '
        Me.ReceitaEstadual.AutoSize = True
        Me.ReceitaEstadual.Location = New System.Drawing.Point(273, 122)
        Me.ReceitaEstadual.Name = "ReceitaEstadual"
        Me.ReceitaEstadual.Size = New System.Drawing.Size(129, 20)
        Me.ReceitaEstadual.TabIndex = 63
        Me.ReceitaEstadual.Text = "Receita Estadual"
        Me.ReceitaEstadual.UseVisualStyleBackColor = True
        '
        'ReceitaFederal
        '
        Me.ReceitaFederal.AutoSize = True
        Me.ReceitaFederal.Location = New System.Drawing.Point(137, 122)
        Me.ReceitaFederal.Name = "ReceitaFederal"
        Me.ReceitaFederal.Size = New System.Drawing.Size(123, 20)
        Me.ReceitaFederal.TabIndex = 62
        Me.ReceitaFederal.Text = "Receita Federal"
        Me.ReceitaFederal.UseVisualStyleBackColor = True
        '
        'EmpresaFacil
        '
        Me.EmpresaFacil.AutoSize = True
        Me.EmpresaFacil.Location = New System.Drawing.Point(10, 122)
        Me.EmpresaFacil.Name = "EmpresaFacil"
        Me.EmpresaFacil.Size = New System.Drawing.Size(113, 20)
        Me.EmpresaFacil.TabIndex = 61
        Me.EmpresaFacil.Text = "Empresa Fácil"
        Me.EmpresaFacil.UseVisualStyleBackColor = True
        '
        'EventosEmpresaDataGridView
        '
        Me.EventosEmpresaDataGridView.AllowUserToAddRows = False
        Me.EventosEmpresaDataGridView.AllowUserToDeleteRows = False
        Me.EventosEmpresaDataGridView.AutoGenerateColumns = False
        Me.EventosEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventosEmpresaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
        Me.EventosEmpresaDataGridView.Location = New System.Drawing.Point(10, 150)
        Me.EventosEmpresaDataGridView.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.EventosEmpresaDataGridView.Name = "EventosEmpresaDataGridView"
        Me.EventosEmpresaDataGridView.ReadOnly = True
        Me.EventosEmpresaDataGridView.Size = New System.Drawing.Size(762, 158)
        Me.EventosEmpresaDataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Eventos"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Eventos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'EventosTextBox
        '
        Me.EventosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventosEmpresaBindingSource, "Eventos", True))
        Me.EventosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventosTextBox.Location = New System.Drawing.Point(130, 308)
        Me.EventosTextBox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.EventosTextBox.Name = "EventosTextBox"
        Me.EventosTextBox.ReadOnly = True
        Me.EventosTextBox.Size = New System.Drawing.Size(642, 22)
        Me.EventosTextBox.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Controle dos Eventos dos Orgãos Governamentais"
        '
        'EventosComboBox
        '
        Me.EventosComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EventosComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EventosComboBox.DataSource = Me.EventosEmpresaBindingSource
        Me.EventosComboBox.DisplayMember = "Eventos"
        Me.EventosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventosComboBox.FormattingEnabled = True
        Me.EventosComboBox.Location = New System.Drawing.Point(10, 70)
        Me.EventosComboBox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.EventosComboBox.Name = "EventosComboBox"
        Me.EventosComboBox.Size = New System.Drawing.Size(762, 24)
        Me.EventosComboBox.TabIndex = 54
        Me.EventosComboBox.ValueMember = "Eventos"
        '
        'GroupBoxMenu
        '
        Me.GroupBoxMenu.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMenu.Controls.Add(Me.BtnFechar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnSalvar)
        Me.GroupBoxMenu.Controls.Add(Me.BtnNovo)
        Me.GroupBoxMenu.Controls.Add(Me.BtnExcluir)
        Me.GroupBoxMenu.Location = New System.Drawing.Point(797, 3)
        Me.GroupBoxMenu.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBoxMenu.Size = New System.Drawing.Size(102, 159)
        Me.GroupBoxMenu.TabIndex = 61
        Me.GroupBoxMenu.TabStop = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(6, 126)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(91, 29)
        Me.BtnFechar.TabIndex = 38
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 54)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(91, 29)
        Me.BtnSalvar.TabIndex = 37
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(6, 19)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(91, 27)
        Me.BtnNovo.TabIndex = 35
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = CType(resources.GetObject("BtnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(6, 90)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(91, 29)
        Me.BtnExcluir.TabIndex = 36
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'EventosEmpresaTableAdapter
        '
        Me.EventosEmpresaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Me.EventosEmpresaTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosAvisoTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmControleEventosEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 531)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmControleEventosEmpresa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Eventos Empresa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBoxMeio.ResumeLayout(False)
        Me.GroupBoxMeio.PerformLayout()
        CType(Me.EventosEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTopo.ResumeLayout(False)
        Me.GroupBoxTopo.PerformLayout()
        CType(Me.EventosEmpresaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxMeio As GroupBox
    Friend WithEvents EventosTextBox As TextBox
    Friend WithEvents GroupBoxTopo As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EventosComboBox As ComboBox
    Friend WithEvents GroupBoxMenu As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EventosEmpresaBindingSource As BindingSource
    Friend WithEvents EventosEmpresaTableAdapter As PrinceDBDataSetTableAdapters.EventosEmpresaTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EventosEmpresaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ReceitaEstadualCheckBox As CheckBox
    Friend WithEvents ReceitaFederalCheckBox As CheckBox
    Friend WithEvents EmpresaFacilCheckBox As CheckBox
    Friend WithEvents EventosTextBox1 As TextBox
    Friend WithEvents PrefeituraMunicipalCheckBox As CheckBox
    Friend WithEvents EmpresaFacil As CheckBox
    Friend WithEvents ReceitaFederal As CheckBox
    Friend WithEvents ReceitaEstadual As CheckBox
    Friend WithEvents PrefeituraMunicipal As CheckBox
End Class
