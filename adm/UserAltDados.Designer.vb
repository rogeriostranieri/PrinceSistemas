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
        Me.TemaPictureBox = New System.Windows.Forms.PictureBox()
        TemaLabel = New System.Windows.Forms.Label()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        CType(Me.TemaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.BackColor = System.Drawing.Color.Transparent
        TemaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TemaLabel.ForeColor = System.Drawing.Color.Black
        TemaLabel.Location = New System.Drawing.Point(37, 212)
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
        Me.TemaComboBox.Location = New System.Drawing.Point(40, 233)
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
        Me.BtnLimpar.Location = New System.Drawing.Point(152, 386)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(94, 28)
        Me.BtnLimpar.TabIndex = 23
        Me.BtnLimpar.Text = "&Limpar"
        '
        'BtnNomeFinal
        '
        Me.BtnNomeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnNomeFinal.Location = New System.Drawing.Point(40, 386)
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
        Me.BtnMostrarDados.Location = New System.Drawing.Point(40, 116)
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
        'TemaPictureBox
        '
        Me.TemaPictureBox.Location = New System.Drawing.Point(39, 263)
        Me.TemaPictureBox.Name = "TemaPictureBox"
        Me.TemaPictureBox.Size = New System.Drawing.Size(284, 105)
        Me.TemaPictureBox.TabIndex = 31
        Me.TemaPictureBox.TabStop = False
        '
        'UserAltDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.Size = New System.Drawing.Size(351, 426)
        CType(Me.TemaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
