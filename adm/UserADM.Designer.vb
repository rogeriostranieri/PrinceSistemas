<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class UserADM
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents BtnLimparSenha As System.Windows.Forms.Button

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.BtnLimparSenha = New System.Windows.Forms.Button()
        Me.SenhaNova = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SenhaNovaRepetida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnNomeFinal = New System.Windows.Forms.Button()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.TemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        TemaLabel = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.BackColor = System.Drawing.Color.Transparent
        NomeCompletoLabel.ForeColor = System.Drawing.Color.White
        NomeCompletoLabel.Location = New System.Drawing.Point(540, 17)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(85, 13)
        NomeCompletoLabel.TabIndex = 12
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.BackColor = System.Drawing.Color.Transparent
        TemaLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        TemaLabel.Location = New System.Drawing.Point(540, 60)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 14
        TemaLabel.Text = "Tema:"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = Global.PrinceSistemas.My.Resources.Resources.Area_de_Membros
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(197, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(206, 12)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nome de Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(206, 55)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Senha Atual"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(208, 35)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(208, 78)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 2
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(232, 214)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 5
        Me.OK.Text = "&Alterar Senha"
        '
        'BtnLimparSenha
        '
        Me.BtnLimparSenha.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLimparSenha.Location = New System.Drawing.Point(335, 214)
        Me.BtnLimparSenha.Name = "BtnLimparSenha"
        Me.BtnLimparSenha.Size = New System.Drawing.Size(94, 23)
        Me.BtnLimparSenha.TabIndex = 6
        Me.BtnLimparSenha.Text = "&Limpar"
        '
        'SenhaNova
        '
        Me.SenhaNova.Location = New System.Drawing.Point(208, 131)
        Me.SenhaNova.Name = "SenhaNova"
        Me.SenhaNova.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNova.Size = New System.Drawing.Size(220, 20)
        Me.SenhaNova.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Nova Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SenhaNovaRepetida
        '
        Me.SenhaNovaRepetida.Location = New System.Drawing.Point(209, 173)
        Me.SenhaNovaRepetida.Name = "SenhaNovaRepetida"
        Me.SenhaNovaRepetida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNovaRepetida.Size = New System.Drawing.Size(220, 20)
        Me.SenhaNovaRepetida.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(207, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&Repita Nova Senha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(646, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Cancelar"
        '
        'BtnNomeFinal
        '
        Me.BtnNomeFinal.Location = New System.Drawing.Point(543, 125)
        Me.BtnNomeFinal.Name = "BtnNomeFinal"
        Me.BtnNomeFinal.Size = New System.Drawing.Size(94, 23)
        Me.BtnNomeFinal.TabIndex = 16
        Me.BtnNomeFinal.Text = "Alterar &Dados"
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(543, 32)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(283, 20)
        Me.NomeCompletoTextBox.TabIndex = 18
        '
        'TemaComboBox
        '
        Me.TemaComboBox.FormattingEnabled = True
        Me.TemaComboBox.Items.AddRange(New Object() {"Noite"})
        Me.TemaComboBox.Location = New System.Drawing.Point(543, 76)
        Me.TemaComboBox.Name = "TemaComboBox"
        Me.TemaComboBox.Size = New System.Drawing.Size(169, 21)
        Me.TemaComboBox.TabIndex = 19
        '
        'Panel1
        '
        ' Me.Panel1.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LogoPictureBox)
        Me.Panel1.Controls.Add(Me.TemaComboBox)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.NomeCompletoTextBox)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(Me.BtnNomeFinal)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(TemaLabel)
        Me.Panel1.Controls.Add(Me.OK)
        Me.Panel1.Controls.Add(NomeCompletoLabel)
        Me.Panel1.Controls.Add(Me.BtnLimparSenha)
        Me.Panel1.Controls.Add(Me.SenhaNovaRepetida)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SenhaNova)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 254)
        Me.Panel1.TabIndex = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(721, 191)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'UserADM
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnLimparSenha
        Me.ClientSize = New System.Drawing.Size(858, 254)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserADM"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Senha"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SenhaNova As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SenhaNovaRepetida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnNomeFinal As Button
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents TemaComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
