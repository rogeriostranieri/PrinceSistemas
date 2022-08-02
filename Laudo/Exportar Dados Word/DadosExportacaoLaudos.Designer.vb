<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DadosExportacaoLaudos
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.14286!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.51163!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.48837!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(450, 444)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 49)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dados:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 108)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(444, 264)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "@RazaoSocial" & Global.Microsoft.VisualBasic.ChrW(10) & "@CNPJ" & Global.Microsoft.VisualBasic.ChrW(10) & "@Endereco" & Global.Microsoft.VisualBasic.ChrW(10) & "@Complemento" & Global.Microsoft.VisualBasic.ChrW(10) & "@EndNum" & Global.Microsoft.VisualBasic.ChrW(10) & "@EndData" & Global.Microsoft.VisualBasic.ChrW(10) & "@EndQuadra" & Global.Microsoft.VisualBasic.ChrW(10) & "@EndZona" & Global.Microsoft.VisualBasic.ChrW(10) & "@E" &
    "ndCEP" & Global.Microsoft.VisualBasic.ChrW(10) & "@RamodeatividadeRich" & Global.Microsoft.VisualBasic.ChrW(10) & "@Requerente" & Global.Microsoft.VisualBasic.ChrW(10) & "@CPFRequerente" & Global.Microsoft.VisualBasic.ChrW(10) & "@EndRequerente" & Global.Microsoft.VisualBasic.ChrW(10) & "@Dia" & Global.Microsoft.VisualBasic.ChrW(10) & "@Mes" & Global.Microsoft.VisualBasic.ChrW(10) & "@" &
    "Ano"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 378)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(444, 63)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(216, 57)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(225, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(216, 57)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'DadosExportacaoLaudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 444)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DadosExportacaoLaudos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DadosExportacaoLaudos"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
