<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWebLaudoAntigoMaringaPR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWebLaudoAntigoMaringaPR))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuImportar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CNPJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENDEREÇOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CNAEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBJETIVODOPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.LblStatusCarregamento = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.Button1, Me.ToolStripSeparator1, Me.MenuImportar, Me.ToolStripSeparator2, Me.Button3, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1299, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(409, 22)
        Me.ToolStripLabel1.Text = "Formulário Alvará (Antigo) - Prefeitura do Município de Maringá"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Button1
        '
        Me.Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 22)
        Me.Button1.Text = "Atualizar"
        Me.Button1.ToolTipText = "Abrir Site"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'MenuImportar
        '
        Me.MenuImportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MenuImportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem})
        Me.MenuImportar.Image = CType(resources.GetObject("MenuImportar.Image"), System.Drawing.Image)
        Me.MenuImportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuImportar.Name = "MenuImportar"
        Me.MenuImportar.Size = New System.Drawing.Size(101, 22)
        Me.MenuImportar.Text = "Importar dados"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.NormalToolStripMenuItem.Text = "Preencher"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Button3
        '
        Me.Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CNPJToolStripMenuItem, Me.ENDEREÇOToolStripMenuItem, Me.CNAEToolStripMenuItem, Me.OBJETIVODOPEDIDOToolStripMenuItem})
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 22)
        Me.Button3.Text = "Faltou dados?"
        '
        'CNPJToolStripMenuItem
        '
        Me.CNPJToolStripMenuItem.Name = "CNPJToolStripMenuItem"
        Me.CNPJToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CNPJToolStripMenuItem.Text = "CNPJ"
        '
        'ENDEREÇOToolStripMenuItem
        '
        Me.ENDEREÇOToolStripMenuItem.Name = "ENDEREÇOToolStripMenuItem"
        Me.ENDEREÇOToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ENDEREÇOToolStripMenuItem.Text = "ENDEREÇO"
        '
        'CNAEToolStripMenuItem
        '
        Me.CNAEToolStripMenuItem.Name = "CNAEToolStripMenuItem"
        Me.CNAEToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CNAEToolStripMenuItem.Text = "CNAE"
        '
        'OBJETIVODOPEDIDOToolStripMenuItem
        '
        Me.OBJETIVODOPEDIDOToolStripMenuItem.Name = "OBJETIVODOPEDIDOToolStripMenuItem"
        Me.OBJETIVODOPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.OBJETIVODOPEDIDOToolStripMenuItem.Text = "OBJETIVO DO PEDIDO"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(128, 22)
        Me.ToolStripButton3.Text = "Exportar Nº. do Laudo"
        Me.ToolStripButton3.ToolTipText = "Exportar Nº. do Laudo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton1.Text = "Nº do Laudo"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 18000
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(0, 25)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(1299, 529)
        Me.WebView21.TabIndex = 3
        Me.WebView21.ZoomFactor = 1.0R
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ProgressBar1, Me.LblStatusCarregamento})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1299, 25)
        Me.StatusStrip1.TabIndex = 20
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
        Me.LblStatusCarregamento.Size = New System.Drawing.Size(141, 20)
        Me.LblStatusCarregamento.Text = "Esperando Conexão"
        '
        'FrmWebLaudoAntigoMaringaPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 554)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmWebLaudoAntigoMaringaPR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimento de Laudo - WebSite Oficial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Button1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Button3 As ToolStripDropDownButton
    Friend WithEvents CNPJToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENDEREÇOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CNAEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OBJETIVODOPEDIDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MenuImportar As ToolStripDropDownButton
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents LblStatusCarregamento As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
