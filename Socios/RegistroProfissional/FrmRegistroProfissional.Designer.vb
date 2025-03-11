<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroProfissional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroProfissional))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.RegistroProfissionalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroProfissionalTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.RegistroProfissionalTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.RegistroProfissionalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistroProfissionalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistroProfissionalDataGridView = New System.Windows.Forms.DataGridView()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sigla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extenso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroProfissionalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroProfissionalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistroProfissionalBindingNavigator.SuspendLayout()
        CType(Me.RegistroProfissionalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroProfissionalBindingSource
        '
        Me.RegistroProfissionalBindingSource.DataMember = "RegistroProfissional"
        Me.RegistroProfissionalBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'RegistroProfissionalTableAdapter
        '
        Me.RegistroProfissionalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
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
        Me.TableAdapterManager.ParcelamentosTableAdapter = Nothing
        Me.TableAdapterManager.RegistroProfissionalTableAdapter = Me.RegistroProfissionalTableAdapter
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistroProfissionalBindingNavigator
        '
        Me.RegistroProfissionalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistroProfissionalBindingNavigator.BindingSource = Me.RegistroProfissionalBindingSource
        Me.RegistroProfissionalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistroProfissionalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistroProfissionalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistroProfissionalBindingNavigatorSaveItem})
        Me.RegistroProfissionalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistroProfissionalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistroProfissionalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistroProfissionalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistroProfissionalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistroProfissionalBindingNavigator.Name = "RegistroProfissionalBindingNavigator"
        Me.RegistroProfissionalBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.RegistroProfissionalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistroProfissionalBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.RegistroProfissionalBindingNavigator.TabIndex = 0
        Me.RegistroProfissionalBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(88, 23)
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
        'RegistroProfissionalBindingNavigatorSaveItem
        '
        Me.RegistroProfissionalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistroProfissionalBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistroProfissionalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistroProfissionalBindingNavigatorSaveItem.Name = "RegistroProfissionalBindingNavigatorSaveItem"
        Me.RegistroProfissionalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistroProfissionalBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'RegistroProfissionalDataGridView
        '
        Me.RegistroProfissionalDataGridView.AllowUserToAddRows = False
        Me.RegistroProfissionalDataGridView.AllowUserToDeleteRows = False
        Me.RegistroProfissionalDataGridView.AllowUserToOrderColumns = True
        Me.RegistroProfissionalDataGridView.AutoGenerateColumns = False
        Me.RegistroProfissionalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RegistroProfissionalDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RegistroProfissionalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistroProfissionalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistroProfissionalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Area, Me.Sigla, Me.Extenso})
        Me.RegistroProfissionalDataGridView.DataSource = Me.RegistroProfissionalBindingSource
        Me.RegistroProfissionalDataGridView.Location = New System.Drawing.Point(18, 144)
        Me.RegistroProfissionalDataGridView.Margin = New System.Windows.Forms.Padding(6)
        Me.RegistroProfissionalDataGridView.Name = "RegistroProfissionalDataGridView"
        Me.RegistroProfissionalDataGridView.ReadOnly = True
        Me.RegistroProfissionalDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RegistroProfissionalDataGridView.Size = New System.Drawing.Size(638, 289)
        Me.RegistroProfissionalDataGridView.TabIndex = 1
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(18, 103)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(509, 29)
        Me.TxtBuscar.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(536, 96)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(120, 44)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Area
        '
        Me.Area.DataPropertyName = "Area"
        Me.Area.HeaderText = "Area"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        Me.Area.Width = 75
        '
        'Sigla
        '
        Me.Sigla.DataPropertyName = "Sigla"
        Me.Sigla.HeaderText = "Sigla"
        Me.Sigla.Name = "Sigla"
        Me.Sigla.ReadOnly = True
        Me.Sigla.Width = 76
        '
        'Extenso
        '
        Me.Extenso.DataPropertyName = "Extenso"
        Me.Extenso.HeaderText = "Extenso"
        Me.Extenso.Name = "Extenso"
        Me.Extenso.ReadOnly = True
        Me.Extenso.Width = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registro Profissional"
        '
        'ButtonFechar
        '
        Me.ButtonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFechar.Location = New System.Drawing.Point(585, 0)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(90, 40)
        Me.ButtonFechar.TabIndex = 5
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'FrmRegistroProfissional
        '
        Me.AcceptButton = Me.BtnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.ButtonFechar
        Me.ClientSize = New System.Drawing.Size(675, 447)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.RegistroProfissionalDataGridView)
        Me.Controls.Add(Me.RegistroProfissionalBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistroProfissional"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Conselho de Registro Profissional"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroProfissionalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroProfissionalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistroProfissionalBindingNavigator.ResumeLayout(False)
        Me.RegistroProfissionalBindingNavigator.PerformLayout()
        CType(Me.RegistroProfissionalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents RegistroProfissionalBindingSource As BindingSource
    Friend WithEvents RegistroProfissionalTableAdapter As PrinceDBDataSetTableAdapters.RegistroProfissionalTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistroProfissionalBindingNavigator As BindingNavigator
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
    Friend WithEvents RegistroProfissionalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RegistroProfissionalDataGridView As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Area As DataGridViewTextBoxColumn
    Friend WithEvents Sigla As DataGridViewTextBoxColumn
    Friend WithEvents Extenso As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonFechar As Button
End Class
