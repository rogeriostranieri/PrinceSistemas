<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTeste
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtTest = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.MyDTP = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtTest
        '
        Me.TxtTest.Location = New System.Drawing.Point(331, 107)
        Me.TxtTest.Name = "TxtTest"
        Me.TxtTest.Size = New System.Drawing.Size(100, 20)
        Me.TxtTest.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(322, 155)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 20)
        Me.Txt2.TabIndex = 2
        '
        'MyDTP
        '
        Me.MyDTP.Location = New System.Drawing.Point(315, 248)
        Me.MyDTP.Name = "MyDTP"
        Me.MyDTP.Size = New System.Drawing.Size(200, 20)
        Me.MyDTP.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(586, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 4
        '
        'FrmTeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MyDTP)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.TxtTest)
        Me.Name = "FrmTeste"
        Me.Text = "FrmTeste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTest As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents MyDTP As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
End Class
