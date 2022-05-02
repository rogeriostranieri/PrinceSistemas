<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAltSenha
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
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.BtnLimparSenha = New System.Windows.Forms.Button()
        Me.SenhaNovaRepetida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SenhaNova = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(39, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 10
        Me.UsernameLabel.Text = "&Nome de Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(39, 61)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 12
        Me.PasswordLabel.Text = "&Senha Atual"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(39, 35)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 23)
        Me.UsernameTextBox.TabIndex = 11
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(39, 87)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 23)
        Me.PasswordTextBox.TabIndex = 13
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OK.Location = New System.Drawing.Point(39, 243)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(119, 27)
        Me.OK.TabIndex = 16
        Me.OK.Text = "&Alterar Senha"
        Me.OK.UseVisualStyleBackColor = False
        '
        'BtnLimparSenha
        '
        Me.BtnLimparSenha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLimparSenha.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLimparSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnLimparSenha.Location = New System.Drawing.Point(165, 243)
        Me.BtnLimparSenha.Name = "BtnLimparSenha"
        Me.BtnLimparSenha.Size = New System.Drawing.Size(94, 27)
        Me.BtnLimparSenha.TabIndex = 17
        Me.BtnLimparSenha.Text = "&Limpar"
        Me.BtnLimparSenha.UseVisualStyleBackColor = False
        '
        'SenhaNovaRepetida
        '
        Me.SenhaNovaRepetida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SenhaNovaRepetida.ForeColor = System.Drawing.Color.Black
        Me.SenhaNovaRepetida.Location = New System.Drawing.Point(39, 191)
        Me.SenhaNovaRepetida.Name = "SenhaNovaRepetida"
        Me.SenhaNovaRepetida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNovaRepetida.Size = New System.Drawing.Size(220, 23)
        Me.SenhaNovaRepetida.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "&Nova Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "&Repita Nova Senha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SenhaNova
        '
        Me.SenhaNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SenhaNova.ForeColor = System.Drawing.Color.Black
        Me.SenhaNova.Location = New System.Drawing.Point(39, 139)
        Me.SenhaNova.Name = "SenhaNova"
        Me.SenhaNova.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNova.Size = New System.Drawing.Size(220, 23)
        Me.SenhaNova.TabIndex = 14
        '
        'UserAltSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.BtnLimparSenha)
        Me.Controls.Add(Me.SenhaNovaRepetida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SenhaNova)
        Me.Name = "UserAltSenha"
        Me.Size = New System.Drawing.Size(283, 305)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents BtnLimparSenha As Button
    Friend WithEvents SenhaNovaRepetida As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SenhaNova As TextBox
End Class
