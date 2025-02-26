<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEventos
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
        Dim EventosLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EventosEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventosEmpresaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EventosEmpresaTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EventosEmpresaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventosDescrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaFacil = New System.Windows.Forms.CheckBox()
        Me.ReceitaFederal = New System.Windows.Forms.CheckBox()
        Me.ReceitaEstadual = New System.Windows.Forms.CheckBox()
        Me.PrefeituraMunicipal = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimparEventos = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.ButtonOk = New System.Windows.Forms.Button()
        EventosLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventosEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventosEmpresaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventosLabel
        '
        EventosLabel.AutoSize = True
        EventosLabel.BackColor = System.Drawing.Color.Transparent
        EventosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EventosLabel.Location = New System.Drawing.Point(14, 93)
        EventosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EventosLabel.Name = "EventosLabel"
        EventosLabel.Size = New System.Drawing.Size(293, 18)
        EventosLabel.TabIndex = 2
        EventosLabel.Text = "Escolher os Orgãos Governamentais:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(14, 216)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(91, 18)
        Label3.TabIndex = 17
        Label3.Text = "EVENTOS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LISTA DE EVENTOS"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(18, 183)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(793, 24)
        Me.TextBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Localizar:"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.Location = New System.Drawing.Point(655, -1)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(156, 69)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 15
        Me.BtnFechar.TabStop = False
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventosEmpresaBindingSource
        '
        Me.EventosEmpresaBindingSource.DataMember = "EventosEmpresa"
        Me.EventosEmpresaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EventosEmpresaTableAdapter
        '
        Me.EventosEmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.AvisosTableAdapter = Nothing
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
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Me.EventosEmpresaTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosAvisoTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EventosEmpresaDataGridView
        '
        Me.EventosEmpresaDataGridView.AllowUserToAddRows = False
        Me.EventosEmpresaDataGridView.AllowUserToDeleteRows = False
        Me.EventosEmpresaDataGridView.AllowUserToOrderColumns = True
        Me.EventosEmpresaDataGridView.AutoGenerateColumns = False
        Me.EventosEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventosEmpresaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.EventosDescrição})
        Me.EventosEmpresaDataGridView.DataSource = Me.EventosEmpresaBindingSource
        Me.EventosEmpresaDataGridView.Location = New System.Drawing.Point(18, 240)
        Me.EventosEmpresaDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EventosEmpresaDataGridView.Name = "EventosEmpresaDataGridView"
        Me.EventosEmpresaDataGridView.ReadOnly = True
        Me.EventosEmpresaDataGridView.Size = New System.Drawing.Size(793, 269)
        Me.EventosEmpresaDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Eventos"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Eventos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'EventosDescrição
        '
        Me.EventosDescrição.DataPropertyName = "EventosDescrição"
        Me.EventosDescrição.HeaderText = "Explicação"
        Me.EventosDescrição.Name = "EventosDescrição"
        Me.EventosDescrição.ReadOnly = True
        Me.EventosDescrição.Width = 230
        '
        'EmpresaFacil
        '
        Me.EmpresaFacil.AutoSize = True
        Me.EmpresaFacil.BackColor = System.Drawing.Color.Transparent
        Me.EmpresaFacil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaFacil.Location = New System.Drawing.Point(33, 124)
        Me.EmpresaFacil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmpresaFacil.Name = "EmpresaFacil"
        Me.EmpresaFacil.Size = New System.Drawing.Size(122, 22)
        Me.EmpresaFacil.TabIndex = 18
        Me.EmpresaFacil.Text = "Empresa Fácil"
        Me.EmpresaFacil.UseVisualStyleBackColor = False
        '
        'ReceitaFederal
        '
        Me.ReceitaFederal.AutoSize = True
        Me.ReceitaFederal.BackColor = System.Drawing.Color.Transparent
        Me.ReceitaFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceitaFederal.Location = New System.Drawing.Point(194, 124)
        Me.ReceitaFederal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ReceitaFederal.Name = "ReceitaFederal"
        Me.ReceitaFederal.Size = New System.Drawing.Size(130, 22)
        Me.ReceitaFederal.TabIndex = 19
        Me.ReceitaFederal.Text = "Receita Federal"
        Me.ReceitaFederal.UseVisualStyleBackColor = False
        '
        'ReceitaEstadual
        '
        Me.ReceitaEstadual.AutoSize = True
        Me.ReceitaEstadual.BackColor = System.Drawing.Color.Transparent
        Me.ReceitaEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceitaEstadual.Location = New System.Drawing.Point(368, 124)
        Me.ReceitaEstadual.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ReceitaEstadual.Name = "ReceitaEstadual"
        Me.ReceitaEstadual.Size = New System.Drawing.Size(138, 22)
        Me.ReceitaEstadual.TabIndex = 20
        Me.ReceitaEstadual.Text = "Receita Estadual"
        Me.ReceitaEstadual.UseVisualStyleBackColor = False
        '
        'PrefeituraMunicipal
        '
        Me.PrefeituraMunicipal.AutoSize = True
        Me.PrefeituraMunicipal.BackColor = System.Drawing.Color.Transparent
        Me.PrefeituraMunicipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrefeituraMunicipal.Location = New System.Drawing.Point(547, 124)
        Me.PrefeituraMunicipal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PrefeituraMunicipal.Name = "PrefeituraMunicipal"
        Me.PrefeituraMunicipal.Size = New System.Drawing.Size(156, 22)
        Me.PrefeituraMunicipal.TabIndex = 21
        Me.PrefeituraMunicipal.Text = "Prefeitura Municipal"
        Me.PrefeituraMunicipal.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 513)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "* Clique duas vezes para adicionar"
        '
        'BtnLimparEventos
        '
        Me.BtnLimparEventos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLimparEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimparEventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimparEventos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLimparEventos.Location = New System.Drawing.Point(533, 515)
        Me.BtnLimparEventos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnLimparEventos.Name = "BtnLimparEventos"
        Me.BtnLimparEventos.Size = New System.Drawing.Size(135, 32)
        Me.BtnLimparEventos.TabIndex = 46
        Me.BtnLimparEventos.Text = "Limpar Eventos"
        Me.BtnLimparEventos.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.Blue
        Me.BtnEditar.Location = New System.Drawing.Point(390, 515)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(135, 32)
        Me.BtnEditar.TabIndex = 47
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'ButtonOk
        '
        Me.ButtonOk.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOk.ForeColor = System.Drawing.Color.Blue
        Me.ButtonOk.Location = New System.Drawing.Point(676, 515)
        Me.ButtonOk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(135, 32)
        Me.ButtonOk.TabIndex = 48
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = False
        '
        'FrmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 559)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnLimparEventos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrefeituraMunicipal)
        Me.Controls.Add(Me.ReceitaEstadual)
        Me.Controls.Add(Me.ReceitaFederal)
        Me.Controls.Add(Me.EmpresaFacil)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.EventosEmpresaDataGridView)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(EventosLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEventos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Eventos"
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventosEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventosEmpresaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFechar As PictureBox
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EventosEmpresaBindingSource As BindingSource
    Friend WithEvents EventosEmpresaTableAdapter As PrinceDBDataSetTableAdapters.EventosEmpresaTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EventosEmpresaDataGridView As DataGridView
    Friend WithEvents EmpresaFacil As CheckBox
    Friend WithEvents ReceitaFederal As CheckBox
    Friend WithEvents ReceitaEstadual As CheckBox
    Friend WithEvents PrefeituraMunicipal As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLimparEventos As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents EventosDescrição As DataGridViewTextBoxColumn
    Friend WithEvents ButtonOk As Button
End Class
