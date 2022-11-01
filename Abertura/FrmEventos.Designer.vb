<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEventos
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
        Dim EventosLabel As System.Windows.Forms.Label
        Me.CheckedListBoxEventosJunta = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEventos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFechar = New System.Windows.Forms.PictureBox()
        EventosLabel = New System.Windows.Forms.Label()
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventosLabel
        '
        EventosLabel.AutoSize = True
        EventosLabel.BackColor = System.Drawing.Color.Transparent
        EventosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EventosLabel.Location = New System.Drawing.Point(12, 135)
        EventosLabel.Name = "EventosLabel"
        EventosLabel.Size = New System.Drawing.Size(69, 13)
        EventosLabel.TabIndex = 2
        EventosLabel.Text = "EVENTOS:"
        '
        'CheckedListBoxEventosJunta
        '
        Me.CheckedListBoxEventosJunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxEventosJunta.FormattingEnabled = True
        Me.CheckedListBoxEventosJunta.Items.AddRange(New Object() {"=======JUNTA COMERCIAL=======", "Abertura Matriz", "Baixa Matriz", "", "Abertura de Filial", "Alteração de Filial", "Baixa de Filial", "", "Alteração da forma de atuação", "Alteração da natureza jurídica", "Alteração de atividades econômicas (principal e secundárias)", "Alteração de capital social e/ou Quadro Societário", "Alteração de Cláusulas Particulares", "Alteração de dados do Empresário", "Alteração de endereço entre estados", "Alteração de endereço entre municípios no mesmo estado", "Alteração de endereço no mesmo município", "Alteração de nome empresarial (firma ou denominação)", "Alteração de Proteção de Nome Empresarial", "Alteração do tipo de unidade", "Alteração da pessoa física responsável perante o CNPJ", "Cancelamento de Proteção de Nome Empresarial", "Consolidação", "Emancipação", "Enquadramento / Reenquadramento / Desenquadramento de Porte de Empresa", "Espólio", "Interrupção temporária de atividades", "Procuração", "Proteção de Nome Empresarial", "Reinício das atividades interrompidas temporariamente", "Rerratificação", "Restabelecimento de filial", "Restabelecimento de matriz (Reativação)", "Revogação de Procuração", "", "=======RECEITA FEDERAL=======", "Abertura apenas na Receita Federal", "Alteração apenas na Receita Federal", "Baixa apenas na Receita Federal", "Alteração da pessoa fisica responsável perante o CNPJ", "", "", "=======RECEITA ESTADUAL=======", "Nova Inscrição Estadual", "Alteração Cadastral da Inscrição Estadual", "Baixa da Inscrição Estadual", "Reativação da Inscrição Estadual", "Inscrição Estadual Auxiliar – Subst. Trib. ", "Inscrição de estabelecimento localizado em outro Estado", "Inscrição de estabelecimento localizado em outro Estado, exceto Substituto Tribut" &
                "ário "})
        Me.CheckedListBoxEventosJunta.Location = New System.Drawing.Point(15, 156)
        Me.CheckedListBoxEventosJunta.Name = "CheckedListBoxEventosJunta"
        Me.CheckedListBoxEventosJunta.Size = New System.Drawing.Size(532, 293)
        Me.CheckedListBoxEventosJunta.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LISTA DE EVENTOS"
        '
        'BtnEventos
        '
        Me.BtnEventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEventos.ForeColor = System.Drawing.Color.Green
        Me.BtnEventos.Location = New System.Drawing.Point(454, 455)
        Me.BtnEventos.Name = "BtnEventos"
        Me.BtnEventos.Size = New System.Drawing.Size(93, 30)
        Me.BtnEventos.TabIndex = 5
        Me.BtnEventos.Text = "Adicionar"
        Me.BtnEventos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(382, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Limpar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(532, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Localizar:"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.Transparent
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.BtnFechar.Location = New System.Drawing.Point(413, -2)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(134, 60)
        Me.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFechar.TabIndex = 15
        Me.BtnFechar.TabStop = False
        '
        'FrmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(566, 492)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnEventos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBoxEventosJunta)
        Me.Controls.Add(EventosLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEventos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Eventos"
        CType(Me.BtnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBoxEventosJunta As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEventos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFechar As PictureBox
End Class
