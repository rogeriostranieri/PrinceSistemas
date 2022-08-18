<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WebAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebAgenda))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DiaBox = New System.Windows.Forms.TextBox()
        Me.MesBox = New System.Windows.Forms.TextBox()
        Me.AnoBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAtualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.LblStatusCarregamento = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(491, 28)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Agenda Tributária"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'DiaBox
        '
        Me.DiaBox.Location = New System.Drawing.Point(6, 19)
        Me.DiaBox.MaxLength = 2
        Me.DiaBox.Name = "DiaBox"
        Me.DiaBox.Size = New System.Drawing.Size(28, 20)
        Me.DiaBox.TabIndex = 6
        '
        'MesBox
        '
        Me.MesBox.Location = New System.Drawing.Point(46, 19)
        Me.MesBox.MaxLength = 2
        Me.MesBox.Name = "MesBox"
        Me.MesBox.Size = New System.Drawing.Size(28, 20)
        Me.MesBox.TabIndex = 7
        '
        'AnoBox
        '
        Me.AnoBox.Location = New System.Drawing.Point(86, 19)
        Me.AnoBox.MaxLength = 4
        Me.AnoBox.Name = "AnoBox"
        Me.AnoBox.Size = New System.Drawing.Size(39, 20)
        Me.AnoBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "/"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAtualizar)
        Me.GroupBox1.Controls.Add(Me.DiaBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MesBox)
        Me.GroupBox1.Controls.Add(Me.AnoBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 63)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAtualizar.Location = New System.Drawing.Point(127, 19)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(46, 20)
        Me.BtnAtualizar.TabIndex = 12
        Me.BtnAtualizar.Text = "Mudar"
        Me.BtnAtualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "/"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ProgressBar1, Me.LblStatusCarregamento})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(860, 25)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 20)
        Me.ToolStripStatusLabel1.Text = "Status :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 19)
        '
        'LblStatusCarregamento
        '
        Me.LblStatusCarregamento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusCarregamento.Name = "LblStatusCarregamento"
        Me.LblStatusCarregamento.Size = New System.Drawing.Size(153, 20)
        Me.LblStatusCarregamento.Text = "ToolStripStatusLabel2"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 132)
        Me.Panel1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(720, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 66)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.logo_receita
        Me.PictureBox1.Location = New System.Drawing.Point(503, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'WebView2
        '
        Me.WebView2.AllowExternalDrop = True
        Me.WebView2.CreationProperties = Nothing
        Me.WebView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView2.Location = New System.Drawing.Point(0, 132)
        Me.WebView2.Name = "WebView2"
        Me.WebView2.Size = New System.Drawing.Size(860, 293)
        Me.WebView2.Source = New System.Uri("https://www.gov.br/receitafederal/pt-br/assuntos/agenda-tributaria/agenda-tributa" &
        "ria", System.UriKind.Absolute)
        Me.WebView2.TabIndex = 16
        Me.WebView2.ZoomFactor = 1.0R
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.icone_questao
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(304, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 66)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WebAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 450)
        Me.Controls.Add(Me.WebView2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "WebAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Tributária"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DiaBox As TextBox
    Friend WithEvents MesBox As TextBox
    Friend WithEvents AnoBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAtualizar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WebView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents LblStatusCarregamento As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
