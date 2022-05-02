<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaAnotacoes
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnBuscaSub = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSubstituir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLimpaSub = New System.Windows.Forms.Button()
        Me.TextBoxLocalizaSub = New System.Windows.Forms.TextBox()
        Me.ButtonSubstituir = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLimparSelecao = New System.Windows.Forms.Button()
        Me.TextBoxLocalizar = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(422, 187)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(175, 43)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Localizar Todos"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnBuscaSub)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBoxSubstituir)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.BtnLimpaSub)
        Me.TabPage2.Controls.Add(Me.TextBoxLocalizaSub)
        Me.TabPage2.Controls.Add(Me.ButtonSubstituir)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(612, 254)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Substituir"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnBuscaSub
        '
        Me.BtnBuscaSub.Location = New System.Drawing.Point(60, 187)
        Me.BtnBuscaSub.Name = "BtnBuscaSub"
        Me.BtnBuscaSub.Size = New System.Drawing.Size(175, 43)
        Me.BtnBuscaSub.TabIndex = 10
        Me.BtnBuscaSub.Text = "Localizar Todos"
        Me.BtnBuscaSub.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Substituir:"
        '
        'TextBoxSubstituir
        '
        Me.TextBoxSubstituir.Location = New System.Drawing.Point(103, 99)
        Me.TextBoxSubstituir.Name = "TextBoxSubstituir"
        Me.TextBoxSubstituir.Size = New System.Drawing.Size(403, 24)
        Me.TextBoxSubstituir.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Localizar:"
        '
        'BtnLimpaSub
        '
        Me.BtnLimpaSub.Location = New System.Drawing.Point(241, 187)
        Me.BtnLimpaSub.Name = "BtnLimpaSub"
        Me.BtnLimpaSub.Size = New System.Drawing.Size(175, 43)
        Me.BtnLimpaSub.TabIndex = 6
        Me.BtnLimpaSub.Text = "Limpar Seleção"
        Me.BtnLimpaSub.UseVisualStyleBackColor = True
        '
        'TextBoxLocalizaSub
        '
        Me.TextBoxLocalizaSub.Location = New System.Drawing.Point(103, 43)
        Me.TextBoxLocalizaSub.Name = "TextBoxLocalizaSub"
        Me.TextBoxLocalizaSub.Size = New System.Drawing.Size(403, 24)
        Me.TextBoxLocalizaSub.TabIndex = 5
        '
        'ButtonSubstituir
        '
        Me.ButtonSubstituir.Location = New System.Drawing.Point(422, 187)
        Me.ButtonSubstituir.Name = "ButtonSubstituir"
        Me.ButtonSubstituir.Size = New System.Drawing.Size(175, 43)
        Me.ButtonSubstituir.TabIndex = 4
        Me.ButtonSubstituir.Text = "Substituir Todos"
        Me.ButtonSubstituir.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ButtonLimparSelecao)
        Me.TabPage1.Controls.Add(Me.TextBoxLocalizar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 254)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Localizar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Localizar:"
        '
        'ButtonLimparSelecao
        '
        Me.ButtonLimparSelecao.Location = New System.Drawing.Point(241, 187)
        Me.ButtonLimparSelecao.Name = "ButtonLimparSelecao"
        Me.ButtonLimparSelecao.Size = New System.Drawing.Size(175, 43)
        Me.ButtonLimparSelecao.TabIndex = 2
        Me.ButtonLimparSelecao.Text = "Limpar Seleção"
        Me.ButtonLimparSelecao.UseVisualStyleBackColor = True
        '
        'TextBoxLocalizar
        '
        Me.TextBoxLocalizar.Location = New System.Drawing.Point(103, 43)
        Me.TextBoxLocalizar.Name = "TextBoxLocalizar"
        Me.TextBoxLocalizar.Size = New System.Drawing.Size(403, 24)
        Me.TextBoxLocalizar.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 285)
        Me.TabControl1.TabIndex = 1
        '
        'FrmBuscaAnotacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 307)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscaAnotacoes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TextBoxLocalizar As TextBox
    Friend WithEvents ButtonLimparSelecao As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimpaSub As Button
    Friend WithEvents TextBoxLocalizaSub As TextBox
    Friend WithEvents ButtonSubstituir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSubstituir As TextBox
    Friend WithEvents BtnBuscaSub As Button
End Class
