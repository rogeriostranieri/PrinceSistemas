<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExtraiCNPJ
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
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.WebSite = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxAguarde = New System.Windows.Forms.PictureBox()
        Me.LinkCadastro = New System.Windows.Forms.LinkLabel()
        Me.BtnImportarAlternativo = New System.Windows.Forms.Button()
        Me.BtnAbrirInterno = New System.Windows.Forms.Button()
        Me.BtnAbrirExterno = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        Me.LinkLabelImportar = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnIR = New System.Windows.Forms.PictureBox()
        Me.BtnVoltar = New System.Windows.Forms.PictureBox()
        Me.BtnAvancar = New System.Windows.Forms.PictureBox()
        Me.BtnAtualizar = New System.Windows.Forms.PictureBox()
        Me.BtnHome = New System.Windows.Forms.PictureBox()
        Me.SITETextBox = New System.Windows.Forms.TextBox()
        Me.BtnParar = New System.Windows.Forms.PictureBox()
        Me.BtnSoltar = New System.Windows.Forms.PictureBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TxtCarregamento = New System.Windows.Forms.ToolStripLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.WebSite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxAguarde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAvancar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnParar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.LightBlue
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExportar.Location = New System.Drawing.Point(206, 107)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(191, 50)
        Me.BtnExportar.TabIndex = 2
        Me.BtnExportar.Text = "Exportar Dados Federal"
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(95, 33)
        Me.CNPJMaskedTextBox.Mask = "99,999,999/9999-99"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(162, 26)
        Me.CNPJMaskedTextBox.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.WebSite, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(818, 608)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'WebSite
        '
        Me.WebSite.AllowExternalDrop = True
        Me.WebSite.CreationProperties = Nothing
        Me.WebSite.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebSite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebSite.Location = New System.Drawing.Point(3, 226)
        Me.WebSite.Name = "WebSite"
        Me.WebSite.Size = New System.Drawing.Size(812, 348)
        Me.WebSite.TabIndex = 8
        Me.WebSite.ZoomFactor = 1.0R
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBoxAguarde)
        Me.GroupBox1.Controls.Add(Me.LinkCadastro)
        Me.GroupBox1.Controls.Add(Me.BtnImportarAlternativo)
        Me.GroupBox1.Controls.Add(Me.BtnAbrirInterno)
        Me.GroupBox1.Controls.Add(Me.BtnAbrirExterno)
        Me.GroupBox1.Controls.Add(Me.BtnFechar)
        Me.GroupBox1.Controls.Add(Me.LinkLabelImportar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnConsultar)
        Me.GroupBox1.Controls.Add(Me.BtnExportar)
        Me.GroupBox1.Controls.Add(Me.CNPJMaskedTextBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Importar CNPJ - Receita Federal"
        '
        'PictureBoxAguarde
        '
        Me.PictureBoxAguarde.Image = Global.PrinceSistemas.My.Resources.Resources.Aguarde
        Me.PictureBoxAguarde.Location = New System.Drawing.Point(9, 25)
        Me.PictureBoxAguarde.Name = "PictureBoxAguarde"
        Me.PictureBoxAguarde.Size = New System.Drawing.Size(608, 135)
        Me.PictureBoxAguarde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAguarde.TabIndex = 19
        Me.PictureBoxAguarde.TabStop = False
        '
        'LinkCadastro
        '
        Me.LinkCadastro.AutoSize = True
        Me.LinkCadastro.Location = New System.Drawing.Point(91, 62)
        Me.LinkCadastro.Name = "LinkCadastro"
        Me.LinkCadastro.Size = New System.Drawing.Size(155, 20)
        Me.LinkCadastro.TabIndex = 20
        Me.LinkCadastro.TabStop = True
        Me.LinkCadastro.Text = "Cadastrar Empresa"
        '
        'BtnImportarAlternativo
        '
        Me.BtnImportarAlternativo.BackColor = System.Drawing.Color.LightBlue
        Me.BtnImportarAlternativo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnImportarAlternativo.Location = New System.Drawing.Point(403, 107)
        Me.BtnImportarAlternativo.Name = "BtnImportarAlternativo"
        Me.BtnImportarAlternativo.Size = New System.Drawing.Size(191, 50)
        Me.BtnImportarAlternativo.TabIndex = 18
        Me.BtnImportarAlternativo.Text = "Exportar Dados Alternativo"
        Me.BtnImportarAlternativo.UseVisualStyleBackColor = False
        '
        'BtnAbrirInterno
        '
        Me.BtnAbrirInterno.BackColor = System.Drawing.Color.LightBlue
        Me.BtnAbrirInterno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbrirInterno.Location = New System.Drawing.Point(464, 25)
        Me.BtnAbrirInterno.Name = "BtnAbrirInterno"
        Me.BtnAbrirInterno.Size = New System.Drawing.Size(117, 36)
        Me.BtnAbrirInterno.TabIndex = 17
        Me.BtnAbrirInterno.Text = "Abrir Interno"
        Me.BtnAbrirInterno.UseVisualStyleBackColor = False
        '
        'BtnAbrirExterno
        '
        Me.BtnAbrirExterno.BackColor = System.Drawing.Color.LightBlue
        Me.BtnAbrirExterno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbrirExterno.Location = New System.Drawing.Point(341, 26)
        Me.BtnAbrirExterno.Name = "BtnAbrirExterno"
        Me.BtnAbrirExterno.Size = New System.Drawing.Size(117, 36)
        Me.BtnAbrirExterno.TabIndex = 16
        Me.BtnAbrirExterno.Text = "Abrir Externo"
        Me.BtnAbrirExterno.UseVisualStyleBackColor = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.Location = New System.Drawing.Point(672, 9)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(134, 60)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 15
        Me.BtnFechar.TabStop = False
        '
        'LinkLabelImportar
        '
        Me.LinkLabelImportar.AutoSize = True
        Me.LinkLabelImportar.Location = New System.Drawing.Point(264, 36)
        Me.LinkLabelImportar.Name = "LinkLabelImportar"
        Me.LinkLabelImportar.Size = New System.Drawing.Size(71, 20)
        Me.LinkLabelImportar.TabIndex = 6
        Me.LinkLabelImportar.TabStop = True
        Me.LinkLabelImportar.Text = "Importar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CNPJ ="
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.LightBlue
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultar.Location = New System.Drawing.Point(9, 107)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(191, 50)
        Me.BtnConsultar.TabIndex = 4
        Me.BtnConsultar.Text = "Consultar Abaixo"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 166)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(818, 57)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnIR, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnVoltar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAvancar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAtualizar, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnHome, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SITETextBox, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnParar, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSoltar, 8, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 20)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(818, 37)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'BtnIR
        '
        Me.BtnIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIR.Image = Global.PrinceSistemas.My.Resources.Resources.acessar
        Me.BtnIR.Location = New System.Drawing.Point(702, 3)
        Me.BtnIR.Name = "BtnIR"
        Me.BtnIR.Size = New System.Drawing.Size(31, 30)
        Me.BtnIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnIR.TabIndex = 0
        Me.BtnIR.TabStop = False
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVoltar.Image = Global.PrinceSistemas.My.Resources.Resources.VoltarNavegador
        Me.BtnVoltar.Location = New System.Drawing.Point(11, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(32, 30)
        Me.BtnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnVoltar.TabIndex = 1
        Me.BtnVoltar.TabStop = False
        '
        'BtnAvancar
        '
        Me.BtnAvancar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAvancar.Image = Global.PrinceSistemas.My.Resources.Resources.AvancarNavegador
        Me.BtnAvancar.Location = New System.Drawing.Point(54, 3)
        Me.BtnAvancar.Name = "BtnAvancar"
        Me.BtnAvancar.Size = New System.Drawing.Size(32, 30)
        Me.BtnAvancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAvancar.TabIndex = 2
        Me.BtnAvancar.TabStop = False
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAtualizar.Image = Global.PrinceSistemas.My.Resources.Resources.atualizar_azu
        Me.BtnAtualizar.Location = New System.Drawing.Point(97, 3)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(32, 30)
        Me.BtnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAtualizar.TabIndex = 3
        Me.BtnAtualizar.TabStop = False
        '
        'BtnHome
        '
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.Image = Global.PrinceSistemas.My.Resources.Resources.home
        Me.BtnHome.Location = New System.Drawing.Point(141, 3)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(32, 30)
        Me.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnHome.TabIndex = 4
        Me.BtnHome.TabStop = False
        '
        'SITETextBox
        '
        Me.SITETextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SITETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SITETextBox.Location = New System.Drawing.Point(181, 3)
        Me.SITETextBox.Name = "SITETextBox"
        Me.SITETextBox.Size = New System.Drawing.Size(515, 26)
        Me.SITETextBox.TabIndex = 5
        '
        'BtnParar
        '
        Me.BtnParar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnParar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnParar.Image = Global.PrinceSistemas.My.Resources.Resources.Fechar_Icone
        Me.BtnParar.Location = New System.Drawing.Point(742, 3)
        Me.BtnParar.Name = "BtnParar"
        Me.BtnParar.Size = New System.Drawing.Size(32, 30)
        Me.BtnParar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnParar.TabIndex = 6
        Me.BtnParar.TabStop = False
        '
        'BtnSoltar
        '
        Me.BtnSoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSoltar.Image = Global.PrinceSistemas.My.Resources.Resources.expandirpagina
        Me.BtnSoltar.Location = New System.Drawing.Point(783, 3)
        Me.BtnSoltar.Name = "BtnSoltar"
        Me.BtnSoltar.Size = New System.Drawing.Size(32, 30)
        Me.BtnSoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSoltar.TabIndex = 7
        Me.BtnSoltar.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.TxtCarregamento})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 583)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(818, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 22)
        '
        'TxtCarregamento
        '
        Me.TxtCarregamento.Name = "TxtCarregamento"
        Me.TxtCarregamento.Size = New System.Drawing.Size(19, 22)
        Me.TxtCarregamento.Text = "..."
        '
        'FrmExtraiCNPJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(818, 608)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmExtraiCNPJ"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extrair CNPJ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.WebSite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxAguarde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.BtnIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAvancar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnParar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSoltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnExportar As Button
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabelImportar As LinkLabel
    Friend WithEvents BtnFechar As PictureBox
    Friend WithEvents BtnAbrirExterno As Button
    Friend WithEvents BtnAbrirInterno As Button
    Friend WithEvents BtnImportarAlternativo As Button
    Friend WithEvents PictureBoxAguarde As PictureBox
    Friend WithEvents LinkCadastro As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnIR As PictureBox
    Friend WithEvents BtnVoltar As PictureBox
    Friend WithEvents BtnAvancar As PictureBox
    Friend WithEvents BtnAtualizar As PictureBox
    Friend WithEvents BtnHome As PictureBox
    Friend WithEvents SITETextBox As TextBox
    Friend WithEvents BtnSoltar As PictureBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents TxtCarregamento As ToolStripLabel
    Friend WithEvents BtnParar As PictureBox
    Friend WithEvents WebSite As Microsoft.Web.WebView2.WinForms.WebView2
End Class
