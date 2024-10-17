<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscolha
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
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.BtnAlvara = New System.Windows.Forms.Button()
        Me.LabelCNPJ = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.BackColor = System.Drawing.Color.Azure
        Me.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.Location = New System.Drawing.Point(12, 12)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(211, 77)
        Me.BtnEmpresa.TabIndex = 0
        Me.BtnEmpresa.Text = "Empresas"
        Me.BtnEmpresa.UseVisualStyleBackColor = False
        '
        'BtnAlvara
        '
        Me.BtnAlvara.BackColor = System.Drawing.Color.Azure
        Me.BtnAlvara.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAlvara.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAlvara.Location = New System.Drawing.Point(12, 95)
        Me.BtnAlvara.Name = "BtnAlvara"
        Me.BtnAlvara.Size = New System.Drawing.Size(211, 77)
        Me.BtnAlvara.TabIndex = 1
        Me.BtnAlvara.Text = "Alvara"
        Me.BtnAlvara.UseVisualStyleBackColor = False
        '
        'LabelCNPJ
        '
        Me.LabelCNPJ.AutoSize = True
        Me.LabelCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCNPJ.Location = New System.Drawing.Point(235, 9)
        Me.LabelCNPJ.Name = "LabelCNPJ"
        Me.LabelCNPJ.Size = New System.Drawing.Size(66, 24)
        Me.LabelCNPJ.TabIndex = 2
        Me.LabelCNPJ.Text = "Label1"
        Me.LabelCNPJ.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(89, 173)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 198)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Copiar CNPJ"
        '
        'FrmEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(239, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelCNPJ)
        Me.Controls.Add(Me.BtnAlvara)
        Me.Controls.Add(Me.BtnEmpresa)
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEscolha"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prince Sistemas - Escolha"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEmpresa As Button
    Friend WithEvents BtnAlvara As Button
    Friend WithEvents LabelCNPJ As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
