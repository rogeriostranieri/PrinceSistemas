﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContatos
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim ID_ContatosLabel As System.Windows.Forms.Label
        Dim Telefone_ResidencialLabel As System.Windows.Forms.Label
        Dim Telefone_TrabalhoLabel As System.Windows.Forms.Label
        Dim Telefone_Celular_ParticularLabel As System.Windows.Forms.Label
        Dim Telefone_Celular_ContatoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim End_CEPLabel As System.Windows.Forms.Label
        Dim End_RuaLabel As System.Windows.Forms.Label
        Dim End_NumeroLabel As System.Windows.Forms.Label
        Dim End_CompLabel As System.Windows.Forms.Label
        Dim End_BairroLabel As System.Windows.Forms.Label
        Dim End_CidadeLabel As System.Windows.Forms.Label
        Dim End_EstadoLabel As System.Windows.Forms.Label
        Dim End_PaisLabel As System.Windows.Forms.Label
        Dim Outras_InformacoesLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContatos))
        Me.ContatosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ContatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ContatosLabel1 = New System.Windows.Forms.Label()
        Me.Telefone_ResidencialMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone_TrabalhoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone_Celular_ParticularMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone_Celular_ContatoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.End_CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BtnPreencher = New System.Windows.Forms.Button()
        Me.End_RuaTextBox = New System.Windows.Forms.TextBox()
        Me.End_NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.End_CompTextBox = New System.Windows.Forms.TextBox()
        Me.End_BairroTextBox = New System.Windows.Forms.TextBox()
        Me.End_CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.End_EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.End_PaisTextBox = New System.Windows.Forms.TextBox()
        Me.Outras_InformacoesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupoContato = New System.Windows.Forms.GroupBox()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.ContatosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.ContatosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        NomeLabel = New System.Windows.Forms.Label()
        ID_ContatosLabel = New System.Windows.Forms.Label()
        Telefone_ResidencialLabel = New System.Windows.Forms.Label()
        Telefone_TrabalhoLabel = New System.Windows.Forms.Label()
        Telefone_Celular_ParticularLabel = New System.Windows.Forms.Label()
        Telefone_Celular_ContatoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        End_CEPLabel = New System.Windows.Forms.Label()
        End_RuaLabel = New System.Windows.Forms.Label()
        End_NumeroLabel = New System.Windows.Forms.Label()
        End_CompLabel = New System.Windows.Forms.Label()
        End_BairroLabel = New System.Windows.Forms.Label()
        End_CidadeLabel = New System.Windows.Forms.Label()
        End_EstadoLabel = New System.Windows.Forms.Label()
        End_PaisLabel = New System.Windows.Forms.Label()
        Outras_InformacoesLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CType(Me.ContatosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContatosBindingNavigator.SuspendLayout()
        CType(Me.ContatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupoContato.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(18, 75)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(100, 15)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome Completo:"
        '
        'ID_ContatosLabel
        '
        ID_ContatosLabel.AutoSize = True
        ID_ContatosLabel.Location = New System.Drawing.Point(12, 15)
        ID_ContatosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_ContatosLabel.Name = "ID_ContatosLabel"
        ID_ContatosLabel.Size = New System.Drawing.Size(22, 15)
        ID_ContatosLabel.TabIndex = 5
        ID_ContatosLabel.Text = "ID:"
        '
        'Telefone_ResidencialLabel
        '
        Telefone_ResidencialLabel.AutoSize = True
        Telefone_ResidencialLabel.Location = New System.Drawing.Point(7, 43)
        Telefone_ResidencialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone_ResidencialLabel.Name = "Telefone_ResidencialLabel"
        Telefone_ResidencialLabel.Size = New System.Drawing.Size(75, 15)
        Telefone_ResidencialLabel.TabIndex = 7
        Telefone_ResidencialLabel.Text = "Residencial:"
        '
        'Telefone_TrabalhoLabel
        '
        Telefone_TrabalhoLabel.AutoSize = True
        Telefone_TrabalhoLabel.Location = New System.Drawing.Point(22, 73)
        Telefone_TrabalhoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone_TrabalhoLabel.Name = "Telefone_TrabalhoLabel"
        Telefone_TrabalhoLabel.Size = New System.Drawing.Size(59, 15)
        Telefone_TrabalhoLabel.TabIndex = 9
        Telefone_TrabalhoLabel.Text = "Trabalho:"
        '
        'Telefone_Celular_ParticularLabel
        '
        Telefone_Celular_ParticularLabel.AutoSize = True
        Telefone_Celular_ParticularLabel.Location = New System.Drawing.Point(300, 43)
        Telefone_Celular_ParticularLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone_Celular_ParticularLabel.Name = "Telefone_Celular_ParticularLabel"
        Telefone_Celular_ParticularLabel.Size = New System.Drawing.Size(104, 15)
        Telefone_Celular_ParticularLabel.TabIndex = 11
        Telefone_Celular_ParticularLabel.Text = "Celular Particular:"
        '
        'Telefone_Celular_ContatoLabel
        '
        Telefone_Celular_ContatoLabel.AutoSize = True
        Telefone_Celular_ContatoLabel.Location = New System.Drawing.Point(308, 73)
        Telefone_Celular_ContatoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone_Celular_ContatoLabel.Name = "Telefone_Celular_ContatoLabel"
        Telefone_Celular_ContatoLabel.Size = New System.Drawing.Size(94, 15)
        Telefone_Celular_ContatoLabel.TabIndex = 13
        Telefone_Celular_ContatoLabel.Text = "Celular Contato:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(22, 233)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 15)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "e-Mail:"
        '
        'End_CEPLabel
        '
        End_CEPLabel.AutoSize = True
        End_CEPLabel.Location = New System.Drawing.Point(57, 28)
        End_CEPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_CEPLabel.Name = "End_CEPLabel"
        End_CEPLabel.Size = New System.Drawing.Size(34, 15)
        End_CEPLabel.TabIndex = 17
        End_CEPLabel.Text = "CEP:"
        '
        'End_RuaLabel
        '
        End_RuaLabel.AutoSize = True
        End_RuaLabel.Location = New System.Drawing.Point(33, 73)
        End_RuaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_RuaLabel.Name = "End_RuaLabel"
        End_RuaLabel.Size = New System.Drawing.Size(63, 15)
        End_RuaLabel.TabIndex = 20
        End_RuaLabel.Text = "Endereço:"
        '
        'End_NumeroLabel
        '
        End_NumeroLabel.AutoSize = True
        End_NumeroLabel.Location = New System.Drawing.Point(407, 73)
        End_NumeroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_NumeroLabel.Name = "End_NumeroLabel"
        End_NumeroLabel.Size = New System.Drawing.Size(23, 15)
        End_NumeroLabel.TabIndex = 22
        End_NumeroLabel.Text = "Nº:"
        '
        'End_CompLabel
        '
        End_CompLabel.AutoSize = True
        End_CompLabel.Location = New System.Drawing.Point(7, 103)
        End_CompLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_CompLabel.Name = "End_CompLabel"
        End_CompLabel.Size = New System.Drawing.Size(88, 15)
        End_CompLabel.TabIndex = 24
        End_CompLabel.Text = "Complemento:"
        '
        'End_BairroLabel
        '
        End_BairroLabel.AutoSize = True
        End_BairroLabel.Location = New System.Drawing.Point(50, 133)
        End_BairroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_BairroLabel.Name = "End_BairroLabel"
        End_BairroLabel.Size = New System.Drawing.Size(43, 15)
        End_BairroLabel.TabIndex = 26
        End_BairroLabel.Text = "Bairro:"
        '
        'End_CidadeLabel
        '
        End_CidadeLabel.AutoSize = True
        End_CidadeLabel.Location = New System.Drawing.Point(43, 163)
        End_CidadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_CidadeLabel.Name = "End_CidadeLabel"
        End_CidadeLabel.Size = New System.Drawing.Size(49, 15)
        End_CidadeLabel.TabIndex = 28
        End_CidadeLabel.Text = "Cidade:"
        '
        'End_EstadoLabel
        '
        End_EstadoLabel.AutoSize = True
        End_EstadoLabel.Location = New System.Drawing.Point(317, 163)
        End_EstadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_EstadoLabel.Name = "End_EstadoLabel"
        End_EstadoLabel.Size = New System.Drawing.Size(48, 15)
        End_EstadoLabel.TabIndex = 30
        End_EstadoLabel.Text = "Estado:"
        '
        'End_PaisLabel
        '
        End_PaisLabel.AutoSize = True
        End_PaisLabel.Location = New System.Drawing.Point(56, 193)
        End_PaisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        End_PaisLabel.Name = "End_PaisLabel"
        End_PaisLabel.Size = New System.Drawing.Size(34, 15)
        End_PaisLabel.TabIndex = 32
        End_PaisLabel.Text = "País:"
        '
        'Outras_InformacoesLabel
        '
        Outras_InformacoesLabel.AutoSize = True
        Outras_InformacoesLabel.Location = New System.Drawing.Point(31, 526)
        Outras_InformacoesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Outras_InformacoesLabel.Name = "Outras_InformacoesLabel"
        Outras_InformacoesLabel.Size = New System.Drawing.Size(117, 15)
        Outras_InformacoesLabel.TabIndex = 34
        Outras_InformacoesLabel.Text = "Outras Informações:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(481, 18)
        DataLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(36, 15)
        DataLabel.TabIndex = 36
        DataLabel.Text = "Data:"
        '
        'ContatosBindingNavigator
        '
        Me.ContatosBindingNavigator.AddNewItem = Nothing
        Me.ContatosBindingNavigator.BindingSource = Me.ContatosBindingSource
        Me.ContatosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContatosBindingNavigator.DeleteItem = Nothing
        Me.ContatosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1})
        Me.ContatosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContatosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContatosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContatosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContatosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContatosBindingNavigator.Name = "ContatosBindingNavigator"
        Me.ContatosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContatosBindingNavigator.Size = New System.Drawing.Size(747, 25)
        Me.ContatosBindingNavigator.TabIndex = 0
        Me.ContatosBindingNavigator.Text = "BindingNavigator1"
        '
        'ContatosBindingSource
        '
        Me.ContatosBindingSource.DataMember = "Contatos"
        Me.ContatosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(46, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripLabel1.Text = "Buscar por Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(124, 72)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(434, 21)
        Me.NomeTextBox.TabIndex = 2
        '
        'ID_ContatosLabel1
        '
        Me.ID_ContatosLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "ID_Contatos", True))
        Me.ID_ContatosLabel1.Location = New System.Drawing.Point(37, 15)
        Me.ID_ContatosLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ID_ContatosLabel1.Name = "ID_ContatosLabel1"
        Me.ID_ContatosLabel1.Size = New System.Drawing.Size(66, 18)
        Me.ID_ContatosLabel1.TabIndex = 6
        Me.ID_ContatosLabel1.Text = "Label1"
        '
        'Telefone_ResidencialMaskedTextBox
        '
        Me.Telefone_ResidencialMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Telefone_Residencial", True))
        Me.Telefone_ResidencialMaskedTextBox.Location = New System.Drawing.Point(90, 39)
        Me.Telefone_ResidencialMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Telefone_ResidencialMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone_ResidencialMaskedTextBox.Name = "Telefone_ResidencialMaskedTextBox"
        Me.Telefone_ResidencialMaskedTextBox.Size = New System.Drawing.Size(102, 21)
        Me.Telefone_ResidencialMaskedTextBox.TabIndex = 8
        '
        'Telefone_TrabalhoMaskedTextBox
        '
        Me.Telefone_TrabalhoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Telefone_Trabalho", True))
        Me.Telefone_TrabalhoMaskedTextBox.Location = New System.Drawing.Point(90, 69)
        Me.Telefone_TrabalhoMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Telefone_TrabalhoMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone_TrabalhoMaskedTextBox.Name = "Telefone_TrabalhoMaskedTextBox"
        Me.Telefone_TrabalhoMaskedTextBox.Size = New System.Drawing.Size(102, 21)
        Me.Telefone_TrabalhoMaskedTextBox.TabIndex = 10
        '
        'Telefone_Celular_ParticularMaskedTextBox
        '
        Me.Telefone_Celular_ParticularMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Telefone_Celular_Particular", True))
        Me.Telefone_Celular_ParticularMaskedTextBox.Location = New System.Drawing.Point(411, 39)
        Me.Telefone_Celular_ParticularMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Telefone_Celular_ParticularMaskedTextBox.Mask = "(99) 00000-0000"
        Me.Telefone_Celular_ParticularMaskedTextBox.Name = "Telefone_Celular_ParticularMaskedTextBox"
        Me.Telefone_Celular_ParticularMaskedTextBox.Size = New System.Drawing.Size(104, 21)
        Me.Telefone_Celular_ParticularMaskedTextBox.TabIndex = 12
        '
        'Telefone_Celular_ContatoMaskedTextBox
        '
        Me.Telefone_Celular_ContatoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Telefone_Celular_Contato", True))
        Me.Telefone_Celular_ContatoMaskedTextBox.Location = New System.Drawing.Point(411, 69)
        Me.Telefone_Celular_ContatoMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Telefone_Celular_ContatoMaskedTextBox.Mask = "(99) 00000-0000"
        Me.Telefone_Celular_ContatoMaskedTextBox.Name = "Telefone_Celular_ContatoMaskedTextBox"
        Me.Telefone_Celular_ContatoMaskedTextBox.Size = New System.Drawing.Size(104, 21)
        Me.Telefone_Celular_ContatoMaskedTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(69, 230)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(461, 21)
        Me.EmailTextBox.TabIndex = 16
        '
        'End_CEPMaskedTextBox
        '
        Me.End_CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_CEP", True))
        Me.End_CEPMaskedTextBox.Location = New System.Drawing.Point(100, 24)
        Me.End_CEPMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_CEPMaskedTextBox.Mask = "0000-000"
        Me.End_CEPMaskedTextBox.Name = "End_CEPMaskedTextBox"
        Me.End_CEPMaskedTextBox.Size = New System.Drawing.Size(62, 21)
        Me.End_CEPMaskedTextBox.TabIndex = 18
        '
        'BtnPreencher
        '
        Me.BtnPreencher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreencher.Location = New System.Drawing.Point(170, 22)
        Me.BtnPreencher.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnPreencher.Name = "BtnPreencher"
        Me.BtnPreencher.Size = New System.Drawing.Size(77, 29)
        Me.BtnPreencher.TabIndex = 19
        Me.BtnPreencher.Text = "Preencher"
        Me.BtnPreencher.UseVisualStyleBackColor = True
        '
        'End_RuaTextBox
        '
        Me.End_RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Rua", True))
        Me.End_RuaTextBox.Location = New System.Drawing.Point(100, 69)
        Me.End_RuaTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_RuaTextBox.Name = "End_RuaTextBox"
        Me.End_RuaTextBox.Size = New System.Drawing.Size(299, 21)
        Me.End_RuaTextBox.TabIndex = 21
        '
        'End_NumeroTextBox
        '
        Me.End_NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Numero", True))
        Me.End_NumeroTextBox.Location = New System.Drawing.Point(435, 69)
        Me.End_NumeroTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_NumeroTextBox.Name = "End_NumeroTextBox"
        Me.End_NumeroTextBox.Size = New System.Drawing.Size(80, 21)
        Me.End_NumeroTextBox.TabIndex = 23
        '
        'End_CompTextBox
        '
        Me.End_CompTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Comp", True))
        Me.End_CompTextBox.Location = New System.Drawing.Point(100, 99)
        Me.End_CompTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_CompTextBox.Name = "End_CompTextBox"
        Me.End_CompTextBox.Size = New System.Drawing.Size(237, 21)
        Me.End_CompTextBox.TabIndex = 25
        '
        'End_BairroTextBox
        '
        Me.End_BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Bairro", True))
        Me.End_BairroTextBox.Location = New System.Drawing.Point(100, 129)
        Me.End_BairroTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_BairroTextBox.Name = "End_BairroTextBox"
        Me.End_BairroTextBox.Size = New System.Drawing.Size(237, 21)
        Me.End_BairroTextBox.TabIndex = 27
        '
        'End_CidadeTextBox
        '
        Me.End_CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Cidade", True))
        Me.End_CidadeTextBox.Location = New System.Drawing.Point(100, 159)
        Me.End_CidadeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_CidadeTextBox.Name = "End_CidadeTextBox"
        Me.End_CidadeTextBox.Size = New System.Drawing.Size(188, 21)
        Me.End_CidadeTextBox.TabIndex = 29
        '
        'End_EstadoTextBox
        '
        Me.End_EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Estado", True))
        Me.End_EstadoTextBox.Location = New System.Drawing.Point(374, 159)
        Me.End_EstadoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_EstadoTextBox.Name = "End_EstadoTextBox"
        Me.End_EstadoTextBox.Size = New System.Drawing.Size(116, 21)
        Me.End_EstadoTextBox.TabIndex = 31
        '
        'End_PaisTextBox
        '
        Me.End_PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "End_Pais", True))
        Me.End_PaisTextBox.Location = New System.Drawing.Point(100, 189)
        Me.End_PaisTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.End_PaisTextBox.Name = "End_PaisTextBox"
        Me.End_PaisTextBox.Size = New System.Drawing.Size(116, 21)
        Me.End_PaisTextBox.TabIndex = 33
        '
        'Outras_InformacoesRichTextBox
        '
        Me.Outras_InformacoesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Outras_Informacoes", True))
        Me.Outras_InformacoesRichTextBox.Location = New System.Drawing.Point(158, 523)
        Me.Outras_InformacoesRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Outras_InformacoesRichTextBox.Name = "Outras_InformacoesRichTextBox"
        Me.Outras_InformacoesRichTextBox.Size = New System.Drawing.Size(401, 110)
        Me.Outras_InformacoesRichTextBox.TabIndex = 35
        Me.Outras_InformacoesRichTextBox.Text = ""
        '
        'DataMaskedTextBox
        '
        Me.DataMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Data", True))
        Me.DataMaskedTextBox.Location = New System.Drawing.Point(526, 15)
        Me.DataMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataMaskedTextBox.Mask = "00/00/0000"
        Me.DataMaskedTextBox.Name = "DataMaskedTextBox"
        Me.DataMaskedTextBox.Size = New System.Drawing.Size(80, 21)
        Me.DataMaskedTextBox.TabIndex = 37
        Me.DataMaskedTextBox.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Telefone_Celular_ContatoLabel)
        Me.GroupBox1.Controls.Add(Me.Telefone_Celular_ContatoMaskedTextBox)
        Me.GroupBox1.Controls.Add(Telefone_Celular_ParticularLabel)
        Me.GroupBox1.Controls.Add(Me.Telefone_Celular_ParticularMaskedTextBox)
        Me.GroupBox1.Controls.Add(Telefone_TrabalhoLabel)
        Me.GroupBox1.Controls.Add(Me.Telefone_TrabalhoMaskedTextBox)
        Me.GroupBox1.Controls.Add(Telefone_ResidencialLabel)
        Me.GroupBox1.Controls.Add(Me.Telefone_ResidencialMaskedTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(544, 115)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telefones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(End_PaisLabel)
        Me.GroupBox2.Controls.Add(Me.End_PaisTextBox)
        Me.GroupBox2.Controls.Add(End_EstadoLabel)
        Me.GroupBox2.Controls.Add(Me.End_EstadoTextBox)
        Me.GroupBox2.Controls.Add(End_CidadeLabel)
        Me.GroupBox2.Controls.Add(Me.End_CidadeTextBox)
        Me.GroupBox2.Controls.Add(End_BairroLabel)
        Me.GroupBox2.Controls.Add(Me.End_BairroTextBox)
        Me.GroupBox2.Controls.Add(Me.BtnPreencher)
        Me.GroupBox2.Controls.Add(End_CompLabel)
        Me.GroupBox2.Controls.Add(Me.End_CompTextBox)
        Me.GroupBox2.Controls.Add(End_NumeroLabel)
        Me.GroupBox2.Controls.Add(Me.End_NumeroTextBox)
        Me.GroupBox2.Controls.Add(End_RuaLabel)
        Me.GroupBox2.Controls.Add(Me.End_RuaTextBox)
        Me.GroupBox2.Controls.Add(End_CEPLabel)
        Me.GroupBox2.Controls.Add(Me.End_CEPMaskedTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 275)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(544, 228)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(393, 18)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 15)
        Me.LinkLabel1.TabIndex = 35
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Site Correios BR"
        '
        'GroupoContato
        '
        Me.GroupoContato.BackColor = System.Drawing.Color.Transparent
        Me.GroupoContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupoContato.Controls.Add(Me.GroupBox2)
        Me.GroupoContato.Controls.Add(Me.GroupBox1)
        Me.GroupoContato.Controls.Add(DataLabel)
        Me.GroupoContato.Controls.Add(Me.DataMaskedTextBox)
        Me.GroupoContato.Controls.Add(Outras_InformacoesLabel)
        Me.GroupoContato.Controls.Add(Me.Outras_InformacoesRichTextBox)
        Me.GroupoContato.Controls.Add(EmailLabel)
        Me.GroupoContato.Controls.Add(Me.EmailTextBox)
        Me.GroupoContato.Controls.Add(ID_ContatosLabel)
        Me.GroupoContato.Controls.Add(Me.ID_ContatosLabel1)
        Me.GroupoContato.Controls.Add(NomeLabel)
        Me.GroupoContato.Controls.Add(Me.NomeTextBox)
        Me.GroupoContato.Location = New System.Drawing.Point(0, 38)
        Me.GroupoContato.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupoContato.Name = "GroupoContato"
        Me.GroupoContato.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupoContato.Size = New System.Drawing.Size(622, 646)
        Me.GroupoContato.TabIndex = 40
        Me.GroupoContato.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(629, 46)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(107, 29)
        Me.BtnNovo.TabIndex = 41
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(629, 118)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(107, 29)
        Me.BtnEditar.TabIndex = 42
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(629, 82)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(107, 29)
        Me.BtnSalvar.TabIndex = 43
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(629, 189)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(107, 29)
        Me.BtnExcluir.TabIndex = 44
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(629, 153)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(107, 29)
        Me.BtnCancelar.TabIndex = 45
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.Location = New System.Drawing.Point(629, 248)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(107, 29)
        Me.BtnFechar.TabIndex = 46
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'ContatosTableAdapter
        '
        Me.ContatosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ContatosTableAdapter = Me.ContatosTableAdapter
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContatosBindingSource, "Nome", True))
        Me.ComboBox1.DataSource = Me.ContatosBindingSource
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(362, 3)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(356, 23)
        Me.ComboBox1.TabIndex = 40
        Me.ComboBox1.ValueMember = "Nome"
        '
        'FrmContatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 685)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.GroupoContato)
        Me.Controls.Add(Me.ContatosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmContatos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contatos"
        CType(Me.ContatosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContatosBindingNavigator.ResumeLayout(False)
        Me.ContatosBindingNavigator.PerformLayout()
        CType(Me.ContatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupoContato.ResumeLayout(False)
        Me.GroupoContato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ContatosBindingSource As BindingSource
    Friend WithEvents ContatosTableAdapter As PrinceDBDataSetTableAdapters.ContatosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContatosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents ID_ContatosLabel1 As Label
    Friend WithEvents Telefone_ResidencialMaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone_TrabalhoMaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone_Celular_ParticularMaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone_Celular_ContatoMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents End_CEPMaskedTextBox As MaskedTextBox
    Friend WithEvents BtnPreencher As Button
    Friend WithEvents End_RuaTextBox As TextBox
    Friend WithEvents End_NumeroTextBox As TextBox
    Friend WithEvents End_CompTextBox As TextBox
    Friend WithEvents End_BairroTextBox As TextBox
    Friend WithEvents End_CidadeTextBox As TextBox
    Friend WithEvents End_EstadoTextBox As TextBox
    Friend WithEvents End_PaisTextBox As TextBox
    Friend WithEvents Outras_InformacoesRichTextBox As RichTextBox
    Friend WithEvents DataMaskedTextBox As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupoContato As GroupBox
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
