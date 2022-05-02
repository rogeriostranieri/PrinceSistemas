<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWebLaudoAntigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWebLaudoAntigo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TxtCarregar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuImportar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CNPJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENDEREÇOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CNAEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBJETIVODOPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.TextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.WebBrowser1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.334963!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66504!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 66)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(794, 360)
        Me.WebBrowser1.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.TxtCarregar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 429)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 21)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 18)
        '
        'TxtCarregar
        '
        Me.TxtCarregar.Name = "TxtCarregar"
        Me.TxtCarregar.Size = New System.Drawing.Size(52, 18)
        Me.TxtCarregar.Text = "Aguarde"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button1, Me.ToolStripSeparator1, Me.MenuImportar, Me.ToolStripSeparator2, Me.Button3, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 34)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button1
        '
        Me.Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 31)
        Me.Button1.Text = "Atualizar"
        Me.Button1.ToolTipText = "Abrir Site"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'MenuImportar
        '
        Me.MenuImportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MenuImportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.MEIToolStripMenuItem})
        Me.MenuImportar.Image = CType(resources.GetObject("MenuImportar.Image"), System.Drawing.Image)
        Me.MenuImportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuImportar.Name = "MenuImportar"
        Me.MenuImportar.Size = New System.Drawing.Size(101, 31)
        Me.MenuImportar.Text = "Importar dados"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'MEIToolStripMenuItem
        '
        Me.MEIToolStripMenuItem.Name = "MEIToolStripMenuItem"
        Me.MEIToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.MEIToolStripMenuItem.Text = "MEI"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'Button3
        '
        Me.Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CNPJToolStripMenuItem, Me.ENDEREÇOToolStripMenuItem, Me.CNAEToolStripMenuItem, Me.OBJETIVODOPEDIDOToolStripMenuItem})
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 31)
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
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(465, 31)
        Me.ToolStripButton1.Text = "Formulário Alvará (Antigo) - Prefeitura do Município de Maringá"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextBox1, Me.ToolStripButton2, Me.ToolStripSeparator4})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 34)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(128, 22)
        Me.ToolStripButton2.Text = "Exportar Nº. do Laudo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 18000
        '
        'FrmWebLaudoAntigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmWebLaudoAntigo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimento de Laudo - WebSite Oficial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents TxtCarregar As ToolStripLabel
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents TextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents MenuImportar As ToolStripDropDownButton
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MEIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
