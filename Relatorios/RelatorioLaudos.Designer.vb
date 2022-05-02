<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelatorioLaudos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelatorioLaudos))
        Me.SituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.CADSituacaoAlvaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BbtnPrint = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LaudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.CADSituacaoAlvaraTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADSituacaoAlvaraTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nlaudo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CADSituacaoAlvaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SituacaoComboBox
        '
        Me.SituacaoComboBox.DataSource = Me.CADSituacaoAlvaraBindingSource
        Me.SituacaoComboBox.DisplayMember = "Descricao"
        Me.SituacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SituacaoComboBox.FormattingEnabled = True
        Me.SituacaoComboBox.Location = New System.Drawing.Point(62, 50)
        Me.SituacaoComboBox.Name = "SituacaoComboBox"
        Me.SituacaoComboBox.Size = New System.Drawing.Size(296, 21)
        Me.SituacaoComboBox.TabIndex = 38
        '
        'CADSituacaoAlvaraBindingSource
        '
        Me.CADSituacaoAlvaraBindingSource.DataMember = "CADSituacaoAlvara"
        Me.CADSituacaoAlvaraBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(364, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 24)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Situação:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(258, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 36)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Alvarás / Laudos"
        '
        'BbtnPrint
        '
        Me.BbtnPrint.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbtnPrint.Location = New System.Drawing.Point(482, 382)
        Me.BbtnPrint.Name = "BbtnPrint"
        Me.BbtnPrint.Size = New System.Drawing.Size(89, 34)
        Me.BbtnPrint.TabIndex = 35
        Me.BbtnPrint.Text = "Imprimir"
        Me.BbtnPrint.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(577, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 34)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
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
        'LaudosBindingSource
        '
        Me.LaudosBindingSource.DataMember = "Laudos"
        Me.LaudosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'LaudosTableAdapter
        '
        Me.LaudosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Me.LaudosTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LaudosDataGridView
        '
        Me.LaudosDataGridView.AllowUserToAddRows = False
        Me.LaudosDataGridView.AllowUserToDeleteRows = False
        Me.LaudosDataGridView.AutoGenerateColumns = False
        Me.LaudosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Nlaudo, Me.Situacao})
        Me.LaudosDataGridView.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView.Location = New System.Drawing.Point(15, 80)
        Me.LaudosDataGridView.Name = "LaudosDataGridView"
        Me.LaudosDataGridView.ReadOnly = True
        Me.LaudosDataGridView.Size = New System.Drawing.Size(651, 300)
        Me.LaudosDataGridView.TabIndex = 40
        '
        'CADSituacaoAlvaraTableAdapter
        '
        Me.CADSituacaoAlvaraTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CNPJ"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CNPJ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Nlaudo
        '
        Me.Nlaudo.DataPropertyName = "Nlaudo"
        Me.Nlaudo.HeaderText = "Nº do Laudo"
        Me.Nlaudo.Name = "Nlaudo"
        Me.Nlaudo.ReadOnly = True
        '
        'Situacao
        '
        Me.Situacao.DataPropertyName = "Situacao"
        Me.Situacao.HeaderText = "Situação"
        Me.Situacao.Name = "Situacao"
        Me.Situacao.ReadOnly = True
        '
        'RelatorioLaudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 422)
        Me.Controls.Add(Me.LaudosDataGridView)
        Me.Controls.Add(Me.SituacaoComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BbtnPrint)
        Me.Controls.Add(Me.Button2)
        Me.KeyPreview = True
        Me.Name = "RelatorioLaudos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Geral de  Alvarás / Laudos"
        CType(Me.CADSituacaoAlvaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SituacaoComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BbtnPrint As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LaudosDataGridView As DataGridView
    Friend WithEvents CADSituacaoAlvaraBindingSource As BindingSource
    Friend WithEvents CADSituacaoAlvaraTableAdapter As PrinceDBDataSetTableAdapters.CADSituacaoAlvaraTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Nlaudo As DataGridViewTextBoxColumn
    Friend WithEvents Situacao As DataGridViewTextBoxColumn
End Class
