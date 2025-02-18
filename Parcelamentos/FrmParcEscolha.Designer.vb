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
        Me.LabelGeral = New System.Windows.Forms.Label()
        Me.Lbltexto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxData = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAgora = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AtrasoParcelaCheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBoxFormaDeEnvio = New System.Windows.Forms.TextBox()
        Me.TextBoxNparcEnviada = New System.Windows.Forms.TextBox()
        Me.ButtonEcac = New System.Windows.Forms.Button()
        Me.ButtonProc = New System.Windows.Forms.Button()
        Me.LabelCNPJ = New System.Windows.Forms.Label()
        Me.LinkLabelCopiaCNPJ = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'ComboBoxProtParc
        '
        Me.ComboBoxProtParc.FormattingEnabled = True
        Me.ComboBoxProtParc.Location = New System.Drawing.Point(252, 250)
        Me.ComboBoxProtParc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxProtParc.Name = "ComboBoxProtParc"
        Me.ComboBoxProtParc.Size = New System.Drawing.Size(313, 32)
        Me.ComboBoxProtParc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 254)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Protocolo do Parcelamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(87, 300)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total de Parcelas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(48, 378)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nº da Parcela Enviada:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(252, 454)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(315, 61)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'ComboBoxTotalParc
        '
        Me.ComboBoxTotalParc.FormattingEnabled = True
        Me.ComboBoxTotalParc.Location = New System.Drawing.Point(252, 295)
        Me.ComboBoxTotalParc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxTotalParc.Name = "ComboBoxTotalParc"
        Me.ComboBoxTotalParc.Size = New System.Drawing.Size(313, 32)
        Me.ComboBoxTotalParc.TabIndex = 5
        '
        'LabelGeral
        '
        Me.LabelGeral.AutoSize = True
        Me.LabelGeral.BackColor = System.Drawing.Color.Transparent
        Me.LabelGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGeral.ForeColor = System.Drawing.Color.DarkViolet
        Me.LabelGeral.Location = New System.Drawing.Point(13, 12)
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
        Me.Lbltexto.Location = New System.Drawing.Point(15, 113)
        Me.Lbltexto.Name = "Lbltexto"
        Me.Lbltexto.Size = New System.Drawing.Size(64, 22)
        Me.Lbltexto.TabIndex = 8
        Me.Lbltexto.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(121, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data Enviada:"
        '
        'MaskedTextBoxData
        '
        Me.MaskedTextBoxData.Location = New System.Drawing.Point(252, 210)
        Me.MaskedTextBoxData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaskedTextBoxData.Mask = "00/00/0000 90:00"
        Me.MaskedTextBoxData.Name = "MaskedTextBoxData"
        Me.MaskedTextBoxData.Size = New System.Drawing.Size(154, 29)
        Me.MaskedTextBoxData.TabIndex = 10
        Me.MaskedTextBoxData.ValidatingType = GetType(Date)
        '
        'ButtonAgora
        '
        Me.ButtonAgora.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButtonAgora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgora.Location = New System.Drawing.Point(414, 206)
        Me.ButtonAgora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAgora.Name = "ButtonAgora"
        Me.ButtonAgora.Size = New System.Drawing.Size(153, 41)
        Me.ButtonAgora.TabIndex = 11
        Me.ButtonAgora.Text = "Agora"
        Me.ButtonAgora.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Forma de Envio:"
        '
        'AtrasoParcelaCheckBox
        '
        Me.AtrasoParcelaCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.AtrasoParcelaCheckBox.Location = New System.Drawing.Point(252, 339)
        Me.AtrasoParcelaCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AtrasoParcelaCheckBox.Name = "AtrasoParcelaCheckBox"
        Me.AtrasoParcelaCheckBox.Size = New System.Drawing.Size(128, 32)
        Me.AtrasoParcelaCheckBox.TabIndex = 22
        Me.AtrasoParcelaCheckBox.Text = "Em Atraso"
        Me.AtrasoParcelaCheckBox.UseVisualStyleBackColor = False
        '
        'TextBoxFormaDeEnvio
        '
        Me.TextBoxFormaDeEnvio.Location = New System.Drawing.Point(252, 414)
        Me.TextBoxFormaDeEnvio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxFormaDeEnvio.Name = "TextBoxFormaDeEnvio"
        Me.TextBoxFormaDeEnvio.Size = New System.Drawing.Size(313, 29)
        Me.TextBoxFormaDeEnvio.TabIndex = 23
        '
        'TextBoxNparcEnviada
        '
        Me.TextBoxNparcEnviada.Location = New System.Drawing.Point(252, 374)
        Me.TextBoxNparcEnviada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxNparcEnviada.Name = "TextBoxNparcEnviada"
        Me.TextBoxNparcEnviada.Size = New System.Drawing.Size(313, 29)
        Me.TextBoxNparcEnviada.TabIndex = 6
        '
        'ButtonEcac
        '
        Me.ButtonEcac.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButtonEcac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEcac.Location = New System.Drawing.Point(15, 147)
        Me.ButtonEcac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonEcac.Name = "ButtonEcac"
        Me.ButtonEcac.Size = New System.Drawing.Size(153, 41)
        Me.ButtonEcac.TabIndex = 24
        Me.ButtonEcac.Text = "Ecac"
        Me.ButtonEcac.UseVisualStyleBackColor = False
        '
        'ButtonProc
        '
        Me.ButtonProc.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButtonProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProc.Location = New System.Drawing.Point(174, 147)
        Me.ButtonProc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonProc.Name = "ButtonProc"
        Me.ButtonProc.Size = New System.Drawing.Size(153, 41)
        Me.ButtonProc.TabIndex = 25
        Me.ButtonProc.Text = "Procuradoria"
        Me.ButtonProc.UseVisualStyleBackColor = False
        '
        'LabelCNPJ
        '
        Me.LabelCNPJ.AutoSize = True
        Me.LabelCNPJ.BackColor = System.Drawing.Color.Transparent
        Me.LabelCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCNPJ.ForeColor = System.Drawing.Color.DarkViolet
        Me.LabelCNPJ.Location = New System.Drawing.Point(14, 46)
        Me.LabelCNPJ.Name = "LabelCNPJ"
        Me.LabelCNPJ.Size = New System.Drawing.Size(92, 29)
        Me.LabelCNPJ.TabIndex = 26
        Me.LabelCNPJ.Text = "Label4"
        '
        'LinkLabelCopiaCNPJ
        '
        Me.LinkLabelCopiaCNPJ.AutoSize = True
        Me.LinkLabelCopiaCNPJ.Location = New System.Drawing.Point(15, 75)
        Me.LinkLabelCopiaCNPJ.Name = "LinkLabelCopiaCNPJ"
        Me.LinkLabelCopiaCNPJ.Size = New System.Drawing.Size(118, 24)
        Me.LinkLabelCopiaCNPJ.TabIndex = 27
        Me.LinkLabelCopiaCNPJ.TabStop = True
        Me.LinkLabelCopiaCNPJ.Text = "Copiar CNPJ"
        '
        'FrmParcEscolha
        '
        Me.AcceptButton = Me.BtnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.menu_fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 521)
        Me.Controls.Add(Me.LinkLabelCopiaCNPJ)
        Me.Controls.Add(Me.LabelCNPJ)
        Me.Controls.Add(Me.ButtonProc)
        Me.Controls.Add(Me.ButtonEcac)
        Me.Controls.Add(Me.TextBoxFormaDeEnvio)
        Me.Controls.Add(Me.AtrasoParcelaCheckBox)
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
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents LabelGeral As Label
    Friend WithEvents Lbltexto As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBoxData As MaskedTextBox
    Friend WithEvents ButtonAgora As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AtrasoParcelaCheckBox As CheckBox
    Friend WithEvents TextBoxFormaDeEnvio As TextBox
    Friend WithEvents TextBoxNparcEnviada As TextBox
    Friend WithEvents ButtonEcac As Button
    Friend WithEvents ButtonProc As Button
    Friend WithEvents LabelCNPJ As Label
    Friend WithEvents LinkLabelCopiaCNPJ As LinkLabel
End Class
