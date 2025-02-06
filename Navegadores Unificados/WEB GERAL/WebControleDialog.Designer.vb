<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebControleDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControleGeral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnPagInicialPadrao = New System.Windows.Forms.Button()
        Me.BtnPagInicialAtual = New System.Windows.Forms.Button()
        Me.TextBoxPaginaInicial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControleGeral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(334, 220)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.24596!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.96053!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.03947!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(557, 264)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TabControleGeral)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(549, 197)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opções gerais do Navegador Prince Sistemas"
        '
        'TabControleGeral
        '
        Me.TabControleGeral.Controls.Add(Me.TabPage1)
        Me.TabControleGeral.Controls.Add(Me.TabPage2)
        Me.TabControleGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControleGeral.Location = New System.Drawing.Point(4, 21)
        Me.TabControleGeral.Name = "TabControleGeral"
        Me.TabControleGeral.SelectedIndex = -1
        Me.TabControleGeral.Size = New System.Drawing.Size(541, 172)
        Me.TabControleGeral.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnPagInicialPadrao)
        Me.TabPage1.Controls.Add(Me.BtnPagInicialAtual)
        Me.TabPage1.Controls.Add(Me.TextBoxPaginaInicial)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(533, 141)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Geral"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnPagInicialPadrao
        '
        Me.BtnPagInicialPadrao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagInicialPadrao.Location = New System.Drawing.Point(220, 57)
        Me.BtnPagInicialPadrao.Name = "BtnPagInicialPadrao"
        Me.BtnPagInicialPadrao.Size = New System.Drawing.Size(105, 30)
        Me.BtnPagInicialPadrao.TabIndex = 3
        Me.BtnPagInicialPadrao.Text = "Usar Padrão"
        Me.BtnPagInicialPadrao.UseVisualStyleBackColor = True
        '
        'BtnPagInicialAtual
        '
        Me.BtnPagInicialAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagInicialAtual.Location = New System.Drawing.Point(109, 57)
        Me.BtnPagInicialAtual.Name = "BtnPagInicialAtual"
        Me.BtnPagInicialAtual.Size = New System.Drawing.Size(105, 30)
        Me.BtnPagInicialAtual.TabIndex = 2
        Me.BtnPagInicialAtual.Text = "Usar Atual"
        Me.BtnPagInicialAtual.UseVisualStyleBackColor = True
        '
        'TextBoxPaginaInicial
        '
        Me.TextBoxPaginaInicial.Location = New System.Drawing.Point(109, 27)
        Me.TextBoxPaginaInicial.Name = "TextBoxPaginaInicial"
        Me.TextBoxPaginaInicial.Size = New System.Drawing.Size(317, 24)
        Me.TextBoxPaginaInicial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Página Inicial:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckedListBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(533, 141)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Privacidade"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckedListBox
        '
        Me.CheckedListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Items.AddRange(New Object() {"Histórico de navegação", "Histórico de downloads", "Histórico de cookies", "Histórico de armazenamento de cache", "Histórico de senhas e privacidade", "Apagar tudo"})
        Me.CheckedListBox.Location = New System.Drawing.Point(3, 3)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckedListBox.Size = New System.Drawing.Size(527, 135)
        Me.CheckedListBox.TabIndex = 2
        '
        'WebControleDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(557, 264)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WebControleDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Histórico de Navegação"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControleGeral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents TabControleGeral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxPaginaInicial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPagInicialPadrao As Button
    Friend WithEvents BtnPagInicialAtual As Button
End Class
