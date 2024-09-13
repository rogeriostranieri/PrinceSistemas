<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRichTextCompleto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRichTextCompleto))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ColarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBoxFontes = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBoxTamanho = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RichTextBoxCompleto = New System.Windows.Forms.RichTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonNegrito = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonItalico = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSublinhado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.79926!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxCompleto, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.391753!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.60825!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(817, 485)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.AbrirToolStripButton, Me.SalvarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton, Me.CopiarToolStripButton, Me.ColarToolStripButton, Me.toolStripSeparator1, Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripComboBoxFontes, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.ToolStripComboBoxTamanho, Me.ToolStripSeparator4, Me.ToolStripButtonNegrito, Me.ToolStripButtonItalico, Me.ToolStripButtonSublinhado, Me.ToolStripSeparator5, Me.AjudaToolStripButton, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(817, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.AbrirToolStripButton.Text = "&Abrir"
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.SalvarToolStripButton.Text = "&Salvar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'RecortarToolStripButton
        '
        Me.RecortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecortarToolStripButton.Image = CType(resources.GetObject("RecortarToolStripButton.Image"), System.Drawing.Image)
        Me.RecortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecortarToolStripButton.Name = "RecortarToolStripButton"
        Me.RecortarToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.RecortarToolStripButton.Text = "Recor&tar"
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'ColarToolStripButton
        '
        Me.ColarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColarToolStripButton.Image = CType(resources.GetObject("ColarToolStripButton.Image"), System.Drawing.Image)
        Me.ColarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ColarToolStripButton.Name = "ColarToolStripButton"
        Me.ColarToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.ColarToolStripButton.Text = "C&olar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 28)
        Me.ToolStripButton1.Text = "Fechar"
        '
        'ToolStripComboBoxFontes
        '
        Me.ToolStripComboBoxFontes.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBoxFontes.Name = "ToolStripComboBoxFontes"
        Me.ToolStripComboBoxFontes.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripComboBoxTamanho
        '
        Me.ToolStripComboBoxTamanho.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBoxTamanho.Name = "ToolStripComboBoxTamanho"
        Me.ToolStripComboBoxTamanho.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'AjudaToolStripButton
        '
        Me.AjudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AjudaToolStripButton.Image = CType(resources.GetObject("AjudaToolStripButton.Image"), System.Drawing.Image)
        Me.AjudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AjudaToolStripButton.Name = "AjudaToolStripButton"
        Me.AjudaToolStripButton.Size = New System.Drawing.Size(23, 28)
        Me.AjudaToolStripButton.Text = "&Ajuda"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'RichTextBoxCompleto
        '
        Me.RichTextBoxCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxCompleto.Location = New System.Drawing.Point(3, 34)
        Me.RichTextBoxCompleto.Name = "RichTextBoxCompleto"
        Me.RichTextBoxCompleto.Size = New System.Drawing.Size(811, 448)
        Me.RichTextBoxCompleto.TabIndex = 1
        Me.RichTextBoxCompleto.Text = ""
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 28)
        Me.ToolStripLabel1.Text = "Fonte"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(73, 28)
        Me.ToolStripLabel2.Text = "Tamanho"
        '
        'ToolStripButtonNegrito
        '
        Me.ToolStripButtonNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonNegrito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonNegrito.Image = CType(resources.GetObject("ToolStripButtonNegrito.Image"), System.Drawing.Image)
        Me.ToolStripButtonNegrito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNegrito.Name = "ToolStripButtonNegrito"
        Me.ToolStripButtonNegrito.Size = New System.Drawing.Size(24, 28)
        Me.ToolStripButtonNegrito.Text = "B"
        '
        'ToolStripButtonItalico
        '
        Me.ToolStripButtonItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonItalico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonItalico.Image = CType(resources.GetObject("ToolStripButtonItalico.Image"), System.Drawing.Image)
        Me.ToolStripButtonItalico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonItalico.Name = "ToolStripButtonItalico"
        Me.ToolStripButtonItalico.Size = New System.Drawing.Size(23, 28)
        Me.ToolStripButtonItalico.Text = "i"
        '
        'ToolStripButtonSublinhado
        '
        Me.ToolStripButtonSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSublinhado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonSublinhado.Image = CType(resources.GetObject("ToolStripButtonSublinhado.Image"), System.Drawing.Image)
        Me.ToolStripButtonSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSublinhado.Name = "ToolStripButtonSublinhado"
        Me.ToolStripButtonSublinhado.Size = New System.Drawing.Size(23, 28)
        Me.ToolStripButtonSublinhado.Text = "S"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'FrmRichTextCompleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 485)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmRichTextCompleto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prince Sistemas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents AbrirToolStripButton As ToolStripButton
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents RecortarToolStripButton As ToolStripButton
    Friend WithEvents CopiarToolStripButton As ToolStripButton
    Friend WithEvents ColarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AjudaToolStripButton As ToolStripButton
    Friend WithEvents RichTextBoxCompleto As RichTextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripComboBoxFontes As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripComboBoxTamanho As ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButtonNegrito As ToolStripButton
    Friend WithEvents ToolStripButtonItalico As ToolStripButton
    Friend WithEvents ToolStripButtonSublinhado As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
