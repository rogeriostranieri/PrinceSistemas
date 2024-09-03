<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMultaBombeiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMultaBombeiro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxDataMulta = New System.Windows.Forms.MaskedTextBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BoxMultaDataFinal = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data da Notificação de Autuação:"
        '
        'BoxDataMulta
        '
        Me.BoxDataMulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDataMulta.Location = New System.Drawing.Point(337, 6)
        Me.BoxDataMulta.Mask = "00/00/0000"
        Me.BoxDataMulta.Name = "BoxDataMulta"
        Me.BoxDataMulta.Size = New System.Drawing.Size(102, 29)
        Me.BoxDataMulta.TabIndex = 1
        Me.BoxDataMulta.ValidatingType = GetType(Date)
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Green
        Me.BtnSalvar.Location = New System.Drawing.Point(261, 427)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(93, 31)
        Me.BtnSalvar.TabIndex = 47
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFechar.Location = New System.Drawing.Point(392, 427)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(93, 31)
        Me.BtnFechar.TabIndex = 48
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(20, 100)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(758, 321)
        Me.RichTextBox1.TabIndex = 49
        Me.RichTextBox1.Text = ""
        '
        'BoxMultaDataFinal
        '
        Me.BoxMultaDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMultaDataFinal.Location = New System.Drawing.Point(337, 41)
        Me.BoxMultaDataFinal.Mask = "00/00/0000"
        Me.BoxMultaDataFinal.Name = "BoxMultaDataFinal"
        Me.BoxMultaDataFinal.ReadOnly = True
        Me.BoxMultaDataFinal.Size = New System.Drawing.Size(102, 29)
        Me.BoxMultaDataFinal.TabIndex = 51
        Me.BoxMultaDataFinal.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Prazo Final:"
        '
        'Btncalcular
        '
        Me.Btncalcular.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.Btncalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncalcular.ForeColor = System.Drawing.Color.MediumBlue
        Me.Btncalcular.Location = New System.Drawing.Point(445, 6)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(93, 64)
        Me.Btncalcular.TabIndex = 77
        Me.Btncalcular.Text = "Calcular prazo"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'FrmMultaBombeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.BoxMultaDataFinal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BoxDataMulta)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMultaBombeiro"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bombeiros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BoxDataMulta As MaskedTextBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BoxMultaDataFinal As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btncalcular As Button
End Class
