<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Telefones
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
        Dim Telefone1Label As System.Windows.Forms.Label
        Dim TelefoneOutrosLabel As System.Windows.Forms.Label
        Dim ObsLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SiteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Telefones))
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.Telefone1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelefoneOutrosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SiteTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxBusca = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CboCidadeOrgao = New System.Windows.Forms.ToolStripTextBox()
        Me.TelefonesTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.TelefonesTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        NomeLabel = New System.Windows.Forms.Label()
        Telefone1Label = New System.Windows.Forms.Label()
        TelefoneOutrosLabel = New System.Windows.Forms.Label()
        ObsLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SiteLabel = New System.Windows.Forms.Label()
        CType(Me.TelefonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Location = New System.Drawing.Point(45, 62)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(47, 16)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'Telefone1Label
        '
        Telefone1Label.AutoSize = True
        Telefone1Label.BackColor = System.Drawing.Color.Transparent
        Telefone1Label.Location = New System.Drawing.Point(27, 90)
        Telefone1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefone1Label.Name = "Telefone1Label"
        Telefone1Label.Size = New System.Drawing.Size(64, 16)
        Telefone1Label.TabIndex = 3
        Telefone1Label.Text = "Telefone:"
        '
        'TelefoneOutrosLabel
        '
        TelefoneOutrosLabel.AutoSize = True
        TelefoneOutrosLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneOutrosLabel.Location = New System.Drawing.Point(17, 126)
        TelefoneOutrosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefoneOutrosLabel.Name = "TelefoneOutrosLabel"
        TelefoneOutrosLabel.Size = New System.Drawing.Size(71, 16)
        TelefoneOutrosLabel.TabIndex = 5
        TelefoneOutrosLabel.Text = "Telefones:"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.BackColor = System.Drawing.Color.Transparent
        ObsLabel.Location = New System.Drawing.Point(223, 94)
        ObsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(35, 16)
        ObsLabel.TabIndex = 7
        ObsLabel.Text = "Obs:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(61, 31)
        CEPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(37, 16)
        CEPLabel.TabIndex = 9
        CEPLabel.Text = "CEP:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(17, 63)
        EndereçoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(80, 16)
        EndereçoLabel.TabIndex = 11
        EndereçoLabel.Text = "Logradouro:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroLabel.Location = New System.Drawing.Point(459, 63)
        NumeroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(58, 16)
        NumeroLabel.TabIndex = 13
        NumeroLabel.Text = "Numero:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComplementoLabel.Location = New System.Drawing.Point(4, 95)
        ComplementoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(94, 16)
        ComplementoLabel.TabIndex = 15
        ComplementoLabel.Text = "Complemento:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(347, 95)
        BairroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(46, 16)
        BairroLabel.TabIndex = 17
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(45, 127)
        CidadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(54, 16)
        CidadeLabel.TabIndex = 19
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(256, 127)
        EstadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(53, 16)
        EstadoLabel.TabIndex = 21
        EstadoLabel.Text = "Estado:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(45, 251)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(47, 16)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "e-Mail:"
        '
        'SiteLabel
        '
        SiteLabel.AutoSize = True
        SiteLabel.BackColor = System.Drawing.Color.Transparent
        SiteLabel.Location = New System.Drawing.Point(28, 283)
        SiteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SiteLabel.Name = "SiteLabel"
        SiteLabel.Size = New System.Drawing.Size(62, 16)
        SiteLabel.TabIndex = 25
        SiteLabel.Text = "WebSite:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(104, 58)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(539, 22)
        Me.NomeTextBox.TabIndex = 2
        '
        'TelefonesBindingSource
        '
        Me.TelefonesBindingSource.DataMember = "Telefones"
        Me.TelefonesBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Telefone1", True))
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(104, 90)
        Me.Telefone1MaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Telefone1MaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(109, 22)
        Me.Telefone1MaskedTextBox.TabIndex = 4
        '
        'TelefoneOutrosRichTextBox
        '
        Me.TelefoneOutrosRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "TelefoneOutros", True))
        Me.TelefoneOutrosRichTextBox.Location = New System.Drawing.Point(104, 122)
        Me.TelefoneOutrosRichTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TelefoneOutrosRichTextBox.Name = "TelefoneOutrosRichTextBox"
        Me.TelefoneOutrosRichTextBox.Size = New System.Drawing.Size(109, 117)
        Me.TelefoneOutrosRichTextBox.TabIndex = 6
        Me.TelefoneOutrosRichTextBox.Text = ""
        '
        'ObsRichTextBox
        '
        Me.ObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Obs", True))
        Me.ObsRichTextBox.Location = New System.Drawing.Point(269, 94)
        Me.ObsRichTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ObsRichTextBox.Name = "ObsRichTextBox"
        Me.ObsRichTextBox.Size = New System.Drawing.Size(374, 146)
        Me.ObsRichTextBox.TabIndex = 8
        Me.ObsRichTextBox.Text = ""
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(111, 27)
        Me.CEPMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(97, 22)
        Me.CEPMaskedTextBox.TabIndex = 10
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(111, 59)
        Me.EndereçoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(345, 22)
        Me.EndereçoTextBox.TabIndex = 12
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.Location = New System.Drawing.Point(521, 59)
        Me.NumeroTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(73, 22)
        Me.NumeroTextBox.TabIndex = 14
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(111, 91)
        Me.ComplementoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(227, 22)
        Me.ComplementoTextBox.TabIndex = 16
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.Location = New System.Drawing.Point(397, 91)
        Me.BairroTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(197, 22)
        Me.BairroTextBox.TabIndex = 18
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.Location = New System.Drawing.Point(111, 123)
        Me.CidadeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CidadeTextBox.TabIndex = 20
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.Location = New System.Drawing.Point(321, 123)
        Me.EstadoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.EstadoTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(104, 247)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(539, 22)
        Me.EmailTextBox.TabIndex = 24
        '
        'SiteTextBox
        '
        Me.SiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonesBindingSource, "site", True))
        Me.SiteTextBox.Location = New System.Drawing.Point(104, 279)
        Me.SiteTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SiteTextBox.Name = "SiteTextBox"
        Me.SiteTextBox.Size = New System.Drawing.Size(539, 22)
        Me.SiteTextBox.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(217, 27)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Buscar CEP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(CidadeLabel)
        Me.GroupBox1.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox1.Controls.Add(ComplementoLabel)
        Me.GroupBox1.Controls.Add(BairroLabel)
        Me.GroupBox1.Controls.Add(Me.BairroTextBox)
        Me.GroupBox1.Controls.Add(Me.ComplementoTextBox)
        Me.GroupBox1.Controls.Add(NumeroLabel)
        Me.GroupBox1.Controls.Add(Me.NumeroTextBox)
        Me.GroupBox1.Controls.Add(EndereçoLabel)
        Me.GroupBox1.Controls.Add(Me.EndereçoTextBox)
        Me.GroupBox1.Controls.Add(CEPLabel)
        Me.GroupBox1.Controls.Add(Me.CEPMaskedTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 334)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(603, 176)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endereço"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button16)
        Me.GroupBox5.Controls.Add(Me.Button18)
        Me.GroupBox5.Controls.Add(Me.Button17)
        Me.GroupBox5.Controls.Add(Me.Button19)
        Me.GroupBox5.Location = New System.Drawing.Point(672, 34)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(125, 197)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MENU"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(17, 23)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(92, 27)
        Me.Button16.TabIndex = 46
        Me.Button16.Text = "Novo"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(17, 58)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(92, 28)
        Me.Button18.TabIndex = 48
        Me.Button18.Text = "Salvar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(17, 113)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(92, 28)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "Excluir"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(17, 149)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(92, 28)
        Me.Button19.TabIndex = 49
        Me.Button19.Text = "Fechar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ComboBoxBusca, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CboCidadeOrgao})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 25)
        Me.ToolStrip1.TabIndex = 59
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "Localizar:"
        '
        'ComboBoxBusca
        '
        Me.ComboBoxBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBusca.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ComboBoxBusca.Name = "ComboBoxBusca"
        Me.ComboBoxBusca.Size = New System.Drawing.Size(345, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel2.Text = "Filtro:"
        '
        'CboCidadeOrgao
        '
        Me.CboCidadeOrgao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CboCidadeOrgao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CboCidadeOrgao.Name = "CboCidadeOrgao"
        Me.CboCidadeOrgao.Size = New System.Drawing.Size(133, 25)
        '
        'TelefonesTableAdapter
        '
        Me.TelefonesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Me.TelefonesTableAdapter
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Telefones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 526)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(SiteLabel)
        Me.Controls.Add(Me.SiteTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(ObsLabel)
        Me.Controls.Add(Me.ObsRichTextBox)
        Me.Controls.Add(TelefoneOutrosLabel)
        Me.Controls.Add(Me.TelefoneOutrosRichTextBox)
        Me.Controls.Add(Telefone1Label)
        Me.Controls.Add(Me.Telefone1MaskedTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Telefones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telefones dos Órgãos Governamentais"
        CType(Me.TelefonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents TelefonesBindingSource As BindingSource
    Friend WithEvents TelefonesTableAdapter As PrinceDBDataSetTableAdapters.TelefonesTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Telefone1MaskedTextBox As MaskedTextBox
    Friend WithEvents TelefoneOutrosRichTextBox As RichTextBox
    Friend WithEvents ObsRichTextBox As RichTextBox
    Friend WithEvents CEPMaskedTextBox As MaskedTextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents SiteTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBoxBusca As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents CboCidadeOrgao As ToolStripTextBox
End Class
