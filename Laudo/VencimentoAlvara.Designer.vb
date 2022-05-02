<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VencimentoAlvara
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
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LaudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BombeiroSituacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.LaudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Situacao, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.BombeiroSituacao, Me.DataGridViewTextBoxColumn51})
        Me.LaudosDataGridView.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView.Location = New System.Drawing.Point(12, 124)
        Me.LaudosDataGridView.Name = "LaudosDataGridView"
        Me.LaudosDataGridView.ReadOnly = True
        Me.LaudosDataGridView.Size = New System.Drawing.Size(872, 239)
        Me.LaudosDataGridView.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(88, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Mostrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(12, 88)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox1.TabIndex = 12
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(161, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(622, 41)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Vencimentos de alvará de localização"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'Situacao
        '
        Me.Situacao.DataPropertyName = "Situacao"
        Me.Situacao.HeaderText = "Situação"
        Me.Situacao.Name = "Situacao"
        Me.Situacao.ReadOnly = True
        Me.Situacao.Width = 110
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "AmbientalDataProvisorio"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Ambiental"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Width = 70
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "ViabilidadeDataProvisorio"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Viabilidade"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 70
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "SanitarioDataProvisorio"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Sanitario"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Width = 70
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "SetranDataProvisorio"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Setran"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Width = 70
        '
        'BombeiroSituacao
        '
        Me.BombeiroSituacao.DataPropertyName = "BombeiroSituacao"
        Me.BombeiroSituacao.HeaderText = "Situação"
        Me.BombeiroSituacao.Name = "BombeiroSituacao"
        Me.BombeiroSituacao.ReadOnly = True
        Me.BombeiroSituacao.Width = 110
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "BombeiroDataProvisorio"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Bombeiro"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Width = 70
        '
        'VencimentoAlvara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 379)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.LaudosDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "VencimentoAlvara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vencimentos de Alvara de localização"
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
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Situacao As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents BombeiroSituacao As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
End Class
