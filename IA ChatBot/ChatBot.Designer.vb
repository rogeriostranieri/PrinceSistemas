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
        Me.TextBoxPergunta = New System.Windows.Forms.TextBox()
        Me.BtnProcurar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxResposta
        '
        Me.RichTextBoxResposta.Location = New System.Drawing.Point(5, 5)
        Me.RichTextBoxResposta.Margin = New System.Windows.Forms.Padding(5)
        Me.RichTextBoxResposta.Name = "RichTextBoxResposta"
        Me.RichTextBoxResposta.Size = New System.Drawing.Size(424, 155)
        Me.RichTextBoxResposta.TabIndex = 0
        Me.RichTextBoxResposta.Text = ""
        '
        'DataGridViewResultados
        '
        Me.DataGridViewResultados.AllowUserToAddRows = False
        Me.DataGridViewResultados.AllowUserToDeleteRows = False
        Me.DataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResultados.Location = New System.Drawing.Point(5, 170)
        Me.DataGridViewResultados.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridViewResultados.Name = "DataGridViewResultados"
        Me.DataGridViewResultados.ReadOnly = True
        Me.DataGridViewResultados.Size = New System.Drawing.Size(419, 137)
        Me.DataGridViewResultados.TabIndex = 1
        '
        'TextBoxPergunta
        '
        Me.TextBoxPergunta.Location = New System.Drawing.Point(5, 317)
        Me.TextBoxPergunta.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxPergunta.Name = "TextBoxPergunta"
        Me.TextBoxPergunta.Size = New System.Drawing.Size(424, 26)
        Me.TextBoxPergunta.TabIndex = 2
        '
        'BtnProcurar
        '
        Me.BtnProcurar.Location = New System.Drawing.Point(508, 317)
        Me.BtnProcurar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnProcurar.Name = "BtnProcurar"
        Me.BtnProcurar.Size = New System.Drawing.Size(152, 80)
        Me.BtnProcurar.TabIndex = 3
        Me.BtnProcurar.Text = "Button1"
        Me.BtnProcurar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFechar.Location = New System.Drawing.Point(508, 5)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(152, 43)
        Me.BtnFechar.TabIndex = 4
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.6391!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.3609!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnProcurar, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnFechar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPergunta, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxResposta, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewResultados, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(665, 490)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'ChatBot
        '
        Me.AcceptButton = Me.BtnProcurar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.BtnFechar
        Me.ClientSize = New System.Drawing.Size(665, 490)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ChatBot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatBot"
        CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxResposta As RichTextBox
    Friend WithEvents DataGridViewResultados As DataGridView
    Friend WithEvents TextBoxPergunta As TextBox
    Friend WithEvents BtnProcurar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
