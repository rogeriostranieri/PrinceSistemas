﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNAE
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
        Me.RichTextBoxCNAEBusca = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxCNAEresultado = New System.Windows.Forms.RichTextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnTodosCNAE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxCNAEBusca
        '
        Me.RichTextBoxCNAEBusca.Location = New System.Drawing.Point(12, 26)
        Me.RichTextBoxCNAEBusca.Name = "RichTextBoxCNAEBusca"
        Me.RichTextBoxCNAEBusca.Size = New System.Drawing.Size(116, 161)
        Me.RichTextBoxCNAEBusca.TabIndex = 0
        Me.RichTextBoxCNAEBusca.Text = ""
        '
        'RichTextBoxCNAEresultado
        '
        Me.RichTextBoxCNAEresultado.Location = New System.Drawing.Point(134, 26)
        Me.RichTextBoxCNAEresultado.Name = "RichTextBoxCNAEresultado"
        Me.RichTextBoxCNAEresultado.Size = New System.Drawing.Size(781, 161)
        Me.RichTextBoxCNAEresultado.TabIndex = 1
        Me.RichTextBoxCNAEresultado.Text = ""
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(134, 193)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(134, 36)
        Me.BtnConsultar.TabIndex = 2
        Me.BtnConsultar.Text = "Buscar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CNAEs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*Até momento apenas Grau de Risco para CNAE na prefeitura de Maringá-PR"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(850, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnTodosCNAE
        '
        Me.BtnTodosCNAE.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnTodosCNAE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTodosCNAE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTodosCNAE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTodosCNAE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTodosCNAE.Location = New System.Drawing.Point(12, 193)
        Me.BtnTodosCNAE.Name = "BtnTodosCNAE"
        Me.BtnTodosCNAE.Size = New System.Drawing.Size(116, 36)
        Me.BtnTodosCNAE.TabIndex = 7
        Me.BtnTodosCNAE.Text = "Todos"
        Me.BtnTodosCNAE.UseVisualStyleBackColor = True
        '
        'FrmCNAE
        '
        Me.AcceptButton = Me.BtnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 237)
        Me.Controls.Add(Me.BtnTodosCNAE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.RichTextBoxCNAEresultado)
        Me.Controls.Add(Me.RichTextBoxCNAEBusca)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCNAE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNAE - Grau de Risco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBoxCNAEBusca As RichTextBox
    Friend WithEvents RichTextBoxCNAEresultado As RichTextBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnTodosCNAE As Button
End Class