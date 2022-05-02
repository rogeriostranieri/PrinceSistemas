<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserNovo
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.TemaComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnCriar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        UsuarioLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        TemaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.ForeColor = System.Drawing.Color.Black
        UsuarioLabel.Location = New System.Drawing.Point(36, 5)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(64, 18)
        UsuarioLabel.TabIndex = 1
        UsuarioLabel.Text = "Usuario:"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.BackColor = System.Drawing.Color.Transparent
        SenhaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.ForeColor = System.Drawing.Color.Black
        SenhaLabel.Location = New System.Drawing.Point(36, 49)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(54, 18)
        SenhaLabel.TabIndex = 3
        SenhaLabel.Text = "Senha:"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.BackColor = System.Drawing.Color.Transparent
        NomeCompletoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeCompletoLabel.ForeColor = System.Drawing.Color.Black
        NomeCompletoLabel.Location = New System.Drawing.Point(36, 119)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(122, 18)
        NomeCompletoLabel.TabIndex = 5
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.BackColor = System.Drawing.Color.Transparent
        TemaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TemaLabel.ForeColor = System.Drawing.Color.Black
        TemaLabel.Location = New System.Drawing.Point(36, 163)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(50, 18)
        TemaLabel.TabIndex = 7
        TemaLabel.Text = "Tema:"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Location = New System.Drawing.Point(39, 26)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(196, 20)
        Me.UsuarioTextBox.TabIndex = 2
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.Location = New System.Drawing.Point(39, 70)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaTextBox.Size = New System.Drawing.Size(196, 20)
        Me.SenhaTextBox.TabIndex = 4
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(39, 140)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(305, 20)
        Me.NomeCompletoTextBox.TabIndex = 6
        '
        'TemaComboBox
        '
        Me.TemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TemaComboBox.FormattingEnabled = True
        Me.TemaComboBox.Location = New System.Drawing.Point(39, 184)
        Me.TemaComboBox.Name = "TemaComboBox"
        Me.TemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TemaComboBox.TabIndex = 8
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(239, 235)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnCriar
        '
        Me.BtnCriar.Location = New System.Drawing.Point(39, 235)
        Me.BtnCriar.Name = "BtnCriar"
        Me.BtnCriar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCriar.TabIndex = 9
        Me.BtnCriar.Text = "&Criar"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLimpar.Location = New System.Drawing.Point(139, 235)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(94, 23)
        Me.BtnLimpar.TabIndex = 11
        Me.BtnLimpar.Text = "&Limpar"
        '
        'UserNovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnCriar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(Me.TemaComboBox)
        Me.Controls.Add(NomeCompletoLabel)
        Me.Controls.Add(Me.NomeCompletoTextBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Name = "UserNovo"
        Me.Size = New System.Drawing.Size(363, 281)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents TemaComboBox As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnCriar As Button
    Friend WithEvents BtnLimpar As Button
End Class
