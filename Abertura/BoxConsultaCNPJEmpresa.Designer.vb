<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BoxConsultaCNPJEmpresa
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BtnExterno = New System.Windows.Forms.Button()
        Me.BtnInterno = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnImportarFederal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(168, 349)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'BtnExterno
        '
        Me.BtnExterno.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExterno.Location = New System.Drawing.Point(18, 72)
        Me.BtnExterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExterno.Name = "BtnExterno"
        Me.BtnExterno.Size = New System.Drawing.Size(176, 77)
        Me.BtnExterno.TabIndex = 1
        Me.BtnExterno.Text = "Abrir Externo"
        Me.BtnExterno.UseVisualStyleBackColor = False
        '
        'BtnInterno
        '
        Me.BtnInterno.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInterno.Location = New System.Drawing.Point(202, 72)
        Me.BtnInterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnInterno.Name = "BtnInterno"
        Me.BtnInterno.Size = New System.Drawing.Size(176, 77)
        Me.BtnInterno.TabIndex = 2
        Me.BtnInterno.Text = "Abrir Interno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnInterno.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Deseja abrir a consulta CNPJ..."
        '
        'BtnImportar
        '
        Me.BtnImportar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.Location = New System.Drawing.Point(18, 224)
        Me.BtnImportar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(176, 77)
        Me.BtnImportar.TabIndex = 4
        Me.BtnImportar.Text = "Importar Dados Completo"
        Me.BtnImportar.UseVisualStyleBackColor = False
        '
        'BtnImportarFederal
        '
        Me.BtnImportarFederal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnImportarFederal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportarFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportarFederal.Location = New System.Drawing.Point(202, 224)
        Me.BtnImportarFederal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnImportarFederal.Name = "BtnImportarFederal"
        Me.BtnImportarFederal.Size = New System.Drawing.Size(176, 77)
        Me.BtnImportarFederal.TabIndex = 8
        Me.BtnImportarFederal.Text = "Abrir"
        Me.BtnImportarFederal.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Deseja abrir a importar CNPJ..."
        '
        'BoxConsultaCNPJEmpresa
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(405, 412)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnImportarFederal)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnInterno)
        Me.Controls.Add(Me.BtnExterno)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BoxConsultaCNPJEmpresa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta CNPJ - Prince Sistemas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BtnExterno As Button
    Friend WithEvents BtnInterno As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnImportar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnImportarFederal As Button
    Friend WithEvents Label2 As Label
End Class
