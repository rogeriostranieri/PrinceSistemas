<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCNAEOficialEscolha
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
        Dim RamoDeAtividadeLabel As System.Windows.Forms.Label
        Dim CNAESecundarioLabel As System.Windows.Forms.Label
        Dim CNAEPrincipalLabel As System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CNAESecundarioRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.RamoDeAtividadeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CNAEPrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Adicionar_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TodosCNAERichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        RamoDeAtividadeLabel = New System.Windows.Forms.Label()
        CNAESecundarioLabel = New System.Windows.Forms.Label()
        CNAEPrincipalLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RamoDeAtividadeLabel
        '
        RamoDeAtividadeLabel.AutoSize = True
        RamoDeAtividadeLabel.BackColor = System.Drawing.Color.Transparent
        RamoDeAtividadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RamoDeAtividadeLabel.Location = New System.Drawing.Point(263, 246)
        RamoDeAtividadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RamoDeAtividadeLabel.Name = "RamoDeAtividadeLabel"
        RamoDeAtividadeLabel.Size = New System.Drawing.Size(156, 18)
        RamoDeAtividadeLabel.TabIndex = 43
        RamoDeAtividadeLabel.Text = "Ramo De Atividade:"
        '
        'CNAESecundarioLabel
        '
        CNAESecundarioLabel.AutoSize = True
        CNAESecundarioLabel.BackColor = System.Drawing.Color.Transparent
        CNAESecundarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNAESecundarioLabel.Location = New System.Drawing.Point(38, 300)
        CNAESecundarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNAESecundarioLabel.Name = "CNAESecundarioLabel"
        CNAESecundarioLabel.Size = New System.Drawing.Size(98, 18)
        CNAESecundarioLabel.TabIndex = 42
        CNAESecundarioLabel.Text = "Secundário:"
        '
        'CNAEPrincipalLabel
        '
        CNAEPrincipalLabel.AutoSize = True
        CNAEPrincipalLabel.BackColor = System.Drawing.Color.Transparent
        CNAEPrincipalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNAEPrincipalLabel.Location = New System.Drawing.Point(62, 267)
        CNAEPrincipalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNAEPrincipalLabel.Name = "CNAEPrincipalLabel"
        CNAEPrincipalLabel.Size = New System.Drawing.Size(78, 18)
        CNAEPrincipalLabel.TabIndex = 41
        CNAEPrincipalLabel.Text = "Principal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 222)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(232, 27)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Exemplo para Exportar:"
        '
        'CNAESecundarioRichTextBox
        '
        Me.CNAESecundarioRichTextBox.Location = New System.Drawing.Point(135, 300)
        Me.CNAESecundarioRichTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CNAESecundarioRichTextBox.Name = "CNAESecundarioRichTextBox"
        Me.CNAESecundarioRichTextBox.Size = New System.Drawing.Size(120, 173)
        Me.CNAESecundarioRichTextBox.TabIndex = 46
        Me.CNAESecundarioRichTextBox.Text = ""
        '
        'RamoDeAtividadeRichTextBox
        '
        Me.RamoDeAtividadeRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RamoDeAtividadeRichTextBox.Location = New System.Drawing.Point(263, 264)
        Me.RamoDeAtividadeRichTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RamoDeAtividadeRichTextBox.Name = "RamoDeAtividadeRichTextBox"
        Me.RamoDeAtividadeRichTextBox.Size = New System.Drawing.Size(366, 209)
        Me.RamoDeAtividadeRichTextBox.TabIndex = 44
        Me.RamoDeAtividadeRichTextBox.Text = ""
        '
        'CNAEPrincipalTextBox
        '
        Me.CNAEPrincipalTextBox.Location = New System.Drawing.Point(135, 264)
        Me.CNAEPrincipalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CNAEPrincipalTextBox.Name = "CNAEPrincipalTextBox"
        Me.CNAEPrincipalTextBox.Size = New System.Drawing.Size(120, 24)
        Me.CNAEPrincipalTextBox.TabIndex = 45
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Adicionar_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(469, 507)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(174, 34)
        Me.TableLayoutPanel1.TabIndex = 48
        '
        'Adicionar_Button
        '
        Me.Adicionar_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Adicionar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Adicionar_Button.Location = New System.Drawing.Point(3, 3)
        Me.Adicionar_Button.Name = "Adicionar_Button"
        Me.Adicionar_Button.Size = New System.Drawing.Size(81, 28)
        Me.Adicionar_Button.TabIndex = 0
        Me.Adicionar_Button.Text = "Adicionar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Location = New System.Drawing.Point(90, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(81, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TodosCNAERichTextBox
        '
        Me.TodosCNAERichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodosCNAERichTextBox.Location = New System.Drawing.Point(12, 12)
        Me.TodosCNAERichTextBox.Name = "TodosCNAERichTextBox"
        Me.TodosCNAERichTextBox.Size = New System.Drawing.Size(617, 127)
        Me.TodosCNAERichTextBox.TabIndex = 49
        Me.TodosCNAERichTextBox.Text = ""
        '
        'BtnMostrar
        '
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnMostrar.Location = New System.Drawing.Point(231, 145)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(177, 47)
        Me.BtnMostrar.TabIndex = 50
        Me.BtnMostrar.Text = "Mostrar como vai ficar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'FrmCNAEOficialEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 544)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.TodosCNAERichTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CNAESecundarioRichTextBox)
        Me.Controls.Add(RamoDeAtividadeLabel)
        Me.Controls.Add(Me.RamoDeAtividadeRichTextBox)
        Me.Controls.Add(Me.CNAEPrincipalTextBox)
        Me.Controls.Add(CNAESecundarioLabel)
        Me.Controls.Add(CNAEPrincipalLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCNAEOficialEscolha"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNAE FINAL"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents CNAESecundarioRichTextBox As RichTextBox
    Friend WithEvents RamoDeAtividadeRichTextBox As RichTextBox
    Friend WithEvents CNAEPrincipalTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Adicionar_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents TodosCNAERichTextBox As RichTextBox
    Friend WithEvents BtnMostrar As Button
End Class
