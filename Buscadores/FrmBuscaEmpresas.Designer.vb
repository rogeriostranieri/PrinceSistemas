﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuscaEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscaEmpresas))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EmpresasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsavelNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocoloJuntaComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocoloREDESIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IEComprovante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IEeProcNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPesquisaRazaoSocial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPesquisaCNPJ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPesquisaProtJunta = New System.Windows.Forms.TextBox()
        Me.TxtPesquisaProtRedeSim = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPesquisaCompEstado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPesquisaProtEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxResponsavel = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasDataGridView
        '
        Me.EmpresasDataGridView.AllowUserToAddRows = False
        Me.EmpresasDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasDataGridView.AllowUserToOrderColumns = True
        Me.EmpresasDataGridView.AutoGenerateColumns = False
        Me.EmpresasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.EmpresasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.EmpresasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ResponsavelNome, Me.ProtocoloJuntaComercial, Me.ProtocoloREDESIM, Me.IEComprovante, Me.IEeProcNum})
        Me.EmpresasDataGridView.DataSource = Me.EmpresasBindingSource
        Me.EmpresasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpresasDataGridView.Location = New System.Drawing.Point(561, 66)
        Me.EmpresasDataGridView.Name = "EmpresasDataGridView"
        Me.EmpresasDataGridView.ReadOnly = True
        Me.EmpresasDataGridView.Size = New System.Drawing.Size(552, 330)
        Me.EmpresasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razão Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 88
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CNPJ"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CNPJ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 59
        '
        'ResponsavelNome
        '
        Me.ResponsavelNome.DataPropertyName = "NomeResponsavel"
        Me.ResponsavelNome.HeaderText = "Nome do Responsavel"
        Me.ResponsavelNome.Name = "ResponsavelNome"
        Me.ResponsavelNome.ReadOnly = True
        Me.ResponsavelNome.Width = 128
        '
        'ProtocoloJuntaComercial
        '
        Me.ProtocoloJuntaComercial.DataPropertyName = "ProtocoloJuntaComercial"
        Me.ProtocoloJuntaComercial.HeaderText = "Protocolo Junta Comercial"
        Me.ProtocoloJuntaComercial.Name = "ProtocoloJuntaComercial"
        Me.ProtocoloJuntaComercial.ReadOnly = True
        Me.ProtocoloJuntaComercial.Width = 142
        '
        'ProtocoloREDESIM
        '
        Me.ProtocoloREDESIM.DataPropertyName = "ProtocoloREDESIM"
        Me.ProtocoloREDESIM.HeaderText = "Protocolo REDESIM"
        Me.ProtocoloREDESIM.Name = "ProtocoloREDESIM"
        Me.ProtocoloREDESIM.ReadOnly = True
        Me.ProtocoloREDESIM.Width = 118
        '
        'IEComprovante
        '
        Me.IEComprovante.DataPropertyName = "IEComprovante"
        Me.IEComprovante.HeaderText = "Estado Comprovante"
        Me.IEComprovante.Name = "IEComprovante"
        Me.IEComprovante.ReadOnly = True
        Me.IEComprovante.Width = 120
        '
        'IEeProcNum
        '
        Me.IEeProcNum.DataPropertyName = "IEeProcNum"
        Me.IEeProcNum.HeaderText = "Estado eProtocolo"
        Me.IEeProcNum.Name = "IEeProcNum"
        Me.IEeProcNum.ReadOnly = True
        Me.IEeProcNum.Width = 109
        '
        'TxtPesquisaRazaoSocial
        '
        Me.TxtPesquisaRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisaRazaoSocial.Location = New System.Drawing.Point(156, 26)
        Me.TxtPesquisaRazaoSocial.Name = "TxtPesquisaRazaoSocial"
        Me.TxtPesquisaRazaoSocial.Size = New System.Drawing.Size(353, 24)
        Me.TxtPesquisaRazaoSocial.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Razão Social :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Busca dados em Empresas"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(984, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CNPJ :"
        '
        'TxtPesquisaCNPJ
        '
        Me.TxtPesquisaCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisaCNPJ.Location = New System.Drawing.Point(156, 56)
        Me.TxtPesquisaCNPJ.Name = "TxtPesquisaCNPJ"
        Me.TxtPesquisaCNPJ.Size = New System.Drawing.Size(353, 24)
        Me.TxtPesquisaCNPJ.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Junta Comercial Protocolo :"
        '
        'TxtPesquisaProtJunta
        '
        Me.TxtPesquisaProtJunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisaProtJunta.Location = New System.Drawing.Point(209, 156)
        Me.TxtPesquisaProtJunta.Name = "TxtPesquisaProtJunta"
        Me.TxtPesquisaProtJunta.Size = New System.Drawing.Size(300, 24)
        Me.TxtPesquisaProtJunta.TabIndex = 19
        '
        'TxtPesquisaProtRedeSim
        '
        Me.TxtPesquisaProtRedeSim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisaProtRedeSim.Location = New System.Drawing.Point(209, 186)
        Me.TxtPesquisaProtRedeSim.Name = "TxtPesquisaProtRedeSim"
        Me.TxtPesquisaProtRedeSim.Size = New System.Drawing.Size(300, 24)
        Me.TxtPesquisaProtRedeSim.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "REDESIM Protocolo :"
        '
        'TxtPesquisaCompEstado
        '
        Me.TxtPesquisaCompEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisaCompEstado.Location = New System.Drawing.Point(209, 216)
        Me.TxtPesquisaCompEstado.Name = "TxtPesquisaCompEstado"
        Me.TxtPesquisaCompEstado.Size = New System.Drawing.Size(300, 24)
        Me.TxtPesquisaCompEstado.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Estado Comprovante :"
        '
        'TxtPesquisaProtEstado
        '
        Me.TxtPesquisaProtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisaProtEstado.Location = New System.Drawing.Point(209, 246)
        Me.TxtPesquisaProtEstado.Name = "TxtPesquisaProtEstado"
        Me.TxtPesquisaProtEstado.Size = New System.Drawing.Size(300, 24)
        Me.TxtPesquisaProtEstado.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Estado eProtocolo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonLimpar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBoxResponsavel)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisaProtEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisaCompEstado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisaProtRedeSim)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisaProtJunta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisaCNPJ)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisaRazaoSocial)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 330)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Digite aonde deseja localizar"
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.BackgroundImage = CType(resources.GetObject("ButtonLimpar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.Location = New System.Drawing.Point(431, 298)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(78, 32)
        Me.ButtonLimpar.TabIndex = 33
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Responsável :"
        '
        'TextBoxResponsavel
        '
        Me.TextBoxResponsavel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResponsavel.Location = New System.Drawing.Point(156, 86)
        Me.TextBoxResponsavel.Name = "TextBoxResponsavel"
        Me.TextBoxResponsavel.Size = New System.Drawing.Size(353, 24)
        Me.TextBoxResponsavel.TabIndex = 26
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpresasDataGridView, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1116, 399)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'FrmBuscaEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1116, 399)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmBuscaEmpresas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca por Razão Social - Empresas"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasDataGridView As DataGridView
    Friend WithEvents TxtPesquisaRazaoSocial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ResponsavelNome As DataGridViewTextBoxColumn
    Friend WithEvents ProtocoloJuntaComercial As DataGridViewTextBoxColumn
    Friend WithEvents ProtocoloREDESIM As DataGridViewTextBoxColumn
    Friend WithEvents IEComprovante As DataGridViewTextBoxColumn
    Friend WithEvents IEeProcNum As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPesquisaCNPJ As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPesquisaProtJunta As TextBox
    Friend WithEvents TxtPesquisaProtRedeSim As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPesquisaCompEstado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPesquisaProtEstado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxResponsavel As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLimpar As Button
End Class
