<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAvisoParcelamento
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
        Dim MesRealizadoLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAvisoParcelamento))
        Dim MesRealizadoLabel1 As System.Windows.Forms.Label
        Dim AnoLabel1 As System.Windows.Forms.Label
        Me.LblDataAviso = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.ParcelamentosAvisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParcelamentosAvisoTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosAvisoTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ParcelamentosAvisoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ParcelamentosAvisoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MesRealizadoComboBox = New System.Windows.Forms.ComboBox()
        Me.AnoComboBox = New System.Windows.Forms.ComboBox()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.ParcelamentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        MesRealizadoLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        MesRealizadoLabel1 = New System.Windows.Forms.Label()
        AnoLabel1 = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosAvisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosAvisoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParcelamentosAvisoBindingNavigator.SuspendLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MesRealizadoLabel
        '
        MesRealizadoLabel.AutoSize = True
        MesRealizadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesRealizadoLabel.ForeColor = System.Drawing.Color.White
        MesRealizadoLabel.Location = New System.Drawing.Point(208, 98)
        MesRealizadoLabel.Name = "MesRealizadoLabel"
        MesRealizadoLabel.Size = New System.Drawing.Size(166, 18)
        MesRealizadoLabel.TabIndex = 3
        MesRealizadoLabel.Text = "Mes de fechamento :"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnoLabel.ForeColor = System.Drawing.Color.White
        AnoLabel.Location = New System.Drawing.Point(33, 98)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(42, 18)
        AnoLabel.TabIndex = 4
        AnoLabel.Text = "Ano:"
        '
        'LblDataAviso
        '
        Me.LblDataAviso.AutoSize = True
        Me.LblDataAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataAviso.ForeColor = System.Drawing.Color.White
        Me.LblDataAviso.Location = New System.Drawing.Point(228, 38)
        Me.LblDataAviso.Name = "LblDataAviso"
        Me.LblDataAviso.Size = New System.Drawing.Size(95, 31)
        Me.LblDataAviso.TabIndex = 6
        Me.LblDataAviso.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data do Aviso:"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParcelamentosAvisoBindingSource
        '
        Me.ParcelamentosAvisoBindingSource.DataMember = "ParcelamentosAviso"
        Me.ParcelamentosAvisoBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'ParcelamentosAvisoTableAdapter
        '
        Me.ParcelamentosAvisoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ParcelamentosAvisoTableAdapter = Me.ParcelamentosAvisoTableAdapter
        Me.TableAdapterManager.ParcelamentosTableAdapter = Me.ParcelamentosTableAdapter
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ParcelamentosAvisoBindingNavigator
        '
        Me.ParcelamentosAvisoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ParcelamentosAvisoBindingNavigator.BindingSource = Me.ParcelamentosAvisoBindingSource
        Me.ParcelamentosAvisoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParcelamentosAvisoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ParcelamentosAvisoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ParcelamentosAvisoBindingNavigatorSaveItem})
        Me.ParcelamentosAvisoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParcelamentosAvisoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParcelamentosAvisoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParcelamentosAvisoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParcelamentosAvisoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParcelamentosAvisoBindingNavigator.Name = "ParcelamentosAvisoBindingNavigator"
        Me.ParcelamentosAvisoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParcelamentosAvisoBindingNavigator.Size = New System.Drawing.Size(1059, 25)
        Me.ParcelamentosAvisoBindingNavigator.TabIndex = 8
        Me.ParcelamentosAvisoBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'ParcelamentosAvisoBindingNavigatorSaveItem
        '
        Me.ParcelamentosAvisoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ParcelamentosAvisoBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParcelamentosAvisoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParcelamentosAvisoBindingNavigatorSaveItem.Name = "ParcelamentosAvisoBindingNavigatorSaveItem"
        Me.ParcelamentosAvisoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ParcelamentosAvisoBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'MesRealizadoLabel1
        '
        MesRealizadoLabel1.AutoSize = True
        MesRealizadoLabel1.Location = New System.Drawing.Point(158, 176)
        MesRealizadoLabel1.Name = "MesRealizadoLabel1"
        MesRealizadoLabel1.Size = New System.Drawing.Size(111, 18)
        MesRealizadoLabel1.TabIndex = 8
        MesRealizadoLabel1.Text = "Mes Realizado:"
        '
        'MesRealizadoComboBox
        '
        Me.MesRealizadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosAvisoBindingSource, "MesRealizado", True))
        Me.MesRealizadoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesRealizadoComboBox.FormattingEnabled = True
        Me.MesRealizadoComboBox.Items.AddRange(New Object() {"A", "B", "C"})
        Me.MesRealizadoComboBox.Location = New System.Drawing.Point(380, 95)
        Me.MesRealizadoComboBox.Name = "MesRealizadoComboBox"
        Me.MesRealizadoComboBox.Size = New System.Drawing.Size(175, 28)
        Me.MesRealizadoComboBox.TabIndex = 9
        '
        'AnoLabel1
        '
        AnoLabel1.AutoSize = True
        AnoLabel1.Location = New System.Drawing.Point(231, 221)
        AnoLabel1.Name = "AnoLabel1"
        AnoLabel1.Size = New System.Drawing.Size(38, 18)
        AnoLabel1.TabIndex = 9
        AnoLabel1.Text = "Ano:"
        '
        'AnoComboBox
        '
        Me.AnoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosAvisoBindingSource, "Ano", True))
        Me.AnoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoComboBox.FormattingEnabled = True
        Me.AnoComboBox.Location = New System.Drawing.Point(81, 95)
        Me.AnoComboBox.Name = "AnoComboBox"
        Me.AnoComboBox.Size = New System.Drawing.Size(121, 28)
        Me.AnoComboBox.TabIndex = 10
        '
        'ParcelamentosBindingSource
        '
        Me.ParcelamentosBindingSource.DataMember = "Parcelamentos"
        Me.ParcelamentosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'ParcelamentosTableAdapter
        '
        Me.ParcelamentosTableAdapter.ClearBeforeFill = True
        '
        'ParcelamentosDataGridView
        '
        Me.ParcelamentosDataGridView.AllowUserToAddRows = False
        Me.ParcelamentosDataGridView.AllowUserToDeleteRows = False
        Me.ParcelamentosDataGridView.AllowUserToOrderColumns = True
        Me.ParcelamentosDataGridView.AutoGenerateColumns = False
        Me.ParcelamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParcelamentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.ParcelamentosDataGridView.DataSource = Me.ParcelamentosBindingSource
        Me.ParcelamentosDataGridView.Location = New System.Drawing.Point(37, 231)
        Me.ParcelamentosDataGridView.Name = "ParcelamentosDataGridView"
        Me.ParcelamentosDataGridView.ReadOnly = True
        Me.ParcelamentosDataGridView.Size = New System.Drawing.Size(518, 220)
        Me.ParcelamentosDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 450
        '
        'FrmAvisoParcelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1059, 525)
        Me.Controls.Add(Me.ParcelamentosDataGridView)
        Me.Controls.Add(AnoLabel1)
        Me.Controls.Add(Me.AnoComboBox)
        Me.Controls.Add(MesRealizadoLabel1)
        Me.Controls.Add(Me.MesRealizadoComboBox)
        Me.Controls.Add(Me.ParcelamentosAvisoBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblDataAviso)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(MesRealizadoLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAvisoParcelamento"
        Me.Text = "FrmAvisoParcelamento"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosAvisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosAvisoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParcelamentosAvisoBindingNavigator.ResumeLayout(False)
        Me.ParcelamentosAvisoBindingNavigator.PerformLayout()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDataAviso As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosAvisoBindingSource As BindingSource
    Friend WithEvents ParcelamentosAvisoTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosAvisoTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParcelamentosAvisoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ParcelamentosAvisoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MesRealizadoComboBox As ComboBox
    Friend WithEvents AnoComboBox As ComboBox
    Friend WithEvents ParcelamentosTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents ParcelamentosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
