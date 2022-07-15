<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaCNPJImportar
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnHTML = New System.Windows.Forms.Button()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.txtHTML = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 68)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "32936721000102"
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(236, 12)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(346, 20)
        Me.txtURL.TabIndex = 3
        '
        'btnHTML
        '
        Me.btnHTML.Location = New System.Drawing.Point(92, 53)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(102, 68)
        Me.btnHTML.TabIndex = 4
        Me.btnHTML.Text = "btnHTML"
        Me.btnHTML.UseVisualStyleBackColor = True
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(21, 211)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(767, 369)
        Me.WebView21.TabIndex = 6
        Me.WebView21.ZoomFactor = 1.0R
        '
        'txtHTML
        '
        Me.txtHTML.Location = New System.Drawing.Point(236, 37)
        Me.txtHTML.Name = "txtHTML"
        Me.txtHTML.Size = New System.Drawing.Size(498, 159)
        Me.txtHTML.TabIndex = 7
        Me.txtHTML.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 68)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmConsultaCNPJImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 592)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtHTML)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.btnHTML)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmConsultaCNPJImportar"
        Me.Text = "FrmConsultaCNPJImportar"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnHTML As Button
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents txtHTML As RichTextBox
    Friend WithEvents Button2 As Button
End Class
