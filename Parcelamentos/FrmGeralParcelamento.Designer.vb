﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGeralParcelamento
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAtualizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.CheckBoxEmAndamento = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFinalizada = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTodos = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMEI = New System.Windows.Forms.CheckBox()
        Me.CheckBoxINSSAntigo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxINSSNovo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxINSSProcuradoria = New System.Windows.Forms.CheckBox()
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.ParcelamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxMesFechamento = New System.Windows.Forms.ComboBox()
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(14, 201)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(664, 411)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(55, 616)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Label2"
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAtualizar.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.atualizar_azu
        Me.BtnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtualizar.Location = New System.Drawing.Point(14, 615)
        Me.BtnAtualizar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(42, 37)
        Me.BtnAtualizar.TabIndex = 30
        Me.BtnAtualizar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.fechar2
        Me.PictureBox2.Location = New System.Drawing.Point(535, -3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Parcelamentos"
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusca.Location = New System.Drawing.Point(14, 90)
        Me.TextBoxBusca.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(662, 31)
        Me.TextBoxBusca.TabIndex = 27
        '
        'CheckBoxEmAndamento
        '
        Me.CheckBoxEmAndamento.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxEmAndamento.Location = New System.Drawing.Point(14, 129)
        Me.CheckBoxEmAndamento.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxEmAndamento.Name = "CheckBoxEmAndamento"
        Me.CheckBoxEmAndamento.Size = New System.Drawing.Size(134, 24)
        Me.CheckBoxEmAndamento.TabIndex = 0
        Me.CheckBoxEmAndamento.Text = "Em Andamento"
        Me.CheckBoxEmAndamento.UseVisualStyleBackColor = False
        '
        'CheckBoxFinalizada
        '
        Me.CheckBoxFinalizada.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxFinalizada.Location = New System.Drawing.Point(156, 129)
        Me.CheckBoxFinalizada.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxFinalizada.Name = "CheckBoxFinalizada"
        Me.CheckBoxFinalizada.Size = New System.Drawing.Size(106, 24)
        Me.CheckBoxFinalizada.TabIndex = 32
        Me.CheckBoxFinalizada.Text = "Finalizados"
        Me.CheckBoxFinalizada.UseVisualStyleBackColor = False
        '
        'CheckBoxTodos
        '
        Me.CheckBoxTodos.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxTodos.Location = New System.Drawing.Point(284, 129)
        Me.CheckBoxTodos.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxTodos.Name = "CheckBoxTodos"
        Me.CheckBoxTodos.Size = New System.Drawing.Size(106, 24)
        Me.CheckBoxTodos.TabIndex = 33
        Me.CheckBoxTodos.Text = "Todos"
        Me.CheckBoxTodos.UseVisualStyleBackColor = False
        '
        'CheckBoxMEI
        '
        Me.CheckBoxMEI.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxMEI.Location = New System.Drawing.Point(13, 161)
        Me.CheckBoxMEI.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxMEI.Name = "CheckBoxMEI"
        Me.CheckBoxMEI.Size = New System.Drawing.Size(61, 24)
        Me.CheckBoxMEI.TabIndex = 34
        Me.CheckBoxMEI.Text = "MEI"
        Me.CheckBoxMEI.UseVisualStyleBackColor = False
        '
        'CheckBoxINSSAntigo
        '
        Me.CheckBoxINSSAntigo.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxINSSAntigo.Location = New System.Drawing.Point(82, 161)
        Me.CheckBoxINSSAntigo.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxINSSAntigo.Name = "CheckBoxINSSAntigo"
        Me.CheckBoxINSSAntigo.Size = New System.Drawing.Size(109, 24)
        Me.CheckBoxINSSAntigo.TabIndex = 35
        Me.CheckBoxINSSAntigo.Text = "INSS Antigo"
        Me.CheckBoxINSSAntigo.UseVisualStyleBackColor = False
        '
        'CheckBoxINSSNovo
        '
        Me.CheckBoxINSSNovo.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxINSSNovo.Location = New System.Drawing.Point(199, 161)
        Me.CheckBoxINSSNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxINSSNovo.Name = "CheckBoxINSSNovo"
        Me.CheckBoxINSSNovo.Size = New System.Drawing.Size(109, 24)
        Me.CheckBoxINSSNovo.TabIndex = 36
        Me.CheckBoxINSSNovo.Text = "INSS Novo"
        Me.CheckBoxINSSNovo.UseVisualStyleBackColor = False
        '
        'CheckBoxINSSProcuradoria
        '
        Me.CheckBoxINSSProcuradoria.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxINSSProcuradoria.Location = New System.Drawing.Point(305, 161)
        Me.CheckBoxINSSProcuradoria.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxINSSProcuradoria.Name = "CheckBoxINSSProcuradoria"
        Me.CheckBoxINSSProcuradoria.Size = New System.Drawing.Size(161, 24)
        Me.CheckBoxINSSProcuradoria.TabIndex = 37
        Me.CheckBoxINSSProcuradoria.Text = "INSS Procuradoria"
        Me.CheckBoxINSSProcuradoria.UseVisualStyleBackColor = False
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParcelamentosBindingSource
        '
        Me.ParcelamentosBindingSource.DataMember = "Parcelamentos"
        Me.ParcelamentosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjudaEmpresaFacilTableAdapter = Nothing
        Me.TableAdapterManager.AlvaraSistemaTableAdapter = Nothing
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BombeiroSituacaoTableAdapter = Nothing
        Me.TableAdapterManager.BrasilDistritosTableAdapter = Nothing
        Me.TableAdapterManager.BrasilEstadoTableAdapter = Nothing
        Me.TableAdapterManager.BrasilMunicipiosTableAdapter = Nothing
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAEprefMaringaPRTableAdapter = Nothing
        Me.TableAdapterManager.CNAESubclasses23TableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosAvisoTableAdapter = Nothing
        Me.TableAdapterManager.ParcelamentosTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Buscar:"
        '
        'ComboBoxMesFechamento
        '
        Me.ComboBoxMesFechamento.FormattingEnabled = True
        Me.ComboBoxMesFechamento.Location = New System.Drawing.Point(505, 158)
        Me.ComboBoxMesFechamento.Name = "ComboBoxMesFechamento"
        Me.ComboBoxMesFechamento.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxMesFechamento.TabIndex = 39
        '
        'FrmGeralParcelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 657)
        Me.Controls.Add(Me.ComboBoxMesFechamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBoxINSSProcuradoria)
        Me.Controls.Add(Me.CheckBoxINSSNovo)
        Me.Controls.Add(Me.CheckBoxINSSAntigo)
        Me.Controls.Add(Me.CheckBoxMEI)
        Me.Controls.Add(Me.CheckBoxTodos)
        Me.Controls.Add(Me.CheckBoxFinalizada)
        Me.Controls.Add(Me.CheckBoxEmAndamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAtualizar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBusca)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmGeralParcelamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGeralParcelamento"
        CType(Me.BtnAtualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParcelamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAtualizar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusca As TextBox
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents ParcelamentosBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckBoxEmAndamento As CheckBox
    Friend WithEvents CheckBoxFinalizada As CheckBox
    Friend WithEvents CheckBoxTodos As CheckBox
    Friend WithEvents CheckBoxMEI As CheckBox
    Friend WithEvents CheckBoxINSSAntigo As CheckBox
    Friend WithEvents CheckBoxINSSNovo As CheckBox
    Friend WithEvents CheckBoxINSSProcuradoria As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxMesFechamento As ComboBox
End Class
