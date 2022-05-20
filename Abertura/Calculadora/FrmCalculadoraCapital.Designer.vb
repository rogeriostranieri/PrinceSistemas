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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblCapTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnSocio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPorcentagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAntigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNovo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSocio, Me.ColumnPorcentagem, Me.ColumnAntigo, Me.ColumnNovo})
        Me.DataGridView1.Location = New System.Drawing.Point(59, 234)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(486, 150)
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
        'FrmCalculadoraCapital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblCapTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FrmCalculadoraCapital"
        Me.Text = "FrmCalculadoraCapital"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LblCapTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnSocio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPorcentagem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAntigo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNovo As DataGridViewTextBoxColumn
End Class
