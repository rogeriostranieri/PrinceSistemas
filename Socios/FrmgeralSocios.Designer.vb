<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSociosGERAL
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAtualizar = New System.Windows.Forms.PictureBox()
        Me.ListViewGeral = New System.Windows.Forms.ListView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 567)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Label2"
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.atualizar_azu
        Me.BtnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtualizar.Location = New System.Drawing.Point(10, 562)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(24, 23)
        Me.BtnAtualizar.TabIndex = 25
        Me.BtnAtualizar.TabStop = False
        '
        'ListViewGeral
        '
        Me.ListViewGeral.HideSelection = False
        Me.ListViewGeral.Location = New System.Drawing.Point(10, 95)
        Me.ListViewGeral.Name = "ListViewGeral"
        Me.ListViewGeral.Size = New System.Drawing.Size(472, 464)
        Me.ListViewGeral.TabIndex = 24
        Me.ListViewGeral.UseCompatibleStateImageBehavior = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(356, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Todos Sócios"
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusca.Location = New System.Drawing.Point(10, 58)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(472, 31)
        Me.TextBoxBusca.TabIndex = 20
        '
        'FrmSociosGERAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(500, 590)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAtualizar)
        Me.Controls.Add(Me.ListViewGeral)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBusca)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSociosGERAL"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geral Sócios"
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAtualizar As PictureBox
    Friend WithEvents ListViewGeral As ListView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusca As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
