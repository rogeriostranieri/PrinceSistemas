﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LembreteInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LembreteInicial))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EmpresasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.LaudosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matriz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonImprimir = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ButtonSalvarEmpresa = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonSalvarlaudo = New System.Windows.Forms.Button()
        Me.ButtonImprimirLaudo = New System.Windows.Forms.Button()
        Me.PrintPreviewDialogLaudo = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentLaudo = New System.Drawing.Printing.PrintDocument()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
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
        'EmpresasDataGridView
        '
        Me.EmpresasDataGridView.AllowUserToAddRows = False
        Me.EmpresasDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasDataGridView.AutoGenerateColumns = False
        Me.EmpresasDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.EmpresasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmpresasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.SEDE, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn33})
        Me.EmpresasDataGridView.DataSource = Me.EmpresasBindingSource
        Me.EmpresasDataGridView.Location = New System.Drawing.Point(12, 82)
        Me.EmpresasDataGridView.Name = "EmpresasDataGridView"
        Me.EmpresasDataGridView.ReadOnly = True
        Me.EmpresasDataGridView.Size = New System.Drawing.Size(648, 163)
        Me.EmpresasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razao Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'SEDE
        '
        Me.SEDE.DataPropertyName = "SEDE"
        Me.SEDE.HeaderText = "Matriz"
        Me.SEDE.Name = "SEDE"
        Me.SEDE.ReadOnly = True
        Me.SEDE.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "EmpCriado"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Criado dia"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Geral"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Observação"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lembrete de Empresas"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(568, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'LaudosDataGridView
        '
        Me.LaudosDataGridView.AllowUserToAddRows = False
        Me.LaudosDataGridView.AllowUserToDeleteRows = False
        Me.LaudosDataGridView.AutoGenerateColumns = False
        Me.LaudosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.LaudosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaudosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaudosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Matriz, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn67})
        Me.LaudosDataGridView.DataSource = Me.LaudosBindingSource
        Me.LaudosDataGridView.Location = New System.Drawing.Point(12, 295)
        Me.LaudosDataGridView.Name = "LaudosDataGridView"
        Me.LaudosDataGridView.ReadOnly = True
        Me.LaudosDataGridView.Size = New System.Drawing.Size(648, 163)
        Me.LaudosDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'Matriz
        '
        Me.Matriz.DataPropertyName = "Matriz"
        Me.Matriz.HeaderText = "Matriz"
        Me.Matriz.Name = "Matriz"
        Me.Matriz.ReadOnly = True
        Me.Matriz.Width = 50
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "Situacao"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Situação"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Width = 150
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "DataCriado"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Criado em"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "ModeloSistema"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Sistema"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lembrete de Laudos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(247, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 37)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LEMBRETES"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 39)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Avisos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimir.Location = New System.Drawing.Point(531, 251)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(129, 27)
        Me.ButtonImprimir.TabIndex = 9
        Me.ButtonImprimir.Text = "Imprimir Empresa"
        Me.ButtonImprimir.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
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
        'ButtonSalvarEmpresa
        '
        Me.ButtonSalvarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalvarEmpresa.Location = New System.Drawing.Point(396, 251)
        Me.ButtonSalvarEmpresa.Name = "ButtonSalvarEmpresa"
        Me.ButtonSalvarEmpresa.Size = New System.Drawing.Size(129, 27)
        Me.ButtonSalvarEmpresa.TabIndex = 10
        Me.ButtonSalvarEmpresa.Text = "Salvar TXT Empresa"
        Me.ButtonSalvarEmpresa.UseVisualStyleBackColor = True
        '
        'ButtonSalvarlaudo
        '
        Me.ButtonSalvarlaudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalvarlaudo.Location = New System.Drawing.Point(396, 464)
        Me.ButtonSalvarlaudo.Name = "ButtonSalvarlaudo"
        Me.ButtonSalvarlaudo.Size = New System.Drawing.Size(129, 27)
        Me.ButtonSalvarlaudo.TabIndex = 12
        Me.ButtonSalvarlaudo.Text = "Salvar TXT Laudo"
        Me.ButtonSalvarlaudo.UseVisualStyleBackColor = True
        '
        'ButtonImprimirLaudo
        '
        Me.ButtonImprimirLaudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimirLaudo.Location = New System.Drawing.Point(531, 464)
        Me.ButtonImprimirLaudo.Name = "ButtonImprimirLaudo"
        Me.ButtonImprimirLaudo.Size = New System.Drawing.Size(129, 27)
        Me.ButtonImprimirLaudo.TabIndex = 11
        Me.ButtonImprimirLaudo.Text = "Imprimir Laudo"
        Me.ButtonImprimirLaudo.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialogLaudo
        '
        Me.PrintPreviewDialogLaudo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogLaudo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogLaudo.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogLaudo.Enabled = True
        Me.PrintPreviewDialogLaudo.Icon = CType(resources.GetObject("PrintPreviewDialogLaudo.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogLaudo.Name = "PrintPreviewDialogLaudo"
        Me.PrintPreviewDialogLaudo.Visible = False
        '
        'LembreteInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(672, 498)
        Me.Controls.Add(Me.ButtonSalvarlaudo)
        Me.Controls.Add(Me.ButtonImprimirLaudo)
        Me.Controls.Add(Me.ButtonSalvarEmpresa)
        Me.Controls.Add(Me.ButtonImprimir)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LaudosDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpresasDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LembreteInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importante"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents LaudosDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SEDE As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Matriz As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonImprimir As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ButtonSalvarEmpresa As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ButtonSalvarlaudo As Button
    Friend WithEvents ButtonImprimirLaudo As Button
    Friend WithEvents PrintPreviewDialogLaudo As PrintPreviewDialog
    Friend WithEvents PrintDocumentLaudo As Printing.PrintDocument
End Class
