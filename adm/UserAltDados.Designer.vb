<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAltDados
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim TemaLabel As System.Windows.Forms.Label
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Me.TemaComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnNomeFinal = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BtnMostrarDados = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnAjudaImage = New System.Windows.Forms.Button()
        Me.TemaPictureBox = New System.Windows.Forms.PictureBox()
        Me.BtnProcurarPasta = New System.Windows.Forms.Button()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LoginTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.DataNascimentoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        TemaLabel = New System.Windows.Forms.Label()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        CType(Me.TemaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.BackColor = System.Drawing.Color.Transparent
        TemaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TemaLabel.ForeColor = System.Drawing.Color.Black
        TemaLabel.Location = New System.Drawing.Point(37, 241)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(50, 18)
        TemaLabel.TabIndex = 21
        TemaLabel.Text = "Tema:"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.BackColor = System.Drawing.Color.Transparent
        NomeCompletoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeCompletoLabel.ForeColor = System.Drawing.Color.Black
        NomeCompletoLabel.Location = New System.Drawing.Point(37, 165)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(122, 18)
        NomeCompletoLabel.TabIndex = 20
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'TemaComboBox
        '
        Me.TemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TemaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TemaComboBox.ForeColor = System.Drawing.Color.Black
        Me.TemaComboBox.FormattingEnabled = True
        Me.TemaComboBox.Location = New System.Drawing.Point(40, 262)
        Me.TemaComboBox.Name = "TemaComboBox"
        Me.TemaComboBox.Size = New System.Drawing.Size(169, 24)
        Me.TemaComboBox.TabIndex = 25
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NomeCompletoTextBox.ForeColor = System.Drawing.Color.Black
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(40, 186)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(283, 23)
        Me.NomeCompletoTextBox.TabIndex = 24
        '
        'BtnLimpar
        '
        Me.BtnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnLimpar.Location = New System.Drawing.Point(229, 403)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(94, 28)
        Me.BtnLimpar.TabIndex = 23
        Me.BtnLimpar.Text = "&Limpar"
        '
        'BtnNomeFinal
        '
        Me.BtnNomeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnNomeFinal.Location = New System.Drawing.Point(117, 403)
        Me.BtnNomeFinal.Name = "BtnNomeFinal"
        Me.BtnNomeFinal.Size = New System.Drawing.Size(106, 28)
        Me.BtnNomeFinal.TabIndex = 22
        Me.BtnNomeFinal.Text = "Alterar &Dados"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(37, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 26
        Me.UsernameLabel.Text = "&Nome de Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(36, 49)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 28
        Me.PasswordLabel.Text = "&Senha Atual"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(39, 23)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 23)
        Me.UsernameTextBox.TabIndex = 27
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(40, 75)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 23)
        Me.PasswordTextBox.TabIndex = 29
        '
        'BtnMostrarDados
        '
        Me.BtnMostrarDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnMostrarDados.Location = New System.Drawing.Point(40, 105)
        Me.BtnMostrarDados.Name = "BtnMostrarDados"
        Me.BtnMostrarDados.Size = New System.Drawing.Size(106, 28)
        Me.BtnMostrarDados.TabIndex = 30
        Me.BtnMostrarDados.Text = "Mostrar &Dados"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnAjudaImage
        '
        Me.BtnAjudaImage.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.interrogacao
        Me.BtnAjudaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAjudaImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAjudaImage.FlatAppearance.BorderSize = 0
        Me.BtnAjudaImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjudaImage.Location = New System.Drawing.Point(215, 262)
        Me.BtnAjudaImage.Name = "BtnAjudaImage"
        Me.BtnAjudaImage.Size = New System.Drawing.Size(27, 23)
        Me.BtnAjudaImage.TabIndex = 70
        Me.BtnAjudaImage.UseVisualStyleBackColor = True
        '
        'TemaPictureBox
        '
        Me.TemaPictureBox.Location = New System.Drawing.Point(39, 292)
        Me.TemaPictureBox.Name = "TemaPictureBox"
        Me.TemaPictureBox.Size = New System.Drawing.Size(284, 105)
        Me.TemaPictureBox.TabIndex = 31
        Me.TemaPictureBox.TabStop = False
        '
        'BtnProcurarPasta
        '
        Me.BtnProcurarPasta.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.pasta1
        Me.BtnProcurarPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProcurarPasta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcurarPasta.FlatAppearance.BorderSize = 0
        Me.BtnProcurarPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcurarPasta.Location = New System.Drawing.Point(248, 262)
        Me.BtnProcurarPasta.Name = "BtnProcurarPasta"
        Me.BtnProcurarPasta.Size = New System.Drawing.Size(27, 23)
        Me.BtnProcurarPasta.TabIndex = 71
        Me.BtnProcurarPasta.UseVisualStyleBackColor = True
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        DataNascimentoLabel.Location = New System.Drawing.Point(37, 218)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(133, 16)
        DataNascimentoLabel.TabIndex = 72
        DataNascimentoLabel.Text = "Data de Nascimento:"
        '
        'DataNascimentoMaskedTextBox
        '
        Me.DataNascimentoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "DataNascimento", True))
        Me.DataNascimentoMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.DataNascimentoMaskedTextBox.Location = New System.Drawing.Point(176, 215)
        Me.DataNascimentoMaskedTextBox.Mask = "00/00/0000"
        Me.DataNascimentoMaskedTextBox.Name = "DataNascimentoMaskedTextBox"
        Me.DataNascimentoMaskedTextBox.Size = New System.Drawing.Size(80, 21)
        Me.DataNascimentoMaskedTextBox.TabIndex = 73
        Me.DataNascimentoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'UserAltDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(DataNascimentoLabel)
        Me.Controls.Add(Me.DataNascimentoMaskedTextBox)
        Me.Controls.Add(Me.BtnProcurarPasta)
        Me.Controls.Add(Me.BtnAjudaImage)
        Me.Controls.Add(Me.TemaPictureBox)
        Me.Controls.Add(Me.BtnMostrarDados)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.TemaComboBox)
        Me.Controls.Add(Me.NomeCompletoTextBox)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnNomeFinal)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(NomeCompletoLabel)
        Me.Name = "UserAltDados"
        Me.Size = New System.Drawing.Size(333, 440)
        CType(Me.TemaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TemaComboBox As ComboBox
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnNomeFinal As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents BtnMostrarDados As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TemaPictureBox As PictureBox
    Friend WithEvents BtnAjudaImage As Button
    Friend WithEvents BtnProcurarPasta As Button
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As PrinceDBDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataNascimentoMaskedTextBox As MaskedTextBox
End Class
