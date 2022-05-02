<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnotacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnotacoes))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.AnotacoesTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.AnotacoesTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.GroupBoxEditor = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cbofonte = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbotamanho = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MudarCorBotao = New System.Windows.Forms.ToolStripButton()
        Me.BtnRealcar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNegrito = New System.Windows.Forms.ToolStripButton()
        Me.BtnItalico = New System.Windows.Forms.ToolStripButton()
        Me.BtnSublinhado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDataHoraAgora = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnColar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCopiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDesfazer = New System.Windows.Forms.ToolStripButton()
        Me.BtnRefazer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEsquerda = New System.Windows.Forms.ToolStripButton()
        Me.BtnCentral = New System.Windows.Forms.ToolStripButton()
        Me.BtnDireita = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMudaTexto = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInicial = New System.Windows.Forms.Button()
        Me.ButtonLegalizacao = New System.Windows.Forms.Button()
        Me.ButtonFederal = New System.Windows.Forms.Button()
        Me.ButtonEstadual = New System.Windows.Forms.Button()
        Me.ButtonPrefeitura = New System.Windows.Forms.Button()
        Me.ButtonDemais = New System.Windows.Forms.Button()
        Me.RichTextBoxAnotacao = New System.Windows.Forms.RichTextBox()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AnotacoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEditor.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnotacoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnotacoesTableAdapter
        '
        Me.AnotacoesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnotacoesTableAdapter = Me.AnotacoesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBoxEditor
        '
        Me.GroupBoxEditor.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxEditor.Controls.Add(Me.ToolStrip1)
        Me.GroupBoxEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxEditor.Location = New System.Drawing.Point(149, 49)
        Me.GroupBoxEditor.Name = "GroupBoxEditor"
        Me.GroupBoxEditor.Size = New System.Drawing.Size(704, 55)
        Me.GroupBoxEditor.TabIndex = 53
        Me.GroupBoxEditor.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cbofonte, Me.ToolStripSeparator1, Me.cbotamanho, Me.ToolStripSeparator2, Me.MudarCorBotao, Me.BtnRealcar, Me.ToolStripSeparator3, Me.BtnNegrito, Me.BtnItalico, Me.BtnSublinhado, Me.ToolStripSeparator4, Me.BtnDataHoraAgora, Me.ToolStripSeparator5, Me.BtnColar, Me.BtnCopiar, Me.ToolStripSeparator7, Me.BtnPesquisar, Me.ToolStripSeparator8, Me.BtnDesfazer, Me.BtnRefazer, Me.ToolStripSeparator6, Me.BtnEsquerda, Me.BtnCentral, Me.BtnDireita, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(698, 36)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cbofonte
        '
        Me.cbofonte.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cbofonte.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cbofonte.Name = "cbofonte"
        Me.cbofonte.Size = New System.Drawing.Size(201, 36)
        Me.cbofonte.ToolTipText = "Escolha sua fonte do texto"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'cbotamanho
        '
        Me.cbotamanho.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cbotamanho.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cbotamanho.Name = "cbotamanho"
        Me.cbotamanho.Size = New System.Drawing.Size(75, 36)
        Me.cbotamanho.ToolTipText = "Tamanho do texto"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'MudarCorBotao
        '
        Me.MudarCorBotao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MudarCorBotao.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MudarCorBotao.Image = CType(resources.GetObject("MudarCorBotao.Image"), System.Drawing.Image)
        Me.MudarCorBotao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MudarCorBotao.Name = "MudarCorBotao"
        Me.MudarCorBotao.Size = New System.Drawing.Size(23, 33)
        Me.MudarCorBotao.Text = "Cores"
        Me.MudarCorBotao.ToolTipText = "Escolher Cores no texto"
        '
        'BtnRealcar
        '
        Me.BtnRealcar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnRealcar.Image = CType(resources.GetObject("BtnRealcar.Image"), System.Drawing.Image)
        Me.BtnRealcar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRealcar.Name = "BtnRealcar"
        Me.BtnRealcar.Size = New System.Drawing.Size(23, 33)
        Me.BtnRealcar.Text = "Realçar texto"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
        '
        'BtnNegrito
        '
        Me.BtnNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNegrito.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNegrito.Image = CType(resources.GetObject("BtnNegrito.Image"), System.Drawing.Image)
        Me.BtnNegrito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNegrito.Name = "BtnNegrito"
        Me.BtnNegrito.Size = New System.Drawing.Size(23, 33)
        Me.BtnNegrito.Text = "B"
        Me.BtnNegrito.ToolTipText = "Negrito"
        '
        'BtnItalico
        '
        Me.BtnItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnItalico.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalico.Image = CType(resources.GetObject("BtnItalico.Image"), System.Drawing.Image)
        Me.BtnItalico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnItalico.Name = "BtnItalico"
        Me.BtnItalico.Size = New System.Drawing.Size(23, 33)
        Me.BtnItalico.Text = "I"
        Me.BtnItalico.ToolTipText = "Itálico"
        '
        'BtnSublinhado
        '
        Me.BtnSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnSublinhado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSublinhado.Image = CType(resources.GetObject("BtnSublinhado.Image"), System.Drawing.Image)
        Me.BtnSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSublinhado.Name = "BtnSublinhado"
        Me.BtnSublinhado.Size = New System.Drawing.Size(23, 33)
        Me.BtnSublinhado.Text = "S"
        Me.BtnSublinhado.ToolTipText = "Sublinhado"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
        '
        'BtnDataHoraAgora
        '
        Me.BtnDataHoraAgora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDataHoraAgora.Image = CType(resources.GetObject("BtnDataHoraAgora.Image"), System.Drawing.Image)
        Me.BtnDataHoraAgora.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDataHoraAgora.Name = "BtnDataHoraAgora"
        Me.BtnDataHoraAgora.Size = New System.Drawing.Size(23, 33)
        Me.BtnDataHoraAgora.Text = "Data e Hora Agora"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
        '
        'BtnColar
        '
        Me.BtnColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnColar.Image = CType(resources.GetObject("BtnColar.Image"), System.Drawing.Image)
        Me.BtnColar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnColar.Name = "BtnColar"
        Me.BtnColar.Size = New System.Drawing.Size(23, 33)
        Me.BtnColar.Text = "Colar"
        '
        'BtnCopiar
        '
        Me.BtnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCopiar.Image = CType(resources.GetObject("BtnCopiar.Image"), System.Drawing.Image)
        Me.BtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(23, 33)
        Me.BtnCopiar.Text = "Copiar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 36)
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(23, 33)
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.ToolTipText = "Localizar e Subistituir"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 36)
        '
        'BtnDesfazer
        '
        Me.BtnDesfazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDesfazer.Image = CType(resources.GetObject("BtnDesfazer.Image"), System.Drawing.Image)
        Me.BtnDesfazer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDesfazer.Name = "BtnDesfazer"
        Me.BtnDesfazer.Size = New System.Drawing.Size(23, 33)
        Me.BtnDesfazer.Text = "Desfazer"
        '
        'BtnRefazer
        '
        Me.BtnRefazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnRefazer.Image = CType(resources.GetObject("BtnRefazer.Image"), System.Drawing.Image)
        Me.BtnRefazer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefazer.Name = "BtnRefazer"
        Me.BtnRefazer.Size = New System.Drawing.Size(23, 33)
        Me.BtnRefazer.Text = "Refazer"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 36)
        '
        'BtnEsquerda
        '
        Me.BtnEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEsquerda.Image = CType(resources.GetObject("BtnEsquerda.Image"), System.Drawing.Image)
        Me.BtnEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEsquerda.Name = "BtnEsquerda"
        Me.BtnEsquerda.Size = New System.Drawing.Size(23, 33)
        Me.BtnEsquerda.Text = "Organizar à esquerda"
        '
        'BtnCentral
        '
        Me.BtnCentral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCentral.Image = CType(resources.GetObject("BtnCentral.Image"), System.Drawing.Image)
        Me.BtnCentral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCentral.Name = "BtnCentral"
        Me.BtnCentral.Size = New System.Drawing.Size(23, 33)
        Me.BtnCentral.Text = "Organizar no centro"
        '
        'BtnDireita
        '
        Me.BtnDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDireita.Image = CType(resources.GetObject("BtnDireita.Image"), System.Drawing.Image)
        Me.BtnDireita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDireita.Name = "BtnDireita"
        Me.BtnDireita.Size = New System.Drawing.Size(23, 33)
        Me.BtnDireita.Text = "Organizar à direita"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 36)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblMudaTexto)
        Me.GroupBox2.Location = New System.Drawing.Point(149, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 40)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 50)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ANOTAÇÕES : "
        '
        'lblMudaTexto
        '
        Me.lblMudaTexto.BackColor = System.Drawing.Color.Transparent
        Me.lblMudaTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMudaTexto.ForeColor = System.Drawing.Color.Blue
        Me.lblMudaTexto.Location = New System.Drawing.Point(229, 6)
        Me.lblMudaTexto.Name = "lblMudaTexto"
        Me.lblMudaTexto.Size = New System.Drawing.Size(416, 35)
        Me.lblMudaTexto.TabIndex = 55
        Me.lblMudaTexto.Text = "Escolha no menu lateral..."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonLimpar)
        Me.GroupBox1.Controls.Add(Me.ButtonSalvar)
        Me.GroupBox1.Location = New System.Drawing.Point(859, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 104)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.BackgroundImage = CType(resources.GetObject("ButtonLimpar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonLimpar.Location = New System.Drawing.Point(6, 48)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(69, 23)
        Me.ButtonLimpar.TabIndex = 53
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.BackgroundImage = CType(resources.GetObject("ButtonSalvar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalvar.Location = New System.Drawing.Point(6, 19)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(69, 23)
        Me.ButtonSalvar.TabIndex = 51
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonInicial, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonLegalizacao, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonFederal, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonEstadual, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonPrefeitura, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonDemais, 0, 5)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 110)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(124, 213)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ButtonInicial
        '
        Me.ButtonInicial.AutoSize = True
        Me.ButtonInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonInicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonInicial.Location = New System.Drawing.Point(3, 3)
        Me.ButtonInicial.Name = "ButtonInicial"
        Me.ButtonInicial.Size = New System.Drawing.Size(120, 29)
        Me.ButtonInicial.TabIndex = 53
        Me.ButtonInicial.Text = "Inicial"
        Me.ButtonInicial.UseVisualStyleBackColor = True
        '
        'ButtonLegalizacao
        '
        Me.ButtonLegalizacao.AutoSize = True
        Me.ButtonLegalizacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonLegalizacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLegalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLegalizacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonLegalizacao.Location = New System.Drawing.Point(3, 38)
        Me.ButtonLegalizacao.Name = "ButtonLegalizacao"
        Me.ButtonLegalizacao.Size = New System.Drawing.Size(120, 29)
        Me.ButtonLegalizacao.TabIndex = 52
        Me.ButtonLegalizacao.Text = "Legalizacao"
        Me.ButtonLegalizacao.UseVisualStyleBackColor = True
        '
        'ButtonFederal
        '
        Me.ButtonFederal.AutoSize = True
        Me.ButtonFederal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonFederal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFederal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonFederal.Location = New System.Drawing.Point(3, 73)
        Me.ButtonFederal.Name = "ButtonFederal"
        Me.ButtonFederal.Size = New System.Drawing.Size(120, 29)
        Me.ButtonFederal.TabIndex = 54
        Me.ButtonFederal.Text = "Receita Federal"
        Me.ButtonFederal.UseVisualStyleBackColor = True
        '
        'ButtonEstadual
        '
        Me.ButtonEstadual.AutoSize = True
        Me.ButtonEstadual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonEstadual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEstadual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEstadual.Location = New System.Drawing.Point(3, 108)
        Me.ButtonEstadual.Name = "ButtonEstadual"
        Me.ButtonEstadual.Size = New System.Drawing.Size(120, 29)
        Me.ButtonEstadual.TabIndex = 55
        Me.ButtonEstadual.Text = "Receita Estadual"
        Me.ButtonEstadual.UseVisualStyleBackColor = True
        '
        'ButtonPrefeitura
        '
        Me.ButtonPrefeitura.AutoSize = True
        Me.ButtonPrefeitura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrefeitura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrefeitura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrefeitura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPrefeitura.Location = New System.Drawing.Point(3, 143)
        Me.ButtonPrefeitura.Name = "ButtonPrefeitura"
        Me.ButtonPrefeitura.Size = New System.Drawing.Size(120, 29)
        Me.ButtonPrefeitura.TabIndex = 56
        Me.ButtonPrefeitura.Text = "Prefeitura"
        Me.ButtonPrefeitura.UseVisualStyleBackColor = True
        '
        'ButtonDemais
        '
        Me.ButtonDemais.AutoSize = True
        Me.ButtonDemais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDemais.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDemais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDemais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDemais.Location = New System.Drawing.Point(3, 178)
        Me.ButtonDemais.Name = "ButtonDemais"
        Me.ButtonDemais.Size = New System.Drawing.Size(120, 32)
        Me.ButtonDemais.TabIndex = 57
        Me.ButtonDemais.Text = "Demais"
        Me.ButtonDemais.UseVisualStyleBackColor = True
        '
        'RichTextBoxAnotacao
        '
        Me.RichTextBoxAnotacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxAnotacao.Location = New System.Drawing.Point(149, 110)
        Me.RichTextBoxAnotacao.Name = "RichTextBoxAnotacao"
        Me.RichTextBoxAnotacao.Size = New System.Drawing.Size(704, 678)
        Me.RichTextBoxAnotacao.TabIndex = 54
        Me.RichTextBoxAnotacao.Text = ""
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFechar.BackgroundImage = CType(resources.GetObject("ButtonFechar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonFechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonFechar.Location = New System.Drawing.Point(875, 3)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(69, 23)
        Me.ButtonFechar.TabIndex = 52
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.52511!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.11416!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.474886!))
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonFechar, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RichTextBoxAnotacao, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBoxEditor, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.18792!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.81208!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(947, 845)
        Me.TableLayoutPanel5.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'AnotacoesBindingSource
        '
        Me.AnotacoesBindingSource.DataMember = "Anotacoes"
        Me.AnotacoesBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'FrmAnotacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 845)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.KeyPreview = True
        Me.Name = "FrmAnotacoes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anotações Gerais"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEditor.ResumeLayout(False)
        Me.GroupBoxEditor.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnotacoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents AnotacoesTableAdapter As PrinceDBDataSetTableAdapters.AnotacoesTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents minhasCores As ColorDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBoxEditor As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cbofonte As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cbotamanho As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MudarCorBotao As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnNegrito As ToolStripButton
    Friend WithEvents BtnItalico As ToolStripButton
    Friend WithEvents BtnSublinhado As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BtnColar As ToolStripButton
    Friend WithEvents BtnCopiar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMudaTexto As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonLimpar As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonInicial As Button
    Friend WithEvents ButtonLegalizacao As Button
    Friend WithEvents ButtonFederal As Button
    Friend WithEvents ButtonEstadual As Button
    Friend WithEvents ButtonPrefeitura As Button
    Friend WithEvents ButtonDemais As Button
    Friend WithEvents RichTextBoxAnotacao As RichTextBox
    Friend WithEvents ButtonFechar As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents AnotacoesBindingSource As BindingSource
    Friend WithEvents BtnPesquisar As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents BtnDataHoraAgora As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents BtnDesfazer As ToolStripButton
    Friend WithEvents BtnRefazer As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BtnRealcar As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents BtnEsquerda As ToolStripButton
    Friend WithEvents BtnCentral As ToolStripButton
    Friend WithEvents BtnDireita As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
