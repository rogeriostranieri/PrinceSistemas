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
        Dim MesRealizadoLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Me.LblDataAviso = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.ParcelamentosAvisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParcelamentosAvisoTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosAvisoTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ParcelamentosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter()
        Me.MesRealizadoComboBox = New System.Windows.Forms.ComboBox()
        Me.AnoComboBox = New System.Windows.Forms.ComboBox()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParcelamentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnVerParcelamentos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        MesRealizadoLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosAvisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MesRealizadoLabel
        '
        MesRealizadoLabel.AutoSize = True
        MesRealizadoLabel.BackColor = System.Drawing.Color.Transparent
        MesRealizadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesRealizadoLabel.ForeColor = System.Drawing.Color.Black
        MesRealizadoLabel.Location = New System.Drawing.Point(196, 82)
        MesRealizadoLabel.Name = "MesRealizadoLabel"
        MesRealizadoLabel.Size = New System.Drawing.Size(166, 18)
        MesRealizadoLabel.TabIndex = 3
        MesRealizadoLabel.Text = "Mes de fechamento :"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.BackColor = System.Drawing.Color.Transparent
        AnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnoLabel.ForeColor = System.Drawing.Color.Black
        AnoLabel.Location = New System.Drawing.Point(21, 82)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(42, 18)
        AnoLabel.TabIndex = 4
        AnoLabel.Text = "Ano:"
        '
        'LblDataAviso
        '
        Me.LblDataAviso.AutoSize = True
        Me.LblDataAviso.BackColor = System.Drawing.Color.Transparent
        Me.LblDataAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataAviso.ForeColor = System.Drawing.Color.Black
        Me.LblDataAviso.Location = New System.Drawing.Point(200, 9)
        Me.LblDataAviso.Name = "LblDataAviso"
        Me.LblDataAviso.Size = New System.Drawing.Size(95, 31)
        Me.LblDataAviso.TabIndex = 6
        Me.LblDataAviso.Text = "Label2"
        Me.LblDataAviso.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data do Aviso:"
        Me.Label3.Visible = False
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
        Me.TableAdapterManager.ParcelamentosTableAdapter = Me.ParcelamentosTableAdapter
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ParcelamentosTableAdapter
        '
        Me.ParcelamentosTableAdapter.ClearBeforeFill = True
        '
        'MesRealizadoComboBox
        '
        Me.MesRealizadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosAvisoBindingSource, "MesRealizado", True))
        Me.MesRealizadoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesRealizadoComboBox.FormattingEnabled = True
        Me.MesRealizadoComboBox.Location = New System.Drawing.Point(368, 79)
        Me.MesRealizadoComboBox.Name = "MesRealizadoComboBox"
        Me.MesRealizadoComboBox.Size = New System.Drawing.Size(175, 28)
        Me.MesRealizadoComboBox.TabIndex = 9
        '
        'AnoComboBox
        '
        Me.AnoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParcelamentosAvisoBindingSource, "Ano", True))
        Me.AnoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoComboBox.FormattingEnabled = True
        Me.AnoComboBox.Location = New System.Drawing.Point(69, 79)
        Me.AnoComboBox.Name = "AnoComboBox"
        Me.AnoComboBox.Size = New System.Drawing.Size(121, 28)
        Me.AnoComboBox.TabIndex = 10
        '
        'ParcelamentosBindingSource
        '
        Me.ParcelamentosBindingSource.DataMember = "Parcelamentos"
        Me.ParcelamentosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'ParcelamentosDataGridView
        '
        Me.ParcelamentosDataGridView.AllowUserToAddRows = False
        Me.ParcelamentosDataGridView.AllowUserToDeleteRows = False
        Me.ParcelamentosDataGridView.AllowUserToOrderColumns = True
        Me.ParcelamentosDataGridView.AutoGenerateColumns = False
        Me.ParcelamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParcelamentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.ParcelamentosDataGridView.DataSource = Me.ParcelamentosBindingSource
        Me.ParcelamentosDataGridView.Location = New System.Drawing.Point(19, 250)
        Me.ParcelamentosDataGridView.Name = "ParcelamentosDataGridView"
        Me.ParcelamentosDataGridView.ReadOnly = True
        Me.ParcelamentosDataGridView.Size = New System.Drawing.Size(542, 220)
        Me.ParcelamentosDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razao Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 450
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
        Me.Label1.Location = New System.Drawing.Point(13, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Lembrete de hoje:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 31)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fechamento Mensal"
        '
        'BtnVerParcelamentos
        '
        Me.BtnVerParcelamentos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnVerParcelamentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVerParcelamentos.FlatAppearance.BorderSize = 5
        Me.BtnVerParcelamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVerParcelamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerParcelamentos.ForeColor = System.Drawing.Color.White
        Me.BtnVerParcelamentos.Location = New System.Drawing.Point(116, 488)
        Me.BtnVerParcelamentos.Name = "BtnVerParcelamentos"
        Me.BtnVerParcelamentos.Size = New System.Drawing.Size(309, 58)
        Me.BtnVerParcelamentos.TabIndex = 18
        Me.BtnVerParcelamentos.Text = "Controle de Parcelamentos"
        Me.BtnVerParcelamentos.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AnoComboBox)
        Me.GroupBox1.Controls.Add(MesRealizadoLabel)
        Me.GroupBox1.Controls.Add(Me.MesRealizadoComboBox)
        Me.GroupBox1.Controls.Add(AnoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 133)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controle de Parcelamentos"
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
        Me.ClientSize = New System.Drawing.Size(577, 561)
        Me.Controls.Add(Me.BtnVerParcelamentos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.ParcelamentosDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblDataAviso)
        Me.Controls.Add(Me.GroupBox1)
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
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDataAviso As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosAvisoBindingSource As BindingSource
    Friend WithEvents ParcelamentosAvisoTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosAvisoTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MesRealizadoComboBox As ComboBox
    Friend WithEvents AnoComboBox As ComboBox
    Friend WithEvents ParcelamentosTableAdapter As PrinceDBDataSetTableAdapters.ParcelamentosTableAdapter
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents ParcelamentosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BtnFechar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnVerParcelamentos As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
