<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLigacaoAlvara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLigacaoAlvara))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LaudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BombeiroExigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmbientalExigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViabilidadeExigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanitarioExigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SetranExigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
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
        Me.LaudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn58, Me.BombeiroExigencia, Me.AmbientalExigencia, Me.ViabilidadeExigencia, Me.SanitarioExigencia, Me.SetranExigencia})
        Me.LaudosDataGridView.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.LaudosDataGridView.Name = "LaudosDataGridView"
        Me.LaudosDataGridView.ReadOnly = True
        Me.LaudosDataGridView.Size = New System.Drawing.Size(556, 220)
        Me.LaudosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 230
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Nlaudo"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Nº. do Laudo"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 70
        '
        'BombeiroExigencia
        '
        Me.BombeiroExigencia.DataPropertyName = "BombeiroExigencia"
        Me.BombeiroExigencia.HeaderText = "Exigência"
        Me.BombeiroExigencia.Name = "BombeiroExigencia"
        Me.BombeiroExigencia.ReadOnly = True
        Me.BombeiroExigencia.Width = 200
        '
        'AmbientalExigencia
        '
        Me.AmbientalExigencia.DataPropertyName = "AmbientalExigencia"
        Me.AmbientalExigencia.HeaderText = "Exigência"
        Me.AmbientalExigencia.Name = "AmbientalExigencia"
        Me.AmbientalExigencia.ReadOnly = True
        Me.AmbientalExigencia.Width = 200
        '
        'ViabilidadeExigencia
        '
        Me.ViabilidadeExigencia.DataPropertyName = "ViabilidadeExigencia"
        Me.ViabilidadeExigencia.HeaderText = "Exigência"
        Me.ViabilidadeExigencia.Name = "ViabilidadeExigencia"
        Me.ViabilidadeExigencia.ReadOnly = True
        Me.ViabilidadeExigencia.Width = 200
        '
        'SanitarioExigencia
        '
        Me.SanitarioExigencia.DataPropertyName = "SanitarioExigencia"
        Me.SanitarioExigencia.HeaderText = "Exigência"
        Me.SanitarioExigencia.Name = "SanitarioExigencia"
        Me.SanitarioExigencia.ReadOnly = True
        Me.SanitarioExigencia.Width = 200
        '
        'SetranExigencia
        '
        Me.SetranExigencia.DataPropertyName = "SetranExigencia"
        Me.SetranExigencia.HeaderText = "Exigência"
        Me.SetranExigencia.Name = "SetranExigencia"
        Me.SetranExigencia.ReadOnly = True
        Me.SetranExigencia.Width = 200
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(139, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 24)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bombeiros", "Ambiental", "Viabilidade", "Sanitario", "Setran"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Controle de Ligações"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(477, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Location = New System.Drawing.Point(499, 36)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(69, 23)
        Me.Button13.TabIndex = 56
        Me.Button13.Text = "Telefones"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'FrmLigacaoAlvara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 335)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LaudosDataGridView)
        Me.KeyPreview = True
        Me.Name = "FrmLigacaoAlvara"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Alvará"
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents BombeiroExigencia As DataGridViewTextBoxColumn
    Friend WithEvents AmbientalExigencia As DataGridViewTextBoxColumn
    Friend WithEvents ViabilidadeExigencia As DataGridViewTextBoxColumn
    Friend WithEvents SanitarioExigencia As DataGridViewTextBoxColumn
    Friend WithEvents SetranExigencia As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button13 As Button
End Class
