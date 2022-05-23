<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadoraCapital
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
        Me.TextBoxCapitalSocial = New System.Windows.Forms.TextBox()
        Me.ButtonPorcentagem = New System.Windows.Forms.Button()
        Me.LblCapTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnSocio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPorcentagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAntigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNovo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GanhaEPerca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonDistribuir = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCapitalSocial
        '
        Me.TextBoxCapitalSocial.Location = New System.Drawing.Point(128, 36)
        Me.TextBoxCapitalSocial.Name = "TextBoxCapitalSocial"
        Me.TextBoxCapitalSocial.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxCapitalSocial.TabIndex = 0
        Me.TextBoxCapitalSocial.Text = "20000"
        '
        'ButtonPorcentagem
        '
        Me.ButtonPorcentagem.Location = New System.Drawing.Point(592, 81)
        Me.ButtonPorcentagem.Name = "ButtonPorcentagem"
        Me.ButtonPorcentagem.Size = New System.Drawing.Size(89, 20)
        Me.ButtonPorcentagem.TabIndex = 2
        Me.ButtonPorcentagem.Text = "% Porcentgem"
        Me.ButtonPorcentagem.UseVisualStyleBackColor = True
        '
        'LblCapTotal
        '
        Me.LblCapTotal.AutoSize = True
        Me.LblCapTotal.Location = New System.Drawing.Point(21, 39)
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
        'ButtonDistribuir
        '
        Me.ButtonDistribuir.Location = New System.Drawing.Point(592, 107)
        Me.ButtonDistribuir.Name = "ButtonDistribuir"
        Me.ButtonDistribuir.Size = New System.Drawing.Size(89, 20)
        Me.ButtonDistribuir.TabIndex = 6
        Me.ButtonDistribuir.Text = "Distribuição"
        Me.ButtonDistribuir.UseVisualStyleBackColor = True
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.Location = New System.Drawing.Point(484, 237)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(89, 20)
        Me.ButtonLimpar.TabIndex = 7
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'FrmCalculadoraCapital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 269)
        Me.Controls.Add(Me.ButtonLimpar)
        Me.Controls.Add(Me.ButtonDistribuir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblCapTotal)
        Me.Controls.Add(Me.ButtonPorcentagem)
        Me.Controls.Add(Me.TextBoxCapitalSocial)
        Me.Name = "FrmCalculadoraCapital"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCalculadoraCapital"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCapitalSocial As TextBox
    Friend WithEvents ButtonPorcentagem As Button
    Friend WithEvents LblCapTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonDistribuir As Button
    Friend WithEvents ColumnSocio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPorcentagem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAntigo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNovo As DataGridViewTextBoxColumn
    Friend WithEvents GanhaEPerca As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLimpar As Button
End Class
