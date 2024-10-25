<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoxJuntaComercial
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
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnInterno = New System.Windows.Forms.Button()
        Me.BtnExterno = New System.Windows.Forms.Button()
        Me.BtnCopiaPRP = New System.Windows.Forms.Button()
        Me.ComboBoxEscolhaProtocolo = New System.Windows.Forms.ComboBox()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(317, 204)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'BtnImportar
        '
        Me.BtnImportar.BackColor = System.Drawing.Color.Transparent
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.Location = New System.Drawing.Point(349, 59)
        Me.BtnImportar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(156, 62)
        Me.BtnImportar.TabIndex = 15
        Me.BtnImportar.Text = "Importar Dados"
        Me.BtnImportar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Deseja abrir a Junta Comercial / Empresa Fácil..."
        '
        'BtnInterno
        '
        Me.BtnInterno.BackColor = System.Drawing.Color.Transparent
        Me.BtnInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInterno.Location = New System.Drawing.Point(185, 59)
        Me.BtnInterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInterno.Name = "BtnInterno"
        Me.BtnInterno.Size = New System.Drawing.Size(156, 62)
        Me.BtnInterno.TabIndex = 13
        Me.BtnInterno.Text = "Abrir Interno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnInterno.UseVisualStyleBackColor = False
        '
        'BtnExterno
        '
        Me.BtnExterno.BackColor = System.Drawing.Color.Transparent
        Me.BtnExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExterno.Location = New System.Drawing.Point(21, 59)
        Me.BtnExterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExterno.Name = "BtnExterno"
        Me.BtnExterno.Size = New System.Drawing.Size(156, 62)
        Me.BtnExterno.TabIndex = 12
        Me.BtnExterno.Text = "Abrir Externo"
        Me.BtnExterno.UseVisualStyleBackColor = False
        '
        'BtnCopiaPRP
        '
        Me.BtnCopiaPRP.BackColor = System.Drawing.Color.Lavender
        Me.BtnCopiaPRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiaPRP.Location = New System.Drawing.Point(185, 155)
        Me.BtnCopiaPRP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCopiaPRP.Name = "BtnCopiaPRP"
        Me.BtnCopiaPRP.Size = New System.Drawing.Size(156, 34)
        Me.BtnCopiaPRP.TabIndex = 16
        Me.BtnCopiaPRP.Text = "Copiar Protocolo"
        Me.BtnCopiaPRP.UseVisualStyleBackColor = False
        '
        'ComboBoxEscolhaProtocolo
        '
        Me.ComboBoxEscolhaProtocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEscolhaProtocolo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxEscolhaProtocolo.FormattingEnabled = True
        Me.ComboBoxEscolhaProtocolo.Location = New System.Drawing.Point(21, 161)
        Me.ComboBoxEscolhaProtocolo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxEscolhaProtocolo.Name = "ComboBoxEscolhaProtocolo"
        Me.ComboBoxEscolhaProtocolo.Size = New System.Drawing.Size(155, 24)
        Me.ComboBoxEscolhaProtocolo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Copiar Numero do Protocolo"
        '
        'BoxJuntaComercial
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(528, 255)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxEscolhaProtocolo)
        Me.Controls.Add(Me.BtnCopiaPRP)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnInterno)
        Me.Controls.Add(Me.BtnExterno)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BoxJuntaComercial"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Box Empresa Fácil"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BtnImportar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInterno As Button
    Friend WithEvents BtnExterno As Button
    Friend WithEvents BtnCopiaPRP As Button
    Friend WithEvents ComboBoxEscolhaProtocolo As ComboBox
    Friend WithEvents Label2 As Label
End Class
