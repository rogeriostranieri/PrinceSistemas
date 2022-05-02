<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmailCaixaDeSaida
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
        Dim EMailPrincipalLabel As System.Windows.Forms.Label
        Dim EMailDestinoLabel As System.Windows.Forms.Label
        Dim AssuntoLabel As System.Windows.Forms.Label
        Dim CaixaDeSaidaTextoLabel As System.Windows.Forms.Label
        Dim DataEnviadoLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmailCaixaDeSaida))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EMailCaixaDeSaidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMailCaixaDeSaidaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.eMailCaixaDeSaidaTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EMailPrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.EMailDestinoTextBox = New System.Windows.Forms.TextBox()
        Me.AssuntoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBoxBusca = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataEnviadoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CaixaDeSaidaTextoRichTextBox = New System.Windows.Forms.RichTextBox()
        EMailPrincipalLabel = New System.Windows.Forms.Label()
        EMailDestinoLabel = New System.Windows.Forms.Label()
        AssuntoLabel = New System.Windows.Forms.Label()
        CaixaDeSaidaTextoLabel = New System.Windows.Forms.Label()
        DataEnviadoLabel1 = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMailPrincipalLabel
        '
        EMailPrincipalLabel.AutoSize = True
        EMailPrincipalLabel.Location = New System.Drawing.Point(38, 73)
        EMailPrincipalLabel.Name = "EMailPrincipalLabel"
        EMailPrincipalLabel.Size = New System.Drawing.Size(81, 13)
        EMailPrincipalLabel.TabIndex = 1
        EMailPrincipalLabel.Text = "e Mail Principal:"
        '
        'EMailDestinoLabel
        '
        EMailDestinoLabel.AutoSize = True
        EMailDestinoLabel.Location = New System.Drawing.Point(42, 99)
        EMailDestinoLabel.Name = "EMailDestinoLabel"
        EMailDestinoLabel.Size = New System.Drawing.Size(77, 13)
        EMailDestinoLabel.TabIndex = 3
        EMailDestinoLabel.Text = "e Mail Destino:"
        '
        'AssuntoLabel
        '
        AssuntoLabel.AutoSize = True
        AssuntoLabel.Location = New System.Drawing.Point(71, 141)
        AssuntoLabel.Name = "AssuntoLabel"
        AssuntoLabel.Size = New System.Drawing.Size(48, 13)
        AssuntoLabel.TabIndex = 5
        AssuntoLabel.Text = "Assunto:"
        '
        'CaixaDeSaidaTextoLabel
        '
        CaixaDeSaidaTextoLabel.AutoSize = True
        CaixaDeSaidaTextoLabel.Location = New System.Drawing.Point(6, 193)
        CaixaDeSaidaTextoLabel.Name = "CaixaDeSaidaTextoLabel"
        CaixaDeSaidaTextoLabel.Size = New System.Drawing.Size(113, 13)
        CaixaDeSaidaTextoLabel.TabIndex = 7
        CaixaDeSaidaTextoLabel.Text = "Caixa De Saida Texto:"
        '
        'DataEnviadoLabel1
        '
        DataEnviadoLabel1.AutoSize = True
        DataEnviadoLabel1.Location = New System.Drawing.Point(130, 47)
        DataEnviadoLabel1.Name = "DataEnviadoLabel1"
        DataEnviadoLabel1.Size = New System.Drawing.Size(81, 13)
        DataEnviadoLabel1.TabIndex = 52
        DataEnviadoLabel1.Text = "Enviado no dia:"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMailCaixaDeSaidaBindingSource
        '
        Me.EMailCaixaDeSaidaBindingSource.DataMember = "eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EMailCaixaDeSaidaTableAdapter
        '
        Me.EMailCaixaDeSaidaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Me.EMailCaixaDeSaidaTableAdapter
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMailPrincipalTextBox
        '
        Me.EMailPrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailCaixaDeSaidaBindingSource, "eMailPrincipal", True))
        Me.EMailPrincipalTextBox.Location = New System.Drawing.Point(125, 70)
        Me.EMailPrincipalTextBox.Name = "EMailPrincipalTextBox"
        Me.EMailPrincipalTextBox.ReadOnly = True
        Me.EMailPrincipalTextBox.Size = New System.Drawing.Size(216, 20)
        Me.EMailPrincipalTextBox.TabIndex = 2
        '
        'EMailDestinoTextBox
        '
        Me.EMailDestinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailCaixaDeSaidaBindingSource, "eMailDestino", True))
        Me.EMailDestinoTextBox.Location = New System.Drawing.Point(125, 96)
        Me.EMailDestinoTextBox.Name = "EMailDestinoTextBox"
        Me.EMailDestinoTextBox.ReadOnly = True
        Me.EMailDestinoTextBox.Size = New System.Drawing.Size(216, 20)
        Me.EMailDestinoTextBox.TabIndex = 4
        '
        'AssuntoTextBox
        '
        Me.AssuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailCaixaDeSaidaBindingSource, "Assunto", True))
        Me.AssuntoTextBox.Location = New System.Drawing.Point(125, 138)
        Me.AssuntoTextBox.Name = "AssuntoTextBox"
        Me.AssuntoTextBox.ReadOnly = True
        Me.AssuntoTextBox.Size = New System.Drawing.Size(216, 20)
        Me.AssuntoTextBox.TabIndex = 6
        '
        'ComboBoxBusca
        '
        Me.ComboBoxBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBusca.DataSource = Me.EMailCaixaDeSaidaBindingSource
        Me.ComboBoxBusca.DisplayMember = "ID_eMailCaixaDeSaida"
        Me.ComboBoxBusca.Enabled = False
        Me.ComboBoxBusca.FormattingEnabled = True
        Me.ComboBoxBusca.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxBusca.Name = "ComboBoxBusca"
        Me.ComboBoxBusca.Size = New System.Drawing.Size(64, 21)
        Me.ComboBoxBusca.TabIndex = 10
        Me.ComboBoxBusca.ValueMember = "eMailPrincipal"
        Me.ComboBoxBusca.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(422, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.email
        Me.PictureBox1.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "e-Mail enviados"
        '
        'DataEnviadoMaskedTextBox
        '
        Me.DataEnviadoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailCaixaDeSaidaBindingSource, "DataEnviado", True))
        Me.DataEnviadoMaskedTextBox.Location = New System.Drawing.Point(217, 44)
        Me.DataEnviadoMaskedTextBox.Name = "DataEnviadoMaskedTextBox"
        Me.DataEnviadoMaskedTextBox.ReadOnly = True
        Me.DataEnviadoMaskedTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DataEnviadoMaskedTextBox.TabIndex = 53
        Me.DataEnviadoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'CaixaDeSaidaTextoRichTextBox
        '
        Me.CaixaDeSaidaTextoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailCaixaDeSaidaBindingSource, "CaixaDeSaidaTexto", True))
        Me.CaixaDeSaidaTextoRichTextBox.Location = New System.Drawing.Point(125, 193)
        Me.CaixaDeSaidaTextoRichTextBox.Name = "CaixaDeSaidaTextoRichTextBox"
        Me.CaixaDeSaidaTextoRichTextBox.ReadOnly = True
        Me.CaixaDeSaidaTextoRichTextBox.Size = New System.Drawing.Size(366, 126)
        Me.CaixaDeSaidaTextoRichTextBox.TabIndex = 54
        Me.CaixaDeSaidaTextoRichTextBox.Text = ""
        '
        'FrmEmailCaixaDeSaida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 331)
        Me.Controls.Add(Me.CaixaDeSaidaTextoRichTextBox)
        Me.Controls.Add(DataEnviadoLabel1)
        Me.Controls.Add(Me.DataEnviadoMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxBusca)
        Me.Controls.Add(CaixaDeSaidaTextoLabel)
        Me.Controls.Add(AssuntoLabel)
        Me.Controls.Add(Me.AssuntoTextBox)
        Me.Controls.Add(EMailDestinoLabel)
        Me.Controls.Add(Me.EMailDestinoTextBox)
        Me.Controls.Add(EMailPrincipalLabel)
        Me.Controls.Add(Me.EMailPrincipalTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmailCaixaDeSaida"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EMailCaixaDeSaidaBindingSource As BindingSource
    Friend WithEvents EMailCaixaDeSaidaTableAdapter As PrinceDBDataSetTableAdapters.eMailCaixaDeSaidaTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMailPrincipalTextBox As TextBox
    Friend WithEvents EMailDestinoTextBox As TextBox
    Friend WithEvents AssuntoTextBox As TextBox
    Friend WithEvents ComboBoxBusca As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataEnviadoMaskedTextBox As MaskedTextBox
    Friend WithEvents CaixaDeSaidaTextoRichTextBox As RichTextBox
End Class
