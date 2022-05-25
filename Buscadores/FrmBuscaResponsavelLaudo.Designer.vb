<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaResponsavelLaudo
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
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.BackColor = System.Drawing.Color.Transparent
        RazaoSocialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RazaoSocialLabel.Location = New System.Drawing.Point(138, 266)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(91, 16)
        RazaoSocialLabel.TabIndex = 18
        RazaoSocialLabel.Text = "Razao Social:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(678, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Resultado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(538, 43)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Busca por nome do Responsável do Alvará"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nome do Responsável da Empresa"
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir.Location = New System.Drawing.Point(619, 262)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(104, 25)
        Me.BtnAbrir.TabIndex = 20
        Me.BtnAbrir.Text = "Abrir Alvará"
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Me.LaudosTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(235, 265)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.ReadOnly = True
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(378, 20)
        Me.RazaoSocialTextBox.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.LaudosBindingSource
        Me.ComboBox1.DisplayMember = "Requerente"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(488, 21)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.ValueMember = "Requerente"
        '
        'FrmBuscaResponsavelLaudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 337)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RazaoSocialTextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAbrir)
        Me.Controls.Add(RazaoSocialLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscaResponsavelLaudo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador por Nome do Responsável em Sistema"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
