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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControleEventosEmpresa))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxMeio = New System.Windows.Forms.GroupBox()
        Me.PrefeituraMunicipal = New System.Windows.Forms.CheckBox()
        Me.EventosEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EventosTextBox = New System.Windows.Forms.TextBox()
        Me.ReceitaEstadual = New System.Windows.Forms.CheckBox()
        Me.ReceitaFederal = New System.Windows.Forms.CheckBox()
        Me.EmpresaFacil = New System.Windows.Forms.CheckBox()
        Me.GroupBoxTopo = New System.Windows.Forms.GroupBox()
        Me.EventosEmpresaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        EventosLabel.Location = New System.Drawing.Point(6, 23)
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
        Label5.Location = New System.Drawing.Point(6, 55)
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
        EventosLabel1.Location = New System.Drawing.Point(10, 58)
        EventosLabel1.Name = "EventosLabel1"
        EventosLabel1.Size = New System.Drawing.Size(125, 20)
        EventosLabel1.TabIndex = 53
        EventosLabel1.Text = "Filtar Eventos:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.76978!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.23022!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMeio, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxTopo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenu, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.14161!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.85839!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(685, 387)
        Me.TableLayoutPanel1.TabIndex = 61
        '
        'GroupBoxMeio
        '
        Me.GroupBoxMeio.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMeio.Controls.Add(EventosLabel)
        Me.GroupBoxMeio.Controls.Add(Me.PrefeituraMunicipal)
        Me.GroupBoxMeio.Controls.Add(Me.EventosTextBox)
        Me.GroupBoxMeio.Controls.Add(Me.ReceitaEstadual)
        Me.GroupBoxMeio.Controls.Add(Label5)
        Me.GroupBoxMeio.Controls.Add(Me.ReceitaFederal)
        Me.GroupBoxMeio.Controls.Add(Me.EmpresaFacil)
        Me.GroupBoxMeio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMeio.Location = New System.Drawing.Point(3, 255)
        Me.GroupBoxMeio.Name = "GroupBoxMeio"
        Me.GroupBoxMeio.Size = New System.Drawing.Size(595, 129)
        Me.GroupBoxMeio.TabIndex = 61
        Me.GroupBoxMeio.TabStop = False
        '
        'PrefeituraMunicipal
        '
        Me.PrefeituraMunicipal.BackColor = System.Drawing.Color.Transparent
        Me.PrefeituraMunicipal.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "PrefeituraMunicipal", True))
        Me.PrefeituraMunicipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrefeituraMunicipal.Location = New System.Drawing.Point(395, 80)
        Me.PrefeituraMunicipal.Name = "PrefeituraMunicipal"
        Me.PrefeituraMunicipal.Size = New System.Drawing.Size(144, 24)
        Me.PrefeituraMunicipal.TabIndex = 59
        Me.PrefeituraMunicipal.Text = "Prefeitura Municipal"
        Me.PrefeituraMunicipal.UseVisualStyleBackColor = False
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
        'EventosTextBox
        '
        Me.EventosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventosEmpresaBindingSource, "Eventos", True))
        Me.EventosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventosTextBox.Location = New System.Drawing.Point(118, 20)
        Me.EventosTextBox.Name = "EventosTextBox"
        Me.EventosTextBox.Size = New System.Drawing.Size(464, 22)
        Me.EventosTextBox.TabIndex = 45
        '
        'ReceitaEstadual
        '
        Me.ReceitaEstadual.BackColor = System.Drawing.Color.Transparent
        Me.ReceitaEstadual.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "ReceitaEstadual", True))
        Me.ReceitaEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceitaEstadual.Location = New System.Drawing.Point(259, 80)
        Me.ReceitaEstadual.Name = "ReceitaEstadual"
        Me.ReceitaEstadual.Size = New System.Drawing.Size(130, 24)
        Me.ReceitaEstadual.TabIndex = 58
        Me.ReceitaEstadual.Text = "Receita Estadual"
        Me.ReceitaEstadual.UseVisualStyleBackColor = False
        '
        'ReceitaFederal
        '
        Me.ReceitaFederal.BackColor = System.Drawing.Color.Transparent
        Me.ReceitaFederal.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "ReceitaFederal", True))
        Me.ReceitaFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceitaFederal.Location = New System.Drawing.Point(130, 80)
        Me.ReceitaFederal.Name = "ReceitaFederal"
        Me.ReceitaFederal.Size = New System.Drawing.Size(123, 24)
        Me.ReceitaFederal.TabIndex = 57
        Me.ReceitaFederal.Text = "Receita Federal"
        Me.ReceitaFederal.UseVisualStyleBackColor = False
        '
        'EmpresaFacil
        '
        Me.EmpresaFacil.BackColor = System.Drawing.Color.Transparent
        Me.EmpresaFacil.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EventosEmpresaBindingSource, "EmpresaFacil", True))
        Me.EmpresaFacil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaFacil.Location = New System.Drawing.Point(9, 80)
        Me.EmpresaFacil.Name = "EmpresaFacil"
        Me.EmpresaFacil.Size = New System.Drawing.Size(115, 24)
        Me.EmpresaFacil.TabIndex = 56
        Me.EmpresaFacil.Text = "Empresa Fácil"
        Me.EmpresaFacil.UseVisualStyleBackColor = False
        '
        'GroupBoxTopo
        '
        Me.GroupBoxTopo.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTopo.Controls.Add(Me.EventosEmpresaDataGridView)
        Me.GroupBoxTopo.Controls.Add(Me.Label1)
        Me.GroupBoxTopo.Controls.Add(Me.EventosComboBox)
        Me.GroupBoxTopo.Controls.Add(EventosLabel1)
        Me.GroupBoxTopo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxTopo.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxTopo.Name = "GroupBoxTopo"
        Me.GroupBoxTopo.Size = New System.Drawing.Size(595, 246)
        Me.GroupBoxTopo.TabIndex = 61
        Me.GroupBoxTopo.TabStop = False
        '
        'EventosEmpresaDataGridView
        '
        Me.EventosEmpresaDataGridView.AllowUserToAddRows = False
        Me.EventosEmpresaDataGridView.AllowUserToDeleteRows = False
        Me.EventosEmpresaDataGridView.AutoGenerateColumns = False
        Me.EventosEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventosEmpresaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
        Me.EventosEmpresaDataGridView.Location = New System.Drawing.Point(14, 111)
        Me.EventosEmpresaDataGridView.Name = "EventosEmpresaDataGridView"
        Me.EventosEmpresaDataGridView.ReadOnly = True
        Me.EventosEmpresaDataGridView.Size = New System.Drawing.Size(568, 128)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
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
        Me.EventosComboBox.Location = New System.Drawing.Point(10, 81)
        Me.EventosComboBox.Name = "EventosComboBox"
        Me.EventosComboBox.Size = New System.Drawing.Size(572, 24)
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
        Me.GroupBoxMenu.Location = New System.Drawing.Point(604, 255)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Size = New System.Drawing.Size(78, 129)
        Me.GroupBoxMenu.TabIndex = 61
        Me.GroupBoxMenu.TabStop = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(4, 102)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 23)
        Me.BtnFechar.TabIndex = 38
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(4, 44)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 23)
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
        Me.BtnNovo.Location = New System.Drawing.Point(4, 16)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(69, 22)
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
        Me.BtnExcluir.Location = New System.Drawing.Point(4, 73)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(69, 23)
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
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmControleEventosEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(685, 387)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmControleEventosEmpresa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Eventos Empresa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxMeio.ResumeLayout(False)
        Me.GroupBoxMeio.PerformLayout()
        CType(Me.EventosEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTopo.ResumeLayout(False)
        Me.GroupBoxTopo.PerformLayout()
        CType(Me.EventosEmpresaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxMeio As GroupBox
    Friend WithEvents PrefeituraMunicipal As CheckBox
    Friend WithEvents EventosTextBox As TextBox
    Friend WithEvents ReceitaEstadual As CheckBox
    Friend WithEvents ReceitaFederal As CheckBox
    Friend WithEvents EmpresaFacil As CheckBox
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
End Class
