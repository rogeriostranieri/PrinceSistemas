<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaCNAE
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
        Me.LinkLabelEditor = New System.Windows.Forms.LinkLabel()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListViewCNAEs = New System.Windows.Forms.ListView()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabelEditor
        '
        Me.LinkLabelEditor.AutoSize = True
        Me.LinkLabelEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelEditor.Location = New System.Drawing.Point(378, 566)
        Me.LinkLabelEditor.Name = "LinkLabelEditor"
        Me.LinkLabelEditor.Size = New System.Drawing.Size(103, 18)
        Me.LinkLabelEditor.TabIndex = 21
        Me.LinkLabelEditor.TabStop = True
        Me.LinkLabelEditor.Text = "Ir para o editor"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnClose.Location = New System.Drawing.Point(355, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(134, 60)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnClose.TabIndex = 20
        Me.BtnClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Todos CNAE"
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusca.Location = New System.Drawing.Point(9, 64)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(472, 31)
        Me.TextBoxBusca.TabIndex = 17
        '
        'ListViewCNAEs
        '
        Me.ListViewCNAEs.HideSelection = False
        Me.ListViewCNAEs.Location = New System.Drawing.Point(9, 101)
        Me.ListViewCNAEs.Name = "ListViewCNAEs"
        Me.ListViewCNAEs.Size = New System.Drawing.Size(472, 464)
        Me.ListViewCNAEs.TabIndex = 22
        Me.ListViewCNAEs.UseCompatibleStateImageBehavior = False
        '
        'FrmBuscaCNAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(490, 593)
        Me.Controls.Add(Me.ListViewCNAEs)
        Me.Controls.Add(Me.LinkLabelEditor)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBusca)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscaCNAE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar CNAE"
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabelEditor As LinkLabel
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusca As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ListViewCNAEs As ListView
End Class
