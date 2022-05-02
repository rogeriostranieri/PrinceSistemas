<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProcedimentos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProcedimentos))
        Me.MunicipioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.MunicipioTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.MunicipioTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.ProcedimentoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.BtnBusca = New System.Windows.Forms.Button()
        Me.NomeLabel1 = New System.Windows.Forms.Label()
        Me.UfLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MunicipioBindingSource
        '
        Me.MunicipioBindingSource.DataMember = "Municipio"
        Me.MunicipioBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MunicipioTableAdapter
        '
        Me.MunicipioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Me.MunicipioTableAdapter
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProcedimentoRichTextBox
        '
        Me.ProcedimentoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MunicipioBindingSource, "Procedimento", True))
        Me.ProcedimentoRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcedimentoRichTextBox.Location = New System.Drawing.Point(25, 171)
        Me.ProcedimentoRichTextBox.Name = "ProcedimentoRichTextBox"
        Me.ProcedimentoRichTextBox.Size = New System.Drawing.Size(339, 215)
        Me.ProcedimentoRichTextBox.TabIndex = 4
        Me.ProcedimentoRichTextBox.Text = ""
        '
        'GroupBox9
        '
        Me.GroupBox9.AutoSize = True
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.BtnFechar)
        Me.GroupBox9.Controls.Add(Me.BtnSalvar)
        Me.GroupBox9.Location = New System.Drawing.Point(379, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(82, 90)
        Me.GroupBox9.TabIndex = 30
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "MENU"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Location = New System.Drawing.Point(7, 48)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 23)
        Me.BtnFechar.TabIndex = 6
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 19)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 23)
        Me.BtnSalvar.TabIndex = 5
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'TxtCidade
        '
        Me.TxtCidade.Location = New System.Drawing.Point(53, 12)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(129, 20)
        Me.TxtCidade.TabIndex = 1
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(229, 12)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(31, 20)
        Me.TxtEstado.TabIndex = 2
        '
        'BtnBusca
        '
        Me.BtnBusca.Location = New System.Drawing.Point(270, 9)
        Me.BtnBusca.Name = "BtnBusca"
        Me.BtnBusca.Size = New System.Drawing.Size(68, 26)
        Me.BtnBusca.TabIndex = 3
        Me.BtnBusca.Text = "Mostrar"
        Me.BtnBusca.UseVisualStyleBackColor = True
        '
        'NomeLabel1
        '
        Me.NomeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MunicipioBindingSource, "Nome", True))
        Me.NomeLabel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeLabel1.Location = New System.Drawing.Point(22, 99)
        Me.NomeLabel1.Name = "NomeLabel1"
        Me.NomeLabel1.Size = New System.Drawing.Size(252, 23)
        Me.NomeLabel1.TabIndex = 39
        Me.NomeLabel1.Text = "Label3"
        '
        'UfLabel1
        '
        Me.UfLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MunicipioBindingSource, "Uf", True))
        Me.UfLabel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UfLabel1.Location = New System.Drawing.Point(22, 122)
        Me.UfLabel1.Name = "UfLabel1"
        Me.UfLabel1.Size = New System.Drawing.Size(69, 23)
        Me.UfLabel1.TabIndex = 40
        Me.UfLabel1.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Estado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnBusca)
        Me.GroupBox1.Controls.Add(Me.TxtEstado)
        Me.GroupBox1.Controls.Add(Me.TxtCidade)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 45)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 15)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Procedimento Prefeitura:"
        '
        'FrmProcedimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 398)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UfLabel1)
        Me.Controls.Add(Me.NomeLabel1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.ProcedimentoRichTextBox)
        Me.Name = "FrmProcedimentos"
        Me.ShowIcon = False
        Me.Text = "Procedimentos por Cidades"
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents MunicipioBindingSource As BindingSource
    Friend WithEvents MunicipioTableAdapter As PrinceDBDataSetTableAdapters.MunicipioTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProcedimentoRichTextBox As RichTextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents BtnBusca As Button
    Friend WithEvents NomeLabel1 As Label
    Friend WithEvents UfLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
End Class
