<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAvisoParcelamento
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
        Me.ParcelamentosAvisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParcelamentosAvisoTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosAvisoTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVerParcelamentos = New System.Windows.Forms.Button()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.ParcelamentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnTodosParcel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonHoje = New System.Windows.Forms.Button()
        Me.ButtonImportarData = New System.Windows.Forms.Button()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosAvisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParcelamentosAvisoBindingSource
        '
        Me.ParcelamentosAvisoBindingSource.DataMember = "ParcelamentosAviso"
        Me.ParcelamentosAvisoBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'ParcelamentosAvisoTableAdapter
        '
        Me.ParcelamentosAvisoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
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
        Me.TableAdapterManager.ParcelamentosAvisoTableAdapter = Me.ParcelamentosAvisoTableAdapter
        Me.TableAdapterManager.ParcelamentosTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.Location = New System.Drawing.Point(443, 0)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(134, 60)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 15
        Me.BtnFechar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Lembrete de hoje e Para Fazer:"
        '
        'BtnVerParcelamentos
        '
        Me.BtnVerParcelamentos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnVerParcelamentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVerParcelamentos.FlatAppearance.BorderSize = 5
        Me.BtnVerParcelamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVerParcelamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerParcelamentos.ForeColor = System.Drawing.Color.Black
        Me.BtnVerParcelamentos.Location = New System.Drawing.Point(261, 292)
        Me.BtnVerParcelamentos.Name = "BtnVerParcelamentos"
        Me.BtnVerParcelamentos.Size = New System.Drawing.Size(309, 58)
        Me.BtnVerParcelamentos.TabIndex = 18
        Me.BtnVerParcelamentos.Text = "Controle de Parcelamentos"
        Me.BtnVerParcelamentos.UseVisualStyleBackColor = False
        '
        'ParcelamentosBindingSource
        '
        Me.ParcelamentosBindingSource.DataMember = "Parcelamentos"
        Me.ParcelamentosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'ParcelamentosTableAdapter
        '
        Me.ParcelamentosTableAdapter.ClearBeforeFill = True
        '
        'ParcelamentosDataGridView
        '
        Me.ParcelamentosDataGridView.AllowUserToAddRows = False
        Me.ParcelamentosDataGridView.AllowUserToDeleteRows = False
        Me.ParcelamentosDataGridView.AllowUserToOrderColumns = True
        Me.ParcelamentosDataGridView.AutoGenerateColumns = False
        Me.ParcelamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParcelamentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.ParcelamentosDataGridView.DataSource = Me.ParcelamentosBindingSource
        Me.ParcelamentosDataGridView.Location = New System.Drawing.Point(12, 66)
        Me.ParcelamentosDataGridView.Name = "ParcelamentosDataGridView"
        Me.ParcelamentosDataGridView.Size = New System.Drawing.Size(558, 220)
        Me.ParcelamentosDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RazaoSocial"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 500
        '
        'BtnTodosParcel
        '
        Me.BtnTodosParcel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTodosParcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTodosParcel.FlatAppearance.BorderSize = 5
        Me.BtnTodosParcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTodosParcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTodosParcel.ForeColor = System.Drawing.Color.Black
        Me.BtnTodosParcel.Location = New System.Drawing.Point(12, 292)
        Me.BtnTodosParcel.Name = "BtnTodosParcel"
        Me.BtnTodosParcel.Size = New System.Drawing.Size(243, 58)
        Me.BtnTodosParcel.TabIndex = 21
        Me.BtnTodosParcel.Text = "Todos Parcelamentos"
        Me.BtnTodosParcel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Data:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(61, 3)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(82, 24)
        Me.MaskedTextBox1.TabIndex = 23
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'ButtonHoje
        '
        Me.ButtonHoje.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonHoje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonHoje.Location = New System.Drawing.Point(149, 1)
        Me.ButtonHoje.Name = "ButtonHoje"
        Me.ButtonHoje.Size = New System.Drawing.Size(75, 26)
        Me.ButtonHoje.TabIndex = 24
        Me.ButtonHoje.Text = "Hoje"
        Me.ButtonHoje.UseVisualStyleBackColor = False
        '
        'ButtonImportarData
        '
        Me.ButtonImportarData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonImportarData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonImportarData.Location = New System.Drawing.Point(230, 1)
        Me.ButtonImportarData.Name = "ButtonImportarData"
        Me.ButtonImportarData.Size = New System.Drawing.Size(142, 26)
        Me.ButtonImportarData.TabIndex = 25
        Me.ButtonImportarData.Text = "Importar Data"
        Me.ButtonImportarData.UseVisualStyleBackColor = False
        '
        'FrmAvisoParcelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 363)
        Me.Controls.Add(Me.ButtonImportarData)
        Me.Controls.Add(Me.ButtonHoje)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTodosParcel)
        Me.Controls.Add(Me.ParcelamentosDataGridView)
        Me.Controls.Add(Me.BtnVerParcelamentos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFechar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmAvisoParcelamento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle Parcelamentos"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosAvisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosAvisoBindingSource As BindingSource
    Friend WithEvents ParcelamentosAvisoTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosAvisoTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnFechar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnVerParcelamentos As Button
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents ParcelamentosTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter
    Friend WithEvents ParcelamentosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BtnTodosParcel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ButtonHoje As Button
    Friend WithEvents ButtonImportarData As Button
End Class
