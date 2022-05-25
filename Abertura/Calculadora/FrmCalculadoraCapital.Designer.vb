<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculadoraCapital
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
        Me.TextBoxCapitalSocial = New System.Windows.Forms.TextBox()
        Me.ButtonPorcentagem = New System.Windows.Forms.Button()
        Me.LblCapTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnSocio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPorcentagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAntigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNovo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GanhaEPerca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCapitalSocial
        '
        Me.TextBoxCapitalSocial.Location = New System.Drawing.Point(119, 58)
        Me.TextBoxCapitalSocial.Name = "TextBoxCapitalSocial"
        Me.TextBoxCapitalSocial.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxCapitalSocial.TabIndex = 0
        Me.TextBoxCapitalSocial.Text = "0"
        '
        'ButtonPorcentagem
        '
        Me.ButtonPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPorcentagem.Location = New System.Drawing.Point(579, 81)
        Me.ButtonPorcentagem.Name = "ButtonPorcentagem"
        Me.ButtonPorcentagem.Size = New System.Drawing.Size(89, 48)
        Me.ButtonPorcentagem.TabIndex = 2
        Me.ButtonPorcentagem.Text = "Calcular"
        Me.ButtonPorcentagem.UseVisualStyleBackColor = True
        '
        'LblCapTotal
        '
        Me.LblCapTotal.AutoSize = True
        Me.LblCapTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblCapTotal.Location = New System.Drawing.Point(12, 61)
        Me.LblCapTotal.Name = "LblCapTotal"
        Me.LblCapTotal.Size = New System.Drawing.Size(101, 13)
        Me.LblCapTotal.TabIndex = 4
        Me.LblCapTotal.Text = "Capital Social Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSocio, Me.ColumnPorcentagem, Me.ColumnAntigo, Me.ColumnNovo, Me.GanhaEPerca})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'ColumnSocio
        '
        Me.ColumnSocio.HeaderText = "Socio"
        Me.ColumnSocio.Name = "ColumnSocio"
        '
        'ColumnPorcentagem
        '
        Me.ColumnPorcentagem.HeaderText = "%"
        Me.ColumnPorcentagem.Name = "ColumnPorcentagem"
        '
        'ColumnAntigo
        '
        Me.ColumnAntigo.HeaderText = "Capital Antigo"
        Me.ColumnAntigo.Name = "ColumnAntigo"
        '
        'ColumnNovo
        '
        Me.ColumnNovo.HeaderText = "Capital Novo"
        Me.ColumnNovo.Name = "ColumnNovo"
        '
        'GanhaEPerca
        '
        Me.GanhaEPerca.HeaderText = "Ganhou/Perdeu"
        Me.GanhaEPerca.Name = "GanhaEPerca"
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpar.Location = New System.Drawing.Point(476, 237)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(97, 29)
        Me.ButtonLimpar.TabIndex = 7
        Me.ButtonLimpar.Text = "Limpar Tudo"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Calculadora de Capital Social"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.Location = New System.Drawing.Point(571, 9)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(97, 47)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 35
        Me.BtnFechar.TabStop = False
        '
        'FrmCalculadoraCapital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 269)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonLimpar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblCapTotal)
        Me.Controls.Add(Me.ButtonPorcentagem)
        Me.Controls.Add(Me.TextBoxCapitalSocial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalculadoraCapital"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora de Capital Social"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCapitalSocial As TextBox
    Friend WithEvents ButtonPorcentagem As Button
    Friend WithEvents LblCapTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnSocio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPorcentagem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAntigo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNovo As DataGridViewTextBoxColumn
    Friend WithEvents GanhaEPerca As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLimpar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFechar As PictureBox
End Class
