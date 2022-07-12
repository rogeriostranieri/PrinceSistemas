<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportarContratoWordDialog
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
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BtnSocios = New System.Windows.Forms.Button()
        Me.BtnContrato = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.TextBoxCaminho = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDados = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAbrir, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(252, 253)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(283, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAbrir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAbrir.Location = New System.Drawing.Point(13, 3)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(67, 23)
        Me.BtnAbrir.TabIndex = 2
        Me.BtnAbrir.Text = "Abrir"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(107, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(202, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'BtnSocios
        '
        Me.BtnSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSocios.Location = New System.Drawing.Point(14, 31)
        Me.BtnSocios.Name = "BtnSocios"
        Me.BtnSocios.Size = New System.Drawing.Size(87, 30)
        Me.BtnSocios.TabIndex = 1
        Me.BtnSocios.Text = "Sócios"
        Me.BtnSocios.UseVisualStyleBackColor = True
        '
        'BtnContrato
        '
        Me.BtnContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContrato.Location = New System.Drawing.Point(103, 31)
        Me.BtnContrato.Name = "BtnContrato"
        Me.BtnContrato.Size = New System.Drawing.Size(98, 30)
        Me.BtnContrato.TabIndex = 2
        Me.BtnContrato.Text = "Contrato"
        Me.BtnContrato.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Arquivo:"
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.Location = New System.Drawing.Point(453, 73)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(87, 30)
        Me.BtnAdicionar.TabIndex = 5
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'TextBoxCaminho
        '
        Me.TextBoxCaminho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCaminho.Location = New System.Drawing.Point(85, 77)
        Me.TextBoxCaminho.Name = "TextBoxCaminho"
        Me.TextBoxCaminho.Size = New System.Drawing.Size(362, 22)
        Me.TextBoxCaminho.TabIndex = 6
        Me.TextBoxCaminho.Text = "Clique em ""ADICIONAR"" para escolher o contrato social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Exportação de Contrato Social"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDados)
        Me.GroupBox1.Controls.Add(Me.BtnContrato)
        Me.GroupBox1.Controls.Add(Me.BtnSocios)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 76)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exportação"
        '
        'BtnDados
        '
        Me.BtnDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDados.Location = New System.Drawing.Point(207, 31)
        Me.BtnDados.Name = "BtnDados"
        Me.BtnDados.Size = New System.Drawing.Size(98, 30)
        Me.BtnDados.TabIndex = 3
        Me.BtnDados.Text = "Dados..."
        Me.BtnDados.UseVisualStyleBackColor = True
        '
        'ExportarContratoWordDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(547, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCaminho)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExportarContratoWordDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExportarContratoWordDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BtnSocios As Button
    Friend WithEvents BtnContrato As Button
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TextBoxCaminho As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDados As Button
End Class
