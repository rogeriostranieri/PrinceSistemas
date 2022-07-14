<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLegalizacao
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
        Dim NomeFantasiaLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ProcessoLabel As System.Windows.Forms.Label
        Dim ProtocoloJuntaComercialLabel As System.Windows.Forms.Label
        Dim GeralLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim EndNumeroLabel As System.Windows.Forms.Label
        Dim EndBairroLabel As System.Windows.Forms.Label
        Dim EndComplementoLabel As System.Windows.Forms.Label
        Dim EndCEPLabel As System.Windows.Forms.Label
        Dim EndCidadeLabel As System.Windows.Forms.Label
        Dim EndEstadoLabel As System.Windows.Forms.Label
        Dim EndPaisLabel As System.Windows.Forms.Label
        Dim EmpTel1Label As System.Windows.Forms.Label
        Dim EmpTel2Label As System.Windows.Forms.Label
        Dim EmpEmailLabel As System.Windows.Forms.Label
        Dim PaginaWebLabel As System.Windows.Forms.Label
        Dim EmpCriadoLabel As System.Windows.Forms.Label
        Dim DataProtJuntaComercialLabel As System.Windows.Forms.Label
        Dim DataPedidoIELabel As System.Windows.Forms.Label
        Dim IELabel As System.Windows.Forms.Label
        Dim NIRELabel As System.Windows.Forms.Label
        Dim NireDataLabel As System.Windows.Forms.Label
        Dim RamoDeAtividadeLabel As System.Windows.Forms.Label
        Dim CNAESecundarioLabel As System.Windows.Forms.Label
        Dim CNAEPrincipalLabel As System.Windows.Forms.Label
        Dim EmpInicioAtividadeLabel As System.Windows.Forms.Label
        Dim NaturezaJuridicaLabel As System.Windows.Forms.Label
        Dim JuntaObsLabel As System.Windows.Forms.Label
        Dim DataRegistroAltLabel As System.Windows.Forms.Label
        Dim NRegistroAltLabel As System.Windows.Forms.Label
        Dim RedeSimObsLabel As System.Windows.Forms.Label
        Dim EstadualObsLabel As System.Windows.Forms.Label
        Dim PrefeituraObsLabel As System.Windows.Forms.Label
        Dim PrazoSimplesLabel As System.Windows.Forms.Label
        Dim CodigoSimplesLabel As System.Windows.Forms.Label
        Dim ArquivoContratoLabel As System.Windows.Forms.Label
        Dim ProcedimentoLabel As System.Windows.Forms.Label
        Dim RegimeFederalLabel As System.Windows.Forms.Label
        Dim TipoDeEmpresaLabel As System.Windows.Forms.Label
        Dim CPFResponsavelLabel As System.Windows.Forms.Label
        Dim NomeResponsavelLabel As System.Windows.Forms.Label
        Dim IEComprovanteLabel As System.Windows.Forms.Label
        Dim IEjuntaLabel As System.Windows.Forms.Label
        Dim BombeiroJuntaLabel As System.Windows.Forms.Label
        Dim ProtJuntaFinalLabel As System.Windows.Forms.Label
        Dim TituloeleitorLabel As System.Windows.Forms.Label
        Dim ObsSimplesLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim Area2Label As System.Windows.Forms.Label
        Dim DataSimplesLabel As System.Windows.Forms.Label
        Dim DataUltdefSimplesLabel As System.Windows.Forms.Label
        Dim OrgãoPedSimplesLabel As System.Windows.Forms.Label
        Dim PastaDocumentosLabel As System.Windows.Forms.Label
        Dim RespRGLabel As System.Windows.Forms.Label
        Dim HistoricoLabel As System.Windows.Forms.Label
        Dim AltProtLabel As System.Windows.Forms.Label
        Dim CapitalSLabel As System.Windows.Forms.Label
        Dim CapitalILabel As System.Windows.Forms.Label
        Dim DataExcSocialLabel As System.Windows.Forms.Label
        Dim RespMaeLabel As System.Windows.Forms.Label
        Dim RespDataNascLabel As System.Windows.Forms.Label
        Dim CNHnumeroLabel As System.Windows.Forms.Label
        Dim CNHexpLabel As System.Windows.Forms.Label
        Dim CNHdataexpLabel As System.Windows.Forms.Label
        Dim CadImobLabel As System.Windows.Forms.Label
        Dim EndZonaLabel As System.Windows.Forms.Label
        Dim EndQuadraLabel As System.Windows.Forms.Label
        Dim EndDataLabel As System.Windows.Forms.Label
        Dim ProcuracaoLabel As System.Windows.Forms.Label
        Dim ProcuracaoNLabel As System.Windows.Forms.Label
        Dim ProcuracaoDataLabel As System.Windows.Forms.Label
        Dim NovaRazaoSocial1Label As System.Windows.Forms.Label
        Dim NovaRazaoSocial2Label As System.Windows.Forms.Label
        Dim NovaRazaoSocial3Label As System.Windows.Forms.Label
        Dim AvisarDiaLabel As System.Windows.Forms.Label
        Dim NomeFantasiaLabel1 As System.Windows.Forms.Label
        Dim RespPaiLabel As System.Windows.Forms.Label
        Dim IEOnlineLabel As System.Windows.Forms.Label
        Dim IETipoLabel As System.Windows.Forms.Label
        Dim IEeProcNumLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim SituacaoCadastralLabel As System.Windows.Forms.Label
        Dim DivisaoCapitalSociosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLegalizacao))
        Me.EmpresasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox()
        Me.NomeFantasiaTextBox = New System.Windows.Forms.TextBox()
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CADstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControle = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MotivoLabel = New System.Windows.Forms.Label()
        Me.Button46 = New System.Windows.Forms.Button()
        Me.BtnListaEventos = New System.Windows.Forms.Button()
        Me.MotivoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ProcedimentoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GeralRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.BtnImportarSocioAdm = New System.Windows.Forms.Button()
        Me.BtnCopiarSenhaGov = New System.Windows.Forms.Button()
        Me.SenhaGovLabel = New System.Windows.Forms.Label()
        Me.SenhaGovTextBox = New System.Windows.Forms.TextBox()
        Me.RespPaiTextBox = New System.Windows.Forms.TextBox()
        Me.RespRgSiglaTextBox = New System.Windows.Forms.TextBox()
        Me.Button44 = New System.Windows.Forms.Button()
        Me.CNHdataexpMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CNHexpTextBox = New System.Windows.Forms.TextBox()
        Me.CNHnumeroTextBox = New System.Windows.Forms.TextBox()
        Me.RespDataNascMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RespMaeTextBox = New System.Windows.Forms.TextBox()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.NomeResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.RespRGTextBox = New System.Windows.Forms.TextBox()
        Me.TituloeleitorTextBox = New System.Windows.Forms.TextBox()
        Me.CPFResponsavelMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage19 = New System.Windows.Forms.TabPage()
        Me.BtnAddmaisSocio = New System.Windows.Forms.Button()
        Me.BtnLimparSocio = New System.Windows.Forms.Button()
        Me.BtnLimparSocios = New System.Windows.Forms.Button()
        Me.LblQuantidadeSocios = New System.Windows.Forms.Label()
        Me.QuantidadeSociosTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAdicionarSocio = New System.Windows.Forms.Button()
        Me.DadosSociosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CnaeSimples = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.CNAESecundarioRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.RamoDeAtividadeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CNAEPrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.EndPaisTextBox = New System.Windows.Forms.TextBox()
        Me.EndCidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EndComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.EndBairroTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.EndDataTextBox = New System.Windows.Forms.TextBox()
        Me.EndQuadraTextBox = New System.Windows.Forms.TextBox()
        Me.EndZonaTextBox = New System.Windows.Forms.TextBox()
        Me.CadImobTextBox = New System.Windows.Forms.TextBox()
        Me.EndCEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Area2TextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.EndEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.EndNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.EmpTel1TextBox = New System.Windows.Forms.TextBox()
        Me.EmpEmailTextBox = New System.Windows.Forms.TextBox()
        Me.PaginaWebTextBox = New System.Windows.Forms.TextBox()
        Me.EmpTel2TextBox = New System.Windows.Forms.TextBox()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.DivisaoCapitalSociosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonCalcCapSocial = New System.Windows.Forms.Button()
        Me.CapitalITextBox = New System.Windows.Forms.TextBox()
        Me.CapitalSTextBox = New System.Windows.Forms.TextBox()
        Me.DataExcSocialMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage18 = New System.Windows.Forms.TabPage()
        Me.BtnUsarNomeFantasia = New System.Windows.Forms.Button()
        Me.BtnUsarRazao3 = New System.Windows.Forms.Button()
        Me.BtnUsarRazao2 = New System.Windows.Forms.Button()
        Me.BtnUsarRazao1 = New System.Windows.Forms.Button()
        Me.RazaoSocialAntigaLabel = New System.Windows.Forms.Label()
        Me.BtnImportarRazaoSocial = New System.Windows.Forms.Button()
        Me.RazaoSocialAntigaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeFantasiaTextBox1 = New System.Windows.Forms.TextBox()
        Me.NovaRazaoSocial3TextBox = New System.Windows.Forms.TextBox()
        Me.NovaRazaoSocial2TextBox = New System.Windows.Forms.TextBox()
        Me.NovaRazaoSocial1TextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnAnotacoesLEgalizacao = New System.Windows.Forms.Button()
        Me.BtnData3 = New System.Windows.Forms.Button()
        Me.BtnData2 = New System.Windows.Forms.Button()
        Me.LinkLabelMudarRazaoSocial = New System.Windows.Forms.LinkLabel()
        Me.LabelNovaRazaoFinal = New System.Windows.Forms.Label()
        Me.NovaRazaoSocialFinalTextBox = New System.Windows.Forms.TextBox()
        Me.Button48 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.NireDataMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NIRETextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AltProtComboBox = New System.Windows.Forms.ComboBox()
        Me.NRegistroAltTextBox = New System.Windows.Forms.TextBox()
        Me.DataRegistroAltMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.BtnArrumar = New System.Windows.Forms.Button()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.PastaDocumentosTextBox = New System.Windows.Forms.TextBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.ArquivoContratoTextBox = New System.Windows.Forms.TextBox()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.TabPage20 = New System.Windows.Forms.TabPage()
        Me.BtnImportarAnexo = New System.Windows.Forms.Button()
        Me.AnexoBoxPicture = New System.Windows.Forms.PictureBox()
        Me.DocContratosLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BtnApagaAnexo = New System.Windows.Forms.Button()
        Me.BtnAbrirDoc = New System.Windows.Forms.Button()
        Me.BtnSalvarDoc = New System.Windows.Forms.Button()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.ProtJuntaFinalMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.JuntaObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataProtJuntaComercialMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BtnConsultaJunta = New System.Windows.Forms.Button()
        Me.ProtocoloJuntaComercialTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BtnAnotacoesFederal = New System.Windows.Forms.Button()
        Me.BtnData4 = New System.Windows.Forms.Button()
        Me.Button47 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel15 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel14 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.ProtocoloREDESIMLabel = New System.Windows.Forms.Label()
        Me.DataProtREDESIMLabel = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.RedeSimObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.BtnConsultaRedeSim = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataProtREDESIMMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ProtocoloREDESIMTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BtnAnotacoesEstadual = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.BtnConsultaeProcessoEstado = New System.Windows.Forms.Button()
        Me.DatadeInicioIE = New System.Windows.Forms.Label()
        Me.IEeProcNumTextBox = New System.Windows.Forms.TextBox()
        Me.IETipoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IEOnlineComboBox = New System.Windows.Forms.ComboBox()
        Me.IEVencPedidoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.IEInicioAtividadeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EstadualObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.IEComprovanteTextBox = New System.Windows.Forms.TextBox()
        Me.DataPedidoIEMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.IEjuntaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.BtnAnotacoesSimples = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.BtnCopiaDataDeNasc = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.OrgãoPedSimplesComboBox = New System.Windows.Forms.ComboBox()
        Me.DataUltdefSimplesMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataSimplesMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ObsSimplesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel17 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtDataASomar = New System.Windows.Forms.TextBox()
        Me.PrazoSimplesMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.CodigoSimplesTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.BtnAnotacoesPrefeitura = New System.Windows.Forms.Button()
        Me.LinkLabel16 = New System.Windows.Forms.LinkLabel()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.BombeiroJuntaComboBox = New System.Windows.Forms.ComboBox()
        Me.PrefeituraObsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnAnotacoesDemais = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.HistoricoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage17 = New System.Windows.Forms.TabPage()
        Me.ProcuracaoDataMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ProcuracaoNMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ProcuracaoComboBox = New System.Windows.Forms.ComboBox()
        Me.Button45 = New System.Windows.Forms.Button()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NovaRazaoSocialComboBox = New System.Windows.Forms.ComboBox()
        Me.AvisarDiaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.LembreteCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrioridadeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.IETextBox = New System.Windows.Forms.TextBox()
        Me.EmpInicioAtividadeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NaturezaJuridicaComboBox = New System.Windows.Forms.ComboBox()
        Me.NaturezajuridicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CNAEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProcessoComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EmpresasTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.NaturezajuridicaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.NaturezajuridicaTableAdapter()
        Me.CNAETableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CNAETableAdapter()
        Me.EmpCriadoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SituacaoCadastralComboBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabel18 = New System.Windows.Forms.LinkLabel()
        Me.RazaoSocialLabel = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button43 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TipoDeEmpresaComboBox = New System.Windows.Forms.ComboBox()
        Me.PorteDaEmpresaComboBox = New System.Windows.Forms.ComboBox()
        Me.RegimeFederalComboBox = New System.Windows.Forms.ComboBox()
        Me.SistemaExternoComboBox = New System.Windows.Forms.ComboBox()
        Me.ButtoneMail = New System.Windows.Forms.Button()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.NAlteracaoLabel = New System.Windows.Forms.Label()
        Me.NAlteracaoComboBox = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnContador = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.BtnAlteracao = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.ComboBoxBuscaEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.NovaRazaoSocialLabel = New System.Windows.Forms.Label()
        Me.PictureBoxSistemaExterno = New System.Windows.Forms.PictureBox()
        Me.BtnData1 = New System.Windows.Forms.Button()
        Me.LabelConsolidar = New System.Windows.Forms.Label()
        Me.AltConsolidadaComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnVerEventos = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SistemaExternoLabel = New System.Windows.Forms.Label()
        Me.BtnWord = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnLocalizar = New System.Windows.Forms.Button()
        Me.CADstatusTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADstatusTableAdapter()
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxMenuCima = New System.Windows.Forms.GroupBox()
        Me.GroupBoxMenuBaixo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxBuscaCNPJ = New System.Windows.Forms.ComboBox()
        NomeFantasiaLabel = New System.Windows.Forms.Label()
        CNPJLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ProcessoLabel = New System.Windows.Forms.Label()
        ProtocoloJuntaComercialLabel = New System.Windows.Forms.Label()
        GeralLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        EndNumeroLabel = New System.Windows.Forms.Label()
        EndBairroLabel = New System.Windows.Forms.Label()
        EndComplementoLabel = New System.Windows.Forms.Label()
        EndCEPLabel = New System.Windows.Forms.Label()
        EndCidadeLabel = New System.Windows.Forms.Label()
        EndEstadoLabel = New System.Windows.Forms.Label()
        EndPaisLabel = New System.Windows.Forms.Label()
        EmpTel1Label = New System.Windows.Forms.Label()
        EmpTel2Label = New System.Windows.Forms.Label()
        EmpEmailLabel = New System.Windows.Forms.Label()
        PaginaWebLabel = New System.Windows.Forms.Label()
        EmpCriadoLabel = New System.Windows.Forms.Label()
        DataProtJuntaComercialLabel = New System.Windows.Forms.Label()
        DataPedidoIELabel = New System.Windows.Forms.Label()
        IELabel = New System.Windows.Forms.Label()
        NIRELabel = New System.Windows.Forms.Label()
        NireDataLabel = New System.Windows.Forms.Label()
        RamoDeAtividadeLabel = New System.Windows.Forms.Label()
        CNAESecundarioLabel = New System.Windows.Forms.Label()
        CNAEPrincipalLabel = New System.Windows.Forms.Label()
        EmpInicioAtividadeLabel = New System.Windows.Forms.Label()
        NaturezaJuridicaLabel = New System.Windows.Forms.Label()
        JuntaObsLabel = New System.Windows.Forms.Label()
        DataRegistroAltLabel = New System.Windows.Forms.Label()
        NRegistroAltLabel = New System.Windows.Forms.Label()
        RedeSimObsLabel = New System.Windows.Forms.Label()
        EstadualObsLabel = New System.Windows.Forms.Label()
        PrefeituraObsLabel = New System.Windows.Forms.Label()
        PrazoSimplesLabel = New System.Windows.Forms.Label()
        CodigoSimplesLabel = New System.Windows.Forms.Label()
        ArquivoContratoLabel = New System.Windows.Forms.Label()
        ProcedimentoLabel = New System.Windows.Forms.Label()
        RegimeFederalLabel = New System.Windows.Forms.Label()
        TipoDeEmpresaLabel = New System.Windows.Forms.Label()
        CPFResponsavelLabel = New System.Windows.Forms.Label()
        NomeResponsavelLabel = New System.Windows.Forms.Label()
        IEComprovanteLabel = New System.Windows.Forms.Label()
        IEjuntaLabel = New System.Windows.Forms.Label()
        BombeiroJuntaLabel = New System.Windows.Forms.Label()
        ProtJuntaFinalLabel = New System.Windows.Forms.Label()
        TituloeleitorLabel = New System.Windows.Forms.Label()
        ObsSimplesLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        Area2Label = New System.Windows.Forms.Label()
        DataSimplesLabel = New System.Windows.Forms.Label()
        DataUltdefSimplesLabel = New System.Windows.Forms.Label()
        OrgãoPedSimplesLabel = New System.Windows.Forms.Label()
        PastaDocumentosLabel = New System.Windows.Forms.Label()
        RespRGLabel = New System.Windows.Forms.Label()
        HistoricoLabel = New System.Windows.Forms.Label()
        AltProtLabel = New System.Windows.Forms.Label()
        CapitalSLabel = New System.Windows.Forms.Label()
        CapitalILabel = New System.Windows.Forms.Label()
        DataExcSocialLabel = New System.Windows.Forms.Label()
        RespMaeLabel = New System.Windows.Forms.Label()
        RespDataNascLabel = New System.Windows.Forms.Label()
        CNHnumeroLabel = New System.Windows.Forms.Label()
        CNHexpLabel = New System.Windows.Forms.Label()
        CNHdataexpLabel = New System.Windows.Forms.Label()
        CadImobLabel = New System.Windows.Forms.Label()
        EndZonaLabel = New System.Windows.Forms.Label()
        EndQuadraLabel = New System.Windows.Forms.Label()
        EndDataLabel = New System.Windows.Forms.Label()
        ProcuracaoLabel = New System.Windows.Forms.Label()
        ProcuracaoNLabel = New System.Windows.Forms.Label()
        ProcuracaoDataLabel = New System.Windows.Forms.Label()
        NovaRazaoSocial1Label = New System.Windows.Forms.Label()
        NovaRazaoSocial2Label = New System.Windows.Forms.Label()
        NovaRazaoSocial3Label = New System.Windows.Forms.Label()
        AvisarDiaLabel = New System.Windows.Forms.Label()
        NomeFantasiaLabel1 = New System.Windows.Forms.Label()
        RespPaiLabel = New System.Windows.Forms.Label()
        IEOnlineLabel = New System.Windows.Forms.Label()
        IETipoLabel = New System.Windows.Forms.Label()
        IEeProcNumLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        SituacaoCadastralLabel = New System.Windows.Forms.Label()
        DivisaoCapitalSociosLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasBindingNavigator.SuspendLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControle.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPage19.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        Me.TabPage16.SuspendLayout()
        Me.TabPage18.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage20.SuspendLayout()
        CType(Me.AnexoBoxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage17.SuspendLayout()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaturezajuridicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CNAEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.PictureBoxSistemaExterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMenuCima.SuspendLayout()
        Me.GroupBoxMenuBaixo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeFantasiaLabel
        '
        NomeFantasiaLabel.AutoSize = True
        NomeFantasiaLabel.Location = New System.Drawing.Point(12, 98)
        NomeFantasiaLabel.Name = "NomeFantasiaLabel"
        NomeFantasiaLabel.Size = New System.Drawing.Size(81, 13)
        NomeFantasiaLabel.TabIndex = 3
        NomeFantasiaLabel.Text = "Nome Fantasia:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(56, 46)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(37, 13)
        CNPJLabel.TabIndex = 5
        CNPJLabel.Text = "CNPJ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(338, 18)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 9
        StatusLabel.Text = "Status:"
        '
        'ProcessoLabel
        '
        ProcessoLabel.AutoSize = True
        ProcessoLabel.Location = New System.Drawing.Point(11, 106)
        ProcessoLabel.Name = "ProcessoLabel"
        ProcessoLabel.Size = New System.Drawing.Size(54, 13)
        ProcessoLabel.TabIndex = 11
        ProcessoLabel.Text = "Processo:"
        '
        'ProtocoloJuntaComercialLabel
        '
        ProtocoloJuntaComercialLabel.AutoSize = True
        ProtocoloJuntaComercialLabel.Location = New System.Drawing.Point(29, 40)
        ProtocoloJuntaComercialLabel.Name = "ProtocoloJuntaComercialLabel"
        ProtocoloJuntaComercialLabel.Size = New System.Drawing.Size(55, 13)
        ProtocoloJuntaComercialLabel.TabIndex = 0
        ProtocoloJuntaComercialLabel.Text = "Protocolo:"
        '
        'GeralLabel
        '
        GeralLabel.AutoSize = True
        GeralLabel.Location = New System.Drawing.Point(337, 149)
        GeralLabel.Name = "GeralLabel"
        GeralLabel.Size = New System.Drawing.Size(106, 13)
        GeralLabel.TabIndex = 0
        GeralLabel.Text = "Observações Gerais:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(7, 53)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 0
        EnderecoLabel.Text = "Endereco:"
        '
        'EndNumeroLabel
        '
        EndNumeroLabel.AutoSize = True
        EndNumeroLabel.Location = New System.Drawing.Point(459, 53)
        EndNumeroLabel.Name = "EndNumeroLabel"
        EndNumeroLabel.Size = New System.Drawing.Size(47, 13)
        EndNumeroLabel.TabIndex = 2
        EndNumeroLabel.Text = "Numero:"
        '
        'EndBairroLabel
        '
        EndBairroLabel.AutoSize = True
        EndBairroLabel.Location = New System.Drawing.Point(23, 104)
        EndBairroLabel.Name = "EndBairroLabel"
        EndBairroLabel.Size = New System.Drawing.Size(37, 13)
        EndBairroLabel.TabIndex = 4
        EndBairroLabel.Text = "Bairro:"
        '
        'EndComplementoLabel
        '
        EndComplementoLabel.AutoSize = True
        EndComplementoLabel.Location = New System.Drawing.Point(289, 104)
        EndComplementoLabel.Name = "EndComplementoLabel"
        EndComplementoLabel.Size = New System.Drawing.Size(74, 13)
        EndComplementoLabel.TabIndex = 6
        EndComplementoLabel.Text = "Complemento:"
        '
        'EndCEPLabel
        '
        EndCEPLabel.AutoSize = True
        EndCEPLabel.Location = New System.Drawing.Point(29, 27)
        EndCEPLabel.Name = "EndCEPLabel"
        EndCEPLabel.Size = New System.Drawing.Size(31, 13)
        EndCEPLabel.TabIndex = 8
        EndCEPLabel.Text = "CEP:"
        '
        'EndCidadeLabel
        '
        EndCidadeLabel.AutoSize = True
        EndCidadeLabel.Location = New System.Drawing.Point(20, 130)
        EndCidadeLabel.Name = "EndCidadeLabel"
        EndCidadeLabel.Size = New System.Drawing.Size(43, 13)
        EndCidadeLabel.TabIndex = 10
        EndCidadeLabel.Text = "Cidade:"
        '
        'EndEstadoLabel
        '
        EndEstadoLabel.AutoSize = True
        EndEstadoLabel.Location = New System.Drawing.Point(245, 130)
        EndEstadoLabel.Name = "EndEstadoLabel"
        EndEstadoLabel.Size = New System.Drawing.Size(43, 13)
        EndEstadoLabel.TabIndex = 12
        EndEstadoLabel.Text = "Estado:"
        '
        'EndPaisLabel
        '
        EndPaisLabel.AutoSize = True
        EndPaisLabel.Location = New System.Drawing.Point(340, 130)
        EndPaisLabel.Name = "EndPaisLabel"
        EndPaisLabel.Size = New System.Drawing.Size(32, 13)
        EndPaisLabel.TabIndex = 14
        EndPaisLabel.Text = "País:"
        '
        'EmpTel1Label
        '
        EmpTel1Label.AutoSize = True
        EmpTel1Label.Location = New System.Drawing.Point(9, 15)
        EmpTel1Label.Name = "EmpTel1Label"
        EmpTel1Label.Size = New System.Drawing.Size(61, 13)
        EmpTel1Label.TabIndex = 13
        EmpTel1Label.Text = "Telefone 1:"
        '
        'EmpTel2Label
        '
        EmpTel2Label.AutoSize = True
        EmpTel2Label.Location = New System.Drawing.Point(9, 41)
        EmpTel2Label.Name = "EmpTel2Label"
        EmpTel2Label.Size = New System.Drawing.Size(61, 13)
        EmpTel2Label.TabIndex = 15
        EmpTel2Label.Text = "Telefone 2:"
        '
        'EmpEmailLabel
        '
        EmpEmailLabel.AutoSize = True
        EmpEmailLabel.Location = New System.Drawing.Point(36, 67)
        EmpEmailLabel.Name = "EmpEmailLabel"
        EmpEmailLabel.Size = New System.Drawing.Size(35, 13)
        EmpEmailLabel.TabIndex = 21
        EmpEmailLabel.Text = "eMail:"
        '
        'PaginaWebLabel
        '
        PaginaWebLabel.AutoSize = True
        PaginaWebLabel.Location = New System.Drawing.Point(40, 97)
        PaginaWebLabel.Name = "PaginaWebLabel"
        PaginaWebLabel.Size = New System.Drawing.Size(33, 13)
        PaginaWebLabel.TabIndex = 23
        PaginaWebLabel.Text = "Web:"
        '
        'EmpCriadoLabel
        '
        EmpCriadoLabel.AutoSize = True
        EmpCriadoLabel.Location = New System.Drawing.Point(1, 19)
        EmpCriadoLabel.Name = "EmpCriadoLabel"
        EmpCriadoLabel.Size = New System.Drawing.Size(64, 13)
        EmpCriadoLabel.TabIndex = 13
        EmpCriadoLabel.Text = "Iniciado em:"
        '
        'DataProtJuntaComercialLabel
        '
        DataProtJuntaComercialLabel.AutoSize = True
        DataProtJuntaComercialLabel.Location = New System.Drawing.Point(20, 14)
        DataProtJuntaComercialLabel.Name = "DataProtJuntaComercialLabel"
        DataProtJuntaComercialLabel.Size = New System.Drawing.Size(64, 13)
        DataProtJuntaComercialLabel.TabIndex = 3
        DataProtJuntaComercialLabel.Text = "Iniciado dia:"
        '
        'DataPedidoIELabel
        '
        DataPedidoIELabel.AutoSize = True
        DataPedidoIELabel.Location = New System.Drawing.Point(34, 70)
        DataPedidoIELabel.Name = "DataPedidoIELabel"
        DataPedidoIELabel.Size = New System.Drawing.Size(73, 13)
        DataPedidoIELabel.TabIndex = 0
        DataPedidoIELabel.Text = "Solicitado dia:"
        '
        'IELabel
        '
        IELabel.AutoSize = True
        IELabel.Location = New System.Drawing.Point(353, 47)
        IELabel.Name = "IELabel"
        IELabel.Size = New System.Drawing.Size(97, 13)
        IELabel.TabIndex = 2
        IELabel.Text = "Inscrição Estadual:"
        '
        'NIRELabel
        '
        NIRELabel.AutoSize = True
        NIRELabel.Location = New System.Drawing.Point(4, 19)
        NIRELabel.Name = "NIRELabel"
        NIRELabel.Size = New System.Drawing.Size(54, 13)
        NIRELabel.TabIndex = 21
        NIRELabel.Text = "Nº. NIRE:"
        '
        'NireDataLabel
        '
        NireDataLabel.AutoSize = True
        NireDataLabel.Location = New System.Drawing.Point(25, 42)
        NireDataLabel.Name = "NireDataLabel"
        NireDataLabel.Size = New System.Drawing.Size(33, 13)
        NireDataLabel.TabIndex = 22
        NireDataLabel.Text = "Data:"
        '
        'RamoDeAtividadeLabel
        '
        RamoDeAtividadeLabel.AutoSize = True
        RamoDeAtividadeLabel.Location = New System.Drawing.Point(153, 19)
        RamoDeAtividadeLabel.Name = "RamoDeAtividadeLabel"
        RamoDeAtividadeLabel.Size = New System.Drawing.Size(102, 13)
        RamoDeAtividadeLabel.TabIndex = 30
        RamoDeAtividadeLabel.Text = "Ramo De Atividade:"
        '
        'CNAESecundarioLabel
        '
        CNAESecundarioLabel.AutoSize = True
        CNAESecundarioLabel.Location = New System.Drawing.Point(1, 58)
        CNAESecundarioLabel.Name = "CNAESecundarioLabel"
        CNAESecundarioLabel.Size = New System.Drawing.Size(64, 13)
        CNAESecundarioLabel.TabIndex = 26
        CNAESecundarioLabel.Text = "Secundário:"
        '
        'CNAEPrincipalLabel
        '
        CNAEPrincipalLabel.AutoSize = True
        CNAEPrincipalLabel.Location = New System.Drawing.Point(17, 34)
        CNAEPrincipalLabel.Name = "CNAEPrincipalLabel"
        CNAEPrincipalLabel.Size = New System.Drawing.Size(50, 13)
        CNAEPrincipalLabel.TabIndex = 25
        CNAEPrincipalLabel.Text = "Principal:"
        '
        'EmpInicioAtividadeLabel
        '
        EmpInicioAtividadeLabel.AutoSize = True
        EmpInicioAtividadeLabel.Location = New System.Drawing.Point(452, 16)
        EmpInicioAtividadeLabel.Name = "EmpInicioAtividadeLabel"
        EmpInicioAtividadeLabel.Size = New System.Drawing.Size(109, 13)
        EmpInicioAtividadeLabel.TabIndex = 24
        EmpInicioAtividadeLabel.Text = "Início das Atividades:"
        '
        'NaturezaJuridicaLabel
        '
        NaturezaJuridicaLabel.AutoSize = True
        NaturezaJuridicaLabel.Location = New System.Drawing.Point(7, 124)
        NaturezaJuridicaLabel.Name = "NaturezaJuridicaLabel"
        NaturezaJuridicaLabel.Size = New System.Drawing.Size(92, 13)
        NaturezaJuridicaLabel.TabIndex = 22
        NaturezaJuridicaLabel.Text = "Natureza Juridica:"
        '
        'JuntaObsLabel
        '
        JuntaObsLabel.AutoSize = True
        JuntaObsLabel.Location = New System.Drawing.Point(6, 146)
        JuntaObsLabel.Name = "JuntaObsLabel"
        JuntaObsLabel.Size = New System.Drawing.Size(29, 13)
        JuntaObsLabel.TabIndex = 29
        JuntaObsLabel.Text = "Obs:"
        '
        'DataRegistroAltLabel
        '
        DataRegistroAltLabel.AutoSize = True
        DataRegistroAltLabel.Location = New System.Drawing.Point(48, 42)
        DataRegistroAltLabel.Name = "DataRegistroAltLabel"
        DataRegistroAltLabel.Size = New System.Drawing.Size(75, 13)
        DataRegistroAltLabel.TabIndex = 30
        DataRegistroAltLabel.Text = "Data Registro:"
        '
        'NRegistroAltLabel
        '
        NRegistroAltLabel.AutoSize = True
        NRegistroAltLabel.Location = New System.Drawing.Point(68, 19)
        NRegistroAltLabel.Name = "NRegistroAltLabel"
        NRegistroAltLabel.Size = New System.Drawing.Size(55, 13)
        NRegistroAltLabel.TabIndex = 31
        NRegistroAltLabel.Text = "Protocolo:"
        '
        'RedeSimObsLabel
        '
        RedeSimObsLabel.AutoSize = True
        RedeSimObsLabel.Location = New System.Drawing.Point(20, 118)
        RedeSimObsLabel.Name = "RedeSimObsLabel"
        RedeSimObsLabel.Size = New System.Drawing.Size(29, 13)
        RedeSimObsLabel.TabIndex = 30
        RedeSimObsLabel.Text = "Obs:"
        '
        'EstadualObsLabel
        '
        EstadualObsLabel.AutoSize = True
        EstadualObsLabel.Location = New System.Drawing.Point(379, 17)
        EstadualObsLabel.Name = "EstadualObsLabel"
        EstadualObsLabel.Size = New System.Drawing.Size(29, 13)
        EstadualObsLabel.TabIndex = 4
        EstadualObsLabel.Text = "Obs:"
        '
        'PrefeituraObsLabel
        '
        PrefeituraObsLabel.AutoSize = True
        PrefeituraObsLabel.Location = New System.Drawing.Point(28, 53)
        PrefeituraObsLabel.Name = "PrefeituraObsLabel"
        PrefeituraObsLabel.Size = New System.Drawing.Size(29, 13)
        PrefeituraObsLabel.TabIndex = 39
        PrefeituraObsLabel.Text = "Obs:"
        '
        'PrazoSimplesLabel
        '
        PrazoSimplesLabel.AutoSize = True
        PrazoSimplesLabel.Location = New System.Drawing.Point(9, 53)
        PrazoSimplesLabel.Name = "PrazoSimplesLabel"
        PrazoSimplesLabel.Size = New System.Drawing.Size(76, 13)
        PrazoSimplesLabel.TabIndex = 28
        PrazoSimplesLabel.Text = "Prazo Simples:"
        '
        'CodigoSimplesLabel
        '
        CodigoSimplesLabel.AutoSize = True
        CodigoSimplesLabel.Location = New System.Drawing.Point(104, 10)
        CodigoSimplesLabel.Name = "CodigoSimplesLabel"
        CodigoSimplesLabel.Size = New System.Drawing.Size(97, 13)
        CodigoSimplesLabel.TabIndex = 32
        CodigoSimplesLabel.Text = "Código do Simples:"
        '
        'ArquivoContratoLabel
        '
        ArquivoContratoLabel.AutoSize = True
        ArquivoContratoLabel.Location = New System.Drawing.Point(6, 8)
        ArquivoContratoLabel.Name = "ArquivoContratoLabel"
        ArquivoContratoLabel.Size = New System.Drawing.Size(104, 13)
        ArquivoContratoLabel.TabIndex = 36
        ArquivoContratoLabel.Text = "Arquivo do Contrato:"
        '
        'ProcedimentoLabel
        '
        ProcedimentoLabel.AutoSize = True
        ProcedimentoLabel.Location = New System.Drawing.Point(337, 20)
        ProcedimentoLabel.Name = "ProcedimentoLabel"
        ProcedimentoLabel.Size = New System.Drawing.Size(125, 13)
        ProcedimentoLabel.TabIndex = 2
        ProcedimentoLabel.Text = "Procedimento detalhado:"
        '
        'RegimeFederalLabel
        '
        RegimeFederalLabel.AutoSize = True
        RegimeFederalLabel.Location = New System.Drawing.Point(422, 152)
        RegimeFederalLabel.Name = "RegimeFederalLabel"
        RegimeFederalLabel.Size = New System.Drawing.Size(84, 13)
        RegimeFederalLabel.TabIndex = 27
        RegimeFederalLabel.Text = "Regime Federal:"
        '
        'TipoDeEmpresaLabel
        '
        TipoDeEmpresaLabel.AutoSize = True
        TipoDeEmpresaLabel.Location = New System.Drawing.Point(62, 16)
        TipoDeEmpresaLabel.Name = "TipoDeEmpresaLabel"
        TipoDeEmpresaLabel.Size = New System.Drawing.Size(31, 13)
        TipoDeEmpresaLabel.TabIndex = 29
        TipoDeEmpresaLabel.Text = "Tipo:"
        '
        'CPFResponsavelLabel
        '
        CPFResponsavelLabel.AutoSize = True
        CPFResponsavelLabel.Location = New System.Drawing.Point(24, 129)
        CPFResponsavelLabel.Name = "CPFResponsavelLabel"
        CPFResponsavelLabel.Size = New System.Drawing.Size(30, 13)
        CPFResponsavelLabel.TabIndex = 34
        CPFResponsavelLabel.Text = "CPF:"
        '
        'NomeResponsavelLabel
        '
        NomeResponsavelLabel.AutoSize = True
        NomeResponsavelLabel.Location = New System.Drawing.Point(16, 18)
        NomeResponsavelLabel.Name = "NomeResponsavelLabel"
        NomeResponsavelLabel.Size = New System.Drawing.Size(38, 13)
        NomeResponsavelLabel.TabIndex = 33
        NomeResponsavelLabel.Text = "Nome:"
        '
        'IEComprovanteLabel
        '
        IEComprovanteLabel.AutoSize = True
        IEComprovanteLabel.Location = New System.Drawing.Point(5, 97)
        IEComprovanteLabel.Name = "IEComprovanteLabel"
        IEComprovanteLabel.Size = New System.Drawing.Size(103, 13)
        IEComprovanteLabel.TabIndex = 24
        IEComprovanteLabel.Text = "Nº do Comprovante:"
        '
        'IEjuntaLabel
        '
        IEjuntaLabel.AutoSize = True
        IEjuntaLabel.Location = New System.Drawing.Point(13, 21)
        IEjuntaLabel.Name = "IEjuntaLabel"
        IEjuntaLabel.Size = New System.Drawing.Size(115, 13)
        IEjuntaLabel.TabIndex = 36
        IEjuntaLabel.Text = "Vinculo da Solicitação:"
        '
        'BombeiroJuntaLabel
        '
        BombeiroJuntaLabel.AutoSize = True
        BombeiroJuntaLabel.Location = New System.Drawing.Point(24, 24)
        BombeiroJuntaLabel.Name = "BombeiroJuntaLabel"
        BombeiroJuntaLabel.Size = New System.Drawing.Size(115, 13)
        BombeiroJuntaLabel.TabIndex = 40
        BombeiroJuntaLabel.Text = "Vinculo da Solicitação:"
        '
        'ProtJuntaFinalLabel
        '
        ProtJuntaFinalLabel.AutoSize = True
        ProtJuntaFinalLabel.Location = New System.Drawing.Point(17, 66)
        ProtJuntaFinalLabel.Name = "ProtJuntaFinalLabel"
        ProtJuntaFinalLabel.Size = New System.Drawing.Size(67, 13)
        ProtJuntaFinalLabel.TabIndex = 40
        ProtJuntaFinalLabel.Text = "Protocolado:"
        '
        'TituloeleitorLabel
        '
        TituloeleitorLabel.AutoSize = True
        TituloeleitorLabel.Location = New System.Drawing.Point(252, 102)
        TituloeleitorLabel.Name = "TituloeleitorLabel"
        TituloeleitorLabel.Size = New System.Drawing.Size(85, 13)
        TituloeleitorLabel.TabIndex = 37
        TituloeleitorLabel.Text = "Título de Eleitor:"
        '
        'ObsSimplesLabel
        '
        ObsSimplesLabel.AutoSize = True
        ObsSimplesLabel.Location = New System.Drawing.Point(8, 128)
        ObsSimplesLabel.Name = "ObsSimplesLabel"
        ObsSimplesLabel.Size = New System.Drawing.Size(29, 13)
        ObsSimplesLabel.TabIndex = 48
        ObsSimplesLabel.Text = "Obs:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(20, 156)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(101, 13)
        AreaLabel.TabIndex = 26
        AreaLabel.Text = "Área do Imóvel (m²):"
        '
        'Area2Label
        '
        Area2Label.AutoSize = True
        Area2Label.Location = New System.Drawing.Point(178, 156)
        Area2Label.Name = "Area2Label"
        Area2Label.Size = New System.Drawing.Size(148, 13)
        Area2Label.TabIndex = 28
        Area2Label.Text = "Área do Estabelecimento (m²):"
        '
        'DataSimplesLabel
        '
        DataSimplesLabel.AutoSize = True
        DataSimplesLabel.Location = New System.Drawing.Point(88, 79)
        DataSimplesLabel.Name = "DataSimplesLabel"
        DataSimplesLabel.Size = New System.Drawing.Size(113, 13)
        DataSimplesLabel.TabIndex = 49
        DataSimplesLabel.Text = "Finalização do pedido:"
        '
        'DataUltdefSimplesLabel
        '
        DataUltdefSimplesLabel.AutoSize = True
        DataUltdefSimplesLabel.Location = New System.Drawing.Point(6, 32)
        DataUltdefSimplesLabel.Name = "DataUltdefSimplesLabel"
        DataUltdefSimplesLabel.Size = New System.Drawing.Size(196, 13)
        DataUltdefSimplesLabel.TabIndex = 51
        DataUltdefSimplesLabel.Text = "Data do último deferimento de inscrição:"
        '
        'OrgãoPedSimplesLabel
        '
        OrgãoPedSimplesLabel.AutoSize = True
        OrgãoPedSimplesLabel.Location = New System.Drawing.Point(69, 57)
        OrgãoPedSimplesLabel.Name = "OrgãoPedSimplesLabel"
        OrgãoPedSimplesLabel.Size = New System.Drawing.Size(133, 13)
        OrgãoPedSimplesLabel.TabIndex = 52
        OrgãoPedSimplesLabel.Text = "Tipo de Inscrição utilizada:"
        '
        'PastaDocumentosLabel
        '
        PastaDocumentosLabel.AutoSize = True
        PastaDocumentosLabel.Location = New System.Drawing.Point(6, 85)
        PastaDocumentosLabel.Name = "PastaDocumentosLabel"
        PastaDocumentosLabel.Size = New System.Drawing.Size(120, 13)
        PastaDocumentosLabel.TabIndex = 42
        PastaDocumentosLabel.Text = "Pasta dos Documentos:"
        '
        'RespRGLabel
        '
        RespRGLabel.AutoSize = True
        RespRGLabel.Location = New System.Drawing.Point(22, 103)
        RespRGLabel.Name = "RespRGLabel"
        RespRGLabel.Size = New System.Drawing.Size(32, 13)
        RespRGLabel.TabIndex = 38
        RespRGLabel.Text = "R.G.:"
        '
        'HistoricoLabel
        '
        HistoricoLabel.AutoSize = True
        HistoricoLabel.Location = New System.Drawing.Point(15, 18)
        HistoricoLabel.Name = "HistoricoLabel"
        HistoricoLabel.Size = New System.Drawing.Size(110, 13)
        HistoricoLabel.TabIndex = 0
        HistoricoLabel.Text = "Histórico da Empresa:"
        '
        'AltProtLabel
        '
        AltProtLabel.AutoSize = True
        AltProtLabel.Location = New System.Drawing.Point(41, 19)
        AltProtLabel.Name = "AltProtLabel"
        AltProtLabel.Size = New System.Drawing.Size(22, 13)
        AltProtLabel.TabIndex = 49
        AltProtLabel.Text = "Alt."
        '
        'CapitalSLabel
        '
        CapitalSLabel.AutoSize = True
        CapitalSLabel.Location = New System.Drawing.Point(37, 25)
        CapitalSLabel.Name = "CapitalSLabel"
        CapitalSLabel.Size = New System.Drawing.Size(74, 13)
        CapitalSLabel.TabIndex = 0
        CapitalSLabel.Text = "Capital Social:"
        '
        'CapitalILabel
        '
        CapitalILabel.AutoSize = True
        CapitalILabel.Location = New System.Drawing.Point(6, 51)
        CapitalILabel.Name = "CapitalILabel"
        CapitalILabel.Size = New System.Drawing.Size(105, 13)
        CapitalILabel.TabIndex = 2
        CapitalILabel.Text = "Capital Integralizado:"
        '
        'DataExcSocialLabel
        '
        DataExcSocialLabel.AutoSize = True
        DataExcSocialLabel.Location = New System.Drawing.Point(254, 25)
        DataExcSocialLabel.Name = "DataExcSocialLabel"
        DataExcSocialLabel.Size = New System.Drawing.Size(128, 13)
        DataExcSocialLabel.TabIndex = 4
        DataExcSocialLabel.Text = "Data de Exercício Social:"
        '
        'RespMaeLabel
        '
        RespMaeLabel.AutoSize = True
        RespMaeLabel.Location = New System.Drawing.Point(21, 44)
        RespMaeLabel.Name = "RespMaeLabel"
        RespMaeLabel.Size = New System.Drawing.Size(31, 13)
        RespMaeLabel.TabIndex = 40
        RespMaeLabel.Text = "Mãe:"
        '
        'RespDataNascLabel
        '
        RespDataNascLabel.AutoSize = True
        RespDataNascLabel.Location = New System.Drawing.Point(288, 44)
        RespDataNascLabel.Name = "RespDataNascLabel"
        RespDataNascLabel.Size = New System.Drawing.Size(107, 13)
        RespDataNascLabel.TabIndex = 41
        RespDataNascLabel.Text = "Data de Nascimento:"
        '
        'CNHnumeroLabel
        '
        CNHnumeroLabel.AutoSize = True
        CNHnumeroLabel.Location = New System.Drawing.Point(3, 155)
        CNHnumeroLabel.Name = "CNHnumeroLabel"
        CNHnumeroLabel.Size = New System.Drawing.Size(51, 13)
        CNHnumeroLabel.TabIndex = 42
        CNHnumeroLabel.Text = "CNH N.º:"
        '
        'CNHexpLabel
        '
        CNHexpLabel.AutoSize = True
        CNHexpLabel.Location = New System.Drawing.Point(162, 157)
        CNHexpLabel.Name = "CNHexpLabel"
        CNHexpLabel.Size = New System.Drawing.Size(54, 13)
        CNHexpLabel.TabIndex = 43
        CNHexpLabel.Text = "Expedida:"
        '
        'CNHdataexpLabel
        '
        CNHdataexpLabel.AutoSize = True
        CNHdataexpLabel.Location = New System.Drawing.Point(303, 157)
        CNHdataexpLabel.Name = "CNHdataexpLabel"
        CNHdataexpLabel.Size = New System.Drawing.Size(69, 13)
        CNHdataexpLabel.TabIndex = 44
        CNHdataexpLabel.Text = "data de exp.:"
        '
        'CadImobLabel
        '
        CadImobLabel.AutoSize = True
        CadImobLabel.Location = New System.Drawing.Point(325, 79)
        CadImobLabel.Name = "CadImobLabel"
        CadImobLabel.Size = New System.Drawing.Size(101, 13)
        CadImobLabel.TabIndex = 29
        CadImobLabel.Text = "Cadastro Imobiliário:"
        '
        'EndZonaLabel
        '
        EndZonaLabel.AutoSize = True
        EndZonaLabel.Location = New System.Drawing.Point(25, 79)
        EndZonaLabel.Name = "EndZonaLabel"
        EndZonaLabel.Size = New System.Drawing.Size(35, 13)
        EndZonaLabel.TabIndex = 30
        EndZonaLabel.Text = "Zona:"
        '
        'EndQuadraLabel
        '
        EndQuadraLabel.AutoSize = True
        EndQuadraLabel.Location = New System.Drawing.Point(122, 79)
        EndQuadraLabel.Name = "EndQuadraLabel"
        EndQuadraLabel.Size = New System.Drawing.Size(45, 13)
        EndQuadraLabel.TabIndex = 31
        EndQuadraLabel.Text = "Quadra:"
        '
        'EndDataLabel
        '
        EndDataLabel.AutoSize = True
        EndDataLabel.Location = New System.Drawing.Point(223, 79)
        EndDataLabel.Name = "EndDataLabel"
        EndDataLabel.Size = New System.Drawing.Size(33, 13)
        EndDataLabel.TabIndex = 32
        EndDataLabel.Text = "Data:"
        '
        'ProcuracaoLabel
        '
        ProcuracaoLabel.AutoSize = True
        ProcuracaoLabel.Location = New System.Drawing.Point(12, 50)
        ProcuracaoLabel.Name = "ProcuracaoLabel"
        ProcuracaoLabel.Size = New System.Drawing.Size(125, 13)
        ProcuracaoLabel.TabIndex = 41
        ProcuracaoLabel.Text = "Situação da Procuracao:"
        '
        'ProcuracaoNLabel
        '
        ProcuracaoNLabel.AutoSize = True
        ProcuracaoNLabel.Location = New System.Drawing.Point(39, 94)
        ProcuracaoNLabel.Name = "ProcuracaoNLabel"
        ProcuracaoNLabel.Size = New System.Drawing.Size(98, 13)
        ProcuracaoNLabel.TabIndex = 42
        ProcuracaoNLabel.Text = "Nº. da Procuração:"
        '
        'ProcuracaoDataLabel
        '
        ProcuracaoDataLabel.AutoSize = True
        ProcuracaoDataLabel.Location = New System.Drawing.Point(36, 142)
        ProcuracaoDataLabel.Name = "ProcuracaoDataLabel"
        ProcuracaoDataLabel.Size = New System.Drawing.Size(101, 13)
        ProcuracaoDataLabel.TabIndex = 43
        ProcuracaoDataLabel.Text = "Data da solicitação:"
        '
        'NovaRazaoSocial1Label
        '
        NovaRazaoSocial1Label.AutoSize = True
        NovaRazaoSocial1Label.Location = New System.Drawing.Point(8, 59)
        NovaRazaoSocial1Label.Name = "NovaRazaoSocial1Label"
        NovaRazaoSocial1Label.Size = New System.Drawing.Size(117, 13)
        NovaRazaoSocial1Label.TabIndex = 0
        NovaRazaoSocial1Label.Text = "Razão Social Opção 1:"
        '
        'NovaRazaoSocial2Label
        '
        NovaRazaoSocial2Label.AutoSize = True
        NovaRazaoSocial2Label.Location = New System.Drawing.Point(8, 85)
        NovaRazaoSocial2Label.Name = "NovaRazaoSocial2Label"
        NovaRazaoSocial2Label.Size = New System.Drawing.Size(117, 13)
        NovaRazaoSocial2Label.TabIndex = 2
        NovaRazaoSocial2Label.Text = "Razão Social Opção 2:"
        '
        'NovaRazaoSocial3Label
        '
        NovaRazaoSocial3Label.AutoSize = True
        NovaRazaoSocial3Label.Location = New System.Drawing.Point(8, 111)
        NovaRazaoSocial3Label.Name = "NovaRazaoSocial3Label"
        NovaRazaoSocial3Label.Size = New System.Drawing.Size(117, 13)
        NovaRazaoSocial3Label.TabIndex = 4
        NovaRazaoSocial3Label.Text = "Razão Social Opção 3:"
        '
        'AvisarDiaLabel
        '
        AvisarDiaLabel.AutoSize = True
        AvisarDiaLabel.Location = New System.Drawing.Point(7, 43)
        AvisarDiaLabel.Name = "AvisarDiaLabel"
        AvisarDiaLabel.Size = New System.Drawing.Size(58, 13)
        AvisarDiaLabel.TabIndex = 20
        AvisarDiaLabel.Text = "Avisar Dia:"
        '
        'NomeFantasiaLabel1
        '
        NomeFantasiaLabel1.AutoSize = True
        NomeFantasiaLabel1.Location = New System.Drawing.Point(38, 138)
        NomeFantasiaLabel1.Name = "NomeFantasiaLabel1"
        NomeFantasiaLabel1.Size = New System.Drawing.Size(81, 13)
        NomeFantasiaLabel1.TabIndex = 8
        NomeFantasiaLabel1.Text = "Nome Fantasia:"
        '
        'RespPaiLabel
        '
        RespPaiLabel.AutoSize = True
        RespPaiLabel.Location = New System.Drawing.Point(29, 70)
        RespPaiLabel.Name = "RespPaiLabel"
        RespPaiLabel.Size = New System.Drawing.Size(25, 13)
        RespPaiLabel.TabIndex = 66
        RespPaiLabel.Text = "Pai:"
        '
        'IEOnlineLabel
        '
        IEOnlineLabel.AutoSize = True
        IEOnlineLabel.Location = New System.Drawing.Point(63, 17)
        IEOnlineLabel.Name = "IEOnlineLabel"
        IEOnlineLabel.Size = New System.Drawing.Size(43, 13)
        IEOnlineLabel.TabIndex = 38
        IEOnlineLabel.Text = "Pedido:"
        '
        'IETipoLabel
        '
        IETipoLabel.AutoSize = True
        IETipoLabel.Location = New System.Drawing.Point(205, 17)
        IETipoLabel.Name = "IETipoLabel"
        IETipoLabel.Size = New System.Drawing.Size(31, 13)
        IETipoLabel.TabIndex = 39
        IETipoLabel.Text = "Tipo:"
        '
        'IEeProcNumLabel
        '
        IEeProcNumLabel.AutoSize = True
        IEeProcNumLabel.Location = New System.Drawing.Point(32, 153)
        IEeProcNumLabel.Name = "IEeProcNumLabel"
        IEeProcNumLabel.Size = New System.Drawing.Size(75, 13)
        IEeProcNumLabel.TabIndex = 40
        IEeProcNumLabel.Text = "eProcesso Nº:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(11, 53)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(50, 13)
        Label10.TabIndex = 47
        Label10.Text = "Contrato:"
        '
        'SituacaoCadastralLabel
        '
        SituacaoCadastralLabel.AutoSize = True
        SituacaoCadastralLabel.Location = New System.Drawing.Point(423, 98)
        SituacaoCadastralLabel.Name = "SituacaoCadastralLabel"
        SituacaoCadastralLabel.Size = New System.Drawing.Size(99, 13)
        SituacaoCadastralLabel.TabIndex = 65
        SituacaoCadastralLabel.Text = "Situação Cadastral:"
        '
        'DivisaoCapitalSociosLabel
        '
        DivisaoCapitalSociosLabel.AutoSize = True
        DivisaoCapitalSociosLabel.Location = New System.Drawing.Point(6, 88)
        DivisaoCapitalSociosLabel.Name = "DivisaoCapitalSociosLabel"
        DivisaoCapitalSociosLabel.Size = New System.Drawing.Size(127, 13)
        DivisaoCapitalSociosLabel.TabIndex = 60
        DivisaoCapitalSociosLabel.Text = "Divisao de Capital Social:"
        '
        'EmpresasBindingNavigator
        '
        Me.EmpresasBindingNavigator.AddNewItem = Nothing
        Me.EmpresasBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.EmpresasBindingNavigator.BindingSource = Me.EmpresasBindingSource
        Me.EmpresasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasBindingNavigator.DeleteItem = Nothing
        Me.EmpresasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.EmpresasBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.EmpresasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasBindingNavigator.Name = "EmpresasBindingNavigator"
        Me.EmpresasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasBindingNavigator.Size = New System.Drawing.Size(757, 23)
        Me.EmpresasBindingNavigator.Stretch = True
        Me.EmpresasBindingNavigator.TabIndex = 0
        Me.EmpresasBindingNavigator.Text = "BindingNavigator1"
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Margin = New System.Windows.Forms.Padding(4)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 23)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(25, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(99, 69)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(528, 20)
        Me.RazaoSocialTextBox.TabIndex = 2
        '
        'NomeFantasiaTextBox
        '
        Me.NomeFantasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NomeFantasia", True))
        Me.NomeFantasiaTextBox.Location = New System.Drawing.Point(99, 95)
        Me.NomeFantasiaTextBox.Name = "NomeFantasiaTextBox"
        Me.NomeFantasiaTextBox.Size = New System.Drawing.Size(318, 20)
        Me.NomeFantasiaTextBox.TabIndex = 4
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(99, 43)
        Me.CNPJMaskedTextBox.Mask = "99,999,999/9999-99"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(107, 20)
        Me.CNPJMaskedTextBox.TabIndex = 6
        '
        'CADstatusBindingSource
        '
        Me.CADstatusBindingSource.DataMember = "CADstatus"
        Me.CADstatusBindingSource.DataSource = Me.PrinceDBDataSetBindingSource
        '
        'PrinceDBDataSetBindingSource
        '
        Me.PrinceDBDataSetBindingSource.DataSource = Me.PrinceDBDataSet
        Me.PrinceDBDataSetBindingSource.Position = 0
        '
        'TabControle
        '
        Me.TabControle.Controls.Add(Me.TabPage1)
        Me.TabControle.Controls.Add(Me.TabPage10)
        Me.TabControle.Controls.Add(Me.TabPage3)
        Me.TabControle.Controls.Add(Me.TabPage4)
        Me.TabControle.Controls.Add(Me.TabPage5)
        Me.TabControle.Controls.Add(Me.TabPage7)
        Me.TabControle.Controls.Add(Me.TabPage6)
        Me.TabControle.Controls.Add(Me.TabPage2)
        Me.TabControle.Controls.Add(Me.TabPage17)
        Me.TabControle.Location = New System.Drawing.Point(6, 163)
        Me.TabControle.Name = "TabControle"
        Me.TabControle.SelectedIndex = 0
        Me.TabControle.Size = New System.Drawing.Size(625, 265)
        Me.TabControle.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MotivoLabel)
        Me.TabPage1.Controls.Add(Me.Button46)
        Me.TabPage1.Controls.Add(Me.BtnListaEventos)
        Me.TabPage1.Controls.Add(Me.MotivoRichTextBox)
        Me.TabPage1.Controls.Add(ProcedimentoLabel)
        Me.TabPage1.Controls.Add(Me.ProcedimentoRichTextBox)
        Me.TabPage1.Controls.Add(GeralLabel)
        Me.TabPage1.Controls.Add(Me.GeralRichTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(617, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Geral"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MotivoLabel
        '
        Me.MotivoLabel.AutoSize = True
        Me.MotivoLabel.Location = New System.Drawing.Point(6, 20)
        Me.MotivoLabel.Name = "MotivoLabel"
        Me.MotivoLabel.Size = New System.Drawing.Size(42, 13)
        Me.MotivoLabel.TabIndex = 41
        Me.MotivoLabel.Text = "Motivo:"
        '
        'Button46
        '
        Me.Button46.Location = New System.Drawing.Point(166, 195)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(70, 38)
        Me.Button46.TabIndex = 42
        Me.Button46.Text = "Limpar de Eventos"
        Me.Button46.UseVisualStyleBackColor = True
        '
        'BtnListaEventos
        '
        Me.BtnListaEventos.Location = New System.Drawing.Point(242, 195)
        Me.BtnListaEventos.Name = "BtnListaEventos"
        Me.BtnListaEventos.Size = New System.Drawing.Size(70, 38)
        Me.BtnListaEventos.TabIndex = 41
        Me.BtnListaEventos.Text = "Lista de Eventos"
        Me.BtnListaEventos.UseVisualStyleBackColor = True
        '
        'MotivoRichTextBox
        '
        Me.MotivoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Motivo", True))
        Me.MotivoRichTextBox.Location = New System.Drawing.Point(6, 36)
        Me.MotivoRichTextBox.Name = "MotivoRichTextBox"
        Me.MotivoRichTextBox.Size = New System.Drawing.Size(306, 153)
        Me.MotivoRichTextBox.TabIndex = 43
        Me.MotivoRichTextBox.Text = ""
        '
        'ProcedimentoRichTextBox
        '
        Me.ProcedimentoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Procedimento", True))
        Me.ProcedimentoRichTextBox.Location = New System.Drawing.Point(337, 36)
        Me.ProcedimentoRichTextBox.Name = "ProcedimentoRichTextBox"
        Me.ProcedimentoRichTextBox.Size = New System.Drawing.Size(265, 103)
        Me.ProcedimentoRichTextBox.TabIndex = 3
        Me.ProcedimentoRichTextBox.Text = ""
        '
        'GeralRichTextBox
        '
        Me.GeralRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Geral", True))
        Me.GeralRichTextBox.Location = New System.Drawing.Point(337, 165)
        Me.GeralRichTextBox.Name = "GeralRichTextBox"
        Me.GeralRichTextBox.Size = New System.Drawing.Size(274, 68)
        Me.GeralRichTextBox.TabIndex = 1
        Me.GeralRichTextBox.Text = ""
        '
        'TabPage10
        '
        Me.TabPage10.AutoScroll = True
        Me.TabPage10.Controls.Add(Me.TabControl2)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(617, 239)
        Me.TabPage10.TabIndex = 6
        Me.TabPage10.Text = "Dados"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage12)
        Me.TabControl2.Controls.Add(Me.TabPage19)
        Me.TabControl2.Controls.Add(Me.TabPage13)
        Me.TabControl2.Controls.Add(Me.TabPage14)
        Me.TabControl2.Controls.Add(Me.TabPage15)
        Me.TabControl2.Controls.Add(Me.TabPage16)
        Me.TabControl2.Controls.Add(Me.TabPage18)
        Me.TabControl2.Location = New System.Drawing.Point(8, 9)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(572, 205)
        Me.TabControl2.TabIndex = 36
        '
        'TabPage12
        '
        Me.TabPage12.AutoScroll = True
        Me.TabPage12.Controls.Add(Me.BtnImportarSocioAdm)
        Me.TabPage12.Controls.Add(Me.BtnCopiarSenhaGov)
        Me.TabPage12.Controls.Add(RespPaiLabel)
        Me.TabPage12.Controls.Add(Me.SenhaGovLabel)
        Me.TabPage12.Controls.Add(Me.SenhaGovTextBox)
        Me.TabPage12.Controls.Add(Me.RespPaiTextBox)
        Me.TabPage12.Controls.Add(Me.RespRgSiglaTextBox)
        Me.TabPage12.Controls.Add(Me.Button44)
        Me.TabPage12.Controls.Add(Me.CNHdataexpMaskedTextBox)
        Me.TabPage12.Controls.Add(Me.CNHexpTextBox)
        Me.TabPage12.Controls.Add(CNHnumeroLabel)
        Me.TabPage12.Controls.Add(Me.CNHnumeroTextBox)
        Me.TabPage12.Controls.Add(RespDataNascLabel)
        Me.TabPage12.Controls.Add(Me.RespDataNascMaskedTextBox)
        Me.TabPage12.Controls.Add(RespMaeLabel)
        Me.TabPage12.Controls.Add(Me.RespMaeTextBox)
        Me.TabPage12.Controls.Add(Me.Button39)
        Me.TabPage12.Controls.Add(RespRGLabel)
        Me.TabPage12.Controls.Add(Me.NomeResponsavelTextBox)
        Me.TabPage12.Controls.Add(Me.RespRGTextBox)
        Me.TabPage12.Controls.Add(NomeResponsavelLabel)
        Me.TabPage12.Controls.Add(Me.TituloeleitorTextBox)
        Me.TabPage12.Controls.Add(Me.CPFResponsavelMaskedTextBox)
        Me.TabPage12.Controls.Add(TituloeleitorLabel)
        Me.TabPage12.Controls.Add(CPFResponsavelLabel)
        Me.TabPage12.Controls.Add(CNHexpLabel)
        Me.TabPage12.Controls.Add(CNHdataexpLabel)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(564, 179)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Responsável"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'BtnImportarSocioAdm
        '
        Me.BtnImportarSocioAdm.ForeColor = System.Drawing.Color.Green
        Me.BtnImportarSocioAdm.Location = New System.Drawing.Point(483, 70)
        Me.BtnImportarSocioAdm.Name = "BtnImportarSocioAdm"
        Me.BtnImportarSocioAdm.Size = New System.Drawing.Size(75, 49)
        Me.BtnImportarSocioAdm.TabIndex = 7
        Me.BtnImportarSocioAdm.Text = "Adicionar Socios"
        Me.BtnImportarSocioAdm.UseVisualStyleBackColor = True
        '
        'BtnCopiarSenhaGov
        '
        Me.BtnCopiarSenhaGov.BackColor = System.Drawing.Color.Transparent
        Me.BtnCopiarSenhaGov.BackgroundImage = CType(resources.GetObject("BtnCopiarSenhaGov.BackgroundImage"), System.Drawing.Image)
        Me.BtnCopiarSenhaGov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopiarSenhaGov.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiarSenhaGov.Location = New System.Drawing.Point(367, 126)
        Me.BtnCopiarSenhaGov.Name = "BtnCopiarSenhaGov"
        Me.BtnCopiarSenhaGov.Size = New System.Drawing.Size(42, 22)
        Me.BtnCopiarSenhaGov.TabIndex = 68
        Me.BtnCopiarSenhaGov.Text = "Copiar"
        Me.BtnCopiarSenhaGov.UseVisualStyleBackColor = False
        '
        'SenhaGovLabel
        '
        Me.SenhaGovLabel.AutoSize = True
        Me.SenhaGovLabel.Location = New System.Drawing.Point(187, 130)
        Me.SenhaGovLabel.Name = "SenhaGovLabel"
        Me.SenhaGovLabel.Size = New System.Drawing.Size(77, 13)
        Me.SenhaGovLabel.TabIndex = 66
        Me.SenhaGovLabel.Text = "Senha Gov.Br:"
        '
        'SenhaGovTextBox
        '
        Me.SenhaGovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "SenhaGov", True))
        Me.SenhaGovTextBox.Location = New System.Drawing.Point(264, 127)
        Me.SenhaGovTextBox.Name = "SenhaGovTextBox"
        Me.SenhaGovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SenhaGovTextBox.TabIndex = 65
        '
        'RespPaiTextBox
        '
        Me.RespPaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RespPai", True))
        Me.RespPaiTextBox.Location = New System.Drawing.Point(54, 67)
        Me.RespPaiTextBox.Name = "RespPaiTextBox"
        Me.RespPaiTextBox.Size = New System.Drawing.Size(225, 20)
        Me.RespPaiTextBox.TabIndex = 67
        '
        'RespRgSiglaTextBox
        '
        Me.RespRgSiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RespRgSigla", True))
        Me.RespRgSiglaTextBox.Location = New System.Drawing.Point(160, 100)
        Me.RespRgSiglaTextBox.Name = "RespRgSiglaTextBox"
        Me.RespRgSiglaTextBox.Size = New System.Drawing.Size(64, 20)
        Me.RespRgSiglaTextBox.TabIndex = 64
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.Transparent
        Me.Button44.BackgroundImage = CType(resources.GetObject("Button44.BackgroundImage"), System.Drawing.Image)
        Me.Button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button44.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(141, 125)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(42, 22)
        Me.Button44.TabIndex = 63
        Me.Button44.Text = "Copiar"
        Me.Button44.UseVisualStyleBackColor = False
        '
        'CNHdataexpMaskedTextBox
        '
        Me.CNHdataexpMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CNHdataexp", True))
        Me.CNHdataexpMaskedTextBox.Location = New System.Drawing.Point(370, 154)
        Me.CNHdataexpMaskedTextBox.Mask = "00/00/0000"
        Me.CNHdataexpMaskedTextBox.Name = "CNHdataexpMaskedTextBox"
        Me.CNHdataexpMaskedTextBox.Size = New System.Drawing.Size(66, 20)
        Me.CNHdataexpMaskedTextBox.TabIndex = 45
        Me.CNHdataexpMaskedTextBox.ValidatingType = GetType(Date)
        '
        'CNHexpTextBox
        '
        Me.CNHexpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CNHexp", True))
        Me.CNHexpTextBox.Location = New System.Drawing.Point(214, 154)
        Me.CNHexpTextBox.Name = "CNHexpTextBox"
        Me.CNHexpTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CNHexpTextBox.TabIndex = 44
        '
        'CNHnumeroTextBox
        '
        Me.CNHnumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CNHnumero", True))
        Me.CNHnumeroTextBox.Location = New System.Drawing.Point(54, 152)
        Me.CNHnumeroTextBox.Name = "CNHnumeroTextBox"
        Me.CNHnumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNHnumeroTextBox.TabIndex = 43
        '
        'RespDataNascMaskedTextBox
        '
        Me.RespDataNascMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RespDataNasc", True))
        Me.RespDataNascMaskedTextBox.Location = New System.Drawing.Point(395, 41)
        Me.RespDataNascMaskedTextBox.Mask = "00/00/0000"
        Me.RespDataNascMaskedTextBox.Name = "RespDataNascMaskedTextBox"
        Me.RespDataNascMaskedTextBox.Size = New System.Drawing.Size(68, 20)
        Me.RespDataNascMaskedTextBox.TabIndex = 42
        Me.RespDataNascMaskedTextBox.ValidatingType = GetType(Date)
        '
        'RespMaeTextBox
        '
        Me.RespMaeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RespMae", True))
        Me.RespMaeTextBox.Location = New System.Drawing.Point(54, 41)
        Me.RespMaeTextBox.Name = "RespMaeTextBox"
        Me.RespMaeTextBox.Size = New System.Drawing.Size(225, 20)
        Me.RespMaeTextBox.TabIndex = 41
        '
        'Button39
        '
        Me.Button39.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button39.Location = New System.Drawing.Point(421, 98)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(42, 22)
        Me.Button39.TabIndex = 40
        Me.Button39.Text = "TSE"
        Me.Button39.UseVisualStyleBackColor = True
        '
        'NomeResponsavelTextBox
        '
        Me.NomeResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NomeResponsavel", True))
        Me.NomeResponsavelTextBox.Location = New System.Drawing.Point(54, 15)
        Me.NomeResponsavelTextBox.Name = "NomeResponsavelTextBox"
        Me.NomeResponsavelTextBox.Size = New System.Drawing.Size(409, 20)
        Me.NomeResponsavelTextBox.TabIndex = 34
        '
        'RespRGTextBox
        '
        Me.RespRGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RespRG", True))
        Me.RespRGTextBox.Location = New System.Drawing.Point(54, 100)
        Me.RespRGTextBox.Name = "RespRGTextBox"
        Me.RespRGTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RespRGTextBox.TabIndex = 39
        '
        'TituloeleitorTextBox
        '
        Me.TituloeleitorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Tituloeleitor", True))
        Me.TituloeleitorTextBox.Location = New System.Drawing.Point(334, 99)
        Me.TituloeleitorTextBox.Name = "TituloeleitorTextBox"
        Me.TituloeleitorTextBox.Size = New System.Drawing.Size(86, 20)
        Me.TituloeleitorTextBox.TabIndex = 38
        '
        'CPFResponsavelMaskedTextBox
        '
        Me.CPFResponsavelMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CPFResponsavel", True))
        Me.CPFResponsavelMaskedTextBox.Location = New System.Drawing.Point(54, 126)
        Me.CPFResponsavelMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFResponsavelMaskedTextBox.Name = "CPFResponsavelMaskedTextBox"
        Me.CPFResponsavelMaskedTextBox.Size = New System.Drawing.Size(85, 20)
        Me.CPFResponsavelMaskedTextBox.TabIndex = 35
        '
        'TabPage19
        '
        Me.TabPage19.AutoScroll = True
        Me.TabPage19.Controls.Add(Me.BtnAddmaisSocio)
        Me.TabPage19.Controls.Add(Me.BtnLimparSocio)
        Me.TabPage19.Controls.Add(Me.BtnLimparSocios)
        Me.TabPage19.Controls.Add(Me.LblQuantidadeSocios)
        Me.TabPage19.Controls.Add(Me.QuantidadeSociosTextBox)
        Me.TabPage19.Controls.Add(Me.BtnAdicionarSocio)
        Me.TabPage19.Controls.Add(Me.DadosSociosRichTextBox)
        Me.TabPage19.Location = New System.Drawing.Point(4, 22)
        Me.TabPage19.Name = "TabPage19"
        Me.TabPage19.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage19.Size = New System.Drawing.Size(564, 179)
        Me.TabPage19.TabIndex = 6
        Me.TabPage19.Text = "Dados dos Sócios"
        Me.TabPage19.UseVisualStyleBackColor = True
        '
        'BtnAddmaisSocio
        '
        Me.BtnAddmaisSocio.Location = New System.Drawing.Point(519, 123)
        Me.BtnAddmaisSocio.Name = "BtnAddmaisSocio"
        Me.BtnAddmaisSocio.Size = New System.Drawing.Size(35, 23)
        Me.BtnAddmaisSocio.TabIndex = 7
        Me.BtnAddmaisSocio.Text = "+1"
        Me.BtnAddmaisSocio.UseVisualStyleBackColor = True
        '
        'BtnLimparSocio
        '
        Me.BtnLimparSocio.Location = New System.Drawing.Point(519, 150)
        Me.BtnLimparSocio.Name = "BtnLimparSocio"
        Me.BtnLimparSocio.Size = New System.Drawing.Size(35, 23)
        Me.BtnLimparSocio.TabIndex = 6
        Me.BtnLimparSocio.Text = "-1"
        Me.BtnLimparSocio.UseVisualStyleBackColor = True
        '
        'BtnLimparSocios
        '
        Me.BtnLimparSocios.ForeColor = System.Drawing.Color.Crimson
        Me.BtnLimparSocios.Location = New System.Drawing.Point(475, 65)
        Me.BtnLimparSocios.Name = "BtnLimparSocios"
        Me.BtnLimparSocios.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimparSocios.TabIndex = 5
        Me.BtnLimparSocios.Text = "Limpar Tudo"
        Me.BtnLimparSocios.UseVisualStyleBackColor = True
        '
        'LblQuantidadeSocios
        '
        Me.LblQuantidadeSocios.AutoSize = True
        Me.LblQuantidadeSocios.Location = New System.Drawing.Point(465, 107)
        Me.LblQuantidadeSocios.Name = "LblQuantidadeSocios"
        Me.LblQuantidadeSocios.Size = New System.Drawing.Size(88, 13)
        Me.LblQuantidadeSocios.TabIndex = 4
        Me.LblQuantidadeSocios.Text = "Total Cadastrado"
        '
        'QuantidadeSociosTextBox
        '
        Me.QuantidadeSociosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "QuantidadeSocios", True))
        Me.QuantidadeSociosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantidadeSociosTextBox.Location = New System.Drawing.Point(477, 136)
        Me.QuantidadeSociosTextBox.Name = "QuantidadeSociosTextBox"
        Me.QuantidadeSociosTextBox.ReadOnly = True
        Me.QuantidadeSociosTextBox.Size = New System.Drawing.Size(39, 22)
        Me.QuantidadeSociosTextBox.TabIndex = 3
        '
        'BtnAdicionarSocio
        '
        Me.BtnAdicionarSocio.Location = New System.Drawing.Point(473, 11)
        Me.BtnAdicionarSocio.Name = "BtnAdicionarSocio"
        Me.BtnAdicionarSocio.Size = New System.Drawing.Size(75, 48)
        Me.BtnAdicionarSocio.TabIndex = 2
        Me.BtnAdicionarSocio.Text = "Adicionar Sócio(a)"
        Me.BtnAdicionarSocio.UseVisualStyleBackColor = True
        '
        'DadosSociosRichTextBox
        '
        Me.DadosSociosRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DadosSocios", True))
        Me.DadosSociosRichTextBox.Location = New System.Drawing.Point(8, 11)
        Me.DadosSociosRichTextBox.Name = "DadosSociosRichTextBox"
        Me.DadosSociosRichTextBox.Size = New System.Drawing.Size(457, 162)
        Me.DadosSociosRichTextBox.TabIndex = 1
        Me.DadosSociosRichTextBox.Text = ""
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.GroupBox1)
        Me.TabPage13.Location = New System.Drawing.Point(4, 22)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(564, 179)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "Ramo/CNAE"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CnaeSimples)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button25)
        Me.GroupBox1.Controls.Add(Me.CNAESecundarioRichTextBox)
        Me.GroupBox1.Controls.Add(RamoDeAtividadeLabel)
        Me.GroupBox1.Controls.Add(Me.RamoDeAtividadeRichTextBox)
        Me.GroupBox1.Controls.Add(Me.CNAEPrincipalTextBox)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(CNAESecundarioLabel)
        Me.GroupBox1.Controls.Add(CNAEPrincipalLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 167)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atividades Economicas"
        '
        'CnaeSimples
        '
        Me.CnaeSimples.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.CnaeSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CnaeSimples.Location = New System.Drawing.Point(29, 124)
        Me.CnaeSimples.Name = "CnaeSimples"
        Me.CnaeSimples.Size = New System.Drawing.Size(107, 37)
        Me.CnaeSimples.TabIndex = 41
        Me.CnaeSimples.Text = "Verificar CNAE - Simples Nacional"
        Me.CnaeSimples.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "CNAE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Buscar CNAE:"
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Location = New System.Drawing.Point(457, 82)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(82, 24)
        Me.Button25.TabIndex = 34
        Me.Button25.Text = "CNAE - MEI"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'CNAESecundarioRichTextBox
        '
        Me.CNAESecundarioRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CNAESecundario", True))
        Me.CNAESecundarioRichTextBox.Location = New System.Drawing.Point(66, 58)
        Me.CNAESecundarioRichTextBox.Name = "CNAESecundarioRichTextBox"
        Me.CNAESecundarioRichTextBox.Size = New System.Drawing.Size(81, 60)
        Me.CNAESecundarioRichTextBox.TabIndex = 33
        Me.CNAESecundarioRichTextBox.Text = ""
        '
        'RamoDeAtividadeRichTextBox
        '
        Me.RamoDeAtividadeRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RamoDeAtividade", True))
        Me.RamoDeAtividadeRichTextBox.Location = New System.Drawing.Point(153, 32)
        Me.RamoDeAtividadeRichTextBox.Name = "RamoDeAtividadeRichTextBox"
        Me.RamoDeAtividadeRichTextBox.Size = New System.Drawing.Size(298, 117)
        Me.RamoDeAtividadeRichTextBox.TabIndex = 32
        Me.RamoDeAtividadeRichTextBox.Text = ""
        '
        'CNAEPrincipalTextBox
        '
        Me.CNAEPrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CNAEPrincipal", True))
        Me.CNAEPrincipalTextBox.Location = New System.Drawing.Point(66, 32)
        Me.CNAEPrincipalTextBox.Name = "CNAEPrincipalTextBox"
        Me.CNAEPrincipalTextBox.Size = New System.Drawing.Size(81, 20)
        Me.CNAEPrincipalTextBox.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(457, 52)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 24)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "CNAE - Geral"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabPage14
        '
        Me.TabPage14.AutoScroll = True
        Me.TabPage14.Controls.Add(Me.EndPaisTextBox)
        Me.TabPage14.Controls.Add(Me.EndCidadeTextBox)
        Me.TabPage14.Controls.Add(Me.EndComplementoTextBox)
        Me.TabPage14.Controls.Add(Me.EndBairroTextBox)
        Me.TabPage14.Controls.Add(Me.EnderecoTextBox)
        Me.TabPage14.Controls.Add(EndDataLabel)
        Me.TabPage14.Controls.Add(Me.EndDataTextBox)
        Me.TabPage14.Controls.Add(EndQuadraLabel)
        Me.TabPage14.Controls.Add(Me.EndQuadraTextBox)
        Me.TabPage14.Controls.Add(EndZonaLabel)
        Me.TabPage14.Controls.Add(Me.EndZonaTextBox)
        Me.TabPage14.Controls.Add(Me.CadImobTextBox)
        Me.TabPage14.Controls.Add(Area2Label)
        Me.TabPage14.Controls.Add(Me.EndCEPMaskedTextBox)
        Me.TabPage14.Controls.Add(Me.Area2TextBox)
        Me.TabPage14.Controls.Add(EndBairroLabel)
        Me.TabPage14.Controls.Add(AreaLabel)
        Me.TabPage14.Controls.Add(EndNumeroLabel)
        Me.TabPage14.Controls.Add(EndComplementoLabel)
        Me.TabPage14.Controls.Add(Me.AreaTextBox)
        Me.TabPage14.Controls.Add(EndCEPLabel)
        Me.TabPage14.Controls.Add(Me.LinkLabel10)
        Me.TabPage14.Controls.Add(EndPaisLabel)
        Me.TabPage14.Controls.Add(Me.EndEstadoTextBox)
        Me.TabPage14.Controls.Add(Me.EndNumeroTextBox)
        Me.TabPage14.Controls.Add(Me.Button3)
        Me.TabPage14.Controls.Add(EnderecoLabel)
        Me.TabPage14.Controls.Add(EndEstadoLabel)
        Me.TabPage14.Controls.Add(EndCidadeLabel)
        Me.TabPage14.Controls.Add(CadImobLabel)
        Me.TabPage14.Location = New System.Drawing.Point(4, 22)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Size = New System.Drawing.Size(564, 179)
        Me.TabPage14.TabIndex = 2
        Me.TabPage14.Text = "Endereço"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'EndPaisTextBox
        '
        Me.EndPaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndPais", True))
        Me.EndPaisTextBox.Location = New System.Drawing.Point(378, 127)
        Me.EndPaisTextBox.Name = "EndPaisTextBox"
        Me.EndPaisTextBox.Size = New System.Drawing.Size(179, 20)
        Me.EndPaisTextBox.TabIndex = 38
        '
        'EndCidadeTextBox
        '
        Me.EndCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndCidade", True))
        Me.EndCidadeTextBox.Location = New System.Drawing.Point(69, 127)
        Me.EndCidadeTextBox.Name = "EndCidadeTextBox"
        Me.EndCidadeTextBox.Size = New System.Drawing.Size(170, 20)
        Me.EndCidadeTextBox.TabIndex = 37
        '
        'EndComplementoTextBox
        '
        Me.EndComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndComplemento", True))
        Me.EndComplementoTextBox.Location = New System.Drawing.Point(369, 101)
        Me.EndComplementoTextBox.Name = "EndComplementoTextBox"
        Me.EndComplementoTextBox.Size = New System.Drawing.Size(188, 20)
        Me.EndComplementoTextBox.TabIndex = 36
        '
        'EndBairroTextBox
        '
        Me.EndBairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndBairro", True))
        Me.EndBairroTextBox.Location = New System.Drawing.Point(69, 101)
        Me.EndBairroTextBox.Name = "EndBairroTextBox"
        Me.EndBairroTextBox.Size = New System.Drawing.Size(214, 20)
        Me.EndBairroTextBox.TabIndex = 35
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(69, 50)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(384, 20)
        Me.EnderecoTextBox.TabIndex = 34
        '
        'EndDataTextBox
        '
        Me.EndDataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndData", True))
        Me.EndDataTextBox.Location = New System.Drawing.Point(262, 76)
        Me.EndDataTextBox.Name = "EndDataTextBox"
        Me.EndDataTextBox.Size = New System.Drawing.Size(47, 20)
        Me.EndDataTextBox.TabIndex = 33
        '
        'EndQuadraTextBox
        '
        Me.EndQuadraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndQuadra", True))
        Me.EndQuadraTextBox.Location = New System.Drawing.Point(170, 76)
        Me.EndQuadraTextBox.Name = "EndQuadraTextBox"
        Me.EndQuadraTextBox.Size = New System.Drawing.Size(47, 20)
        Me.EndQuadraTextBox.TabIndex = 32
        '
        'EndZonaTextBox
        '
        Me.EndZonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndZona", True))
        Me.EndZonaTextBox.Location = New System.Drawing.Point(69, 76)
        Me.EndZonaTextBox.Name = "EndZonaTextBox"
        Me.EndZonaTextBox.Size = New System.Drawing.Size(47, 20)
        Me.EndZonaTextBox.TabIndex = 31
        '
        'CadImobTextBox
        '
        Me.CadImobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CadImob", True))
        Me.CadImobTextBox.Location = New System.Drawing.Point(424, 76)
        Me.CadImobTextBox.Name = "CadImobTextBox"
        Me.CadImobTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CadImobTextBox.TabIndex = 30
        '
        'EndCEPMaskedTextBox
        '
        Me.EndCEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndCEP", True))
        Me.EndCEPMaskedTextBox.Location = New System.Drawing.Point(69, 24)
        Me.EndCEPMaskedTextBox.Mask = "00000-000"
        Me.EndCEPMaskedTextBox.Name = "EndCEPMaskedTextBox"
        Me.EndCEPMaskedTextBox.Size = New System.Drawing.Size(62, 20)
        Me.EndCEPMaskedTextBox.TabIndex = 9
        '
        'Area2TextBox
        '
        Me.Area2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "area2", True))
        Me.Area2TextBox.Location = New System.Drawing.Point(332, 153)
        Me.Area2TextBox.Name = "Area2TextBox"
        Me.Area2TextBox.Size = New System.Drawing.Size(49, 20)
        Me.Area2TextBox.TabIndex = 29
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(123, 153)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(49, 20)
        Me.AreaTextBox.TabIndex = 27
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.Location = New System.Drawing.Point(473, 11)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(84, 13)
        Me.LinkLabel10.TabIndex = 26
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "Site Correios BR"
        '
        'EndEstadoTextBox
        '
        Me.EndEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndEstado", True))
        Me.EndEstadoTextBox.Location = New System.Drawing.Point(294, 127)
        Me.EndEstadoTextBox.Name = "EndEstadoTextBox"
        Me.EndEstadoTextBox.Size = New System.Drawing.Size(40, 20)
        Me.EndEstadoTextBox.TabIndex = 14
        '
        'EndNumeroTextBox
        '
        Me.EndNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EndNumero", True))
        Me.EndNumeroTextBox.Location = New System.Drawing.Point(508, 50)
        Me.EndNumeroTextBox.Name = "EndNumeroTextBox"
        Me.EndNumeroTextBox.Size = New System.Drawing.Size(49, 20)
        Me.EndNumeroTextBox.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(135, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 21)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Preencher"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(PaginaWebLabel)
        Me.TabPage15.Controls.Add(Me.EmpTel1TextBox)
        Me.TabPage15.Controls.Add(EmpTel1Label)
        Me.TabPage15.Controls.Add(Me.EmpEmailTextBox)
        Me.TabPage15.Controls.Add(Me.PaginaWebTextBox)
        Me.TabPage15.Controls.Add(Me.EmpTel2TextBox)
        Me.TabPage15.Controls.Add(EmpTel2Label)
        Me.TabPage15.Controls.Add(EmpEmailLabel)
        Me.TabPage15.Location = New System.Drawing.Point(4, 22)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Size = New System.Drawing.Size(564, 179)
        Me.TabPage15.TabIndex = 3
        Me.TabPage15.Text = "Telefone/Outros"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'EmpTel1TextBox
        '
        Me.EmpTel1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EmpTel1", True))
        Me.EmpTel1TextBox.Location = New System.Drawing.Point(79, 12)
        Me.EmpTel1TextBox.Name = "EmpTel1TextBox"
        Me.EmpTel1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmpTel1TextBox.TabIndex = 14
        '
        'EmpEmailTextBox
        '
        Me.EmpEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EmpEmail", True))
        Me.EmpEmailTextBox.Location = New System.Drawing.Point(79, 64)
        Me.EmpEmailTextBox.MaxLength = 1000
        Me.EmpEmailTextBox.Name = "EmpEmailTextBox"
        Me.EmpEmailTextBox.Size = New System.Drawing.Size(309, 20)
        Me.EmpEmailTextBox.TabIndex = 22
        '
        'PaginaWebTextBox
        '
        Me.PaginaWebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "PaginaWeb", True))
        Me.PaginaWebTextBox.Location = New System.Drawing.Point(79, 90)
        Me.PaginaWebTextBox.MaxLength = 1000
        Me.PaginaWebTextBox.Name = "PaginaWebTextBox"
        Me.PaginaWebTextBox.Size = New System.Drawing.Size(309, 20)
        Me.PaginaWebTextBox.TabIndex = 24
        '
        'EmpTel2TextBox
        '
        Me.EmpTel2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EmpTel2", True))
        Me.EmpTel2TextBox.Location = New System.Drawing.Point(79, 38)
        Me.EmpTel2TextBox.Name = "EmpTel2TextBox"
        Me.EmpTel2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmpTel2TextBox.TabIndex = 16
        '
        'TabPage16
        '
        Me.TabPage16.AutoScroll = True
        Me.TabPage16.Controls.Add(DivisaoCapitalSociosLabel)
        Me.TabPage16.Controls.Add(Me.DivisaoCapitalSociosRichTextBox)
        Me.TabPage16.Controls.Add(Me.Button1)
        Me.TabPage16.Controls.Add(Me.ButtonCalcCapSocial)
        Me.TabPage16.Controls.Add(Me.CapitalITextBox)
        Me.TabPage16.Controls.Add(Me.CapitalSTextBox)
        Me.TabPage16.Controls.Add(DataExcSocialLabel)
        Me.TabPage16.Controls.Add(Me.DataExcSocialMaskedTextBox)
        Me.TabPage16.Controls.Add(CapitalILabel)
        Me.TabPage16.Controls.Add(CapitalSLabel)
        Me.TabPage16.Controls.Add(Me.Label8)
        Me.TabPage16.Location = New System.Drawing.Point(4, 22)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage16.Size = New System.Drawing.Size(564, 179)
        Me.TabPage16.TabIndex = 4
        Me.TabPage16.Text = "Capital Social"
        Me.TabPage16.UseVisualStyleBackColor = True
        '
        'DivisaoCapitalSociosRichTextBox
        '
        Me.DivisaoCapitalSociosRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DivisaoCapitalSocios", True))
        Me.DivisaoCapitalSociosRichTextBox.Location = New System.Drawing.Point(9, 104)
        Me.DivisaoCapitalSociosRichTextBox.Name = "DivisaoCapitalSociosRichTextBox"
        Me.DivisaoCapitalSociosRichTextBox.Size = New System.Drawing.Size(267, 67)
        Me.DivisaoCapitalSociosRichTextBox.TabIndex = 61
        Me.DivisaoCapitalSociosRichTextBox.Text = ""
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(282, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 31)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonCalcCapSocial
        '
        Me.ButtonCalcCapSocial.BackgroundImage = CType(resources.GetObject("ButtonCalcCapSocial.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCalcCapSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCalcCapSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalcCapSocial.Location = New System.Drawing.Point(429, 51)
        Me.ButtonCalcCapSocial.Name = "ButtonCalcCapSocial"
        Me.ButtonCalcCapSocial.Size = New System.Drawing.Size(117, 56)
        Me.ButtonCalcCapSocial.TabIndex = 58
        Me.ButtonCalcCapSocial.Text = "Calculadora de Capital Social"
        Me.ButtonCalcCapSocial.UseVisualStyleBackColor = True
        '
        'CapitalITextBox
        '
        Me.CapitalITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CapitalI", True))
        Me.CapitalITextBox.Location = New System.Drawing.Point(117, 48)
        Me.CapitalITextBox.Name = "CapitalITextBox"
        Me.CapitalITextBox.Size = New System.Drawing.Size(117, 20)
        Me.CapitalITextBox.TabIndex = 9
        '
        'CapitalSTextBox
        '
        Me.CapitalSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CapitalS", True))
        Me.CapitalSTextBox.Location = New System.Drawing.Point(117, 22)
        Me.CapitalSTextBox.Name = "CapitalSTextBox"
        Me.CapitalSTextBox.Size = New System.Drawing.Size(117, 20)
        Me.CapitalSTextBox.TabIndex = 7
        '
        'DataExcSocialMaskedTextBox
        '
        Me.DataExcSocialMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataExcSocial", True))
        Me.DataExcSocialMaskedTextBox.Location = New System.Drawing.Point(382, 22)
        Me.DataExcSocialMaskedTextBox.Mask = "99/99"
        Me.DataExcSocialMaskedTextBox.Name = "DataExcSocialMaskedTextBox"
        Me.DataExcSocialMaskedTextBox.Size = New System.Drawing.Size(44, 20)
        Me.DataExcSocialMaskedTextBox.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 12)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Padrão: 31/12"
        '
        'TabPage18
        '
        Me.TabPage18.AutoScroll = True
        Me.TabPage18.Controls.Add(Me.BtnUsarNomeFantasia)
        Me.TabPage18.Controls.Add(Me.BtnUsarRazao3)
        Me.TabPage18.Controls.Add(Me.BtnUsarRazao2)
        Me.TabPage18.Controls.Add(Me.BtnUsarRazao1)
        Me.TabPage18.Controls.Add(Me.RazaoSocialAntigaLabel)
        Me.TabPage18.Controls.Add(Me.BtnImportarRazaoSocial)
        Me.TabPage18.Controls.Add(Me.RazaoSocialAntigaTextBox)
        Me.TabPage18.Controls.Add(NomeFantasiaLabel1)
        Me.TabPage18.Controls.Add(Me.NomeFantasiaTextBox1)
        Me.TabPage18.Controls.Add(NovaRazaoSocial3Label)
        Me.TabPage18.Controls.Add(Me.NovaRazaoSocial3TextBox)
        Me.TabPage18.Controls.Add(NovaRazaoSocial2Label)
        Me.TabPage18.Controls.Add(Me.NovaRazaoSocial2TextBox)
        Me.TabPage18.Controls.Add(NovaRazaoSocial1Label)
        Me.TabPage18.Controls.Add(Me.NovaRazaoSocial1TextBox)
        Me.TabPage18.Location = New System.Drawing.Point(4, 22)
        Me.TabPage18.Name = "TabPage18"
        Me.TabPage18.Size = New System.Drawing.Size(564, 179)
        Me.TabPage18.TabIndex = 5
        Me.TabPage18.Text = "Busca de Nome"
        Me.TabPage18.UseVisualStyleBackColor = True
        '
        'BtnUsarNomeFantasia
        '
        Me.BtnUsarNomeFantasia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsarNomeFantasia.Location = New System.Drawing.Point(477, 135)
        Me.BtnUsarNomeFantasia.Name = "BtnUsarNomeFantasia"
        Me.BtnUsarNomeFantasia.Size = New System.Drawing.Size(40, 23)
        Me.BtnUsarNomeFantasia.TabIndex = 50
        Me.BtnUsarNomeFantasia.Text = "Usar"
        Me.BtnUsarNomeFantasia.UseVisualStyleBackColor = True
        '
        'BtnUsarRazao3
        '
        Me.BtnUsarRazao3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsarRazao3.Location = New System.Drawing.Point(477, 106)
        Me.BtnUsarRazao3.Name = "BtnUsarRazao3"
        Me.BtnUsarRazao3.Size = New System.Drawing.Size(40, 23)
        Me.BtnUsarRazao3.TabIndex = 49
        Me.BtnUsarRazao3.Text = "Usar"
        Me.BtnUsarRazao3.UseVisualStyleBackColor = True
        '
        'BtnUsarRazao2
        '
        Me.BtnUsarRazao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsarRazao2.Location = New System.Drawing.Point(477, 80)
        Me.BtnUsarRazao2.Name = "BtnUsarRazao2"
        Me.BtnUsarRazao2.Size = New System.Drawing.Size(40, 23)
        Me.BtnUsarRazao2.TabIndex = 48
        Me.BtnUsarRazao2.Text = "Usar"
        Me.BtnUsarRazao2.UseVisualStyleBackColor = True
        '
        'BtnUsarRazao1
        '
        Me.BtnUsarRazao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsarRazao1.Location = New System.Drawing.Point(477, 54)
        Me.BtnUsarRazao1.Name = "BtnUsarRazao1"
        Me.BtnUsarRazao1.Size = New System.Drawing.Size(40, 23)
        Me.BtnUsarRazao1.TabIndex = 47
        Me.BtnUsarRazao1.Text = "Usar"
        Me.BtnUsarRazao1.UseVisualStyleBackColor = True
        '
        'RazaoSocialAntigaLabel
        '
        Me.RazaoSocialAntigaLabel.AutoSize = True
        Me.RazaoSocialAntigaLabel.Location = New System.Drawing.Point(13, 19)
        Me.RazaoSocialAntigaLabel.Name = "RazaoSocialAntigaLabel"
        Me.RazaoSocialAntigaLabel.Size = New System.Drawing.Size(106, 13)
        Me.RazaoSocialAntigaLabel.TabIndex = 46
        Me.RazaoSocialAntigaLabel.Text = "Razão Social Antiga:"
        '
        'BtnImportarRazaoSocial
        '
        Me.BtnImportarRazaoSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportarRazaoSocial.Location = New System.Drawing.Point(477, 14)
        Me.BtnImportarRazaoSocial.Name = "BtnImportarRazaoSocial"
        Me.BtnImportarRazaoSocial.Size = New System.Drawing.Size(62, 23)
        Me.BtnImportarRazaoSocial.TabIndex = 45
        Me.BtnImportarRazaoSocial.Text = "Importar"
        Me.BtnImportarRazaoSocial.UseVisualStyleBackColor = True
        '
        'RazaoSocialAntigaTextBox
        '
        Me.RazaoSocialAntigaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RazaoSocialAntiga", True))
        Me.RazaoSocialAntigaTextBox.Location = New System.Drawing.Point(125, 16)
        Me.RazaoSocialAntigaTextBox.Name = "RazaoSocialAntigaTextBox"
        Me.RazaoSocialAntigaTextBox.Size = New System.Drawing.Size(346, 20)
        Me.RazaoSocialAntigaTextBox.TabIndex = 10
        '
        'NomeFantasiaTextBox1
        '
        Me.NomeFantasiaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NomeFantasia", True))
        Me.NomeFantasiaTextBox1.Location = New System.Drawing.Point(125, 135)
        Me.NomeFantasiaTextBox1.Name = "NomeFantasiaTextBox1"
        Me.NomeFantasiaTextBox1.Size = New System.Drawing.Size(346, 20)
        Me.NomeFantasiaTextBox1.TabIndex = 9
        '
        'NovaRazaoSocial3TextBox
        '
        Me.NovaRazaoSocial3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NovaRazaoSocial3", True))
        Me.NovaRazaoSocial3TextBox.Location = New System.Drawing.Point(125, 108)
        Me.NovaRazaoSocial3TextBox.Name = "NovaRazaoSocial3TextBox"
        Me.NovaRazaoSocial3TextBox.Size = New System.Drawing.Size(346, 20)
        Me.NovaRazaoSocial3TextBox.TabIndex = 5
        '
        'NovaRazaoSocial2TextBox
        '
        Me.NovaRazaoSocial2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NovaRazaoSocial2", True))
        Me.NovaRazaoSocial2TextBox.Location = New System.Drawing.Point(125, 82)
        Me.NovaRazaoSocial2TextBox.Name = "NovaRazaoSocial2TextBox"
        Me.NovaRazaoSocial2TextBox.Size = New System.Drawing.Size(346, 20)
        Me.NovaRazaoSocial2TextBox.TabIndex = 3
        '
        'NovaRazaoSocial1TextBox
        '
        Me.NovaRazaoSocial1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NovaRazaoSocial1", True))
        Me.NovaRazaoSocial1TextBox.Location = New System.Drawing.Point(125, 56)
        Me.NovaRazaoSocial1TextBox.Name = "NovaRazaoSocial1TextBox"
        Me.NovaRazaoSocial1TextBox.Size = New System.Drawing.Size(346, 20)
        Me.NovaRazaoSocial1TextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.BtnAnotacoesLEgalizacao)
        Me.TabPage3.Controls.Add(Me.BtnData3)
        Me.TabPage3.Controls.Add(Me.BtnData2)
        Me.TabPage3.Controls.Add(Me.LinkLabelMudarRazaoSocial)
        Me.TabPage3.Controls.Add(Me.LabelNovaRazaoFinal)
        Me.TabPage3.Controls.Add(Me.NovaRazaoSocialFinalTextBox)
        Me.TabPage3.Controls.Add(Me.Button48)
        Me.TabPage3.Controls.Add(Me.TabControl1)
        Me.TabPage3.Controls.Add(Me.Button30)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Controls.Add(ProtJuntaFinalLabel)
        Me.TabPage3.Controls.Add(Me.ProtJuntaFinalMaskedTextBox)
        Me.TabPage3.Controls.Add(JuntaObsLabel)
        Me.TabPage3.Controls.Add(Me.JuntaObsRichTextBox)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.DataProtJuntaComercialMaskedTextBox)
        Me.TabPage3.Controls.Add(DataProtJuntaComercialLabel)
        Me.TabPage3.Controls.Add(Me.BtnConsultaJunta)
        Me.TabPage3.Controls.Add(ProtocoloJuntaComercialLabel)
        Me.TabPage3.Controls.Add(Me.ProtocoloJuntaComercialTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(617, 239)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Junta Comercial"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnAnotacoesLEgalizacao
        '
        Me.BtnAnotacoesLEgalizacao.BackgroundImage = CType(resources.GetObject("BtnAnotacoesLEgalizacao.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesLEgalizacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesLEgalizacao.Location = New System.Drawing.Point(536, 11)
        Me.BtnAnotacoesLEgalizacao.Name = "BtnAnotacoesLEgalizacao"
        Me.BtnAnotacoesLEgalizacao.Size = New System.Drawing.Size(69, 23)
        Me.BtnAnotacoesLEgalizacao.TabIndex = 71
        Me.BtnAnotacoesLEgalizacao.Text = "Anotações"
        Me.BtnAnotacoesLEgalizacao.UseVisualStyleBackColor = True
        '
        'BtnData3
        '
        Me.BtnData3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnData3.Location = New System.Drawing.Point(265, 62)
        Me.BtnData3.Name = "BtnData3"
        Me.BtnData3.Size = New System.Drawing.Size(43, 21)
        Me.BtnData3.TabIndex = 52
        Me.BtnData3.Text = "Agora"
        Me.BtnData3.UseVisualStyleBackColor = True
        '
        'BtnData2
        '
        Me.BtnData2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnData2.Location = New System.Drawing.Point(265, 10)
        Me.BtnData2.Name = "BtnData2"
        Me.BtnData2.Size = New System.Drawing.Size(43, 21)
        Me.BtnData2.TabIndex = 51
        Me.BtnData2.Text = "Agora"
        Me.BtnData2.UseVisualStyleBackColor = True
        '
        'LinkLabelMudarRazaoSocial
        '
        Me.LinkLabelMudarRazaoSocial.AutoSize = True
        Me.LinkLabelMudarRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.LinkLabelMudarRazaoSocial.Location = New System.Drawing.Point(198, 135)
        Me.LinkLabelMudarRazaoSocial.Name = "LinkLabelMudarRazaoSocial"
        Me.LinkLabelMudarRazaoSocial.Size = New System.Drawing.Size(101, 13)
        Me.LinkLabelMudarRazaoSocial.TabIndex = 50
        Me.LinkLabelMudarRazaoSocial.TabStop = True
        Me.LinkLabelMudarRazaoSocial.Text = "Mudar Razão Social"
        '
        'LabelNovaRazaoFinal
        '
        Me.LabelNovaRazaoFinal.AutoSize = True
        Me.LabelNovaRazaoFinal.Location = New System.Drawing.Point(8, 99)
        Me.LabelNovaRazaoFinal.Name = "LabelNovaRazaoFinal"
        Me.LabelNovaRazaoFinal.Size = New System.Drawing.Size(147, 13)
        Me.LabelNovaRazaoFinal.TabIndex = 49
        Me.LabelNovaRazaoFinal.Text = "Resultado- nova razão social:"
        '
        'NovaRazaoSocialFinalTextBox
        '
        Me.NovaRazaoSocialFinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NovaRazaoSocialFinal", True))
        Me.NovaRazaoSocialFinalTextBox.Location = New System.Drawing.Point(14, 115)
        Me.NovaRazaoSocialFinalTextBox.Name = "NovaRazaoSocialFinalTextBox"
        Me.NovaRazaoSocialFinalTextBox.Size = New System.Drawing.Size(285, 20)
        Me.NovaRazaoSocialFinalTextBox.TabIndex = 48
        '
        'Button48
        '
        Me.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button48.Location = New System.Drawing.Point(320, 10)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(60, 24)
        Me.Button48.TabIndex = 47
        Me.Button48.Text = "Eventos"
        Me.Button48.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage20)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Location = New System.Drawing.Point(317, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(292, 190)
        Me.TabControl1.TabIndex = 46
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.GroupBox6)
        Me.TabPage9.Controls.Add(Me.GroupBox5)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(284, 164)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "NIRE"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button22)
        Me.GroupBox6.Controls.Add(NireDataLabel)
        Me.GroupBox6.Controls.Add(Me.NireDataMaskedTextBox)
        Me.GroupBox6.Controls.Add(NIRELabel)
        Me.GroupBox6.Controls.Add(Me.NIRETextBox)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(221, 67)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Nire Abertura"
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Location = New System.Drawing.Point(154, 16)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(62, 38)
        Me.Button22.TabIndex = 41
        Me.Button22.Text = "Simples Nacional"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'NireDataMaskedTextBox
        '
        Me.NireDataMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NireData", True))
        Me.NireDataMaskedTextBox.Location = New System.Drawing.Point(64, 39)
        Me.NireDataMaskedTextBox.Mask = "00/00/0000"
        Me.NireDataMaskedTextBox.Name = "NireDataMaskedTextBox"
        Me.NireDataMaskedTextBox.Size = New System.Drawing.Size(69, 20)
        Me.NireDataMaskedTextBox.TabIndex = 23
        Me.NireDataMaskedTextBox.ValidatingType = GetType(Date)
        '
        'NIRETextBox
        '
        Me.NIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NIRE", True))
        Me.NIRETextBox.Location = New System.Drawing.Point(64, 16)
        Me.NIRETextBox.Name = "NIRETextBox"
        Me.NIRETextBox.Size = New System.Drawing.Size(87, 20)
        Me.NIRETextBox.TabIndex = 22
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(AltProtLabel)
        Me.GroupBox5.Controls.Add(NRegistroAltLabel)
        Me.GroupBox5.Controls.Add(Me.AltProtComboBox)
        Me.GroupBox5.Controls.Add(DataRegistroAltLabel)
        Me.GroupBox5.Controls.Add(Me.NRegistroAltTextBox)
        Me.GroupBox5.Controls.Add(Me.DataRegistroAltMaskedTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 85)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(221, 67)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Alteração / Baixa"
        '
        'AltProtComboBox
        '
        Me.AltProtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "AltProt", True))
        Me.AltProtComboBox.FormattingEnabled = True
        Me.AltProtComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22+"})
        Me.AltProtComboBox.Location = New System.Drawing.Point(4, 15)
        Me.AltProtComboBox.Name = "AltProtComboBox"
        Me.AltProtComboBox.Size = New System.Drawing.Size(34, 21)
        Me.AltProtComboBox.TabIndex = 50
        '
        'NRegistroAltTextBox
        '
        Me.NRegistroAltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NRegistroAlt", True))
        Me.NRegistroAltTextBox.Location = New System.Drawing.Point(129, 16)
        Me.NRegistroAltTextBox.Name = "NRegistroAltTextBox"
        Me.NRegistroAltTextBox.Size = New System.Drawing.Size(87, 20)
        Me.NRegistroAltTextBox.TabIndex = 32
        '
        'DataRegistroAltMaskedTextBox
        '
        Me.DataRegistroAltMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataRegistroAlt", True))
        Me.DataRegistroAltMaskedTextBox.Location = New System.Drawing.Point(129, 39)
        Me.DataRegistroAltMaskedTextBox.Mask = "00/00/0000"
        Me.DataRegistroAltMaskedTextBox.Name = "DataRegistroAltMaskedTextBox"
        Me.DataRegistroAltMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.DataRegistroAltMaskedTextBox.TabIndex = 31
        Me.DataRegistroAltMaskedTextBox.ValidatingType = GetType(Date)
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.BtnArrumar)
        Me.TabPage8.Controls.Add(Me.Button41)
        Me.TabPage8.Controls.Add(Me.Button40)
        Me.TabPage8.Controls.Add(ArquivoContratoLabel)
        Me.TabPage8.Controls.Add(Me.Button31)
        Me.TabPage8.Controls.Add(Me.PastaDocumentosTextBox)
        Me.TabPage8.Controls.Add(Me.Button15)
        Me.TabPage8.Controls.Add(Me.Button14)
        Me.TabPage8.Controls.Add(PastaDocumentosLabel)
        Me.TabPage8.Controls.Add(Me.ArquivoContratoTextBox)
        Me.TabPage8.Controls.Add(Me.Button38)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(284, 164)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Arquivos"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'BtnArrumar
        '
        Me.BtnArrumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArrumar.Location = New System.Drawing.Point(213, 127)
        Me.BtnArrumar.Name = "BtnArrumar"
        Me.BtnArrumar.Size = New System.Drawing.Size(55, 23)
        Me.BtnArrumar.TabIndex = 48
        Me.BtnArrumar.Text = "Importar"
        Me.BtnArrumar.UseVisualStyleBackColor = True
        '
        'Button41
        '
        Me.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button41.Location = New System.Drawing.Point(77, 127)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(62, 23)
        Me.Button41.TabIndex = 47
        Me.Button41.Text = "Limpar"
        Me.Button41.UseVisualStyleBackColor = True
        '
        'Button40
        '
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Location = New System.Drawing.Point(77, 49)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(62, 23)
        Me.Button40.TabIndex = 46
        Me.Button40.Text = "Limpar"
        Me.Button40.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Location = New System.Drawing.Point(9, 127)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(62, 23)
        Me.Button31.TabIndex = 45
        Me.Button31.Text = "Procurar"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'PastaDocumentosTextBox
        '
        Me.PastaDocumentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "PastaDocumentos", True))
        Me.PastaDocumentosTextBox.Location = New System.Drawing.Point(9, 101)
        Me.PastaDocumentosTextBox.Name = "PastaDocumentosTextBox"
        Me.PastaDocumentosTextBox.Size = New System.Drawing.Size(256, 20)
        Me.PastaDocumentosTextBox.TabIndex = 43
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(9, 49)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(62, 23)
        Me.Button15.TabIndex = 40
        Me.Button15.Text = "Procurar"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Location = New System.Drawing.Point(145, 49)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(62, 23)
        Me.Button14.TabIndex = 36
        Me.Button14.Text = "Abrir"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'ArquivoContratoTextBox
        '
        Me.ArquivoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ArquivoContrato", True))
        Me.ArquivoContratoTextBox.Location = New System.Drawing.Point(9, 24)
        Me.ArquivoContratoTextBox.Name = "ArquivoContratoTextBox"
        Me.ArquivoContratoTextBox.Size = New System.Drawing.Size(256, 20)
        Me.ArquivoContratoTextBox.TabIndex = 37
        '
        'Button38
        '
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.Location = New System.Drawing.Point(145, 127)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(62, 23)
        Me.Button38.TabIndex = 44
        Me.Button38.Text = "Abrir"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'TabPage20
        '
        Me.TabPage20.AutoScroll = True
        Me.TabPage20.Controls.Add(Me.BtnImportarAnexo)
        Me.TabPage20.Controls.Add(Me.AnexoBoxPicture)
        Me.TabPage20.Controls.Add(Me.DocContratosLinkLabel)
        Me.TabPage20.Controls.Add(Me.BtnApagaAnexo)
        Me.TabPage20.Controls.Add(Me.BtnAbrirDoc)
        Me.TabPage20.Controls.Add(Label10)
        Me.TabPage20.Controls.Add(Me.BtnSalvarDoc)
        Me.TabPage20.Location = New System.Drawing.Point(4, 22)
        Me.TabPage20.Name = "TabPage20"
        Me.TabPage20.Size = New System.Drawing.Size(284, 164)
        Me.TabPage20.TabIndex = 3
        Me.TabPage20.Text = "Anexo"
        Me.TabPage20.UseVisualStyleBackColor = True
        '
        'BtnImportarAnexo
        '
        Me.BtnImportarAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportarAnexo.Location = New System.Drawing.Point(13, 124)
        Me.BtnImportarAnexo.Name = "BtnImportarAnexo"
        Me.BtnImportarAnexo.Size = New System.Drawing.Size(84, 23)
        Me.BtnImportarAnexo.TabIndex = 60
        Me.BtnImportarAnexo.Text = "Auto Importar"
        Me.BtnImportarAnexo.UseVisualStyleBackColor = True
        '
        'AnexoBoxPicture
        '
        Me.AnexoBoxPicture.Location = New System.Drawing.Point(215, 3)
        Me.AnexoBoxPicture.Name = "AnexoBoxPicture"
        Me.AnexoBoxPicture.Size = New System.Drawing.Size(66, 40)
        Me.AnexoBoxPicture.TabIndex = 59
        Me.AnexoBoxPicture.TabStop = False
        '
        'DocContratosLinkLabel
        '
        Me.DocContratosLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DocContratos", True))
        Me.DocContratosLinkLabel.Location = New System.Drawing.Point(62, 53)
        Me.DocContratosLinkLabel.Name = "DocContratosLinkLabel"
        Me.DocContratosLinkLabel.Size = New System.Drawing.Size(100, 23)
        Me.DocContratosLinkLabel.TabIndex = 58
        Me.DocContratosLinkLabel.TabStop = True
        Me.DocContratosLinkLabel.Text = "Contrato Anexado"
        '
        'BtnApagaAnexo
        '
        Me.BtnApagaAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnApagaAnexo.Location = New System.Drawing.Point(193, 95)
        Me.BtnApagaAnexo.Name = "BtnApagaAnexo"
        Me.BtnApagaAnexo.Size = New System.Drawing.Size(84, 23)
        Me.BtnApagaAnexo.TabIndex = 55
        Me.BtnApagaAnexo.Text = "Apagar Anexo"
        Me.BtnApagaAnexo.UseVisualStyleBackColor = True
        '
        'BtnAbrirDoc
        '
        Me.BtnAbrirDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrirDoc.Location = New System.Drawing.Point(103, 95)
        Me.BtnAbrirDoc.Name = "BtnAbrirDoc"
        Me.BtnAbrirDoc.Size = New System.Drawing.Size(84, 23)
        Me.BtnAbrirDoc.TabIndex = 53
        Me.BtnAbrirDoc.Text = "Abrir"
        Me.BtnAbrirDoc.UseVisualStyleBackColor = True
        '
        'BtnSalvarDoc
        '
        Me.BtnSalvarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvarDoc.Location = New System.Drawing.Point(13, 95)
        Me.BtnSalvarDoc.Name = "BtnSalvarDoc"
        Me.BtnSalvarDoc.Size = New System.Drawing.Size(84, 23)
        Me.BtnSalvarDoc.TabIndex = 48
        Me.BtnSalvarDoc.Text = "Anexar"
        Me.BtnSalvarDoc.UseVisualStyleBackColor = True
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.GroupBox3)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(284, 164)
        Me.TabPage11.TabIndex = 2
        Me.TabPage11.Text = "Ajuda"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkLabel2)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 67)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ajuda"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(9, 39)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(144, 13)
        Me.LinkLabel2.TabIndex = 29
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Eventos que precisa de PRP"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 19)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(180, 13)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CANCELADA - ART.60 LEI 8934/94"
        '
        'Button30
        '
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button30.Location = New System.Drawing.Point(196, 63)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(65, 20)
        Me.Button30.TabIndex = 42
        Me.Button30.Text = "Detalhes"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Location = New System.Drawing.Point(386, 10)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(145, 24)
        Me.Button12.TabIndex = 35
        Me.Button12.Text = "Responsável pela Empresa"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'ProtJuntaFinalMaskedTextBox
        '
        Me.ProtJuntaFinalMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ProtJuntaFinal", True))
        Me.ProtJuntaFinalMaskedTextBox.Location = New System.Drawing.Point(90, 63)
        Me.ProtJuntaFinalMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.ProtJuntaFinalMaskedTextBox.Name = "ProtJuntaFinalMaskedTextBox"
        Me.ProtJuntaFinalMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProtJuntaFinalMaskedTextBox.TabIndex = 41
        Me.ProtJuntaFinalMaskedTextBox.ValidatingType = GetType(Date)
        '
        'JuntaObsRichTextBox
        '
        Me.JuntaObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "JuntaObs", True))
        Me.JuntaObsRichTextBox.Location = New System.Drawing.Point(14, 162)
        Me.JuntaObsRichTextBox.Name = "JuntaObsRichTextBox"
        Me.JuntaObsRichTextBox.Size = New System.Drawing.Size(285, 70)
        Me.JuntaObsRichTextBox.TabIndex = 30
        Me.JuntaObsRichTextBox.Text = ""
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(196, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(65, 20)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Detalhes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataProtJuntaComercialMaskedTextBox
        '
        Me.DataProtJuntaComercialMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataProtJuntaComercial", True))
        Me.DataProtJuntaComercialMaskedTextBox.Location = New System.Drawing.Point(90, 11)
        Me.DataProtJuntaComercialMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataProtJuntaComercialMaskedTextBox.Name = "DataProtJuntaComercialMaskedTextBox"
        Me.DataProtJuntaComercialMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataProtJuntaComercialMaskedTextBox.TabIndex = 6
        Me.DataProtJuntaComercialMaskedTextBox.ValidatingType = GetType(Date)
        '
        'BtnConsultaJunta
        '
        Me.BtnConsultaJunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaJunta.Location = New System.Drawing.Point(196, 35)
        Me.BtnConsultaJunta.Name = "BtnConsultaJunta"
        Me.BtnConsultaJunta.Size = New System.Drawing.Size(65, 22)
        Me.BtnConsultaJunta.TabIndex = 2
        Me.BtnConsultaJunta.Text = "Consultar"
        Me.BtnConsultaJunta.UseVisualStyleBackColor = True
        '
        'ProtocoloJuntaComercialTextBox
        '
        Me.ProtocoloJuntaComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ProtocoloJuntaComercial", True))
        Me.ProtocoloJuntaComercialTextBox.Location = New System.Drawing.Point(90, 37)
        Me.ProtocoloJuntaComercialTextBox.Name = "ProtocoloJuntaComercialTextBox"
        Me.ProtocoloJuntaComercialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProtocoloJuntaComercialTextBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.BtnAnotacoesFederal)
        Me.TabPage4.Controls.Add(Me.BtnData4)
        Me.TabPage4.Controls.Add(Me.Button47)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.ProtocoloREDESIMLabel)
        Me.TabPage4.Controls.Add(Me.DataProtREDESIMLabel)
        Me.TabPage4.Controls.Add(Me.Button13)
        Me.TabPage4.Controls.Add(Me.RedeSimObsRichTextBox)
        Me.TabPage4.Controls.Add(RedeSimObsLabel)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.BtnConsultaRedeSim)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.DataProtREDESIMMaskedTextBox)
        Me.TabPage4.Controls.Add(Me.ProtocoloREDESIMTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(617, 239)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Receita Federal"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BtnAnotacoesFederal
        '
        Me.BtnAnotacoesFederal.BackgroundImage = CType(resources.GetObject("BtnAnotacoesFederal.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesFederal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesFederal.Location = New System.Drawing.Point(241, 63)
        Me.BtnAnotacoesFederal.Name = "BtnAnotacoesFederal"
        Me.BtnAnotacoesFederal.Size = New System.Drawing.Size(69, 23)
        Me.BtnAnotacoesFederal.TabIndex = 72
        Me.BtnAnotacoesFederal.Text = "Anotações"
        Me.BtnAnotacoesFederal.UseVisualStyleBackColor = True
        '
        'BtnData4
        '
        Me.BtnData4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnData4.Location = New System.Drawing.Point(265, 11)
        Me.BtnData4.Name = "BtnData4"
        Me.BtnData4.Size = New System.Drawing.Size(43, 21)
        Me.BtnData4.TabIndex = 52
        Me.BtnData4.Text = "Agora"
        Me.BtnData4.UseVisualStyleBackColor = True
        '
        'Button47
        '
        Me.Button47.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button47.Location = New System.Drawing.Point(24, 63)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(60, 24)
        Me.Button47.TabIndex = 41
        Me.Button47.Text = "Eventos"
        Me.Button47.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LinkLabel15)
        Me.GroupBox7.Controls.Add(Me.LinkLabel14)
        Me.GroupBox7.Controls.Add(Me.LinkLabel13)
        Me.GroupBox7.Controls.Add(Me.LinkLabel8)
        Me.GroupBox7.Controls.Add(Me.LinkLabel12)
        Me.GroupBox7.Location = New System.Drawing.Point(386, 105)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(202, 90)
        Me.GroupBox7.TabIndex = 40
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Serviços REDESIM - Links"
        '
        'LinkLabel15
        '
        Me.LinkLabel15.AutoSize = True
        Me.LinkLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel15.Location = New System.Drawing.Point(13, 60)
        Me.LinkLabel15.Name = "LinkLabel15"
        Me.LinkLabel15.Size = New System.Drawing.Size(38, 15)
        Me.LinkLabel15.TabIndex = 32
        Me.LinkLabel15.TabStop = True
        Me.LinkLabel15.Text = "Baixa"
        '
        'LinkLabel14
        '
        Me.LinkLabel14.AutoSize = True
        Me.LinkLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel14.Location = New System.Drawing.Point(99, 37)
        Me.LinkLabel14.Name = "LinkLabel14"
        Me.LinkLabel14.Size = New System.Drawing.Size(56, 15)
        Me.LinkLabel14.TabIndex = 31
        Me.LinkLabel14.TabStop = True
        Me.LinkLabel14.Text = "Cancelar"
        '
        'LinkLabel13
        '
        Me.LinkLabel13.AutoSize = True
        Me.LinkLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel13.Location = New System.Drawing.Point(99, 16)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(65, 15)
        Me.LinkLabel13.TabIndex = 30
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "Recuperar"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.Location = New System.Drawing.Point(13, 16)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(53, 15)
        Me.LinkLabel8.TabIndex = 29
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Abertura"
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.Location = New System.Drawing.Point(13, 37)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(58, 15)
        Me.LinkLabel12.TabIndex = 28
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Alteração"
        '
        'ProtocoloREDESIMLabel
        '
        Me.ProtocoloREDESIMLabel.AutoSize = True
        Me.ProtocoloREDESIMLabel.Location = New System.Drawing.Point(29, 41)
        Me.ProtocoloREDESIMLabel.Name = "ProtocoloREDESIMLabel"
        Me.ProtocoloREDESIMLabel.Size = New System.Drawing.Size(55, 13)
        Me.ProtocoloREDESIMLabel.TabIndex = 39
        Me.ProtocoloREDESIMLabel.Text = "Protocolo:"
        '
        'DataProtREDESIMLabel
        '
        Me.DataProtREDESIMLabel.AutoSize = True
        Me.DataProtREDESIMLabel.Location = New System.Drawing.Point(11, 15)
        Me.DataProtREDESIMLabel.Name = "DataProtREDESIMLabel"
        Me.DataProtREDESIMLabel.Size = New System.Drawing.Size(73, 13)
        Me.DataProtREDESIMLabel.TabIndex = 38
        Me.DataProtREDESIMLabel.Text = "Solicitado dia:"
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Location = New System.Drawing.Point(90, 63)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(145, 24)
        Me.Button13.TabIndex = 36
        Me.Button13.Text = "Responsável pela Empresa"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'RedeSimObsRichTextBox
        '
        Me.RedeSimObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RedeSimObs", True))
        Me.RedeSimObsRichTextBox.Location = New System.Drawing.Point(55, 118)
        Me.RedeSimObsRichTextBox.Name = "RedeSimObsRichTextBox"
        Me.RedeSimObsRichTextBox.Size = New System.Drawing.Size(246, 101)
        Me.RedeSimObsRichTextBox.TabIndex = 31
        Me.RedeSimObsRichTextBox.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LinkLabel3)
        Me.GroupBox4.Controls.Add(Me.LinkLabel4)
        Me.GroupBox4.Location = New System.Drawing.Point(386, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 62)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ajuda"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(9, 39)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(144, 13)
        Me.LinkLabel3.TabIndex = 29
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Eventos que precisa de PRP"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(8, 19)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(180, 13)
        Me.LinkLabel4.TabIndex = 28
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "CANCELADA - ART.60 LEI 8934/94"
        '
        'BtnConsultaRedeSim
        '
        Me.BtnConsultaRedeSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaRedeSim.Location = New System.Drawing.Point(196, 35)
        Me.BtnConsultaRedeSim.Name = "BtnConsultaRedeSim"
        Me.BtnConsultaRedeSim.Size = New System.Drawing.Size(65, 22)
        Me.BtnConsultaRedeSim.TabIndex = 23
        Me.BtnConsultaRedeSim.Text = "Solicitar"
        Me.BtnConsultaRedeSim.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(196, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 22)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Detalhes"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DataProtREDESIMMaskedTextBox
        '
        Me.DataProtREDESIMMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataProtREDESIM", True))
        Me.DataProtREDESIMMaskedTextBox.Location = New System.Drawing.Point(90, 12)
        Me.DataProtREDESIMMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataProtREDESIMMaskedTextBox.Name = "DataProtREDESIMMaskedTextBox"
        Me.DataProtREDESIMMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataProtREDESIMMaskedTextBox.TabIndex = 4
        Me.DataProtREDESIMMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ProtocoloREDESIMTextBox
        '
        Me.ProtocoloREDESIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ProtocoloREDESIM", True))
        Me.ProtocoloREDESIMTextBox.Location = New System.Drawing.Point(90, 37)
        Me.ProtocoloREDESIMTextBox.Name = "ProtocoloREDESIMTextBox"
        Me.ProtocoloREDESIMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProtocoloREDESIMTextBox.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.BtnAnotacoesEstadual)
        Me.TabPage5.Controls.Add(Me.Button33)
        Me.TabPage5.Controls.Add(Me.GroupBox12)
        Me.TabPage5.Controls.Add(Me.IEjuntaComboBox)
        Me.TabPage5.Controls.Add(IEjuntaLabel)
        Me.TabPage5.Controls.Add(Me.Button11)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(617, 239)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Receita Estadual"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'BtnAnotacoesEstadual
        '
        Me.BtnAnotacoesEstadual.BackgroundImage = CType(resources.GetObject("BtnAnotacoesEstadual.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesEstadual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesEstadual.Location = New System.Drawing.Point(439, 12)
        Me.BtnAnotacoesEstadual.Name = "BtnAnotacoesEstadual"
        Me.BtnAnotacoesEstadual.Size = New System.Drawing.Size(69, 23)
        Me.BtnAnotacoesEstadual.TabIndex = 73
        Me.BtnAnotacoesEstadual.Text = "Anotações"
        Me.BtnAnotacoesEstadual.UseVisualStyleBackColor = True
        '
        'Button33
        '
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Location = New System.Drawing.Point(318, 18)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(98, 21)
        Me.Button33.TabIndex = 44
        Me.Button33.Text = "Junta Comercial"
        Me.Button33.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.BtnConsultaeProcessoEstado)
        Me.GroupBox12.Controls.Add(Me.DatadeInicioIE)
        Me.GroupBox12.Controls.Add(IEeProcNumLabel)
        Me.GroupBox12.Controls.Add(Me.IEeProcNumTextBox)
        Me.GroupBox12.Controls.Add(IETipoLabel)
        Me.GroupBox12.Controls.Add(Me.IETipoComboBox)
        Me.GroupBox12.Controls.Add(IEOnlineLabel)
        Me.GroupBox12.Controls.Add(Me.Label7)
        Me.GroupBox12.Controls.Add(Me.IEOnlineComboBox)
        Me.GroupBox12.Controls.Add(Me.IEVencPedidoMaskedTextBox)
        Me.GroupBox12.Controls.Add(Me.Button23)
        Me.GroupBox12.Controls.Add(EstadualObsLabel)
        Me.GroupBox12.Controls.Add(Me.IEInicioAtividadeMaskedTextBox)
        Me.GroupBox12.Controls.Add(Me.EstadualObsRichTextBox)
        Me.GroupBox12.Controls.Add(IEComprovanteLabel)
        Me.GroupBox12.Controls.Add(Me.IEComprovanteTextBox)
        Me.GroupBox12.Controls.Add(Me.DataPedidoIEMaskedTextBox)
        Me.GroupBox12.Controls.Add(DataPedidoIELabel)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(589, 188)
        Me.GroupBox12.TabIndex = 27
        Me.GroupBox12.TabStop = False
        '
        'BtnConsultaeProcessoEstado
        '
        Me.BtnConsultaeProcessoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaeProcessoEstado.Location = New System.Drawing.Point(182, 148)
        Me.BtnConsultaeProcessoEstado.Name = "BtnConsultaeProcessoEstado"
        Me.BtnConsultaeProcessoEstado.Size = New System.Drawing.Size(65, 22)
        Me.BtnConsultaeProcessoEstado.TabIndex = 43
        Me.BtnConsultaeProcessoEstado.Text = "Solicitar"
        Me.BtnConsultaeProcessoEstado.UseVisualStyleBackColor = True
        '
        'DatadeInicioIE
        '
        Me.DatadeInicioIE.AutoSize = True
        Me.DatadeInicioIE.Location = New System.Drawing.Point(28, 44)
        Me.DatadeInicioIE.Name = "DatadeInicioIE"
        Me.DatadeInicioIE.Size = New System.Drawing.Size(78, 13)
        Me.DatadeInicioIE.TabIndex = 42
        Me.DatadeInicioIE.Text = "Data de Início:"
        '
        'IEeProcNumTextBox
        '
        Me.IEeProcNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IEeProcNum", True))
        Me.IEeProcNumTextBox.Location = New System.Drawing.Point(108, 150)
        Me.IEeProcNumTextBox.Name = "IEeProcNumTextBox"
        Me.IEeProcNumTextBox.Size = New System.Drawing.Size(70, 20)
        Me.IEeProcNumTextBox.TabIndex = 41
        '
        'IETipoComboBox
        '
        Me.IETipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IETipo", True))
        Me.IETipoComboBox.FormattingEnabled = True
        Me.IETipoComboBox.Items.AddRange(New Object() {"Abertura", "Alteração", "Baixa", "Reativação"})
        Me.IETipoComboBox.Location = New System.Drawing.Point(236, 14)
        Me.IETipoComboBox.Name = "IETipoComboBox"
        Me.IETipoComboBox.Size = New System.Drawing.Size(91, 21)
        Me.IETipoComboBox.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Prazo Máximo Para a Entrega da Documentação:"
        '
        'IEOnlineComboBox
        '
        Me.IEOnlineComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IEOnline", True))
        Me.IEOnlineComboBox.FormattingEnabled = True
        Me.IEOnlineComboBox.Items.AddRange(New Object() {"X", "Online", "eProcesso", "Manual"})
        Me.IEOnlineComboBox.Location = New System.Drawing.Point(108, 14)
        Me.IEOnlineComboBox.Name = "IEOnlineComboBox"
        Me.IEOnlineComboBox.Size = New System.Drawing.Size(83, 21)
        Me.IEOnlineComboBox.TabIndex = 39
        '
        'IEVencPedidoMaskedTextBox
        '
        Me.IEVencPedidoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IEVencPedido", True))
        Me.IEVencPedidoMaskedTextBox.Location = New System.Drawing.Point(247, 117)
        Me.IEVencPedidoMaskedTextBox.Mask = "00/00/0000"
        Me.IEVencPedidoMaskedTextBox.Name = "IEVencPedidoMaskedTextBox"
        Me.IEVencPedidoMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.IEVencPedidoMaskedTextBox.TabIndex = 29
        Me.IEVencPedidoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Button23
        '
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Location = New System.Drawing.Point(214, 67)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(57, 20)
        Me.Button23.TabIndex = 28
        Me.Button23.Text = "Detalhes"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'IEInicioAtividadeMaskedTextBox
        '
        Me.IEInicioAtividadeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IEInicioAtividade", True))
        Me.IEInicioAtividadeMaskedTextBox.Location = New System.Drawing.Point(108, 41)
        Me.IEInicioAtividadeMaskedTextBox.Mask = "00/00/0000"
        Me.IEInicioAtividadeMaskedTextBox.Name = "IEInicioAtividadeMaskedTextBox"
        Me.IEInicioAtividadeMaskedTextBox.Size = New System.Drawing.Size(66, 20)
        Me.IEInicioAtividadeMaskedTextBox.TabIndex = 26
        Me.IEInicioAtividadeMaskedTextBox.ValidatingType = GetType(Date)
        '
        'EstadualObsRichTextBox
        '
        Me.EstadualObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EstadualObs", True))
        Me.EstadualObsRichTextBox.Location = New System.Drawing.Point(379, 32)
        Me.EstadualObsRichTextBox.Name = "EstadualObsRichTextBox"
        Me.EstadualObsRichTextBox.Size = New System.Drawing.Size(190, 150)
        Me.EstadualObsRichTextBox.TabIndex = 5
        Me.EstadualObsRichTextBox.Text = ""
        '
        'IEComprovanteTextBox
        '
        Me.IEComprovanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IEComprovante", True))
        Me.IEComprovanteTextBox.Location = New System.Drawing.Point(108, 94)
        Me.IEComprovanteTextBox.Name = "IEComprovanteTextBox"
        Me.IEComprovanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IEComprovanteTextBox.TabIndex = 25
        '
        'DataPedidoIEMaskedTextBox
        '
        Me.DataPedidoIEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataPedidoIE", True))
        Me.DataPedidoIEMaskedTextBox.Location = New System.Drawing.Point(108, 67)
        Me.DataPedidoIEMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataPedidoIEMaskedTextBox.Name = "DataPedidoIEMaskedTextBox"
        Me.DataPedidoIEMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataPedidoIEMaskedTextBox.TabIndex = 4
        Me.DataPedidoIEMaskedTextBox.ValidatingType = GetType(Date)
        '
        'IEjuntaComboBox
        '
        Me.IEjuntaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IEjunta", True))
        Me.IEjuntaComboBox.FormattingEnabled = True
        Me.IEjuntaComboBox.Items.AddRange(New Object() {"Vinculado na Junta Comercial", "Manualmente o Pedido"})
        Me.IEjuntaComboBox.Location = New System.Drawing.Point(134, 18)
        Me.IEjuntaComboBox.Name = "IEjuntaComboBox"
        Me.IEjuntaComboBox.Size = New System.Drawing.Size(178, 21)
        Me.IEjuntaComboBox.TabIndex = 37
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(515, 13)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(82, 21)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "Receita-PR"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Controls.Add(Me.BtnAnotacoesSimples)
        Me.TabPage7.Controls.Add(Me.GroupBox13)
        Me.TabPage7.Controls.Add(OrgãoPedSimplesLabel)
        Me.TabPage7.Controls.Add(Me.OrgãoPedSimplesComboBox)
        Me.TabPage7.Controls.Add(DataUltdefSimplesLabel)
        Me.TabPage7.Controls.Add(Me.DataUltdefSimplesMaskedTextBox)
        Me.TabPage7.Controls.Add(DataSimplesLabel)
        Me.TabPage7.Controls.Add(Me.DataSimplesMaskedTextBox)
        Me.TabPage7.Controls.Add(ObsSimplesLabel)
        Me.TabPage7.Controls.Add(Me.ObsSimplesRichTextBox)
        Me.TabPage7.Controls.Add(Me.GroupBox11)
        Me.TabPage7.Controls.Add(Me.GroupBox8)
        Me.TabPage7.Controls.Add(CodigoSimplesLabel)
        Me.TabPage7.Controls.Add(Me.CodigoSimplesTextBox)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(617, 239)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "Simples Nacional"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'BtnAnotacoesSimples
        '
        Me.BtnAnotacoesSimples.BackgroundImage = CType(resources.GetObject("BtnAnotacoesSimples.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesSimples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesSimples.Location = New System.Drawing.Point(299, 74)
        Me.BtnAnotacoesSimples.Name = "BtnAnotacoesSimples"
        Me.BtnAnotacoesSimples.Size = New System.Drawing.Size(69, 23)
        Me.BtnAnotacoesSimples.TabIndex = 76
        Me.BtnAnotacoesSimples.Text = "Anotações"
        Me.BtnAnotacoesSimples.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Button36)
        Me.GroupBox13.Controls.Add(Me.BtnCopiaDataDeNasc)
        Me.GroupBox13.Controls.Add(Me.Button35)
        Me.GroupBox13.Controls.Add(Me.Button34)
        Me.GroupBox13.Controls.Add(Me.Button37)
        Me.GroupBox13.Location = New System.Drawing.Point(165, 102)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox13.TabIndex = 54
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Copia rápida"
        '
        'Button36
        '
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Location = New System.Drawing.Point(4, 99)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(114, 25)
        Me.Button36.TabIndex = 48
        Me.Button36.Text = "Código do Simples"
        Me.Button36.UseVisualStyleBackColor = True
        '
        'BtnCopiaDataDeNasc
        '
        Me.BtnCopiaDataDeNasc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiaDataDeNasc.Location = New System.Drawing.Point(4, 71)
        Me.BtnCopiaDataDeNasc.Name = "BtnCopiaDataDeNasc"
        Me.BtnCopiaDataDeNasc.Size = New System.Drawing.Size(114, 25)
        Me.BtnCopiaDataDeNasc.TabIndex = 55
        Me.BtnCopiaDataDeNasc.Text = "Data de Nascimento"
        Me.BtnCopiaDataDeNasc.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Location = New System.Drawing.Point(4, 15)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(76, 25)
        Me.Button35.TabIndex = 47
        Me.Button35.Text = "CPF"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Location = New System.Drawing.Point(82, 15)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(84, 25)
        Me.Button34.TabIndex = 46
        Me.Button34.Text = "CNPJ"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.Location = New System.Drawing.Point(4, 43)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(114, 25)
        Me.Button37.TabIndex = 51
        Me.Button37.Text = "Título de Eleitor"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'OrgãoPedSimplesComboBox
        '
        Me.OrgãoPedSimplesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OrgãoPedSimplesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.OrgãoPedSimplesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "OrgãoPedSimples", True))
        Me.OrgãoPedSimplesComboBox.FormattingEnabled = True
        Me.OrgãoPedSimplesComboBox.Items.AddRange(New Object() {"Estadual", "Municipal"})
        Me.OrgãoPedSimplesComboBox.Location = New System.Drawing.Point(202, 52)
        Me.OrgãoPedSimplesComboBox.Name = "OrgãoPedSimplesComboBox"
        Me.OrgãoPedSimplesComboBox.Size = New System.Drawing.Size(81, 21)
        Me.OrgãoPedSimplesComboBox.TabIndex = 53
        '
        'DataUltdefSimplesMaskedTextBox
        '
        Me.DataUltdefSimplesMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataUltdefSimples", True))
        Me.DataUltdefSimplesMaskedTextBox.Location = New System.Drawing.Point(202, 29)
        Me.DataUltdefSimplesMaskedTextBox.Mask = "00/00/0000"
        Me.DataUltdefSimplesMaskedTextBox.Name = "DataUltdefSimplesMaskedTextBox"
        Me.DataUltdefSimplesMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.DataUltdefSimplesMaskedTextBox.TabIndex = 52
        Me.DataUltdefSimplesMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataSimplesMaskedTextBox
        '
        Me.DataSimplesMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "DataSimples", True))
        Me.DataSimplesMaskedTextBox.Location = New System.Drawing.Point(202, 76)
        Me.DataSimplesMaskedTextBox.Mask = "00/00/0000"
        Me.DataSimplesMaskedTextBox.Name = "DataSimplesMaskedTextBox"
        Me.DataSimplesMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.DataSimplesMaskedTextBox.TabIndex = 50
        Me.DataSimplesMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ObsSimplesRichTextBox
        '
        Me.ObsSimplesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ObsSimples", True))
        Me.ObsSimplesRichTextBox.Location = New System.Drawing.Point(9, 141)
        Me.ObsSimplesRichTextBox.Name = "ObsSimplesRichTextBox"
        Me.ObsSimplesRichTextBox.Size = New System.Drawing.Size(150, 84)
        Me.ObsSimplesRichTextBox.TabIndex = 49
        Me.ObsSimplesRichTextBox.Text = ""
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.LinkLabel17)
        Me.GroupBox11.Controls.Add(Me.Label5)
        Me.GroupBox11.Controls.Add(Me.Button8)
        Me.GroupBox11.Controls.Add(PrazoSimplesLabel)
        Me.GroupBox11.Controls.Add(Me.txtDataASomar)
        Me.GroupBox11.Controls.Add(Me.PrazoSimplesMaskedTextBox)
        Me.GroupBox11.Controls.Add(Me.Label3)
        Me.GroupBox11.Location = New System.Drawing.Point(374, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(218, 105)
        Me.GroupBox11.TabIndex = 41
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Prazo máximo do Simples Nacional"
        '
        'LinkLabel17
        '
        Me.LinkLabel17.AutoSize = True
        Me.LinkLabel17.Location = New System.Drawing.Point(183, 53)
        Me.LinkLabel17.Name = "LinkLabel17"
        Me.LinkLabel17.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel17.TabIndex = 55
        Me.LinkLabel17.TabStop = True
        Me.LinkLabel17.Text = "Ajuda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Data de vencimento:"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(12, 22)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(103, 23)
        Me.Button8.TabIndex = 30
        Me.Button8.Text = "Calcular Prazo"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtDataASomar
        '
        Me.txtDataASomar.Location = New System.Drawing.Point(86, 50)
        Me.txtDataASomar.Name = "txtDataASomar"
        Me.txtDataASomar.Size = New System.Drawing.Size(27, 20)
        Me.txtDataASomar.TabIndex = 31
        Me.txtDataASomar.Text = "60"
        '
        'PrazoSimplesMaskedTextBox
        '
        Me.PrazoSimplesMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "PrazoSimples", True))
        Me.PrazoSimplesMaskedTextBox.Location = New System.Drawing.Point(115, 76)
        Me.PrazoSimplesMaskedTextBox.Name = "PrazoSimplesMaskedTextBox"
        Me.PrazoSimplesMaskedTextBox.ReadOnly = True
        Me.PrazoSimplesMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.PrazoSimplesMaskedTextBox.TabIndex = 29
        Me.PrazoSimplesMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Dias corridos"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LinkLabel11)
        Me.GroupBox8.Controls.Add(Me.LinkLabel7)
        Me.GroupBox8.Controls.Add(Me.LinkLabel6)
        Me.GroupBox8.Controls.Add(Me.LinkLabel5)
        Me.GroupBox8.Location = New System.Drawing.Point(378, 134)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(217, 93)
        Me.GroupBox8.TabIndex = 40
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Link de Serviços Simples Nacional"
        '
        'LinkLabel11
        '
        Me.LinkLabel11.AutoSize = True
        Me.LinkLabel11.Location = New System.Drawing.Point(6, 36)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(208, 13)
        Me.LinkLabel11.TabIndex = 40
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "Solicitação da Opção do Simples Nacional"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(6, 71)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(170, 13)
        Me.LinkLabel7.TabIndex = 39
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Criar ou alterar - Código de Acesso"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(6, 53)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(141, 13)
        Me.LinkLabel6.TabIndex = 38
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Acompanhar a Formalização"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(6, 19)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(109, 13)
        Me.LinkLabel5.TabIndex = 37
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Site Simples Nacional"
        '
        'CodigoSimplesTextBox
        '
        Me.CodigoSimplesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "CodigoSimples", True))
        Me.CodigoSimplesTextBox.Location = New System.Drawing.Point(201, 6)
        Me.CodigoSimplesTextBox.Name = "CodigoSimplesTextBox"
        Me.CodigoSimplesTextBox.Size = New System.Drawing.Size(103, 20)
        Me.CodigoSimplesTextBox.TabIndex = 33
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.BtnAnotacoesPrefeitura)
        Me.TabPage6.Controls.Add(Me.LinkLabel16)
        Me.TabPage6.Controls.Add(Me.Button32)
        Me.TabPage6.Controls.Add(BombeiroJuntaLabel)
        Me.TabPage6.Controls.Add(Me.BombeiroJuntaComboBox)
        Me.TabPage6.Controls.Add(PrefeituraObsLabel)
        Me.TabPage6.Controls.Add(Me.PrefeituraObsRichTextBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(617, 239)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Prefeitura"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'BtnAnotacoesPrefeitura
        '
        Me.BtnAnotacoesPrefeitura.BackgroundImage = CType(resources.GetObject("BtnAnotacoesPrefeitura.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesPrefeitura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesPrefeitura.Location = New System.Drawing.Point(338, 19)
        Me.BtnAnotacoesPrefeitura.Name = "BtnAnotacoesPrefeitura"
        Me.BtnAnotacoesPrefeitura.Size = New System.Drawing.Size(69, 23)
        Me.BtnAnotacoesPrefeitura.TabIndex = 74
        Me.BtnAnotacoesPrefeitura.Text = "Anotações"
        Me.BtnAnotacoesPrefeitura.UseVisualStyleBackColor = True
        '
        'LinkLabel16
        '
        Me.LinkLabel16.AutoSize = True
        Me.LinkLabel16.Location = New System.Drawing.Point(12, 179)
        Me.LinkLabel16.Name = "LinkLabel16"
        Me.LinkLabel16.Size = New System.Drawing.Size(323, 13)
        Me.LinkLabel16.TabIndex = 43
        Me.LinkLabel16.TabStop = True
        Me.LinkLabel16.Text = "Documentos necessários para Requerimento de Extravio de Alvará"
        '
        'Button32
        '
        Me.Button32.FlatAppearance.BorderSize = 2
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Location = New System.Drawing.Point(325, 71)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(153, 39)
        Me.Button32.TabIndex = 42
        Me.Button32.Text = "Sistema de Laudo / Alvará"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'BombeiroJuntaComboBox
        '
        Me.BombeiroJuntaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "BombeiroJunta", True))
        Me.BombeiroJuntaComboBox.FormattingEnabled = True
        Me.BombeiroJuntaComboBox.Items.AddRange(New Object() {"Vinculado na Junta Comercial", "Manualmente o Pedido"})
        Me.BombeiroJuntaComboBox.Location = New System.Drawing.Point(141, 21)
        Me.BombeiroJuntaComboBox.Name = "BombeiroJuntaComboBox"
        Me.BombeiroJuntaComboBox.Size = New System.Drawing.Size(178, 21)
        Me.BombeiroJuntaComboBox.TabIndex = 41
        '
        'PrefeituraObsRichTextBox
        '
        Me.PrefeituraObsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "PrefeituraObs", True))
        Me.PrefeituraObsRichTextBox.Location = New System.Drawing.Point(27, 71)
        Me.PrefeituraObsRichTextBox.Name = "PrefeituraObsRichTextBox"
        Me.PrefeituraObsRichTextBox.Size = New System.Drawing.Size(292, 99)
        Me.PrefeituraObsRichTextBox.TabIndex = 40
        Me.PrefeituraObsRichTextBox.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnAnotacoesDemais)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(HistoricoLabel)
        Me.TabPage2.Controls.Add(Me.HistoricoRichTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(617, 239)
        Me.TabPage2.TabIndex = 8
        Me.TabPage2.Text = "Histórico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnAnotacoesDemais
        '
        Me.BtnAnotacoesDemais.BackgroundImage = CType(resources.GetObject("BtnAnotacoesDemais.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesDemais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesDemais.Location = New System.Drawing.Point(510, 79)
        Me.BtnAnotacoesDemais.Name = "BtnAnotacoesDemais"
        Me.BtnAnotacoesDemais.Size = New System.Drawing.Size(69, 23)
        Me.BtnAnotacoesDemais.TabIndex = 75
        Me.BtnAnotacoesDemais.Text = "Anotações"
        Me.BtnAnotacoesDemais.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(490, 34)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 39)
        Me.Button9.TabIndex = 50
        Me.Button9.Text = "Voltar para Aba Geral"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'HistoricoRichTextBox
        '
        Me.HistoricoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Historico", True))
        Me.HistoricoRichTextBox.Location = New System.Drawing.Point(18, 34)
        Me.HistoricoRichTextBox.Name = "HistoricoRichTextBox"
        Me.HistoricoRichTextBox.Size = New System.Drawing.Size(451, 180)
        Me.HistoricoRichTextBox.TabIndex = 1
        Me.HistoricoRichTextBox.Text = ""
        '
        'TabPage17
        '
        Me.TabPage17.Controls.Add(ProcuracaoDataLabel)
        Me.TabPage17.Controls.Add(Me.ProcuracaoDataMaskedTextBox)
        Me.TabPage17.Controls.Add(ProcuracaoNLabel)
        Me.TabPage17.Controls.Add(Me.ProcuracaoNMaskedTextBox)
        Me.TabPage17.Controls.Add(ProcuracaoLabel)
        Me.TabPage17.Controls.Add(Me.ProcuracaoComboBox)
        Me.TabPage17.Controls.Add(Me.Button45)
        Me.TabPage17.Location = New System.Drawing.Point(4, 22)
        Me.TabPage17.Name = "TabPage17"
        Me.TabPage17.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage17.Size = New System.Drawing.Size(617, 239)
        Me.TabPage17.TabIndex = 9
        Me.TabPage17.Text = "Procuração"
        Me.TabPage17.UseVisualStyleBackColor = True
        '
        'ProcuracaoDataMaskedTextBox
        '
        Me.ProcuracaoDataMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ProcuracaoData", True))
        Me.ProcuracaoDataMaskedTextBox.Location = New System.Drawing.Point(144, 139)
        Me.ProcuracaoDataMaskedTextBox.Mask = "00/00/0000"
        Me.ProcuracaoDataMaskedTextBox.Name = "ProcuracaoDataMaskedTextBox"
        Me.ProcuracaoDataMaskedTextBox.Size = New System.Drawing.Size(69, 20)
        Me.ProcuracaoDataMaskedTextBox.TabIndex = 44
        Me.ProcuracaoDataMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ProcuracaoNMaskedTextBox
        '
        Me.ProcuracaoNMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "ProcuracaoN", True))
        Me.ProcuracaoNMaskedTextBox.Location = New System.Drawing.Point(144, 91)
        Me.ProcuracaoNMaskedTextBox.Name = "ProcuracaoNMaskedTextBox"
        Me.ProcuracaoNMaskedTextBox.Size = New System.Drawing.Size(198, 20)
        Me.ProcuracaoNMaskedTextBox.TabIndex = 43
        '
        'ProcuracaoComboBox
        '
        Me.ProcuracaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Procuracao", True))
        Me.ProcuracaoComboBox.FormattingEnabled = True
        Me.ProcuracaoComboBox.Items.AddRange(New Object() {"Não Solicitado", "Solicitado", "Aguardando Cliente", "Aguardando Protocolo Finalizar", "Finalizado"})
        Me.ProcuracaoComboBox.Location = New System.Drawing.Point(144, 47)
        Me.ProcuracaoComboBox.Name = "ProcuracaoComboBox"
        Me.ProcuracaoComboBox.Size = New System.Drawing.Size(198, 21)
        Me.ProcuracaoComboBox.TabIndex = 42
        '
        'Button45
        '
        Me.Button45.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.Button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button45.Location = New System.Drawing.Point(348, 59)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(70, 38)
        Me.Button45.TabIndex = 41
        Me.Button45.Text = "Solicitar"
        Me.Button45.UseVisualStyleBackColor = True
        '
        'LaudosBindingSource
        '
        Me.LaudosBindingSource.DataMember = "Laudos"
        Me.LaudosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'NovaRazaoSocialComboBox
        '
        Me.NovaRazaoSocialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NovaRazaoSocial", True))
        Me.NovaRazaoSocialComboBox.FormattingEnabled = True
        Me.NovaRazaoSocialComboBox.Items.AddRange(New Object() {"Não", "Sim"})
        Me.NovaRazaoSocialComboBox.Location = New System.Drawing.Point(268, 129)
        Me.NovaRazaoSocialComboBox.Name = "NovaRazaoSocialComboBox"
        Me.NovaRazaoSocialComboBox.Size = New System.Drawing.Size(61, 21)
        Me.NovaRazaoSocialComboBox.TabIndex = 7
        '
        'AvisarDiaMaskedTextBox
        '
        Me.AvisarDiaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "AvisarDia", True))
        Me.AvisarDiaMaskedTextBox.Location = New System.Drawing.Point(65, 40)
        Me.AvisarDiaMaskedTextBox.Mask = "00/00/0000"
        Me.AvisarDiaMaskedTextBox.Name = "AvisarDiaMaskedTextBox"
        Me.AvisarDiaMaskedTextBox.Size = New System.Drawing.Size(65, 20)
        Me.AvisarDiaMaskedTextBox.TabIndex = 21
        Me.AvisarDiaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'LembreteCheckBox
        '
        Me.LembreteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpresasBindingSource, "Lembrete", True))
        Me.LembreteCheckBox.Location = New System.Drawing.Point(137, 65)
        Me.LembreteCheckBox.Name = "LembreteCheckBox"
        Me.LembreteCheckBox.Size = New System.Drawing.Size(73, 18)
        Me.LembreteCheckBox.TabIndex = 16
        Me.LembreteCheckBox.Text = "Lembrete"
        Me.LembreteCheckBox.UseVisualStyleBackColor = True
        '
        'PrioridadeCheckBox
        '
        Me.PrioridadeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpresasBindingSource, "Prioridade", True))
        Me.PrioridadeCheckBox.Location = New System.Drawing.Point(65, 65)
        Me.PrioridadeCheckBox.Name = "PrioridadeCheckBox"
        Me.PrioridadeCheckBox.Size = New System.Drawing.Size(76, 18)
        Me.PrioridadeCheckBox.TabIndex = 5
        Me.PrioridadeCheckBox.Text = "Prioridade"
        Me.PrioridadeCheckBox.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Location = New System.Drawing.Point(7, 172)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(69, 50)
        Me.Button24.TabIndex = 45
        Me.Button24.Text = "Portal do MEI"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Location = New System.Drawing.Point(7, 275)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(69, 23)
        Me.Button21.TabIndex = 44
        Me.Button21.Text = "RedeSim"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Location = New System.Drawing.Point(7, 228)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(69, 41)
        Me.Button20.TabIndex = 43
        Me.Button20.Text = "Junta Comercial"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'IETextBox
        '
        Me.IETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "IE", True))
        Me.IETextBox.Location = New System.Drawing.Point(451, 43)
        Me.IETextBox.Name = "IETextBox"
        Me.IETextBox.Size = New System.Drawing.Size(110, 20)
        Me.IETextBox.TabIndex = 3
        '
        'EmpInicioAtividadeMaskedTextBox
        '
        Me.EmpInicioAtividadeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EmpInicioAtividade", True))
        Me.EmpInicioAtividadeMaskedTextBox.Location = New System.Drawing.Point(559, 13)
        Me.EmpInicioAtividadeMaskedTextBox.Mask = "00/00/0000"
        Me.EmpInicioAtividadeMaskedTextBox.Name = "EmpInicioAtividadeMaskedTextBox"
        Me.EmpInicioAtividadeMaskedTextBox.Size = New System.Drawing.Size(69, 20)
        Me.EmpInicioAtividadeMaskedTextBox.TabIndex = 28
        Me.EmpInicioAtividadeMaskedTextBox.ValidatingType = GetType(Date)
        '
        'NaturezaJuridicaComboBox
        '
        Me.NaturezaJuridicaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NaturezaJuridicaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NaturezaJuridicaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NaturezaJuridica", True))
        Me.NaturezaJuridicaComboBox.DataSource = Me.NaturezajuridicaBindingSource
        Me.NaturezaJuridicaComboBox.DisplayMember = "Descricao"
        Me.NaturezaJuridicaComboBox.FormattingEnabled = True
        Me.NaturezaJuridicaComboBox.Location = New System.Drawing.Point(99, 121)
        Me.NaturezaJuridicaComboBox.Name = "NaturezaJuridicaComboBox"
        Me.NaturezaJuridicaComboBox.Size = New System.Drawing.Size(318, 21)
        Me.NaturezaJuridicaComboBox.TabIndex = 23
        '
        'NaturezajuridicaBindingSource
        '
        Me.NaturezajuridicaBindingSource.DataMember = "Naturezajuridica"
        Me.NaturezajuridicaBindingSource.DataSource = Me.PrinceDBDataSetBindingSource
        '
        'CNAEBindingSource
        '
        Me.CNAEBindingSource.DataMember = "CNAE"
        Me.CNAEBindingSource.DataSource = Me.PrinceDBDataSetBindingSource
        '
        'ProcessoComboBox
        '
        Me.ProcessoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Processo", True))
        Me.ProcessoComboBox.FormattingEnabled = True
        Me.ProcessoComboBox.Location = New System.Drawing.Point(65, 102)
        Me.ProcessoComboBox.Name = "ProcessoComboBox"
        Me.ProcessoComboBox.Size = New System.Drawing.Size(107, 21)
        Me.ProcessoComboBox.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(212, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 22)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnotacoesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NaturezajuridicaTableAdapter
        '
        Me.NaturezajuridicaTableAdapter.ClearBeforeFill = True
        '
        'CNAETableAdapter
        '
        Me.CNAETableAdapter.ClearBeforeFill = True
        '
        'EmpCriadoMaskedTextBox
        '
        Me.EmpCriadoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "EmpCriado", True))
        Me.EmpCriadoMaskedTextBox.Location = New System.Drawing.Point(65, 16)
        Me.EmpCriadoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.EmpCriadoMaskedTextBox.Name = "EmpCriadoMaskedTextBox"
        Me.EmpCriadoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmpCriadoMaskedTextBox.TabIndex = 19
        Me.EmpCriadoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(171, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 20)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Detalhes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(SituacaoCadastralLabel)
        Me.GroupBox2.Controls.Add(Me.SituacaoCadastralComboBox)
        Me.GroupBox2.Controls.Add(Me.LinkLabel18)
        Me.GroupBox2.Controls.Add(Me.NaturezaJuridicaComboBox)
        Me.GroupBox2.Controls.Add(Me.RazaoSocialLabel)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.Button43)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Button29)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(IELabel)
        Me.GroupBox2.Controls.Add(TipoDeEmpresaLabel)
        Me.GroupBox2.Controls.Add(Me.IETextBox)
        Me.GroupBox2.Controls.Add(Me.TipoDeEmpresaComboBox)
        Me.GroupBox2.Controls.Add(Me.PorteDaEmpresaComboBox)
        Me.GroupBox2.Controls.Add(RegimeFederalLabel)
        Me.GroupBox2.Controls.Add(Me.EmpInicioAtividadeMaskedTextBox)
        Me.GroupBox2.Controls.Add(EmpInicioAtividadeLabel)
        Me.GroupBox2.Controls.Add(Me.RegimeFederalComboBox)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(NaturezaJuridicaLabel)
        Me.GroupBox2.Controls.Add(NomeFantasiaLabel)
        Me.GroupBox2.Controls.Add(CNPJLabel)
        Me.GroupBox2.Controls.Add(Me.CNPJMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.NomeFantasiaTextBox)
        Me.GroupBox2.Controls.Add(Me.RazaoSocialTextBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 174)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'SituacaoCadastralComboBox
        '
        Me.SituacaoCadastralComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "SituacaoCadastral", True))
        Me.SituacaoCadastralComboBox.FormattingEnabled = True
        Me.SituacaoCadastralComboBox.Items.AddRange(New Object() {"ATIVO", "BAIXADA", "INAPTA"})
        Me.SituacaoCadastralComboBox.Location = New System.Drawing.Point(522, 95)
        Me.SituacaoCadastralComboBox.Name = "SituacaoCadastralComboBox"
        Me.SituacaoCadastralComboBox.Size = New System.Drawing.Size(106, 21)
        Me.SituacaoCadastralComboBox.TabIndex = 66
        '
        'LinkLabel18
        '
        Me.LinkLabel18.AutoSize = True
        Me.LinkLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel18.Location = New System.Drawing.Point(499, 134)
        Me.LinkLabel18.Name = "LinkLabel18"
        Me.LinkLabel18.Size = New System.Drawing.Size(128, 13)
        Me.LinkLabel18.TabIndex = 65
        Me.LinkLabel18.TabStop = True
        Me.LinkLabel18.Text = "Consulta Optante Simples"
        '
        'RazaoSocialLabel
        '
        Me.RazaoSocialLabel.AutoSize = True
        Me.RazaoSocialLabel.Location = New System.Drawing.Point(20, 72)
        Me.RazaoSocialLabel.Name = "RazaoSocialLabel"
        Me.RazaoSocialLabel.Size = New System.Drawing.Size(73, 13)
        Me.RazaoSocialLabel.TabIndex = 64
        Me.RazaoSocialLabel.Text = "Razao Social:"
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(0, 69)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 63
        Me.PictureBox6.TabStop = False
        '
        'Button43
        '
        Me.Button43.BackColor = System.Drawing.Color.Transparent
        Me.Button43.BackgroundImage = CType(resources.GetObject("Button43.BackgroundImage"), System.Drawing.Image)
        Me.Button43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button43.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button43.Location = New System.Drawing.Point(276, 41)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(46, 22)
        Me.Button43.TabIndex = 62
        Me.Button43.Text = "Copiar"
        Me.Button43.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Button29
        '
        Me.Button29.BackgroundImage = CType(resources.GetObject("Button29.BackgroundImage"), System.Drawing.Image)
        Me.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Location = New System.Drawing.Point(567, 41)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(61, 22)
        Me.Button29.TabIndex = 49
        Me.Button29.Text = "Consultar"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Porte"
        '
        'TipoDeEmpresaComboBox
        '
        Me.TipoDeEmpresaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "TipoDeEmpresa", True))
        Me.TipoDeEmpresaComboBox.FormattingEnabled = True
        Me.TipoDeEmpresaComboBox.Items.AddRange(New Object() {"Sociedade Empresária Limitada ( Ltda. )", "Empresa Individual de Responsabilidade Limitada ( Eireli )", "Empresa individual ( RE )", "Microempreendedor Indivual ( MEI )", "Sociedade Anônima (SA)", "Sociedade Simples", "Igreja", "Comunidade e Similares"})
        Me.TipoDeEmpresaComboBox.Location = New System.Drawing.Point(99, 13)
        Me.TipoDeEmpresaComboBox.Name = "TipoDeEmpresaComboBox"
        Me.TipoDeEmpresaComboBox.Size = New System.Drawing.Size(287, 21)
        Me.TipoDeEmpresaComboBox.TabIndex = 30
        '
        'PorteDaEmpresaComboBox
        '
        Me.PorteDaEmpresaComboBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PorteDaEmpresaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "PorteDaEmpresa", True))
        Me.PorteDaEmpresaComboBox.FormattingEnabled = True
        Me.PorteDaEmpresaComboBox.Items.AddRange(New Object() {"Microempresa", "Empresa de Pequeno Porte", "Demais", "Outros"})
        Me.PorteDaEmpresaComboBox.Location = New System.Drawing.Point(99, 148)
        Me.PorteDaEmpresaComboBox.Name = "PorteDaEmpresaComboBox"
        Me.PorteDaEmpresaComboBox.Size = New System.Drawing.Size(195, 21)
        Me.PorteDaEmpresaComboBox.TabIndex = 29
        '
        'RegimeFederalComboBox
        '
        Me.RegimeFederalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "RegimeFederal", True))
        Me.RegimeFederalComboBox.FormattingEnabled = True
        Me.RegimeFederalComboBox.Items.AddRange(New Object() {"Lucro Normal", "Lucro Presumido", "RET", "Simples Nacional", "Pendência"})
        Me.RegimeFederalComboBox.Location = New System.Drawing.Point(506, 149)
        Me.RegimeFederalComboBox.Name = "RegimeFederalComboBox"
        Me.RegimeFederalComboBox.Size = New System.Drawing.Size(121, 21)
        Me.RegimeFederalComboBox.TabIndex = 28
        '
        'SistemaExternoComboBox
        '
        Me.SistemaExternoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "SistemaExterno", True))
        Me.SistemaExternoComboBox.FormattingEnabled = True
        Me.SistemaExternoComboBox.Items.AddRange(New Object() {"Sim", "Não"})
        Me.SistemaExternoComboBox.Location = New System.Drawing.Point(566, 40)
        Me.SistemaExternoComboBox.Name = "SistemaExternoComboBox"
        Me.SistemaExternoComboBox.Size = New System.Drawing.Size(61, 21)
        Me.SistemaExternoComboBox.TabIndex = 65
        '
        'ButtoneMail
        '
        Me.ButtoneMail.BackgroundImage = CType(resources.GetObject("ButtoneMail.BackgroundImage"), System.Drawing.Image)
        Me.ButtoneMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtoneMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtoneMail.Location = New System.Drawing.Point(7, 97)
        Me.ButtoneMail.Name = "ButtoneMail"
        Me.ButtoneMail.Size = New System.Drawing.Size(69, 23)
        Me.ButtoneMail.TabIndex = 44
        Me.ButtoneMail.Text = "e-Mail"
        Me.ButtoneMail.UseVisualStyleBackColor = True
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(241, 106)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(56, 13)
        Me.LinkLabel9.TabIndex = 34
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Atenção!!!"
        '
        'NAlteracaoLabel
        '
        Me.NAlteracaoLabel.AutoSize = True
        Me.NAlteracaoLabel.Location = New System.Drawing.Point(175, 105)
        Me.NAlteracaoLabel.Name = "NAlteracaoLabel"
        Me.NAlteracaoLabel.Size = New System.Drawing.Size(25, 13)
        Me.NAlteracaoLabel.TabIndex = 22
        Me.NAlteracaoLabel.Text = "Nº.:"
        '
        'NAlteracaoComboBox
        '
        Me.NAlteracaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "NAlteracao", True))
        Me.NAlteracaoComboBox.FormattingEnabled = True
        Me.NAlteracaoComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "+21"})
        Me.NAlteracaoComboBox.Location = New System.Drawing.Point(201, 102)
        Me.NAlteracaoComboBox.Name = "NAlteracaoComboBox"
        Me.NAlteracaoComboBox.Size = New System.Drawing.Size(34, 21)
        Me.NAlteracaoComboBox.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(6, 19)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(69, 22)
        Me.BtnNovo.TabIndex = 22
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = CType(resources.GetObject("BtnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(6, 117)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(69, 23)
        Me.BtnExcluir.TabIndex = 23
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 47)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 23)
        Me.BtnSalvar.TabIndex = 24
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Location = New System.Drawing.Point(6, 146)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 23)
        Me.BtnFechar.TabIndex = 25
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnContador
        '
        Me.BtnContador.BackgroundImage = CType(resources.GetObject("BtnContador.BackgroundImage"), System.Drawing.Image)
        Me.BtnContador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnContador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContador.Location = New System.Drawing.Point(7, 126)
        Me.BtnContador.Name = "BtnContador"
        Me.BtnContador.Size = New System.Drawing.Size(69, 23)
        Me.BtnContador.TabIndex = 57
        Me.BtnContador.Text = "Contador"
        Me.BtnContador.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(7, 76)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(69, 23)
        Me.BtnEditar.TabIndex = 50
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Location = New System.Drawing.Point(7, 398)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(69, 23)
        Me.Button28.TabIndex = 48
        Me.Button28.Text = "Prefeitura"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'BtnAlteracao
        '
        Me.BtnAlteracao.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnAlteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlteracao.Location = New System.Drawing.Point(7, 19)
        Me.BtnAlteracao.Name = "BtnAlteracao"
        Me.BtnAlteracao.Size = New System.Drawing.Size(69, 39)
        Me.BtnAlteracao.TabIndex = 49
        Me.BtnAlteracao.Text = "Nova Alteração"
        Me.BtnAlteracao.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Location = New System.Drawing.Point(7, 304)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(69, 41)
        Me.Button27.TabIndex = 47
        Me.Button27.Text = "Receita Estadual"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Location = New System.Drawing.Point(7, 351)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(69, 41)
        Me.Button26.TabIndex = 46
        Me.Button26.Text = "Simples Nacional"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'ComboBoxBuscaEmpresa
        '
        Me.ComboBoxBuscaEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscaEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscaEmpresa.DataSource = Me.EmpresasBindingSource
        Me.ComboBoxBuscaEmpresa.DisplayMember = "RazaoSocial"
        Me.ComboBoxBuscaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBuscaEmpresa.FormattingEnabled = True
        Me.ComboBoxBuscaEmpresa.Location = New System.Drawing.Point(237, 2)
        Me.ComboBoxBuscaEmpresa.Name = "ComboBoxBuscaEmpresa"
        Me.ComboBoxBuscaEmpresa.Size = New System.Drawing.Size(220, 21)
        Me.ComboBoxBuscaEmpresa.TabIndex = 30
        Me.ComboBoxBuscaEmpresa.ValueMember = "RazaoSocial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Empresa:"
        '
        'GroupBox10
        '
        Me.GroupBox10.AutoSize = True
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.StatusComboBox)
        Me.GroupBox10.Controls.Add(Me.NovaRazaoSocialComboBox)
        Me.GroupBox10.Controls.Add(Me.NovaRazaoSocialLabel)
        Me.GroupBox10.Controls.Add(Me.PictureBoxSistemaExterno)
        Me.GroupBox10.Controls.Add(Me.BtnData1)
        Me.GroupBox10.Controls.Add(Me.SistemaExternoComboBox)
        Me.GroupBox10.Controls.Add(Me.LabelConsolidar)
        Me.GroupBox10.Controls.Add(Me.AltConsolidadaComboBox)
        Me.GroupBox10.Controls.Add(Me.BtnVerEventos)
        Me.GroupBox10.Controls.Add(Me.PictureBox2)
        Me.GroupBox10.Controls.Add(Me.AvisarDiaMaskedTextBox)
        Me.GroupBox10.Controls.Add(Me.LembreteCheckBox)
        Me.GroupBox10.Controls.Add(AvisarDiaLabel)
        Me.GroupBox10.Controls.Add(Me.LinkLabel9)
        Me.GroupBox10.Controls.Add(Me.PrioridadeCheckBox)
        Me.GroupBox10.Controls.Add(StatusLabel)
        Me.GroupBox10.Controls.Add(Me.Button5)
        Me.GroupBox10.Controls.Add(Me.NAlteracaoLabel)
        Me.GroupBox10.Controls.Add(Me.EmpCriadoMaskedTextBox)
        Me.GroupBox10.Controls.Add(Me.NAlteracaoComboBox)
        Me.GroupBox10.Controls.Add(EmpCriadoLabel)
        Me.GroupBox10.Controls.Add(ProcessoLabel)
        Me.GroupBox10.Controls.Add(Me.ProcessoComboBox)
        Me.GroupBox10.Controls.Add(Me.TabControle)
        Me.GroupBox10.Controls.Add(Me.SistemaExternoLabel)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Location = New System.Drawing.Point(3, 259)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(663, 433)
        Me.GroupBox10.TabIndex = 37
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Procedimentos"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Status", True))
        Me.StatusComboBox.DropDownHeight = 200
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.IntegralHeight = False
        Me.StatusComboBox.Location = New System.Drawing.Point(379, 13)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(248, 21)
        Me.StatusComboBox.TabIndex = 71
        '
        'NovaRazaoSocialLabel
        '
        Me.NovaRazaoSocialLabel.AutoSize = True
        Me.NovaRazaoSocialLabel.Location = New System.Drawing.Point(132, 132)
        Me.NovaRazaoSocialLabel.Name = "NovaRazaoSocialLabel"
        Me.NovaRazaoSocialLabel.Size = New System.Drawing.Size(139, 13)
        Me.NovaRazaoSocialLabel.TabIndex = 67
        Me.NovaRazaoSocialLabel.Text = "Alteração de Razão Social :"
        '
        'PictureBoxSistemaExterno
        '
        Me.PictureBoxSistemaExterno.Location = New System.Drawing.Point(379, 40)
        Me.PictureBoxSistemaExterno.Name = "PictureBoxSistemaExterno"
        Me.PictureBoxSistemaExterno.Size = New System.Drawing.Size(24, 19)
        Me.PictureBoxSistemaExterno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSistemaExterno.TabIndex = 66
        Me.PictureBoxSistemaExterno.TabStop = False
        '
        'BtnData1
        '
        Me.BtnData1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnData1.Location = New System.Drawing.Point(136, 39)
        Me.BtnData1.Name = "BtnData1"
        Me.BtnData1.Size = New System.Drawing.Size(43, 21)
        Me.BtnData1.TabIndex = 43
        Me.BtnData1.Text = "Agora"
        Me.BtnData1.UseVisualStyleBackColor = True
        '
        'LabelConsolidar
        '
        Me.LabelConsolidar.AutoSize = True
        Me.LabelConsolidar.Location = New System.Drawing.Point(5, 132)
        Me.LabelConsolidar.Name = "LabelConsolidar"
        Me.LabelConsolidar.Size = New System.Drawing.Size(59, 13)
        Me.LabelConsolidar.TabIndex = 42
        Me.LabelConsolidar.Text = "Consolidar:"
        '
        'AltConsolidadaComboBox
        '
        Me.AltConsolidadaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "AltConsolidada", True))
        Me.AltConsolidadaComboBox.FormattingEnabled = True
        Me.AltConsolidadaComboBox.Items.AddRange(New Object() {"Não", "Sim"})
        Me.AltConsolidadaComboBox.Location = New System.Drawing.Point(65, 129)
        Me.AltConsolidadaComboBox.Name = "AltConsolidadaComboBox"
        Me.AltConsolidadaComboBox.Size = New System.Drawing.Size(61, 21)
        Me.AltConsolidadaComboBox.TabIndex = 41
        '
        'BtnVerEventos
        '
        Me.BtnVerEventos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVerEventos.Location = New System.Drawing.Point(234, 16)
        Me.BtnVerEventos.Name = "BtnVerEventos"
        Me.BtnVerEventos.Size = New System.Drawing.Size(60, 20)
        Me.BtnVerEventos.TabIndex = 40
        Me.BtnVerEventos.Text = "Motivo"
        Me.BtnVerEventos.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(481, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'SistemaExternoLabel
        '
        Me.SistemaExternoLabel.AutoSize = True
        Me.SistemaExternoLabel.Location = New System.Drawing.Point(409, 43)
        Me.SistemaExternoLabel.Name = "SistemaExternoLabel"
        Me.SistemaExternoLabel.Size = New System.Drawing.Size(159, 13)
        Me.SistemaExternoLabel.TabIndex = 68
        Me.SistemaExternoLabel.Text = "Atualização no Sistema Externo:"
        '
        'BtnWord
        '
        Me.BtnWord.BackgroundImage = CType(resources.GetObject("BtnWord.BackgroundImage"), System.Drawing.Image)
        Me.BtnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWord.Location = New System.Drawing.Point(7, 68)
        Me.BtnWord.Name = "BtnWord"
        Me.BtnWord.Size = New System.Drawing.Size(69, 23)
        Me.BtnWord.TabIndex = 72
        Me.BtnWord.Text = "WORD"
        Me.BtnWord.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "CPF/CNPJ:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = Global.PrinceSistemas.My.Resources.Resources.Fundo
        Me.PictureBox5.Location = New System.Drawing.Point(3, 235)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(663, 18)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 44
        Me.PictureBox5.TabStop = False
        '
        'BtnLocalizar
        '
        Me.BtnLocalizar.BackgroundImage = CType(resources.GetObject("BtnLocalizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLocalizar.Location = New System.Drawing.Point(678, 0)
        Me.BtnLocalizar.Name = "BtnLocalizar"
        Me.BtnLocalizar.Size = New System.Drawing.Size(69, 23)
        Me.BtnLocalizar.TabIndex = 45
        Me.BtnLocalizar.Text = "Localizar"
        Me.BtnLocalizar.UseVisualStyleBackColor = True
        '
        'CADstatusTableAdapter
        '
        Me.CADstatusTableAdapter.ClearBeforeFill = True
        '
        'LaudosTableAdapter
        '
        Me.LaudosTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.38476!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.61524!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenuCima, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxMenuBaixo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5641!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.4359!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 438.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 695)
        Me.TableLayoutPanel1.TabIndex = 46
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox7, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(672, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(82, 46)
        Me.TableLayoutPanel3.TabIndex = 48
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox7.Image = Global.PrinceSistemas.My.Resources.Resources.Fundo
        Me.PictureBox7.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(76, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 45
        Me.PictureBox7.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.PrinceSistemas.My.Resources.Resources.Fundo
        Me.PictureBox4.Location = New System.Drawing.Point(672, 235)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(82, 18)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        '
        'GroupBoxMenuCima
        '
        Me.GroupBoxMenuCima.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBoxMenuCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxMenuCima.Controls.Add(Me.BtnNovo)
        Me.GroupBoxMenuCima.Controls.Add(Me.BtnEditar)
        Me.GroupBoxMenuCima.Controls.Add(Me.BtnExcluir)
        Me.GroupBoxMenuCima.Controls.Add(Me.BtnSalvar)
        Me.GroupBoxMenuCima.Controls.Add(Me.BtnFechar)
        Me.GroupBoxMenuCima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMenuCima.Location = New System.Drawing.Point(672, 55)
        Me.GroupBoxMenuCima.Name = "GroupBoxMenuCima"
        Me.GroupBoxMenuCima.Size = New System.Drawing.Size(82, 174)
        Me.GroupBoxMenuCima.TabIndex = 24
        Me.GroupBoxMenuCima.TabStop = False
        Me.GroupBoxMenuCima.Text = "MENU"
        '
        'GroupBoxMenuBaixo
        '
        Me.GroupBoxMenuBaixo.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBoxMenuBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxMenuBaixo.Controls.Add(Me.BtnWord)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.BtnContador)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.BtnAlteracao)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.Button24)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.Button26)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.Button28)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.Button21)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.ButtoneMail)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.Button27)
        Me.GroupBoxMenuBaixo.Controls.Add(Me.Button20)
        Me.GroupBoxMenuBaixo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMenuBaixo.Location = New System.Drawing.Point(672, 259)
        Me.GroupBoxMenuBaixo.Name = "GroupBoxMenuBaixo"
        Me.GroupBoxMenuBaixo.Size = New System.Drawing.Size(82, 433)
        Me.GroupBoxMenuBaixo.TabIndex = 25
        Me.GroupBoxMenuBaixo.TabStop = False
        Me.GroupBoxMenuBaixo.Text = "Atalhos"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.02715!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.97285!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox8, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(663, 46)
        Me.TableLayoutPanel2.TabIndex = 47
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox8.Image = Global.PrinceSistemas.My.Resources.Resources.Empresas
        Me.PictureBox8.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(87, 40)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 44
        Me.PictureBox8.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.PrinceSistemas.My.Resources.Resources.Fundo
        Me.PictureBox3.Location = New System.Drawing.Point(96, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(564, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'ComboBoxBuscaCNPJ
        '
        Me.ComboBoxBuscaCNPJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscaCNPJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscaCNPJ.DataSource = Me.EmpresasBindingSource
        Me.ComboBoxBuscaCNPJ.DisplayMember = "CNPJ"
        Me.ComboBoxBuscaCNPJ.FormattingEnabled = True
        Me.ComboBoxBuscaCNPJ.Location = New System.Drawing.Point(532, 1)
        Me.ComboBoxBuscaCNPJ.Name = "ComboBoxBuscaCNPJ"
        Me.ComboBoxBuscaCNPJ.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxBuscaCNPJ.TabIndex = 47
        Me.ComboBoxBuscaCNPJ.ValueMember = "CNPJ"
        '
        'FrmLegalizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 718)
        Me.Controls.Add(Me.ComboBoxBuscaCNPJ)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnLocalizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxBuscaEmpresa)
        Me.Controls.Add(Me.EmpresasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmLegalizacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle geral de Legalização de Empresas"
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasBindingNavigator.ResumeLayout(False)
        Me.EmpresasBindingNavigator.PerformLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControle.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.TabPage19.ResumeLayout(False)
        Me.TabPage19.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage14.PerformLayout()
        Me.TabPage15.ResumeLayout(False)
        Me.TabPage15.PerformLayout()
        Me.TabPage16.ResumeLayout(False)
        Me.TabPage16.PerformLayout()
        Me.TabPage18.ResumeLayout(False)
        Me.TabPage18.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage20.ResumeLayout(False)
        Me.TabPage20.PerformLayout()
        CType(Me.AnexoBoxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage17.ResumeLayout(False)
        Me.TabPage17.PerformLayout()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaturezajuridicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CNAEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.PictureBoxSistemaExterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMenuCima.ResumeLayout(False)
        Me.GroupBoxMenuBaixo.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As PrinceDBDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RazaoSocialTextBox As TextBox
    Friend WithEvents NomeFantasiaTextBox As TextBox
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents TabControle As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ProtocoloJuntaComercialTextBox As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ProcessoComboBox As ComboBox
    Friend WithEvents BtnConsultaJunta As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GeralRichTextBox As RichTextBox
    Friend WithEvents EndEstadoTextBox As TextBox
    Friend WithEvents EndCEPMaskedTextBox As MaskedTextBox
    Friend WithEvents EndNumeroTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PaginaWebTextBox As TextBox
    Friend WithEvents EmpEmailTextBox As TextBox
    Friend WithEvents EmpTel2TextBox As TextBox
    Friend WithEvents EmpTel1TextBox As TextBox
    Friend WithEvents PrinceDBDataSetBindingSource As BindingSource
    Friend WithEvents NaturezajuridicaBindingSource As BindingSource
    Friend WithEvents NaturezajuridicaTableAdapter As PrinceDBDataSetTableAdapters.NaturezajuridicaTableAdapter
    Friend WithEvents CNAETableAdapter As PrinceDBDataSetTableAdapters.CNAETableAdapter
    Friend WithEvents LembreteCheckBox As CheckBox
    Friend WithEvents ProtocoloREDESIMTextBox As TextBox
    Friend WithEvents IETextBox As TextBox
    Friend WithEvents CNAEBindingSource As BindingSource
    Friend WithEvents EmpCriadoMaskedTextBox As MaskedTextBox
    Friend WithEvents DataProtJuntaComercialMaskedTextBox As MaskedTextBox
    Friend WithEvents DataProtREDESIMMaskedTextBox As MaskedTextBox
    Friend WithEvents DataPedidoIEMaskedTextBox As MaskedTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents NireDataMaskedTextBox As MaskedTextBox
    Friend WithEvents NIRETextBox As TextBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents RamoDeAtividadeRichTextBox As RichTextBox
    Friend WithEvents EmpInicioAtividadeMaskedTextBox As MaskedTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents NaturezaJuridicaComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CNAESecundarioRichTextBox As RichTextBox
    Friend WithEvents CNAEPrincipalTextBox As TextBox
    Friend WithEvents AvisarDiaMaskedTextBox As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnConsultaRedeSim As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NRegistroAltTextBox As TextBox
    Friend WithEvents DataRegistroAltMaskedTextBox As MaskedTextBox
    Friend WithEvents JuntaObsRichTextBox As RichTextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RedeSimObsRichTextBox As RichTextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents EstadualObsRichTextBox As RichTextBox
    Friend WithEvents PrefeituraObsRichTextBox As RichTextBox
    Friend WithEvents NAlteracaoComboBox As ComboBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Button8 As Button
    Friend WithEvents PrazoSimplesMaskedTextBox As MaskedTextBox
    Friend WithEvents txtDataASomar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CodigoSimplesTextBox As TextBox
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents ArquivoContratoTextBox As TextBox
    Friend WithEvents Button15 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ProcedimentoRichTextBox As RichTextBox
    Friend WithEvents PrioridadeCheckBox As CheckBox
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents NAlteracaoLabel As Label
    Friend WithEvents Button22 As Button
    Friend WithEvents RegimeFederalComboBox As ComboBox
    Friend WithEvents PorteDaEmpresaComboBox As ComboBox
    Friend WithEvents TipoDeEmpresaComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxBuscaEmpresa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents CPFResponsavelMaskedTextBox As MaskedTextBox
    Friend WithEvents NomeResponsavelTextBox As TextBox
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button24 As Button
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents IEInicioAtividadeMaskedTextBox As MaskedTextBox
    Friend WithEvents IEComprovanteTextBox As TextBox
    Friend WithEvents Button23 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents IEVencPedidoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents IEjuntaComboBox As ComboBox
    Friend WithEvents ProtocoloREDESIMLabel As Label
    Friend WithEvents DataProtREDESIMLabel As Label
    Friend WithEvents BombeiroJuntaComboBox As ComboBox
    Friend WithEvents ProtJuntaFinalMaskedTextBox As MaskedTextBox
    Friend WithEvents Button30 As Button
    Friend WithEvents TituloeleitorTextBox As TextBox
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button36 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents ObsSimplesRichTextBox As RichTextBox
    Friend WithEvents Area2TextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents DataSimplesMaskedTextBox As MaskedTextBox
    Friend WithEvents Button37 As Button
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents OrgãoPedSimplesComboBox As ComboBox
    Friend WithEvents DataUltdefSimplesMaskedTextBox As MaskedTextBox
    Friend WithEvents PastaDocumentosTextBox As TextBox
    Friend WithEvents Button31 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents RespRGTextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents HistoricoRichTextBox As RichTextBox
    Friend WithEvents BtnAlteracao As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button39 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AltProtComboBox As ComboBox
    Friend WithEvents Button41 As Button
    Friend WithEvents Button40 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtoneMail As Button
    Friend WithEvents TabPage16 As TabPage
    Friend WithEvents DataExcSocialMaskedTextBox As MaskedTextBox
    Friend WithEvents CapitalITextBox As TextBox
    Friend WithEvents CapitalSTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CNHdataexpMaskedTextBox As MaskedTextBox
    Friend WithEvents CNHexpTextBox As TextBox
    Friend WithEvents CNHnumeroTextBox As TextBox
    Friend WithEvents RespDataNascMaskedTextBox As MaskedTextBox
    Friend WithEvents RespMaeTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button43 As Button
    Friend WithEvents CadImobTextBox As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents LinkLabel13 As LinkLabel
    Friend WithEvents LinkLabel14 As LinkLabel
    Friend WithEvents LinkLabel15 As LinkLabel
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents EndZonaTextBox As TextBox
    Friend WithEvents EndDataTextBox As TextBox
    Friend WithEvents EndQuadraTextBox As TextBox
    Friend WithEvents Button44 As Button
    Friend WithEvents TabPage17 As TabPage
    Friend WithEvents Button45 As Button
    Friend WithEvents RespRgSiglaTextBox As TextBox
    Friend WithEvents ProcuracaoDataMaskedTextBox As MaskedTextBox
    Friend WithEvents ProcuracaoNMaskedTextBox As MaskedTextBox
    Friend WithEvents ProcuracaoComboBox As ComboBox
    Friend WithEvents LinkLabel16 As LinkLabel
    Friend WithEvents TabPage18 As TabPage
    Friend WithEvents NovaRazaoSocialComboBox As ComboBox
    Friend WithEvents NovaRazaoSocial3TextBox As TextBox
    Friend WithEvents NovaRazaoSocial2TextBox As TextBox
    Friend WithEvents NovaRazaoSocial1TextBox As TextBox
    Friend WithEvents BtnVerEventos As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BtnListaEventos As Button
    Friend WithEvents Button46 As Button
    Friend WithEvents Button48 As Button
    Friend WithEvents Button47 As Button
    Friend WithEvents MotivoRichTextBox As RichTextBox
    Friend WithEvents MotivoLabel As Label
    Friend WithEvents NomeFantasiaTextBox1 As TextBox
    Friend WithEvents SenhaGovTextBox As TextBox
    Friend WithEvents SenhaGovLabel As Label
    Friend WithEvents RespPaiTextBox As TextBox
    Friend WithEvents BtnCopiarSenhaGov As Button
    Friend WithEvents AltConsolidadaComboBox As ComboBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents LabelConsolidar As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RazaoSocialLabel As Label
    Friend WithEvents NovaRazaoSocialFinalTextBox As TextBox
    Friend WithEvents LabelNovaRazaoFinal As Label
    Friend WithEvents LinkLabelMudarRazaoSocial As LinkLabel
    Friend WithEvents IEOnlineComboBox As ComboBox
    Friend WithEvents IEeProcNumTextBox As TextBox
    Friend WithEvents IETipoComboBox As ComboBox
    Friend WithEvents DatadeInicioIE As Label
    Friend WithEvents CnaeSimples As Button
    Friend WithEvents SistemaExternoComboBox As ComboBox
    Friend WithEvents BtnData1 As Button
    Friend WithEvents BtnData2 As Button
    Friend WithEvents BtnData3 As Button
    Friend WithEvents BtnData4 As Button
    Friend WithEvents BtnConsultaeProcessoEstado As Button
    Friend WithEvents LinkLabel17 As LinkLabel
    Friend WithEvents PictureBoxSistemaExterno As PictureBox
    Friend WithEvents NovaRazaoSocialLabel As Label
    Friend WithEvents TabPage19 As TabPage
    Friend WithEvents DadosSociosRichTextBox As RichTextBox
    Friend WithEvents BtnAdicionarSocio As Button
    Friend WithEvents QuantidadeSociosTextBox As TextBox
    Friend WithEvents LblQuantidadeSocios As Label
    Friend WithEvents BtnLimparSocio As Button
    Friend WithEvents BtnLimparSocios As Button
    Friend WithEvents BtnCopiaDataDeNasc As Button
    Friend WithEvents SistemaExternoLabel As Label
    Friend WithEvents LinkLabel18 As LinkLabel
    Friend WithEvents BtnLocalizar As Button
    Friend WithEvents BtnContador As Button
    Friend WithEvents CADstatusBindingSource As BindingSource
    Friend WithEvents CADstatusTableAdapter As PrinceDBDataSetTableAdapters.CADstatusTableAdapter
    Friend WithEvents BtnAnotacoesLEgalizacao As Button
    Friend WithEvents BtnAnotacoesFederal As Button
    Friend WithEvents BtnAnotacoesEstadual As Button
    Friend WithEvents BtnAnotacoesPrefeitura As Button
    Friend WithEvents BtnAnotacoesDemais As Button
    Friend WithEvents BtnAnotacoesSimples As Button
    Friend WithEvents TabPage20 As TabPage
    Friend WithEvents BtnSalvarDoc As Button
    Friend WithEvents BtnAbrirDoc As Button
    Friend WithEvents BtnApagaAnexo As Button
    Friend WithEvents DocContratosLinkLabel As LinkLabel
    Friend WithEvents AnexoBoxPicture As PictureBox
    Friend WithEvents BtnArrumar As Button
    Friend WithEvents BtnImportarAnexo As Button
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents ButtonCalcCapSocial As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents GroupBoxMenuCima As GroupBox
    Friend WithEvents GroupBoxMenuBaixo As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBoxBuscaCNPJ As ComboBox
    Friend WithEvents RazaoSocialAntigaLabel As Label
    Friend WithEvents BtnImportarRazaoSocial As Button
    Friend WithEvents RazaoSocialAntigaTextBox As TextBox
    Friend WithEvents BtnUsarNomeFantasia As Button
    Friend WithEvents BtnUsarRazao3 As Button
    Friend WithEvents BtnUsarRazao2 As Button
    Friend WithEvents BtnUsarRazao1 As Button
    Friend WithEvents BtnImportarSocioAdm As Button
    Friend WithEvents EndComplementoTextBox As TextBox
    Friend WithEvents EndBairroTextBox As TextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents EndPaisTextBox As TextBox
    Friend WithEvents EndCidadeTextBox As TextBox
    Friend WithEvents BtnAddmaisSocio As Button
    Friend WithEvents SituacaoCadastralComboBox As ComboBox
    Friend WithEvents BtnWord As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DivisaoCapitalSociosRichTextBox As RichTextBox
End Class
