<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProtocoladosGeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProtocoladosGeral))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewEmpresas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLaudos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTotalEmpresa = New System.Windows.Forms.Label()
        Me.LblTotallaudos = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnAtualizar = New System.Windows.Forms.PictureBox()
        Me.BtnAtualizar1 = New System.Windows.Forms.PictureBox()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLaudos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAtualizar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BombeiroSituacaoTableAdapter = Nothing
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAEprefMaringaPRTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Me.LaudosTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LaudosTableAdapter
        '
        Me.LaudosTableAdapter.ClearBeforeFill = True
        '
        'LaudosBindingSource
        '
        Me.LaudosBindingSource.DataMember = "Laudos"
        Me.LaudosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'DataGridViewEmpresas
        '
        Me.DataGridViewEmpresas.AllowUserToAddRows = False
        Me.DataGridViewEmpresas.AllowUserToDeleteRows = False
        Me.DataGridViewEmpresas.AllowUserToOrderColumns = True
        Me.DataGridViewEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmpresas.Location = New System.Drawing.Point(24, 95)
        Me.DataGridViewEmpresas.Name = "DataGridViewEmpresas"
        Me.DataGridViewEmpresas.ReadOnly = True
        Me.DataGridViewEmpresas.Size = New System.Drawing.Size(453, 280)
        Me.DataGridViewEmpresas.TabIndex = 0
        '
        'DataGridViewLaudos
        '
        Me.DataGridViewLaudos.AllowUserToAddRows = False
        Me.DataGridViewLaudos.AllowUserToDeleteRows = False
        Me.DataGridViewLaudos.AllowUserToOrderColumns = True
        Me.DataGridViewLaudos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewLaudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLaudos.Location = New System.Drawing.Point(507, 95)
        Me.DataGridViewLaudos.Name = "DataGridViewLaudos"
        Me.DataGridViewLaudos.ReadOnly = True
        Me.DataGridViewLaudos.Size = New System.Drawing.Size(451, 280)
        Me.DataGridViewLaudos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Protocolados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Empresas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(503, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Laudos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total encontrado ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(503, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total encontrado ="
        '
        'LblTotalEmpresa
        '
        Me.LblTotalEmpresa.AutoSize = True
        Me.LblTotalEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalEmpresa.Location = New System.Drawing.Point(170, 378)
        Me.LblTotalEmpresa.Name = "LblTotalEmpresa"
        Me.LblTotalEmpresa.Size = New System.Drawing.Size(57, 20)
        Me.LblTotalEmpresa.TabIndex = 7
        Me.LblTotalEmpresa.Text = "Label6"
        '
        'LblTotallaudos
        '
        Me.LblTotallaudos.AutoSize = True
        Me.LblTotallaudos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotallaudos.Location = New System.Drawing.Point(651, 378)
        Me.LblTotallaudos.Name = "LblTotallaudos"
        Me.LblTotallaudos.Size = New System.Drawing.Size(57, 20)
        Me.LblTotallaudos.TabIndex = 8
        Me.LblTotallaudos.Text = "Label6"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(824, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAtualizar.Image = CType(resources.GetObject("BtnAtualizar.Image"), System.Drawing.Image)
        Me.BtnAtualizar.Location = New System.Drawing.Point(442, 378)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(35, 29)
        Me.BtnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAtualizar.TabIndex = 16
        Me.BtnAtualizar.TabStop = False
        '
        'BtnAtualizar1
        '
        Me.BtnAtualizar1.BackColor = System.Drawing.Color.Transparent
        Me.BtnAtualizar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtualizar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAtualizar1.Image = CType(resources.GetObject("BtnAtualizar1.Image"), System.Drawing.Image)
        Me.BtnAtualizar1.Location = New System.Drawing.Point(923, 378)
        Me.BtnAtualizar1.Name = "BtnAtualizar1"
        Me.BtnAtualizar1.Size = New System.Drawing.Size(35, 29)
        Me.BtnAtualizar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAtualizar1.TabIndex = 17
        Me.BtnAtualizar1.TabStop = False
        '
        'FrmProtocoladosGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(970, 421)
        Me.Controls.Add(Me.BtnAtualizar1)
        Me.Controls.Add(Me.BtnAtualizar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblTotallaudos)
        Me.Controls.Add(Me.LblTotalEmpresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewLaudos)
        Me.Controls.Add(Me.DataGridViewEmpresas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProtocoladosGeral"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLaudos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAtualizar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents DataGridViewEmpresas As DataGridView
    Friend WithEvents DataGridViewLaudos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblTotalEmpresa As Label
    Friend WithEvents LblTotallaudos As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnAtualizar As PictureBox
    Friend WithEvents BtnAtualizar1 As PictureBox
End Class
