<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParcEscolha
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
        Me.ComboBoxProtParc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.ComboBoxTotalParc = New System.Windows.Forms.ComboBox()
        Me.TextBoxNparcEnviada = New System.Windows.Forms.TextBox()
        Me.LabelGeral = New System.Windows.Forms.Label()
        Me.Lbltexto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxProtParc
        '
        Me.ComboBoxProtParc.FormattingEnabled = True
        Me.ComboBoxProtParc.Location = New System.Drawing.Point(216, 69)
        Me.ComboBoxProtParc.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxProtParc.Name = "ComboBoxProtParc"
        Me.ComboBoxProtParc.Size = New System.Drawing.Size(257, 26)
        Me.ComboBoxProtParc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Protocolo do Parcelamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(81, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total de Parcelas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(50, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nº da Parcela Enviada:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(216, 170)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(257, 46)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'ComboBoxTotalParc
        '
        Me.ComboBoxTotalParc.FormattingEnabled = True
        Me.ComboBoxTotalParc.Location = New System.Drawing.Point(216, 103)
        Me.ComboBoxTotalParc.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxTotalParc.Name = "ComboBoxTotalParc"
        Me.ComboBoxTotalParc.Size = New System.Drawing.Size(257, 26)
        Me.ComboBoxTotalParc.TabIndex = 5
        '
        'TextBoxNparcEnviada
        '
        Me.TextBoxNparcEnviada.Location = New System.Drawing.Point(216, 136)
        Me.TextBoxNparcEnviada.Name = "TextBoxNparcEnviada"
        Me.TextBoxNparcEnviada.Size = New System.Drawing.Size(257, 24)
        Me.TextBoxNparcEnviada.TabIndex = 6
        '
        'LabelGeral
        '
        Me.LabelGeral.AutoSize = True
        Me.LabelGeral.BackColor = System.Drawing.Color.Transparent
        Me.LabelGeral.Location = New System.Drawing.Point(213, 11)
        Me.LabelGeral.Name = "LabelGeral"
        Me.LabelGeral.Size = New System.Drawing.Size(51, 18)
        Me.LabelGeral.TabIndex = 7
        Me.LabelGeral.Text = "Label4"
        '
        'Lbltexto
        '
        Me.Lbltexto.AutoSize = True
        Me.Lbltexto.BackColor = System.Drawing.Color.Transparent
        Me.Lbltexto.Location = New System.Drawing.Point(213, 47)
        Me.Lbltexto.Name = "Lbltexto"
        Me.Lbltexto.Size = New System.Drawing.Size(51, 18)
        Me.Lbltexto.TabIndex = 8
        Me.Lbltexto.Text = "Label4"
        '
        'FrmParcEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 235)
        Me.Controls.Add(Me.Lbltexto)
        Me.Controls.Add(Me.LabelGeral)
        Me.Controls.Add(Me.TextBoxNparcEnviada)
        Me.Controls.Add(Me.ComboBoxTotalParc)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxProtParc)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmParcEscolha"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar envio de parcelamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxProtParc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents ComboBoxTotalParc As ComboBox
    Friend WithEvents TextBoxNparcEnviada As TextBox
    Friend WithEvents LabelGeral As Label
    Friend WithEvents Lbltexto As Label
End Class
