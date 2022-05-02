<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelacaoAlvaraProtocolado
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
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LaudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocoloTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocoloN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocoloAno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocoloSenha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
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
        'LaudosDataGridView
        '
        Me.LaudosDataGridView.AllowUserToAddRows = False
        Me.LaudosDataGridView.AllowUserToDeleteRows = False
        Me.LaudosDataGridView.AutoGenerateColumns = False
        Me.LaudosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn61, Me.ProtocoloTipo, Me.ProtocoloN, Me.ProtocoloAno, Me.ProtocoloSenha})
        Me.LaudosDataGridView.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView.Location = New System.Drawing.Point(18, 69)
        Me.LaudosDataGridView.Name = "LaudosDataGridView"
        Me.LaudosDataGridView.ReadOnly = True
        Me.LaudosDataGridView.Size = New System.Drawing.Size(671, 234)
        Me.LaudosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Nlaudo"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Nº laudo"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 80
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Situacao"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Situação"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        Me.DataGridViewTextBoxColumn59.Width = 70
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "DataEntrada"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Data de Entrada"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        '
        'ProtocoloTipo
        '
        Me.ProtocoloTipo.DataPropertyName = "ProtocoloTipo"
        Me.ProtocoloTipo.HeaderText = "Tipo"
        Me.ProtocoloTipo.Name = "ProtocoloTipo"
        Me.ProtocoloTipo.ReadOnly = True
        Me.ProtocoloTipo.Width = 30
        '
        'ProtocoloN
        '
        Me.ProtocoloN.DataPropertyName = "ProtocoloN"
        Me.ProtocoloN.HeaderText = "Número"
        Me.ProtocoloN.Name = "ProtocoloN"
        Me.ProtocoloN.ReadOnly = True
        Me.ProtocoloN.Width = 50
        '
        'ProtocoloAno
        '
        Me.ProtocoloAno.DataPropertyName = "ProtocoloAno"
        Me.ProtocoloAno.HeaderText = "Ano"
        Me.ProtocoloAno.Name = "ProtocoloAno"
        Me.ProtocoloAno.ReadOnly = True
        Me.ProtocoloAno.Width = 40
        '
        'ProtocoloSenha
        '
        Me.ProtocoloSenha.DataPropertyName = "ProtocoloSenha"
        Me.ProtocoloSenha.HeaderText = "Senha"
        Me.ProtocoloSenha.Name = "ProtocoloSenha"
        Me.ProtocoloSenha.ReadOnly = True
        Me.ProtocoloSenha.Width = 40
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(541, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 34)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(101, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(506, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "CONSULTA - ALVARÁS PROTOCOLADOS"
        '
        'RelacaoAlvaraProtocolado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 350)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LaudosDataGridView)
        Me.Name = "RelacaoAlvaraProtocolado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Protocolo Alvará"
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
    Friend WithEvents LaudosDataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents ProtocoloTipo As DataGridViewTextBoxColumn
    Friend WithEvents ProtocoloN As DataGridViewTextBoxColumn
    Friend WithEvents ProtocoloAno As DataGridViewTextBoxColumn
    Friend WithEvents ProtocoloSenha As DataGridViewTextBoxColumn
End Class
