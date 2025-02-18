<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscolha
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
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.BtnAlvara = New System.Windows.Forms.Button()
        Me.LabelCNPJ = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnParcelamentos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelRazaoSocial = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.BackColor = System.Drawing.Color.Azure
        Me.BtnEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnEmpresa.FlatAppearance.BorderSize = 3
        Me.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.Location = New System.Drawing.Point(153, 98)
        Me.BtnEmpresa.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(253, 70)
        Me.BtnEmpresa.TabIndex = 0
        Me.BtnEmpresa.Text = "Empresas"
        Me.BtnEmpresa.UseVisualStyleBackColor = False
        '
        'BtnAlvara
        '
        Me.BtnAlvara.BackColor = System.Drawing.Color.Azure
        Me.BtnAlvara.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnAlvara.FlatAppearance.BorderSize = 3
        Me.BtnAlvara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlvara.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAlvara.Location = New System.Drawing.Point(153, 180)
        Me.BtnAlvara.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnAlvara.Name = "BtnAlvara"
        Me.BtnAlvara.Size = New System.Drawing.Size(253, 70)
        Me.BtnAlvara.TabIndex = 1
        Me.BtnAlvara.Text = "Alvara"
        Me.BtnAlvara.UseVisualStyleBackColor = False
        '
        'LabelCNPJ
        '
        Me.LabelCNPJ.AutoSize = True
        Me.LabelCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCNPJ.Location = New System.Drawing.Point(153, 24)
        Me.LabelCNPJ.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelCNPJ.Name = "LabelCNPJ"
        Me.LabelCNPJ.Size = New System.Drawing.Size(20, 24)
        Me.LabelCNPJ.TabIndex = 2
        Me.LabelCNPJ.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(153, 344)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(153, 48)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(118, 24)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Copiar CNPJ"
        '
        'BtnParcelamentos
        '
        Me.BtnParcelamentos.BackColor = System.Drawing.Color.Azure
        Me.BtnParcelamentos.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnParcelamentos.FlatAppearance.BorderSize = 3
        Me.BtnParcelamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnParcelamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnParcelamentos.Location = New System.Drawing.Point(153, 262)
        Me.BtnParcelamentos.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnParcelamentos.Name = "BtnParcelamentos"
        Me.BtnParcelamentos.Size = New System.Drawing.Size(253, 70)
        Me.BtnParcelamentos.TabIndex = 18
        Me.BtnParcelamentos.Text = "Parcelamentos"
        Me.BtnParcelamentos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Razão Social ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "CNPJ ="
        '
        'LabelRazaoSocial
        '
        Me.LabelRazaoSocial.AutoSize = True
        Me.LabelRazaoSocial.Location = New System.Drawing.Point(153, 0)
        Me.LabelRazaoSocial.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelRazaoSocial.Name = "LabelRazaoSocial"
        Me.LabelRazaoSocial.Size = New System.Drawing.Size(24, 24)
        Me.LabelRazaoSocial.TabIndex = 21
        Me.LabelRazaoSocial.Text = "X"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnParcelamentos, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelRazaoSocial, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAlvara, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelCNPJ, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEmpresa, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(434, 414)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'FrmEscolha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(434, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEscolha"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prince Sistemas - Escolha"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEmpresa As Button
    Friend WithEvents BtnAlvara As Button
    Friend WithEvents LabelCNPJ As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnParcelamentos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelRazaoSocial As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
