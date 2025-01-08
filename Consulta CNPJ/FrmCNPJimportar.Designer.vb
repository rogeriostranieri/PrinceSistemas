<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNPJimportar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnImportarFederal = New System.Windows.Forms.Button()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnInterno = New System.Windows.Forms.Button()
        Me.BtnExterno = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCadEmpresa = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 27)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Deseja abrir a importar CNPJ..."
        '
        'BtnImportarFederal
        '
        Me.BtnImportarFederal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnImportarFederal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportarFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportarFederal.Location = New System.Drawing.Point(200, 201)
        Me.BtnImportarFederal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnImportarFederal.Name = "BtnImportarFederal"
        Me.BtnImportarFederal.Size = New System.Drawing.Size(176, 77)
        Me.BtnImportarFederal.TabIndex = 15
        Me.BtnImportarFederal.Text = "Importar Dados FEDERAL"
        Me.BtnImportarFederal.UseVisualStyleBackColor = False
        '
        'BtnImportar
        '
        Me.BtnImportar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.Location = New System.Drawing.Point(16, 201)
        Me.BtnImportar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(176, 77)
        Me.BtnImportar.TabIndex = 14
        Me.BtnImportar.Text = "Importar Dados Completo"
        Me.BtnImportar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Deseja abrir a consulta CNPJ..."
        '
        'BtnInterno
        '
        Me.BtnInterno.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInterno.Location = New System.Drawing.Point(200, 49)
        Me.BtnInterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnInterno.Name = "BtnInterno"
        Me.BtnInterno.Size = New System.Drawing.Size(176, 77)
        Me.BtnInterno.TabIndex = 12
        Me.BtnInterno.Text = "Abrir Interno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnInterno.UseVisualStyleBackColor = False
        '
        'BtnExterno
        '
        Me.BtnExterno.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExterno.Location = New System.Drawing.Point(16, 49)
        Me.BtnExterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExterno.Name = "BtnExterno"
        Me.BtnExterno.Size = New System.Drawing.Size(176, 77)
        Me.BtnExterno.TabIndex = 11
        Me.BtnExterno.Text = "Abrir Externo"
        Me.BtnExterno.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(173, 456)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 319)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 27)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Deseja Cadastrar Empresa?"
        '
        'ButtonCadEmpresa
        '
        Me.ButtonCadEmpresa.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonCadEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCadEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCadEmpresa.Location = New System.Drawing.Point(16, 351)
        Me.ButtonCadEmpresa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonCadEmpresa.Name = "ButtonCadEmpresa"
        Me.ButtonCadEmpresa.Size = New System.Drawing.Size(176, 77)
        Me.ButtonCadEmpresa.TabIndex = 17
        Me.ButtonCadEmpresa.Text = "Cadastrar Empresa"
        Me.ButtonCadEmpresa.UseVisualStyleBackColor = False
        '
        'FrmCNPJimportar
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(395, 503)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonCadEmpresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnImportarFederal)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnInterno)
        Me.Controls.Add(Me.BtnExterno)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCNPJimportar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importação Geral CNPJ"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnImportarFederal As Button
    Friend WithEvents BtnImportar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInterno As Button
    Friend WithEvents BtnExterno As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonCadEmpresa As Button
End Class
