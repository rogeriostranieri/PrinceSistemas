<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDel
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BtnNoMostrar = New System.Windows.Forms.Button()
        Me.ComboBoxUser = New System.Windows.Forms.ComboBox()
        Me.BtnApagar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblNomeCompleto = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(39, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 30
        Me.UsernameLabel.Text = "&Nome de Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(40, 68)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 32
        Me.PasswordLabel.Text = "&Senha Atual"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UsernameTextBox.Location = New System.Drawing.Point(42, 35)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 23)
        Me.UsernameTextBox.TabIndex = 31
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(42, 91)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 23)
        Me.PasswordTextBox.TabIndex = 33
        '
        'BtnNoMostrar
        '
        Me.BtnNoMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnNoMostrar.Location = New System.Drawing.Point(43, 126)
        Me.BtnNoMostrar.Name = "BtnNoMostrar"
        Me.BtnNoMostrar.Size = New System.Drawing.Size(138, 28)
        Me.BtnNoMostrar.TabIndex = 34
        Me.BtnNoMostrar.Text = "Mostrar Usuários"
        '
        'ComboBoxUser
        '
        Me.ComboBoxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxUser.FormattingEnabled = True
        Me.ComboBoxUser.Location = New System.Drawing.Point(42, 224)
        Me.ComboBoxUser.Name = "ComboBoxUser"
        Me.ComboBoxUser.Size = New System.Drawing.Size(138, 24)
        Me.ComboBoxUser.TabIndex = 35
        '
        'BtnApagar
        '
        Me.BtnApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnApagar.Location = New System.Drawing.Point(42, 266)
        Me.BtnApagar.Name = "BtnApagar"
        Me.BtnApagar.Size = New System.Drawing.Size(139, 28)
        Me.BtnApagar.TabIndex = 36
        Me.BtnApagar.Text = "Apagar Usuário"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnCancelar.Location = New System.Drawing.Point(189, 266)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(126, 28)
        Me.BtnCancelar.TabIndex = 37
        Me.BtnCancelar.Text = "Cancelar"
        '
        'LblUser
        '
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.Black
        Me.LblUser.Location = New System.Drawing.Point(41, 198)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(139, 23)
        Me.LblUser.TabIndex = 38
        Me.LblUser.Text = "Usuários"
        Me.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNomeCompleto
        '
        Me.LblNomeCompleto.BackColor = System.Drawing.Color.Transparent
        Me.LblNomeCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomeCompleto.ForeColor = System.Drawing.Color.Black
        Me.LblNomeCompleto.Location = New System.Drawing.Point(186, 198)
        Me.LblNomeCompleto.Name = "LblNomeCompleto"
        Me.LblNomeCompleto.Size = New System.Drawing.Size(220, 23)
        Me.LblNomeCompleto.TabIndex = 39
        Me.LblNomeCompleto.Text = "Nome Completo"
        Me.LblNomeCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxNome.Location = New System.Drawing.Point(186, 224)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(220, 23)
        Me.TextBoxNome.TabIndex = 41
        '
        'UserDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.LblNomeCompleto)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnApagar)
        Me.Controls.Add(Me.ComboBoxUser)
        Me.Controls.Add(Me.BtnNoMostrar)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Name = "UserDel"
        Me.Size = New System.Drawing.Size(418, 316)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents BtnNoMostrar As Button
    Friend WithEvents ComboBoxUser As ComboBox
    Friend WithEvents BtnApagar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblUser As Label
    Friend WithEvents LblNomeCompleto As Label
    Friend WithEvents TextBoxNome As TextBox
End Class
