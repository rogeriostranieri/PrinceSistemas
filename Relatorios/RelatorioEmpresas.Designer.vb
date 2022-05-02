<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelatorioEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelatorioEmpresas))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EmpresasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Processo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NireData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BbtnPrint = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ProcessoComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CADstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CADstatusTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADstatusTableAdapter()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasDataGridView
        '
        Me.EmpresasDataGridView.AllowUserToAddRows = False
        Me.EmpresasDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasDataGridView.AutoGenerateColumns = False
        Me.EmpresasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn22, Me.Processo, Me.NireData})
        Me.EmpresasDataGridView.DataSource = Me.EmpresasBindingSource
        Me.EmpresasDataGridView.Location = New System.Drawing.Point(6, 128)
        Me.EmpresasDataGridView.Name = "EmpresasDataGridView"
        Me.EmpresasDataGridView.ReadOnly = True
        Me.EmpresasDataGridView.Size = New System.Drawing.Size(659, 263)
        Me.EmpresasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CNPJ"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CNPJ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'Processo
        '
        Me.Processo.DataPropertyName = "Processo"
        Me.Processo.HeaderText = "Processo"
        Me.Processo.Name = "Processo"
        Me.Processo.ReadOnly = True
        Me.Processo.Width = 80
        '
        'NireData
        '
        Me.NireData.DataPropertyName = "NireData"
        Me.NireData.HeaderText = "Data Abertura"
        Me.NireData.Name = "NireData"
        Me.NireData.ReadOnly = True
        '
        'BbtnPrint
        '
        Me.BbtnPrint.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbtnPrint.Location = New System.Drawing.Point(481, 91)
        Me.BbtnPrint.Name = "BbtnPrint"
        Me.BbtnPrint.Size = New System.Drawing.Size(89, 34)
        Me.BbtnPrint.TabIndex = 19
        Me.BbtnPrint.Text = "Imprimir"
        Me.BbtnPrint.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(576, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 34)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.StatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StatusComboBox.DataSource = Me.CADstatusBindingSource
        Me.StatusComboBox.DisplayMember = "Descricao"
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(62, 61)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(172, 21)
        Me.StatusComboBox.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 24)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Filtrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Situação:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(214, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 36)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Relatório de Empresas"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'ProcessoComboBox
        '
        Me.ProcessoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProcessoComboBox.FormattingEnabled = True
        Me.ProcessoComboBox.Location = New System.Drawing.Point(62, 88)
        Me.ProcessoComboBox.Name = "ProcessoComboBox"
        Me.ProcessoComboBox.Size = New System.Drawing.Size(112, 21)
        Me.ProcessoComboBox.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(180, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 24)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Filtrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Tipo:"
        '
        'CADstatusBindingSource
        '
        Me.CADstatusBindingSource.DataMember = "CADstatus"
        Me.CADstatusBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'CADstatusTableAdapter
        '
        Me.CADstatusTableAdapter.ClearBeforeFill = True
        '
        'RelatorioEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 397)
        Me.Controls.Add(Me.ProcessoComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BbtnPrint)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.EmpresasDataGridView)
        Me.KeyPreview = True
        Me.Name = "RelatorioEmpresas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Geral Empresas"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasDataGridView As DataGridView
    Friend WithEvents BbtnPrint As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ProcessoComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents Processo As DataGridViewTextBoxColumn
    Friend WithEvents NireData As DataGridViewTextBoxColumn
    Friend WithEvents CADstatusBindingSource As BindingSource
    Friend WithEvents CADstatusTableAdapter As PrinceDBDataSetTableAdapters.CADstatusTableAdapter
End Class
