<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaNomeSocio
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
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ComBoxNomeResp = New System.Windows.Forms.ComboBox()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RazaoSocialLabel.Location = New System.Drawing.Point(149, 260)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(92, 16)
        RazaoSocialLabel.TabIndex = 2
        RazaoSocialLabel.Text = "Razao Social:"
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
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComBoxNomeResp
        '
        Me.ComBoxNomeResp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComBoxNomeResp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComBoxNomeResp.DataSource = Me.EmpresasBindingSource
        Me.ComBoxNomeResp.DisplayMember = "NomeResponsavel"
        Me.ComBoxNomeResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxNomeResp.FormattingEnabled = True
        Me.ComBoxNomeResp.Location = New System.Drawing.Point(247, 128)
        Me.ComBoxNomeResp.Name = "ComBoxNomeResp"
        Me.ComBoxNomeResp.Size = New System.Drawing.Size(487, 24)
        Me.ComBoxNomeResp.TabIndex = 1
        Me.ComBoxNomeResp.ValueMember = "NomeResponsavel"
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(247, 257)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.ReadOnly = True
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(377, 22)
        Me.RazaoSocialTextBox.TabIndex = 3
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir.Location = New System.Drawing.Point(630, 254)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(104, 25)
        Me.BtnAbrir.TabIndex = 4
        Me.BtnAbrir.Text = "Abrir Empresa"
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome do Responsável da Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(561, 43)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Busca por nome do Responsável da Empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resultado:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(689, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'BuscaNomeSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 337)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAbrir)
        Me.Controls.Add(RazaoSocialLabel)
        Me.Controls.Add(Me.RazaoSocialTextBox)
        Me.Controls.Add(Me.ComBoxNomeResp)
        Me.Name = "BuscaNomeSocio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador por Nome de Sócio em Sistema"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComBoxNomeResp As ComboBox
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
