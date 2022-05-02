<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelSimples
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelSimples))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BbtnPrint = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EmpresasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegimeFederal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Lucro Normal", "Lucro Presumido", "RET", "Simples Nacional", "Pendência", "TODAS"})
        Me.ComboBox1.Location = New System.Drawing.Point(97, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox1.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(231, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 24)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Filtrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Regime Federal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(165, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 36)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Consulta Regime Federal"
        '
        'BbtnPrint
        '
        Me.BbtnPrint.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbtnPrint.Location = New System.Drawing.Point(411, 95)
        Me.BbtnPrint.Name = "BbtnPrint"
        Me.BbtnPrint.Size = New System.Drawing.Size(89, 34)
        Me.BbtnPrint.TabIndex = 38
        Me.BbtnPrint.Text = "Imprimir"
        Me.BbtnPrint.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(506, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 34)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EmpresasDataGridView
        '
        Me.EmpresasDataGridView.AllowUserToAddRows = False
        Me.EmpresasDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasDataGridView.AutoGenerateColumns = False
        Me.EmpresasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.RegimeFederal})
        Me.EmpresasDataGridView.DataSource = Me.EmpresasBindingSource
        Me.EmpresasDataGridView.Location = New System.Drawing.Point(12, 149)
        Me.EmpresasDataGridView.Name = "EmpresasDataGridView"
        Me.EmpresasDataGridView.ReadOnly = True
        Me.EmpresasDataGridView.Size = New System.Drawing.Size(583, 246)
        Me.EmpresasDataGridView.TabIndex = 36
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
        'RegimeFederal
        '
        Me.RegimeFederal.DataPropertyName = "RegimeFederal"
        Me.RegimeFederal.HeaderText = "Regime Federal"
        Me.RegimeFederal.Name = "RegimeFederal"
        Me.RegimeFederal.ReadOnly = True
        Me.RegimeFederal.Width = 150
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'FrmRelSimples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 412)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BbtnPrint)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.EmpresasDataGridView)
        Me.KeyPreview = True
        Me.Name = "FrmRelSimples"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regime Federal"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BbtnPrint As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents EmpresasDataGridView As DataGridView
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents RegimeFederal As DataGridViewTextBoxColumn
End Class
