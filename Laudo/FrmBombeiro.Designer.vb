<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBombeiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBombeiro))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BbtnPrint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LaudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Não Necessita", "------ PrevFogo ------", "Não solicitado", "Aguardando Pagamento", "Em Andamento", "Junto com Laudo", "Não Liberado", "Finalizado Definitivo", "Finalizado Provisório", "Cancelado", "Paralizado", "Baixa em Andamento", "Baixado", "-", "---- Prefeitura/Laudo ----", "Não Iniciado", "Aguardando Pagamento", "Encaminhado p/ Vistoria", "Em Andamento", "Em Exigências", "Liberado", "Baixa em Andamento", "Baixado", "-"})
        Me.ComboBox1.Location = New System.Drawing.Point(62, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(189, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 24)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Mostrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(163, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 38)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "PrevFogo - Bombeiro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Situação:"
        '
        'BbtnPrint
        '
        Me.BbtnPrint.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbtnPrint.Location = New System.Drawing.Point(387, 325)
        Me.BbtnPrint.Name = "BbtnPrint"
        Me.BbtnPrint.Size = New System.Drawing.Size(89, 34)
        Me.BbtnPrint.TabIndex = 31
        Me.BbtnPrint.Text = "Imprimir"
        Me.BbtnPrint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(482, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'LaudosDataGridView
        '
        Me.LaudosDataGridView.AllowUserToAddRows = False
        Me.LaudosDataGridView.AllowUserToDeleteRows = False
        Me.LaudosDataGridView.AutoGenerateColumns = False
        Me.LaudosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn78})
        Me.LaudosDataGridView.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView.Location = New System.Drawing.Point(12, 99)
        Me.LaudosDataGridView.Name = "LaudosDataGridView"
        Me.LaudosDataGridView.ReadOnly = True
        Me.LaudosDataGridView.Size = New System.Drawing.Size(560, 220)
        Me.LaudosDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "BombeiroSituacao"
        Me.DataGridViewTextBoxColumn78.HeaderText = "Situação"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        Me.DataGridViewTextBoxColumn78.ReadOnly = True
        Me.DataGridViewTextBoxColumn78.Width = 200
        '
        'FrmBombeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 368)
        Me.Controls.Add(Me.LaudosDataGridView)
        Me.Controls.Add(Me.BbtnPrint)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBombeiro"
        Me.ShowIcon = False
        Me.Text = "PrevFogo - Consulta"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BbtnPrint As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LaudosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As DataGridViewTextBoxColumn
End Class
