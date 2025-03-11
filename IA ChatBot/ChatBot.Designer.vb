<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatBot
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
        Me.RichTextBoxResposta = New System.Windows.Forms.RichTextBox()
        Me.DataGridViewResultados = New System.Windows.Forms.DataGridView()
        Me.BtnProcurar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRecomecar = New System.Windows.Forms.Button()
        Me.TextBoxPergunta = New System.Windows.Forms.RichTextBox()
        CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxResposta
        '
        Me.RichTextBoxResposta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxResposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxResposta.Location = New System.Drawing.Point(5, 52)
        Me.RichTextBoxResposta.Margin = New System.Windows.Forms.Padding(5)
        Me.RichTextBoxResposta.Name = "RichTextBoxResposta"
        Me.RichTextBoxResposta.ReadOnly = True
        Me.RichTextBoxResposta.Size = New System.Drawing.Size(743, 323)
        Me.RichTextBoxResposta.TabIndex = 0
        Me.RichTextBoxResposta.Text = ""
        '
        'DataGridViewResultados
        '
        Me.DataGridViewResultados.AllowUserToAddRows = False
        Me.DataGridViewResultados.AllowUserToDeleteRows = False
        Me.DataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewResultados.Location = New System.Drawing.Point(5, 385)
        Me.DataGridViewResultados.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridViewResultados.Name = "DataGridViewResultados"
        Me.DataGridViewResultados.ReadOnly = True
        Me.DataGridViewResultados.Size = New System.Drawing.Size(743, 107)
        Me.DataGridViewResultados.TabIndex = 1
        '
        'BtnProcurar
        '
        Me.BtnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcurar.Location = New System.Drawing.Point(758, 502)
        Me.BtnProcurar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnProcurar.Name = "BtnProcurar"
        Me.BtnProcurar.Size = New System.Drawing.Size(151, 73)
        Me.BtnProcurar.TabIndex = 3
        Me.BtnProcurar.Text = "Perguntar"
        Me.BtnProcurar.UseVisualStyleBackColor = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo5
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.ForeColor = System.Drawing.Color.Black
        Me.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnFechar.Location = New System.Drawing.Point(758, 5)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(151, 37)
        Me.BtnFechar.TabIndex = 4
        Me.BtnFechar.Text = "FECHAR"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.38512!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.61488!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnFechar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnProcurar, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxResposta, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewResultados, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnRecomecar, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPergunta, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(914, 599)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'BtnRecomecar
        '
        Me.BtnRecomecar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRecomecar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecomecar.Location = New System.Drawing.Point(758, 52)
        Me.BtnRecomecar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnRecomecar.Name = "BtnRecomecar"
        Me.BtnRecomecar.Size = New System.Drawing.Size(151, 83)
        Me.BtnRecomecar.TabIndex = 5
        Me.BtnRecomecar.Text = "Recomeçar"
        Me.BtnRecomecar.UseVisualStyleBackColor = False
        '
        'TextBoxPergunta
        '
        Me.TextBoxPergunta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPergunta.Location = New System.Drawing.Point(3, 500)
        Me.TextBoxPergunta.Name = "TextBoxPergunta"
        Me.TextBoxPergunta.Size = New System.Drawing.Size(747, 96)
        Me.TextBoxPergunta.TabIndex = 6
        Me.TextBoxPergunta.Text = ""
        '
        'ChatBot
        '
        Me.AcceptButton = Me.BtnProcurar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.background_vermelho_e_preto_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnFechar
        Me.ClientSize = New System.Drawing.Size(914, 599)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChatBot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrinceBot"
        CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxResposta As RichTextBox
    Friend WithEvents DataGridViewResultados As DataGridView
    Friend WithEvents BtnProcurar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnRecomecar As Button
    Friend WithEvents TextBoxPergunta As RichTextBox
End Class
