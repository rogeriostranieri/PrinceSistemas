<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportarContratoWordDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportarContratoWordDialog))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDados = New System.Windows.Forms.Button()
        Me.BtnContrato = New System.Windows.Forms.Button()
        Me.BtnSocios = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCaminho = New System.Windows.Forms.TextBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PictureBoxAguarde = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBoxAguarde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnDados)
        Me.GroupBox1.Controls.Add(Me.BtnContrato)
        Me.GroupBox1.Controls.Add(Me.BtnSocios)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 87)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exportação"
        '
        'BtnDados
        '
        Me.BtnDados.BackgroundImage = CType(resources.GetObject("BtnDados.BackgroundImage"), System.Drawing.Image)
        Me.BtnDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDados.Location = New System.Drawing.Point(207, 25)
        Me.BtnDados.Name = "BtnDados"
        Me.BtnDados.Size = New System.Drawing.Size(121, 50)
        Me.BtnDados.TabIndex = 3
        Me.BtnDados.Text = "Informações"
        Me.BtnDados.UseVisualStyleBackColor = True
        '
        'BtnContrato
        '
        Me.BtnContrato.BackgroundImage = CType(resources.GetObject("BtnContrato.BackgroundImage"), System.Drawing.Image)
        Me.BtnContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContrato.Location = New System.Drawing.Point(103, 25)
        Me.BtnContrato.Name = "BtnContrato"
        Me.BtnContrato.Size = New System.Drawing.Size(98, 50)
        Me.BtnContrato.TabIndex = 2
        Me.BtnContrato.Text = "Contrato"
        Me.BtnContrato.UseVisualStyleBackColor = True
        '
        'BtnSocios
        '
        Me.BtnSocios.BackgroundImage = CType(resources.GetObject("BtnSocios.BackgroundImage"), System.Drawing.Image)
        Me.BtnSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSocios.Location = New System.Drawing.Point(14, 25)
        Me.BtnSocios.Name = "BtnSocios"
        Me.BtnSocios.Size = New System.Drawing.Size(87, 50)
        Me.BtnSocios.TabIndex = 1
        Me.BtnSocios.Text = "Sócios"
        Me.BtnSocios.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Exportação de Contrato Social"
        '
        'TextBoxCaminho
        '
        Me.TextBoxCaminho.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCaminho.Location = New System.Drawing.Point(85, 80)
        Me.TextBoxCaminho.Name = "TextBoxCaminho"
        Me.TextBoxCaminho.Size = New System.Drawing.Size(393, 24)
        Me.TextBoxCaminho.TabIndex = 12
        Me.TextBoxCaminho.Text = "Clique em ""PROCURAR"" para escolher o contrato social"
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.Location = New System.Drawing.Point(483, 77)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(87, 30)
        Me.BtnAdicionar.TabIndex = 11
        Me.BtnAdicionar.Text = "Procurar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Arquivo:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.93458!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.06542!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAbrir, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(239, 227)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(331, 45)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'BtnAbrir
        '
        Me.BtnAbrir.BackColor = System.Drawing.Color.Transparent
        Me.BtnAbrir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAbrir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAbrir.Location = New System.Drawing.Point(3, 3)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(101, 39)
        Me.BtnAbrir.TabIndex = 2
        Me.BtnAbrir.Text = "Abrir"
        Me.BtnAbrir.UseVisualStyleBackColor = False
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(110, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(98, 39)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(214, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(114, 39)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'PictureBoxAguarde
        '
        Me.PictureBoxAguarde.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAguarde.Location = New System.Drawing.Point(8, 216)
        Me.PictureBoxAguarde.Name = "PictureBoxAguarde"
        Me.PictureBoxAguarde.Size = New System.Drawing.Size(224, 58)
        Me.PictureBoxAguarde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAguarde.TabIndex = 22
        Me.PictureBoxAguarde.TabStop = False
        '
        'ExportarContratoWordDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(578, 279)
        Me.Controls.Add(Me.PictureBoxAguarde)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCaminho)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExportarContratoWordDialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBoxAguarde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDados As Button
    Friend WithEvents BtnContrato As Button
    Friend WithEvents BtnSocios As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCaminho As TextBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents PictureBoxAguarde As PictureBox
End Class
