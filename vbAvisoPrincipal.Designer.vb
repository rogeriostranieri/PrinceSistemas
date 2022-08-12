<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VbAvisoPrincipal
    Inherits PrinceSistemas.Avisos

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.LaudosDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.ButtonMais7 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Me.LaudosTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Vencimento de Alvará"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(491, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 21)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(415, 448)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox2.TabIndex = 18
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'LaudosDataGridView1
        '
        Me.LaudosDataGridView1.AllowUserToAddRows = False
        Me.LaudosDataGridView1.AllowUserToDeleteRows = False
        Me.LaudosDataGridView1.AllowUserToOrderColumns = True
        Me.LaudosDataGridView1.AutoGenerateColumns = False
        Me.LaudosDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LaudosDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LaudosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaudosDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.LaudosDataGridView1.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView1.Location = New System.Drawing.Point(5, 471)
        Me.LaudosDataGridView1.Name = "LaudosDataGridView1"
        Me.LaudosDataGridView1.ReadOnly = True
        Me.LaudosDataGridView1.Size = New System.Drawing.Size(544, 115)
        Me.LaudosDataGridView1.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.LaudosDataGridView1, "Clique na empresa para abrir")
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(40, 216)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 21
        '
        'ButtonMais7
        '
        Me.ButtonMais7.BackColor = System.Drawing.Color.White
        Me.ButtonMais7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMais7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMais7.Location = New System.Drawing.Point(360, 592)
        Me.ButtonMais7.Name = "ButtonMais7"
        Me.ButtonMais7.Size = New System.Drawing.Size(189, 21)
        Me.ButtonMais7.TabIndex = 22
        Me.ButtonMais7.Text = "Consulta de Vencimento de Alvarás"
        Me.ButtonMais7.UseVisualStyleBackColor = False
        '
        'VbAvisoPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(555, 619)
        Me.Controls.Add(Me.ButtonMais7)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.LaudosDataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VbAvisoPrincipal"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.MaskedTextBox2, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.LaudosDataGridView1, 0)
        Me.Controls.SetChildIndex(Me.MonthCalendar2, 0)
        Me.Controls.SetChildIndex(Me.ButtonMais7, 0)
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend Shadows WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend Shadows WithEvents LaudosBindingSource As BindingSource
    Friend Shadows WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend Shadows WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents LaudosDataGridView1 As DataGridView
    Friend WithEvents MonthCalendar2 As MonthCalendar
#Disable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonMais7 As Button
    Friend WithEvents ToolTip1 As ToolTip
#Enable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'


End Class
