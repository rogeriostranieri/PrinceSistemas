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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBoxProtParc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.ComboBoxTotalParc = New System.Windows.Forms.ComboBox()
        Me.TextBoxNparcEnviada = New System.Windows.Forms.TextBox()
        Me.LabelGeral = New System.Windows.Forms.Label()
        Me.Lbltexto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxData = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAgora = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelFormaDeEnvio = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ComboBoxProtParc
        '
        Me.ComboBoxProtParc.FormattingEnabled = True
        Me.ComboBoxProtParc.Location = New System.Drawing.Point(206, 114)
        Me.ComboBoxProtParc.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxProtParc.Name = "ComboBoxProtParc"
        Me.ComboBoxProtParc.Size = New System.Drawing.Size(257, 26)
        Me.ComboBoxProtParc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 117)
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
        Me.Label2.Location = New System.Drawing.Point(71, 151)
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
        Me.Label3.Location = New System.Drawing.Point(40, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nº da Parcela Enviada:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(206, 215)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(257, 46)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'ComboBoxTotalParc
        '
        Me.ComboBoxTotalParc.FormattingEnabled = True
        Me.ComboBoxTotalParc.Location = New System.Drawing.Point(206, 148)
        Me.ComboBoxTotalParc.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxTotalParc.Name = "ComboBoxTotalParc"
        Me.ComboBoxTotalParc.Size = New System.Drawing.Size(257, 26)
        Me.ComboBoxTotalParc.TabIndex = 5
        '
        'TextBoxNparcEnviada
        '
        Me.TextBoxNparcEnviada.Location = New System.Drawing.Point(206, 181)
        Me.TextBoxNparcEnviada.Name = "TextBoxNparcEnviada"
        Me.TextBoxNparcEnviada.Size = New System.Drawing.Size(257, 24)
        Me.TextBoxNparcEnviada.TabIndex = 6
        '
        'LabelGeral
        '
        Me.LabelGeral.AutoSize = True
        Me.LabelGeral.BackColor = System.Drawing.Color.Transparent
        Me.LabelGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGeral.ForeColor = System.Drawing.Color.DarkViolet
        Me.LabelGeral.Location = New System.Drawing.Point(11, 9)
        Me.LabelGeral.Name = "LabelGeral"
        Me.LabelGeral.Size = New System.Drawing.Size(92, 29)
        Me.LabelGeral.TabIndex = 7
        Me.LabelGeral.Text = "Label4"
        '
        'Lbltexto
        '
        Me.Lbltexto.AutoSize = True
        Me.Lbltexto.BackColor = System.Drawing.Color.Transparent
        Me.Lbltexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Italic)
        Me.Lbltexto.Location = New System.Drawing.Point(13, 44)
        Me.Lbltexto.Name = "Lbltexto"
        Me.Lbltexto.Size = New System.Drawing.Size(64, 22)
        Me.Lbltexto.TabIndex = 8
        Me.Lbltexto.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(99, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data Enviada:"
        '
        'MaskedTextBoxData
        '
        Me.MaskedTextBoxData.Location = New System.Drawing.Point(206, 84)
        Me.MaskedTextBoxData.Mask = "00/00/0000 90:00"
        Me.MaskedTextBoxData.Name = "MaskedTextBoxData"
        Me.MaskedTextBoxData.Size = New System.Drawing.Size(126, 24)
        Me.MaskedTextBoxData.TabIndex = 10
        Me.MaskedTextBoxData.ValidatingType = GetType(Date)
        '
        'ButtonAgora
        '
        Me.ButtonAgora.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButtonAgora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgora.Location = New System.Drawing.Point(338, 81)
        Me.ButtonAgora.Name = "ButtonAgora"
        Me.ButtonAgora.Size = New System.Drawing.Size(125, 31)
        Me.ButtonAgora.TabIndex = 11
        Me.ButtonAgora.Text = "Agora"
        Me.ButtonAgora.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Forma de Envio:"
        '
        'LabelFormaDeEnvio
        '
        Me.LabelFormaDeEnvio.AutoSize = True
        Me.LabelFormaDeEnvio.BackColor = System.Drawing.Color.Transparent
        Me.LabelFormaDeEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormaDeEnvio.Location = New System.Drawing.Point(204, 264)
        Me.LabelFormaDeEnvio.Name = "LabelFormaDeEnvio"
        Me.LabelFormaDeEnvio.Size = New System.Drawing.Size(0, 24)
        Me.LabelFormaDeEnvio.TabIndex = 13
        '
        'Timer1
        '
        '
        'FrmParcEscolha
        '
        Me.AcceptButton = Me.BtnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.menu_fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(480, 293)
        Me.Controls.Add(Me.LabelFormaDeEnvio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonAgora)
        Me.Controls.Add(Me.MaskedTextBoxData)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBoxData As MaskedTextBox
    Friend WithEvents ButtonAgora As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelFormaDeEnvio As Label
    Friend WithEvents Timer1 As Timer
End Class
