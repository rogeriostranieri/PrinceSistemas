﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControleSituacaoAlvara
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
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControleSituacaoAlvara))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CADSituacaoAlvaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CADSituacaoAlvaraTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADSituacaoAlvaraTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.CADSituacaoAlvaraDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_CADSituacaoAlv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CADSituacaoAlvaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CADSituacaoAlvaraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.BackColor = System.Drawing.Color.Transparent
        DescricaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.Location = New System.Drawing.Point(12, 90)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(80, 18)
        DescricaoLabel.TabIndex = 2
        DescricaoLabel.Text = "Descricao:"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CADSituacaoAlvaraBindingSource
        '
        Me.CADSituacaoAlvaraBindingSource.DataMember = "CADSituacaoAlvara"
        Me.CADSituacaoAlvaraBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'CADSituacaoAlvaraTableAdapter
        '
        Me.CADSituacaoAlvaraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Me.CADSituacaoAlvaraTableAdapter
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
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
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CADSituacaoAlvaraDataGridView
        '
        Me.CADSituacaoAlvaraDataGridView.AllowUserToAddRows = False
        Me.CADSituacaoAlvaraDataGridView.AllowUserToDeleteRows = False
        Me.CADSituacaoAlvaraDataGridView.AutoGenerateColumns = False
        Me.CADSituacaoAlvaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CADSituacaoAlvaraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CADSituacaoAlv, Me.DataGridViewTextBoxColumn2})
        Me.CADSituacaoAlvaraDataGridView.DataSource = Me.CADSituacaoAlvaraBindingSource
        Me.CADSituacaoAlvaraDataGridView.Location = New System.Drawing.Point(12, 157)
        Me.CADSituacaoAlvaraDataGridView.Name = "CADSituacaoAlvaraDataGridView"
        Me.CADSituacaoAlvaraDataGridView.ReadOnly = True
        Me.CADSituacaoAlvaraDataGridView.Size = New System.Drawing.Size(552, 191)
        Me.CADSituacaoAlvaraDataGridView.TabIndex = 1
        '
        'ID_CADSituacaoAlv
        '
        Me.ID_CADSituacaoAlv.DataPropertyName = "ID_CADSituacaoAlv"
        Me.ID_CADSituacaoAlv.HeaderText = "ID"
        Me.ID_CADSituacaoAlv.Name = "ID_CADSituacaoAlv"
        Me.ID_CADSituacaoAlv.ReadOnly = True
        Me.ID_CADSituacaoAlv.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Situação"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 450
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CADSituacaoAlvaraBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(98, 87)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(466, 24)
        Me.DescricaoTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 27)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(420, 354)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 27)
        Me.BtnFechar.TabIndex = 36
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(345, 354)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 27)
        Me.BtnSalvar.TabIndex = 35
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(270, 354)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(69, 27)
        Me.BtnNovo.TabIndex = 33
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = CType(resources.GetObject("BtnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(495, 354)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(69, 27)
        Me.BtnExcluir.TabIndex = 34
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Controle do Situação das Empresas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Consulta"
        '
        'FrmControleSituacaoAlvara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(577, 387)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(Me.CADSituacaoAlvaraDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmControleSituacaoAlvara"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de situação de alvará"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CADSituacaoAlvaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CADSituacaoAlvaraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents CADSituacaoAlvaraBindingSource As BindingSource
    Friend WithEvents CADSituacaoAlvaraTableAdapter As PrinceDBDataSetTableAdapters.CADSituacaoAlvaraTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CADSituacaoAlvaraDataGridView As DataGridView
    Friend WithEvents ID_CADSituacaoAlv As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
