<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNAEAberturaEscolha
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
        Me.BtnInterno = New System.Windows.Forms.Button()
        Me.BtnExterno = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnInterno
        '
        Me.BtnInterno.BackColor = System.Drawing.Color.Transparent
        Me.BtnInterno.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundorobo
        Me.BtnInterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInterno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInterno.FlatAppearance.BorderSize = 0
        Me.BtnInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInterno.ForeColor = System.Drawing.Color.White
        Me.BtnInterno.Location = New System.Drawing.Point(16, 50)
        Me.BtnInterno.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInterno.Name = "BtnInterno"
        Me.BtnInterno.Size = New System.Drawing.Size(176, 69)
        Me.BtnInterno.TabIndex = 17
        Me.BtnInterno.Text = "Abrir Sistema Interno"
        Me.BtnInterno.UseVisualStyleBackColor = False
        '
        'BtnExterno
        '
        Me.BtnExterno.BackColor = System.Drawing.Color.Transparent
        Me.BtnExterno.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundorobo
        Me.BtnExterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExterno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExterno.FlatAppearance.BorderSize = 0
        Me.BtnExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExterno.ForeColor = System.Drawing.Color.White
        Me.BtnExterno.Location = New System.Drawing.Point(200, 50)
        Me.BtnExterno.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExterno.Name = "BtnExterno"
        Me.BtnExterno.Size = New System.Drawing.Size(176, 69)
        Me.BtnExterno.TabIndex = 16
        Me.BtnExterno.Text = "Abrir Site Oficial"
        Me.BtnExterno.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 27)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "CNAE - O que deseja fazer?"
        '
        'FrmCNAEAberturaEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(394, 132)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnInterno)
        Me.Controls.Add(Me.BtnExterno)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCNAEAberturaEscolha"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNAE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInterno As Button
    Friend WithEvents BtnExterno As Button
    Friend WithEvents Label6 As Label
End Class
