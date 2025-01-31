<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlertaCentral
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
        Dim AvisarLabel As System.Windows.Forms.Label
        Dim TextoAvisoLabel As System.Windows.Forms.Label
        Dim DataAvisoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertaCentral))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.AvisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvisosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.AvisosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.AvisosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AvisosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AvisarComboBox = New System.Windows.Forms.ComboBox()
        Me.TextoAvisoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataAvisoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnEmpresas = New System.Windows.Forms.Button()
        Me.BtnLaudos = New System.Windows.Forms.Button()
        Me.BtnSocios = New System.Windows.Forms.Button()
        Me.BtnParcelamentos = New System.Windows.Forms.Button()
        Me.LblContadorTexto = New System.Windows.Forms.Label()
        AvisarLabel = New System.Windows.Forms.Label()
        TextoAvisoLabel = New System.Windows.Forms.Label()
        DataAvisoLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AvisosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AvisarLabel
        '
        AvisarLabel.AutoSize = True
        AvisarLabel.BackColor = System.Drawing.Color.Transparent
        AvisarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AvisarLabel.Location = New System.Drawing.Point(54, 43)
        AvisarLabel.Name = "AvisarLabel"
        AvisarLabel.Size = New System.Drawing.Size(84, 29)
        AvisarLabel.TabIndex = 2
        AvisarLabel.Text = "Avisar:"
        '
        'TextoAvisoLabel
        '
        TextoAvisoLabel.AutoSize = True
        TextoAvisoLabel.BackColor = System.Drawing.Color.Transparent
        TextoAvisoLabel.Location = New System.Drawing.Point(44, 138)
        TextoAvisoLabel.Name = "TextoAvisoLabel"
        TextoAvisoLabel.Size = New System.Drawing.Size(94, 20)
        TextoAvisoLabel.TabIndex = 4
        TextoAvisoLabel.Text = "Texto Aviso:"
        '
        'DataAvisoLabel
        '
        DataAvisoLabel.AutoSize = True
        DataAvisoLabel.BackColor = System.Drawing.Color.Transparent
        DataAvisoLabel.Location = New System.Drawing.Point(13, 107)
        DataAvisoLabel.Name = "DataAvisoLabel"
        DataAvisoLabel.Size = New System.Drawing.Size(131, 20)
        DataAvisoLabel.TabIndex = 6
        DataAvisoLabel.Text = "Data para Avisar:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(504, 308)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AvisosBindingSource
        '
        Me.AvisosBindingSource.DataMember = "Avisos"
        Me.AvisosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'AvisosTableAdapter
        '
        Me.AvisosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.AvisosTableAdapter = Me.AvisosTableAdapter
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
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AvisosBindingNavigator
        '
        Me.AvisosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AvisosBindingNavigator.BindingSource = Me.AvisosBindingSource
        Me.AvisosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AvisosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AvisosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AvisosBindingNavigatorSaveItem})
        Me.AvisosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AvisosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AvisosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AvisosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AvisosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AvisosBindingNavigator.Name = "AvisosBindingNavigator"
        Me.AvisosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AvisosBindingNavigator.Size = New System.Drawing.Size(727, 25)
        Me.AvisosBindingNavigator.TabIndex = 1
        Me.AvisosBindingNavigator.Text = "BindingNavigator1"
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
        'AvisosBindingNavigatorSaveItem
        '
        Me.AvisosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AvisosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AvisosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AvisosBindingNavigatorSaveItem.Name = "AvisosBindingNavigatorSaveItem"
        Me.AvisosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AvisosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'AvisarComboBox
        '
        Me.AvisarComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "Avisar", True))
        Me.AvisarComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisarComboBox.FormattingEnabled = True
        Me.AvisarComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.AvisarComboBox.Location = New System.Drawing.Point(144, 40)
        Me.AvisarComboBox.Name = "AvisarComboBox"
        Me.AvisarComboBox.Size = New System.Drawing.Size(121, 37)
        Me.AvisarComboBox.TabIndex = 3
        '
        'TextoAvisoRichTextBox
        '
        Me.TextoAvisoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvisosBindingSource, "TextoAviso", True))
        Me.TextoAvisoRichTextBox.Location = New System.Drawing.Point(144, 135)
        Me.TextoAvisoRichTextBox.Name = "TextoAvisoRichTextBox"
        Me.TextoAvisoRichTextBox.Size = New System.Drawing.Size(430, 162)
        Me.TextoAvisoRichTextBox.TabIndex = 5
        Me.TextoAvisoRichTextBox.Text = ""
        '
        'DataAvisoDateTimePicker
        '
        Me.DataAvisoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AvisosBindingSource, "DataAviso", True))
        Me.DataAvisoDateTimePicker.Location = New System.Drawing.Point(144, 103)
        Me.DataAvisoDateTimePicker.Name = "DataAvisoDateTimePicker"
        Me.DataAvisoDateTimePicker.Size = New System.Drawing.Size(361, 26)
        Me.DataAvisoDateTimePicker.TabIndex = 7
        '
        'BtnEmpresas
        '
        Me.BtnEmpresas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEmpresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresas.Location = New System.Drawing.Point(580, 135)
        Me.BtnEmpresas.Name = "BtnEmpresas"
        Me.BtnEmpresas.Size = New System.Drawing.Size(140, 36)
        Me.BtnEmpresas.TabIndex = 8
        Me.BtnEmpresas.Text = "Empresa"
        Me.BtnEmpresas.UseVisualStyleBackColor = False
        '
        'BtnLaudos
        '
        Me.BtnLaudos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLaudos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLaudos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaudos.Location = New System.Drawing.Point(580, 177)
        Me.BtnLaudos.Name = "BtnLaudos"
        Me.BtnLaudos.Size = New System.Drawing.Size(140, 36)
        Me.BtnLaudos.TabIndex = 9
        Me.BtnLaudos.Text = "Laudos"
        Me.BtnLaudos.UseVisualStyleBackColor = False
        '
        'BtnSocios
        '
        Me.BtnSocios.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSocios.Location = New System.Drawing.Point(580, 219)
        Me.BtnSocios.Name = "BtnSocios"
        Me.BtnSocios.Size = New System.Drawing.Size(140, 36)
        Me.BtnSocios.TabIndex = 10
        Me.BtnSocios.Text = "Sócios"
        Me.BtnSocios.UseVisualStyleBackColor = False
        '
        'BtnParcelamentos
        '
        Me.BtnParcelamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnParcelamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnParcelamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnParcelamentos.Location = New System.Drawing.Point(580, 261)
        Me.BtnParcelamentos.Name = "BtnParcelamentos"
        Me.BtnParcelamentos.Size = New System.Drawing.Size(140, 36)
        Me.BtnParcelamentos.TabIndex = 11
        Me.BtnParcelamentos.Text = "Parcelamentos"
        Me.BtnParcelamentos.UseVisualStyleBackColor = False
        '
        'LblContadorTexto
        '
        Me.LblContadorTexto.AutoSize = True
        Me.LblContadorTexto.BackColor = System.Drawing.Color.Transparent
        Me.LblContadorTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LblContadorTexto.Location = New System.Drawing.Point(144, 302)
        Me.LblContadorTexto.Name = "LblContadorTexto"
        Me.LblContadorTexto.Size = New System.Drawing.Size(45, 15)
        Me.LblContadorTexto.TabIndex = 12
        Me.LblContadorTexto.Text = "Label1"
        '
        'AlertaCentral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(727, 358)
        Me.Controls.Add(Me.LblContadorTexto)
        Me.Controls.Add(Me.BtnParcelamentos)
        Me.Controls.Add(Me.BtnSocios)
        Me.Controls.Add(Me.BtnLaudos)
        Me.Controls.Add(Me.BtnEmpresas)
        Me.Controls.Add(DataAvisoLabel)
        Me.Controls.Add(Me.DataAvisoDateTimePicker)
        Me.Controls.Add(TextoAvisoLabel)
        Me.Controls.Add(Me.TextoAvisoRichTextBox)
        Me.Controls.Add(AvisarLabel)
        Me.Controls.Add(Me.AvisarComboBox)
        Me.Controls.Add(Me.AvisosBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlertaCentral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlertaCentral"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AvisosBindingNavigator.ResumeLayout(False)
        Me.AvisosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents AvisosBindingSource As BindingSource
    Friend WithEvents AvisosTableAdapter As PrinceDBDataSetTableAdapters.AvisosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AvisosBindingNavigator As BindingNavigator
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
    Friend WithEvents AvisosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AvisarComboBox As ComboBox
    Friend WithEvents TextoAvisoRichTextBox As RichTextBox
    Friend WithEvents DataAvisoDateTimePicker As DateTimePicker
    Friend WithEvents BtnEmpresas As Button
    Friend WithEvents BtnLaudos As Button
    Friend WithEvents BtnSocios As Button
    Friend WithEvents BtnParcelamentos As Button
    Friend WithEvents LblContadorTexto As Label
End Class
