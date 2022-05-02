<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpresaAltStatus
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
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresaAltStatus))
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.CADstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CADstatusDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDCADstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CADstatusTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADstatusTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CADstatusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.BackColor = System.Drawing.Color.Transparent
        DescricaoLabel.Location = New System.Drawing.Point(24, 68)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 30
        DescricaoLabel.Text = "Descricao:"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Location = New System.Drawing.Point(551, 80)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 23)
        Me.BtnFechar.TabIndex = 29
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Location = New System.Drawing.Point(476, 79)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 23)
        Me.BtnSalvar.TabIndex = 28
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(476, 51)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(69, 22)
        Me.BtnNovo.TabIndex = 26
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = CType(resources.GetObject("BtnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(551, 51)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(69, 23)
        Me.BtnExcluir.TabIndex = 27
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CADstatusBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(88, 65)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(370, 20)
        Me.DescricaoTextBox.TabIndex = 31
        '
        'CADstatusBindingSource
        '
        Me.CADstatusBindingSource.DataMember = "CADstatus"
        Me.CADstatusBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CADstatusDataGridView
        '
        Me.CADstatusDataGridView.AllowUserToAddRows = False
        Me.CADstatusDataGridView.AllowUserToDeleteRows = False
        Me.CADstatusDataGridView.AutoGenerateColumns = False
        Me.CADstatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CADstatusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCADstatusDataGridViewTextBoxColumn, Me.Descricao})
        Me.CADstatusDataGridView.DataSource = Me.CADstatusBindingSource
        Me.CADstatusDataGridView.Location = New System.Drawing.Point(18, 155)
        Me.CADstatusDataGridView.Name = "CADstatusDataGridView"
        Me.CADstatusDataGridView.ReadOnly = True
        Me.CADstatusDataGridView.Size = New System.Drawing.Size(507, 209)
        Me.CADstatusDataGridView.TabIndex = 31
        '
        'IDCADstatusDataGridViewTextBoxColumn
        '
        Me.IDCADstatusDataGridViewTextBoxColumn.DataPropertyName = "ID_CADstatus"
        Me.IDCADstatusDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDCADstatusDataGridViewTextBoxColumn.Name = "IDCADstatusDataGridViewTextBoxColumn"
        Me.IDCADstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCADstatusDataGridViewTextBoxColumn.Width = 50
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descricao"
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        Me.Descricao.Width = 400
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(531, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 32)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CADstatusTableAdapter
        '
        Me.CADstatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Me.CADstatusTableAdapter
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Controle do Status das Empresas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Consulta"
        '
        'FrmEmpresaAltStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 375)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CADstatusDataGridView)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnExcluir)
        Me.KeyPreview = True
        Me.Name = "FrmEmpresaAltStatus"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle dos Status em Empresas"
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CADstatusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents CADstatusBindingSource As BindingSource
    Friend WithEvents CADstatusTableAdapter As PrinceDBDataSetTableAdapters.CADstatusTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents CADstatusDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDCADstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
End Class
