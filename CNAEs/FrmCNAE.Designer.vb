<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNAE
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
        Me.RichTextBoxCNAEBusca = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxCNAEresultado = New System.Windows.Forms.RichTextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTodosCNAE = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBoxCNAEBusca
        '
        Me.RichTextBoxCNAEBusca.Location = New System.Drawing.Point(16, 135)
        Me.RichTextBoxCNAEBusca.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxCNAEBusca.Name = "RichTextBoxCNAEBusca"
        Me.RichTextBoxCNAEBusca.Size = New System.Drawing.Size(153, 249)
        Me.RichTextBoxCNAEBusca.TabIndex = 0
        Me.RichTextBoxCNAEBusca.Text = ""
        '
        'RichTextBoxCNAEresultado
        '
        Me.RichTextBoxCNAEresultado.Location = New System.Drawing.Point(301, 135)
        Me.RichTextBoxCNAEresultado.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxCNAEresultado.Name = "RichTextBoxCNAEresultado"
        Me.RichTextBoxCNAEresultado.Size = New System.Drawing.Size(829, 249)
        Me.RichTextBoxCNAEresultado.TabIndex = 1
        Me.RichTextBoxCNAEresultado.Text = ""
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(177, 135)
        Me.BtnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(116, 44)
        Me.BtnConsultar.TabIndex = 2
        Me.BtnConsultar.Text = "Buscar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CNAEs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(659, 388)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*Até momento apenas Grau de Risco para CNAE na prefeitura de Maringá-PR"
        '
        'BtnTodosCNAE
        '
        Me.BtnTodosCNAE.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnTodosCNAE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTodosCNAE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTodosCNAE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTodosCNAE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTodosCNAE.Location = New System.Drawing.Point(891, 83)
        Me.BtnTodosCNAE.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTodosCNAE.Name = "BtnTodosCNAE"
        Me.BtnTodosCNAE.Size = New System.Drawing.Size(239, 44)
        Me.BtnTodosCNAE.TabIndex = 7
        Me.BtnTodosCNAE.Text = "Ver todos CNAE"
        Me.BtnTodosCNAE.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(951, 1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(663, 33)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Consultar Grau de Risco - Fiscalização da Prefeitura"
        '
        'FrmCNAE
        '
        Me.AcceptButton = Me.BtnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1143, 406)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnTodosCNAE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.RichTextBoxCNAEresultado)
        Me.Controls.Add(Me.RichTextBoxCNAEBusca)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCNAE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNAE - Grau de Risco"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBoxCNAEBusca As RichTextBox
    Friend WithEvents RichTextBoxCNAEresultado As RichTextBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTodosCNAE As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
End Class
