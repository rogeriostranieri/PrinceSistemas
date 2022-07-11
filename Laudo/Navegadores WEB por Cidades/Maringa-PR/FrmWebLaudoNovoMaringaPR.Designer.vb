<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWebLaudoNovoMaringaPR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWebLaudoNovoMaringaPR))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.LblStatusCarregamento = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImportarCNPJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroImobiliarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndereçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CnaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WebView21, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.542056!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.45795!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 386)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ProgressBar1, Me.LblStatusCarregamento})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 365)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 21)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 16)
        Me.ToolStripStatusLabel1.Text = "Status :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 15)
        '
        'LblStatusCarregamento
        '
        Me.LblStatusCarregamento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusCarregamento.Name = "LblStatusCarregamento"
        Me.LblStatusCarregamento.Size = New System.Drawing.Size(141, 16)
        Me.LblStatusCarregamento.Text = "Esperando Conexão"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator3, Me.ToolStripDropDownButton2, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 23)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripLabel3.Text = "PARANÁ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(242, 20)
        Me.ToolStripLabel2.Text = "PREFEITURA DO MUNICIPIO DE MARINGA"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.Image = Global.PrinceSistemas.My.Resources.Resources.Cancel
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 20)
        Me.ToolStripButton1.Text = "Fechar"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarCNPJToolStripMenuItem, Me.CadastroImobiliarioToolStripMenuItem, Me.EndereçoToolStripMenuItem, Me.ÁreaToolStripMenuItem, Me.CnaeToolStripMenuItem})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(114, 20)
        Me.ToolStripDropDownButton1.Text = "Importar Dados"
        Me.ToolStripDropDownButton1.ToolTipText = "Importar Dados"
        '
        'ImportarCNPJToolStripMenuItem
        '
        Me.ImportarCNPJToolStripMenuItem.Name = "ImportarCNPJToolStripMenuItem"
        Me.ImportarCNPJToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImportarCNPJToolStripMenuItem.Text = "CNPJ"
        '
        'CadastroImobiliarioToolStripMenuItem
        '
        Me.CadastroImobiliarioToolStripMenuItem.Name = "CadastroImobiliarioToolStripMenuItem"
        Me.CadastroImobiliarioToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CadastroImobiliarioToolStripMenuItem.Text = "Cadastro Imobiliario"
        '
        'EndereçoToolStripMenuItem
        '
        Me.EndereçoToolStripMenuItem.Name = "EndereçoToolStripMenuItem"
        Me.EndereçoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EndereçoToolStripMenuItem.Text = "Ou Endereço"
        '
        'ÁreaToolStripMenuItem
        '
        Me.ÁreaToolStripMenuItem.Name = "ÁreaToolStripMenuItem"
        Me.ÁreaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ÁreaToolStripMenuItem.Text = "Área"
        '
        'CnaeToolStripMenuItem
        '
        Me.CnaeToolStripMenuItem.Name = "CnaeToolStripMenuItem"
        Me.CnaeToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CnaeToolStripMenuItem.Text = "Cnae"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(77, 20)
        Me.ToolStripDropDownButton2.Text = "Nº Laudo"
        Me.ToolStripDropDownButton2.ToolTipText = "Importar Dados"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.ToolStripMenuItem1.Text = "Importar Nº do Laudo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(3, 26)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(794, 336)
        Me.WebView21.TabIndex = 8
        Me.WebView21.ZoomFactor = 1.0R
        '
        'FrmWebLaudoNovoMaringaPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 386)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmWebLaudoNovoMaringaPR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmWebLaudoNovoMaringaPR"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents LblStatusCarregamento As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ImportarCNPJToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroImobiliarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndereçoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ÁreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CnaeToolStripMenuItem As ToolStripMenuItem
End Class
